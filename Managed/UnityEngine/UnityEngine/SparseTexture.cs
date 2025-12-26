using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Class for handling Sparse Textures.</para>
	/// </summary>
	// Token: 0x02000042 RID: 66
	public sealed class SparseTexture : Texture
	{
		/// <summary>
		///   <para>Create a sparse texture.</para>
		/// </summary>
		/// <param name="width">Texture width in pixels.</param>
		/// <param name="height">Texture height in pixels.</param>
		/// <param name="format">Texture format.</param>
		/// <param name="mipCount">Mipmap count. Pass -1 to create full mipmap chain.</param>
		/// <param name="linear">Whether texture data will be in linear or sRGB color space (default is sRGB).</param>
		// Token: 0x06000366 RID: 870 RVA: 0x000029B5 File Offset: 0x00000BB5
		public SparseTexture(int width, int height, TextureFormat format, int mipCount)
		{
			SparseTexture.Internal_Create(this, width, height, format, mipCount, false);
		}

		/// <summary>
		///   <para>Create a sparse texture.</para>
		/// </summary>
		/// <param name="width">Texture width in pixels.</param>
		/// <param name="height">Texture height in pixels.</param>
		/// <param name="format">Texture format.</param>
		/// <param name="mipCount">Mipmap count. Pass -1 to create full mipmap chain.</param>
		/// <param name="linear">Whether texture data will be in linear or sRGB color space (default is sRGB).</param>
		// Token: 0x06000367 RID: 871 RVA: 0x000029C9 File Offset: 0x00000BC9
		public SparseTexture(int width, int height, TextureFormat format, int mipCount, bool linear)
		{
			SparseTexture.Internal_Create(this, width, height, format, mipCount, linear);
		}

		/// <summary>
		///   <para>Get sparse texture tile width (Read Only).</para>
		/// </summary>
		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000368 RID: 872
		public extern int tileWidth
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Get sparse texture tile height (Read Only).</para>
		/// </summary>
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000369 RID: 873
		public extern int tileHeight
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Is the sparse texture actually created? (Read Only)</para>
		/// </summary>
		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600036A RID: 874
		public extern bool isCreated
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x0600036B RID: 875
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] SparseTexture mono, int width, int height, TextureFormat format, int mipCount, bool linear);

		/// <summary>
		///   <para>Update sparse texture tile with color values.</para>
		/// </summary>
		/// <param name="tileX">Tile X coordinate.</param>
		/// <param name="tileY">Tile Y coordinate.</param>
		/// <param name="miplevel">Mipmap level of the texture.</param>
		/// <param name="data">Tile color data.</param>
		// Token: 0x0600036C RID: 876
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void UpdateTile(int tileX, int tileY, int miplevel, Color32[] data);

		/// <summary>
		///   <para>Update sparse texture tile with raw pixel values.</para>
		/// </summary>
		/// <param name="tileX">Tile X coordinate.</param>
		/// <param name="tileY">Tile Y coordinate.</param>
		/// <param name="miplevel">Mipmap level of the texture.</param>
		/// <param name="data">Tile raw pixel data.</param>
		// Token: 0x0600036D RID: 877
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void UpdateTileRaw(int tileX, int tileY, int miplevel, byte[] data);

		/// <summary>
		///   <para>Unload sparse texture tile.</para>
		/// </summary>
		/// <param name="tileX">Tile X coordinate.</param>
		/// <param name="tileY">Tile Y coordinate.</param>
		/// <param name="miplevel">Mipmap level of the texture.</param>
		// Token: 0x0600036E RID: 878
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void UnloadTile(int tileX, int tileY, int miplevel);
	}
}
