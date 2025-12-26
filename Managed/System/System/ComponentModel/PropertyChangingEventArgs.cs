using System;

namespace System.ComponentModel
{
	/// <summary>Provides data for the <see cref="E:System.ComponentModel.INotifyPropertyChanging.PropertyChanging" /> event. </summary>
	// Token: 0x0200019A RID: 410
	public class PropertyChangingEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyChangingEventArgs" /> class. </summary>
		/// <param name="propertyName">The name of the property whose value is changing.</param>
		// Token: 0x06000E39 RID: 3641 RVA: 0x0000BDEC File Offset: 0x00009FEC
		public PropertyChangingEventArgs(string propertyName)
		{
			this.name = propertyName;
		}

		/// <summary>Gets the name of the property whose value is changing.</summary>
		/// <returns>The name of the property whose value is changing.</returns>
		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x0000BDFB File Offset: 0x00009FFB
		public virtual string PropertyName
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x04000413 RID: 1043
		private string name;
	}
}
