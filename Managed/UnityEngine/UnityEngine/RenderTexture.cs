using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Render textures are textures that can be rendered to.</para>
	/// </summary>
	// Token: 0x02000043 RID: 67
	public sealed class RenderTexture : Texture
	{
		/// <summary>
		///   <para>Creates a new RenderTexture object.</para>
		/// </summary>
		/// <param name="width">Texture width in pixels.</param>
		/// <param name="height">Texture height in pixels.</param>
		/// <param name="depth">Number of bits in depth buffer (0, 16 or 24). Note that only 24 bit depth has stencil buffer.</param>
		/// <param name="format">Texture color format.</param>
		/// <param name="readWrite">How or if color space conversions should be done on texture read/write.</param>
		// Token: 0x0600036F RID: 879 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		public RenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			RenderTexture.Internal_CreateRenderTexture(this);
			this.width = width;
			this.height = height;
			this.depth = depth;
			this.format = format;
			bool flag = readWrite == RenderTextureReadWrite.sRGB;
			if (readWrite == RenderTextureReadWrite.Default)
			{
				flag = QualitySettings.activeColorSpace == ColorSpace.Linear;
			}
			RenderTexture.Internal_SetSRGBReadWrite(this, flag);
		}

		/// <summary>
		///   <para>Creates a new RenderTexture object.</para>
		/// </summary>
		/// <param name="width">Texture width in pixels.</param>
		/// <param name="height">Texture height in pixels.</param>
		/// <param name="depth">Number of bits in depth buffer (0, 16 or 24). Note that only 24 bit depth has stencil buffer.</param>
		/// <param name="format">Texture color format.</param>
		/// <param name="readWrite">How or if color space conversions should be done on texture read/write.</param>
		// Token: 0x06000370 RID: 880 RVA: 0x000029DE File Offset: 0x00000BDE
		public RenderTexture(int width, int height, int depth, RenderTextureFormat format)
		{
			RenderTexture.Internal_CreateRenderTexture(this);
			this.width = width;
			this.height = height;
			this.depth = depth;
			this.format = format;
			RenderTexture.Internal_SetSRGBReadWrite(this, QualitySettings.activeColorSpace == ColorSpace.Linear);
		}

		/// <summary>
		///   <para>Creates a new RenderTexture object.</para>
		/// </summary>
		/// <param name="width">Texture width in pixels.</param>
		/// <param name="height">Texture height in pixels.</param>
		/// <param name="depth">Number of bits in depth buffer (0, 16 or 24). Note that only 24 bit depth has stencil buffer.</param>
		/// <param name="format">Texture color format.</param>
		/// <param name="readWrite">How or if color space conversions should be done on texture read/write.</param>
		// Token: 0x06000371 RID: 881 RVA: 0x00002A17 File Offset: 0x00000C17
		public RenderTexture(int width, int height, int depth)
		{
			RenderTexture.Internal_CreateRenderTexture(this);
			this.width = width;
			this.height = height;
			this.depth = depth;
			this.format = RenderTextureFormat.Default;
			RenderTexture.Internal_SetSRGBReadWrite(this, QualitySettings.activeColorSpace == ColorSpace.Linear);
		}

		// Token: 0x06000372 RID: 882
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateRenderTexture([Writable] RenderTexture rt);

		/// <summary>
		///   <para>Allocate a temporary render texture.</para>
		/// </summary>
		/// <param name="width">Width in pixels.</param>
		/// <param name="height">Height in pixels.</param>
		/// <param name="depthBuffer">Depth buffer bits (0, 16 or 24). Note that only 24 bit depth has stencil buffer.</param>
		/// <param name="format">Render texture format.</param>
		/// <param name="readWrite">sRGB handling mode.</param>
		/// <param name="antiAliasing">Anti-aliasing (1,2,4,8).</param>
		// Token: 0x06000373 RID: 883
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern RenderTexture GetTemporary(int width, int height, [DefaultValue("0")] int depthBuffer, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat format, [DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite, [DefaultValue("1")] int antiAliasing);

		// Token: 0x06000374 RID: 884 RVA: 0x0000FF3C File Offset: 0x0000E13C
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			int num = 1;
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, readWrite, num);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000FF58 File Offset: 0x0000E158
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format)
		{
			int num = 1;
			RenderTextureReadWrite renderTextureReadWrite = RenderTextureReadWrite.Default;
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, renderTextureReadWrite, num);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000FF74 File Offset: 0x0000E174
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer)
		{
			int num = 1;
			RenderTextureReadWrite renderTextureReadWrite = RenderTextureReadWrite.Default;
			RenderTextureFormat renderTextureFormat = RenderTextureFormat.Default;
			return RenderTexture.GetTemporary(width, height, depthBuffer, renderTextureFormat, renderTextureReadWrite, num);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000FF94 File Offset: 0x0000E194
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height)
		{
			int num = 1;
			RenderTextureReadWrite renderTextureReadWrite = RenderTextureReadWrite.Default;
			RenderTextureFormat renderTextureFormat = RenderTextureFormat.Default;
			int num2 = 0;
			return RenderTexture.GetTemporary(width, height, num2, renderTextureFormat, renderTextureReadWrite, num);
		}

		/// <summary>
		///   <para>Release a temporary texture allocated with GetTemporary.</para>
		/// </summary>
		/// <param name="temp"></param>
		// Token: 0x06000378 RID: 888
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ReleaseTemporary(RenderTexture temp);

		// Token: 0x06000379 RID: 889
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetWidth(RenderTexture mono);

		// Token: 0x0600037A RID: 890
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetWidth(RenderTexture mono, int width);

		// Token: 0x0600037B RID: 891
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetHeight(RenderTexture mono);

		// Token: 0x0600037C RID: 892
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetHeight(RenderTexture mono, int width);

		// Token: 0x0600037D RID: 893
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetSRGBReadWrite(RenderTexture mono, bool sRGB);

		/// <summary>
		///   <para>The width of the render texture in pixels.</para>
		/// </summary>
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00002A4F File Offset: 0x00000C4F
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00002A57 File Offset: 0x00000C57
		public override int width
		{
			get
			{
				return RenderTexture.Internal_GetWidth(this);
			}
			set
			{
				RenderTexture.Internal_SetWidth(this, value);
			}
		}

		/// <summary>
		///   <para>The height of the render texture in pixels.</para>
		/// </summary>
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00002A60 File Offset: 0x00000C60
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00002A68 File Offset: 0x00000C68
		public override int height
		{
			get
			{
				return RenderTexture.Internal_GetHeight(this);
			}
			set
			{
				RenderTexture.Internal_SetHeight(this, value);
			}
		}

		/// <summary>
		///   <para>The precision of the render texture's depth buffer in bits (0, 16, 24 are supported).</para>
		/// </summary>
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000382 RID: 898
		// (set) Token: 0x06000383 RID: 899
		public extern int depth
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000384 RID: 900
		// (set) Token: 0x06000385 RID: 901
		public extern bool isPowerOfTwo
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Does this render texture use sRGB read / write (Read Only).</para>
		/// </summary>
		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000386 RID: 902
		public extern bool sRGB
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The color format of the render texture.</para>
		/// </summary>
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000387 RID: 903
		// (set) Token: 0x06000388 RID: 904
		public extern RenderTextureFormat format
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Use mipmaps on a render texture?</para>
		/// </summary>
		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000389 RID: 905
		// (set) Token: 0x0600038A RID: 906
		public extern bool useMipMap
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should mipmap levels be generated automatically?</para>
		/// </summary>
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600038B RID: 907
		// (set) Token: 0x0600038C RID: 908
		public extern bool generateMips
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>If enabled, this Render Texture will be used as a Cubemap.</para>
		/// </summary>
		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600038D RID: 909
		// (set) Token: 0x0600038E RID: 910
		public extern bool isCubemap
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>If enabled, this Render Texture will be used as a Texture3D.</para>
		/// </summary>
		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600038F RID: 911
		// (set) Token: 0x06000390 RID: 912
		public extern bool isVolume
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Volume extent of a 3D render texture.</para>
		/// </summary>
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000391 RID: 913
		// (set) Token: 0x06000392 RID: 914
		public extern int volumeDepth
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The antialiasing level for the RenderTexture.</para>
		/// </summary>
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000393 RID: 915
		// (set) Token: 0x06000394 RID: 916
		public extern int antiAliasing
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Enable random access write into this render texture on Shader Model 5.0 level shaders.</para>
		/// </summary>
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000395 RID: 917
		// (set) Token: 0x06000396 RID: 918
		public extern bool enableRandomWrite
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Actually creates the RenderTexture.</para>
		/// </summary>
		// Token: 0x06000397 RID: 919 RVA: 0x00002A71 File Offset: 0x00000C71
		public bool Create()
		{
			return RenderTexture.INTERNAL_CALL_Create(this);
		}

		// Token: 0x06000398 RID: 920
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Create(RenderTexture self);

		/// <summary>
		///   <para>Releases the RenderTexture.</para>
		/// </summary>
		// Token: 0x06000399 RID: 921 RVA: 0x00002A79 File Offset: 0x00000C79
		public void Release()
		{
			RenderTexture.INTERNAL_CALL_Release(this);
		}

		// Token: 0x0600039A RID: 922
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Release(RenderTexture self);

		/// <summary>
		///   <para>Is the render texture actually created?</para>
		/// </summary>
		// Token: 0x0600039B RID: 923 RVA: 0x00002A81 File Offset: 0x00000C81
		public bool IsCreated()
		{
			return RenderTexture.INTERNAL_CALL_IsCreated(this);
		}

		// Token: 0x0600039C RID: 924
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_IsCreated(RenderTexture self);

		/// <summary>
		///   <para>Discards the contents of the RenderTexture.</para>
		/// </summary>
		/// <param name="discardColor">Should the colour buffer be discarded?</param>
		/// <param name="discardDepth">Should the depth buffer be discarded?</param>
		// Token: 0x0600039D RID: 925 RVA: 0x00002A89 File Offset: 0x00000C89
		public void DiscardContents()
		{
			RenderTexture.INTERNAL_CALL_DiscardContents(this);
		}

		// Token: 0x0600039E RID: 926
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_DiscardContents(RenderTexture self);

		/// <summary>
		///   <para>Discards the contents of the RenderTexture.</para>
		/// </summary>
		/// <param name="discardColor">Should the colour buffer be discarded?</param>
		/// <param name="discardDepth">Should the depth buffer be discarded?</param>
		// Token: 0x0600039F RID: 927
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void DiscardContents(bool discardColor, bool discardDepth);

		/// <summary>
		///   <para>Indicate that there's a RenderTexture restore operation expected.</para>
		/// </summary>
		// Token: 0x060003A0 RID: 928 RVA: 0x00002A91 File Offset: 0x00000C91
		public void MarkRestoreExpected()
		{
			RenderTexture.INTERNAL_CALL_MarkRestoreExpected(this);
		}

		// Token: 0x060003A1 RID: 929
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_MarkRestoreExpected(RenderTexture self);

		/// <summary>
		///   <para>Color buffer of the render texture (Read Only).</para>
		/// </summary>
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0000FFB4 File Offset: 0x0000E1B4
		public RenderBuffer colorBuffer
		{
			get
			{
				RenderBuffer renderBuffer;
				this.GetColorBuffer(out renderBuffer);
				return renderBuffer;
			}
		}

		/// <summary>
		///   <para>Depth/stencil buffer of the render texture (Read Only).</para>
		/// </summary>
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0000FFCC File Offset: 0x0000E1CC
		public RenderBuffer depthBuffer
		{
			get
			{
				RenderBuffer renderBuffer;
				this.GetDepthBuffer(out renderBuffer);
				return renderBuffer;
			}
		}

		// Token: 0x060003A4 RID: 932
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetColorBuffer(out RenderBuffer res);

		// Token: 0x060003A5 RID: 933
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetDepthBuffer(out RenderBuffer res);

		/// <summary>
		///   <para>Assigns this RenderTexture as a global shader property named propertyName.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		// Token: 0x060003A6 RID: 934
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetGlobalShaderProperty(string propertyName);

		/// <summary>
		///   <para>Currently active render texture.</para>
		/// </summary>
		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060003A7 RID: 935
		// (set) Token: 0x060003A8 RID: 936
		public static extern RenderTexture active
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060003A9 RID: 937
		// (set) Token: 0x060003AA RID: 938
		[Obsolete("Use SystemInfo.supportsRenderTextures instead.")]
		public static extern bool enabled
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x060003AB RID: 939
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetTexelOffset(RenderTexture tex, out Vector2 output);

		// Token: 0x060003AC RID: 940 RVA: 0x0000FFE4 File Offset: 0x0000E1E4
		public Vector2 GetTexelOffset()
		{
			Vector2 vector;
			RenderTexture.Internal_GetTexelOffset(this, out vector);
			return vector;
		}

		/// <summary>
		///   <para>Does a RenderTexture have stencil buffer?</para>
		/// </summary>
		/// <param name="rt">Render texture, or null for main screen.</param>
		// Token: 0x060003AD RID: 941
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SupportsStencil(RenderTexture rt);

		// Token: 0x060003AE RID: 942 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("SetBorderColor is no longer supported.", true)]
		public void SetBorderColor(Color color)
		{
		}
	}
}
