using System;

namespace UnityEngine.Networking
{
	// Token: 0x0200004A RID: 74
	[Serializable]
	public struct NetworkSceneId
	{
		// Token: 0x0600033A RID: 826 RVA: 0x00010108 File Offset: 0x0000E308
		public NetworkSceneId(uint value)
		{
			this.m_Value = value;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00010114 File Offset: 0x0000E314
		public bool IsEmpty()
		{
			return this.m_Value == 0U;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00010120 File Offset: 0x0000E320
		public override int GetHashCode()
		{
			return (int)this.m_Value;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00010128 File Offset: 0x0000E328
		public override bool Equals(object obj)
		{
			return obj is NetworkSceneId && this == (NetworkSceneId)obj;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0001014C File Offset: 0x0000E34C
		public override string ToString()
		{
			return this.m_Value.ToString();
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600033F RID: 831 RVA: 0x0001015C File Offset: 0x0000E35C
		public uint Value
		{
			get
			{
				return this.m_Value;
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00010164 File Offset: 0x0000E364
		public static bool operator ==(NetworkSceneId c1, NetworkSceneId c2)
		{
			return c1.m_Value == c2.m_Value;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00010178 File Offset: 0x0000E378
		public static bool operator !=(NetworkSceneId c1, NetworkSceneId c2)
		{
			return c1.m_Value != c2.m_Value;
		}

		// Token: 0x04000169 RID: 361
		[SerializeField]
		private uint m_Value;
	}
}
