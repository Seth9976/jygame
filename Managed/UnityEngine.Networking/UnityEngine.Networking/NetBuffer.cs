using System;

namespace UnityEngine.Networking
{
	// Token: 0x02000032 RID: 50
	internal class NetBuffer
	{
		// Token: 0x06000128 RID: 296 RVA: 0x0000664C File Offset: 0x0000484C
		public NetBuffer()
		{
			this.m_Buffer = new byte[64];
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00006664 File Offset: 0x00004864
		public NetBuffer(byte[] buffer)
		{
			this.m_Buffer = buffer;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00006674 File Offset: 0x00004874
		public uint Position
		{
			get
			{
				return this.m_Pos;
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000667C File Offset: 0x0000487C
		public byte ReadByte()
		{
			if ((ulong)this.m_Pos >= (ulong)((long)this.m_Buffer.Length))
			{
				throw new IndexOutOfRangeException("NetworkReader:ReadByte out of range:" + this.ToString());
			}
			return this.m_Buffer[(int)((UIntPtr)(this.m_Pos++))];
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000066D0 File Offset: 0x000048D0
		public void ReadBytes(byte[] buffer, uint count)
		{
			if ((ulong)(this.m_Pos + count) > (ulong)((long)this.m_Buffer.Length))
			{
				throw new IndexOutOfRangeException(string.Concat(new object[]
				{
					"NetworkReader:ReadBytes out of range: (",
					count,
					") ",
					this.ToString()
				}));
			}
			ushort num = 0;
			while ((uint)num < count)
			{
				buffer[(int)num] = this.m_Buffer[(int)((UIntPtr)(this.m_Pos + (uint)num))];
				num += 1;
			}
			this.m_Pos += count;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000675C File Offset: 0x0000495C
		public void ReadChars(char[] buffer, uint count)
		{
			if ((ulong)(this.m_Pos + count) > (ulong)((long)this.m_Buffer.Length))
			{
				throw new IndexOutOfRangeException(string.Concat(new object[]
				{
					"NetworkReader:ReadChars out of range: (",
					count,
					") ",
					this.ToString()
				}));
			}
			ushort num = 0;
			while ((uint)num < count)
			{
				buffer[(int)num] = (char)this.m_Buffer[(int)((UIntPtr)(this.m_Pos + (uint)num))];
				num += 1;
			}
			this.m_Pos += count;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000067E8 File Offset: 0x000049E8
		internal ArraySegment<byte> AsArraySegment()
		{
			return new ArraySegment<byte>(this.m_Buffer, 0, (int)this.m_Pos);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000067FC File Offset: 0x000049FC
		public void WriteByte(byte value)
		{
			this.WriteCheckForSpace(1);
			this.m_Buffer[(int)((UIntPtr)this.m_Pos)] = value;
			this.m_Pos += 1U;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00006830 File Offset: 0x00004A30
		public void WriteByte2(byte value0, byte value1)
		{
			this.WriteCheckForSpace(2);
			this.m_Buffer[(int)((UIntPtr)this.m_Pos)] = value0;
			this.m_Buffer[(int)((UIntPtr)(this.m_Pos + 1U))] = value1;
			this.m_Pos += 2U;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00006868 File Offset: 0x00004A68
		public void WriteByte4(byte value0, byte value1, byte value2, byte value3)
		{
			this.WriteCheckForSpace(4);
			this.m_Buffer[(int)((UIntPtr)this.m_Pos)] = value0;
			this.m_Buffer[(int)((UIntPtr)(this.m_Pos + 1U))] = value1;
			this.m_Buffer[(int)((UIntPtr)(this.m_Pos + 2U))] = value2;
			this.m_Buffer[(int)((UIntPtr)(this.m_Pos + 3U))] = value3;
			this.m_Pos += 4U;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000068D0 File Offset: 0x00004AD0
		public void WriteByte8(byte value0, byte value1, byte value2, byte value3, byte value4, byte value5, byte value6, byte value7)
		{
			this.WriteCheckForSpace(8);
			this.m_Buffer[(int)((UIntPtr)this.m_Pos)] = value0;
			this.m_Buffer[(int)((UIntPtr)(this.m_Pos + 1U))] = value1;
			this.m_Buffer[(int)((UIntPtr)(this.m_Pos + 2U))] = value2;
			this.m_Buffer[(int)((UIntPtr)(this.m_Pos + 3U))] = value3;
			this.m_Buffer[(int)((UIntPtr)(this.m_Pos + 4U))] = value4;
			this.m_Buffer[(int)((UIntPtr)(this.m_Pos + 5U))] = value5;
			this.m_Buffer[(int)((UIntPtr)(this.m_Pos + 6U))] = value6;
			this.m_Buffer[(int)((UIntPtr)(this.m_Pos + 7U))] = value7;
			this.m_Pos += 8U;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00006980 File Offset: 0x00004B80
		public void WriteBytesAtOffset(byte[] buffer, ushort targetOffset, ushort count)
		{
			uint num = (uint)(count + targetOffset);
			this.WriteCheckForSpace((ushort)num);
			if (targetOffset == 0 && (int)count == buffer.Length)
			{
				buffer.CopyTo(this.m_Buffer, (long)((ulong)this.m_Pos));
			}
			else
			{
				for (int i = 0; i < (int)count; i++)
				{
					this.m_Buffer[(int)targetOffset + i] = buffer[i];
				}
			}
			if (num > this.m_Pos)
			{
				this.m_Pos = num;
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000069F4 File Offset: 0x00004BF4
		public void WriteBytes(byte[] buffer, ushort count)
		{
			this.WriteCheckForSpace(count);
			if ((int)count == buffer.Length)
			{
				buffer.CopyTo(this.m_Buffer, (long)((ulong)this.m_Pos));
			}
			else
			{
				for (int i = 0; i < (int)count; i++)
				{
					checked
					{
						this.m_Buffer[(int)((IntPtr)(unchecked((ulong)this.m_Pos + (ulong)((long)i))))] = buffer[i];
					}
				}
			}
			this.m_Pos += (uint)count;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00006A60 File Offset: 0x00004C60
		private void WriteCheckForSpace(ushort count)
		{
			if ((ulong)(this.m_Pos + (uint)count) < (ulong)((long)this.m_Buffer.Length))
			{
				return;
			}
			int num = (int)((float)this.m_Buffer.Length * 1.5f);
			while ((ulong)(this.m_Pos + (uint)count) >= (ulong)((long)num))
			{
				num = (int)((float)num * 1.5f);
				if (num > 134217728)
				{
					Debug.LogWarning("NetworkBuffer size is " + num + " bytes!");
				}
			}
			byte[] array = new byte[num];
			this.m_Buffer.CopyTo(array, 0);
			this.m_Buffer = array;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00006AF8 File Offset: 0x00004CF8
		public void FinishMessage()
		{
			ushort num = (ushort)(this.m_Pos - 4U);
			this.m_Buffer[0] = (byte)(num & 255);
			this.m_Buffer[1] = (byte)((num >> 8) & 255);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00006B34 File Offset: 0x00004D34
		public void SeekZero()
		{
			this.m_Pos = 0U;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00006B40 File Offset: 0x00004D40
		public void Replace(byte[] buffer)
		{
			this.m_Buffer = buffer;
			this.m_Pos = 0U;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00006B50 File Offset: 0x00004D50
		public override string ToString()
		{
			return string.Format("NetBuf sz:{0} pos:{1}", this.m_Buffer.Length, this.m_Pos);
		}

		// Token: 0x04000097 RID: 151
		private const int k_InitialSize = 64;

		// Token: 0x04000098 RID: 152
		private const float k_GrowthFactor = 1.5f;

		// Token: 0x04000099 RID: 153
		private const int k_BufferSizeWarning = 134217728;

		// Token: 0x0400009A RID: 154
		private byte[] m_Buffer;

		// Token: 0x0400009B RID: 155
		private uint m_Pos;
	}
}
