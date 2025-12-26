using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;

namespace System.CodeDom.Compiler
{
	// Token: 0x0200007D RID: 125
	internal sealed class Compiler : ConfigurationElement
	{
		// Token: 0x06000507 RID: 1287 RVA: 0x000056FB File Offset: 0x000038FB
		internal Compiler()
		{
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00005703 File Offset: 0x00003903
		public Compiler(string compilerOptions, string extension, string language, string type, int warningLevel)
		{
			this.CompilerOptions = compilerOptions;
			this.Extension = extension;
			this.Language = language;
			this.Type = type;
			this.WarningLevel = warningLevel;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00028AFC File Offset: 0x00026CFC
		static Compiler()
		{
			Compiler.properties.Add(Compiler.compilerOptionsProp);
			Compiler.properties.Add(Compiler.extensionProp);
			Compiler.properties.Add(Compiler.languageProp);
			Compiler.properties.Add(Compiler.typeProp);
			Compiler.properties.Add(Compiler.warningLevelProp);
			Compiler.properties.Add(Compiler.providerOptionsProp);
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00005730 File Offset: 0x00003930
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x00005742 File Offset: 0x00003942
		[ConfigurationProperty("compilerOptions", DefaultValue = "")]
		public string CompilerOptions
		{
			get
			{
				return (string)base[Compiler.compilerOptionsProp];
			}
			internal set
			{
				base[Compiler.compilerOptionsProp] = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00005750 File Offset: 0x00003950
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x00005762 File Offset: 0x00003962
		[ConfigurationProperty("extension", DefaultValue = "")]
		public string Extension
		{
			get
			{
				return (string)base[Compiler.extensionProp];
			}
			internal set
			{
				base[Compiler.extensionProp] = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00005770 File Offset: 0x00003970
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00005782 File Offset: 0x00003982
		[ConfigurationProperty("language", DefaultValue = "", Options = ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey)]
		public string Language
		{
			get
			{
				return (string)base[Compiler.languageProp];
			}
			internal set
			{
				base[Compiler.languageProp] = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00005790 File Offset: 0x00003990
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x000057A2 File Offset: 0x000039A2
		[ConfigurationProperty("type", DefaultValue = "", Options = ConfigurationPropertyOptions.IsRequired)]
		public string Type
		{
			get
			{
				return (string)base[Compiler.typeProp];
			}
			internal set
			{
				base[Compiler.typeProp] = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x000057B0 File Offset: 0x000039B0
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x000057C2 File Offset: 0x000039C2
		[IntegerValidator(MinValue = 0, MaxValue = 4)]
		[ConfigurationProperty("warningLevel", DefaultValue = "0")]
		public int WarningLevel
		{
			get
			{
				return (int)base[Compiler.warningLevelProp];
			}
			internal set
			{
				base[Compiler.warningLevelProp] = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x000057D5 File Offset: 0x000039D5
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x000057E7 File Offset: 0x000039E7
		[ConfigurationProperty("", Options = ConfigurationPropertyOptions.IsDefaultCollection)]
		public CompilerProviderOptionsCollection ProviderOptions
		{
			get
			{
				return (CompilerProviderOptionsCollection)base[Compiler.providerOptionsProp];
			}
			internal set
			{
				base[Compiler.providerOptionsProp] = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x000057F5 File Offset: 0x000039F5
		public Dictionary<string, string> ProviderOptionsDictionary
		{
			get
			{
				return this.ProviderOptions.ProviderOptions;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00005802 File Offset: 0x00003A02
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return Compiler.properties;
			}
		}

		// Token: 0x0400012C RID: 300
		private static ConfigurationProperty compilerOptionsProp = new ConfigurationProperty("compilerOptions", typeof(string), string.Empty);

		// Token: 0x0400012D RID: 301
		private static ConfigurationProperty extensionProp = new ConfigurationProperty("extension", typeof(string), string.Empty);

		// Token: 0x0400012E RID: 302
		private static ConfigurationProperty languageProp = new ConfigurationProperty("language", typeof(string), string.Empty, ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey);

		// Token: 0x0400012F RID: 303
		private static ConfigurationProperty typeProp = new ConfigurationProperty("type", typeof(string), string.Empty, ConfigurationPropertyOptions.IsRequired);

		// Token: 0x04000130 RID: 304
		private static ConfigurationProperty warningLevelProp = new ConfigurationProperty("warningLevel", typeof(int), 0, global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(int)), new IntegerValidator(0, 4), ConfigurationPropertyOptions.None);

		// Token: 0x04000131 RID: 305
		private static ConfigurationProperty providerOptionsProp = new ConfigurationProperty(string.Empty, typeof(CompilerProviderOptionsCollection), null, null, null, ConfigurationPropertyOptions.IsDefaultCollection);

		// Token: 0x04000132 RID: 306
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();
	}
}
