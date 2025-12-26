using System;
using System.Configuration;

namespace System.CodeDom.Compiler
{
	// Token: 0x02000083 RID: 131
	internal sealed class CompilerProviderOption : ConfigurationElement
	{
		// Token: 0x06000575 RID: 1397 RVA: 0x00029318 File Offset: 0x00027518
		static CompilerProviderOption()
		{
			CompilerProviderOption.properties.Add(CompilerProviderOption.nameProp);
			CompilerProviderOption.properties.Add(CompilerProviderOption.valueProp);
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x00005C2D File Offset: 0x00003E2D
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x00005C3F File Offset: 0x00003E3F
		[ConfigurationProperty("name", DefaultValue = "", Options = ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey)]
		public string Name
		{
			get
			{
				return (string)base[CompilerProviderOption.nameProp];
			}
			set
			{
				base[CompilerProviderOption.nameProp] = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x00005C4D File Offset: 0x00003E4D
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x00005C5F File Offset: 0x00003E5F
		[ConfigurationProperty("value", DefaultValue = "", Options = ConfigurationPropertyOptions.IsRequired)]
		public string Value
		{
			get
			{
				return (string)base[CompilerProviderOption.valueProp];
			}
			set
			{
				base[CompilerProviderOption.valueProp] = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x00005C6D File Offset: 0x00003E6D
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return CompilerProviderOption.properties;
			}
		}

		// Token: 0x04000154 RID: 340
		private static ConfigurationProperty nameProp = new ConfigurationProperty("name", typeof(string), string.Empty, ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey);

		// Token: 0x04000155 RID: 341
		private static ConfigurationProperty valueProp = new ConfigurationProperty("value", typeof(string), string.Empty, ConfigurationPropertyOptions.IsRequired);

		// Token: 0x04000156 RID: 342
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();
	}
}
