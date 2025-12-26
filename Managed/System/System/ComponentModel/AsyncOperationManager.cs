using System;
using System.Security.Permissions;
using System.Threading;

namespace System.ComponentModel
{
	/// <summary>Provides concurrency management for classes that support asynchronous method calls. This class cannot be inherited.</summary>
	// Token: 0x020000CD RID: 205
	public static class AsyncOperationManager
	{
		/// <summary>Gets or sets the synchronization context for the asynchronous operation.</summary>
		/// <returns>The synchronization context for the asynchronous operation.</returns>
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x000084DA File Offset: 0x000066DA
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x000084F5 File Offset: 0x000066F5
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static SynchronizationContext SynchronizationContext
		{
			get
			{
				if (SynchronizationContext.Current == null)
				{
					SynchronizationContext.SetSynchronizationContext(new SynchronizationContext());
				}
				return SynchronizationContext.Current;
			}
			[PermissionSet(SecurityAction.LinkDemand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\">\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\nversion=\"1\"\nFlags=\"NoFlags\"/>\n</PermissionSet>\n")]
			set
			{
				SynchronizationContext.SetSynchronizationContext(value);
			}
		}

		/// <summary>Returns an <see cref="T:System.ComponentModel.AsyncOperation" /> for tracking the duration of a particular asynchronous operation.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.AsyncOperation" /> that you can use to track the duration of an asynchronous method invocation.</returns>
		/// <param name="userSuppliedState">An object used to associate a piece of client state, such as a task ID, with a particular asynchronous operation. </param>
		// Token: 0x060008C2 RID: 2242 RVA: 0x000084FD File Offset: 0x000066FD
		public static AsyncOperation CreateOperation(object userSuppliedState)
		{
			return new AsyncOperation(AsyncOperationManager.SynchronizationContext, userSuppliedState);
		}
	}
}
