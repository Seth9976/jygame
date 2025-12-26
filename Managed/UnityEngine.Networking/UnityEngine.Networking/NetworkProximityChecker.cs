using System;
using System.Collections.Generic;

namespace UnityEngine.Networking
{
	// Token: 0x02000046 RID: 70
	[RequireComponent(typeof(NetworkIdentity))]
	[AddComponentMenu("Network/NetworkProximityChecker")]
	public class NetworkProximityChecker : NetworkBehaviour
	{
		// Token: 0x060002F3 RID: 755 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		private void Update()
		{
			if (!NetworkServer.active)
			{
				return;
			}
			if (Time.time - this.m_VisUpdateTime > this.visUpdateInterval)
			{
				base.GetComponent<NetworkIdentity>().RebuildObservers(false);
				this.m_VisUpdateTime = Time.time;
			}
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000EB08 File Offset: 0x0000CD08
		public override bool OnCheckObserver(NetworkConnection newObserver)
		{
			if (this.forceHidden)
			{
				return false;
			}
			GameObject gameObject = null;
			foreach (PlayerController playerController in newObserver.playerControllers)
			{
				if (playerController != null && playerController.gameObject != null)
				{
					gameObject = playerController.gameObject;
					break;
				}
			}
			if (gameObject == null)
			{
				return false;
			}
			Vector3 position = gameObject.transform.position;
			return (position - base.transform.position).magnitude < (float)this.visRange;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000EBD8 File Offset: 0x0000CDD8
		public override bool OnRebuildObservers(HashSet<NetworkConnection> observers, bool initial)
		{
			if (this.forceHidden)
			{
				NetworkIdentity component = base.GetComponent<NetworkIdentity>();
				if (component.connectionToClient != null)
				{
					observers.Add(component.connectionToClient);
				}
				return true;
			}
			NetworkProximityChecker.CheckMethod checkMethod = this.checkMethod;
			if (checkMethod == NetworkProximityChecker.CheckMethod.Physics3D)
			{
				Collider[] array = Physics.OverlapSphere(base.transform.position, (float)this.visRange);
				foreach (Collider collider in array)
				{
					NetworkIdentity component2 = collider.GetComponent<NetworkIdentity>();
					if (component2 != null && component2.connectionToClient != null)
					{
						observers.Add(component2.connectionToClient);
					}
				}
				return true;
			}
			if (checkMethod != NetworkProximityChecker.CheckMethod.Physics2D)
			{
				return false;
			}
			Collider2D[] array3 = Physics2D.OverlapCircleAll(base.transform.position, (float)this.visRange);
			foreach (Collider2D collider2D in array3)
			{
				NetworkIdentity component3 = collider2D.GetComponent<NetworkIdentity>();
				if (component3 != null && component3.connectionToClient != null)
				{
					observers.Add(component3.connectionToClient);
				}
			}
			return true;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000ED0C File Offset: 0x0000CF0C
		public override void OnSetLocalVisibility(bool vis)
		{
			NetworkProximityChecker.SetVis(base.gameObject, vis);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000ED1C File Offset: 0x0000CF1C
		private static void SetVis(GameObject go, bool vis)
		{
			foreach (Renderer renderer in go.GetComponents<Renderer>())
			{
				renderer.enabled = vis;
			}
			for (int j = 0; j < go.transform.childCount; j++)
			{
				Transform child = go.transform.GetChild(j);
				NetworkProximityChecker.SetVis(child.gameObject, vis);
			}
		}

		// Token: 0x04000158 RID: 344
		public int visRange = 10;

		// Token: 0x04000159 RID: 345
		public float visUpdateInterval = 1f;

		// Token: 0x0400015A RID: 346
		public NetworkProximityChecker.CheckMethod checkMethod;

		// Token: 0x0400015B RID: 347
		public bool forceHidden;

		// Token: 0x0400015C RID: 348
		private float m_VisUpdateTime;

		// Token: 0x02000047 RID: 71
		public enum CheckMethod
		{
			// Token: 0x0400015E RID: 350
			Physics3D,
			// Token: 0x0400015F RID: 351
			Physics2D
		}
	}
}
