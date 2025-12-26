using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a goto statement.</summary>
	// Token: 0x02000043 RID: 67
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[Serializable]
	public class CodeGotoStatement : CodeStatement
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeGotoStatement" /> class. </summary>
		// Token: 0x0600022E RID: 558 RVA: 0x00002CA6 File Offset: 0x00000EA6
		public CodeGotoStatement()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeGotoStatement" /> class using the specified label name.</summary>
		/// <param name="label">The name of the label at which to continue program execution. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="Label" /> is null.</exception>
		// Token: 0x0600022F RID: 559 RVA: 0x000036C2 File Offset: 0x000018C2
		public CodeGotoStatement(string label)
		{
			this.Label = label;
		}

		/// <summary>Gets or sets the name of the label at which to continue program execution.</summary>
		/// <returns>A string that indicates the name of the label at which to continue program execution.</returns>
		/// <exception cref="T:System.ArgumentNullException">The label cannot be set because<paramref name=" value" /> is null or an empty string.</exception>
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000230 RID: 560 RVA: 0x000036D1 File Offset: 0x000018D1
		// (set) Token: 0x06000231 RID: 561 RVA: 0x000036D9 File Offset: 0x000018D9
		public string Label
		{
			get
			{
				return this.label;
			}
			set
			{
				if (value == null || value.Length == 0)
				{
					throw new ArgumentNullException("value");
				}
				this.label = value;
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000036FE File Offset: 0x000018FE
		internal override void Accept(ICodeDomVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Token: 0x040000A6 RID: 166
		private string label;
	}
}
