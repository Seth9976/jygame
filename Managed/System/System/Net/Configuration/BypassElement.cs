using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the address information for resources that are not retrieved using a proxy server. This class cannot be inherited.</summary>
	// Token: 0x020002D8 RID: 728
	public sealed class BypassElement : ConfigurationElement
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.BypassElement" /> class. </summary>
		// Token: 0x060018D9 RID: 6361 RVA: 0x000056FB File Offset: 0x000038FB
		public BypassElement()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.BypassElement" /> class with the specified type information.</summary>
		/// <param name="address">A string that identifies the address of a resource.</param>
		// Token: 0x060018DA RID: 6362 RVA: 0x00012564 File Offset: 0x00010764
		public BypassElement(string address)
		{
			this.Address = address;
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x00012573 File Offset: 0x00010773
		static BypassElement()
		{
			BypassElement.properties.Add(BypassElement.addressProp);
		}

		/// <summary>Gets or sets the addresses of resources that bypass the proxy server.</summary>
		/// <returns>A string that identifies a resource.</returns>
		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x000125A9 File Offset: 0x000107A9
		// (set) Token: 0x060018DD RID: 6365 RVA: 0x000125BB File Offset: 0x000107BB
		[ConfigurationProperty("address", Options = ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey)]
		public string Address
		{
			get
			{
				return (string)base[BypassElement.addressProp];
			}
			set
			{
				base[BypassElement.addressProp] = value;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x060018DE RID: 6366 RVA: 0x000125C9 File Offset: 0x000107C9
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return BypassElement.properties;
			}
		}

		// Token: 0x04000FCD RID: 4045
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

		// Token: 0x04000FCE RID: 4046
		private static ConfigurationProperty addressProp = new ConfigurationProperty("Address", typeof(string), null, ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey);
	}
}
