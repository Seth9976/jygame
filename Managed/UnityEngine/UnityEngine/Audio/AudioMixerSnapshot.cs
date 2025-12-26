using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Audio
{
	/// <summary>
	///   <para>Object representing a snapshot in the mixer.</para>
	/// </summary>
	// Token: 0x02000167 RID: 359
	public class AudioMixerSnapshot : Object
	{
		// Token: 0x0600151D RID: 5405 RVA: 0x0000208E File Offset: 0x0000028E
		internal AudioMixerSnapshot()
		{
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x0600151E RID: 5406
		public extern AudioMixer audioMixer
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Performs an interpolated transition towards this snapshot over the time interval specified.</para>
		/// </summary>
		/// <param name="timeToReach">Relative time after which this snapshot should be reached from any current state.</param>
		// Token: 0x0600151F RID: 5407
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void TransitionTo(float timeToReach);
	}
}
