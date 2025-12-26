using System;
using UnityEngine.Networking.NetworkSystem;

namespace UnityEngine.Networking
{
	// Token: 0x02000041 RID: 65
	[AddComponentMenu("Network/NetworkLobbyPlayer")]
	[DisallowMultipleComponent]
	public class NetworkLobbyPlayer : NetworkBehaviour
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0000C21C File Offset: 0x0000A41C
		// (set) Token: 0x0600025E RID: 606 RVA: 0x0000C224 File Offset: 0x0000A424
		public byte slot
		{
			get
			{
				return this.m_Slot;
			}
			set
			{
				this.m_Slot = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0000C230 File Offset: 0x0000A430
		// (set) Token: 0x06000260 RID: 608 RVA: 0x0000C238 File Offset: 0x0000A438
		public bool readyToBegin
		{
			get
			{
				return this.m_ReadyToBegin;
			}
			set
			{
				this.m_ReadyToBegin = value;
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000C244 File Offset: 0x0000A444
		private void Start()
		{
			Object.DontDestroyOnLoad(base.gameObject);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000C254 File Offset: 0x0000A454
		public override void OnStartClient()
		{
			NetworkLobbyManager networkLobbyManager = NetworkManager.singleton as NetworkLobbyManager;
			if (networkLobbyManager)
			{
				networkLobbyManager.lobbySlots[(int)this.m_Slot] = this;
				this.m_ReadyToBegin = false;
				this.OnClientEnterLobby();
			}
			else
			{
				Debug.LogError("No Lobby for LobbyPlayer");
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000C2A4 File Offset: 0x0000A4A4
		public void SendReadyToBeginMessage()
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkLobbyPlayer SendReadyToBeginMessage");
			}
			NetworkLobbyManager networkLobbyManager = NetworkManager.singleton as NetworkLobbyManager;
			if (networkLobbyManager)
			{
				LobbyReadyToBeginMessage lobbyReadyToBeginMessage = new LobbyReadyToBeginMessage();
				lobbyReadyToBeginMessage.slotId = (byte)base.playerControllerId;
				lobbyReadyToBeginMessage.readyState = true;
				networkLobbyManager.client.Send(43, lobbyReadyToBeginMessage);
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000C304 File Offset: 0x0000A504
		public void SendNotReadyToBeginMessage()
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkLobbyPlayer SendReadyToBeginMessage");
			}
			NetworkLobbyManager networkLobbyManager = NetworkManager.singleton as NetworkLobbyManager;
			if (networkLobbyManager)
			{
				LobbyReadyToBeginMessage lobbyReadyToBeginMessage = new LobbyReadyToBeginMessage();
				lobbyReadyToBeginMessage.slotId = (byte)base.playerControllerId;
				lobbyReadyToBeginMessage.readyState = false;
				networkLobbyManager.client.Send(43, lobbyReadyToBeginMessage);
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000C364 File Offset: 0x0000A564
		public void SendSceneLoadedMessage()
		{
			if (LogFilter.logDebug)
			{
				Debug.Log("NetworkLobbyPlayer SendSceneLoadedMessage");
			}
			NetworkLobbyManager networkLobbyManager = NetworkManager.singleton as NetworkLobbyManager;
			if (networkLobbyManager)
			{
				IntegerMessage integerMessage = new IntegerMessage((int)base.playerControllerId);
				networkLobbyManager.client.Send(44, integerMessage);
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000C3B8 File Offset: 0x0000A5B8
		private void OnLevelWasLoaded()
		{
			NetworkLobbyManager networkLobbyManager = NetworkManager.singleton as NetworkLobbyManager;
			if (networkLobbyManager && Application.loadedLevelName == networkLobbyManager.lobbyScene)
			{
				return;
			}
			if (base.isLocalPlayer)
			{
				this.SendSceneLoadedMessage();
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000C404 File Offset: 0x0000A604
		public void RemovePlayer()
		{
			if (base.isLocalPlayer && !this.m_ReadyToBegin)
			{
				if (LogFilter.logDebug)
				{
					Debug.Log("NetworkLobbyPlayer RemovePlayer");
				}
				ClientScene.RemovePlayer(base.GetComponent<NetworkIdentity>().playerControllerId);
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000C44C File Offset: 0x0000A64C
		public virtual void OnClientEnterLobby()
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000C450 File Offset: 0x0000A650
		public virtual void OnClientExitLobby()
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000C454 File Offset: 0x0000A654
		public virtual void OnClientReady(bool readyState)
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000C458 File Offset: 0x0000A658
		public override bool OnSerialize(NetworkWriter writer, bool initialState)
		{
			writer.WritePackedUInt32(1U);
			writer.Write(this.m_Slot);
			writer.Write(this.m_ReadyToBegin);
			return true;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000C488 File Offset: 0x0000A688
		public override void OnDeserialize(NetworkReader reader, bool initialState)
		{
			if (reader.ReadPackedUInt32() == 0U)
			{
				return;
			}
			this.m_Slot = reader.ReadByte();
			this.m_ReadyToBegin = reader.ReadBoolean();
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000C4BC File Offset: 0x0000A6BC
		private void OnGUI()
		{
			if (!this.ShowLobbyGUI)
			{
				return;
			}
			NetworkLobbyManager networkLobbyManager = NetworkManager.singleton as NetworkLobbyManager;
			if (networkLobbyManager)
			{
				if (!networkLobbyManager.showLobbyGUI)
				{
					return;
				}
				if (Application.loadedLevelName != networkLobbyManager.lobbyScene)
				{
					return;
				}
			}
			Rect rect = new Rect((float)(100 + this.m_Slot * 100), 200f, 90f, 20f);
			if (base.isLocalPlayer)
			{
				GUI.Label(rect, " [ You ]");
				if (this.m_ReadyToBegin)
				{
					rect.y += 25f;
					if (GUI.Button(rect, "Ready"))
					{
						this.SendNotReadyToBeginMessage();
					}
				}
				else
				{
					rect.y += 25f;
					if (GUI.Button(rect, "Not Ready"))
					{
						this.SendReadyToBeginMessage();
					}
					rect.y += 25f;
					if (GUI.Button(rect, "Remove"))
					{
						ClientScene.RemovePlayer(base.GetComponent<NetworkIdentity>().playerControllerId);
					}
				}
			}
			else
			{
				GUI.Label(rect, "Player [" + base.netId + "]");
				rect.y += 25f;
				GUI.Label(rect, "Ready [" + this.m_ReadyToBegin + "]");
			}
		}

		// Token: 0x04000120 RID: 288
		[SerializeField]
		public bool ShowLobbyGUI = true;

		// Token: 0x04000121 RID: 289
		private byte m_Slot;

		// Token: 0x04000122 RID: 290
		private bool m_ReadyToBegin;
	}
}
