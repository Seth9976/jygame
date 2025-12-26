using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Internal;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking
{
	/// <summary>
	///   <para>Low level (transport layer) API.</para>
	/// </summary>
	// Token: 0x0200021B RID: 539
	public sealed class NetworkTransport
	{
		// Token: 0x06001ED0 RID: 7888 RVA: 0x000021D6 File Offset: 0x000003D6
		private NetworkTransport()
		{
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00025C04 File Offset: 0x00023E04
		public static int ConnectEndPoint(int hostId, EndPoint xboxOneEndPoint, int exceptionConnectionId, out byte error)
		{
			error = 0;
			byte[] array = new byte[] { 95, 36, 19, 246 };
			if (xboxOneEndPoint == null)
			{
				throw new NullReferenceException("Null EndPoint provided");
			}
			if (xboxOneEndPoint.GetType().FullName != "UnityEngine.XboxOne.XboxOneEndPoint")
			{
				throw new ArgumentException("Endpoint of type XboxOneEndPoint required");
			}
			if (xboxOneEndPoint.AddressFamily != AddressFamily.InterNetworkV6)
			{
				throw new ArgumentException("XboxOneEndPoint has an invalid family");
			}
			SocketAddress socketAddress = xboxOneEndPoint.Serialize();
			if (socketAddress.Size != 14)
			{
				throw new ArgumentException("XboxOneEndPoint has an invalid size");
			}
			if (socketAddress[0] != 0 || socketAddress[1] != 0)
			{
				throw new ArgumentException("XboxOneEndPoint has an invalid family signature");
			}
			if (socketAddress[2] != array[0] || socketAddress[3] != array[1] || socketAddress[4] != array[2] || socketAddress[5] != array[3])
			{
				throw new ArgumentException("XboxOneEndPoint has an invalid signature");
			}
			byte[] array2 = new byte[8];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = socketAddress[6 + i];
			}
			IntPtr intPtr = new IntPtr(BitConverter.ToInt64(array2, 0));
			if (intPtr == IntPtr.Zero)
			{
				throw new ArgumentException("XboxOneEndPoint has an invalid SOCKET_STORAGE pointer");
			}
			byte[] array3 = new byte[2];
			Marshal.Copy(intPtr, array3, 0, array3.Length);
			AddressFamily addressFamily = (AddressFamily)(((int)array3[1] << 8) + (int)array3[0]);
			if (addressFamily != AddressFamily.InterNetworkV6)
			{
				throw new ArgumentException("XboxOneEndPoint has corrupt or invalid SOCKET_STORAGE pointer");
			}
			return NetworkTransport.Internal_ConnectEndPoint(hostId, intPtr, 128, exceptionConnectionId, out error);
		}

		/// <summary>
		///   <para>First function which should be called before any other NetworkTransport function.</para>
		/// </summary>
		// Token: 0x06001ED2 RID: 7890 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
		public static void Init()
		{
			NetworkTransport.InitWithNoParameters();
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x0000C2EF File Offset: 0x0000A4EF
		public static void Init(GlobalConfig config)
		{
			NetworkTransport.InitWithParameters(new GlobalConfigInternal(config));
		}

		// Token: 0x06001ED4 RID: 7892
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitWithNoParameters();

		// Token: 0x06001ED5 RID: 7893
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitWithParameters(GlobalConfigInternal config);

		/// <summary>
		///   <para>Shutdown the transport layer, after calling this function no any other function can be called.</para>
		/// </summary>
		// Token: 0x06001ED6 RID: 7894
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Shutdown();

		/// <summary>
		///   <para>The UNet spawning system uses assetIds to identify how spawn remote objects. This function allows you to get the assetId for the prefab associated with an object.</para>
		/// </summary>
		/// <param name="go">Target game object to get asset Id for.</param>
		/// <returns>
		///   <para>The assetId of the game object's prefab.</para>
		/// </returns>
		// Token: 0x06001ED7 RID: 7895
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetAssetId(GameObject go);

		// Token: 0x06001ED8 RID: 7896
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AddSceneId(int id);

		// Token: 0x06001ED9 RID: 7897
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetNextSceneId();

		// Token: 0x06001EDA RID: 7898
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ConnectAsNetworkHost(int hostId, string address, int port, NetworkID network, SourceID source, NodeID node, out byte error);

		// Token: 0x06001EDB RID: 7899
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DisconnectNetworkHost(int hostId, out byte error);

		// Token: 0x06001EDC RID: 7900
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern NetworkEventType ReceiveRelayEventFromHost(int hostId, out byte error);

		// Token: 0x06001EDD RID: 7901
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int ConnectToNetworkPeer(int hostId, string address, int port, int exceptionConnectionId, int relaySlotId, NetworkID network, SourceID source, NodeID node, int bytesPerSec, float bucketSizeFactor, out byte error);

		// Token: 0x06001EDE RID: 7902 RVA: 0x00025DA8 File Offset: 0x00023FA8
		public static int ConnectToNetworkPeer(int hostId, string address, int port, int exceptionConnectionId, int relaySlotId, NetworkID network, SourceID source, NodeID node, out byte error)
		{
			return NetworkTransport.ConnectToNetworkPeer(hostId, address, port, exceptionConnectionId, relaySlotId, network, source, node, 0, 0f, out error);
		}

		/// <summary>
		///   <para>Return value of messages waiting for reading.</para>
		/// </summary>
		// Token: 0x06001EDF RID: 7903
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCurrentIncomingMessageAmount();

		/// <summary>
		///   <para>Return total message amount waiting for sending.</para>
		/// </summary>
		// Token: 0x06001EE0 RID: 7904
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCurrentOutgoingMessageAmount();

		// Token: 0x06001EE1 RID: 7905
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCurrentRtt(int hostId, int connectionId, out byte error);

		// Token: 0x06001EE2 RID: 7906
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetNetworkLostPacketNum(int hostId, int connectionId, out byte error);

		// Token: 0x06001EE3 RID: 7907
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetPacketSentRate(int hostId, int connectionId, out byte error);

		// Token: 0x06001EE4 RID: 7908
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetPacketReceivedRate(int hostId, int connectionId, out byte error);

		// Token: 0x06001EE5 RID: 7909
		[WrapperlessIcall]
		[Obsolete("GetRemotePacketReceivedRate has been made obsolete. Please do not use this function.")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetRemotePacketReceivedRate(int hostId, int connectionId, out byte error);

		/// <summary>
		///   <para>Function returns time spent on network io operations in micro seconds.</para>
		/// </summary>
		/// <returns>
		///   <para>Time in micro seconds.</para>
		/// </returns>
		// Token: 0x06001EE6 RID: 7910
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetNetIOTimeuS();

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00025DD0 File Offset: 0x00023FD0
		public static void GetConnectionInfo(int hostId, int connectionId, out string address, out int port, out NetworkID network, out NodeID dstNode, out byte error)
		{
			ulong num;
			ushort num2;
			address = NetworkTransport.GetConnectionInfo(hostId, connectionId, out port, out num, out num2, out error);
			network = (NetworkID)num;
			dstNode = (NodeID)num2;
		}

		// Token: 0x06001EE8 RID: 7912
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetConnectionInfo(int hostId, int connectionId, out int port, out ulong network, out ushort dstNode, out byte error);

		/// <summary>
		///   <para>Get UNET timestamp which can be added to message for further definitions of packet delaying.</para>
		/// </summary>
		// Token: 0x06001EE9 RID: 7913
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetNetworkTimestamp();

		// Token: 0x06001EEA RID: 7914
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetRemoteDelayTimeMS(int hostId, int connectionId, int remoteTime, out byte error);

		// Token: 0x06001EEB RID: 7915
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool StartSendMulticast(int hostId, int channelId, byte[] buffer, int size, out byte error);

		// Token: 0x06001EEC RID: 7916
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SendMulticast(int hostId, int connectionId, out byte error);

		// Token: 0x06001EED RID: 7917
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool FinishSendMulticast(int hostId, out byte error);

		// Token: 0x06001EEE RID: 7918
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetMaxPacketSize();

		// Token: 0x06001EEF RID: 7919 RVA: 0x00025DF8 File Offset: 0x00023FF8
		private static void CheckTopology(HostTopology topology)
		{
			int maxPacketSize = NetworkTransport.GetMaxPacketSize();
			if ((int)topology.DefaultConfig.PacketSize > maxPacketSize)
			{
				throw new ArgumentOutOfRangeException("Default config: packet size should be less than packet size defined in global config: " + maxPacketSize.ToString());
			}
			for (int i = 0; i < topology.SpecialConnectionConfigs.Count; i++)
			{
				if ((int)topology.SpecialConnectionConfigs[i].PacketSize > maxPacketSize)
				{
					throw new ArgumentOutOfRangeException("Special config " + i.ToString() + ": packet size should be less than packet size defined in global config: " + maxPacketSize.ToString());
				}
			}
		}

		// Token: 0x06001EF0 RID: 7920
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int AddWsHostWrapper(HostTopologyInternal topologyInt, string ip, int port);

		// Token: 0x06001EF1 RID: 7921
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int AddWsHostWrapperWithoutIp(HostTopologyInternal topologyInt, int port);

		/// <summary>
		///   <para>Created web socket host. 
		/// This function is supported only for Editor (Win, Linux, Mac) and StandalonePlayers (Win, Linux, Mac) 
		/// Topology is used to define how many client can connect, and how many messages should be preallocated in send and receive pool, all other parameters are ignored.</para>
		/// </summary>
		/// <param name="port">Listening tcp port.</param>
		/// <param name="topology">Topology.</param>
		/// <returns>
		///   <para>Web socket host id.</para>
		/// </returns>
		// Token: 0x06001EF2 RID: 7922 RVA: 0x00025E8C File Offset: 0x0002408C
		[ExcludeFromDocs]
		public static int AddWebsocketHost(HostTopology topology, int port)
		{
			string text = null;
			return NetworkTransport.AddWebsocketHost(topology, port, text);
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x0000C2FC File Offset: 0x0000A4FC
		public static int AddWebsocketHost(HostTopology topology, int port, [DefaultValue("null")] string ip)
		{
			if (topology == null)
			{
				throw new NullReferenceException("topology is not defined");
			}
			if (ip == null)
			{
				return NetworkTransport.AddWsHostWrapperWithoutIp(new HostTopologyInternal(topology), port);
			}
			return NetworkTransport.AddWsHostWrapper(new HostTopologyInternal(topology), ip, port);
		}

		// Token: 0x06001EF4 RID: 7924
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int AddHostWrapper(HostTopologyInternal topologyInt, string ip, int port, int minTimeout, int maxTimeout);

		// Token: 0x06001EF5 RID: 7925
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int AddHostWrapperWithoutIp(HostTopologyInternal topologyInt, int port, int minTimeout, int maxTimeout);

		// Token: 0x06001EF6 RID: 7926 RVA: 0x00025EA4 File Offset: 0x000240A4
		[ExcludeFromDocs]
		public static int AddHost(HostTopology topology, int port)
		{
			string text = null;
			return NetworkTransport.AddHost(topology, port, text);
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x00025EBC File Offset: 0x000240BC
		[ExcludeFromDocs]
		public static int AddHost(HostTopology topology)
		{
			string text = null;
			int num = 0;
			return NetworkTransport.AddHost(topology, num, text);
		}

		/// <summary>
		///   <para>Will create a host (open socket) with given topology and optionally port and IP.</para>
		/// </summary>
		/// <param name="topology">The host topology for this host.</param>
		/// <param name="port">Bind to specific port, if 0 is selected the port will chosen by OS.</param>
		/// <param name="ip">Bind to specific IP address.</param>
		/// <returns>
		///   <para>Returns host ID just created.</para>
		/// </returns>
		// Token: 0x06001EF8 RID: 7928 RVA: 0x0000C32F File Offset: 0x0000A52F
		public static int AddHost(HostTopology topology, [DefaultValue("0")] int port, [DefaultValue("null")] string ip)
		{
			if (topology == null)
			{
				throw new NullReferenceException("topology is not defined");
			}
			if (ip == null)
			{
				return NetworkTransport.AddHostWrapperWithoutIp(new HostTopologyInternal(topology), port, 0, 0);
			}
			return NetworkTransport.AddHostWrapper(new HostTopologyInternal(topology), ip, port, 0, 0);
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00025ED8 File Offset: 0x000240D8
		[ExcludeFromDocs]
		public static int AddHostWithSimulator(HostTopology topology, int minTimeout, int maxTimeout, int port)
		{
			string text = null;
			return NetworkTransport.AddHostWithSimulator(topology, minTimeout, maxTimeout, port, text);
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x00025EF4 File Offset: 0x000240F4
		[ExcludeFromDocs]
		public static int AddHostWithSimulator(HostTopology topology, int minTimeout, int maxTimeout)
		{
			string text = null;
			int num = 0;
			return NetworkTransport.AddHostWithSimulator(topology, minTimeout, maxTimeout, num, text);
		}

		/// <summary>
		///   <para>Create a host (open socket) and configure them to simulate internet latency (works on editor and development build only).</para>
		/// </summary>
		/// <param name="topology">The host topology for this host.</param>
		/// <param name="minTimeout">Minimum simulated delay.</param>
		/// <param name="maxTimeout">Maximum simulated delay.</param>
		/// <param name="port">Bind to specific port, if 0 is selected the port will chosen by OS.</param>
		/// <param name="ip">Bind to specific IP address.</param>
		/// <returns>
		///   <para>Returns host ID just created.</para>
		/// </returns>
		// Token: 0x06001EFB RID: 7931 RVA: 0x0000C366 File Offset: 0x0000A566
		public static int AddHostWithSimulator(HostTopology topology, int minTimeout, int maxTimeout, [DefaultValue("0")] int port, [DefaultValue("null")] string ip)
		{
			if (topology == null)
			{
				throw new NullReferenceException("topology is not defined");
			}
			if (ip == null)
			{
				return NetworkTransport.AddHostWrapperWithoutIp(new HostTopologyInternal(topology), port, minTimeout, maxTimeout);
			}
			return NetworkTransport.AddHostWrapper(new HostTopologyInternal(topology), ip, port, minTimeout, maxTimeout);
		}

		/// <summary>
		///   <para>Close opened socket, close all connection belonging this socket.</para>
		/// </summary>
		/// <param name="hostId">If of opened udp socket.</param>
		// Token: 0x06001EFC RID: 7932
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool RemoveHost(int hostId);

		/// <summary>
		///   <para>Obsolete, will be removed.</para>
		/// </summary>
		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001EFD RID: 7933
		public static extern bool IsStarted
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x06001EFE RID: 7934
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Connect(int hostId, string address, int port, int exeptionConnectionId, out byte error);

		// Token: 0x06001EFF RID: 7935
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_ConnectEndPoint(int hostId, IntPtr sockAddrStorage, int sockAddrStorageLen, int exceptionConnectionId, out byte error);

		// Token: 0x06001F00 RID: 7936
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int ConnectWithSimulator(int hostId, string address, int port, int exeptionConnectionId, out byte error, ConnectionSimulatorConfig conf);

		// Token: 0x06001F01 RID: 7937
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Disconnect(int hostId, int connectionId, out byte error);

		// Token: 0x06001F02 RID: 7938 RVA: 0x0000C39F File Offset: 0x0000A59F
		public static bool Send(int hostId, int connectionId, int channelId, byte[] buffer, int size, out byte error)
		{
			if (buffer == null)
			{
				throw new NullReferenceException("send buffer is not initialized");
			}
			return NetworkTransport.SendWrapper(hostId, connectionId, channelId, buffer, size, out error);
		}

		// Token: 0x06001F03 RID: 7939
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool SendWrapper(int hostId, int connectionId, int channelId, byte[] buffer, int size, out byte error);

		// Token: 0x06001F04 RID: 7940
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern NetworkEventType Receive(out int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error);

		// Token: 0x06001F05 RID: 7941
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern NetworkEventType ReceiveFromHost(int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error);

		// Token: 0x06001F06 RID: 7942
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetPacketStat(int direction, int packetStatId, int numMsgs, int numBytes);

		// Token: 0x06001F07 RID: 7943
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool StartBroadcastDiscovery(int hostId, int broadcastPort, int key, int version, int subversion, byte[] buffer, int size, int timeout, out byte error);

		/// <summary>
		///   <para>Stop sending broadcast discovery message.</para>
		/// </summary>
		// Token: 0x06001F08 RID: 7944
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopBroadcastDiscovery();

		/// <summary>
		///   <para>Check if broadcastdiscovery sender works.</para>
		/// </summary>
		/// <returns>
		///   <para>True if it works.</para>
		/// </returns>
		// Token: 0x06001F09 RID: 7945
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsBroadcastDiscoveryRunning();

		// Token: 0x06001F0A RID: 7946
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetBroadcastCredentials(int hostId, int key, int version, int subversion, out byte error);

		// Token: 0x06001F0B RID: 7947
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string GetBroadcastConnectionInfo(int hostId, out int port, out byte error);

		// Token: 0x06001F0C RID: 7948 RVA: 0x0000C3BF File Offset: 0x0000A5BF
		public static void GetBroadcastConnectionInfo(int hostId, out string address, out int port, out byte error)
		{
			address = NetworkTransport.GetBroadcastConnectionInfo(hostId, out port, out error);
		}

		// Token: 0x06001F0D RID: 7949
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetBroadcastConnectionMessage(int hostId, byte[] buffer, int bufferSize, out int receivedSize, out byte error);
	}
}
