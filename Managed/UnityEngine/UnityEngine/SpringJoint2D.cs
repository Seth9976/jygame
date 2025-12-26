using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Joint that attempts to keep two Rigidbody2D objects a set distance apart by applying a force between them.</para>
	/// </summary>
	// Token: 0x02000131 RID: 305
	public sealed class SpringJoint2D : AnchoredJoint2D
	{
		/// <summary>
		///   <para>The distance the spring will try to keep between the two objects.</para>
		/// </summary>
		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060012A3 RID: 4771
		// (set) Token: 0x060012A4 RID: 4772
		public extern float distance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The amount by which the spring force is reduced in proportion to the movement speed.</para>
		/// </summary>
		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060012A5 RID: 4773
		// (set) Token: 0x060012A6 RID: 4774
		public extern float dampingRatio
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The frequency at which the spring oscillates around the distance distance between the objects.</para>
		/// </summary>
		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060012A7 RID: 4775
		// (set) Token: 0x060012A8 RID: 4776
		public extern float frequency
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Gets the reaction force of the joint given the specified timestep.</para>
		/// </summary>
		/// <param name="timeStep">The time to calculate the reaction force for.</param>
		// Token: 0x060012A9 RID: 4777 RVA: 0x0001A0E4 File Offset: 0x000182E4
		public Vector2 GetReactionForce(float timeStep)
		{
			Vector2 vector;
			SpringJoint2D.SpringJoint2D_CUSTOM_INTERNAL_GetReactionForce(this, timeStep, out vector);
			return vector;
		}

		// Token: 0x060012AA RID: 4778
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SpringJoint2D_CUSTOM_INTERNAL_GetReactionForce(SpringJoint2D joint, float timeStep, out Vector2 value);

		/// <summary>
		///   <para>Gets the reaction torque of the joint given the specified timestep.</para>
		/// </summary>
		/// <param name="timeStep">The time to calculate the reaction torque for.</param>
		// Token: 0x060012AB RID: 4779 RVA: 0x000079A6 File Offset: 0x00005BA6
		public float GetReactionTorque(float timeStep)
		{
			return SpringJoint2D.INTERNAL_CALL_GetReactionTorque(this, timeStep);
		}

		// Token: 0x060012AC RID: 4780
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_GetReactionTorque(SpringJoint2D self, float timeStep);
	}
}
