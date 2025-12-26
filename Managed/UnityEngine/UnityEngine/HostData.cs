using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>This is the data structure for holding individual host information.</para>
	/// </summary>
	// Token: 0x02000073 RID: 115
	[StructLayout(LayoutKind.Sequential)]
	public sealed class HostData
	{
		/// <summary>
		///   <para>Does this server require NAT punchthrough?</para>
		/// </summary>
		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x00004D2E File Offset: 0x00002F2E
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x00004D3C File Offset: 0x00002F3C
		public bool useNat
		{
			get
			{
				return this.m_Nat != 0;
			}
			set
			{
				this.m_Nat = ((!value) ? 0 : 1);
			}
		}

		/// <summary>
		///   <para>The type of the game (like "MyUniqueGameType").</para>
		/// </summary>
		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x00004D51 File Offset: 0x00002F51
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x00004D59 File Offset: 0x00002F59
		public string gameType
		{
			get
			{
				return this.m_GameType;
			}
			set
			{
				this.m_GameType = value;
			}
		}

		/// <summary>
		///   <para>The name of the game (like John Doe's Game).</para>
		/// </summary>
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00004D62 File Offset: 0x00002F62
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x00004D6A File Offset: 0x00002F6A
		public string gameName
		{
			get
			{
				return this.m_GameName;
			}
			set
			{
				this.m_GameName = value;
			}
		}

		/// <summary>
		///   <para>Currently connected players.</para>
		/// </summary>
		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x00004D73 File Offset: 0x00002F73
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x00004D7B File Offset: 0x00002F7B
		public int connectedPlayers
		{
			get
			{
				return this.m_ConnectedPlayers;
			}
			set
			{
				this.m_ConnectedPlayers = value;
			}
		}

		/// <summary>
		///   <para>Maximum players limit.</para>
		/// </summary>
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x00004D84 File Offset: 0x00002F84
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x00004D8C File Offset: 0x00002F8C
		public int playerLimit
		{
			get
			{
				return this.m_PlayerLimit;
			}
			set
			{
				this.m_PlayerLimit = value;
			}
		}

		/// <summary>
		///   <para>Server IP address.</para>
		/// </summary>
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00004D95 File Offset: 0x00002F95
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x00004D9D File Offset: 0x00002F9D
		public string[] ip
		{
			get
			{
				return this.m_IP;
			}
			set
			{
				this.m_IP = value;
			}
		}

		/// <summary>
		///   <para>Server port.</para>
		/// </summary>
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00004DA6 File Offset: 0x00002FA6
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x00004DAE File Offset: 0x00002FAE
		public int port
		{
			get
			{
				return this.m_Port;
			}
			set
			{
				this.m_Port = value;
			}
		}

		/// <summary>
		///   <para>Does the server require a password?</para>
		/// </summary>
		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00004DB7 File Offset: 0x00002FB7
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00004DC5 File Offset: 0x00002FC5
		public bool passwordProtected
		{
			get
			{
				return this.m_PasswordProtected != 0;
			}
			set
			{
				this.m_PasswordProtected = ((!value) ? 0 : 1);
			}
		}

		/// <summary>
		///   <para>A miscellaneous comment (can hold data).</para>
		/// </summary>
		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00004DDA File Offset: 0x00002FDA
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x00004DE2 File Offset: 0x00002FE2
		public string comment
		{
			get
			{
				return this.m_Comment;
			}
			set
			{
				this.m_Comment = value;
			}
		}

		/// <summary>
		///   <para>The GUID of the host, needed when connecting with NAT punchthrough.</para>
		/// </summary>
		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00004DEB File Offset: 0x00002FEB
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x00004DF3 File Offset: 0x00002FF3
		public string guid
		{
			get
			{
				return this.m_GUID;
			}
			set
			{
				this.m_GUID = value;
			}
		}

		// Token: 0x04000148 RID: 328
		private int m_Nat;

		// Token: 0x04000149 RID: 329
		private string m_GameType;

		// Token: 0x0400014A RID: 330
		private string m_GameName;

		// Token: 0x0400014B RID: 331
		private int m_ConnectedPlayers;

		// Token: 0x0400014C RID: 332
		private int m_PlayerLimit;

		// Token: 0x0400014D RID: 333
		private string[] m_IP;

		// Token: 0x0400014E RID: 334
		private int m_Port;

		// Token: 0x0400014F RID: 335
		private int m_PasswordProtected;

		// Token: 0x04000150 RID: 336
		private string m_Comment;

		// Token: 0x04000151 RID: 337
		private string m_GUID;
	}
}
