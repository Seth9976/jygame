using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Movie Textures are textures onto which movies are played back.</para>
	/// </summary>
	// Token: 0x02000169 RID: 361
	public sealed class MovieTexture : Texture
	{
		/// <summary>
		///   <para>Starts playing the movie.</para>
		/// </summary>
		// Token: 0x06001523 RID: 5411 RVA: 0x00007D99 File Offset: 0x00005F99
		public void Play()
		{
			MovieTexture.INTERNAL_CALL_Play(this);
		}

		// Token: 0x06001524 RID: 5412
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Play(MovieTexture self);

		/// <summary>
		///   <para>Stops playing the movie, and rewinds it to the beginning.</para>
		/// </summary>
		// Token: 0x06001525 RID: 5413 RVA: 0x00007DA1 File Offset: 0x00005FA1
		public void Stop()
		{
			MovieTexture.INTERNAL_CALL_Stop(this);
		}

		// Token: 0x06001526 RID: 5414
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Stop(MovieTexture self);

		/// <summary>
		///   <para>Pauses playing the movie.</para>
		/// </summary>
		// Token: 0x06001527 RID: 5415 RVA: 0x00007DA9 File Offset: 0x00005FA9
		public void Pause()
		{
			MovieTexture.INTERNAL_CALL_Pause(this);
		}

		// Token: 0x06001528 RID: 5416
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Pause(MovieTexture self);

		/// <summary>
		///   <para>Returns the AudioClip belonging to the MovieTexture.</para>
		/// </summary>
		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001529 RID: 5417
		public extern AudioClip audioClip
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Set this to true to make the movie loop.</para>
		/// </summary>
		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x0600152A RID: 5418
		// (set) Token: 0x0600152B RID: 5419
		public extern bool loop
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Returns whether the movie is playing or not.</para>
		/// </summary>
		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x0600152C RID: 5420
		public extern bool isPlaying
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>If the movie is downloading from a web site, this returns if enough data has been downloaded so playback should be able to start without interruptions.</para>
		/// </summary>
		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x0600152D RID: 5421
		public extern bool isReadyToPlay
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The time, in seconds, that the movie takes to play back completely.</para>
		/// </summary>
		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x0600152E RID: 5422
		public extern float duration
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}
	}
}
