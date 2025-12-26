using System;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003E4 RID: 996
	[StructLayout(LayoutKind.Explicit)]
	internal struct AlignmentUnion
	{
		// Token: 0x0400149C RID: 5276
		[FieldOffset(0)]
		public ulong Alignment;

		// Token: 0x0400149D RID: 5277
		[FieldOffset(0)]
		public int Length;

		// Token: 0x0400149E RID: 5278
		[FieldOffset(4)]
		public int IfIndex;
	}
}
