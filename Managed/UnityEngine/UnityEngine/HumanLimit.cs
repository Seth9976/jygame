using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>This class stores the rotation limits that define the muscle for a single human bone.</para>
	/// </summary>
	// Token: 0x0200018D RID: 397
	public struct HumanLimit
	{
		/// <summary>
		///   <para>Should this limit use the default values?</para>
		/// </summary>
		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001731 RID: 5937 RVA: 0x000085FD File Offset: 0x000067FD
		// (set) Token: 0x06001732 RID: 5938 RVA: 0x0000860B File Offset: 0x0000680B
		public bool useDefaultValues
		{
			get
			{
				return this.m_UseDefaultValues != 0;
			}
			set
			{
				this.m_UseDefaultValues = ((!value) ? 0 : 1);
			}
		}

		/// <summary>
		///   <para>The maximum negative rotation away from the initial value that this muscle can apply.</para>
		/// </summary>
		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x00008620 File Offset: 0x00006820
		// (set) Token: 0x06001734 RID: 5940 RVA: 0x00008628 File Offset: 0x00006828
		public Vector3 min
		{
			get
			{
				return this.m_Min;
			}
			set
			{
				this.m_Min = value;
			}
		}

		/// <summary>
		///   <para>The maximum rotation away from the initial value that this muscle can apply.</para>
		/// </summary>
		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001735 RID: 5941 RVA: 0x00008631 File Offset: 0x00006831
		// (set) Token: 0x06001736 RID: 5942 RVA: 0x00008639 File Offset: 0x00006839
		public Vector3 max
		{
			get
			{
				return this.m_Max;
			}
			set
			{
				this.m_Max = value;
			}
		}

		/// <summary>
		///   <para>The default orientation of a bone when no muscle action is applied.</para>
		/// </summary>
		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x00008642 File Offset: 0x00006842
		// (set) Token: 0x06001738 RID: 5944 RVA: 0x0000864A File Offset: 0x0000684A
		public Vector3 center
		{
			get
			{
				return this.m_Center;
			}
			set
			{
				this.m_Center = value;
			}
		}

		/// <summary>
		///   <para>Length of the bone to which the limit is applied.</para>
		/// </summary>
		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x00008653 File Offset: 0x00006853
		// (set) Token: 0x0600173A RID: 5946 RVA: 0x0000865B File Offset: 0x0000685B
		public float axisLength
		{
			get
			{
				return this.m_AxisLength;
			}
			set
			{
				this.m_AxisLength = value;
			}
		}

		// Token: 0x0400046B RID: 1131
		private Vector3 m_Min;

		// Token: 0x0400046C RID: 1132
		private Vector3 m_Max;

		// Token: 0x0400046D RID: 1133
		private Vector3 m_Center;

		// Token: 0x0400046E RID: 1134
		private float m_AxisLength;

		// Token: 0x0400046F RID: 1135
		private int m_UseDefaultValues;
	}
}
