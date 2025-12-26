using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Experimental.Director
{
	/// <summary>
	///   <para>Playable used to mix AnimationPlayables.</para>
	/// </summary>
	// Token: 0x0200019D RID: 413
	public class AnimationMixerPlayable : AnimationPlayable
	{
		// Token: 0x06001770 RID: 6000 RVA: 0x0000874B File Offset: 0x0000694B
		public AnimationMixerPlayable()
			: base(false)
		{
			this.m_Ptr = IntPtr.Zero;
			this.InstantiateEnginePlayable();
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x00008765 File Offset: 0x00006965
		public AnimationMixerPlayable(bool final)
			: base(false)
		{
			this.m_Ptr = IntPtr.Zero;
			if (final)
			{
				this.InstantiateEnginePlayable();
			}
		}

		// Token: 0x06001772 RID: 6002
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InstantiateEnginePlayable();

		/// <summary>
		///   <para>Automatically creates an AnimationClipPlayable for each supplied AnimationClip, then sets them as inputs to the mixer.</para>
		/// </summary>
		/// <param name="clips">AnimationClips to be used as inputs.</param>
		/// <returns>
		///   <para>Returns false if the creation of the AnimationClipPlayables failed, or if the connection failed.</para>
		/// </returns>
		// Token: 0x06001773 RID: 6003 RVA: 0x0001AFA4 File Offset: 0x000191A4
		public bool SetInputs(AnimationClip[] clips)
		{
			if (clips == null)
			{
				throw new NullReferenceException("Parameter clips was null. You need to pass in a valid array of clips.");
			}
			AnimationPlayable[] array = new AnimationPlayable[clips.Length];
			for (int i = 0; i < clips.Length; i++)
			{
				array[i] = new AnimationClipPlayable(clips[i]);
			}
			return base.SetInputs(array);
		}
	}
}
