using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000387 RID: 903
	internal class IPAddressInformationImpl : IPAddressInformation
	{
		// Token: 0x06001FA6 RID: 8102 RVA: 0x00016FF4 File Offset: 0x000151F4
		public IPAddressInformationImpl(IPAddress address, bool isDnsEligible, bool isTransient)
		{
			this.address = address;
			this.is_dns_eligible = isDnsEligible;
			this.is_transient = isTransient;
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x00017011 File Offset: 0x00015211
		public override IPAddress Address
		{
			get
			{
				return this.address;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001FA8 RID: 8104 RVA: 0x00017019 File Offset: 0x00015219
		public override bool IsDnsEligible
		{
			get
			{
				return this.is_dns_eligible;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x00017021 File Offset: 0x00015221
		[global::System.MonoTODO("Always false on Linux")]
		public override bool IsTransient
		{
			get
			{
				return this.is_transient;
			}
		}

		// Token: 0x0400132C RID: 4908
		private IPAddress address;

		// Token: 0x0400132D RID: 4909
		private bool is_dns_eligible;

		// Token: 0x0400132E RID: 4910
		private bool is_transient;
	}
}
