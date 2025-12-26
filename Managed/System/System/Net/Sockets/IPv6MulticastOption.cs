using System;

namespace System.Net.Sockets
{
	/// <summary>Contains option values for joining an IPv6 multicast group.</summary>
	// Token: 0x02000407 RID: 1031
	public class IPv6MulticastOption
	{
		/// <summary>Initializes a new version of the <see cref="T:System.Net.Sockets.IPv6MulticastOption" /> class for the specified IP multicast group.</summary>
		/// <param name="group">The <see cref="T:System.Net.IPAddress" /> of the multicast group. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="group" /> is null. </exception>
		// Token: 0x0600232F RID: 9007 RVA: 0x00018D64 File Offset: 0x00016F64
		public IPv6MulticastOption(IPAddress group)
			: this(group, 0L)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.IPv6MulticastOption" /> class with the specified IP multicast group and the local interface address.</summary>
		/// <param name="group">The group <see cref="T:System.Net.IPAddress" />. </param>
		/// <param name="ifindex">The local interface address. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="ifindex" /> is less than 0.-or- <paramref name="ifindex" /> is greater than 0x00000000FFFFFFFF. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="group" /> is null. </exception>
		// Token: 0x06002330 RID: 9008 RVA: 0x00065914 File Offset: 0x00063B14
		public IPv6MulticastOption(IPAddress group, long ifindex)
		{
			if (group == null)
			{
				throw new ArgumentNullException("group");
			}
			if (ifindex < 0L || ifindex > (long)((ulong)(-1)))
			{
				throw new ArgumentOutOfRangeException("ifindex");
			}
			this.group = group;
			this.ifIndex = ifindex;
		}

		/// <summary>Gets or sets the IP address of a multicast group.</summary>
		/// <returns>An <see cref="T:System.Net.IPAddress" /> that contains the Internet address of a multicast group.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="group" /> is null. </exception>
		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x00018D6F File Offset: 0x00016F6F
		// (set) Token: 0x06002332 RID: 9010 RVA: 0x00018D77 File Offset: 0x00016F77
		public IPAddress Group
		{
			get
			{
				return this.group;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.group = value;
			}
		}

		/// <summary>Gets or sets the interface index that is associated with a multicast group.</summary>
		/// <returns>A <see cref="T:System.UInt64" /> value that specifies the address of the interface.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value that is specified for a set operation is less than 0 or greater than 0x00000000FFFFFFFF. </exception>
		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06002333 RID: 9011 RVA: 0x00018D91 File Offset: 0x00016F91
		// (set) Token: 0x06002334 RID: 9012 RVA: 0x00018D99 File Offset: 0x00016F99
		public long InterfaceIndex
		{
			get
			{
				return this.ifIndex;
			}
			set
			{
				if (value < 0L || value > (long)((ulong)(-1)))
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.ifIndex = value;
			}
		}

		// Token: 0x0400159E RID: 5534
		private IPAddress group;

		// Token: 0x0400159F RID: 5535
		private long ifIndex;
	}
}
