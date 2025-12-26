using System;
using System.Collections.Generic;

namespace System.ComponentModel
{
	/// <summary>Encapsulates zero or more components.</summary>
	// Token: 0x020000E6 RID: 230
	public class Container : IDisposable, IContainer
	{
		/// <summary>Gets all the components in the <see cref="T:System.ComponentModel.Container" />.</summary>
		/// <returns>A collection that contains the components in the <see cref="T:System.ComponentModel.Container" />.</returns>
		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x0002FAB4 File Offset: 0x0002DCB4
		public virtual ComponentCollection Components
		{
			get
			{
				IComponent[] array = this.c.ToArray();
				return new ComponentCollection(array);
			}
		}

		/// <summary>Adds the specified <see cref="T:System.ComponentModel.Component" /> to the <see cref="T:System.ComponentModel.Container" />. The component is unnamed.</summary>
		/// <param name="component">The component to add. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="component" /> is null.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x0600099B RID: 2459 RVA: 0x00008FAB File Offset: 0x000071AB
		public virtual void Add(IComponent component)
		{
			this.Add(component, null);
		}

		/// <summary>Adds the specified <see cref="T:System.ComponentModel.Component" /> to the <see cref="T:System.ComponentModel.Container" /> and assigns it a name.</summary>
		/// <param name="component">The component to add. </param>
		/// <param name="name">The unique, case-insensitive name to assign to the component.-or- null, which leaves the component unnamed. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="component" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> is not unique.</exception>
		// Token: 0x0600099C RID: 2460 RVA: 0x0002FAD4 File Offset: 0x0002DCD4
		public virtual void Add(IComponent component, string name)
		{
			if (component != null && (component.Site == null || component.Site.Container != this))
			{
				this.ValidateName(component, name);
				if (component.Site != null)
				{
					component.Site.Container.Remove(component);
				}
				component.Site = this.CreateSite(component, name);
				this.c.Add(component);
			}
		}

		/// <summary>Determines whether the component name is unique for this container.</summary>
		/// <param name="component">The named component.</param>
		/// <param name="name">The component name to validate.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="component" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> is not unique.</exception>
		// Token: 0x0600099D RID: 2461 RVA: 0x0002FB44 File Offset: 0x0002DD44
		protected virtual void ValidateName(IComponent component, string name)
		{
			if (component == null)
			{
				throw new ArgumentNullException("component");
			}
			if (name == null)
			{
				return;
			}
			foreach (IComponent component2 in this.c)
			{
				if (!object.ReferenceEquals(component, component2))
				{
					if (component2.Site != null && string.Compare(component2.Site.Name, name, true) == 0)
					{
						throw new ArgumentException(string.Format("There already is a named component '{0}' in this container", name));
					}
				}
			}
		}

		/// <summary>Creates a site <see cref="T:System.ComponentModel.ISite" /> for the given <see cref="T:System.ComponentModel.IComponent" /> and assigns the given name to the site.</summary>
		/// <returns>The newly created site.</returns>
		/// <param name="component">The <see cref="T:System.ComponentModel.IComponent" /> to create a site for. </param>
		/// <param name="name">The name to assign to <paramref name="component" />, or null to skip the name assignment. </param>
		// Token: 0x0600099E RID: 2462 RVA: 0x00008FB5 File Offset: 0x000071B5
		protected virtual ISite CreateSite(IComponent component, string name)
		{
			return new Container.DefaultSite(name, component, this);
		}

