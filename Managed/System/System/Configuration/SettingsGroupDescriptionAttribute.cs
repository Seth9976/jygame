using System;

namespace System.Configuration
{
	/// <summary>Provides a string that describes an application settings property group. This class cannot be inherited.</summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x02000207 RID: 519
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class SettingsGroupDescriptionAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Configuration.SettingsGroupDescriptionAttribute" /> class.</summary>
		/// <param name="description">A <see cref="T:System.String" /> containing the descriptive text for the application settings group.</param>
		// Token: 0x06001196 RID: 4502 RVA: 0x0000E36C File Offset: 0x0000C56C
		public SettingsGroupDescriptionAttribute(string description)
		{
			this.desc = description;
		}

		/// <summary>The descriptive text for the application settings properties group.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the descriptive text for the application settings group.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x0000E37B File Offset: 0x0000C57B
		public string Description
		{
			get
			{
				return this.desc;
			}
		}

		// Token: 0x04000511 RID: 1297
		private string desc;
	}
}
