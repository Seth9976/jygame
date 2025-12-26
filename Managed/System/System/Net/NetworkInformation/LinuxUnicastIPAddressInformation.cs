using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003E2 RID: 994
	internal class LinuxUnicastIPAddressInformation : UnicastIPAddressInformation
	{
		// Token: 0x060021FA RID: 8698 RVA: 0x0001834C File Offset: 0x0001654C
		public LinuxUnicastIPAddressInformation(IPAddress address)
		{
			this.address = address;
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x060021FB RID: 8699 RVA: 0x0001835B File Offset: 0x0001655B
		public override IPAddress Address
		{
			get
			{
				return this.address;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x060021FC RID: 8700 RVA: 0x00062DA8 File Offset: 0x00060FA8
		public override bool IsDnsEligible
		{
			get
			{
				byte[] addressBytes = this.address.GetAddressBytes();
				return addressBytes[0] != 169 || addressBytes[1] != 254;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x060021FD RID: 8701 RVA: 0x00002AA1 File Offset: 0x00000CA1
		[global::System.MonoTODO("Always returns false")]
		public override bool IsTransient
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x00002664 File Offset: 0x00000864
		public override long AddressPreferredLifetime
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x060021FF RID: 8703 RVA: 0x00002664 File Offset: 0x00000864
		public override long AddressValidLifetime
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x00002664 File Offset: 0x00000864
		public override long DhcpLeaseLifetime
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06002201 RID: 8705 RVA: 0x00002664 File Offset: 0x00000864
		public override DuplicateAddressDetectionState DuplicateAddressDetectionState
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06002202 RID: 8706 RVA: 0x00002664 File Offset: 0x00000864
		public override IPAddress IPv4Mask
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06002203 RID: 8707 RVA: 0x00002664 File Offset: 0x00000864
		public override PrefixOrigin PrefixOrigin
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06002204 RID: 8708 RVA: 0x00002664 File Offset: 0x00000864
		public override SuffixOrigin SuffixOrigin
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x0400148E RID: 5262
		private IPAddress address;
	}
}
