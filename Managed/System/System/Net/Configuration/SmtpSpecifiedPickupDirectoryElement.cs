using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents an SMTP pickup directory configuration element.</summary>
	// Token: 0x020002F4 RID: 756
	public sealed class SmtpSpecifiedPickupDirectoryElement : ConfigurationElement
	{
		// Token: 0x0600199E RID: 6558 RVA: 0x00012F59 File Offset: 0x00011159
		static SmtpSpecifiedPickupDirectoryElement()
		{
			SmtpSpecifiedPickupDirectoryElement.properties.Add(SmtpSpecifiedPickupDirectoryElement.pickupDirectoryLocationProp);
		}

		/// <summary>Gets or sets the folder where applications save mail messages to be processed by the SMTP server.</summary>
		/// <returns>A string that specifies the pickup directory for e-mail messages.</returns>
		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x0600199F RID: 6559 RVA: 0x00012F8D File Offset: 0x0001118D
		// (set) Token: 0x060019A0 RID: 6560 RVA: 0x00012F9F File Offset: 0x0001119F
		[ConfigurationProperty("pickupDirectoryLocation")]
		public string PickupDirectoryLocation
		{
			get
			{
				return (string)base[SmtpSpecifiedPickupDirectoryElement.pickupDirectoryLocationProp];
			}
			set
			{
				base[SmtpSpecifiedPickupDirectoryElement.pickupDirectoryLocationProp] = value;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x00012FAD File Offset: 0x000111AD
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return SmtpSpecifiedPickupDirectoryElement.properties;
			}
		}

		// Token: 0x04001015 RID: 4117
		private static ConfigurationProperty pickupDirectoryLocationProp = new ConfigurationProperty("pickupDirectoryLocation", typeof(string));

		// Token: 0x04001016 RID: 4118
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();
	}
}
