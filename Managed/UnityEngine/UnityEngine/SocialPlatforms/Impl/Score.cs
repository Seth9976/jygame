using System;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x020002B1 RID: 689
	public class Score : IScore
	{
		// Token: 0x06002118 RID: 8472 RVA: 0x0000D3EE File Offset: 0x0000B5EE
		public Score()
			: this("unkown", -1L)
		{
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x0000D3FD File Offset: 0x0000B5FD
		public Score(string leaderboardID, long value)
			: this(leaderboardID, value, "0", DateTime.Now, string.Empty, -1)
		{
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x0000D417 File Offset: 0x0000B617
		public Score(string leaderboardID, long value, string userID, DateTime date, string formattedValue, int rank)
		{
			this.leaderboardID = leaderboardID;
			this.value = value;
			this.m_UserID = userID;
			this.m_Date = date;
			this.m_FormattedValue = formattedValue;
			this.m_Rank = rank;
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x00028788 File Offset: 0x00026988
		public override string ToString()
		{
			return string.Concat(new object[] { "Rank: '", this.m_Rank, "' Value: '", this.value, "' Category: '", this.leaderboardID, "' PlayerID: '", this.m_UserID, "' Date: '", this.m_Date });
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x0000D44C File Offset: 0x0000B64C
		public void ReportScore(Action<bool> callback)
		{
			ActivePlatform.Instance.ReportScore(this.value, this.leaderboardID, callback);
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x0000D465 File Offset: 0x0000B665
		public void SetDate(DateTime date)
		{
			this.m_Date = date;
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x0000D46E File Offset: 0x0000B66E
		public void SetFormattedValue(string value)
		{
			this.m_FormattedValue = value;
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x0000D477 File Offset: 0x0000B677
		public void SetUserID(string userID)
		{
			this.m_UserID = userID;
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x0000D480 File Offset: 0x0000B680
		public void SetRank(int rank)
		{
			this.m_Rank = rank;
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06002121 RID: 8481 RVA: 0x0000D489 File Offset: 0x0000B689
		// (set) Token: 0x06002122 RID: 8482 RVA: 0x0000D491 File Offset: 0x0000B691
		public string leaderboardID { get; set; }

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06002123 RID: 8483 RVA: 0x0000D49A File Offset: 0x0000B69A
		// (set) Token: 0x06002124 RID: 8484 RVA: 0x0000D4A2 File Offset: 0x0000B6A2
		public long value { get; set; }

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06002125 RID: 8485 RVA: 0x0000D4AB File Offset: 0x0000B6AB
		public DateTime date
		{
			get
			{
				return this.m_Date;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06002126 RID: 8486 RVA: 0x0000D4B3 File Offset: 0x0000B6B3
		public string formattedValue
		{
			get
			{
				return this.m_FormattedValue;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x0000D4BB File Offset: 0x0000B6BB
		public string userID
		{
			get
			{
				return this.m_UserID;
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06002128 RID: 8488 RVA: 0x0000D4C3 File Offset: 0x0000B6C3
		public int rank
		{
			get
			{
				return this.m_Rank;
			}
		}

		// Token: 0x04000AA8 RID: 2728
		private DateTime m_Date;

		// Token: 0x04000AA9 RID: 2729
		private string m_FormattedValue;

		// Token: 0x04000AAA RID: 2730
		private string m_UserID;

		// Token: 0x04000AAB RID: 2731
		private int m_Rank;
	}
}
