using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x020002BD RID: 701
	public interface IAchievementDescription
	{
		/// <summary>
		///   <para>Unique identifier for this achievement description.</para>
		/// </summary>
		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x0600218F RID: 8591
		// (set) Token: 0x06002190 RID: 8592
		string id { get; set; }

		/// <summary>
		///   <para>Human readable title.</para>
		/// </summary>
		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06002191 RID: 8593
		string title { get; }

		/// <summary>
		///   <para>Image representation of the achievement.</para>
		/// </summary>
		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06002192 RID: 8594
		Texture2D image { get; }

		/// <summary>
		///   <para>Description when the achivement is completed.</para>
		/// </summary>
		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06002193 RID: 8595
		string achievedDescription { get; }

		/// <summary>
		///   <para>Description when the achivement has not been completed.</para>
		/// </summary>
		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06002194 RID: 8596
		string unachievedDescription { get; }

		/// <summary>
		///   <para>Hidden achievement are not shown in the list until the percentCompleted has been touched (even if it's 0.0).</para>
		/// </summary>
		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06002195 RID: 8597
		bool hidden { get; }

		/// <summary>
		///   <para>Point value of this achievement.</para>
		/// </summary>
		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06002196 RID: 8598
		int points { get; }
	}
}
