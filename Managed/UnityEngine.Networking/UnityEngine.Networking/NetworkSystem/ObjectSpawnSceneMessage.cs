using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x02000022 RID: 34
	internal class ObjectSpawnSceneMessage : MessageBase
	{
		// Token: 0x060000AE RID: 174 RVA: 0x00004BAC File Offset: 0x00002DAC
		public override void Deserialize(NetworkReader reader)
		{
			this.netId = reader.ReadNetworkId();
			this.sceneId = reader.ReadSceneId();
			this.position = reader.ReadVector3();
			this.payload = reader.ReadBytesAndSize();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00004BEC File Offset: 0x00002DEC
		public override void Serialize(NetworkWriter writer)
		{
			writer.Write(this.netId);
			writer.Write(this.sceneId);
			writer.Write(this.position);
			writer.WriteBytesFull(this.payload);
		}

		// Token: 0x0400005F RID: 95
		public NetworkInstanceId netId;

		// Token: 0x04000060 RID: 96
		public NetworkSceneId sceneId;

		// Token: 0x04000061 RID: 97
		public Vector3 position;

		// Token: 0x04000062 RID: 98
		public byte[] payload;
	}
}
