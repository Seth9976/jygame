using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x0200001D RID: 29
	public class AddPlayerMessage : MessageBase
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00004948 File Offset: 0x00002B48
		public override void Deserialize(NetworkReader reader)
		{
			this.playerControllerId = (short)reader.ReadUInt16();
			this.msgData = reader.ReadBytesAndSize();
			if (this.msgData == null)
			{
				this.msgSize = 0;
			}
			else
			{
				this.msgSize = this.msgData.Length;
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00004994 File Offset: 0x00002B94
		public override void Serialize(NetworkWriter writer)
		{
			writer.Write((ushort)this.playerControllerId);
			writer.WriteBytesAndSize(this.msgData, this.msgSize);
		}

		// Token: 0x04000051 RID: 81
		public short playerControllerId;

		// Token: 0x04000052 RID: 82
		public int msgSize;

		// Token: 0x04000053 RID: 83
		public byte[] msgData;
	}
}
