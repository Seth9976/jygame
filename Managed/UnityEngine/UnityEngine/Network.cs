using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngineInternal;

namespace UnityEngine
{
	/// <summary>
	///   <para>The network class is at the heart of the network implementation and provides the core functions.</para>
	/// </summary>
	// Token: 0x02000070 RID: 112
	public sealed class Network
	{
		/// <summary>
		///   <para>Initialize the server.</para>
		/// </summary>
		/// <param name="connections"></param>
		/// <param name="listenPort"></param>
		/// <param name="useNat"></param>
		// Token: 0x06000698 RID: 1688
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern NetworkConnectionError InitializeServer(int connections, int listenPort, bool useNat);

		// Token: 0x06000699 RID: 1689
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern NetworkConnectionError Internal_InitializeServerDeprecated(int connections, int listenPort);

		/// <summary>
		///   <para>Initialize the server.</para>
		/// </summary>
		/// <param name="connections"></param>
		/// <param name="listenPort"></param>
		/// <param name="useNat"></param>
		// Token: 0x0600069A RID: 1690 RVA: 0x00004C2D File Offset: 0x00002E2D
		[Obsolete("Use the IntializeServer(connections, listenPort, useNat) function instead")]
		public static NetworkConnectionError InitializeServer(int connections, int listenPort)
		{
			return Network.Internal_InitializeServerDeprecated(connections, listenPort);
		}

		/// <summary>
		///   <para>Set the password for the server (for incoming connections).</para>
		/// </summary>
		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600069B RID: 1691
		// (set) Token: 0x0600069C RID: 1692
		public static extern string incomingPassword
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Set the log level for network messages (default is Off).</para>
		/// </summary>
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600069D RID: 1693
		// (set) Token: 0x0600069E RID: 1694
		public static extern NetworkLogLevel logLevel
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Initializes security layer.</para>
		/// </summary>
		// Token: 0x0600069F RID: 1695
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void InitializeSecurity();

		// Token: 0x060006A0 RID: 1696
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern NetworkConnectionError Internal_ConnectToSingleIP(string IP, int remotePort, int localPort, [DefaultValue("\"\"")] string password);

		// Token: 0x060006A1 RID: 1697 RVA: 0x00013BF8 File Offset: 0x00011DF8
		[ExcludeFromDocs]
		private static NetworkConnectionError Internal_ConnectToSingleIP(string IP, int remotePort, int localPort)
		{
			string empty = string.Empty;
			return Network.Internal_ConnectToSingleIP(IP, remotePort, localPort, empty);
		}

		// Token: 0x060006A2 RID: 1698
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern NetworkConnectionError Internal_ConnectToGuid(string guid, string password);

		// Token: 0x060006A3 RID: 1699
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern NetworkConnectionError Internal_ConnectToIPs(string[] IP, int remotePort, int localPort, [DefaultValue("\"\"")] string password);

		// Token: 0x060006A4 RID: 1700 RVA: 0x00013C14 File Offset: 0x00011E14
		[ExcludeFromDocs]
		private static NetworkConnectionError Internal_ConnectToIPs(string[] IP, int remotePort, int localPort)
		{
			string empty = string.Empty;
			return Network.Internal_ConnectToIPs(IP, remotePort, localPort, empty);
		}

		/// <summary>
		///   <para>Connect to the specified host (ip or domain name) and server port.</para>
		/// </summary>
		/// <param name="IP"></param>
		/// <param name="remotePort"></param>
		/// <param name="password"></param>
		// Token: 0x060006A5 RID: 1701 RVA: 0x00013C30 File Offset: 0x00011E30
		[ExcludeFromDocs]
		public static NetworkConnectionError Connect(string IP, int remotePort)
		{
			string empty = string.Empty;
			return Network.Connect(IP, remotePort, empty);
		}

		/// <summary>
		///   <para>Connect to the specified host (ip or domain name) and server port.</para>
		/// </summary>
		/// <param name="IP"></param>
		/// <param name="remotePort"></param>
		/// <param name="password"></param>
		// Token: 0x060006A6 RID: 1702 RVA: 0x00004C36 File Offset: 0x00002E36
		public static NetworkConnectionError Connect(string IP, int remotePort, [DefaultValue("\"\"")] string password)
		{
			return Network.Internal_ConnectToSingleIP(IP, remotePort, 0, password);
		}

