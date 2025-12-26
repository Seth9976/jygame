using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Control of an object's position through physics simulation.</para>
	/// </summary>
	// Token: 0x02000104 RID: 260
	public sealed class Rigidbody : Component
	{
		/// <summary>
		///   <para>The velocity vector of the rigidbody.</para>
		/// </summary>
		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x000187A8 File Offset: 0x000169A8
		// (set) Token: 0x06000F11 RID: 3857 RVA: 0x00007096 File Offset: 0x00005296
		public Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_velocity(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_velocity(ref value);
			}
		}

		// Token: 0x06000F12 RID: 3858
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_velocity(out Vector3 value);

		// Token: 0x06000F13 RID: 3859
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_velocity(ref Vector3 value);

		/// <summary>
		///   <para>The angular velocity vector of the rigidbody.</para>
		/// </summary>
		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x000187C0 File Offset: 0x000169C0
		// (set) Token: 0x06000F15 RID: 3861 RVA: 0x000070A0 File Offset: 0x000052A0
		public Vector3 angularVelocity
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_angularVelocity(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_angularVelocity(ref value);
			}
		}

		// Token: 0x06000F16 RID: 3862
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_angularVelocity(out Vector3 value);

		// Token: 0x06000F17 RID: 3863
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_angularVelocity(ref Vector3 value);

		/// <summary>
		///   <para>The drag of the object.</para>
		/// </summary>
		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000F18 RID: 3864
		// (set) Token: 0x06000F19 RID: 3865
		public extern float drag
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The angular drag of the object.</para>
		/// </summary>
		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000F1A RID: 3866
		// (set) Token: 0x06000F1B RID: 3867
		public extern float angularDrag
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The mass of the rigidbody.</para>
		/// </summary>
		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000F1C RID: 3868
		// (set) Token: 0x06000F1D RID: 3869
		public extern float mass
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Sets the mass based on the attached colliders assuming a constant density.</para>
		/// </summary>
		/// <param name="density"></param>
		// Token: 0x06000F1E RID: 3870 RVA: 0x000070AA File Offset: 0x000052AA
		public void SetDensity(float density)
		{
			Rigidbody.INTERNAL_CALL_SetDensity(this, density);
		}

		// Token: 0x06000F1F RID: 3871
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetDensity(Rigidbody self, float density);

		/// <summary>
		///   <para>Controls whether gravity affects this rigidbody.</para>
		/// </summary>
		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000F20 RID: 3872
		// (set) Token: 0x06000F21 RID: 3873
		public extern bool useGravity
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Maximum velocity of a rigidbody when moving out of penetrating state.</para>
		/// </summary>
		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000F22 RID: 3874
		// (set) Token: 0x06000F23 RID: 3875
		public extern float maxDepenetrationVelocity
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Controls whether physics affects the rigidbody.</para>
		/// </summary>
		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000F24 RID: 3876
		// (set) Token: 0x06000F25 RID: 3877
		public extern bool isKinematic
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Controls whether physics will change the rotation of the object.</para>
		/// </summary>
		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000F26 RID: 3878
		// (set) Token: 0x06000F27 RID: 3879
		public extern bool freezeRotation
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Controls which degrees of freedom are allowed for the simulation of this Rigidbody.</para>
		/// </summary>
		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000F28 RID: 3880
		// (set) Token: 0x06000F29 RID: 3881
		public extern RigidbodyConstraints constraints
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The Rigidbody's collision detection mode.</para>
		/// </summary>
		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000F2A RID: 3882
		// (set) Token: 0x06000F2B RID: 3883
		public extern CollisionDetectionMode collisionDetectionMode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Adds a force to the rigidbody.</para>
		/// </summary>
		/// <param name="force">Force vector in world coordinates.</param>
		/// <param name="mode"></param>
		// Token: 0x06000F2C RID: 3884 RVA: 0x000070B3 File Offset: 0x000052B3
		public void AddForce(Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			Rigidbody.INTERNAL_CALL_AddForce(this, ref force, mode);
		}

		/// <summary>
		///   <para>Adds a force to the rigidbody.</para>
		/// </summary>
		/// <param name="force">Force vector in world coordinates.</param>
		/// <param name="mode"></param>
		// Token: 0x06000F2D RID: 3885 RVA: 0x000187D8 File Offset: 0x000169D8
		[ExcludeFromDocs]
		public void AddForce(Vector3 force)
		{
			ForceMode forceMode = ForceMode.Force;
			Rigidbody.INTERNAL_CALL_AddForce(this, ref force, forceMode);
		}

		// Token: 0x06000F2E RID: 3886
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddForce(Rigidbody self, ref Vector3 force, ForceMode mode);

		/// <summary>
		///   <para>Adds a force to the rigidbody.</para>
		/// </summary>
		/// <param name="x">Size of force along the world x-axis.</param>
		/// <param name="y">Size of force along the world y-axis.</param>
		/// <param name="z">Size of force along the world z-axis.</param>
		/// <param name="mode"></param>
		// Token: 0x06000F2F RID: 3887 RVA: 0x000187F0 File Offset: 0x000169F0
		[ExcludeFromDocs]
		public void AddForce(float x, float y, float z)
		{
			ForceMode forceMode = ForceMode.Force;
			this.AddForce(x, y, z, forceMode);
		}

		/// <summary>
		///   <para>Adds a force to the rigidbody.</para>
		/// </summary>
		/// <param name="x">Size of force along the world x-axis.</param>
		/// <param name="y">Size of force along the world y-axis.</param>
		/// <param name="z">Size of force along the world z-axis.</param>
		/// <param name="mode"></param>
		// Token: 0x06000F30 RID: 3888 RVA: 0x000070BE File Offset: 0x000052BE
		public void AddForce(float x, float y, float z, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			this.AddForce(new Vector3(x, y, z), mode);
		}

		/// <summary>
		///   <para>Adds a force to the rigidbody relative to its coordinate system.</para>
		/// </summary>
		/// <param name="force">Force vector in local coordinates.</param>
		/// <param name="mode"></param>
		// Token: 0x06000F31 RID: 3889 RVA: 0x000070D0 File Offset: 0x000052D0
		public void AddRelativeForce(Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			Rigidbody.INTERNAL_CALL_AddRelativeForce(this, ref force, mode);
		}

		/// <summary>
		///   <para>Adds a force to the rigidbody relative to its coordinate system.</para>
		/// </summary>
		/// <param name="force">Force vector in local coordinates.</param>
		/// <param name="mode"></param>
		// Token: 0x06000F32 RID: 3890 RVA: 0x0001880C File Offset: 0x00016A0C
		[ExcludeFromDocs]
		public void AddRelativeForce(Vector3 force)
		{
			ForceMode forceMode = ForceMode.Force;
			Rigidbody.INTERNAL_CALL_AddRelativeForce(this, ref force, forceMode);
		}

		// Token: 0x06000F33 RID: 3891
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddRelativeForce(Rigidbody self, ref Vector3 force, ForceMode mode);

		/// <summary>
		///   <para>Adds a force to the rigidbody relative to its coordinate system.</para>
		/// </summary>
		/// <param name="x">Size of force along the local x-axis.</param>
		/// <param name="y">Size of force along the local y-axis.</param>
		/// <param name="z">Size of force along the local z-axis.</param>
		/// <param name="mode"></param>
		// Token: 0x06000F34 RID: 3892 RVA: 0x00018824 File Offset: 0x00016A24
		[ExcludeFromDocs]
		public void AddRelativeForce(float x, float y, float z)
		{
			ForceMode forceMode = ForceMode.Force;
			this.AddRelativeForce(x, y, z, forceMode);
		}

		/// <summary>
		///   <para>Adds a force to the rigidbody relative to its coordinate system.</para>
		/// </summary>
		/// <param name="x">Size of force along the local x-axis.</param>
		/// <param name="y">Size of force along the local y-axis.</param>
		/// <param name="z">Size of force along the local z-axis.</param>
		/// <param name="mode"></param>
		// Token: 0x06000F35 RID: 3893 RVA: 0x000070DB File Offset: 0x000052DB
		public void AddRelativeForce(float x, float y, float z, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			this.AddRelativeForce(new Vector3(x, y, z), mode);
		}

		/// <summary>
		///   <para>Adds a torque to the rigidbody.</para>
		/// </summary>
		/// <param name="torque">Torque vector in world coordinates.</param>
		/// <param name="mode"></param>
		// Token: 0x06000F36 RID: 3894 RVA: 0x000070ED File Offset: 0x000052ED
		public void AddTorque(Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			Rigidbody.INTERNAL_CALL_AddTorque(this, ref torque, mode);
		}

		/// <summary>
		///   <para>Adds a torque to the rigidbody.</para>
		/// </summary>
		/// <param name="torque">Torque vector in world coordinates.</param>
		/// <param name="mode"></param>
		// Token: 0x06000F37 RID: 3895 RVA: 0x00018840 File Offset: 0x00016A40
		[ExcludeFromDocs]
		public void AddTorque(Vector3 torque)
		{
			ForceMode forceMode = ForceMode.Force;
			Rigidbody.INTERNAL_CALL_AddTorque(this, ref torque, forceMode);
		}

		// Token: 0x06000F38 RID: 3896
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddTorque(Rigidbody self, ref Vector3 torque, ForceMode mode);

		/// <summary>
		///   <para>Adds a torque to the rigidbody.</para>
		/// </summary>
		/// <param name="x">Size of torque along the world x-axis.</param>
		/// <param name="y">Size of torque along the world y-axis.</param>
		/// <param name="z">Size of torque along the world z-axis.</param>
		/// <param name="mode"></param>
		// Token: 0x06000F39 RID: 3897 RVA: 0x00018858 File Offset: 0x00016A58
		[ExcludeFromDocs]
		public void AddTorque(float x, float y, float z)
		{
			ForceMode forceMode = ForceMode.Force;
			this.AddTorque(x, y, z, forceMode);
		}

		/// <summary>
		///   <para>Adds a torque to the rigidbody.</para>
		/// </summary>
		/// <param name="x">Size of torque along the world x-axis.</param>
		/// <param name="y">Size of torque along the world y-axis.</param>
		/// <param name="z">Size of torque along the world z-axis.</param>
		/// <param name="mode"></param>
		// Token: 0x06000F3A RID: 3898 RVA: 0x000070F8 File Offset: 0x000052F8
		public void AddTorque(float x, float y, float z, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			this.AddTorque(new Vector3(x, y, z), mode);
		}

		/// <summary>
		///   <para>Adds a torque to the rigidbody relative to its coordinate system.</para>
		/// </summary>
		/// <param name="torque">Torque vector in local coordinates.</param>
		/// <param name="mode"></param>
		// Token: 0x06000F3B RID: 3899 RVA: 0x0000710A File Offset: 0x0000530A
		public void AddRelativeTorque(Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			Rigidbody.INTERNAL_CALL_AddRelativeTorque(this, ref torque, mode);
		}

		/// <summary>
		///   <para>Adds a torque to the rigidbody relative to its coordinate system.</para>
		/// </summary>
		/// <param name="torque">Torque vector in local coordinates.</param>
		/// <param name="mode"></param>
		// Token: 0x06000F3C RID: 3900 RVA: 0x00018874 File Offset: 0x00016A74
		[ExcludeFromDocs]
		public void AddRelativeTorque(Vector3 torque)
		{
			ForceMode forceMode = ForceMode.Force;
			Rigidbody.INTERNAL_CALL_AddRelativeTorque(this, ref torque, forceMode);
		}

		// Token: 0x06000F3D RID: 3901
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddRelativeTorque(Rigidbody self, ref Vector3 torque, ForceMode mode);

		/// <summary>
		///   <para>Adds a torque to the rigidbody relative to its coordinate system.</para>
		/// </summary>
		/// <param name="x">Size of torque along the local x-axis.</param>
		/// <param name="y">Size of torque along the local y-axis.</param>
		/// <param name="z">Size of torque along the local z-axis.</param>
		/// <param name="mode"></param>
		// Token: 0x06000F3E RID: 3902 RVA: 0x0001888C File Offset: 0x00016A8C
		[ExcludeFromDocs]
		public void AddRelativeTorque(float x, float y, float z)
		{
			ForceMode forceMode = ForceMode.Force;
			this.AddRelativeTorque(x, y, z, forceMode);
		}

		/// <summary>
		///   <para>Adds a torque to the rigidbody relative to its coordinate system.</para>
		/// </summary>
		/// <param name="x">Size of torque along the local x-axis.</param>
		/// <param name="y">Size of torque along the local y-axis.</param>
		/// <param name="z">Size of torque along the local z-axis.</param>
		/// <param name="mode"></param>
		// Token: 0x06000F3F RID: 3903 RVA: 0x00007115 File Offset: 0x00005315
		public void AddRelativeTorque(float x, float y, float z, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			this.AddRelativeTorque(new Vector3(x, y, z), mode);
		}

		/// <summary>
		///   <para>Applies force at position. As a result this will apply a torque and force on the object.</para>
		/// </summary>
		/// <param name="force">Force vector in world coordinates.</param>
		/// <param name="position">Position in world coordinates.</param>
		/// <param name="mode"></param>
		// Token: 0x06000F40 RID: 3904 RVA: 0x00007127 File Offset: 0x00005327
		public void AddForceAtPosition(Vector3 force, Vector3 position, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			Rigidbody.INTERNAL_CALL_AddForceAtPosition(this, ref force, ref position, mode);
		}

		/// <summary>
		///   <para>Applies force at position. As a result this will apply a torque and force on the object.</para>
		/// </summary>
		/// <param name="force">Force vector in world coordinates.</param>
		/// <param name="position">Position in world coordinates.</param>
		/// <param name="mode"></param>
		// Token: 0x06000F41 RID: 3905 RVA: 0x000188A8 File Offset: 0x00016AA8
		[ExcludeFromDocs]
		public void AddForceAtPosition(Vector3 force, Vector3 position)
		{
			ForceMode forceMode = ForceMode.Force;
			Rigidbody.INTERNAL_CALL_AddForceAtPosition(this, ref force, ref position, forceMode);
		}

		// Token: 0x06000F42 RID: 3906
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddForceAtPosition(Rigidbody self, ref Vector3 force, ref Vector3 position, ForceMode mode);

		/// <summary>
		///   <para>Applies a force to a rigidbody that simulates explosion effects.</para>
		/// </summary>
		/// <param name="explosionForce">The force of the explosion (which may be modified by distance).</param>
		/// <param name="explosionPosition">The centre of the sphere within which the explosion has its effect.</param>
		/// <param name="explosionRadius">The radius of the sphere within which the explosion has its effect.</param>
		/// <param name="upwardsModifier">Adjustment to the apparent position of the explosion to make it seem to lift objects.</param>
		/// <param name="mode">The method used to apply the force to its targets.</param>
		// Token: 0x06000F43 RID: 3907 RVA: 0x00007134 File Offset: 0x00005334
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, [DefaultValue("0.0F")] float upwardsModifier, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
			Rigidbody.INTERNAL_CALL_AddExplosionForce(this, explosionForce, ref explosionPosition, explosionRadius, upwardsModifier, mode);
		}

		/// <summary>
		///   <para>Applies a force to a rigidbody that simulates explosion effects.</para>
		/// </summary>
		/// <param name="explosionForce">The force of the explosion (which may be modified by distance).</param>
		/// <param name="explosionPosition">The centre of the sphere within which the explosion has its effect.</param>
		/// <param name="explosionRadius">The radius of the sphere within which the explosion has its effect.</param>
		/// <param name="upwardsModifier">Adjustment to the apparent position of the explosion to make it seem to lift objects.</param>
		/// <param name="mode">The method used to apply the force to its targets.</param>
		// Token: 0x06000F44 RID: 3908 RVA: 0x000188C4 File Offset: 0x00016AC4
		[ExcludeFromDocs]
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier)
		{
			ForceMode forceMode = ForceMode.Force;
			Rigidbody.INTERNAL_CALL_AddExplosionForce(this, explosionForce, ref explosionPosition, explosionRadius, upwardsModifier, forceMode);
		}

		/// <summary>
		///   <para>Applies a force to a rigidbody that simulates explosion effects.</para>
		/// </summary>
		/// <param name="explosionForce">The force of the explosion (which may be modified by distance).</param>
		/// <param name="explosionPosition">The centre of the sphere within which the explosion has its effect.</param>
		/// <param name="explosionRadius">The radius of the sphere within which the explosion has its effect.</param>
		/// <param name="upwardsModifier">Adjustment to the apparent position of the explosion to make it seem to lift objects.</param>
		/// <param name="mode">The method used to apply the force to its targets.</param>
		// Token: 0x06000F45 RID: 3909 RVA: 0x000188E0 File Offset: 0x00016AE0
		[ExcludeFromDocs]
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius)
		{
			ForceMode forceMode = ForceMode.Force;
			float num = 0f;
			Rigidbody.INTERNAL_CALL_AddExplosionForce(this, explosionForce, ref explosionPosition, explosionRadius, num, forceMode);
		}

		// Token: 0x06000F46 RID: 3910
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_AddExplosionForce(Rigidbody self, float explosionForce, ref Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode);

		/// <summary>
		///   <para>The closest point to the bounding box of the attached colliders.</para>
		/// </summary>
		/// <param name="position"></param>
		// Token: 0x06000F47 RID: 3911 RVA: 0x00007144 File Offset: 0x00005344
		public Vector3 ClosestPointOnBounds(Vector3 position)
		{
			return Rigidbody.INTERNAL_CALL_ClosestPointOnBounds(this, ref position);
		}

		// Token: 0x06000F48 RID: 3912
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_ClosestPointOnBounds(Rigidbody self, ref Vector3 position);

		/// <summary>
		///   <para>The velocity relative to the rigidbody at the point relativePoint.</para>
		/// </summary>
		/// <param name="relativePoint"></param>
		// Token: 0x06000F49 RID: 3913 RVA: 0x0000714E File Offset: 0x0000534E
		public Vector3 GetRelativePointVelocity(Vector3 relativePoint)
		{
			return Rigidbody.INTERNAL_CALL_GetRelativePointVelocity(this, ref relativePoint);
		}

		// Token: 0x06000F4A RID: 3914
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_GetRelativePointVelocity(Rigidbody self, ref Vector3 relativePoint);

		/// <summary>
		///   <para>The velocity of the rigidbody at the point worldPoint in global space.</para>
		/// </summary>
		/// <param name="worldPoint"></param>
		// Token: 0x06000F4B RID: 3915 RVA: 0x00007158 File Offset: 0x00005358
		public Vector3 GetPointVelocity(Vector3 worldPoint)
		{
			return Rigidbody.INTERNAL_CALL_GetPointVelocity(this, ref worldPoint);
		}

		// Token: 0x06000F4C RID: 3916
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_GetPointVelocity(Rigidbody self, ref Vector3 worldPoint);

		/// <summary>
		///   <para>The center of mass relative to the transform's origin.</para>
		/// </summary>
		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x00018904 File Offset: 0x00016B04
		// (set) Token: 0x06000F4E RID: 3918 RVA: 0x00007162 File Offset: 0x00005362
		public Vector3 centerOfMass
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_centerOfMass(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_centerOfMass(ref value);
			}
		}

		// Token: 0x06000F4F RID: 3919
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_centerOfMass(out Vector3 value);

		// Token: 0x06000F50 RID: 3920
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_centerOfMass(ref Vector3 value);

		/// <summary>
		///   <para>The center of mass of the rigidbody in world space (Read Only).</para>
		/// </summary>
		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x0001891C File Offset: 0x00016B1C
		public Vector3 worldCenterOfMass
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_worldCenterOfMass(out vector);
				return vector;
			}
		}

		// Token: 0x06000F52 RID: 3922
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_worldCenterOfMass(out Vector3 value);

		/// <summary>
		///   <para>The rotation of the inertia tensor.</para>
		/// </summary>
		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x00018934 File Offset: 0x00016B34
		// (set) Token: 0x06000F54 RID: 3924 RVA: 0x0000716C File Offset: 0x0000536C
		public Quaternion inertiaTensorRotation
		{
			get
			{
				Quaternion quaternion;
				this.INTERNAL_get_inertiaTensorRotation(out quaternion);
				return quaternion;
			}
			set
			{
				this.INTERNAL_set_inertiaTensorRotation(ref value);
			}
		}

		// Token: 0x06000F55 RID: 3925
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_inertiaTensorRotation(out Quaternion value);

		// Token: 0x06000F56 RID: 3926
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_inertiaTensorRotation(ref Quaternion value);

		/// <summary>
		///   <para>The diagonal inertia tensor of mass relative to the center of mass.</para>
		/// </summary>
		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x0001894C File Offset: 0x00016B4C
		// (set) Token: 0x06000F58 RID: 3928 RVA: 0x00007176 File Offset: 0x00005376
		public Vector3 inertiaTensor
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_inertiaTensor(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_inertiaTensor(ref value);
			}
		}

		// Token: 0x06000F59 RID: 3929
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_inertiaTensor(out Vector3 value);

		// Token: 0x06000F5A RID: 3930
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_inertiaTensor(ref Vector3 value);

		/// <summary>
		///   <para>Should collision detection be enabled? (By default always enabled).</para>
		/// </summary>
		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000F5B RID: 3931
		// (set) Token: 0x06000F5C RID: 3932
		public extern bool detectCollisions
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Force cone friction to be used for this rigidbody.</para>
		/// </summary>
		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000F5D RID: 3933
		// (set) Token: 0x06000F5E RID: 3934
		public extern bool useConeFriction
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The position of the rigidbody.</para>
		/// </summary>
		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x00018964 File Offset: 0x00016B64
		// (set) Token: 0x06000F60 RID: 3936 RVA: 0x00007180 File Offset: 0x00005380
		public Vector3 position
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_position(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_position(ref value);
			}
		}

		// Token: 0x06000F61 RID: 3937
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_position(out Vector3 value);

		// Token: 0x06000F62 RID: 3938
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_position(ref Vector3 value);

		/// <summary>
		///   <para>The rotation of the rigdibody.</para>
		/// </summary>
		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x0001897C File Offset: 0x00016B7C
		// (set) Token: 0x06000F64 RID: 3940 RVA: 0x0000718A File Offset: 0x0000538A
		public Quaternion rotation
		{
			get
			{
				Quaternion quaternion;
				this.INTERNAL_get_rotation(out quaternion);
				return quaternion;
			}
			set
			{
				this.INTERNAL_set_rotation(ref value);
			}
		}

		// Token: 0x06000F65 RID: 3941
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rotation(out Quaternion value);

		// Token: 0x06000F66 RID: 3942
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_rotation(ref Quaternion value);

		/// <summary>
		///   <para>Moves the rigidbody to position.</para>
		/// </summary>
		/// <param name="position">The new position for the Rigidbody object.</param>
		// Token: 0x06000F67 RID: 3943 RVA: 0x00007194 File Offset: 0x00005394
		public void MovePosition(Vector3 position)
		{
			Rigidbody.INTERNAL_CALL_MovePosition(this, ref position);
		}

		// Token: 0x06000F68 RID: 3944
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_MovePosition(Rigidbody self, ref Vector3 position);

		/// <summary>
		///   <para>Rotates the rigidbody to rotation.</para>
		/// </summary>
		/// <param name="rot">The new rotation for the Rigidbody.</param>
		// Token: 0x06000F69 RID: 3945 RVA: 0x0000719E File Offset: 0x0000539E
		public void MoveRotation(Quaternion rot)
		{
			Rigidbody.INTERNAL_CALL_MoveRotation(this, ref rot);
		}

		// Token: 0x06000F6A RID: 3946
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_MoveRotation(Rigidbody self, ref Quaternion rot);

		/// <summary>
		///   <para>Interpolation allows you to smooth out the effect of running physics at a fixed frame rate.</para>
		/// </summary>
		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000F6B RID: 3947
		// (set) Token: 0x06000F6C RID: 3948
		public extern RigidbodyInterpolation interpolation
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Forces a rigidbody to sleep at least one frame.</para>
		/// </summary>
		// Token: 0x06000F6D RID: 3949 RVA: 0x000071A8 File Offset: 0x000053A8
		public void Sleep()
		{
			Rigidbody.INTERNAL_CALL_Sleep(this);
		}

		// Token: 0x06000F6E RID: 3950
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Sleep(Rigidbody self);

		/// <summary>
		///   <para>Is the rigidbody sleeping?</para>
		/// </summary>
		// Token: 0x06000F6F RID: 3951 RVA: 0x000071B0 File Offset: 0x000053B0
		public bool IsSleeping()
		{
			return Rigidbody.INTERNAL_CALL_IsSleeping(this);
		}

		// Token: 0x06000F70 RID: 3952
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_IsSleeping(Rigidbody self);

		/// <summary>
		///   <para>Forces a rigidbody to wake up.</para>
		/// </summary>
		// Token: 0x06000F71 RID: 3953 RVA: 0x000071B8 File Offset: 0x000053B8
		public void WakeUp()
		{
			Rigidbody.INTERNAL_CALL_WakeUp(this);
		}

		// Token: 0x06000F72 RID: 3954
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_WakeUp(Rigidbody self);

		/// <summary>
		///   <para>Allows you to override the solver iteration count per rigidbody.</para>
		/// </summary>
		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000F73 RID: 3955
		// (set) Token: 0x06000F74 RID: 3956
		public extern int solverIterationCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The linear velocity below which objects start going to sleep. (Default 0.14) range { 0, infinity }.</para>
		/// </summary>
		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000F75 RID: 3957
		// (set) Token: 0x06000F76 RID: 3958
		[Obsolete("The sleepVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.")]
		public extern float sleepVelocity
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The angular velocity below which objects start going to sleep.  (Default 0.14) range { 0, infinity }.</para>
		/// </summary>
		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000F77 RID: 3959
		// (set) Token: 0x06000F78 RID: 3960
		[Obsolete("The sleepAngularVelocity is no longer supported. Set Use sleepThreshold to specify energy.")]
		public extern float sleepAngularVelocity
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The mass-normalized energy threshold, below which objects start going to sleep.</para>
		/// </summary>
		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000F79 RID: 3961
		// (set) Token: 0x06000F7A RID: 3962
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
		///   <para>The maximimum angular velocity of the rigidbody. (Default 7) range { 0, infinity }.</para>
		/// </summary>
		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000F7B RID: 3963
		// (set) Token: 0x06000F7C RID: 3964
		public extern float maxAngularVelocity
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x000071C0 File Offset: 0x000053C0
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Rigidbody.INTERNAL_CALL_SweepTest(this, ref direction, out hitInfo, maxDistance, queryTriggerInteraction);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00018994 File Offset: 0x00016B94
		[ExcludeFromDocs]
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Rigidbody.INTERNAL_CALL_SweepTest(this, ref direction, out hitInfo, maxDistance, queryTriggerInteraction);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x000189B0 File Offset: 0x00016BB0
		[ExcludeFromDocs]
		public bool SweepTest(Vector3 direction, out RaycastHit hitInfo)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			float positiveInfinity = float.PositiveInfinity;
			return Rigidbody.INTERNAL_CALL_SweepTest(this, ref direction, out hitInfo, positiveInfinity, queryTriggerInteraction);
		}

		// Token: 0x06000F80 RID: 3968
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_SweepTest(Rigidbody self, ref Vector3 direction, out RaycastHit hitInfo, float maxDistance, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x06000F81 RID: 3969 RVA: 0x000071CE File Offset: 0x000053CE
		public RaycastHit[] SweepTestAll(Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
		{
			return Rigidbody.INTERNAL_CALL_SweepTestAll(this, ref direction, maxDistance, queryTriggerInteraction);
		}

		/// <summary>
		///   <para>Like Rigidbody.SweepTest, but returns all hits.</para>
		/// </summary>
		/// <param name="direction">Direction to sweep the Rigidbody object.</param>
		/// <param name="distance">Length of the sweep.</param>
		/// <param name="maxDistance"></param>
		/// <param name="queryTriggerInteraction"></param>
		// Token: 0x06000F82 RID: 3970 RVA: 0x000189D0 File Offset: 0x00016BD0
		[ExcludeFromDocs]
		public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			return Rigidbody.INTERNAL_CALL_SweepTestAll(this, ref direction, maxDistance, queryTriggerInteraction);
		}

		/// <summary>
		///   <para>Like Rigidbody.SweepTest, but returns all hits.</para>
		/// </summary>
		/// <param name="direction">Direction to sweep the Rigidbody object.</param>
		/// <param name="distance">Length of the sweep.</param>
		/// <param name="maxDistance"></param>
		/// <param name="queryTriggerInteraction"></param>
		// Token: 0x06000F83 RID: 3971 RVA: 0x000189EC File Offset: 0x00016BEC
		[ExcludeFromDocs]
		public RaycastHit[] SweepTestAll(Vector3 direction)
		{
			QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal;
			float positiveInfinity = float.PositiveInfinity;
			return Rigidbody.INTERNAL_CALL_SweepTestAll(this, ref direction, positiveInfinity, queryTriggerInteraction);
		}

		// Token: 0x06000F84 RID: 3972
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RaycastHit[] INTERNAL_CALL_SweepTestAll(Rigidbody self, ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x06000F85 RID: 3973 RVA: 0x000071DA File Offset: 0x000053DA
		[Obsolete("use Rigidbody.maxAngularVelocity instead.")]
		public void SetMaxAngularVelocity(float a)
		{
			this.maxAngularVelocity = a;
		}
	}
}
