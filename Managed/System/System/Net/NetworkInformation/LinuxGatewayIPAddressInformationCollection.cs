using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000374 RID: 884
	internal class LinuxGatewayIPAddressInformationCollection : GatewayIPAddressInformationCollection
	{
		// Token: 0x06001EBF RID: 7871 RVA: 0x00016632 File Offset: 0x00014832
		private LinuxGatewayIPAddressInformationCollection(bool isReadOnly)
		{
			this.is_readonly = isReadOnly;
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x0005F760 File Offset: 0x0005D960
		public LinuxGatewayIPAddressInformationCollection(IPAddressCollection col)
		{
			foreach (IPAddress ipaddress in col)
			{
				this.Add(new GatewayIPAddressInformationImpl(ipaddress));
			}
			this.is_readonly = true;
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x0001664E File Offset: 0x0001484E
		public override bool IsReadOnly
		{
			get
			{
				return this.is_readonly;
			}
		}

		// Token: 0x040012FA RID: 4858
		public static readonly LinuxGatewayIPAddressInformationCollection Empty = new LinuxGatewayIPAddressInformationCollection(true);

		// Token: 0x040012FB RID: 4859
		private bool is_readonly;
	}
}
