using System;
using System.ComponentModel.Design;

namespace System.ComponentModel
{
	/// <summary>Specifies the class used to implement design-time services for a component.</summary>
	// Token: 0x0200010A RID: 266
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	public sealed class DesignerAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DesignerAttribute" /> class using the name of the type that provides design-time services.</summary>
		/// <param name="designerTypeName">The concatenation of the fully qualified name of the type that provides design-time services for the component this attribute is bound to, and the name of the assembly this type resides in. </param>
		// Token: 0x06000A9F RID: 2719 RVA: 0x00009BF0 File Offset: 0x00007DF0
		public DesignerAttribute(string designerTypeName)
		{
			if (designerTypeName == null)
			{
				throw new NullReferenceException();
			}
			this.name = designerTypeName;
			this.basetypename = typeof(global::System.ComponentModel.Design.IDesigner).FullName;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DesignerAttribute" /> class using the type that provides design-time services.</summary>
		/// <param name="designerType">A <see cref="T:System.Type" /> that represents the class that provides design-time services for the component this attribute is bound to. </param>
		// Token: 0x06000AA0 RID: 2720 RVA: 0x00009C20 File Offset: 0x00007E20
		public DesignerAttribute(Type designerType)
			: this(designerType.AssemblyQualifiedName)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DesignerAttribute" /> class, using the name of the designer class and the base class for the designer.</summary>
		/// <param name="designerTypeName">The concatenation of the fully qualified name of the type that provides design-time services for the component this attribute is bound to, and the name of the assembly this type resides in. </param>
		/// <param name="designerBaseType">A <see cref="T:System.Type" /> that represents the base class to associate with the <paramref name="designerTypeName" />. </param>
		// Token: 0x06000AA1 RID: 2721 RVA: 0x00009C2E File Offset: 0x00007E2E
		public DesignerAttribute(string designerTypeName, Type designerBaseType)
			: this(designerTypeName, designerBaseType.AssemblyQualifiedName)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DesignerAttribute" /> class using the types of the designer and designer base class.</summary>
		/// <param name="designerType">A <see cref="T:System.Type" /> that represents the class that provides design-time services for the component this attribute is bound to. </param>
		/// <param name="designerBaseType">A <see cref="T:System.Type" /> that represents the base class to associate with the <paramref name="designerType" />. </param>
		// Token: 0x06000AA2 RID: 2722 RVA: 0x00009C3D File Offset: 0x00007E3D
		public DesignerAttribute(Type designerType, Type designerBaseType)
			: this(designerType.AssemblyQualifiedName, designerBaseType.AssemblyQualifiedName)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DesignerAttribute" /> class using the designer type and the base class for the designer.</summary>
		/// <param name="designerTypeName">The concatenation of the fully qualified name of the type that provides design-time services for the component this attribute is bound to, and the name of the assembly this type resides in. </param>
		/// <param name="designerBaseTypeName">The fully qualified name of the base class to associate with the designer class. </param>
		// Token: 0x06000AA3 RID: 2723 RVA: 0x00009C51 File Offset: 0x00007E51
		public DesignerAttribute(string designerTypeName, string designerBaseTypeName)
		{
			if (designerTypeName == null)
			{
				throw new NullReferenceException();
			}
			this.name = designerTypeName;
			this.basetypename = designerBaseTypeName;
		}

		/// <summary>Gets the name of the base type of this designer.</summary>
		/// <returns>The name of the base type of this designer.</returns>
		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x00009C73 File Offset: 0x00007E73
		public string DesignerBaseTypeName
		{
			get
			{
				return this.basetypename;
			}
		}

		/// <summary>Gets the name of the designer type associated with this designer attribute.</summary>
		/// <returns>The name of the designer type associated with this designer attribute.</returns>
		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x00009C7B File Offset: 0x00007E7B
		public string DesignerTypeName
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets a unique ID for this attribute type.</summary>
		/// <returns>A unique ID for this attribute type.</returns>
		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x000306E8 File Offset: 0x0002E8E8
		public override object TypeId
		{
			get
			{
				string text = this.basetypename;
				int num = text.IndexOf(',');
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				return base.GetType().ToString() + text;
			}
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.DesignerAttribute" />.</summary>
		/// <returns>true if the value of the given object is equal to that of the current; otherwise, false.</returns>
		/// <param name="obj">The object to test the value equality of. </param>
		// Token: 0x06000AA7 RID: 2727 RVA: 0x00030728 File Offset: 0x0002E928
		public override bool Equals(object obj)
		{
			return obj is DesignerAttribute && ((DesignerAttribute)obj).DesignerBaseTypeName.Equals(this.basetypename) && ((DesignerAttribute)obj).DesignerTypeName.Equals(this.name);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00009C83 File Offset: 0x00007E83
		public override int GetHashCode()
		{
			return (this.name + this.basetypename).GetHashCode();
		}

		// Token: 0x040002DB RID: 731
		private string name;

		// Token: 0x040002DC RID: 732
		private string basetypename;
	}
}
