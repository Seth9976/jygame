using System;
using System.IO;

namespace System.Media
{
	/// <summary>Represents a system sound type.</summary>
	/// <filterpriority>2</filterpriority>
	/// <completionlist cref="T:System.Media.SystemSounds" />
	// Token: 0x020002C2 RID: 706
	public class SystemSound
	{
		// Token: 0x06001851 RID: 6225 RVA: 0x00012053 File Offset: 0x00010253
		internal SystemSound(string tag)
		{
			this.resource = typeof(SystemSound).Assembly.GetManifestResourceStream(tag + ".wav");
		}

		/// <summary>Plays the system sound type.</summary>
		// Token: 0x06001852 RID: 6226 RVA: 0x0004A6EC File Offset: 0x000488EC
		public void Play()
		{
			SoundPlayer soundPlayer = new SoundPlayer(this.resource);
			soundPlayer.Play();
		}

		// Token: 0x04000F77 RID: 3959
		private Stream resource;
	}
}
