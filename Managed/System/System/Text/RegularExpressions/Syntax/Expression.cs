using System;

namespace System.Text.RegularExpressions.Syntax
{
	// Token: 0x020004B6 RID: 1206
	internal abstract class Expression
	{
		// Token: 0x06002ADF RID: 10975
		public abstract void Compile(ICompiler cmp, bool reverse);

		// Token: 0x06002AE0 RID: 10976
		public abstract void GetWidth(out int min, out int max);

		// Token: 0x06002AE1 RID: 10977 RVA: 0x0008AC08 File Offset: 0x00088E08
		public int GetFixedWidth()
		{
			int num;
			int num2;
			this.GetWidth(out num, out num2);
			if (num == num2)
			{
				return num;
			}
			return -1;
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x0001DD63 File Offset: 0x0001BF63
		public virtual AnchorInfo GetAnchorInfo(bool reverse)
		{
			return new AnchorInfo(this, this.GetFixedWidth());
		}

		// Token: 0x06002AE3 RID: 10979
		public abstract bool IsComplex();
	}
}
