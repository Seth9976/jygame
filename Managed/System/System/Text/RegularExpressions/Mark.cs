using System;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000496 RID: 1174
	internal struct Mark
	{
		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06002968 RID: 10600 RVA: 0x0001CDD3 File Offset: 0x0001AFD3
		public bool IsDefined
		{
			get
			{
				return this.Start >= 0 && this.End >= 0;
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06002969 RID: 10601 RVA: 0x0001CDF0 File Offset: 0x0001AFF0
		public int Index
		{
			get
			{
				return (this.Start >= this.End) ? this.End : this.Start;
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x0001CE14 File Offset: 0x0001B014
		public int Length
		{
			get
			{
				return (this.Start >= this.End) ? (this.Start - this.End) : (this.End - this.Start);
			}
		}

		// Token: 0x040019EB RID: 6635
		public int Start;

		// Token: 0x040019EC RID: 6636
		public int End;

		// Token: 0x040019ED RID: 6637
		public int Previous;
	}
}
