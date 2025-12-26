using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003E1 RID: 993
	internal class Win32UnicastIPAddressInformation : UnicastIPAddressInformation
	{
		// Token: 0x060021EF RID: 8687 RVA: 0x000182AF File Offset: 0x000164AF
		public Win32UnicastIPAddressInformation(int ifIndex, Win32_IP_ADAPTER_UNICAST_ADDRESS info)
		{
			this.if_index = ifIndex;
			this.info = info;
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x060021F0 RID: 8688 RVA: 0x000182C5 File Offset: 0x000164C5
		public override IPAddress Address
		{
			get
			{
				return this.info.Address.GetIPAddress();
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x060021F1 RID: 8689 RVA: 0x000182D7 File Offset: 0x000164D7
		public override bool IsDnsEligible
		{
			get
			{
				return this.info.LengthFlags.IsDnsEligible;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x060021F2 RID: 8690 RVA: 0x000182E9 File Offset: 0x000164E9
		public override bool IsTransient
		{
			get
			{
				return this.info.LengthFlags.IsTransient;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x060021F3 RID: 8691 RVA: 0x000182FB File Offset: 0x000164FB
		public override long AddressPreferredLifetime
		{
			get
			{
				return (long)((ulong)this.info.PreferredLifetime);
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x060021F4 RID: 8692 RVA: 0x00018309 File Offset: 0x00016509
		public override long AddressValidLifetime
		{
			get
			{
				return (long)((ulong)this.info.ValidLifetime);
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x060021F5 RID: 8693 RVA: 0x00018317 File Offset: 0x00016517
		public override long DhcpLeaseLifetime
		{
			get
			{
				return (long)((ulong)this.info.LeaseLifetime);
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x060021F6 RID: 8694 RVA: 0x00018325 File Offset: 0x00016525
		public override DuplicateAddressDetectionState DuplicateAddressDetectionState
		{
			get
			{
				return this.info.DadState;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x060021F7 RID: 8695 RVA: 0x00062CF0 File Offset: 0x00060EF0
		public override IPAddress IPv4Mask
		{
			get
			{
				Win32_IP_ADAPTER_INFO adapterInfoByIndex = Win32NetworkInterface2.GetAdapterInfoByIndex(this.if_index);
				if (adapterInfoByIndex == null)
				{
					throw new Exception("huh? " + this.if_index);
				}
				if (this.Address == null)
				{
					return null;
				}
				string text = this.Address.ToString();
				Win32_IP_ADDR_STRING win32_IP_ADDR_STRING = adapterInfoByIndex.IpAddressList;
				while (!(win32_IP_ADDR_STRING.IpAddress == text))
				{
					if (win32_IP_ADDR_STRING.Next == IntPtr.Zero)
					{
						return null;
					}
					win32_IP_ADDR_STRING = (Win32_IP_ADDR_STRING)Marshal.PtrToStructure(win32_IP_ADDR_STRING.Next, typeof(Win32_IP_ADDR_STRING));
				}
				return IPAddress.Parse(win32_IP_ADDR_STRING.IpMask);
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x060021F8 RID: 8696 RVA: 0x00018332 File Offset: 0x00016532
		public override PrefixOrigin PrefixOrigin
		{
			get
			{
				return this.info.PrefixOrigin;
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x060021F9 RID: 8697 RVA: 0x0001833F File Offset: 0x0001653F
		public override SuffixOrigin SuffixOrigin
		{
			get
			{
				return this.info.SuffixOrigin;
			}
		}

		// Token: 0x0400148C RID: 5260
		private int if_index;

		// Token: 0x0400148D RID: 5261
		private Win32_IP_ADAPTER_UNICAST_ADDRESS info;
	}
}
