using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Collider for 2D physics representing an circle.</para>
	/// </summary>
	// Token: 0x02000124 RID: 292
	public sealed class CircleCollider2D : Collider2D
	{
		/// <summary>
		///   <para>Radius of the circle.</para>
		/// </summary>
		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x0600125D RID: 4701
		// (set) Token: 0x0600125E RID: 4702
		public extern float radius
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
