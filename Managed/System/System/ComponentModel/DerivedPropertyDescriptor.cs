using System;
using System.Reflection;

namespace System.ComponentModel
{
	// Token: 0x020000F6 RID: 246
	internal class DerivedPropertyDescriptor : PropertyDescriptor
	{
		// Token: 0x06000A09 RID: 2569 RVA: 0x000095EE File Offset: 0x000077EE
		protected DerivedPropertyDescriptor(string name, Attribute[] attrs)
			: base(name, attrs)
		{
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x000095F8 File Offset: 0x000077F8
		public DerivedPropertyDescriptor(string name, Attribute[] attrs, int dummy)
			: this(name, attrs)
		{
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00009602 File Offset: 0x00007802
		public void SetReadOnly(bool value)
		{
			this.readOnly = value;
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0000960B File Offset: 0x0000780B
		public void SetComponentType(Type type)
		{
			this.componentType = type;
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00009614 File Offset: 0x00007814
		public void SetPropertyType(Type type)
		{
			this.propertyType = type;
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0000961D File Offset: 0x0000781D
		public override object GetValue(object component)
		{
			if (this.prop == null)
			{
				this.prop = this.componentType.GetProperty(this.Name);
			}
			return this.prop.GetValue(component, null);
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x0003028C File Offset: 0x0002E48C
		public override void SetValue(object component, object value)
		{
			if (this.prop == null)
			{
				this.prop = this.componentType.GetProperty(this.Name);
			}
			this.prop.SetValue(component, value, null);
			this.OnValueChanged(component, new PropertyChangedEventArgs(this.Name));
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00002664 File Offset: 0x00000864
		[global::System.MonoTODO]
		public override void ResetValue(object component)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00002664 File Offset: 0x00000864
		[global::System.MonoTODO]
		public override bool CanResetValue(object component)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00002664 File Offset: 0x00000864
		[global::System.MonoTODO]
		public override bool ShouldSerializeValue(object component)
		{
			throw new NotImplementedException();
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0000964E File Offset: 0x0000784E
		public override Type ComponentType
		{
			get
			{
				return this.componentType;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00009656 File Offset: 0x00007856
		public override bool IsReadOnly
		{
			get
			{
				return this.readOnly;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x0000965E File Offset: 0x0000785E
		public override Type PropertyType
		{
			get
			{
				return this.propertyType;
			}
		}

		// Token: 0x040002B4 RID: 692
		private bool readOnly;

		// Token: 0x040002B5 RID: 693
		private Type componentType;

		// Token: 0x040002B6 RID: 694
		private Type propertyType;

		// Token: 0x040002B7 RID: 695
		private PropertyInfo prop;
	}
}
