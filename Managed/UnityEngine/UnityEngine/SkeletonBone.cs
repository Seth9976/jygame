using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Details of the Transform name mapped to a model's skeleton bone and its default position and rotation in the T-pose.</para>
	/// </summary>
	// Token: 0x0200018C RID: 396
	public struct SkeletonBone
	{
		/// <summary>
		///   <para>The name of the Transform mapped to the bone.</para>
		/// </summary>
		// Token: 0x04000466 RID: 1126
		public string name;

		/// <summary>
		///   <para>The T-pose position of the bone in local space.</para>
		/// </summary>
		// Token: 0x04000467 RID: 1127
		public Vector3 position;

		/// <summary>
		///   <para>The T-pose rotation of the bone in local space.</para>
		/// </summary>
		// Token: 0x04000468 RID: 1128
		public Quaternion rotation;

		/// <summary>
		///   <para>The T-pose scaling of the bone in local space.</para>
		/// </summary>
		// Token: 0x04000469 RID: 1129
		public Vector3 scale;

		// Token: 0x0400046A RID: 1130
		public int transformModified;
	}
}
