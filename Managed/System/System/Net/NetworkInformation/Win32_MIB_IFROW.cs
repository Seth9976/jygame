using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003E7 RID: 999
	internal struct Win32_MIB_IFROW
	{
		// Token: 0x040014CA RID: 5322
		private const int MAX_INTERFACE_NAME_LEN = 256;

		// Token: 0x040014CB RID: 5323
		private const int MAXLEN_PHYSADDR = 8;

		// Token: 0x040014CC RID: 5324
		private const int MAXLEN_IFDESCR = 256;

		// Token: 0x040014CD RID: 5325
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public char[] Name;

		// Token: 0x040014CE RID: 5326
		public int Index;

		// Token: 0x040014CF RID: 5327
		public NetworkInterfaceType Type;

		// Token: 0x040014D0 RID: 5328
		public int Mtu;

		// Token: 0x040014D1 RID: 5329
		public uint Speed;

		// Token: 0x040014D2 RID: 5330
		public int PhysAddrLen;

		// Token: 0x040014D3 RID: 5331
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] PhysAddr;

		// Token: 0x040014D4 RID: 5332
		public uint AdminStatus;

		// Token: 0x040014D5 RID: 5333
		public uint OperStatus;

		// Token: 0x040014D6 RID: 5334
		public uint LastChange;

		// Token: 0x040014D7 RID: 5335
		public int InOctets;

		// Token: 0x040014D8 RID: 5336
		public int InUcastPkts;

		// Token: 0x040014D9 RID: 5337
		public int InNUcastPkts;

		// Token: 0x040014DA RID: 5338
		public int InDiscards;

		// Token: 0x040014DB RID: 5339
		public int InErrors;

		// Token: 0x040014DC RID: 5340
		public int InUnknownProtos;

		// Token: 0x040014DD RID: 5341
		public int OutOctets;

		// Token: 0x040014DE RID: 5342
		public int OutUcastPkts;

		// Token: 0x040014DF RID: 5343
		public int OutNUcastPkts;

		// Token: 0x040014E0 RID: 5344
		public int OutDiscards;

		// Token: 0x040014E1 RID: 5345
		public int OutErrors;

		// Token: 0x040014E2 RID: 5346
		public int OutQLen;

		// Token: 0x040014E3 RID: 5347
		public int DescrLen;

		// Token: 0x040014E4 RID: 5348
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		public byte[] Descr;
	}
}
