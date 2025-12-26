using System;

namespace UnityEngine.Networking
{
	// Token: 0x02000056 RID: 86
	public sealed class SyncListFloat : SyncList<float>
	{
		// Token: 0x0600045E RID: 1118 RVA: 0x0001707C File Offset: 0x0001527C
		protected override void SerializeItem(NetworkWriter writer, float item)
		{
			writer.Write(item);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00017088 File Offset: 0x00015288
		protected override float DeserializeItem(NetworkReader reader)
		{
			return reader.ReadSingle();
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00017090 File Offset: 0x00015290
		public static SyncListFloat ReadInstance(NetworkReader reader)
		{
			ushort num = reader.ReadUInt16();
			SyncListFloat syncListFloat = new SyncListFloat();
			for (ushort num2 = 0; num2 < num; num2 += 1)
			{
				syncListFloat.AddInternal(reader.ReadSingle());
			}
			return syncListFloat;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000170CC File Offset: 0x000152CC
		public static void WriteInstance(NetworkWriter writer, SyncListFloat items)
		{
			writer.Write((ushort)items.Count);
			foreach (float num in items)
			{
				float num2 = num;
				writer.Write(num2);
			}
		}
	}
}
