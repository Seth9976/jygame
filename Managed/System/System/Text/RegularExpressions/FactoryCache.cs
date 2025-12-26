using System;
using System.Collections;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000485 RID: 1157
	internal class FactoryCache
	{
		// Token: 0x060028D5 RID: 10453 RVA: 0x0001C6CB File Offset: 0x0001A8CB
		public FactoryCache(int capacity)
		{
			this.capacity = capacity;
			this.factories = new Hashtable(capacity);
			this.mru_list = new MRUList();
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x0007A7F4 File Offset: 0x000789F4
		public void Add(string pattern, RegexOptions options, IMachineFactory factory)
		{
			lock (this)
			{
				FactoryCache.Key key = new FactoryCache.Key(pattern, options);
				this.Cleanup();
				this.factories[key] = factory;
				this.mru_list.Use(key);
			}
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x0007A84C File Offset: 0x00078A4C
		private void Cleanup()
		{
			while (this.factories.Count >= this.capacity && this.capacity > 0)
			{
				object obj = this.mru_list.Evict();
				if (obj != null)
				{
					this.factories.Remove((FactoryCache.Key)obj);
				}
			}
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x0007A8A4 File Offset: 0x00078AA4
		public IMachineFactory Lookup(string pattern, RegexOptions options)
		{
			lock (this)
			{
				FactoryCache.Key key = new FactoryCache.Key(pattern, options);
				if (this.factories.Contains(key))
				{
					this.mru_list.Use(key);
					return (IMachineFactory)this.factories[key];
				}
			}
			return null;
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x060028D9 RID: 10457 RVA: 0x0001C6F1 File Offset: 0x0001A8F1
		// (set) Token: 0x060028DA RID: 10458 RVA: 0x0007A914 File Offset: 0x00078B14
		public int Capacity
		{
			get
			{
				return this.capacity;
			}
			set
			{
				lock (this)
				{
					this.capacity = value;
					this.Cleanup();
				}
			}
		}

		// Token: 0x04001920 RID: 6432
		private int capacity;

		// Token: 0x04001921 RID: 6433
		private Hashtable factories;

		// Token: 0x04001922 RID: 6434
		private MRUList mru_list;

		// Token: 0x02000486 RID: 1158
		private class Key
		{
			// Token: 0x060028DB RID: 10459 RVA: 0x0001C6F9 File Offset: 0x0001A8F9
			public Key(string pattern, RegexOptions options)
			{
				this.pattern = pattern;
				this.options = options;
			}

			// Token: 0x060028DC RID: 10460 RVA: 0x0001C70F File Offset: 0x0001A90F
			public override int GetHashCode()
			{
				return this.pattern.GetHashCode() ^ (int)this.options;
			}

			// Token: 0x060028DD RID: 10461 RVA: 0x0007A954 File Offset: 0x00078B54
			public override bool Equals(object o)
			{
				if (o == null || !(o is FactoryCache.Key))
				{
					return false;
				}
				FactoryCache.Key key = (FactoryCache.Key)o;
				return this.options == key.options && this.pattern.Equals(key.pattern);
			}

			// Token: 0x060028DE RID: 10462 RVA: 0x0001C723 File Offset: 0x0001A923
			public override string ToString()
			{
				return string.Concat(new object[] { "('", this.pattern, "', [", this.options, "])" });
			}

			// Token: 0x04001923 RID: 6435
			public string pattern;

			// Token: 0x04001924 RID: 6436
			public RegexOptions options;
		}
	}
}
