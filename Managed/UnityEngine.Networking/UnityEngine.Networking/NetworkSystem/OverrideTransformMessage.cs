using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x02000027 RID: 39
	internal class OverrideTransformMessage : MessageBase
	{
		// Token: 0x060000BD RID: 189 RVA: 0x00004D04 File Offset: 0x00002F04
		public override void Deserialize(NetworkReader reader)
		{
			this.netId = reader.ReadNetworkId();
			this.payload = reader.ReadBytesAndSize();
			this.teleport = reader.ReadBoolean();
			this.time = (int)reader.ReadPackedUInt32();
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00004D44 File Offset: 0x00002F44
		public override void Serialize(NetworkWriter writer)
		{
			writer.Write(this.netId);
			writer.WriteBytesFull(this.payload);
			writer.Write(this.teleport);
			writer.WritePackedUInt32((uint)this.time);
		}

		// Token: 0x04000069 RID: 105
		public NetworkInstanceId netId;

		// Token: 0x0400006A RID: 106
		public byte[] payload;

		// Token: 0x0400006B RID: 107
		public bool teleport;

		// Token: 0x0400006C RID: 108
		public int time;
	}
}
