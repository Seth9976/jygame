using System;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000335 RID: 821
	internal class HttpStreamAsyncResult : IAsyncResult
	{
		// Token: 0x06001C59 RID: 7257 RVA: 0x00014972 File Offset: 0x00012B72
		public void Complete(Exception e)
		{
			this.Error = e;
			this.Complete();
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x000555D8 File Offset: 0x000537D8
		public void Complete()
		{
			object obj = this.locker;
			lock (obj)
			{
				if (!this.completed)
				{
					this.completed = true;
					if (this.handle != null)
					{
						this.handle.Set();
					}
					if (this.Callback != null)
					{
						this.Callback.BeginInvoke(this, null, null);
					}
				}
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x00014981 File Offset: 0x00012B81
		public object AsyncState
		{
			get
			{
				return this.State;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x00055658 File Offset: 0x00053858
		public WaitHandle AsyncWaitHandle
		{
			get
			{
				object obj = this.locker;
				lock (obj)
				{
					if (this.handle == null)
					{
						this.handle = new ManualResetEvent(this.completed);
					}
				}
				return this.handle;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x00014989 File Offset: 0x00012B89
		public bool CompletedSynchronously
		{
			get
			{
				return this.SynchRead == this.Count;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x000556B0 File Offset: 0x000538B0
		public bool IsCompleted
		{
			get
			{
				object obj = this.locker;
				bool flag;
				lock (obj)
				{
					flag = this.completed;
				}
				return flag;
			}
		}

		// Token: 0x040011CB RID: 4555
		private object locker = new object();

		// Token: 0x040011CC RID: 4556
		private ManualResetEvent handle;

		// Token: 0x040011CD RID: 4557
		private bool completed;

		// Token: 0x040011CE RID: 4558
		internal byte[] Buffer;

		// Token: 0x040011CF RID: 4559
		internal int Offset;

		// Token: 0x040011D0 RID: 4560
		internal int Count;

		// Token: 0x040011D1 RID: 4561
		internal AsyncCallback Callback;

		// Token: 0x040011D2 RID: 4562
		internal object State;

		// Token: 0x040011D3 RID: 4563
		internal int SynchRead;

		// Token: 0x040011D4 RID: 4564
		internal Exception Error;
	}
}
