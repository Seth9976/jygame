using System;
using System.Text;

namespace UnityEngine.Networking
{
	// Token: 0x02000048 RID: 72
	public class NetworkReader
	{
		// Token: 0x060002F8 RID: 760 RVA: 0x0000ED88 File Offset: 0x0000CF88
		public NetworkReader()
		{
			this.m_buf = new NetBuffer();
			NetworkReader.Initialize();
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000EDA0 File Offset: 0x0000CFA0
		public NetworkReader(NetworkWriter writer)
		{
			this.m_buf = new NetBuffer(writer.AsArray());
			NetworkReader.Initialize();
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		public NetworkReader(byte[] buffer)
		{
			this.m_buf = new NetBuffer(buffer);
			NetworkReader.Initialize();
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000EDDC File Offset: 0x0000CFDC
		private static void Initialize()
		{
			if (NetworkReader.s_Encoding == null)
			{
				NetworkReader.s_StringReaderBuffer = new byte[1024];
				NetworkReader.s_Encoding = new UTF8Encoding();
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0000EE04 File Offset: 0x0000D004
		public uint Position
		{
			get
			{
				return this.m_buf.Position;
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000EE14 File Offset: 0x0000D014
		public void SeekZero()
		{
			this.m_buf.SeekZero();
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000EE24 File Offset: 0x0000D024
		internal void Replace(byte[] buffer)
		{
			this.m_buf.Replace(buffer);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000EE34 File Offset: 0x0000D034
		public uint ReadPackedUInt32()
		{
			byte b = this.ReadByte();
			if (b < 241)
			{
				return (uint)b;
			}
			byte b2 = this.ReadByte();
			if (b >= 241 && b <= 248)
			{
				return 240U + 256U * (uint)(b - 241) + (uint)b2;
			}
			byte b3 = this.ReadByte();
			if (b == 249)
			{
				return 2288U + 256U * (uint)b2 + (uint)b3;
			}
			byte b4 = this.ReadByte();
			if (b == 250)
			{
				return (uint)((int)b2 + ((int)b3 << 8) + ((int)b4 << 16));
			}
			byte b5 = this.ReadByte();
			if (b >= 251)
			{
				return (uint)((int)b2 + ((int)b3 << 8) + ((int)b4 << 16) + ((int)b5 << 24));
			}
			throw new IndexOutOfRangeException("ReadPackedUInt32() failure: " + b);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000EF00 File Offset: 0x0000D100
		public ulong ReadPackedUInt64()
		{
			byte b = this.ReadByte();
			if (b < 241)
			{
				return (ulong)b;
			}
			byte b2 = this.ReadByte();
			if (b >= 241 && b <= 248)
			{
				return 240UL + 256UL * ((ulong)b - 241UL) + (ulong)b2;
			}
			byte b3 = this.ReadByte();
			if (b == 249)
			{
				return 2288UL + 256UL * (ulong)b2 + (ulong)b3;
			}
			byte b4 = this.ReadByte();
			if (b == 250)
			{
				return (ulong)b2 + ((ulong)b3 << 8) + ((ulong)b4 << 16);
			}
			byte b5 = this.ReadByte();
			if (b == 251)
			{
				return (ulong)b2 + ((ulong)b3 << 8) + ((ulong)b4 << 16) + ((ulong)b5 << 24);
			}
			byte b6 = this.ReadByte();
			if (b == 252)
			{
				return (ulong)b2 + ((ulong)b3 << 8) + ((ulong)b4 << 16) + ((ulong)b5 << 24) + ((ulong)b6 << 32);
			}
			byte b7 = this.ReadByte();
			if (b == 253)
			{
				return (ulong)b2 + ((ulong)b3 << 8) + ((ulong)b4 << 16) + ((ulong)b5 << 24) + ((ulong)b6 << 32) + ((ulong)b7 << 40);
			}
			byte b8 = this.ReadByte();
			if (b == 254)
			{
				return (ulong)b2 + ((ulong)b3 << 8) + ((ulong)b4 << 16) + ((ulong)b5 << 24) + ((ulong)b6 << 32) + ((ulong)b7 << 40) + ((ulong)b8 << 48);
			}
			byte b9 = this.ReadByte();
			if (b == 255)
			{
				return (ulong)b2 + ((ulong)b3 << 8) + ((ulong)b4 << 16) + ((ulong)b5 << 24) + ((ulong)b6 << 32) + ((ulong)b7 << 40) + ((ulong)b8 << 48) + ((ulong)b9 << 56);
			}
			throw new IndexOutOfRangeException("ReadPackedUInt64() failure: " + b);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000F0C4 File Offset: 0x0000D2C4
		public NetworkInstanceId ReadNetworkId()
		{
			return new NetworkInstanceId(this.ReadPackedUInt32());
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000F0D4 File Offset: 0x0000D2D4
		public NetworkSceneId ReadSceneId()
		{
			return new NetworkSceneId(this.ReadPackedUInt32());
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000F0E4 File Offset: 0x0000D2E4
		public byte ReadByte()
		{
			return this.m_buf.ReadByte();
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000F0F4 File Offset: 0x0000D2F4
		public sbyte ReadSByte()
		{
			return (sbyte)this.m_buf.ReadByte();
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000F104 File Offset: 0x0000D304
		public short ReadInt16()
		{
			ushort num = 0;
			num |= (ushort)this.m_buf.ReadByte();
			num |= (ushort)(this.m_buf.ReadByte() << 8);
			return (short)num;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000F138 File Offset: 0x0000D338
		public ushort ReadUInt16()
		{
			ushort num = 0;
			num |= (ushort)this.m_buf.ReadByte();
			return num | (ushort)(this.m_buf.ReadByte() << 8);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000F16C File Offset: 0x0000D36C
		public int ReadInt32()
		{
			uint num = 0U;
			num |= (uint)this.m_buf.ReadByte();
			num |= (uint)((uint)this.m_buf.ReadByte() << 8);
			num |= (uint)((uint)this.m_buf.ReadByte() << 16);
			return (int)(num | (uint)((uint)this.m_buf.ReadByte() << 24));
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000F1BC File Offset: 0x0000D3BC
		public uint ReadUInt32()
		{
			uint num = 0U;
			num |= (uint)this.m_buf.ReadByte();
			num |= (uint)((uint)this.m_buf.ReadByte() << 8);
			num |= (uint)((uint)this.m_buf.ReadByte() << 16);
			return num | (uint)((uint)this.m_buf.ReadByte() << 24);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000F20C File Offset: 0x0000D40C
		public long ReadInt64()
		{
			ulong num = 0UL;
			ulong num2 = (ulong)this.m_buf.ReadByte();
			num |= num2;
			num2 = (ulong)this.m_buf.ReadByte() << 8;
			num |= num2;
			num2 = (ulong)this.m_buf.ReadByte() << 16;
			num |= num2;
			num2 = (ulong)this.m_buf.ReadByte() << 24;
			num |= num2;
			num2 = (ulong)this.m_buf.ReadByte() << 32;
			num |= num2;
			num2 = (ulong)this.m_buf.ReadByte() << 40;
			num |= num2;
			num2 = (ulong)this.m_buf.ReadByte() << 48;
			num |= num2;
			num2 = (ulong)this.m_buf.ReadByte() << 56;
			return (long)(num | num2);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000F2BC File Offset: 0x0000D4BC
		public ulong ReadUInt64()
		{
			ulong num = 0UL;
			ulong num2 = (ulong)this.m_buf.ReadByte();
			num |= num2;
			num2 = (ulong)this.m_buf.ReadByte() << 8;
			num |= num2;
			num2 = (ulong)this.m_buf.ReadByte() << 16;
			num |= num2;
			num2 = (ulong)this.m_buf.ReadByte() << 24;
			num |= num2;
			num2 = (ulong)this.m_buf.ReadByte() << 32;
			num |= num2;
			num2 = (ulong)this.m_buf.ReadByte() << 40;
			num |= num2;
			num2 = (ulong)this.m_buf.ReadByte() << 48;
			num |= num2;
			num2 = (ulong)this.m_buf.ReadByte() << 56;
			return num | num2;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000F36C File Offset: 0x0000D56C
		public float ReadSingle()
		{
			uint num = this.ReadUInt32();
			return FloatConversion.ToSingle(num);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000F388 File Offset: 0x0000D588
		public double ReadDouble()
		{
			ulong num = this.ReadUInt64();
			return FloatConversion.ToDouble(num);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000F3A4 File Offset: 0x0000D5A4
		public string ReadString()
		{
			ushort num = this.ReadUInt16();
			if (num == 0)
			{
				return string.Empty;
			}
			if (num >= 32768)
			{
				throw new IndexOutOfRangeException("ReadString() too long: " + num);
			}
			while ((int)num > NetworkReader.s_StringReaderBuffer.Length)
			{
				NetworkReader.s_StringReaderBuffer = new byte[NetworkReader.s_StringReaderBuffer.Length * 2];
			}
			this.m_buf.ReadBytes(NetworkReader.s_StringReaderBuffer, (uint)num);
			char[] chars = NetworkReader.s_Encoding.GetChars(NetworkReader.s_StringReaderBuffer, 0, (int)num);
			return new string(chars);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000F434 File Offset: 0x0000D634
		public char ReadChar()
		{
			return (char)this.m_buf.ReadByte();
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000F444 File Offset: 0x0000D644
		public bool ReadBoolean()
		{
			int num = (int)this.m_buf.ReadByte();
			return num == 1;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000F464 File Offset: 0x0000D664
		public byte[] ReadBytes(int count)
		{
			if (count < 0)
			{
				throw new IndexOutOfRangeException("NetworkReader ReadBytes " + count);
			}
			byte[] array = new byte[count];
			this.m_buf.ReadBytes(array, (uint)count);
			return array;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000F4A4 File Offset: 0x0000D6A4
		public byte[] ReadBytesAndSize()
		{
			ushort num = this.ReadUInt16();
			if (num == 0)
			{
				return null;
			}
			return this.ReadBytes((int)num);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
		public Vector2 ReadVector2()
		{
			return new Vector2(this.ReadSingle(), this.ReadSingle());
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000F4DC File Offset: 0x0000D6DC
		public Vector3 ReadVector3()
		{
			return new Vector3(this.ReadSingle(), this.ReadSingle(), this.ReadSingle());
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000F500 File Offset: 0x0000D700
		public Vector4 ReadVector4()
		{
			return new Vector4(this.ReadSingle(), this.ReadSingle(), this.ReadSingle(), this.ReadSingle());
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000F52C File Offset: 0x0000D72C
		public Color ReadColor()
		{
			return new Color(this.ReadSingle(), this.ReadSingle(), this.ReadSingle(), this.ReadSingle());
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000F558 File Offset: 0x0000D758
		public Color32 ReadColor32()
		{
			return new Color32(this.ReadByte(), this.ReadByte(), this.ReadByte(), this.ReadByte());
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000F584 File Offset: 0x0000D784
		public Quaternion ReadQuaternion()
		{
			return new Quaternion(this.ReadSingle(), this.ReadSingle(), this.ReadSingle(), this.ReadSingle());
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000F5B0 File Offset: 0x0000D7B0
		public Rect ReadRect()
		{
			return new Rect(this.ReadSingle(), this.ReadSingle(), this.ReadSingle(), this.ReadSingle());
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000F5DC File Offset: 0x0000D7DC
		public Plane ReadPlane()
		{
			return new Plane(this.ReadVector3(), this.ReadSingle());
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000F5F0 File Offset: 0x0000D7F0
		public Ray ReadRay()
		{
			return new Ray(this.ReadVector3(), this.ReadVector3());
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000F604 File Offset: 0x0000D804
		public Matrix4x4 ReadMatrix4x4()
		{
			return new Matrix4x4
			{
				m00 = this.ReadSingle(),
				m01 = this.ReadSingle(),
				m02 = this.ReadSingle(),
				m03 = this.ReadSingle(),
				m10 = this.ReadSingle(),
				m11 = this.ReadSingle(),
				m12 = this.ReadSingle(),
				m13 = this.ReadSingle(),
				m20 = this.ReadSingle(),
				m21 = this.ReadSingle(),
				m22 = this.ReadSingle(),
				m23 = this.ReadSingle(),
				m30 = this.ReadSingle(),
				m31 = this.ReadSingle(),
				m32 = this.ReadSingle(),
				m33 = this.ReadSingle()
			};
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000F6EC File Offset: 0x0000D8EC
		public NetworkHash128 ReadNetworkHash128()
		{
			NetworkHash128 networkHash;
			networkHash.i0 = this.ReadByte();
			networkHash.i1 = this.ReadByte();
			networkHash.i2 = this.ReadByte();
			networkHash.i3 = this.ReadByte();
			networkHash.i4 = this.ReadByte();
			networkHash.i5 = this.ReadByte();
			networkHash.i6 = this.ReadByte();
			networkHash.i7 = this.ReadByte();
			networkHash.i8 = this.ReadByte();
			networkHash.i9 = this.ReadByte();
			networkHash.i10 = this.ReadByte();
			networkHash.i11 = this.ReadByte();
			networkHash.i12 = this.ReadByte();
			networkHash.i13 = this.ReadByte();
			networkHash.i14 = this.ReadByte();
			networkHash.i15 = this.ReadByte();
			return networkHash;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000F7CC File Offset: 0x0000D9CC
		public Transform ReadTransform()
		{
			NetworkInstanceId networkInstanceId = this.ReadNetworkId();
			if (networkInstanceId.IsEmpty())
			{
				return null;
			}
			GameObject gameObject = ClientScene.FindLocalObject(networkInstanceId);
			if (gameObject == null)
			{
				if (LogFilter.logDebug)
				{
					Debug.Log("ReadTransform netId:" + networkInstanceId);
				}
				return null;
			}
			return gameObject.transform;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000F828 File Offset: 0x0000DA28
		public GameObject ReadGameObject()
		{
			NetworkInstanceId networkInstanceId = this.ReadNetworkId();
			if (networkInstanceId.IsEmpty())
			{
				return null;
			}
			GameObject gameObject;
			if (NetworkServer.active)
			{
				gameObject = NetworkServer.FindLocalObject(networkInstanceId);
			}
			else
			{
				gameObject = ClientScene.FindLocalObject(networkInstanceId);
			}
			if (gameObject == null && LogFilter.logDebug)
			{
				Debug.Log("ReadGameObject netId:" + networkInstanceId + "go: null");
			}
			return gameObject;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000F898 File Offset: 0x0000DA98
		public NetworkIdentity ReadNetworkIdentity()
		{
			NetworkInstanceId networkInstanceId = this.ReadNetworkId();
			if (networkInstanceId.IsEmpty())
			{
				return null;
			}
			GameObject gameObject;
			if (NetworkServer.active)
			{
				gameObject = NetworkServer.FindLocalObject(networkInstanceId);
			}
			else
			{
				gameObject = ClientScene.FindLocalObject(networkInstanceId);
			}
			if (gameObject == null)
			{
				if (LogFilter.logDebug)
				{
					Debug.Log("ReadNetworkIdentity netId:" + networkInstanceId + "go: null");
				}
				return null;
			}
			return gameObject.GetComponent<NetworkIdentity>();
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000F910 File Offset: 0x0000DB10
		public override string ToString()
		{
			return this.m_buf.ToString();
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000F920 File Offset: 0x0000DB20
		public TMsg ReadMessage<TMsg>() where TMsg : MessageBase, new()
		{
			TMsg tmsg = new TMsg();
			tmsg.Deserialize(this);
			return tmsg;
		}

		// Token: 0x04000160 RID: 352
		private const int k_MaxStringLength = 32768;

		// Token: 0x04000161 RID: 353
		private const int k_InitialStringBufferSize = 1024;

		// Token: 0x04000162 RID: 354
		private NetBuffer m_buf;

		// Token: 0x04000163 RID: 355
		private static byte[] s_StringReaderBuffer;

		// Token: 0x04000164 RID: 356
		private static Encoding s_Encoding;
	}
}
