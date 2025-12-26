using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Application sandbox type.</para>
	/// </summary>
	// Token: 0x020000AC RID: 172
	public enum ApplicationSandboxType
	{
		/// <summary>
		///   <para>Application sandbox type is unknown.</para>
		/// </summary>
		// Token: 0x0400020F RID: 527
		Unknown,
		/// <summary>
		///   <para>Application not running in a sandbox.</para>
		/// </summary>
		// Token: 0x04000210 RID: 528
		NotSandboxed,
		/// <summary>
		///   <para>Application is running in a sandbox.</para>
		/// </summary>
		// Token: 0x04000211 RID: 529
		Sandboxed,
		/// <summary>
		///   <para>Application is running in broken sandbox.</para>
		/// </summary>
		// Token: 0x04000212 RID: 530
		SandboxBroken
	}
}
