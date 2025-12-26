using System;

namespace System.Diagnostics
{
	/// <summary>Provides data for the <see cref="E:System.Diagnostics.Process.OutputDataReceived" /> and <see cref="E:System.Diagnostics.Process.ErrorDataReceived" /> events.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000219 RID: 537
	public class DataReceivedEventArgs : EventArgs
	{
		// Token: 0x060011E4 RID: 4580 RVA: 0x0000E6D4 File Offset: 0x0000C8D4
		internal DataReceivedEventArgs(string data)
		{
			this.data = data;
		}

		/// <summary>Gets the line of characters that was written to a redirected <see cref="T:System.Diagnostics.Process" /> output stream.</summary>
		/// <returns>The line that was written by an associated <see cref="T:System.Diagnostics.Process" /> to its redirected <see cref="P:System.Diagnostics.Process.StandardOutput" /> or <see cref="P:System.Diagnostics.Process.StandardError" /> stream.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x0000E6E3 File Offset: 0x0000C8E3
		public string Data
		{
			get
			{
				return this.data;
			}
		}

		// Token: 0x04000529 RID: 1321
		private string data;
	}
}
