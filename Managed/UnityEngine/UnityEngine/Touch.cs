using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Structure describing the status of a finger touching the screen.</para>
	/// </summary>
	// Token: 0x020000BC RID: 188
	public struct Touch
	{
		/// <summary>
		///   <para>The unique index for the touch.</para>
		/// </summary>
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x00005D61 File Offset: 0x00003F61
		public int fingerId
		{
			get
			{
				return this.m_FingerId;
			}
		}

		/// <summary>
		///   <para>The position of the touch in pixel coordinates.</para>
		/// </summary>
		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x00005D69 File Offset: 0x00003F69
		public Vector2 position
		{
			get
			{
				return this.m_Position;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x00005D71 File Offset: 0x00003F71
		public Vector2 rawPosition
		{
			get
			{
				return this.m_RawPosition;
			}
		}

		/// <summary>
		///   <para>The position delta since last change.</para>
		/// </summary>
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00005D79 File Offset: 0x00003F79
		public Vector2 deltaPosition
		{
			get
			{
				return this.m_PositionDelta;
			}
		}

		/// <summary>
		///   <para>Amount of time that has passed since the last recorded change in Touch values.</para>
		/// </summary>
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x00005D81 File Offset: 0x00003F81
		public float deltaTime
		{
			get
			{
				return this.m_TimeDelta;
			}
		}

		/// <summary>
		///   <para>Number of taps.</para>
		/// </summary>
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x00005D89 File Offset: 0x00003F89
		public int tapCount
		{
			get
			{
				return this.m_TapCount;
			}
		}

		/// <summary>
		///   <para>Describes the phase of the touch.</para>
		/// </summary>
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x00005D91 File Offset: 0x00003F91
		public TouchPhase phase
		{
			get
			{
				return this.m_Phase;
			}
		}

		/// <summary>
		///   <para>The current amount of pressure being applied to a touch.  1.0f is considered to be the pressure of an average touch.  If Input.touchPressureSupported returns false, the value of this property will always be 1.0f.</para>
		/// </summary>
		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00005D99 File Offset: 0x00003F99
		public float pressure
		{
			get
			{
				return this.m_Pressure;
			}
		}

		/// <summary>
		///   <para>The maximum possible pressure value for a platform.  If Input.touchPressureSupported returns false, the value of this property will always be 1.0f.</para>
		/// </summary>
		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x00005DA1 File Offset: 0x00003FA1
		public float maximumPossiblePressure
		{
			get
			{
				return this.m_maximumPossiblePressure;
			}
		}

		/// <summary>
		///   <para>A value that indicates whether a touch was of Direct, Indirect (or remote), or Stylus type.</para>
		/// </summary>
		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x00005DA9 File Offset: 0x00003FA9
		public TouchType type
		{
			get
			{
				return this.m_Type;
			}
		}

		/// <summary>
		///   <para>Value of 0 radians indicates that the stylus is parallel to the surface, pi/2 indicates that it is perpendicular.</para>
		/// </summary>
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00005DB1 File Offset: 0x00003FB1
		public float altitudeAngle
		{
			get
			{
				return this.m_AltitudeAngle;
			}
		}

		/// <summary>
		///   <para>Value of 0 radians indicates that the stylus is pointed along the x-axis of the device.</para>
		/// </summary>
		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x00005DB9 File Offset: 0x00003FB9
		public float azimuthAngle
		{
			get
			{
				return this.m_AzimuthAngle;
			}
		}

		/// <summary>
		///   <para>An estimated value of the radius of a touch.  Add radiusVariance to get the maximum touch size, subtract it to get the minimum touch size.</para>
		/// </summary>
		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x00005DC1 File Offset: 0x00003FC1
		public float radius
		{
			get
			{
				return this.m_Radius;
			}
		}

		/// <summary>
		///   <para>The amount that the radius varies by for a touch.</para>
		/// </summary>
		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00005DC9 File Offset: 0x00003FC9
		public float radiusVariance
		{
			get
			{
				return this.m_RadiusVariance;
			}
		}

		// Token: 0x04000229 RID: 553
		private int m_FingerId;

		// Token: 0x0400022A RID: 554
		private Vector2 m_Position;

		// Token: 0x0400022B RID: 555
		private Vector2 m_RawPosition;

		// Token: 0x0400022C RID: 556
		private Vector2 m_PositionDelta;

		// Token: 0x0400022D RID: 557
		private float m_TimeDelta;

		// Token: 0x0400022E RID: 558
		private int m_TapCount;

		// Token: 0x0400022F RID: 559
		private TouchPhase m_Phase;

		// Token: 0x04000230 RID: 560
		private TouchType m_Type;

		// Token: 0x04000231 RID: 561
		private float m_Pressure;

		// Token: 0x04000232 RID: 562
		private float m_maximumPossiblePressure;

		// Token: 0x04000233 RID: 563
		private float m_Radius;

		// Token: 0x04000234 RID: 564
		private float m_RadiusVariance;

		// Token: 0x04000235 RID: 565
		private float m_AltitudeAngle;

		// Token: 0x04000236 RID: 566
		private float m_AzimuthAngle;
	}
}
