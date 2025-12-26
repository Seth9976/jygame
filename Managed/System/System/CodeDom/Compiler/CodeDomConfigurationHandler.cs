using System;
using System.Configuration;

namespace System.CodeDom.Compiler
{
	// Token: 0x02000077 RID: 119
	internal sealed class CodeDomConfigurationHandler : ConfigurationSection
	{
		// Token: 0x06000422 RID: 1058 RVA: 0x000271F0 File Offset: 0x000253F0
		static CodeDomConfigurationHandler()
		{
			CodeDomConfigurationHandler.properties.Add(CodeDomConfigurationHandler.compilersProp);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00004EFD File Offset: 0x000030FD
		protected override void InitializeDefault()
		{
			CodeDomConfigurationHandler.compilersProp = new ConfigurationProperty("compilers", typeof(CompilerCollection), CodeDomConfigurationHandler.default_compilers);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00004F1D File Offset: 0x0000311D
		[global::System.MonoTODO]
		protected override void PostDeserialize()
		{
			base.PostDeserialize();
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000021CB File Offset: 0x000003CB
		protected override object GetRuntimeObject()
		{
			return this;
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00004F25 File Offset: 0x00003125
		[ConfigurationProperty("compilers")]
		public CompilerCollection Compilers
		{
			get
			{
				return (CompilerCollection)base[CodeDomConfigurationHandler.compilersProp];
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00027240 File Offset: 0x00025440
		public CompilerInfo[] CompilerInfos
		{
			get
			{
				CompilerCollection compilerCollection = (CompilerCollection)base[CodeDomConfigurationHandler.compilersProp];
				if (compilerCollection == null)
				{
					return null;
				}
				return compilerCollection.CompilerInfos;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00004F37 File Offset: 0x00003137
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return CodeDomConfigurationHandler.properties;
			}
		}

		// Token: 0x04000121 RID: 289
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

		// Token: 0x04000122 RID: 290
		private static ConfigurationProperty compilersProp = new ConfigurationProperty("compilers", typeof(CompilerCollection), CodeDomConfigurationHandler.default_compilers);

		// Token: 0x04000123 RID: 291
		private static CompilerCollection default_compilers = new CompilerCollection();
	}
}
