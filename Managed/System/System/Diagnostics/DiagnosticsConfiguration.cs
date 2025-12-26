using System;
using System.Collections;
using System.Configuration;
using System.Threading;

namespace System.Diagnostics
{
	// Token: 0x0200021E RID: 542
	internal sealed class DiagnosticsConfiguration
	{
		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x0003CDD4 File Offset: 0x0003AFD4
		public static IDictionary Settings
		{
			get
			{
				if (DiagnosticsConfiguration.settings == null)
				{
					object config = global::System.Configuration.ConfigurationSettings.GetConfig("system.diagnostics");
					if (config == null)
					{
						throw new Exception("INTERNAL configuration error: failed to get configuration 'system.diagnostics'");
					}
					Thread.MemoryBarrier();
					while (Interlocked.CompareExchange(ref DiagnosticsConfiguration.settings, config, null) == null)
					{
					}
					Thread.MemoryBarrier();
				}
				return (IDictionary)DiagnosticsConfiguration.settings;
			}
		}

		// Token: 0x0400053A RID: 1338
		private static object settings;
	}
}
