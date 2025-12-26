using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Representation of a listener in 3D space.</para>
	/// </summary>
	// Token: 0x02000158 RID: 344
	public sealed class AudioListener : Behaviour
	{
		/// <summary>
		///   <para>Controls the game sound volume (0.0 to 1.0).</para>
		/// </summary>
		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001440 RID: 5184
		// (set) Token: 0x06001441 RID: 5185
		public static extern float volume
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The paused state of the audio system.</para>
		/// </summary>
		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001442 RID: 5186
		// (set) Token: 0x06001443 RID: 5187
		public static extern bool pause
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>This lets you set whether the Audio Listener should be updated in the fixed or dynamic update.</para>
		/// </summary>
		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001444 RID: 5188
		// (set) Token: 0x06001445 RID: 5189
		public extern AudioVelocityUpdateMode velocityUpdateMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06001446 RID: 5190
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetOutputDataHelper(float[] samples, int channel);

		// Token: 0x06001447 RID: 5191
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetSpectrumDataHelper(float[] samples, int channel, FFTWindow window);

		/// <summary>
		///   <para>Returns a block of the listener (master)'s output data.</para>
		/// </summary>
		/// <param name="numSamples"></param>
		/// <param name="channel"></param>
		// Token: 0x06001448 RID: 5192 RVA: 0x0001A414 File Offset: 0x00018614
		[Obsolete("GetOutputData returning a float[] is deprecated, use GetOutputData and pass a pre allocated array instead.")]
		public static float[] GetOutputData(int numSamples, int channel)
		{
			float[] array = new float[numSamples];
			AudioListener.GetOutputDataHelper(array, channel);
			return array;
		}

		/// <summary>
		///   <para>Returns a block of the listener (master)'s output data.</para>
		/// </summary>
		/// <param name="samples"></param>
		/// <param name="channel"></param>
		// Token: 0x06001449 RID: 5193 RVA: 0x00007D61 File Offset: 0x00005F61
		public static void GetOutputData(float[] samples, int channel)
		{
			AudioListener.GetOutputDataHelper(samples, channel);
		}

		/// <summary>
		///   <para></para>
		/// </summary>
		/// <param name="numSamples"></param>
		/// <param name="channel"></param>
		/// <param name="window"></param>
		// Token: 0x0600144A RID: 5194 RVA: 0x0001A430 File Offset: 0x00018630
		[Obsolete("GetSpectrumData returning a float[] is deprecated, use GetOutputData and pass a pre allocated array instead.")]
		public static float[] GetSpectrumData(int numSamples, int channel, FFTWindow window)
		{
			float[] array = new float[numSamples];
			AudioListener.GetSpectrumDataHelper(array, channel, window);
			return array;
		}

		/// <summary>
		///   <para>Returns a block of the listener (master)'s spectrum data.</para>
		/// </summary>
		/// <param name="samples"></param>
		/// <param name="channel"></param>
		/// <param name="window"></param>
		// Token: 0x0600144B RID: 5195 RVA: 0x00007D6A File Offset: 0x00005F6A
		public static void GetSpectrumData(float[] samples, int channel, FFTWindow window)
		{
			AudioListener.GetSpectrumDataHelper(samples, channel, window);
		}
	}
}
