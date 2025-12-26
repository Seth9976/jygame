using System;

namespace System.Net
{
	// Token: 0x02000348 RID: 840
	internal sealed class ListenerPrefix
	{
		// Token: 0x06001D66 RID: 7526 RVA: 0x000153DD File Offset: 0x000135DD
		public ListenerPrefix(string prefix)
		{
			this.original = prefix;
			this.Parse(prefix);
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x000153F3 File Offset: 0x000135F3
		public override string ToString()
		{
			return this.original;
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x000153FB File Offset: 0x000135FB
		// (set) Token: 0x06001D69 RID: 7529 RVA: 0x00015403 File Offset: 0x00013603
		public IPAddress[] Addresses
		{
			get
			{
				return this.addresses;
			}
			set
			{
				this.addresses = value;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x0001540C File Offset: 0x0001360C
		public bool Secure
		{
			get
			{
				return this.secure;
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x00015414 File Offset: 0x00013614
		public string Host
		{
			get
			{
				return this.host;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x0001541C File Offset: 0x0001361C
		public int Port
		{
			get
			{
				return (int)this.port;
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x00015424 File Offset: 0x00013624
		public string Path
		{
			get
			{
				return this.path;
			}
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x0005A088 File Offset: 0x00058288
		public override bool Equals(object o)
		{
			ListenerPrefix listenerPrefix = o as ListenerPrefix;
			return listenerPrefix != null && this.original == listenerPrefix.original;
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x0001542C File Offset: 0x0001362C
		public override int GetHashCode()
		{
			return this.original.GetHashCode();
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x0005A0B8 File Offset: 0x000582B8
		private void Parse(string uri)
		{
			int num = ((!uri.StartsWith("http://")) ? (-1) : 80);
			if (num == -1)
			{
				int num2 = ((!uri.StartsWith("https://")) ? (-1) : 443);
				this.secure = true;
			}
			int length = uri.Length;
			int num3 = uri.IndexOf(':') + 3;
			if (num3 >= length)
			{
				throw new ArgumentException("No host specified.");
			}
			int num4 = uri.IndexOf(':', num3, length - num3);
			if (num4 > 0)
			{
				this.host = uri.Substring(num3, num4 - num3);
				int num5 = uri.IndexOf('/', num4, length - num4);
				this.port = (ushort)int.Parse(uri.Substring(num4 + 1, num5 - num4 - 1));
				this.path = uri.Substring(num5);
			}
			else
			{
				int num5 = uri.IndexOf('/', num3, length - num3);
				this.host = uri.Substring(num3, num5 - num3);
				this.path = uri.Substring(num5);
			}
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x0005A1BC File Offset: 0x000583BC
		public static void CheckUri(string uri)
		{
			if (uri == null)
			{
				throw new ArgumentNullException("uriPrefix");
			}
			int num = ((!uri.StartsWith("http://")) ? (-1) : 80);
			if (num == -1)
			{
				num = ((!uri.StartsWith("https://")) ? (-1) : 443);
			}
			if (num == -1)
			{
				throw new ArgumentException("Only 'http' and 'https' schemes are supported.");
			}
			int length = uri.Length;
			int num2 = uri.IndexOf(':') + 3;
			if (num2 >= length)
			{
				throw new ArgumentException("No host specified.");
			}
			int num3 = uri.IndexOf(':', num2, length - num2);
			if (num2 == num3)
			{
				throw new ArgumentException("No host specified.");
			}
			if (num3 > 0)
			{
				int num4 = uri.IndexOf('/', num3, length - num3);
				if (num4 == -1)
				{
					throw new ArgumentException("No path specified.");
				}
				try
				{
					int num5 = int.Parse(uri.Substring(num3 + 1, num4 - num3 - 1));
					if (num5 <= 0 || num5 >= 65536)
					{
						throw new Exception();
					}
				}
				catch
				{
					throw new ArgumentException("Invalid port.");
				}
			}
			else
			{
				int num4 = uri.IndexOf('/', num2, length - num2);
				if (num4 == -1)
				{
					throw new ArgumentException("No path specified.");
				}
			}
			if (uri[uri.Length - 1] != '/')
			{
				throw new ArgumentException("The prefix must end with '/'");
			}
		}

		// Token: 0x0400123D RID: 4669
		private string original;

		// Token: 0x0400123E RID: 4670
		private string host;

		// Token: 0x0400123F RID: 4671
		private ushort port;

		// Token: 0x04001240 RID: 4672
		private string path;

		// Token: 0x04001241 RID: 4673
		private bool secure;

		// Token: 0x04001242 RID: 4674
		private IPAddress[] addresses;

		// Token: 0x04001243 RID: 4675
		public HttpListener Listener;
	}
}
