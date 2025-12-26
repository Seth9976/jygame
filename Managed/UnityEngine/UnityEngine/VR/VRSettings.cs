using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.VR
{
	/// <summary>
	///   <para>Global VR related settings.</para>
	/// </summary>
	// Token: 0x0200023C RID: 572
	public sealed class VRSettings
	{
		/// <summary>
		///   <para>Globally enables or disables VR for the application.</para>
		/// </summary>
		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x0600202A RID: 8234
		// (set) Token: 0x0600202B RID: 8235
		public static extern bool enabled
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Mirror what is shown on the device to the main display, if possible.</para>
		/// </summary>
		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x0600202C RID: 8236
		// (set) Token: 0x0600202D RID: 8237
		public static extern bool showDeviceView
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Controls the texel:pixel ratio before lens correction, trading performance for sharpness.</para>
		/// </summary>
		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x0600202E RID: 8238
		// (set) Token: 0x0600202F RID: 8239
		public static extern float renderScale
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Type of VR device that is currently in use.</para>
		/// </summary>
		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06002030 RID: 8240
		// (set) Token: 0x06002031 RID: 8241
		public static extern VRDeviceType loadedDevice
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}
	}
}
