using System;
using System.Runtime.InteropServices;

namespace System.ComponentModel.Design
{
	/// <summary>Provides data for the <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentAdded" />, <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentAdding" />, <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentRemoved" />, and <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentRemoving" /> events.</summary>
	// Token: 0x020000FD RID: 253
	[ComVisible(true)]
	public class ComponentEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.ComponentEventArgs" /> class.</summary>
		/// <param name="component">The component that is the source of the event. </param>
		// Token: 0x06000A36 RID: 2614 RVA: 0x00009829 File Offset: 0x00007A29
		public ComponentEventArgs(IComponent component)
		{
			this.icomp = component;
		}

		/// <summary>Gets the component associated with the event.</summary>
		/// <returns>The component associated with the event.</returns>
		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x00009838 File Offset: 0x00007A38
		public virtual IComponent Component
		{
			get
			{
				return this.icomp;
			}
		}

		// Token: 0x040002C5 RID: 709
		private IComponent icomp;
	}
}
