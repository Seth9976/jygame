using System;

namespace System.ComponentModel
{
	/// <summary>Defines identifiers that indicate the type of a refresh of the Properties window.</summary>
	// Token: 0x020001A7 RID: 423
	public enum RefreshProperties
	{
		/// <summary>The properties should be requeried and the view should be refreshed.</summary>
		// Token: 0x0400043D RID: 1085
		All = 1,
		/// <summary>No refresh is necessary.</summary>
		// Token: 0x0400043E RID: 1086
		None = 0,
		/// <summary>The view should be refreshed.</summary>
		// Token: 0x0400043F RID: 1087
		Repaint = 2
	}
}
