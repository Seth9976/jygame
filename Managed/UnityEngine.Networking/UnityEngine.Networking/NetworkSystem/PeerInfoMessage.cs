using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x0200001F RID: 31
	public class PeerInfoMessage : MessageBase
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x000049E8 File Offset: 0x00002BE8
		public override void Deserialize(NetworkReader reader)
		{
			this.connectionId = (int)reader.ReadPackedUInt32();
			this.address = reader.ReadString();
			this.port = (int)reader.ReadPackedUInt32();
			this.isHost = reader.ReadBoolean();
			this.isYou = reader.ReadBoolean();
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004A34 File Offset: 0x00002C34
		public override void Serialize(NetworkWriter writer)
		{
			writer.WritePackedUInt32((uint)this.connectionId);
			writer.Write(this.address);
			writer.WritePackedUInt32((uint)this.port);
			writer.Write(this.isHost);
			writer.Write(this.isYou);
		}

		// Token: 0x04000055 RID: 85
		public int connectionId;

		// Token: 0x04000056 RID: 86
		public string address;

		// Token: 0x04000057 RID: 87
		public int port;

		// Token: 0x04000058 RID: 88
		public bool isHost;

		// Token: 0x04000059 RID: 89
		public bool isYou;
	}
}