		/// <summary>
		///   <para>This function is exactly like Network.Connect but can accept an array of IP addresses.</para>
		/// </summary>
		/// <param name="IPs"></param>
		/// <param name="remotePort"></param>
		/// <param name="password"></param>
		// Token: 0x060006A7 RID: 1703 RVA: 0x00013C4C File Offset: 0x00011E4C
		[ExcludeFromDocs]
		public static NetworkConnectionError Connect(string[] IPs, int remotePort)
		{
			string empty = string.Empty;
			return Network.Connect(IPs, remotePort, empty);
		}

		/// <summary>
		///   <para>This function is exactly like Network.Connect but can accept an array of IP addresses.</para>
		/// </summary>
		/// <param name="IPs"></param>
		/// <param name="remotePort"></param>
		/// <param name="password"></param>
		// Token: 0x060006A8 RID: 1704 RVA: 0x00004C41 File Offset: 0x00002E41
		public static NetworkConnectionError Connect(string[] IPs, int remotePort, [DefaultValue("\"\"")] string password)
		{
			return Network.Internal_ConnectToIPs(IPs, remotePort, 0, password);
		}

		/// <summary>
		///   <para>Connect to a server GUID. NAT punchthrough can only be performed this way.</para>
		/// </summary>
		/// <param name="GUID"></param>
		/// <param name="password"></param>
		// Token: 0x060006A9 RID: 1705 RVA: 0x00013C68 File Offset: 0x00011E68
		[ExcludeFromDocs]
		public static NetworkConnectionError Connect(string GUID)
		{
			string empty = string.Empty;
			return Network.Connect(GUID, empty);
		}

		/// <summary>
		///   <para>Connect to a server GUID. NAT punchthrough can only be performed this way.</para>
		/// </summary>
		/// <param name="GUID"></param>
		/// <param name="password"></param>
		// Token: 0x060006AA RID: 1706 RVA: 0x00004C4C File Offset: 0x00002E4C
		public static NetworkConnectionError Connect(string GUID, [DefaultValue("\"\"")] string password)
		{
			return Network.Internal_ConnectToGuid(GUID, password);
		}

		/// <summary>
		///   <para>Connect to the host represented by a HostData structure returned by the Master Server.</para>
		/// </summary>
		/// <param name="hostData"></param>
		/// <param name="password"></param>
		// Token: 0x060006AB RID: 1707 RVA: 0x00013C84 File Offset: 0x00011E84
		[ExcludeFromDocs]
		public static NetworkConnectionError Connect(HostData hostData)
		{
			string empty = string.Empty;
			return Network.Connect(hostData, empty);
		}

		/// <summary>
		///   <para>Connect to the host represented by a HostData structure returned by the Master Server.</para>
		/// </summary>
		/// <param name="hostData"></param>
		/// <param name="password"></param>
		// Token: 0x060006AC RID: 1708 RVA: 0x00013CA0 File Offset: 0x00011EA0
		public static NetworkConnectionError Connect(HostData hostData, [DefaultValue("\"\"")] string password)
		{
			if (hostData == null)
			{
				throw new NullReferenceException();
			}
			if (hostData.guid.Length > 0 && hostData.useNat)
			{
				return Network.Connect(hostData.guid, password);
			}
			return Network.Connect(hostData.ip, hostData.port, password);
		}

		/// <summary>
		///   <para>Close all open connections and shuts down the network interface.</para>
		/// </summary>
		/// <param name="timeout"></param>
		// Token: 0x060006AD RID: 1709
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Disconnect([DefaultValue("200")] int timeout);

		// Token: 0x060006AE RID: 1710 RVA: 0x00013CF4 File Offset: 0x00011EF4
		[ExcludeFromDocs]
		public static void Disconnect()
		{
			int num = 200;
			Network.Disconnect(num);
		}

		/// <summary>
		///   <para>Close the connection to another system.</para>
		/// </summary>
		/// <param name="target"></param>
		/// <param name="sendDisconnectionNotification"></param>
		// Token: 0x060006AF RID: 1711
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CloseConnection(NetworkPlayer target, bool sendDisconnectionNotification);

