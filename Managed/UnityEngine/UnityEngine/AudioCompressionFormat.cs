using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>An enum containing different compression types.</para>
	/// </summary>
	// Token: 0x02000152 RID: 338
	public enum AudioCompressionFormat
	{
		/// <summary>
		///   <para>Uncompressed pulse-code modulation.</para>
		/// </summary>
		// Token: 0x040003B3 RID: 947
		PCM,
		/// <summary>
		///   <para>Vorbis compression format.</para>
		/// </summary>
		// Token: 0x040003B4 RID: 948
		Vorbis,
		/// <summary>
		///   <para>Adaptive differential pulse-code modulation.</para>
		/// </summary>
		// Token: 0x040003B5 RID: 949
		ADPCM,
		/// <summary>
		///   <para>MPEG Audio Layer III.</para>
		/// </summary>
		// Token: 0x040003B6 RID: 950
		MP3,
		/// <summary>
		///   <para>Sony proprietary hardware format.</para>
		/// </summary>
		// Token: 0x040003B7 RID: 951
		VAG,
		/// <summary>
		///   <para>Sony proprietory hardware codec.</para>
		/// </summary>
		// Token: 0x040003B8 RID: 952
		HEVAG,
		/// <summary>
		///   <para>Xbox One proprietary hardware format.</para>
		/// </summary>
		// Token: 0x040003B9 RID: 953
		XMA,
		/// <summary>
		///   <para>AAC Audio Compression.</para>
		/// </summary>
		// Token: 0x040003BA RID: 954
		AAC,
		/// <summary>
		///   <para>Nintendo ADPCM audio compression format.</para>
		/// </summary>
		// Token: 0x040003BB RID: 955
		GCADPCM
	}
}
