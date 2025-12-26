using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Controls how collisions are detected when a Rigidbody2D moves.</para>
	/// </summary>
	// Token: 0x0200011E RID: 286
	public enum CollisionDetectionMode2D
	{
		/// <summary>
		///   <para>This mode is obsolete.  You should use Discrete mode.</para>
		/// </summary>
		// Token: 0x0400033F RID: 831
		[Obsolete("Enum member CollisionDetectionMode2D.None has been deprecated. Use CollisionDetectionMode2D.Discrete instead (UnityUpgradable) -> Discrete", true)]
		None,
		/// <summary>
		///   <para>When a Rigidbody2D moves, only collisions at the new position are detected.</para>
		/// </summary>
		// Token: 0x04000340 RID: 832
		Discrete = 0,
		/// <summary>
		///   <para>Ensures that all collisions are detected when a Rigidbody2D moves.</para>
		/// </summary>
		// Token: 0x04000341 RID: 833
		Continuous
	}
}
