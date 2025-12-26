using System;

namespace System.ComponentModel.Design
{
	/// <summary>Provides event notifications when root designers are added and removed, when a selected component changes, and when the current root designer changes.</summary>
	// Token: 0x02000115 RID: 277
	public interface IDesignerEventService
	{
		/// <summary>Occurs when the current root designer changes.</summary>
		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06000AD6 RID: 2774
		// (remove) Token: 0x06000AD7 RID: 2775
		event ActiveDesignerEventHandler ActiveDesignerChanged;

		/// <summary>Occurs when a root designer is created.</summary>
		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06000AD8 RID: 2776
		// (remove) Token: 0x06000AD9 RID: 2777
		event DesignerEventHandler DesignerCreated;

		/// <summary>Occurs when a root designer for a document is disposed.</summary>
		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06000ADA RID: 2778
		// (remove) Token: 0x06000ADB RID: 2779
		event DesignerEventHandler DesignerDisposed;

		/// <summary>Occurs when the current design-view selection changes.</summary>
		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06000ADC RID: 2780
		// (remove) Token: 0x06000ADD RID: 2781
		event EventHandler SelectionChanged;

		/// <summary>Gets the root designer for the currently active document.</summary>
		/// <returns>The currently active document, or null if there is no active document.</returns>
		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000ADE RID: 2782
		IDesignerHost ActiveDesigner { get; }

		/// <summary>Gets a collection of root designers for design documents that are currently active in the development environment.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerCollection" /> containing the root designers that have been created and not yet disposed.</returns>
		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000ADF RID: 2783
		DesignerCollection Designers { get; }
	}
}
