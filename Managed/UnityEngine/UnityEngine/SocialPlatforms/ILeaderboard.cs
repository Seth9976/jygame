using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x020002C2 RID: 706
	public interface ILeaderboard
	{
		/// <summary>
		///   <para>Only search for these user IDs.</para>
		/// </summary>
		/// <param name="userIDs">List of user ids.</param>
		// Token: 0x060021A1 RID: 8609
		void SetUserFilter(string[] userIDs);

		// Token: 0x060021A2 RID: 8610
		void LoadScores(Action<bool> callback);

		/// <summary>
		///   <para>The leaderboad is in the process of loading scores.</para>
		/// </summary>
		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x060021A3 RID: 8611
		bool loading { get; }

		/// <summary>
		///   <para>Unique identifier for this leaderboard.</para>
		/// </summary>
		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x060021A4 RID: 8612
		// (set) Token: 0x060021A5 RID: 8613
		string id { get; set; }

		/// <summary>
		///   <para>The users scope searched by this leaderboard.</para>
		/// </summary>
		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x060021A6 RID: 8614
		// (set) Token: 0x060021A7 RID: 8615
		UserScope userScope { get; set; }

		/// <summary>
		///   <para>The rank range this leaderboard returns.</para>
		/// </summary>
		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x060021A8 RID: 8616
		// (set) Token: 0x060021A9 RID: 8617
		Range range { get; set; }

		/// <summary>
		///   <para>The time period/scope searched by this leaderboard.</para>
		/// </summary>
		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x060021AA RID: 8618
		// (set) Token: 0x060021AB RID: 8619
		TimeScope timeScope { get; set; }

		/// <summary>
		///   <para>The leaderboard score of the logged in user.</para>
		/// </summary>
		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x060021AC RID: 8620
		IScore localUserScore { get; }

		/// <summary>
		///   <para>The total amount of scores the leaderboard contains.</para>
		/// </summary>
		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x060021AD RID: 8621
		uint maxRange { get; }

		/// <summary>
		///   <para>The leaderboard scores returned by a query.</para>
		/// </summary>
		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x060021AE RID: 8622
		IScore[] scores { get; }

		/// <summary>
		///   <para>The human readable title of this leaderboard.</para>
		/// </summary>
		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x060021AF RID: 8623
		string title { get; }
	}
}
