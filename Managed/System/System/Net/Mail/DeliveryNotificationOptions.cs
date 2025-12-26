using System;

namespace System.Net.Mail
{
	/// <summary>Describes the delivery notification options for e-mail.</summary>
	// Token: 0x0200034F RID: 847
	[Flags]
	public enum DeliveryNotificationOptions
	{
		/// <summary>No notification.</summary>
		// Token: 0x0400124E RID: 4686
		None = 0,
		/// <summary>Notify if the delivery is successful.</summary>
		// Token: 0x0400124F RID: 4687
		OnSuccess = 1,
		/// <summary>Notify if the delivery is unsuccessful.</summary>
		// Token: 0x04001250 RID: 4688
		OnFailure = 2,
		/// <summary>Notify if the delivery is delayed</summary>
		// Token: 0x04001251 RID: 4689
		Delay = 4,
		/// <summary>Never notify.</summary>
		// Token: 0x04001252 RID: 4690
		Never = 134217728
	}
}
