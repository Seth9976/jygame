using System;
using System.IO;
using System.Runtime.InteropServices;

namespace System.Net
{
	// Token: 0x020003F3 RID: 1011
	internal class RequestStream : Stream
	{
		// Token: 0x0600221C RID: 8732 RVA: 0x00018407 File Offset: 0x00016607
		internal RequestStream(Stream stream, byte[] buffer, int offset, int length)
			: this(stream, buffer, offset, length, -1L)
		{
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x00018416 File Offset: 0x00016616
		internal RequestStream(Stream stream, byte[] buffer, int offset, int length, long contentlength)
		{
			this.stream = stream;
			this.buffer = buffer;
			this.offset = offset;
			this.length = length;
			this.remaining_body = contentlength;
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x000025B7 File Offset: 0x000007B7
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x0600221F RID: 8735 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06002220 RID: 8736 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06002221 RID: 8737 RVA: 0x00006A38 File Offset: 0x00004C38
		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x00006A38 File Offset: 0x00004C38
		// (set) Token: 0x06002223 RID: 8739 RVA: 0x00006A38 File Offset: 0x00004C38
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

		// Token: 0x06002224 RID: 8740 RVA: 0x00018443 File Offset: 0x00016643
		public override void Close()
		{
			this.disposed = true;
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override void Flush()
		{
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x00062EB4 File Offset: 0x000610B4
		private int FillFromBuffer(byte[] buffer, int off, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (off < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "< 0");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "< 0");
			}
			int num = buffer.Length;
			if (off > num)
			{
				throw new ArgumentException("destination offset is beyond array size");
			}
			if (off > num - count)
			{
				throw new ArgumentException("Reading would overrun buffer");
			}
			if (this.remaining_body == 0L)
			{
				return -1;
			}
			if (this.length == 0)
			{
				return 0;
			}
			int num2 = Math.Min(this.length, count);
			if (this.remaining_body > 0L)
			{
				num2 = (int)Math.Min((long)num2, this.remaining_body);
			}
			if (this.offset > this.buffer.Length - num2)
			{
				num2 = Math.Min(num2, this.buffer.Length - this.offset);
			}
			if (num2 == 0)
			{
				return 0;
			}
			Buffer.BlockCopy(this.buffer, this.offset, buffer, off, num2);
			this.offset += num2;
			this.length -= num2;
			if (this.remaining_body > 0L)
			{
				this.remaining_body -= (long)num2;
			}
			return num2;
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x00062FF0 File Offset: 0x000611F0
		public override int Read([In] [Out] byte[] buffer, int offset, int count)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(typeof(RequestStream).ToString());
			}
			int num = this.FillFromBuffer(buffer, offset, count);
			if (num == -1)
			{
				return 0;
			}
			if (num > 0)
			{
				return num;
			}
			num = this.stream.Read(buffer, offset, count);
			if (num > 0 && this.remaining_body > 0L)
			{
				this.remaining_body -= (long)num;
			}
			return num;
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x0006306C File Offset: 0x0006126C
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(typeof(RequestStream).ToString());
			}
			int num = this.FillFromBuffer(buffer, offset, count);
			if (num > 0 || num == -1)
			{
				HttpStreamAsyncResult httpStreamAsyncResult = new HttpStreamAsyncResult();
				httpStreamAsyncResult.Buffer = buffer;
				httpStreamAsyncResult.Offset = offset;
				httpStreamAsyncResult.Count = count;
				httpStreamAsyncResult.Callback = cback;
				httpStreamAsyncResult.State = state;
				httpStreamAsyncResult.SynchRead = num;
				httpStreamAsyncResult.Complete();
				return httpStreamAsyncResult;
			}
			if (this.remaining_body >= 0L && (long)count > this.remaining_body)
			{
				count = (int)Math.Min(2147483647L, this.remaining_body);
			}
			return this.stream.BeginRead(buffer, offset, count, cback, state);
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x0006312C File Offset: 0x0006132C
		public override int EndRead(IAsyncResult ares)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(typeof(RequestStream).ToString());
			}
			if (ares == null)
			{
				throw new ArgumentNullException("async_result");
			}
			if (ares is HttpStreamAsyncResult)
			{
				HttpStreamAsyncResult httpStreamAsyncResult = (HttpStreamAsyncResult)ares;
				if (!ares.IsCompleted)
				{
					ares.AsyncWaitHandle.WaitOne();
				}
				return httpStreamAsyncResult.SynchRead;
			}
			int num = this.stream.EndRead(ares);
			if (this.remaining_body > 0L && num > 0)
			{
				this.remaining_body -= (long)num;
			}
			return num;
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x00006A38 File Offset: 0x00004C38
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x00006A38 File Offset: 0x00004C38
		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x00006A38 File Offset: 0x00004C38
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x00006A38 File Offset: 0x00004C38
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x00006A38 File Offset: 0x00004C38
		public override void EndWrite(IAsyncResult async_result)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04001506 RID: 5382
		private byte[] buffer;

		// Token: 0x04001507 RID: 5383
		private int offset;

		// Token: 0x04001508 RID: 5384
		private int length;

		// Token: 0x04001509 RID: 5385
		private long remaining_body;

		// Token: 0x0400150A RID: 5386
		private bool disposed;

		// Token: 0x0400150B RID: 5387
		private Stream stream;
	}
}
