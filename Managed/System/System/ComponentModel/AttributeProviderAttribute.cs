using System;

namespace System.ComponentModel
{
	/// <summary>Enables attribute redirection. This class cannot be inherited.</summary>
	// Token: 0x020000CE RID: 206
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	public class AttributeProviderAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AttributeProviderAttribute" /> class with the given type.</summary>
		/// <param name="type">The type to specify.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> is null.</exception>
		// Token: 0x060008C3 RID: 2243 RVA: 0x0000850A File Offset: 0x0000670A
		public AttributeProviderAttribute(Type type)
		{
			this.type_name = type.AssemblyQualifiedName;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AttributeProviderAttribute" /> class with the given type name and property name.</summary>
		/// <param name="typeName">The name of the type to specify.</param>
		/// <param name="propertyName">The name of the property for which attributes will be retrieved.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="typeName" /> is null.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="propertyName" /> is null.</exception>
		// Token: 0x060008C4 RID: 2244 RVA: 0x0000851E File Offset: 0x0000671E
		public AttributeProviderAttribute(string typeName, string propertyName)
		{
			this.type_name = typeName;
			this.property_name = propertyName;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AttributeProviderAttribute" /> class with the given type name.</summary>
		/// <param name="typeName">The name of the type to specify.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="typeName" /> is null.</exception>
		// Token: 0x060008C5 RID: 2245 RVA: 0x00008534 File Offset: 0x00006734
		public AttributeProviderAttribute(string typeName)
		{
			this.type_name = typeName;
		}

		/// <summary>Gets the name of the property for which attributes will be retrieved.</summary>
		/// <returns>The name of the property for which attributes will be retrieved.</returns>
		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00008543 File Offset: 0x00006743
		public string PropertyName
		{
			get
			{
				return this.property_name;
			}
		}

		/// <summary>Gets the assembly qualified type name passed into the constructor.</summary>
		/// <returns>The assembly qualified name of the type specified in the constructor.</returns>
		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x0000854B File Offset: 0x0000674B
		public string TypeName
		{
			get
			{
				return this.type_name;
			}
		}

		// Token: 0x04000252 RID: 594
		private string type_name;

		// Token: 0x04000253 RID: 595
		private string property_name;
	}
}
