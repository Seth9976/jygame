using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Priority of a thread.</para>
	/// </summary>
	// Token: 0x02000013 RID: 19
	public enum ThreadPriority
	{
		/// <summary>
		///   <para>Lowest thread priority.</para>
		/// </summary>
		// Token: 0x0400006A RID: 106
		Low,
		/// <summary>
		///   <para>Below normal thread priority.</para>
		/// </summary>
		// Token: 0x0400006B RID: 107
		BelowNormal,
		/// <summary>
		///   <para>Normal thread priority.</para>
		/// </summary>
		// Token: 0x0400006C RID: 108
		Normal,
		/// <summary>
		///   <para>Highest thread priority.</para>
		/// </summary>
		// Token: 0x0400006D RID: 109
		High = 4
	}
}
