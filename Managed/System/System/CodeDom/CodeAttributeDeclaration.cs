using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents an attribute declaration.</summary>
	// Token: 0x02000029 RID: 41
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Serializable]
	public class CodeAttributeDeclaration
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeAttributeDeclaration" /> class.</summary>
		// Token: 0x06000179 RID: 377 RVA: 0x000021C3 File Offset: 0x000003C3
		public CodeAttributeDeclaration()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeAttributeDeclaration" /> class using the specified name.</summary>
		/// <param name="name">The name of the attribute. </param>
		// Token: 0x0600017A RID: 378 RVA: 0x00002E89 File Offset: 0x00001089
		public CodeAttributeDeclaration(string name)
		{
			this.Name = name;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeAttributeDeclaration" /> class using the specified name and arguments.</summary>
		/// <param name="name">The name of the attribute. </param>
		/// <param name="arguments">An array of type <see cref="T:System.CodeDom.CodeAttributeArgument" />  that contains the arguments for the attribute. </param>
		// Token: 0x0600017B RID: 379 RVA: 0x00002E98 File Offset: 0x00001098
		public CodeAttributeDeclaration(string name, params CodeAttributeArgument[] arguments)
		{
			this.Name = name;
			this.Arguments.AddRange(arguments);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeAttributeDeclaration" /> class using the specified code type reference.</summary>
		/// <param name="attributeType">The <see cref="T:System.CodeDom.CodeTypeReference" /> that identifies the attribute.</param>
		// Token: 0x0600017C RID: 380 RVA: 0x00002EB3 File Offset: 0x000010B3
		public CodeAttributeDeclaration(CodeTypeReference attributeType)
		{
			this.attribute = attributeType;
			if (attributeType != null)
			{
				this.name = attributeType.BaseType;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeAttributeDeclaration" /> class using the specified code type reference and arguments.</summary>
		/// <param name="attributeType">The <see cref="T:System.CodeDom.CodeTypeReference" /> that identifies the attribute.</param>
		/// <param name="arguments">An array of type <see cref="T:System.CodeDom.CodeAttributeArgument" /> that contains the arguments for the attribute.</param>
		// Token: 0x0600017D RID: 381 RVA: 0x00002ED4 File Offset: 0x000010D4
		public CodeAttributeDeclaration(CodeTypeReference attributeType, params CodeAttributeArgument[] arguments)
		{
			this.attribute = attributeType;
			if (attributeType != null)
			{
				this.name = attributeType.BaseType;
			}
			this.Arguments.AddRange(arguments);
		}

		/// <summary>Gets the arguments for the attribute.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeAttributeArgumentCollection" /> that contains the arguments for the attribute.</returns>
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00002F01 File Offset: 0x00001101
		public CodeAttributeArgumentCollection Arguments
		{
			get
			{
				if (this.arguments == null)
				{
					this.arguments = new CodeAttributeArgumentCollection();
				}
				return this.arguments;
			}
		}

		/// <summary>Gets or sets the name of the attribute being declared.</summary>
		/// <returns>The name of the attribute.</returns>
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00002F1F File Offset: 0x0000111F
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002F38 File Offset: 0x00001138
		public string Name
		{
			get
			{
				if (this.name == null)
				{
					return string.Empty;
				}
				return this.name;
			}
			set
			{
				this.name = value;
				this.attribute = new CodeTypeReference(this.name);
			}
		}

		/// <summary>Gets the code type reference for the code attribute declaration.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeTypeReference" /> that identifies the <see cref="T:System.CodeDom.CodeAttributeDeclaration" />.</returns>
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00002F52 File Offset: 0x00001152
		public CodeTypeReference AttributeType
		{
			get
			{
				return this.attribute;
			}
		}

		// Token: 0x0400006C RID: 108
		private string name;

		// Token: 0x0400006D RID: 109
		private CodeAttributeArgumentCollection arguments;

		// Token: 0x0400006E RID: 110
		private CodeTypeReference attribute;
	}
}
