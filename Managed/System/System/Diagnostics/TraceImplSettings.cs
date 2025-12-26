using System;

namespace System.Diagnostics
{
	// Token: 0x02000263 RID: 611
	internal class TraceImplSettings
	{
		// Token: 0x06001557 RID: 5463 RVA: 0x000106BE File Offset: 0x0000E8BE
		public TraceImplSettings()
		{
			this.Listeners.Add(new DefaultTraceListener(), this);
		}

		// Token: 0x040006A1 RID: 1697
		public const string Key = ".__TraceInfoSettingsKey__.";

		// Token: 0x040006A2 RID: 1698
		public bool AutoFlush;

		// Token: 0x040006A3 RID: 1699
		public int IndentLevel;

		// Token: 0x040006A4 RID: 1700
		public int IndentSize = 4;

		// Token: 0x040006A5 RID: 1701
		public TraceListenerCollection Listeners = new TraceListenerCollection(false);
	}
}
