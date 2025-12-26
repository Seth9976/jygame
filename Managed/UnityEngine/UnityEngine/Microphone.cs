using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Use this class to record to an AudioClip using a connected microphone.</para>
	/// </summary>
	// Token: 0x02000165 RID: 357
	public sealed class Microphone
	{
		/// <summary>
		///   <para>Start Recording with device.</para>
		/// </summary>
		/// <param name="deviceName">The name of the device.</param>
		/// <param name="loop">Indicates whether the recording should continue recording if lengthSec is reached, and wrap around and record from the beginning of the AudioClip.</param>
		/// <param name="lengthSec">Is the length of the AudioClip produced by the recording.</param>
		/// <param name="frequency">The sample rate of the AudioClip produced by the recording.</param>
		/// <returns>
		///   <para>The function returns null if the recording fails to start.</para>
		/// </returns>
		// Token: 0x0600150D RID: 5389
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern AudioClip Start(string deviceName, bool loop, int lengthSec, int frequency);

		/// <summary>
		///   <para>Stops recording.</para>
		/// </summary>
		/// <param name="deviceName">The name of the device.</param>
		// Token: 0x0600150E RID: 5390
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void End(string deviceName);

		/// <summary>
		///   <para>A list of available microphone devices, identified by name.</para>
		/// </summary>
		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x0600150F RID: 5391
		public static extern string[] devices
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Query if a device is currently recording.</para>
		/// </summary>
		/// <param name="deviceName">The name of the device.</param>
		// Token: 0x06001510 RID: 5392
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsRecording(string deviceName);

		/// <summary>
		///   <para>Get the position in samples of the recording.</para>
		/// </summary>
		/// <param name="deviceName">The name of the device.</param>
		// Token: 0x06001511 RID: 5393
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetPosition(string deviceName);

		// Token: 0x06001512 RID: 5394
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetDeviceCaps(string deviceName, out int minFreq, out int maxFreq);
	}
}
