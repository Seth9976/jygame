using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Describes a single bounding sphere for use by a CullingGroup.</para>
	/// </summary>
	// Token: 0x02000048 RID: 72
	public struct BoundingSphere
	{
		/// <summary>
		///   <para>Initializes a BoundingSphere.</para>
		/// </summary>
		/// <param name="pos">The center of the sphere.</param>
		/// <param name="rad">The radius of the sphere.</param>
		/// <param name="packedSphere">A four-component vector containing the position (packed into the XYZ components) and radius (packed into the W component).</param>
		// Token: 0x060003FB RID: 1019 RVA: 0x00002AE5 File Offset: 0x00000CE5
		public BoundingSphere(Vector3 pos, float rad)
		{
			this.position = pos;
			this.radius = rad;
		}

		/// <summary>
		///   <para>Initializes a BoundingSphere.</para>
		/// </summary>
		/// <param name="pos">The center of the sphere.</param>
		/// <param name="rad">The radius of the sphere.</param>
		/// <param name="packedSphere">A four-component vector containing the position (packed into the XYZ components) and radius (packed into the W component).</param>
		// Token: 0x060003FC RID: 1020 RVA: 0x00002AF5 File Offset: 0x00000CF5
		public BoundingSphere(Vector4 packedSphere)
		{
			this.position = new Vector3(packedSphere.x, packedSphere.y, packedSphere.z);
			this.radius = packedSphere.w;
		}

		/// <summary>
		///   <para>The position of the center of the BoundingSphere.</para>
		/// </summary>
		// Token: 0x040000AF RID: 175
		public Vector3 position;

		/// <summary>
		///   <para>The radius of the BoundingSphere.</para>
		/// </summary>
		// Token: 0x040000B0 RID: 176
		public float radius;
	}
}
