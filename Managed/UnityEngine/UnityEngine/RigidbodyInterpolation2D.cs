using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Interpolation mode for Rigidbody2D objects.</para>
	/// </summary>
	// Token: 0x0200011C RID: 284
	public enum RigidbodyInterpolation2D
	{
		/// <summary>
		///   <para>Do not apply any smoothing to the object's movement.</para>
		/// </summary>
		// Token: 0x04000337 RID: 823
		None,
		/// <summary>
		///   <para>Smooth movement based on the object's positions in previous frames.</para>
		/// </summary>
		// Token: 0x04000338 RID: 824
		Interpolate,
		/// <summary>
		///   <para>Smooth an object's movement based on an estimate of its position in the next frame.</para>
		/// </summary>
		// Token: 0x04000339 RID: 825
		Extrapolate
	}
}
