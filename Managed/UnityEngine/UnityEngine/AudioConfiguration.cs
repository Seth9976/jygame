using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Specifies the current properties or desired properties to be set for the audio system.</para>
	/// </summary>
	// Token: 0x0200014E RID: 334
	public struct AudioConfiguration
	{
		/// <summary>
		///   <para>The current speaker mode used by the audio output device.</para>
		/// </summary>
		// Token: 0x0400039E RID: 926
		public AudioSpeakerMode speakerMode;

		/// <summary>
		///   <para>The length of the DSP buffer in samples determining the latency of sounds by the audio output device.</para>
		/// </summary>
		// Token: 0x0400039F RID: 927
		public int dspBufferSize;

		/// <summary>
		///   <para>The current sample rate of the audio output device used.</para>
		/// </summary>
		// Token: 0x040003A0 RID: 928
		public int sampleRate;

		/// <summary>
		///   <para>The current maximum number of simultaneously audible sounds in the game.</para>
		/// </summary>
		// Token: 0x040003A1 RID: 929
		public int numRealVoices;

		/// <summary>
		///   <para>The  maximum number of managed sounds in the game. Beyond this limit sounds will simply stop playing.</para>
		/// </summary>
		// Token: 0x040003A2 RID: 930
		public int numVirtualVoices;
	}
}
