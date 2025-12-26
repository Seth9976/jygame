using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a reference to the base class.</summary>
	// Token: 0x0200002A RID: 42
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Serializable]
	public class CodeBaseReferenceExpression : CodeExpression
	{
		// Token: 0x06000183 RID: 387 RVA: 0x00002F5A File Offset: 0x0000115A
		internal override void Accept(ICodeDomVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
