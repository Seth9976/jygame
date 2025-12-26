using System;
using System.Runtime.InteropServices;

namespace System.ComponentModel.Design
{
	/// <summary>Provides data for the <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentChanging" /> event. This class cannot be inherited.</summary>
	// Token: 0x020000FC RID: 252
	[ComVisible(true)]
	public sealed class ComponentChangingEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.ComponentChangingEventArgs" /> class.</summary>
		/// <param name="component">The component that is about to be changed. </param>
		/// <param name="member">A <see cref="T:System.ComponentModel.MemberDescriptor" /> indicating the member of the component that is about to be changed. </param>
		// Token: 0x06000A33 RID: 2611 RVA: 0x00009803 File Offset: 0x00007A03
		public ComponentChangingEventArgs(object component, MemberDescriptor member)
		{
			this.component = component;
			this.member = member;
		}

		/// <summary>Gets the component that is about to be changed or the component that is the parent container of the member that is about to be changed.</summary>
		/// <returns>The component that is about to have a member changed.</returns>
		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x00009819 File Offset: 0x00007A19
		public object Component
		{
			get
			{
				return this.component;
			}
		}

		/// <summary>Gets the member that is about to be changed.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.MemberDescriptor" /> indicating the member that is about to be changed, if known, or null otherwise.</returns>
		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00009821 File Offset: 0x00007A21
		public MemberDescriptor Member
		{
			get
			{
				return this.member;
			}
		}

		// Token: 0x040002C3 RID: 707
		private object component;

		// Token: 0x040002C4 RID: 708
		private MemberDescriptor member;
	}
}
