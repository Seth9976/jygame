using System;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000487 RID: 1159
	internal class MRUList
	{
		// Token: 0x060028DF RID: 10463 RVA: 0x0007A9A0 File Offset: 0x00078BA0
		public MRUList()
		{
			this.head = (this.tail = null);
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x0007A9C4 File Offset: 0x00078BC4
		public void Use(object o)
		{
			MRUList.Node node;
			if (this.head == null)
			{
				node = new MRUList.Node(o);
				this.head = (this.tail = node);
				return;
			}
			node = this.head;
			while (node != null && !o.Equals(node.value))
			{
				node = node.previous;
			}
			if (node == null)
			{
				node = new MRUList.Node(o);
			}
			else
			{
				if (node == this.head)
				{
					return;
				}
				if (node == this.tail)
				{
					this.tail = node.next;
				}
				else
				{
					node.previous.next = node.next;
				}
				node.next.previous = node.previous;
			}
			this.head.next = node;
			node.previous = this.head;
			node.next = null;
			this.head = node;
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x0007AAA4 File Offset: 0x00078CA4
		public object Evict()
		{
			if (this.tail == null)
			{
				return null;
			}
			object value = this.tail.value;
			this.tail = this.tail.next;
			if (this.tail == null)
			{
				this.head = null;
			}
			else
			{
				this.tail.previous = null;
			}
			return value;
		}

		// Token: 0x04001925 RID: 6437
		private MRUList.Node head;

		// Token: 0x04001926 RID: 6438
		private MRUList.Node tail;

		// Token: 0x02000488 RID: 1160
		private class Node
		{
			// Token: 0x060028E2 RID: 10466 RVA: 0x0001C75F File Offset: 0x0001A95F
			public Node(object value)
			{
				this.value = value;
			}

			// Token: 0x04001927 RID: 6439
			public object value;

			// Token: 0x04001928 RID: 6440
			public MRUList.Node previous;

			// Token: 0x04001929 RID: 6441
			public MRUList.Node next;
		}
	}
}
