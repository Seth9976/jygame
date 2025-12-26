using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Color space conversion mode of a RenderTexture.</para>
	/// </summary>
	// Token: 0x0200027A RID: 634
	public enum RenderTextureReadWrite
	{
		/// <summary>
		///   <para>The correct color space for the current position in the rendering pipeline.</para>
		/// </summary>
		// Token: 0x040009A3 RID: 2467
		Default,
		/// <summary>
		///   <para>No sRGB reads or writes to this render texture.</para>
		/// </summary>
		// Token: 0x040009A4 RID: 2468
		Linear,
		/// <summary>
		///   <para>sRGB reads and writes to this render texture.</para>
		/// </summary>
		// Token: 0x040009A5 RID: 2469
		sRGB
	}
}
