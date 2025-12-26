using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Asset type that defines the surface properties of a Collider2D.</para>
	/// </summary>
	// Token: 0x02000136 RID: 310
	public sealed class PhysicsMaterial2D : Object
	{
		// Token: 0x060012F1 RID: 4849 RVA: 0x00007A18 File Offset: 0x00005C18
		public PhysicsMaterial2D()
		{
			PhysicsMaterial2D.Internal_Create(this, null);
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00007A27 File Offset: 0x00005C27
		public PhysicsMaterial2D(string name)
		{
			PhysicsMaterial2D.Internal_Create(this, name);
		}

		// Token: 0x060012F3 RID: 4851
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Create([Writable] PhysicsMaterial2D mat, string name);

		/// <summary>
		///   <para>The degree of elasticity during collisions.</para>
		/// </summary>
		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060012F4 RID: 4852
		// (set) Token: 0x060012F5 RID: 4853
		public extern float bounciness
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Coefficient of friction.</para>
		/// </summary>
		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060012F6 RID: 4854
		// (set) Token: 0x060012F7 RID: 4855
		public extern float friction
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
