using System;
using System.Collections.Generic;
using System.Configuration;

namespace System.CodeDom.Compiler
{
	// Token: 0x02000084 RID: 132
	[ConfigurationCollection(typeof(CompilerProviderOption), CollectionType = ConfigurationElementCollectionType.BasicMap, AddItemName = "providerOption")]
	internal sealed class CompilerProviderOptionsCollection : ConfigurationElementCollection
	{
		// Token: 0x0600057D RID: 1405 RVA: 0x00005C80 File Offset: 0x00003E80
		protected override ConfigurationElement CreateNewElement()
		{
			return new CompilerProviderOption();
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00005C87 File Offset: 0x00003E87
		public CompilerProviderOption Get(int index)
		{
			return (CompilerProviderOption)base.BaseGet(index);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00005C95 File Offset: 0x00003E95
		public CompilerProviderOption Get(string name)
		{
			return (CompilerProviderOption)base.BaseGet(name);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00005CA3 File Offset: 0x00003EA3
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((CompilerProviderOption)element).Name;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00005841 File Offset: 0x00003A41
		public string GetKey(int index)
		{
			return (string)base.BaseGetKey(index);
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x0002938C File Offset: 0x0002758C
		public string[] AllKeys
		{
			get
			{
				int count = this.Count;
				string[] array = new string[count];
				for (int i = 0; i < count; i++)
				{
					array[i] = this[i].Name;
				}
				return array;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00005CB0 File Offset: 0x00003EB0
		protected override string ElementName
		{
			get
			{
				return "providerOption";
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x00005CB7 File Offset: 0x00003EB7
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return CompilerProviderOptionsCollection.properties;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x000293CC File Offset: 0x000275CC
		public Dictionary<string, string> ProviderOptions
		{
			get
			{
				int count = this.Count;
				if (count == 0)
				{
					return null;
				}
				Dictionary<string, string> dictionary = new Dictionary<string, string>(count);
				for (int i = 0; i < count; i++)
				{
					CompilerProviderOption compilerProviderOption = this[i];
					dictionary.Add(compilerProviderOption.Name, compilerProviderOption.Value);
				}
				return dictionary;
			}
		}

		// Token: 0x17000110 RID: 272
		public CompilerProviderOption this[int index]
		{
			get
			{
				return (CompilerProviderOption)base.BaseGet(index);
			}
		}

		// Token: 0x17000111 RID: 273
		public CompilerProviderOption this[string name]
		{
			get
			{
				foreach (object obj in this)
				{
					CompilerProviderOption compilerProviderOption = (CompilerProviderOption)obj;
					if (compilerProviderOption.Name == name)
					{
						return compilerProviderOption;
					}
				}
				return null;
			}
		}

		// Token: 0x04000157 RID: 343
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();
	}
}
