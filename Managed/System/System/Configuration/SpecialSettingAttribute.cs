using System;

namespace System.Configuration
{
	/// <summary>Indicates that an application settings property has a special significance. This class cannot be inherited.</summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x0200020C RID: 524
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class SpecialSettingAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Configuration.SpecialSettingAttribute" /> class.</summary>
		/// <param name="specialSetting">A <see cref="T:System.Configuration.SpecialSetting" /> enumeration value defining the category of the application settings property.</param>
		// Token: 0x0600119E RID: 4510 RVA: 0x0000E3B1 File Offset: 0x0000C5B1
		public SpecialSettingAttribute(SpecialSetting setting)
		{
			this.setting = setting;
		}

		/// <summary>Gets the value describing the special setting category of the application settings property.</summary>
		/// <returns>A <see cref="T:System.Configuration.SpecialSetting" /> enumeration value defining the category of the application settings property.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x0000E3C0 File Offset: 0x0000C5C0
		public SpecialSetting SpecialSetting
		{
			get
			{
				return this.setting;
			}
		}

		// Token: 0x04000517 RID: 1303
		private SpecialSetting setting;
	}
}
