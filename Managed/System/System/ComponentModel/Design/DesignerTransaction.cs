using System;

namespace System.ComponentModel.Design
{
	/// <summary>Provides a way to group a series of design-time actions to improve performance and enable most types of changes to be undone.</summary>
	// Token: 0x02000105 RID: 261
	public abstract class DesignerTransaction : IDisposable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.DesignerTransaction" /> class with no description.</summary>
		// Token: 0x06000A76 RID: 2678 RVA: 0x00009AA9 File Offset: 0x00007CA9
		protected DesignerTransaction()
			: this(string.Empty)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.DesignerTransaction" /> class using the specified transaction description.</summary>
		/// <param name="description">A description for this transaction. </param>
		// Token: 0x06000A77 RID: 2679 RVA: 0x00009AB6 File Offset: 0x00007CB6
		protected DesignerTransaction(string description)
		{
			this.description = description;
			this.committed = false;
			this.canceled = false;
		}

		/// <summary>Releases all resources used by the <see cref="T:System.ComponentModel.Design.DesignerTransaction" />. </summary>
		// Token: 0x06000A78 RID: 2680 RVA: 0x00009AD3 File Offset: 0x00007CD3
		void IDisposable.Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.ComponentModel.Design.DesignerTransaction" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
		// Token: 0x06000A79 RID: 2681 RVA: 0x00009ADC File Offset: 0x00007CDC
		protected virtual void Dispose(bool disposing)
		{
			this.Cancel();
			if (disposing)
			{
				GC.SuppressFinalize(true);
			}
		}

		/// <summary>Raises the Cancel event.</summary>
		// Token: 0x06000A7A RID: 2682
		protected abstract void OnCancel();

		/// <summary>Performs the actual work of committing a transaction.</summary>
		// Token: 0x06000A7B RID: 2683
		protected abstract void OnCommit();

		/// <summary>Cancels the transaction and attempts to roll back the changes made by the events of the transaction.</summary>
		// Token: 0x06000A7C RID: 2684 RVA: 0x00009AF5 File Offset: 0x00007CF5
		public void Cancel()
		{
			if (!this.Canceled && !this.Committed)
			{
				this.canceled = true;
				this.OnCancel();
			}
		}

		/// <summary>Commits this transaction.</summary>
		// Token: 0x06000A7D RID: 2685 RVA: 0x00009B1A File Offset: 0x00007D1A
		public void Commit()
		{
			if (!this.Canceled && !this.Committed)
			{
				this.committed = true;
				this.OnCommit();
			}
		}

		/// <summary>Gets a value indicating whether the transaction was canceled.</summary>
		/// <returns>true if the transaction was canceled; otherwise, false.</returns>
		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x00009B3F File Offset: 0x00007D3F
		public bool Canceled
		{
			get
			{
				return this.canceled;
			}
		}

		/// <summary>Gets a value indicating whether the transaction was committed.</summary>
		/// <returns>true if the transaction was committed; otherwise, false.</returns>
		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00009B47 File Offset: 0x00007D47
		public bool Committed
		{
			get
			{
				return this.committed;
			}
		}

		/// <summary>Gets a description for the transaction.</summary>
		/// <returns>A description for the transaction.</returns>
		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x00009B4F File Offset: 0x00007D4F
		public string Description
		{
			get
			{
				return this.description;
			}
		}

		/// <summary>Releases the resources associated with this object. This override commits this transaction if it was not already committed.</summary>
		// Token: 0x06000A81 RID: 2689 RVA: 0x00030614 File Offset: 0x0002E814
		~DesignerTransaction()
		{
			this.Dispose(false);
		}

		// Token: 0x040002D5 RID: 725
		private string description;

		// Token: 0x040002D6 RID: 726
		private bool committed;

		// Token: 0x040002D7 RID: 727
		private bool canceled;
	}
}
