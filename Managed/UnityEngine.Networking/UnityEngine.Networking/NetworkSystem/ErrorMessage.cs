using System;

namespace UnityEngine.Networking.NetworkSystem
{
	// Token: 0x0200001A RID: 26
	public class ErrorMessage : MessageBase
	{
		// Token: 0x0600009A RID: 154 RVA: 0x00004910 File Offset: 0x00002B10
		public override void Deserialize(NetworkReader reader)
		{
			this.errorCode = (int)reader.ReadUInt16();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004920 File Offset: 0x00002B20
		public override void Serialize(NetworkWriter writer)
		{
			writer.Write((ushort)this.errorCode);
		}

		// Token: 0x04000050 RID: 80
		public int errorCode;
	}
}
