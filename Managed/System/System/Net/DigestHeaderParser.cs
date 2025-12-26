using System;

namespace System.Net
{
	// Token: 0x02000306 RID: 774
	internal class DigestHeaderParser
	{
		// Token: 0x06001A46 RID: 6726 RVA: 0x00013737 File Offset: 0x00011937
		public DigestHeaderParser(string header)
		{
			this.header = header.Trim();
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001A48 RID: 6728 RVA: 0x00013792 File Offset: 0x00011992
		public string Realm
		{
			get
			{
				return this.values[0];
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001A49 RID: 6729 RVA: 0x0001379C File Offset: 0x0001199C
		public string Opaque
		{
			get
			{
				return this.values[1];
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001A4A RID: 6730 RVA: 0x000137A6 File Offset: 0x000119A6
		public string Nonce
		{
			get
			{
				return this.values[2];
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001A4B RID: 6731 RVA: 0x000137B0 File Offset: 0x000119B0
		public string Algorithm
		{
			get
			{
				return this.values[3];
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001A4C RID: 6732 RVA: 0x000137BA File Offset: 0x000119BA
		public string QOP
		{
			get
			{
				return this.values[4];
			}
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x0004E65C File Offset: 0x0004C85C
		public bool Parse()
		{
			if (!this.header.ToLower().StartsWith("digest "))
			{
				return false;
			}
			this.pos = 6;
			this.length = this.header.Length;
			while (this.pos < this.length)
			{
				string text;
				string text2;
				if (!this.GetKeywordAndValue(out text, out text2))
				{
					return false;
				}
				this.SkipWhitespace();
				if (this.pos < this.length && this.header[this.pos] == ',')
				{
					this.pos++;
				}
				int num = Array.IndexOf<string>(DigestHeaderParser.keywords, text);
				if (num != -1)
				{
					if (this.values[num] != null)
					{
						return false;
					}
					this.values[num] = text2;
				}
			}
			return this.Realm != null && this.Nonce != null;
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0004E74C File Offset: 0x0004C94C
		private void SkipWhitespace()
		{
			char c = ' ';
			while (this.pos < this.length && (c == ' ' || c == '\t' || c == '\r' || c == '\n'))
			{
				c = this.header[this.pos++];
			}
			this.pos--;
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0004E7C0 File Offset: 0x0004C9C0
		private string GetKey()
		{
			this.SkipWhitespace();
			int num = this.pos;
			while (this.pos < this.length && this.header[this.pos] != '=')
			{
				this.pos++;
			}
			return this.header.Substring(num, this.pos - num).Trim().ToLower();
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0004E838 File Offset: 0x0004CA38
		private bool GetKeywordAndValue(out string key, out string value)
		{
			key = null;
			value = null;
			key = this.GetKey();
			if (this.pos >= this.length)
			{
				return false;
			}
			this.SkipWhitespace();
			if (this.pos + 1 >= this.length || this.header[this.pos++] != '=')
			{
				return false;
			}
			this.SkipWhitespace();
			if (this.pos + 1 >= this.length)
			{
				return false;
			}
			bool flag = false;
			if (this.header[this.pos] == '"')
			{
				this.pos++;
				flag = true;
			}
			int num = this.pos;
			if (flag)
			{
				this.pos = this.header.IndexOf('"', this.pos);
				if (this.pos == -1)
				{
					return false;
				}
			}
			else
			{
				do
				{
					char c = this.header[this.pos];
					if (c == ',' || c == ' ' || c == '\t' || c == '\r' || c == '\n')
					{
						break;
					}
				}
				while (++this.pos < this.length);
				if (this.pos >= this.length && num == this.pos)
				{
					return false;
				}
			}
			value = this.header.Substring(num, this.pos - num);
			this.pos += 2;
			return true;
		}

		// Token: 0x04001052 RID: 4178
		private string header;

		// Token: 0x04001053 RID: 4179
		private int length;

		// Token: 0x04001054 RID: 4180
		private int pos;

		// Token: 0x04001055 RID: 4181
		private static string[] keywords = new string[] { "realm", "opaque", "nonce", "algorithm", "qop" };

		// Token: 0x04001056 RID: 4182
		private string[] values = new string[DigestHeaderParser.keywords.Length];
	}
}
