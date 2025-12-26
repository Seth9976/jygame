using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Represents a display resolution.</para>
	/// </summary>
	// Token: 0x0200025E RID: 606
	public struct Resolution
	{
		/// <summary>
		///   <para>Resolution width in pixels.</para>
		/// </summary>
		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x0000CD85 File Offset: 0x0000AF85
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x0000CD8D File Offset: 0x0000AF8D
		public int width
		{
			get
			{
				return this.m_Width;
			}
			set
			{
				this.m_Width = value;
			}
		}

		/// <summary>
		///   <para>Resolution height in pixels.</para>
		/// </summary>
		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x0000CD96 File Offset: 0x0000AF96
		// (set) Token: 0x06002090 RID: 8336 RVA: 0x0000CD9E File Offset: 0x0000AF9E
		public int height
		{
			get
			{
				return this.m_Height;
			}
			set
			{
				this.m_Height = value;
			}
		}

		/// <summary>
		///   <para>Resolution's vertical refresh rate in Hz.</para>
		/// </summary>
		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x0000CDA7 File Offset: 0x0000AFA7
		// (set) Token: 0x06002092 RID: 8338 RVA: 0x0000CDAF File Offset: 0x0000AFAF
		public int refreshRate
		{
			get
			{
				return this.m_RefreshRate;
			}
			set
			{
				this.m_RefreshRate = value;
			}
		}

		/// <summary>
		///   <para>Returns a nicely formatted string of the resolution.</para>
		/// </summary>
		/// <returns>
		///   <para>A string with the format "width x height @ refreshRateHz".</para>
		/// </returns>
		// Token: 0x06002093 RID: 8339 RVA: 0x0000CDB8 File Offset: 0x0000AFB8
		public override string ToString()
		{
			return UnityString.Format("{0} x {1} @ {2}Hz", new object[] { this.m_Width, this.m_Height, this.m_RefreshRate });
		}

		// Token: 0x040008DE RID: 2270
		private int m_Width;

		// Token: 0x040008DF RID: 2271
		private int m_Height;

		// Token: 0x040008E0 RID: 2272
		private int m_RefreshRate;
	}
}
