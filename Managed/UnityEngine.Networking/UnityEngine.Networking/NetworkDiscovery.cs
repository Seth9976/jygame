using System;
using System.Collections.Generic;

namespace UnityEngine.Networking
{
	// Token: 0x0200003B RID: 59
	[AddComponentMenu("Network/NetworkDiscovery")]
	[DisallowMultipleComponent]
	public class NetworkDiscovery : MonoBehaviour
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00008F08 File Offset: 0x00007108
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00008F10 File Offset: 0x00007110
		public int broadcastPort
		{
			get
			{
				return this.m_BroadcastPort;
			}
			set
			{
				this.m_BroadcastPort = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00008F1C File Offset: 0x0000711C
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00008F24 File Offset: 0x00007124
		public int broadcastKey
		{
			get
			{
				return this.m_BroadcastKey;
			}
			set
			{
				this.m_BroadcastKey = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00008F30 File Offset: 0x00007130
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00008F38 File Offset: 0x00007138
		public int broadcastVersion
		{
			get
			{
				return this.m_BroadcastVersion;
			}
			set
			{
				this.m_BroadcastVersion = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00008F44 File Offset: 0x00007144
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00008F4C File Offset: 0x0000714C
		public int broadcastSubVersion
		{
			get
			{
				return this.m_BroadcastSubVersion;
			}
			set
			{
				this.m_BroadcastSubVersion = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00008F58 File Offset: 0x00007158
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00008F60 File Offset: 0x00007160
		public int broadcastInterval
		{
			get
			{
				return this.m_BroadcastInterval;
			}
			set
			{
				this.m_BroadcastInterval = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00008F6C File Offset: 0x0000716C
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00008F74 File Offset: 0x00007174
		public bool useNetworkManager
		{
			get
			{
				return this.m_UseNetworkManager;
			}
			set
			{
				this.m_UseNetworkManager = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00008F80 File Offset: 0x00007180
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00008F88 File Offset: 0x00007188
		public string broadcastData
		{
			get
			{
				return this.m_BroadcastData;
			}
			set
			{
				this.m_BroadcastData = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00008F94 File Offset: 0x00007194
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00008F9C File Offset: 0x0000719C
		public bool showGUI
		{
			get
			{
				return this.m_ShowGUI;
			}
			set
			{
				this.m_ShowGUI = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00008FA8 File Offset: 0x000071A8
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00008FB0 File Offset: 0x000071B0
		public int offsetX
		{
			get
			{
				return this.m_OffsetX;
			}
			set
			{
				this.m_OffsetX = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00008FBC File Offset: 0x000071BC
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00008FC4 File Offset: 0x000071C4
		public int offsetY
		{
			get
			{
				return this.m_OffsetY;
			}
			set
			{
				this.m_OffsetY = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00008FD0 File Offset: 0x000071D0
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00008FD8 File Offset: 0x000071D8
		public int hostId
		{
			get
			{
				return this.m_HostId;
			}
			set
			{
				this.m_HostId = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00008FE4 File Offset: 0x000071E4
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00008FEC File Offset: 0x000071EC
		public bool running
		{
			get
			{
				return this.m_Running;
			}
			set
			{
				this.m_Running = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00008FF8 File Offset: 0x000071F8
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00009000 File Offset: 0x00007200
		public bool isServer
		{
			get
			{
				return this.m_IsServer;
			}
			set
			{
				this.m_IsServer = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0000900C File Offset: 0x0000720C
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00009014 File Offset: 0x00007214
		public bool isClient
		{
			get
			{
				return this.m_IsClient;
			}
			set
			{
				this.m_IsClient = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00009020 File Offset: 0x00007220
		public Dictionary<string, NetworkBroadcastResult> broadcastsReceived
		{
			get
			{
				return this.m_BroadcastsReceived;
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00009028 File Offset: 0x00007228
		private static byte[] StringToBytes(string str)
		{
			byte[] array = new byte[str.Length * 2];
			Buffer.BlockCopy(str.ToCharArray(), 0, array, 0, array.Length);
			return array;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00009058 File Offset: 0x00007258
		private static string BytesToString(byte[] bytes)
		{
			char[] array = new char[bytes.Length / 2];
			Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length);
			return new string(array);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00009084 File Offset: 0x00007284
		public bool Initialize()
		{
			if (this.m_BroadcastData.Length >= 1024)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkDiscovery Initialize - data too large. max is " + 1024);
				}
				return false;
			}
			if (!NetworkTransport.IsStarted)
			{
				NetworkTransport.Init();
			}
			if (this.m_UseNetworkManager && NetworkManager.singleton != null)
			{
				this.m_BroadcastData = string.Concat(new object[]
				{
					"NetworkManager:",
					NetworkManager.singleton.networkAddress,
					":",
					NetworkManager.singleton.networkPort
				});
				if (LogFilter.logInfo)
				{
					Debug.Log("NetwrokDiscovery set broadbast data to:" + this.m_BroadcastData);
				}
			}
			this.m_MsgOutBuffer = NetworkDiscovery.StringToBytes(this.m_BroadcastData);
			this.m_MsgInBuffer = new byte[1024];
			this.m_BroadcastsReceived = new Dictionary<string, NetworkBroadcastResult>();
			ConnectionConfig connectionConfig = new ConnectionConfig();
			connectionConfig.AddChannel(QosType.Unreliable);
			this.m_DefaultTopology = new HostTopology(connectionConfig, 1);
			if (this.m_IsServer)
			{
				this.StartAsServer();
			}
			if (this.m_IsClient)
			{
				this.StartAsClient();
			}
			return true;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000091C0 File Offset: 0x000073C0
		public bool StartAsClient()
		{
			if (this.m_HostId != -1 || this.m_Running)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("NetworkDiscovery StartAsClient already started");
				}
				return false;
			}
			this.m_HostId = NetworkTransport.AddHost(this.m_DefaultTopology, this.m_BroadcastPort);
			if (this.m_HostId == -1)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkDiscovery StartAsClient - addHost failed");
				}
				return false;
			}
			byte b;
			NetworkTransport.SetBroadcastCredentials(this.m_HostId, this.m_BroadcastKey, this.m_BroadcastVersion, this.m_BroadcastSubVersion, out b);
			this.m_Running = true;
			this.m_IsClient = true;
			if (LogFilter.logDebug)
			{
				Debug.Log("StartAsClient Discovery listening");
			}
			return true;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00009278 File Offset: 0x00007478
		public bool StartAsServer()
		{
			if (this.m_HostId != -1 || this.m_Running)
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("NetworkDiscovery StartAsServer already started");
				}
				return false;
			}
			this.m_HostId = NetworkTransport.AddHost(this.m_DefaultTopology, 0);
			if (this.m_HostId == -1)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkDiscovery StartAsServer - addHost failed");
				}
				return false;
			}
			byte b;
			if (!NetworkTransport.StartBroadcastDiscovery(this.m_HostId, this.m_BroadcastPort, this.m_BroadcastKey, this.m_BroadcastVersion, this.m_BroadcastSubVersion, this.m_MsgOutBuffer, this.m_MsgOutBuffer.Length, this.m_BroadcastInterval, out b))
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkDiscovery StartBroadcast failed err: " + b);
				}
				return false;
			}
			this.m_Running = true;
			this.m_IsServer = true;
			if (LogFilter.logDebug)
			{
				Debug.Log("StartAsServer Discovery broadcasting");
			}
			Object.DontDestroyOnLoad(base.gameObject);
			return true;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00009374 File Offset: 0x00007574
		public void StopBroadcast()
		{
			if (this.m_HostId == -1)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkDiscovery StopBroadcast not initialized");
				}
				return;
			}
			if (!this.m_Running)
			{
				Debug.LogWarning("NetworkDiscovery StopBroadcast not started");
				return;
			}
			if (this.m_IsServer)
			{
				NetworkTransport.StopBroadcastDiscovery();
			}
			NetworkTransport.RemoveHost(this.m_HostId);
			this.m_HostId = -1;
			this.m_Running = false;
			this.m_IsServer = false;
			this.m_IsClient = false;
			this.m_MsgInBuffer = null;
			this.m_BroadcastsReceived = null;
			if (LogFilter.logDebug)
			{
				Debug.Log("Stopped Discovery broadcasting");
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00009414 File Offset: 0x00007614
		private void Update()
		{
			if (this.m_HostId == -1)
			{
				return;
			}
			if (this.m_IsServer)
			{
				return;
			}
			NetworkEventType networkEventType;
			do
			{
				int num;
				int num2;
				int num3;
				byte b;
				networkEventType = NetworkTransport.ReceiveFromHost(this.m_HostId, out num, out num2, this.m_MsgInBuffer, 1024, out num3, out b);
				if (networkEventType == NetworkEventType.BroadcastEvent)
				{
					NetworkTransport.GetBroadcastConnectionMessage(this.m_HostId, this.m_MsgInBuffer, 1024, out num3, out b);
					string text;
					int num4;
					NetworkTransport.GetBroadcastConnectionInfo(this.m_HostId, out text, out num4, out b);
					NetworkBroadcastResult networkBroadcastResult = default(NetworkBroadcastResult);
					networkBroadcastResult.serverAddress = text;
					networkBroadcastResult.broadcastData = new byte[num3];
					Buffer.BlockCopy(this.m_MsgInBuffer, 0, networkBroadcastResult.broadcastData, 0, num3);
					this.m_BroadcastsReceived[text] = networkBroadcastResult;
					this.OnReceivedBroadcast(text, NetworkDiscovery.BytesToString(this.m_MsgInBuffer));
				}
			}
			while (networkEventType != NetworkEventType.Nothing);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000094E8 File Offset: 0x000076E8
		public virtual void OnReceivedBroadcast(string fromAddress, string data)
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000094EC File Offset: 0x000076EC
		private void OnGUI()
		{
			if (!this.m_ShowGUI)
			{
				return;
			}
			int num = 10 + this.m_OffsetX;
			int num2 = 40 + this.m_OffsetY;
			if (this.m_MsgInBuffer == null)
			{
				if (GUI.Button(new Rect((float)num, (float)num2, 200f, 20f), "Initialize Broadcast"))
				{
					this.Initialize();
				}
				return;
			}
			string text = string.Empty;
			if (this.m_IsServer)
			{
				text = " (server)";
			}
			if (this.m_IsClient)
			{
				text = " (client)";
			}
			GUI.Label(new Rect((float)num, (float)num2, 200f, 20f), "initialized" + text);
			num2 += 24;
			if (this.m_Running)
			{
				if (GUI.Button(new Rect((float)num, (float)num2, 200f, 20f), "Stop"))
				{
					this.StopBroadcast();
				}
				num2 += 24;
				if (this.m_BroadcastsReceived != null)
				{
					foreach (string text2 in this.m_BroadcastsReceived.Keys)
					{
						NetworkBroadcastResult networkBroadcastResult = this.m_BroadcastsReceived[text2];
						if (GUI.Button(new Rect((float)num, (float)(num2 + 20), 200f, 20f), "Game at " + text2) && this.m_UseNetworkManager)
						{
							string text3 = NetworkDiscovery.BytesToString(networkBroadcastResult.broadcastData);
							string[] array = text3.Split(new char[] { ':' });
							if (array.Length == 3 && array[0] == "NetworkManager" && NetworkManager.singleton != null && NetworkManager.singleton.client == null)
							{
								NetworkManager.singleton.networkAddress = array[1];
								NetworkManager.singleton.networkPort = Convert.ToInt32(array[2]);
								NetworkManager.singleton.StartClient();
							}
						}
						num2 += 24;
					}
				}
			}
			else
			{
				if (GUI.Button(new Rect((float)num, (float)num2, 200f, 20f), "Start Broadcasting"))
				{
					this.StartAsServer();
				}
				num2 += 24;
				if (GUI.Button(new Rect((float)num, (float)num2, 200f, 20f), "Listen for Broadcast"))
				{
					this.StartAsClient();
				}
				num2 += 24;
			}
		}

		// Token: 0x040000D9 RID: 217
		private const int k_MaxBroadcastMsgSize = 1024;

		// Token: 0x040000DA RID: 218
		[SerializeField]
		private int m_BroadcastPort = 47777;

		// Token: 0x040000DB RID: 219
		[SerializeField]
		private int m_BroadcastKey = 2222;

		// Token: 0x040000DC RID: 220
		[SerializeField]
		private int m_BroadcastVersion = 1;

		// Token: 0x040000DD RID: 221
		[SerializeField]
		private int m_BroadcastSubVersion = 1;

		// Token: 0x040000DE RID: 222
		[SerializeField]
		private int m_BroadcastInterval = 1000;

		// Token: 0x040000DF RID: 223
		[SerializeField]
		private bool m_UseNetworkManager = true;

		// Token: 0x040000E0 RID: 224
		[SerializeField]
		private string m_BroadcastData = "HELLO";

		// Token: 0x040000E1 RID: 225
		[SerializeField]
		private bool m_ShowGUI = true;

		// Token: 0x040000E2 RID: 226
		[SerializeField]
		private int m_OffsetX;

		// Token: 0x040000E3 RID: 227
		[SerializeField]
		private int m_OffsetY;

		// Token: 0x040000E4 RID: 228
		private int m_HostId = -1;

		// Token: 0x040000E5 RID: 229
		private bool m_Running;

		// Token: 0x040000E6 RID: 230
		private bool m_IsServer;

		// Token: 0x040000E7 RID: 231
		private bool m_IsClient;

		// Token: 0x040000E8 RID: 232
		private byte[] m_MsgOutBuffer;

		// Token: 0x040000E9 RID: 233
		private byte[] m_MsgInBuffer;

		// Token: 0x040000EA RID: 234
		private HostTopology m_DefaultTopology;

		// Token: 0x040000EB RID: 235
		private Dictionary<string, NetworkBroadcastResult> m_BroadcastsReceived;
	}
}
