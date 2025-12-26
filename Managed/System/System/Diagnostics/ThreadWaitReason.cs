using System;

namespace System.Diagnostics
{
	/// <summary>Specifies the reason a thread is waiting.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x0200025E RID: 606
	public enum ThreadWaitReason
	{
		/// <summary>The thread is waiting for event pair high.</summary>
		// Token: 0x04000682 RID: 1666
		EventPairHigh = 7,
		/// <summary>The thread is waiting for event pair low.</summary>
		// Token: 0x04000683 RID: 1667
		EventPairLow,
		/// <summary>Thread execution is delayed.</summary>
		// Token: 0x04000684 RID: 1668
		ExecutionDelay = 4,
		/// <summary>The thread is waiting for the scheduler.</summary>
		// Token: 0x04000685 RID: 1669
		Executive = 0,
		/// <summary>The thread is waiting for a free virtual memory page.</summary>
		// Token: 0x04000686 RID: 1670
		FreePage,
		/// <summary>The thread is waiting for a local procedure call to arrive.</summary>
		// Token: 0x04000687 RID: 1671
		LpcReceive = 9,
		/// <summary>The thread is waiting for reply to a local procedure call to arrive.</summary>
		// Token: 0x04000688 RID: 1672
		LpcReply,
		/// <summary>The thread is waiting for a virtual memory page to arrive in memory.</summary>
		// Token: 0x04000689 RID: 1673
		PageIn = 2,
		/// <summary>The thread is waiting for a virtual memory page to be written to disk.</summary>
		// Token: 0x0400068A RID: 1674
		PageOut = 12,
		/// <summary>Thread execution is suspended.</summary>
		// Token: 0x0400068B RID: 1675
		Suspended = 5,
		/// <summary>The thread is waiting for system allocation.</summary>
		// Token: 0x0400068C RID: 1676
		SystemAllocation = 3,
		/// <summary>The thread is waiting for an unknown reason.</summary>
		// Token: 0x0400068D RID: 1677
		Unknown = 13,
		/// <summary>The thread is waiting for a user request.</summary>
		// Token: 0x0400068E RID: 1678
		UserRequest = 6,
		/// <summary>The thread is waiting for the system to allocate virtual memory.</summary>
		// Token: 0x0400068F RID: 1679
		VirtualMemory = 11
	}
}
