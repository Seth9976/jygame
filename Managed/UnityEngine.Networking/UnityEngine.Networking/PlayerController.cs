using System;

namespace UnityEngine.Networking
{
	// Token: 0x02000054 RID: 84
	public class PlayerController
	{
		// Token: 0x06000454 RID: 1108 RVA: 0x00016EDC File Offset: 0x000150DC
		public PlayerController()
		{
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00016EEC File Offset: 0x000150EC
		internal PlayerController(GameObject go, short playerControllerId)
		{
			this.gameObject = go;
			this.unetView = go.GetComponent<NetworkIdentity>();
			this.playerControllerId = playerControllerId;
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00016F18 File Offset: 0x00015118
		public bool IsValid
		{
			get
			{
				return this.playerControllerId != -1;
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00016F28 File Offset: 0x00015128
		public override string ToString()
		{
			return string.Format("ID={0} NetworkIdentity NetID={1} Player={2}", new object[]
			{
				this.playerControllerId,
				(!(this.unetView != null)) ? "null" : this.unetView.netId.ToString(),
				(!(this.gameObject != null)) ? "null" : this.gameObject.name
			});
		}

		// Token: 0x040001D2 RID: 466
		internal const short kMaxLocalPlayers = 8;

		// Token: 0x040001D3 RID: 467
		public const int MaxPlayersPerClient = 32;

		// Token: 0x040001D4 RID: 468
		public short playerControllerId = -1;

		// Token: 0x040001D5 RID: 469
		public NetworkIdentity unetView;

		// Token: 0x040001D6 RID: 470
		public GameObject gameObject;
	}
}
