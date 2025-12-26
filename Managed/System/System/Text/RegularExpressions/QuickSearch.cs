using System;
using System.Collections;

namespace System.Text.RegularExpressions
{
	// Token: 0x020004A6 RID: 1190
	internal class QuickSearch
	{
		// Token: 0x06002A09 RID: 10761 RVA: 0x0001D430 File Offset: 0x0001B630
		public QuickSearch(string str, bool ignore)
			: this(str, ignore, false)
		{
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x00084448 File Offset: 0x00082648
		public QuickSearch(string str, bool ignore, bool reverse)
		{
			this.str = str;
			this.len = str.Length;
			this.ignore = ignore;
			this.reverse = reverse;
			if (ignore)
			{
				str = str.ToLower();
			}
			if (this.len > QuickSearch.THRESHOLD)
			{
				this.SetupShiftTable();
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06002A0C RID: 10764 RVA: 0x0001D443 File Offset: 0x0001B643
		public string String
		{
			get
			{
				return this.str;
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06002A0D RID: 10765 RVA: 0x0001D44B File Offset: 0x0001B64B
		public int Length
		{
			get
			{
				return this.len;
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06002A0E RID: 10766 RVA: 0x0001D453 File Offset: 0x0001B653
		public bool IgnoreCase
		{
			get
			{
				return this.ignore;
			}
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x000844A0 File Offset: 0x000826A0
		public int Search(string text, int start, int end)
		{
			int i = start;
			if (this.reverse)
			{
				if (start < end)
				{
					return -1;
				}
				if (i > text.Length)
				{
					i = text.Length;
				}
				if (this.len == 1)
				{
					while (--i >= end)
					{
						if (this.str[0] == this.GetChar(text[i]))
						{
							return i;
						}
					}
					return -1;
				}
				if (end < this.len)
				{
					end = this.len - 1;
				}
				for (i--; i >= end; i -= this.GetShiftDistance(text[i - this.len]))
				{
					int num = this.len - 1;
					while (this.str[num] == this.GetChar(text[i - this.len + 1 + num]))
					{
						if (--num < 0)
						{
							return i - this.len + 1;
						}
					}
					if (i <= end)
					{
						break;
					}
				}
			}
			else
			{
				if (this.len == 1)
				{
					while (i <= end)
					{
						if (this.str[0] == this.GetChar(text[i]))
						{
							return i;
						}
						i++;
					}
					return -1;
				}
				if (end > text.Length - this.len)
				{
					end = text.Length - this.len;
				}
				while (i <= end)
				{
					int num2 = this.len - 1;
					while (this.str[num2] == this.GetChar(text[i + num2]))
					{
						if (--num2 < 0)
						{
							return i;
						}
					}
					if (i >= end)
					{
						break;
					}
					i += this.GetShiftDistance(text[i + this.len]);
				}
			}
			return -1;
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x00084684 File Offset: 0x00082884
		private void SetupShiftTable()
		{
			bool flag = this.len > 254;
			byte b = 0;
			for (int i = 0; i < this.len; i++)
			{
				char c = this.str[i];
				if (c <= 'ÿ')
				{
					if ((byte)c > b)
					{
						b = (byte)c;
					}
				}
				else
				{
					flag = true;
				}
			}
			this.shift = new byte[(int)(b + 1)];
			if (flag)
			{
				this.shiftExtended = new Hashtable();
			}
			int j = 0;
			int num = this.len;
			while (j < this.len)
			{
				char c2 = this.str[this.reverse ? (num - 1) : j];
				if ((int)c2 >= this.shift.Length)
				{
					goto IL_00DD;
				}
				if (num >= 255)
				{
					this.shift[(int)c2] = byte.MaxValue;
					goto IL_00DD;
				}
				this.shift[(int)c2] = (byte)num;
				IL_00F6:
				j++;
				num--;
				continue;
				IL_00DD:
				this.shiftExtended[c2] = num;
				goto IL_00F6;
			}
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x000847A0 File Offset: 0x000829A0
		private int GetShiftDistance(char c)
		{
			if (this.shift == null)
			{
				return 1;
			}
			c = this.GetChar(c);
			if ((int)c < this.shift.Length)
			{
				int num = (int)this.shift[(int)c];
				if (num == 0)
				{
					return this.len + 1;
				}
				if (num != 255)
				{
					return num;
				}
			}
			else if (c < 'ÿ')
			{
				return this.len + 1;
			}
			if (this.shiftExtended == null)
			{
				return this.len + 1;
			}
			object obj = this.shiftExtended[c];
			return (obj == null) ? (this.len + 1) : ((int)obj);
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x0001D45B File Offset: 0x0001B65B
		private char GetChar(char c)
		{
			return this.ignore ? char.ToLower(c) : c;
		}

		// Token: 0x04001A25 RID: 6693
		private string str;

		// Token: 0x04001A26 RID: 6694
		private int len;

		// Token: 0x04001A27 RID: 6695
		private bool ignore;

		// Token: 0x04001A28 RID: 6696
		private bool reverse;

		// Token: 0x04001A29 RID: 6697
		private byte[] shift;

		// Token: 0x04001A2A RID: 6698
		private Hashtable shiftExtended;

		// Token: 0x04001A2B RID: 6699
		private static readonly int THRESHOLD = 5;
	}
}
