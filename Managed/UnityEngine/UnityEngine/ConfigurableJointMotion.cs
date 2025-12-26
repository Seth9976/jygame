using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Constrains movement for a ConfigurableJoint along the 6 axes.</para>
	/// </summary>
	// Token: 0x0200010A RID: 266
	public enum ConfigurableJointMotion
	{
		/// <summary>
		///   <para>Motion along the axis will be locked.</para>
		/// </summary>
		// Token: 0x0400031A RID: 794
		Locked,
		/// <summary>
		///   <para>Motion along the axis will be limited by the respective limit.</para>
		/// </summary>
		// Token: 0x0400031B RID: 795
		Limited,
		/// <summary>
		///   <para>Motion along the axis will be completely free and completely unconstrained.</para>
		/// </summary>
		// Token: 0x0400031C RID: 796
		Free
	}
}
