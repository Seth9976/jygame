using System;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Indicates the base serializer to use for a root designer object. This class cannot be inherited.</summary>
	// Token: 0x0200013C RID: 316
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	[Obsolete("Use DesignerSerializerAttribute instead")]
	public sealed class RootDesignerSerializerAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.Serialization.RootDesignerSerializerAttribute" /> class using the specified attributes.</summary>
		/// <param name="serializerTypeName">The fully qualified name of the data type of the serializer. </param>
		/// <param name="baseSerializerTypeName">The name of the base type of the serializer. A class can include multiple serializers as they all have different base types. </param>
		/// <param name="reloadable">true if this serializer supports dynamic reloading of the document; otherwise, false. </param>
		// Token: 0x06000BC1 RID: 3009 RVA: 0x0000A36F File Offset: 0x0000856F
		public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable)
		{
			this.serializer = serializerTypeName;
			this.baseserializer = baseSerializerTypeName;
			this.reload = reloadable;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.Serialization.RootDesignerSerializerAttribute" /> class using the specified attributes.</summary>
		/// <param name="serializerTypeName">The fully qualified name of the data type of the serializer. </param>
		/// <param name="baseSerializerType">The name of the base type of the serializer. A class can include multiple serializers, as they all have different base types. </param>
		/// <param name="reloadable">true if this serializer supports dynamic reloading of the document; otherwise, false. </param>
		// Token: 0x06000BC2 RID: 3010 RVA: 0x0000A38C File Offset: 0x0000858C
		public RootDesignerSerializerAttribute(string serializerTypeName, Type baseSerializerType, bool reloadable)
			: this(serializerTypeName, baseSerializerType.AssemblyQualifiedName, reloadable)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.Serialization.RootDesignerSerializerAttribute" /> class using the specified attributes.</summary>
		/// <param name="serializerType">The data type of the serializer. </param>
		/// <param name="baseSerializerType">The base type of the serializer. A class can include multiple serializers as they all have different base types. </param>
		/// <param name="reloadable">true if this serializer supports dynamic reloading of the document; otherwise, false. </param>
		// Token: 0x06000BC3 RID: 3011 RVA: 0x0000A39C File Offset: 0x0000859C
		public RootDesignerSerializerAttribute(Type serializerType, Type baseSerializerType, bool reloadable)
			: this(serializerType.AssemblyQualifiedName, baseSerializerType.AssemblyQualifiedName, reloadable)
		{
		}

		/// <summary>Gets a value indicating whether the root serializer supports reloading of the design document without first disposing the designer host.</summary>
		/// <returns>true if the root serializer supports reloading; otherwise, false.</returns>
		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x0000A3B1 File Offset: 0x000085B1
		public bool Reloadable
		{
			get
			{
				return this.reload;
			}
		}

		/// <summary>Gets the fully qualified type name of the base type of the serializer.</summary>
		/// <returns>The name of the base type of the serializer.</returns>
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x0000A3B9 File Offset: 0x000085B9
		public string SerializerBaseTypeName
		{
			get
			{
				return this.baseserializer;
			}
		}

		/// <summary>Gets the fully qualified type name of the serializer.</summary>
		/// <returns>The name of the type of the serializer.</returns>
		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x0000A3C1 File Offset: 0x000085C1
		public string SerializerTypeName
		{
			get
			{
				return this.serializer;
			}
		}

		/// <summary>Gets a unique ID for this attribute type.</summary>
		/// <returns>An object containing a unique ID for this attribute type.</returns>
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x0000A3C9 File Offset: 0x000085C9
		public override object TypeId
		{
			get
			{
				return this.ToString() + this.baseserializer;
			}
		}

		// Token: 0x0400031E RID: 798
		private string serializer;

		// Token: 0x0400031F RID: 799
		private string baseserializer;

		// Token: 0x04000320 RID: 800
		private bool reload;
	}
}
