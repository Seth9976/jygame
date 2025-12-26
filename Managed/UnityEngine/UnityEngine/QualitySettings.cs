using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Script interface for.</para>
	/// </summary>
	// Token: 0x0200001C RID: 28
	public sealed class QualitySettings : Object
	{
		/// <summary>
		///   <para>The indexed list of available Quality Settings.</para>
		/// </summary>
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000D9 RID: 217
		public static extern string[] names
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns the current graphics quality level.</para>
		/// </summary>
		// Token: 0x060000DA RID: 218
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetQualityLevel();

		/// <summary>
		///   <para>Sets a new graphics quality level.</para>
		/// </summary>
		/// <param name="index">Quality index to set.</param>
		/// <param name="applyExpensiveChanges">Should expensive changes be applied (Anti-aliasing etc).</param>
		// Token: 0x060000DB RID: 219
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetQualityLevel(int index, [DefaultValue("true")] bool applyExpensiveChanges);

		// Token: 0x060000DC RID: 220 RVA: 0x0000F06C File Offset: 0x0000D26C
		[ExcludeFromDocs]
		public static void SetQualityLevel(int index)
		{
			bool flag = true;
			QualitySettings.SetQualityLevel(index, flag);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000DD RID: 221
		// (set) Token: 0x060000DE RID: 222
		[Obsolete("Use GetQualityLevel and SetQualityLevel")]
		public static extern QualityLevel currentLevel
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Increase the current quality level.</para>
		/// </summary>
		/// <param name="applyExpensiveChanges">Should expensive changes be applied (Anti-aliasing etc).</param>
		// Token: 0x060000DF RID: 223
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void IncreaseLevel([DefaultValue("false")] bool applyExpensiveChanges);

		// Token: 0x060000E0 RID: 224 RVA: 0x0000F084 File Offset: 0x0000D284
		[ExcludeFromDocs]
		public static void IncreaseLevel()
		{
			bool flag = false;
			QualitySettings.IncreaseLevel(flag);
		}

		/// <summary>
		///   <para>Decrease the current quality level.</para>
		/// </summary>
		/// <param name="applyExpensiveChanges">Should expensive changes be applied (Anti-aliasing etc).</param>
		// Token: 0x060000E1 RID: 225
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DecreaseLevel([DefaultValue("false")] bool applyExpensiveChanges);

		// Token: 0x060000E2 RID: 226 RVA: 0x0000F09C File Offset: 0x0000D29C
		[ExcludeFromDocs]
		public static void DecreaseLevel()
		{
			bool flag = false;
			QualitySettings.DecreaseLevel(flag);
		}

		/// <summary>
		///   <para>The maximum number of pixel lights that should affect any object.</para>
		/// </summary>
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000E3 RID: 227
		// (set) Token: 0x060000E4 RID: 228
		public static extern int pixelLightCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Directional light shadow projection.</para>
		/// </summary>
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000E5 RID: 229
		// (set) Token: 0x060000E6 RID: 230
		public static extern ShadowProjection shadowProjection
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Number of cascades to use for directional light shadows.</para>
		/// </summary>
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000E7 RID: 231
		// (set) Token: 0x060000E8 RID: 232
		public static extern int shadowCascades
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Shadow drawing distance.</para>
		/// </summary>
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000E9 RID: 233
		// (set) Token: 0x060000EA RID: 234
		public static extern float shadowDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Offset shadow frustum near plane.</para>
		/// </summary>
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000EB RID: 235
		// (set) Token: 0x060000EC RID: 236
		public static extern float shadowNearPlaneOffset
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The normalized cascade distribution for a 2 cascade setup. The value defines the position of the cascade with respect to Zero.</para>
		/// </summary>
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000ED RID: 237
		// (set) Token: 0x060000EE RID: 238
		public static extern float shadowCascade2Split
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The normalized cascade start position for a 4 cascade setup. Each member of the vector defines the normalized position of the coresponding cascade with respect to Zero.</para>
		/// </summary>
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000F0B4 File Offset: 0x0000D2B4
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x000022CB File Offset: 0x000004CB
		public static Vector3 shadowCascade4Split
		{
			get
			{
				Vector3 vector;
				QualitySettings.INTERNAL_get_shadowCascade4Split(out vector);
				return vector;
			}
			set
			{
				QualitySettings.INTERNAL_set_shadowCascade4Split(ref value);
			}
		}

		// Token: 0x060000F1 RID: 241
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_shadowCascade4Split(out Vector3 value);

		// Token: 0x060000F2 RID: 242
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_shadowCascade4Split(ref Vector3 value);

		/// <summary>
		///   <para>A texture size limit applied to all textures.</para>
		/// </summary>
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000F3 RID: 243
		// (set) Token: 0x060000F4 RID: 244
		public static extern int masterTextureLimit
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Global anisotropic filtering mode.</para>
		/// </summary>
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000F5 RID: 245
		// (set) Token: 0x060000F6 RID: 246
		public static extern AnisotropicFiltering anisotropicFiltering
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Global multiplier for the LOD's switching distance.</para>
		/// </summary>
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000F7 RID: 247
		// (set) Token: 0x060000F8 RID: 248
		public static extern float lodBias
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>A maximum LOD level. All LOD groups.</para>
		/// </summary>
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000F9 RID: 249
		// (set) Token: 0x060000FA RID: 250
		public static extern int maximumLODLevel
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Budget for how many ray casts can be performed per frame for approximate collision testing.</para>
		/// </summary>
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000FB RID: 251
		// (set) Token: 0x060000FC RID: 252
		public static extern int particleRaycastBudget
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Use a two-pass shader for the vegetation in the terrain engine.</para>
		/// </summary>
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000FD RID: 253
		// (set) Token: 0x060000FE RID: 254
		public static extern bool softVegetation
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Enables realtime reflection probes.</para>
		/// </summary>
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000FF RID: 255
		// (set) Token: 0x06000100 RID: 256
		public static extern bool realtimeReflectionProbes
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>If enabled, billboards will face towards camera position rather than camera orientation.</para>
		/// </summary>
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000101 RID: 257
		// (set) Token: 0x06000102 RID: 258
		public static extern bool billboardsFaceCameraPosition
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Maximum number of frames queued up by graphics driver.</para>
		/// </summary>
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000103 RID: 259
		// (set) Token: 0x06000104 RID: 260
		public static extern int maxQueuedFrames
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The VSync Count.</para>
		/// </summary>
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000105 RID: 261
		// (set) Token: 0x06000106 RID: 262
		public static extern int vSyncCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Set The AA Filtering option.</para>
		/// </summary>
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000107 RID: 263
		// (set) Token: 0x06000108 RID: 264
		public static extern int antiAliasing
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Desired color space.</para>
		/// </summary>
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000109 RID: 265
		public static extern ColorSpace desiredColorSpace
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Active color space.</para>
		/// </summary>
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600010A RID: 266
		public static extern ColorSpace activeColorSpace
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Blend weights.</para>
		/// </summary>
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600010B RID: 267
		// (set) Token: 0x0600010C RID: 268
		public static extern BlendWeights blendWeights
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}
	}
}
