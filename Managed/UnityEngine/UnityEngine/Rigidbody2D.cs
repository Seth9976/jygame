using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Rigidbody physics component for 2D sprites.</para>
	/// </summary>
	// Token: 0x02000122 RID: 290
	public sealed class Rigidbody2D : Component
	{
		/// <summary>
		///   <para>The position of the rigidbody.</para>
		/// </summary>
		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x00019EA4 File Offset: 0x000180A4
		// (set) Token: 0x060011F4 RID: 4596 RVA: 0x0000777C File Offset: 0x0000597C
		public Vector2 position
		{
			get
			{
				Vector2 vector;
				this.INTERNAL_get_position(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_position(ref value);
			}
		}

		// Token: 0x060011F5 RID: 4597
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_position(out Vector2 value);

		// Token: 0x060011F6 RID: 4598
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_position(ref Vector2 value);

		/// <summary>
		///   <para>The rotation of the rigdibody.</para>
		/// </summary>
		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060011F7 RID: 4599
		// (set) Token: 0x060011F8 RID: 4600
		public extern float rotation
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Moves the rigidbody to position.</para>
		/// </summary>
		/// <param name="position">The new position for the Rigidbody object.</param>
		// Token: 0x060011F9 RID: 4601 RVA: 0x00007786 File Offset: 0x00005986
		public void MovePosition(Vector2 position)
		{
			Rigidbody2D.INTERNAL_CALL_MovePosition(this, ref position);
		}

		// Token: 0x060011FA RID: 4602
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_MovePosition(Rigidbody2D self, ref Vector2 position);

		/// <summary>
		///   <para>Rotates the rigidbody to angle (given in degrees).</para>
		/// </summary>
		/// <param name="angle">The new rotation angle for the Rigidbody object.</param>
		// Token: 0x060011FB RID: 4603 RVA: 0x00007790 File Offset: 0x00005990
		public void MoveRotation(float angle)
		{
			Rigidbody2D.INTERNAL_CALL_MoveRotation(this, angle);
		}

		// Token: 0x060011FC RID: 4604
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_MoveRotation(Rigidbody2D self, float angle);

		/// <summary>
		///   <para>Linear velocity of the rigidbody.</para>
		/// </summary>
		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x00019EBC File Offset: 0x000180BC
		// (set) Token: 0x060011FE RID: 4606 RVA: 0x00007799 File Offset: 0x00005999
		public Vector2 velocity
		{
			get
			{
				Vector2 vector;
				this.INTERNAL_get_velocity(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_velocity(ref value);
			}
		}

		// Token: 0x060011FF RID: 4607
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_velocity(out Vector2 value);

		// Token: 0x06001200 RID: 4608
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_velocity(ref Vector2 value);

		/// <summary>
		///   <para>Angular velocity in degrees per second.</para>
		/// </summary>
		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001201 RID: 4609
		// (set) Token: 0x06001202 RID: 4610
		public extern float angularVelocity
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Mass of the rigidbody.</para>
		/// </summary>
		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001203 RID: 4611
		// (set) Token: 0x06001204 RID: 4612
		public extern float mass
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The center of mass of the rigidBody in local space.</para>
		/// </summary>
		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001205 RID: 4613 RVA: 0x00019ED4 File Offset: 0x000180D4
		// (set) Token: 0x06001206 RID: 4614 RVA: 0x000077A3 File Offset: 0x000059A3
		public Vector2 centerOfMass
		{
			get
			{
				Vector2 vector;
				this.INTERNAL_get_centerOfMass(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_centerOfMass(ref value);
			}
		}

		// Token: 0x06001207 RID: 4615
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_centerOfMass(out Vector2 value);

		// Token: 0x06001208 RID: 4616
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_centerOfMass(ref Vector2 value);

		/// <summary>
		///   <para>Gets the center of mass of the rigidBody in global space.</para>
		/// </summary>
		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x00019EEC File Offset: 0x000180EC
		public Vector2 worldCenterOfMass
		{
			get
			{
				Vector2 vector;
				this.INTERNAL_get_worldCenterOfMass(out vector);
				return vector;
			}
		}

		// Token: 0x0600120A RID: 4618
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_worldCenterOfMass(out Vector2 value);

		/// <summary>
		///   <para>The rigidBody rotational inertia.</para>
		/// </summary>
		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600120B RID: 4619
		// (set) Token: 0x0600120C RID: 4620
		public extern float inertia
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Coefficient of drag.</para>
		/// </summary>
		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x0600120D RID: 4621
		// (set) Token: 0x0600120E RID: 4622
		public extern float drag
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Coefficient of angular drag.</para>
		/// </summary>
		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x0600120F RID: 4623
		// (set) Token: 0x06001210 RID: 4624
		public extern float angularDrag
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The degree to which this object is affected by gravity.</para>
		/// </summary>
		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001211 RID: 4625
		// (set) Token: 0x06001212 RID: 4626
		public extern float gravityScale
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should this rigidbody be taken out of physics control?</para>
		/// </summary>
		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001213 RID: 4627
		// (set) Token: 0x06001214 RID: 4628
		public extern bool isKinematic
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should the rigidbody be prevented from rotating?</para>
		/// </summary>
		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001215 RID: 4629
		// (set) Token: 0x06001216 RID: 4630
		[Obsolete("The fixedAngle is no longer supported. Use constraints instead.")]
		public extern bool fixedAngle
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Controls whether physics will change the rotation of the object.</para>
		/// </summary>
		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001217 RID: 4631
		// (set) Token: 0x06001218 RID: 4632
		public extern bool freezeRotation
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Controls which degrees of freedom are allowed for the simulation of this Rigidbody2D.</para>
		/// </summary>
		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001219 RID: 4633
		// (set) Token: 0x0600121A RID: 4634
		public extern RigidbodyConstraints2D constraints
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Is the rigidbody "sleeping"?</para>
		/// </summary>
		// Token: 0x0600121B RID: 4635
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsSleeping();

		/// <summary>
		///   <para>Is the rigidbody "awake"?</para>
		/// </summary>
		// Token: 0x0600121C RID: 4636
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsAwake();

		/// <summary>
		///   <para>Make the rigidbody "sleep".</para>
		/// </summary>
		// Token: 0x0600121D RID: 4637
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Sleep();

		/// <summary>
		///   <para>Disables the "sleeping" state of a rigidbody.</para>
		/// </summary>
		// Token: 0x0600121E RID: 4638
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void WakeUp();

		/// <summary>
		///   <para>Indicates whether the rigid body should be simulated or not by the physics system.</para>
		/// </summary>
		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600121F RID: 4639
		// (set) Token: 0x06001220 RID: 4640
		public extern bool simulated
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Physics interpolation used between updates.</para>
		/// </summary>
		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001221 RID: 4641
		// (set) Token: 0x06001222 RID: 4642
		public extern RigidbodyInterpolation2D interpolation
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The sleep state that the rigidbody will initially be in.</para>
		/// </summary>
		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001223 RID: 4643
		// (set) Token: 0x06001224 RID: 4644
		public extern RigidbodySleepMode2D sleepMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The method used by the physics engine to check if two objects have collided.</para>
		/// </summary>
		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001225 RID: 4645
		// (set) Token: 0x06001226 RID: 4646
		public extern CollisionDetectionMode2D collisionDetectionMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Check whether any of the collider(s) attached to this rigidbody are touching the collider or not.</para>
		/// </summary>
		/// <param name="collider">The collider to check if it is touching any of the collider(s) attached to this rigidbody.</param>
		/// <returns>
		///   <para>Whether the collider is touching any of the collider(s) attached to this rigidbody or not.</para>
		/// </returns>
		// Token: 0x06001227 RID: 4647
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsTouching(Collider2D collider);

		/// <summary>
		///   <para>Checks whether any of the collider(s) attached to this rigidbody are touching any colliders on the specified layerMask or not.</para>
		/// </summary>
		/// <param name="layerMask">Any colliders on any of these layers count as touching.</param>
		/// <returns>
		///   <para>Whether any of the collider(s) attached to this rigidbody are touching any colliders on the specified layerMask or not.</para>
		/// </returns>
		// Token: 0x06001228 RID: 4648
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsTouchingLayers([DefaultValue("Physics2D.AllLayers")] int layerMask);

		// Token: 0x06001229 RID: 4649 RVA: 0x00019F04 File Offset: 0x00018104
		[ExcludeFromDocs]
		public bool IsTouchingLayers()
		{
			int num = -1;
			return this.IsTouchingLayers(num);
		}

		/// <summary>
		///   <para>Apply a force to the rigidbody.</para>
		/// </summary>
		/// <param name="force">Components of the force in the X and Y axes.</param>
		/// <param name="mode">The method used to apply the specified force.</param>
		// Token: 0x0600122A RID: 4650 RVA: 0x000077AD File Offset: 0x000059AD
		public void AddForce(Vector2 force, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode)
		{
			Rigidbody2D.INTERNAL_CALL_AddForce(this, ref force, mode);
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00019F1C File Offset: 0x0001811C
		[ExcludeFromDocs]
		public void AddForce(Vector2 force)
		{
			ForceMode2D forceMode2D = ForceMode2D.Force;
			Rigidbody2D.INTERNAL_CALL_AddForce(this, ref force, forceMode2D);
		}

		// Token: 0x0600122C RID: 4652
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddForce(Rigidbody2D self, ref Vector2 force, ForceMode2D mode);

		/// <summary>
		///   <para>Adds a force to the rigidbody2D relative to its coordinate system.</para>
		/// </summary>
		/// <param name="relativeForce">Components of the force in the X and Y axes.</param>
		/// <param name="mode">The method used to apply the specified force.</param>
		// Token: 0x0600122D RID: 4653 RVA: 0x000077B8 File Offset: 0x000059B8
		public void AddRelativeForce(Vector2 relativeForce, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode)
		{
			Rigidbody2D.INTERNAL_CALL_AddRelativeForce(this, ref relativeForce, mode);
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00019F34 File Offset: 0x00018134
		[ExcludeFromDocs]
		public void AddRelativeForce(Vector2 relativeForce)
		{
			ForceMode2D forceMode2D = ForceMode2D.Force;
			Rigidbody2D.INTERNAL_CALL_AddRelativeForce(this, ref relativeForce, forceMode2D);
		}

		// Token: 0x0600122F RID: 4655
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddRelativeForce(Rigidbody2D self, ref Vector2 relativeForce, ForceMode2D mode);

		/// <summary>
		///   <para>Apply a force at a given position in space.</para>
		/// </summary>
		/// <param name="force">Components of the force in the X and Y axes.</param>
		/// <param name="position">Position in world space to apply the force.</param>
		/// <param name="mode">The method used to apply the specified force.</param>
		// Token: 0x06001230 RID: 4656 RVA: 0x000077C3 File Offset: 0x000059C3
		public void AddForceAtPosition(Vector2 force, Vector2 position, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode)
		{
			Rigidbody2D.INTERNAL_CALL_AddForceAtPosition(this, ref force, ref position, mode);
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00019F4C File Offset: 0x0001814C
		[ExcludeFromDocs]
		public void AddForceAtPosition(Vector2 force, Vector2 position)
		{
			ForceMode2D forceMode2D = ForceMode2D.Force;
			Rigidbody2D.INTERNAL_CALL_AddForceAtPosition(this, ref force, ref position, forceMode2D);
		}

		// Token: 0x06001232 RID: 4658
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddForceAtPosition(Rigidbody2D self, ref Vector2 force, ref Vector2 position, ForceMode2D mode);

		/// <summary>
		///   <para>Apply a torque at the rigidbody's centre of mass.</para>
		/// </summary>
		/// <param name="torque">Torque to apply.</param>
		/// <param name="mode">The force mode to use.</param>
		// Token: 0x06001233 RID: 4659
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void AddTorque(float torque, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode);

		// Token: 0x06001234 RID: 4660 RVA: 0x00019F68 File Offset: 0x00018168
		[ExcludeFromDocs]
		public void AddTorque(float torque)
		{
			ForceMode2D forceMode2D = ForceMode2D.Force;
			this.AddTorque(torque, forceMode2D);
		}

		/// <summary>
		///   <para>Get a local space point given the point point in rigidBody global space.</para>
		/// </summary>
		/// <param name="point">The global space point to transform into local space.</param>
		// Token: 0x06001235 RID: 4661 RVA: 0x00019F80 File Offset: 0x00018180
		public Vector2 GetPoint(Vector2 point)
		{
			Vector2 vector;
			Rigidbody2D.Rigidbody2D_CUSTOM_INTERNAL_GetPoint(this, point, out vector);
			return vector;
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x000077D0 File Offset: 0x000059D0
		private static void Rigidbody2D_CUSTOM_INTERNAL_GetPoint(Rigidbody2D rigidbody, Vector2 point, out Vector2 value)
		{
			Rigidbody2D.INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetPoint(rigidbody, ref point, out value);
		}

		// Token: 0x06001237 RID: 4663
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetPoint(Rigidbody2D rigidbody, ref Vector2 point, out Vector2 value);

		/// <summary>
		///   <para>Get a global space point given the point relativePoint in rigidBody local space.</para>
		/// </summary>
		/// <param name="relativePoint">The local space point to transform into global space.</param>
		// Token: 0x06001238 RID: 4664 RVA: 0x00019F98 File Offset: 0x00018198
		public Vector2 GetRelativePoint(Vector2 relativePoint)
		{
			Vector2 vector;
			Rigidbody2D.Rigidbody2D_CUSTOM_INTERNAL_GetRelativePoint(this, relativePoint, out vector);
			return vector;
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x000077DB File Offset: 0x000059DB
		private static void Rigidbody2D_CUSTOM_INTERNAL_GetRelativePoint(Rigidbody2D rigidbody, Vector2 relativePoint, out Vector2 value)
		{
			Rigidbody2D.INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetRelativePoint(rigidbody, ref relativePoint, out value);
		}

		// Token: 0x0600123A RID: 4666
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetRelativePoint(Rigidbody2D rigidbody, ref Vector2 relativePoint, out Vector2 value);

		/// <summary>
		///   <para>Get a local space vector given the vector vector in rigidBody global space.</para>
		/// </summary>
		/// <param name="vector">The global space vector to transform into a local space vector.</param>
		// Token: 0x0600123B RID: 4667 RVA: 0x00019FB0 File Offset: 0x000181B0
		public Vector2 GetVector(Vector2 vector)
		{
			Vector2 vector2;
			Rigidbody2D.Rigidbody2D_CUSTOM_INTERNAL_GetVector(this, vector, out vector2);
			return vector2;
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x000077E6 File Offset: 0x000059E6
		private static void Rigidbody2D_CUSTOM_INTERNAL_GetVector(Rigidbody2D rigidbody, Vector2 vector, out Vector2 value)
		{
			Rigidbody2D.INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetVector(rigidbody, ref vector, out value);
		}

		// Token: 0x0600123D RID: 4669
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetVector(Rigidbody2D rigidbody, ref Vector2 vector, out Vector2 value);

		/// <summary>
		///   <para>Get a global space vector given the vector relativeVector in rigidBody local space.</para>
		/// </summary>
		/// <param name="relativeVector">The local space vector to transform into a global space vector.</param>
		// Token: 0x0600123E RID: 4670 RVA: 0x00019FC8 File Offset: 0x000181C8
		public Vector2 GetRelativeVector(Vector2 relativeVector)
		{
			Vector2 vector;
			Rigidbody2D.Rigidbody2D_CUSTOM_INTERNAL_GetRelativeVector(this, relativeVector, out vector);
			return vector;
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x000077F1 File Offset: 0x000059F1
		private static void Rigidbody2D_CUSTOM_INTERNAL_GetRelativeVector(Rigidbody2D rigidbody, Vector2 relativeVector, out Vector2 value)
		{
			Rigidbody2D.INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetRelativeVector(rigidbody, ref relativeVector, out value);
		}

		// Token: 0x06001240 RID: 4672
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetRelativeVector(Rigidbody2D rigidbody, ref Vector2 relativeVector, out Vector2 value);

		/// <summary>
		///   <para>The velocity of the rigidbody at the point Point in global space.</para>
		/// </summary>
		/// <param name="point">The global space point to calculate velocity for.</param>
		// Token: 0x06001241 RID: 4673 RVA: 0x00019FE0 File Offset: 0x000181E0
		public Vector2 GetPointVelocity(Vector2 point)
		{
			Vector2 vector;
			Rigidbody2D.Rigidbody2D_CUSTOM_INTERNAL_GetPointVelocity(this, point, out vector);
			return vector;
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x000077FC File Offset: 0x000059FC
		private static void Rigidbody2D_CUSTOM_INTERNAL_GetPointVelocity(Rigidbody2D rigidbody, Vector2 point, out Vector2 value)
		{
			Rigidbody2D.INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetPointVelocity(rigidbody, ref point, out value);
		}

		// Token: 0x06001243 RID: 4675
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetPointVelocity(Rigidbody2D rigidbody, ref Vector2 point, out Vector2 value);

		/// <summary>
		///   <para>The velocity of the rigidbody at the point Point in local space.</para>
		/// </summary>
		/// <param name="relativePoint">The local space point to calculate velocity for.</param>
		// Token: 0x06001244 RID: 4676 RVA: 0x00019FF8 File Offset: 0x000181F8
		public Vector2 GetRelativePointVelocity(Vector2 relativePoint)
		{
			Vector2 vector;
			Rigidbody2D.Rigidbody2D_CUSTOM_INTERNAL_GetRelativePointVelocity(this, relativePoint, out vector);
			return vector;
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00007807 File Offset: 0x00005A07
		private static void Rigidbody2D_CUSTOM_INTERNAL_GetRelativePointVelocity(Rigidbody2D rigidbody, Vector2 relativePoint, out Vector2 value)
		{
			Rigidbody2D.INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetRelativePointVelocity(rigidbody, ref relativePoint, out value);
		}

		// Token: 0x06001246 RID: 4678
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetRelativePointVelocity(Rigidbody2D rigidbody, ref Vector2 relativePoint, out Vector2 value);
	}
}
