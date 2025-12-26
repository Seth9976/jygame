using System;

namespace System.Configuration
{
	/// <summary>Represents a group of user-scoped application settings in a configuration file.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x020001CF RID: 463
	public sealed class ClientSettingsSection : ConfigurationSection
	{
		// Token: 0x06001027 RID: 4135 RVA: 0x0000D2A5 File Offset: 0x0000B4A5
		static ClientSettingsSection()
		{
			ClientSettingsSection.properties.Add(ClientSettingsSection.settings_prop);
		}

		/// <summary>Gets the collection of client settings for the section.</summary>
		/// <returns>A <see cref="T:System.Configuration.SettingElementCollection" /> containing all the client settings found in the current configuration section.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x0000D2DB File Offset: 0x0000B4DB
		[ConfigurationProperty("", Options = ConfigurationPropertyOptions.IsDefaultCollection)]
		public SettingElementCollection Settings
		{
			get
			{
				return (SettingElementCollection)base[ClientSettingsSection.settings_prop];
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x0000D2ED File Offset: 0x0000B4ED
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return ClientSettingsSection.properties;
			}
		}

		// Token: 0x0400048A RID: 1162
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

		// Token: 0x0400048B RID: 1163
		private static ConfigurationProperty settings_prop = new ConfigurationProperty(string.Empty, typeof(SettingElementCollection), null, ConfigurationPropertyOptions.IsDefaultCollection);
	}
}
