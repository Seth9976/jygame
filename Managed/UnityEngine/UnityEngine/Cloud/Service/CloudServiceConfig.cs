using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Cloud.Service
{
	// Token: 0x02000241 RID: 577
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class CloudServiceConfig
	{
		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x0600203C RID: 8252 RVA: 0x0000CB89 File Offset: 0x0000AD89
		// (set) Token: 0x0600203D RID: 8253 RVA: 0x0000CB91 File Offset: 0x0000AD91
		public int maxNumberOfEventInGroup
		{
			get
			{
				return this.m_MaxNumberOfEventInGroup;
			}
			set
			{
				this.m_MaxNumberOfEventInGroup = value;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x0600203E RID: 8254 RVA: 0x0000CB9A File Offset: 0x0000AD9A
		// (set) Token: 0x0600203F RID: 8255 RVA: 0x0000CBA2 File Offset: 0x0000ADA2
		public string sessionHeaderName
		{
			get
			{
				return this.m_SessionHeaderName;
			}
			set
			{
				this.m_SessionHeaderName = value;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06002040 RID: 8256 RVA: 0x0000CBAB File Offset: 0x0000ADAB
		// (set) Token: 0x06002041 RID: 8257 RVA: 0x0000CBB3 File Offset: 0x0000ADB3
		public string eventsHeaderName
		{
			get
			{
				return this.m_EventsHeaderName;
			}
			set
			{
				this.m_EventsHeaderName = value;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06002042 RID: 8258 RVA: 0x0000CBBC File Offset: 0x0000ADBC
		// (set) Token: 0x06002043 RID: 8259 RVA: 0x0000CBC4 File Offset: 0x0000ADC4
		public string eventsEndPoint
		{
			get
			{
				return this.m_EventsEndPoint;
			}
			set
			{
				this.m_EventsEndPoint = value;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06002044 RID: 8260 RVA: 0x0000CBCD File Offset: 0x0000ADCD
		// (set) Token: 0x06002045 RID: 8261 RVA: 0x0000CBD5 File Offset: 0x0000ADD5
		public int[] networkFailureRetryTimeoutInSec
		{
			get
			{
				return this.m_NetworkFailureRetryTimeoutInSec;
			}
			set
			{
				this.m_NetworkFailureRetryTimeoutInSec = value;
			}
		}

		// Token: 0x040008CB RID: 2251
		private int m_MaxNumberOfEventInGroup;

		// Token: 0x040008CC RID: 2252
		private string m_SessionHeaderName;

		// Token: 0x040008CD RID: 2253
		private string m_EventsHeaderName;

		// Token: 0x040008CE RID: 2254
		private string m_EventsEndPoint;

		// Token: 0x040008CF RID: 2255
		private int[] m_NetworkFailureRetryTimeoutInSec;
	}
}
