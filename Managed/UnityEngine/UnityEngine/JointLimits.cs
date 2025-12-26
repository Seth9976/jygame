using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>JointLimits is used by the HingeJoint to limit the joints angle.</para>
	/// </summary>
	// Token: 0x020000FA RID: 250
	public struct JointLimits
	{
		/// <summary>
		///   <para>The lower angular limit (in degrees) of the joint.</para>
		/// </summary>
		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x00006CDC File Offset: 0x00004EDC
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x00006CE4 File Offset: 0x00004EE4
		public float min
		{
			get
			{
				return this.m_Min;
			}
			set
			{
				this.m_Min = value;
			}
		}

		/// <summary>
		///   <para>The upper angular limit (in degrees) of the joint.</para>
		/// </summary>
		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00006CED File Offset: 0x00004EED
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x00006CF5 File Offset: 0x00004EF5
		public float max
		{
			get
			{
				return this.m_Max;
			}
			set
			{
				this.m_Max = value;
			}
		}

		/// <summary>
		///   <para>Determines the size of the bounce when the joint hits it's limit. Also known as restitution.</para>
		/// </summary>
		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x00006CFE File Offset: 0x00004EFE
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x00006D06 File Offset: 0x00004F06
		public float bounciness
		{
			get
			{
				return this.m_Bounciness;
			}
			set
			{
				this.m_Bounciness = value;
			}
		}

		/// <summary>
		///   <para>The minimum impact velocity which will cause the joint to bounce.</para>
		/// </summary>
		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00006D0F File Offset: 0x00004F0F
		// (set) Token: 0x06000E6D RID: 3693 RVA: 0x00006D17 File Offset: 0x00004F17
		public float bounceMinVelocity
		{
			get
			{
				return this.m_BounceMinVelocity;
			}
			set
			{
				this.m_BounceMinVelocity = value;
			}
		}

		/// <summary>
		///   <para>Distance inside the limit value at which the limit will be considered to be active by the solver.</para>
		/// </summary>
		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x00006D20 File Offset: 0x00004F20
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x00006D28 File Offset: 0x00004F28
		public float contactDistance
		{
			get
			{
				return this.m_ContactDistance;
			}
			set
			{
				this.m_ContactDistance = value;
			}
		}

		// Token: 0x040002DE RID: 734
		private float m_Min;

		// Token: 0x040002DF RID: 735
		private float m_Max;

		// Token: 0x040002E0 RID: 736
		private float m_Bounciness;

		// Token: 0x040002E1 RID: 737
		private float m_BounceMinVelocity;

		// Token: 0x040002E2 RID: 738
		private float m_ContactDistance;

		// Token: 0x040002E3 RID: 739
		[Obsolete("minBounce and maxBounce are replaced by a single JointLimits.bounciness for both limit ends.", true)]
		public float minBounce;

		// Token: 0x040002E4 RID: 740
		[Obsolete("minBounce and maxBounce are replaced by a single JointLimits.bounciness for both limit ends.", true)]
		public float maxBounce;
	}
}
