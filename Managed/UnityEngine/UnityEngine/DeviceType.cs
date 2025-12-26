using System;

namespace UnityEngine
{
	/// <summary>
	///   <para>Enumeration for SystemInfo.deviceType, denotes a coarse grouping of kinds of devices.</para>
	/// </summary>
	// Token: 0x0200000C RID: 12
	public enum DeviceType
	{
		/// <summary>
		///   <para>Device type is unknown. You should never see this in practice.</para>
		/// </summary>
		// Token: 0x04000063 RID: 99
		Unknown,
		/// <summary>
		///   <para>A handheld device like mobile phone or a tablet.</para>
		/// </summary>
		// Token: 0x04000064 RID: 100
		Handheld,
		/// <summary>
		///   <para>A stationary gaming console.</para>
		/// </summary>
		// Token: 0x04000065 RID: 101
		Console,
		/// <summary>
		///   <para>Desktop or laptop computer.</para>
		/// </summary>
		// Token: 0x04000066 RID: 102
		Desktop
	}
}
