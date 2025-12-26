using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a reference to the current local class instance.</summary>
	// Token: 0x02000063 RID: 99
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Serializable]
	public class CodeThisReferenceExpression : CodeExpression
	{
		// Token: 0x06000336 RID: 822 RVA: 0x0000455E File Offset: 0x0000275E
		internal override void Accept(ICodeDomVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
