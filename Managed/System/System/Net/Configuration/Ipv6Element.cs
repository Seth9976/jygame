using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Determines whether Internet Protocol version 6 is enabled on the local computer. This class cannot be inherited.</summary>
	// Token: 0x020002E4 RID: 740
	public sealed class Ipv6Element : ConfigurationElement
	{
		// Token: 0x06001935 RID: 6453 RVA: 0x0001298F File Offset: 0x00010B8F
		static Ipv6Element()
		{
			Ipv6Element.properties.Add(Ipv6Element.enabledProp);
		}

		/// <summary>Gets or sets a Boolean value that indicates whether Internet Protocol version 6 is enabled on the local computer.</summary>
		/// <returns>true if IPv6 is enabled; otherwise, false.</returns>
		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x000129C9 File Offset: 0x00010BC9
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x000129DB File Offset: 0x00010BDB
		[ConfigurationProperty("enabled", DefaultValue = "False")]
		public bool Enabled
		{
			get
			{
				return (bool)base[Ipv6Element.enabledProp];
			}
			set
			{
				base[Ipv6Element.enabledProp] = value;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x000129EE File Offset: 0x00010BEE
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return Ipv6Element.properties;
			}
		}

		// Token: 0x04000FE8 RID: 4072
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

		// Token: 0x04000FE9 RID: 4073
		private static ConfigurationProperty enabledProp = new ConfigurationProperty("enabled", typeof(bool), false);
	}
}
