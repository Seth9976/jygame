using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The limits defined by the CharacterJoint.</para>
	/// </summary>
	// Token: 0x020000F4 RID: 244
	public struct SoftJointLimit
	{
		/// <summary>
		///   <para>The limit position/angle of the joint (in degrees).</para>
		/// </summary>
		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00006C01 File Offset: 0x00004E01
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x00006C09 File Offset: 0x00004E09
		public float limit
		{
			get
			{
				return this.m_Limit;
			}
			set
			{
				this.m_Limit = value;
			}
		}

		/// <summary>
		///   <para>If greater than zero, the limit is soft. The spring will pull the joint back.</para>
		/// </summary>
		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00006170 File Offset: 0x00004370
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("Spring has been moved to SoftJointLimitSpring class in Unity 5", true)]
		public float spring
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		/// <summary>
		///   <para>If spring is greater than zero, the limit is soft.</para>
		/// </summary>
		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x00006170 File Offset: 0x00004370
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("Damper has been moved to SoftJointLimitSpring class in Unity 5", true)]
		public float damper
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		/// <summary>
		///   <para>When the joint hits the limit, it can be made to bounce off it.</para>
		/// </summary>
		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00006C12 File Offset: 0x00004E12
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x00006C1A File Offset: 0x00004E1A
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
		///   <para>Determines how far ahead in space the solver can "see" the joint limit.</para>
		/// </summary>
		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x00006C23 File Offset: 0x00004E23
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x00006C2B File Offset: 0x00004E2B
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

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x00006C12 File Offset: 0x00004E12
		// (set) Token: 0x06000E53 RID: 3667 RVA: 0x00006C1A File Offset: 0x00004E1A
		[Obsolete("Use SoftJointLimit.bounciness instead", true)]
		public float bouncyness
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

		// Token: 0x040002CB RID: 715
		private float m_Limit;

		// Token: 0x040002CC RID: 716
		private float m_Bounciness;

		// Token: 0x040002CD RID: 717
		private float m_ContactDistance;
	}
}
