using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>JointSpring is used add a spring force to HingeJoint and PhysicMaterial.</para>
	/// </summary>
	// Token: 0x020000F9 RID: 249
	public struct JointSpring
	{
		/// <summary>
		///   <para>The spring forces used to reach the target position.</para>
		/// </summary>
		// Token: 0x040002DB RID: 731
		public float spring;

		/// <summary>
		///   <para>The damper force uses to dampen the spring.</para>
		/// </summary>
		// Token: 0x040002DC RID: 732
		public float damper;

		/// <summary>
		///   <para>The target position the joint attempts to reach.</para>
		/// </summary>
		// Token: 0x040002DD RID: 733
		public float targetPosition;
	}
}
