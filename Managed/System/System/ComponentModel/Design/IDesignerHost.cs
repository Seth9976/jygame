using System;
using System.Runtime.InteropServices;

namespace System.ComponentModel.Design
{
	/// <summary>Provides an interface for managing designer transactions and components.</summary>
	// Token: 0x02000117 RID: 279
	[ComVisible(true)]
	public interface IDesignerHost : IServiceProvider, IServiceContainer
	{
		/// <summary>Occurs when this designer is activated.</summary>
		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06000AE6 RID: 2790
		// (remove) Token: 0x06000AE7 RID: 2791
		event EventHandler Activated;

		/// <summary>Occurs when this designer is deactivated.</summary>
		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06000AE8 RID: 2792
		// (remove) Token: 0x06000AE9 RID: 2793
		event EventHandler Deactivated;

		/// <summary>Occurs when this designer completes loading its document.</summary>
		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06000AEA RID: 2794
		// (remove) Token: 0x06000AEB RID: 2795
		event EventHandler LoadComplete;

		/// <summary>Adds an event handler for the <see cref="E:System.ComponentModel.Design.IDesignerHost.TransactionClosed" /> event.</summary>
		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06000AEC RID: 2796
		// (remove) Token: 0x06000AED RID: 2797
		event DesignerTransactionCloseEventHandler TransactionClosed;

		/// <summary>Adds an event handler for the <see cref="E:System.ComponentModel.Design.IDesignerHost.TransactionClosing" /> event.</summary>
		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06000AEE RID: 2798
		// (remove) Token: 0x06000AEF RID: 2799
		event DesignerTransactionCloseEventHandler TransactionClosing;

		/// <summary>Adds an event handler for the <see cref="E:System.ComponentModel.Design.IDesignerHost.TransactionOpened" /> event.</summary>
		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06000AF0 RID: 2800
		// (remove) Token: 0x06000AF1 RID: 2801
		event EventHandler TransactionOpened;

		/// <summary>Adds an event handler for the <see cref="E:System.ComponentModel.Design.IDesignerHost.TransactionOpening" /> event.</summary>
		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06000AF2 RID: 2802
		// (remove) Token: 0x06000AF3 RID: 2803
		event EventHandler TransactionOpening;

		/// <summary>Gets the container for this designer host.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.IContainer" /> for this host.</returns>
		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000AF4 RID: 2804
		IContainer Container { get; }

		/// <summary>Gets a value indicating whether the designer host is currently in a transaction.</summary>
		/// <returns>true if a transaction is in progress; otherwise, false.</returns>
		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000AF5 RID: 2805
		bool InTransaction { get; }

		/// <summary>Gets a value indicating whether the designer host is currently loading the document.</summary>
		/// <returns>true if the designer host is currently loading the document; otherwise, false.</returns>
		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000AF6 RID: 2806
		bool Loading { get; }

		/// <summary>Gets the instance of the base class used as the root component for the current design.</summary>
		/// <returns>The instance of the root component class.</returns>
		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000AF7 RID: 2807
		IComponent RootComponent { get; }

		/// <summary>Gets the fully qualified name of the class being designed.</summary>
		/// <returns>The fully qualified name of the base component class.</returns>
		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000AF8 RID: 2808
		string RootComponentClassName { get; }

		/// <summary>Gets the description of the current transaction.</summary>
		/// <returns>A description of the current transaction.</returns>
		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000AF9 RID: 2809
		string TransactionDescription { get; }

		/// <summary>Activates the designer that this host is hosting.</summary>
		// Token: 0x06000AFA RID: 2810
		void Activate();

		/// <summary>Creates a component of the specified type and adds it to the design document.</summary>
		/// <returns>The newly created component.</returns>
		/// <param name="componentClass">The type of the component to create. </param>
		// Token: 0x06000AFB RID: 2811
		IComponent CreateComponent(Type componentClass);

		/// <summary>Creates a component of the specified type and name, and adds it to the design document.</summary>
		/// <returns>The newly created component.</returns>
		/// <param name="componentClass">The type of the component to create. </param>
		/// <param name="name">The name for the component. </param>
		// Token: 0x06000AFC RID: 2812
		IComponent CreateComponent(Type componentClass, string name);

		/// <summary>Creates a <see cref="T:System.ComponentModel.Design.DesignerTransaction" /> that can encapsulate event sequences to improve performance and enable undo and redo support functionality.</summary>
		/// <returns>A new instance of <see cref="T:System.ComponentModel.Design.DesignerTransaction" />. When you complete the steps in your transaction, you should call <see cref="M:System.ComponentModel.Design.DesignerTransaction.Commit" /> on this object.</returns>
		// Token: 0x06000AFD RID: 2813
		DesignerTransaction CreateTransaction();

		/// <summary>Creates a <see cref="T:System.ComponentModel.Design.DesignerTransaction" /> that can encapsulate event sequences to improve performance and enable undo and redo support functionality, using the specified transaction description.</summary>
		/// <returns>A new <see cref="T:System.ComponentModel.Design.DesignerTransaction" />. When you have completed the steps in your transaction, you should call <see cref="M:System.ComponentModel.Design.DesignerTransaction.Commit" /> on this object.</returns>
		/// <param name="description">A title or description for the newly created transaction. </param>
		// Token: 0x06000AFE RID: 2814
		DesignerTransaction CreateTransaction(string description);

		/// <summary>Destroys the specified component and removes it from the designer container.</summary>
		/// <param name="component">The component to destroy. </param>
		// Token: 0x06000AFF RID: 2815
		void DestroyComponent(IComponent component);

		/// <summary>Gets the designer instance that contains the specified component.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.Design.IDesigner" />, or null if there is no designer for the specified component.</returns>
		/// <param name="component">The <see cref="T:System.ComponentModel.IComponent" /> to retrieve the designer for. </param>
		// Token: 0x06000B00 RID: 2816
		IDesigner GetDesigner(IComponent component);

		/// <summary>Gets an instance of the specified, fully qualified type name.</summary>
		/// <returns>The type object for the specified type name, or null if the type cannot be found.</returns>
		/// <param name="typeName">The name of the type to load. </param>
		// Token: 0x06000B01 RID: 2817
		Type GetType(string typeName);
	}
}
