using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Contact information for the wheel, reported by WheelCollider.</para>
	/// </summary>
	// Token: 0x02000102 RID: 258
	public struct WheelHit
	{
		/// <summary>
		///   <para>The other Collider the wheel is hitting.</para>
		/// </summary>
		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x00006FDF File Offset: 0x000051DF
		// (set) Token: 0x06000EFB RID: 3835 RVA: 0x00006FE7 File Offset: 0x000051E7
		public Collider collider
		{
			get
			{
				return this.m_Collider;
			}
			set
			{
				this.m_Collider = value;
			}
		}

		/// <summary>
		///   <para>The point of contact between the wheel and the ground.</para>
		/// </summary>
		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x00006FF0 File Offset: 0x000051F0
		// (set) Token: 0x06000EFD RID: 3837 RVA: 0x00006FF8 File Offset: 0x000051F8
		public Vector3 point
		{
			get
			{
				return this.m_Point;
			}
			set
			{
				this.m_Point = value;
			}
		}

		/// <summary>
		///   <para>The normal at the point of contact.</para>
		/// </summary>
		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x00007001 File Offset: 0x00005201
		// (set) Token: 0x06000EFF RID: 3839 RVA: 0x00007009 File Offset: 0x00005209
		public Vector3 normal
		{
			get
			{
				return this.m_Normal;
			}
			set
			{
				this.m_Normal = value;
			}
		}

		/// <summary>
		///   <para>The direction the wheel is pointing in.</para>
		/// </summary>
		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00007012 File Offset: 0x00005212
		// (set) Token: 0x06000F01 RID: 3841 RVA: 0x0000701A File Offset: 0x0000521A
		public Vector3 forwardDir
		{
			get
			{
				return this.m_ForwardDir;
			}
			set
			{
				this.m_ForwardDir = value;
			}
		}

		/// <summary>
		///   <para>The sideways direction of the wheel.</para>
		/// </summary>
		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x00007023 File Offset: 0x00005223
		// (set) Token: 0x06000F03 RID: 3843 RVA: 0x0000702B File Offset: 0x0000522B
		public Vector3 sidewaysDir
		{
			get
			{
				return this.m_SidewaysDir;
			}
			set
			{
				this.m_SidewaysDir = value;
			}
		}

		/// <summary>
		///   <para>The magnitude of the force being applied for the contact.</para>
		/// </summary>
		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x00007034 File Offset: 0x00005234
		// (set) Token: 0x06000F05 RID: 3845 RVA: 0x0000703C File Offset: 0x0000523C
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
		///   <para>Tire slip in the rolling direction. Acceleration slip is negative, braking slip is positive.</para>
		/// </summary>
		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x00007045 File Offset: 0x00005245
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x0000704D File Offset: 0x0000524D
		public float forwardSlip
		{
			get
			{
				return this.m_ForwardSlip;
			}
			set
			{
				this.m_Force = this.m_ForwardSlip;
			}
		}

		/// <summary>
		///   <para>Tire slip in the sideways direction.</para>
		/// </summary>
		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x0000705B File Offset: 0x0000525B
		// (set) Token: 0x06000F09 RID: 3849 RVA: 0x00007063 File Offset: 0x00005263
		public float sidewaysSlip
		{
			get
			{
				return this.m_SidewaysSlip;
			}
			set
			{
				this.m_SidewaysSlip = value;
			}
		}

		// Token: 0x0400030A RID: 778
		private Vector3 m_Point;

		// Token: 0x0400030B RID: 779
		private Vector3 m_Normal;

		// Token: 0x0400030C RID: 780
		private Vector3 m_ForwardDir;

		// Token: 0x0400030D RID: 781
		private Vector3 m_SidewaysDir;

		// Token: 0x0400030E RID: 782
		private float m_Force;

		// Token: 0x0400030F RID: 783
		private float m_ForwardSlip;

		// Token: 0x04000310 RID: 784
		private float m_SidewaysSlip;

		// Token: 0x04000311 RID: 785
		private Collider m_Collider;
	}
}
