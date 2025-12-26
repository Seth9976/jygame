using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>(Legacy Particles) Script interface for particle emitters.</para>
	/// </summary>
	// Token: 0x020000E9 RID: 233
	public class ParticleEmitter : Component
	{
		// Token: 0x06000DD1 RID: 3537 RVA: 0x00002279 File Offset: 0x00000479
		internal ParticleEmitter()
		{
		}

		/// <summary>
		///   <para>Should particles be automatically emitted each frame?</para>
		/// </summary>
		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000DD2 RID: 3538
		// (set) Token: 0x06000DD3 RID: 3539
		public extern bool emit
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The minimum size each particle can be at the time when it is spawned.</para>
		/// </summary>
		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000DD4 RID: 3540
		// (set) Token: 0x06000DD5 RID: 3541
		public extern float minSize
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The maximum size each particle can be at the time when it is spawned.</para>
		/// </summary>
		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000DD6 RID: 3542
		// (set) Token: 0x06000DD7 RID: 3543
		public extern float maxSize
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The minimum lifetime of each particle, measured in seconds.</para>
		/// </summary>
		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000DD8 RID: 3544
		// (set) Token: 0x06000DD9 RID: 3545
		public extern float minEnergy
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The maximum lifetime of each particle, measured in seconds.</para>
		/// </summary>
		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000DDA RID: 3546
		// (set) Token: 0x06000DDB RID: 3547
		public extern float maxEnergy
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The minimum number of particles that will be spawned every second.</para>
		/// </summary>
		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000DDC RID: 3548
		// (set) Token: 0x06000DDD RID: 3549
		public extern float minEmission
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The maximum number of particles that will be spawned every second.</para>
		/// </summary>
		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000DDE RID: 3550
		// (set) Token: 0x06000DDF RID: 3551
		public extern float maxEmission
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The amount of the emitter's speed that the particles inherit.</para>
		/// </summary>
		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000DE0 RID: 3552
		// (set) Token: 0x06000DE1 RID: 3553
		public extern float emitterVelocityScale
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The starting speed of particles in world space, along X, Y, and Z.</para>
		/// </summary>
		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x00017F04 File Offset: 0x00016104
		// (set) Token: 0x06000DE3 RID: 3555 RVA: 0x00006B11 File Offset: 0x00004D11
		public Vector3 worldVelocity
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_worldVelocity(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_worldVelocity(ref value);
			}
		}

		// Token: 0x06000DE4 RID: 3556
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_worldVelocity(out Vector3 value);

		// Token: 0x06000DE5 RID: 3557
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_worldVelocity(ref Vector3 value);

		/// <summary>
		///   <para>The starting speed of particles along X, Y, and Z, measured in the object's orientation.</para>
		/// </summary>
		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x00017F1C File Offset: 0x0001611C
		// (set) Token: 0x06000DE7 RID: 3559 RVA: 0x00006B1B File Offset: 0x00004D1B
		public Vector3 localVelocity
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_localVelocity(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_localVelocity(ref value);
			}
		}

		// Token: 0x06000DE8 RID: 3560
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localVelocity(out Vector3 value);

		// Token: 0x06000DE9 RID: 3561
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localVelocity(ref Vector3 value);

		/// <summary>
		///   <para>A random speed along X, Y, and Z that is added to the velocity.</para>
		/// </summary>
		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x00017F34 File Offset: 0x00016134
		// (set) Token: 0x06000DEB RID: 3563 RVA: 0x00006B25 File Offset: 0x00004D25
		public Vector3 rndVelocity
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_rndVelocity(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_rndVelocity(ref value);
			}
		}

		// Token: 0x06000DEC RID: 3564
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rndVelocity(out Vector3 value);

		// Token: 0x06000DED RID: 3565
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_rndVelocity(ref Vector3 value);

		/// <summary>
		///   <para>If enabled, the particles don't move when the emitter moves. If false, when you move the emitter, the particles follow it around.</para>
		/// </summary>
		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000DEE RID: 3566
		// (set) Token: 0x06000DEF RID: 3567
		public extern bool useWorldSpace
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>If enabled, the particles will be spawned with random rotations.</para>
		/// </summary>
		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000DF0 RID: 3568
		// (set) Token: 0x06000DF1 RID: 3569
		public extern bool rndRotation
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The angular velocity of new particles in degrees per second.</para>
		/// </summary>
		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000DF2 RID: 3570
		// (set) Token: 0x06000DF3 RID: 3571
		public extern float angularVelocity
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>A random angular velocity modifier for new particles.</para>
		/// </summary>
		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000DF4 RID: 3572
		// (set) Token: 0x06000DF5 RID: 3573
		public extern float rndAngularVelocity
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Returns a copy of all particles and assigns an array of all particles to be the current particles.</para>
		/// </summary>
		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000DF6 RID: 3574
		// (set) Token: 0x06000DF7 RID: 3575
		public extern Particle[] particles
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The current number of particles (Read Only).</para>
		/// </summary>
		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000DF8 RID: 3576
		public extern int particleCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Removes all particles from the particle emitter.</para>
		/// </summary>
		// Token: 0x06000DF9 RID: 3577 RVA: 0x00006B2F File Offset: 0x00004D2F
		public void ClearParticles()
		{
			ParticleEmitter.INTERNAL_CALL_ClearParticles(this);
		}

		// Token: 0x06000DFA RID: 3578
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ClearParticles(ParticleEmitter self);

		/// <summary>
		///   <para>Emit a number of particles.</para>
		/// </summary>
		// Token: 0x06000DFB RID: 3579 RVA: 0x00006B37 File Offset: 0x00004D37
		public void Emit()
		{
			this.Emit2((int)Random.Range(this.minEmission, this.maxEmission));
		}

		/// <summary>
		///   <para>Emit count particles immediately.</para>
		/// </summary>
		/// <param name="count"></param>
		// Token: 0x06000DFC RID: 3580 RVA: 0x00006B51 File Offset: 0x00004D51
		public void Emit(int count)
		{
			this.Emit2(count);
		}

		/// <summary>
		///   <para>Emit a single particle with given parameters.</para>
		/// </summary>
		/// <param name="pos">The position of the particle.</param>
		/// <param name="velocity">The velocity of the particle.</param>
		/// <param name="size">The size of the particle.</param>
		/// <param name="energy">The remaining lifetime of the particle.</param>
		/// <param name="color">The color of the particle.</param>
		// Token: 0x06000DFD RID: 3581 RVA: 0x00017F4C File Offset: 0x0001614C
		public void Emit(Vector3 pos, Vector3 velocity, float size, float energy, Color color)
		{
			InternalEmitParticleArguments internalEmitParticleArguments = default(InternalEmitParticleArguments);
			internalEmitParticleArguments.pos = pos;
			internalEmitParticleArguments.velocity = velocity;
			internalEmitParticleArguments.size = size;
			internalEmitParticleArguments.energy = energy;
			internalEmitParticleArguments.color = color;
			internalEmitParticleArguments.rotation = 0f;
			internalEmitParticleArguments.angularVelocity = 0f;
			this.Emit3(ref internalEmitParticleArguments);
		}

		/// <summary>
		///   <para></para>
		/// </summary>
		/// <param name="rotation">The initial rotation of the particle in degrees.</param>
		/// <param name="angularVelocity">The angular velocity of the particle in degrees per second.</param>
		/// <param name="pos"></param>
		/// <param name="velocity"></param>
		/// <param name="size"></param>
		/// <param name="energy"></param>
		/// <param name="color"></param>
		// Token: 0x06000DFE RID: 3582 RVA: 0x00017FAC File Offset: 0x000161AC
		public void Emit(Vector3 pos, Vector3 velocity, float size, float energy, Color color, float rotation, float angularVelocity)
		{
			InternalEmitParticleArguments internalEmitParticleArguments = default(InternalEmitParticleArguments);
			internalEmitParticleArguments.pos = pos;
			internalEmitParticleArguments.velocity = velocity;
			internalEmitParticleArguments.size = size;
			internalEmitParticleArguments.energy = energy;
			internalEmitParticleArguments.color = color;
			internalEmitParticleArguments.rotation = rotation;
			internalEmitParticleArguments.angularVelocity = angularVelocity;
			this.Emit3(ref internalEmitParticleArguments);
		}

		// Token: 0x06000DFF RID: 3583
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Emit2(int count);

		// Token: 0x06000E00 RID: 3584
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Emit3(ref InternalEmitParticleArguments args);

		/// <summary>
		///   <para>Advance particle simulation by given time.</para>
		/// </summary>
		/// <param name="deltaTime"></param>
		// Token: 0x06000E01 RID: 3585
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Simulate(float deltaTime);

		/// <summary>
		///   <para>Turns the ParticleEmitter on or off.</para>
		/// </summary>
		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000E02 RID: 3586
		// (set) Token: 0x06000E03 RID: 3587
		public extern bool enabled
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
