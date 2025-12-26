using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>The portal for dynamically changing occlusion at runtime.</para>
	/// </summary>
	// Token: 0x0200001A RID: 26
	public sealed class OcclusionPortal : Component
	{
		/// <summary>
		///   <para>Gets / sets the portal's open state.</para>
		/// </summary>
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600009B RID: 155
		// (set) Token: 0x0600009C RID: 156
		public extern bool open
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
