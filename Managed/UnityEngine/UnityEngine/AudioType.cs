using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Type of the imported(native) data.</para>
	/// </summary>
	// Token: 0x02000151 RID: 337
	public enum AudioType
	{
		/// <summary>
		///   <para>3rd party / unknown plugin format.</para>
		/// </summary>
		// Token: 0x040003A5 RID: 933
		UNKNOWN,
		/// <summary>
		///   <para>Acc - not supported.</para>
		/// </summary>
		// Token: 0x040003A6 RID: 934
		ACC,
		/// <summary>
		///   <para>Aiff.</para>
		/// </summary>
		// Token: 0x040003A7 RID: 935
		AIFF,
		/// <summary>
		///   <para>Impulse tracker.</para>
		/// </summary>
		// Token: 0x040003A8 RID: 936
		IT = 10,
		/// <summary>
		///   <para>Protracker / Fasttracker MOD.</para>
		/// </summary>
		// Token: 0x040003A9 RID: 937
		MOD = 12,
		/// <summary>
		///   <para>MP2/MP3 MPEG.</para>
		/// </summary>
		// Token: 0x040003AA RID: 938
		MPEG,
		/// <summary>
		///   <para>Ogg vorbis.</para>
		/// </summary>
		// Token: 0x040003AB RID: 939
		OGGVORBIS,
		/// <summary>
		///   <para>ScreamTracker 3.</para>
		/// </summary>
		// Token: 0x040003AC RID: 940
		S3M = 17,
		/// <summary>
		///   <para>Microsoft WAV.</para>
		/// </summary>
		// Token: 0x040003AD RID: 941
		WAV = 20,
		/// <summary>
		///   <para>FastTracker 2 XM.</para>
		/// </summary>
		// Token: 0x040003AE RID: 942
		XM,
		/// <summary>
		///   <para>Xbox360 XMA.</para>
		/// </summary>
		// Token: 0x040003AF RID: 943
		XMA,
		/// <summary>
		///   <para>VAG.</para>
		/// </summary>
		// Token: 0x040003B0 RID: 944
		VAG,
		/// <summary>
		///   <para>iPhone hardware decoder, supports AAC, ALAC and MP3. Extracodecdata is a pointer to an FMOD_AUDIOQUEUE_EXTRACODECDATA structure.</para>
		/// </summary>
		// Token: 0x040003B1 RID: 945
		AUDIOQUEUE
	}
}
