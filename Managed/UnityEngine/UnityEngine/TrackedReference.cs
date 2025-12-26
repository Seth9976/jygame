using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	// Token: 0x020002E0 RID: 736
	[StructLayout(LayoutKind.Sequential)]
	public class TrackedReference
	{
		// Token: 0x0600226B RID: 8811 RVA: 0x000021D6 File Offset: 0x000003D6
		protected TrackedReference()
		{
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x0000DD95 File Offset: 0x0000BF95
		public override bool Equals(object o)
		{
			return o as TrackedReference == this;
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x0000DDA3 File Offset: 0x0000BFA3
		public override int GetHashCode()
		{
			return (int)this.m_Ptr;
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x0002D0E0 File Offset: 0x0002B2E0
		public static bool operator ==(TrackedReference x, TrackedReference y)
		{
			if (y == null && x == null)
			{
				return true;
			}
			if (y == null)
			{
				return x.m_Ptr == IntPtr.Zero;
			}
			if (x == null)
			{
				return y.m_Ptr == IntPtr.Zero;
			}
			return x.m_Ptr == y.m_Ptr;
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x0000DDB0 File Offset: 0x0000BFB0
		public static bool operator !=(TrackedReference x, TrackedReference y)
		{
			return !(x == y);
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x0000DDBC File Offset: 0x0000BFBC
		public static implicit operator bool(TrackedReference exists)
		{
			return exists != null;
		}

		// Token: 0x04000B6B RID: 2923
		internal IntPtr m_Ptr;
	}
}
