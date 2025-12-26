using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("item")]
public class Item : BasePojo
{
	[XmlAttribute("name")]
	public string Name;

	[XmlAttribute]
	public string desc;

	[XmlAttribute]
	public string pic;

	[XmlAttribute]
	public int type;

	[XmlAttribute]
	public int level;

	[XmlAttribute]
	public int price;

	[XmlAttribute]
	public bool drop;

	[XmlAttribute]
	public string talent = string.Empty;

	[XmlAttribute]
	public string CanzhangSkill;

	[XmlElement("require")]
	public List<Require> Requires = new List<Require>();

	[XmlElement("trigger")]
	public List<Trigger> Triggers = new List<Trigger>();

	[XmlAttribute("cd")]
	public int Cooldown;

	[XmlArrayItem(typeof(SkillInstance))]
	[XmlArray("skills")]
	public List<SkillInstance> Skills = new List<SkillInstance>();

	[XmlArrayItem(typeof(SpecialSkillInstance))]
	[XmlArray("special_skills")]
	public List<SpecialSkillInstance> SpecialSkills = new List<SpecialSkillInstance>();

	[XmlAttribute]
	public int round = 1000;

	[XmlAttribute("buff")]
	public string buff;

	[XmlAttribute]
	public string parameters = string.Empty;

	[XmlAttribute]
	public int box;

	public override string PK => Name;

	[XmlIgnore]
	public string[] Talents => _206B_200C_200F_206D_202D_202A_200B_200F_206F_202D_200F_200C_200D_202C_202C_206A_206B_202E_206B_202D_206A_202C_200B_206A_200E_206D_200C_202D_206F_200E_202D_202C_202C_202D_202A_206E_202A_206B_206C_200D_202E(talent, new char[1] { '#' }, StringSplitOptions.RemoveEmptyEntries);

