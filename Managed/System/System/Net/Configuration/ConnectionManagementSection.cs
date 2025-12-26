using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the configuration section for connection management. This class cannot be inherited.</summary>
	// Token: 0x020002DE RID: 734
	public sealed class ConnectionManagementSection : ConfigurationSection
	{
		// Token: 0x06001902 RID: 6402 RVA: 0x0001271D File Offset: 0x0001091D
		static ConnectionManagementSection()
		{
			ConnectionManagementSection.properties.Add(ConnectionManagementSection.connectionManagementProp);
		}

		/// <summary>Gets the collection of connection management objects in the section.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.ConnectionManagementElementCollection" /> that contains the connection management information for the local computer. </returns>
		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001903 RID: 6403 RVA: 0x00012753 File Offset: 0x00010953
		[ConfigurationProperty("", Options = ConfigurationPropertyOptions.IsDefaultCollection)]
		public ConnectionManagementElementCollection ConnectionManagement
		{
			get
			{
				return (ConnectionManagementElementCollection)base[ConnectionManagementSection.connectionManagementProp];
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x00012765 File Offset: 0x00010965
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return ConnectionManagementSection.properties;
			}
		}

		// Token: 0x04000FD4 RID: 4052
		private static ConfigurationProperty connectionManagementProp = new ConfigurationProperty("ConnectionManagement", typeof(ConnectionManagementElementCollection), null, ConfigurationPropertyOptions.IsDefaultCollection);

		// Token: 0x04000FD5 RID: 4053
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();
	}
}
