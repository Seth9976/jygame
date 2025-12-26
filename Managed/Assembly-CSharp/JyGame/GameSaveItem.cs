using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("item")]
public class GameSaveItem
{
	[XmlAttribute("n")]
	public string name;

	[XmlElement("t")]
	public Trigger[] triggers;

	[XmlAttribute("c")]
	public int count;

	public ItemInstance Generate()
	{
		ItemInstance itemInstance = new ItemInstance();
		Item item = Item.GetItem(name);
		if (item == null)
		{
			goto IL_0018;
		}
		goto IL_00bd;
		IL_0018:
		int num = 1386203884;
		goto IL_001d;
		IL_001d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x2FA2A8F0)) % 7)
			{
			case 6u:
				break;
			case 2u:
				return null;
			case 3u:
				itemInstance.AdditionTriggers = new List<Trigger>();
				num = ((int)num2 * -1228183387) ^ -746873492;
				continue;
			case 1u:
				num = ((int)num2 * -424537077) ^ -2117668985;
				continue;
			case 0u:
				itemInstance.AdditionTriggers = ((triggers != null && triggers.Length < 21) ? triggers.ToList() : new List<Trigger>());
				num = 803794218;
				continue;
			case 4u:
				goto IL_00bd;
			default:
				itemInstance.InitBind();
				return itemInstance;
			}
			break;
		}
		goto IL_0018;
		IL_00bd:
		itemInstance.SetItem(item);
		itemInstance.Name = name;
		int num3;
		if (item.type == 12)
		{
			num = 1424625455;
			num3 = num;
		}
		else
		{
			num = 132836223;
			num3 = num;
		}
		goto IL_001d;
	}

	public ItemInstance GenerateCanzhang()
	{
		ItemInstance itemInstance = new ItemInstance();
		Item canzhang = Item.GetCanzhang(name);
		while (true)
		{
			int num = -1636261004;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -81038115)) % 7)
				{
				case 3u:
					break;
				case 4u:
					itemInstance.InitBind();
					num = ((int)num2 * -1373113949) ^ 0x371624FF;
					continue;
				case 5u:
					itemInstance.SetItem(canzhang);
					num = -1577465722;
					continue;
				case 2u:
					itemInstance.Name = name;
					num = ((int)num2 * -1294211843) ^ 0x4A439DC5;
					continue;
				case 6u:
					return null;
				case 1u:
				{
					int num3;
					int num4;
					if (canzhang == null)
					{
						num3 = -1417442165;
						num4 = num3;
					}
					else
					{
						num3 = -647490503;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1397651977);
					continue;
				}
				default:
					return itemInstance;
				}
				break;
			}
		}
	}

	public ItemInstance Generate2()
	{
		ItemInstance itemInstance = new ItemInstance();
		Item item = Item.GetItem(name);
		while (true)
		{
			int num = 701524377;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x658572D0)) % 10)
				{
				case 9u:
					break;
				case 7u:
					itemInstance.SetItem(item);
					num = 1485858552;
					continue;
				case 3u:
					itemInstance.AdditionTriggers = new List<Trigger>();
					num = 1111435368;
					continue;
				case 2u:
				{
					itemInstance.Name = name;
					int num8;
					int num9;
					if (item.type != 12)
					{
						num8 = 5741876;
						num9 = num8;
					}
					else
					{
						num8 = 1216132697;
						num9 = num8;
					}
					num = num8 ^ ((int)num2 * -1716288040);
					continue;
				}
				case 8u:
				{
					int num5;
					int num6;
					if (triggers == null)
					{
						num5 = 1957806657;
						num6 = num5;
					}
					else
					{
						num5 = 1315412888;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 576222278);
					continue;
				}
				case 5u:
				{
					int number = _206C_202E_206C_206B_202C_200B_206B_200F_200D_206C_200E_206B_202B_200B_206C_206F_200F_206F_202C_200C_202D_206A_206A_202C_200E_206D_206F_202D_200C_206C_202C_202D_206D_200F_202C_200D_206D_206F_200B_202A_202E(20, triggers.Length);
					itemInstance.AddRandomTriggers(number);
					num = ((int)num2 * -875871722) ^ 0x246D6CEE;
					continue;
				}
				case 0u:
					return null;
				case 6u:
				{
					int num7;
					if (triggers != null)
					{
						num = 456770681;
						num7 = num;
					}
					else
					{
						num = 1111435368;
						num7 = num;
					}
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (item == null)
					{
						num3 = 1231303159;
						num4 = num3;
					}
					else
					{
						num3 = 443231874;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 853450061);
					continue;
				}
				default:
					itemInstance.InitBind();
					return itemInstance;
				}
				break;
			}
		}
	}

	static int _206C_202E_206C_206B_202C_200B_206B_200F_200D_206C_200E_206B_202B_200B_206C_206F_200F_206F_202C_200C_202D_206A_206A_202C_200E_206D_206F_202D_200C_206C_202C_202D_206D_200F_202C_200D_206D_206F_200B_202A_202E(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}
}
