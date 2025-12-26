using System;

namespace UnityEngine
{
	// Token: 0x020002DA RID: 730
	internal class SystemClock
	{
		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x0600220C RID: 8716 RVA: 0x0000DA8B File Offset: 0x0000BC8B
		public static DateTime now
		{
			get
			{
				return DateTime.Now;
			}
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x0002A8A0 File Offset: 0x00028AA0
		public static long ToUnixTimeMilliseconds(DateTime date)
		{
			return Convert.ToInt64((date.ToUniversalTime() - SystemClock.s_Epoch).TotalMilliseconds);
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x0002A8CC File Offset: 0x00028ACC
		public static long ToUnixTimeSeconds(DateTime date)
		{
			return Convert.ToInt64((date.ToUniversalTime() - SystemClock.s_Epoch).TotalSeconds);
		}

		// Token: 0x04000B06 RID: 2822
		private static readonly DateTime s_Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
	}
}
