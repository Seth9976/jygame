using System;
using System.ComponentModel;

namespace System.Configuration
{
	/// <summary>Provides data for the <see cref="E:System.Configuration.ApplicationSettingsBase.SettingChanging" /> event.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x020001F1 RID: 497
	public class SettingChangingEventArgs : global::System.ComponentModel.CancelEventArgs
	{
		/// <summary>Initializes an instance of the <see cref="T:System.Configuration.SettingChangingEventArgs" /> class.</summary>
		/// <param name="settingName">A <see cref="T:System.String" /> containing the name of the application setting.</param>
		/// <param name="settingClass">A <see cref="T:System.String" /> containing a category description of the setting. Often this parameter is set to the application settings group name.</param>
		/// <param name="settingKey">A <see cref="T:System.String" /> containing the application settings key.</param>
		/// <param name="newValue">An <see cref="T:System.Object" /> that contains the new value to be assigned to the application settings property.</param>
		/// <param name="cancel">true to cancel the event; otherwise, false. </param>
		// Token: 0x060010FE RID: 4350 RVA: 0x0000DDA6 File Offset: 0x0000BFA6
		public SettingChangingEventArgs(string settingName, string settingClass, string settingKey, object newValue, bool cancel)
			: base(cancel)
		{
			this.settingName = settingName;
			this.settingClass = settingClass;
			this.settingKey = settingKey;
			this.newValue = newValue;
		}

		/// <summary>Gets the name of the application setting associated with the application settings property.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the name of the application setting. </returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x0000DDCD File Offset: 0x0000BFCD
		public string SettingName
		{
			get
			{
				return this.settingName;
			}
		}

		/// <summary>Gets the application settings property category.</summary>
		/// <returns>A <see cref="T:System.String" /> containing a category description of the setting. Typically, this parameter is set to the application settings group name.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x0000DDD5 File Offset: 0x0000BFD5
		public string SettingClass
		{
			get
			{
				return this.settingClass;
			}
		}

		/// <summary>Gets the application settings key associated with the property.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the application settings key.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x0000DDDD File Offset: 0x0000BFDD
		public string SettingKey
		{
			get
			{
				return this.settingKey;
			}
		}

		/// <summary>Gets the new value being assigned to the application settings property.</summary>
		/// <returns>An <see cref="T:System.Object" /> that contains the new value to be assigned to the application settings property.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x0000DDE5 File Offset: 0x0000BFE5
		public object NewValue
		{
			get
			{
				return this.newValue;
			}
		}

		// Token: 0x040004E2 RID: 1250
		private string settingName;

		// Token: 0x040004E3 RID: 1251
		private string settingClass;

		// Token: 0x040004E4 RID: 1252
		private string settingKey;

		// Token: 0x040004E5 RID: 1253
		private object newValue;
	}
}
