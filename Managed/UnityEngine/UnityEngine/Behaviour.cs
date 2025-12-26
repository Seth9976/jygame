using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Behaviours are Components that can be enabled or disabled.</para>
	/// </summary>
	// Token: 0x020000AD RID: 173
	public class Behaviour : Component
	{
		/// <summary>
		///   <para>Enabled Behaviours are Updated, disabled Behaviours are not.</para>
		/// </summary>
		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060009B9 RID: 2489
		// (set) Token: 0x060009BA RID: 2490
		public extern bool enabled
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Has the Behaviour had enabled called.</para>
		/// </summary>
		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060009BB RID: 2491
		public extern bool isActiveAndEnabled
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}
	}
}
