using System;

namespace System.Text.RegularExpressions.Syntax
{
	// Token: 0x020004C0 RID: 1216
	internal class ExpressionAssertion : Assertion
	{
		// Token: 0x06002B1B RID: 11035 RVA: 0x0001DF60 File Offset: 0x0001C160
		public ExpressionAssertion()
		{
			base.Expressions.Add(null);
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06002B1C RID: 11036 RVA: 0x0001DF74 File Offset: 0x0001C174
		// (set) Token: 0x06002B1D RID: 11037 RVA: 0x0001DF7C File Offset: 0x0001C17C
		public bool Reverse
		{
			get
			{
				return this.reverse;
			}
			set
			{
				this.reverse = value;
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06002B1E RID: 11038 RVA: 0x0001DF85 File Offset: 0x0001C185
		// (set) Token: 0x06002B1F RID: 11039 RVA: 0x0001DF8D File Offset: 0x0001C18D
		public bool Negate
		{
			get
			{
				return this.negate;
			}
			set
			{
				this.negate = value;
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06002B20 RID: 11040 RVA: 0x0001DF96 File Offset: 0x0001C196
		// (set) Token: 0x06002B21 RID: 11041 RVA: 0x0001DFA4 File Offset: 0x0001C1A4
		public Expression TestExpression
		{
			get
			{
				return base.Expressions[2];
			}
			set
			{
				base.Expressions[2] = value;
			}
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x0008B53C File Offset: 0x0008973C
		public override void Compile(ICompiler cmp, bool reverse)
		{
			LinkRef linkRef = cmp.NewLink();
			LinkRef linkRef2 = cmp.NewLink();
			if (!this.negate)
			{
				cmp.EmitTest(linkRef, linkRef2);
			}
			else
			{
				cmp.EmitTest(linkRef2, linkRef);
			}
			this.TestExpression.Compile(cmp, this.reverse);
			cmp.EmitTrue();
			if (base.TrueExpression == null)
			{
				cmp.ResolveLink(linkRef2);
				cmp.EmitFalse();
				cmp.ResolveLink(linkRef);
			}
			else
			{
				cmp.ResolveLink(linkRef);
				base.TrueExpression.Compile(cmp, reverse);
				if (base.FalseExpression == null)
				{
					cmp.ResolveLink(linkRef2);
				}
				else
				{
					LinkRef linkRef3 = cmp.NewLink();
					cmp.EmitJump(linkRef3);
					cmp.ResolveLink(linkRef2);
					base.FalseExpression.Compile(cmp, reverse);
					cmp.ResolveLink(linkRef3);
				}
			}
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x000025B7 File Offset: 0x000007B7
		public override bool IsComplex()
		{
			return true;
		}

		// Token: 0x04001B2A RID: 6954
		private bool reverse;

		// Token: 0x04001B2B RID: 6955
		private bool negate;
	}
}
