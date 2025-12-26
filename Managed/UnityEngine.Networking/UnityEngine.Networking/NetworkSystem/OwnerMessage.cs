using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x02000025 RID: 37
	internal class OwnerMessage : MessageBase
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00004C84 File Offset: 0x00002E84
		public override void Deserialize(NetworkReader reader)
		{
			this.netId = reader.ReadNetworkId();
			this.playerControllerId = (short)reader.ReadPackedUInt32();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004CA0 File Offset: 0x00002EA0
		public override void Serialize(NetworkWriter writer)
		{
			writer.Write(this.netId);
			writer.WritePackedUInt32((uint)this.playerControllerId);
		}

		// Token: 0x04000065 RID: 101
		public NetworkInstanceId netId;

		// Token: 0x04000066 RID: 102
		public short playerControllerId;
	}
}
