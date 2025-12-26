using System;

namespace System.ComponentModel
{
	/// <summary>Notifies clients that a property value is changing.</summary>
	// Token: 0x02000168 RID: 360
	public interface INotifyPropertyChanging
	{
		/// <summary>Occurs when a property value is changing.</summary>
		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06000CC2 RID: 3266
		// (remove) Token: 0x06000CC3 RID: 3267
		event PropertyChangingEventHandler PropertyChanging;
	}
}
