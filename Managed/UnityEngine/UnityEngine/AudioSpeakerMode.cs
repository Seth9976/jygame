using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>These are speaker types defined for use with AudioSettings.speakerMode.</para>
	/// </summary>
	// Token: 0x0200014C RID: 332
	public enum AudioSpeakerMode
	{
		/// <summary>
		///   <para>Channel count is unaffected.</para>
		/// </summary>
		// Token: 0x04000391 RID: 913
		Raw,
		/// <summary>
		///   <para>Channel count is set to 1. The speakers are monaural.</para>
		/// </summary>
		// Token: 0x04000392 RID: 914
		Mono,
		/// <summary>
		///   <para>Channel count is set to 2. The speakers are stereo. This is the editor default.</para>
		/// </summary>
		// Token: 0x04000393 RID: 915
		Stereo,
		/// <summary>
		///   <para>Channel count is set to 4. 4 speaker setup. This includes front left, front right, rear left, rear right.</para>
		/// </summary>
		// Token: 0x04000394 RID: 916
		Quad,
		/// <summary>
		///   <para>Channel count is set to 5. 5 speaker setup. This includes front left, front right, center, rear left, rear right.</para>
		/// </summary>
		// Token: 0x04000395 RID: 917
		Surround,
		/// <summary>
		///   <para>Channel count is set to 6. 5.1 speaker setup. This includes front left, front right, center, rear left, rear right and a subwoofer.</para>
		/// </summary>
		// Token: 0x04000396 RID: 918
		Mode5point1,
		/// <summary>
		///   <para>Channel count is set to 8. 7.1 speaker setup. This includes front left, front right, center, rear left, rear right, side left, side right and a subwoofer.</para>
		/// </summary>
		// Token: 0x04000397 RID: 919
		Mode7point1,
		/// <summary>
		///   <para>Channel count is set to 2. Stereo output, but data is encoded in a way that is picked up by a Prologic/Prologic2 decoder and split into a 5.1 speaker setup.</para>
		/// </summary>
		// Token: 0x04000398 RID: 920
		Prologic
	}
}
