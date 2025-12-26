using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Networking
{
	// Token: 0x02000033 RID: 51
	[StructLayout(LayoutKind.Explicit)]
	internal struct UIntFloat
	{
		// Token: 0x0400009C RID: 156
		[FieldOffset(0)]
		public float floatValue;

		// Token: 0x0400009D RID: 157
		[FieldOffset(0)]
		public uint intValue;

		// Token: 0x0400009E RID: 158
		[FieldOffset(0)]
		public double doubleValue;

		// Token: 0x0400009F RID: 159
		[FieldOffset(0)]
		public ulong longValue;
	}
}
