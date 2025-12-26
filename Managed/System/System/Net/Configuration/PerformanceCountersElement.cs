using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the performance counter element in the System.Net configuration file that determines whether the usage of performance counters is enabled. This class cannot be inherited.</summary>
	// Token: 0x020002EA RID: 746
	public sealed class PerformanceCountersElement : ConfigurationElement
	{
		// Token: 0x0600194F RID: 6479 RVA: 0x00012B09 File Offset: 0x00010D09
		static PerformanceCountersElement()
		{
			PerformanceCountersElement.properties.Add(PerformanceCountersElement.enabledProp);
		}

		/// <summary>Gets or sets whether performance counters are enabled.</summary>
		/// <returns>true if performance counters are enabled; otherwise, false.</returns>
		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x00012B43 File Offset: 0x00010D43
		// (set) Token: 0x06001951 RID: 6481 RVA: 0x00012B55 File Offset: 0x00010D55
		[ConfigurationProperty("enabled", DefaultValue = "False")]
		public bool Enabled
		{
			get
			{
				return (bool)base[PerformanceCountersElement.enabledProp];
			}
			set
			{
				base[PerformanceCountersElement.enabledProp] = value;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x00012B68 File Offset: 0x00010D68
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return PerformanceCountersElement.properties;
			}
		}

		// Token: 0x04000FEC RID: 4076
		private static ConfigurationProperty enabledProp = new ConfigurationProperty("enabled", typeof(bool), false);

		// Token: 0x04000FED RID: 4077
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();
	}
}
