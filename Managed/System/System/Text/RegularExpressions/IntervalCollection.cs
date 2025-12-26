using System;
using System.Collections;

namespace System.Text.RegularExpressions
{
	// Token: 0x0200049F RID: 1183
	internal class IntervalCollection : ICollection, IEnumerable
	{
		// Token: 0x060029B9 RID: 10681 RVA: 0x0001D12A File Offset: 0x0001B32A
		public IntervalCollection()
		{
			this.intervals = new ArrayList();
		}

		// Token: 0x17000B82 RID: 2946
		public Interval this[int i]
		{
			get
			{
				return (Interval)this.intervals[i];
			}
			set
			{
				this.intervals[i] = value;
			}
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x0001D164 File Offset: 0x0001B364
		public void Add(Interval i)
		{
			this.intervals.Add(i);
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x0001D178 File Offset: 0x0001B378
		public void Clear()
		{
			this.intervals.Clear();
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x0001D185 File Offset: 0x0001B385
		public void Sort()
		{
			this.intervals.Sort();
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x00081D1C File Offset: 0x0007FF1C
		public void Normalize()
		{
			this.intervals.Sort();
			int i = 0;
			while (i < this.intervals.Count - 1)
			{
				Interval interval = (Interval)this.intervals[i];
				Interval interval2 = (Interval)this.intervals[i + 1];
				if (!interval.IsDisjoint(interval2) || interval.IsAdjacent(interval2))
				{
					interval.Merge(interval2);
					this.intervals[i] = interval;
					this.intervals.RemoveAt(i + 1);
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x00081DC0 File Offset: 0x0007FFC0
		public IntervalCollection GetMetaCollection(IntervalCollection.CostDelegate cost_del)
		{
			IntervalCollection intervalCollection = new IntervalCollection();
			this.Normalize();
			this.Optimize(0, this.Count - 1, intervalCollection, cost_del);
			intervalCollection.intervals.Sort();
			return intervalCollection;
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x00081DF8 File Offset: 0x0007FFF8
		private void Optimize(int begin, int end, IntervalCollection meta, IntervalCollection.CostDelegate cost_del)
		{
			Interval interval;
			interval.contiguous = false;
			int num = -1;
			int num2 = -1;
			double num3 = 0.0;
			for (int i = begin; i <= end; i++)
			{
				interval.low = this[i].low;
				double num4 = 0.0;
				for (int j = i; j <= end; j++)
				{
					interval.high = this[j].high;
					num4 += cost_del(this[j]);
					double num5 = cost_del(interval);
					if (num5 < num4 && num4 > num3)
					{
						num = i;
						num2 = j;
						num3 = num4;
					}
				}
			}
			if (num < 0)
			{
				for (int k = begin; k <= end; k++)
				{
					meta.Add(this[k]);
				}
			}
			else
			{
				interval.low = this[num].low;
				interval.high = this[num2].high;
				meta.Add(interval);
				if (num > begin)
				{
					this.Optimize(begin, num - 1, meta, cost_del);
				}
				if (num2 < end)
				{
					this.Optimize(num2 + 1, end, meta, cost_del);
				}
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x060029C2 RID: 10690 RVA: 0x0001D192 File Offset: 0x0001B392
		public int Count
		{
			get
			{
				return this.intervals.Count;
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x060029C3 RID: 10691 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x060029C4 RID: 10692 RVA: 0x0001D19F File Offset: 0x0001B39F
		public object SyncRoot
		{
			get
			{
				return this.intervals;
			}
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x00081F48 File Offset: 0x00080148
		public void CopyTo(Array array, int index)
		{
			foreach (object obj in this.intervals)
			{
				Interval interval = (Interval)obj;
				if (index > array.Length)
				{
					break;
				}
				array.SetValue(interval, index++);
			}
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x0001D1A7 File Offset: 0x0001B3A7
		public IEnumerator GetEnumerator()
		{
			return new IntervalCollection.Enumerator(this.intervals);
		}

		// Token: 0x04001A13 RID: 6675
		private ArrayList intervals;

		// Token: 0x020004A0 RID: 1184
		private class Enumerator : IEnumerator
		{
			// Token: 0x060029C7 RID: 10695 RVA: 0x0001D1B4 File Offset: 0x0001B3B4
			public Enumerator(IList list)
			{
				this.list = list;
				this.Reset();
			}

			// Token: 0x17000B86 RID: 2950
			// (get) Token: 0x060029C8 RID: 10696 RVA: 0x0001D1C9 File Offset: 0x0001B3C9
			public object Current
			{
				get
				{
					if (this.ptr >= this.list.Count)
					{
						throw new InvalidOperationException();
					}
					return this.list[this.ptr];
				}
			}

			// Token: 0x060029C9 RID: 10697 RVA: 0x00081FC8 File Offset: 0x000801C8
			public bool MoveNext()
			{
				if (this.ptr > this.list.Count)
				{
					throw new InvalidOperationException();
				}
				return ++this.ptr < this.list.Count;
			}

			// Token: 0x060029CA RID: 10698 RVA: 0x0001D1F8 File Offset: 0x0001B3F8
			public void Reset()
			{
				this.ptr = -1;
			}

			// Token: 0x04001A14 RID: 6676
			private IList list;

			// Token: 0x04001A15 RID: 6677
			private int ptr;
		}

		// Token: 0x020004A1 RID: 1185
		// (Invoke) Token: 0x060029CC RID: 10700
		public delegate double CostDelegate(Interval i);
	}
}
