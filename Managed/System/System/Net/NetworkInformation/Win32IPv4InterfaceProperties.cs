using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200039E RID: 926
	internal sealed class Win32IPv4InterfaceProperties : IPv4InterfaceProperties
	{
		// Token: 0x06002085 RID: 8325 RVA: 0x00060E08 File Offset: 0x0005F008
		public Win32IPv4InterfaceProperties(Win32_IP_ADAPTER_INFO ainfo, Win32_MIB_IFROW mib)
		{
			this.ainfo = ainfo;
			this.mib = mib;
			int num = 0;
			Win32IPv4InterfaceProperties.GetPerAdapterInfo(mib.Index, null, ref num);
			this.painfo = new Win32_IP_PER_ADAPTER_INFO();
			int perAdapterInfo = Win32IPv4InterfaceProperties.GetPerAdapterInfo(mib.Index, this.painfo, ref num);
			if (perAdapterInfo != 0)
			{
				throw new NetworkInformationException(perAdapterInfo);
			}
		}

		// Token: 0x06002086 RID: 8326
		[DllImport("iphlpapi.dll")]
		private static extern int GetPerAdapterInfo(int IfIndex, Win32_IP_PER_ADAPTER_INFO pPerAdapterInfo, ref int pOutBufLen);

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x0001763E File Offset: 0x0001583E
		public override int Index
		{
			get
			{
				return this.mib.Index;
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06002088 RID: 8328 RVA: 0x0001764B File Offset: 0x0001584B
		public override bool IsAutomaticPrivateAddressingActive
		{
			get
			{
				return this.painfo.AutoconfigActive != 0U;
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x0001765E File Offset: 0x0001585E
		public override bool IsAutomaticPrivateAddressingEnabled
		{
			get
			{
				return this.painfo.AutoconfigEnabled != 0U;
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x0600208A RID: 8330 RVA: 0x00017671 File Offset: 0x00015871
		public override bool IsDhcpEnabled
		{
			get
			{
				return this.ainfo.DhcpEnabled != 0U;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x00017684 File Offset: 0x00015884
		public override bool IsForwardingEnabled
		{
			get
			{
				return Win32_FIXED_INFO.Instance.EnableRouting != 0U;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x0600208C RID: 8332 RVA: 0x00017696 File Offset: 0x00015896
		public override int Mtu
		{
			get
			{
				return this.mib.Mtu;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x000176A3 File Offset: 0x000158A3
		public override bool UsesWins
		{
			get
			{
				return this.ainfo.HaveWins;
			}
		}

		// Token: 0x0400138B RID: 5003
		private Win32_IP_ADAPTER_INFO ainfo;

		// Token: 0x0400138C RID: 5004
		private Win32_IP_PER_ADAPTER_INFO painfo;

		// Token: 0x0400138D RID: 5005
		private Win32_MIB_IFROW mib;
	}
}
