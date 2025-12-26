using System;
using System.Collections;
using System.Reflection;

namespace System.ComponentModel
{
	// Token: 0x020001C2 RID: 450
	internal class TypeInfo : Info
	{
		// Token: 0x06000FCC RID: 4044 RVA: 0x0000CE43 File Offset: 0x0000B043
		public TypeInfo(Type t)
			: base(t)
		{
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x0000CE4C File Offset: 0x0000B04C
		public override AttributeCollection GetAttributes()
		{
			return base.GetAttributes(null);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00038754 File Offset: 0x00036954
		public override EventDescriptorCollection GetEvents()
		{
			if (this._events != null)
			{
				return this._events;
			}
			EventInfo[] events = base.InfoType.GetEvents();
			EventDescriptor[] array = new EventDescriptor[events.Length];
			for (int i = 0; i < events.Length; i++)
			{
				array[i] = new ReflectionEventDescriptor(events[i]);
			}
			this._events = new EventDescriptorCollection(array);
			return this._events;
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x000387BC File Offset: 0x000369BC
		public override PropertyDescriptorCollection GetProperties()
		{
			if (this._properties != null)
			{
				return this._properties;
			}
			Hashtable hashtable = new Hashtable();
			ArrayList arrayList = new ArrayList();
			Type type = base.InfoType;
			while (type != null && type != typeof(object))
			{
				PropertyInfo[] properties = type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
				foreach (PropertyInfo propertyInfo in properties)
				{
					if (propertyInfo.GetIndexParameters().Length == 0 && propertyInfo.CanRead && !hashtable.ContainsKey(propertyInfo.Name))
					{
						arrayList.Add(new ReflectionPropertyDescriptor(propertyInfo));
						hashtable.Add(propertyInfo.Name, null);
					}
				}
				type = type.BaseType;
			}
			this._properties = new PropertyDescriptorCollection((PropertyDescriptor[])arrayList.ToArray(typeof(PropertyDescriptor)), true);
			return this._properties;
		}

		// Token: 0x04000477 RID: 1143
		private EventDescriptorCollection _events;

		// Token: 0x04000478 RID: 1144
		private PropertyDescriptorCollection _properties;
	}
}
