using System;

namespace System.Configuration
{
	/// <summary>Provides the configuration setting for International Resource Identifier (IRI) processing in the <see cref="T:System.Uri" /> class.</summary>
	// Token: 0x020001E9 RID: 489
	public sealed class IriParsingElement : ConfigurationElement
	{
		// Token: 0x060010DF RID: 4319 RVA: 0x0000DC6A File Offset: 0x0000BE6A
		static IriParsingElement()
		{
			IriParsingElement.properties.Add(IriParsingElement.enabled_prop);
		}

		/// <summary>Gets or sets the value of the <see cref="T:System.Configuration.IriParsingElement" /> configuration setting.</summary>
		/// <returns>A Boolean that indicates if International Resource Identifier (IRI) processing is enabled. </returns>
		// Token: 0x170003CA RID: 970
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x0000DCA5 File Offset: 0x0000BEA5
		// (set) Token: 0x060010E1 RID: 4321 RVA: 0x0000DCB7 File Offset: 0x0000BEB7
		[ConfigurationProperty("enabled", DefaultValue = false, Options = ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey)]
		public bool Enabled
		{
			get
			{
				return (bool)base[IriParsingElement.enabled_prop];
			}
			set
			{
				base[IriParsingElement.enabled_prop] = value;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x0000DCCA File Offset: 0x0000BECA
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return IriParsingElement.properties;
			}
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0003B514 File Offset: 0x00039714
		public override bool Equals(object o)
		{
			IriParsingElement iriParsingElement = o as IriParsingElement;
			return iriParsingElement != null && iriParsingElement.Enabled == this.Enabled;
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0000DCD1 File Offset: 0x0000BED1
		public override int GetHashCode()
		{
			return Convert.ToInt32(this.Enabled) ^ 127;
		}

		// Token: 0x040004DF RID: 1247
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

		// Token: 0x040004E0 RID: 1248
		private static ConfigurationProperty enabled_prop = new ConfigurationProperty("enabled", typeof(bool), false, ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey);
	}
}
