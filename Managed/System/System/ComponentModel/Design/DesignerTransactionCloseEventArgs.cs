using System;
using System.Runtime.InteropServices;

namespace System.ComponentModel.Design
{
	/// <summary>Provides data for the <see cref="E:System.ComponentModel.Design.IDesignerHost.TransactionClosed" /> and <see cref="E:System.ComponentModel.Design.IDesignerHost.TransactionClosing" /> events.</summary>
	// Token: 0x02000104 RID: 260
	[ComVisible(true)]
	public class DesignerTransactionCloseEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.DesignerTransactionCloseEventArgs" /> class. </summary>
		/// <param name="commit">A value indicating whether the transaction was committed.</param>
		/// <param name="lastTransaction">true if this is the last transaction to close; otherwise, false.</param>
		// Token: 0x06000A72 RID: 2674 RVA: 0x00009A74 File Offset: 0x00007C74
		public DesignerTransactionCloseEventArgs(bool commit, bool lastTransaction)
		{
			this.commit = commit;
			this.last_transaction = lastTransaction;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.DesignerTransactionCloseEventArgs" /> class, using the specified value that indicates whether the designer called <see cref="M:System.ComponentModel.Design.DesignerTransaction.Commit" /> on the transaction.</summary>
		/// <param name="commit">A value indicating whether the transaction was committed.</param>
		// Token: 0x06000A73 RID: 2675 RVA: 0x00009A8A File Offset: 0x00007C8A
		[Obsolete("Use another constructor that indicates lastTransaction")]
		public DesignerTransactionCloseEventArgs(bool commit)
		{
			this.commit = commit;
		}

		/// <summary>Gets a value indicating whether this is the last transaction to close.</summary>
		/// <returns>true, if this is the last transaction to close; otherwise, false. </returns>
		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x00009A99 File Offset: 0x00007C99
		public bool LastTransaction
		{
			get
			{
				return this.last_transaction;
			}
		}

		/// <summary>Indicates whether the designer called <see cref="M:System.ComponentModel.Design.DesignerTransaction.Commit" /> on the transaction.</summary>
		/// <returns>true if the designer called <see cref="M:System.ComponentModel.Design.DesignerTransaction.Commit" /> on the transaction; otherwise, false.</returns>
		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00009AA1 File Offset: 0x00007CA1
		public bool TransactionCommitted
		{
			get
			{
				return this.commit;
			}
		}

		// Token: 0x040002D3 RID: 723
		private bool commit;

		// Token: 0x040002D4 RID: 724
		private bool last_transaction;
	}
}
