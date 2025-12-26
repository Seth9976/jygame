using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Format used when creating textures from scripts.</para>
	/// </summary>
	// Token: 0x02000277 RID: 631
	public enum TextureFormat
	{
		/// <summary>
		///   <para>Alpha-only texture format.</para>
		/// </summary>
		// Token: 0x04000956 RID: 2390
		Alpha8 = 1,
		/// <summary>
		///   <para>A 16 bits/pixel texture format. Texture stores color with an alpha channel.</para>
		/// </summary>
		// Token: 0x04000957 RID: 2391
		ARGB4444,
		/// <summary>
		///   <para>A color texture format.</para>
		/// </summary>
		// Token: 0x04000958 RID: 2392
		RGB24,
		/// <summary>
		///   <para>Color with alpha texture format, 8-bits per channel.</para>
		/// </summary>
		// Token: 0x04000959 RID: 2393
		RGBA32,
		/// <summary>
		///   <para>Color with an alpha channel texture format.</para>
		/// </summary>
		// Token: 0x0400095A RID: 2394
		ARGB32,
		/// <summary>
		///   <para>A 16 bit color texture format.</para>
		/// </summary>
		// Token: 0x0400095B RID: 2395
		RGB565 = 7,
		/// <summary>
		///   <para>A 16 bit color texture format that only has a red channel.</para>
		/// </summary>
		// Token: 0x0400095C RID: 2396
		R16 = 9,
		/// <summary>
		///   <para>Compressed color texture format.</para>
		/// </summary>
		// Token: 0x0400095D RID: 2397
		DXT1,
		/// <summary>
		///   <para>Compressed color with alpha channel texture format.</para>
		/// </summary>
		// Token: 0x0400095E RID: 2398
		DXT5 = 12,
		/// <summary>
		///   <para>Color and alpha  texture format, 4 bit per channel.</para>
		/// </summary>
		// Token: 0x0400095F RID: 2399
		RGBA4444,
		/// <summary>
		///   <para>Format returned by iPhone camera.</para>
		/// </summary>
		// Token: 0x04000960 RID: 2400
		BGRA32,
		/// <summary>
		///   <para>Scalar (R)  texture format, 16 bit floating point.</para>
		/// </summary>
		// Token: 0x04000961 RID: 2401
		RHalf,
		/// <summary>
		///   <para>Two color (RG)  texture format, 16 bit floating point per channel.</para>
		/// </summary>
		// Token: 0x04000962 RID: 2402
		RGHalf,
		/// <summary>
		///   <para>RGB color and alpha texture format, 16 bit floating point per channel.</para>
		/// </summary>
		// Token: 0x04000963 RID: 2403
		RGBAHalf,
		/// <summary>
		///   <para>Scalar (R) texture format, 32 bit floating point.</para>
		/// </summary>
		// Token: 0x04000964 RID: 2404
		RFloat,
		/// <summary>
		///   <para>Two color (RG)  texture format, 32 bit floating point per channel.</para>
		/// </summary>
		// Token: 0x04000965 RID: 2405
		RGFloat,
		/// <summary>
		///   <para>RGB color and alpha etxture format,  32-bit floats per channel.</para>
		/// </summary>
		// Token: 0x04000966 RID: 2406
		RGBAFloat,
		/// <summary>
		///   <para>A format that uses the YUV color space and is often used for video encoding.  Currently, this texture format is only useful for native code plugins as there is no support for texture importing or pixel access for this format.  YUY2 is implemented for Direct3D 9, Direct3D 11, and Xbox One.</para>
		/// </summary>
		// Token: 0x04000967 RID: 2407
		YUY2,
		/// <summary>
		///   <para>Compressed color texture format with crunch compression for small storage sizes.</para>
		/// </summary>
		// Token: 0x04000968 RID: 2408
		DXT1Crunched = 28,
		/// <summary>
		///   <para>Compressed color with alpha channel texture format with crunch compression for small storage sizes.</para>
		/// </summary>
		// Token: 0x04000969 RID: 2409
		DXT5Crunched,
		/// <summary>
		///   <para>PowerVR (iOS) 2 bits/pixel compressed color texture format.</para>
		/// </summary>
		// Token: 0x0400096A RID: 2410
		PVRTC_RGB2,
		/// <summary>
		///   <para>PowerVR (iOS) 2 bits/pixel compressed with alpha channel texture format.</para>
		/// </summary>
		// Token: 0x0400096B RID: 2411
		PVRTC_RGBA2,
		/// <summary>
		///   <para>PowerVR (iOS) 4 bits/pixel compressed color texture format.</para>
		/// </summary>
		// Token: 0x0400096C RID: 2412
		PVRTC_RGB4,
		/// <summary>
		///   <para>PowerVR (iOS) 4 bits/pixel compressed with alpha channel texture format.</para>
		/// </summary>
		// Token: 0x0400096D RID: 2413
		PVRTC_RGBA4,
		/// <summary>
		///   <para>ETC (GLES2.0) 4 bits/pixel compressed RGB texture format.</para>
		/// </summary>
		// Token: 0x0400096E RID: 2414
		ETC_RGB4,
		/// <summary>
		///   <para>ATC (ATITC) 4 bits/pixel compressed RGB texture format.</para>
		/// </summary>
		// Token: 0x0400096F RID: 2415
		ATC_RGB4,
		/// <summary>
		///   <para>ATC (ATITC) 8 bits/pixel compressed RGB texture format.</para>
		/// </summary>
		// Token: 0x04000970 RID: 2416
		ATC_RGBA8,
		/// <summary>
		///   <para>ETC2  EAC (GL ES 3.0) 4 bitspixel compressed unsigned single-channel texture format.</para>
		/// </summary>
		// Token: 0x04000971 RID: 2417
		EAC_R = 41,
		/// <summary>
		///   <para>ETC2  EAC (GL ES 3.0) 4 bitspixel compressed signed single-channel texture format.</para>
		/// </summary>
		// Token: 0x04000972 RID: 2418
		EAC_R_SIGNED,
		/// <summary>
		///   <para>ETC2  EAC (GL ES 3.0) 8 bitspixel compressed unsigned dual-channel (RG) texture format.</para>
		/// </summary>
		// Token: 0x04000973 RID: 2419
		EAC_RG,
		/// <summary>
		///   <para>ETC2  EAC (GL ES 3.0) 8 bitspixel compressed signed dual-channel (RG) texture format.</para>
		/// </summary>
		// Token: 0x04000974 RID: 2420
		EAC_RG_SIGNED,
		/// <summary>
		///   <para>ETC2 (GL ES 3.0) 4 bits/pixel compressed RGB texture format.</para>
		/// </summary>
		// Token: 0x04000975 RID: 2421
		ETC2_RGB,
		/// <summary>
		///   <para>ETC2 (GL ES 3.0) 4 bits/pixel RGB+1-bit alpha texture format.</para>
		/// </summary>
		// Token: 0x04000976 RID: 2422
		ETC2_RGBA1,
		/// <summary>
		///   <para>ETC2 (GL ES 3.0) 8 bits/pixel compressed RGBA texture format.</para>
		/// </summary>
		// Token: 0x04000977 RID: 2423
		ETC2_RGBA8,
		/// <summary>
		///   <para>ASTC (4x4 pixel block in 128 bits) compressed RGB texture format.</para>
		/// </summary>
		// Token: 0x04000978 RID: 2424
		ASTC_RGB_4x4,
		/// <summary>
		///   <para>ASTC (5x5 pixel block in 128 bits) compressed RGB texture format.</para>
		/// </summary>
		// Token: 0x04000979 RID: 2425
		ASTC_RGB_5x5,
		/// <summary>
		///   <para>ASTC (6x6 pixel block in 128 bits) compressed RGB texture format.</para>
		/// </summary>
		// Token: 0x0400097A RID: 2426
		ASTC_RGB_6x6,
		/// <summary>
		///   <para>ASTC (8x8 pixel block in 128 bits) compressed RGB texture format.</para>
		/// </summary>
		// Token: 0x0400097B RID: 2427
		ASTC_RGB_8x8,
		/// <summary>
		///   <para>ASTC (10x10 pixel block in 128 bits) compressed RGB texture format.</para>
		/// </summary>
		// Token: 0x0400097C RID: 2428
		ASTC_RGB_10x10,
		/// <summary>
		///   <para>ASTC (12x12 pixel block in 128 bits) compressed RGB texture format.</para>
		/// </summary>
		// Token: 0x0400097D RID: 2429
		ASTC_RGB_12x12,
		/// <summary>
		///   <para>ASTC (4x4 pixel block in 128 bits) compressed RGBA texture format.</para>
		/// </summary>
		// Token: 0x0400097E RID: 2430
		ASTC_RGBA_4x4,
		/// <summary>
		///   <para>ASTC (5x5 pixel block in 128 bits) compressed RGBA texture format.</para>
		/// </summary>
		// Token: 0x0400097F RID: 2431
		ASTC_RGBA_5x5,
		/// <summary>
		///   <para>ASTC (6x6 pixel block in 128 bits) compressed RGBA texture format.</para>
		/// </summary>
		// Token: 0x04000980 RID: 2432
		ASTC_RGBA_6x6,
		/// <summary>
		///   <para>ASTC (8x8 pixel block in 128 bits) compressed RGBA texture format.</para>
		/// </summary>
		// Token: 0x04000981 RID: 2433
		ASTC_RGBA_8x8,
		/// <summary>
		///   <para>ASTC (10x10 pixel block in 128 bits) compressed RGBA texture format.</para>
		/// </summary>
		// Token: 0x04000982 RID: 2434
		ASTC_RGBA_10x10,
		/// <summary>
		///   <para>ASTC (12x12 pixel block in 128 bits) compressed RGBA texture format.</para>
		/// </summary>
		// Token: 0x04000983 RID: 2435
		ASTC_RGBA_12x12,
		/// <summary>
		///   <para>ETC (Nintendo 3DS) 4 bits/pixel compressed RGB texture format.</para>
		/// </summary>
		// Token: 0x04000984 RID: 2436
		ETC_RGB4_3DS,
		/// <summary>
		///   <para>ETC (Nintendo 3DS) 4 bitspixel RGB + 4 bitspixel Alpha compressed texture format.</para>
		/// </summary>
		// Token: 0x04000985 RID: 2437
		ETC_RGBA8_3DS
	}
}
