using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("shop")]
public class Shop : BasePojo
{
	[XmlAttribute("name")]
	public string Name;

	[XmlAttribute]
	public string pic;

	[XmlAttribute]
	public string music;

	private string _202E_202A_206F_202D_200D_200C_200B_200B_200E_206B_200D_206E_206F_202A_206D_200E_202C_202C_200B_202D_206F_202E_200B_202D_202D_206A_202D_206C_202A_202E_200F_200F_206C_202A_206F_202E_200B_206C_200F_206C_202E = string.Empty;

	[XmlElement("sale")]
	public List<ShopSale> Sales = new List<ShopSale>();

	public override string PK => Name;

	[XmlAttribute]
	public string key
	{
		get
		{
			if (_200E_206D_206E_200B_200C_206C_200F_206A_202B_202D_206E_202B_202B_206F_200C_206A_206B_202A_202D_202C_200D_200F_206A_206B_200F_206C_202E_200D_202A_200D_206C_200D_202A_200E_200E_202A_206E_200E_202B_206B_202E(_202E_202A_206F_202D_200D_200C_200B_200B_200E_206B_200D_206E_206F_202A_206D_200E_202C_202C_200B_202D_206F_202E_200B_202D_202D_206A_202D_206C_202A_202E_200F_200F_206C_202A_206F_202E_200B_206C_200F_206C_202E))
			{
				while (true)
				{
					uint num;
					switch ((num = 1425340675u) % 3)
					{
					case 0u:
						continue;
					case 1u:
						return Name;
					}
					break;
				}
			}
			return _202E_202A_206F_202D_200D_200C_200B_200B_200E_206B_200D_206E_206F_202A_206D_200E_202C_202C_200B_202D_206F_202E_200B_202D_202D_206A_202D_206C_202A_202E_200F_200F_206C_202A_206F_202E_200B_206C_200F_206C_202E;
		}
		set
		{
			_202E_202A_206F_202D_200D_200C_200B_200B_200E_206B_200D_206E_206F_202A_206D_200E_202C_202C_200B_202D_206F_202E_200B_202D_202D_206A_202D_206C_202A_202E_200F_200F_206C_202A_206F_202E_200B_206C_200F_206C_202E = value;
		}
	}

