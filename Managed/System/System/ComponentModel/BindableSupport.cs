using System;

namespace System.ComponentModel
{
	/// <summary>Specifies values to indicate whether a property can be bound to a data element or another property.</summary>
	// Token: 0x020000D4 RID: 212
	public enum BindableSupport
	{
		/// <summary>The property is not bindable at design time.</summary>
		// Token: 0x04000264 RID: 612
		No,
		/// <summary>The property is bindable at design time.</summary>
		// Token: 0x04000265 RID: 613
		Yes,
		/// <summary>The property is set to the default.</summary>
		// Token: 0x04000266 RID: 614
		Default
	}
}
