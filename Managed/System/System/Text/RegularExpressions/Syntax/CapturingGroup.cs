using System;

namespace System.Text.RegularExpressions.Syntax
{
	// Token: 0x020004BA RID: 1210
	internal class CapturingGroup : Group, IComparable
	{
		// Token: 0x06002AF3 RID: 10995 RVA: 0x0001DDDF File Offset: 0x0001BFDF
		public CapturingGroup()
		{
			this.gid = 0;
			this.name = null;
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06002AF4 RID: 10996 RVA: 0x0001DDF5 File Offset: 0x0001BFF5
		// (set) Token: 0x06002AF5 RID: 10997 RVA: 0x0001DDFD File Offset: 0x0001BFFD
		public int Index
		{
			get
			{
				return this.gid;
			}
			set
			{
				this.gid = value;
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06002AF6 RID: 10998 RVA: 0x0001DE06 File Offset: 0x0001C006
		// (set) Token: 0x06002AF7 RID: 10999 RVA: 0x0001DE0E File Offset: 0x0001C00E
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06002AF8 RID: 11000 RVA: 0x0001DE17 File Offset: 0x0001C017
		public bool IsNamed
		{
			get
			{
				return this.name != null;
			}
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x0001DE25 File Offset: 0x0001C025
		public override void Compile(ICompiler cmp, bool reverse)
		{
			cmp.EmitOpen(this.gid);
			base.Compile(cmp, reverse);
			cmp.EmitClose(this.gid);
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x000025B7 File Offset: 0x000007B7
		public override bool IsComplex()
		{
			return true;
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x0001DE47 File Offset: 0x0001C047
		public int CompareTo(object other)
		{
			return this.gid - ((CapturingGroup)other).gid;
		}

		// Token: 0x04001B21 RID: 6945
		private int gid;

		// Token: 0x04001B22 RID: 6946
		private string name;
	}
}
