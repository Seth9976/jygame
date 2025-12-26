using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200038A RID: 906
	internal class Win32IPGlobalProperties : IPGlobalProperties
	{
		// Token: 0x06001FD7 RID: 8151 RVA: 0x0006012C File Offset: 0x0005E32C
		private unsafe void FillTcpTable(out List<Win32IPGlobalProperties.Win32_MIB_TCPROW> tab4, out List<Win32IPGlobalProperties.Win32_MIB_TCP6ROW> tab6)
		{
			tab4 = new List<Win32IPGlobalProperties.Win32_MIB_TCPROW>();
			int num = 0;
			Win32IPGlobalProperties.GetTcpTable(null, ref num, true);
			byte[] array = new byte[num];
			Win32IPGlobalProperties.GetTcpTable(array, ref num, true);
			int num2 = Marshal.SizeOf(typeof(Win32IPGlobalProperties.Win32_MIB_TCPROW));
			fixed (byte* ptr = (ref array != null && array.Length != 0 ? ref array[0] : ref *null))
			{
				int num3 = Marshal.ReadInt32((IntPtr)((void*)ptr));
				for (int i = 0; i < num3; i++)
				{
					Win32IPGlobalProperties.Win32_MIB_TCPROW win32_MIB_TCPROW = new Win32IPGlobalProperties.Win32_MIB_TCPROW();
					Marshal.PtrToStructure((IntPtr)((void*)(ptr + i * num2 + 4)), win32_MIB_TCPROW);
					tab4.Add(win32_MIB_TCPROW);
				}
			}
			tab6 = new List<Win32IPGlobalProperties.Win32_MIB_TCP6ROW>();
			if (Environment.OSVersion.Version.Major >= 6)
			{
				int num4 = 0;
				Win32IPGlobalProperties.GetTcp6Table(null, ref num4, true);
				byte[] array2 = new byte[num4];
				Win32IPGlobalProperties.GetTcp6Table(array2, ref num4, true);
				int num5 = Marshal.SizeOf(typeof(Win32IPGlobalProperties.Win32_MIB_TCP6ROW));
				fixed (byte* ptr2 = (ref array2 != null && array2.Length != 0 ? ref array2[0] : ref *null))
				{
					int num6 = Marshal.ReadInt32((IntPtr)((void*)ptr2));
					for (int j = 0; j < num6; j++)
					{
						Win32IPGlobalProperties.Win32_MIB_TCP6ROW win32_MIB_TCP6ROW = new Win32IPGlobalProperties.Win32_MIB_TCP6ROW();
						Marshal.PtrToStructure((IntPtr)((void*)(ptr2 + j * num5 + 4)), win32_MIB_TCP6ROW);
						tab6.Add(win32_MIB_TCP6ROW);
					}
				}
			}
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x00060294 File Offset: 0x0005E494
		private bool IsListenerState(TcpState state)
		{
			switch (state)
			{
			case TcpState.Listen:
			case TcpState.SynSent:
			case TcpState.FinWait1:
			case TcpState.FinWait2:
			case TcpState.CloseWait:
				return true;
			}
			return false;
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x000602D0 File Offset: 0x0005E4D0
		public override TcpConnectionInformation[] GetActiveTcpConnections()
		{
			List<Win32IPGlobalProperties.Win32_MIB_TCPROW> list = null;
			List<Win32IPGlobalProperties.Win32_MIB_TCP6ROW> list2 = null;
			this.FillTcpTable(out list, out list2);
			int count = list.Count;
			TcpConnectionInformation[] array = new TcpConnectionInformation[count + list2.Count];
			for (int i = 0; i < count; i++)
			{
				array[i] = list[i].TcpInfo;
			}
			for (int j = 0; j < list2.Count; j++)
			{
				array[count + j] = list2[j].TcpInfo;
			}
			return array;
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x00060358 File Offset: 0x0005E558
		public override IPEndPoint[] GetActiveTcpListeners()
		{
			List<Win32IPGlobalProperties.Win32_MIB_TCPROW> list = null;
			List<Win32IPGlobalProperties.Win32_MIB_TCP6ROW> list2 = null;
			this.FillTcpTable(out list, out list2);
			List<IPEndPoint> list3 = new List<IPEndPoint>();
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				if (this.IsListenerState(list[i].State))
				{
					list3.Add(list[i].LocalEndPoint);
				}
				i++;
			}
			int j = 0;
			int count2 = list2.Count;
			while (j < count2)
			{
				if (this.IsListenerState(list2[j].State))
				{
					list3.Add(list2[j].LocalEndPoint);
				}
				j++;
			}
			return list3.ToArray();
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x00060410 File Offset: 0x0005E610
		public unsafe override IPEndPoint[] GetActiveUdpListeners()
		{
			List<IPEndPoint> list = new List<IPEndPoint>();
			int num = 0;
			Win32IPGlobalProperties.GetUdpTable(null, ref num, true);
			byte[] array = new byte[num];
			Win32IPGlobalProperties.GetUdpTable(array, ref num, true);
			int num2 = Marshal.SizeOf(typeof(Win32IPGlobalProperties.Win32_MIB_UDPROW));
			fixed (byte* ptr = (ref array != null && array.Length != 0 ? ref array[0] : ref *null))
			{
				int num3 = Marshal.ReadInt32((IntPtr)((void*)ptr));
				for (int i = 0; i < num3; i++)
				{
					Win32IPGlobalProperties.Win32_MIB_UDPROW win32_MIB_UDPROW = new Win32IPGlobalProperties.Win32_MIB_UDPROW();
					Marshal.PtrToStructure((IntPtr)((void*)(ptr + i * num2 + 4)), win32_MIB_UDPROW);
					list.Add(win32_MIB_UDPROW.LocalEndPoint);
				}
			}
			if (Environment.OSVersion.Version.Major >= 6)
			{
				int num4 = 0;
				Win32IPGlobalProperties.GetUdp6Table(null, ref num4, true);
				byte[] array2 = new byte[num4];
				Win32IPGlobalProperties.GetUdp6Table(array2, ref num4, true);
				int num5 = Marshal.SizeOf(typeof(Win32IPGlobalProperties.Win32_MIB_UDP6ROW));
				fixed (byte* ptr2 = (ref array2 != null && array2.Length != 0 ? ref array2[0] : ref *null))
				{
					int num6 = Marshal.ReadInt32((IntPtr)((void*)ptr2));
					for (int j = 0; j < num6; j++)
					{
						Win32IPGlobalProperties.Win32_MIB_UDP6ROW win32_MIB_UDP6ROW = new Win32IPGlobalProperties.Win32_MIB_UDP6ROW();
						Marshal.PtrToStructure((IntPtr)((void*)(ptr2 + j * num5 + 4)), win32_MIB_UDP6ROW);
						list.Add(win32_MIB_UDP6ROW.LocalEndPoint);
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x00060588 File Offset: 0x0005E788
		public override IcmpV4Statistics GetIcmpV4Statistics()
		{
			if (!global::System.Net.Sockets.Socket.SupportsIPv4)
			{
				throw new NetworkInformationException();
			}
			Win32_MIBICMPINFO win32_MIBICMPINFO;
			Win32IPGlobalProperties.GetIcmpStatistics(out win32_MIBICMPINFO, 2);
			return new Win32IcmpV4Statistics(win32_MIBICMPINFO);
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x000605B4 File Offset: 0x0005E7B4
		public override IcmpV6Statistics GetIcmpV6Statistics()
		{
			if (!global::System.Net.Sockets.Socket.OSSupportsIPv6)
			{
				throw new NetworkInformationException();
			}
			Win32_MIB_ICMP_EX win32_MIB_ICMP_EX;
			Win32IPGlobalProperties.GetIcmpStatisticsEx(out win32_MIB_ICMP_EX, 23);
			return new Win32IcmpV6Statistics(win32_MIB_ICMP_EX);
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x000605E4 File Offset: 0x0005E7E4
		public override IPGlobalStatistics GetIPv4GlobalStatistics()
		{
			if (!global::System.Net.Sockets.Socket.SupportsIPv4)
			{
				throw new NetworkInformationException();
			}
			Win32_MIB_IPSTATS win32_MIB_IPSTATS;
			Win32IPGlobalProperties.GetIPStatisticsEx(out win32_MIB_IPSTATS, 2);
			return new Win32IPGlobalStatistics(win32_MIB_IPSTATS);
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x00060610 File Offset: 0x0005E810
		public override IPGlobalStatistics GetIPv6GlobalStatistics()
		{
			if (!global::System.Net.Sockets.Socket.OSSupportsIPv6)
			{
				throw new NetworkInformationException();
			}
			Win32_MIB_IPSTATS win32_MIB_IPSTATS;
			Win32IPGlobalProperties.GetIPStatisticsEx(out win32_MIB_IPSTATS, 23);
			return new Win32IPGlobalStatistics(win32_MIB_IPSTATS);
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x00060640 File Offset: 0x0005E840
		public override TcpStatistics GetTcpIPv4Statistics()
		{
			if (!global::System.Net.Sockets.Socket.SupportsIPv4)
			{
				throw new NetworkInformationException();
			}
			Win32_MIB_TCPSTATS win32_MIB_TCPSTATS;
			Win32IPGlobalProperties.GetTcpStatisticsEx(out win32_MIB_TCPSTATS, 2);
			return new Win32TcpStatistics(win32_MIB_TCPSTATS);
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x0006066C File Offset: 0x0005E86C
		public override TcpStatistics GetTcpIPv6Statistics()
		{
			if (!global::System.Net.Sockets.Socket.OSSupportsIPv6)
			{
				throw new NetworkInformationException();
			}
			Win32_MIB_TCPSTATS win32_MIB_TCPSTATS;
			Win32IPGlobalProperties.GetTcpStatisticsEx(out win32_MIB_TCPSTATS, 23);
			return new Win32TcpStatistics(win32_MIB_TCPSTATS);
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x0006069C File Offset: 0x0005E89C
		public override UdpStatistics GetUdpIPv4Statistics()
		{
			if (!global::System.Net.Sockets.Socket.SupportsIPv4)
			{
				throw new NetworkInformationException();
			}
			Win32_MIB_UDPSTATS win32_MIB_UDPSTATS;
			Win32IPGlobalProperties.GetUdpStatisticsEx(out win32_MIB_UDPSTATS, 2);
			return new Win32UdpStatistics(win32_MIB_UDPSTATS);
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x000606C8 File Offset: 0x0005E8C8
		public override UdpStatistics GetUdpIPv6Statistics()
		{
			if (!global::System.Net.Sockets.Socket.OSSupportsIPv6)
			{
				throw new NetworkInformationException();
			}
			Win32_MIB_UDPSTATS win32_MIB_UDPSTATS;
			Win32IPGlobalProperties.GetUdpStatisticsEx(out win32_MIB_UDPSTATS, 23);
			return new Win32UdpStatistics(win32_MIB_UDPSTATS);
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x000170DE File Offset: 0x000152DE
		public override string DhcpScopeName
		{
			get
			{
				return Win32_FIXED_INFO.Instance.ScopeId;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x000170EA File Offset: 0x000152EA
		public override string DomainName
		{
			get
			{
				return Win32_FIXED_INFO.Instance.DomainName;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x000170F6 File Offset: 0x000152F6
		public override string HostName
		{
			get
			{
				return Win32_FIXED_INFO.Instance.HostName;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x00017102 File Offset: 0x00015302
		public override bool IsWinsProxy
		{
			get
			{
				return Win32_FIXED_INFO.Instance.EnableProxy != 0U;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x00017114 File Offset: 0x00015314
		public override NetBiosNodeType NodeType
		{
			get
			{
				return Win32_FIXED_INFO.Instance.NodeType;
			}
		}

		// Token: 0x06001FE9 RID: 8169
		[DllImport("Iphlpapi.dll")]
		private static extern int GetTcpTable(byte[] pTcpTable, ref int pdwSize, bool bOrder);

		// Token: 0x06001FEA RID: 8170
		[DllImport("Iphlpapi.dll")]
		private static extern int GetTcp6Table(byte[] TcpTable, ref int SizePointer, bool Order);

		// Token: 0x06001FEB RID: 8171
		[DllImport("Iphlpapi.dll")]
		private static extern int GetUdpTable(byte[] pUdpTable, ref int pdwSize, bool bOrder);

		// Token: 0x06001FEC RID: 8172
		[DllImport("Iphlpapi.dll")]
		private static extern int GetUdp6Table(byte[] Udp6Table, ref int SizePointer, bool Order);

		// Token: 0x06001FED RID: 8173
		[DllImport("Iphlpapi.dll")]
		private static extern int GetTcpStatisticsEx(out Win32_MIB_TCPSTATS pStats, int dwFamily);

		// Token: 0x06001FEE RID: 8174
		[DllImport("Iphlpapi.dll")]
		private static extern int GetUdpStatisticsEx(out Win32_MIB_UDPSTATS pStats, int dwFamily);

		// Token: 0x06001FEF RID: 8175
		[DllImport("Iphlpapi.dll")]
		private static extern int GetIcmpStatistics(out Win32_MIBICMPINFO pStats, int dwFamily);

		// Token: 0x06001FF0 RID: 8176
		[DllImport("Iphlpapi.dll")]
		private static extern int GetIcmpStatisticsEx(out Win32_MIB_ICMP_EX pStats, int dwFamily);

		// Token: 0x06001FF1 RID: 8177
		[DllImport("Iphlpapi.dll")]
		private static extern int GetIPStatisticsEx(out Win32_MIB_IPSTATS pStats, int dwFamily);

		// Token: 0x04001338 RID: 4920
		public const int AF_INET = 2;

		// Token: 0x04001339 RID: 4921
		public const int AF_INET6 = 23;

		// Token: 0x0200038B RID: 907
		[StructLayout(LayoutKind.Explicit)]
		private struct Win32_IN6_ADDR
		{
			// Token: 0x0400133A RID: 4922
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
			public byte[] Bytes;
		}

		// Token: 0x0200038C RID: 908
		[StructLayout(LayoutKind.Sequential)]
		private class Win32_MIB_TCPROW
		{
			// Token: 0x1700085D RID: 2141
			// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x00017120 File Offset: 0x00015320
			public IPEndPoint LocalEndPoint
			{
				get
				{
					return new IPEndPoint((long)((ulong)this.LocalAddr), this.LocalPort);
				}
			}

			// Token: 0x1700085E RID: 2142
			// (get) Token: 0x06001FF4 RID: 8180 RVA: 0x00017134 File Offset: 0x00015334
			public IPEndPoint RemoteEndPoint
			{
				get
				{
					return new IPEndPoint((long)((ulong)this.RemoteAddr), this.RemotePort);
				}
			}

			// Token: 0x1700085F RID: 2143
			// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x00017148 File Offset: 0x00015348
			public TcpConnectionInformation TcpInfo
			{
				get
				{
					return new TcpConnectionInformationImpl(this.LocalEndPoint, this.RemoteEndPoint, this.State);
				}
			}

			// Token: 0x0400133B RID: 4923
			public TcpState State;

			// Token: 0x0400133C RID: 4924
			public uint LocalAddr;

			// Token: 0x0400133D RID: 4925
			public int LocalPort;

			// Token: 0x0400133E RID: 4926
			public uint RemoteAddr;

			// Token: 0x0400133F RID: 4927
			public int RemotePort;
		}

		// Token: 0x0200038D RID: 909
		[StructLayout(LayoutKind.Sequential)]
		private class Win32_MIB_TCP6ROW
		{
			// Token: 0x17000860 RID: 2144
			// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x00017161 File Offset: 0x00015361
			public IPEndPoint LocalEndPoint
			{
				get
				{
					return new IPEndPoint(new IPAddress(this.LocalAddr.Bytes, (long)((ulong)this.LocalScopeId)), this.LocalPort);
				}
			}

			// Token: 0x17000861 RID: 2145
			// (get) Token: 0x06001FF8 RID: 8184 RVA: 0x00017185 File Offset: 0x00015385
			public IPEndPoint RemoteEndPoint
			{
				get
				{
					return new IPEndPoint(new IPAddress(this.RemoteAddr.Bytes, (long)((ulong)this.RemoteScopeId)), this.RemotePort);
				}
			}

			// Token: 0x17000862 RID: 2146
			// (get) Token: 0x06001FF9 RID: 8185 RVA: 0x000171A9 File Offset: 0x000153A9
			public TcpConnectionInformation TcpInfo
			{
				get
				{
					return new TcpConnectionInformationImpl(this.LocalEndPoint, this.RemoteEndPoint, this.State);
				}
			}

			// Token: 0x04001340 RID: 4928
			public TcpState State;

			// Token: 0x04001341 RID: 4929
			public Win32IPGlobalProperties.Win32_IN6_ADDR LocalAddr;

			// Token: 0x04001342 RID: 4930
			public uint LocalScopeId;

			// Token: 0x04001343 RID: 4931
			public int LocalPort;

			// Token: 0x04001344 RID: 4932
			public Win32IPGlobalProperties.Win32_IN6_ADDR RemoteAddr;

			// Token: 0x04001345 RID: 4933
			public uint RemoteScopeId;

			// Token: 0x04001346 RID: 4934
			public int RemotePort;
		}

		// Token: 0x0200038E RID: 910
		[StructLayout(LayoutKind.Sequential)]
		private class Win32_MIB_UDPROW
		{
			// Token: 0x17000863 RID: 2147
			// (get) Token: 0x06001FFB RID: 8187 RVA: 0x000171C2 File Offset: 0x000153C2
			public IPEndPoint LocalEndPoint
			{
				get
				{
					return new IPEndPoint((long)((ulong)this.LocalAddr), this.LocalPort);
				}
			}

			// Token: 0x04001347 RID: 4935
			public uint LocalAddr;

			// Token: 0x04001348 RID: 4936
			public int LocalPort;
		}

		// Token: 0x0200038F RID: 911
		[StructLayout(LayoutKind.Sequential)]
		private class Win32_MIB_UDP6ROW
		{
			// Token: 0x17000864 RID: 2148
			// (get) Token: 0x06001FFD RID: 8189 RVA: 0x000171D6 File Offset: 0x000153D6
			public IPEndPoint LocalEndPoint
			{
				get
				{
					return new IPEndPoint(new IPAddress(this.LocalAddr.Bytes, (long)((ulong)this.LocalScopeId)), this.LocalPort);
				}
			}

			// Token: 0x04001349 RID: 4937
			public Win32IPGlobalProperties.Win32_IN6_ADDR LocalAddr;

			// Token: 0x0400134A RID: 4938
			public uint LocalScopeId;

			// Token: 0x0400134B RID: 4939
			public int LocalPort;
		}
	}
}
