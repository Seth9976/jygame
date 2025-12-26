using System;
using System.Collections;
using System.Collections.Specialized;
using System.Xml;

namespace System.Configuration
{
	// Token: 0x020001D0 RID: 464
	internal class ConfigHelper
	{
		// Token: 0x0600102B RID: 4139 RVA: 0x00039388 File Offset: 0x00037588
		internal static IDictionary GetDictionary(IDictionary prev, XmlNode region, string nameAtt, string valueAtt)
		{
			Hashtable hashtable;
			if (prev == null)
			{
				hashtable = new Hashtable(CaseInsensitiveHashCodeProvider.Default, CaseInsensitiveComparer.Default);
			}
			else
			{
				Hashtable hashtable2 = (Hashtable)prev;
				hashtable = (Hashtable)hashtable2.Clone();
			}
			ConfigHelper.CollectionWrapper collectionWrapper = new ConfigHelper.CollectionWrapper(hashtable);
			collectionWrapper = ConfigHelper.GoGetThem(collectionWrapper, region, nameAtt, valueAtt);
			if (collectionWrapper == null)
			{
				return null;
			}
			return collectionWrapper.UnWrap() as IDictionary;
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x000393E8 File Offset: 0x000375E8
		internal static ConfigNameValueCollection GetNameValueCollection(global::System.Collections.Specialized.NameValueCollection prev, XmlNode region, string nameAtt, string valueAtt)
		{
			ConfigNameValueCollection configNameValueCollection = new ConfigNameValueCollection(CaseInsensitiveHashCodeProvider.Default, CaseInsensitiveComparer.Default);
			if (prev != null)
			{
				configNameValueCollection.Add(prev);
			}
			ConfigHelper.CollectionWrapper collectionWrapper = new ConfigHelper.CollectionWrapper(configNameValueCollection);
			collectionWrapper = ConfigHelper.GoGetThem(collectionWrapper, region, nameAtt, valueAtt);
			if (collectionWrapper == null)
			{
				return null;
			}
			return collectionWrapper.UnWrap() as ConfigNameValueCollection;
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00039438 File Offset: 0x00037638
		private static ConfigHelper.CollectionWrapper GoGetThem(ConfigHelper.CollectionWrapper result, XmlNode region, string nameAtt, string valueAtt)
		{
			if (region.Attributes != null && region.Attributes.Count != 0 && (region.Attributes.Count != 1 || region.Attributes[0].Name != "xmlns"))
			{
				throw new ConfigurationException("Unknown attribute", region);
			}
			XmlNodeList childNodes = region.ChildNodes;
			foreach (object obj in childNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				XmlNodeType nodeType = xmlNode.NodeType;
				if (nodeType != XmlNodeType.Whitespace && nodeType != XmlNodeType.Comment)
				{
					if (nodeType != XmlNodeType.Element)
					{
						throw new ConfigurationException("Only XmlElement allowed", xmlNode);
					}
					string name = xmlNode.Name;
					if (name == "clear")
					{
						if (xmlNode.Attributes != null && xmlNode.Attributes.Count != 0)
						{
							throw new ConfigurationException("Unknown attribute", xmlNode);
						}
						result.Clear();
					}
					else if (name == "remove")
					{
						XmlNode xmlNode2 = null;
						if (xmlNode.Attributes != null)
						{
							xmlNode2 = xmlNode.Attributes.RemoveNamedItem(nameAtt);
						}
						if (xmlNode2 == null)
						{
							throw new ConfigurationException("Required attribute not found", xmlNode);
						}
						if (xmlNode2.Value == string.Empty)
						{
							throw new ConfigurationException("Required attribute is empty", xmlNode);
						}
						if (xmlNode.Attributes.Count != 0)
						{
							throw new ConfigurationException("Unknown attribute", xmlNode);
						}
						result.Remove(xmlNode2.Value);
					}
					else
					{
						if (!(name == "add"))
						{
							throw new ConfigurationException("Unknown element", xmlNode);
						}
						XmlNode xmlNode2 = null;
						if (xmlNode.Attributes != null)
						{
							xmlNode2 = xmlNode.Attributes.RemoveNamedItem(nameAtt);
						}
						if (xmlNode2 == null)
						{
							throw new ConfigurationException("Required attribute not found", xmlNode);
						}
						if (xmlNode2.Value == string.Empty)
						{
							throw new ConfigurationException("Required attribute is empty", xmlNode);
						}
						XmlNode xmlNode3 = xmlNode.Attributes.RemoveNamedItem(valueAtt);
						if (xmlNode3 == null)
						{
							throw new ConfigurationException("Required attribute not found", xmlNode);
						}
						if (xmlNode.Attributes.Count != 0)
						{
							throw new ConfigurationException("Unknown attribute", xmlNode);
						}
						result[xmlNode2.Value] = xmlNode3.Value;
					}
				}
			}
			return result;
		}

		// Token: 0x020001D1 RID: 465
		private class CollectionWrapper
		{
			// Token: 0x0600102E RID: 4142 RVA: 0x0000D2F4 File Offset: 0x0000B4F4
			public CollectionWrapper(IDictionary dict)
			{
				this.dict = dict;
				this.isDict = true;
			}

			// Token: 0x0600102F RID: 4143 RVA: 0x0000D30A File Offset: 0x0000B50A
			public CollectionWrapper(global::System.Collections.Specialized.NameValueCollection collection)
			{
				this.collection = collection;
				this.isDict = false;
			}

			// Token: 0x06001030 RID: 4144 RVA: 0x0000D320 File Offset: 0x0000B520
			public void Remove(string s)
			{
				if (this.isDict)
				{
					this.dict.Remove(s);
				}
				else
				{
					this.collection.Remove(s);
				}
			}

			// Token: 0x06001031 RID: 4145 RVA: 0x0000D34A File Offset: 0x0000B54A
			public void Clear()
			{
				if (this.isDict)
				{
					this.dict.Clear();
				}
				else
				{
					this.collection.Clear();
				}
			}

			// Token: 0x1700039A RID: 922
			public string this[string key]
			{
				set
				{
					if (this.isDict)
					{
						this.dict[key] = value;
					}
					else
					{
						this.collection[key] = value;
					}
				}
			}

			// Token: 0x06001033 RID: 4147 RVA: 0x0000D39E File Offset: 0x0000B59E
			public object UnWrap()
			{
				if (this.isDict)
				{
					return this.dict;
				}
				return this.collection;
			}

			// Token: 0x0400048C RID: 1164
			private IDictionary dict;

			// Token: 0x0400048D RID: 1165
			private global::System.Collections.Specialized.NameValueCollection collection;

			// Token: 0x0400048E RID: 1166
			private bool isDict;
		}
	}
}
