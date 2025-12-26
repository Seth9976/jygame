using System;

namespace System
{
	// Token: 0x020004F6 RID: 1270
	internal class UriData : global::System.IUriData
	{
		// Token: 0x06002C82 RID: 11394 RVA: 0x0001EBBD File Offset: 0x0001CDBD
		public UriData(global::System.Uri uri, global::System.UriParser parser)
		{
			this.uri = uri;
			this.parser = parser;
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x0001EBD3 File Offset: 0x0001CDD3
		private string Lookup(ref string cache, global::System.UriComponents components)
		{
			return this.Lookup(ref cache, components, (!this.uri.UserEscaped) ? global::System.UriFormat.UriEscaped : global::System.UriFormat.Unescaped);
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x0001EBF4 File Offset: 0x0001CDF4
		private string Lookup(ref string cache, global::System.UriComponents components, global::System.UriFormat format)
		{
			if (cache == null)
			{
				cache = this.parser.GetComponents(this.uri, components, format);
			}
			return cache;
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06002C85 RID: 11397 RVA: 0x0001EC14 File Offset: 0x0001CE14
		public string AbsolutePath
		{
			get
			{
				return this.Lookup(ref this.absolute_path, global::System.UriComponents.Path | global::System.UriComponents.KeepDelimiter);
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06002C86 RID: 11398 RVA: 0x0001EC27 File Offset: 0x0001CE27
		public string AbsoluteUri
		{
			get
			{
				return this.Lookup(ref this.absolute_uri, global::System.UriComponents.AbsoluteUri);
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06002C87 RID: 11399 RVA: 0x0001EC37 File Offset: 0x0001CE37
		public string AbsoluteUri_SafeUnescaped
		{
			get
			{
				return this.Lookup(ref this.absolute_uri_unescaped, global::System.UriComponents.AbsoluteUri, global::System.UriFormat.SafeUnescaped);
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06002C88 RID: 11400 RVA: 0x0001EC48 File Offset: 0x0001CE48
		public string Authority
		{
			get
			{
				return this.Lookup(ref this.authority, global::System.UriComponents.Host | global::System.UriComponents.Port);
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06002C89 RID: 11401 RVA: 0x0001EC58 File Offset: 0x0001CE58
		public string Fragment
		{
			get
			{
				return this.Lookup(ref this.fragment, global::System.UriComponents.Fragment | global::System.UriComponents.KeepDelimiter);
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06002C8A RID: 11402 RVA: 0x0001EC6B File Offset: 0x0001CE6B
		public string Host
		{
			get
			{
				return this.Lookup(ref this.host, global::System.UriComponents.Host);
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06002C8B RID: 11403 RVA: 0x0001EC7A File Offset: 0x0001CE7A
		public string PathAndQuery
		{
			get
			{
				return this.Lookup(ref this.path_and_query, global::System.UriComponents.PathAndQuery);
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06002C8C RID: 11404 RVA: 0x0001EC8A File Offset: 0x0001CE8A
		public string StrongPort
		{
			get
			{
				return this.Lookup(ref this.strong_port, global::System.UriComponents.StrongPort);
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06002C8D RID: 11405 RVA: 0x0001EC9D File Offset: 0x0001CE9D
		public string Query
		{
			get
			{
				return this.Lookup(ref this.query, global::System.UriComponents.Query | global::System.UriComponents.KeepDelimiter);
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06002C8E RID: 11406 RVA: 0x0001ECB0 File Offset: 0x0001CEB0
		public string UserInfo
		{
			get
			{
				return this.Lookup(ref this.user_info, global::System.UriComponents.UserInfo);
			}
		}

		// Token: 0x04001BED RID: 7149
		private global::System.Uri uri;

		// Token: 0x04001BEE RID: 7150
		private global::System.UriParser parser;

		// Token: 0x04001BEF RID: 7151
		private string absolute_path;

		// Token: 0x04001BF0 RID: 7152
		private string absolute_uri;

		// Token: 0x04001BF1 RID: 7153
		private string absolute_uri_unescaped;

		// Token: 0x04001BF2 RID: 7154
		private string authority;

		// Token: 0x04001BF3 RID: 7155
		private string fragment;

		// Token: 0x04001BF4 RID: 7156
		private string host;

		// Token: 0x04001BF5 RID: 7157
		private string path_and_query;

		// Token: 0x04001BF6 RID: 7158
		private string strong_port;

		// Token: 0x04001BF7 RID: 7159
		private string query;

		// Token: 0x04001BF8 RID: 7160
		private string user_info;
	}
}
