using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Motion limits of a Rigidbody2D object along a SliderJoint2D.</para>
	/// </summary>
	// Token: 0x0200012C RID: 300
	public struct JointTranslationLimits2D
	{
		/// <summary>
		///   <para>Minimum distance the Rigidbody2D object can move from the Slider Joint's anchor.</para>
		/// </summary>
		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001286 RID: 4742 RVA: 0x0000790B File Offset: 0x00005B0B
		// (set) Token: 0x06001287 RID: 4743 RVA: 0x00007913 File Offset: 0x00005B13
		public float min
		{
			get
			{
				return this.m_LowerTranslation;
			}
			set
			{
				this.m_LowerTranslation = value;
			}
		}

		/// <summary>
		///   <para>Maximum distance the Rigidbody2D object can move from the Slider Joint's anchor.</para>
		/// </summary>
		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x0000791C File Offset: 0x00005B1C
		// (set) Token: 0x06001289 RID: 4745 RVA: 0x00007924 File Offset: 0x00005B24
		public float max
		{
			get
			{
				return this.m_UpperTranslation;
			}
			set
			{
				this.m_UpperTranslation = value;
			}
		}

		// Token: 0x04000360 RID: 864
		private float m_LowerTranslation;

		// Token: 0x04000361 RID: 865
		private float m_UpperTranslation;
	}
}
