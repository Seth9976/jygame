using System;
using System.Configuration;
using System.Xml;

namespace System.Net.Configuration
{
	// Token: 0x020002DD RID: 733
	internal class HandlersUtil
	{
		// Token: 0x060018FD RID: 6397 RVA: 0x000021C3 File Offset: 0x000003C3
		private HandlersUtil()
		{
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x000126D7 File Offset: 0x000108D7
		internal static string ExtractAttributeValue(string attKey, XmlNode node)
		{
			return HandlersUtil.ExtractAttributeValue(attKey, node, false);
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x0004BB18 File Offset: 0x00049D18
		internal static string ExtractAttributeValue(string attKey, XmlNode node, bool optional)
		{
			if (node.Attributes == null)
			{
				if (optional)
				{
					return null;
				}
				HandlersUtil.ThrowException("Required attribute not found: " + attKey, node);
			}
			XmlNode xmlNode = node.Attributes.RemoveNamedItem(attKey);
			if (xmlNode == null)
			{
				if (optional)
				{
					return null;
				}
				HandlersUtil.ThrowException("Required attribute not found: " + attKey, node);
			}
			string value = xmlNode.Value;
			if (value == string.Empty)
			{
				string text = ((!optional) ? "Required" : "Optional");
				HandlersUtil.ThrowException(text + " attribute is empty: " + attKey, node);
			}
			return value;
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x000126E1 File Offset: 0x000108E1
		internal static void ThrowException(string msg, XmlNode node)
		{
			if (node != null && node.Name != string.Empty)
			{
				msg = msg + " (node name: " + node.Name + ") ";
			}
			throw new global::System.Configuration.ConfigurationException(msg, node);
		}
	}
}
