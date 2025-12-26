using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Reflection;

namespace System.ComponentModel
{
	// Token: 0x020001C1 RID: 449
	internal class ComponentInfo : Info
	{
		// Token: 0x06000FC8 RID: 4040 RVA: 0x0000CE20 File Offset: 0x0000B020
		public ComponentInfo(IComponent component)
			: base(component.GetType())
		{
			this._component = component;
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x0000CE35 File Offset: 0x0000B035
		public override AttributeCollection GetAttributes()
		{
			return base.GetAttributes(this._component);
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x0003858C File Offset: 0x0003678C
		public override EventDescriptorCollection GetEvents()
		{
			if (this._events != null)
			{
				return this._events;
			}
			bool flag = true;
			EventInfo[] events = this._component.GetType().GetEvents();
			Hashtable hashtable = new Hashtable();
			foreach (EventInfo eventInfo in events)
			{
				hashtable[eventInfo.Name] = new ReflectionEventDescriptor(eventInfo);
			}
			if (this._component.Site != null)
			{
				global::System.ComponentModel.Design.ITypeDescriptorFilterService typeDescriptorFilterService = (global::System.ComponentModel.Design.ITypeDescriptorFilterService)this._component.Site.GetService(typeof(global::System.ComponentModel.Design.ITypeDescriptorFilterService));
				if (typeDescriptorFilterService != null)
				{
					flag = typeDescriptorFilterService.FilterEvents(this._component, hashtable);
				}
			}
			ArrayList arrayList = new ArrayList();
			arrayList.AddRange(hashtable.Values);
			EventDescriptorCollection eventDescriptorCollection = new EventDescriptorCollection(arrayList);
			if (flag)
			{
				this._events = eventDescriptorCollection;
			}
			return eventDescriptorCollection;
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0003866C File Offset: 0x0003686C
		public override PropertyDescriptorCollection GetProperties()
		{
			if (this._properties != null)
			{
				return this._properties;
			}
			bool flag = true;
			PropertyInfo[] properties = this._component.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
			Hashtable hashtable = new Hashtable();
			for (int i = properties.Length - 1; i >= 0; i--)
			{
				hashtable[properties[i].Name] = new ReflectionPropertyDescriptor(properties[i]);
			}
			if (this._component.Site != null)
			{
				global::System.ComponentModel.Design.ITypeDescriptorFilterService typeDescriptorFilterService = (global::System.ComponentModel.Design.ITypeDescriptorFilterService)this._component.Site.GetService(typeof(global::System.ComponentModel.Design.ITypeDescriptorFilterService));
				if (typeDescriptorFilterService != null)
				{
					flag = typeDescriptorFilterService.FilterProperties(this._component, hashtable);
				}
			}
			PropertyDescriptor[] array = new PropertyDescriptor[hashtable.Values.Count];
			hashtable.Values.CopyTo(array, 0);
			PropertyDescriptorCollection propertyDescriptorCollection = new PropertyDescriptorCollection(array, true);
			if (flag)
			{
				this._properties = propertyDescriptorCollection;
			}
			return propertyDescriptorCollection;
		}

		// Token: 0x04000474 RID: 1140
		private IComponent _component;

		// Token: 0x04000475 RID: 1141
		private EventDescriptorCollection _events;

		// Token: 0x04000476 RID: 1142
		private PropertyDescriptorCollection _properties;
	}
}
