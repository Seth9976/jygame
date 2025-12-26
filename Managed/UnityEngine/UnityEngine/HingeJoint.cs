using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The HingeJoint groups together 2 rigid bodies, constraining them to move like connected by a hinge.</para>
	/// </summary>
	// Token: 0x02000106 RID: 262
	public sealed class HingeJoint : Joint
	{
		/// <summary>
		///   <para>The motor will apply a force up to a maximum force to achieve the target velocity in degrees per second.</para>
		/// </summary>
		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00018A54 File Offset: 0x00016C54
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x00007209 File Offset: 0x00005409
		public JointMotor motor
		{
			get
			{
				JointMotor jointMotor;
				this.INTERNAL_get_motor(out jointMotor);
				return jointMotor;
			}
			set
			{
				this.INTERNAL_set_motor(ref value);
			}
		}

		// Token: 0x06000FA2 RID: 4002
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_motor(out JointMotor value);

		// Token: 0x06000FA3 RID: 4003
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_motor(ref JointMotor value);

		/// <summary>
		///   <para>Limit of angular rotation (in degrees) on the hinge joint.</para>
		/// </summary>
		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00018A6C File Offset: 0x00016C6C
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x00007213 File Offset: 0x00005413
		public JointLimits limits
		{
			get
			{
				JointLimits jointLimits;
				this.INTERNAL_get_limits(out jointLimits);
				return jointLimits;
			}
			set
			{
				this.INTERNAL_set_limits(ref value);
			}
		}

		// Token: 0x06000FA6 RID: 4006
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_limits(out JointLimits value);

		// Token: 0x06000FA7 RID: 4007
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_limits(ref JointLimits value);

		/// <summary>
		///   <para>The spring attempts to reach a target angle by adding spring and damping forces.</para>
		/// </summary>
		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x00018A84 File Offset: 0x00016C84
		// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x0000721D File Offset: 0x0000541D
		public JointSpring spring
		{
			get
			{
				JointSpring jointSpring;
				this.INTERNAL_get_spring(out jointSpring);
				return jointSpring;
			}
			set
			{
				this.INTERNAL_set_spring(ref value);
			}
		}

		// Token: 0x06000FAA RID: 4010
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_spring(out JointSpring value);

		// Token: 0x06000FAB RID: 4011
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_spring(ref JointSpring value);

		/// <summary>
		///   <para>Enables the joint's motor. Disabled by default.</para>
		/// </summary>
		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000FAC RID: 4012
		// (set) Token: 0x06000FAD RID: 4013
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
		///   <para>Enables the joint's limits. Disabled by default.</para>
		/// </summary>
		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000FAE RID: 4014
		// (set) Token: 0x06000FAF RID: 4015
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
		///   <para>Enables the joint's spring. Disabled by default.</para>
		/// </summary>
		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000FB0 RID: 4016
		// (set) Token: 0x06000FB1 RID: 4017
		public extern bool useSpring
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The angular velocity of the joint in degrees per second.</para>
		/// </summary>
		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000FB2 RID: 4018
		public extern float velocity
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The current angle in degrees of the joint relative to its rest position. (Read Only)</para>
		/// </summary>
		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000FB3 RID: 4019
		public extern float angle
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}
	}
}
