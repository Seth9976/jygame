using System;

namespace System.Diagnostics
{
	/// <summary>Indicates whether the performance counter category can have multiple instances.</summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x0200023C RID: 572
	public enum PerformanceCounterCategoryType
	{
		/// <summary>The performance counter category can have only a single instance.</summary>
		// Token: 0x040005AB RID: 1451
		SingleInstance,
		/// <summary>The performance counter category can have multiple instances.</summary>
		// Token: 0x040005AC RID: 1452
		MultiInstance,
		/// <summary>The instance functionality for the performance counter category is unknown. </summary>
		// Token: 0x040005AD RID: 1453
		Unknown = -1
	}
}
