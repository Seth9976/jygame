using System;

namespace System.IO
{
	// Token: 0x020002B4 RID: 692
	internal class SearchPattern2
	{
		// Token: 0x060017F4 RID: 6132 RVA: 0x00011CCB File Offset: 0x0000FECB
		public SearchPattern2(string pattern)
			: this(pattern, false)
		{
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00011CD5 File Offset: 0x0000FED5
		public SearchPattern2(string pattern, bool ignore)
		{
			this.ignore = ignore;
			this.pattern = pattern;
			this.Compile(pattern);
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00049970 File Offset: 0x00047B70
		public bool IsMatch(string text, bool ignorecase)
		{
			if (this.hasWildcard)
			{
				return this.Match(this.ops, text, 0);
			}
			bool flag = string.Compare(this.pattern, text, ignorecase) == 0;
			if (flag)
			{
				return true;
			}
			int num = text.LastIndexOf('/');
			if (num == -1)
			{
				return false;
			}
			num++;
			return num != text.Length && string.Compare(this.pattern, text.Substring(num), ignorecase) == 0;
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00011D24 File Offset: 0x0000FF24
		public bool IsMatch(string text)
		{
			return this.IsMatch(text, this.ignore);
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x00011D33 File Offset: 0x0000FF33
		public bool HasWildcard
		{
			get
			{
				return this.hasWildcard;
			}
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x000499EC File Offset: 0x00047BEC
		private void Compile(string pattern)
		{
			if (pattern == null || pattern.IndexOfAny(SearchPattern2.InvalidChars) >= 0)
			{
				throw new ArgumentException("Invalid search pattern: '" + pattern + "'");
			}
			if (pattern == "*")
			{
				this.ops = new SearchPattern2.Op(SearchPattern2.OpCode.True);
				this.hasWildcard = true;
				return;
			}
			this.ops = null;
			int i = 0;
			SearchPattern2.Op op = null;
			while (i < pattern.Length)
			{
				char c = pattern[i];
				SearchPattern2.Op op2;
				if (c != '*')
				{
					if (c != '?')
					{
						op2 = new SearchPattern2.Op(SearchPattern2.OpCode.ExactString);
						int num = pattern.IndexOfAny(SearchPattern2.WildcardChars, i);
						if (num < 0)
						{
							num = pattern.Length;
						}
						op2.Argument = pattern.Substring(i, num - i);
						if (this.ignore)
						{
							op2.Argument = op2.Argument.ToLower();
						}
						i = num;
					}
					else
					{
						op2 = new SearchPattern2.Op(SearchPattern2.OpCode.AnyChar);
						i++;
						this.hasWildcard = true;
					}
				}
				else
				{
					op2 = new SearchPattern2.Op(SearchPattern2.OpCode.AnyString);
					i++;
					this.hasWildcard = true;
				}
				if (op == null)
				{
					this.ops = op2;
				}
				else
				{
					op.Next = op2;
				}
				op = op2;
			}
			if (op == null)
			{
				this.ops = new SearchPattern2.Op(SearchPattern2.OpCode.End);
			}
			else
			{
				op.Next = new SearchPattern2.Op(SearchPattern2.OpCode.End);
			}
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x00049B48 File Offset: 0x00047D48
		private bool Match(SearchPattern2.Op op, string text, int ptr)
		{
			while (op != null)
			{
				switch (op.Code)
				{
				case SearchPattern2.OpCode.ExactString:
				{
					int length = op.Argument.Length;
					if (ptr + length > text.Length)
					{
						return false;
					}
					string text2 = text.Substring(ptr, length);
					if (this.ignore)
					{
						text2 = text2.ToLower();
					}
					if (text2 != op.Argument)
					{
						return false;
					}
					ptr += length;
					break;
				}
				case SearchPattern2.OpCode.AnyChar:
					if (++ptr > text.Length)
					{
						return false;
					}
					break;
				case SearchPattern2.OpCode.AnyString:
					while (ptr <= text.Length)
					{
						if (this.Match(op.Next, text, ptr))
						{
							return true;
						}
						ptr++;
					}
					return false;
				case SearchPattern2.OpCode.End:
					return ptr == text.Length;
				case SearchPattern2.OpCode.True:
					return true;
				}
				op = op.Next;
			}
			return true;
		}

		// Token: 0x04000F27 RID: 3879
		private SearchPattern2.Op ops;

		// Token: 0x04000F28 RID: 3880
		private bool ignore;

		// Token: 0x04000F29 RID: 3881
		private bool hasWildcard;

		// Token: 0x04000F2A RID: 3882
		private string pattern;

		// Token: 0x04000F2B RID: 3883
		internal static readonly char[] WildcardChars = new char[] { '*', '?' };

		// Token: 0x04000F2C RID: 3884
		internal static readonly char[] InvalidChars = new char[]
		{
			Path.DirectorySeparatorChar,
			Path.AltDirectorySeparatorChar
		};

		// Token: 0x020002B5 RID: 693
		private class Op
		{
			// Token: 0x060017FC RID: 6140 RVA: 0x00011D3B File Offset: 0x0000FF3B
			public Op(SearchPattern2.OpCode code)
			{
				this.Code = code;
				this.Argument = null;
				this.Next = null;
			}

			// Token: 0x04000F2D RID: 3885
			public SearchPattern2.OpCode Code;

			// Token: 0x04000F2E RID: 3886
			public string Argument;

			// Token: 0x04000F2F RID: 3887
			public SearchPattern2.Op Next;
		}

		// Token: 0x020002B6 RID: 694
		private enum OpCode
		{
			// Token: 0x04000F31 RID: 3889
			ExactString,
			// Token: 0x04000F32 RID: 3890
			AnyChar,
			// Token: 0x04000F33 RID: 3891
			AnyString,
			// Token: 0x04000F34 RID: 3892
			End,
			// Token: 0x04000F35 RID: 3893
			True
		}
	}
}
