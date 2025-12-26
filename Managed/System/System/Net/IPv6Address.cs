using System;
using System.Globalization;
using System.Net.Sockets;
using System.Text;

namespace System.Net
{
	// Token: 0x02000343 RID: 835
	[Serializable]
	internal class IPv6Address
	{
		// Token: 0x06001D3C RID: 7484 RVA: 0x0001523C File Offset: 0x0001343C
		public IPv6Address(ushort[] addr)
		{
			if (addr == null)
			{
				throw new ArgumentNullException("addr");
			}
			if (addr.Length != 8)
			{
				throw new ArgumentException("addr");
			}
			this.address = addr;
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x00015270 File Offset: 0x00013470
		public IPv6Address(ushort[] addr, int prefixLength)
			: this(addr)
		{
			if (prefixLength < 0 || prefixLength > 128)
			{
				throw new ArgumentException("prefixLength");
			}
			this.prefixLength = prefixLength;
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x0001529D File Offset: 0x0001349D
		public IPv6Address(ushort[] addr, int prefixLength, int scopeId)
			: this(addr, prefixLength)
		{
			this.scopeId = (long)scopeId;
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x00059458 File Offset: 0x00057658
		public static IPv6Address Parse(string ipString)
		{
			if (ipString == null)
			{
				throw new ArgumentNullException("ipString");
			}
			IPv6Address pv6Address;
			if (IPv6Address.TryParse(ipString, out pv6Address))
			{
				return pv6Address;
			}
			throw new FormatException("Not a valid IPv6 address");
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x00059490 File Offset: 0x00057690
		private static int Fill(ushort[] addr, string ipString)
		{
			int num = 0;
			int num2 = 0;
			if (ipString.Length == 0)
			{
				return 0;
			}
			if (ipString.IndexOf("::") != -1)
			{
				return -1;
			}
			for (int i = 0; i < ipString.Length; i++)
			{
				char c = ipString[i];
				if (c == ':')
				{
					if (i == ipString.Length - 1)
					{
						return -1;
					}
					if (num2 == 8)
					{
						return -1;
					}
					addr[num2++] = (ushort)num;
					num = 0;
				}
				else
				{
					int num3;
					if ('0' <= c && c <= '9')
					{
						num3 = (int)(c - '0');
					}
					else if ('a' <= c && c <= 'f')
					{
						num3 = (int)(c - 'a' + '\n');
					}
					else
					{
						if ('A' > c || c > 'F')
						{
							return -1;
						}
						num3 = (int)(c - 'A' + '\n');
					}
					num = (num << 4) + num3;
					if (num > 65535)
					{
						return -1;
					}
				}
			}
			if (num2 == 8)
			{
				return -1;
			}
			addr[num2++] = (ushort)num;
			return num2;
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x000152CF File Offset: 0x000134CF
		private static bool TryParse(string prefix, out int res)
		{
			return int.TryParse(prefix, NumberStyles.Integer, CultureInfo.InvariantCulture, out res);
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x00059594 File Offset: 0x00057794
		public static bool TryParse(string ipString, out IPv6Address result)
		{
			result = null;
			if (ipString == null)
			{
				return false;
			}
			if (ipString.Length > 2 && ipString[0] == '[' && ipString[ipString.Length - 1] == ']')
			{
				ipString = ipString.Substring(1, ipString.Length - 2);
			}
			if (ipString.Length < 2)
			{
				return false;
			}
			int num = 0;
			int num2 = 0;
			int num3 = ipString.LastIndexOf('/');
			if (num3 != -1)
			{
				string text = ipString.Substring(num3 + 1);
				if (!IPv6Address.TryParse(text, out num))
				{
					num = -1;
				}
				if (num < 0 || num > 128)
				{
					return false;
				}
				ipString = ipString.Substring(0, num3);
			}
			else
			{
				num3 = ipString.LastIndexOf('%');
				if (num3 != -1)
				{
					string text2 = ipString.Substring(num3 + 1);
					if (!IPv6Address.TryParse(text2, out num2))
					{
						num2 = 0;
					}
					ipString = ipString.Substring(0, num3);
				}
			}
			ushort[] array = new ushort[8];
			bool flag = false;
			int num4 = ipString.LastIndexOf(':');
			if (num4 == -1)
			{
				return false;
			}
			int num5 = 0;
			if (num4 < ipString.Length - 1)
			{
				string text3 = ipString.Substring(num4 + 1);
				if (text3.IndexOf('.') != -1)
				{
					IPAddress ipaddress;
					if (!IPAddress.TryParse(text3, out ipaddress))
					{
						return false;
					}
					long internalIPv4Address = ipaddress.InternalIPv4Address;
					array[6] = (ushort)(((int)(internalIPv4Address & 255L) << 8) + (int)((internalIPv4Address >> 8) & 255L));
					array[7] = (ushort)(((int)((internalIPv4Address >> 16) & 255L) << 8) + (int)((internalIPv4Address >> 24) & 255L));
					if (num4 > 0 && ipString[num4 - 1] == ':')
					{
						ipString = ipString.Substring(0, num4 + 1);
					}
					else
					{
						ipString = ipString.Substring(0, num4);
					}
					flag = true;
					num5 = 2;
				}
			}
			int num6 = ipString.IndexOf("::");
			if (num6 != -1)
			{
				int num7 = IPv6Address.Fill(array, ipString.Substring(num6 + 2));
				if (num7 == -1)
				{
					return false;
				}
				if (num7 + num5 > 8)
				{
					return false;
				}
				int num8 = 8 - num5 - num7;
				for (int i = num7; i > 0; i--)
				{
					array[i + num8 - 1] = array[i - 1];
					array[i - 1] = 0;
				}
				int num9 = IPv6Address.Fill(array, ipString.Substring(0, num6));
				if (num9 == -1)
				{
					return false;
				}
				if (num9 + num7 + num5 > 7)
				{
					return false;
				}
			}
			else if (IPv6Address.Fill(array, ipString) != 8 - num5)
			{
				return false;
			}
			bool flag2 = false;
			for (int j = 0; j < num5; j++)
			{
				if (array[j] != 0 || (j == 5 && array[j] != 65535))
				{
					flag2 = true;
				}
			}
			if (flag && !flag2)
			{
				for (int k = 0; k < 5; k++)
				{
					if (array[k] != 0)
					{
						return false;
					}
				}
				if (array[5] != 0 && array[5] != 65535)
				{
					return false;
				}
			}
			result = new IPv6Address(array, num, num2);
			return true;
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x000152DE File Offset: 0x000134DE
		public ushort[] Address
		{
			get
			{
				return this.address;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x000152E6 File Offset: 0x000134E6
		public int PrefixLength
		{
			get
			{
				return this.prefixLength;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06001D46 RID: 7494 RVA: 0x000152EE File Offset: 0x000134EE
		// (set) Token: 0x06001D47 RID: 7495 RVA: 0x000152F6 File Offset: 0x000134F6
		public long ScopeId
		{
			get
			{
				return this.scopeId;
			}
			set
			{
				this.scopeId = value;
			}
		}

		// Token: 0x1700073C RID: 1852
		public ushort this[int index]
		{
			get
			{
				return this.address[index];
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06001D49 RID: 7497 RVA: 0x00015309 File Offset: 0x00013509
		public global::System.Net.Sockets.AddressFamily AddressFamily
		{
			get
			{
				return global::System.Net.Sockets.AddressFamily.InterNetworkV6;
			}
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x000598B0 File Offset: 0x00057AB0
		public static bool IsLoopback(IPv6Address addr)
		{
			if (addr.address[7] != 1)
			{
				return false;
			}
			int num = addr.address[6] >> 8;
			if (num != 127 && num != 0)
			{
				return false;
			}
			for (int i = 0; i < 4; i++)
			{
				if (addr.address[i] != 0)
				{
					return false;
				}
			}
			return addr.address[5] == 0 || addr.address[5] == ushort.MaxValue;
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x0001530D File Offset: 0x0001350D
		private static ushort SwapUShort(ushort number)
		{
			return (ushort)(((number >> 8) & 255) + (((int)number << 8) & 65280));
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x00015323 File Offset: 0x00013523
		private int AsIPv4Int()
		{
			return ((int)IPv6Address.SwapUShort(this.address[7]) << 16) + (int)IPv6Address.SwapUShort(this.address[6]);
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x0005992C File Offset: 0x00057B2C
		public bool IsIPv4Compatible()
		{
			for (int i = 0; i < 6; i++)
			{
				if (this.address[i] != 0)
				{
					return false;
				}
			}
			return this.AsIPv4Int() > 1;
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x00059964 File Offset: 0x00057B64
		public bool IsIPv4Mapped()
		{
			for (int i = 0; i < 5; i++)
			{
				if (this.address[i] != 0)
				{
					return false;
				}
			}
			return this.address[5] == ushort.MaxValue;
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x000599A4 File Offset: 0x00057BA4
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this.IsIPv4Compatible() || this.IsIPv4Mapped())
			{
				stringBuilder.Append("::");
				if (this.IsIPv4Mapped())
				{
					stringBuilder.Append("ffff:");
				}
				stringBuilder.Append(new IPAddress((long)this.AsIPv4Int()).ToString());
				return stringBuilder.ToString();
			}
			int num = -1;
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < 8; i++)
			{
				if (this.address[i] != 0)
				{
					if (num3 > num2 && num3 > 1)
					{
						num2 = num3;
						num = i - num3;
					}
					num3 = 0;
				}
				else
				{
					num3++;
				}
			}
			if (num3 > num2 && num3 > 1)
			{
				num2 = num3;
				num = 8 - num3;
			}
			if (num == 0)
			{
				stringBuilder.Append(":");
			}
			for (int j = 0; j < 8; j++)
			{
				if (j == num)
				{
					stringBuilder.Append(":");
					j += num2 - 1;
				}
				else
				{
					stringBuilder.AppendFormat("{0:x}", this.address[j]);
					if (j < 7)
					{
						stringBuilder.Append(':');
					}
				}
			}
			if (this.scopeId != 0L)
			{
				stringBuilder.Append('%').Append(this.scopeId);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x00059B08 File Offset: 0x00057D08
		public string ToString(bool fullLength)
		{
			if (!fullLength)
			{
				return this.ToString();
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < this.address.Length - 1; i++)
			{
				stringBuilder.AppendFormat("{0:X4}:", this.address[i]);
			}
			stringBuilder.AppendFormat("{0:X4}", this.address[this.address.Length - 1]);
			return stringBuilder.ToString();
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x00059B84 File Offset: 0x00057D84
		public override bool Equals(object other)
		{
			IPv6Address pv6Address = other as IPv6Address;
			if (pv6Address != null)
			{
				for (int i = 0; i < 8; i++)
				{
					if (this.address[i] != pv6Address.address[i])
					{
						return false;
					}
				}
				return true;
			}
			IPAddress ipaddress = other as IPAddress;
			if (ipaddress == null)
			{
				return false;
			}
			for (int j = 0; j < 5; j++)
			{
				if (this.address[j] != 0)
				{
					return false;
				}
			}
			if (this.address[5] != 0 && this.address[5] != 65535)
			{
				return false;
			}
			long internalIPv4Address = ipaddress.InternalIPv4Address;
			return this.address[6] == (ushort)(((int)(internalIPv4Address & 255L) << 8) + (int)((internalIPv4Address >> 8) & 255L)) && this.address[7] == (ushort)(((int)((internalIPv4Address >> 16) & 255L) << 8) + (int)((internalIPv4Address >> 24) & 255L));
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x00059C78 File Offset: 0x00057E78
		public override int GetHashCode()
		{
			return IPv6Address.Hash(((int)this.address[0] << 16) + (int)this.address[1], ((int)this.address[2] << 16) + (int)this.address[3], ((int)this.address[4] << 16) + (int)this.address[5], ((int)this.address[6] << 16) + (int)this.address[7]);
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x00015126 File Offset: 0x00013326
		private static int Hash(int i, int j, int k, int l)
		{
			return i ^ ((j << 13) | (j >> 19)) ^ ((k << 26) | (k >> 6)) ^ ((l << 7) | (l >> 25));
		}

		// Token: 0x0400122F RID: 4655
		private ushort[] address;

		// Token: 0x04001230 RID: 4656
		private int prefixLength;

		// Token: 0x04001231 RID: 4657
		private long scopeId;

		// Token: 0x04001232 RID: 4658
		public static readonly IPv6Address Loopback = IPv6Address.Parse("::1");

		// Token: 0x04001233 RID: 4659
		public static readonly IPv6Address Unspecified = IPv6Address.Parse("::");
	}
}
