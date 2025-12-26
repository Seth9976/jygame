using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The configurable joint is an extremely flexible joint giving you complete control over rotation and linear motion.</para>
	/// </summary>
	// Token: 0x0200010C RID: 268
	public sealed class ConfigurableJoint : Joint
	{
		/// <summary>
		///   <para>The joint's secondary axis.</para>
		/// </summary>
		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00018B44 File Offset: 0x00016D44
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x0000726D File Offset: 0x0000546D
		public Vector3 secondaryAxis
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_secondaryAxis(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_secondaryAxis(ref value);
			}
		}

		// Token: 0x06000FE6 RID: 4070
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_secondaryAxis(out Vector3 value);

		// Token: 0x06000FE7 RID: 4071
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_secondaryAxis(ref Vector3 value);

		/// <summary>
		///   <para>Allow movement along the X axis to be Free, completely Locked, or Limited according to Linear Limit.</para>
		/// </summary>
		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000FE8 RID: 4072
		// (set) Token: 0x06000FE9 RID: 4073
		public extern ConfigurableJointMotion xMotion
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Allow movement along the Y axis to be Free, completely Locked, or Limited according to Linear Limit.</para>
		/// </summary>
		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000FEA RID: 4074
		// (set) Token: 0x06000FEB RID: 4075
		public extern ConfigurableJointMotion yMotion
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Allow movement along the Z axis to be Free, completely Locked, or Limited according to Linear Limit.</para>
		/// </summary>
		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000FEC RID: 4076
		// (set) Token: 0x06000FED RID: 4077
		public extern ConfigurableJointMotion zMotion
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Allow rotation around the X axis to be Free, completely Locked, or Limited according to Low and High Angular XLimit.</para>
		/// </summary>
		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000FEE RID: 4078
		// (set) Token: 0x06000FEF RID: 4079
		public extern ConfigurableJointMotion angularXMotion
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Allow rotation around the Y axis to be Free, completely Locked, or Limited according to Angular YLimit.</para>
		/// </summary>
		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000FF0 RID: 4080
		// (set) Token: 0x06000FF1 RID: 4081
		public extern ConfigurableJointMotion angularYMotion
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Allow rotation around the Z axis to be Free, completely Locked, or Limited according to Angular ZLimit.</para>
		/// </summary>
		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000FF2 RID: 4082
		// (set) Token: 0x06000FF3 RID: 4083
		public extern ConfigurableJointMotion angularZMotion
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The configuration of the spring attached to the linear limit of the joint.</para>
		/// </summary>
		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x00018B5C File Offset: 0x00016D5C
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x00007277 File Offset: 0x00005477
		public SoftJointLimitSpring linearLimitSpring
		{
			get
			{
				SoftJointLimitSpring softJointLimitSpring;
				this.INTERNAL_get_linearLimitSpring(out softJointLimitSpring);
				return softJointLimitSpring;
			}
			set
			{
				this.INTERNAL_set_linearLimitSpring(ref value);
			}
		}

		// Token: 0x06000FF6 RID: 4086
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_linearLimitSpring(out SoftJointLimitSpring value);

		// Token: 0x06000FF7 RID: 4087
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_linearLimitSpring(ref SoftJointLimitSpring value);

		/// <summary>
		///   <para>The configuration of the spring attached to the angular X limit of the joint.</para>
		/// </summary>
		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x00018B74 File Offset: 0x00016D74
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x00007281 File Offset: 0x00005481
		public SoftJointLimitSpring angularXLimitSpring
		{
			get
			{
				SoftJointLimitSpring softJointLimitSpring;
				this.INTERNAL_get_angularXLimitSpring(out softJointLimitSpring);
				return softJointLimitSpring;
			}
			set
			{
				this.INTERNAL_set_angularXLimitSpring(ref value);
			}
		}

		// Token: 0x06000FFA RID: 4090
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_angularXLimitSpring(out SoftJointLimitSpring value);

		// Token: 0x06000FFB RID: 4091
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_angularXLimitSpring(ref SoftJointLimitSpring value);

		/// <summary>
		///   <para>The configuration of the spring attached to the angular Y and angular Z limits of the joint.</para>
		/// </summary>
		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x00018B8C File Offset: 0x00016D8C
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x0000728B File Offset: 0x0000548B
		public SoftJointLimitSpring angularYZLimitSpring
		{
			get
			{
				SoftJointLimitSpring softJointLimitSpring;
				this.INTERNAL_get_angularYZLimitSpring(out softJointLimitSpring);
				return softJointLimitSpring;
			}
			set
			{
				this.INTERNAL_set_angularYZLimitSpring(ref value);
			}
		}

		// Token: 0x06000FFE RID: 4094
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_angularYZLimitSpring(out SoftJointLimitSpring value);

		// Token: 0x06000FFF RID: 4095
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_angularYZLimitSpring(ref SoftJointLimitSpring value);

		/// <summary>
		///   <para>Boundary defining movement restriction, based on distance from the joint's origin.</para>
		/// </summary>
		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x00018BA4 File Offset: 0x00016DA4
		// (set) Token: 0x06001001 RID: 4097 RVA: 0x00007295 File Offset: 0x00005495
		public SoftJointLimit linearLimit
		{
			get
			{
				SoftJointLimit softJointLimit;
				this.INTERNAL_get_linearLimit(out softJointLimit);
				return softJointLimit;
			}
			set
			{
				this.INTERNAL_set_linearLimit(ref value);
			}
		}

		// Token: 0x06001002 RID: 4098
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_linearLimit(out SoftJointLimit value);

		// Token: 0x06001003 RID: 4099
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_linearLimit(ref SoftJointLimit value);

		/// <summary>
		///   <para>Boundary defining lower rotation restriction, based on delta from original rotation.</para>
		/// </summary>
		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x00018BBC File Offset: 0x00016DBC
		// (set) Token: 0x06001005 RID: 4101 RVA: 0x0000729F File Offset: 0x0000549F
		public SoftJointLimit lowAngularXLimit
		{
			get
			{
				SoftJointLimit softJointLimit;
				this.INTERNAL_get_lowAngularXLimit(out softJointLimit);
				return softJointLimit;
			}
			set
			{
				this.INTERNAL_set_lowAngularXLimit(ref value);
			}
		}

		// Token: 0x06001006 RID: 4102
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_lowAngularXLimit(out SoftJointLimit value);

		// Token: 0x06001007 RID: 4103
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_lowAngularXLimit(ref SoftJointLimit value);

		/// <summary>
		///   <para>Boundary defining upper rotation restriction, based on delta from original rotation.</para>
		/// </summary>
		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x00018BD4 File Offset: 0x00016DD4
		// (set) Token: 0x06001009 RID: 4105 RVA: 0x000072A9 File Offset: 0x000054A9
		public SoftJointLimit highAngularXLimit
		{
			get
			{
				SoftJointLimit softJointLimit;
				this.INTERNAL_get_highAngularXLimit(out softJointLimit);
				return softJointLimit;
			}
			set
			{
				this.INTERNAL_set_highAngularXLimit(ref value);
			}
		}

		// Token: 0x0600100A RID: 4106
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_highAngularXLimit(out SoftJointLimit value);

		// Token: 0x0600100B RID: 4107
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_highAngularXLimit(ref SoftJointLimit value);

		/// <summary>
		///   <para>Boundary defining rotation restriction, based on delta from original rotation.</para>
		/// </summary>
		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x00018BEC File Offset: 0x00016DEC
		// (set) Token: 0x0600100D RID: 4109 RVA: 0x000072B3 File Offset: 0x000054B3
		public SoftJointLimit angularYLimit
		{
			get
			{
				SoftJointLimit softJointLimit;
				this.INTERNAL_get_angularYLimit(out softJointLimit);
				return softJointLimit;
			}
			set
			{
				this.INTERNAL_set_angularYLimit(ref value);
			}
		}

		// Token: 0x0600100E RID: 4110
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_angularYLimit(out SoftJointLimit value);

		// Token: 0x0600100F RID: 4111
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_angularYLimit(ref SoftJointLimit value);

		/// <summary>
		///   <para>Boundary defining rotation restriction, based on delta from original rotation.</para>
		/// </summary>
		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x00018C04 File Offset: 0x00016E04
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x000072BD File Offset: 0x000054BD
		public SoftJointLimit angularZLimit
		{
			get
			{
				SoftJointLimit softJointLimit;
				this.INTERNAL_get_angularZLimit(out softJointLimit);
				return softJointLimit;
			}
			set
			{
				this.INTERNAL_set_angularZLimit(ref value);
			}
		}

		// Token: 0x06001012 RID: 4114
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_angularZLimit(out SoftJointLimit value);

		// Token: 0x06001013 RID: 4115
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_angularZLimit(ref SoftJointLimit value);

		/// <summary>
		///   <para>The desired position that the joint should move into.</para>
		/// </summary>
		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x00018C1C File Offset: 0x00016E1C
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x000072C7 File Offset: 0x000054C7
		public Vector3 targetPosition
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_targetPosition(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_targetPosition(ref value);
			}
		}

		// Token: 0x06001016 RID: 4118
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_targetPosition(out Vector3 value);

		// Token: 0x06001017 RID: 4119
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_targetPosition(ref Vector3 value);

		/// <summary>
		///   <para>The desired velocity that the joint should move along.</para>
		/// </summary>
		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x00018C34 File Offset: 0x00016E34
		// (set) Token: 0x06001019 RID: 4121 RVA: 0x000072D1 File Offset: 0x000054D1
		public Vector3 targetVelocity
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_targetVelocity(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_targetVelocity(ref value);
			}
		}

		// Token: 0x0600101A RID: 4122
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_targetVelocity(out Vector3 value);

		// Token: 0x0600101B RID: 4123
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_targetVelocity(ref Vector3 value);

		/// <summary>
		///   <para>Definition of how the joint's movement will behave along its local X axis.</para>
		/// </summary>
		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x00018C4C File Offset: 0x00016E4C
		// (set) Token: 0x0600101D RID: 4125 RVA: 0x000072DB File Offset: 0x000054DB
		public JointDrive xDrive
		{
			get
			{
				JointDrive jointDrive;
				this.INTERNAL_get_xDrive(out jointDrive);
				return jointDrive;
			}
			set
			{
				this.INTERNAL_set_xDrive(ref value);
			}
		}

		// Token: 0x0600101E RID: 4126
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_xDrive(out JointDrive value);

		// Token: 0x0600101F RID: 4127
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_xDrive(ref JointDrive value);

		/// <summary>
		///   <para>Definition of how the joint's movement will behave along its local Y axis.</para>
		/// </summary>
		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x00018C64 File Offset: 0x00016E64
		// (set) Token: 0x06001021 RID: 4129 RVA: 0x000072E5 File Offset: 0x000054E5
		public JointDrive yDrive
		{
			get
			{
				JointDrive jointDrive;
				this.INTERNAL_get_yDrive(out jointDrive);
				return jointDrive;
			}
			set
			{
				this.INTERNAL_set_yDrive(ref value);
			}
		}

		// Token: 0x06001022 RID: 4130
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_yDrive(out JointDrive value);

		// Token: 0x06001023 RID: 4131
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_yDrive(ref JointDrive value);

		/// <summary>
		///   <para>Definition of how the joint's movement will behave along its local Z axis.</para>
		/// </summary>
		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x00018C7C File Offset: 0x00016E7C
		// (set) Token: 0x06001025 RID: 4133 RVA: 0x000072EF File Offset: 0x000054EF
		public JointDrive zDrive
		{
			get
			{
				JointDrive jointDrive;
				this.INTERNAL_get_zDrive(out jointDrive);
				return jointDrive;
			}
			set
			{
				this.INTERNAL_set_zDrive(ref value);
			}
		}

		// Token: 0x06001026 RID: 4134
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_zDrive(out JointDrive value);

		// Token: 0x06001027 RID: 4135
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_zDrive(ref JointDrive value);

		/// <summary>
		///   <para>This is a Quaternion. It defines the desired rotation that the joint should rotate into.</para>
		/// </summary>
		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x00018C94 File Offset: 0x00016E94
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x000072F9 File Offset: 0x000054F9
		public Quaternion targetRotation
		{
			get
			{
				Quaternion quaternion;
				this.INTERNAL_get_targetRotation(out quaternion);
				return quaternion;
			}
			set
			{
				this.INTERNAL_set_targetRotation(ref value);
			}
		}

		// Token: 0x0600102A RID: 4138
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_targetRotation(out Quaternion value);

		// Token: 0x0600102B RID: 4139
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_targetRotation(ref Quaternion value);

		/// <summary>
		///   <para>This is a Vector3. It defines the desired angular velocity that the joint should rotate into.</para>
		/// </summary>
		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x00018CAC File Offset: 0x00016EAC
		// (set) Token: 0x0600102D RID: 4141 RVA: 0x00007303 File Offset: 0x00005503
		public Vector3 targetAngularVelocity
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_targetAngularVelocity(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_targetAngularVelocity(ref value);
			}
		}

		// Token: 0x0600102E RID: 4142
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_targetAngularVelocity(out Vector3 value);

		// Token: 0x0600102F RID: 4143
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_targetAngularVelocity(ref Vector3 value);

		/// <summary>
		///   <para>Control the object's rotation with either X &amp; YZ or Slerp Drive by itself.</para>
		/// </summary>
		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001030 RID: 4144
		// (set) Token: 0x06001031 RID: 4145
		public extern RotationDriveMode rotationDriveMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Definition of how the joint's rotation will behave around its local X axis. Only used if Rotation Drive Mode is Swing &amp; Twist.</para>
		/// </summary>
		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x00018CC4 File Offset: 0x00016EC4
		// (set) Token: 0x06001033 RID: 4147 RVA: 0x0000730D File Offset: 0x0000550D
		public JointDrive angularXDrive
		{
			get
			{
				JointDrive jointDrive;
				this.INTERNAL_get_angularXDrive(out jointDrive);
				return jointDrive;
			}
			set
			{
				this.INTERNAL_set_angularXDrive(ref value);
			}
		}

		// Token: 0x06001034 RID: 4148
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_angularXDrive(out JointDrive value);

		// Token: 0x06001035 RID: 4149
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_angularXDrive(ref JointDrive value);

		/// <summary>
		///   <para>Definition of how the joint's rotation will behave around its local Y and Z axes. Only used if Rotation Drive Mode is Swing &amp; Twist.</para>
		/// </summary>
		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x00018CDC File Offset: 0x00016EDC
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x00007317 File Offset: 0x00005517
		public JointDrive angularYZDrive
		{
			get
			{
				JointDrive jointDrive;
				this.INTERNAL_get_angularYZDrive(out jointDrive);
				return jointDrive;
			}
			set
			{
				this.INTERNAL_set_angularYZDrive(ref value);
			}
		}

		// Token: 0x06001038 RID: 4152
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_angularYZDrive(out JointDrive value);

		// Token: 0x06001039 RID: 4153
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_angularYZDrive(ref JointDrive value);

		/// <summary>
		///   <para>Definition of how the joint's rotation will behave around all local axes. Only used if Rotation Drive Mode is Slerp Only.</para>
		/// </summary>
		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x00018CF4 File Offset: 0x00016EF4
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x00007321 File Offset: 0x00005521
		public JointDrive slerpDrive
		{
			get
			{
				JointDrive jointDrive;
				this.INTERNAL_get_slerpDrive(out jointDrive);
				return jointDrive;
			}
			set
			{
				this.INTERNAL_set_slerpDrive(ref value);
			}
		}

		// Token: 0x0600103C RID: 4156
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_slerpDrive(out JointDrive value);

		// Token: 0x0600103D RID: 4157
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_slerpDrive(ref JointDrive value);

		/// <summary>
		///   <para>Brings violated constraints back into alignment even when the solver fails. Projection is not a physical process and does not preserve momentum or respect collision geometry. It is best avoided if practical, but can be useful in improving simulation quality where joint separation results in unacceptable artifacts.</para>
		/// </summary>
		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x0600103E RID: 4158
		// (set) Token: 0x0600103F RID: 4159
		public extern JointProjectionMode projectionMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Set the linear tolerance threshold for projection.
		///
		/// If the joint separates by more than this distance along its locked degrees of freedom, the solver 
		/// will move the bodies to close the distance.
		///
		/// Setting a very small tolerance may result in simulation jitter or other artifacts.
		///
		/// Sometimes it is not possible to project (for example when the joints form a cycle).</para>
		/// </summary>
		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001040 RID: 4160
		// (set) Token: 0x06001041 RID: 4161
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
		///   <para>Set the angular tolerance threshold (in degrees) for projection.
		///
		/// If the joint deviates by more than this angle around its locked angular degrees of freedom, 
		/// the solver will move the bodies to close the angle.
		///
		/// Setting a very small tolerance may result in simulation jitter or other artifacts.
		///
		/// Sometimes it is not possible to project (for example when the joints form a cycle).</para>
		/// </summary>
		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001042 RID: 4162
		// (set) Token: 0x06001043 RID: 4163
		public extern float projectionAngle
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>If enabled, all Target values will be calculated in world space instead of the object's local space.</para>
		/// </summary>
		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001044 RID: 4164
		// (set) Token: 0x06001045 RID: 4165
		public extern bool configuredInWorldSpace
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>If enabled, the two connected rigidbodies will be swapped, as if the joint was attached to the other body.</para>
		/// </summary>
		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001046 RID: 4166
		// (set) Token: 0x06001047 RID: 4167
		public extern bool swapBodies
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
