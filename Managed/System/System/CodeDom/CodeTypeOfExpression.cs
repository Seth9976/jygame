using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a typeof expression, an expression that returns a <see cref="T:System.Type" /> for a specified type name.</summary>
	// Token: 0x0200006C RID: 108
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Serializable]
	public class CodeTypeOfExpression : CodeExpression
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeTypeOfExpression" /> class.</summary>
		// Token: 0x06000385 RID: 901 RVA: 0x00002AA4 File Offset: 0x00000CA4
		public CodeTypeOfExpression()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeTypeOfExpression" /> class.</summary>
		/// <param name="type">A <see cref="T:System.CodeDom.CodeTypeReference" /> that indicates the data type for the typeof expression. </param>
		// Token: 0x06000386 RID: 902 RVA: 0x00004A2B File Offset: 0x00002C2B
		public CodeTypeOfExpression(CodeTypeReference type)
		{
			this.type = type;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeTypeOfExpression" /> class using the specified type.</summary>
		/// <param name="type">The name of the data type for the typeof expression. </param>
		// Token: 0x06000387 RID: 903 RVA: 0x00004A3A File Offset: 0x00002C3A
		public CodeTypeOfExpression(string type)
		{
			this.type = new CodeTypeReference(type);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeTypeOfExpression" /> class using the specified type.</summary>
		/// <param name="type">The data type of the data type of the typeof expression. </param>
		// Token: 0x06000388 RID: 904 RVA: 0x00004A4E File Offset: 0x00002C4E
		public CodeTypeOfExpression(Type type)
		{
			this.type = new CodeTypeReference(type);
		}

		/// <summary>Gets or sets the data type referenced by the typeof expression.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeTypeReference" /> that indicates the data type referenced by the typeof expression. This property will never return null, and defaults to the <see cref="T:System.Void" /> type.</returns>
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00004A62 File Offset: 0x00002C62
		// (set) Token: 0x0600038A RID: 906 RVA: 0x00004A85 File Offset: 0x00002C85
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

		// Token: 0x0600038B RID: 907 RVA: 0x00004A8E File Offset: 0x00002C8E
		internal override void Accept(ICodeDomVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Token: 0x0400010D RID: 269
		private CodeTypeReference type;
	}
}
