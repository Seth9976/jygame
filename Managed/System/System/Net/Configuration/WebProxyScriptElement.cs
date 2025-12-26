using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents information used to configure Web proxy scripts. This class cannot be inherited.</summary>
	// Token: 0x020002F6 RID: 758
	public sealed class WebProxyScriptElement : ConfigurationElement
	{
		// Token: 0x060019AA RID: 6570 RVA: 0x0004CBC0 File Offset: 0x0004ADC0
		static WebProxyScriptElement()
		{
			WebProxyScriptElement.properties.Add(WebProxyScriptElement.downloadTimeoutProp);
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x000029F5 File Offset: 0x00000BF5
		protected override void PostDeserialize()
		{
		}

		/// <summary>Gets or sets the Web proxy script download timeout using the format hours:minutes:seconds.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> object that contains the timeout value. The default download timeout is one minute.</returns>
		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x00013005 File Offset: 0x00011205
		// (set) Token: 0x060019AD RID: 6573 RVA: 0x00013017 File Offset: 0x00011217
		[ConfigurationProperty("downloadTimeout", DefaultValue = "00:02:00")]
		public TimeSpan DownloadTimeout
		{
			get
			{
				return (TimeSpan)base[WebProxyScriptElement.downloadTimeoutProp];
			}
			set
			{
				base[WebProxyScriptElement.downloadTimeoutProp] = value;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x0001302A File Offset: 0x0001122A
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return WebProxyScriptElement.properties;
			}
		}

		// Token: 0x0400101A RID: 4122
		private static ConfigurationProperty downloadTimeoutProp = new ConfigurationProperty("downloadTimeout", typeof(TimeSpan), new TimeSpan(0, 0, 2, 0));

		// Token: 0x0400101B RID: 4123
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();
	}
}
