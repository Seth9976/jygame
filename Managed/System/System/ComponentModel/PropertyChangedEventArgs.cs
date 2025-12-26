using System;

namespace System.ComponentModel
{
	/// <summary>Provides data for the <see cref="E:System.ComponentModel.INotifyPropertyChanged.PropertyChanged" /> event.</summary>
	// Token: 0x02000199 RID: 409
	public class PropertyChangedEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyChangedEventArgs" /> class.</summary>
		/// <param name="propertyName">The name of the property that changed. </param>
		// Token: 0x06000E37 RID: 3639 RVA: 0x0000BDD5 File Offset: 0x00009FD5
		public PropertyChangedEventArgs(string name)
		{
			this.propertyName = name;
		}

		/// <summary>Gets the name of the property that changed.</summary>
		/// <returns>The name of the property that changed.</returns>
		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x0000BDE4 File Offset: 0x00009FE4
		public virtual string PropertyName
		{
			get
			{
				return this.propertyName;
			}
		}

		// Token: 0x04000412 RID: 1042
		private string propertyName;
	}
}
