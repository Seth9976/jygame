using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace SimpleJson.Reflection
{
	// Token: 0x0200022F RID: 559
	[GeneratedCode("reflection-utils", "1.0.0")]
	internal class ReflectionUtils
	{
		// Token: 0x06001FE0 RID: 8160 RVA: 0x0000C9D5 File Offset: 0x0000ABD5
		public static Attribute GetAttribute(MemberInfo info, Type type)
		{
			if (info == null || type == null || !Attribute.IsDefined(info, type))
			{
				return null;
			}
			return Attribute.GetCustomAttribute(info, type);
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x0000C9D5 File Offset: 0x0000ABD5
		public static Attribute GetAttribute(Type objectType, Type attributeType)
		{
			if (objectType == null || attributeType == null || !Attribute.IsDefined(objectType, attributeType))
			{
				return null;
			}
			return Attribute.GetCustomAttribute(objectType, attributeType);
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x0000C9F8 File Offset: 0x0000ABF8
		public static Type[] GetGenericTypeArguments(Type type)
		{
			return type.GetGenericArguments();
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00027F48 File Offset: 0x00026148
		public static bool IsTypeGenericeCollectionInterface(Type type)
		{
			if (!type.IsGenericType)
			{
				return false;
			}
			Type genericTypeDefinition = type.GetGenericTypeDefinition();
			return genericTypeDefinition == typeof(IList<>) || genericTypeDefinition == typeof(ICollection<>) || genericTypeDefinition == typeof(IEnumerable<>);
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x0000CA00 File Offset: 0x0000AC00
		public static bool IsAssignableFrom(Type type1, Type type2)
		{
			return type1.IsAssignableFrom(type2);
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00027F9C File Offset: 0x0002619C
		public static bool IsTypeDictionary(Type type)
		{
			if (typeof(IDictionary).IsAssignableFrom(type))
			{
				return true;
			}
			if (!type.IsGenericType)
			{
				return false;
			}
			Type genericTypeDefinition = type.GetGenericTypeDefinition();
			return genericTypeDefinition == typeof(IDictionary<, >);
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x0000CA09 File Offset: 0x0000AC09
		public static bool IsNullableType(Type type)
		{
			return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x0000CA2B File Offset: 0x0000AC2B
		public static object ToNullableType(object obj, Type nullableType)
		{
			return (obj != null) ? Convert.ChangeType(obj, Nullable.GetUnderlyingType(nullableType), CultureInfo.InvariantCulture) : null;
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x0000CA4A File Offset: 0x0000AC4A
		public static bool IsValueType(Type type)
		{
			return type.IsValueType;
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x0000CA52 File Offset: 0x0000AC52
		public static IEnumerable<ConstructorInfo> GetConstructors(Type type)
		{
			return type.GetConstructors();
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x00027FE4 File Offset: 0x000261E4
		public static ConstructorInfo GetConstructorInfo(Type type, params Type[] argsType)
		{
			IEnumerable<ConstructorInfo> constructors = ReflectionUtils.GetConstructors(type);
			foreach (ConstructorInfo constructorInfo in constructors)
			{
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				if (argsType.Length == parameters.Length)
				{
					int num = 0;
					bool flag = true;
					foreach (ParameterInfo parameterInfo in constructorInfo.GetParameters())
					{
						if (parameterInfo.ParameterType != argsType[num])
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						return constructorInfo;
					}
				}
			}
			return null;
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x0000CA5A File Offset: 0x0000AC5A
		public static IEnumerable<PropertyInfo> GetProperties(Type type)
		{
			return type.GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x0000CA64 File Offset: 0x0000AC64
		public static IEnumerable<FieldInfo> GetFields(Type type)
		{
			return type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x0000CA6E File Offset: 0x0000AC6E
		public static MethodInfo GetGetterMethodInfo(PropertyInfo propertyInfo)
		{
			return propertyInfo.GetGetMethod(true);
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x0000CA77 File Offset: 0x0000AC77
		public static MethodInfo GetSetterMethodInfo(PropertyInfo propertyInfo)
		{
			return propertyInfo.GetSetMethod(true);
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x0000CA80 File Offset: 0x0000AC80
		public static ReflectionUtils.ConstructorDelegate GetContructor(ConstructorInfo constructorInfo)
		{
			return ReflectionUtils.GetConstructorByReflection(constructorInfo);
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x0000CA88 File Offset: 0x0000AC88
		public static ReflectionUtils.ConstructorDelegate GetContructor(Type type, params Type[] argsType)
		{
			return ReflectionUtils.GetConstructorByReflection(type, argsType);
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x000280A8 File Offset: 0x000262A8
		public static ReflectionUtils.ConstructorDelegate GetConstructorByReflection(ConstructorInfo constructorInfo)
		{
			return (object[] args) => constructorInfo.Invoke(args);
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x000280D0 File Offset: 0x000262D0
		public static ReflectionUtils.ConstructorDelegate GetConstructorByReflection(Type type, params Type[] argsType)
		{
			ConstructorInfo constructorInfo = ReflectionUtils.GetConstructorInfo(type, argsType);
			return (constructorInfo != null) ? ReflectionUtils.GetConstructorByReflection(constructorInfo) : null;
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x0000CA91 File Offset: 0x0000AC91
		public static ReflectionUtils.GetDelegate GetGetMethod(PropertyInfo propertyInfo)
		{
			return ReflectionUtils.GetGetMethodByReflection(propertyInfo);
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x0000CA99 File Offset: 0x0000AC99
		public static ReflectionUtils.GetDelegate GetGetMethod(FieldInfo fieldInfo)
		{
			return ReflectionUtils.GetGetMethodByReflection(fieldInfo);
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x000280F8 File Offset: 0x000262F8
		public static ReflectionUtils.GetDelegate GetGetMethodByReflection(PropertyInfo propertyInfo)
		{
			MethodInfo methodInfo = ReflectionUtils.GetGetterMethodInfo(propertyInfo);
			return (object source) => methodInfo.Invoke(source, ReflectionUtils.EmptyObjects);
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x00028124 File Offset: 0x00026324
		public static ReflectionUtils.GetDelegate GetGetMethodByReflection(FieldInfo fieldInfo)
		{
			return (object source) => fieldInfo.GetValue(source);
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x0000CAA1 File Offset: 0x0000ACA1
		public static ReflectionUtils.SetDelegate GetSetMethod(PropertyInfo propertyInfo)
		{
			return ReflectionUtils.GetSetMethodByReflection(propertyInfo);
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x0000CAA9 File Offset: 0x0000ACA9
		public static ReflectionUtils.SetDelegate GetSetMethod(FieldInfo fieldInfo)
		{
			return ReflectionUtils.GetSetMethodByReflection(fieldInfo);
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x0002814C File Offset: 0x0002634C
		public static ReflectionUtils.SetDelegate GetSetMethodByReflection(PropertyInfo propertyInfo)
		{
			MethodInfo methodInfo = ReflectionUtils.GetSetterMethodInfo(propertyInfo);
			return delegate(object source, object value)
			{
				methodInfo.Invoke(source, new object[] { value });
			};
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x00028178 File Offset: 0x00026378
		public static ReflectionUtils.SetDelegate GetSetMethodByReflection(FieldInfo fieldInfo)
		{
			return delegate(object source, object value)
			{
				fieldInfo.SetValue(source, value);
			};
		}

		// Token: 0x040008B1 RID: 2225
		private static readonly object[] EmptyObjects = new object[0];

		// Token: 0x02000230 RID: 560
		public sealed class ThreadSafeDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
		{
			// Token: 0x06001FFB RID: 8187 RVA: 0x0000CAB1 File Offset: 0x0000ACB1
			public ThreadSafeDictionary(ReflectionUtils.ThreadSafeDictionaryValueFactory<TKey, TValue> valueFactory)
			{
				this._valueFactory = valueFactory;
			}

			// Token: 0x06001FFC RID: 8188 RVA: 0x0000CACB File Offset: 0x0000ACCB
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this._dictionary.GetEnumerator();
			}

			// Token: 0x06001FFD RID: 8189 RVA: 0x000281A0 File Offset: 0x000263A0
			private TValue Get(TKey key)
			{
				if (this._dictionary == null)
				{
					return this.AddValue(key);
				}
				TValue tvalue;
				if (!this._dictionary.TryGetValue(key, out tvalue))
				{
					return this.AddValue(key);
				}
				return tvalue;
			}

			// Token: 0x06001FFE RID: 8190 RVA: 0x000281DC File Offset: 0x000263DC
			private TValue AddValue(TKey key)
			{
				TValue tvalue = this._valueFactory(key);
				object @lock = this._lock;
				lock (@lock)
				{
					if (this._dictionary == null)
					{
						this._dictionary = new Dictionary<TKey, TValue>();
						this._dictionary[key] = tvalue;
					}
					else
					{
						TValue tvalue2;
						if (this._dictionary.TryGetValue(key, out tvalue2))
						{
							return tvalue2;
						}
						Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>(this._dictionary);
						dictionary[key] = tvalue;
						this._dictionary = dictionary;
					}
				}
				return tvalue;
			}

			// Token: 0x06001FFF RID: 8191 RVA: 0x0000CADD File Offset: 0x0000ACDD
			public void Add(TKey key, TValue value)
			{
				throw new NotImplementedException();
			}

			// Token: 0x06002000 RID: 8192 RVA: 0x0000CAE4 File Offset: 0x0000ACE4
			public bool ContainsKey(TKey key)
			{
				return this._dictionary.ContainsKey(key);
			}

			// Token: 0x17000846 RID: 2118
			// (get) Token: 0x06002001 RID: 8193 RVA: 0x0000CAF2 File Offset: 0x0000ACF2
			public ICollection<TKey> Keys
			{
				get
				{
					return this._dictionary.Keys;
				}
			}

			// Token: 0x06002002 RID: 8194 RVA: 0x0000CADD File Offset: 0x0000ACDD
			public bool Remove(TKey key)
			{
				throw new NotImplementedException();
			}

			// Token: 0x06002003 RID: 8195 RVA: 0x0000CAFF File Offset: 0x0000ACFF
			public bool TryGetValue(TKey key, out TValue value)
			{
				value = this[key];
				return true;
			}

			// Token: 0x17000847 RID: 2119
			// (get) Token: 0x06002004 RID: 8196 RVA: 0x0000CB0F File Offset: 0x0000AD0F
			public ICollection<TValue> Values
			{
				get
				{
					return this._dictionary.Values;
				}
			}

			// Token: 0x17000848 RID: 2120
			public TValue this[TKey key]
			{
				get
				{
					return this.Get(key);
				}
				set
				{
					throw new NotImplementedException();
				}
			}

			// Token: 0x06002007 RID: 8199 RVA: 0x0000CADD File Offset: 0x0000ACDD
			public void Add(KeyValuePair<TKey, TValue> item)
			{
				throw new NotImplementedException();
			}

			// Token: 0x06002008 RID: 8200 RVA: 0x0000CADD File Offset: 0x0000ACDD
			public void Clear()
			{
				throw new NotImplementedException();
			}

			// Token: 0x06002009 RID: 8201 RVA: 0x0000CADD File Offset: 0x0000ACDD
			public bool Contains(KeyValuePair<TKey, TValue> item)
			{
				throw new NotImplementedException();
			}

			// Token: 0x0600200A RID: 8202 RVA: 0x0000CADD File Offset: 0x0000ACDD
			public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
			{
				throw new NotImplementedException();
			}

			// Token: 0x17000849 RID: 2121
			// (get) Token: 0x0600200B RID: 8203 RVA: 0x0000CB25 File Offset: 0x0000AD25
			public int Count
			{
				get
				{
					return this._dictionary.Count;
				}
			}

			// Token: 0x1700084A RID: 2122
			// (get) Token: 0x0600200C RID: 8204 RVA: 0x0000CADD File Offset: 0x0000ACDD
			public bool IsReadOnly
			{
				get
				{
					throw new NotImplementedException();
				}
			}

			// Token: 0x0600200D RID: 8205 RVA: 0x0000CADD File Offset: 0x0000ACDD
			public bool Remove(KeyValuePair<TKey, TValue> item)
			{
				throw new NotImplementedException();
			}

			// Token: 0x0600200E RID: 8206 RVA: 0x0000CACB File Offset: 0x0000ACCB
			public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
			{
				return this._dictionary.GetEnumerator();
			}

			// Token: 0x040008B2 RID: 2226
			private readonly object _lock = new object();

			// Token: 0x040008B3 RID: 2227
			private readonly ReflectionUtils.ThreadSafeDictionaryValueFactory<TKey, TValue> _valueFactory;

			// Token: 0x040008B4 RID: 2228
			private Dictionary<TKey, TValue> _dictionary;
		}

		// Token: 0x02000231 RID: 561
		// (Invoke) Token: 0x06002010 RID: 8208
		public delegate object GetDelegate(object source);

		// Token: 0x02000232 RID: 562
		// (Invoke) Token: 0x06002014 RID: 8212
		public delegate void SetDelegate(object source, object value);

		// Token: 0x02000233 RID: 563
		// (Invoke) Token: 0x06002018 RID: 8216
		public delegate object ConstructorDelegate(params object[] args);

		// Token: 0x02000234 RID: 564
		// (Invoke) Token: 0x0600201C RID: 8220
		public delegate TValue ThreadSafeDictionaryValueFactory<TKey, TValue>(TKey key);
	}
}
