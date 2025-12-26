using System;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine
{
	/// <summary>
	///   <para>The Render Settings contain values for a range of visual elements in your scene, like fog and ambient light.</para>
	/// </summary>
	// Token: 0x0200001B RID: 27
	public sealed class RenderSettings : Object
	{
		/// <summary>
		///   <para>Is fog enabled?</para>
		/// </summary>
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600009E RID: 158
		// (set) Token: 0x0600009F RID: 159
		public static extern bool fog
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Fog mode to use.</para>
		/// </summary>
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000A0 RID: 160
		// (set) Token: 0x060000A1 RID: 161
		public static extern FogMode fogMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The color of the fog.</para>
		/// </summary>
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000EFDC File Offset: 0x0000D1DC
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002295 File Offset: 0x00000495
		public static Color fogColor
		{
			get
			{
				Color color;
				RenderSettings.INTERNAL_get_fogColor(out color);
				return color;
			}
			set
			{
				RenderSettings.INTERNAL_set_fogColor(ref value);
			}
		}

		// Token: 0x060000A4 RID: 164
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_fogColor(out Color value);

		// Token: 0x060000A5 RID: 165
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_fogColor(ref Color value);

		/// <summary>
		///   <para>The density of the exponential fog.</para>
		/// </summary>
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000A6 RID: 166
		// (set) Token: 0x060000A7 RID: 167
		public static extern float fogDensity
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The starting distance of linear fog.</para>
		/// </summary>
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000A8 RID: 168
		// (set) Token: 0x060000A9 RID: 169
		public static extern float fogStartDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The ending distance of linear fog.</para>
		/// </summary>
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000AA RID: 170
		// (set) Token: 0x060000AB RID: 171
		public static extern float fogEndDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Ambient lighting mode.</para>
		/// </summary>
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000AC RID: 172
		// (set) Token: 0x060000AD RID: 173
		public static extern AmbientMode ambientMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Ambient lighting coming from above.</para>
		/// </summary>
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000EFF4 File Offset: 0x0000D1F4
		// (set) Token: 0x060000AF RID: 175 RVA: 0x0000229E File Offset: 0x0000049E
		public static Color ambientSkyColor
		{
			get
			{
				Color color;
				RenderSettings.INTERNAL_get_ambientSkyColor(out color);
				return color;
			}
			set
			{
				RenderSettings.INTERNAL_set_ambientSkyColor(ref value);
			}
		}

		// Token: 0x060000B0 RID: 176
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_ambientSkyColor(out Color value);

		// Token: 0x060000B1 RID: 177
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_ambientSkyColor(ref Color value);

		/// <summary>
		///   <para>Ambient lighting coming from the sides.</para>
		/// </summary>
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000F00C File Offset: 0x0000D20C
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000022A7 File Offset: 0x000004A7
		public static Color ambientEquatorColor
		{
			get
			{
				Color color;
				RenderSettings.INTERNAL_get_ambientEquatorColor(out color);
				return color;
			}
			set
			{
				RenderSettings.INTERNAL_set_ambientEquatorColor(ref value);
			}
		}

		// Token: 0x060000B4 RID: 180
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_ambientEquatorColor(out Color value);

		// Token: 0x060000B5 RID: 181
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_ambientEquatorColor(ref Color value);

		/// <summary>
		///   <para>Ambient lighting coming from below.</para>
		/// </summary>
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000F024 File Offset: 0x0000D224
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x000022B0 File Offset: 0x000004B0
		public static Color ambientGroundColor
		{
			get
			{
				Color color;
				RenderSettings.INTERNAL_get_ambientGroundColor(out color);
				return color;
			}
			set
			{
				RenderSettings.INTERNAL_set_ambientGroundColor(ref value);
			}
		}

		// Token: 0x060000B8 RID: 184
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_ambientGroundColor(out Color value);

		// Token: 0x060000B9 RID: 185
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_ambientGroundColor(ref Color value);

		/// <summary>
		///   <para>Flat ambient lighting color.</para>
		/// </summary>
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000F03C File Offset: 0x0000D23C
		// (set) Token: 0x060000BB RID: 187 RVA: 0x000022B9 File Offset: 0x000004B9
		public static Color ambientLight
		{
			get
			{
				Color color;
				RenderSettings.INTERNAL_get_ambientLight(out color);
				return color;
			}
			set
			{
				RenderSettings.INTERNAL_set_ambientLight(ref value);
			}
		}

		// Token: 0x060000BC RID: 188
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_ambientLight(out Color value);

		// Token: 0x060000BD RID: 189
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_ambientLight(ref Color value);

		/// <summary>
		///   <para>How much the light from the Ambient Source affects the scene.</para>
		/// </summary>
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000BE RID: 190
		// (set) Token: 0x060000BF RID: 191
		public static extern float ambientIntensity
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Custom or skybox ambient lighting data.</para>
		/// </summary>
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000F054 File Offset: 0x0000D254
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x000022C2 File Offset: 0x000004C2
		public static SphericalHarmonicsL2 ambientProbe
		{
			get
			{
				SphericalHarmonicsL2 sphericalHarmonicsL;
				RenderSettings.INTERNAL_get_ambientProbe(out sphericalHarmonicsL);
				return sphericalHarmonicsL;
			}
			set
			{
				RenderSettings.INTERNAL_set_ambientProbe(ref value);
			}
		}

		// Token: 0x060000C2 RID: 194
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_ambientProbe(out SphericalHarmonicsL2 value);

		// Token: 0x060000C3 RID: 195
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_ambientProbe(ref SphericalHarmonicsL2 value);

		/// <summary>
		///   <para>How much the skybox / custom cubemap reflection affects the scene.</para>
		/// </summary>
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000C4 RID: 196
		// (set) Token: 0x060000C5 RID: 197
		public static extern float reflectionIntensity
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The number of times a reflection includes other reflections.</para>
		/// </summary>
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000C6 RID: 198
		// (set) Token: 0x060000C7 RID: 199
		public static extern int reflectionBounces
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Size of the Light halos.</para>
		/// </summary>
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000C8 RID: 200
		// (set) Token: 0x060000C9 RID: 201
		public static extern float haloStrength
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The intensity of all flares in the scene.</para>
		/// </summary>
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000CA RID: 202
		// (set) Token: 0x060000CB RID: 203
		public static extern float flareStrength
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The fade speed of all flares in the scene.</para>
		/// </summary>
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000CC RID: 204
		// (set) Token: 0x060000CD RID: 205
		public static extern float flareFadeSpeed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The global skybox to use.</para>
		/// </summary>
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000CE RID: 206
		// (set) Token: 0x060000CF RID: 207
		public static extern Material skybox
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Default reflection mode.</para>
		/// </summary>
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000D0 RID: 208
		// (set) Token: 0x060000D1 RID: 209
		public static extern DefaultReflectionMode defaultReflectionMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Cubemap resolution for default reflection.</para>
		/// </summary>
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000D2 RID: 210
		// (set) Token: 0x060000D3 RID: 211
		public static extern int defaultReflectionResolution
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Custom specular reflection cubemap.</para>
		/// </summary>
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000D4 RID: 212
		// (set) Token: 0x060000D5 RID: 213
		public static extern Cubemap customReflection
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x060000D6 RID: 214
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Reset();

		// Token: 0x060000D7 RID: 215
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Object GetRenderSettings();
	}
}
