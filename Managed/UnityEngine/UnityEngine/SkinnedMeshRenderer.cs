using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The Skinned Mesh filter.</para>
	/// </summary>
	// Token: 0x02000021 RID: 33
	public class SkinnedMeshRenderer : Renderer
	{
		/// <summary>
		///   <para>The bones used to skin the mesh.</para>
		/// </summary>
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000173 RID: 371
		// (set) Token: 0x06000174 RID: 372
		public extern Transform[] bones
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000175 RID: 373
		// (set) Token: 0x06000176 RID: 374
		public extern Transform rootBone
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The maximum number of bones affecting a single vertex.</para>
		/// </summary>
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000177 RID: 375
		// (set) Token: 0x06000178 RID: 376
		public extern SkinQuality quality
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The mesh used for skinning.</para>
		/// </summary>
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000179 RID: 377
		// (set) Token: 0x0600017A RID: 378
		public extern Mesh sharedMesh
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>If enabled, the Skinned Mesh will be updated when offscreen. If disabled, this also disables updating animations.</para>
		/// </summary>
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600017B RID: 379
		// (set) Token: 0x0600017C RID: 380
		public extern bool updateWhenOffscreen
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>AABB of this Skinned Mesh in its local space.</para>
		/// </summary>
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000F348 File Offset: 0x0000D548
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002430 File Offset: 0x00000630
		public Bounds localBounds
		{
			get
			{
				Bounds bounds;
				this.INTERNAL_get_localBounds(out bounds);
				return bounds;
			}
			set
			{
				this.INTERNAL_set_localBounds(ref value);
			}
		}

		// Token: 0x0600017F RID: 383
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localBounds(out Bounds value);

		// Token: 0x06000180 RID: 384
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localBounds(ref Bounds value);

		/// <summary>
		///   <para>Creates a snapshot of SkinnedMeshRenderer and stores it in mesh.</para>
		/// </summary>
		/// <param name="mesh">A static mesh that will receive the snapshot of the skinned mesh.</param>
		// Token: 0x06000181 RID: 385
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void BakeMesh(Mesh mesh);

		/// <summary>
		///   <para>Returns weight of BlendShape on this renderer.</para>
		/// </summary>
		/// <param name="index"></param>
		// Token: 0x06000182 RID: 386
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetBlendShapeWeight(int index);

		/// <summary>
		///   <para>Sets weight of BlendShape on this renderer.</para>
		/// </summary>
		/// <param name="index"></param>
		/// <param name="value"></param>
		// Token: 0x06000183 RID: 387
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetBlendShapeWeight(int index, float value);
	}
}
