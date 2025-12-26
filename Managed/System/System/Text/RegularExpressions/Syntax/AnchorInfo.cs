using System;

namespace System.Text.RegularExpressions.Syntax
{
	// Token: 0x020004C7 RID: 1223
	internal class AnchorInfo
	{
		// Token: 0x06002B53 RID: 11091 RVA: 0x0001E1D6 File Offset: 0x0001C3D6
		public AnchorInfo(Expression expr, int width)
		{
			this.expr = expr;
			this.offset = 0;
			this.width = width;
			this.str = null;
			this.ignore = false;
			this.pos = Position.Any;
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x0008BC64 File Offset: 0x00089E64
		public AnchorInfo(Expression expr, int offset, int width, string str, bool ignore)
		{
			this.expr = expr;
			this.offset = offset;
			this.width = width;
			this.str = ((!ignore) ? str : str.ToLower());
			this.ignore = ignore;
			this.pos = Position.Any;
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x0001E208 File Offset: 0x0001C408
		public AnchorInfo(Expression expr, int offset, int width, Position pos)
		{
			this.expr = expr;
			this.offset = offset;
			this.width = width;
			this.pos = pos;
			this.str = null;
			this.ignore = false;
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06002B56 RID: 11094 RVA: 0x0001E23B File Offset: 0x0001C43B
		public Expression Expression
		{
			get
			{
				return this.expr;
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06002B57 RID: 11095 RVA: 0x0001E243 File Offset: 0x0001C443
		public int Offset
		{
			get
			{
				return this.offset;
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06002B58 RID: 11096 RVA: 0x0001E24B File Offset: 0x0001C44B
		public int Width
		{
			get
			{
				return this.width;
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06002B59 RID: 11097 RVA: 0x0001E253 File Offset: 0x0001C453
		public int Length
		{
			get
			{
				return (this.str == null) ? 0 : this.str.Length;
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06002B5A RID: 11098 RVA: 0x0001E271 File Offset: 0x0001C471
		public bool IsUnknownWidth
		{
			get
			{
				return this.width < 0;
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06002B5B RID: 11099 RVA: 0x0001E27C File Offset: 0x0001C47C
		public bool IsComplete
		{
			get
			{
				return this.Length == this.Width;
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06002B5C RID: 11100 RVA: 0x0001E28C File Offset: 0x0001C48C
		public string Substring
		{
			get
			{
				return this.str;
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06002B5D RID: 11101 RVA: 0x0001E294 File Offset: 0x0001C494
		public bool IgnoreCase
		{
			get
			{
				return this.ignore;
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06002B5E RID: 11102 RVA: 0x0001E29C File Offset: 0x0001C49C
		public Position Position
		{
			get
			{
				return this.pos;
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06002B5F RID: 11103 RVA: 0x0001E2A4 File Offset: 0x0001C4A4
		public bool IsSubstring
		{
			get
			{
				return this.str != null;
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06002B60 RID: 11104 RVA: 0x0001E2B2 File Offset: 0x0001C4B2
		public bool IsPosition
		{
			get
			{
				return this.pos != Position.Any;
			}
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x0001E2C0 File Offset: 0x0001C4C0
		public Interval GetInterval()
		{
			return this.GetInterval(0);
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x0001E2C9 File Offset: 0x0001C4C9
		public Interval GetInterval(int start)
		{
			if (!this.IsSubstring)
			{
				return Interval.Empty;
			}
			return new Interval(start + this.Offset, start + this.Offset + this.Length - 1);
		}

		// Token: 0x04001B3A RID: 6970
		private Expression expr;

		// Token: 0x04001B3B RID: 6971
		private Position pos;

		// Token: 0x04001B3C RID: 6972
		private int offset;

		// Token: 0x04001B3D RID: 6973
		private string str;

		// Token: 0x04001B3E RID: 6974
		private int width;

		// Token: 0x04001B3F RID: 6975
		private bool ignore;
	}
}
