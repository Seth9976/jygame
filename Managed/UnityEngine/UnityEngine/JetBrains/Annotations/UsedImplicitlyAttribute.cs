using System;

namespace JetBrains.Annotations
{
	// Token: 0x020002A2 RID: 674
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class UsedImplicitlyAttribute : Attribute
	{
		// Token: 0x060020CA RID: 8394 RVA: 0x0000D05A File Offset: 0x0000B25A
		public UsedImplicitlyAttribute()
			: this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x0000D064 File Offset: 0x0000B264
		public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
			: this(useKindFlags, ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x0000D06E File Offset: 0x0000B26E
		public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
			: this(ImplicitUseKindFlags.Default, targetFlags)
		{
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x0000D078 File Offset: 0x0000B278
		public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
		{
			this.UseKindFlags = useKindFlags;
			this.TargetFlags = targetFlags;
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x0000D08E File Offset: 0x0000B28E
		// (set) Token: 0x060020CF RID: 8399 RVA: 0x0000D096 File Offset: 0x0000B296
		public ImplicitUseKindFlags UseKindFlags { get; private set; }

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x0000D09F File Offset: 0x0000B29F
		// (set) Token: 0x060020D1 RID: 8401 RVA: 0x0000D0A7 File Offset: 0x0000B2A7
		public ImplicitUseTargetFlags TargetFlags { get; private set; }
	}
}
