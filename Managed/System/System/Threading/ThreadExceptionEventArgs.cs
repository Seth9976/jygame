using System;

namespace System.Threading
{
	/// <summary>Provides data for the <see cref="E:System.Windows.Forms.Application.ThreadException" /> event.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x020004CA RID: 1226
	public class ThreadExceptionEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.ThreadExceptionEventArgs" /> class.</summary>
		/// <param name="t">The <see cref="T:System.Exception" /> that occurred. </param>
		// Token: 0x06002B75 RID: 11125 RVA: 0x0001E362 File Offset: 0x0001C562
		public ThreadExceptionEventArgs(Exception t)
		{
			this.exception = t;
		}

		/// <summary>Gets the <see cref="T:System.Exception" /> that occurred.</summary>
		/// <returns>The <see cref="T:System.Exception" /> that occurred.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06002B76 RID: 11126 RVA: 0x0001E371 File Offset: 0x0001C571
		public Exception Exception
		{
			get
			{
				return this.exception;
			}
		}

		// Token: 0x04001B40 RID: 6976
		private Exception exception;
	}
}
