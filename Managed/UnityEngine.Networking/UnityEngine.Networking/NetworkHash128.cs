using System;

namespace UnityEngine.Networking
{
	// Token: 0x0200003C RID: 60
	[Serializable]
	public struct NetworkHash128
	{
		// Token: 0x060001D3 RID: 467 RVA: 0x00009774 File Offset: 0x00007974
		public void Reset()
		{
			this.i0 = 0;
			this.i1 = 0;
			this.i2 = 0;
			this.i3 = 0;
			this.i4 = 0;
			this.i5 = 0;
			this.i6 = 0;
			this.i7 = 0;
			this.i8 = 0;
			this.i9 = 0;
			this.i10 = 0;
			this.i11 = 0;
			this.i12 = 0;
			this.i13 = 0;
			this.i14 = 0;
			this.i15 = 0;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000097F4 File Offset: 0x000079F4
		public bool IsValid()
		{
			return (this.i0 | this.i1 | this.i2 | this.i3 | this.i4 | this.i5 | this.i6 | this.i7 | this.i8 | this.i9 | this.i10 | this.i11 | this.i12 | this.i13 | this.i14 | this.i15) != 0;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00009878 File Offset: 0x00007A78
		private static int HexToNumber(char c)
		{
			if (c >= '0' && c <= '9')
			{
				return (int)(c - '0');
			}
			if (c >= 'a' && c <= 'f')
			{
				return (int)(c - 'a' + '\n');
			}
			if (c >= 'A' && c <= 'F')
			{
				return (int)(c - 'A' + '\n');
			}
			return 0;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000098CC File Offset: 0x00007ACC
		public static NetworkHash128 Parse(string text)
		{
			int length = text.Length;
			if (length < 32)
			{
				string text2 = string.Empty;
				for (int i = 0; i < 32 - length; i++)
				{
					text2 += "0";
				}
				text = text2 + text;
			}
			NetworkHash128 networkHash;
			networkHash.i0 = (byte)(NetworkHash128.HexToNumber(text[0]) * 16 + NetworkHash128.HexToNumber(text[1]));
			networkHash.i1 = (byte)(NetworkHash128.HexToNumber(text[2]) * 16 + NetworkHash128.HexToNumber(text[3]));
			networkHash.i2 = (byte)(NetworkHash128.HexToNumber(text[4]) * 16 + NetworkHash128.HexToNumber(text[5]));
			networkHash.i3 = (byte)(NetworkHash128.HexToNumber(text[6]) * 16 + NetworkHash128.HexToNumber(text[7]));
			networkHash.i4 = (byte)(NetworkHash128.HexToNumber(text[8]) * 16 + NetworkHash128.HexToNumber(text[9]));
			networkHash.i5 = (byte)(NetworkHash128.HexToNumber(text[10]) * 16 + NetworkHash128.HexToNumber(text[11]));
			networkHash.i6 = (byte)(NetworkHash128.HexToNumber(text[12]) * 16 + NetworkHash128.HexToNumber(text[13]));
			networkHash.i7 = (byte)(NetworkHash128.HexToNumber(text[14]) * 16 + NetworkHash128.HexToNumber(text[15]));
			networkHash.i8 = (byte)(NetworkHash128.HexToNumber(text[16]) * 16 + NetworkHash128.HexToNumber(text[17]));
			networkHash.i9 = (byte)(NetworkHash128.HexToNumber(text[18]) * 16 + NetworkHash128.HexToNumber(text[19]));
			networkHash.i10 = (byte)(NetworkHash128.HexToNumber(text[20]) * 16 + NetworkHash128.HexToNumber(text[21]));
			networkHash.i11 = (byte)(NetworkHash128.HexToNumber(text[22]) * 16 + NetworkHash128.HexToNumber(text[23]));
			networkHash.i12 = (byte)(NetworkHash128.HexToNumber(text[24]) * 16 + NetworkHash128.HexToNumber(text[25]));
			networkHash.i13 = (byte)(NetworkHash128.HexToNumber(text[26]) * 16 + NetworkHash128.HexToNumber(text[27]));
			networkHash.i14 = (byte)(NetworkHash128.HexToNumber(text[28]) * 16 + NetworkHash128.HexToNumber(text[29]));
			networkHash.i15 = (byte)(NetworkHash128.HexToNumber(text[30]) * 16 + NetworkHash128.HexToNumber(text[31]));
			return networkHash;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00009B70 File Offset: 0x00007D70
		public override string ToString()
		{
			return string.Format("{0:x}{1:x}{2:x}{3:x}{4:x}{5:x}{6:x}{7:x}{8:x}{9:x}{10:x}{11:x}{12:x}{13:x}{14:x}{15:x}", new object[]
			{
				this.i0, this.i1, this.i2, this.i3, this.i4, this.i5, this.i6, this.i7, this.i8, this.i9,
				this.i10, this.i11, this.i12, this.i13, this.i14, this.i15
			});
		}

		// Token: 0x040000EC RID: 236
		public byte i0;

		// Token: 0x040000ED RID: 237
		public byte i1;

		// Token: 0x040000EE RID: 238
		public byte i2;

		// Token: 0x040000EF RID: 239
		public byte i3;

		// Token: 0x040000F0 RID: 240
		public byte i4;

		// Token: 0x040000F1 RID: 241
		public byte i5;

		// Token: 0x040000F2 RID: 242
		public byte i6;

		// Token: 0x040000F3 RID: 243
		public byte i7;

		// Token: 0x040000F4 RID: 244
		public byte i8;

		// Token: 0x040000F5 RID: 245
		public byte i9;

		// Token: 0x040000F6 RID: 246
		public byte i10;

		// Token: 0x040000F7 RID: 247
		public byte i11;

		// Token: 0x040000F8 RID: 248
		public byte i12;

		// Token: 0x040000F9 RID: 249
		public byte i13;

		// Token: 0x040000FA RID: 250
		public byte i14;

		// Token: 0x040000FB RID: 251
		public byte i15;
	}
}
