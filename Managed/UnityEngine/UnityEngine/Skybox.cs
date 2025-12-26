using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A script interface for the.</para>
	/// </summary>
	// Token: 0x02000026 RID: 38
	public sealed class Skybox : Behaviour
	{
		/// <summary>
		///   <para>The material used by the skybox.</para>
		/// </summary>
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001DB RID: 475
		// (set) Token: 0x060001DC RID: 476
		public extern Material material
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
