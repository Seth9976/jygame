using System;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	/// <summary>Provides functionality required by all components. </summary>
	// Token: 0x02000159 RID: 345
	[ComVisible(true)]
	[TypeConverter(typeof(ComponentConverter))]
	[Designer("System.Windows.Forms.Design.ComponentDocumentDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(global::System.ComponentModel.Design.IRootDesigner))]
	[global::System.ComponentModel.Design.Serialization.RootDesignerSerializer("System.ComponentModel.Design.Serialization.RootCodeDomSerializer, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true)]
	[Designer("System.ComponentModel.Design.ComponentDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(global::System.ComponentModel.Design.IDesigner))]
	public interface IComponent : IDisposable
	{
		/// <summary>Represents the method that handles the <see cref="E:System.ComponentModel.IComponent.Disposed" /> event of a component.</summary>
		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06000C90 RID: 3216
		// (remove) Token: 0x06000C91 RID: 3217
		event EventHandler Disposed;

		/// <summary>Gets or sets the <see cref="T:System.ComponentModel.ISite" /> associated with the <see cref="T:System.ComponentModel.IComponent" />.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.ISite" /> object associated with the component; or null, if the component does not have a site.</returns>
		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000C92 RID: 3218
		// (set) Token: 0x06000C93 RID: 3219
		ISite Site { get; set; }
	}
}
