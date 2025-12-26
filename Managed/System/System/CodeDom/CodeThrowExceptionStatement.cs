using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a statement that throws an exception.</summary>
	// Token: 0x02000064 RID: 100
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Serializable]
	public class CodeThrowExceptionStatement : CodeStatement
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeThrowExceptionStatement" /> class.</summary>
		// Token: 0x06000337 RID: 823 RVA: 0x00002CA6 File Offset: 0x00000EA6
		public CodeThrowExceptionStatement()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeThrowExceptionStatement" /> class with the specified exception type instance.</summary>
		/// <param name="toThrow">A <see cref="T:System.CodeDom.CodeExpression" /> that indicates the exception to throw. </param>
		// Token: 0x06000338 RID: 824 RVA: 0x00004567 File Offset: 0x00002767
		public CodeThrowExceptionStatement(CodeExpression toThrow)
		{
			this.toThrow = toThrow;
		}

		/// <summary>Gets or sets the exception to throw.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeExpression" /> representing an instance of the exception to throw.</returns>
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000339 RID: 825 RVA: 0x00004576 File Offset: 0x00002776
		// (set) Token: 0x0600033A RID: 826 RVA: 0x0000457E File Offset: 0x0000277E
		public CodeExpression ToThrow
		{
			get
			{
				return this.toThrow;
			}
			set
			{
				this.toThrow = value;
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00004587 File Offset: 0x00002787
		internal override void Accept(ICodeDomVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Token: 0x040000F6 RID: 246
		private CodeExpression toThrow;
	}
}
