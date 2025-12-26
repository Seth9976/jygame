using System;

namespace System.ComponentModel
{
	/// <summary>Provides data for the <see cref="E:System.ComponentModel.TypeDescriptor.Refreshed" /> event.</summary>
	// Token: 0x020001A5 RID: 421
	public class RefreshEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.RefreshEventArgs" /> class with the component that has changed.</summary>
		/// <param name="componentChanged">The component that changed. </param>
		// Token: 0x06000ED0 RID: 3792 RVA: 0x0000C3E8 File Offset: 0x0000A5E8
		public RefreshEventArgs(object componentChanged)
		{
			if (componentChanged == null)
			{
				throw new ArgumentNullException("componentChanged");
			}
			this.component = componentChanged;
			this.type = this.component.GetType();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.RefreshEventArgs" /> class with the type of component that has changed.</summary>
		/// <param name="typeChanged">The <see cref="T:System.Type" /> that changed. </param>
		// Token: 0x06000ED1 RID: 3793 RVA: 0x0000C419 File Offset: 0x0000A619
		public RefreshEventArgs(Type typeChanged)
		{
			this.type = typeChanged;
		}

		/// <summary>Gets the component that changed its properties, events, or extenders.</summary>
		/// <returns>The component that changed its properties, events, or extenders, or null if all components of the same type have changed.</returns>
		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x0000C428 File Offset: 0x0000A628
		public object ComponentChanged
		{
			get
			{
				return this.component;
			}
		}

		/// <summary>Gets the <see cref="T:System.Type" /> that changed its properties or events.</summary>
		/// <returns>The <see cref="T:System.Type" /> that changed its properties or events.</returns>
		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x0000C430 File Offset: 0x0000A630
		public Type TypeChanged
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x04000436 RID: 1078
		private object component;

		// Token: 0x04000437 RID: 1079
		private Type type;
	}
}
