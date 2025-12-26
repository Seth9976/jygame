using System;
using System.Collections.Generic;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000396 RID: 918
	internal class LinuxIPInterfaceProperties : UnixIPInterfaceProperties
	{
		// Token: 0x06002060 RID: 8288 RVA: 0x00017539 File Offset: 0x00015739
		public LinuxIPInterfaceProperties(LinuxNetworkInterface iface, List<IPAddress> addresses)
			: base(iface, addresses)
		{
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x00017543 File Offset: 0x00015743
		public override IPv4InterfaceProperties GetIPv4Properties()
		{
			if (this.ipv4iface_properties == null)
			{
				this.ipv4iface_properties = new LinuxIPv4InterfaceProperties(this.iface as LinuxNetworkInterface);
			}
			return this.ipv4iface_properties;
		}
	}
}