	[XmlIgnore]
	public IEnumerable<Buff> Buffs
	{
		get
		{
			if (buff != null)
			{
				while (true)
				{
					int num = -1400208709;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -398558327)) % 7)
						{
						case 0u:
							break;
						case 5u:
							buff = null;
							num = ((int)num2 * -394291424) ^ 0x72999C75;
							continue;
						case 6u:
						{
							int num7;
							int num8;
							if (type != 2)
							{
								num7 = -1064265183;
								num8 = num7;
							}
							else
							{
								num7 = -646879759;
								num8 = num7;
							}
							num = num7 ^ (int)(num2 * 1247074970);
							continue;
						}
						case 1u:
						{
							int num5;
							int num6;
							if (type != 12)
							{
								num5 = 1027033250;
								num6 = num5;
							}
							else
							{
								num5 = 254919287;
								num6 = num5;
							}
							num = num5 ^ (int)(num2 * 1673495390);
							continue;
						}
						case 3u:
						{
							int num9;
							int num10;
							if (type != 3)
							{
								num9 = -943636366;
								num10 = num9;
							}
							else
							{
								num9 = -2056637295;
								num10 = num9;
							}
							num = num9 ^ (int)(num2 * 2039108283);
							continue;
						}
						case 4u:
						{
							int num3;
							int num4;
							if (type == 1)
							{
								num3 = -1185955425;
								num4 = num3;
							}
							else
							{
								num3 = -877477543;
								num4 = num3;
							}
							num = num3 ^ ((int)num2 * -1894780883);
							continue;
						}
						default:
							goto end_IL_000b;
						}
						break;
					}
					continue;
					end_IL_000b:
					break;
				}
			}
			return Buff.Parse(buff);
		}
	}

	public static Item GetItem(string name)
	{
		return ResourceManager.Get<Item>(name);
	}

	public ItemInstance Generate(bool setRandomTrigger)
	{
		ItemInstance itemInstance = new ItemInstance();
		while (true)
		{
			int num = 248054584;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4C032E34)) % 59)
				{
				case 10u:
					break;
				case 43u:
				{
					int num12;
					if (!Tools.ProbabilityTest(0.2))
					{
						num = 1424028191;
						num12 = num;
					}
					else
					{
						num = 1577253874;
						num12 = num;
					}
					continue;
				}
				case 5u:
					itemInstance.AddRandomTriggers(4);
					num = (int)(num2 * 1878800936) ^ -10185540;
					continue;
				case 27u:
				{
					itemInstance.Name = Name;
					int num21;
					int num22;
					if (!setRandomTrigger)
					{
						num21 = 1019641656;
						num22 = num21;
					}
					else
					{
						num21 = 335124598;
						num22 = num21;
					}
					num = num21 ^ ((int)num2 * -37126172);
					continue;
				}
				case 39u:
					itemInstance.AddRandomTriggers(1);
					num = 481951411;
					continue;
				case 45u:
				{
					int num26;
					if (Tools.ProbabilityTest(0.01))
					{
						num = 300692195;
						num26 = num;
					}
					else
					{
						num = 694148211;
						num26 = num;
					}
					continue;
				}
				case 23u:
					num = (int)((num2 * 82810468) ^ 0x7BF27508);
					continue;
				case 1u:
					itemInstance.AddRandomTriggers(3);
					num = (int)((num2 * 366750565) ^ 0xDD9A12);
					continue;
				case 29u:
				{
					int num15;
					if (!Tools.ProbabilityTest(0.05))
					{
						num = 797595622;
						num15 = num;
					}
					else
					{
						num = 421662088;
						num15 = num;
					}
					continue;
				}
				case 42u:
					num = (int)((num2 * 775229495) ^ 0x3B85B364);
					continue;
				case 31u:
				{
					int num6;
					if (Tools.ProbabilityTest(0.4))
					{
						num = 233061003;
						num6 = num;
					}
					else
					{
						num = 693102263;
						num6 = num;
					}
					continue;
				}
				case 28u:
					num = (int)((num2 * 106088687) ^ 0x3C80450A);
					continue;
				case 18u:
					itemInstance.AddRandomTriggers(16);
					num = ((int)num2 * -14201044) ^ 0x2F8EEB64;
					continue;
				case 35u:
				{
					int num24;
					if (Tools.ProbabilityTest(0.08))
					{
						num = 1969746273;
						num24 = num;
					}
					else
					{
						num = 606629713;
						num24 = num;
					}
					continue;
				}
				case 6u:
					itemInstance.SetItem(this);
					num = (int)(num2 * 1194773860) ^ -724369871;
					continue;
				case 53u:
				{
					int num19;
					if (CommonSettings.MOD_KEY() == 4)
					{
						num = 106085316;
						num19 = num;
					}
					else
					{
						num = 1020597109;
						num19 = num;
					}
					continue;
				}
				case 32u:
					num = (int)(num2 * 991034076) ^ -195266236;
					continue;
				case 51u:
					itemInstance.AddRandomTriggers(2);
					num = (int)(num2 * 554277612) ^ -1377050178;
					continue;
				case 57u:
				{
					int num16;
					if (Tools.ProbabilityTest(0.09))
					{
						num = 1614189199;
						num16 = num;
					}
					else
					{
						num = 259997497;
						num16 = num;
					}
					continue;
				}
				case 34u:
					num = ((int)num2 * -2146714709) ^ -828944912;
					continue;
				case 30u:
				{
					int num9;
					if (!Tools.ProbabilityTest(0.4))
					{
						num = 2097387874;
						num9 = num;
					}
					else
					{
						num = 1489777203;
						num9 = num;
					}
					continue;
				}
				case 12u:
					itemInstance.AddRandomTriggers(5);
					num = ((int)num2 * -1904303302) ^ 0x4448C571;
					continue;
				case 2u:
					num = ((int)num2 * -1040466592) ^ 0x6FA83E4C;
					continue;
				case 58u:
				{
					int num5;
					if (!Tools.ProbabilityTest(0.07))
					{
						num = 239038225;
						num5 = num;
					}
					else
					{
						num = 1559502575;
						num5 = num;
					}
					continue;
				}
				case 44u:
					num = ((int)num2 * -1903548798) ^ -1552199834;
					continue;
				case 7u:
				{
					int num27;
					if (!Tools.ProbabilityTest(0.1))
					{
						num = 617281423;
						num27 = num;
					}
					else
					{
						num = 1061477706;
						num27 = num;
					}
					continue;
				}
				case 0u:
				{
					int num25;
					if (!Tools.ProbabilityTest(0.2))
					{
						num = 649932072;
						num25 = num;
					}
					else
					{
						num = 201887199;
						num25 = num;
					}
					continue;
				}
				case 24u:
				{
					int num23;
					if (Tools.ProbabilityTest(0.1))
					{
						num = 2108536841;
						num23 = num;
					}
					else
					{
						num = 1669449565;
						num23 = num;
					}
					continue;
				}
				case 55u:
					num = ((int)num2 * -597317382) ^ -934713724;
					continue;
				case 14u:
					itemInstance.AddRandomTriggers(9);
					num = (int)((num2 * 1011084993) ^ 0x8EFC60B);
					continue;
				case 38u:
					itemInstance.AddRandomTriggers(10);
					num = ((int)num2 * -465997975) ^ 0x41670E23;
					continue;
				case 16u:
					num = ((int)num2 * -1493190497) ^ -143292203;
					continue;
				case 41u:
				{
					int num20;
					if (Tools.ProbabilityTest(0.06))
					{
						num = 1566900247;
						num20 = num;
					}
					else
					{
						num = 70965878;
						num20 = num;
					}
					continue;
				}
				case 26u:
				{
					int num17;
					int num18;
					if (CommonSettings.MOD_KEY() != 1)
					{
						num17 = 63061029;
						num18 = num17;
					}
					else
					{
						num17 = 748236171;
						num18 = num17;
					}
					num = num17 ^ (int)(num2 * 1186801685);
					continue;
				}
				case 37u:
				{
					int num13;
					int num14;
					if (Tools.ProbabilityTest(0.02))
					{
						num13 = -1231467435;
						num14 = num13;
					}
					else
					{
						num13 = -663441389;
						num14 = num13;
					}
					num = num13 ^ (int)(num2 * 1136800981);
					continue;
				}
				case 9u:
				{
					int num10;
					int num11;
					if (Tools.ProbabilityTest(0.1))
					{
						num10 = -1948705786;
						num11 = num10;
					}
					else
					{
						num10 = -1292919062;
						num11 = num10;
					}
					num = num10 ^ ((int)num2 * -433097282);
					continue;
				}
				case 25u:
					itemInstance.AddRandomTriggers(6);
					num = (int)(num2 * 928010802) ^ -914179624;
					continue;
				case 36u:
					itemInstance.AddRandomTriggers(4);
					num = ((int)num2 * -1978857055) ^ -1930100086;
					continue;
				case 21u:
					num = ((int)num2 * -1924679914) ^ -1262639562;
					continue;
				case 19u:
					itemInstance.AddRandomTriggers(5);
					num = (int)((num2 * 1731673372) ^ 0x61A28569);
					continue;
				case 33u:
					itemInstance.AddRandomTriggers(1);
					num = 1561592588;
					continue;
				case 22u:
					itemInstance.AddRandomTriggers(4);
					num = (int)((num2 * 1514923106) ^ 0x1FE00918);
					continue;
				case 46u:
					itemInstance.AddRandomTriggers(3);
					num = ((int)num2 * -1301933133) ^ 0x368ACF12;
					continue;
				case 3u:
					itemInstance.AddRandomTriggers(7);
					num = ((int)num2 * -675969640) ^ -518250807;
					continue;
				case 48u:
					itemInstance.AddRandomTriggers(6);
					num = (int)(num2 * 453981385) ^ -945840463;
					continue;
				case 17u:
					num = (int)(num2 * 1648102551) ^ -451247541;
					continue;
				case 49u:
				{
					int num8;
					if (!Tools.ProbabilityTest(0.4))
					{
						num = 482804672;
						num8 = num;
					}
					else
					{
						num = 1507313465;
						num8 = num;
					}
					continue;
				}
				case 20u:
					num = (int)((num2 * 1522533487) ^ 0x4DBE1261);
					continue;
				case 40u:
					itemInstance.AddRandomTriggers(2);
					num = (int)(num2 * 12018620) ^ -1399856735;
					continue;
				case 54u:
					itemInstance.AddRandomTriggers(3);
					num = ((int)num2 * -708045789) ^ 0x7F4F345D;
					continue;
				case 15u:
					num = (int)(num2 * 572935751) ^ -1572240151;
					continue;
				case 8u:
				{
					int num7;
					if (Tools.ProbabilityTest(0.2))
					{
						num = 629579215;
						num7 = num;
					}
					else
					{
						num = 310592702;
						num7 = num;
					}
					continue;
				}
				case 56u:
					itemInstance.AddRandomTriggers(2);
					num = (int)((num2 * 2100396005) ^ 0x469AE8AD);
					continue;
				case 11u:
					itemInstance.AddRandomTriggers(1);
					num = 1806651502;
					continue;
				case 50u:
					num = ((int)num2 * -389270900) ^ 0x2592F5D0;
					continue;
				case 4u:
				{
					int num4;
					if (Tools.ProbabilityTest(0.0001))
					{
						num = 1628565543;
						num4 = num;
					}
					else
					{
						num = 2009515681;
						num4 = num;
					}
					continue;
				}
				case 47u:
					itemInstance.AddRandomTriggers(8);
					num = (int)(num2 * 1000876660) ^ -1288160869;
					continue;
				case 52u:
				{
					int num3;
					if (!Tools.ProbabilityTest(0.02))
					{
						num = 972154921;
						num3 = num;
					}
					else
					{
						num = 137415059;
						num3 = num;
					}
					continue;
				}
				default:
					return itemInstance;
				}
				break;
			}
		}
	}

	public static Item GetCanzhang(string name)
	{
		if (_202D_202E_200E_200F_202A_200C_206A_200F_206D_206A_202B_206C_202C_202B_206A_200B_206E_202E_200B_206F_206E_202B_200C_206C_202E_206D_200B_200B_200C_206F_202C_206F_200F_206A_200B_200D_202D_200E_200C_202E_202E(name, ResourceStrings.ResStrings[331]))
		{
			while (true)
			{
				uint num;
				switch ((num = 2075352157u) % 3)
				{
				case 0u:
					continue;
				case 1u:
				{
					string text = _200F_206A_202D_206D_206C_200B_202A_202A_202E_200B_202D_200B_206D_202B_202E_200D_206A_206E_202C_200D_206C_200B_206A_202B_206A_206F_202C_206F_200D_200F_200D_206A_202D_202B_206F_206F_206A_206A_202E_206A_202E(name, 0, _200B_200E_206D_200F_200B_200F_200C_200D_202B_202A_200D_206C_200F_200B_206A_200D_202C_206A_202D_200B_206A_206C_202A_200F_200E_202E_202C_200C_206D_202B_206B_202C_206B_206F_202C_206E_202D_202C_206C_200F_202E(name) - _200B_200E_206D_200F_200B_200F_200C_200D_202B_202A_200D_206C_200F_200B_206A_200D_202C_206A_202D_200B_206A_206C_202A_200F_200E_202E_202C_200C_206D_202B_206B_202C_206B_206F_202C_206E_202D_202C_206C_200F_202E(ResourceStrings.ResStrings[331]));
					return new Item
					{
						Name = name,
						type = 10,
						pic = ResourceStrings.ResStrings[333],
						CanzhangSkill = text,
						desc = _200D_206E_206C_206F_200B_200E_202A_200E_202B_200E_202A_200C_206A_202B_206F_206B_206D_200F_206F_200F_200F_206F_206A_206B_202B_200C_206E_200C_202A_200C_200F_206A_206C_206C_202D_200C_200F_202C_206E_206E_202E(ResourceStrings.ResStrings[332], (object)text),
						price = 200,
						box = -1
					};
				}
				}
				break;
			}
		}
		return null;
	}

	static string[] _206B_200C_200F_206D_202D_202A_200B_200F_206F_202D_200F_200C_200D_202C_202C_206A_206B_202E_206B_202D_206A_202C_200B_206A_200E_206D_200C_202D_206F_200E_202D_202C_202C_202D_202A_206E_202A_206B_206C_200D_202E(string P_0, char[] P_1, StringSplitOptions P_2)
	{
		return P_0.Split(P_1, P_2);
	}

	static bool _202D_202E_200E_200F_202A_200C_206A_200F_206D_206A_202B_206C_202C_202B_206A_200B_206E_202E_200B_206F_206E_202B_200C_206C_202E_206D_200B_200B_200C_206F_202C_206F_200F_206A_200B_200D_202D_200E_200C_202E_202E(string P_0, string P_1)
	{
		return P_0.EndsWith(P_1);
	}

	static int _200B_200E_206D_200F_200B_200F_200C_200D_202B_202A_200D_206C_200F_200B_206A_200D_202C_206A_202D_200B_206A_206C_202A_200F_200E_202E_202C_200C_206D_202B_206B_202C_206B_206F_202C_206E_202D_202C_206C_200F_202E(string P_0)
	{
		return P_0.Length;
	}

	static string _200F_206A_202D_206D_206C_200B_202A_202A_202E_200B_202D_200B_206D_202B_202E_200D_206A_206E_202C_200D_206C_200B_206A_202B_206A_206F_202C_206F_200D_200F_200D_206A_202D_202B_206F_206F_206A_206A_202E_206A_202E(string P_0, int P_1, int P_2)
	{
		return P_0.Substring(P_1, P_2);
	}

	static string _200D_206E_206C_206F_200B_200E_202A_200E_202B_200E_202A_200C_206A_202B_206F_206B_206D_200F_206F_200F_200F_206F_206A_206B_202B_200C_206E_200C_202A_200C_200F_206A_206C_206C_202D_200C_200F_202C_206E_206E_202E(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}
}
