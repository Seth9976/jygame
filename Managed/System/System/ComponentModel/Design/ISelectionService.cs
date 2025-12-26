using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.ComponentModel.Design
{
	/// <summary>Provides an interface for a designer to select components.</summary>
	// Token: 0x02000123 RID: 291
	[ComVisible(true)]
	public interface ISelectionService
	{
		/// <summary>Occurs when the current selection changes.</summary>
		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06000B2C RID: 2860
		// (remove) Token: 0x06000B2D RID: 2861
		event EventHandler SelectionChanged;

		/// <summary>Occurs when the current selection is about to change.</summary>
		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06000B2E RID: 2862
		// (remove) Token: 0x06000B2F RID: 2863
		event EventHandler SelectionChanging;

		/// <summary>Gets a value indicating whether the specified component is currently selected.</summary>
		/// <returns>true if the component is part of the user's current selection; otherwise, false.</returns>
		/// <param name="component">The component to test. </param>
		// Token: 0x06000B30 RID: 2864
		bool GetComponentSelected(object component);

		/// <summary>Gets a collection of components that are currently selected.</summary>
		/// <returns>A collection that represents the current set of components that are selected.</returns>
		// Token: 0x06000B31 RID: 2865
		ICollection GetSelectedComponents();

		/// <summary>Selects the components from within the specified collection of components that match the specified selection type.</summary>
		/// <param name="components">The collection of components to select. </param>
		/// <param name="selectionType">A value from the <see cref="T:System.ComponentModel.Design.SelectionTypes" /> enumeration. The default is <see cref="F:System.ComponentModel.Design.SelectionTypes.Normal" />. </param>
		// Token: 0x06000B32 RID: 2866
		void SetSelectedComponents(ICollection components, SelectionTypes selectionType);

		/// <summary>Selects the specified collection of components.</summary>
		/// <param name="components">The collection of components to select. </param>
		// Token: 0x06000B33 RID: 2867
		void SetSelectedComponents(ICollection components);

		/// <summary>Gets the object that is currently the primary selected object.</summary>
		/// <returns>The object that is currently the primary selected object.</returns>
		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000B34 RID: 2868
		object PrimarySelection { get; }

		/// <summary>Gets the count of selected objects.</summary>
		/// <returns>The number of selected objects.</returns>
		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000B35 RID: 2869
		int SelectionCount { get; }
	}
}
