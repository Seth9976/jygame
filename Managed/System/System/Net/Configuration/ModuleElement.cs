using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the type information for a custom <see cref="T:System.Net.IWebProxy" /> module. This class cannot be inherited.</summary>
	// Token: 0x020002E6 RID: 742
	public sealed class ModuleElement : ConfigurationElement
	{
		// Token: 0x0600193C RID: 6460 RVA: 0x00012A0C File Offset: 0x00010C0C
		static ModuleElement()
		{
			ModuleElement.properties.Add(ModuleElement.typeProp);
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x00012A41 File Offset: 0x00010C41
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return ModuleElement.properties;
			}
		}

		/// <summary>Gets or sets the type and assembly information for the current instance.</summary>
		/// <returns>A string that identifies a type that implements the <see cref="T:System.Net.IWebProxy" /> interface or null if no value has been specified.</returns>
		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x00012A48 File Offset: 0x00010C48
		// (set) Token: 0x0600193F RID: 6463 RVA: 0x00012A5A File Offset: 0x00010C5A
		[ConfigurationProperty("type")]
		public string Type
		{
			get
			{
				return (string)base[ModuleElement.typeProp];
			}
			set
			{
				base[ModuleElement.typeProp] = value;
			}
		}

		// Token: 0x04000FEA RID: 4074
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

		// Token: 0x04000FEB RID: 4075
		private static ConfigurationProperty typeProp = new ConfigurationProperty("type", typeof(string), null);
	}
}
