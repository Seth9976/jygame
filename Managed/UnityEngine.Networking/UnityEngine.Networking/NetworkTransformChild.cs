using System;

namespace UnityEngine.Networking
{
	// Token: 0x0200004D RID: 77
	[AddComponentMenu("Network/NetworkTransformChild")]
	public class NetworkTransformChild : NetworkBehaviour
	{
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x000131C4 File Offset: 0x000113C4
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x000131CC File Offset: 0x000113CC
		public Transform target
		{
			get
			{
				return this.m_Target;
			}
			set
			{
				this.m_Target = value;
				this.OnValidate();
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x000131DC File Offset: 0x000113DC
		public uint childIndex
		{
			get
			{
				return this.m_ChildIndex;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x000131E4 File Offset: 0x000113E4
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x000131EC File Offset: 0x000113EC
		public float sendInterval
		{
			get
			{
				return this.m_SendInterval;
			}
			set
			{
				this.m_SendInterval = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x000131F8 File Offset: 0x000113F8
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00013200 File Offset: 0x00011400
		public NetworkTransform.AxisSyncMode syncRotationAxis
		{
			get
			{
				return this.m_SyncRotationAxis;
			}
			set
			{
				this.m_SyncRotationAxis = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x0001320C File Offset: 0x0001140C
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00013214 File Offset: 0x00011414
		public NetworkTransform.CompressionSyncMode rotationSyncCompression
		{
			get
			{
				return this.m_RotationSyncCompression;
			}
			set
			{
				this.m_RotationSyncCompression = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00013220 File Offset: 0x00011420
		// (set) Token: 0x060003BC RID: 956 RVA: 0x00013228 File Offset: 0x00011428
		public float movementThreshold
		{
			get
			{
				return this.m_MovementThreshold;
			}
			set
			{
				this.m_MovementThreshold = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00013234 File Offset: 0x00011434
		// (set) Token: 0x060003BE RID: 958 RVA: 0x0001323C File Offset: 0x0001143C
		public float interpolateRotation
		{
			get
			{
				return this.m_InterpolateRotation;
			}
			set
			{
				this.m_InterpolateRotation = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00013248 File Offset: 0x00011448
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x00013250 File Offset: 0x00011450
		public float interpolateMovement
		{
			get
			{
				return this.m_InterpolateMovement;
			}
			set
			{
				this.m_InterpolateMovement = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0001325C File Offset: 0x0001145C
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x00013264 File Offset: 0x00011464
		public NetworkTransform.ClientMoveCallback3D clientMoveCallback3D
		{
			get
			{
				return this.m_ClientMoveCallback3D;
			}
			set
			{
				this.m_ClientMoveCallback3D = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00013270 File Offset: 0x00011470
		public float lastSyncTime
		{
			get
			{
				return this.m_LastClientSyncTime;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00013278 File Offset: 0x00011478
		public Vector3 targetSyncPosition
		{
			get
			{
				return this.m_TargetSyncPosition;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00013280 File Offset: 0x00011480
		public Quaternion targetSyncRotation3D
		{
			get
			{
				return this.m_TargetSyncRotation3D;
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00013288 File Offset: 0x00011488
		private void OnValidate()
		{
			if (this.m_Target != null)
			{
				Transform transform = this.m_Target.parent;
				if (transform == null)
				{
					if (LogFilter.logError)
					{
						Debug.LogError("NetworkTransformChild target cannot be the root transform.");
					}
					this.m_Target = null;
					return;
				}
				while (transform.parent != null)
				{
					transform = transform.parent;
				}
				this.m_Root = transform.gameObject.GetComponent<NetworkTransform>();
				if (this.m_Root == null)
				{
					if (LogFilter.logError)
					{
						Debug.LogError("NetworkTransformChild root must have NetworkTransform");
					}
					this.m_Target = null;
					return;
				}
			}
			this.m_ChildIndex = uint.MaxValue;
			NetworkTransformChild[] components = this.m_Root.GetComponents<NetworkTransformChild>();
			uint num = 0U;
			while ((ulong)num < (ulong)((long)components.Length))
			{
				if (components[(int)((UIntPtr)num)] == this)
				{
					this.m_ChildIndex = num;
					break;
				}
				num += 1U;
			}
			if (this.m_ChildIndex == 4294967295U)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("NetworkTransformChild component must be a child in the same hierarchy");
				}
				this.m_Target = null;
			}
			if (this.m_SendInterval < 0f)
			{
				this.m_SendInterval = 0f;
			}
			if (this.m_SyncRotationAxis < NetworkTransform.AxisSyncMode.None || this.m_SyncRotationAxis > NetworkTransform.AxisSyncMode.AxisXYZ)
			{
				this.m_SyncRotationAxis = NetworkTransform.AxisSyncMode.None;
			}
			if (this.movementThreshold < 0f)
			{
				this.movementThreshold = 0f;
			}
			if (this.interpolateRotation < 0f)
			{
				this.interpolateRotation = 0.01f;
			}
			if (this.interpolateRotation > 1f)
			{
				this.interpolateRotation = 1f;
			}
			if (this.interpolateMovement < 0f)
			{
				this.interpolateMovement = 0.01f;
			}
			if (this.interpolateMovement > 1f)
			{
				this.interpolateMovement = 1f;
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00013464 File Offset: 0x00011664
		private void Awake()
		{
			this.m_PrevPosition = this.m_Target.localPosition;
			this.m_PrevRotation = this.m_Target.localRotation;
			if (base.localPlayerAuthority)
			{
				this.m_LocalTransformWriter = new NetworkWriter();
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x000134AC File Offset: 0x000116AC
		public override bool OnSerialize(NetworkWriter writer, bool initialState)
		{
			if (!initialState)
			{
				if (base.syncVarDirtyBits == 0U)
				{
					writer.WritePackedUInt32(0U);
					return false;
				}
				writer.WritePackedUInt32(1U);
			}
			this.SerializeModeTransform(writer);
			return true;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000134E8 File Offset: 0x000116E8
		private void SerializeModeTransform(NetworkWriter writer)
		{
			writer.Write(this.m_Target.localPosition);
			if (this.m_SyncRotationAxis != NetworkTransform.AxisSyncMode.None)
			{
				NetworkTransform.SerializeRotation3D(writer, this.m_Target.localRotation, this.syncRotationAxis, this.rotationSyncCompression);
			}
			this.m_PrevPosition = this.m_Target.localPosition;
			this.m_PrevRotation = this.m_Target.localRotation;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00013550 File Offset: 0x00011750
		public override void OnDeserialize(NetworkReader reader, bool initialState)
		{
			if (base.isServer && NetworkServer.localClientActive)
			{
				return;
			}
			if (!initialState && reader.ReadPackedUInt32() == 0U)
			{
				return;
			}
			this.UnserializeModeTransform(reader, initialState);
			this.m_LastClientSyncTime = Time.time;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00013598 File Offset: 0x00011798
		private void UnserializeModeTransform(NetworkReader reader, bool initialState)
		{
			if (base.hasAuthority)
			{
				reader.ReadVector3();
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					NetworkTransform.UnserializeRotation3D(reader, this.syncRotationAxis, this.rotationSyncCompression);
				}
				return;
			}
			if (base.isServer && this.m_ClientMoveCallback3D != null)
			{
				Vector3 vector = reader.ReadVector3();
				Vector3 zero = Vector3.zero;
				Quaternion quaternion = Quaternion.identity;
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					quaternion = NetworkTransform.UnserializeRotation3D(reader, this.syncRotationAxis, this.rotationSyncCompression);
				}
				if (!this.m_ClientMoveCallback3D(ref vector, ref zero, ref quaternion))
				{
					return;
				}
				this.m_TargetSyncPosition = vector;
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					this.m_TargetSyncRotation3D = quaternion;
				}
			}
			else
			{
				this.m_TargetSyncPosition = reader.ReadVector3();
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					this.m_TargetSyncRotation3D = NetworkTransform.UnserializeRotation3D(reader, this.syncRotationAxis, this.rotationSyncCompression);
				}
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00013688 File Offset: 0x00011888
		private void FixedUpdate()
		{
			if (base.isServer)
			{
				this.FixedUpdateServer();
			}
			if (base.isClient)
			{
				this.FixedUpdateClient();
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x000136B8 File Offset: 0x000118B8
		private void FixedUpdateServer()
		{
			if (base.syncVarDirtyBits != 0U)
			{
				return;
			}
			if (!NetworkServer.active)
			{
				return;
			}
			if (!base.isServer)
			{
				return;
			}
			if (this.GetNetworkSendInterval() == 0f)
			{
				return;
			}
			float num = (this.m_Target.localPosition - this.m_PrevPosition).sqrMagnitude;
			if (num < this.movementThreshold)
			{
				num = Quaternion.Angle(this.m_PrevRotation, this.m_Target.localRotation);
				if (num < this.movementThreshold)
				{
					return;
				}
			}
			base.SetDirtyBit(1U);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00013750 File Offset: 0x00011950
		private void FixedUpdateClient()
		{
			if (this.m_LastClientSyncTime == 0f)
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
			if (this.GetNetworkSendInterval() == 0f)
			{
				return;
			}
			if (base.hasAuthority)
			{
				return;
			}
			if (this.m_LastClientSyncTime != 0f)
			{
				this.m_Target.localPosition = Vector3.Lerp(this.m_Target.localPosition, this.m_TargetSyncPosition, this.m_InterpolateMovement);
				this.m_Target.localRotation = Quaternion.Slerp(this.m_Target.localRotation, this.m_TargetSyncRotation3D, this.m_InterpolateRotation);
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00013818 File Offset: 0x00011A18
		private void Update()
		{
			if (!base.hasAuthority)
			{
				return;
			}
			if (!base.localPlayerAuthority)
			{
				return;
			}
			if (NetworkServer.active)
			{
				return;
			}
			if (Time.time - this.m_LastClientSendTime > this.GetNetworkSendInterval())
			{
				this.SendTransform();
				this.m_LastClientSendTime = Time.time;
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00013870 File Offset: 0x00011A70
		private bool HasMoved()
		{
			float num = (this.m_Target.localPosition - this.m_PrevPosition).sqrMagnitude;
			if (num > 1E-05f)
			{
				return true;
			}
			num = Quaternion.Angle(this.m_Target.localRotation, this.m_PrevRotation);
			return num > 1E-05f;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x000138D4 File Offset: 0x00011AD4
		[Client]
		private void SendTransform()
		{
			if (!this.HasMoved() || ClientScene.readyConnection == null)
			{
				return;
			}
			this.m_LocalTransformWriter.StartMessage(16);
			this.m_LocalTransformWriter.Write(base.netId);
			this.m_LocalTransformWriter.WritePackedUInt32(this.m_ChildIndex);
			this.SerializeModeTransform(this.m_LocalTransformWriter);
			this.m_PrevPosition = this.m_Target.localPosition;
			this.m_PrevRotation = this.m_Target.localRotation;
			this.m_LocalTransformWriter.FinishMessage();
			ClientScene.readyConnection.SendWriter(this.m_LocalTransformWriter, this.GetNetworkChannel());
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00013978 File Offset: 0x00011B78
		internal static void HandleChildTransform(NetworkMessage netMsg)
		{
			NetworkInstanceId networkInstanceId = netMsg.reader.ReadNetworkId();
			uint num = netMsg.reader.ReadPackedUInt32();
			GameObject gameObject = NetworkServer.FindLocalObject(networkInstanceId);
			if (gameObject == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("HandleChildTransform no gameObject");
				}
				return;
			}
			NetworkTransformChild[] components = gameObject.GetComponents<NetworkTransformChild>();
			if (components == null || components.Length == 0)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("HandleChildTransform no children");
				}
				return;
			}
			if ((ulong)num >= (ulong)((long)components.Length))
			{
				if (LogFilter.logError)
				{
					Debug.LogError("HandleChildTransform childIndex invalid");
				}
				return;
			}
			NetworkTransformChild networkTransformChild = components[(int)((UIntPtr)num)];
			if (networkTransformChild == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("HandleChildTransform null target");
				}
				return;
			}
			if (!networkTransformChild.localPlayerAuthority)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("HandleChildTransform no localPlayerAuthority");
				}
				return;
			}
			if (!netMsg.conn.clientOwnedObjects.Contains(networkInstanceId))
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("NetworkTransformChild netId:" + networkInstanceId + " is not for a valid player");
				}
				return;
			}
			networkTransformChild.UnserializeModeTransform(netMsg.reader, false);
			networkTransformChild.m_LastClientSyncTime = Time.time;
			if (!networkTransformChild.isClient)
			{
				networkTransformChild.m_Target.localPosition = networkTransformChild.m_TargetSyncPosition;
				networkTransformChild.m_Target.localRotation = networkTransformChild.m_TargetSyncRotation3D;
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00013AE0 File Offset: 0x00011CE0
		public override int GetNetworkChannel()
		{
			return 1;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00013AE4 File Offset: 0x00011CE4
		public override float GetNetworkSendInterval()
		{
			return this.m_SendInterval;
		}

		// Token: 0x04000182 RID: 386
		private const float k_LocalMovementThreshold = 1E-05f;

		// Token: 0x04000183 RID: 387
		private const float k_LocalRotationThreshold = 1E-05f;

		// Token: 0x04000184 RID: 388
		[SerializeField]
		private Transform m_Target;

		// Token: 0x04000185 RID: 389
		[SerializeField]
		private uint m_ChildIndex;

		// Token: 0x04000186 RID: 390
		private NetworkTransform m_Root;

		// Token: 0x04000187 RID: 391
		[SerializeField]
		private float m_SendInterval = 0.1f;

		// Token: 0x04000188 RID: 392
		[SerializeField]
		private NetworkTransform.AxisSyncMode m_SyncRotationAxis = NetworkTransform.AxisSyncMode.AxisXYZ;

		// Token: 0x04000189 RID: 393
		[SerializeField]
		private NetworkTransform.CompressionSyncMode m_RotationSyncCompression;

		// Token: 0x0400018A RID: 394
		[SerializeField]
		private float m_MovementThreshold = 0.001f;

		// Token: 0x0400018B RID: 395
		[SerializeField]
		private float m_InterpolateRotation = 0.5f;

		// Token: 0x0400018C RID: 396
		[SerializeField]
		private float m_InterpolateMovement = 0.5f;

		// Token: 0x0400018D RID: 397
		[SerializeField]
		private NetworkTransform.ClientMoveCallback3D m_ClientMoveCallback3D;

		// Token: 0x0400018E RID: 398
		private Vector3 m_TargetSyncPosition;

		// Token: 0x0400018F RID: 399
		private Quaternion m_TargetSyncRotation3D;

		// Token: 0x04000190 RID: 400
		private float m_LastClientSyncTime;

		// Token: 0x04000191 RID: 401
		private float m_LastClientSendTime;

		// Token: 0x04000192 RID: 402
		private Vector3 m_PrevPosition;

		// Token: 0x04000193 RID: 403
		private Quaternion m_PrevRotation;

		// Token: 0x04000194 RID: 404
		private NetworkWriter m_LocalTransformWriter;
	}
}
