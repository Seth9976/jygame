using System;
using System.Collections;

namespace System.Configuration
{
	/// <summary>Provides contextual information that the provider can use when persisting settings.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x020001F6 RID: 502
	[Serializable]
	public class SettingsContext : Hashtable
	{
		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x0000DF35 File Offset: 0x0000C135
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x0000DF3D File Offset: 0x0000C13D
		internal ApplicationSettingsBase CurrentSettings
		{
			get
			{
				return this.current;
			}
			set
			{
				this.current = value;
			}
		}

		// Token: 0x040004EF RID: 1263
		[NonSerialized]
		private ApplicationSettingsBase current;
	}
}
