using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the browsable state of a property or method from within an editor.</summary>
	// Token: 0x02000149 RID: 329
	public enum EditorBrowsableState
	{
		/// <summary>The property or method is always browsable from within an editor.</summary>
		// Token: 0x04000374 RID: 884
		Always,
		/// <summary>The property or method is never browsable from within an editor.</summary>
		// Token: 0x04000375 RID: 885
		Never,
		/// <summary>The property or method is a feature that only advanced users should see. An editor can either show or hide such properties.</summary>
		// Token: 0x04000376 RID: 886
		Advanced
	}
}
