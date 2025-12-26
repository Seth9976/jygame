using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents a reference to an indexer property of an object.</summary>
	// Token: 0x02000044 RID: 68
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Serializable]
	public class CodeIndexerExpression : CodeExpression
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeIndexerExpression" /> class.</summary>
		// Token: 0x06000233 RID: 563 RVA: 0x00002AA4 File Offset: 0x00000CA4
		public CodeIndexerExpression()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeIndexerExpression" /> class using the specified target object and index.</summary>
		/// <param name="targetObject">The target object. </param>
		/// <param name="indices">The index or indexes of the indexer expression. </param>
		// Token: 0x06000234 RID: 564 RVA: 0x00003707 File Offset: 0x00001907
		public CodeIndexerExpression(CodeExpression targetObject, params CodeExpression[] indices)
		{
			this.targetObject = targetObject;
			this.Indices.AddRange(indices);
		}

		/// <summary>Gets the collection of indexes of the indexer expression.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeExpressionCollection" /> that indicates the index or indexes of the indexer expression.</returns>
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00003722 File Offset: 0x00001922
		public CodeExpressionCollection Indices
		{
			get
			{
				if (this.indices == null)
				{
					this.indices = new CodeExpressionCollection();
				}
				return this.indices;
			}
		}

		/// <summary>Gets or sets the target object that can be indexed.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeExpression" /> that indicates the indexer object.</returns>
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00003740 File Offset: 0x00001940
		// (set) Token: 0x06000237 RID: 567 RVA: 0x00003748 File Offset: 0x00001948
		public CodeExpression TargetObject
		{
			get
			{
				return this.targetObject;
			}
			set
			{
				this.targetObject = value;
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00003751 File Offset: 0x00001951
		internal override void Accept(ICodeDomVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Token: 0x040000A7 RID: 167
		private CodeExpression targetObject;

		// Token: 0x040000A8 RID: 168
		private CodeExpressionCollection indices;
	}
}
