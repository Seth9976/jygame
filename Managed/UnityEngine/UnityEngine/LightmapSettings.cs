using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Stores lightmaps of the scene.</para>
	/// </summary>
	// Token: 0x02000032 RID: 50
	public sealed class LightmapSettings : Object
	{
		/// <summary>
		///   <para>Lightmap array.</para>
		/// </summary>
		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600027E RID: 638
		// (set) Token: 0x0600027F RID: 639
		public static extern LightmapData[] lightmaps
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000280 RID: 640
		// (set) Token: 0x06000281 RID: 641
		[Obsolete("Use lightmapsMode property")]
		public static extern LightmapsModeLegacy lightmapsModeLegacy
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Non-directional, Directional or Directional Specular lightmaps rendering mode.</para>
		/// </summary>
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000282 RID: 642
		// (set) Token: 0x06000283 RID: 643
		public static extern LightmapsMode lightmapsMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Color space of the lightmap.</para>
		/// </summary>
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0000275D File Offset: 0x0000095D
		// (set) Token: 0x06000285 RID: 645 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("bakedColorSpace is no longer valid. Use QualitySettings.desiredColorSpace.", false)]
		public static ColorSpace bakedColorSpace
		{
			get
			{
				return QualitySettings.desiredColorSpace;
			}
			set
			{
			}
		}

		/// <summary>
		///   <para>Holds all data needed by the light probes.</para>
		/// </summary>
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000286 RID: 646
		// (set) Token: 0x06000287 RID: 647
		public static extern LightProbes lightProbes
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000288 RID: 648
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Reset();
	}
}
