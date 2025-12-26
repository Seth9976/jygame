using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Used by Animation.Play function.</para>
	/// </summary>
	// Token: 0x02000176 RID: 374
	public enum QueueMode
	{
		/// <summary>
		///   <para>Will start playing after all other animations have stopped playing.</para>
		/// </summary>
		// Token: 0x04000418 RID: 1048
		CompleteOthers,
		/// <summary>
		///   <para>Starts playing immediately. This can be used if you just want to quickly create a duplicate animation.</para>
		/// </summary>
		// Token: 0x04000419 RID: 1049
		PlayNow = 2
	}
}
