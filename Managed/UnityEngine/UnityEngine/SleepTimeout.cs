using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Constants for special values of Screen.sleepTimeout.</para>
	/// </summary>
	// Token: 0x02000035 RID: 53
	public sealed class SleepTimeout
	{
		/// <summary>
		///   <para>Prevent screen dimming.</para>
		/// </summary>
		// Token: 0x040000A2 RID: 162
		public const int NeverSleep = -1;

		/// <summary>
		///   <para>Set the sleep timeout to whatever the user has specified in the system settings.</para>
		/// </summary>
		// Token: 0x040000A3 RID: 163
		public const int SystemSetting = -2;
	}
}
