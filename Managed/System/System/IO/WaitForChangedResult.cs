using System;

namespace System.IO
{
	/// <summary>Contains information on the change that occurred.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x020002B7 RID: 695
	public struct WaitForChangedResult
	{
		/// <summary>Gets or sets the type of change that occurred.</summary>
		/// <returns>One of the <see cref="T:System.IO.WatcherChangeTypes" /> values.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x00011D58 File Offset: 0x0000FF58
		// (set) Token: 0x060017FE RID: 6142 RVA: 0x00011D60 File Offset: 0x0000FF60
		public WatcherChangeTypes ChangeType
		{
			get
			{
				return this.changeType;
			}
			set
			{
				this.changeType = value;
			}
		}

		/// <summary>Gets or sets the name of the file or directory that changed.</summary>
		/// <returns>The name of the file or directory that changed.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x00011D69 File Offset: 0x0000FF69
		// (set) Token: 0x06001800 RID: 6144 RVA: 0x00011D71 File Offset: 0x0000FF71
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		/// <summary>Gets or sets the original name of the file or directory that was renamed.</summary>
		/// <returns>The original name of the file or directory that was renamed.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x00011D7A File Offset: 0x0000FF7A
		// (set) Token: 0x06001802 RID: 6146 RVA: 0x00011D82 File Offset: 0x0000FF82
		public string OldName
		{
			get
			{
				return this.oldName;
			}
			set
			{
				this.oldName = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether the wait operation timed out.</summary>
		/// <returns>true if the <see cref="M:System.IO.FileSystemWatcher.WaitForChanged(System.IO.WatcherChangeTypes)" /> method timed out; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x00011D8B File Offset: 0x0000FF8B
		// (set) Token: 0x06001804 RID: 6148 RVA: 0x00011D93 File Offset: 0x0000FF93
		public bool TimedOut
		{
			get
			{
				return this.timedOut;
			}
			set
			{
				this.timedOut = value;
			}
		}

		// Token: 0x04000F36 RID: 3894
		private WatcherChangeTypes changeType;

		// Token: 0x04000F37 RID: 3895
		private string name;

		// Token: 0x04000F38 RID: 3896
		private string oldName;

		// Token: 0x04000F39 RID: 3897
		private bool timedOut;
	}
}
