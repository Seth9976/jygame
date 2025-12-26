using System;
using System.IO;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200039C RID: 924
	internal sealed class LinuxIPv4InterfaceProperties : UnixIPv4InterfaceProperties
	{
		// Token: 0x0600207F RID: 8319 RVA: 0x00017635 File Offset: 0x00015835
		public LinuxIPv4InterfaceProperties(LinuxNetworkInterface iface)
			: base(iface)
		{
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06002080 RID: 8320 RVA: 0x00060D60 File Offset: 0x0005EF60
		public override bool IsForwardingEnabled
		{
			get
			{
				string text = "/proc/sys/net/ipv4/conf/" + this.iface.Name + "/forwarding";
				if (File.Exists(text))
				{
					string text2 = NetworkInterface.ReadLine(text);
					return text2 != "0";
				}
				return false;
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x00060DA8 File Offset: 0x0005EFA8
		public override int Mtu
		{
			get
			{
				string text = (this.iface as LinuxNetworkInterface).IfacePath + "mtu";
				int num = 0;
				if (File.Exists(text))
				{
					string text2 = NetworkInterface.ReadLine(text);
					try
					{
						num = int.Parse(text2);
					}
					catch
					{
					}
				}
				return num;
			}
		}
	}
}
