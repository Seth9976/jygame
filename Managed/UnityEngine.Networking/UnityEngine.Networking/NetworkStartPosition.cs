using System;

namespace UnityEngine.Networking
{
	// Token: 0x0200004C RID: 76
	[AddComponentMenu("Network/NetworkStartPosition")]
	[DisallowMultipleComponent]
	public class NetworkStartPosition : MonoBehaviour
	{
		// Token: 0x060003AF RID: 943 RVA: 0x00013168 File Offset: 0x00011368
		public void Awake()
		{
			NetworkManager.RegisterStartPosition(base.transform);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00013178 File Offset: 0x00011378
		public void OnDestroy()
		{
			NetworkManager.UnRegisterStartPosition(base.transform);
		}
	}
}
