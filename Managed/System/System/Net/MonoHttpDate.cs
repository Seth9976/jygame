using System;
using System.Globalization;

namespace System.Net
{
	// Token: 0x0200036D RID: 877
	internal class MonoHttpDate
	{
		// Token: 0x06001EA1 RID: 7841 RVA: 0x0005F664 File Offset: 0x0005D864
		internal static DateTime Parse(string dateStr)
		{
			return DateTime.ParseExact(dateStr, MonoHttpDate.formats, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces).ToLocalTime();
		}

		// Token: 0x040012E5 RID: 4837
		private static readonly string rfc1123_date = "r";

		// Token: 0x040012E6 RID: 4838
		private static readonly string rfc850_date = "dddd, dd-MMM-yy HH:mm:ss G\\MT";

		// Token: 0x040012E7 RID: 4839
		private static readonly string asctime_date = "ddd MMM d HH:mm:ss yyyy";

		// Token: 0x040012E8 RID: 4840
		private static readonly string[] formats = new string[]
		{
			MonoHttpDate.rfc1123_date,
			MonoHttpDate.rfc850_date,
			MonoHttpDate.asctime_date
		};
	}
}
