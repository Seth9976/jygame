using System;

namespace UnityEngine.Networking
{
	// Token: 0x0200003E RID: 62
	[Serializable]
	public struct NetworkInstanceId
	{
		// Token: 0x06000210 RID: 528 RVA: 0x0000B1D4 File Offset: 0x000093D4
		public NetworkInstanceId(uint value)
		{
			this.m_Value = value;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000B1F8 File Offset: 0x000093F8
		public bool IsEmpty()
		{
			return this.m_Value == 0U;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000B204 File Offset: 0x00009404
		public override int GetHashCode()
		{
			return (int)this.m_Value;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000B20C File Offset: 0x0000940C
		public override bool Equals(object obj)
		{
			return obj is NetworkInstanceId && this == (NetworkInstanceId)obj;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000B230 File Offset: 0x00009430
		public override string ToString()
		{
			return this.m_Value.ToString();
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0000B24C File Offset: 0x0000944C
		public uint Value
		{
			get
			{
				return this.m_Value;
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000B254 File Offset: 0x00009454
		public static bool operator ==(NetworkInstanceId c1, NetworkInstanceId c2)
		{
			return c1.m_Value == c2.m_Value;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000B268 File Offset: 0x00009468
		public static bool operator !=(NetworkInstanceId c1, NetworkInstanceId c2)
		{
			return c1.m_Value != c2.m_Value;
		}

		// Token: 0x0400010E RID: 270
		[SerializeField]
		private readonly uint m_Value;

		// Token: 0x0400010F RID: 271
		public static NetworkInstanceId Invalid = new NetworkInstanceId(uint.MaxValue);

		// Token: 0x04000110 RID: 272
		internal static NetworkInstanceId Zero = new NetworkInstanceId(0U);
	}
}
