using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x02000017 RID: 23
	public class StringMessage : MessageBase
	{
		// Token: 0x0600008E RID: 142 RVA: 0x00004888 File Offset: 0x00002A88
		public StringMessage()
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004890 File Offset: 0x00002A90
		public StringMessage(string v)
		{
			this.value = v;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000048A0 File Offset: 0x00002AA0
		public override void Deserialize(NetworkReader reader)
		{
			this.value = reader.ReadString();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000048B0 File Offset: 0x00002AB0
		public override void Serialize(NetworkWriter writer)
		{
			writer.Write(this.value);
		}

		// Token: 0x0400004E RID: 78
		public string value;
	}
}
