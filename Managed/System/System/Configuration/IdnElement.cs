using System;

namespace System.Configuration
{
	/// <summary>Provides the configuration setting for International Domain Name (IDN) processing in the <see cref="T:System.Uri" /> class.</summary>
	// Token: 0x020001E7 RID: 487
	public sealed class IdnElement : ConfigurationElement
	{
		// Token: 0x060010D6 RID: 4310 RVA: 0x0000DBF8 File Offset: 0x0000BDF8
		static IdnElement()
		{
			IdnElement.properties.Add(IdnElement.enabled_prop);
		}

		/// <summary>Gets or sets the value of the <see cref="T:System.Configuration.IdnElement" /> configuration setting. </summary>
		/// <returns>A <see cref="T:System.UriIdnScope" /> that contains the current configuration setting for IDN processing.</returns>
		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x0000DC33 File Offset: 0x0000BE33
		// (set) Token: 0x060010D8 RID: 4312 RVA: 0x0000DC45 File Offset: 0x0000BE45
		[ConfigurationProperty("enabled", DefaultValue = global::System.UriIdnScope.None, Options = ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey)]
		public global::System.UriIdnScope Enabled
		{
			get
			{
				return (global::System.UriIdnScope)((int)base[IdnElement.enabled_prop]);
			}
			set
			{
				base[IdnElement.enabled_prop] = value;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x0000DC58 File Offset: 0x0000BE58
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return IdnElement.properties;
			}
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0003B4E8 File Offset: 0x000396E8
		public override bool Equals(object o)
		{
			IdnElement idnElement = o as IdnElement;
			return idnElement != null && idnElement.Enabled == this.Enabled;
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x0000DC5F File Offset: 0x0000BE5F
		public override int GetHashCode()
		{
			return (int)(this.Enabled ^ (global::System.UriIdnScope)127);
		}

		// Token: 0x040004DD RID: 1245
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

		// Token: 0x040004DE RID: 1246
		private static ConfigurationProperty enabled_prop = new ConfigurationProperty("enabled", typeof(global::System.UriIdnScope), global::System.UriIdnScope.None, ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey);
	}
}
