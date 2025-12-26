using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Describes when an AudioSource or AudioListener is updated.</para>
	/// </summary>
	// Token: 0x02000157 RID: 343
	public enum AudioVelocityUpdateMode
	{
		/// <summary>
		///   <para>Updates the source or listener in the fixed update loop if it is attached to a Rigidbody, dynamic otherwise.</para>
		/// </summary>
		// Token: 0x040003C3 RID: 963
		Auto,
		/// <summary>
		///   <para>Updates the source or listener in the fixed update loop.</para>
		/// </summary>
		// Token: 0x040003C4 RID: 964
		Fixed,
		/// <summary>
		///   <para>Updates the source or listener in the dynamic update loop.</para>
		/// </summary>
		// Token: 0x040003C5 RID: 965
		Dynamic
	}
}
