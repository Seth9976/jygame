using System;
using System.Security;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Allows declaritive performance counter permission checks. </summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x02000242 RID: 578
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Event, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public class PerformanceCounterPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.PerformanceCounterPermissionAttribute" /> class.</summary>
		/// <param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values. </param>
		// Token: 0x060013DF RID: 5087 RVA: 0x0000F99B File Offset: 0x0000DB9B
		public PerformanceCounterPermissionAttribute(SecurityAction action)
			: base(action)
		{
			this.categoryName = "*";
			this.machineName = ".";
			this.permissionAccess = PerformanceCounterPermissionAccess.Write;
		}

		/// <summary>Gets or sets the name of the performance counter category.</summary>
		/// <returns>The name of the performance counter category (performance object).</returns>
		/// <exception cref="T:System.ArgumentNullException">The value is null. </exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x0000F9C1 File Offset: 0x0000DBC1
		// (set) Token: 0x060013E1 RID: 5089 RVA: 0x0000F9C9 File Offset: 0x0000DBC9
		public string CategoryName
		{
			get
			{
				return this.categoryName;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("CategoryName");
				}
				this.categoryName = value;
			}
		}

		/// <summary>Gets or sets the computer name for the performance counter.</summary>
		/// <returns>The server on which the category of the performance counter resides.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Diagnostics.PerformanceCounterPermissionAttribute.MachineName" /> format is invalid. </exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x0000F9E3 File Offset: 0x0000DBE3
		// (set) Token: 0x060013E3 RID: 5091 RVA: 0x0000F9EB File Offset: 0x0000DBEB
		public string MachineName
		{
			get
			{
				return this.machineName;
			}
			set
			{
				global::System.Security.Permissions.ResourcePermissionBase.ValidateMachineName(value);
				this.machineName = value;
			}
		}

		/// <summary>Gets or sets the access levels used in the permissions request.</summary>
		/// <returns>A bitwise combination of the <see cref="T:System.Diagnostics.PerformanceCounterPermissionAccess" /> values. The default is <see cref="F:System.Diagnostics.EventLogPermissionAccess.Write" />.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x0000F9FA File Offset: 0x0000DBFA
		// (set) Token: 0x060013E5 RID: 5093 RVA: 0x0000FA02 File Offset: 0x0000DC02
		public PerformanceCounterPermissionAccess PermissionAccess
		{
			get
			{
				return this.permissionAccess;
			}
			set
			{
				this.permissionAccess = value;
			}
		}

		/// <summary>Creates the permission based on the requested access levels that are set through the <see cref="P:System.Diagnostics.PerformanceCounterPermissionAttribute.PermissionAccess" /> property on the attribute.</summary>
		/// <returns>An <see cref="T:System.Security.IPermission" /> that represents the created permission.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x060013E6 RID: 5094 RVA: 0x0000FA0B File Offset: 0x0000DC0B
		public override IPermission CreatePermission()
		{
			if (base.Unrestricted)
			{
				return new PerformanceCounterPermission(PermissionState.Unrestricted);
			}
			return new PerformanceCounterPermission(this.permissionAccess, this.machineName, this.categoryName);
		}

		// Token: 0x040005C5 RID: 1477
		private string categoryName;

		// Token: 0x040005C6 RID: 1478
		private string machineName;

		// Token: 0x040005C7 RID: 1479
		private PerformanceCounterPermissionAccess permissionAccess;
	}
}
