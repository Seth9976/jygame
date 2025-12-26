using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Audio
{
	/// <summary>
	///   <para>Object representing a group in the mixer.</para>
	/// </summary>
	// Token: 0x02000168 RID: 360
	public class AudioMixerGroup : Object
	{
		// Token: 0x06001520 RID: 5408 RVA: 0x0000208E File Offset: 0x0000028E
		internal AudioMixerGroup()
		{
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001521 RID: 5409
		public extern AudioMixer audioMixer
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}
	}
}
