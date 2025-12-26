using System;
using System.Security;
using System.Security.Permissions;

namespace System.Net.NetworkInformation
{
	/// <summary>Controls access to network information and traffic statistics for the local computer. This class cannot be inherited. </summary>
	// Token: 0x020003BE RID: 958
	[Serializable]
	public sealed class NetworkInformationPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkInformation.NetworkInformationPermission" /> class with the specified <see cref="T:System.Security.Permissions.PermissionState" />.</summary>
		/// <param name="state">One of the <see cref="T:System.Security.Permissions.PermissionState" /> values.</param>
		// Token: 0x060020FA RID: 8442 RVA: 0x000179FF File Offset: 0x00015BFF
		[global::System.MonoTODO]
		public NetworkInformationPermission(PermissionState state)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkInformation.NetworkInformationPermission" /> class using the specified <see cref="T:System.Net.NetworkInformation.NetworkInformationAccess" /> value.</summary>
		/// <param name="access">One of the <see cref="T:System.Net.NetworkInformation.NetworkInformationAccess" /> values.</param>
		// Token: 0x060020FB RID: 8443 RVA: 0x000179FF File Offset: 0x00015BFF
		[global::System.MonoTODO]
		public NetworkInformationPermission(NetworkInformationAccess access)
		{
		}

		/// <summary>Adds the specified value to this permission.</summary>
		/// <param name="access">One of the <see cref="T:System.Net.NetworkInformation.NetworkInformationAccess" /> values.</param>
		// Token: 0x060020FC RID: 8444 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO]
		public void AddPermission(NetworkInformationAccess access)
		{
		}

		/// <summary>Creates and returns an identical copy of this permission.</summary>
		/// <returns>A <see cref="T:System.Net.NetworkInformation.NetworkInformationPermission" /> that is identical to the current permission</returns>
		// Token: 0x060020FD RID: 8445 RVA: 0x00002A97 File Offset: 0x00000C97
		[global::System.MonoTODO]
		public override IPermission Copy()
		{
			return null;
		}

		/// <summary>Sets the state of this permission using the specified XML encoding.</summary>
		/// <param name="securityElement">A <see cref="T:System.Security.SecurityElement" /> that contains the XML encoding to use to set the state of the current permission</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="securityElement" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="securityElement" /> is not a permission encoding.-or-<paramref name="securityElement" /> is not an encoding of a <see cref="T:System.Net.NetworkInformation.NetworkInformationPermission" />. -or-<paramref name="securityElement" /> has invalid <see cref="T:System.Net.NetworkInformation.NetworkInformationAccess" /> values.</exception>
		// Token: 0x060020FE RID: 8446 RVA: 0x000029F5 File Offset: 0x00000BF5
		[global::System.MonoTODO]
		public override void FromXml(SecurityElement securityElement)
		{
		}

		/// <summary>Creates and returns a permission that is the intersection of the current permission and the specified permission.</summary>
		/// <returns>A <see cref="T:System.Net.NetworkInformation.NetworkInformationPermission" /> that represents the intersection of the current permission and the specified permission. This new permission is null if the intersection is empty or <paramref name="target" /> is null.</returns>
		/// <param name="target">An <see cref="T:System.Security.IPermission" /> to intersect with the current permission. It must be of the same type as the current permission. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> is not a <see cref="T:System.Net.NetworkInformation.NetworkInformationPermission" />.</exception>
		// Token: 0x060020FF RID: 8447 RVA: 0x00002A97 File Offset: 0x00000C97
		[global::System.MonoTODO]
		public override IPermission Intersect(IPermission target)
		{
			return null;
		}

		/// <summary>Determines whether the current permission is a subset of the specified permission.</summary>
		/// <returns>true if the current permission is a subset of the specified permission; otherwise, false.</returns>
		/// <param name="target">An <see cref="T:System.Security.IPermission" /> that is to be tested for the subset relationship. This permission must be of the same type as the current permission</param>
		// Token: 0x06002100 RID: 8448 RVA: 0x00002AA1 File Offset: 0x00000CA1
		[global::System.MonoTODO]
		public override bool IsSubsetOf(IPermission target)
		{
			return false;
		}

		/// <summary>Returns a value indicating whether the current permission is unrestricted.</summary>
		/// <returns>true if the current permission is unrestricted; otherwise, false.</returns>
		// Token: 0x06002101 RID: 8449 RVA: 0x00002AA1 File Offset: 0x00000CA1
		[global::System.MonoTODO]
		public bool IsUnrestricted()
		{
			return false;
		}

		/// <summary>Creates an XML encoding of the state of this permission.</summary>
		/// <returns>A <see cref="T:System.Security.SecurityElement" /> that contains the XML encoding of the current permission.</returns>
		// Token: 0x06002102 RID: 8450 RVA: 0x000610B8 File Offset: 0x0005F2B8
		[global::System.MonoTODO]
		public override SecurityElement ToXml()
		{
			return global::System.Security.Permissions.PermissionHelper.Element(typeof(NetworkInformationPermission), 1);
		}

		/// <summary>Creates a permission that is the union of this permission and the specified permission.</summary>
		/// <returns>A new permission that represents the union of the current permission and the specified permission.</returns>
		/// <param name="target">A <see cref="T:System.Net.NetworkInformation.NetworkInformationPermission" />  permission to combine with the current permission. </param>
		// Token: 0x06002103 RID: 8451 RVA: 0x00002A97 File Offset: 0x00000C97
		[global::System.MonoTODO]
		public override IPermission Union(IPermission target)
		{
			return null;
		}

		/// <summary>Gets the level of access to network information controlled by this permission. </summary>
		/// <returns>One of the <see cref="T:System.Net.NetworkInformation.NetworkInformationAccess" /> values.</returns>
		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06002104 RID: 8452 RVA: 0x00002AA1 File Offset: 0x00000CA1
		[global::System.MonoTODO]
		public NetworkInformationAccess Access
		{
			get
			{
				return NetworkInformationAccess.None;
			}
		}

		// Token: 0x040013F4 RID: 5108
		private const int version = 1;
	}
}
