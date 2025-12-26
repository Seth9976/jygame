using System;

namespace System.ComponentModel
{
	/// <summary>Represents the method that will handle the <see cref="E:System.ComponentModel.BackgroundWorker.DoWork" /> event. This class cannot be inherited.</summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">A <see cref="T:System.ComponentModel.DoWorkEventArgs" />    that contains the event data.</param>
	// Token: 0x0200050B RID: 1291
	// (Invoke) Token: 0x06002CE0 RID: 11488
	public delegate void DoWorkEventHandler(object sender, DoWorkEventArgs e);
}
