using System;
using System.Collections;
using System.IO;
using System.Security.Permissions;
using System.Xml;

namespace System.Configuration
{
	// Token: 0x020001D8 RID: 472
	internal class ConfigurationData
	{
		// Token: 0x06001059 RID: 4185 RVA: 0x0000D5AD File Offset: 0x0000B7AD
		public ConfigurationData()
			: this(null)
		{
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0000D5B6 File Offset: 0x0000B7B6
		public ConfigurationData(ConfigurationData parent)
		{
			this.parent = ((parent != this) ? parent : null);
			this.factories = new Hashtable();
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x0000D5FD File Offset: 0x0000B7FD
		private Hashtable FileCache
		{
			get
			{
				if (this.cache != null)
				{
					return this.cache;
				}
				this.cache = new Hashtable();
				return this.cache;
			}
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0003992C File Offset: 0x00037B2C
		[PermissionSet(SecurityAction.Assert, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\">\n<IPermission class=\"System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\nversion=\"1\"\nUnrestricted=\"true\"/>\n</PermissionSet>\n")]
		public bool Load(string fileName)
		{
			this.fileName = fileName;
			if (fileName == null || !File.Exists(fileName))
			{
				return false;
			}
			XmlTextReader xmlTextReader = null;
			try
			{
				FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
				xmlTextReader = new XmlTextReader(fileStream);
				if (this.InitRead(xmlTextReader))
				{
					this.ReadConfigFile(xmlTextReader);
				}
			}
			catch (ConfigurationException)
			{
				throw;
			}
			catch (Exception ex)
			{
				throw new ConfigurationException("Error reading " + fileName, ex);
			}
			finally
			{
				if (xmlTextReader != null)
				{
					xmlTextReader.Close();
				}
			}
			return true;
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x000399D4 File Offset: 0x00037BD4
		public bool LoadString(string data)
		{
			if (data == null)
			{
				return false;
			}
			XmlTextReader xmlTextReader = null;
			try
			{
				TextReader textReader = new StringReader(data);
				xmlTextReader = new XmlTextReader(textReader);
				if (this.InitRead(xmlTextReader))
				{
					this.ReadConfigFile(xmlTextReader);
				}
			}
			catch (ConfigurationException)
			{
				throw;
			}
			catch (Exception ex)
			{
				throw new ConfigurationException("Error reading " + this.fileName, ex);
			}
			finally
			{
				if (xmlTextReader != null)
				{
					xmlTextReader.Close();
				}
			}
			return true;
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00039A6C File Offset: 0x00037C6C
		private object GetHandler(string sectionName)
		{
			Hashtable hashtable = this.factories;
			object obj2;
			lock (hashtable)
			{
				object obj = this.factories[sectionName];
				if (obj == null || obj == ConfigurationData.removedMark)
				{
					if (this.parent != null)
					{
						obj2 = this.parent.GetHandler(sectionName);
					}
					else
					{
						obj2 = null;
					}
				}
				else if (obj is IConfigurationSectionHandler)
				{
					obj2 = (IConfigurationSectionHandler)obj;
				}
				else
				{
					obj = this.CreateNewHandler(sectionName, (SectionData)obj);
					this.factories[sectionName] = obj;
					obj2 = obj;
				}
			}
			return obj2;
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00039B20 File Offset: 0x00037D20
		private object CreateNewHandler(string sectionName, SectionData section)
		{
			Type type = Type.GetType(section.TypeName);
			if (type == null)
			{
				throw new ConfigurationException("Cannot get Type for " + section.TypeName);
			}
			object obj = Activator.CreateInstance(type, true);
			if (obj == null)
			{
				throw new ConfigurationException("Cannot get instance for " + type);
			}
			return obj;
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00039B78 File Offset: 0x00037D78
		private XmlDocument GetInnerDoc(XmlDocument doc, int i, string[] sectionPath)
		{
			if (++i >= sectionPath.Length)
			{
				return doc;
			}
			if (doc.DocumentElement == null)
			{
				return null;
			}
			for (XmlNode xmlNode = doc.DocumentElement.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
			{
				if (xmlNode.Name == sectionPath[i])
				{
					ConfigXmlDocument configXmlDocument = new ConfigXmlDocument();
					configXmlDocument.Load(new StringReader(xmlNode.OuterXml));
					return this.GetInnerDoc(configXmlDocument, i, sectionPath);
				}
			}
			return null;
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00039BF8 File Offset: 0x00037DF8
		private XmlDocument GetDocumentForSection(string sectionName)
		{
			ConfigXmlDocument configXmlDocument = new ConfigXmlDocument();
			if (this.pending == null)
			{
				return configXmlDocument;
			}
			string[] array = sectionName.Split(new char[] { '/' });
			string text = this.pending[array[0]] as string;
			if (text == null)
			{
				return configXmlDocument;
			}
			StringReader stringReader = new StringReader(text);
			XmlTextReader xmlTextReader = new XmlTextReader(stringReader);
			xmlTextReader.MoveToContent();
			configXmlDocument.LoadSingleElement(this.fileName, xmlTextReader);
			return this.GetInnerDoc(configXmlDocument, 0, array);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00039C74 File Offset: 0x00037E74
		private object GetConfigInternal(string sectionName)
		{
			object handler = this.GetHandler(sectionName);
			IConfigurationSectionHandler configurationSectionHandler = handler as IConfigurationSectionHandler;
			if (configurationSectionHandler == null)
			{
				return handler;
			}
			object obj = null;
			if (this.parent != null)
			{
				obj = this.parent.GetConfig(sectionName);
			}
			XmlDocument documentForSection = this.GetDocumentForSection(sectionName);
			if (documentForSection == null || documentForSection.DocumentElement == null)
			{
				return obj;
			}
			return configurationSectionHandler.Create(obj, this.fileName, documentForSection.DocumentElement);
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00039CE0 File Offset: 0x00037EE0
		public object GetConfig(string sectionName)
		{
			object obj;
			lock (this)
			{
				obj = this.FileCache[sectionName];
			}
			if (obj == ConfigurationData.emptyMark)
			{
				return null;
			}
			if (obj != null)
			{
				return obj;
			}
			lock (this)
			{
				obj = this.GetConfigInternal(sectionName);
				this.FileCache[sectionName] = ((obj != null) ? obj : ConfigurationData.emptyMark);
			}
			return obj;
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00039D7C File Offset: 0x00037F7C
		private object LookForFactory(string key)
		{
			object obj = this.factories[key];
			if (obj != null)
			{
				return obj;
			}
			if (this.parent != null)
			{
				return this.parent.LookForFactory(key);
			}
			return null;
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00039DB8 File Offset: 0x00037FB8
		private bool InitRead(XmlTextReader reader)
		{
			reader.MoveToContent();
			if (reader.NodeType != XmlNodeType.Element || reader.Name != "configuration")
			{
				this.ThrowException("Configuration file does not have a valid root element", reader);
			}
			if (reader.HasAttributes)
			{
				this.ThrowException("Unrecognized attribute in root element", reader);
			}
			if (reader.IsEmptyElement)
			{
				reader.Skip();
				return false;
			}
			reader.Read();
			reader.MoveToContent();
			return reader.NodeType != XmlNodeType.EndElement;
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00039E40 File Offset: 0x00038040
		private void MoveToNextElement(XmlTextReader reader)
		{
			while (reader.Read())
			{
				XmlNodeType nodeType = reader.NodeType;
				if (nodeType == XmlNodeType.Element)
				{
					return;
				}
				if (nodeType != XmlNodeType.Whitespace && nodeType != XmlNodeType.Comment && nodeType != XmlNodeType.SignificantWhitespace && nodeType != XmlNodeType.EndElement)
				{
					this.ThrowException("Unrecognized element", reader);
				}
			}
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x00039E98 File Offset: 0x00038098
		private void ReadSection(XmlTextReader reader, string sectionName)
		{
			string text = null;
			string text2 = null;
			string text3 = null;
			string text4 = null;
			bool flag = false;
			string text5 = null;
			bool flag2 = true;
			AllowDefinition allowDefinition = AllowDefinition.Everywhere;
			while (reader.MoveToNextAttribute())
			{
				string name = reader.Name;
				if (name != null)
				{
					if (name == "allowLocation")
					{
						if (text3 != null)
						{
							this.ThrowException("Duplicated allowLocation attribute.", reader);
						}
						text3 = reader.Value;
						flag2 = text3 == "true";
						if (!flag2 && text3 != "false")
						{
							this.ThrowException("Invalid attribute value", reader);
						}
					}
					else if (name == "requirePermission")
					{
						if (text5 != null)
						{
							this.ThrowException("Duplicated requirePermission attribute.", reader);
						}
						text5 = reader.Value;
						flag = text5 == "true";
						if (!flag && text5 != "false")
						{
							this.ThrowException("Invalid attribute value", reader);
						}
					}
					else if (name == "allowDefinition")
					{
						if (text4 != null)
						{
							this.ThrowException("Duplicated allowDefinition attribute.", reader);
						}
						text4 = reader.Value;
						try
						{
							allowDefinition = (AllowDefinition)((int)Enum.Parse(typeof(AllowDefinition), text4));
						}
						catch
						{
							this.ThrowException("Invalid attribute value", reader);
						}
					}
					else if (name == "type")
					{
						if (text2 != null)
						{
							this.ThrowException("Duplicated type attribute.", reader);
						}
						text2 = reader.Value;
					}
					else if (name == "name")
					{
						if (text != null)
						{
							this.ThrowException("Duplicated name attribute.", reader);
						}
						text = reader.Value;
						if (text == "location")
						{
							this.ThrowException("location is a reserved section name", reader);
						}
					}
					else
					{
						this.ThrowException("Unrecognized attribute.", reader);
					}
				}
			}
			if (text == null || text2 == null)
			{
				this.ThrowException("Required attribute missing", reader);
			}
			if (sectionName != null)
			{
				text = sectionName + '/' + text;
			}
			reader.MoveToElement();
			object obj = this.LookForFactory(text);
			if (obj != null && obj != ConfigurationData.removedMark)
			{
				this.ThrowException("Already have a factory for " + text, reader);
			}
			SectionData sectionData = new SectionData(text, text2, flag2, allowDefinition, flag);
			sectionData.FileName = this.fileName;
			this.factories[text] = sectionData;
			if (reader.IsEmptyElement)
			{
				reader.Skip();
			}
			else
			{
				reader.Read();
				reader.MoveToContent();
				if (reader.NodeType != XmlNodeType.EndElement)
				{
					this.ReadSections(reader, text);
				}
				reader.ReadEndElement();
			}
			reader.MoveToContent();
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x0003A164 File Offset: 0x00038364
		private void ReadRemoveSection(XmlTextReader reader, string sectionName)
		{
			if (!reader.MoveToNextAttribute() || reader.Name != "name")
			{
				this.ThrowException("Unrecognized attribute.", reader);
			}
			string text = reader.Value;
			if (text == null || text.Length == 0)
			{
				this.ThrowException("Empty name to remove", reader);
			}
			reader.MoveToElement();
			if (sectionName != null)
			{
				text = sectionName + '/' + text;
			}
			object obj = this.LookForFactory(text);
			if (obj != null && obj == ConfigurationData.removedMark)
			{
				this.ThrowException("No factory for " + text, reader);
			}
			this.factories[text] = ConfigurationData.removedMark;
			this.MoveToNextElement(reader);
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0003A220 File Offset: 0x00038420
		private void ReadSectionGroup(XmlTextReader reader, string configSection)
		{
			if (!reader.MoveToNextAttribute())
			{
				this.ThrowException("sectionGroup must have a 'name' attribute.", reader);
			}
			string text = null;
			do
			{
				if (reader.Name == "name")
				{
					if (text != null)
					{
						this.ThrowException("Duplicate 'name' attribute.", reader);
					}
					text = reader.Value;
				}
				else if (reader.Name != "type")
				{
					this.ThrowException("Unrecognized attribute.", reader);
				}
			}
			while (reader.MoveToNextAttribute());
			if (text == null)
			{
				this.ThrowException("No 'name' attribute.", reader);
			}
			if (text == "location")
			{
				this.ThrowException("location is a reserved section name", reader);
			}
			if (configSection != null)
			{
				text = configSection + '/' + text;
			}
			object obj = this.LookForFactory(text);
			if (obj != null && obj != ConfigurationData.removedMark && obj != ConfigurationData.groupMark)
			{
				this.ThrowException("Already have a factory for " + text, reader);
			}
			this.factories[text] = ConfigurationData.groupMark;
			if (reader.IsEmptyElement)
			{
				reader.Skip();
				reader.MoveToContent();
			}
			else
			{
				reader.Read();
				reader.MoveToContent();
				if (reader.NodeType != XmlNodeType.EndElement)
				{
					this.ReadSections(reader, text);
				}
				reader.ReadEndElement();
				reader.MoveToContent();
			}
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0003A37C File Offset: 0x0003857C
		private void ReadSections(XmlTextReader reader, string configSection)
		{
			int depth = reader.Depth;
			reader.MoveToContent();
			while (reader.Depth == depth)
			{
				string name = reader.Name;
				if (name == "section")
				{
					this.ReadSection(reader, configSection);
				}
				else if (name == "remove")
				{
					this.ReadRemoveSection(reader, configSection);
				}
				else if (name == "clear")
				{
					if (reader.HasAttributes)
					{
						this.ThrowException("Unrecognized attribute.", reader);
					}
					this.factories.Clear();
					this.MoveToNextElement(reader);
				}
				else if (name == "sectionGroup")
				{
					this.ReadSectionGroup(reader, configSection);
				}
				else
				{
					this.ThrowException("Unrecognized element: " + reader.Name, reader);
				}
				reader.MoveToContent();
			}
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0000D622 File Offset: 0x0000B822
		private void StorePending(string name, XmlTextReader reader)
		{
			if (this.pending == null)
			{
				this.pending = new Hashtable();
			}
			this.pending[name] = reader.ReadOuterXml();
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x0003A464 File Offset: 0x00038664
		private void ReadConfigFile(XmlTextReader reader)
		{
			reader.MoveToContent();
			while (!reader.EOF && reader.NodeType != XmlNodeType.EndElement)
			{
				string name = reader.Name;
				if (name == "configSections")
				{
					if (reader.HasAttributes)
					{
						this.ThrowException("Unrecognized attribute in <configSections>.", reader);
					}
					if (reader.IsEmptyElement)
					{
						reader.Skip();
					}
					else
					{
						reader.Read();
						reader.MoveToContent();
						if (reader.NodeType != XmlNodeType.EndElement)
						{
							this.ReadSections(reader, null);
						}
						reader.ReadEndElement();
					}
				}
				else if (name != null && name != string.Empty)
				{
					this.StorePending(name, reader);
					this.MoveToNextElement(reader);
				}
				else
				{
					this.MoveToNextElement(reader);
				}
				reader.MoveToContent();
			}
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x0000D64C File Offset: 0x0000B84C
		private void ThrowException(string text, XmlTextReader reader)
		{
			throw new ConfigurationException(text, this.fileName, reader.LineNumber);
		}

		// Token: 0x040004A0 RID: 1184
		private ConfigurationData parent;

		// Token: 0x040004A1 RID: 1185
		private Hashtable factories;

		// Token: 0x040004A2 RID: 1186
		private static object removedMark = new object();

		// Token: 0x040004A3 RID: 1187
		private static object emptyMark = new object();

		// Token: 0x040004A4 RID: 1188
		private Hashtable pending;

		// Token: 0x040004A5 RID: 1189
		private string fileName;

		// Token: 0x040004A6 RID: 1190
		private static object groupMark = new object();

		// Token: 0x040004A7 RID: 1191
		private Hashtable cache;
	}
}
