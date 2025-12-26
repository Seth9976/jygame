using System;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Provides data for the <see cref="E:System.ComponentModel.Design.Serialization.IDesignerSerializationManager.ResolveName" /> event.</summary>
	// Token: 0x0200013B RID: 315
	public class ResolveNameEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.Serialization.ResolveNameEventArgs" /> class.</summary>
		/// <param name="name">The name to resolve. </param>
		// Token: 0x06000BBD RID: 3005 RVA: 0x0000A347 File Offset: 0x00008547
		public ResolveNameEventArgs(string name)
		{
			this.name = name;
		}

		/// <summary>Gets the name of the object to resolve.</summary>
		/// <returns>The name of the object to resolve.</returns>
		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x0000A356 File Offset: 0x00008556
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets or sets the object that matches the name.</summary>
		/// <returns>The object that the name is associated with.</returns>
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x0000A35E File Offset: 0x0000855E
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x0000A366 File Offset: 0x00008566
		public object Value
		{
			get
			{
				return this.value;
			}
			set
			{
				this.value = value;
			}
		}

		// Token: 0x0400031C RID: 796
		private string name;

		// Token: 0x0400031D RID: 797
		private object value;
	}
}
