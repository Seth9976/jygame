using System;

namespace System.Configuration
{
	/// <summary>Specifies a name for application settings property group. This class cannot be inherited.</summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x02000209 RID: 521
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class SettingsGroupNameAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Configuration.SettingsGroupNameAttribute" /> class.</summary>
		/// <param name="groupName">A <see cref="T:System.String" /> containing the name of the application settings property group.</param>
		// Token: 0x0600119A RID: 4506 RVA: 0x0000E39A File Offset: 0x0000C59A
		public SettingsGroupNameAttribute(string groupName)
		{
			this.group_name = groupName;
		}

		/// <summary>Gets the name of the application settings property group.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the name of the application settings property group.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x0000E3A9 File Offset: 0x0000C5A9
		public string GroupName
		{
			get
			{
				return this.group_name;
			}
		}

		// Token: 0x04000513 RID: 1299
		private string group_name;
	}
}
