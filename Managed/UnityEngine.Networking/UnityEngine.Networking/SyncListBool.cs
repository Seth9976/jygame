using System;

namespace UnityEngine.Networking
{
	// Token: 0x02000059 RID: 89
	public class SyncListBool : SyncList<bool>
	{
		// Token: 0x0600046D RID: 1133 RVA: 0x000172C8 File Offset: 0x000154C8
		protected override void SerializeItem(NetworkWriter writer, bool item)
		{
			writer.Write(item);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x000172D4 File Offset: 0x000154D4
		protected override bool DeserializeItem(NetworkReader reader)
		{
			return reader.ReadBoolean();
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000172DC File Offset: 0x000154DC
		public static SyncListBool ReadInstance(NetworkReader reader)
		{
			ushort num = reader.ReadUInt16();
			SyncListBool syncListBool = new SyncListBool();
			for (ushort num2 = 0; num2 < num; num2 += 1)
			{
				syncListBool.AddInternal(reader.ReadBoolean());
			}
			return syncListBool;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00017318 File Offset: 0x00015518
		public static void WriteInstance(NetworkWriter writer, SyncListBool items)
		{
			writer.Write((ushort)items.Count);
			foreach (bool flag in items)
			{
				writer.Write(flag);
			}
		}
	}
}
