using System;

namespace System.Text.RegularExpressions
{
	// Token: 0x0200049E RID: 1182
	internal struct Interval : IComparable
	{
		// Token: 0x060029A8 RID: 10664 RVA: 0x00081964 File Offset: 0x0007FB64
		public Interval(int low, int high)
		{
			if (low > high)
			{
				int num = low;
				low = high;
				high = num;
			}
			this.low = low;
			this.high = high;
			this.contiguous = true;
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x060029A9 RID: 10665 RVA: 0x00081998 File Offset: 0x0007FB98
		public static Interval Empty
		{
			get
			{
				Interval interval;
				interval.low = 0;
				interval.high = interval.low - 1;
				interval.contiguous = true;
				return interval;
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x0001D08C File Offset: 0x0001B28C
		public static Interval Entire
		{
			get
			{
				return new Interval(int.MinValue, int.MaxValue);
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x060029AB RID: 10667 RVA: 0x0001D09D File Offset: 0x0001B29D
		public bool IsDiscontiguous
		{
			get
			{
				return !this.contiguous;
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x0001D0A8 File Offset: 0x0001B2A8
		public bool IsSingleton
		{
			get
			{
				return this.contiguous && this.low == this.high;
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x060029AD RID: 10669 RVA: 0x0001D0C6 File Offset: 0x0001B2C6
		public bool IsRange
		{
			get
			{
				return !this.IsSingleton && !this.IsEmpty;
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x060029AE RID: 10670 RVA: 0x0001D0DF File Offset: 0x0001B2DF
		public bool IsEmpty
		{
			get
			{
				return this.low > this.high;
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x060029AF RID: 10671 RVA: 0x0001D0EF File Offset: 0x0001B2EF
		public int Size
		{
			get
			{
				if (this.IsEmpty)
				{
					return 0;
				}
				return this.high - this.low + 1;
			}
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x000819C8 File Offset: 0x0007FBC8
		public bool IsDisjoint(Interval i)
		{
			return this.IsEmpty || i.IsEmpty || (this.low > i.high || i.low > this.high);
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x00081A18 File Offset: 0x0007FC18
		public bool IsAdjacent(Interval i)
		{
			return !this.IsEmpty && !i.IsEmpty && (this.low == i.high + 1 || this.high == i.low - 1);
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x00081A68 File Offset: 0x0007FC68
		public bool Contains(Interval i)
		{
			return (!this.IsEmpty && i.IsEmpty) || (!this.IsEmpty && this.low <= i.low && i.high <= this.high);
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x0001D10D File Offset: 0x0001B30D
		public bool Contains(int i)
		{
			return this.low <= i && i <= this.high;
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x00081AC4 File Offset: 0x0007FCC4
		public bool Intersects(Interval i)
		{
			return !this.IsEmpty && !i.IsEmpty && ((this.Contains(i.low) && !this.Contains(i.high)) || (this.Contains(i.high) && !this.Contains(i.low)));
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x00081B38 File Offset: 0x0007FD38
		public void Merge(Interval i)
		{
			if (i.IsEmpty)
			{
				return;
			}
			if (this.IsEmpty)
			{
				this.low = i.low;
				this.high = i.high;
			}
			if (i.low < this.low)
			{
				this.low = i.low;
			}
			if (i.high > this.high)
			{
				this.high = i.high;
			}
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x00081BB8 File Offset: 0x0007FDB8
		public void Intersect(Interval i)
		{
			if (this.IsDisjoint(i))
			{
				this.low = 0;
				this.high = this.low - 1;
				return;
			}
			if (i.low > this.low)
			{
				this.low = i.low;
			}
			if (i.high > this.high)
			{
				this.high = i.high;
			}
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x00081C28 File Offset: 0x0007FE28
		public int CompareTo(object o)
		{
			return this.low - ((Interval)o).low;
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x00081C4C File Offset: 0x0007FE4C
		public new string ToString()
		{
			if (this.IsEmpty)
			{
				return "(EMPTY)";
			}
			if (!this.contiguous)
			{
				return string.Concat(new object[] { "{", this.low, ", ", this.high, "}" });
			}
			if (this.IsSingleton)
			{
				return "(" + this.low + ")";
			}
			return string.Concat(new object[] { "(", this.low, ", ", this.high, ")" });
		}

		// Token: 0x04001A10 RID: 6672
		public int low;

		// Token: 0x04001A11 RID: 6673
		public int high;

		// Token: 0x04001A12 RID: 6674
		public bool contiguous;
	}
}
