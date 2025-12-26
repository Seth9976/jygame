using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Application installation mode (Read Only).</para>
	/// </summary>
	// Token: 0x020000AB RID: 171
	public enum ApplicationInstallMode
	{
		/// <summary>
		///   <para>Application install mode unknown.</para>
		/// </summary>
		// Token: 0x04000208 RID: 520
		Unknown,
		/// <summary>
		///   <para>Application installed via online store.</para>
		/// </summary>
		// Token: 0x04000209 RID: 521
		Store,
		/// <summary>
		///   <para>Application installed via developer build.</para>
		/// </summary>
		// Token: 0x0400020A RID: 522
		DeveloperBuild,
		/// <summary>
		///   <para>Application installed via ad hoc distribution.</para>
		/// </summary>
		// Token: 0x0400020B RID: 523
		Adhoc,
		/// <summary>
		///   <para>Application installed via enterprise distribution.</para>
		/// </summary>
		// Token: 0x0400020C RID: 524
		Enterprise,
		/// <summary>
		///   <para>Application running in editor.</para>
		/// </summary>
		// Token: 0x0400020D RID: 525
		Editor
	}
}
