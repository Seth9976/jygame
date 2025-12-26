using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x020002BB RID: 699
	public interface IUserProfile
	{
		/// <summary>
		///   <para>This user's username or alias.</para>
		/// </summary>
		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06002182 RID: 8578
		string userName { get; }

		/// <summary>
		///   <para>This users unique identifier.</para>
		/// </summary>
		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06002183 RID: 8579
		string id { get; }

		/// <summary>
		///   <para>Is this user a friend of the current logged in user?</para>
		/// </summary>
		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06002184 RID: 8580
		bool isFriend { get; }

		/// <summary>
		///   <para>Presence state of the user.</para>
		/// </summary>
		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06002185 RID: 8581
		UserState state { get; }

		/// <summary>
		///   <para>Avatar image of the user.</para>
		/// </summary>
		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06002186 RID: 8582
		Texture2D image { get; }
	}
}
