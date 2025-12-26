using System;

namespace System.IO
{
	/// <summary>Provides data for the <see cref="E:System.IO.FileSystemWatcher.Renamed" /> event.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x020002B3 RID: 691
	public class RenamedEventArgs : FileSystemEventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.RenamedEventArgs" /> class.</summary>
		/// <param name="changeType">One of the <see cref="T:System.IO.WatcherChangeTypes" /> values. </param>
		/// <param name="directory">The name of the affected file or directory. </param>
		/// <param name="name">The name of the affected file or directory. </param>
		/// <param name="oldName">The old name of the affected file or directory. </param>
		// Token: 0x060017F1 RID: 6129 RVA: 0x00011C9A File Offset: 0x0000FE9A
		public RenamedEventArgs(WatcherChangeTypes changeType, string directory, string name, string oldName)
			: base(changeType, directory, name)
		{
			this.oldName = oldName;
			this.oldFullPath = Path.Combine(directory, oldName);
		}

		/// <summary>Gets the previous fully qualified path of the affected file or directory.</summary>
		/// <returns>The previous fully qualified path of the affected file or directory.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x00011CBB File Offset: 0x0000FEBB
		public string OldFullPath
		{
			get
			{
				return this.oldFullPath;
			}
		}

		/// <summary>Gets the old name of the affected file or directory.</summary>
		/// <returns>The previous name of the affected file or directory.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060017F3 RID: 6131 RVA: 0x00011CC3 File Offset: 0x0000FEC3
		public string OldName
		{
			get
			{
				return this.oldName;
			}
		}

		// Token: 0x04000F25 RID: 3877
		private string oldName;

		// Token: 0x04000F26 RID: 3878
		private string oldFullPath;
	}
}
