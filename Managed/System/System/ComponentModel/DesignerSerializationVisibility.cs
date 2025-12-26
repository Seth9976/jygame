using System;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	/// <summary>Specifies the visibility a property has to the design-time serializer.</summary>
	// Token: 0x0200010D RID: 269
	[ComVisible(true)]
	public enum DesignerSerializationVisibility
	{
		/// <summary>The code generator does not produce code for the object.</summary>
		// Token: 0x040002E8 RID: 744
		Hidden,
		/// <summary>The code generator produces code for the object.</summary>
		// Token: 0x040002E9 RID: 745
		Visible,
		/// <summary>The code generator produces code for the contents of the object, rather than for the object itself.</summary>
		// Token: 0x040002EA RID: 746
		Content
	}
}
