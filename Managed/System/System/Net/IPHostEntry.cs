using System;

namespace System.Net
{
	/// <summary>Provides a container class for Internet host address information.</summary>
	// Token: 0x02000342 RID: 834
	public class IPHostEntry
	{
		/// <summary>Gets or sets a list of IP addresses that are associated with a host.</summary>
		/// <returns>An array of type <see cref="T:System.Net.IPAddress" /> that contains IP addresses that resolve to the host names that are contained in the <see cref="P:System.Net.IPHostEntry.Aliases" /> property.</returns>
		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06001D36 RID: 7478 RVA: 0x00015209 File Offset: 0x00013409
		// (set) Token: 0x06001D37 RID: 7479 RVA: 0x00015211 File Offset: 0x00013411
		public IPAddress[] AddressList
		{
			get
			{
				return this.addressList;
			}
			set
			{
				this.addressList = value;
			}
		}

		/// <summary>Gets or sets a list of aliases that are associated with a host.</summary>
		/// <returns>An array of strings that contain DNS names that resolve to the IP addresses in the <see cref="P:System.Net.IPHostEntry.AddressList" /> property.</returns>
		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x0001521A File Offset: 0x0001341A
		// (set) Token: 0x06001D39 RID: 7481 RVA: 0x00015222 File Offset: 0x00013422
		public string[] Aliases
		{
			get
			{
				return this.aliases;
			}
			set
			{
				this.aliases = value;
			}
		}

		/// <summary>Gets or sets the DNS name of the host.</summary>
		/// <returns>A string that contains the primary host name for the server.</returns>
		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x0001522B File Offset: 0x0001342B
		// (set) Token: 0x06001D3B RID: 7483 RVA: 0x00015233 File Offset: 0x00013433
		public string HostName
		{
			get
			{
				return this.hostName;
			}
			set
			{
				this.hostName = value;
			}
		}

		// Token: 0x0400122C RID: 4652
		private IPAddress[] addressList;

		// Token: 0x0400122D RID: 4653
		private string[] aliases;

		// Token: 0x0400122E RID: 4654
		private string hostName;
	}
}
