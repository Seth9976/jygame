using System;

namespace JetBrains.Annotations
{
	// Token: 0x0200029F RID: 671
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class LocalizationRequiredAttribute : Attribute
	{
		// Token: 0x060020C2 RID: 8386 RVA: 0x0000D011 File Offset: 0x0000B211
		public LocalizationRequiredAttribute()
			: this(true)
		{
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x0000D01A File Offset: 0x0000B21A
		public LocalizationRequiredAttribute(bool required)
		{
			this.Required = required;
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x0000D029 File Offset: 0x0000B229
		// (set) Token: 0x060020C5 RID: 8389 RVA: 0x0000D031 File Offset: 0x0000B231
		public bool Required { get; private set; }
	}
}
