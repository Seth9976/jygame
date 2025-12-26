using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Class for handling cube maps, Use this to create or modify existing.</para>
	/// </summary>
	// Token: 0x02000040 RID: 64
	public sealed class Cubemap : Texture
	{
		/// <summary>
		///   <para>Create a new empty cubemap texture.</para>
		/// </summary>
		/// <param name="size">Width/height of a cube face in pixels.</param>
		/// <param name="format">Pixel data format to be used for the Cubemap.</param>
		/// <param name="mipmap">Should mipmaps be created?</param>
		// Token: 0x06000348 RID: 840 RVA: 0x00002982 File Offset: 0x00000B82
		public Cubemap(int size, TextureFormat format, bool mipmap)
		{
			Cubemap.Internal_Create(this, size, format, mipmap);
		}

		/// <summary>
		///   <para>Sets pixel color at coordinates (face, x, y).</para>
		/// </summary>
		/// <param name="face"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="color"></param>
		// Token: 0x06000349 RID: 841 RVA: 0x00002993 File Offset: 0x00000B93
		public void SetPixel(CubemapFace face, int x, int y, Color color)
		{
			Cubemap.INTERNAL_CALL_SetPixel(this, face, x, y, ref color);
		}

		// Token: 0x0600034A RID: 842
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetPixel(Cubemap self, CubemapFace face, int x, int y, ref Color color);

		/// <summary>
		///   <para>Returns pixel color at coordinates (face, x, y).</para>
		/// </summary>
		/// <param name="face"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		// Token: 0x0600034B RID: 843
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color GetPixel(CubemapFace face, int x, int y);

		/// <summary>
		///   <para>Returns pixel colors of a cubemap face.</para>
		/// </summary>
		/// <param name="face">The face from which pixel data is taken.</param>
		/// <param name="miplevel">Mipmap level for the chosen face.</param>
		// Token: 0x0600034C RID: 844
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color[] GetPixels(CubemapFace face, [DefaultValue("0")] int miplevel);

		// Token: 0x0600034D RID: 845 RVA: 0x0000FDF4 File Offset: 0x0000DFF4
		[ExcludeFromDocs]
		public Color[] GetPixels(CubemapFace face)
		{
			int num = 0;
			return this.GetPixels(face, num);
		}

		/// <summary>
		///   <para>Sets pixel colors of a cubemap face.</para>
		/// </summary>
		/// <param name="colors">Pixel data for the Cubemap face.</param>
		/// <param name="face">The face to which the new data should be applied.</param>
		/// <param name="miplevel">The mipmap level for the face.</param>
		// Token: 0x0600034E RID: 846
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetPixels(Color[] colors, CubemapFace face, [DefaultValue("0")] int miplevel);

		// Token: 0x0600034F RID: 847 RVA: 0x0000FE0C File Offset: 0x0000E00C
		[ExcludeFromDocs]
		public void SetPixels(Color[] colors, CubemapFace face)
		{
			int num = 0;
			this.SetPixels(colors, face, num);
		}

		/// <summary>
		///   <para>How many mipmap levels are in this texture (Read Only).</para>
		/// </summary>
		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000350 RID: 848
		public extern int mipmapCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Actually apply all previous SetPixel and SetPixels changes.</para>
		/// </summary>
		/// <param name="updateMipmaps">Should all mipmap levels be updated?</param>
		/// <param name="makeNoLongerReadable">Should the Cubemap texture data be readable/modifiable after changes are applied?</param>
		// Token: 0x06000351 RID: 849
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable);

		// Token: 0x06000352 RID: 850 RVA: 0x0000FE24 File Offset: 0x0000E024
		[ExcludeFromDocs]
		public void Apply(bool updateMipmaps)
		{
			bool flag = false;
			this.Apply(updateMipmaps, flag);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000FE3C File Offset: 0x0000E03C
		[ExcludeFromDocs]
		public void Apply()
		{
			bool flag = false;
			bool flag2 = true;
			this.Apply(flag2, flag);
		}

		/// <summary>
		///   <para>The format of the pixel data in the texture (Read Only).</para>
		/// </summary>
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000354 RID: 852
		public extern TextureFormat format
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06000355 RID: 853
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] Cubemap mono, int size, TextureFormat format, bool mipmap);

		/// <summary>
		///   <para>Performs smoothing of near edge regions.</para>
		/// </summary>
		/// <param name="smoothRegionWidthInPixels">Pixel distance at edges over which to apply smoothing.</param>
		// Token: 0x06000356 RID: 854
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SmoothEdges([DefaultValue("1")] int smoothRegionWidthInPixels);

		// Token: 0x06000357 RID: 855 RVA: 0x0000FE58 File Offset: 0x0000E058
		[ExcludeFromDocs]
		public void SmoothEdges()
		{
			int num = 1;
			this.SmoothEdges(num);
		}
	}
}
