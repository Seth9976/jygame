using System;

namespace System.Text.RegularExpressions.Syntax
{
	// Token: 0x020004C4 RID: 1220
	internal class Reference : Expression
	{
		// Token: 0x06002B3A RID: 11066 RVA: 0x0001E0B1 File Offset: 0x0001C2B1
		public Reference(bool ignore)
		{
			this.ignore = ignore;
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06002B3B RID: 11067 RVA: 0x0001E0C0 File Offset: 0x0001C2C0
		// (set) Token: 0x06002B3C RID: 11068 RVA: 0x0001E0C8 File Offset: 0x0001C2C8
		public CapturingGroup CapturingGroup
		{
			get
			{
				return this.group;
			}
			set
			{
				this.group = value;
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06002B3D RID: 11069 RVA: 0x0001E0D1 File Offset: 0x0001C2D1
		// (set) Token: 0x06002B3E RID: 11070 RVA: 0x0001E0D9 File Offset: 0x0001C2D9
		public bool IgnoreCase
		{
			get
			{
				return this.ignore;
			}
			set
			{
				this.ignore = value;
			}
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x0001E0E2 File Offset: 0x0001C2E2
		public override void Compile(ICompiler cmp, bool reverse)
		{
			cmp.EmitReference(this.group.Index, this.ignore, reverse);
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x0001E0FC File Offset: 0x0001C2FC
		public override void GetWidth(out int min, out int max)
		{
			min = 0;
			max = int.MaxValue;
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x000025B7 File Offset: 0x000007B7
		public override bool IsComplex()
		{
			return true;
		}

		// Token: 0x04001B2F RID: 6959
		private CapturingGroup group;

		// Token: 0x04001B30 RID: 6960
		private bool ignore;
	}
}
