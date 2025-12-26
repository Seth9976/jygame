using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x02000028 RID: 40
	internal class AnimationMessage : MessageBase
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x00004D8C File Offset: 0x00002F8C
		public override void Deserialize(NetworkReader reader)
		{
			this.netId = reader.ReadNetworkId();
			this.stateHash = (int)reader.ReadPackedUInt32();
			this.normalizedTime = reader.ReadSingle();
			this.parameters = reader.ReadBytesAndSize();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00004DCC File Offset: 0x00002FCC
		public override void Serialize(NetworkWriter writer)
		{
			writer.Write(this.netId);
			writer.WritePackedUInt32((uint)this.stateHash);
			writer.Write(this.normalizedTime);
			if (this.parameters == null)
			{
				writer.WriteBytesAndSize(this.parameters, 0);
			}
			else
			{
				writer.WriteBytesAndSize(this.parameters, this.parameters.Length);
			}
		}

		// Token: 0x0400006D RID: 109
		public NetworkInstanceId netId;

		// Token: 0x0400006E RID: 110
		public int stateHash;

		// Token: 0x0400006F RID: 111
		public float normalizedTime;

		// Token: 0x04000070 RID: 112
		public byte[] parameters;
	}
}
