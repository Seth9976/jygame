using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003C4 RID: 964
	internal class Win32NetworkInterface2 : NetworkInterface
	{
		// Token: 0x06002136 RID: 8502 RVA: 0x00061C20 File Offset: 0x0005FE20
		private Win32NetworkInterface2(Win32_IP_ADAPTER_ADDRESSES addr)
		{
			this.addr = addr;
			this.mib4 = default(Win32_MIB_IFROW);
			this.mib4.Index = addr.Alignment.IfIndex;
			if (Win32NetworkInterface2.GetIfEntry(ref this.mib4) != 0)
			{
				this.mib4.Index = -1;
			}
			this.mib6 = default(Win32_MIB_IFROW);
			this.mib6.Index = addr.Ipv6IfIndex;
			if (Win32NetworkInterface2.GetIfEntry(ref this.mib6) != 0)
			{
				this.mib6.Index = -1;
			}
			this.ip4stats = new Win32IPv4InterfaceStatistics(this.mib4);
			this.ip_if_props = new Win32IPInterfaceProperties2(addr, this.mib4, this.mib6);
		}

		// Token: 0x06002137 RID: 8503
		[DllImport("iphlpapi.dll", SetLastError = true)]
		private static extern int GetAdaptersInfo(byte[] info, ref int size);

		// Token: 0x06002138 RID: 8504
		[DllImport("iphlpapi.dll", SetLastError = true)]
		private static extern int GetAdaptersAddresses(uint family, uint flags, IntPtr reserved, byte[] info, ref int size);

		// Token: 0x06002139 RID: 8505
		[DllImport("iphlpapi.dll", SetLastError = true)]
		private static extern int GetIfEntry(ref Win32_MIB_IFROW row);

		// Token: 0x0600213A RID: 8506 RVA: 0x00061CE0 File Offset: 0x0005FEE0
		public static NetworkInterface[] ImplGetAllNetworkInterfaces()
		{
			Win32_IP_ADAPTER_ADDRESSES[] adaptersAddresses = Win32NetworkInterface2.GetAdaptersAddresses();
			NetworkInterface[] array = new NetworkInterface[adaptersAddresses.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new Win32NetworkInterface2(adaptersAddresses[i]);
			}
			return array;
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x00061D1C File Offset: 0x0005FF1C
		public static Win32_IP_ADAPTER_INFO GetAdapterInfoByIndex(int index)
		{
			foreach (Win32_IP_ADAPTER_INFO win32_IP_ADAPTER_INFO in Win32NetworkInterface2.GetAdaptersInfo())
			{
				if ((ulong)win32_IP_ADAPTER_INFO.Index == (ulong)((long)index))
				{
					return win32_IP_ADAPTER_INFO;
				}
			}
			return null;
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x00061D58 File Offset: 0x0005FF58
		private unsafe static Win32_IP_ADAPTER_INFO[] GetAdaptersInfo()
		{
			byte[] array = null;
			int num = 0;
			Win32NetworkInterface2.GetAdaptersInfo(array, ref num);
			array = new byte[num];
			int adaptersInfo = Win32NetworkInterface2.GetAdaptersInfo(array, ref num);
			if (adaptersInfo != 0)
			{
				throw new NetworkInformationException(adaptersInfo);
			}
			List<Win32_IP_ADAPTER_INFO> list = new List<Win32_IP_ADAPTER_INFO>();
			fixed (byte* ptr = (ref array != null && array.Length != 0 ? ref array[0] : ref *null))
			{
				IntPtr intPtr = (IntPtr)((void*)ptr);
				while (intPtr != IntPtr.Zero)
				{
					Win32_IP_ADAPTER_INFO win32_IP_ADAPTER_INFO = new Win32_IP_ADAPTER_INFO();
					Marshal.PtrToStructure(intPtr, win32_IP_ADAPTER_INFO);
					list.Add(win32_IP_ADAPTER_INFO);
					intPtr = win32_IP_ADAPTER_INFO.Next;
				}
			}
			return list.ToArray();
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x00061E00 File Offset: 0x00060000
		private unsafe static Win32_IP_ADAPTER_ADDRESSES[] GetAdaptersAddresses()
		{
			byte[] array = null;
			int num = 0;
			Win32NetworkInterface2.GetAdaptersAddresses(0U, 0U, IntPtr.Zero, array, ref num);
			array = new byte[num];
			int adaptersAddresses = Win32NetworkInterface2.GetAdaptersAddresses(0U, 0U, IntPtr.Zero, array, ref num);
			if (adaptersAddresses != 0)
			{
				throw new NetworkInformationException(adaptersAddresses);
			}
			List<Win32_IP_ADAPTER_ADDRESSES> list = new List<Win32_IP_ADAPTER_ADDRESSES>();
			fixed (byte* ptr = (ref array != null && array.Length != 0 ? ref array[0] : ref *null))
			{
				IntPtr intPtr = (IntPtr)((void*)ptr);
				while (intPtr != IntPtr.Zero)
				{
					Win32_IP_ADAPTER_ADDRESSES win32_IP_ADAPTER_ADDRESSES = new Win32_IP_ADAPTER_ADDRESSES();
					Marshal.PtrToStructure(intPtr, win32_IP_ADAPTER_ADDRESSES);
					list.Add(win32_IP_ADAPTER_ADDRESSES);
					intPtr = win32_IP_ADAPTER_ADDRESSES.Next;
				}
			}
			return list.ToArray();
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x00017B40 File Offset: 0x00015D40
		public override IPInterfaceProperties GetIPProperties()
		{
			return this.ip_if_props;
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x00017B48 File Offset: 0x00015D48
		public override IPv4InterfaceStatistics GetIPv4Statistics()
		{
			return this.ip4stats;
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x00061EB4 File Offset: 0x000600B4
		public override PhysicalAddress GetPhysicalAddress()
		{
			byte[] array = new byte[this.addr.PhysicalAddressLength];
			Array.Copy(this.addr.PhysicalAddress, 0, array, 0, array.Length);
			return new PhysicalAddress(array);
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x00061EF0 File Offset: 0x000600F0
		public override bool Supports(NetworkInterfaceComponent networkInterfaceComponent)
		{
			if (networkInterfaceComponent != NetworkInterfaceComponent.IPv4)
			{
				return networkInterfaceComponent == NetworkInterfaceComponent.IPv6 && this.mib6.Index >= 0;
			}
			return this.mib4.Index >= 0;
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x00017B50 File Offset: 0x00015D50
		public override string Description
		{
			get
			{
				return this.addr.Description;
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x00017B5D File Offset: 0x00015D5D
		public override string Id
		{
			get
			{
				return this.addr.AdapterName;
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06002144 RID: 8516 RVA: 0x00017B6A File Offset: 0x00015D6A
		public override bool IsReceiveOnly
		{
			get
			{
				return this.addr.IsReceiveOnly;
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x00017B77 File Offset: 0x00015D77
		public override string Name
		{
			get
			{
				return this.addr.FriendlyName;
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06002146 RID: 8518 RVA: 0x00017B84 File Offset: 0x00015D84
		public override NetworkInterfaceType NetworkInterfaceType
		{
			get
			{
				return this.addr.IfType;
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06002147 RID: 8519 RVA: 0x00017B91 File Offset: 0x00015D91
		public override OperationalStatus OperationalStatus
		{
			get
			{
				return this.addr.OperStatus;
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x00017B9E File Offset: 0x00015D9E
		public override long Speed
		{
			get
			{
				return (long)((ulong)((this.mib6.Index < 0) ? this.mib4.Speed : this.mib6.Speed));
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x00017BCD File Offset: 0x00015DCD
		public override bool SupportsMulticast
		{
			get
			{
				return !this.addr.NoMulticast;
			}
		}

		// Token: 0x0400140C RID: 5132
		private Win32_IP_ADAPTER_ADDRESSES addr;

		// Token: 0x0400140D RID: 5133
		private Win32_MIB_IFROW mib4;

		// Token: 0x0400140E RID: 5134
		private Win32_MIB_IFROW mib6;

		// Token: 0x0400140F RID: 5135
		private Win32IPv4InterfaceStatistics ip4stats;

		// Token: 0x04001410 RID: 5136
		private IPInterfaceProperties ip_if_props;
	}
}
