using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Joint that allows a Rigidbody2D object to rotate around a point in space or a point on another object.</para>
	/// </summary>
	// Token: 0x02000133 RID: 307
	public sealed class HingeJoint2D : AnchoredJoint2D
	{
		/// <summary>
		///   <para>Should the joint be rotated automatically by a motor torque?</para>
		/// </summary>
		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060012B7 RID: 4791
		// (set) Token: 0x060012B8 RID: 4792
		public extern bool useMotor
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should limits be placed on the range of rotation?</para>
		/// </summary>
		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060012B9 RID: 4793
		// (set) Token: 0x060012BA RID: 4794
		public extern bool useLimits
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Parameters for the motor force applied to the joint.</para>
		/// </summary>
		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x0001A114 File Offset: 0x00018314
		// (set) Token: 0x060012BC RID: 4796 RVA: 0x000079B8 File Offset: 0x00005BB8
		public JointMotor2D motor
		{
			get
			{
				JointMotor2D jointMotor2D;
				this.INTERNAL_get_motor(out jointMotor2D);
				return jointMotor2D;
			}
			set
			{
				this.INTERNAL_set_motor(ref value);
			}
		}

		// Token: 0x060012BD RID: 4797
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_motor(out JointMotor2D value);

		// Token: 0x060012BE RID: 4798
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_motor(ref JointMotor2D value);

		/// <summary>
		///   <para>Limit of angular rotation (in degrees) on the joint.</para>
		/// </summary>
		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x0001A12C File Offset: 0x0001832C
		// (set) Token: 0x060012C0 RID: 4800 RVA: 0x000079C2 File Offset: 0x00005BC2
		public JointAngleLimits2D limits
		{
			get
			{
				JointAngleLimits2D jointAngleLimits2D;
				this.INTERNAL_get_limits(out jointAngleLimits2D);
				return jointAngleLimits2D;
			}
			set
			{
				this.INTERNAL_set_limits(ref value);
			}
		}

		// Token: 0x060012C1 RID: 4801
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_limits(out JointAngleLimits2D value);

		// Token: 0x060012C2 RID: 4802
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_limits(ref JointAngleLimits2D value);

		/// <summary>
		///   <para>Gets the state of the joint limit.</para>
		/// </summary>
		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060012C3 RID: 4803
		public extern JointLimitState2D limitState
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The angle (in degrees) referenced between the two bodies used as the constraint for the joint.</para>
		/// </summary>
		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060012C4 RID: 4804
		public extern float referenceAngle
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The current joint angle (in degrees) with respect to the reference angle.</para>
		/// </summary>
		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060012C5 RID: 4805
		public extern float jointAngle
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The current joint speed.</para>
		/// </summary>
		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060012C6 RID: 4806
		public extern float jointSpeed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Gets the reaction force of the joint given the specified timestep.</para>
		/// </summary>
		/// <param name="timeStep">The time to calculate the reaction force for.</param>
		// Token: 0x060012C7 RID: 4807 RVA: 0x0001A144 File Offset: 0x00018344
		public Vector2 GetReactionForce(float timeStep)
		{
			Vector2 vector;
			HingeJoint2D.HingeJoint2D_CUSTOM_INTERNAL_GetReactionForce(this, timeStep, out vector);
			return vector;
		}

		// Token: 0x060012C8 RID: 4808
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void HingeJoint2D_CUSTOM_INTERNAL_GetReactionForce(HingeJoint2D joint, float timeStep, out Vector2 value);

		/// <summary>
		///   <para>Gets the reaction torque of the joint given the specified timestep.</para>
		/// </summary>
		/// <param name="timeStep">The time to calculate the reaction torque for.</param>
		// Token: 0x060012C9 RID: 4809 RVA: 0x000079CC File Offset: 0x00005BCC
		public float GetReactionTorque(float timeStep)
		{
			return HingeJoint2D.INTERNAL_CALL_GetReactionTorque(this, timeStep);
		}

		// Token: 0x060012CA RID: 4810
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_GetReactionTorque(HingeJoint2D self, float timeStep);

		/// <summary>
		///   <para>Gets the motor torque of the joint given the specified timestep.</para>
		/// </summary>
		/// <param name="timeStep">The time to calculate the motor torque for.</param>
		// Token: 0x060012CB RID: 4811 RVA: 0x000079D5 File Offset: 0x00005BD5
		public float GetMotorTorque(float timeStep)
		{
			return HingeJoint2D.INTERNAL_CALL_GetMotorTorque(this, timeStep);
		}

		// Token: 0x060012CC RID: 4812
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_GetMotorTorque(HingeJoint2D self, float timeStep);
	}
}
