using System;
using System.IO;
using System.Threading;

namespace System.Net
{
	// Token: 0x0200031B RID: 795
	internal class FtpAsyncResult : IAsyncResult
	{
		// Token: 0x06001B08 RID: 6920 RVA: 0x00013B7F File Offset: 0x00011D7F
		public FtpAsyncResult(AsyncCallback callback, object state)
		{
			this.callback = callback;
			this.state = state;
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x00013BA0 File Offset: 0x00011DA0
		public object AsyncState
		{
			get
			{
				return this.state;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x000511F8 File Offset: 0x0004F3F8
		public WaitHandle AsyncWaitHandle
		{
			get
			{
				object obj = this.locker;
				lock (obj)
				{
					if (this.waitHandle == null)
					{
						this.waitHandle = new ManualResetEvent(false);
					}
				}
				return this.waitHandle;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x00013BA8 File Offset: 0x00011DA8
		public bool CompletedSynchronously
		{
			get
			{
				return this.synch;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x0005124C File Offset: 0x0004F44C
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

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x00013BB0 File Offset: 0x00011DB0
		internal bool GotException
		{
			get
			{
				return this.exception != null;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x00013BBE File Offset: 0x00011DBE
		internal Exception Exception
		{
			get
			{
				return this.exception;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x00013BC6 File Offset: 0x00011DC6
		// (set) Token: 0x06001B10 RID: 6928 RVA: 0x00013BCE File Offset: 0x00011DCE
		internal FtpWebResponse Response
		{
			get
			{
				return this.response;
			}
			set
			{
				this.response = value;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001B11 RID: 6929 RVA: 0x00013BD7 File Offset: 0x00011DD7
		// (set) Token: 0x06001B12 RID: 6930 RVA: 0x00013BDF File Offset: 0x00011DDF
		internal Stream Stream
		{
			get
			{
				return this.stream;
			}
			set
			{
				this.stream = value;
			}
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x00013BE8 File Offset: 0x00011DE8
		internal void WaitUntilComplete()
		{
			if (this.IsCompleted)
			{
				return;
			}
			this.AsyncWaitHandle.WaitOne();
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x00013C02 File Offset: 0x00011E02
		internal bool WaitUntilComplete(int timeout, bool exitContext)
		{
			return this.IsCompleted || this.AsyncWaitHandle.WaitOne(timeout, exitContext);
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x00051290 File Offset: 0x0004F490
		internal void SetCompleted(bool synch, Exception exc, FtpWebResponse response)
		{
			this.synch = synch;
			this.exception = exc;
			this.response = response;
			object obj = this.locker;
			lock (obj)
			{
				this.completed = true;
				if (this.waitHandle != null)
				{
					this.waitHandle.Set();
				}
			}
			this.DoCallback();
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x00013C1E File Offset: 0x00011E1E
		internal void SetCompleted(bool synch, FtpWebResponse response)
		{
			this.SetCompleted(synch, null, response);
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x00013C29 File Offset: 0x00011E29
		internal void SetCompleted(bool synch, Exception exc)
		{
			this.SetCompleted(synch, exc, null);
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x00051300 File Offset: 0x0004F500
		internal void DoCallback()
		{
			if (this.callback != null)
			{
				try
				{
					this.callback(this);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x00051340 File Offset: 0x0004F540
		internal void Reset()
		{
			this.exception = null;
			this.synch = false;
			this.response = null;
			this.state = null;
			object obj = this.locker;
			lock (obj)
			{
				this.completed = false;
				if (this.waitHandle != null)
				{
					this.waitHandle.Reset();
				}
			}
		}

		// Token: 0x04001085 RID: 4229
		private FtpWebResponse response;

		// Token: 0x04001086 RID: 4230
		private ManualResetEvent waitHandle;

		// Token: 0x04001087 RID: 4231
		private Exception exception;

		// Token: 0x04001088 RID: 4232
		private AsyncCallback callback;

		// Token: 0x04001089 RID: 4233
		private Stream stream;

		// Token: 0x0400108A RID: 4234
		private object state;

		// Token: 0x0400108B RID: 4235
		private bool completed;

		// Token: 0x0400108C RID: 4236
		private bool synch;

		// Token: 0x0400108D RID: 4237
		private object locker = new object();
	}
}
