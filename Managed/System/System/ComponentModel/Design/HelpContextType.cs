using System;

namespace System.ComponentModel.Design
{
	/// <summary>Defines identifiers that indicate information about the context in which a request for Help information originated.</summary>
	// Token: 0x0200010E RID: 270
	public enum HelpContextType
	{
		/// <summary>A general context.</summary>
		// Token: 0x040002EC RID: 748
		Ambient,
		/// <summary>A window.</summary>
		// Token: 0x040002ED RID: 749
		Window,
		/// <summary>A selection.</summary>
		// Token: 0x040002EE RID: 750
		Selection,
		/// <summary>A tool window selection.</summary>
		// Token: 0x040002EF RID: 751
		ToolWindowSelection
	}
}
