using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine
{
	/// <summary>
	///   <para>General functionality for all renderers.</para>
	/// </summary>
	// Token: 0x02000024 RID: 36
	public class Renderer : Component
	{
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000191 RID: 401
		// (set) Token: 0x06000192 RID: 402
		internal extern Transform staticBatchRootTransform
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000193 RID: 403
		internal extern int staticBatchIndex
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06000194 RID: 404
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetSubsetIndex(int index, int subSetIndexForMaterial);

		/// <summary>
		///   <para>Has this renderer been statically batched with any other renderers?</para>
		/// </summary>
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000195 RID: 405
		public extern bool isPartOfStaticBatch
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Matrix that transforms a point from world space into local space (Read Only).</para>
		/// </summary>
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0000F378 File Offset: 0x0000D578
		public Matrix4x4 worldToLocalMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.INTERNAL_get_worldToLocalMatrix(out matrix4x);
				return matrix4x;
			}
		}

		// Token: 0x06000197 RID: 407
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_worldToLocalMatrix(out Matrix4x4 value);

		/// <summary>
		///   <para>Matrix that transforms a point from local space into world space (Read Only).</para>
		/// </summary>
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0000F390 File Offset: 0x0000D590
		public Matrix4x4 localToWorldMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.INTERNAL_get_localToWorldMatrix(out matrix4x);
				return matrix4x;
			}
		}

		// Token: 0x06000199 RID: 409
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localToWorldMatrix(out Matrix4x4 value);

		/// <summary>
		///   <para>Makes the rendered 3D object visible if enabled.</para>
		/// </summary>
		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600019A RID: 410
		// (set) Token: 0x0600019B RID: 411
		public extern bool enabled
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Does this object cast shadows?</para>
		/// </summary>
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600019C RID: 412
		// (set) Token: 0x0600019D RID: 413
		public extern ShadowCastingMode shadowCastingMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600019E RID: 414
		// (set) Token: 0x0600019F RID: 415
		[Obsolete("Property castShadows has been deprecated. Use shadowCastingMode instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public extern bool castShadows
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Does this object receive shadows?</para>
		/// </summary>
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001A0 RID: 416
		// (set) Token: 0x060001A1 RID: 417
		public extern bool receiveShadows
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Returns the first instantiated Material assigned to the renderer.</para>
		/// </summary>
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001A2 RID: 418
		// (set) Token: 0x060001A3 RID: 419
		public extern Material material
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The shared material of this object.</para>
		/// </summary>
		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001A4 RID: 420
		// (set) Token: 0x060001A5 RID: 421
		public extern Material sharedMaterial
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Returns all the instantiated materials of this object.</para>
		/// </summary>
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001A6 RID: 422
		// (set) Token: 0x060001A7 RID: 423
		public extern Material[] materials
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>All the shared materials of this object.</para>
		/// </summary>
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001A8 RID: 424
		// (set) Token: 0x060001A9 RID: 425
		public extern Material[] sharedMaterials
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The bounding volume of the renderer (Read Only).</para>
		/// </summary>
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0000F3A8 File Offset: 0x0000D5A8
		public Bounds bounds
		{
			get
			{
				Bounds bounds;
				this.INTERNAL_get_bounds(out bounds);
				return bounds;
			}
		}

		// Token: 0x060001AB RID: 427
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_bounds(out Bounds value);

		/// <summary>
		///   <para>The index of the baked lightmap applied to this renderer.</para>
		/// </summary>
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001AC RID: 428
		// (set) Token: 0x060001AD RID: 429
		public extern int lightmapIndex
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The index of the realtime lightmap applied to this renderer.</para>
		/// </summary>
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001AE RID: 430
		// (set) Token: 0x060001AF RID: 431
		public extern int realtimeLightmapIndex
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The UV scale &amp; offset used for a lightmap.</para>
		/// </summary>
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x0000244C File Offset: 0x0000064C
		public Vector4 lightmapScaleOffset
		{
			get
			{
				Vector4 vector;
				this.INTERNAL_get_lightmapScaleOffset(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_lightmapScaleOffset(ref value);
			}
		}

		// Token: 0x060001B2 RID: 434
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_lightmapScaleOffset(out Vector4 value);

		// Token: 0x060001B3 RID: 435
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_lightmapScaleOffset(ref Vector4 value);

		/// <summary>
		///   <para>The UV scale &amp; offset used for a realtime lightmap.</para>
		/// </summary>
		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002456 File Offset: 0x00000656
		public Vector4 realtimeLightmapScaleOffset
		{
			get
			{
				Vector4 vector;
				this.INTERNAL_get_realtimeLightmapScaleOffset(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_realtimeLightmapScaleOffset(ref value);
			}
		}

		// Token: 0x060001B6 RID: 438
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_realtimeLightmapScaleOffset(out Vector4 value);

		// Token: 0x060001B7 RID: 439
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_realtimeLightmapScaleOffset(ref Vector4 value);

		/// <summary>
		///   <para>Is this renderer visible in any camera? (Read Only)</para>
		/// </summary>
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001B8 RID: 440
		public extern bool isVisible
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Should light probes be used for this Renderer?</para>
		/// </summary>
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001B9 RID: 441
		// (set) Token: 0x060001BA RID: 442
		public extern bool useLightProbes
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>If set, Renderer will use this Transform's position to find the light or reflection probe.</para>
		/// </summary>
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001BB RID: 443
		// (set) Token: 0x060001BC RID: 444
		public extern Transform probeAnchor
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should reflection probes be used for this Renderer?</para>
		/// </summary>
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001BD RID: 445
		// (set) Token: 0x060001BE RID: 446
		public extern ReflectionProbeUsage reflectionProbeUsage
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Lets you add per-renderer material parameters without duplicating a material.</para>
		/// </summary>
		/// <param name="properties"></param>
		// Token: 0x060001BF RID: 447
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetPropertyBlock(MaterialPropertyBlock properties);

		/// <summary>
		///   <para>Get per-renderer material property block.</para>
		/// </summary>
		/// <param name="dest"></param>
		// Token: 0x060001C0 RID: 448
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void GetPropertyBlock(MaterialPropertyBlock dest);

		/// <summary>
		///   <para>Name of the Renderer's sorting layer.</para>
		/// </summary>
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001C1 RID: 449
		// (set) Token: 0x060001C2 RID: 450
		public extern string sortingLayerName
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Unique ID of the Renderer's sorting layer.</para>
		/// </summary>
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001C3 RID: 451
		// (set) Token: 0x060001C4 RID: 452
		public extern int sortingLayerID
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Renderer's order within a sorting layer.</para>
		/// </summary>
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001C5 RID: 453
		// (set) Token: 0x060001C6 RID: 454
		public extern int sortingOrder
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x060001C7 RID: 455
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetClosestReflectionProbesInternal(object result);

		// Token: 0x060001C8 RID: 456 RVA: 0x00002460 File Offset: 0x00000660
		public void GetClosestReflectionProbes(List<ReflectionProbeBlendInfo> result)
		{
			this.GetClosestReflectionProbesInternal(result);
		}
	}
}
