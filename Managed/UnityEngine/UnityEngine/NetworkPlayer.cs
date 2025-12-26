using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The NetworkPlayer is a data structure with which you can locate another player over the network.</para>
	/// </summary>
	// Token: 0x0200006C RID: 108
	public struct NetworkPlayer
	{
		// Token: 0x06000656 RID: 1622 RVA: 0x00004AC4 File Offset: 0x00002CC4
		public NetworkPlayer(string ip, int port)
		{
			Debug.LogError("Not yet implemented");
			this.index = 0;
		}

		// Token: 0x06000657 RID: 1623
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string Internal_GetIPAddress(int index);

		// Token: 0x06000658 RID: 1624
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetPort(int index);

		// Token: 0x06000659 RID: 1625
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string Internal_GetExternalIP();

		// Token: 0x0600065A RID: 1626
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetExternalPort();

		// Token: 0x0600065B RID: 1627
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string Internal_GetLocalIP();

		// Token: 0x0600065C RID: 1628
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetLocalPort();

		// Token: 0x0600065D RID: 1629
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetPlayerIndex();

		// Token: 0x0600065E RID: 1630
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string Internal_GetGUID(int index);

		// Token: 0x0600065F RID: 1631
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string Internal_GetLocalGUID();

		// Token: 0x06000660 RID: 1632 RVA: 0x00004AD7 File Offset: 0x00002CD7
		public override int GetHashCode()
		{
			return this.index.GetHashCode();
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00013ACC File Offset: 0x00011CCC
		public override bool Equals(object other)
		{
			return other is NetworkPlayer && ((NetworkPlayer)other).index == this.index;
		}

		/// <summary>
		///   <para>The IP address of this player.</para>
		/// </summary>
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x00004AE4 File Offset: 0x00002CE4
		public string ipAddress
		{
			get
			{
				if (this.index == NetworkPlayer.Internal_GetPlayerIndex())
				{
					return NetworkPlayer.Internal_GetLocalIP();
				}
				return NetworkPlayer.Internal_GetIPAddress(this.index);
			}
		}

		/// <summary>
		///   <para>The port of this player.</para>
		/// </summary>
		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x00004B07 File Offset: 0x00002D07
		public int port
		{
			get
			{
				if (this.index == NetworkPlayer.Internal_GetPlayerIndex())
				{
					return NetworkPlayer.Internal_GetLocalPort();
				}
				return NetworkPlayer.Internal_GetPort(this.index);
			}
		}

		/// <summary>
		///   <para>The GUID for this player, used when connecting with NAT punchthrough.</para>
		/// </summary>
		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00004B2A File Offset: 0x00002D2A
		public string guid
		{
			get
			{
				if (this.index == NetworkPlayer.Internal_GetPlayerIndex())
				{
					return NetworkPlayer.Internal_GetLocalGUID();
				}
				return NetworkPlayer.Internal_GetGUID(this.index);
			}
		}

		/// <summary>
		///   <para>Returns the index number for this network player.</para>
		/// </summary>
		// Token: 0x06000665 RID: 1637 RVA: 0x00004B4D File Offset: 0x00002D4D
		public override string ToString()
		{
			return this.index.ToString();
		}

		/// <summary>
		///   <para>Returns the external IP address of the network interface.</para>
		/// </summary>
		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00004B5A File Offset: 0x00002D5A
		public string externalIP
		{
			get
			{
				return NetworkPlayer.Internal_GetExternalIP();
			}
		}

		/// <summary>
		///   <para>Returns the external port of the network interface.</para>
		/// </summary>
		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x00004B61 File Offset: 0x00002D61
		public int externalPort
		{
			get
			{
				return NetworkPlayer.Internal_GetExternalPort();
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00013AFC File Offset: 0x00011CFC
		internal static NetworkPlayer unassigned
		{
			get
			{
				NetworkPlayer networkPlayer;
				networkPlayer.index = -1;
				return networkPlayer;
			}
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00004B68 File Offset: 0x00002D68
		public static bool operator ==(NetworkPlayer lhs, NetworkPlayer rhs)
		{
			return lhs.index == rhs.index;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00004B7A File Offset: 0x00002D7A
		public static bool operator !=(NetworkPlayer lhs, NetworkPlayer rhs)
		{
			return lhs.index != rhs.index;
		}

		// Token: 0x04000142 RID: 322
		internal int index;
	}
}
