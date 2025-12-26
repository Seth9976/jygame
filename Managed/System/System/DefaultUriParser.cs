using System;

namespace System
{
	// Token: 0x02000210 RID: 528
	internal class DefaultUriParser : global::System.UriParser
	{
		// Token: 0x060011A7 RID: 4519 RVA: 0x0000E3F3 File Offset: 0x0000C5F3
		public DefaultUriParser()
		{
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0000E3FB File Offset: 0x0000C5FB
		public DefaultUriParser(string scheme)
		{
			this.scheme_name = scheme;
		}
	}
}
