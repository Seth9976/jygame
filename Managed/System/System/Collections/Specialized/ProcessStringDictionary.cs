using System;

namespace System.Collections.Specialized
{
	// Token: 0x020000C3 RID: 195
	internal class ProcessStringDictionary : StringDictionary, IEnumerable
	{
		// Token: 0x06000856 RID: 2134 RVA: 0x0002E764 File Offset: 0x0002C964
		public ProcessStringDictionary()
		{
			IHashCodeProvider hashCodeProvider = null;
			IComparer comparer = null;
			int platform = (int)Environment.OSVersion.Platform;
			if (platform != 4 && platform != 128)
			{
				hashCodeProvider = CaseInsensitiveHashCodeProvider.DefaultInvariant;
				comparer = CaseInsensitiveComparer.DefaultInvariant;
			}
			this.table = new Hashtable(hashCodeProvider, comparer);
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00007EB3 File Offset: 0x000060B3
		public override int Count
		{
			get
			{
				return this.table.Count;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001D0 RID: 464
		public override string this[string key]
		{
			get
			{
				return (string)this.table[key];
			}
			set
			{
				this.table[key] = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x00007EE2 File Offset: 0x000060E2
		public override ICollection Keys
		{
			get
			{
				return this.table.Keys;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x00007EEF File Offset: 0x000060EF
		public override ICollection Values
		{
			get
			{
				return this.table.Values;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x00007EFC File Offset: 0x000060FC
		public override object SyncRoot
		{
			get
			{
				return this.table.SyncRoot;
			}
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00007F09 File Offset: 0x00006109
		public override void Add(string key, string value)
		{
			this.table.Add(key, value);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00007F18 File Offset: 0x00006118
		public override void Clear()
		{
			this.table.Clear();
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00007F25 File Offset: 0x00006125
		public override bool ContainsKey(string key)
		{
			return this.table.ContainsKey(key);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00007F33 File Offset: 0x00006133
		public override bool ContainsValue(string value)
		{
			return this.table.ContainsValue(value);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00007F41 File Offset: 0x00006141
		public override void CopyTo(Array array, int index)
		{
			this.table.CopyTo(array, index);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00007F50 File Offset: 0x00006150
		public override IEnumerator GetEnumerator()
		{
			return this.table.GetEnumerator();
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00007F5D File Offset: 0x0000615D
		public override void Remove(string key)
		{
			this.table.Remove(key);
		}

		// Token: 0x04000244 RID: 580
		private Hashtable table;
	}
}
