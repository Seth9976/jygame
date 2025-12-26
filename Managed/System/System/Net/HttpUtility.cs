using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace System.Net
{
	// Token: 0x02000336 RID: 822
	internal sealed class HttpUtility
	{
		// Token: 0x06001C5F RID: 7263 RVA: 0x000021C3 File Offset: 0x000003C3
		private HttpUtility()
		{
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x00014999 File Offset: 0x00012B99
		public static string UrlDecode(string s)
		{
			return HttpUtility.UrlDecode(s, null);
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x000149A2 File Offset: 0x00012BA2
		private static char[] GetChars(MemoryStream b, Encoding e)
		{
			return e.GetChars(b.GetBuffer(), 0, (int)b.Length);
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x000556F4 File Offset: 0x000538F4
		public static string UrlDecode(string s, Encoding e)
		{
			if (s == null)
			{
				return null;
			}
			if (s.IndexOf('%') == -1 && s.IndexOf('+') == -1)
			{
				return s;
			}
			if (e == null)
			{
				e = Encoding.GetEncoding(28591);
			}
			StringBuilder stringBuilder = new StringBuilder();
			long num = (long)s.Length;
			NumberStyles numberStyles = NumberStyles.HexNumber;
			MemoryStream memoryStream = new MemoryStream();
			int num2 = 0;
			while ((long)num2 < num)
			{
				if (s[num2] == '%' && (long)(num2 + 2) < num)
				{
					if (s[num2 + 1] == 'u' && (long)(num2 + 5) < num)
					{
						if (memoryStream.Length > 0L)
						{
							stringBuilder.Append(HttpUtility.GetChars(memoryStream, e));
							memoryStream.SetLength(0L);
						}
						stringBuilder.Append((char)int.Parse(s.Substring(num2 + 2, 4), numberStyles));
						num2 += 5;
					}
					else
					{
						memoryStream.WriteByte((byte)int.Parse(s.Substring(num2 + 1, 2), numberStyles));
						num2 += 2;
					}
				}
				else
				{
					if (memoryStream.Length > 0L)
					{
						stringBuilder.Append(HttpUtility.GetChars(memoryStream, e));
						memoryStream.SetLength(0L);
					}
					if (s[num2] == '+')
					{
						stringBuilder.Append(' ');
					}
					else
					{
						stringBuilder.Append(s[num2]);
					}
				}
				num2++;
			}
			if (memoryStream.Length > 0L)
			{
				stringBuilder.Append(HttpUtility.GetChars(memoryStream, e));
			}
			return stringBuilder.ToString();
		}
	}
}
