using System;

namespace Mono.Audio
{
	// Token: 0x020002BF RID: 703
	internal class AudioDevice
	{
		// Token: 0x0600181D RID: 6173 RVA: 0x0004A1B0 File Offset: 0x000483B0
		private static AudioDevice TryAlsa(string name)
		{
			AudioDevice audioDevice2;
			try
			{
				AudioDevice audioDevice = new AlsaDevice(name);
				audioDevice2 = audioDevice;
			}
			catch
			{
				audioDevice2 = null;
			}
			return audioDevice2;
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x0004A1F0 File Offset: 0x000483F0
		public static AudioDevice CreateDevice(string name)
		{
			AudioDevice audioDevice = AudioDevice.TryAlsa(name);
			if (audioDevice == null)
			{
				audioDevice = new AudioDevice();
			}
			return audioDevice;
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x000025B7 File Offset: 0x000007B7
		public virtual bool SetFormat(AudioFormat format, int channels, int rate)
		{
			return true;
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x00011DF8 File Offset: 0x0000FFF8
		public virtual int PlaySample(byte[] buffer, int num_frames)
		{
			return num_frames;
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x000029F5 File Offset: 0x00000BF5
		public virtual void Wait()
		{
		}
	}
}
