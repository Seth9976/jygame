using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>This enum controlls culling of Animation component.</para>
	/// </summary>
	// Token: 0x02000179 RID: 377
	public enum AnimationCullingType
	{
		/// <summary>
		///   <para>Animation culling is disabled - object is animated even when offscreen.</para>
		/// </summary>
		// Token: 0x04000422 RID: 1058
		AlwaysAnimate,
		/// <summary>
		///   <para>Animation is disabled when renderers are not visible.</para>
		/// </summary>
		// Token: 0x04000423 RID: 1059
		BasedOnRenderers,
		// Token: 0x04000424 RID: 1060
		[Obsolete("Enum member AnimatorCullingMode.BasedOnClipBounds has been deprecated. Use AnimationCullingType.AlwaysAnimate or AnimationCullingType.BasedOnRenderers instead")]
		BasedOnClipBounds,
		// Token: 0x04000425 RID: 1061
		[Obsolete("Enum member AnimatorCullingMode.BasedOnUserBounds has been deprecated. Use AnimationCullingType.AlwaysAnimate or AnimationCullingType.BasedOnRenderers instead")]
		BasedOnUserBounds
	}
}
