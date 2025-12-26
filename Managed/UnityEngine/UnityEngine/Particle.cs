using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>(Legacy Particle system).</para>
	/// </summary>
	// Token: 0x020000E7 RID: 231
	public struct Particle
	{
		/// <summary>
		///   <para>The position of the particle.</para>
		/// </summary>
		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x00006A89 File Offset: 0x00004C89
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x00006A91 File Offset: 0x00004C91
		public Vector3 position
		{
			get
			{
				return this.m_Position;
			}
			set
			{
				this.m_Position = value;
			}
		}

		/// <summary>
		///   <para>The velocity of the particle.</para>
		/// </summary>
		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x00006A9A File Offset: 0x00004C9A
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x00006AA2 File Offset: 0x00004CA2
		public Vector3 velocity
		{
			get
			{
				return this.m_Velocity;
			}
			set
			{
				this.m_Velocity = value;
			}
		}

		/// <summary>
		///   <para>The energy of the particle.</para>
		/// </summary>
		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x00006AAB File Offset: 0x00004CAB
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x00006AB3 File Offset: 0x00004CB3
		public float energy
		{
			get
			{
				return this.m_Energy;
			}
			set
			{
				this.m_Energy = value;
			}
		}

		/// <summary>
		///   <para>The starting energy of the particle.</para>
		/// </summary>
		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x00006ABC File Offset: 0x00004CBC
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x00006AC4 File Offset: 0x00004CC4
		public float startEnergy
		{
			get
			{
				return this.m_StartEnergy;
			}
			set
			{
				this.m_StartEnergy = value;
			}
		}

		/// <summary>
		///   <para>The size of the particle.</para>
		/// </summary>
		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x00006ACD File Offset: 0x00004CCD
		// (set) Token: 0x06000DCA RID: 3530 RVA: 0x00006AD5 File Offset: 0x00004CD5
		public float size
		{
			get
			{
				return this.m_Size;
			}
			set
			{
				this.m_Size = value;
			}
		}

		/// <summary>
		///   <para>The rotation of the particle.</para>
		/// </summary>
		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x00006ADE File Offset: 0x00004CDE
		// (set) Token: 0x06000DCC RID: 3532 RVA: 0x00006AE6 File Offset: 0x00004CE6
		public float rotation
		{
			get
			{
				return this.m_Rotation;
			}
			set
			{
				this.m_Rotation = value;
			}
		}

		/// <summary>
		///   <para>The angular velocity of the particle.</para>
		/// </summary>
		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x00006AEF File Offset: 0x00004CEF
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x00006AF7 File Offset: 0x00004CF7
		public float angularVelocity
		{
			get
			{
				return this.m_AngularVelocity;
			}
			set
			{
				this.m_AngularVelocity = value;
			}
		}

		/// <summary>
		///   <para>The color of the particle.</para>
		/// </summary>
		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x00006B00 File Offset: 0x00004D00
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x00006B08 File Offset: 0x00004D08
		public Color color
		{
			get
			{
				return this.m_Color;
			}
			set
			{
				this.m_Color = value;
			}
		}

		// Token: 0x04000298 RID: 664
		private Vector3 m_Position;

		// Token: 0x04000299 RID: 665
		private Vector3 m_Velocity;

		// Token: 0x0400029A RID: 666
		private float m_Size;

		// Token: 0x0400029B RID: 667
		private float m_Rotation;

		// Token: 0x0400029C RID: 668
		private float m_AngularVelocity;

		// Token: 0x0400029D RID: 669
		private float m_Energy;

		// Token: 0x0400029E RID: 670
		private float m_StartEnergy;

		// Token: 0x0400029F RID: 671
		private Color m_Color;
	}
}
