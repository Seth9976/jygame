using System;
using System.Runtime.CompilerServices;
using UnityEngine.Experimental.Director;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Interface to control the Mecanim animation system.</para>
	/// </summary>
	// Token: 0x02000189 RID: 393
	public sealed class Animator : DirectorPlayer, IAnimatorControllerPlayable
	{
		/// <summary>
		///   <para>Returns true if the current rig is optimizable with AnimatorUtility.OptimizeTransformHierarchy.</para>
		/// </summary>
		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001636 RID: 5686
		public extern bool isOptimizable
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns true if the current rig is humanoid, false if it is generic.</para>
		/// </summary>
		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001637 RID: 5687
		public extern bool isHuman
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns true if the current rig has root motion.</para>
		/// </summary>
		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001638 RID: 5688
		public extern bool hasRootMotion
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001639 RID: 5689
		internal extern bool isRootPositionOrRotationControlledByCurves
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns the scale of the current Avatar for a humanoid rig, (1 by default if the rig is generic).</para>
		/// </summary>
		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x0600163A RID: 5690
		public extern float humanScale
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns whether the animator is initialized successfully.</para>
		/// </summary>
		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x0600163B RID: 5691
		public extern bool isInitialized
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.GetFloat.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="id"></param>
		// Token: 0x0600163C RID: 5692 RVA: 0x0000829F File Offset: 0x0000649F
		public float GetFloat(string name)
		{
			return this.GetFloatString(name);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.GetFloat.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="id"></param>
		// Token: 0x0600163D RID: 5693 RVA: 0x000082A8 File Offset: 0x000064A8
		public float GetFloat(int id)
		{
			return this.GetFloatID(id);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.SetFloat.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="dampTime"></param>
		/// <param name="deltaTime"></param>
		/// <param name="id"></param>
		// Token: 0x0600163E RID: 5694 RVA: 0x000082B1 File Offset: 0x000064B1
		public void SetFloat(string name, float value)
		{
			this.SetFloatString(name, value);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.SetFloat.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="dampTime"></param>
		/// <param name="deltaTime"></param>
		/// <param name="id"></param>
		// Token: 0x0600163F RID: 5695 RVA: 0x000082BB File Offset: 0x000064BB
		public void SetFloat(string name, float value, float dampTime, float deltaTime)
		{
			this.SetFloatStringDamp(name, value, dampTime, deltaTime);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.SetFloat.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="dampTime"></param>
		/// <param name="deltaTime"></param>
		/// <param name="id"></param>
		// Token: 0x06001640 RID: 5696 RVA: 0x000082C8 File Offset: 0x000064C8
		public void SetFloat(int id, float value)
		{
			this.SetFloatID(id, value);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.SetFloat.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="dampTime"></param>
		/// <param name="deltaTime"></param>
		/// <param name="id"></param>
		// Token: 0x06001641 RID: 5697 RVA: 0x000082D2 File Offset: 0x000064D2
		public void SetFloat(int id, float value, float dampTime, float deltaTime)
		{
			this.SetFloatIDDamp(id, value, dampTime, deltaTime);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.GetBool.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="id"></param>
		// Token: 0x06001642 RID: 5698 RVA: 0x000082DF File Offset: 0x000064DF
		public bool GetBool(string name)
		{
			return this.GetBoolString(name);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.GetBool.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="id"></param>
		// Token: 0x06001643 RID: 5699 RVA: 0x000082E8 File Offset: 0x000064E8
		public bool GetBool(int id)
		{
			return this.GetBoolID(id);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.SetBool.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="id"></param>
		// Token: 0x06001644 RID: 5700 RVA: 0x000082F1 File Offset: 0x000064F1
		public void SetBool(string name, bool value)
		{
			this.SetBoolString(name, value);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.SetBool.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="id"></param>
		// Token: 0x06001645 RID: 5701 RVA: 0x000082FB File Offset: 0x000064FB
		public void SetBool(int id, bool value)
		{
			this.SetBoolID(id, value);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.GetInteger.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="id"></param>
		// Token: 0x06001646 RID: 5702 RVA: 0x00008305 File Offset: 0x00006505
		public int GetInteger(string name)
		{
			return this.GetIntegerString(name);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.GetInteger.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="id"></param>
		// Token: 0x06001647 RID: 5703 RVA: 0x0000830E File Offset: 0x0000650E
		public int GetInteger(int id)
		{
			return this.GetIntegerID(id);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.SetInteger.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="id"></param>
		// Token: 0x06001648 RID: 5704 RVA: 0x00008317 File Offset: 0x00006517
		public void SetInteger(string name, int value)
		{
			this.SetIntegerString(name, value);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.SetInteger.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="id"></param>
		// Token: 0x06001649 RID: 5705 RVA: 0x00008321 File Offset: 0x00006521
		public void SetInteger(int id, int value)
		{
			this.SetIntegerID(id, value);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.SetTrigger.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="id"></param>
		// Token: 0x0600164A RID: 5706 RVA: 0x0000832B File Offset: 0x0000652B
		public void SetTrigger(string name)
		{
			this.SetTriggerString(name);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.SetTrigger.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="id"></param>
		// Token: 0x0600164B RID: 5707 RVA: 0x00008334 File Offset: 0x00006534
		public void SetTrigger(int id)
		{
			this.SetTriggerID(id);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.ResetTrigger.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="id"></param>
		// Token: 0x0600164C RID: 5708 RVA: 0x0000833D File Offset: 0x0000653D
		public void ResetTrigger(string name)
		{
			this.ResetTriggerString(name);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.ResetTrigger.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="id"></param>
		// Token: 0x0600164D RID: 5709 RVA: 0x00008346 File Offset: 0x00006546
		public void ResetTrigger(int id)
		{
			this.ResetTriggerID(id);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.IsParameterControlledByCurve.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="id"></param>
		// Token: 0x0600164E RID: 5710 RVA: 0x0000834F File Offset: 0x0000654F
		public bool IsParameterControlledByCurve(string name)
		{
			return this.IsParameterControlledByCurveString(name);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.IsParameterControlledByCurve.</para>
		/// </summary>
		/// <param name="name"></param>
		/// <param name="id"></param>
		// Token: 0x0600164F RID: 5711 RVA: 0x00008358 File Offset: 0x00006558
		public bool IsParameterControlledByCurve(int id)
		{
			return this.IsParameterControlledByCurveID(id);
		}

		/// <summary>
		///   <para>Gets the avatar delta position for the last evaluated frame.</para>
		/// </summary>
		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x0001AA84 File Offset: 0x00018C84
		public Vector3 deltaPosition
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_deltaPosition(out vector);
				return vector;
			}
		}

		// Token: 0x06001651 RID: 5713
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_deltaPosition(out Vector3 value);

		/// <summary>
		///   <para>Gets the avatar delta rotation for the last evaluated frame.</para>
		/// </summary>
		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x0001AA9C File Offset: 0x00018C9C
		public Quaternion deltaRotation
		{
			get
			{
				Quaternion quaternion;
				this.INTERNAL_get_deltaRotation(out quaternion);
				return quaternion;
			}
		}

		// Token: 0x06001653 RID: 5715
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_deltaRotation(out Quaternion value);

		/// <summary>
		///   <para>Gets the avatar velocity  for the last evaluated frame.</para>
		/// </summary>
		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001654 RID: 5716 RVA: 0x0001AAB4 File Offset: 0x00018CB4
		public Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_velocity(out vector);
				return vector;
			}
		}

		// Token: 0x06001655 RID: 5717
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_velocity(out Vector3 value);

		/// <summary>
		///   <para>Gets the avatar angular velocity for the last evaluated frame.</para>
		/// </summary>
		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001656 RID: 5718 RVA: 0x0001AACC File Offset: 0x00018CCC
		public Vector3 angularVelocity
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_angularVelocity(out vector);
				return vector;
			}
		}

		// Token: 0x06001657 RID: 5719
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_angularVelocity(out Vector3 value);

		/// <summary>
		///   <para>The root position, the position of the game object.</para>
		/// </summary>
		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x0001AAE4 File Offset: 0x00018CE4
		// (set) Token: 0x06001659 RID: 5721 RVA: 0x00008361 File Offset: 0x00006561
		public Vector3 rootPosition
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_rootPosition(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_rootPosition(ref value);
			}
		}

		// Token: 0x0600165A RID: 5722
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rootPosition(out Vector3 value);

		// Token: 0x0600165B RID: 5723
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_rootPosition(ref Vector3 value);

		/// <summary>
		///   <para>The root rotation, the rotation of the game object.</para>
		/// </summary>
		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x0600165C RID: 5724 RVA: 0x0001AAFC File Offset: 0x00018CFC
		// (set) Token: 0x0600165D RID: 5725 RVA: 0x0000836B File Offset: 0x0000656B
		public Quaternion rootRotation
		{
			get
			{
				Quaternion quaternion;
				this.INTERNAL_get_rootRotation(out quaternion);
				return quaternion;
			}
			set
			{
				this.INTERNAL_set_rootRotation(ref value);
			}
		}

		// Token: 0x0600165E RID: 5726
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rootRotation(out Quaternion value);

		// Token: 0x0600165F RID: 5727
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_rootRotation(ref Quaternion value);

		/// <summary>
		///   <para>Should root motion be applied?</para>
		/// </summary>
		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001660 RID: 5728
		// (set) Token: 0x06001661 RID: 5729
		public extern bool applyRootMotion
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>When linearVelocityBlending is set to true, the root motion velocity and angular velocity will be blended linearly.</para>
		/// </summary>
		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001662 RID: 5730
		// (set) Token: 0x06001663 RID: 5731
		public extern bool linearVelocityBlending
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>When turned on, animations will be executed in the physics loop. This is only useful in conjunction with kinematic rigidbodies.</para>
		/// </summary>
		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x00008375 File Offset: 0x00006575
		// (set) Token: 0x06001665 RID: 5733 RVA: 0x00008380 File Offset: 0x00006580
		[Obsolete("Use Animator.updateMode instead")]
		public bool animatePhysics
		{
			get
			{
				return this.updateMode == AnimatorUpdateMode.AnimatePhysics;
			}
			set
			{
				this.updateMode = ((!value) ? AnimatorUpdateMode.Normal : AnimatorUpdateMode.AnimatePhysics);
			}
		}

		/// <summary>
		///   <para>Specifies the update mode of the Animator.</para>
		/// </summary>
		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001666 RID: 5734
		// (set) Token: 0x06001667 RID: 5735
		public extern AnimatorUpdateMode updateMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Returns true if the object has a transform hierarchy.</para>
		/// </summary>
		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001668 RID: 5736
		public extern bool hasTransformHierarchy
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001669 RID: 5737
		// (set) Token: 0x0600166A RID: 5738
		internal extern bool allowConstantClipSamplingOptimization
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The current gravity weight based on current animations that are played.</para>
		/// </summary>
		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x0600166B RID: 5739
		public extern float gravityWeight
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The position of the body center of mass.</para>
		/// </summary>
		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x0001AB14 File Offset: 0x00018D14
		// (set) Token: 0x0600166D RID: 5741 RVA: 0x00008395 File Offset: 0x00006595
		public Vector3 bodyPosition
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_bodyPosition(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_bodyPosition(ref value);
			}
		}

		// Token: 0x0600166E RID: 5742
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_bodyPosition(out Vector3 value);

		// Token: 0x0600166F RID: 5743
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_bodyPosition(ref Vector3 value);

		/// <summary>
		///   <para>The rotation of the body center of mass.</para>
		/// </summary>
		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x0001AB2C File Offset: 0x00018D2C
		// (set) Token: 0x06001671 RID: 5745 RVA: 0x0000839F File Offset: 0x0000659F
		public Quaternion bodyRotation
		{
			get
			{
				Quaternion quaternion;
				this.INTERNAL_get_bodyRotation(out quaternion);
				return quaternion;
			}
			set
			{
				this.INTERNAL_set_bodyRotation(ref value);
			}
		}

		// Token: 0x06001672 RID: 5746
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_bodyRotation(out Quaternion value);

		// Token: 0x06001673 RID: 5747
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_bodyRotation(ref Quaternion value);

		/// <summary>
		///   <para>Gets the position of an IK goal.</para>
		/// </summary>
		/// <param name="goal">The AvatarIKGoal that is queried.</param>
		/// <returns>
		///   <para>Return the current position of this IK goal in world space.</para>
		/// </returns>
		// Token: 0x06001674 RID: 5748 RVA: 0x000083A9 File Offset: 0x000065A9
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			this.CheckIfInIKPass();
			return this.GetIKPositionInternal(goal);
		}

		// Token: 0x06001675 RID: 5749
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Vector3 GetIKPositionInternal(AvatarIKGoal goal);

		/// <summary>
		///   <para>Sets the position of an IK goal.</para>
		/// </summary>
		/// <param name="goal">The AvatarIKGoal that is set.</param>
		/// <param name="goalPosition">The position in world space.</param>
		// Token: 0x06001676 RID: 5750 RVA: 0x000083B8 File Offset: 0x000065B8
		public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition)
		{
			this.CheckIfInIKPass();
			this.SetIKPositionInternal(goal, goalPosition);
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x000083C8 File Offset: 0x000065C8
		internal void SetIKPositionInternal(AvatarIKGoal goal, Vector3 goalPosition)
		{
			Animator.INTERNAL_CALL_SetIKPositionInternal(this, goal, ref goalPosition);
		}

		// Token: 0x06001678 RID: 5752
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetIKPositionInternal(Animator self, AvatarIKGoal goal, ref Vector3 goalPosition);

		/// <summary>
		///   <para>Gets the rotation of an IK goal.</para>
		/// </summary>
		/// <param name="goal">The AvatarIKGoal that is is queried.</param>
		// Token: 0x06001679 RID: 5753 RVA: 0x000083D3 File Offset: 0x000065D3
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			this.CheckIfInIKPass();
			return this.GetIKRotationInternal(goal);
		}

		// Token: 0x0600167A RID: 5754
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Quaternion GetIKRotationInternal(AvatarIKGoal goal);

		/// <summary>
		///   <para>Sets the rotation of an IK goal.</para>
		/// </summary>
		/// <param name="goal">The AvatarIKGoal that is set.</param>
		/// <param name="goalRotation">The rotation in world space.</param>
		// Token: 0x0600167B RID: 5755 RVA: 0x000083E2 File Offset: 0x000065E2
		public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation)
		{
			this.CheckIfInIKPass();
			this.SetIKRotationInternal(goal, goalRotation);
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x000083F2 File Offset: 0x000065F2
		internal void SetIKRotationInternal(AvatarIKGoal goal, Quaternion goalRotation)
		{
			Animator.INTERNAL_CALL_SetIKRotationInternal(this, goal, ref goalRotation);
		}

		// Token: 0x0600167D RID: 5757
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetIKRotationInternal(Animator self, AvatarIKGoal goal, ref Quaternion goalRotation);

		/// <summary>
		///   <para>Gets the translative weight of an IK goal (0 = at the original animation before IK, 1 = at the goal).</para>
		/// </summary>
		/// <param name="goal">The AvatarIKGoal that is queried.</param>
		// Token: 0x0600167E RID: 5758 RVA: 0x000083FD File Offset: 0x000065FD
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			this.CheckIfInIKPass();
			return this.GetIKPositionWeightInternal(goal);
		}

		// Token: 0x0600167F RID: 5759
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern float GetIKPositionWeightInternal(AvatarIKGoal goal);

		/// <summary>
		///   <para>Sets the translative weight of an IK goal (0 = at the original animation before IK, 1 = at the goal).</para>
		/// </summary>
		/// <param name="goal">The AvatarIKGoal that is set.</param>
		/// <param name="value">The translative weight.</param>
		// Token: 0x06001680 RID: 5760 RVA: 0x0000840C File Offset: 0x0000660C
		public void SetIKPositionWeight(AvatarIKGoal goal, float value)
		{
			this.CheckIfInIKPass();
			this.SetIKPositionWeightInternal(goal, value);
		}

		// Token: 0x06001681 RID: 5761
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetIKPositionWeightInternal(AvatarIKGoal goal, float value);

		/// <summary>
		///   <para>Gets the rotational weight of an IK goal (0 = rotation before IK, 1 = rotation at the IK goal).</para>
		/// </summary>
		/// <param name="goal">The AvatarIKGoal that is queried.</param>
		// Token: 0x06001682 RID: 5762 RVA: 0x0000841C File Offset: 0x0000661C
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			this.CheckIfInIKPass();
			return this.GetIKRotationWeightInternal(goal);
		}

		// Token: 0x06001683 RID: 5763
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern float GetIKRotationWeightInternal(AvatarIKGoal goal);

		/// <summary>
		///   <para>Sets the rotational weight of an IK goal (0 = rotation before IK, 1 = rotation at the IK goal).</para>
		/// </summary>
		/// <param name="goal">The AvatarIKGoal that is set.</param>
		/// <param name="value">The rotational weight.</param>
		// Token: 0x06001684 RID: 5764 RVA: 0x0000842B File Offset: 0x0000662B
		public void SetIKRotationWeight(AvatarIKGoal goal, float value)
		{
			this.CheckIfInIKPass();
			this.SetIKRotationWeightInternal(goal, value);
		}

		// Token: 0x06001685 RID: 5765
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetIKRotationWeightInternal(AvatarIKGoal goal, float value);

		/// <summary>
		///   <para>Gets the position of an IK hint.</para>
		/// </summary>
		/// <param name="hint">The AvatarIKHint that is queried.</param>
		/// <returns>
		///   <para>Return the current position of this IK hint in world space.</para>
		/// </returns>
		// Token: 0x06001686 RID: 5766 RVA: 0x0000843B File Offset: 0x0000663B
		public Vector3 GetIKHintPosition(AvatarIKHint hint)
		{
			this.CheckIfInIKPass();
			return this.GetIKHintPositionInternal(hint);
		}

		// Token: 0x06001687 RID: 5767
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Vector3 GetIKHintPositionInternal(AvatarIKHint hint);

		/// <summary>
		///   <para>Sets the position of an IK hint.</para>
		/// </summary>
		/// <param name="hint">The AvatarIKHint that is set.</param>
		/// <param name="hintPosition">The position in world space.</param>
		// Token: 0x06001688 RID: 5768 RVA: 0x0000844A File Offset: 0x0000664A
		public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition)
		{
			this.CheckIfInIKPass();
			this.SetIKHintPositionInternal(hint, hintPosition);
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x0000845A File Offset: 0x0000665A
		internal void SetIKHintPositionInternal(AvatarIKHint hint, Vector3 hintPosition)
		{
			Animator.INTERNAL_CALL_SetIKHintPositionInternal(this, hint, ref hintPosition);
		}

		// Token: 0x0600168A RID: 5770
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetIKHintPositionInternal(Animator self, AvatarIKHint hint, ref Vector3 hintPosition);

		/// <summary>
		///   <para>Gets the translative weight of an IK Hint (0 = at the original animation before IK, 1 = at the hint).</para>
		/// </summary>
		/// <param name="hint">The AvatarIKHint that is queried.</param>
		/// <returns>
		///   <para>Return translative weight.</para>
		/// </returns>
		// Token: 0x0600168B RID: 5771 RVA: 0x00008465 File Offset: 0x00006665
		public float GetIKHintPositionWeight(AvatarIKHint hint)
		{
			this.CheckIfInIKPass();
			return this.GetHintWeightPositionInternal(hint);
		}

		// Token: 0x0600168C RID: 5772
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern float GetHintWeightPositionInternal(AvatarIKHint hint);

		/// <summary>
		///   <para>Sets the translative weight of an IK hint (0 = at the original animation before IK, 1 = at the hint).</para>
		/// </summary>
		/// <param name="hint">The AvatarIKHint that is set.</param>
		/// <param name="value">The translative weight.</param>
		// Token: 0x0600168D RID: 5773 RVA: 0x00008474 File Offset: 0x00006674
		public void SetIKHintPositionWeight(AvatarIKHint hint, float value)
		{
			this.CheckIfInIKPass();
			this.SetIKHintPositionWeightInternal(hint, value);
		}

		// Token: 0x0600168E RID: 5774
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetIKHintPositionWeightInternal(AvatarIKHint hint, float value);

		/// <summary>
		///   <para>Sets the look at position.</para>
		/// </summary>
		/// <param name="lookAtPosition">The position to lookAt.</param>
		// Token: 0x0600168F RID: 5775 RVA: 0x00008484 File Offset: 0x00006684
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
			this.CheckIfInIKPass();
			this.SetLookAtPositionInternal(lookAtPosition);
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x00008493 File Offset: 0x00006693
		internal void SetLookAtPositionInternal(Vector3 lookAtPosition)
		{
			Animator.INTERNAL_CALL_SetLookAtPositionInternal(this, ref lookAtPosition);
		}

		// Token: 0x06001691 RID: 5777
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetLookAtPositionInternal(Animator self, ref Vector3 lookAtPosition);

		/// <summary>
		///   <para>Set look at weights.</para>
		/// </summary>
		/// <param name="weight">(0-1) the global weight of the LookAt, multiplier for other parameters.</param>
		/// <param name="bodyWeight">(0-1) determines how much the body is involved in the LookAt.</param>
		/// <param name="headWeight">(0-1) determines how much the head is involved in the LookAt.</param>
		/// <param name="eyesWeight">(0-1) determines how much the eyes are involved in the LookAt.</param>
		/// <param name="clampWeight">(0-1) 0.0 means the character is completely unrestrained in motion, 1.0 means he's completely clamped (look at becomes impossible), and 0.5 means he'll be able to move on half of the possible range (180 degrees).</param>
		// Token: 0x06001692 RID: 5778 RVA: 0x0001AB44 File Offset: 0x00018D44
		[ExcludeFromDocs]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
			float num = 0.5f;
			this.SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight, num);
		}

		/// <summary>
		///   <para>Set look at weights.</para>
		/// </summary>
		/// <param name="weight">(0-1) the global weight of the LookAt, multiplier for other parameters.</param>
		/// <param name="bodyWeight">(0-1) determines how much the body is involved in the LookAt.</param>
		/// <param name="headWeight">(0-1) determines how much the head is involved in the LookAt.</param>
		/// <param name="eyesWeight">(0-1) determines how much the eyes are involved in the LookAt.</param>
		/// <param name="clampWeight">(0-1) 0.0 means the character is completely unrestrained in motion, 1.0 means he's completely clamped (look at becomes impossible), and 0.5 means he'll be able to move on half of the possible range (180 degrees).</param>
		// Token: 0x06001693 RID: 5779 RVA: 0x0001AB64 File Offset: 0x00018D64
		[ExcludeFromDocs]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
			float num = 0.5f;
			float num2 = 0f;
			this.SetLookAtWeight(weight, bodyWeight, headWeight, num2, num);
		}

		/// <summary>
		///   <para>Set look at weights.</para>
		/// </summary>
		/// <param name="weight">(0-1) the global weight of the LookAt, multiplier for other parameters.</param>
		/// <param name="bodyWeight">(0-1) determines how much the body is involved in the LookAt.</param>
		/// <param name="headWeight">(0-1) determines how much the head is involved in the LookAt.</param>
		/// <param name="eyesWeight">(0-1) determines how much the eyes are involved in the LookAt.</param>
		/// <param name="clampWeight">(0-1) 0.0 means the character is completely unrestrained in motion, 1.0 means he's completely clamped (look at becomes impossible), and 0.5 means he'll be able to move on half of the possible range (180 degrees).</param>
		// Token: 0x06001694 RID: 5780 RVA: 0x0001AB88 File Offset: 0x00018D88
		[ExcludeFromDocs]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
			float num = 0.5f;
			float num2 = 0f;
			float num3 = 1f;
			this.SetLookAtWeight(weight, bodyWeight, num3, num2, num);
		}

		/// <summary>
		///   <para>Set look at weights.</para>
		/// </summary>
		/// <param name="weight">(0-1) the global weight of the LookAt, multiplier for other parameters.</param>
		/// <param name="bodyWeight">(0-1) determines how much the body is involved in the LookAt.</param>
		/// <param name="headWeight">(0-1) determines how much the head is involved in the LookAt.</param>
		/// <param name="eyesWeight">(0-1) determines how much the eyes are involved in the LookAt.</param>
		/// <param name="clampWeight">(0-1) 0.0 means the character is completely unrestrained in motion, 1.0 means he's completely clamped (look at becomes impossible), and 0.5 means he'll be able to move on half of the possible range (180 degrees).</param>
		// Token: 0x06001695 RID: 5781 RVA: 0x0001ABB4 File Offset: 0x00018DB4
		[ExcludeFromDocs]
		public void SetLookAtWeight(float weight)
		{
			float num = 0.5f;
			float num2 = 0f;
			float num3 = 1f;
			float num4 = 0f;
			this.SetLookAtWeight(weight, num4, num3, num2, num);
		}

		/// <summary>
		///   <para>Set look at weights.</para>
		/// </summary>
		/// <param name="weight">(0-1) the global weight of the LookAt, multiplier for other parameters.</param>
		/// <param name="bodyWeight">(0-1) determines how much the body is involved in the LookAt.</param>
		/// <param name="headWeight">(0-1) determines how much the head is involved in the LookAt.</param>
		/// <param name="eyesWeight">(0-1) determines how much the eyes are involved in the LookAt.</param>
		/// <param name="clampWeight">(0-1) 0.0 means the character is completely unrestrained in motion, 1.0 means he's completely clamped (look at becomes impossible), and 0.5 means he'll be able to move on half of the possible range (180 degrees).</param>
		// Token: 0x06001696 RID: 5782 RVA: 0x0000849D File Offset: 0x0000669D
		public void SetLookAtWeight(float weight, [DefaultValue("0.00f")] float bodyWeight, [DefaultValue("1.00f")] float headWeight, [DefaultValue("0.00f")] float eyesWeight, [DefaultValue("0.50f")] float clampWeight)
		{
			this.CheckIfInIKPass();
			this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
		}

		// Token: 0x06001697 RID: 5783
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void SetLookAtWeightInternal(float weight, [DefaultValue("0.00f")] float bodyWeight, [DefaultValue("1.00f")] float headWeight, [DefaultValue("0.00f")] float eyesWeight, [DefaultValue("0.50f")] float clampWeight);

		// Token: 0x06001698 RID: 5784 RVA: 0x0001ABE4 File Offset: 0x00018DE4
		[ExcludeFromDocs]
		internal void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
			float num = 0.5f;
			this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, eyesWeight, num);
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x0001AC04 File Offset: 0x00018E04
		[ExcludeFromDocs]
		internal void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight)
		{
			float num = 0.5f;
			float num2 = 0f;
			this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, num2, num);
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x0001AC28 File Offset: 0x00018E28
		[ExcludeFromDocs]
		internal void SetLookAtWeightInternal(float weight, float bodyWeight)
		{
			float num = 0.5f;
			float num2 = 0f;
			float num3 = 1f;
			this.SetLookAtWeightInternal(weight, bodyWeight, num3, num2, num);
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x0001AC54 File Offset: 0x00018E54
		[ExcludeFromDocs]
		internal void SetLookAtWeightInternal(float weight)
		{
			float num = 0.5f;
			float num2 = 0f;
			float num3 = 1f;
			float num4 = 0f;
			this.SetLookAtWeightInternal(weight, num4, num3, num2, num);
		}

		/// <summary>
		///   <para>Sets local rotation of a human bone during a IK pass.</para>
		/// </summary>
		/// <param name="humanBoneId">The human bone Id.</param>
		/// <param name="rotation">The local rotation.</param>
		// Token: 0x0600169C RID: 5788 RVA: 0x000084B2 File Offset: 0x000066B2
		public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation)
		{
			this.CheckIfInIKPass();
			this.SetBoneLocalRotationInternal(humanBoneId, rotation);
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x000084C2 File Offset: 0x000066C2
		internal void SetBoneLocalRotationInternal(HumanBodyBones humanBoneId, Quaternion rotation)
		{
			Animator.INTERNAL_CALL_SetBoneLocalRotationInternal(this, humanBoneId, ref rotation);
		}

		// Token: 0x0600169E RID: 5790
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetBoneLocalRotationInternal(Animator self, HumanBodyBones humanBoneId, ref Quaternion rotation);

		// Token: 0x0600169F RID: 5791
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern ScriptableObject GetBehaviour(Type type);

		// Token: 0x060016A0 RID: 5792 RVA: 0x000084CD File Offset: 0x000066CD
		public T GetBehaviour<T>() where T : StateMachineBehaviour
		{
			return this.GetBehaviour(typeof(T)) as T;
		}

		// Token: 0x060016A1 RID: 5793
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern ScriptableObject[] GetBehaviours(Type type);

		// Token: 0x060016A2 RID: 5794 RVA: 0x00014610 File Offset: 0x00012810
		internal static T[] ConvertStateMachineBehaviour<T>(ScriptableObject[] rawObjects) where T : StateMachineBehaviour
		{
			if (rawObjects == null)
			{
				return null;
			}
			T[] array = new T[rawObjects.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (T)((object)rawObjects[i]);
			}
			return array;
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x000084E9 File Offset: 0x000066E9
		public T[] GetBehaviours<T>() where T : StateMachineBehaviour
		{
			return Animator.ConvertStateMachineBehaviour<T>(this.GetBehaviours(typeof(T)));
		}

		/// <summary>
		///   <para>Automatic stabilization of feet during transition and blending.</para>
		/// </summary>
		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060016A4 RID: 5796
		// (set) Token: 0x060016A5 RID: 5797
		public extern bool stabilizeFeet
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.layerCount.</para>
		/// </summary>
		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060016A6 RID: 5798
		public extern int layerCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.GetLayerName.</para>
		/// </summary>
		/// <param name="layerIndex"></param>
		// Token: 0x060016A7 RID: 5799
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string GetLayerName(int layerIndex);

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.GetLayerIndex.</para>
		/// </summary>
		/// <param name="layerName"></param>
		// Token: 0x060016A8 RID: 5800
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetLayerIndex(string layerName);

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.GetLayerWeight.</para>
		/// </summary>
		/// <param name="layerIndex"></param>
		// Token: 0x060016A9 RID: 5801
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetLayerWeight(int layerIndex);

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.SetLayerWeight.</para>
		/// </summary>
		/// <param name="layerIndex"></param>
		/// <param name="weight"></param>
		// Token: 0x060016AA RID: 5802
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetLayerWeight(int layerIndex, float weight);

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.GetCurrentAnimatorStateInfo.</para>
		/// </summary>
		/// <param name="layerIndex"></param>
		// Token: 0x060016AB RID: 5803
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.GetNextAnimatorStateInfo.</para>
		/// </summary>
		/// <param name="layerIndex"></param>
		// Token: 0x060016AC RID: 5804
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex);

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.GetAnimatorTransitionInfo.</para>
		/// </summary>
		/// <param name="layerIndex"></param>
		// Token: 0x060016AD RID: 5805
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex);

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.GetCurrentAnimatorClipInfo.</para>
		/// </summary>
		/// <param name="layerIndex"></param>
		// Token: 0x060016AE RID: 5806
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.GetNextAnimatorClipInfo.</para>
		/// </summary>
		/// <param name="layerIndex"></param>
		// Token: 0x060016AF RID: 5807
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex);

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.IsInTransition.</para>
		/// </summary>
		/// <param name="layerIndex"></param>
		// Token: 0x060016B0 RID: 5808
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsInTransition(int layerIndex);

		/// <summary>
		///   <para>Read only acces to the AnimatorControllerParameters used by the animator.</para>
		/// </summary>
		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060016B1 RID: 5809
		public extern AnimatorControllerParameter[] parameters
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.parameterCount.</para>
		/// </summary>
		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060016B2 RID: 5810
		public extern int parameterCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>See AnimatorController.GetParameter.</para>
		/// </summary>
		/// <param name="index"></param>
		// Token: 0x060016B3 RID: 5811 RVA: 0x0001AC84 File Offset: 0x00018E84
		public AnimatorControllerParameter GetParameter(int index)
		{
			AnimatorControllerParameter[] parameters = this.parameters;
			if (index < 0 && index >= this.parameters.Length)
			{
				throw new IndexOutOfRangeException("index");
			}
			return parameters[index];
		}

		/// <summary>
		///   <para>Blends pivot point between body center of mass and feet pivot. At 0%, the blending point is body center of mass. At 100%, the blending point is feet pivot.</para>
		/// </summary>
		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060016B4 RID: 5812
		// (set) Token: 0x060016B5 RID: 5813
		public extern float feetPivotActive
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Gets the pivot weight.</para>
		/// </summary>
		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060016B6 RID: 5814
		public extern float pivotWeight
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Get the current position of the pivot.</para>
		/// </summary>
		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060016B7 RID: 5815 RVA: 0x0001ACBC File Offset: 0x00018EBC
		public Vector3 pivotPosition
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_pivotPosition(out vector);
				return vector;
			}
		}

		// Token: 0x060016B8 RID: 5816
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_pivotPosition(out Vector3 value);

		/// <summary>
		///   <para>Automatically adjust the gameobject position and rotation so that the AvatarTarget reaches the matchPosition when the current state is at the specified progress.</para>
		/// </summary>
		/// <param name="matchPosition">The position we want the body part to reach.</param>
		/// <param name="matchRotation">The rotation in which we want the body part to be.</param>
		/// <param name="targetBodyPart">The body part that is involved in the match.</param>
		/// <param name="weightMask">Structure that contains weights for matching position and rotation.</param>
		/// <param name="startNormalizedTime">Start time within the animation clip (0 - beginning of clip, 1 - end of clip).</param>
		/// <param name="targetNormalizedTime">End time within the animation clip (0 - beginning of clip, 1 - end of clip), values greater than 1 can be set to trigger a match after a certain number of loops. Ex: 2.3 means at 30% of 2nd loop.</param>
		// Token: 0x060016B9 RID: 5817 RVA: 0x00008500 File Offset: 0x00006700
		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, [DefaultValue("1")] float targetNormalizedTime)
		{
			Animator.INTERNAL_CALL_MatchTarget(this, ref matchPosition, ref matchRotation, targetBodyPart, ref weightMask, startNormalizedTime, targetNormalizedTime);
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x0001ACD4 File Offset: 0x00018ED4
		[ExcludeFromDocs]
		public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime)
		{
			float num = 1f;
			Animator.INTERNAL_CALL_MatchTarget(this, ref matchPosition, ref matchRotation, targetBodyPart, ref weightMask, startNormalizedTime, num);
		}

		// Token: 0x060016BB RID: 5819
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_MatchTarget(Animator self, ref Vector3 matchPosition, ref Quaternion matchRotation, AvatarTarget targetBodyPart, ref MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime);

		/// <summary>
		///   <para>Interrupts the automatic target matching.</para>
		/// </summary>
		/// <param name="completeMatch"></param>
		// Token: 0x060016BC RID: 5820
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InterruptMatchTarget([DefaultValue("true")] bool completeMatch);

		// Token: 0x060016BD RID: 5821 RVA: 0x0001ACF8 File Offset: 0x00018EF8
		[ExcludeFromDocs]
		public void InterruptMatchTarget()
		{
			bool flag = true;
			this.InterruptMatchTarget(flag);
		}

		/// <summary>
		///   <para>If automatic matching is active.</para>
		/// </summary>
		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060016BE RID: 5822
		public extern bool isMatchingTarget
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The playback speed of the Animator. 1 is normal playback speed.</para>
		/// </summary>
		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060016BF RID: 5823
		// (set) Token: 0x060016C0 RID: 5824
		public extern float speed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00008513 File Offset: 0x00006713
		[Obsolete("ForceStateNormalizedTime is deprecated. Please use Play or CrossFade instead.")]
		public void ForceStateNormalizedTime(float normalizedTime)
		{
			this.Play(0, 0, normalizedTime);
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x0001AD10 File Offset: 0x00018F10
		[ExcludeFromDocs]
		public void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer)
		{
			float num = 0f;
			this.CrossFadeInFixedTime(stateName, transitionDuration, layer, num);
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x0001AD30 File Offset: 0x00018F30
		[ExcludeFromDocs]
		public void CrossFadeInFixedTime(string stateName, float transitionDuration)
		{
			float num = 0f;
			int num2 = -1;
			this.CrossFadeInFixedTime(stateName, transitionDuration, num2, num);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.CrossFadeInFixedTime.</para>
		/// </summary>
		/// <param name="stateName"></param>
		/// <param name="transitionDuration"></param>
		/// <param name="layer"></param>
		/// <param name="fixedTime"></param>
		/// <param name="stateNameHash"></param>
		// Token: 0x060016C4 RID: 5828 RVA: 0x0000851E File Offset: 0x0000671E
		public void CrossFadeInFixedTime(string stateName, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float fixedTime)
		{
			this.CrossFadeInFixedTime(Animator.StringToHash(stateName), transitionDuration, layer, fixedTime);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.CrossFadeInFixedTime.</para>
		/// </summary>
		/// <param name="stateName"></param>
		/// <param name="transitionDuration"></param>
		/// <param name="layer"></param>
		/// <param name="fixedTime"></param>
		/// <param name="stateNameHash"></param>
		// Token: 0x060016C5 RID: 5829
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float fixedTime);

		// Token: 0x060016C6 RID: 5830 RVA: 0x0001AD50 File Offset: 0x00018F50
		[ExcludeFromDocs]
		public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer)
		{
			float num = 0f;
			this.CrossFadeInFixedTime(stateNameHash, transitionDuration, layer, num);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x0001AD70 File Offset: 0x00018F70
		[ExcludeFromDocs]
		public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration)
		{
			float num = 0f;
			int num2 = -1;
			this.CrossFadeInFixedTime(stateNameHash, transitionDuration, num2, num);
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x0001AD90 File Offset: 0x00018F90
		[ExcludeFromDocs]
		public void CrossFade(string stateName, float transitionDuration, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.CrossFade(stateName, transitionDuration, layer, negativeInfinity);
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x0001ADB0 File Offset: 0x00018FB0
		[ExcludeFromDocs]
		public void CrossFade(string stateName, float transitionDuration)
		{
			float negativeInfinity = float.NegativeInfinity;
			int num = -1;
			this.CrossFade(stateName, transitionDuration, num, negativeInfinity);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.CrossFade.</para>
		/// </summary>
		/// <param name="stateName"></param>
		/// <param name="transitionDuration"></param>
		/// <param name="layer"></param>
		/// <param name="normalizedTime"></param>
		/// <param name="stateNameHash"></param>
		// Token: 0x060016CA RID: 5834 RVA: 0x00008530 File Offset: 0x00006730
		public void CrossFade(string stateName, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
			this.CrossFade(Animator.StringToHash(stateName), transitionDuration, layer, normalizedTime);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.CrossFade.</para>
		/// </summary>
		/// <param name="stateName"></param>
		/// <param name="transitionDuration"></param>
		/// <param name="layer"></param>
		/// <param name="normalizedTime"></param>
		/// <param name="stateNameHash"></param>
		// Token: 0x060016CB RID: 5835
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void CrossFade(int stateNameHash, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime);

		// Token: 0x060016CC RID: 5836 RVA: 0x0001ADD0 File Offset: 0x00018FD0
		[ExcludeFromDocs]
		public void CrossFade(int stateNameHash, float transitionDuration, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.CrossFade(stateNameHash, transitionDuration, layer, negativeInfinity);
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x0001ADF0 File Offset: 0x00018FF0
		[ExcludeFromDocs]
		public void CrossFade(int stateNameHash, float transitionDuration)
		{
			float negativeInfinity = float.NegativeInfinity;
			int num = -1;
			this.CrossFade(stateNameHash, transitionDuration, num, negativeInfinity);
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x0001AE10 File Offset: 0x00019010
		[ExcludeFromDocs]
		public void PlayInFixedTime(string stateName, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.PlayInFixedTime(stateName, layer, negativeInfinity);
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x0001AE2C File Offset: 0x0001902C
		[ExcludeFromDocs]
		public void PlayInFixedTime(string stateName)
		{
			float negativeInfinity = float.NegativeInfinity;
			int num = -1;
			this.PlayInFixedTime(stateName, num, negativeInfinity);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.PlayInFixedTime.</para>
		/// </summary>
		/// <param name="stateName"></param>
		/// <param name="layer"></param>
		/// <param name="fixedTime"></param>
		/// <param name="stateNameHash"></param>
		// Token: 0x060016D0 RID: 5840 RVA: 0x00008542 File Offset: 0x00006742
		public void PlayInFixedTime(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime)
		{
			this.PlayInFixedTime(Animator.StringToHash(stateName), layer, fixedTime);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.PlayInFixedTime.</para>
		/// </summary>
		/// <param name="stateName"></param>
		/// <param name="layer"></param>
		/// <param name="fixedTime"></param>
		/// <param name="stateNameHash"></param>
		// Token: 0x060016D1 RID: 5841
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void PlayInFixedTime(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime);

		// Token: 0x060016D2 RID: 5842 RVA: 0x0001AE4C File Offset: 0x0001904C
		[ExcludeFromDocs]
		public void PlayInFixedTime(int stateNameHash, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.PlayInFixedTime(stateNameHash, layer, negativeInfinity);
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x0001AE68 File Offset: 0x00019068
		[ExcludeFromDocs]
		public void PlayInFixedTime(int stateNameHash)
		{
			float negativeInfinity = float.NegativeInfinity;
			int num = -1;
			this.PlayInFixedTime(stateNameHash, num, negativeInfinity);
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x0001AE88 File Offset: 0x00019088
		[ExcludeFromDocs]
		public void Play(string stateName, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.Play(stateName, layer, negativeInfinity);
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x0001AEA4 File Offset: 0x000190A4
		[ExcludeFromDocs]
		public void Play(string stateName)
		{
			float negativeInfinity = float.NegativeInfinity;
			int num = -1;
			this.Play(stateName, num, negativeInfinity);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.Play.</para>
		/// </summary>
		/// <param name="stateName"></param>
		/// <param name="layer"></param>
		/// <param name="normalizedTime"></param>
		/// <param name="stateNameHash"></param>
		// Token: 0x060016D6 RID: 5846 RVA: 0x00008552 File Offset: 0x00006752
		public void Play(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
			this.Play(Animator.StringToHash(stateName), layer, normalizedTime);
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.Play.</para>
		/// </summary>
		/// <param name="stateName"></param>
		/// <param name="layer"></param>
		/// <param name="normalizedTime"></param>
		/// <param name="stateNameHash"></param>
		// Token: 0x060016D7 RID: 5847
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Play(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime);

		// Token: 0x060016D8 RID: 5848 RVA: 0x0001AEC4 File Offset: 0x000190C4
		[ExcludeFromDocs]
		public void Play(int stateNameHash, int layer)
		{
			float negativeInfinity = float.NegativeInfinity;
			this.Play(stateNameHash, layer, negativeInfinity);
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x0001AEE0 File Offset: 0x000190E0
		[ExcludeFromDocs]
		public void Play(int stateNameHash)
		{
			float negativeInfinity = float.NegativeInfinity;
			int num = -1;
			this.Play(stateNameHash, num, negativeInfinity);
		}

		/// <summary>
		///   <para>Sets an AvatarTarget and a targetNormalizedTime for the current state.</para>
		/// </summary>
		/// <param name="targetIndex">The avatar body part that is queried.</param>
		/// <param name="targetNormalizedTime">The current state Time that is queried.</param>
		// Token: 0x060016DA RID: 5850
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime);

		/// <summary>
		///   <para>Returns the position of the target specified by SetTarget(AvatarTarget targetIndex, float targetNormalizedTime)).</para>
		/// </summary>
		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x0001AF00 File Offset: 0x00019100
		public Vector3 targetPosition
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_targetPosition(out vector);
				return vector;
			}
		}

		// Token: 0x060016DC RID: 5852
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_targetPosition(out Vector3 value);

		/// <summary>
		///   <para>Returns the rotation of the target specified by SetTarget(AvatarTarget targetIndex, float targetNormalizedTime)).</para>
		/// </summary>
		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x0001AF18 File Offset: 0x00019118
		public Quaternion targetRotation
		{
			get
			{
				Quaternion quaternion;
				this.INTERNAL_get_targetRotation(out quaternion);
				return quaternion;
			}
		}

		// Token: 0x060016DE RID: 5854
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_targetRotation(out Quaternion value);

		/// <summary>
		///   <para>Returns true if the transform is controlled by the Animator\.</para>
		/// </summary>
		/// <param name="transform">The transform that is queried.</param>
		// Token: 0x060016DF RID: 5855
		[Obsolete("use mask and layers to control subset of transfroms in a skeleton", true)]
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsControlled(Transform transform);

		// Token: 0x060016E0 RID: 5856
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern bool IsBoneTransform(Transform transform);

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x060016E1 RID: 5857
		internal extern Transform avatarRoot
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns transform mapped to this human bone id.</para>
		/// </summary>
		/// <param name="humanBoneId">The human bone that is queried, see enum HumanBodyBones for a list of possible values.</param>
		// Token: 0x060016E2 RID: 5858
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Transform GetBoneTransform(HumanBodyBones humanBoneId);

		/// <summary>
		///   <para>Controls culling of this Animator component.</para>
		/// </summary>
		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060016E3 RID: 5859
		// (set) Token: 0x060016E4 RID: 5860
		public extern AnimatorCullingMode cullingMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Sets the animator in playback mode.</para>
		/// </summary>
		// Token: 0x060016E5 RID: 5861
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void StartPlayback();

		/// <summary>
		///   <para>Stops the animator playback mode. When playback stops, the avatar resumes getting control from game logic.</para>
		/// </summary>
		// Token: 0x060016E6 RID: 5862
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void StopPlayback();

		/// <summary>
		///   <para>Sets the playback position in the recording buffer.</para>
		/// </summary>
		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060016E7 RID: 5863
		// (set) Token: 0x060016E8 RID: 5864
		public extern float playbackTime
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Sets the animator in recording mode, and allocates a circular buffer of size frameCount.</para>
		/// </summary>
		/// <param name="frameCount">The number of frames (updates) that will be recorded. If frameCount is 0, the recording will continue until the user calls StopRecording. The maximum value for frameCount is 10000.</param>
		// Token: 0x060016E9 RID: 5865
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void StartRecording(int frameCount);

		/// <summary>
		///   <para>Stops animator record mode.</para>
		/// </summary>
		// Token: 0x060016EA RID: 5866
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void StopRecording();

		/// <summary>
		///   <para>Start time of the first frame of the buffer relative to the frame at which StartRecording was called.</para>
		/// </summary>
		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060016EB RID: 5867
		// (set) Token: 0x060016EC RID: 5868
		public extern float recorderStartTime
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>End time of the recorded clip relative to when StartRecording was called.</para>
		/// </summary>
		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060016ED RID: 5869
		// (set) Token: 0x060016EE RID: 5870
		public extern float recorderStopTime
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Gets the mode of the Animator recorder.</para>
		/// </summary>
		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060016EF RID: 5871
		public extern AnimatorRecorderMode recorderMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The runtime representation of AnimatorController that controls the Animator.</para>
		/// </summary>
		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x060016F0 RID: 5872
		// (set) Token: 0x060016F1 RID: 5873
		public extern RuntimeAnimatorController runtimeAnimatorController
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>See IAnimatorControllerPlayable.HasState.</para>
		/// </summary>
		/// <param name="layerIndex"></param>
		/// <param name="stateID"></param>
		// Token: 0x060016F2 RID: 5874
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool HasState(int layerIndex, int stateID);

		/// <summary>
		///   <para>Generates an parameter id from a string.</para>
		/// </summary>
		/// <param name="name">The string to convert to Id.</param>
		// Token: 0x060016F3 RID: 5875
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int StringToHash(string name);

		/// <summary>
		///   <para>Gets/Sets the current Avatar.</para>
		/// </summary>
		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x060016F4 RID: 5876
		// (set) Token: 0x060016F5 RID: 5877
		public extern Avatar avatar
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x060016F6 RID: 5878
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern string GetStats();

		// Token: 0x060016F7 RID: 5879 RVA: 0x00008562 File Offset: 0x00006762
		private void CheckIfInIKPass()
		{
			if (this.logWarnings && !this.CheckIfInIKPassInternal())
			{
				Debug.LogWarning("Setting and getting IK Goals, Lookat and BoneLocalRotation should only be done in OnAnimatorIK or OnStateIK");
			}
		}

		// Token: 0x060016F8 RID: 5880
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool CheckIfInIKPassInternal();

		// Token: 0x060016F9 RID: 5881
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetFloatString(string name, float value);

		// Token: 0x060016FA RID: 5882
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetFloatID(int id, float value);

		// Token: 0x060016FB RID: 5883
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern float GetFloatString(string name);

		// Token: 0x060016FC RID: 5884
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern float GetFloatID(int id);

		// Token: 0x060016FD RID: 5885
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetBoolString(string name, bool value);

		// Token: 0x060016FE RID: 5886
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetBoolID(int id, bool value);

		// Token: 0x060016FF RID: 5887
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool GetBoolString(string name);

		// Token: 0x06001700 RID: 5888
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool GetBoolID(int id);

		// Token: 0x06001701 RID: 5889
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetIntegerString(string name, int value);

		// Token: 0x06001702 RID: 5890
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetIntegerID(int id, int value);

		// Token: 0x06001703 RID: 5891
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int GetIntegerString(string name);

		// Token: 0x06001704 RID: 5892
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int GetIntegerID(int id);

		// Token: 0x06001705 RID: 5893
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetTriggerString(string name);

		// Token: 0x06001706 RID: 5894
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetTriggerID(int id);

		// Token: 0x06001707 RID: 5895
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void ResetTriggerString(string name);

		// Token: 0x06001708 RID: 5896
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void ResetTriggerID(int id);

		// Token: 0x06001709 RID: 5897
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool IsParameterControlledByCurveString(string name);

		// Token: 0x0600170A RID: 5898
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool IsParameterControlledByCurveID(int id);

		// Token: 0x0600170B RID: 5899
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime);

		// Token: 0x0600170C RID: 5900
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime);

		/// <summary>
		///   <para>Additional layers affects the center of mass.</para>
		/// </summary>
		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x0600170D RID: 5901
		// (set) Token: 0x0600170E RID: 5902
		public extern bool layersAffectMassCenter
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Get left foot bottom height.</para>
		/// </summary>
		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x0600170F RID: 5903
		public extern float leftFeetBottomHeight
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Get right foot bottom height.</para>
		/// </summary>
		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001710 RID: 5904
		public extern float rightFeetBottomHeight
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Evaluates the animator based on deltaTime.</para>
		/// </summary>
		/// <param name="deltaTime">The time delta.</param>
		// Token: 0x06001711 RID: 5905
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Update(float deltaTime);

		/// <summary>
		///   <para>Rebind all the animated properties and mesh data with the Animator.</para>
		/// </summary>
		// Token: 0x06001712 RID: 5906
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Rebind();

		/// <summary>
		///   <para>Apply the default Root Motion.</para>
		/// </summary>
		// Token: 0x06001713 RID: 5907
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ApplyBuiltinRootMotion();

		// Token: 0x06001714 RID: 5908
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern string ResolveHash(int hash);

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001715 RID: 5909
		// (set) Token: 0x06001716 RID: 5910
		public extern bool logWarnings
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001717 RID: 5911
		// (set) Token: 0x06001718 RID: 5912
		public extern bool fireEvents
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Gets the value of a vector parameter.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		// Token: 0x06001719 RID: 5913 RVA: 0x00005F24 File Offset: 0x00004124
		[Obsolete("GetVector is deprecated.")]
		public Vector3 GetVector(string name)
		{
			return Vector3.zero;
		}

		/// <summary>
		///   <para>Gets the value of a vector parameter.</para>
		/// </summary>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x0600171A RID: 5914 RVA: 0x00005F24 File Offset: 0x00004124
		[Obsolete("GetVector is deprecated.")]
		public Vector3 GetVector(int id)
		{
			return Vector3.zero;
		}

		/// <summary>
		///   <para>Sets the value of a vector parameter.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="value">The new value for the parameter.</param>
		// Token: 0x0600171B RID: 5915 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("SetVector is deprecated.")]
		public void SetVector(string name, Vector3 value)
		{
		}

		/// <summary>
		///   <para>Sets the value of a vector parameter.</para>
		/// </summary>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		/// <param name="value">The new value for the parameter.</param>
		// Token: 0x0600171C RID: 5916 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("SetVector is deprecated.")]
		public void SetVector(int id, Vector3 value)
		{
		}

		/// <summary>
		///   <para>Gets the value of a quaternion parameter.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		// Token: 0x0600171D RID: 5917 RVA: 0x00005F1D File Offset: 0x0000411D
		[Obsolete("GetQuaternion is deprecated.")]
		public Quaternion GetQuaternion(string name)
		{
			return Quaternion.identity;
		}

		/// <summary>
		///   <para>Gets the value of a quaternion parameter.</para>
		/// </summary>
		/// <param name="id">The id of the parameter. The id is generated using Animator::StringToHash.</param>
		// Token: 0x0600171E RID: 5918 RVA: 0x00005F1D File Offset: 0x0000411D
		[Obsolete("GetQuaternion is deprecated.")]
		public Quaternion GetQuaternion(int id)
		{
			return Quaternion.identity;
		}

		/// <summary>
		///   <para>Sets the value of a quaternion parameter.</para>
		/// </summary>
		/// <param name="name">The name of the parameter.</param>
		/// <param name="value">The new value for the parameter.</param>
		// Token: 0x0600171F RID: 5919 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("SetQuaternion is deprecated.")]
		public void SetQuaternion(string name, Quaternion value)
		{
		}

		/// <summary>
		///   <para>Sets the value of a quaternion parameter.</para>
		/// </summary>
		/// <param name="id">Of the parameter. The id is generated using Animator::StringToHash.</param>
		/// <param name="value">The new value for the parameter.</param>
		// Token: 0x06001720 RID: 5920 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("SetQuaternion is deprecated.")]
		public void SetQuaternion(int id, Quaternion value)
		{
		}
	}
}
