using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a variable declaration.</summary>
	// Token: 0x02000073 RID: 115
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Serializable]
	public class CodeVariableDeclarationStatement : CodeStatement
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeVariableDeclarationStatement" /> class.</summary>
		// Token: 0x060003CC RID: 972 RVA: 0x00002CA6 File Offset: 0x00000EA6
		public CodeVariableDeclarationStatement()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeVariableDeclarationStatement" /> class using the specified type and name.</summary>
		/// <param name="type">A <see cref="T:System.CodeDom.CodeTypeReference" /> that indicates the data type of the variable. </param>
		/// <param name="name">The name of the variable. </param>
		// Token: 0x060003CD RID: 973 RVA: 0x00004D1E File Offset: 0x00002F1E
		public CodeVariableDeclarationStatement(CodeTypeReference type, string name)
		{
			this.type = type;
			this.name = name;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeVariableDeclarationStatement" /> class using the specified data type name and variable name.</summary>
		/// <param name="type">The name of the data type of the variable. </param>
		/// <param name="name">The name of the variable. </param>
		// Token: 0x060003CE RID: 974 RVA: 0x00004D34 File Offset: 0x00002F34
		public CodeVariableDeclarationStatement(string type, string name)
		{
			this.type = new CodeTypeReference(type);
			this.name = name;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeVariableDeclarationStatement" /> class using the specified data type and variable name.</summary>
		/// <param name="type">The data type for the variable. </param>
		/// <param name="name">The name of the variable. </param>
		// Token: 0x060003CF RID: 975 RVA: 0x00004D4F File Offset: 0x00002F4F
		public CodeVariableDeclarationStatement(Type type, string name)
		{
			this.type = new CodeTypeReference(type);
			this.name = name;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeVariableDeclarationStatement" /> class using the specified data type, variable name, and initialization expression.</summary>
		/// <param name="type">A <see cref="T:System.CodeDom.CodeTypeReference" /> that indicates the type of the variable. </param>
		/// <param name="name">The name of the variable. </param>
		/// <param name="initExpression">A <see cref="T:System.CodeDom.CodeExpression" /> that indicates the initialization expression for the variable. </param>
		// Token: 0x060003D0 RID: 976 RVA: 0x00004D6A File Offset: 0x00002F6A
		public CodeVariableDeclarationStatement(CodeTypeReference type, string name, CodeExpression initExpression)
		{
			this.type = type;
			this.name = name;
			this.initExpression = initExpression;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeVariableDeclarationStatement" /> class using the specified data type, variable name, and initialization expression.</summary>
		/// <param name="type">The name of the data type of the variable. </param>
		/// <param name="name">The name of the variable. </param>
		/// <param name="initExpression">A <see cref="T:System.CodeDom.CodeExpression" /> that indicates the initialization expression for the variable. </param>
		// Token: 0x060003D1 RID: 977 RVA: 0x00004D87 File Offset: 0x00002F87
		public CodeVariableDeclarationStatement(string type, string name, CodeExpression initExpression)
		{
			this.type = new CodeTypeReference(type);
			this.name = name;
			this.initExpression = initExpression;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeVariableDeclarationStatement" /> class using the specified data type, variable name, and initialization expression.</summary>
		/// <param name="type">The data type of the variable. </param>
		/// <param name="name">The name of the variable. </param>
		/// <param name="initExpression">A <see cref="T:System.CodeDom.CodeExpression" /> that indicates the initialization expression for the variable. </param>
		// Token: 0x060003D2 RID: 978 RVA: 0x00004DA9 File Offset: 0x00002FA9
		public CodeVariableDeclarationStatement(Type type, string name, CodeExpression initExpression)
		{
			this.type = new CodeTypeReference(type);
			this.name = name;
			this.initExpression = initExpression;
		}

		/// <summary>Gets or sets the initialization expression for the variable.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeExpression" /> that indicates the initialization expression for the variable.</returns>
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00004DCB File Offset: 0x00002FCB
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x00004DD3 File Offset: 0x00002FD3
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

		/// <summary>Gets or sets the name of the variable.</summary>
		/// <returns>The name of the variable.</returns>
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00004DDC File Offset: 0x00002FDC
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x00004DF5 File Offset: 0x00002FF5
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

		/// <summary>Gets or sets the data type of the variable.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeTypeReference" /> that indicates the data type of the variable.</returns>
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x00004DFE File Offset: 0x00002FFE
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x00004E21 File Offset: 0x00003021
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

		// Token: 0x060003D9 RID: 985 RVA: 0x00004E2A File Offset: 0x0000302A
		internal override void Accept(ICodeDomVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Token: 0x0400011D RID: 285
		private CodeExpression initExpression;

		// Token: 0x0400011E RID: 286
		private CodeTypeReference type;

		// Token: 0x0400011F RID: 287
		private string name;
	}
}
