using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003ED RID: 1005
	internal struct Win32_IP_ADAPTER_UNICAST_ADDRESS
	{
		// Token: 0x040014F6 RID: 5366
		public Win32LengthFlagsUnion LengthFlags;

		// Token: 0x040014F7 RID: 5367
		public IntPtr Next;

		// Token: 0x040014F8 RID: 5368
		public Win32_SOCKET_ADDRESS Address;

		// Token: 0x040014F9 RID: 5369
		public PrefixOrigin PrefixOrigin;

		// Token: 0x040014FA RID: 5370
		public SuffixOrigin SuffixOrigin;

		// Token: 0x040014FB RID: 5371
		public DuplicateAddressDetectionState DadState;

		// Token: 0x040014FC RID: 5372
		public uint ValidLifetime;

		// Token: 0x040014FD RID: 5373
		public uint PreferredLifetime;

		// Token: 0x040014FE RID: 5374
		public uint LeaseLifetime;

		// Token: 0x040014FF RID: 5375
		public byte OnLinkPrefixLength;
	}
}
