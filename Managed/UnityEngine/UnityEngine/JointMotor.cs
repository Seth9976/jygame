using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The JointMotor is used to motorize a joint.</para>
	/// </summary>
	// Token: 0x020000F8 RID: 248
	public struct JointMotor
	{
		/// <summary>
		///   <para>The motor will apply a force up to force to achieve targetVelocity.</para>
		/// </summary>
		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x00006C9A File Offset: 0x00004E9A
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x00006CA2 File Offset: 0x00004EA2
		public float targetVelocity
		{
			get
			{
				return this.m_TargetVelocity;
			}
			set
			{
				this.m_TargetVelocity = value;
			}
		}

		/// <summary>
		///   <para>The motor will apply a force.</para>
		/// </summary>
		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x00006CAB File Offset: 0x00004EAB
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x00006CB3 File Offset: 0x00004EB3
		public float force
		{
			get
			{
				return this.m_Force;
			}
			set
			{
				this.m_Force = value;
			}
		}

		/// <summary>
		///   <para>If freeSpin is enabled the motor will only accelerate but never slow down.</para>
		/// </summary>
		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x00006CBC File Offset: 0x00004EBC
		// (set) Token: 0x06000E65 RID: 3685 RVA: 0x00006CC7 File Offset: 0x00004EC7
		public bool freeSpin
		{
			get
			{
				return this.m_FreeSpin == 1;
			}
			set
			{
				this.m_FreeSpin = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x040002D8 RID: 728
		private float m_TargetVelocity;

		// Token: 0x040002D9 RID: 729
		private float m_Force;

		// Token: 0x040002DA RID: 730
		private int m_FreeSpin;
	}
}
