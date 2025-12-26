using System;
using System.Collections;

namespace System.ComponentModel.Design
{
	/// <summary>Provides a simple implementation of the <see cref="T:System.ComponentModel.Design.IServiceContainer" /> interface. This class cannot be inherited.</summary>
	// Token: 0x0200013F RID: 319
	public class ServiceContainer : IDisposable, IServiceProvider, IServiceContainer
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.ServiceContainer" /> class.</summary>
		// Token: 0x06000BD1 RID: 3025 RVA: 0x0000A440 File Offset: 0x00008640
		public ServiceContainer()
			: this(null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.ServiceContainer" /> class using the specified parent service provider.</summary>
		/// <param name="parentProvider">A parent service provider. </param>
		// Token: 0x06000BD2 RID: 3026 RVA: 0x0000A449 File Offset: 0x00008649
		public ServiceContainer(IServiceProvider parentProvider)
		{
			this.parentProvider = parentProvider;
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x0000A458 File Offset: 0x00008658
		private Hashtable Services
		{
			get
			{
				if (this.services == null)
				{
					this.services = new Hashtable();
				}
				return this.services;
			}
		}

		/// <summary>Adds the specified service to the service container.</summary>
		/// <param name="serviceType">The type of service to add. </param>
		/// <param name="serviceInstance">An instance of the service to add. This object must implement or inherit from the type indicated by the <paramref name="serviceType" /> parameter. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="serviceType" /> or <paramref name="serviceInstance" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">A service of type <paramref name="serviceType" /> already exists in the container.</exception>
		// Token: 0x06000BD4 RID: 3028 RVA: 0x0000A476 File Offset: 0x00008676
		public void AddService(Type serviceType, object serviceInstance)
		{
			this.AddService(serviceType, serviceInstance, false);
		}

		/// <summary>Adds the specified service to the service container.</summary>
		/// <param name="serviceType">The type of service to add. </param>
		/// <param name="callback">A callback object that can create the service. This allows a service to be declared as available, but delays creation of the object until the service is requested. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="serviceType" /> or <paramref name="callback" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">A service of type <paramref name="serviceType" /> already exists in the container.</exception>
		// Token: 0x06000BD5 RID: 3029 RVA: 0x0000A481 File Offset: 0x00008681
		public void AddService(Type serviceType, ServiceCreatorCallback callback)
		{
			this.AddService(serviceType, callback, false);
		}

		/// <summary>Adds the specified service to the service container.</summary>
		/// <param name="serviceType">The type of service to add. </param>
		/// <param name="serviceInstance">An instance of the service type to add. This object must implement or inherit from the type indicated by the <paramref name="serviceType" /> parameter. </param>
		/// <param name="promote">true if this service should be added to any parent service containers; otherwise, false. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="serviceType" /> or <paramref name="serviceInstance" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">A service of type <paramref name="serviceType" /> already exists in the container.</exception>
		// Token: 0x06000BD6 RID: 3030 RVA: 0x00030EF0 File Offset: 0x0002F0F0
		public virtual void AddService(Type serviceType, object serviceInstance, bool promote)
		{
			if (promote && this.parentProvider != null)
			{
				IServiceContainer serviceContainer = (IServiceContainer)this.parentProvider.GetService(typeof(IServiceContainer));
				serviceContainer.AddService(serviceType, serviceInstance, promote);
				return;
			}
			if (serviceType == null)
			{
				throw new ArgumentNullException("serviceType");
			}
			if (serviceInstance == null)
			{
				throw new ArgumentNullException("serviceInstance");
			}
			if (this.Services.Contains(serviceType))
			{
				throw new ArgumentException(string.Format("The service {0} already exists in the service container.", serviceType.ToString()), "serviceType");
			}
			this.Services.Add(serviceType, serviceInstance);
		}

		/// <summary>Adds the specified service to the service container.</summary>
		/// <param name="serviceType">The type of service to add. </param>
		/// <param name="callback">A callback object that can create the service. This allows a service to be declared as available, but delays creation of the object until the service is requested. </param>
		/// <param name="promote">true if this service should be added to any parent service containers; otherwise, false. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="serviceType" /> or <paramref name="callback" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">A service of type <paramref name="serviceType" /> already exists in the container.</exception>
		// Token: 0x06000BD7 RID: 3031 RVA: 0x00030F90 File Offset: 0x0002F190
		public virtual void AddService(Type serviceType, ServiceCreatorCallback callback, bool promote)
		{
			if (promote && this.parentProvider != null)
			{
				IServiceContainer serviceContainer = (IServiceContainer)this.parentProvider.GetService(typeof(IServiceContainer));
				serviceContainer.AddService(serviceType, callback, promote);
				return;
			}
			if (serviceType == null)
			{
				throw new ArgumentNullException("serviceType");
			}
			if (callback == null)
			{
				throw new ArgumentNullException("callback");
			}
			if (this.Services.Contains(serviceType))
			{
				throw new ArgumentException(string.Format("The service {0} already exists in the service container.", serviceType.ToString()), "serviceType");
			}
			this.Services.Add(serviceType, callback);
		}

		/// <summary>Removes the specified service type from the service container.</summary>
		/// <param name="serviceType">The type of service to remove. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="serviceType" /> is null.</exception>
		// Token: 0x06000BD8 RID: 3032 RVA: 0x0000A48C File Offset: 0x0000868C
		public void RemoveService(Type serviceType)
		{
			this.RemoveService(serviceType, false);
		}

		/// <summary>Removes the specified service type from the service container.</summary>
		/// <param name="serviceType">The type of service to remove. </param>
		/// <param name="promote">true if this service should be removed from any parent service containers; otherwise, false. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="serviceType" /> is null.</exception>
		// Token: 0x06000BD9 RID: 3033 RVA: 0x00031030 File Offset: 0x0002F230
		public virtual void RemoveService(Type serviceType, bool promote)
		{
			if (promote && this.parentProvider != null)
			{
				IServiceContainer serviceContainer = (IServiceContainer)this.parentProvider.GetService(typeof(IServiceContainer));
				serviceContainer.RemoveService(serviceType, promote);
				return;
			}
			if (serviceType == null)
			{
				throw new ArgumentNullException("serviceType");
			}
			this.Services.Remove(serviceType);
		}

		/// <summary>Gets the requested service.</summary>
		/// <returns>An instance of the service if it could be found, or null if it could not be found.</returns>
		/// <param name="serviceType">The type of service to retrieve. </param>
		// Token: 0x06000BDA RID: 3034 RVA: 0x00031090 File Offset: 0x0002F290
		public virtual object GetService(Type serviceType)
		{
			object obj = null;
			Type[] defaultServices = this.DefaultServices;
			for (int i = 0; i < defaultServices.Length; i++)
			{
				if (defaultServices[i] == serviceType)
				{
					obj = this;
					break;
				}
			}
			if (obj == null)
			{
				obj = this.Services[serviceType];
			}
			if (obj == null && this.parentProvider != null)
			{
				obj = this.parentProvider.GetService(serviceType);
			}
			if (obj != null)
			{
				ServiceCreatorCallback serviceCreatorCallback = obj as ServiceCreatorCallback;
				if (serviceCreatorCallback != null)
				{
					obj = serviceCreatorCallback(this, serviceType);
					this.Services[serviceType] = obj;
				}
			}
			return obj;
		}

		/// <summary>Gets the default services implemented directly by <see cref="T:System.ComponentModel.Design.ServiceContainer" />.</summary>
		/// <returns>The default services.</returns>
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x0000A496 File Offset: 0x00008696
		protected virtual Type[] DefaultServices
		{
			get
			{
				return new Type[]
				{
					typeof(IServiceContainer),
					typeof(ServiceContainer)
				};
			}
		}

		/// <summary>Disposes this service container.</summary>
		// Token: 0x06000BDC RID: 3036 RVA: 0x0000A4B8 File Offset: 0x000086B8
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Disposes this service container.</summary>
		/// <param name="disposing">true if the <see cref="T:System.ComponentModel.Design.ServiceContainer" /> is in the process of being disposed of; otherwise, false.</param>
		// Token: 0x06000BDD RID: 3037 RVA: 0x00031128 File Offset: 0x0002F328
		protected virtual void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				if (disposing && this.services != null)
				{
					foreach (object obj in this.services)
					{
						if (obj is IDisposable)
						{
							((IDisposable)obj).Dispose();
						}
					}
					this.services = null;
				}
				this._disposed = true;
			}
		}

		// Token: 0x04000322 RID: 802
		private IServiceProvider parentProvider;

		// Token: 0x04000323 RID: 803
		private Hashtable services;

		// Token: 0x04000324 RID: 804
		private bool _disposed;
	}
}
