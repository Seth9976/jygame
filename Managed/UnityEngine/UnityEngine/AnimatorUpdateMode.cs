using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The update mode of the Animator.</para>
	/// </summary>
	// Token: 0x02000185 RID: 389
	public enum AnimatorUpdateMode
	{
		/// <summary>
		///   <para>Normal update of the animator.</para>
		/// </summary>
		// Token: 0x0400044D RID: 1101
		Normal,
		/// <summary>
		///   <para>Updates the animator during the physic loop in order to have the animation system synchronized with the physics engine.</para>
		/// </summary>
		// Token: 0x0400044E RID: 1102
		AnimatePhysics,
		/// <summary>
		///   <para>Animator updates independently of Time.timeScale.</para>
		/// </summary>
		// Token: 0x0400044F RID: 1103
		UnscaledTime
	}
}
