using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a reference to a default value.</summary>
	// Token: 0x02000037 RID: 55
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Serializable]
	public class CodeDefaultValueExpression : CodeExpression
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeDefaultValueExpression" /> class. </summary>
		// Token: 0x060001E1 RID: 481 RVA: 0x00002AA4 File Offset: 0x00000CA4
		public CodeDefaultValueExpression()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeDefaultValueExpression" /> class using the specified code type reference.</summary>
		/// <param name="type">A <see cref="T:System.CodeDom.CodeTypeReference" /> that specifies the reference to a value type.</param>
		// Token: 0x060001E2 RID: 482 RVA: 0x00003409 File Offset: 0x00001609
		public CodeDefaultValueExpression(CodeTypeReference type)
		{
			this.type = type;
		}

		/// <summary>Gets or sets the data type reference for a default value.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeTypeReference" /> object representing a data type that has a default value.</returns>
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00003418 File Offset: 0x00001618
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x0000343B File Offset: 0x0000163B
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

		// Token: 0x060001E5 RID: 485 RVA: 0x00003444 File Offset: 0x00001644
		internal override void Accept(ICodeDomVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Token: 0x04000099 RID: 153
		private CodeTypeReference type;
	}
}
