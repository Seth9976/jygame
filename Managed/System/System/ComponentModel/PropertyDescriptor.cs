using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	/// <summary>Provides an abstraction of a property on a class.</summary>
	// Token: 0x0200019C RID: 412
	[ComVisible(true)]
	public abstract class PropertyDescriptor : MemberDescriptor
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> class with the name and attributes in the specified <see cref="T:System.ComponentModel.MemberDescriptor" />.</summary>
		/// <param name="descr">A <see cref="T:System.ComponentModel.MemberDescriptor" /> that contains the name of the property and its attributes. </param>
		// Token: 0x06000E6F RID: 3695 RVA: 0x0000A9BE File Offset: 0x00008BBE
		protected PropertyDescriptor(MemberDescriptor reference)
			: base(reference)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> class with the name in the specified <see cref="T:System.ComponentModel.MemberDescriptor" /> and the attributes in both the <see cref="T:System.ComponentModel.MemberDescriptor" /> and the <see cref="T:System.Attribute" /> array.</summary>
		/// <param name="descr">A <see cref="T:System.ComponentModel.MemberDescriptor" /> containing the name of the member and its attributes. </param>
		/// <param name="attrs">An <see cref="T:System.Attribute" /> array containing the attributes you want to associate with the property. </param>
		// Token: 0x06000E70 RID: 3696 RVA: 0x0000A9C7 File Offset: 0x00008BC7
		protected PropertyDescriptor(MemberDescriptor reference, Attribute[] attrs)
			: base(reference, attrs)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> class with the specified name and attributes.</summary>
		/// <param name="name">The name of the property. </param>
		/// <param name="attrs">An array of type <see cref="T:System.Attribute" /> that contains the property attributes. </param>
		// Token: 0x06000E71 RID: 3697 RVA: 0x0000A9D1 File Offset: 0x00008BD1
		protected PropertyDescriptor(string name, Attribute[] attrs)
			: base(name, attrs)
		{
		}

		/// <summary>When overridden in a derived class, gets the type of the component this property is bound to.</summary>
		/// <returns>A <see cref="T:System.Type" /> that represents the type of component this property is bound to. When the <see cref="M:System.ComponentModel.PropertyDescriptor.GetValue(System.Object)" /> or <see cref="M:System.ComponentModel.PropertyDescriptor.SetValue(System.Object,System.Object)" /> methods are invoked, the object specified might be an instance of this type.</returns>
		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000E72 RID: 3698
		public abstract Type ComponentType { get; }

		/// <summary>Gets the type converter for this property.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.TypeConverter" /> that is used to convert the <see cref="T:System.Type" /> of this property.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x00035100 File Offset: 0x00033300
		public virtual TypeConverter Converter
		{
			get
			{
				if (this.converter == null && this.PropertyType != null)
				{
					TypeConverterAttribute typeConverterAttribute = (TypeConverterAttribute)this.Attributes[typeof(TypeConverterAttribute)];
					if (typeConverterAttribute != null && typeConverterAttribute != TypeConverterAttribute.Default)
					{
						Type typeFromName = this.GetTypeFromName(typeConverterAttribute.ConverterTypeName);
						if (typeFromName != null && typeof(TypeConverter).IsAssignableFrom(typeFromName))
						{
							this.converter = (TypeConverter)this.CreateInstance(typeFromName);
						}
					}
					if (this.converter == null)
					{
						this.converter = TypeDescriptor.GetConverter(this.PropertyType);
					}
				}
				return this.converter;
			}
		}

		/// <summary>Gets a value indicating whether this property should be localized, as specified in the <see cref="T:System.ComponentModel.LocalizableAttribute" />.</summary>
		/// <returns>true if the member is marked with the <see cref="T:System.ComponentModel.LocalizableAttribute" /> set to true; otherwise, false.</returns>
		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x000351AC File Offset: 0x000333AC
		public virtual bool IsLocalizable
		{
			get
			{
				foreach (Attribute attribute in this.AttributeArray)
				{
					if (attribute is LocalizableAttribute)
					{
						return ((LocalizableAttribute)attribute).IsLocalizable;
					}
				}
				return false;
			}
		}

		/// <summary>When overridden in a derived class, gets a value indicating whether this property is read-only.</summary>
		/// <returns>true if the property is read-only; otherwise, false.</returns>
		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000E75 RID: 3701
		public abstract bool IsReadOnly { get; }

		/// <summary>When overridden in a derived class, gets the type of the property.</summary>
		/// <returns>A <see cref="T:System.Type" /> that represents the type of the property.</returns>
		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000E76 RID: 3702
		public abstract Type PropertyType { get; }

		/// <summary>Gets a value indicating whether value change notifications for this property may originate from outside the property descriptor.</summary>
		/// <returns>true if value change notifications may originate from outside the property descriptor; otherwise, false.</returns>
		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public virtual bool SupportsChangeEvents
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether this property should be serialized, as specified in the <see cref="T:System.ComponentModel.DesignerSerializationVisibilityAttribute" />.</summary>
		/// <returns>One of the <see cref="T:System.ComponentModel.DesignerSerializationVisibility" /> enumeration values that specifies whether this property should be serialized.</returns>
		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x000351F0 File Offset: 0x000333F0
		public DesignerSerializationVisibility SerializationVisibility
		{
			get
			{
				foreach (Attribute attribute in this.AttributeArray)
				{
					if (attribute is DesignerSerializationVisibilityAttribute)
					{
						DesignerSerializationVisibilityAttribute designerSerializationVisibilityAttribute = (DesignerSerializationVisibilityAttribute)attribute;
						return designerSerializationVisibilityAttribute.Visibility;
					}
				}
				return DesignerSerializationVisibility.Visible;
			}
		}

		/// <summary>Enables other objects to be notified when this property changes.</summary>
		/// <param name="component">The component to add the handler for. </param>
		/// <param name="handler">The delegate to add as a listener. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="component" /> or <paramref name="handler" /> is null.</exception>
		// Token: 0x06000E79 RID: 3705 RVA: 0x00035238 File Offset: 0x00033438
		public virtual void AddValueChanged(object component, EventHandler handler)
		{
			if (component == null)
			{
				throw new ArgumentNullException("component");
			}
			if (handler == null)
			{
				throw new ArgumentNullException("handler");
			}
			if (this.notifiers == null)
			{
				this.notifiers = new Hashtable();
			}
			EventHandler eventHandler = (EventHandler)this.notifiers[component];
			if (eventHandler != null)
			{
				eventHandler = (EventHandler)Delegate.Combine(eventHandler, handler);
				this.notifiers[component] = eventHandler;
			}
			else
			{
				this.notifiers[component] = handler;
			}
		}

		/// <summary>Enables other objects to be notified when this property changes.</summary>
		/// <param name="component">The component to remove the handler for. </param>
		/// <param name="handler">The delegate to remove as a listener. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="component" /> or <paramref name="handler" /> is null.</exception>
		// Token: 0x06000E7A RID: 3706 RVA: 0x000352C4 File Offset: 0x000334C4
		public virtual void RemoveValueChanged(object component, EventHandler handler)
		{
			if (component == null)
			{
				throw new ArgumentNullException("component");
			}
			if (handler == null)
			{
				throw new ArgumentNullException("handler");
			}
			if (this.notifiers == null)
			{
				return;
			}
			EventHandler eventHandler = (EventHandler)this.notifiers[component];
			eventHandler = (EventHandler)Delegate.Remove(eventHandler, handler);
			if (eventHandler == null)
			{
				this.notifiers.Remove(component);
			}
			else
			{
				this.notifiers[component] = eventHandler;
			}
		}

		/// <summary>Adds the attributes of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> to the specified list of attributes in the parent class.</summary>
		/// <param name="attributeList">An <see cref="T:System.Collections.IList" /> that lists the attributes in the parent class. Initially, this is empty.</param>
		// Token: 0x06000E7B RID: 3707 RVA: 0x0000C06D File Offset: 0x0000A26D
		protected override void FillAttributes(IList attributeList)
		{
			base.FillAttributes(attributeList);
		}

		/// <summary>This method returns the object that should be used during invocation of members.</summary>
		/// <returns>The <see cref="T:System.Object" /> that should be used during invocation of members.</returns>
		/// <param name="type">The <see cref="T:System.Type" /> of the invocation target.</param>
		/// <param name="instance">The potential invocation target.</param>
		// Token: 0x06000E7C RID: 3708 RVA: 0x00035344 File Offset: 0x00033544
		protected override object GetInvocationTarget(Type type, object instance)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (instance == null)
			{
				throw new ArgumentNullException("instance");
			}
			if (instance is CustomTypeDescriptor)
			{
				CustomTypeDescriptor customTypeDescriptor = (CustomTypeDescriptor)instance;
				return customTypeDescriptor.GetPropertyOwner(this);
			}
			return base.GetInvocationTarget(type, instance);
		}

		/// <summary>Retrieves the current set of ValueChanged event handlers for a specific component</summary>
		/// <returns>A combined multicast event handler, or null if no event handlers are currently assigned to <paramref name="component" />.</returns>
		/// <param name="component">The component for which to retrieve event handlers.</param>
		// Token: 0x06000E7D RID: 3709 RVA: 0x0000C076 File Offset: 0x0000A276
		protected internal EventHandler GetValueChangedHandler(object component)
		{
			if (component == null || this.notifiers == null)
			{
				return null;
			}
			return (EventHandler)this.notifiers[component];
		}

		/// <summary>Raises the ValueChanged event that you implemented.</summary>
		/// <param name="component">The object that raises the event. </param>
		/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data. </param>
		// Token: 0x06000E7E RID: 3710 RVA: 0x00035398 File Offset: 0x00033598
		protected virtual void OnValueChanged(object component, EventArgs e)
		{
			if (this.notifiers == null)
			{
				return;
			}
			EventHandler eventHandler = (EventHandler)this.notifiers[component];
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(component, e);
		}

		/// <summary>When overridden in a derived class, gets the current value of the property on a component.</summary>
		/// <returns>The value of a property for a given component.</returns>
		/// <param name="component">The component with the property for which to retrieve the value. </param>
		// Token: 0x06000E7F RID: 3711
		public abstract object GetValue(object component);

		/// <summary>When overridden in a derived class, sets the value of the component to a different value.</summary>
		/// <param name="component">The component with the property value that is to be set. </param>
		/// <param name="value">The new value. </param>
		// Token: 0x06000E80 RID: 3712
		public abstract void SetValue(object component, object value);

		/// <summary>When overridden in a derived class, resets the value for this property of the component to the default value.</summary>
		/// <param name="component">The component with the property value that is to be reset to the default value. </param>
		// Token: 0x06000E81 RID: 3713
		public abstract void ResetValue(object component);

		/// <summary>When overridden in a derived class, returns whether resetting an object changes its value.</summary>
		/// <returns>true if resetting the component changes its value; otherwise, false.</returns>
		/// <param name="component">The component to test for reset capability. </param>
		// Token: 0x06000E82 RID: 3714
		public abstract bool CanResetValue(object component);

		/// <summary>When overridden in a derived class, determines a value indicating whether the value of this property needs to be persisted.</summary>
		/// <returns>true if the property should be persisted; otherwise, false.</returns>
		/// <param name="component">The component with the property to be examined for persistence. </param>
		// Token: 0x06000E83 RID: 3715
		public abstract bool ShouldSerializeValue(object component);

		/// <summary>Creates an instance of the specified type.</summary>
		/// <returns>A new instance of the type.</returns>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type to create. </param>
		// Token: 0x06000E84 RID: 3716 RVA: 0x000353D4 File Offset: 0x000335D4
		protected object CreateInstance(Type type)
		{
			if (type == null || this.PropertyType == null)
			{
				return null;
			}
			Type[] array = new Type[] { typeof(Type) };
			ConstructorInfo constructor = type.GetConstructor(array);
			object obj;
			if (constructor != null)
			{
				object[] array2 = new object[] { this.PropertyType };
				obj = TypeDescriptor.CreateInstance(null, type, array, array2);
			}
			else
			{
				obj = TypeDescriptor.CreateInstance(null, type, null, null);
			}
			return obj;
		}

		/// <summary>Compares this to another object to see if they are equivalent.</summary>
		/// <returns>true if the values are equivalent; otherwise, false.</returns>
		/// <param name="obj">The object to compare to this <see cref="T:System.ComponentModel.PropertyDescriptor" />. </param>
		// Token: 0x06000E85 RID: 3717 RVA: 0x00035444 File Offset: 0x00033644
		public override bool Equals(object obj)
		{
			if (!base.Equals(obj))
			{
				return false;
			}
			PropertyDescriptor propertyDescriptor = obj as PropertyDescriptor;
			return propertyDescriptor != null && propertyDescriptor.PropertyType == this.PropertyType;
		}

		/// <summary>Returns the default <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06000E86 RID: 3718 RVA: 0x0000C09C File Offset: 0x0000A29C
		public PropertyDescriptorCollection GetChildProperties()
		{
			return this.GetChildProperties(null, null);
		}

		/// <summary>Returns a <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> for a given object.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties for the specified component.</returns>
		/// <param name="instance">A component to get the properties for. </param>
		// Token: 0x06000E87 RID: 3719 RVA: 0x0000C0A6 File Offset: 0x0000A2A6
		public PropertyDescriptorCollection GetChildProperties(object instance)
		{
			return this.GetChildProperties(instance, null);
		}

		/// <summary>Returns a <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> using a specified array of attributes as a filter.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties that match the specified attributes.</returns>
		/// <param name="filter">An array of type <see cref="T:System.Attribute" /> to use as a filter. </param>
		// Token: 0x06000E88 RID: 3720 RVA: 0x0000C0B0 File Offset: 0x0000A2B0
		public PropertyDescriptorCollection GetChildProperties(Attribute[] filter)
		{
			return this.GetChildProperties(null, filter);
		}

		/// <summary>Returns the hash code for this object.</summary>
		/// <returns>The hash code for this object.</returns>
		// Token: 0x06000E89 RID: 3721 RVA: 0x0000C0BA File Offset: 0x0000A2BA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Returns a <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> for a given object using a specified array of attributes as a filter.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> with the properties that match the specified attributes for the specified component.</returns>
		/// <param name="instance">A component to get the properties for. </param>
		/// <param name="filter">An array of type <see cref="T:System.Attribute" /> to use as a filter. </param>
		// Token: 0x06000E8A RID: 3722 RVA: 0x0000C0C2 File Offset: 0x0000A2C2
		public virtual PropertyDescriptorCollection GetChildProperties(object instance, Attribute[] filter)
		{
			return TypeDescriptor.GetProperties(instance, filter);
		}

		/// <summary>Gets an editor of the specified type.</summary>
		/// <returns>An instance of the requested editor type, or null if an editor cannot be found.</returns>
		/// <param name="editorBaseType">The base type of editor, which is used to differentiate between multiple editors that a property supports. </param>
		// Token: 0x06000E8B RID: 3723 RVA: 0x0003547C File Offset: 0x0003367C
		public virtual object GetEditor(Type editorBaseType)
		{
			Type type = null;
			Attribute[] attributeArray = this.AttributeArray;
			if (attributeArray != null && attributeArray.Length != 0)
			{
				foreach (Attribute attribute in attributeArray)
				{
					EditorAttribute editorAttribute = attribute as EditorAttribute;
					if (editorAttribute != null)
					{
						type = this.GetTypeFromName(editorAttribute.EditorTypeName);
						if (type != null && type.IsSubclassOf(editorBaseType))
						{
							break;
						}
					}
				}
			}
			object obj = null;
			if (type != null)
			{
				obj = this.CreateInstance(type);
			}
			if (obj == null)
			{
				obj = TypeDescriptor.GetEditor(this.PropertyType, editorBaseType);
			}
			return obj;
		}

		/// <summary>Returns a type using its name.</summary>
		/// <returns>A <see cref="T:System.Type" /> that matches the given type name, or null if a match cannot be found.</returns>
		/// <param name="typeName">The assembly-qualified name of the type to retrieve. </param>
		// Token: 0x06000E8C RID: 3724 RVA: 0x00035524 File Offset: 0x00033724
		protected Type GetTypeFromName(string typeName)
		{
			if (typeName == null || this.ComponentType == null || typeName.Trim().Length == 0)
			{
				return null;
			}
			Type type = Type.GetType(typeName);
			if (type == null)
			{
				int num = typeName.IndexOf(",");
				if (num != -1)
				{
					typeName = typeName.Substring(0, num);
				}
				type = this.ComponentType.Assembly.GetType(typeName);
			}
			return type;
		}

		// Token: 0x04000417 RID: 1047
		private TypeConverter converter;

		// Token: 0x04000418 RID: 1048
		private Hashtable notifiers;
	}
}
