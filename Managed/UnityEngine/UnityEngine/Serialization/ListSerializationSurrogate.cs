using System;
using System.Collections;
using System.Runtime.Serialization;

namespace UnityEngine.Serialization
{
	// Token: 0x02000302 RID: 770
	internal class ListSerializationSurrogate : ISerializationSurrogate
	{
		// Token: 0x0600235F RID: 9055 RVA: 0x0002E558 File Offset: 0x0002C758
		public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
		{
			IList list = (IList)obj;
			info.AddValue("_size", list.Count);
			info.AddValue("_items", ListSerializationSurrogate.ArrayFromGenericList(list));
			info.AddValue("_version", 0);
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x0002E59C File Offset: 0x0002C79C
		public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
		{
			IList list = (IList)Activator.CreateInstance(obj.GetType());
			int @int = info.GetInt32("_size");
			if (@int == 0)
			{
				return list;
			}
			IEnumerator enumerator = ((IEnumerable)info.GetValue("_items", typeof(IEnumerable))).GetEnumerator();
			for (int i = 0; i < @int; i++)
			{
				if (!enumerator.MoveNext())
				{
					throw new InvalidOperationException();
				}
				list.Add(enumerator.Current);
			}
			return list;
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x0002E620 File Offset: 0x0002C820
		private static Array ArrayFromGenericList(IList list)
		{
			Array array = Array.CreateInstance(list.GetType().GetGenericArguments()[0], list.Count);
			list.CopyTo(array, 0);
			return array;
		}

		// Token: 0x04000BB3 RID: 2995
		public static readonly ISerializationSurrogate Default = new ListSerializationSurrogate();
	}
}
