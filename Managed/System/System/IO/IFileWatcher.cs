using System;

namespace System.IO
{
	// Token: 0x0200028D RID: 653
	internal interface IFileWatcher
	{
		// Token: 0x060016DF RID: 5855
		void StartDispatching(FileSystemWatcher fsw);

		// Token: 0x060016E0 RID: 5856
		void StopDispatching(FileSystemWatcher fsw);
	}
}
