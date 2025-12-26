using System;
using System.Collections.Generic;

namespace System.ComponentModel
{
	// Token: 0x020001C9 RID: 457
	internal sealed class WeakObjectWrapperComparer : EqualityComparer<WeakObjectWrapper>
	{
		// Token: 0x06000FF6 RID: 4086 RVA: 0x000389DC File Offset: 0x00036BDC
		public override bool Equals(WeakObjectWrapper x, WeakObjectWrapper y)
		{
			if (x == null && y == null)
			{
				return false;
			}
			if (x == null || y == null)
			{
				return false;
			}
			WeakReference weak = x.Weak;
			WeakReference weak2 = y.Weak;
			return (weak.IsAlive || weak2.IsAlive) && weak.Target == weak2.Target;
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0000D01A File Offset: 0x0000B21A
		public override int GetHashCode(WeakObjectWrapper obj)
		{
			if (obj == null)
			{
				return 0;
			}
			return obj.TargetHashCode;
		}
	}
}
