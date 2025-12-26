using System;
using System.IO;
using System.Threading;

namespace System.Net
{
	// Token: 0x0200042B RID: 1067
	internal class WebAsyncResult : IAsyncResult
	{
		// Token: 0x0600251A RID: 9498 RVA: 0x0001A06F File Offset: 0x0001826F
		public WebAsyncResult(AsyncCallback cb, object state)
		{
			this.cb = cb;
			this.state = state;
		}

		// Token: 0x0600251B RID: 9499 RVA: 0x0001A090 File Offset: 0x00018290
		public WebAsyncResult(HttpWebRequest request, AsyncCallback cb, object state)
		{
			this.cb = cb;
			this.state = state;
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x0001A0B1 File Offset: 0x000182B1
		public WebAsyncResult(AsyncCallback cb, object state, byte[] buffer, int offset, int size)
		{
			this.cb = cb;
			this.state = state;
			this.buffer = buffer;
			this.offset = offset;
			this.size = size;
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x0006C1B4 File Offset: 0x0006A3B4
		internal void SetCompleted(bool synch, Exception e)
		{
			this.synch = synch;
			this.exc = e;
			object obj = this.locker;
			lock (obj)
			{
				this.isCompleted = true;
				if (this.handle != null)
				{
					this.handle.Set();
				}
			}
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x0006C218 File Offset: 0x0006A418
		internal void Reset()
		{
			this.callbackDone = false;
			this.exc = null;
			this.response = null;
			this.writeStream = null;
			this.exc = null;
			object obj = this.locker;
			lock (obj)
			{
				this.isCompleted = false;
				if (this.handle != null)
				{
					this.handle.Reset();
				}
			}
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x0006C290 File Offset: 0x0006A490
		internal void SetCompleted(bool synch, int nbytes)
		{
			this.synch = synch;
			this.nbytes = nbytes;
			this.exc = null;
			object obj = this.locker;
			lock (obj)
			{
				this.isCompleted = true;
				if (this.handle != null)
				{
					this.handle.Set();
				}
			}
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x0006C2FC File Offset: 0x0006A4FC
		internal void SetCompleted(bool synch, Stream writeStream)
		{
			this.synch = synch;
			this.writeStream = writeStream;
			this.exc = null;
			object obj = this.locker;
			lock (obj)
			{
				this.isCompleted = true;
				if (this.handle != null)
				{
					this.handle.Set();
				}
			}
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x0006C368 File Offset: 0x0006A568
		internal void SetCompleted(bool synch, HttpWebResponse response)
		{
			this.synch = synch;
			this.response = response;
			this.exc = null;
			object obj = this.locker;
			lock (obj)
			{
				this.isCompleted = true;
				if (this.handle != null)
				{
					this.handle.Set();
				}
			}
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x0001A0E9 File Offset: 0x000182E9
		internal void DoCallback()
		{
			if (!this.callbackDone && this.cb != null)
			{
				this.callbackDone = true;
				this.cb(this);
			}
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x0001A114 File Offset: 0x00018314
		internal void WaitUntilComplete()
		{
			if (this.IsCompleted)
			{
				return;
			}
			this.AsyncWaitHandle.WaitOne();
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x0001A12E File Offset: 0x0001832E
		internal bool WaitUntilComplete(int timeout, bool exitContext)
		{
			return this.IsCompleted || this.AsyncWaitHandle.WaitOne(timeout, exitContext);
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002525 RID: 9509 RVA: 0x0001A14A File Offset: 0x0001834A
		public object AsyncState
		{
			get
			{
				return this.state;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x0006C3D4 File Offset: 0x0006A5D4
		public WaitHandle AsyncWaitHandle
		{
			get
			{
				object obj = this.locker;
				lock (obj)
				{
					if (this.handle == null)
					{
						this.handle = new ManualResetEvent(this.isCompleted);
					}
				}
				return this.handle;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002527 RID: 9511 RVA: 0x0001A152 File Offset: 0x00018352
		public bool CompletedSynchronously
		{
			get
			{
				return this.synch;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x0006C42C File Offset: 0x0006A62C
		public bool IsCompleted
		{
			get
			{
				object obj = this.locker;
				bool flag;
				lock (obj)
				{
					flag = this.isCompleted;
				}
				return flag;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06002529 RID: 9513 RVA: 0x0001A15A File Offset: 0x0001835A
		internal bool GotException
		{
			get
			{
				return this.exc != null;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x0001A168 File Offset: 0x00018368
		internal Exception Exception
		{
			get
			{
				return this.exc;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x0600252B RID: 9515 RVA: 0x0001A170 File Offset: 0x00018370
		// (set) Token: 0x0600252C RID: 9516 RVA: 0x0001A178 File Offset: 0x00018378
		internal int NBytes
		{
			get
			{
				return this.nbytes;
			}
			set
			{
				this.nbytes = value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x0600252D RID: 9517 RVA: 0x0001A181 File Offset: 0x00018381
		// (set) Token: 0x0600252E RID: 9518 RVA: 0x0001A189 File Offset: 0x00018389
		internal IAsyncResult InnerAsyncResult
		{
			get
			{
				return this.innerAsyncResult;
			}
			set
			{
				this.innerAsyncResult = value;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x0001A192 File Offset: 0x00018392
		internal Stream WriteStream
		{
			get
			{
				return this.writeStream;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002530 RID: 9520 RVA: 0x0001A19A File Offset: 0x0001839A
		internal HttpWebResponse Response
		{
			get
			{
				return this.response;
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06002531 RID: 9521 RVA: 0x0001A1A2 File Offset: 0x000183A2
		internal byte[] Buffer
		{
			get
			{
				return this.buffer;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06002532 RID: 9522 RVA: 0x0001A1AA File Offset: 0x000183AA
		internal int Offset
		{
			get
			{
				return this.offset;
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06002533 RID: 9523 RVA: 0x0001A1B2 File Offset: 0x000183B2
		internal int Size
		{
			get
			{
				return this.size;
			}
		}

		// Token: 0x040016FB RID: 5883
		private ManualResetEvent handle;

		// Token: 0x040016FC RID: 5884
		private bool synch;

		// Token: 0x040016FD RID: 5885
		private bool isCompleted;

		// Token: 0x040016FE RID: 5886
		private AsyncCallback cb;

		// Token: 0x040016FF RID: 5887
		private object state;

		// Token: 0x04001700 RID: 5888
		private int nbytes;

		// Token: 0x04001701 RID: 5889
		private IAsyncResult innerAsyncResult;

		// Token: 0x04001702 RID: 5890
		private bool callbackDone;

		// Token: 0x04001703 RID: 5891
		private Exception exc;

		// Token: 0x04001704 RID: 5892
		private HttpWebResponse response;

		// Token: 0x04001705 RID: 5893
		private Stream writeStream;

		// Token: 0x04001706 RID: 5894
		private byte[] buffer;

		// Token: 0x04001707 RID: 5895
		private int offset;

		// Token: 0x04001708 RID: 5896
		private int size;

		// Token: 0x04001709 RID: 5897
		private object locker = new object();

		// Token: 0x0400170A RID: 5898
		public bool EndCalled;

		// Token: 0x0400170B RID: 5899
		public bool AsyncWriteAll;
	}
}
