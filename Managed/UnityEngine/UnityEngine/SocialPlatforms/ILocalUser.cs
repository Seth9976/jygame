using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x020002B9 RID: 697
	public interface ILocalUser : IUserProfile
	{
		// Token: 0x0600217D RID: 8573
		void Authenticate(Action<bool> callback);

		// Token: 0x0600217E RID: 8574
		void LoadFriends(Action<bool> callback);

		/// <summary>
		///   <para>The users friends list.</para>
		/// </summary>
		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x0600217F RID: 8575
		IUserProfile[] friends { get; }

		/// <summary>
		///   <para>Checks if the current user has been authenticated.</para>
		/// </summary>
		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06002180 RID: 8576
		bool authenticated { get; }

		/// <summary>
		///   <para>Is the user underage?</para>
		/// </summary>
		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06002181 RID: 8577
		bool underage { get; }
	}
}
