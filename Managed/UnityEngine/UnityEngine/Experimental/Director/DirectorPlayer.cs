using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Experimental.Director
{
	/// <summary>
	///   <para>The DirectorPlayer is the base class for all components capable of playing a Experimental.Director.Playable tree.</para>
	/// </summary>
	// Token: 0x020000D5 RID: 213
	public class DirectorPlayer : Behaviour
	{
		// Token: 0x06000CD7 RID: 3287 RVA: 0x00006675 File Offset: 0x00004875
		public void Play(Playable playable, object customData)
		{
			this.PlayInternal(playable, customData);
		}

		/// <summary>
		///   <para>Starts playing a Experimental.Director.Playable tree.</para>
		/// </summary>
		/// <param name="playable">The root Experimental.Director.Playable in the tree.</param>
		// Token: 0x06000CD8 RID: 3288 RVA: 0x0000667F File Offset: 0x0000487F
		public void Play(Playable playable)
		{
			this.PlayInternal(playable, null);
		}

		// Token: 0x06000CD9 RID: 3289
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void PlayInternal(Playable playable, object customData);

		/// <summary>
		///   <para>Stop the playback of the Player and Experimental.Director.Playable.</para>
		/// </summary>
		// Token: 0x06000CDA RID: 3290
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Stop();

		/// <summary>
		///   <para>Sets the Player's local time.</para>
		/// </summary>
		/// <param name="time">The new local time.</param>
		// Token: 0x06000CDB RID: 3291
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetTime(double time);

		/// <summary>
		///   <para>Returns the Player's current local time.</para>
		/// </summary>
		/// <returns>
		///   <para>Current local time.</para>
		/// </returns>
		// Token: 0x06000CDC RID: 3292
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern double GetTime();

		/// <summary>
		///   <para>Specifies the way the Player's will increment when it is playing.</para>
		/// </summary>
		/// <param name="mode"></param>
		// Token: 0x06000CDD RID: 3293
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetTimeUpdateMode(DirectorUpdateMode mode);

		/// <summary>
		///   <para>Returns the current Experimental.Director.DirectorUpdateMode.</para>
		/// </summary>
		/// <returns>
		///   <para>Current update mode for this player.</para>
		/// </returns>
		// Token: 0x06000CDE RID: 3294
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern DirectorUpdateMode GetTimeUpdateMode();
	}
}
