using System;
using System.Collections.Generic;
using System.Net.NetworkInformation.MacOsStructs;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003C3 RID: 963
	internal class MacOsNetworkInterface : UnixNetworkInterface
	{
		// Token: 0x0600212E RID: 8494 RVA: 0x00017AF0 File Offset: 0x00015CF0
		private MacOsNetworkInterface(string name)
			: base(name)
		{
		}

		// Token: 0x0600212F RID: 8495
		[DllImport("libc")]
		private static extern int getifaddrs(out IntPtr ifap);

		// Token: 0x06002130 RID: 8496
		[DllImport("libc")]
		private static extern void freeifaddrs(IntPtr ifap);

		// Token: 0x06002131 RID: 8497 RVA: 0x000618E4 File Offset: 0x0005FAE4
		public static NetworkInterface[] ImplGetAllNetworkInterfaces()
		{
			Dictionary<string, MacOsNetworkInterface> dictionary = new Dictionary<string, MacOsNetworkInterface>();
			IntPtr intPtr;
			if (MacOsNetworkInterface.getifaddrs(out intPtr) != 0)
			{
				throw new SystemException("getifaddrs() failed");
			}
			try
			{
				IntPtr intPtr2 = intPtr;
				while (intPtr2 != IntPtr.Zero)
				{
					global::System.Net.NetworkInformation.MacOsStructs.ifaddrs ifaddrs = (global::System.Net.NetworkInformation.MacOsStructs.ifaddrs)Marshal.PtrToStructure(intPtr2, typeof(global::System.Net.NetworkInformation.MacOsStructs.ifaddrs));
					IPAddress ipaddress = IPAddress.None;
					string ifa_name = ifaddrs.ifa_name;
					int num = -1;
					byte[] array = null;
					NetworkInterfaceType networkInterfaceType = NetworkInterfaceType.Unknown;
					if (ifaddrs.ifa_addr != IntPtr.Zero)
					{
						global::System.Net.NetworkInformation.MacOsStructs.sockaddr sockaddr = (global::System.Net.NetworkInformation.MacOsStructs.sockaddr)Marshal.PtrToStructure(ifaddrs.ifa_addr, typeof(global::System.Net.NetworkInformation.MacOsStructs.sockaddr));
						if (sockaddr.sa_family == 30)
						{
							global::System.Net.NetworkInformation.MacOsStructs.sockaddr_in6 sockaddr_in = (global::System.Net.NetworkInformation.MacOsStructs.sockaddr_in6)Marshal.PtrToStructure(ifaddrs.ifa_addr, typeof(global::System.Net.NetworkInformation.MacOsStructs.sockaddr_in6));
							ipaddress = new IPAddress(sockaddr_in.sin6_addr.u6_addr8, (long)((ulong)sockaddr_in.sin6_scope_id));
						}
						else if (sockaddr.sa_family == 2)
						{
							ipaddress = new IPAddress((long)((ulong)((global::System.Net.NetworkInformation.MacOsStructs.sockaddr_in)Marshal.PtrToStructure(ifaddrs.ifa_addr, typeof(global::System.Net.NetworkInformation.MacOsStructs.sockaddr_in))).sin_addr));
						}
						else if (sockaddr.sa_family == 18)
						{
							global::System.Net.NetworkInformation.MacOsStructs.sockaddr_dl sockaddr_dl = (global::System.Net.NetworkInformation.MacOsStructs.sockaddr_dl)Marshal.PtrToStructure(ifaddrs.ifa_addr, typeof(global::System.Net.NetworkInformation.MacOsStructs.sockaddr_dl));
							array = new byte[(int)sockaddr_dl.sdl_alen];
							Array.Copy(sockaddr_dl.sdl_data, (int)sockaddr_dl.sdl_nlen, array, 0, Math.Min(array.Length, sockaddr_dl.sdl_data.Length - (int)sockaddr_dl.sdl_nlen));
							num = (int)sockaddr_dl.sdl_index;
							int sdl_type = (int)sockaddr_dl.sdl_type;
							if (Enum.IsDefined(typeof(MacOsArpHardware), sdl_type))
							{
								MacOsArpHardware macOsArpHardware = (MacOsArpHardware)sdl_type;
								switch (macOsArpHardware)
								{
								case MacOsArpHardware.PPP:
									networkInterfaceType = NetworkInterfaceType.Ppp;
									break;
								case MacOsArpHardware.LOOPBACK:
									networkInterfaceType = NetworkInterfaceType.Loopback;
									array = null;
									break;
								default:
									if (macOsArpHardware != MacOsArpHardware.ETHER)
									{
										if (macOsArpHardware != MacOsArpHardware.FDDI)
										{
											if (macOsArpHardware == MacOsArpHardware.ATM)
											{
												networkInterfaceType = NetworkInterfaceType.Atm;
											}
										}
										else
										{
											networkInterfaceType = NetworkInterfaceType.Fddi;
										}
									}
									else
									{
										networkInterfaceType = NetworkInterfaceType.Ethernet;
									}
									break;
								case MacOsArpHardware.SLIP:
									networkInterfaceType = NetworkInterfaceType.Slip;
									break;
								}
							}
						}
					}
					MacOsNetworkInterface macOsNetworkInterface = null;
					if (!dictionary.TryGetValue(ifa_name, out macOsNetworkInterface))
					{
						macOsNetworkInterface = new MacOsNetworkInterface(ifa_name);
						dictionary.Add(ifa_name, macOsNetworkInterface);
					}
					if (!ipaddress.Equals(IPAddress.None))
					{
						macOsNetworkInterface.AddAddress(ipaddress);
					}
					if (array != null || networkInterfaceType == NetworkInterfaceType.Loopback)
					{
						macOsNetworkInterface.SetLinkLayerInfo(num, array, networkInterfaceType);
					}
					intPtr2 = ifaddrs.ifa_next;
				}
			}
			finally
			{
				MacOsNetworkInterface.freeifaddrs(intPtr);
			}
			NetworkInterface[] array2 = new NetworkInterface[dictionary.Count];
			int num2 = 0;
			foreach (NetworkInterface networkInterface in dictionary.Values)
			{
				array2[num2] = networkInterface;
				num2++;
			}
			return array2;
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x00017AF9 File Offset: 0x00015CF9
		public override IPInterfaceProperties GetIPProperties()
		{
			if (this.ipproperties == null)
			{
				this.ipproperties = new MacOsIPInterfaceProperties(this, this.addresses);
			}
			return this.ipproperties;
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x00017B1E File Offset: 0x00015D1E
		public override IPv4InterfaceStatistics GetIPv4Statistics()
		{
			if (this.ipv4stats == null)
			{
				this.ipv4stats = new MacOsIPv4InterfaceStatistics(this);
			}
			return this.ipv4stats;
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x00017B3D File Offset: 0x00015D3D
		public override OperationalStatus OperationalStatus
		{
			get
			{
				return OperationalStatus.Unknown;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool SupportsMulticast
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04001409 RID: 5129
		private const int AF_INET = 2;

		// Token: 0x0400140A RID: 5130
		private const int AF_INET6 = 30;

		// Token: 0x0400140B RID: 5131
		private const int AF_LINK = 18;
	}
}
