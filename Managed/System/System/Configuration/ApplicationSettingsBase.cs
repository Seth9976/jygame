using System;
using System.ComponentModel;
using System.Reflection;
using System.Threading;

namespace System.Configuration
{
	/// <summary>Acts as a base class for deriving concrete wrapper classes to implement the application settings feature in Window Forms applications.</summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x020001CC RID: 460
	public abstract class ApplicationSettingsBase : SettingsBase, global::System.ComponentModel.INotifyPropertyChanged
	{
		/// <summary>Initializes an instance of the <see cref="T:System.Configuration.ApplicationSettingsBase" /> class to its default state.</summary>
		// Token: 0x06001002 RID: 4098 RVA: 0x0000D0EC File Offset: 0x0000B2EC
		protected ApplicationSettingsBase()
		{
			base.Initialize(this.Context, this.Properties, this.Providers);
		}

		/// <summary>Initializes an instance of the <see cref="T:System.Configuration.ApplicationSettingsBase" /> class using the supplied owner component.</summary>
		/// <param name="owner">The component that will act as the owner of the application settings object.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="owner" /> is null.</exception>
		// Token: 0x06001003 RID: 4099 RVA: 0x0000D10C File Offset: 0x0000B30C
		protected ApplicationSettingsBase(global::System.ComponentModel.IComponent owner)
			: this(owner, string.Empty)
		{
		}

		/// <summary>Initializes an instance of the <see cref="T:System.Configuration.ApplicationSettingsBase" /> class using the supplied settings key.</summary>
		/// <param name="settingsKey">A <see cref="T:System.String" /> that uniquely identifies separate instances of the wrapper class.</param>
		// Token: 0x06001004 RID: 4100 RVA: 0x0000D11A File Offset: 0x0000B31A
		protected ApplicationSettingsBase(string settingsKey)
		{
			this.settingsKey = settingsKey;
			base.Initialize(this.Context, this.Properties, this.Providers);
		}

		/// <summary>Initializes an instance of the <see cref="T:System.Configuration.ApplicationSettingsBase" /> class using the supplied owner component and settings key.</summary>
		/// <param name="owner">The component that will act as the owner of the application settings object.</param>
		/// <param name="settingsKey">A <see cref="T:System.String" /> that uniquely identifies separate instances of the wrapper class.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="owner" /> is null.</exception>
		// Token: 0x06001005 RID: 4101 RVA: 0x00038A3C File Offset: 0x00036C3C
		protected ApplicationSettingsBase(global::System.ComponentModel.IComponent owner, string settingsKey)
		{
			if (owner == null)
			{
				throw new ArgumentNullException();
			}
			this.providerService = (ISettingsProviderService)owner.Site.GetService(typeof(ISettingsProviderService));
			this.settingsKey = settingsKey;
			base.Initialize(this.Context, this.Properties, this.Providers);
		}

		/// <summary>Occurs after the value of an application settings property is changed.</summary>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1400003B RID: 59
		// (add) Token: 0x06001006 RID: 4102 RVA: 0x0000D141 File Offset: 0x0000B341
		// (remove) Token: 0x06001007 RID: 4103 RVA: 0x0000D15A File Offset: 0x0000B35A
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		/// <summary>Occurs before the value of an application settings property is changed.</summary>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1400003C RID: 60
		// (add) Token: 0x06001008 RID: 4104 RVA: 0x0000D173 File Offset: 0x0000B373
		// (remove) Token: 0x06001009 RID: 4105 RVA: 0x0000D18C File Offset: 0x0000B38C
		public event SettingChangingEventHandler SettingChanging;

		/// <summary>Occurs after the application settings are retrieved from storage.</summary>
		// Token: 0x1400003D RID: 61
		// (add) Token: 0x0600100A RID: 4106 RVA: 0x0000D1A5 File Offset: 0x0000B3A5
		// (remove) Token: 0x0600100B RID: 4107 RVA: 0x0000D1BE File Offset: 0x0000B3BE
		public event SettingsLoadedEventHandler SettingsLoaded;

