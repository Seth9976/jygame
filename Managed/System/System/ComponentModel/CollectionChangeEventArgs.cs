using System;

namespace System.ComponentModel
{
	/// <summary>Provides data for the <see cref="E:System.Data.DataColumnCollection.CollectionChanged" /> event.</summary>
	// Token: 0x020000DE RID: 222
	public class CollectionChangeEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.CollectionChangeEventArgs" /> class.</summary>
		/// <param name="action">One of the <see cref="T:System.ComponentModel.CollectionChangeAction" /> values that specifies how the collection changed. </param>
		/// <param name="element">An <see cref="T:System.Object" /> that specifies the instance of the collection where the change occurred. </param>
		// Token: 0x0600096D RID: 2413 RVA: 0x00008D86 File Offset: 0x00006F86
		public CollectionChangeEventArgs(CollectionChangeAction action, object element)
		{
			this.changeAction = action;
			this.theElement = element;
		}

		/// <summary>Gets an action that specifies how the collection changed.</summary>
		/// <returns>One of the <see cref="T:System.ComponentModel.CollectionChangeAction" /> values.</returns>
		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x00008D9C File Offset: 0x00006F9C
		public virtual CollectionChangeAction Action
		{
			get
			{
				return this.changeAction;
			}
		}

		/// <summary>Gets the instance of the collection with the change.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the instance of the collection with the change, or null if you refresh the collection.</returns>
		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x00008DA4 File Offset: 0x00006FA4
		public virtual object Element
		{
			get
			{
				return this.theElement;
			}
		}

		// Token: 0x0400028F RID: 655
		private CollectionChangeAction changeAction;

		// Token: 0x04000290 RID: 656
		private object theElement;
	}
}
