using System;
using System.ComponentModel;

namespace System
{
	// Token: 0x0200047D RID: 1149
	[AttributeUsage(AttributeTargets.All)]
	internal class SRDescriptionAttribute : global::System.ComponentModel.DescriptionAttribute
	{
		// Token: 0x060028BB RID: 10427 RVA: 0x0000F60E File Offset: 0x0000D80E
		public SRDescriptionAttribute(string description)
			: base(description)
		{
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x060028BC RID: 10428 RVA: 0x0001C66C File Offset: 0x0001A86C
		public override string Description
		{
			get
			{
				if (!this.isReplaced)
				{
					this.isReplaced = true;
					base.DescriptionValue = global::Locale.GetText(base.DescriptionValue);
				}
				return base.DescriptionValue;
			}
		}

		// Token: 0x040018F3 RID: 6387
		private bool isReplaced;
	}
}
