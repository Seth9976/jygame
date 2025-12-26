using System;
using System.Runtime.InteropServices;

namespace Mono.Audio
{
	// Token: 0x020002C0 RID: 704
	internal class AlsaDevice : AudioDevice, IDisposable
	{
		// Token: 0x06001822 RID: 6178 RVA: 0x0004A214 File Offset: 0x00048414
		public AlsaDevice(string name)
		{
			if (name == null)
			{
				name = "default";
			}
			int num = AlsaDevice.snd_pcm_open(ref this.handle, name, 0, 0);
			if (num < 0)
			{
				throw new Exception("no open " + num);
			}
		}

		// Token: 0x06001823 RID: 6179
		[DllImport("libasound.so.2")]
		private static extern int snd_pcm_open(ref IntPtr handle, string pcm_name, int stream, int mode);

		// Token: 0x06001824 RID: 6180
		[DllImport("libasound.so.2")]
		private static extern int snd_pcm_close(IntPtr handle);

		// Token: 0x06001825 RID: 6181
		[DllImport("libasound.so.2")]
		private static extern int snd_pcm_drain(IntPtr handle);

		// Token: 0x06001826 RID: 6182
		[DllImport("libasound.so.2")]
		private static extern int snd_pcm_writei(IntPtr handle, byte[] buf, int size);

		// Token: 0x06001827 RID: 6183
		[DllImport("libasound.so.2")]
		private static extern int snd_pcm_set_params(IntPtr handle, int format, int access, int channels, int rate, int soft_resample, int latency);

		// Token: 0x06001828 RID: 6184 RVA: 0x0004A260 File Offset: 0x00048460
		~AlsaDevice()
		{
			this.Dispose(false);
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x00011DFB File Offset: 0x0000FFFB
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x00011E0A File Offset: 0x0001000A
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
			}
			if (this.handle != IntPtr.Zero)
			{
				AlsaDevice.snd_pcm_close(this.handle);
			}
			this.handle = IntPtr.Zero;
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x0004A290 File Offset: 0x00048490
		public override bool SetFormat(AudioFormat format, int channels, int rate)
		{
			int num = AlsaDevice.snd_pcm_set_params(this.handle, (int)format, 3, channels, rate, 1, 500000);
			return num == 0;
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x0004A2B8 File Offset: 0x000484B8
		public override int PlaySample(byte[] buffer, int num_frames)
		{
			return AlsaDevice.snd_pcm_writei(this.handle, buffer, num_frames);
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00011E3E File Offset: 0x0001003E
		public override void Wait()
		{
			AlsaDevice.snd_pcm_drain(this.handle);
		}

		// Token: 0x04000F68 RID: 3944
		private IntPtr handle;
	}
}
