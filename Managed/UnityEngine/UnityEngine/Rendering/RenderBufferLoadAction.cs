using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>Handling of loading RenderBuffer contents on setting as active RenderTarget.</para>
	/// </summary>
	// Token: 0x0200027E RID: 638
	public enum RenderBufferLoadAction
	{
		/// <summary>
		///   <para>Make RenderBuffer to Load its contents when setting as RenderTarget.</para>
		/// </summary>
		// Token: 0x040009B4 RID: 2484
		Load,
		/// <summary>
		///   <para>RenderBuffer will try to skip loading its contents on setting as Render Target.</para>
		/// </summary>
		// Token: 0x040009B5 RID: 2485
		DontCare = 2
	}
}