		/// <summary>
		///   <para>All connected players.</para>
		/// </summary>
		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060006B0 RID: 1712
		public static extern NetworkPlayer[] connections
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x060006B1 RID: 1713
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetPlayer();

		/// <summary>
		///   <para>Get the local NetworkPlayer instance.</para>
		/// </summary>
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00013D10 File Offset: 0x00011F10
		public static NetworkPlayer player
		{
			get
			{
				NetworkPlayer networkPlayer;
				networkPlayer.index = Network.Internal_GetPlayer();
				return networkPlayer;
			}
		}

		// Token: 0x060006B3 RID: 1715
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_AllocateViewID(out NetworkViewID viewID);

		/// <summary>
		///   <para>Query for the next available network view ID number and allocate it (reserve).</para>
		/// </summary>
		// Token: 0x060006B4 RID: 1716 RVA: 0x00013D2C File Offset: 0x00011F2C
		public static NetworkViewID AllocateViewID()
		{
			NetworkViewID networkViewID;
			Network.Internal_AllocateViewID(out networkViewID);
			return networkViewID;
		}

		/// <summary>
		///   <para>Network instantiate a prefab.</para>
		/// </summary>
		/// <param name="prefab"></param>
		/// <param name="position"></param>
		/// <param name="rotation"></param>
		/// <param name="group"></param>
		// Token: 0x060006B5 RID: 1717 RVA: 0x00004C55 File Offset: 0x00002E55
		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object prefab, Vector3 position, Quaternion rotation, int group)
		{
			return Network.INTERNAL_CALL_Instantiate(prefab, ref position, ref rotation, group);
		}

		// Token: 0x060006B6 RID: 1718
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Object INTERNAL_CALL_Instantiate(Object prefab, ref Vector3 position, ref Quaternion rotation, int group);

		/// <summary>
		///   <para>Destroy the object associated with this view ID across the network.</para>
		/// </summary>
		/// <param name="viewID"></param>
		// Token: 0x060006B7 RID: 1719 RVA: 0x00004C62 File Offset: 0x00002E62
		public static void Destroy(NetworkViewID viewID)
		{
			Network.INTERNAL_CALL_Destroy(ref viewID);
		}

		// Token: 0x060006B8 RID: 1720
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Destroy(ref NetworkViewID viewID);

		/// <summary>
		///   <para>Destroy the object across the network.</para>
		/// </summary>
		/// <param name="gameObject"></param>
		// Token: 0x060006B9 RID: 1721 RVA: 0x00013D44 File Offset: 0x00011F44
		public static void Destroy(GameObject gameObject)
		{
			if (gameObject != null)
			{
				NetworkView component = gameObject.GetComponent<NetworkView>();
				if (component != null)
				{
					Network.Destroy(component.viewID);
				}
				else
				{
					Debug.LogError("Couldn't destroy game object because no network view is attached to it.", gameObject);
				}
			}
		}

		/// <summary>
		///   <para>Destroy all the objects based on view IDs belonging to this player.</para>
		/// </summary>
		/// <param name="playerID"></param>
		// Token: 0x060006BA RID: 1722
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyPlayerObjects(NetworkPlayer playerID);

		// Token: 0x060006BB RID: 1723 RVA: 0x00004C6B File Offset: 0x00002E6B
		private static void Internal_RemoveRPCs(NetworkPlayer playerID, NetworkViewID viewID, uint channelMask)
		{
			Network.INTERNAL_CALL_Internal_RemoveRPCs(playerID, ref viewID, channelMask);
		}

		// Token: 0x060006BC RID: 1724
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_RemoveRPCs(NetworkPlayer playerID, ref NetworkViewID viewID, uint channelMask);

		/// <summary>
		///   <para>Remove all RPC functions which belong to this player ID.</para>
		/// </summary>
		/// <param name="playerID"></param>
		// Token: 0x060006BD RID: 1725 RVA: 0x00004C76 File Offset: 0x00002E76
		public static void RemoveRPCs(NetworkPlayer playerID)
		{
			Network.Internal_RemoveRPCs(playerID, NetworkViewID.unassigned, uint.MaxValue);
		}

