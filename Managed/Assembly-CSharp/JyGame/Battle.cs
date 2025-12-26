using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("battle")]
public class Battle : BasePojo
{
	[XmlAttribute("key")]
	public string Key;

	[XmlAttribute("map")]
	public string Map;

	[XmlAttribute("mapkey")]
	public string MapKey;

	[XmlAttribute("music")]
	public string Music;

	[XmlAttribute("must")]
	public string MustStr;

	[XmlAttribute("forceAI")]
	public bool ForceAI;

	[XmlArrayItem(typeof(BattleRole))]
	[XmlArray("roles")]
	public List<BattleRole> Roles;

	[XmlArrayItem(typeof(StoryAction))]
	[XmlArray("story0")]
	public List<StoryAction> StoryActions;

	[XmlElement("random")]
	public RandomBattleRole randomBattleRoles;

	[XmlAttribute("bonus")]
	public bool Bonus = true;

	[XmlAttribute("trainingmode")]
	public bool TrainingMode;

	[XmlAttribute("setmoney")]
	public string SetMoney;

	[XmlAttribute("setyuanbao")]
	public string SetYuanbao;

	[XmlAttribute("setexp")]
	public string SetExp;

	[XmlAttribute("moveblock_remove")]
	public string MoveBlock_Remove;

	[XmlAttribute("moveblock_max_x")]
	public int MoveBlock_Max_X;

	[XmlAttribute("moveblock_max_y")]
	public int MoveBlock_Max_Y;

	[XmlAttribute("moveblock_margin_right")]
	public float MoveBlock_Margin_Right;

	[XmlAttribute("moveblock_margin_top")]
	public float MoveBlock_Margin_Top;

	[XmlAttribute("forbbiden")]
	public string Forbbiden;

	[XmlArrayItem(typeof(BattleStory))]
	[XmlArray("storys")]
	public List<BattleStory> Storys;

	public override string PK => Key;

	public List<string> mustKeys
	{
		get
		{
			if (!_202C_200F_202A_202C_200F_206F_202E_200E_206D_202B_200B_202E_206D_206D_200C_202D_206F_206B_206F_200C_202C_200B_206B_206A_202E_202C_202C_202C_202C_206E_202B_202A_206B_202E_202C_202C_200F_206D_202D_206B_202E(MustStr))
			{
				while (true)
				{
					uint num;
					switch ((num = 1258209286u) % 3)
					{
					case 0u:
						continue;
					case 1u:
						return new List<string>(_200B_206F_200C_206C_202C_206F_206A_206E_202A_202A_202B_200E_202D_200C_200D_206F_200D_206B_202A_202C_206C_200B_206E_206D_206B_206F_202D_206A_202E_206D_202B_206B_200C_202E_206A_200E_206D_206D_206D_202E(MustStr, new char[1] { '#' }));
					}
					break;
				}
			}
			return null;
		}
	}

	[XmlIgnore]
	public bool IsArena => _202C_200B_200C_206A_206E_206E_200B_206C_200B_200F_200F_200B_202A_206E_202E_202C_202A_202C_206C_202E_202C_200D_202D_206A_206D_206C_200F_200F_200F_206D_202A_206C_200C_200D_200C_202A_200D_200D_206E_206A_202E(Key, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(984164806u));

	public Battle Clone()
	{
		Battle battle = BasePojo.Create<Battle>(Xml);
		battle.Xml = Xml;
		battle.initStorys();
		return battle;
	}

	private void initStorys()
	{
		if (Storys == null)
		{
			return;
		}
		using List<BattleStory>.Enumerator enumerator = Storys.GetEnumerator();
		while (true)
		{
			int num;
			int num2;
			if (enumerator.MoveNext())
			{
				num = 1538332916;
				num2 = num;
			}
			else
			{
				num = 632995381;
				num2 = num;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num ^ 0x24FEE8D7)) % 4)
				{
				case 0u:
					num = 1538332916;
					continue;
				default:
					return;
				case 3u:
					enumerator.Current.Init();
					num = 1014090654;
					continue;
				case 1u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	static bool _202C_200F_202A_202C_200F_206F_202E_200E_206D_202B_200B_202E_206D_206D_200C_202D_206F_206B_206F_200C_202C_200B_206B_206A_202E_202C_202C_202C_202C_206E_202B_202A_206B_202E_202C_202C_200F_206D_202D_206B_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static string[] _200B_206F_200C_206C_202C_206F_206A_206E_202A_202A_202B_200E_202D_200C_200D_206F_200D_206B_202A_202C_206C_200B_206E_206D_206B_206F_202D_206A_202E_206D_202B_206B_200C_202E_206A_200E_206D_206D_206D_202E(string P_0, char[] P_1)
	{
		return P_0.Split(P_1);
	}

	static bool _202C_200B_200C_206A_206E_206E_200B_206C_200B_200F_200F_200B_202A_206E_202E_202C_202A_202C_206C_202E_202C_200D_202D_206A_206D_206C_200F_200F_200F_206D_202A_206C_200C_200D_200C_202A_200D_200D_206E_206A_202E(string P_0, string P_1)
	{
		return P_0.StartsWith(P_1);
	}
}
