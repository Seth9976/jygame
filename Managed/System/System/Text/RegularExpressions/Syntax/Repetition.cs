using System;

namespace System.Text.RegularExpressions.Syntax
{
	// Token: 0x020004BD RID: 1213
	internal class Repetition : CompositeExpression
	{
		// Token: 0x06002B03 RID: 11011 RVA: 0x0001DE83 File Offset: 0x0001C083
		public Repetition(int min, int max, bool lazy)
		{
			base.Expressions.Add(null);
			this.min = min;
			this.max = max;
			this.lazy = lazy;
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06002B04 RID: 11012 RVA: 0x0001DD94 File Offset: 0x0001BF94
		// (set) Token: 0x06002B05 RID: 11013 RVA: 0x0001DDA2 File Offset: 0x0001BFA2
		public Expression Expression
		{
			get
			{
				return base.Expressions[0];
			}
			set
			{
				base.Expressions[0] = value;
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06002B06 RID: 11014 RVA: 0x0001DEAC File Offset: 0x0001C0AC
		// (set) Token: 0x06002B07 RID: 11015 RVA: 0x0001DEB4 File Offset: 0x0001C0B4
		public int Minimum
		{
			get
			{
				return this.min;
			}
			set
			{
				this.min = value;
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06002B08 RID: 11016 RVA: 0x0001DEBD File Offset: 0x0001C0BD
		// (set) Token: 0x06002B09 RID: 11017 RVA: 0x0001DEC5 File Offset: 0x0001C0C5
		public int Maximum
		{
			get
			{
				return this.max;
			}
			set
			{
				this.max = value;
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06002B0A RID: 11018 RVA: 0x0001DECE File Offset: 0x0001C0CE
		// (set) Token: 0x06002B0B RID: 11019 RVA: 0x0001DED6 File Offset: 0x0001C0D6
		public bool Lazy
		{
			get
			{
				return this.lazy;
			}
			set
			{
				this.lazy = value;
			}
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x0008B220 File Offset: 0x00089420
		public override void Compile(ICompiler cmp, bool reverse)
		{
			if (this.Expression.IsComplex())
			{
				LinkRef linkRef = cmp.NewLink();
				cmp.EmitRepeat(this.min, this.max, this.lazy, linkRef);
				this.Expression.Compile(cmp, reverse);
				cmp.EmitUntil(linkRef);
			}
			else
			{
				LinkRef linkRef2 = cmp.NewLink();
				cmp.EmitFastRepeat(this.min, this.max, this.lazy, linkRef2);
				this.Expression.Compile(cmp, reverse);
				cmp.EmitTrue();
				cmp.ResolveLink(linkRef2);
			}
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x0008B2B0 File Offset: 0x000894B0
		public override void GetWidth(out int min, out int max)
		{
			this.Expression.GetWidth(out min, out max);
			min *= this.min;
			if (max == 2147483647 || this.max == 65535)
			{
				max = int.MaxValue;
			}
			else
			{
				max *= this.max;
			}
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x0008B308 File Offset: 0x00089508
		public override AnchorInfo GetAnchorInfo(bool reverse)
		{
			int fixedWidth = base.GetFixedWidth();
			if (this.Minimum == 0)
			{
				return new AnchorInfo(this, fixedWidth);
			}
			AnchorInfo anchorInfo = this.Expression.GetAnchorInfo(reverse);
			if (anchorInfo.IsPosition)
			{
				return new AnchorInfo(this, anchorInfo.Offset, fixedWidth, anchorInfo.Position);
			}
			if (!anchorInfo.IsSubstring)
			{
				return new AnchorInfo(this, fixedWidth);
			}
			if (anchorInfo.IsComplete)
			{
				string substring = anchorInfo.Substring;
				StringBuilder stringBuilder = new StringBuilder(substring);
				for (int i = 1; i < this.Minimum; i++)
				{
					stringBuilder.Append(substring);
				}
				return new AnchorInfo(this, 0, fixedWidth, stringBuilder.ToString(), anchorInfo.IgnoreCase);
			}
			return new AnchorInfo(this, anchorInfo.Offset, fixedWidth, anchorInfo.Substring, anchorInfo.IgnoreCase);
		}

		// Token: 0x04001B24 RID: 6948
		private int min;

		// Token: 0x04001B25 RID: 6949
		private int max;

		// Token: 0x04001B26 RID: 6950
		private bool lazy;
	}
}
