using System;

namespace System.Net
{
	// Token: 0x0200033A RID: 826
	internal class CookieParser
	{
		// Token: 0x06001CFA RID: 7418 RVA: 0x00014FB0 File Offset: 0x000131B0
		public CookieParser(string header)
			: this(header, 0)
		{
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x00014FBA File Offset: 0x000131BA
		public CookieParser(string header, int position)
		{
			this.header = header;
			this.pos = position;
			this.length = header.Length;
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x00058580 File Offset: 0x00056780
		public bool GetNextNameValue(out string name, out string val)
		{
			name = null;
			val = null;
			if (this.pos >= this.length)
			{
				return false;
			}
			name = this.GetCookieName();
			if (this.pos < this.header.Length && this.header[this.pos] == '=')
			{
				this.pos++;
				val = this.GetCookieValue();
			}
			if (this.pos < this.length && this.header[this.pos] == ';')
			{
				this.pos++;
			}
			return true;
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x0005862C File Offset: 0x0005682C
		private string GetCookieName()
		{
			int num = this.pos;
			while (num < this.length && char.IsWhiteSpace(this.header[num]))
			{
				num++;
			}
			int num2 = num;
			while (num < this.length && this.header[num] != ';' && this.header[num] != '=')
			{
				num++;
			}
			this.pos = num;
			return this.header.Substring(num2, num - num2).Trim();
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x000586C4 File Offset: 0x000568C4
		private string GetCookieValue()
		{
			if (this.pos >= this.length)
			{
				return null;
			}
			int num = this.pos;
			while (num < this.length && char.IsWhiteSpace(this.header[num]))
			{
				num++;
			}
			int num2;
			if (this.header[num] == '"')
			{
				num = (num2 = num + 1);
				while (num < this.length && this.header[num] != '"')
				{
					num++;
				}
				int num3 = num;
				while (num3 < this.length && this.header[num3] != ';')
				{
					num3++;
				}
				this.pos = num3;
			}
			else
			{
				num2 = num;
				while (num < this.length && this.header[num] != ';')
				{
					num++;
				}
				this.pos = num;
			}
			return this.header.Substring(num2, num - num2).Trim();
		}

		// Token: 0x04001219 RID: 4633
		private string header;

		// Token: 0x0400121A RID: 4634
		private int pos;

		// Token: 0x0400121B RID: 4635
		private int length;
	}
}
