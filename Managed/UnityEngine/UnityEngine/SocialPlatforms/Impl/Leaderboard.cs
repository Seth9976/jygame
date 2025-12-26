using System;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x020002B2 RID: 690
	public class Leaderboard : ILeaderboard
	{
		// Token: 0x06002129 RID: 8489 RVA: 0x00028808 File Offset: 0x00026A08
		public Leaderboard()
		{
			this.id = "Invalid";
			this.range = new Range(1, 10);
			this.userScope = UserScope.Global;
			this.timeScope = TimeScope.AllTime;
			this.m_Loading = false;
			this.m_LocalUserScore = new Score("Invalid", 0L);
			this.m_MaxRange = 0U;
			this.m_Scores = new Score[0];
			this.m_Title = "Invalid";
			this.m_UserIDs = new string[0];
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x0000D4CB File Offset: 0x0000B6CB
		public void SetUserFilter(string[] userIDs)
		{
			this.m_UserIDs = userIDs;
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x00028888 File Offset: 0x00026A88
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"ID: '",
				this.id,
				"' Title: '",
				this.m_Title,
				"' Loading: '",
				this.m_Loading,
				"' Range: [",
				this.range.from,
				",",
				this.range.count,
				"] MaxRange: '",
				this.m_MaxRange,
				"' Scores: '",
				this.m_Scores.Length,
				"' UserScope: '",
				this.userScope,
				"' TimeScope: '",
				this.timeScope,
				"' UserFilter: '",
				this.m_UserIDs.Length
			});
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x0000D4D4 File Offset: 0x0000B6D4
		public void LoadScores(Action<bool> callback)
		{
			ActivePlatform.Instance.LoadScores(this, callback);
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x0000D4E2 File Offset: 0x0000B6E2
		public bool loading
		{
			get
			{
				return ActivePlatform.Instance.GetLoading(this);
			}
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x0000D4EF File Offset: 0x0000B6EF
		public void SetLocalUserScore(IScore score)
		{
			this.m_LocalUserScore = score;
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x0000D4F8 File Offset: 0x0000B6F8
		public void SetMaxRange(uint maxRange)
		{
			this.m_MaxRange = maxRange;
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x0000D501 File Offset: 0x0000B701
		public void SetScores(IScore[] scores)
		{
			this.m_Scores = scores;
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x0000D50A File Offset: 0x0000B70A
		public void SetTitle(string title)
		{
			this.m_Title = title;
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x0000D513 File Offset: 0x0000B713
		public string[] GetUserFilter()
		{
			return this.m_UserIDs;
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x0000D51B File Offset: 0x0000B71B
		// (set) Token: 0x06002134 RID: 8500 RVA: 0x0000D523 File Offset: 0x0000B723
		public string id { get; set; }

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x0000D52C File Offset: 0x0000B72C
		// (set) Token: 0x06002136 RID: 8502 RVA: 0x0000D534 File Offset: 0x0000B734
		public UserScope userScope { get; set; }

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x0000D53D File Offset: 0x0000B73D
		// (set) Token: 0x06002138 RID: 8504 RVA: 0x0000D545 File Offset: 0x0000B745
		public Range range { get; set; }

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x0000D54E File Offset: 0x0000B74E
		// (set) Token: 0x0600213A RID: 8506 RVA: 0x0000D556 File Offset: 0x0000B756
		public TimeScope timeScope { get; set; }

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x0000D55F File Offset: 0x0000B75F
		public IScore localUserScore
		{
			get
			{
				return this.m_LocalUserScore;
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x0600213C RID: 8508 RVA: 0x0000D567 File Offset: 0x0000B767
		public uint maxRange
		{
			get
			{
				return this.m_MaxRange;
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x0000D56F File Offset: 0x0000B76F
		public IScore[] scores
		{
			get
			{
				return this.m_Scores;
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x0000D577 File Offset: 0x0000B777
		public string title
		{
			get
			{
				return this.m_Title;
			}
		}

		// Token: 0x04000AAE RID: 2734
		private bool m_Loading;

		// Token: 0x04000AAF RID: 2735
		private IScore m_LocalUserScore;

		// Token: 0x04000AB0 RID: 2736
		private uint m_MaxRange;

		// Token: 0x04000AB1 RID: 2737
		private IScore[] m_Scores;

		// Token: 0x04000AB2 RID: 2738
		private string m_Title;

		// Token: 0x04000AB3 RID: 2739
		private string[] m_UserIDs;
	}
}
