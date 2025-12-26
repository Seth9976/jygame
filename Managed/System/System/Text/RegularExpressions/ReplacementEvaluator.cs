using System;
using System.Text.RegularExpressions.Syntax;

namespace System.Text.RegularExpressions
{
	// Token: 0x020004B4 RID: 1204
	internal class ReplacementEvaluator
	{
		// Token: 0x06002ACF RID: 10959 RVA: 0x0001DD07 File Offset: 0x0001BF07
		public ReplacementEvaluator(Regex regex, string replacement)
		{
			this.regex = regex;
			this.replacement = replacement;
			this.pieces = null;
			this.n_pieces = 0;
			this.Compile();
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x0008A740 File Offset: 0x00088940
		public static string Evaluate(string replacement, Match match)
		{
			ReplacementEvaluator replacementEvaluator = new ReplacementEvaluator(match.Regex, replacement);
			return replacementEvaluator.Evaluate(match);
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x0008A764 File Offset: 0x00088964
		public string Evaluate(Match match)
		{
			if (this.n_pieces == 0)
			{
				return this.replacement;
			}
			StringBuilder stringBuilder = new StringBuilder();
			this.EvaluateAppend(match, stringBuilder);
			return stringBuilder.ToString();
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x0008A798 File Offset: 0x00088998
		public void EvaluateAppend(Match match, StringBuilder sb)
		{
			if (this.n_pieces == 0)
			{
				sb.Append(this.replacement);
				return;
			}
			int i = 0;
			while (i < this.n_pieces)
			{
				int num = this.pieces[i++];
				if (num >= 0)
				{
					int num2 = this.pieces[i++];
					sb.Append(this.replacement, num, num2);
				}
				else if (num < -3)
				{
					global::System.Text.RegularExpressions.Group group = match.Groups[-(num + 4)];
					sb.Append(group.Text, group.Index, group.Length);
				}
				else if (num == -1)
				{
					sb.Append(match.Text);
				}
				else if (num == -2)
				{
					sb.Append(match.Text, 0, match.Index);
				}
				else
				{
					int num3 = match.Index + match.Length;
					sb.Append(match.Text, num3, match.Text.Length - num3);
				}
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x0001DD31 File Offset: 0x0001BF31
		public bool NeedsGroupsOrCaptures
		{
			get
			{
				return this.n_pieces != 0;
			}
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x0008A8A4 File Offset: 0x00088AA4
		private void Ensure(int size)
		{
			if (this.pieces == null)
			{
				int num = 4;
				if (num < size)
				{
					num = size;
				}
				this.pieces = new int[num];
			}
			else if (size >= this.pieces.Length)
			{
				int num = this.pieces.Length + (this.pieces.Length >> 1);
				if (num < size)
				{
					num = size;
				}
				int[] array = new int[num];
				Array.Copy(this.pieces, array, this.n_pieces);
				this.pieces = array;
			}
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x0008A924 File Offset: 0x00088B24
		private void AddFromReplacement(int start, int end)
		{
			if (start == end)
			{
				return;
			}
			this.Ensure(this.n_pieces + 2);
			this.pieces[this.n_pieces++] = start;
			this.pieces[this.n_pieces++] = end - start;
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x0008A97C File Offset: 0x00088B7C
		private void AddInt(int i)
		{
			this.Ensure(this.n_pieces + 1);
			this.pieces[this.n_pieces++] = i;
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x0008A9B0 File Offset: 0x00088BB0
		private void Compile()
		{
			int num = 0;
			int i = 0;
			while (i < this.replacement.Length)
			{
				char c = this.replacement[i++];
				if (c == '$')
				{
					if (i == this.replacement.Length)
					{
						break;
					}
					if (this.replacement[i] == '$')
					{
						this.AddFromReplacement(num, i);
						i = (num = i + 1);
					}
					else
					{
						int num2 = i - 1;
						int num3 = this.CompileTerm(ref i);
						if (num3 < 0)
						{
							this.AddFromReplacement(num, num2);
							this.AddInt(num3);
							num = i;
						}
					}
				}
			}
			if (num != 0)
			{
				this.AddFromReplacement(num, i);
			}
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x0008AA6C File Offset: 0x00088C6C
		private int CompileTerm(ref int ptr)
		{
			char c = this.replacement[ptr];
			if (char.IsDigit(c))
			{
				int num = global::System.Text.RegularExpressions.Syntax.Parser.ParseDecimal(this.replacement, ref ptr);
				if (num < 0 || num > this.regex.GroupCount)
				{
					return 0;
				}
				return -num - 4;
			}
			else
			{
				ptr++;
				char c2 = c;
				switch (c2)
				{
				case '&':
					return -4;
				case '\'':
					return -3;
				default:
				{
					if (c2 == '_')
					{
						return -1;
					}
					if (c2 == '`')
					{
						return -2;
					}
					if (c2 != '{')
					{
						return 0;
					}
					int num2 = -1;
					string text;
					try
					{
						if (char.IsDigit(this.replacement[ptr]))
						{
							num2 = global::System.Text.RegularExpressions.Syntax.Parser.ParseDecimal(this.replacement, ref ptr);
							text = string.Empty;
						}
						else
						{
							text = global::System.Text.RegularExpressions.Syntax.Parser.ParseName(this.replacement, ref ptr);
						}
					}
					catch (IndexOutOfRangeException)
					{
						ptr = this.replacement.Length;
						return 0;
					}
					if (ptr == this.replacement.Length || this.replacement[ptr] != '}' || text == null)
					{
						return 0;
					}
					ptr++;
					if (text != string.Empty)
					{
						num2 = this.regex.GroupNumberFromName(text);
					}
					if (num2 < 0 || num2 > this.regex.GroupCount)
					{
						return 0;
					}
					return -num2 - 4;
				}
				case '+':
					return -this.regex.GroupCount - 4;
				}
			}
		}

		// Token: 0x04001B1B RID: 6939
		private Regex regex;

		// Token: 0x04001B1C RID: 6940
		private int n_pieces;

		// Token: 0x04001B1D RID: 6941
		private int[] pieces;

		// Token: 0x04001B1E RID: 6942
		private string replacement;
	}
}
