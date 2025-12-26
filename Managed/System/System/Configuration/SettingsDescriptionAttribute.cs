using System;

namespace System.Configuration
{
	/// <summary>Provides a string that describes an individual configuration property. This class cannot be inherited.</summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x02000208 RID: 520
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class SettingsDescriptionAttribute : Attribute
	{
		/// <summary>Initializes an instance of the <see cref="T:System.Configuration.SettingsDescriptionAttribute" /> class.</summary>
		/// <param name="description">The <see cref="T:System.String" /> used as descriptive text.</param>
		// Token: 0x06001198 RID: 4504 RVA: 0x0000E383 File Offset: 0x0000C583
		public SettingsDescriptionAttribute(string description)
		{
			this.desc = description;
		}

		/// <summary>Gets the descriptive text for the associated configuration property.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the descriptive text for the associated configuration property.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x0000E392 File Offset: 0x0000C592
		public string Description
		{
			get
			{
				return this.desc;
			}
		}

		// Token: 0x04000512 RID: 1298
		private string desc;
	}
}