		/// <summary>Releases all resources used by the <see cref="T:System.ComponentModel.Container" />.</summary>
		// Token: 0x0600099F RID: 2463 RVA: 0x00008FBF File Offset: 0x000071BF
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.ComponentModel.Container" />, and optionally releases the managed resources.</summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
		// Token: 0x060009A0 RID: 2464 RVA: 0x0002FBF4 File Offset: 0x0002DDF4
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				while (this.c.Count > 0)
				{
					int num = this.c.Count - 1;
					IComponent component = this.c[num];
					this.Remove(component);
					component.Dispose();
				}
			}
		}

		/// <summary>Releases unmanaged resources and performs other cleanup operations before the <see cref="T:System.ComponentModel.Container" /> is reclaimed by garbage collection.</summary>
		// Token: 0x060009A1 RID: 2465 RVA: 0x0002FC48 File Offset: 0x0002DE48
		~Container()
		{
			this.Dispose(false);
		}

		/// <summary>Gets the service object of the specified type, if it is available.</summary>
		/// <returns>An <see cref="T:System.Object" /> implementing the requested service, or null if the service cannot be resolved.</returns>
		/// <param name="service">The <see cref="T:System.Type" /> of the service to retrieve. </param>
		// Token: 0x060009A2 RID: 2466 RVA: 0x00008FCE File Offset: 0x000071CE
		protected virtual object GetService(Type service)
		{
			if (typeof(IContainer) != service)
			{
				return null;
			}
			return this;
		}

		/// <summary>Removes a component from the <see cref="T:System.ComponentModel.Container" />.</summary>
		/// <param name="component">The component to remove. </param>
		// Token: 0x060009A3 RID: 2467 RVA: 0x00008FE3 File Offset: 0x000071E3
		public virtual void Remove(IComponent component)
		{
			this.Remove(component, true);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00008FED File Offset: 0x000071ED
		private void Remove(IComponent component, bool unsite)
		{
			if (component != null && component.Site != null && component.Site.Container == this)
			{
				if (unsite)
				{
					component.Site = null;
				}
				this.c.Remove(component);
			}
		}

		/// <summary>Removes a component from the <see cref="T:System.ComponentModel.Container" /> without setting <see cref="P:System.ComponentModel.IComponent.Site" /> to null.</summary>
		/// <param name="component">The component to remove.</param>
		// Token: 0x060009A5 RID: 2469 RVA: 0x0000902B File Offset: 0x0000722B
		protected void RemoveWithoutUnsiting(IComponent component)
		{
			this.Remove(component, false);
		}

		// Token: 0x04000297 RID: 663
		private List<IComponent> c = new List<IComponent>();

		// Token: 0x020000E7 RID: 231
		private class DefaultSite : IServiceProvider, ISite
		{
			// Token: 0x060009A6 RID: 2470 RVA: 0x00009035 File Offset: 0x00007235
			public DefaultSite(string name, IComponent component, Container container)
			{
				this.component = component;
				this.container = container;
				this.name = name;
			}

			// Token: 0x1700022F RID: 559
			// (get) Token: 0x060009A7 RID: 2471 RVA: 0x00009052 File Offset: 0x00007252
			public IComponent Component
			{
				get
				{
					return this.component;
				}
			}

			// Token: 0x17000230 RID: 560
			// (get) Token: 0x060009A8 RID: 2472 RVA: 0x0000905A File Offset: 0x0000725A
			public IContainer Container
			{
				get
				{
					return this.container;
				}
			}

			// Token: 0x17000231 RID: 561
			// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00002AA1 File Offset: 0x00000CA1
			public bool DesignMode
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000232 RID: 562
			// (get) Token: 0x060009AA RID: 2474 RVA: 0x00009062 File Offset: 0x00007262
			// (set) Token: 0x060009AB RID: 2475 RVA: 0x0000906A File Offset: 0x0000726A
			public string Name
			{
				get
				{
					return this.name;
				}
				set
				{
					this.name = value;
				}
			}

			// Token: 0x060009AC RID: 2476 RVA: 0x00009073 File Offset: 0x00007273
			public virtual object GetService(Type t)
			{
				if (typeof(ISite) == t)
				{
					return this;
				}
				return this.container.GetService(t);
			}

			// Token: 0x04000298 RID: 664
			private readonly IComponent component;

			// Token: 0x04000299 RID: 665
			private readonly Container container;

			// Token: 0x0400029A RID: 666
			private string name;
		}
	}
}
