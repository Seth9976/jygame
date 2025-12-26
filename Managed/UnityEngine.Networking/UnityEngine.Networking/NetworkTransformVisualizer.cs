using System;
using System.ComponentModel;

namespace UnityEngine.Networking
{
	// Token: 0x02000052 RID: 82
	[AddComponentMenu("Network/NetworkTransformVisualizer")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[RequireComponent(typeof(NetworkTransform))]
	[DisallowMultipleComponent]
	public class NetworkTransformVisualizer : NetworkBehaviour
	{
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00015B74 File Offset: 0x00013D74
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00015B7C File Offset: 0x00013D7C
		public GameObject visualizerPrefab
		{
			get
			{
				return this.m_VisualizerPrefab;
			}
			set
			{
				this.m_VisualizerPrefab = value;
			}
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00015B88 File Offset: 0x00013D88
		public override void OnStartClient()
		{
			if (this.m_VisualizerPrefab != null)
			{
				this.m_NetworkTransform = base.GetComponent<NetworkTransform>();
				NetworkTransformVisualizer.CreateLineMaterial();
				this.m_Visualizer = (GameObject)Object.Instantiate(this.m_VisualizerPrefab, base.transform.position, Quaternion.identity);
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00015BE0 File Offset: 0x00013DE0
		public override void OnStartLocalPlayer()
		{
			if (this.m_Visualizer == null)
			{
				return;
			}
			if (this.m_NetworkTransform.localPlayerAuthority || base.isServer)
			{
				Object.Destroy(this.m_Visualizer);
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00015C28 File Offset: 0x00013E28
		private void OnDestroy()
		{
			if (this.m_Visualizer != null)
			{
				Object.Destroy(this.m_Visualizer);
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00015C48 File Offset: 0x00013E48
		[ClientCallback]
		private void FixedUpdate()
		{
			if (this.m_Visualizer == null)
			{
				return;
			}
			if (!NetworkServer.active && !NetworkClient.active)
			{
				return;
			}
			if (!base.isServer && !base.isClient)
			{
				return;
			}
			if (base.hasAuthority && this.m_NetworkTransform.localPlayerAuthority)
			{
				return;
			}
			this.m_Visualizer.transform.position = this.m_NetworkTransform.targetSyncPosition;
			if (this.m_NetworkTransform.rigidbody3D != null && this.m_Visualizer.GetComponent<Rigidbody>() != null)
			{
				this.m_Visualizer.GetComponent<Rigidbody>().velocity = this.m_NetworkTransform.targetSyncVelocity;
			}
			if (this.m_NetworkTransform.rigidbody2D != null && this.m_Visualizer.GetComponent<Rigidbody2D>() != null)
			{
				this.m_Visualizer.GetComponent<Rigidbody2D>().velocity = this.m_NetworkTransform.targetSyncVelocity;
			}
			Quaternion quaternion = Quaternion.identity;
			if (this.m_NetworkTransform.rigidbody3D != null)
			{
				quaternion = this.m_NetworkTransform.targetSyncRotation3D;
			}
			if (this.m_NetworkTransform.rigidbody2D != null)
			{
				quaternion = Quaternion.Euler(0f, 0f, this.m_NetworkTransform.targetSyncRotation2D);
			}
			this.m_Visualizer.transform.rotation = quaternion;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00015DC8 File Offset: 0x00013FC8
		private void OnRenderObject()
		{
			if (this.m_Visualizer == null)
			{
				return;
			}
			if (this.m_NetworkTransform.localPlayerAuthority && base.hasAuthority)
			{
				return;
			}
			if (this.m_NetworkTransform.lastSyncTime == 0f)
			{
				return;
			}
			NetworkTransformVisualizer.s_LineMaterial.SetPass(0);
			GL.Begin(1);
			GL.Color(Color.white);
			GL.Vertex3(base.transform.position.x, base.transform.position.y, base.transform.position.z);
			GL.Vertex3(this.m_NetworkTransform.targetSyncPosition.x, this.m_NetworkTransform.targetSyncPosition.y, this.m_NetworkTransform.targetSyncPosition.z);
			GL.End();
			this.DrawRotationInterpolation();
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00015EC0 File Offset: 0x000140C0
		private void DrawRotationInterpolation()
		{
			Quaternion quaternion = Quaternion.identity;
			if (this.m_NetworkTransform.rigidbody3D != null)
			{
				quaternion = this.m_NetworkTransform.targetSyncRotation3D;
			}
			if (this.m_NetworkTransform.rigidbody2D != null)
			{
				quaternion = Quaternion.Euler(0f, 0f, this.m_NetworkTransform.targetSyncRotation2D);
			}
			if (quaternion == Quaternion.identity)
			{
				return;
			}
			GL.Begin(1);
			GL.Color(Color.yellow);
			GL.Vertex3(base.transform.position.x, base.transform.position.y, base.transform.position.z);
			Vector3 vector = base.transform.position + base.transform.right;
			GL.Vertex3(vector.x, vector.y, vector.z);
			GL.End();
			GL.Begin(1);
			GL.Color(Color.green);
			GL.Vertex3(base.transform.position.x, base.transform.position.y, base.transform.position.z);
			Vector3 vector2 = quaternion * Vector3.right;
			Vector3 vector3 = base.transform.position + vector2;
			GL.Vertex3(vector3.x, vector3.y, vector3.z);
			GL.End();
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00016054 File Offset: 0x00014254
		private static void CreateLineMaterial()
		{
			if (NetworkTransformVisualizer.s_LineMaterial)
			{
				return;
			}
			Shader shader = Shader.Find("Hidden/Internal-Colored");
			if (!shader)
			{
				Debug.LogWarning("Could not find Colored builtin shader");
				return;
			}
			NetworkTransformVisualizer.s_LineMaterial = new Material(shader);
			NetworkTransformVisualizer.s_LineMaterial.hideFlags = HideFlags.HideAndDontSave;
			NetworkTransformVisualizer.s_LineMaterial.SetInt("_ZWrite", 0);
		}

		// Token: 0x040001C9 RID: 457
		[SerializeField]
		private GameObject m_VisualizerPrefab;

		// Token: 0x040001CA RID: 458
		private NetworkTransform m_NetworkTransform;

		// Token: 0x040001CB RID: 459
		private GameObject m_Visualizer;

		// Token: 0x040001CC RID: 460
		private static Material s_LineMaterial;
	}
}
