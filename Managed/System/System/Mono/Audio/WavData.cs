using System;
using System.IO;

namespace Mono.Audio
{
	// Token: 0x020002BC RID: 700
	internal class WavData : AudioData
	{
		// Token: 0x06001812 RID: 6162 RVA: 0x00049C3C File Offset: 0x00047E3C
		public WavData(Stream data)
		{
			this.stream = data;
			byte[] array = new byte[44];
			int num = this.stream.Read(array, 0, 44);
			if (num != 44 || array[0] != 82 || array[1] != 73 || array[2] != 70 || array[3] != 70 || array[8] != 87 || array[9] != 65 || array[10] != 86 || array[11] != 69)
			{
				throw new Exception("incorrect format" + num);
			}
			if (array[12] != 102 || array[13] != 109 || array[14] != 116 || array[15] != 32)
			{
				throw new Exception("incorrect format (fmt)");
			}
			int num2 = (int)array[16];
			num2 |= (int)array[17] << 8;
			num2 |= (int)array[18] << 16;
			num2 |= (int)array[19] << 24;
			int num3 = (int)array[20] | ((int)array[21] << 8);
			if (num3 != 1)
			{
				throw new Exception("incorrect format (not PCM)");
			}
			this.channels = (short)((int)array[22] | ((int)array[23] << 8));
			this.sample_rate = (int)array[24];
			this.sample_rate |= (int)array[25] << 8;
			this.sample_rate |= (int)array[26] << 16;
			this.sample_rate |= (int)array[27] << 24;
			int num4 = (int)array[28];
			num4 |= (int)array[29] << 8;
			num4 |= (int)array[30] << 16;
			num4 |= (int)array[31] << 24;
			int num5 = (int)array[34] | ((int)array[35] << 8);
			if (array[36] != 100 || array[37] != 97 || array[38] != 116 || array[39] != 97)
			{
				throw new Exception("incorrect format (data)");
			}
			int num6 = (int)array[40];
			num6 |= (int)array[41] << 8;
			num6 |= (int)array[42] << 16;
			num6 |= (int)array[43] << 24;
			this.data_len = num6;
			int num7 = num5;
			if (num7 != 8)
			{
				if (num7 != 16)
				{
					throw new Exception("bits per sample");
				}
				this.frame_divider = 2;
				this.format = AudioFormat.S16_LE;
			}
			else
			{
				this.frame_divider = 1;
				this.format = AudioFormat.U8;
			}
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x00049E98 File Offset: 0x00048098
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

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x00011DC8 File Offset: 0x0000FFC8
		public override int Channels
		{
			get
			{
				return (int)this.channels;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x00011DD0 File Offset: 0x0000FFD0
		public override int Rate
		{
			get
			{
				return this.sample_rate;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x00011DD8 File Offset: 0x0000FFD8
		public override AudioFormat Format
		{
			get
			{
				return this.format;
			}
		}

		// Token: 0x04000F42 RID: 3906
		private Stream stream;

		// Token: 0x04000F43 RID: 3907
		private short channels;

		// Token: 0x04000F44 RID: 3908
		private ushort frame_divider;

		// Token: 0x04000F45 RID: 3909
		private int sample_rate;

		// Token: 0x04000F46 RID: 3910
		private int data_len;

		// Token: 0x04000F47 RID: 3911
		private AudioFormat format;
	}
}
