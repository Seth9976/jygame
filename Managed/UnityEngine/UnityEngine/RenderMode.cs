using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>RenderMode for the Canvas.</para>
	/// </summary>
	// Token: 0x020001B9 RID: 441
	public enum RenderMode
	{
		/// <summary>
		///   <para>Render at the end of the scene using a 2D Canvas.</para>
		/// </summary>
		// Token: 0x04000565 RID: 1381
		ScreenSpaceOverlay,
		/// <summary>
		///   <para>Render using the Camera configured on the Canvas.</para>
		/// </summary>
		// Token: 0x04000566 RID: 1382
		ScreenSpaceCamera,
		/// <summary>
		///   <para>Render using any Camera in the scene that can render the layer.</para>
		/// </summary>
		// Token: 0x04000567 RID: 1383
		WorldSpace
	}
}
