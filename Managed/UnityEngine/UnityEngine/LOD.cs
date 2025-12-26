using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Structure for building a LOD for passing to the SetLODs function.</para>
	/// </summary>
	// Token: 0x02000046 RID: 70
	public struct LOD
	{
		/// <summary>
		///   <para>Construct a LOD.</para>
		/// </summary>
		/// <param name="screenRelativeTransitionHeight">The screen relative height to use for the transition [0-1].</param>
		/// <param name="renderers">An array of renderers to use for this LOD level.</param>
		// Token: 0x060003E5 RID: 997 RVA: 0x00002AB7 File Offset: 0x00000CB7
		public LOD(float screenRelativeTransitionHeight, Renderer[] renderers)
		{
			this.screenRelativeTransitionHeight = screenRelativeTransitionHeight;
			this.fadeTransitionWidth = 0f;
			this.renderers = renderers;
		}

		/// <summary>
		///   <para>The screen relative height to use for the transition [0-1].</para>
		/// </summary>
		// Token: 0x040000AC RID: 172
		public float screenRelativeTransitionHeight;

		/// <summary>
		///   <para>Width of the cross-fade transition zone (proportion to the current LOD's whole length) [0-1]. Only used if it's not animated.</para>
		/// </summary>
		// Token: 0x040000AD RID: 173
		public float fadeTransitionWidth;

		/// <summary>
		///   <para>List of renderers for this LOD level.</para>
		/// </summary>
		// Token: 0x040000AE RID: 174
		public Renderer[] renderers;
	}
}
