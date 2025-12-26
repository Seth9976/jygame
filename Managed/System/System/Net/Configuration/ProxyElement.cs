using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Identifies the configuration settings for Web proxy server. This class cannot be inherited.</summary>
	// Token: 0x020002EB RID: 747
	public sealed class ProxyElement : ConfigurationElement
	{
		// Token: 0x06001954 RID: 6484 RVA: 0x0004C700 File Offset: 0x0004A900
		static ProxyElement()
		{
			ProxyElement.properties.Add(ProxyElement.bypassOnLocalProp);
			ProxyElement.properties.Add(ProxyElement.proxyAddressProp);
			ProxyElement.properties.Add(ProxyElement.scriptLocationProp);
			ProxyElement.properties.Add(ProxyElement.useSystemDefaultProp);
		}

		/// <summary>Gets and sets an <see cref="T:System.Net.Configuration.ProxyElement.AutoDetectValues" /> value that controls whether the Web proxy is automatically detected.</summary>
		/// <returns>
		///   <see cref="F:System.Net.Configuration.ProxyElement.AutoDetectValues.True" /> if the <see cref="T:System.Net.WebProxy" /> is automatically detected; <see cref="F:System.Net.Configuration.ProxyElement.AutoDetectValues.False" /> if the <see cref="T:System.Net.WebProxy" /> is not automatically detected; or <see cref="F:System.Net.Configuration.ProxyElement.AutoDetectValues.Unspecified" />.</returns>
		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001955 RID: 6485 RVA: 0x00012B6F File Offset: 0x00010D6F
		// (set) Token: 0x06001956 RID: 6486 RVA: 0x00012B81 File Offset: 0x00010D81
		[ConfigurationProperty("autoDetect", DefaultValue = "Unspecified")]
		public ProxyElement.AutoDetectValues AutoDetect
		{
			get
			{
				return (ProxyElement.AutoDetectValues)((int)base[ProxyElement.autoDetectProp]);
			}
			set
			{
				base[ProxyElement.autoDetectProp] = value;
			}
		}

		/// <summary>Gets and sets a value that indicates whether local resources are retrieved by using a Web proxy server.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.ProxyElement.BypassOnLocalValues" />.</returns>
		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001957 RID: 6487 RVA: 0x00012B94 File Offset: 0x00010D94
		// (set) Token: 0x06001958 RID: 6488 RVA: 0x00012BA6 File Offset: 0x00010DA6
		[ConfigurationProperty("bypassonlocal", DefaultValue = "Unspecified")]
		public ProxyElement.BypassOnLocalValues BypassOnLocal
		{
			get
			{
				return (ProxyElement.BypassOnLocalValues)((int)base[ProxyElement.bypassOnLocalProp]);
			}
			set
			{
				base[ProxyElement.bypassOnLocalProp] = value;
			}
		}

		/// <summary>Gets and sets the URI that identifies the Web proxy server to use.</summary>
		/// <returns>A <see cref="T:System.String" /> containing a URI.</returns>
		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x00012BB9 File Offset: 0x00010DB9
		// (set) Token: 0x0600195A RID: 6490 RVA: 0x00012BCB File Offset: 0x00010DCB
		[ConfigurationProperty("proxyaddress")]
		public global::System.Uri ProxyAddress
		{
			get
			{
				return (global::System.Uri)base[ProxyElement.proxyAddressProp];
			}
			set
			{
				base[ProxyElement.proxyAddressProp] = value;
			}
		}

		/// <summary>Gets and sets an <see cref="T:System.Uri" /> value that specifies the location of the automatic proxy detection script.</summary>
		/// <returns>A <see cref="T:System.Uri" /> specifying the location of the automatic proxy detection script.</returns>
		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x00012BD9 File Offset: 0x00010DD9
		// (set) Token: 0x0600195C RID: 6492 RVA: 0x00012BEB File Offset: 0x00010DEB
		[ConfigurationProperty("scriptLocation")]
		public global::System.Uri ScriptLocation
		{
			get
			{
				return (global::System.Uri)base[ProxyElement.scriptLocationProp];
			}
			set
			{
				base[ProxyElement.scriptLocationProp] = value;
			}
		}

		/// <summary>Gets and sets a <see cref="T:System.Boolean" /> value that controls whether the Internet Explorer Web proxy settings are used.</summary>
		/// <returns>true if the Internet Explorer LAN settings are used to detect and configure the default <see cref="T:System.Net.WebProxy" /> used for requests; otherwise, false.</returns>
		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x00012BF9 File Offset: 0x00010DF9
		// (set) Token: 0x0600195E RID: 6494 RVA: 0x00012C0B File Offset: 0x00010E0B
		[ConfigurationProperty("usesystemdefault", DefaultValue = "Unspecified")]
		public ProxyElement.UseSystemDefaultValues UseSystemDefault
		{
			get
			{
				return (ProxyElement.UseSystemDefaultValues)((int)base[ProxyElement.useSystemDefaultProp]);
			}
			set
			{
				base[ProxyElement.useSystemDefaultProp] = value;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x0600195F RID: 6495 RVA: 0x00012C1E File Offset: 0x00010E1E
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return ProxyElement.properties;
			}
		}

		// Token: 0x04000FEE RID: 4078
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

		// Token: 0x04000FEF RID: 4079
		private static ConfigurationProperty autoDetectProp = new ConfigurationProperty("autoDetect", typeof(ProxyElement.AutoDetectValues), ProxyElement.AutoDetectValues.Unspecified);

		// Token: 0x04000FF0 RID: 4080
		private static ConfigurationProperty bypassOnLocalProp = new ConfigurationProperty("bypassonlocal", typeof(ProxyElement.BypassOnLocalValues), ProxyElement.BypassOnLocalValues.Unspecified);

		// Token: 0x04000FF1 RID: 4081
		private static ConfigurationProperty proxyAddressProp = new ConfigurationProperty("proxyaddress", typeof(global::System.Uri), null);

		// Token: 0x04000FF2 RID: 4082
		private static ConfigurationProperty scriptLocationProp = new ConfigurationProperty("scriptLocation", typeof(global::System.Uri), null);

		// Token: 0x04000FF3 RID: 4083
		private static ConfigurationProperty useSystemDefaultProp = new ConfigurationProperty("UseSystemDefault", typeof(ProxyElement.UseSystemDefaultValues), ProxyElement.UseSystemDefaultValues.Unspecified);

		/// <summary>Specifies whether the proxy is bypassed for local resources.</summary>
		// Token: 0x020002EC RID: 748
		public enum BypassOnLocalValues
		{
			/// <summary>Unspecified.</summary>
			// Token: 0x04000FF5 RID: 4085
			Unspecified = -1,
			/// <summary>Access local resources directly.</summary>
			// Token: 0x04000FF6 RID: 4086
			True = 1,
			/// <summary>All requests for local resources should go through the proxy</summary>
			// Token: 0x04000FF7 RID: 4087
			False = 0
		}

		/// <summary>Specifies whether to use the local system proxy settings to determine whether the proxy is bypassed for local resources.</summary>
		// Token: 0x020002ED RID: 749
		public enum UseSystemDefaultValues
		{
			/// <summary>The system default proxy setting is unspecified.</summary>
			// Token: 0x04000FF9 RID: 4089
			Unspecified = -1,
			/// <summary>Use system default proxy setting values.</summary>
			// Token: 0x04000FFA RID: 4090
			True = 1,
			/// <summary>Do not use system default proxy setting values</summary>
			// Token: 0x04000FFB RID: 4091
			False = 0
		}

		/// <summary>Specifies whether the proxy is automatically detected.</summary>
		// Token: 0x020002EE RID: 750
		public enum AutoDetectValues
		{
			/// <summary>Unspecified.</summary>
			// Token: 0x04000FFD RID: 4093
			Unspecified = -1,
			/// <summary>The proxy is automatically detected.</summary>
			// Token: 0x04000FFE RID: 4094
			True = 1,
			/// <summary>The proxy is not automatically detected.</summary>
			// Token: 0x04000FFF RID: 4095
			False = 0
		}
	}
}
