using System;
using System.Collections;

namespace System.Text.RegularExpressions.Syntax
{
	// Token: 0x020004C6 RID: 1222
	internal class CharacterClass : Expression
	{
		// Token: 0x06002B45 RID: 11077 RVA: 0x0008B804 File Offset: 0x00089A04
		public CharacterClass(bool negate, bool ignore)
		{
			this.negate = negate;
			this.ignore = ignore;
			this.intervals = new IntervalCollection();
			int num = 144;
			this.pos_cats = new BitArray(num);
			this.neg_cats = new BitArray(num);
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x0001E14B File Offset: 0x0001C34B
		public CharacterClass(Category cat, bool negate)
			: this(false, false)
		{
			this.AddCategory(cat, negate);
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06002B48 RID: 11080 RVA: 0x0001E16D File Offset: 0x0001C36D
		// (set) Token: 0x06002B49 RID: 11081 RVA: 0x0001E175 File Offset: 0x0001C375
		public bool Negate
		{
			get
			{
				return this.negate;
			}
			set
			{
				this.negate = value;
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06002B4A RID: 11082 RVA: 0x0001E17E File Offset: 0x0001C37E
		// (set) Token: 0x06002B4B RID: 11083 RVA: 0x0001E186 File Offset: 0x0001C386
		public bool IgnoreCase
		{
			get
			{
				return this.ignore;
			}
			set
			{
				this.ignore = value;
			}
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x0008B850 File Offset: 0x00089A50
		public void AddCategory(Category cat, bool negate)
		{
			if (negate)
			{
				this.neg_cats[(int)cat] = true;
			}
			else
			{
				this.pos_cats[(int)cat] = true;
			}
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x0001E18F File Offset: 0x0001C38F
		public void AddCharacter(char c)
		{
			this.AddRange(c, c);
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x0008B884 File Offset: 0x00089A84
		public void AddRange(char lo, char hi)
		{
			Interval interval = new Interval((int)lo, (int)hi);
			if (this.ignore)
			{
				if (CharacterClass.upper_case_characters.Intersects(interval))
				{
					Interval interval2;
					if (interval.low < CharacterClass.upper_case_characters.low)
					{
						interval2 = new Interval(CharacterClass.upper_case_characters.low + 32, interval.high + 32);
						interval.high = CharacterClass.upper_case_characters.low - 1;
					}
					else
					{
						interval2 = new Interval(interval.low + 32, CharacterClass.upper_case_characters.high + 32);
						interval.low = CharacterClass.upper_case_characters.high + 1;
					}
					this.intervals.Add(interval2);
				}
				else if (CharacterClass.upper_case_characters.Contains(interval))
				{
					interval.high += 32;
					interval.low += 32;
				}
			}
			this.intervals.Add(interval);
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x0008B980 File Offset: 0x00089B80
		public override void Compile(ICompiler cmp, bool reverse)
		{
			IntervalCollection metaCollection = this.intervals.GetMetaCollection(new IntervalCollection.CostDelegate(CharacterClass.GetIntervalCost));
			int num = metaCollection.Count;
			for (int i = 0; i < this.pos_cats.Length; i++)
			{
				if (this.pos_cats[i] || this.neg_cats[i])
				{
					num++;
				}
			}
			if (num == 0)
			{
				return;
			}
			LinkRef linkRef = cmp.NewLink();
			if (num > 1)
			{
				cmp.EmitIn(linkRef);
			}
			foreach (object obj in metaCollection)
			{
				Interval interval = (Interval)obj;
				if (interval.IsDiscontiguous)
				{
					BitArray bitArray = new BitArray(interval.Size);
					foreach (object obj2 in this.intervals)
					{
						Interval interval2 = (Interval)obj2;
						if (interval.Contains(interval2))
						{
							for (int j = interval2.low; j <= interval2.high; j++)
							{
								bitArray[j - interval.low] = true;
							}
						}
					}
					cmp.EmitSet((char)interval.low, bitArray, this.negate, this.ignore, reverse);
				}
				else if (interval.IsSingleton)
				{
					cmp.EmitCharacter((char)interval.low, this.negate, this.ignore, reverse);
				}
				else
				{
					cmp.EmitRange((char)interval.low, (char)interval.high, this.negate, this.ignore, reverse);
				}
			}
			for (int k = 0; k < this.pos_cats.Length; k++)
			{
				if (this.pos_cats[k])
				{
					if (this.neg_cats[k])
					{
						cmp.EmitCategory(Category.AnySingleline, this.negate, reverse);
					}
					else
					{
						cmp.EmitCategory((Category)k, this.negate, reverse);
					}
				}
				else if (this.neg_cats[k])
				{
					cmp.EmitNotCategory((Category)k, this.negate, reverse);
				}
			}
			if (num > 1)
			{
				if (this.negate)
				{
					cmp.EmitTrue();
				}
				else
				{
					cmp.EmitFalse();
				}
				cmp.ResolveLink(linkRef);
			}
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x0008BC4C File Offset: 0x00089E4C
		public override void GetWidth(out int min, out int max)
		{
			min = (max = 1);
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool IsComplex()
		{
			return false;
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x0001E199 File Offset: 0x0001C399
		private static double GetIntervalCost(Interval i)
		{
			if (i.IsDiscontiguous)
			{
				return (double)(3 + (i.Size + 15 >> 4));
			}
			if (i.IsSingleton)
			{
				return 2.0;
			}
			return 3.0;
		}

		// Token: 0x04001B33 RID: 6963
		private const int distance_between_upper_and_lower_case = 32;

		// Token: 0x04001B34 RID: 6964
		private static Interval upper_case_characters = new Interval(65, 90);

		// Token: 0x04001B35 RID: 6965
		private bool negate;

		// Token: 0x04001B36 RID: 6966
		private bool ignore;

		// Token: 0x04001B37 RID: 6967
		private BitArray pos_cats;

		// Token: 0x04001B38 RID: 6968
		private BitArray neg_cats;

		// Token: 0x04001B39 RID: 6969
		private IntervalCollection intervals;
	}
}
