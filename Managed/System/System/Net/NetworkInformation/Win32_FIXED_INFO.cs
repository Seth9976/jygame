using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003E3 RID: 995
	[StructLayout(LayoutKind.Sequential)]
	internal class Win32_FIXED_INFO
	{
		// Token: 0x06002206 RID: 8710
		[DllImport("iphlpapi.dll", SetLastError = true)]
		private static extern int GetNetworkParams(byte[] bytes, ref int size);

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x00018363 File Offset: 0x00016563
		public static Win32_FIXED_INFO Instance
		{
			get
			{
				if (Win32_FIXED_INFO.fixed_info == null)
				{
					Win32_FIXED_INFO.fixed_info = Win32_FIXED_INFO.GetInstance();
				}
				return Win32_FIXED_INFO.fixed_info;
			}
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x00062DE0 File Offset: 0x00060FE0
		private unsafe static Win32_FIXED_INFO GetInstance()
		{
			int num = 0;
			Win32_FIXED_INFO.GetNetworkParams(null, ref num);
			byte[] array = new byte[num];
			Win32_FIXED_INFO.GetNetworkParams(array, ref num);
			Win32_FIXED_INFO win32_FIXED_INFO = new Win32_FIXED_INFO();
			fixed (byte* ptr = (ref array != null && array.Length != 0 ? ref array[0] : ref *null))
			{
				Marshal.PtrToStructure((IntPtr)((void*)ptr), win32_FIXED_INFO);
			}
			return win32_FIXED_INFO;
		}

		// Token: 0x0400148F RID: 5263
		private const int MAX_HOSTNAME_LEN = 128;

		// Token: 0x04001490 RID: 5264
		private const int MAX_DOMAIN_NAME_LEN = 128;

		// Token: 0x04001491 RID: 5265
		private const int MAX_SCOPE_ID_LEN = 256;

		// Token: 0x04001492 RID: 5266
		private static Win32_FIXED_INFO fixed_info;

		// Token: 0x04001493 RID: 5267
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 132)]
		public string HostName;

		// Token: 0x04001494 RID: 5268
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 132)]
		public string DomainName;

		// Token: 0x04001495 RID: 5269
		public IntPtr CurrentDnsServer;

		// Token: 0x04001496 RID: 5270
		public Win32_IP_ADDR_STRING DnsServerList;

		// Token: 0x04001497 RID: 5271
		public NetBiosNodeType NodeType;

		// Token: 0x04001498 RID: 5272
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string ScopeId;

		// Token: 0x04001499 RID: 5273
		public uint EnableRouting;

		// Token: 0x0400149A RID: 5274
		public uint EnableProxy;

		// Token: 0x0400149B RID: 5275
		public uint EnableDns;
	}
}
