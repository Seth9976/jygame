using System;

namespace System.Text.RegularExpressions.Syntax
{
	// Token: 0x020004B9 RID: 1209
	internal class RegularExpression : Group
	{
		// Token: 0x06002AEF RID: 10991 RVA: 0x0001DDBF File Offset: 0x0001BFBF
		public RegularExpression()
		{
			this.group_count = 0;
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x0001DDCE File Offset: 0x0001BFCE
		// (set) Token: 0x06002AF1 RID: 10993 RVA: 0x0001DDD6 File Offset: 0x0001BFD6
		public int GroupCount
		{
			get
			{
				return this.group_count;
			}
			set
			{
				this.group_count = value;
			}
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x0008B0C8 File Offset: 0x000892C8
		public override void Compile(ICompiler cmp, bool reverse)
		{
			int num;
			int num2;
			this.GetWidth(out num, out num2);
			cmp.EmitInfo(this.group_count, num, num2);
			AnchorInfo anchorInfo = this.GetAnchorInfo(reverse);
			LinkRef linkRef = cmp.NewLink();
			cmp.EmitAnchor(reverse, anchorInfo.Offset, linkRef);
			if (anchorInfo.IsPosition)
			{
				cmp.EmitPosition(anchorInfo.Position);
			}
			else if (anchorInfo.IsSubstring)
			{
				cmp.EmitString(anchorInfo.Substring, anchorInfo.IgnoreCase, reverse);
			}
			cmp.EmitTrue();
			cmp.ResolveLink(linkRef);
			base.Compile(cmp, reverse);
			cmp.EmitTrue();
		}

		// Token: 0x04001B20 RID: 6944
		private int group_count;
	}
}
