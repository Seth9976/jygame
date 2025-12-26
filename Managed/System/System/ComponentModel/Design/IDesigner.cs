using System;
using System.Runtime.InteropServices;

namespace System.ComponentModel.Design
{
	/// <summary>Provides the basic framework for building a custom designer.</summary>
	// Token: 0x02000114 RID: 276
	[ComVisible(true)]
	public interface IDesigner : IDisposable
	{
		/// <summary>Gets the base component that this designer is designing.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.IComponent" /> indicating the base component that this designer is designing.</returns>
		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000AD2 RID: 2770
		IComponent Component { get; }

		/// <summary>Gets a collection of the design-time verbs supported by the designer.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerVerbCollection" /> that contains the verbs supported by the designer, or null if the component has no verbs.</returns>
		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000AD3 RID: 2771
		DesignerVerbCollection Verbs { get; }

		/// <summary>Performs the default action for this designer.</summary>
		// Token: 0x06000AD4 RID: 2772
		void DoDefaultAction();

		/// <summary>Initializes the designer with the specified component.</summary>
		/// <param name="component">The component to associate with this designer. </param>
		// Token: 0x06000AD5 RID: 2773
		void Initialize(IComponent component);
	}
}
