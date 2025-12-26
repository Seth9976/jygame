using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x02000021 RID: 33
	internal class ObjectSpawnMessage : MessageBase
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00004B24 File Offset: 0x00002D24
		public override void Deserialize(NetworkReader reader)
		{
			this.netId = reader.ReadNetworkId();
			this.assetId = reader.ReadNetworkHash128();
			this.position = reader.ReadVector3();
			this.payload = reader.ReadBytesAndSize();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004B64 File Offset: 0x00002D64
		public override void Serialize(NetworkWriter writer)
		{
			writer.Write(this.netId);
			writer.Write(this.assetId);
			writer.Write(this.position);
			writer.WriteBytesFull(this.payload);
		}

		// Token: 0x0400005B RID: 91
		public NetworkInstanceId netId;

		// Token: 0x0400005C RID: 92
		public NetworkHash128 assetId;

		// Token: 0x0400005D RID: 93
		public Vector3 position;

		// Token: 0x0400005E RID: 94
		public byte[] payload;
	}
}
