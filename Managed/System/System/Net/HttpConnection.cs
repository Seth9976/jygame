using System;
using System.IO;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Mono.Security.Protocol.Tls;

namespace System.Net
{
	// Token: 0x02000327 RID: 807
	internal sealed class HttpConnection
	{
		// Token: 0x06001BB9 RID: 7097 RVA: 0x00053118 File Offset: 0x00051318
		public HttpConnection(global::System.Net.Sockets.Socket sock, EndPointListener epl, bool secure, global::System.Security.Cryptography.X509Certificates.X509Certificate2 cert, AsymmetricAlgorithm key)
		{
			this.sock = sock;
			this.epl = epl;
			this.secure = secure;
			this.key = key;
			if (!secure)
			{
				this.stream = new global::System.Net.Sockets.NetworkStream(sock, false);
			}
			else
			{
				SslServerStream sslServerStream = new SslServerStream(new global::System.Net.Sockets.NetworkStream(sock, false), cert, false, false);
				SslServerStream sslServerStream2 = sslServerStream;
				sslServerStream2.PrivateKeyCertSelectionDelegate = (PrivateKeySelectionCallback)Delegate.Combine(sslServerStream2.PrivateKeyCertSelectionDelegate, new PrivateKeySelectionCallback(this.OnPVKSelection));
				this.stream = sslServerStream;
			}
			this.Init();
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x0001418F File Offset: 0x0001238F
		private AsymmetricAlgorithm OnPVKSelection(X509Certificate certificate, string targetHost)
		{
			return this.key;
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x000531A0 File Offset: 0x000513A0
		private void Init()
		{
			this.context_bound = false;
			this.i_stream = null;
			this.o_stream = null;
			this.prefix = null;
			this.chunked = false;
			this.ms = new MemoryStream();
			this.position = 0;
			this.input_state = HttpConnection.InputState.RequestLine;
			this.line_state = HttpConnection.LineState.None;
			this.context = new HttpListenerContext(this);
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x00014197 File Offset: 0x00012397
		public int ChunkedUses
		{
			get
			{
				return this.chunked_uses;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x0001419F File Offset: 0x0001239F
		public IPEndPoint LocalEndPoint
		{
			get
			{
				return (IPEndPoint)this.sock.LocalEndPoint;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001BBE RID: 7102 RVA: 0x000141B1 File Offset: 0x000123B1
		public IPEndPoint RemoteEndPoint
		{
			get
			{
				return (IPEndPoint)this.sock.RemoteEndPoint;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x000141C3 File Offset: 0x000123C3
		public bool IsSecure
		{
			get
			{
				return this.secure;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x000141CB File Offset: 0x000123CB
		// (set) Token: 0x06001BC1 RID: 7105 RVA: 0x000141D3 File Offset: 0x000123D3
		public ListenerPrefix Prefix
		{
			get
			{
				return this.prefix;
			}
			set
			{
				this.prefix = value;
			}
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x000531FC File Offset: 0x000513FC
		public void BeginReadRequest()
		{
			if (this.buffer == null)
			{
				this.buffer = new byte[8192];
			}
			try
			{
				this.stream.BeginRead(this.buffer, 0, 8192, new AsyncCallback(this.OnRead), this);
			}
			catch
			{
				this.CloseSocket();
			}
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x0005326C File Offset: 0x0005146C
		public RequestStream GetRequestStream(bool chunked, long contentlength)
		{
			if (this.i_stream == null)
			{
				byte[] array = this.ms.GetBuffer();
				int num = (int)this.ms.Length;
				this.ms = null;
				if (chunked)
				{
					this.chunked = true;
					this.context.Response.SendChunked = true;
					this.i_stream = new ChunkedInputStream(this.context, this.stream, array, this.position, num - this.position);
				}
				else
				{
					this.i_stream = new RequestStream(this.stream, array, this.position, num - this.position, contentlength);
				}
			}
			return this.i_stream;
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x00053314 File Offset: 0x00051514
		public ResponseStream GetResponseStream()
		{
			if (this.o_stream == null)
			{
				HttpListener listener = this.context.Listener;
				bool flag = listener == null || listener.IgnoreWriteExceptions;
				this.o_stream = new ResponseStream(this.stream, this.context.Response, flag);
			}
			return this.o_stream;
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x00053370 File Offset: 0x00051570
		private void OnRead(IAsyncResult ares)
		{
			HttpConnection httpConnection = (HttpConnection)ares.AsyncState;
			int num = -1;
			try
			{
				num = this.stream.EndRead(ares);
				this.ms.Write(this.buffer, 0, num);
				if (this.ms.Length > 32768L)
				{
					this.SendError("Bad request", 400);
					this.Close(true);
					return;
				}
			}
			catch
			{
				if (this.ms != null && this.ms.Length > 0L)
				{
					this.SendError();
				}
				if (this.sock != null)
				{
					this.CloseSocket();
				}
				return;
			}
			if (num == 0)
			{
				this.CloseSocket();
				return;
			}
			if (this.ProcessInput(this.ms))
			{
				if (!this.context.HaveError)
				{
					this.context.Request.FinishInitialization();
				}
				if (this.context.HaveError)
				{
					this.SendError();
					this.Close(true);
					return;
				}
				if (!this.epl.BindContext(this.context))
				{
					this.SendError("Invalid host", 400);
					this.Close(true);
				}
				this.context_bound = true;
				return;
			}
			else
			{
				this.stream.BeginRead(this.buffer, 0, 8192, new AsyncCallback(this.OnRead), httpConnection);
			}
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x000534E8 File Offset: 0x000516E8
		private bool ProcessInput(MemoryStream ms)
		{
			byte[] array = ms.GetBuffer();
			int num = (int)ms.Length;
			int num2 = 0;
			string text;
			try
			{
				text = this.ReadLine(array, this.position, num - this.position, ref num2);
				this.position += num2;
			}
			catch (Exception ex)
			{
				this.context.ErrorMessage = "Bad request";
				this.context.ErrorStatus = 400;
				return true;
			}
			while (text != null)
			{
				if (text == string.Empty)
				{
					if (this.input_state != HttpConnection.InputState.RequestLine)
					{
						this.current_line = null;
						ms = null;
						return true;
					}
				}
				else
				{
					if (this.input_state == HttpConnection.InputState.RequestLine)
					{
						this.context.Request.SetRequestLine(text);
						this.input_state = HttpConnection.InputState.Headers;
					}
					else
					{
						try
						{
							this.context.Request.AddHeader(text);
						}
						catch (Exception ex2)
						{
							this.context.ErrorMessage = ex2.Message;
							this.context.ErrorStatus = 400;
							return true;
						}
					}
					if (this.context.HaveError)
					{
						return true;
					}
					if (this.position >= num)
					{
						break;
					}
					try
					{
						text = this.ReadLine(array, this.position, num - this.position, ref num2);
						this.position += num2;
					}
					catch (Exception ex3)
					{
						this.context.ErrorMessage = "Bad request";
						this.context.ErrorStatus = 400;
						return true;
					}
				}
				if (text != null)
				{
					continue;
				}
				IL_0194:
				if (num2 == num)
				{
					ms.SetLength(0L);
					this.position = 0;
				}
				return false;
			}
			goto IL_0194;
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x000536CC File Offset: 0x000518CC
		private string ReadLine(byte[] buffer, int offset, int len, ref int used)
		{
			if (this.current_line == null)
			{
				this.current_line = new StringBuilder();
			}
			int num = offset + len;
			used = 0;
			int num2 = offset;
			while (num2 < num && this.line_state != HttpConnection.LineState.LF)
			{
				used++;
				byte b = buffer[num2];
				if (b == 13)
				{
					this.line_state = HttpConnection.LineState.CR;
				}
				else if (b == 10)
				{
					this.line_state = HttpConnection.LineState.LF;
				}
				else
				{
					this.current_line.Append((char)b);
				}
				num2++;
			}
			string text = null;
			if (this.line_state == HttpConnection.LineState.LF)
			{
				this.line_state = HttpConnection.LineState.None;
				text = this.current_line.ToString();
				this.current_line.Length = 0;
			}
			return text;
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x00053788 File Offset: 0x00051988
		public void SendError(string msg, int status)
		{
			try
			{
				HttpListenerResponse response = this.context.Response;
				response.StatusCode = status;
				response.ContentType = "text/html";
				string statusDescription = HttpListenerResponse.GetStatusDescription(status);
				string text;
				if (msg != null)
				{
					text = string.Format("<h1>{0} ({1})</h1>", statusDescription, msg);
				}
				else
				{
					text = string.Format("<h1>{0}</h1>", statusDescription);
				}
				byte[] bytes = this.context.Response.ContentEncoding.GetBytes(text);
				response.Close(bytes, false);
			}
			catch
			{
			}
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x000141DC File Offset: 0x000123DC
		public void SendError()
		{
			this.SendError(this.context.ErrorMessage, this.context.ErrorStatus);
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x000141FA File Offset: 0x000123FA
		private void Unbind()
		{
			if (this.context_bound)
			{
				this.epl.UnbindContext(this.context);
				this.context_bound = false;
			}
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0001421F File Offset: 0x0001241F
		public void Close()
		{
			this.Close(false);
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00053818 File Offset: 0x00051A18
		private void CloseSocket()
		{
			if (this.sock == null)
			{
				return;
			}
			try
			{
				this.sock.Close();
			}
			catch
			{
			}
			finally
			{
				this.sock = null;
			}
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x0005386C File Offset: 0x00051A6C
		internal void Close(bool force_close)
		{
			if (this.sock != null)
			{
				Stream responseStream = this.GetResponseStream();
				responseStream.Close();
				this.o_stream = null;
			}
			if (this.sock == null)
			{
				return;
			}
			force_close |= this.context.Request.Headers["connection"] == "close";
			if (!force_close)
			{
				int statusCode = this.context.Response.StatusCode;
				bool flag = statusCode == 400 || statusCode == 408 || statusCode == 411 || statusCode == 413 || statusCode == 414 || statusCode == 500 || statusCode == 503;
				force_close |= this.context.Request.ProtocolVersion <= HttpVersion.Version10;
			}
			if (force_close || !this.context.Request.FlushInput())
			{
				global::System.Net.Sockets.Socket socket = this.sock;
				this.sock = null;
				try
				{
					if (socket != null)
					{
						socket.Shutdown(global::System.Net.Sockets.SocketShutdown.Both);
					}
				}
				catch
				{
				}
				finally
				{
					if (socket != null)
					{
						socket.Close();
					}
				}
				this.Unbind();
				return;
			}
			if (this.chunked && !this.context.Response.ForceCloseChunked)
			{
				this.chunked_uses++;
				this.Unbind();
				this.Init();
				this.BeginReadRequest();
				return;
			}
			this.Unbind();
			this.Init();
			this.BeginReadRequest();
		}

		// Token: 0x040010FE RID: 4350
		private const int BufferSize = 8192;

		// Token: 0x040010FF RID: 4351
		private global::System.Net.Sockets.Socket sock;

		// Token: 0x04001100 RID: 4352
		private Stream stream;

		// Token: 0x04001101 RID: 4353
		private EndPointListener epl;

		// Token: 0x04001102 RID: 4354
		private MemoryStream ms;

		// Token: 0x04001103 RID: 4355
		private byte[] buffer;

		// Token: 0x04001104 RID: 4356
		private HttpListenerContext context;

		// Token: 0x04001105 RID: 4357
		private StringBuilder current_line;

		// Token: 0x04001106 RID: 4358
		private ListenerPrefix prefix;

		// Token: 0x04001107 RID: 4359
		private RequestStream i_stream;

		// Token: 0x04001108 RID: 4360
		private ResponseStream o_stream;

		// Token: 0x04001109 RID: 4361
		private bool chunked;

		// Token: 0x0400110A RID: 4362
		private int chunked_uses;

		// Token: 0x0400110B RID: 4363
		private bool context_bound;

		// Token: 0x0400110C RID: 4364
		private bool secure;

		// Token: 0x0400110D RID: 4365
		private AsymmetricAlgorithm key;

		// Token: 0x0400110E RID: 4366
		private HttpConnection.InputState input_state;

		// Token: 0x0400110F RID: 4367
		private HttpConnection.LineState line_state;

		// Token: 0x04001110 RID: 4368
		private int position;

		// Token: 0x02000328 RID: 808
		private enum InputState
		{
			// Token: 0x04001112 RID: 4370
			RequestLine,
			// Token: 0x04001113 RID: 4371
			Headers
		}

		// Token: 0x02000329 RID: 809
		private enum LineState
		{
			// Token: 0x04001115 RID: 4373
			None,
			// Token: 0x04001116 RID: 4374
			CR,
			// Token: 0x04001117 RID: 4375
			LF
		}
	}
}
