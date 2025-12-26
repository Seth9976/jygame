using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Skinning bone weights of a vertex in the mesh.</para>
	/// </summary>
	// Token: 0x02000020 RID: 32
	public struct BoneWeight
	{
		/// <summary>
		///   <para>Skinning weight for first bone.</para>
		/// </summary>
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00002394 File Offset: 0x00000594
		// (set) Token: 0x0600015F RID: 351 RVA: 0x0000239C File Offset: 0x0000059C
		public float weight0
		{
			get
			{
				return this.m_Weight0;
			}
			set
			{
				this.m_Weight0 = value;
			}
		}

		/// <summary>
		///   <para>Skinning weight for second bone.</para>
		/// </summary>
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000023A5 File Offset: 0x000005A5
		// (set) Token: 0x06000161 RID: 353 RVA: 0x000023AD File Offset: 0x000005AD
		public float weight1
		{
			get
			{
				return this.m_Weight1;
			}
			set
			{
				this.m_Weight1 = value;
			}
		}

		/// <summary>
		///   <para>Skinning weight for third bone.</para>
		/// </summary>
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000162 RID: 354 RVA: 0x000023B6 File Offset: 0x000005B6
		// (set) Token: 0x06000163 RID: 355 RVA: 0x000023BE File Offset: 0x000005BE
		public float weight2
		{
			get
			{
				return this.m_Weight2;
			}
			set
			{
				this.m_Weight2 = value;
			}
		}

		/// <summary>
		///   <para>Skinning weight for fourth bone.</para>
		/// </summary>
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000164 RID: 356 RVA: 0x000023C7 File Offset: 0x000005C7
		// (set) Token: 0x06000165 RID: 357 RVA: 0x000023CF File Offset: 0x000005CF
		public float weight3
		{
			get
			{
				return this.m_Weight3;
			}
			set
			{
				this.m_Weight3 = value;
			}
		}

		/// <summary>
		///   <para>Index of first bone.</para>
		/// </summary>
		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000166 RID: 358 RVA: 0x000023D8 File Offset: 0x000005D8
		// (set) Token: 0x06000167 RID: 359 RVA: 0x000023E0 File Offset: 0x000005E0
		public int boneIndex0
		{
			get
			{
				return this.m_BoneIndex0;
			}
			set
			{
				this.m_BoneIndex0 = value;
			}
		}

		/// <summary>
		///   <para>Index of second bone.</para>
		/// </summary>
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000168 RID: 360 RVA: 0x000023E9 File Offset: 0x000005E9
		// (set) Token: 0x06000169 RID: 361 RVA: 0x000023F1 File Offset: 0x000005F1
		public int boneIndex1
		{
			get
			{
				return this.m_BoneIndex1;
			}
			set
			{
				this.m_BoneIndex1 = value;
			}
		}

		/// <summary>
		///   <para>Index of third bone.</para>
		/// </summary>
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000023FA File Offset: 0x000005FA
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00002402 File Offset: 0x00000602
		public int boneIndex2
		{
			get
			{
				return this.m_BoneIndex2;
			}
			set
			{
				this.m_BoneIndex2 = value;
			}
		}

		/// <summary>
		///   <para>Index of fourth bone.</para>
		/// </summary>
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0000240B File Offset: 0x0000060B
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00002413 File Offset: 0x00000613
		public int boneIndex3
		{
			get
			{
				return this.m_BoneIndex3;
			}
			set
			{
				this.m_BoneIndex3 = value;
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000F130 File Offset: 0x0000D330
		public override int GetHashCode()
		{
			return this.boneIndex0.GetHashCode() ^ (this.boneIndex1.GetHashCode() << 2) ^ (this.boneIndex2.GetHashCode() >> 2) ^ (this.boneIndex3.GetHashCode() >> 1) ^ (this.weight0.GetHashCode() << 5) ^ (this.weight1.GetHashCode() << 4) ^ (this.weight2.GetHashCode() >> 4) ^ (this.weight3.GetHashCode() >> 3);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000F1C8 File Offset: 0x0000D3C8
		public override bool Equals(object other)
		{
			if (!(other is BoneWeight))
			{
				return false;
			}
			BoneWeight boneWeight = (BoneWeight)other;
			bool flag;
			if (this.boneIndex0.Equals(boneWeight.boneIndex0) && this.boneIndex1.Equals(boneWeight.boneIndex1) && this.boneIndex2.Equals(boneWeight.boneIndex2) && this.boneIndex3.Equals(boneWeight.boneIndex3))
			{
				Vector4 vector = new Vector4(this.weight0, this.weight1, this.weight2, this.weight3);
				flag = vector.Equals(new Vector4(boneWeight.weight0, boneWeight.weight1, boneWeight.weight2, boneWeight.weight3));
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000F2A4 File Offset: 0x0000D4A4
		public static bool operator ==(BoneWeight lhs, BoneWeight rhs)
		{
			return lhs.boneIndex0 == rhs.boneIndex0 && lhs.boneIndex1 == rhs.boneIndex1 && lhs.boneIndex2 == rhs.boneIndex2 && lhs.boneIndex3 == rhs.boneIndex3 && new Vector4(lhs.weight0, lhs.weight1, lhs.weight2, lhs.weight3) == new Vector4(rhs.weight0, rhs.weight1, rhs.weight2, rhs.weight3);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000241C File Offset: 0x0000061C
		public static bool operator !=(BoneWeight lhs, BoneWeight rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x0400007D RID: 125
		private float m_Weight0;

		// Token: 0x0400007E RID: 126
		private float m_Weight1;

		// Token: 0x0400007F RID: 127
		private float m_Weight2;

		// Token: 0x04000080 RID: 128
		private float m_Weight3;

		// Token: 0x04000081 RID: 129
		private int m_BoneIndex0;

		// Token: 0x04000082 RID: 130
		private int m_BoneIndex1;

		// Token: 0x04000083 RID: 131
		private int m_BoneIndex2;

		// Token: 0x04000084 RID: 132
		private int m_BoneIndex3;
	}
}
