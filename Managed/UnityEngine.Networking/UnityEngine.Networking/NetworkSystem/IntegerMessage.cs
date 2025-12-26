using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x02000018 RID: 24
	public class IntegerMessage : MessageBase
	{
		// Token: 0x06000092 RID: 146 RVA: 0x000048C0 File Offset: 0x00002AC0
		public IntegerMessage()
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000048C8 File Offset: 0x00002AC8
		public IntegerMessage(int v)
		{
			this.value = v;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000048D8 File Offset: 0x00002AD8
		public override void Deserialize(NetworkReader reader)
		{
			this.value = (int)reader.ReadPackedUInt32();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000048E8 File Offset: 0x00002AE8
		public override void Serialize(NetworkWriter writer)
		{
			writer.WritePackedUInt32((uint)this.value);
		}

		// Token: 0x0400004F RID: 79
		public int value;
	}
}
