using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A special collider for vehicle wheels.</para>
	/// </summary>
	// Token: 0x02000114 RID: 276
	public sealed class WheelCollider : Collider
	{
		/// <summary>
		///   <para>The center of the wheel, measured in the object's local space.</para>
		/// </summary>
		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x00018DE4 File Offset: 0x00016FE4
		// (set) Token: 0x06001092 RID: 4242 RVA: 0x000073C9 File Offset: 0x000055C9
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

		// Token: 0x06001093 RID: 4243
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_center(out Vector3 value);

		// Token: 0x06001094 RID: 4244
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_center(ref Vector3 value);

		/// <summary>
		///   <para>The radius of the wheel, measured in local space.</para>
		/// </summary>
		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001095 RID: 4245
		// (set) Token: 0x06001096 RID: 4246
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
		///   <para>Maximum extension distance of wheel suspension, measured in local space.</para>
		/// </summary>
		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001097 RID: 4247
		// (set) Token: 0x06001098 RID: 4248
		public extern float suspensionDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The parameters of wheel's suspension. The suspension attempts to reach a target position by applying a linear force and a damping force.</para>
		/// </summary>
		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x00018DFC File Offset: 0x00016FFC
		// (set) Token: 0x0600109A RID: 4250 RVA: 0x000073D3 File Offset: 0x000055D3
		public JointSpring suspensionSpring
		{
			get
			{
				JointSpring jointSpring;
				this.INTERNAL_get_suspensionSpring(out jointSpring);
				return jointSpring;
			}
			set
			{
				this.INTERNAL_set_suspensionSpring(ref value);
			}
		}

		// Token: 0x0600109B RID: 4251
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_suspensionSpring(out JointSpring value);

		// Token: 0x0600109C RID: 4252
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_suspensionSpring(ref JointSpring value);

		/// <summary>
		///   <para>Application point of the suspension and tire forces measured from the base of the resting wheel.</para>
		/// </summary>
		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x0600109D RID: 4253
		// (set) Token: 0x0600109E RID: 4254
		public extern float forceAppPointDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The mass of the wheel, expressed in kilograms. Must be larger than zero. Typical values would be in range (20,80).</para>
		/// </summary>
		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x0600109F RID: 4255
		// (set) Token: 0x060010A0 RID: 4256
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
		///   <para>The damping rate of the wheel. Must be larger than zero.</para>
		/// </summary>
		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060010A1 RID: 4257
		// (set) Token: 0x060010A2 RID: 4258
		public extern float wheelDampingRate
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Properties of tire friction in the direction the wheel is pointing in.</para>
		/// </summary>
		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x00018E14 File Offset: 0x00017014
		// (set) Token: 0x060010A4 RID: 4260 RVA: 0x000073DD File Offset: 0x000055DD
		public WheelFrictionCurve forwardFriction
		{
			get
			{
				WheelFrictionCurve wheelFrictionCurve;
				this.INTERNAL_get_forwardFriction(out wheelFrictionCurve);
				return wheelFrictionCurve;
			}
			set
			{
				this.INTERNAL_set_forwardFriction(ref value);
			}
		}

		// Token: 0x060010A5 RID: 4261
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_forwardFriction(out WheelFrictionCurve value);

		// Token: 0x060010A6 RID: 4262
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_forwardFriction(ref WheelFrictionCurve value);

		/// <summary>
		///   <para>Properties of tire friction in the sideways direction.</para>
		/// </summary>
		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x00018E2C File Offset: 0x0001702C
		// (set) Token: 0x060010A8 RID: 4264 RVA: 0x000073E7 File Offset: 0x000055E7
		public WheelFrictionCurve sidewaysFriction
		{
			get
			{
				WheelFrictionCurve wheelFrictionCurve;
				this.INTERNAL_get_sidewaysFriction(out wheelFrictionCurve);
				return wheelFrictionCurve;
			}
			set
			{
				this.INTERNAL_set_sidewaysFriction(ref value);
			}
		}

		// Token: 0x060010A9 RID: 4265
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_sidewaysFriction(out WheelFrictionCurve value);

		// Token: 0x060010AA RID: 4266
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_sidewaysFriction(ref WheelFrictionCurve value);

		/// <summary>
		///   <para>Motor torque on the wheel axle expressed in Newton metres. Positive or negative depending on direction.</para>
		/// </summary>
		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060010AB RID: 4267
		// (set) Token: 0x060010AC RID: 4268
		public extern float motorTorque
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Brake torque expressed in Newton metres.</para>
		/// </summary>
		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060010AD RID: 4269
		// (set) Token: 0x060010AE RID: 4270
		public extern float brakeTorque
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Steering angle in degrees, always around the local y-axis.</para>
		/// </summary>
		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060010AF RID: 4271
		// (set) Token: 0x060010B0 RID: 4272
		public extern float steerAngle
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Indicates whether the wheel currently collides with something (Read Only).</para>
		/// </summary>
		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060010B1 RID: 4273
		public extern bool isGrounded
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Configure vehicle sub-stepping parameters.</para>
		/// </summary>
		/// <param name="speedThreshold">The speed threshold of the sub-stepping algorithm.</param>
		/// <param name="stepsBelowThreshold">Amount of simulation sub-steps when vehicle's speed is below speedThreshold.</param>
		/// <param name="stepsAboveThreshold">Amount of simulation sub-steps when vehicle's speed is above speedThreshold.</param>
		// Token: 0x060010B2 RID: 4274
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ConfigureVehicleSubsteps(float speedThreshold, int stepsBelowThreshold, int stepsAboveThreshold);

		/// <summary>
		///   <para>The mass supported by this WheelCollider.</para>
		/// </summary>
		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060010B3 RID: 4275
		public extern float sprungMass
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x060010B4 RID: 4276
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool GetGroundHit(out WheelHit hit);

		// Token: 0x060010B5 RID: 4277
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void GetWorldPose(out Vector3 pos, out Quaternion quat);

		/// <summary>
		///   <para>Current wheel axle rotation speed, in rotations per minute (Read Only).</para>
		/// </summary>
		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060010B6 RID: 4278
		public extern float rpm
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}
	}
}
