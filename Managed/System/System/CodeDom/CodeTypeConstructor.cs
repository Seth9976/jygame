using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a static constructor for a class.</summary>
	// Token: 0x02000066 RID: 102
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[Serializable]
	public class CodeTypeConstructor : CodeMemberMethod
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeTypeConstructor" /> class.</summary>
		// Token: 0x06000343 RID: 835 RVA: 0x0000463F File Offset: 0x0000283F
		public CodeTypeConstructor()
		{
			base.Name = ".cctor";
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00004652 File Offset: 0x00002852
		internal override void Accept(ICodeDomVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
