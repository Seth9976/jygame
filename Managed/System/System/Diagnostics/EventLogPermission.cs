using System;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Allows control of code access permissions for event logging.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x0200022C RID: 556
	[Serializable]
	public sealed class EventLogPermission : global::System.Security.Permissions.ResourcePermissionBase
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventLogPermission" /> class.</summary>
		// Token: 0x060012DC RID: 4828 RVA: 0x0000EFDF File Offset: 0x0000D1DF
		public EventLogPermission()
		{
			this.SetUp();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventLogPermission" /> class with the specified permission access level entries.</summary>
		/// <param name="permissionAccessEntries">An array of <see cref="T:System.Diagnostics.EventLogPermissionEntry" /> objects. The <see cref="P:System.Diagnostics.EventLogPermission.PermissionEntries" /> property is set to this value. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="permissionAccessEntries" /> is null.</exception>
		// Token: 0x060012DD RID: 4829 RVA: 0x0000EFED File Offset: 0x0000D1ED
		public EventLogPermission(EventLogPermissionEntry[] permissionAccessEntries)
		{
			if (permissionAccessEntries == null)
			{
				throw new ArgumentNullException("permissionAccessEntries");
			}
			this.SetUp();
			this.innerCollection = new EventLogPermissionEntryCollection(this);
			this.innerCollection.AddRange(permissionAccessEntries);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventLogPermission" /> class with the specified permission state.</summary>
		/// <param name="state">One of the <see cref="T:System.Security.Permissions.PermissionState" /> values. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="state" /> parameter is not a valid value of <see cref="T:System.Security.Permissions.PermissionState" />. </exception>
		// Token: 0x060012DE RID: 4830 RVA: 0x0000F024 File Offset: 0x0000D224
		public EventLogPermission(PermissionState state)
			: base(state)
		{
			this.SetUp();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventLogPermission" /> class with the specified access levels and the name of the computer to use.</summary>
		/// <param name="permissionAccess">One of the <see cref="T:System.Diagnostics.EventLogPermissionAccess" /> values. </param>
		/// <param name="machineName">The name of the computer on which to read or write events. </param>
		// Token: 0x060012DF RID: 4831 RVA: 0x0000F033 File Offset: 0x0000D233
		public EventLogPermission(EventLogPermissionAccess permissionAccess, string machineName)
		{
			this.SetUp();
			this.innerCollection = new EventLogPermissionEntryCollection(this);
			this.innerCollection.Add(new EventLogPermissionEntry(permissionAccess, machineName));
		}

		/// <summary>Gets the collection of permission entries for this permissions request.</summary>
		/// <returns>A <see cref="T:System.Diagnostics.EventLogPermissionEntryCollection" /> that contains the permission entries for this permissions request.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060012E0 RID: 4832 RVA: 0x0000F060 File Offset: 0x0000D260
		public EventLogPermissionEntryCollection PermissionEntries
		{
			get
			{
				if (this.innerCollection == null)
				{
					this.innerCollection = new EventLogPermissionEntryCollection(this);
				}
				return this.innerCollection;
			}
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x0000F07F File Offset: 0x0000D27F
		private void SetUp()
		{
			base.TagNames = new string[] { "Machine" };
			base.PermissionAccessType = typeof(EventLogPermissionAccess);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x0000F0A5 File Offset: 0x0000D2A5
		internal global::System.Security.Permissions.ResourcePermissionBaseEntry[] GetEntries()
		{
			return base.GetPermissionEntries();
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0000F0AD File Offset: 0x0000D2AD
		internal void ClearEntries()
		{
			base.Clear();
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x0003ECBC File Offset: 0x0003CEBC
		internal void Add(object obj)
		{
			EventLogPermissionEntry eventLogPermissionEntry = obj as EventLogPermissionEntry;
			base.AddPermissionAccess(eventLogPermissionEntry.CreateResourcePermissionBaseEntry());
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0003ECDC File Offset: 0x0003CEDC
		internal void Remove(object obj)
		{
			EventLogPermissionEntry eventLogPermissionEntry = obj as EventLogPermissionEntry;
			base.RemovePermissionAccess(eventLogPermissionEntry.CreateResourcePermissionBaseEntry());
		}

		// Token: 0x04000572 RID: 1394
		private EventLogPermissionEntryCollection innerCollection;
	}
}
