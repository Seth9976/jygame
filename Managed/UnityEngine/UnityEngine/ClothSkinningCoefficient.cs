using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>The ClothSkinningCoefficient struct is used to set up how a Cloth component is allowed to move with respect to the SkinnedMeshRenderer it is attached to.</para>
	/// </summary>
	// Token: 0x020000FF RID: 255
	public struct ClothSkinningCoefficient
	{
		/// <summary>
		///   <para>Distance a vertex is allowed to travel from the skinned mesh vertex position.</para>
		/// </summary>
		// Token: 0x040002FE RID: 766
		public float maxDistance;

		/// <summary>
		///   <para>Definition of a sphere a vertex is not allowed to enter. This allows collision against the animated cloth.</para>
		/// </summary>
		// Token: 0x040002FF RID: 767
		public float collisionSphereDistance;
	}
}
