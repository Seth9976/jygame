using System;
using System.Text;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	// Token: 0x02000035 RID: 53
	internal static class StringPluginExtensions
	{
		// Token: 0x0600017F RID: 383 RVA: 0x00009B7A File Offset: 0x00007D7A
		static StringPluginExtensions()
		{
			StringPluginExtensions.ScrambledChars.ScrambleChars();
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00009BA0 File Offset: 0x00007DA0
		internal static void ScrambleChars(this char[] chars)
		{
			int num = chars.Length;
			for (int i = 0; i < num; i++)
			{
				char c = chars[i];
				int num2 = global::UnityEngine.Random.Range(i, num);
				chars[i] = chars[num2];
				chars[num2] = c;
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00009BD4 File Offset: 0x00007DD4
		internal static StringBuilder AppendScrambledChars(this StringBuilder buffer, int length, char[] chars)
		{
			if (length <= 0)
			{
				return buffer;
			}
			int num = chars.Length;
			int num2;
			for (num2 = StringPluginExtensions._lastRndSeed; num2 == StringPluginExtensions._lastRndSeed; num2 = global::UnityEngine.Random.Range(0, num))
			{
			}
			StringPluginExtensions._lastRndSeed = num2;
			for (int i = 0; i < length; i++)
			{
				if (num2 >= num)
				{
					num2 = 0;
				}
				buffer.Append(chars[num2]);
				num2++;
			}
			return buffer;
		}

		// Token: 0x04000101 RID: 257
		public static readonly char[] ScrambledChars = new char[]
		{
			'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
			'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
			'U', 'V', 'X', 'Y', 'Z'
		};

		// Token: 0x04000102 RID: 258
		private static int _lastRndSeed;
	}
}
