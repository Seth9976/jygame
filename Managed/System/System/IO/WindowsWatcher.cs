using System;

namespace System.IO
{
	// Token: 0x020002B9 RID: 697
	internal class WindowsWatcher : IFileWatcher
	{
		// Token: 0x06001805 RID: 6149 RVA: 0x000021C3 File Offset: 0x000003C3
		private WindowsWatcher()
		{
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00006A38 File Offset: 0x00004C38
		public static bool GetInstance(out IFileWatcher watcher)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x000029F5 File Offset: 0x00000BF5
		public void StartDispatching(FileSystemWatcher fsw)
		{
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x000029F5 File Offset: 0x00000BF5
		public void StopDispatching(FileSystemWatcher fsw)
		{
		}
	}
}
