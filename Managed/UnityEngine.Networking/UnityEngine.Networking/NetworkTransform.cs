using System;

namespace UnityEngine.Networking
{
	// Token: 0x0200004E RID: 78
	[DisallowMultipleComponent]
	[AddComponentMenu("Network/NetworkTransform")]
	public class NetworkTransform : NetworkBehaviour
	{
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00013B44 File Offset: 0x00011D44
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00013B4C File Offset: 0x00011D4C
		public NetworkTransform.TransformSyncMode transformSyncMode
		{
			get
			{
				return this.m_TransformSyncMode;
			}
			set
			{
				this.m_TransformSyncMode = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00013B58 File Offset: 0x00011D58
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x00013B60 File Offset: 0x00011D60
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

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00013B6C File Offset: 0x00011D6C
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00013B74 File Offset: 0x00011D74
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

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00013B80 File Offset: 0x00011D80
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00013B88 File Offset: 0x00011D88
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

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00013B94 File Offset: 0x00011D94
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00013B9C File Offset: 0x00011D9C
		public bool syncSpin
		{
			get
			{
				return this.m_SyncSpin;
			}
			set
			{
				this.m_SyncSpin = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00013BA8 File Offset: 0x00011DA8
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x00013BB0 File Offset: 0x00011DB0
		public float movementTheshold
		{
			get
			{
				return this.m_MovementTheshold;
			}
			set
			{
				this.m_MovementTheshold = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00013BBC File Offset: 0x00011DBC
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x00013BC4 File Offset: 0x00011DC4
		public float snapThreshold
		{
			get
			{
				return this.m_SnapThreshold;
			}
			set
			{
				this.m_SnapThreshold = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00013BD0 File Offset: 0x00011DD0
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x00013BD8 File Offset: 0x00011DD8
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

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00013BE4 File Offset: 0x00011DE4
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00013BEC File Offset: 0x00011DEC
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

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00013BF8 File Offset: 0x00011DF8
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00013C00 File Offset: 0x00011E00
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

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00013C0C File Offset: 0x00011E0C
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00013C14 File Offset: 0x00011E14
		public NetworkTransform.ClientMoveCallback2D clientMoveCallback2D
		{
			get
			{
				return this.m_ClientMoveCallback2D;
			}
			set
			{
				this.m_ClientMoveCallback2D = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00013C20 File Offset: 0x00011E20
		public CharacterController characterContoller
		{
			get
			{
				return this.m_CharacterController;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00013C28 File Offset: 0x00011E28
		public Rigidbody rigidbody3D
		{
			get
			{
				return this.m_RigidBody3D;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00013C30 File Offset: 0x00011E30
		public Rigidbody2D rigidbody2D
		{
			get
			{
				return this.m_RigidBody2D;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00013C38 File Offset: 0x00011E38
		public float lastSyncTime
		{
			get
			{
				return this.m_LastClientSyncTime;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00013C40 File Offset: 0x00011E40
		public Vector3 targetSyncPosition
		{
			get
			{
				return this.m_TargetSyncPosition;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00013C48 File Offset: 0x00011E48
		public Vector3 targetSyncVelocity
		{
			get
			{
				return this.m_TargetSyncVelocity;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00013C50 File Offset: 0x00011E50
		public Quaternion targetSyncRotation3D
		{
			get
			{
				return this.m_TargetSyncRotation3D;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00013C58 File Offset: 0x00011E58
		public float targetSyncRotation2D
		{
			get
			{
				return this.m_TargetSyncRotation2D;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00013C60 File Offset: 0x00011E60
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00013C68 File Offset: 0x00011E68
		public bool grounded
		{
			get
			{
				return this.m_Grounded;
			}
			set
			{
				this.m_Grounded = value;
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00013C74 File Offset: 0x00011E74
		private void OnValidate()
		{
			if (this.m_TransformSyncMode < NetworkTransform.TransformSyncMode.SyncNone || this.m_TransformSyncMode > NetworkTransform.TransformSyncMode.SyncCharacterController)
			{
				this.m_TransformSyncMode = NetworkTransform.TransformSyncMode.SyncTransform;
			}
			if (this.m_SendInterval < 0f)
			{
				this.m_SendInterval = 0f;
			}
			if (this.m_SyncRotationAxis < NetworkTransform.AxisSyncMode.None || this.m_SyncRotationAxis > NetworkTransform.AxisSyncMode.AxisXYZ)
			{
				this.m_SyncRotationAxis = NetworkTransform.AxisSyncMode.None;
			}
			if (this.m_MovementTheshold < 0f)
			{
				this.m_MovementTheshold = 0f;
			}
			if (this.m_SnapThreshold < 0f)
			{
				this.m_SnapThreshold = 0.01f;
			}
			if (this.m_InterpolateRotation < 0f)
			{
				this.m_InterpolateRotation = 0.01f;
			}
			if (this.m_InterpolateMovement < 0f)
			{
				this.m_InterpolateMovement = 0.01f;
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00013D48 File Offset: 0x00011F48
		private void Awake()
		{
			this.m_RigidBody3D = base.GetComponent<Rigidbody>();
			this.m_RigidBody2D = base.GetComponent<Rigidbody2D>();
			this.m_CharacterController = base.GetComponent<CharacterController>();
			this.m_PrevPosition = base.transform.position;
			this.m_PrevRotation = base.transform.rotation;
			this.m_PrevVelocity = 0f;
			if (base.localPlayerAuthority)
			{
				this.m_LocalTransformWriter = new NetworkWriter();
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00013DBC File Offset: 0x00011FBC
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
			switch (this.transformSyncMode)
			{
			case NetworkTransform.TransformSyncMode.SyncNone:
				return false;
			case NetworkTransform.TransformSyncMode.SyncTransform:
				this.SerializeModeTransform(writer);
				break;
			case NetworkTransform.TransformSyncMode.SyncRigidbody2D:
				this.SerializeMode2D(writer);
				break;
			case NetworkTransform.TransformSyncMode.SyncRigidbody3D:
				this.SerializeMode3D(writer);
				break;
			case NetworkTransform.TransformSyncMode.SyncCharacterController:
				this.SerializeModeCharacterController(writer);
				break;
			}
			return true;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00013E48 File Offset: 0x00012048
		private void SerializeModeTransform(NetworkWriter writer)
		{
			writer.Write(base.transform.position);
			if (this.m_SyncRotationAxis != NetworkTransform.AxisSyncMode.None)
			{
				NetworkTransform.SerializeRotation3D(writer, base.transform.rotation, this.syncRotationAxis, this.rotationSyncCompression);
			}
			this.m_PrevPosition = base.transform.position;
			this.m_PrevRotation = base.transform.rotation;
			this.m_PrevVelocity = 0f;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00013EBC File Offset: 0x000120BC
		private void SerializeMode3D(NetworkWriter writer)
		{
			if (base.isServer && this.m_LastClientSyncTime != 0f)
			{
				writer.Write(this.m_TargetSyncPosition);
				NetworkTransform.SerializeVelocity3D(writer, this.m_TargetSyncVelocity, NetworkTransform.CompressionSyncMode.None);
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					NetworkTransform.SerializeRotation3D(writer, this.m_TargetSyncRotation3D, this.syncRotationAxis, this.rotationSyncCompression);
				}
			}
			else
			{
				writer.Write(this.m_RigidBody3D.position);
				NetworkTransform.SerializeVelocity3D(writer, this.m_RigidBody3D.velocity, NetworkTransform.CompressionSyncMode.None);
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					NetworkTransform.SerializeRotation3D(writer, this.m_RigidBody3D.rotation, this.syncRotationAxis, this.rotationSyncCompression);
				}
			}
			if (this.m_SyncSpin)
			{
				NetworkTransform.SerializeSpin3D(writer, this.m_RigidBody3D.angularVelocity, this.syncRotationAxis, this.rotationSyncCompression);
			}
			this.m_PrevPosition = this.m_RigidBody3D.position;
			this.m_PrevRotation = base.transform.rotation;
			this.m_PrevVelocity = this.m_RigidBody3D.velocity.sqrMagnitude;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00013FD4 File Offset: 0x000121D4
		private void SerializeModeCharacterController(NetworkWriter writer)
		{
			if (base.isServer && this.m_LastClientSyncTime != 0f)
			{
				writer.Write(this.m_TargetSyncPosition);
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					NetworkTransform.SerializeRotation3D(writer, this.m_TargetSyncRotation3D, this.syncRotationAxis, this.rotationSyncCompression);
				}
			}
			else
			{
				writer.Write(base.transform.position);
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					NetworkTransform.SerializeRotation3D(writer, base.transform.rotation, this.syncRotationAxis, this.rotationSyncCompression);
				}
			}
			this.m_PrevPosition = base.transform.position;
			this.m_PrevRotation = base.transform.rotation;
			this.m_PrevVelocity = 0f;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00014098 File Offset: 0x00012298
		private void SerializeMode2D(NetworkWriter writer)
		{
			if (base.isServer && this.m_LastClientSyncTime != 0f)
			{
				writer.Write(this.m_TargetSyncPosition);
				NetworkTransform.SerializeVelocity2D(writer, this.m_TargetSyncVelocity, NetworkTransform.CompressionSyncMode.None);
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					float num = this.m_TargetSyncRotation2D % 360f;
					if (num < 0f)
					{
						num += 360f;
					}
					NetworkTransform.SerializeRotation2D(writer, num, this.rotationSyncCompression);
				}
			}
			else
			{
				writer.Write(this.m_RigidBody2D.position);
				NetworkTransform.SerializeVelocity2D(writer, this.m_RigidBody2D.velocity, NetworkTransform.CompressionSyncMode.None);
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					float num2 = this.m_RigidBody2D.rotation % 360f;
					if (num2 < 0f)
					{
						num2 += 360f;
					}
					NetworkTransform.SerializeRotation2D(writer, num2, this.rotationSyncCompression);
				}
			}
			if (this.m_SyncSpin)
			{
				NetworkTransform.SerializeSpin2D(writer, this.m_RigidBody2D.angularVelocity, this.rotationSyncCompression);
			}
			this.m_PrevPosition = this.m_RigidBody2D.position;
			this.m_PrevRotation = base.transform.rotation;
			this.m_PrevVelocity = this.m_RigidBody2D.velocity.sqrMagnitude;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000141E4 File Offset: 0x000123E4
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
			switch (this.transformSyncMode)
			{
			case NetworkTransform.TransformSyncMode.SyncNone:
				return;
			case NetworkTransform.TransformSyncMode.SyncTransform:
				this.UnserializeModeTransform(reader, initialState);
				break;
			case NetworkTransform.TransformSyncMode.SyncRigidbody2D:
				this.UnserializeMode2D(reader, initialState);
				break;
			case NetworkTransform.TransformSyncMode.SyncRigidbody3D:
				this.UnserializeMode3D(reader, initialState);
				break;
			case NetworkTransform.TransformSyncMode.SyncCharacterController:
				this.UnserializeModeCharacterController(reader, initialState);
				break;
			}
			this.m_LastClientSyncTime = Time.time;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00014280 File Offset: 0x00012480
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
				base.transform.position = vector;
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					base.transform.rotation = quaternion;
				}
			}
			else
			{
				base.transform.position = reader.ReadVector3();
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					base.transform.rotation = NetworkTransform.UnserializeRotation3D(reader, this.syncRotationAxis, this.rotationSyncCompression);
				}
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00014384 File Offset: 0x00012584
		private void UnserializeMode3D(NetworkReader reader, bool initialState)
		{
			if (base.hasAuthority)
			{
				reader.ReadVector3();
				reader.ReadVector3();
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					NetworkTransform.UnserializeRotation3D(reader, this.syncRotationAxis, this.rotationSyncCompression);
				}
				if (this.syncSpin)
				{
					NetworkTransform.UnserializeSpin3D(reader, this.syncRotationAxis, this.rotationSyncCompression);
				}
				return;
			}
			if (base.isServer && this.m_ClientMoveCallback3D != null)
			{
				Vector3 vector = reader.ReadVector3();
				Vector3 vector2 = reader.ReadVector3();
				Quaternion quaternion = Quaternion.identity;
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					quaternion = NetworkTransform.UnserializeRotation3D(reader, this.syncRotationAxis, this.rotationSyncCompression);
				}
				if (!this.m_ClientMoveCallback3D(ref vector, ref vector2, ref quaternion))
				{
					return;
				}
				this.m_TargetSyncPosition = vector;
				this.m_TargetSyncVelocity = vector2;
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					this.m_TargetSyncRotation3D = quaternion;
				}
			}
			else
			{
				this.m_TargetSyncPosition = reader.ReadVector3();
				this.m_TargetSyncVelocity = reader.ReadVector3();
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					this.m_TargetSyncRotation3D = NetworkTransform.UnserializeRotation3D(reader, this.syncRotationAxis, this.rotationSyncCompression);
				}
			}
			if (this.syncSpin)
			{
				this.m_TargetSyncAngularVelocity3D = NetworkTransform.UnserializeSpin3D(reader, this.syncRotationAxis, this.rotationSyncCompression);
			}
			if (this.m_RigidBody3D == null)
			{
				return;
			}
			if (base.isServer && !base.isClient)
			{
				this.m_RigidBody3D.MovePosition(this.m_TargetSyncPosition);
				this.m_RigidBody3D.MoveRotation(this.m_TargetSyncRotation3D);
				this.m_RigidBody3D.velocity = this.m_TargetSyncVelocity;
				return;
			}
			if (this.GetNetworkSendInterval() == 0f)
			{
				this.m_RigidBody3D.MovePosition(this.m_TargetSyncPosition);
				this.m_RigidBody3D.velocity = this.m_TargetSyncVelocity;
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					this.m_RigidBody3D.MoveRotation(this.m_TargetSyncRotation3D);
				}
				if (this.syncSpin)
				{
					this.m_RigidBody3D.angularVelocity = this.m_TargetSyncAngularVelocity3D;
				}
				return;
			}
			float magnitude = (this.m_RigidBody3D.position - this.m_TargetSyncPosition).magnitude;
			if (magnitude > this.snapThreshold)
			{
				this.m_RigidBody3D.position = this.m_TargetSyncPosition;
				this.m_RigidBody3D.velocity = this.m_TargetSyncVelocity;
			}
			if (this.interpolateRotation == 0f && this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
			{
				this.m_RigidBody3D.rotation = this.m_TargetSyncRotation3D;
				if (this.syncSpin)
				{
					this.m_RigidBody3D.angularVelocity = this.m_TargetSyncAngularVelocity3D;
				}
			}
			if (this.m_InterpolateMovement == 0f)
			{
				this.m_RigidBody3D.position = this.m_TargetSyncPosition;
			}
			if (initialState && this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
			{
				this.m_RigidBody3D.rotation = this.m_TargetSyncRotation3D;
			}
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00014670 File Offset: 0x00012870
		private void UnserializeMode2D(NetworkReader reader, bool initialState)
		{
			if (base.hasAuthority)
			{
				reader.ReadVector2();
				reader.ReadVector2();
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					NetworkTransform.UnserializeRotation2D(reader, this.rotationSyncCompression);
				}
				if (this.syncSpin)
				{
					NetworkTransform.UnserializeSpin2D(reader, this.rotationSyncCompression);
				}
				return;
			}
			if (this.m_RigidBody2D == null)
			{
				return;
			}
			if (base.isServer && this.m_ClientMoveCallback2D != null)
			{
				Vector2 vector = reader.ReadVector2();
				Vector2 vector2 = reader.ReadVector2();
				float num = 0f;
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					num = NetworkTransform.UnserializeRotation2D(reader, this.rotationSyncCompression);
				}
				if (!this.m_ClientMoveCallback2D(ref vector, ref vector2, ref num))
				{
					return;
				}
				this.m_TargetSyncPosition = vector;
				this.m_TargetSyncVelocity = vector2;
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					this.m_TargetSyncRotation2D = num;
				}
			}
			else
			{
				this.m_TargetSyncPosition = reader.ReadVector2();
				this.m_TargetSyncVelocity = reader.ReadVector2();
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					this.m_TargetSyncRotation2D = NetworkTransform.UnserializeRotation2D(reader, this.rotationSyncCompression);
				}
			}
			if (this.syncSpin)
			{
				this.m_TargetSyncAngularVelocity2D = NetworkTransform.UnserializeSpin2D(reader, this.rotationSyncCompression);
			}
			if (base.isServer && !base.isClient)
			{
				base.transform.position = this.m_TargetSyncPosition;
				this.m_RigidBody2D.MoveRotation(this.m_TargetSyncRotation2D);
				this.m_RigidBody2D.velocity = this.m_TargetSyncVelocity;
				return;
			}
			if (this.GetNetworkSendInterval() == 0f)
			{
				base.transform.position = this.m_TargetSyncPosition;
				this.m_RigidBody2D.velocity = this.m_TargetSyncVelocity;
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					this.m_RigidBody2D.MoveRotation(this.m_TargetSyncRotation2D);
				}
				if (this.syncSpin)
				{
					this.m_RigidBody2D.angularVelocity = this.m_TargetSyncAngularVelocity2D;
				}
				return;
			}
			float magnitude = (this.m_RigidBody2D.position - this.m_TargetSyncPosition).magnitude;
			if (magnitude > this.snapThreshold)
			{
				this.m_RigidBody2D.position = this.m_TargetSyncPosition;
				this.m_RigidBody2D.velocity = this.m_TargetSyncVelocity;
			}
			if (this.interpolateRotation == 0f && this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
			{
				this.m_RigidBody2D.rotation = this.m_TargetSyncRotation2D;
				if (this.syncSpin)
				{
					this.m_RigidBody2D.angularVelocity = this.m_TargetSyncAngularVelocity2D;
				}
			}
			if (this.m_InterpolateMovement == 0f)
			{
				this.m_RigidBody2D.position = this.m_TargetSyncPosition;
			}
			if (initialState)
			{
				this.m_RigidBody2D.rotation = this.m_TargetSyncRotation2D;
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00014964 File Offset: 0x00012B64
		private void UnserializeModeCharacterController(NetworkReader reader, bool initialState)
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
				Quaternion quaternion = Quaternion.identity;
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					quaternion = NetworkTransform.UnserializeRotation3D(reader, this.syncRotationAxis, this.rotationSyncCompression);
				}
				if (this.m_CharacterController == null)
				{
					return;
				}
				Vector3 velocity = this.m_CharacterController.velocity;
				if (!this.m_ClientMoveCallback3D(ref vector, ref velocity, ref quaternion))
				{
					return;
				}
				this.m_TargetSyncPosition = vector;
				this.m_TargetSyncVelocity = velocity;
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
			if (this.m_CharacterController == null)
			{
				return;
			}
			Vector3 vector2 = this.m_TargetSyncPosition - base.transform.position;
			Vector3 vector3 = vector2 / this.GetNetworkSendInterval();
			this.m_FixedPosDiff = vector3 * Time.fixedDeltaTime;
			if (base.isServer && !base.isClient)
			{
				base.transform.position = this.m_TargetSyncPosition;
				base.transform.rotation = this.m_TargetSyncRotation3D;
				return;
			}
			if (this.GetNetworkSendInterval() == 0f)
			{
				base.transform.position = this.m_TargetSyncPosition;
				if (this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
				{
					base.transform.rotation = this.m_TargetSyncRotation3D;
				}
				return;
			}
			float magnitude = (base.transform.position - this.m_TargetSyncPosition).magnitude;
			if (magnitude > this.snapThreshold)
			{
				base.transform.position = this.m_TargetSyncPosition;
			}
			if (this.interpolateRotation == 0f && this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
			{
				base.transform.rotation = this.m_TargetSyncRotation3D;
			}
			if (this.m_InterpolateMovement == 0f)
			{
				base.transform.position = this.m_TargetSyncPosition;
			}
			if (initialState && this.syncRotationAxis != NetworkTransform.AxisSyncMode.None)
			{
				base.transform.rotation = this.m_TargetSyncRotation3D;
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00014BE0 File Offset: 0x00012DE0
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

		// Token: 0x06000403 RID: 1027 RVA: 0x00014C10 File Offset: 0x00012E10
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
			float num = (base.transform.position - this.m_PrevPosition).magnitude;
			if (num < this.movementTheshold)
			{
				num = Quaternion.Angle(this.m_PrevRotation, base.transform.rotation);
				if (num < this.movementTheshold)
				{
					return;
				}
			}
			base.SetDirtyBit(1U);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00014CA8 File Offset: 0x00012EA8
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
			switch (this.transformSyncMode)
			{
			case NetworkTransform.TransformSyncMode.SyncNone:
				return;
			case NetworkTransform.TransformSyncMode.SyncTransform:
				return;
			case NetworkTransform.TransformSyncMode.SyncRigidbody2D:
				this.InterpolateTransformMode2D();
				break;
			case NetworkTransform.TransformSyncMode.SyncRigidbody3D:
				this.InterpolateTransformMode3D();
				break;
			case NetworkTransform.TransformSyncMode.SyncCharacterController:
				this.InterpolateTransformModeCharacterController();
				break;
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00014D58 File Offset: 0x00012F58
		private void InterpolateTransformMode3D()
		{
			if (this.m_InterpolateMovement != 0f)
			{
				Vector3 vector = (this.m_TargetSyncPosition - this.m_RigidBody3D.position) * this.m_InterpolateMovement / this.GetNetworkSendInterval();
				this.m_RigidBody3D.velocity = vector;
			}
			if (this.interpolateRotation != 0f)
			{
				this.m_RigidBody3D.MoveRotation(Quaternion.Slerp(this.m_RigidBody3D.rotation, this.m_TargetSyncRotation3D, Time.fixedDeltaTime * this.interpolateRotation));
			}
			this.m_TargetSyncPosition += this.m_TargetSyncVelocity * Time.fixedDeltaTime * 0.1f;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00014E18 File Offset: 0x00013018
		private void InterpolateTransformModeCharacterController()
		{
			if (this.m_FixedPosDiff == Vector3.zero && this.m_TargetSyncRotation3D == base.transform.rotation)
			{
				return;
			}
			if (this.m_InterpolateMovement != 0f)
			{
				this.m_CharacterController.Move(this.m_FixedPosDiff * this.m_InterpolateMovement);
			}
			if (this.interpolateRotation != 0f)
			{
				base.transform.rotation = Quaternion.Slerp(base.transform.rotation, this.m_TargetSyncRotation3D, Time.fixedDeltaTime * this.interpolateRotation * 10f);
			}
			if (Time.time - this.m_LastClientSyncTime > this.GetNetworkSendInterval())
			{
				this.m_FixedPosDiff = Vector3.zero;
				Vector3 vector = this.m_TargetSyncPosition - base.transform.position;
				this.m_CharacterController.Move(vector);
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00014F0C File Offset: 0x0001310C
		private void InterpolateTransformMode2D()
		{
			if (this.m_InterpolateMovement != 0f)
			{
				Vector2 velocity = this.m_RigidBody2D.velocity;
				Vector2 vector = (this.m_TargetSyncPosition - this.m_RigidBody2D.position) * this.m_InterpolateMovement / this.GetNetworkSendInterval();
				if (!this.m_Grounded && vector.y < 0f)
				{
					vector.y = velocity.y;
				}
				this.m_RigidBody2D.velocity = vector;
			}
			if (this.interpolateRotation != 0f)
			{
				float num = this.m_RigidBody2D.rotation % 360f;
				if (num < 0f)
				{
					num += 360f;
				}
				Quaternion quaternion = Quaternion.Slerp(base.transform.rotation, Quaternion.Euler(0f, 0f, this.m_TargetSyncRotation2D), Time.fixedDeltaTime * this.interpolateRotation / this.GetNetworkSendInterval());
				this.m_RigidBody2D.MoveRotation(quaternion.eulerAngles.z);
				this.m_TargetSyncRotation2D += this.m_TargetSyncAngularVelocity2D * Time.fixedDeltaTime * 0.1f;
			}
			this.m_TargetSyncPosition += this.m_TargetSyncVelocity * Time.fixedDeltaTime * 0.1f;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00015070 File Offset: 0x00013270
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

		// Token: 0x06000409 RID: 1033 RVA: 0x000150C8 File Offset: 0x000132C8
		private bool HasMoved()
		{
			float num;
			if (this.m_RigidBody3D != null)
			{
				num = (this.m_RigidBody3D.position - this.m_PrevPosition).magnitude;
			}
			else if (this.m_RigidBody2D != null)
			{
				num = (this.m_RigidBody2D.position - this.m_PrevPosition).magnitude;
			}
			else
			{
				num = (base.transform.position - this.m_PrevPosition).magnitude;
			}
			if (num > 1E-05f)
			{
				return true;
			}
			if (this.m_RigidBody3D != null)
			{
				num = Quaternion.Angle(this.m_RigidBody3D.rotation, this.m_PrevRotation);
			}
			else if (this.m_RigidBody2D != null)
			{
				num = Math.Abs(this.m_RigidBody2D.rotation - this.m_PrevRotation2D);
			}
			else
			{
				num = Quaternion.Angle(base.transform.rotation, this.m_PrevRotation);
			}
			if (num > 1E-05f)
			{
				return true;
			}
			if (this.m_RigidBody3D != null)
			{
				num = Mathf.Abs(this.m_RigidBody3D.velocity.sqrMagnitude - this.m_PrevVelocity);
			}
			else if (this.m_RigidBody2D != null)
			{
				num = Mathf.Abs(this.m_RigidBody2D.velocity.sqrMagnitude - this.m_PrevVelocity);
			}
			return num > 1E-05f;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0001526C File Offset: 0x0001346C
		[Client]
		private void SendTransform()
		{
			if (!this.HasMoved() || ClientScene.readyConnection == null)
			{
				return;
			}
			this.m_LocalTransformWriter.StartMessage(6);
			this.m_LocalTransformWriter.Write(base.netId);
			switch (this.transformSyncMode)
			{
			case NetworkTransform.TransformSyncMode.SyncNone:
				return;
			case NetworkTransform.TransformSyncMode.SyncTransform:
				this.SerializeModeTransform(this.m_LocalTransformWriter);
				break;
			case NetworkTransform.TransformSyncMode.SyncRigidbody2D:
				this.SerializeMode2D(this.m_LocalTransformWriter);
				break;
			case NetworkTransform.TransformSyncMode.SyncRigidbody3D:
				this.SerializeMode3D(this.m_LocalTransformWriter);
				break;
			case NetworkTransform.TransformSyncMode.SyncCharacterController:
				this.SerializeModeCharacterController(this.m_LocalTransformWriter);
				break;
			}
			if (this.m_RigidBody3D != null)
			{
				this.m_PrevPosition = this.m_RigidBody3D.position;
				this.m_PrevRotation = this.m_RigidBody3D.rotation;
				this.m_PrevVelocity = this.m_RigidBody3D.velocity.sqrMagnitude;
			}
			else if (this.m_RigidBody2D != null)
			{
				this.m_PrevPosition = this.m_RigidBody2D.position;
				this.m_PrevRotation2D = this.m_RigidBody2D.rotation;
				this.m_PrevVelocity = this.m_RigidBody2D.velocity.sqrMagnitude;
			}
			else
			{
				this.m_PrevPosition = base.transform.position;
				this.m_PrevRotation = base.transform.rotation;
			}
			this.m_LocalTransformWriter.FinishMessage();
			ClientScene.readyConnection.SendWriter(this.m_LocalTransformWriter, this.GetNetworkChannel());
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00015404 File Offset: 0x00013604
		public static void HandleTransform(NetworkMessage netMsg)
		{
			NetworkInstanceId networkInstanceId = netMsg.reader.ReadNetworkId();
			GameObject gameObject = NetworkServer.FindLocalObject(networkInstanceId);
			if (gameObject == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("HandleTransform no gameObject");
				}
				return;
			}
			NetworkTransform component = gameObject.GetComponent<NetworkTransform>();
			if (component == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("HandleTransform null target");
				}
				return;
			}
			if (!component.localPlayerAuthority)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("HandleTransform no localPlayerAuthority");
				}
				return;
			}
			if (netMsg.conn.clientOwnedObjects == null)
			{
				if (LogFilter.logError)
				{
					Debug.LogError("HandleTransform object not owned by connection");
				}
				return;
			}
			if (netMsg.conn.clientOwnedObjects.Contains(networkInstanceId))
			{
				switch (component.transformSyncMode)
				{
				case NetworkTransform.TransformSyncMode.SyncNone:
					return;
				case NetworkTransform.TransformSyncMode.SyncTransform:
					component.UnserializeModeTransform(netMsg.reader, false);
					break;
				case NetworkTransform.TransformSyncMode.SyncRigidbody2D:
					component.UnserializeMode2D(netMsg.reader, false);
					break;
				case NetworkTransform.TransformSyncMode.SyncRigidbody3D:
					component.UnserializeMode3D(netMsg.reader, false);
					break;
				case NetworkTransform.TransformSyncMode.SyncCharacterController:
					component.UnserializeModeCharacterController(netMsg.reader, false);
					break;
				}
				component.m_LastClientSyncTime = Time.time;
				return;
			}
			if (LogFilter.logWarn)
			{
				Debug.LogWarning("HandleTransform netId:" + networkInstanceId + " is not for a valid player");
			}
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00015568 File Offset: 0x00013768
		private static void WriteAngle(NetworkWriter writer, float angle, NetworkTransform.CompressionSyncMode compression)
		{
			switch (compression)
			{
			case NetworkTransform.CompressionSyncMode.None:
				writer.Write(angle);
				break;
			case NetworkTransform.CompressionSyncMode.Low:
				writer.Write((short)angle);
				break;
			case NetworkTransform.CompressionSyncMode.High:
				writer.Write((short)angle);
				break;
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x000155B4 File Offset: 0x000137B4
		private static float ReadAngle(NetworkReader reader, NetworkTransform.CompressionSyncMode compression)
		{
			switch (compression)
			{
			case NetworkTransform.CompressionSyncMode.None:
				return reader.ReadSingle();
			case NetworkTransform.CompressionSyncMode.Low:
				return (float)reader.ReadInt16();
			case NetworkTransform.CompressionSyncMode.High:
				return (float)reader.ReadInt16();
			default:
				return 0f;
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000155F8 File Offset: 0x000137F8
		public static void SerializeVelocity3D(NetworkWriter writer, Vector3 velocity, NetworkTransform.CompressionSyncMode compression)
		{
			writer.Write(velocity);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00015604 File Offset: 0x00013804
		public static void SerializeVelocity2D(NetworkWriter writer, Vector2 velocity, NetworkTransform.CompressionSyncMode compression)
		{
			writer.Write(velocity);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00015610 File Offset: 0x00013810
		public static void SerializeRotation3D(NetworkWriter writer, Quaternion rot, NetworkTransform.AxisSyncMode mode, NetworkTransform.CompressionSyncMode compression)
		{
			switch (mode)
			{
			case NetworkTransform.AxisSyncMode.AxisX:
				NetworkTransform.WriteAngle(writer, rot.eulerAngles.x, compression);
				break;
			case NetworkTransform.AxisSyncMode.AxisY:
				NetworkTransform.WriteAngle(writer, rot.eulerAngles.y, compression);
				break;
			case NetworkTransform.AxisSyncMode.AxisZ:
				NetworkTransform.WriteAngle(writer, rot.eulerAngles.z, compression);
				break;
			case NetworkTransform.AxisSyncMode.AxisXY:
				NetworkTransform.WriteAngle(writer, rot.eulerAngles.x, compression);
				NetworkTransform.WriteAngle(writer, rot.eulerAngles.y, compression);
				break;
			case NetworkTransform.AxisSyncMode.AxisXZ:
				NetworkTransform.WriteAngle(writer, rot.eulerAngles.x, compression);
				NetworkTransform.WriteAngle(writer, rot.eulerAngles.z, compression);
				break;
			case NetworkTransform.AxisSyncMode.AxisYZ:
				NetworkTransform.WriteAngle(writer, rot.eulerAngles.y, compression);
				NetworkTransform.WriteAngle(writer, rot.eulerAngles.z, compression);
				break;
			case NetworkTransform.AxisSyncMode.AxisXYZ:
				NetworkTransform.WriteAngle(writer, rot.eulerAngles.x, compression);
				NetworkTransform.WriteAngle(writer, rot.eulerAngles.y, compression);
				NetworkTransform.WriteAngle(writer, rot.eulerAngles.z, compression);
				break;
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00015784 File Offset: 0x00013984
		public static void SerializeRotation2D(NetworkWriter writer, float rot, NetworkTransform.CompressionSyncMode compression)
		{
			NetworkTransform.WriteAngle(writer, rot, compression);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00015790 File Offset: 0x00013990
		public static void SerializeSpin3D(NetworkWriter writer, Vector3 angularVelocity, NetworkTransform.AxisSyncMode mode, NetworkTransform.CompressionSyncMode compression)
		{
			switch (mode)
			{
			case NetworkTransform.AxisSyncMode.AxisX:
				NetworkTransform.WriteAngle(writer, angularVelocity.x, compression);
				break;
			case NetworkTransform.AxisSyncMode.AxisY:
				NetworkTransform.WriteAngle(writer, angularVelocity.y, compression);
				break;
			case NetworkTransform.AxisSyncMode.AxisZ:
				NetworkTransform.WriteAngle(writer, angularVelocity.z, compression);
				break;
			case NetworkTransform.AxisSyncMode.AxisXY:
				NetworkTransform.WriteAngle(writer, angularVelocity.x, compression);
				NetworkTransform.WriteAngle(writer, angularVelocity.y, compression);
				break;
			case NetworkTransform.AxisSyncMode.AxisXZ:
				NetworkTransform.WriteAngle(writer, angularVelocity.x, compression);
				NetworkTransform.WriteAngle(writer, angularVelocity.z, compression);
				break;
			case NetworkTransform.AxisSyncMode.AxisYZ:
				NetworkTransform.WriteAngle(writer, angularVelocity.y, compression);
				NetworkTransform.WriteAngle(writer, angularVelocity.z, compression);
				break;
			case NetworkTransform.AxisSyncMode.AxisXYZ:
				NetworkTransform.WriteAngle(writer, angularVelocity.x, compression);
				NetworkTransform.WriteAngle(writer, angularVelocity.y, compression);
				NetworkTransform.WriteAngle(writer, angularVelocity.z, compression);
				break;
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0001589C File Offset: 0x00013A9C
		public static void SerializeSpin2D(NetworkWriter writer, float angularVelocity, NetworkTransform.CompressionSyncMode compression)
		{
			NetworkTransform.WriteAngle(writer, angularVelocity, compression);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000158A8 File Offset: 0x00013AA8
		public static Vector3 UnserializeVelocity3D(NetworkReader reader, NetworkTransform.CompressionSyncMode compression)
		{
			return reader.ReadVector3();
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000158B0 File Offset: 0x00013AB0
		public static Vector3 UnserializeVelocity2D(NetworkReader reader, NetworkTransform.CompressionSyncMode compression)
		{
			return reader.ReadVector2();
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000158C0 File Offset: 0x00013AC0
		public static Quaternion UnserializeRotation3D(NetworkReader reader, NetworkTransform.AxisSyncMode mode, NetworkTransform.CompressionSyncMode compression)
		{
			Quaternion identity = Quaternion.identity;
			Vector3 zero = Vector3.zero;
			switch (mode)
			{
			case NetworkTransform.AxisSyncMode.AxisX:
				zero.Set(NetworkTransform.ReadAngle(reader, compression), 0f, 0f);
				identity.eulerAngles = zero;
				break;
			case NetworkTransform.AxisSyncMode.AxisY:
				zero.Set(0f, NetworkTransform.ReadAngle(reader, compression), 0f);
				identity.eulerAngles = zero;
				break;
			case NetworkTransform.AxisSyncMode.AxisZ:
				zero.Set(0f, 0f, NetworkTransform.ReadAngle(reader, compression));
				identity.eulerAngles = zero;
				break;
			case NetworkTransform.AxisSyncMode.AxisXY:
				zero.Set(NetworkTransform.ReadAngle(reader, compression), NetworkTransform.ReadAngle(reader, compression), 0f);
				identity.eulerAngles = zero;
				break;
			case NetworkTransform.AxisSyncMode.AxisXZ:
				zero.Set(NetworkTransform.ReadAngle(reader, compression), 0f, NetworkTransform.ReadAngle(reader, compression));
				identity.eulerAngles = zero;
				break;
			case NetworkTransform.AxisSyncMode.AxisYZ:
				zero.Set(0f, NetworkTransform.ReadAngle(reader, compression), NetworkTransform.ReadAngle(reader, compression));
				identity.eulerAngles = zero;
				break;
			case NetworkTransform.AxisSyncMode.AxisXYZ:
				zero.Set(NetworkTransform.ReadAngle(reader, compression), NetworkTransform.ReadAngle(reader, compression), NetworkTransform.ReadAngle(reader, compression));
				identity.eulerAngles = zero;
				break;
			}
			return identity;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00015A1C File Offset: 0x00013C1C
		public static float UnserializeRotation2D(NetworkReader reader, NetworkTransform.CompressionSyncMode compression)
		{
			return NetworkTransform.ReadAngle(reader, compression);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00015A28 File Offset: 0x00013C28
		public static Vector3 UnserializeSpin3D(NetworkReader reader, NetworkTransform.AxisSyncMode mode, NetworkTransform.CompressionSyncMode compression)
		{
			Vector3 zero = Vector3.zero;
			switch (mode)
			{
			case NetworkTransform.AxisSyncMode.AxisX:
				zero.Set(NetworkTransform.ReadAngle(reader, compression), 0f, 0f);
				break;
			case NetworkTransform.AxisSyncMode.AxisY:
				zero.Set(0f, NetworkTransform.ReadAngle(reader, compression), 0f);
				break;
			case NetworkTransform.AxisSyncMode.AxisZ:
				zero.Set(0f, 0f, NetworkTransform.ReadAngle(reader, compression));
				break;
			case NetworkTransform.AxisSyncMode.AxisXY:
				zero.Set(NetworkTransform.ReadAngle(reader, compression), NetworkTransform.ReadAngle(reader, compression), 0f);
				break;
			case NetworkTransform.AxisSyncMode.AxisXZ:
				zero.Set(NetworkTransform.ReadAngle(reader, compression), 0f, NetworkTransform.ReadAngle(reader, compression));
				break;
			case NetworkTransform.AxisSyncMode.AxisYZ:
				zero.Set(0f, NetworkTransform.ReadAngle(reader, compression), NetworkTransform.ReadAngle(reader, compression));
				break;
			case NetworkTransform.AxisSyncMode.AxisXYZ:
				zero.Set(NetworkTransform.ReadAngle(reader, compression), NetworkTransform.ReadAngle(reader, compression), NetworkTransform.ReadAngle(reader, compression));
				break;
			}
			return zero;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00015B44 File Offset: 0x00013D44
		public static float UnserializeSpin2D(NetworkReader reader, NetworkTransform.CompressionSyncMode compression)
		{
			return NetworkTransform.ReadAngle(reader, compression);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00015B50 File Offset: 0x00013D50
		public override int GetNetworkChannel()
		{
			return 1;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00015B54 File Offset: 0x00013D54
		public override float GetNetworkSendInterval()
		{
			return this.m_SendInterval;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00015B5C File Offset: 0x00013D5C
		public override void OnStartAuthority()
		{
			this.m_LastClientSyncTime = 0f;
		}

		// Token: 0x04000195 RID: 405
		private const float k_LocalMovementThreshold = 1E-05f;

		// Token: 0x04000196 RID: 406
		private const float k_LocalRotationThreshold = 1E-05f;

		// Token: 0x04000197 RID: 407
		private const float k_LocalVelocityThreshold = 1E-05f;

		// Token: 0x04000198 RID: 408
		private const float k_MoveAheadRatio = 0.1f;

		// Token: 0x04000199 RID: 409
		[SerializeField]
		private NetworkTransform.TransformSyncMode m_TransformSyncMode;

		// Token: 0x0400019A RID: 410
		[SerializeField]
		private float m_SendInterval = 0.1f;

		// Token: 0x0400019B RID: 411
		[SerializeField]
		private NetworkTransform.AxisSyncMode m_SyncRotationAxis = NetworkTransform.AxisSyncMode.AxisXYZ;

		// Token: 0x0400019C RID: 412
		[SerializeField]
		private NetworkTransform.CompressionSyncMode m_RotationSyncCompression;

		// Token: 0x0400019D RID: 413
		[SerializeField]
		private bool m_SyncSpin;

		// Token: 0x0400019E RID: 414
		[SerializeField]
		private float m_MovementTheshold = 0.001f;

		// Token: 0x0400019F RID: 415
		[SerializeField]
		private float m_SnapThreshold = 5f;

		// Token: 0x040001A0 RID: 416
		[SerializeField]
		private float m_InterpolateRotation = 1f;

		// Token: 0x040001A1 RID: 417
		[SerializeField]
		private float m_InterpolateMovement = 1f;

		// Token: 0x040001A2 RID: 418
		[SerializeField]
		private NetworkTransform.ClientMoveCallback3D m_ClientMoveCallback3D;

		// Token: 0x040001A3 RID: 419
		[SerializeField]
		private NetworkTransform.ClientMoveCallback2D m_ClientMoveCallback2D;

		// Token: 0x040001A4 RID: 420
		private Rigidbody m_RigidBody3D;

		// Token: 0x040001A5 RID: 421
		private Rigidbody2D m_RigidBody2D;

		// Token: 0x040001A6 RID: 422
		private CharacterController m_CharacterController;

		// Token: 0x040001A7 RID: 423
		private bool m_Grounded = true;

		// Token: 0x040001A8 RID: 424
		private Vector3 m_TargetSyncPosition;

		// Token: 0x040001A9 RID: 425
		private Vector3 m_TargetSyncVelocity;

		// Token: 0x040001AA RID: 426
		private Vector3 m_FixedPosDiff;

		// Token: 0x040001AB RID: 427
		private Quaternion m_TargetSyncRotation3D;

		// Token: 0x040001AC RID: 428
		private Vector3 m_TargetSyncAngularVelocity3D;

		// Token: 0x040001AD RID: 429
		private float m_TargetSyncRotation2D;

		// Token: 0x040001AE RID: 430
		private float m_TargetSyncAngularVelocity2D;

		// Token: 0x040001AF RID: 431
		private float m_LastClientSyncTime;

		// Token: 0x040001B0 RID: 432
		private float m_LastClientSendTime;

		// Token: 0x040001B1 RID: 433
		private Vector3 m_PrevPosition;

		// Token: 0x040001B2 RID: 434
		private Quaternion m_PrevRotation;

		// Token: 0x040001B3 RID: 435
		private float m_PrevRotation2D;

		// Token: 0x040001B4 RID: 436
		private float m_PrevVelocity;

		// Token: 0x040001B5 RID: 437
		private NetworkWriter m_LocalTransformWriter;

		// Token: 0x0200004F RID: 79
		public enum TransformSyncMode
		{
			// Token: 0x040001B7 RID: 439
			SyncNone,
			// Token: 0x040001B8 RID: 440
			SyncTransform,
			// Token: 0x040001B9 RID: 441
			SyncRigidbody2D,
			// Token: 0x040001BA RID: 442
			SyncRigidbody3D,
			// Token: 0x040001BB RID: 443
			SyncCharacterController
		}

		// Token: 0x02000050 RID: 80
		public enum AxisSyncMode
		{
			// Token: 0x040001BD RID: 445
			None,
			// Token: 0x040001BE RID: 446
			AxisX,
			// Token: 0x040001BF RID: 447
			AxisY,
			// Token: 0x040001C0 RID: 448
			AxisZ,
			// Token: 0x040001C1 RID: 449
			AxisXY,
			// Token: 0x040001C2 RID: 450
			AxisXZ,
			// Token: 0x040001C3 RID: 451
			AxisYZ,
			// Token: 0x040001C4 RID: 452
			AxisXYZ
		}

		// Token: 0x02000051 RID: 81
		public enum CompressionSyncMode
		{
			// Token: 0x040001C6 RID: 454
			None,
			// Token: 0x040001C7 RID: 455
			Low,
			// Token: 0x040001C8 RID: 456
			High
		}

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x060004A1 RID: 1185
		public delegate bool ClientMoveCallback3D(ref Vector3 position, ref Vector3 velocity, ref Quaternion rotation);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x060004A5 RID: 1189
		public delegate bool ClientMoveCallback2D(ref Vector2 position, ref Vector2 velocity, ref float rotation);
	}
}
