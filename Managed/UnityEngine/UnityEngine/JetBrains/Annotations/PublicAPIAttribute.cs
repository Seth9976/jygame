using System;

namespace JetBrains.Annotations
{
	// Token: 0x020002A6 RID: 678
	[MeansImplicitUse]
	public sealed class PublicAPIAttribute : Attribute
	{
		// Token: 0x060020DA RID: 8410 RVA: 0x0000286A File Offset: 0x00000A6A
		public PublicAPIAttribute()
		{
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x0000D106 File Offset: 0x0000B306
		public PublicAPIAttribute([NotNull] string comment)
		{
			this.Comment = comment;
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x0000D115 File Offset: 0x0000B315
		// (set) Token: 0x060020DD RID: 8413 RVA: 0x0000D11D File Offset: 0x0000B31D
		[NotNull]
		public string Comment { get; private set; }
	}
}
