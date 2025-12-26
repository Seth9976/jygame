using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Depth texture generation mode for Camera.</para>
	/// </summary>
	// Token: 0x0200026C RID: 620
	[Flags]
	public enum DepthTextureMode
	{
		/// <summary>
		///   <para>Do not generate depth texture (Default).</para>
		/// </summary>
		// Token: 0x04000921 RID: 2337
		None = 0,
		/// <summary>
		///   <para>Generate a depth texture.</para>
		/// </summary>
		// Token: 0x04000922 RID: 2338
		Depth = 1,
		/// <summary>
		///   <para>Generate a depth + normals texture.</para>
		/// </summary>
		// Token: 0x04000923 RID: 2339
		DepthNormals = 2
	}
}
