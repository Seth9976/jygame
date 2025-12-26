using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200037B RID: 891
	internal struct Win32_MIBICMPSTATS
	{
		// Token: 0x04001302 RID: 4866
		public uint Msgs;

		// Token: 0x04001303 RID: 4867
		public uint Errors;

		// Token: 0x04001304 RID: 4868
		public uint DestUnreachs;

		// Token: 0x04001305 RID: 4869
		public uint TimeExcds;

		// Token: 0x04001306 RID: 4870
		public uint ParmProbs;

		// Token: 0x04001307 RID: 4871
		public uint SrcQuenchs;

		// Token: 0x04001308 RID: 4872
		public uint Redirects;

		// Token: 0x04001309 RID: 4873
		public uint Echos;

		// Token: 0x0400130A RID: 4874
		public uint EchoReps;

		// Token: 0x0400130B RID: 4875
		public uint Timestamps;

		// Token: 0x0400130C RID: 4876
		public uint TimestampReps;

		// Token: 0x0400130D RID: 4877
		public uint AddrMasks;

		// Token: 0x0400130E RID: 4878
		public uint AddrMaskReps;
	}
}
