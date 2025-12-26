using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a delegate declaration.</summary>
	// Token: 0x02000069 RID: 105
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[Serializable]
	public class CodeTypeDelegate : CodeTypeDeclaration
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeTypeDelegate" /> class.</summary>
		// Token: 0x06000367 RID: 871 RVA: 0x000048AB File Offset: 0x00002AAB
		public CodeTypeDelegate()
		{
			base.BaseTypes.Add(new CodeTypeReference("System.Delegate"));
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeTypeDelegate" /> class.</summary>
		/// <param name="name">The name of the delegate. </param>
		// Token: 0x06000368 RID: 872 RVA: 0x000048C9 File Offset: 0x00002AC9
		public CodeTypeDelegate(string name)
			: this()
		{
			base.Name = name;
		}

		/// <summary>Gets the parameters of the delegate.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeParameterDeclarationExpressionCollection" /> that indicates the parameters of the delegate.</returns>
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000369 RID: 873 RVA: 0x000048D8 File Offset: 0x00002AD8
		public CodeParameterDeclarationExpressionCollection Parameters
		{
			get
			{
				if (this.parameters == null)
				{
					this.parameters = new CodeParameterDeclarationExpressionCollection();
				}
				return this.parameters;
			}
		}

		/// <summary>Gets or sets the return type of the delegate.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeTypeReference" /> that indicates the return type of the delegate.</returns>
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600036A RID: 874 RVA: 0x000048F6 File Offset: 0x00002AF6
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00004919 File Offset: 0x00002B19
		public CodeTypeReference ReturnType
		{
			get
			{
				if (this.returnType == null)
				{
					this.returnType = new CodeTypeReference(string.Empty);
				}
				return this.returnType;
			}
			set
			{
				this.returnType = value;
			}
		}

		// Token: 0x04000104 RID: 260
		private CodeParameterDeclarationExpressionCollection parameters;

		// Token: 0x04000105 RID: 261
		private CodeTypeReference returnType;
	}
}