		/// <summary>Occurs before values are saved to the data store.</summary>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1400003E RID: 62
		// (add) Token: 0x0600100C RID: 4108 RVA: 0x0000D1D7 File Offset: 0x0000B3D7
		// (remove) Token: 0x0600100D RID: 4109 RVA: 0x0000D1F0 File Offset: 0x0000B3F0
		public event SettingsSavingEventHandler SettingsSaving;

		/// <summary>Returns the value of the named settings property for the previous version of the same application.</summary>
		/// <returns>An <see cref="T:System.Object" /> containing the value of the specified <see cref="T:System.Configuration.SettingsProperty" /> if found; otherwise, null.</returns>
		/// <param name="propertyName">A <see cref="T:System.String" /> containing the name of the settings property whose value is to be returned.</param>
		/// <exception cref="T:System.Configuration.SettingsPropertyNotFoundException">The property does not exist. The property count is zero or the property cannot be found in the data store.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlPrincipal" />
		/// </PermissionSet>
		// Token: 0x0600100E RID: 4110 RVA: 0x00002664 File Offset: 0x00000864
		public object GetPreviousVersion(string propertyName)
		{
			throw new NotImplementedException();
		}

		/// <summary>Refreshes the application settings property values from persistent storage.</summary>
		/// <filterpriority>1</filterpriority>
		// Token: 0x0600100F RID: 4111 RVA: 0x00038A9C File Offset: 0x00036C9C
		public void Reload()
		{
			foreach (object obj in this.Providers)
			{
				SettingsProvider settingsProvider = (SettingsProvider)obj;
				IApplicationSettingsProvider applicationSettingsProvider = settingsProvider as IApplicationSettingsProvider;
				if (applicationSettingsProvider != null)
				{
					applicationSettingsProvider.Reset(this.Context);
				}
			}
		}

		/// <summary>Restores the persisted application settings values to their corresponding default properties.</summary>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06001010 RID: 4112 RVA: 0x0000D209 File Offset: 0x0000B409
		public void Reset()
		{
			this.Reload();
		}

		/// <summary>Stores the current values of the application settings properties.</summary>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06001011 RID: 4113 RVA: 0x00038B14 File Offset: 0x00036D14
		public override void Save()
		{
			this.Context.CurrentSettings = this;
			foreach (object obj in this.Providers)
			{
				SettingsProvider settingsProvider = (SettingsProvider)obj;
				SettingsPropertyValueCollection settingsPropertyValueCollection = new SettingsPropertyValueCollection();
				foreach (object obj2 in this.PropertyValues)
				{
					SettingsPropertyValue settingsPropertyValue = (SettingsPropertyValue)obj2;
					if (settingsPropertyValue.Property.Provider == settingsProvider)
					{
						settingsPropertyValueCollection.Add(settingsPropertyValue);
					}
				}
				if (settingsPropertyValueCollection.Count > 0)
				{
					settingsProvider.SetPropertyValues(this.Context, settingsPropertyValueCollection);
				}
			}
			this.Context.CurrentSettings = null;
		}

		/// <summary>Updates application settings to reflect a more recent installation of the application.</summary>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06001012 RID: 4114 RVA: 0x000029F5 File Offset: 0x00000BF5
		public virtual void Upgrade()
		{
		}

