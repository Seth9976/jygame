using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Determines how the audio clip is loaded in.</para>
	/// </summary>
	// Token: 0x02000153 RID: 339
	public enum AudioClipLoadType
	{
		/// <summary>
		///   <para>The audio data is decompressed when the audio clip is loaded.</para>
		/// </summary>
		// Token: 0x040003BD RID: 957
		DecompressOnLoad,
		/// <summary>
		///   <para>The audio data of the clip will be kept in memory in compressed form.</para>
		/// </summary>
		// Token: 0x040003BE RID: 958
		CompressedInMemory,
		/// <summary>
		///   <para>Streams audio data from disk.</para>
		/// </summary>
		// Token: 0x040003BF RID: 959
		Streaming
	}
}
