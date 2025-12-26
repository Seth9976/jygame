using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x02000024 RID: 36
	internal class ObjectDestroyMessage : MessageBase
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x00004C5C File Offset: 0x00002E5C
		public override void Deserialize(NetworkReader reader)
		{
			this.netId = reader.ReadNetworkId();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004C6C File Offset: 0x00002E6C
		public override void Serialize(NetworkWriter writer)
		{
			writer.Write(this.netId);
		}

		// Token: 0x04000064 RID: 100
		public NetworkInstanceId netId;
	}
}
