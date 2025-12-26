using System;
using System.Net.Sockets;

namespace System.Net
{
	/// <summary>Represents a network endpoint as an IP address and a port number.</summary>
	// Token: 0x02000341 RID: 833
	[Serializable]
	public class IPEndPoint : EndPoint
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.IPEndPoint" /> class with the specified address and port number.</summary>
		/// <param name="address">An <see cref="T:System.Net.IPAddress" />. </param>
		/// <param name="port">The port number associated with the <paramref name="address" />, or 0 to specify any available port. <paramref name="port" /> is in host order.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="port" /> is less than <see cref="F:System.Net.IPEndPoint.MinPort" />.-or- <paramref name="port" /> is greater than <see cref="F:System.Net.IPEndPoint.MaxPort" />.-or- <paramref name="address" /> is less than 0 or greater than 0x00000000FFFFFFFF. </exception>
		// Token: 0x06001D29 RID: 7465 RVA: 0x00015145 File Offset: 0x00013345
		public IPEndPoint(IPAddress address, int port)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			this.Address = address;
			this.Port = port;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.IPEndPoint" /> class with the specified address and port number.</summary>
		/// <param name="address">The IP address of the Internet host. </param>
		/// <param name="port">The port number associated with the <paramref name="address" />, or 0 to specify any available port. <paramref name="port" /> is in host order.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="port" /> is less than <see cref="F:System.Net.IPEndPoint.MinPort" />.-or- <paramref name="port" /> is greater than <see cref="F:System.Net.IPEndPoint.MaxPort" />.-or- <paramref name="address" /> is less than 0 or greater than 0x00000000FFFFFFFF. </exception>
		// Token: 0x06001D2A RID: 7466 RVA: 0x0001516C File Offset: 0x0001336C
		public IPEndPoint(long iaddr, int port)
		{
			this.Address = new IPAddress(iaddr);
			this.Port = port;
		}

		/// <summary>Gets or sets the IP address of the endpoint.</summary>
		/// <returns>An <see cref="T:System.Net.IPAddress" /> instance containing the IP address of the endpoint.</returns>
		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x00015187 File Offset: 0x00013387
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x0001518F File Offset: 0x0001338F
		public IPAddress Address
		{
			get
			{
				return this.address;
			}
			set
			{
				this.address = value;
			}
		}

		/// <summary>Gets the Internet Protocol (IP) address family.</summary>
		/// <returns>Returns <see cref="F:System.Net.Sockets.AddressFamily.InterNetwork" />.</returns>
		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x00015198 File Offset: 0x00013398
		public override global::System.Net.Sockets.AddressFamily AddressFamily
		{
			get
			{
				return this.address.AddressFamily;
			}
		}

		/// <summary>Gets or sets the port number of the endpoint.</summary>
		/// <returns>An integer value in the range <see cref="F:System.Net.IPEndPoint.MinPort" /> to <see cref="F:System.Net.IPEndPoint.MaxPort" /> indicating the port number of the endpoint.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value that was specified for a set operation is less than <see cref="F:System.Net.IPEndPoint.MinPort" /> or greater than <see cref="F:System.Net.IPEndPoint.MaxPort" />. </exception>
		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x000151A5 File Offset: 0x000133A5
		// (set) Token: 0x06001D2F RID: 7471 RVA: 0x000151AD File Offset: 0x000133AD
		public int Port
		{
			get
			{
				return this.port;
			}
			set
			{
				if (value < 0 || value > 65535)
				{
					throw new ArgumentOutOfRangeException("Invalid port");
				}
				this.port = value;
			}
		}

		/// <summary>Creates an endpoint from a socket address.</summary>
		/// <returns>An <see cref="T:System.Net.EndPoint" /> instance using the specified socket address.</returns>
		/// <param name="socketAddress">The <see cref="T:System.Net.SocketAddress" /> to use for the endpoint. </param>
		/// <exception cref="T:System.ArgumentException">The AddressFamily of <paramref name="socketAddress" /> is not equal to the AddressFamily of the current instance.-or- <paramref name="socketAddress" />.Size &lt; 8. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06001D30 RID: 7472 RVA: 0x000590E4 File Offset: 0x000572E4
		public override EndPoint Create(SocketAddress socketAddress)
		{
			if (socketAddress == null)
			{
				throw new ArgumentNullException("socketAddress");
			}
			if (socketAddress.Family != this.AddressFamily)
			{
				throw new ArgumentException(string.Concat(new object[] { "The IPEndPoint was created using ", this.AddressFamily, " AddressFamily but SocketAddress contains ", socketAddress.Family, " instead, please use the same type." }));
			}
			int size = socketAddress.Size;
			global::System.Net.Sockets.AddressFamily family = socketAddress.Family;
			global::System.Net.Sockets.AddressFamily addressFamily = family;
			IPEndPoint ipendPoint;
			if (addressFamily != global::System.Net.Sockets.AddressFamily.InterNetwork)
			{
				if (addressFamily != global::System.Net.Sockets.AddressFamily.InterNetworkV6)
				{
					return null;
				}
				if (size < 28)
				{
					return null;
				}
				int num = ((int)socketAddress[2] << 8) + (int)socketAddress[3];
				int num2 = (int)socketAddress[24] + ((int)socketAddress[25] << 8) + ((int)socketAddress[26] << 16) + ((int)socketAddress[27] << 24);
				ushort[] array = new ushort[8];
				for (int i = 0; i < 8; i++)
				{
					array[i] = (ushort)(((int)socketAddress[8 + i * 2] << 8) + (int)socketAddress[8 + i * 2 + 1]);
				}
				ipendPoint = new IPEndPoint(new IPAddress(array, (long)num2), num);
			}
			else
			{
				if (size < 8)
				{
					return null;
				}
				int num = ((int)socketAddress[2] << 8) + (int)socketAddress[3];
				long num3 = ((long)socketAddress[7] << 24) + ((long)socketAddress[6] << 16) + ((long)socketAddress[5] << 8) + (long)socketAddress[4];
				ipendPoint = new IPEndPoint(num3, num);
			}
			return ipendPoint;
		}

