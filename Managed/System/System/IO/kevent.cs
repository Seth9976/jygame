using System;
using System.Runtime.InteropServices;

namespace System.IO
{
	// Token: 0x02000297 RID: 663
	internal struct kevent : IDisposable
	{
		// Token: 0x0600170B RID: 5899 RVA: 0x00011573 File Offset: 0x0000F773
		public void Dispose()
		{
			if (this.udata != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(this.udata);
			}
		}

		// Token: 0x04000787 RID: 1927
		public int ident;

		// Token: 0x04000788 RID: 1928
		public short filter;

		// Token: 0x04000789 RID: 1929
		public ushort flags;

		// Token: 0x0400078A RID: 1930
		public uint fflags;

		// Token: 0x0400078B RID: 1931
		public int data;

		// Token: 0x0400078C RID: 1932
		public IntPtr udata;
	}
}
