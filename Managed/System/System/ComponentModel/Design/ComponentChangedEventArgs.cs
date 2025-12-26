using System;
using System.Runtime.InteropServices;

namespace System.ComponentModel.Design
{
	/// <summary>Provides data for the <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentChanged" /> event. This class cannot be inherited.</summary>
	// Token: 0x020000FB RID: 251
	[ComVisible(true)]
	public sealed class ComponentChangedEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.ComponentChangedEventArgs" /> class.</summary>
		/// <param name="component">The component that was changed. </param>
		/// <param name="member">A <see cref="T:System.ComponentModel.MemberDescriptor" /> that represents the member that was changed. </param>
		/// <param name="oldValue">The old value of the changed member. </param>
		/// <param name="newValue">The new value of the changed member. </param>
		// Token: 0x06000A2E RID: 2606 RVA: 0x000097BE File Offset: 0x000079BE
		public ComponentChangedEventArgs(object component, MemberDescriptor member, object oldValue, object newValue)
		{
			this.component = component;
			this.member = member;
			this.oldValue = oldValue;
			this.newValue = newValue;
		}

		/// <summary>Gets the component that was modified.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the component that was modified.</returns>
		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x000097E3 File Offset: 0x000079E3
		public object Component
		{
			get
			{
				return this.component;
			}
		}

		/// <summary>Gets the member that has been changed.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.MemberDescriptor" /> that indicates the member that has been changed.</returns>
		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x000097EB File Offset: 0x000079EB
		public MemberDescriptor Member
		{
			get
			{
				return this.member;
			}
		}

		/// <summary>Gets the new value of the changed member.</summary>
		/// <returns>The new value of the changed member. This property can be null.</returns>
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x000097F3 File Offset: 0x000079F3
		public object NewValue
		{
			get
			{
				return this.oldValue;
			}
		}

		/// <summary>Gets the old value of the changed member.</summary>
		/// <returns>The old value of the changed member. This property can be null.</returns>
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x000097FB File Offset: 0x000079FB
		public object OldValue
		{
			get
			{
				return this.newValue;
			}
		}

		// Token: 0x040002BF RID: 703
		private object component;

		// Token: 0x040002C0 RID: 704
		private MemberDescriptor member;

		// Token: 0x040002C1 RID: 705
		private object oldValue;

		// Token: 0x040002C2 RID: 706
		private object newValue;
	}
}
