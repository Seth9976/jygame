using System;

namespace System.ComponentModel
{
	/// <summary>Provides data for the <see cref="E:System.ComponentModel.BackgroundWorker.ProgressChanged" /> event.</summary>
	// Token: 0x020004DD RID: 1245
	public class ProgressChangedEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ProgressChangedEventArgs" /> class.</summary>
		/// <param name="progressPercentage">The percentage of an asynchronous task that has been completed.</param>
		/// <param name="userState">A unique user state.</param>
		// Token: 0x06002C3E RID: 11326 RVA: 0x0001E9E4 File Offset: 0x0001CBE4
		public ProgressChangedEventArgs(int progressPercentage, object userState)
		{
			this.progress = progressPercentage;
			this.state = userState;
		}

		/// <summary>Gets the asynchronous task progress percentage.</summary>
		/// <returns>A percentage value indicating the asynchronous task progress.</returns>
		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06002C3F RID: 11327 RVA: 0x0001E9FA File Offset: 0x0001CBFA
		public int ProgressPercentage
		{
			get
			{
				return this.progress;
			}
		}

		/// <summary>Gets a unique user state.</summary>
		/// <returns>A unique <see cref="T:System.Object" /> indicating the user state.</returns>
		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06002C40 RID: 11328 RVA: 0x0001EA02 File Offset: 0x0001CC02
		public object UserState
		{
			get
			{
				return this.state;
			}
		}

		// Token: 0x04001BB3 RID: 7091
		private int progress;

		// Token: 0x04001BB4 RID: 7092
		private object state;
	}
}
