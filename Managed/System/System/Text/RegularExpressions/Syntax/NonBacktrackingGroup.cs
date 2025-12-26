using System;

namespace System.Text.RegularExpressions.Syntax
{
	// Token: 0x020004BC RID: 1212
	internal class NonBacktrackingGroup : Group
	{
		// Token: 0x06002B01 RID: 11009 RVA: 0x0008B1F0 File Offset: 0x000893F0
		public override void Compile(ICompiler cmp, bool reverse)
		{
			LinkRef linkRef = cmp.NewLink();
			cmp.EmitSub(linkRef);
			base.Compile(cmp, reverse);
			cmp.EmitTrue();
			cmp.ResolveLink(linkRef);
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x000025B7 File Offset: 0x000007B7
		public override bool IsComplex()
		{
			return true;
		}
	}
}
