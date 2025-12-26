using System;

namespace System
{
	// Token: 0x02000005 RID: 5
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	internal class MonoTODOAttribute : Attribute
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000021D7 File Offset: 0x000003D7
		public MonoTODOAttribute()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000021DF File Offset: 0x000003DF
		public MonoTODOAttribute(string comment)
		{
			this.comment = comment;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000021EE File Offset: 0x000003EE
		public string Comment
		{
			get
			{
				return this.comment;
			}
		}

		// Token: 0x0400001F RID: 31
		private string comment;
	}
}
