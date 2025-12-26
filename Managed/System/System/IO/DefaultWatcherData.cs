using System;
using System.Collections;

namespace System.IO
{
	// Token: 0x0200027F RID: 639
	internal class DefaultWatcherData
	{
		// Token: 0x04000706 RID: 1798
		public FileSystemWatcher FSW;

		// Token: 0x04000707 RID: 1799
		public string Directory;

		// Token: 0x04000708 RID: 1800
		public string FileMask;

		// Token: 0x04000709 RID: 1801
		public bool IncludeSubdirs;

		// Token: 0x0400070A RID: 1802
		public bool Enabled;

		// Token: 0x0400070B RID: 1803
		public bool NoWildcards;

		// Token: 0x0400070C RID: 1804
		public DateTime DisabledTime;

		// Token: 0x0400070D RID: 1805
		public Hashtable Files;
	}
}
