using System;
using System.Collections.Generic;
using System.Configuration;

namespace System.CodeDom.Compiler
{
	// Token: 0x0200007E RID: 126
	[ConfigurationCollection(typeof(Compiler), AddItemName = "compiler", CollectionType = ConfigurationElementCollectionType.BasicMap)]
	internal sealed class CompilerCollection : ConfigurationElementCollection
	{
		// Token: 0x06000519 RID: 1305 RVA: 0x00028C3C File Offset: 0x00026E3C
		static CompilerCollection()
		{
			CompilerInfo compilerInfo = new CompilerInfo();
			compilerInfo.Languages = "c#;cs;csharp";
			compilerInfo.Extensions = ".cs";
			compilerInfo.TypeName = "Microsoft.CSharp.CSharpCodeProvider, System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
			compilerInfo.ProviderOptions = new Dictionary<string, string>(1);
			compilerInfo.ProviderOptions["CompilerVersion"] = "2.0";
			CompilerCollection.AddCompilerInfo(compilerInfo);
			compilerInfo = new CompilerInfo();
			compilerInfo.Languages = "vb;vbs;visualbasic;vbscript";
			compilerInfo.Extensions = ".vb";
			compilerInfo.TypeName = "Microsoft.VisualBasic.VBCodeProvider, System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
			compilerInfo.ProviderOptions = new Dictionary<string, string>(1);
			compilerInfo.ProviderOptions["CompilerVersion"] = "2.0";
			CompilerCollection.AddCompilerInfo(compilerInfo);
			compilerInfo = new CompilerInfo();
			compilerInfo.Languages = "js;jscript;javascript";
			compilerInfo.Extensions = ".js";
			compilerInfo.TypeName = "Microsoft.JScript.JScriptCodeProvider, Microsoft.JScript, Version=8.0.1100.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
			compilerInfo.ProviderOptions = new Dictionary<string, string>(1);
			compilerInfo.ProviderOptions["CompilerVersion"] = "2.0";
			CompilerCollection.AddCompilerInfo(compilerInfo);
			compilerInfo = new CompilerInfo();
			compilerInfo.Languages = "vj#;vjs;vjsharp";
			compilerInfo.Extensions = ".jsl;.java";
			compilerInfo.TypeName = "Microsoft.VJSharp.VJSharpCodeProvider, VJSharpCodeProvider, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
			compilerInfo.ProviderOptions = new Dictionary<string, string>(1);
			compilerInfo.ProviderOptions["CompilerVersion"] = "2.0";
			CompilerCollection.AddCompilerInfo(compilerInfo);
			compilerInfo = new CompilerInfo();
			compilerInfo.Languages = "c++;mc;cpp";
			compilerInfo.Extensions = ".h";
			compilerInfo.TypeName = "Microsoft.VisualC.CppCodeProvider, CppCodeProvider, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
			compilerInfo.ProviderOptions = new Dictionary<string, string>(1);
			compilerInfo.ProviderOptions["CompilerVersion"] = "2.0";
			CompilerCollection.AddCompilerInfo(compilerInfo);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00028E04 File Offset: 0x00027004
		private static void AddCompilerInfo(CompilerInfo ci)
		{
			ci.Init();
			CompilerCollection.compiler_infos.Add(ci);
			string[] languages = ci.GetLanguages();
			if (languages != null)
			{
				foreach (string text in languages)
				{
					CompilerCollection.compiler_languages[text] = ci;
				}
			}
			string[] extensions = ci.GetExtensions();
			if (extensions != null)
			{
				foreach (string text2 in extensions)
				{
					CompilerCollection.compiler_extensions[text2] = ci;
				}
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00028E98 File Offset: 0x00027098
		private static void AddCompilerInfo(Compiler compiler)
		{
			CompilerCollection.AddCompilerInfo(new CompilerInfo
			{
				Languages = compiler.Language,
				Extensions = compiler.Extension,
				TypeName = compiler.Type,
				ProviderOptions = compiler.ProviderOptionsDictionary,
				CompilerOptions = compiler.CompilerOptions,
				WarningLevel = compiler.WarningLevel
			});
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00028EFC File Offset: 0x000270FC
		protected override void BaseAdd(ConfigurationElement element)
		{
			Compiler compiler = element as Compiler;
			if (compiler != null)
			{
				CompilerCollection.AddCompilerInfo(compiler);
			}
			base.BaseAdd(element);
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00002AA1 File Offset: 0x00000CA1
		protected override bool ThrowOnDuplicate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00005811 File Offset: 0x00003A11
		protected override ConfigurationElement CreateNewElement()
		{
			return new Compiler();
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00028F24 File Offset: 0x00027124
		public CompilerInfo GetCompilerInfoForLanguage(string language)
		{
			if (CompilerCollection.compiler_languages.Count == 0)
			{
				return null;
			}
			CompilerInfo compilerInfo;
			if (CompilerCollection.compiler_languages.TryGetValue(language, out compilerInfo))
			{
				return compilerInfo;
			}
			return null;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00028F58 File Offset: 0x00027158
		public CompilerInfo GetCompilerInfoForExtension(string extension)
		{
			if (CompilerCollection.compiler_extensions.Count == 0)
			{
				return null;
			}
			CompilerInfo compilerInfo;
			if (CompilerCollection.compiler_extensions.TryGetValue(extension, out compilerInfo))
			{
				return compilerInfo;
			}
			return null;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00028F8C File Offset: 0x0002718C
		public string GetLanguageFromExtension(string extension)
		{
			CompilerInfo compilerInfoForExtension = this.GetCompilerInfoForExtension(extension);
			if (compilerInfoForExtension == null)
			{
				return null;
			}
			string[] languages = compilerInfoForExtension.GetLanguages();
			if (languages != null && languages.Length > 0)
			{
				return languages[0];
			}
			return null;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00005818 File Offset: 0x00003A18
		public Compiler Get(int index)
		{
			return (Compiler)base.BaseGet(index);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00005826 File Offset: 0x00003A26
		public Compiler Get(string language)
		{
			return (Compiler)base.BaseGet(language);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00005834 File Offset: 0x00003A34
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((Compiler)element).Language;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00005841 File Offset: 0x00003A41
		public string GetKey(int index)
		{
			return (string)base.BaseGetKey(index);
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00028FC4 File Offset: 0x000271C4
		public string[] AllKeys
		{
			get
			{
				string[] array = new string[CompilerCollection.compiler_infos.Count];
				for (int i = 0; i < this.Count; i++)
				{
					array[i] = CompilerCollection.compiler_infos[i].Languages;
				}
				return array;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return ConfigurationElementCollectionType.BasicMap;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0000584F File Offset: 0x00003A4F
		protected override string ElementName
		{
			get
			{
				return "compiler";
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00005856 File Offset: 0x00003A56
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return CompilerCollection.properties;
			}
		}

		// Token: 0x170000EC RID: 236
		public Compiler this[int index]
		{
			get
			{
				return (Compiler)base.BaseGet(index);
			}
		}

		// Token: 0x170000ED RID: 237
		public CompilerInfo this[string language]
		{
			get
			{
				return this.GetCompilerInfoForLanguage(language);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00005866 File Offset: 0x00003A66
		public CompilerInfo[] CompilerInfos
		{
			get
			{
				return CompilerCollection.compiler_infos.ToArray();
			}
		}

		// Token: 0x04000133 RID: 307
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

		// Token: 0x04000134 RID: 308
		private static List<CompilerInfo> compiler_infos = new List<CompilerInfo>();

		// Token: 0x04000135 RID: 309
		private static Dictionary<string, CompilerInfo> compiler_languages = new Dictionary<string, CompilerInfo>(16, StringComparer.OrdinalIgnoreCase);

		// Token: 0x04000136 RID: 310
		private static Dictionary<string, CompilerInfo> compiler_extensions = new Dictionary<string, CompilerInfo>(6, StringComparer.OrdinalIgnoreCase);
	}
}
