using System;

namespace System.Configuration
{
	/// <summary>Used internally as the class that represents metadata about an individual configuration property.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x020001F9 RID: 505
	public class SettingsProperty
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Configuration.SettingsProperty" /> class, based on the supplied parameter.</summary>
		/// <param name="propertyToCopy">Specifies a copy of an existing <see cref="T:System.Configuration.SettingsProperty" /> object.</param>
		// Token: 0x0600113F RID: 4415 RVA: 0x0003BBE0 File Offset: 0x00039DE0
		public SettingsProperty(SettingsProperty propertyToCopy)
			: this(propertyToCopy.Name, propertyToCopy.PropertyType, propertyToCopy.Provider, propertyToCopy.IsReadOnly, propertyToCopy.DefaultValue, propertyToCopy.SerializeAs, new SettingsAttributeDictionary(propertyToCopy.Attributes), propertyToCopy.ThrowOnErrorDeserializing, propertyToCopy.ThrowOnErrorSerializing)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Configuration.SettingsProperty" /> class. based on the supplied parameter.</summary>
		/// <param name="name">Specifies the name of an existing <see cref="T:System.Configuration.SettingsProperty" /> object.</param>
		// Token: 0x06001140 RID: 4416 RVA: 0x0003BC30 File Offset: 0x00039E30
		public SettingsProperty(string name)
			: this(name, null, null, false, null, SettingsSerializeAs.String, new SettingsAttributeDictionary(), false, false)
		{
		}

		/// <summary>Creates a new instance of the <see cref="T:System.Configuration.SettingsProperty" /> class based on the supplied parameters.</summary>
		/// <param name="name">The name of the <see cref="T:System.Configuration.SettingsProperty" /> object.</param>
		/// <param name="propertyType">The type of <see cref="T:System.Configuration.SettingsProperty" /> object.</param>
		/// <param name="provider">A <see cref="T:System.Configuration.SettingsProvider" /> object to use for persistence.</param>
		/// <param name="isReadOnly">A <see cref="T:System.Boolean" /> value specifying whether the <see cref="T:System.Configuration.SettingsProperty" /> object is read-only.</param>
		/// <param name="defaultValue">The default value of the <see cref="T:System.Configuration.SettingsProperty" /> object.</param>
		/// <param name="serializeAs">A <see cref="T:System.Configuration.SettingsSerializeAs" /> object. This object is an enumeration used to set the serialization scheme for storing application settings.</param>
		/// <param name="attributes">A <see cref="T:System.Configuration.SettingsAttributeDictionary" /> object.</param>
		/// <param name="throwOnErrorDeserializing">A Boolean value specifying whether an error will be thrown when the property is unsuccessfully deserialized.</param>
		/// <param name="throwOnErrorSerializing">A Boolean value specifying whether an error will be thrown when the property is unsuccessfully serialized.</param>
		// Token: 0x06001141 RID: 4417 RVA: 0x0003BC50 File Offset: 0x00039E50
		public SettingsProperty(string name, Type propertyType, SettingsProvider provider, bool isReadOnly, object defaultValue, SettingsSerializeAs serializeAs, SettingsAttributeDictionary attributes, bool throwOnErrorDeserializing, bool throwOnErrorSerializing)
		{
			this.name = name;
			this.propertyType = propertyType;
			this.provider = provider;
			this.isReadOnly = isReadOnly;
			this.defaultValue = defaultValue;
			this.serializeAs = serializeAs;
			this.attributes = attributes;
			this.throwOnErrorDeserializing = throwOnErrorDeserializing;
			this.throwOnErrorSerializing = throwOnErrorSerializing;
		}

		/// <summary>Gets a <see cref="T:System.Configuration.SettingsAttributeDictionary" /> object containing the attributes of the <see cref="T:System.Configuration.SettingsProperty" /> object.</summary>
		/// <returns>A <see cref="T:System.Configuration.SettingsAttributeDictionary" /> object.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x0000E01C File Offset: 0x0000C21C
		public virtual SettingsAttributeDictionary Attributes
		{
			get
			{
				return this.attributes;
			}
		}

		/// <summary>Gets or sets the default value of the <see cref="T:System.Configuration.SettingsProperty" /> object.</summary>
		/// <returns>An object containing the default value of the <see cref="T:System.Configuration.SettingsProperty" /> object.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x0000E024 File Offset: 0x0000C224
		// (set) Token: 0x06001144 RID: 4420 RVA: 0x0000E02C File Offset: 0x0000C22C
		public virtual object DefaultValue
		{
			get
			{
				return this.defaultValue;
			}
			set
			{
				this.defaultValue = value;
			}
		}

