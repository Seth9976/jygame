using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UI.Collections
{
	// Token: 0x0200009C RID: 156
	internal class IndexedSet<T> : IList<T>, IEnumerable, ICollection<T>, IEnumerable<T>
	{
		// Token: 0x06000577 RID: 1399 RVA: 0x00017BB4 File Offset: 0x00015DB4
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00017BBC File Offset: 0x00015DBC
		public void Add(T item)
		{
			if (this.m_Dictionary.ContainsKey(item))
			{
				return;
			}
			this.m_List.Add(item);
			this.m_Dictionary.Add(item, this.m_List.Count - 1);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00017C00 File Offset: 0x00015E00
		public bool Remove(T item)
		{
			int num = -1;
			if (!this.m_Dictionary.TryGetValue(item, out num))
			{
				return false;
			}
			this.RemoveAt(num);
			return true;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00017C2C File Offset: 0x00015E2C
		public IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00017C34 File Offset: 0x00015E34
		public void Clear()
		{
			this.m_List.Clear();
			this.m_Dictionary.Clear();
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00017C4C File Offset: 0x00015E4C
		public bool Contains(T item)
		{
			return this.m_Dictionary.ContainsKey(item);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00017C5C File Offset: 0x00015E5C
		public void CopyTo(T[] array, int arrayIndex)
		{
			this.m_List.CopyTo(array, arrayIndex);
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x00017C6C File Offset: 0x00015E6C
		public int Count
		{
			get
			{
				return this.m_List.Count;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00017C7C File Offset: 0x00015E7C
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00017C80 File Offset: 0x00015E80
		public int IndexOf(T item)
		{
			int num = -1;
			this.m_Dictionary.TryGetValue(item, out num);
			return num;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00017CA0 File Offset: 0x00015EA0
		public void Insert(int index, T item)
		{
			throw new NotSupportedException("Random Insertion is semantically invalid, since this structure does not guarantee ordering.");
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00017CAC File Offset: 0x00015EAC
		public void RemoveAt(int index)
		{
			T t = this.m_List[index];
			this.m_Dictionary.Remove(t);
			if (index == this.m_List.Count - 1)
			{
				this.m_List.RemoveAt(index);
			}
			else
			{
				int num = this.m_List.Count - 1;
				T t2 = this.m_List[num];
				this.m_List[index] = t2;
				this.m_Dictionary[t2] = index;
				this.m_List.RemoveAt(num);
			}
		}

		// Token: 0x17000172 RID: 370
		public T this[int index]
		{
			get
			{
				return this.m_List[index];
			}
			set
			{
				T t = this.m_List[index];
				this.m_Dictionary.Remove(t);
				this.m_List[index] = value;
				this.m_Dictionary.Add(t, index);
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00017D8C File Offset: 0x00015F8C
		public void RemoveAll(Predicate<T> match)
		{
			int i = 0;
			while (i < this.m_List.Count)
			{
				T t = this.m_List[i];
				if (match(t))
				{
					this.Remove(t);
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00017DDC File Offset: 0x00015FDC
		public void Sort(Comparison<T> sortLayoutFunction)
		{
			this.m_List.Sort(sortLayoutFunction);
			for (int i = 0; i < this.m_List.Count; i++)
			{
				T t = this.m_List[i];
				this.m_Dictionary[t] = i;
			}
		}

		// Token: 0x0400029E RID: 670
		private readonly List<T> m_List = new List<T>();

		// Token: 0x0400029F RID: 671
		private Dictionary<T, int> m_Dictionary = new Dictionary<T, int>();
	}
}
