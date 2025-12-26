using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a member of a type using a literal code fragment.</summary>
	// Token: 0x02000060 RID: 96
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[Serializable]
	public class CodeSnippetTypeMember : CodeTypeMember
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeSnippetTypeMember" /> class.</summary>
		// Token: 0x0600031D RID: 797 RVA: 0x00003888 File Offset: 0x00001A88
		public CodeSnippetTypeMember()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeSnippetTypeMember" /> class using the specified text.</summary>
		/// <param name="text">The literal code fragment for the type member. </param>
		// Token: 0x0600031E RID: 798 RVA: 0x00004498 File Offset: 0x00002698
		public CodeSnippetTypeMember(string text)
		{
			this.text = text;
		}

		/// <summary>Gets or sets the literal code fragment for the type member.</summary>
		/// <returns>The literal code fragment for the type member.</returns>
		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600031F RID: 799 RVA: 0x000044A7 File Offset: 0x000026A7
		// (set) Token: 0x06000320 RID: 800 RVA: 0x000044C0 File Offset: 0x000026C0
		public string Text
		{
			get
			{
				if (this.text == null)
				{
					return string.Empty;
				}
				return this.text;
			}
			set
			{
				this.text = value;
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000044C9 File Offset: 0x000026C9
		internal override void Accept(ICodeDomVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Token: 0x040000F2 RID: 242
		private string text;
	}
}
