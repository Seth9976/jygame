using System;

namespace System.Net.Sockets
{
	/// <summary>Contains <see cref="T:System.Net.IPAddress" /> values used to join and drop multicast groups.</summary>
	// Token: 0x0200040A RID: 1034
	public class MulticastOption
	{
		/// <summary>Initializes a new version of the <see cref="T:System.Net.Sockets.MulticastOption" /> class for the specified IP multicast group.</summary>
		/// <param name="group">The <see cref="T:System.Net.IPAddress" /> of the multicast group. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="group" /> is null. </exception>
		// Token: 0x06002341 RID: 9025 RVA: 0x00018E4A File Offset: 0x0001704A
		public MulticastOption(IPAddress group)
			: this(group, IPAddress.Any)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.MulticastOption" /> class with the specified IP multicast group address and interface index.</summary>
		/// <param name="group">The <see cref="T:System.Net.IPAddress" /> of the multicast group.</param>
		/// <param name="interfaceIndex">The index of the interface that is used to send and receive multicast packets.</param>
		// Token: 0x06002342 RID: 9026 RVA: 0x000659AC File Offset: 0x00063BAC
		public MulticastOption(IPAddress group, int interfaceIndex)
		{
			if (group == null)
			{
				throw new ArgumentNullException("group");
			}
			if (interfaceIndex < 0 || interfaceIndex > 16777215)
			{
				throw new ArgumentOutOfRangeException("interfaceIndex");
			}
			this.group = group;
			this.iface_index = interfaceIndex;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.MulticastOption" /> class with the specified IP multicast group address and local IP address associated with a network interface.</summary>
		/// <param name="group">The group <see cref="T:System.Net.IPAddress" />. </param>
		/// <param name="mcint">The local <see cref="T:System.Net.IPAddress" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="group" /> is null.-or- <paramref name="mcint" /> is null. </exception>
		// Token: 0x06002343 RID: 9027 RVA: 0x00018E58 File Offset: 0x00017058
		public MulticastOption(IPAddress group, IPAddress mcint)
		{
			if (group == null)
			{
				throw new ArgumentNullException("group");
			}
			if (mcint == null)
			{
				throw new ArgumentNullException("mcint");
			}
			this.group = group;
			this.local = mcint;
		}

		/// <summary>Gets or sets the IP address of a multicast group.</summary>
		/// <returns>An <see cref="T:System.Net.IPAddress" /> that contains the Internet address of a multicast group.</returns>
		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06002344 RID: 9028 RVA: 0x00018E90 File Offset: 0x00017090
		// (set) Token: 0x06002345 RID: 9029 RVA: 0x00018E98 File Offset: 0x00017098
		public IPAddress Group
		{
			get
			{
				return this.group;
			}
			set
			{
				this.group = value;
			}
		}

		/// <summary>Gets or sets the local address associated with a multicast group.</summary>
		/// <returns>An <see cref="T:System.Net.IPAddress" /> that contains the local address associated with a multicast group.</returns>
		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06002346 RID: 9030 RVA: 0x00018EA1 File Offset: 0x000170A1
		// (set) Token: 0x06002347 RID: 9031 RVA: 0x00018EA9 File Offset: 0x000170A9
		public IPAddress LocalAddress
		{
			get
			{
				return this.local;
			}
			set
			{
				this.local = value;
				this.iface_index = 0;
			}
		}

		/// <summary>Gets or sets the index of the interface that is used to send and receive multicast packets. </summary>
		/// <returns>An integer that represents the index of a <see cref="T:System.Net.NetworkInformation.NetworkInterface" /> array element.</returns>
		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06002348 RID: 9032 RVA: 0x00018EB9 File Offset: 0x000170B9
		// (set) Token: 0x06002349 RID: 9033 RVA: 0x00018EC1 File Offset: 0x000170C1
		public int InterfaceIndex
		{
			get
			{
				return this.iface_index;
			}
			set
			{
				if (value < 0 || value > 16777215)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.iface_index = value;
				this.local = null;
			}
		}

		// Token: 0x040015A4 RID: 5540
		private IPAddress group;

		// Token: 0x040015A5 RID: 5541
		private IPAddress local;

		// Token: 0x040015A6 RID: 5542
		private int iface_index;
	}
}
