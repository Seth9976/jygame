using System;
using System.Runtime.InteropServices;

namespace System.ComponentModel.Design
{
	/// <summary>Provides data for the <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentRename" /> event.</summary>
	// Token: 0x020000FE RID: 254
	[ComVisible(true)]
	public class ComponentRenameEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.ComponentRenameEventArgs" /> class.</summary>
		/// <param name="component">The component to be renamed. </param>
		/// <param name="oldName">The old name of the component. </param>
		/// <param name="newName">The new name of the component. </param>
		// Token: 0x06000A38 RID: 2616 RVA: 0x00009840 File Offset: 0x00007A40
		public ComponentRenameEventArgs(object component, string oldName, string newName)
		{
			this.component = component;
			this.oldName = oldName;
			this.newName = newName;
		}

		/// <summary>Gets the component that is being renamed.</summary>
		/// <returns>The component that is being renamed.</returns>
		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x0000985D File Offset: 0x00007A5D
		public object Component
		{
			get
			{
				return this.component;
			}
		}

		/// <summary>Gets the name of the component after the rename event.</summary>
		/// <returns>The name of the component after the rename event.</returns>
		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x00009865 File Offset: 0x00007A65
		public virtual string NewName
		{
			get
			{
				return this.newName;
			}
		}

		/// <summary>Gets the name of the component before the rename event.</summary>
		/// <returns>The previous name of the component.</returns>
		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0000986D File Offset: 0x00007A6D
		public virtual string OldName
		{
			get
			{
				return this.oldName;
			}
		}

		// Token: 0x040002C6 RID: 710
		private object component;

		// Token: 0x040002C7 RID: 711
		private string oldName;

		// Token: 0x040002C8 RID: 712
		private string newName;
	}
}
