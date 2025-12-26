using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The collision detection mode constants used for Rigidbody.collisionDetectionMode.</para>
	/// </summary>
	// Token: 0x0200010E RID: 270
	public enum CollisionDetectionMode
	{
		/// <summary>
		///   <para>Continuous collision detection is off for this Rigidbody.</para>
		/// </summary>
		// Token: 0x04000321 RID: 801
		Discrete,
		/// <summary>
		///   <para>Continuous collision detection is on for colliding with static mesh geometry.</para>
		/// </summary>
		// Token: 0x04000322 RID: 802
		Continuous,
		/// <summary>
		///   <para>Continuous collision detection is on for colliding with static and dynamic geometry.</para>
		/// </summary>
		// Token: 0x04000323 RID: 803
		ContinuousDynamic
	}
}
