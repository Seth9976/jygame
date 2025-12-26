using System;

namespace System.Net.NetworkInformation
{
	// Token: 0x020003A5 RID: 933
	internal class Win32IPv6InterfaceProperties : IPv6InterfaceProperties
	{
		// Token: 0x060020C7 RID: 8391 RVA: 0x00017802 File Offset: 0x00015A02
		public Win32IPv6InterfaceProperties(Win32_MIB_IFROW mib)
		{
			this.mib = mib;
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x060020C8 RID: 8392 RVA: 0x00017811 File Offset: 0x00015A11
		public override int Index
		{
			get
			{
				return this.mib.Index;
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x0001781E File Offset: 0x00015A1E
		public override int Mtu
		{
			get
			{
				return this.mib.Mtu;
			}
		}

		// Token: 0x04001395 RID: 5013
		private Win32_MIB_IFROW mib;
	}
}
