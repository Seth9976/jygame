using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>CollisionFlags is a bitmask returned by CharacterController.Move.</para>
	/// </summary>
	// Token: 0x020000FE RID: 254
	public enum CollisionFlags
	{
		/// <summary>
		///   <para>CollisionFlags is a bitmask returned by CharacterController.Move.</para>
		/// </summary>
		// Token: 0x040002F7 RID: 759
		None,
		/// <summary>
		///   <para>CollisionFlags is a bitmask returned by CharacterController.Move.</para>
		/// </summary>
		// Token: 0x040002F8 RID: 760
		Sides,
		/// <summary>
		///   <para>CollisionFlags is a bitmask returned by CharacterController.Move.</para>
		/// </summary>
		// Token: 0x040002F9 RID: 761
		Above,
		/// <summary>
		///   <para>CollisionFlags is a bitmask returned by CharacterController.Move.</para>
		/// </summary>
		// Token: 0x040002FA RID: 762
		Below = 4,
		// Token: 0x040002FB RID: 763
		CollidedSides = 1,
		// Token: 0x040002FC RID: 764
		CollidedAbove,
		// Token: 0x040002FD RID: 765
		CollidedBelow = 4
	}
}
