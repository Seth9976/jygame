using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>This class defines a pair of clips used by AnimatorOverrideController.</para>
	/// </summary>
	// Token: 0x0200016D RID: 365
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class AnimationClipPair
	{
		/// <summary>
		///   <para>The original clip from the controller.</para>
		/// </summary>
		// Token: 0x040003F7 RID: 1015
		public AnimationClip originalClip;

		/// <summary>
		///   <para>The override animation clip.</para>
		/// </summary>
		// Token: 0x040003F8 RID: 1016
		public AnimationClip overrideClip;
	}
}
