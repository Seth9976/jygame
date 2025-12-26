using System;

namespace System.Text.RegularExpressions.Syntax
{
	// Token: 0x020004C2 RID: 1218
	internal class Literal : Expression
	{
		// Token: 0x06002B29 RID: 11049 RVA: 0x0001DFDE File Offset: 0x0001C1DE
		public Literal(string str, bool ignore)
		{
			this.str = str;
			this.ignore = ignore;
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06002B2A RID: 11050 RVA: 0x0001DFF4 File Offset: 0x0001C1F4
		// (set) Token: 0x06002B2B RID: 11051 RVA: 0x0001DFFC File Offset: 0x0001C1FC
		public string String
		{
			get
			{
				return this.str;
			}
			set
			{
				this.str = value;
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06002B2C RID: 11052 RVA: 0x0001E005 File Offset: 0x0001C205
		// (set) Token: 0x06002B2D RID: 11053 RVA: 0x0001E00D File Offset: 0x0001C20D
		public bool IgnoreCase
		{
			get
			{
				return this.ignore;
			}
			set
			{
				this.ignore = value;
			}
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x0001E016 File Offset: 0x0001C216
		public static void CompileLiteral(string str, ICompiler cmp, bool ignore, bool reverse)
		{
			if (str.Length == 0)
			{
				return;
			}
			if (str.Length == 1)
			{
				cmp.EmitCharacter(str[0], false, ignore, reverse);
			}
			else
			{
				cmp.EmitString(str, ignore, reverse);
			}
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x0001E04E File Offset: 0x0001C24E
		public override void Compile(ICompiler cmp, bool reverse)
		{
			Literal.CompileLiteral(this.str, cmp, this.ignore, reverse);
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x0008B6AC File Offset: 0x000898AC
		public override void GetWidth(out int min, out int max)
		{
			min = (max = this.str.Length);
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x0001E063 File Offset: 0x0001C263
		public override AnchorInfo GetAnchorInfo(bool reverse)
		{
			return new AnchorInfo(this, 0, this.str.Length, this.str, this.ignore);
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool IsComplex()
		{
			return false;
		}

		// Token: 0x04001B2C RID: 6956
		private string str;

		// Token: 0x04001B2D RID: 6957
		private bool ignore;
	}
}
