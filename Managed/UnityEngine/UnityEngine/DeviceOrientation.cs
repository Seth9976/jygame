using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Describes physical orientation of the device as determined by the OS.</para>
	/// </summary>
	// Token: 0x020000BD RID: 189
	public enum DeviceOrientation
	{
		/// <summary>
		///   <para>The orientation of the device cannot be determined.</para>
		/// </summary>
		// Token: 0x04000238 RID: 568
		Unknown,
		/// <summary>
		///   <para>The device is in portrait mode, with the device held upright and the home button at the bottom.</para>
		/// </summary>
		// Token: 0x04000239 RID: 569
		Portrait,
		/// <summary>
		///   <para>The device is in portrait mode but upside down, with the device held upright and the home button at the top.</para>
		/// </summary>
		// Token: 0x0400023A RID: 570
		PortraitUpsideDown,
		/// <summary>
		///   <para>The device is in landscape mode, with the device held upright and the home button on the right side.</para>
		/// </summary>
		// Token: 0x0400023B RID: 571
		LandscapeLeft,
		/// <summary>
		///   <para>The device is in landscape mode, with the device held upright and the home button on the left side.</para>
		/// </summary>
		// Token: 0x0400023C RID: 572
		LandscapeRight,
		/// <summary>
		///   <para>The device is held parallel to the ground with the screen facing upwards.</para>
		/// </summary>
		// Token: 0x0400023D RID: 573
		FaceUp,
		/// <summary>
		///   <para>The device is held parallel to the ground with the screen facing downwards.</para>
		/// </summary>
		// Token: 0x0400023E RID: 574
		FaceDown
	}
}
