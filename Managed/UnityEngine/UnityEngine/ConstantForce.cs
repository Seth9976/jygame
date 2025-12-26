using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A force applied constantly.</para>
	/// </summary>
	// Token: 0x0200010D RID: 269
	public sealed class ConstantForce : Behaviour
	{
		/// <summary>
		///   <para>The force applied to the rigidbody every frame.</para>
		/// </summary>
		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x00018D0C File Offset: 0x00016F0C
		// (set) Token: 0x0600104A RID: 4170 RVA: 0x0000732B File Offset: 0x0000552B
		public Vector3 force
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_force(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_force(ref value);
			}
		}

		// Token: 0x0600104B RID: 4171
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_force(out Vector3 value);

		// Token: 0x0600104C RID: 4172
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_force(ref Vector3 value);

		/// <summary>
		///   <para>The force - relative to the rigid bodies coordinate system - applied every frame.</para>
		/// </summary>
		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x00018D24 File Offset: 0x00016F24
		// (set) Token: 0x0600104E RID: 4174 RVA: 0x00007335 File Offset: 0x00005535
		public Vector3 relativeForce
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_relativeForce(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_relativeForce(ref value);
			}
		}

		// Token: 0x0600104F RID: 4175
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_relativeForce(out Vector3 value);

		// Token: 0x06001050 RID: 4176
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_relativeForce(ref Vector3 value);

		/// <summary>
		///   <para>The torque applied to the rigidbody every frame.</para>
		/// </summary>
		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x00018D3C File Offset: 0x00016F3C
		// (set) Token: 0x06001052 RID: 4178 RVA: 0x0000733F File Offset: 0x0000553F
		public Vector3 torque
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_torque(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_torque(ref value);
			}
		}

		// Token: 0x06001053 RID: 4179
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_torque(out Vector3 value);

		// Token: 0x06001054 RID: 4180
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_torque(ref Vector3 value);

		/// <summary>
		///   <para>The torque - relative to the rigid bodies coordinate system - applied every frame.</para>
		/// </summary>
		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x00018D54 File Offset: 0x00016F54
		// (set) Token: 0x06001056 RID: 4182 RVA: 0x00007349 File Offset: 0x00005549
		public Vector3 relativeTorque
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_relativeTorque(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_relativeTorque(ref value);
			}
		}

		// Token: 0x06001057 RID: 4183
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_relativeTorque(out Vector3 value);

		// Token: 0x06001058 RID: 4184
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_relativeTorque(ref Vector3 value);
	}
}
