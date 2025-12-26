using System;

namespace System.ComponentModel.Design
{
	/// <summary>Provides an interface for adding and removing extender providers at design time.</summary>
	// Token: 0x0200011C RID: 284
	public interface IExtenderProviderService
	{
		/// <summary>Adds the specified extender provider.</summary>
		/// <param name="provider">The extender provider to add. </param>
		// Token: 0x06000B10 RID: 2832
		void AddExtenderProvider(IExtenderProvider provider);

		/// <summary>Removes the specified extender provider.</summary>
		/// <param name="provider">The extender provider to remove. </param>
		// Token: 0x06000B11 RID: 2833
		void RemoveExtenderProvider(IExtenderProvider provider);
	}
}
