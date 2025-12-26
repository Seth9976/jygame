using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading;

namespace System.IO
{
	/// <summary>Listens to the file system change notifications and raises events when a directory, or file in a directory, changes.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x0200028B RID: 651
	[IODescription("")]
	[global::System.ComponentModel.DefaultEvent("Changed")]
	public class FileSystemWatcher : global::System.ComponentModel.Component, global::System.ComponentModel.ISupportInitialize
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileSystemWatcher" /> class.</summary>
		// Token: 0x060016AA RID: 5802 RVA: 0x0004661C File Offset: 0x0004481C
		public FileSystemWatcher()
		{
			this.notifyFilter = NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastWrite;
			this.enableRaisingEvents = false;
			this.filter = "*.*";
			this.includeSubdirectories = false;
			this.internalBufferSize = 8192;
			this.path = string.Empty;
			this.InitWatcher();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileSystemWatcher" /> class, given the specified directory to monitor.</summary>
		/// <param name="path">The directory to monitor, in standard or Universal Naming Convention (UNC) notation. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="path" /> parameter is null. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="path" /> parameter is an empty string ("").-or- The path specified through the <paramref name="path" /> parameter does not exist. </exception>
		// Token: 0x060016AB RID: 5803 RVA: 0x00011178 File Offset: 0x0000F378
		public FileSystemWatcher(string path)
			: this(path, "*.*")
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileSystemWatcher" /> class, given the specified directory and type of files to monitor.</summary>
		/// <param name="path">The directory to monitor, in standard or Universal Naming Convention (UNC) notation. </param>
		/// <param name="filter">The type of files to watch. For example, "*.txt" watches for changes to all text files. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="path" /> parameter is null.-or- The <paramref name="filter" /> parameter is null. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="path" /> parameter is an empty string ("").-or- The path specified through the <paramref name="path" /> parameter does not exist. </exception>
		// Token: 0x060016AC RID: 5804 RVA: 0x0004666C File Offset: 0x0004486C
		public FileSystemWatcher(string path, string filter)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (filter == null)
			{
				throw new ArgumentNullException("filter");
			}
			if (path == string.Empty)
			{
				throw new ArgumentException("Empty path", "path");
			}
			if (!Directory.Exists(path))
			{
				throw new ArgumentException("Directory does not exists", "path");
			}
			this.enableRaisingEvents = false;
			this.filter = filter;
			this.includeSubdirectories = false;
			this.internalBufferSize = 8192;
			this.notifyFilter = NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastWrite;
			this.path = path;
			this.synchronizingObject = null;
			this.InitWatcher();
		}

		/// <summary>Occurs when a file or directory in the specified <see cref="P:System.IO.FileSystemWatcher.Path" /> is changed.</summary>
		/// <filterpriority>2</filterpriority>
		// Token: 0x14000043 RID: 67
		// (add) Token: 0x060016AE RID: 5806 RVA: 0x00011192 File Offset: 0x0000F392
		// (remove) Token: 0x060016AF RID: 5807 RVA: 0x000111AB File Offset: 0x0000F3AB
		[IODescription("Occurs when a file/directory change matches the filter")]
		public event FileSystemEventHandler Changed;

		/// <summary>Occurs when a file or directory in the specified <see cref="P:System.IO.FileSystemWatcher.Path" /> is created.</summary>
		/// <filterpriority>2</filterpriority>
		// Token: 0x14000044 RID: 68
		// (add) Token: 0x060016B0 RID: 5808 RVA: 0x000111C4 File Offset: 0x0000F3C4
		// (remove) Token: 0x060016B1 RID: 5809 RVA: 0x000111DD File Offset: 0x0000F3DD
		[IODescription("Occurs when a file/directory creation matches the filter")]
		public event FileSystemEventHandler Created;

		/// <summary>Occurs when a file or directory in the specified <see cref="P:System.IO.FileSystemWatcher.Path" /> is deleted.</summary>
		/// <filterpriority>2</filterpriority>
		// Token: 0x14000045 RID: 69
		// (add) Token: 0x060016B2 RID: 5810 RVA: 0x000111F6 File Offset: 0x0000F3F6
		// (remove) Token: 0x060016B3 RID: 5811 RVA: 0x0001120F File Offset: 0x0000F40F
		[IODescription("Occurs when a file/directory deletion matches the filter")]
		public event FileSystemEventHandler Deleted;

