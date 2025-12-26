using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the configuration section for Web proxy server usage. This class cannot be inherited.</summary>
	// Token: 0x020002E0 RID: 736
	public sealed class DefaultProxySection : ConfigurationSection
	{
		// Token: 0x06001909 RID: 6409 RVA: 0x0004C088 File Offset: 0x0004A288
		static DefaultProxySection()
		{
			DefaultProxySection.properties.Add(DefaultProxySection.bypassListProp);
			DefaultProxySection.properties.Add(DefaultProxySection.moduleProp);
			DefaultProxySection.properties.Add(DefaultProxySection.proxyProp);
		}

		/// <summary>Gets the collection of resources that are not obtained using the Web proxy server.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.BypassElementCollection" /> that contains the addresses of resources that bypass the Web proxy server. </returns>
		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x0001276C File Offset: 0x0001096C
		[ConfigurationProperty("bypasslist")]
		public BypassElementCollection BypassList
		{
			get
			{
				return (BypassElementCollection)base[DefaultProxySection.bypassListProp];
			}
		}

		/// <summary>Gets or sets whether a Web proxy is used.</summary>
		/// <returns>true if a Web proxy will be used; otherwise, false.</returns>
		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x0600190B RID: 6411 RVA: 0x0001277E File Offset: 0x0001097E
		// (set) Token: 0x0600190C RID: 6412 RVA: 0x00012790 File Offset: 0x00010990
		[ConfigurationProperty("enabled", DefaultValue = "True")]
		public bool Enabled
		{
			get
			{
				return (bool)base[DefaultProxySection.enabledProp];
			}
			set
			{
				base[DefaultProxySection.enabledProp] = value;
			}
		}

		/// <summary>Gets the type information for a custom Web proxy implementation.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.ModuleElement" />. </returns>
		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x0600190D RID: 6413 RVA: 0x000127A3 File Offset: 0x000109A3
		[ConfigurationProperty("module")]
		public ModuleElement Module
		{
			get
			{
				return (ModuleElement)base[DefaultProxySection.moduleProp];
			}
		}

		/// <summary>Gets the URI that identifies the Web proxy server to use.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.ProxyElement" />. </returns>
		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x000127B5 File Offset: 0x000109B5
		[ConfigurationProperty("proxy")]
		public ProxyElement Proxy
		{
			get
			{
				return (ProxyElement)base[DefaultProxySection.proxyProp];
			}
		}

		/// <summary>Gets or sets whether default credentials are to be used to access a Web proxy server.</summary>
		/// <returns>true if default credentials are to be used; otherwise, false.</returns>
		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x000127C7 File Offset: 0x000109C7
		// (set) Token: 0x06001910 RID: 6416 RVA: 0x000127D9 File Offset: 0x000109D9
		[ConfigurationProperty("useDefaultCredentials", DefaultValue = "False")]
		public bool UseDefaultCredentials
		{
			get
			{
				return (bool)base[DefaultProxySection.useDefaultCredentialsProp];
			}
			set
			{
				base[DefaultProxySection.useDefaultCredentialsProp] = value;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x000127EC File Offset: 0x000109EC
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return DefaultProxySection.properties;
			}
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO]
		protected override void PostDeserialize()
		{
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO]
		protected override void Reset(ConfigurationElement parentElement)
		{
		}

		// Token: 0x04000FD6 RID: 4054
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

		// Token: 0x04000FD7 RID: 4055
		private static ConfigurationProperty bypassListProp = new ConfigurationProperty("bypasslist", typeof(BypassElementCollection), null);

		// Token: 0x04000FD8 RID: 4056
		private static ConfigurationProperty enabledProp = new ConfigurationProperty("enabled", typeof(bool), true);

		// Token: 0x04000FD9 RID: 4057
		private static ConfigurationProperty moduleProp = new ConfigurationProperty("module", typeof(ModuleElement), null);

		// Token: 0x04000FDA RID: 4058
		private static ConfigurationProperty proxyProp = new ConfigurationProperty("proxy", typeof(ProxyElement), null);

		// Token: 0x04000FDB RID: 4059
		private static ConfigurationProperty useDefaultCredentialsProp = new ConfigurationProperty("useDefaultCredentials", typeof(bool), false);
	}
}
