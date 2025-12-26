using System;
using System.Runtime.CompilerServices;
using UnityEngine.Audio;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>A representation of audio sources in 3D.</para>
	/// </summary>
	// Token: 0x0200015C RID: 348
	public sealed class AudioSource : Behaviour
	{
		/// <summary>
		///   <para>The volume of the audio source (0.0 to 1.0).</para>
		/// </summary>
		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x0600144D RID: 5197
		// (set) Token: 0x0600144E RID: 5198
		public extern float volume
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The pitch of the audio source.</para>
		/// </summary>
		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x0600144F RID: 5199
		// (set) Token: 0x06001450 RID: 5200
		public extern float pitch
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Playback position in seconds.</para>
		/// </summary>
		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001451 RID: 5201
		// (set) Token: 0x06001452 RID: 5202
		public extern float time
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Playback position in PCM samples.</para>
		/// </summary>
		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001453 RID: 5203
		// (set) Token: 0x06001454 RID: 5204
		public extern int timeSamples
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The default AudioClip to play.</para>
		/// </summary>
		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001455 RID: 5205
		// (set) Token: 0x06001456 RID: 5206
		public extern AudioClip clip
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The target group to which the AudioSource should route its signal.</para>
		/// </summary>
		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001457 RID: 5207
		// (set) Token: 0x06001458 RID: 5208
		public extern AudioMixerGroup outputAudioMixerGroup
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Plays the clip with an optional certain delay.</para>
		/// </summary>
		/// <param name="delay">Delay in number of samples, assuming a 44100Hz sample rate (meaning that Play(44100) will delay the playing by exactly 1 sec).</param>
		// Token: 0x06001459 RID: 5209
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Play([DefaultValue("0")] ulong delay);

		// Token: 0x0600145A RID: 5210 RVA: 0x0001A450 File Offset: 0x00018650
		[ExcludeFromDocs]
		public void Play()
		{
			ulong num = 0UL;
			this.Play(num);
		}

		/// <summary>
		///   <para>Plays the clip with a delay specified in seconds. Users are advised to use this function instead of the old Play(delay) function that took a delay specified in samples relative to a reference rate of 44.1 kHz as an argument.</para>
		/// </summary>
		/// <param name="delay">Delay time specified in seconds.</param>
		// Token: 0x0600145B RID: 5211
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void PlayDelayed(float delay);

		/// <summary>
		///   <para>Plays the clip at a specific time on the absolute time-line that AudioSettings.dspTime reads from.</para>
		/// </summary>
		/// <param name="time">Time in seconds on the absolute time-line that AudioSettings.dspTime refers to for when the sound should start playing.</param>
		// Token: 0x0600145C RID: 5212
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void PlayScheduled(double time);

		/// <summary>
		///   <para>Changes the time at which a sound that has already been scheduled to play will start.</para>
		/// </summary>
		/// <param name="time">Time in seconds.</param>
		// Token: 0x0600145D RID: 5213
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetScheduledStartTime(double time);

		/// <summary>
		///   <para>Changes the time at which a sound that has already been scheduled to play will end. Notice that depending on the timing not all rescheduling requests can be fulfilled.</para>
		/// </summary>
		/// <param name="time">Time in seconds.</param>
		// Token: 0x0600145E RID: 5214
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetScheduledEndTime(double time);

		/// <summary>
		///   <para>Stops playing the clip.</para>
		/// </summary>
		// Token: 0x0600145F RID: 5215
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Stop();

		/// <summary>
		///   <para>Pauses playing the clip.</para>
		/// </summary>
		// Token: 0x06001460 RID: 5216 RVA: 0x00007D74 File Offset: 0x00005F74
		public void Pause()
		{
			AudioSource.INTERNAL_CALL_Pause(this);
		}

		// Token: 0x06001461 RID: 5217
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Pause(AudioSource self);

		/// <summary>
		///   <para>Unpause the paused playback of this AudioSource.</para>
		/// </summary>
		// Token: 0x06001462 RID: 5218 RVA: 0x00007D7C File Offset: 0x00005F7C
		public void UnPause()
		{
			AudioSource.INTERNAL_CALL_UnPause(this);
		}

		// Token: 0x06001463 RID: 5219
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_UnPause(AudioSource self);

		/// <summary>
		///   <para>Is the clip playing right now (Read Only)?</para>
		/// </summary>
		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001464 RID: 5220
		public extern bool isPlaying
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Plays an AudioClip, and scales the AudioSource volume by volumeScale.</para>
		/// </summary>
		/// <param name="clip">The clip being played.</param>
		/// <param name="volumeScale">The scale of the volume (0-1).</param>
		// Token: 0x06001465 RID: 5221
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void PlayOneShot(AudioClip clip, [DefaultValue("1.0F")] float volumeScale);

		/// <summary>
		///   <para>Plays an AudioClip, and scales the AudioSource volume by volumeScale.</para>
		/// </summary>
		/// <param name="clip">The clip being played.</param>
		/// <param name="volumeScale">The scale of the volume (0-1).</param>
		// Token: 0x06001466 RID: 5222 RVA: 0x0001A468 File Offset: 0x00018668
		[ExcludeFromDocs]
		public void PlayOneShot(AudioClip clip)
		{
			float num = 1f;
			this.PlayOneShot(clip, num);
		}

		/// <summary>
		///   <para>Plays an AudioClip at a given position in world space.</para>
		/// </summary>
		/// <param name="clip">Audio data to play.</param>
		/// <param name="position">Position in world space from which sound originates.</param>
		/// <param name="volume">Playback volume.</param>
		// Token: 0x06001467 RID: 5223 RVA: 0x0001A484 File Offset: 0x00018684
		[ExcludeFromDocs]
		public static void PlayClipAtPoint(AudioClip clip, Vector3 position)
		{
			float num = 1f;
			AudioSource.PlayClipAtPoint(clip, position, num);
		}

		/// <summary>
		///   <para>Plays an AudioClip at a given position in world space.</para>
		/// </summary>
		/// <param name="clip">Audio data to play.</param>
		/// <param name="position">Position in world space from which sound originates.</param>
		/// <param name="volume">Playback volume.</param>
		// Token: 0x06001468 RID: 5224 RVA: 0x0001A4A0 File Offset: 0x000186A0
		public static void PlayClipAtPoint(AudioClip clip, Vector3 position, [DefaultValue("1.0F")] float volume)
		{
			GameObject gameObject = new GameObject("One shot audio");
			gameObject.transform.position = position;
			AudioSource audioSource = (AudioSource)gameObject.AddComponent(typeof(AudioSource));
			audioSource.clip = clip;
			audioSource.spatialBlend = 1f;
			audioSource.volume = volume;
			audioSource.Play();
			Object.Destroy(gameObject, clip.length * ((Time.timeScale >= 0.01f) ? Time.timeScale : 0.01f));
		}

		/// <summary>
		///   <para>Is the audio clip looping?</para>
		/// </summary>
		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001469 RID: 5225
		// (set) Token: 0x0600146A RID: 5226
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
		///   <para>This makes the audio source not take into account the volume of the audio listener.</para>
		/// </summary>
		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x0600146B RID: 5227
		// (set) Token: 0x0600146C RID: 5228
		public extern bool ignoreListenerVolume
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>If set to true, the audio source will automatically start playing on awake.</para>
		/// </summary>
		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600146D RID: 5229
		// (set) Token: 0x0600146E RID: 5230
		public extern bool playOnAwake
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Allows AudioSource to play even though AudioListener.pause is set to true. This is useful for the menu element sounds or background music in pause menus.</para>
		/// </summary>
		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600146F RID: 5231
		// (set) Token: 0x06001470 RID: 5232
		public extern bool ignoreListenerPause
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Whether the Audio Source should be updated in the fixed or dynamic update.</para>
		/// </summary>
		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001471 RID: 5233
		// (set) Token: 0x06001472 RID: 5234
		public extern AudioVelocityUpdateMode velocityUpdateMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Pans a playing sound in a stereo way (left or right). This only applies to sounds that are Mono or Stereo.</para>
		/// </summary>
		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001473 RID: 5235
		// (set) Token: 0x06001474 RID: 5236
		public extern float panStereo
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Sets how much this AudioSource is affected by 3D spatialisation calculations (attenuation, doppler etc). 0.0 makes the sound full 2D, 1.0 makes it full 3D.</para>
		/// </summary>
		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001475 RID: 5237
		// (set) Token: 0x06001476 RID: 5238
		public extern float spatialBlend
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Enables or disables spatialization.</para>
		/// </summary>
		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001477 RID: 5239
		// (set) Token: 0x06001478 RID: 5240
		public extern bool spatialize
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Set the custom curve for the given AudioSourceCurveType.</para>
		/// </summary>
		/// <param name="type">The curve type that should be set.</param>
		/// <param name="curve">The curve that should be applied to the given curve type.</param>
		// Token: 0x06001479 RID: 5241
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve);

		/// <summary>
		///   <para>Get the current custom curve for the given AudioSourceCurveType.</para>
		/// </summary>
		/// <param name="type">The curve type to get.</param>
		/// <returns>
		///   <para>The custom AnimationCurve corresponding to the given curve type.</para>
		/// </returns>
		// Token: 0x0600147A RID: 5242
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AnimationCurve GetCustomCurve(AudioSourceCurveType type);

		/// <summary>
		///   <para>The amount by which the signal from the AudioSource will be mixed into the global reverb associated with the Reverb Zones.</para>
		/// </summary>
		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x0600147B RID: 5243
		// (set) Token: 0x0600147C RID: 5244
		public extern float reverbZoneMix
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Bypass effects (Applied from filter components or global listener filters).</para>
		/// </summary>
		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x0600147D RID: 5245
		// (set) Token: 0x0600147E RID: 5246
		public extern bool bypassEffects
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>When set global effects on the AudioListener will not be applied to the audio signal generated by the AudioSource. Does not apply if the AudioSource is playing into a mixer group.</para>
		/// </summary>
		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x0600147F RID: 5247
		// (set) Token: 0x06001480 RID: 5248
		public extern bool bypassListenerEffects
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>When set doesn't route the signal from an AudioSource into the global reverb associated with reverb zones.</para>
		/// </summary>
		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001481 RID: 5249
		// (set) Token: 0x06001482 RID: 5250
		public extern bool bypassReverbZones
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Sets the Doppler scale for this AudioSource.</para>
		/// </summary>
		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001483 RID: 5251
		// (set) Token: 0x06001484 RID: 5252
		public extern float dopplerLevel
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Sets the spread angle (in degrees) of a 3d stereo or multichannel sound in speaker space.</para>
		/// </summary>
		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001485 RID: 5253
		// (set) Token: 0x06001486 RID: 5254
		public extern float spread
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Sets the priority of the AudioSource.</para>
		/// </summary>
		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001487 RID: 5255
		// (set) Token: 0x06001488 RID: 5256
		public extern int priority
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Un- / Mutes the AudioSource. Mute sets the volume=0, Un-Mute restore the original volume.</para>
		/// </summary>
		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001489 RID: 5257
		// (set) Token: 0x0600148A RID: 5258
		public extern bool mute
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Within the Min distance the AudioSource will cease to grow louder in volume.</para>
		/// </summary>
		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x0600148B RID: 5259
		// (set) Token: 0x0600148C RID: 5260
		public extern float minDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>(Logarithmic rolloff) MaxDistance is the distance a sound stops attenuating at.</para>
		/// </summary>
		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x0600148D RID: 5261
		// (set) Token: 0x0600148E RID: 5262
		public extern float maxDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Sets/Gets how the AudioSource attenuates over distance.</para>
		/// </summary>
		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600148F RID: 5263
		// (set) Token: 0x06001490 RID: 5264
		public extern AudioRolloffMode rolloffMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06001491 RID: 5265
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetOutputDataHelper(float[] samples, int channel);

		/// <summary>
		///   <para>Returns a block of the currently playing source's output data.</para>
		/// </summary>
		/// <param name="numSamples"></param>
		/// <param name="channel"></param>
		// Token: 0x06001492 RID: 5266 RVA: 0x0001A524 File Offset: 0x00018724
		[Obsolete("GetOutputData return a float[] is deprecated, use GetOutputData passing a pre allocated array instead.")]
		public float[] GetOutputData(int numSamples, int channel)
		{
			float[] array = new float[numSamples];
			this.GetOutputDataHelper(array, channel);
			return array;
		}

		/// <summary>
		///   <para>Returns a block of the currently playing source's output data.</para>
		/// </summary>
		/// <param name="samples"></param>
		/// <param name="channel"></param>
		// Token: 0x06001493 RID: 5267 RVA: 0x00007D84 File Offset: 0x00005F84
		public void GetOutputData(float[] samples, int channel)
		{
			this.GetOutputDataHelper(samples, channel);
		}

		// Token: 0x06001494 RID: 5268
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetSpectrumDataHelper(float[] samples, int channel, FFTWindow window);

		/// <summary>
		///   <para>Returns a block of the currently playing source's spectrum data.</para>
		/// </summary>
		/// <param name="numSamples"></param>
		/// <param name="channel"></param>
		/// <param name="window"></param>
		// Token: 0x06001495 RID: 5269 RVA: 0x0001A544 File Offset: 0x00018744
		[Obsolete("GetSpectrumData returning a float[] is deprecated, use GetSpectrumData passing a pre allocated array instead.")]
		public float[] GetSpectrumData(int numSamples, int channel, FFTWindow window)
		{
			float[] array = new float[numSamples];
			this.GetSpectrumDataHelper(array, channel, window);
			return array;
		}

		/// <summary>
		///   <para>Returns a block of the currently playing source's spectrum data.</para>
		/// </summary>
		/// <param name="samples"></param>
		/// <param name="channel"></param>
		/// <param name="window"></param>
		// Token: 0x06001496 RID: 5270 RVA: 0x00007D8E File Offset: 0x00005F8E
		public void GetSpectrumData(float[] samples, int channel, FFTWindow window)
		{
			this.GetSpectrumDataHelper(samples, channel, window);
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001497 RID: 5271
		// (set) Token: 0x06001498 RID: 5272
		[Obsolete("minVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.", true)]
		public extern float minVolume
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001499 RID: 5273
		// (set) Token: 0x0600149A RID: 5274
		[Obsolete("maxVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.", true)]
		public extern float maxVolume
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x0600149B RID: 5275
		// (set) Token: 0x0600149C RID: 5276
		[Obsolete("rolloffFactor is not supported anymore. Use min-, maxDistance and rolloffMode instead.", true)]
		public extern float rolloffFactor
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Sets a user-defined parameter of a custom spatializer effect that is attached to an AudioSource.</para>
		/// </summary>
		/// <param name="index">Zero-based index of user-defined parameter to be set.</param>
		/// <param name="value">New value of the user-defined parameter.</param>
		/// <returns>
		///   <para>True, if the parameter could be set.</para>
		/// </returns>
		// Token: 0x0600149D RID: 5277
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool SetSpatializerFloat(int index, float value);

		// Token: 0x0600149E RID: 5278
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool GetSpatializerFloat(int index, out float value);
	}
}
