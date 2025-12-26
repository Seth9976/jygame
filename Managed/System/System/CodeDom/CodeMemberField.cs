using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a declaration for a field of a type.</summary>
	// Token: 0x02000049 RID: 73
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Serializable]
	public class CodeMemberField : CodeTypeMember
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeMemberField" /> class.</summary>
		// Token: 0x06000258 RID: 600 RVA: 0x00003888 File Offset: 0x00001A88
		public CodeMemberField()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeMemberField" /> class using the specified field type and field name.</summary>
		/// <param name="type">A <see cref="T:System.CodeDom.CodeTypeReference" /> that indicates the type of the field. </param>
		/// <param name="name">The name of the field. </param>
		// Token: 0x06000259 RID: 601 RVA: 0x000038F4 File Offset: 0x00001AF4
		public CodeMemberField(CodeTypeReference type, string name)
		{
			this.type = type;
			base.Name = name;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeMemberField" /> class using the specified field type and field name.</summary>
		/// <param name="type">The data type of the field. </param>
		/// <param name="name">The name of the field. </param>
		// Token: 0x0600025A RID: 602 RVA: 0x0000390A File Offset: 0x00001B0A
		public CodeMemberField(string type, string name)
		{
			this.type = new CodeTypeReference(type);
			base.Name = name;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeMemberField" /> class using the specified field type and field name.</summary>
		/// <param name="type">The data type of the field. </param>
		/// <param name="name">The name of the field. </param>
		// Token: 0x0600025B RID: 603 RVA: 0x00003925 File Offset: 0x00001B25
		public CodeMemberField(Type type, string name)
		{
			this.type = new CodeTypeReference(type);
			base.Name = name;
		}

		/// <summary>Gets or sets the initialization expression for the field.</summary>
		/// <returns>The initialization expression for the field.</returns>
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00003940 File Offset: 0x00001B40
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00003948 File Offset: 0x00001B48
		public CodeExpression InitExpression
		{
			get
			{
				return this.initExpression;
			}
			set
			{
				this.initExpression = value;
			}
		}

		/// <summary>Gets or sets the data type of the field.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeTypeReference" /> that indicates the data type of the field.</returns>
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00003951 File Offset: 0x00001B51
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00003974 File Offset: 0x00001B74
		public CodeTypeReference Type
		{
			get
			{
				if (this.type == null)
				{
					this.type = new CodeTypeReference(string.Empty);
				}
				return this.type;
			}
			set
			{
				this.type = value;
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000397D File Offset: 0x00001B7D
		internal override void Accept(ICodeDomVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Token: 0x040000B4 RID: 180
		private CodeExpression initExpression;

		// Token: 0x040000B5 RID: 181
		private CodeTypeReference type;
	}
}
