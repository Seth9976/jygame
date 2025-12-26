using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Describes whether a touch is direct, indirect (or remote), or from a stylus.</para>
	/// </summary>
	// Token: 0x020000BB RID: 187
	public enum TouchType
	{
		/// <summary>
		///   <para>A direct touch on a device.</para>
		/// </summary>
		// Token: 0x04000226 RID: 550
		Direct,
		/// <summary>
		///   <para>An Indirect, or remote, touch on a device.</para>
		/// </summary>
		// Token: 0x04000227 RID: 551
		Indirect,
		/// <summary>
		///   <para>A touch from a stylus on a device.</para>
		/// </summary>
		// Token: 0x04000228 RID: 552
		Stylus
	}
}
