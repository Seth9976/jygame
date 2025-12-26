using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000398 RID: 920
	internal class Win32IPInterfaceProperties2 : IPInterfaceProperties
	{
		// Token: 0x06002064 RID: 8292 RVA: 0x00017595 File Offset: 0x00015795
		public Win32IPInterfaceProperties2(Win32_IP_ADAPTER_ADDRESSES addr, Win32_MIB_IFROW mib4, Win32_MIB_IFROW mib6)
		{
			this.addr = addr;
			this.mib4 = mib4;
			this.mib6 = mib6;
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x00060BA4 File Offset: 0x0005EDA4
		public override IPv4InterfaceProperties GetIPv4Properties()
		{
			Win32_IP_ADAPTER_INFO adapterInfoByIndex = Win32NetworkInterface2.GetAdapterInfoByIndex(this.mib4.Index);
			return (adapterInfoByIndex == null) ? null : new Win32IPv4InterfaceProperties(adapterInfoByIndex, this.mib4);
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x00060BE0 File Offset: 0x0005EDE0
		public override IPv6InterfaceProperties GetIPv6Properties()
		{
			Win32_IP_ADAPTER_INFO adapterInfoByIndex = Win32NetworkInterface2.GetAdapterInfoByIndex(this.mib6.Index);
			return (adapterInfoByIndex == null) ? null : new Win32IPv6InterfaceProperties(this.mib6);
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x000175B2 File Offset: 0x000157B2
		public override IPAddressInformationCollection AnycastAddresses
		{
			get
			{
				return IPAddressInformationImplCollection.Win32FromAnycast(this.addr.FirstAnycastAddress);
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06002068 RID: 8296 RVA: 0x00060C18 File Offset: 0x0005EE18
		public override IPAddressCollection DhcpServerAddresses
		{
			get
			{
				Win32_IP_ADAPTER_INFO adapterInfoByIndex = Win32NetworkInterface2.GetAdapterInfoByIndex(this.mib4.Index);
				return (adapterInfoByIndex == null) ? Win32IPAddressCollection.Empty : new Win32IPAddressCollection(new Win32_IP_ADDR_STRING[] { adapterInfoByIndex.DhcpServer });
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06002069 RID: 8297 RVA: 0x000175C4 File Offset: 0x000157C4
		public override IPAddressCollection DnsAddresses
		{
			get
			{
				return Win32IPAddressCollection.FromDnsServer(this.addr.FirstDnsServerAddress);
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x0600206A RID: 8298 RVA: 0x000175D6 File Offset: 0x000157D6
		public override string DnsSuffix
		{
			get
			{
				return this.addr.DnsSuffix;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x0600206B RID: 8299 RVA: 0x00060C68 File Offset: 0x0005EE68
		public override GatewayIPAddressInformationCollection GatewayAddresses
		{
			get
			{
				Win32_IP_ADAPTER_INFO adapterInfoByIndex = Win32NetworkInterface2.GetAdapterInfoByIndex(this.mib4.Index);
				return (adapterInfoByIndex == null) ? Win32GatewayIPAddressInformationCollection.Empty : new Win32GatewayIPAddressInformationCollection(new Win32_IP_ADDR_STRING[] { adapterInfoByIndex.GatewayList });
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x000175E3 File Offset: 0x000157E3
		public override bool IsDnsEnabled
		{
			get
			{
				return Win32_FIXED_INFO.Instance.EnableDns != 0U;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x000175F5 File Offset: 0x000157F5
		public override bool IsDynamicDnsEnabled
		{
			get
			{
				return this.addr.DdnsEnabled;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x00017602 File Offset: 0x00015802
		public override MulticastIPAddressInformationCollection MulticastAddresses
		{
			get
			{
				return MulticastIPAddressInformationImplCollection.Win32FromMulticast(this.addr.FirstMulticastAddress);
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x00060CB8 File Offset: 0x0005EEB8
		public override UnicastIPAddressInformationCollection UnicastAddresses
		{
			get
			{
				Win32_IP_ADAPTER_INFO adapterInfoByIndex = Win32NetworkInterface2.GetAdapterInfoByIndex(this.mib4.Index);
				return (adapterInfoByIndex == null) ? UnicastIPAddressInformationImplCollection.Empty : UnicastIPAddressInformationImplCollection.Win32FromUnicast((int)adapterInfoByIndex.Index, this.addr.FirstUnicastAddress);
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x00060D00 File Offset: 0x0005EF00
		public override IPAddressCollection WinsServersAddresses
		{
			get
			{
				Win32_IP_ADAPTER_INFO adapterInfoByIndex = Win32NetworkInterface2.GetAdapterInfoByIndex(this.mib4.Index);
				return (adapterInfoByIndex == null) ? Win32IPAddressCollection.Empty : new Win32IPAddressCollection(new Win32_IP_ADDR_STRING[] { adapterInfoByIndex.PrimaryWinsServer, adapterInfoByIndex.SecondaryWinsServer });
			}
		}

		// Token: 0x0400136E RID: 4974
		private readonly Win32_IP_ADAPTER_ADDRESSES addr;

		// Token: 0x0400136F RID: 4975
		private readonly Win32_MIB_IFROW mib4;

		// Token: 0x04001370 RID: 4976
		private readonly Win32_MIB_IFROW mib6;
	}
}
