using System;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace System.Configuration
{
	// Token: 0x020001E0 RID: 480
	internal class CustomizableFileSettingsProvider : SettingsProvider, IApplicationSettingsProvider
	{
		// Token: 0x06001090 RID: 4240 RVA: 0x0000D928 File Offset: 0x0000BB28
		public override void Initialize(string name, global::System.Collections.Specialized.NameValueCollection config)
		{
			base.Initialize(name, config);
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x0000D932 File Offset: 0x0000BB32
		internal static string UserRoamingFullPath
		{
			get
			{
				return Path.Combine(CustomizableFileSettingsProvider.userRoamingPath, CustomizableFileSettingsProvider.userRoamingName);
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x0000D943 File Offset: 0x0000BB43
		internal static string UserLocalFullPath
		{
			get
			{
				return Path.Combine(CustomizableFileSettingsProvider.userLocalPath, CustomizableFileSettingsProvider.userLocalName);
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x0000D954 File Offset: 0x0000BB54
		public static string PrevUserRoamingFullPath
		{
			get
			{
				return Path.Combine(CustomizableFileSettingsProvider.userRoamingPathPrevVersion, CustomizableFileSettingsProvider.userRoamingName);
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001094 RID: 4244 RVA: 0x0000D965 File Offset: 0x0000BB65
		public static string PrevUserLocalFullPath
		{
			get
			{
				return Path.Combine(CustomizableFileSettingsProvider.userLocalPathPrevVersion, CustomizableFileSettingsProvider.userLocalName);
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x0000D976 File Offset: 0x0000BB76
		public static string UserRoamingPath
		{
			get
			{
				return CustomizableFileSettingsProvider.userRoamingPath;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x0000D97D File Offset: 0x0000BB7D
		public static string UserLocalPath
		{
			get
			{
				return CustomizableFileSettingsProvider.userLocalPath;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x0000D984 File Offset: 0x0000BB84
		public static string UserRoamingName
		{
			get
			{
				return CustomizableFileSettingsProvider.userRoamingName;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x0000D98B File Offset: 0x0000BB8B
		public static string UserLocalName
		{
			get
			{
				return CustomizableFileSettingsProvider.userLocalName;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x0000D992 File Offset: 0x0000BB92
		// (set) Token: 0x0600109A RID: 4250 RVA: 0x0003A668 File Offset: 0x00038868
		public static UserConfigLocationOption UserConfigSelector
		{
			get
			{
				return CustomizableFileSettingsProvider.userConfig;
			}
			set
			{
				CustomizableFileSettingsProvider.userConfig = value;
				if ((CustomizableFileSettingsProvider.userConfig & UserConfigLocationOption.Other) != (UserConfigLocationOption)0U)
				{
					CustomizableFileSettingsProvider.isVersionMajor = false;
					CustomizableFileSettingsProvider.isVersionMinor = false;
					CustomizableFileSettingsProvider.isVersionBuild = false;
					CustomizableFileSettingsProvider.isVersionRevision = false;
					CustomizableFileSettingsProvider.isCompany = false;
					return;
				}
				CustomizableFileSettingsProvider.isVersionRevision = (CustomizableFileSettingsProvider.userConfig & (UserConfigLocationOption)8U) != (UserConfigLocationOption)0U;
				CustomizableFileSettingsProvider.isVersionBuild = CustomizableFileSettingsProvider.isVersionRevision | ((CustomizableFileSettingsProvider.userConfig & (UserConfigLocationOption)4U) != (UserConfigLocationOption)0U);
				CustomizableFileSettingsProvider.isVersionMinor = CustomizableFileSettingsProvider.isVersionBuild | ((CustomizableFileSettingsProvider.userConfig & (UserConfigLocationOption)2U) != (UserConfigLocationOption)0U);
				CustomizableFileSettingsProvider.isVersionMajor = CustomizableFileSettingsProvider.IsVersionMinor | ((CustomizableFileSettingsProvider.userConfig & (UserConfigLocationOption)1U) != (UserConfigLocationOption)0U);
				CustomizableFileSettingsProvider.isCompany = (CustomizableFileSettingsProvider.userConfig & (UserConfigLocationOption)16U) != (UserConfigLocationOption)0U;
				CustomizableFileSettingsProvider.isProduct = (CustomizableFileSettingsProvider.userConfig & UserConfigLocationOption.Product) != (UserConfigLocationOption)0U;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x0000D999 File Offset: 0x0000BB99
		// (set) Token: 0x0600109C RID: 4252 RVA: 0x0000D9A0 File Offset: 0x0000BBA0
		public static bool IsVersionMajor
		{
			get
			{
				return CustomizableFileSettingsProvider.isVersionMajor;
			}
			set
			{
				CustomizableFileSettingsProvider.isVersionMajor = value;
				CustomizableFileSettingsProvider.isVersionMinor = false;
				CustomizableFileSettingsProvider.isVersionBuild = false;
				CustomizableFileSettingsProvider.isVersionRevision = false;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x0000D9BA File Offset: 0x0000BBBA
		// (set) Token: 0x0600109E RID: 4254 RVA: 0x0000D9C1 File Offset: 0x0000BBC1
		public static bool IsVersionMinor
		{
			get
			{
				return CustomizableFileSettingsProvider.isVersionMinor;
			}
			set
			{
				CustomizableFileSettingsProvider.isVersionMinor = value;
				if (CustomizableFileSettingsProvider.isVersionMinor)
				{
					CustomizableFileSettingsProvider.isVersionMajor = true;
				}
				CustomizableFileSettingsProvider.isVersionBuild = false;
				CustomizableFileSettingsProvider.isVersionRevision = false;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x0000D9E5 File Offset: 0x0000BBE5
		// (set) Token: 0x060010A0 RID: 4256 RVA: 0x0000D9EC File Offset: 0x0000BBEC
		public static bool IsVersionBuild
		{
			get
			{
				return CustomizableFileSettingsProvider.isVersionBuild;
			}
			set
			{
				CustomizableFileSettingsProvider.isVersionBuild = value;
				if (CustomizableFileSettingsProvider.isVersionBuild)
				{
					CustomizableFileSettingsProvider.isVersionMajor = true;
					CustomizableFileSettingsProvider.isVersionMinor = true;
				}
				CustomizableFileSettingsProvider.isVersionRevision = false;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x0000DA10 File Offset: 0x0000BC10
		// (set) Token: 0x060010A2 RID: 4258 RVA: 0x0000DA17 File Offset: 0x0000BC17
		public static bool IsVersionRevision
		{
			get
			{
				return CustomizableFileSettingsProvider.isVersionRevision;
			}
			set
			{
				CustomizableFileSettingsProvider.isVersionRevision = value;
				if (CustomizableFileSettingsProvider.isVersionRevision)
				{
					CustomizableFileSettingsProvider.isVersionMajor = true;
					CustomizableFileSettingsProvider.isVersionMinor = true;
					CustomizableFileSettingsProvider.isVersionBuild = true;
				}
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x0000DA3B File Offset: 0x0000BC3B
		// (set) Token: 0x060010A4 RID: 4260 RVA: 0x0000DA42 File Offset: 0x0000BC42
		public static bool IsCompany
		{
			get
			{
				return CustomizableFileSettingsProvider.isCompany;
			}
			set
			{
				CustomizableFileSettingsProvider.isCompany = value;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x0000DA4A File Offset: 0x0000BC4A
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x0000DA51 File Offset: 0x0000BC51
		public static bool IsEvidence
		{
			get
			{
				return CustomizableFileSettingsProvider.isEvidence;
			}
			set
			{
				CustomizableFileSettingsProvider.isEvidence = value;
			}
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0003A72C File Offset: 0x0003892C
		private static string GetCompanyName()
		{
			Assembly assembly = Assembly.GetEntryAssembly();
			if (assembly == null)
			{
				assembly = Assembly.GetCallingAssembly();
			}
			AssemblyCompanyAttribute[] array = (AssemblyCompanyAttribute[])assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), true);
			if (array != null && array.Length > 0)
			{
				return array[0].Company;
			}
			MethodInfo entryPoint = assembly.EntryPoint;
			Type type = ((entryPoint == null) ? null : entryPoint.DeclaringType);
			if (type != null && !string.IsNullOrEmpty(type.Namespace))
			{
				int num = type.Namespace.IndexOf('.');
				return (num >= 0) ? type.Namespace.Substring(0, num) : type.Namespace;
			}
			return "Program";
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0003A7E0 File Offset: 0x000389E0
		private static string GetProductName()
		{
			Assembly assembly = Assembly.GetEntryAssembly();
			if (assembly == null)
			{
				assembly = Assembly.GetCallingAssembly();
			}
			byte[] publicKeyToken = assembly.GetName().GetPublicKeyToken();
			return string.Format("{0}_{1}_{2}", AppDomain.CurrentDomain.FriendlyName, (publicKeyToken == null) ? "Url" : "StrongName", CustomizableFileSettingsProvider.GetEvidenceHash());
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0003A83C File Offset: 0x00038A3C
		private static string GetEvidenceHash()
		{
			Assembly assembly = Assembly.GetEntryAssembly();
			if (assembly == null)
			{
				assembly = Assembly.GetCallingAssembly();
			}
			byte[] publicKeyToken = assembly.GetName().GetPublicKeyToken();
			byte[] array = SHA1.Create().ComputeHash((publicKeyToken == null) ? Encoding.UTF8.GetBytes(assembly.EscapedCodeBase) : publicKeyToken);
			return Convert.ToBase64String(array);
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0003A894 File Offset: 0x00038A94
		private static string GetProductVersion()
		{
			Assembly assembly = Assembly.GetEntryAssembly();
			if (assembly == null)
			{
				assembly = Assembly.GetCallingAssembly();
			}
			if (assembly == null)
			{
				return string.Empty;
			}
			return assembly.GetName().Version.ToString();
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0003A8D0 File Offset: 0x00038AD0
		private static void CreateUserConfigPath()
		{
			if (CustomizableFileSettingsProvider.userDefine)
			{
				return;
			}
			if (CustomizableFileSettingsProvider.ProductName == string.Empty)
			{
				CustomizableFileSettingsProvider.ProductName = CustomizableFileSettingsProvider.GetProductName();
			}
			if (CustomizableFileSettingsProvider.CompanyName == string.Empty)
			{
				CustomizableFileSettingsProvider.CompanyName = CustomizableFileSettingsProvider.GetCompanyName();
			}
			if (CustomizableFileSettingsProvider.ForceVersion == string.Empty)
			{
				CustomizableFileSettingsProvider.ProductVersion = CustomizableFileSettingsProvider.GetProductVersion().Split(new char[] { '.' });
			}
			if (CustomizableFileSettingsProvider.userRoamingBasePath == string.Empty)
			{
				CustomizableFileSettingsProvider.userRoamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			}
			else
			{
				CustomizableFileSettingsProvider.userRoamingPath = CustomizableFileSettingsProvider.userRoamingBasePath;
			}
			if (CustomizableFileSettingsProvider.userLocalBasePath == string.Empty)
			{
				CustomizableFileSettingsProvider.userLocalPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			}
			else
			{
				CustomizableFileSettingsProvider.userLocalPath = CustomizableFileSettingsProvider.userLocalBasePath;
			}
			if (CustomizableFileSettingsProvider.isCompany)
			{
				CustomizableFileSettingsProvider.userRoamingPath = Path.Combine(CustomizableFileSettingsProvider.userRoamingPath, CustomizableFileSettingsProvider.CompanyName);
				CustomizableFileSettingsProvider.userLocalPath = Path.Combine(CustomizableFileSettingsProvider.userLocalPath, CustomizableFileSettingsProvider.CompanyName);
			}
			if (CustomizableFileSettingsProvider.isProduct)
			{
				if (CustomizableFileSettingsProvider.isEvidence)
				{
					Assembly assembly = Assembly.GetEntryAssembly();
					if (assembly == null)
					{
						assembly = Assembly.GetCallingAssembly();
					}
					byte[] publicKeyToken = assembly.GetName().GetPublicKeyToken();
					CustomizableFileSettingsProvider.ProductName = string.Format("{0}_{1}_{2}", CustomizableFileSettingsProvider.ProductName, (publicKeyToken == null) ? "Url" : "StrongName", CustomizableFileSettingsProvider.GetEvidenceHash());
				}
				CustomizableFileSettingsProvider.userRoamingPath = Path.Combine(CustomizableFileSettingsProvider.userRoamingPath, CustomizableFileSettingsProvider.ProductName);
				CustomizableFileSettingsProvider.userLocalPath = Path.Combine(CustomizableFileSettingsProvider.userLocalPath, CustomizableFileSettingsProvider.ProductName);
			}
			string text;
			if (CustomizableFileSettingsProvider.ForceVersion == string.Empty)
			{
				if (CustomizableFileSettingsProvider.isVersionRevision)
				{
					text = string.Format("{0}.{1}.{2}.{3}", new object[]
					{
						CustomizableFileSettingsProvider.ProductVersion[0],
						CustomizableFileSettingsProvider.ProductVersion[1],
						CustomizableFileSettingsProvider.ProductVersion[2],
						CustomizableFileSettingsProvider.ProductVersion[3]
					});
				}
				else if (CustomizableFileSettingsProvider.isVersionBuild)
				{
					text = string.Format("{0}.{1}.{2}", CustomizableFileSettingsProvider.ProductVersion[0], CustomizableFileSettingsProvider.ProductVersion[1], CustomizableFileSettingsProvider.ProductVersion[2]);
				}
				else if (CustomizableFileSettingsProvider.isVersionMinor)
				{
					text = string.Format("{0}.{1}", CustomizableFileSettingsProvider.ProductVersion[0], CustomizableFileSettingsProvider.ProductVersion[1]);
				}
				else if (CustomizableFileSettingsProvider.isVersionMajor)
				{
					text = CustomizableFileSettingsProvider.ProductVersion[0];
				}
				else
				{
					text = string.Empty;
				}
			}
			else
			{
				text = CustomizableFileSettingsProvider.ForceVersion;
			}
			string text2 = CustomizableFileSettingsProvider.PrevVersionPath(CustomizableFileSettingsProvider.userRoamingPath, text);
			string text3 = CustomizableFileSettingsProvider.PrevVersionPath(CustomizableFileSettingsProvider.userLocalPath, text);
			CustomizableFileSettingsProvider.userRoamingPath = Path.Combine(CustomizableFileSettingsProvider.userRoamingPath, text);
			CustomizableFileSettingsProvider.userLocalPath = Path.Combine(CustomizableFileSettingsProvider.userLocalPath, text);
			if (text2 != string.Empty)
			{
				CustomizableFileSettingsProvider.userRoamingPathPrevVersion = Path.Combine(CustomizableFileSettingsProvider.userRoamingPath, text2);
			}
			if (text3 != string.Empty)
			{
				CustomizableFileSettingsProvider.userLocalPathPrevVersion = Path.Combine(CustomizableFileSettingsProvider.userLocalPath, text3);
			}
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0003ABC0 File Offset: 0x00038DC0
		private static string PrevVersionPath(string dirName, string currentVersion)
		{
			string text = string.Empty;
			if (!Directory.Exists(dirName))
			{
				return text;
			}
			DirectoryInfo directoryInfo = new DirectoryInfo(dirName);
			foreach (DirectoryInfo directoryInfo2 in directoryInfo.GetDirectories())
			{
				if (string.Compare(currentVersion, directoryInfo2.Name, StringComparison.Ordinal) > 0 && string.Compare(text, directoryInfo2.Name, StringComparison.Ordinal) < 0)
				{
					text = directoryInfo2.Name;
				}
			}
			return text;
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0000DA59 File Offset: 0x0000BC59
		public static bool SetUserRoamingPath(string configPath)
		{
			if (CustomizableFileSettingsProvider.CheckPath(configPath))
			{
				CustomizableFileSettingsProvider.userRoamingBasePath = configPath;
				return true;
			}
			return false;
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x0000DA6F File Offset: 0x0000BC6F
		public static bool SetUserLocalPath(string configPath)
		{
			if (CustomizableFileSettingsProvider.CheckPath(configPath))
			{
				CustomizableFileSettingsProvider.userLocalBasePath = configPath;
				return true;
			}
			return false;
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x0000DA85 File Offset: 0x0000BC85
		private static bool CheckFileName(string configFile)
		{
			return configFile.IndexOfAny(Path.GetInvalidFileNameChars()) < 0;
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0000DA95 File Offset: 0x0000BC95
		public static bool SetUserRoamingFileName(string configFile)
		{
			if (CustomizableFileSettingsProvider.CheckFileName(configFile))
			{
				CustomizableFileSettingsProvider.userRoamingName = configFile;
				return true;
			}
			return false;
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0000DAAB File Offset: 0x0000BCAB
		public static bool SetUserLocalFileName(string configFile)
		{
			if (CustomizableFileSettingsProvider.CheckFileName(configFile))
			{
				CustomizableFileSettingsProvider.userLocalName = configFile;
				return true;
			}
			return false;
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0000DAC1 File Offset: 0x0000BCC1
		public static bool SetCompanyName(string companyName)
		{
			if (CustomizableFileSettingsProvider.CheckFileName(companyName))
			{
				CustomizableFileSettingsProvider.CompanyName = companyName;
				return true;
			}
			return false;
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0000DAD7 File Offset: 0x0000BCD7
		public static bool SetProductName(string productName)
		{
			if (CustomizableFileSettingsProvider.CheckFileName(productName))
			{
				CustomizableFileSettingsProvider.ProductName = productName;
				return true;
			}
			return false;
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0000DAED File Offset: 0x0000BCED
		public static bool SetVersion(int major)
		{
			CustomizableFileSettingsProvider.ForceVersion = string.Format("{0}", major);
			return true;
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0000DB05 File Offset: 0x0000BD05
		public static bool SetVersion(int major, int minor)
		{
			CustomizableFileSettingsProvider.ForceVersion = string.Format("{0}.{1}", major, minor);
			return true;
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0000DB23 File Offset: 0x0000BD23
		public static bool SetVersion(int major, int minor, int build)
		{
			CustomizableFileSettingsProvider.ForceVersion = string.Format("{0}.{1}.{2}", major, minor, build);
			return true;
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0000DB47 File Offset: 0x0000BD47
		public static bool SetVersion(int major, int minor, int build, int revision)
		{
			CustomizableFileSettingsProvider.ForceVersion = string.Format("{0}.{1}.{2}.{3}", new object[] { major, minor, build, revision });
			return true;
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x0000DB83 File Offset: 0x0000BD83
		public static bool SetVersion(string forceVersion)
		{
			if (CustomizableFileSettingsProvider.CheckFileName(forceVersion))
			{
				CustomizableFileSettingsProvider.ForceVersion = forceVersion;
				return true;
			}
			return false;
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x0003AC3C File Offset: 0x00038E3C
		private static bool CheckPath(string configPath)
		{
			char[] invalidPathChars = Path.GetInvalidPathChars();
			if (configPath.IndexOfAny(invalidPathChars) >= 0)
			{
				return false;
			}
			string text = configPath;
			string fileName;
			while ((fileName = Path.GetFileName(text)) != string.Empty)
			{
				if (!CustomizableFileSettingsProvider.CheckFileName(fileName))
				{
					return false;
				}
				text = Path.GetDirectoryName(text);
			}
			return true;
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x0000DB99 File Offset: 0x0000BD99
		public override string Name
		{
			get
			{
				return base.Name;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x0000DBA1 File Offset: 0x0000BDA1
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x0000DBA9 File Offset: 0x0000BDA9
		public override string ApplicationName
		{
			get
			{
				return this.app_name;
			}
			set
			{
				this.app_name = value;
			}
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x0003AC94 File Offset: 0x00038E94
		private void SaveProperties(ExeConfigurationFileMap exeMap, SettingsPropertyValueCollection collection, ConfigurationUserLevel level, SettingsContext context, bool checkUserLevel)
		{
			Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(exeMap, level);
			UserSettingsGroup userSettingsGroup = configuration.GetSectionGroup("userSettings") as UserSettingsGroup;
			bool flag = level == ConfigurationUserLevel.PerUserRoaming;
			if (userSettingsGroup == null)
			{
				userSettingsGroup = new UserSettingsGroup();
				configuration.SectionGroups.Add("userSettings", userSettingsGroup);
				ApplicationSettingsBase currentSettings = context.CurrentSettings;
				ClientSettingsSection clientSettingsSection = new ClientSettingsSection();
				userSettingsGroup.Sections.Add(((currentSettings == null) ? typeof(ApplicationSettingsBase) : currentSettings.GetType()).FullName, clientSettingsSection);
			}
			bool flag2 = false;
			foreach (object obj in userSettingsGroup.Sections)
			{
				ConfigurationSection configurationSection = (ConfigurationSection)obj;
				ClientSettingsSection clientSettingsSection2 = configurationSection as ClientSettingsSection;
				if (clientSettingsSection2 != null)
				{
					foreach (object obj2 in collection)
					{
						SettingsPropertyValue settingsPropertyValue = (SettingsPropertyValue)obj2;
						if (!checkUserLevel || settingsPropertyValue.Property.Attributes.Contains(typeof(SettingsManageabilityAttribute)) == flag)
						{
							flag2 = true;
							SettingElement settingElement = clientSettingsSection2.Settings.Get(settingsPropertyValue.Name);
							if (settingElement == null)
							{
								settingElement = new SettingElement(settingsPropertyValue.Name, settingsPropertyValue.Property.SerializeAs);
								clientSettingsSection2.Settings.Add(settingElement);
							}
							if (settingElement.Value.ValueXml == null)
							{
								settingElement.Value.ValueXml = new XmlDocument().CreateElement("value");
							}
							switch (settingsPropertyValue.Property.SerializeAs)
							{
							case SettingsSerializeAs.String:
								settingElement.Value.ValueXml.InnerText = settingsPropertyValue.SerializedValue as string;
								break;
							case SettingsSerializeAs.Xml:
								settingElement.Value.ValueXml.InnerXml = (settingsPropertyValue.SerializedValue as string) ?? string.Empty;
								break;
							case SettingsSerializeAs.Binary:
								settingElement.Value.ValueXml.InnerText = ((settingsPropertyValue.SerializedValue == null) ? string.Empty : Convert.ToBase64String(settingsPropertyValue.SerializedValue as byte[]));
								break;
							default:
								throw new NotImplementedException();
							}
						}
					}
				}
			}
			if (flag2)
			{
				configuration.Save(ConfigurationSaveMode.Minimal, true);
			}
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0003AF58 File Offset: 0x00039158
		private void LoadPropertyValue(SettingsPropertyCollection collection, SettingElement element, bool allowOverwrite)
		{
			SettingsProperty settingsProperty = collection[element.Name];
			if (settingsProperty == null)
			{
				settingsProperty = new SettingsProperty(element.Name);
				collection.Add(settingsProperty);
			}
			SettingsPropertyValue settingsPropertyValue = new SettingsPropertyValue(settingsProperty);
			settingsPropertyValue.IsDirty = false;
			if (element.Value.ValueXml != null)
			{
				switch (settingsPropertyValue.Property.SerializeAs)
				{
				case SettingsSerializeAs.String:
					settingsPropertyValue.SerializedValue = element.Value.ValueXml.InnerText;
					break;
				case SettingsSerializeAs.Xml:
					settingsPropertyValue.SerializedValue = element.Value.ValueXml.InnerXml;
					break;
				case SettingsSerializeAs.Binary:
					settingsPropertyValue.SerializedValue = Convert.FromBase64String(element.Value.ValueXml.InnerText);
					break;
				}
			}
			else
			{
				settingsPropertyValue.SerializedValue = settingsProperty.DefaultValue;
			}
			try
			{
				if (allowOverwrite)
				{
					this.values.Remove(element.Name);
				}
				this.values.Add(settingsPropertyValue);
			}
			catch (ArgumentException ex)
			{
				throw new ConfigurationErrorsException(string.Format(CultureInfo.InvariantCulture, "Failed to load value for '{0}'.", new object[] { element.Name }), ex);
			}
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0003B098 File Offset: 0x00039298
		private void LoadProperties(ExeConfigurationFileMap exeMap, SettingsPropertyCollection collection, ConfigurationUserLevel level, string sectionGroupName, bool allowOverwrite, string groupName)
		{
			Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(exeMap, level);
			ConfigurationSectionGroup sectionGroup = configuration.GetSectionGroup(sectionGroupName);
			if (sectionGroup != null)
			{
				foreach (object obj in sectionGroup.Sections)
				{
					ConfigurationSection configurationSection = (ConfigurationSection)obj;
					if (!(configurationSection.SectionInformation.Name != groupName))
					{
						ClientSettingsSection clientSettingsSection = configurationSection as ClientSettingsSection;
						if (clientSettingsSection != null)
						{
							foreach (object obj2 in clientSettingsSection.Settings)
							{
								SettingElement settingElement = (SettingElement)obj2;
								this.LoadPropertyValue(collection, settingElement, allowOverwrite);
							}
							break;
						}
					}
				}
			}
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x0003B1A4 File Offset: 0x000393A4
		public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection collection)
		{
			this.CreateExeMap();
			if (CustomizableFileSettingsProvider.UserLocalFullPath == CustomizableFileSettingsProvider.UserRoamingFullPath)
			{
				this.SaveProperties(this.exeMapCurrent, collection, ConfigurationUserLevel.PerUserRoaming, context, false);
			}
			else
			{
				this.SaveProperties(this.exeMapCurrent, collection, ConfigurationUserLevel.PerUserRoaming, context, true);
				this.SaveProperties(this.exeMapCurrent, collection, ConfigurationUserLevel.PerUserRoamingAndLocal, context, true);
			}
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0003B204 File Offset: 0x00039404
		public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection collection)
		{
			this.CreateExeMap();
			if (this.values == null)
			{
				this.values = new SettingsPropertyValueCollection();
				string text = context["GroupName"] as string;
				this.LoadProperties(this.exeMapCurrent, collection, ConfigurationUserLevel.None, "applicationSettings", false, text);
				this.LoadProperties(this.exeMapCurrent, collection, ConfigurationUserLevel.None, "userSettings", false, text);
				this.LoadProperties(this.exeMapCurrent, collection, ConfigurationUserLevel.PerUserRoaming, "userSettings", true, text);
				this.LoadProperties(this.exeMapCurrent, collection, ConfigurationUserLevel.PerUserRoamingAndLocal, "userSettings", true, text);
				foreach (object obj in collection)
				{
					SettingsProperty settingsProperty = (SettingsProperty)obj;
					if (this.values[settingsProperty.Name] == null)
					{
						this.values.Add(new SettingsPropertyValue(settingsProperty));
					}
				}
			}
			return this.values;
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x0003B30C File Offset: 0x0003950C
		private void CreateExeMap()
		{
			if (this.exeMapCurrent == null)
			{
				CustomizableFileSettingsProvider.CreateUserConfigPath();
				this.exeMapCurrent = new ExeConfigurationFileMap();
				Assembly assembly = Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly();
				this.exeMapCurrent.ExeConfigFilename = assembly.Location + ".config";
				this.exeMapCurrent.LocalUserConfigFilename = CustomizableFileSettingsProvider.UserLocalFullPath;
				this.exeMapCurrent.RoamingUserConfigFilename = CustomizableFileSettingsProvider.UserRoamingFullPath;
				if (CustomizableFileSettingsProvider.webConfigurationFileMapType != null && typeof(ConfigurationFileMap).IsAssignableFrom(CustomizableFileSettingsProvider.webConfigurationFileMapType))
				{
					try
					{
						ConfigurationFileMap configurationFileMap = Activator.CreateInstance(CustomizableFileSettingsProvider.webConfigurationFileMapType) as ConfigurationFileMap;
						if (configurationFileMap != null)
						{
							string machineConfigFilename = configurationFileMap.MachineConfigFilename;
							if (!string.IsNullOrEmpty(machineConfigFilename))
							{
								this.exeMapCurrent.ExeConfigFilename = machineConfigFilename;
							}
						}
					}
					catch
					{
					}
				}
				if (CustomizableFileSettingsProvider.PrevUserLocalFullPath != string.Empty && CustomizableFileSettingsProvider.PrevUserRoamingFullPath != string.Empty)
				{
					this.exeMapPrev = new ExeConfigurationFileMap();
					this.exeMapPrev.ExeConfigFilename = assembly.Location + ".config";
					this.exeMapPrev.LocalUserConfigFilename = CustomizableFileSettingsProvider.PrevUserLocalFullPath;
					this.exeMapPrev.RoamingUserConfigFilename = CustomizableFileSettingsProvider.PrevUserRoamingFullPath;
				}
			}
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00002A97 File Offset: 0x00000C97
		public SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property)
		{
			return null;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x0003B464 File Offset: 0x00039664
		public void Reset(SettingsContext context)
		{
			SettingsPropertyCollection settingsPropertyCollection = new SettingsPropertyCollection();
			this.GetPropertyValues(context, settingsPropertyCollection);
			foreach (object obj in this.values)
			{
				SettingsPropertyValue settingsPropertyValue = (SettingsPropertyValue)obj;
				settingsPropertyValue.PropertyValue = settingsPropertyValue.Reset();
			}
			this.SetPropertyValues(context, this.values);
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x000029F5 File Offset: 0x00000BF5
		public void Upgrade(SettingsContext context, SettingsPropertyCollection properties)
		{
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x0000DBB2 File Offset: 0x0000BDB2
		public static void setCreate()
		{
			CustomizableFileSettingsProvider.CreateUserConfigPath();
		}

		// Token: 0x040004C2 RID: 1218
		private static Type webConfigurationFileMapType;

		// Token: 0x040004C3 RID: 1219
		private static string userRoamingPath = string.Empty;

		// Token: 0x040004C4 RID: 1220
		private static string userLocalPath = string.Empty;

		// Token: 0x040004C5 RID: 1221
		private static string userRoamingPathPrevVersion = string.Empty;

		// Token: 0x040004C6 RID: 1222
		private static string userLocalPathPrevVersion = string.Empty;

		// Token: 0x040004C7 RID: 1223
		private static string userRoamingName = "user.config";

		// Token: 0x040004C8 RID: 1224
		private static string userLocalName = "user.config";

		// Token: 0x040004C9 RID: 1225
		private static string userRoamingBasePath = string.Empty;

		// Token: 0x040004CA RID: 1226
		private static string userLocalBasePath = string.Empty;

		// Token: 0x040004CB RID: 1227
		private static string CompanyName = string.Empty;

		// Token: 0x040004CC RID: 1228
		private static string ProductName = string.Empty;

		// Token: 0x040004CD RID: 1229
		private static string ForceVersion = string.Empty;

		// Token: 0x040004CE RID: 1230
		private static string[] ProductVersion;

		// Token: 0x040004CF RID: 1231
		private static bool isVersionMajor;

		// Token: 0x040004D0 RID: 1232
		private static bool isVersionMinor;

		// Token: 0x040004D1 RID: 1233
		private static bool isVersionBuild;

		// Token: 0x040004D2 RID: 1234
		private static bool isVersionRevision;

		// Token: 0x040004D3 RID: 1235
		private static bool isCompany = true;

		// Token: 0x040004D4 RID: 1236
		private static bool isProduct = true;

		// Token: 0x040004D5 RID: 1237
		private static bool isEvidence;

		// Token: 0x040004D6 RID: 1238
		private static bool userDefine;

		// Token: 0x040004D7 RID: 1239
		private static UserConfigLocationOption userConfig = UserConfigLocationOption.Company_Product;

		// Token: 0x040004D8 RID: 1240
		private string app_name = string.Empty;

		// Token: 0x040004D9 RID: 1241
		private ExeConfigurationFileMap exeMapCurrent;

		// Token: 0x040004DA RID: 1242
		private ExeConfigurationFileMap exeMapPrev;

		// Token: 0x040004DB RID: 1243
		private SettingsPropertyValueCollection values;
	}
}
