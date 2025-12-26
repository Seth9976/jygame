using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Describes screen orientation.</para>
	/// </summary>
	// Token: 0x02000273 RID: 627
	public enum ScreenOrientation
	{
		// Token: 0x04000943 RID: 2371
		Unknown,
		/// <summary>
		///   <para>Portrait orientation.</para>
		/// </summary>
		// Token: 0x04000944 RID: 2372
		Portrait,
		/// <summary>
		///   <para>Portrait orientation, upside down.</para>
		/// </summary>
		// Token: 0x04000945 RID: 2373
		PortraitUpsideDown,
		/// <summary>
		///   <para>Landscape orientation, counter-clockwise from the portrait orientation.</para>
		/// </summary>
		// Token: 0x04000946 RID: 2374
		LandscapeLeft,
		/// <summary>
		///   <para>Landscape orientation, clockwise from the portrait orientation.</para>
		/// </summary>
		// Token: 0x04000947 RID: 2375
		LandscapeRight,
		/// <summary>
		///   <para>Auto-rotates the screen as necessary toward any of the enabled orientations.</para>
		/// </summary>
		// Token: 0x04000948 RID: 2376
		AutoRotation,
		// Token: 0x04000949 RID: 2377
		Landscape = 3
	}
}
