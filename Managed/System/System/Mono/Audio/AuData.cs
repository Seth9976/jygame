using System;
using System.IO;

namespace Mono.Audio
{
	// Token: 0x020002BD RID: 701
	internal class AuData : AudioData
	{
		// Token: 0x06001817 RID: 6167 RVA: 0x00049F10 File Offset: 0x00048110
		public AuData(Stream data)
		{
			this.stream = data;
			byte[] array = new byte[24];
			int num = this.stream.Read(array, 0, 24);
			if (num != 24 || array[0] != 46 || array[1] != 115 || array[2] != 110 || array[3] != 100)
			{
				throw new Exception("incorrect format" + num);
			}
			int num2 = (int)array[7];
			num2 |= (int)array[6] << 8;
			num2 |= (int)array[5] << 16;
			num2 |= (int)array[4] << 24;
			this.data_len = (int)array[11];
			this.data_len |= (int)array[10] << 8;
			this.data_len |= (int)array[9] << 16;
			this.data_len |= (int)array[8] << 24;
			int num3 = (int)array[15];
			num3 |= (int)array[14] << 8;
			num3 |= (int)array[13] << 16;
			num3 |= (int)array[12] << 24;
			this.sample_rate = (int)array[19];
			this.sample_rate |= (int)array[18] << 8;
			this.sample_rate |= (int)array[17] << 16;
			this.sample_rate |= (int)array[16] << 24;
			int num4 = (int)array[23];
			num4 |= (int)array[22] << 8;
			num4 |= (int)array[21] << 16;
			num4 |= (int)array[20] << 24;
			this.channels = (short)num4;
			if (num2 < 24 || (num4 != 1 && num4 != 2))
			{
				throw new Exception("incorrect format offset" + num2);
			}
			if (num2 != 24)
			{
				for (int i = 24; i < num2; i++)
				{
					this.stream.ReadByte();
				}
			}
			int num5 = num3;
			if (num5 != 1)
			{
				throw new Exception("incorrect format encoding" + num3);
			}
			this.frame_divider = 1;
			this.format = AudioFormat.MU_LAW;
			if (this.data_len == -1)
			{
				this.data_len = (int)this.stream.Length - num2;
			}
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x0004A138 File Offset: 0x00048338
		public override void Play(AudioDevice dev)
		{
			int num = this.data_len;
			byte[] array = new byte[4096];
			this.stream.Position = 0L;
			int num2;
			while (!this.IsStopped && num >= 0 && (num2 = this.stream.Read(array, 0, Math.Min(array.Length, num))) > 0)
			{
				dev.PlaySample(array, num2 / (int)this.frame_divider);
				num -= num2;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x00011DE0 File Offset: 0x0000FFE0
		public override int Channels
		{
			get
			{
				return (int)this.channels;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x00011DE8 File Offset: 0x0000FFE8
		public override int Rate
		{
			get
			{
				return this.sample_rate;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x00011DF0 File Offset: 0x0000FFF0
		public override AudioFormat Format
		{
			get
			{
				return this.format;
			}
		}

		// Token: 0x04000F48 RID: 3912
		private Stream stream;

		// Token: 0x04000F49 RID: 3913
		private short channels;

		// Token: 0x04000F4A RID: 3914
		private ushort frame_divider;

		// Token: 0x04000F4B RID: 3915
		private int sample_rate;

		// Token: 0x04000F4C RID: 3916
		private int data_len;

		// Token: 0x04000F4D RID: 3917
		private AudioFormat format;
	}
}
