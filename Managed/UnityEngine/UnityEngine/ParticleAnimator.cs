using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>(Legacy Particles) Particle animators move your particles over time, you use them to apply wind, drag &amp; color cycling to your particle emitters.</para>
	/// </summary>
	// Token: 0x020000EC RID: 236
	public sealed class ParticleAnimator : Component
	{
		/// <summary>
		///   <para>Do particles cycle their color over their lifetime?</para>
		/// </summary>
		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000E07 RID: 3591
		// (set) Token: 0x06000E08 RID: 3592
		public extern bool doesAnimateColor
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>World space axis the particles rotate around.</para>
		/// </summary>
		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x00018008 File Offset: 0x00016208
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x00006B62 File Offset: 0x00004D62
		public Vector3 worldRotationAxis
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_worldRotationAxis(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_worldRotationAxis(ref value);
			}
		}

		// Token: 0x06000E0B RID: 3595
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_worldRotationAxis(out Vector3 value);

		// Token: 0x06000E0C RID: 3596
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_worldRotationAxis(ref Vector3 value);

		/// <summary>
		///   <para>Local space axis the particles rotate around.</para>
		/// </summary>
		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x00018020 File Offset: 0x00016220
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x00006B6C File Offset: 0x00004D6C
		public Vector3 localRotationAxis
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_localRotationAxis(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_localRotationAxis(ref value);
			}
		}

		// Token: 0x06000E0F RID: 3599
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localRotationAxis(out Vector3 value);

		// Token: 0x06000E10 RID: 3600
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localRotationAxis(ref Vector3 value);

		/// <summary>
		///   <para>How the particle sizes grow over their lifetime.</para>
		/// </summary>
		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000E11 RID: 3601
		// (set) Token: 0x06000E12 RID: 3602
		public extern float sizeGrow
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>A random force added to particles every frame.</para>
		/// </summary>
		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x00018038 File Offset: 0x00016238
		// (set) Token: 0x06000E14 RID: 3604 RVA: 0x00006B76 File Offset: 0x00004D76
		public Vector3 rndForce
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_rndForce(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_rndForce(ref value);
			}
		}

		// Token: 0x06000E15 RID: 3605
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rndForce(out Vector3 value);

		// Token: 0x06000E16 RID: 3606
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_rndForce(ref Vector3 value);

		/// <summary>
		///   <para>The force being applied to particles every frame.</para>
		/// </summary>
		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000E17 RID: 3607 RVA: 0x00018050 File Offset: 0x00016250
		// (set) Token: 0x06000E18 RID: 3608 RVA: 0x00006B80 File Offset: 0x00004D80
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

		// Token: 0x06000E19 RID: 3609
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_force(out Vector3 value);

		// Token: 0x06000E1A RID: 3610
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_force(ref Vector3 value);

		/// <summary>
		///   <para>How much particles are slowed down every frame.</para>
		/// </summary>
		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000E1B RID: 3611
		// (set) Token: 0x06000E1C RID: 3612
		public extern float damping
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Does the GameObject of this particle animator auto destructs?</para>
		/// </summary>
		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000E1D RID: 3613
		// (set) Token: 0x06000E1E RID: 3614
		public extern bool autodestruct
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Colors the particles will cycle through over their lifetime.</para>
		/// </summary>
		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000E1F RID: 3615
		// (set) Token: 0x06000E20 RID: 3616
		public extern Color[] colorAnimation
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
