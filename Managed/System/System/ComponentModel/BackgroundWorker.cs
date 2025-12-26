using System;
using System.Threading;

namespace System.ComponentModel
{
	/// <summary>Executes an operation on a separate thread.</summary>
	// Token: 0x020000D0 RID: 208
	[DefaultEvent("DoWork")]
	public class BackgroundWorker : Component
	{
		/// <summary>Occurs when <see cref="M:System.ComponentModel.BackgroundWorker.RunWorkerAsync" /> is called.</summary>
		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060008DB RID: 2267 RVA: 0x000085F7 File Offset: 0x000067F7
		// (remove) Token: 0x060008DC RID: 2268 RVA: 0x00008610 File Offset: 0x00006810
		public event DoWorkEventHandler DoWork;

		/// <summary>Occurs when <see cref="M:System.ComponentModel.BackgroundWorker.ReportProgress(System.Int32)" /> is called.</summary>
		// Token: 0x14000018 RID: 24
		// (add) Token: 0x060008DD RID: 2269 RVA: 0x00008629 File Offset: 0x00006829
		// (remove) Token: 0x060008DE RID: 2270 RVA: 0x00008642 File Offset: 0x00006842
		public event ProgressChangedEventHandler ProgressChanged;

		/// <summary>Occurs when the background operation has completed, has been canceled, or has raised an exception.</summary>
		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060008DF RID: 2271 RVA: 0x0000865B File Offset: 0x0000685B
		// (remove) Token: 0x060008E0 RID: 2272 RVA: 0x00008674 File Offset: 0x00006874
		public event RunWorkerCompletedEventHandler RunWorkerCompleted;

