using System;

namespace System.Net.NetworkInformation
{
	/// <summary>Used to control how <see cref="T:System.Net.NetworkInformation.Ping" /> data packets are transmitted.</summary>
	// Token: 0x020003CF RID: 975
	public class PingOptions
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkInformation.PingOptions" /> class.</summary>
		// Token: 0x06002182 RID: 8578 RVA: 0x00017E22 File Offset: 0x00016022
		public PingOptions()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkInformation.PingOptions" /> class and sets the Time to Live and fragmentation values.</summary>
		/// <param name="ttl">An <see cref="T:System.Int32" /> value greater than zero that specifies the number of times that the <see cref="T:System.Net.NetworkInformation.Ping" /> data packets can be forwarded.</param>
		/// <param name="dontFragment">true to prevent data sent to the remote host from being fragmented; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="ttl " />is less than or equal to zero.</exception>
		// Token: 0x06002183 RID: 8579 RVA: 0x00017E35 File Offset: 0x00016035
		public PingOptions(int ttl, bool dontFragment)
		{
			if (ttl <= 0)
			{
				throw new ArgumentOutOfRangeException("Must be greater than zero.", "ttl");
			}
			this.ttl = ttl;
			this.dont_fragment = dontFragment;
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that controls fragmentation of the data sent to the remote host.</summary>
		/// <returns>true if the data cannot be sent in multiple packets; otherwise false. The default is false.</returns>
		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x00017E6D File Offset: 0x0001606D
		// (set) Token: 0x06002185 RID: 8581 RVA: 0x00017E75 File Offset: 0x00016075
		public bool DontFragment
		{
			get
			{
				return this.dont_fragment;
			}
			set
			{
				this.dont_fragment = value;
			}
		}

		/// <summary>Gets or sets the number of routing nodes that can forward the <see cref="T:System.Net.NetworkInformation.Ping" /> data before it is discarded.</summary>
		/// <returns>An <see cref="T:System.Int32" /> value that specifies the number of times the <see cref="T:System.Net.NetworkInformation.Ping" /> data packets can be forwarded. The default is 128.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is less than or equal to zero.</exception>
		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06002186 RID: 8582 RVA: 0x00017E7E File Offset: 0x0001607E
		// (set) Token: 0x06002187 RID: 8583 RVA: 0x00017E86 File Offset: 0x00016086
		public int Ttl
		{
			get
			{
				return this.ttl;
			}
			set
			{
				this.ttl = value;
			}
		}

		// Token: 0x0400144C RID: 5196
		private int ttl = 128;

		// Token: 0x0400144D RID: 5197
		private bool dont_fragment;
	}
}
