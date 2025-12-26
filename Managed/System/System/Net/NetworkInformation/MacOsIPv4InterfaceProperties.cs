using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200039D RID: 925
	internal sealed class MacOsIPv4InterfaceProperties : UnixIPv4InterfaceProperties
	{
		// Token: 0x06002082 RID: 8322 RVA: 0x00017635 File Offset: 0x00015835
		public MacOsIPv4InterfaceProperties(MacOsNetworkInterface iface)
			: base(iface)
		{
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool IsForwardingEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06002084 RID: 8324 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override int Mtu
		{
			get
			{
				return 0;
			}
		}
	}
}
