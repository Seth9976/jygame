using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>To specify position and rotation weight mask for Animator::MatchTarget.</para>
	/// </summary>
	// Token: 0x02000188 RID: 392
	public struct MatchTargetWeightMask
	{
		/// <summary>
		///   <para>MatchTargetWeightMask contructor.</para>
		/// </summary>
		/// <param name="positionXYZWeight">Position XYZ weight.</param>
		/// <param name="rotationWeight">Rotation weight.</param>
		// Token: 0x06001630 RID: 5680 RVA: 0x00008265 File Offset: 0x00006465
		public MatchTargetWeightMask(Vector3 positionXYZWeight, float rotationWeight)
		{
			this.m_PositionXYZWeight = positionXYZWeight;
			this.m_RotationWeight = rotationWeight;
		}

		/// <summary>
		///   <para>Position XYZ weight.</para>
		/// </summary>
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x00008275 File Offset: 0x00006475
		// (set) Token: 0x06001632 RID: 5682 RVA: 0x0000827D File Offset: 0x0000647D
		public Vector3 positionXYZWeight
		{
			get
			{
				return this.m_PositionXYZWeight;
			}
			set
			{
				this.m_PositionXYZWeight = value;
			}
		}

		/// <summary>
		///   <para>Rotation weight.</para>
		/// </summary>
		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x00008286 File Offset: 0x00006486
		// (set) Token: 0x06001634 RID: 5684 RVA: 0x0000828E File Offset: 0x0000648E
		public float rotationWeight
		{
			get
			{
				return this.m_RotationWeight;
			}
			set
			{
				this.m_RotationWeight = value;
			}
		}

		// Token: 0x0400045F RID: 1119
		private Vector3 m_PositionXYZWeight;

		// Token: 0x04000460 RID: 1120
		private float m_RotationWeight;
	}
}
