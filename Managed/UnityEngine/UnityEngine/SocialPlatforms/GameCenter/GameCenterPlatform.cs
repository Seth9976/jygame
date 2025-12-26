using System;

namespace UnityEngine.SocialPlatforms.GameCenter
{
	/// <summary>
	///   <para>iOS GameCenter implementation for network services.</para>
	/// </summary>
	// Token: 0x0200025D RID: 605
	public class GameCenterPlatform : Local
	{
		// Token: 0x0600208A RID: 8330 RVA: 0x0000CD5A File Offset: 0x0000AF5A
		public static void ResetAllAchievements(Action<bool> callback)
		{
			Debug.Log("ResetAllAchievements - no effect in editor");
			callback(true);
		}

		/// <summary>
		///   <para>Show the default iOS banner when achievements are completed.</para>
		/// </summary>
		/// <param name="value"></param>
		// Token: 0x0600208B RID: 8331 RVA: 0x0000CD6D File Offset: 0x0000AF6D
		public static void ShowDefaultAchievementCompletionBanner(bool value)
		{
			Debug.Log("ShowDefaultAchievementCompletionBanner - no effect in editor");
		}

		/// <summary>
		///   <para>Show the leaderboard UI with a specific leaderboard shown initially with a specific time scope selected.</para>
		/// </summary>
		/// <param name="leaderboardID"></param>
		/// <param name="timeScope"></param>
		// Token: 0x0600208C RID: 8332 RVA: 0x0000CD79 File Offset: 0x0000AF79
		public static void ShowLeaderboardUI(string leaderboardID, TimeScope timeScope)
		{
			Debug.Log("ShowLeaderboardUI - no effect in editor");
		}
	}
}
