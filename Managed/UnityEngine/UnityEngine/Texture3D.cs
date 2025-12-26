using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Class for handling 3D Textures, Use this to create.</para>
	/// </summary>
	// Token: 0x02000041 RID: 65
	public sealed class Texture3D : Texture
	{
		/// <summary>
		///   <para>Create a new empty 3D Texture.</para>
		/// </summary>
		/// <param name="width">Width of texture in pixels.</param>
		/// <param name="height">Height of texture in pixels.</param>
		/// <param name="depth">Depth of texture in pixels.</param>
		/// <param name="format">Texture data format.</param>
		/// <param name="mipmap">Should the texture have mipmaps?</param>
		// Token: 0x06000358 RID: 856 RVA: 0x000029A0 File Offset: 0x00000BA0
		public Texture3D(int width, int height, int depth, TextureFormat format, bool mipmap)
		{
			Texture3D.Internal_Create(this, width, height, depth, format, mipmap);
		}

		/// <summary>
		///   <para>The depth of the texture (Read Only).</para>
		/// </summary>
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000359 RID: 857
		public extern int depth
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns an array of pixel colors representing one mip level of the 3D texture.</para>
		/// </summary>
		/// <param name="miplevel"></param>
		// Token: 0x0600035A RID: 858
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color[] GetPixels([DefaultValue("0")] int miplevel);

		// Token: 0x0600035B RID: 859 RVA: 0x0000FE70 File Offset: 0x0000E070
		[ExcludeFromDocs]
		public Color[] GetPixels()
		{
			int num = 0;
			return this.GetPixels(num);
		}

		/// <summary>
		///   <para>Returns an array of pixel colors representing one mip level of the 3D texture.</para>
		/// </summary>
		/// <param name="miplevel"></param>
		// Token: 0x0600035C RID: 860
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color32[] GetPixels32([DefaultValue("0")] int miplevel);

		// Token: 0x0600035D RID: 861 RVA: 0x0000FE88 File Offset: 0x0000E088
		[ExcludeFromDocs]
		public Color32[] GetPixels32()
		{
			int num = 0;
			return this.GetPixels32(num);
		}

		/// <summary>
		///   <para>Sets pixel colors of a 3D texture.</para>
		/// </summary>
		/// <param name="colors">The colors to set the pixels to.</param>
		/// <param name="miplevel">The mipmap level to be affected by the new colors.</param>
		// Token: 0x0600035E RID: 862
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetPixels(Color[] colors, [DefaultValue("0")] int miplevel);

		// Token: 0x0600035F RID: 863 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
		[ExcludeFromDocs]
		public void SetPixels(Color[] colors)
		{
			int num = 0;
			this.SetPixels(colors, num);
		}

		/// <summary>
		///   <para>Sets pixel colors of a 3D texture.</para>
		/// </summary>
		/// <param name="colors">The colors to set the pixels to.</param>
		/// <param name="miplevel">The mipmap level to be affected by the new colors.</param>
		// Token: 0x06000360 RID: 864
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetPixels32(Color32[] colors, [DefaultValue("0")] int miplevel);

		// Token: 0x06000361 RID: 865 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
		[ExcludeFromDocs]
		public void SetPixels32(Color32[] colors)
		{
			int num = 0;
			this.SetPixels32(colors, num);
		}

		/// <summary>
		///   <para>Actually apply all previous SetPixels changes.</para>
		/// </summary>
		/// <param name="updateMipmaps"></param>
		// Token: 0x06000362 RID: 866
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Apply([DefaultValue("true")] bool updateMipmaps);

		// Token: 0x06000363 RID: 867 RVA: 0x0000FED0 File Offset: 0x0000E0D0
		[ExcludeFromDocs]
		public void Apply()
		{
			bool flag = true;
			this.Apply(flag);
		}

		/// <summary>
		///   <para>The format of the pixel data in the texture (Read Only).</para>
		/// </summary>
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000364 RID: 868
		public extern TextureFormat format
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06000365 RID: 869
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] Texture3D mono, int width, int height, int depth, TextureFormat format, bool mipmap);
	}
}
