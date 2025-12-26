using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>ProceduralMaterial loading behavior.</para>
	/// </summary>
	// Token: 0x0200008E RID: 142
	public enum ProceduralLoadingBehavior
	{
		/// <summary>
		///   <para>Do not generate the textures. RebuildTextures() or RebuildTexturesImmediately() must be called to generate the textures.</para>
		/// </summary>
		// Token: 0x040001AA RID: 426
		DoNothing,
		/// <summary>
		///   <para>Generate the textures when loading to favor application's size (default on supported platform).</para>
		/// </summary>
		// Token: 0x040001AB RID: 427
		Generate,
		/// <summary>
		///   <para>Bake the textures to speed up loading and keep the ProceduralMaterial data so that it can still be tweaked and regenerated later on.</para>
		/// </summary>
		// Token: 0x040001AC RID: 428
		BakeAndKeep,
		/// <summary>
		///   <para>Bake the textures to speed up loading and discard the ProceduralMaterial data (default on unsupported platform).</para>
		/// </summary>
		// Token: 0x040001AD RID: 429
		BakeAndDiscard,
		/// <summary>
		///   <para>Generate the textures when loading and cache them to diskflash to speed up subsequent gameapplication startups.</para>
		/// </summary>
		// Token: 0x040001AE RID: 430
		Cache,
		/// <summary>
		///   <para>Do not generate the textures. RebuildTextures() or RebuildTexturesImmediately() must be called to generate the textures. After the textures have been generrated for the first time, they are cached to diskflash to speed up subsequent gameapplication startups.</para>
		/// </summary>
		// Token: 0x040001AF RID: 431
		DoNothingAndCache
	}
}
