using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003E6 RID: 998
	[StructLayout(LayoutKind.Sequential)]
	internal class Win32_IP_ADAPTER_INFO
	{
		// Token: 0x040014B5 RID: 5301
		private const int MAX_ADAPTER_NAME_LENGTH = 256;

		// Token: 0x040014B6 RID: 5302
		private const int MAX_ADAPTER_DESCRIPTION_LENGTH = 128;

		// Token: 0x040014B7 RID: 5303
		private const int MAX_ADAPTER_ADDRESS_LENGTH = 8;

		// Token: 0x040014B8 RID: 5304
		public IntPtr Next;

		// Token: 0x040014B9 RID: 5305
		public int ComboIndex;

		// Token: 0x040014BA RID: 5306
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string AdapterName;

		// Token: 0x040014BB RID: 5307
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 132)]
		public string Description;

		// Token: 0x040014BC RID: 5308
		public uint AddressLength;

		// Token: 0x040014BD RID: 5309
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] Address;

		// Token: 0x040014BE RID: 5310
		public uint Index;

		// Token: 0x040014BF RID: 5311
		public uint Type;

		// Token: 0x040014C0 RID: 5312
		public uint DhcpEnabled;

		// Token: 0x040014C1 RID: 5313
		public IntPtr CurrentIpAddress;

		// Token: 0x040014C2 RID: 5314
		public Win32_IP_ADDR_STRING IpAddressList;

		// Token: 0x040014C3 RID: 5315
		public Win32_IP_ADDR_STRING GatewayList;

		// Token: 0x040014C4 RID: 5316
		public Win32_IP_ADDR_STRING DhcpServer;

		// Token: 0x040014C5 RID: 5317
		public bool HaveWins;

		// Token: 0x040014C6 RID: 5318
		public Win32_IP_ADDR_STRING PrimaryWinsServer;

		// Token: 0x040014C7 RID: 5319
		public Win32_IP_ADDR_STRING SecondaryWinsServer;

		// Token: 0x040014C8 RID: 5320
		public long LeaseObtained;

		// Token: 0x040014C9 RID: 5321
		public long LeaseExpires;
	}
}
