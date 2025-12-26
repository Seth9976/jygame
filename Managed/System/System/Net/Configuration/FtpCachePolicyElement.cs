using System;
using System.Configuration;
using System.Net.Cache;
using System.Xml;

namespace System.Net.Configuration
{
	/// <summary>Represents the default FTP cache policy for network resources. This class cannot be inherited.</summary>
	// Token: 0x020002E1 RID: 737
	public sealed class FtpCachePolicyElement : ConfigurationElement
	{
		// Token: 0x06001915 RID: 6421 RVA: 0x000127F3 File Offset: 0x000109F3
		static FtpCachePolicyElement()
		{
			FtpCachePolicyElement.properties.Add(FtpCachePolicyElement.policyLevelProp);
		}

		/// <summary>Gets or sets FTP caching behavior for the local machine.</summary>
		/// <returns>A <see cref="T:System.Net.Cache.RequestCacheLevel" /> value that specifies the cache behavior.</returns>
		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001916 RID: 6422 RVA: 0x0001282D File Offset: 0x00010A2D
		// (set) Token: 0x06001917 RID: 6423 RVA: 0x0001283F File Offset: 0x00010A3F
		[ConfigurationProperty("policyLevel", DefaultValue = "Default")]
		public global::System.Net.Cache.RequestCacheLevel PolicyLevel
		{
			get
			{
				return (global::System.Net.Cache.RequestCacheLevel)((int)base[FtpCachePolicyElement.policyLevelProp]);
			}
			set
			{
				base[FtpCachePolicyElement.policyLevelProp] = value;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001918 RID: 6424 RVA: 0x00012852 File Offset: 0x00010A52
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return FtpCachePolicyElement.properties;
			}
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x00002664 File Offset: 0x00000864
		[global::System.MonoTODO]
		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x00002664 File Offset: 0x00000864
		[global::System.MonoTODO]
		protected override void Reset(ConfigurationElement parentElement)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000FDC RID: 4060
		private static ConfigurationProperty policyLevelProp = new ConfigurationProperty("policyLevel", typeof(global::System.Net.Cache.RequestCacheLevel), global::System.Net.Cache.RequestCacheLevel.Default);

		// Token: 0x04000FDD RID: 4061
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();
	}
}
