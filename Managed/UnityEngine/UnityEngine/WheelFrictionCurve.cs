using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>WheelFrictionCurve is used by the WheelCollider to describe friction properties of the wheel tire.</para>
	/// </summary>
	// Token: 0x020000F3 RID: 243
	public struct WheelFrictionCurve
	{
		/// <summary>
		///   <para>Extremum point slip (default 1).</para>
		/// </summary>
		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00006BAC File Offset: 0x00004DAC
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x00006BB4 File Offset: 0x00004DB4
		public float extremumSlip
		{
			get
			{
				return this.m_ExtremumSlip;
			}
			set
			{
				this.m_ExtremumSlip = value;
			}
		}

		/// <summary>
		///   <para>Force at the extremum slip (default 20000).</para>
		/// </summary>
		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x00006BBD File Offset: 0x00004DBD
		// (set) Token: 0x06000E41 RID: 3649 RVA: 0x00006BC5 File Offset: 0x00004DC5
		public float extremumValue
		{
			get
			{
				return this.m_ExtremumValue;
			}
			set
			{
				this.m_ExtremumValue = value;
			}
		}

		/// <summary>
		///   <para>Asymptote point slip (default 2).</para>
		/// </summary>
		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00006BCE File Offset: 0x00004DCE
		// (set) Token: 0x06000E43 RID: 3651 RVA: 0x00006BD6 File Offset: 0x00004DD6
		public float asymptoteSlip
		{
			get
			{
				return this.m_AsymptoteSlip;
			}
			set
			{
				this.m_AsymptoteSlip = value;
			}
		}

		/// <summary>
		///   <para>Force at the asymptote slip (default 10000).</para>
		/// </summary>
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x00006BDF File Offset: 0x00004DDF
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x00006BE7 File Offset: 0x00004DE7
		public float asymptoteValue
		{
			get
			{
				return this.m_AsymptoteValue;
			}
			set
			{
				this.m_AsymptoteValue = value;
			}
		}

		/// <summary>
		///   <para>Multiplier for the extremumValue and asymptoteValue values (default 1).</para>
		/// </summary>
		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x00006BF0 File Offset: 0x00004DF0
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x00006BF8 File Offset: 0x00004DF8
		public float stiffness
		{
			get
			{
				return this.m_Stiffness;
			}
			set
			{
				this.m_Stiffness = value;
			}
		}

		// Token: 0x040002C6 RID: 710
		private float m_ExtremumSlip;

		// Token: 0x040002C7 RID: 711
		private float m_ExtremumValue;

		// Token: 0x040002C8 RID: 712
		private float m_AsymptoteSlip;

		// Token: 0x040002C9 RID: 713
		private float m_AsymptoteValue;

		// Token: 0x040002CA RID: 714
		private float m_Stiffness;
	}
}
