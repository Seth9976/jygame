using System;
using System.Collections.Generic;
using UnityEngine.SocialPlatforms.Impl;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x020002B3 RID: 691
	public class Local : ISocialPlatform
	{
		// Token: 0x06002141 RID: 8513 RVA: 0x00028994 File Offset: 0x00026B94
		void ISocialPlatform.Authenticate(ILocalUser user, Action<bool> callback)
		{
			LocalUser localUser = (LocalUser)user;
			this.m_DefaultTexture = this.CreateDummyTexture(32, 32);
			this.PopulateStaticData();
			localUser.SetAuthenticated(true);
			localUser.SetUnderage(false);
			localUser.SetUserID("1000");
			localUser.SetUserName("Lerpz");
			localUser.SetImage(this.m_DefaultTexture);
			if (callback != null)
			{
				callback(true);
			}
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x0000D5BE File Offset: 0x0000B7BE
		void ISocialPlatform.LoadFriends(ILocalUser user, Action<bool> callback)
		{
			if (!this.VerifyUser())
			{
				return;
			}
			((LocalUser)user).SetFriends(this.m_Friends.ToArray());
			if (callback != null)
			{
				callback(true);
			}
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x000289FC File Offset: 0x00026BFC
		void ISocialPlatform.LoadScores(ILeaderboard board, Action<bool> callback)
		{
			if (!this.VerifyUser())
			{
				return;
			}
			Leaderboard leaderboard = (Leaderboard)board;
			foreach (Leaderboard leaderboard2 in this.m_Leaderboards)
			{
				if (leaderboard2.id == leaderboard.id)
				{
					leaderboard.SetTitle(leaderboard2.title);
					leaderboard.SetScores(leaderboard2.scores);
					leaderboard.SetMaxRange((uint)leaderboard2.scores.Length);
				}
			}
			this.SortScores(leaderboard);
			this.SetLocalPlayerScore(leaderboard);
			if (callback != null)
			{
				callback(true);
			}
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x0000D5EF File Offset: 0x0000B7EF
		bool ISocialPlatform.GetLoading(ILeaderboard board)
		{
			return this.VerifyUser() && ((Leaderboard)board).loading;
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x0000D609 File Offset: 0x0000B809
		public ILocalUser localUser
		{
			get
			{
				if (Local.m_LocalUser == null)
				{
					Local.m_LocalUser = new LocalUser();
				}
				return Local.m_LocalUser;
			}
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x00028ABC File Offset: 0x00026CBC
		public void LoadUsers(string[] userIDs, Action<IUserProfile[]> callback)
		{
			List<UserProfile> list = new List<UserProfile>();
			if (!this.VerifyUser())
			{
				return;
			}
			foreach (string text in userIDs)
			{
				foreach (UserProfile userProfile in this.m_Users)
				{
					if (userProfile.id == text)
					{
						list.Add(userProfile);
					}
				}
				foreach (UserProfile userProfile2 in this.m_Friends)
				{
					if (userProfile2.id == text)
					{
						list.Add(userProfile2);
					}
				}
			}
			callback(list.ToArray());
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00028BC4 File Offset: 0x00026DC4
		public void ReportProgress(string id, double progress, Action<bool> callback)
		{
			if (!this.VerifyUser())
			{
				return;
			}
			foreach (Achievement achievement in this.m_Achievements)
			{
				if (achievement.id == id && achievement.percentCompleted <= progress)
				{
					if (progress >= 100.0)
					{
						achievement.SetCompleted(true);
					}
					achievement.SetHidden(false);
					achievement.SetLastReportedDate(DateTime.Now);
					achievement.percentCompleted = progress;
					if (callback != null)
					{
						callback(true);
					}
					return;
				}
			}
			foreach (AchievementDescription achievementDescription in this.m_AchievementDescriptions)
			{
				if (achievementDescription.id == id)
				{
					bool flag = progress >= 100.0;
					Achievement achievement2 = new Achievement(id, progress, flag, false, DateTime.Now);
					this.m_Achievements.Add(achievement2);
					if (callback != null)
					{
						callback(true);
					}
					return;
				}
			}
			Debug.LogError("Achievement ID not found");
			if (callback != null)
			{
				callback(false);
			}
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x0000D624 File Offset: 0x0000B824
		public void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback)
		{
			if (!this.VerifyUser())
			{
				return;
			}
			if (callback != null)
			{
				callback(this.m_AchievementDescriptions.ToArray());
			}
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x0000D649 File Offset: 0x0000B849
		public void LoadAchievements(Action<IAchievement[]> callback)
		{
			if (!this.VerifyUser())
			{
				return;
			}
			if (callback != null)
			{
				callback(this.m_Achievements.ToArray());
			}
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00028D34 File Offset: 0x00026F34
		public void ReportScore(long score, string board, Action<bool> callback)
		{
			if (!this.VerifyUser())
			{
				return;
			}
			foreach (Leaderboard leaderboard in this.m_Leaderboards)
			{
				if (leaderboard.id == board)
				{
					leaderboard.SetScores(new List<Score>((Score[])leaderboard.scores)
					{
						new Score(board, score, this.localUser.id, DateTime.Now, score + " points", 0)
					}.ToArray());
					if (callback != null)
					{
						callback(true);
					}
					return;
				}
			}
			Debug.LogError("Leaderboard not found");
			if (callback != null)
			{
				callback(false);
			}
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x00028E18 File Offset: 0x00027018
		public void LoadScores(string leaderboardID, Action<IScore[]> callback)
		{
			if (!this.VerifyUser())
			{
				return;
			}
			foreach (Leaderboard leaderboard in this.m_Leaderboards)
			{
				if (leaderboard.id == leaderboardID)
				{
					this.SortScores(leaderboard);
					if (callback != null)
					{
						callback(leaderboard.scores);
					}
					return;
				}
			}
			Debug.LogError("Leaderboard not found");
			if (callback != null)
			{
				callback(new Score[0]);
			}
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x00028EC4 File Offset: 0x000270C4
		private void SortScores(Leaderboard board)
		{
			List<Score> list = new List<Score>((Score[])board.scores);
			list.Sort((Score s1, Score s2) => s2.value.CompareTo(s1.value));
			for (int i = 0; i < list.Count; i++)
			{
				list[i].SetRank(i + 1);
			}
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x00028F2C File Offset: 0x0002712C
		private void SetLocalPlayerScore(Leaderboard board)
		{
			foreach (Score score in board.scores)
			{
				if (score.userID == this.localUser.id)
				{
					board.SetLocalUserScore(score);
					break;
				}
			}
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x0000D66E File Offset: 0x0000B86E
		public void ShowAchievementsUI()
		{
			Debug.Log("ShowAchievementsUI not implemented");
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x0000D67A File Offset: 0x0000B87A
		public void ShowLeaderboardUI()
		{
			Debug.Log("ShowLeaderboardUI not implemented");
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x00028F84 File Offset: 0x00027184
		public ILeaderboard CreateLeaderboard()
		{
			return new Leaderboard();
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x00028F98 File Offset: 0x00027198
		public IAchievement CreateAchievement()
		{
			return new Achievement();
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x0000D686 File Offset: 0x0000B886
		private bool VerifyUser()
		{
			if (!this.localUser.authenticated)
			{
				Debug.LogError("Must authenticate first");
				return false;
			}
			return true;
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x00028FAC File Offset: 0x000271AC
		private void PopulateStaticData()
		{
			this.m_Friends.Add(new UserProfile("Fred", "1001", true, UserState.Online, this.m_DefaultTexture));
			this.m_Friends.Add(new UserProfile("Julia", "1002", true, UserState.Online, this.m_DefaultTexture));
			this.m_Friends.Add(new UserProfile("Jeff", "1003", true, UserState.Online, this.m_DefaultTexture));
			this.m_Users.Add(new UserProfile("Sam", "1004", false, UserState.Offline, this.m_DefaultTexture));
			this.m_Users.Add(new UserProfile("Max", "1005", false, UserState.Offline, this.m_DefaultTexture));
			this.m_AchievementDescriptions.Add(new AchievementDescription("Achievement01", "First achievement", this.m_DefaultTexture, "Get first achievement", "Received first achievement", false, 10));
			this.m_AchievementDescriptions.Add(new AchievementDescription("Achievement02", "Second achievement", this.m_DefaultTexture, "Get second achievement", "Received second achievement", false, 20));
			this.m_AchievementDescriptions.Add(new AchievementDescription("Achievement03", "Third achievement", this.m_DefaultTexture, "Get third achievement", "Received third achievement", false, 15));
			Leaderboard leaderboard = new Leaderboard();
			leaderboard.SetTitle("High Scores");
			leaderboard.id = "Leaderboard01";
			leaderboard.SetScores(new List<Score>
			{
				new Score("Leaderboard01", 300L, "1001", DateTime.Now.AddDays(-1.0), "300 points", 1),
				new Score("Leaderboard01", 255L, "1002", DateTime.Now.AddDays(-1.0), "255 points", 2),
				new Score("Leaderboard01", 55L, "1003", DateTime.Now.AddDays(-1.0), "55 points", 3),
				new Score("Leaderboard01", 10L, "1004", DateTime.Now.AddDays(-1.0), "10 points", 4)
			}.ToArray());
			this.m_Leaderboards.Add(leaderboard);
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x000291FC File Offset: 0x000273FC
		private Texture2D CreateDummyTexture(int width, int height)
		{
			Texture2D texture2D = new Texture2D(width, height);
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					Color color = (((j & i) <= 0) ? Color.gray : Color.white);
					texture2D.SetPixel(j, i, color);
				}
			}
			texture2D.Apply();
			return texture2D;
		}

		// Token: 0x04000AB8 RID: 2744
		private static LocalUser m_LocalUser;

		// Token: 0x04000AB9 RID: 2745
		private List<UserProfile> m_Friends = new List<UserProfile>();

		// Token: 0x04000ABA RID: 2746
		private List<UserProfile> m_Users = new List<UserProfile>();

		// Token: 0x04000ABB RID: 2747
		private List<AchievementDescription> m_AchievementDescriptions = new List<AchievementDescription>();

		// Token: 0x04000ABC RID: 2748
		private List<Achievement> m_Achievements = new List<Achievement>();

		// Token: 0x04000ABD RID: 2749
		private List<Leaderboard> m_Leaderboards = new List<Leaderboard>();

		// Token: 0x04000ABE RID: 2750
		private Texture2D m_DefaultTexture;
	}
}
