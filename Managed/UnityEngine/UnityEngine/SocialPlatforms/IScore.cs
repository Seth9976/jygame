using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x020002BE RID: 702
	public interface IScore
	{
		// Token: 0x06002197 RID: 8599
		void ReportScore(Action<bool> callback);

		/// <summary>
		///   <para>The ID of the leaderboard this score belongs to.</para>
		/// </summary>
		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06002198 RID: 8600
		// (set) Token: 0x06002199 RID: 8601
		string leaderboardID { get; set; }

		/// <summary>
		///   <para>The score value achieved.</para>
		/// </summary>
		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x0600219A RID: 8602
		// (set) Token: 0x0600219B RID: 8603
		long value { get; set; }

		/// <summary>
		///   <para>The date the score was achieved.</para>
		/// </summary>
		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x0600219C RID: 8604
		DateTime date { get; }

		/// <summary>
		///   <para>The correctly formatted value of the score, like X points or X kills.</para>
		/// </summary>
		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x0600219D RID: 8605
		string formattedValue { get; }

		/// <summary>
		///   <para>The user who owns this score.</para>
		/// </summary>
		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x0600219E RID: 8606
		string userID { get; }

		/// <summary>
		///   <para>The rank or position of the score in the leaderboard. </para>
		/// </summary>
		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x0600219F RID: 8607
		int rank { get; }
	}
}
