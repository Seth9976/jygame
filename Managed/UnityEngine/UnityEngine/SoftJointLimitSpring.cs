using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The configuration of the spring attached to the joint's limits: linear and angular. Used by CharacterJoint and ConfigurableJoint.</para>
	/// </summary>
	// Token: 0x020000F5 RID: 245
	public struct SoftJointLimitSpring
	{
		/// <summary>
		///   <para>The stiffness of the spring limit. When stiffness is zero the limit is hard, otherwise soft.</para>
		/// </summary>
		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x00006C34 File Offset: 0x00004E34
		// (set) Token: 0x06000E55 RID: 3669 RVA: 0x00006C3C File Offset: 0x00004E3C
		public float spring
		{
			get
			{
				return this.m_Spring;
			}
			set
			{
				this.m_Spring = value;
			}
		}

		/// <summary>
		///   <para>The damping of the spring limit. In effect when the stiffness of the sprint limit is not zero.</para>
		/// </summary>
		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00006C45 File Offset: 0x00004E45
		// (set) Token: 0x06000E57 RID: 3671 RVA: 0x00006C4D File Offset: 0x00004E4D
		public float damper
		{
			get
			{
				return this.m_Damper;
			}
			set
			{
				this.m_Damper = value;
			}
		}

		// Token: 0x040002CE RID: 718
		private float m_Spring;

		// Token: 0x040002CF RID: 719
		private float m_Damper;
	}
}
