using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003B7 RID: 951
	internal class MulticastIPAddressInformationImpl : MulticastIPAddressInformation
	{
		// Token: 0x060020E1 RID: 8417 RVA: 0x0001792C File Offset: 0x00015B2C
		public MulticastIPAddressInformationImpl(IPAddress address, bool isDnsEligible, bool isTransient)
		{
			this.address = address;
			this.is_dns_eligible = isDnsEligible;
			this.is_transient = isTransient;
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x00017949 File Offset: 0x00015B49
		public override IPAddress Address
		{
			get
			{
				return this.address;
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x00017951 File Offset: 0x00015B51
		public override bool IsDnsEligible
		{
			get
			{
				return this.is_dns_eligible;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x060020E4 RID: 8420 RVA: 0x00017959 File Offset: 0x00015B59
		public override bool IsTransient
		{
			get
			{
				return this.is_transient;
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x060020E5 RID: 8421 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public override long AddressPreferredLifetime
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public override long AddressValidLifetime
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x060020E7 RID: 8423 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public override long DhcpLeaseLifetime
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x060020E8 RID: 8424 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override DuplicateAddressDetectionState DuplicateAddressDetectionState
		{
			get
			{
				return DuplicateAddressDetectionState.Invalid;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x060020E9 RID: 8425 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override PrefixOrigin PrefixOrigin
		{
			get
			{
				return PrefixOrigin.Other;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x060020EA RID: 8426 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override SuffixOrigin SuffixOrigin
		{
			get
			{
				return SuffixOrigin.Other;
			}
		}

		// Token: 0x040013E0 RID: 5088
		private IPAddress address;

		// Token: 0x040013E1 RID: 5089
		private bool is_dns_eligible;

		// Token: 0x040013E2 RID: 5090
		private bool is_transient;
	}
}
