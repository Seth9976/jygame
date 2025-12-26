using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>The Cloth class provides an interface to cloth simulation physics.</para>
	/// </summary>
	// Token: 0x02000119 RID: 281
	public sealed class Cloth : Component
	{
		/// <summary>
		///   <para>Cloth's sleep threshold.</para>
		/// </summary>
		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001100 RID: 4352
		// (set) Token: 0x06001101 RID: 4353
		public extern float sleepThreshold
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Bending stiffness of the cloth.</para>
		/// </summary>
		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001102 RID: 4354
		// (set) Token: 0x06001103 RID: 4355
		public extern float bendingStiffness
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Stretching stiffness of the cloth.</para>
		/// </summary>
		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001104 RID: 4356
		// (set) Token: 0x06001105 RID: 4357
		public extern float stretchingStiffness
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Damp cloth motion.</para>
		/// </summary>
		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001106 RID: 4358
		// (set) Token: 0x06001107 RID: 4359
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
		///   <para>A constant, external acceleration applied to the cloth.</para>
		/// </summary>
		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x00018FB0 File Offset: 0x000171B0
		// (set) Token: 0x06001109 RID: 4361 RVA: 0x0000755C File Offset: 0x0000575C
		public Vector3 externalAcceleration
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_externalAcceleration(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_externalAcceleration(ref value);
			}
		}

		// Token: 0x0600110A RID: 4362
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_externalAcceleration(out Vector3 value);

		// Token: 0x0600110B RID: 4363
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_externalAcceleration(ref Vector3 value);

		/// <summary>
		///   <para>A random, external acceleration applied to the cloth.</para>
		/// </summary>
		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x00018FC8 File Offset: 0x000171C8
		// (set) Token: 0x0600110D RID: 4365 RVA: 0x00007566 File Offset: 0x00005766
		public Vector3 randomAcceleration
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_randomAcceleration(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_randomAcceleration(ref value);
			}
		}

		// Token: 0x0600110E RID: 4366
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_randomAcceleration(out Vector3 value);

		// Token: 0x0600110F RID: 4367
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_randomAcceleration(ref Vector3 value);

		/// <summary>
		///   <para>Should gravity affect the cloth simulation?</para>
		/// </summary>
		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001110 RID: 4368
		// (set) Token: 0x06001111 RID: 4369
		public extern bool useGravity
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001112 RID: 4370
		// (set) Token: 0x06001113 RID: 4371
		[Obsolete("Deprecated. Cloth.selfCollisions is no longer supported since Unity 5.0.", true)]
		public extern bool selfCollision
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Is this cloth enabled?</para>
		/// </summary>
		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001114 RID: 4372
		// (set) Token: 0x06001115 RID: 4373
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
		///   <para>The current vertex positions of the cloth object.</para>
		/// </summary>
		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001116 RID: 4374
		public extern Vector3[] vertices
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The current normals of the cloth object.</para>
		/// </summary>
		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001117 RID: 4375
		public extern Vector3[] normals
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The friction of the cloth when colliding with the character.</para>
		/// </summary>
		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06001118 RID: 4376
		// (set) Token: 0x06001119 RID: 4377
		public extern float friction
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>How much to increase mass of colliding particles.</para>
		/// </summary>
		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x0600111A RID: 4378
		// (set) Token: 0x0600111B RID: 4379
		public extern float collisionMassScale
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Enable continuous collision to improve collision stability.</para>
		/// </summary>
		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x0600111C RID: 4380
		// (set) Token: 0x0600111D RID: 4381
		public extern float useContinuousCollision
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Add one virtual particle per triangle to improve collision stability.</para>
		/// </summary>
		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x0600111E RID: 4382
		// (set) Token: 0x0600111F RID: 4383
		public extern float useVirtualParticles
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Clear the pending transform changes from affecting the cloth simulation.</para>
		/// </summary>
		// Token: 0x06001120 RID: 4384 RVA: 0x00007570 File Offset: 0x00005770
		public void ClearTransformMotion()
		{
			Cloth.INTERNAL_CALL_ClearTransformMotion(this);
		}

		// Token: 0x06001121 RID: 4385
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ClearTransformMotion(Cloth self);

		/// <summary>
		///   <para>The cloth skinning coefficients used to set up how the cloth interacts with the skinned mesh.</para>
		/// </summary>
		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001122 RID: 4386
		// (set) Token: 0x06001123 RID: 4387
		public extern ClothSkinningCoefficient[] coefficients
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>How much world-space movement of the character will affect cloth vertices.</para>
		/// </summary>
		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001124 RID: 4388
		// (set) Token: 0x06001125 RID: 4389
		public extern float worldVelocityScale
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>How much world-space acceleration of the character will affect cloth vertices.</para>
		/// </summary>
		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001126 RID: 4390
		// (set) Token: 0x06001127 RID: 4391
		public extern float worldAccelerationScale
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Fade the cloth simulation in or out.</para>
		/// </summary>
		/// <param name="enabled">Fading enabled or not.</param>
		/// <param name="interpolationTime"></param>
		// Token: 0x06001128 RID: 4392
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetEnabledFading(bool enabled, [DefaultValue("0.5f")] float interpolationTime);

		// Token: 0x06001129 RID: 4393 RVA: 0x00018FE0 File Offset: 0x000171E0
		[ExcludeFromDocs]
		public void SetEnabledFading(bool enabled)
		{
			float num = 0.5f;
			this.SetEnabledFading(enabled, num);
		}

		/// <summary>
		///   <para>Number of solver iterations per second.</para>
		/// </summary>
		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x0600112A RID: 4394
		// (set) Token: 0x0600112B RID: 4395
		public extern bool solverFrequency
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>An array of CapsuleColliders which this Cloth instance should collide with.</para>
		/// </summary>
		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x0600112C RID: 4396
		// (set) Token: 0x0600112D RID: 4397
		public extern CapsuleCollider[] capsuleColliders
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>An array of ClothSphereColliderPairs which this Cloth instance should collide with.</para>
		/// </summary>
		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x0600112E RID: 4398
		// (set) Token: 0x0600112F RID: 4399
		public extern ClothSphereColliderPair[] sphereColliders
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
