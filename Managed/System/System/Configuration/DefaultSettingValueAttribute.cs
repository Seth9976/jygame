using System;

namespace System.Configuration
{
	/// <summary>Specifies the default value for an application settings property.</summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x020001E1 RID: 481
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class DefaultSettingValueAttribute : Attribute
	{
		/// <summary>Initializes an instance of the <see cref="T:System.Configuration.DefaultSettingValueAttribute" /> class.</summary>
		/// <param name="value">A <see cref="T:System.String" /> that represents the default value for the property. </param>
		// Token: 0x060010C7 RID: 4295 RVA: 0x0000DBB9 File Offset: 0x0000BDB9
		public DefaultSettingValueAttribute(string value)
		{
			this.value = value;
		}

		/// <summary>Gets the default value for the application settings property.</summary>
		/// <returns>A <see cref="T:System.String" /> that represents the default value for the property.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060010C8 RID: 4296 RVA: 0x0000DBC8 File Offset: 0x0000BDC8
		public string Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x040004DC RID: 1244
		private string value;
	}
}
