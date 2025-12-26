using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The type of a ProceduralProperty.</para>
	/// </summary>
	// Token: 0x0200008F RID: 143
	public enum ProceduralPropertyType
	{
		/// <summary>
		///   <para>Procedural boolean property. Use with ProceduralMaterial.GetProceduralBoolean.</para>
		/// </summary>
		// Token: 0x040001B1 RID: 433
		Boolean,
		/// <summary>
		///   <para>Procedural float property. Use with ProceduralMaterial.GetProceduralFloat.</para>
		/// </summary>
		// Token: 0x040001B2 RID: 434
		Float,
		/// <summary>
		///   <para>Procedural Vector2 property. Use with ProceduralMaterial.GetProceduralVector.</para>
		/// </summary>
		// Token: 0x040001B3 RID: 435
		Vector2,
		/// <summary>
		///   <para>Procedural Vector3 property. Use with ProceduralMaterial.GetProceduralVector.</para>
		/// </summary>
		// Token: 0x040001B4 RID: 436
		Vector3,
		/// <summary>
		///   <para>Procedural Vector4 property. Use with ProceduralMaterial.GetProceduralVector.</para>
		/// </summary>
		// Token: 0x040001B5 RID: 437
		Vector4,
		/// <summary>
		///   <para>Procedural Color property without alpha. Use with ProceduralMaterial.GetProceduralColor.</para>
		/// </summary>
		// Token: 0x040001B6 RID: 438
		Color3,
		/// <summary>
		///   <para>Procedural Color property with alpha. Use with ProceduralMaterial.GetProceduralColor.</para>
		/// </summary>
		// Token: 0x040001B7 RID: 439
		Color4,
		/// <summary>
		///   <para>Procedural Enum property. Use with ProceduralMaterial.GetProceduralEnum.</para>
		/// </summary>
		// Token: 0x040001B8 RID: 440
		Enum,
		/// <summary>
		///   <para>Procedural Texture property. Use with ProceduralMaterial.GetProceduralTexture.</para>
		/// </summary>
		// Token: 0x040001B9 RID: 441
		Texture
	}
}
