using System;
using System.Runtime.InteropServices;

namespace System.ComponentModel.Design
{
	/// <summary>Represents the method that will handle a <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentRename" /> event.</summary>
	/// <param name="sender">The source of the event. </param>
	/// <param name="e">A <see cref="T:System.ComponentModel.Design.ComponentRenameEventArgs" /> that contains the event data. </param>
	// Token: 0x02000506 RID: 1286
	// (Invoke) Token: 0x06002CCC RID: 11468
	[ComVisible(true)]
	public delegate void ComponentRenameEventHandler(object sender, ComponentRenameEventArgs e);
}
