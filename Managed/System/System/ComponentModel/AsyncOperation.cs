using System;
using System.Threading;

namespace System.ComponentModel
{
	/// <summary>Tracks the lifetime of an asynchronous operation.</summary>
	// Token: 0x020000CC RID: 204
	public sealed class AsyncOperation
	{
		// Token: 0x060008B8 RID: 2232 RVA: 0x00008439 File Offset: 0x00006639
		internal AsyncOperation(SynchronizationContext ctx, object state)
		{
			this.ctx = ctx;
			this.state = state;
			ctx.OperationStarted();
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x0002E8B4 File Offset: 0x0002CAB4
		~AsyncOperation()
		{
			if (!this.done && this.ctx != null)
			{
				this.ctx.OperationCompleted();
			}
		}

		/// <summary>Gets the <see cref="T:System.Threading.SynchronizationContext" /> object that was passed to the constructor.</summary>
		/// <returns>The <see cref="T:System.Threading.SynchronizationContext" /> object that was passed to the constructor.</returns>
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x00008455 File Offset: 0x00006655
		public SynchronizationContext SynchronizationContext
		{
			get
			{
				return this.ctx;
			}
		}

		/// <summary>Gets or sets an object used to uniquely identify an asynchronous operation.</summary>
		/// <returns>The state object passed to the asynchronous method invocation.</returns>
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x0000845D File Offset: 0x0000665D
		public object UserSuppliedState
		{
			get
			{
				return this.state;
			}
		}

		/// <summary>Ends the lifetime of an asynchronous operation.</summary>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="M:System.ComponentModel.AsyncOperation.OperationCompleted" /> has been called previously for this task. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x060008BC RID: 2236 RVA: 0x00008465 File Offset: 0x00006665
		public void OperationCompleted()
		{
			if (this.done)
			{
				throw new InvalidOperationException("This task is already completed. Multiple call to OperationCompleted is not allowed.");
			}
			this.ctx.OperationCompleted();
			this.done = true;
		}

		/// <summary>Invokes a delegate on the thread or context appropriate for the application model.</summary>
		/// <param name="d">A <see cref="T:System.Threading.SendOrPostCallback" /> object that wraps the delegate to be called when the operation ends. </param>
		/// <param name="arg">An argument for the delegate contained in the <paramref name="d" /> parameter. </param>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="M:System.ComponentModel.AsyncOperation.PostOperationCompleted(System.Threading.SendOrPostCallback,System.Object)" /> method has been called previously for this task. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="d" /> is null. </exception>
		// Token: 0x060008BD RID: 2237 RVA: 0x0000848F File Offset: 0x0000668F
		public void Post(SendOrPostCallback d, object arg)
		{
			if (this.done)
			{
				throw new InvalidOperationException("This task is already completed. Multiple call to Post is not allowed.");
			}
			this.ctx.Post(d, arg);
		}

		/// <summary>Ends the lifetime of an asynchronous operation.</summary>
		/// <param name="d">A <see cref="T:System.Threading.SendOrPostCallback" /> object that wraps the delegate to be called when the operation ends. </param>
		/// <param name="arg">An argument for the delegate contained in the <paramref name="d" /> parameter. </param>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="M:System.ComponentModel.AsyncOperation.OperationCompleted" /> has been called previously for this task. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="d" /> is null. </exception>
		// Token: 0x060008BE RID: 2238 RVA: 0x000084B4 File Offset: 0x000066B4
		public void PostOperationCompleted(SendOrPostCallback d, object arg)
		{
			if (this.done)
			{
				throw new InvalidOperationException("This task is already completed. Multiple call to PostOperationCompleted is not allowed.");
			}
			this.Post(d, arg);
			this.OperationCompleted();
		}

		// Token: 0x0400024F RID: 591
		private SynchronizationContext ctx;

		// Token: 0x04000250 RID: 592
		private object state;

		// Token: 0x04000251 RID: 593
		private bool done;
	}
}
