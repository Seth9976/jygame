using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x020002B8 RID: 696
	public interface ISocialPlatform
	{
		/// <summary>
		///   <para>See Social.localUser.</para>
		/// </summary>
		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x0600216E RID: 8558
		ILocalUser localUser { get; }

		// Token: 0x0600216F RID: 8559
		void LoadUsers(string[] userIDs, Action<IUserProfile[]> callback);

		// Token: 0x06002170 RID: 8560
		void ReportProgress(string achievementID, double progress, Action<bool> callback);

		// Token: 0x06002171 RID: 8561
		void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback);

		// Token: 0x06002172 RID: 8562
		void LoadAchievements(Action<IAchievement[]> callback);

		/// <summary>
		///   <para>See Social.CreateAchievement..</para>
		/// </summary>
		// Token: 0x06002173 RID: 8563
		IAchievement CreateAchievement();

		// Token: 0x06002174 RID: 8564
		void ReportScore(long score, string board, Action<bool> callback);

		// Token: 0x06002175 RID: 8565
		void LoadScores(string leaderboardID, Action<IScore[]> callback);

		/// <summary>
		///   <para>See Social.CreateLeaderboard.</para>
		/// </summary>
		// Token: 0x06002176 RID: 8566
		ILeaderboard CreateLeaderboard();

		/// <summary>
		///   <para>See Social.ShowAchievementsUI.</para>
		/// </summary>
		// Token: 0x06002177 RID: 8567
		void ShowAchievementsUI();

		/// <summary>
		///   <para>See Social.ShowLeaderboardUI.</para>
		/// </summary>
		// Token: 0x06002178 RID: 8568
		void ShowLeaderboardUI();

		// Token: 0x06002179 RID: 8569
		void Authenticate(ILocalUser user, Action<bool> callback);

		// Token: 0x0600217A RID: 8570
		void LoadFriends(ILocalUser user, Action<bool> callback);

		// Token: 0x0600217B RID: 8571
		void LoadScores(ILeaderboard board, Action<bool> callback);

		// Token: 0x0600217C RID: 8572
		bool GetLoading(ILeaderboard board);
	}
}
