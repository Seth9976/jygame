using System;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Net.Configuration;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Mono.Security.Protocol.Tls;
using Mono.Security.X509;
using Mono.Security.X509.Extensions;

namespace System.Net
{
	/// <summary>Manages the collection of <see cref="T:System.Net.ServicePoint" /> objects.</summary>
	// Token: 0x020003FF RID: 1023
	public class ServicePointManager
	{
		// Token: 0x060022DD RID: 8925 RVA: 0x000021C3 File Offset: 0x000003C3
		private ServicePointManager()
		{
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x00064030 File Offset: 0x00062230
		static ServicePointManager()
		{
			object section = ConfigurationManager.GetSection("system.net/connectionManagement");
			global::System.Net.Configuration.ConnectionManagementSection connectionManagementSection = section as global::System.Net.Configuration.ConnectionManagementSection;
			if (connectionManagementSection != null)
			{
				ServicePointManager.manager = new global::System.Net.Configuration.ConnectionManagementData(null);
				foreach (object obj in connectionManagementSection.ConnectionManagement)
				{
					global::System.Net.Configuration.ConnectionManagementElement connectionManagementElement = (global::System.Net.Configuration.ConnectionManagementElement)obj;
					ServicePointManager.manager.Add(connectionManagementElement.Address, connectionManagementElement.MaxConnection);
				}
				ServicePointManager.defaultConnectionLimit = (int)ServicePointManager.manager.GetMaxConnections("*");
				return;
			}
			ServicePointManager.manager = (global::System.Net.Configuration.ConnectionManagementData)global::System.Configuration.ConfigurationSettings.GetConfig("system.net/connectionManagement");
			if (ServicePointManager.manager != null)
			{
				ServicePointManager.defaultConnectionLimit = (int)ServicePointManager.manager.GetMaxConnections("*");
			}
		}

		/// <summary>Gets or sets policy for server certificates.</summary>
		/// <returns>An object that implements the <see cref="T:System.Net.ICertificatePolicy" /> interface.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x000189FE File Offset: 0x00016BFE
		// (set) Token: 0x060022E0 RID: 8928 RVA: 0x00018A05 File Offset: 0x00016C05
		[Obsolete("Use ServerCertificateValidationCallback instead", false)]
		public static ICertificatePolicy CertificatePolicy
		{
			get
			{
				return ServicePointManager.policy;
			}
			set
			{
				ServicePointManager.policy = value;
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that indicates whether the certificate is checked against the certificate authority revocation list.</summary>
		/// <returns>true if the certificate revocation list is checked; otherwise, false.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x060022E1 RID: 8929 RVA: 0x00018A0D File Offset: 0x00016C0D
		// (set) Token: 0x060022E2 RID: 8930 RVA: 0x00018A14 File Offset: 0x00016C14
		[global::System.MonoTODO("CRL checks not implemented")]
		public static bool CheckCertificateRevocationList
		{
			get
			{
				return ServicePointManager._checkCRL;
			}
			set
			{
				ServicePointManager._checkCRL = false;
			}
		}

		/// <summary>Gets or sets the maximum number of concurrent connections allowed by a <see cref="T:System.Net.ServicePoint" /> object.</summary>
		/// <returns>The maximum number of concurrent connections allowed by a <see cref="T:System.Net.ServicePoint" /> object. The default value is 2.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <see cref="P:System.Net.ServicePointManager.DefaultConnectionLimit" /> is less than or equal to 0. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x060022E3 RID: 8931 RVA: 0x00018A1C File Offset: 0x00016C1C
		// (set) Token: 0x060022E4 RID: 8932 RVA: 0x00018A23 File Offset: 0x00016C23
		public static int DefaultConnectionLimit
		{
			get
			{
				return ServicePointManager.defaultConnectionLimit;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				ServicePointManager.defaultConnectionLimit = value;
			}
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x00005023 File Offset: 0x00003223
		private static Exception GetMustImplement()
		{
			return new NotImplementedException();
		}

		/// <summary>Gets or sets a value that indicates how long a Domain Name Service (DNS) resolution is considered valid.</summary>
		/// <returns>The time-out value, in milliseconds. A value of -1 indicates an infinite time-out period. The default value is 120,000 milliseconds (two minutes).</returns>
		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x060022E6 RID: 8934 RVA: 0x00018A3D File Offset: 0x00016C3D
		// (set) Token: 0x060022E7 RID: 8935 RVA: 0x00018A3D File Offset: 0x00016C3D
		[global::System.MonoTODO]
		public static int DnsRefreshTimeout
		{
			get
			{
				throw ServicePointManager.GetMustImplement();
			}
			set
			{
				throw ServicePointManager.GetMustImplement();
			}
		}

		/// <summary>Gets or sets a value that indicates whether a Domain Name Service (DNS) resolution rotates among the applicable Internet Protocol (IP) addresses.</summary>
		/// <returns>false if a DNS resolution always returns the first IP address for a particular host; otherwise true. The default is false.</returns>
		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x00018A3D File Offset: 0x00016C3D
		// (set) Token: 0x060022E9 RID: 8937 RVA: 0x00018A3D File Offset: 0x00016C3D
		[global::System.MonoTODO]
		public static bool EnableDnsRoundRobin
		{
			get
			{
				throw ServicePointManager.GetMustImplement();
			}
			set
			{
				throw ServicePointManager.GetMustImplement();
			}
		}

		/// <summary>Gets or sets the maximum idle time of a <see cref="T:System.Net.ServicePoint" /> object.</summary>
		/// <returns>The maximum idle time, in milliseconds, of a <see cref="T:System.Net.ServicePoint" /> object. The default value is 100,000 milliseconds (100 seconds).</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <see cref="P:System.Net.ServicePointManager.MaxServicePointIdleTime" /> is less than <see cref="F:System.Threading.Timeout.Infinite" /> or greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x060022EA RID: 8938 RVA: 0x00018A44 File Offset: 0x00016C44
		// (set) Token: 0x060022EB RID: 8939 RVA: 0x00018A4B File Offset: 0x00016C4B
		public static int MaxServicePointIdleTime
		{
			get
			{
				return ServicePointManager.maxServicePointIdleTime;
			}
			set
			{
				if (value < -2 || value > 2147483647)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				ServicePointManager.maxServicePointIdleTime = value;
			}
		}

		/// <summary>Gets or sets the maximum number of <see cref="T:System.Net.ServicePoint" /> objects to maintain at any time.</summary>
		/// <returns>The maximum number of <see cref="T:System.Net.ServicePoint" /> objects to maintain. The default value is 0, which means there is no limit to the number of <see cref="T:System.Net.ServicePoint" /> objects.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <see cref="P:System.Net.ServicePointManager.MaxServicePoints" /> is less than 0 or greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Net.WebPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x060022EC RID: 8940 RVA: 0x00018A71 File Offset: 0x00016C71
		// (set) Token: 0x060022ED RID: 8941 RVA: 0x00018A78 File Offset: 0x00016C78
		public static int MaxServicePoints
		{
			get
			{
				return ServicePointManager.maxServicePoints;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("value");
				}
				ServicePointManager.maxServicePoints = value;
				ServicePointManager.RecycleServicePoints();
			}
		}

		/// <summary>Gets or sets the security protocol used by the <see cref="T:System.Net.ServicePoint" /> objects managed by the <see cref="T:System.Net.ServicePointManager" /> object.</summary>
		/// <returns>One of the values defined in the <see cref="T:System.Net.SecurityProtocolType" /> enumeration.</returns>
		/// <exception cref="T:System.NotSupportedException">The value specified to set the property is not a valid <see cref="T:System.Net.SecurityProtocolType" /> enumeration value. </exception>
		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x00018A97 File Offset: 0x00016C97
		// (set) Token: 0x060022EF RID: 8943 RVA: 0x00018A9E File Offset: 0x00016C9E
		public static SecurityProtocolType SecurityProtocol
		{
			get
			{
				return ServicePointManager._securityProtocol;
			}
			set
			{
				ServicePointManager._securityProtocol = value;
			}
		}

		/// <summary>Gets or sets the callback to validate a server certificate.</summary>
		/// <returns>A <see cref="T:System.Net.Security.RemoteCertificateValidationCallback" /> The default value is null.</returns>
		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x060022F0 RID: 8944 RVA: 0x00018AA6 File Offset: 0x00016CA6
		// (set) Token: 0x060022F1 RID: 8945 RVA: 0x00018AAD File Offset: 0x00016CAD
		public static global::System.Net.Security.RemoteCertificateValidationCallback ServerCertificateValidationCallback
		{
			get
			{
				return ServicePointManager.server_cert_cb;
			}
			set
			{
				ServicePointManager.server_cert_cb = value;
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Boolean" /> value that determines whether 100-Continue behavior is used.</summary>
		/// <returns>true to enable 100-Continue behavior. The default value is true.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x060022F2 RID: 8946 RVA: 0x00018AB5 File Offset: 0x00016CB5
		// (set) Token: 0x060022F3 RID: 8947 RVA: 0x00018ABC File Offset: 0x00016CBC
		public static bool Expect100Continue
		{
			get
			{
				return ServicePointManager.expectContinue;
			}
			set
			{
				ServicePointManager.expectContinue = value;
			}
		}

		/// <summary>Determines whether the Nagle algorithm is used by the service points managed by this <see cref="T:System.Net.ServicePointManager" /> object.</summary>
		/// <returns>true to use the Nagle algorithm; otherwise, false. The default value is true.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x00018AC4 File Offset: 0x00016CC4
		// (set) Token: 0x060022F5 RID: 8949 RVA: 0x00018ACB File Offset: 0x00016CCB
		public static bool UseNagleAlgorithm
		{
			get
			{
				return ServicePointManager.useNagle;
			}
			set
			{
				ServicePointManager.useNagle = value;
			}
		}

		/// <summary>Finds an existing <see cref="T:System.Net.ServicePoint" /> object or creates a new <see cref="T:System.Net.ServicePoint" /> object to manage communications with the specified <see cref="T:System.Uri" /> object.</summary>
		/// <returns>The <see cref="T:System.Net.ServicePoint" /> object that manages communications for the request.</returns>
		/// <param name="address">The <see cref="T:System.Uri" /> object of the Internet resource to contact. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="address" /> is null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The maximum number of <see cref="T:System.Net.ServicePoint" /> objects defined in <see cref="P:System.Net.ServicePointManager.MaxServicePoints" /> has been reached. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x060022F6 RID: 8950 RVA: 0x00018AD3 File Offset: 0x00016CD3
		public static ServicePoint FindServicePoint(global::System.Uri address)
		{
			return ServicePointManager.FindServicePoint(address, GlobalProxySelection.Select);
		}

		/// <summary>Finds an existing <see cref="T:System.Net.ServicePoint" /> object or creates a new <see cref="T:System.Net.ServicePoint" /> object to manage communications with the specified Uniform Resource Identifier (URI).</summary>
		/// <returns>The <see cref="T:System.Net.ServicePoint" /> object that manages communications for the request.</returns>
		/// <param name="uriString">The URI of the Internet resource to be contacted. </param>
		/// <param name="proxy">The proxy data for this request. </param>
		/// <exception cref="T:System.UriFormatException">The URI specified in <paramref name="uriString" /> is invalid. </exception>
		/// <exception cref="T:System.InvalidOperationException">The maximum number of <see cref="T:System.Net.ServicePoint" /> objects defined in <see cref="P:System.Net.ServicePointManager.MaxServicePoints" /> has been reached. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x060022F7 RID: 8951 RVA: 0x00018AE0 File Offset: 0x00016CE0
		public static ServicePoint FindServicePoint(string uriString, IWebProxy proxy)
		{
			return ServicePointManager.FindServicePoint(new global::System.Uri(uriString), proxy);
		}

		/// <summary>Finds an existing <see cref="T:System.Net.ServicePoint" /> object or creates a new <see cref="T:System.Net.ServicePoint" /> object to manage communications with the specified <see cref="T:System.Uri" /> object.</summary>
		/// <returns>The <see cref="T:System.Net.ServicePoint" /> object that manages communications for the request.</returns>
		/// <param name="address">A <see cref="T:System.Uri" /> object that contains the address of the Internet resource to contact. </param>
		/// <param name="proxy">The proxy data for this request. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="address" /> is null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The maximum number of <see cref="T:System.Net.ServicePoint" /> objects defined in <see cref="P:System.Net.ServicePointManager.MaxServicePoints" /> has been reached. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x060022F8 RID: 8952 RVA: 0x00064150 File Offset: 0x00062350
		public static ServicePoint FindServicePoint(global::System.Uri address, IWebProxy proxy)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			ServicePointManager.RecycleServicePoints();
			bool flag = false;
			bool flag2 = false;
			if (proxy != null && !proxy.IsBypassed(address))
			{
				flag = true;
				bool flag3 = address.Scheme == "https";
				address = proxy.GetProxy(address);
				if (address.Scheme != "http" && !flag3)
				{
					throw new NotSupportedException("Proxy scheme not supported.");
				}
				if (flag3 && address.Scheme == "http")
				{
					flag2 = true;
				}
			}
			address = new global::System.Uri(address.Scheme + "://" + address.Authority);
			ServicePoint servicePoint = null;
			global::System.Collections.Specialized.HybridDictionary hybridDictionary = ServicePointManager.servicePoints;
			lock (hybridDictionary)
			{
				ServicePointManager.SPKey spkey = new ServicePointManager.SPKey(address, flag2);
				servicePoint = ServicePointManager.servicePoints[spkey] as ServicePoint;
				if (servicePoint != null)
				{
					return servicePoint;
				}
				if (ServicePointManager.maxServicePoints > 0 && ServicePointManager.servicePoints.Count >= ServicePointManager.maxServicePoints)
				{
					throw new InvalidOperationException("maximum number of service points reached");
				}
				string text = address.ToString();
				int maxConnections = (int)ServicePointManager.manager.GetMaxConnections(text);
				servicePoint = new ServicePoint(address, maxConnections, ServicePointManager.maxServicePointIdleTime);
				servicePoint.Expect100Continue = ServicePointManager.expectContinue;
				servicePoint.UseNagleAlgorithm = ServicePointManager.useNagle;
				servicePoint.UsesProxy = flag;
				servicePoint.UseConnect = flag2;
				ServicePointManager.servicePoints.Add(spkey, servicePoint);
			}
			return servicePoint;
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x000642E4 File Offset: 0x000624E4
		internal static void RecycleServicePoints()
		{
			ArrayList arrayList = new ArrayList();
			global::System.Collections.Specialized.HybridDictionary hybridDictionary = ServicePointManager.servicePoints;
			lock (hybridDictionary)
			{
				IDictionaryEnumerator dictionaryEnumerator = ServicePointManager.servicePoints.GetEnumerator();
				while (dictionaryEnumerator.MoveNext())
				{
					ServicePoint servicePoint = (ServicePoint)dictionaryEnumerator.Value;
					if (servicePoint.AvailableForRecycling)
					{
						arrayList.Add(dictionaryEnumerator.Key);
					}
				}
				for (int i = 0; i < arrayList.Count; i++)
				{
					ServicePointManager.servicePoints.Remove(arrayList[i]);
				}
				if (ServicePointManager.maxServicePoints != 0 && ServicePointManager.servicePoints.Count > ServicePointManager.maxServicePoints)
				{
					SortedList sortedList = new SortedList(ServicePointManager.servicePoints.Count);
					dictionaryEnumerator = ServicePointManager.servicePoints.GetEnumerator();
					while (dictionaryEnumerator.MoveNext())
					{
						ServicePoint servicePoint2 = (ServicePoint)dictionaryEnumerator.Value;
						if (servicePoint2.CurrentConnections == 0)
						{
							while (sortedList.ContainsKey(servicePoint2.IdleSince))
							{
								servicePoint2.IdleSince = servicePoint2.IdleSince.AddMilliseconds(1.0);
							}
							sortedList.Add(servicePoint2.IdleSince, servicePoint2.Address);
						}
					}
					int num = 0;
					while (num < sortedList.Count && ServicePointManager.servicePoints.Count > ServicePointManager.maxServicePoints)
					{
						ServicePointManager.servicePoints.Remove(sortedList.GetByIndex(num));
						num++;
					}
				}
			}
		}

		/// <summary>The default number of non-persistent connections (4) allowed on a <see cref="T:System.Net.ServicePoint" /> object connected to an HTTP/1.0 or later server. This field is constant but is no longer used in the .NET Framework 2.0.</summary>
		// Token: 0x0400153E RID: 5438
		public const int DefaultNonPersistentConnectionLimit = 4;

		/// <summary>The default number of persistent connections (2) allowed on a <see cref="T:System.Net.ServicePoint" /> object connected to an HTTP/1.1 or later server. This field is constant and is used to initialize the <see cref="P:System.Net.ServicePointManager.DefaultConnectionLimit" /> property if the value of the <see cref="P:System.Net.ServicePointManager.DefaultConnectionLimit" /> property has not been set either directly or through configuration.</summary>
		// Token: 0x0400153F RID: 5439
		public const int DefaultPersistentConnectionLimit = 2;

		// Token: 0x04001540 RID: 5440
		private const string configKey = "system.net/connectionManagement";

		// Token: 0x04001541 RID: 5441
		private static global::System.Collections.Specialized.HybridDictionary servicePoints = new global::System.Collections.Specialized.HybridDictionary();

		// Token: 0x04001542 RID: 5442
		private static ICertificatePolicy policy = new DefaultCertificatePolicy();

		// Token: 0x04001543 RID: 5443
		private static int defaultConnectionLimit = 2;

		// Token: 0x04001544 RID: 5444
		private static int maxServicePointIdleTime = 900000;

		// Token: 0x04001545 RID: 5445
		private static int maxServicePoints = 0;

		// Token: 0x04001546 RID: 5446
		private static bool _checkCRL = false;

		// Token: 0x04001547 RID: 5447
		private static SecurityProtocolType _securityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;

		// Token: 0x04001548 RID: 5448
		private static bool expectContinue = true;

		// Token: 0x04001549 RID: 5449
		private static bool useNagle;

		// Token: 0x0400154A RID: 5450
		private static global::System.Net.Security.RemoteCertificateValidationCallback server_cert_cb;

		// Token: 0x0400154B RID: 5451
		private static global::System.Net.Configuration.ConnectionManagementData manager;

		// Token: 0x02000400 RID: 1024
		private class SPKey
		{
			// Token: 0x060022FA RID: 8954 RVA: 0x00018AEE File Offset: 0x00016CEE
			public SPKey(global::System.Uri uri, bool use_connect)
			{
				this.uri = uri;
				this.use_connect = use_connect;
			}

			// Token: 0x17000A0E RID: 2574
			// (get) Token: 0x060022FB RID: 8955 RVA: 0x00018B04 File Offset: 0x00016D04
			public global::System.Uri Uri
			{
				get
				{
					return this.uri;
				}
			}

			// Token: 0x17000A0F RID: 2575
			// (get) Token: 0x060022FC RID: 8956 RVA: 0x00018B0C File Offset: 0x00016D0C
			public bool UseConnect
			{
				get
				{
					return this.use_connect;
				}
			}

			// Token: 0x060022FD RID: 8957 RVA: 0x00018B14 File Offset: 0x00016D14
			public override int GetHashCode()
			{
				return this.uri.GetHashCode() + ((!this.use_connect) ? 0 : 1);
			}

			// Token: 0x060022FE RID: 8958 RVA: 0x0006449C File Offset: 0x0006269C
			public override bool Equals(object obj)
			{
				ServicePointManager.SPKey spkey = obj as ServicePointManager.SPKey;
				return obj != null && this.uri.Equals(spkey.uri) && spkey.use_connect == this.use_connect;
			}

			// Token: 0x0400154C RID: 5452
			private global::System.Uri uri;

			// Token: 0x0400154D RID: 5453
			private bool use_connect;
		}

		// Token: 0x02000401 RID: 1025
		internal class ChainValidationHelper
		{
			// Token: 0x060022FF RID: 8959 RVA: 0x00018B34 File Offset: 0x00016D34
			public ChainValidationHelper(object sender)
			{
				this.sender = sender;
			}

			// Token: 0x17000A10 RID: 2576
			// (get) Token: 0x06002301 RID: 8961 RVA: 0x00018B5E File Offset: 0x00016D5E
			// (set) Token: 0x06002302 RID: 8962 RVA: 0x00018B9C File Offset: 0x00016D9C
			public string Host
			{
				get
				{
					if (this.host == null && this.sender is HttpWebRequest)
					{
						this.host = ((HttpWebRequest)this.sender).Address.Host;
					}
					return this.host;
				}
				set
				{
					this.host = value;
				}
			}

			// Token: 0x06002303 RID: 8963 RVA: 0x000644E0 File Offset: 0x000626E0
			internal ValidationResult ValidateChain(Mono.Security.X509.X509CertificateCollection certs)
			{
				bool flag = false;
				if (certs == null || certs.Count == 0)
				{
					return null;
				}
				ICertificatePolicy certificatePolicy = ServicePointManager.CertificatePolicy;
				global::System.Net.Security.RemoteCertificateValidationCallback serverCertificateValidationCallback = ServicePointManager.ServerCertificateValidationCallback;
				global::System.Security.Cryptography.X509Certificates.X509Chain x509Chain = new global::System.Security.Cryptography.X509Certificates.X509Chain();
				x509Chain.ChainPolicy = new global::System.Security.Cryptography.X509Certificates.X509ChainPolicy();
				for (int i = 1; i < certs.Count; i++)
				{
					global::System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate = new global::System.Security.Cryptography.X509Certificates.X509Certificate2(certs[i].RawData);
					x509Chain.ChainPolicy.ExtraStore.Add(x509Certificate);
				}
				global::System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate2 = new global::System.Security.Cryptography.X509Certificates.X509Certificate2(certs[0].RawData);
				int num = 0;
				global::System.Net.Security.SslPolicyErrors sslPolicyErrors = global::System.Net.Security.SslPolicyErrors.None;
				try
				{
					if (!x509Chain.Build(x509Certificate2))
					{
						sslPolicyErrors |= ServicePointManager.ChainValidationHelper.GetErrorsFromChain(x509Chain);
					}
				}
				catch (Exception ex)
				{
					Console.Error.WriteLine("ERROR building certificate chain: {0}", ex);
					Console.Error.WriteLine("Please, report this problem to the Mono team");
					sslPolicyErrors |= global::System.Net.Security.SslPolicyErrors.RemoteCertificateChainErrors;
				}
				if (!ServicePointManager.ChainValidationHelper.CheckCertificateUsage(x509Certificate2))
				{
					sslPolicyErrors |= global::System.Net.Security.SslPolicyErrors.RemoteCertificateChainErrors;
					num = -2146762490;
				}
				if (!ServicePointManager.ChainValidationHelper.CheckServerIdentity(certs[0], this.Host))
				{
					sslPolicyErrors |= global::System.Net.Security.SslPolicyErrors.RemoteCertificateNameMismatch;
					num = -2146762481;
				}
				bool flag2 = false;
				if (ServicePointManager.ChainValidationHelper.is_macosx)
				{
					try
					{
						Mono.Security.X509.OSX509Certificates.SecTrustResult secTrustResult = Mono.Security.X509.OSX509Certificates.TrustEvaluateSsl(certs);
						flag2 = secTrustResult == Mono.Security.X509.OSX509Certificates.SecTrustResult.Proceed || secTrustResult == Mono.Security.X509.OSX509Certificates.SecTrustResult.Unspecified;
					}
					catch
					{
					}
					if (flag2)
					{
						num = 0;
						sslPolicyErrors = global::System.Net.Security.SslPolicyErrors.None;
					}
				}
				if (certificatePolicy != null && (!(certificatePolicy is DefaultCertificatePolicy) || serverCertificateValidationCallback == null))
				{
					ServicePoint servicePoint = null;
					HttpWebRequest httpWebRequest = this.sender as HttpWebRequest;
					if (httpWebRequest != null)
					{
						servicePoint = httpWebRequest.ServicePoint;
					}
					if (num == 0 && sslPolicyErrors != global::System.Net.Security.SslPolicyErrors.None)
					{
						num = ServicePointManager.ChainValidationHelper.GetStatusFromChain(x509Chain);
					}
					flag2 = certificatePolicy.CheckValidationResult(servicePoint, x509Certificate2, httpWebRequest, num);
					flag = !flag2 && !(certificatePolicy is DefaultCertificatePolicy);
				}
				if (serverCertificateValidationCallback != null)
				{
					flag2 = serverCertificateValidationCallback(this.sender, x509Certificate2, x509Chain, sslPolicyErrors);
					flag = !flag2;
				}
				return new ValidationResult(flag2, flag, num);
			}

			// Token: 0x06002304 RID: 8964 RVA: 0x000646FC File Offset: 0x000628FC
			private static int GetStatusFromChain(global::System.Security.Cryptography.X509Certificates.X509Chain chain)
			{
				long num = 0L;
				foreach (global::System.Security.Cryptography.X509Certificates.X509ChainStatus x509ChainStatus in chain.ChainStatus)
				{
					global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags status = x509ChainStatus.Status;
					if (status != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
					{
						if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NotTimeValid) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146762495));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NotTimeNested) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146762494));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.Revoked) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146762484));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NotSignatureValid) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146869244));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NotValidForUsage) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146762480));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.UntrustedRoot) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146762487));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.RevocationStatusUnknown) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146885614));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.Cyclic) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146762486));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.InvalidExtension) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146762485));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.InvalidPolicyConstraints) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146762483));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.InvalidBasicConstraints) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146869223));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.InvalidNameConstraints) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146762476));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.HasNotSupportedNameConstraint) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146762476));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.HasNotDefinedNameConstraint) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146762476));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.HasNotPermittedNameConstraint) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146762476));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.HasExcludedNameConstraint) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146762476));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.PartialChain) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146762486));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.CtlNotTimeValid) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146762495));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.CtlNotSignatureValid) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146869244));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.CtlNotValidForUsage) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146762480));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.OfflineRevocation) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146885614));
						}
						else if ((status & global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoIssuanceChainPolicy) != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
						{
							num = (long)((ulong)(-2146762489));
						}
						else
						{
							num = (long)((ulong)(-2146762485));
						}
						break;
					}
				}
				return (int)num;
			}

			// Token: 0x06002305 RID: 8965 RVA: 0x00064964 File Offset: 0x00062B64
			private static global::System.Net.Security.SslPolicyErrors GetErrorsFromChain(global::System.Security.Cryptography.X509Certificates.X509Chain chain)
			{
				global::System.Net.Security.SslPolicyErrors sslPolicyErrors = global::System.Net.Security.SslPolicyErrors.None;
				foreach (global::System.Security.Cryptography.X509Certificates.X509ChainStatus x509ChainStatus in chain.ChainStatus)
				{
					if (x509ChainStatus.Status != global::System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
					{
						sslPolicyErrors |= global::System.Net.Security.SslPolicyErrors.RemoteCertificateChainErrors;
						break;
					}
				}
				return sslPolicyErrors;
			}

			// Token: 0x06002306 RID: 8966 RVA: 0x000649B8 File Offset: 0x00062BB8
			private static bool CheckCertificateUsage(global::System.Security.Cryptography.X509Certificates.X509Certificate2 cert)
			{
				bool flag;
				try
				{
					if (cert.Version < 3)
					{
						flag = true;
					}
					else
					{
						global::System.Security.Cryptography.X509Certificates.X509KeyUsageExtension x509KeyUsageExtension = (global::System.Security.Cryptography.X509Certificates.X509KeyUsageExtension)cert.Extensions["2.5.29.15"];
						global::System.Security.Cryptography.X509Certificates.X509EnhancedKeyUsageExtension x509EnhancedKeyUsageExtension = (global::System.Security.Cryptography.X509Certificates.X509EnhancedKeyUsageExtension)cert.Extensions["2.5.29.37"];
						if (x509KeyUsageExtension != null && x509EnhancedKeyUsageExtension != null)
						{
							if ((x509KeyUsageExtension.KeyUsages & ServicePointManager.ChainValidationHelper.s_flags) == global::System.Security.Cryptography.X509Certificates.X509KeyUsageFlags.None)
							{
								flag = false;
							}
							else
							{
								flag = x509EnhancedKeyUsageExtension.EnhancedKeyUsages["1.3.6.1.5.5.7.3.1"] != null || x509EnhancedKeyUsageExtension.EnhancedKeyUsages["2.16.840.1.113730.4.1"] != null;
							}
						}
						else if (x509KeyUsageExtension != null)
						{
							flag = (x509KeyUsageExtension.KeyUsages & ServicePointManager.ChainValidationHelper.s_flags) != global::System.Security.Cryptography.X509Certificates.X509KeyUsageFlags.None;
						}
						else if (x509EnhancedKeyUsageExtension != null)
						{
							flag = x509EnhancedKeyUsageExtension.EnhancedKeyUsages["1.3.6.1.5.5.7.3.1"] != null || x509EnhancedKeyUsageExtension.EnhancedKeyUsages["2.16.840.1.113730.4.1"] != null;
						}
						else
						{
							global::System.Security.Cryptography.X509Certificates.X509Extension x509Extension = cert.Extensions["2.16.840.1.113730.1.1"];
							if (x509Extension != null)
							{
								string text = x509Extension.NetscapeCertType(false);
								flag = text.IndexOf("SSL Server Authentication") != -1;
							}
							else
							{
								flag = true;
							}
						}
					}
				}
				catch (Exception ex)
				{
					Console.Error.WriteLine("ERROR processing certificate: {0}", ex);
					Console.Error.WriteLine("Please, report this problem to the Mono team");
					flag = false;
				}
				return flag;
			}

			// Token: 0x06002307 RID: 8967 RVA: 0x00064B4C File Offset: 0x00062D4C
			private static bool CheckServerIdentity(Mono.Security.X509.X509Certificate cert, string targetHost)
			{
				bool flag;
				try
				{
					Mono.Security.X509.X509Extension x509Extension = cert.Extensions["2.5.29.17"];
					if (x509Extension != null)
					{
						SubjectAltNameExtension subjectAltNameExtension = new SubjectAltNameExtension(x509Extension);
						foreach (string text in subjectAltNameExtension.DNSNames)
						{
							if (ServicePointManager.ChainValidationHelper.Match(targetHost, text))
							{
								return true;
							}
						}
						foreach (string text2 in subjectAltNameExtension.IPAddresses)
						{
							if (text2 == targetHost)
							{
								return true;
							}
						}
					}
					flag = ServicePointManager.ChainValidationHelper.CheckDomainName(cert.SubjectName, targetHost);
				}
				catch (Exception ex)
				{
					Console.Error.WriteLine("ERROR processing certificate: {0}", ex);
					Console.Error.WriteLine("Please, report this problem to the Mono team");
					flag = false;
				}
				return flag;
			}

			// Token: 0x06002308 RID: 8968 RVA: 0x00064C48 File Offset: 0x00062E48
			private static bool CheckDomainName(string subjectName, string targetHost)
			{
				string text = string.Empty;
				global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("CN\\s*=\\s*([^,]*)");
				global::System.Text.RegularExpressions.MatchCollection matchCollection = regex.Matches(subjectName);
				if (matchCollection.Count == 1 && matchCollection[0].Success)
				{
					text = matchCollection[0].Groups[1].Value.ToString();
				}
				return ServicePointManager.ChainValidationHelper.Match(targetHost, text);
			}

			// Token: 0x06002309 RID: 8969 RVA: 0x00064CB0 File Offset: 0x00062EB0
			private static bool Match(string hostname, string pattern)
			{
				int num = pattern.IndexOf('*');
				if (num == -1)
				{
					return string.Compare(hostname, pattern, true, CultureInfo.InvariantCulture) == 0;
				}
				if (num != pattern.Length - 1 && pattern[num + 1] != '.')
				{
					return false;
				}
				int num2 = pattern.IndexOf('*', num + 1);
				if (num2 != -1)
				{
					return false;
				}
				string text = pattern.Substring(num + 1);
				int num3 = hostname.Length - text.Length;
				if (num3 <= 0)
				{
					return false;
				}
				if (string.Compare(hostname, num3, text, 0, text.Length, true, CultureInfo.InvariantCulture) != 0)
				{
					return false;
				}
				if (num == 0)
				{
					int num4 = hostname.IndexOf('.');
					return num4 == -1 || num4 >= hostname.Length - text.Length;
				}
				string text2 = pattern.Substring(0, num);
				return string.Compare(hostname, 0, text2, 0, text2.Length, true, CultureInfo.InvariantCulture) == 0;
			}

			// Token: 0x0400154E RID: 5454
			private object sender;

			// Token: 0x0400154F RID: 5455
			private string host;

			// Token: 0x04001550 RID: 5456
			private static bool is_macosx = File.Exists("/System/Library/Frameworks/Security.framework/Security");

			// Token: 0x04001551 RID: 5457
			private static global::System.Security.Cryptography.X509Certificates.X509KeyUsageFlags s_flags = global::System.Security.Cryptography.X509Certificates.X509KeyUsageFlags.KeyAgreement | global::System.Security.Cryptography.X509Certificates.X509KeyUsageFlags.KeyEncipherment | global::System.Security.Cryptography.X509Certificates.X509KeyUsageFlags.DigitalSignature;
		}
	}
}
