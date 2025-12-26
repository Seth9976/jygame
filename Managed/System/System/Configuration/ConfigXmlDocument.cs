using System;
using System.Configuration.Internal;
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.Xml;

namespace System.Configuration
{
	/// <summary>Wraps the corresponding <see cref="T:System.Xml.XmlDocument" /> type and also carries the necessary information for reporting file-name and line numbers. </summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x020001D9 RID: 473
	[PermissionSet((SecurityAction)14, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\"\nUnrestricted=\"true\"/>\n")]
	public sealed class ConfigXmlDocument : XmlDocument, IConfigErrorInfo, IConfigXmlNode
	{
		/// <summary>Gets the configuration file name.</summary>
		/// <returns>The file name.</returns>
		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x0000D668 File Offset: 0x0000B868
		string IConfigErrorInfo.Filename
		{
			get
			{
				return this.Filename;
			}
		}

		/// <summary>Gets the configuration line number.</summary>
		/// <returns>The line number.</returns>
		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x0000D670 File Offset: 0x0000B870
		int IConfigErrorInfo.LineNumber
		{
			get
			{
				return this.LineNumber;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x0000D668 File Offset: 0x0000B868
		string IConfigXmlNode.Filename
		{
			get
			{
				return this.Filename;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x0000D670 File Offset: 0x0000B870
		int IConfigXmlNode.LineNumber
		{
			get
			{
				return this.LineNumber;
			}
		}

		/// <summary>Creates a configuration element attribute.</summary>
		/// <returns>The <see cref="P:System.Xml.Serialization.XmlAttributes.XmlAttribute" /> attribute.</returns>
		/// <param name="prefix">The prefix definition.</param>
		/// <param name="localName">The name that is used locally.</param>
		/// <param name="namespaceUri">The URL that is assigned to the namespace.</param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x06001074 RID: 4212 RVA: 0x0000D678 File Offset: 0x0000B878
		public override XmlAttribute CreateAttribute(string prefix, string localName, string namespaceUri)
		{
			return new ConfigXmlDocument.ConfigXmlAttribute(this, prefix, localName, namespaceUri);
		}

		/// <summary>Creates an XML CData section.</summary>
		/// <returns>The <see cref="T:System.Xml.XmlCDataSection" /> value.</returns>
		/// <param name="data">The data to use.</param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x06001075 RID: 4213 RVA: 0x0000D683 File Offset: 0x0000B883
		public override XmlCDataSection CreateCDataSection(string data)
		{
			return new ConfigXmlDocument.ConfigXmlCDataSection(this, data);
		}

		/// <summary>Create an XML comment.</summary>
		/// <returns>The <see cref="T:System.Xml.XmlComment" /> value.</returns>
		/// <param name="data">The comment data.</param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x06001076 RID: 4214 RVA: 0x0000D68C File Offset: 0x0000B88C
		public override XmlComment CreateComment(string comment)
		{
			return new ConfigXmlDocument.ConfigXmlComment(this, comment);
		}

		/// <summary>Creates a configuration element.</summary>
		/// <returns>The <see cref="T:System.Xml.XmlElement" /> value.</returns>
		/// <param name="prefix">The prefix definition.</param>
		/// <param name="localName">The name used locally.</param>
		/// <param name="namespaceUri">The namespace for the URL.</param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x06001077 RID: 4215 RVA: 0x0000D695 File Offset: 0x0000B895
		public override XmlElement CreateElement(string prefix, string localName, string namespaceUri)
		{
			return new ConfigXmlDocument.ConfigXmlElement(this, prefix, localName, namespaceUri);
		}

		/// <summary>Creates white spaces.</summary>
		/// <returns>The <see cref="T:System.Xml.XmlSignificantWhitespace" /> value.</returns>
		/// <param name="data">The data to use.</param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x06001078 RID: 4216 RVA: 0x0000D6A0 File Offset: 0x0000B8A0
		public override XmlSignificantWhitespace CreateSignificantWhitespace(string data)
		{
			return base.CreateSignificantWhitespace(data);
		}

		/// <summary>Create a text node.</summary>
		/// <returns>The <see cref="T:System.Xml.XmlText" /> value.</returns>
		/// <param name="text">The text to use.</param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x06001079 RID: 4217 RVA: 0x0000D6A9 File Offset: 0x0000B8A9
		public override XmlText CreateTextNode(string text)
		{
			return new ConfigXmlDocument.ConfigXmlText(this, text);
		}

		/// <summary>Creates white space.</summary>
		/// <returns>The <see cref="T:System.Xml.XmlWhitespace" /> value.</returns>
		/// <param name="data">The data to use.</param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x0600107A RID: 4218 RVA: 0x0000D6B2 File Offset: 0x0000B8B2
		public override XmlWhitespace CreateWhitespace(string data)
		{
			return base.CreateWhitespace(data);
		}

		/// <summary>Loads the configuration file.</summary>
		/// <param name="filename">The name of the file.</param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x0600107B RID: 4219 RVA: 0x0003A540 File Offset: 0x00038740
		public override void Load(string filename)
		{
			XmlTextReader xmlTextReader = new XmlTextReader(filename);
			try
			{
				xmlTextReader.MoveToContent();
				this.LoadSingleElement(filename, xmlTextReader);
			}
			finally
			{
				xmlTextReader.Close();
			}
		}

		/// <summary>Loads a single configuration element.</summary>
		/// <param name="filename">The name of the file.</param>
		/// <param name="sourceReader">The source for the reader.</param>
		/// <filterpriority>2</filterpriority>
		// Token: 0x0600107C RID: 4220 RVA: 0x0003A580 File Offset: 0x00038780
		public void LoadSingleElement(string filename, XmlTextReader sourceReader)
		{
			this.fileName = filename;
			this.lineNumber = sourceReader.LineNumber;
			string text = sourceReader.ReadOuterXml();
			this.reader = new XmlTextReader(new StringReader(text), sourceReader.NameTable);
			this.Load(this.reader);
			this.reader.Close();
		}

		/// <summary>Gets the configuration file name.</summary>
		/// <returns>The configuration file name.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x0000D6BB File Offset: 0x0000B8BB
		public string Filename
		{
			get
			{
				if (this.fileName != null && this.fileName.Length > 0 && SecurityManager.SecurityEnabled)
				{
					new FileIOPermission(FileIOPermissionAccess.PathDiscovery, this.fileName).Demand();
				}
				return this.fileName;
			}
		}

		/// <summary>Gets the current node line number.</summary>
		/// <returns>The line number for the current node.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x0000D6FA File Offset: 0x0000B8FA
		public int LineNumber
		{
			get
			{
				return this.lineNumber;
			}
		}

		// Token: 0x040004A8 RID: 1192
		private XmlTextReader reader;

		// Token: 0x040004A9 RID: 1193
		private string fileName;

		// Token: 0x040004AA RID: 1194
		private int lineNumber;

		// Token: 0x020001DA RID: 474
		private class ConfigXmlAttribute : XmlAttribute, IConfigErrorInfo, IConfigXmlNode
		{
			// Token: 0x0600107F RID: 4223 RVA: 0x0000D702 File Offset: 0x0000B902
			public ConfigXmlAttribute(ConfigXmlDocument document, string prefix, string localName, string namespaceUri)
				: base(prefix, localName, namespaceUri, document)
			{
				this.fileName = document.fileName;
				this.lineNumber = document.LineNumber;
			}

			// Token: 0x170003A8 RID: 936
			// (get) Token: 0x06001080 RID: 4224 RVA: 0x0000D727 File Offset: 0x0000B927
			public string Filename
			{
				get
				{
					if (this.fileName != null && this.fileName.Length > 0 && SecurityManager.SecurityEnabled)
					{
						new FileIOPermission(FileIOPermissionAccess.PathDiscovery, this.fileName).Demand();
					}
					return this.fileName;
				}
			}

			// Token: 0x170003A9 RID: 937
			// (get) Token: 0x06001081 RID: 4225 RVA: 0x0000D766 File Offset: 0x0000B966
			public int LineNumber
			{
				get
				{
					return this.lineNumber;
				}
			}

			// Token: 0x040004AB RID: 1195
			private string fileName;

			// Token: 0x040004AC RID: 1196
			private int lineNumber;
		}

		// Token: 0x020001DB RID: 475
		private class ConfigXmlCDataSection : XmlCDataSection, IConfigErrorInfo, IConfigXmlNode
		{
			// Token: 0x06001082 RID: 4226 RVA: 0x0000D76E File Offset: 0x0000B96E
			public ConfigXmlCDataSection(ConfigXmlDocument document, string data)
				: base(data, document)
			{
				this.fileName = document.fileName;
				this.lineNumber = document.LineNumber;
			}

			// Token: 0x170003AA RID: 938
			// (get) Token: 0x06001083 RID: 4227 RVA: 0x0000D790 File Offset: 0x0000B990
			public string Filename
			{
				get
				{
					if (this.fileName != null && this.fileName.Length > 0 && SecurityManager.SecurityEnabled)
					{
						new FileIOPermission(FileIOPermissionAccess.PathDiscovery, this.fileName).Demand();
					}
					return this.fileName;
				}
			}

			// Token: 0x170003AB RID: 939
			// (get) Token: 0x06001084 RID: 4228 RVA: 0x0000D7CF File Offset: 0x0000B9CF
			public int LineNumber
			{
				get
				{
					return this.lineNumber;
				}
			}

			// Token: 0x040004AD RID: 1197
			private string fileName;

			// Token: 0x040004AE RID: 1198
			private int lineNumber;
		}

		// Token: 0x020001DC RID: 476
		private class ConfigXmlComment : XmlComment, IConfigXmlNode
		{
			// Token: 0x06001085 RID: 4229 RVA: 0x0000D7D7 File Offset: 0x0000B9D7
			public ConfigXmlComment(ConfigXmlDocument document, string comment)
				: base(comment, document)
			{
				this.fileName = document.fileName;
				this.lineNumber = document.LineNumber;
			}

			// Token: 0x170003AC RID: 940
			// (get) Token: 0x06001086 RID: 4230 RVA: 0x0000D7F9 File Offset: 0x0000B9F9
			public string Filename
			{
				get
				{
					if (this.fileName != null && this.fileName.Length > 0 && SecurityManager.SecurityEnabled)
					{
						new FileIOPermission(FileIOPermissionAccess.PathDiscovery, this.fileName).Demand();
					}
					return this.fileName;
				}
			}

			// Token: 0x170003AD RID: 941
			// (get) Token: 0x06001087 RID: 4231 RVA: 0x0000D838 File Offset: 0x0000BA38
			public int LineNumber
			{
				get
				{
					return this.lineNumber;
				}
			}

			// Token: 0x040004AF RID: 1199
			private string fileName;

			// Token: 0x040004B0 RID: 1200
			private int lineNumber;
		}

		// Token: 0x020001DD RID: 477
		private class ConfigXmlElement : XmlElement, IConfigErrorInfo, IConfigXmlNode
		{
			// Token: 0x06001088 RID: 4232 RVA: 0x0000D840 File Offset: 0x0000BA40
			public ConfigXmlElement(ConfigXmlDocument document, string prefix, string localName, string namespaceUri)
				: base(prefix, localName, namespaceUri, document)
			{
				this.fileName = document.fileName;
				this.lineNumber = document.LineNumber;
			}

			// Token: 0x170003AE RID: 942
			// (get) Token: 0x06001089 RID: 4233 RVA: 0x0000D865 File Offset: 0x0000BA65
			public string Filename
			{
				get
				{
					if (this.fileName != null && this.fileName.Length > 0 && SecurityManager.SecurityEnabled)
					{
						new FileIOPermission(FileIOPermissionAccess.PathDiscovery, this.fileName).Demand();
					}
					return this.fileName;
				}
			}

			// Token: 0x170003AF RID: 943
			// (get) Token: 0x0600108A RID: 4234 RVA: 0x0000D8A4 File Offset: 0x0000BAA4
			public int LineNumber
			{
				get
				{
					return this.lineNumber;
				}
			}

			// Token: 0x040004B1 RID: 1201
			private string fileName;

			// Token: 0x040004B2 RID: 1202
			private int lineNumber;
		}

		// Token: 0x020001DE RID: 478
		private class ConfigXmlText : XmlText, IConfigErrorInfo, IConfigXmlNode
		{
			// Token: 0x0600108B RID: 4235 RVA: 0x0000D8AC File Offset: 0x0000BAAC
			public ConfigXmlText(ConfigXmlDocument document, string data)
				: base(data, document)
			{
				this.fileName = document.fileName;
				this.lineNumber = document.LineNumber;
			}

			// Token: 0x170003B0 RID: 944
			// (get) Token: 0x0600108C RID: 4236 RVA: 0x0000D8CE File Offset: 0x0000BACE
			public string Filename
			{
				get
				{
					if (this.fileName != null && this.fileName.Length > 0 && SecurityManager.SecurityEnabled)
					{
						new FileIOPermission(FileIOPermissionAccess.PathDiscovery, this.fileName).Demand();
					}
					return this.fileName;
				}
			}

			// Token: 0x170003B1 RID: 945
			// (get) Token: 0x0600108D RID: 4237 RVA: 0x0000D90D File Offset: 0x0000BB0D
			public int LineNumber
			{
				get
				{
					return this.lineNumber;
				}
			}

			// Token: 0x040004B3 RID: 1203
			private string fileName;

			// Token: 0x040004B4 RID: 1204
			private int lineNumber;
		}
	}
}
