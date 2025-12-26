using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	/// <summary>Implements <see cref="T:System.ComponentModel.IComponent" /> and provides the base implementation for remotable components that are marshaled by value (a copy of the serialized object is passed).</summary>
	// Token: 0x02000189 RID: 393
	[Designer("System.Windows.Forms.Design.ComponentDocumentDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(global::System.ComponentModel.Design.IRootDesigner))]
	[DesignerCategory("Component")]
	[TypeConverter(typeof(ComponentConverter))]
	[ComVisible(true)]
	public class MarshalByValueComponent : IDisposable, IServiceProvider, IComponent
	{
		/// <summary>Adds an event handler to listen to the <see cref="E:System.ComponentModel.MarshalByValueComponent.Disposed" /> event on the component.</summary>
		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06000D62 RID: 3426 RVA: 0x0000B21E File Offset: 0x0000941E
		// (remove) Token: 0x06000D63 RID: 3427 RVA: 0x0000B232 File Offset: 0x00009432
		public event EventHandler Disposed
		{
			add
			{
				this.Events.AddHandler(this.disposedEvent, value);
			}
			remove
			{
				this.Events.RemoveHandler(this.disposedEvent, value);
			}
		}

		/// <summary>Releases all resources used by the <see cref="T:System.ComponentModel.MarshalByValueComponent" />.</summary>
		// Token: 0x06000D64 RID: 3428 RVA: 0x0000B246 File Offset: 0x00009446
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.ComponentModel.MarshalByValueComponent" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
		// Token: 0x06000D65 RID: 3429 RVA: 0x0000B255 File Offset: 0x00009455
		[global::System.MonoTODO]
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
			}
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00032688 File Offset: 0x00030888
		~MarshalByValueComponent()
		{
			this.Dispose(false);
		}

		/// <summary>Gets the implementer of the <see cref="T:System.IServiceProvider" />.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the implementer of the <see cref="T:System.IServiceProvider" />.</returns>
		/// <param name="service">A <see cref="T:System.Type" /> that represents the type of service you want. </param>
		// Token: 0x06000D67 RID: 3431 RVA: 0x0000B25D File Offset: 0x0000945D
		public virtual object GetService(Type service)
		{
			if (this.mySite != null)
			{
				return this.mySite.GetService(service);
			}
			return null;
		}

		/// <summary>Gets the container for the component.</summary>
		/// <returns>An object implementing the <see cref="T:System.ComponentModel.IContainer" /> interface that represents the component's container, or null if the component does not have a site.</returns>
		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x0000B278 File Offset: 0x00009478
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual IContainer Container
		{
			get
			{
				if (this.mySite == null)
				{
					return null;
				}
				return this.mySite.Container;
			}
		}

		/// <summary>Gets a value indicating whether the component is currently in design mode.</summary>
		/// <returns>true if the component is in design mode; otherwise, false.</returns>
		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x0000B292 File Offset: 0x00009492
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual bool DesignMode
		{
			get
			{
				return this.mySite != null && this.mySite.DesignMode;
			}
		}

		/// <summary>Gets or sets the site of the component.</summary>
		/// <returns>An object implementing the <see cref="T:System.ComponentModel.ISite" /> interface that represents the site of the component.</returns>
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x0000B2AC File Offset: 0x000094AC
		// (set) Token: 0x06000D6B RID: 3435 RVA: 0x0000B2B4 File Offset: 0x000094B4
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public virtual ISite Site
		{
			get
			{
				return this.mySite;
			}
			set
			{
				this.mySite = value;
			}
		}

		/// <summary>Returns a <see cref="T:System.String" /> containing the name of the <see cref="T:System.ComponentModel.Component" />, if any. This method should not be overridden.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the name of the <see cref="T:System.ComponentModel.Component" />, if any.null if the <see cref="T:System.ComponentModel.Component" /> is unnamed.</returns>
		// Token: 0x06000D6C RID: 3436 RVA: 0x0000B2BD File Offset: 0x000094BD
		public override string ToString()
		{
			if (this.mySite == null)
			{
				return base.GetType().ToString();
			}
			return string.Format("{0} [{1}]", this.mySite.Name, base.GetType().ToString());
		}

		/// <summary>Gets the list of event handlers that are attached to this component.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.EventHandlerList" /> that provides the delegates for this component.</returns>
		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x0000B2F6 File Offset: 0x000094F6
		protected EventHandlerList Events
		{
			get
			{
				if (this.eventList == null)
				{
					this.eventList = new EventHandlerList();
				}
				return this.eventList;
			}
		}

		// Token: 0x040003BE RID: 958
		private EventHandlerList eventList;

		// Token: 0x040003BF RID: 959
		private ISite mySite;

		// Token: 0x040003C0 RID: 960
		private object disposedEvent = new object();
	}
}
