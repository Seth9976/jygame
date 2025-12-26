using System;
using System.Collections;

namespace System.Text.RegularExpressions.Syntax
{
	// Token: 0x020004B5 RID: 1205
	internal class ExpressionCollection : CollectionBase
	{
		// Token: 0x06002ADA RID: 10970 RVA: 0x0001DD41 File Offset: 0x0001BF41
		public void Add(Expression e)
		{
			base.List.Add(e);
		}

		// Token: 0x17000BAD RID: 2989
		public Expression this[int i]
		{
			get
			{
				return (Expression)base.List[i];
			}
			set
			{
				base.List[i] = value;
			}
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x000029F5 File Offset: 0x00000BF5
		protected override void OnValidate(object o)
		{
		}
	}
}
