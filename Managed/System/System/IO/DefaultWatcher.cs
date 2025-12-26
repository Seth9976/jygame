using System;
using System.Collections;
using System.Threading;

namespace System.IO
{
	// Token: 0x02000281 RID: 641
	internal class DefaultWatcher : IFileWatcher
	{
		// Token: 0x0600167B RID: 5755 RVA: 0x000021C3 File Offset: 0x000003C3
		private DefaultWatcher()
		{
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x0001104E File Offset: 0x0000F24E
		public static bool GetInstance(out IFileWatcher watcher)
		{
			if (DefaultWatcher.instance != null)
			{
				watcher = DefaultWatcher.instance;
				return true;
			}
			DefaultWatcher.instance = new DefaultWatcher();
			watcher = DefaultWatcher.instance;
			return true;
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00045480 File Offset: 0x00043680
		public void StartDispatching(FileSystemWatcher fsw)
		{
			lock (this)
			{
				if (DefaultWatcher.watches == null)
				{
					DefaultWatcher.watches = new Hashtable();
				}
				if (DefaultWatcher.thread == null)
				{
					DefaultWatcher.thread = new Thread(new ThreadStart(this.Monitor));
					DefaultWatcher.thread.IsBackground = true;
					DefaultWatcher.thread.Start();
				}
			}
			Hashtable hashtable = DefaultWatcher.watches;
			lock (hashtable)
			{
				DefaultWatcherData defaultWatcherData = (DefaultWatcherData)DefaultWatcher.watches[fsw];
				if (defaultWatcherData == null)
				{
					defaultWatcherData = new DefaultWatcherData();
					defaultWatcherData.Files = new Hashtable();
					DefaultWatcher.watches[fsw] = defaultWatcherData;
				}
				defaultWatcherData.FSW = fsw;
				defaultWatcherData.Directory = fsw.FullPath;
				defaultWatcherData.NoWildcards = !fsw.Pattern.HasWildcard;
				if (defaultWatcherData.NoWildcards)
				{
					defaultWatcherData.FileMask = Path.Combine(defaultWatcherData.Directory, fsw.MangledFilter);
				}
				else
				{
					defaultWatcherData.FileMask = fsw.MangledFilter;
				}
				defaultWatcherData.IncludeSubdirs = fsw.IncludeSubdirectories;
				defaultWatcherData.Enabled = true;
				defaultWatcherData.DisabledTime = DateTime.MaxValue;
				this.UpdateDataAndDispatch(defaultWatcherData, false);
			}
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x000455D4 File Offset: 0x000437D4
		public void StopDispatching(FileSystemWatcher fsw)
		{
			lock (this)
			{
				if (DefaultWatcher.watches == null)
				{
					return;
				}
			}
			Hashtable hashtable = DefaultWatcher.watches;
			lock (hashtable)
			{
				DefaultWatcherData defaultWatcherData = (DefaultWatcherData)DefaultWatcher.watches[fsw];
				if (defaultWatcherData != null)
				{
					defaultWatcherData.Enabled = false;
					defaultWatcherData.DisabledTime = DateTime.Now;
				}
			}
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00045664 File Offset: 0x00043864
		private void Monitor()
		{
			int num = 0;
			for (;;)
			{
				Thread.Sleep(750);
				Hashtable hashtable = DefaultWatcher.watches;
				Hashtable hashtable2;
				lock (hashtable)
				{
					if (DefaultWatcher.watches.Count == 0)
					{
						if (++num == 20)
						{
							break;
						}
						continue;
					}
					else
					{
						hashtable2 = (Hashtable)DefaultWatcher.watches.Clone();
					}
				}
				if (hashtable2.Count != 0)
				{
					num = 0;
					foreach (object obj in hashtable2.Values)
					{
						DefaultWatcherData defaultWatcherData = (DefaultWatcherData)obj;
						bool flag = this.UpdateDataAndDispatch(defaultWatcherData, true);
						if (flag)
						{
							Hashtable hashtable3 = DefaultWatcher.watches;
							lock (hashtable3)
							{
								DefaultWatcher.watches.Remove(defaultWatcherData.FSW);
							}
						}
					}
				}
			}
			lock (this)
			{
				DefaultWatcher.thread = null;
			}
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x000457B0 File Offset: 0x000439B0
		private bool UpdateDataAndDispatch(DefaultWatcherData data, bool dispatch)
		{
			if (!data.Enabled)
			{
				return data.DisabledTime != DateTime.MaxValue && (DateTime.Now - data.DisabledTime).TotalSeconds > 5.0;
			}
			this.DoFiles(data, data.Directory, dispatch);
			return false;
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00045814 File Offset: 0x00043A14
		private static void DispatchEvents(FileSystemWatcher fsw, FileAction action, string filename)
		{
			RenamedEventArgs renamedEventArgs = null;
			lock (fsw)
			{
				fsw.DispatchEvents(action, filename, ref renamedEventArgs);
				if (fsw.Waiting)
				{
					fsw.Waiting = false;
					global::System.Threading.Monitor.PulseAll(fsw);
				}
			}
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x0004586C File Offset: 0x00043A6C
		private void DoFiles(DefaultWatcherData data, string directory, bool dispatch)
		{
			bool flag = Directory.Exists(directory);
			if (flag && data.IncludeSubdirs)
			{
				foreach (string text in Directory.GetDirectories(directory))
				{
					this.DoFiles(data, text, dispatch);
				}
			}
			string[] array = null;
			if (!flag)
			{
				array = DefaultWatcher.NoStringsArray;
			}
			else if (!data.NoWildcards)
			{
				array = Directory.GetFileSystemEntries(directory, data.FileMask);
			}
			else if (File.Exists(data.FileMask) || Directory.Exists(data.FileMask))
			{
				array = new string[] { data.FileMask };
			}
			else
			{
				array = DefaultWatcher.NoStringsArray;
			}
			foreach (object obj in data.Files.Keys)
			{
				string text2 = (string)obj;
				FileData fileData = (FileData)data.Files[text2];
				if (fileData.Directory == directory)
				{
					fileData.NotExists = true;
				}
			}
			foreach (string text3 in array)
			{
				FileData fileData2 = (FileData)data.Files[text3];
				if (fileData2 == null)
				{
					try
					{
						data.Files.Add(text3, DefaultWatcher.CreateFileData(directory, text3));
					}
					catch
					{
						data.Files.Remove(text3);
						goto IL_01BD;
					}
					if (dispatch)
					{
						DefaultWatcher.DispatchEvents(data.FSW, FileAction.Added, text3);
					}
				}
				else if (fileData2.Directory == directory)
				{
					fileData2.NotExists = false;
				}
				IL_01BD:;
			}
			if (!dispatch)
			{
				return;
			}
			ArrayList arrayList = null;
			foreach (object obj2 in data.Files.Keys)
			{
				string text4 = (string)obj2;
				FileData fileData3 = (FileData)data.Files[text4];
				if (fileData3.NotExists)
				{
					if (arrayList == null)
					{
						arrayList = new ArrayList();
					}
					arrayList.Add(text4);
					DefaultWatcher.DispatchEvents(data.FSW, FileAction.Removed, text4);
				}
			}
			if (arrayList != null)
			{
				foreach (object obj3 in arrayList)
				{
					string text5 = (string)obj3;
					data.Files.Remove(text5);
				}
				arrayList = null;
			}
			foreach (object obj4 in data.Files.Keys)
			{
				string text6 = (string)obj4;
				FileData fileData4 = (FileData)data.Files[text6];
				DateTime creationTime;
				DateTime lastWriteTime;
				try
				{
					creationTime = File.GetCreationTime(text6);
					lastWriteTime = File.GetLastWriteTime(text6);
				}
				catch
				{
					if (arrayList == null)
					{
						arrayList = new ArrayList();
					}
					arrayList.Add(text6);
					DefaultWatcher.DispatchEvents(data.FSW, FileAction.Removed, text6);
					continue;
				}
				if (creationTime != fileData4.CreationTime || lastWriteTime != fileData4.LastWriteTime)
				{
					fileData4.CreationTime = creationTime;
					fileData4.LastWriteTime = lastWriteTime;
					DefaultWatcher.DispatchEvents(data.FSW, FileAction.Modified, text6);
				}
			}
			if (arrayList != null)
			{
				foreach (object obj5 in arrayList)
				{
					string text7 = (string)obj5;
					data.Files.Remove(text7);
				}
			}
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00045CDC File Offset: 0x00043EDC
		private static FileData CreateFileData(string directory, string filename)
		{
			FileData fileData = new FileData();
			string text = Path.Combine(directory, filename);
			fileData.Directory = directory;
			fileData.Attributes = File.GetAttributes(text);
			fileData.CreationTime = File.GetCreationTime(text);
			fileData.LastWriteTime = File.GetLastWriteTime(text);
			return fileData;
		}

		// Token: 0x04000713 RID: 1811
		private static DefaultWatcher instance;

		// Token: 0x04000714 RID: 1812
		private static Thread thread;

		// Token: 0x04000715 RID: 1813
		private static Hashtable watches;

		// Token: 0x04000716 RID: 1814
		private static string[] NoStringsArray = new string[0];
	}
}
