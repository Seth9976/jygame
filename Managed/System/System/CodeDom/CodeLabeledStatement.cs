using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a labeled statement or a stand-alone label.</summary>
	// Token: 0x02000046 RID: 70
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[Serializable]
	public class CodeLabeledStatement : CodeStatement
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeLabeledStatement" /> class.</summary>
		// Token: 0x06000243 RID: 579 RVA: 0x00002CA6 File Offset: 0x00000EA6
		public CodeLabeledStatement()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeLabeledStatement" /> class using the specified label name.</summary>
		/// <param name="label">The name of the label. </param>
		// Token: 0x06000244 RID: 580 RVA: 0x000037DE File Offset: 0x000019DE
		public CodeLabeledStatement(string label)
		{
			this.label = label;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeLabeledStatement" /> class using the specified label name and statement.</summary>
		/// <param name="label">The name of the label. </param>
		/// <param name="statement">The <see cref="T:System.CodeDom.CodeStatement" /> to associate with the label. </param>
		// Token: 0x06000245 RID: 581 RVA: 0x000037ED File Offset: 0x000019ED
		public CodeLabeledStatement(string label, CodeStatement statement)
		{
			this.label = label;
			this.statement = statement;
		}

		/// <summary>Gets or sets the name of the label.</summary>
		/// <returns>The name of the label.</returns>
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00003803 File Offset: 0x00001A03
		// (set) Token: 0x06000247 RID: 583 RVA: 0x0000381C File Offset: 0x00001A1C
		public string Label
		{
			get
			{
				if (this.label == null)
				{
					return string.Empty;
				}
				return this.label;
			}
			set
			{
				this.label = value;
			}
		}

		/// <summary>Gets or sets the optional associated statement.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeStatement" /> that indicates the statement associated with the label.</returns>
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00003825 File Offset: 0x00001A25
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0000382D File Offset: 0x00001A2D
		public CodeStatement Statement
		{
			get
			{
				return this.statement;
			}
			set
			{
				this.statement = value;
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00003836 File Offset: 0x00001A36
		internal override void Accept(ICodeDomVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Token: 0x040000AD RID: 173
		private string label;

		// Token: 0x040000AE RID: 174
		private CodeStatement statement;
	}
}
