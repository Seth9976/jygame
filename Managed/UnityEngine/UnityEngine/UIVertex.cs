using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Vertex class used by a Canvas for managing vertices.</para>
	/// </summary>
	// Token: 0x020001BE RID: 446
	public struct UIVertex
	{
		/// <summary>
		///   <para>Vertex position.</para>
		/// </summary>
		// Token: 0x04000569 RID: 1385
		public Vector3 position;

		/// <summary>
		///   <para>Normal.</para>
		/// </summary>
		// Token: 0x0400056A RID: 1386
		public Vector3 normal;

		/// <summary>
		///   <para>Vertex color.</para>
		/// </summary>
		// Token: 0x0400056B RID: 1387
		public Color32 color;

		/// <summary>
		///   <para>UV0.</para>
		/// </summary>
		// Token: 0x0400056C RID: 1388
		public Vector2 uv0;

		/// <summary>
		///   <para>UV1.</para>
		/// </summary>
		// Token: 0x0400056D RID: 1389
		public Vector2 uv1;

		/// <summary>
		///   <para>Tangent.</para>
		/// </summary>
		// Token: 0x0400056E RID: 1390
		public Vector4 tangent;

		// Token: 0x0400056F RID: 1391
		private static readonly Color32 s_DefaultColor = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

		// Token: 0x04000570 RID: 1392
		private static readonly Vector4 s_DefaultTangent = new Vector4(1f, 0f, 0f, -1f);

		/// <summary>
		///   <para>Simple UIVertex with sensible settings for use in the UI system.</para>
		/// </summary>
		// Token: 0x04000571 RID: 1393
		public static UIVertex simpleVert = new UIVertex
		{
			position = Vector3.zero,
			normal = Vector3.back,
			tangent = UIVertex.s_DefaultTangent,
			color = UIVertex.s_DefaultColor,
			uv0 = Vector2.zero,
			uv1 = Vector2.zero
		};
	}
}
