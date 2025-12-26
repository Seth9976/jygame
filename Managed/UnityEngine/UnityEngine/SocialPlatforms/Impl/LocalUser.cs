using System;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x020002AD RID: 685
	public class LocalUser : UserProfile, ILocalUser, IUserProfile
	{
		// Token: 0x060020E7 RID: 8423 RVA: 0x0000D146 File Offset: 0x0000B346
		public LocalUser()
		{
			this.m_Friends = new UserProfile[0];
			this.m_Authenticated = false;
			this.m_Underage = false;
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x0000D168 File Offset: 0x0000B368
		public void Authenticate(Action<bool> callback)
		{
			ActivePlatform.Instance.Authenticate(this, callback);
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x0000D176 File Offset: 0x0000B376
		public void LoadFriends(Action<bool> callback)
		{
			ActivePlatform.Instance.LoadFriends(this, callback);
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x0000D184 File Offset: 0x0000B384
		public void SetFriends(IUserProfile[] friends)
		{
			this.m_Friends = friends;
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x0000D18D File Offset: 0x0000B38D
		public void SetAuthenticated(bool value)
		{
			this.m_Authenticated = value;
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x0000D196 File Offset: 0x0000B396
		public void SetUnderage(bool value)
		{
			this.m_Underage = value;
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x060020ED RID: 8429 RVA: 0x0000D19F File Offset: 0x0000B39F
		public IUserProfile[] friends
		{
			get
			{
				return this.m_Friends;
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x060020EE RID: 8430 RVA: 0x0000D1A7 File Offset: 0x0000B3A7
		public bool authenticated
		{
			get
			{
				return this.m_Authenticated;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x0000D1AF File Offset: 0x0000B3AF
		public bool underage
		{
			get
			{
				return this.m_Underage;
			}
		}

		// Token: 0x04000A94 RID: 2708
		private IUserProfile[] m_Friends;

		// Token: 0x04000A95 RID: 2709
		private bool m_Authenticated;

		// Token: 0x04000A96 RID: 2710
		private bool m_Underage;
	}
}
