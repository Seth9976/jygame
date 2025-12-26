using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>How the Light is rendered.</para>
	/// </summary>
	// Token: 0x02000266 RID: 614
	public enum LightRenderMode
	{
		/// <summary>
		///   <para>Automatically choose the render mode.</para>
		/// </summary>
		// Token: 0x04000905 RID: 2309
		Auto,
		/// <summary>
		///   <para>Force the Light to be a pixel light.</para>
		/// </summary>
		// Token: 0x04000906 RID: 2310
		ForcePixel,
		/// <summary>
		///   <para>Force the Light to be a vertex light.</para>
		/// </summary>
		// Token: 0x04000907 RID: 2311
		ForceVertex
	}
}
