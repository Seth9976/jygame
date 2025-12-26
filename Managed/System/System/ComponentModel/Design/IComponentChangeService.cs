using System;
using System.Runtime.InteropServices;

namespace System.ComponentModel.Design
{
	/// <summary>Provides an interface to add and remove the event handlers for events that add, change, remove or rename components, and provides methods to raise a <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentChanged" /> or <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentChanging" /> event.</summary>
	// Token: 0x02000111 RID: 273
	[ComVisible(true)]
	public interface IComponentChangeService
	{
		/// <summary>Occurs when a component has been added.</summary>
		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06000ABF RID: 2751
		// (remove) Token: 0x06000AC0 RID: 2752
		event ComponentEventHandler ComponentAdded;

		/// <summary>Occurs when a component is in the process of being added.</summary>
		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000AC1 RID: 2753
		// (remove) Token: 0x06000AC2 RID: 2754
		event ComponentEventHandler ComponentAdding;

		/// <summary>Occurs when a component has been changed.</summary>
		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06000AC3 RID: 2755
		// (remove) Token: 0x06000AC4 RID: 2756
		event ComponentChangedEventHandler ComponentChanged;

		/// <summary>Occurs when a component is in the process of being changed.</summary>
		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06000AC5 RID: 2757
		// (remove) Token: 0x06000AC6 RID: 2758
		event ComponentChangingEventHandler ComponentChanging;

		/// <summary>Occurs when a component has been removed.</summary>
		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06000AC7 RID: 2759
		// (remove) Token: 0x06000AC8 RID: 2760
		event ComponentEventHandler ComponentRemoved;

		/// <summary>Occurs when a component is in the process of being removed.</summary>
		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06000AC9 RID: 2761
		// (remove) Token: 0x06000ACA RID: 2762
		event ComponentEventHandler ComponentRemoving;

		/// <summary>Occurs when a component is renamed.</summary>
		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06000ACB RID: 2763
		// (remove) Token: 0x06000ACC RID: 2764
		event ComponentRenameEventHandler ComponentRename;

		/// <summary>Announces to the component change service that a particular component has changed.</summary>
		/// <param name="component">The component that has changed. </param>
		/// <param name="member">The member that has changed. This is null if this change is not related to a single member. </param>
		/// <param name="oldValue">The old value of the member. This is valid only if the member is not null. </param>
		/// <param name="newValue">The new value of the member. This is valid only if the member is not null. </param>
		// Token: 0x06000ACD RID: 2765
		void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue);

		/// <summary>Announces to the component change service that a particular component is changing.</summary>
		/// <param name="component">The component that is about to change. </param>
		/// <param name="member">The member that is changing. This is null if this change is not related to a single member. </param>
		// Token: 0x06000ACE RID: 2766
		void OnComponentChanging(object component, MemberDescriptor member);
	}
}
