using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000432 RID: 1074
	internal class WebConnectionStream : Stream
	{
		// Token: 0x060025F2 RID: 9714 RVA: 0x00070810 File Offset: 0x0006EA10
		public WebConnectionStream(WebConnection cnc)
		{
			this.isRead = true;
			this.pending = new ManualResetEvent(true);
			this.request = cnc.Data.request;
			this.read_timeout = this.request.ReadWriteTimeout;
			this.write_timeout = this.read_timeout;
			this.cnc = cnc;
			string text = cnc.Data.Headers["Transfer-Encoding"];
			bool flag = text != null && text.ToLower().IndexOf("chunked") != -1;
			string text2 = cnc.Data.Headers["Content-Length"];
			if (!flag && text2 != null && text2 != string.Empty)
			{
				try
				{
					this.contentLength = int.Parse(text2);
					if (this.contentLength == 0 && !this.IsNtlmAuth())
					{
						this.ReadAll();
					}
				}
				catch
				{
					this.contentLength = int.MaxValue;
				}
			}
			else
			{
				this.contentLength = int.MaxValue;
			}
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x0007093C File Offset: 0x0006EB3C
		public WebConnectionStream(WebConnection cnc, HttpWebRequest request)
		{
			this.read_timeout = request.ReadWriteTimeout;
			this.write_timeout = this.read_timeout;
			this.isRead = false;
			this.cnc = cnc;
			this.request = request;
			this.allowBuffering = request.InternalAllowBuffering;
			this.sendChunked = request.SendChunked;
			if (this.sendChunked)
			{
				this.pending = new ManualResetEvent(true);
			}
			else if (this.allowBuffering)
			{
				this.writeBuffer = new MemoryStream();
			}
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x000709D4 File Offset: 0x0006EBD4
		private bool IsNtlmAuth()
		{
			bool flag = this.request.Proxy != null && !this.request.Proxy.IsBypassed(this.request.Address);
			string text = ((!flag) ? "WWW-Authenticate" : "Proxy-Authenticate");
			string text2 = this.cnc.Data.Headers[text];
			return text2 != null && text2.IndexOf("NTLM") != -1;
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x0001AA2E File Offset: 0x00018C2E
		internal void CheckResponseInBuffer()
		{
			if (this.contentLength > 0 && this.readBufferSize - this.readBufferOffset >= this.contentLength && !this.IsNtlmAuth())
			{
				this.ReadAll();
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x060025F7 RID: 9719 RVA: 0x0001AA65 File Offset: 0x00018C65
		internal HttpWebRequest Request
		{
			get
			{
				return this.request;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x0001AA6D File Offset: 0x00018C6D
		internal WebConnection Connection
		{
			get
			{
				return this.cnc;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x060025F9 RID: 9721 RVA: 0x000025B7 File Offset: 0x000007B7
		public override bool CanTimeout
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x060025FA RID: 9722 RVA: 0x0001AA75 File Offset: 0x00018C75
		// (set) Token: 0x060025FB RID: 9723 RVA: 0x0001AA7D File Offset: 0x00018C7D
		public override int ReadTimeout
		{
			get
			{
				return this.read_timeout;
			}
			set
			{
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.read_timeout = value;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x0001AA98 File Offset: 0x00018C98
		// (set) Token: 0x060025FD RID: 9725 RVA: 0x0001AAA0 File Offset: 0x00018CA0
		public override int WriteTimeout
		{
			get
			{
				return this.write_timeout;
			}
			set
			{
				if (value < -1)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.write_timeout = value;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x0001AABB File Offset: 0x00018CBB
		internal bool CompleteRequestWritten
		{
			get
			{
				return this.complete_request_written;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (set) Token: 0x060025FF RID: 9727 RVA: 0x0001AAC3 File Offset: 0x00018CC3
		internal bool SendChunked
		{
			set
			{
				this.sendChunked = value;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (set) Token: 0x06002600 RID: 9728 RVA: 0x0001AACC File Offset: 0x00018CCC
		internal byte[] ReadBuffer
		{
			set
			{
				this.readBuffer = value;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (set) Token: 0x06002601 RID: 9729 RVA: 0x0001AAD5 File Offset: 0x00018CD5
		internal int ReadBufferOffset
		{
			set
			{
				this.readBufferOffset = value;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (set) Token: 0x06002602 RID: 9730 RVA: 0x0001AADE File Offset: 0x00018CDE
		internal int ReadBufferSize
		{
			set
			{
				this.readBufferSize = value;
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06002603 RID: 9731 RVA: 0x0001AAE7 File Offset: 0x00018CE7
		internal byte[] WriteBuffer
		{
			get
			{
				return this.writeBuffer.GetBuffer();
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x0001AAF4 File Offset: 0x00018CF4
		internal int WriteBufferLength
		{
			get
			{
				return (this.writeBuffer == null) ? (-1) : ((int)this.writeBuffer.Length);
			}
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x0001AB13 File Offset: 0x00018D13
		internal void ForceCompletion()
		{
			if (!this.nextReadCalled)
			{
				if (this.contentLength == 2147483647)
				{
					this.contentLength = 0;
				}
				this.nextReadCalled = true;
				this.cnc.NextRead();
			}
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x00070A5C File Offset: 0x0006EC5C
		internal void CheckComplete()
		{
			if (!this.nextReadCalled && this.readBufferSize - this.readBufferOffset == this.contentLength)
			{
				this.nextReadCalled = true;
				this.cnc.NextRead();
			}
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x00070AA0 File Offset: 0x0006ECA0
		internal void ReadAll()
		{
			if (!this.isRead || this.read_eof || this.totalRead >= this.contentLength || this.nextReadCalled)
			{
				if (this.isRead && !this.nextReadCalled)
				{
					this.nextReadCalled = true;
					this.cnc.NextRead();
				}
				return;
			}
			this.pending.WaitOne();
			object obj = this.locker;
			lock (obj)
			{
				if (this.totalRead >= this.contentLength)
				{
					return;
				}
				int num = this.readBufferSize - this.readBufferOffset;
				byte[] array2;
				int num3;
				if (this.contentLength == 2147483647)
				{
					MemoryStream memoryStream = new MemoryStream();
					byte[] array = null;
					if (this.readBuffer != null && num > 0)
					{
						memoryStream.Write(this.readBuffer, this.readBufferOffset, num);
						if (this.readBufferSize >= 8192)
						{
							array = this.readBuffer;
						}
					}
					if (array == null)
					{
						array = new byte[8192];
					}
					int num2;
					while ((num2 = this.cnc.Read(this.request, array, 0, array.Length)) != 0)
					{
						memoryStream.Write(array, 0, num2);
					}
					array2 = memoryStream.GetBuffer();
					num3 = (int)memoryStream.Length;
					this.contentLength = num3;
				}
				else
				{
					num3 = this.contentLength - this.totalRead;
					array2 = new byte[num3];
					if (this.readBuffer != null && num > 0)
					{
						if (num > num3)
						{
							num = num3;
						}
						Buffer.BlockCopy(this.readBuffer, this.readBufferOffset, array2, 0, num);
					}
					int num4 = num3 - num;
					int num5 = -1;
					while (num4 > 0 && num5 != 0)
					{
						num5 = this.cnc.Read(this.request, array2, num, num4);
						num4 -= num5;
						num += num5;
					}
				}
				this.readBuffer = array2;
				this.readBufferOffset = 0;
				this.readBufferSize = num3;
				this.totalRead = 0;
				this.nextReadCalled = true;
			}
			this.cnc.NextRead();
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x00070CDC File Offset: 0x0006EEDC
		private void WriteCallbackWrapper(IAsyncResult r)
		{
			WebAsyncResult webAsyncResult = r as WebAsyncResult;
			if (webAsyncResult != null && webAsyncResult.AsyncWriteAll)
			{
				return;
			}
			if (r.AsyncState != null)
			{
				webAsyncResult = (WebAsyncResult)r.AsyncState;
				webAsyncResult.InnerAsyncResult = r;
				webAsyncResult.DoCallback();
			}
			else
			{
				this.EndWrite(r);
			}
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x00070D34 File Offset: 0x0006EF34
		private void ReadCallbackWrapper(IAsyncResult r)
		{
			if (r.AsyncState != null)
			{
				WebAsyncResult webAsyncResult = (WebAsyncResult)r.AsyncState;
				webAsyncResult.InnerAsyncResult = r;
				webAsyncResult.DoCallback();
			}
			else
			{
				this.EndRead(r);
			}
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x00070D74 File Offset: 0x0006EF74
		public override int Read(byte[] buffer, int offset, int size)
		{
			AsyncCallback asyncCallback = new AsyncCallback(this.ReadCallbackWrapper);
			WebAsyncResult webAsyncResult = (WebAsyncResult)this.BeginRead(buffer, offset, size, asyncCallback, null);
			if (!webAsyncResult.IsCompleted && !webAsyncResult.WaitUntilComplete(this.ReadTimeout, false))
			{
				this.nextReadCalled = true;
				this.cnc.Close(true);
				throw new WebException("The operation has timed out.", WebExceptionStatus.Timeout);
			}
			return this.EndRead(webAsyncResult);
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x00070DE4 File Offset: 0x0006EFE4
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state)
		{
			if (!this.isRead)
			{
				throw new NotSupportedException("this stream does not allow reading");
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			int num = buffer.Length;
			if (offset < 0 || num < offset)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (size < 0 || num - offset < size)
			{
				throw new ArgumentOutOfRangeException("size");
			}
			object obj = this.locker;
			lock (obj)
			{
				this.pendingReads++;
				this.pending.Reset();
			}
			WebAsyncResult webAsyncResult = new WebAsyncResult(cb, state, buffer, offset, size);
			if (this.totalRead >= this.contentLength)
			{
				webAsyncResult.SetCompleted(true, -1);
				webAsyncResult.DoCallback();
				return webAsyncResult;
			}
			int num2 = this.readBufferSize - this.readBufferOffset;
			if (num2 > 0)
			{
				int num3 = ((num2 <= size) ? num2 : size);
				Buffer.BlockCopy(this.readBuffer, this.readBufferOffset, buffer, offset, num3);
				this.readBufferOffset += num3;
				offset += num3;
				size -= num3;
				this.totalRead += num3;
				if (size == 0 || this.totalRead >= this.contentLength)
				{
					webAsyncResult.SetCompleted(true, num3);
					webAsyncResult.DoCallback();
					return webAsyncResult;
				}
				webAsyncResult.NBytes = num3;
			}
			if (cb != null)
			{
				cb = new AsyncCallback(this.ReadCallbackWrapper);
			}
			if (this.contentLength != 2147483647 && this.contentLength - this.totalRead < size)
			{
				size = this.contentLength - this.totalRead;
			}
			if (!this.read_eof)
			{
				webAsyncResult.InnerAsyncResult = this.cnc.BeginRead(this.request, buffer, offset, size, cb, webAsyncResult);
			}
			else
			{
				webAsyncResult.SetCompleted(true, webAsyncResult.NBytes);
				webAsyncResult.DoCallback();
			}
			return webAsyncResult;
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x00070FE0 File Offset: 0x0006F1E0
		public override int EndRead(IAsyncResult r)
		{
			WebAsyncResult webAsyncResult = (WebAsyncResult)r;
			if (webAsyncResult.EndCalled)
			{
				int nbytes = webAsyncResult.NBytes;
				return (nbytes < 0) ? 0 : nbytes;
			}
			webAsyncResult.EndCalled = true;
			if (!webAsyncResult.IsCompleted)
			{
				int num = -1;
				try
				{
					num = this.cnc.EndRead(this.request, webAsyncResult);
				}
				catch (Exception ex)
				{
					object obj = this.locker;
					lock (obj)
					{
						this.pendingReads--;
						if (this.pendingReads == 0)
						{
							this.pending.Set();
						}
					}
					this.nextReadCalled = true;
					this.cnc.Close(true);
					webAsyncResult.SetCompleted(false, ex);
					webAsyncResult.DoCallback();
					throw;
				}
				if (num < 0)
				{
					num = 0;
					this.read_eof = true;
				}
				this.totalRead += num;
				webAsyncResult.SetCompleted(false, num + webAsyncResult.NBytes);
				webAsyncResult.DoCallback();
				if (num == 0)
				{
					this.contentLength = this.totalRead;
				}
			}
			object obj2 = this.locker;
			lock (obj2)
			{
				this.pendingReads--;
				if (this.pendingReads == 0)
				{
					this.pending.Set();
				}
			}
			if (this.totalRead >= this.contentLength && !this.nextReadCalled)
			{
				this.ReadAll();
			}
			int nbytes2 = webAsyncResult.NBytes;
			return (nbytes2 < 0) ? 0 : nbytes2;
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x00071194 File Offset: 0x0006F394
		private void WriteRequestAsyncCB(IAsyncResult r)
		{
			WebAsyncResult webAsyncResult = (WebAsyncResult)r.AsyncState;
			try
			{
				this.cnc.EndWrite2(this.request, r);
				webAsyncResult.SetCompleted(false, 0);
				if (!this.initRead)
				{
					this.initRead = true;
					WebConnection.InitRead(this.cnc);
				}
			}
			catch (Exception ex)
			{
				this.KillBuffer();
				this.nextReadCalled = true;
				this.cnc.Close(true);
				if (ex is global::System.Net.Sockets.SocketException)
				{
					ex = new IOException("Error writing request", ex);
				}
				webAsyncResult.SetCompleted(false, ex);
			}
			this.complete_request_written = true;
			webAsyncResult.DoCallback();
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x00071244 File Offset: 0x0006F444
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state)
		{
			if (this.request.Aborted)
			{
				throw new WebException("The request was canceled.", null, WebExceptionStatus.RequestCanceled);
			}
			if (this.isRead)
			{
				throw new NotSupportedException("this stream does not allow writing");
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			int num = buffer.Length;
			if (offset < 0 || num < offset)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (size < 0 || num - offset < size)
			{
				throw new ArgumentOutOfRangeException("size");
			}
			if (this.sendChunked)
			{
				object obj = this.locker;
				lock (obj)
				{
					this.pendingWrites++;
					this.pending.Reset();
				}
			}
			WebAsyncResult webAsyncResult = new WebAsyncResult(cb, state);
			if (!this.sendChunked)
			{
				this.CheckWriteOverflow(this.request.ContentLength, this.totalWritten, (long)size);
			}
			if (this.allowBuffering && !this.sendChunked)
			{
				if (this.writeBuffer == null)
				{
					this.writeBuffer = new MemoryStream();
				}
				this.writeBuffer.Write(buffer, offset, size);
				this.totalWritten += (long)size;
				if (this.request.ContentLength > 0L && this.totalWritten == this.request.ContentLength)
				{
					try
					{
						webAsyncResult.AsyncWriteAll = true;
						webAsyncResult.InnerAsyncResult = this.WriteRequestAsync(new AsyncCallback(this.WriteRequestAsyncCB), webAsyncResult);
						if (webAsyncResult.InnerAsyncResult == null)
						{
							if (!webAsyncResult.IsCompleted)
							{
								webAsyncResult.SetCompleted(true, 0);
							}
							webAsyncResult.DoCallback();
						}
					}
					catch (Exception ex)
					{
						webAsyncResult.SetCompleted(true, ex);
						webAsyncResult.DoCallback();
					}
				}
				else
				{
					webAsyncResult.SetCompleted(true, 0);
					webAsyncResult.DoCallback();
				}
				return webAsyncResult;
			}
			AsyncCallback asyncCallback = null;
			if (cb != null)
			{
				asyncCallback = new AsyncCallback(this.WriteCallbackWrapper);
			}
			if (this.sendChunked)
			{
				this.WriteRequest();
				string text = string.Format("{0:X}\r\n", size);
				byte[] bytes = Encoding.ASCII.GetBytes(text);
				int num2 = 2 + size + bytes.Length;
				byte[] array = new byte[num2];
				Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length);
				Buffer.BlockCopy(buffer, offset, array, bytes.Length, size);
				Buffer.BlockCopy(WebConnectionStream.crlf, 0, array, bytes.Length + size, WebConnectionStream.crlf.Length);
				buffer = array;
				offset = 0;
				size = num2;
			}
			webAsyncResult.InnerAsyncResult = this.cnc.BeginWrite(this.request, buffer, offset, size, asyncCallback, webAsyncResult);
			this.totalWritten += (long)size;
			return webAsyncResult;
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x00071504 File Offset: 0x0006F704
		private void CheckWriteOverflow(long contentLength, long totalWritten, long size)
		{
			if (contentLength == -1L)
			{
				return;
			}
			long num = contentLength - totalWritten;
			if (size > num)
			{
				this.KillBuffer();
				this.nextReadCalled = true;
				this.cnc.Close(true);
				throw new ProtocolViolationException("The number of bytes to be written is greater than the specified ContentLength.");
			}
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x0007154C File Offset: 0x0006F74C
		public override void EndWrite(IAsyncResult r)
		{
			if (r == null)
			{
				throw new ArgumentNullException("r");
			}
			WebAsyncResult webAsyncResult = r as WebAsyncResult;
			if (webAsyncResult == null)
			{
				throw new ArgumentException("Invalid IAsyncResult");
			}
			if (webAsyncResult.EndCalled)
			{
				return;
			}
			webAsyncResult.EndCalled = true;
			if (webAsyncResult.AsyncWriteAll)
			{
				webAsyncResult.WaitUntilComplete();
				if (webAsyncResult.GotException)
				{
					throw webAsyncResult.Exception;
				}
				return;
			}
			else
			{
				if (this.allowBuffering && !this.sendChunked)
				{
					return;
				}
				if (webAsyncResult.GotException)
				{
					throw webAsyncResult.Exception;
				}
				try
				{
					this.cnc.EndWrite2(this.request, webAsyncResult.InnerAsyncResult);
					webAsyncResult.SetCompleted(false, 0);
					webAsyncResult.DoCallback();
				}
				catch (Exception ex)
				{
					webAsyncResult.SetCompleted(false, ex);
					webAsyncResult.DoCallback();
					throw;
				}
				finally
				{
					if (this.sendChunked)
					{
						object obj = this.locker;
						lock (obj)
						{
							this.pendingWrites--;
							if (this.pendingWrites == 0)
							{
								this.pending.Set();
							}
						}
					}
				}
				return;
			}
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x00071694 File Offset: 0x0006F894
		public override void Write(byte[] buffer, int offset, int size)
		{
			AsyncCallback asyncCallback = new AsyncCallback(this.WriteCallbackWrapper);
			WebAsyncResult webAsyncResult = (WebAsyncResult)this.BeginWrite(buffer, offset, size, asyncCallback, null);
			if (!webAsyncResult.IsCompleted && !webAsyncResult.WaitUntilComplete(this.WriteTimeout, false))
			{
				this.KillBuffer();
				this.nextReadCalled = true;
				this.cnc.Close(true);
				throw new IOException("Write timed out.");
			}
			this.EndWrite(webAsyncResult);
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override void Flush()
		{
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x00071708 File Offset: 0x0006F908
		internal void SetHeaders(byte[] buffer)
		{
			if (this.headersSent)
			{
				return;
			}
			this.headers = buffer;
			long num = this.request.ContentLength;
			string method = this.request.Method;
			bool flag = method == "GET" || method == "CONNECT" || method == "HEAD" || method == "TRACE" || method == "DELETE";
			if (this.sendChunked || num > -1L || flag)
			{
				this.WriteHeaders();
				if (!this.initRead)
				{
					this.initRead = true;
					WebConnection.InitRead(this.cnc);
				}
				if (!this.sendChunked && num == 0L)
				{
					this.requestWritten = true;
				}
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x0001AB49 File Offset: 0x00018D49
		internal bool RequestWritten
		{
			get
			{
				return this.requestWritten;
			}
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x000717E4 File Offset: 0x0006F9E4
		private IAsyncResult WriteRequestAsync(AsyncCallback cb, object state)
		{
			this.requestWritten = true;
			byte[] buffer = this.writeBuffer.GetBuffer();
			int num = (int)this.writeBuffer.Length;
			IAsyncResult asyncResult2;
			if (num > 0)
			{
				IAsyncResult asyncResult = this.cnc.BeginWrite(this.request, buffer, 0, num, cb, state);
				asyncResult2 = asyncResult;
			}
			else
			{
				asyncResult2 = null;
			}
			return asyncResult2;
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x00071838 File Offset: 0x0006FA38
		private void WriteHeaders()
		{
			if (this.headersSent)
			{
				return;
			}
			this.headersSent = true;
			string text = null;
			if (!this.cnc.Write(this.request, this.headers, 0, this.headers.Length, ref text))
			{
				throw new WebException("Error writing request: " + text, null, WebExceptionStatus.SendFailure, null);
			}
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x00071898 File Offset: 0x0006FA98
		internal void WriteRequest()
		{
			if (this.requestWritten)
			{
				return;
			}
			this.requestWritten = true;
			if (this.sendChunked)
			{
				return;
			}
			if (!this.allowBuffering || this.writeBuffer == null)
			{
				return;
			}
			byte[] buffer = this.writeBuffer.GetBuffer();
			int num = (int)this.writeBuffer.Length;
			if (this.request.ContentLength != -1L && this.request.ContentLength < (long)num)
			{
				this.nextReadCalled = true;
				this.cnc.Close(true);
				throw new WebException("Specified Content-Length is less than the number of bytes to write", null, WebExceptionStatus.ServerProtocolViolation, null);
			}
			if (!this.headersSent)
			{
				string method = this.request.Method;
				if (!(method == "GET") && !(method == "CONNECT") && !(method == "HEAD") && !(method == "TRACE") && !(method == "DELETE"))
				{
					this.request.InternalContentLength = (long)num;
				}
				this.request.SendRequestHeaders(true);
			}
			this.WriteHeaders();
			if (this.cnc.Data.StatusCode != 0 && this.cnc.Data.StatusCode != 100)
			{
				return;
			}
			IAsyncResult asyncResult = null;
			if (num > 0)
			{
				asyncResult = this.cnc.BeginWrite(this.request, buffer, 0, num, null, null);
			}
			if (!this.initRead)
			{
				this.initRead = true;
				WebConnection.InitRead(this.cnc);
			}
			if (num > 0)
			{
				this.complete_request_written = this.cnc.EndWrite(this.request, asyncResult);
			}
			else
			{
				this.complete_request_written = true;
			}
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x0001AB51 File Offset: 0x00018D51
		internal void InternalClose()
		{
			this.disposed = true;
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x00071A60 File Offset: 0x0006FC60
		public override void Close()
		{
			if (this.sendChunked)
			{
				if (this.disposed)
				{
					return;
				}
				this.disposed = true;
				this.pending.WaitOne();
				byte[] bytes = Encoding.ASCII.GetBytes("0\r\n\r\n");
				string text = null;
				this.cnc.Write(this.request, bytes, 0, bytes.Length, ref text);
				return;
			}
			else
			{
				if (this.isRead)
				{
					if (!this.nextReadCalled)
					{
						this.CheckComplete();
						if (!this.nextReadCalled)
						{
							this.nextReadCalled = true;
							this.cnc.Close(true);
						}
					}
					return;
				}
				if (!this.allowBuffering)
				{
					this.complete_request_written = true;
					if (!this.initRead)
					{
						this.initRead = true;
						WebConnection.InitRead(this.cnc);
					}
					return;
				}
				if (this.disposed || this.requestWritten)
				{
					return;
				}
				long num = this.request.ContentLength;
				if (!this.sendChunked && num != -1L && this.totalWritten != num)
				{
					IOException ex = new IOException("Cannot close the stream until all bytes are written");
					this.nextReadCalled = true;
					this.cnc.Close(true);
					throw new WebException("Request was cancelled.", ex, WebExceptionStatus.RequestCanceled);
				}
				this.WriteRequest();
				this.disposed = true;
				return;
			}
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x0001AB5A File Offset: 0x00018D5A
		internal void KillBuffer()
		{
			this.writeBuffer = null;
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x00006A38 File Offset: 0x00004C38
		public override long Seek(long a, SeekOrigin b)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x00006A38 File Offset: 0x00004C38
		public override void SetLength(long a)
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x0600261D RID: 9757 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x0600261E RID: 9758 RVA: 0x0001AB63 File Offset: 0x00018D63
		public override bool CanRead
		{
			get
			{
				return !this.disposed && this.isRead;
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x0600261F RID: 9759 RVA: 0x0001AB79 File Offset: 0x00018D79
		public override bool CanWrite
		{
			get
			{
				return !this.disposed && !this.isRead;
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06002620 RID: 9760 RVA: 0x00006A38 File Offset: 0x00004C38
		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06002621 RID: 9761 RVA: 0x00006A38 File Offset: 0x00004C38
		// (set) Token: 0x06002622 RID: 9762 RVA: 0x00006A38 File Offset: 0x00004C38
		public override long Position
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x04001756 RID: 5974
		private static byte[] crlf = new byte[] { 13, 10 };

		// Token: 0x04001757 RID: 5975
		private bool isRead;

		// Token: 0x04001758 RID: 5976
		private WebConnection cnc;

		// Token: 0x04001759 RID: 5977
		private HttpWebRequest request;

		// Token: 0x0400175A RID: 5978
		private byte[] readBuffer;

		// Token: 0x0400175B RID: 5979
		private int readBufferOffset;

		// Token: 0x0400175C RID: 5980
		private int readBufferSize;

		// Token: 0x0400175D RID: 5981
		private int contentLength;

		// Token: 0x0400175E RID: 5982
		private int totalRead;

		// Token: 0x0400175F RID: 5983
		private long totalWritten;

		// Token: 0x04001760 RID: 5984
		private bool nextReadCalled;

		// Token: 0x04001761 RID: 5985
		private int pendingReads;

		// Token: 0x04001762 RID: 5986
		private int pendingWrites;

		// Token: 0x04001763 RID: 5987
		private ManualResetEvent pending;

		// Token: 0x04001764 RID: 5988
		private bool allowBuffering;

		// Token: 0x04001765 RID: 5989
		private bool sendChunked;

		// Token: 0x04001766 RID: 5990
		private MemoryStream writeBuffer;

		// Token: 0x04001767 RID: 5991
		private bool requestWritten;

		// Token: 0x04001768 RID: 5992
		private byte[] headers;

		// Token: 0x04001769 RID: 5993
		private bool disposed;

		// Token: 0x0400176A RID: 5994
		private bool headersSent;

		// Token: 0x0400176B RID: 5995
		private object locker = new object();

		// Token: 0x0400176C RID: 5996
		private bool initRead;

		// Token: 0x0400176D RID: 5997
		private bool read_eof;

		// Token: 0x0400176E RID: 5998
		private bool complete_request_written;

		// Token: 0x0400176F RID: 5999
		private int read_timeout;

		// Token: 0x04001770 RID: 6000
		private int write_timeout;
	}
}
