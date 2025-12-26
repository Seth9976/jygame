using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace JyGame;

public class BuffInstance
{
	public BattleSprite Owner;

	public Buff buff;

	private int _202B_202C_202C_200B_206B_200B_206D_206A_206B_200D_200D_200F_206E_200F_202D_206D_202E_200C_206F_206B_200E_206C_206B_200D_202C_206D_206A_206C_202B_200E_202B_200B_206F_206E_206F_202D_206A_206E_206D_206F_202E = -1;

	public int LeftRound;

	public int TimeStamp;

	[CompilerGenerated]
	private static Dictionary<string, int> _200F_200B_202C_200F_200F_206A_200C_202C_206E_206D_200C_200C_200D_206A_200C_200F_200D_202B_206C_206E_200E_200C_206F_206F_202C_202C_200C_200B_200B_202B_202C_202D_200E_202B_200D_200F_206C_200D_202E_206B_202E;

	public string Name => buff.Name;

	public int Level
	{
		get
		{
			return (_202B_202C_202C_200B_206B_200B_206D_206A_206B_200D_200D_200F_206E_200F_202D_206D_202E_200C_206F_206B_200E_206C_206B_200D_202C_206D_206A_206C_202B_200E_202B_200B_206F_206E_206F_202D_206A_206E_206D_206F_202E != -1) ? _202B_202C_202C_200B_206B_200B_206D_206A_206B_200D_200D_200F_206E_200F_202D_206D_202E_200C_206F_206B_200E_206C_206B_200D_202C_206D_206A_206C_202B_200E_202B_200B_206F_206E_206F_202D_206A_206E_206D_206F_202E : buff.Level;
		}
		set
		{
			_202B_202C_202C_200B_206B_200B_206D_206A_206B_200D_200D_200F_206E_200F_202D_206D_202E_200C_206F_206B_200E_206C_206B_200D_202C_206D_206A_206C_202B_200E_202B_200B_206F_206E_206F_202D_206A_206E_206D_206F_202E = value;
		}
	}

	public bool IsDebuff => buff.IsDebuff;

