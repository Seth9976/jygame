using System;
using System.Runtime.InteropServices;

namespace System.CodeDom
{
	/// <summary>Represents an expression used as a method invoke parameter along with a reference direction indicator.</summary>
	// Token: 0x0200003A RID: 58
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[Serializable]
	public class CodeDirectionExpression : CodeExpression
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeDirectionExpression" /> class.</summary>
		// Token: 0x060001F6 RID: 502 RVA: 0x00002AA4 File Offset: 0x00000CA4
		public CodeDirectionExpression()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.CodeDirectionExpression" /> class using the specified field direction and expression.</summary>
		/// <param name="direction">A <see cref="T:System.CodeDom.FieldDirection" /> that indicates the field direction of the expression. </param>
		/// <param name="expression">A <see cref="T:System.CodeDom.CodeExpression" /> that indicates the code expression to represent. </param>
		// Token: 0x060001F7 RID: 503 RVA: 0x00003534 File Offset: 0x00001734
		public CodeDirectionExpression(FieldDirection direction, CodeExpression expression)
		{
			this.direction = direction;
			this.expression = expression;
		}

		/// <summary>Gets or sets the field direction for this direction expression.</summary>
		/// <returns>A <see cref="T:System.CodeDom.FieldDirection" /> that indicates the field direction for this direction expression.</returns>
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000354A File Offset: 0x0000174A
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00003552 File Offset: 0x00001752
		public FieldDirection Direction
		{
			get
			{
				return this.direction;
			}
			set
			{
				this.direction = value;
			}
		}

		/// <summary>Gets or sets the code expression to represent.</summary>
		/// <returns>A <see cref="T:System.CodeDom.CodeExpression" /> that indicates the expression to represent.</returns>
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0000355B File Offset: 0x0000175B
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00003563 File Offset: 0x00001763
		public CodeExpression Expression
		{
			get
			{
				return this.expression;
			}
			set
			{
				this.expression = value;
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000356C File Offset: 0x0000176C
		internal override void Accept(ICodeDomVisitor visitor)
		{
			visitor.Visit(this);
		}

		// Token: 0x0400009F RID: 159
		private FieldDirection direction;

		// Token: 0x040000A0 RID: 160
		private CodeExpression expression;
	}
}
