using System;

namespace System.Configuration
{
	// Token: 0x020001E6 RID: 486
	internal interface IConfigXmlNode
	{
		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x060010D3 RID: 4307
		string Filename { get; }

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060010D4 RID: 4308
		int LineNumber { get; }
	}
}
