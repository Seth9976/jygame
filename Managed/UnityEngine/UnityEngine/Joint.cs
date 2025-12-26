using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Joint is the base class for all joints.</para>
	/// </summary>
	// Token: 0x02000105 RID: 261
	public class Joint : Component
	{
		/// <summary>
		///   <para>A reference to another rigidbody this joint connects to.</para>
		/// </summary>
		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000F87 RID: 3975
		// (set) Token: 0x06000F88 RID: 3976
		public extern Rigidbody connectedBody
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The Direction of the axis around which the body is constrained.</para>
		/// </summary>
		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x00018A0C File Offset: 0x00016C0C
		// (set) Token: 0x06000F8A RID: 3978 RVA: 0x000071E3 File Offset: 0x000053E3
		public Vector3 axis
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_axis(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_axis(ref value);
			}
		}

		// Token: 0x06000F8B RID: 3979
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_axis(out Vector3 value);

		// Token: 0x06000F8C RID: 3980
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_axis(ref Vector3 value);

		/// <summary>
		///   <para>The Position of the anchor around which the joints motion is constrained.</para>
		/// </summary>
		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x00018A24 File Offset: 0x00016C24
		// (set) Token: 0x06000F8E RID: 3982 RVA: 0x000071ED File Offset: 0x000053ED
		public Vector3 anchor
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_anchor(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_anchor(ref value);
			}
		}

		// Token: 0x06000F8F RID: 3983
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_anchor(out Vector3 value);

		// Token: 0x06000F90 RID: 3984
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_anchor(ref Vector3 value);

		/// <summary>
		///   <para>Position of the anchor relative to the connected Rigidbody.</para>
		/// </summary>
		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x00018A3C File Offset: 0x00016C3C
		// (set) Token: 0x06000F92 RID: 3986 RVA: 0x000071F7 File Offset: 0x000053F7
		public Vector3 connectedAnchor
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_connectedAnchor(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_connectedAnchor(ref value);
			}
		}

		// Token: 0x06000F93 RID: 3987
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_connectedAnchor(out Vector3 value);

		// Token: 0x06000F94 RID: 3988
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_connectedAnchor(ref Vector3 value);

		/// <summary>
		///   <para>Should the connectedAnchor be calculated automatically?</para>
		/// </summary>
		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000F95 RID: 3989
		// (set) Token: 0x06000F96 RID: 3990
		public extern bool autoConfigureConnectedAnchor
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The force that needs to be applied for this joint to break.</para>
		/// </summary>
		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000F97 RID: 3991
		// (set) Token: 0x06000F98 RID: 3992
		public extern float breakForce
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The torque that needs to be applied for this joint to break.</para>
		/// </summary>
		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000F99 RID: 3993
		// (set) Token: 0x06000F9A RID: 3994
		public extern float breakTorque
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Enable collision between bodies connected with the joint.</para>
		/// </summary>
		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000F9B RID: 3995
		// (set) Token: 0x06000F9C RID: 3996
		public extern bool enableCollision
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Toggle preprocessing for this joint.</para>
		/// </summary>
		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000F9D RID: 3997
		// (set) Token: 0x06000F9E RID: 3998
		public extern bool enablePreprocessing
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
