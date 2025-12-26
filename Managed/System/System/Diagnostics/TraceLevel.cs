using System;

namespace System.Diagnostics
{
	/// <summary>Specifies what messages to output for the <see cref="T:System.Diagnostics.Debug" />, <see cref="T:System.Diagnostics.Trace" /> and <see cref="T:System.Diagnostics.TraceSwitch" /> classes.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000265 RID: 613
	public enum TraceLevel
	{
		/// <summary>Output no tracing and debugging messages.</summary>
		// Token: 0x040006AE RID: 1710
		Off,
		/// <summary>Output error-handling messages.</summary>
		// Token: 0x040006AF RID: 1711
		Error,
		/// <summary>Output warnings and error-handling messages.</summary>
		// Token: 0x040006B0 RID: 1712
		Warning,
		/// <summary>Output informational messages, warnings, and error-handling messages.</summary>
		// Token: 0x040006B1 RID: 1713
		Info,
		/// <summary>Output all debugging and tracing messages.</summary>
		// Token: 0x040006B2 RID: 1714
		Verbose
	}
}
