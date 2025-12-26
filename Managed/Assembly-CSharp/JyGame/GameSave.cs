using System;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("gamesave")]
public class GameSave : BasePojo
{
	[XmlAttribute("name")]
	public string Name = global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(728548317u);

	[XmlAttribute("newbieTask")]
	public string NewbieTask = string.Empty;

	[XmlElement]
	public GameSaveRole[] Roles;

	[XmlElement]
	public GameSaveRole[] Follows;

	[XmlElement("i")]
	public GameSaveItem[] GameItems;

	[XmlElement]
	public GameSaveItem[] XiangziItems;

	[XmlElement]
	public GameSaveRole[] Temps;

	[XmlAttribute("information")]
	public string Information = string.Empty;

	[XmlElement("b")]
	public GameSaveKeyValues[] BattleKeyValues;

	[XmlElement("cz")]
	public GameSaveItem[] CanzhangItems;

	[XmlElement("k")]
	public GameSaveKeyValues[] KeyValues;

	public override string PK => Name;

	[XmlIgnore]
	public DateTime Time => GetTimeByValue(GetValueByKey(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2004836147u)));

	[XmlIgnore]
	public string GameMode
	{
		get
		{
			if (GetValueByKey(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3583266687u)) == null)
			{
				while (true)
				{
					uint num;
					switch ((num = 1875837868u) % 3)
					{
					case 2u:
						continue;
					case 1u:
						return global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3019957305u);
					}
					break;
				}
			}
			return GetValueByKey(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3583266687u));
		}
	}

	[XmlIgnore]
	public bool AutoSaveOnly
	{
		get
		{
			if (GetValueByKey(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2214503410u)) != null)
			{
				while (true)
				{
					uint num;
					switch ((num = 305552542u) % 3)
					{
					case 2u:
						continue;
					case 1u:
						return bool.Parse(GetValueByKey(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3385120205u)));
					}
					break;
				}
			}
			return false;
		}
	}

	[XmlIgnore]
	public int Round
	{
		get
		{
			if (GetValueByKey(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(355178724u)) == null)
			{
				while (true)
				{
					uint num;
					switch ((num = 347940247u) % 3)
					{
					case 0u:
						continue;
					case 1u:
						return 1;
					}
					break;
				}
			}
			return int.Parse(GetValueByKey(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2069282016u)));
		}
	}

	[XmlIgnore]
	public string Locate
	{
		get
		{
			int num = -1;
			string valueByKey = default(string);
			int num4 = default(int);
			int num6 = default(int);
			while (true)
			{
				int num2 = -1300264617;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ -1965489602)) % 10)
					{
					case 8u:
						break;
					case 1u:
						valueByKey = GetValueByKey(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3129512498u));
						num4 = _202D_206A_206E_200C_206C_202B_206F_202E_202B_202A_202A_202B_200E_206D_200D_206E_206E_202C_200E_200C_206A_202A_202B_206C_202D_206B_206E_202D_200C_206E_200F_202B_206E_200F_206A_202A_202E_202E_200F_202A_202E(valueByKey) - 1;
						num2 = ((int)num3 * -890954568) ^ -426589183;
						continue;
					case 5u:
					{
						int num9;
						int num10;
						if (num6 < 48)
						{
							num9 = 201106335;
							num10 = num9;
						}
						else
						{
							num9 = 1005749416;
							num10 = num9;
						}
						num2 = num9 ^ ((int)num3 * -804202476);
						continue;
					}
					case 9u:
						num2 = (int)(num3 * 2022759850) ^ -2008619836;
						continue;
					case 0u:
						num6 = _206C_206A_200B_202C_202B_206A_206C_200D_206F_206B_202C_200C_206B_200F_206E_202E_200B_202A_200E_202A_206B_202C_206B_200D_200F_200C_200F_200D_202D_200E_202A_202E_202A_200C_202C_202D_202B_206E_202B_202A_202E(valueByKey, num4);
						num2 = -579864261;
						continue;
					case 6u:
						num4--;
						num2 = -1109339934;
						continue;
					case 4u:
					{
						int num7;
						int num8;
						if (num6 <= 57)
						{
							num7 = -959382244;
							num8 = num7;
						}
						else
						{
							num7 = -581932053;
							num8 = num7;
						}
						num2 = num7 ^ ((int)num3 * -2145123256);
						continue;
					}
					case 2u:
					{
						int num5;
						if (num4 < 0)
						{
							num2 = -1831780453;
							num5 = num2;
						}
						else
						{
							num2 = -994550380;
							num5 = num2;
						}
						continue;
					}
					case 7u:
						num = num4;
						num2 = -1831780453;
						continue;
					default:
						return _206C_202A_200F_206D_206D_202E_206C_200E_202C_206E_202B_200C_206B_200E_200D_202D_206E_200C_202E_206B_200D_202D_200C_202E_200E_202D_206C_206F_206B_202E_206D_206B_200D_202D_202A_206E_202C_202A_200D_202A_202E(valueByKey, 0, num + 1);
					}
					break;
				}
			}
		}
	}

	public override void InitBind()
	{
	}

	public string GetValueByKey(string key)
	{
		GameSaveKeyValues[] keyValues = KeyValues;
		int num = 0;
		GameSaveKeyValues gameSaveKeyValues = default(GameSaveKeyValues);
		while (true)
		{
			int num2 = -936421623;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1456386313)) % 8)
				{
				case 0u:
					break;
				case 6u:
					num2 = ((int)num3 * -2066503850) ^ 0x3B05456C;
					continue;
				case 3u:
					num++;
					num2 = -1670502344;
					continue;
				case 4u:
					return gameSaveKeyValues.value;
				case 7u:
				{
					int num6;
					if (num < keyValues.Length)
					{
						num2 = -1729686979;
						num6 = num2;
					}
					else
					{
						num2 = -1077802742;
						num6 = num2;
					}
					continue;
				}
				case 2u:
					gameSaveKeyValues = keyValues[num];
					num2 = -378833442;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (!_202D_206B_200C_200E_200E_202B_202C_200F_206B_206D_202E_202B_200D_202B_206A_200C_206C_202E_206D_200C_200E_202E_202B_202A_206C_200B_206F_206D_206D_206E_206C_200D_200C_206D_202D_200B_202B_206B_202A_200C_202E(gameSaveKeyValues.key, key))
					{
						num4 = 1720006424;
						num5 = num4;
					}
					else
					{
						num4 = 975286767;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -1696611036);
					continue;
				}
				default:
					return null;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		string text = CommonSettings.DateToGameTime(Time);
		if (AutoSaveOnly)
		{
			goto IL_0017;
		}
		goto IL_0126;
		IL_0017:
		int num = -847228809;
		goto IL_001c;
		IL_001c:
		string text2 = default(string);
		string text3 = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1843943453)) % 11)
			{
			case 4u:
				break;
			case 10u:
				text2 = ResourceStrings.ResStrings[587];
				num = (int)(num2 * 1589608977) ^ -115907712;
				continue;
			case 7u:
				num = (int)((num2 * 75432712) ^ 0x6CB57900);
				continue;
			case 5u:
				text2 = ResourceStrings.ResStrings[588];
				num = ((int)num2 * -2038860251) ^ -2026781459;
				continue;
			case 1u:
				goto IL_00ad;
			case 0u:
				text2 = ResourceStrings.ResStrings[589];
				num = -882388312;
				continue;
			case 6u:
				text2 = ResourceStrings.ResStrings[586];
				num = (int)((num2 * 162909418) ^ 0x72B1EFE0);
				continue;
			case 8u:
				num = ((int)num2 * -1678507204) ^ 0x36488248;
				continue;
			case 2u:
				goto IL_0126;
			case 9u:
				text3 = _206D_200E_202B_206F_200B_202B_202B_202D_206D_202B_202D_202A_200B_202B_200F_202B_206B_206C_200D_200B_200F_202A_206F_202C_200F_202C_202E_200F_202D_206D_206E_202A_206C_202C_206F_202C_200D_200B_206F_206C_202E(ResourceStrings.ResStrings[590], (object)Round);
				num = -1549408370;
				continue;
			default:
				return _200B_202A_202E_206B_202A_200D_206B_202C_206D_206D_206D_200D_202B_206B_202B_202D_206C_206F_206D_202B_200F_206C_200E_206A_206D_206E_206F_200D_206D_206A_206D_206E_200D_200D_202B_200C_200B_200D_202D_200D_202E(ResourceStrings.ResStrings[591], new object[8]
				{
					Roles[0].name,
					text,
					Locate,
					text2,
					text3,
					GetValueByKey(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(53294780u)),
					Roles.Length,
					global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3237049688u)
				});
			}
			break;
			IL_00ad:
			int num3;
			if (_202D_206B_200C_200E_200E_202B_202C_200F_206B_206D_202E_202B_200D_202B_206A_200C_206C_202E_206D_200C_200E_202E_202B_202A_206C_200B_206F_206D_206D_206E_206C_200D_200C_206D_202D_200B_202B_206B_202A_200C_202E(GameMode, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(574844096u)))
			{
				num = -1135361444;
				num3 = num;
			}
			else
			{
				num = -1166346366;
				num3 = num;
			}
		}
		goto IL_0017;
		IL_0126:
		int num4;
		if (_202D_206B_200C_200E_200E_202B_202C_200F_206B_206D_202E_202B_200D_202B_206A_200C_206C_202E_206D_200C_200E_202E_202B_202A_206C_200B_206F_206D_206D_206E_206C_200D_200C_206D_202D_200B_202B_206B_202A_200C_202E(GameMode, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2124360156u)))
		{
			num = -2119539816;
			num4 = num;
		}
		else
		{
			num = -1923729761;
			num4 = num;
		}
		goto IL_001c;
	}

	public static DateTime GetTimeByValue(string value)
	{
		if (_202D_206A_206E_200C_206C_202B_206F_202E_202B_202A_202A_202B_200E_206D_200D_206E_206E_202C_200E_200C_206A_202A_202B_206C_202D_206B_206E_202D_200C_206E_200F_202B_206E_200F_206A_202A_202E_202E_200F_202A_202E(value) > 12)
		{
			while (true)
			{
				uint num;
				switch ((num = 487421999u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return Tools.GetDateTime(-62135589600L);
				}
				break;
			}
		}
		return Tools.GetDateTime(long.Parse(value));
	}

	public static string ToString2(string[] array)
	{
		if (array.Length > 7)
		{
			DateTime dateTime = default(DateTime);
			int num6 = default(int);
			string text4 = default(string);
			string text2 = default(string);
			string text3 = default(string);
			string text = default(string);
			string text5 = default(string);
			int num5 = default(int);
			int num7 = default(int);
			while (true)
			{
				int num = 483097583;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x24FEC49)) % 27)
					{
					case 16u:
						break;
					case 1u:
						dateTime = Tools.GetDateTime(long.Parse(array[8]));
						num = (int)((num2 * 406086447) ^ 0x277C0AF3);
						continue;
					case 19u:
						goto IL_00b2;
					case 12u:
						num = (int)((num2 * 18763572) ^ 0x248FB5E7);
						continue;
					case 10u:
						num6 = -1;
						num = 1632109947;
						continue;
					case 25u:
						text4 = array[3].Substring(0, num6 + 1);
						num = 919253385;
						continue;
					case 4u:
						text2 = ResourceStrings.ResStrings[589];
						num = 487660115;
						continue;
					case 8u:
						goto IL_011e;
					case 17u:
						return string.Format(ResourceStrings.ResStrings[591], array[1], text3, text4, text2, text, array[6], array[7], text5);
					case 6u:
						text2 = ResourceStrings.ResStrings[586];
						num = (int)((num2 * 1126478380) ^ 0x60A7B443);
						continue;
					case 26u:
						num5--;
						num = 736922351;
						continue;
					case 5u:
						text3 = CommonSettings.DateToGameTime(GetTimeByValue(array[2]));
						num = (int)(num2 * 1033869089) ^ -922242691;
						continue;
					case 22u:
						text5 = dateTime.ToString(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1810115944u));
						num = (int)((num2 * 590381862) ^ 0x6806558);
						continue;
					case 18u:
					{
						int num10;
						int num11;
						if (array.Length <= 8)
						{
							num10 = -1071016512;
							num11 = num10;
						}
						else
						{
							num10 = -1346257073;
							num11 = num10;
						}
						num = num10 ^ (int)(num2 * 2016592678);
						continue;
					}
					case 11u:
						text5 = global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1874555673u);
						num = 683533391;
						continue;
					case 24u:
					{
						int num8;
						int num9;
						if (num7 <= 57)
						{
							num8 = 53451357;
							num9 = num8;
						}
						else
						{
							num8 = 1286911570;
							num9 = num8;
						}
						num = num8 ^ ((int)num2 * -1729169211);
						continue;
					}
					case 14u:
						num5 = array[3].Length - 1;
						num = ((int)num2 * -2060118419) ^ 0x322E1CA5;
						continue;
					case 9u:
						num6 = num5;
						num = 709895071;
						continue;
					case 13u:
						num = ((int)num2 * -582492676) ^ -952745557;
						continue;
					case 23u:
						text2 = ResourceStrings.ResStrings[588];
						num = ((int)num2 * -1182912082) ^ -1693628215;
						continue;
					case 3u:
					{
						int num3;
						int num4;
						if (_202D_206B_200C_200E_200E_202B_202C_200F_206B_206D_202E_202B_200D_202B_206A_200C_206C_202E_206D_200C_200E_202E_202B_202A_206C_200B_206F_206D_206D_206E_206C_200D_200C_206D_202D_200B_202B_206B_202A_200C_202E(array[4], global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2759614622u)))
						{
							num3 = 240097497;
							num4 = num3;
						}
						else
						{
							num3 = 1360864052;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 500296435);
						continue;
					}
					case 2u:
						text2 = ResourceStrings.ResStrings[587];
						num = (int)(num2 * 1341982078) ^ -1801896395;
						continue;
					case 7u:
						text = _206D_200E_202B_206F_200B_202B_202B_202D_206D_202B_202D_202A_200B_202B_200F_202B_206B_206C_200D_200B_200F_202A_206F_202C_200F_202C_202E_200F_202D_206D_206E_202A_206C_202C_206F_202C_200D_200B_206F_206C_202E(ResourceStrings.ResStrings[590], (object)array[5]);
						num = 1299698872;
						continue;
					case 21u:
						goto IL_0348;
					case 15u:
						goto IL_0370;
					case 0u:
						num = (int)((num2 * 489352639) ^ 0x69888CFC);
						continue;
					default:
						goto end_IL_0009;
					}
					break;
					IL_0370:
					num7 = array[3][num5];
					int num12;
					if (num7 >= 48)
					{
						num = 1290968542;
						num12 = num;
					}
					else
					{
						num = 746588001;
						num12 = num;
					}
					continue;
					IL_011e:
					int num13;
					if (!_202D_206B_200C_200E_200E_202B_202C_200F_206B_206D_202E_202B_200D_202B_206A_200C_206C_202E_206D_200C_200E_202E_202B_202A_206C_200B_206F_206D_206D_206E_206C_200D_200C_206D_202D_200B_202B_206B_202A_200C_202E(array[4], global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3441403404u)))
					{
						num = 1438362391;
						num13 = num;
					}
					else
					{
						num = 1391245874;
						num13 = num;
					}
					continue;
					IL_00b2:
					int num14;
					if (num5 < 0)
					{
						num = 203617439;
						num14 = num;
					}
					else
					{
						num = 659858118;
						num14 = num;
					}
					continue;
					IL_0348:
					int num15;
					if (_202D_206B_200C_200E_200E_202B_202C_200F_206B_206D_202E_202B_200D_202B_206A_200C_206C_202E_206D_200C_200E_202E_202B_202A_206C_200B_206F_206D_206D_206E_206C_200D_200C_206D_202D_200B_202B_206B_202A_200C_202E(array[4], global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2124360156u)))
					{
						num = 1956601284;
						num15 = num;
					}
					else
					{
						num = 1728444412;
						num15 = num;
					}
				}
				continue;
				end_IL_0009:
				break;
			}
		}
		return string.Empty;
	}

	static bool _202D_206B_200C_200E_200E_202B_202C_200F_206B_206D_202E_202B_200D_202B_206A_200C_206C_202E_206D_200C_200E_202E_202B_202A_206C_200B_206F_206D_206D_206E_206C_200D_200C_206D_202D_200B_202B_206B_202A_200C_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static int _202D_206A_206E_200C_206C_202B_206F_202E_202B_202A_202A_202B_200E_206D_200D_206E_206E_202C_200E_200C_206A_202A_202B_206C_202D_206B_206E_202D_200C_206E_200F_202B_206E_200F_206A_202A_202E_202E_200F_202A_202E(string P_0)
	{
		return P_0.Length;
	}

	static char _206C_206A_200B_202C_202B_206A_206C_200D_206F_206B_202C_200C_206B_200F_206E_202E_200B_202A_200E_202A_206B_202C_206B_200D_200F_200C_200F_200D_202D_200E_202A_202E_202A_200C_202C_202D_202B_206E_202B_202A_202E(string P_0, int P_1)
	{
		return P_0[P_1];
	}

	static string _206C_202A_200F_206D_206D_202E_206C_200E_202C_206E_202B_200C_206B_200E_200D_202D_206E_200C_202E_206B_200D_202D_200C_202E_200E_202D_206C_206F_206B_202E_206D_206B_200D_202D_202A_206E_202C_202A_200D_202A_202E(string P_0, int P_1, int P_2)
	{
		return P_0.Substring(P_1, P_2);
	}

	static string _206D_200E_202B_206F_200B_202B_202B_202D_206D_202B_202D_202A_200B_202B_200F_202B_206B_206C_200D_200B_200F_202A_206F_202C_200F_202C_202E_200F_202D_206D_206E_202A_206C_202C_206F_202C_200D_200B_206F_206C_202E(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}

	static string _200B_202A_202E_206B_202A_200D_206B_202C_206D_206D_206D_200D_202B_206B_202B_202D_206C_206F_206D_202B_200F_206C_200E_206A_206D_206E_206F_200D_206D_206A_206D_206E_200D_200D_202B_200C_200B_200D_202D_200D_202E(string P_0, object[] P_1)
	{
		return string.Format(P_0, P_1);
	}
}
