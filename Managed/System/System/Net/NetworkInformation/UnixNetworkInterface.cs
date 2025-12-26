using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003C1 RID: 961
	internal abstract class UnixNetworkInterface : NetworkInterface
	{
		// Token: 0x06002118 RID: 8472 RVA: 0x00017A27 File Offset: 0x00015C27
		internal UnixNetworkInterface(string name)
		{
			this.name = name;
			this.addresses = new List<IPAddress>();
		}

		// Token: 0x06002119 RID: 8473
		[DllImport("libc")]
		private static extern int if_nametoindex(string ifname);

		// Token: 0x0600211A RID: 8474 RVA: 0x00017A41 File Offset: 0x00015C41
		public static int IfNameToIndex(string ifname)
		{
			return UnixNetworkInterface.if_nametoindex(ifname);
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x00017A49 File Offset: 0x00015C49
		internal void AddAddress(IPAddress address)
		{
			this.addresses.Add(address);
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x00017A57 File Offset: 0x00015C57
		internal void SetLinkLayerInfo(int index, byte[] macAddress, NetworkInterfaceType type)
		{
			this.index = index;
			this.macAddress = macAddress;
			this.type = type;
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x00017A6E File Offset: 0x00015C6E
		public override PhysicalAddress GetPhysicalAddress()
		{
			if (this.macAddress != null)
			{
				return new PhysicalAddress(this.macAddress);
			}
			return PhysicalAddress.None;
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x0006125C File Offset: 0x0005F45C
		public override bool Supports(NetworkInterfaceComponent networkInterfaceComponent)
		{
			bool flag = networkInterfaceComponent == NetworkInterfaceComponent.IPv4;
			bool flag2 = !flag && networkInterfaceComponent == NetworkInterfaceComponent.IPv6;
			foreach (IPAddress ipaddress in this.addresses)
			{
				if (flag && ipaddress.AddressFamily == global::System.Net.Sockets.AddressFamily.InterNetwork)
				{
					return true;
				}
				if (flag2 && ipaddress.AddressFamily == global::System.Net.Sockets.AddressFamily.InterNetworkV6)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x0600211F RID: 8479 RVA: 0x00017A8C File Offset: 0x00015C8C
		public override string Description
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x00017A8C File Offset: 0x00015C8C
		public override string Id
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06002121 RID: 8481 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool IsReceiveOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06002122 RID: 8482 RVA: 0x00017A8C File Offset: 0x00015C8C
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06002123 RID: 8483 RVA: 0x00017A94 File Offset: 0x00015C94
		public override NetworkInterfaceType NetworkInterfaceType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06002124 RID: 8484 RVA: 0x00017A9C File Offset: 0x00015C9C
		[global::System.MonoTODO("Parse dmesg?")]
		public override long Speed
		{
			get
			{
				return 1000000L;
			}
		}

		// Token: 0x040013FA RID: 5114
		protected IPv4InterfaceStatistics ipv4stats;

		// Token: 0x040013FB RID: 5115
		protected IPInterfaceProperties ipproperties;

		// Token: 0x040013FC RID: 5116
		private string name;

		// Token: 0x040013FD RID: 5117
		private int index;

		// Token: 0x040013FE RID: 5118
		protected List<IPAddress> addresses;

		// Token: 0x040013FF RID: 5119
		private byte[] macAddress;

		// Token: 0x04001400 RID: 5120
		private NetworkInterfaceType type;
	}
}
