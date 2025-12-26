using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Runtime reprentation of the AnimatorController. It can be used to change the Animator's controller during runtime.</para>
	/// </summary>
	// Token: 0x02000191 RID: 401
	public class RuntimeAnimatorController : Object
	{
		/// <summary>
		///   <para>Retrieves all AnimationClip used by the controller.</para>
		/// </summary>
		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001755 RID: 5973
		public extern AnimationClip[] animationClips
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}
	}
}
