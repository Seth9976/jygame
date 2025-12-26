using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Lightmap (and lighting) configuration mode, controls how lightmaps interact with lighting and what kind of information they store.</para>
	/// </summary>
	// Token: 0x0200027B RID: 635
	public enum LightmapsMode
	{
		/// <summary>
		///   <para>Light intensity (no directional information), encoded as 1 lightmap.</para>
		/// </summary>
		// Token: 0x040009A7 RID: 2471
		NonDirectional,
		/// <summary>
		///   <para>Directional information for direct light is combined with directional information for indirect light, encoded as 2 lightmaps.</para>
		/// </summary>
		// Token: 0x040009A8 RID: 2472
		CombinedDirectional,
		/// <summary>
		///   <para>Directional information for direct light is stored separately from directional information for indirect light, encoded as 4 lightmaps.</para>
		/// </summary>
		// Token: 0x040009A9 RID: 2473
		SeparateDirectional
	}
}
