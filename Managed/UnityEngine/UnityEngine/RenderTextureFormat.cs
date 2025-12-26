using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Format of a RenderTexture.</para>
	/// </summary>
	// Token: 0x02000279 RID: 633
	public enum RenderTextureFormat
	{
		/// <summary>
		///   <para>Color render texture format, 8 bits per channel.</para>
		/// </summary>
		// Token: 0x0400098F RID: 2447
		ARGB32,
		/// <summary>
		///   <para>A depth render texture format.</para>
		/// </summary>
		// Token: 0x04000990 RID: 2448
		Depth,
		/// <summary>
		///   <para>Color render texture format, 16 bit floating point per channel.</para>
		/// </summary>
		// Token: 0x04000991 RID: 2449
		ARGBHalf,
		/// <summary>
		///   <para>A native shadowmap render texture format.</para>
		/// </summary>
		// Token: 0x04000992 RID: 2450
		Shadowmap,
		/// <summary>
		///   <para>Color render texture format.</para>
		/// </summary>
		// Token: 0x04000993 RID: 2451
		RGB565,
		/// <summary>
		///   <para>Color render texture format, 4 bit per channel.</para>
		/// </summary>
		// Token: 0x04000994 RID: 2452
		ARGB4444,
		/// <summary>
		///   <para>Color render texture format, 1 bit for Alpha channel, 5 bits for Red, Green and Blue channels.</para>
		/// </summary>
		// Token: 0x04000995 RID: 2453
		ARGB1555,
		/// <summary>
		///   <para>Default color render texture format: will be chosen accordingly to Frame Buffer format and Platform.</para>
		/// </summary>
		// Token: 0x04000996 RID: 2454
		Default,
		/// <summary>
		///   <para>Color render texture format. 10 bits for colors, 2 bits for alpha.</para>
		/// </summary>
		// Token: 0x04000997 RID: 2455
		ARGB2101010,
		/// <summary>
		///   <para>Default HDR color render texture format: will be chosen accordingly to Frame Buffer format and Platform.</para>
		/// </summary>
		// Token: 0x04000998 RID: 2456
		DefaultHDR,
		/// <summary>
		///   <para>Color render texture format, 32 bit floating point per channel.</para>
		/// </summary>
		// Token: 0x04000999 RID: 2457
		ARGBFloat = 11,
		/// <summary>
		///   <para>Two color (RG) render texture format, 32 bit floating point per channel.</para>
		/// </summary>
		// Token: 0x0400099A RID: 2458
		RGFloat,
		/// <summary>
		///   <para>Two color (RG) render texture format, 16 bit floating point per channel.</para>
		/// </summary>
		// Token: 0x0400099B RID: 2459
		RGHalf,
		/// <summary>
		///   <para>Scalar (R) render texture format, 32 bit floating point.</para>
		/// </summary>
		// Token: 0x0400099C RID: 2460
		RFloat,
		/// <summary>
		///   <para>Scalar (R) render texture format, 16 bit floating point.</para>
		/// </summary>
		// Token: 0x0400099D RID: 2461
		RHalf,
		/// <summary>
		///   <para>Scalar (R) render texture format, 8 bit fixed point.</para>
		/// </summary>
		// Token: 0x0400099E RID: 2462
		R8,
		/// <summary>
		///   <para>Four channel (ARGB) render texture format, 32 bit signed integer per channel.</para>
		/// </summary>
		// Token: 0x0400099F RID: 2463
		ARGBInt,
		/// <summary>
		///   <para>Two channel (RG) render texture format, 32 bit signed integer per channel.</para>
		/// </summary>
		// Token: 0x040009A0 RID: 2464
		RGInt,
		/// <summary>
		///   <para>Scalar (R) render texture format, 32 bit signed integer.</para>
		/// </summary>
		// Token: 0x040009A1 RID: 2465
		RInt
	}
}
