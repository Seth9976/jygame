using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Describes location service status.</para>
	/// </summary>
	// Token: 0x020000C1 RID: 193
	public enum LocationServiceStatus
	{
		/// <summary>
		///   <para>Location service is stopped.</para>
		/// </summary>
		// Token: 0x04000249 RID: 585
		Stopped,
		/// <summary>
		///   <para>Location service is initializing, some time later it will switch to.</para>
		/// </summary>
		// Token: 0x0400024A RID: 586
		Initializing,
		/// <summary>
		///   <para>Location service is running and locations could be queried.</para>
		/// </summary>
		// Token: 0x0400024B RID: 587
		Running,
		/// <summary>
		///   <para>Location service failed (user denied access to location service).</para>
		/// </summary>
		// Token: 0x0400024C RID: 588
		Failed
	}
}
