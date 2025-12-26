using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000385 RID: 901
	internal class IPAddressInformationImplCollection : IPAddressInformationCollection
	{
		// Token: 0x06001F9D RID: 8093 RVA: 0x00016FD0 File Offset: 0x000151D0
		private IPAddressInformationImplCollection(bool isReadOnly)
		{
			this.is_readonly = isReadOnly;
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x00016FEC File Offset: 0x000151EC
		public override bool IsReadOnly
		{
			get
			{
				return this.is_readonly;
			}
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x0005F990 File Offset: 0x0005DB90
		public static IPAddressInformationCollection Win32FromAnycast(IntPtr ptr)
		{
			IPAddressInformationImplCollection ipaddressInformationImplCollection = new IPAddressInformationImplCollection(false);
			IntPtr intPtr = ptr;
			while (intPtr != IntPtr.Zero)
			{
				Win32_IP_ADAPTER_ANYCAST_ADDRESS win32_IP_ADAPTER_ANYCAST_ADDRESS = (Win32_IP_ADAPTER_ANYCAST_ADDRESS)Marshal.PtrToStructure(intPtr, typeof(Win32_IP_ADAPTER_ANYCAST_ADDRESS));
				ipaddressInformationImplCollection.Add(new IPAddressInformationImpl(win32_IP_ADAPTER_ANYCAST_ADDRESS.Address.GetIPAddress(), win32_IP_ADAPTER_ANYCAST_ADDRESS.LengthFlags.IsDnsEligible, win32_IP_ADAPTER_ANYCAST_ADDRESS.LengthFlags.IsTransient));
				intPtr = win32_IP_ADAPTER_ANYCAST_ADDRESS.Next;
			}
			ipaddressInformationImplCollection.is_readonly = true;
			return ipaddressInformationImplCollection;
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x0005FA10 File Offset: 0x0005DC10
		public static IPAddressInformationImplCollection LinuxFromAnycast(IList<IPAddress> addresses)
		{
			IPAddressInformationImplCollection ipaddressInformationImplCollection = new IPAddressInformationImplCollection(false);
			foreach (IPAddress ipaddress in addresses)
			{
				ipaddressInformationImplCollection.Add(new IPAddressInformationImpl(ipaddress, false, false));
			}
			ipaddressInformationImplCollection.is_readonly = true;
			return ipaddressInformationImplCollection;
		}

		// Token: 0x0400132A RID: 4906
		public static readonly IPAddressInformationImplCollection Empty = new IPAddressInformationImplCollection(true);

		// Token: 0x0400132B RID: 4907
		private bool is_readonly;
	}
}
