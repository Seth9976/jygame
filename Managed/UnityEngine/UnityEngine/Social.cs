using System;
using UnityEngine.SocialPlatforms;

namespace UnityEngine
{
	/// <summary>
	///   <para>Generic access to the Social API.</para>
	/// </summary>
	// Token: 0x020002B6 RID: 694
	public static class Social
	{
		/// <summary>
		///   <para>This is the currently active social platform. </para>
		/// </summary>
		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x0000D711 File Offset: 0x0000B911
		// (set) Token: 0x0600215F RID: 8543 RVA: 0x0000D718 File Offset: 0x0000B918
		public static ISocialPlatform Active
		{
			get
			{
				return ActivePlatform.Instance;
			}
			set
			{
				ActivePlatform.Instance = value;
			}
		}

		/// <summary>
		///   <para>The local user (potentially not logged in).</para>
		/// </summary>
		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x0000D720 File Offset: 0x0000B920
		public static ILocalUser localUser
		{
			get
			{
				return Social.Active.localUser;
			}
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x0000D72C File Offset: 0x0000B92C
		public static void LoadUsers(string[] userIDs, Action<IUserProfile[]> callback)
		{
			Social.Active.LoadUsers(userIDs, callback);
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x0000D73A File Offset: 0x0000B93A
		public static void ReportProgress(string achievementID, double progress, Action<bool> callback)
		{
			Social.Active.ReportProgress(achievementID, progress, callback);
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x0000D749 File Offset: 0x0000B949
		public static void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback)
		{
			Social.Active.LoadAchievementDescriptions(callback);
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x0000D756 File Offset: 0x0000B956
		public static void LoadAchievements(Action<IAchievement[]> callback)
		{
			Social.Active.LoadAchievements(callback);
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x0000D763 File Offset: 0x0000B963
		public static void ReportScore(long score, string board, Action<bool> callback)
		{
			Social.Active.ReportScore(score, board, callback);
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x0000D772 File Offset: 0x0000B972
		public static void LoadScores(string leaderboardID, Action<IScore[]> callback)
		{
			Social.Active.LoadScores(leaderboardID, callback);
		}

		/// <summary>
		///   <para>Create an ILeaderboard instance.</para>
		/// </summary>
		// Token: 0x06002167 RID: 8551 RVA: 0x0000D780 File Offset: 0x0000B980
		public static ILeaderboard CreateLeaderboard()
		{
			return Social.Active.CreateLeaderboard();
		}

		/// <summary>
		///   <para>Create an IAchievement instance.</para>
		/// </summary>
		// Token: 0x06002168 RID: 8552 RVA: 0x0000D78C File Offset: 0x0000B98C
		public static IAchievement CreateAchievement()
		{
			return Social.Active.CreateAchievement();
		}

		/// <summary>
		///   <para>Show a default/system view of the games achievements.</para>
		/// </summary>
		// Token: 0x06002169 RID: 8553 RVA: 0x0000D798 File Offset: 0x0000B998
		public static void ShowAchievementsUI()
		{
			Social.Active.ShowAchievementsUI();
		}

		/// <summary>
		///   <para>Show a default/system view of the games leaderboards.</para>
		/// </summary>
		// Token: 0x0600216A RID: 8554 RVA: 0x0000D7A4 File Offset: 0x0000B9A4
		public static void ShowLeaderboardUI()
		{
			Social.Active.ShowLeaderboardUI();
		}
	}
}
