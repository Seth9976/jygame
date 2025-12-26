using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003D9 RID: 985
	internal struct Win32_MIB_TCPSTATS
	{
		// Token: 0x04001473 RID: 5235
		public uint RtoAlgorithm;

		// Token: 0x04001474 RID: 5236
		public uint RtoMin;

		// Token: 0x04001475 RID: 5237
		public uint RtoMax;

		// Token: 0x04001476 RID: 5238
		public uint MaxConn;

		// Token: 0x04001477 RID: 5239
		public uint ActiveOpens;

		// Token: 0x04001478 RID: 5240
		public uint PassiveOpens;

		// Token: 0x04001479 RID: 5241
		public uint AttemptFails;

		// Token: 0x0400147A RID: 5242
		public uint EstabResets;

		// Token: 0x0400147B RID: 5243
		public uint CurrEstab;

		// Token: 0x0400147C RID: 5244
		public uint InSegs;

		// Token: 0x0400147D RID: 5245
		public uint OutSegs;

		// Token: 0x0400147E RID: 5246
		public uint RetransSegs;

		// Token: 0x0400147F RID: 5247
		public uint InErrs;

		// Token: 0x04001480 RID: 5248
		public uint OutRsts;

		// Token: 0x04001481 RID: 5249
		public uint NumConns;
	}
}
