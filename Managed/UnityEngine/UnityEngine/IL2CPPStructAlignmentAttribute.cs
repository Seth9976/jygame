using System;

namespace UnityEngine
{
	// Token: 0x02000245 RID: 581
	[AttributeUsage(AttributeTargets.Struct)]
	internal class IL2CPPStructAlignmentAttribute : Attribute
	{
		// Token: 0x0600205D RID: 8285 RVA: 0x0000CC2C File Offset: 0x0000AE2C
		public IL2CPPStructAlignmentAttribute()
		{
			this.Align = 1;
		}

		// Token: 0x040008D1 RID: 2257
		public int Align;
	}
}
