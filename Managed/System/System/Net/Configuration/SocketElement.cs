using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents information used to configure <see cref="T:System.Net.Sockets.Socket" /> objects. This class cannot be inherited.</summary>
	// Token: 0x020002F5 RID: 757
	public sealed class SocketElement : ConfigurationElement
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.SocketElement" /> class. </summary>
		// Token: 0x060019A2 RID: 6562 RVA: 0x0004CB44 File Offset: 0x0004AD44
		public SocketElement()
		{
			SocketElement.alwaysUseCompletionPortsForAcceptProp = new ConfigurationProperty("alwaysUseCompletionPortsForAccept", typeof(bool), false);
			SocketElement.alwaysUseCompletionPortsForConnectProp = new ConfigurationProperty("alwaysUseCompletionPortsForConnect", typeof(bool), false);
			SocketElement.properties = new ConfigurationPropertyCollection();
			SocketElement.properties.Add(SocketElement.alwaysUseCompletionPortsForAcceptProp);
			SocketElement.properties.Add(SocketElement.alwaysUseCompletionPortsForConnectProp);
		}

		/// <summary>Gets or sets a Boolean value that specifies whether completion ports are used when accepting connections.</summary>
		/// <returns>true to use completion ports; otherwise, false.</returns>
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x00012FB4 File Offset: 0x000111B4
		// (set) Token: 0x060019A4 RID: 6564 RVA: 0x00012FC6 File Offset: 0x000111C6
		[ConfigurationProperty("alwaysUseCompletionPortsForAccept", DefaultValue = "False")]
		public bool AlwaysUseCompletionPortsForAccept
		{
			get
			{
				return (bool)base[SocketElement.alwaysUseCompletionPortsForAcceptProp];
			}
			set
			{
				base[SocketElement.alwaysUseCompletionPortsForAcceptProp] = value;
			}
		}

		/// <summary>Gets or sets a Boolean value that specifies whether completion ports are used when making connections.</summary>
		/// <returns>true to use completion ports; otherwise, false.</returns>
		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060019A5 RID: 6565 RVA: 0x00012FD9 File Offset: 0x000111D9
		// (set) Token: 0x060019A6 RID: 6566 RVA: 0x00012FEB File Offset: 0x000111EB
		[ConfigurationProperty("alwaysUseCompletionPortsForConnect", DefaultValue = "False")]
		public bool AlwaysUseCompletionPortsForConnect
		{
			get
			{
				return (bool)base[SocketElement.alwaysUseCompletionPortsForConnectProp];
			}
			set
			{
				base[SocketElement.alwaysUseCompletionPortsForConnectProp] = value;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x060019A7 RID: 6567 RVA: 0x00012FFE File Offset: 0x000111FE
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return SocketElement.properties;
			}
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO]
		protected override void PostDeserialize()
		{
		}

		// Token: 0x04001017 RID: 4119
		private static ConfigurationPropertyCollection properties;

		// Token: 0x04001018 RID: 4120
		private static ConfigurationProperty alwaysUseCompletionPortsForAcceptProp;

		// Token: 0x04001019 RID: 4121
		private static ConfigurationProperty alwaysUseCompletionPortsForConnectProp;
	}
}
