using System;
using System.ComponentModel;

namespace System.Net.NetworkInformation
{
	/// <summary>Provides data for the <see cref="E:System.Net.NetworkInformation.Ping.PingCompleted" /> event.</summary>
	// Token: 0x020003C8 RID: 968
	public class PingCompletedEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
	{
		// Token: 0x06002153 RID: 8531 RVA: 0x00017C06 File Offset: 0x00015E06
		internal PingCompletedEventArgs(Exception ex, bool cancelled, object userState, PingReply reply)
			: base(ex, cancelled, userState)
		{
			this.reply = reply;
		}

		/// <summary>Gets an object that contains data that describes an attempt to send an Internet Control Message Protocol (ICMP) echo request message and receive a corresponding ICMP echo reply message.</summary>
		/// <returns>A <see cref="T:System.Net.NetworkInformation.PingReply" /> object that describes the results of the ICMP echo request.</returns>
		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x00017C19 File Offset: 0x00015E19
		public PingReply Reply
		{
			get
			{
				return this.reply;
			}
		}

		// Token: 0x04001436 RID: 5174
		private PingReply reply;
	}
}
