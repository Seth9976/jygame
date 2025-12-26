using System;
using System.ComponentModel;

namespace System.Net.Mail
{
	/// <summary>Represents the method that will handle the <see cref="E:System.Net.Mail.SmtpClient.SendCompleted" /> event.</summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">An <see cref="T:System.ComponentModel.AsyncCompletedEventArgs" /> containing event data.</param>
	// Token: 0x02000520 RID: 1312
	// (Invoke) Token: 0x06002D34 RID: 11572
	public delegate void SendCompletedEventHandler(object sender, global::System.ComponentModel.AsyncCompletedEventArgs e);
}
