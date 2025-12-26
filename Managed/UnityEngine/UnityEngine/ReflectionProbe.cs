using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEngine
{
	/// <summary>
	///   <para>The reflection probe is used to capture the surroundings into a texture which is passed to the shaders and used for reflections.</para>
	/// </summary>
	// Token: 0x02000044 RID: 68
	public sealed class ReflectionProbe : Behaviour
	{
		/// <summary>
		///   <para>Reflection probe type.</para>
		/// </summary>
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060003B0 RID: 944
		// (set) Token: 0x060003B1 RID: 945
		public extern ReflectionProbeType type
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should this reflection probe use HDR rendering?</para>
		/// </summary>
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060003B2 RID: 946
		// (set) Token: 0x060003B3 RID: 947
		public extern bool hdr
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The size of the box area in which reflections will be applied to the objects. Measured in the probes's local space.</para>
		/// </summary>
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x0000FFFC File Offset: 0x0000E1FC
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x00002A99 File Offset: 0x00000C99
		public Vector3 size
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_size(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_size(ref value);
			}
		}

		// Token: 0x060003B6 RID: 950
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_size(out Vector3 value);

		// Token: 0x060003B7 RID: 951
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_size(ref Vector3 value);

		/// <summary>
		///   <para>The center of the box area in which reflections will be applied to the objects. Measured in the probes's local space.</para>
		/// </summary>
		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00010014 File Offset: 0x0000E214
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00002AA3 File Offset: 0x00000CA3
		public Vector3 center
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_center(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_center(ref value);
			}
		}

		// Token: 0x060003BA RID: 954
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_center(out Vector3 value);

		// Token: 0x060003BB RID: 955
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_center(ref Vector3 value);

		/// <summary>
		///   <para>The near clipping plane distance when rendering the probe.</para>
		/// </summary>
		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060003BC RID: 956
		// (set) Token: 0x060003BD RID: 957
		public extern float nearClipPlane
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The far clipping plane distance when rendering the probe.</para>
		/// </summary>
		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003BE RID: 958
		// (set) Token: 0x060003BF RID: 959
		public extern float farClipPlane
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Shadow drawing distance when rendering the probe.</para>
		/// </summary>
		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003C0 RID: 960
		// (set) Token: 0x060003C1 RID: 961
		public extern float shadowDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Resolution of the underlying reflection texture in pixels.</para>
		/// </summary>
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003C2 RID: 962
		// (set) Token: 0x060003C3 RID: 963
		public extern int resolution
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>This is used to render parts of the reflecion probe's surrounding selectively.</para>
		/// </summary>
		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003C4 RID: 964
		// (set) Token: 0x060003C5 RID: 965
		public extern int cullingMask
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>How the reflection probe clears the background.</para>
		/// </summary>
		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003C6 RID: 966
		// (set) Token: 0x060003C7 RID: 967
		public extern ReflectionProbeClearFlags clearFlags
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The color with which the texture of reflection probe will be cleared.</para>
		/// </summary>
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x0001002C File Offset: 0x0000E22C
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x00002AAD File Offset: 0x00000CAD
		public Color backgroundColor
		{
			get
			{
				Color color;
				this.INTERNAL_get_backgroundColor(out color);
				return color;
			}
			set
			{
				this.INTERNAL_set_backgroundColor(ref value);
			}
		}

		// Token: 0x060003CA RID: 970
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_backgroundColor(out Color value);

		// Token: 0x060003CB RID: 971
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_backgroundColor(ref Color value);

		/// <summary>
		///   <para>The intensity modifier that is applied to the texture of reflection probe in the shader.</para>
		/// </summary>
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003CC RID: 972
		// (set) Token: 0x060003CD RID: 973
		public extern float intensity
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Distance around probe used for blending (used in deferred probes).</para>
		/// </summary>
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003CE RID: 974
		// (set) Token: 0x060003CF RID: 975
		public extern float blendDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should this reflection probe use box projection?</para>
		/// </summary>
		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003D0 RID: 976
		// (set) Token: 0x060003D1 RID: 977
		public extern bool boxProjection
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The bounding volume of the reflection probe (Read Only).</para>
		/// </summary>
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00010044 File Offset: 0x0000E244
		public Bounds bounds
		{
			get
			{
				Bounds bounds;
				this.INTERNAL_get_bounds(out bounds);
				return bounds;
			}
		}

		// Token: 0x060003D3 RID: 979
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_bounds(out Bounds value);

		/// <summary>
		///   <para>Should reflection probe texture be generated in the Editor (ReflectionProbeMode.Baked) or should probe use custom specified texure (ReflectionProbeMode.Custom)?</para>
		/// </summary>
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003D4 RID: 980
		// (set) Token: 0x060003D5 RID: 981
		public extern ReflectionProbeMode mode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Reflection probe importance.</para>
		/// </summary>
		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003D6 RID: 982
		// (set) Token: 0x060003D7 RID: 983
		public extern int importance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Sets the way the probe will refresh.
		///
		/// See Also: ReflectionProbeRefreshMode.</para>
		/// </summary>
		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003D8 RID: 984
		// (set) Token: 0x060003D9 RID: 985
		public extern ReflectionProbeRefreshMode refreshMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Sets this probe time-slicing mode
		///
		/// See Also: ReflectionProbeTimeSlicingMode.</para>
		/// </summary>
		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003DA RID: 986
		// (set) Token: 0x060003DB RID: 987
		public extern ReflectionProbeTimeSlicingMode timeSlicingMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Reference to the baked texture of the reflection probe's surrounding.</para>
		/// </summary>
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003DC RID: 988
		// (set) Token: 0x060003DD RID: 989
		public extern Texture bakedTexture
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Reference to the baked texture of the reflection probe's surrounding. Use this to assign custom reflection texture.</para>
		/// </summary>
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003DE RID: 990
		// (set) Token: 0x060003DF RID: 991
		public extern Texture customBakedTexture
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Texture which is passed to the shader of the objects in the vicinity of the reflection probe (Read Only).</para>
		/// </summary>
		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003E0 RID: 992
		public extern Texture texture
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Refreshes the probe's cubemap.</para>
		/// </summary>
		/// <param name="targetTexture">Target RendeTexture in which rendering should be done. Specifying null will update the probe's default texture.</param>
		/// <returns>
		///   <para>
		///     An integer representing a RenderID which can subsequently be used to check if the probe has finished rendering while rendering in time-slice mode.
		///
		///     See Also: IsFinishedRendering
		///     See Also: timeSlicingMode
		///   </para>
		/// </returns>
		// Token: 0x060003E1 RID: 993
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int RenderProbe([DefaultValue("null")] RenderTexture targetTexture);

		// Token: 0x060003E2 RID: 994 RVA: 0x0001005C File Offset: 0x0000E25C
		[ExcludeFromDocs]
		public int RenderProbe()
		{
			RenderTexture renderTexture = null;
			return this.RenderProbe(renderTexture);
		}

		/// <summary>
		///   <para>Checks if a probe has finished a time-sliced render.</para>
		/// </summary>
		/// <param name="renderId">An integer representing the RenderID as returned by the RenderProbe method.</param>
		/// <returns>
		///   <para>
		///     True if the render has finished, false otherwise.
		///
		///     See Also: timeSlicingMode
		///   </para>
		/// </returns>
		// Token: 0x060003E3 RID: 995
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsFinishedRendering(int renderId);

		/// <summary>
		///   <para>Utility method to blend 2 cubemaps into a target render texture.</para>
		/// </summary>
		/// <param name="src">Cubemap to blend from.</param>
		/// <param name="dst">Cubemap to blend to.</param>
		/// <param name="blend">Blend weight.</param>
		/// <param name="target">RenderTexture which will hold the result of the blend.</param>
		/// <returns>
		///   <para>Returns trues if cubemaps were blended, false otherwise.</para>
		/// </returns>
		// Token: 0x060003E4 RID: 996
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target);
	}
}
