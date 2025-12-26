using System;

namespace System.ComponentModel.Design
{
	/// <summary>Provides data for the <see cref="P:System.ComponentModel.Design.IDesignerEventService.ActiveDesigner" /> event.</summary>
	// Token: 0x020000F8 RID: 248
	public class ActiveDesignerEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.ActiveDesignerEventArgs" /> class.</summary>
		/// <param name="oldDesigner">The document that is losing activation. </param>
		/// <param name="newDesigner">The document that is gaining activation. </param>
		// Token: 0x06000A1F RID: 2591 RVA: 0x000096F2 File Offset: 0x000078F2
		public ActiveDesignerEventArgs(IDesignerHost oldDesigner, IDesignerHost newDesigner)
		{
			this.oldDesigner = oldDesigner;
			this.newDesigner = newDesigner;
		}

		/// <summary>Gets the document that is gaining activation.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.Design.IDesignerHost" /> that represents the document gaining activation.</returns>
		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x00009708 File Offset: 0x00007908
		public IDesignerHost NewDesigner
		{
			get
			{
				return this.newDesigner;
			}
		}

		/// <summary>Gets the document that is losing activation.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.Design.IDesignerHost" /> that represents the document losing activation.</returns>
		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00009710 File Offset: 0x00007910
		public IDesignerHost OldDesigner
		{
			get
			{
				return this.oldDesigner;
			}
		}

		// Token: 0x040002BA RID: 698
		private IDesignerHost oldDesigner;

		// Token: 0x040002BB RID: 699
		private IDesignerHost newDesigner;
	}
}