		/// <summary>
		///   <para>Remove all RPC functions which belong to this player ID and were sent based on the given group.</para>
		/// </summary>
		/// <param name="playerID"></param>
		/// <param name="group"></param>
		// Token: 0x060006BE RID: 1726 RVA: 0x00004C84 File Offset: 0x00002E84
		public static void RemoveRPCs(NetworkPlayer playerID, int group)
		{
			Network.Internal_RemoveRPCs(playerID, NetworkViewID.unassigned, 1U << group);
		}

		/// <summary>
		///   <para>Remove the RPC function calls accociated with this view ID number.</para>
		/// </summary>
		/// <param name="viewID"></param>
		// Token: 0x060006BF RID: 1727 RVA: 0x00004C97 File Offset: 0x00002E97
		public static void RemoveRPCs(NetworkViewID viewID)
		{
			Network.Internal_RemoveRPCs(NetworkPlayer.unassigned, viewID, uint.MaxValue);
		}

		/// <summary>
		///   <para>Remove all RPC functions which belong to given group number.</para>
		/// </summary>
		/// <param name="group"></param>
		// Token: 0x060006C0 RID: 1728 RVA: 0x00004CA5 File Offset: 0x00002EA5
		public static void RemoveRPCsInGroup(int group)
		{
			Network.Internal_RemoveRPCs(NetworkPlayer.unassigned, NetworkViewID.unassigned, 1U << group);
		}

		/// <summary>
		///   <para>Returns true if your peer type is client.</para>
		/// </summary>
		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060006C1 RID: 1729
		public static extern bool isClient
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns true if your peer type is server.</para>
		/// </summary>
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060006C2 RID: 1730
		public static extern bool isServer
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The status of the peer type, i.e. if it is disconnected, connecting, server or client.</para>
		/// </summary>
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060006C3 RID: 1731
		public static extern NetworkPeerType peerType
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Set the level prefix which will then be prefixed to all network ViewID numbers.</para>
		/// </summary>
		/// <param name="prefix"></param>
		// Token: 0x060006C4 RID: 1732
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetLevelPrefix(int prefix);

		/// <summary>
		///   <para>The last ping time to the given player in milliseconds.</para>
		/// </summary>
		/// <param name="player"></param>
		// Token: 0x060006C5 RID: 1733
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetLastPing(NetworkPlayer player);

		/// <summary>
		///   <para>The last average ping time to the given player in milliseconds.</para>
		/// </summary>
		/// <param name="player"></param>
		// Token: 0x060006C6 RID: 1734
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetAveragePing(NetworkPlayer player);

		/// <summary>
		///   <para>The default send rate of network updates for all Network Views.</para>
		/// </summary>
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060006C7 RID: 1735
		// (set) Token: 0x060006C8 RID: 1736
		public static extern float sendRate
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Enable or disable the processing of network messages.</para>
		/// </summary>
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060006C9 RID: 1737
		// (set) Token: 0x060006CA RID: 1738
		public static extern bool isMessageQueueRunning
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Enable or disables the reception of messages in a specific group number from a specific player.</para>
		/// </summary>
		/// <param name="player"></param>
		/// <param name="group"></param>
		/// <param name="enabled"></param>
		// Token: 0x060006CB RID: 1739
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetReceivingEnabled(NetworkPlayer player, int group, bool enabled);

		// Token: 0x060006CC RID: 1740
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetSendingGlobal(int group, bool enabled);

		// Token: 0x060006CD RID: 1741
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetSendingSpecific(NetworkPlayer player, int group, bool enabled);

		/// <summary>
		///   <para>Enables or disables transmission of messages and RPC calls on a specific network group number.</para>
		/// </summary>
		/// <param name="group"></param>
		/// <param name="enabled"></param>
		// Token: 0x060006CE RID: 1742 RVA: 0x00004CBC File Offset: 0x00002EBC
		public static void SetSendingEnabled(int group, bool enabled)
		{
			Network.Internal_SetSendingGlobal(group, enabled);
		}

		/// <summary>
		///   <para>Enable or disable transmission of messages and RPC calls based on target network player as well as the network group.</para>
		/// </summary>
		/// <param name="player"></param>
		/// <param name="group"></param>
		/// <param name="enabled"></param>
		// Token: 0x060006CF RID: 1743 RVA: 0x00004CC5 File Offset: 0x00002EC5
		public static void SetSendingEnabled(NetworkPlayer player, int group, bool enabled)
		{
			Network.Internal_SetSendingSpecific(player, group, enabled);
		}