		/// <summary>Gets a value indicating whether the application has requested cancellation of a background operation.</summary>
		/// <returns>true if the application has requested cancellation of a background operation; otherwise, false. The default is false.</returns>
		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x0000868D File Offset: 0x0000688D
		[Browsable(false)]
		public bool CancellationPending
		{
			get
			{
				return this.cancel_pending;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.ComponentModel.BackgroundWorker" /> is running an asynchronous operation.</summary>
		/// <returns>true, if the <see cref="T:System.ComponentModel.BackgroundWorker" /> is running an asynchronous operation; otherwise, false.</returns>
		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x00008695 File Offset: 0x00006895
		[Browsable(false)]
		public bool IsBusy
		{
			get
			{
				return this.async != null;
			}
		}

		/// <summary>Gets or sets a value indicating whether the <see cref="T:System.ComponentModel.BackgroundWorker" /> can report progress updates.</summary>
		/// <returns>true if the <see cref="T:System.ComponentModel.BackgroundWorker" /> supports progress updates; otherwise false. The default is false.</returns>
		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x000086A3 File Offset: 0x000068A3
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x000086AB File Offset: 0x000068AB
		[DefaultValue(false)]
		public bool WorkerReportsProgress
		{
			get
			{
				return this.report_progress;
			}
			set
			{
				this.report_progress = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether the <see cref="T:System.ComponentModel.BackgroundWorker" /> supports asynchronous cancellation.</summary>
		/// <returns>true if the <see cref="T:System.ComponentModel.BackgroundWorker" /> supports cancellation; otherwise false. The default is false.</returns>
		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x000086B4 File Offset: 0x000068B4
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x000086BC File Offset: 0x000068BC
		[DefaultValue(false)]
		public bool WorkerSupportsCancellation
		{
			get
			{
				return this.support_cancel;
			}
			set
			{
				this.support_cancel = value;
			}
		}

		/// <summary>Requests cancellation of a pending background operation.</summary>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="P:System.ComponentModel.BackgroundWorker.WorkerSupportsCancellation" /> is false. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x060008E7 RID: 2279 RVA: 0x000086C5 File Offset: 0x000068C5
		public void CancelAsync()
		{
			if (!this.support_cancel)
			{
				throw new InvalidOperationException("This background worker does not support cancellation.");
			}
			if (!this.IsBusy)
			{
				return;
			}
			this.cancel_pending = true;
		}

		/// <summary>Raises the <see cref="E:System.ComponentModel.BackgroundWorker.ProgressChanged" /> event.</summary>
		/// <param name="percentProgress">The percentage, from 0 to 100, of the background operation that is complete. </param>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.ComponentModel.BackgroundWorker.WorkerReportsProgress" /> property is set to false. </exception>
		// Token: 0x060008E8 RID: 2280 RVA: 0x000086F0 File Offset: 0x000068F0
		public void ReportProgress(int percentProgress)
		{
			this.ReportProgress(percentProgress, null);
		}

		/// <summary>Raises the <see cref="E:System.ComponentModel.BackgroundWorker.ProgressChanged" /> event.</summary>
		/// <param name="percentProgress">The percentage, from 0 to 100, of the background operation that is complete.</param>
		/// <param name="userState">The state object passed to <see cref="M:System.ComponentModel.BackgroundWorker.RunWorkerAsync(System.Object)" />.</param>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.ComponentModel.BackgroundWorker.WorkerReportsProgress" /> property is set to false. </exception>
		// Token: 0x060008E9 RID: 2281 RVA: 0x0002EBAC File Offset: 0x0002CDAC
		public void ReportProgress(int percentProgress, object userState)
		{
			if (!this.WorkerReportsProgress)
			{
				throw new InvalidOperationException("This background worker does not report progress.");
			}
			if (!this.IsBusy)
			{
				return;
			}
			this.async.Post(delegate(object o)
			{
				ProgressChangedEventArgs progressChangedEventArgs = o as ProgressChangedEventArgs;
				this.OnProgressChanged(progressChangedEventArgs);
			}, new ProgressChangedEventArgs(percentProgress, userState));
		}

		/// <summary>Starts execution of a background operation.</summary>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="P:System.ComponentModel.BackgroundWorker.IsBusy" /> is true.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x060008EA RID: 2282 RVA: 0x000086FA File Offset: 0x000068FA
		public void RunWorkerAsync()
		{
			this.RunWorkerAsync(null);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0002EBFC File Offset: 0x0002CDFC
		private void ProcessWorker(object argument, AsyncOperation async, SendOrPostCallback callback)
		{
			Exception ex = null;
			DoWorkEventArgs doWorkEventArgs = new DoWorkEventArgs(argument);
			try
			{
				this.OnDoWork(doWorkEventArgs);
			}
			catch (Exception ex2)
			{
				ex = ex2;
				doWorkEventArgs.Cancel = false;
			}
			callback(new object[]
			{
				new RunWorkerCompletedEventArgs(doWorkEventArgs.Result, ex, doWorkEventArgs.Cancel),
				async
			});
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0002EC64 File Offset: 0x0002CE64
		private void CompleteWorker(object state)
		{
			object[] array = (object[])state;
			RunWorkerCompletedEventArgs runWorkerCompletedEventArgs = array[0] as RunWorkerCompletedEventArgs;
			AsyncOperation asyncOperation = array[1] as AsyncOperation;
			SendOrPostCallback sendOrPostCallback = delegate(object darg)
			{
				this.async = null;
				this.OnRunWorkerCompleted(darg as RunWorkerCompletedEventArgs);
			};
			asyncOperation.PostOperationCompleted(sendOrPostCallback, runWorkerCompletedEventArgs);
			this.cancel_pending = false;
		}

		/// <summary>Starts execution of a background operation.</summary>
		/// <param name="argument">A parameter for use by the background operation to be executed in the <see cref="E:System.ComponentModel.BackgroundWorker.DoWork" /> event handler. </param>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="P:System.ComponentModel.BackgroundWorker.IsBusy" /> is true. </exception>
		// Token: 0x060008ED RID: 2285 RVA: 0x0002ECA8 File Offset: 0x0002CEA8
		public void RunWorkerAsync(object argument)
		{
			if (this.IsBusy)
			{
				throw new InvalidOperationException("The background worker is busy.");
			}
			this.async = AsyncOperationManager.CreateOperation(this);
			BackgroundWorker.ProcessWorkerEventHandler processWorkerEventHandler = new BackgroundWorker.ProcessWorkerEventHandler(this.ProcessWorker);
			processWorkerEventHandler.BeginInvoke(argument, this.async, new SendOrPostCallback(this.CompleteWorker), null, null);
		}

		/// <summary>Raises the <see cref="E:System.ComponentModel.BackgroundWorker.DoWork" /> event. </summary>
		/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
		// Token: 0x060008EE RID: 2286 RVA: 0x00008703 File Offset: 0x00006903
		protected virtual void OnDoWork(DoWorkEventArgs e)
		{
			if (this.DoWork != null)
			{
				this.DoWork(this, e);
			}
		}

		/// <summary>Raises the <see cref="E:System.ComponentModel.BackgroundWorker.ProgressChanged" /> event.</summary>
		/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data. </param>
		// Token: 0x060008EF RID: 2287 RVA: 0x0000871D File Offset: 0x0000691D
		protected virtual void OnProgressChanged(ProgressChangedEventArgs e)
		{
			if (this.ProgressChanged != null)
			{
				this.ProgressChanged(this, e);
			}
		}

		/// <summary>Raises the <see cref="E:System.ComponentModel.BackgroundWorker.RunWorkerCompleted" /> event.</summary>
		/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data. </param>
		// Token: 0x060008F0 RID: 2288 RVA: 0x00008737 File Offset: 0x00006937
		protected virtual void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e)
		{
			if (this.RunWorkerCompleted != null)
			{
				this.RunWorkerCompleted(this, e);
			}
		}

		// Token: 0x04000256 RID: 598
		private AsyncOperation async;

		// Token: 0x04000257 RID: 599
		private bool cancel_pending;

		// Token: 0x04000258 RID: 600
		private bool report_progress;

		// Token: 0x04000259 RID: 601
		private bool support_cancel;

		// Token: 0x020000D1 RID: 209
		// (Invoke) Token: 0x060008F4 RID: 2292
		private delegate void ProcessWorkerEventHandler(object argument, AsyncOperation async, SendOrPostCallback callback);
	}
}
