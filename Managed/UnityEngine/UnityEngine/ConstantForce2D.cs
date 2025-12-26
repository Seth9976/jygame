using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Applies both linear and angular (torque) forces continuously to the rigidbody each physics update.</para>
	/// </summary>
	// Token: 0x02000138 RID: 312
	public sealed class ConstantForce2D : PhysicsUpdateBehaviour2D
	{
		/// <summary>
		///   <para>The linear force applied to the rigidbody each physics update.</para>
		/// </summary>
		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x0001A1BC File Offset: 0x000183BC
		// (set) Token: 0x060012FB RID: 4859 RVA: 0x00007A3E File Offset: 0x00005C3E
		public Vector2 force
		{
			get
			{
				Vector2 vector;
				this.INTERNAL_get_force(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_force(ref value);
			}
		}

		// Token: 0x060012FC RID: 4860
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_force(out Vector2 value);

		// Token: 0x060012FD RID: 4861
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_force(ref Vector2 value);

		/// <summary>
		///   <para>The linear force, relative to the rigid-body coordinate system, applied each physics update.</para>
		/// </summary>
		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x0001A1D4 File Offset: 0x000183D4
		// (set) Token: 0x060012FF RID: 4863 RVA: 0x00007A48 File Offset: 0x00005C48
		public Vector2 relativeForce
		{
			get
			{
				Vector2 vector;
				this.INTERNAL_get_relativeForce(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_relativeForce(ref value);
			}
		}

		// Token: 0x06001300 RID: 4864
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_relativeForce(out Vector2 value);

		// Token: 0x06001301 RID: 4865
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_relativeForce(ref Vector2 value);

		/// <summary>
		///   <para>The torque applied to the rigidbody each physics update.</para>
		/// </summary>
		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001302 RID: 4866
		// (set) Token: 0x06001303 RID: 4867
		public extern float torque
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
