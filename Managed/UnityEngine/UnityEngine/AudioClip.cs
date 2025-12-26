using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A container for audio data.</para>
	/// </summary>
	// Token: 0x02000154 RID: 340
	public sealed class AudioClip : Object
	{
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600141C RID: 5148 RVA: 0x00007C9D File Offset: 0x00005E9D
		// (remove) Token: 0x0600141D RID: 5149 RVA: 0x00007CB6 File Offset: 0x00005EB6
		private event AudioClip.PCMReaderCallback m_PCMReaderCallback;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600141E RID: 5150 RVA: 0x00007CCF File Offset: 0x00005ECF
		// (remove) Token: 0x0600141F RID: 5151 RVA: 0x00007CE8 File Offset: 0x00005EE8
		private event AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback;

		/// <summary>
		///   <para>The length of the audio clip in seconds. (Read Only)</para>
		/// </summary>
		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001420 RID: 5152
		public extern float length
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The length of the audio clip in samples. (Read Only)</para>
		/// </summary>
		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001421 RID: 5153
		public extern int samples
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The number of channels in the audio clip. (Read Only)</para>
		/// </summary>
		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001422 RID: 5154
		public extern int channels
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The sample frequency of the clip in Hertz. (Read Only)</para>
		/// </summary>
		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001423 RID: 5155
		public extern int frequency
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns true if the AudioClip is ready to play (read-only).</para>
		/// </summary>
		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001424 RID: 5156
		[Obsolete("Use AudioClip.loadState instead to get more detailed information about the loading process.")]
		public extern bool isReadyToPlay
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The load type of the clip (read-only).</para>
		/// </summary>
		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001425 RID: 5157
		public extern AudioClipLoadType loadType
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Loads the audio data of a clip. Clips that have "Preload Audio Data" set will load the audio data automatically.</para>
		/// </summary>
		/// <returns>
		///   <para>Returns true if loading succeeded.</para>
		/// </returns>
		// Token: 0x06001426 RID: 5158
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool LoadAudioData();

		/// <summary>
		///   <para>Unloads the audio data associated with the clip. This works only for AudioClips that are based on actual sound file assets.</para>
		/// </summary>
		/// <returns>
		///   <para>Returns false if unloading failed.</para>
		/// </returns>
		// Token: 0x06001427 RID: 5159
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool UnloadAudioData();

		/// <summary>
		///   <para>Preloads audio data of the clip when the clip asset is loaded. When this flag is off, scripts have to call AudioClip.LoadAudioData() to load the data before the clip can be played. Properties like length, channels and format are available before the audio data has been loaded.</para>
		/// </summary>
		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001428 RID: 5160
		public extern bool preloadAudioData
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Returns the current load state of the audio data associated with an AudioClip.</para>
		/// </summary>
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001429 RID: 5161
		public extern AudioDataLoadState loadState
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Corresponding to the "Load In Background" flag in the inspector, when this flag is set, the loading will happen delayed without blocking the main thread.</para>
		/// </summary>
		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x0600142A RID: 5162
		public extern bool loadInBackground
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Fills an array with sample data from the clip.</para>
		/// </summary>
		/// <param name="data"></param>
		/// <param name="offsetSamples"></param>
		// Token: 0x0600142B RID: 5163
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool GetData(float[] data, int offsetSamples);

		/// <summary>
		///   <para>Set sample data in a clip.</para>
		/// </summary>
		/// <param name="data"></param>
		/// <param name="offsetSamples"></param>
		// Token: 0x0600142C RID: 5164
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool SetData(float[] data, int offsetSamples);

		/// <summary>
		///   <para>Creates a user AudioClip with a name and with the given length in samples, channels and frequency.</para>
		/// </summary>
		/// <param name="name">Name of clip.</param>
		/// <param name="lengthSamples">Number of sample frames.</param>
		/// <param name="channels">Number of channels per frame.</param>
		/// <param name="frequency">Sample frequency of clip.</param>
		/// <param name="_3D">Audio clip is played back in 3D.</param>
		/// <param name="stream">True if clip is streamed, that is if the pcmreadercallback generates data on the fly.</param>
		/// <param name="pcmreadercallback">This callback is invoked to generate a block of sample data. Non-streamed clips call this only once at creation time while streamed clips call this continuously.</param>
		/// <param name="pcmsetpositioncallback">This callback is invoked whenever the clip loops or changes playback position.</param>
		/// <returns>
		///   <para>A reference to the created AudioClip.</para>
		/// </returns>
		// Token: 0x0600142D RID: 5165 RVA: 0x00007D01 File Offset: 0x00005F01
		[Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream);
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x00007D0E File Offset: 0x00005F0E
		[Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, AudioClip.PCMReaderCallback pcmreadercallback)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, null);
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x00007D1E File Offset: 0x00005F1E
		[Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, pcmsetpositioncallback);
		}

		/// <summary>
		///   <para>Creates a user AudioClip with a name and with the given length in samples, channels and frequency.</para>
		/// </summary>
		/// <param name="name">Name of clip.</param>
		/// <param name="lengthSamples">Number of sample frames.</param>
		/// <param name="channels">Number of channels per frame.</param>
		/// <param name="frequency">Sample frequency of clip.</param>
		/// <param name="_3D">Audio clip is played back in 3D.</param>
		/// <param name="stream">True if clip is streamed, that is if the pcmreadercallback generates data on the fly.</param>
		/// <param name="pcmreadercallback">This callback is invoked to generate a block of sample data. Non-streamed clips call this only once at creation time while streamed clips call this continuously.</param>
		/// <param name="pcmsetpositioncallback">This callback is invoked whenever the clip loops or changes playback position.</param>
		/// <returns>
		///   <para>A reference to the created AudioClip.</para>
		/// </returns>
		// Token: 0x06001430 RID: 5168 RVA: 0x0001A338 File Offset: 0x00018538
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream, null, null);
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0001A354 File Offset: 0x00018554
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, null);
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0001A374 File Offset: 0x00018574
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback)
		{
			if (name == null)
			{
				throw new NullReferenceException();
			}
			if (lengthSamples <= 0)
			{
				throw new ArgumentException("Length of created clip must be larger than 0");
			}
			if (channels <= 0)
			{
				throw new ArgumentException("Number of channels in created clip must be greater than 0");
			}
			if (frequency <= 0)
			{
				throw new ArgumentException("Frequency in created clip must be greater than 0");
			}
			AudioClip audioClip = AudioClip.Construct_Internal();
			if (pcmreadercallback != null)
			{
				AudioClip audioClip2 = audioClip;
				audioClip2.m_PCMReaderCallback = (AudioClip.PCMReaderCallback)Delegate.Combine(audioClip2.m_PCMReaderCallback, pcmreadercallback);
			}
			if (pcmsetpositioncallback != null)
			{
				AudioClip audioClip3 = audioClip;
				audioClip3.m_PCMSetPositionCallback = (AudioClip.PCMSetPositionCallback)Delegate.Combine(audioClip3.m_PCMSetPositionCallback, pcmsetpositioncallback);
			}
			audioClip.Init_Internal(name, lengthSamples, channels, frequency, stream);
			return audioClip;
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00007D2F File Offset: 0x00005F2F
		private void InvokePCMReaderCallback_Internal(float[] data)
		{
			if (this.m_PCMReaderCallback != null)
			{
				this.m_PCMReaderCallback(data);
			}
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x00007D48 File Offset: 0x00005F48
		private void InvokePCMSetPositionCallback_Internal(int position)
		{
			if (this.m_PCMSetPositionCallback != null)
			{
				this.m_PCMSetPositionCallback(position);
			}
		}

		// Token: 0x06001435 RID: 5173
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AudioClip Construct_Internal();

		// Token: 0x06001436 RID: 5174
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Init_Internal(string name, int lengthSamples, int channels, int frequency, bool stream);

		/// <summary>
		///   <para>Delegate called each time AudioClip reads data.</para>
		/// </summary>
		/// <param name="data">Array of floats containing data read from the clip.</param>
		// Token: 0x02000155 RID: 341
		// (Invoke) Token: 0x06001438 RID: 5176
		public delegate void PCMReaderCallback(float[] data);

		/// <summary>
		///   <para>Delegate called each time AudioClip changes read position.</para>
		/// </summary>
		/// <param name="position">New position in the audio clip.</param>
		// Token: 0x02000156 RID: 342
		// (Invoke) Token: 0x0600143C RID: 5180
		public delegate void PCMSetPositionCallback(int position);
	}
}
