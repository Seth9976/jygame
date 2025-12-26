using System;
using System.Configuration;
using System.Net.Mail;

namespace System.Net.Configuration
{
	/// <summary>Represents the SMTP section in the System.Net configuration file.</summary>
	// Token: 0x020002F3 RID: 755
	public sealed class SmtpSection : ConfigurationSection
	{
		/// <summary>Gets or sets the SMTP delivery method. The default delivery method is <see cref="F:System.Net.Mail.SmtpDeliveryMethod.Network" />.</summary>
		/// <returns>A string that represents the SMTP delivery method.</returns>
		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x00012EF0 File Offset: 0x000110F0
		// (set) Token: 0x06001997 RID: 6551 RVA: 0x00012F02 File Offset: 0x00011102
		[ConfigurationProperty("deliveryMethod", DefaultValue = "Network")]
		public global::System.Net.Mail.SmtpDeliveryMethod DeliveryMethod
		{
			get
			{
				return (global::System.Net.Mail.SmtpDeliveryMethod)((int)base["deliveryMethod"]);
			}
			set
			{
				base["deliveryMethod"] = value;
			}
		}

		/// <summary>Gets or sets the default value that indicates who the email message is from.</summary>
		/// <returns>A string that represents the default value indicating who a mail message is from.</returns>
		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001998 RID: 6552 RVA: 0x00012F15 File Offset: 0x00011115
		// (set) Token: 0x06001999 RID: 6553 RVA: 0x00012F27 File Offset: 0x00011127
		[ConfigurationProperty("from")]
		public string From
		{
			get
			{
				return (string)base["from"];
			}
			set
			{
				base["from"] = value;
			}
		}

		/// <summary>Gets a <see cref="T:System.Net.Configuration.SmtpNetworkElement" />.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.SmtpNetworkElement" /> object.</returns>
		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x0600199A RID: 6554 RVA: 0x00012F35 File Offset: 0x00011135
		[ConfigurationProperty("network")]
		public SmtpNetworkElement Network
		{
			get
			{
				return (SmtpNetworkElement)base["network"];
			}
		}

		/// <summary>Gets the pickup directory that will be used by the SMPT client.</summary>
		/// <returns>A <see cref="T:System.Net.Configuration.SmtpSpecifiedPickupDirectoryElement" /> object that specifies the pickup directory folder.</returns>
		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x00012F47 File Offset: 0x00011147
		[ConfigurationProperty("specifiedPickupDirectory")]
		public SmtpSpecifiedPickupDirectoryElement SpecifiedPickupDirectory
		{
			get
			{
				return (SmtpSpecifiedPickupDirectoryElement)base["specifiedPickupDirectory"];
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x0000E304 File Offset: 0x0000C504
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return base.Properties;
			}
		}
	}
}
