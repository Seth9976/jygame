using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the editor to use to change a property. This class cannot be inherited.</summary>
	// Token: 0x02000147 RID: 327
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public sealed class EditorAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EditorAttribute" /> class with the default editor, which is no editor.</summary>
		// Token: 0x06000BFA RID: 3066 RVA: 0x0000A612 File Offset: 0x00008812
		public EditorAttribute()
		{
			this.name = string.Empty;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EditorAttribute" /> class with the type name and base type name of the editor.</summary>
		/// <param name="typeName">The fully qualified type name of the editor. </param>
		/// <param name="baseTypeName">The fully qualified type name of the base class or interface to use as a lookup key for the editor. This class must be or derive from <see cref="T:System.Drawing.Design.UITypeEditor" />. </param>
		// Token: 0x06000BFB RID: 3067 RVA: 0x0000A625 File Offset: 0x00008825
		public EditorAttribute(string typeName, string baseTypeName)
		{
			this.name = typeName;
			this.basename = baseTypeName;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EditorAttribute" /> class with the type name and the base type.</summary>
		/// <param name="typeName">The fully qualified type name of the editor. </param>
		/// <param name="baseType">The <see cref="T:System.Type" /> of the base class or interface to use as a lookup key for the editor. This class must be or derive from <see cref="T:System.Drawing.Design.UITypeEditor" />. </param>
		// Token: 0x06000BFC RID: 3068 RVA: 0x0000A63B File Offset: 0x0000883B
		public EditorAttribute(string typeName, Type baseType)
			: this(typeName, baseType.AssemblyQualifiedName)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EditorAttribute" /> class with the type and the base type.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type of the editor. </param>
		/// <param name="baseType">The <see cref="T:System.Type" /> of the base class or interface to use as a lookup key for the editor. This class must be or derive from <see cref="T:System.Drawing.Design.UITypeEditor" />. </param>
		// Token: 0x06000BFD RID: 3069 RVA: 0x0000A64A File Offset: 0x0000884A
		public EditorAttribute(Type type, Type baseType)
			: this(type.AssemblyQualifiedName, baseType.AssemblyQualifiedName)
		{
		}

		/// <summary>Gets the name of the base class or interface serving as a lookup key for this editor.</summary>
		/// <returns>The name of the base class or interface serving as a lookup key for this editor.</returns>
		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x0000A65E File Offset: 0x0000885E
		public string EditorBaseTypeName
		{
			get
			{
				return this.basename;
			}
		}

		/// <summary>Gets the name of the editor class in the <see cref="P:System.Type.AssemblyQualifiedName" /> format.</summary>
		/// <returns>The name of the editor class in the <see cref="P:System.Type.AssemblyQualifiedName" /> format.</returns>
		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x0000A666 File Offset: 0x00008866
		public string EditorTypeName
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets a unique ID for this attribute type.</summary>
		/// <returns>A unique ID for this attribute type.</returns>
		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x00009CFB File Offset: 0x00007EFB
		public override object TypeId
		{
			get
			{
				return base.GetType();
			}
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.EditorAttribute" />.</summary>
		/// <returns>true if the value of the given object is equal to that of the current object; otherwise, false.</returns>
		/// <param name="obj">The object to test the value equality of. </param>
		// Token: 0x06000C01 RID: 3073 RVA: 0x000315B0 File Offset: 0x0002F7B0
		public override bool Equals(object obj)
		{
			return obj is EditorAttribute && ((EditorAttribute)obj).EditorBaseTypeName.Equals(this.basename) && ((EditorAttribute)obj).EditorTypeName.Equals(this.name);
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x0000A66E File Offset: 0x0000886E
		public override int GetHashCode()
		{
			return (this.name + this.basename).GetHashCode();
		}

		// Token: 0x04000370 RID: 880
		private string name;

		// Token: 0x04000371 RID: 881
		private string basename;
	}
}
