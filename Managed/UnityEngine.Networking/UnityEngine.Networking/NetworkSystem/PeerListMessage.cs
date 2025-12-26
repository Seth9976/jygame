using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x02000020 RID: 32
	public class PeerListMessage : MessageBase
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x00004A88 File Offset: 0x00002C88
		public override void Deserialize(NetworkReader reader)
		{
			int num = (int)reader.ReadUInt16();
			this.peers = new PeerInfoMessage[num];
			for (int i = 0; i < this.peers.Length; i++)
			{
				PeerInfoMessage peerInfoMessage = new PeerInfoMessage();
				peerInfoMessage.Deserialize(reader);
				this.peers[i] = peerInfoMessage;
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004AD8 File Offset: 0x00002CD8
		public override void Serialize(NetworkWriter writer)
		{
			writer.Write((ushort)this.peers.Length);
			foreach (PeerInfoMessage peerInfoMessage in this.peers)
			{
				peerInfoMessage.Serialize(writer);
			}
		}

		// Token: 0x0400005A RID: 90
		public PeerInfoMessage[] peers;
	}
}
