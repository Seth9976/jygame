using System;
using System.Collections;

namespace System.Text.RegularExpressions.Syntax
{
	// Token: 0x020004C5 RID: 1221
	internal class BackslashNumber : Reference
	{
		// Token: 0x06002B42 RID: 11074 RVA: 0x0001E108 File Offset: 0x0001C308
		public BackslashNumber(bool ignore, bool ecma)
			: base(ignore)
		{
			this.ecma = ecma;
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x0008B728 File Offset: 0x00089928
		public bool ResolveReference(string num_str, Hashtable groups)
		{
			if (this.ecma)
			{
				int num = 0;
				for (int i = 1; i < num_str.Length; i++)
				{
					if (groups[num_str.Substring(0, i)] != null)
					{
						num = i;
					}
				}
				if (num != 0)
				{
					base.CapturingGroup = (CapturingGroup)groups[num_str.Substring(0, num)];
					this.literal = num_str.Substring(num);
					return true;
				}
			}
			else if (num_str.Length == 1)
			{
				return false;
			}
			int num2 = 0;
			int num3 = Parser.ParseOctal(num_str, ref num2);
			if (num3 == -1)
			{
				return false;
			}
			if (num3 > 255 && this.ecma)
			{
				num3 /= 8;
				num2--;
			}
			num3 &= 255;
			this.literal = (char)num3 + num_str.Substring(num2);
			return true;
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x0001E118 File Offset: 0x0001C318
		public override void Compile(ICompiler cmp, bool reverse)
		{
			if (base.CapturingGroup != null)
			{
				base.Compile(cmp, reverse);
			}
			if (this.literal != null)
			{
				Literal.CompileLiteral(this.literal, cmp, base.IgnoreCase, reverse);
			}
		}

		// Token: 0x04001B31 RID: 6961
		private string literal;

		// Token: 0x04001B32 RID: 6962
		private bool ecma;
	}
}
