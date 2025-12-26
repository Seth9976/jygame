using System;

namespace System.Diagnostics
{
	// Token: 0x02000239 RID: 569
	internal class NullEventLog : EventLogImpl
	{
		// Token: 0x06001375 RID: 4981 RVA: 0x0000F567 File Offset: 0x0000D767
		public NullEventLog(EventLog coreEventLog)
			: base(coreEventLog)
		{
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override void BeginInit()
		{
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override void Clear()
		{
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override void Close()
		{
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override void CreateEventSource(EventSourceCreationData sourceData)
		{
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override void Delete(string logName, string machineName)
		{
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override void DeleteEventSource(string source, string machineName)
		{
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override void Dispose(bool disposing)
		{
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override void DisableNotification()
		{
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override void EnableNotification()
		{
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override void EndInit()
		{
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x000025B7 File Offset: 0x000007B7
		public override bool Exists(string logName, string machineName)
		{
			return true;
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0000F5BE File Offset: 0x0000D7BE
		protected override string FormatMessage(string source, uint messageID, string[] replacementStrings)
		{
			return string.Join(", ", replacementStrings);
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00002AA1 File Offset: 0x00000CA1
		protected override int GetEntryCount()
		{
			return 0;
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x00002A97 File Offset: 0x00000C97
		protected override EventLogEntry GetEntry(int index)
		{
			return null;
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x0000F5CB File Offset: 0x0000D7CB
		protected override string GetLogDisplayName()
		{
			return base.CoreEventLog.Log;
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0000F61F File Offset: 0x0000D81F
		protected override string[] GetLogNames(string machineName)
		{
			return new string[0];
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x00002A97 File Offset: 0x00000C97
		public override string LogNameFromSourceName(string source, string machineName)
		{
			return null;
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool SourceExists(string source, string machineName)
		{
			return false;
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x000029F5 File Offset: 0x00000BF5
		public override void WriteEntry(string[] replacementStrings, EventLogEntryType type, uint instanceID, short category, byte[] rawData)
		{
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x0000B674 File Offset: 0x00009874
		public override OverflowAction OverflowAction
		{
			get
			{
				return OverflowAction.DoNotOverwrite;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x0000F5D8 File Offset: 0x0000D7D8
		public override int MinimumRetentionDays
		{
			get
			{
				return int.MaxValue;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x0000F5DF File Offset: 0x0000D7DF
		// (set) Token: 0x0600138C RID: 5004 RVA: 0x0000F5EA File Offset: 0x0000D7EA
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

		// Token: 0x0600138D RID: 5005 RVA: 0x0000F5F6 File Offset: 0x0000D7F6
		public override void ModifyOverflowPolicy(OverflowAction action, int retentionDays)
		{
			throw new NotSupportedException("This EventLog implementation does not support modifying overflow policy");
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x0000F602 File Offset: 0x0000D802
		public override void RegisterDisplayName(string resourceFile, long resourceId)
		{
			throw new NotSupportedException("This EventLog implementation does not support registering display name");
		}
	}
}
