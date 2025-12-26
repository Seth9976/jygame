using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000376 RID: 886
	internal class GatewayIPAddressInformationImpl : GatewayIPAddressInformation
	{
		// Token: 0x06001EC5 RID: 7877 RVA: 0x00016656 File Offset: 0x00014856
		public GatewayIPAddressInformationImpl(IPAddress address)
		{
			this.address = address;
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x00016665 File Offset: 0x00014865
		public override IPAddress Address
		{
			get
			{
				return this.address;
			}
		}

		// Token: 0x040012FC RID: 4860
		private IPAddress address;
	}
}
