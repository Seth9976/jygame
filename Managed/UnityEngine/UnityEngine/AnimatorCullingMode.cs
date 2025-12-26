using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Culling mode for the Animator.</para>
	/// </summary>
	// Token: 0x02000184 RID: 388
	public enum AnimatorCullingMode
	{
		/// <summary>
		///   <para>Always animate the entire character. Object is animated even when offscreen.</para>
		/// </summary>
		// Token: 0x04000449 RID: 1097
		AlwaysAnimate,
		/// <summary>
		///   <para>Retarget, IK and write of Transforms are disabled when renderers are not visible.</para>
		/// </summary>
		// Token: 0x0400044A RID: 1098
		CullUpdateTransforms,
		/// <summary>
		///   <para>Animation is completely disabled when renderers are not visible.</para>
		/// </summary>
		// Token: 0x0400044B RID: 1099
		CullCompletely
	}
}
