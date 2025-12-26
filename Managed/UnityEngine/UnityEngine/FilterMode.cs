using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Filtering mode for textures. Corresponds to the settings in a.</para>
	/// </summary>
	// Token: 0x02000274 RID: 628
	public enum FilterMode
	{
		/// <summary>
		///   <para>Point filtering - texture pixels become blocky up close.</para>
		/// </summary>
		// Token: 0x0400094B RID: 2379
		Point,
		/// <summary>
		///   <para>Bilinear filtering - texture samples are averaged.</para>
		/// </summary>
		// Token: 0x0400094C RID: 2380
		Bilinear,
		/// <summary>
		///   <para>Trilinear filtering - texture samples are averaged and also blended between mipmap levels.</para>
		/// </summary>
		// Token: 0x0400094D RID: 2381
		Trilinear
	}
}
