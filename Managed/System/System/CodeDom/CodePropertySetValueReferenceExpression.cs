using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents the value argument of a property set method call within a property set method.</summary>
	// Token: 0x02000059 RID: 89
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[Serializable]
	public class CodePropertySetValueReferenceExpression : CodeExpression
	{
		// Token: 0x060002FF RID: 767 RVA: 0x0000431E File Offset: 0x0000251E
		internal override void Accept(ICodeDomVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
