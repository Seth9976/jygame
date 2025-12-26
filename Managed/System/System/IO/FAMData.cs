using System;
using System.Collections;

namespace System.IO
{
	// Token: 0x02000286 RID: 646
	internal class FAMData
	{
		// Token: 0x04000725 RID: 1829
		public FileSystemWatcher FSW;

		// Token: 0x04000726 RID: 1830
		public string Directory;

		// Token: 0x04000727 RID: 1831
		public string FileMask;

		// Token: 0x04000728 RID: 1832
		public bool IncludeSubdirs;

		// Token: 0x04000729 RID: 1833
		public bool Enabled;

		// Token: 0x0400072A RID: 1834
		public FAMRequest Request;

		// Token: 0x0400072B RID: 1835
		public Hashtable SubDirs;
	}
}
