using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Security;
using System.Text;
using System.Threading;

namespace System.Diagnostics
{
	// Token: 0x02000237 RID: 567
	internal class LocalFileEventLog : EventLogImpl
	{
		// Token: 0x06001351 RID: 4945 RVA: 0x0000F567 File Offset: 0x0000D767
		public LocalFileEventLog(EventLog coreEventLog)
			: base(coreEventLog)
		{
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override void BeginInit()
		{
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0003F2C8 File Offset: 0x0003D4C8
		public override void Clear()
		{
			string text = this.FindLogStore(base.CoreEventLog.Log);
			if (!Directory.Exists(text))
			{
				return;
			}
			foreach (string text2 in Directory.GetFiles(text, "*.log"))
			{
				File.Delete(text2);
			}
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x0000F57C File Offset: 0x0000D77C
		public override void Close()
		{
			if (this.file_watcher != null)
			{
				this.file_watcher.EnableRaisingEvents = false;
				this.file_watcher = null;
			}
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0003F320 File Offset: 0x0003D520
		public override void CreateEventSource(EventSourceCreationData sourceData)
		{
			string text = this.FindLogStore(sourceData.LogName);
			if (!Directory.Exists(text))
			{
				base.ValidateCustomerLogName(sourceData.LogName, sourceData.MachineName);
				Directory.CreateDirectory(text);
				Directory.CreateDirectory(Path.Combine(text, sourceData.LogName));
				if (this.RunningOnUnix)
				{
					LocalFileEventLog.ModifyAccessPermissions(text, "777");
					LocalFileEventLog.ModifyAccessPermissions(text, "+t");
				}
			}
			string text2 = Path.Combine(text, sourceData.Source);
			Directory.CreateDirectory(text2);
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x0003F3A8 File Offset: 0x0003D5A8
		public override void Delete(string logName, string machineName)
		{
			string text = this.FindLogStore(logName);
			if (!Directory.Exists(text))
			{
				throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Event Log '{0}' does not exist on computer '{1}'.", new object[] { logName, machineName }));
			}
			Directory.Delete(text, true);
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0003F3F4 File Offset: 0x0003D5F4
		public override void DeleteEventSource(string source, string machineName)
		{
			if (!Directory.Exists(this.EventLogStore))
			{
				throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "The source '{0}' is not registered on computer '{1}'.", new object[] { source, machineName }));
			}
			string text = this.FindSourceDirectory(source);
			if (text == null)
			{
				throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "The source '{0}' is not registered on computer '{1}'.", new object[] { source, machineName }));
			}
			Directory.Delete(text);
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x0000F59C File Offset: 0x0000D79C
		public override void Dispose(bool disposing)
		{
			this.Close();
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0000F5A4 File Offset: 0x0000D7A4
		public override void DisableNotification()
		{
			if (this.file_watcher == null)
			{
				return;
			}
			this.file_watcher.EnableRaisingEvents = false;
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x0003F46C File Offset: 0x0003D66C
		public override void EnableNotification()
		{
			if (this.file_watcher == null)
			{
				string text = this.FindLogStore(base.CoreEventLog.Log);
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				this.file_watcher = new global::System.IO.FileSystemWatcher();
				this.file_watcher.Path = text;
				this.file_watcher.Created += delegate(object o, global::System.IO.FileSystemEventArgs e)
				{
					lock (this)
					{
						if (this._notifying)
						{
							return;
						}
						this._notifying = true;
					}
					Thread.Sleep(100);
					try
					{
						while (this.GetLatestIndex() > this.last_notification_index)
						{
							try
							{
								base.CoreEventLog.OnEntryWritten(this.GetEntry(this.last_notification_index++));
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						lock (this)
						{
							this._notifying = false;
						}
					}
				};
			}
			this.last_notification_index = this.GetLatestIndex();
			this.file_watcher.EnableRaisingEvents = true;
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override void EndInit()
		{
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0003F4F0 File Offset: 0x0003D6F0
		public override bool Exists(string logName, string machineName)
		{
			string text = this.FindLogStore(logName);
			return Directory.Exists(text);
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0000F5BE File Offset: 0x0000D7BE
		[global::System.MonoTODO("Use MessageTable from PE for lookup")]
		protected override string FormatMessage(string source, uint eventID, string[] replacementStrings)
		{
			return string.Join(", ", replacementStrings);
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x0003F50C File Offset: 0x0003D70C
		protected override int GetEntryCount()
		{
			string text = this.FindLogStore(base.CoreEventLog.Log);
			if (!Directory.Exists(text))
			{
				return 0;
			}
			string[] files = Directory.GetFiles(text, "*.log");
			return files.Length;
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x0003F548 File Offset: 0x0003D748
		protected override EventLogEntry GetEntry(int index)
		{
			string text = this.FindLogStore(base.CoreEventLog.Log);
			string text2 = Path.Combine(text, (index + 1).ToString(CultureInfo.InvariantCulture) + ".log");
			EventLogEntry eventLogEntry;
			using (TextReader textReader = File.OpenText(text2))
			{
				int num = int.Parse(Path.GetFileNameWithoutExtension(text2), CultureInfo.InvariantCulture);
				uint num2 = uint.Parse(textReader.ReadLine().Substring(12), CultureInfo.InvariantCulture);
				EventLogEntryType eventLogEntryType = (EventLogEntryType)((int)Enum.Parse(typeof(EventLogEntryType), textReader.ReadLine().Substring(11)));
				string text3 = textReader.ReadLine().Substring(8);
				string text4 = textReader.ReadLine().Substring(10);
				short num3 = short.Parse(text4, CultureInfo.InvariantCulture);
				string text5 = "(" + text4 + ")";
				DateTime dateTime = DateTime.ParseExact(textReader.ReadLine().Substring(15), "yyyyMMddHHmmssfff", CultureInfo.InvariantCulture);
				DateTime lastWriteTime = File.GetLastWriteTime(text2);
				int num4 = int.Parse(textReader.ReadLine().Substring(20));
				ArrayList arrayList = new ArrayList();
				StringBuilder stringBuilder = new StringBuilder();
				while (arrayList.Count < num4)
				{
					char c = (char)textReader.Read();
					if (c == '\0')
					{
						arrayList.Add(stringBuilder.ToString());
						stringBuilder.Length = 0;
					}
					else
					{
						stringBuilder.Append(c);
					}
				}
				string[] array = new string[arrayList.Count];
				arrayList.CopyTo(array, 0);
				string text6 = this.FormatMessage(text3, num2, array);
				int eventID = EventLog.GetEventID((long)((ulong)num2));
				byte[] array2 = Convert.FromBase64String(textReader.ReadToEnd());
				eventLogEntry = new EventLogEntry(text5, num3, num, eventID, text3, text6, null, Environment.MachineName, eventLogEntryType, dateTime, lastWriteTime, array2, array, (long)((ulong)num2));
			}
			return eventLogEntry;
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x0000F5CB File Offset: 0x0000D7CB
		[global::System.MonoTODO]
		protected override string GetLogDisplayName()
		{
			return base.CoreEventLog.Log;
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x0003F744 File Offset: 0x0003D944
		protected override string[] GetLogNames(string machineName)
		{
			if (!Directory.Exists(this.EventLogStore))
			{
				return new string[0];
			}
			string[] directories = Directory.GetDirectories(this.EventLogStore, "*");
			string[] array = new string[directories.Length];
			for (int i = 0; i < directories.Length; i++)
			{
				array[i] = Path.GetFileName(directories[i]);
			}
			return array;
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x0003F7A4 File Offset: 0x0003D9A4
		public override string LogNameFromSourceName(string source, string machineName)
		{
			if (!Directory.Exists(this.EventLogStore))
			{
				return string.Empty;
			}
			string text = this.FindSourceDirectory(source);
			if (text == null)
			{
				return string.Empty;
			}
			DirectoryInfo directoryInfo = new DirectoryInfo(text);
			return directoryInfo.Parent.Name;
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x0003F7F0 File Offset: 0x0003D9F0
		public override bool SourceExists(string source, string machineName)
		{
			if (!Directory.Exists(this.EventLogStore))
			{
				return false;
			}
			string text = this.FindSourceDirectory(source);
			return text != null;
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x0003F820 File Offset: 0x0003DA20
		public override void WriteEntry(string[] replacementStrings, EventLogEntryType type, uint instanceID, short category, byte[] rawData)
		{
			object obj = LocalFileEventLog.lockObject;
			lock (obj)
			{
				string text = this.FindLogStore(base.CoreEventLog.Log);
				string text2 = Path.Combine(text, (this.GetLatestIndex() + 1).ToString(CultureInfo.InvariantCulture) + ".log");
				try
				{
					using (TextWriter textWriter = File.CreateText(text2))
					{
						textWriter.WriteLine("InstanceID: {0}", instanceID.ToString(CultureInfo.InvariantCulture));
						textWriter.WriteLine("EntryType: {0}", (int)type);
						textWriter.WriteLine("Source: {0}", base.CoreEventLog.Source);
						textWriter.WriteLine("Category: {0}", category.ToString(CultureInfo.InvariantCulture));
						textWriter.WriteLine("TimeGenerated: {0}", DateTime.Now.ToString("yyyyMMddHHmmssfff", CultureInfo.InvariantCulture));
						textWriter.WriteLine("ReplacementStrings: {0}", replacementStrings.Length.ToString(CultureInfo.InvariantCulture));
						StringBuilder stringBuilder = new StringBuilder();
						foreach (string text3 in replacementStrings)
						{
							stringBuilder.Append(text3);
							stringBuilder.Append('\0');
						}
						textWriter.Write(stringBuilder.ToString());
						textWriter.Write(Convert.ToBase64String(rawData));
					}
				}
				catch (IOException)
				{
					File.Delete(text2);
				}
			}
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x0003F9E4 File Offset: 0x0003DBE4
		private string FindSourceDirectory(string source)
		{
			string text = null;
			string[] directories = Directory.GetDirectories(this.EventLogStore, "*");
			for (int i = 0; i < directories.Length; i++)
			{
				string[] directories2 = Directory.GetDirectories(directories[i], "*");
				for (int j = 0; j < directories2.Length; j++)
				{
					string fileName = Path.GetFileName(directories2[j]);
					if (string.Compare(fileName, source, true, CultureInfo.InvariantCulture) == 0)
					{
						text = directories2[j];
						break;
					}
				}
			}
			return text;
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x0003FA68 File Offset: 0x0003DC68
		private bool RunningOnUnix
		{
			get
			{
				int platform = (int)Environment.OSVersion.Platform;
				return platform == 4 || platform == 128 || platform == 6;
			}
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x0003FA9C File Offset: 0x0003DC9C
		private string FindLogStore(string logName)
		{
			if (!Directory.Exists(this.EventLogStore))
			{
				return Path.Combine(this.EventLogStore, logName);
			}
			string[] directories = Directory.GetDirectories(this.EventLogStore, "*");
			for (int i = 0; i < directories.Length; i++)
			{
				string fileName = Path.GetFileName(directories[i]);
				if (string.Compare(fileName, logName, true, CultureInfo.InvariantCulture) == 0)
				{
					return directories[i];
				}
			}
			return Path.Combine(this.EventLogStore, logName);
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x0003FB18 File Offset: 0x0003DD18
		private string EventLogStore
		{
			get
			{
				string environmentVariable = Environment.GetEnvironmentVariable("MONO_EVENTLOG_TYPE");
				if (environmentVariable != null && environmentVariable.Length > "local".Length + 1)
				{
					return environmentVariable.Substring("local".Length + 1);
				}
				if (this.RunningOnUnix)
				{
					return "/var/lib/mono/eventlog";
				}
				return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "mono\\eventlog");
			}
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x0003FB84 File Offset: 0x0003DD84
		private int GetLatestIndex()
		{
			int num = 0;
			string[] files = Directory.GetFiles(this.FindLogStore(base.CoreEventLog.Log), "*.log");
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					string text = files[i];
					int num2 = int.Parse(Path.GetFileNameWithoutExtension(text), CultureInfo.InvariantCulture);
					if (num2 > num)
					{
						num = num2;
					}
				}
				catch
				{
				}
			}
			return num;
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x0003FC00 File Offset: 0x0003DE00
		private static void ModifyAccessPermissions(string path, string permissions)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "chmod";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.Arguments = string.Format("{0} \"{1}\"", permissions, path);
			Process process = null;
			try
			{
				process = Process.Start(processStartInfo);
			}
			catch (Exception ex)
			{
				throw new SecurityException("Access permissions could not be modified.", ex);
			}
			process.WaitForExit();
			if (process.ExitCode != 0)
			{
				process.Close();
				throw new SecurityException("Access permissions could not be modified.");
			}
			process.Close();
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x0000B674 File Offset: 0x00009874
		public override OverflowAction OverflowAction
		{
			get
			{
				return OverflowAction.DoNotOverwrite;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x0000F5D8 File Offset: 0x0000D7D8
		public override int MinimumRetentionDays
		{
			get
			{
				return int.MaxValue;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x0000F5DF File Offset: 0x0000D7DF
		// (set) Token: 0x0600136F RID: 4975 RVA: 0x0000F5EA File Offset: 0x0000D7EA
		public override long MaximumKilobytes
		{
			get
			{
				return long.MaxValue;
			}
			set
			{
				throw new NotSupportedException("This EventLog implementation does not support setting max kilobytes policy");
			}
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x0000F5F6 File Offset: 0x0000D7F6
		public override void ModifyOverflowPolicy(OverflowAction action, int retentionDays)
		{
			throw new NotSupportedException("This EventLog implementation does not support modifying overflow policy");
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x0000F602 File Offset: 0x0000D802
		public override void RegisterDisplayName(string resourceFile, long resourceId)
		{
			throw new NotSupportedException("This EventLog implementation does not support registering display name");
		}

		// Token: 0x0400059E RID: 1438
		private const string DateFormat = "yyyyMMddHHmmssfff";

		// Token: 0x0400059F RID: 1439
		private static readonly object lockObject = new object();

		// Token: 0x040005A0 RID: 1440
		private global::System.IO.FileSystemWatcher file_watcher;

		// Token: 0x040005A1 RID: 1441
		private int last_notification_index;

		// Token: 0x040005A2 RID: 1442
		private bool _notifying;
	}
}
