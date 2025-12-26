using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Specifies the operational state of a network interface.</summary>
	// Token: 0x020003C6 RID: 966
	public enum OperationalStatus
	{
		/// <summary>The network interface is up; it can transmit data packets.</summary>
		// Token: 0x0400142C RID: 5164
		Up = 1,
		/// <summary>The network interface is unable to transmit data packets.</summary>
		// Token: 0x0400142D RID: 5165
		Down,
		/// <summary>The network interface is running tests.</summary>
		// Token: 0x0400142E RID: 5166
		Testing,
		/// <summary>The network interface status is not known.</summary>
		// Token: 0x0400142F RID: 5167
		Unknown,
		/// <summary>The network interface is not in a condition to transmit data packets; it is waiting for an external event.</summary>
		// Token: 0x04001430 RID: 5168
		Dormant,
		/// <summary>The network interface is unable to transmit data packets because of a missing component, typically a hardware component.</summary>
		// Token: 0x04001431 RID: 5169
		NotPresent,
		/// <summary>The network interface is unable to transmit data packets because it runs on top of one or more other interfaces, and at least one of these "lower layer" interfaces is down.</summary>
		// Token: 0x04001432 RID: 5170
		LowerLayerDown
	}
}
