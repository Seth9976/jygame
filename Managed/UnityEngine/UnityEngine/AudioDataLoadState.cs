using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Value describing the current load state of the audio data associated with an AudioClip.</para>
	/// </summary>
	// Token: 0x0200014D RID: 333
	public enum AudioDataLoadState
	{
		/// <summary>
		///   <para>Value returned by AudioClip.loadState for an AudioClip that has no audio data loaded and where loading has not been initiated yet.</para>
		/// </summary>
		// Token: 0x0400039A RID: 922
		Unloaded,
		/// <summary>
		///   <para>Value returned by AudioClip.loadState for an AudioClip that is currently loading audio data.</para>
		/// </summary>
		// Token: 0x0400039B RID: 923
		Loading,
		/// <summary>
		///   <para>Value returned by AudioClip.loadState for an AudioClip that has succeeded loading its audio data.</para>
		/// </summary>
		// Token: 0x0400039C RID: 924
		Loaded,
		/// <summary>
		///   <para>Value returned by AudioClip.loadState for an AudioClip that has failed loading its audio data.</para>
		/// </summary>
		// Token: 0x0400039D RID: 925
		Failed
	}
}
