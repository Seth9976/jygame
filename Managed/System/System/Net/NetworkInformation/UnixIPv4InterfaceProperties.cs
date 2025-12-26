using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200039B RID: 923
	internal abstract class UnixIPv4InterfaceProperties : IPv4InterfaceProperties
	{
		// Token: 0x06002079 RID: 8313 RVA: 0x00017614 File Offset: 0x00015814
		public UnixIPv4InterfaceProperties(UnixNetworkInterface iface)
		{
			this.iface = iface;
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x00017623 File Offset: 0x00015823
		public override int Index
		{
			get
			{
				return UnixNetworkInterface.IfNameToIndex(this.iface.Name);
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool IsAutomaticPrivateAddressingActive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x0600207C RID: 8316 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool IsAutomaticPrivateAddressingEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x0600207D RID: 8317 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool IsDhcpEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x0600207E RID: 8318 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public override bool UsesWins
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0400138A RID: 5002
		protected UnixNetworkInterface iface;
	}
}
