using System;
using System.Text;

namespace UnityEngine.Networking
{
	// Token: 0x02000053 RID: 83
	public class NetworkWriter
	{
		// Token: 0x06000427 RID: 1063 RVA: 0x000160BC File Offset: 0x000142BC
		public NetworkWriter()
		{
			this.m_Buffer = new NetBuffer();
			if (NetworkWriter.s_Encoding == null)
			{
				NetworkWriter.s_Encoding = new UTF8Encoding();
				NetworkWriter.s_StringWriteBuffer = new byte[32768];
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00016100 File Offset: 0x00014300
		public NetworkWriter(byte[] buffer)
		{
			this.m_Buffer = new NetBuffer(buffer);
			if (NetworkWriter.s_Encoding == null)
			{
				NetworkWriter.s_Encoding = new UTF8Encoding();
				NetworkWriter.s_StringWriteBuffer = new byte[32768];
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00016138 File Offset: 0x00014338
		public short Position
		{
			get
			{
				return (short)this.m_Buffer.Position;
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00016148 File Offset: 0x00014348
		public byte[] ToArray()
		{
			byte[] array = new byte[this.m_Buffer.AsArraySegment().Count];
			Array.Copy(this.m_Buffer.AsArraySegment().Array, array, this.m_Buffer.AsArraySegment().Count);
			return array;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0001619C File Offset: 0x0001439C
		public byte[] AsArray()
		{
			return this.AsArraySegment().Array;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000161B8 File Offset: 0x000143B8
		internal ArraySegment<byte> AsArraySegment()
		{
			return this.m_Buffer.AsArraySegment();
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000161C8 File Offset: 0x000143C8
		public void WritePackedUInt32(uint value)
		{
			if (value <= 240U)
			{
				this.Write((byte)value);
				return;
			}
			if (value <= 2287U)
			{
				this.Write((byte)((value - 240U) / 256U + 241U));
				this.Write((byte)((value - 240U) % 256U));
				return;
			}
			if (value <= 67823U)
			{
				this.Write(249);
				this.Write((byte)((value - 2288U) / 256U));
				this.Write((byte)((value - 2288U) % 256U));
				return;
			}
			if (value <= 16777215U)
			{
				this.Write(250);
				this.Write((byte)(value & 255U));
				this.Write((byte)((value >> 8) & 255U));
				this.Write((byte)((value >> 16) & 255U));
				return;
			}
			this.Write(251);
			this.Write((byte)(value & 255U));
			this.Write((byte)((value >> 8) & 255U));
			this.Write((byte)((value >> 16) & 255U));
			this.Write((byte)((value >> 24) & 255U));
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000162F4 File Offset: 0x000144F4
		public void WritePackedUInt64(ulong value)
		{
			if (value <= 240UL)
			{
				this.Write((byte)value);
				return;
			}
			if (value <= 2287UL)
			{
				this.Write((byte)((value - 240UL) / 256UL + 241UL));
				this.Write((byte)((value - 240UL) % 256UL));
				return;
			}
			if (value <= 67823UL)
			{
				this.Write(249);
				this.Write((byte)((value - 2288UL) / 256UL));
				this.Write((byte)((value - 2288UL) % 256UL));
				return;
			}
			if (value <= 16777215UL)
			{
				this.Write(250);
				this.Write((byte)(value & 255UL));
				this.Write((byte)((value >> 8) & 255UL));
				this.Write((byte)((value >> 16) & 255UL));
				return;
			}
			if (value <= (ulong)(-1))
			{
				this.Write(251);
				this.Write((byte)(value & 255UL));
				this.Write((byte)((value >> 8) & 255UL));
				this.Write((byte)((value >> 16) & 255UL));
				this.Write((byte)((value >> 24) & 255UL));
				return;
			}
			if (value <= 1099511627775UL)
			{
				this.Write(252);
				this.Write((byte)(value & 255UL));
				this.Write((byte)((value >> 8) & 255UL));
				this.Write((byte)((value >> 16) & 255UL));
				this.Write((byte)((value >> 24) & 255UL));
				this.Write((byte)((value >> 32) & 255UL));
				return;
			}
			if (value <= 281474976710655UL)
			{
				this.Write(253);
				this.Write((byte)(value & 255UL));
				this.Write((byte)((value >> 8) & 255UL));
				this.Write((byte)((value >> 16) & 255UL));
				this.Write((byte)((value >> 24) & 255UL));
				this.Write((byte)((value >> 32) & 255UL));
				this.Write((byte)((value >> 40) & 255UL));
				return;
			}
			if (value <= 72057594037927935UL)
			{
				this.Write(254);
				this.Write((byte)(value & 255UL));
				this.Write((byte)((value >> 8) & 255UL));
				this.Write((byte)((value >> 16) & 255UL));
				this.Write((byte)((value >> 24) & 255UL));
				this.Write((byte)((value >> 32) & 255UL));
				this.Write((byte)((value >> 40) & 255UL));
				this.Write((byte)((value >> 48) & 255UL));
				return;
			}
			this.Write(byte.MaxValue);
			this.Write((byte)(value & 255UL));
			this.Write((byte)((value >> 8) & 255UL));
			this.Write((byte)((value >> 16) & 255UL));
			this.Write((byte)((value >> 24) & 255UL));
			this.Write((byte)((value >> 32) & 255UL));
			this.Write((byte)((value >> 40) & 255UL));
			this.Write((byte)((value >> 48) & 255UL));
			this.Write((byte)((value >> 56) & 255UL));
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0001665C File Offset: 0x0001485C
		public void Write(NetworkInstanceId value)
		{
			this.WritePackedUInt32(value.Value);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0001666C File Offset: 0x0001486C
		public void Write(NetworkSceneId value)
		{
			this.WritePackedUInt32(value.Value);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0001667C File Offset: 0x0001487C
		public void Write(char value)
		{
			this.m_Buffer.WriteByte((byte)value);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0001668C File Offset: 0x0001488C
		public void Write(byte value)
		{
			this.m_Buffer.WriteByte(value);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0001669C File Offset: 0x0001489C
		public void Write(sbyte value)
		{
			this.m_Buffer.WriteByte((byte)value);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000166AC File Offset: 0x000148AC
		public void Write(short value)
		{
			this.m_Buffer.WriteByte2((byte)(value & 255), (byte)((value >> 8) & 255));
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000166CC File Offset: 0x000148CC
		public void Write(ushort value)
		{
			this.m_Buffer.WriteByte2((byte)(value & 255), (byte)((value >> 8) & 255));
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x000166EC File Offset: 0x000148EC
		public void Write(int value)
		{
			this.m_Buffer.WriteByte4((byte)(value & 255), (byte)((value >> 8) & 255), (byte)((value >> 16) & 255), (byte)((value >> 24) & 255));
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00016724 File Offset: 0x00014924
		public void Write(uint value)
		{
			this.m_Buffer.WriteByte4((byte)(value & 255U), (byte)((value >> 8) & 255U), (byte)((value >> 16) & 255U), (byte)((value >> 24) & 255U));
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0001675C File Offset: 0x0001495C
		public void Write(long value)
		{
			this.m_Buffer.WriteByte8((byte)(value & 255L), (byte)((value >> 8) & 255L), (byte)((value >> 16) & 255L), (byte)((value >> 24) & 255L), (byte)((value >> 32) & 255L), (byte)((value >> 40) & 255L), (byte)((value >> 48) & 255L), (byte)((value >> 56) & 255L));
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000167D0 File Offset: 0x000149D0
		public void Write(ulong value)
		{
			this.m_Buffer.WriteByte8((byte)(value & 255UL), (byte)((value >> 8) & 255UL), (byte)((value >> 16) & 255UL), (byte)((value >> 24) & 255UL), (byte)((value >> 32) & 255UL), (byte)((value >> 40) & 255UL), (byte)((value >> 48) & 255UL), (byte)((value >> 56) & 255UL));
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00016844 File Offset: 0x00014A44
		public void Write(float value)
		{
			NetworkWriter.s_FloatConverter.floatValue = value;
			this.Write(NetworkWriter.s_FloatConverter.intValue);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00016864 File Offset: 0x00014A64
		public void Write(double value)
		{
			NetworkWriter.s_FloatConverter.doubleValue = value;
			this.Write(NetworkWriter.s_FloatConverter.longValue);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00016884 File Offset: 0x00014A84
		public void Write(string value)
		{
			if (value == null)
			{
				this.m_Buffer.WriteByte2(0, 0);
				return;
			}
			int byteCount = NetworkWriter.s_Encoding.GetByteCount(value);
			if (byteCount >= 32768)
			{
				throw new IndexOutOfRangeException("Serialize(string) too long: " + value.Length);
			}
			this.Write((ushort)byteCount);
			int bytes = NetworkWriter.s_Encoding.GetBytes(value, 0, value.Length, NetworkWriter.s_StringWriteBuffer, 0);
			this.m_Buffer.WriteBytes(NetworkWriter.s_StringWriteBuffer, (ushort)bytes);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0001690C File Offset: 0x00014B0C
		public void Write(bool value)
		{
			if (value)
			{
				this.m_Buffer.WriteByte(1);
			}
			else
			{
				this.m_Buffer.WriteByte(0);
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00016934 File Offset: 0x00014B34
		public void Write(byte[] buffer, int count)
		{
			this.m_Buffer.WriteBytes(buffer, (ushort)count);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00016944 File Offset: 0x00014B44
		public void Write(byte[] buffer, int offset, int count)
		{
			this.m_Buffer.WriteBytesAtOffset(buffer, (ushort)offset, (ushort)count);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00016958 File Offset: 0x00014B58
		public void WriteBytesAndSize(byte[] buffer, int count)
		{
			if (buffer == null || count == 0)
			{
				this.Write(0);
				return;
			}
			this.Write((ushort)count);
			this.m_Buffer.WriteBytes(buffer, (ushort)count);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00016990 File Offset: 0x00014B90
		public void WriteBytesFull(byte[] buffer)
		{
			if (buffer == null)
			{
				this.Write(0);
				return;
			}
			this.Write((ushort)buffer.Length);
			this.m_Buffer.WriteBytes(buffer, (ushort)buffer.Length);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000169C8 File Offset: 0x00014BC8
		public void Write(Vector2 value)
		{
			this.Write(value.x);
			this.Write(value.y);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000169E4 File Offset: 0x00014BE4
		public void Write(Vector3 value)
		{
			this.Write(value.x);
			this.Write(value.y);
			this.Write(value.z);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00016A10 File Offset: 0x00014C10
		public void Write(Vector4 value)
		{
			this.Write(value.x);
			this.Write(value.y);
			this.Write(value.z);
			this.Write(value.w);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00016A54 File Offset: 0x00014C54
		public void Write(Color value)
		{
			this.Write(value.r);
			this.Write(value.g);
			this.Write(value.b);
			this.Write(value.a);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00016A98 File Offset: 0x00014C98
		public void Write(Color32 value)
		{
			this.Write(value.r);
			this.Write(value.g);
			this.Write(value.b);
			this.Write(value.a);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00016ADC File Offset: 0x00014CDC
		public void Write(Quaternion value)
		{
			this.Write(value.x);
			this.Write(value.y);
			this.Write(value.z);
			this.Write(value.w);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00016B20 File Offset: 0x00014D20
		public void Write(Rect value)
		{
			this.Write(value.xMin);
			this.Write(value.yMin);
			this.Write(value.width);
			this.Write(value.height);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00016B64 File Offset: 0x00014D64
		public void Write(Plane value)
		{
			this.Write(value.normal);
			this.Write(value.distance);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00016B8C File Offset: 0x00014D8C
		public void Write(Ray value)
		{
			this.Write(value.direction);
			this.Write(value.origin);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00016BB4 File Offset: 0x00014DB4
		public void Write(Matrix4x4 value)
		{
			this.Write(value.m00);
			this.Write(value.m01);
			this.Write(value.m02);
			this.Write(value.m03);
			this.Write(value.m10);
			this.Write(value.m11);
			this.Write(value.m12);
			this.Write(value.m13);
			this.Write(value.m20);
			this.Write(value.m21);
			this.Write(value.m22);
			this.Write(value.m23);
			this.Write(value.m30);
			this.Write(value.m31);
			this.Write(value.m32);
			this.Write(value.m33);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00016C94 File Offset: 0x00014E94
		public void Write(NetworkHash128 value)
		{
			this.Write(value.i0);
			this.Write(value.i1);
			this.Write(value.i2);
			this.Write(value.i3);
			this.Write(value.i4);
			this.Write(value.i5);
			this.Write(value.i6);
			this.Write(value.i7);
			this.Write(value.i8);
			this.Write(value.i9);
			this.Write(value.i10);
			this.Write(value.i11);
			this.Write(value.i12);
			this.Write(value.i13);
			this.Write(value.i14);
			this.Write(value.i15);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00016D74 File Offset: 0x00014F74
		public void Write(NetworkIdentity value)
		{
			if (value == null)
			{
				this.WritePackedUInt32(0U);
				return;
			}
			this.Write(value.netId);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00016DA4 File Offset: 0x00014FA4
		public void Write(Transform value)
		{
			if (value == null || value.gameObject == null)
			{
				this.WritePackedUInt32(0U);
				return;
			}
			NetworkIdentity component = value.gameObject.GetComponent<NetworkIdentity>();
			if (component != null)
			{
				this.Write(component.netId);
			}
			else
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("NetworkWriter " + value + " has no NetworkIdentity");
				}
				this.WritePackedUInt32(0U);
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00016E28 File Offset: 0x00015028
		public void Write(GameObject value)
		{
			if (value == null)
			{
				this.WritePackedUInt32(0U);
				return;
			}
			NetworkIdentity component = value.GetComponent<NetworkIdentity>();
			if (component != null)
			{
				this.Write(component.netId);
			}
			else
			{
				if (LogFilter.logWarn)
				{
					Debug.LogWarning("NetworkWriter " + value + " has no NetworkIdentity");
				}
				this.WritePackedUInt32(0U);
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00016E94 File Offset: 0x00015094
		public void Write(MessageBase msg)
		{
			msg.Serialize(this);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00016EA0 File Offset: 0x000150A0
		public void SeekZero()
		{
			this.m_Buffer.SeekZero();
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00016EB0 File Offset: 0x000150B0
		public void StartMessage(short msgType)
		{
			this.SeekZero();
			this.m_Buffer.WriteByte2(0, 0);
			this.Write(msgType);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00016ECC File Offset: 0x000150CC
		public void FinishMessage()
		{
			this.m_Buffer.FinishMessage();
		}

		// Token: 0x040001CD RID: 461
		private const int k_MaxStringLength = 32768;

		// Token: 0x040001CE RID: 462
		private NetBuffer m_Buffer;

		// Token: 0x040001CF RID: 463
		private static Encoding s_Encoding;

		// Token: 0x040001D0 RID: 464
		private static byte[] s_StringWriteBuffer;

		// Token: 0x040001D1 RID: 465
		private static UIntFloat s_FloatConverter;
	}
}
