using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Class for texture handling.</para>
	/// </summary>
	// Token: 0x0200003F RID: 63
	public sealed class Texture2D : Texture
	{
		/// <summary>
		///   <para>Create a new empty texture.</para>
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		// Token: 0x06000315 RID: 789 RVA: 0x000028BF File Offset: 0x00000ABF
		public Texture2D(int width, int height)
		{
			Texture2D.Internal_Create(this, width, height, TextureFormat.ARGB32, true, false, IntPtr.Zero);
		}

		/// <summary>
		///   <para>Create a new empty texture.</para>
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="format"></param>
		/// <param name="mipmap"></param>
		// Token: 0x06000316 RID: 790 RVA: 0x000028D7 File Offset: 0x00000AD7
		public Texture2D(int width, int height, TextureFormat format, bool mipmap)
		{
			Texture2D.Internal_Create(this, width, height, format, mipmap, false, IntPtr.Zero);
		}

		/// <summary>
		///   <para>See Also: SetPixel, SetPixels, Apply functions.</para>
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="format"></param>
		/// <param name="mipmap"></param>
		/// <param name="linear"></param>
		// Token: 0x06000317 RID: 791 RVA: 0x000028F0 File Offset: 0x00000AF0
		public Texture2D(int width, int height, TextureFormat format, bool mipmap, bool linear)
		{
			Texture2D.Internal_Create(this, width, height, format, mipmap, linear, IntPtr.Zero);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000290A File Offset: 0x00000B0A
		internal Texture2D(int width, int height, TextureFormat format, bool mipmap, bool linear, IntPtr nativeTex)
		{
			Texture2D.Internal_Create(this, width, height, format, mipmap, linear, nativeTex);
		}

		/// <summary>
		///   <para>How many mipmap levels are in this texture (Read Only).</para>
		/// </summary>
		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000319 RID: 793
		public extern int mipmapCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x0600031A RID: 794
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] Texture2D mono, int width, int height, TextureFormat format, bool mipmap, bool linear, IntPtr nativeTex);

		/// <summary>
		///   <para>Creates Unity Texture out of externally created native texture object.</para>
		/// </summary>
		/// <param name="nativeTex">Native 2D texture object.</param>
		/// <param name="width">Width of texture in pixels.</param>
		/// <param name="height">Height of texture in pixels.</param>
		/// <param name="format">Format of underlying texture object.</param>
		/// <param name="mipmap">Does the texture have mipmaps?</param>
		/// <param name="linear">Is texture using linear color space?</param>
		// Token: 0x0600031B RID: 795 RVA: 0x00002921 File Offset: 0x00000B21
		public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipmap, bool linear, IntPtr nativeTex)
		{
			return new Texture2D(width, height, format, mipmap, linear, nativeTex);
		}

		/// <summary>
		///   <para>Updates Unity texture to use different native texture object.</para>
		/// </summary>
		/// <param name="nativeTex">Native 2D texture object.</param>
		// Token: 0x0600031C RID: 796
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void UpdateExternalTexture(IntPtr nativeTex);

		/// <summary>
		///   <para>The format of the pixel data in the texture (Read Only).</para>
		/// </summary>
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600031D RID: 797
		public extern TextureFormat format
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Get a small texture with all white pixels.</para>
		/// </summary>
		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600031E RID: 798
		public static extern Texture2D whiteTexture
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Get a small texture with all black pixels.</para>
		/// </summary>
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600031F RID: 799
		public static extern Texture2D blackTexture
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Sets pixel color at coordinates (x,y).</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="color"></param>
		// Token: 0x06000320 RID: 800 RVA: 0x00002930 File Offset: 0x00000B30
		public void SetPixel(int x, int y, Color color)
		{
			Texture2D.INTERNAL_CALL_SetPixel(this, x, y, ref color);
		}

		// Token: 0x06000321 RID: 801
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetPixel(Texture2D self, int x, int y, ref Color color);

		/// <summary>
		///   <para>Returns pixel color at coordinates (x, y).</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		// Token: 0x06000322 RID: 802
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color GetPixel(int x, int y);

		/// <summary>
		///   <para>Returns filtered pixel color at normalized coordinates (u, v).</para>
		/// </summary>
		/// <param name="u"></param>
		/// <param name="v"></param>
		// Token: 0x06000323 RID: 803
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color GetPixelBilinear(float u, float v);

		// Token: 0x06000324 RID: 804 RVA: 0x0000FC24 File Offset: 0x0000DE24
		[ExcludeFromDocs]
		public void SetPixels(Color[] colors)
		{
			int num = 0;
			this.SetPixels(colors, num);
		}

		/// <summary>
		///   <para>Set a block of pixel colors.</para>
		/// </summary>
		/// <param name="colors"></param>
		/// <param name="miplevel"></param>
		// Token: 0x06000325 RID: 805 RVA: 0x0000FC3C File Offset: 0x0000DE3C
		public void SetPixels(Color[] colors, [DefaultValue("0")] int miplevel)
		{
			int num = this.width >> miplevel;
			if (num < 1)
			{
				num = 1;
			}
			int num2 = this.height >> miplevel;
			if (num2 < 1)
			{
				num2 = 1;
			}
			this.SetPixels(0, 0, num, num2, colors, miplevel);
		}

		/// <summary>
		///   <para>Set a block of pixel colors.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="blockWidth"></param>
		/// <param name="blockHeight"></param>
		/// <param name="colors"></param>
		/// <param name="miplevel"></param>
		// Token: 0x06000326 RID: 806
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, [DefaultValue("0")] int miplevel);

		// Token: 0x06000327 RID: 807 RVA: 0x0000FC80 File Offset: 0x0000DE80
		[ExcludeFromDocs]
		public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors)
		{
			int num = 0;
			this.SetPixels(x, y, blockWidth, blockHeight, colors, num);
		}

		// Token: 0x06000328 RID: 808
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetAllPixels32(Color32[] colors, int miplevel);

		// Token: 0x06000329 RID: 809
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel);

		// Token: 0x0600032A RID: 810 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		[ExcludeFromDocs]
		public void SetPixels32(Color32[] colors)
		{
			int num = 0;
			this.SetPixels32(colors, num);
		}

		/// <summary>
		///   <para>Set a block of pixel colors.</para>
		/// </summary>
		/// <param name="colors"></param>
		/// <param name="miplevel"></param>
		// Token: 0x0600032B RID: 811 RVA: 0x0000293C File Offset: 0x00000B3C
		public void SetPixels32(Color32[] colors, [DefaultValue("0")] int miplevel)
		{
			this.SetAllPixels32(colors, miplevel);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000FCB8 File Offset: 0x0000DEB8
		[ExcludeFromDocs]
		public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors)
		{
			int num = 0;
			this.SetPixels32(x, y, blockWidth, blockHeight, colors, num);
		}

		/// <summary>
		///   <para>Set a block of pixel colors.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="blockWidth"></param>
		/// <param name="blockHeight"></param>
		/// <param name="colors"></param>
		/// <param name="miplevel"></param>
		// Token: 0x0600032D RID: 813 RVA: 0x00002946 File Offset: 0x00000B46
		public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, [DefaultValue("0")] int miplevel)
		{
			this.SetBlockOfPixels32(x, y, blockWidth, blockHeight, colors, miplevel);
		}

		/// <summary>
		///   <para>Loads PNG/JPG image byte array into a texture.</para>
		/// </summary>
		/// <param name="data">The byte array containing the image data to load.</param>
		/// <returns>
		///   <para>Returns true if the data can be loaded, false otherwise.</para>
		/// </returns>
		// Token: 0x0600032E RID: 814
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool LoadImage(byte[] data);

		/// <summary>
		///   <para>Fills texture pixels with raw preformatted data.</para>
		/// </summary>
		/// <param name="data">Byte array to initialize texture pixels with.</param>
		// Token: 0x0600032F RID: 815
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void LoadRawTextureData(byte[] data);

		/// <summary>
		///   <para>Get raw data from a texture.</para>
		/// </summary>
		/// <returns>
		///   <para>Raw texture data as a byte array.</para>
		/// </returns>
		// Token: 0x06000330 RID: 816
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern byte[] GetRawTextureData();

		// Token: 0x06000331 RID: 817 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		[ExcludeFromDocs]
		public Color[] GetPixels()
		{
			int num = 0;
			return this.GetPixels(num);
		}

		/// <summary>
		///   <para>Get a block of pixel colors.</para>
		/// </summary>
		/// <param name="miplevel"></param>
		// Token: 0x06000332 RID: 818 RVA: 0x0000FCF0 File Offset: 0x0000DEF0
		public Color[] GetPixels([DefaultValue("0")] int miplevel)
		{
			int num = this.width >> miplevel;
			if (num < 1)
			{
				num = 1;
			}
			int num2 = this.height >> miplevel;
			if (num2 < 1)
			{
				num2 = 1;
			}
			return this.GetPixels(0, 0, num, num2, miplevel);
		}

		/// <summary>
		///   <para>Get a block of pixel colors.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="blockWidth"></param>
		/// <param name="blockHeight"></param>
		/// <param name="miplevel"></param>
		// Token: 0x06000333 RID: 819
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, [DefaultValue("0")] int miplevel);

		// Token: 0x06000334 RID: 820 RVA: 0x0000FD34 File Offset: 0x0000DF34
		[ExcludeFromDocs]
		public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight)
		{
			int num = 0;
			return this.GetPixels(x, y, blockWidth, blockHeight, num);
		}

		/// <summary>
		///   <para>Get a block of pixel colors in Color32 format.</para>
		/// </summary>
		/// <param name="miplevel"></param>
		// Token: 0x06000335 RID: 821
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color32[] GetPixels32([DefaultValue("0")] int miplevel);

		// Token: 0x06000336 RID: 822 RVA: 0x0000FD50 File Offset: 0x0000DF50
		[ExcludeFromDocs]
		public Color32[] GetPixels32()
		{
			int num = 0;
			return this.GetPixels32(num);
		}

		/// <summary>
		///   <para>Actually apply all previous SetPixel and SetPixels changes.</para>
		/// </summary>
		/// <param name="updateMipmaps"></param>
		/// <param name="makeNoLongerReadable"></param>
		// Token: 0x06000337 RID: 823
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable);

		// Token: 0x06000338 RID: 824 RVA: 0x0000FD68 File Offset: 0x0000DF68
		[ExcludeFromDocs]
		public void Apply(bool updateMipmaps)
		{
			bool flag = false;
			this.Apply(updateMipmaps, flag);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000FD80 File Offset: 0x0000DF80
		[ExcludeFromDocs]
		public void Apply()
		{
			bool flag = false;
			bool flag2 = true;
			this.Apply(flag2, flag);
		}

		/// <summary>
		///   <para>Resizes the texture.</para>
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="format"></param>
		/// <param name="hasMipMap"></param>
		// Token: 0x0600033A RID: 826
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool Resize(int width, int height, TextureFormat format, bool hasMipMap);

		/// <summary>
		///   <para>Resizes the texture.</para>
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		// Token: 0x0600033B RID: 827 RVA: 0x00002957 File Offset: 0x00000B57
		public bool Resize(int width, int height)
		{
			return this.Internal_ResizeWH(width, height);
		}

		// Token: 0x0600033C RID: 828
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool Internal_ResizeWH(int width, int height);

		/// <summary>
		///   <para>Compress texture into DXT format.</para>
		/// </summary>
		/// <param name="highQuality"></param>
		// Token: 0x0600033D RID: 829 RVA: 0x00002961 File Offset: 0x00000B61
		public void Compress(bool highQuality)
		{
			Texture2D.INTERNAL_CALL_Compress(this, highQuality);
		}

		// Token: 0x0600033E RID: 830
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Compress(Texture2D self, bool highQuality);

		/// <summary>
		///   <para>Packs multiple Textures into a texture atlas.</para>
		/// </summary>
		/// <param name="textures">Array of textures to pack into the atlas.</param>
		/// <param name="padding">Padding in pixels between the packed textures.</param>
		/// <param name="maximumAtlasSize">Maximum size of the resulting texture.</param>
		/// <param name="makeNoLongerReadable">Should the texture be marked as no longer readable?</param>
		/// <returns>
		///   <para>An array of rectangles containing the UV coordinates in the atlas for each input texture, or null if packing fails.</para>
		/// </returns>
		// Token: 0x0600033F RID: 831
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Rect[] PackTextures(Texture2D[] textures, int padding, [DefaultValue("2048")] int maximumAtlasSize, [DefaultValue("false")] bool makeNoLongerReadable);

		// Token: 0x06000340 RID: 832 RVA: 0x0000FD9C File Offset: 0x0000DF9C
		[ExcludeFromDocs]
		public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize)
		{
			bool flag = false;
			return this.PackTextures(textures, padding, maximumAtlasSize, flag);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000FDB8 File Offset: 0x0000DFB8
		[ExcludeFromDocs]
		public Rect[] PackTextures(Texture2D[] textures, int padding)
		{
			bool flag = false;
			int num = 2048;
			return this.PackTextures(textures, padding, num, flag);
		}

		/// <summary>
		///   <para>Read pixels from screen into the saved texture data.</para>
		/// </summary>
		/// <param name="source">Rectangular region of the view to read from. Pixels are read from current render target.</param>
		/// <param name="destX">Horizontal pixel position in the texture to place the pixels that are read.</param>
		/// <param name="destY">Vertical pixel position in the texture to place the pixels that are read.</param>
		/// <param name="recalculateMipMaps">Should the texture's mipmaps be recalculated after reading?</param>
		// Token: 0x06000342 RID: 834 RVA: 0x0000296A File Offset: 0x00000B6A
		public void ReadPixels(Rect source, int destX, int destY, [DefaultValue("true")] bool recalculateMipMaps)
		{
			Texture2D.INTERNAL_CALL_ReadPixels(this, ref source, destX, destY, recalculateMipMaps);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000FDD8 File Offset: 0x0000DFD8
		[ExcludeFromDocs]
		public void ReadPixels(Rect source, int destX, int destY)
		{
			bool flag = true;
			Texture2D.INTERNAL_CALL_ReadPixels(this, ref source, destX, destY, flag);
		}

		// Token: 0x06000344 RID: 836
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ReadPixels(Texture2D self, ref Rect source, int destX, int destY, bool recalculateMipMaps);

		/// <summary>
		///   <para>Encodes this texture into PNG format.</para>
		/// </summary>
		// Token: 0x06000345 RID: 837
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern byte[] EncodeToPNG();

		/// <summary>
		///   <para>Encodes this texture into JPG format.</para>
		/// </summary>
		/// <param name="quality">JPG quality to encode with, 1..100 (default 75).</param>
		// Token: 0x06000346 RID: 838
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern byte[] EncodeToJPG(int quality);

		/// <summary>
		///   <para>Encodes this texture into JPG format.</para>
		/// </summary>
		/// <param name="quality">JPG quality to encode with, 1..100 (default 75).</param>
		// Token: 0x06000347 RID: 839 RVA: 0x00002978 File Offset: 0x00000B78
		public byte[] EncodeToJPG()
		{
			return this.EncodeToJPG(75);
		}
	}
}