		/// <summary>Raises the <see cref="E:System.Configuration.ApplicationSettingsBase.PropertyChanged" /> event.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">A <see cref="T:System.ComponentModel.PropertyChangedEventArgs" /> that contains the event data.</param>
		// Token: 0x06001013 RID: 4115 RVA: 0x0000D211 File Offset: 0x0000B411
		protected virtual void OnPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(sender, e);
			}
		}

		/// <summary>Raises the <see cref="E:System.Configuration.ApplicationSettingsBase.SettingChanging" /> event.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">A <see cref="T:System.Configuration.SettingChangingEventArgs" /> that contains the event data.</param>
		// Token: 0x06001014 RID: 4116 RVA: 0x0000D22B File Offset: 0x0000B42B
		protected virtual void OnSettingChanging(object sender, SettingChangingEventArgs e)
		{
			if (this.SettingChanging != null)
			{
				this.SettingChanging(sender, e);
			}
		}

		/// <summary>Raises the <see cref="E:System.Configuration.ApplicationSettingsBase.SettingsLoaded" /> event.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">A <see cref="T:System.Configuration.SettingsLoadedEventArgs" /> that contains the event data.</param>
		// Token: 0x06001015 RID: 4117 RVA: 0x0000D245 File Offset: 0x0000B445
		protected virtual void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
		{
			if (this.SettingsLoaded != null)
			{
				this.SettingsLoaded(sender, e);
			}
		}

		/// <summary>Raises the <see cref="E:System.Configuration.ApplicationSettingsBase.SettingsSaving" /> event.</summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">A <see cref="T:System.ComponentModel.CancelEventArgs" /> that contains the event data.</param>
		// Token: 0x06001016 RID: 4118 RVA: 0x0000D25F File Offset: 0x0000B45F
		protected virtual void OnSettingsSaving(object sender, global::System.ComponentModel.CancelEventArgs e)
		{
			if (this.SettingsSaving != null)
			{
				this.SettingsSaving(sender, e);
			}
		}

		/// <summary>Gets the application settings context associated with the settings group.</summary>
		/// <returns>A <see cref="T:System.Configuration.SettingsContext" /> associated with the settings group.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x00038C14 File Offset: 0x00036E14
		[global::System.ComponentModel.Browsable(false)]
		public override SettingsContext Context
		{
			get
			{
				if (base.IsSynchronized)
				{
					Monitor.Enter(this);
				}
				SettingsContext settingsContext;
				try
				{
					if (this.context == null)
					{
						this.context = new SettingsContext();
						this.context["SettingsKey"] = string.Empty;
						Type type = base.GetType();
						this.context["GroupName"] = type.FullName;
						this.context["SettingsClassType"] = type;
					}
					settingsContext = this.context;
				}
				finally
				{
					if (base.IsSynchronized)
					{
						Monitor.Exit(this);
					}
				}
				return settingsContext;
			}
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00038CC0 File Offset: 0x00036EC0
		private void CacheValuesByProvider(SettingsProvider provider)
		{
			SettingsPropertyCollection settingsPropertyCollection = new SettingsPropertyCollection();
			foreach (object obj in this.Properties)
			{
				SettingsProperty settingsProperty = (SettingsProperty)obj;
				if (settingsProperty.Provider == provider)
				{
					settingsPropertyCollection.Add(settingsProperty);
				}
			}
			if (settingsPropertyCollection.Count > 0)
			{
				SettingsPropertyValueCollection settingsPropertyValueCollection = provider.GetPropertyValues(this.Context, settingsPropertyCollection);
				this.PropertyValues.Add(settingsPropertyValueCollection);
			}
			this.OnSettingsLoaded(this, new SettingsLoadedEventArgs(provider));
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x000029F5 File Offset: 0x00000BF5
		private void InitializeSettings(SettingsPropertyCollection settings)
		{
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00038D6C File Offset: 0x00036F6C
		private object GetPropertyValue(string propertyName)
		{
			SettingsProperty settingsProperty = this.Properties[propertyName];
			if (settingsProperty == null)
			{
				throw new SettingsPropertyNotFoundException(propertyName);
			}
			if (this.propertyValues == null)
			{
				this.InitializeSettings(this.Properties);
			}
			if (this.PropertyValues[propertyName] == null)
			{
				this.CacheValuesByProvider(settingsProperty.Provider);
			}
			return this.PropertyValues[propertyName].PropertyValue;
		}

		/// <summary>Gets or sets the value of the specified application settings property.</summary>
		/// <returns>If found, the value of the named settings property; otherwise, null.</returns>
		/// <param name="propertyName">A <see cref="T:System.String" /> containing the name of the property to access.</param>
		/// <exception cref="T:System.Configuration.SettingsPropertyNotFoundException">There are no properties associated with the current wrapper or the specified property could not be found.</exception>
		/// <exception cref="T:System.Configuration.SettingsPropertyIsReadOnlyException">An attempt was made to set a read-only property.</exception>
		/// <exception cref="T:System.Configuration.SettingsPropertyWrongTypeException">The value supplied is of a type incompatible with the settings property, during a set operation.</exception>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000393 RID: 915
		[global::System.MonoTODO]
		public override object this[string propertyName]
		{
			get
			{
				if (base.IsSynchronized)
				{
					lock (this)
					{
						return this.GetPropertyValue(propertyName);
					}
				}
				return this.GetPropertyValue(propertyName);
			}
			set
			{
				SettingsProperty settingsProperty = this.Properties[propertyName];
				if (settingsProperty == null)
				{
					throw new SettingsPropertyNotFoundException(propertyName);
				}
				if (settingsProperty.IsReadOnly)
				{
					throw new SettingsPropertyIsReadOnlyException(propertyName);
				}
				if (value != null && !settingsProperty.PropertyType.IsAssignableFrom(value.GetType()))
				{
					throw new SettingsPropertyWrongTypeException(propertyName);
				}
				if (this.PropertyValues[propertyName] == null)
				{
					this.CacheValuesByProvider(settingsProperty.Provider);
				}
				SettingChangingEventArgs settingChangingEventArgs = new SettingChangingEventArgs(propertyName, base.GetType().FullName, this.settingsKey, value, false);
				this.OnSettingChanging(this, settingChangingEventArgs);
				if (!settingChangingEventArgs.Cancel)
				{
					this.PropertyValues[propertyName].PropertyValue = value;
					this.OnPropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
				}
			}
		}

		/// <summary>Gets the collection of settings properties in the wrapper.</summary>
		/// <returns>A <see cref="T:System.Configuration.SettingsPropertyCollection" /> containing all the <see cref="T:System.Configuration.SettingsProperty" /> objects used in the current wrapper.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">The associated settings provider could not be found or its instantiation failed. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x17000394 RID: 916
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x00038EF4 File Offset: 0x000370F4
		[global::System.ComponentModel.Browsable(false)]
		public override SettingsPropertyCollection Properties
		{
			get
			{
				if (base.IsSynchronized)
				{
					Monitor.Enter(this);
				}
				SettingsPropertyCollection settingsPropertyCollection;
				try
				{
					if (this.properties == null)
					{
						LocalFileSettingsProvider localFileSettingsProvider = null;
						this.properties = new SettingsPropertyCollection();
						foreach (PropertyInfo propertyInfo in base.GetType().GetProperties())
						{
							SettingAttribute[] array2 = (SettingAttribute[])propertyInfo.GetCustomAttributes(typeof(SettingAttribute), false);
							if (array2 != null && array2.Length != 0)
							{
								this.CreateSettingsProperty(propertyInfo, this.properties, ref localFileSettingsProvider);
							}
						}
					}
					settingsPropertyCollection = this.properties;
				}
				finally
				{
					if (base.IsSynchronized)
					{
						Monitor.Exit(this);
					}
				}
				return settingsPropertyCollection;
			}
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00038FC0 File Offset: 0x000371C0
		private void CreateSettingsProperty(PropertyInfo prop, SettingsPropertyCollection properties, ref LocalFileSettingsProvider local_provider)
		{
			SettingsAttributeDictionary settingsAttributeDictionary = new SettingsAttributeDictionary();
			SettingsProvider settingsProvider = null;
			object obj = null;
			SettingsSerializeAs settingsSerializeAs = SettingsSerializeAs.String;
			bool flag = false;
			foreach (Attribute attribute in prop.GetCustomAttributes(false))
			{
				if (attribute is SettingsProviderAttribute)
				{
					Type type = Type.GetType(((SettingsProviderAttribute)attribute).ProviderTypeName);
					settingsProvider = (SettingsProvider)Activator.CreateInstance(type);
					settingsProvider.Initialize(null, null);
				}
				else if (attribute is DefaultSettingValueAttribute)
				{
					obj = ((DefaultSettingValueAttribute)attribute).Value;
				}
				else if (attribute is SettingsSerializeAsAttribute)
				{
					settingsSerializeAs = ((SettingsSerializeAsAttribute)attribute).SerializeAs;
					flag = true;
				}
				else if (attribute is ApplicationScopedSettingAttribute || attribute is UserScopedSettingAttribute)
				{
					settingsAttributeDictionary.Add(attribute.GetType(), attribute);
				}
				else
				{
					settingsAttributeDictionary.Add(attribute.GetType(), attribute);
				}
			}
			if (!flag)
			{
				global::System.ComponentModel.TypeConverter converter = global::System.ComponentModel.TypeDescriptor.GetConverter(prop.PropertyType);
				if (converter != null && (!converter.CanConvertFrom(typeof(string)) || !converter.CanConvertTo(typeof(string))))
				{
					settingsSerializeAs = SettingsSerializeAs.Xml;
				}
			}
			SettingsProperty settingsProperty = new SettingsProperty(prop.Name, prop.PropertyType, settingsProvider, false, obj, settingsSerializeAs, settingsAttributeDictionary, false, false);
			if (this.providerService != null)
			{
				settingsProperty.Provider = this.providerService.GetSettingsProvider(settingsProperty);
			}
			if (settingsProvider == null)
			{
				if (local_provider == null)
				{
					local_provider = new LocalFileSettingsProvider();
					local_provider.Initialize(null, null);
				}
				settingsProperty.Provider = local_provider;
				settingsProvider = local_provider;
			}
			if (settingsProvider != null)
			{
				SettingsProvider settingsProvider2 = this.Providers[settingsProvider.Name];
				if (settingsProvider2 != null)
				{
					settingsProperty.Provider = settingsProvider2;
				}
			}
			properties.Add(settingsProperty);
			if (settingsProperty.Provider != null && this.Providers[settingsProperty.Provider.Name] == null)
			{
				this.Providers.Add(settingsProperty.Provider);
			}
		}

		/// <summary>Gets a collection of property values.</summary>
		/// <returns>A <see cref="T:System.Configuration.SettingsPropertyValueCollection" /> of property values.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000395 RID: 917
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x000391D4 File Offset: 0x000373D4
		[global::System.ComponentModel.Browsable(false)]
		public override SettingsPropertyValueCollection PropertyValues
		{
			get
			{
				if (base.IsSynchronized)
				{
					Monitor.Enter(this);
				}
				SettingsPropertyValueCollection settingsPropertyValueCollection;
				try
				{
					if (this.propertyValues == null)
					{
						this.propertyValues = new SettingsPropertyValueCollection();
					}
					settingsPropertyValueCollection = this.propertyValues;
				}
				finally
				{
					if (base.IsSynchronized)
					{
						Monitor.Exit(this);
					}
				}
				return settingsPropertyValueCollection;
			}
		}

		/// <summary>Gets the collection of application settings providers used by the wrapper.</summary>
		/// <returns>A <see cref="T:System.Configuration.SettingsProviderCollection" /> containing all the <see cref="T:System.Configuration.SettingsProvider" /> objects used by the settings properties of the current settings wrapper.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x0003923C File Offset: 0x0003743C
		[global::System.ComponentModel.Browsable(false)]
		public override SettingsProviderCollection Providers
		{
			get
			{
				if (base.IsSynchronized)
				{
					Monitor.Enter(this);
				}
				SettingsProviderCollection settingsProviderCollection;
				try
				{
					if (this.providers == null)
					{
						this.providers = new SettingsProviderCollection();
					}
					settingsProviderCollection = this.providers;
				}
				finally
				{
					if (base.IsSynchronized)
					{
						Monitor.Exit(this);
					}
				}
				return settingsProviderCollection;
			}
		}

		/// <summary>Gets or sets the settings key for the application settings group.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the settings key for the current settings group.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001021 RID: 4129 RVA: 0x0000D279 File Offset: 0x0000B479
		// (set) Token: 0x06001022 RID: 4130 RVA: 0x0000D281 File Offset: 0x0000B481
		[global::System.ComponentModel.Browsable(false)]
		public string SettingsKey
		{
			get
			{
				return this.settingsKey;
			}
			set
			{
				this.settingsKey = value;
			}
		}

		// Token: 0x0400047F RID: 1151
		private string settingsKey;

		// Token: 0x04000480 RID: 1152
		private SettingsContext context;

		// Token: 0x04000481 RID: 1153
		private SettingsPropertyCollection properties;

		// Token: 0x04000482 RID: 1154
		private ISettingsProviderService providerService;

		// Token: 0x04000483 RID: 1155
		private SettingsPropertyValueCollection propertyValues;

		// Token: 0x04000484 RID: 1156
		private SettingsProviderCollection providers;
	}
}
