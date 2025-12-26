using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Joint that restricts the motion of a Rigidbody2D object to a single line.</para>
	/// </summary>
	// Token: 0x02000134 RID: 308
	public sealed class SliderJoint2D : AnchoredJoint2D
	{
		/// <summary>
		///   <para>The angle of the line in space (in degrees).</para>
		/// </summary>
		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060012CE RID: 4814
		// (set) Token: 0x060012CF RID: 4815
		public extern float angle
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should a motor force be applied automatically to the Rigidbody2D?</para>
		/// </summary>
		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060012D0 RID: 4816
		// (set) Token: 0x060012D1 RID: 4817
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
		///   <para>Should motion limits be used?</para>
		/// </summary>
		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060012D2 RID: 4818
		// (set) Token: 0x060012D3 RID: 4819
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
		///   <para>Parameters for a motor force that is applied automatically to the Rigibody2D along the line.</para>
		/// </summary>
		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x0001A15C File Offset: 0x0001835C
		// (set) Token: 0x060012D5 RID: 4821 RVA: 0x000079DE File Offset: 0x00005BDE
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

		// Token: 0x060012D6 RID: 4822
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_motor(out JointMotor2D value);

		// Token: 0x060012D7 RID: 4823
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_motor(ref JointMotor2D value);

		/// <summary>
		///   <para>Restrictions on how far the joint can slide in each direction along the line.</para>
		/// </summary>
		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060012D8 RID: 4824 RVA: 0x0001A174 File Offset: 0x00018374
		// (set) Token: 0x060012D9 RID: 4825 RVA: 0x000079E8 File Offset: 0x00005BE8
		public JointTranslationLimits2D limits
		{
			get
			{
				JointTranslationLimits2D jointTranslationLimits2D;
				this.INTERNAL_get_limits(out jointTranslationLimits2D);
				return jointTranslationLimits2D;
			}
			set
			{
				this.INTERNAL_set_limits(ref value);
			}
		}

		// Token: 0x060012DA RID: 4826
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_limits(out JointTranslationLimits2D value);

		// Token: 0x060012DB RID: 4827
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_limits(ref JointTranslationLimits2D value);

		/// <summary>
		///   <para>Gets the state of the joint limit.</para>
		/// </summary>
		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060012DC RID: 4828
		public extern JointLimitState2D limitState
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The angle (in degrees) referenced between the two bodies used as the constraint for the joint.</para>
		/// </summary>
		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060012DD RID: 4829
		public extern float referenceAngle
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The current joint translation.</para>
		/// </summary>
		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060012DE RID: 4830
		public extern float jointTranslation
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The current joint speed.</para>
		/// </summary>
		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060012DF RID: 4831
		public extern float jointSpeed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Gets the motor force of the joint given the specified timestep.</para>
		/// </summary>
		/// <param name="timeStep">The time to calculate the motor force for.</param>
		// Token: 0x060012E0 RID: 4832 RVA: 0x000079F2 File Offset: 0x00005BF2
		public float GetMotorForce(float timeStep)
		{
			return SliderJoint2D.INTERNAL_CALL_GetMotorForce(this, timeStep);
		}

		// Token: 0x060012E1 RID: 4833
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_GetMotorForce(SliderJoint2D self, float timeStep);
	}
}
