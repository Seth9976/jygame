using System;
using System.Runtime.Remoting.Messaging;

namespace System.IO
{
	// Token: 0x0200029E RID: 670
	internal class MonoSyncFileStream : FileStream
	{
		// Token: 0x06001723 RID: 5923 RVA: 0x000115C5 File Offset: 0x0000F7C5
		public MonoSyncFileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize)
			: base(handle, access, ownsHandle, bufferSize, false)
		{
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x000484F4 File Offset: 0x000466F4
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			if (!this.CanWrite)
			{
				throw new NotSupportedException("This stream does not support writing");
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Must be >= 0");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Must be >= 0");
			}
			MonoSyncFileStream.WriteDelegate writeDelegate = new MonoSyncFileStream.WriteDelegate(this.Write);
			return writeDelegate.BeginInvoke(buffer, offset, count, cback, state);
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00048574 File Offset: 0x00046774
		public override void EndWrite(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			AsyncResult asyncResult2 = asyncResult as AsyncResult;
			if (asyncResult2 == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", "asyncResult");
			}
			MonoSyncFileStream.WriteDelegate writeDelegate = asyncResult2.AsyncDelegate as MonoSyncFileStream.WriteDelegate;
			if (writeDelegate == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", "asyncResult");
			}
			writeDelegate.EndInvoke(asyncResult);
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x000485D8 File Offset: 0x000467D8
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			if (!this.CanRead)
			{
				throw new NotSupportedException("This stream does not support reading");
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Must be >= 0");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Must be >= 0");
			}
			MonoSyncFileStream.ReadDelegate readDelegate = new MonoSyncFileStream.ReadDelegate(this.Read);
			return readDelegate.BeginInvoke(buffer, offset, count, cback, state);
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x00048658 File Offset: 0x00046858
		public override int EndRead(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			AsyncResult asyncResult2 = asyncResult as AsyncResult;
			if (asyncResult2 == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", "asyncResult");
			}
			MonoSyncFileStream.ReadDelegate readDelegate = asyncResult2.AsyncDelegate as MonoSyncFileStream.ReadDelegate;
			if (readDelegate == null)
			{
				throw new ArgumentException("Invalid IAsyncResult", "asyncResult");
			}
			return readDelegate.EndInvoke(asyncResult);
		}

		// Token: 0x0200029F RID: 671
		// (Invoke) Token: 0x06001729 RID: 5929
		private delegate void WriteDelegate(byte[] buffer, int offset, int count);

		// Token: 0x020002A0 RID: 672
		// (Invoke) Token: 0x0600172D RID: 5933
		private delegate int ReadDelegate(byte[] buffer, int offset, int count);
	}
}
