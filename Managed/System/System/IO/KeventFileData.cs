using System;

namespace System.IO
{
	// Token: 0x02000299 RID: 665
	internal class KeventFileData
	{
		// Token: 0x0600170C RID: 5900 RVA: 0x00011595 File Offset: 0x0000F795
		public KeventFileData(FileSystemInfo fsi, DateTime LastAccessTime, DateTime LastWriteTime)
		{
			this.fsi = fsi;
			this.LastAccessTime = LastAccessTime;
			this.LastWriteTime = LastWriteTime;
		}

		// Token: 0x0400078F RID: 1935
		public FileSystemInfo fsi;

		// Token: 0x04000790 RID: 1936
		public DateTime LastAccessTime;

		// Token: 0x04000791 RID: 1937
		public DateTime LastWriteTime;
	}
}
