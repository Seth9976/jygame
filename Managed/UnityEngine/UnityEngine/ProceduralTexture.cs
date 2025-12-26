using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Class for ProceduralTexture handling.</para>
	/// </summary>
	// Token: 0x02000093 RID: 147
	public sealed class ProceduralTexture : Texture
	{
		/// <summary>
		///   <para>The output type of this ProceduralTexture.</para>
		/// </summary>
		// Token: 0x0600088E RID: 2190
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern ProceduralOutputType GetProceduralOutputType();

		// Token: 0x0600088F RID: 2191
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern ProceduralMaterial GetProceduralMaterial();

		/// <summary>
		///   <para>Check whether the ProceduralMaterial that generates this ProceduralTexture is set to an output format with an alpha channel.</para>
		/// </summary>
		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000890 RID: 2192
		public extern bool hasAlpha
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06000891 RID: 2193
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern bool HasBeenGenerated();

		/// <summary>
		///   <para>The format of the pixel data in the texture (Read Only).</para>
		/// </summary>
		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000892 RID: 2194
		public extern TextureFormat format
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Grab pixel values from a ProceduralTexture.
		/// </para>
		/// </summary>
		/// <param name="x">X-coord of the top-left corner of the rectangle to grab.</param>
		/// <param name="y">Y-coord of the top-left corner of the rectangle to grab.</param>
		/// <param name="blockWidth">Width of rectangle to grab.</param>
		/// <param name="blockHeight">Height of the rectangle to grab.
		/// Get the pixel values from a rectangular area of a ProceduralTexture into an array.
		/// The block is specified by its x,y offset in the texture and by its width and height. The block is "flattened" into the array by scanning the pixel values across rows one by one.</param>
		// Token: 0x06000893 RID: 2195
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color32[] GetPixels32(int x, int y, int blockWidth, int blockHeight);
	}
}
