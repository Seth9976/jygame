using System;

namespace System.ComponentModel
{
	/// <summary>Allows coordination of initialization for a component and its dependent properties.</summary>
	// Token: 0x02000174 RID: 372
	public interface ISupportInitializeNotification : ISupportInitialize
	{
		/// <summary>Occurs when initialization of the component is completed.</summary>
		// Token: 0x14000038 RID: 56
		// (add) Token: 0x06000CED RID: 3309
		// (remove) Token: 0x06000CEE RID: 3310
		event EventHandler Initialized;

		/// <summary>Gets a value indicating whether the component is initialized.</summary>
		/// <returns>true to indicate the component has completed initialization; otherwise, false. </returns>
		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000CEF RID: 3311
		bool IsInitialized { get; }
	}
}