		/// <summary>Gets or sets a value specifying whether a <see cref="T:System.Configuration.SettingsProperty" /> object is read-only. </summary>
		/// <returns>true if the <see cref="T:System.Configuration.SettingsProperty" /> is read-only; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x0000E035 File Offset: 0x0000C235
		// (set) Token: 0x06001146 RID: 4422 RVA: 0x0000E03D File Offset: 0x0000C23D
		public virtual bool IsReadOnly
		{
			get
			{
				return this.isReadOnly;
			}
			set
			{
				this.isReadOnly = value;
			}
		}

		/// <summary>Gets or sets the name of the <see cref="T:System.Configuration.SettingsProperty" />.</summary>
		/// <returns>The name of the <see cref="T:System.Configuration.SettingsProperty" />.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x0000E046 File Offset: 0x0000C246
		// (set) Token: 0x06001148 RID: 4424 RVA: 0x0000E04E File Offset: 0x0000C24E
		public virtual string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		/// <summary>Gets or sets the type for the <see cref="T:System.Configuration.SettingsProperty" />.</summary>
		/// <returns>The type for the <see cref="T:System.Configuration.SettingsProperty" />.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x0000E057 File Offset: 0x0000C257
		// (set) Token: 0x0600114A RID: 4426 RVA: 0x0000E05F File Offset: 0x0000C25F
		public virtual Type PropertyType
		{
			get
			{
				return this.propertyType;
			}
			set
			{
				this.propertyType = value;
			}
		}

		/// <summary>Gets or sets the provider for the <see cref="T:System.Configuration.SettingsProperty" />.</summary>
		/// <returns>A <see cref="T:System.Configuration.SettingsProvider" /> object.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x0000E068 File Offset: 0x0000C268
		// (set) Token: 0x0600114C RID: 4428 RVA: 0x0000E070 File Offset: 0x0000C270
		public virtual SettingsProvider Provider
		{
			get
			{
				return this.provider;
			}
			set
			{
				this.provider = value;
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Configuration.SettingsSerializeAs" /> object for the <see cref="T:System.Configuration.SettingsProperty" />.</summary>
		/// <returns>A <see cref="T:System.Configuration.SettingsSerializeAs" /> object.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x0000E079 File Offset: 0x0000C279
		// (set) Token: 0x0600114E RID: 4430 RVA: 0x0000E081 File Offset: 0x0000C281
		public virtual SettingsSerializeAs SerializeAs
		{
			get
			{
				return this.serializeAs;
			}
			set
			{
				this.serializeAs = value;
			}
		}

		/// <summary>Gets or sets a value specifying whether an error will be thrown when the property is unsuccessfully deserialized.</summary>
		/// <returns>true if the error will be thrown when the property is unsuccessfully deserialized; otherwise, false.</returns>
		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x0000E08A File Offset: 0x0000C28A
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x0000E092 File Offset: 0x0000C292
		public bool ThrowOnErrorDeserializing
		{
			get
			{
				return this.throwOnErrorDeserializing;
			}
			set
			{
				this.throwOnErrorDeserializing = value;
			}
		}

		/// <summary>Gets or sets a value specifying whether an error will be thrown when the property is unsuccessfully serialized.</summary>
		/// <returns>true if the error will be thrown when the property is unsuccessfully serialized; otherwise, false.</returns>
		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x0000E09B File Offset: 0x0000C29B
		// (set) Token: 0x06001152 RID: 4434 RVA: 0x0000E0A3 File Offset: 0x0000C2A3
		public bool ThrowOnErrorSerializing
		{
			get
			{
				return this.throwOnErrorSerializing;
			}
			set
			{
				this.throwOnErrorSerializing = value;
			}
		}

		// Token: 0x040004F3 RID: 1267
		private string name;

		// Token: 0x040004F4 RID: 1268
		private Type propertyType;

		// Token: 0x040004F5 RID: 1269
		private SettingsProvider provider;

		// Token: 0x040004F6 RID: 1270
		private bool isReadOnly;

		// Token: 0x040004F7 RID: 1271
		private object defaultValue;

		// Token: 0x040004F8 RID: 1272
		private SettingsSerializeAs serializeAs;

		// Token: 0x040004F9 RID: 1273
		private SettingsAttributeDictionary attributes;

		// Token: 0x040004FA RID: 1274
		private bool throwOnErrorDeserializing;

		// Token: 0x040004FB RID: 1275
		private bool throwOnErrorSerializing;
	}
}
