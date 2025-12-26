using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Rigidbody interpolation mode.</para>
	/// </summary>
	// Token: 0x020000F7 RID: 247
	public enum RigidbodyInterpolation
	{
		/// <summary>
		///   <para>No Interpolation.</para>
		/// </summary>
		// Token: 0x040002D5 RID: 725
		None,
		/// <summary>
		///   <para>Interpolation will always lag a little bit behind but can be smoother than extrapolation.</para>
		/// </summary>
		// Token: 0x040002D6 RID: 726
		Interpolate,
		/// <summary>
		///   <para>Extrapolation will predict the position of the rigidbody based on the current velocity.</para>
		/// </summary>
		// Token: 0x040002D7 RID: 727
		Extrapolate
	}
}
