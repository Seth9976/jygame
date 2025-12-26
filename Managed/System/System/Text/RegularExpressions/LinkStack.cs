using System;
using System.Collections;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000495 RID: 1173
	internal abstract class LinkStack : LinkRef
	{
		// Token: 0x06002963 RID: 10595 RVA: 0x0001CD86 File Offset: 0x0001AF86
		public LinkStack()
		{
			this.stack = new Stack();
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x0001CD99 File Offset: 0x0001AF99
		public void Push()
		{
			this.stack.Push(this.GetCurrent());
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x0001CDAC File Offset: 0x0001AFAC
		public bool Pop()
		{
			if (this.stack.Count > 0)
			{
				this.SetCurrent(this.stack.Pop());
				return true;
			}
			return false;
		}

		// Token: 0x06002966 RID: 10598
		protected abstract object GetCurrent();

		// Token: 0x06002967 RID: 10599
		protected abstract void SetCurrent(object l);

		// Token: 0x040019EA RID: 6634
		private Stack stack;
	}
}
