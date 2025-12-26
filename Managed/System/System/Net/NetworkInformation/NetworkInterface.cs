using System;
using System.IO;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	/// <summary>Provides configuration and statistical information for a network interface.</summary>
	// Token: 0x020003C0 RID: 960
	public abstract class NetworkInterface
	{
		// Token: 0x06002107 RID: 8455
		[DllImport("libc")]
		private static extern int uname(IntPtr buf);

		/// <summary>Returns objects that describe the network interfaces on the local computer.</summary>
		/// <returns>A <see cref="T:System.Net.NetworkInformation.NetworkInterface" /> array that contains objects that describe the available network interfaces, or an empty array if no interfaces are detected.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">A Windows system function call failed. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Net.NetworkInformation.NetworkInformationPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Access="Read" />
		/// </PermissionSet>
		// Token: 0x06002108 RID: 8456 RVA: 0x000610D8 File Offset: 0x0005F2D8
		[global::System.MonoTODO("Only works on Linux and Windows")]
		public static NetworkInterface[] GetAllNetworkInterfaces()
		{
			if (NetworkInterface.runningOnUnix)
			{
				bool flag = false;
				IntPtr intPtr = Marshal.AllocHGlobal(8192);
				if (NetworkInterface.uname(intPtr) == 0)
				{
					string text = Marshal.PtrToStringAnsi(intPtr);
					if (text == "Darwin")
					{
						flag = true;
					}
				}
				Marshal.FreeHGlobal(intPtr);
				try
				{
					if (flag)
					{
						return MacOsNetworkInterface.ImplGetAllNetworkInterfaces();
					}
					return LinuxNetworkInterface.ImplGetAllNetworkInterfaces();
				}
				catch (SystemException ex)
				{
					throw ex;
				}
				catch
				{
					return new NetworkInterface[0];
				}
			}
			if (Environment.OSVersion.Version >= NetworkInterface.windowsVer51)
			{
				return Win32NetworkInterface2.ImplGetAllNetworkInterfaces();
			}
			return new NetworkInterface[0];
		}

		/// <summary>Indicates whether any network connection is available.</summary>
		/// <returns>true if a network connection is available; otherwise, false.</returns>
		// Token: 0x06002109 RID: 8457 RVA: 0x000025B7 File Offset: 0x000007B7
		[global::System.MonoTODO("Always returns true")]
		public static bool GetIsNetworkAvailable()
		{
			return true;
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x000611A8 File Offset: 0x0005F3A8
		internal static string ReadLine(string path)
		{
			string text;
			using (FileStream fileStream = File.OpenRead(path))
			{
				using (StreamReader streamReader = new StreamReader(fileStream))
				{
					text = streamReader.ReadLine();
				}
			}
			return text;
		}

		/// <summary>Gets the index of the IPv4 loopback interface.</summary>
		/// <returns>A <see cref="T:System.Int32" /> that contains the index for the IPv4 loopback interface.</returns>
		/// <exception cref="T:System.Net.NetworkInformation.NetworkInformationException">This property is not valid on computers running only Ipv6.</exception>
		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x00061210 File Offset: 0x0005F410
		[global::System.MonoTODO("Only works on Linux. Returns 0 on other systems.")]
		public static int LoopbackInterfaceIndex
		{
			get
			{
				if (NetworkInterface.runningOnUnix)
				{
					try
					{
						return UnixNetworkInterface.IfNameToIndex("lo");
					}
					catch
					{
						return 0;
					}
					return 0;
				}
				return 0;
			}
		}

		/// <summary>Returns an object that describes the configuration of this network interface.</summary>
		/// <returns>An <see cref="T:System.Net.NetworkInformation.IPInterfaceProperties" /> object that describes this network interface.</returns>
		// Token: 0x0600210C RID: 8460
		public abstract IPInterfaceProperties GetIPProperties();

		/// <summary>Gets the IPv4 statistics.</summary>
		/// <returns>An <see cref="T:System.Net.NetworkInformation.IPv4InterfaceStatistics" /> object.</returns>
		// Token: 0x0600210D RID: 8461
		public abstract IPv4InterfaceStatistics GetIPv4Statistics();

		/// <summary>Returns the Media Access Control (MAC) or physical address for this adapter.</summary>
		/// <returns>A <see cref="T:System.Net.NetworkInformation.PhysicalAddress" /> object that contains the physical address.</returns>
		// Token: 0x0600210E RID: 8462
		public abstract PhysicalAddress GetPhysicalAddress();

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the interface supports the specified protocol.</summary>
		/// <returns>true if the specified protocol is supported; otherwise, false.</returns>
		/// <param name="networkInterfaceComponent">A <see cref="T:System.Net.NetworkInformation.NetworkInterfaceComponent" /> value.</param>
		// Token: 0x0600210F RID: 8463
		public abstract bool Supports(NetworkInterfaceComponent networkInterfaceComponent);

		/// <summary>Gets the description of the interface.</summary>
		/// <returns>A <see cref="T:System.String" /> that describes this interface.</returns>
		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06002110 RID: 8464
		public abstract string Description { get; }

		/// <summary>Gets the identifier of the network adapter.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the identifier.</returns>
		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06002111 RID: 8465
		public abstract string Id { get; }

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the network interface is set to only receive data packets.</summary>
		/// <returns>true if the interface only receives network traffic; otherwise, false.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">This property is not valid on computers running operating systems earlier than Windows XP. </exception>
		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06002112 RID: 8466
		public abstract bool IsReceiveOnly { get; }

		/// <summary>Gets the name of the network adapter.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the adapter name.</returns>
		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06002113 RID: 8467
		public abstract string Name { get; }

		/// <summary>Gets the interface type.</summary>
		/// <returns>An <see cref="T:System.Net.NetworkInformation.NetworkInterfaceType" /> value that specifies the network interface type.</returns>
		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06002114 RID: 8468
		public abstract NetworkInterfaceType NetworkInterfaceType { get; }

		/// <summary>Gets the current operational state of the network connection.</summary>
		/// <returns>One of the <see cref="T:System.Net.NetworkInformation.OperationalStatus" /> values.</returns>
		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06002115 RID: 8469
		public abstract OperationalStatus OperationalStatus { get; }

		/// <summary>Gets the speed of the network interface.</summary>
		/// <returns>A <see cref="T:System.Int64" /> value that specifies the speed in bits per second.</returns>
		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06002116 RID: 8470
		public abstract long Speed { get; }

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the network interface is enabled to receive multicast packets.</summary>
		/// <returns>true if the interface receives multicast packets; otherwise, false.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">This property is not valid on computers running operating systems earlier than Windows XP. </exception>
		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06002117 RID: 8471
		public abstract bool SupportsMulticast { get; }

		// Token: 0x040013F8 RID: 5112
		private static Version windowsVer51 = new Version(5, 1);

		// Token: 0x040013F9 RID: 5113
		internal static readonly bool runningOnUnix = Environment.OSVersion.Platform == PlatformID.Unix;
	}
}
