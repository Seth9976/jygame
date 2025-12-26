using System;

namespace System.ComponentModel
{
	/// <summary>Specifies when the <see cref="T:System.ComponentModel.License" /> can be used.</summary>
	// Token: 0x0200017E RID: 382
	public enum LicenseUsageMode
	{
		/// <summary>Used during design time by a visual designer or the compiler.</summary>
		// Token: 0x0400039B RID: 923
		Designtime = 1,
		/// <summary>Used during runtime.</summary>
		// Token: 0x0400039C RID: 924
		Runtime = 0
	}
}
