using System;
using System.Runtime.InteropServices;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Provides a basic designer loader interface that can be used to implement a custom designer loader.</summary>
	// Token: 0x0200012F RID: 303
	[ComVisible(true)]
	public abstract class DesignerLoader
	{
		/// <summary>Gets a value indicating whether the loader is currently loading a document.</summary>
		/// <returns>true if the loader is currently loading a document; otherwise, false.</returns>
		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public virtual bool Loading
		{
			get
			{
				return false;
			}
		}

		/// <summary>Begins loading a designer.</summary>
		/// <param name="host">The loader host through which this loader loads components. </param>
		// Token: 0x06000B7B RID: 2939
		public abstract void BeginLoad(IDesignerLoaderHost host);

		/// <summary>Releases all resources used by the <see cref="T:System.ComponentModel.Design.Serialization.DesignerLoader" />.</summary>
		// Token: 0x06000B7C RID: 2940
		public abstract void Dispose();

		/// <summary>Writes cached changes to the location that the designer was loaded from.</summary>
		// Token: 0x06000B7D RID: 2941 RVA: 0x000029F5 File Offset: 0x00000BF5
		public virtual void Flush()
		{
		}
	}
}
