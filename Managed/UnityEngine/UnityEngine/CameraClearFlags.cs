using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Values for Camera.clearFlags, determining what to clear when rendering a Camera.</para>
	/// </summary>
	// Token: 0x0200026B RID: 619
	public enum CameraClearFlags
	{
		/// <summary>
		///   <para>Clear with the skybox.</para>
		/// </summary>
		// Token: 0x0400091B RID: 2331
		Skybox = 1,
		// Token: 0x0400091C RID: 2332
		Color,
		/// <summary>
		///   <para>Clear with a background color.</para>
		/// </summary>
		// Token: 0x0400091D RID: 2333
		SolidColor = 2,
		/// <summary>
		///   <para>Clear only the depth buffer.</para>
		/// </summary>
		// Token: 0x0400091E RID: 2334
		Depth,
		/// <summary>
		///   <para>Don't clear anything.</para>
		/// </summary>
		// Token: 0x0400091F RID: 2335
		Nothing
	}
}
