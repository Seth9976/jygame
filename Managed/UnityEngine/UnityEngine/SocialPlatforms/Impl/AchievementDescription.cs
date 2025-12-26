using System;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x020002B0 RID: 688
	public class AchievementDescription : IAchievementDescription
	{
		// Token: 0x0600210D RID: 8461 RVA: 0x0000D367 File Offset: 0x0000B567
		public AchievementDescription(string id, string title, Texture2D image, string achievedDescription, string unachievedDescription, bool hidden, int points)
		{
			this.id = id;
			this.m_Title = title;
			this.m_Image = image;
			this.m_AchievedDescription = achievedDescription;
			this.m_UnachievedDescription = unachievedDescription;
			this.m_Hidden = hidden;
			this.m_Points = points;
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x00028704 File Offset: 0x00026904
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				this.id, " - ", this.title, " - ", this.achievedDescription, " - ", this.unachievedDescription, " - ", this.points, " - ",
				this.hidden
			});
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x0000D3A4 File Offset: 0x0000B5A4
		public void SetImage(Texture2D image)
		{
			this.m_Image = image;
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x0000D3AD File Offset: 0x0000B5AD
		// (set) Token: 0x06002111 RID: 8465 RVA: 0x0000D3B5 File Offset: 0x0000B5B5
		public string id { get; set; }

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06002112 RID: 8466 RVA: 0x0000D3BE File Offset: 0x0000B5BE
		public string title
		{
			get
			{
				return this.m_Title;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06002113 RID: 8467 RVA: 0x0000D3C6 File Offset: 0x0000B5C6
		public Texture2D image
		{
			get
			{
				return this.m_Image;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06002114 RID: 8468 RVA: 0x0000D3CE File Offset: 0x0000B5CE
		public string achievedDescription
		{
			get
			{
				return this.m_AchievedDescription;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06002115 RID: 8469 RVA: 0x0000D3D6 File Offset: 0x0000B5D6
		public string unachievedDescription
		{
			get
			{
				return this.m_UnachievedDescription;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06002116 RID: 8470 RVA: 0x0000D3DE File Offset: 0x0000B5DE
		public bool hidden
		{
			get
			{
				return this.m_Hidden;
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06002117 RID: 8471 RVA: 0x0000D3E6 File Offset: 0x0000B5E6
		public int points
		{
			get
			{
				return this.m_Points;
			}
		}

		// Token: 0x04000AA1 RID: 2721
		private string m_Title;

		// Token: 0x04000AA2 RID: 2722
		private Texture2D m_Image;

		// Token: 0x04000AA3 RID: 2723
		private string m_AchievedDescription;

		// Token: 0x04000AA4 RID: 2724
		private string m_UnachievedDescription;

		// Token: 0x04000AA5 RID: 2725
		private bool m_Hidden;

		// Token: 0x04000AA6 RID: 2726
		private int m_Points;
	}
}
