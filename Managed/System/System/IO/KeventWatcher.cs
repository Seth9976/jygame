using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.IO
{
	// Token: 0x0200029B RID: 667
	internal class KeventWatcher : IFileWatcher
	{
		// Token: 0x0600170E RID: 5902 RVA: 0x000021C3 File Offset: 0x000003C3
		private KeventWatcher()
		{
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x00047C80 File Offset: 0x00045E80
		public static bool GetInstance(out IFileWatcher watcher)
		{
			if (KeventWatcher.failed)
			{
				watcher = null;
				return false;
			}
			if (KeventWatcher.instance != null)
			{
				watcher = KeventWatcher.instance;
				return true;
			}
			KeventWatcher.watches = Hashtable.Synchronized(new Hashtable());
			KeventWatcher.requests = Hashtable.Synchronized(new Hashtable());
			KeventWatcher.conn = KeventWatcher.kqueue();
			if (KeventWatcher.conn == -1)
			{
				KeventWatcher.failed = true;
				watcher = null;
				return false;
			}
			KeventWatcher.instance = new KeventWatcher();
			watcher = KeventWatcher.instance;
			return true;
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00047D00 File Offset: 0x00045F00
		public void StartDispatching(FileSystemWatcher fsw)
		{
			KeventData keventData;
			lock (this)
			{
				if (KeventWatcher.thread == null)
				{
					KeventWatcher.thread = new Thread(new ThreadStart(this.Monitor));
					KeventWatcher.thread.IsBackground = true;
					KeventWatcher.thread.Start();
				}
				keventData = (KeventData)KeventWatcher.watches[fsw];
			}
			if (keventData == null)
			{
				keventData = new KeventData();
				keventData.FSW = fsw;
				keventData.Directory = fsw.FullPath;
				keventData.FileMask = fsw.MangledFilter;
				keventData.IncludeSubdirs = fsw.IncludeSubdirectories;
				keventData.Enabled = true;
				lock (this)
				{
					KeventWatcher.StartMonitoringDirectory(keventData);
					KeventWatcher.watches[fsw] = keventData;
					KeventWatcher.stop = false;
				}
			}
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x00047DF0 File Offset: 0x00045FF0
		private static void StartMonitoringDirectory(KeventData data)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(data.Directory);
			if (data.DirEntries == null)
			{
				data.DirEntries = new Hashtable();
				foreach (FileSystemInfo fileSystemInfo in directoryInfo.GetFileSystemInfos())
				{
					data.DirEntries.Add(fileSystemInfo.FullName, new KeventFileData(fileSystemInfo, fileSystemInfo.LastAccessTime, fileSystemInfo.LastWriteTime));
				}
			}
			int num = KeventWatcher.open(data.Directory, 0, 0);
			kevent kevent = default(kevent);
			kevent.udata = IntPtr.Zero;
			timespec timespec = default(timespec);
			timespec.tv_sec = 0;
			timespec.tv_usec = 0;
			if (num > 0)
			{
				kevent.ident = num;
				kevent.filter = -4;
				kevent.flags = 21;
				kevent.fflags = 31U;
				kevent.data = 0;
				kevent.udata = Marshal.StringToHGlobalAuto(data.Directory);
				kevent kevent2 = default(kevent);
				kevent2.udata = IntPtr.Zero;
				KeventWatcher.kevent(KeventWatcher.conn, ref kevent, 1, ref kevent2, 0, ref timespec);
				data.ev = kevent;
				KeventWatcher.requests[num] = data;
			}
			if (!data.IncludeSubdirs)
			{
				return;
			}
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00047F30 File Offset: 0x00046130
		public void StopDispatching(FileSystemWatcher fsw)
		{
			lock (this)
			{
				KeventData keventData = (KeventData)KeventWatcher.watches[fsw];
				if (keventData != null)
				{
					KeventWatcher.StopMonitoringDirectory(keventData);
					KeventWatcher.watches.Remove(fsw);
					if (KeventWatcher.watches.Count == 0)
					{
						KeventWatcher.stop = true;
					}
					if (!keventData.IncludeSubdirs)
					{
					}
				}
			}
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x000115B2 File Offset: 0x0000F7B2
		private static void StopMonitoringDirectory(KeventData data)
		{
			KeventWatcher.close(data.ev.ident);
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x00047FB4 File Offset: 0x000461B4
		private void Monitor()
		{
			while (!KeventWatcher.stop)
			{
				kevent kevent = default(kevent);
				kevent.udata = IntPtr.Zero;
				kevent kevent2 = default(kevent);
				kevent2.udata = IntPtr.Zero;
				timespec timespec = default(timespec);
				timespec.tv_sec = 0;
				timespec.tv_usec = 0;
				int num;
				lock (this)
				{
					num = KeventWatcher.kevent(KeventWatcher.conn, ref kevent2, 0, ref kevent, 1, ref timespec);
				}
				if (num > 0)
				{
					KeventData keventData = (KeventData)KeventWatcher.requests[kevent.ident];
					KeventWatcher.StopMonitoringDirectory(keventData);
					KeventWatcher.StartMonitoringDirectory(keventData);
					this.ProcessEvent(kevent);
				}
				else
				{
					Thread.Sleep(500);
				}
			}
			lock (this)
			{
				KeventWatcher.thread = null;
				KeventWatcher.stop = false;
			}
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x000480C0 File Offset: 0x000462C0
		private void ProcessEvent(kevent ev)
		{
			lock (this)
			{
				KeventData keventData = (KeventData)KeventWatcher.requests[ev.ident];
				if (keventData.Enabled)
				{
					string text = string.Empty;
					FileSystemWatcher fsw = keventData.FSW;
					DirectoryInfo directoryInfo = new DirectoryInfo(keventData.Directory);
					FileSystemInfo fileSystemInfo = null;
					try
					{
						foreach (FileSystemInfo fileSystemInfo2 in directoryInfo.GetFileSystemInfos())
						{
							if (keventData.DirEntries.ContainsKey(fileSystemInfo2.FullName) && fileSystemInfo2 is FileInfo)
							{
								KeventFileData keventFileData = (KeventFileData)keventData.DirEntries[fileSystemInfo2.FullName];
								if (keventFileData.LastWriteTime != fileSystemInfo2.LastWriteTime)
								{
									text = fileSystemInfo2.Name;
									FileAction fileAction = FileAction.Modified;
									keventData.DirEntries[fileSystemInfo2.FullName] = new KeventFileData(fileSystemInfo2, fileSystemInfo2.LastAccessTime, fileSystemInfo2.LastWriteTime);
									if (fsw.IncludeSubdirectories && fileSystemInfo2 is DirectoryInfo)
									{
										keventData.Directory = text;
										KeventWatcher.requests[ev.ident] = keventData;
										this.ProcessEvent(ev);
									}
									this.PostEvent(text, fsw, fileAction, fileSystemInfo);
								}
							}
						}
					}
					catch (Exception)
					{
					}
					try
					{
						bool flag = true;
						while (flag)
						{
							foreach (object obj in keventData.DirEntries.Values)
							{
								KeventFileData keventFileData2 = (KeventFileData)obj;
								if (!File.Exists(keventFileData2.fsi.FullName) && !Directory.Exists(keventFileData2.fsi.FullName))
								{
									text = keventFileData2.fsi.Name;
									FileAction fileAction = FileAction.Removed;
									keventData.DirEntries.Remove(keventFileData2.fsi.FullName);
									this.PostEvent(text, fsw, fileAction, fileSystemInfo);
									break;
								}
							}
							flag = false;
						}
					}
					catch (Exception)
					{
					}
					try
					{
						foreach (FileSystemInfo fileSystemInfo3 in directoryInfo.GetFileSystemInfos())
						{
							if (!keventData.DirEntries.ContainsKey(fileSystemInfo3.FullName))
							{
								fileSystemInfo = fileSystemInfo3;
								text = fileSystemInfo3.Name;
								FileAction fileAction = FileAction.Added;
								keventData.DirEntries[fileSystemInfo3.FullName] = new KeventFileData(fileSystemInfo3, fileSystemInfo3.LastAccessTime, fileSystemInfo3.LastWriteTime);
								this.PostEvent(text, fsw, fileAction, fileSystemInfo);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x00048408 File Offset: 0x00046608
		private void PostEvent(string filename, FileSystemWatcher fsw, FileAction fa, FileSystemInfo changedFsi)
		{
			RenamedEventArgs renamedEventArgs = null;
			if (fa == (FileAction)0)
			{
				return;
			}
			if (fsw.IncludeSubdirectories && fa == FileAction.Added && changedFsi is DirectoryInfo)
			{
				KeventData keventData = new KeventData();
				keventData.FSW = fsw;
				keventData.Directory = changedFsi.FullName;
				keventData.FileMask = fsw.MangledFilter;
				keventData.IncludeSubdirs = fsw.IncludeSubdirectories;
				keventData.Enabled = true;
				lock (this)
				{
					KeventWatcher.StartMonitoringDirectory(keventData);
				}
			}
			if (!fsw.Pattern.IsMatch(filename, true))
			{
				return;
			}
			lock (fsw)
			{
				fsw.DispatchEvents(fa, filename, ref renamedEventArgs);
				if (fsw.Waiting)
				{
					fsw.Waiting = false;
					global::System.Threading.Monitor.PulseAll(fsw);
				}
			}
		}

		// Token: 0x06001717 RID: 5911
		[DllImport("libc")]
		private static extern int open(string path, int flags, int mode_t);

		// Token: 0x06001718 RID: 5912
		[DllImport("libc")]
		private static extern int close(int fd);

		// Token: 0x06001719 RID: 5913
		[DllImport("libc")]
		private static extern int kqueue();

		// Token: 0x0600171A RID: 5914
		[DllImport("libc")]
		private static extern int kevent(int kqueue, ref kevent ev, int nchanges, ref kevent evtlist, int nevents, ref timespec ts);

		// Token: 0x04000799 RID: 1945
		private static bool failed;

		// Token: 0x0400079A RID: 1946
		private static KeventWatcher instance;

		// Token: 0x0400079B RID: 1947
		private static Hashtable watches;

		// Token: 0x0400079C RID: 1948
		private static Hashtable requests;

		// Token: 0x0400079D RID: 1949
		private static Thread thread;

		// Token: 0x0400079E RID: 1950
		private static int conn;

		// Token: 0x0400079F RID: 1951
		private static bool stop;
	}
}
