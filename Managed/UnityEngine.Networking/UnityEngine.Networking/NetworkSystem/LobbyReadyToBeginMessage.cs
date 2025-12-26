using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x0200002B RID: 43
	internal class LobbyReadyToBeginMessage : MessageBase
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x00004EDC File Offset: 0x000030DC
		public override void Deserialize(NetworkReader reader)
		{
			this.slotId = reader.ReadByte();
			this.readyState = reader.ReadBoolean();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00004EF8 File Offset: 0x000030F8
		public override void Serialize(NetworkWriter writer)
		{
			writer.Write(this.slotId);
			writer.Write(this.readyState);
		}

		// Token: 0x04000075 RID: 117
		public byte slotId;

		// Token: 0x04000076 RID: 118
		public bool readyState;
	}
}
