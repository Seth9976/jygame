using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a namespace declaration.</summary>
	// Token: 0x02000050 RID: 80
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Serializable]
	public class CodeNamespace : CodeObject
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeNamespace" /> class.</summary>
		// Token: 0x060002A2 RID: 674 RVA: 0x000031A0 File Offset: 0x000013A0
		public CodeNamespace()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeNamespace" /> class using the specified name.</summary>
		/// <param name="name">The name of the namespace being declared. </param>
		// Token: 0x060002A3 RID: 675 RVA: 0x00003E2F File Offset: 0x0000202F
		public CodeNamespace(string name)
		{
			this.name = name;
		}

		/// <summary>An event that will be raised the first time the <see cref="P:System.CodeDom.CodeNamespace.Comments" /> collection is accessed.</summary>
		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060002A4 RID: 676 RVA: 0x00003E3E File Offset: 0x0000203E
		// (remove) Token: 0x060002A5 RID: 677 RVA: 0x00003E57 File Offset: 0x00002057
		public event EventHandler PopulateComments;

		/// <summary>An event that will be raised the first time the <see cref="P:System.CodeDom.CodeNamespace.Imports" /> collection is accessed.</summary>
		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060002A6 RID: 678 RVA: 0x00003E70 File Offset: 0x00002070
		// (remove) Token: 0x060002A7 RID: 679 RVA: 0x00003E89 File Offset: 0x00002089
		public event EventHandler PopulateImports;

		/// <summary>An event that will be raised the first time the <see cref="P:System.CodeDom.CodeNamespace.Types" /> collection is accessed.</summary>
		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060002A8 RID: 680 RVA: 0x00003EA2 File Offset: 0x000020A2
		// (remove) Token: 0x060002A9 RID: 681 RVA: 0x00003EBB File Offset: 0x000020BB
		public event EventHandler PopulateTypes;

		/// <summary>Gets the comments for the namespace.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeCommentStatementCollection" /> that indicates the comments for the namespace.</returns>
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060002AA RID: 682 RVA: 0x00003ED4 File Offset: 0x000020D4
		public CodeCommentStatementCollection Comments
		{
			get
			{
				if (this.comments == null)
				{
					this.comments = new CodeCommentStatementCollection();
					if (this.PopulateComments != null)
					{
						this.PopulateComments(this, EventArgs.Empty);
					}
				}
				return this.comments;
			}
		}

		/// <summary>Gets the collection of namespace import directives used by the namespace.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeNamespaceImportCollection" /> that indicates the namespace import directives used by the namespace.</returns>
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002AB RID: 683 RVA: 0x00003F0E File Offset: 0x0000210E
		public CodeNamespaceImportCollection Imports
		{
			get
			{
				if (this.imports == null)
				{
					this.imports = new CodeNamespaceImportCollection();
					if (this.PopulateImports != null)
					{
						this.PopulateImports(this, EventArgs.Empty);
					}
				}
				return this.imports;
			}
		}

		/// <summary>Gets or sets the name of the namespace.</summary>
		/// <returns>The name of the namespace.</returns>
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00003F48 File Offset: 0x00002148
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00003F61 File Offset: 0x00002161
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

		/// <summary>Gets the collection of types that the namespace contains.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeTypeDeclarationCollection" /> that indicates the types contained in the namespace.</returns>
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00003F6A File Offset: 0x0000216A
		public CodeTypeDeclarationCollection Types
		{
			get
			{
				if (this.classes == null)
				{
					this.classes = new CodeTypeDeclarationCollection();
					if (this.PopulateTypes != null)
					{
						this.PopulateTypes(this, EventArgs.Empty);
					}
				}
				return this.classes;
			}
		}

		// Token: 0x040000CF RID: 207
		private CodeCommentStatementCollection comments;

		// Token: 0x040000D0 RID: 208
		private CodeNamespaceImportCollection imports;

		// Token: 0x040000D1 RID: 209
		private CodeNamespaceCollection namespaces;

		// Token: 0x040000D2 RID: 210
		private CodeTypeDeclarationCollection classes;

		// Token: 0x040000D3 RID: 211
		private string name;

		// Token: 0x040000D4 RID: 212
		private int populated;
	}
}
