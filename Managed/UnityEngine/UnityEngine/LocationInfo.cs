using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Structure describing device location.</para>
	/// </summary>
	// Token: 0x020000C0 RID: 192
	public struct LocationInfo
	{
		/// <summary>
		///   <para>Geographical device location latitude.</para>
		/// </summary>
		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00005E67 File Offset: 0x00004067
		public float latitude
		{
			get
			{
				return this.m_Latitude;
			}
		}

		/// <summary>
		///   <para>Geographical device location latitude.</para>
		/// </summary>
		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x00005E6F File Offset: 0x0000406F
		public float longitude
		{
			get
			{
				return this.m_Longitude;
			}
		}

		/// <summary>
		///   <para>Geographical device location altitude.</para>
		/// </summary>
		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00005E77 File Offset: 0x00004077
		public float altitude
		{
			get
			{
				return this.m_Altitude;
			}
		}

		/// <summary>
		///   <para>Horizontal accuracy of the location.</para>
		/// </summary>
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x00005E7F File Offset: 0x0000407F
		public float horizontalAccuracy
		{
			get
			{
				return this.m_HorizontalAccuracy;
			}
		}

		/// <summary>
		///   <para>Vertical accuracy of the location.</para>
		/// </summary>
		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x00005E87 File Offset: 0x00004087
		public float verticalAccuracy
		{
			get
			{
				return this.m_VerticalAccuracy;
			}
		}

		/// <summary>
		///   <para>Timestamp (in seconds since 1970) when location was last time updated.</para>
		/// </summary>
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x00005E8F File Offset: 0x0000408F
		public double timestamp
		{
			get
			{
				return this.m_Timestamp;
			}
		}

		// Token: 0x04000242 RID: 578
		private double m_Timestamp;

		// Token: 0x04000243 RID: 579
		private float m_Latitude;

		// Token: 0x04000244 RID: 580
		private float m_Longitude;

		// Token: 0x04000245 RID: 581
		private float m_Altitude;

		// Token: 0x04000246 RID: 582
		private float m_HorizontalAccuracy;

		// Token: 0x04000247 RID: 583
		private float m_VerticalAccuracy;
	}
}
