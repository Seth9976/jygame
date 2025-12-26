using System;

namespace System.Configuration
{
	// Token: 0x020001DF RID: 479
	internal enum UserConfigLocationOption : uint
	{
		// Token: 0x040004B6 RID: 1206
		Product = 32U,
		// Token: 0x040004B7 RID: 1207
		Product_VersionMajor,
		// Token: 0x040004B8 RID: 1208
		Product_VersionMinor,
		// Token: 0x040004B9 RID: 1209
		Product_VersionBuild = 36U,
		// Token: 0x040004BA RID: 1210
		Product_VersionRevision = 40U,
		// Token: 0x040004BB RID: 1211
		Company_Product = 48U,
		// Token: 0x040004BC RID: 1212
		Company_Product_VersionMajor,
		// Token: 0x040004BD RID: 1213
		Company_Product_VersionMinor,
		// Token: 0x040004BE RID: 1214
		Company_Product_VersionBuild = 52U,
		// Token: 0x040004BF RID: 1215
		Company_Product_VersionRevision = 56U,
		// Token: 0x040004C0 RID: 1216
		Evidence = 64U,
		// Token: 0x040004C1 RID: 1217
		Other = 32768U
	}
}
