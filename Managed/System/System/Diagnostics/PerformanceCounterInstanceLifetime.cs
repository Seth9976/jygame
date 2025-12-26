using System;

namespace System.Diagnostics
{
	/// <summary>Specifies the lifetime of a performance counter instance.</summary>
	// Token: 0x0200023F RID: 575
	public enum PerformanceCounterInstanceLifetime
	{
		/// <summary>Remove the performance counter instance when no counters are using the process category.</summary>
		// Token: 0x040005BC RID: 1468
		Global,
		/// <summary>Remove the performance counter instance when the process is closed.</summary>
		// Token: 0x040005BD RID: 1469
		Process
	}
}
