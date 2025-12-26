using System;
using System.Collections.Generic;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000397 RID: 919
	internal class MacOsIPInterfaceProperties : UnixIPInterfaceProperties
	{
		// Token: 0x06002062 RID: 8290 RVA: 0x00017539 File Offset: 0x00015739
		public MacOsIPInterfaceProperties(MacOsNetworkInterface iface, List<IPAddress> addresses)
			: base(iface, addresses)
		{
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x0001756C File Offset: 0x0001576C
		public override IPv4InterfaceProperties GetIPv4Properties()
		{
			if (this.ipv4iface_properties == null)
			{
				this.ipv4iface_properties = new MacOsIPv4InterfaceProperties(this.iface as MacOsNetworkInterface);
			}
			return this.ipv4iface_properties;
		}
	}
}
