using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation.MacOsStructs
{
	// Token: 0x020003B2 RID: 946
	internal struct sockaddr_dl
	{
		// Token: 0x040013CE RID: 5070
		public byte sdl_len;

		// Token: 0x040013CF RID: 5071
		public byte sdl_family;

		// Token: 0x040013D0 RID: 5072
		public ushort sdl_index;

		// Token: 0x040013D1 RID: 5073
		public byte sdl_type;

		// Token: 0x040013D2 RID: 5074
		public byte sdl_nlen;

		// Token: 0x040013D3 RID: 5075
		public byte sdl_alen;

		// Token: 0x040013D4 RID: 5076
		public byte sdl_slen;

		// Token: 0x040013D5 RID: 5077
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
		public byte[] sdl_data;
	}
}
