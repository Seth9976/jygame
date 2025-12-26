using System;
using System.Collections;

namespace System.IO
{
	// Token: 0x02000290 RID: 656
	internal class ParentInotifyData
	{
		// Token: 0x04000771 RID: 1905
		public bool IncludeSubdirs;

		// Token: 0x04000772 RID: 1906
		public bool Enabled;

		// Token: 0x04000773 RID: 1907
		public ArrayList children;

		// Token: 0x04000774 RID: 1908
		public InotifyData data;
	}
}
