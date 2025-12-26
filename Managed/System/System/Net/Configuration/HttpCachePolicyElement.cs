using System;
using System.Configuration;
using System.Net.Cache;
using System.Xml;

namespace System.Net.Configuration
{
	/// <summary>Represents the default HTTP cache policy for network resources. This class cannot be inherited.</summary>
	// Token: 0x020002E2 RID: 738
	public sealed class HttpCachePolicyElement : ConfigurationElement
	{
		// Token: 0x0600191C RID: 6428 RVA: 0x0004C158 File Offset: 0x0004A358
		static HttpCachePolicyElement()
		{
			HttpCachePolicyElement.properties.Add(HttpCachePolicyElement.maximumAgeProp);
			HttpCachePolicyElement.properties.Add(HttpCachePolicyElement.maximumStaleProp);
			HttpCachePolicyElement.properties.Add(HttpCachePolicyElement.minimumFreshProp);
			HttpCachePolicyElement.properties.Add(HttpCachePolicyElement.policyLevelProp);
		}

		/// <summary>Gets or sets the maximum age permitted for a resource returned from the cache.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> value that specifies the maximum age for cached resources specified in the configuration file.</returns>
		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x0600191D RID: 6429 RVA: 0x00012859 File Offset: 0x00010A59
		// (set) Token: 0x0600191E RID: 6430 RVA: 0x0001286B File Offset: 0x00010A6B
		[ConfigurationProperty("maximumAge", DefaultValue = "10675199.02:48:05.4775807")]
		public TimeSpan MaximumAge
		{
			get
			{
				return (TimeSpan)base[HttpCachePolicyElement.maximumAgeProp];
			}
			set
			{
				base[HttpCachePolicyElement.maximumAgeProp] = value;
			}
		}

		/// <summary>Gets or sets the maximum staleness value permitted for a resource returned from the cache.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> value that is set to the maximum staleness value specified in the configuration file.</returns>
		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x0600191F RID: 6431 RVA: 0x0001287E File Offset: 0x00010A7E
		// (set) Token: 0x06001920 RID: 6432 RVA: 0x00012890 File Offset: 0x00010A90
		[ConfigurationProperty("maximumStale", DefaultValue = "-10675199.02:48:05.4775808")]
		public TimeSpan MaximumStale
		{
			get
			{
				return (TimeSpan)base[HttpCachePolicyElement.maximumStaleProp];
			}
			set
			{
				base[HttpCachePolicyElement.maximumStaleProp] = value;
			}
		}

		/// <summary>Gets or sets the minimum freshness permitted for a resource returned from the cache.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> value that specifies the minimum freshness specified in the configuration file.</returns>
		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x000128A3 File Offset: 0x00010AA3
		// (set) Token: 0x06001922 RID: 6434 RVA: 0x000128B5 File Offset: 0x00010AB5
		[ConfigurationProperty("minimumFresh", DefaultValue = "-10675199.02:48:05.4775808")]
		public TimeSpan MinimumFresh
		{
			get
			{
				return (TimeSpan)base[HttpCachePolicyElement.minimumFreshProp];
			}
			set
			{
				base[HttpCachePolicyElement.minimumFreshProp] = value;
			}
		}

		/// <summary>Gets or sets HTTP caching behavior for the local machine.</summary>
		/// <returns>A <see cref="T:System.Net.Cache.HttpRequestCacheLevel" /> value that specifies the cache behavior.</returns>
		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x000128C8 File Offset: 0x00010AC8
		// (set) Token: 0x06001924 RID: 6436 RVA: 0x000128DA File Offset: 0x00010ADA
		[ConfigurationProperty("policyLevel", DefaultValue = "Default", Options = ConfigurationPropertyOptions.IsRequired)]
		public global::System.Net.Cache.HttpRequestCacheLevel PolicyLevel
		{
			get
			{
				return (global::System.Net.Cache.HttpRequestCacheLevel)((int)base[HttpCachePolicyElement.policyLevelProp]);
			}
			set
			{
				base[HttpCachePolicyElement.policyLevelProp] = value;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001925 RID: 6437 RVA: 0x000128ED File Offset: 0x00010AED
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return HttpCachePolicyElement.properties;
			}
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00002664 File Offset: 0x00000864
		[global::System.MonoTODO]
		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x00002664 File Offset: 0x00000864
		[global::System.MonoTODO]
		protected override void Reset(ConfigurationElement parentElement)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000FDE RID: 4062
		private static ConfigurationProperty maximumAgeProp = new ConfigurationProperty("maximumAge", typeof(TimeSpan), TimeSpan.MaxValue);

		// Token: 0x04000FDF RID: 4063
		private static ConfigurationProperty maximumStaleProp = new ConfigurationProperty("maximumStale", typeof(TimeSpan), TimeSpan.MinValue);

		// Token: 0x04000FE0 RID: 4064
		private static ConfigurationProperty minimumFreshProp = new ConfigurationProperty("minimumFresh", typeof(TimeSpan), TimeSpan.MinValue);

		// Token: 0x04000FE1 RID: 4065
		private static ConfigurationProperty policyLevelProp = new ConfigurationProperty("policyLevel", typeof(global::System.Net.Cache.HttpRequestCacheLevel), global::System.Net.Cache.HttpRequestCacheLevel.Default, ConfigurationPropertyOptions.IsRequired);

		// Token: 0x04000FE2 RID: 4066
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();
	}
}
