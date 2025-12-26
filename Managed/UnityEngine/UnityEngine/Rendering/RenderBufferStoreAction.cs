using System;

namespace UnityEngine.Rendering
{
	/// <summary>
	///   <para>Handling of storing RenderBuffer contents after it was an active RenderTarget and another RenderTarget was set.</para>
	/// </summary>
	// Token: 0x0200027F RID: 639
	public enum RenderBufferStoreAction
	{
		/// <summary>
		///   <para>Make RenderBuffer to Store its contents.</para>
		/// </summary>
		// Token: 0x040009B7 RID: 2487
		Store,
		/// <summary>
		///   <para>RenderBuffer will try to skip storing its contents.</para>
		/// </summary>
		// Token: 0x040009B8 RID: 2488
		DontCare
	}
}
