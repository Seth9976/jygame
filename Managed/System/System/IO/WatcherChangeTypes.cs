using System;

namespace System.IO
{
	/// <summary>Changes that might occur to a file or directory.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x020002B8 RID: 696
	[Flags]
	public enum WatcherChangeTypes
	{
		/// <summary>The creation, deletion, change, or renaming of a file or folder.</summary>
		// Token: 0x04000F3B RID: 3899
		All = 15,
		/// <summary>The change of a file or folder. The types of changes include: changes to size, attributes, security settings, last write, and last access time.</summary>
		// Token: 0x04000F3C RID: 3900
		Changed = 4,
		/// <summary>The creation of a file or folder.</summary>
		// Token: 0x04000F3D RID: 3901
		Created = 1,
		/// <summary>The deletion of a file or folder.</summary>
		// Token: 0x04000F3E RID: 3902
		Deleted = 2,
		/// <summary>The renaming of a file or folder.</summary>
		// Token: 0x04000F3F RID: 3903
		Renamed = 8
	}
}
