using System;

namespace System.IO
{
	// Token: 0x02000288 RID: 648
	internal class NullFileWatcher : IFileWatcher
	{
		// Token: 0x060016A2 RID: 5794 RVA: 0x000029F5 File Offset: 0x00000BF5
		public void StartDispatching(FileSystemWatcher fsw)
		{
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x000029F5 File Offset: 0x00000BF5
		public void StopDispatching(FileSystemWatcher fsw)
		{
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x000465EC File Offset: 0x000447EC
		public static bool GetInstance(out IFileWatcher watcher)
		{
			if (NullFileWatcher.instance != null)
			{
				watcher = NullFileWatcher.instance;
				return true;
			}
			IFileWatcher fileWatcher;
			watcher = (fileWatcher = new NullFileWatcher());
			NullFileWatcher.instance = fileWatcher;
			return true;
		}

		// Token: 0x04000735 RID: 1845
		private static IFileWatcher instance;
	}
}
