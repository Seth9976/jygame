using System;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000347 RID: 839
	internal class ListenerAsyncResult : IAsyncResult
	{
		// Token: 0x06001D5C RID: 7516 RVA: 0x00015343 File Offset: 0x00013543
		public ListenerAsyncResult(AsyncCallback cb, object state)
		{
			this.cb = cb;
			this.state = state;
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x00059CDC File Offset: 0x00057EDC
		internal void Complete(string error)
		{
			if (this.forward != null)
			{
				this.forward.Complete(error);
				return;
			}
			this.exception = new HttpListenerException(0, error);
			object obj = this.locker;
			lock (obj)
			{
				this.completed = true;
				if (this.handle != null)
				{
					this.handle.Set();
				}
				if (this.cb != null)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(ListenerAsyncResult.InvokeCallback), this);
				}
			}
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x00059D74 File Offset: 0x00057F74
		private static void InvokeCallback(object o)
		{
			ListenerAsyncResult listenerAsyncResult = (ListenerAsyncResult)o;
			if (listenerAsyncResult.forward != null)
			{
				listenerAsyncResult.forward.cb(listenerAsyncResult);
				return;
			}
			listenerAsyncResult.cb(listenerAsyncResult);
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x00015364 File Offset: 0x00013564
		internal void Complete(HttpListenerContext context)
		{
			this.Complete(context, false);
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x00059DB4 File Offset: 0x00057FB4
		internal void Complete(HttpListenerContext context, bool synch)
		{
			if (this.forward != null)
			{
				this.forward.Complete(context, synch);
				return;
			}
			this.synch = synch;
			this.context = context;
			object obj = this.locker;
			lock (obj)
			{
				AuthenticationSchemes authenticationSchemes = context.Listener.SelectAuthenticationScheme(context);
				if ((authenticationSchemes == AuthenticationSchemes.Basic || context.Listener.AuthenticationSchemes == AuthenticationSchemes.Negotiate) && context.Request.Headers["Authorization"] == null)
				{
					context.Response.StatusCode = 401;
					context.Response.Headers["WWW-Authenticate"] = string.Concat(new object[]
					{
						authenticationSchemes,
						" realm=\"",
						context.Listener.Realm,
						"\""
					});
					context.Response.OutputStream.Close();
					IAsyncResult asyncResult = context.Listener.BeginGetContext(this.cb, this.state);
					this.forward = (ListenerAsyncResult)asyncResult;
					object obj2 = this.forward.locker;
					lock (obj2)
					{
						if (this.handle != null)
						{
							this.forward.handle = this.handle;
						}
					}
					ListenerAsyncResult listenerAsyncResult = this.forward;
					int num = 0;
					while (listenerAsyncResult.forward != null)
					{
						if (num > 20)
						{
							this.Complete("Too many authentication errors");
						}
						listenerAsyncResult = listenerAsyncResult.forward;
						num++;
					}
				}
				else
				{
					this.completed = true;
					if (this.handle != null)
					{
						this.handle.Set();
					}
					if (this.cb != null)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(ListenerAsyncResult.InvokeCallback), this);
					}
				}
			}
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x0001536E File Offset: 0x0001356E
		internal HttpListenerContext GetContext()
		{
			if (this.forward != null)
			{
				return this.forward.GetContext();
			}
			if (this.exception != null)
			{
				throw this.exception;
			}
			return this.context;
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x0001539F File Offset: 0x0001359F
		public object AsyncState
		{
			get
			{
				if (this.forward != null)
				{
					return this.forward.AsyncState;
				}
				return this.state;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x00059FBC File Offset: 0x000581BC
		public WaitHandle AsyncWaitHandle
		{
			get
			{
				if (this.forward != null)
				{
					return this.forward.AsyncWaitHandle;
				}
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

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x000153BE File Offset: 0x000135BE
		public bool CompletedSynchronously
		{
			get
			{
				if (this.forward != null)
				{
					return this.forward.CompletedSynchronously;
				}
				return this.synch;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x0005A02C File Offset: 0x0005822C
		public bool IsCompleted
		{
			get
			{
				if (this.forward != null)
				{
					return this.forward.IsCompleted;
				}
				object obj = this.locker;
				bool flag;
				lock (obj)
				{
					flag = this.completed;
				}
				return flag;
			}
		}

		// Token: 0x04001234 RID: 4660
		private ManualResetEvent handle;

		// Token: 0x04001235 RID: 4661
		private bool synch;

		// Token: 0x04001236 RID: 4662
		private bool completed;

		// Token: 0x04001237 RID: 4663
		private AsyncCallback cb;

		// Token: 0x04001238 RID: 4664
		private object state;

		// Token: 0x04001239 RID: 4665
		private Exception exception;

		// Token: 0x0400123A RID: 4666
		private HttpListenerContext context;

		// Token: 0x0400123B RID: 4667
		private object locker = new object();

		// Token: 0x0400123C RID: 4668
		private ListenerAsyncResult forward;
	}
}
