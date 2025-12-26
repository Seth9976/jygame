using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace JyGame;

public class ZhenlongqijuLogic
{
	private static string[] randomWuqiName;

	private static string[] randomFangju;

	private static string[] randomShipin;

	[CompilerGenerated]
	private static CommonSettings.JudgeCallback _202B_200C_206A_200F_206E_206E_200B_202C_202E_206E_206F_202D_200C_202B_206E_200C_202A_202A_200C_202D_206F_206D_200F_202B_202C_206A_202A_202A_206E_200E_206E_202D_206B_200D_200F_206A_206B_200D_206A_206B_202E;

	[CompilerGenerated]
	private static CommonSettings.JudgeCallback _206C_206F_202A_206B_206D_206D_202C_202D_206B_202A_200E_202A_202C_202B_202A_206C_200D_202D_206B_200F_202A_200E_206A_206E_206B_200F_202B_200C_202E_206C_206C_200C_202B_206F_200F_200F_206A_206C_206D_206D_202E;

	[CompilerGenerated]
	private static CommonSettings.JudgeCallback _202A_202A_206B_202B_206A_202C_200D_206C_206C_202B_206C_200C_206D_202E_202C_200F_202C_206F_200B_202D_200F_200C_202E_200D_206C_202E_200B_202D_200D_202C_200F_200E_202B_206C_202C_206C_200C_206F_206D_202D_202E;

