using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Class that holds humanoid avatar parameters to pass to the AvatarBuilder.BuildHumanAvatar function.</para>
	/// </summary>
	// Token: 0x0200018F RID: 399
	public struct HumanDescription
	{
		/// <summary>
		///   <para>Defines how the lower arm's roll/twisting is distributed between the shoulder and elbow joints.</para>
		/// </summary>
		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x00008686 File Offset: 0x00006886
		// (set) Token: 0x06001740 RID: 5952 RVA: 0x0000868E File Offset: 0x0000688E
		public float upperArmTwist
		{
			get
			{
				return this.m_ArmTwist;
			}
			set
			{
				this.m_ArmTwist = value;
			}
		}

		/// <summary>
		///   <para>Defines how the lower arm's roll/twisting is distributed between the elbow and wrist joints.</para>
		/// </summary>
		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x00008697 File Offset: 0x00006897
		// (set) Token: 0x06001742 RID: 5954 RVA: 0x0000869F File Offset: 0x0000689F
		public float lowerArmTwist
		{
			get
			{
				return this.m_ForeArmTwist;
			}
			set
			{
				this.m_ForeArmTwist = value;
			}
		}

		/// <summary>
		///   <para>Defines how the upper leg's roll/twisting is distributed between the thigh and knee joints.</para>
		/// </summary>
		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x000086A8 File Offset: 0x000068A8
		// (set) Token: 0x06001744 RID: 5956 RVA: 0x000086B0 File Offset: 0x000068B0
		public float upperLegTwist
		{
			get
			{
				return this.m_UpperLegTwist;
			}
			set
			{
				this.m_UpperLegTwist = value;
			}
		}

		/// <summary>
		///   <para>Defines how the lower leg's roll/twisting is distributed between the knee and ankle.</para>
		/// </summary>
		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x000086B9 File Offset: 0x000068B9
		// (set) Token: 0x06001746 RID: 5958 RVA: 0x000086C1 File Offset: 0x000068C1
		public float lowerLegTwist
		{
			get
			{
				return this.m_LegTwist;
			}
			set
			{
				this.m_LegTwist = value;
			}
		}

		/// <summary>
		///   <para>Amount by which the arm's length is allowed to stretch when using IK.</para>
		/// </summary>
		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001747 RID: 5959 RVA: 0x000086CA File Offset: 0x000068CA
		// (set) Token: 0x06001748 RID: 5960 RVA: 0x000086D2 File Offset: 0x000068D2
		public float armStretch
		{
			get
			{
				return this.m_ArmStretch;
			}
			set
			{
				this.m_ArmStretch = value;
			}
		}

		/// <summary>
		///   <para>Amount by which the leg's length is allowed to stretch when using IK.</para>
		/// </summary>
		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x000086DB File Offset: 0x000068DB
		// (set) Token: 0x0600174A RID: 5962 RVA: 0x000086E3 File Offset: 0x000068E3
		public float legStretch
		{
			get
			{
				return this.m_LegStretch;
			}
			set
			{
				this.m_LegStretch = value;
			}
		}

		/// <summary>
		///   <para>Modification to the minimum distance between the feet of a humanoid model.</para>
		/// </summary>
		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x000086EC File Offset: 0x000068EC
		// (set) Token: 0x0600174C RID: 5964 RVA: 0x000086F4 File Offset: 0x000068F4
		public float feetSpacing
		{
			get
			{
				return this.m_FeetSpacing;
			}
			set
			{
				this.m_FeetSpacing = value;
			}
		}

		/// <summary>
		///   <para>True for any human that has a translation Degree of Freedom (DoF). It is set to false by default.</para>
		/// </summary>
		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x0600174D RID: 5965 RVA: 0x000086FD File Offset: 0x000068FD
		// (set) Token: 0x0600174E RID: 5966 RVA: 0x00008705 File Offset: 0x00006905
		public bool hasTranslationDoF
		{
			get
			{
				return this.m_HasTranslationDoF;
			}
			set
			{
				this.m_HasTranslationDoF = value;
			}
		}

		/// <summary>
		///   <para>Mapping between Mecanim bone names and bone names in the rig.</para>
		/// </summary>
		// Token: 0x04000473 RID: 1139
		public HumanBone[] human;

		/// <summary>
		///   <para>List of bone Transforms to include in the model.</para>
		/// </summary>
		// Token: 0x04000474 RID: 1140
		public SkeletonBone[] skeleton;

		// Token: 0x04000475 RID: 1141
		internal float m_ArmTwist;

		// Token: 0x04000476 RID: 1142
		internal float m_ForeArmTwist;

		// Token: 0x04000477 RID: 1143
		internal float m_UpperLegTwist;

		// Token: 0x04000478 RID: 1144
		internal float m_LegTwist;

		// Token: 0x04000479 RID: 1145
		internal float m_ArmStretch;

		// Token: 0x0400047A RID: 1146
		internal float m_LegStretch;

		// Token: 0x0400047B RID: 1147
		internal float m_FeetSpacing;

		// Token: 0x0400047C RID: 1148
		private bool m_HasTranslationDoF;
	}
}
