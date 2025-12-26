using System;

namespace UnityEngine.Networking.Match
{
	// Token: 0x020001FE RID: 510
	public interface IResponse
	{
		// Token: 0x06001DE9 RID: 7657
		void SetSuccess();

		// Token: 0x06001DEA RID: 7658
		void SetFailure(string info);
	}
}
