using System;

namespace System.IO
{
	/// <summary>Provides data for the directory events: <see cref="E:System.IO.FileSystemWatcher.Changed" />, <see cref="E:System.IO.FileSystemWatcher.Created" />, <see cref="E:System.IO.FileSystemWatcher.Deleted" />.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x0200028A RID: 650
	public class FileSystemEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileSystemEventArgs" /> class.</summary>
		/// <param name="changeType">One of the <see cref="T:System.IO.WatcherChangeTypes" /> values, which represents the kind of change detected in the file system. </param>
		/// <param name="directory">The root directory of the affected file or directory. </param>
		/// <param name="name">The name of the affected file or directory. </param>
		// Token: 0x060016A5 RID: 5797 RVA: 0x0001112F File Offset: 0x0000F32F
		public FileSystemEventArgs(WatcherChangeTypes changeType, string directory, string name)
		{
			this.changeType = changeType;
			this.directory = directory;
			this.name = name;
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x0001114C File Offset: 0x0000F34C
		internal void SetName(string name)
		{
			this.name = name;
		}

		/// <summary>Gets the type of directory event that occurred.</summary>
		/// <returns>One of the <see cref="T:System.IO.WatcherChangeTypes" /> values that represents the kind of change detected in the file system.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x00011155 File Offset: 0x0000F355
		public WatcherChangeTypes ChangeType
		{
			get
			{
				return this.changeType;
			}
		}

		/// <summary>Gets the fully qualifed path of the affected file or directory.</summary>
		/// <returns>The path of the affected file or directory.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x0001115D File Offset: 0x0000F35D
		public string FullPath
		{
			get
			{
				return Path.Combine(this.directory, this.name);
			}
		}

		/// <summary>Gets the name of the affected file or directory.</summary>
		/// <returns>The name of the affected file or directory.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060016A9 RID: 5801 RVA: 0x00011170 File Offset: 0x0000F370
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x0400073C RID: 1852
		private WatcherChangeTypes changeType;

		// Token: 0x0400073D RID: 1853
		private string directory;

		// Token: 0x0400073E RID: 1854
		private string name;
	}
}
