using System;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x020002AE RID: 686
	public class UserProfile : IUserProfile
	{
		// Token: 0x060020F0 RID: 8432 RVA: 0x0000D1B7 File Offset: 0x0000B3B7
		public UserProfile()
		{
			this.m_UserName = "Uninitialized";
			this.m_ID = "0";
			this.m_IsFriend = false;
			this.m_State = UserState.Offline;
			this.m_Image = new Texture2D(32, 32);
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x0000D1F2 File Offset: 0x0000B3F2
		public UserProfile(string name, string id, bool friend)
			: this(name, id, friend, UserState.Offline, new Texture2D(0, 0))
		{
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x0000D205 File Offset: 0x0000B405
		public UserProfile(string name, string id, bool friend, UserState state, Texture2D image)
		{
			this.m_UserName = name;
			this.m_ID = id;
			this.m_IsFriend = friend;
			this.m_State = state;
			this.m_Image = image;
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00028628 File Offset: 0x00026828
		public override string ToString()
		{
			return string.Concat(new object[] { this.id, " - ", this.userName, " - ", this.isFriend, " - ", this.state });
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x0000D232 File Offset: 0x0000B432
		public void SetUserName(string name)
		{
			this.m_UserName = name;
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x0000D23B File Offset: 0x0000B43B
		public void SetUserID(string id)
		{
			this.m_ID = id;
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x0000D244 File Offset: 0x0000B444
		public void SetImage(Texture2D image)
		{
			this.m_Image = image;
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x0000D24D File Offset: 0x0000B44D
		public void SetIsFriend(bool value)
		{
			this.m_IsFriend = value;
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x0000D256 File Offset: 0x0000B456
		public void SetState(UserState state)
		{
			this.m_State = state;
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x060020F9 RID: 8441 RVA: 0x0000D25F File Offset: 0x0000B45F
		public string userName
		{
			get
			{
				return this.m_UserName;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x060020FA RID: 8442 RVA: 0x0000D267 File Offset: 0x0000B467
		public string id
		{
			get
			{
				return this.m_ID;
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x060020FB RID: 8443 RVA: 0x0000D26F File Offset: 0x0000B46F
		public bool isFriend
		{
			get
			{
				return this.m_IsFriend;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x0000D277 File Offset: 0x0000B477
		public UserState state
		{
			get
			{
				return this.m_State;
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x0000D27F File Offset: 0x0000B47F
		public Texture2D image
		{
			get
			{
				return this.m_Image;
			}
		}

		// Token: 0x04000A97 RID: 2711
		protected string m_UserName;

		// Token: 0x04000A98 RID: 2712
		protected string m_ID;

		// Token: 0x04000A99 RID: 2713
		protected bool m_IsFriend;

		// Token: 0x04000A9A RID: 2714
		protected UserState m_State;

		// Token: 0x04000A9B RID: 2715
		protected Texture2D m_Image;
	}
}
