using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Parent class for joints to connect Rigidbody2D objects.</para>
	/// </summary>
	// Token: 0x0200012F RID: 303
	public class Joint2D : Behaviour
	{
		/// <summary>
		///   <para>The Rigidbody2D object to which the other end of the joint is attached (ie, the object without the joint component).</para>
		/// </summary>
		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001295 RID: 4757
		// (set) Token: 0x06001296 RID: 4758
		public extern Rigidbody2D connectedBody
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should rigid bodies connected with this joint collide?</para>
		/// </summary>
		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001297 RID: 4759
		// (set) Token: 0x06001298 RID: 4760
		public extern bool enableCollision
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
