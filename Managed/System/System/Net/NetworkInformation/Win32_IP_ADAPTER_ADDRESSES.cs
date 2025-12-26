using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003E5 RID: 997
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal class Win32_IP_ADAPTER_ADDRESSES
	{
		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x0600220A RID: 8714 RVA: 0x0001837E File Offset: 0x0001657E
		public bool DdnsEnabled
		{
			get
			{
				return (this.Flags & 1U) != 0U;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x0001838E File Offset: 0x0001658E
		public bool IsReceiveOnly
		{
			get
			{
				return (this.Flags & 8U) != 0U;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x0600220C RID: 8716 RVA: 0x0001839E File Offset: 0x0001659E
		public bool NoMulticast
		{
			get
			{
				return (this.Flags & 16U) != 0U;
			}
		}

		// Token: 0x0400149F RID: 5279
		private const int MAX_ADAPTER_ADDRESS_LENGTH = 8;

		// Token: 0x040014A0 RID: 5280
		private const int IP_ADAPTER_DDNS_ENABLED = 1;

		// Token: 0x040014A1 RID: 5281
		private const int IP_ADAPTER_RECEIVE_ONLY = 8;

		// Token: 0x040014A2 RID: 5282
		private const int IP_ADAPTER_NO_MULTICAST = 16;

		// Token: 0x040014A3 RID: 5283
		public AlignmentUnion Alignment;

		// Token: 0x040014A4 RID: 5284
		public IntPtr Next;

		// Token: 0x040014A5 RID: 5285
		[MarshalAs(UnmanagedType.LPStr)]
		public string AdapterName;

		// Token: 0x040014A6 RID: 5286
		public IntPtr FirstUnicastAddress;

		// Token: 0x040014A7 RID: 5287
		public IntPtr FirstAnycastAddress;

		// Token: 0x040014A8 RID: 5288
		public IntPtr FirstMulticastAddress;

		// Token: 0x040014A9 RID: 5289
		public IntPtr FirstDnsServerAddress;

		// Token: 0x040014AA RID: 5290
		public string DnsSuffix;

		// Token: 0x040014AB RID: 5291
		public string Description;

		// Token: 0x040014AC RID: 5292
		public string FriendlyName;

		// Token: 0x040014AD RID: 5293
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] PhysicalAddress;

		// Token: 0x040014AE RID: 5294
		public uint PhysicalAddressLength;

		// Token: 0x040014AF RID: 5295
		public uint Flags;

		// Token: 0x040014B0 RID: 5296
		public uint Mtu;

		// Token: 0x040014B1 RID: 5297
		public NetworkInterfaceType IfType;

		// Token: 0x040014B2 RID: 5298
		public OperationalStatus OperStatus;

		// Token: 0x040014B3 RID: 5299
		public int Ipv6IfIndex;

		// Token: 0x040014B4 RID: 5300
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		public uint[] ZoneIndices;
	}
}
