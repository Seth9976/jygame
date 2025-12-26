using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Provides information about the status and data resulting from a <see cref="Overload:System.Net.NetworkInformation.Ping.Send" /> or <see cref="Overload:System.Net.NetworkInformation.Ping.SendAsync" /> operation.</summary>
	// Token: 0x020003D0 RID: 976
	public class PingReply
	{
		// Token: 0x06002188 RID: 8584 RVA: 0x00017E8F File Offset: 0x0001608F
		internal PingReply(IPAddress address, byte[] buffer, PingOptions options, long roundtripTime, IPStatus status)
		{
			this.address = address;
			this.buffer = buffer;
			this.options = options;
			this.rtt = roundtripTime;
			this.status = status;
		}

		/// <summary>Gets the address of the host that sends the Internet Control Message Protocol (ICMP) echo reply.</summary>
		/// <returns>An <see cref="T:System.Net.IPAddress" /> containing the destination for the ICMP echo message.</returns>
		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06002189 RID: 8585 RVA: 0x00017EBC File Offset: 0x000160BC
		public IPAddress Address
		{
			get
			{
				return this.address;
			}
		}

		/// <summary>Gets the buffer of data received in an Internet Control Message Protocol (ICMP) echo reply message.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array containing the data received in an ICMP echo reply message, or an empty array, if no reply was received.</returns>
		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x00017EC4 File Offset: 0x000160C4
		public byte[] Buffer
		{
			get
			{
				return this.buffer;
			}
		}

		/// <summary>Gets the options used to transmit the reply to an Internet Control Message Protocol (ICMP) echo request.</summary>
		/// <returns>A <see cref="T:System.Net.NetworkInformation.PingOptions" /> object that contains the Time to Live (TTL) and the fragmentation directive used for transmitting the reply if <see cref="P:System.Net.NetworkInformation.PingReply.Status" /> is <see cref="F:System.Net.NetworkInformation.IPStatus.Success" />; otherwise, null.</returns>
		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x0600218B RID: 8587 RVA: 0x00017ECC File Offset: 0x000160CC
		public PingOptions Options
		{
			get
			{
				return this.options;
			}
		}

		/// <summary>Gets the number of milliseconds taken to send an Internet Control Message Protocol (ICMP) echo request and receive the corresponding ICMP echo reply message.</summary>
		/// <returns>An <see cref="T:System.Int64" /> that specifies the round trip time, in milliseconds. </returns>
		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x0600218C RID: 8588 RVA: 0x00017ED4 File Offset: 0x000160D4
		public long RoundtripTime
		{
			get
			{
				return this.rtt;
			}
		}

		/// <summary>Gets the status of an attempt to send an Internet Control Message Protocol (ICMP) echo request and receive the corresponding ICMP echo reply message.</summary>
		/// <returns>An <see cref="T:System.Net.NetworkInformation.IPStatus" /> value indicating the result of the request.</returns>
		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x0600218D RID: 8589 RVA: 0x00017EDC File Offset: 0x000160DC
		public IPStatus Status
		{
			get
			{
				return this.status;
			}
		}

		// Token: 0x0400144E RID: 5198
		private IPAddress address;

		// Token: 0x0400144F RID: 5199
		private byte[] buffer;

		// Token: 0x04001450 RID: 5200
		private PingOptions options;

		// Token: 0x04001451 RID: 5201
		private long rtt;

		// Token: 0x04001452 RID: 5202
		private IPStatus status;
	}
}
