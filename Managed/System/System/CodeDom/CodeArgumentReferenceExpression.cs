using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a reference to the value of an argument passed to a method.</summary>
	// Token: 0x02000021 RID: 33
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[Serializable]
	public class CodeArgumentReferenceExpression : CodeExpression
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeArgumentReferenceExpression" /> class.</summary>
		// Token: 0x0600012C RID: 300 RVA: 0x00002AA4 File Offset: 0x00000CA4
		public CodeArgumentReferenceExpression()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeArgumentReferenceExpression" /> class using the specified parameter name.</summary>
		/// <param name="parameterName">The name of the parameter to reference. </param>
		// Token: 0x0600012D RID: 301 RVA: 0x00002AAC File Offset: 0x00000CAC
		public CodeArgumentReferenceExpression(string name)
		{
			this.parameterName = name;
		}

		/// <summary>Gets or sets the name of the parameter this expression references.</summary>
		/// <returns>The name of the parameter to reference.</returns>
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00002ABB File Offset: 0x00000CBB
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00002AD4 File Offset: 0x00000CD4
		public string ParameterName
		{
			get
			{
				if (this.parameterName == null)
				{
					return string.Empty;
				}
				return this.parameterName;
			}
			set
			{
				this.parameterName = value;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002ADD File Offset: 0x00000CDD
		internal override void Accept(ICodeDomVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Token: 0x0400005F RID: 95
		private string parameterName;
	}
}
