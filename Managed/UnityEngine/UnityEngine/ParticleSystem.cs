using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Script interface for particle systems (Shuriken).</para>
	/// </summary>
	// Token: 0x020000E1 RID: 225
	public sealed class ParticleSystem : Component
	{
		/// <summary>
		///   <para>Start delay in seconds.</para>
		/// </summary>
		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000D51 RID: 3409
		// (set) Token: 0x06000D52 RID: 3410
		public extern float startDelay
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Is the particle system playing right now ?</para>
		/// </summary>
		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000D53 RID: 3411
		public extern bool isPlaying
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Is the particle system stopped right now ?</para>
		/// </summary>
		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000D54 RID: 3412
		public extern bool isStopped
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Is the particle system paused right now ?</para>
		/// </summary>
		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000D55 RID: 3413
		public extern bool isPaused
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Is the particle system looping?</para>
		/// </summary>
		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000D56 RID: 3414
		// (set) Token: 0x06000D57 RID: 3415
		public extern bool loop
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>If set to true, the particle system will automatically start playing on startup.</para>
		/// </summary>
		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000D58 RID: 3416
		// (set) Token: 0x06000D59 RID: 3417
		public extern bool playOnAwake
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Playback position in seconds.</para>
		/// </summary>
		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000D5A RID: 3418
		// (set) Token: 0x06000D5B RID: 3419
		public extern float time
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The duration of the particle system in seconds (Read Only).</para>
		/// </summary>
		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000D5C RID: 3420
		public extern float duration
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The playback speed of the particle system. 1 is normal playback speed.</para>
		/// </summary>
		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000D5D RID: 3421
		// (set) Token: 0x06000D5E RID: 3422
		public extern float playbackSpeed
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
		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000D5F RID: 3423
		public extern int particleCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>When set to false, the particle system will not emit particles.</para>
		/// </summary>
		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000D60 RID: 3424
		// (set) Token: 0x06000D61 RID: 3425
		public extern bool enableEmission
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The rate of emission.</para>
		/// </summary>
		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000D62 RID: 3426
		// (set) Token: 0x06000D63 RID: 3427
		public extern float emissionRate
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The initial speed of particles when emitted. When using curves, this values acts as a scale on the curve.</para>
		/// </summary>
		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000D64 RID: 3428
		// (set) Token: 0x06000D65 RID: 3429
		public extern float startSpeed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The initial size of particles when emitted. When using curves, this values acts as a scale on the curve.</para>
		/// </summary>
		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000D66 RID: 3430
		// (set) Token: 0x06000D67 RID: 3431
		public extern float startSize
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The initial color of particles when emitted.</para>
		/// </summary>
		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00017B5C File Offset: 0x00015D5C
		// (set) Token: 0x06000D69 RID: 3433 RVA: 0x0000694C File Offset: 0x00004B4C
		public Color startColor
		{
			get
			{
				Color color;
				this.INTERNAL_get_startColor(out color);
				return color;
			}
			set
			{
				this.INTERNAL_set_startColor(ref value);
			}
		}

		// Token: 0x06000D6A RID: 3434
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_startColor(out Color value);

		// Token: 0x06000D6B RID: 3435
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_startColor(ref Color value);

		/// <summary>
		///   <para>The initial rotation of particles when emitted. When using curves, this values acts as a scale on the curve.</para>
		/// </summary>
		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000D6C RID: 3436
		// (set) Token: 0x06000D6D RID: 3437
		public extern float startRotation
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The total lifetime in seconds that particles will have when emitted. When using curves, this values acts as a scale on the curve. This value is set in the particle when it is create by the particle system.</para>
		/// </summary>
		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000D6E RID: 3438
		// (set) Token: 0x06000D6F RID: 3439
		public extern float startLifetime
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Scale being applied to the gravity defined by Physics.gravity.</para>
		/// </summary>
		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000D70 RID: 3440
		// (set) Token: 0x06000D71 RID: 3441
		public extern float gravityModifier
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The maximum number of particles to emit.</para>
		/// </summary>
		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000D72 RID: 3442
		// (set) Token: 0x06000D73 RID: 3443
		public extern int maxParticles
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>This selects the space in which to simulate particles. It can be either world or local space.</para>
		/// </summary>
		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000D74 RID: 3444
		// (set) Token: 0x06000D75 RID: 3445
		public extern ParticleSystemSimulationSpace simulationSpace
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Random seed used for the particle system emission. If set to 0, it will be assigned a random value on awake.</para>
		/// </summary>
		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000D76 RID: 3446
		// (set) Token: 0x06000D77 RID: 3447
		public extern uint randomSeed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000D78 RID: 3448
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetParticles(ParticleSystem.Particle[] particles, int size);

		// Token: 0x06000D79 RID: 3449
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetParticles(ParticleSystem.Particle[] particles);

		// Token: 0x06000D7A RID: 3450
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_Simulate(float t, bool restart);

		// Token: 0x06000D7B RID: 3451
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_Play();

		// Token: 0x06000D7C RID: 3452
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_Stop();

		// Token: 0x06000D7D RID: 3453
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_Pause();

		// Token: 0x06000D7E RID: 3454
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_Clear();

		// Token: 0x06000D7F RID: 3455
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool Internal_IsAlive();

		/// <summary>
		///   <para>Fastforwards the particle system by simulating particles over given period of time, then pauses it.</para>
		/// </summary>
		/// <param name="t">Time to fastforward the particle system.</param>
		/// <param name="withChildren">Fastforward all child particle systems as well.</param>
		/// <param name="restart">Restart and start from the beginning.</param>
		// Token: 0x06000D80 RID: 3456 RVA: 0x00017B74 File Offset: 0x00015D74
		[ExcludeFromDocs]
		public void Simulate(float t, bool withChildren)
		{
			bool flag = true;
			this.Simulate(t, withChildren, flag);
		}

		/// <summary>
		///   <para>Fastforwards the particle system by simulating particles over given period of time, then pauses it.</para>
		/// </summary>
		/// <param name="t">Time to fastforward the particle system.</param>
		/// <param name="withChildren">Fastforward all child particle systems as well.</param>
		/// <param name="restart">Restart and start from the beginning.</param>
		// Token: 0x06000D81 RID: 3457 RVA: 0x00017B8C File Offset: 0x00015D8C
		[ExcludeFromDocs]
		public void Simulate(float t)
		{
			bool flag = true;
			bool flag2 = true;
			this.Simulate(t, flag2, flag);
		}

		/// <summary>
		///   <para>Fastforwards the particle system by simulating particles over given period of time, then pauses it.</para>
		/// </summary>
		/// <param name="t">Time to fastforward the particle system.</param>
		/// <param name="withChildren">Fastforward all child particle systems as well.</param>
		/// <param name="restart">Restart and start from the beginning.</param>
		// Token: 0x06000D82 RID: 3458 RVA: 0x00017BA8 File Offset: 0x00015DA8
		public void Simulate(float t, [DefaultValue("true")] bool withChildren, [DefaultValue("true")] bool restart)
		{
			if (withChildren)
			{
				ParticleSystem[] particleSystems = ParticleSystem.GetParticleSystems(this);
				foreach (ParticleSystem particleSystem in particleSystems)
				{
					particleSystem.Internal_Simulate(t, restart);
				}
			}
			else
			{
				this.Internal_Simulate(t, restart);
			}
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00017BF4 File Offset: 0x00015DF4
		[ExcludeFromDocs]
		public void Play()
		{
			bool flag = true;
			this.Play(flag);
		}

		/// <summary>
		///   <para>Plays the particle system.</para>
		/// </summary>
		/// <param name="withChildren">Play all child particle systems as well.</param>
		// Token: 0x06000D84 RID: 3460 RVA: 0x00017C0C File Offset: 0x00015E0C
		public void Play([DefaultValue("true")] bool withChildren)
		{
			if (withChildren)
			{
				ParticleSystem[] particleSystems = ParticleSystem.GetParticleSystems(this);
				foreach (ParticleSystem particleSystem in particleSystems)
				{
					particleSystem.Internal_Play();
				}
			}
			else
			{
				this.Internal_Play();
			}
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00017C54 File Offset: 0x00015E54
		[ExcludeFromDocs]
		public void Stop()
		{
			bool flag = true;
			this.Stop(flag);
		}

		/// <summary>
		///   <para>Stops playing the particle system.</para>
		/// </summary>
		/// <param name="withChildren">Stop all child particle systems as well.</param>
		// Token: 0x06000D86 RID: 3462 RVA: 0x00017C6C File Offset: 0x00015E6C
		public void Stop([DefaultValue("true")] bool withChildren)
		{
			if (withChildren)
			{
				ParticleSystem[] particleSystems = ParticleSystem.GetParticleSystems(this);
				foreach (ParticleSystem particleSystem in particleSystems)
				{
					particleSystem.Internal_Stop();
				}
			}
			else
			{
				this.Internal_Stop();
			}
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00017CB4 File Offset: 0x00015EB4
		[ExcludeFromDocs]
		public void Pause()
		{
			bool flag = true;
			this.Pause(flag);
		}

		/// <summary>
		///   <para>Pauses playing the particle system.</para>
		/// </summary>
		/// <param name="withChildren">Pause all child particle systems as well.</param>
		// Token: 0x06000D88 RID: 3464 RVA: 0x00017CCC File Offset: 0x00015ECC
		public void Pause([DefaultValue("true")] bool withChildren)
		{
			if (withChildren)
			{
				ParticleSystem[] particleSystems = ParticleSystem.GetParticleSystems(this);
				foreach (ParticleSystem particleSystem in particleSystems)
				{
					particleSystem.Internal_Pause();
				}
			}
			else
			{
				this.Internal_Pause();
			}
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00017D14 File Offset: 0x00015F14
		[ExcludeFromDocs]
		public void Clear()
		{
			bool flag = true;
			this.Clear(flag);
		}

		/// <summary>
		///   <para>Remove all particles in the particle system.</para>
		/// </summary>
		/// <param name="withChildren">Clear all child particle systems as well.</param>
		// Token: 0x06000D8A RID: 3466 RVA: 0x00017D2C File Offset: 0x00015F2C
		public void Clear([DefaultValue("true")] bool withChildren)
		{
			if (withChildren)
			{
				ParticleSystem[] particleSystems = ParticleSystem.GetParticleSystems(this);
				foreach (ParticleSystem particleSystem in particleSystems)
				{
					particleSystem.Internal_Clear();
				}
			}
			else
			{
				this.Internal_Clear();
			}
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00017D74 File Offset: 0x00015F74
		[ExcludeFromDocs]
		public bool IsAlive()
		{
			bool flag = true;
			return this.IsAlive(flag);
		}

		/// <summary>
		///   <para>Does the system have any live particles (or will produce more)?</para>
		/// </summary>
		/// <param name="withChildren">Check all child particle systems as well.</param>
		/// <returns>
		///   <para>True if the particle system is still "alive", false if the particle system is done emitting particles and all particles are dead.</para>
		/// </returns>
		// Token: 0x06000D8C RID: 3468 RVA: 0x00017D8C File Offset: 0x00015F8C
		public bool IsAlive([DefaultValue("true")] bool withChildren)
		{
			if (withChildren)
			{
				ParticleSystem[] particleSystems = ParticleSystem.GetParticleSystems(this);
				foreach (ParticleSystem particleSystem in particleSystems)
				{
					if (particleSystem.Internal_IsAlive())
					{
						return true;
					}
				}
				return false;
			}
			return this.Internal_IsAlive();
		}

		/// <summary>
		///   <para>Emit count particles immediately.</para>
		/// </summary>
		/// <param name="count"></param>
		// Token: 0x06000D8D RID: 3469 RVA: 0x00006956 File Offset: 0x00004B56
		public void Emit(int count)
		{
			ParticleSystem.INTERNAL_CALL_Emit(this, count);
		}

		// Token: 0x06000D8E RID: 3470
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Emit(ParticleSystem self, int count);

		/// <summary>
		///   <para>Emit a single particle with given parameters.</para>
		/// </summary>
		/// <param name="position">The position of the particle.</param>
		/// <param name="velocity">The velocity of the particle.</param>
		/// <param name="size">The size of the particle.</param>
		/// <param name="lifetime">The remaining lifetime of the particle.</param>
		/// <param name="color">The color of the particle.</param>
		// Token: 0x06000D8F RID: 3471 RVA: 0x00017DD8 File Offset: 0x00015FD8
		public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color)
		{
			ParticleSystem.Particle particle = default(ParticleSystem.Particle);
			particle.position = position;
			particle.velocity = velocity;
			particle.lifetime = lifetime;
			particle.startLifetime = lifetime;
			particle.size = size;
			particle.rotation = 0f;
			particle.angularVelocity = 0f;
			particle.color = color;
			particle.randomSeed = 5U;
			this.Internal_Emit(ref particle);
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0000695F File Offset: 0x00004B5F
		public void Emit(ParticleSystem.Particle particle)
		{
			this.Internal_Emit(ref particle);
		}

		// Token: 0x06000D91 RID: 3473
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_Emit(ref ParticleSystem.Particle particle);

		// Token: 0x06000D92 RID: 3474 RVA: 0x00017E48 File Offset: 0x00016048
		internal static ParticleSystem[] GetParticleSystems(ParticleSystem root)
		{
			if (!root)
			{
				return null;
			}
			List<ParticleSystem> list = new List<ParticleSystem>();
			list.Add(root);
			ParticleSystem.GetDirectParticleSystemChildrenRecursive(root.transform, list);
			return list.ToArray();
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00017E84 File Offset: 0x00016084
		private static void GetDirectParticleSystemChildrenRecursive(Transform transform, List<ParticleSystem> particleSystems)
		{
			foreach (object obj in transform)
			{
				Transform transform2 = (Transform)obj;
				ParticleSystem component = transform2.gameObject.GetComponent<ParticleSystem>();
				if (component != null)
				{
					particleSystems.Add(component);
					ParticleSystem.GetDirectParticleSystemChildrenRecursive(transform2, particleSystems);
				}
			}
		}

		/// <summary>
		///   <para>Script interface for a Particle.</para>
		/// </summary>
		// Token: 0x020000E2 RID: 226
		public struct Particle
		{
			/// <summary>
			///   <para>The position of the particle.</para>
			/// </summary>
			// Token: 0x1700034D RID: 845
			// (get) Token: 0x06000D94 RID: 3476 RVA: 0x00006969 File Offset: 0x00004B69
			// (set) Token: 0x06000D95 RID: 3477 RVA: 0x00006971 File Offset: 0x00004B71
			public Vector3 position
			{
				get
				{
					return this.m_Position;
				}
				set
				{
					this.m_Position = value;
				}
			}

			/// <summary>
			///   <para>The velocity of the particle.</para>
			/// </summary>
			// Token: 0x1700034E RID: 846
			// (get) Token: 0x06000D96 RID: 3478 RVA: 0x0000697A File Offset: 0x00004B7A
			// (set) Token: 0x06000D97 RID: 3479 RVA: 0x00006982 File Offset: 0x00004B82
			public Vector3 velocity
			{
				get
				{
					return this.m_Velocity;
				}
				set
				{
					this.m_Velocity = value;
				}
			}

			/// <summary>
			///   <para>The lifetime of the particle.</para>
			/// </summary>
			// Token: 0x1700034F RID: 847
			// (get) Token: 0x06000D98 RID: 3480 RVA: 0x0000698B File Offset: 0x00004B8B
			// (set) Token: 0x06000D99 RID: 3481 RVA: 0x00006993 File Offset: 0x00004B93
			public float lifetime
			{
				get
				{
					return this.m_Lifetime;
				}
				set
				{
					this.m_Lifetime = value;
				}
			}

			/// <summary>
			///   <para>The starting lifetime of the particle.</para>
			/// </summary>
			// Token: 0x17000350 RID: 848
			// (get) Token: 0x06000D9A RID: 3482 RVA: 0x0000699C File Offset: 0x00004B9C
			// (set) Token: 0x06000D9B RID: 3483 RVA: 0x000069A4 File Offset: 0x00004BA4
			public float startLifetime
			{
				get
				{
					return this.m_StartLifetime;
				}
				set
				{
					this.m_StartLifetime = value;
				}
			}

			/// <summary>
			///   <para>The initial size of the particle. The current size of the particle is calculated procedurally based on this value and the active size modules.</para>
			/// </summary>
			// Token: 0x17000351 RID: 849
			// (get) Token: 0x06000D9C RID: 3484 RVA: 0x000069AD File Offset: 0x00004BAD
			// (set) Token: 0x06000D9D RID: 3485 RVA: 0x000069B5 File Offset: 0x00004BB5
			public float size
			{
				get
				{
					return this.m_Size;
				}
				set
				{
					this.m_Size = value;
				}
			}

			// Token: 0x17000352 RID: 850
			// (get) Token: 0x06000D9E RID: 3486 RVA: 0x000069BE File Offset: 0x00004BBE
			// (set) Token: 0x06000D9F RID: 3487 RVA: 0x000069C6 File Offset: 0x00004BC6
			public Vector3 axisOfRotation
			{
				get
				{
					return this.m_AxisOfRotation;
				}
				set
				{
					this.m_AxisOfRotation = value;
				}
			}

			/// <summary>
			///   <para>The rotation of the particle.</para>
			/// </summary>
			// Token: 0x17000353 RID: 851
			// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x000069CF File Offset: 0x00004BCF
			// (set) Token: 0x06000DA1 RID: 3489 RVA: 0x000069DD File Offset: 0x00004BDD
			public float rotation
			{
				get
				{
					return this.m_Rotation * 57.29578f;
				}
				set
				{
					this.m_Rotation = value * 0.017453292f;
				}
			}

			/// <summary>
			///   <para>The angular velocity of the particle.</para>
			/// </summary>
			// Token: 0x17000354 RID: 852
			// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x000069EC File Offset: 0x00004BEC
			// (set) Token: 0x06000DA3 RID: 3491 RVA: 0x000069FA File Offset: 0x00004BFA
			public float angularVelocity
			{
				get
				{
					return this.m_AngularVelocity * 57.29578f;
				}
				set
				{
					this.m_AngularVelocity = value * 0.017453292f;
				}
			}

			/// <summary>
			///   <para>The initial color of the particle. The current color of the particle is calculated procedurally based on this value and the active color modules.</para>
			/// </summary>
			// Token: 0x17000355 RID: 853
			// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x00006A09 File Offset: 0x00004C09
			// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x00006A11 File Offset: 0x00004C11
			public Color32 color
			{
				get
				{
					return this.m_Color;
				}
				set
				{
					this.m_Color = value;
				}
			}

			/// <summary>
			///   <para>The random value of the particle.</para>
			/// </summary>
			// Token: 0x17000356 RID: 854
			// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x00006A1A File Offset: 0x00004C1A
			// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x00006A2D File Offset: 0x00004C2D
			[Obsolete("randomValue property is deprecated. Use randomSeed instead to control random behavior of particles.")]
			public float randomValue
			{
				get
				{
					return BitConverter.ToSingle(BitConverter.GetBytes(this.m_RandomSeed), 0);
				}
				set
				{
					this.m_RandomSeed = BitConverter.ToUInt32(BitConverter.GetBytes(value), 0);
				}
			}

			/// <summary>
			///   <para>The random seed of the particle.</para>
			/// </summary>
			// Token: 0x17000357 RID: 855
			// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x00006A41 File Offset: 0x00004C41
			// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x00006A49 File Offset: 0x00004C49
			public uint randomSeed
			{
				get
				{
					return this.m_RandomSeed;
				}
				set
				{
					this.m_RandomSeed = value;
				}
			}

			// Token: 0x04000287 RID: 647
			private Vector3 m_Position;

			// Token: 0x04000288 RID: 648
			private Vector3 m_Velocity;

			// Token: 0x04000289 RID: 649
			private Vector3 m_AnimatedVelocity;

			// Token: 0x0400028A RID: 650
			private Vector3 m_AxisOfRotation;

			// Token: 0x0400028B RID: 651
			private float m_Rotation;

			// Token: 0x0400028C RID: 652
			private float m_AngularVelocity;

			// Token: 0x0400028D RID: 653
			private float m_Size;

			// Token: 0x0400028E RID: 654
			private Color32 m_Color;

			// Token: 0x0400028F RID: 655
			private uint m_RandomSeed;

			// Token: 0x04000290 RID: 656
			private float m_Lifetime;

			// Token: 0x04000291 RID: 657
			private float m_StartLifetime;

			// Token: 0x04000292 RID: 658
			private float m_EmitAccumulator0;

			// Token: 0x04000293 RID: 659
			private float m_EmitAccumulator1;
		}
	}
}