	public override string ToString()
	{
		return _202C_206E_206C_206B_206E_200C_200D_206C_206B_202C_202B_202B_200C_200B_202C_206B_200B_200B_200F_202C_200E_202A_206A_200F_202B_202E_206E_200D_206C_202C_206A_206E_206A_202C_206F_202D_206C_200B_202A_200C_202E(buff.Name, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4098429582u));
	}

	public string Info()
	{
		string text = string.Empty;
		string text2 = default(string);
		while (true)
		{
			int num = -1293712042;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2083458736)) % 7)
				{
				case 0u:
					break;
				case 4u:
					text = _206A_200E_200D_202A_202C_200E_206F_206F_200F_206B_206F_200E_200B_200E_206D_202B_202A_200E_202B_206B_200D_206E_206F_202A_206E_200E_206A_200C_200B_202A_206B_206A_200E_206B_200B_200B_206E_202E_206B_200C_202E(new object[4]
					{
						text2,
						global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2276242103u),
						Level,
						global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3271294194u)
					});
					num = ((int)num2 * -1307403526) ^ -1544309780;
					continue;
				case 6u:
					text2 = text;
					num = (int)(num2 * 1693299080) ^ -1944397733;
					continue;
				case 3u:
					text = _202C_206E_206C_206B_206E_200C_200D_206C_206B_202C_202B_202B_200C_200B_202C_206B_200B_200B_200F_202C_200E_202A_206A_200F_202B_202E_206E_200D_206C_202C_206A_206E_206A_202C_206F_202D_206C_200B_202A_200C_202E(text, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2591225805u));
					num = -941572891;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (buff.Level <= 0)
					{
						num3 = -271087753;
						num4 = num3;
					}
					else
					{
						num3 = -726980726;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 660061258);
					continue;
				}
				case 1u:
					num = (int)(num2 * 1487233953) ^ -766485881;
					continue;
				default:
					return text + global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(713379169u) + LeftRound + global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2280779557u);
				}
				break;
			}
		}
	}

	public RoundBuffResult RoundEffect()
	{
		RoundBuffResult roundBuffResult = new RoundBuffResult();
		int num4 = default(int);
		double num12 = default(double);
		string name = default(string);
		int num8 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -548613902;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -357199382)) % 35)
				{
				case 3u:
					break;
				case 9u:
					return roundBuffResult;
				case 21u:
					num4 = (int)((double)(70 * Level) * (1.0 - num12 * 0.6) * Tools.GetRandom(0.9, 1.0));
					num = ((int)num2 * -1127198867) ^ -712698695;
					continue;
				case 30u:
				{
					int num22;
					int num23;
					if (_200F_200E_202C_200D_200B_200E_206C_202D_202C_206D_202E_206C_202A_206D_206F_202B_202D_200C_206F_200F_202B_202C_202D_206A_206F_206F_206D_202E_200F_200B_206F_206F_200E_206E_206F_202A_206C_200F_206F_200D_202E(name, ResourceStrings.ResStrings[523]))
					{
						num22 = -1316533659;
						num23 = num22;
					}
					else
					{
						num22 = -1117997677;
						num23 = num22;
					}
					num = num22 ^ (int)(num2 * 701925718);
					continue;
				}
				case 25u:
					num4 /= 2;
					num = (int)((num2 * 965145116) ^ 0xB07D363);
					continue;
				case 1u:
				{
					int num16;
					if (!_200F_200E_202C_200D_200B_200E_206C_202D_202C_206D_202E_206C_202A_206D_206F_202B_202D_200C_206F_200F_202B_202C_202D_206A_206F_206F_206D_202E_200F_200B_206F_206F_200E_206E_206F_202A_206C_200F_206F_200D_202E(name, ResourceStrings.ResStrings[520]))
					{
						num = -1398495573;
						num16 = num;
					}
					else
					{
						num = -1089050139;
						num16 = num;
					}
					continue;
				}
				case 26u:
					num4 = 1;
					num = (int)(num2 * 2022506040) ^ -799702520;
					continue;
				case 6u:
					roundBuffResult.AddMp = -num8;
					num = (int)(num2 * 1890877445) ^ -1926612436;
					continue;
				case 14u:
					Owner.Hp = 1;
					num = ((int)num2 * -834359459) ^ -1843922418;
					continue;
				case 28u:
				{
					int num20;
					if (Owner.Mp - num8 >= 0)
					{
						num = -545115110;
						num20 = num;
					}
					else
					{
						num = -382910813;
						num20 = num;
					}
					continue;
				}
				case 16u:
					roundBuffResult.buff = this;
					num = (int)((num2 * 1953961824) ^ 0x56C2AC81);
					continue;
				case 34u:
					num8 = 1;
					num = (int)((num2 * 137762923) ^ 0x427089D2);
					continue;
				case 0u:
					roundBuffResult.AddHp = -num4;
					num = -1022815425;
					continue;
				case 2u:
					return roundBuffResult;
				case 33u:
				{
					name = buff.Name;
					int num13;
					int num14;
					if (_200F_200E_202C_200D_200B_200E_206C_202D_202C_206D_202E_206C_202A_206D_206F_202B_202D_200C_206F_200F_202B_202C_202D_206A_206F_206F_206D_202E_200F_200B_206F_206F_200E_206E_206F_202A_206C_200F_206F_200D_202E(name, ResourceStrings.ResStrings[519]))
					{
						num13 = -704575202;
						num14 = num13;
					}
					else
					{
						num13 = -1112643429;
						num14 = num13;
					}
					num = num13 ^ ((int)num2 * -1548441879);
					continue;
				}
				case 8u:
					return roundBuffResult;
				case 27u:
				{
					int num7;
					if (num4 >= 1)
					{
						num = -868334640;
						num7 = num;
					}
					else
					{
						num = -971204089;
						num7 = num;
					}
					continue;
				}
				case 7u:
				{
					int num21;
					if (Tools.ProbabilityTest(_206B_202D_206D_206F_202A_200E_200C_206A_206D_200D_200B_202E_202D_202A_200D_200B_200F_202C_200D_206D_206A_206B_206B_206B_206F_202B_206D_202A_206C_200F_202A_202C_206F_206D_206A_200F_206E_206B_206C_200F_202E(0.15 + 0.2 * (double)Level, (double)buff.Property * 0.01)))
					{
						num = -128158346;
						num21 = num;
					}
					else
					{
						num = -962563148;
						num21 = num;
					}
					continue;
				}
				case 5u:
					roundBuffResult.AddBall = _206E_200B_206D_202D_206E_200D_206F_206B_206C_202C_206F_202A_206E_206D_202C_202D_200F_200D_200C_206B_202C_206B_200C_206A_200E_200D_200B_200B_206F_206D_206D_206A_206C_202D_200F_206F_206B_206F_202D_206C_202E(1, roundBuffResult.AddBall);
					num = (int)(num2 * 1479297137) ^ -889603224;
					continue;
				case 24u:
					num12 = (double)Owner.Role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(912726802u)] / (double)BattleField.ROLE_MAX_ATTRIBUTE[Owner.Role];
					num = ((int)num2 * -578035367) ^ 0xB0535BE;
					continue;
				case 10u:
				{
					int num19;
					if (Owner.Hp - num4 < 0)
					{
						num = -365576799;
						num19 = num;
					}
					else
					{
						num = -516808981;
						num19 = num;
					}
					continue;
				}
				case 15u:
					num3 = Owner.MaxHp - Owner.Hp;
					num = (int)(num2 * 1533256443) ^ -1907145544;
					continue;
				case 31u:
					LuaManager.Call(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(61217689u), this, roundBuffResult);
					num = -326842843;
					continue;
				case 23u:
					num8 = Owner.Mp;
					num = (int)(num2 * 522799502) ^ -1378074780;
					continue;
				case 13u:
					Owner.Mp -= num8;
					num = -245584283;
					continue;
				case 20u:
					return roundBuffResult;
				case 11u:
				{
					num3 = (int)((double)(Owner.Role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3583101943u)] / 3 * Level) * (1.0 + Tools.GetRandom(0.0, 0.5)));
					int num17;
					int num18;
					if (Owner.Hp + num3 <= Owner.MaxHp)
					{
						num17 = -1300559416;
						num18 = num17;
					}
					else
					{
						num17 = -1932977536;
						num18 = num17;
					}
					num = num17 ^ (int)(num2 * 122207715);
					continue;
				}
				case 32u:
				{
					int num15;
					if (!_200F_200E_202C_200D_200B_200E_206C_202D_202C_206D_202E_206C_202A_206D_206F_202B_202D_200C_206F_200F_202B_202C_202D_206A_206F_206F_206D_202E_200F_200B_206F_206F_200E_206E_206F_202A_206C_200F_206F_200D_202E(name, ResourceStrings.ResStrings[521]))
					{
						num = -1127774686;
						num15 = num;
					}
					else
					{
						num = -928670059;
						num15 = num;
					}
					continue;
				}
				case 22u:
				{
					num8 = (int)((double)((BattleField.ROLE_MAX_ATTRIBUTE[Owner.Role] - Owner.Role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(912726802u)]) / 4 * Level) * (1.0 + Tools.GetRandom(0.0, 0.5)));
					int num10;
					int num11;
					if (num8 < 1)
					{
						num10 = 1853292109;
						num11 = num10;
					}
					else
					{
						num10 = 1983195233;
						num11 = num10;
					}
					num = num10 ^ (int)(num2 * 1318897671);
					continue;
				}
				case 18u:
				{
					int num9;
					if (!_200F_200E_202C_200D_200B_200E_206C_202D_202C_206D_202E_206C_202A_206D_206F_202B_202D_200C_206F_200F_202B_202C_202D_206A_206F_206F_206D_202E_200F_200B_206F_206F_200E_206E_206F_202A_206C_200F_206F_200D_202E(name, ResourceStrings.ResStrings[522]))
					{
						num = -588659314;
						num9 = num;
					}
					else
					{
						num = -1975347203;
						num9 = num;
					}
					continue;
				}
				case 4u:
					Owner.Hp += num3;
					num = -165262058;
					continue;
				case 19u:
				{
					int num5;
					int num6;
					if (Owner.Role.BuiltInTalents[28])
					{
						num5 = 1704160243;
						num6 = num5;
					}
					else
					{
						num5 = 697367227;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1371527563);
					continue;
				}
				case 17u:
					num4 = Owner.Hp - 1;
					num = (int)(num2 * 685570296) ^ -1881073045;
					continue;
				case 12u:
					roundBuffResult.AddHp = num3;
					num = ((int)num2 * -693001159) ^ 0x13F66532;
					continue;
				default:
					return roundBuffResult;
				}
				break;
			}
		}
	}

	static string _202C_206E_206C_206B_206E_200C_200D_206C_206B_202C_202B_202B_200C_200B_202C_206B_200B_200B_200F_202C_200E_202A_206A_200F_202B_202E_206E_200D_206C_202C_206A_206E_206A_202C_206F_202D_206C_200B_202A_200C_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static string _206A_200E_200D_202A_202C_200E_206F_206F_200F_206B_206F_200E_200B_200E_206D_202B_202A_200E_202B_206B_200D_206E_206F_202A_206E_200E_206A_200C_200B_202A_206B_206A_200E_206B_200B_200B_206E_202E_206B_200C_202E(object[] P_0)
	{
		return string.Concat(P_0);
	}

	static bool _200F_200E_202C_200D_200B_200E_206C_202D_202C_206D_202E_206C_202A_206D_206F_202B_202D_200C_206F_200F_202B_202C_202D_206A_206F_206F_206D_202E_200F_200B_206F_206F_200E_206E_206F_202A_206C_200F_206F_200D_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static double _206B_202D_206D_206F_202A_200E_200C_206A_206D_200D_200B_202E_202D_202A_200D_200B_200F_202C_200D_206D_206A_206B_206B_206B_206F_202B_206D_202A_206C_200F_202A_202C_206F_206D_206A_200F_206E_206B_206C_200F_202E(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	static int _206E_200B_206D_202D_206E_200D_206F_206B_206C_202C_206F_202A_206E_206D_202C_202D_200F_200D_200C_206B_202C_206B_200C_206A_200E_200D_200B_200B_206F_206D_206D_206A_206C_202D_200F_206F_206B_206F_202D_206C_202E(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}
}
