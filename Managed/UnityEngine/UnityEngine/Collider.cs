using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A base class of all colliders.</para>
	/// </summary>
	// Token: 0x0200010F RID: 271
	public class Collider : Component
	{
		/// <summary>
		///   <para>Enabled Colliders will collide with other colliders, disabled Colliders won't.</para>
		/// </summary>
		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600105A RID: 4186
		// (set) Token: 0x0600105B RID: 4187
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
		///   <para>The rigidbody the collider is attached to.</para>
		/// </summary>
		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x0600105C RID: 4188
		public extern Rigidbody attachedRigidbody
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Is the collider a trigger?</para>
		/// </summary>
		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x0600105D RID: 4189
		// (set) Token: 0x0600105E RID: 4190
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
		///   <para>Contact offset value of this collider.</para>
		/// </summary>
		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x0600105F RID: 4191
		// (set) Token: 0x06001060 RID: 4192
		public extern float contactOffset
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The material used by the collider.</para>
		/// </summary>
		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001061 RID: 4193
		// (set) Token: 0x06001062 RID: 4194
		public extern PhysicMaterial material
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The closest point to the bounding box of the attached collider.</para>
		/// </summary>
		/// <param name="position"></param>
		// Token: 0x06001063 RID: 4195 RVA: 0x00007353 File Offset: 0x00005553
		public Vector3 ClosestPointOnBounds(Vector3 position)
		{
			return Collider.INTERNAL_CALL_ClosestPointOnBounds(this, ref position);
		}

		// Token: 0x06001064 RID: 4196
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_ClosestPointOnBounds(Collider self, ref Vector3 position);

		/// <summary>
		///   <para>The shared physic material of this collider.</para>
		/// </summary>
		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001065 RID: 4197
		// (set) Token: 0x06001066 RID: 4198
		public extern PhysicMaterial sharedMaterial
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The world space bounding volume of the collider.</para>
		/// </summary>
		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x00018D6C File Offset: 0x00016F6C
		public Bounds bounds
		{
			get
			{
				Bounds bounds;
				this.INTERNAL_get_bounds(out bounds);
				return bounds;
			}
		}

		// Token: 0x06001068 RID: 4200
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_bounds(out Bounds value);

		// Token: 0x06001069 RID: 4201 RVA: 0x0000735D File Offset: 0x0000555D
		private static bool Internal_Raycast(Collider col, Ray ray, out RaycastHit hitInfo, float maxDistance)
		{
			return Collider.INTERNAL_CALL_Internal_Raycast(col, ref ray, out hitInfo, maxDistance);
		}

		// Token: 0x0600106A RID: 4202
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Internal_Raycast(Collider col, ref Ray ray, out RaycastHit hitInfo, float maxDistance);

		// Token: 0x0600106B RID: 4203 RVA: 0x00007369 File Offset: 0x00005569
		public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
		{
			return Collider.Internal_Raycast(this, ray, out hitInfo, maxDistance);
		}
	}
}
