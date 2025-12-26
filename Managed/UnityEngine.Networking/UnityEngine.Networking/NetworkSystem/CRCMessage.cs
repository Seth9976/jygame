using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x0200002D RID: 45
	internal class CRCMessage : MessageBase
	{
		// Token: 0x060000CC RID: 204 RVA: 0x00004F1C File Offset: 0x0000311C
		public override void Deserialize(NetworkReader reader)
		{
			int num = (int)reader.ReadUInt16();
			this.scripts = new CRCMessageEntry[num];
			for (int i = 0; i < this.scripts.Length; i++)
			{
				CRCMessageEntry crcmessageEntry = default(CRCMessageEntry);
				crcmessageEntry.name = reader.ReadString();
				crcmessageEntry.channel = reader.ReadByte();
				this.scripts[i] = crcmessageEntry;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00004F8C File Offset: 0x0000318C
		public override void Serialize(NetworkWriter writer)
		{
			writer.Write((ushort)this.scripts.Length);
			foreach (CRCMessageEntry crcmessageEntry in this.scripts)
			{
				writer.Write(crcmessageEntry.name);
				writer.Write(crcmessageEntry.channel);
			}
		}

		// Token: 0x04000079 RID: 121
		public CRCMessageEntry[] scripts;
	}
}
