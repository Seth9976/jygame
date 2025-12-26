using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Settings for a Rigidbody2D's initial sleep state.</para>
	/// </summary>
	// Token: 0x0200011D RID: 285
	public enum RigidbodySleepMode2D
	{
		/// <summary>
		///   <para>Rigidbody2D never automatically sleeps.</para>
		/// </summary>
		// Token: 0x0400033B RID: 827
		NeverSleep,
		/// <summary>
		///   <para>Rigidbody2D is initially awake.</para>
		/// </summary>
		// Token: 0x0400033C RID: 828
		StartAwake,
		/// <summary>
		///   <para>Rigidbody2D is initially asleep.</para>
		/// </summary>
		// Token: 0x0400033D RID: 829
		StartAsleep
	}
}
