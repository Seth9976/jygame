using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The ConfigurableJoint attempts to attain position / velocity targets based on this flag.</para>
	/// </summary>
	// Token: 0x020000F1 RID: 241
	[Flags]
	public enum JointDriveMode
	{
		/// <summary>
		///   <para>Don't apply any forces to reach the target.</para>
		/// </summary>
		// Token: 0x040002BE RID: 702
		None = 0,
		/// <summary>
		///   <para>Try to reach the specified target position.</para>
		/// </summary>
		// Token: 0x040002BF RID: 703
		Position = 1,
		/// <summary>
		///   <para>Try to reach the specified target velocity.</para>
		/// </summary>
		// Token: 0x040002C0 RID: 704
		Velocity = 2,
		/// <summary>
		///   <para>Try to reach the specified target position and velocity.</para>
		/// </summary>
		// Token: 0x040002C1 RID: 705
		PositionAndVelocity = 3
	}
}
