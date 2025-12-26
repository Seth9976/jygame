using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a return value statement.</summary>
	// Token: 0x0200004E RID: 78
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Serializable]
	public class CodeMethodReturnStatement : CodeStatement
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeMethodReturnStatement" /> class.</summary>
		// Token: 0x06000290 RID: 656 RVA: 0x00002CA6 File Offset: 0x00000EA6
		public CodeMethodReturnStatement()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeMethodReturnStatement" /> class using the specified expression.</summary>
		/// <param name="expression">A <see cref="T:System.CodeDom.CodeExpression" /> that indicates the return value. </param>
		// Token: 0x06000291 RID: 657 RVA: 0x00003DD5 File Offset: 0x00001FD5
		public CodeMethodReturnStatement(CodeExpression expression)
		{
			this.expression = expression;
		}

		/// <summary>Gets or sets the return value.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeExpression" /> that indicates the value to return for the return statement, or null if the statement is part of a subroutine.</returns>
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00003DE4 File Offset: 0x00001FE4
		// (set) Token: 0x06000293 RID: 659 RVA: 0x00003DEC File Offset: 0x00001FEC
		public CodeExpression Expression
		{
			get
			{
				return this.expression;
			}
			set
			{
				this.expression = value;
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00003DF5 File Offset: 0x00001FF5
		internal override void Accept(ICodeDomVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Token: 0x040000CE RID: 206
		private CodeExpression expression;
	}
}
