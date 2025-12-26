using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Controls the global audio settings from script.</para>
	/// </summary>
	// Token: 0x0200014F RID: 335
	public sealed class AudioSettings
	{
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06001409 RID: 5129 RVA: 0x00007C4F File Offset: 0x00005E4F
		// (remove) Token: 0x0600140A RID: 5130 RVA: 0x00007C66 File Offset: 0x00005E66
		public static event AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged;

		/// <summary>
		///   <para>Returns the speaker mode capability of the current audio driver. (Read Only)</para>
		/// </summary>
		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x0600140B RID: 5131
		public static extern AudioSpeakerMode driverCapabilities
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Gets the current speaker mode. Default is 2 channel stereo.</para>
		/// </summary>
		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x0600140C RID: 5132
		// (set) Token: 0x0600140D RID: 5133
		public static extern AudioSpeakerMode speakerMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Returns the current time of the audio system.</para>
		/// </summary>
		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x0600140E RID: 5134
		public static extern double dspTime
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Get the mixer's current output rate.</para>
		/// </summary>
		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600140F RID: 5135
		// (set) Token: 0x06001410 RID: 5136
		public static extern int outputSampleRate
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06001411 RID: 5137
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetDSPBufferSize(out int bufferLength, out int numBuffers);

		// Token: 0x06001412 RID: 5138
		[Obsolete("AudioSettings.SetDSPBufferSize is deprecated and has been replaced by audio project settings and the AudioSettings.GetConfiguration/AudioSettings.Reset API.")]
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetDSPBufferSize(int bufferLength, int numBuffers);

		/// <summary>
		///   <para>Returns the current configuration of the audio device and system. The values in the struct may then be modified and reapplied via AudioSettings.Reset.</para>
		/// </summary>
		/// <returns>
		///   <para>The new configuration to be applied.</para>
		/// </returns>
		// Token: 0x06001413 RID: 5139
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern AudioConfiguration GetConfiguration();

		/// <summary>
		///   <para>Performs a change of the device configuration. In response to this the AudioSettings.OnAudioConfigurationChanged delegate is invoked with the argument deviceWasChanged=false. It cannot be guaranteed that the exact settings specified can be used, but the an attempt is made to use the closest match supported by the system.</para>
		/// </summary>
		/// <param name="config">The new configuration to be used.</param>
		/// <returns>
		///   <para>True if all settings could be successfully applied.</para>
		/// </returns>
		// Token: 0x06001414 RID: 5140 RVA: 0x00007C7D File Offset: 0x00005E7D
		public static bool Reset(AudioConfiguration config)
		{
			return AudioSettings.INTERNAL_CALL_Reset(ref config);
		}

		// Token: 0x06001415 RID: 5141
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Reset(ref AudioConfiguration config);

		// Token: 0x06001416 RID: 5142 RVA: 0x00007C86 File Offset: 0x00005E86
		internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged)
		{
			if (AudioSettings.OnAudioConfigurationChanged != null)
			{
				AudioSettings.OnAudioConfigurationChanged(deviceWasChanged);
			}
		}

		/// <summary>
		///   <para>A delegate called whenever the global audio settings are changed, either by AudioSettings.Reset or by an external device change such as the OS control panel changing the sample rate or because the default output device was changed, for example when plugging in an HDMI monitor or a USB headset.</para>
		/// </summary>
		/// <param name="deviceWasChanged">True if the change was caused by an device change.</param>
		// Token: 0x02000150 RID: 336
		// (Invoke) Token: 0x06001418 RID: 5144
		public delegate void AudioConfigurationChangeHandler(bool deviceWasChanged);
	}
}
