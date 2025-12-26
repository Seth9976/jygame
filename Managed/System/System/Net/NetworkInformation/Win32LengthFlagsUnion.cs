using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003E9 RID: 1001
	internal struct Win32LengthFlagsUnion
	{
		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x0600220E RID: 8718 RVA: 0x000183AF File Offset: 0x000165AF
		public bool IsDnsEligible
		{
			get
			{
				return (this.Flags & 1U) != 0U;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x000183BF File Offset: 0x000165BF
		public bool IsTransient
		{
			get
			{
				return (this.Flags & 2U) != 0U;
			}
		}

		// Token: 0x040014E9 RID: 5353
		private const int IP_ADAPTER_ADDRESS_DNS_ELIGIBLE = 1;

		// Token: 0x040014EA RID: 5354
		private const int IP_ADAPTER_ADDRESS_TRANSIENT = 2;

		// Token: 0x040014EB RID: 5355
		public uint Length;

		// Token: 0x040014EC RID: 5356
		public uint Flags;
	}
}
