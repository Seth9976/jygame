using System;
using System.Runtime.CompilerServices;

namespace System.Configuration
{
	// Token: 0x020001D5 RID: 469
	internal class DefaultConfig : IConfigurationSystem
	{
		// Token: 0x0600104E RID: 4174 RVA: 0x000021C3 File Offset: 0x000003C3
		private DefaultConfig()
		{
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0000D557 File Offset: 0x0000B757
		public static DefaultConfig GetInstance()
		{
			return DefaultConfig.instance;
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x0000D55E File Offset: 0x0000B75E
		[Obsolete("This method is obsolete.  Please use System.Configuration.ConfigurationManager.GetConfig")]
		public object GetConfig(string sectionName)
		{
			this.Init();
			return this.config.GetConfig(sectionName);
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00039838 File Offset: 0x00037A38
		public void Init()
		{
			lock (this)
			{
				if (this.config == null)
				{
					ConfigurationData configurationData = new ConfigurationData();
					if (!configurationData.LoadString(DefaultConfig.GetBundledMachineConfig()))
					{
						if (!configurationData.Load(DefaultConfig.GetMachineConfigPath()))
						{
							throw new ConfigurationException("Cannot find " + DefaultConfig.GetMachineConfigPath());
						}
					}
					string appConfigPath = DefaultConfig.GetAppConfigPath();
					if (appConfigPath == null)
					{
						this.config = configurationData;
					}
					else
					{
						ConfigurationData configurationData2 = new ConfigurationData(configurationData);
						if (configurationData2.Load(appConfigPath))
						{
							this.config = configurationData2;
						}
						else
						{
							this.config = configurationData;
						}
					}
				}
			}
		}

		// Token: 0x06001053 RID: 4179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string get_bundled_machine_config();

		// Token: 0x06001054 RID: 4180 RVA: 0x0000D572 File Offset: 0x0000B772
		internal static string GetBundledMachineConfig()
		{
			return DefaultConfig.get_bundled_machine_config();
		}

		// Token: 0x06001055 RID: 4181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string get_machine_config_path();

		// Token: 0x06001056 RID: 4182 RVA: 0x0000D579 File Offset: 0x0000B779
		internal static string GetMachineConfigPath()
		{
			return DefaultConfig.get_machine_config_path();
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x000398F8 File Offset: 0x00037AF8
		private static string GetAppConfigPath()
		{
			AppDomainSetup setupInformation = AppDomain.CurrentDomain.SetupInformation;
			string configurationFile = setupInformation.ConfigurationFile;
			if (configurationFile == null || configurationFile.Length == 0)
			{
				return null;
			}
			return configurationFile;
		}

		// Token: 0x04000494 RID: 1172
		private static readonly DefaultConfig instance = new DefaultConfig();

		// Token: 0x04000495 RID: 1173
		private ConfigurationData config;
	}
}
