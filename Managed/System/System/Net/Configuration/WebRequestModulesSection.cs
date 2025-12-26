using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the configuration section for Web request modules. This class cannot be inherited.</summary>
	// Token: 0x020002FA RID: 762
	public sealed class WebRequestModulesSection : ConfigurationSection
	{
		// Token: 0x060019C8 RID: 6600 RVA: 0x000130F2 File Offset: 0x000112F2
		static WebRequestModulesSection()
		{
			WebRequestModulesSection.properties.Add(WebRequestModulesSection.webRequestModulesProp);
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060019C9 RID: 6601 RVA: 0x00013128 File Offset: 0x00011328
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return WebRequestModulesSection.properties;
			}
		}

		/// <summary>Gets the collection of Web request modules in the section.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.WebRequestModuleElementCollection" /> containing the registered Web request modules. </returns>
		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x0001312F File Offset: 0x0001132F
		[ConfigurationProperty("", Options = ConfigurationPropertyOptions.IsDefaultCollection)]
		public WebRequestModuleElementCollection WebRequestModules
		{
			get
			{
				return (WebRequestModuleElementCollection)base[WebRequestModulesSection.webRequestModulesProp];
			}
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO]
		protected override void PostDeserialize()
		{
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO]
		protected override void InitializeDefault()
		{
		}

		// Token: 0x0400101F RID: 4127
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

		// Token: 0x04001020 RID: 4128
		private static ConfigurationProperty webRequestModulesProp = new ConfigurationProperty(string.Empty, typeof(WebRequestModuleElementCollection), null, ConfigurationPropertyOptions.IsDefaultCollection);
	}
}