		// Token: 0x060006D0 RID: 1744
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetTime(out double t);

		/// <summary>
		///   <para>Get the current network time (seconds).</para>
		/// </summary>
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x00013D8C File Offset: 0x00011F8C
		public static double time
		{
			get
			{
				double num;
				Network.Internal_GetTime(out num);
				return num;
			}
		}

		/// <summary>
		///   <para>Get or set the minimum number of ViewID numbers in the ViewID pool given to clients by the server.</para>
		/// </summary>
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060006D2 RID: 1746
		// (set) Token: 0x060006D3 RID: 1747
		public static extern int minimumAllocatableViewIDs
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060006D4 RID: 1748
		// (set) Token: 0x060006D5 RID: 1749
		[Obsolete("No longer needed. This is now explicitly set in the InitializeServer function call. It is implicitly set when calling Connect depending on if an IP/port combination is used (useNat=false) or a GUID is used(useNat=true).")]
		public static extern bool useNat
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The IP address of the NAT punchthrough facilitator.</para>
		/// </summary>
		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060006D6 RID: 1750
		// (set) Token: 0x060006D7 RID: 1751
		public static extern string natFacilitatorIP
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The port of the NAT punchthrough facilitator.</para>
		/// </summary>
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060006D8 RID: 1752
		// (set) Token: 0x060006D9 RID: 1753
		public static extern int natFacilitatorPort
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Test this machines network connection.</para>
		/// </summary>
		/// <param name="forceTest"></param>
		// Token: 0x060006DA RID: 1754
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ConnectionTesterStatus TestConnection([DefaultValue("false")] bool forceTest);

		// Token: 0x060006DB RID: 1755 RVA: 0x00013DA4 File Offset: 0x00011FA4
		[ExcludeFromDocs]
		public static ConnectionTesterStatus TestConnection()
		{
			bool flag = false;
			return Network.TestConnection(flag);
		}

		/// <summary>
		///   <para>Test the connection specifically for NAT punch-through connectivity.</para>
		/// </summary>
		/// <param name="forceTest"></param>
		// Token: 0x060006DC RID: 1756
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ConnectionTesterStatus TestConnectionNAT([DefaultValue("false")] bool forceTest);

		// Token: 0x060006DD RID: 1757 RVA: 0x00013DBC File Offset: 0x00011FBC
		[ExcludeFromDocs]
		public static ConnectionTesterStatus TestConnectionNAT()
		{
			bool flag = false;
			return Network.TestConnectionNAT(flag);
		}

		/// <summary>
		///   <para>The IP address of the connection tester used in Network.TestConnection.</para>
		/// </summary>
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060006DE RID: 1758
		// (set) Token: 0x060006DF RID: 1759
		public static extern string connectionTesterIP
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The port of the connection tester used in Network.TestConnection.</para>
		/// </summary>
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060006E0 RID: 1760
		// (set) Token: 0x060006E1 RID: 1761
		public static extern int connectionTesterPort
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Check if this machine has a public IP address.</para>
		/// </summary>
		// Token: 0x060006E2 RID: 1762
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HavePublicAddress();

		/// <summary>
		///   <para>Set the maximum amount of connections/players allowed.</para>
		/// </summary>
		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060006E3 RID: 1763
		// (set) Token: 0x060006E4 RID: 1764
		public static extern int maxConnections
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The IP address of the proxy server.</para>
		/// </summary>
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060006E5 RID: 1765
		// (set) Token: 0x060006E6 RID: 1766
		public static extern string proxyIP
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The port of the proxy server.</para>
		/// </summary>
		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060006E7 RID: 1767
		// (set) Token: 0x060006E8 RID: 1768
		public static extern int proxyPort
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Indicate if proxy support is needed, in which case traffic is relayed through the proxy server.</para>
		/// </summary>
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060006E9 RID: 1769
		// (set) Token: 0x060006EA RID: 1770
		public static extern bool useProxy
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Set the proxy server password.</para>
		/// </summary>
		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060006EB RID: 1771
		// (set) Token: 0x060006EC RID: 1772
		public static extern string proxyPassword
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}
	}
}
