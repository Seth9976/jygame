using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("trigger")]
public class ITTrigger
{
	[XmlAttribute("name")]
	public string Name = string.Empty;

	[XmlAttribute("w")]
	public int Weight = 100;

	[XmlElement("param")]
	public List<ITParam> Params = new List<ITParam>();

	[XmlAttribute("r")]
	public int Round = 1;

	public bool HasPool
	{
		get
		{
			List<ITParam>.Enumerator enumerator = Params.GetEnumerator();
			try
			{
				while (true)
				{
					IL_005e:
					int num;
					int num2;
					if (!enumerator.MoveNext())
					{
						num = -1865152945;
						num2 = num;
					}
					else
					{
						num = -1868837042;
						num2 = num;
					}
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num ^ -1626889105)) % 5)
						{
						case 3u:
							num = -1868837042;
							continue;
						default:
							goto end_IL_0013;
						case 1u:
						{
							ITParam current = enumerator.Current;
							int num4;
							if (!_200B_202D_200B_206A_202C_200B_200B_200D_200B_200E_202D_206F_202D_200D_202C_200E_200B_200B_206E_202B_206D_202A_200E_200D_206A_200E_200F_206A_206D_206A_206B_200F_202C_206F_206B_206A_200B_200E_200E_206D_202E(current.Pool))
							{
								num = -1203489128;
								num4 = num;
							}
							else
							{
								num = -2138577639;
								num4 = num;
							}
							continue;
						}
						case 2u:
							break;
						case 4u:
							return true;
						case 0u:
							goto end_IL_0013;
						}
						goto IL_005e;
						continue;
						end_IL_0013:
						break;
					}
					break;
				}
			}
			finally
			{
				_206F_200B_200D_202A_200D_206F_206E_206F_206D_200D_202E_200D_200F_200F_206E_200F_202A_200D_200B_206F_206F_200E_200F_206A_200D_202C_202D_206B_200F_200F_202D_202C_200D_206B_200D_200D_200F_202D_202D_206F_202E((IDisposable)enumerator);
			}
			return false;
		}
	}

	public Trigger GenerateItemTrigger(int itemLevel)
	{
		int num = itemLevel;
		if (num < 1)
		{
			goto IL_0009;
		}
		goto IL_076c;
		IL_0009:
		int num2 = 1261351907;
		goto IL_000e;
		IL_000e:
		Trigger trigger = default(Trigger);
		Aoyi randomAoyi = default(Aoyi);
		int num30 = default(int);
		int num31 = default(int);
		bool flag = default(bool);
		bool triggersXml = default(bool);
		double num58 = default(double);
		int round9 = default(int);
		float startSkillHard2 = default(float);
		int a4 = default(int);
		int b4 = default(int);
		int a3 = default(int);
		int b3 = default(int);
		int round7 = default(int);
		int b2 = default(int);
		int round3 = default(int);
		string text3 = default(string);
		int a2 = default(int);
		string text2 = default(string);
		string[] array = default(string[]);
		int num9 = default(int);
		int a = default(int);
		int b = default(int);
		string text = default(string);
		int round2 = default(int);
		Skill randomSkill2 = default(Skill);
		int num20 = default(int);
		int num36 = default(int);
		UniqueSkill randomUniqueSkill = default(UniqueSkill);
		int num34 = default(int);
		int num35 = default(int);
		int a5 = default(int);
		int a6 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		Skill randomSkill = default(Skill);
		int num25 = default(int);
		int num6 = default(int);
		int num37 = default(int);
		int num38 = default(int);
		InternalSkill randomInternalSkill2 = default(InternalSkill);
		int num61 = default(int);
		int num57 = default(int);
		int round12 = default(int);
		int round11 = default(int);
		UniqueSkill randomUniqueSkill2 = default(UniqueSkill);
		int round6 = default(int);
		InternalSkill randomInternalSkill = default(InternalSkill);
		int num45 = default(int);
		int num46 = default(int);
		int round = default(int);
		Aoyi randomAoyi2 = default(Aoyi);
		int round5 = default(int);
		int num84 = default(int);
		int num93 = default(int);
		int round4 = default(int);
		string text4 = default(string);
		int round8 = default(int);
		int num26 = default(int);
		int num27 = default(int);
		float startSkillHard = default(float);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x2A13C0F9)) % 201)
			{
			case 79u:
				break;
			case 127u:
			{
				int num82;
				int num83;
				if (Name == global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3282273608u))
				{
					num82 = 1535989264;
					num83 = num82;
				}
				else
				{
					num82 = 1061818369;
					num83 = num82;
				}
				num2 = num82 ^ ((int)num3 * -1966978848);
				continue;
			}
			case 0u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3860053141u), randomAoyi.Name, Math.Round((decimal)Tools.GetRandom(num30, num31), 2, MidpointRounding.AwayFromZero), Math.Round((decimal)Tools.GetRandom(10.0, 20.0), 2, MidpointRounding.AwayFromZero));
				num2 = ((int)num3 * -514910119) ^ 0x14C8151C;
				continue;
			case 50u:
			{
				int num53;
				int num54;
				if (num == 7)
				{
					num53 = 452340654;
					num54 = num53;
				}
				else
				{
					num53 = 946963720;
					num54 = num53;
				}
				num2 = num53 ^ (int)(num3 * 1372928080);
				continue;
			}
			case 82u:
			{
				int num78;
				int num79;
				if (!flag)
				{
					num78 = -1278300580;
					num79 = num78;
				}
				else
				{
					num78 = -851885360;
					num79 = num78;
				}
				num2 = num78 ^ (int)(num3 * 485933960);
				continue;
			}
			case 149u:
			{
				triggersXml = CommonSettings.GetTriggersXml();
				int num70;
				int num71;
				if (!triggersXml)
				{
					num70 = -2103626717;
					num71 = num70;
				}
				else
				{
					num70 = -604135187;
					num71 = num70;
				}
				num2 = num70 ^ ((int)num3 * -1883679435);
				continue;
			}
			case 88u:
				trigger.ArgvsString = (Tools.GetRandomInt(7, 10) + (int)num58).ToString();
				num2 = 1040254255;
				continue;
			case 137u:
				round9 = RuntimeData.Instance.Round;
				num2 = 841227422;
				continue;
			case 163u:
				goto IL_0494;
			case 70u:
			{
				int num14;
				int num15;
				if (!flag)
				{
					num14 = 565131589;
					num15 = num14;
				}
				else
				{
					num14 = 2120652161;
					num15 = num14;
				}
				num2 = num14 ^ (int)(num3 * 546136278);
				continue;
			}
			case 130u:
				trigger.ArgvsString = Math.Round((decimal)Tools.GetRandom((double)num * 0.5, num), 2, MidpointRounding.AwayFromZero).ToString();
				num2 = ((int)num3 * -241306069) ^ 0x1B2C0386;
				continue;
			case 76u:
				return trigger;
			case 165u:
				return trigger;
			case 122u:
				startSkillHard2 = randomAoyi.GetStartSkillHard();
				num2 = ((int)num3 * -1192181544) ^ 0x7577FF10;
				continue;
			case 115u:
				return trigger;
			case 160u:
				trigger = new Trigger();
				num2 = 72658616;
				continue;
			case 107u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3202622147u), Tools.GetRandomInt(a4, b4), Tools.GetRandomInt(1, num + 2));
				num2 = 1405527338;
				continue;
			case 182u:
				num2 = (int)(num3 * 1558780972) ^ -50944001;
				continue;
			case 106u:
			{
				int num68;
				int num69;
				if (flag)
				{
					num68 = 1400922630;
					num69 = num68;
				}
				else
				{
					num68 = 559304977;
					num69 = num68;
				}
				num2 = num68 ^ (int)(num3 * 932363385);
				continue;
			}
			case 159u:
			{
				int round10 = RuntimeData.Instance.Round;
				a3 = num * (1 + round10 * 2);
				b3 = num * 2 * (1 + round10 * 2) + Tools.GetRandomInt(1, round10 * 2);
				int num51;
				int num52;
				if (flag)
				{
					num51 = -1784853528;
					num52 = num51;
				}
				else
				{
					num51 = -507426423;
					num52 = num51;
				}
				num2 = num51 ^ ((int)num3 * -915494204);
				continue;
			}
			case 34u:
				num = 9;
				num2 = ((int)num3 * -401129004) ^ 0x440208FA;
				continue;
			case 193u:
				round7 = RuntimeData.Instance.Round;
				num2 = ((int)num3 * -805773142) ^ -98496088;
				continue;
			case 200u:
				b2 = (int)(20.0 + 3.0 * (double)round3);
				num2 = ((int)num3 * -425000203) ^ 0x63CE20EA;
				continue;
			case 140u:
				trigger.ArgvsString = _200B_206F_206A_202C_206B_206F_206A_206D_200E_202B_206A_206B_206D_202A_200F_206C_200F_202D_200D_206B_202A_200F_200D_202A_202C_206A_202C_206D_206A_206B_202E_200E_206A_200C_200C_206D_206C_202A_202B_202C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1681462778u), (object)text3, (object)Tools.GetRandomInt(a2, b2));
				num2 = ((int)num3 * -998329757) ^ -282397634;
				continue;
			case 33u:
			{
				int num12;
				int num13;
				if (flag)
				{
					num12 = -278537184;
					num13 = num12;
				}
				else
				{
					num12 = -1361434937;
					num13 = num12;
				}
				num2 = num12 ^ ((int)num3 * -1002062206);
				continue;
			}
			case 131u:
				text2 = array[num9];
				a = (int)((double)num * ((double)(round3 + 3) * 100.0)) + num * 1000;
				b = (int)((double)num * ((double)(round3 + 3) * 150.0)) + num * 1500;
				num2 = ((int)num3 * -1917176661) ^ -997048927;
				continue;
			case 93u:
				goto IL_0730;
			case 185u:
				text = array[num9];
				num2 = 700478426;
				continue;
			case 81u:
				goto IL_076c;
			case 27u:
				num30 = (int)(6f * ((float)(round7 + 3) / (startSkillHard2 / 2f + 1f)));
				num31 = (int)(12f * ((float)(round7 + 4) / (startSkillHard2 / 2f + 1f)));
				num2 = (int)(num3 * 1430422331) ^ -617388526;
				continue;
			case 111u:
				round2 = RuntimeData.Instance.Round;
				num2 = ((int)num3 * -186043736) ^ -788770289;
				continue;
			case 151u:
				return trigger;
			case 71u:
				trigger = GenerateItemTriggerFromXml(trigger);
				num2 = (int)((num3 * 451101068) ^ 0x47D7454D);
				continue;
			case 13u:
			{
				int num104;
				int num105;
				if (num >= 100)
				{
					num104 = 151711580;
					num105 = num104;
				}
				else
				{
					num104 = 774314709;
					num105 = num104;
				}
				num2 = num104 ^ (int)(num3 * 1168897229);
				continue;
			}
			case 31u:
				trigger.ArgvsString = _200B_206F_206A_202C_206B_206F_206A_206D_200E_202B_206A_206B_206D_202A_200F_206C_200F_202D_200D_206B_202A_200F_200D_202A_202C_206A_202C_206D_206A_206B_202E_200E_206A_200C_200C_206D_206C_202A_202B_202C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1384191244u), (object)randomSkill2.Name, (object)Tools.GetRandomInt(num20, num36));
				num2 = 1554397770;
				continue;
			case 66u:
				trigger.ArgvsString = Math.Round((decimal)Tools.GetRandom(1.0, 5.0), 2, MidpointRounding.AwayFromZero).ToString();
				num2 = (int)((num3 * 722068229) ^ 0x68A9E6F2);
				continue;
			case 98u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1681462778u), randomUniqueSkill.Name, Tools.GetRandomInt(num34, num35));
				num2 = 643728695;
				continue;
			case 194u:
			{
				int b6 = (int)((double)num * ((double)(round3 + 3) / 3.0)) + num * 4;
				trigger.ArgvsString = _200B_206F_206A_202C_206B_206F_206A_206D_200E_202B_206A_206B_206D_202A_200F_206C_200F_202D_200D_206B_202A_200F_200D_202A_202C_206A_202C_206D_206A_206B_202E_200E_206A_200C_200C_206D_206C_202A_202B_202C_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(97255320u), (object)text, (object)Tools.GetRandomInt(a5, b6));
				num2 = (int)(num3 * 2039105956) ^ -578844716;
				continue;
			}
			case 198u:
				num2 = ((int)num3 * -89999731) ^ 0x2E9E5429;
				continue;
			case 9u:
				array = _200E_200C_206E_200B_200B_200F_202A_206D_202A_202B_206F_200F_202C_202E_202C_202E_200E_202A_206E_206E_206B_200C_202A_200C_202A_206D_200C_206F_206F_202A_206B_200C_202D_206E_200C_202E_206D_206C_202D_202C_202E(_202C_202E_206C_200E_200D_206B_206B_202D_206C_200E_206B_206E_206F_200C_202D_200F_202B_200B_200E_200C_202C_206B_206D_206A_200F_202E_202E_206F_202B_200B_200F_202B_202E_202D_206D_206C_206F_206A_206D_202C_202E(ResourceStrings.ResStrings[583], global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2471904275u), ResourceStrings.ResStrings[1029]), new char[1] { '#' });
				num2 = ((int)num3 * -1262805443) ^ -1462641989;
				continue;
			case 56u:
				a6 = (int)((double)num * ((double)(round3 + 3) * 33.0)) + num * 100;
				num2 = ((int)num3 * -1862435163) ^ -1186484948;
				continue;
			case 80u:
				return trigger;
			case 64u:
				trigger.ArgvsString = Tools.GetRandomInt(5, 9).ToString();
				num2 = 426738092;
				continue;
			case 138u:
				num = 10;
				num2 = ((int)num3 * -352874549) ^ -1700997786;
				continue;
			case 126u:
				num2 = (int)((num3 * 1911526921) ^ 0x68BC77FD);
				continue;
			case 89u:
			{
				int round13 = RuntimeData.Instance.Round;
				num4 = (int)(5.0 + 4.0 * (double)round13 * 0.85);
				num5 = (int)(5.0 + 4.0 * (double)round13);
				num2 = 1781868982;
				continue;
			}
			case 59u:
				return trigger;
			case 178u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(959027613u), randomSkill.Name, Math.Round((decimal)Tools.GetRandom(num25, num6), 2, MidpointRounding.AwayFromZero));
				num2 = ((int)num3 * -44774472) ^ -54803593;
				continue;
			case 61u:
				num2 = (int)(num3 * 859242280) ^ -769504859;
				continue;
			case 8u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2853782832u), randomAoyi.Name, Tools.GetRandomInt(num30, num31), Tools.GetRandomInt(10, 20));
				num2 = 1039906876;
				continue;
			case 49u:
			{
				int num87;
				int num88;
				if (_200F_206F_202E_206D_206B_206B_206C_200F_202D_202C_202E_200F_202B_206C_200F_200E_206B_202A_206D_206D_200E_200B_200E_200C_206B_206B_206B_200C_202C_202B_202B_206C_206A_200E_206B_206E_202A_206C_206E_202B_202E(Name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3226220175u)))
				{
					num87 = 374874654;
					num88 = num87;
				}
				else
				{
					num87 = 1318967978;
					num88 = num87;
				}
				num2 = num87 ^ (int)(num3 * 1829034928);
				continue;
			}
			case 74u:
				goto IL_0b53;
			case 192u:
				return trigger;
			case 1u:
				trigger.ArgvsString = _200B_206F_206A_202C_206B_206F_206A_206D_200E_202B_206A_206B_206D_202A_200F_206C_200F_202D_200D_206B_202A_200F_200D_202A_202C_206A_202C_206D_206A_206B_202E_200E_206A_200C_200C_206D_206C_202A_202B_202C_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3202622147u), (object)text2, (object)Tools.GetRandomInt(a, b));
				num2 = ((int)num3 * -922057192) ^ 0x7905B251;
				continue;
			case 174u:
			{
				int num76;
				int num77;
				if (num9 > 1)
				{
					num76 = 2066999938;
					num77 = num76;
				}
				else
				{
					num76 = 535082515;
					num77 = num76;
				}
				num2 = num76 ^ ((int)num3 * -640701507);
				continue;
			}
			case 157u:
			{
				int num72;
				int num73;
				if (num >= 90)
				{
					num72 = -17049068;
					num73 = num72;
				}
				else
				{
					num72 = -1920790739;
					num73 = num72;
				}
				num2 = num72 ^ ((int)num3 * -325102789);
				continue;
			}
			case 195u:
				trigger.ArgvsString = Math.Round((decimal)Tools.GetRandom(5.0, 8.0), 2, MidpointRounding.AwayFromZero).ToString();
				num2 = ((int)num3 * -330709806) ^ -1620192787;
				continue;
			case 167u:
				trigger.ArgvsString = Math.Round((decimal)Tools.GetRandom(5.0, 7.0), 2, MidpointRounding.AwayFromZero).ToString();
				num2 = ((int)num3 * -557082965) ^ 0x67BD4945;
				continue;
			case 24u:
				num37 = (int)((double)num * 0.4 * (1.0 + (double)round9 * 0.7));
				num38 = (int)((double)num * 0.6 * (1.0 + (double)round9 * 0.7));
				num2 = (int)((num3 * 1320322129) ^ 0x351FE81B);
				continue;
			case 176u:
				num2 = (int)(num3 * 1468199394) ^ -2024557135;
				continue;
			case 90u:
				return trigger;
			case 91u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1681462778u), randomInternalSkill2.Name, Math.Round((decimal)Tools.GetRandom(num61, num57), 2, MidpointRounding.AwayFromZero));
				num2 = (int)((num3 * 1019266941) ^ 0x5A93910E);
				continue;
			case 173u:
				a5 = (int)((double)num * ((double)(round3 + 3) / 4.0)) + num * 2;
				num2 = (int)(num3 * 1512042120) ^ -1610089685;
				continue;
			case 136u:
				randomSkill = GetRandomSkill(num - 1, num + 4);
				num2 = (int)((num3 * 1023192171) ^ 0x3825FD5F);
				continue;
			case 150u:
				randomInternalSkill2 = GetRandomInternalSkill(num - 1, num + 4);
				num61 = (int)(3f * ((float)(round12 + 3) / (randomInternalSkill2.Hard / 2f + 1f)));
				num2 = (int)((num3 * 1038538685) ^ 0x10901E92);
				continue;
			case 37u:
				num2 = ((int)num3 * -897163574) ^ -1780976426;
				continue;
			case 87u:
				goto IL_0e02;
			case 15u:
				round11 = RuntimeData.Instance.Round;
				a4 = num * (1 + round11 * 2);
				num2 = ((int)num3 * -186444830) ^ -1478646967;
				continue;
			case 21u:
				randomUniqueSkill2 = GetRandomUniqueSkill(num + 2, num + 9);
				num2 = (int)(num3 * 1648438795) ^ -561136210;
				continue;
			case 23u:
			{
				round6 = RuntimeData.Instance.Round;
				int num47;
				int num48;
				if (num == 7)
				{
					num47 = -681962621;
					num48 = num47;
				}
				else
				{
					num47 = -567916596;
					num48 = num47;
				}
				num2 = num47 ^ ((int)num3 * -1700617761);
				continue;
			}
			case 170u:
				trigger.ArgvsString = _200B_206F_206A_202C_206B_206F_206A_206D_200E_202B_206A_206B_206D_202A_200F_206C_200F_202D_200D_206B_202A_200F_200D_202A_202C_206A_202C_206D_206A_206B_202E_200E_206A_200C_200C_206D_206C_202A_202B_202C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1384191244u), (object)randomInternalSkill.Name, (object)Tools.GetRandomInt(num45, num46));
				num2 = 89533161;
				continue;
			case 86u:
			{
				int num41;
				int num42;
				if (flag)
				{
					num41 = 620723731;
					num42 = num41;
				}
				else
				{
					num41 = 994850720;
					num42 = num41;
				}
				num2 = num41 ^ ((int)num3 * -2113281693);
				continue;
			}
			case 83u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1384191244u), randomUniqueSkill.Name, Math.Round((decimal)Tools.GetRandom(num34, num35), 2, MidpointRounding.AwayFromZero));
				num2 = ((int)num3 * -1715931278) ^ 0x3C236799;
				continue;
			case 166u:
				trigger.Name = Name;
				num2 = ((int)num3 * -697912031) ^ -1769635462;
				continue;
			case 102u:
				trigger.ArgvsString = _200B_206F_206A_202C_206B_206F_206A_206D_200E_202B_206A_206B_206D_202A_200F_206C_200F_202D_200D_206B_202A_200F_200D_202A_202C_206A_202C_206D_206A_206B_202E_200E_206A_200C_200C_206D_206C_202A_202B_202C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1681462778u), (object)randomSkill2.Name, (object)_202C_200C_200B_206E_200C_206B_200F_206F_206B_200D_200B_206A_202E_200F_206A_200C_206B_202C_206D_202B_202C_206F_202D_200F_206E_200F_200F_206B_200F_206A_202E_202D_206D_206F_206E_200D_206E_206A_202B_200E_202E((decimal)Tools.GetRandom(num20, num36), 2, MidpointRounding.AwayFromZero));
				num2 = (int)((num3 * 1451077763) ^ 0x7059A4B6);
				continue;
			case 51u:
			{
				int num23;
				int num24;
				if (flag)
				{
					num23 = 949547207;
					num24 = num23;
				}
				else
				{
					num23 = 84276768;
					num24 = num23;
				}
				num2 = num23 ^ ((int)num3 * -918655927);
				continue;
			}
			case 108u:
				num2 = ((int)num3 * -86353099) ^ -1526500395;
				continue;
			case 191u:
				num25 = (int)(4f * ((float)(round + 3) / (randomSkill.Hard / 2f + 1f)));
				num2 = ((int)num3 * -1430243408) ^ 0x76763C98;
				continue;
			case 132u:
				return trigger;
			case 146u:
				goto IL_102d;
			case 135u:
				num2 = ((int)num3 * -531468064) ^ -498312663;
				continue;
			case 161u:
			{
				int num16;
				int num17;
				if (!(Name == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1016810967u)))
				{
					num16 = 2072920315;
					num17 = num16;
				}
				else
				{
					num16 = 135472340;
					num17 = num16;
				}
				num2 = num16 ^ (int)(num3 * 301675311);
				continue;
			}
			case 67u:
				round = RuntimeData.Instance.Round;
				num2 = ((int)num3 * -1582206327) ^ 0x3277584C;
				continue;
			case 141u:
			{
				int num108;
				int num109;
				if (flag)
				{
					num108 = -1633616604;
					num109 = num108;
				}
				else
				{
					num108 = -183498869;
					num109 = num108;
				}
				num2 = num108 ^ (int)(num3 * 801519793);
				continue;
			}
			case 118u:
				goto IL_10de;
			case 112u:
			{
				int num106;
				int num107;
				if (Name == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3280711958u))
				{
					num106 = -1320378828;
					num107 = num106;
				}
				else
				{
					num106 = -1491053663;
					num107 = num106;
				}
				num2 = num106 ^ (int)(num3 * 66968781);
				continue;
			}
			case 162u:
			{
				int num102;
				int num103;
				if (trigger != null)
				{
					num102 = 1655405078;
					num103 = num102;
				}
				else
				{
					num102 = 1549468675;
					num103 = num102;
				}
				num2 = num102 ^ (int)(num3 * 263254239);
				continue;
			}
			case 97u:
				array = _200E_200C_206E_200B_200B_200F_202A_206D_202A_202B_206F_200F_202C_202E_202C_202E_200E_202A_206E_206E_206B_200C_202A_200C_202A_206D_200C_206F_206F_202A_206B_200C_202D_206E_200C_202E_206D_206C_202D_202C_202E(ResourceStrings.ResStrings[583], new char[1] { '#' });
				num2 = 562098280;
				continue;
			case 125u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(959027613u), Tools.GetRandomInt(a4, b4), Math.Round((decimal)Tools.GetRandom(1.0, num + 2), 2, MidpointRounding.AwayFromZero));
				num2 = ((int)num3 * -1989252862) ^ -1761078520;
				continue;
			case 60u:
				randomAoyi2 = GetRandomAoyi(num, num + 5);
				num2 = 709441837;
				continue;
			case 57u:
				num35 = (int)(10f * ((float)(round5 + 4) / (randomUniqueSkill.Hard / 2f + 1f)));
				num2 = ((int)num3 * -529115494) ^ -1239352827;
				continue;
			case 172u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3202622147u), Tools.GetRandomInt(a3, b3), Math.Round((decimal)Tools.GetRandom(1.0, num), 2, MidpointRounding.AwayFromZero));
				num2 = (int)(num3 * 1732841398) ^ -1177877028;
				continue;
			case 180u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(959027613u), randomUniqueSkill2.Name, Math.Round((decimal)Tools.GetRandom(num84, num93), 2, MidpointRounding.AwayFromZero));
				num2 = (int)((num3 * 1676190521) ^ 0x47412A42);
				continue;
			case 133u:
				num36 = (int)(22f * ((float)(round4 + 3) / (randomSkill2.Hard / 2f + 1f)));
				num2 = (int)((num3 * 1048504708) ^ 0x6F125A64);
				continue;
			case 19u:
			{
				int num100;
				int num101;
				if (!(Name == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3280711958u)))
				{
					num100 = -92145391;
					num101 = num100;
				}
				else
				{
					num100 = -1067767728;
					num101 = num100;
				}
				num2 = num100 ^ ((int)num3 * -944971592);
				continue;
			}
			case 38u:
				return trigger;
			case 121u:
				goto IL_1345;
			case 5u:
				return trigger;
			case 189u:
			{
				int num98;
				int num99;
				if (trigger != null)
				{
					num98 = 1584284815;
					num99 = num98;
				}
				else
				{
					num98 = 503731653;
					num99 = num98;
				}
				num2 = num98 ^ (int)(num3 * 716569741);
				continue;
			}
			case 22u:
				num2 = (int)((num3 * 1187486459) ^ 0x568308F3);
				continue;
			case 153u:
				b4 = num * 2 * (1 + round11 * 2) + Tools.GetRandomInt(0, round11);
				num2 = ((int)num3 * -340270204) ^ -850641290;
				continue;
			case 96u:
			{
				int num96;
				int num97;
				if (!string.IsNullOrEmpty(trigger.ArgvsString))
				{
					num96 = -1274825568;
					num97 = num96;
				}
				else
				{
					num96 = -1014035379;
					num97 = num96;
				}
				num2 = num96 ^ ((int)num3 * -1139470754);
				continue;
			}
			case 144u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(97255320u), randomSkill.Name, Tools.GetRandomInt(num25, num6));
				num2 = 224114551;
				continue;
			case 139u:
			{
				int num94;
				int num95;
				if (Name == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(7860661u))
				{
					num94 = 1771289604;
					num95 = num94;
				}
				else
				{
					num94 = 1974644921;
					num95 = num94;
				}
				num2 = num94 ^ ((int)num3 * -1170040934);
				continue;
			}
			case 169u:
				goto IL_1455;
			case 187u:
				num2 = (int)(num3 * 234261776) ^ -26418305;
				continue;
			case 110u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1842574002u), Tools.GetRandomInt(num37, num38));
				num2 = 747595753;
				continue;
			case 105u:
				goto IL_14ad;
			case 100u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3202622147u), randomInternalSkill2.Name, Tools.GetRandomInt(num61, num57));
				num2 = 1586555517;
				continue;
			case 45u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1681462778u), randomUniqueSkill2.Name, Tools.GetRandomInt(num84, num93));
				num2 = 102590024;
				continue;
			case 158u:
				num = 8;
				num2 = (int)((num3 * 744775083) ^ 0x2F18093E);
				continue;
			case 114u:
				return trigger;
			case 78u:
				return trigger;
			case 20u:
				num2 = (int)((num3 * 414005818) ^ 0x58D26221);
				continue;
			case 32u:
			{
				int b5 = (int)((double)num * ((double)(round3 + 3) * 50.0)) + num * 150;
				trigger.ArgvsString = _200B_206F_206A_202C_206B_206F_206A_206D_200E_202B_206A_206B_206D_202A_200F_206C_200F_202D_200D_206B_202A_200F_200D_202A_202C_206A_202C_206D_206A_206B_202E_200E_206A_200C_200C_206D_206C_202A_202B_202C_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3202622147u), (object)text4, (object)Tools.GetRandomInt(a6, b5));
				num2 = (int)(num3 * 1648954136) ^ -123581794;
				continue;
			}
			case 156u:
				text4 = array[num9];
				num2 = 25592662;
				continue;
			case 48u:
				trigger.ArgvsString = Tools.GetRandomInt((int)((double)num * 0.5 + 0.5), num).ToString();
				num2 = 340555156;
				continue;
			case 77u:
				num2 = (int)((num3 * 1233815170) ^ 0x7264B81E);
				continue;
			case 10u:
				randomAoyi = GetRandomAoyi(num - 1, num + 4);
				num2 = ((int)num3 * -1340028444) ^ -1016397047;
				continue;
			case 41u:
				trigger.ArgvsString = Tools.GetRandomInt(1, 2).ToString();
				num2 = ((int)num3 * -1605751393) ^ 0x1153F592;
				continue;
			case 123u:
				goto IL_1684;
			case 62u:
				trigger.ArgvsString = _200B_206F_206A_202C_206B_206F_206A_206D_200E_202B_206A_206B_206D_202A_200F_206C_200F_202D_200D_206B_202A_200F_200D_202A_202C_206A_202C_206D_206A_206B_202E_200E_206A_200C_200C_206D_206C_202A_202B_202C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1681462778u), (object)randomInternalSkill.Name, (object)_202C_200C_200B_206E_200C_206B_200F_206F_206B_200D_200B_206A_202E_200F_206A_200C_206B_202C_206D_202B_202C_206F_202D_200F_206E_200F_200F_206B_200F_206A_202E_202D_206D_206F_206E_200D_206E_206A_202B_200E_202E((decimal)Tools.GetRandom(num45, num46), 2, MidpointRounding.AwayFromZero));
				num2 = (int)(num3 * 1632846686) ^ -1849604620;
				continue;
			case 53u:
				round4 = RuntimeData.Instance.Round;
				num2 = ((int)num3 * -341131985) ^ 0xD0EF265;
				continue;
			case 4u:
				randomAoyi2 = GetRandomAoyi(num + 2, num + 9);
				num2 = (int)(num3 * 96823020) ^ -1083840980;
				continue;
			case 109u:
				trigger.ArgvsString = Math.Round((decimal)(Tools.GetRandom(7.0, 10.0) + num58), 2, MidpointRounding.AwayFromZero).ToString();
				num2 = ((int)num3 * -1503006102) ^ 0x789F5521;
				continue;
			case 199u:
				flag = Tools.ProbabilityTest(0.15);
				num2 = 946437584;
				continue;
			case 30u:
				return trigger;
			case 155u:
				num93 = (int)(16f * ((float)(round8 + 3) / (randomUniqueSkill2.Hard / 2f + 1f)));
				num2 = (int)((num3 * 1082778530) ^ 0x8144FCA);
				continue;
			case 40u:
				trigger = GenerateItemTriggerFromXml(trigger);
				num2 = (int)((num3 * 1273058578) ^ 0x15993245);
				continue;
			case 148u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3860053141u), randomAoyi2.Name, _202C_200C_200B_206E_200C_206B_200F_206F_206B_200D_200B_206A_202E_200F_206A_200C_206B_202C_206D_202B_202C_206F_202D_200F_206E_200F_200F_206B_200F_206A_202E_202D_206D_206F_206E_200D_206E_206A_202B_200E_202E((decimal)Tools.GetRandom(num26, num27), 2, MidpointRounding.AwayFromZero) + 5m, Math.Round((decimal)Tools.GetRandom(14.0, 18.0), 2, MidpointRounding.AwayFromZero));
				num2 = (int)((num3 * 911888653) ^ 0x3A407979);
				continue;
			case 11u:
				num = 1;
				num2 = (int)((num3 * 2045338674) ^ 0x1DCE27EF);
				continue;
			case 113u:
				goto IL_188d;
			case 181u:
			{
				int num91;
				int num92;
				if (flag)
				{
					num91 = 1451493060;
					num92 = num91;
				}
				else
				{
					num91 = 1316985520;
					num92 = num91;
				}
				num2 = num91 ^ (int)(num3 * 203958756);
				continue;
			}
			case 39u:
				a2 = (int)(20.0 + 3.0 * (double)round3 * 0.85);
				num2 = ((int)num3 * -1738668974) ^ 0x8B01E44;
				continue;
			case 104u:
			{
				int num89;
				int num90;
				if (Name == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1740975116u))
				{
					num89 = -1415944536;
					num90 = num89;
				}
				else
				{
					num89 = -1503903352;
					num90 = num89;
				}
				num2 = num89 ^ (int)(num3 * 1561643017);
				continue;
			}
			case 92u:
				goto IL_1931;
			case 99u:
				trigger.ArgvsString = Math.Round((decimal)Tools.GetRandom(5.0, 9.0), 2, MidpointRounding.AwayFromZero).ToString();
				num2 = ((int)num3 * -513195544) ^ -423337523;
				continue;
			case 145u:
			{
				int num85;
				int num86;
				if (_200F_206F_202E_206D_206B_206B_206C_200F_202D_202C_202E_200F_202B_206C_200F_200E_206B_202A_206D_206D_200E_200B_200E_200C_206B_206B_206B_200C_202C_202B_202B_206C_206A_200E_206B_206E_202A_206C_206E_202B_202E(Name, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3235781248u)))
				{
					num85 = 1793145074;
					num86 = num85;
				}
				else
				{
					num85 = 1347048684;
					num86 = num85;
				}
				num2 = num85 ^ (int)(num3 * 1525365565);
				continue;
			}
			case 128u:
				num9 = Tools.GetRandomInt(0, array.Length - 1);
				num2 = 25150573;
				continue;
			case 52u:
				randomUniqueSkill2 = GetRandomUniqueSkill(num, num + 5);
				num2 = 975044577;
				continue;
			case 58u:
				goto IL_19f2;
			case 168u:
				num84 = (int)(14f * ((float)(round8 + 3) / (randomUniqueSkill2.Hard / 2f + 1f)));
				num2 = 1313262412;
				continue;
			case 44u:
				return trigger;
			case 16u:
				return trigger;
			case 197u:
			{
				int num80;
				int num81;
				if (CommonSettings.MOD_KEY() < 0)
				{
					num80 = 602764531;
					num81 = num80;
				}
				else
				{
					num80 = 197099685;
					num81 = num80;
				}
				num2 = num80 ^ (int)(num3 * 2123074901);
				continue;
			}
			case 129u:
			{
				int num74;
				int num75;
				if (flag)
				{
					num74 = -249062726;
					num75 = num74;
				}
				else
				{
					num74 = -1170016360;
					num75 = num74;
				}
				num2 = num74 ^ (int)(num3 * 731713862);
				continue;
			}
			case 26u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3860053141u), randomAoyi2.Name, Tools.GetRandomInt(num26, num27) + 5, Tools.GetRandomInt(14, 18));
				num2 = 1914510380;
				continue;
			case 42u:
			{
				int num66;
				int num67;
				if (flag)
				{
					num66 = -1362694447;
					num67 = num66;
				}
				else
				{
					num66 = -715504590;
					num67 = num66;
				}
				num2 = num66 ^ ((int)num3 * -754340785);
				continue;
			}
			case 175u:
			{
				int num64;
				int num65;
				if (num > 3)
				{
					num64 = 921733578;
					num65 = num64;
				}
				else
				{
					num64 = 1166642488;
					num65 = num64;
				}
				num2 = num64 ^ ((int)num3 * -649843839);
				continue;
			}
			case 120u:
				randomUniqueSkill = GetRandomUniqueSkill(num - 1, num + 4);
				num34 = (int)(5f * ((float)(round5 + 3) / (randomUniqueSkill.Hard / 2f + 1f)));
				num2 = (int)(num3 * 978444449) ^ -1917991523;
				continue;
			case 14u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1384191244u), Tools.GetRandomInt(a3, b3), Tools.GetRandomInt(1, num));
				num2 = 1951012447;
				continue;
			case 134u:
				startSkillHard = randomAoyi2.GetStartSkillHard();
				num2 = 1053269883;
				continue;
			case 171u:
			{
				int num62;
				int num63;
				if (!flag)
				{
					num62 = 148087072;
					num63 = num62;
				}
				else
				{
					num62 = 459373989;
					num63 = num62;
				}
				num2 = num62 ^ ((int)num3 * -2020639771);
				continue;
			}
			case 72u:
				randomSkill2 = GetRandomSkill(num + 2, num + 9);
				num2 = (int)(num3 * 2117275254) ^ -326215232;
				continue;
			case 183u:
			{
				round3 = RuntimeData.Instance.Round;
				int num59;
				int num60;
				if (CommonSettings.MOD_KEY() == 0)
				{
					num59 = 421985924;
					num60 = num59;
				}
				else
				{
					num59 = 2025842428;
					num60 = num59;
				}
				num2 = num59 ^ (int)(num3 * 2136202928);
				continue;
			}
			case 69u:
				goto IL_1c39;
			case 124u:
				round12 = RuntimeData.Instance.Round;
				num2 = (int)(num3 * 1341454387) ^ -831070575;
				continue;
			case 179u:
				num58 = Math.Min(100.0, (double)(itemLevel - 100) * 0.1);
				num2 = 2091665005;
				continue;
			case 164u:
				num2 = ((int)num3 * -1562848851) ^ -2125141277;
				continue;
			case 63u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3572822551u), Tools.GetRandomInt(num4, num5));
				num2 = 114894997;
				continue;
			case 101u:
				num2 = ((int)num3 * -1973229392) ^ 0x70A18E6F;
				continue;
			case 73u:
				return trigger;
			case 117u:
				num57 = (int)(8f * ((float)(round12 + 4) / (randomInternalSkill2.Hard / 2f + 1f)));
				num2 = (int)((num3 * 1586271937) ^ 0x7B5103AC);
				continue;
			case 28u:
				randomSkill2 = GetRandomSkill(num, num + 5);
				num2 = 190092475;
				continue;
			case 46u:
			{
				int num55;
				int num56;
				if (flag)
				{
					num55 = -566927101;
					num56 = num55;
				}
				else
				{
					num55 = -1823548185;
					num56 = num55;
				}
				num2 = num55 ^ ((int)num3 * -283504504);
				continue;
			}
			case 35u:
				trigger.ArgvsString = Tools.GetRandomInt(1, 5).ToString();
				num2 = 1094451259;
				continue;
			case 143u:
				randomInternalSkill = GetRandomInternalSkill(num + 2, num + 9);
				num2 = ((int)num3 * -382440865) ^ -1043998277;
				continue;
			case 142u:
				goto IL_1dc5;
			case 147u:
				num2 = (int)(num3 * 22092504) ^ -85890558;
				continue;
			case 119u:
				return trigger;
			case 152u:
			{
				int num49;
				int num50;
				if (!_200B_202D_200B_206A_202C_200B_200B_200D_200B_200E_202D_206F_202D_200D_202C_200E_200B_200B_206E_202B_206D_202A_200E_200D_206A_200E_200F_206A_206D_206A_206B_200F_202C_206F_206B_206A_200B_200E_200E_206D_202E(trigger.ArgvsString))
				{
					num49 = -1083224912;
					num50 = num49;
				}
				else
				{
					num49 = -134706249;
					num50 = num49;
				}
				num2 = num49 ^ ((int)num3 * -198805685);
				continue;
			}
			case 186u:
				num9 = Tools.GetRandomInt(2, array.Length - 1);
				text3 = array[num9];
				num2 = (int)((num3 * 943107214) ^ 0x32C239B1);
				continue;
			case 3u:
				num2 = ((int)num3 * -780905504) ^ -331624694;
				continue;
			case 17u:
				goto IL_1ea4;
			case 84u:
			{
				round8 = RuntimeData.Instance.Round;
				int num43;
				int num44;
				if (num == 7)
				{
					num43 = 405694041;
					num44 = num43;
				}
				else
				{
					num43 = 1436302884;
					num44 = num43;
				}
				num2 = num43 ^ ((int)num3 * -1708066701);
				continue;
			}
			case 36u:
			{
				int num39;
				int num40;
				if (Name == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1168936690u))
				{
					num39 = 1620832567;
					num40 = num39;
				}
				else
				{
					num39 = 1240251462;
					num40 = num39;
				}
				num2 = num39 ^ (int)(num3 * 1260672045);
				continue;
			}
			case 6u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3981192675u), Math.Round((decimal)Tools.GetRandom(num37, num38), 2, MidpointRounding.AwayFromZero));
				num2 = ((int)num3 * -413269879) ^ -978877405;
				continue;
			case 2u:
				randomInternalSkill = GetRandomInternalSkill(num, num + 5);
				num2 = 1150794962;
				continue;
			case 154u:
				goto IL_1f8c;
			case 7u:
			{
				int num32;
				int num33;
				if (!flag)
				{
					num32 = -571579463;
					num33 = num32;
				}
				else
				{
					num32 = -905258529;
					num33 = num32;
				}
				num2 = num32 ^ ((int)num3 * -382305183);
				continue;
			}
			case 184u:
			{
				num26 = (int)(14f * ((float)(round6 + 3) / (startSkillHard / 2f + 1f)));
				num27 = (int)(16f * ((float)(round6 + 3) / (startSkillHard / 2f + 1f)));
				int num28;
				int num29;
				if (flag)
				{
					num28 = 1278708430;
					num29 = num28;
				}
				else
				{
					num28 = 307282617;
					num29 = num28;
				}
				num2 = num28 ^ (int)(num3 * 1230041199);
				continue;
			}
			case 116u:
			{
				int num21;
				int num22;
				if (!(Name == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1740975116u)))
				{
					num21 = -1539553584;
					num22 = num21;
				}
				else
				{
					num21 = -1868121792;
					num22 = num21;
				}
				num2 = num21 ^ (int)(num3 * 501819472);
				continue;
			}
			case 94u:
				return trigger;
			case 95u:
				round5 = RuntimeData.Instance.Round;
				num2 = ((int)num3 * -1419758689) ^ -427378881;
				continue;
			case 29u:
				num20 = (int)(18f * ((float)(round4 + 3) / (randomSkill2.Hard / 2f + 1f)));
				num2 = 734848784;
				continue;
			case 25u:
				trigger.ArgvsString = Tools.GetRandomInt(5, 8).ToString();
				num2 = 1833836677;
				continue;
			case 68u:
			{
				int num18;
				int num19;
				if (num != 7)
				{
					num18 = -507242286;
					num19 = num18;
				}
				else
				{
					num18 = -1889747013;
					num19 = num18;
				}
				num2 = num18 ^ ((int)num3 * -544186656);
				continue;
			}
			case 103u:
				return trigger;
			case 85u:
				goto IL_2112;
			case 190u:
			{
				int num10;
				int num11;
				if (!flag)
				{
					num10 = -256513345;
					num11 = num10;
				}
				else
				{
					num10 = -2071722431;
					num11 = num10;
				}
				num2 = num10 ^ ((int)num3 * -1739934351);
				continue;
			}
			case 12u:
				goto IL_214b;
			case 43u:
			{
				num6 = (int)(8f * ((float)(round + 4) / (randomSkill.Hard / 2f + 1f)));
				int num7;
				int num8;
				if (!flag)
				{
					num7 = 671961129;
					num8 = num7;
				}
				else
				{
					num7 = 196811123;
					num8 = num7;
				}
				num2 = num7 ^ (int)(num3 * 1568598090);
				continue;
			}
			case 54u:
				goto IL_21a5;
			case 188u:
				goto IL_21c4;
			case 177u:
				num2 = ((int)num3 * -706732293) ^ 0x62C7464E;
				continue;
			case 196u:
				goto IL_2202;
			case 75u:
				trigger.ArgvsString = string.Format(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(905711202u), Math.Round((decimal)Tools.GetRandom(num4, num5), 2, MidpointRounding.AwayFromZero));
				num2 = (int)((num3 * 228862912) ^ 0xC472AD5);
				continue;
			case 55u:
				num2 = (int)(num3 * 1870013711) ^ -1630419174;
				continue;
			case 65u:
				trigger.ArgvsString = Tools.GetRandomInt(5, 7).ToString();
				num2 = 1040254255;
				continue;
			case 47u:
				goto IL_22a4;
			default:
				return null;
			}
			break;
			IL_22a4:
			int num110;
			if (CommonSettings.MOD_KEY() == 1)
			{
				num2 = 458119340;
				num110 = num2;
			}
			else
			{
				num2 = 536513070;
				num110 = num2;
			}
			continue;
			IL_1345:
			int num111;
			if (!triggersXml)
			{
				num2 = 1469990553;
				num111 = num2;
			}
			else
			{
				num2 = 1799227399;
				num111 = num2;
			}
			continue;
			IL_1dc5:
			num45 = (int)(8f * ((float)(round2 + 3) / (randomInternalSkill.Hard / 2f + 1f)));
			num46 = (int)(10f * ((float)(round2 + 3) / (randomInternalSkill.Hard / 2f + 1f)));
			int num112;
			if (flag)
			{
				num2 = 1276017125;
				num112 = num2;
			}
			else
			{
				num2 = 1553301503;
				num112 = num2;
			}
			continue;
			IL_2202:
			int num113;
			if (Name == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1686075188u))
			{
				num2 = 655872478;
				num113 = num2;
			}
			else
			{
				num2 = 1823038814;
				num113 = num2;
			}
			continue;
			IL_1684:
			int num114;
			if (Name == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2081569984u))
			{
				num2 = 2107912560;
				num114 = num2;
			}
			else
			{
				num2 = 1325238176;
				num114 = num2;
			}
			continue;
			IL_0494:
			int num115;
			if (num >= 90)
			{
				num2 = 111640483;
				num115 = num2;
			}
			else
			{
				num2 = 792194126;
				num115 = num2;
			}
			continue;
			IL_21c4:
			int num116;
			if (Name == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2050710063u))
			{
				num2 = 563539510;
				num116 = num2;
			}
			else
			{
				num2 = 1190045867;
				num116 = num2;
			}
			continue;
			IL_1c39:
			int num117;
			if (Name == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(862773248u))
			{
				num2 = 1489777968;
				num117 = num2;
			}
			else
			{
				num2 = 254522664;
				num117 = num2;
			}
			continue;
			IL_0b53:
			int num118;
			if (!(Name == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3487093323u)))
			{
				num2 = 1424105620;
				num118 = num2;
			}
			else
			{
				num2 = 51304987;
				num118 = num2;
			}
			continue;
			IL_21a5:
			num9 = 0;
			int num119;
			if (CommonSettings.MOD_KEY() == 1)
			{
				num2 = 1758256266;
				num119 = num2;
			}
			else
			{
				num2 = 900013193;
				num119 = num2;
			}
			continue;
			IL_14ad:
			int num120;
			if (!(Name == global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(380218444u)))
			{
				num2 = 1165512342;
				num120 = num2;
			}
			else
			{
				num2 = 1190057978;
				num120 = num2;
			}
			continue;
			IL_19f2:
			int num121;
			if (_200F_206F_202E_206D_206B_206B_206C_200F_202D_202C_202E_200F_202B_206C_200F_200E_206B_202A_206D_206D_200E_200B_200E_200C_206B_206B_206B_200C_202C_202B_202B_206C_206A_200E_206B_206E_202A_206C_206E_202B_202E(Name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(75814027u)))
			{
				num2 = 1727516758;
				num121 = num2;
			}
			else
			{
				num2 = 276191471;
				num121 = num2;
			}
			continue;
			IL_214b:
			int num122;
			if (num <= 5)
			{
				num2 = 1902787432;
				num122 = num2;
			}
			else
			{
				num2 = 2009397849;
				num122 = num2;
			}
			continue;
			IL_10de:
			int num123;
			if (!(Name == global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1032379924u)))
			{
				num2 = 1054597428;
				num123 = num2;
			}
			else
			{
				num2 = 959501311;
				num123 = num2;
			}
			continue;
			IL_0e02:
			int num124;
			if (!_200F_206F_202E_206D_206B_206B_206C_200F_202D_202C_202E_200F_202B_206C_200F_200E_206B_202A_206D_206D_200E_200B_200E_200C_206B_206B_206B_200C_202C_202B_202B_206C_206A_200E_206B_206E_202A_206C_206E_202B_202E(Name, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1032379924u)))
			{
				num2 = 907563376;
				num124 = num2;
			}
			else
			{
				num2 = 326059093;
				num124 = num2;
			}
			continue;
			IL_2112:
			int num125;
			if (num >= 100)
			{
				num2 = 602794877;
				num125 = num2;
			}
			else
			{
				num2 = 296478922;
				num125 = num2;
			}
			continue;
			IL_1931:
			int num126;
			if (num > 8)
			{
				num2 = 2133002950;
				num126 = num2;
			}
			else
			{
				num2 = 440456560;
				num126 = num2;
			}
			continue;
			IL_1455:
			int num127;
			if (num <= 7)
			{
				num2 = 1158638561;
				num127 = num2;
			}
			else
			{
				num2 = 1855785715;
				num127 = num2;
			}
			continue;
			IL_1f8c:
			int num128;
			if (!(Name == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(395918471u)))
			{
				num2 = 453819098;
				num128 = num2;
			}
			else
			{
				num2 = 68945168;
				num128 = num2;
			}
			continue;
			IL_0730:
			int num129;
			if (!(Name == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3608460132u)))
			{
				num2 = 2112239331;
				num129 = num2;
			}
			else
			{
				num2 = 1027661216;
				num129 = num2;
			}
			continue;
			IL_188d:
			int num130;
			if (num > 9)
			{
				num2 = 1397749408;
				num130 = num2;
			}
			else
			{
				num2 = 1620322520;
				num130 = num2;
			}
			continue;
			IL_1ea4:
			int num131;
			if (Name == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(978355675u))
			{
				num2 = 820732876;
				num131 = num2;
			}
			else
			{
				num2 = 1239678190;
				num131 = num2;
			}
			continue;
			IL_102d:
			int num132;
			if (Name == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1274594443u))
			{
				num2 = 733556241;
				num132 = num2;
			}
			else
			{
				num2 = 1135664240;
				num132 = num2;
			}
		}
		goto IL_0009;
		IL_076c:
		int num133;
		if (num < 8)
		{
			num2 = 1940036179;
			num133 = num2;
		}
		else
		{
			num2 = 1568562844;
			num133 = num2;
		}
		goto IL_000e;
	}

	private Skill GetRandomSkill(float minHard, float maxHard)
	{
		List<Skill> list = new List<Skill>();
		Skill current = default(Skill);
		float num5 = default(float);
		Skill current2 = default(Skill);
		Skill skill = default(Skill);
		int num18 = default(int);
		while (true)
		{
			int num = 1253385408;
			while (true)
			{
				int num19;
				uint num2;
				switch ((num2 = (uint)(num ^ 0x795374A1)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0029;
				default:
					{
						IEnumerator<Skill> enumerator = ResourceManager.GetAll<Skill>().GetEnumerator();
						try
						{
							while (true)
							{
								IL_00cb:
								int num3;
								int num4;
								if (_200F_200F_200E_202C_202B_202D_200B_206B_200B_202C_202B_206E_206C_200B_202C_206F_206C_202D_206B_200D_206A_202E_200F_202D_206B_206B_200D_200D_200F_206B_202A_202D_200B_200E_206B_202A_206B_202C_200D_206C_202E((IEnumerator)enumerator))
								{
									num3 = 785834475;
									num4 = num3;
								}
								else
								{
									num3 = 1079110250;
									num4 = num3;
								}
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ 0x795374A1)) % 9)
									{
									case 0u:
										num3 = 785834475;
										continue;
									default:
										goto end_IL_0052;
									case 8u:
									{
										int num11;
										if (current.Hard >= minHard)
										{
											num3 = 404775406;
											num11 = num3;
										}
										else
										{
											num3 = 1443189901;
											num11 = num3;
										}
										continue;
									}
									case 3u:
									{
										int num7;
										int num8;
										if (current.Hard <= maxHard)
										{
											num7 = -1493060322;
											num8 = num7;
										}
										else
										{
											num7 = -73851467;
											num8 = num7;
										}
										num3 = num7 ^ ((int)num2 * -1753201336);
										continue;
									}
									case 2u:
										break;
									case 7u:
										num5 = current.Hard;
										num3 = (int)((num2 * 1831802208) ^ 0x6E296F6C);
										continue;
									case 1u:
									{
										int num9;
										int num10;
										if (current.Hard >= 100f)
										{
											num9 = 449270074;
											num10 = num9;
										}
										else
										{
											num9 = 865716477;
											num10 = num9;
										}
										num3 = num9 ^ ((int)num2 * -1166897794);
										continue;
									}
									case 4u:
										list.Add(current);
										num3 = ((int)num2 * -1789496576) ^ 0x61ABF18D;
										continue;
									case 5u:
									{
										current = enumerator.Current;
										int num6;
										if (num5 < current.Hard)
										{
											num3 = 1819420500;
											num6 = num3;
										}
										else
										{
											num3 = 1014502060;
											num6 = num3;
										}
										continue;
									}
									case 6u:
										goto end_IL_0052;
									}
									goto IL_00cb;
									continue;
									end_IL_0052:
									break;
								}
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								while (true)
								{
									IL_0176:
									int num12 = 221613160;
									while (true)
									{
										switch ((num2 = (uint)(num12 ^ 0x795374A1)) % 3)
										{
										case 0u:
											break;
										default:
											goto end_IL_017b;
										case 1u:
											goto IL_0199;
										case 2u:
											goto end_IL_017b;
										}
										goto IL_0176;
										IL_0199:
										_206F_200B_200D_202A_200D_206F_206E_206F_206D_200D_202E_200D_200F_200F_206E_200F_202A_200D_200B_206F_206F_200E_200F_206A_200D_202C_202D_206B_200F_200F_202D_202C_200D_206B_200D_200D_200F_202D_202D_206F_202E((IDisposable)enumerator);
										num12 = (int)((num2 * 1920767217) ^ 0x230F027A);
										continue;
										end_IL_017b:
										break;
									}
									break;
								}
							}
						}
						if (list.Count == 0)
						{
							while (true)
							{
								int num13 = 1039231585;
								while (true)
								{
									switch ((num2 = (uint)(num13 ^ 0x795374A1)) % 3)
									{
									case 0u:
										break;
									case 2u:
										goto IL_01df;
									default:
										goto IL_01fa;
									}
									break;
									IL_01fa:
									enumerator = ResourceManager.GetAll<Skill>().GetEnumerator();
									try
									{
										while (true)
										{
											IL_025d:
											int num14;
											int num15;
											if (!_200F_200F_200E_202C_202B_202D_200B_206B_200B_202C_202B_206E_206C_200B_202C_206F_206C_202D_206B_200D_206A_202E_200F_202D_206B_206B_200D_200D_200F_206B_202A_202D_200B_200E_206B_202A_206B_202C_200D_206C_202E((IEnumerator)enumerator))
											{
												num14 = 162421181;
												num15 = num14;
											}
											else
											{
												num14 = 739708971;
												num15 = num14;
											}
											while (true)
											{
												switch ((num2 = (uint)(num14 ^ 0x795374A1)) % 5)
												{
												case 0u:
													num14 = 739708971;
													continue;
												default:
													goto end_IL_020d;
												case 1u:
												{
													current2 = enumerator.Current;
													int num16;
													if (current2.Hard >= num5 - 1f)
													{
														num14 = 143134712;
														num16 = num14;
													}
													else
													{
														num14 = 1107871531;
														num16 = num14;
													}
													continue;
												}
												case 2u:
													break;
												case 4u:
													list.Add(current2);
													num14 = (int)((num2 * 1288764339) ^ 0x30BF4510);
													continue;
												case 3u:
													goto end_IL_020d;
												}
												goto IL_025d;
												continue;
												end_IL_020d:
												break;
											}
											break;
										}
									}
									finally
									{
										if (enumerator != null)
										{
											while (true)
											{
												IL_0298:
												int num17 = 700450367;
												while (true)
												{
													switch ((num2 = (uint)(num17 ^ 0x795374A1)) % 3)
													{
													case 0u:
														break;
													default:
														goto end_IL_029d;
													case 1u:
														goto IL_02bb;
													case 2u:
														goto end_IL_029d;
													}
													goto IL_0298;
													IL_02bb:
													_206F_200B_200D_202A_200D_206F_206E_206F_206D_200D_202E_200D_200F_200F_206E_200F_202A_200D_200B_206F_206F_200E_200F_206A_200D_202C_202D_206B_200F_200F_202D_202C_200D_206B_200D_200D_200F_202D_202D_206F_202E((IDisposable)enumerator);
													num17 = ((int)num2 * -1666349484) ^ 0x7CB6DFEE;
													continue;
													end_IL_029d:
													break;
												}
												break;
											}
										}
									}
									goto end_IL_01bc;
									IL_01df:
									if (!(num5 > 0f))
									{
										goto end_IL_01bc;
									}
									num13 = ((int)num2 * -1708428722) ^ -2000425264;
								}
								continue;
								end_IL_01bc:
								break;
							}
							if (list.Count == 0)
							{
								goto IL_02db;
							}
						}
						goto IL_0339;
					}
					IL_0339:
					skill = list[Tools.GetRandomInt(0, list.Count - 1)];
					num18 = 0;
					num19 = 1656683342;
					goto IL_02e0;
					IL_02e0:
					while (true)
					{
						switch ((num2 = (uint)(num19 ^ 0x795374A1)) % 10)
						{
						case 2u:
							break;
						case 4u:
							list.Add(ResourceManager.GetRandom<Skill>());
							num19 = (int)((num2 * 1605035316) ^ 0x226032B2);
							continue;
						case 5u:
							goto IL_0339;
						case 7u:
							skill = list[Tools.GetRandomInt(0, list.Count - 1)];
							num19 = 555073387;
							continue;
						case 9u:
						{
							int num20;
							int num21;
							if (num18 >= 100)
							{
								num20 = -555226919;
								num21 = num20;
							}
							else
							{
								num20 = -2023187398;
								num21 = num20;
							}
							num19 = num20 ^ (int)(num2 * 294080472);
							continue;
						}
						case 0u:
							list.Add(ResourceManager.GetRandom<Skill>());
							num19 = ((int)num2 * -73998235) ^ -1596406018;
							continue;
						case 3u:
							list.Add(ResourceManager.GetRandom<Skill>());
							num19 = (int)((num2 * 760175424) ^ 0x50181863);
							continue;
						case 8u:
							num18++;
							num19 = ((int)num2 * -1778672225) ^ -1027633352;
							continue;
						case 1u:
							goto IL_03eb;
						default:
							return skill;
						}
						break;
						IL_03eb:
						int num22;
						if (skill.IsNpc)
						{
							num19 = 2065149450;
							num22 = num19;
						}
						else
						{
							num19 = 170372497;
							num22 = num19;
						}
					}
					goto IL_02db;
					IL_02db:
					num19 = 1364721927;
					goto IL_02e0;
				}
				break;
				IL_0029:
				num5 = 0f;
				num = ((int)num2 * -1329593151) ^ -1350525173;
			}
		}
	}

	private InternalSkill GetRandomInternalSkill(float minHard, float maxHard)
	{
		List<InternalSkill> list = new List<InternalSkill>();
		float num = 0f;
		IEnumerator<InternalSkill> enumerator = ResourceManager.GetAll<InternalSkill>().GetEnumerator();
		try
		{
			InternalSkill current = default(InternalSkill);
			while (true)
			{
				IL_00bf:
				int num2;
				int num3;
				if (!_200F_200F_200E_202C_202B_202D_200B_206B_200B_202C_202B_206E_206C_200B_202C_206F_206C_202D_206B_200D_206A_202E_200F_202D_206B_206B_200D_200D_200F_206B_202A_202D_200B_200E_206B_202A_206B_202C_200D_206C_202E((IEnumerator)enumerator))
				{
					num2 = -1185998939;
					num3 = num2;
				}
				else
				{
					num2 = -1549993636;
					num3 = num2;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num2 ^ -650498873)) % 9)
					{
					case 6u:
						num2 = -1549993636;
						continue;
					default:
						goto end_IL_0022;
					case 2u:
						num = current.Hard;
						num2 = ((int)num4 * -331575232) ^ -178696124;
						continue;
					case 3u:
					{
						int num9;
						int num10;
						if (current.Hard > maxHard)
						{
							num9 = -124709804;
							num10 = num9;
						}
						else
						{
							num9 = -1230600271;
							num10 = num9;
						}
						num2 = num9 ^ ((int)num4 * -663329657);
						continue;
					}
					case 5u:
					{
						current = enumerator.Current;
						int num6;
						if (num >= current.Hard)
						{
							num2 = -872090428;
							num6 = num2;
						}
						else
						{
							num2 = -1623757203;
							num6 = num2;
						}
						continue;
					}
					case 0u:
						break;
					case 1u:
					{
						int num7;
						int num8;
						if (current.Hard < 100f)
						{
							num7 = -579349549;
							num8 = num7;
						}
						else
						{
							num7 = -361372222;
							num8 = num7;
						}
						num2 = num7 ^ ((int)num4 * -1881316745);
						continue;
					}
					case 8u:
					{
						int num5;
						if (current.Hard >= minHard)
						{
							num2 = -688147828;
							num5 = num2;
						}
						else
						{
							num2 = -686763559;
							num5 = num2;
						}
						continue;
					}
					case 4u:
						list.Add(current);
						num2 = ((int)num4 * -1701813975) ^ 0x1E330EA;
						continue;
					case 7u:
						goto end_IL_0022;
					}
					goto IL_00bf;
					continue;
					end_IL_0022:
					break;
				}
				break;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_0146:
					int num11 = -1740126983;
					while (true)
					{
						uint num4;
						switch ((num4 = (uint)(num11 ^ -650498873)) % 3)
						{
						case 2u:
							break;
						default:
							goto end_IL_014b;
						case 1u:
							goto IL_0169;
						case 0u:
							goto end_IL_014b;
						}
						goto IL_0146;
						IL_0169:
						_206F_200B_200D_202A_200D_206F_206E_206F_206D_200D_202E_200D_200F_200F_206E_200F_202A_200D_200B_206F_206F_200E_200F_206A_200D_202C_202D_206B_200F_200F_202D_202C_200D_206B_200D_200D_200F_202D_202D_206F_202E((IDisposable)enumerator);
						num11 = ((int)num4 * -337542153) ^ 0x6F2C3DD2;
						continue;
						end_IL_014b:
						break;
					}
					break;
				}
			}
		}
		if (list.Count == 0)
		{
			InternalSkill current2 = default(InternalSkill);
			while (true)
			{
				int num12 = -1953522980;
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num12 ^ -650498873)) % 3)
					{
					case 2u:
						break;
					case 1u:
						goto IL_01af;
					default:
						goto IL_01ca;
					}
					break;
					IL_01ca:
					enumerator = ResourceManager.GetAll<InternalSkill>().GetEnumerator();
					try
					{
						while (true)
						{
							IL_0207:
							int num13;
							int num14;
							if (_200F_200F_200E_202C_202B_202D_200B_206B_200B_202C_202B_206E_206C_200B_202C_206F_206C_202D_206B_200D_206A_202E_200F_202D_206B_206B_200D_200D_200F_206B_202A_202D_200B_200E_206B_202A_206B_202C_200D_206C_202E((IEnumerator)enumerator))
							{
								num13 = -1265823896;
								num14 = num13;
							}
							else
							{
								num13 = -1432127855;
								num14 = num13;
							}
							while (true)
							{
								switch ((num4 = (uint)(num13 ^ -650498873)) % 6)
								{
								case 4u:
									num13 = -1265823896;
									continue;
								default:
									goto end_IL_01dd;
								case 2u:
									break;
								case 5u:
								{
									int num15;
									int num16;
									if (current2.Hard >= num - 1f)
									{
										num15 = -1942815052;
										num16 = num15;
									}
									else
									{
										num15 = -1325420289;
										num16 = num15;
									}
									num13 = num15 ^ ((int)num4 * -456174178);
									continue;
								}
								case 3u:
									list.Add(current2);
									num13 = ((int)num4 * -1237506989) ^ -1069041810;
									continue;
								case 1u:
									current2 = enumerator.Current;
									num13 = -830337324;
									continue;
								case 0u:
									goto end_IL_01dd;
								}
								goto IL_0207;
								continue;
								end_IL_01dd:
								break;
							}
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							while (true)
							{
								IL_027f:
								int num17 = -2147416291;
								while (true)
								{
									switch ((num4 = (uint)(num17 ^ -650498873)) % 3)
									{
									case 2u:
										break;
									default:
										goto end_IL_0284;
									case 1u:
										goto IL_02a2;
									case 0u:
										goto end_IL_0284;
									}
									goto IL_027f;
									IL_02a2:
									_206F_200B_200D_202A_200D_206F_206E_206F_206D_200D_202E_200D_200F_200F_206E_200F_202A_200D_200B_206F_206F_200E_200F_206A_200D_202C_202D_206B_200F_200F_202D_202C_200D_206B_200D_200D_200F_202D_202D_206F_202E((IDisposable)enumerator);
									num17 = (int)((num4 * 1577713182) ^ 0x2D9A830E);
									continue;
									end_IL_0284:
									break;
								}
								break;
							}
						}
					}
					goto end_IL_018c;
					IL_01af:
					if (!(num > 0f))
					{
						goto end_IL_018c;
					}
					num12 = (int)((num4 * 985205418) ^ 0x41C076F0);
				}
				continue;
				end_IL_018c:
				break;
			}
			if (list.Count == 0)
			{
				goto IL_02c5;
			}
		}
		goto IL_038d;
		IL_02ca:
		int num18;
		InternalSkill internalSkill = default(InternalSkill);
		int num19 = default(int);
		while (true)
		{
			uint num4;
			switch ((num4 = (uint)(num18 ^ -650498873)) % 10)
			{
			case 3u:
				break;
			case 6u:
				internalSkill = list[Tools.GetRandomInt(0, list.Count - 1)];
				num18 = -906929871;
				continue;
			case 8u:
				num18 = (int)(num4 * 1500646959) ^ -1132913526;
				continue;
			case 1u:
				list.Add(ResourceManager.Get<InternalSkill>(ResourceStrings.ResStrings[323]));
				num18 = ((int)num4 * -884346928) ^ 0x605B4E47;
				continue;
			case 2u:
				num19++;
				num18 = (int)((num4 * 1695867542) ^ 0x50A4E8CC);
				continue;
			case 9u:
				num19 = 0;
				num18 = (int)((num4 * 787268644) ^ 0xE73C07D);
				continue;
			case 0u:
				goto IL_038d;
			case 5u:
			{
				int num20;
				int num21;
				if (num19 >= 100)
				{
					num20 = -1224994169;
					num21 = num20;
				}
				else
				{
					num20 = -476563063;
					num21 = num20;
				}
				num18 = num20 ^ ((int)num4 * -1172009446);
				continue;
			}
			case 7u:
				goto IL_03ce;
			default:
				return internalSkill;
			}
			break;
			IL_03ce:
			int num22;
			if (internalSkill.IsNpc)
			{
				num18 = -58513970;
				num22 = num18;
			}
			else
			{
				num18 = -236062099;
				num22 = num18;
			}
		}
		goto IL_02c5;
		IL_02c5:
		num18 = -1354594608;
		goto IL_02ca;
		IL_038d:
		internalSkill = list[Tools.GetRandomInt(0, list.Count - 1)];
		num18 = -1847467682;
		goto IL_02ca;
	}

	private Aoyi GetRandomAoyi(float minHard, float maxHard)
	{
		List<Aoyi> list = new List<Aoyi>();
		Aoyi current = default(Aoyi);
		float startSkillHard = default(float);
		float num5 = default(float);
		Aoyi current2 = default(Aoyi);
		Aoyi aoyi = default(Aoyi);
		int num20 = default(int);
		while (true)
		{
			int num = -51081602;
			while (true)
			{
				int num21;
				uint num2;
				switch ((num2 = (uint)(num ^ -2052337803)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0029;
				default:
					{
						IEnumerator<Aoyi> enumerator = ResourceManager.GetAll<Aoyi>().GetEnumerator();
						try
						{
							while (true)
							{
								IL_00a9:
								int num3;
								int num4;
								if (_200F_200F_200E_202C_202B_202D_200B_206B_200B_202C_202B_206E_206C_200B_202C_206F_206C_202D_206B_200D_206A_202E_200F_202D_206B_206B_200D_200D_200F_206B_202A_202D_200B_200E_206B_202A_206B_202C_200D_206C_202E((IEnumerator)enumerator))
								{
									num3 = -1088238824;
									num4 = num3;
								}
								else
								{
									num3 = -106638167;
									num4 = num3;
								}
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ -2052337803)) % 10)
									{
									case 9u:
										num3 = -1088238824;
										continue;
									default:
										goto end_IL_0052;
									case 3u:
										current = enumerator.Current;
										startSkillHard = current.GetStartSkillHard();
										num3 = -1014098255;
										continue;
									case 1u:
										break;
									case 2u:
									{
										int num11;
										int num12;
										if (startSkillHard > maxHard)
										{
											num11 = 690836864;
											num12 = num11;
										}
										else
										{
											num11 = 1905806206;
											num12 = num11;
										}
										num3 = num11 ^ (int)(num2 * 1685155927);
										continue;
									}
									case 5u:
									{
										int num8;
										if (startSkillHard < minHard)
										{
											num3 = -739237430;
											num8 = num3;
										}
										else
										{
											num3 = -1469146957;
											num8 = num3;
										}
										continue;
									}
									case 8u:
										num5 = startSkillHard;
										num3 = ((int)num2 * -949576373) ^ -522370298;
										continue;
									case 4u:
									{
										int num9;
										int num10;
										if (startSkillHard < 100f)
										{
											num9 = 1460993343;
											num10 = num9;
										}
										else
										{
											num9 = 1482101860;
											num10 = num9;
										}
										num3 = num9 ^ ((int)num2 * -2101832337);
										continue;
									}
									case 7u:
										list.Add(current);
										num3 = ((int)num2 * -369245154) ^ -1696675244;
										continue;
									case 0u:
									{
										int num6;
										int num7;
										if (num5 >= startSkillHard)
										{
											num6 = -1295127726;
											num7 = num6;
										}
										else
										{
											num6 = -1984502945;
											num7 = num6;
										}
										num3 = num6 ^ (int)(num2 * 971469984);
										continue;
									}
									case 6u:
										goto end_IL_0052;
									}
									goto IL_00a9;
									continue;
									end_IL_0052:
									break;
								}
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								while (true)
								{
									IL_017d:
									int num13 = -1895381581;
									while (true)
									{
										switch ((num2 = (uint)(num13 ^ -2052337803)) % 3)
										{
										case 0u:
											break;
										default:
											goto end_IL_0182;
										case 1u:
											goto IL_01a0;
										case 2u:
											goto end_IL_0182;
										}
										goto IL_017d;
										IL_01a0:
										_206F_200B_200D_202A_200D_206F_206E_206F_206D_200D_202E_200D_200F_200F_206E_200F_202A_200D_200B_206F_206F_200E_200F_206A_200D_202C_202D_206B_200F_200F_202D_202C_200D_206B_200D_200D_200F_202D_202D_206F_202E((IDisposable)enumerator);
										num13 = (int)((num2 * 1921889761) ^ 0x3F4B2829);
										continue;
										end_IL_0182:
										break;
									}
									break;
								}
							}
						}
						if (list.Count == 0)
						{
							while (true)
							{
								int num14 = -1449749872;
								while (true)
								{
									switch ((num2 = (uint)(num14 ^ -2052337803)) % 3)
									{
									case 0u:
										break;
									case 1u:
										goto IL_01e6;
									default:
										goto IL_0201;
									}
									break;
									IL_0201:
									enumerator = ResourceManager.GetAll<Aoyi>().GetEnumerator();
									try
									{
										while (true)
										{
											IL_0280:
											int num15;
											int num16;
											if (!_200F_200F_200E_202C_202B_202D_200B_206B_200B_202C_202B_206E_206C_200B_202C_206F_206C_202D_206B_200D_206A_202E_200F_202D_206B_206B_200D_200D_200F_206B_202A_202D_200B_200E_206B_202A_206B_202C_200D_206C_202E((IEnumerator)enumerator))
											{
												num15 = -405918148;
												num16 = num15;
											}
											else
											{
												num15 = -495937590;
												num16 = num15;
											}
											while (true)
											{
												switch ((num2 = (uint)(num15 ^ -2052337803)) % 6)
												{
												case 2u:
													num15 = -495937590;
													continue;
												default:
													goto end_IL_0214;
												case 3u:
													list.Add(current2);
													num15 = (int)((num2 * 617775752) ^ 0xACE486B);
													continue;
												case 0u:
												{
													int num17;
													int num18;
													if (current2.GetStartSkillHard() < num5 - 1f)
													{
														num17 = 1414010461;
														num18 = num17;
													}
													else
													{
														num17 = 1930857760;
														num18 = num17;
													}
													num15 = num17 ^ (int)(num2 * 2125480167);
													continue;
												}
												case 4u:
													break;
												case 1u:
													current2 = enumerator.Current;
													num15 = -1902931433;
													continue;
												case 5u:
													goto end_IL_0214;
												}
												goto IL_0280;
												continue;
												end_IL_0214:
												break;
											}
											break;
										}
									}
									finally
									{
										if (enumerator != null)
										{
											while (true)
											{
												IL_02b6:
												int num19 = -71600608;
												while (true)
												{
													switch ((num2 = (uint)(num19 ^ -2052337803)) % 3)
													{
													case 2u:
														break;
													default:
														goto end_IL_02bb;
													case 1u:
														goto IL_02d9;
													case 0u:
														goto end_IL_02bb;
													}
													goto IL_02b6;
													IL_02d9:
													_206F_200B_200D_202A_200D_206F_206E_206F_206D_200D_202E_200D_200F_200F_206E_200F_202A_200D_200B_206F_206F_200E_200F_206A_200D_202C_202D_206B_200F_200F_202D_202C_200D_206B_200D_200D_200F_202D_202D_206F_202E((IDisposable)enumerator);
													num19 = ((int)num2 * -495283368) ^ -869761096;
													continue;
													end_IL_02bb:
													break;
												}
												break;
											}
										}
									}
									goto end_IL_01c3;
									IL_01e6:
									if (!(num5 > 0f))
									{
										goto end_IL_01c3;
									}
									num14 = (int)(num2 * 715050289) ^ -203493090;
								}
								continue;
								end_IL_01c3:
								break;
							}
							if (list.Count == 0)
							{
								goto IL_02fc;
							}
						}
						goto IL_03bc;
					}
					IL_03bc:
					aoyi = list[Tools.GetRandomInt(0, list.Count - 1)];
					num20 = 0;
					num21 = -1222414388;
					goto IL_0301;
					IL_0301:
					while (true)
					{
						switch ((num2 = (uint)(num21 ^ -2052337803)) % 8)
						{
						case 7u:
							break;
						case 6u:
							list.Add(ResourceManager.GetRandom<Aoyi>());
							list.Add(ResourceManager.GetRandom<Aoyi>());
							num21 = (int)((num2 * 425889164) ^ 0x3E600547);
							continue;
						case 2u:
							list.Add(ResourceManager.GetRandom<Aoyi>());
							num21 = (int)((num2 * 1038413878) ^ 0x70A0B02C);
							continue;
						case 3u:
						{
							int num22;
							int num23;
							if (num20 < 100)
							{
								num22 = -1834876041;
								num23 = num22;
							}
							else
							{
								num22 = -2023949741;
								num23 = num22;
							}
							num21 = num22 ^ ((int)num2 * -1859866110);
							continue;
						}
						case 4u:
							aoyi = list[Tools.GetRandomInt(0, list.Count - 1)];
							num20++;
							num21 = -1222414388;
							continue;
						case 5u:
							goto IL_03bc;
						case 1u:
							goto IL_03dd;
						default:
							return list[Tools.GetRandomInt(0, list.Count - 1)];
						}
						break;
						IL_03dd:
						int num24;
						if (!ResourceManager.GetNpcSkills(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2804517961u)).Contains(aoyi.Name))
						{
							num21 = -1949869723;
							num24 = num21;
						}
						else
						{
							num21 = -1906826770;
							num24 = num21;
						}
					}
					goto IL_02fc;
					IL_02fc:
					num21 = -1771007581;
					goto IL_0301;
				}
				break;
				IL_0029:
				num5 = 0f;
				num = ((int)num2 * -1723847529) ^ 0x7B826940;
			}
		}
	}

	private UniqueSkill GetRandomUniqueSkill(float minHard, float maxHard)
	{
		List<UniqueSkill> list = new List<UniqueSkill>();
		float num7 = default(float);
		UniqueSkill current = default(UniqueSkill);
		UniqueSkill current2 = default(UniqueSkill);
		UniqueSkill uniqueSkill = default(UniqueSkill);
		int num20 = default(int);
		while (true)
		{
			int num = -531422989;
			while (true)
			{
				int num19;
				uint num2;
				switch ((num2 = (uint)(num ^ -2098450371)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0029;
				default:
					{
						IEnumerator<UniqueSkill> enumerator = ResourceManager.GetAll<UniqueSkill>().GetEnumerator();
						try
						{
							while (true)
							{
								IL_012f:
								int num3;
								int num4;
								if (!_200F_200F_200E_202C_202B_202D_200B_206B_200B_202C_202B_206E_206C_200B_202C_206F_206C_202D_206B_200D_206A_202E_200F_202D_206B_206B_200D_200D_200F_206B_202A_202D_200B_200E_206B_202A_206B_202C_200D_206C_202E((IEnumerator)enumerator))
								{
									num3 = -38336380;
									num4 = num3;
								}
								else
								{
									num3 = -1501328863;
									num4 = num3;
								}
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ -2098450371)) % 9)
									{
									case 0u:
										num3 = -1501328863;
										continue;
									default:
										goto end_IL_0055;
									case 7u:
										num7 = current.Hard;
										num3 = (int)((num2 * 811454935) ^ 0x68262495);
										continue;
									case 6u:
									{
										int num10;
										int num11;
										if (current.Hard < 100f)
										{
											num10 = 193266894;
											num11 = num10;
										}
										else
										{
											num10 = 724181536;
											num11 = num10;
										}
										num3 = num10 ^ (int)(num2 * 94656622);
										continue;
									}
									case 2u:
										list.Add(current);
										num3 = ((int)num2 * -226327516) ^ -710692492;
										continue;
									case 1u:
									{
										current = enumerator.Current;
										int num8;
										if (num7 >= current.Hard)
										{
											num3 = -123006268;
											num8 = num3;
										}
										else
										{
											num3 = -1876503005;
											num8 = num3;
										}
										continue;
									}
									case 5u:
									{
										int num9;
										if (current.Hard < minHard)
										{
											num3 = -434946560;
											num9 = num3;
										}
										else
										{
											num3 = -1055853450;
											num9 = num3;
										}
										continue;
									}
									case 4u:
										break;
									case 8u:
									{
										int num5;
										int num6;
										if (current.Hard <= maxHard)
										{
											num5 = -549762917;
											num6 = num5;
										}
										else
										{
											num5 = -1423645805;
											num6 = num5;
										}
										num3 = num5 ^ (int)(num2 * 1947217625);
										continue;
									}
									case 3u:
										goto end_IL_0055;
									}
									goto IL_012f;
									continue;
									end_IL_0055:
									break;
								}
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								while (true)
								{
									IL_0179:
									int num12 = -1777092611;
									while (true)
									{
										switch ((num2 = (uint)(num12 ^ -2098450371)) % 3)
										{
										case 0u:
											break;
										default:
											goto end_IL_017e;
										case 2u:
											goto IL_019c;
										case 1u:
											goto end_IL_017e;
										}
										goto IL_0179;
										IL_019c:
										_206F_200B_200D_202A_200D_206F_206E_206F_206D_200D_202E_200D_200F_200F_206E_200F_202A_200D_200B_206F_206F_200E_200F_206A_200D_202C_202D_206B_200F_200F_202D_202C_200D_206B_200D_200D_200F_202D_202D_206F_202E((IDisposable)enumerator);
										num12 = (int)((num2 * 634485643) ^ 0x705796B);
										continue;
										end_IL_017e:
										break;
									}
									break;
								}
							}
						}
						if (list.Count == 0)
						{
							while (true)
							{
								int num13 = -312306342;
								while (true)
								{
									switch ((num2 = (uint)(num13 ^ -2098450371)) % 3)
									{
									case 0u:
										break;
									case 2u:
										goto IL_01e2;
									default:
										goto IL_01fd;
									}
									break;
									IL_01fd:
									enumerator = ResourceManager.GetAll<UniqueSkill>().GetEnumerator();
									try
									{
										while (true)
										{
											IL_0262:
											int num14;
											int num15;
											if (!_200F_200F_200E_202C_202B_202D_200B_206B_200B_202C_202B_206E_206C_200B_202C_206F_206C_202D_206B_200D_206A_202E_200F_202D_206B_206B_200D_200D_200F_206B_202A_202D_200B_200E_206B_202A_206B_202C_200D_206C_202E((IEnumerator)enumerator))
											{
												num14 = -3930308;
												num15 = num14;
											}
											else
											{
												num14 = -1049202702;
												num15 = num14;
											}
											while (true)
											{
												switch ((num2 = (uint)(num14 ^ -2098450371)) % 6)
												{
												case 3u:
													num14 = -1049202702;
													continue;
												default:
													goto end_IL_0210;
												case 1u:
													current2 = enumerator.Current;
													num14 = -457195739;
													continue;
												case 2u:
													list.Add(current2);
													num14 = ((int)num2 * -195306564) ^ -1269293125;
													continue;
												case 0u:
													break;
												case 4u:
												{
													int num16;
													int num17;
													if (current2.Hard >= num7 - 1f)
													{
														num16 = 336553211;
														num17 = num16;
													}
													else
													{
														num16 = 1898858627;
														num17 = num16;
													}
													num14 = num16 ^ ((int)num2 * -553445738);
													continue;
												}
												case 5u:
													goto end_IL_0210;
												}
												goto IL_0262;
												continue;
												end_IL_0210:
												break;
											}
											break;
										}
									}
									finally
									{
										if (enumerator != null)
										{
											while (true)
											{
												IL_02af:
												int num18 = -717520012;
												while (true)
												{
													switch ((num2 = (uint)(num18 ^ -2098450371)) % 3)
													{
													case 0u:
														break;
													default:
														goto end_IL_02b4;
													case 2u:
														goto IL_02d2;
													case 1u:
														goto end_IL_02b4;
													}
													goto IL_02af;
													IL_02d2:
													_206F_200B_200D_202A_200D_206F_206E_206F_206D_200D_202E_200D_200F_200F_206E_200F_202A_200D_200B_206F_206F_200E_200F_206A_200D_202C_202D_206B_200F_200F_202D_202C_200D_206B_200D_200D_200F_202D_202D_206F_202E((IDisposable)enumerator);
													num18 = (int)(num2 * 1750412847) ^ -1590042672;
													continue;
													end_IL_02b4:
													break;
												}
												break;
											}
										}
									}
									goto end_IL_01bf;
									IL_01e2:
									if (!(num7 > 0f))
									{
										goto end_IL_01bf;
									}
									num13 = ((int)num2 * -595453445) ^ 0x7200B384;
								}
								continue;
								end_IL_01bf:
								break;
							}
							if (list.Count == 0)
							{
								goto IL_02f5;
							}
						}
						goto IL_03f1;
					}
					IL_03f1:
					uniqueSkill = list[Tools.GetRandomInt(0, list.Count - 1)];
					num19 = -1748727073;
					goto IL_02fa;
					IL_02fa:
					while (true)
					{
						switch ((num2 = (uint)(num19 ^ -2098450371)) % 10)
						{
						case 9u:
							break;
						case 0u:
						{
							int num21;
							int num22;
							if (num20 >= 100)
							{
								num21 = -1921617438;
								num22 = num21;
							}
							else
							{
								num21 = -1911117939;
								num22 = num21;
							}
							num19 = num21 ^ ((int)num2 * -2017404166);
							continue;
						}
						case 7u:
							list.Add(ResourceManager.GetRandom<UniqueSkill>());
							list.Add(ResourceManager.GetRandom<UniqueSkill>());
							num19 = (int)(num2 * 1419196020) ^ -771520712;
							continue;
						case 1u:
							list.Add(ResourceManager.GetRandom<UniqueSkill>());
							num19 = ((int)num2 * -1340306381) ^ 0x2E724F6B;
							continue;
						case 6u:
							goto IL_039e;
						case 4u:
							uniqueSkill = list[Tools.GetRandomInt(0, list.Count - 1)];
							num20++;
							num19 = -520294317;
							continue;
						case 3u:
							goto IL_03f1;
						case 8u:
							num20 = 0;
							num19 = (int)((num2 * 1635577231) ^ 0x2EA5E945);
							continue;
						case 2u:
							num19 = (int)((num2 * 1419042137) ^ 0x4D46C505);
							continue;
						default:
							return list[Tools.GetRandomInt(0, list.Count - 1)];
						}
						break;
						IL_039e:
						int num23;
						if (!ResourceManager.GetNpcSkills(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(351772101u)).Contains(uniqueSkill.Name))
						{
							num19 = -1527872394;
							num23 = num19;
						}
						else
						{
							num19 = -1203873745;
							num23 = num19;
						}
					}
					goto IL_02f5;
					IL_02f5:
					num19 = -1606347584;
					goto IL_02fa;
				}
				break;
				IL_0029:
				num7 = 0f;
				num = ((int)num2 * -302262313) ^ 0x5EABC645;
			}
		}
	}

	private Trigger GenerateItemTriggerFromXml(Trigger trigger)
	{
		List<string> list = new List<string>();
		if (!_200F_206F_202E_206D_206B_206B_206C_200F_202D_202C_202E_200F_202B_206C_200F_200E_206B_202A_206D_206D_200E_200B_200E_200C_206B_206B_206B_200C_202C_202B_202B_206C_206A_200E_206B_206E_202A_206C_206E_202B_202E(trigger.Name, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2723001403u)))
		{
			goto IL_0020;
		}
		goto IL_04d9;
		IL_0020:
		int num = -1180542106;
		goto IL_0025;
		IL_0025:
		ITParam iTParam2 = default(ITParam);
		int num9 = default(int);
		string text2 = default(string);
		string text3 = default(string);
		string[] array = default(string[]);
		ITParam iTParam = default(ITParam);
		int num18 = default(int);
		int num8 = default(int);
		string text5 = default(string);
		string[] array3 = default(string[]);
		string text = default(string);
		int num3 = default(int);
		int num19 = default(int);
		string item = default(string);
		ITParam iTParam3 = default(ITParam);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -684558082)) % 56)
			{
			case 34u:
				break;
			case 43u:
				goto IL_011b;
			case 36u:
			{
				int num28;
				int num29;
				if (!_200F_206F_202E_206D_206B_206B_206C_200F_202D_202C_202E_200F_202B_206C_200F_200E_206B_202A_206D_206D_200E_200B_200E_200C_206B_206B_206B_200C_202C_202B_202B_206C_206A_200E_206B_206E_202A_206C_206E_202B_202E(trigger.Name, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1229190677u)))
				{
					num28 = 1727678778;
					num29 = num28;
				}
				else
				{
					num28 = 176289856;
					num29 = num28;
				}
				num = num28 ^ ((int)num2 * -991543142);
				continue;
			}
			case 6u:
			{
				int num32;
				int num33;
				if (iTParam2.Max2 == -1.0)
				{
					num32 = -1137438023;
					num33 = num32;
				}
				else
				{
					num32 = -1954656537;
					num33 = num32;
				}
				num = num32 ^ ((int)num2 * -1961181228);
				continue;
			}
			case 42u:
				num9 = (int)(Tools.GetRandom(iTParam2.Min, iTParam2.Max) + 0.5);
				num = ((int)num2 * -955455739) ^ 0x35BF9F0A;
				continue;
			case 4u:
				list.Add(text2 + global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2129775u) + text3);
				num = (int)(num2 * 549820250) ^ -480159875;
				continue;
			case 24u:
				array = _200E_200C_206E_200B_200B_200F_202A_206D_202A_202B_206F_200F_202C_202E_202C_202E_200E_202A_206E_206E_206B_200C_202A_200C_202A_206D_200C_206F_206F_202A_206B_200C_202D_206E_200C_202E_206D_206C_202D_202C_202E(iTParam.Pool, new char[1] { ',' });
				num = ((int)num2 * -793002108) ^ -1424918671;
				continue;
			case 5u:
				num = ((int)num2 * -695192110) ^ -96927936;
				continue;
			case 15u:
				text2 = array[Tools.GetRandomInt(0, array.Length - 1)];
				num9 = (int)(Tools.GetRandom(iTParam.Min, iTParam.Max) + 0.5);
				text3 = num9.ToString();
				num = ((int)num2 * -1666532269) ^ -807521585;
				continue;
			case 19u:
				trigger.ArgvsString = trigger.ArgvsString.Substring(0, trigger.ArgvsString.Length - 1);
				num = (int)(num2 * 1060922536) ^ -844751667;
				continue;
			case 16u:
				goto IL_02ad;
			case 25u:
			{
				int num30;
				int num31;
				if (iTParam2.Max == -1.0)
				{
					num30 = -1927950475;
					num31 = num30;
				}
				else
				{
					num30 = -1474326472;
					num31 = num30;
				}
				num = num30 ^ (int)(num2 * 453007540);
				continue;
			}
			case 2u:
				num18 = 0;
				num = -1346505224;
				continue;
			case 46u:
			{
				int num12;
				int num13;
				if (Params.Count <= 0)
				{
					num12 = 1377382265;
					num13 = num12;
				}
				else
				{
					num12 = 296710832;
					num13 = num12;
				}
				num = num12 ^ (int)(num2 * 293520874);
				continue;
			}
			case 40u:
			{
				int num36;
				int num37;
				if (num8 < 100)
				{
					num36 = -219320313;
					num37 = num36;
				}
				else
				{
					num36 = -1325097371;
					num37 = num36;
				}
				num = num36 ^ (int)(num2 * 1571880245);
				continue;
			}
			case 32u:
			{
				int num24;
				int num25;
				if (_200F_206F_202E_206D_206B_206B_206C_200F_202D_202C_202E_200F_202B_206C_200F_200E_206B_202A_206D_206D_200E_200B_200E_200C_206B_206B_206B_200C_202C_202B_202B_206C_206A_200E_206B_206E_202A_206C_206E_202B_202E(trigger.Name, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1421926737u)))
				{
					num24 = -835817536;
					num25 = num24;
				}
				else
				{
					num24 = -1074469526;
					num25 = num24;
				}
				num = num24 ^ ((int)num2 * -1762657291);
				continue;
			}
			case 55u:
				text5 = array3[Tools.GetRandomInt(0, array3.Length - 1)];
				num = (int)((num2 * 844615134) ^ 0x145F22F6);
				continue;
			case 28u:
				array3 = iTParam2.Pool.Split(',');
				num = (int)((num2 * 1693156684) ^ 0x172D0881);
				continue;
			case 52u:
			{
				string text4 = num9.ToString();
				list.Add(text5 + global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2129775u) + text + global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2129775u) + text4);
				num = (int)((num2 * 507911942) ^ 0x3ED99FA9);
				continue;
			}
			case 20u:
			{
				int num16;
				int num17;
				if (iTParam2.Min != -1.0)
				{
					num16 = 592601675;
					num17 = num16;
				}
				else
				{
					num16 = 100907477;
					num17 = num16;
				}
				num = num16 ^ (int)(num2 * 1082163113);
				continue;
			}
			case 53u:
				num18++;
				num = -1346505224;
				continue;
			case 10u:
			{
				int num6;
				int num7;
				if (iTParam2.Min2 == -1.0)
				{
					num6 = -746149579;
					num7 = num6;
				}
				else
				{
					num6 = -1111158900;
					num7 = num6;
				}
				num = num6 ^ ((int)num2 * -1840508150);
				continue;
			}
			case 33u:
				iTParam2 = Params[Tools.GetRandomInt(0, Params.Count - 1)];
				num = -1208322678;
				continue;
			case 26u:
				iTParam2 = null;
				num8 = 0;
				num = ((int)num2 * -712463854) ^ 0x17CF07A7;
				continue;
			case 14u:
				goto IL_04d9;
			case 45u:
				num9 = (int)(Tools.GetRandom(iTParam2.Min2, iTParam2.Max2) + 0.5);
				num = (int)((num2 * 1520529836) ^ 0x301446A6);
				continue;
			case 30u:
				iTParam = null;
				num3 = 0;
				num = (int)(num2 * 2107099411) ^ -950351539;
				continue;
			case 44u:
			{
				int num34;
				int num35;
				if (_200F_206F_202E_206D_206B_206B_206C_200F_202D_202C_202E_200F_202B_206C_200F_200E_206B_202A_206D_206D_200E_200B_200E_200C_206B_206B_206B_200C_202C_202B_202B_206C_206A_200E_206B_206E_202A_206C_206E_202B_202E(trigger.Name, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1879655336u)))
				{
					num34 = 332813752;
					num35 = num34;
				}
				else
				{
					num34 = 174261166;
					num35 = num34;
				}
				num = num34 ^ (int)(num2 * 1018507136);
				continue;
			}
			case 35u:
				trigger.ArgvsString = string.Empty;
				num19 = 0;
				num = -2067791228;
				continue;
			case 13u:
			{
				int num26;
				int num27;
				if (trigger.ArgvsString.EndsWith(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1130733518u)))
				{
					num26 = 1590674680;
					num27 = num26;
				}
				else
				{
					num26 = 155431408;
					num27 = num26;
				}
				num = num26 ^ ((int)num2 * -1295947935);
				continue;
			}
			case 47u:
				num = ((int)num2 * -1848519057) ^ 0x44A866C4;
				continue;
			case 23u:
				list.Add(item);
				num = (int)(num2 * 2075533173) ^ -2034891696;
				continue;
			case 8u:
			{
				int num22;
				int num23;
				if (num3 < 100)
				{
					num22 = -1729437683;
					num23 = num22;
				}
				else
				{
					num22 = -156041001;
					num23 = num22;
				}
				num = num22 ^ (int)(num2 * 2066835360);
				continue;
			}
			case 12u:
				goto IL_0615;
			case 50u:
				goto IL_062d;
			case 29u:
			{
				int num20;
				int num21;
				if (iTParam.Max == -1.0)
				{
					num20 = -298563521;
					num21 = num20;
				}
				else
				{
					num20 = -2131204588;
					num21 = num20;
				}
				num = num20 ^ ((int)num2 * -1123948536);
				continue;
			}
			case 49u:
				goto IL_0679;
			case 9u:
			{
				string[] array2 = iTParam3.Pool.Split(',');
				item = array2[Tools.GetRandomInt(0, array2.Length - 1)];
				num = ((int)num2 * -1292791752) ^ -468820959;
				continue;
			}
			case 41u:
				iTParam = null;
				num = -667733765;
				continue;
			case 11u:
				trigger.ArgvsString = trigger.ArgvsString + list[num19] + global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2129775u);
				num19++;
				num = -2067791228;
				continue;
			case 39u:
			{
				int num14;
				int num15;
				if (iTParam3.Max == -1.0)
				{
					num14 = -1215873954;
					num15 = num14;
				}
				else
				{
					num14 = -505587365;
					num15 = num14;
				}
				num = num14 ^ (int)(num2 * 86832336);
				continue;
			}
			case 54u:
				text = num9.ToString();
				num = ((int)num2 * -938367883) ^ 0x4426848D;
				continue;
			case 31u:
				iTParam2 = null;
				num = -866387563;
				continue;
			case 48u:
				goto IL_0764;
			case 3u:
				goto IL_078f;
			case 38u:
				goto IL_07d3;
			case 7u:
				goto IL_07f6;
			case 1u:
			{
				int num10;
				int num11;
				if (string.IsNullOrEmpty(iTParam2.Pool))
				{
					num10 = 993013285;
					num11 = num10;
				}
				else
				{
					num10 = 768934897;
					num11 = num10;
				}
				num = num10 ^ ((int)num2 * -1117474076);
				continue;
			}
			case 27u:
				num8++;
				num = -508461046;
				continue;
			case 21u:
				num9 = (int)(Tools.GetRandom(iTParam3.Min, iTParam3.Max) + 0.5);
				list.Add(num9.ToString());
				num = (int)(num2 * 1003139921) ^ -34825187;
				continue;
			case 17u:
				num = ((int)num2 * -100973448) ^ 0x30B6656;
				continue;
			case 22u:
				num = ((int)num2 * -1842887140) ^ 0xE8DEFAB;
				continue;
			case 0u:
				goto IL_08cc;
			case 18u:
			{
				int num4;
				int num5;
				if (!_200B_202D_200B_206A_202C_200B_200B_200D_200B_200E_202D_206F_202D_200D_202C_200E_200B_200B_206E_202B_206D_202A_200E_200D_206A_200E_200F_206A_206D_206A_206B_200F_202C_206F_206B_206A_200B_200E_200E_206D_202E(iTParam.Pool))
				{
					num4 = 1739297943;
					num5 = num4;
				}
				else
				{
					num4 = 216808955;
					num5 = num4;
				}
				num = num4 ^ (int)(num2 * 1418448502);
				continue;
			}
			case 37u:
				num3++;
				num = -1183374098;
				continue;
			default:
				return trigger;
			}
			break;
			IL_08cc:
			int num38;
			if (!string.IsNullOrEmpty(iTParam3.Pool))
			{
				num = -1091991257;
				num38 = num;
			}
			else
			{
				num = -2011369469;
				num38 = num;
			}
			continue;
			IL_011b:
			int num39;
			if (iTParam2 != null)
			{
				num = -1542376862;
				num39 = num;
			}
			else
			{
				num = -516344763;
				num39 = num;
			}
			continue;
			IL_0615:
			int num40;
			if (iTParam2 != null)
			{
				num = -969113491;
				num40 = num;
			}
			else
			{
				num = -197609962;
				num40 = num;
			}
			continue;
			IL_07f6:
			iTParam3 = Params[num18];
			int num41;
			if (iTParam3.Min != -1.0)
			{
				num = -1615809319;
				num41 = num;
			}
			else
			{
				num = -653772818;
				num41 = num;
			}
			continue;
			IL_0764:
			int num42;
			if (!(trigger.Name == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1078516913u)))
			{
				num = -1145655356;
				num42 = num;
			}
			else
			{
				num = -1610458984;
				num42 = num;
			}
			continue;
			IL_062d:
			int num43;
			if (num19 >= list.Count)
			{
				num = -852736741;
				num43 = num;
			}
			else
			{
				num = -1075569579;
				num43 = num;
			}
			continue;
			IL_07d3:
			int num44;
			if (num18 >= Params.Count)
			{
				num = -516344763;
				num44 = num;
			}
			else
			{
				num = -1845984775;
				num44 = num;
			}
			continue;
			IL_02ad:
			int num45;
			if (iTParam == null)
			{
				num = -391355946;
				num45 = num;
			}
			else
			{
				num = -1859792425;
				num45 = num;
			}
			continue;
			IL_0679:
			int num46;
			if (iTParam == null)
			{
				num = -516344763;
				num46 = num;
			}
			else
			{
				num = -779049994;
				num46 = num;
			}
			continue;
			IL_078f:
			iTParam = Params[Tools.GetRandomInt(0, Params.Count - 1)];
			int num47;
			if (iTParam.Min == -1.0)
			{
				num = -1284204137;
				num47 = num;
			}
			else
			{
				num = -879492661;
				num47 = num;
			}
		}
		goto IL_0020;
		IL_04d9:
		int num48;
		if (Params.Count <= 0)
		{
			num = -516344763;
			num48 = num;
		}
		else
		{
			num = -1209793040;
			num48 = num;
		}
		goto IL_0025;
	}

	static bool _200B_202D_200B_206A_202C_200B_200B_200D_200B_200E_202D_206F_202D_200D_202C_200E_200B_200B_206E_202B_206D_202A_200E_200D_206A_200E_200F_206A_206D_206A_206B_200F_202C_206F_206B_206A_200B_200E_200E_206D_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static bool _200F_206F_202E_206D_206B_206B_206C_200F_202D_202C_202E_200F_202B_206C_200F_200E_206B_202A_206D_206D_200E_200B_200E_200C_206B_206B_206B_200C_202C_202B_202B_206C_206A_200E_206B_206E_202A_206C_206E_202B_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static string _202C_202E_206C_200E_200D_206B_206B_202D_206C_200E_206B_206E_206F_200C_202D_200F_202B_200B_200E_200C_202C_206B_206D_206A_200F_202E_202E_206F_202B_200B_200F_202B_202E_202D_206D_206C_206F_206A_206D_202C_202E(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}

	static string[] _200E_200C_206E_200B_200B_200F_202A_206D_202A_202B_206F_200F_202C_202E_202C_202E_200E_202A_206E_206E_206B_200C_202A_200C_202A_206D_200C_206F_206F_202A_206B_200C_202D_206E_200C_202E_206D_206C_202D_202C_202E(string P_0, char[] P_1)
	{
		return P_0.Split(P_1);
	}

	static string _200B_206F_206A_202C_206B_206F_206A_206D_200E_202B_206A_206B_206D_202A_200F_206C_200F_202D_200D_206B_202A_200F_200D_202A_202C_206A_202C_206D_206A_206B_202E_200E_206A_200C_200C_206D_206C_202A_202B_202C_202E(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static decimal _202C_200C_200B_206E_200C_206B_200F_206F_206B_200D_200B_206A_202E_200F_206A_200C_206B_202C_206D_202B_202C_206F_202D_200F_206E_200F_200F_206B_200F_206A_202E_202D_206D_206F_206E_200D_206E_206A_202B_200E_202E(decimal P_0, int P_1, MidpointRounding P_2)
	{
		return Math.Round(P_0, P_1, P_2);
	}

	static void _206F_200B_200D_202A_200D_206F_206E_206F_206D_200D_202E_200D_200F_200F_206E_200F_202A_200D_200B_206F_206F_200E_200F_206A_200D_202C_202D_206B_200F_200F_202D_202C_200D_206B_200D_200D_200F_202D_202D_206F_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static bool _200F_200F_200E_202C_202B_202D_200B_206B_200B_202C_202B_206E_206C_200B_202C_206F_206C_202D_206B_200D_206A_202E_200F_202D_206B_206B_200D_200D_200F_206B_202A_202D_200B_200E_206B_202A_206B_202C_200D_206C_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}
}
