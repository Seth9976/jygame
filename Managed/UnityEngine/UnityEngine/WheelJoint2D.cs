using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The wheel joint allows the simulation of wheels by providing a constraining suspension motion with an optional motor.</para>
	/// </summary>
	// Token: 0x02000135 RID: 309
	public sealed class WheelJoint2D : AnchoredJoint2D
	{
		/// <summary>
		///   <para>Set the joint suspension configuration.</para>
		/// </summary>
		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x0001A18C File Offset: 0x0001838C
		// (set) Token: 0x060012E4 RID: 4836 RVA: 0x000079FB File Offset: 0x00005BFB
		public JointSuspension2D suspension
		{
			get
			{
				JointSuspension2D jointSuspension2D;
				this.INTERNAL_get_suspension(out jointSuspension2D);
				return jointSuspension2D;
			}
			set
			{
				this.INTERNAL_set_suspension(ref value);
			}
		}

		// Token: 0x060012E5 RID: 4837
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_suspension(out JointSuspension2D value);

		// Token: 0x060012E6 RID: 4838
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_suspension(ref JointSuspension2D value);

		/// <summary>
		///   <para>Should a motor force be applied automatically to the Rigidbody2D?</para>
		/// </summary>
		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060012E7 RID: 4839
		// (set) Token: 0x060012E8 RID: 4840
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
		///   <para>Parameters for a motor force that is applied automatically to the Rigibody2D along the line.</para>
		/// </summary>
		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x0001A1A4 File Offset: 0x000183A4
		// (set) Token: 0x060012EA RID: 4842 RVA: 0x00007A05 File Offset: 0x00005C05
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

		// Token: 0x060012EB RID: 4843
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_motor(out JointMotor2D value);

		// Token: 0x060012EC RID: 4844
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_motor(ref JointMotor2D value);

		/// <summary>
		///   <para>The current joint translation.</para>
		/// </summary>
		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060012ED RID: 4845
		public extern float jointTranslation
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The current joint speed.</para>
		/// </summary>
		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060012EE RID: 4846
		public extern float jointSpeed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Gets the motor torque of the joint given the specified timestep.</para>
		/// </summary>
		/// <param name="timeStep">The time to calculate the motor torque for.</param>
		// Token: 0x060012EF RID: 4847 RVA: 0x00007A0F File Offset: 0x00005C0F
		public float GetMotorTorque(float timeStep)
		{
			return WheelJoint2D.INTERNAL_CALL_GetMotorTorque(this, timeStep);
		}

		// Token: 0x060012F0 RID: 4848
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_GetMotorTorque(WheelJoint2D self, float timeStep);
	}
}
