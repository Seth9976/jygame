using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x020002B7 RID: 695
	internal static class ActivePlatform
	{
		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x0600216B RID: 8555 RVA: 0x0000D7B0 File Offset: 0x0000B9B0
		// (set) Token: 0x0600216C RID: 8556 RVA: 0x0000D7CB File Offset: 0x0000B9CB
		internal static ISocialPlatform Instance
		{
			get
			{
				if (ActivePlatform._active == null)
				{
					ActivePlatform._active = ActivePlatform.SelectSocialPlatform();
				}
				return ActivePlatform._active;
			}
			set
			{
				ActivePlatform._active = value;
			}
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x0000D7D3 File Offset: 0x0000B9D3
		private static ISocialPlatform SelectSocialPlatform()
		{
			return new Local();
		}

		// Token: 0x04000ACA RID: 2762
		private static ISocialPlatform _active;
	}
}
