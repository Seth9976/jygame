using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The type of generated image in a ProceduralMaterial.</para>
	/// </summary>
	// Token: 0x02000090 RID: 144
	public enum ProceduralOutputType
	{
		/// <summary>
		///   <para>Undefined type.</para>
		/// </summary>
		// Token: 0x040001BB RID: 443
		Unknown,
		/// <summary>
		///   <para>Diffuse map.</para>
		/// </summary>
		// Token: 0x040001BC RID: 444
		Diffuse,
		/// <summary>
		///   <para>Normal (Bump) map.</para>
		/// </summary>
		// Token: 0x040001BD RID: 445
		Normal,
		/// <summary>
		///   <para>Height map.</para>
		/// </summary>
		// Token: 0x040001BE RID: 446
		Height,
		/// <summary>
		///   <para>Emissive map.</para>
		/// </summary>
		// Token: 0x040001BF RID: 447
		Emissive,
		/// <summary>
		///   <para>Specular map.</para>
		/// </summary>
		// Token: 0x040001C0 RID: 448
		Specular,
		/// <summary>
		///   <para>Opacity (Tranparency) map.</para>
		/// </summary>
		// Token: 0x040001C1 RID: 449
		Opacity,
		/// <summary>
		///   <para>Smoothness map (formerly referred to as Glossiness).</para>
		/// </summary>
		// Token: 0x040001C2 RID: 450
		Smoothness,
		/// <summary>
		///   <para>Ambient occlusion map.</para>
		/// </summary>
		// Token: 0x040001C3 RID: 451
		AmbientOcclusion,
		/// <summary>
		///   <para>Detail mask map.</para>
		/// </summary>
		// Token: 0x040001C4 RID: 452
		DetailMask,
		/// <summary>
		///   <para>Metalness map.</para>
		/// </summary>
		// Token: 0x040001C5 RID: 453
		Metallic,
		/// <summary>
		///   <para>Roughness map.</para>
		/// </summary>
		// Token: 0x040001C6 RID: 454
		Roughness
	}
}
