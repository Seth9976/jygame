using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Mono.Security.Protocol.Tls;

namespace System.Net
{
	// Token: 0x0200042E RID: 1070
	internal class WebConnection
	{
		// Token: 0x060025BC RID: 9660 RVA: 0x0006E34C File Offset: 0x0006C54C
		public WebConnection(WebConnectionGroup group, ServicePoint sPoint)
		{
			this.sPoint = sPoint;
			this.buffer = new byte[4096];
			this.readState = ReadState.None;
			this.Data = new WebConnectionData();
			this.initConn = new WaitCallback(this.InitConnection);
			this.queue = group.Queue;
			this.abortHelper = new WebConnection.AbortHelper();
			this.abortHelper.Connection = this;
			this.abortHandler = new EventHandler(this.abortHelper.Abort);
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x0001A917 File Offset: 0x00018B17
		private bool CanReuse()
		{
			return !this.socket.Poll(0, global::System.Net.Sockets.SelectMode.SelectRead);
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x0001A929 File Offset: 0x00018B29
		private void LoggedThrow(Exception e)
		{
			Console.WriteLine("Throwing this exception: " + e);
			throw e;
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x0006E3E0 File Offset: 0x0006C5E0
		internal static Stream DownloadPolicy(string url, string proxy)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			if (proxy != null)
			{
				httpWebRequest.Proxy = new WebProxy(proxy);
			}
			return httpWebRequest.GetResponse().GetResponseStream();
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x0006E418 File Offset: 0x0006C618
		private void CheckUnityWebSecurity(HttpWebRequest request)
		{
			if (!Environment.SocketSecurityEnabled)
			{
				return;
			}
			Console.WriteLine("CheckingSecurityForUrl: " + request.RequestUri.AbsoluteUri);
			global::System.Uri requestUri = request.RequestUri;
			string text = string.Empty;
			if (!requestUri.IsDefaultPort)
			{
				text = ":" + requestUri.Port;
			}
			if (requestUri.ToString() == string.Concat(new string[] { requestUri.Scheme, "://", requestUri.Host, text, "/crossdomain.xml" }))
			{
				return;
			}
			try
			{
				if (WebConnection.method_GetSecurityPolicyFromNonMainThread == null)
				{
					Type type = Type.GetType("UnityEngine.UnityCrossDomainHelper, CrossDomainPolicyParser, Version=1.0.0.0, Culture=neutral");
					if (type == null)
					{
						this.LoggedThrow(new SecurityException("Cant find type UnityCrossDomainHelper"));
					}
					WebConnection.method_GetSecurityPolicyFromNonMainThread = type.GetMethod("GetSecurityPolicyForDotNetWebRequest");
					if (WebConnection.method_GetSecurityPolicyFromNonMainThread == null)
					{
						this.LoggedThrow(new SecurityException("Cant find GetSecurityPolicyFromNonMainThread"));
					}
				}
				MethodInfo method = typeof(WebConnection).GetMethod("DownloadPolicy", BindingFlags.Static | BindingFlags.NonPublic);
				if (method == null)
				{
					this.LoggedThrow(new SecurityException("Cannot find method DownloadPolicy"));
				}
				if (!(bool)WebConnection.method_GetSecurityPolicyFromNonMainThread.Invoke(null, new object[]
				{
					request.RequestUri.ToString(),
					method
				}))
				{
					this.LoggedThrow(new SecurityException("Webrequest was denied"));
				}
			}
			catch (Exception ex)
			{
				this.LoggedThrow(new SecurityException("Unexpected error while trying to call method_GetSecurityPolicyBlocking : " + ex));
			}
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x0006E5B0 File Offset: 0x0006C7B0
		private void Connect(HttpWebRequest request)
		{
			object obj = this.socketLock;
			lock (obj)
			{
				if (this.socket != null && this.socket.Connected && this.status == WebExceptionStatus.Success && this.CanReuse() && this.CompleteChunkedRead())
				{
					this.reused = true;
				}
				else
				{
					this.reused = false;
					if (this.socket != null)
					{
						this.socket.Close();
						this.socket = null;
					}
					this.chunkStream = null;
					IPHostEntry hostEntry = this.sPoint.HostEntry;
					if (hostEntry == null)
					{
						this.status = ((!this.sPoint.UsesProxy) ? WebExceptionStatus.NameResolutionFailure : WebExceptionStatus.ProxyNameResolutionFailure);
					}
					else
					{
						WebConnectionData data = this.Data;
						foreach (IPAddress ipaddress in hostEntry.AddressList)
						{
							this.socket = new global::System.Net.Sockets.Socket(ipaddress.AddressFamily, global::System.Net.Sockets.SocketType.Stream, global::System.Net.Sockets.ProtocolType.Tcp);
							IPEndPoint ipendPoint = new IPEndPoint(ipaddress, this.sPoint.Address.Port);
							this.socket.SetSocketOption(global::System.Net.Sockets.SocketOptionLevel.Tcp, global::System.Net.Sockets.SocketOptionName.Debug, (!this.sPoint.UseNagleAlgorithm) ? 1 : 0);
							this.socket.NoDelay = !this.sPoint.UseNagleAlgorithm;
							if (!this.sPoint.CallEndPointDelegate(this.socket, ipendPoint))
							{
								this.socket.Close();
								this.socket = null;
								this.status = WebExceptionStatus.ConnectFailure;
							}
							else
							{
								try
								{
									if (request.Aborted)
									{
										break;
									}
									this.CheckUnityWebSecurity(request);
									this.socket.Connect(ipendPoint, false);
									this.status = WebExceptionStatus.Success;
									break;
								}
								catch (ThreadAbortException)
								{
									global::System.Net.Sockets.Socket socket = this.socket;
									this.socket = null;
									if (socket != null)
									{
										socket.Close();
									}
									break;
								}
								catch (ObjectDisposedException ex)
								{
									break;
								}
								catch (Exception ex2)
								{
									global::System.Net.Sockets.Socket socket2 = this.socket;
									this.socket = null;
									if (socket2 != null)
									{
										socket2.Close();
									}
									if (!request.Aborted)
									{
										this.status = WebExceptionStatus.ConnectFailure;
									}
									this.connect_exception = ex2;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x0006E858 File Offset: 0x0006CA58
		private static void EnsureSSLStreamAvailable()
		{
			object obj = WebConnection.classLock;
			lock (obj)
			{
				if (WebConnection.sslStream == null)
				{
					WebConnection.sslStream = Type.GetType("Mono.Security.Protocol.Tls.HttpsClientStream, Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756", false);
					if (WebConnection.sslStream == null)
					{
						string text = "Missing Mono.Security.dll assembly. Support for SSL/TLS is unavailable.";
						throw new NotSupportedException(text);
					}
					WebConnection.piClient = WebConnection.sslStream.GetProperty("SelectedClientCertificate");
					WebConnection.piServer = WebConnection.sslStream.GetProperty("ServerCertificate");
					WebConnection.piTrustFailure = WebConnection.sslStream.GetProperty("TrustFailure");
				}
			}
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x0006E900 File Offset: 0x0006CB00
		private bool CreateTunnel(HttpWebRequest request, Stream stream, out byte[] buffer)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CONNECT ");
			stringBuilder.Append(request.Address.Host);
			stringBuilder.Append(':');
			stringBuilder.Append(request.Address.Port);
			stringBuilder.Append(" HTTP/");
			if (request.ServicePoint.ProtocolVersion == HttpVersion.Version11)
			{
				stringBuilder.Append("1.1");
			}
			else
			{
				stringBuilder.Append("1.0");
			}
			stringBuilder.Append("\r\nHost: ");
			stringBuilder.Append(request.Address.Authority);
			string challenge = this.Data.Challenge;
			this.Data.Challenge = null;
			bool flag = request.Headers["Proxy-Authorization"] != null;
			if (flag)
			{
				stringBuilder.Append("\r\nProxy-Authorization: ");
				stringBuilder.Append(request.Headers["Proxy-Authorization"]);
			}
			else if (challenge != null && this.Data.StatusCode == 407)
			{
				flag = true;
				ICredentials credentials = request.Proxy.Credentials;
				Authorization authorization = AuthenticationManager.Authenticate(challenge, request, credentials);
				if (authorization != null)
				{
					stringBuilder.Append("\r\nProxy-Authorization: ");
					stringBuilder.Append(authorization.Message);
				}
			}
			stringBuilder.Append("\r\n\r\n");
			this.Data.StatusCode = 0;
			byte[] bytes = Encoding.Default.GetBytes(stringBuilder.ToString());
			stream.Write(bytes, 0, bytes.Length);
			int num;
			WebHeaderCollection webHeaderCollection = this.ReadHeaders(request, stream, out buffer, out num);
			if (!flag && webHeaderCollection != null && num == 407)
			{
				this.Data.StatusCode = num;
				this.Data.Challenge = webHeaderCollection["Proxy-Authenticate"];
				return false;
			}
			if (num != 200)
			{
				string text = string.Format("The remote server returned a {0} status code.", num);
				this.HandleError(WebExceptionStatus.SecureChannelFailure, null, text);
				return false;
			}
			return webHeaderCollection != null;
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x0006EB18 File Offset: 0x0006CD18
		private WebHeaderCollection ReadHeaders(HttpWebRequest request, Stream stream, out byte[] retBuffer, out int status)
		{
			retBuffer = null;
			status = 200;
			byte[] array = new byte[1024];
			MemoryStream memoryStream = new MemoryStream();
			bool flag = false;
			int num2;
			WebHeaderCollection webHeaderCollection;
			for (;;)
			{
				int num = stream.Read(array, 0, 1024);
				if (num == 0)
				{
					break;
				}
				memoryStream.Write(array, 0, num);
				num2 = 0;
				string text = null;
				webHeaderCollection = new WebHeaderCollection();
				while (WebConnection.ReadLine(memoryStream.GetBuffer(), ref num2, (int)memoryStream.Length, ref text))
				{
					if (text == null)
					{
						goto Block_2;
					}
					if (flag)
					{
						webHeaderCollection.Add(text);
					}
					else
					{
						int num3 = text.IndexOf(' ');
						if (num3 == -1)
						{
							goto Block_5;
						}
						status = (int)uint.Parse(text.Substring(num3 + 1, 3));
						flag = true;
					}
				}
			}
			this.HandleError(WebExceptionStatus.ServerProtocolViolation, null, "ReadHeaders");
			return null;
			Block_2:
			if (memoryStream.Length - (long)num2 > 0L)
			{
				retBuffer = new byte[memoryStream.Length - (long)num2];
				Buffer.BlockCopy(memoryStream.GetBuffer(), num2, retBuffer, 0, retBuffer.Length);
			}
			return webHeaderCollection;
			Block_5:
			this.HandleError(WebExceptionStatus.ServerProtocolViolation, null, "ReadHeaders2");
			return null;
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x0006EC34 File Offset: 0x0006CE34
		private bool CreateStream(HttpWebRequest request)
		{
			try
			{
				global::System.Net.Sockets.NetworkStream networkStream = new global::System.Net.Sockets.NetworkStream(this.socket, false);
				if (request.Address.Scheme == global::System.Uri.UriSchemeHttps)
				{
					this.ssl = true;
					WebConnection.EnsureSSLStreamAvailable();
					if (!this.reused || this.nstream == null || this.nstream.GetType() != WebConnection.sslStream)
					{
						byte[] array = null;
						if (this.sPoint.UseConnect && !this.CreateTunnel(request, networkStream, out array))
						{
							return false;
						}
						object[] array2 = new object[] { networkStream, request.ClientCertificates, request, array };
						this.nstream = (Stream)Activator.CreateInstance(WebConnection.sslStream, array2);
						SslClientStream sslClientStream = (SslClientStream)this.nstream;
						ServicePointManager.ChainValidationHelper chainValidationHelper = new ServicePointManager.ChainValidationHelper(request);
						sslClientStream.ServerCertValidation2 += chainValidationHelper.ValidateChain;
						this.certsAvailable = false;
					}
				}
				else
				{
					this.ssl = false;
					this.nstream = networkStream;
				}
			}
			catch (Exception)
			{
				if (!request.Aborted)
				{
					this.status = WebExceptionStatus.ConnectFailure;
				}
				return false;
			}
			return true;
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x0006ED84 File Offset: 0x0006CF84
		private void HandleError(WebExceptionStatus st, Exception e, string where)
		{
			this.status = st;
			lock (this)
			{
				if (st == WebExceptionStatus.RequestCanceled)
				{
					this.Data = new WebConnectionData();
				}
			}
			if (e == null)
			{
				try
				{
					throw new Exception(new StackTrace().ToString());
				}
				catch (Exception ex)
				{
					e = ex;
				}
			}
			HttpWebRequest httpWebRequest = null;
			if (this.Data != null && this.Data.request != null)
			{
				httpWebRequest = this.Data.request;
			}
			this.Close(true);
			if (httpWebRequest != null)
			{
				httpWebRequest.FinishedReading = true;
				httpWebRequest.SetResponseError(st, e, where);
			}
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x0006EE44 File Offset: 0x0006D044
		private static void ReadDone(IAsyncResult result)
		{
			WebConnection webConnection = (WebConnection)result.AsyncState;
			WebConnectionData data = webConnection.Data;
			Stream stream = webConnection.nstream;
			if (stream == null)
			{
				webConnection.Close(true);
				return;
			}
			int num = -1;
			try
			{
				num = stream.EndRead(result);
			}
			catch (Exception ex)
			{
				webConnection.HandleError(WebExceptionStatus.ReceiveFailure, ex, "ReadDone1");
				return;
			}
			if (num == 0)
			{
				webConnection.HandleError(WebExceptionStatus.ReceiveFailure, null, "ReadDone2");
				return;
			}
			if (num < 0)
			{
				webConnection.HandleError(WebExceptionStatus.ServerProtocolViolation, null, "ReadDone3");
				return;
			}
			int num2 = -1;
			num += webConnection.position;
			if (webConnection.readState == ReadState.None)
			{
				Exception ex2 = null;
				try
				{
					num2 = webConnection.GetResponse(webConnection.buffer, num);
				}
				catch (Exception ex3)
				{
					ex2 = ex3;
				}
				if (ex2 != null)
				{
					webConnection.HandleError(WebExceptionStatus.ServerProtocolViolation, ex2, "ReadDone4");
					return;
				}
			}
			if (webConnection.readState != ReadState.Content)
			{
				int num3 = num * 2;
				int num4 = ((num3 >= webConnection.buffer.Length) ? num3 : webConnection.buffer.Length);
				byte[] array = new byte[num4];
				Buffer.BlockCopy(webConnection.buffer, 0, array, 0, num);
				webConnection.buffer = array;
				webConnection.position = num;
				webConnection.readState = ReadState.None;
				WebConnection.InitRead(webConnection);
				return;
			}
			webConnection.position = 0;
			WebConnectionStream webConnectionStream = new WebConnectionStream(webConnection);
			string text = data.Headers["Transfer-Encoding"];
			webConnection.chunkedRead = text != null && text.ToLower().IndexOf("chunked") != -1;
			if (!webConnection.chunkedRead)
			{
				webConnectionStream.ReadBuffer = webConnection.buffer;
				webConnectionStream.ReadBufferOffset = num2;
				webConnectionStream.ReadBufferSize = num;
				webConnectionStream.CheckResponseInBuffer();
			}
			else if (webConnection.chunkStream == null)
			{
				try
				{
					webConnection.chunkStream = new ChunkStream(webConnection.buffer, num2, num, data.Headers);
				}
				catch (Exception ex4)
				{
					webConnection.HandleError(WebExceptionStatus.ServerProtocolViolation, ex4, "ReadDone5");
					return;
				}
			}
			else
			{
				webConnection.chunkStream.ResetBuffer();
				try
				{
					webConnection.chunkStream.Write(webConnection.buffer, num2, num);
				}
				catch (Exception ex5)
				{
					webConnection.HandleError(WebExceptionStatus.ServerProtocolViolation, ex5, "ReadDone6");
					return;
				}
			}
			data.stream = webConnectionStream;
			if (!WebConnection.ExpectContent(data.StatusCode) || data.request.Method == "HEAD")
			{
				webConnectionStream.ForceCompletion();
			}
			data.request.SetResponseData(data);
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x0001A93C File Offset: 0x00018B3C
		private static bool ExpectContent(int statusCode)
		{
			return statusCode >= 200 && statusCode != 204 && statusCode != 304;
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x0006F104 File Offset: 0x0006D304
		internal void GetCertificates()
		{
			X509Certificate x509Certificate = (X509Certificate)WebConnection.piClient.GetValue(this.nstream, null);
			X509Certificate x509Certificate2 = (X509Certificate)WebConnection.piServer.GetValue(this.nstream, null);
			this.sPoint.SetCertificates(x509Certificate, x509Certificate2);
			this.certsAvailable = x509Certificate2 != null;
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x0006F15C File Offset: 0x0006D35C
		internal static void InitRead(object state)
		{
			WebConnection webConnection = (WebConnection)state;
			Stream stream = webConnection.nstream;
			try
			{
				int num = webConnection.buffer.Length - webConnection.position;
				stream.BeginRead(webConnection.buffer, webConnection.position, num, WebConnection.readDoneDelegate, webConnection);
			}
			catch (Exception ex)
			{
				webConnection.HandleError(WebExceptionStatus.ReceiveFailure, ex, "InitRead");
			}
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x0006F1CC File Offset: 0x0006D3CC
		private int GetResponse(byte[] buffer, int max)
		{
			int num = 0;
			string text = null;
			bool flag = false;
			bool flag2 = false;
			for (;;)
			{
				if (this.readState != ReadState.None)
				{
					goto IL_0114;
				}
				if (!WebConnection.ReadLine(buffer, ref num, max, ref text))
				{
					break;
				}
				if (text == null)
				{
					flag2 = true;
				}
				else
				{
					flag2 = false;
					this.readState = ReadState.Status;
					string[] array = text.Split(new char[] { ' ' });
					if (array.Length < 2)
					{
						return -1;
					}
					if (string.Compare(array[0], "HTTP/1.1", true) == 0)
					{
						this.Data.Version = HttpVersion.Version11;
						this.sPoint.SetVersion(HttpVersion.Version11);
					}
					else
					{
						this.Data.Version = HttpVersion.Version10;
						this.sPoint.SetVersion(HttpVersion.Version10);
					}
					this.Data.StatusCode = (int)uint.Parse(array[1]);
					if (array.Length >= 3)
					{
						this.Data.StatusDescription = string.Join(" ", array, 2, array.Length - 2);
					}
					else
					{
						this.Data.StatusDescription = string.Empty;
					}
					if (num >= max)
					{
						return num;
					}
					goto IL_0114;
				}
				IL_02CA:
				if (!flag2 && !flag)
				{
					return -1;
				}
				continue;
				IL_0114:
				flag2 = false;
				if (this.readState != ReadState.Status)
				{
					goto IL_02CA;
				}
				this.readState = ReadState.Headers;
				this.Data.Headers = new WebHeaderCollection();
				ArrayList arrayList = new ArrayList();
				bool flag3 = false;
				while (!flag3)
				{
					if (!WebConnection.ReadLine(buffer, ref num, max, ref text))
					{
						break;
					}
					if (text == null)
					{
						flag3 = true;
					}
					else if (text.Length > 0 && (text[0] == ' ' || text[0] == '\t'))
					{
						int num2 = arrayList.Count - 1;
						if (num2 < 0)
						{
							break;
						}
						string text2 = (string)arrayList[num2] + text;
						arrayList[num2] = text2;
					}
					else
					{
						arrayList.Add(text);
					}
				}
				if (!flag3)
				{
					return -1;
				}
				foreach (object obj in arrayList)
				{
					string text3 = (string)obj;
					this.Data.Headers.SetInternal(text3);
				}
				if (this.Data.StatusCode != 100)
				{
					goto IL_02C1;
				}
				this.sPoint.SendContinue = true;
				if (num >= max)
				{
					return num;
				}
				if (this.Data.request.ExpectContinue)
				{
					this.Data.request.DoContinueDelegate(this.Data.StatusCode, this.Data.Headers);
					this.Data.request.ExpectContinue = false;
				}
				this.readState = ReadState.None;
				flag = true;
				goto IL_02CA;
			}
			return -1;
			IL_02C1:
			this.readState = ReadState.Content;
			return num;
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x0006F4C4 File Offset: 0x0006D6C4
		private void InitConnection(object state)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)state;
			httpWebRequest.WebConnection = this;
			if (httpWebRequest.Aborted)
			{
				return;
			}
			this.keepAlive = httpWebRequest.KeepAlive;
			this.Data = new WebConnectionData();
			this.Data.request = httpWebRequest;
			WebExceptionStatus webExceptionStatus;
			for (;;)
			{
				this.Connect(httpWebRequest);
				if (httpWebRequest.Aborted)
				{
					break;
				}
				if (this.status != WebExceptionStatus.Success)
				{
					goto Block_3;
				}
				if (this.CreateStream(httpWebRequest))
				{
					goto IL_00D2;
				}
				if (httpWebRequest.Aborted)
				{
					return;
				}
				webExceptionStatus = this.status;
				if (this.Data.Challenge == null)
				{
					goto IL_00B4;
				}
			}
			return;
			Block_3:
			if (!httpWebRequest.Aborted)
			{
				httpWebRequest.SetWriteStreamError(this.status, this.connect_exception);
				this.Close(true);
			}
			return;
			IL_00B4:
			Exception ex = this.connect_exception;
			this.connect_exception = null;
			httpWebRequest.SetWriteStreamError(webExceptionStatus, ex);
			this.Close(true);
			return;
			IL_00D2:
			this.readState = ReadState.None;
			httpWebRequest.SetWriteStream(new WebConnectionStream(this, httpWebRequest));
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x0006F5B8 File Offset: 0x0006D7B8
		internal EventHandler SendRequest(HttpWebRequest request)
		{
			if (request.Aborted)
			{
				return null;
			}
			lock (this)
			{
				if (!this.busy)
				{
					this.busy = true;
					this.status = WebExceptionStatus.Success;
					ThreadPool.QueueUserWorkItem(this.initConn, request);
				}
				else
				{
					Queue queue = this.queue;
					lock (queue)
					{
						this.queue.Enqueue(request);
					}
				}
			}
			return this.abortHandler;
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x0006F658 File Offset: 0x0006D858
		private void SendNext()
		{
			Queue queue = this.queue;
			lock (queue)
			{
				if (this.queue.Count > 0)
				{
					this.SendRequest((HttpWebRequest)this.queue.Dequeue());
				}
			}
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x0006F6B8 File Offset: 0x0006D8B8
		internal void NextRead()
		{
			lock (this)
			{
				this.Data.request.FinishedReading = true;
				string text = ((!this.sPoint.UsesProxy) ? "Connection" : "Proxy-Connection");
				string text2 = ((this.Data.Headers == null) ? null : this.Data.Headers[text]);
				bool flag = this.Data.Version == HttpVersion.Version11 && this.keepAlive;
				if (text2 != null)
				{
					text2 = text2.ToLower();
					flag = this.keepAlive && text2.IndexOf("keep-alive") != -1;
				}
				if ((this.socket != null && !this.socket.Connected) || !flag || (text2 != null && text2.IndexOf("close") != -1))
				{
					this.Close(false);
				}
				this.busy = false;
				if (this.priority_request != null)
				{
					this.SendRequest(this.priority_request);
					this.priority_request = null;
				}
				else
				{
					this.SendNext();
				}
			}
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x0006F810 File Offset: 0x0006DA10
		private static bool ReadLine(byte[] buffer, ref int start, int max, ref string output)
		{
			bool flag = false;
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			while (start < max)
			{
				num = (int)buffer[start++];
				if (num == 10)
				{
					if (stringBuilder.Length > 0 && stringBuilder[stringBuilder.Length - 1] == '\r')
					{
						stringBuilder.Length--;
					}
					flag = false;
					break;
				}
				if (flag)
				{
					stringBuilder.Length--;
					break;
				}
				if (num == 13)
				{
					flag = true;
				}
				stringBuilder.Append((char)num);
			}
			if (num != 10 && num != 13)
			{
				return false;
			}
			if (stringBuilder.Length == 0)
			{
				output = null;
				return num == 10 || num == 13;
			}
			if (flag)
			{
				stringBuilder.Length--;
			}
			output = stringBuilder.ToString();
			return true;
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x0006F8F8 File Offset: 0x0006DAF8
		internal IAsyncResult BeginRead(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state)
		{
			lock (this)
			{
				if (this.Data.request != request)
				{
					throw new ObjectDisposedException(typeof(global::System.Net.Sockets.NetworkStream).FullName);
				}
				if (this.nstream == null)
				{
					return null;
				}
			}
			IAsyncResult asyncResult = null;
			if (this.chunkedRead)
			{
				if (!this.chunkStream.WantMore)
				{
					goto IL_009A;
				}
			}
			try
			{
				asyncResult = this.nstream.BeginRead(buffer, offset, size, cb, state);
				cb = null;
			}
			catch (Exception)
			{
				this.HandleError(WebExceptionStatus.ReceiveFailure, null, "chunked BeginRead");
				throw;
			}
			IL_009A:
			if (this.chunkedRead)
			{
				WebAsyncResult webAsyncResult = new WebAsyncResult(cb, state, buffer, offset, size);
				webAsyncResult.InnerAsyncResult = asyncResult;
				if (asyncResult == null)
				{
					webAsyncResult.SetCompleted(true, null);
					webAsyncResult.DoCallback();
				}
				return webAsyncResult;
			}
			return asyncResult;
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x0006F9F4 File Offset: 0x0006DBF4
		internal int EndRead(HttpWebRequest request, IAsyncResult result)
		{
			lock (this)
			{
				if (this.Data.request != request)
				{
					throw new ObjectDisposedException(typeof(global::System.Net.Sockets.NetworkStream).FullName);
				}
				if (this.nstream == null)
				{
					throw new ObjectDisposedException(typeof(global::System.Net.Sockets.NetworkStream).FullName);
				}
			}
			int num = 0;
			WebAsyncResult webAsyncResult = null;
			IAsyncResult innerAsyncResult = ((WebAsyncResult)result).InnerAsyncResult;
			if (this.chunkedRead && innerAsyncResult is WebAsyncResult)
			{
				webAsyncResult = (WebAsyncResult)innerAsyncResult;
				IAsyncResult innerAsyncResult2 = webAsyncResult.InnerAsyncResult;
				if (innerAsyncResult2 != null && !(innerAsyncResult2 is WebAsyncResult))
				{
					num = this.nstream.EndRead(innerAsyncResult2);
				}
			}
			else if (!(innerAsyncResult is WebAsyncResult))
			{
				num = this.nstream.EndRead(innerAsyncResult);
				webAsyncResult = (WebAsyncResult)result;
			}
			if (this.chunkedRead)
			{
				bool flag = num == 0;
				try
				{
					this.chunkStream.WriteAndReadBack(webAsyncResult.Buffer, webAsyncResult.Offset, webAsyncResult.Size, ref num);
					if (!flag && num == 0 && this.chunkStream.WantMore)
					{
						num = this.EnsureRead(webAsyncResult.Buffer, webAsyncResult.Offset, webAsyncResult.Size);
					}
				}
				catch (Exception ex)
				{
					if (ex is WebException)
					{
						throw ex;
					}
					throw new WebException("Invalid chunked data.", ex, WebExceptionStatus.ServerProtocolViolation, null);
				}
				if ((flag || num == 0) && this.chunkStream.ChunkLeft != 0)
				{
					this.HandleError(WebExceptionStatus.ReceiveFailure, null, "chunked EndRead");
					throw new WebException("Read error", null, WebExceptionStatus.ReceiveFailure, null);
				}
			}
			return (num == 0) ? (-1) : num;
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x0006FBC8 File Offset: 0x0006DDC8
		private int EnsureRead(byte[] buffer, int offset, int size)
		{
			byte[] array = null;
			int num = 0;
			while (num == 0 && this.chunkStream.WantMore)
			{
				int num2 = this.chunkStream.ChunkLeft;
				if (num2 <= 0)
				{
					num2 = 1024;
				}
				else if (num2 > 16384)
				{
					num2 = 16384;
				}
				if (array == null || array.Length < num2)
				{
					array = new byte[num2];
				}
				int num3 = this.nstream.Read(array, 0, num2);
				if (num3 <= 0)
				{
					return 0;
				}
				this.chunkStream.Write(array, 0, num3);
				num += this.chunkStream.Read(buffer, offset + num, size - num);
			}
			return num;
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x0006FC78 File Offset: 0x0006DE78
		private bool CompleteChunkedRead()
		{
			if (!this.chunkedRead || this.chunkStream == null)
			{
				return true;
			}
			while (this.chunkStream.WantMore)
			{
				int num = this.nstream.Read(this.buffer, 0, this.buffer.Length);
				if (num <= 0)
				{
					return false;
				}
				this.chunkStream.Write(this.buffer, 0, num);
			}
			return true;
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x0006FCEC File Offset: 0x0006DEEC
		internal IAsyncResult BeginWrite(HttpWebRequest request, byte[] buffer, int offset, int size, AsyncCallback cb, object state)
		{
			lock (this)
			{
				if (this.Data.request != request)
				{
					throw new ObjectDisposedException(typeof(global::System.Net.Sockets.NetworkStream).FullName);
				}
				if (this.nstream == null)
				{
					return null;
				}
			}
			IAsyncResult asyncResult = null;
			try
			{
				asyncResult = this.nstream.BeginWrite(buffer, offset, size, cb, state);
			}
			catch (Exception)
			{
				this.status = WebExceptionStatus.SendFailure;
				throw;
			}
			return asyncResult;
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x0006FD90 File Offset: 0x0006DF90
		internal void EndWrite2(HttpWebRequest request, IAsyncResult result)
		{
			if (request.FinishedReading)
			{
				return;
			}
			lock (this)
			{
				if (this.Data.request != request)
				{
					throw new ObjectDisposedException(typeof(global::System.Net.Sockets.NetworkStream).FullName);
				}
				if (this.nstream == null)
				{
					throw new ObjectDisposedException(typeof(global::System.Net.Sockets.NetworkStream).FullName);
				}
			}
			try
			{
				this.nstream.EndWrite(result);
			}
			catch (Exception ex)
			{
				this.status = WebExceptionStatus.SendFailure;
				if (ex.InnerException != null)
				{
					throw ex.InnerException;
				}
				throw;
			}
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x0006FE54 File Offset: 0x0006E054
		internal bool EndWrite(HttpWebRequest request, IAsyncResult result)
		{
			if (request.FinishedReading)
			{
				return true;
			}
			lock (this)
			{
				if (this.Data.request != request)
				{
					throw new ObjectDisposedException(typeof(global::System.Net.Sockets.NetworkStream).FullName);
				}
				if (this.nstream == null)
				{
					throw new ObjectDisposedException(typeof(global::System.Net.Sockets.NetworkStream).FullName);
				}
			}
			bool flag;
			try
			{
				this.nstream.EndWrite(result);
				flag = true;
			}
			catch
			{
				this.status = WebExceptionStatus.SendFailure;
				flag = false;
			}
			return flag;
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x0006FF14 File Offset: 0x0006E114
		internal int Read(HttpWebRequest request, byte[] buffer, int offset, int size)
		{
			lock (this)
			{
				if (this.Data.request != request)
				{
					throw new ObjectDisposedException(typeof(global::System.Net.Sockets.NetworkStream).FullName);
				}
				if (this.nstream == null)
				{
					return 0;
				}
			}
			int num = 0;
			try
			{
				bool flag = false;
				if (!this.chunkedRead)
				{
					num = this.nstream.Read(buffer, offset, size);
					flag = num == 0;
				}
				if (this.chunkedRead)
				{
					try
					{
						this.chunkStream.WriteAndReadBack(buffer, offset, size, ref num);
						if (!flag && num == 0 && this.chunkStream.WantMore)
						{
							num = this.EnsureRead(buffer, offset, size);
						}
					}
					catch (Exception ex)
					{
						this.HandleError(WebExceptionStatus.ReceiveFailure, ex, "chunked Read1");
						throw;
					}
					if ((flag || num == 0) && this.chunkStream.WantMore)
					{
						this.HandleError(WebExceptionStatus.ReceiveFailure, null, "chunked Read2");
						throw new WebException("Read error", null, WebExceptionStatus.ReceiveFailure, null);
					}
				}
			}
			catch (Exception ex2)
			{
				this.HandleError(WebExceptionStatus.ReceiveFailure, ex2, "Read");
			}
			return num;
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x0007006C File Offset: 0x0006E26C
		internal bool Write(HttpWebRequest request, byte[] buffer, int offset, int size, ref string err_msg)
		{
			err_msg = null;
			lock (this)
			{
				if (this.Data.request != request)
				{
					throw new ObjectDisposedException(typeof(global::System.Net.Sockets.NetworkStream).FullName);
				}
				if (this.nstream == null)
				{
					return false;
				}
			}
			try
			{
				this.nstream.Write(buffer, offset, size);
				if (this.ssl && !this.certsAvailable)
				{
					this.GetCertificates();
				}
			}
			catch (Exception ex)
			{
				err_msg = ex.Message;
				WebExceptionStatus webExceptionStatus = WebExceptionStatus.SendFailure;
				string text = "Write: " + err_msg;
				if (ex is WebException)
				{
					this.HandleError(webExceptionStatus, ex, text);
					return false;
				}
				if (this.ssl && (bool)WebConnection.piTrustFailure.GetValue(this.nstream, null))
				{
					webExceptionStatus = WebExceptionStatus.TrustFailure;
					text = "Trust failure";
				}
				this.HandleError(webExceptionStatus, ex, text);
				return false;
			}
			return true;
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x00070198 File Offset: 0x0006E398
		internal void Close(bool sendNext)
		{
			lock (this)
			{
				if (this.nstream != null)
				{
					try
					{
						this.nstream.Close();
					}
					catch
					{
					}
					this.nstream = null;
				}
				if (this.socket != null)
				{
					try
					{
						this.socket.Close();
					}
					catch
					{
					}
					this.socket = null;
				}
				this.busy = false;
				this.Data = new WebConnectionData();
				if (sendNext)
				{
					this.SendNext();
				}
			}
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x00070250 File Offset: 0x0006E450
		private void Abort(object sender, EventArgs args)
		{
			lock (this)
			{
				Queue queue = this.queue;
				lock (queue)
				{
					HttpWebRequest httpWebRequest = (HttpWebRequest)sender;
					if (this.Data.request == httpWebRequest)
					{
						if (!httpWebRequest.FinishedReading)
						{
							this.status = WebExceptionStatus.RequestCanceled;
							this.Close(false);
							if (this.queue.Count > 0)
							{
								this.Data.request = (HttpWebRequest)this.queue.Dequeue();
								this.SendRequest(this.Data.request);
							}
						}
					}
					else
					{
						httpWebRequest.FinishedReading = true;
						httpWebRequest.SetResponseError(WebExceptionStatus.RequestCanceled, null, "User aborted");
						if (this.queue.Count > 0 && this.queue.Peek() == sender)
						{
							this.queue.Dequeue();
						}
						else if (this.queue.Count > 0)
						{
							object[] array = this.queue.ToArray();
							this.queue.Clear();
							for (int i = array.Length - 1; i >= 0; i--)
							{
								if (array[i] != sender)
								{
									this.queue.Enqueue(array[i]);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x0001A962 File Offset: 0x00018B62
		internal void ResetNtlm()
		{
			this.ntlm_authenticated = false;
			this.ntlm_credentials = null;
			this.unsafe_sharing = false;
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x060025DE RID: 9694 RVA: 0x000703D4 File Offset: 0x0006E5D4
		internal bool Busy
		{
			get
			{
				bool flag;
				lock (this)
				{
					flag = this.busy;
				}
				return flag;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x060025DF RID: 9695 RVA: 0x00070414 File Offset: 0x0006E614
		internal bool Connected
		{
			get
			{
				bool flag;
				lock (this)
				{
					flag = this.socket != null && this.socket.Connected;
				}
				return flag;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (set) Token: 0x060025E0 RID: 9696 RVA: 0x0001A979 File Offset: 0x00018B79
		internal HttpWebRequest PriorityRequest
		{
			set
			{
				this.priority_request = value;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x060025E1 RID: 9697 RVA: 0x0001A982 File Offset: 0x00018B82
		// (set) Token: 0x060025E2 RID: 9698 RVA: 0x0001A98A File Offset: 0x00018B8A
		internal bool NtlmAuthenticated
		{
			get
			{
				return this.ntlm_authenticated;
			}
			set
			{
				this.ntlm_authenticated = value;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x060025E3 RID: 9699 RVA: 0x0001A993 File Offset: 0x00018B93
		// (set) Token: 0x060025E4 RID: 9700 RVA: 0x0001A99B File Offset: 0x00018B9B
		internal NetworkCredential NtlmCredential
		{
			get
			{
				return this.ntlm_credentials;
			}
			set
			{
				this.ntlm_credentials = value;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x060025E5 RID: 9701 RVA: 0x0001A9A4 File Offset: 0x00018BA4
		// (set) Token: 0x060025E6 RID: 9702 RVA: 0x0001A9AC File Offset: 0x00018BAC
		internal bool UnsafeAuthenticatedConnectionSharing
		{
			get
			{
				return this.unsafe_sharing;
			}
			set
			{
				this.unsafe_sharing = value;
			}
		}

		// Token: 0x04001729 RID: 5929
		private ServicePoint sPoint;

		// Token: 0x0400172A RID: 5930
		private Stream nstream;

		// Token: 0x0400172B RID: 5931
		private global::System.Net.Sockets.Socket socket;

		// Token: 0x0400172C RID: 5932
		private object socketLock = new object();

		// Token: 0x0400172D RID: 5933
		private WebExceptionStatus status;

		// Token: 0x0400172E RID: 5934
		private WaitCallback initConn;

		// Token: 0x0400172F RID: 5935
		private bool keepAlive;

		// Token: 0x04001730 RID: 5936
		private byte[] buffer;

		// Token: 0x04001731 RID: 5937
		private static AsyncCallback readDoneDelegate = new AsyncCallback(WebConnection.ReadDone);

		// Token: 0x04001732 RID: 5938
		private EventHandler abortHandler;

		// Token: 0x04001733 RID: 5939
		private WebConnection.AbortHelper abortHelper;

		// Token: 0x04001734 RID: 5940
		private ReadState readState;

		// Token: 0x04001735 RID: 5941
		internal WebConnectionData Data;

		// Token: 0x04001736 RID: 5942
		private bool chunkedRead;

		// Token: 0x04001737 RID: 5943
		private ChunkStream chunkStream;

		// Token: 0x04001738 RID: 5944
		private Queue queue;

		// Token: 0x04001739 RID: 5945
		private bool reused;

		// Token: 0x0400173A RID: 5946
		private int position;

		// Token: 0x0400173B RID: 5947
		private bool busy;

		// Token: 0x0400173C RID: 5948
		private HttpWebRequest priority_request;

		// Token: 0x0400173D RID: 5949
		private NetworkCredential ntlm_credentials;

		// Token: 0x0400173E RID: 5950
		private bool ntlm_authenticated;

		// Token: 0x0400173F RID: 5951
		private bool unsafe_sharing;

		// Token: 0x04001740 RID: 5952
		private bool ssl;

		// Token: 0x04001741 RID: 5953
		private bool certsAvailable;

		// Token: 0x04001742 RID: 5954
		private Exception connect_exception;

		// Token: 0x04001743 RID: 5955
		private static object classLock = new object();

		// Token: 0x04001744 RID: 5956
		private static Type sslStream;

		// Token: 0x04001745 RID: 5957
		private static PropertyInfo piClient;

		// Token: 0x04001746 RID: 5958
		private static PropertyInfo piServer;

		// Token: 0x04001747 RID: 5959
		private static PropertyInfo piTrustFailure;

		// Token: 0x04001748 RID: 5960
		private static MethodInfo method_GetSecurityPolicyFromNonMainThread;

		// Token: 0x0200042F RID: 1071
		private class AbortHelper
		{
			// Token: 0x060025E8 RID: 9704 RVA: 0x00070468 File Offset: 0x0006E668
			public void Abort(object sender, EventArgs args)
			{
				WebConnection webConnection = ((HttpWebRequest)sender).WebConnection;
				if (webConnection == null)
				{
					webConnection = this.Connection;
				}
				webConnection.Abort(sender, args);
			}

			// Token: 0x04001749 RID: 5961
			public WebConnection Connection;
		}
	}
}
