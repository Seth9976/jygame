using System;
using System.Collections;
using System.ComponentModel.Design;

namespace System.ComponentModel
{
	// Token: 0x020001C0 RID: 448
	internal abstract class Info
	{
		// Token: 0x06000FBE RID: 4030 RVA: 0x0000CE09 File Offset: 0x0000B009
		public Info(Type infoType)
		{
			this._infoType = infoType;
		}

		// Token: 0x06000FBF RID: 4031
		public abstract AttributeCollection GetAttributes();

		// Token: 0x06000FC0 RID: 4032
		public abstract EventDescriptorCollection GetEvents();

		// Token: 0x06000FC1 RID: 4033
		public abstract PropertyDescriptorCollection GetProperties();

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x0000CE18 File Offset: 0x0000B018
		public Type InfoType
		{
			get
			{
				return this._infoType;
			}
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00038230 File Offset: 0x00036430
		public EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			EventDescriptorCollection events = this.GetEvents();
			if (attributes == null)
			{
				return events;
			}
			return events.Filter(attributes);
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00038254 File Offset: 0x00036454
		public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			PropertyDescriptorCollection properties = this.GetProperties();
			if (attributes == null)
			{
				return properties;
			}
			return properties.Filter(attributes);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00038278 File Offset: 0x00036478
		public EventDescriptor GetDefaultEvent()
		{
			if (this._gotDefaultEvent)
			{
				return this._defaultEvent;
			}
			DefaultEventAttribute defaultEventAttribute = (DefaultEventAttribute)this.GetAttributes()[typeof(DefaultEventAttribute)];
			if (defaultEventAttribute == null || defaultEventAttribute.Name == null)
			{
				this._defaultEvent = null;
			}
			else
			{
				EventDescriptorCollection events = this.GetEvents();
				this._defaultEvent = events[defaultEventAttribute.Name];
			}
			this._gotDefaultEvent = true;
			return this._defaultEvent;
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x000382F8 File Offset: 0x000364F8
		public PropertyDescriptor GetDefaultProperty()
		{
			if (this._gotDefaultProperty)
			{
				return this._defaultProperty;
			}
			DefaultPropertyAttribute defaultPropertyAttribute = (DefaultPropertyAttribute)this.GetAttributes()[typeof(DefaultPropertyAttribute)];
			if (defaultPropertyAttribute == null || defaultPropertyAttribute.Name == null)
			{
				this._defaultProperty = null;
			}
			else
			{
				PropertyDescriptorCollection properties = this.GetProperties();
				this._defaultProperty = properties[defaultPropertyAttribute.Name];
			}
			this._gotDefaultProperty = true;
			return this._defaultProperty;
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00038378 File Offset: 0x00036578
		protected AttributeCollection GetAttributes(IComponent comp)
		{
			if (this._attributes != null)
			{
				return this._attributes;
			}
			bool flag = true;
			ArrayList arrayList = new ArrayList();
			foreach (Attribute attribute in this._infoType.GetCustomAttributes(false))
			{
				arrayList.Add(attribute);
			}
			Type type = this._infoType.BaseType;
			while (type != null && type != typeof(object))
			{
				foreach (Attribute attribute2 in type.GetCustomAttributes(false))
				{
					arrayList.Add(attribute2);
				}
				type = type.BaseType;
			}
			foreach (Type type2 in this._infoType.GetInterfaces())
			{
				foreach (object obj in TypeDescriptor.GetAttributes(type2))
				{
					Attribute attribute3 = (Attribute)obj;
					arrayList.Add(attribute3);
				}
			}
			Hashtable hashtable = new Hashtable();
			for (int l = arrayList.Count - 1; l >= 0; l--)
			{
				Attribute attribute4 = (Attribute)arrayList[l];
				hashtable[attribute4.TypeId] = attribute4;
			}
			if (comp != null && comp.Site != null)
			{
				global::System.ComponentModel.Design.ITypeDescriptorFilterService typeDescriptorFilterService = (global::System.ComponentModel.Design.ITypeDescriptorFilterService)comp.Site.GetService(typeof(global::System.ComponentModel.Design.ITypeDescriptorFilterService));
				if (typeDescriptorFilterService != null)
				{
					flag = typeDescriptorFilterService.FilterAttributes(comp, hashtable);
				}
			}
			Attribute[] array = new Attribute[hashtable.Values.Count];
			hashtable.Values.CopyTo(array, 0);
			AttributeCollection attributeCollection = new AttributeCollection(array);
			if (flag)
			{
				this._attributes = attributeCollection;
			}
			return attributeCollection;
		}

		// Token: 0x0400046E RID: 1134
		private Type _infoType;

		// Token: 0x0400046F RID: 1135
		private EventDescriptor _defaultEvent;

		// Token: 0x04000470 RID: 1136
		private bool _gotDefaultEvent;

		// Token: 0x04000471 RID: 1137
		private PropertyDescriptor _defaultProperty;

		// Token: 0x04000472 RID: 1138
		private bool _gotDefaultProperty;

		// Token: 0x04000473 RID: 1139
		private AttributeCollection _attributes;
	}
}
