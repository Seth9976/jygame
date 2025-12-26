using System;

namespace System.ComponentModel
{
	/// <summary>Notifies clients that a property value has changed.</summary>
	// Token: 0x02000167 RID: 359
	public interface INotifyPropertyChanged
	{
		/// <summary>Occurs when a property value changes.</summary>
		// Token: 0x14000036 RID: 54
		// (add) Token: 0x06000CC0 RID: 3264
		// (remove) Token: 0x06000CC1 RID: 3265
		event PropertyChangedEventHandler PropertyChanged;
	}
}
