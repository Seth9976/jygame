using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Level of obstacle avoidance.</para>
	/// </summary>
	// Token: 0x02000140 RID: 320
	public enum ObstacleAvoidanceType
	{
		/// <summary>
		///   <para>Disable avoidance.</para>
		/// </summary>
		// Token: 0x0400036F RID: 879
		NoObstacleAvoidance,
		/// <summary>
		///   <para>Enable simple avoidance. Low performance impact.</para>
		/// </summary>
		// Token: 0x04000370 RID: 880
		LowQualityObstacleAvoidance,
		/// <summary>
		///   <para>Medium avoidance. Medium performance impact.</para>
		/// </summary>
		// Token: 0x04000371 RID: 881
		MedQualityObstacleAvoidance,
		/// <summary>
		///   <para>Good avoidance. High performance impact.</para>
		/// </summary>
		// Token: 0x04000372 RID: 882
		GoodQualityObstacleAvoidance,
		/// <summary>
		///   <para>Enable highest precision. Highest performance impact.</para>
		/// </summary>
		// Token: 0x04000373 RID: 883
		HighQualityObstacleAvoidance
	}
}
