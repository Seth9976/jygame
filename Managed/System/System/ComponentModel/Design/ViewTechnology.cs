using System;
using System.Runtime.InteropServices;

namespace System.ComponentModel.Design
{
	/// <summary>Defines identifiers for a set of technologies that designer hosts support.</summary>
	// Token: 0x02000143 RID: 323
	[ComVisible(true)]
	public enum ViewTechnology
	{
		/// <summary>Represents a mode in which the view object is passed directly to the development environment. </summary>
		// Token: 0x04000369 RID: 873
		[Obsolete("Use ViewTechnology.Default.")]
		Passthrough,
		/// <summary>Represents a mode in which a Windows Forms control object provides the display for the root designer. </summary>
		// Token: 0x0400036A RID: 874
		[Obsolete("Use ViewTechnology.Default.")]
		WindowsForms,
		/// <summary>Specifies the default view technology support. </summary>
		// Token: 0x0400036B RID: 875
		Default
	}
}
