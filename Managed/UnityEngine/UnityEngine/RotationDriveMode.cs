using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Control ConfigurableJoint's rotation with either X &amp; YZ or Slerp Drive.</para>
	/// </summary>
	// Token: 0x0200010B RID: 267
	public enum RotationDriveMode
	{
		/// <summary>
		///   <para>Use XY &amp; Z Drive.</para>
		/// </summary>
		// Token: 0x0400031E RID: 798
		XYAndZ,
		/// <summary>
		///   <para>Use Slerp drive.</para>
		/// </summary>
		// Token: 0x0400031F RID: 799
		Slerp
	}
}
