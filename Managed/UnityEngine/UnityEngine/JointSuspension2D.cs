using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Joint suspension is used to define how suspension works on a WheelJoint2D.</para>
	/// </summary>
	// Token: 0x0200012E RID: 302
	public struct JointSuspension2D
	{
		/// <summary>
		///   <para>The amount by which the suspension spring force is reduced in proportion to the movement speed.</para>
		/// </summary>
		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x0600128E RID: 4750 RVA: 0x0000794F File Offset: 0x00005B4F
		// (set) Token: 0x0600128F RID: 4751 RVA: 0x00007957 File Offset: 0x00005B57
		public float dampingRatio
		{
			get
			{
				return this.m_DampingRatio;
			}
			set
			{
				this.m_DampingRatio = value;
			}
		}

		/// <summary>
		///   <para>The frequency at which the suspension spring oscillates.</para>
		/// </summary>
		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001290 RID: 4752 RVA: 0x00007960 File Offset: 0x00005B60
		// (set) Token: 0x06001291 RID: 4753 RVA: 0x00007968 File Offset: 0x00005B68
		public float frequency
		{
			get
			{
				return this.m_Frequency;
			}
			set
			{
				this.m_Frequency = value;
			}
		}

		/// <summary>
		///   <para>The world angle (in degrees) along which the suspension will move.</para>
		/// </summary>
		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x00007971 File Offset: 0x00005B71
		// (set) Token: 0x06001293 RID: 4755 RVA: 0x00007979 File Offset: 0x00005B79
		public float angle
		{
			get
			{
				return this.m_Angle;
			}
			set
			{
				this.m_Angle = value;
			}
		}

		// Token: 0x04000364 RID: 868
		private float m_DampingRatio;

		// Token: 0x04000365 RID: 869
		private float m_Frequency;

		// Token: 0x04000366 RID: 870
		private float m_Angle;
	}
}
