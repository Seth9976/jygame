using System;
using System.IO;
using System.Text;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x0200009E RID: 158
	internal sealed class WWWTranscoder
	{
		// Token: 0x06000908 RID: 2312 RVA: 0x000161B0 File Offset: 0x000143B0
		private static byte Hex2Byte(byte[] b, int offset)
		{
			byte b2 = 0;
			for (int i = offset; i < offset + 2; i++)
			{
				b2 *= 16;
				int num = (int)b[i];
				if (num >= 48 && num <= 57)
				{
					num -= 48;
				}
				else if (num >= 65 && num <= 75)
				{
					num -= 55;
				}
				else if (num >= 97 && num <= 102)
				{
					num -= 87;
				}
				if (num > 15)
				{
					return 63;
				}
				b2 += (byte)num;
			}
			return b2;
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00016238 File Offset: 0x00014438
		private static byte[] Byte2Hex(byte b, byte[] hexChars)
		{
			return new byte[]
			{
				hexChars[b >> 4],
				hexChars[(int)(b & 15)]
			};
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00016260 File Offset: 0x00014460
		[ExcludeFromDocs]
		public static string URLEncode(string toEncode)
		{
			Encoding utf = Encoding.UTF8;
			return WWWTranscoder.URLEncode(toEncode, utf);
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0001627C File Offset: 0x0001447C
		public static string URLEncode(string toEncode, [DefaultValue("Encoding.UTF8")] Encoding e)
		{
			byte[] array = WWWTranscoder.Encode(e.GetBytes(toEncode), WWWTranscoder.urlEscapeChar, WWWTranscoder.urlSpace, WWWTranscoder.urlForbidden, false);
			return WWW.DefaultEncoding.GetString(array, 0, array.Length);
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x000056E6 File Offset: 0x000038E6
		public static byte[] URLEncode(byte[] toEncode)
		{
			return WWWTranscoder.Encode(toEncode, WWWTranscoder.urlEscapeChar, WWWTranscoder.urlSpace, WWWTranscoder.urlForbidden, false);
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x000162B8 File Offset: 0x000144B8
		[ExcludeFromDocs]
		public static string QPEncode(string toEncode)
		{
			Encoding utf = Encoding.UTF8;
			return WWWTranscoder.QPEncode(toEncode, utf);
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x000162D4 File Offset: 0x000144D4
		public static string QPEncode(string toEncode, [DefaultValue("Encoding.UTF8")] Encoding e)
		{
			byte[] array = WWWTranscoder.Encode(e.GetBytes(toEncode), WWWTranscoder.qpEscapeChar, WWWTranscoder.qpSpace, WWWTranscoder.qpForbidden, true);
			return WWW.DefaultEncoding.GetString(array, 0, array.Length);
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x000056FE File Offset: 0x000038FE
		public static byte[] QPEncode(byte[] toEncode)
		{
			return WWWTranscoder.Encode(toEncode, WWWTranscoder.qpEscapeChar, WWWTranscoder.qpSpace, WWWTranscoder.qpForbidden, true);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00016310 File Offset: 0x00014510
		public static byte[] Encode(byte[] input, byte escapeChar, byte space, byte[] forbidden, bool uppercase)
		{
			byte[] array;
			using (MemoryStream memoryStream = new MemoryStream(input.Length * 2))
			{
				for (int i = 0; i < input.Length; i++)
				{
					if (input[i] == 32)
					{
						memoryStream.WriteByte(space);
					}
					else if (input[i] < 32 || input[i] > 126 || WWWTranscoder.ByteArrayContains(forbidden, input[i]))
					{
						memoryStream.WriteByte(escapeChar);
						memoryStream.Write(WWWTranscoder.Byte2Hex(input[i], (!uppercase) ? WWWTranscoder.lcHexChars : WWWTranscoder.ucHexChars), 0, 2);
					}
					else
					{
						memoryStream.WriteByte(input[i]);
					}
				}
				array = memoryStream.ToArray();
			}
			return array;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x000163E0 File Offset: 0x000145E0
		private static bool ByteArrayContains(byte[] array, byte b)
		{
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				if (array[i] == b)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00016410 File Offset: 0x00014610
		[ExcludeFromDocs]
		public static string URLDecode(string toEncode)
		{
			Encoding utf = Encoding.UTF8;
			return WWWTranscoder.URLDecode(toEncode, utf);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0001642C File Offset: 0x0001462C
		public static string URLDecode(string toEncode, [DefaultValue("Encoding.UTF8")] Encoding e)
		{
			byte[] array = WWWTranscoder.Decode(WWW.DefaultEncoding.GetBytes(toEncode), WWWTranscoder.urlEscapeChar, WWWTranscoder.urlSpace);
			return e.GetString(array, 0, array.Length);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00005716 File Offset: 0x00003916
		public static byte[] URLDecode(byte[] toEncode)
		{
			return WWWTranscoder.Decode(toEncode, WWWTranscoder.urlEscapeChar, WWWTranscoder.urlSpace);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00016460 File Offset: 0x00014660
		[ExcludeFromDocs]
		public static string QPDecode(string toEncode)
		{
			Encoding utf = Encoding.UTF8;
			return WWWTranscoder.QPDecode(toEncode, utf);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0001647C File Offset: 0x0001467C
		public static string QPDecode(string toEncode, [DefaultValue("Encoding.UTF8")] Encoding e)
		{
			byte[] array = WWWTranscoder.Decode(WWW.DefaultEncoding.GetBytes(toEncode), WWWTranscoder.qpEscapeChar, WWWTranscoder.qpSpace);
			return e.GetString(array, 0, array.Length);
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00005728 File Offset: 0x00003928
		public static byte[] QPDecode(byte[] toEncode)
		{
			return WWWTranscoder.Decode(toEncode, WWWTranscoder.qpEscapeChar, WWWTranscoder.qpSpace);
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x000164B0 File Offset: 0x000146B0
		public static byte[] Decode(byte[] input, byte escapeChar, byte space)
		{
			byte[] array;
			using (MemoryStream memoryStream = new MemoryStream(input.Length))
			{
				for (int i = 0; i < input.Length; i++)
				{
					if (input[i] == space)
					{
						memoryStream.WriteByte(32);
					}
					else if (input[i] == escapeChar && i + 2 < input.Length)
					{
						i++;
						memoryStream.WriteByte(WWWTranscoder.Hex2Byte(input, i++));
					}
					else
					{
						memoryStream.WriteByte(input[i]);
					}
				}
				array = memoryStream.ToArray();
			}
			return array;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00016558 File Offset: 0x00014758
		[ExcludeFromDocs]
		public static bool SevenBitClean(string s)
		{
			Encoding utf = Encoding.UTF8;
			return WWWTranscoder.SevenBitClean(s, utf);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0000573A File Offset: 0x0000393A
		public static bool SevenBitClean(string s, [DefaultValue("Encoding.UTF8")] Encoding e)
		{
			return WWWTranscoder.SevenBitClean(e.GetBytes(s));
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00016574 File Offset: 0x00014774
		public static bool SevenBitClean(byte[] input)
		{
			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] < 32 || input[i] > 126)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040001F0 RID: 496
		private static byte[] ucHexChars = WWW.DefaultEncoding.GetBytes("0123456789ABCDEF");

		// Token: 0x040001F1 RID: 497
		private static byte[] lcHexChars = WWW.DefaultEncoding.GetBytes("0123456789abcdef");

		// Token: 0x040001F2 RID: 498
		private static byte urlEscapeChar = 37;

		// Token: 0x040001F3 RID: 499
		private static byte urlSpace = 43;

		// Token: 0x040001F4 RID: 500
		private static byte[] urlForbidden = WWW.DefaultEncoding.GetBytes("@&;:<>=?\"'/\\!#%+$,{}|^[]`");

		// Token: 0x040001F5 RID: 501
		private static byte qpEscapeChar = 61;

		// Token: 0x040001F6 RID: 502
		private static byte qpSpace = 95;

		// Token: 0x040001F7 RID: 503
		private static byte[] qpForbidden = WWW.DefaultEncoding.GetBytes("&;=?\"'%+_");
	}
}
