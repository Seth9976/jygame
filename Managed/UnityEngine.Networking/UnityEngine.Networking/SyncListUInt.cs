using System;

namespace UnityEngine.Networking
{
	// Token: 0x02000058 RID: 88
	public class SyncListUInt : SyncList<uint>
	{
		// Token: 0x06000468 RID: 1128 RVA: 0x00017204 File Offset: 0x00015404
		protected override void SerializeItem(NetworkWriter writer, uint item)
		{
			writer.WritePackedUInt32(item);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00017210 File Offset: 0x00015410
		protected override uint DeserializeItem(NetworkReader reader)
		{
			return reader.ReadPackedUInt32();
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00017218 File Offset: 0x00015418
		public static SyncListUInt ReadInstance(NetworkReader reader)
		{
			ushort num = reader.ReadUInt16();
			SyncListUInt syncListUInt = new SyncListUInt();
			for (ushort num2 = 0; num2 < num; num2 += 1)
			{
				syncListUInt.AddInternal(reader.ReadPackedUInt32());
			}
			return syncListUInt;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00017254 File Offset: 0x00015454
		public static void WriteInstance(NetworkWriter writer, SyncListUInt items)
		{
			writer.Write((ushort)items.Count);
			foreach (uint num in items)
			{
				writer.WritePackedUInt32(num);
			}
		}
	}
}
