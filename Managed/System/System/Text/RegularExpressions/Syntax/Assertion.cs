using System;

namespace System.Text.RegularExpressions.Syntax
{
	// Token: 0x020004BE RID: 1214
	internal abstract class Assertion : CompositeExpression
	{
		// Token: 0x06002B0F RID: 11023 RVA: 0x0001DEDF File Offset: 0x0001C0DF
		public Assertion()
		{
			base.Expressions.Add(null);
			base.Expressions.Add(null);
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06002B10 RID: 11024 RVA: 0x0001DD94 File Offset: 0x0001BF94
		// (set) Token: 0x06002B11 RID: 11025 RVA: 0x0001DDA2 File Offset: 0x0001BFA2
		public Expression TrueExpression
		{
			get
			{
				return base.Expressions[0];
			}
			set
			{
				base.Expressions[0] = value;
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06002B12 RID: 11026 RVA: 0x0001DEFF File Offset: 0x0001C0FF
		// (set) Token: 0x06002B13 RID: 11027 RVA: 0x0001DF0D File Offset: 0x0001C10D
		public Expression FalseExpression
		{
			get
			{
				return base.Expressions[1];
			}
			set
			{
				base.Expressions[1] = value;
			}
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x0001DF1C File Offset: 0x0001C11C
		public override void GetWidth(out int min, out int max)
		{
			base.GetWidth(out min, out max, 2);
			if (this.TrueExpression == null || this.FalseExpression == null)
			{
				min = 0;
			}
		}
	}
}
