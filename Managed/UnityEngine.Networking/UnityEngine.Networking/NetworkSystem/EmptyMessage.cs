using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x02000019 RID: 25
	public class EmptyMessage : MessageBase
	{
		// Token: 0x06000097 RID: 151 RVA: 0x00004900 File Offset: 0x00002B00
		public override void Deserialize(NetworkReader reader)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004904 File Offset: 0x00002B04
		public override void Serialize(NetworkWriter writer)
		{
		}
	}
}
