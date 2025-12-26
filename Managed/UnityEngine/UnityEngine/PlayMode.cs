using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Used by Animation.Play function.</para>
	/// </summary>
	// Token: 0x02000175 RID: 373
	public enum PlayMode
	{
		/// <summary>
		///   <para>Will stop all animations that were started in the same layer. This is the default when playing animations.</para>
		/// </summary>
		// Token: 0x04000415 RID: 1045
		StopSameLayer,
		/// <summary>
		///   <para>Will stop all animations that were started with this component before playing.</para>
		/// </summary>
		// Token: 0x04000416 RID: 1046
		StopAll = 4
	}
}
