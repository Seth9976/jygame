using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the configuration section for authentication modules. This class cannot be inherited.</summary>
	// Token: 0x020002D6 RID: 726
	public sealed class AuthenticationModulesSection : ConfigurationSection
	{
		// Token: 0x060018C6 RID: 6342 RVA: 0x000124DD File Offset: 0x000106DD
		static AuthenticationModulesSection()
		{
			AuthenticationModulesSection.properties.Add(AuthenticationModulesSection.authenticationModulesProp);
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x00012513 File Offset: 0x00010713
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return AuthenticationModulesSection.properties;
			}
		}

		/// <summary>Gets the collection of authentication modules in the section.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.AuthenticationModuleElementCollection" /> that contains the registered authentication modules. </returns>
		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060018C8 RID: 6344 RVA: 0x0001251A File Offset: 0x0001071A
		[ConfigurationProperty("", Options = ConfigurationPropertyOptions.IsDefaultCollection)]
		public AuthenticationModuleElementCollection AuthenticationModules
		{
			get
			{
				return (AuthenticationModuleElementCollection)base[AuthenticationModulesSection.authenticationModulesProp];
			}
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO]
		protected override void PostDeserialize()
		{
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO]
		protected override void InitializeDefault()
		{
		}

		// Token: 0x04000FCB RID: 4043
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

		// Token: 0x04000FCC RID: 4044
		private static ConfigurationProperty authenticationModulesProp = new ConfigurationProperty(string.Empty, typeof(AuthenticationModuleElementCollection), null, ConfigurationPropertyOptions.IsDefaultCollection);
	}
}