	public Dictionary<ItemInstance, int> GetAvaliableSales()
	{
		Dictionary<ItemInstance, int> dictionary = new Dictionary<ItemInstance, int>();
		using (List<ShopSale>.Enumerator enumerator = Sales.GetEnumerator())
		{
			int num7 = default(int);
			string text = default(string);
			ItemInstance itemInstance = default(ItemInstance);
			ShopSale current = default(ShopSale);
			Item item = default(Item);
			while (true)
			{
				IL_01f7:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 1136796941;
					num2 = num;
				}
				else
				{
					num = 1196252057;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x7FA64BBA)) % 17)
					{
					case 0u:
						num = 1196252057;
						continue;
					default:
						goto end_IL_001c;
					case 16u:
						num7 = int.Parse(RuntimeData.Instance.KeyValues[text]);
						num = ((int)num3 * -1528564241) ^ -1237505000;
						continue;
					case 9u:
						dictionary.Add(itemInstance, -1);
						num = 145490082;
						continue;
					case 5u:
						text = _206E_206E_202A_202E_200D_200C_206A_206C_206A_206B_206E_206F_206F_202E_206E_206A_200F_206D_202D_202D_206B_200D_206F_206B_202B_200B_206C_202D_200E_206E_202D_202D_206B_200C_200D_206E_206E_206D_200E_202E_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4291010201u), key, current.name);
						num = ((int)num3 * -1184817714) ^ 0x49931CF1;
						continue;
					case 10u:
					{
						itemInstance = new ItemInstance();
						itemInstance.SetItem(item);
						itemInstance.Name = item.Name;
						int num10;
						int num11;
						if (current.limit == -1)
						{
							num10 = -1330845957;
							num11 = num10;
						}
						else
						{
							num10 = -1119112685;
							num11 = num10;
						}
						num = num10 ^ ((int)num3 * -300261540);
						continue;
					}
					case 2u:
						current = enumerator.Current;
						num = 1125784389;
						continue;
					case 4u:
					{
						int num6;
						if (item != null)
						{
							num = 1903410274;
							num6 = num;
						}
						else
						{
							num = 145490082;
							num6 = num;
						}
						continue;
					}
					case 12u:
						item = Item.GetItem(current.name);
						num = (int)((num3 * 1907675682) ^ 0x309DBDAA);
						continue;
					case 15u:
					{
						int num12;
						if (num7 < current.limit)
						{
							num = 1374955421;
							num12 = num;
						}
						else
						{
							num = 145490082;
							num12 = num;
						}
						continue;
					}
					case 6u:
					{
						int num8;
						int num9;
						if (!RuntimeData.Instance.KeyValues.ContainsKey(text))
						{
							num8 = 19935789;
							num9 = num8;
						}
						else
						{
							num8 = 365775891;
							num9 = num8;
						}
						num = num8 ^ (int)(num3 * 2046434853);
						continue;
					}
					case 13u:
						num7 = 0;
						num = (int)(num3 * 3298445) ^ -995639644;
						continue;
					case 3u:
						dictionary.Add(itemInstance, current.limit - num7);
						num = (int)(num3 * 966388281) ^ -1085878083;
						continue;
					case 7u:
						break;
					case 14u:
					{
						int num4;
						int num5;
						if (item != null)
						{
							num4 = -1565254130;
							num5 = num4;
						}
						else
						{
							num4 = -1669750910;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 380371538);
						continue;
					}
					case 8u:
						item = Item.GetCanzhang(current.name);
						num = ((int)num3 * -1572534301) ^ -37206905;
						continue;
					case 1u:
						num = (int)(num3 * 836711183) ^ -1069125510;
						continue;
					case 11u:
						goto end_IL_001c;
					}
					goto IL_01f7;
					continue;
					end_IL_001c:
					break;
				}
				break;
			}
		}
		return dictionary;
	}

	public ShopSale GetSale(ItemInstance item)
	{
		List<ShopSale>.Enumerator enumerator = Sales.GetEnumerator();
		try
		{
			ShopSale current = default(ShopSale);
			while (true)
			{
				IL_008a:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -723308965;
					num2 = num;
				}
				else
				{
					num = -842033855;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1749110258)) % 6)
					{
					case 0u:
						num = -842033855;
						continue;
					default:
						goto end_IL_0013;
					case 4u:
						return current;
					case 2u:
					{
						int num4;
						int num5;
						if (_200E_200F_200C_200E_206B_200C_206A_200E_206B_206E_202D_202A_200D_200D_202D_200D_206D_206A_200C_200F_206F_202D_202E_202B_200F_206F_206A_206A_200B_206B_200D_206C_200E_202A_202C_206A_200F_206C_202B_206F_202E(item.Name, current.name))
						{
							num4 = -467249126;
							num5 = num4;
						}
						else
						{
							num4 = -930706191;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -1258762714);
						continue;
					}
					case 3u:
						current = enumerator.Current;
						num = -2117530188;
						continue;
					case 1u:
						break;
					case 5u:
						goto end_IL_0013;
					}
					goto IL_008a;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		finally
		{
			_206D_200E_206C_202B_202D_200B_206E_206A_206A_200C_202A_200E_202C_200F_206E_206B_202E_202D_200E_202D_206A_202A_200D_200C_206B_206D_206E_200B_200E_206F_206C_206F_202A_206F_202E_202C_200E_200E_200E_206B_202E((IDisposable)enumerator);
		}
		return null;
	}

	public void BuyItem(string itemName, int count = 1)
	{
		string text = _206E_206E_202A_202E_200D_200C_206A_206C_206A_206B_206E_206F_206F_202E_206E_206A_200F_206D_202D_202D_206B_200D_206F_206B_202B_200B_206C_202D_200E_206E_202D_202D_206B_200C_200D_206E_206E_206D_200E_202E_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4245209806u), key, itemName);
		int num3 = default(int);
		while (true)
		{
			int num = -588364221;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1652559325)) % 7)
				{
				case 3u:
					break;
				default:
					return;
				case 2u:
				{
					int num4;
					int num5;
					if (!RuntimeData.Instance.KeyValues.ContainsKey(text))
					{
						num4 = 107767850;
						num5 = num4;
					}
					else
					{
						num4 = 349464441;
						num5 = num4;
					}
					num = num4 ^ ((int)num2 * -1955152738);
					continue;
				}
				case 0u:
					RuntimeData.Instance.KeyValues[text] = count.ToString();
					num = -2126470983;
					continue;
				case 4u:
					num3 = int.Parse(RuntimeData.Instance.KeyValues[text]);
					num = (int)(num2 * 711509345) ^ -379683354;
					continue;
				case 1u:
					num = (int)((num2 * 1522509013) ^ 0x1ACFF923);
					continue;
				case 5u:
					num3 += count;
					RuntimeData.Instance.KeyValues[text] = num3.ToString();
					num = (int)(num2 * 634652302) ^ -1743252189;
					continue;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	static bool _200E_206D_206E_200B_200C_206C_200F_206A_202B_202D_206E_202B_202B_206F_200C_206A_206B_202A_202D_202C_200D_200F_206A_206B_200F_206C_202E_200D_202A_200D_206C_200D_202A_200E_200E_202A_206E_200E_202B_206B_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static string _206E_206E_202A_202E_200D_200C_206A_206C_206A_206B_206E_206F_206F_202E_206E_206A_200F_206D_202D_202D_206B_200D_206F_206B_202B_200B_206C_202D_200E_206E_202D_202D_206B_200C_200D_206E_206E_206D_200E_202E_202E(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}

	static bool _200E_200F_200C_200E_206B_200C_206A_200E_206B_206E_202D_202A_200D_200D_202D_200D_206D_206A_200C_200F_206F_202D_202E_202B_200F_206F_206A_206A_200B_206B_200D_206C_200E_202A_202C_206A_200F_206C_202B_206F_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static void _206D_200E_206C_202B_202D_200B_206E_206A_206A_200C_202A_200E_202C_200F_206E_206B_202E_202D_200E_202D_206A_202A_200D_200C_206B_206D_206E_200B_200E_206F_206C_206F_202A_206F_202E_202C_200E_200E_200E_206B_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}
}
