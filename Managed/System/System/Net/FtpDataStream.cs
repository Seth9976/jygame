using System;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace System.Net
{
	// Token: 0x0200031C RID: 796
	internal class FtpDataStream : Stream, IDisposable
	{
		// Token: 0x06001B1A RID: 6938 RVA: 0x00013C34 File Offset: 0x00011E34
		internal FtpDataStream(FtpWebRequest request, Stream stream, bool isRead)
		{
			if (request == null)
			{
				throw new ArgumentNullException("request");
			}
			this.request = request;
			this.networkStream = stream;
			this.isRead = isRead;
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x00013C62 File Offset: 0x00011E62
		void IDisposable.Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001B1C RID: 6940 RVA: 0x00013C71 File Offset: 0x00011E71
		public override bool CanRead
		{
			get
			{
				return this.isRead;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x00013C79 File Offset: 0x00011E79
		public override bool CanWrite
		{
			get
			{
				return !this.isRead;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001B1E RID: 6942 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x00006A38 File Offset: 0x00004C38
		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001B20 RID: 6944 RVA: 0x00006A38 File Offset: 0x00004C38
		// (set) Token: 0x06001B21 RID: 6945 RVA: 0x00006A38 File Offset: 0x00004C38
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

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001B22 RID: 6946 RVA: 0x00013C84 File Offset: 0x00011E84
		internal Stream NetworkStream
		{
			get
			{
				this.CheckDisposed();
				return this.networkStream;
			}
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x00013C92 File Offset: 0x00011E92
		public override void Close()
		{
			this.Dispose(true);
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override void Flush()
		{
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x00006A38 File Offset: 0x00004C38
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x00006A38 File Offset: 0x00004C38
		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x000513B0 File Offset: 0x0004F5B0
		private int ReadInternal(byte[] buffer, int offset, int size)
		{
			int num = 0;
			this.request.CheckIfAborted();
			try
			{
				num = this.networkStream.Read(buffer, offset, size);
			}
			catch (IOException)
			{
				throw new ProtocolViolationException("Server commited a protocol violation");
			}
			this.totalRead += num;
			if (num == 0)
			{
				this.networkStream = null;
				this.request.CloseDataConnection();
				this.request.SetTransferCompleted();
			}
			return num;
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x00051434 File Offset: 0x0004F634
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state)
		{
			this.CheckDisposed();
			if (!this.isRead)
			{
				throw new NotSupportedException();
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0 || offset > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (size < 0 || size > buffer.Length - offset)
			{
				throw new ArgumentOutOfRangeException("offset+size");
			}
			FtpDataStream.ReadDelegate readDelegate = new FtpDataStream.ReadDelegate(this.ReadInternal);
			return readDelegate.BeginInvoke(buffer, offset, size, cb, state);
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x000514BC File Offset: 0x0004F6BC
		public override int EndRead(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			AsyncResult asyncResult2 = asyncResult as AsyncResult;
			if (asyncResult2 == null)
			{
				throw new ArgumentException("Invalid asyncResult", "asyncResult");
			}
			FtpDataStream.ReadDelegate readDelegate = asyncResult2.AsyncDelegate as FtpDataStream.ReadDelegate;
			if (readDelegate == null)
			{
				throw new ArgumentException("Invalid asyncResult", "asyncResult");
			}
			return readDelegate.EndInvoke(asyncResult);
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x00051520 File Offset: 0x0004F720
		public override int Read(byte[] buffer, int offset, int size)
		{
			this.request.CheckIfAborted();
			IAsyncResult asyncResult = this.BeginRead(buffer, offset, size, null, null);
			if (!asyncResult.IsCompleted && !asyncResult.AsyncWaitHandle.WaitOne(this.request.ReadWriteTimeout, false))
			{
				throw new WebException("Read timed out.", WebExceptionStatus.Timeout);
			}
			return this.EndRead(asyncResult);
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x00051580 File Offset: 0x0004F780
		private void WriteInternal(byte[] buffer, int offset, int size)
		{
			this.request.CheckIfAborted();
			try
			{
				this.networkStream.Write(buffer, offset, size);
			}
			catch (IOException)
			{
				throw new ProtocolViolationException();
			}
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x000515C8 File Offset: 0x0004F7C8
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state)
		{
			this.CheckDisposed();
			if (this.isRead)
			{
				throw new NotSupportedException();
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0 || offset > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (size < 0 || size > buffer.Length - offset)
			{
				throw new ArgumentOutOfRangeException("offset+size");
			}
			FtpDataStream.WriteDelegate writeDelegate = new FtpDataStream.WriteDelegate(this.WriteInternal);
			return writeDelegate.BeginInvoke(buffer, offset, size, cb, state);
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x00051650 File Offset: 0x0004F850
		public override void EndWrite(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			AsyncResult asyncResult2 = asyncResult as AsyncResult;
			if (asyncResult2 == null)
			{
				throw new ArgumentException("Invalid asyncResult.", "asyncResult");
			}
			FtpDataStream.WriteDelegate writeDelegate = asyncResult2.AsyncDelegate as FtpDataStream.WriteDelegate;
			if (writeDelegate == null)
			{
				throw new ArgumentException("Invalid asyncResult.", "asyncResult");
			}
			writeDelegate.EndInvoke(asyncResult);
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x000516B4 File Offset: 0x0004F8B4
		public override void Write(byte[] buffer, int offset, int size)
		{
			this.request.CheckIfAborted();
			IAsyncResult asyncResult = this.BeginWrite(buffer, offset, size, null, null);
			if (!asyncResult.IsCompleted && !asyncResult.AsyncWaitHandle.WaitOne(this.request.ReadWriteTimeout, false))
			{
				throw new WebException("Read timed out.", WebExceptionStatus.Timeout);
			}
			this.EndWrite(asyncResult);
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x00051714 File Offset: 0x0004F914
		~FtpDataStream()
		{
			this.Dispose(false);
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x00051744 File Offset: 0x0004F944
		protected override void Dispose(bool disposing)
		{
			if (this.disposed)
			{
				return;
			}
			this.disposed = true;
			if (this.networkStream != null)
			{
				this.request.CloseDataConnection();
				this.request.SetTransferCompleted();
				this.request = null;
				this.networkStream = null;
			}
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x00013C9B File Offset: 0x00011E9B
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
		}

		// Token: 0x0400108E RID: 4238
		private FtpWebRequest request;

		// Token: 0x0400108F RID: 4239
		private Stream networkStream;

		// Token: 0x04001090 RID: 4240
		private bool disposed;

		// Token: 0x04001091 RID: 4241
		private bool isRead;

		// Token: 0x04001092 RID: 4242
		private int totalRead;

		// Token: 0x0200031D RID: 797
		// (Invoke) Token: 0x06001B33 RID: 6963
		private delegate void WriteDelegate(byte[] buffer, int offset, int size);

		// Token: 0x0200031E RID: 798
		// (Invoke) Token: 0x06001B37 RID: 6967
		private delegate int ReadDelegate(byte[] buffer, int offset, int size);
	}
}
