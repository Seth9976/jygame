using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x02000029 RID: 41
	internal class AnimationParametersMessage : MessageBase
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x00004E38 File Offset: 0x00003038
		public override void Deserialize(NetworkReader reader)
		{
			this.netId = reader.ReadNetworkId();
			this.parameters = reader.ReadBytesAndSize();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00004E54 File Offset: 0x00003054
		public override void Serialize(NetworkWriter writer)
		{
			writer.Write(this.netId);
			if (this.parameters == null)
			{
				writer.WriteBytesAndSize(this.parameters, 0);
			}
			else
			{
				writer.WriteBytesAndSize(this.parameters, this.parameters.Length);
			}
		}

		// Token: 0x04000071 RID: 113
		public NetworkInstanceId netId;

		// Token: 0x04000072 RID: 114
		public byte[] parameters;
	}
}
