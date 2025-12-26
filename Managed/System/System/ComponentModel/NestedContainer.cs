using System;

namespace System.ComponentModel
{
	/// <summary>Provides the base implementation for the <see cref="T:System.ComponentModel.INestedContainer" /> interface, which enables containers to have an owning component.</summary>
	// Token: 0x02000193 RID: 403
	public class NestedContainer : Container, IDisposable, IContainer, INestedContainer
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.NestedContainer" /> class.</summary>
		/// <param name="owner">The <see cref="T:System.ComponentModel.IComponent" /> that owns this nested container.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="owner" /> is null.</exception>
		// Token: 0x06000E04 RID: 3588 RVA: 0x0000B99C File Offset: 0x00009B9C
		public NestedContainer(IComponent owner)
		{
			if (owner == null)
			{
				throw new ArgumentNullException("owner");
			}
			this._owner = owner;
			this._owner.Disposed += this.OnOwnerDisposed;
		}

		/// <summary>Gets the owning component for this nested container.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.IComponent" /> that owns this nested container.</returns>
		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x0000B9D3 File Offset: 0x00009BD3
		public IComponent Owner
		{
			get
			{
				return this._owner;
			}
		}

		/// <summary>Gets the name of the owning component.</summary>
		/// <returns>The name of the owning component.</returns>
		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x00034B34 File Offset: 0x00032D34
		protected virtual string OwnerName
		{
			get
			{
				if (this._owner.Site is INestedSite)
				{
					return ((INestedSite)this._owner.Site).FullName;
				}
				if (this._owner == null || this._owner.Site == null)
				{
					return null;
				}
				return this._owner.Site.Name;
			}
		}

		/// <summary>Creates a site for the component within the container.</summary>
		/// <returns>The newly created <see cref="T:System.ComponentModel.ISite" />.</returns>
		/// <param name="component">The <see cref="T:System.ComponentModel.IComponent" /> to create a site for.</param>
		/// <param name="name">The name to assign to <paramref name="component" />, or null to skip the name assignment.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="component" /> is null.</exception>
		// Token: 0x06000E07 RID: 3591 RVA: 0x0000B9DB File Offset: 0x00009BDB
		protected override ISite CreateSite(IComponent component, string name)
		{
			if (component == null)
			{
				throw new ArgumentNullException("component");
			}
			return new NestedContainer.Site(component, this, name);
		}

		/// <summary>Gets the service object of the specified type, if it is available.</summary>
		/// <returns>An <see cref="T:System.Object" /> that implements the requested service, or null if the service cannot be resolved.</returns>
		/// <param name="service">The <see cref="T:System.Type" /> of the service to retrieve.</param>
		// Token: 0x06000E08 RID: 3592 RVA: 0x0000B9F6 File Offset: 0x00009BF6
		protected override object GetService(Type service)
		{
			if (service == typeof(INestedContainer))
			{
				return this;
			}
			return base.GetService(service);
		}

		/// <summary>Releases the resources used by the nested container.</summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
		// Token: 0x06000E09 RID: 3593 RVA: 0x0000BA11 File Offset: 0x00009C11
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this._owner.Disposed -= this.OnOwnerDisposed;
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x0000BA37 File Offset: 0x00009C37
		private void OnOwnerDisposed(object sender, EventArgs e)
		{
			this.Dispose();
		}

		// Token: 0x04000401 RID: 1025
		private IComponent _owner;

		// Token: 0x02000194 RID: 404
		private class Site : IServiceProvider, INestedSite, ISite
		{
			// Token: 0x06000E0B RID: 3595 RVA: 0x0000BA3F File Offset: 0x00009C3F
			public Site(IComponent component, NestedContainer container, string name)
			{
				this._component = component;
				this._nestedContainer = container;
				this._siteName = name;
			}

			// Token: 0x1700033D RID: 829
			// (get) Token: 0x06000E0C RID: 3596 RVA: 0x0000BA5C File Offset: 0x00009C5C
			public IComponent Component
			{
				get
				{
					return this._component;
				}
			}

			// Token: 0x1700033E RID: 830
			// (get) Token: 0x06000E0D RID: 3597 RVA: 0x0000BA64 File Offset: 0x00009C64
			public IContainer Container
			{
				get
				{
					return this._nestedContainer;
				}
			}

			// Token: 0x1700033F RID: 831
			// (get) Token: 0x06000E0E RID: 3598 RVA: 0x0000BA6C File Offset: 0x00009C6C
			public bool DesignMode
			{
				get
				{
					return this._nestedContainer.Owner != null && this._nestedContainer.Owner.Site != null && this._nestedContainer.Owner.Site.DesignMode;
				}
			}

			// Token: 0x17000340 RID: 832
			// (get) Token: 0x06000E0F RID: 3599 RVA: 0x0000BAAA File Offset: 0x00009CAA
			// (set) Token: 0x06000E10 RID: 3600 RVA: 0x0000BAB2 File Offset: 0x00009CB2
			public string Name
			{
				get
				{
					return this._siteName;
				}
				set
				{
					this._siteName = value;
				}
			}

			// Token: 0x17000341 RID: 833
			// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00034B9C File Offset: 0x00032D9C
			public string FullName
			{
				get
				{
					if (this._siteName == null)
					{
						return null;
					}
					if (this._nestedContainer.OwnerName == null)
					{
						return this._siteName;
					}
					return this._nestedContainer.OwnerName + "." + this._siteName;
				}
			}

			// Token: 0x06000E12 RID: 3602 RVA: 0x0000BABB File Offset: 0x00009CBB
			public virtual object GetService(Type service)
			{
				if (service == typeof(ISite))
				{
					return this;
				}
				return this._nestedContainer.GetService(service);
			}

			// Token: 0x04000402 RID: 1026
			private IComponent _component;

			// Token: 0x04000403 RID: 1027
			private NestedContainer _nestedContainer;

			// Token: 0x04000404 RID: 1028
			private string _siteName;
		}
	}
}
