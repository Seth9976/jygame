using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a parameter declaration for a method, property, or constructor.</summary>
	// Token: 0x02000056 RID: 86
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Serializable]
	public class CodeParameterDeclarationExpression : CodeExpression
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" /> class.</summary>
		// Token: 0x060002E5 RID: 741 RVA: 0x00002AA4 File Offset: 0x00000CA4
		public CodeParameterDeclarationExpression()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" /> class using the specified parameter type and name.</summary>
		/// <param name="type">A <see cref="T:System.CodeDom.CodeTypeReference" /> that indicates the type of the parameter to declare. </param>
		/// <param name="name">The name of the parameter to declare. </param>
		// Token: 0x060002E6 RID: 742 RVA: 0x000041C8 File Offset: 0x000023C8
		public CodeParameterDeclarationExpression(CodeTypeReference type, string name)
		{
			this.type = type;
			this.name = name;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" /> class using the specified parameter type and name.</summary>
		/// <param name="type">The name of the type of the parameter to declare. </param>
		/// <param name="name">The name of the parameter to declare. </param>
		// Token: 0x060002E7 RID: 743 RVA: 0x000041DE File Offset: 0x000023DE
		public CodeParameterDeclarationExpression(string type, string name)
		{
			this.type = new CodeTypeReference(type);
			this.name = name;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeParameterDeclarationExpression" /> class using the specified parameter type and name.</summary>
		/// <param name="type">The data type of the parameter to declare. </param>
		/// <param name="name">The name of the parameter to declare. </param>
		// Token: 0x060002E8 RID: 744 RVA: 0x000041F9 File Offset: 0x000023F9
		public CodeParameterDeclarationExpression(Type type, string name)
		{
			this.type = new CodeTypeReference(type);
			this.name = name;
		}

		/// <summary>Gets or sets the custom attributes for the parameter declaration.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeAttributeDeclarationCollection" /> that indicates the custom attributes.</returns>
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00004214 File Offset: 0x00002414
		// (set) Token: 0x060002EA RID: 746 RVA: 0x00004232 File Offset: 0x00002432
		public CodeAttributeDeclarationCollection CustomAttributes
		{
			get
			{
				if (this.customAttributes == null)
				{
					this.customAttributes = new CodeAttributeDeclarationCollection();
				}
				return this.customAttributes;
			}
			set
			{
				this.customAttributes = value;
			}
		}

		/// <summary>Gets or sets the direction of the field.</summary>
		/// <returns>A <see cref="T:System.CodeDom.FieldDirection" /> that indicates the direction of the field.</returns>
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0000423B File Offset: 0x0000243B
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00004243 File Offset: 0x00002443
		public FieldDirection Direction
		{
			get
			{
				return this.direction;
			}
			set
			{
				this.direction = value;
			}
		}

		/// <summary>Gets or sets the name of the parameter.</summary>
		/// <returns>The name of the parameter.</returns>
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000424C File Offset: 0x0000244C
		// (set) Token: 0x060002EE RID: 750 RVA: 0x00004265 File Offset: 0x00002465
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
			}
		}

		/// <summary>Gets or sets the type of the parameter.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeTypeReference" /> that indicates the data type of the parameter.</returns>
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002EF RID: 751 RVA: 0x0000426E File Offset: 0x0000246E
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x00004291 File Offset: 0x00002491
		public CodeTypeReference Type
		{
			get
			{
				if (this.type == null)
				{
					this.type = new CodeTypeReference(string.Empty);
				}
				return this.type;
			}
			set
			{
				this.type = value;
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000429A File Offset: 0x0000249A
		internal override void Accept(ICodeDomVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Token: 0x040000DF RID: 223
		private CodeAttributeDeclarationCollection customAttributes;

		// Token: 0x040000E0 RID: 224
		private FieldDirection direction;

		// Token: 0x040000E1 RID: 225
		private string name;

		// Token: 0x040000E2 RID: 226
		private CodeTypeReference type;
	}
}
