using System;

namespace System.ComponentModel
{
	/// <summary>Indicates whether a class converts property change events to <see cref="E:System.ComponentModel.IBindingList.ListChanged" /> events.</summary>
	// Token: 0x02000171 RID: 369
	public interface IRaiseItemChangedEvents
	{
		/// <summary>Gets a value indicating whether the <see cref="T:System.ComponentModel.IRaiseItemChangedEvents" /> object raises <see cref="E:System.ComponentModel.IBindingList.ListChanged" /> events.</summary>
		/// <returns>true if the <see cref="T:System.ComponentModel.IRaiseItemChangedEvents" /> object raises <see cref="E:System.ComponentModel.IBindingList.ListChanged" /> events when one of its property values changes; otherwise, false.</returns>
		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000CE5 RID: 3301
		bool RaisesItemChangedEvents { get; }
	}
}
