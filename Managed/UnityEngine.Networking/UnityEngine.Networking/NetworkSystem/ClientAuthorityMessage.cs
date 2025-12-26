using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x02000026 RID: 38
	internal class ClientAuthorityMessage : MessageBase
	{
		// Token: 0x060000BA RID: 186 RVA: 0x00004CC4 File Offset: 0x00002EC4
		public override void Deserialize(NetworkReader reader)
		{
			this.netId = reader.ReadNetworkId();
			this.authority = reader.ReadBoolean();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00004CE0 File Offset: 0x00002EE0
		public override void Serialize(NetworkWriter writer)
		{
			writer.Write(this.netId);
			writer.Write(this.authority);
		}

		// Token: 0x04000067 RID: 103
		public NetworkInstanceId netId;

		// Token: 0x04000068 RID: 104
		public bool authority;
	}
}
