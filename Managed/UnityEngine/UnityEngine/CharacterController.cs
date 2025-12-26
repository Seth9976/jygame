using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A CharacterController allows you to easily do movement constrained by collisions without having to deal with a rigidbody.</para>
	/// </summary>
	// Token: 0x02000117 RID: 279
	public sealed class CharacterController : Collider
	{
		/// <summary>
		///   <para>Moves the character with speed.</para>
		/// </summary>
		/// <param name="speed"></param>
		// Token: 0x060010E1 RID: 4321 RVA: 0x000074E0 File Offset: 0x000056E0
		public bool SimpleMove(Vector3 speed)
		{
			return CharacterController.INTERNAL_CALL_SimpleMove(this, ref speed);
		}

		// Token: 0x060010E2 RID: 4322
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_SimpleMove(CharacterController self, ref Vector3 speed);

		/// <summary>
		///   <para>A more complex move function taking absolute movement deltas.</para>
		/// </summary>
		/// <param name="motion"></param>
		// Token: 0x060010E3 RID: 4323 RVA: 0x000074EA File Offset: 0x000056EA
		public CollisionFlags Move(Vector3 motion)
		{
			return CharacterController.INTERNAL_CALL_Move(this, ref motion);
		}

		// Token: 0x060010E4 RID: 4324
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern CollisionFlags INTERNAL_CALL_Move(CharacterController self, ref Vector3 motion);

		/// <summary>
		///   <para>Was the CharacterController touching the ground during the last move?</para>
		/// </summary>
		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060010E5 RID: 4325
		public extern bool isGrounded
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The current relative velocity of the Character (see notes).</para>
		/// </summary>
		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x00018F80 File Offset: 0x00017180
		public Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_velocity(out vector);
				return vector;
			}
		}

		// Token: 0x060010E7 RID: 4327
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_velocity(out Vector3 value);

		/// <summary>
		///   <para>What part of the capsule collided with the environment during the last CharacterController.Move call.</para>
		/// </summary>
		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060010E8 RID: 4328
		public extern CollisionFlags collisionFlags
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The radius of the character's capsule.</para>
		/// </summary>
		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060010E9 RID: 4329
		// (set) Token: 0x060010EA RID: 4330
		public extern float radius
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The height of the character's capsule.</para>
		/// </summary>
		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060010EB RID: 4331
		// (set) Token: 0x060010EC RID: 4332
		public extern float height
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The center of the character's capsule relative to the transform's position.</para>
		/// </summary>
		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x00018F98 File Offset: 0x00017198
		// (set) Token: 0x060010EE RID: 4334 RVA: 0x000074F4 File Offset: 0x000056F4
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

		// Token: 0x060010EF RID: 4335
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_center(out Vector3 value);

		// Token: 0x060010F0 RID: 4336
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_center(ref Vector3 value);

		/// <summary>
		///   <para>The character controllers slope limit in degrees.</para>
		/// </summary>
		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060010F1 RID: 4337
		// (set) Token: 0x060010F2 RID: 4338
		public extern float slopeLimit
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The character controllers step offset in meters.</para>
		/// </summary>
		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060010F3 RID: 4339
		// (set) Token: 0x060010F4 RID: 4340
		public extern float stepOffset
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The character's collision skin width.</para>
		/// </summary>
		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x060010F5 RID: 4341
		// (set) Token: 0x060010F6 RID: 4342
		public extern float skinWidth
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Determines whether other rigidbodies or character controllers collide with this character controller (by default this is always enabled).</para>
		/// </summary>
		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x060010F7 RID: 4343
		// (set) Token: 0x060010F8 RID: 4344
		public extern bool detectCollisions
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
