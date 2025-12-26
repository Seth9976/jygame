using System;

namespace System.IO
{
	/// <summary>Specifies changes to watch for in a file or folder.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x020002A1 RID: 673
	[Flags]
	public enum NotifyFilters
	{
		/// <summary>The attributes of the file or folder.</summary>
		// Token: 0x04000E98 RID: 3736
		Attributes = 4,
		/// <summary>The time the file or folder was created.</summary>
		// Token: 0x04000E99 RID: 3737
		CreationTime = 64,
		/// <summary>The name of the directory.</summary>
		// Token: 0x04000E9A RID: 3738
		DirectoryName = 2,
		/// <summary>The name of the file.</summary>
		// Token: 0x04000E9B RID: 3739
		FileName = 1,
		/// <summary>The date the file or folder was last opened.</summary>
		// Token: 0x04000E9C RID: 3740
		LastAccess = 32,
		/// <summary>The date the file or folder last had anything written to it.</summary>
		// Token: 0x04000E9D RID: 3741
		LastWrite = 16,
		/// <summary>The security settings of the file or folder.</summary>
		// Token: 0x04000E9E RID: 3742
		Security = 256,
		/// <summary>The size of the file or folder.</summary>
		// Token: 0x04000E9F RID: 3743
		Size = 8
	}
}
