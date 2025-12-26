using System;

namespace System.ComponentModel
{
	/// <summary>Provides data for a cancelable event.</summary>
	// Token: 0x020000DA RID: 218
	public class CancelEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.CancelEventArgs" /> class with the <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property set to false.</summary>
		// Token: 0x0600094F RID: 2383 RVA: 0x00008CCF File Offset: 0x00006ECF
		public CancelEventArgs()
		{
			this.cancel = false;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.CancelEventArgs" /> class with the <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property set to the given value.</summary>
		/// <param name="cancel">true to cancel the event; otherwise, false. </param>
		// Token: 0x06000950 RID: 2384 RVA: 0x00008CDE File Offset: 0x00006EDE
		public CancelEventArgs(bool cancel)
		{
			this.cancel = cancel;
		}

		/// <summary>Gets or sets a value indicating whether the event should be canceled.</summary>
		/// <returns>true if the event should be canceled; otherwise, false.</returns>
		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x00008CED File Offset: 0x00006EED
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x00008CF5 File Offset: 0x00006EF5
		public bool Cancel
		{
			get
			{
				return this.cancel;
			}
			set
			{
				this.cancel = value;
			}
		}

		// Token: 0x04000279 RID: 633
		private bool cancel;
	}
}
