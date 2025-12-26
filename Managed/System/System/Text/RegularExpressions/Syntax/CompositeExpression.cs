using System;

namespace System.Text.RegularExpressions.Syntax
{
	// Token: 0x020004B7 RID: 1207
	internal abstract class CompositeExpression : Expression
	{
		// Token: 0x06002AE4 RID: 10980 RVA: 0x0001DD71 File Offset: 0x0001BF71
		public CompositeExpression()
		{
			this.expressions = new ExpressionCollection();
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06002AE5 RID: 10981 RVA: 0x0001DD84 File Offset: 0x0001BF84
		protected ExpressionCollection Expressions
		{
			get
			{
				return this.expressions;
			}
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x0008AC2C File Offset: 0x00088E2C
		protected void GetWidth(out int min, out int max, int count)
		{
			min = int.MaxValue;
			max = 0;
			bool flag = true;
			for (int i = 0; i < count; i++)
			{
				Expression expression = this.Expressions[i];
				if (expression != null)
				{
					flag = false;
					int num;
					int num2;
					expression.GetWidth(out num, out num2);
					if (num < min)
					{
						min = num;
					}
					if (num2 > max)
					{
						max = num2;
					}
				}
			}
			if (flag)
			{
				min = (max = 0);
			}
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x0008ACA4 File Offset: 0x00088EA4
		public override bool IsComplex()
		{
			foreach (object obj in this.Expressions)
			{
				Expression expression = (Expression)obj;
				if (expression.IsComplex())
				{
					return true;
				}
			}
			return base.GetFixedWidth() <= 0;
		}

		// Token: 0x04001B1F RID: 6943
		private ExpressionCollection expressions;
	}
}
