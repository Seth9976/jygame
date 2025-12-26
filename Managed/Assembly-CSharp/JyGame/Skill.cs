using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("skill")]
public class Skill : BasePojo
{
	[XmlAttribute("name")]
	public string Name;

	[XmlAttribute("tiaohe")]
	public int TiaoheValue = -1;

	[XmlAttribute("type")]
	public int Type;

	private int _206A_206A_206D_202E_202C_206B_202D_206E_202B_202E_202E_206A_200B_200C_202D_206D_200B_202C_206D_202B_202B_202B_200F_202D_202B_206A_206C_206A_202D_206F_206A_206B_206C_202E_202B_206F_200E_202E_202D_202E_202E = -1;

	[XmlAttribute("coversize")]
	public int CoverSize;

	[XmlAttribute("castsize")]
	public int CastSize;

	[XmlAttribute("suit")]
	public float Suit;

	[XmlAttribute("hard")]
	public float Hard;

	[XmlAttribute("info")]
	public string Info;

	[XmlAttribute("audio")]
	public string Audio;

	[XmlAttribute("basepower")]
	public float BasePower;

	[XmlAttribute("step")]
	public float Step;

	[XmlAttribute("animation")]
	public string Animation;

	[XmlAttribute("cd")]
	public int Cd;

	[XmlAttribute]
	public string icon = string.Empty;

	[XmlAttribute("buff")]
	public string buff;

	[XmlElement("level")]
	public List<SkillLevelInfo> Levels = new List<SkillLevelInfo>();

	[XmlElement("trigger")]
	public List<Trigger> Triggers = new List<Trigger>();

	[XmlElement("unique")]
	public List<UniqueSkill> UniqueSkills = new List<UniqueSkill>();

	[XmlAttribute]
	public int fullscreen;

	[XmlAttribute]
	public float attacktime;

	[XmlAttribute("tiaohescale")]
	public float TiaoheScale;

	[XmlAttribute("audio2")]
	public string Audio2;

	[XmlAttribute("isnpc")]
	public bool IsNpc;

	public override string PK => Name;

	public bool Tiaohe => TiaoheValue == 1;

	[XmlAttribute("covertype")]
	public int CoverType
	{
		get
		{
			return (_206A_206A_206D_202E_202C_206B_202D_206E_202B_202E_202E_206A_200B_200C_202D_206D_200B_202C_206D_202B_202B_202B_200F_202D_202B_206A_206C_206A_202D_206F_206A_206B_206C_202E_202B_206F_200E_202E_202D_202E_202E != -1) ? _206A_206A_206D_202E_202C_206B_202D_206E_202B_202E_202E_206A_200B_200C_202D_206D_200B_202C_206D_202B_202B_202B_200F_202D_202B_206A_206C_206A_202D_206F_206A_206B_206C_202E_202B_206F_200E_202E_202D_202E_202E : ((int)CommonSettings.GetDefaultCoverType(Type));
		}
		set
		{
			_206A_206A_206D_202E_202C_206B_202D_206E_202B_202E_202E_206A_200B_200C_202D_206D_200B_202C_206D_202B_202B_202B_200F_202D_202B_206A_206C_206A_202D_206F_206A_206B_206C_202E_202B_206F_200E_202E_202D_202E_202E = value;
		}
	}

	[XmlIgnore]
	public IEnumerable<Buff> Buffs => Buff.Parse(buff);

