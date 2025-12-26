using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000395 RID: 917
	internal abstract class UnixIPInterfaceProperties : IPInterfaceProperties
	{
		// Token: 0x06002051 RID: 8273 RVA: 0x000174A6 File Offset: 0x000156A6
		public UnixIPInterfaceProperties(UnixNetworkInterface iface, List<IPAddress> addresses)
		{
			this.iface = iface;
			this.addresses = addresses;
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x00002664 File Offset: 0x00000864
		public override IPv6InterfaceProperties GetIPv6Properties()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x000606F8 File Offset: 0x0005E8F8
		private void ParseRouteInfo(string iface)
		{
			try
			{
				this.gateways = new IPAddressCollection();
				using (StreamReader streamReader = new StreamReader("/proc/net/route"))
				{
					streamReader.ReadLine();
					string text;
					while ((text = streamReader.ReadLine()) != null)
					{
						text = text.Trim();
						if (text.Length != 0)
						{
							string[] array = text.Split(new char[] { '\t' });
							if (array.Length >= 3)
							{
								string text2 = array[2].Trim();
								byte[] array2 = new byte[4];
								if (text2.Length == 8 && iface.Equals(array[0], StringComparison.OrdinalIgnoreCase))
								{
									for (int i = 0; i < 4; i++)
									{
										if (!byte.TryParse(text2.Substring(i * 2, 2), NumberStyles.HexNumber, null, out array2[3 - i]))
										{
										}
									}
									IPAddress ipaddress = new IPAddress(array2);
									if (!ipaddress.Equals(IPAddress.Any))
									{
										this.gateways.Add(ipaddress);
									}
								}
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x00060854 File Offset: 0x0005EA54
		private void ParseResolvConf()
		{
			try
			{
				DateTime lastWriteTime = File.GetLastWriteTime("/etc/resolv.conf");
				if (!(lastWriteTime <= this.last_parse))
				{
					this.last_parse = lastWriteTime;
					this.dns_suffix = string.Empty;
					this.dns_servers = new IPAddressCollection();
					using (StreamReader streamReader = new StreamReader("/etc/resolv.conf"))
					{
						string text;
						while ((text = streamReader.ReadLine()) != null)
						{
							text = text.Trim();
							if (text.Length != 0 && text[0] != '#')
							{
								global::System.Text.RegularExpressions.Match match = UnixIPInterfaceProperties.ns.Match(text);
								if (match.Success)
								{
									try
									{
										string text2 = match.Groups["address"].Value;
										text2 = text2.Trim();
										this.dns_servers.Add(IPAddress.Parse(text2));
									}
									catch
									{
									}
								}
								else
								{
									match = UnixIPInterfaceProperties.search.Match(text);
									if (match.Success)
									{
										string text2 = match.Groups["domain"].Value;
										string[] array = text2.Split(new char[] { ',' });
										this.dns_suffix = array[0].Trim();
									}
								}
							}
						}
					}
				}
			}
			catch
			{
			}
			finally
			{
				this.dns_servers.SetReadOnly();
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x00060A18 File Offset: 0x0005EC18
		public override IPAddressInformationCollection AnycastAddresses
		{
			get
			{
				List<IPAddress> list = new List<IPAddress>();
				return IPAddressInformationImplCollection.LinuxFromAnycast(list);
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x00060A34 File Offset: 0x0005EC34
		[global::System.MonoTODO("Always returns an empty collection.")]
		public override IPAddressCollection DhcpServerAddresses
		{
			get
			{
				IPAddressCollection ipaddressCollection = new IPAddressCollection();
				ipaddressCollection.SetReadOnly();
				return ipaddressCollection;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06002058 RID: 8280 RVA: 0x000174DC File Offset: 0x000156DC
		public override IPAddressCollection DnsAddresses
		{
			get
			{
				this.ParseResolvConf();
				return this.dns_servers;
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06002059 RID: 8281 RVA: 0x000174EA File Offset: 0x000156EA
		public override string DnsSuffix
		{
			get
			{
				this.ParseResolvConf();
				return this.dns_suffix;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x0600205A RID: 8282 RVA: 0x000174F8 File Offset: 0x000156F8
		public override GatewayIPAddressInformationCollection GatewayAddresses
		{
			get
			{
				this.ParseRouteInfo(this.iface.Name.ToString());
				if (this.gateways.Count > 0)
				{
					return new LinuxGatewayIPAddressInformationCollection(this.gateways);
				}
				return LinuxGatewayIPAddressInformationCollection.Empty;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x000025B7 File Offset: 0x000007B7
		[global::System.MonoTODO("Always returns true")]
		public override bool IsDnsEnabled
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x0600205C RID: 8284 RVA: 0x00002AA1 File Offset: 0x00000CA1
		[global::System.MonoTODO("Always returns false")]
		public override bool IsDynamicDnsEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x0600205D RID: 8285 RVA: 0x00060A50 File Offset: 0x0005EC50
		public override MulticastIPAddressInformationCollection MulticastAddresses
		{
			get
			{
				List<IPAddress> list = new List<IPAddress>();
				foreach (IPAddress ipaddress in this.addresses)
				{
					byte[] addressBytes = ipaddress.GetAddressBytes();
					if (addressBytes[0] >= 224 && addressBytes[0] <= 239)
					{
						list.Add(ipaddress);
					}
				}
				return MulticastIPAddressInformationImplCollection.LinuxFromList(list);
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x00060AD8 File Offset: 0x0005ECD8
		public override UnicastIPAddressInformationCollection UnicastAddresses
		{
			get
			{
				List<IPAddress> list = new List<IPAddress>();
				foreach (IPAddress ipaddress in this.addresses)
				{
					global::System.Net.Sockets.AddressFamily addressFamily = ipaddress.AddressFamily;
					if (addressFamily != global::System.Net.Sockets.AddressFamily.InterNetwork)
					{
						if (addressFamily == global::System.Net.Sockets.AddressFamily.InterNetworkV6)
						{
							if (!ipaddress.IsIPv6Multicast)
							{
								list.Add(ipaddress);
							}
						}
					}
					else
					{
						byte b = ipaddress.GetAddressBytes()[0];
						if (b < 224 || b > 239)
						{
							list.Add(ipaddress);
						}
					}
				}
				return UnicastIPAddressInformationImplCollection.LinuxFromList(list);
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x0600205F RID: 8287 RVA: 0x00017532 File Offset: 0x00015732
		[global::System.MonoTODO("Always returns an empty collection.")]
		public override IPAddressCollection WinsServersAddresses
		{
			get
			{
				return new IPAddressCollection();
			}
		}

		// Token: 0x04001365 RID: 4965
		protected IPv4InterfaceProperties ipv4iface_properties;

		// Token: 0x04001366 RID: 4966
		protected UnixNetworkInterface iface;

		// Token: 0x04001367 RID: 4967
		private List<IPAddress> addresses;

		// Token: 0x04001368 RID: 4968
		private IPAddressCollection dns_servers;

		// Token: 0x04001369 RID: 4969
		private IPAddressCollection gateways;

		// Token: 0x0400136A RID: 4970
		private string dns_suffix;

		// Token: 0x0400136B RID: 4971
		private DateTime last_parse;

		// Token: 0x0400136C RID: 4972
		private static global::System.Text.RegularExpressions.Regex ns = new global::System.Text.RegularExpressions.Regex("\\s*nameserver\\s+(?<address>.*)");

		// Token: 0x0400136D RID: 4973
		private static global::System.Text.RegularExpressions.Regex search = new global::System.Text.RegularExpressions.Regex("\\s*search\\s+(?<domain>.*)");
	}
}