	static ZhenlongqijuLogic()
	{
		randomWuqiName = LuaManager.GetConfig<string[]>(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2743215920u));
		while (true)
		{
			int num = -2080991238;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -738612781)) % 4)
				{
				case 3u:
					break;
				default:
					return;
				case 1u:
					randomFangju = LuaManager.GetConfig<string[]>(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(904180667u));
					num = (int)(num2 * 428444099) ^ -232241694;
					continue;
				case 2u:
					randomShipin = LuaManager.GetConfig<string[]>(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3575227321u));
					num = ((int)num2 * -433818970) ^ 0x6168A3B3;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public static void CalcItems(List<ItemInstance> items)
	{
		int zhenlongqijuLevel = ModData.ZhenlongqijuLevel;
		int num14 = default(int);
		ItemInstance itemInstance = default(ItemInstance);
		InternalSkill randomInternalSkill3 = default(InternalSkill);
		int num4 = default(int);
		InternalSkill randomInternalSkill2 = default(InternalSkill);
		InternalSkill randomInternalSkill = default(InternalSkill);
		int num12 = default(int);
		int num7 = default(int);
		while (true)
		{
			int num = 614751838;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7472BED7)) % 56)
				{
				case 39u:
					break;
				default:
					return;
				case 8u:
					num14 = _206E_202A_200E_202E_202A_206B_206C_206C_206A_202C_200E_200C_200F_206E_200B_202C_202E_202C_200D_206A_200E_200D_200E_206D_202B_200B_202C_202E_206E_206F_206F_200B_200C_206E_206B_202A_202E_206B_200F_202E(num14, 2);
					num = (int)((num2 * 1121358753) ^ 0x4D91BE84);
					continue;
				case 16u:
				{
					int num30;
					if (Tools.ProbabilityTest(0.1))
					{
						num = 115681361;
						num30 = num;
					}
					else
					{
						num = 617523712;
						num30 = num;
					}
					continue;
				}
				case 22u:
					itemInstance.AddRandomTriggers(Tools.GetRandomInt(4, 8));
					num = 861455952;
					continue;
				case 38u:
				{
					int num29;
					if (CommonSettings.MOD_KEY() == 4)
					{
						num = 1568106643;
						num29 = num;
					}
					else
					{
						num = 1789684924;
						num29 = num;
					}
					continue;
				}
				case 33u:
					items.Add(Item.GetCanzhang(_202A_206D_200E_202B_206B_202A_200C_202C_202E_200F_200F_200B_200F_206D_206E_202D_200E_202A_202E_202C_206F_206C_200D_206F_202C_202A_206C_202E_206D_200C_206D_206B_202D_200E_200B_206F_206F_206B_202A_202E_202E(randomInternalSkill3.Name, ResourceStrings.ResStrings[331])).Generate(setRandomTrigger: false));
					num = ((int)num2 * -38905011) ^ -804834949;
					continue;
				case 44u:
					itemInstance.AddRandomTriggers(Tools.GetRandomInt(1, 6));
					num = ((int)num2 * -1007467795) ^ -230325795;
					continue;
				case 19u:
					num14 = _206E_202A_200E_202E_202A_206B_206C_206C_206A_202C_200E_200C_200F_206E_200B_202C_202E_202C_200D_206A_200E_200D_200E_206D_202B_200B_202C_202E_206E_206F_206F_200B_200C_206E_206B_202A_202E_206B_200F_202E(num14, 4);
					num = (int)((num2 * 1655197972) ^ 0x406874D2);
					continue;
				case 34u:
					randomInternalSkill3 = GetRandomInternalSkill(1, 7);
					num = 29682406;
					continue;
				case 9u:
				{
					int num19;
					if (Tools.ProbabilityTest(0.3 + BattleField.fjtl_percent))
					{
						num = 1708809029;
						num19 = num;
					}
					else
					{
						num = 1954141804;
						num19 = num;
					}
					continue;
				}
				case 54u:
					num = (int)(num2 * 3744331) ^ -565450438;
					continue;
				case 49u:
				{
					List<string> list = new List<string>();
					list.AddRange(randomWuqiName.AsEnumerable());
					list.AddRange(randomFangju.AsEnumerable());
					list.AddRange(randomShipin.AsEnumerable());
					itemInstance = Item.GetItem(list[Tools.GetRandomInt(0, list.Count - 1)]).Generate(setRandomTrigger: false);
					num = ((int)num2 * -154323712) ^ 0x298F124A;
					continue;
				}
				case 17u:
					num = ((int)num2 * -345425255) ^ 0x2BB6E7D1;
					continue;
				case 36u:
					num4++;
					num = 150775340;
					continue;
				case 46u:
					num = (int)((num2 * 2015700175) ^ 0x6EA04D9C);
					continue;
				case 18u:
					randomInternalSkill2 = GetRandomInternalSkill(8, _206B_206A_202C_202D_202E_206F_202C_206D_200F_206D_206D_200D_206C_202B_202E_202A_200F_206D_202E_200C_200D_206D_206B_202A_202E_202E_200B_202C_206A_200B_206E_200C_200E_206E_200E_202D_202C_200B_206C_200D_202E(10, (int)((float)zhenlongqijuLevel * 0.1f)));
					num = 987835504;
					continue;
				case 47u:
					itemInstance.AddRandomTriggers(Tools.GetRandomInt(4 + num14, 10 + num14));
					num = 861455952;
					continue;
				case 40u:
				{
					int num31;
					int num32;
					if (Tools.ProbabilityTest(0.001))
					{
						num31 = 1375947247;
						num32 = num31;
					}
					else
					{
						num31 = 1253070634;
						num32 = num31;
					}
					num = num31 ^ ((int)num2 * -1280399926);
					continue;
				}
				case 45u:
				{
					int num26;
					if (!Tools.ProbabilityTest(0.003))
					{
						num = 2139740499;
						num26 = num;
					}
					else
					{
						num = 574802283;
						num26 = num;
					}
					continue;
				}
				case 53u:
				{
					int num21;
					int num22;
					if (CommonSettings.MOD_KEY() == 1)
					{
						num21 = -1207246557;
						num22 = num21;
					}
					else
					{
						num21 = -1346778953;
						num22 = num21;
					}
					num = num21 ^ ((int)num2 * -1707650050);
					continue;
				}
				case 15u:
					num14 = (int)(((double)zhenlongqijuLevel + BattleField.fjtl_percent * 100.0) / 100.0);
					num = 1175371711;
					continue;
				case 24u:
					randomInternalSkill = GetRandomInternalSkill(1, 7);
					num = 558571210;
					continue;
				case 52u:
				{
					int num16;
					if (num12 >= zhenlongqijuLevel)
					{
						num = 1734439375;
						num16 = num;
					}
					else
					{
						num = 2115652030;
						num16 = num;
					}
					continue;
				}
				case 2u:
					num14 = 0;
					num = ((int)num2 * -1970588834) ^ -137900141;
					continue;
				case 1u:
				{
					int num10;
					int num11;
					if (Tools.ProbabilityTest(0.6))
					{
						num10 = -971680470;
						num11 = num10;
					}
					else
					{
						num10 = -1217171288;
						num11 = num10;
					}
					num = num10 ^ (int)(num2 * 1495726535);
					continue;
				}
				case 42u:
					num = ((int)num2 * -1117081977) ^ -1233641370;
					continue;
				case 10u:
					itemInstance.AddRandomTriggers(Tools.GetRandomInt(1, 4));
					num = (int)((num2 * 91705913) ^ 0x124EE072);
					continue;
				case 7u:
					items.Add(itemInstance);
					return;
				case 48u:
					num4 = 0;
					num = 1949280931;
					continue;
				case 0u:
				{
					int num34;
					if (num14 < 2)
					{
						num = 225442944;
						num34 = num;
					}
					else
					{
						num = 1165935479;
						num34 = num;
					}
					continue;
				}
				case 4u:
					num = ((int)num2 * -859266625) ^ 0x311390A0;
					continue;
				case 37u:
				{
					Skill randomSkill3 = GetRandomSkill(8, _206B_206A_202C_202D_202E_206F_202C_206D_200F_206D_206D_200D_206C_202B_202E_202A_200F_206D_202E_200C_200D_206D_206B_202A_202E_202E_200B_202C_206A_200B_206E_200C_200E_206E_200E_202D_202C_200B_206C_200D_202E(10, (int)((float)zhenlongqijuLevel * 0.1f)));
					items.Add(Item.GetCanzhang(_202A_206D_200E_202B_206B_202A_200C_202C_202E_200F_200F_200B_200F_206D_206E_202D_200E_202A_202E_202C_206F_206C_200D_206F_202C_202A_206C_202E_206D_200C_206D_206B_202D_200E_200B_206F_206F_206B_202A_202E_202E(randomSkill3.Name, ResourceStrings.ResStrings[331])).Generate(setRandomTrigger: false));
					num = ((int)num2 * -59234905) ^ 0x7208716D;
					continue;
				}
				case 43u:
				{
					int num33;
					if (Tools.ProbabilityTest(0.3 + BattleField.fjtl_percent))
					{
						num = 399689590;
						num33 = num;
					}
					else
					{
						num = 1848378683;
						num33 = num;
					}
					continue;
				}
				case 30u:
					num14 = _206E_202A_200E_202E_202A_206B_206C_206C_206A_202C_200E_200C_200F_206E_200B_202C_202E_202C_200D_206A_200E_200D_200E_206D_202B_200B_202C_202E_206E_206F_206F_200B_200C_206E_206B_202A_202E_206B_200F_202E(num14, 3);
					num = ((int)num2 * -1964069516) ^ -2070725064;
					continue;
				case 14u:
				{
					int num27;
					int num28;
					if (Tools.ProbabilityTest(0.6))
					{
						num27 = 341253778;
						num28 = num27;
					}
					else
					{
						num27 = 1443937829;
						num28 = num27;
					}
					num = num27 ^ ((int)num2 * -562726360);
					continue;
				}
				case 5u:
				{
					int num24;
					int num25;
					if (CommonSettings.MOD_KEY() != -1)
					{
						num24 = -189417354;
						num25 = num24;
					}
					else
					{
						num24 = -754613597;
						num25 = num24;
					}
					num = num24 ^ ((int)num2 * -1905214666);
					continue;
				}
				case 20u:
					num14 = _206E_202A_200E_202E_202A_206B_206C_206C_206A_202C_200E_200C_200F_206E_200B_202C_202E_202C_200D_206A_200E_200D_200E_206D_202B_200B_202C_202E_206E_206F_206F_200B_200C_206E_206B_202A_202E_206B_200F_202E(num14, 5);
					num = ((int)num2 * -2137420010) ^ 0x20E62F95;
					continue;
				case 27u:
				{
					int num23;
					if (num4 < zhenlongqijuLevel)
					{
						num = 496329516;
						num23 = num;
					}
					else
					{
						num = 862046820;
						num23 = num;
					}
					continue;
				}
				case 25u:
					num7--;
					num = 1656640064;
					continue;
				case 26u:
				{
					Skill randomSkill2 = GetRandomSkill(1, 7);
					items.Add(Item.GetCanzhang(_202A_206D_200E_202B_206B_202A_200C_202C_202E_200F_200F_200B_200F_206D_206E_202D_200E_202A_202E_202C_206F_206C_200D_206F_202C_202A_206C_202E_206D_200C_206D_206B_202D_200E_200B_206F_206F_206B_202A_202E_202E(randomSkill2.Name, ResourceStrings.ResStrings[331])).Generate(setRandomTrigger: false));
					num = ((int)num2 * -1826052517) ^ 0x713FF44C;
					continue;
				}
				case 32u:
					num14 = _206E_202A_200E_202E_202A_206B_206C_206C_206A_202C_200E_200C_200F_206E_200B_202C_202E_202C_200D_206A_200E_200D_200E_206D_202B_200B_202C_202E_206E_206F_206F_200B_200C_206E_206B_202A_202E_206B_200F_202E(num14, 6);
					num = (int)(num2 * 1081400101) ^ -2106076968;
					continue;
				case 31u:
					items.Add(Item.GetCanzhang(_202A_206D_200E_202B_206B_202A_200C_202C_202E_200F_200F_200B_200F_206D_206E_202D_200E_202A_202E_202C_206F_206C_200D_206F_202C_202A_206C_202E_206D_200C_206D_206B_202D_200E_200B_206F_206F_206B_202A_202E_202E(randomInternalSkill2.Name, ResourceStrings.ResStrings[331])).Generate(setRandomTrigger: false));
					num = ((int)num2 * -192607814) ^ -2080056480;
					continue;
				case 51u:
					num12++;
					num = 1861901979;
					continue;
				case 6u:
					num14 = 1;
					num = 225442944;
					continue;
				case 13u:
				{
					int num20;
					if (!Tools.ProbabilityTest(0.5 + BattleField.fjtl_percent))
					{
						num = 236293318;
						num20 = num;
					}
					else
					{
						num = 1165616889;
						num20 = num;
					}
					continue;
				}
				case 50u:
				{
					int num17;
					int num18;
					if (Tools.ProbabilityTest(0.6))
					{
						num17 = -413938680;
						num18 = num17;
					}
					else
					{
						num17 = -881444337;
						num18 = num17;
					}
					num = num17 ^ ((int)num2 * -1801611983);
					continue;
				}
				case 23u:
				{
					int num15;
					if (!Tools.ProbabilityTest(0.5))
					{
						num = 2068946809;
						num15 = num;
					}
					else
					{
						num = 147388615;
						num15 = num;
					}
					continue;
				}
				case 21u:
					items.Add(Item.GetCanzhang(_202A_206D_200E_202B_206B_202A_200C_202C_202E_200F_200F_200B_200F_206D_206E_202D_200E_202A_202E_202C_206F_206C_200D_206F_202C_202A_206C_202E_206D_200C_206D_206B_202D_200E_200B_206F_206F_206B_202A_202E_202E(randomInternalSkill.Name, ResourceStrings.ResStrings[331])).Generate(setRandomTrigger: false));
					num = (int)(num2 * 1466658995) ^ -822965699;
					continue;
				case 28u:
				{
					int num13;
					if (Tools.ProbabilityTest(0.02))
					{
						num = 214922244;
						num13 = num;
					}
					else
					{
						num = 680158911;
						num13 = num;
					}
					continue;
				}
				case 41u:
					num7 = 1 + (int)(((double)zhenlongqijuLevel + BattleField.fjtl_percent * 100.0) / 100.0);
					num12 = 0;
					num = 1861901979;
					continue;
				case 55u:
				{
					int num8;
					int num9;
					if (num7 > 0)
					{
						num8 = 1141621051;
						num9 = num8;
					}
					else
					{
						num8 = 1460889240;
						num9 = num8;
					}
					num = num8 ^ (int)(num2 * 1925563201);
					continue;
				}
				case 12u:
				{
					int num5;
					int num6;
					if (RuntimeData.Instance.Round > 2)
					{
						num5 = 1089065530;
						num6 = num5;
					}
					else
					{
						num5 = 1887509793;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1137181928);
					continue;
				}
				case 35u:
				{
					int num3;
					if (!Tools.ProbabilityTest(0.3))
					{
						num = 1046327105;
						num3 = num;
					}
					else
					{
						num = 81789291;
						num3 = num;
					}
					continue;
				}
				case 29u:
				{
					Skill randomSkill = GetRandomSkill(1, 7);
					items.Add(Item.GetCanzhang(_202A_206D_200E_202B_206B_202A_200C_202C_202E_200F_200F_200B_200F_206D_206E_202D_200E_202A_202E_202C_206F_206C_200D_206F_202C_202A_206C_202E_206D_200C_206D_206B_202D_200E_200B_206F_206F_206B_202A_202E_202E(randomSkill.Name, ResourceStrings.ResStrings[331])).Generate(setRandomTrigger: false));
					num = (int)(num2 * 1864253541) ^ -1446993800;
					continue;
				}
				case 11u:
					num = (int)(num2 * 380437776) ^ -507269200;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public static void PowerupRole(Role role, int level)
	{
		role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2431070502u)] = (int)((double)role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(592457607u)] * (1.0 + (double)level * 0.1)) + level * 2000;
		double num7 = default(double);
		double num35 = default(double);
		int randomInt = default(int);
		double num28 = default(double);
		double num37 = default(double);
		ItemInstance itemInstance2 = default(ItemInstance);
		ItemInstance itemInstance3 = default(ItemInstance);
		int num19 = default(int);
		ItemInstance itemInstance = default(ItemInstance);
		while (true)
		{
			int num = 1302736018;
			while (true)
			{
				int num8;
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2C976A11)) % 50)
				{
				case 23u:
					break;
				case 10u:
				{
					int num44;
					if (_206E_202D_206F_202C_200C_206E_202E_206D_200D_206D_200B_202B_206A_206C_206E_206E_206E_206F_206A_206D_206A_202C_202E_200B_202A_206D_200C_200F_202D_202E_206E_200D_202D_206E_206B_202D_206A_206D_206F_200C_202E(RuntimeData.Instance.GameMode, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3441403404u)))
					{
						num = 933452103;
						num44 = num;
					}
					else
					{
						num = 1323610155;
						num44 = num;
					}
					continue;
				}
				case 9u:
					num7 *= Tools.GetRandom(1.08, 1.1);
					num = (int)((num2 * 1082469758) ^ 0x2D525C05);
					continue;
				case 45u:
					num35 -= 1.0;
					num = 1177388229;
					continue;
				case 26u:
					role.addRoundSkillLevel_Zhenlongqiju();
					num = (int)((num2 * 871577975) ^ 0x211E8003);
					continue;
				case 37u:
					num7 *= Tools.GetRandom(1.01, 1.03);
					num = ((int)num2 * -275421381) ^ -1098868070;
					continue;
				case 1u:
					role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1923523063u)] = role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(912726802u)] + Tools.GetRandomInt(0, 2);
					num = (int)(num2 * 1507103172) ^ -589577304;
					continue;
				case 4u:
					num = (int)(num2 * 1989169811) ^ -1602493817;
					continue;
				case 34u:
					role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2475589736u)] = role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1550623476u)] + Tools.GetRandomInt(0, 2);
					num = ((int)num2 * -1442609878) ^ 0x2B25B6AC;
					continue;
				case 25u:
					num = (int)(num2 * 113857638) ^ -1949689290;
					continue;
				case 6u:
					randomInt = Tools.GetRandomInt(1, 6);
					num = 2043005766;
					continue;
				case 29u:
					role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2722506620u)] = role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(424952987u)] + Tools.GetRandomInt(level * 2, level * 4);
					num = ((int)num2 * -741707063) ^ -538596147;
					continue;
				case 33u:
					num7 = _206F_202B_202B_206E_202C_200B_202A_206F_202A_202A_206A_206A_206F_202D_206C_202B_206D_202A_202D_206B_206D_206D_202E_200D_206A_200E_206E_202C_202A_200B_200E_202D_200B_206B_200B_200C_200F_200F_202B_200C_202E(num35) * Tools.GetRandom(1.0, 1.1) + (double)level / 100.0;
					num = (int)(num2 * 1275534816) ^ -1423146096;
					continue;
				case 46u:
					num7 *= Tools.GetRandom(1.05, 1.07);
					num = (int)((num2 * 698932922) ^ 0x3F3B0169);
					continue;
				case 40u:
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(394181284u)] = role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(394181284u)] + Tools.GetRandomInt(level * 2, level * 4);
					num = (int)(num2 * 267914397) ^ -2091283961;
					continue;
				case 39u:
					role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1564888282u)] = role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(710450445u)] + Tools.GetRandomInt(0, 1);
					num = (int)((num2 * 204754122) ^ 0x6C1ED19E);
					continue;
				case 3u:
					role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3051962998u)] = role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3583101943u)] + Tools.GetRandomInt(level * 2, level * 4);
					num = ((int)num2 * -646691244) ^ -650507501;
					continue;
				case 13u:
				{
					int num40;
					int num41;
					if (num28 >= 0.0)
					{
						num40 = -577774845;
						num41 = num40;
					}
					else
					{
						num40 = -172449226;
						num41 = num40;
					}
					num = num40 ^ (int)(num2 * 209130345);
					continue;
				}
				case 43u:
					num = (int)((num2 * 1840019157) ^ 0x304C712D);
					continue;
				case 32u:
				{
					int num36;
					if (!(num35 <= 1.0))
					{
						num = 1102981295;
						num36 = num;
					}
					else
					{
						num = 1482730427;
						num36 = num;
					}
					continue;
				}
				case 36u:
					role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(942219431u)] = role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4176639349u)] + Tools.GetRandomInt(level * 2, level * 4);
					num = (int)((num2 * 645875520) ^ 0x648130ED);
					continue;
				case 19u:
				{
					int num31;
					int num32;
					if (!RuntimeData.Instance.AutoSaveOnly)
					{
						num31 = -578650605;
						num32 = num31;
					}
					else
					{
						num31 = -930607226;
						num32 = num31;
					}
					num = num31 ^ ((int)num2 * -1522044530);
					continue;
				}
				case 27u:
					role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(269729863u)] = role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(248942232u)] + (int)num7;
					num = ((int)num2 * -1829702349) ^ -457613404;
					continue;
				case 22u:
					role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3665747899u)] = role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(710450445u)] + (int)num7;
					num = 1738751984;
					continue;
				case 7u:
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2186305609u)] = role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2741516750u)] + (int)num7;
					role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1790491204u)] = role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3051962998u)] + (int)num7;
					num = ((int)num2 * -437685156) ^ 0x327AADDD;
					continue;
				case 16u:
				{
					int num25;
					if (randomInt == 4)
					{
						num = 1130056040;
						num25 = num;
					}
					else
					{
						num = 1381277188;
						num25 = num;
					}
					continue;
				}
				case 8u:
				{
					num37 = (double)role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(475395429u)] * (1.0 + CommonSettings.ZHOUMU_MP_ADD * (double)(RuntimeData.Instance.Round - 1) * Tools.GetRandom(0.09, 0.11));
					int num47;
					int num48;
					if (!(num28 > 2147483647.0))
					{
						num47 = -1926099414;
						num48 = num47;
					}
					else
					{
						num47 = -1950178555;
						num48 = num47;
					}
					num = num47 ^ (int)(num2 * 2019337832);
					continue;
				}
				case 49u:
				{
					int num45;
					int num46;
					if (num37 >= 0.0)
					{
						num45 = -867525874;
						num46 = num45;
					}
					else
					{
						num45 = -250966560;
						num46 = num45;
					}
					num = num45 ^ ((int)num2 * -1001000272);
					continue;
				}
				case 12u:
				{
					int num42;
					int num43;
					if (CommonSettings.MOD_KEY() == 1)
					{
						num42 = -682031099;
						num43 = num42;
					}
					else
					{
						num42 = -915465889;
						num43 = num42;
					}
					num = num42 ^ ((int)num2 * -1324708966);
					continue;
				}
				case 5u:
					num37 = 2147483647.0;
					num = 1165644862;
					continue;
				case 48u:
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2249625138u)] = role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1977936243u)] + (int)num7;
					num = (int)((num2 * 1911651879) ^ 0x14D2B12F);
					continue;
				case 14u:
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(136168559u)] = role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(739543880u)] + Tools.GetRandomInt(level * 2, level * 4);
					num = (int)((num2 * 2026412470) ^ 0x29AFBA88);
					continue;
				case 24u:
				{
					int num39;
					if (_206E_202D_206F_202C_200C_206E_202E_206D_200D_206D_200B_202B_206A_206C_206E_206E_206E_206F_206A_206D_206A_202C_202E_200B_202A_206D_200C_200F_202D_202E_206E_200D_202D_206E_206B_202D_206A_206D_206F_200C_202E(RuntimeData.Instance.GameMode, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3809679645u)))
					{
						num = 87131378;
						num39 = num;
					}
					else
					{
						num = 70646219;
						num39 = num;
					}
					continue;
				}
				case 30u:
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2575692001u)] = role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1790491204u)] + Tools.GetRandomInt(0, 2);
					num = (int)(num2 * 131293922) ^ -1039041968;
					continue;
				case 31u:
					role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2431070502u)] = (int)num28;
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(187771104u)] = (int)num37;
					num35 = (double)_206E_202A_200E_202E_202A_206B_206C_206C_206A_202C_200E_200C_200F_206E_200B_202C_202E_202C_200D_206A_200E_200D_200E_206D_202B_200B_202C_202E_206E_206F_206F_200B_200C_206E_206B_202A_202E_206B_200F_202E(role.MAX_LEVEL, 199) - (double)role.Level;
					num = 144129854;
					continue;
				case 35u:
				{
					int num38;
					if (!(num37 > 2147483647.0))
					{
						num = 699141960;
						num38 = num;
					}
					else
					{
						num = 2017084112;
						num38 = num;
					}
					continue;
				}
				case 15u:
				{
					int num33;
					int num34;
					if (randomInt != 1)
					{
						num33 = 1790893537;
						num34 = num33;
					}
					else
					{
						num33 = 1644324669;
						num34 = num33;
					}
					num = num33 ^ (int)(num2 * 419942127);
					continue;
				}
				case 28u:
					num28 = 2147483647.0;
					num = 2110045040;
					continue;
				case 47u:
					role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2077292732u)] = role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1029863417u)] + Tools.GetRandomInt(level * 2, level * 4);
					num = ((int)num2 * -1113395493) ^ -1140291996;
					continue;
				case 42u:
					role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(701808387u)] = role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(701808387u)] + (int)num7;
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1550623476u)] = role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1412133437u)] + (int)num7;
					role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(739543880u)] = role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1368077529u)] + (int)num7;
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(199488088u)] = role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1944260873u)] + (int)num7;
					role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2077292732u)] = role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2077292732u)] + (int)num7;
					num = (int)(num2 * 153904128) ^ -1253968240;
					continue;
				case 18u:
					role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1923523063u)] = role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3406067330u)] + Tools.GetRandomInt(level * 2, level * 4);
					role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1550623476u)] = role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1412133437u)] + Tools.GetRandomInt(level * 2, level * 4);
					num = (int)(num2 * 1042748740) ^ -850406977;
					continue;
				case 20u:
				{
					int num29;
					int num30;
					if (CommonSettings.MOD_KEY() >= 0)
					{
						num29 = 2037399269;
						num30 = num29;
					}
					else
					{
						num29 = 1063465201;
						num30 = num29;
					}
					num = num29 ^ (int)(num2 * 946568323);
					continue;
				}
				case 44u:
					num28 = (double)role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1995100678u)] * (1.0 + CommonSettings.ZHOUMU_HP_ADD * (double)(RuntimeData.Instance.Round - 1) * Tools.GetRandom(0.09, 0.11));
					num = ((int)num2 * -245156888) ^ 0x38A5BE69;
					continue;
				case 38u:
				{
					int num27;
					if (randomInt == 3)
					{
						num = 666122783;
						num27 = num;
					}
					else
					{
						num = 219176157;
						num27 = num;
					}
					continue;
				}
				case 41u:
					role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2741516750u)] = role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(664072894u)] + Tools.GetRandomInt(0, 2);
					num = (int)(num2 * 548861078) ^ -1175443108;
					continue;
				case 17u:
					role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1306348308u)] = (int)((double)role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(187771104u)] * (1.0 + (double)level * 0.1)) + level * 2000;
					role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(710450445u)] = role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(710450445u)] + Tools.GetRandomInt(level * 2, level * 4);
					role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2930940463u)] = role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2930940463u)] + Tools.GetRandomInt(level * 2, level * 4);
					num = ((int)num2 * -1685496559) ^ 0x6C649075;
					continue;
				case 11u:
				{
					int num26;
					if (randomInt != 2)
					{
						num = 615088319;
						num26 = num;
					}
					else
					{
						num = 1405891586;
						num26 = num;
					}
					continue;
				}
				case 21u:
				{
					int num24;
					if (randomInt != 5)
					{
						num = 441733981;
						num24 = num;
					}
					else
					{
						num = 2005761793;
						num24 = num;
					}
					continue;
				}
				case 2u:
					role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(739543880u)] = role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1368077529u)] + Tools.GetRandomInt(0, 2);
					num = 1968009740;
					continue;
				default:
					{
						using (List<InternalSkillInstance>.Enumerator enumerator = role.InternalSkills.GetEnumerator())
						{
							while (true)
							{
								IL_0cbd:
								int num3;
								int num4;
								if (!enumerator.MoveNext())
								{
									num3 = 601724685;
									num4 = num3;
								}
								else
								{
									num3 = 1803997500;
									num4 = num3;
								}
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ 0x2C976A11)) % 4)
									{
									case 2u:
										num3 = 1803997500;
										continue;
									default:
										goto end_IL_0c68;
									case 1u:
									{
										InternalSkillInstance current = enumerator.Current;
										current.level += Tools.GetRandomInt(level / 5, level / 3);
										current.level2 = 0f - (float)current.level;
										num3 = 1390810662;
										continue;
									}
									case 3u:
										break;
									case 0u:
										goto end_IL_0c68;
									}
									goto IL_0cbd;
									continue;
									end_IL_0c68:
									break;
								}
								break;
							}
						}
						using (List<SkillInstance>.Enumerator enumerator2 = role.Skills.GetEnumerator())
						{
							while (true)
							{
								IL_0d50:
								int num5;
								int num6;
								if (!enumerator2.MoveNext())
								{
									num5 = 1077528246;
									num6 = num5;
								}
								else
								{
									num5 = 153815736;
									num6 = num5;
								}
								while (true)
								{
									switch ((num2 = (uint)(num5 ^ 0x2C976A11)) % 4)
									{
									case 2u:
										num5 = 153815736;
										continue;
									default:
										goto end_IL_0cfb;
									case 1u:
									{
										SkillInstance current2 = enumerator2.Current;
										current2.level += Tools.GetRandomInt(level / 5, level / 3);
										current2.level2 = 0f - (float)current2.level;
										num5 = 438373513;
										continue;
									}
									case 0u:
										break;
									case 3u:
										goto end_IL_0cfb;
									}
									goto IL_0d50;
									continue;
									end_IL_0cfb:
									break;
								}
								break;
							}
						}
						role.addRandomTalentAndWeapons();
						if (role.Equipment == null)
						{
							goto IL_0d8b;
						}
						goto IL_0e30;
					}
					IL_0e30:
					role.Equipment.Clear();
					num8 = 288198558;
					goto IL_0d90;
					IL_0d90:
					while (true)
					{
						switch ((num2 = (uint)(num8 ^ 0x2C976A11)) % 24)
						{
						case 5u:
							break;
						case 6u:
						{
							int num13;
							int num14;
							if (RuntimeData.Instance.Round <= 2)
							{
								num13 = 543861455;
								num14 = num13;
							}
							else
							{
								num13 = 2081478810;
								num14 = num13;
							}
							num8 = num13 ^ (int)(num2 * 1600426045);
							continue;
						}
						case 14u:
							goto IL_0e30;
						case 10u:
							itemInstance2.AddRandomTriggers(4);
							num8 = 254351981;
							continue;
						case 21u:
							num8 = (int)((num2 * 971526497) ^ 0x50AD77F7);
							continue;
						case 18u:
							itemInstance3.AddRandomTriggers(Tools.GetRandomInt(4 + num19, 8 + num19));
							num8 = (int)((num2 * 1652052778) ^ 0x2B3C5BF8);
							continue;
						case 19u:
							itemInstance2.AddRandomTriggers(Tools.GetRandomInt(4 + num19, 8 + num19));
							num8 = ((int)num2 * -527755077) ^ -1068794756;
							continue;
						case 16u:
							itemInstance3.AddRandomTriggers(4);
							num8 = 55514634;
							continue;
						case 22u:
							num19 = 4;
							num8 = ((int)num2 * -1929818549) ^ 0x4320A7A9;
							continue;
						case 13u:
							itemInstance.AddRandomTriggers(Tools.GetRandomInt(4 + num19, 8 + num19));
							num8 = (int)((num2 * 393183042) ^ 0x18D122B2);
							continue;
						case 7u:
						{
							int num15;
							int num16;
							if (role.Equipment.Count == 0)
							{
								num15 = 1289319265;
								num16 = num15;
							}
							else
							{
								num15 = 1381306007;
								num16 = num15;
							}
							num8 = num15 ^ ((int)num2 * -720768921);
							continue;
						}
						case 1u:
							num8 = ((int)num2 * -1179958625) ^ -1550613763;
							continue;
						case 9u:
							role.Equipment = new List<ItemInstance>();
							num8 = (int)(num2 * 2012712691) ^ -1351573444;
							continue;
						case 17u:
						{
							num19 = (int)((double)ModData.ZhenlongqijuLevel / 100.0);
							int num20;
							int num21;
							if (num19 <= 4)
							{
								num20 = -615853497;
								num21 = num20;
							}
							else
							{
								num20 = -54749909;
								num21 = num20;
							}
							num8 = num20 ^ (int)(num2 * 98743236);
							continue;
						}
						case 15u:
						{
							int num17;
							int num18;
							if (!Tools.ProbabilityTest(0.3))
							{
								num17 = -1969007500;
								num18 = num17;
							}
							else
							{
								num17 = -2084494672;
								num18 = num17;
							}
							num8 = num17 ^ ((int)num2 * -1321007213);
							continue;
						}
						case 0u:
							itemInstance3 = ItemInstance.Generate(randomFangju[Tools.GetRandomInt(0, randomFangju.Length - 1)]);
							num8 = ((int)num2 * -1713741427) ^ -1940030194;
							continue;
						case 4u:
						{
							int num11;
							int num12;
							if (RuntimeData.Instance.Round <= 2)
							{
								num11 = -308446795;
								num12 = num11;
							}
							else
							{
								num11 = -399833985;
								num12 = num11;
							}
							num8 = num11 ^ ((int)num2 * -1231070487);
							continue;
						}
						case 8u:
							itemInstance.AddRandomTriggers(4);
							num8 = 1871959706;
							continue;
						case 3u:
							goto IL_1030;
						case 12u:
						{
							int num9;
							int num10;
							if (RuntimeData.Instance.Round <= 2)
							{
								num9 = 816142139;
								num10 = num9;
							}
							else
							{
								num9 = 108900154;
								num10 = num9;
							}
							num8 = num9 ^ ((int)num2 * -900217578);
							continue;
						}
						case 20u:
							role.Equipment.Add(itemInstance2);
							num8 = 2058326945;
							continue;
						case 11u:
							role.Equipment.Add(itemInstance);
							num8 = 1211785758;
							continue;
						case 2u:
							goto IL_10d6;
						default:
							role.Reset();
							return;
						}
						break;
						IL_10d6:
						itemInstance2 = ItemInstance.Generate(randomWuqiName[Tools.GetRandomInt(0, randomWuqiName.Length - 1)]);
						int num22;
						if (Tools.ProbabilityTest(0.3))
						{
							num8 = 582047581;
							num22 = num8;
						}
						else
						{
							num8 = 1106089907;
							num22 = num8;
						}
						continue;
						IL_1030:
						role.Equipment.Add(itemInstance3);
						itemInstance = ItemInstance.Generate(randomShipin[Tools.GetRandomInt(0, randomShipin.Length - 1)]);
						int num23;
						if (Tools.ProbabilityTest(0.3))
						{
							num8 = 810428943;
							num23 = num8;
						}
						else
						{
							num8 = 1642565097;
							num23 = num8;
						}
					}
					goto IL_0d8b;
					IL_0d8b:
					num8 = 2143875448;
					goto IL_0d90;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private static bool _202D_206F_202A_200C_206F_202E_206E_206C_202D_202D_202E_206F_206F_202D_202E_206E_202C_200E_206A_200D_200C_202B_202C_202E_200E_200E_206D_200E_206A_206B_206F_200F_202A_202E_206C_202A_200B_202D_206D_206D_202E(object P_0)
	{
		return (P_0 as Skill).Hard < 8f;
	}

	[CompilerGenerated]
	private static bool _206F_202C_200D_200B_200F_206F_206A_200B_206D_200F_200D_200C_202B_206D_202E_202E_200B_206E_202B_206B_202E_200F_202C_206E_202B_206C_206F_202C_206D_200E_202B_206F_200D_206E_202A_206B_202B_206D_202A_200F_202E(object P_0)
	{
		return (P_0 as Skill).Hard < 8f;
	}

	[CompilerGenerated]
	private static bool _206C_206C_200B_206E_200C_202A_206E_202B_206A_200B_206C_200B_206C_206F_206F_202D_206D_202B_202B_206E_202B_206D_202B_202E_200B_206C_206D_200E_200F_200B_206F_202C_206E_202C_200C_200E_200D_202B_202D_206D_202E(object P_0)
	{
		return (P_0 as Skill).Hard >= 8f;
	}

	private static Skill GetRandomSkill(int minHard, int maxHard)
	{
		List<Skill> list = new List<Skill>();
		IEnumerator<Skill> enumerator = ResourceManager.GetAll<Skill>().GetEnumerator();
		try
		{
			Skill current = default(Skill);
			while (true)
			{
				IL_00a2:
				int num;
				int num2;
				if (!_202E_202E_206C_206D_206E_200C_206A_200E_206A_202C_200D_202A_206B_206C_200D_200F_202B_206D_200B_206B_202D_206E_206C_202E_200E_202C_200B_200B_202D_206A_206B_202E_202A_206D_202E_206A_200D_202B_200E_206B_202E((IEnumerator)enumerator))
				{
					num = 1002040853;
					num2 = num;
				}
				else
				{
					num = 965849185;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ 0x3A5AFBAE)) % 6)
					{
					case 2u:
						num = 965849185;
						continue;
					default:
						goto end_IL_001b;
					case 5u:
					{
						current = enumerator.Current;
						int num6;
						if (current.Hard < (float)minHard)
						{
							num = 1234336194;
							num6 = num;
						}
						else
						{
							num = 426816594;
							num6 = num;
						}
						continue;
					}
					case 3u:
						list.Add(current);
						num = ((int)num3 * -1808138256) ^ 0xD6CBE52;
						continue;
					case 0u:
					{
						int num4;
						int num5;
						if (current.Hard > (float)maxHard)
						{
							num4 = -1720063366;
							num5 = num4;
						}
						else
						{
							num4 = -980935791;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 2143257362);
						continue;
					}
					case 4u:
						break;
					case 1u:
						goto end_IL_001b;
					}
					goto IL_00a2;
					continue;
					end_IL_001b:
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
					IL_00c3:
					int num7 = 1688614880;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num7 ^ 0x3A5AFBAE)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_00c8;
						case 1u:
							goto IL_00e5;
						case 2u:
							goto end_IL_00c8;
						}
						goto IL_00c3;
						IL_00e5:
						_200D_206F_200D_202E_200C_200B_200E_206C_206C_206D_206D_206F_202E_200F_206B_202B_206E_200B_202E_202A_206F_202C_206B_206D_200F_200B_202C_206E_206C_206F_206A_200D_200B_206F_200F_200E_202B_206D_206F_200E_202E((IDisposable)enumerator);
						num7 = (int)((num3 * 434627544) ^ 0x6197F086);
						continue;
						end_IL_00c8:
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
				uint num3;
				switch ((num3 = 447511571u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return ResourceManager.GetRandom<Skill>();
				}
				break;
			}
		}
		return list[Tools.GetRandomInt(0, list.Count - 1)];
	}

	private static InternalSkill GetRandomInternalSkill(int minHard, int maxHard)
	{
		List<InternalSkill> list = new List<InternalSkill>();
		IEnumerator<InternalSkill> enumerator = ResourceManager.GetAll<InternalSkill>().GetEnumerator();
		try
		{
			InternalSkill current = default(InternalSkill);
			while (true)
			{
				IL_00a2:
				int num;
				int num2;
				if (!_202E_202E_206C_206D_206E_200C_206A_200E_206A_202C_200D_202A_206B_206C_200D_200F_202B_206D_200B_206B_202D_206E_206C_202E_200E_202C_200B_200B_202D_206A_206B_202E_202A_206D_202E_206A_200D_202B_200E_206B_202E((IEnumerator)enumerator))
				{
					num = -653455119;
					num2 = num;
				}
				else
				{
					num = -437343685;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -573782979)) % 6)
					{
					case 5u:
						num = -437343685;
						continue;
					default:
						goto end_IL_001b;
					case 2u:
					{
						current = enumerator.Current;
						int num6;
						if (current.Hard < (float)minHard)
						{
							num = -1134512127;
							num6 = num;
						}
						else
						{
							num = -398788842;
							num6 = num;
						}
						continue;
					}
					case 3u:
					{
						int num4;
						int num5;
						if (current.Hard > (float)maxHard)
						{
							num4 = 394370915;
							num5 = num4;
						}
						else
						{
							num4 = 163205032;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -410702554);
						continue;
					}
					case 1u:
						list.Add(current);
						num = ((int)num3 * -261085657) ^ -1816609888;
						continue;
					case 0u:
						break;
					case 4u:
						goto end_IL_001b;
					}
					goto IL_00a2;
					continue;
					end_IL_001b:
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
					IL_00c3:
					int num7 = -381683450;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num7 ^ -573782979)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_00c8;
						case 1u:
							goto IL_00e5;
						case 2u:
							goto end_IL_00c8;
						}
						goto IL_00c3;
						IL_00e5:
						_200D_206F_200D_202E_200C_200B_200E_206C_206C_206D_206D_206F_202E_200F_206B_202B_206E_200B_202E_202A_206F_202C_206B_206D_200F_200B_202C_206E_206C_206F_206A_200D_200B_206F_200F_200E_202B_206D_206F_200E_202E((IDisposable)enumerator);
						num7 = ((int)num3 * -847935737) ^ 0x70E1FE0D;
						continue;
						end_IL_00c8:
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
				uint num3;
				switch ((num3 = 396925912u) % 3)
				{
				case 2u:
					continue;
				case 1u:
					return ResourceManager.Get<InternalSkill>(ResourceStrings.ResStrings[323]);
				}
				break;
			}
		}
		return list[Tools.GetRandomInt(0, list.Count - 1)];
	}

	public static void SetRandomZhuangBei()
	{
		randomWuqiName = new string[0];
		randomFangju = new string[0];
		randomShipin = new string[0];
		while (true)
		{
			int num = -1911906731;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -601393465)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					randomWuqiName = LuaManager.GetConfig<string[]>(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(10734229u));
					num = ((int)num2 * -1090083667) ^ -970024148;
					continue;
				case 1u:
					randomFangju = LuaManager.GetConfig<string[]>(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1854607264u));
					randomShipin = LuaManager.GetConfig<string[]>(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2526206739u));
					num = ((int)num2 * -399075188) ^ 0x51333858;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	static string _202A_206D_200E_202B_206B_202A_200C_202C_202E_200F_200F_200B_200F_206D_206E_202D_200E_202A_202E_202C_206F_206C_200D_206F_202C_202A_206C_202E_206D_200C_206D_206B_202D_200E_200B_206F_206F_206B_202A_202E_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static int _206B_206A_202C_202D_202E_206F_202C_206D_200F_206D_206D_200D_206C_202B_202E_202A_200F_206D_202E_200C_200D_206D_206B_202A_202E_202E_200B_202C_206A_200B_206E_200C_200E_206E_200E_202D_202C_200B_206C_200D_202E(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	static int _206E_202A_200E_202E_202A_206B_206C_206C_206A_202C_200E_200C_200F_206E_200B_202C_202E_202C_200D_206A_200E_200D_200E_206D_202B_200B_202C_202E_206E_206F_206F_200B_200C_206E_206B_202A_202E_206B_200F_202E(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	static double _206F_202B_202B_206E_202C_200B_202A_206F_202A_202A_206A_206A_206F_202D_206C_202B_206D_202A_202D_206B_206D_206D_202E_200D_206A_200E_206E_202C_202A_200B_200E_202D_200B_206B_200B_200C_200F_200F_202B_200C_202E(double P_0)
	{
		return Math.Abs(P_0);
	}

	static bool _206E_202D_206F_202C_200C_206E_202E_206D_200D_206D_200B_202B_206A_206C_206E_206E_206E_206F_206A_206D_206A_202C_202E_200B_202A_206D_200C_200F_202D_202E_206E_200D_202D_206E_206B_202D_206A_206D_206F_200C_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static bool _202E_202E_206C_206D_206E_200C_206A_200E_206A_202C_200D_202A_206B_206C_200D_200F_202B_206D_200B_206B_202D_206E_206C_202E_200E_202C_200B_200B_202D_206A_206B_202E_202A_206D_202E_206A_200D_202B_200E_206B_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _200D_206F_200D_202E_200C_200B_200E_206C_206C_206D_206D_206F_202E_200F_206B_202B_206E_200B_202E_202A_206F_202C_206B_206D_200F_200B_202C_206E_206C_206F_206A_200D_200B_206F_200F_200E_202B_206D_206F_200E_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}
}
