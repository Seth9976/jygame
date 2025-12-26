using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Provides a base class for a member of a type. Type members include fields, methods, properties, constructors and nested types.</summary>
	// Token: 0x0200006B RID: 107
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Serializable]
	public class CodeTypeMember : CodeObject
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeTypeMember" /> class. </summary>
		// Token: 0x06000379 RID: 889 RVA: 0x00004953 File Offset: 0x00002B53
		public CodeTypeMember()
		{
			this.attributes = (MemberAttributes)20482;
		}

		/// <summary>Gets or sets the attributes of the member.</summary>
		/// <returns>A bitwise combination of the <see cref="T:System.CodeDom.MemberAttributes" /> values used to indicate the attributes of the member. The default value is <see cref="F:System.CodeDom.MemberAttributes.Private" /> | <see cref="F:System.CodeDom.MemberAttributes.Final" />. </returns>
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00004966 File Offset: 0x00002B66
		// (set) Token: 0x0600037B RID: 891 RVA: 0x0000496E File Offset: 0x00002B6E
		public MemberAttributes Attributes
		{
			get
			{
				return this.attributes;
			}
			set
			{
				this.attributes = value;
			}
		}

		/// <summary>Gets the collection of comments for the type member.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeCommentStatementCollection" /> that indicates the comments for the member.</returns>
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00004977 File Offset: 0x00002B77
		public CodeCommentStatementCollection Comments
		{
			get
			{
				if (this.comments == null)
				{
					this.comments = new CodeCommentStatementCollection();
				}
				return this.comments;
			}
		}

		/// <summary>Gets or sets the custom attributes of the member.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeAttributeDeclarationCollection" /> that indicates the custom attributes of the member.</returns>
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00004995 File Offset: 0x00002B95
		// (set) Token: 0x0600037E RID: 894 RVA: 0x000049B3 File Offset: 0x00002BB3
		public CodeAttributeDeclarationCollection CustomAttributes
		{
			get
			{
				if (this.customAttributes == null)
				{
					this.customAttributes = new CodeAttributeDeclarationCollection();
				}
				return this.customAttributes;
			}
			set
			{
				this.customAttributes = value;
			}
		}

		/// <summary>Gets or sets the line on which the type member statement occurs.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeLinePragma" /> object that indicates the location of the type member declaration.</returns>
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600037F RID: 895 RVA: 0x000049BC File Offset: 0x00002BBC
		// (set) Token: 0x06000380 RID: 896 RVA: 0x000049C4 File Offset: 0x00002BC4
		public CodeLinePragma LinePragma
		{
			get
			{
				return this.linePragma;
			}
			set
			{
				this.linePragma = value;
			}
		}

		/// <summary>Gets or sets the name of the member.</summary>
		/// <returns>The name of the member.</returns>
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000381 RID: 897 RVA: 0x000049CD File Offset: 0x00002BCD
		// (set) Token: 0x06000382 RID: 898 RVA: 0x000049E6 File Offset: 0x00002BE6
		public string Name
		{
			get
			{
				if (this.name == null)
				{
					return string.Empty;
				}
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		/// <summary>Gets the end directives for the member.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeDirectiveCollection" /> object containing end directives.</returns>
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000383 RID: 899 RVA: 0x000049EF File Offset: 0x00002BEF
		public CodeDirectiveCollection EndDirectives
		{
			get
			{
				if (this.endDirectives == null)
				{
					this.endDirectives = new CodeDirectiveCollection();
				}
				return this.endDirectives;
			}
		}

		/// <summary>Gets the start directives for the member.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeDirectiveCollection" /> object containing start directives.</returns>
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00004A0D File Offset: 0x00002C0D
		public CodeDirectiveCollection StartDirectives
		{
			get
			{
				if (this.startDirectives == null)
				{
					this.startDirectives = new CodeDirectiveCollection();
				}
				return this.startDirectives;
			}
		}

		// Token: 0x04000106 RID: 262
		private string name;

		// Token: 0x04000107 RID: 263
		private MemberAttributes attributes;

		// Token: 0x04000108 RID: 264
		private CodeCommentStatementCollection comments;

		// Token: 0x04000109 RID: 265
		private CodeAttributeDeclarationCollection customAttributes;

		// Token: 0x0400010A RID: 266
		private CodeLinePragma linePragma;

		// Token: 0x0400010B RID: 267
		private CodeDirectiveCollection endDirectives;

		// Token: 0x0400010C RID: 268
		private CodeDirectiveCollection startDirectives;
	}
}
