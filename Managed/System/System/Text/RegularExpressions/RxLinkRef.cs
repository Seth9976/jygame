using System;

namespace System.Text.RegularExpressions
{
	// Token: 0x020004B0 RID: 1200
	internal class RxLinkRef : LinkRef
	{
		// Token: 0x06002A97 RID: 10903 RVA: 0x0001D996 File Offset: 0x0001BB96
		public RxLinkRef()
		{
			this.offsets = new int[8];
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x000893E0 File Offset: 0x000875E0
		public void PushInstructionBase(int offset)
		{
			if ((this.current & 1) != 0)
			{
				throw new Exception();
			}
			if (this.current == this.offsets.Length)
			{
				int[] array = new int[this.offsets.Length * 2];
				Array.Copy(this.offsets, array, this.offsets.Length);
				this.offsets = array;
			}
			this.offsets[this.current++] = offset;
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x00089458 File Offset: 0x00087658
		public void PushOffsetPosition(int offset)
		{
			if ((this.current & 1) == 0)
			{
				throw new Exception();
			}
			this.offsets[this.current++] = offset;
		}

		// Token: 0x04001A72 RID: 6770
		public int[] offsets;

		// Token: 0x04001A73 RID: 6771
		public int current;
	}
}
