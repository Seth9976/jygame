using System;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Defines the smallest unit of a code access security permission that is set for an <see cref="T:System.Diagnostics.EventLog" />.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x0200022E RID: 558
	[Serializable]
	public class EventLogPermissionEntry
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventLogPermissionEntry" /> class.</summary>
		/// <param name="permissionAccess">A bitwise combination of the <see cref="T:System.Diagnostics.EventLogPermissionAccess" /> values. The <see cref="P:System.Diagnostics.EventLogPermissionEntry.PermissionAccess" /> property is set to this value. </param>
		/// <param name="machineName">The name of the computer on which to read or write events. The <see cref="P:System.Diagnostics.EventLogPermissionEntry.MachineName" /> property is set to this value. </param>
		/// <exception cref="T:System.ArgumentException">The computer name is invalid. </exception>
		// Token: 0x060012F5 RID: 4853 RVA: 0x0000F10B File Offset: 0x0000D30B
		public EventLogPermissionEntry(EventLogPermissionAccess permissionAccess, string machineName)
		{
			global::System.Security.Permissions.ResourcePermissionBase.ValidateMachineName(machineName);
			this.permissionAccess = permissionAccess;
			this.machineName = machineName;
		}

		/// <summary>Gets the name of the computer on which to read or write events.</summary>
		/// <returns>The name of the computer on which to read or write events.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x0000F127 File Offset: 0x0000D327
		public string MachineName
		{
			get
			{
				return this.machineName;
			}
		}

		/// <summary>Gets the permission access levels used in the permissions request.</summary>
		/// <returns>A bitwise combination of the <see cref="T:System.Diagnostics.EventLogPermissionAccess" /> values.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x0000F12F File Offset: 0x0000D32F
		public EventLogPermissionAccess PermissionAccess
		{
			get
			{
				return this.permissionAccess;
			}
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x0000F137 File Offset: 0x0000D337
		internal global::System.Security.Permissions.ResourcePermissionBaseEntry CreateResourcePermissionBaseEntry()
		{
			return new global::System.Security.Permissions.ResourcePermissionBaseEntry((int)this.permissionAccess, new string[] { this.machineName });
		}

		// Token: 0x04000574 RID: 1396
		private EventLogPermissionAccess permissionAccess;

		// Token: 0x04000575 RID: 1397
		private string machineName;
	}
}
