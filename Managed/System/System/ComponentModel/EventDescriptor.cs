using System;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	/// <summary>Provides information about an event.</summary>
	// Token: 0x0200014D RID: 333
	[ComVisible(true)]
	public abstract class EventDescriptor : MemberDescriptor
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EventDescriptor" /> class with the name and attributes in the specified <see cref="T:System.ComponentModel.MemberDescriptor" />.</summary>
		/// <param name="descr">A <see cref="T:System.ComponentModel.MemberDescriptor" /> that contains the name of the event and its attributes. </param>
		// Token: 0x06000C43 RID: 3139 RVA: 0x0000A9BE File Offset: 0x00008BBE
		protected EventDescriptor(MemberDescriptor desc)
			: base(desc)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EventDescriptor" /> class with the name in the specified <see cref="T:System.ComponentModel.MemberDescriptor" /> and the attributes in both the <see cref="T:System.ComponentModel.MemberDescriptor" /> and the <see cref="T:System.Attribute" /> array.</summary>
		/// <param name="descr">A <see cref="T:System.ComponentModel.MemberDescriptor" /> that has the name of the member and its attributes. </param>
		/// <param name="attrs">An <see cref="T:System.Attribute" /> array with the attributes you want to add to this event description. </param>
		// Token: 0x06000C44 RID: 3140 RVA: 0x0000A9C7 File Offset: 0x00008BC7
		protected EventDescriptor(MemberDescriptor desc, Attribute[] attrs)
			: base(desc, attrs)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.EventDescriptor" /> class with the specified name and attribute array.</summary>
		/// <param name="name">The name of the event. </param>
		/// <param name="attrs">An array of type <see cref="T:System.Attribute" /> that contains the event attributes. </param>
		// Token: 0x06000C45 RID: 3141 RVA: 0x0000A9D1 File Offset: 0x00008BD1
		protected EventDescriptor(string str, Attribute[] attrs)
			: base(str, attrs)
		{
		}

		/// <summary>When overridden in a derived class, binds the event to the component.</summary>
		/// <param name="component">A component that provides events to the delegate. </param>
		/// <param name="value">A delegate that represents the method that handles the event. </param>
		// Token: 0x06000C46 RID: 3142
		public abstract void AddEventHandler(object component, Delegate value);

		/// <summary>When overridden in a derived class, unbinds the delegate from the component so that the delegate will no longer receive events from the component.</summary>
		/// <param name="component">The component that the delegate is bound to. </param>
		/// <param name="value">The delegate to unbind from the component. </param>
		// Token: 0x06000C47 RID: 3143
		public abstract void RemoveEventHandler(object component, Delegate value);

		/// <summary>When overridden in a derived class, gets the type of component this event is bound to.</summary>
		/// <returns>A <see cref="T:System.Type" /> that represents the type of component the event is bound to.</returns>
		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000C48 RID: 3144
		public abstract Type ComponentType { get; }

		/// <summary>When overridden in a derived class, gets the type of delegate for the event.</summary>
		/// <returns>A <see cref="T:System.Type" /> that represents the type of delegate for the event.</returns>
		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000C49 RID: 3145
		public abstract Type EventType { get; }

		/// <summary>When overridden in a derived class, gets a value indicating whether the event delegate is a multicast delegate.</summary>
		/// <returns>true if the event delegate is multicast; otherwise, false.</returns>
		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000C4A RID: 3146
		public abstract bool IsMulticast { get; }
	}
}
