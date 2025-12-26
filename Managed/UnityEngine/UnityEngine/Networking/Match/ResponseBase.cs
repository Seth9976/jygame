using System;
using System.Collections.Generic;

namespace UnityEngine.Networking.Match
{
	/// <summary>
	///   <para>A response object base.</para>
	/// </summary>
	// Token: 0x020001FD RID: 509
	public abstract class ResponseBase
	{
		// Token: 0x06001DDD RID: 7645
		public abstract void Parse(object obj);

		// Token: 0x06001DDE RID: 7646 RVA: 0x0000B9F6 File Offset: 0x00009BF6
		internal string ParseJSONString(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				return obj as string;
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x0000BA1D File Offset: 0x00009C1D
		internal short ParseJSONInt16(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				return Convert.ToInt16(obj);
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x0000BA44 File Offset: 0x00009C44
		internal int ParseJSONInt32(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				return Convert.ToInt32(obj);
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x0000BA6B File Offset: 0x00009C6B
		internal long ParseJSONInt64(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				return Convert.ToInt64(obj);
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x0000BA92 File Offset: 0x00009C92
		internal ushort ParseJSONUInt16(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				return Convert.ToUInt16(obj);
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x0000BAB9 File Offset: 0x00009CB9
		internal uint ParseJSONUInt32(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				return Convert.ToUInt32(obj);
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x0000BAE0 File Offset: 0x00009CE0
		internal ulong ParseJSONUInt64(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				return Convert.ToUInt64(obj);
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x0000BB07 File Offset: 0x00009D07
		internal bool ParseJSONBool(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				return Convert.ToBoolean(obj);
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x0000BB2E File Offset: 0x00009D2E
		internal DateTime ParseJSONDateTime(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			throw new FormatException(name + " DateTime not yet supported");
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x000248BC File Offset: 0x00022ABC
		internal List<string> ParseJSONListOfStrings(string name, object obj, IDictionary<string, object> dictJsonObj)
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				List<object> list = obj as List<object>;
				if (list != null)
				{
					List<string> list2 = new List<string>();
					foreach (object obj2 in list)
					{
						IDictionary<string, object> dictionary = (IDictionary<string, object>)obj2;
						foreach (KeyValuePair<string, object> keyValuePair in dictionary)
						{
							string text = (string)keyValuePair.Value;
							list2.Add(text);
						}
					}
					return list2;
				}
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x00024998 File Offset: 0x00022B98
		internal List<T> ParseJSONList<T>(string name, object obj, IDictionary<string, object> dictJsonObj) where T : ResponseBase, new()
		{
			if (dictJsonObj.TryGetValue(name, out obj))
			{
				List<object> list = obj as List<object>;
				if (list != null)
				{
					List<T> list2 = new List<T>();
					foreach (object obj2 in list)
					{
						IDictionary<string, object> dictionary = (IDictionary<string, object>)obj2;
						T t = new T();
						t.Parse(dictionary);
						list2.Add(t);
					}
					return list2;
				}
			}
			throw new FormatException(name + " not found in JSON dictionary");
		}
	}
}
