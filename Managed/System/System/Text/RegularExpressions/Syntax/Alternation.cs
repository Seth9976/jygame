using System;

namespace System.Text.RegularExpressions.Syntax
{
	// Token: 0x020004C1 RID: 1217
	internal class Alternation : CompositeExpression
	{
		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06002B25 RID: 11045 RVA: 0x0001DFB3 File Offset: 0x0001C1B3
		public ExpressionCollection Alternatives
		{
			get
			{
				return base.Expressions;
			}
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x0001DFBB File Offset: 0x0001C1BB
		public void AddAlternative(Expression e)
		{
			this.Alternatives.Add(e);
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x0008B608 File Offset: 0x00089808
		public override void Compile(ICompiler cmp, bool reverse)
		{
			LinkRef linkRef = cmp.NewLink();
			foreach (object obj in this.Alternatives)
			{
				Expression expression = (Expression)obj;
				LinkRef linkRef2 = cmp.NewLink();
				cmp.EmitBranch(linkRef2);
				expression.Compile(cmp, reverse);
				cmp.EmitJump(linkRef);
				cmp.ResolveLink(linkRef2);
				cmp.EmitBranchEnd();
			}
			cmp.EmitFalse();
			cmp.ResolveLink(linkRef);
			cmp.EmitAlternationEnd();
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x0001DFC9 File Offset: 0x0001C1C9
		public override void GetWidth(out int min, out int max)
		{
			base.GetWidth(out min, out max, this.Alternatives.Count);
		}
	}
}
