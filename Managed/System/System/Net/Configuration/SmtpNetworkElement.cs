using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the network element in the SMTP configuration file. This class cannot be inherited.</summary>
	// Token: 0x020002F2 RID: 754
	public sealed class SmtpNetworkElement : ConfigurationElement
	{
		/// <summary>Determines whether or not default user credentials are used to access an SMTP server. The default value is false.</summary>
		/// <returns>true indicates that default user credentials will be used to access the SMTP server; otherwise, false.</returns>
		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001989 RID: 6537 RVA: 0x00012E46 File Offset: 0x00011046
		// (set) Token: 0x0600198A RID: 6538 RVA: 0x00012E58 File Offset: 0x00011058
		[ConfigurationProperty("defaultCredentials", DefaultValue = "False")]
		public bool DefaultCredentials
		{
			get
			{
				return (bool)base["defaultCredentials"];
			}
			set
			{
				base["defaultCredentials"] = value;
			}
		}

		/// <summary>Gets or sets the name of the SMTP server.</summary>
		/// <returns>A string that represents the name of the SMTP server to connect to.</returns>
		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x0600198B RID: 6539 RVA: 0x00012E6B File Offset: 0x0001106B
		// (set) Token: 0x0600198C RID: 6540 RVA: 0x00012E7D File Offset: 0x0001107D
		[ConfigurationProperty("host")]
		public string Host
		{
			get
			{
				return (string)base["host"];
			}
			set
			{
				base["host"] = value;
			}
		}

		/// <summary>Gets or sets the user password to use to connect to an SMTP mail server.</summary>
		/// <returns>A string that represents the password to use to connect to an SMTP mail server.</returns>
		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x00012E8B File Offset: 0x0001108B
		// (set) Token: 0x0600198E RID: 6542 RVA: 0x00012E9D File Offset: 0x0001109D
		[ConfigurationProperty("password")]
		public string Password
		{
			get
			{
				return (string)base["password"];
			}
			set
			{
				base["password"] = value;
			}
		}

		/// <summary>Gets or sets the port that SMTP clients use to connect to an SMTP mail server. The default value is 25.</summary>
		/// <returns>A string that represents the port to connect to an SMTP mail server.</returns>
		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x00012EAB File Offset: 0x000110AB
		// (set) Token: 0x06001990 RID: 6544 RVA: 0x00012EBD File Offset: 0x000110BD
		[ConfigurationProperty("port", DefaultValue = "25")]
		public int Port
		{
			get
			{
				return (int)base["port"];
			}
			set
			{
				base["port"] = value;
			}
		}

		/// <summary>Gets or sets the user name to connect to an SMTP mail server.</summary>
		/// <returns>A string that represents the user name to connect to an SMTP mail server.</returns>
		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x00012ED0 File Offset: 0x000110D0
		// (set) Token: 0x06001992 RID: 6546 RVA: 0x00012EE2 File Offset: 0x000110E2
		[ConfigurationProperty("userName", DefaultValue = null)]
		public string UserName
		{
			get
			{
				return (string)base["userName"];
			}
			set
			{
				base["userName"] = value;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x0000E304 File Offset: 0x0000C504
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return base.Properties;
			}
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x000029F5 File Offset: 0x00000BF5
		protected override void PostDeserialize()
		{
		}
	}
}
