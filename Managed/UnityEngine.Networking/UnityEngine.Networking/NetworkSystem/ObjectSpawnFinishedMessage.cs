using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x02000023 RID: 35
	internal class ObjectSpawnFinishedMessage : MessageBase
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00004C34 File Offset: 0x00002E34
		public override void Deserialize(NetworkReader reader)
		{
			this.state = reader.ReadPackedUInt32();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004C44 File Offset: 0x00002E44
		public override void Serialize(NetworkWriter writer)
		{
			writer.WritePackedUInt32(this.state);
		}

		// Token: 0x04000063 RID: 99
		public uint state;
	}
}
