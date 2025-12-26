using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace UnityEngine.Networking
{
	// Token: 0x0200005B RID: 91
	[EditorBrowsable(EditorBrowsableState.Never)]
	public abstract class SyncList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x06000478 RID: 1144 RVA: 0x000173E0 File Offset: 0x000155E0
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x000173E8 File Offset: 0x000155E8
		public int Count
		{
			get
			{
				return this.m_Objects.Count;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x000173F8 File Offset: 0x000155F8
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x000173FC File Offset: 0x000155FC
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x00017404 File Offset: 0x00015604
		public SyncList<T>.SyncListChanged Callback
		{
			get
			{
				return this.m_Callback;
			}
			set
			{
				this.m_Callback = value;
			}
		}

		// Token: 0x0600047D RID: 1149
		protected abstract void SerializeItem(NetworkWriter writer, T item);

		// Token: 0x0600047E RID: 1150
		protected abstract T DeserializeItem(NetworkReader reader);

		// Token: 0x0600047F RID: 1151 RVA: 0x00017410 File Offset: 0x00015610
		public void InitializeBehaviour(NetworkBehaviour beh, int cmdHash)
		{
			this.m_Behaviour = beh;
			this.m_CmdHash = cmdHash;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00017420 File Offset: 0x00015620
		private void SendMsg(SyncList<T>.Operation op, int itemIndex, T item)
		{
			if (this.m_Behaviour == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("SyncList not initialized");
				}
				return;
			}
			NetworkIdentity component = this.m_Behaviour.GetComponent<NetworkIdentity>();
			if (component == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("SyncList no NetworkIdentity");
				}
				return;
			}
			NetworkWriter networkWriter = new NetworkWriter();
			networkWriter.StartMessage(9);
			networkWriter.Write(component.netId);
			networkWriter.WritePackedUInt32((uint)this.m_CmdHash);
			networkWriter.Write((byte)op);
			networkWriter.WritePackedUInt32((uint)itemIndex);
			this.SerializeItem(networkWriter, item);
			networkWriter.FinishMessage();
			NetworkServer.SendWriterToReady(component.gameObject, networkWriter, 0);
			if (this.m_Behaviour.isServer && this.m_Behaviour.isClient && this.m_Callback != null)
			{
				this.m_Callback(op, itemIndex);
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00017508 File Offset: 0x00015708
		private void SendMsg(SyncList<T>.Operation op, int itemIndex)
		{
			this.SendMsg(op, itemIndex, default(T));
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00017528 File Offset: 0x00015728
		public void HandleMsg(NetworkReader reader)
		{
			byte b = reader.ReadByte();
			int num = (int)reader.ReadPackedUInt32();
			T t = this.DeserializeItem(reader);
			switch (b)
			{
			case 0:
				this.m_Objects.Add(t);
				break;
			case 1:
				this.m_Objects.Clear();
				break;
			case 2:
				this.m_Objects.Insert(num, t);
				break;
			case 3:
				this.m_Objects.Remove(t);
				break;
			case 4:
				this.m_Objects.RemoveAt(num);
				break;
			case 5:
			case 6:
				this.m_Objects[num] = t;
				break;
			}
			if (this.m_Callback != null)
			{
				this.m_Callback((SyncList<T>.Operation)b, num);
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000175F4 File Offset: 0x000157F4
		internal void AddInternal(T item)
		{
			this.m_Objects.Add(item);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00017604 File Offset: 0x00015804
		public void Add(T item)
		{
			this.m_Objects.Add(item);
			this.SendMsg(SyncList<T>.Operation.OP_ADD, this.m_Objects.Count - 1, item);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00017634 File Offset: 0x00015834
		public void Clear()
		{
			this.m_Objects.Clear();
			this.SendMsg(SyncList<T>.Operation.OP_CLEAR, 0);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0001764C File Offset: 0x0001584C
		public bool Contains(T item)
		{
			return this.m_Objects.Contains(item);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0001765C File Offset: 0x0001585C
		public void CopyTo(T[] array, int index)
		{
			this.m_Objects.CopyTo(array, index);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0001766C File Offset: 0x0001586C
		public int IndexOf(T item)
		{
			return this.m_Objects.IndexOf(item);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0001767C File Offset: 0x0001587C
		public void Insert(int index, T item)
		{
			this.m_Objects.Insert(index, item);
			this.SendMsg(SyncList<T>.Operation.OP_INSERT, index, item);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00017694 File Offset: 0x00015894
		public bool Remove(T item)
		{
			bool flag = this.m_Objects.Remove(item);
			if (flag)
			{
				this.SendMsg(SyncList<T>.Operation.OP_REMOVE, 0, item);
			}
			return flag;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x000176C0 File Offset: 0x000158C0
		public void RemoveAt(int index)
		{
			this.m_Objects.RemoveAt(index);
			this.SendMsg(SyncList<T>.Operation.OP_REMOVEAT, index);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000176D8 File Offset: 0x000158D8
		public void Dirty(int index)
		{
			this.SendMsg(SyncList<T>.Operation.OP_DIRTY, index, this.m_Objects[index]);
		}

		// Token: 0x170000B9 RID: 185
		public T this[int i]
		{
			get
			{
				return this.m_Objects[i];
			}
			set
			{
				this.m_Objects[i] = value;
				this.SendMsg(SyncList<T>.Operation.OP_SET, i, value);
			}
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00017718 File Offset: 0x00015918
		public IEnumerator<T> GetEnumerator()
		{
			return this.m_Objects.GetEnumerator();
		}

		// Token: 0x040001D7 RID: 471
		private List<T> m_Objects = new List<T>();

		// Token: 0x040001D8 RID: 472
		private NetworkBehaviour m_Behaviour;

		// Token: 0x040001D9 RID: 473
		private int m_CmdHash;

		// Token: 0x040001DA RID: 474
		private SyncList<T>.SyncListChanged m_Callback;

		// Token: 0x0200005C RID: 92
		public enum Operation
		{
			// Token: 0x040001DC RID: 476
			OP_ADD,
			// Token: 0x040001DD RID: 477
			OP_CLEAR,
			// Token: 0x040001DE RID: 478
			OP_INSERT,
			// Token: 0x040001DF RID: 479
			OP_REMOVE,
			// Token: 0x040001E0 RID: 480
			OP_REMOVEAT,
			// Token: 0x040001E1 RID: 481
			OP_SET,
			// Token: 0x040001E2 RID: 482
			OP_DIRTY
		}

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x060004A9 RID: 1193
		public delegate void SyncListChanged(SyncList<T>.Operation op, int itemIndex);
	}
}
