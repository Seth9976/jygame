using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003EF RID: 1007
	internal struct Win32_SOCKET_ADDRESS
	{
		// Token: 0x06002210 RID: 8720 RVA: 0x00062E40 File Offset: 0x00061040
		public IPAddress GetIPAddress()
		{
			Win32_SOCKADDR win32_SOCKADDR = (Win32_SOCKADDR)Marshal.PtrToStructure(this.Sockaddr, typeof(Win32_SOCKADDR));
			byte[] array;
			if (win32_SOCKADDR.AddressFamily == 23)
			{
				array = new byte[16];
				Array.Copy(win32_SOCKADDR.AddressData, 6, array, 0, 16);
			}
			else
			{
				array = new byte[4];
				Array.Copy(win32_SOCKADDR.AddressData, 2, array, 0, 4);
			}
			return new IPAddress(array);
		}

		// Token: 0x04001502 RID: 5378
		private const int AF_INET6 = 23;

		// Token: 0x04001503 RID: 5379
		public IntPtr Sockaddr;

		// Token: 0x04001504 RID: 5380
		public int SockaddrLength;
	}
}
