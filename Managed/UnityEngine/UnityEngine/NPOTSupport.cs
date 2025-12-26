using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>NPOT Texture2D|textures support.</para>
	/// </summary>
	// Token: 0x02000276 RID: 630
	public enum NPOTSupport
	{
		/// <summary>
		///   <para>NPOT textures are not supported. Will be upscaled/padded at loading time.</para>
		/// </summary>
		// Token: 0x04000952 RID: 2386
		None,
		/// <summary>
		///   <para>Limited NPOT support: no mip-maps and clamp TextureWrapMode|wrap mode will be forced.</para>
		/// </summary>
		// Token: 0x04000953 RID: 2387
		Restricted,
		/// <summary>
		///   <para>Full NPOT support.</para>
		/// </summary>
		// Token: 0x04000954 RID: 2388
		Full
	}
}
