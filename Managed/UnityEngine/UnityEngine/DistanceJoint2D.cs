using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Joint that keeps two Rigidbody2D objects a fixed distance apart.</para>
	/// </summary>
	// Token: 0x02000132 RID: 306
	public sealed class DistanceJoint2D : AnchoredJoint2D
	{
		/// <summary>
		///   <para>The distance separating the two ends of the joint.</para>
		/// </summary>
		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060012AE RID: 4782
		// (set) Token: 0x060012AF RID: 4783
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
		///   <para>Whether to maintain a maximum distance only or not.  If not then the absolute distance will be maintained instead.</para>
		/// </summary>
		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060012B0 RID: 4784
		// (set) Token: 0x060012B1 RID: 4785
		public extern bool maxDistanceOnly
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
		// Token: 0x060012B2 RID: 4786 RVA: 0x0001A0FC File Offset: 0x000182FC
		public Vector2 GetReactionForce(float timeStep)
		{
			Vector2 vector;
			DistanceJoint2D.DistanceJoint2D_CUSTOM_INTERNAL_GetReactionForce(this, timeStep, out vector);
			return vector;
		}

		// Token: 0x060012B3 RID: 4787
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void DistanceJoint2D_CUSTOM_INTERNAL_GetReactionForce(DistanceJoint2D joint, float timeStep, out Vector2 value);

		/// <summary>
		///   <para>Gets the reaction torque of the joint given the specified timestep.</para>
		/// </summary>
		/// <param name="timeStep">The time to calculate the reaction torque for.</param>
		// Token: 0x060012B4 RID: 4788 RVA: 0x000079AF File Offset: 0x00005BAF
		public float GetReactionTorque(float timeStep)
		{
			return DistanceJoint2D.INTERNAL_CALL_GetReactionTorque(this, timeStep);
		}

		// Token: 0x060012B5 RID: 4789
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_GetReactionTorque(DistanceJoint2D self, float timeStep);
	}
}