		/// <summary>Occurs when the internal buffer overflows.</summary>
		/// <filterpriority>2</filterpriority>
		// Token: 0x14000046 RID: 70
		// (add) Token: 0x060016B4 RID: 5812 RVA: 0x00011228 File Offset: 0x0000F428
		// (remove) Token: 0x060016B5 RID: 5813 RVA: 0x00011241 File Offset: 0x0000F441
		[global::System.ComponentModel.Browsable(false)]
		public event ErrorEventHandler Error;

		/// <summary>Occurs when a file or directory in the specified <see cref="P:System.IO.FileSystemWatcher.Path" /> is renamed.</summary>
		/// <filterpriority>2</filterpriority>
		// Token: 0x14000047 RID: 71
		// (add) Token: 0x060016B6 RID: 5814 RVA: 0x0001125A File Offset: 0x0000F45A
		// (remove) Token: 0x060016B7 RID: 5815 RVA: 0x00011273 File Offset: 0x0000F473
		[IODescription("Occurs when a file/directory rename matches the filter")]
		public event RenamedEventHandler Renamed;

		// Token: 0x060016B8 RID: 5816 RVA: 0x00046718 File Offset: 0x00044918
		[PermissionSet(SecurityAction.Assert, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\">\n<IPermission class=\"System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\nversion=\"1\"\nRead=\"MONO_MANAGED_WATCHER\"\nWrite=\"\"/>\n</PermissionSet>\n")]
		private void InitWatcher()
		{
			object obj = FileSystemWatcher.lockobj;
			lock (obj)
			{
				if (FileSystemWatcher.watcher == null)
				{
					string environmentVariable = Environment.GetEnvironmentVariable("MONO_MANAGED_WATCHER");
					int num = 0;
					if (environmentVariable == null)
					{
						num = FileSystemWatcher.InternalSupportsFSW();
					}
					bool flag = false;
					switch (num)
					{
					case 1:
						flag = DefaultWatcher.GetInstance(out FileSystemWatcher.watcher);
						break;
					case 2:
						flag = FAMWatcher.GetInstance(out FileSystemWatcher.watcher, false);
						break;
					case 3:
						flag = KeventWatcher.GetInstance(out FileSystemWatcher.watcher);
						break;
					case 4:
						flag = FAMWatcher.GetInstance(out FileSystemWatcher.watcher, true);
						break;
					case 5:
						flag = InotifyWatcher.GetInstance(out FileSystemWatcher.watcher, true);
						break;
					}
					if (num == 0 || !flag)
					{
						if (string.Compare(environmentVariable, "disabled", true) == 0)
						{
							NullFileWatcher.GetInstance(out FileSystemWatcher.watcher);
						}
						else
						{
							DefaultWatcher.GetInstance(out FileSystemWatcher.watcher);
						}
					}
				}
			}
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x0001128C File Offset: 0x0000F48C
		[Conditional("DEBUG")]
		[Conditional("TRACE")]
		private void ShowWatcherInfo()
		{
			Console.WriteLine("Watcher implementation: {0}", (FileSystemWatcher.watcher == null) ? "<none>" : FileSystemWatcher.watcher.GetType().ToString());
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x000112BB File Offset: 0x0000F4BB
		// (set) Token: 0x060016BB RID: 5819 RVA: 0x000112C3 File Offset: 0x0000F4C3
		internal bool Waiting
		{
			get
			{
				return this.waiting;
			}
			set
			{
				this.waiting = value;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x00046828 File Offset: 0x00044A28
		internal string MangledFilter
		{
			get
			{
				if (this.filter != "*.*")
				{
					return this.filter;
				}
				if (this.mangledFilter != null)
				{
					return this.mangledFilter;
				}
				string text = "*.*";
				if (FileSystemWatcher.watcher.GetType() != typeof(WindowsWatcher))
				{
					text = "*";
				}
				return text;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x000112CC File Offset: 0x0000F4CC
		internal SearchPattern2 Pattern
		{
			get
			{
				if (this.pattern == null)
				{
					this.pattern = new SearchPattern2(this.MangledFilter);
				}
				return this.pattern;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x0004688C File Offset: 0x00044A8C
		internal string FullPath
		{
			get
			{
				if (this.fullpath == null)
				{
					if (this.path == null || this.path == string.Empty)
					{
						this.fullpath = Environment.CurrentDirectory;
					}
					else
					{
						this.fullpath = global::System.IO.Path.GetFullPath(this.path);
					}
				}
				return this.fullpath;
			}
		}

		/// <summary>Gets or sets a value indicating whether the component is enabled.</summary>
		/// <returns>true if the component is enabled; otherwise, false. The default is false. If you are using the component on a designer in Visual Studio 2005, the default is true.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.FileSystemWatcher" /> object has been disposed.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows NT or later.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The directory specified in <see cref="P:System.IO.FileSystemWatcher.Path" /> could not be found.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="P:System.IO.FileSystemWatcher.Path" /> has not been set or is invalid.</exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x000112F0 File Offset: 0x0000F4F0
		// (set) Token: 0x060016C0 RID: 5824 RVA: 0x000112F8 File Offset: 0x0000F4F8
		[IODescription("Flag to indicate if this instance is active")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool EnableRaisingEvents
		{
			get
			{
				return this.enableRaisingEvents;
			}
			set
			{
				if (value == this.enableRaisingEvents)
				{
					return;
				}
				this.enableRaisingEvents = value;
				if (value)
				{
					this.Start();
				}
				else
				{
					this.Stop();
				}
			}
		}

		/// <summary>Gets or sets the filter string used to determine what files are monitored in a directory.</summary>
		/// <returns>The filter string. The default is "*.*" (Watches all files.) </returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x00011325 File Offset: 0x0000F525
		// (set) Token: 0x060016C2 RID: 5826 RVA: 0x000468EC File Offset: 0x00044AEC
		[IODescription("File name filter pattern")]
		[global::System.ComponentModel.DefaultValue("*.*")]
		[global::System.ComponentModel.TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[global::System.ComponentModel.RecommendedAsConfigurable(true)]
		public string Filter
		{
			get
			{
				return this.filter;
			}
			set
			{
				if (value == null || value == string.Empty)
				{
					value = "*.*";
				}
				if (this.filter != value)
				{
					this.filter = value;
					this.pattern = null;
					this.mangledFilter = null;
				}
			}
		}

		/// <summary>Gets or sets a value indicating whether subdirectories within the specified path should be monitored.</summary>
		/// <returns>true if you want to monitor subdirectories; otherwise, false. The default is false.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x0001132D File Offset: 0x0000F52D
		// (set) Token: 0x060016C4 RID: 5828 RVA: 0x00011335 File Offset: 0x0000F535
		[IODescription("Flag to indicate we want to watch subdirectories")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool IncludeSubdirectories
		{
			get
			{
				return this.includeSubdirectories;
			}
			set
			{
				if (this.includeSubdirectories == value)
				{
					return;
				}
				this.includeSubdirectories = value;
				if (value && this.enableRaisingEvents)
				{
					this.Stop();
					this.Start();
				}
			}
		}

		/// <summary>Gets or sets the size of the internal buffer.</summary>
		/// <returns>The internal buffer size. The default is 8192 (8 KB).</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060016C5 RID: 5829 RVA: 0x00011368 File Offset: 0x0000F568
		// (set) Token: 0x060016C6 RID: 5830 RVA: 0x00011370 File Offset: 0x0000F570
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DefaultValue(8192)]
		public int InternalBufferSize
		{
			get
			{
				return this.internalBufferSize;
			}
			set
			{
				if (this.internalBufferSize == value)
				{
					return;
				}
				if (value < 4196)
				{
					value = 4196;
				}
				this.internalBufferSize = value;
				if (this.enableRaisingEvents)
				{
					this.Stop();
					this.Start();
				}
			}
		}

		/// <summary>Gets or sets the type of changes to watch for.</summary>
		/// <returns>One of the <see cref="T:System.IO.NotifyFilters" /> values. The default is the bitwise OR combination of LastWrite, FileName, and DirectoryName.</returns>
		/// <exception cref="T:System.ArgumentException">The value is not a valid bitwise OR combination of the <see cref="T:System.IO.NotifyFilters" /> values. </exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value that is being set is not valid.</exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060016C7 RID: 5831 RVA: 0x000113AF File Offset: 0x0000F5AF
		// (set) Token: 0x060016C8 RID: 5832 RVA: 0x000113B7 File Offset: 0x0000F5B7
		[IODescription("Flag to indicate which change event we want to monitor")]
		[global::System.ComponentModel.DefaultValue(NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastWrite)]
		public NotifyFilters NotifyFilter
		{
			get
			{
				return this.notifyFilter;
			}
			set
			{
				if (this.notifyFilter == value)
				{
					return;
				}
				this.notifyFilter = value;
				if (this.enableRaisingEvents)
				{
					this.Stop();
					this.Start();
				}
			}
		}

		/// <summary>Gets or sets the path of the directory to watch.</summary>
		/// <returns>The path to monitor. The default is an empty string ("").</returns>
		/// <exception cref="T:System.ArgumentException">The specified path does not exist or could not be found.-or- The specified path contains wildcard characters.-or- The specified path contains invalid path characters.</exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060016C9 RID: 5833 RVA: 0x000113E4 File Offset: 0x0000F5E4
		// (set) Token: 0x060016CA RID: 5834 RVA: 0x0004693C File Offset: 0x00044B3C
		[global::System.ComponentModel.TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[global::System.ComponentModel.Editor("System.Diagnostics.Design.FSWPathEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[global::System.ComponentModel.RecommendedAsConfigurable(true)]
		[IODescription("The directory to monitor")]
		[global::System.ComponentModel.DefaultValue("")]
		public string Path
		{
			get
			{
				return this.path;
			}
			set
			{
				if (this.path == value)
				{
					return;
				}
				bool flag = false;
				Exception ex = null;
				try
				{
					flag = Directory.Exists(value);
				}
				catch (Exception ex2)
				{
					ex = ex2;
				}
				if (ex != null)
				{
					throw new ArgumentException("Invalid directory name", "value", ex);
				}
				if (!flag)
				{
					throw new ArgumentException("Directory does not exists", "value");
				}
				this.path = value;
				this.fullpath = null;
				if (this.enableRaisingEvents)
				{
					this.Stop();
					this.Start();
				}
			}
		}

		/// <summary>Gets or sets an <see cref="T:System.ComponentModel.ISite" /> for the <see cref="T:System.IO.FileSystemWatcher" />.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.ISite" /> for the <see cref="T:System.IO.FileSystemWatcher" />.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060016CB RID: 5835 RVA: 0x000113EC File Offset: 0x0000F5EC
		// (set) Token: 0x060016CC RID: 5836 RVA: 0x000113F4 File Offset: 0x0000F5F4
		[global::System.ComponentModel.Browsable(false)]
		public override global::System.ComponentModel.ISite Site
		{
			get
			{
				return base.Site;
			}
			set
			{
				base.Site = value;
			}
		}

		/// <summary>Gets or sets the object used to marshal the event handler calls issued as a result of a directory change.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.ISynchronizeInvoke" /> that represents the object used to marshal the event handler calls issued as a result of a directory change. The default is null.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x000113FD File Offset: 0x0000F5FD
		// (set) Token: 0x060016CE RID: 5838 RVA: 0x00011405 File Offset: 0x0000F605
		[global::System.ComponentModel.Browsable(false)]
		[IODescription("The object used to marshal the event handler calls resulting from a directory change")]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.ComponentModel.ISynchronizeInvoke SynchronizingObject
		{
			get
			{
				return this.synchronizingObject;
			}
			set
			{
				this.synchronizingObject = value;
			}
		}

		/// <summary>Begins the initialization of a <see cref="T:System.IO.FileSystemWatcher" /> used on a form or used by another component. The initialization occurs at run time.</summary>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060016CF RID: 5839 RVA: 0x000029F5 File Offset: 0x00000BF5
		public void BeginInit()
		{
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.FileSystemWatcher" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
		// Token: 0x060016D0 RID: 5840 RVA: 0x0001140E File Offset: 0x0000F60E
		protected override void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				this.disposed = true;
				this.Stop();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x000469D8 File Offset: 0x00044BD8
		~FileSystemWatcher()
		{
			this.disposed = true;
			this.Stop();
		}

		/// <summary>Ends the initialization of a <see cref="T:System.IO.FileSystemWatcher" /> used on a form or used by another component. The initialization occurs at run time.</summary>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060016D2 RID: 5842 RVA: 0x000029F5 File Offset: 0x00000BF5
		public void EndInit()
		{
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x00046A10 File Offset: 0x00044C10
		private void RaiseEvent(Delegate ev, EventArgs arg, FileSystemWatcher.EventType evtype)
		{
			if (ev == null)
			{
				return;
			}
			if (this.synchronizingObject == null)
			{
				switch (evtype)
				{
				case FileSystemWatcher.EventType.FileSystemEvent:
					((FileSystemEventHandler)ev).BeginInvoke(this, (FileSystemEventArgs)arg, null, null);
					break;
				case FileSystemWatcher.EventType.ErrorEvent:
					((ErrorEventHandler)ev).BeginInvoke(this, (ErrorEventArgs)arg, null, null);
					break;
				case FileSystemWatcher.EventType.RenameEvent:
					((RenamedEventHandler)ev).BeginInvoke(this, (RenamedEventArgs)arg, null, null);
					break;
				}
				return;
			}
			this.synchronizingObject.BeginInvoke(ev, new object[] { this, arg });
		}

		/// <summary>Raises the <see cref="E:System.IO.FileSystemWatcher.Changed" /> event.</summary>
		/// <param name="e">A <see cref="T:System.IO.FileSystemEventArgs" /> that contains the event data. </param>
		// Token: 0x060016D4 RID: 5844 RVA: 0x0001142F File Offset: 0x0000F62F
		protected void OnChanged(FileSystemEventArgs e)
		{
			this.RaiseEvent(this.Changed, e, FileSystemWatcher.EventType.FileSystemEvent);
		}

		/// <summary>Raises the <see cref="E:System.IO.FileSystemWatcher.Created" /> event.</summary>
		/// <param name="e">A <see cref="T:System.IO.FileSystemEventArgs" /> that contains the event data. </param>
		// Token: 0x060016D5 RID: 5845 RVA: 0x0001143F File Offset: 0x0000F63F
		protected void OnCreated(FileSystemEventArgs e)
		{
			this.RaiseEvent(this.Created, e, FileSystemWatcher.EventType.FileSystemEvent);
		}

		/// <summary>Raises the <see cref="E:System.IO.FileSystemWatcher.Deleted" /> event.</summary>
		/// <param name="e">A <see cref="T:System.IO.FileSystemEventArgs" /> that contains the event data. </param>
		// Token: 0x060016D6 RID: 5846 RVA: 0x0001144F File Offset: 0x0000F64F
		protected void OnDeleted(FileSystemEventArgs e)
		{
			this.RaiseEvent(this.Deleted, e, FileSystemWatcher.EventType.FileSystemEvent);
		}

		/// <summary>Raises the <see cref="E:System.IO.FileSystemWatcher.Error" /> event.</summary>
		/// <param name="e">An <see cref="T:System.IO.ErrorEventArgs" /> that contains the event data. </param>
		// Token: 0x060016D7 RID: 5847 RVA: 0x0001145F File Offset: 0x0000F65F
		protected void OnError(ErrorEventArgs e)
		{
			this.RaiseEvent(this.Error, e, FileSystemWatcher.EventType.ErrorEvent);
		}

		/// <summary>Raises the <see cref="E:System.IO.FileSystemWatcher.Renamed" /> event.</summary>
		/// <param name="e">A <see cref="T:System.IO.RenamedEventArgs" /> that contains the event data. </param>
		// Token: 0x060016D8 RID: 5848 RVA: 0x0001146F File Offset: 0x0000F66F
		protected void OnRenamed(RenamedEventArgs e)
		{
			this.RaiseEvent(this.Renamed, e, FileSystemWatcher.EventType.RenameEvent);
		}

		/// <summary>A synchronous method that returns a structure that contains specific information on the change that occurred, given the type of change you want to monitor.</summary>
		/// <returns>A <see cref="T:System.IO.WaitForChangedResult" /> that contains specific information on the change that occurred.</returns>
		/// <param name="changeType">The <see cref="T:System.IO.WatcherChangeTypes" /> to watch for. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060016D9 RID: 5849 RVA: 0x0001147F File Offset: 0x0000F67F
		public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType)
		{
			return this.WaitForChanged(changeType, -1);
		}

		/// <summary>A synchronous method that returns a structure that contains specific information on the change that occurred, given the type of change you want to monitor and the time (in milliseconds) to wait before timing out.</summary>
		/// <returns>A <see cref="T:System.IO.WaitForChangedResult" /> that contains specific information on the change that occurred.</returns>
		/// <param name="changeType">The <see cref="T:System.IO.WatcherChangeTypes" /> to watch for. </param>
		/// <param name="timeout">The time (in milliseconds) to wait before timing out. </param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x060016DA RID: 5850 RVA: 0x00046AB4 File Offset: 0x00044CB4
		public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout)
		{
			WaitForChangedResult waitForChangedResult = default(WaitForChangedResult);
			bool flag = this.EnableRaisingEvents;
			if (!flag)
			{
				this.EnableRaisingEvents = true;
			}
			bool flag2;
			lock (this)
			{
				this.waiting = true;
				flag2 = Monitor.Wait(this, timeout);
				if (flag2)
				{
					waitForChangedResult = this.lastData;
				}
			}
			this.EnableRaisingEvents = flag;
			if (!flag2)
			{
				waitForChangedResult.TimedOut = true;
			}
			return waitForChangedResult;
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00046B34 File Offset: 0x00044D34
		internal void DispatchEvents(FileAction act, string filename, ref RenamedEventArgs renamed)
		{
			if (this.waiting)
			{
				this.lastData = default(WaitForChangedResult);
			}
			switch (act)
			{
			case FileAction.Added:
				this.lastData.Name = filename;
				this.lastData.ChangeType = WatcherChangeTypes.Created;
				this.OnCreated(new FileSystemEventArgs(WatcherChangeTypes.Created, this.path, filename));
				break;
			case FileAction.Removed:
				this.lastData.Name = filename;
				this.lastData.ChangeType = WatcherChangeTypes.Deleted;
				this.OnDeleted(new FileSystemEventArgs(WatcherChangeTypes.Deleted, this.path, filename));
				break;
			case FileAction.Modified:
				this.lastData.Name = filename;
				this.lastData.ChangeType = WatcherChangeTypes.Changed;
				this.OnChanged(new FileSystemEventArgs(WatcherChangeTypes.Changed, this.path, filename));
				break;
			case FileAction.RenamedOldName:
				if (renamed != null)
				{
					this.OnRenamed(renamed);
				}
				this.lastData.OldName = filename;
				this.lastData.ChangeType = WatcherChangeTypes.Renamed;
				renamed = new RenamedEventArgs(WatcherChangeTypes.Renamed, this.path, filename, string.Empty);
				break;
			case FileAction.RenamedNewName:
				this.lastData.Name = filename;
				this.lastData.ChangeType = WatcherChangeTypes.Renamed;
				if (renamed == null)
				{
					renamed = new RenamedEventArgs(WatcherChangeTypes.Renamed, this.path, string.Empty, filename);
				}
				this.OnRenamed(renamed);
				renamed = null;
				break;
			}
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00011489 File Offset: 0x0000F689
		private void Start()
		{
			FileSystemWatcher.watcher.StartDispatching(this);
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x00011496 File Offset: 0x0000F696
		private void Stop()
		{
			FileSystemWatcher.watcher.StopDispatching(this);
		}

		// Token: 0x060016DE RID: 5854
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int InternalSupportsFSW();

		// Token: 0x0400073F RID: 1855
		private bool enableRaisingEvents;

		// Token: 0x04000740 RID: 1856
		private string filter;

		// Token: 0x04000741 RID: 1857
		private bool includeSubdirectories;

		// Token: 0x04000742 RID: 1858
		private int internalBufferSize;

		// Token: 0x04000743 RID: 1859
		private NotifyFilters notifyFilter;

		// Token: 0x04000744 RID: 1860
		private string path;

		// Token: 0x04000745 RID: 1861
		private string fullpath;

		// Token: 0x04000746 RID: 1862
		private global::System.ComponentModel.ISynchronizeInvoke synchronizingObject;

		// Token: 0x04000747 RID: 1863
		private WaitForChangedResult lastData;

		// Token: 0x04000748 RID: 1864
		private bool waiting;

		// Token: 0x04000749 RID: 1865
		private SearchPattern2 pattern;

		// Token: 0x0400074A RID: 1866
		private bool disposed;

		// Token: 0x0400074B RID: 1867
		private string mangledFilter;

		// Token: 0x0400074C RID: 1868
		private static IFileWatcher watcher;

		// Token: 0x0400074D RID: 1869
		private static object lockobj = new object();

		// Token: 0x0200028C RID: 652
		private enum EventType
		{
			// Token: 0x04000754 RID: 1876
			FileSystemEvent,
			// Token: 0x04000755 RID: 1877
			ErrorEvent,
			// Token: 0x04000756 RID: 1878
			RenameEvent
		}
	}
}
