using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a declaration for an instance constructor of a type.</summary>
	// Token: 0x02000036 RID: 54
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[Serializable]
	public class CodeConstructor : CodeMemberMethod
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeConstructor" /> class.</summary>
		// Token: 0x060001DD RID: 477 RVA: 0x000033B1 File Offset: 0x000015B1
		public CodeConstructor()
		{
			base.Name = ".ctor";
		}

		/// <summary>Gets the collection of base constructor arguments.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeExpressionCollection" /> that contains the base constructor arguments.</returns>
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001DE RID: 478 RVA: 0x000033C4 File Offset: 0x000015C4
		public CodeExpressionCollection BaseConstructorArgs
		{
			get
			{
				if (this.baseConstructorArgs == null)
				{
					this.baseConstructorArgs = new CodeExpressionCollection();
				}
				return this.baseConstructorArgs;
			}
		}

		/// <summary>Gets the collection of chained constructor arguments.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeExpressionCollection" /> that contains the chained constructor arguments.</returns>
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001DF RID: 479 RVA: 0x000033E2 File Offset: 0x000015E2
		public CodeExpressionCollection ChainedConstructorArgs
		{
			get
			{
				if (this.chainedConstructorArgs == null)
				{
					this.chainedConstructorArgs = new CodeExpressionCollection();
				}
				return this.chainedConstructorArgs;
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00003400 File Offset: 0x00001600
		internal override void Accept(ICodeDomVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Token: 0x04000097 RID: 151
		private CodeExpressionCollection baseConstructorArgs;

		// Token: 0x04000098 RID: 152
		private CodeExpressionCollection chainedConstructorArgs;
	}
}
