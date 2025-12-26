using System;
using System.Configuration;
using System.Net.Cache;
using System.Xml;

namespace System.Net.Configuration
{
	/// <summary>Represents the configuration section for cache behavior. This class cannot be inherited.</summary>
	// Token: 0x020002EF RID: 751
	public sealed class RequestCachingSection : ConfigurationSection
	{
		// Token: 0x06001961 RID: 6497 RVA: 0x0004C7E4 File Offset: 0x0004A9E4
		static RequestCachingSection()
		{
			RequestCachingSection.properties.Add(RequestCachingSection.defaultFtpCachePolicyProp);
			RequestCachingSection.properties.Add(RequestCachingSection.defaultHttpCachePolicyProp);
			RequestCachingSection.properties.Add(RequestCachingSection.defaultPolicyLevelProp);
			RequestCachingSection.properties.Add(RequestCachingSection.disableAllCachingProp);
			RequestCachingSection.properties.Add(RequestCachingSection.isPrivateCacheProp);
			RequestCachingSection.properties.Add(RequestCachingSection.unspecifiedMaximumAgeProp);
		}

		/// <summary>Gets the default FTP caching behavior for the local computer.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.FtpCachePolicyElement" /> that defines the default cache policy.</returns>
		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x00012C25 File Offset: 0x00010E25
		[ConfigurationProperty("defaultFtpCachePolicy")]
		public FtpCachePolicyElement DefaultFtpCachePolicy
		{
			get
			{
				return (FtpCachePolicyElement)base[RequestCachingSection.defaultFtpCachePolicyProp];
			}
		}

		/// <summary>Gets the default caching behavior for the local computer.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.HttpCachePolicyElement" /> that defines the default cache policy.</returns>
		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001963 RID: 6499 RVA: 0x00012C37 File Offset: 0x00010E37
		[ConfigurationProperty("defaultHttpCachePolicy")]
		public HttpCachePolicyElement DefaultHttpCachePolicy
		{
			get
			{
				return (HttpCachePolicyElement)base[RequestCachingSection.defaultHttpCachePolicyProp];
			}
		}

		/// <summary>Gets or sets the default cache policy level.</summary>
		/// <returns>A <see cref="T:System.Net.Cache.RequestCacheLevel" /> enumeration value.</returns>
		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x00012C49 File Offset: 0x00010E49
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x00012C5B File Offset: 0x00010E5B
		[ConfigurationProperty("defaultPolicyLevel", DefaultValue = "BypassCache")]
		public global::System.Net.Cache.RequestCacheLevel DefaultPolicyLevel
		{
			get
			{
				return (global::System.Net.Cache.RequestCacheLevel)((int)base[RequestCachingSection.defaultPolicyLevelProp]);
			}
			set
			{
				base[RequestCachingSection.defaultPolicyLevelProp] = value;
			}
		}

		/// <summary>Gets or sets a Boolean value that enables caching on the local computer.</summary>
		/// <returns>true if caching is disabled on the local computer; otherwise, false.</returns>
		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x00012C6E File Offset: 0x00010E6E
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x00012C80 File Offset: 0x00010E80
		[ConfigurationProperty("disableAllCaching", DefaultValue = "False")]
		public bool DisableAllCaching
		{
			get
			{
				return (bool)base[RequestCachingSection.disableAllCachingProp];
			}
			set
			{
				base[RequestCachingSection.disableAllCachingProp] = value;
			}
		}

		/// <summary>Gets or sets a Boolean value that indicates whether the local computer cache is private.</summary>
		/// <returns>true if the cache provides user isolation; otherwise, false.</returns>
		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x00012C93 File Offset: 0x00010E93
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x00012CA5 File Offset: 0x00010EA5
		[ConfigurationProperty("isPrivateCache", DefaultValue = "True")]
		public bool IsPrivateCache
		{
			get
			{
				return (bool)base[RequestCachingSection.isPrivateCacheProp];
			}
			set
			{
				base[RequestCachingSection.isPrivateCacheProp] = value;
			}
		}

		/// <summary>Gets or sets a value used as the maximum age for cached resources that do not have expiration information.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> that provides a default maximum age for cached resources.</returns>
		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x00012CB8 File Offset: 0x00010EB8
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x00012CCA File Offset: 0x00010ECA
		[ConfigurationProperty("unspecifiedMaximumAge", DefaultValue = "1.00:00:00")]
		public TimeSpan UnspecifiedMaximumAge
		{
			get
			{
				return (TimeSpan)base[RequestCachingSection.unspecifiedMaximumAgeProp];
			}
			set
			{
				base[RequestCachingSection.unspecifiedMaximumAgeProp] = value;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x00012CDD File Offset: 0x00010EDD
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return RequestCachingSection.properties;
			}
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x00004F1D File Offset: 0x0000311D
		[global::System.MonoTODO]
		protected override void PostDeserialize()
		{
			base.PostDeserialize();
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00012CE4 File Offset: 0x00010EE4
		[global::System.MonoTODO]
		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
			base.DeserializeElement(reader, serializeCollectionKey);
		}

		// Token: 0x04001000 RID: 4096
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

		// Token: 0x04001001 RID: 4097
		private static ConfigurationProperty defaultFtpCachePolicyProp = new ConfigurationProperty("defaultFtpCachePolicy", typeof(FtpCachePolicyElement));

		// Token: 0x04001002 RID: 4098
		private static ConfigurationProperty defaultHttpCachePolicyProp = new ConfigurationProperty("defaultHttpCachePolicy", typeof(HttpCachePolicyElement));

		// Token: 0x04001003 RID: 4099
		private static ConfigurationProperty defaultPolicyLevelProp = new ConfigurationProperty("defaultPolicyLevel", typeof(global::System.Net.Cache.RequestCacheLevel), global::System.Net.Cache.RequestCacheLevel.BypassCache);

		// Token: 0x04001004 RID: 4100
		private static ConfigurationProperty disableAllCachingProp = new ConfigurationProperty("disableAllCaching", typeof(bool), false);

		// Token: 0x04001005 RID: 4101
		private static ConfigurationProperty isPrivateCacheProp = new ConfigurationProperty("isPrivateCache", typeof(bool), true);

		// Token: 0x04001006 RID: 4102
		private static ConfigurationProperty unspecifiedMaximumAgeProp = new ConfigurationProperty("unspecifiedMaximumAge", typeof(TimeSpan), new TimeSpan(1, 0, 0, 0));
	}
}
