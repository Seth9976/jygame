using System;
using System.Collections;

namespace System.IO
{
	// Token: 0x0200029A RID: 666
	internal class KeventData
	{
		// Token: 0x04000792 RID: 1938
		public FileSystemWatcher FSW;

		// Token: 0x04000793 RID: 1939
		public string Directory;

		// Token: 0x04000794 RID: 1940
		public string FileMask;

		// Token: 0x04000795 RID: 1941
		public bool IncludeSubdirs;

		// Token: 0x04000796 RID: 1942
		public bool Enabled;

		// Token: 0x04000797 RID: 1943
		public Hashtable DirEntries;

		// Token: 0x04000798 RID: 1944
		public kevent ev;
	}
}
