using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Provides Transmission Control Protocol (TCP) statistical data.</summary>
	// Token: 0x020003D6 RID: 982
	public abstract class TcpStatistics
	{
		/// <summary>Gets the number of accepted Transmission Control Protocol (TCP) connection requests.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of TCP connection requests accepted.</returns>
		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06002197 RID: 8599
		public abstract long ConnectionsAccepted { get; }

		/// <summary>Gets the number of Transmission Control Protocol (TCP) connection requests made by clients.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of TCP connections initiated by clients.</returns>
		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06002198 RID: 8600
		public abstract long ConnectionsInitiated { get; }

		/// <summary>Specifies the total number of Transmission Control Protocol (TCP) connections established.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of connections established.</returns>
		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06002199 RID: 8601
		public abstract long CumulativeConnections { get; }

		/// <summary>Gets the number of current Transmission Control Protocol (TCP) connections.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of current TCP connections.</returns>
		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x0600219A RID: 8602
		public abstract long CurrentConnections { get; }

		/// <summary>Gets the number of Transmission Control Protocol (TCP) errors received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of TCP errors received.</returns>
		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x0600219B RID: 8603
		public abstract long ErrorsReceived { get; }

		/// <summary>Gets the number of failed Transmission Control Protocol (TCP) connection attempts.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of failed TCP connection attempts.</returns>
		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x0600219C RID: 8604
		public abstract long FailedConnectionAttempts { get; }

		/// <summary>Gets the maximum number of supported Transmission Control Protocol (TCP) connections.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of TCP connections that can be supported.</returns>
		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x0600219D RID: 8605
		public abstract long MaximumConnections { get; }

		/// <summary>Gets the maximum retransmission time-out value for Transmission Control Protocol (TCP) segments.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the maximum number of milliseconds permitted by a TCP implementation for the retransmission time-out value.</returns>
		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x0600219E RID: 8606
		public abstract long MaximumTransmissionTimeout { get; }

		/// <summary>Gets the minimum retransmission time-out value for Transmission Control Protocol (TCP) segments.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the minimum number of milliseconds permitted by a TCP implementation for the retransmission time-out value.</returns>
		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x0600219F RID: 8607
		public abstract long MinimumTransmissionTimeout { get; }

		/// <summary>Gets the number of RST packets received by Transmission Control Protocol (TCP) connections.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of reset TCP connections.</returns>
		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x060021A0 RID: 8608
		public abstract long ResetConnections { get; }

		/// <summary>Gets the number of Transmission Control Protocol (TCP) segments sent with the reset flag set.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of TCP segments sent with the reset flag set.</returns>
		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x060021A1 RID: 8609
		public abstract long ResetsSent { get; }

		/// <summary>Gets the number of Transmission Control Protocol (TCP) segments received.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of TCP segments received.</returns>
		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x060021A2 RID: 8610
		public abstract long SegmentsReceived { get; }

		/// <summary>Gets the number of Transmission Control Protocol (TCP) segments re-sent.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of TCP segments retransmitted.</returns>
		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x060021A3 RID: 8611
		public abstract long SegmentsResent { get; }

		/// <summary>Gets the number of Transmission Control Protocol (TCP) segments sent.</summary>
		/// <returns>An <see cref="T:System.Int64" /> value that specifies the total number of TCP segments sent.</returns>
		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x060021A4 RID: 8612
		public abstract long SegmentsSent { get; }
	}
}
