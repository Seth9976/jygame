using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Character Joints are mainly used for Ragdoll effects.</para>
	/// </summary>
	// Token: 0x02000109 RID: 265
	public sealed class CharacterJoint : Joint
	{
		/// <summary>
		///   <para>The secondary axis around which the joint can rotate.</para>
		/// </summary>
		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000FC1 RID: 4033 RVA: 0x00018A9C File Offset: 0x00016C9C
		// (set) Token: 0x06000FC2 RID: 4034 RVA: 0x00007227 File Offset: 0x00005427
		public Vector3 swingAxis
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_swingAxis(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_swingAxis(ref value);
			}
		}

		// Token: 0x06000FC3 RID: 4035
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_swingAxis(out Vector3 value);

		// Token: 0x06000FC4 RID: 4036
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_swingAxis(ref Vector3 value);

		/// <summary>
		///   <para>The configuration of the spring attached to the twist limits of the joint.</para>
		/// </summary>
		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x00018AB4 File Offset: 0x00016CB4
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x00007231 File Offset: 0x00005431
		public SoftJointLimitSpring twistLimitSpring
		{
			get
			{
				SoftJointLimitSpring softJointLimitSpring;
				this.INTERNAL_get_twistLimitSpring(out softJointLimitSpring);
				return softJointLimitSpring;
			}
			set
			{
				this.INTERNAL_set_twistLimitSpring(ref value);
			}
		}

		// Token: 0x06000FC7 RID: 4039
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_twistLimitSpring(out SoftJointLimitSpring value);

		// Token: 0x06000FC8 RID: 4040
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_twistLimitSpring(ref SoftJointLimitSpring value);

		/// <summary>
		///   <para>The configuration of the spring attached to the swing limits of the joint.</para>
		/// </summary>
		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x00018ACC File Offset: 0x00016CCC
		// (set) Token: 0x06000FCA RID: 4042 RVA: 0x0000723B File Offset: 0x0000543B
		public SoftJointLimitSpring swingLimitSpring
		{
			get
			{
				SoftJointLimitSpring softJointLimitSpring;
				this.INTERNAL_get_swingLimitSpring(out softJointLimitSpring);
				return softJointLimitSpring;
			}
			set
			{
				this.INTERNAL_set_swingLimitSpring(ref value);
			}
		}

		// Token: 0x06000FCB RID: 4043
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_swingLimitSpring(out SoftJointLimitSpring value);

		// Token: 0x06000FCC RID: 4044
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_swingLimitSpring(ref SoftJointLimitSpring value);

		/// <summary>
		///   <para>The lower limit around the primary axis of the character joint.</para>
		/// </summary>
		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x00018AE4 File Offset: 0x00016CE4
		// (set) Token: 0x06000FCE RID: 4046 RVA: 0x00007245 File Offset: 0x00005445
		public SoftJointLimit lowTwistLimit
		{
			get
			{
				SoftJointLimit softJointLimit;
				this.INTERNAL_get_lowTwistLimit(out softJointLimit);
				return softJointLimit;
			}
			set
			{
				this.INTERNAL_set_lowTwistLimit(ref value);
			}
		}

		// Token: 0x06000FCF RID: 4047
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_lowTwistLimit(out SoftJointLimit value);

		// Token: 0x06000FD0 RID: 4048
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_lowTwistLimit(ref SoftJointLimit value);

		/// <summary>
		///   <para>The upper limit around the primary axis of the character joint.</para>
		/// </summary>
		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x00018AFC File Offset: 0x00016CFC
		// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x0000724F File Offset: 0x0000544F
		public SoftJointLimit highTwistLimit
		{
			get
			{
				SoftJointLimit softJointLimit;
				this.INTERNAL_get_highTwistLimit(out softJointLimit);
				return softJointLimit;
			}
			set
			{
				this.INTERNAL_set_highTwistLimit(ref value);
			}
		}

		// Token: 0x06000FD3 RID: 4051
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_highTwistLimit(out SoftJointLimit value);

		// Token: 0x06000FD4 RID: 4052
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_highTwistLimit(ref SoftJointLimit value);

		/// <summary>
		///   <para>The angular limit of rotation (in degrees) around the primary axis of the character joint.</para>
		/// </summary>
		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x00018B14 File Offset: 0x00016D14
		// (set) Token: 0x06000FD6 RID: 4054 RVA: 0x00007259 File Offset: 0x00005459
		public SoftJointLimit swing1Limit
		{
			get
			{
				SoftJointLimit softJointLimit;
				this.INTERNAL_get_swing1Limit(out softJointLimit);
				return softJointLimit;
			}
			set
			{
				this.INTERNAL_set_swing1Limit(ref value);
			}
		}

		// Token: 0x06000FD7 RID: 4055
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_swing1Limit(out SoftJointLimit value);

		// Token: 0x06000FD8 RID: 4056
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_swing1Limit(ref SoftJointLimit value);

		/// <summary>
		///   <para>The angular limit of rotation (in degrees) around the primary axis of the character joint.</para>
		/// </summary>
		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00018B2C File Offset: 0x00016D2C
		// (set) Token: 0x06000FDA RID: 4058 RVA: 0x00007263 File Offset: 0x00005463
		public SoftJointLimit swing2Limit
		{
			get
			{
				SoftJointLimit softJointLimit;
				this.INTERNAL_get_swing2Limit(out softJointLimit);
				return softJointLimit;
			}
			set
			{
				this.INTERNAL_set_swing2Limit(ref value);
			}
		}

		// Token: 0x06000FDB RID: 4059
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_swing2Limit(out SoftJointLimit value);

		// Token: 0x06000FDC RID: 4060
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_swing2Limit(ref SoftJointLimit value);

		/// <summary>
		///   <para>Brings violated constraints back into alignment even when the solver fails.</para>
		/// </summary>
		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000FDD RID: 4061
		// (set) Token: 0x06000FDE RID: 4062
		public extern bool enableProjection
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Set the linear tolerance threshold for projection.</para>
		/// </summary>
		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000FDF RID: 4063
		// (set) Token: 0x06000FE0 RID: 4064
		public extern float projectionDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Set the angular tolerance threshold (in degrees) for projection.</para>
		/// </summary>
		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000FE1 RID: 4065
		// (set) Token: 0x06000FE2 RID: 4066
		public extern float projectionAngle
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x04000316 RID: 790
		[Obsolete("TargetRotation not in use for Unity 5 and assumed disabled.", true)]
		public Quaternion targetRotation;

		// Token: 0x04000317 RID: 791
		[Obsolete("TargetAngularVelocity not in use for Unity 5 and assumed disabled.", true)]
		public Vector3 targetAngularVelocity;

		// Token: 0x04000318 RID: 792
		[Obsolete("RotationDrive not in use for Unity 5 and assumed disabled.", true)]
		public JointDrive rotationDrive;
	}
}
