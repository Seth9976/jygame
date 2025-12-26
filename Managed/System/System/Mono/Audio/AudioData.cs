using System;

namespace Mono.Audio
{
	// Token: 0x020002BB RID: 699
	internal abstract class AudioData
	{
		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600180B RID: 6155
		public abstract int Channels { get; }

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600180C RID: 6156
		public abstract int Rate { get; }

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600180D RID: 6157
		public abstract AudioFormat Format { get; }

		// Token: 0x0600180E RID: 6158 RVA: 0x00011D9C File Offset: 0x0000FF9C
		public virtual void Setup(AudioDevice dev)
		{
			dev.SetFormat(this.Format, this.Channels, this.Rate);
		}

		// Token: 0x0600180F RID: 6159
		public abstract void Play(AudioDevice dev);

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001810 RID: 6160 RVA: 0x00011DB7 File Offset: 0x0000FFB7
		// (set) Token: 0x06001811 RID: 6161 RVA: 0x00011DBF File Offset: 0x0000FFBF
		public virtual bool IsStopped
		{
			get
			{
				return this.stopped;
			}
			set
			{
				this.stopped = value;
			}
		}

		// Token: 0x04000F40 RID: 3904
		protected const int buffer_size = 4096;

		// Token: 0x04000F41 RID: 3905
		private bool stopped;
	}
}
