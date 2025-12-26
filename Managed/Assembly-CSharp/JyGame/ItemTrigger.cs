using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("item_trigger")]
public class ItemTrigger : BasePojo
{
	private string _206E_200B_202E_200B_200C_202A_206B_206F_202A_206A_202C_202A_206E_206B_206B_202A_202E_206D_206C_200D_202B_206F_206A_202C_206C_206D_202A_202A_202B_200F_206B_202C_206E_206D_206C_200C_206E_206D_202E_202C_202E;

	[XmlAttribute("name")]
	public string Name;

	[XmlAttribute("minlevel")]
	public int MinLevel = -1;

	[XmlAttribute("maxlevel")]
	public int MaxLevel = -1;

	[XmlElement("trigger")]
	public List<ITTrigger> Triggers;

	public override string PK => _206E_200B_202E_200B_200C_202A_206B_206F_202A_206A_202C_202A_206E_206B_206B_202A_202E_206D_206C_200D_202B_206F_206A_202C_206C_206D_202A_202A_202B_200F_206B_202C_206E_206D_206C_200C_206E_206D_202E_202C_202E;

	public ItemTrigger()
	{
		while (true)
		{
			int num = 693016807;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x516E9BC7)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0036;
				case 0u:
					return;
				}
				break;
				IL_0036:
				_206E_200B_202E_200B_200C_202A_206B_206F_202A_206A_202C_202A_206E_206B_206B_202A_202E_206D_206C_200D_202B_206F_206A_202C_206C_206D_202A_202A_202B_200F_206B_202C_206E_206D_206C_200C_206E_206D_202E_202C_202E = Guid.NewGuid().ToString();
				num = ((int)num2 * -1584846586) ^ -374305115;
			}
		}
	}
}
