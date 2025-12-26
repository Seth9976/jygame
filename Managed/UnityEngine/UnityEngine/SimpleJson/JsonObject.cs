using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SimpleJson
{
	// Token: 0x0200022B RID: 555
	[GeneratedCode("simple-json", "1.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class JsonObject : IDictionary<string, object>, IEnumerable<KeyValuePair<string, object>>, ICollection<KeyValuePair<string, object>>, IEnumerable
	{
		// Token: 0x06001F9F RID: 8095 RVA: 0x0000C786 File Offset: 0x0000A986
		public JsonObject()
		{
			this._members = new Dictionary<string, object>();
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x0000C799 File Offset: 0x0000A999
		public JsonObject(IEqualityComparer<string> comparer)
		{
			this._members = new Dictionary<string, object>(comparer);
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x0000C7AD File Offset: 0x0000A9AD
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this._members.GetEnumerator();
		}

		// Token: 0x1700083E RID: 2110
		public object this[int index]
		{
			get
			{
				return JsonObject.GetAtIndex(this._members, index);
			}
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x00026560 File Offset: 0x00024760
		internal static object GetAtIndex(IDictionary<string, object> obj, int index)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			if (index >= obj.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			int num = 0;
			foreach (KeyValuePair<string, object> keyValuePair in obj)
			{
				if (num++ == index)
				{
					return keyValuePair.Value;
				}
			}
			return null;
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x0000C7CD File Offset: 0x0000A9CD
		public void Add(string key, object value)
		{
			this._members.Add(key, value);
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x0000C7DC File Offset: 0x0000A9DC
		public bool ContainsKey(string key)
		{
			return this._members.ContainsKey(key);
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x0000C7EA File Offset: 0x0000A9EA
		public ICollection<string> Keys
		{
			get
			{
				return this._members.Keys;
			}
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x0000C7F7 File Offset: 0x0000A9F7
		public bool Remove(string key)
		{
			return this._members.Remove(key);
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x0000C805 File Offset: 0x0000AA05
		public bool TryGetValue(string key, out object value)
		{
			return this._members.TryGetValue(key, out value);
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x0000C814 File Offset: 0x0000AA14
		public ICollection<object> Values
		{
			get
			{
				return this._members.Values;
			}
		}

		// Token: 0x17000841 RID: 2113
		public object this[string key]
		{
			get
			{
				return this._members[key];
			}
			set
			{
				this._members[key] = value;
			}
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x0000C83E File Offset: 0x0000AA3E
		public void Add(KeyValuePair<string, object> item)
		{
			this._members.Add(item.Key, item.Value);
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x0000C859 File Offset: 0x0000AA59
		public void Clear()
		{
			this._members.Clear();
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x0000C866 File Offset: 0x0000AA66
		public bool Contains(KeyValuePair<string, object> item)
		{
			return this._members.ContainsKey(item.Key) && this._members[item.Key] == item.Value;
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x000265F0 File Offset: 0x000247F0
		public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			int num = this.Count;
			foreach (KeyValuePair<string, object> keyValuePair in this)
			{
				array[arrayIndex++] = keyValuePair;
				if (--num <= 0)
				{
					break;
				}
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x0000C89D File Offset: 0x0000AA9D
		public int Count
		{
			get
			{
				return this._members.Count;
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x00002C36 File Offset: 0x00000E36
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x0000C8AA File Offset: 0x0000AAAA
		public bool Remove(KeyValuePair<string, object> item)
		{
			return this._members.Remove(item.Key);
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x0000C7AD File Offset: 0x0000A9AD
		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			return this._members.GetEnumerator();
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x0000C8BE File Offset: 0x0000AABE
		public override string ToString()
		{
			return SimpleJson.SerializeObject(this);
		}

		// Token: 0x0400089B RID: 2203
		private readonly Dictionary<string, object> _members;
	}
}
