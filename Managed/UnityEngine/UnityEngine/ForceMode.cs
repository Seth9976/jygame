using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Option for how to apply a force using Rigidbody.AddForce.</para>
	/// </summary>
	// Token: 0x020000F0 RID: 240
	public enum ForceMode
	{
		/// <summary>
		///   <para>Add a continuous force to the rigidbody, using its mass.</para>
		/// </summary>
		// Token: 0x040002B9 RID: 697
		Force,
		/// <summary>
		///   <para>Add a continuous acceleration to the rigidbody, ignoring its mass.</para>
		/// </summary>
		// Token: 0x040002BA RID: 698
		Acceleration = 5,
		/// <summary>
		///   <para>Add an instant force impulse to the rigidbody, using its mass.</para>
		/// </summary>
		// Token: 0x040002BB RID: 699
		Impulse = 1,
		/// <summary>
		///   <para>Add an instant velocity change to the rigidbody, ignoring its mass.</para>
		/// </summary>
		// Token: 0x040002BC RID: 700
		VelocityChange
	}
}
