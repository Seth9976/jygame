using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Net
{
	// Token: 0x020003F4 RID: 1012
	internal class ResponseStream : Stream
	{
		// Token: 0x0600222F RID: 8751 RVA: 0x0001844C File Offset: 0x0001664C
		internal ResponseStream(Stream stream, HttpListenerResponse response, bool ignore_errors)
		{
			this.response = response;
			this.ignore_errors = ignore_errors;
			this.stream = stream;
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06002231 RID: 8753 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06002233 RID: 8755 RVA: 0x000025B7 File Offset: 0x000007B7
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x00006A38 File Offset: 0x00004C38
		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06002235 RID: 8757 RVA: 0x00006A38 File Offset: 0x00004C38
		// (set) Token: 0x06002236 RID: 8758 RVA: 0x00006A38 File Offset: 0x00004C38
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

		// Token: 0x06002237 RID: 8759 RVA: 0x000631CC File Offset: 0x000613CC
		public override void Close()
		{
			if (!this.disposed)
			{
				this.disposed = true;
				MemoryStream headers = this.GetHeaders(true);
				bool sendChunked = this.response.SendChunked;
				if (headers != null)
				{
					long position = headers.Position;
					if (sendChunked && !this.trailer_sent)
					{
						byte[] array = ResponseStream.GetChunkSizeBytes(0, true);
						headers.Position = headers.Length;
						headers.Write(array, 0, array.Length);
					}
					this.InternalWrite(headers.GetBuffer(), (int)position, (int)(headers.Length - position));
					this.trailer_sent = true;
				}
				else if (sendChunked && !this.trailer_sent)
				{
					byte[] array = ResponseStream.GetChunkSizeBytes(0, true);
					this.InternalWrite(array, 0, array.Length);
					this.trailer_sent = true;
				}
				this.response.Close();
			}
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x00063298 File Offset: 0x00061498
		private MemoryStream GetHeaders(bool closing)
		{
			if (this.response.HeadersSent)
			{
				return null;
			}
			MemoryStream memoryStream = new MemoryStream();
			this.response.SendHeaders(closing, memoryStream);
			return memoryStream;
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override void Flush()
		{
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x000632CC File Offset: 0x000614CC
		private static byte[] GetChunkSizeBytes(int size, bool final)
		{
			string text = string.Format("{0:x}\r\n{1}", size, (!final) ? string.Empty : "\r\n");
			return Encoding.ASCII.GetBytes(text);
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x0006330C File Offset: 0x0006150C
		internal void InternalWrite(byte[] buffer, int offset, int count)
		{
			if (this.ignore_errors)
			{
				try
				{
					this.stream.Write(buffer, offset, count);
				}
				catch
				{
				}
			}
			else
			{
				this.stream.Write(buffer, offset, count);
			}
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x00063360 File Offset: 0x00061560
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().ToString());
			}
			MemoryStream headers = this.GetHeaders(false);
			bool sendChunked = this.response.SendChunked;
			if (headers != null)
			{
				long position = headers.Position;
				headers.Position = headers.Length;
				if (sendChunked)
				{
					byte[] array = ResponseStream.GetChunkSizeBytes(count, false);
					headers.Write(array, 0, array.Length);
				}
				int num = Math.Min(count, 16384 - (int)headers.Position + (int)position);
				headers.Write(buffer, offset, num);
				count -= num;
				offset += num;
				this.InternalWrite(headers.GetBuffer(), (int)position, (int)(headers.Length - position));
				headers.SetLength(0L);
				headers.Capacity = 0;
			}
			else if (sendChunked)
			{
				byte[] array = ResponseStream.GetChunkSizeBytes(count, false);
				this.InternalWrite(array, 0, array.Length);
			}
			if (count > 0)
			{
				this.InternalWrite(buffer, offset, count);
			}
			if (sendChunked)
			{
				this.InternalWrite(ResponseStream.crlf, 0, 2);
			}
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x00063468 File Offset: 0x00061668
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().ToString());
			}
			MemoryStream headers = this.GetHeaders(false);
			bool sendChunked = this.response.SendChunked;
			if (headers != null)
			{
				long position = headers.Position;
				headers.Position = headers.Length;
				if (sendChunked)
				{
					byte[] array = ResponseStream.GetChunkSizeBytes(count, false);
					headers.Write(array, 0, array.Length);
				}
				headers.Write(buffer, offset, count);
				buffer = headers.GetBuffer();
				offset = (int)position;
				count = (int)(headers.Position - position);
			}
			else if (sendChunked)
			{
				byte[] array = ResponseStream.GetChunkSizeBytes(count, false);
				this.InternalWrite(array, 0, array.Length);
			}
			return this.stream.BeginWrite(buffer, offset, count, cback, state);
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x0006352C File Offset: 0x0006172C
		public override void EndWrite(IAsyncResult ares)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().ToString());
			}
			if (this.ignore_errors)
			{
				try
				{
					this.stream.EndWrite(ares);
					if (this.response.SendChunked)
					{
						this.stream.Write(ResponseStream.crlf, 0, 2);
					}
				}
				catch
				{
				}
			}
			else
			{
				this.stream.EndWrite(ares);
				if (this.response.SendChunked)
				{
					this.stream.Write(ResponseStream.crlf, 0, 2);
				}
			}
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x00006A38 File Offset: 0x00004C38
		public override int Read([In] [Out] byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x00006A38 File Offset: 0x00004C38
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x00006A38 File Offset: 0x00004C38
		public override int EndRead(IAsyncResult ares)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x00006A38 File Offset: 0x00004C38
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x00006A38 File Offset: 0x00004C38
		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0400150C RID: 5388
		private HttpListenerResponse response;

		// Token: 0x0400150D RID: 5389
		private bool ignore_errors;

		// Token: 0x0400150E RID: 5390
		private bool disposed;

		// Token: 0x0400150F RID: 5391
		private bool trailer_sent;

		// Token: 0x04001510 RID: 5392
		private Stream stream;

		// Token: 0x04001511 RID: 5393
		private static byte[] crlf = new byte[] { 13, 10 };
	}
}
