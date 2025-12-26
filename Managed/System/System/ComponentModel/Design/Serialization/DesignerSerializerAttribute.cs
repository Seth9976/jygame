using System;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Indicates a serializer for the serialization manager to use to serialize the values of the type this attribute is applied to. This class cannot be inherited.</summary>
	// Token: 0x02000130 RID: 304
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	public sealed class DesignerSerializerAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.Serialization.DesignerSerializerAttribute" /> class.</summary>
		/// <param name="serializerTypeName">The fully qualified name of the data type of the serializer. </param>
		/// <param name="baseSerializerTypeName">The fully qualified name of the base data type of the serializer. Multiple serializers can be supplied for a class as long as the serializers have different base types. </param>
		// Token: 0x06000B7E RID: 2942 RVA: 0x0000A0B3 File Offset: 0x000082B3
		public DesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName)
		{
			this.serializerTypeName = serializerTypeName;
			this.baseSerializerTypeName = baseSerializerTypeName;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.Serialization.DesignerSerializerAttribute" /> class.</summary>
		/// <param name="serializerTypeName">The fully qualified name of the data type of the serializer. </param>
		/// <param name="baseSerializerType">The base data type of the serializer. Multiple serializers can be supplied for a class as long as the serializers have different base types. </param>
		// Token: 0x06000B7F RID: 2943 RVA: 0x0000A0C9 File Offset: 0x000082C9
		public DesignerSerializerAttribute(string serializerTypeName, Type baseSerializerType)
			: this(serializerTypeName, baseSerializerType.AssemblyQualifiedName)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.Serialization.DesignerSerializerAttribute" /> class.</summary>
		/// <param name="serializerType">The data type of the serializer. </param>
		/// <param name="baseSerializerType">The base data type of the serializer. Multiple serializers can be supplied for a class as long as the serializers have different base types. </param>
		// Token: 0x06000B80 RID: 2944 RVA: 0x0000A0D8 File Offset: 0x000082D8
		public DesignerSerializerAttribute(Type serializerType, Type baseSerializerType)
			: this(serializerType.AssemblyQualifiedName, baseSerializerType.AssemblyQualifiedName)
		{
		}

		/// <summary>Gets the fully qualified type name of the serializer base type.</summary>
		/// <returns>The fully qualified type name of the serializer base type.</returns>
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x0000A0EC File Offset: 0x000082EC
		public string SerializerBaseTypeName
		{
			get
			{
				return this.baseSerializerTypeName;
			}
		}

		/// <summary>Gets the fully qualified type name of the serializer.</summary>
		/// <returns>The fully qualified type name of the serializer.</returns>
		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x0000A0F4 File Offset: 0x000082F4
		public string SerializerTypeName
		{
			get
			{
				return this.serializerTypeName;
			}
		}

		/// <summary>Indicates a unique ID for this attribute type.</summary>
		/// <returns>A unique ID for this attribute type.</returns>
		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x0000A0FC File Offset: 0x000082FC
		public override object TypeId
		{
			get
			{
				return this.ToString() + this.baseSerializerTypeName;
			}
		}

		// Token: 0x04000311 RID: 785
		private string serializerTypeName;

		// Token: 0x04000312 RID: 786
		private string baseSerializerTypeName;
	}
}
