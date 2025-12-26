using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Result information for NavMesh queries.</para>
	/// </summary>
	// Token: 0x02000142 RID: 322
	public struct NavMeshHit
	{
		/// <summary>
		///   <para>Position of hit.</para>
		/// </summary>
		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x00007AEA File Offset: 0x00005CEA
		// (set) Token: 0x060013A1 RID: 5025 RVA: 0x00007AF2 File Offset: 0x00005CF2
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
		///   <para>Normal at the point of hit.</para>
		/// </summary>
		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x00007AFB File Offset: 0x00005CFB
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x00007B03 File Offset: 0x00005D03
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
		///   <para>Distance to the point of hit.</para>
		/// </summary>
		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x00007B0C File Offset: 0x00005D0C
		// (set) Token: 0x060013A5 RID: 5029 RVA: 0x00007B14 File Offset: 0x00005D14
		public float distance
		{
			get
			{
				return this.m_Distance;
			}
			set
			{
				this.m_Distance = value;
			}
		}

		/// <summary>
		///   <para>Mask specifying NavMesh area at point of hit.</para>
		/// </summary>
		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x00007B1D File Offset: 0x00005D1D
		// (set) Token: 0x060013A7 RID: 5031 RVA: 0x00007B25 File Offset: 0x00005D25
		public int mask
		{
			get
			{
				return this.m_Mask;
			}
			set
			{
				this.m_Mask = value;
			}
		}

		/// <summary>
		///   <para>Flag set when hit.</para>
		/// </summary>
		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x00007B2E File Offset: 0x00005D2E
		// (set) Token: 0x060013A9 RID: 5033 RVA: 0x00007B3C File Offset: 0x00005D3C
		public bool hit
		{
			get
			{
				return this.m_Hit != 0;
			}
			set
			{
				this.m_Hit = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x04000374 RID: 884
		private Vector3 m_Position;

		// Token: 0x04000375 RID: 885
		private Vector3 m_Normal;

		// Token: 0x04000376 RID: 886
		private float m_Distance;

		// Token: 0x04000377 RID: 887
		private int m_Mask;

		// Token: 0x04000378 RID: 888
		private int m_Hit;
	}
}
