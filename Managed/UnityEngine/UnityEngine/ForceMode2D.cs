using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Option for how to apply a force using Rigidbody2D.AddForce.</para>
	/// </summary>
	// Token: 0x0200011F RID: 287
	public enum ForceMode2D
	{
		/// <summary>
		///   <para>Add a force to the Rigidbody2D, using its mass.</para>
		/// </summary>
		// Token: 0x04000343 RID: 835
		Force,
		/// <summary>
		///   <para>Add an instant force impulse to the rigidbody2D, using its mass.</para>
		/// </summary>
		// Token: 0x04000344 RID: 836
		Impulse
	}
}
