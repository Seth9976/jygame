using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x0200002A RID: 42
	internal class AnimationTriggerMessage : MessageBase
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x00004E9C File Offset: 0x0000309C
		public override void Deserialize(NetworkReader reader)
		{
			this.netId = reader.ReadNetworkId();
			this.hash = (int)reader.ReadPackedUInt32();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00004EB8 File Offset: 0x000030B8
		public override void Serialize(NetworkWriter writer)
		{
			writer.Write(this.netId);
			writer.WritePackedUInt32((uint)this.hash);
		}

		// Token: 0x04000073 RID: 115
		public NetworkInstanceId netId;

		// Token: 0x04000074 RID: 116
		public int hash;
	}
}
