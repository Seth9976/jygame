using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Light Probe Group.</para>
	/// </summary>
	// Token: 0x02000055 RID: 85
	public sealed class LightProbeGroup : Component
	{
		/// <summary>
		///   <para>Editor only function to access and modify probe positions.</para>
		/// </summary>
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600047B RID: 1147
		// (set) Token: 0x0600047C RID: 1148
		public extern Vector3[] probePositions
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
