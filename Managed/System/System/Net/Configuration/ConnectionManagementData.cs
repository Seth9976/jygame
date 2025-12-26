using System;
using System.Collections;

namespace System.Net.Configuration
{
	// Token: 0x020002DB RID: 731
	internal class ConnectionManagementData
	{
		// Token: 0x060018F4 RID: 6388 RVA: 0x0004B864 File Offset: 0x00049A64
		public ConnectionManagementData(object parent)
		{
			this.data = new Hashtable(CaseInsensitiveHashCodeProvider.DefaultInvariant, CaseInsensitiveComparer.DefaultInvariant);
			if (parent != null && parent is ConnectionManagementData)
			{
				ConnectionManagementData connectionManagementData = (ConnectionManagementData)parent;
				foreach (object obj in connectionManagementData.data.Keys)
				{
					string text = (string)obj;
					this.data[text] = connectionManagementData.data[text];
				}
			}
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x0001266A File Offset: 0x0001086A
		public void Add(string address, string nconns)
		{
			if (nconns == null || nconns == string.Empty)
			{
				nconns = "2";
			}
			this.data[address] = uint.Parse(nconns);
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x000126A0 File Offset: 0x000108A0
		public void Add(string address, int nconns)
		{
			this.data[address] = (uint)nconns;
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x000126B4 File Offset: 0x000108B4
		public void Remove(string address)
		{
			this.data.Remove(address);
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x000126C2 File Offset: 0x000108C2
		public void Clear()
		{
			this.data.Clear();
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x0004B910 File Offset: 0x00049B10
		public uint GetMaxConnections(string hostOrIP)
		{
			object obj = this.data[hostOrIP];
			if (obj == null)
			{
				obj = this.data["*"];
			}
			if (obj == null)
			{
				return 2U;
			}
			return (uint)obj;
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x000126CF File Offset: 0x000108CF
		public Hashtable Data
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x04000FD2 RID: 4050
		private const int defaultMaxConnections = 2;

		// Token: 0x04000FD3 RID: 4051
		private Hashtable data;
	}
}
