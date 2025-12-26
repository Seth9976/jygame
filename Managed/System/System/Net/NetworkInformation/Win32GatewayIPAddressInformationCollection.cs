using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000373 RID: 883
	internal class Win32GatewayIPAddressInformationCollection : GatewayIPAddressInformationCollection
	{
		// Token: 0x06001EBA RID: 7866 RVA: 0x0001660E File Offset: 0x0001480E
		private Win32GatewayIPAddressInformationCollection(bool isReadOnly)
		{
			this.is_readonly = isReadOnly;
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x0005F68C File Offset: 0x0005D88C
		public Win32GatewayIPAddressInformationCollection(params Win32_IP_ADDR_STRING[] al)
		{
			foreach (Win32_IP_ADDR_STRING win32_IP_ADDR_STRING in al)
			{
				if (!string.IsNullOrEmpty(win32_IP_ADDR_STRING.IpAddress))
				{
					this.Add(new GatewayIPAddressInformationImpl(IPAddress.Parse(win32_IP_ADDR_STRING.IpAddress)));
					this.AddSubsequently(win32_IP_ADDR_STRING.Next);
				}
			}
			this.is_readonly = true;
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x0005F704 File Offset: 0x0005D904
		private void AddSubsequently(IntPtr head)
		{
			IntPtr intPtr = head;
			while (intPtr != IntPtr.Zero)
			{
				Win32_IP_ADDR_STRING win32_IP_ADDR_STRING = (Win32_IP_ADDR_STRING)Marshal.PtrToStructure(intPtr, typeof(Win32_IP_ADDR_STRING));
				this.Add(new GatewayIPAddressInformationImpl(IPAddress.Parse(win32_IP_ADDR_STRING.IpAddress)));
				intPtr = win32_IP_ADDR_STRING.Next;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x0001662A File Offset: 0x0001482A
		public override bool IsReadOnly
		{
			get
			{
				return this.is_readonly;
			}
		}

		// Token: 0x040012F8 RID: 4856
		public static readonly Win32GatewayIPAddressInformationCollection Empty = new Win32GatewayIPAddressInformationCollection(true);

		// Token: 0x040012F9 RID: 4857
		private bool is_readonly;
	}
}
