using System;

namespace UnityEngine.VR
{
	/// <summary>
	///   <para>Supported VR devices.</para>
	/// </summary>
	// Token: 0x0200023A RID: 570
	public enum VRDeviceType
	{
		/// <summary>
		///   <para>No VR Device.</para>
		/// </summary>
		// Token: 0x040008BB RID: 2235
		None,
		/// <summary>
		///   <para>Stereo 3D via D3D11 or OpenGL.</para>
		/// </summary>
		// Token: 0x040008BC RID: 2236
		Stereo,
		/// <summary>
		///   <para>Split screen stereo 3D (the left and right cameras are rendered side by side).</para>
		/// </summary>
		// Token: 0x040008BD RID: 2237
		Split,
		/// <summary>
		///   <para>Oculus family of VR devices.</para>
		/// </summary>
		// Token: 0x040008BE RID: 2238
		Oculus,
		/// <summary>
		///   <para>Sony's Project Morpheus VR device for Playstation 4.</para>
		/// </summary>
		// Token: 0x040008BF RID: 2239
		Morpheus
	}
}
