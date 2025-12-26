using System;

namespace System.ComponentModel
{
	/// <summary>Provides data for the <see cref="E:System.ComponentModel.BackgroundWorker.DoWork" /> event handler.</summary>
	// Token: 0x02000146 RID: 326
	public class DoWorkEventArgs : CancelEventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DoWorkEventArgs" /> class.</summary>
		/// <param name="argument">Specifies an argument for an asynchronous operation.</param>
		// Token: 0x06000BF6 RID: 3062 RVA: 0x0000A5EA File Offset: 0x000087EA
		public DoWorkEventArgs(object argument)
		{
			this.arg = argument;
		}

		/// <summary>Gets a value that represents the argument of an asynchronous operation.</summary>
		/// <returns>An <see cref="T:System.Object" /> representing the argument of an asynchronous operation.</returns>
		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x0000A5F9 File Offset: 0x000087F9
		public object Argument
		{
			get
			{
				return this.arg;
			}
		}

		/// <summary>Gets or sets a value that represents the result of an asynchronous operation.</summary>
		/// <returns>An <see cref="T:System.Object" /> representing the result of an asynchronous operation.</returns>
		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x0000A601 File Offset: 0x00008801
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x0000A609 File Offset: 0x00008809
		public object Result
		{
			get
			{
				return this.result;
			}
			set
			{
				this.result = value;
			}
		}

		// Token: 0x0400036E RID: 878
		private object arg;

		// Token: 0x0400036F RID: 879
		private object result;
	}
}
