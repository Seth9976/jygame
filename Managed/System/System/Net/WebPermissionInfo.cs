using System;
using System.Text.RegularExpressions;

namespace System.Net
{
	// Token: 0x02000438 RID: 1080
	internal class WebPermissionInfo
	{
		// Token: 0x06002667 RID: 9831 RVA: 0x0001AF0C File Offset: 0x0001910C
		public WebPermissionInfo(WebPermissionInfoType type, string info)
		{
			this._type = type;
			this._info = info;
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x0001AF22 File Offset: 0x00019122
		public WebPermissionInfo(global::System.Text.RegularExpressions.Regex regex)
		{
			this._type = WebPermissionInfoType.InfoRegex;
			this._info = regex;
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06002669 RID: 9833 RVA: 0x0001AF38 File Offset: 0x00019138
		public string Info
		{
			get
			{
				if (this._type == WebPermissionInfoType.InfoRegex)
				{
					return null;
				}
				return (string)this._info;
			}
		}

		// Token: 0x04001794 RID: 6036
		private WebPermissionInfoType _type;

		// Token: 0x04001795 RID: 6037
		private object _info;
	}
}
