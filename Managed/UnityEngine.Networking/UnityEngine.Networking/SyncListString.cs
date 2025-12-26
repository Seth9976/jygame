using System;

namespace UnityEngine.Networking
{
	// Token: 0x02000055 RID: 85
	public sealed class SyncListString : SyncList<string>
	{
		// Token: 0x06000459 RID: 1113 RVA: 0x00016FB8 File Offset: 0x000151B8
		protected override void SerializeItem(NetworkWriter writer, string item)
		{
			writer.Write(item);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00016FC4 File Offset: 0x000151C4
		protected override string DeserializeItem(NetworkReader reader)
		{
			return reader.ReadString();
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00016FCC File Offset: 0x000151CC
		public static SyncListString ReadInstance(NetworkReader reader)
		{
			ushort num = reader.ReadUInt16();
			SyncListString syncListString = new SyncListString();
			for (ushort num2 = 0; num2 < num; num2 += 1)
			{
				syncListString.AddInternal(reader.ReadString());
			}
			return syncListString;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00017008 File Offset: 0x00015208
		public static void WriteInstance(NetworkWriter writer, SyncListString items)
		{
			writer.Write((ushort)items.Count);
			foreach (string text in items)
			{
				writer.Write(text);
			}
		}
	}
}
