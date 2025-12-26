using System;

namespace System.Text.RegularExpressions.Syntax
{
	// Token: 0x020004BF RID: 1215
	internal class CaptureAssertion : Assertion
	{
		// Token: 0x06002B15 RID: 11029 RVA: 0x0001DF40 File Offset: 0x0001C140
		public CaptureAssertion(Literal l)
		{
			this.literal = l;
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06002B16 RID: 11030 RVA: 0x0001DF4F File Offset: 0x0001C14F
		// (set) Token: 0x06002B17 RID: 11031 RVA: 0x0001DF57 File Offset: 0x0001C157
		public CapturingGroup CapturingGroup
		{
			get
			{
				return this.group;
			}
			set
			{
				this.group = value;
			}
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x0008B3D8 File Offset: 0x000895D8
		public override void Compile(ICompiler cmp, bool reverse)
		{
			if (this.group == null)
			{
				this.Alternate.Compile(cmp, reverse);
				return;
			}
			int index = this.group.Index;
			LinkRef linkRef = cmp.NewLink();
			if (base.FalseExpression == null)
			{
				cmp.EmitIfDefined(index, linkRef);
				base.TrueExpression.Compile(cmp, reverse);
			}
			else
			{
				LinkRef linkRef2 = cmp.NewLink();
				cmp.EmitIfDefined(index, linkRef2);
				base.TrueExpression.Compile(cmp, reverse);
				cmp.EmitJump(linkRef);
				cmp.ResolveLink(linkRef2);
				base.FalseExpression.Compile(cmp, reverse);
			}
			cmp.ResolveLink(linkRef);
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x0008B474 File Offset: 0x00089674
		public override bool IsComplex()
		{
			if (this.group == null)
			{
				return this.Alternate.IsComplex();
			}
			return (base.TrueExpression != null && base.TrueExpression.IsComplex()) || (base.FalseExpression != null && base.FalseExpression.IsComplex()) || base.GetFixedWidth() <= 0;
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06002B1A RID: 11034 RVA: 0x0008B4E0 File Offset: 0x000896E0
		private ExpressionAssertion Alternate
		{
			get
			{
				if (this.alternate == null)
				{
					this.alternate = new ExpressionAssertion();
					this.alternate.TrueExpression = base.TrueExpression;
					this.alternate.FalseExpression = base.FalseExpression;
					this.alternate.TestExpression = this.literal;
				}
				return this.alternate;
			}
		}

		// Token: 0x04001B27 RID: 6951
		private ExpressionAssertion alternate;

		// Token: 0x04001B28 RID: 6952
		private CapturingGroup group;

		// Token: 0x04001B29 RID: 6953
		private Literal literal;
	}
}
