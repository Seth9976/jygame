using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>How the joint's movement will behave along its local X axis.</para>
	/// </summary>
	// Token: 0x020000F6 RID: 246
	public struct JointDrive
	{
		/// <summary>
		///   <para>Whether the drive should attempt to reach position, velocity, both or nothing.</para>
		/// </summary>
		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00006C56 File Offset: 0x00004E56
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x00006C5E File Offset: 0x00004E5E
		public JointDriveMode mode
		{
			get
			{
				return (JointDriveMode)this.m_Mode;
			}
			set
			{
				this.m_Mode = (int)value;
			}
		}

		/// <summary>
		///   <para>Strength of a rubber-band pull toward the defined direction. Only used if mode includes Position.</para>
		/// </summary>
		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x00006C67 File Offset: 0x00004E67
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x00006C6F File Offset: 0x00004E6F
		public float positionSpring
		{
			get
			{
				return this.m_PositionSpring;
			}
			set
			{
				this.m_PositionSpring = value;
			}
		}

		/// <summary>
		///   <para>Resistance strength against the Position Spring. Only used if mode includes Position.</para>
		/// </summary>
		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x00006C78 File Offset: 0x00004E78
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x00006C80 File Offset: 0x00004E80
		public float positionDamper
		{
			get
			{
				return this.m_PositionDamper;
			}
			set
			{
				this.m_PositionDamper = value;
			}
		}

		/// <summary>
		///   <para>Amount of force applied to push the object toward the defined direction.</para>
		/// </summary>
		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00006C89 File Offset: 0x00004E89
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x00006C91 File Offset: 0x00004E91
		public float maximumForce
		{
			get
			{
				return this.m_MaximumForce;
			}
			set
			{
				this.m_MaximumForce = value;
			}
		}

		// Token: 0x040002D0 RID: 720
		private int m_Mode;

		// Token: 0x040002D1 RID: 721
		private float m_PositionSpring;

		// Token: 0x040002D2 RID: 722
		private float m_PositionDamper;

		// Token: 0x040002D3 RID: 723
		private float m_MaximumForce;
	}
}
