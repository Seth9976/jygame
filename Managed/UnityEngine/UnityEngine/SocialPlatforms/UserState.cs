using System;

namespace UnityEngine.SocialPlatforms
{
	/// <summary>
	///   <para>User presence state.</para>
	/// </summary>
	// Token: 0x020002BA RID: 698
	public enum UserState
	{
		/// <summary>
		///   <para>The user is online.</para>
		/// </summary>
		// Token: 0x04000ACC RID: 2764
		Online,
		/// <summary>
		///   <para>The user is online but away from his computer.</para>
		/// </summary>
		// Token: 0x04000ACD RID: 2765
		OnlineAndAway,
		/// <summary>
		///   <para>The user is only but set his status to busy.</para>
		/// </summary>
		// Token: 0x04000ACE RID: 2766
		OnlineAndBusy,
		/// <summary>
		///   <para>The user is offline.</para>
		/// </summary>
		// Token: 0x04000ACF RID: 2767
		Offline,
		/// <summary>
		///   <para>The user is playing a game.</para>
		/// </summary>
		// Token: 0x04000AD0 RID: 2768
		Playing
	}
}
