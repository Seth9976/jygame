using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x0200001E RID: 30
	public class RemovePlayerMessage : MessageBase
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x000049C0 File Offset: 0x00002BC0
		public override void Deserialize(NetworkReader reader)
		{
			this.playerControllerId = (short)reader.ReadUInt16();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000049D0 File Offset: 0x00002BD0
		public override void Serialize(NetworkWriter writer)
		{
			writer.Write((ushort)this.playerControllerId);
		}

		// Token: 0x04000054 RID: 84
		public short playerControllerId;
	}
}
