using System;
using System.ComponentModel;

namespace System.Diagnostics
{
	/// <summary>Identifies the type of event that has caused the trace.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000261 RID: 609
	public enum TraceEventType
	{
		/// <summary>Fatal error or application crash.</summary>
		// Token: 0x04000697 RID: 1687
		Critical = 1,
		/// <summary>Recoverable error.</summary>
		// Token: 0x04000698 RID: 1688
		Error,
		/// <summary>Noncritical problem.</summary>
		// Token: 0x04000699 RID: 1689
		Warning = 4,
		/// <summary>Informational message.</summary>
		// Token: 0x0400069A RID: 1690
		Information = 8,
		/// <summary>Debugging trace.</summary>
		// Token: 0x0400069B RID: 1691
		Verbose = 16,
		/// <summary>Starting of a logical operation.</summary>
		// Token: 0x0400069C RID: 1692
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		Start = 256,
		/// <summary>Stopping of a logical operation.</summary>
		// Token: 0x0400069D RID: 1693
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		Stop = 512,
		/// <summary>Suspension of a logical operation.</summary>
		// Token: 0x0400069E RID: 1694
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		Suspend = 1024,
		/// <summary>Resumption of a logical operation.</summary>
		// Token: 0x0400069F RID: 1695
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		Resume = 2048,
		/// <summary>Changing of correlation identity.</summary>
		// Token: 0x040006A0 RID: 1696
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		Transfer = 4096
	}
}
