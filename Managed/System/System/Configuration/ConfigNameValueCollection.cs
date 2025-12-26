using System;
using System.Collections;
using System.Collections.Specialized;

namespace System.Configuration
{
	// Token: 0x020001D2 RID: 466
	internal class ConfigNameValueCollection : global::System.Collections.Specialized.NameValueCollection
	{
		// Token: 0x06001034 RID: 4148 RVA: 0x0000D3B8 File Offset: 0x0000B5B8
		public ConfigNameValueCollection()
		{
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x0000D3C0 File Offset: 0x0000B5C0
		public ConfigNameValueCollection(ConfigNameValueCollection col)
			: base(col.Count, col)
		{
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x0000D3CF File Offset: 0x0000B5CF
		public ConfigNameValueCollection(IHashCodeProvider hashProvider, IComparer comparer)
			: base(hashProvider, comparer)
		{
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0000D3D9 File Offset: 0x0000B5D9
		public void ResetModified()
		{
			this.modified = false;
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x0000D3E2 File Offset: 0x0000B5E2
		public bool IsModified
		{
			get
			{
				return this.modified;
			}
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0000D3EA File Offset: 0x0000B5EA
		public override void Set(string name, string value)
		{
			base.Set(name, value);
			this.modified = true;
		}

		// Token: 0x0400048F RID: 1167
		private bool modified;
	}
}
