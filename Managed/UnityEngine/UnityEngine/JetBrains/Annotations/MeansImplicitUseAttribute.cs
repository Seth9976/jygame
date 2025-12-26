using System;

namespace JetBrains.Annotations
{
	// Token: 0x020002A3 RID: 675
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class MeansImplicitUseAttribute : Attribute
	{
		// Token: 0x060020D2 RID: 8402 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		public MeansImplicitUseAttribute()
			: this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x0000D0BA File Offset: 0x0000B2BA
		public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
			: this(useKindFlags, ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x0000D0C4 File Offset: 0x0000B2C4
		public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
			: this(ImplicitUseKindFlags.Default, targetFlags)
		{
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x0000D0CE File Offset: 0x0000B2CE
		public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
		{
			this.UseKindFlags = useKindFlags;
			this.TargetFlags = targetFlags;
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x060020D6 RID: 8406 RVA: 0x0000D0E4 File Offset: 0x0000B2E4
		// (set) Token: 0x060020D7 RID: 8407 RVA: 0x0000D0EC File Offset: 0x0000B2EC
		[UsedImplicitly]
		public ImplicitUseKindFlags UseKindFlags { get; private set; }

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x0000D0F5 File Offset: 0x0000B2F5
		// (set) Token: 0x060020D9 RID: 8409 RVA: 0x0000D0FD File Offset: 0x0000B2FD
		[UsedImplicitly]
		public ImplicitUseTargetFlags TargetFlags { get; private set; }
	}
}
