using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000389 RID: 905
	internal class MibIPGlobalProperties : IPGlobalProperties
	{
		// Token: 0x06001FBC RID: 8124 RVA: 0x0005FB08 File Offset: 0x0005DD08
		public MibIPGlobalProperties(string procDir)
		{
			this.StatisticsFile = Path.Combine(procDir, "net/snmp");
			this.StatisticsFileIPv6 = Path.Combine(procDir, "net/snmp6");
			this.TcpFile = Path.Combine(procDir, "net/tcp");
			this.Tcp6File = Path.Combine(procDir, "net/tcp6");
			this.UdpFile = Path.Combine(procDir, "net/udp");
			this.Udp6File = Path.Combine(procDir, "net/udp6");
		}

		// Token: 0x06001FBE RID: 8126
		[DllImport("libc")]
		private static extern int gethostname([MarshalAs(UnmanagedType.LPArray, SizeConst = 0, SizeParamIndex = 1)] byte[] name, int len);

		// Token: 0x06001FBF RID: 8127
		[DllImport("libc")]
		private static extern int getdomainname([MarshalAs(UnmanagedType.LPArray, SizeConst = 0, SizeParamIndex = 1)] byte[] name, int len);

		// Token: 0x06001FC0 RID: 8128 RVA: 0x0005FB84 File Offset: 0x0005DD84
		private global::System.Collections.Specialized.StringDictionary GetProperties4(string item)
		{
			string statisticsFile = this.StatisticsFile;
			string text = item + ": ";
			global::System.Collections.Specialized.StringDictionary stringDictionary2;
			using (StreamReader streamReader = new StreamReader(statisticsFile, Encoding.ASCII))
			{
				string[] array = null;
				string[] array2 = null;
				string text2 = string.Empty;
				for (;;)
				{
					text2 = streamReader.ReadLine();
					if (!string.IsNullOrEmpty(text2))
					{
						if (text2.Length > text.Length && string.CompareOrdinal(text2, 0, text, 0, text.Length) == 0)
						{
							if (array != null)
							{
								break;
							}
							array = text2.Substring(text.Length).Split(new char[] { ' ' });
						}
					}
					if (streamReader.EndOfStream)
					{
						goto IL_00E2;
					}
				}
				if (array2 != null)
				{
					throw this.CreateException(statisticsFile, string.Format("Found duplicate line for values for the same item '{0}'", item));
				}
				array2 = text2.Substring(text.Length).Split(new char[] { ' ' });
				IL_00E2:
				if (array2 == null)
				{
					throw this.CreateException(statisticsFile, string.Format("No corresponding line was not found for '{0}'", item));
				}
				if (array.Length != array2.Length)
				{
					throw this.CreateException(statisticsFile, string.Format("The counts in the header line and the value line do not match for '{0}'", item));
				}
				global::System.Collections.Specialized.StringDictionary stringDictionary = new global::System.Collections.Specialized.StringDictionary();
				for (int i = 0; i < array.Length; i++)
				{
					stringDictionary[array[i]] = array2[i];
				}
				stringDictionary2 = stringDictionary;
			}
			return stringDictionary2;
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x0005FD14 File Offset: 0x0005DF14
		private global::System.Collections.Specialized.StringDictionary GetProperties6(string item)
		{
			if (!File.Exists(this.StatisticsFileIPv6))
			{
				throw new NetworkInformationException();
			}
			string statisticsFileIPv = this.StatisticsFileIPv6;
			global::System.Collections.Specialized.StringDictionary stringDictionary2;
			using (StreamReader streamReader = new StreamReader(statisticsFileIPv, Encoding.ASCII))
			{
				global::System.Collections.Specialized.StringDictionary stringDictionary = new global::System.Collections.Specialized.StringDictionary();
				string text = string.Empty;
				for (;;)
				{
					text = streamReader.ReadLine();
					if (!string.IsNullOrEmpty(text))
					{
						if (text.Length > item.Length && string.CompareOrdinal(text, 0, item, 0, item.Length) == 0)
						{
							int num = text.IndexOfAny(MibIPGlobalProperties.wsChars, item.Length);
							if (num < 0)
							{
								break;
							}
							stringDictionary[text.Substring(item.Length, num - item.Length)] = text.Substring(num + 1).Trim(MibIPGlobalProperties.wsChars);
						}
					}
					if (streamReader.EndOfStream)
					{
						goto Block_7;
					}
				}
				throw this.CreateException(statisticsFileIPv, null);
				Block_7:
				stringDictionary2 = stringDictionary;
			}
			return stringDictionary2;
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x00017040 File Offset: 0x00015240
		private Exception CreateException(string file, string msg)
		{
			return new InvalidOperationException(string.Format("Unsupported (unexpected) '{0}' file format. ", file) + msg);
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x0005FE2C File Offset: 0x0005E02C
		private IPEndPoint[] GetLocalAddresses(List<string[]> list)
		{
			IPEndPoint[] array = new IPEndPoint[list.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = this.ToEndpoint(list[i][1]);
			}
			return array;
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x0005FE6C File Offset: 0x0005E06C
		private IPEndPoint ToEndpoint(string s)
		{
			int num = s.IndexOf(':');
			int num2 = int.Parse(s.Substring(num + 1), NumberStyles.HexNumber);
			if (s.Length == 13)
			{
				return new IPEndPoint(long.Parse(s.Substring(0, num), NumberStyles.HexNumber), num2);
			}
			byte[] array = new byte[16];
			int num3 = 0;
			while (num3 << 1 < num)
			{
				array[num3] = byte.Parse(s.Substring(num3 << 1, 2), NumberStyles.HexNumber);
				num3++;
			}
			return new IPEndPoint(new IPAddress(array), num2);
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x0005FEFC File Offset: 0x0005E0FC
		private void GetRows(string file, List<string[]> list)
		{
			if (!File.Exists(file))
			{
				return;
			}
			using (StreamReader streamReader = new StreamReader(file, Encoding.ASCII))
			{
				streamReader.ReadLine();
				while (!streamReader.EndOfStream)
				{
					string[] array = streamReader.ReadLine().Split(MibIPGlobalProperties.wsChars, StringSplitOptions.RemoveEmptyEntries);
					if (array.Length < 4)
					{
						throw this.CreateException(file, null);
					}
					list.Add(array);
				}
			}
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x0005FF88 File Offset: 0x0005E188
		public override TcpConnectionInformation[] GetActiveTcpConnections()
		{
			List<string[]> list = new List<string[]>();
			this.GetRows(this.TcpFile, list);
			this.GetRows(this.Tcp6File, list);
			TcpConnectionInformation[] array = new TcpConnectionInformation[list.Count];
			for (int i = 0; i < array.Length; i++)
			{
				IPEndPoint ipendPoint = this.ToEndpoint(list[i][1]);
				IPEndPoint ipendPoint2 = this.ToEndpoint(list[i][2]);
				TcpState tcpState = (TcpState)int.Parse(list[i][3], NumberStyles.HexNumber);
				array[i] = new TcpConnectionInformationImpl(ipendPoint, ipendPoint2, tcpState);
			}
			return array;
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x0006001C File Offset: 0x0005E21C
		public override IPEndPoint[] GetActiveTcpListeners()
		{
			List<string[]> list = new List<string[]>();
			this.GetRows(this.TcpFile, list);
			this.GetRows(this.Tcp6File, list);
			return this.GetLocalAddresses(list);
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x00060050 File Offset: 0x0005E250
		public override IPEndPoint[] GetActiveUdpListeners()
		{
			List<string[]> list = new List<string[]>();
			this.GetRows(this.UdpFile, list);
			this.GetRows(this.Udp6File, list);
			return this.GetLocalAddresses(list);
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x00017058 File Offset: 0x00015258
		public override IcmpV4Statistics GetIcmpV4Statistics()
		{
			return new MibIcmpV4Statistics(this.GetProperties4("Icmp"));
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x0001706A File Offset: 0x0001526A
		public override IcmpV6Statistics GetIcmpV6Statistics()
		{
			return new MibIcmpV6Statistics(this.GetProperties6("Icmp6"));
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x0001707C File Offset: 0x0001527C
		public override IPGlobalStatistics GetIPv4GlobalStatistics()
		{
			return new MibIPGlobalStatistics(this.GetProperties4("Ip"));
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x0001708E File Offset: 0x0001528E
		public override IPGlobalStatistics GetIPv6GlobalStatistics()
		{
			return new MibIPGlobalStatistics(this.GetProperties6("Ip6"));
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x000170A0 File Offset: 0x000152A0
		public override TcpStatistics GetTcpIPv4Statistics()
		{
			return new MibTcpStatistics(this.GetProperties4("Tcp"));
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x000170A0 File Offset: 0x000152A0
		public override TcpStatistics GetTcpIPv6Statistics()
		{
			return new MibTcpStatistics(this.GetProperties4("Tcp"));
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x000170B2 File Offset: 0x000152B2
		public override UdpStatistics GetUdpIPv4Statistics()
		{
			return new MibUdpStatistics(this.GetProperties4("Udp"));
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x000170C4 File Offset: 0x000152C4
		public override UdpStatistics GetUdpIPv6Statistics()
		{
			return new MibUdpStatistics(this.GetProperties6("Udp6"));
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x00004F46 File Offset: 0x00003146
		public override string DhcpScopeName
		{
			get
			{
				return string.Empty;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x00060084 File Offset: 0x0005E284
		public override string DomainName
		{
			get
			{
				byte[] array = new byte[256];
				if (MibIPGlobalProperties.getdomainname(array, 256) != 0)
				{
					throw new NetworkInformationException();
				}
				int num = Array.IndexOf<byte>(array, 0);
				return Encoding.ASCII.GetString(array, 0, (num >= 0) ? num : 256);
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x000600D8 File Offset: 0x0005E2D8
		public override string HostName
		{
			get
			{
				byte[] array = new byte[256];
				if (MibIPGlobalProperties.gethostname(array, 256) != 0)
				{
					throw new NetworkInformationException();
				}
				int num = Array.IndexOf<byte>(array, 0);
				return Encoding.ASCII.GetString(array, 0, (num >= 0) ? num : 256);
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool IsWinsProxy
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override NetBiosNodeType NodeType
		{
			get
			{
				return NetBiosNodeType.Unknown;
			}
		}

		// Token: 0x0400132F RID: 4911
		public const string ProcDir = "/proc";

		// Token: 0x04001330 RID: 4912
		public const string CompatProcDir = "/usr/compat/linux/proc";

		// Token: 0x04001331 RID: 4913
		public readonly string StatisticsFile;

		// Token: 0x04001332 RID: 4914
		public readonly string StatisticsFileIPv6;

		// Token: 0x04001333 RID: 4915
		public readonly string TcpFile;

		// Token: 0x04001334 RID: 4916
		public readonly string Tcp6File;

		// Token: 0x04001335 RID: 4917
		public readonly string UdpFile;

		// Token: 0x04001336 RID: 4918
		public readonly string Udp6File;

		// Token: 0x04001337 RID: 4919
		private static readonly char[] wsChars = new char[] { ' ', '\t' };
	}
}
