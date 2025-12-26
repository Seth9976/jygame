using System;

namespace System.Text.RegularExpressions.Syntax
{
	// Token: 0x020004C3 RID: 1219
	internal class PositionAssertion : Expression
	{
		// Token: 0x06002B33 RID: 11059 RVA: 0x0001E083 File Offset: 0x0001C283
		public PositionAssertion(Position pos)
		{
			this.pos = pos;
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06002B34 RID: 11060 RVA: 0x0001E092 File Offset: 0x0001C292
		// (set) Token: 0x06002B35 RID: 11061 RVA: 0x0001E09A File Offset: 0x0001C29A
		public Position Position
		{
			get
			{
				return this.pos;
			}
			set
			{
				this.pos = value;
			}
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x0001E0A3 File Offset: 0x0001C2A3
		public override void Compile(ICompiler cmp, bool reverse)
		{
			cmp.EmitPosition(this.pos);
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x0008B6CC File Offset: 0x000898CC
		public override void GetWidth(out int min, out int max)
		{
			min = (max = 0);
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool IsComplex()
		{
			return false;
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x0008B6E4 File Offset: 0x000898E4
		public override AnchorInfo GetAnchorInfo(bool revers)
		{
			switch (this.pos)
			{
			case Position.StartOfString:
			case Position.StartOfLine:
			case Position.StartOfScan:
				return new AnchorInfo(this, 0, 0, this.pos);
			default:
				return new AnchorInfo(this, 0);
			}
		}

		// Token: 0x04001B2E RID: 6958
		private Position pos;
	}
}
