using System;
using System.Xml;

namespace System.Configuration
{
	/// <summary>Contains the XML representing the serialized value of the setting. This class cannot be inherited.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000204 RID: 516
	public sealed class SettingValueElement : ConfigurationElement
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Configuration.SettingValueElement" /> class. </summary>
		// Token: 0x06001188 RID: 4488 RVA: 0x000056FB File Offset: 0x000038FB
		[global::System.MonoTODO]
		public SettingValueElement()
		{
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x0000E304 File Offset: 0x0000C504
		[global::System.MonoTODO]
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return base.Properties;
			}
		}

		/// <summary>Gets or sets the value of a <see cref="T:System.Configuration.SettingValueElement" /> object by using an <see cref="T:System.Xml.XmlNode" /> object.</summary>
		/// <returns>An <see cref="T:System.Xml.XmlNode" /> object containing the value of a <see cref="T:System.Configuration.SettingElement" />.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x0000E30C File Offset: 0x0000C50C
		// (set) Token: 0x0600118B RID: 4491 RVA: 0x0000E314 File Offset: 0x0000C514
		public XmlNode ValueXml
		{
			get
			{
				return this.node;
			}
			set
			{
				this.node = value;
			}
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0000E31D File Offset: 0x0000C51D
		[global::System.MonoTODO]
		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
			this.node = new XmlDocument().ReadNode(reader);
		}

		/// <summary>Compares the current <see cref="T:System.Configuration.SettingValueElement" /> instance to the specified object.</summary>
		/// <returns>true if the <see cref="T:System.Configuration.SettingValueElement" /> instance is equal to the specified object; otherwise, false.</returns>
		/// <param name="settingValue">The object to compare.</param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x0600118D RID: 4493 RVA: 0x00002664 File Offset: 0x00000864
		public override bool Equals(object settingValue)
		{
			throw new NotImplementedException();
		}

		/// <summary>Gets a unique value representing the <see cref="T:System.Configuration.SettingValueElement" /> current instance.</summary>
		/// <returns>A unique value representing the <see cref="T:System.Configuration.SettingValueElement" /> current instance.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x0600118E RID: 4494 RVA: 0x00002664 File Offset: 0x00000864
		public override int GetHashCode()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00002664 File Offset: 0x00000864
		protected override bool IsModified()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0000E330 File Offset: 0x0000C530
		protected override void Reset(ConfigurationElement parentElement)
		{
			this.node = null;
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00002664 File Offset: 0x00000864
		protected override void ResetModified()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0000E339 File Offset: 0x0000C539
		protected override bool SerializeToXmlElement(XmlWriter writer, string elementName)
		{
			if (this.node == null)
			{
				return false;
			}
			this.node.WriteTo(writer);
			return true;
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00002664 File Offset: 0x00000864
		protected override void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400050D RID: 1293
		private XmlNode node;
	}
}
