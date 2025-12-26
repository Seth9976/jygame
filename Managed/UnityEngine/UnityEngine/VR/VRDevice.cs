using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.VR
{
	/// <summary>
	///   <para>Contains all functionality related to a VR device.</para>
	/// </summary>
	// Token: 0x0200023D RID: 573
	public sealed class VRDevice
	{
		/// <summary>
		///   <para>Successfully detected a VR device in working order.</para>
		/// </summary>
		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06002033 RID: 8243
		public static extern bool isPresent
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The name of the family of the loaded VR device.</para>
		/// </summary>
		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06002034 RID: 8244
		public static extern string family
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Specific model of loaded VR device.</para>
		/// </summary>
		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06002035 RID: 8245
		public static extern string model
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Native pointer to the VR device structure, if available.</para>
		/// </summary>
		/// <returns>
		///   <para>Native pointer to VR device if available, else 0.</para>
		/// </returns>
		// Token: 0x06002036 RID: 8246
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr GetNativePtr();
	}
}
