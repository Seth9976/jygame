using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the default settings used to create connections to a remote computer. This class cannot be inherited.</summary>
	// Token: 0x020002F0 RID: 752
	public sealed class ServicePointManagerElement : ConfigurationElement
	{
		// Token: 0x06001970 RID: 6512 RVA: 0x0004C90C File Offset: 0x0004AB0C
		static ServicePointManagerElement()
		{
			ServicePointManagerElement.properties.Add(ServicePointManagerElement.checkCertificateNameProp);
			ServicePointManagerElement.properties.Add(ServicePointManagerElement.checkCertificateRevocationListProp);
			ServicePointManagerElement.properties.Add(ServicePointManagerElement.dnsRefreshTimeoutProp);
			ServicePointManagerElement.properties.Add(ServicePointManagerElement.enableDnsRoundRobinProp);
			ServicePointManagerElement.properties.Add(ServicePointManagerElement.expect100ContinueProp);
			ServicePointManagerElement.properties.Add(ServicePointManagerElement.useNagleAlgorithmProp);
		}

		/// <summary>Gets or sets a Boolean value that controls checking host name information in an X509 certificate.</summary>
		/// <returns>true to specify host name checking; otherwise, false. </returns>
		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x00012CEE File Offset: 0x00010EEE
		// (set) Token: 0x06001972 RID: 6514 RVA: 0x00012D00 File Offset: 0x00010F00
		[ConfigurationProperty("checkCertificateName", DefaultValue = "True")]
		public bool CheckCertificateName
		{
			get
			{
				return (bool)base[ServicePointManagerElement.checkCertificateNameProp];
			}
			set
			{
				base[ServicePointManagerElement.checkCertificateNameProp] = value;
			}
		}

		/// <summary>Gets or sets a Boolean value that indicates whether the certificate is checked against the certificate authority revocation list.</summary>
		/// <returns>true if the certificate revocation list is checked; otherwise, false.The default value is false.</returns>
		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x00012D13 File Offset: 0x00010F13
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x00012D25 File Offset: 0x00010F25
		[ConfigurationProperty("checkCertificateRevocationList", DefaultValue = "False")]
		public bool CheckCertificateRevocationList
		{
			get
			{
				return (bool)base[ServicePointManagerElement.checkCertificateRevocationListProp];
			}
			set
			{
				base[ServicePointManagerElement.checkCertificateRevocationListProp] = value;
			}
		}

		/// <summary>Gets or sets the amount of time after which address information is refreshed.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> that specifies when addresses are resolved using DNS.</returns>
		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x00012D38 File Offset: 0x00010F38
		// (set) Token: 0x06001976 RID: 6518 RVA: 0x00012D4A File Offset: 0x00010F4A
		[ConfigurationProperty("dnsRefreshTimeout", DefaultValue = "120000")]
		public int DnsRefreshTimeout
		{
			get
			{
				return (int)base[ServicePointManagerElement.dnsRefreshTimeoutProp];
			}
			set
			{
				base[ServicePointManagerElement.dnsRefreshTimeoutProp] = value;
			}
		}

		/// <summary>Gets or sets a Boolean value that controls using different IP addresses on connections to the same server.</summary>
		/// <returns>true to enable DNS round-robin behavior; otherwise, false.</returns>
		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x00012D5D File Offset: 0x00010F5D
		// (set) Token: 0x06001978 RID: 6520 RVA: 0x00012D6F File Offset: 0x00010F6F
		[ConfigurationProperty("enableDnsRoundRobin", DefaultValue = "False")]
		public bool EnableDnsRoundRobin
		{
			get
			{
				return (bool)base[ServicePointManagerElement.enableDnsRoundRobinProp];
			}
			set
			{
				base[ServicePointManagerElement.enableDnsRoundRobinProp] = value;
			}
		}

		/// <summary>Gets or sets a Boolean value that determines whether 100-Continue behavior is used.</summary>
		/// <returns>true to expect 100-Continue responses for POST requests; otherwise, false. The default value is true.</returns>
		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x00012D82 File Offset: 0x00010F82
		// (set) Token: 0x0600197A RID: 6522 RVA: 0x00012D94 File Offset: 0x00010F94
		[ConfigurationProperty("expect100Continue", DefaultValue = "True")]
		public bool Expect100Continue
		{
			get
			{
				return (bool)base[ServicePointManagerElement.expect100ContinueProp];
			}
			set
			{
				base[ServicePointManagerElement.expect100ContinueProp] = value;
			}
		}

		/// <summary>Gets or sets a Boolean value that determines whether the Nagle algorithm is used.</summary>
		/// <returns>true to use the Nagle algorithm; otherwise, false. The default value is true.</returns>
		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x00012DA7 File Offset: 0x00010FA7
		// (set) Token: 0x0600197C RID: 6524 RVA: 0x00012DB9 File Offset: 0x00010FB9
		[ConfigurationProperty("useNagleAlgorithm", DefaultValue = "True")]
		public bool UseNagleAlgorithm
		{
			get
			{
				return (bool)base[ServicePointManagerElement.useNagleAlgorithmProp];
			}
			set
			{
				base[ServicePointManagerElement.useNagleAlgorithmProp] = value;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x0600197D RID: 6525 RVA: 0x00012DCC File Offset: 0x00010FCC
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return ServicePointManagerElement.properties;
			}
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO]
		protected override void PostDeserialize()
		{
		}

		// Token: 0x04001007 RID: 4103
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

		// Token: 0x04001008 RID: 4104
		private static ConfigurationProperty checkCertificateNameProp = new ConfigurationProperty("checkCertificateName", typeof(bool), true);

		// Token: 0x04001009 RID: 4105
		private static ConfigurationProperty checkCertificateRevocationListProp = new ConfigurationProperty("checkCertificateRevocationList", typeof(bool), false);

		// Token: 0x0400100A RID: 4106
		private static ConfigurationProperty dnsRefreshTimeoutProp = new ConfigurationProperty("dnsRefreshTimeout", typeof(int), 120000);

		// Token: 0x0400100B RID: 4107
		private static ConfigurationProperty enableDnsRoundRobinProp = new ConfigurationProperty("enableDnsRoundRobin", typeof(bool), false);

		// Token: 0x0400100C RID: 4108
		private static ConfigurationProperty expect100ContinueProp = new ConfigurationProperty("expect100Continue", typeof(bool), true);

		// Token: 0x0400100D RID: 4109
		private static ConfigurationProperty useNagleAlgorithmProp = new ConfigurationProperty("useNagleAlgorithm", typeof(bool), true);
	}
}
