using System;

namespace UnityEngine.Networking
{
	// Token: 0x0200005A RID: 90
	public class SyncListStruct<T> : SyncList<T> where T : struct
	{
		// Token: 0x06000472 RID: 1138 RVA: 0x0001738C File Offset: 0x0001558C
		public new void AddInternal(T item)
		{
			base.AddInternal(item);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00017398 File Offset: 0x00015598
		protected override void SerializeItem(NetworkWriter writer, T item)
		{
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0001739C File Offset: 0x0001559C
		protected override T DeserializeItem(NetworkReader reader)
		{
			return default(T);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x000173B4 File Offset: 0x000155B4
		public T GetItem(int i)
		{
			return base[i];
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x000173C0 File Offset: 0x000155C0
		public new ushort Count
		{
			get
			{
				return (ushort)base.Count;
			}
		}
	}
}
