using System;

namespace UnityEngine.Networking
{
	// Token: 0x02000057 RID: 87
	public class SyncListInt : SyncList<int>
	{
		// Token: 0x06000463 RID: 1123 RVA: 0x00017140 File Offset: 0x00015340
		protected override void SerializeItem(NetworkWriter writer, int item)
		{
			writer.WritePackedUInt32((uint)item);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0001714C File Offset: 0x0001534C
		protected override int DeserializeItem(NetworkReader reader)
		{
			return (int)reader.ReadPackedUInt32();
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00017154 File Offset: 0x00015354
		public static SyncListInt ReadInstance(NetworkReader reader)
		{
			ushort num = reader.ReadUInt16();
			SyncListInt syncListInt = new SyncListInt();
			for (ushort num2 = 0; num2 < num; num2 += 1)
			{
				syncListInt.AddInternal((int)reader.ReadPackedUInt32());
			}
			return syncListInt;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00017190 File Offset: 0x00015390
		public static void WriteInstance(NetworkWriter writer, SyncListInt items)
		{
			writer.Write((ushort)items.Count);
			foreach (int num in items)
			{
				writer.WritePackedUInt32((uint)num);
			}
		}
	}
}
