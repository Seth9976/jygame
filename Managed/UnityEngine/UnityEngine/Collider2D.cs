using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Parent class for collider types used with 2D gameplay.</para>
	/// </summary>
	// Token: 0x02000123 RID: 291
	public class Collider2D : Behaviour
	{
		/// <summary>
		///   <para>Is this collider configured as a trigger?</para>
		/// </summary>
		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001248 RID: 4680
		// (set) Token: 0x06001249 RID: 4681
		public extern bool isTrigger
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Whether the collider is used by an attached effector or not.</para>
		/// </summary>
		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x0600124A RID: 4682
		// (set) Token: 0x0600124B RID: 4683
		public extern bool usedByEffector
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The local offset of the collider geometry.</para>
		/// </summary>
		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x0001A010 File Offset: 0x00018210
		// (set) Token: 0x0600124D RID: 4685 RVA: 0x00007812 File Offset: 0x00005A12
		public Vector2 offset
		{
			get
			{
				Vector2 vector;
				this.INTERNAL_get_offset(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_offset(ref value);
			}
		}

		// Token: 0x0600124E RID: 4686
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_offset(out Vector2 value);

		// Token: 0x0600124F RID: 4687
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_offset(ref Vector2 value);

		/// <summary>
		///   <para>The Rigidbody2D attached to the Collider2D's GameObject.</para>
		/// </summary>
		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001250 RID: 4688
		public extern Rigidbody2D attachedRigidbody
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The number of separate shaped regions in the collider.</para>
		/// </summary>
		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001251 RID: 4689
		public extern int shapeCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The world space bounding area of the collider.</para>
		/// </summary>
		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x0001A028 File Offset: 0x00018228
		public Bounds bounds
		{
			get
			{
				Bounds bounds;
				this.INTERNAL_get_bounds(out bounds);
				return bounds;
			}
		}

		// Token: 0x06001253 RID: 4691
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_bounds(out Bounds value);

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001254 RID: 4692
		internal extern ColliderErrorState2D errorState
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Check if a collider overlaps a point in space.</para>
		/// </summary>
		/// <param name="point">A point in world space.</param>
		// Token: 0x06001255 RID: 4693 RVA: 0x0000781C File Offset: 0x00005A1C
		public bool OverlapPoint(Vector2 point)
		{
			return Collider2D.INTERNAL_CALL_OverlapPoint(this, ref point);
		}

		// Token: 0x06001256 RID: 4694
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_OverlapPoint(Collider2D self, ref Vector2 point);

		/// <summary>
		///   <para>The PhysicsMaterial2D that is applied to this collider.</para>
		/// </summary>
		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001257 RID: 4695
		// (set) Token: 0x06001258 RID: 4696
		public extern PhysicsMaterial2D sharedMaterial
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Check whether this collider is touching the collider or not.</para>
		/// </summary>
		/// <param name="collider">The collider to check if it is touching this collider.</param>
		/// <returns>
		///   <para>Whether the collider is touching this collider or not.</para>
		/// </returns>
		// Token: 0x06001259 RID: 4697
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsTouching(Collider2D collider);

		/// <summary>
		///   <para>Checks whether this collider is touching any colliders on the specified layerMask or not.</para>
		/// </summary>
		/// <param name="layerMask">Any colliders on any of these layers count as touching.</param>
		/// <returns>
		///   <para>Whether this collider is touching any collider on the specified layerMask or not.</para>
		/// </returns>
		// Token: 0x0600125A RID: 4698
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsTouchingLayers([DefaultValue("Physics2D.AllLayers")] int layerMask);

		// Token: 0x0600125B RID: 4699 RVA: 0x0001A040 File Offset: 0x00018240
		[ExcludeFromDocs]
		public bool IsTouchingLayers()
		{
			int num = -1;
			return this.IsTouchingLayers(num);
		}
	}
}