	public string SuitInfo
	{
		get
		{
			if (Tiaohe)
			{
				goto IL_000b;
			}
			goto IL_0108;
			IL_000b:
			int num = 1451740947;
			goto IL_0010;
			IL_0010:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7FA7D96A)) % 9)
				{
				case 0u:
					break;
				case 5u:
					return _202A_200D_202D_206E_202D_200F_202E_200C_200D_202E_200F_206E_202C_202A_206C_200B_206A_206A_206B_206F_206A_206A_200D_206C_200C_202A_206B_200E_200D_200D_206F_200B_200B_202E_200B_200E_202D_200F_206C_206E_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2495314555u), (object)(Suit * 100f));
				case 3u:
					goto IL_0079;
				case 6u:
					return global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1267673718u);
				case 8u:
					return _202A_200D_202D_206E_202D_200F_202E_200C_200D_202E_200F_206E_202C_202A_206C_200B_206A_206A_206B_206F_206A_206A_200D_206C_200C_202A_206B_200E_200D_200D_206F_200B_200B_202E_200B_200E_202D_200F_206C_206E_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(121755540u), (object)((0f - Suit) * 100f));
				case 7u:
					return global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1994577410u);
				case 1u:
					goto IL_0108;
				case 2u:
					goto IL_0129;
				default:
					return global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2425292056u);
				}
				break;
				IL_0129:
				int num3;
				if (Suit >= 0f)
				{
					num = 483807235;
					num3 = num;
				}
				else
				{
					num = 2095840810;
					num3 = num;
				}
				continue;
				IL_0079:
				int num4;
				if (Suit > 0f)
				{
					num = 1003290692;
					num4 = num;
				}
				else
				{
					num = 764392093;
					num4 = num;
				}
			}
			goto IL_000b;
			IL_0108:
			int num5;
			if (Suit != 0f)
			{
				num = 701198131;
				num5 = num;
			}
			else
			{
				num = 849299266;
				num5 = num;
			}
			goto IL_0010;
		}
	}

	private SkillLevelInfo GetSkillLevelInfo(int level)
	{
		List<SkillLevelInfo>.Enumerator enumerator = Levels.GetEnumerator();
		try
		{
			SkillLevelInfo current = default(SkillLevelInfo);
			SkillLevelInfo result = default(SkillLevelInfo);
			while (true)
			{
				IL_006f:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 425547419;
					num2 = num;
				}
				else
				{
					num = 877456167;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x11F95C4A)) % 6)
					{
					case 4u:
						num = 425547419;
						continue;
					default:
						goto end_IL_0013;
					case 1u:
					{
						current = enumerator.Current;
						int num4;
						if (current.Level == level)
						{
							num = 849237192;
							num4 = num;
						}
						else
						{
							num = 1574752301;
							num4 = num;
						}
						continue;
					}
					case 0u:
						result = current;
						num = (int)(num3 * 971476350) ^ -2026247402;
						continue;
					case 5u:
						break;
					case 3u:
						goto end_IL_0013;
					case 2u:
						return result;
					}
					goto IL_006f;
					continue;
					end_IL_0013:
					break;
				}
				break;
			}
		}
		finally
		{
			_202E_206F_206D_206D_206B_202A_206B_206A_200C_202E_200F_200C_202D_200D_206C_200C_200F_206C_200F_200B_200F_200E_200C_200E_206C_202A_206C_202B_200F_200B_206E_206D_202C_202C_200C_202E_202D_206F_202B_206F_202E((IDisposable)enumerator);
		}
		return null;
	}

	public float GetPower(int level)
	{
		SkillLevelInfo skillLevelInfo = GetSkillLevelInfo(level);
		while (true)
		{
			int num = -1213270117;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ -1044102223)) % 4)
				{
				case 3u:
					break;
				case 2u:
				{
					int num4;
					if (skillLevelInfo != null)
					{
						num3 = 49922220;
						num4 = num3;
					}
					else
					{
						num3 = 1736509653;
						num4 = num3;
					}
					goto IL_003f;
				}
				case 1u:
					return skillLevelInfo.Power;
				default:
					return BasePower + (float)(level - 1) * Step;
				}
				break;
				IL_003f:
				num = num3 ^ (int)(num2 * 1508768602);
			}
		}
	}

	public int GetCoverSize(int level)
	{
		SkillLevelInfo skillLevelInfo = GetSkillLevelInfo(level);
		float dSize = default(float);
		int coverType = default(int);
		while (true)
		{
			int num = -1889484960;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1426074839)) % 21)
				{
				case 5u:
					break;
				case 17u:
				{
					int num15;
					int num16;
					if (Type != 2)
					{
						num15 = -563481445;
						num16 = num15;
					}
					else
					{
						num15 = -474255238;
						num16 = num15;
					}
					num = num15 ^ ((int)num2 * -161291760);
					continue;
				}
				case 16u:
					dSize = new SkillCoverTypeHelper((SkillCoverType)coverType).dSize;
					num = -229172394;
					continue;
				case 8u:
				{
					int num17;
					int num18;
					if (level < 100)
					{
						num17 = -1406978214;
						num18 = num17;
					}
					else
					{
						num17 = -1357211931;
						num18 = num17;
					}
					num = num17 ^ ((int)num2 * -854486012);
					continue;
				}
				case 0u:
				{
					int num6;
					if (level >= 100)
					{
						num = -370359168;
						num6 = num;
					}
					else
					{
						num = -352442646;
						num6 = num;
					}
					continue;
				}
				case 6u:
					coverType = CoverType;
					num = -1239871192;
					continue;
				case 10u:
				{
					int num11;
					int num12;
					if (Type == 5)
					{
						num11 = 145262822;
						num12 = num11;
					}
					else
					{
						num11 = 522883478;
						num12 = num11;
					}
					num = num11 ^ (int)(num2 * 930653582);
					continue;
				}
				case 1u:
				{
					int num20;
					if (level >= 5)
					{
						num = -28421876;
						num20 = num;
					}
					else
					{
						num = -1738343823;
						num20 = num;
					}
					continue;
				}
				case 12u:
				{
					int num9;
					int num10;
					if (coverType == 5)
					{
						num9 = 1825064010;
						num10 = num9;
					}
					else
					{
						num9 = 1346607287;
						num10 = num9;
					}
					num = num9 ^ (int)(num2 * 1835091037);
					continue;
				}
				case 2u:
					return 2;
				case 9u:
				{
					int num5;
					if (level >= 5)
					{
						num = -1995921241;
						num5 = num;
					}
					else
					{
						num = -640244804;
						num5 = num;
					}
					continue;
				}
				case 19u:
				{
					int num19;
					if (CoverSize <= 0)
					{
						num = -1456142064;
						num19 = num;
					}
					else
					{
						num = -1211074001;
						num19 = num;
					}
					continue;
				}
				case 4u:
					return 1;
				case 18u:
					return skillLevelInfo.CoverSize;
				case 20u:
				{
					int num13;
					int num14;
					if (skillLevelInfo != null)
					{
						num13 = 1537955566;
						num14 = num13;
					}
					else
					{
						num13 = 697945542;
						num14 = num13;
					}
					num = num13 ^ ((int)num2 * -1254593778);
					continue;
				}
				case 14u:
					return CoverSize;
				case 11u:
				{
					int num7;
					int num8;
					if (skillLevelInfo.CoverSize > 0)
					{
						num7 = 1273074290;
						num8 = num7;
					}
					else
					{
						num7 = 1384209933;
						num8 = num7;
					}
					num = num7 ^ (int)(num2 * 1282954717);
					continue;
				}
				case 15u:
					return (int)(1f + dSize * (float)level);
				case 3u:
					return 0;
				case 7u:
				{
					int num3;
					int num4;
					if (level <= 10)
					{
						num3 = 1147101266;
						num4 = num3;
					}
					else
					{
						num3 = 1160442057;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -800553954);
					continue;
				}
				default:
					return (int)(1f + dSize * 10f);
				}
				break;
			}
		}
	}

	public SkillCoverType GetCoverType(int level)
	{
		SkillLevelInfo skillLevelInfo = GetSkillLevelInfo(level);
		while (true)
		{
			int num = 1513123412;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ 0x497BE86A)) % 4)
				{
				case 0u:
					break;
				case 2u:
				{
					int num4;
					if (skillLevelInfo != null)
					{
						num3 = 1073658797;
						num4 = num3;
					}
					else
					{
						num3 = 514655007;
						num4 = num3;
					}
					goto IL_003f;
				}
				case 1u:
					return (SkillCoverType)skillLevelInfo.CoverType;
				default:
					return (SkillCoverType)CoverType;
				}
				break;
				IL_003f:
				num = num3 ^ ((int)num2 * -1196650921);
			}
		}
	}

	public int GetCastSize(int level)
	{
		SkillLevelInfo skillLevelInfo = GetSkillLevelInfo(level);
		int baseCastSize = default(int);
		float dCastSize = default(float);
		while (true)
		{
			int num = 704076891;
			while (true)
			{
				uint num2;
				int result;
				switch ((num2 = (uint)(num ^ 0x53D899C)) % 9)
				{
				case 8u:
					break;
				case 1u:
					return CastSize;
				case 2u:
					return skillLevelInfo.CastSize;
				case 0u:
				{
					int num6;
					int num7;
					if (skillLevelInfo.CastSize <= 0)
					{
						num6 = -932207689;
						num7 = num6;
					}
					else
					{
						num6 = -1771650196;
						num7 = num6;
					}
					num = num6 ^ ((int)num2 * -1735630308);
					continue;
				}
				case 7u:
				{
					int num3;
					int num4;
					if (skillLevelInfo == null)
					{
						num3 = 621330612;
						num4 = num3;
					}
					else
					{
						num3 = 124658054;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1271992633);
					continue;
				}
				case 3u:
				{
					int num5;
					if (CastSize <= 0)
					{
						num = 76600869;
						num5 = num;
					}
					else
					{
						num = 403646844;
						num5 = num;
					}
					continue;
				}
				case 5u:
					if (level <= 10)
					{
						num = (int)((num2 * 1606063837) ^ 0x4B6F7677);
						continue;
					}
					result = (int)((float)baseCastSize + dCastSize * 10f);
					goto IL_012a;
				case 4u:
				{
					SkillCoverTypeHelper skillCoverTypeHelper = new SkillCoverTypeHelper(GetCoverType(level));
					baseCastSize = skillCoverTypeHelper.baseCastSize;
					dCastSize = skillCoverTypeHelper.dCastSize;
					num = 2127742689;
					continue;
				}
				default:
					{
						result = (int)((float)baseCastSize + dCastSize * (float)level);
						goto IL_012a;
					}
					IL_012a:
					return result;
				}
				break;
			}
		}
	}

	public string GetAnimationName(int level)
	{
		SkillLevelInfo skillLevelInfo = GetSkillLevelInfo(level);
		if (skillLevelInfo != null)
		{
			while (true)
			{
				uint num;
				switch ((num = 1022884699u) % 3)
				{
				case 0u:
					continue;
				case 1u:
					return skillLevelInfo.Animation;
				}
				break;
			}
		}
		return Animation;
	}

	public int GetCooldown(int level)
	{
		SkillLevelInfo skillLevelInfo = GetSkillLevelInfo(level);
		if (skillLevelInfo != null)
		{
			while (true)
			{
				uint num;
				switch ((num = 50269366u) % 3)
				{
				case 2u:
					continue;
				case 1u:
					return skillLevelInfo.Cd;
				}
				break;
			}
		}
		return Cd;
	}

	public int GetLevelupExp(int currentLevel)
	{
		return (int)((float)currentLevel / 4f * (Hard + 1f) / 4f * 15f * 8f);
	}

	public override void InitBind()
	{
		List<UniqueSkill>.Enumerator enumerator = UniqueSkills.GetEnumerator();
		try
		{
			while (true)
			{
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 1063837662;
					num2 = num;
				}
				else
				{
					num = 397270640;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x1834CEC7)) % 4)
					{
					case 2u:
						num = 1063837662;
						continue;
					default:
						return;
					case 1u:
					{
						UniqueSkill current = enumerator.Current;
						ResourceManager.Add<UniqueSkill>(current.PK, current);
						num = 1848412483;
						continue;
					}
					case 0u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			_202E_206F_206D_206D_206B_202A_206B_206A_200C_202E_200F_200C_202D_200D_206C_200C_200F_206C_200F_200B_200F_200E_200C_200E_206C_202A_206C_202B_200F_200B_206E_206D_202C_202C_200C_202E_202D_206F_202B_206F_202E((IDisposable)enumerator);
		}
	}

	static void _202E_206F_206D_206D_206B_202A_206B_206A_200C_202E_200F_200C_202D_200D_206C_200C_200F_206C_200F_200B_200F_200E_200C_200E_206C_202A_206C_202B_200F_200B_206E_206D_202C_202C_200C_202E_202D_206F_202B_206F_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static string _202A_200D_202D_206E_202D_200F_202E_200C_200D_202E_200F_206E_202C_202A_206C_200B_206A_206A_206B_206F_206A_206A_200D_206C_200C_202A_206B_200E_200D_200D_206F_200B_200B_202E_200B_200E_202D_200F_206C_206E_202E(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}
}
