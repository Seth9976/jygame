using System;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x020002AF RID: 687
	public class Achievement : IAchievement
	{
		// Token: 0x060020FE RID: 8446 RVA: 0x0000D287 File Offset: 0x0000B487
		public Achievement(string id, double percentCompleted, bool completed, bool hidden, DateTime lastReportedDate)
		{
			this.id = id;
			this.percentCompleted = percentCompleted;
			this.m_Completed = completed;
			this.m_Hidden = hidden;
			this.m_LastReportedDate = lastReportedDate;
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x0000D2B4 File Offset: 0x0000B4B4
		public Achievement(string id, double percent)
		{
			this.id = id;
			this.percentCompleted = percent;
			this.m_Hidden = false;
			this.m_Completed = false;
			this.m_LastReportedDate = DateTime.MinValue;
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x0000D2E3 File Offset: 0x0000B4E3
		public Achievement()
			: this("unknown", 0.0)
		{
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x00028688 File Offset: 0x00026888
		public override string ToString()
		{
			return string.Concat(new object[] { this.id, " - ", this.percentCompleted, " - ", this.completed, " - ", this.hidden, " - ", this.lastReportedDate });
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x0000D2F9 File Offset: 0x0000B4F9
		public void ReportProgress(Action<bool> callback)
		{
			ActivePlatform.Instance.ReportProgress(this.id, this.percentCompleted, callback);
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x0000D312 File Offset: 0x0000B512
		public void SetCompleted(bool value)
		{
			this.m_Completed = value;
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x0000D31B File Offset: 0x0000B51B
		public void SetHidden(bool value)
		{
			this.m_Hidden = value;
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x0000D324 File Offset: 0x0000B524
		public void SetLastReportedDate(DateTime date)
		{
			this.m_LastReportedDate = date;
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x0000D32D File Offset: 0x0000B52D
		// (set) Token: 0x06002107 RID: 8455 RVA: 0x0000D335 File Offset: 0x0000B535
		public string id { get; set; }

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06002108 RID: 8456 RVA: 0x0000D33E File Offset: 0x0000B53E
		// (set) Token: 0x06002109 RID: 8457 RVA: 0x0000D346 File Offset: 0x0000B546
		public double percentCompleted { get; set; }

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x0600210A RID: 8458 RVA: 0x0000D34F File Offset: 0x0000B54F
		public bool completed
		{
			get
			{
				return this.m_Completed;
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x0000D357 File Offset: 0x0000B557
		public bool hidden
		{
			get
			{
				return this.m_Hidden;
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x0000D35F File Offset: 0x0000B55F
		public DateTime lastReportedDate
		{
			get
			{
				return this.m_LastReportedDate;
			}
		}

		// Token: 0x04000A9C RID: 2716
		private bool m_Completed;

		// Token: 0x04000A9D RID: 2717
		private bool m_Hidden;

		// Token: 0x04000A9E RID: 2718
		private DateTime m_LastReportedDate;
	}
}
