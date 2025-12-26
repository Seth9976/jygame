using System;
using System.Globalization;

namespace System.Diagnostics
{
	// Token: 0x02000228 RID: 552
	internal abstract class EventLogImpl
	{
		// Token: 0x060012B4 RID: 4788 RVA: 0x0000EF5F File Offset: 0x0000D15F
		protected EventLogImpl(EventLog coreEventLog)
		{
			this._coreEventLog = coreEventLog;
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x0000EF6E File Offset: 0x0000D16E
		protected EventLog CoreEventLog
		{
			get
			{
				return this._coreEventLog;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x0003E88C File Offset: 0x0003CA8C
		public int EntryCount
		{
			get
			{
				if (this._coreEventLog.Log == null || this._coreEventLog.Log.Length == 0)
				{
					throw new ArgumentException("Log property is not set.");
				}
				if (!EventLog.Exists(this._coreEventLog.Log, this._coreEventLog.MachineName))
				{
					throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "The event log '{0}' on  computer '{1}' does not exist.", new object[]
					{
						this._coreEventLog.Log,
						this._coreEventLog.MachineName
					}));
				}
				return this.GetEntryCount();
			}
		}

		// Token: 0x17000447 RID: 1095
		public EventLogEntry this[int index]
		{
			get
			{
				if (this._coreEventLog.Log == null || this._coreEventLog.Log.Length == 0)
				{
					throw new ArgumentException("Log property is not set.");
				}
				if (!EventLog.Exists(this._coreEventLog.Log, this._coreEventLog.MachineName))
				{
					throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "The event log '{0}' on  computer '{1}' does not exist.", new object[]
					{
						this._coreEventLog.Log,
						this._coreEventLog.MachineName
					}));
				}
				if (index < 0 || index >= this.EntryCount)
				{
					throw new ArgumentException("Index out of range");
				}
				return this.GetEntry(index);
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x0003E9E4 File Offset: 0x0003CBE4
		public string LogDisplayName
		{
			get
			{
				if (this._coreEventLog.Log != null && this._coreEventLog.Log.Length == 0)
				{
					throw new InvalidOperationException("Event log names must consist of printable characters and cannot contain \\, *, ?, or spaces.");
				}
				if (this._coreEventLog.Log != null)
				{
					if (this._coreEventLog.Log.Length == 0)
					{
						return string.Empty;
					}
					if (!EventLog.Exists(this._coreEventLog.Log, this._coreEventLog.MachineName))
					{
						throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Cannot find Log {0} on computer {1}.", new object[]
						{
							this._coreEventLog.Log,
							this._coreEventLog.MachineName
						}));
					}
				}
				return this.GetLogDisplayName();
			}
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x0003EAAC File Offset: 0x0003CCAC
		public EventLogEntry[] GetEntries()
		{
			string log = this.CoreEventLog.Log;
			if (log == null || log.Length == 0)
			{
				throw new ArgumentException("Log property value has not been specified.");
			}
			if (!EventLog.Exists(log))
			{
				throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "The event log '{0}' on  computer '{1}' does not exist.", new object[]
				{
					log,
					this._coreEventLog.MachineName
				}));
			}
			int entryCount = this.GetEntryCount();
			EventLogEntry[] array = new EventLogEntry[entryCount];
			for (int i = 0; i < entryCount; i++)
			{
				array[i] = this.GetEntry(i);
			}
			return array;
		}

		// Token: 0x060012BA RID: 4794
		public abstract void DisableNotification();

		// Token: 0x060012BB RID: 4795
		public abstract void EnableNotification();

		// Token: 0x060012BC RID: 4796
		public abstract void BeginInit();

		// Token: 0x060012BD RID: 4797
		public abstract void Clear();

		// Token: 0x060012BE RID: 4798
		public abstract void Close();

		// Token: 0x060012BF RID: 4799
		public abstract void CreateEventSource(EventSourceCreationData sourceData);

		// Token: 0x060012C0 RID: 4800
		public abstract void Delete(string logName, string machineName);

		// Token: 0x060012C1 RID: 4801
		public abstract void DeleteEventSource(string source, string machineName);

		// Token: 0x060012C2 RID: 4802
		public abstract void Dispose(bool disposing);

		// Token: 0x060012C3 RID: 4803
		public abstract void EndInit();

		// Token: 0x060012C4 RID: 4804
		public abstract bool Exists(string logName, string machineName);

		// Token: 0x060012C5 RID: 4805
		protected abstract int GetEntryCount();

		// Token: 0x060012C6 RID: 4806
		protected abstract EventLogEntry GetEntry(int index);

		// Token: 0x060012C7 RID: 4807 RVA: 0x0003EB44 File Offset: 0x0003CD44
		public EventLog[] GetEventLogs(string machineName)
		{
			string[] logNames = this.GetLogNames(machineName);
			EventLog[] array = new EventLog[logNames.Length];
			for (int i = 0; i < logNames.Length; i++)
			{
				EventLog eventLog = new EventLog(logNames[i], machineName);
				array[i] = eventLog;
			}
			return array;
		}

		// Token: 0x060012C8 RID: 4808
		protected abstract string GetLogDisplayName();

		// Token: 0x060012C9 RID: 4809
		public abstract string LogNameFromSourceName(string source, string machineName);

		// Token: 0x060012CA RID: 4810
		public abstract bool SourceExists(string source, string machineName);

		// Token: 0x060012CB RID: 4811
		public abstract void WriteEntry(string[] replacementStrings, EventLogEntryType type, uint instanceID, short category, byte[] rawData);

		// Token: 0x060012CC RID: 4812
		protected abstract string FormatMessage(string source, uint messageID, string[] replacementStrings);

		// Token: 0x060012CD RID: 4813
		protected abstract string[] GetLogNames(string machineName);

		// Token: 0x060012CE RID: 4814 RVA: 0x0003EB88 File Offset: 0x0003CD88
		protected void ValidateCustomerLogName(string logName, string machineName)
		{
			if (logName.Length >= 8)
			{
				string text = logName.Substring(0, 8);
				if (string.Compare(text, "AppEvent", true) == 0 || string.Compare(text, "SysEvent", true) == 0 || string.Compare(text, "SecEvent", true) == 0)
				{
					throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "The log name: '{0}' is invalid for customer log creation.", new object[] { logName }));
				}
				foreach (string text2 in this.GetLogNames(machineName))
				{
					if (text2.Length >= 8 && string.Compare(text2, 0, text, 0, 8, true) == 0)
					{
						throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Only the first eight characters of a custom log name are significant, and there is already another log on the system using the first eight characters of the name given. Name given: '{0}', name of existing log: '{1}'.", new object[] { logName, text2 }));
					}
				}
			}
			if (!this.SourceExists(logName, machineName))
			{
				return;
			}
			if (machineName == ".")
			{
				throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Log {0} has already been registered as a source on the local computer.", new object[] { logName }));
			}
			throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Log {0} has already been registered as a source on the computer {1}.", new object[] { logName, machineName }));
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060012CF RID: 4815
		public abstract OverflowAction OverflowAction { get; }

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060012D0 RID: 4816
		public abstract int MinimumRetentionDays { get; }

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060012D1 RID: 4817
		// (set) Token: 0x060012D2 RID: 4818
		public abstract long MaximumKilobytes { get; set; }

		// Token: 0x060012D3 RID: 4819
		public abstract void ModifyOverflowPolicy(OverflowAction action, int retentionDays);

		// Token: 0x060012D4 RID: 4820
		public abstract void RegisterDisplayName(string resourceFile, long resourceId);

		// Token: 0x04000568 RID: 1384
		private readonly EventLog _coreEventLog;
	}
}
