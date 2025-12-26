using System;
using System.Collections.Generic;

namespace UnityEngine.Networking.Match
{
	// Token: 0x0200020D RID: 525
	public class CreateDedicatedMatchRequest : Request
	{
		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x0000C074 File Offset: 0x0000A274
		// (set) Token: 0x06001E7C RID: 7804 RVA: 0x0000C07C File Offset: 0x0000A27C
		public string name { get; set; }

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001E7D RID: 7805 RVA: 0x0000C085 File Offset: 0x0000A285
		// (set) Token: 0x06001E7E RID: 7806 RVA: 0x0000C08D File Offset: 0x0000A28D
		public uint size { get; set; }

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x0000C096 File Offset: 0x0000A296
		// (set) Token: 0x06001E80 RID: 7808 RVA: 0x0000C09E File Offset: 0x0000A29E
		public bool advertise { get; set; }

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06001E81 RID: 7809 RVA: 0x0000C0A7 File Offset: 0x0000A2A7
		// (set) Token: 0x06001E82 RID: 7810 RVA: 0x0000C0AF File Offset: 0x0000A2AF
		public string password { get; set; }

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x0000C0B8 File Offset: 0x0000A2B8
		// (set) Token: 0x06001E84 RID: 7812 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		public string publicAddress { get; set; }

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06001E85 RID: 7813 RVA: 0x0000C0C9 File Offset: 0x0000A2C9
		// (set) Token: 0x06001E86 RID: 7814 RVA: 0x0000C0D1 File Offset: 0x0000A2D1
		public string privateAddress { get; set; }

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06001E87 RID: 7815 RVA: 0x0000C0DA File Offset: 0x0000A2DA
		// (set) Token: 0x06001E88 RID: 7816 RVA: 0x0000C0E2 File Offset: 0x0000A2E2
		public int eloScore { get; set; }

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001E89 RID: 7817 RVA: 0x0000C0EB File Offset: 0x0000A2EB
		// (set) Token: 0x06001E8A RID: 7818 RVA: 0x0000C0F3 File Offset: 0x0000A2F3
		public Dictionary<string, long> matchAttributes { get; set; }

		// Token: 0x06001E8B RID: 7819 RVA: 0x0000C0FC File Offset: 0x0000A2FC
		public override bool IsValid()
		{
			return this.matchAttributes == null || this.matchAttributes.Count <= 10;
		}
	}
}
