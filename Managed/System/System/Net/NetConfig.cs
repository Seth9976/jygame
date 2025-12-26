using System;

namespace System.Net
{
	// Token: 0x0200036E RID: 878
	internal class NetConfig : ICloneable
	{
		// Token: 0x06001EA2 RID: 7842 RVA: 0x0001647C File Offset: 0x0001467C
		internal NetConfig()
		{
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x0001648C File Offset: 0x0001468C
		object ICloneable.Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x040012E9 RID: 4841
		internal bool ipv6Enabled;

		// Token: 0x040012EA RID: 4842
		internal int MaxResponseHeadersLength = 64;
	}
}
