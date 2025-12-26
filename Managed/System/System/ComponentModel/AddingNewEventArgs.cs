using System;

namespace System.ComponentModel
{
	/// <summary>Provides data for the <see cref="E:System.Windows.Forms.BindingSource.AddingNew" /> event.</summary>
	// Token: 0x020000C7 RID: 199
	public class AddingNewEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AddingNewEventArgs" /> class using no parameters.</summary>
		// Token: 0x06000894 RID: 2196 RVA: 0x00008243 File Offset: 0x00006443
		public AddingNewEventArgs()
			: this(null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AddingNewEventArgs" /> class using the specified object as the new item.</summary>
		/// <param name="newObject">An <see cref="T:System.Object" /> to use as the new item value.</param>
		// Token: 0x06000895 RID: 2197 RVA: 0x0000824C File Offset: 0x0000644C
		public AddingNewEventArgs(object newObject)
		{
			this.obj = newObject;
		}

		/// <summary>Gets or sets the object to be added to the binding list. </summary>
		/// <returns>The <see cref="T:System.Object" /> to be added as a new item to the associated collection. </returns>
		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x0000825B File Offset: 0x0000645B
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x00008263 File Offset: 0x00006463
		public object NewObject
		{
			get
			{
				return this.obj;
			}
			set
			{
				this.obj = value;
			}
		}

		// Token: 0x04000248 RID: 584
		private object obj;
	}
}
