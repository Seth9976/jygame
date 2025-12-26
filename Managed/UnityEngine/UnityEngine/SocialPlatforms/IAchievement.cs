using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x020002BC RID: 700
	public interface IAchievement
	{
		// Token: 0x06002187 RID: 8583
		void ReportProgress(Action<bool> callback);

		/// <summary>
		///   <para>The unique identifier of this achievement.</para>
		/// </summary>
		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06002188 RID: 8584
		// (set) Token: 0x06002189 RID: 8585
		string id { get; set; }

		/// <summary>
		///   <para>Progress for this achievement.</para>
		/// </summary>
		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x0600218A RID: 8586
		// (set) Token: 0x0600218B RID: 8587
		double percentCompleted { get; set; }

		/// <summary>
		///   <para>Set to true when percentCompleted is 100.0.</para>
		/// </summary>
		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x0600218C RID: 8588
		bool completed { get; }

		/// <summary>
		///   <para>This achievement is currently hidden from the user.</para>
		/// </summary>
		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x0600218D RID: 8589
		bool hidden { get; }

		/// <summary>
		///   <para>Set by server when percentCompleted is updated.</para>
		/// </summary>
		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x0600218E RID: 8590
		DateTime lastReportedDate { get; }
	}
}