		/// <summary>Serializes endpoint information into a <see cref="T:System.Net.SocketAddress" /> instance.</summary>
		/// <returns>A <see cref="T:System.Net.SocketAddress" /> instance containing the socket address for the endpoint.</returns>
		// Token: 0x06001D31 RID: 7473 RVA: 0x00059280 File Offset: 0x00057480
		public override SocketAddress Serialize()
		{
			SocketAddress socketAddress = null;
			global::System.Net.Sockets.AddressFamily addressFamily = this.address.AddressFamily;
			if (addressFamily != global::System.Net.Sockets.AddressFamily.InterNetwork)
			{
				if (addressFamily == global::System.Net.Sockets.AddressFamily.InterNetworkV6)
				{
					socketAddress = new SocketAddress(global::System.Net.Sockets.AddressFamily.InterNetworkV6, 28);
					socketAddress[2] = (byte)((this.port >> 8) & 255);
					socketAddress[3] = (byte)(this.port & 255);
					byte[] addressBytes = this.address.GetAddressBytes();
					for (int i = 0; i < 16; i++)
					{
						socketAddress[8 + i] = addressBytes[i];
					}
					socketAddress[24] = (byte)(this.address.ScopeId & 255L);
					socketAddress[25] = (byte)((this.address.ScopeId >> 8) & 255L);
					socketAddress[26] = (byte)((this.address.ScopeId >> 16) & 255L);
					socketAddress[27] = (byte)((this.address.ScopeId >> 24) & 255L);
				}
			}
			else
			{
				socketAddress = new SocketAddress(global::System.Net.Sockets.AddressFamily.InterNetwork, 16);
				socketAddress[2] = (byte)((this.port >> 8) & 255);
				socketAddress[3] = (byte)(this.port & 255);
				long internalIPv4Address = this.address.InternalIPv4Address;
				socketAddress[4] = (byte)(internalIPv4Address & 255L);
				socketAddress[5] = (byte)((internalIPv4Address >> 8) & 255L);
				socketAddress[6] = (byte)((internalIPv4Address >> 16) & 255L);
				socketAddress[7] = (byte)((internalIPv4Address >> 24) & 255L);
			}
			return socketAddress;
		}

		/// <summary>Returns the IP address and port number of the specified endpoint.</summary>
		/// <returns>A string containing the IP address and the port number of the specified endpoint (for example, 192.168.1.2:80).</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001D32 RID: 7474 RVA: 0x000151D3 File Offset: 0x000133D3
		public override string ToString()
		{
			return this.address.ToString() + ":" + this.port;
		}

		/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Net.IPEndPoint" /> instance.</summary>
		/// <returns>true if the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />; otherwise, false.</returns>
		/// <param name="comparand">The specified <see cref="T:System.Object" /> to compare with the current <see cref="T:System.Net.IPEndPoint" /> instance.</param>
		// Token: 0x06001D33 RID: 7475 RVA: 0x00059418 File Offset: 0x00057618
		public override bool Equals(object obj)
		{
			IPEndPoint ipendPoint = obj as IPEndPoint;
			return ipendPoint != null && ipendPoint.port == this.port && ipendPoint.address.Equals(this.address);
		}

		/// <summary>Returns a hash value for a <see cref="T:System.Net.IPEndPoint" /> instance.</summary>
		/// <returns>An integer hash value.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x06001D34 RID: 7476 RVA: 0x000151F5 File Offset: 0x000133F5
		public override int GetHashCode()
		{
			return this.address.GetHashCode() + this.port;
		}

		/// <summary>Specifies the maximum value that can be assigned to the <see cref="P:System.Net.IPEndPoint.Port" /> property. The MaxPort value is set to 0x0000FFFF. This field is read-only.</summary>
		// Token: 0x04001228 RID: 4648
		public const int MaxPort = 65535;

		/// <summary>Specifies the minimum value that can be assigned to the <see cref="P:System.Net.IPEndPoint.Port" /> property. This field is read-only.</summary>
		// Token: 0x04001229 RID: 4649
		public const int MinPort = 0;

		// Token: 0x0400122A RID: 4650
		private IPAddress address;

		// Token: 0x0400122B RID: 4651
		private int port;
	}
}
