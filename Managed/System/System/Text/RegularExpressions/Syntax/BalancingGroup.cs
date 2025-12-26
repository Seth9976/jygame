using System;

namespace System.Text.RegularExpressions.Syntax
{
	// Token: 0x020004BB RID: 1211
	internal class BalancingGroup : CapturingGroup
	{
		// Token: 0x06002AFC RID: 11004 RVA: 0x0001DE5B File Offset: 0x0001C05B
		public BalancingGroup()
		{
			this.balance = null;
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06002AFD RID: 11005 RVA: 0x0001DE6A File Offset: 0x0001C06A
		// (set) Token: 0x06002AFE RID: 11006 RVA: 0x0001DE72 File Offset: 0x0001C072
		public CapturingGroup Balance
		{
			get
			{
				return this.balance;
			}
			set
			{
				this.balance = value;
			}
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x0008B160 File Offset: 0x00089360
		public override void Compile(ICompiler cmp, bool reverse)
		{
			LinkRef linkRef = cmp.NewLink();
			cmp.EmitBalanceStart(base.Index, this.balance.Index, base.IsNamed, linkRef);
			int count = base.Expressions.Count;
			for (int i = 0; i < count; i++)
			{
				Expression expression;
				if (reverse)
				{
					expression = base.Expressions[count - i - 1];
				}
				else
				{
					expression = base.Expressions[i];
				}
				expression.Compile(cmp, reverse);
			}
			cmp.EmitBalance();
			cmp.ResolveLink(linkRef);
		}

		// Token: 0x04001B23 RID: 6947
		private CapturingGroup balance;
	}
}
