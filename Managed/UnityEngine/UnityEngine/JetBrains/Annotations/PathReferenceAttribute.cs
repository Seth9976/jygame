using System;

namespace JetBrains.Annotations
{
	// Token: 0x020002A9 RID: 681
	[AttributeUsage(AttributeTargets.Parameter)]
	public class PathReferenceAttribute : Attribute
	{
		// Token: 0x060020E0 RID: 8416 RVA: 0x0000286A File Offset: 0x00000A6A
		public PathReferenceAttribute()
		{
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x0000D126 File Offset: 0x0000B326
		public PathReferenceAttribute([PathReference] string basePath)
		{
			this.BasePath = basePath;
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x0000D135 File Offset: 0x0000B335
		// (set) Token: 0x060020E3 RID: 8419 RVA: 0x0000D13D File Offset: 0x0000B33D
		[NotNull]
		public string BasePath { get; private set; }
	}
}
