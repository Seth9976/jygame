using System;

namespace System.Security.Cryptography
{
	// Token: 0x0200044D RID: 1101
	internal enum AsnDecodeStatus
	{
		// Token: 0x040017DD RID: 6109
		NotDecoded = -1,
		// Token: 0x040017DE RID: 6110
		Ok,
		// Token: 0x040017DF RID: 6111
		BadAsn,
		// Token: 0x040017E0 RID: 6112
		BadTag,
		// Token: 0x040017E1 RID: 6113
		BadLength,
		// Token: 0x040017E2 RID: 6114
		InformationNotAvailable
	}
}
