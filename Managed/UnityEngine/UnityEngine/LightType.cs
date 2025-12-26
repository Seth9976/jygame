using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The type of a Light.</para>
	/// </summary>
	// Token: 0x02000265 RID: 613
	public enum LightType
	{
		/// <summary>
		///   <para>The light is a spot light.</para>
		/// </summary>
		// Token: 0x04000900 RID: 2304
		Spot,
		/// <summary>
		///   <para>The light is a directional light.</para>
		/// </summary>
		// Token: 0x04000901 RID: 2305
		Directional,
		/// <summary>
		///   <para>The light is a point light.</para>
		/// </summary>
		// Token: 0x04000902 RID: 2306
		Point,
		/// <summary>
		///   <para>The light is an area light. It affects only lightmaps and lightprobes.</para>
		/// </summary>
		// Token: 0x04000903 RID: 2307
		Area
	}
}
