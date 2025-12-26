using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace JyGame;

public class AttackLogic
{
	public static BattleField field;

	[CompilerGenerated]
	private static Dictionary<string, int> _200E_200D_206F_202A_200B_206E_200C_202E_202A_202E_202A_206E_206B_200B_206E_202C_200B_206F_206A_200D_206E_200D_206B_202C_202C_206F_206E_206C_202C_200D_206B_200E_206A_206F_206E_202B_202A_206E_206F_202D_202E;

	[CompilerGenerated]
	private static Dictionary<string, int> _206B_200C_200C_206E_202A_202A_206B_200E_206C_200E_200B_202D_202A_206B_206E_202A_206E_200B_206E_206F_202E_206E_200F_206C_206B_200E_202D_200D_200B_206F_200E_206B_202B_206A_206F_200D_206D_202A_202A_202E;

	private static double ZHOUMU_ATTACK_ADD;

	private static double ZHOUMU_DEFENCE_ADD;

	private static bool NoZhenlongqiju;

	private static int Round;

	public static void Log(string msg)
	{
		if (!_200F_200E_206C_206D_202A_206A_206A_202B_206E_202D_202E_206F_206D_206D_206F_200E_202E_206D_206B_206D_202B_202C_206A_202A_200D_200D_206D_200C_200C_202B_206A_202D_202D_200C_206A_206C_206F_206B_200C_200C_202E((Object)(object)field, (Object)null))
		{
			return;
		}
		while (true)
		{
			int num = 1919909698;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xC00C29E)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_002f;
				case 0u:
					return;
				}
				break;
				IL_002f:
				field.Log(msg);
				num = ((int)num2 * -1109142891) ^ 0x59DCB46;
			}
		}
	}

	public static AttackResult Attack(SkillBox skill, BattleSprite source, BattleSprite target, BattleField bf)
	{
		if (target.Team != source.Team)
		{
			int num5 = default(int);
			int num6 = default(int);
			int num19 = default(int);
			int num25 = default(int);
			int num12 = default(int);
			int num13 = default(int);
			int num9 = default(int);
			int num20 = default(int);
			int mAX_X = default(int);
			BattleAI aI = default(BattleAI);
			int num14 = default(int);
			while (true)
			{
				int num = -906835317;
				while (true)
				{
					uint num2;
					int num27;
					int num26;
					switch ((num2 = (uint)(num ^ -919030575)) % 36)
					{
					case 16u:
						break;
					case 32u:
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[760], (object)target.Role.Name, (object)source.Role.Name));
						num = ((int)num2 * -303423333) ^ 0x7CF239E0;
						continue;
					case 21u:
						num5 = num6;
						num = (int)((num2 * 92778232) ^ 0x7515CDB0);
						continue;
					case 27u:
						target.SetPosWithAnimation(num19, num5, 0.05f, 3, skill.Animation);
						num = -1603742386;
						continue;
					case 1u:
						target.SetPosWithAnimation(num19, num5, 0.05f, 3);
						num = -567293712;
						continue;
					case 19u:
						num27 = 0;
						goto IL_0153;
					case 6u:
						num25 = 0;
						num = ((int)num2 * -857371603) ^ -1386671392;
						continue;
					case 28u:
					{
						int num7;
						int num8;
						if (source.HasBuff(ResourceStrings.ResStrings[540]))
						{
							num7 = 2028466942;
							num8 = num7;
						}
						else
						{
							num7 = 758041721;
							num8 = num7;
						}
						num = num7 ^ ((int)num2 * -1394844163);
						continue;
					}
					case 31u:
						num12++;
						num19 = num13;
						num = (int)((num2 * 65109894) ^ 0x7CDF0DA);
						continue;
					case 30u:
						num9 = (source.Y - target.Y) / _202D_202D_206F_202B_202C_206D_206E_206D_200C_202A_206E_202D_202B_202C_206E_202D_202B_202D_202A_206F_206E_206A_200B_200F_202A_200B_206D_206C_202A_202B_202A_202A_206E_200D_206A_200C_206B_202B_206E_202A_202E(source.Y - target.Y);
						num = -933952687;
						continue;
					case 10u:
					{
						int num23;
						int num24;
						if (skill.HitSelf)
						{
							num23 = -1325876878;
							num24 = num23;
						}
						else
						{
							num23 = -659481105;
							num24 = num23;
						}
						num = num23 ^ ((int)num2 * -1537180571);
						continue;
					}
					case 0u:
						goto IL_0214;
					case 24u:
					{
						int num17;
						int num18;
						if (!Tools.ProbabilityTest(0.3))
						{
							num17 = 1382316148;
							num18 = num17;
						}
						else
						{
							num17 = 1530202101;
							num18 = num17;
						}
						num = num17 ^ ((int)num2 * -422061297);
						continue;
					}
					case 18u:
						goto IL_0269;
					case 23u:
						goto IL_0286;
					case 22u:
						num6 = target.Y + num20;
						num = ((int)num2 * -1152213268) ^ 0x5C6AB0A6;
						continue;
					case 11u:
						target.Say_fs(ResourceStrings.ResStrings[757], skill.AttackTime);
						num = ((int)num2 * -1178197640) ^ 0x1C8581CC;
						continue;
					case 25u:
						num = ((int)num2 * -207368576) ^ -1106780207;
						continue;
					case 2u:
						source.RefreshBuffsInvoke();
						Log(_200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[758], (object)source.Role.Name));
						num = (int)((num2 * 1873506506) ^ 0x4CB1E9A1);
						continue;
					case 26u:
						mAX_X = BattleField.MAX_X;
						aI = bf.AI;
						num = ((int)num2 * -272626826) ^ 0x36A6EFE4;
						continue;
					case 20u:
						num26 = 0;
						goto IL_036f;
					case 12u:
					{
						int num28;
						int num29;
						if (num5 == target.Y)
						{
							num28 = -2116434824;
							num29 = num28;
						}
						else
						{
							num28 = -1900763410;
							num29 = num28;
						}
						num = num28 ^ (int)(num2 * 791943044);
						continue;
					}
					case 3u:
						num25 = (source.X - target.X) / _202D_202D_206F_202B_202C_206D_206E_206D_200C_202A_206E_202D_202B_202C_206E_202D_202B_202D_202A_206F_206E_206A_200B_200F_202A_200B_206D_206C_202A_202B_202A_202A_206E_200D_206A_200C_206B_202B_206E_202A_202E(source.X - target.X);
						num = -995945682;
						continue;
					case 17u:
						if (num25 != 0)
						{
							num26 = -num25 * num12;
							goto IL_036f;
						}
						num = -1064043571;
						continue;
					case 4u:
						num19 = target.X;
						num5 = target.Y;
						num = -1589873721;
						continue;
					case 5u:
						source.DeleteBuff(ResourceStrings.ResStrings[540]);
						num = ((int)num2 * -1862433728) ^ 0x57E7BFD3;
						continue;
					case 7u:
					{
						int num21;
						int num22;
						if (aI.IsEmptyBlock(num13, num6))
						{
							num21 = -1001673370;
							num22 = num21;
						}
						else
						{
							num21 = -601739570;
							num22 = num21;
						}
						num = num21 ^ ((int)num2 * -296017701);
						continue;
					}
					case 8u:
						source.Say_fs(ResourceStrings.ResStrings[759], skill.AttackTime);
						num = ((int)num2 * -1716701423) ^ -529083495;
						continue;
					case 34u:
					{
						int num15;
						int num16;
						if (num12 <= mAX_X)
						{
							num15 = -297206270;
							num16 = num15;
						}
						else
						{
							num15 = -2036791813;
							num16 = num15;
						}
						num = num15 ^ ((int)num2 * -853210176);
						continue;
					}
					case 35u:
						num13 = target.X + num14;
						num = ((int)num2 * -1199848499) ^ -714095120;
						continue;
					case 14u:
						num12 = 1;
						num = ((int)num2 * -188009405) ^ -2007134767;
						continue;
					case 33u:
					{
						int num10;
						int num11;
						if (skill.IsSpecial)
						{
							num10 = 1907866627;
							num11 = num10;
						}
						else
						{
							num10 = 1010489118;
							num11 = num10;
						}
						num = num10 ^ (int)(num2 * 2073062515);
						continue;
					}
					case 15u:
						num = ((int)num2 * -969394812) ^ -1738569716;
						continue;
					case 13u:
						num9 = 0;
						num = (int)((num2 * 884357292) ^ 0x618EF880);
						continue;
					case 9u:
					{
						int num3;
						int num4;
						if (source.X - target.X == 0)
						{
							num3 = -624224260;
							num4 = num3;
						}
						else
						{
							num3 = -894939015;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 823890579);
						continue;
					}
					default:
						goto end_IL_0011;
						IL_0153:
						num20 = num27;
						num = -509044354;
						continue;
						IL_036f:
						num14 = num26;
						if (num9 != 0)
						{
							num27 = -num9 * num12;
							goto IL_0153;
						}
						num = -1329074874;
						continue;
					}
					break;
					IL_0286:
					int num30;
					if (source.Y - target.Y != 0)
					{
						num = -1391593481;
						num30 = num;
					}
					else
					{
						num = -1434970780;
						num30 = num;
					}
					continue;
					IL_0269:
					int num31;
					if (num19 != target.X)
					{
						num = -275276706;
						num31 = num;
					}
					else
					{
						num = -1948911363;
						num31 = num;
					}
					continue;
					IL_0214:
					int num32;
					if (!source.Role.BuiltInTalents[86])
					{
						num = -567293712;
						num32 = num;
					}
					else
					{
						num = -225279664;
						num32 = num;
					}
				}
				continue;
				end_IL_0011:
				break;
			}
		}
		return GetAttackResult(skill, source, target, bf);
	}

	public static AttackResult GetAttackResult(SkillBox skill, BattleSprite sourceSprite, BattleSprite targetSprite, BattleField bf)
	{
		//IL_6d47: Unknown result type (might be due to invalid IL or missing references)
		//IL_77e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_6811: Unknown result type (might be due to invalid IL or missing references)
		//IL_8a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_921c: Unknown result type (might be due to invalid IL or missing references)
		//IL_9411: Unknown result type (might be due to invalid IL or missing references)
		//IL_925e: Unknown result type (might be due to invalid IL or missing references)
		//IL_9514: Unknown result type (might be due to invalid IL or missing references)
		//IL_9079: Unknown result type (might be due to invalid IL or missing references)
		//IL_90b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_9631: Unknown result type (might be due to invalid IL or missing references)
		//IL_92d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_9680: Unknown result type (might be due to invalid IL or missing references)
		//IL_8d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_9a81: Unknown result type (might be due to invalid IL or missing references)
		//IL_a09a: Unknown result type (might be due to invalid IL or missing references)
		//IL_9d97: Unknown result type (might be due to invalid IL or missing references)
		//IL_a699: Unknown result type (might be due to invalid IL or missing references)
		//IL_a750: Unknown result type (might be due to invalid IL or missing references)
		//IL_a494: Unknown result type (might be due to invalid IL or missing references)
		Role role = sourceSprite.Role;
		int num51 = default(int);
		Role role2 = default(Role);
		double num6 = default(double);
		double num337 = default(double);
		double num312 = default(double);
		BattleSprite zhujueSprite = default(BattleSprite);
		int num43 = default(int);
		int num42 = default(int);
		bool flag = default(bool);
		double num32 = default(double);
		double num5 = default(double);
		AttackResult attackResult = default(AttackResult);
		int type = default(int);
		double num59 = default(double);
		bool flag2 = default(bool);
		float num40 = default(float);
		double num28 = default(double);
		InternalSkillInstance equippedInternalSkill = default(InternalSkillInstance);
		float num46 = default(float);
		double num58 = default(double);
		double num48 = default(double);
		int num54 = default(int);
		float num313 = default(float);
		AttackFormula attackFormula = default(AttackFormula);
		string name3 = default(string);
		string name2 = default(string);
		string name = default(string);
		BattleSprite current = default(BattleSprite);
		BattleSprite zhujueSprite2 = default(BattleSprite);
		bool flag3 = default(bool);
		BattleSprite current2 = default(BattleSprite);
		Buff buff12 = default(Buff);
		Buff buff11 = default(Buff);
		Buff buff6 = default(Buff);
		double num152 = default(double);
		Buff buff4 = default(Buff);
		Buff buff = default(Buff);
		Buff buff7 = default(Buff);
		double num110 = default(double);
		Buff buff5 = default(Buff);
		Buff buff8 = default(Buff);
		double num111 = default(double);
		Buff buff9 = default(Buff);
		BuffInstance buff10 = default(BuffInstance);
		Buff buff3 = default(Buff);
		int num114 = default(int);
		float num113 = default(float);
		int balls = default(int);
		double num112 = default(double);
		Buff buff2 = default(Buff);
		double num149 = default(double);
		bool flag4 = default(bool);
		BattleSprite current3 = default(BattleSprite);
		double num264 = default(double);
		double num248 = default(double);
		double num249 = default(double);
		double num269 = default(double);
		List<Buff> list = default(List<Buff>);
		Buff current4 = default(Buff);
		Buff current5 = default(Buff);
		double p = default(double);
		Buff current6 = default(Buff);
		double num328 = default(double);
		Buff current7 = default(Buff);
		List<Buff> list2 = default(List<Buff>);
		double p3 = default(double);
		double p2 = default(double);
		Buff current9 = default(Buff);
		BuffInstance buff13 = default(BuffInstance);
		BuffInstance buff22 = default(BuffInstance);
		double num376 = default(double);
		double num387 = default(double);
		double num361 = default(double);
		BuffInstance buff16 = default(BuffInstance);
		double num386 = default(double);
		double num374 = default(double);
		BuffInstance buff23 = default(BuffInstance);
		int internalSkillLevel2 = default(int);
		double x = default(double);
		BuffInstance buff20 = default(BuffInstance);
		BuffInstance buff17 = default(BuffInstance);
		double num369 = default(double);
		BuffInstance buff21 = default(BuffInstance);
		BuffInstance buff19 = default(BuffInstance);
		double num35 = default(double);
		double num375 = default(double);
		double num364 = default(double);
		double num360 = default(double);
		bool flag7 = default(bool);
		bool flag6 = default(bool);
		bool flag5 = default(bool);
		double num410 = default(double);
		BuffInstance buff18 = default(BuffInstance);
		int internalSkillLevel = default(int);
		double num383 = default(double);
		BuffInstance buff15 = default(BuffInstance);
		BuffInstance buff14 = default(BuffInstance);
		Buff buff26 = default(Buff);
		int num505 = default(int);
		Buff buff24 = default(Buff);
		BuffInstance buff25 = default(BuffInstance);
		BattleSprite current10 = default(BattleSprite);
		bool flag8 = default(bool);
		int num607 = default(int);
		double num614 = default(double);
		string[] array = default(string[]);
		int num612 = default(int);
		BuffInstance buff29 = default(BuffInstance);
		double num609 = default(double);
		int num539 = default(int);
		double num540 = default(double);
		BattleSprite current12 = default(BattleSprite);
		List<BuffInstance> list3 = default(List<BuffInstance>);
		BuffInstance current13 = default(BuffInstance);
		BattleSprite current14 = default(BattleSprite);
		List<BuffInstance> list4 = default(List<BuffInstance>);
		BuffInstance current15 = default(BuffInstance);
		BattleSprite current16 = default(BattleSprite);
		BuffInstance buff30 = default(BuffInstance);
		BattleSprite current17 = default(BattleSprite);
		List<BuffInstance> list5 = default(List<BuffInstance>);
		BuffInstance current18 = default(BuffInstance);
		int num590 = default(int);
		int num582 = default(int);
		int num598 = default(int);
		int x2 = default(int);
		int y = default(int);
		int num589 = default(int);
		int num594 = default(int);
		int num593 = default(int);
		Buff buff34 = default(Buff);
		BattleAI aI = default(BattleAI);
		int num581 = default(int);
		int num579 = default(int);
		int num595 = default(int);
		int num586 = default(int);
		Buff buff27 = default(Buff);
		BattleSprite current11 = default(BattleSprite);
		BuffInstance buff28 = default(BuffInstance);
		while (true)
		{
			int num = 1459132884;
			while (true)
			{
				float num315;
				double num41;
				double num47;
				double num314;
				int num100;
				int num101;
				int num338;
				IEnumerator<Buff> enumerator2;
				int num488;
				int num489;
				uint num2;
				int num623;
				switch ((num2 = (uint)(num ^ 0x69C4C43D)) % 106)
				{
				case 37u:
					break;
				case 56u:
					num51 = role.AttributesFinal[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1790491204u)];
					num = 1318826083;
					continue;
				case 25u:
				{
					int num484;
					if (role2.BuiltInTalents[55])
					{
						num = 2024952922;
						num484 = num;
					}
					else
					{
						num = 456443691;
						num484 = num;
					}
					continue;
				}
				case 73u:
					num6 *= num337;
					num35 *= num312;
					num = ((int)num2 * -1533857765) ^ 0x56FC4453;
					continue;
				case 62u:
				{
					int num45;
					if (!role.BuiltInTalents[204])
					{
						num = 1984652442;
						num45 = num;
					}
					else
					{
						num = 1207519680;
						num45 = num;
					}
					continue;
				}
				case 27u:
				{
					int num64;
					int num65;
					if (zhujueSprite.Role.BuiltInTalents[30])
					{
						num64 = -149252953;
						num65 = num64;
					}
					else
					{
						num64 = -1265033840;
						num65 = num64;
					}
					num = num64 ^ (int)(num2 * 1198025816);
					continue;
				}
				case 86u:
					goto IL_0287;
				case 17u:
				{
					int num339;
					int num340;
					if (role2.Difficulty != 1.0)
					{
						num339 = -1447152493;
						num340 = num339;
					}
					else
					{
						num339 = -1506071504;
						num340 = num339;
					}
					num = num339 ^ ((int)num2 * -2105269796);
					continue;
				}
				case 39u:
				{
					int num63;
					if (!role.BuiltInTalents[55])
					{
						num = 1413457766;
						num63 = num;
					}
					else
					{
						num = 912337912;
						num63 = num;
					}
					continue;
				}
				case 68u:
					num337 = 1.0 + ZHOUMU_ATTACK_ADD * (double)(Round - 1);
					num = ((int)num2 * -212891730) ^ 0x297936F4;
					continue;
				case 32u:
					goto IL_0326;
				case 36u:
				{
					int num627;
					int num628;
					if (role.BuiltInTalents[135])
					{
						num627 = -391208221;
						num628 = num627;
					}
					else
					{
						num627 = -1754655829;
						num628 = num627;
					}
					num = num627 ^ ((int)num2 * -222622546);
					continue;
				}
				case 60u:
				{
					int num333;
					int num334;
					if (num43 >= num42)
					{
						num333 = -1301879929;
						num334 = num333;
					}
					else
					{
						num333 = -1788970327;
						num334 = num333;
					}
					num = num333 ^ ((int)num2 * -2052951264);
					continue;
				}
				case 55u:
				{
					flag = false;
					int num52;
					int num53;
					if ((Object)(object)zhujueSprite != (Object)null)
					{
						num52 = -2119776546;
						num53 = num52;
					}
					else
					{
						num52 = -338993226;
						num53 = num52;
					}
					num = num52 ^ (int)(num2 * 651353130);
					continue;
				}
				case 53u:
				{
					num32 = 0.2;
					int num33;
					int num34;
					if (role2.BuiltInTalents[56])
					{
						num33 = 586729066;
						num34 = num33;
					}
					else
					{
						num33 = 414273152;
						num34 = num33;
					}
					num = num33 ^ ((int)num2 * -1595883910);
					continue;
				}
				case 54u:
					goto IL_03fa;
				case 59u:
					num5 *= num337;
					num = (int)((num2 * 1080971155) ^ 0x41BF4F71);
					continue;
				case 6u:
					num315 = 0f;
					goto IL_0447;
				case 15u:
				{
					int num490;
					if (NoZhenlongqiju)
					{
						num = 1835822407;
						num490 = num;
					}
					else
					{
						num = 804110516;
						num490 = num;
					}
					continue;
				}
				case 8u:
					attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[850].Split('#'), 0.12f, skill.AttackTime);
					num = (int)((num2 * 839227666) ^ 0x216B25C7);
					continue;
				case 99u:
				{
					int num485;
					if (type == 1)
					{
						num = 2025379333;
						num485 = num;
					}
					else
					{
						num = 1702695355;
						num485 = num;
					}
					continue;
				}
				case 85u:
					num59 = 0.2;
					num = (int)(num2 * 1582028246) ^ -1756818563;
					continue;
				case 18u:
				{
					int num104;
					int num105;
					if (role.Difficulty <= 0.0)
					{
						num104 = 1245010158;
						num105 = num104;
					}
					else
					{
						num104 = 851428498;
						num105 = num104;
					}
					num = num104 ^ (int)(num2 * 399794717);
					continue;
				}
				case 87u:
					num312 = 1.0 + ZHOUMU_DEFENCE_ADD * (double)(Round - 1);
					num = ((int)num2 * -1055436655) ^ -1046494871;
					continue;
				case 95u:
				{
					int num99;
					if (!flag2)
					{
						num = 745103854;
						num99 = num;
					}
					else
					{
						num = 7798019;
						num99 = num;
					}
					continue;
				}
				case 77u:
				{
					int num56;
					int num57;
					if ((Object)(object)zhujueSprite != (Object)(object)sourceSprite)
					{
						num56 = 1118142230;
						num57 = num56;
					}
					else
					{
						num56 = 1094186611;
						num57 = num56;
					}
					num = num56 ^ (int)(num2 * 1001470519);
					continue;
				}
				case 44u:
					num = ((int)num2 * -127962310) ^ 0x46EAB89A;
					continue;
				case 84u:
					num40 = 1f;
					num = ((int)num2 * -189898576) ^ -1594279050;
					continue;
				case 7u:
				{
					int num31;
					if (role.BuiltInTalents[205])
					{
						num = 702876620;
						num31 = num;
					}
					else
					{
						num = 2025617113;
						num31 = num;
					}
					continue;
				}
				case 96u:
					num35 *= role2.Difficulty;
					num = (int)((num2 * 1487971816) ^ 0x50ED58A4);
					continue;
				case 78u:
					num6 = (double)skill.PowerBattle * 8.0 * (1.5 + (double)role.AttributesFinal[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(710450445u)] / 400.0) * (2.0 + (double)num51 / 800.0) * (1.0 + num28) * (1.0 + (double)(equippedInternalSkill.AttackBattle + num46));
					num = ((int)num2 * -820235865) ^ -1231757;
					continue;
				case 30u:
				{
					int num631;
					int num632;
					if (sourceSprite.Team != 2)
					{
						num631 = 917065416;
						num632 = num631;
					}
					else
					{
						num631 = 919705667;
						num632 = num631;
					}
					num = num631 ^ (int)(num2 * 2066058104);
					continue;
				}
				case 64u:
					flag2 = true;
					num = ((int)num2 * -1160937716) ^ 0x3D91AC80;
					continue;
				case 14u:
				{
					int num624;
					int num625;
					if (!role.BuiltInTalents[56])
					{
						num624 = -1795473058;
						num625 = num624;
					}
					else
					{
						num624 = -198469280;
						num625 = num624;
					}
					num = num624 ^ (int)(num2 * 556321231);
					continue;
				}
				case 0u:
					num = ((int)num2 * -1727202815) ^ -480818307;
					continue;
				case 88u:
					if (role.BuiltInTalents[30])
					{
						num = 1820712432;
						continue;
					}
					goto IL_17ce;
				case 10u:
					num58 = role.CriticalpValue * (1.0 + num28 / (num28 * 1.5 + 5.0)) + role.EquipmentCriticalpValue;
					num = 1428866055;
					continue;
				case 75u:
				{
					int num49;
					int num50;
					if (role.Difficulty != 1.0)
					{
						num49 = 547855222;
						num50 = num49;
					}
					else
					{
						num49 = 252630393;
						num50 = num49;
					}
					num = num49 ^ ((int)num2 * -17495447);
					continue;
				}
				case 49u:
					num = (int)((num2 * 1399517613) ^ 0x2342B11B);
					continue;
				case 29u:
					num48 = role.criticalValue;
					flag2 = false;
					num = (int)(num2 * 1884341474) ^ -1256299559;
					continue;
				case 63u:
					zhujueSprite = bf.GetZhujueSprite();
					num = ((int)num2 * -655647234) ^ -2042135592;
					continue;
				case 52u:
				{
					int num38;
					int num39;
					if (role.BuiltInTalents[136])
					{
						num38 = 1487987081;
						num39 = num38;
					}
					else
					{
						num38 = 1528936702;
						num39 = num38;
					}
					num = num38 ^ ((int)num2 * -1144644357);
					continue;
				}
				case 89u:
					if (skill.Tiaohe)
					{
						num = ((int)num2 * -2145059110) ^ -1180720559;
						continue;
					}
					num41 = ((!(skill.Suit <= 0f)) ? ((double)(skill.Suit * (float)equippedInternalSkill.YangBattle / 100f)) : ((0f + skill.Suit >= 0f) ? 0.0 : ((0.0 - (double)skill.Suit) * (double)(float)equippedInternalSkill.YinBattle / 100.0)));
					goto IL_09ef;
				case 72u:
					num5 = 0.0;
					num = ((int)num2 * -10958536) ^ 0x1D3A6F63;
					continue;
				case 24u:
				{
					int num629;
					int num630;
					if (zhujueSprite.Team == sourceSprite.Team)
					{
						num629 = -481597876;
						num630 = num629;
					}
					else
					{
						num629 = -1289486248;
						num630 = num629;
					}
					num = num629 ^ (int)(num2 * 138440497);
					continue;
				}
				case 83u:
				{
					int num626;
					if (num54 != 1)
					{
						num = 86110017;
						num626 = num;
					}
					else
					{
						num = 1285048330;
						num626 = num;
					}
					continue;
				}
				case 94u:
					num28 = -0.9999;
					num = ((int)num2 * -1952123360) ^ -1475497708;
					continue;
				case 66u:
					num47 = Math.Max((float)equippedInternalSkill.YinBattle * num40, (float)equippedInternalSkill.YangBattle * num313) / 100f;
					goto IL_092a;
				case 69u:
					if (!skill.IsSpecial)
					{
						num = (int)(num2 * 383340516) ^ -1149854273;
						continue;
					}
					goto IL_75ed;
				case 98u:
					num41 = Math.Max((float)equippedInternalSkill.YinBattle * num40, (float)equippedInternalSkill.YangBattle * num313) / 100f;
					goto IL_09ef;
				case 57u:
					switch (type)
					{
					case 4:
						break;
					case 3:
						goto IL_0287;
					case 0:
						goto IL_0326;
					case 2:
						goto IL_03fa;
					default:
						goto IL_0a1b;
					case 1:
						goto IL_1098;
					case 5:
						goto IL_1281;
					}
					goto case 56u;
				case 34u:
					if (skill.Tiaohe)
					{
						num = 653278505;
						continue;
					}
					num314 = ((!(skill.Suit <= 0f)) ? ((double)(skill.Suit * (float)num42 / 100f)) : ((0f + skill.Suit >= 0f) ? 0.0 : ((0.0 - (double)skill.Suit) * (double)(float)num43 / 100.0)));
					goto IL_0f9c;
				case 9u:
					equippedInternalSkill = role.EquippedInternalSkill;
					num = 1833284366;
					continue;
				case 46u:
					num6 = 0.0;
					num = ((int)num2 * -710443921) ^ 0x7DA0FE40;
					continue;
				case 28u:
				{
					int num486;
					int num487;
					if (skill.TiaoheScale >= 1.001f)
					{
						num486 = -1527171039;
						num487 = num486;
					}
					else
					{
						num486 = -40313736;
						num487 = num486;
					}
					num = num486 ^ ((int)num2 * -1611632833);
					continue;
				}
				case 13u:
					num28 = -0.9999;
					num = (int)(num2 * 749965628) ^ -1180244688;
					continue;
				case 23u:
					num59 = 0.5;
					num = (int)(num2 * 878813587) ^ -1439400495;
					continue;
				case 105u:
					Debug.LogError((object)(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1500516149u) + skill.Name + global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4103400612u) + type));
					num = 1169239482;
					continue;
				case 103u:
					num43 = equippedInternalSkill.YinBattle;
					num42 = equippedInternalSkill.YangBattle;
					num = ((int)num2 * -1813239284) ^ -806674132;
					continue;
				case 2u:
				{
					int num483;
					if (type == 0)
					{
						num = 474782933;
						num483 = num;
					}
					else
					{
						num = 989410182;
						num483 = num;
					}
					continue;
				}
				case 91u:
				{
					num313 = 1f;
					int num341;
					int num342;
					if (skill.Tiaohe)
					{
						num341 = -898193766;
						num342 = num341;
					}
					else
					{
						num341 = -325802845;
						num342 = num341;
					}
					num = num341 ^ ((int)num2 * -561952745);
					continue;
				}
				case 20u:
					num = ((int)num2 * -1920605367) ^ 0x26ED2596;
					continue;
				case 58u:
					attackResult.AddCastInfo2(targetSprite, ResourceStrings.ResStrings[853].Split('#'), 0.2f, skill.AttackTime);
					num35 *= 1.5;
					num = (int)((num2 * 1916394356) ^ 0x62211CD3);
					continue;
				case 41u:
					num5 *= (double)(1f + (equippedInternalSkill.AttackBattle + num46) * 0.2f);
					num = 1501071593;
					continue;
				case 22u:
					num58 = role.CriticalpValue + role.EquipmentCriticalpValue;
					num = ((int)num2 * -773141689) ^ 0x320F877D;
					continue;
				case 67u:
					num5 = (double)skill.PowerBattle * (2.0 + (double)num51 / 200.0) * 2.5 * Math.Pow((double)role.AttributesFinal[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(655417903u)] + 50.0, 0.3) * (1.0 + num28);
					num = 1305107062;
					continue;
				case 76u:
					attackResult = new AttackResult();
					num = ((int)num2 * -1339648925) ^ 0x77058CC7;
					continue;
				case 93u:
					role2 = targetSprite.Role;
					num = ((int)num2 * -266095792) ^ 0x3625E7D9;
					continue;
				case 4u:
					flag = true;
					num = (int)(num2 * 121744047) ^ -1137558698;
					continue;
				case 33u:
					num5 = (double)skill.PowerBattle * 8.0 * (1.5 + (double)role.AttributesFinal[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(655417903u)] / 400.0) * (2.0 + (double)num51 / 800.0) * (1.0 + num28) * (1.0 + (double)(equippedInternalSkill.AttackBattle + num46) * 0.5);
					num = 1933608629;
					continue;
				case 48u:
					attackFormula = new AttackFormula();
					num = ((int)num2 * -1556792536) ^ -1310849804;
					continue;
				case 19u:
					num6 = (double)skill.PowerBattle * 8.0 * (1.2 + (double)role.AttributesFinal[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1564888282u)] / 500.0) * (1.0 + (double)num51 / 350.0) * (1.0 + num28) * (1.0 + (double)(equippedInternalSkill.AttackBattle + num46));
					num58 = role.CriticalpValue * (1.0 + num28 / (num28 * 1.5 + 5.0)) + role.EquipmentCriticalpValue;
					num = (int)(num2 * 1348747046) ^ -1283067051;
					continue;
				case 90u:
				{
					int num335;
					int num336;
					if (num28 >= -0.9999)
					{
						num335 = 627976580;
						num336 = num335;
					}
					else
					{
						num335 = 57354433;
						num336 = num335;
					}
					num = num335 ^ ((int)num2 * -1110773194);
					continue;
				}
				case 16u:
					attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[852].Split('#'), 0.2f, skill.AttackTime);
					num5 *= 1.5;
					num6 *= 1.5;
					num58 *= 1.5;
					num = (int)(num2 * 41526306) ^ -1686159906;
					continue;
				case 3u:
					num58 = 0.0;
					num = ((int)num2 * -537643117) ^ -1468921492;
					continue;
				case 47u:
					name3 = equippedInternalSkill.Name;
					name2 = role2.EquippedInternalSkill.Name;
					if (role.EquippedTitle != null)
					{
						num315 = role.EquippedTitle.Attack;
						goto IL_0447;
					}
					num = ((int)num2 * -1123434119) ^ -255771798;
					continue;
				case 50u:
					num314 = Math.Max((float)num43 * num40, (float)num42 * num313) / 100f;
					goto IL_0f9c;
				case 102u:
					num40 = (float)(int)((skill.TiaoheScale + 1E-05f) % 1f * 1000f) / 100f;
					num313 = (float)Math.Min(999, (int)skill.TiaoheScale) / 100f;
					num = (int)(num2 * 780853145) ^ -428670732;
					continue;
				case 45u:
					num5 = (double)skill.PowerBattle * 8.0 * (1.2 + (double)role.AttributesFinal[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1564888282u)] / 500.0) * (1.0 + (double)num51 / 350.0) * (1.0 + num28) * (1.0 + (double)(equippedInternalSkill.AttackBattle + num46) * 0.5);
					num = 1129595246;
					continue;
				case 101u:
					num = ((int)num2 * -191004373) ^ -989486706;
					continue;
				case 104u:
					goto IL_1098;
				case 51u:
					num54 = CommonSettings.MOD_KEY();
					name = skill.Name;
					num = ((int)num2 * -1594392735) ^ -655268667;
					continue;
				case 5u:
				{
					int num102;
					int num103;
					if (role.BuiltInTalents[203])
					{
						num102 = 265095397;
						num103 = num102;
					}
					else
					{
						num102 = 33062469;
						num103 = num102;
					}
					num = num102 ^ ((int)num2 * -848654522);
					continue;
				}
				case 100u:
					num = ((int)num2 * -1109607773) ^ 0x7F988EB5;
					continue;
				case 26u:
					num42 = num43;
					num = 739228825;
					continue;
				case 82u:
					num35 = role2.DefanceValue;
					num = 1306993790;
					continue;
				case 97u:
				{
					int num98;
					if (role2.Difficulty > 0.0)
					{
						num = 425693978;
						num98 = num;
					}
					else
					{
						num = 804110516;
						num98 = num;
					}
					continue;
				}
				case 43u:
				{
					num6 = num5 * (double)(1f + (equippedInternalSkill.AttackBattle + num46));
					int num61;
					int num62;
					if (skill.SkillType == SkillType.Normal)
					{
						num61 = 1171741808;
						num62 = num61;
					}
					else
					{
						num61 = 1077517584;
						num62 = num61;
					}
					num = num61 ^ (int)(num2 * 171142878);
					continue;
				}
				case 92u:
					num43 = num42;
					num = (int)((num2 * 1591846017) ^ 0x586BA08D);
					continue;
				case 1u:
				{
					int num60;
					if ((double)((float)role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1768687720u)] / (float)role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(31734228u)]) > num59)
					{
						num = 1413457766;
						num60 = num;
					}
					else
					{
						num = 1420058529;
						num60 = num;
					}
					continue;
				}
				case 71u:
					num43 = Math.Max(num43, (int)((double)num42 * 1.03));
					num = ((int)num2 * -815009726) ^ -200884765;
					continue;
				case 42u:
					attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[851].Split('#'), 0.12f, skill.AttackTime);
					num = ((int)num2 * -1976080216) ^ -1529829786;
					continue;
				case 80u:
				{
					int num55;
					if (num54 != 2)
					{
						num = 1732972231;
						num55 = num;
					}
					else
					{
						num = 1293690030;
						num55 = num;
					}
					continue;
				}
				case 21u:
					goto IL_1281;
				case 40u:
					num5 *= role.Difficulty;
					num6 *= role.Difficulty;
					num = (int)((num2 * 59826839) ^ 0x6596AE7E);
					continue;
				case 31u:
					return null;
				case 38u:
					type = skill.Type;
					num = ((int)num2 * -1534538887) ^ -308948914;
					continue;
				case 74u:
					if (skill.Tiaohe)
					{
						num = 1814468907;
						continue;
					}
					num47 = ((!(skill.Suit <= 0f)) ? ((double)(skill.Suit * (float)equippedInternalSkill.YangBattle / 100f)) : ((0f + skill.Suit >= 0f) ? 0.0 : ((0.0 - (double)skill.Suit) * (double)(float)equippedInternalSkill.YinBattle / 100.0)));
					goto IL_092a;
				case 61u:
					num5 *= (double)(1f + (equippedInternalSkill.AttackBattle + num46) * 0.1f);
					num = ((int)num2 * -936034771) ^ -1843093517;
					continue;
				case 65u:
				{
					int num44;
					if ((double)((float)role2.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2873590287u)] / (float)role2.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1796919217u)]) <= num32)
					{
						num = 424969259;
						num44 = num;
					}
					else
					{
						num = 456443691;
						num44 = num;
					}
					continue;
				}
				case 70u:
					num28 = -0.9999;
					num = ((int)num2 * -141920655) ^ 0x7E71CF34;
					continue;
				case 81u:
					num42 = Math.Max(num42, (int)((double)num43 * 1.03));
					num = (int)((num2 * 1855635873) ^ 0xBE0148);
					continue;
				case 12u:
				{
					int num36;
					int num37;
					if (NoZhenlongqiju)
					{
						num36 = 345896735;
						num37 = num36;
					}
					else
					{
						num36 = 2140106870;
						num37 = num36;
					}
					num = num36 ^ ((int)num2 * -2055677009);
					continue;
				}
				case 11u:
					num32 = 0.5;
					num = (int)((num2 * 2142027098) ^ 0x1BD5E04C);
					continue;
				case 35u:
				{
					int num29;
					int num30;
					if (num28 < -0.9999)
					{
						num29 = -201472228;
						num30 = num29;
					}
					else
					{
						num29 = -2017962635;
						num30 = num29;
					}
					num = num29 ^ ((int)num2 * -377960637);
					continue;
				}
				default:
					{
						IEnumerator<BattleSprite> enumerator = bf.Sprites.GetEnumerator();
						try
						{
							while (true)
							{
								IL_14ed:
								int num3;
								int num4;
								if (!enumerator.MoveNext())
								{
									num3 = 124470036;
									num4 = num3;
								}
								else
								{
									num3 = 23800636;
									num4 = num3;
								}
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ 0x69C4C43D)) % 20)
									{
									case 3u:
										num3 = 23800636;
										continue;
									default:
										goto end_IL_1450;
									case 18u:
									{
										int num25;
										int num26;
										if (current.Role.Female == zhujueSprite.Role.Female)
										{
											num25 = 1051682575;
											num26 = num25;
										}
										else
										{
											num25 = 1499973567;
											num26 = num25;
										}
										num3 = num25 ^ ((int)num2 * -580797775);
										continue;
									}
									case 14u:
										break;
									case 9u:
										current = enumerator.Current;
										num3 = 946818163;
										continue;
									case 5u:
									{
										int num13;
										int num14;
										if (flag)
										{
											num13 = 1928302515;
											num14 = num13;
										}
										else
										{
											num13 = 2034107473;
											num14 = num13;
										}
										num3 = num13 ^ (int)(num2 * 381939644);
										continue;
									}
									case 7u:
									{
										int num19;
										int num20;
										if (Tools.ProbabilityTest(0.45))
										{
											num19 = 1794603499;
											num20 = num19;
										}
										else
										{
											num19 = 619986171;
											num20 = num19;
										}
										num3 = num19 ^ ((int)num2 * -1707095142);
										continue;
									}
									case 17u:
										num3 = ((int)num2 * -585061830) ^ -1182254281;
										continue;
									case 16u:
										attackResult.AddCastInfo2(current, ResourceStrings.ResStrings[191], 1f, skill.AttackTime);
										num3 = 652668133;
										continue;
									case 11u:
										goto end_IL_1450;
									case 13u:
									{
										int num23;
										int num24;
										if (!((Object)(object)current != (Object)(object)sourceSprite))
										{
											num23 = 894740145;
											num24 = num23;
										}
										else
										{
											num23 = 145066845;
											num24 = num23;
										}
										num3 = num23 ^ (int)(num2 * 281276622);
										continue;
									}
									case 15u:
										attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[191], 1f, skill.AttackTime);
										num3 = 377697108;
										continue;
									case 19u:
									{
										int num15;
										int num16;
										if (role.Female == zhujueSprite.Role.Female)
										{
											num15 = -1883582816;
											num16 = num15;
										}
										else
										{
											num15 = -167621137;
											num16 = num15;
										}
										num3 = num15 ^ ((int)num2 * -1638085829);
										continue;
									}
									case 12u:
									{
										int num9;
										int num10;
										if (flag)
										{
											num9 = -1848291854;
											num10 = num9;
										}
										else
										{
											num9 = -179071659;
											num10 = num9;
										}
										num3 = num9 ^ (int)(num2 * 1416374924);
										continue;
									}
									case 6u:
									{
										int num21;
										int num22;
										if (current.Role.BuiltInTalents[30])
										{
											num21 = 1512475553;
											num22 = num21;
										}
										else
										{
											num21 = 307959273;
											num22 = num21;
										}
										num3 = num21 ^ ((int)num2 * -627650631);
										continue;
									}
									case 10u:
									{
										int num17;
										int num18;
										if (current.Role.Female == role.Female)
										{
											num17 = 1523192981;
											num18 = num17;
										}
										else
										{
											num17 = 293944916;
											num18 = num17;
										}
										num3 = num17 ^ ((int)num2 * -920425429);
										continue;
									}
									case 2u:
									{
										int num11;
										int num12;
										if (current.Team != sourceSprite.Team)
										{
											num11 = -1279196079;
											num12 = num11;
										}
										else
										{
											num11 = -547175842;
											num12 = num11;
										}
										num3 = num11 ^ (int)(num2 * 634072915);
										continue;
									}
									case 0u:
										attackResult.AddCastInfo2(zhujueSprite, ResourceStrings.ResStrings[191], 1f, skill.AttackTime);
										num3 = ((int)num2 * -1786412836) ^ 0x59A8F500;
										continue;
									case 8u:
									{
										int num7;
										int num8;
										if (flag)
										{
											num7 = -1896604551;
											num8 = num7;
										}
										else
										{
											num7 = -1817399990;
											num8 = num7;
										}
										num3 = num7 ^ (int)(num2 * 81340732);
										continue;
									}
									case 4u:
										num5 *= Tools.GetRandom(1.2, 1.4);
										num6 *= Tools.GetRandom(1.2, 1.4);
										num3 = 1610637466;
										continue;
									case 1u:
										goto end_IL_1450;
									}
									goto IL_14ed;
									continue;
									end_IL_1450:
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
									IL_1793:
									int num27 = 2014697156;
									while (true)
									{
										switch ((num2 = (uint)(num27 ^ 0x69C4C43D)) % 3)
										{
										case 0u:
											break;
										default:
											goto end_IL_1798;
										case 1u:
											goto IL_17b6;
										case 2u:
											goto end_IL_1798;
										}
										goto IL_1793;
										IL_17b6:
										enumerator.Dispose();
										num27 = ((int)num2 * -1152043075) ^ 0x57ADD898;
										continue;
										end_IL_1798:
										break;
									}
									break;
								}
							}
						}
						goto IL_17ce;
					}
					IL_09ef:
					num28 = num41;
					num = 603113876;
					continue;
					IL_0287:
					num51 = role.AttributesFinal[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(942219431u)];
					num = 1294086102;
					continue;
					IL_0326:
					num51 = role.AttributesFinal[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2722506620u)];
					num = 1065583004;
					continue;
					IL_17ce:
					if (role2.BuiltInTalents[30])
					{
						while (true)
						{
							int num66 = 271929612;
							while (true)
							{
								switch ((num2 = (uint)(num66 ^ 0x69C4C43D)) % 8)
								{
								case 0u:
									break;
								case 7u:
								{
									int num69;
									int num70;
									if (zhujueSprite2.Team != targetSprite.Team)
									{
										num69 = 1550980213;
										num70 = num69;
									}
									else
									{
										num69 = 58016633;
										num70 = num69;
									}
									num66 = num69 ^ (int)(num2 * 371942250);
									continue;
								}
								case 5u:
									flag3 = true;
									num66 = ((int)num2 * -312783405) ^ 0x15681264;
									continue;
								case 3u:
								{
									int num71;
									int num72;
									if (!((Object)(object)zhujueSprite2 != (Object)(object)targetSprite))
									{
										num71 = 1682225082;
										num72 = num71;
									}
									else
									{
										num71 = 1354940411;
										num72 = num71;
									}
									num66 = num71 ^ (int)(num2 * 411787627);
									continue;
								}
								case 2u:
								{
									int num73;
									int num74;
									if (zhujueSprite2.Role.BuiltInTalents[30])
									{
										num73 = 1045726910;
										num74 = num73;
									}
									else
									{
										num73 = 1978105757;
										num74 = num73;
									}
									num66 = num73 ^ ((int)num2 * -1846985689);
									continue;
								}
								case 1u:
									zhujueSprite2 = bf.GetZhujueSprite();
									num66 = ((int)num2 * -672483152) ^ -2145040831;
									continue;
								case 4u:
								{
									flag3 = false;
									int num67;
									int num68;
									if (!((Object)(object)zhujueSprite2 != (Object)null))
									{
										num67 = 578246327;
										num68 = num67;
									}
									else
									{
										num67 = 544541346;
										num68 = num67;
									}
									num66 = num67 ^ (int)(num2 * 422272263);
									continue;
								}
								default:
									goto end_IL_17e0;
								}
								break;
							}
							continue;
							end_IL_17e0:
							break;
						}
						IEnumerator<BattleSprite> enumerator = bf.Sprites.GetEnumerator();
						try
						{
							while (true)
							{
								IL_1a43:
								int num75;
								int num76;
								if (!enumerator.MoveNext())
								{
									num75 = 558540137;
									num76 = num75;
								}
								else
								{
									num75 = 1222063203;
									num76 = num75;
								}
								while (true)
								{
									switch ((num2 = (uint)(num75 ^ 0x69C4C43D)) % 20)
									{
									case 19u:
										num75 = 1222063203;
										continue;
									default:
										goto end_IL_190b;
									case 8u:
										num75 = ((int)num2 * -440381609) ^ 0x5AB5370C;
										continue;
									case 12u:
									{
										int num95;
										int num96;
										if (current2.Role.Female == zhujueSprite2.Role.Female)
										{
											num95 = -1522676090;
											num96 = num95;
										}
										else
										{
											num95 = -708922492;
											num96 = num95;
										}
										num75 = num95 ^ ((int)num2 * -6954764);
										continue;
									}
									case 16u:
										attackResult.AddCastInfo2(targetSprite, ResourceStrings.ResStrings[191], 1f, skill.AttackTime);
										num75 = 1610952055;
										continue;
									case 3u:
									{
										int num93;
										int num94;
										if (current2.Team != targetSprite.Team)
										{
											num93 = -1855289175;
											num94 = num93;
										}
										else
										{
											num93 = -380655289;
											num94 = num93;
										}
										num75 = num93 ^ (int)(num2 * 1098531596);
										continue;
									}
									case 6u:
										current2 = enumerator.Current;
										num75 = 844208154;
										continue;
									case 10u:
									{
										int num83;
										int num84;
										if (flag3)
										{
											num83 = 306513525;
											num84 = num83;
										}
										else
										{
											num83 = 500679651;
											num84 = num83;
										}
										num75 = num83 ^ (int)(num2 * 1281982355);
										continue;
									}
									case 4u:
										break;
									case 5u:
									{
										int num91;
										int num92;
										if (role2.Female == zhujueSprite2.Role.Female)
										{
											num91 = 1854124062;
											num92 = num91;
										}
										else
										{
											num91 = 1914274515;
											num92 = num91;
										}
										num75 = num91 ^ ((int)num2 * -344537034);
										continue;
									}
									case 18u:
									{
										int num87;
										int num88;
										if (!flag3)
										{
											num87 = 1906727136;
											num88 = num87;
										}
										else
										{
											num87 = 1052902264;
											num88 = num87;
										}
										num75 = num87 ^ (int)(num2 * 144445080);
										continue;
									}
									case 13u:
										attackResult.AddCastInfo2(current2, ResourceStrings.ResStrings[191], 1f, skill.AttackTime);
										num75 = 582010352;
										continue;
									case 11u:
									{
										int num79;
										int num80;
										if (!current2.Role.BuiltInTalents[30])
										{
											num79 = -446934739;
											num80 = num79;
										}
										else
										{
											num79 = -321305334;
											num80 = num79;
										}
										num75 = num79 ^ ((int)num2 * -513543376);
										continue;
									}
									case 7u:
										attackResult.AddCastInfo2(zhujueSprite2, ResourceStrings.ResStrings[191], 1f, skill.AttackTime);
										num75 = ((int)num2 * -1516532651) ^ -608796354;
										continue;
									case 2u:
									{
										int num89;
										int num90;
										if (!((Object)(object)current2 != (Object)(object)targetSprite))
										{
											num89 = -1041077669;
											num90 = num89;
										}
										else
										{
											num89 = -714445470;
											num90 = num89;
										}
										num75 = num89 ^ ((int)num2 * -1927121627);
										continue;
									}
									case 9u:
									{
										int num85;
										int num86;
										if (current2.Role.Female != role2.Female)
										{
											num85 = -1991624936;
											num86 = num85;
										}
										else
										{
											num85 = -1445963867;
											num86 = num85;
										}
										num75 = num85 ^ (int)(num2 * 1783106456);
										continue;
									}
									case 17u:
										num35 *= Tools.GetRandom(1.2, 1.4);
										num75 = 1349921482;
										continue;
									case 1u:
									{
										int num81;
										int num82;
										if (Tools.ProbabilityTest(0.45))
										{
											num81 = -1307593431;
											num82 = num81;
										}
										else
										{
											num81 = -1512381810;
											num82 = num81;
										}
										num75 = num81 ^ (int)(num2 * 866371286);
										continue;
									}
									case 14u:
									{
										int num77;
										int num78;
										if (flag3)
										{
											num77 = -2123744795;
											num78 = num77;
										}
										else
										{
											num77 = -1075089760;
											num78 = num77;
										}
										num75 = num77 ^ ((int)num2 * -1036664990);
										continue;
									}
									case 15u:
										goto end_IL_190b;
									case 0u:
										goto end_IL_190b;
									}
									goto IL_1a43;
									continue;
									end_IL_190b:
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
									IL_1c2c:
									int num97 = 1869720612;
									while (true)
									{
										switch ((num2 = (uint)(num97 ^ 0x69C4C43D)) % 3)
										{
										case 0u:
											break;
										default:
											goto end_IL_1c31;
										case 1u:
											goto IL_1c4f;
										case 2u:
											goto end_IL_1c31;
										}
										goto IL_1c2c;
										IL_1c4f:
										enumerator.Dispose();
										num97 = (int)(num2 * 1987159156) ^ -1514406850;
										continue;
										end_IL_1c31:
										break;
									}
									break;
								}
							}
						}
					}
					if (role2.BuiltInTalents[31])
					{
						goto IL_1c79;
					}
					goto IL_2ac5;
					IL_2ac5:
					if (role.BuiltInTalents[32])
					{
						num100 = 2075973767;
						num101 = num100;
					}
					else
					{
						num100 = 1914215075;
						num101 = num100;
					}
					goto IL_1c7e;
					IL_1c7e:
					while (true)
					{
						switch ((num2 = (uint)(num100 ^ 0x69C4C43D)) % 200)
						{
						case 96u:
							break;
						case 78u:
							buff12 = new Buff();
							buff12.Name = ResourceStrings.ResStrings[551];
							buff12.Level = 0;
							num100 = ((int)num2 * -1226941544) ^ 0x585F63C7;
							continue;
						case 120u:
							buff11.Round = 2;
							attackResult.Debuff.Add(buff11);
							num100 = ((int)num2 * -568532209) ^ -940157688;
							continue;
						case 113u:
							buff6.Level = 0;
							buff6.Round = 2;
							attackResult.Debuff.Add(buff6);
							num100 = ((int)num2 * -1544412031) ^ 0x7EF25FC7;
							continue;
						case 18u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[862].Split('#'), 0.55f, skill.AttackTime);
							num100 = 832271321;
							continue;
						case 146u:
							buff12.Round = 2;
							attackResult.Debuff.Add(buff12);
							num100 = (int)(num2 * 1187491962) ^ -1154507062;
							continue;
						case 112u:
							buff11 = new Buff();
							num100 = (int)((num2 * 142148761) ^ 0x6176F24E);
							continue;
						case 69u:
							num6 *= 1.2;
							num58 += 0.15;
							num100 = ((int)num2 * -271732781) ^ 0x6AE759C3;
							continue;
						case 20u:
							num152 += 0.12;
							num100 = (int)(num2 * 201007951) ^ -84433757;
							continue;
						case 3u:
							num100 = ((int)num2 * -1715801677) ^ -1926346643;
							continue;
						case 107u:
						{
							int num157;
							int num158;
							if (!name.StartsWith(ResourceStrings.ResStrings[725]))
							{
								num157 = -708739724;
								num158 = num157;
							}
							else
							{
								num157 = -1106526925;
								num158 = num157;
							}
							num100 = num157 ^ ((int)num2 * -411897281);
							continue;
						}
						case 196u:
							num58 *= Tools.GetRandom(1.0, 1.5);
							num5 *= Tools.GetRandom(1.0, 1.3);
							num100 = ((int)num2 * -65045109) ^ 0x45A06215;
							continue;
						case 68u:
							buff4 = new Buff();
							num100 = 570329370;
							continue;
						case 22u:
							attackResult.Debuff.Add(buff);
							num100 = ((int)num2 * -1414456800) ^ 0xD5E8342;
							continue;
						case 16u:
							buff7.Round = 2;
							attackResult.Debuff.Add(buff7);
							num100 = ((int)num2 * -2095828299) ^ -1118019605;
							continue;
						case 7u:
						{
							int num193;
							int num194;
							if (Tools.GetRandom(0.0, 1.0) <= num110)
							{
								num193 = -1104002063;
								num194 = num193;
							}
							else
							{
								num193 = -2086851412;
								num194 = num193;
							}
							num100 = num193 ^ ((int)num2 * -280749548);
							continue;
						}
						case 110u:
							buff5 = new Buff();
							buff5.Name = ResourceStrings.ResStrings[535];
							buff5.Level = 0;
							buff5.Round = 2;
							num100 = (int)((num2 * 1524989213) ^ 0x484655C3);
							continue;
						case 142u:
							buff8.Level = 1;
							num100 = (int)(num2 * 3791157) ^ -1456480618;
							continue;
						case 176u:
							num111 = role.AttributesFinal[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1412133437u)];
							num100 = 697377975;
							continue;
						case 115u:
						{
							int num167;
							int num168;
							if (!Tools.ProbabilityTest(num110))
							{
								num167 = 1348772887;
								num168 = num167;
							}
							else
							{
								num167 = 1725480517;
								num168 = num167;
							}
							num100 = num167 ^ ((int)num2 * -72984625);
							continue;
						}
						case 134u:
							num100 = (int)((num2 * 841615843) ^ 0x6995EB62);
							continue;
						case 60u:
						{
							int num161;
							int num162;
							if (name2 == ResourceStrings.ResStrings[723])
							{
								num161 = 2018041792;
								num162 = num161;
							}
							else
							{
								num161 = 260793542;
								num162 = num161;
							}
							num100 = num161 ^ ((int)num2 * -1023381722);
							continue;
						}
						case 128u:
							buff9.Level = 0;
							num100 = (int)((num2 * 1307513015) ^ 0x74F63E26);
							continue;
						case 79u:
						{
							int num141;
							int num142;
							if (name.Contains(ResourceStrings.ResStrings[719]))
							{
								num141 = -1776563906;
								num142 = num141;
							}
							else
							{
								num141 = -951108171;
								num142 = num141;
							}
							num100 = num141 ^ ((int)num2 * -1667144489);
							continue;
						}
						case 14u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[877].Split('#'), 0.2f, skill.AttackTime);
							num100 = ((int)num2 * -1755252710) ^ -2064929279;
							continue;
						case 65u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[878].Split('#'), 0.12f, skill.AttackTime);
							buff10 = targetSprite.GetBuff(ResourceStrings.ResStrings[542]);
							num100 = (int)((num2 * 957415270) ^ 0x180D4C25);
							continue;
						case 9u:
							buff3 = new Buff();
							buff3.Name = ResourceStrings.ResStrings[551];
							num100 = ((int)num2 * -1822084794) ^ -1027344782;
							continue;
						case 145u:
							goto IL_2442;
						case 179u:
							attackResult.Debuff.Add(buff8);
							num100 = ((int)num2 * -1611329653) ^ 0x5B4F646A;
							continue;
						case 64u:
							num6 += 400.0;
							num100 = (int)(num2 * 1010113307) ^ -1661984618;
							continue;
						case 0u:
							num5 *= Tools.GetRandom(1.0, 1.5);
							num100 = (int)((num2 * 967110631) ^ 0x6AF2C6F);
							continue;
						case 106u:
							num100 = (int)(num2 * 1455488156) ^ -2075961354;
							continue;
						case 2u:
							goto IL_24e8;
						case 119u:
							buff7.Name = ResourceStrings.ResStrings[531];
							buff7.Level = 0;
							num100 = ((int)num2 * -1591152786) ^ -909241385;
							continue;
						case 55u:
							goto IL_253c;
						case 87u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[865].Split('#'), 0.12f, skill.AttackTime);
							num5 *= 1.2;
							num100 = ((int)num2 * -142297949) ^ 0x58E4BAF5;
							continue;
						case 149u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[870].Split('#'), 0.12f, skill.AttackTime);
							num100 = ((int)num2 * -928722443) ^ 0x40E507C7;
							continue;
						case 102u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[859].Split('#'), 0.15f, skill.AttackTime);
							num35 *= 0.8;
							num100 = (int)((num2 * 1061762756) ^ 0x1B2ADE0);
							continue;
						case 98u:
							goto IL_2647;
						case 166u:
							num35 *= 1.5;
							attackResult.AddCastInfo2(targetSprite, ResourceStrings.ResStrings[855].Split('#'), 0.12f, skill.AttackTime);
							num100 = ((int)num2 * -47065128) ^ -367400396;
							continue;
						case 25u:
							goto IL_26b6;
						case 97u:
							num114 = 10;
							num100 = (int)((num2 * 1740535334) ^ 0x390D0934);
							continue;
						case 15u:
							num58 += 0.25;
							num5 *= 1.3;
							num100 = (int)(num2 * 2002650080) ^ -2110753562;
							continue;
						case 150u:
						{
							int num191;
							int num192;
							if (Tools.ProbabilityTest(num110))
							{
								num191 = -1735568390;
								num192 = num191;
							}
							else
							{
								num191 = -184395184;
								num192 = num191;
							}
							num100 = num191 ^ (int)(num2 * 1995692177);
							continue;
						}
						case 130u:
							goto IL_2745;
						case 89u:
						{
							int num187;
							int num188;
							if (!name.Contains(ResourceStrings.ResStrings[703]))
							{
								num187 = 1521344777;
								num188 = num187;
							}
							else
							{
								num187 = 583866465;
								num188 = num187;
							}
							num100 = num187 ^ (int)(num2 * 1586535662);
							continue;
						}
						case 114u:
							goto IL_279d;
						case 72u:
							attackResult.Debuff.Add(buff3);
							num100 = (int)(num2 * 996046785) ^ -723746881;
							continue;
						case 137u:
							buff8.Name = ResourceStrings.ResStrings[542];
							num100 = (int)((num2 * 946108925) ^ 0x7D4222C6);
							continue;
						case 199u:
							goto IL_2809;
						case 42u:
							buff7 = new Buff();
							num100 = ((int)num2 * -654081813) ^ 0x73F23A3C;
							continue;
						case 28u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[861].Split('#'), 0.7f, skill.AttackTime);
							num100 = 373203762;
							continue;
						case 180u:
						{
							int num179;
							int num180;
							if (Tools.ProbabilityTest(Math.Min(0.5, (double)role.Level * 0.01)))
							{
								num179 = -126818645;
								num180 = num179;
							}
							else
							{
								num179 = -771364834;
								num180 = num179;
							}
							num100 = num179 ^ (int)(num2 * 508036932);
							continue;
						}
						case 131u:
							goto IL_28c4;
						case 160u:
							goto IL_28e5;
						case 156u:
							goto IL_2906;
						case 33u:
							buff4.Round = 4;
							num100 = (int)(num2 * 1083748992) ^ -52934679;
							continue;
						case 61u:
							attackResult.AddCastInfo2(targetSprite, ResourceStrings.ResStrings[867].Split('#'), 0.2f, skill.AttackTime);
							num100 = ((int)num2 * -1342415483) ^ 0x7AB41C34;
							continue;
						case 118u:
							goto IL_2988;
						case 40u:
							num100 = (int)(num2 * 1905962877) ^ -1226473070;
							continue;
						case 187u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[869].Split('#'), 0.12f, skill.AttackTime);
							num100 = ((int)num2 * -432898926) ^ 0x42A8170E;
							continue;
						case 75u:
							buff.Level = 0;
							num100 = ((int)num2 * -120638090) ^ 0x3703F192;
							continue;
						case 82u:
						{
							int num171;
							int num172;
							if (!Tools.ProbabilityTest(num110))
							{
								num171 = 1958795782;
								num172 = num171;
							}
							else
							{
								num171 = 285991877;
								num172 = num171;
							}
							num100 = num171 ^ (int)(num2 * 1431447254);
							continue;
						}
						case 6u:
							num5 = 0.0;
							num100 = (int)(num2 * 2067947983) ^ -1528312958;
							continue;
						case 194u:
						{
							int num163;
							int num164;
							if (Tools.ProbabilityTest(num110))
							{
								num163 = 1170306556;
								num164 = num163;
							}
							else
							{
								num163 = 1166267795;
								num164 = num163;
							}
							num100 = num163 ^ ((int)num2 * -649259114);
							continue;
						}
						case 181u:
						{
							int num155;
							int num156;
							if (!name.Contains(ResourceStrings.ResStrings[721]))
							{
								num155 = -486381416;
								num156 = num155;
							}
							else
							{
								num155 = -1710893146;
								num156 = num155;
							}
							num100 = num155 ^ ((int)num2 * -309779028);
							continue;
						}
						case 93u:
							goto IL_2ac5;
						case 153u:
						{
							num152 = 0.12;
							int num153;
							int num154;
							if (!role.BuiltInTalents[136])
							{
								num153 = -179346663;
								num154 = num153;
							}
							else
							{
								num153 = -79168833;
								num154 = num153;
							}
							num100 = num153 ^ ((int)num2 * -1793775074);
							continue;
						}
						case 155u:
							goto IL_2b22;
						case 141u:
							goto IL_2b45;
						case 157u:
							buff = new Buff();
							num100 = (int)((num2 * 1661873553) ^ 0x6740C39C);
							continue;
						case 127u:
							num5 *= (double)(1f + num113 * (float)num114);
							num100 = 652187675;
							continue;
						case 125u:
							num5 += 400.0;
							num100 = (int)((num2 * 282330284) ^ 0x64EAB11);
							continue;
						case 67u:
							buff11.Name = ResourceStrings.ResStrings[533];
							buff11.Level = 0;
							num100 = ((int)num2 * -1769360083) ^ -1933335406;
							continue;
						case 105u:
							goto IL_2bf2;
						case 32u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[858].Split('#'), 0.15f, skill.AttackTime);
							num5 *= 1.2;
							num100 = ((int)num2 * -123117138) ^ -1121029099;
							continue;
						case 59u:
							goto IL_2c5c;
						case 117u:
						{
							int num143;
							int num144;
							if (Tools.ProbabilityTest(0.3))
							{
								num143 = 757413728;
								num144 = num143;
							}
							else
							{
								num143 = 1572486924;
								num144 = num143;
							}
							num100 = num143 ^ ((int)num2 * -1729803252);
							continue;
						}
						case 44u:
							num6 *= 1.0 + (double)balls * 0.1;
							num100 = (int)((num2 * 1063624049) ^ 0x36089ED5);
							continue;
						case 165u:
						{
							int num135;
							int num136;
							if (!(name == ResourceStrings.ResStrings[638]))
							{
								num135 = -786833519;
								num136 = num135;
							}
							else
							{
								num135 = -795232929;
								num136 = num135;
							}
							num100 = num135 ^ (int)(num2 * 1055308042);
							continue;
						}
						case 74u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[871].Split('#'), 0.12f, skill.AttackTime);
							num100 = ((int)num2 * -1109856523) ^ -1603629120;
							continue;
						case 91u:
							num113 = 0.1f;
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[880].Split('#'), 0.12f, skill.AttackTime);
							num100 = (int)((num2 * 1704193613) ^ 0x2175B431);
							continue;
						case 66u:
							num112 = role2.AttributesFinal[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(912726802u)];
							num100 = ((int)num2 * -1860262296) ^ 0x1CEC628F;
							continue;
						case 147u:
							num5 += 250.0;
							num6 += 250.0;
							num100 = ((int)num2 * -867203004) ^ -115742944;
							continue;
						case 94u:
						{
							int num127;
							int num128;
							if (Tools.ProbabilityTest(num110))
							{
								num127 = -714850607;
								num128 = num127;
							}
							else
							{
								num127 = -1630482232;
								num128 = num127;
							}
							num100 = num127 ^ (int)(num2 * 2090180995);
							continue;
						}
						case 13u:
							goto IL_2e1f;
						case 54u:
						{
							int num123;
							int num124;
							if (!Tools.ProbabilityTest(Math.Min(0.95, (double)role.Level * 0.025)))
							{
								num123 = -26718658;
								num124 = num123;
							}
							else
							{
								num123 = -1633832518;
								num124 = num123;
							}
							num100 = num123 ^ ((int)num2 * -1621078455);
							continue;
						}
						case 57u:
							buff6 = new Buff();
							buff6.Name = ResourceStrings.ResStrings[537];
							num100 = (int)(num2 * 828985903) ^ -1817831741;
							continue;
						case 104u:
							goto IL_2eb5;
						case 4u:
							num58 += 0.5;
							num100 = ((int)num2 * -439864103) ^ -732214702;
							continue;
						case 35u:
						{
							int num117;
							int num118;
							if (num110 >= 0.001)
							{
								num117 = -62444959;
								num118 = num117;
							}
							else
							{
								num117 = -1331836853;
								num118 = num117;
							}
							num100 = num117 ^ ((int)num2 * -595726619);
							continue;
						}
						case 132u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[855].Split('#'), 0.12f, skill.AttackTime);
							num100 = ((int)num2 * -877264690) ^ -346116853;
							continue;
						case 34u:
							buff2.Name = ResourceStrings.ResStrings[539];
							buff2.Level = 0;
							buff2.Round = 2;
							attackResult.Debuff.Add(buff2);
							num100 = ((int)num2 * -1885314594) ^ -1071047418;
							continue;
						case 58u:
							goto IL_2fab;
						case 38u:
							goto IL_2fce;
						case 177u:
							num58 += 0.25;
							num100 = ((int)num2 * -945750299) ^ -859168544;
							continue;
						case 80u:
							goto IL_3012;
						case 90u:
							num110 = num111 / 100.0 - num112 / 100.0;
							num100 = (int)(num2 * 659041862) ^ -1429756542;
							continue;
						case 81u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[863].Split('#'), 0.12f, skill.AttackTime);
							num100 = ((int)num2 * -571025793) ^ 0x71E356A4;
							continue;
						case 190u:
						{
							int num195;
							int num196;
							if (buff10 != null)
							{
								num195 = 1075662535;
								num196 = num195;
							}
							else
							{
								num195 = 788385253;
								num196 = num195;
							}
							num100 = num195 ^ (int)(num2 * 302437117);
							continue;
						}
						case 92u:
							num58 += 0.1;
							num100 = ((int)num2 * -1831853483) ^ -2117904612;
							continue;
						case 111u:
							goto IL_30e9;
						case 174u:
							goto IL_30ff;
						case 182u:
							num6 *= 1.3;
							num100 = ((int)num2 * -1886786613) ^ 0x6FF045FF;
							continue;
						case 184u:
						{
							int num189;
							int num190;
							if (!(name2 == ResourceStrings.ResStrings[715]))
							{
								num189 = -1142252796;
								num190 = num189;
							}
							else
							{
								num189 = -621547101;
								num190 = num189;
							}
							num100 = num189 ^ (int)(num2 * 1634172228);
							continue;
						}
						case 133u:
						{
							int num185;
							int num186;
							if (!role2.Female)
							{
								num185 = -1778651846;
								num186 = num185;
							}
							else
							{
								num185 = -9891872;
								num186 = num185;
							}
							num100 = num185 ^ ((int)num2 * -1625272831);
							continue;
						}
						case 195u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[864].Split('#'), 0.12f, skill.AttackTime);
							num100 = ((int)num2 * -1652748100) ^ -1610098976;
							continue;
						case 48u:
							attackResult.AddCastInfo2(targetSprite, ResourceStrings.ResStrings[868].Split('#'), 0.12f, skill.AttackTime);
							num35 *= 1.3;
							num100 = ((int)num2 * -59475253) ^ 0x46FDCC47;
							continue;
						case 192u:
							num35 *= 1.2;
							num100 = (int)((num2 * 1593620946) ^ 0x63C7D4AE);
							continue;
						case 85u:
							num6 *= 1.5;
							num100 = 2118373671;
							continue;
						case 31u:
							num58 += 0.25;
							num100 = ((int)num2 * -1543658574) ^ 0x28472B7F;
							continue;
						case 45u:
							num113 = 0.18f;
							num100 = ((int)num2 * -1738119903) ^ -154458522;
							continue;
						case 19u:
							num100 = ((int)num2 * -375011533) ^ -2101859217;
							continue;
						case 144u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[876].Split('#'), 0.12f, skill.AttackTime);
							num100 = ((int)num2 * -1324210121) ^ -2089076615;
							continue;
						case 63u:
							goto IL_32fe;
						case 167u:
							num58 = 1.0;
							num100 = (int)(num2 * 1535927558) ^ -26577736;
							continue;
						case 53u:
							goto IL_333f;
						case 11u:
							goto IL_3362;
						case 56u:
							num6 *= 1.2;
							num100 = ((int)num2 * -676125949) ^ -922273169;
							continue;
						case 138u:
							num6 *= Tools.GetRandom(1.0, 1.5);
							num100 = (int)(num2 * 1188705802) ^ -1263694560;
							continue;
						case 23u:
							goto IL_33d5;
						case 193u:
						{
							int num183;
							int num184;
							if (!(name == ResourceStrings.ResStrings[720]))
							{
								num183 = -33535373;
								num184 = num183;
							}
							else
							{
								num183 = -1717954086;
								num184 = num183;
							}
							num100 = num183 ^ (int)(num2 * 1396637565);
							continue;
						}
						case 51u:
							goto IL_342d;
						case 159u:
						{
							int num181;
							int num182;
							if (!(name == ResourceStrings.ResStrings[718]))
							{
								num181 = 458682519;
								num182 = num181;
							}
							else
							{
								num181 = 65144908;
								num182 = num181;
							}
							num100 = num181 ^ ((int)num2 * -1869927421);
							continue;
						}
						case 62u:
						{
							int num177;
							int num178;
							if (name == ResourceStrings.ResStrings[639])
							{
								num177 = -368208063;
								num178 = num177;
							}
							else
							{
								num177 = -2125512450;
								num178 = num177;
							}
							num100 = num177 ^ (int)(num2 * 762174290);
							continue;
						}
						case 129u:
							num100 = ((int)num2 * -2127523204) ^ 0x492720A8;
							continue;
						case 52u:
						{
							int num175;
							int num176;
							if (!role.BuiltInTalents[55])
							{
								num175 = -1066236613;
								num176 = num175;
							}
							else
							{
								num175 = -714878086;
								num176 = num175;
							}
							num100 = num175 ^ ((int)num2 * -1466590079);
							continue;
						}
						case 171u:
							goto IL_34f9;
						case 108u:
							num6 *= Tools.GetRandom(1.0, 1.3);
							num100 = (int)(num2 * 455682291) ^ -811923552;
							continue;
						case 123u:
							num113 = 0f;
							num100 = 1357039665;
							continue;
						case 99u:
							goto IL_3556;
						case 37u:
							goto IL_3579;
						case 186u:
							goto IL_359c;
						case 77u:
							goto IL_35bf;
						case 162u:
						{
							int num173;
							int num174;
							if (!name.StartsWith(ResourceStrings.ResStrings[714]))
							{
								num173 = 691300763;
								num174 = num173;
							}
							else
							{
								num173 = 1340993530;
								num174 = num173;
							}
							num100 = num173 ^ (int)(num2 * 765516);
							continue;
						}
						case 70u:
							buff8 = new Buff();
							num100 = ((int)num2 * -1197147096) ^ -11512932;
							continue;
						case 163u:
							num58 *= 1.5;
							num100 = (int)(num2 * 1355013325) ^ -1555807303;
							continue;
						case 46u:
							goto IL_3652;
						case 86u:
							attackResult.AddCastInfo2(targetSprite, ResourceStrings.ResStrings[872].Split('#'), 0.12f, skill.AttackTime);
							num35 *= 2.0;
							num100 = ((int)num2 * -835057433) ^ -255852147;
							continue;
						case 169u:
							buff9.Name = ResourceStrings.ResStrings[536];
							num100 = ((int)num2 * -816780238) ^ -1920286393;
							continue;
						case 124u:
							buff.Name = ResourceStrings.ResStrings[534];
							num100 = (int)((num2 * 695040958) ^ 0x1D89A686);
							continue;
						case 148u:
							num6 *= 1.0 + 0.5 * (1.0 - num149);
							num100 = (int)((num2 * 944825134) ^ 0x17ECD5EB);
							continue;
						case 109u:
							goto IL_3751;
						case 188u:
						{
							int num169;
							int num170;
							if (Tools.ProbabilityTest(0.25))
							{
								num169 = -1737014817;
								num170 = num169;
							}
							else
							{
								num169 = -1127327933;
								num170 = num169;
							}
							num100 = num169 ^ (int)(num2 * 1626677069);
							continue;
						}
						case 10u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[856].Split('#'), 0.2f, skill.AttackTime);
							num5 *= 1.5;
							num100 = (int)(num2 * 1931515294) ^ -1725372875;
							continue;
						case 50u:
						{
							int num165;
							int num166;
							if ((double)((float)role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3054398905u)] / (float)role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(592457607u)]) > 0.3)
							{
								num165 = -1317044566;
								num166 = num165;
							}
							else
							{
								num165 = -1831052229;
								num166 = num165;
							}
							num100 = num165 ^ ((int)num2 * -2131283490);
							continue;
						}
						case 198u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[879].Split('#'), 0.12f, skill.AttackTime);
							num100 = (int)((num2 * 716418310) ^ 0x6559C26A);
							continue;
						case 154u:
						{
							int num159;
							int num160;
							if (role.Female)
							{
								num159 = 196998717;
								num160 = num159;
							}
							else
							{
								num159 = 237539678;
								num160 = num159;
							}
							num100 = num159 ^ (int)(num2 * 290932539);
							continue;
						}
						case 189u:
							goto IL_38b2;
						case 183u:
							num5 *= 1.5;
							num6 *= 1.5;
							num100 = (int)(num2 * 379644903) ^ -1990009153;
							continue;
						case 29u:
							goto IL_3904;
						case 191u:
							buff4.Name = ResourceStrings.ResStrings[542];
							buff4.Level = ((buff10.Level + 1 > 10) ? 10 : (buff10.Level + 1));
							num100 = 213339028;
							continue;
						case 185u:
						{
							num5 *= 0.5;
							int num150;
							int num151;
							if (num5 < 0.0)
							{
								num150 = 1092386067;
								num151 = num150;
							}
							else
							{
								num150 = 1811527280;
								num151 = num150;
							}
							num100 = num150 ^ ((int)num2 * -1266555288);
							continue;
						}
						case 27u:
							num149 = (double)role2.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2873590287u)] / (double)role2.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1995100678u)];
							num5 *= 1.0 + 0.5 * (1.0 - num149);
							num100 = (int)(num2 * 1315931781) ^ -901157154;
							continue;
						case 36u:
						{
							int num147;
							int num148;
							if (name.StartsWith(ResourceStrings.ResStrings[726]))
							{
								num147 = 92963726;
								num148 = num147;
							}
							else
							{
								num147 = 1784782491;
								num148 = num147;
							}
							num100 = num147 ^ (int)(num2 * 532262336);
							continue;
						}
						case 83u:
							num6 *= 1.3;
							num100 = (int)((num2 * 1863221284) ^ 0x6F5F4CE);
							continue;
						case 88u:
							goto IL_3a5d;
						case 121u:
							buff3.Level = 3;
							num100 = (int)(num2 * 1159511632) ^ -1714355167;
							continue;
						case 47u:
							num114 = bf.GetTeamCount(sourceSprite.Team);
							num100 = ((int)num2 * -326269184) ^ 0x528BF710;
							continue;
						case 103u:
							num58 += 0.1;
							num100 = (int)((num2 * 148842252) ^ 0x56B6B8CF);
							continue;
						case 8u:
						{
							int num145;
							int num146;
							if (!Tools.ProbabilityTest(num110))
							{
								num145 = -1492750397;
								num146 = num145;
							}
							else
							{
								num145 = -428293244;
								num146 = num145;
							}
							num100 = num145 ^ ((int)num2 * -260186612);
							continue;
						}
						case 84u:
							buff2 = new Buff();
							num100 = ((int)num2 * -1564188971) ^ -2140905789;
							continue;
						case 116u:
							num6 *= 1.5;
							num100 = (int)((num2 * 851537259) ^ 0x4DB17BAA);
							continue;
						case 100u:
							attackResult.AddCastInfo2(targetSprite, ResourceStrings.ResStrings[866].Split('#'), 0.15f, skill.AttackTime);
							num35 *= 1.2;
							num100 = ((int)num2 * -1004866664) ^ -777232225;
							continue;
						case 73u:
						{
							int num139;
							int num140;
							if (name == ResourceStrings.ResStrings[637])
							{
								num139 = -1605446091;
								num140 = num139;
							}
							else
							{
								num139 = -1164615352;
								num140 = num139;
							}
							num100 = num139 ^ (int)(num2 * 12868488);
							continue;
						}
						case 170u:
						{
							int num137;
							int num138;
							if (name2 == ResourceStrings.ResStrings[722])
							{
								num137 = -1952145559;
								num138 = num137;
							}
							else
							{
								num137 = -115079881;
								num138 = num137;
							}
							num100 = num137 ^ ((int)num2 * -1167540140);
							continue;
						}
						case 26u:
						{
							int num133;
							int num134;
							if (!name.Contains(ResourceStrings.ResStrings[721]))
							{
								num133 = 1174109193;
								num134 = num133;
							}
							else
							{
								num133 = 42471554;
								num134 = num133;
							}
							num100 = num133 ^ ((int)num2 * -825263662);
							continue;
						}
						case 197u:
						{
							int num131;
							int num132;
							if (num114 <= 10)
							{
								num131 = 1897415526;
								num132 = num131;
							}
							else
							{
								num131 = 1719875184;
								num132 = num131;
							}
							num100 = num131 ^ ((int)num2 * -876709868);
							continue;
						}
						case 173u:
							buff9 = new Buff();
							num100 = ((int)num2 * -1920017284) ^ -826397704;
							continue;
						case 139u:
							buff9.Round = 2;
							attackResult.Debuff.Add(buff9);
							num100 = ((int)num2 * -119609066) ^ 0x71E17F9D;
							continue;
						case 12u:
							goto IL_3c9d;
						case 21u:
							buff8.Round = 4;
							num100 = (int)((num2 * 1003489623) ^ 0x7E8221D5);
							continue;
						case 135u:
							goto IL_3ce4;
						case 95u:
						{
							int num129;
							int num130;
							if (!role2.Animal)
							{
								num129 = -1872594715;
								num130 = num129;
							}
							else
							{
								num129 = -1000611324;
								num130 = num129;
							}
							num100 = num129 ^ (int)(num2 * 1338535429);
							continue;
						}
						case 151u:
							goto IL_3d2c;
						case 172u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[875].Split('#'), 0.12f, skill.AttackTime);
							num58 *= Tools.GetRandom(1.0, 2.0);
							num100 = (int)(num2 * 1831129564) ^ -1387308899;
							continue;
						case 17u:
							num110 = 0.001;
							num100 = ((int)num2 * -1616274434) ^ 0x7D24DD95;
							continue;
						case 136u:
							num58 += 0.25;
							num100 = ((int)num2 * -2115673994) ^ -956268656;
							continue;
						case 5u:
							buff.Round = 2;
							num100 = (int)(num2 * 677086552) ^ -240634109;
							continue;
						case 143u:
							num110 = 0.9;
							num100 = (int)(num2 * 180905031) ^ -234799463;
							continue;
						case 30u:
							num35 *= 0.3;
							num100 = ((int)num2 * -908110335) ^ -41387205;
							continue;
						case 43u:
							goto IL_3e48;
						case 161u:
							goto IL_3e92;
						case 175u:
						{
							int num125;
							int num126;
							if (name.StartsWith(ResourceStrings.ResStrings[717]))
							{
								num125 = -787611664;
								num126 = num125;
							}
							else
							{
								num125 = -588819869;
								num126 = num125;
							}
							num100 = num125 ^ ((int)num2 * -250070794);
							continue;
						}
						case 168u:
							attackResult.AddCastInfo2(targetSprite, ResourceStrings.ResStrings[854].Split('#'), 0.12f, skill.AttackTime);
							num35 *= 1.2;
							num35 += (double)(10 * role2.Level);
							num100 = (int)((num2 * 1697240427) ^ 0x404A1748);
							continue;
						case 152u:
						{
							int num121;
							int num122;
							if (name2.StartsWith(ResourceStrings.ResStrings[724]))
							{
								num121 = 81502253;
								num122 = num121;
							}
							else
							{
								num121 = 415848791;
								num122 = num121;
							}
							num100 = num121 ^ ((int)num2 * -109354390);
							continue;
						}
						case 158u:
						{
							int num119;
							int num120;
							if (!role.BuiltInTalents[58])
							{
								num119 = -2052048021;
								num120 = num119;
							}
							else
							{
								num119 = -112331126;
								num120 = num119;
							}
							num100 = num119 ^ (int)(num2 * 1681561673);
							continue;
						}
						case 24u:
							attackResult.Debuff.Add(buff5);
							num100 = ((int)num2 * -1012333398) ^ 0x2A7F744A;
							continue;
						case 39u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[860].Split('#'), 0.7f, skill.AttackTime);
							num58 += 0.25;
							num5 *= 1.3;
							num100 = (int)((num2 * 306677080) ^ 0xE3F6CA3);
							continue;
						case 178u:
							goto IL_402c;
						case 41u:
						{
							int num115;
							int num116;
							if (Tools.ProbabilityTest(0.25))
							{
								num115 = -1182026039;
								num116 = num115;
							}
							else
							{
								num115 = -2007418446;
								num116 = num115;
							}
							num100 = num115 ^ ((int)num2 * -1853588848);
							continue;
						}
						case 76u:
							attackResult.Debuff.Add(buff4);
							num100 = (int)(num2 * 231998171) ^ -1300037921;
							continue;
						case 140u:
							buff3.Round = 2;
							num100 = (int)(num2 * 1617558949) ^ -1113052255;
							continue;
						case 126u:
							num6 *= (double)(1f + num113 * (float)num114);
							num100 = ((int)num2 * -2129835245) ^ -183857576;
							continue;
						case 164u:
						{
							int num108;
							int num109;
							if (!role.BuiltInTalents[68])
							{
								num108 = -2031790836;
								num109 = num108;
							}
							else
							{
								num108 = -227770252;
								num109 = num108;
							}
							num100 = num108 ^ ((int)num2 * -890481687);
							continue;
						}
						case 101u:
							num58 = 1.0;
							num100 = (int)(num2 * 1109278467) ^ -1002478876;
							continue;
						case 1u:
						{
							int num106;
							int num107;
							if (!name.StartsWith(ResourceStrings.ResStrings[724]))
							{
								num106 = -275937260;
								num107 = num106;
							}
							else
							{
								num106 = -1857699985;
								num107 = num106;
							}
							num100 = num106 ^ ((int)num2 * -1250405407);
							continue;
						}
						case 122u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[857].Split('#'), 0.12f, skill.AttackTime);
							num100 = (int)(num2 * 1954487858) ^ -1309569248;
							continue;
						case 49u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[874].Split('#'), 0.12f, skill.AttackTime);
							balls = sourceSprite.Balls;
							num5 *= 1.0 + (double)balls * 0.1;
							num100 = ((int)num2 * -1252594867) ^ -939643788;
							continue;
						default:
							goto IL_4207;
						}
						break;
						IL_4207:
						IEnumerator<BattleSprite> enumerator = bf.Sprites.GetEnumerator();
						try
						{
							while (true)
							{
								IL_42a4:
								int num197;
								int num198;
								if (!enumerator.MoveNext())
								{
									num197 = 144408738;
									num198 = num197;
								}
								else
								{
									num197 = 19306196;
									num198 = num197;
								}
								while (true)
								{
									switch ((num2 = (uint)(num197 ^ 0x69C4C43D)) % 13)
									{
									case 0u:
										num197 = 19306196;
										continue;
									default:
										goto end_IL_421e;
									case 1u:
										flag4 = true;
										num197 = (int)((num2 * 851482708) ^ 0x579BC4C9);
										continue;
									case 5u:
									{
										int num205;
										if (current3.Role.BuiltInTalents[69])
										{
											num197 = 1529576644;
											num205 = num197;
										}
										else
										{
											num197 = 922019749;
											num205 = num197;
										}
										continue;
									}
									case 2u:
										break;
									case 12u:
										num6 *= 0.9;
										num5 *= 0.9;
										goto end_IL_421e;
									case 10u:
									{
										int num201;
										int num202;
										if (!((Object)(object)current3 != (Object)(object)sourceSprite))
										{
											num201 = 884889256;
											num202 = num201;
										}
										else
										{
											num201 = 1977565156;
											num202 = num201;
										}
										num197 = num201 ^ (int)(num2 * 106439330);
										continue;
									}
									case 8u:
									{
										flag4 = false;
										int num203;
										int num204;
										if (!current3.Role.BuiltInTalents[68])
										{
											num203 = -1443085148;
											num204 = num203;
										}
										else
										{
											num203 = -243682658;
											num204 = num203;
										}
										num197 = num203 ^ (int)(num2 * 760997288);
										continue;
									}
									case 3u:
										attackResult.AddCastInfo2(current3, ResourceStrings.ResStrings[879].Split('#'), 0.12f, skill.AttackTime);
										flag4 = true;
										num197 = ((int)num2 * -1848566782) ^ 0x3086CCF8;
										continue;
									case 11u:
									{
										current3 = enumerator.Current;
										int num200;
										if (current3.Team != sourceSprite.Team)
										{
											num197 = 1971933402;
											num200 = num197;
										}
										else
										{
											num197 = 1874550100;
											num200 = num197;
										}
										continue;
									}
									case 4u:
									{
										int num199;
										if (flag4)
										{
											num197 = 880536624;
											num199 = num197;
										}
										else
										{
											num197 = 1971933402;
											num199 = num197;
										}
										continue;
									}
									case 6u:
										num197 = ((int)num2 * -91768772) ^ -1955986607;
										continue;
									case 7u:
										attackResult.AddCastInfo2(current3, ResourceStrings.ResStrings[880].Split('#'), 0.12f, skill.AttackTime);
										num197 = ((int)num2 * -1060902050) ^ 0x13AEE57C;
										continue;
									case 9u:
										goto end_IL_421e;
									}
									goto IL_42a4;
									continue;
									end_IL_421e:
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
									IL_443b:
									int num206 = 801849000;
									while (true)
									{
										switch ((num2 = (uint)(num206 ^ 0x69C4C43D)) % 3)
										{
										case 2u:
											break;
										default:
											goto end_IL_4440;
										case 1u:
											goto IL_445e;
										case 0u:
											goto end_IL_4440;
										}
										goto IL_443b;
										IL_445e:
										enumerator.Dispose();
										num206 = ((int)num2 * -1615732164) ^ 0x94EB472;
										continue;
										end_IL_4440:
										break;
									}
									break;
								}
							}
						}
						goto IL_4476;
						IL_402c:
						int num207;
						if (!role2.BuiltInTalents[34])
						{
							num100 = 915098360;
							num207 = num100;
						}
						else
						{
							num100 = 547303599;
							num207 = num100;
						}
						continue;
						IL_342d:
						int num208;
						if (!role.BuiltInTalents[65])
						{
							num100 = 1162071882;
							num208 = num100;
						}
						else
						{
							num100 = 1162226511;
							num208 = num100;
						}
						continue;
						IL_2e1f:
						int num209;
						if (!role.BuiltInTalents[35])
						{
							num100 = 192511874;
							num209 = num100;
						}
						else
						{
							num100 = 323236378;
							num209 = num100;
						}
						continue;
						IL_3e92:
						int num210;
						if (!role.BuiltInTalents[33])
						{
							num100 = 736099238;
							num210 = num100;
						}
						else
						{
							num100 = 2146987745;
							num210 = num100;
						}
						continue;
						IL_2809:
						int num211;
						if (role.BuiltInTalents[66])
						{
							num100 = 1436776611;
							num211 = num100;
						}
						else
						{
							num100 = 1277469488;
							num211 = num100;
						}
						continue;
						IL_33d5:
						int num212;
						if (!role.BuiltInTalents[48])
						{
							num100 = 1749898228;
							num212 = num100;
						}
						else
						{
							num100 = 717352469;
							num212 = num100;
						}
						continue;
						IL_3e48:
						attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[873].Split('#'), 0.12f, skill.AttackTime);
						int num213;
						if (num54 != 1)
						{
							num100 = 1989469805;
							num213 = num100;
						}
						else
						{
							num100 = 882474298;
							num213 = num100;
						}
						continue;
						IL_24e8:
						int num214;
						if (role.BuiltInTalents[64])
						{
							num100 = 1464551315;
							num214 = num100;
						}
						else
						{
							num100 = 1301037022;
							num214 = num100;
						}
						continue;
						IL_2c5c:
						int num215;
						if (role.BuiltInTalents[37])
						{
							num100 = 1249445102;
							num215 = num100;
						}
						else
						{
							num100 = 325076387;
							num215 = num100;
						}
						continue;
						IL_3d2c:
						int num216;
						if (!role.BuiltInTalents[62])
						{
							num100 = 1686348218;
							num216 = num100;
						}
						else
						{
							num100 = 823127067;
							num216 = num100;
						}
						continue;
						IL_3362:
						int num217;
						if (!role.BuiltInTalents[57])
						{
							num100 = 2118373671;
							num217 = num100;
						}
						else
						{
							num100 = 267063132;
							num217 = num100;
						}
						continue;
						IL_2906:
						int num218;
						if (!role2.BuiltInTalents[46])
						{
							num100 = 1166093392;
							num218 = num100;
						}
						else
						{
							num100 = 314906145;
							num218 = num100;
						}
						continue;
						IL_3ce4:
						int num219;
						if (role.BuiltInTalents[36])
						{
							num100 = 1907795546;
							num219 = num100;
						}
						else
						{
							num100 = 751204886;
							num219 = num100;
						}
						continue;
						IL_26b6:
						int num220;
						if (!role.BuiltInTalents[42])
						{
							num100 = 1964602806;
							num220 = num100;
						}
						else
						{
							num100 = 1545556298;
							num220 = num100;
						}
						continue;
						IL_333f:
						int num221;
						if (role.BuiltInTalents[39])
						{
							num100 = 70148767;
							num221 = num100;
						}
						else
						{
							num100 = 1774599917;
							num221 = num100;
						}
						continue;
						IL_3c9d:
						int num222;
						if (!name.StartsWith(ResourceStrings.ResStrings[716]))
						{
							num100 = 288689466;
							num222 = num100;
						}
						else
						{
							num100 = 332236633;
							num222 = num100;
						}
						continue;
						IL_2bf2:
						int num223;
						if (type != 0)
						{
							num100 = 1608162573;
							num223 = num100;
						}
						else
						{
							num100 = 1364495115;
							num223 = num100;
						}
						continue;
						IL_279d:
						int num224;
						if (role.BuiltInTalents[44])
						{
							num100 = 969913662;
							num224 = num100;
						}
						else
						{
							num100 = 1511720347;
							num224 = num100;
						}
						continue;
						IL_3a5d:
						int num225;
						if (name3.StartsWith(ResourceStrings.ResStrings[724]))
						{
							num100 = 614730120;
							num225 = num100;
						}
						else
						{
							num100 = 1767353580;
							num225 = num100;
						}
						continue;
						IL_32fe:
						int num226;
						if (role.BuiltInTalents[45])
						{
							num100 = 740782700;
							num226 = num100;
						}
						else
						{
							num100 = 1357351681;
							num226 = num100;
						}
						continue;
						IL_28e5:
						int num227;
						if (num58 < 1.0)
						{
							num100 = 1021524712;
							num227 = num100;
						}
						else
						{
							num100 = 1511720347;
							num227 = num100;
						}
						continue;
						IL_3904:
						int num228;
						if (!role.BuiltInTalents[69])
						{
							num100 = 1029462614;
							num228 = num100;
						}
						else
						{
							num100 = 1244116414;
							num228 = num100;
						}
						continue;
						IL_2b45:
						if (bf.GetTeamCount(sourceSprite.Team) > 1)
						{
							num100 = ((int)num2 * -1821987797) ^ 0x541104D;
							continue;
						}
						goto IL_4476;
						IL_30ff:
						int num229;
						if (!role2.BuiltInTalents[32])
						{
							num100 = 532390500;
							num229 = num100;
						}
						else
						{
							num100 = 1146717925;
							num229 = num100;
						}
						continue;
						IL_38b2:
						int num230;
						if (!role.BuiltInTalents[47])
						{
							num100 = 735912738;
							num230 = num100;
						}
						else
						{
							num100 = 965783100;
							num230 = num100;
						}
						continue;
						IL_2442:
						int num231;
						if (!role2.BuiltInTalents[40])
						{
							num100 = 1031342655;
							num231 = num100;
						}
						else
						{
							num100 = 2128307975;
							num231 = num100;
						}
						continue;
						IL_4476:
						if (role.BuiltInTalents[70])
						{
							goto IL_4488;
						}
						goto IL_54f2;
						IL_3751:
						int num232;
						if (role.BuiltInTalents[61])
						{
							num100 = 581453670;
							num232 = num100;
						}
						else
						{
							num100 = 318801794;
							num232 = num100;
						}
						continue;
						IL_30e9:
						if (num113 == 0f)
						{
							num100 = 1303569784;
							continue;
						}
						goto IL_4476;
						IL_54f2:
						int num233;
						int num234;
						if (role.BuiltInTalents[71])
						{
							num233 = 2075937006;
							num234 = num233;
						}
						else
						{
							num233 = 2003403157;
							num234 = num233;
						}
						goto IL_448d;
						IL_3652:
						int num235;
						if (role.BuiltInTalents[60])
						{
							num100 = 748019834;
							num235 = num100;
						}
						else
						{
							num100 = 276768544;
							num235 = num100;
						}
						continue;
						IL_3012:
						int num236;
						if (role.BuiltInTalents[40])
						{
							num100 = 1959090088;
							num236 = num100;
						}
						else
						{
							num100 = 1076025732;
							num236 = num100;
						}
						continue;
						IL_253c:
						int num237;
						if (role.BuiltInTalents[63])
						{
							num100 = 1921423103;
							num237 = num100;
						}
						else
						{
							num100 = 19283519;
							num237 = num100;
						}
						continue;
						IL_35bf:
						int num238;
						if (!role.BuiltInTalents[59])
						{
							num100 = 771020803;
							num238 = num100;
						}
						else
						{
							num100 = 559055725;
							num238 = num100;
						}
						continue;
						IL_28c4:
						int num239;
						if (num110 <= 0.9)
						{
							num100 = 208325168;
							num239 = num100;
						}
						else
						{
							num100 = 1083622322;
							num239 = num100;
						}
						continue;
						IL_2fce:
						int num240;
						if (!role.BuiltInTalents[38])
						{
							num100 = 1014257104;
							num240 = num100;
						}
						else
						{
							num100 = 972240128;
							num240 = num100;
						}
						continue;
						IL_359c:
						int num241;
						if (role2.BuiltInTalents[40])
						{
							num100 = 627881889;
							num241 = num100;
						}
						else
						{
							num100 = 816490990;
							num241 = num100;
						}
						continue;
						IL_448d:
						while (true)
						{
							switch ((num2 = (uint)(num233 ^ 0x69C4C43D)) % 89)
							{
							case 80u:
								break;
							case 82u:
								num58 += num264;
								num48 *= Tools.GetRandom(1.0, 1.0 + num264);
								attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[887].Split('#'), 0.12f, skill.AttackTime);
								num233 = ((int)num2 * -983774471) ^ 0x75F0DA6B;
								continue;
							case 81u:
								goto IL_4671;
							case 76u:
								num6 *= 1.05;
								num233 = ((int)num2 * -803745063) ^ -1509446414;
								continue;
							case 36u:
								goto IL_46b5;
							case 33u:
								goto IL_46db;
							case 1u:
								num6 *= 1.4;
								num5 *= 1.4;
								num233 = 823926133;
								continue;
							case 67u:
								num6 *= 1.4;
								num233 = (int)(num2 * 1840927457) ^ -1482457358;
								continue;
							case 47u:
								num5 *= 1.08;
								num233 = ((int)num2 * -948929771) ^ -894017408;
								continue;
							case 24u:
								num5 *= 1.1;
								num233 = ((int)num2 * -10655112) ^ 0x4B425576;
								continue;
							case 13u:
								num6 *= 1.8;
								num233 = ((int)num2 * -1008455837) ^ 0x5C371129;
								continue;
							case 18u:
							{
								num248 = 0.8 - 0.005 * (double)role.Level;
								int num276;
								int num277;
								if (num248 >= 0.5)
								{
									num276 = 2025365797;
									num277 = num276;
								}
								else
								{
									num276 = 298645234;
									num277 = num276;
								}
								num233 = num276 ^ (int)(num2 * 1237495505);
								continue;
							}
							case 64u:
								num35 *= 2.0;
								num233 = ((int)num2 * -1089064721) ^ 0x5F108922;
								continue;
							case 30u:
								goto IL_480a;
							case 9u:
								goto IL_482d;
							case 34u:
							{
								int num262;
								int num263;
								if (num35 < 1.0)
								{
									num262 = 1443590164;
									num263 = num262;
								}
								else
								{
									num262 = 1230745319;
									num263 = num262;
								}
								num233 = num262 ^ (int)(num2 * 985326754);
								continue;
							}
							case 54u:
								attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[886].Split('#'), 0.2f, skill.AttackTime);
								num58 += 0.2;
								num233 = (int)((num2 * 1191246890) ^ 0x273BF141);
								continue;
							case 79u:
							{
								int num252;
								int num253;
								if (!Tools.ProbabilityTest(0.3))
								{
									num252 = -1142631646;
									num253 = num252;
								}
								else
								{
									num252 = -110570908;
									num253 = num252;
								}
								num233 = num252 ^ (int)(num2 * 1418431094);
								continue;
							}
							case 46u:
								num249 = (double)role.Level / ((double)role.Level * 2.5 + 60.0);
								num233 = (int)((num2 * 1196304247) ^ 0x648D6415);
								continue;
							case 14u:
								num6 *= num269;
								num233 = (int)(num2 * 242785318) ^ -676491398;
								continue;
							case 35u:
							{
								int num278;
								int num279;
								if (!role.BuiltInTalents[133])
								{
									num278 = -1631255812;
									num279 = num278;
								}
								else
								{
									num278 = -1597558966;
									num279 = num278;
								}
								num233 = num278 ^ ((int)num2 * -718438887);
								continue;
							}
							case 2u:
								attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[882].Split('#'), 0.2f, skill.AttackTime);
								num233 = (int)((num2 * 330621374) ^ 0x4DF15CFC);
								continue;
							case 50u:
								num35 = attackFormula.defence;
								list = new List<Buff>();
								num233 = (int)((num2 * 1462220852) ^ 0x19022C02);
								continue;
							case 69u:
								attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[881].Split('#'), 0.3f, skill.AttackTime);
								num233 = 353420537;
								continue;
							case 31u:
							{
								int num267;
								int num268;
								if (role.BuiltInTalents[153])
								{
									num267 = -1887914384;
									num268 = num267;
								}
								else
								{
									num267 = -992001162;
									num268 = num267;
								}
								num233 = num267 ^ ((int)num2 * -1209641783);
								continue;
							}
							case 10u:
								attackResult.AddCastInfo2(targetSprite, ResourceStrings.ResStrings[891].Split('#'), 0.2f, skill.AttackTime);
								num35 += 250.0;
								num233 = 2066763413;
								continue;
							case 42u:
								num269 = (double)role.Level / ((double)role.Level * 3.0 + 90.0) + 1.0;
								num5 *= num269;
								num233 = (int)((num2 * 1369908977) ^ 0x1A16A314);
								continue;
							case 49u:
							{
								int num258;
								int num259;
								if (Tools.ProbabilityTest(0.3))
								{
									num258 = 1790160715;
									num259 = num258;
								}
								else
								{
									num258 = 1196093161;
									num259 = num258;
								}
								num233 = num258 ^ ((int)num2 * -1618074211);
								continue;
							}
							case 84u:
								attackFormula.criticalHit = num58;
								attackFormula.defence = num35;
								num233 = ((int)num2 * -1737860602) ^ -1198476198;
								continue;
							case 16u:
								num6 *= 1.08;
								num233 = ((int)num2 * -1272390926) ^ -1775435515;
								continue;
							case 63u:
								num6 *= 0.95;
								num233 = ((int)num2 * -816864808) ^ 0x6671C237;
								continue;
							case 87u:
								num5 *= 1.8;
								num233 = (int)(num2 * 621296834) ^ -1538483459;
								continue;
							case 73u:
								num5 *= 1.4;
								attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[885].Split('#'), 0.15f, skill.AttackTime);
								num233 = ((int)num2 * -376936618) ^ -274720943;
								continue;
							case 22u:
							{
								int num246;
								int num247;
								if (targetSprite.HasBuff(ResourceStrings.ResStrings[519]))
								{
									num246 = 1137632890;
									num247 = num246;
								}
								else
								{
									num246 = 1444404846;
									num247 = num246;
								}
								num233 = num246 ^ ((int)num2 * -1148298488);
								continue;
							}
							case 59u:
								goto IL_4c15;
							case 40u:
								attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[890].Split('#'), 0.2f, skill.AttackTime);
								num233 = (int)((num2 * 2027805226) ^ 0x2785BFC);
								continue;
							case 60u:
								num6 *= 1.05;
								num233 = (int)(num2 * 1050007454) ^ -456859576;
								continue;
							case 68u:
								LuaManager.Call(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(329331220u), sourceSprite, targetSprite, skill, bf, attackResult, attackFormula);
								num5 = attackFormula.attackLow;
								num233 = ((int)num2 * -1057885671) ^ -2057466263;
								continue;
							case 55u:
								num6 *= 1.1;
								num233 = ((int)num2 * -348226784) ^ -2039116822;
								continue;
							case 65u:
								goto IL_4d07;
							case 44u:
								goto IL_4d2a;
							case 51u:
								num35 -= 70.0;
								num233 = ((int)num2 * -1002249211) ^ 0x7DBD906D;
								continue;
							case 61u:
								num264 = (double)role.Level / ((double)role.Level * 3.0 + 90.0);
								num233 = ((int)num2 * -737950995) ^ -538344472;
								continue;
							case 62u:
							{
								int num281;
								int num282;
								if (!(name3 == ResourceStrings.ResStrings[729]))
								{
									num281 = -1242274367;
									num282 = num281;
								}
								else
								{
									num281 = -1964752918;
									num282 = num281;
								}
								num233 = num281 ^ (int)(num2 * 2118972530);
								continue;
							}
							case 32u:
								num6 *= 1.2;
								num233 = (int)((num2 * 1991502661) ^ 0x7A1E7B0E);
								continue;
							case 53u:
							{
								double num280 = num5;
								num5 = num6;
								num6 = num280;
								num233 = (int)(num2 * 2101587473) ^ -729414453;
								continue;
							}
							case 19u:
								goto IL_4e17;
							case 3u:
								num6 *= 1.1;
								num233 = (int)(num2 * 174742765) ^ -536575310;
								continue;
							case 88u:
								goto IL_4e5b;
							case 28u:
								num35 += 30.0;
								num233 = (int)((num2 * 704753286) ^ 0x61B4DB12);
								continue;
							case 52u:
								num35 *= num248;
								attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[889].Split('#'), 0.12f, skill.AttackTime);
								num233 = 2030434408;
								continue;
							case 25u:
								goto IL_4ee1;
							case 15u:
								num6 = attackFormula.attackUp;
								num233 = ((int)num2 * -1706002954) ^ 0x22303201;
								continue;
							case 71u:
								goto IL_4f1f;
							case 23u:
								goto IL_4f42;
							case 86u:
							{
								int num274;
								int num275;
								if (!name.Contains(ResourceStrings.ResStrings[693]))
								{
									num274 = -2096935657;
									num275 = num274;
								}
								else
								{
									num274 = -1693890916;
									num275 = num274;
								}
								num233 = num274 ^ (int)(num2 * 1919150100);
								continue;
							}
							case 66u:
							{
								int num272;
								int num273;
								if (name2 == ResourceStrings.ResStrings[729])
								{
									num272 = -360062186;
									num273 = num272;
								}
								else
								{
									num272 = -1305545067;
									num273 = num272;
								}
								num233 = num272 ^ (int)(num2 * 1444641009);
								continue;
							}
							case 58u:
								goto IL_4fcf;
							case 29u:
							{
								int num270;
								int num271;
								if (name2 == ResourceStrings.ResStrings[730])
								{
									num270 = -1205926201;
									num271 = num270;
								}
								else
								{
									num270 = -356195780;
									num271 = num270;
								}
								num233 = num270 ^ ((int)num2 * -2073747117);
								continue;
							}
							case 56u:
								attackFormula.attackLow = num5;
								attackFormula.attackUp = num6;
								num233 = 1179039075;
								continue;
							case 21u:
								num5 *= 1.05;
								num58 -= 0.02;
								num233 = ((int)num2 * -1879756060) ^ 0x2D94FFF;
								continue;
							case 4u:
								num58 += 0.3;
								num233 = 660171364;
								continue;
							case 39u:
								num5 *= 1.2;
								num58 += 0.2;
								attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[883].Split('#'), 0.2f, skill.AttackTime);
								num233 = (int)((num2 * 119256543) ^ 0x596FD335);
								continue;
							case 85u:
							{
								num6 *= 0.9;
								num5 *= 1.2;
								int num265;
								int num266;
								if (num5 <= num6)
								{
									num265 = 1446435579;
									num266 = num265;
								}
								else
								{
									num265 = 2014307725;
									num266 = num265;
								}
								num233 = num265 ^ (int)(num2 * 1856013720);
								continue;
							}
							case 5u:
								num58 = attackFormula.criticalHit;
								num233 = (int)((num2 * 433466446) ^ 0x6D2BC5B);
								continue;
							case 70u:
							{
								int num260;
								int num261;
								if (name3 == ResourceStrings.ResStrings[730])
								{
									num260 = -259233651;
									num261 = num260;
								}
								else
								{
									num260 = -842037282;
									num261 = num260;
								}
								num233 = num260 ^ ((int)num2 * -244933240);
								continue;
							}
							case 17u:
								num6 *= 1.06;
								num233 = ((int)num2 * -548816580) ^ 0x696236EA;
								continue;
							case 37u:
								goto IL_5198;
							case 77u:
								goto IL_51bb;
							case 72u:
							{
								int num256;
								int num257;
								if (Tools.ProbabilityTest(0.3))
								{
									num256 = -1744477229;
									num257 = num256;
								}
								else
								{
									num256 = -818740915;
									num257 = num256;
								}
								num233 = num256 ^ (int)(num2 * 644618662);
								continue;
							}
							case 57u:
							{
								int num254;
								int num255;
								if (name3 == ResourceStrings.ResStrings[642])
								{
									num254 = -1696212907;
									num255 = num254;
								}
								else
								{
									num254 = -1491993318;
									num255 = num254;
								}
								num233 = num254 ^ (int)(num2 * 322157536);
								continue;
							}
							case 11u:
								goto IL_5249;
							case 26u:
								num58 += 0.05;
								num233 = ((int)num2 * -1494639915) ^ -828922547;
								continue;
							case 43u:
							{
								int num250;
								int num251;
								if (name.StartsWith(ResourceStrings.ResStrings[727]))
								{
									num250 = -363964444;
									num251 = num250;
								}
								else
								{
									num250 = -1027324539;
									num251 = num250;
								}
								num233 = num250 ^ ((int)num2 * -370133116);
								continue;
							}
							case 75u:
								num58 -= num249;
								attackResult.AddCastInfo2(targetSprite, ResourceStrings.ResStrings[888].Split('#'), 0.12f, skill.AttackTime);
								num233 = ((int)num2 * -1648619074) ^ -1010151505;
								continue;
							case 20u:
								goto IL_530d;
							case 7u:
								num35 = 1.0;
								num233 = (int)((num2 * 164753517) ^ 0x271E6D72);
								continue;
							case 6u:
								num248 = 0.5;
								num233 = ((int)num2 * -586380743) ^ -843122518;
								continue;
							case 41u:
								num5 *= 0.95;
								num233 = (int)(num2 * 420882550) ^ -1323139632;
								continue;
							case 12u:
								num5 *= 1.05;
								num233 = (int)((num2 * 1276309613) ^ 0x76FA93EB);
								continue;
							case 74u:
								goto IL_53ae;
							case 83u:
								num58 += 0.5;
								attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[884].Split('#'), 0.15f, skill.AttackTime);
								num233 = ((int)num2 * -1398693543) ^ 0x6A3CD93B;
								continue;
							case 45u:
								goto IL_5423;
							case 78u:
								num5 *= 1.06;
								num233 = (int)(num2 * 1797541722) ^ -710940384;
								continue;
							case 8u:
								num35 *= 0.9;
								num233 = ((int)num2 * -1253729156) ^ 0x70232A7E;
								continue;
							case 38u:
							{
								int num244;
								int num245;
								if (!(name2 == ResourceStrings.ResStrings[642]))
								{
									num244 = 807422817;
									num245 = num244;
								}
								else
								{
									num244 = 1774136225;
									num245 = num244;
								}
								num233 = num244 ^ ((int)num2 * -530292931);
								continue;
							}
							case 27u:
							{
								int num242;
								int num243;
								if (name == ResourceStrings.ResStrings[728])
								{
									num242 = 1634147472;
									num243 = num242;
								}
								else
								{
									num242 = 690860129;
									num243 = num242;
								}
								num233 = num242 ^ (int)(num2 * 585182468);
								continue;
							}
							case 0u:
								goto IL_54f2;
							default:
								goto IL_5515;
							}
							break;
							IL_5423:
							int num283;
							if (!role2.BuiltInTalents[81])
							{
								num233 = 240353652;
								num283 = num233;
							}
							else
							{
								num233 = 1314545516;
								num283 = num233;
							}
							continue;
							IL_4e17:
							int num284;
							if (!role.BuiltInTalents[82])
							{
								num233 = 1383577102;
								num284 = num233;
							}
							else
							{
								num233 = 1165070513;
								num284 = num233;
							}
							continue;
							IL_4f42:
							int num285;
							if (!role2.BuiltInTalents[75])
							{
								num233 = 2118248591;
								num285 = num233;
							}
							else
							{
								num233 = 281808469;
								num285 = num233;
							}
							continue;
							IL_53ae:
							int num286;
							if (!role2.BuiltInTalents[83])
							{
								num233 = 2066763413;
								num286 = num233;
							}
							else
							{
								num233 = 335376838;
								num286 = num233;
							}
							continue;
							IL_4c15:
							int num287;
							if (!role.BuiltInTalents[52])
							{
								num233 = 709834758;
								num287 = num233;
							}
							else
							{
								num233 = 1425544411;
								num287 = num233;
							}
							continue;
							IL_480a:
							int num288;
							if (!role.BuiltInTalents[78])
							{
								num233 = 1302340691;
								num288 = num233;
							}
							else
							{
								num233 = 6899050;
								num288 = num233;
							}
							continue;
							IL_530d:
							int num289;
							if (!role2.BuiltInTalents[77])
							{
								num233 = 558333296;
								num289 = num233;
							}
							else
							{
								num233 = 1099261448;
								num289 = num233;
							}
							continue;
							IL_4f1f:
							int num290;
							if (role.BuiltInTalents[80])
							{
								num233 = 1001665551;
								num290 = num233;
							}
							else
							{
								num233 = 1345889346;
								num290 = num233;
							}
							continue;
							IL_4d2a:
							int num291;
							if (!role.BuiltInTalents[83])
							{
								num233 = 1699954534;
								num291 = num233;
							}
							else
							{
								num233 = 1802722427;
								num291 = num233;
							}
							continue;
							IL_5249:
							int num292;
							if (!role.BuiltInTalents[79])
							{
								num233 = 1468780123;
								num292 = num233;
							}
							else
							{
								num233 = 2086396291;
								num292 = num233;
							}
							continue;
							IL_46b5:
							int num293;
							if (role.BuiltInTalents[134])
							{
								num233 = 1212623295;
								num293 = num233;
							}
							else
							{
								num233 = 947963663;
								num293 = num233;
							}
							continue;
							IL_4ee1:
							int num294;
							if (role.BuiltInTalents[73])
							{
								num233 = 297914940;
								num294 = num233;
							}
							else
							{
								num233 = 642610321;
								num294 = num233;
							}
							continue;
							IL_51bb:
							int num295;
							if (name.Contains(ResourceStrings.ResStrings[636]))
							{
								num233 = 266211084;
								num295 = num233;
							}
							else
							{
								num233 = 947963663;
								num295 = num233;
							}
							continue;
							IL_482d:
							int num296;
							if (!role.BuiltInTalents[13])
							{
								num233 = 1000056620;
								num296 = num233;
							}
							else
							{
								num233 = 1401946411;
								num296 = num233;
							}
							continue;
							IL_4d07:
							int num297;
							if (role.BuiltInTalents[51])
							{
								num233 = 1162443248;
								num297 = num233;
							}
							else
							{
								num233 = 1425716042;
								num297 = num233;
							}
							continue;
							IL_5198:
							int num298;
							if (role.BuiltInTalents[76])
							{
								num233 = 1693955336;
								num298 = num233;
							}
							else
							{
								num233 = 2030434408;
								num298 = num233;
							}
							continue;
							IL_4e5b:
							int num299;
							if (!role.BuiltInTalents[74])
							{
								num233 = 959319534;
								num299 = num233;
							}
							else
							{
								num233 = 287016485;
								num299 = num233;
							}
							continue;
							IL_4671:
							int num300;
							if (!role.BuiltInTalents[72])
							{
								num233 = 1827032315;
								num300 = num233;
							}
							else
							{
								num233 = 1755913282;
								num300 = num233;
							}
							continue;
							IL_4fcf:
							int num301;
							if (role.BuiltInTalents[77])
							{
								num233 = 44684666;
								num301 = num233;
							}
							else
							{
								num233 = 1810446431;
								num301 = num233;
							}
							continue;
							IL_46db:
							int num302;
							if (skill.Type != 5)
							{
								num233 = 1758293743;
								num302 = num233;
							}
							else
							{
								num233 = 131157612;
								num302 = num233;
							}
						}
						goto IL_4488;
						IL_4488:
						num233 = 1677100355;
						goto IL_448d;
						IL_3579:
						int num303;
						if (role.BuiltInTalents[67])
						{
							num100 = 1881439465;
							num303 = num100;
						}
						else
						{
							num100 = 173739086;
							num303 = num100;
						}
						continue;
						IL_2fab:
						int num304;
						if (role.BuiltInTalents[41])
						{
							num100 = 770937020;
							num304 = num100;
						}
						else
						{
							num100 = 1767353580;
							num304 = num100;
						}
						continue;
						IL_2b22:
						int num305;
						if (role2.BuiltInTalents[43])
						{
							num100 = 1611016577;
							num305 = num100;
						}
						else
						{
							num100 = 865669839;
							num305 = num100;
						}
						continue;
						IL_3556:
						int num306;
						if (!role2.BuiltInTalents[41])
						{
							num100 = 268659911;
							num306 = num100;
						}
						else
						{
							num100 = 1147884693;
							num306 = num100;
						}
						continue;
						IL_2745:
						int num307;
						if (role.BuiltInTalents[34])
						{
							num100 = 1432324016;
							num307 = num100;
						}
						else
						{
							num100 = 439080119;
							num307 = num100;
						}
						continue;
						IL_2eb5:
						int num308;
						if (num58 < 1.0)
						{
							num100 = 594795426;
							num308 = num100;
						}
						else
						{
							num100 = 835849218;
							num308 = num100;
						}
						continue;
						IL_34f9:
						int num309;
						if (num113 >= 0.1f)
						{
							num100 = 397655418;
							num309 = num100;
						}
						else
						{
							num100 = 1140749962;
							num309 = num100;
						}
						continue;
						IL_2647:
						int num310;
						if (!Tools.ProbabilityTest(num152))
						{
							num100 = 1608162573;
							num310 = num100;
						}
						else
						{
							num100 = 1690000399;
							num310 = num100;
						}
						continue;
						IL_2988:
						int num311;
						if (!(name3 == ResourceStrings.ResStrings[725]))
						{
							num100 = 835849218;
							num311 = num100;
						}
						else
						{
							num100 = 1206926972;
							num311 = num100;
						}
					}
					goto IL_1c79;
					IL_5515:
					enumerator2 = skill.Buffs.GetEnumerator();
					try
					{
						while (true)
						{
							IL_554f:
							int num316;
							int num317;
							if (enumerator2.MoveNext())
							{
								num316 = 1049269253;
								num317 = num316;
							}
							else
							{
								num316 = 1876097462;
								num317 = num316;
							}
							while (true)
							{
								switch ((num2 = (uint)(num316 ^ 0x69C4C43D)) % 5)
								{
								case 0u:
									num316 = 1049269253;
									continue;
								default:
									goto end_IL_5529;
								case 4u:
									break;
								case 2u:
									list.Add(current4);
									num316 = (int)((num2 * 664024632) ^ 0x33E9FF5E);
									continue;
								case 1u:
									current4 = enumerator2.Current;
									num316 = 882843036;
									continue;
								case 3u:
									goto end_IL_5529;
								}
								goto IL_554f;
								continue;
								end_IL_5529:
								break;
							}
							break;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							while (true)
							{
								IL_5598:
								int num318 = 423190263;
								while (true)
								{
									switch ((num2 = (uint)(num318 ^ 0x69C4C43D)) % 3)
									{
									case 0u:
										break;
									default:
										goto end_IL_559d;
									case 1u:
										goto IL_55bb;
									case 2u:
										goto end_IL_559d;
									}
									goto IL_5598;
									IL_55bb:
									enumerator2.Dispose();
									num318 = (int)(num2 * 821894350) ^ -74151604;
									continue;
									end_IL_559d:
									break;
								}
								break;
							}
						}
					}
					foreach (ItemInstance item in role.Equipment)
					{
						enumerator2 = item.Buffs.GetEnumerator();
						try
						{
							while (true)
							{
								IL_5635:
								int num319;
								int num320;
								if (enumerator2.MoveNext())
								{
									num319 = 2139124671;
									num320 = num319;
								}
								else
								{
									num319 = 1974427971;
									num320 = num319;
								}
								while (true)
								{
									switch ((num2 = (uint)(num319 ^ 0x69C4C43D)) % 5)
									{
									case 2u:
										num319 = 2139124671;
										continue;
									default:
										goto end_IL_55ff;
									case 3u:
										current5 = enumerator2.Current;
										num319 = 738685308;
										continue;
									case 4u:
										break;
									case 0u:
										list.Add(current5);
										num319 = ((int)num2 * -353083204) ^ -1886766069;
										continue;
									case 1u:
										goto end_IL_55ff;
									}
									goto IL_5635;
									continue;
									end_IL_55ff:
									break;
								}
								break;
							}
						}
						finally
						{
							if (enumerator2 != null)
							{
								while (true)
								{
									IL_566e:
									int num321 = 1505900170;
									while (true)
									{
										switch ((num2 = (uint)(num321 ^ 0x69C4C43D)) % 3)
										{
										case 0u:
											break;
										default:
											goto end_IL_5673;
										case 2u:
											goto IL_5691;
										case 1u:
											goto end_IL_5673;
										}
										goto IL_566e;
										IL_5691:
										enumerator2.Dispose();
										num321 = ((int)num2 * -1584838095) ^ 0x2538BDF0;
										continue;
										end_IL_5673:
										break;
									}
									break;
								}
							}
						}
					}
					using (List<Buff>.Enumerator enumerator4 = list.GetEnumerator())
					{
						while (true)
						{
							IL_5816:
							int num322;
							int num323;
							if (enumerator4.MoveNext())
							{
								num322 = 1037082961;
								num323 = num322;
							}
							else
							{
								num322 = 227955330;
								num323 = num322;
							}
							while (true)
							{
								switch ((num2 = (uint)(num322 ^ 0x69C4C43D)) % 18)
								{
								case 0u:
									num322 = 1037082961;
									continue;
								default:
									goto end_IL_56d8;
								case 17u:
								{
									int num327;
									if (Tools.ProbabilityTest(p))
									{
										num322 = 62502002;
										num327 = num322;
									}
									else
									{
										num322 = 2144995277;
										num327 = num322;
									}
									continue;
								}
								case 5u:
									attackResult.Buff.Add(current6);
									num322 = (int)(num2 * 1391238628) ^ -474579311;
									continue;
								case 13u:
									num322 = ((int)num2 * -226773717) ^ -16009482;
									continue;
								case 1u:
									num328 = 0.1;
									num322 = ((int)num2 * -1786841180) ^ 0x58F1BEC6;
									continue;
								case 9u:
									p = (double)current6.Property / 100.0;
									num322 = 1813816832;
									continue;
								case 2u:
									num322 = (int)(num2 * 1636655085) ^ -1808938215;
									continue;
								case 12u:
								{
									int num329;
									if (!Tools.ProbabilityTest(num328))
									{
										num322 = 2144995277;
										num329 = num322;
									}
									else
									{
										num322 = 716969135;
										num329 = num322;
									}
									continue;
								}
								case 3u:
									p = num111 / (double)(BattleField.ROLE_MAX_ATTRIBUTE[role] + 100);
									num322 = (int)((num2 * 777939650) ^ 0x1C8C8D96);
									continue;
								case 10u:
									break;
								case 4u:
									attackResult.Debuff.Add(current6);
									num322 = ((int)num2 * -976411584) ^ 0x2A2CF519;
									continue;
								case 11u:
									num322 = (int)((num2 * 518213186) ^ 0x344940D2);
									continue;
								case 14u:
									num328 = (double)current6.Property / 100.0;
									num322 = 718979003;
									continue;
								case 16u:
								{
									current6 = enumerator4.Current;
									int num332;
									if (!current6.IsDebuff)
									{
										num322 = 1050870249;
										num332 = num322;
									}
									else
									{
										num322 = 147489579;
										num332 = num322;
									}
									continue;
								}
								case 15u:
								{
									num328 = num111 * 0.9 / Math.Max(1.0, num112);
									int num330;
									int num331;
									if (num328 < 0.1)
									{
										num330 = -226025225;
										num331 = num330;
									}
									else
									{
										num330 = -1094238786;
										num331 = num330;
									}
									num322 = num330 ^ ((int)num2 * -396440965);
									continue;
								}
								case 6u:
								{
									int num325;
									int num326;
									if (current6.Property <= -1)
									{
										num325 = 1343368650;
										num326 = num325;
									}
									else
									{
										num325 = 2027507581;
										num326 = num325;
									}
									num322 = num325 ^ (int)(num2 * 1341937484);
									continue;
								}
								case 8u:
								{
									int num324;
									if (current6.Property <= -1)
									{
										num322 = 1486471724;
										num324 = num322;
									}
									else
									{
										num322 = 226557156;
										num324 = num322;
									}
									continue;
								}
								case 7u:
									goto end_IL_56d8;
								}
								goto IL_5816;
								continue;
								end_IL_56d8:
								break;
							}
							break;
						}
					}
					num5 += role.attackValue / 2.0;
					goto IL_595d;
					IL_595d:
					num338 = 1936797974;
					goto IL_5962;
					IL_7a66:
					enumerator2 = skill.Buffs.GetEnumerator();
					try
					{
						while (true)
						{
							IL_7ab0:
							int num343;
							int num344;
							if (!enumerator2.MoveNext())
							{
								num343 = 85253892;
								num344 = num343;
							}
							else
							{
								num343 = 469197483;
								num344 = num343;
							}
							while (true)
							{
								switch ((num2 = (uint)(num343 ^ 0x69C4C43D)) % 5)
								{
								case 3u:
									num343 = 469197483;
									continue;
								default:
									goto end_IL_7a7a;
								case 1u:
									current7 = enumerator2.Current;
									num343 = 69685918;
									continue;
								case 2u:
									break;
								case 4u:
									list2.Add(current7);
									num343 = ((int)num2 * -480826114) ^ -553719793;
									continue;
								case 0u:
									goto end_IL_7a7a;
								}
								goto IL_7ab0;
								continue;
								end_IL_7a7a:
								break;
							}
							break;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							while (true)
							{
								IL_7ae9:
								int num345 = 1394062188;
								while (true)
								{
									switch ((num2 = (uint)(num345 ^ 0x69C4C43D)) % 3)
									{
									case 2u:
										break;
									default:
										goto end_IL_7aee;
									case 1u:
										goto IL_7b0c;
									case 0u:
										goto end_IL_7aee;
									}
									goto IL_7ae9;
									IL_7b0c:
									enumerator2.Dispose();
									num345 = ((int)num2 * -255458680) ^ 0x551CF261;
									continue;
									end_IL_7aee:
									break;
								}
								break;
							}
						}
					}
					if (!skill.HitSelf)
					{
						foreach (ItemInstance item2 in role.Equipment)
						{
							enumerator2 = item2.Buffs.GetEnumerator();
							try
							{
								while (true)
								{
									IL_7b96:
									int num346;
									int num347;
									if (enumerator2.MoveNext())
									{
										num346 = 1832927556;
										num347 = num346;
									}
									else
									{
										num346 = 307717823;
										num347 = num346;
									}
									while (true)
									{
										switch ((num2 = (uint)(num346 ^ 0x69C4C43D)) % 4)
										{
										case 0u:
											num346 = 1832927556;
											continue;
										default:
											goto end_IL_7b5b;
										case 1u:
										{
											Buff current8 = enumerator2.Current;
											list2.Add(current8);
											num346 = 728650278;
											continue;
										}
										case 3u:
											break;
										case 2u:
											goto end_IL_7b5b;
										}
										goto IL_7b96;
										continue;
										end_IL_7b5b:
										break;
									}
									break;
								}
							}
							finally
							{
								if (enumerator2 != null)
								{
									while (true)
									{
										IL_7bb6:
										int num348 = 1595490154;
										while (true)
										{
											switch ((num2 = (uint)(num348 ^ 0x69C4C43D)) % 3)
											{
											case 2u:
												break;
											default:
												goto end_IL_7bbb;
											case 1u:
												goto IL_7bd9;
											case 0u:
												goto end_IL_7bbb;
											}
											goto IL_7bb6;
											IL_7bd9:
											enumerator2.Dispose();
											num348 = (int)((num2 * 35673090) ^ 0x7C6A2E94);
											continue;
											end_IL_7bbb:
											break;
										}
										break;
									}
								}
							}
						}
					}
					using (List<Buff>.Enumerator enumerator4 = list2.GetEnumerator())
					{
						while (true)
						{
							IL_7d41:
							int num349;
							int num350;
							if (enumerator4.MoveNext())
							{
								num349 = 687865822;
								num350 = num349;
							}
							else
							{
								num349 = 1791876207;
								num350 = num349;
							}
							while (true)
							{
								switch ((num2 = (uint)(num349 ^ 0x69C4C43D)) % 17)
								{
								case 0u:
									num349 = 687865822;
									continue;
								default:
									goto end_IL_7c20;
								case 7u:
								{
									int num357;
									if (!Tools.ProbabilityTest(p3))
									{
										num349 = 689307341;
										num357 = num349;
									}
									else
									{
										num349 = 297648204;
										num357 = num349;
									}
									continue;
								}
								case 14u:
									p2 = current9.Property / 100;
									num349 = 1522621893;
									continue;
								case 3u:
								{
									int num355;
									int num356;
									if (!current9.IsDebuff)
									{
										num355 = -505089465;
										num356 = num355;
									}
									else
									{
										num355 = -1067907103;
										num356 = num355;
									}
									num349 = num355 ^ (int)(num2 * 1432856927);
									continue;
								}
								case 15u:
								{
									int num353;
									if (Tools.ProbabilityTest(p2))
									{
										num349 = 911239085;
										num353 = num349;
									}
									else
									{
										num349 = 689307341;
										num353 = num349;
									}
									continue;
								}
								case 9u:
									num349 = ((int)num2 * -1442066215) ^ -1302906012;
									continue;
								case 1u:
									attackResult.Buff.Add(current9);
									num349 = ((int)num2 * -1451130845) ^ -106895938;
									continue;
								case 6u:
									attackResult.Debuff.Add(current9);
									num349 = (int)(num2 * 612363696) ^ -1625735731;
									continue;
								case 10u:
									break;
								case 4u:
								{
									int num354;
									if (current9.Property != -1)
									{
										num349 = 755243347;
										num354 = num349;
									}
									else
									{
										num349 = 949531534;
										num354 = num349;
									}
									continue;
								}
								case 5u:
									num349 = (int)((num2 * 1083936557) ^ 0x1F3F30BD);
									continue;
								case 12u:
									p3 = (double)role.AttributesFinal[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1412133437u)] / (double)(BattleField.ROLE_MAX_ATTRIBUTE[role] + 100);
									num349 = (int)((num2 * 1841718625) ^ 0x11CE1AB4);
									continue;
								case 13u:
									p3 = current9.Property / 100;
									num349 = 441532462;
									continue;
								case 2u:
									current9 = enumerator4.Current;
									num349 = 886292292;
									continue;
								case 8u:
									p2 = (double)role.AttributesFinal[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(788062007u)] * 0.9 / Math.Max(1.0, role2.AttributesFinal[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(912726802u)]);
									num349 = (int)((num2 * 1704218184) ^ 0x7759EBED);
									continue;
								case 11u:
								{
									int num351;
									int num352;
									if (current9.Property == -1)
									{
										num351 = -54433977;
										num352 = num351;
									}
									else
									{
										num351 = -966719185;
										num352 = num351;
									}
									num349 = num351 ^ ((int)num2 * -1982288951);
									continue;
								}
								case 16u:
									goto end_IL_7c20;
								}
								goto IL_7d41;
								continue;
								end_IL_7c20:
								break;
							}
							break;
						}
					}
					if (name == ResourceStrings.ResStrings[614])
					{
						goto IL_7ea0;
					}
					goto IL_84f8;
					IL_5962:
					while (true)
					{
						switch ((num2 = (uint)(num338 ^ 0x69C4C43D)) % 206)
						{
						case 2u:
							break;
						case 94u:
							goto IL_5cb3;
						case 163u:
							goto IL_5cf9;
						case 111u:
							buff13.LeftRound--;
							num338 = (int)((num2 * 410298778) ^ 0x15285668);
							continue;
						case 95u:
							num338 = ((int)num2 * -806907405) ^ 0x461104F9;
							continue;
						case 32u:
							num338 = (int)(num2 * 219422388) ^ -958756059;
							continue;
						case 99u:
							buff22 = targetSprite.GetBuff(ResourceStrings.ResStrings[554]);
							num338 = 1217779703;
							continue;
						case 57u:
							goto IL_5d85;
						case 203u:
							num6 *= num376;
							num338 = (int)(num2 * 2041377383) ^ -1538051677;
							continue;
						case 44u:
							num338 = ((int)num2 * -630424571) ^ -392567130;
							continue;
						case 56u:
							goto IL_5dcc;
						case 177u:
							num5 *= num387;
							num338 = ((int)num2 * -2122593407) ^ -534075624;
							continue;
						case 197u:
							goto IL_5e00;
						case 113u:
							attackResult.AddCastInfo2(targetSprite, ResourceStrings.ResStrings[895].Split('#'), 0.3f, skill.AttackTime);
							num338 = 1939588416;
							continue;
						case 52u:
							num361 = 0.7;
							num338 = ((int)num2 * -1740412878) ^ 0x736DB47A;
							continue;
						case 21u:
						{
							int num434;
							int num435;
							if (sourceSprite.GetBuff(ResourceStrings.ResStrings[549]) == null)
							{
								num434 = 870063935;
								num435 = num434;
							}
							else
							{
								num434 = 1008877124;
								num435 = num434;
							}
							num338 = num434 ^ ((int)num2 * -1628185896);
							continue;
						}
						case 91u:
						{
							int num421;
							int num422;
							if (role.HasEquipmentTalent(ResourceStrings.ResStrings[320]))
							{
								num421 = 902218315;
								num422 = num421;
							}
							else
							{
								num421 = 936641566;
								num422 = num421;
							}
							num338 = num421 ^ (int)(num2 * 107003117);
							continue;
						}
						case 92u:
						{
							int num415;
							int num416;
							if (buff16 == null)
							{
								num415 = -1980685640;
								num416 = num415;
							}
							else
							{
								num415 = -1249630924;
								num416 = num415;
							}
							num338 = num415 ^ ((int)num2 * -4346144);
							continue;
						}
						case 60u:
							num5 *= num386;
							num6 *= num386;
							num338 = (int)(num2 * 1257598617) ^ -2080856716;
							continue;
						case 171u:
							attackResult.Hp = (int)((double)attackResult.Hp * 0.95);
							num338 = (int)(num2 * 1670183941) ^ -721433807;
							continue;
						case 173u:
						{
							int num367;
							int num368;
							if (attackResult.Hp <= 500)
							{
								num367 = -1225280435;
								num368 = num367;
							}
							else
							{
								num367 = -924661874;
								num368 = num367;
							}
							num338 = num367 ^ ((int)num2 * -194806824);
							continue;
						}
						case 66u:
							attackResult.Hp = 200;
							num338 = ((int)num2 * -1299939107) ^ -1091624940;
							continue;
						case 83u:
						{
							int num426;
							int num427;
							if (!role.HasEquipmentTalent(ResourceStrings.ResStrings[322]))
							{
								num426 = 813183843;
								num427 = num426;
							}
							else
							{
								num426 = 400293340;
								num427 = num426;
							}
							num338 = num426 ^ ((int)num2 * -1600058548);
							continue;
						}
						case 194u:
						{
							int num419;
							int num420;
							if (targetSprite.GetBuff(ResourceStrings.ResStrings[540]) == null)
							{
								num419 = 64805058;
								num420 = num419;
							}
							else
							{
								num419 = 1043242407;
								num420 = num419;
							}
							num338 = num419 ^ (int)(num2 * 1847565689);
							continue;
						}
						case 84u:
						{
							attackResult.Debuff.Clear();
							int num404;
							int num405;
							if (Tools.ProbabilityTest(0.499))
							{
								num404 = -115861540;
								num405 = num404;
							}
							else
							{
								num404 = -937183302;
								num405 = num404;
							}
							num338 = num404 ^ (int)(num2 * 840837461);
							continue;
						}
						case 106u:
							attackResult.Hp = 500;
							num338 = (int)((num2 * 1872573860) ^ 0x6F5E1C15);
							continue;
						case 160u:
							num5 *= 2.0;
							num6 *= 2.0;
							num338 = (int)((num2 * 2062643288) ^ 0x4E1187BC);
							continue;
						case 73u:
							goto IL_607c;
						case 146u:
							num374 = 1.0 + Math.Min(buff23.Level, 10.0) / 10.0 + Math.Min(buff23.Level, 30.0) * 0.003;
							num338 = ((int)num2 * -1400989256) ^ 0x1A81F8D0;
							continue;
						case 188u:
						{
							int num384;
							int num385;
							if (role2.BuiltInTalents[84])
							{
								num384 = 379661605;
								num385 = num384;
							}
							else
							{
								num384 = 170810438;
								num385 = num384;
							}
							num338 = num384 ^ ((int)num2 * -1957594843);
							continue;
						}
						case 157u:
							attackResult.Hp = Math.Max(attackResult.Hp, (int)((float)targetSprite.Hp * 0.25f));
							num338 = (int)((num2 * 51686650) ^ 0x3F187198);
							continue;
						case 51u:
							LuaManager.Call(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3500454747u), sourceSprite, targetSprite, skill, bf, attackResult);
							num338 = ((int)num2 * -1963221811) ^ 0x86AD25;
							continue;
						case 61u:
						{
							int num438;
							int num439;
							if (!Tools.ProbabilityTest(0.5))
							{
								num438 = -245754882;
								num439 = num438;
							}
							else
							{
								num438 = -1408719479;
								num439 = num438;
							}
							num338 = num438 ^ ((int)num2 * -174067136);
							continue;
						}
						case 116u:
							num361 = 0.92;
							num338 = ((int)num2 * -1136976744) ^ -1757597118;
							continue;
						case 93u:
							goto IL_61db;
						case 105u:
							goto IL_61f5;
						case 102u:
							attackResult.Hp = ((attackResult.Hp > 0) ? attackResult.Hp : 0);
							num338 = 1076101818;
							continue;
						case 5u:
							attackResult.Mp = 0;
							num338 = ((int)num2 * -888776045) ^ -610334657;
							continue;
						case 14u:
						{
							int num428;
							int num429;
							if (!Tools.ProbabilityTest(0.2))
							{
								num428 = -1047057317;
								num429 = num428;
							}
							else
							{
								num428 = -972297695;
								num429 = num428;
							}
							num338 = num428 ^ ((int)num2 * -1071604402);
							continue;
						}
						case 178u:
						{
							int num413;
							int num414;
							if (skill.IsAoyi)
							{
								num413 = -1709933563;
								num414 = num413;
							}
							else
							{
								num413 = -1521937075;
								num414 = num413;
							}
							num338 = num413 ^ ((int)num2 * -1863313730);
							continue;
						}
						case 195u:
						{
							int num408;
							int num409;
							if (internalSkillLevel2 < 127)
							{
								num408 = -1247481960;
								num409 = num408;
							}
							else
							{
								num408 = -391122681;
								num409 = num408;
							}
							num338 = num408 ^ ((int)num2 * -1851817813);
							continue;
						}
						case 166u:
							goto IL_62c8;
						case 155u:
							num6 = 1.0;
							num338 = ((int)num2 * -2074900702) ^ -1442336050;
							continue;
						case 63u:
						{
							int num400;
							int num401;
							if (role.HasEquipmentTalent(ResourceStrings.ResStrings[318]))
							{
								num400 = 1696138816;
								num401 = num400;
							}
							else
							{
								num400 = 1130740607;
								num401 = num400;
							}
							num338 = num400 ^ ((int)num2 * -374748600);
							continue;
						}
						case 64u:
						{
							int num396;
							int num397;
							if (attackResult.Hp > 0)
							{
								num396 = 1234503129;
								num397 = num396;
							}
							else
							{
								num396 = 117453576;
								num397 = num396;
							}
							num338 = num396 ^ ((int)num2 * -1011561977);
							continue;
						}
						case 65u:
							num35 = 1.0;
							num338 = ((int)num2 * -1571403807) ^ 0x6FC300DC;
							continue;
						case 144u:
							x = Math.Min(buff20.Level, 20.0);
							num338 = (int)(num2 * 266990214) ^ -1564584787;
							continue;
						case 141u:
							buff17 = targetSprite.GetBuff(ResourceStrings.ResStrings[553]);
							num338 = 1496491543;
							continue;
						case 38u:
							num5 *= 0.9;
							num338 = ((int)num2 * -501649129) ^ -133738291;
							continue;
						case 50u:
							num361 = 0.79;
							num338 = (int)((num2 * 582703127) ^ 0x6F68AE8C);
							continue;
						case 184u:
							goto IL_6401;
						case 77u:
							attackResult.Hp = 0;
							attackResult.Mp = 0;
							num338 = (int)((num2 * 370629682) ^ 0x43DE46D3);
							continue;
						case 79u:
							num369 = 0.79;
							num338 = (int)(num2 * 772583611) ^ -878101940;
							continue;
						case 40u:
							num387 = 1.0 - Math.Min(buff21.Level, 10.0) / 10.0 - Math.Min(buff21.Level, 30.0) * 0.003;
							num338 = (int)(num2 * 345069235) ^ -1319000024;
							continue;
						case 143u:
							buff20 = targetSprite.GetBuff(ResourceStrings.ResStrings[542]);
							num338 = 886272329;
							continue;
						case 45u:
							num369 = 0.6;
							num338 = (int)(num2 * 1407935968) ^ -756852211;
							continue;
						case 136u:
						{
							int num381;
							int num382;
							if (buff20 == null)
							{
								num381 = 1380772528;
								num382 = num381;
							}
							else
							{
								num381 = 760632853;
								num382 = num381;
							}
							num338 = num381 ^ ((int)num2 * -954733373);
							continue;
						}
						case 23u:
							buff16 = targetSprite.GetBuff(ResourceStrings.ResStrings[547]);
							buff19 = targetSprite.GetBuff(ResourceStrings.ResStrings[548]);
							num338 = 559418483;
							continue;
						case 200u:
							num5 *= role.powerup_xianshuValue;
							num6 *= role.powerup_xianshuValue;
							num338 = ((int)num2 * -1948218861) ^ 0x39921E93;
							continue;
						case 189u:
							attackResult.Hp = skill.attackResult_Hp;
							num338 = ((int)num2 * -1667800576) ^ 0x3FAC5635;
							continue;
						case 103u:
							num48 += 0.25;
							num338 = (int)((num2 * 669603811) ^ 0x4F6E11D3);
							continue;
						case 67u:
							num369 = 0.92;
							num338 = (int)(num2 * 1831149714) ^ -735613009;
							continue;
						case 133u:
							num35 += (double)(Math.Min(30, buff16.Level + 1) * 100) * (1.0 + (double)(Round - 1) * 0.02);
							num35 += (double)(Math.Min(100, buff16.Level + 1) * 2);
							num338 = ((int)num2 * -105766639) ^ 0x15F2CC21;
							continue;
						case 33u:
							num5 *= num374;
							num338 = ((int)num2 * -2049461080) ^ 0x250B5CF7;
							continue;
						case 138u:
							num375 = 1.0 + Math.Min(1.1, (double)(buff17.Level + 1) / 10.0 * 1.1);
							num5 *= num375;
							num338 = (int)(num2 * 1711643826) ^ -1701980719;
							continue;
						case 115u:
							goto IL_66b0;
						case 137u:
							num338 = (int)((num2 * 2009304213) ^ 0x47988D78);
							continue;
						case 25u:
						{
							int num365;
							int num366;
							if (num364 <= 1.0)
							{
								num365 = 1950657441;
								num366 = num365;
							}
							else
							{
								num365 = 1862155665;
								num366 = num365;
							}
							num338 = num365 ^ ((int)num2 * -1445833954);
							continue;
						}
						case 0u:
							goto IL_6707;
						case 11u:
							num58 *= 1.0 - Math.Min(0.9, role2.SubCriticalPercent + num112 / 1200.0);
							num338 = ((int)num2 * -1364688625) ^ -935992419;
							continue;
						case 201u:
							num6 += role.attackValue;
							num338 = ((int)num2 * -1630373698) ^ -343395924;
							continue;
						case 204u:
							goto IL_6797;
						case 159u:
							num5 *= num360;
							num6 *= num360;
							num338 = ((int)num2 * -1578467792) ^ -1032512854;
							continue;
						case 193u:
						{
							int num436;
							int num437;
							if (num5 < 1.0)
							{
								num436 = 237726026;
								num437 = num436;
							}
							else
							{
								num436 = 2143518980;
								num437 = num436;
							}
							num338 = num436 ^ ((int)num2 * -2032493848);
							continue;
						}
						case 153u:
							attackResult.AddAttackInfo2(targetSprite, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4234912124u), Color.white, skill.AttackTime);
							num338 = 831713786;
							continue;
						case 53u:
							goto IL_682f;
						case 152u:
							num5 *= role.powerup_jianfaValue;
							num6 *= role.powerup_jianfaValue;
							num338 = ((int)num2 * -1341217667) ^ -1945000753;
							continue;
						case 118u:
							attackResult.Hp = 0;
							num338 = ((int)num2 * -1291082268) ^ -293091118;
							continue;
						case 76u:
							goto IL_688a;
						case 175u:
							num6 = 1.0;
							num338 = ((int)num2 * -1177582054) ^ -750990696;
							continue;
						case 47u:
							internalSkillLevel2 = role2.GetInternalSkillLevel(ResourceStrings.ResStrings[731]);
							num338 = ((int)num2 * -1721710810) ^ -1219885522;
							continue;
						case 134u:
							goto IL_68eb;
						case 117u:
							flag7 = true;
							num338 = ((int)num2 * -1668321948) ^ 0x71D53624;
							continue;
						case 198u:
							flag6 = false;
							num338 = 1699320011;
							continue;
						case 4u:
						{
							int num432;
							int num433;
							if (attackResult.Hp > 200)
							{
								num432 = 1225161701;
								num433 = num432;
							}
							else
							{
								num432 = 303074060;
								num433 = num432;
							}
							num338 = num432 ^ ((int)num2 * -219079973);
							continue;
						}
						case 20u:
							goto IL_695b;
						case 8u:
						{
							int num430;
							int num431;
							if (Tools.ProbabilityTest(0.25))
							{
								num430 = 537988944;
								num431 = num430;
							}
							else
							{
								num430 = 1642015011;
								num431 = num430;
							}
							num338 = num430 ^ ((int)num2 * -470065072);
							continue;
						}
						case 126u:
							goto IL_69a0;
						case 165u:
							attackResult.Critical = flag7;
							num338 = (int)((num2 * 1055753624) ^ 0x2271387F);
							continue;
						case 36u:
							flag5 = true;
							num338 = ((int)num2 * -1631434551) ^ -1456078997;
							continue;
						case 101u:
						{
							num35 -= (double)(Math.Min(100, buff19.Level + 1) * 2);
							int num424;
							int num425;
							if (num35 >= 1.0)
							{
								num424 = -1095961072;
								num425 = num424;
							}
							else
							{
								num424 = -22149679;
								num425 = num424;
							}
							num338 = num424 ^ (int)(num2 * 760776621);
							continue;
						}
						case 150u:
							num361 = 0.85;
							num338 = (int)(num2 * 159076619) ^ -1458976997;
							continue;
						case 28u:
							num369 = 1.0;
							num338 = ((int)num2 * -115856144) ^ 0xD44EA70;
							continue;
						case 187u:
						{
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[900].Split('#'), 0.12f, skill.AttackTime);
							int num423 = role.AttributesFinal[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(664072894u)];
							attackResult.Hp += Tools.GetRandomInt(num423, num423 * 2);
							num338 = (int)((num2 * 1083304256) ^ 0xF3A58DD);
							continue;
						}
						case 109u:
							flag6 = false;
							num338 = 1159130275;
							continue;
						case 10u:
							goto IL_6af2;
						case 142u:
							goto IL_6b0a;
						case 9u:
							num5 = 1.0;
							num338 = ((int)num2 * -447494607) ^ -912621917;
							continue;
						case 125u:
							attackResult.Hp = (int)((double)attackResult.Hp * 1.1);
							num338 = (int)(num2 * 1318539581) ^ -827672096;
							continue;
						case 108u:
							num6 *= num374;
							num338 = (int)(num2 * 1666095289) ^ -1576701249;
							continue;
						case 80u:
							goto IL_6b86;
						case 68u:
							num410 = 1.0 - Math.Min(1.0, (double)(buff22.Level + 1) / 10.0);
							num338 = (int)((num2 * 63745387) ^ 0x3080404D);
							continue;
						case 89u:
							flag5 = false;
							num338 = ((int)num2 * -584540092) ^ 0x47E1799D;
							continue;
						case 43u:
							attackResult.Mp += attackResult.Hp - 500;
							num338 = (int)((num2 * 1933387987) ^ 0x35D0718);
							continue;
						case 59u:
						{
							int num417;
							int num418;
							if (!role.HasEquipmentTalent(ResourceStrings.ResStrings[319]))
							{
								num417 = 1024110476;
								num418 = num417;
							}
							else
							{
								num417 = 993327539;
								num418 = num417;
							}
							num338 = num417 ^ ((int)num2 * -66228057);
							continue;
						}
						case 148u:
							num5 *= role.powerup_daofaValue;
							num338 = (int)((num2 * 521326565) ^ 0x20691805);
							continue;
						case 119u:
							skill.attackResult_Hp = attackResult.Hp;
							skill.attackResult_Mp = attackResult.Mp;
							num338 = 2130796408;
							continue;
						case 114u:
							num364 = (double)attackResult.Hp / (double)role2.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1796919217u)];
							num338 = (int)((num2 * 2137025624) ^ 0x67729930);
							continue;
						case 39u:
							buff18 = sourceSprite.GetBuff(ResourceStrings.ResStrings[554]);
							num338 = 1479910661;
							continue;
						case 168u:
							goto IL_6cea;
						case 82u:
						{
							num5 *= num410;
							num6 *= num410;
							int num411;
							int num412;
							if (num5 >= 1.0)
							{
								num411 = -447446879;
								num412 = num411;
							}
							else
							{
								num411 = -167047396;
								num412 = num411;
							}
							num338 = num411 ^ ((int)num2 * -46621025);
							continue;
						}
						case 78u:
							attackResult.AddAttackInfo2(targetSprite, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(698180709u), Color.white, skill.AttackTime);
							num338 = ((int)num2 * -406824949) ^ -1552316596;
							continue;
						case 35u:
							num6 *= role.powerup_qimenValue;
							num338 = ((int)num2 * -519876429) ^ -1589436276;
							continue;
						case 132u:
						{
							int num406;
							int num407;
							if (buff17 != null)
							{
								num406 = -826246485;
								num407 = num406;
							}
							else
							{
								num406 = -1586233992;
								num407 = num406;
							}
							num338 = num406 ^ ((int)num2 * -2137811414);
							continue;
						}
						case 7u:
							goto IL_6dad;
						case 87u:
							goto IL_6ddc;
						case 3u:
							attackResult.Hp = (int)((double)attackResult.Hp * 1.1);
							num338 = ((int)num2 * -1102986719) ^ 0xD1293DD;
							continue;
						case 18u:
							attackResult.Hp = (int)((double)attackResult.Hp * 0.5 * num369);
							attackResult.AddCastInfo2(targetSprite, ResourceStrings.ResStrings[893].Split('#'), 0.2f, skill.AttackTime);
							num338 = 37030405;
							continue;
						case 98u:
							num338 = ((int)num2 * -99925098) ^ -56826014;
							continue;
						case 29u:
							num338 = ((int)num2 * -1629909030) ^ -1154256834;
							continue;
						case 164u:
							num6 *= num375;
							num338 = ((int)num2 * -1691548659) ^ 0x90B7D14;
							continue;
						case 54u:
							attackResult.AddCastInfo2(targetSprite, ResourceStrings.ResStrings[897].Split('#'), 1f, skill.AttackTime);
							num338 = ((int)num2 * -1557533283) ^ 0x3512B209;
							continue;
						case 158u:
						{
							int num402;
							int num403;
							if (internalSkillLevel >= 127)
							{
								num402 = -1405085573;
								num403 = num402;
							}
							else
							{
								num402 = -1793465304;
								num403 = num402;
							}
							num338 = num402 ^ (int)(num2 * 44014578);
							continue;
						}
						case 104u:
							goto IL_6f27;
						case 16u:
							goto IL_6f44;
						case 26u:
							num58 -= role2.SubCriticalPercent;
							num338 = 14120600;
							continue;
						case 167u:
							attackResult.Hp = (int)((double)attackResult.Hp * 0.5 * num361);
							attackResult.AddCastInfo2(targetSprite, ResourceStrings.ResStrings[894].Split('#'), 0.2f, skill.AttackTime);
							num338 = 61194686;
							continue;
						case 121u:
							attackResult.Mp = 0;
							num338 = ((int)num2 * -17664178) ^ 0x27397240;
							continue;
						case 127u:
							num338 = ((int)num2 * -657966771) ^ -330758674;
							continue;
						case 48u:
							attackResult.Hp = 0;
							num338 = (int)((num2 * 1506745753) ^ 0x67955FE);
							continue;
						case 147u:
							flag6 = false;
							num338 = ((int)num2 * -1152188114) ^ 0x3B5F8481;
							continue;
						case 191u:
						{
							int num398;
							int num399;
							if (type == 0)
							{
								num398 = 1653922573;
								num399 = num398;
							}
							else
							{
								num398 = 557647008;
								num399 = num398;
							}
							num338 = num398 ^ (int)(num2 * 455995878);
							continue;
						}
						case 202u:
						{
							int num394;
							int num395;
							if (!Tools.ProbabilityTest(0.5))
							{
								num394 = -1562284739;
								num395 = num394;
							}
							else
							{
								num394 = -1742663816;
								num395 = num394;
							}
							num338 = num394 ^ (int)(num2 * 877631963);
							continue;
						}
						case 129u:
							return attackResult;
						case 185u:
							goto IL_707f;
						case 37u:
							goto IL_7098;
						case 34u:
							num338 = ((int)num2 * -558209333) ^ -1940203350;
							continue;
						case 205u:
						{
							int num392;
							int num393;
							if (!Tools.ProbabilityTest(0.25))
							{
								num392 = 2142027897;
								num393 = num392;
							}
							else
							{
								num392 = 2026613249;
								num393 = num392;
							}
							num338 = num392 ^ (int)(num2 * 1707081241);
							continue;
						}
						case 46u:
							attackResult.Hp = (int)((double)attackResult.Hp * (1.0 - 0.4 * num364));
							num338 = 1385666612;
							continue;
						case 139u:
							buff13 = targetSprite.GetBuff(ResourceStrings.ResStrings[541]);
							num338 = 81149102;
							continue;
						case 149u:
							num35 -= (double)(Math.Min(30, buff19.Level + 1) * 100) * (1.0 + (double)(Round - 1) * 0.02);
							num338 = (int)(num2 * 1858526795) ^ -1810933203;
							continue;
						case 17u:
							goto IL_7193;
						case 199u:
							flag7 = Tools.ProbabilityTest(Math.Min(num58, Tools.GetRandom(0.95, 0.999)));
							num338 = ((int)num2 * -1977729388) ^ -1841301684;
							continue;
						case 161u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[892].Split('#'), 0.2f, skill.AttackTime);
							num338 = ((int)num2 * -1170191569) ^ 0x408002B0;
							continue;
						case 180u:
						{
							int num390;
							int num391;
							if (buff22 != null)
							{
								num390 = 1346544781;
								num391 = num390;
							}
							else
							{
								num390 = 1642769186;
								num391 = num390;
							}
							num338 = num390 ^ ((int)num2 * -771010219);
							continue;
						}
						case 112u:
							goto IL_724a;
						case 75u:
							goto IL_7263;
						case 97u:
							num338 = (int)(num2 * 1129901707) ^ -415172280;
							continue;
						case 186u:
							num361 = 0.6;
							num338 = ((int)num2 * -918110077) ^ -861239945;
							continue;
						case 123u:
							num369 = 0.74;
							num338 = ((int)num2 * -1696791235) ^ -1344785415;
							continue;
						case 181u:
							num338 = (int)(num2 * 619404701) ^ -14327673;
							continue;
						case 86u:
							goto IL_72ed;
						case 110u:
							goto IL_730e;
						case 130u:
							num338 = ((int)num2 * -384956618) ^ -42135855;
							continue;
						case 120u:
						{
							int num388;
							int num389;
							if (buff18 != null)
							{
								num388 = -1990053844;
								num389 = num388;
							}
							else
							{
								num388 = -792729838;
								num389 = num388;
							}
							num338 = num388 ^ (int)(num2 * 1409474686);
							continue;
						}
						case 74u:
							goto IL_735c;
						case 13u:
							attackResult.AddCastInfo2(targetSprite, ResourceStrings.ResStrings[898].Split('#'), 1f, skill.AttackTime);
							num338 = 219731646;
							continue;
						case 15u:
							num383 = defenceDescAttack(num35) + role2.EquipmentDefencePercent;
							num338 = 845097830;
							continue;
						case 96u:
							num6 *= num387;
							num338 = ((int)num2 * -772064537) ^ -176699440;
							continue;
						case 19u:
							num369 = 0.7;
							num338 = (int)((num2 * 1788885786) ^ 0x51573146);
							continue;
						case 124u:
							num5 *= role.powerup_qimenValue;
							num338 = (int)(num2 * 140708547) ^ -1780403988;
							continue;
						case 122u:
							num5 *= role.powerup_quanzhangValue;
							num6 *= role.powerup_quanzhangValue;
							num338 = (int)((num2 * 1163315204) ^ 0x20E8FEA);
							continue;
						case 31u:
							goto IL_745f;
						case 170u:
							num386 = Math.Pow(1.15, Math.Pow(x, 0.8));
							num338 = ((int)num2 * -1851729721) ^ 0x68927D7D;
							continue;
						case 190u:
							goto IL_74b3;
						case 41u:
							num338 = (int)(num2 * 60650538) ^ -1373901181;
							continue;
						case 49u:
							num6 *= 0.9;
							num338 = (int)(num2 * 2143013480) ^ -886359639;
							continue;
						case 176u:
							goto IL_750a;
						case 55u:
							attackResult.Hp = (int)(Tools.GetRandom(num5, num6) * ((!flag7) ? 1.0 : num48) * (1.0 - num383));
							num338 = 826202997;
							continue;
						case 90u:
						{
							int num379;
							int num380;
							if (sourceSprite.Team == 1)
							{
								num379 = -654650873;
								num380 = num379;
							}
							else
							{
								num379 = -1405852535;
								num380 = num379;
							}
							num338 = num379 ^ ((int)num2 * -1252749810);
							continue;
						}
						case 169u:
							num5 *= num376;
							num338 = (int)(num2 * 678104854) ^ -207347016;
							continue;
						case 70u:
							num5 *= 0.5;
							num338 = 677943541;
							continue;
						case 162u:
							flag6 = true;
							num338 = 1159130275;
							continue;
						case 154u:
							goto IL_75c1;
						case 12u:
							num338 = ((int)num2 * -942897269) ^ -1239719969;
							continue;
						case 81u:
							goto IL_75ed;
						case 1u:
							goto IL_75fe;
						case 62u:
						{
							int num377;
							int num378;
							if (type != 4)
							{
								num377 = -1603182412;
								num378 = num377;
							}
							else
							{
								num377 = -1566475286;
								num378 = num377;
							}
							num338 = num377 ^ (int)(num2 * 1486330208);
							continue;
						}
						case 71u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[899].Split('#'), 1f, skill.AttackTime);
							num338 = (int)(num2 * 865225459) ^ -1090567370;
							continue;
						case 172u:
							num361 = 0.74;
							num338 = ((int)num2 * -1061550122) ^ 0x6239FAC2;
							continue;
						case 192u:
							num6 *= role.powerup_daofaValue;
							num338 = (int)((num2 * 1754225945) ^ 0x751CCEF9);
							continue;
						case 182u:
							goto IL_76b8;
						case 183u:
							attackResult.Hp /= 4;
							num338 = ((int)num2 * -1661309368) ^ 0x6278C982;
							continue;
						case 22u:
							num364 = 1.0;
							num338 = (int)(num2 * 1749907283) ^ -1270598727;
							continue;
						case 196u:
							goto IL_7710;
						case 131u:
							num376 = 1.0 - Math.Min(1.1, (double)(buff18.Level + 1) / 10.0 * 1.1);
							num338 = (int)(num2 * 650276184) ^ -678576142;
							continue;
						case 140u:
							flag5 = true;
							num338 = (int)((num2 * 1373577330) ^ 0x38C2CE75);
							continue;
						case 30u:
						{
							int num372;
							int num373;
							if (sourceSprite.Team == targetSprite.Team)
							{
								num372 = 1911391822;
								num373 = num372;
							}
							else
							{
								num372 = 1491046344;
								num373 = num372;
							}
							num338 = num372 ^ ((int)num2 * -406718379);
							continue;
						}
						case 179u:
							goto IL_77b5;
						case 107u:
							attackResult.AddAttackInfo2(targetSprite, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(698180709u), Color.white, skill.AttackTime);
							num338 = (int)((num2 * 1200243140) ^ 0x65ACEFD5);
							continue;
						case 69u:
							attackResult.Debuff.Clear();
							num338 = (int)(num2 * 878996195) ^ -559462672;
							continue;
						case 85u:
							goto IL_7829;
						case 6u:
							attackResult.AddCastInfo2(targetSprite, ResourceStrings.ResStrings[896].Split('#'), 0.3f, skill.AttackTime);
							num338 = 79704670;
							continue;
						case 151u:
						{
							int num370;
							int num371;
							if (role.HasEquipmentTalent(ResourceStrings.ResStrings[321]))
							{
								num370 = -328349882;
								num371 = num370;
							}
							else
							{
								num370 = -1265863451;
								num371 = num370;
							}
							num338 = num370 ^ (int)(num2 * 1549328162);
							continue;
						}
						case 72u:
							num361 = 1.0;
							internalSkillLevel = role2.GetInternalSkillLevel(ResourceStrings.ResStrings[731]);
							num338 = ((int)num2 * -127125834) ^ 0x7F024A91;
							continue;
						case 128u:
							num360 = 1.0 + Math.Min(1.0, (double)(buff15.Level + 1) / 10.0);
							num338 = (int)((num2 * 363570834) ^ 0x3D4D7D28);
							continue;
						case 100u:
							num338 = ((int)num2 * -1017898265) ^ -398109247;
							continue;
						case 156u:
							num369 = 0.85;
							num338 = (int)((num2 * 1513283436) ^ 0x3B65942E);
							continue;
						case 24u:
						{
							attackResult.Mp = skill.attackResult_Mp;
							int num362;
							int num363;
							if (attackResult.Hp > 0)
							{
								num362 = -984794387;
								num363 = num362;
							}
							else
							{
								num362 = -1779411188;
								num363 = num362;
							}
							num338 = num362 ^ (int)(num2 * 1002662375);
							continue;
						}
						case 88u:
							num6 *= 0.5;
							num338 = ((int)num2 * -1593058277) ^ -1772971876;
							continue;
						case 174u:
							num58 = 0.0;
							num338 = (int)((num2 * 560893603) ^ 0x2E259D5);
							continue;
						case 42u:
							num48 += Math.Min(0.6, (double)(buff14.Level + 1) * 0.03);
							num338 = (int)(num2 * 532625299) ^ -691903368;
							continue;
						case 135u:
							num5 = 1.0;
							num338 = ((int)num2 * -1500259414) ^ -1865971915;
							continue;
						case 58u:
							list2 = new List<Buff>();
							num338 = (int)((num2 * 1649565432) ^ 0x5F812012);
							continue;
						case 27u:
						{
							int num358;
							int num359;
							if (buff13 != null)
							{
								num358 = 225953025;
								num359 = num358;
							}
							else
							{
								num358 = 690604358;
								num359 = num358;
							}
							num338 = num358 ^ ((int)num2 * -1495845627);
							continue;
						}
						default:
							goto IL_7a66;
						}
						break;
						IL_7829:
						int num440;
						if (!role2.BuiltInTalents[51])
						{
							num338 = 2103913967;
							num440 = num338;
						}
						else
						{
							num338 = 2142778118;
							num440 = num338;
						}
						continue;
						IL_6797:
						int num441;
						if (!role2.BuiltInTalents[50])
						{
							num338 = 1175225658;
							num441 = num338;
						}
						else
						{
							num338 = 1030130418;
							num441 = num338;
						}
						continue;
						IL_6af2:
						int num442;
						if (flag6)
						{
							num338 = 1510837206;
							num442 = num338;
						}
						else
						{
							num338 = 687880697;
							num442 = num338;
						}
						continue;
						IL_77b5:
						int num443;
						if (role.BuiltInTalents[53])
						{
							num338 = 967760093;
							num443 = num338;
						}
						else
						{
							num338 = 1036648093;
							num443 = num338;
						}
						continue;
						IL_7098:
						int num444;
						if (num58 < 0.0)
						{
							num338 = 533666385;
							num444 = num338;
						}
						else
						{
							num338 = 1068818193;
							num444 = num338;
						}
						continue;
						IL_607c:
						int num445;
						if (type == 2)
						{
							num338 = 1423582015;
							num445 = num338;
						}
						else
						{
							num338 = 1938883636;
							num445 = num338;
						}
						continue;
						IL_7710:
						int num446;
						if (num54 == 1)
						{
							num338 = 409035926;
							num446 = num338;
						}
						else
						{
							num338 = 1990316659;
							num446 = num338;
						}
						continue;
						IL_5dcc:
						int num447;
						if (internalSkillLevel2 < 63)
						{
							num338 = 754018014;
							num447 = num338;
						}
						else
						{
							num338 = 489287470;
							num447 = num338;
						}
						continue;
						IL_707f:
						int num448;
						if (type == 3)
						{
							num338 = 1983683907;
							num448 = num338;
						}
						else
						{
							num338 = 2119264107;
							num448 = num338;
						}
						continue;
						IL_76b8:
						int num449;
						if (type == 5)
						{
							num338 = 1384684038;
							num449 = num338;
						}
						else
						{
							num338 = 900444647;
							num449 = num338;
						}
						continue;
						IL_69a0:
						int num450;
						if (role.BuiltInTalents[49])
						{
							num338 = 717663917;
							num450 = num338;
						}
						else
						{
							num338 = 1647862819;
							num450 = num338;
						}
						continue;
						IL_6707:
						buff14 = sourceSprite.GetBuff(ResourceStrings.ResStrings[557]);
						int num451;
						if (buff14 != null)
						{
							num338 = 1841780075;
							num451 = num338;
						}
						else
						{
							num338 = 1034783258;
							num451 = num338;
						}
						continue;
						IL_75fe:
						int num452;
						if (buff19 == null)
						{
							num338 = 174426795;
							num452 = num338;
						}
						else
						{
							num338 = 300075224;
							num452 = num338;
						}
						continue;
						IL_6f44:
						int num453;
						if (type != 3)
						{
							num338 = 1256836347;
							num453 = num338;
						}
						else
						{
							num338 = 407815586;
							num453 = num338;
						}
						continue;
						IL_61f5:
						int num454;
						if (targetSprite.Team == sourceSprite.Team)
						{
							num338 = 224624793;
							num454 = num338;
						}
						else
						{
							num338 = 1555717097;
							num454 = num338;
						}
						continue;
						IL_75c1:
						int num455;
						if (internalSkillLevel < 3)
						{
							num338 = 1104605154;
							num455 = num338;
						}
						else
						{
							num338 = 1446496705;
							num455 = num338;
						}
						continue;
						IL_695b:
						int num456;
						if (!flag5)
						{
							num338 = 1261213771;
							num456 = num338;
						}
						else
						{
							num338 = 1010616915;
							num456 = num338;
						}
						continue;
						IL_6f27:
						int num457;
						if (attackResult.Hp <= 0)
						{
							num338 = 831713786;
							num457 = num338;
						}
						else
						{
							num338 = 1127956010;
							num457 = num338;
						}
						continue;
						IL_750a:
						int num458;
						if (type == 1)
						{
							num338 = 742610976;
							num458 = num338;
						}
						else
						{
							num338 = 339093863;
							num458 = num338;
						}
						continue;
						IL_5cf9:
						int num459;
						if (!role2.BuiltInTalents[85])
						{
							num338 = 61194686;
							num459 = num338;
						}
						else
						{
							num338 = 350259132;
							num459 = num338;
						}
						continue;
						IL_66b0:
						int num460;
						if (internalSkillLevel2 >= 31)
						{
							num338 = 1828931400;
							num460 = num338;
						}
						else
						{
							num338 = 1664560372;
							num460 = num338;
						}
						continue;
						IL_74b3:
						int num461;
						if (role2.BuiltInTalents[48])
						{
							num338 = 867515906;
							num461 = num338;
						}
						else
						{
							num338 = 79704670;
							num461 = num338;
						}
						continue;
						IL_6ddc:
						int num462;
						if (role2.BuiltInTalents[47])
						{
							num338 = 395046195;
							num462 = num338;
						}
						else
						{
							num338 = 1805333535;
							num462 = num338;
						}
						continue;
						IL_68eb:
						int num463;
						if (!role2.BuiltInTalents[52])
						{
							num338 = 2098488096;
							num463 = num338;
						}
						else
						{
							num338 = 1418252128;
							num463 = num338;
						}
						continue;
						IL_745f:
						int num464;
						if (num6 < 1.0)
						{
							num338 = 1083086652;
							num464 = num338;
						}
						else
						{
							num338 = 1022443138;
							num464 = num338;
						}
						continue;
						IL_5e00:
						int num465;
						if (type == 1)
						{
							num338 = 2029295261;
							num465 = num338;
						}
						else
						{
							num338 = 616720000;
							num465 = num338;
						}
						continue;
						IL_6dad:
						int num466;
						if (RuntimeData.Instance.GameMode == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1970665288u))
						{
							num338 = 1377807265;
							num466 = num338;
						}
						else
						{
							num338 = 1205023108;
							num466 = num338;
						}
						continue;
						IL_735c:
						buff15 = sourceSprite.GetBuff(ResourceStrings.ResStrings[553]);
						int num467;
						if (buff15 == null)
						{
							num338 = 636364826;
							num467 = num338;
						}
						else
						{
							num338 = 1145846635;
							num467 = num338;
						}
						continue;
						IL_61db:
						int num468;
						if (internalSkillLevel < 31)
						{
							num338 = 552954631;
							num468 = num338;
						}
						else
						{
							num338 = 2031718285;
							num468 = num338;
						}
						continue;
						IL_688a:
						int num469;
						if (type != 2)
						{
							num338 = 270186765;
							num469 = num338;
						}
						else
						{
							num338 = 2008868290;
							num469 = num338;
						}
						continue;
						IL_730e:
						int num470;
						if (internalSkillLevel < 15)
						{
							num338 = 1419820733;
							num470 = num338;
						}
						else
						{
							num338 = 1114003669;
							num470 = num338;
						}
						continue;
						IL_6cea:
						int num471;
						if (internalSkillLevel2 >= 3)
						{
							num338 = 492727306;
							num471 = num338;
						}
						else
						{
							num338 = 1141547249;
							num471 = num338;
						}
						continue;
						IL_6401:
						int num472;
						if (!role.BuiltInTalents[54])
						{
							num338 = 1876778217;
							num472 = num338;
						}
						else
						{
							num338 = 679325263;
							num472 = num338;
						}
						continue;
						IL_72ed:
						int num473;
						if (num6 < 1.0)
						{
							num338 = 243032498;
							num473 = num338;
						}
						else
						{
							num338 = 624351024;
							num473 = num338;
						}
						continue;
						IL_5cb3:
						buff23 = sourceSprite.GetBuff(ResourceStrings.ResStrings[524]);
						buff21 = sourceSprite.GetBuff(ResourceStrings.ResStrings[532]);
						int num474;
						if (buff23 != null)
						{
							num338 = 1660564969;
							num474 = num338;
						}
						else
						{
							num338 = 1501693197;
							num474 = num338;
						}
						continue;
						IL_6b86:
						int num475;
						if (internalSkillLevel < 7)
						{
							num338 = 462178807;
							num475 = num338;
						}
						else
						{
							num338 = 1147782791;
							num475 = num338;
						}
						continue;
						IL_7263:
						attackResult.Debuff.Clear();
						int num476;
						if (attackResult.Mp <= 0)
						{
							num338 = 1573518086;
							num476 = num338;
						}
						else
						{
							num338 = 168958616;
							num476 = num338;
						}
						continue;
						IL_682f:
						int num477;
						if (type == 0)
						{
							num338 = 1234646326;
							num477 = num338;
						}
						else
						{
							num338 = 880067175;
							num477 = num338;
						}
						continue;
						IL_5d85:
						int num478;
						if (internalSkillLevel2 < 15)
						{
							num338 = 1954319397;
							num478 = num338;
						}
						else
						{
							num338 = 57174460;
							num478 = num338;
						}
						continue;
						IL_724a:
						int num479;
						if (type == 5)
						{
							num338 = 629443399;
							num479 = num338;
						}
						else
						{
							num338 = 634369181;
							num479 = num338;
						}
						continue;
						IL_6b0a:
						int num480;
						if (internalSkillLevel2 >= 7)
						{
							num338 = 1815034395;
							num480 = num338;
						}
						else
						{
							num338 = 1094773887;
							num480 = num338;
						}
						continue;
						IL_62c8:
						int num481;
						if (buff21 == null)
						{
							num338 = 1920707328;
							num481 = num338;
						}
						else
						{
							num338 = 93556797;
							num481 = num338;
						}
						continue;
						IL_7193:
						int num482;
						if (internalSkillLevel >= 63)
						{
							num338 = 2082435473;
							num482 = num338;
						}
						else
						{
							num338 = 516914060;
							num482 = num338;
						}
					}
					goto IL_595d;
					IL_84f8:
					if (!(name == ResourceStrings.ResStrings[618]))
					{
						num488 = 897907507;
						num489 = num488;
					}
					else
					{
						num488 = 265248274;
						num489 = num488;
					}
					goto IL_7ea5;
					IL_7ea5:
					while (true)
					{
						switch ((num2 = (uint)(num488 ^ 0x69C4C43D)) % 65)
						{
						case 2u:
							break;
						case 41u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[904].Split('#'), 1f, skill.AttackTime);
							num488 = ((int)num2 * -1318724309) ^ 0x4DEF12C2;
							continue;
						case 25u:
							return attackResult;
						case 53u:
						{
							int num513;
							int num514;
							if (Tools.ProbabilityTest(0.1))
							{
								num513 = -1530062767;
								num514 = num513;
							}
							else
							{
								num513 = -585716947;
								num514 = num513;
							}
							num488 = num513 ^ (int)(num2 * 685911432);
							continue;
						}
						case 3u:
							attackResult.costBall = targetSprite.Balls;
							return attackResult;
						case 13u:
							num488 = (int)((num2 * 327038666) ^ 0x7C5361A1);
							continue;
						case 36u:
							buff26.Level = 3;
							buff26.Round = 1;
							buff26.Property = 100;
							attackResult.Debuff.Add(buff26);
							num488 = ((int)num2 * -1019166907) ^ 0x43E556EA;
							continue;
						case 23u:
							goto IL_80b2;
						case 63u:
							attackResult.Hp = 1;
							num488 = 805357340;
							continue;
						case 18u:
							num505 = (int)((double)Math.Abs(num505) / Tools.GetRandom(5.0, 10.0));
							num488 = 737932137;
							continue;
						case 31u:
							attackResult.costBall = 0;
							num488 = (int)(num2 * 1584072796) ^ -925030156;
							continue;
						case 11u:
							attackResult.Hp = 0;
							num488 = (int)(num2 * 1783082821) ^ -1706168025;
							continue;
						case 62u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[914].Split('#'), 1f, skill.AttackTime);
							return attackResult;
						case 1u:
							attackResult.Hp = targetSprite.Hp;
							num488 = (int)(num2 * 1067312019) ^ -815524125;
							continue;
						case 26u:
							goto IL_81b5;
						case 17u:
							goto IL_81e1;
						case 43u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[903].Split('#'), 1f, skill.AttackTime);
							attackResult.Hp = 1;
							num488 = (int)(num2 * 1138230457) ^ -1071184024;
							continue;
						case 60u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[901].Split('#'), 1f, skill.AttackTime);
							num488 = ((int)num2 * -1093028424) ^ -1185223598;
							continue;
						case 45u:
							goto IL_829c;
						case 27u:
							goto IL_82c8;
						case 40u:
							goto IL_82f4;
						case 58u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[906].Split('#'), 1f, skill.AttackTime);
							num488 = ((int)num2 * -1115590975) ^ -745241117;
							continue;
						case 14u:
							num505 = role.AttributesFinal[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(788062007u)] - role2.AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1550623476u)];
							num488 = (int)(num2 * 2095983294) ^ -2019590415;
							continue;
						case 32u:
							num505 = 0;
							num488 = (int)((num2 * 946231719) ^ 0x316E0840);
							continue;
						case 34u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[902].Split('#'), 1f, skill.AttackTime);
							attackResult.Hp = 0;
							num488 = (int)((num2 * 1578296377) ^ 0x6B35571D);
							continue;
						case 38u:
							goto IL_83fe;
						case 61u:
							return attackResult;
						case 30u:
						{
							int num511;
							int num512;
							if ((double)role.AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1550623476u)] / (double)role2.AttributesFinal[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1412133437u)] >= 2.0)
							{
								num511 = 548464638;
								num512 = num511;
							}
							else
							{
								num511 = 466902789;
								num512 = num511;
							}
							num488 = num511 ^ (int)(num2 * 12475382);
							continue;
						}
						case 33u:
							goto IL_848b;
						case 8u:
							return attackResult;
						case 5u:
							goto IL_84cc;
						case 10u:
							goto IL_84f8;
						case 39u:
							attackResult.Hp = 0;
							num488 = (int)(num2 * 1003703863) ^ -929291896;
							continue;
						case 42u:
							goto IL_853e;
						case 9u:
							goto IL_856a;
						case 51u:
							attackResult.Hp = 0;
							num488 = ((int)num2 * -1158579053) ^ 0x6D930E44;
							continue;
						case 37u:
							return attackResult;
						case 35u:
						{
							int num509;
							int num510;
							if (num505 <= 0)
							{
								num509 = 1729972288;
								num510 = num509;
							}
							else
							{
								num509 = 1128747541;
								num510 = num509;
							}
							num488 = num509 ^ (int)(num2 * 822239194);
							continue;
						}
						case 49u:
							goto IL_85e7;
						case 64u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[913].Split('#'), 1f, skill.AttackTime);
							num488 = (int)((num2 * 318412476) ^ 0x4C683797);
							continue;
						case 19u:
						{
							int num508 = (int)((double)(role.AttributesFinal[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3628012406u)] + role.AttributesFinal[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2259249129u)]) * Tools.GetRandom(5.0, 15.0)) + (int)((double)role2.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1995100678u)] * Tools.GetRandom(0.1, 0.3));
							attackResult.Hp = -num508;
							num488 = ((int)num2 * -1050843183) ^ 0x3B033651;
							continue;
						}
						case 7u:
							return attackResult;
						case 28u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[912].Split('#'), 1f, skill.AttackTime);
							num488 = 1604900444;
							continue;
						case 47u:
							return attackResult;
						case 4u:
							attackResult.Hp = (int)((float)role2.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1768687720u)] / 2f);
							num488 = ((int)num2 * -1628129987) ^ 0x2764ADBB;
							continue;
						case 48u:
							return attackResult;
						case 44u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[909].Split('#'), 1f, skill.AttackTime);
							num488 = (int)(num2 * 1094072584) ^ -1363283405;
							continue;
						case 15u:
							return attackResult;
						case 54u:
							goto IL_87e2;
						case 56u:
							attackResult.costBall = -2;
							return attackResult;
						case 57u:
							attackResult.Hp = 2000 + Tools.GetRandomInt(5 * num505, 20 * num505);
							num488 = (int)(num2 * 373740435) ^ -732364869;
							continue;
						case 12u:
							attackResult.Hp = 0;
							num488 = (int)(num2 * 644023714) ^ -1364371923;
							continue;
						case 52u:
						{
							int num506;
							int num507;
							if (num505 > 0)
							{
								num506 = -1083972917;
								num507 = num506;
							}
							else
							{
								num506 = -445937326;
								num507 = num506;
							}
							num488 = num506 ^ ((int)num2 * -960246837);
							continue;
						}
						case 16u:
							return attackResult;
						case 21u:
							return attackResult;
						case 20u:
							buff26 = new Buff();
							buff26.Name = Buff.DebuffNames[Tools.GetRandomInt(0, Buff.DebuffNames.Length - 1)];
							num488 = ((int)num2 * -1518931243) ^ 0x64208280;
							continue;
						case 55u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[911].Split('#'), 1f, skill.AttackTime);
							attackResult.Hp = Tools.GetRandomInt(1000, 2000 + 100 * role.Level) + (int)((double)targetSprite.Hp * 0.1);
							num488 = ((int)num2 * -546191612) ^ 0x52DCCF93;
							continue;
						case 22u:
							goto IL_8962;
						case 59u:
							attackResult.Hp = 0;
							return attackResult;
						case 6u:
						{
							int num503;
							int num504;
							if (!Tools.ProbabilityTest(0.6))
							{
								num503 = 1364534610;
								num504 = num503;
							}
							else
							{
								num503 = 716577933;
								num504 = num503;
							}
							num488 = num503 ^ (int)(num2 * 591072955);
							continue;
						}
						case 29u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[908].Split('#'), 1f, skill.AttackTime);
							num488 = (int)(num2 * 313863147) ^ -1664330568;
							continue;
						case 24u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[905].Split('#'), 1f, skill.AttackTime);
							attackResult.AddAttackInfo2(targetSprite, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1970663377u), Color.white, skill.AttackTime);
							attackResult.Hp = 0;
							num488 = 1574803311;
							continue;
						case 46u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[907].Split('#'), 1f, skill.AttackTime);
							num488 = (int)((num2 * 2029295677) ^ 0x6369BF3C);
							continue;
						case 50u:
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[910].Split('#'), 1f, skill.AttackTime);
							num488 = ((int)num2 * -571064746) ^ 0x223581F0;
							continue;
						default:
						{
							attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[915].Split('#'), 1f, skill.AttackTime);
							IEnumerator<BattleSprite> enumerator = bf.Sprites.GetEnumerator();
							try
							{
								while (true)
								{
									IL_8d16:
									int num491;
									int num492;
									if (!enumerator.MoveNext())
									{
										num491 = 306805535;
										num492 = num491;
									}
									else
									{
										num491 = 1767035548;
										num492 = num491;
									}
									while (true)
									{
										switch ((num2 = (uint)(num491 ^ 0x69C4C43D)) % 25)
										{
										case 12u:
											num491 = 1767035548;
											continue;
										default:
											goto end_IL_8b4d;
										case 2u:
											buff24.Name = ResourceStrings.ResStrings[527];
											buff24.Level = 5;
											buff24.Round = 3;
											buff25 = new BuffInstance
											{
												buff = buff24,
												Owner = current10,
												LeftRound = buff24.Round
											};
											num491 = ((int)num2 * -2027578498) ^ -1086353944;
											continue;
										case 7u:
											bf.ShowSkillAnimation(skill, current10.X, current10.Y, null);
											num491 = (int)((num2 * 1229586330) ^ 0x4230CAC1);
											continue;
										case 18u:
											current10 = enumerator.Current;
											num491 = 438266274;
											continue;
										case 9u:
											buff24.Round = 3;
											num491 = (int)((num2 * 236274809) ^ 0x121C0A29);
											continue;
										case 16u:
										{
											buff25 = new BuffInstance
											{
												buff = buff24,
												Owner = current10,
												LeftRound = buff24.Round
											};
											int num497;
											int num498;
											if (current10.AddBuffOnly(buff25))
											{
												num497 = -1700129909;
												num498 = num497;
											}
											else
											{
												num497 = -1924208736;
												num498 = num497;
											}
											num491 = num497 ^ (int)(num2 * 1829432881);
											continue;
										}
										case 23u:
											buff24.Round = 3;
											num491 = (int)(num2 * 1501771605) ^ -1790992442;
											continue;
										case 17u:
											buff24 = new Buff();
											num491 = ((int)num2 * -1316516419) ^ 0x5E7096FA;
											continue;
										case 1u:
											current10.RefreshBuffsInvoke();
											num491 = ((int)num2 * -1721098171) ^ -1830345296;
											continue;
										case 20u:
											break;
										case 22u:
											flag8 = false;
											num491 = ((int)num2 * -833474963) ^ 0x6F3254B;
											continue;
										case 19u:
											Log(string.Format(ResourceStrings.ResStrings[916], current10.Role.Name));
											attackResult.AddAttackInfo2(current10, ResourceStrings.ResStrings[917], Color.red, skill.AttackTime);
											num491 = ((int)num2 * -257838446) ^ 0xCBC0ADC;
											continue;
										case 6u:
										{
											int num501;
											if (!flag8)
											{
												num491 = 1517538482;
												num501 = num491;
											}
											else
											{
												num491 = 1252627018;
												num501 = num491;
											}
											continue;
										}
										case 5u:
										{
											int num499;
											int num500;
											if (!current10.AddBuffOnly(buff25))
											{
												num499 = -1423981792;
												num500 = num499;
											}
											else
											{
												num499 = -2119668461;
												num500 = num499;
											}
											num491 = num499 ^ ((int)num2 * -781789062);
											continue;
										}
										case 3u:
											buff25 = new BuffInstance
											{
												buff = buff24,
												Owner = current10,
												LeftRound = buff24.Round
											};
											num491 = ((int)num2 * -1367160252) ^ 0x1FB5518F;
											continue;
										case 10u:
										{
											int num495;
											int num496;
											if (!current10.AddBuffOnly(buff25))
											{
												num495 = -182102879;
												num496 = num495;
											}
											else
											{
												num495 = -1342869228;
												num496 = num495;
											}
											num491 = num495 ^ (int)(num2 * 1082514774);
											continue;
										}
										case 14u:
											buff24.Name = ResourceStrings.ResStrings[524];
											num491 = (int)(num2 * 734970130) ^ -1560969973;
											continue;
										case 8u:
											flag8 = true;
											num491 = (int)((num2 * 957985509) ^ 0xA0E6CE4);
											continue;
										case 4u:
											buff24 = new Buff();
											num491 = 1694978553;
											continue;
										case 21u:
										{
											int num493;
											int num494;
											if (current10.Team != sourceSprite.Team)
											{
												num493 = 2039990581;
												num494 = num493;
											}
											else
											{
												num493 = 161444623;
												num494 = num493;
											}
											num491 = num493 ^ ((int)num2 * -777760999);
											continue;
										}
										case 13u:
											buff24 = new Buff();
											buff24.Name = ResourceStrings.ResStrings[547];
											buff24.Level = 5;
											num491 = 496810461;
											continue;
										case 11u:
											flag8 = true;
											num491 = ((int)num2 * -1973936655) ^ 0x41B018CE;
											continue;
										case 0u:
											flag8 = true;
											num491 = ((int)num2 * -1434518382) ^ 0x1E25FC81;
											continue;
										case 15u:
											buff24.Level = 5;
											num491 = (int)((num2 * 1482522162) ^ 0x66464BAA);
											continue;
										case 24u:
											goto end_IL_8b4d;
										}
										goto IL_8d16;
										continue;
										end_IL_8b4d:
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
										IL_8f3e:
										int num502 = 594137054;
										while (true)
										{
											switch ((num2 = (uint)(num502 ^ 0x69C4C43D)) % 3)
											{
											case 0u:
												break;
											default:
												goto end_IL_8f43;
											case 2u:
												goto IL_8f61;
											case 1u:
												goto end_IL_8f43;
											}
											goto IL_8f3e;
											IL_8f61:
											enumerator.Dispose();
											num502 = (int)((num2 * 191695664) ^ 0x72EBAFC2);
											continue;
											end_IL_8f43:
											break;
										}
										break;
									}
								}
							}
							return attackResult;
						}
						}
						break;
						IL_8962:
						int num515;
						if (name == ResourceStrings.ResStrings[622])
						{
							num488 = 1881591434;
							num515 = num488;
						}
						else
						{
							num488 = 1819424668;
							num515 = num488;
						}
						continue;
						IL_829c:
						int num516;
						if (name == ResourceStrings.ResStrings[604])
						{
							num488 = 853435248;
							num516 = num488;
						}
						else
						{
							num488 = 1705245029;
							num516 = num488;
						}
						continue;
						IL_84cc:
						int num517;
						if (name == ResourceStrings.ResStrings[626])
						{
							num488 = 643360041;
							num517 = num488;
						}
						else
						{
							num488 = 152942940;
							num517 = num488;
						}
						continue;
						IL_87e2:
						int num518;
						if (Tools.ProbabilityTest(0.5))
						{
							num488 = 829721554;
							num518 = num488;
						}
						else
						{
							num488 = 675019842;
							num518 = num488;
						}
						continue;
						IL_82f4:
						if (name == ResourceStrings.ResStrings[612])
						{
							num488 = 365568714;
							continue;
						}
						goto IL_98a0;
						IL_81b5:
						int num519;
						if (name == ResourceStrings.ResStrings[623])
						{
							num488 = 812877521;
							num519 = num488;
						}
						else
						{
							num488 = 2105193238;
							num519 = num488;
						}
						continue;
						IL_85e7:
						int num520;
						if (!Tools.ProbabilityTest(0.1))
						{
							num488 = 737932137;
							num520 = num488;
						}
						else
						{
							num488 = 381941519;
							num520 = num488;
						}
						continue;
						IL_848b:
						int num521;
						if (!(name == ResourceStrings.ResStrings[617]))
						{
							num488 = 607568386;
							num521 = num488;
						}
						else
						{
							num488 = 282118295;
							num521 = num488;
						}
						continue;
						IL_82c8:
						int num522;
						if (name == ResourceStrings.ResStrings[603])
						{
							num488 = 921315061;
							num522 = num488;
						}
						else
						{
							num488 = 1520073067;
							num522 = num488;
						}
						continue;
						IL_856a:
						int num523;
						if (!(name == ResourceStrings.ResStrings[600]))
						{
							num488 = 1113357033;
							num523 = num488;
						}
						else
						{
							num488 = 609244617;
							num523 = num488;
						}
						continue;
						IL_80b2:
						int num524;
						if (name == ResourceStrings.ResStrings[625])
						{
							num488 = 2093070894;
							num524 = num488;
						}
						else
						{
							num488 = 950324370;
							num524 = num488;
						}
						continue;
						IL_83fe:
						int num525;
						if (name == ResourceStrings.ResStrings[602])
						{
							num488 = 724004580;
							num525 = num488;
						}
						else
						{
							num488 = 1327465806;
							num525 = num488;
						}
						continue;
						IL_853e:
						int num526;
						if (!(name == ResourceStrings.ResStrings[601]))
						{
							num488 = 537241213;
							num526 = num488;
						}
						else
						{
							num488 = 1526904499;
							num526 = num488;
						}
						continue;
						IL_81e1:
						int num527;
						if (!(name == ResourceStrings.ResStrings[629]))
						{
							num488 = 238801321;
							num527 = num488;
						}
						else
						{
							num488 = 1173260035;
							num527 = num488;
						}
					}
					goto IL_7ea0;
					IL_98a0:
					while (true)
					{
						int num528;
						int num529;
						if (name == ResourceStrings.ResStrings[628])
						{
							num528 = 1832589597;
							num529 = num528;
						}
						else
						{
							num528 = 2145685355;
							num529 = num528;
						}
						while (true)
						{
							switch ((num2 = (uint)(num528 ^ 0x69C4C43D)) % 51)
							{
							case 48u:
								num528 = 1149556220;
								continue;
							case 37u:
								bf.DoAttackInfo(string.Format(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(413954281u), num607), Color.white, skill.AttackTime, targetSprite.X, targetSprite.Y);
								bf.DoAttackInfo(string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(38753286u), sourceSprite.Hp), Color.white, skill.AttackTime, sourceSprite.X, sourceSprite.Y);
								num528 = ((int)num2 * -1908950080) ^ -1621193221;
								continue;
							case 38u:
								num528 = (int)(num2 * 1473771416) ^ -756749267;
								continue;
							case 44u:
								num614 = 0.01;
								num528 = ((int)num2 * -1607846063) ^ 0x44DA3371;
								continue;
							case 41u:
								Log(string.Format(ResourceStrings.ResStrings[920], role.Name));
								num528 = ((int)num2 * -355449766) ^ -1480332739;
								continue;
							case 12u:
								attackResult.Mp = 0;
								num528 = ((int)num2 * -249486747) ^ 0x4DDF9DBA;
								continue;
							case 24u:
							{
								int num622;
								if (num614 > 0.3)
								{
									num528 = 1051637141;
									num622 = num528;
								}
								else
								{
									num528 = 2063586901;
									num622 = num528;
								}
								continue;
							}
							case 35u:
							{
								sourceSprite.Say_fs(array[Tools.GetRandomInt(0, array.Length) % array.Length], skill.AttackTime);
								num614 = 0.01 + Convert.ToDouble(role.AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2186305609u)] - role2.AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2186305609u)]) / 30000.0;
								int num618;
								int num619;
								if (num614 >= 0.01)
								{
									num618 = -1320641830;
									num619 = num618;
								}
								else
								{
									num618 = -1916866422;
									num619 = num618;
								}
								num528 = num618 ^ (int)(num2 * 2128015187);
								continue;
							}
							case 9u:
								attackResult.AddAttackInfo2(targetSprite, ResourceStrings.ResStrings[926], Color.yellow, skill.AttackTime);
								num528 = ((int)num2 * -468758740) ^ -924007862;
								continue;
							case 19u:
								bf.DoAttackInfo(string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(38753286u), targetSprite.Hp), Color.white, skill.AttackTime, targetSprite.X, targetSprite.Y);
								num528 = ((int)num2 * -1591965422) ^ 0x3D70E151;
								continue;
							case 25u:
								return attackResult;
							case 17u:
								return attackResult;
							case 45u:
								bf.DoAttackInfo(string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(38753286u), sourceSprite.Hp), Color.white, skill.AttackTime, sourceSprite.X, sourceSprite.Y);
								num528 = ((int)num2 * -482121522) ^ 0x462DA451;
								continue;
							case 15u:
								num614 = 0.3;
								num528 = (int)(num2 * 497052115) ^ -1129954515;
								continue;
							case 14u:
								Log(string.Format(ResourceStrings.ResStrings[929], role.Name, role2.Name, num612));
								num528 = (int)((num2 * 1136957212) ^ 0x2CAFF37C);
								continue;
							case 50u:
								targetSprite.Hp -= num607;
								num528 = ((int)num2 * -1550029530) ^ -1334914729;
								continue;
							case 5u:
								attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[924], 1f, skill.AttackTime);
								num528 = (int)((num2 * 1661677200) ^ 0x3F2D8636);
								continue;
							case 7u:
								attackResult.Hp = 0;
								attackResult.Mp = 0;
								num528 = (int)(num2 * 1351467391) ^ -1765987002;
								continue;
							case 4u:
								num607 = (int)((double)sourceSprite.Hp * Tools.GetRandom(0.5, 1.5));
								num528 = 837398700;
								continue;
							case 18u:
								bf.DoAttackInfo(ResourceStrings.ResStrings[922], Color.white, skill.AttackTime, sourceSprite.X, sourceSprite.Y);
								num528 = ((int)num2 * -408342582) ^ -825816294;
								continue;
							case 10u:
								buff29 = targetSprite.GetBuff(ResourceStrings.ResStrings[519]);
								num528 = (int)(num2 * 215988093) ^ -334675426;
								continue;
							case 32u:
								attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[921], 1f, skill.AttackTime);
								num528 = ((int)num2 * -1912617885) ^ -857888364;
								continue;
							case 42u:
							{
								int num537;
								int num538;
								if (buff29 != null)
								{
									num537 = 508624235;
									num538 = num537;
								}
								else
								{
									num537 = 204814967;
									num538 = num537;
								}
								num528 = num537 ^ ((int)num2 * -1528652627);
								continue;
							}
							case 6u:
								num609 = Convert.ToDouble(role.AttributesFinal[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(701808387u)] - role2.AttributesFinal[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(400004197u)]);
								num528 = 1306691462;
								continue;
							case 33u:
								attackResult.Hp = num612;
								attackResult.AddAttackInfo2(targetSprite, ResourceStrings.ResStrings[928], Color.red, skill.AttackTime);
								num528 = (int)(num2 * 467486756) ^ -2080264675;
								continue;
							case 40u:
							{
								int num620;
								int num621;
								if (sourceSprite.Hp <= 0)
								{
									num620 = 1059000181;
									num621 = num620;
								}
								else
								{
									num620 = 110655069;
									num621 = num620;
								}
								num528 = num620 ^ (int)(num2 * 588262899);
								continue;
							}
							case 27u:
								num539 = (int)((double)targetSprite.MaxHp * num540 * Tools.GetRandom(0.5, 1.0 + num609 / 1000.0));
								num528 = 35805515;
								continue;
							case 2u:
								array = ResourceStrings.ResStrings[918].Split('#');
								num528 = ((int)num2 * -20516910) ^ -683819049;
								continue;
							case 47u:
							{
								int num617;
								if (Tools.ProbabilityTest(num614))
								{
									num528 = 1632999816;
									num617 = num528;
								}
								else
								{
									num528 = 2100949865;
									num617 = num528;
								}
								continue;
							}
							case 34u:
							{
								int num616;
								if (!(name == ResourceStrings.ResStrings[620]))
								{
									num528 = 483076478;
									num616 = num528;
								}
								else
								{
									num528 = 553682537;
									num616 = num528;
								}
								continue;
							}
							case 43u:
								bf.DoAttackInfo(string.Format(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(413954281u), num539), Color.white, skill.AttackTime, targetSprite.X, targetSprite.Y);
								targetSprite.Hp -= num539;
								num528 = (int)(num2 * 2001344545) ^ -968934243;
								continue;
							case 46u:
								attackResult.AddAttackInfo2(targetSprite, ResourceStrings.ResStrings[925], Color.yellow, skill.AttackTime);
								num528 = (int)(num2 * 1140015076) ^ -1417787646;
								continue;
							case 29u:
								targetSprite.Sp = 0.0;
								num528 = ((int)num2 * -1293064607) ^ 0x1C52C9B9;
								continue;
							case 0u:
							{
								int num615;
								if (num539 > 0)
								{
									num528 = 321514003;
									num615 = num528;
								}
								else
								{
									num528 = 369917811;
									num615 = num528;
								}
								continue;
							}
							case 1u:
								Log(string.Format(ResourceStrings.ResStrings[927], role.Name, role2.Name));
								num528 = (int)((num2 * 1235794150) ^ 0xCA4461);
								continue;
							case 30u:
								sourceSprite.Hp = 0;
								sourceSprite.MaxHp -= 10;
								num528 = 394626723;
								continue;
							case 31u:
								Log(string.Format(ResourceStrings.ResStrings[923], role.Name));
								attackResult.Hp = 0;
								num528 = 1553772544;
								continue;
							case 26u:
								num540 = Math.Min(0.3, (double)sourceSprite.Hp / (double)sourceSprite.MaxHp);
								sourceSprite.Hp -= (int)((double)sourceSprite.MaxHp * num540);
								num528 = ((int)num2 * -1631922050) ^ 0x7E50388D;
								continue;
							case 16u:
								return attackResult;
							case 23u:
								attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[620], 1f, skill.AttackTime);
								num612 = (int)((double)((buff29.Level + 1) * buff29.LeftRound * 50) * Tools.GetRandom(1.0, 2.0));
								num528 = ((int)num2 * -1700386857) ^ 0x2CE06B75;
								continue;
							case 39u:
								sourceSprite.Hp = 1;
								num528 = (int)(num2 * 621534550) ^ -1708366721;
								continue;
							case 20u:
							{
								int num613;
								if (name == ResourceStrings.ResStrings[619])
								{
									num528 = 2146634783;
									num613 = num528;
								}
								else
								{
									num528 = 181100359;
									num613 = num528;
								}
								continue;
							}
							case 22u:
							{
								num539 = 0;
								int num610;
								int num611;
								if (num609 < 0.0)
								{
									num610 = 1332052567;
									num611 = num610;
								}
								else
								{
									num610 = 2067025807;
									num611 = num610;
								}
								num528 = num610 ^ ((int)num2 * -1398499720);
								continue;
							}
							case 13u:
								break;
							case 11u:
							{
								int num608;
								if (name == ResourceStrings.ResStrings[627])
								{
									num528 = 103916218;
									num608 = num528;
								}
								else
								{
									num528 = 61815195;
									num608 = num528;
								}
								continue;
							}
							case 49u:
								return attackResult;
							case 21u:
								Log(string.Format(ResourceStrings.ResStrings[919], role.Name, role2.Name));
								targetSprite.Hp = 0;
								num528 = (int)(num2 * 407908665) ^ -697636121;
								continue;
							case 3u:
								targetSprite.Balls = 0;
								num528 = ((int)num2 * -1791532910) ^ 0x3F68315A;
								continue;
							case 28u:
								if (name == ResourceStrings.ResStrings[608])
								{
									num528 = 930282753;
									continue;
								}
								while (name == ResourceStrings.ResStrings[609])
								{
									int num541 = 1970660983;
									while (true)
									{
										switch ((num2 = (uint)(num541 ^ 0x69C4C43D)) % 3)
										{
										case 0u:
											goto IL_9c44;
										case 2u:
											break;
										default:
										{
											attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[933], 1f, skill.AttackTime);
											IEnumerator<BattleSprite> enumerator = bf.Sprites.GetEnumerator();
											try
											{
												while (true)
												{
													IL_9ef4:
													if (enumerator.MoveNext())
													{
														while (true)
														{
															current12 = enumerator.Current;
															if (current12.Team != sourceSprite.Team)
															{
																break;
															}
															int num542 = 1103025351;
															while (true)
															{
																switch ((num2 = (uint)(num542 ^ 0x69C4C43D)) % 8)
																{
																case 5u:
																	num542 = 1651127398;
																	continue;
																case 3u:
																	break;
																case 1u:
																	goto IL_9d18;
																case 2u:
																	Log(string.Format(ResourceStrings.ResStrings[934], current12.Role.Name));
																	num542 = ((int)num2 * -41047547) ^ 0x6A6A6F6B;
																	continue;
																case 4u:
																	attackResult.AddAttackInfo2(current12, ResourceStrings.ResStrings[935], Color.white, skill.AttackTime);
																	num542 = ((int)num2 * -1216313965) ^ -373395800;
																	continue;
																case 0u:
																	goto IL_9dbe;
																case 6u:
																	list3 = new List<BuffInstance>();
																	num542 = (int)(num2 * 167564102) ^ -576680490;
																	continue;
																default:
																	goto IL_9dfc;
																}
																break;
																IL_9dbe:
																if (current12.Buffs.Count == 0)
																{
																	goto end_IL_9cf6;
																}
																num542 = (int)(num2 * 1034402771) ^ -2065338981;
																continue;
																IL_9d18:
																bf.ShowSkillAnimation(skill, current12.X, current12.Y, null);
																if (current12.Buffs == null)
																{
																	goto end_IL_9cf6;
																}
																num542 = ((int)num2 * -801564697) ^ 0x3FAF8D52;
															}
															continue;
															end_IL_9cf6:
															break;
														}
														continue;
													}
													int num543 = 2018223437;
													goto IL_9ece;
													IL_9ece:
													while (true)
													{
														switch ((num2 = (uint)(num543 ^ 0x69C4C43D)) % 5)
														{
														case 2u:
															break;
														default:
															goto end_IL_9ef4;
														case 0u:
															goto IL_9ef4;
														case 3u:
															current12.Buffs = list3;
															current12.Set_needRefresh();
															current12.RefreshBuffsInvoke();
															num543 = ((int)num2 * -477638579) ^ -363653649;
															continue;
														case 1u:
															current12.Buffs.Clear();
															num543 = (int)((num2 * 371808766) ^ 0x6A7D0CA1);
															continue;
														case 4u:
															goto end_IL_9ef4;
														}
														break;
													}
													goto IL_9ec9;
													IL_9ec9:
													num543 = 1401960839;
													goto IL_9ece;
													IL_9dfc:
													using (List<BuffInstance>.Enumerator enumerator5 = current12.Buffs.GetEnumerator())
													{
														while (true)
														{
															IL_9e3b:
															int num544;
															int num545;
															if (enumerator5.MoveNext())
															{
																num544 = 663210396;
																num545 = num544;
															}
															else
															{
																num544 = 1138187112;
																num545 = num544;
															}
															while (true)
															{
																switch ((num2 = (uint)(num544 ^ 0x69C4C43D)) % 6)
																{
																case 0u:
																	num544 = 663210396;
																	continue;
																default:
																	goto end_IL_9e11;
																case 2u:
																	break;
																case 4u:
																{
																	int num546;
																	int num547;
																	if (!current13.IsDebuff)
																	{
																		num546 = -441648494;
																		num547 = num546;
																	}
																	else
																	{
																		num546 = -1887018789;
																		num547 = num546;
																	}
																	num544 = num546 ^ ((int)num2 * -775986820);
																	continue;
																}
																case 1u:
																	current13 = enumerator5.Current;
																	num544 = 1135761077;
																	continue;
																case 3u:
																	list3.Add(current13);
																	num544 = ((int)num2 * -1859881149) ^ 0xBAD2B96;
																	continue;
																case 5u:
																	goto end_IL_9e11;
																}
																goto IL_9e3b;
																continue;
																end_IL_9e11:
																break;
															}
															break;
														}
													}
													if (current12.Buffs.Count == list3.Count)
													{
														continue;
													}
													goto IL_9ec9;
													continue;
													end_IL_9ef4:
													break;
												}
											}
											finally
											{
												if (enumerator != null)
												{
													while (true)
													{
														IL_9f50:
														int num548 = 765754917;
														while (true)
														{
															switch ((num2 = (uint)(num548 ^ 0x69C4C43D)) % 3)
															{
															case 0u:
																break;
															default:
																goto end_IL_9f55;
															case 2u:
																goto IL_9f73;
															case 1u:
																goto end_IL_9f55;
															}
															goto IL_9f50;
															IL_9f73:
															enumerator.Dispose();
															num548 = (int)((num2 * 1428720558) ^ 0x4A5719C);
															continue;
															end_IL_9f55:
															break;
														}
														break;
													}
												}
											}
											return attackResult;
										}
										}
										break;
										IL_9c44:
										num541 = 967120360;
									}
								}
								while (name == ResourceStrings.ResStrings[610])
								{
									int num549 = 592496342;
									while (true)
									{
										switch ((num2 = (uint)(num549 ^ 0x69C4C43D)) % 4)
										{
										case 2u:
											num549 = 2090259620;
											continue;
										case 1u:
											break;
										case 3u:
											attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[936], 1f, skill.AttackTime);
											num549 = ((int)num2 * -564814857) ^ 0x5F98130C;
											continue;
										default:
										{
											IEnumerator<BattleSprite> enumerator = bf.Sprites.GetEnumerator();
											try
											{
												while (true)
												{
													IL_a255:
													if (enumerator.MoveNext())
													{
														while (true)
														{
															current14 = enumerator.Current;
															int num550 = 1172560160;
															while (true)
															{
																switch ((num2 = (uint)(num550 ^ 0x69C4C43D)) % 8)
																{
																case 0u:
																	num550 = 1561446571;
																	continue;
																case 6u:
																	break;
																case 2u:
																	Log(string.Format(ResourceStrings.ResStrings[934], current14.Role.Name));
																	attackResult.AddAttackInfo2(current14, ResourceStrings.ResStrings[935], Color.white, skill.AttackTime);
																	num550 = ((int)num2 * -682462048) ^ -1466175844;
																	continue;
																case 1u:
																	goto IL_a0c1;
																case 5u:
																	goto IL_a0f6;
																case 3u:
																	list4 = new List<BuffInstance>();
																	num550 = (int)((num2 * 1350050473) ^ 0x427E4F91);
																	continue;
																case 4u:
																	goto IL_a135;
																default:
																	goto end_IL_a053;
																}
																break;
																IL_a135:
																if (current14.Buffs.Count != 0)
																{
																	num550 = (int)((num2 * 1813296116) ^ 0x702C720E);
																	continue;
																}
																goto IL_a255;
																IL_a0c1:
																bf.ShowSkillAnimation(skill, current14.X, current14.Y, null);
																if (current14.Buffs != null)
																{
																	num550 = ((int)num2 * -88920683) ^ 0x36388C14;
																	continue;
																}
																goto IL_a255;
																IL_a0f6:
																if (current14.Team == sourceSprite.Team)
																{
																	num550 = ((int)num2 * -1602478937) ^ 0x4B4D4B74;
																	continue;
																}
																goto IL_a255;
															}
															continue;
															end_IL_a053:
															break;
														}
														using (List<BuffInstance>.Enumerator enumerator5 = current14.Buffs.GetEnumerator())
														{
															while (true)
															{
																IL_a1a8:
																int num551;
																int num552;
																if (enumerator5.MoveNext())
																{
																	num551 = 1647240453;
																	num552 = num551;
																}
																else
																{
																	num551 = 1881282281;
																	num552 = num551;
																}
																while (true)
																{
																	switch ((num2 = (uint)(num551 ^ 0x69C4C43D)) % 6)
																	{
																	case 0u:
																		num551 = 1647240453;
																		continue;
																	default:
																		goto end_IL_a16e;
																	case 4u:
																		current15 = enumerator5.Current;
																		num551 = 1461963848;
																		continue;
																	case 5u:
																		break;
																	case 3u:
																		list4.Add(current15);
																		num551 = ((int)num2 * -1587056285) ^ -1145575191;
																		continue;
																	case 1u:
																	{
																		int num553;
																		int num554;
																		if (!current15.IsDebuff)
																		{
																			num553 = -47516003;
																			num554 = num553;
																		}
																		else
																		{
																			num553 = -1023700053;
																			num554 = num553;
																		}
																		num551 = num553 ^ ((int)num2 * -1628809821);
																		continue;
																	}
																	case 2u:
																		goto end_IL_a16e;
																	}
																	goto IL_a1a8;
																	continue;
																	end_IL_a16e:
																	break;
																}
																break;
															}
														}
														if (current14.Buffs.Count == list4.Count)
														{
															continue;
														}
														goto IL_a226;
													}
													int num555 = 484794073;
													goto IL_a22b;
													IL_a226:
													num555 = 1087127868;
													goto IL_a22b;
													IL_a22b:
													while (true)
													{
														switch ((num2 = (uint)(num555 ^ 0x69C4C43D)) % 6)
														{
														case 0u:
															break;
														default:
															goto end_IL_a255;
														case 5u:
															goto IL_a255;
														case 2u:
															current14.Set_needRefresh();
															current14.RefreshBuffsInvoke();
															num555 = ((int)num2 * -2072574068) ^ -1043745146;
															continue;
														case 1u:
															current14.Buffs = list4;
															num555 = (int)(num2 * 205692267) ^ -1714250446;
															continue;
														case 3u:
															current14.Buffs.Clear();
															num555 = ((int)num2 * -396721804) ^ -1640503286;
															continue;
														case 4u:
															goto end_IL_a255;
														}
														break;
													}
													goto IL_a226;
													continue;
													end_IL_a255:
													break;
												}
											}
											finally
											{
												if (enumerator != null)
												{
													while (true)
													{
														IL_a2c4:
														int num556 = 1535409763;
														while (true)
														{
															switch ((num2 = (uint)(num556 ^ 0x69C4C43D)) % 3)
															{
															case 2u:
																break;
															default:
																goto end_IL_a2c9;
															case 1u:
																goto IL_a2e7;
															case 0u:
																goto end_IL_a2c9;
															}
															goto IL_a2c4;
															IL_a2e7:
															enumerator.Dispose();
															num556 = (int)(num2 * 178497393) ^ -1661301504;
															continue;
															end_IL_a2c9:
															break;
														}
														break;
													}
												}
											}
											return attackResult;
										}
										}
										break;
									}
								}
								while (name == ResourceStrings.ResStrings[613])
								{
									int num557 = 1860500744;
									while (true)
									{
										switch ((num2 = (uint)(num557 ^ 0x69C4C43D)) % 4)
										{
										case 3u:
											num557 = 1612753187;
											continue;
										case 2u:
											break;
										case 1u:
											attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[613], 1f, skill.AttackTime);
											num557 = (int)(num2 * 19268271) ^ -492022786;
											continue;
										default:
										{
											IEnumerator<BattleSprite> enumerator = bf.Sprites.GetEnumerator();
											try
											{
												while (true)
												{
													IL_a4fd:
													int num558;
													int num559;
													if (enumerator.MoveNext())
													{
														num558 = 1300780388;
														num559 = num558;
													}
													else
													{
														num558 = 1367100645;
														num559 = num558;
													}
													while (true)
													{
														switch ((num2 = (uint)(num558 ^ 0x69C4C43D)) % 8)
														{
														case 2u:
															num558 = 1300780388;
															continue;
														default:
															goto end_IL_a392;
														case 1u:
															current16 = enumerator.Current;
															num558 = 1545025734;
															continue;
														case 7u:
														{
															BuffInstance buff31 = current16.GetBuff(ResourceStrings.ResStrings[519]);
															int randomInt = Tools.GetRandomInt(1, 10);
															Buff buff32 = new Buff
															{
																Name = ResourceStrings.ResStrings[519],
																Level = randomInt,
																Round = Tools.GetRandomInt(3, 6)
															};
															buff30 = new BuffInstance
															{
																buff = buff32,
																Owner = current16,
																LeftRound = buff32.Round
															};
															int num562;
															int num563;
															if (buff31 != null)
															{
																num562 = 336226871;
																num563 = num562;
															}
															else
															{
																num562 = 1045430398;
																num563 = num562;
															}
															num558 = num562 ^ ((int)num2 * -637882015);
															continue;
														}
														case 3u:
															attackResult.AddAttackInfo2(current16, ResourceStrings.ResStrings[519], new Color(0f, 0.392f, 0f, 1f), skill.AttackTime);
															num558 = (int)((num2 * 1571884143) ^ 0x56D3D40F);
															continue;
														case 6u:
															current16.RefreshBuffsInvoke();
															num558 = ((int)num2 * -1059745415) ^ -2010651218;
															continue;
														case 4u:
														{
															int num560;
															int num561;
															if (!current16.AddBuff2(buff30))
															{
																num560 = -1998360888;
																num561 = num560;
															}
															else
															{
																num560 = -875487541;
																num561 = num560;
															}
															num558 = num560 ^ ((int)num2 * -770004738);
															continue;
														}
														case 5u:
															break;
														case 0u:
															goto end_IL_a392;
														}
														goto IL_a4fd;
														continue;
														end_IL_a392:
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
														IL_a520:
														int num564 = 2031344206;
														while (true)
														{
															switch ((num2 = (uint)(num564 ^ 0x69C4C43D)) % 3)
															{
															case 0u:
																break;
															default:
																goto end_IL_a525;
															case 1u:
																goto IL_a543;
															case 2u:
																goto end_IL_a525;
															}
															goto IL_a520;
															IL_a543:
															enumerator.Dispose();
															num564 = (int)((num2 * 1545506195) ^ 0x790A66B0);
															continue;
															end_IL_a525:
															break;
														}
														break;
													}
												}
											}
											return attackResult;
										}
										}
										break;
									}
								}
								while (name == ResourceStrings.ResStrings[611])
								{
									int num565 = 1687227974;
									while (true)
									{
										switch ((num2 = (uint)(num565 ^ 0x69C4C43D)) % 3)
										{
										case 2u:
											goto IL_a55d;
										case 1u:
											break;
										default:
										{
											attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[937], 1f, skill.AttackTime);
											IEnumerator<BattleSprite> enumerator = bf.Sprites.GetEnumerator();
											try
											{
												while (true)
												{
													IL_a98b:
													if (enumerator.MoveNext())
													{
														while (true)
														{
															current17 = enumerator.Current;
															int num566 = 931443893;
															while (true)
															{
																switch ((num2 = (uint)(num566 ^ 0x69C4C43D)) % 13)
																{
																case 8u:
																	num566 = 473882294;
																	continue;
																case 4u:
																	break;
																case 3u:
																{
																	int num569;
																	int num570;
																	if (role.BuiltInTalents[137])
																	{
																		num569 = 1717949547;
																		num570 = num569;
																	}
																	else
																	{
																		num569 = 2124048012;
																		num570 = num569;
																	}
																	num566 = num569 ^ ((int)num2 * -267279017);
																	continue;
																}
																case 5u:
																	goto end_IL_a5da;
																case 2u:
																	attackResult.AddAttackInfo2(current17, ResourceStrings.ResStrings[939], Color.white, skill.AttackTime);
																	bf.ShowSkillAnimation(skill, current17.X, current17.Y, null);
																	num566 = ((int)num2 * -1834776825) ^ 0x19CF0BFA;
																	continue;
																case 12u:
																	goto IL_a6d6;
																case 6u:
																	Log(current17.Role.Name + ResourceStrings.ResStrings[531]);
																	num566 = (int)(num2 * 2100155681) ^ -345044037;
																	continue;
																case 7u:
																	list5 = new List<BuffInstance>();
																	num566 = ((int)num2 * -875678418) ^ 0x650FF876;
																	continue;
																case 9u:
																	attackResult.AddAttackInfo2(current17, ResourceStrings.ResStrings[531], Color.red, skill.AttackTime);
																	num566 = ((int)num2 * -171537830) ^ -137831469;
																	continue;
																case 0u:
																	goto IL_a777;
																case 1u:
																	Log(string.Format(ResourceStrings.ResStrings[938], current17.Role.Name));
																	num566 = (int)((num2 * 263026471) ^ 0x3BEDFF8A);
																	continue;
																case 10u:
																{
																	BuffInstance buff33 = new BuffInstance
																	{
																		buff = new Buff
																		{
																			Name = ResourceStrings.ResStrings[531],
																			Level = 0
																		},
																		Owner = current17,
																		LeftRound = 2
																	};
																	int num567;
																	int num568;
																	if (current17.AddBuffOnly(buff33))
																	{
																		num567 = 306333664;
																		num568 = num567;
																	}
																	else
																	{
																		num567 = 202641721;
																		num568 = num567;
																	}
																	num566 = num567 ^ ((int)num2 * -2048689756);
																	continue;
																}
																default:
																	goto end_IL_a674;
																}
																if (current17.Buffs.Count != 0)
																{
																	num566 = ((int)num2 * -1863974036) ^ -2034767793;
																	continue;
																}
																goto IL_a98b;
																IL_a777:
																if (current17.Team != sourceSprite.Team)
																{
																	num566 = ((int)num2 * -1166442828) ^ -767993484;
																	continue;
																}
																goto IL_a98b;
																IL_a6d6:
																if (current17.Buffs != null)
																{
																	num566 = 9282060;
																	continue;
																}
																goto IL_a98b;
																continue;
																end_IL_a5da:
																break;
															}
															continue;
															end_IL_a674:
															break;
														}
														using (List<BuffInstance>.Enumerator enumerator5 = current17.Buffs.GetEnumerator())
														{
															while (true)
															{
																IL_a878:
																int num571;
																int num572;
																if (enumerator5.MoveNext())
																{
																	num571 = 1305408076;
																	num572 = num571;
																}
																else
																{
																	num571 = 596995103;
																	num572 = num571;
																}
																while (true)
																{
																	switch ((num2 = (uint)(num571 ^ 0x69C4C43D)) % 6)
																	{
																	case 5u:
																		num571 = 1305408076;
																		continue;
																	default:
																		goto end_IL_a84e;
																	case 4u:
																		break;
																	case 1u:
																	{
																		int num573;
																		int num574;
																		if (!current18.IsDebuff)
																		{
																			num573 = -164491137;
																			num574 = num573;
																		}
																		else
																		{
																			num573 = -678570169;
																			num574 = num573;
																		}
																		num571 = num573 ^ ((int)num2 * -1092635642);
																		continue;
																	}
																	case 2u:
																		list5.Add(current18);
																		num571 = (int)(num2 * 1682517768) ^ -1304823119;
																		continue;
																	case 3u:
																		current18 = enumerator5.Current;
																		num571 = 763796864;
																		continue;
																	case 0u:
																		goto end_IL_a84e;
																	}
																	goto IL_a878;
																	continue;
																	end_IL_a84e:
																	break;
																}
																break;
															}
														}
														if (current17.Buffs.Count == list5.Count)
														{
															continue;
														}
														goto IL_a909;
													}
													int num575 = 334178346;
													goto IL_a90e;
													IL_a909:
													num575 = 606628679;
													goto IL_a90e;
													IL_a90e:
													while (true)
													{
														switch ((num2 = (uint)(num575 ^ 0x69C4C43D)) % 6)
														{
														case 0u:
															break;
														default:
															goto end_IL_a98b;
														case 4u:
															current17.Buffs.Clear();
															current17.Buffs = list5;
															num575 = (int)((num2 * 1478475046) ^ 0x6F206841);
															continue;
														case 2u:
															current17.Set_needRefresh();
															num575 = ((int)num2 * -1673525541) ^ -2007212480;
															continue;
														case 3u:
															current17.RefreshBuffsInvoke();
															num575 = (int)((num2 * 1151525703) ^ 0x57FBE091);
															continue;
														case 1u:
															goto IL_a98b;
														case 5u:
															goto end_IL_a98b;
														}
														break;
													}
													goto IL_a909;
													continue;
													end_IL_a98b:
													break;
												}
											}
											finally
											{
												if (enumerator != null)
												{
													while (true)
													{
														IL_a9a7:
														int num576 = 1106664418;
														while (true)
														{
															switch ((num2 = (uint)(num576 ^ 0x69C4C43D)) % 3)
															{
															case 2u:
																break;
															default:
																goto end_IL_a9ac;
															case 1u:
																goto IL_a9ca;
															case 0u:
																goto end_IL_a9ac;
															}
															goto IL_a9a7;
															IL_a9ca:
															enumerator.Dispose();
															num576 = ((int)num2 * -579391921) ^ 0x3C6B20F5;
															continue;
															end_IL_a9ac:
															break;
														}
														break;
													}
												}
											}
											return attackResult;
										}
										}
										break;
										IL_a55d:
										num565 = 210855188;
									}
								}
								while (true)
								{
									int num577;
									int num578;
									if (!(name == ResourceStrings.ResStrings[605]))
									{
										num577 = 1833734045;
										num578 = num577;
									}
									else
									{
										num577 = 1368727742;
										num578 = num577;
									}
									while (true)
									{
										int num596;
										int num592;
										switch ((num2 = (uint)(num577 ^ 0x69C4C43D)) % 40)
										{
										case 8u:
											num577 = 1381919344;
											continue;
										case 37u:
											sourceSprite.RefreshBuffsInvoke();
											num577 = ((int)num2 * -440419731) ^ 0x3F7223D8;
											continue;
										case 17u:
											num590 = sourceSprite.X - targetSprite.X;
											num577 = (int)(num2 * 699997898) ^ -1000587283;
											continue;
										case 38u:
											num582 = targetSprite.Y + num598;
											num577 = ((int)num2 * -686849338) ^ 0x39EF3057;
											continue;
										case 36u:
										{
											int num603;
											int num604;
											if (!bf.AI.IsEmptyBlock(x2, y))
											{
												num603 = -48085354;
												num604 = num603;
											}
											else
											{
												num603 = -1277627106;
												num604 = num603;
											}
											num577 = num603 ^ ((int)num2 * -941333325);
											continue;
										}
										case 3u:
										{
											int num585;
											if (!(name == ResourceStrings.ResStrings[616]))
											{
												num577 = 1345904852;
												num585 = num577;
											}
											else
											{
												num577 = 1169787340;
												num585 = num577;
											}
											continue;
										}
										case 1u:
											attackResult.Hp += Tools.GetRandomInt(num589 * 100, num589 * 500);
											return attackResult;
										case 26u:
											num594 = targetSprite.Y;
											num577 = ((int)num2 * -803774971) ^ 0x67FA7A6A;
											continue;
										case 2u:
										{
											int num602;
											if (num593 != targetSprite.X)
											{
												num577 = 1728525900;
												num602 = num577;
											}
											else
											{
												num577 = 955067148;
												num602 = num577;
											}
											continue;
										}
										case 11u:
											attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[940], 1f, skill.AttackTime);
											attackResult.Hp = 0;
											buff34 = new Buff();
											num577 = (int)(num2 * 542728735) ^ -1116010609;
											continue;
										case 0u:
										{
											int num597;
											if (name == ResourceStrings.ResStrings[615])
											{
												num577 = 242669467;
												num597 = num577;
											}
											else
											{
												num577 = 1424728142;
												num597 = num577;
											}
											continue;
										}
										case 22u:
											num589++;
											num577 = (int)((num2 * 1550267962) ^ 0x7A60ECB2);
											continue;
										case 9u:
											targetSprite.SetPosWithAnimation(num593, num594, 0.05f, 3, skill.Animation);
											num577 = 720177879;
											continue;
										case 20u:
											sourceSprite.FaceRight = false;
											num577 = ((int)num2 * -747688166) ^ -1830053598;
											continue;
										case 14u:
										{
											int num583;
											int num584;
											if (!aI.IsEmptyBlock(num581, num582))
											{
												num583 = 99619425;
												num584 = num583;
											}
											else
											{
												num583 = 173817341;
												num584 = num583;
											}
											num577 = num583 ^ ((int)num2 * -1202002639);
											continue;
										}
										case 12u:
											return attackResult;
										case 5u:
										{
											int num605;
											int num606;
											if (num579 < 0)
											{
												num605 = -1787661140;
												num606 = num605;
											}
											else
											{
												num605 = -597463252;
												num606 = num605;
											}
											num577 = num605 ^ (int)(num2 * 2089106865);
											continue;
										}
										case 35u:
											num593 = num581;
											num577 = (int)(num2 * 1956381357) ^ -2124355670;
											continue;
										case 30u:
											sourceSprite.FaceRight = true;
											num577 = (int)((num2 * 1495843593) ^ 0x53A9AB64);
											continue;
										case 25u:
										{
											int num600;
											int num601;
											if (num594 == targetSprite.Y)
											{
												num600 = -506085572;
												num601 = num600;
											}
											else
											{
												num600 = -1702889649;
												num601 = num600;
											}
											num577 = num600 ^ (int)(num2 * 1245687411);
											continue;
										}
										case 29u:
											break;
										case 4u:
										{
											int num599 = sourceSprite.Y - targetSprite.Y;
											x2 = sourceSprite.X + num579;
											y = sourceSprite.Y + num599;
											num577 = ((int)num2 * -878741708) ^ -1415888439;
											continue;
										}
										case 34u:
											num595 = sourceSprite.Y - targetSprite.Y;
											num593 = targetSprite.X;
											num577 = ((int)num2 * -1316630655) ^ 0x6681B9DD;
											continue;
										case 10u:
											targetSprite.SetPosWithAnimation(num593, num594, 0.05f, 3);
											num577 = 1939629788;
											continue;
										case 39u:
											buff34.Name = ResourceStrings.ResStrings[541];
											num577 = (int)(num2 * 847810625) ^ -981962774;
											continue;
										case 19u:
											num596 = 0;
											goto IL_ae02;
										case 13u:
											num589 = 1;
											num577 = (int)(num2 * 630325282) ^ -1062393192;
											continue;
										case 6u:
											num579 = sourceSprite.X - targetSprite.X;
											num577 = (int)((num2 * 1867043730) ^ 0x7384875D);
											continue;
										case 21u:
											num592 = 0;
											goto IL_ae4f;
										case 32u:
											num594 = num582;
											num577 = (int)(num2 * 2039289149) ^ -1699503155;
											continue;
										case 31u:
											targetSprite.SetPosWithAnimation(x2, y, 0.1f, 3, skill.Animation);
											num577 = ((int)num2 * -1440782012) ^ 0x4CA880CC;
											continue;
										case 27u:
											if (num590 != 0)
											{
												num592 = -num590 * num589;
												goto IL_ae4f;
											}
											num577 = 519906624;
											continue;
										case 24u:
											num577 = (int)((num2 * 437163326) ^ 0x5D4F9A56);
											continue;
										case 7u:
										{
											int num591 = Math.Abs(role.AttributesFinal[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(701808387u)] - role2.AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3406067330u)]);
											attackResult.Hp += Tools.GetRandomInt(num591 * 5, num591 * 20);
											return attackResult;
										}
										case 16u:
										{
											buff34.Level = 0;
											buff34.Round = 3;
											buff34.Property = 100;
											BuffInstance buff35 = new BuffInstance
											{
												buff = buff34,
												Owner = sourceSprite,
												LeftRound = buff34.Round
											};
											int num587;
											int num588;
											if (!sourceSprite.AddBuffOnly(buff35))
											{
												num587 = 1999446073;
												num588 = num587;
											}
											else
											{
												num587 = 1742208056;
												num588 = num587;
											}
											num577 = num587 ^ (int)(num2 * 1657547406);
											continue;
										}
										case 15u:
											num581 = targetSprite.X + num586;
											num577 = (int)(num2 * 2141613092) ^ -1460507177;
											continue;
										case 18u:
											num577 = ((int)num2 * -1421798179) ^ 0x65378EDE;
											continue;
										case 23u:
											aI = bf.AI;
											num577 = (int)((num2 * 1689546505) ^ 0x66D57E31);
											continue;
										case 28u:
										{
											int num580;
											if (num579 <= 0)
											{
												num577 = 1187479258;
												num580 = num577;
											}
											else
											{
												num577 = 1337042291;
												num580 = num577;
											}
											continue;
										}
										default:
											{
												return LuaManager.Call<AttackResult>(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2121605349u), new object[5] { attackResult, skill, sourceSprite, targetSprite, bf });
											}
											IL_ae4f:
											num586 = num592;
											if (num595 != 0)
											{
												num596 = -num595 * num589;
												goto IL_ae02;
											}
											num577 = 70349654;
											continue;
											IL_ae02:
											num598 = num596;
											num577 = 542297034;
											continue;
										}
										break;
									}
								}
							case 8u:
								num539 = (int)((double)targetSprite.MaxHp * num540 * Tools.GetRandom(1.0, 1.2)) + 1000;
								num528 = (int)((num2 * 262019182) ^ 0x21547E67);
								continue;
							default:
							{
								attackResult.AddCastInfo2(sourceSprite, ResourceStrings.ResStrings[930], 1f, skill.AttackTime);
								IEnumerator<BattleSprite> enumerator = bf.Sprites.GetEnumerator();
								try
								{
									while (true)
									{
										IL_9b04:
										int num530;
										int num531;
										if (!enumerator.MoveNext())
										{
											num530 = 1321019459;
											num531 = num530;
										}
										else
										{
											num530 = 1407402763;
											num531 = num530;
										}
										while (true)
										{
											switch ((num2 = (uint)(num530 ^ 0x69C4C43D)) % 13)
											{
											case 7u:
												num530 = 1407402763;
												continue;
											default:
												goto end_IL_99f8;
											case 3u:
												buff27 = new Buff();
												buff27.Name = ResourceStrings.ResStrings[524];
												num530 = (int)(num2 * 1819160931) ^ -2064276190;
												continue;
											case 4u:
												attackResult.AddAttackInfo2(current11, ResourceStrings.ResStrings[931], Color.red, skill.AttackTime);
												bf.ShowSkillAnimation(skill, current11.X, current11.Y, null);
												num530 = (int)((num2 * 1963197945) ^ 0x1E401716);
												continue;
											case 11u:
												current11.RefreshBuffsInvoke();
												num530 = ((int)num2 * -200954753) ^ 0x3852028E;
												continue;
											case 9u:
											{
												int num534;
												int num535;
												if (current11.Team != sourceSprite.Team)
												{
													num534 = 1696056339;
													num535 = num534;
												}
												else
												{
													num534 = 1128898842;
													num535 = num534;
												}
												num530 = num534 ^ ((int)num2 * -958933230);
												continue;
											}
											case 2u:
												break;
											case 12u:
												Log(string.Format(ResourceStrings.ResStrings[932], current11.Role.Name));
												num530 = ((int)num2 * -317341989) ^ -1061088387;
												continue;
											case 5u:
												buff27.Level = 5;
												num530 = (int)((num2 * 1540759420) ^ 0xCC3CF60);
												continue;
											case 10u:
											{
												int num532;
												int num533;
												if (!current11.AddBuffOnly(buff28))
												{
													num532 = -1580537173;
													num533 = num532;
												}
												else
												{
													num532 = -1637680395;
													num533 = num532;
												}
												num530 = num532 ^ (int)(num2 * 1741020977);
												continue;
											}
											case 1u:
												current11 = enumerator.Current;
												num530 = 2116220876;
												continue;
											case 6u:
												buff28 = new BuffInstance
												{
													buff = buff27,
													Owner = current11,
													LeftRound = buff27.Round
												};
												num530 = (int)((num2 * 357133590) ^ 0xD3539CB);
												continue;
											case 8u:
												buff27.Round = 3;
												num530 = (int)((num2 * 1473777488) ^ 0x38FC1287);
												continue;
											case 0u:
												goto end_IL_99f8;
											}
											goto IL_9b04;
											continue;
											end_IL_99f8:
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
											IL_9c07:
											int num536 = 1314782098;
											while (true)
											{
												switch ((num2 = (uint)(num536 ^ 0x69C4C43D)) % 3)
												{
												case 0u:
													break;
												default:
													goto end_IL_9c0c;
												case 1u:
													goto IL_9c2a;
												case 2u:
													goto end_IL_9c0c;
												}
												goto IL_9c07;
												IL_9c2a:
												enumerator.Dispose();
												num536 = ((int)num2 * -1942331926) ^ -782991378;
												continue;
												end_IL_9c0c:
												break;
											}
											break;
										}
									}
								}
								return attackResult;
							}
							}
							break;
						}
					}
					IL_7ea0:
					num488 = 87248387;
					goto IL_7ea5;
					IL_75ed:
					attackResult.Critical = true;
					num338 = 541872955;
					goto IL_5962;
					IL_1c79:
					num100 = 1484059989;
					goto IL_1c7e;
					IL_0f9c:
					num28 = num314;
					num = 934074405;
					continue;
					IL_1281:
					num51 = role.AttributesFinal[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1269723935u)];
					num = 1294086102;
					continue;
					IL_1098:
					num51 = role.AttributesFinal[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3535376985u)];
					num = 1294086102;
					continue;
					IL_0a1b:
					num = ((int)num2 * -45819943) ^ 0x19E1769C;
					continue;
					IL_092a:
					num28 = num47;
					if (num28 < -0.9999)
					{
						num = 591819896;
						num623 = num;
					}
					else
					{
						num = 554795036;
						num623 = num;
					}
					continue;
					IL_03fa:
					num51 = role.AttributesFinal[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2223184606u)];
					num = 1294086102;
					continue;
					IL_0447:
					num46 = num315;
					num28 = 0.0;
					num = 434915159;
					continue;
				}
				break;
			}
		}
	}

	public static double defenceDescAttack(double defence)
	{
		if (CommonSettings.MOD_KEY() == 1)
		{
			goto IL_0008;
		}
		goto IL_0064;
		IL_0008:
		int num = 294437350;
		goto IL_000d;
		IL_000d:
		uint num2;
		switch ((num2 = (uint)(num ^ 0x54535245)) % 5)
		{
		case 4u:
			break;
		case 2u:
			return 1.0 - 1.0 / (defence / 6000.0);
		case 3u:
			goto IL_0064;
		case 1u:
			return 0.9 - _200C_200E_200C_202A_206B_206E_200F_200C_200B_206B_202D_200C_200B_206B_202A_202A_206F_206F_200B_202C_202D_200F_202C_206D_202B_206C_202A_202E_206D_206A_200E_202B_200B_202E_206A_202D_206A_200D_202A_206C_202E(0.9, 0.007 * (defence + 100.0));
		default:
			return 0.9 - _200C_200E_200C_202A_206B_206E_200F_200C_200B_206B_202D_200C_200B_206B_202A_202A_206F_206F_200B_202C_202D_200F_202C_206D_202B_206C_202A_202E_206D_206A_200E_202B_200B_202E_206A_202D_206A_200D_202A_206C_202E(0.9, 0.02 * (defence + 50.0));
		}
		goto IL_0008;
		IL_0064:
		int num3;
		if (CommonSettings.MOD_KEY() == 2)
		{
			num = 704887001;
			num3 = num;
		}
		else
		{
			num = 893922874;
			num3 = num;
		}
		goto IL_000d;
	}

	public static double defenceDescAttack2(double defence)
	{
		if (CommonSettings.MOD_KEY() == 1)
		{
			goto IL_0008;
		}
		goto IL_006e;
		IL_0008:
		int num = 1760001525;
		goto IL_000d;
		IL_000d:
		uint num2;
		switch ((num2 = (uint)(num ^ 0x4CFF99A)) % 5)
		{
		case 2u:
			break;
		case 4u:
			return _206E_206E_206B_206C_200B_202D_202C_202B_202E_200B_200C_206B_206D_202B_200E_200B_200C_206D_206C_206E_206B_200E_200F_202E_202C_202C_200D_200D_206A_206F_200C_206E_206B_202A_206C_200D_202B_206D_200E_202E_202E(defence / 25000.0, 0.1 - (double)(Round - 1) * 0.0002);
		case 0u:
			goto IL_006e;
		case 1u:
			return 0.0;
		default:
			return _206E_206E_206B_206C_200B_202D_202C_202B_202E_200B_200C_206B_206D_202B_200E_200B_200C_206D_206C_206E_206B_200E_200F_202E_202C_202C_200D_200D_206A_206F_200C_206E_206B_202A_206C_200D_202B_206D_200E_202E_202E(defence / (120000.0 - 30000.0 / (double)Round), 0.1 - (double)(Round - 1) * 0.0004);
		}
		goto IL_0008;
		IL_006e:
		int num3;
		if (CommonSettings.MOD_KEY() == 2)
		{
			num = 150655379;
			num3 = num;
		}
		else
		{
			num = 334363282;
			num3 = num;
		}
		goto IL_000d;
	}

	public static AttackResult GetAttackResult_AttackAnalog(SkillBox skill, BattleSprite sourceSprite, BattleSprite targetSprite, BattleField bf)
	{
		Role role = sourceSprite.Role;
		Role role2 = targetSprite.Role;
		AttackResult attackResult = new AttackResult();
		int num88 = default(int);
		double random = default(double);
		string name = default(string);
		InternalSkillInstance equippedInternalSkill = default(InternalSkillInstance);
		float num22 = default(float);
		float num121 = default(float);
		double num29 = default(double);
		double num12 = default(double);
		float num13 = default(float);
		int num60 = default(int);
		double num19 = default(double);
		int num18 = default(int);
		int type = default(int);
		bool flag2 = default(bool);
		double num34 = default(double);
		double num66 = default(double);
		double num3 = default(double);
		bool flag = default(bool);
		double num25 = default(double);
		double num26 = default(double);
		AttackFormula attackFormula = default(AttackFormula);
		int num9 = default(int);
		int num10 = default(int);
		string name2 = default(string);
		double num35 = default(double);
		int num39 = default(int);
		int num79 = default(int);
		double criticalValue = default(double);
		double num87 = default(double);
		int num52 = default(int);
		double num89 = default(double);
		int num65 = default(int);
		BattleAI aI = default(BattleAI);
		int x = default(int);
		int num56 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 733269260;
			while (true)
			{
				uint num2;
				double num144;
				double num142;
				float num93;
				int num53;
				double num8;
				int num38;
				int num201;
				switch ((num2 = (uint)(num ^ 0x21799004)) % 302)
				{
				case 240u:
					break;
				case 109u:
					num88 = (int)((double)_202D_202D_206F_202B_202C_206D_206E_206D_200C_202A_206E_202D_202B_202C_206E_202D_202B_202D_202A_206F_206E_206A_200B_200F_202A_200B_206D_206C_202A_202B_202A_202A_206E_200D_206A_200C_206B_202B_206E_202A_202E(num88) / Tools.GetRandom(5.0, 5.0));
					num = 902172367;
					continue;
				case 287u:
					attackResult.Hp = (int)((double)sourceSprite.Hp * random);
					num = (int)(num2 * 1764044673) ^ -764482905;
					continue;
				case 63u:
					return attackResult;
				case 299u:
				{
					int num139;
					if (!role.BuiltInTalents[41])
					{
						num = 1078767416;
						num139 = num;
					}
					else
					{
						num = 104777823;
						num139 = num;
					}
					continue;
				}
				case 8u:
					num = ((int)num2 * -3193314) ^ -1646604217;
					continue;
				case 261u:
				{
					int num143;
					if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[1053]))
					{
						num = 2109283653;
						num143 = num;
					}
					else
					{
						num = 82026378;
						num143 = num;
					}
					continue;
				}
				case 244u:
					return attackResult;
				case 163u:
					num144 = _206D_200C_206E_200E_202D_200C_202B_206A_202E_202A_206C_200C_202E_200D_200C_202A_206F_202D_200C_202A_206A_202E_206C_202A_206F_206C_206F_206B_202B_202E_200B_200B_200E_206A_200F_202C_206F_200F_202C_206F_202E((float)equippedInternalSkill.YinBattle * num22, (float)equippedInternalSkill.YangBattle * num121) / 100f;
					goto IL_0641;
				case 134u:
					num29 = 1.0;
					num = (int)(num2 * 2081146168) ^ -1799281545;
					continue;
				case 188u:
					num12 *= (double)(1f + (equippedInternalSkill.AttackBattle + num13) * 0.1f);
					num = ((int)num2 * -1969660982) ^ 0x1C98D30E;
					continue;
				case 207u:
				{
					int num167;
					if (num60 != 1)
					{
						num = 1290766958;
						num167 = num;
					}
					else
					{
						num = 1094482465;
						num167 = num;
					}
					continue;
				}
				case 196u:
				{
					int num131;
					if (role.BuiltInTalents[72])
					{
						num = 944257749;
						num131 = num;
					}
					else
					{
						num = 686856394;
						num131 = num;
					}
					continue;
				}
				case 119u:
				{
					int num57;
					int num58;
					if (num19 >= -0.9999)
					{
						num57 = 224981752;
						num58 = num57;
					}
					else
					{
						num57 = 687946083;
						num58 = num57;
					}
					num = num57 ^ ((int)num2 * -1306923611);
					continue;
				}
				case 21u:
					num18 = role.AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1029863417u)];
					num = 724890373;
					continue;
				case 266u:
					attackResult.Hp = 200;
					return attackResult;
				case 84u:
				{
					int num7;
					if (type == 2)
					{
						num = 1639031933;
						num7 = num;
					}
					else
					{
						num = 799858743;
						num7 = num;
					}
					continue;
				}
				case 274u:
				{
					int num189;
					if (flag2)
					{
						num = 519375306;
						num189 = num;
					}
					else
					{
						num = 1972893571;
						num189 = num;
					}
					continue;
				}
				case 150u:
					num12 *= num34;
					num = (int)((num2 * 238916865) ^ 0x502981B6);
					continue;
				case 225u:
				{
					int num175;
					if (!NoZhenlongqiju)
					{
						num = 27341902;
						num175 = num;
					}
					else
					{
						num = 1225734612;
						num175 = num;
					}
					continue;
				}
				case 81u:
					num66 = _206E_206E_206B_206C_200B_202D_202C_202B_202E_200B_200C_206B_206D_202B_200E_200B_200C_206D_206C_206E_206B_200E_200F_202E_202C_202C_200D_200D_206A_206F_200C_206E_206B_202A_206C_200D_202B_206D_200E_202E_202E(0.3, (double)sourceSprite.Hp / (double)sourceSprite.MaxHp);
					num = ((int)num2 * -1436385022) ^ -269304235;
					continue;
				case 249u:
				{
					int num154;
					if (num3 >= 0.0)
					{
						num = 1051329823;
						num154 = num;
					}
					else
					{
						num = 1348586447;
						num154 = num;
					}
					continue;
				}
				case 48u:
					num = (int)((num2 * 1178705721) ^ 0x26D8CA50);
					continue;
				case 168u:
					num142 = _206D_200C_206E_200E_202D_200C_202B_206A_202E_202A_206C_200C_202E_200D_200C_202A_206F_202D_200C_202A_206A_202E_206C_202A_206F_206C_206F_206B_202B_202E_200B_200B_200E_206A_200F_202C_206F_200F_202C_206F_202E((float)equippedInternalSkill.YinBattle * num22, (float)equippedInternalSkill.YangBattle * num121) / 100f;
					goto IL_08a8;
				case 282u:
				{
					int num129;
					int num130;
					if (targetSprite.Team == sourceSprite.Team)
					{
						num129 = 570938082;
						num130 = num129;
					}
					else
					{
						num129 = 1821457941;
						num130 = num129;
					}
					num = num129 ^ (int)(num2 * 681349908);
					continue;
				}
				case 13u:
					flag = false;
					num = (int)((num2 * 1590793523) ^ 0x68993DDD);
					continue;
				case 67u:
					return null;
				case 128u:
					return attackResult;
				case 87u:
					return attackResult;
				case 39u:
					num = ((int)num2 * -159969978) ^ 0x30C360A2;
					continue;
				case 204u:
					num93 = 0f;
					goto IL_093f;
				case 242u:
					return attackResult;
				case 296u:
				{
					attackResult.Critical = true;
					int num72;
					if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[617]))
					{
						num = 809277684;
						num72 = num;
					}
					else
					{
						num = 1589250131;
						num72 = num;
					}
					continue;
				}
				case 212u:
					return attackResult;
				case 83u:
				{
					int num43;
					int num44;
					if ((double)role.AttributesFinal[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(788062007u)] / (double)role2.AttributesFinal[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2475589736u)] < 2.0)
					{
						num43 = 2038402918;
						num44 = num43;
					}
					else
					{
						num43 = 2109670361;
						num44 = num43;
					}
					num = num43 ^ ((int)num2 * -117736967);
					continue;
				}
				case 277u:
					goto IL_09f4;
				case 195u:
					num3 = 1.0;
					num = (int)(num2 * 906171369) ^ -86125629;
					continue;
				case 126u:
					attackResult.Hp = 100;
					num = (int)((num2 * 77883257) ^ 0x1D5162E3);
					continue;
				case 215u:
					num12 = (double)skill.PowerBattle * (2.0 + (double)num18 / 200.0) * 2.5 * _200C_200E_200C_202A_206B_206E_200F_200C_200B_206B_202D_200C_200B_206B_202A_202A_206F_206F_200B_202C_202D_200F_202C_206D_202B_206C_202A_202E_206D_206A_200E_202B_200B_202E_206A_202D_206A_200D_202A_206C_202E((double)role.AttributesFinal[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3665747899u)] + 50.0, 0.3) * (1.0 + num19);
					num25 = num12 * (double)(1f + (equippedInternalSkill.AttackBattle + num13));
					num = 693869974;
					continue;
				case 243u:
					num3 += 0.25;
					num = ((int)num2 * -44842454) ^ -1013503082;
					continue;
				case 247u:
					return attackResult;
				case 38u:
				{
					int num202;
					int num203;
					if (!role.HasEquipmentTalent(ResourceStrings.ResStrings[319]))
					{
						num202 = -293769188;
						num203 = num202;
					}
					else
					{
						num202 = -1454519658;
						num203 = num202;
					}
					num = num202 ^ ((int)num2 * -428324801);
					continue;
				}
				case 121u:
					attackResult.Hp = 0;
					num = 265684352;
					continue;
				case 197u:
					num26 = attackFormula.defence;
					num = (int)((num2 * 1186660341) ^ 0x4BDE242B);
					continue;
				case 232u:
				{
					int num192;
					if (!role.BuiltInTalents[134])
					{
						num = 1468858174;
						num192 = num;
					}
					else
					{
						num = 1229727708;
						num192 = num;
					}
					continue;
				}
				case 210u:
				{
					num25 += role.attackValue;
					int num181;
					int num182;
					if (type != 0)
					{
						num181 = 1363580317;
						num182 = num181;
					}
					else
					{
						num181 = 319941414;
						num182 = num181;
					}
					num = num181 ^ ((int)num2 * -1392494964);
					continue;
				}
				case 100u:
					return attackResult;
				case 236u:
				{
					int num171;
					if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[1051]))
					{
						num = 601410759;
						num171 = num;
					}
					else
					{
						num = 1782577372;
						num171 = num;
					}
					continue;
				}
				case 78u:
				{
					int num165;
					if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[629]))
					{
						num = 1241655839;
						num165 = num;
					}
					else
					{
						num = 2025274189;
						num165 = num;
					}
					continue;
				}
				case 291u:
					num9 = _200C_202C_200E_206D_202A_206B_202B_202B_202D_202B_206C_202D_202A_206A_206E_200C_200E_202E_206B_200F_206A_202E_200E_206E_206E_202C_200E_202B_202A_206D_202B_200B_202D_202D_202B_206A_202B_200F_202D_206F_202E(num9, (int)((double)num10 * 1.03));
					num = (int)(num2 * 1040113839) ^ -1589354923;
					continue;
				case 193u:
					attackFormula.attackUp = num25;
					num = (int)((num2 * 1509535846) ^ 0x3F6E1AE2);
					continue;
				case 91u:
				{
					int num153;
					if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[613]))
					{
						num = 509718221;
						num153 = num;
					}
					else
					{
						num = 1511197418;
						num153 = num;
					}
					continue;
				}
				case 211u:
				{
					int num151;
					if (!role.BuiltInTalents[205])
					{
						num = 1823741364;
						num151 = num;
					}
					else
					{
						num = 94417003;
						num151 = num;
					}
					continue;
				}
				case 137u:
					num3 = 0.999;
					num = (int)(num2 * 1921250175) ^ -1027442386;
					continue;
				case 159u:
					num25 = (double)skill.PowerBattle * 8.0 * (1.5 + (double)role.AttributesFinal[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3665747899u)] / 400.0) * (2.0 + (double)num18 / 800.0) * (1.0 + num19) * (1.0 + (double)(equippedInternalSkill.AttackBattle + num13));
					num = ((int)num2 * -1018719070) ^ -1635880788;
					continue;
				case 295u:
					attackResult.Hp = Tools.GetRandomInt(1000, 2000 + 100 * role.Level) + (int)((double)targetSprite.Hp * 0.1);
					num = (int)((num2 * 319860223) ^ 0x163A398B);
					continue;
				case 271u:
					num3 += 0.1;
					num = ((int)num2 * -789865592) ^ -319697230;
					continue;
				case 276u:
				{
					int num137;
					int num138;
					if (!_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[727]))
					{
						num137 = 1173609060;
						num138 = num137;
					}
					else
					{
						num137 = 571525110;
						num138 = num137;
					}
					num = num137 ^ ((int)num2 * -1885173552);
					continue;
				}
				case 118u:
				{
					int num126;
					if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name2, ResourceStrings.ResStrings[725]))
					{
						num = 2019508390;
						num126 = num;
					}
					else
					{
						num = 828607383;
						num126 = num;
					}
					continue;
				}
				case 57u:
					attackResult.Hp = 150;
					return attackResult;
				case 136u:
					flag = false;
					num = 1042724288;
					continue;
				case 267u:
				{
					int num109;
					int num110;
					if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[639]))
					{
						num109 = -1222850038;
						num110 = num109;
					}
					else
					{
						num109 = -1411529234;
						num110 = num109;
					}
					num = num109 ^ ((int)num2 * -1249726664);
					continue;
				}
				case 253u:
					num26 = role2.DefanceValue;
					num = 2147051584;
					continue;
				case 92u:
					num25 *= role.powerup_xianshuValue;
					num = (int)(num2 * 738284917) ^ -1923413216;
					continue;
				case 146u:
				{
					int num96;
					if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[620]))
					{
						num = 980749077;
						num96 = num;
					}
					else
					{
						num = 192159181;
						num96 = num;
					}
					continue;
				}
				case 16u:
					attackResult.Hp = (int)((float)role2.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1768687720u)] / 2f);
					return attackResult;
				case 269u:
					num19 = -0.9999;
					num = ((int)num2 * -351364850) ^ -490043013;
					continue;
				case 289u:
				{
					int num83;
					if (num60 != 0)
					{
						num = 1263918823;
						num83 = num;
					}
					else
					{
						num = 1013934443;
						num83 = num;
					}
					continue;
				}
				case 184u:
					attackResult.Hp = targetSprite.Hp;
					num = (int)((num2 * 96949539) ^ 0x34C43428);
					continue;
				case 148u:
				{
					int num78;
					if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[1052]))
					{
						num = 645450612;
						num78 = num;
					}
					else
					{
						num = 1738169879;
						num78 = num;
					}
					continue;
				}
				case 177u:
				{
					int num73;
					if (!role.BuiltInTalents[36])
					{
						num = 1414757827;
						num73 = num;
					}
					else
					{
						num = 1219983165;
						num73 = num;
					}
					continue;
				}
				case 107u:
				{
					int num61;
					if (num60 != 1)
					{
						num = 1944535750;
						num61 = num;
					}
					else
					{
						num = 1957949539;
						num61 = num;
					}
					continue;
				}
				case 11u:
					attackResult.Hp = sourceSprite.MaxHp / 2;
					num = (int)(num2 * 1127695433) ^ -1279439435;
					continue;
				case 24u:
					attackResult.Hp = 0;
					num = 601885427;
					continue;
				case 297u:
				{
					int num48;
					if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[1054]))
					{
						num = 1660775767;
						num48 = num;
					}
					else
					{
						num = 1152252373;
						num48 = num;
					}
					continue;
				}
				case 140u:
					attackResult.Hp = 0;
					num = 72799460;
					continue;
				case 102u:
				{
					int num32;
					int num33;
					if (role.BuiltInTalents[203])
					{
						num32 = -683961888;
						num33 = num32;
					}
					else
					{
						num32 = -418643500;
						num33 = num32;
					}
					num = num32 ^ ((int)num2 * -1432787333);
					continue;
				}
				case 151u:
					attackResult.costBall = targetSprite.Balls;
					return attackResult;
				case 69u:
				{
					int num14;
					int num15;
					if (role.BuiltInTalents[58])
					{
						num14 = 1678054463;
						num15 = num14;
					}
					else
					{
						num14 = 1129936887;
						num15 = num14;
					}
					num = num14 ^ ((int)num2 * -1868972773);
					continue;
				}
				case 110u:
					num12 *= (double)(1f + (equippedInternalSkill.AttackBattle + num13) * 0.2f);
					num = 214070711;
					continue;
				case 74u:
					if (skill.Tiaohe)
					{
						num = 652384828;
						continue;
					}
					num142 = ((!(skill.Suit <= 0f)) ? ((double)(skill.Suit * (float)equippedInternalSkill.YangBattle / 100f)) : ((0f + skill.Suit >= 0f) ? 0.0 : ((0.0 - (double)skill.Suit) * (double)(float)equippedInternalSkill.YinBattle / 100.0)));
					goto IL_08a8;
				case 171u:
					num25 *= 1.08;
					num3 += 0.05;
					num = (int)((num2 * 1610377450) ^ 0x6E0163FB);
					continue;
				case 176u:
					flag = false;
					num = 1914914556;
					continue;
				case 30u:
					num3 += 0.25;
					num = ((int)num2 * -1814255858) ^ -2133514639;
					continue;
				case 166u:
					return attackResult;
				case 248u:
				{
					int num190;
					int num191;
					if (targetSprite.Team != sourceSprite.Team)
					{
						num190 = 300541096;
						num191 = num190;
					}
					else
					{
						num190 = 551145795;
						num191 = num190;
					}
					num = num190 ^ (int)(num2 * 1204703542);
					continue;
				}
				case 88u:
				{
					int num185;
					int num186;
					if (skill.SkillType == SkillType.Normal)
					{
						num185 = -1266479530;
						num186 = num185;
					}
					else
					{
						num185 = -2032127906;
						num186 = num185;
					}
					num = num185 ^ ((int)num2 * -107177128);
					continue;
				}
				case 203u:
				{
					int num178;
					int num179;
					if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[637]))
					{
						num178 = 1116302597;
						num179 = num178;
					}
					else
					{
						num178 = 995152241;
						num179 = num178;
					}
					num = num178 ^ ((int)num2 * -1980770563);
					continue;
				}
				case 259u:
					num35 = 1.0 + ZHOUMU_DEFENCE_ADD * (double)(Round - 1);
					num = (int)(num2 * 886033589) ^ -817924179;
					continue;
				case 167u:
				{
					int num174;
					if (role2.Difficulty <= 0.0)
					{
						num = 27341902;
						num174 = num;
					}
					else
					{
						num = 1833704917;
						num174 = num;
					}
					continue;
				}
				case 18u:
					num12 *= 1.4;
					num = (int)((num2 * 1713758410) ^ 0x6F85954E);
					continue;
				case 190u:
				{
					int num169;
					if (_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[636]))
					{
						num = 1413695012;
						num169 = num;
					}
					else
					{
						num = 1468858174;
						num169 = num;
					}
					continue;
				}
				case 169u:
					attackFormula.attackLow = num12;
					num = 609138055;
					continue;
				case 28u:
					num19 = -0.9999;
					num = ((int)num2 * -837598356) ^ -1453911046;
					continue;
				case 122u:
				{
					int num164;
					if (!role.BuiltInTalents[44])
					{
						num = 317241962;
						num164 = num;
					}
					else
					{
						num = 252537447;
						num164 = num;
					}
					continue;
				}
				case 29u:
					attackResult.Hp = _200E_200F_206F_200E_200C_206D_200F_202C_206E_206E_202C_200F_202E_202C_202D_206A_200E_206F_200E_200D_206C_202B_200C_206C_200B_200E_206D_206A_200C_206B_200D_206C_200C_202A_200E_202D_200D_200F_200B_206B_202E(RuntimeData.Instance.Money, 100000);
					num = (int)(num2 * 1986653406) ^ -686683571;
					continue;
				case 27u:
				{
					int num160;
					int num161;
					if (targetSprite.Team == sourceSprite.Team)
					{
						num160 = 5291272;
						num161 = num160;
					}
					else
					{
						num160 = 308093598;
						num161 = num160;
					}
					num = num160 ^ (int)(num2 * 526050132);
					continue;
				}
				case 238u:
					num = ((int)num2 * -1617878562) ^ -1135205476;
					continue;
				case 129u:
					num10 = _200C_202C_200E_206D_202A_206B_202B_202B_202D_202B_206C_202D_202A_206A_206E_200C_200E_202E_206B_200F_206A_202E_200E_206E_206E_202C_200E_202B_202A_206D_202B_200B_202D_202D_202B_206A_202B_200F_202D_206F_202E(num10, (int)((double)num9 * 1.03));
					num = ((int)num2 * -419180053) ^ 0x4FF91A91;
					continue;
				case 301u:
					goto IL_1389;
				case 209u:
					num10 = equippedInternalSkill.YinBattle;
					num = ((int)num2 * -1203225160) ^ 0x43363476;
					continue;
				case 116u:
				{
					int num149;
					int num150;
					if (targetSprite.Team == sourceSprite.Team)
					{
						num149 = -5290137;
						num150 = num149;
					}
					else
					{
						num149 = -3762786;
						num150 = num149;
					}
					num = num149 ^ (int)(num2 * 1701757274);
					continue;
				}
				case 4u:
				{
					int num148;
					if (type == 5)
					{
						num = 265993974;
						num148 = num;
					}
					else
					{
						num = 1454993293;
						num148 = num;
					}
					continue;
				}
				case 172u:
					if (skill.Tiaohe)
					{
						num = (int)((num2 * 1910022372) ^ 0x30AC03BF);
						continue;
					}
					num144 = ((!(skill.Suit <= 0f)) ? ((double)(skill.Suit * (float)equippedInternalSkill.YangBattle / 100f)) : ((0f + skill.Suit >= 0f) ? 0.0 : ((0.0 - (double)skill.Suit) * (double)(float)equippedInternalSkill.YinBattle / 100.0)));
					goto IL_0641;
				case 241u:
				{
					int num135;
					if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[619]))
					{
						num = 1141934221;
						num135 = num;
					}
					else
					{
						num = 444086590;
						num135 = num;
					}
					continue;
				}
				case 117u:
					equippedInternalSkill = role.EquippedInternalSkill;
					num = 808062673;
					continue;
				case 262u:
					num12 *= role.powerup_qimenValue;
					num25 *= role.powerup_qimenValue;
					num = (int)((num2 * 349811360) ^ 0x76FA63D4);
					continue;
				case 198u:
					return attackResult;
				case 101u:
				{
					int num132;
					if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[1057]))
					{
						num = 569213008;
						num132 = num;
					}
					else
					{
						num = 1263918823;
						num132 = num;
					}
					continue;
				}
				case 65u:
				{
					int num124;
					if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[627]))
					{
						num = 362669897;
						num124 = num;
					}
					else
					{
						num = 1054000538;
						num124 = num;
					}
					continue;
				}
				case 46u:
					num39++;
					num = (int)(num2 * 488185757) ^ -1868996054;
					continue;
				case 154u:
					num25 *= 1.4;
					num = (int)((num2 * 1605853723) ^ 0x7A1EE314);
					continue;
				case 75u:
					num88 = role.AttributesFinal[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2475589736u)] - role2.AttributesFinal[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(788062007u)];
					num = (int)((num2 * 901611303) ^ 0x1C56CF3F);
					continue;
				case 96u:
					num12 = (double)skill.PowerBattle * 8.0 * (1.2 + (double)role.AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3795453722u)] / 500.0) * (1.0 + (double)num18 / 350.0) * (1.0 + num19) * (1.0 + (double)(equippedInternalSkill.AttackBattle + num13) * 0.5);
					num25 = (double)skill.PowerBattle * 8.0 * (1.2 + (double)role.AttributesFinal[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(655417903u)] / 500.0) * (1.0 + (double)num18 / 350.0) * (1.0 + num19) * (1.0 + (double)(equippedInternalSkill.AttackBattle + num13));
					num = 2140156395;
					continue;
				case 51u:
					num121 = (float)_200E_200F_206F_200E_200C_206D_200F_202C_206E_206E_202C_200F_202E_202C_202D_206A_200E_206F_200E_200D_206C_202B_200C_206C_200B_200E_206D_206A_200C_206B_200D_206C_200C_202A_200E_202D_200D_200F_200B_206B_202E(999, (int)skill.TiaoheScale) / 100f;
					num = (int)(num2 * 1083681710) ^ -1375593635;
					continue;
				case 64u:
					num3 = 0.0;
					num = (int)((num2 * 865267209) ^ 0x1562615C);
					continue;
				case 99u:
					num26 *= role2.Difficulty;
					num = (int)(num2 * 1854474489) ^ -1762720033;
					continue;
				case 221u:
					return attackResult;
				case 34u:
					num34 = 1.0 + ZHOUMU_ATTACK_ADD * (double)(Round - 1);
					num = (int)(num2 * 2044731675) ^ -316281059;
					continue;
				case 125u:
				{
					int num115;
					int num116;
					if (role2.Difficulty == 1.0)
					{
						num115 = 368244981;
						num116 = num115;
					}
					else
					{
						num115 = 1457121510;
						num116 = num115;
					}
					num = num115 ^ (int)(num2 * 1542772939);
					continue;
				}
				case 273u:
					attackResult.Hp += Tools.GetRandomInt(num79 * 5, num79 * 20);
					num = ((int)num2 * -744478327) ^ -1492989648;
					continue;
				case 182u:
				{
					int num107;
					int num108;
					if (role.Difficulty == 1.0)
					{
						num107 = -1543996319;
						num108 = num107;
					}
					else
					{
						num107 = -821268738;
						num108 = num107;
					}
					num = num107 ^ (int)(num2 * 1765612127);
					continue;
				}
				case 41u:
					num19 = 0.0;
					num = (int)(num2 * 2045659319) ^ -862743529;
					continue;
				case 26u:
					attackResult.Hp = _200C_202C_200E_206D_202A_206B_202B_202B_202D_202B_206C_202D_202A_206A_206E_200C_200E_202E_206B_200F_206A_202E_200E_206E_206E_202C_200E_202B_202A_206D_202B_200B_202D_202D_202B_206A_202B_200F_202D_206F_202E(1, targetSprite.MaxHp);
					num = ((int)num2 * -1173423651) ^ 0x3E38D7FE;
					continue;
				case 108u:
				{
					int num101;
					int num102;
					if (num88 > 0)
					{
						num101 = -2043277288;
						num102 = num101;
					}
					else
					{
						num101 = -906624955;
						num102 = num101;
					}
					num = num101 ^ (int)(num2 * 2089561748);
					continue;
				}
				case 231u:
					return attackResult;
				case 175u:
					attackResult.Hp = _200E_200F_206F_200E_200C_206D_200F_202C_206E_206E_202C_200F_202E_202C_202D_206A_200E_206F_200E_200D_206C_202B_200C_206C_200B_200E_206D_206A_200C_206B_200D_206C_200C_202A_200E_202D_200D_200F_200B_206B_202E(RuntimeData.Instance.Money, 10000);
					num = ((int)num2 * -1693812862) ^ 0x64937F13;
					continue;
				case 72u:
					attackResult.Hp = 200;
					num = ((int)num2 * -1999349877) ^ 0x7C938DD6;
					continue;
				case 105u:
					attackResult.Hp = (int)((num12 + num25) / 2.0 * (1.0 + num3 * criticalValue) * (1.0 - num87));
					attackResult.Hp = ((attackResult.Hp > 0) ? attackResult.Hp : 0);
					num = 1875680154;
					continue;
				case 35u:
					num = (int)(num2 * 2018208780) ^ -1999777696;
					continue;
				case 254u:
					num22 = 1f;
					num = ((int)num2 * -1974130955) ^ -1737953676;
					continue;
				case 223u:
				{
					int num92;
					if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[625]))
					{
						num = 1160739200;
						num92 = num;
					}
					else
					{
						num = 708700091;
						num92 = num;
					}
					continue;
				}
				case 42u:
					attackFormula.criticalHit = num3;
					num = (int)(num2 * 1149519109) ^ -1246369250;
					continue;
				case 50u:
					return attackResult;
				case 138u:
					num3 = 1.0;
					num = ((int)num2 * -1655380362) ^ 0x1467026;
					continue;
				case 115u:
				{
					int num84;
					int num85;
					if (_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[719]))
					{
						num84 = -569643518;
						num85 = num84;
					}
					else
					{
						num84 = -174739790;
						num85 = num84;
					}
					num = num84 ^ (int)(num2 * 1065512135);
					continue;
				}
				case 153u:
				{
					int num76;
					int num77;
					if (_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[693]))
					{
						num76 = 784345647;
						num77 = num76;
					}
					else
					{
						num76 = 1399409408;
						num77 = num76;
					}
					num = num76 ^ ((int)num2 * -1875421782);
					continue;
				}
				case 284u:
					num79 = _202D_202D_206F_202B_202C_206D_206E_206D_200C_202A_206E_202D_202B_202C_206E_202D_202B_202D_202A_206F_206E_206A_200B_200F_202A_200B_206D_206C_202A_202B_202A_202A_206E_200D_206A_200C_206B_202B_206E_202A_202E(role.AttributesFinal[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(912726802u)] - role2.AttributesFinal[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(400004197u)]);
					num = ((int)num2 * -938367871) ^ -682732641;
					continue;
				case 98u:
					num60 = CommonSettings.MOD_KEY();
					name = skill.Name;
					num = (int)((num2 * 1817723447) ^ 0x15CA1893);
					continue;
				case 155u:
				{
					int num69;
					if (_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[716]))
					{
						num = 531726696;
						num69 = num;
					}
					else
					{
						num = 1589606353;
						num69 = num;
					}
					continue;
				}
				case 95u:
					num25 += 250.0;
					num = ((int)num2 * -1051683311) ^ -1852594415;
					continue;
				case 54u:
				{
					int num64;
					if (num60 == 2)
					{
						num = 1975618920;
						num64 = num;
					}
					else
					{
						num = 1065409928;
						num64 = num;
					}
					continue;
				}
				case 186u:
					if (num52 == 0)
					{
						num = 729157424;
						continue;
					}
					num53 = -num52 * num39;
					goto IL_23e8;
				case 298u:
				{
					int num49;
					int num50;
					if (!_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[714]))
					{
						num49 = -1227787100;
						num50 = num49;
					}
					else
					{
						num49 = -2009695991;
						num50 = num49;
					}
					num = num49 ^ ((int)num2 * -1758247707);
					continue;
				}
				case 300u:
				{
					int num45;
					if (type == 0)
					{
						num = 91751045;
						num45 = num;
					}
					else
					{
						num = 1463142252;
						num45 = num;
					}
					continue;
				}
				case 285u:
					attackResult.Hp = 150;
					return attackResult;
				case 213u:
					num = (int)((num2 * 1625828200) ^ 0x386DC685);
					continue;
				case 264u:
					num29 = (double)attackResult.Hp / (double)role2.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1995100678u)];
					num = (int)((num2 * 2067294581) ^ 0x36539199);
					continue;
				case 25u:
				{
					int num30;
					int num31;
					if (num29 <= 1.0)
					{
						num30 = -263763239;
						num31 = num30;
					}
					else
					{
						num30 = -1315504272;
						num31 = num30;
					}
					num = num30 ^ ((int)num2 * -218840106);
					continue;
				}
				case 181u:
					num25 *= role.powerup_daofaValue;
					num = ((int)num2 * -305758568) ^ -199160944;
					continue;
				case 103u:
				{
					int num20;
					int num21;
					if (!_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[717]))
					{
						num20 = -601846052;
						num21 = num20;
					}
					else
					{
						num20 = -1561013187;
						num21 = num20;
					}
					num = num20 ^ (int)(num2 * 355266829);
					continue;
				}
				case 265u:
					num12 = (double)skill.PowerBattle * 8.0 * (1.5 + (double)role.AttributesFinal[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(655417903u)] / 400.0) * (2.0 + (double)num18 / 800.0) * (1.0 + num19) * (1.0 + (double)(equippedInternalSkill.AttackBattle + num13) * 0.5);
					num = 848077099;
					continue;
				case 152u:
					num22 = (float)(int)((skill.TiaoheScale + 1E-05f) % 1f * 1000f) / 100f;
					num = ((int)num2 * -1237529676) ^ -728318797;
					continue;
				case 191u:
					flag = true;
					num = 1914914556;
					continue;
				case 286u:
				{
					int num11;
					if (role.BuiltInTalents[32])
					{
						num = 1784115060;
						num11 = num;
					}
					else
					{
						num = 115690388;
						num11 = num;
					}
					continue;
				}
				case 133u:
					attackResult.Hp = 100 + Tools.GetRandomInt(0, 50 * _202D_202D_206F_202B_202C_206D_206E_206D_200C_202A_206E_202D_202B_202C_206E_202D_202B_202D_202A_206F_206E_206A_200B_200F_202A_200B_206D_206C_202A_202B_202A_202A_206E_200D_206A_200C_206B_202B_206E_202A_202E(role.AttributesFinal[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3665747899u)] - role2.AttributesFinal[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(655417903u)]));
					num = ((int)num2 * -997047305) ^ -387449663;
					continue;
				case 149u:
				{
					int num6;
					if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[616]))
					{
						num = 1325591579;
						num6 = num;
					}
					else
					{
						num = 557754037;
						num6 = num;
					}
					continue;
				}
				case 123u:
					num12 += 400.0;
					num = ((int)num2 * -215678324) ^ -9233229;
					continue;
				case 5u:
				{
					int num199;
					int num200;
					if (sourceSprite.Team == 2)
					{
						num199 = -708752169;
						num200 = num199;
					}
					else
					{
						num199 = -1627333758;
						num200 = num199;
					}
					num = num199 ^ ((int)num2 * -1077701680);
					continue;
				}
				case 113u:
					num8 = _206D_200C_206E_200E_202D_200C_202B_206A_202E_202A_206C_200C_202E_200D_200C_202A_206F_202D_200C_202A_206A_202E_206C_202A_206F_206C_206F_206B_202B_202E_200B_200B_200E_206A_200F_202C_206F_200F_202C_206F_202E((float)num10 * num22, (float)num9 * num121) / 100f;
					goto IL_1e01;
				case 79u:
					num = ((int)num2 * -318536344) ^ 0x6FFCD797;
					continue;
				case 12u:
					num12 *= 1.01;
					num25 *= 1.01;
					num = (int)((num2 * 190941402) ^ 0x2354172C);
					continue;
				case 294u:
					num = ((int)num2 * -14975889) ^ -728829579;
					continue;
				case 270u:
					num25 *= 1.4;
					num12 *= 1.4;
					num3 += 0.2;
					num = 172704370;
					continue;
				case 205u:
				{
					int num197;
					int num198;
					if (!role.HasEquipmentTalent(ResourceStrings.ResStrings[318]))
					{
						num197 = -1813666884;
						num198 = num197;
					}
					else
					{
						num197 = -1552239963;
						num198 = num197;
					}
					num = num197 ^ (int)(num2 * 1730451503);
					continue;
				}
				case 201u:
					num10 = num9;
					num = ((int)num2 * -459094918) ^ 0x27AEA1E5;
					continue;
				case 178u:
					num = (int)((num2 * 1927156267) ^ 0x2DDB4BF9);
					continue;
				case 255u:
				{
					int num195;
					int num196;
					if (num89 < 0.0)
					{
						num195 = -925459246;
						num196 = num195;
					}
					else
					{
						num195 = -1786267852;
						num196 = num195;
					}
					num = num195 ^ ((int)num2 * -235780971);
					continue;
				}
				case 106u:
				{
					int num193;
					int num194;
					if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[728]))
					{
						num193 = -1591133198;
						num194 = num193;
					}
					else
					{
						num193 = -258351914;
						num194 = num193;
					}
					num = num193 ^ (int)(num2 * 1936516834);
					continue;
				}
				case 14u:
				{
					int num187;
					int num188;
					if (role.Difficulty > 0.0)
					{
						num187 = 1469210422;
						num188 = num187;
					}
					else
					{
						num187 = 1171582575;
						num188 = num187;
					}
					num = num187 ^ (int)(num2 * 1172465782);
					continue;
				}
				case 93u:
				{
					int num183;
					int num184;
					if (role.HasEquipmentTalent(ResourceStrings.ResStrings[320]))
					{
						num183 = 1623482502;
						num184 = num183;
					}
					else
					{
						num183 = 844515687;
						num184 = num183;
					}
					num = num183 ^ (int)(num2 * 1367900112);
					continue;
				}
				case 139u:
				{
					int num180;
					if (type == 5)
					{
						num = 947739744;
						num180 = num;
					}
					else
					{
						num = 154063700;
						num180 = num;
					}
					continue;
				}
				case 22u:
				{
					int num176;
					int num177;
					if (!_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[726]))
					{
						num176 = 474614926;
						num177 = num176;
					}
					else
					{
						num176 = 1257955813;
						num177 = num176;
					}
					num = num176 ^ (int)(num2 * 578660778);
					continue;
				}
				case 279u:
					num9 = num10;
					num = 1823741364;
					continue;
				case 61u:
				{
					int num172;
					int num173;
					if (targetSprite.Team == sourceSprite.Team)
					{
						num172 = 1653155401;
						num173 = num172;
					}
					else
					{
						num172 = 773576408;
						num173 = num172;
					}
					num = num172 ^ ((int)num2 * -1040377951);
					continue;
				}
				case 170u:
				{
					int num170;
					if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[615]))
					{
						num = 891830934;
						num170 = num;
					}
					else
					{
						num = 208126013;
						num170 = num;
					}
					continue;
				}
				case 246u:
				{
					int num168;
					if (type == 3)
					{
						num = 440505968;
						num168 = num;
					}
					else
					{
						num = 1273677875;
						num168 = num;
					}
					continue;
				}
				case 19u:
					goto IL_2082;
				case 104u:
					num3 += 0.25;
					num12 *= 1.3;
					num25 *= 1.3;
					num = (int)((num2 * 1980558750) ^ 0x37A0D476);
					continue;
				case 245u:
				{
					int num166;
					if (type != 0)
					{
						num = 1302452431;
						num166 = num;
					}
					else
					{
						num = 304442361;
						num166 = num;
					}
					continue;
				}
				case 132u:
				{
					int num163;
					if (role.BuiltInTalents[204])
					{
						num = 300875201;
						num163 = num;
					}
					else
					{
						num = 2074996833;
						num163 = num;
					}
					continue;
				}
				case 263u:
				{
					int num162;
					if (skill.HitSelf)
					{
						num = 1252010566;
						num162 = num;
					}
					else
					{
						num = 1566422156;
						num162 = num;
					}
					continue;
				}
				case 53u:
					num3 = role.CriticalpValue * (1.0 + num19 / (num19 * 1.5 + 5.0)) + role.EquipmentCriticalpValue;
					num = ((int)num2 * -492663882) ^ -490122447;
					continue;
				case 3u:
					name2 = equippedInternalSkill.Name;
					num = ((int)num2 * -1003117360) ^ -631946252;
					continue;
				case 131u:
					flag2 = true;
					num = ((int)num2 * -792670174) ^ -200833420;
					continue;
				case 179u:
				{
					int num158;
					int num159;
					if (num3 <= 0.999)
					{
						num158 = 434949144;
						num159 = num158;
					}
					else
					{
						num158 = 925251652;
						num159 = num158;
					}
					num = num158 ^ ((int)num2 * -1330638329);
					continue;
				}
				case 77u:
				{
					int num157;
					if (type == 3)
					{
						num = 1538572772;
						num157 = num;
					}
					else
					{
						num = 1780139012;
						num157 = num;
					}
					continue;
				}
				case 237u:
					num25 *= 0.9;
					num12 *= 0.9;
					num = ((int)num2 * -14907572) ^ 0x6830E1E3;
					continue;
				case 73u:
					num3 = role.CriticalpValue * (1.0 + num19 / (num19 * 1.5 + 5.0)) + role.EquipmentCriticalpValue;
					num = 780842971;
					continue;
				case 217u:
				{
					int num155;
					int num156;
					if (!_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[721]))
					{
						num155 = -979617047;
						num156 = num155;
					}
					else
					{
						num155 = -107081822;
						num156 = num155;
					}
					num = num155 ^ ((int)num2 * -1486336460);
					continue;
				}
				case 47u:
				{
					int num152;
					if (num60 == 1)
					{
						num = 1281455311;
						num152 = num;
					}
					else
					{
						num = 411507137;
						num152 = num;
					}
					continue;
				}
				case 86u:
					attackResult.Critical = num3 == 1.0;
					skill.attackResult_Hp = attackResult.Hp;
					num = 529671758;
					continue;
				case 71u:
				{
					int num147;
					if (type != 1)
					{
						num = 974025564;
						num147 = num;
					}
					else
					{
						num = 752336068;
						num147 = num;
					}
					continue;
				}
				case 187u:
					num = (int)(num2 * 492749651) ^ -1102286366;
					continue;
				case 288u:
				{
					int y = targetSprite.Y + num65;
					int num145;
					int num146;
					if (!aI.IsEmptyBlock(x, y))
					{
						num145 = 284303072;
						num146 = num145;
					}
					else
					{
						num145 = 1234556454;
						num146 = num145;
					}
					num = num145 ^ ((int)num2 * -1877491394);
					continue;
				}
				case 20u:
					attackResult.Hp = (int)((double)targetSprite.MaxHp * 10.0 * ((double)sourceSprite.Mp / (double)sourceSprite.MaxMp));
					num = ((int)num2 * -483414520) ^ -999179537;
					continue;
				case 120u:
				{
					int num140;
					int num141;
					if (num19 < -0.9999)
					{
						num140 = -1579660251;
						num141 = num140;
					}
					else
					{
						num140 = -94957075;
						num141 = num140;
					}
					num = num140 ^ ((int)num2 * -292787618);
					continue;
				}
				case 158u:
				{
					int num136;
					if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[621]))
					{
						num = 1902099997;
						num136 = num;
					}
					else
					{
						num = 2003656596;
						num136 = num;
					}
					continue;
				}
				case 124u:
					attackResult.Hp = 0;
					num = 623945295;
					continue;
				case 2u:
					num53 = 0;
					goto IL_23e8;
				case 214u:
					num19 = -0.9999;
					num = ((int)num2 * -2047817660) ^ 0x10606B89;
					continue;
				case 194u:
				{
					int num134;
					if (type == 2)
					{
						num = 606120329;
						num134 = num;
					}
					else
					{
						num = 1851192256;
						num134 = num;
					}
					continue;
				}
				case 239u:
					goto IL_2432;
				case 229u:
					goto IL_2453;
				case 275u:
				{
					int num133;
					if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[628]))
					{
						num = 862163926;
						num133 = num;
					}
					else
					{
						num = 1911582315;
						num133 = num;
					}
					continue;
				}
				case 32u:
					num12 *= role.powerup_quanzhangValue;
					num25 *= role.powerup_quanzhangValue;
					num = ((int)num2 * -96827075) ^ 0x11437D47;
					continue;
				case 76u:
				{
					int num127;
					int num128;
					if (!role.BuiltInTalents[133])
					{
						num127 = -1967336558;
						num128 = num127;
					}
					else
					{
						num127 = -572151795;
						num128 = num127;
					}
					num = num127 ^ (int)(num2 * 333510381);
					continue;
				}
				case 31u:
				{
					int num125;
					if (num3 >= 1.0)
					{
						num = 317241962;
						num125 = num;
					}
					else
					{
						num = 1072603414;
						num125 = num;
					}
					continue;
				}
				case 161u:
				{
					int num123;
					if (type != 1)
					{
						num = 1557305894;
						num123 = num;
					}
					else
					{
						num = 1517886873;
						num123 = num;
					}
					continue;
				}
				case 164u:
					attackResult.Hp += Tools.GetRandomInt(num39 * 100, num39 * 500);
					num = 1206536737;
					continue;
				case 290u:
				{
					int num122;
					if (!role.BuiltInTalents[73])
					{
						num = 172704370;
						num122 = num;
					}
					else
					{
						num = 1645563222;
						num122 = num;
					}
					continue;
				}
				case 0u:
					num121 = 1f;
					num = ((int)num2 * -1546111530) ^ -699798883;
					continue;
				case 144u:
					attackResult.Hp = 1;
					num = ((int)num2 * -744133921) ^ -1112737264;
					continue;
				case 283u:
				{
					int num120;
					if (role.BuiltInTalents[40])
					{
						num = 117199445;
						num120 = num;
					}
					else
					{
						num = 1439964317;
						num120 = num;
					}
					continue;
				}
				case 80u:
					num89 = _206C_200D_200B_202C_202B_206E_202B_206D_206B_202E_200B_202B_206D_200C_206E_206E_206C_202D_206B_200C_206E_202C_200F_206F_200D_200F_202A_202E_200C_202C_202A_200E_206B_202A_200F_200B_206D_200B_202A_200C_202E(role.AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3406067330u)] - role2.AttributesFinal[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(400004197u)]);
					num = ((int)num2 * -1752063922) ^ 0x7F1BDAF1;
					continue;
				case 52u:
					attackFormula = new AttackFormula();
					num = ((int)num2 * -163524848) ^ -1000418792;
					continue;
				case 45u:
				{
					int num118;
					int num119;
					if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[720]))
					{
						num118 = 1138287218;
						num119 = num118;
					}
					else
					{
						num118 = 852736252;
						num119 = num118;
					}
					num = num118 ^ ((int)num2 * -234650759);
					continue;
				}
				case 258u:
					attackResult.Hp = 1;
					return attackResult;
				case 222u:
					num25 *= role.powerup_jianfaValue;
					num = (int)(num2 * 1726462852) ^ -314535924;
					continue;
				case 268u:
					return attackResult;
				case 165u:
					num3 = 0.0;
					num = (int)(num2 * 1827361063) ^ -374328334;
					continue;
				case 62u:
					num3 += 0.25;
					num12 *= 1.3;
					num25 *= 1.3;
					num = 279335899;
					continue;
				case 6u:
					num25 *= role.Difficulty;
					num = (int)((num2 * 837719671) ^ 0x41EEDC9D);
					continue;
				case 157u:
				{
					int num117;
					if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[624]))
					{
						num = 567229592;
						num117 = num;
					}
					else
					{
						num = 1203783439;
						num117 = num;
					}
					continue;
				}
				case 185u:
					return attackResult;
				case 56u:
				{
					int num113;
					int num114;
					if (skill.TiaoheScale < 1.001f)
					{
						num113 = 1828642763;
						num114 = num113;
					}
					else
					{
						num113 = 893941322;
						num114 = num113;
					}
					num = num113 ^ (int)(num2 * 1607302759);
					continue;
				}
				case 58u:
				{
					skill.attackResult_Mp = attackResult.Mp;
					LuaManager.Call(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3500454747u), sourceSprite, targetSprite, skill, bf, attackResult);
					attackResult.Hp = skill.attackResult_Hp;
					attackResult.Mp = skill.attackResult_Mp;
					int num111;
					int num112;
					if (attackResult.Hp > 0)
					{
						num111 = -1214731462;
						num112 = num111;
					}
					else
					{
						num111 = -1306781077;
						num112 = num111;
					}
					num = num111 ^ ((int)num2 * -495747109);
					continue;
				}
				case 180u:
				{
					int num105;
					int num106;
					if (role.HasEquipmentTalent(ResourceStrings.ResStrings[321]))
					{
						num105 = -1039631498;
						num106 = num105;
					}
					else
					{
						num105 = -718506332;
						num106 = num105;
					}
					num = num105 ^ (int)(num2 * 1362247579);
					continue;
				}
				case 55u:
					return attackResult;
				case 292u:
					num25 *= 1.2;
					num3 += 0.15;
					num = ((int)num2 * -1920283144) ^ 0x5E3B288D;
					continue;
				case 43u:
				{
					int num103;
					int num104;
					if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[718]))
					{
						num103 = 1566521186;
						num104 = num103;
					}
					else
					{
						num103 = 1380509137;
						num104 = num103;
					}
					num = num103 ^ (int)(num2 * 534593365);
					continue;
				}
				case 66u:
				{
					int num99;
					int num100;
					if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[638]))
					{
						num99 = -1386023474;
						num100 = num99;
					}
					else
					{
						num99 = -1593173913;
						num100 = num99;
					}
					num = num99 ^ (int)(num2 * 648511286);
					continue;
				}
				case 142u:
				{
					int num97;
					int num98;
					if (targetSprite.Team != sourceSprite.Team)
					{
						num97 = 1286289962;
						num98 = num97;
					}
					else
					{
						num97 = 1662146516;
						num98 = num97;
					}
					num = num97 ^ ((int)num2 * -1817928948);
					continue;
				}
				case 40u:
				{
					int num95;
					if (_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name2, ResourceStrings.ResStrings[724]))
					{
						num = 1895797659;
						num95 = num;
					}
					else
					{
						num = 1078767416;
						num95 = num;
					}
					continue;
				}
				case 183u:
				{
					int num94;
					if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[626]))
					{
						num = 843030284;
						num94 = num;
					}
					else
					{
						num = 220095226;
						num94 = num;
					}
					continue;
				}
				case 160u:
					if (role.EquippedTitle != null)
					{
						num93 = role.EquippedTitle.Attack;
						goto IL_093f;
					}
					num = (int)(num2 * 799494587) ^ -1684815244;
					continue;
				case 59u:
				{
					int num91;
					if (!role.BuiltInTalents[39])
					{
						num = 882649641;
						num91 = num;
					}
					else
					{
						num = 1491937206;
						num91 = num;
					}
					continue;
				}
				case 127u:
					num = ((int)num2 * -315503410) ^ 0x768F4440;
					continue;
				case 114u:
					attackResult.Hp = 0;
					num = 628918432;
					continue;
				case 281u:
				{
					attackResult.Hp = (int)((double)targetSprite.MaxHp * num66 * Tools.GetRandom(0.5, 1.0 + num89 / 1000.0));
					int num90;
					if (attackResult.Hp >= 1)
					{
						num = 1409028750;
						num90 = num;
					}
					else
					{
						num = 2136783142;
						num90 = num;
					}
					continue;
				}
				case 44u:
					num12 *= role.Difficulty;
					num = ((int)num2 * -690008639) ^ 0x10D717EE;
					continue;
				case 235u:
					attackResult.Hp = 2000 + Tools.GetRandomInt(5 * num88, 20 * num88);
					return attackResult;
				case 85u:
					num12 += 250.0;
					num = (int)(num2 * 619949135) ^ -899106164;
					continue;
				case 111u:
					num3 += 0.5;
					num = 1414757827;
					continue;
				case 224u:
					num12 *= 1.2;
					num = ((int)num2 * -1638396666) ^ 0x76467116;
					continue;
				case 219u:
					attackResult.costBall = targetSprite.Balls;
					num = ((int)num2 * -1138564673) ^ -462497527;
					continue;
				case 199u:
					num87 = defenceDescAttack(num26) + role2.EquipmentDefencePercent;
					num = 1613197245;
					continue;
				case 192u:
				{
					int num86;
					if (skill.Type != 5)
					{
						num = 1290028033;
						num86 = num;
					}
					else
					{
						num = 665916156;
						num86 = num;
					}
					continue;
				}
				case 145u:
					attackResult.Hp = 300;
					num = (int)((num2 * 2122598147) ^ 0x4B2AE486);
					continue;
				case 49u:
					num3 *= 1.0 - _206E_206E_206B_206C_200B_202D_202C_202B_202E_200B_200C_206B_206D_202B_200E_200B_200C_206D_206C_206E_206B_200E_200F_202E_202C_202C_200D_200D_206A_206F_200C_206E_206B_202A_206C_200D_202B_206D_200E_202E_202E(0.9, role2.SubCriticalPercent + (double)role2.AttributesFinal[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(400004197u)] / 1200.0);
					num = (int)((num2 * 952268937) ^ 0x18370C78);
					continue;
				case 60u:
				{
					int num81;
					int num82;
					if (type != 4)
					{
						num81 = 2035089559;
						num82 = num81;
					}
					else
					{
						num81 = 186195307;
						num82 = num81;
					}
					num = num81 ^ ((int)num2 * -65826531);
					continue;
				}
				case 82u:
				{
					int num80;
					if (!role.BuiltInTalents[35])
					{
						num = 279335899;
						num80 = num;
					}
					else
					{
						num = 1461602159;
						num80 = num;
					}
					continue;
				}
				case 9u:
					num3 += 0.5;
					num = ((int)num2 * -2034314648) ^ -500681062;
					continue;
				case 230u:
					num9 = equippedInternalSkill.YangBattle;
					num = ((int)num2 * -297223926) ^ 0x9CAACE6;
					continue;
				case 33u:
					num25 += 400.0;
					num = ((int)num2 * -335906490) ^ -622195398;
					continue;
				case 17u:
					aI = bf.AI;
					num = ((int)num2 * -954287490) ^ 0x2A3DDE3A;
					continue;
				case 226u:
					num12 += role.attackValue / 2.0;
					num = ((int)num2 * -225471258) ^ -1946993578;
					continue;
				case 228u:
				{
					int num74;
					int num75;
					if (num10 < num9)
					{
						num74 = -372735899;
						num75 = num74;
					}
					else
					{
						num74 = -1811095705;
						num75 = num74;
					}
					num = num74 ^ ((int)num2 * -194578379);
					continue;
				}
				case 200u:
				{
					criticalValue = role.criticalValue;
					flag2 = false;
					int num70;
					int num71;
					if (!NoZhenlongqiju)
					{
						num70 = -934157314;
						num71 = num70;
					}
					else
					{
						num70 = -1430251203;
						num71 = num70;
					}
					num = num70 ^ (int)(num2 * 1313666667);
					continue;
				}
				case 112u:
					num12 = 0.0;
					num25 = 0.0;
					num = (int)((num2 * 1215912953) ^ 0x189F3CEE);
					continue;
				case 173u:
					num12 *= role.powerup_jianfaValue;
					num = (int)(num2 * 342627737) ^ -1493259705;
					continue;
				case 233u:
					attackResult.Hp = (int)((double)attackResult.Hp * (1.0 - 0.4 * num29));
					num = 1213054245;
					continue;
				case 272u:
					attackResult.Hp = (int)((double)sourceSprite.Hp * Tools.GetRandom(0.01, 0.5));
					num = ((int)num2 * -46482496) ^ -1441548624;
					continue;
				case 1u:
				{
					int num67;
					int num68;
					if (!_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[725]))
					{
						num67 = 626001208;
						num68 = num67;
					}
					else
					{
						num67 = 128134295;
						num68 = num67;
					}
					num = num67 ^ (int)(num2 * 1774399218);
					continue;
				}
				case 278u:
					num3 = role.CriticalpValue + role.EquipmentCriticalpValue;
					num = ((int)num2 * -950521803) ^ -1874177719;
					continue;
				case 202u:
					num12 *= role.powerup_xianshuValue;
					num = ((int)num2 * -1764158154) ^ -1597848264;
					continue;
				case 216u:
					num = ((int)num2 * -2054055271) ^ -141391674;
					continue;
				case 15u:
					attackResult.Hp = (int)((double)targetSprite.MaxHp * num66 * Tools.GetRandom(1.0, 1.2)) + 1000;
					num = (int)((num2 * 1891721438) ^ 0x2A2A3D67);
					continue;
				case 260u:
				{
					int num62;
					int num63;
					if (role.HasEquipmentTalent(ResourceStrings.ResStrings[322]))
					{
						num62 = -662830510;
						num63 = num62;
					}
					else
					{
						num62 = -201743351;
						num63 = num62;
					}
					num = num62 ^ ((int)num2 * -424171182);
					continue;
				}
				case 23u:
				{
					int num59;
					if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[623]))
					{
						num = 2097672417;
						num59 = num;
					}
					else
					{
						num = 1545714725;
						num59 = num;
					}
					continue;
				}
				case 251u:
					num52 = sourceSprite.X - targetSprite.X;
					num56 = sourceSprite.Y - targetSprite.Y;
					_ = targetSprite.X;
					_ = targetSprite.Y;
					num = ((int)num2 * -779929039) ^ -1485618745;
					continue;
				case 37u:
				{
					int num54;
					int num55;
					if (!skill.IsSpecial)
					{
						num54 = -1648588839;
						num55 = num54;
					}
					else
					{
						num54 = -1621692433;
						num55 = num54;
					}
					num = num54 ^ (int)(num2 * 173537837);
					continue;
				}
				case 220u:
					return attackResult;
				case 135u:
				{
					int num51;
					if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[622]))
					{
						num = 1692174833;
						num51 = num;
					}
					else
					{
						num = 2072952637;
						num51 = num;
					}
					continue;
				}
				case 252u:
				{
					int num46;
					int num47;
					if (!_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[721]))
					{
						num46 = -784041055;
						num47 = num46;
					}
					else
					{
						num46 = -1509365000;
						num47 = num46;
					}
					num = num46 ^ (int)(num2 * 2006812772);
					continue;
				}
				case 147u:
				{
					int num41;
					int num42;
					if (_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[724]))
					{
						num41 = -1837880019;
						num42 = num41;
					}
					else
					{
						num41 = -1502906714;
						num42 = num41;
					}
					num = num41 ^ (int)(num2 * 1651873220);
					continue;
				}
				case 189u:
					num25 *= 1.2;
					num = ((int)num2 * -816851832) ^ 0x1568E450;
					continue;
				case 143u:
					switch (type)
					{
					case 2:
						break;
					case 3:
						goto IL_09f4;
					case 4:
						goto IL_1389;
					case 0:
						goto IL_2082;
					case 5:
						goto IL_2432;
					case 1:
						goto IL_2453;
					default:
						goto IL_2fda;
					}
					goto case 21u;
				case 7u:
					num = ((int)num2 * -894321381) ^ 0x1CEDEBB4;
					continue;
				case 234u:
				{
					int num40;
					if (num3 < 1.0)
					{
						num = 1039929881;
						num40 = num;
					}
					else
					{
						num = 2019508390;
						num40 = num;
					}
					continue;
				}
				case 70u:
					num39 = 1;
					num = ((int)num2 * -528119489) ^ 0x49B41249;
					continue;
				case 10u:
					num38 = 0;
					goto IL_3040;
				case 227u:
				{
					int num36;
					int num37;
					if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[1050]))
					{
						num36 = 650554668;
						num37 = num36;
					}
					else
					{
						num36 = 1416769844;
						num37 = num36;
					}
					num = num36 ^ ((int)num2 * -177132994);
					continue;
				}
				case 293u:
					num = ((int)num2 * -1193995488) ^ -1779861388;
					continue;
				case 174u:
					num = ((int)num2 * -1517208878) ^ 0x4496AB5;
					continue;
				case 256u:
					num25 *= num34;
					num26 *= num35;
					num = ((int)num2 * -384494436) ^ -436137357;
					continue;
				case 141u:
				{
					int num27;
					int num28;
					if (!skill.Tiaohe)
					{
						num27 = 1867821509;
						num28 = num27;
					}
					else
					{
						num27 = 1926739282;
						num28 = num27;
					}
					num = num27 ^ (int)(num2 * 2096085146);
					continue;
				}
				case 36u:
					num12 *= 1.2;
					num3 += 0.2;
					num = (int)(num2 * 482370965) ^ -1268504634;
					continue;
				case 206u:
					type = skill.Type;
					num = ((int)num2 * -883235318) ^ 0x759A351F;
					continue;
				case 94u:
					attackFormula.defence = num26;
					LuaManager.Call(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(329331220u), sourceSprite, targetSprite, skill, bf, attackResult, attackFormula);
					num12 = attackFormula.attackLow;
					num25 = attackFormula.attackUp;
					num3 = attackFormula.criticalHit;
					num = (int)(num2 * 1138296633) ^ -1539322417;
					continue;
				case 97u:
					num12 *= 1.08;
					num = (int)(num2 * 765745857) ^ -932707656;
					continue;
				case 156u:
				{
					int num23;
					int num24;
					if (!role.BuiltInTalents[153])
					{
						num23 = -1006400719;
						num24 = num23;
					}
					else
					{
						num23 = -1444852191;
						num24 = num23;
					}
					num = num23 ^ (int)(num2 * 293836762);
					continue;
				}
				case 208u:
				{
					int num16;
					int num17;
					if (!Tools.ProbabilityTest(2.0))
					{
						num16 = 1318578423;
						num17 = num16;
					}
					else
					{
						num16 = 1979369229;
						num17 = num16;
					}
					num = num16 ^ ((int)num2 * -27597158);
					continue;
				}
				case 280u:
					random = Tools.GetRandom(0.5, 1.5);
					num = (int)((num2 * 972223888) ^ 0x7A75C603);
					continue;
				case 257u:
					num12 *= role.powerup_daofaValue;
					num = ((int)num2 * -1293592107) ^ -650057946;
					continue;
				case 68u:
					if (skill.Tiaohe)
					{
						num = 171407453;
						continue;
					}
					num8 = ((!(skill.Suit <= 0f)) ? ((double)(skill.Suit * (float)num9 / 100f)) : ((0f + skill.Suit >= 0f) ? 0.0 : ((0.0 - (double)skill.Suit) * (double)(float)num10 / 100.0)));
					goto IL_1e01;
				case 250u:
					num = (int)(num2 * 256957280) ^ -1801626780;
					continue;
				case 162u:
				{
					int num5;
					if (flag)
					{
						num = 13281331;
						num5 = num;
					}
					else
					{
						num = 451760311;
						num5 = num;
					}
					continue;
				}
				case 90u:
					attackResult.Hp = 0;
					num = 1462889805;
					continue;
				case 89u:
					x = targetSprite.X + num4;
					num = ((int)num2 * -1700114231) ^ -654084255;
					continue;
				case 218u:
					num3 -= role2.SubCriticalPercent;
					num = 1153225575;
					continue;
				default:
					{
						return LuaManager.Call<AttackResult>(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(491565843u), new object[5] { attackResult, skill, sourceSprite, targetSprite, bf });
					}
					IL_09f4:
					num18 = role.AttributesFinal[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1977936243u)];
					num = 724890373;
					continue;
					IL_2fda:
					num = (int)(num2 * 1876766118) ^ -775637441;
					continue;
					IL_23e8:
					num4 = num53;
					if (num56 == 0)
					{
						num = 1663514048;
						continue;
					}
					num38 = -num56 * num39;
					goto IL_3040;
					IL_3040:
					num65 = num38;
					num = 665677439;
					continue;
					IL_093f:
					num13 = num93;
					num = 1307942771;
					continue;
					IL_2453:
					num18 = role.AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(394181284u)];
					num = 724890373;
					continue;
					IL_2432:
					num18 = role.AttributesFinal[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1269723935u)];
					num = 243730983;
					continue;
					IL_08a8:
					num19 = num142;
					num = 2054524936;
					continue;
					IL_1389:
					num18 = role.AttributesFinal[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1790491204u)];
					num = 330744604;
					continue;
					IL_2082:
					num18 = role.AttributesFinal[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2053407229u)];
					num = 724890373;
					continue;
					IL_1e01:
					num19 = num8;
					num = 1204015057;
					continue;
					IL_0641:
					num19 = num144;
					if (num19 >= -0.9999)
					{
						num = 69212674;
						num201 = num;
					}
					else
					{
						num = 1149610206;
						num201 = num;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static void initVar()
	{
		ZHOUMU_ATTACK_ADD = CommonSettings.ZHOUMU_ATTACK_ADD;
		ZHOUMU_DEFENCE_ADD = CommonSettings.ZHOUMU_DEFENCE_ADD;
		if (RuntimeData.Instance.gameEngine.battleType == BattleType.Zhenlongqiju)
		{
			goto IL_0026;
		}
		int noZhenlongqiju = 1;
		goto IL_0050;
		IL_004c:
		noZhenlongqiju = 0;
		goto IL_0050;
		IL_0026:
		int num = 626758489;
		goto IL_002b;
		IL_002b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x3A551BA3)) % 4)
			{
			case 3u:
				break;
			default:
				return;
			case 2u:
				goto IL_004c;
			case 1u:
				Round = RuntimeData.Instance.Round;
				num = (int)(num2 * 896923933) ^ -1578261790;
				continue;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0050:
		NoZhenlongqiju = (byte)noZhenlongqiju != 0;
		num = 458346466;
		goto IL_002b;
	}

	public static AttackResult Attack2(SkillBox skill, BattleSprite source, BattleSprite target, BattleField bf, AttackResult attackResult)
	{
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a31: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_15af: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f66: Unknown result type (might be due to invalid IL or missing references)
		//IL_3df4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_340b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_205f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c86: Unknown result type (might be due to invalid IL or missing references)
		//IL_76ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_67ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_765b: Unknown result type (might be due to invalid IL or missing references)
		//IL_72c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_7334: Unknown result type (might be due to invalid IL or missing references)
		//IL_66a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d85: Unknown result type (might be due to invalid IL or missing references)
		//IL_73cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_60c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_600b: Unknown result type (might be due to invalid IL or missing references)
		//IL_6407: Unknown result type (might be due to invalid IL or missing references)
		//IL_6458: Unknown result type (might be due to invalid IL or missing references)
		//IL_751f: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_547c: Unknown result type (might be due to invalid IL or missing references)
		//IL_7b5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_59df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df8: Unknown result type (might be due to invalid IL or missing references)
		//IL_8ee4: Unknown result type (might be due to invalid IL or missing references)
		//IL_8d8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_839f: Unknown result type (might be due to invalid IL or missing references)
		//IL_934e: Unknown result type (might be due to invalid IL or missing references)
		//IL_93da: Unknown result type (might be due to invalid IL or missing references)
		//IL_93d3: Unknown result type (might be due to invalid IL or missing references)
		if (attackResult == null)
		{
			goto IL_0007;
		}
		goto IL_00ef;
		IL_0007:
		int num = 1412797962;
		goto IL_000c;
		IL_000c:
		int num9 = default(int);
		int hp = default(int);
		Role role = default(Role);
		Role role2 = default(Role);
		bool flag4 = default(bool);
		string name = default(string);
		bool flag = default(bool);
		BattleSprite current = default(BattleSprite);
		double num445 = default(double);
		bool flag2 = default(bool);
		int num307 = default(int);
		int num82 = default(int);
		int num298 = default(int);
		string text = default(string);
		int num83 = default(int);
		List<bool> list = default(List<bool>);
		Buff buff = default(Buff);
		Buff buff9 = default(Buff);
		int num84 = default(int);
		BuffInstance buff10 = default(BuffInstance);
		bool flag3 = default(bool);
		Buff buff2 = default(Buff);
		double num291 = default(double);
		int num51 = default(int);
		BuffInstance buff7 = default(BuffInstance);
		int num34 = default(int);
		int num314 = default(int);
		int num68 = default(int);
		int num71 = default(int);
		Buff buff8 = default(Buff);
		double num319 = default(double);
		BattleSprite current2 = default(BattleSprite);
		int num19 = default(int);
		int num102 = default(int);
		int num222 = default(int);
		int num224 = default(int);
		Buff buff4 = default(Buff);
		int num225 = default(int);
		Buff buff3 = default(Buff);
		BattleSprite battleSprite = default(BattleSprite);
		float num223 = default(float);
		int num105 = default(int);
		int num248 = default(int);
		bool flag5 = default(bool);
		int randomInt2 = default(int);
		int randomInt = default(int);
		double num98 = default(double);
		List<BattleSprite> list2 = default(List<BattleSprite>);
		BattleSprite battleSprite2 = default(BattleSprite);
		BuffInstance buff5 = default(BuffInstance);
		Buff current4 = default(Buff);
		int num117 = default(int);
		double num132 = default(double);
		double num136 = default(double);
		int num139 = default(int);
		double num144 = default(double);
		double num116 = default(double);
		BuffInstance current5 = default(BuffInstance);
		string name2 = default(string);
		int num130 = default(int);
		int num170 = default(int);
		Buff current6 = default(Buff);
		double num169 = default(double);
		List<string> list3 = default(List<string>);
		BuffInstance current7 = default(BuffInstance);
		Buff current8 = default(Buff);
		int num192 = default(int);
		BuffInstance buffInstance = default(BuffInstance);
		List<BattleSprite> list4 = default(List<BattleSprite>);
		BattleSprite current9 = default(BattleSprite);
		int num359 = default(int);
		BattleSprite current10 = default(BattleSprite);
		BattleSprite current11 = default(BattleSprite);
		int num594 = default(int);
		int attackCount = default(int);
		BattleSprite current12 = default(BattleSprite);
		double random = default(double);
		List<BattleSprite> list5 = default(List<BattleSprite>);
		BattleSprite current13 = default(BattleSprite);
		BattleSprite current14 = default(BattleSprite);
		BattleSprite current15 = default(BattleSprite);
		while (true)
		{
			int num588;
			int num11;
			int num12;
			int num589;
			int num590;
			int num591;
			uint num2;
			switch ((num2 = (uint)(num ^ 0x78034022)) % 22)
			{
			case 13u:
				break;
			case 9u:
			{
				int num15;
				int num16;
				if (attackResult.Hp > -4967297)
				{
					num15 = 4770374;
					num16 = num15;
				}
				else
				{
					num15 = 1273702352;
					num16 = num15;
				}
				num = num15 ^ (int)(num2 * 1641240465);
				continue;
			}
			case 11u:
				num588 = ((!skill.HitSelf) ? 1 : 0);
				goto IL_00b1;
			case 12u:
				num9 = (int)((double)attackResult.Hp / (double)bf.GetTeamCount(target.Team));
				num = ((int)num2 * -916939814) ^ -33383221;
				continue;
			case 4u:
				goto IL_00ef;
			case 16u:
			{
				int num592;
				int num593;
				if (!target.IsDead)
				{
					num592 = 1034721983;
					num593 = num592;
				}
				else
				{
					num592 = 1021544106;
					num593 = num592;
				}
				num = num592 ^ (int)(num2 * 2105865823);
				continue;
			}
			case 19u:
				hp = attackResult.Hp;
				num = 1283159921;
				continue;
			case 5u:
				role = source.Role;
				num = 980346974;
				continue;
			case 17u:
				if (attackResult.Hp >= (int)((float)target.MaxHp * 0.2f))
				{
					num = (int)((num2 * 1650517461) ^ 0x6E174FD9);
					continue;
				}
				goto IL_05f4;
			case 7u:
				attackResult.Mp = target.MaxMp;
				num = ((int)num2 * -706944166) ^ -1718349481;
				continue;
			case 21u:
				num9 = _200C_202C_200E_206D_202A_206B_202B_202B_202D_202B_206C_202D_202A_206A_206E_200C_200E_202E_206B_200F_206A_202E_200E_206E_206E_202C_200E_202B_202A_206D_202B_200B_202D_202D_202B_206A_202B_200F_202D_206F_202E(1, (int)((float)num9 * 0.9f));
				num = ((int)num2 * -1033311177) ^ 0x6BB32F7B;
				continue;
			case 6u:
				return attackResult;
			case 2u:
				return null;
			case 3u:
				goto IL_01e9;
			case 1u:
				attackResult.Hp = target.MaxHp;
				num = ((int)num2 * -2067668453) ^ -819621338;
				continue;
			case 20u:
				if (role2.BuiltInTalents[138])
				{
					num = (int)((num2 * 1879420682) ^ 0x59BA19F0);
					continue;
				}
				goto IL_05f4;
			case 0u:
				if (!flag4)
				{
					num588 = 0;
					goto IL_00b1;
				}
				num = ((int)num2 * -738196032) ^ 0x44F71C7D;
				continue;
			case 14u:
				role2 = target.Role;
				flag4 = target.Team != source.Team;
				num = (int)(num2 * 16385384) ^ -1790851944;
				continue;
			case 15u:
				if (attackResult.Hp > 0)
				{
					num = (int)((num2 * 1248828401) ^ 0x36D5D2D7);
					continue;
				}
				goto IL_2b0f;
			case 10u:
				if (bf.GetTeamCount(target.Team) > 2)
				{
					num = (int)(num2 * 89838790) ^ -630130715;
					continue;
				}
				goto IL_05f4;
			case 8u:
			{
				name = skill.Name;
				int num13;
				int num14;
				if (!flag)
				{
					num13 = 1494940341;
					num14 = num13;
				}
				else
				{
					num13 = 2133333415;
					num14 = num13;
				}
				num = num13 ^ ((int)num2 * -1808490294);
				continue;
			}
			default:
				{
					IEnumerator<BattleSprite> enumerator = bf.Sprites.GetEnumerator();
					try
					{
						while (true)
						{
							IL_03d7:
							int num3;
							int num4;
							if (!_202D_202A_206C_200D_200F_202B_202A_206D_206F_206C_200C_200E_200C_202A_200F_202B_200C_202A_206B_206E_202C_202C_206A_200C_200D_206B_202C_200F_206E_206D_206E_202C_206A_202D_206E_206E_206A_206E_206E_206A_202E((IEnumerator)enumerator))
							{
								num3 = 958853368;
								num4 = num3;
							}
							else
							{
								num3 = 320622421;
								num4 = num3;
							}
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ 0x78034022)) % 7)
								{
								case 0u:
									num3 = 320622421;
									continue;
								default:
									goto end_IL_031c;
								case 5u:
									current = enumerator.Current;
									num3 = 546117080;
									continue;
								case 3u:
								{
									int num7;
									int num8;
									if (current.Team != target.Team)
									{
										num7 = 1992831662;
										num8 = num7;
									}
									else
									{
										num7 = 1452417722;
										num8 = num7;
									}
									num3 = num7 ^ (int)(num2 * 1244876792);
									continue;
								}
								case 2u:
									current.Hp -= num9;
									attackResult.AddAttackInfo2(current, _200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3528104119u), (object)num9), Color.white, skill.AttackTime);
									num3 = (int)((num2 * 1835529772) ^ 0x3826E75E);
									continue;
								case 1u:
									break;
								case 6u:
								{
									int num5;
									int num6;
									if (!_200F_200E_206C_206D_202A_206A_206A_202B_206E_202D_202E_206F_206D_206D_206F_200E_202E_206D_206B_206D_202B_202C_206A_202A_200D_200D_206D_200C_200C_202B_206A_202D_202D_200C_206A_206C_206F_206B_200C_200C_202E((Object)(object)current, (Object)(object)target))
									{
										num5 = -1576635730;
										num6 = num5;
									}
									else
									{
										num5 = -1153320382;
										num6 = num5;
									}
									num3 = num5 ^ ((int)num2 * -108736530);
									continue;
								}
								case 4u:
									goto end_IL_031c;
								}
								goto IL_03d7;
								continue;
								end_IL_031c:
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
								IL_0421:
								int num10 = 26281196;
								while (true)
								{
									switch ((num2 = (uint)(num10 ^ 0x78034022)) % 3)
									{
									case 0u:
										break;
									default:
										goto end_IL_0426;
									case 1u:
										goto IL_0444;
									case 2u:
										goto end_IL_0426;
									}
									goto IL_0421;
									IL_0444:
									_206C_202B_200F_200F_206E_206B_202E_206F_206F_200F_206B_200E_206C_200C_200B_202B_206C_200F_200C_200B_200E_202A_202E_206D_202A_206F_202D_200E_200E_202C_200D_200D_206D_200F_206A_206B_206E_200D_200B_200E_202E((IDisposable)enumerator);
									num10 = (int)((num2 * 119673987) ^ 0x29E9C936);
									continue;
									end_IL_0426:
									break;
								}
								break;
							}
						}
					}
					attackResult.Hp = num9;
					goto IL_0465;
				}
				IL_5248:
				if (role.BuiltInTalents[102])
				{
					num11 = 198630517;
					num12 = num11;
				}
				else
				{
					num11 = 1987013336;
					num12 = num11;
				}
				goto IL_0e51;
				IL_0e51:
				while (true)
				{
					double num33;
					int num91;
					int num92;
					int num95;
					switch ((num2 = (uint)(num11 ^ 0x78034022)) % 361)
					{
					case 164u:
						break;
					case 283u:
					{
						int num448;
						int num449;
						if (attackResult.Hp > 0)
						{
							num448 = 479075903;
							num449 = num448;
						}
						else
						{
							num448 = 1476781328;
							num449 = num448;
						}
						num11 = num448 ^ (int)(num2 * 172297620);
						continue;
					}
					case 63u:
					{
						int num456;
						int num457;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[682]))
						{
							num456 = 113969213;
							num457 = num456;
						}
						else
						{
							num456 = 1160074994;
							num457 = num456;
						}
						num11 = num456 ^ ((int)num2 * -1823561961);
						continue;
					}
					case 58u:
					{
						int num405;
						int num406;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[706]))
						{
							num405 = 1341881502;
							num406 = num405;
						}
						else
						{
							num405 = 1515809884;
							num406 = num405;
						}
						num11 = num405 ^ (int)(num2 * 411226994);
						continue;
					}
					case 148u:
					{
						int num296;
						int num297;
						if (_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[665]))
						{
							num296 = -398919452;
							num297 = num296;
						}
						else
						{
							num296 = -475976737;
							num297 = num296;
						}
						num11 = num296 ^ ((int)num2 * -801890927);
						continue;
					}
					case 290u:
					{
						int num413;
						int num414;
						if (_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[700]))
						{
							num413 = -300480950;
							num414 = num413;
						}
						else
						{
							num413 = -460469448;
							num414 = num413;
						}
						num11 = num413 ^ (int)(num2 * 528995888);
						continue;
					}
					case 222u:
					{
						int num54;
						int num55;
						if (!_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[683]))
						{
							num54 = -96503266;
							num55 = num54;
						}
						else
						{
							num54 = -1999336819;
							num55 = num54;
						}
						num11 = num54 ^ (int)(num2 * 967514977);
						continue;
					}
					case 314u:
					{
						int num74;
						int num75;
						if (!_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[645]))
						{
							num74 = -1191913612;
							num75 = num74;
						}
						else
						{
							num74 = -1639903976;
							num75 = num74;
						}
						num11 = num74 ^ (int)(num2 * 1771824400);
						continue;
					}
					case 181u:
					{
						int num481;
						int num482;
						if (num445 > 0.9999)
						{
							num481 = 2031078113;
							num482 = num481;
						}
						else
						{
							num481 = 620391835;
							num482 = num481;
						}
						num11 = num481 ^ (int)(num2 * 437458275);
						continue;
					}
					case 163u:
						attackResult.AddAttackInfo2(target, ResourceStrings.ResStrings[272], Color.magenta, skill.AttackTime);
						flag2 = true;
						num11 = (int)((num2 * 701382648) ^ 0x78920BC4);
						continue;
					case 349u:
						goto IL_15d9;
					case 279u:
					{
						num307 = _202D_202D_206F_202B_202C_206D_206E_206D_200C_202A_206E_202D_202B_202C_206E_202D_202B_202D_202A_206F_206E_206A_200B_200F_202A_200B_206D_206C_202A_202B_202A_202A_206E_200D_206A_200C_206B_202B_206E_202A_202E(source.Mp - target.Mp);
						int num379;
						int num380;
						if (num307 > 10000)
						{
							num379 = -482959706;
							num380 = num379;
						}
						else
						{
							num379 = -1025005346;
							num380 = num379;
						}
						num11 = num379 ^ ((int)num2 * -719060405);
						continue;
					}
					case 3u:
						num82 = _200E_200F_206F_200E_200C_206D_200F_202C_206E_206E_202C_200F_202E_202C_202D_206A_200E_206F_200E_200D_206C_202B_200C_206C_200B_200E_206D_206A_200C_206B_200D_206C_200C_202A_200E_202D_200D_200F_200B_206B_202E((int)((double)attackResult.Hp * 0.05), num298);
						num11 = (int)((num2 * 1345638688) ^ 0x20EA871B);
						continue;
					case 11u:
						target.Hp = target.MaxHp;
						num11 = (int)(num2 * 1886196391) ^ -1603292490;
						continue;
					case 208u:
						text = _200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4136909829u), (object)(-num83));
						num11 = ((int)num2 * -2136513412) ^ 0x37BB2749;
						continue;
					case 205u:
					{
						int num511;
						int num512;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[690]))
						{
							num511 = -1571342234;
							num512 = num511;
						}
						else
						{
							num511 = -146778504;
							num512 = num511;
						}
						num11 = num511 ^ (int)(num2 * 926422424);
						continue;
					}
					case 307u:
						attackResult.Hp = (int)((double)attackResult.Hp * Tools.GetRandom(1.2, 1.8));
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[747], (object)role.Name, (object)ResourceStrings.ResStrings[300]));
						num11 = ((int)num2 * -216881545) ^ -1125388581;
						continue;
					case 73u:
						list[1] = true;
						num11 = ((int)num2 * -957212384) ^ 0x5148AB52;
						continue;
					case 33u:
						goto IL_1769;
					case 186u:
						list[14] = true;
						num11 = ((int)num2 * -188578055) ^ -521732647;
						continue;
					case 289u:
						goto IL_17a0;
					case 194u:
						buff = new Buff();
						num11 = (int)(num2 * 631226828) ^ -79153263;
						continue;
					case 55u:
					{
						int num458;
						int num459;
						if (!_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[671]))
						{
							num458 = -1581290806;
							num459 = num458;
						}
						else
						{
							num458 = -1878329738;
							num459 = num458;
						}
						num11 = num458 ^ (int)(num2 * 1977602365);
						continue;
					}
					case 109u:
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[773], (object)role2.Name, (object)ResourceStrings.ResStrings[249]));
						num11 = ((int)num2 * -1439525293) ^ 0x1987BC91;
						continue;
					case 102u:
					{
						int num415;
						int num416;
						if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[662]))
						{
							num415 = 730578283;
							num416 = num415;
						}
						else
						{
							num415 = 649095565;
							num416 = num415;
						}
						num11 = num415 ^ ((int)num2 * -1806210683);
						continue;
					}
					case 229u:
						attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[748], 0.3f, skill.AttackTime);
						num11 = 1373826933;
						continue;
					case 85u:
						goto IL_18a9;
					case 12u:
					{
						int num334;
						int num335;
						if (!_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[669]))
						{
							num334 = 666178072;
							num335 = num334;
						}
						else
						{
							num334 = 2114847520;
							num335 = num334;
						}
						num11 = num334 ^ (int)(num2 * 1627863337);
						continue;
					}
					case 356u:
						buff9.Name = ResourceStrings.ResStrings[531];
						num11 = ((int)num2 * -1052686475) ^ -1603767214;
						continue;
					case 114u:
					{
						int num58;
						int num59;
						if (_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[661]))
						{
							num58 = -608352389;
							num59 = num58;
						}
						else
						{
							num58 = -589108994;
							num59 = num58;
						}
						num11 = num58 ^ ((int)num2 * -1091501651);
						continue;
					}
					case 45u:
					{
						int num517;
						int num518;
						if (_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[646]))
						{
							num517 = 114948674;
							num518 = num517;
						}
						else
						{
							num517 = 912123199;
							num518 = num517;
						}
						num11 = num517 ^ ((int)num2 * -318667193);
						continue;
					}
					case 204u:
						goto IL_1994;
					case 271u:
						target.MaxHp = 1;
						num11 = (int)(num2 * 1255009872) ^ -369472406;
						continue;
					case 103u:
						attackResult.costBall = 0;
						num11 = ((int)num2 * -1963303156) ^ 0x7285CEA3;
						continue;
					case 359u:
					{
						int num469;
						int num470;
						if (_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[650]))
						{
							num469 = 543084737;
							num470 = num469;
						}
						else
						{
							num469 = 1338874060;
							num470 = num469;
						}
						num11 = num469 ^ (int)(num2 * 796858587);
						continue;
					}
					case 172u:
					{
						int num475;
						int num476;
						if (_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[676]))
						{
							num475 = -1926522544;
							num476 = num475;
						}
						else
						{
							num475 = -5545509;
							num476 = num475;
						}
						num11 = num475 ^ (int)(num2 * 1043982032);
						continue;
					}
					case 122u:
					{
						int num441;
						int num442;
						if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[707]))
						{
							num441 = -1829889864;
							num442 = num441;
						}
						else
						{
							num441 = -809389918;
							num442 = num441;
						}
						num11 = num441 ^ ((int)num2 * -1691128424);
						continue;
					}
					case 51u:
						num84 += 99;
						num11 = ((int)num2 * -802635533) ^ -1878880836;
						continue;
					case 27u:
						bf.ShowSkillAnimation(skill, source.X, source.Y, null);
						num11 = (int)(num2 * 1570190864) ^ -858804339;
						continue;
					case 83u:
						goto IL_1ac2;
					case 331u:
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[783], (object)role2.Name, (object)role.Name));
						num11 = (int)((num2 * 732575587) ^ 0xF965014);
						continue;
					case 26u:
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[772], (object)role2.Name, (object)ResourceStrings.ResStrings[525]));
						num11 = ((int)num2 * -495156931) ^ -1699296798;
						continue;
					case 342u:
						buff10 = new BuffInstance
						{
							buff = buff,
							Owner = source,
							Level = buff.Level,
							LeftRound = buff.Round
						};
						num11 = (int)(num2 * 158842949) ^ -1099323278;
						continue;
					case 152u:
						num84 += 90;
						num11 = ((int)num2 * -2079887676) ^ 0x2764E344;
						continue;
					case 96u:
					{
						int num395;
						int num396;
						if (role2.BuiltInTalents[91])
						{
							num395 = 21069502;
							num396 = num395;
						}
						else
						{
							num395 = 620386564;
							num396 = num395;
						}
						num11 = num395 ^ ((int)num2 * -1247685436);
						continue;
					}
					case 309u:
						list[0] = true;
						num11 = ((int)num2 * -1487200820) ^ -1783432750;
						continue;
					case 110u:
						attackResult.AddAttackInfo2(target, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2199020207u), Color.white, skill.AttackTime);
						num11 = ((int)num2 * -699175316) ^ -556229921;
						continue;
					case 316u:
						goto IL_1c2c;
					case 277u:
						num84 -= 100;
						num11 = (int)((num2 * 731733940) ^ 0x44C9C348);
						continue;
					case 300u:
						attackResult.AddCastInfo2(target, ResourceStrings.ResStrings[197], 0.5f, skill.AttackTime);
						num11 = (int)(num2 * 1997463263) ^ -1306948264;
						continue;
					case 335u:
						attackResult.AddCastInfo2(target, ResourceStrings.ResStrings[782], 0.2f, skill.AttackTime);
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[773], (object)role2.Name, (object)ResourceStrings.ResStrings[199]));
						num11 = ((int)num2 * -1738451292) ^ -285952999;
						continue;
					case 227u:
					{
						int num328;
						int num329;
						if (flag3)
						{
							num328 = -2098217043;
							num329 = num328;
						}
						else
						{
							num328 = -403537537;
							num329 = num328;
						}
						num11 = num328 ^ ((int)num2 * -269229790);
						continue;
					}
					case 340u:
						target.MaxHp -= num298;
						num11 = (int)((num2 * 1082718790) ^ 0x1871386C);
						continue;
					case 0u:
						goto IL_1d44;
					case 228u:
					{
						int num303;
						int num304;
						if (!Tools.ProbabilityTest(0.05))
						{
							num303 = 978635981;
							num304 = num303;
						}
						else
						{
							num303 = 785343360;
							num304 = num303;
						}
						num11 = num303 ^ ((int)num2 * -690758946);
						continue;
					}
					case 257u:
						buff2.Level = 21;
						buff2.Round = 9;
						buff2.Property = 100;
						num11 = (int)(num2 * 850217509) ^ -268583860;
						continue;
					case 167u:
						attackResult.Hp = (int)((double)attackResult.Hp * Tools.GetRandom(1.1, 1.2));
						num11 = ((int)num2 * -453481724) ^ 0x5FCA6C34;
						continue;
					case 191u:
						num291 = 0.2;
						num11 = ((int)num2 * -1621012943) ^ 0x21D6B901;
						continue;
					case 139u:
						attackResult.AddAttackInfo2(target, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1970663377u), Color.white, skill.AttackTime);
						num11 = (int)(num2 * 860873181) ^ -1830192881;
						continue;
					case 233u:
					{
						int num76;
						int num77;
						if (_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[697]))
						{
							num76 = -1390207258;
							num77 = num76;
						}
						else
						{
							num76 = -1048401209;
							num77 = num76;
						}
						num11 = num76 ^ (int)(num2 * 2059492479);
						continue;
					}
					case 190u:
						goto IL_1e78;
					case 334u:
						list[11] = true;
						num11 = ((int)num2 * -1113055456) ^ 0x289360CE;
						continue;
					case 147u:
					{
						int num37;
						int num38;
						if (!flag2)
						{
							num37 = -80414295;
							num38 = num37;
						}
						else
						{
							num37 = -633416325;
							num38 = num37;
						}
						num11 = num37 ^ (int)(num2 * 291415456);
						continue;
					}
					case 130u:
						attackResult.Hp = (int)((double)attackResult.Hp * Tools.GetRandom(1.2, 2.0));
						num11 = (int)((num2 * 2111619392) ^ 0x7DB50F72);
						continue;
					case 323u:
					{
						int num507;
						int num508;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(role.Name, ResourceStrings.ResStrings[633]))
						{
							num507 = -718463519;
							num508 = num507;
						}
						else
						{
							num507 = -270812038;
							num508 = num507;
						}
						num11 = num507 ^ (int)(num2 * 1669887357);
						continue;
					}
					case 87u:
						attackResult.Critical = false;
						attackResult.Buff.Clear();
						attackResult.Debuff.Clear();
						num11 = ((int)num2 * -1035571039) ^ 0x1796D4CA;
						continue;
					case 41u:
						attackResult.AddCastInfo2(target, ResourceStrings.ResStrings[796], 1f, skill.AttackTime);
						num11 = ((int)num2 * -1123002731) ^ 0x70CE31A6;
						continue;
					case 246u:
						num84 += 99;
						num11 = (int)((num2 * 96681617) ^ 0x39EE338A);
						continue;
					case 312u:
						attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[746], 0.5f, skill.AttackTime);
						attackResult.Hp = (int)((double)attackResult.Hp * Tools.GetRandom(1.5, 2.0));
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[747], (object)role.Name, (object)ResourceStrings.ResStrings[262]));
						num11 = 647801076;
						continue;
					case 351u:
						attackResult.AddAttackInfo2(source, ResourceStrings.ResStrings[531], Color.white, skill.AttackTime);
						num11 = ((int)num2 * -876443759) ^ -2011849106;
						continue;
					case 38u:
						num11 = (int)((num2 * 1636949418) ^ 0x2B882333);
						continue;
					case 281u:
					{
						buff9.Level = 0;
						buff9.Round = 3;
						BuffInstance buff11 = new BuffInstance
						{
							buff = buff9,
							Owner = source,
							Level = buff9.Level,
							LeftRound = buff9.Round
						};
						int num491;
						int num492;
						if (!source.AddBuffOnly(buff11))
						{
							num491 = -435132734;
							num492 = num491;
						}
						else
						{
							num491 = -711677042;
							num492 = num491;
						}
						num11 = num491 ^ (int)(num2 * 630842378);
						continue;
					}
					case 284u:
						num51 = 3000;
						num11 = (int)((num2 * 8263602) ^ 0x217DCD7);
						continue;
					case 265u:
						num11 = (int)((num2 * 2098448523) ^ 0x617F92C);
						continue;
					case 29u:
					{
						int num467;
						int num468;
						if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[680]))
						{
							num467 = 1824560224;
							num468 = num467;
						}
						else
						{
							num467 = 1916604550;
							num468 = num467;
						}
						num11 = num467 ^ (int)(num2 * 625722008);
						continue;
					}
					case 216u:
						goto IL_2162;
					case 81u:
					{
						int num462;
						int num463;
						if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[702]))
						{
							num462 = 1380857361;
							num463 = num462;
						}
						else
						{
							num462 = 1798654362;
							num463 = num462;
						}
						num11 = num462 ^ (int)(num2 * 1225513339);
						continue;
					}
					case 360u:
					{
						int num443;
						int num444;
						if (target.GetBuff(ResourceStrings.ResStrings[544]) != null)
						{
							num443 = 1017167935;
							num444 = num443;
						}
						else
						{
							num443 = 99418792;
							num444 = num443;
						}
						num11 = num443 ^ ((int)num2 * -1579015157);
						continue;
					}
					case 97u:
						goto IL_21e2;
					case 142u:
					{
						buff7 = target.GetBuff(ResourceStrings.ResStrings[525]);
						int num425;
						int num426;
						if (buff7 != null)
						{
							num425 = 2120387730;
							num426 = num425;
						}
						else
						{
							num425 = 989751238;
							num426 = num425;
						}
						num11 = num425 ^ ((int)num2 * -218913974);
						continue;
					}
					case 175u:
						goto IL_223d;
					case 40u:
					{
						int num427;
						int num428;
						if (_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[652]))
						{
							num427 = 1444010120;
							num428 = num427;
						}
						else
						{
							num427 = 199642523;
							num428 = num427;
						}
						num11 = num427 ^ ((int)num2 * -714600028);
						continue;
					}
					case 91u:
					{
						int num403;
						int num404;
						if (Tools.ProbabilityTest(0.15))
						{
							num403 = -1252695182;
							num404 = num403;
						}
						else
						{
							num403 = -425069310;
							num404 = num403;
						}
						num11 = num403 ^ (int)(num2 * 1153870137);
						continue;
					}
					case 288u:
					{
						int num391;
						int num392;
						if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[681]))
						{
							num391 = -1551383700;
							num392 = num391;
						}
						else
						{
							num391 = -1270232176;
							num392 = num391;
						}
						num11 = num391 ^ (int)(num2 * 1350815595);
						continue;
					}
					case 343u:
					{
						int num385;
						int num386;
						if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[657]))
						{
							num385 = 1802209469;
							num386 = num385;
						}
						else
						{
							num385 = 1004392450;
							num386 = num385;
						}
						num11 = num385 ^ ((int)num2 * -1497091887);
						continue;
					}
					case 302u:
					{
						int num373;
						int num374;
						if (_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[649]))
						{
							num373 = 1304161146;
							num374 = num373;
						}
						else
						{
							num373 = 414870939;
							num374 = num373;
						}
						num11 = num373 ^ ((int)num2 * -1967400602);
						continue;
					}
					case 123u:
						attackResult.AddCastInfo2(target, ResourceStrings.ResStrings[776], 1f, skill.AttackTime);
						num11 = ((int)num2 * -1183542718) ^ 0x2C890C9F;
						continue;
					case 305u:
						attackResult.AddAttackInfo2(target, _200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[803], (object)num34), Color.green, skill.AttackTime);
						num11 = 463532899;
						continue;
					case 231u:
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[747], (object)role.Name, (object)ResourceStrings.ResStrings[301]));
						num11 = (int)(num2 * 281320626) ^ -1962239360;
						continue;
					case 106u:
						goto IL_240c;
					case 57u:
					{
						int num326;
						int num327;
						if (!role.BuiltInTalents[44])
						{
							num326 = 1615401987;
							num327 = num326;
						}
						else
						{
							num326 = 68859622;
							num327 = num326;
						}
						num11 = num326 ^ ((int)num2 * -1366582170);
						continue;
					}
					case 53u:
					{
						int num322;
						int num323;
						if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[689]))
						{
							num322 = -1858478860;
							num323 = num322;
						}
						else
						{
							num322 = -491069921;
							num323 = num322;
						}
						num11 = num322 ^ (int)(num2 * 774668469);
						continue;
					}
					case 206u:
						text = _200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[797], (object)num314);
						num11 = (int)((num2 * 768139507) ^ 0x3131A3D);
						continue;
					case 315u:
						attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[751], 0.5f, skill.AttackTime);
						attackResult.Hp = (int)((double)attackResult.Hp * 1.4);
						num11 = 291970415;
						continue;
					case 317u:
						num298 = target.MaxHp - 1;
						num11 = 998759419;
						continue;
					case 259u:
					{
						int num294;
						int num295;
						if (!_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[648]))
						{
							num294 = 77489443;
							num295 = num294;
						}
						else
						{
							num294 = 737972338;
							num295 = num294;
						}
						num11 = num294 ^ (int)(num2 * 543598282);
						continue;
					}
					case 219u:
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[773], (object)role2.Name, (object)ResourceStrings.ResStrings[251]));
						num11 = ((int)num2 * -1259351123) ^ -1265711448;
						continue;
					case 107u:
						goto IL_259b;
					case 355u:
						goto IL_25ba;
					case 346u:
					{
						int num89;
						int num90;
						if (!_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[693]))
						{
							num89 = -1731082640;
							num90 = num89;
						}
						else
						{
							num89 = -55040783;
							num90 = num89;
						}
						num11 = num89 ^ ((int)num2 * -1298602875);
						continue;
					}
					case 243u:
						list[12] = true;
						num11 = ((int)num2 * -1070600275) ^ 0x54C49C2A;
						continue;
					case 168u:
						attackResult.Hp = 0;
						attackResult.Mp = 0;
						num11 = ((int)num2 * -719305251) ^ -684374661;
						continue;
					case 48u:
					{
						int num69;
						int num70;
						if (num68 == 1)
						{
							num69 = 829536269;
							num70 = num69;
						}
						else
						{
							num69 = 1683701525;
							num70 = num69;
						}
						num11 = num69 ^ ((int)num2 * -997696222);
						continue;
					}
					case 221u:
						attackResult.Hp = 0;
						attackResult.Mp = 0;
						num11 = ((int)num2 * -1563813047) ^ -1646834778;
						continue;
					case 165u:
						attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[778], 0.5f, skill.AttackTime);
						num11 = ((int)num2 * -1956315713) ^ 0x3541C6C5;
						continue;
					case 326u:
						buff.Name = ResourceStrings.ResStrings[531];
						num11 = ((int)num2 * -55168308) ^ 0x4A1D0D47;
						continue;
					case 120u:
						Log(_200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[802], (object)role2.Name));
						num11 = (int)((num2 * 1983576041) ^ 0x611469C7);
						continue;
					case 212u:
						attackResult.AddCastInfo2(target, ResourceStrings.ResStrings[250], 0.5f, skill.AttackTime);
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[773], (object)role2.Name, (object)ResourceStrings.ResStrings[250]));
						num11 = (int)(num2 * 1248204341) ^ -933826618;
						continue;
					case 89u:
					{
						int num43;
						int num44;
						if (_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[653]))
						{
							num43 = -2013918610;
							num44 = num43;
						}
						else
						{
							num43 = -1706978296;
							num44 = num43;
						}
						num11 = num43 ^ (int)(num2 * 593818822);
						continue;
					}
					case 358u:
					{
						int num39;
						int num40;
						if (skill.HitSelf)
						{
							num39 = 1748998398;
							num40 = num39;
						}
						else
						{
							num39 = 1273620731;
							num40 = num39;
						}
						num11 = num39 ^ ((int)num2 * -689501851);
						continue;
					}
					case 263u:
						list[8] = true;
						num11 = (int)((num2 * 185257308) ^ 0x6CB9E262);
						continue;
					case 232u:
						text = _202B_202B_206C_202D_202C_206A_202D_206C_200B_200B_206D_202D_200F_202E_200D_206B_202B_202B_206E_206F_202E_200F_202E_200D_200F_206D_200D_206D_200B_206A_206C_202D_202C_200E_206E_200F_200D_202B_200C_200E_202E(ResourceStrings.ResStrings[799], (object)role2.Name, (object)num83, (object)num314);
						Log(text);
						num11 = 1889026475;
						continue;
					case 127u:
						list[6] = true;
						num11 = (int)(num2 * 2006304617) ^ -710565100;
						continue;
					case 155u:
					{
						int num513;
						int num514;
						if (_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[686]))
						{
							num513 = 626245604;
							num514 = num513;
						}
						else
						{
							num513 = 1971016970;
							num514 = num513;
						}
						num11 = num513 ^ (int)(num2 * 534222814);
						continue;
					}
					case 310u:
					{
						int num503;
						int num504;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[687]))
						{
							num503 = -1112661239;
							num504 = num503;
						}
						else
						{
							num503 = -2115781908;
							num504 = num503;
						}
						num11 = num503 ^ (int)(num2 * 74089065);
						continue;
					}
					case 111u:
					{
						int num499;
						int num500;
						if (!source.HasBuff(ResourceStrings.ResStrings[1300]))
						{
							num499 = -1479887365;
							num500 = num499;
						}
						else
						{
							num499 = -2092699097;
							num500 = num499;
						}
						num11 = num499 ^ ((int)num2 * -172578879);
						continue;
					}
					case 42u:
						num84 += 99;
						num11 = ((int)num2 * -27211577) ^ -212418697;
						continue;
					case 101u:
						num34 /= 2;
						num11 = ((int)num2 * -109598183) ^ 0x153E6D95;
						continue;
					case 292u:
					{
						int num493;
						int num494;
						if (_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[651]))
						{
							num493 = 671489615;
							num494 = num493;
						}
						else
						{
							num493 = 131646945;
							num494 = num493;
						}
						num11 = num493 ^ ((int)num2 * -1302092959);
						continue;
					}
					case 78u:
					{
						int num487;
						int num488;
						if (flag3)
						{
							num487 = -834956091;
							num488 = num487;
						}
						else
						{
							num487 = -589968283;
							num488 = num487;
						}
						num11 = num487 ^ (int)(num2 * 1826658659);
						continue;
					}
					case 242u:
						flag2 = false;
						num11 = ((int)num2 * -1446895707) ^ 0x5942A558;
						continue;
					case 276u:
						goto IL_2997;
					case 215u:
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[773], (object)role2.Name, (object)ResourceStrings.ResStrings[197]));
						num11 = ((int)num2 * -954083586) ^ -1836792934;
						continue;
					case 104u:
						attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[788], 0.5f, skill.AttackTime);
						num11 = ((int)num2 * -1518495029) ^ 0x2F889A44;
						continue;
					case 235u:
						goto IL_2a30;
					case 54u:
					{
						num83 = (int)((float)attackResult.Hp * 0.25f);
						num314 = (int)((float)attackResult.Mp * 0.25f);
						int num479;
						int num480;
						if (num83 <= 0)
						{
							num479 = -1723485999;
							num480 = num479;
						}
						else
						{
							num479 = -457986887;
							num480 = num479;
						}
						num11 = num479 ^ ((int)num2 * -1128072159);
						continue;
					}
					case 47u:
						num84 = 0;
						num11 = ((int)num2 * -390282786) ^ 0xC621A93;
						continue;
					case 24u:
						attackResult.Buff.Clear();
						num11 = (int)((num2 * 1128591118) ^ 0x334D6C2A);
						continue;
					case 34u:
						buff2 = new Buff();
						num11 = (int)((num2 * 1294919417) ^ 0x6EE4017);
						continue;
					case 319u:
					{
						int num471;
						int num472;
						if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[663]))
						{
							num471 = -1080121228;
							num472 = num471;
						}
						else
						{
							num471 = -2025782331;
							num472 = num471;
						}
						num11 = num471 ^ ((int)num2 * -1146708806);
						continue;
					}
					case 234u:
						goto IL_2b0f;
					case 37u:
					{
						int num464 = (int)((double)num307 * Tools.GetRandom(0.1, 0.25));
						attackResult.Hp += num464;
						attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[271], 0.5f, skill.AttackTime);
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[770], (object)role.Name, (object)num464));
						num11 = 560652478;
						continue;
					}
					case 203u:
					{
						int num454;
						int num455;
						if (attackResult.Mp <= 0)
						{
							num454 = -52566867;
							num455 = num454;
						}
						else
						{
							num454 = -364862531;
							num455 = num454;
						}
						num11 = num454 ^ (int)(num2 * 890645225);
						continue;
					}
					case 90u:
						goto IL_2bd9;
					case 5u:
					{
						int num450;
						int num451;
						if (!role2.BuiltInTalents[88])
						{
							num450 = -528672045;
							num451 = num450;
						}
						else
						{
							num450 = -2083970021;
							num451 = num450;
						}
						num11 = num450 ^ (int)(num2 * 695965223);
						continue;
					}
					case 296u:
						flag2 = true;
						num11 = 1987945478;
						continue;
					case 207u:
					{
						int num437;
						int num438;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[685]))
						{
							num437 = 446743185;
							num438 = num437;
						}
						else
						{
							num437 = 850576173;
							num438 = num437;
						}
						num11 = num437 ^ (int)(num2 * 383088245);
						continue;
					}
					case 187u:
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[747], (object)role.Name, (object)ResourceStrings.ResStrings[269]));
						num11 = ((int)num2 * -1607023746) ^ 0x702030CE;
						continue;
					case 258u:
						list = new List<bool>();
						num71 = 0;
						num11 = 1934403478;
						continue;
					case 125u:
						attackResult.Hp = (int)((double)attackResult.Hp * Tools.GetRandom(1.2, 1.8));
						num11 = ((int)num2 * -1291157133) ^ -441333117;
						continue;
					case 245u:
						goto IL_2cf6;
					case 95u:
						attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[766], 1f, skill.AttackTime);
						buff8 = new Buff();
						buff8.Name = ResourceStrings.ResStrings[531];
						num11 = (int)(num2 * 828120052) ^ -1725467545;
						continue;
					case 313u:
						attackResult.AddCastInfo2(target, ResourceStrings.ResStrings[775], 0.5f, skill.AttackTime);
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[773], (object)role2.Name, (object)ResourceStrings.ResStrings[253]));
						num11 = (int)(num2 * 1299785407) ^ -1947833824;
						continue;
					case 158u:
						list[13] = true;
						num84 += 199;
						num11 = ((int)num2 * -1524829854) ^ -1224596008;
						continue;
					case 17u:
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[777], (object)role2.Name, (object)role.Name));
						buff9 = new Buff();
						num11 = (int)((num2 * 512414480) ^ 0x6692A89C);
						continue;
					case 327u:
						attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[273], 1f, skill.AttackTime);
						num11 = (int)((num2 * 1256817680) ^ 0x75B7A02E);
						continue;
					case 217u:
						goto IL_2e6a;
					case 13u:
					{
						int num423;
						int num424;
						if (Tools.ProbabilityTest(0.1 + num319))
						{
							num423 = -1367322298;
							num424 = num423;
						}
						else
						{
							num423 = -1889994985;
							num424 = num423;
						}
						num11 = num423 ^ (int)(num2 * 81301210);
						continue;
					}
					case 223u:
					{
						int num419;
						int num420;
						if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[705]))
						{
							num419 = -1762393967;
							num420 = num419;
						}
						else
						{
							num419 = -1465355607;
							num420 = num419;
						}
						num11 = num419 ^ ((int)num2 * -407257343);
						continue;
					}
					case 269u:
					{
						num291 = 0.1;
						int num409;
						int num410;
						if (!role2.BuiltInTalents[125])
						{
							num409 = 679833809;
							num410 = num409;
						}
						else
						{
							num409 = 249142322;
							num410 = num409;
						}
						num11 = num409 ^ ((int)num2 * -1771090673);
						continue;
					}
					case 171u:
						goto IL_2f29;
					case 209u:
						attackResult.AddAttackInfo2(source, _200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[798], (object)num51), Color.blue, skill.AttackTime);
						source.Mp -= num51;
						num11 = ((int)num2 * -317202020) ^ -1378113646;
						continue;
					case 183u:
						attackResult.ClearInfo(target);
						num11 = ((int)num2 * -747147129) ^ 0x2919EF07;
						continue;
					case 108u:
					{
						int num399;
						int num400;
						if (!list[0])
						{
							num399 = -2080887374;
							num400 = num399;
						}
						else
						{
							num399 = -157525238;
							num400 = num399;
						}
						num11 = num399 ^ ((int)num2 * -1821539707);
						continue;
					}
					case 357u:
						list[10] = true;
						num11 = (int)((num2 * 1682600837) ^ 0x7CD6367B);
						continue;
					case 178u:
						goto IL_2ffb;
					case 224u:
						target.SkillCdRecover();
						num11 = ((int)num2 * -258542841) ^ -242822342;
						continue;
					case 272u:
						attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[749], 0.5f, skill.AttackTime);
						num11 = 313557948;
						continue;
					case 260u:
					{
						int num389;
						int num390;
						if (target.MaxHp > num298)
						{
							num389 = -557334597;
							num390 = num389;
						}
						else
						{
							num389 = -638994744;
							num390 = num389;
						}
						num11 = num389 ^ (int)(num2 * 1204909086);
						continue;
					}
					case 140u:
						source.Hp -= num83;
						num11 = (int)(num2 * 1186819912) ^ -315742083;
						continue;
					case 274u:
						goto IL_30ad;
					case 184u:
					{
						int num381;
						int num382;
						if (!_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[654]))
						{
							num381 = -995208582;
							num382 = num381;
						}
						else
						{
							num381 = -2006758824;
							num382 = num381;
						}
						num11 = num381 ^ ((int)num2 * -1853254720);
						continue;
					}
					case 251u:
					{
						int num375;
						int num376;
						if (Tools.ProbabilityTest(0.1))
						{
							num375 = -316735500;
							num376 = num375;
						}
						else
						{
							num375 = -1764458989;
							num376 = num375;
						}
						num11 = num375 ^ ((int)num2 * -843201489);
						continue;
					}
					case 273u:
					{
						int num371;
						int num372;
						if (source.GetBuff(ResourceStrings.ResStrings[544]) != null)
						{
							num371 = -1179919311;
							num372 = num371;
						}
						else
						{
							num371 = -1126282320;
							num372 = num371;
						}
						num11 = num371 ^ (int)(num2 * 469140106);
						continue;
					}
					case 240u:
						attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[750], 0.5f, skill.AttackTime);
						num11 = 1587865666;
						continue;
					case 268u:
						num84 += 99;
						num11 = ((int)num2 * -1336036089) ^ -313466643;
						continue;
					case 252u:
						list[2] = true;
						num11 = (int)(num2 * 2084395663) ^ -1292248261;
						continue;
					case 25u:
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[747], (object)role.Name, (object)ResourceStrings.ResStrings[267]));
						num11 = 1046000090;
						continue;
					case 149u:
						goto IL_31f9;
					case 43u:
					{
						int num340;
						int num341;
						if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[655]))
						{
							num340 = -1298217019;
							num341 = num340;
						}
						else
						{
							num340 = -1379934614;
							num341 = num340;
						}
						num11 = num340 ^ ((int)num2 * -502120673);
						continue;
					}
					case 166u:
						list[4] = true;
						num84 += 99;
						num11 = ((int)num2 * -430873574) ^ 0x1CA9C200;
						continue;
					case 298u:
						attackResult.AddCastInfo2(target, ResourceStrings.ResStrings[807], 1f, skill.AttackTime);
						attackResult.AddCastInfo2(source, _200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[808], (object)role.Name), 1f, skill.AttackTime);
						num11 = (int)((num2 * 824920895) ^ 0x7136F32F);
						continue;
					case 129u:
						goto IL_32d8;
					case 308u:
						num84 += 99;
						num11 = ((int)num2 * -1544484916) ^ -1992540100;
						continue;
					case 20u:
						attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[755], 0.7f, skill.AttackTime);
						num11 = (int)((num2 * 1086640051) ^ 0x2C8053CA);
						continue;
					case 146u:
						goto IL_333f;
					case 133u:
						goto IL_3362;
					case 241u:
						num84 += 99;
						num11 = ((int)num2 * -158135169) ^ -36863570;
						continue;
					case 189u:
						goto IL_3395;
					case 135u:
						Log(_200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[780], (object)role.Name));
						num11 = ((int)num2 * -1667812094) ^ 0x66513E73;
						continue;
					case 330u:
						attackResult.AddAttackInfo2(target, _202C_202D_200B_202E_202E_206C_206E_206B_206D_200F_200B_200D_200E_206B_202E_200D_200D_200E_200F_202B_202E_202E_202E_206E_206D_206B_206E_202B_202A_206E_206B_202A_200E_200D_200F_200D_206C_200C_200F_206A_202E(ResourceStrings.ResStrings[259], global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2461224786u)), Color.magenta, skill.AttackTime);
						num11 = (int)((num2 * 499850970) ^ 0x562864AC);
						continue;
					case 100u:
					{
						int num330;
						int num331;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[670]))
						{
							num330 = -767030222;
							num331 = num330;
						}
						else
						{
							num330 = -1882367170;
							num331 = num330;
						}
						num11 = num330 ^ (int)(num2 * 1432274371);
						continue;
					}
					case 128u:
					{
						int num317;
						int num318;
						if (!_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[664]))
						{
							num317 = 1670703225;
							num318 = num317;
						}
						else
						{
							num317 = 2054754239;
							num318 = num317;
						}
						num11 = num317 ^ (int)(num2 * 1706098877);
						continue;
					}
					case 220u:
						num51 /= 3;
						num11 = 663387752;
						continue;
					case 347u:
						Log(_200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[787], (object)role.Name));
						num11 = (int)(num2 * 288689341) ^ -494449218;
						continue;
					case 303u:
						goto IL_34de;
					case 226u:
						goto IL_3501;
					case 74u:
						buff8.Level = 0;
						buff8.Round = 2;
						attackResult.Debuff.Add(buff8);
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[767], (object)role.Name, (object)role2.Name));
						num11 = (int)(num2 * 1910540411) ^ -968426582;
						continue;
					case 321u:
						goto IL_357d;
					case 44u:
					{
						int num310;
						int num311;
						if (!Tools.ProbabilityTest(0.09))
						{
							num310 = 2028809309;
							num311 = num310;
						}
						else
						{
							num310 = 1607877224;
							num311 = num310;
						}
						num11 = num310 ^ ((int)num2 * -1254872809);
						continue;
					}
					case 345u:
						buff.Round = 2;
						num11 = ((int)num2 * -1358174878) ^ 0xA68312E;
						continue;
					case 93u:
						num307 += (int)((double)source.Mp * 0.1);
						num11 = ((int)num2 * -1684947420) ^ 0x38581633;
						continue;
					case 261u:
					{
						int num301;
						int num302;
						if (!Tools.ProbabilityTest((double)buff7.Level * 0.07))
						{
							num301 = -449322252;
							num302 = num301;
						}
						else
						{
							num301 = -873254158;
							num302 = num301;
						}
						num11 = num301 ^ ((int)num2 * -437322248);
						continue;
					}
					case 328u:
						list.Add(item: false);
						num11 = 411059920;
						continue;
					case 350u:
						goto IL_364f;
					case 32u:
					{
						int num289;
						int num290;
						if (!skill.HitSelf)
						{
							num289 = 1897913658;
							num290 = num289;
						}
						else
						{
							num289 = 928616018;
							num290 = num289;
						}
						num11 = num289 ^ ((int)num2 * -1429529283);
						continue;
					}
					case 21u:
						if (attackResult.Mp > 0)
						{
							num11 = (int)(num2 * 2128219365) ^ -139006138;
							continue;
						}
						goto IL_7048;
					case 236u:
						attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[250], 0.5f, skill.AttackTime);
						Log(_200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[784], (object)role.Name));
						num11 = ((int)num2 * -858823900) ^ 0x66FD0612;
						continue;
					case 267u:
						goto IL_3706;
					case 169u:
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[747], (object)role.Name, (object)ResourceStrings.ResStrings[265]));
						num11 = (int)((num2 * 329735079) ^ 0x5FB75C11);
						continue;
					case 354u:
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[805], (object)role.Name, (object)num82));
						num11 = ((int)num2 * -456864480) ^ 0x10CB35BE;
						continue;
					case 70u:
					{
						int num78;
						int num79;
						if (_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[694]))
						{
							num78 = 569885652;
							num79 = num78;
						}
						else
						{
							num78 = 652610258;
							num79 = num78;
						}
						num11 = num78 ^ (int)(num2 * 725014486);
						continue;
					}
					case 76u:
					{
						int num64;
						int num65;
						if (role.HasTalent(ResourceStrings.ResStrings[1201]))
						{
							num64 = -1215591071;
							num65 = num64;
						}
						else
						{
							num64 = -1769169937;
							num65 = num64;
						}
						num11 = num64 ^ ((int)num2 * -216040638);
						continue;
					}
					case 174u:
						goto IL_380d;
					case 84u:
						buff2.Name = ResourceStrings.ResStrings[519];
						num11 = ((int)num2 * -1407755908) ^ -186566687;
						continue;
					case 115u:
						attackResult.AddCastInfo2(target, _206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[772], (object)string.Empty, (object)ResourceStrings.ResStrings[525]), 0.5f, skill.AttackTime);
						num11 = (int)((num2 * 168388783) ^ 0x7D7CF2AA);
						continue;
					case 82u:
					{
						int num56;
						int num57;
						if (!_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[703]))
						{
							num56 = 594295002;
							num57 = num56;
						}
						else
						{
							num56 = 1871713963;
							num57 = num56;
						}
						num11 = num56 ^ ((int)num2 * -1678114276);
						continue;
					}
					case 64u:
					{
						int num49;
						int num50;
						if (Tools.ProbabilityTest(0.25))
						{
							num49 = 1998638933;
							num50 = num49;
						}
						else
						{
							num49 = 1118060784;
							num50 = num49;
						}
						num11 = num49 ^ ((int)num2 * -76041485);
						continue;
					}
					case 80u:
					{
						int num45;
						int num46;
						if (Tools.ProbabilityTest(0.1))
						{
							num45 = -1003687231;
							num46 = num45;
						}
						else
						{
							num45 = -601400886;
							num46 = num45;
						}
						num11 = num45 ^ ((int)num2 * -1502708030);
						continue;
					}
					case 270u:
						goto IL_3937;
					case 94u:
					{
						int num519;
						int num520;
						if (Tools.ProbabilityTest(0.1))
						{
							num519 = 1604167480;
							num520 = num519;
						}
						else
						{
							num519 = 1212737512;
							num520 = num519;
						}
						num11 = num519 ^ (int)(num2 * 1121781659);
						continue;
					}
					case 4u:
					{
						int num515;
						int num516;
						if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[668]))
						{
							num515 = -1870527595;
							num516 = num515;
						}
						else
						{
							num515 = -1694318665;
							num516 = num515;
						}
						num11 = num515 ^ (int)(num2 * 465090315);
						continue;
					}
					case 199u:
					{
						int num509;
						int num510;
						if (!_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[692]))
						{
							num509 = -430540062;
							num510 = num509;
						}
						else
						{
							num509 = -45992004;
							num510 = num509;
						}
						num11 = num509 ^ (int)(num2 * 529363348);
						continue;
					}
					case 151u:
						attackResult.Hp = (int)((double)attackResult.Hp * Tools.GetRandom(1.2, 1.5));
						num11 = 165276129;
						continue;
					case 238u:
						attackResult.AddAttackInfo2(source, ResourceStrings.ResStrings[531], Color.white, skill.AttackTime);
						num11 = (int)(num2 * 614758583) ^ -252387180;
						continue;
					case 157u:
						num11 = ((int)num2 * -225901512) ^ -751570758;
						continue;
					case 65u:
						attackResult.Critical = false;
						num11 = ((int)num2 * -236787977) ^ -2098214629;
						continue;
					case 68u:
					{
						int num505;
						int num506;
						if (_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[700]))
						{
							num505 = 2142923284;
							num506 = num505;
						}
						else
						{
							num505 = 642533146;
							num506 = num505;
						}
						num11 = num505 ^ (int)(num2 * 642118464);
						continue;
					}
					case 282u:
						attackResult.AddCastInfo2(target, ResourceStrings.ResStrings[774], 0.5f, skill.AttackTime);
						num11 = (int)((num2 * 1980084995) ^ 0x35E83493);
						continue;
					case 244u:
					{
						int num501;
						int num502;
						if (!_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[656]))
						{
							num501 = -1953687288;
							num502 = num501;
						}
						else
						{
							num501 = -334768985;
							num502 = num501;
						}
						num11 = num501 ^ (int)(num2 * 1736895819);
						continue;
					}
					case 144u:
						goto IL_3b29;
					case 211u:
						Log(_200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[802], (object)role2.Name));
						num11 = (int)(num2 * 1486183146) ^ -1787359788;
						continue;
					case 10u:
					{
						int num497;
						int num498;
						if (_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[693]))
						{
							num497 = 1098650406;
							num498 = num497;
						}
						else
						{
							num497 = 1100377495;
							num498 = num497;
						}
						num11 = num497 ^ ((int)num2 * -327705710);
						continue;
					}
					case 333u:
						attackResult.AddAttackInfo2(source, text, Color.blue, skill.AttackTime);
						num11 = ((int)num2 * -897418861) ^ 0x32DA792C;
						continue;
					case 256u:
						attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[779], 0.5f, skill.AttackTime);
						num11 = (int)(num2 * 1140655813) ^ -1418193955;
						continue;
					case 62u:
						source.Hp += num82;
						num11 = 736705938;
						continue;
					case 218u:
						list[5] = true;
						num11 = ((int)num2 * -962025492) ^ 0x384D5D53;
						continue;
					case 214u:
					{
						int num495;
						int num496;
						if (!target.HasBuff(ResourceStrings.ResStrings[555]))
						{
							num495 = 1874786676;
							num496 = num495;
						}
						else
						{
							num495 = 967266442;
							num496 = num495;
						}
						num11 = num495 ^ ((int)num2 * -1519191670);
						continue;
					}
					case 254u:
						attackResult.AddCastInfo2(target, _202B_206B_200E_206C_206A_200C_206F_200B_202B_200D_206F_200E_202E_206E_200C_200D_206D_202E_202D_206C_206E_200E_200D_200B_202E_206E_202D_200B_200F_202D_206E_206B_200D_202C_206A_206B_202B_200D_200F_206E_202E(ResourceStrings.ResStrings[768], new char[1] { '#' }), 0.5f, skill.AttackTime);
						Log(_200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[769], (object)role2.Name));
						num11 = (int)((num2 * 1729062111) ^ 0x230BD327);
						continue;
					case 59u:
						if (num84 == 0)
						{
							num11 = 96951734;
							continue;
						}
						num33 = _200E_200D_200B_202E_206E_206C_200B_200B_202A_202E_200C_202B_206C_202A_200E_200F_200B_202C_200C_206B_200C_202A_206D_202C_202A_200E_200E_206C_206C_206B_206A_202B_202E_202C_206E_206B_202C_200D_202A_206D_202E(0.001, role.mingzhongValue - (double)num84 * 0.01);
						goto IL_5332;
					case 188u:
						list[7] = true;
						num84 -= Tools.GetRandomInt(40, 60);
						num11 = (int)(num2 * 757645855) ^ -84522629;
						continue;
					case 352u:
						goto IL_3d1c;
					case 75u:
					{
						int num489;
						int num490;
						if (Tools.ProbabilityTest(0.1))
						{
							num489 = 1210305835;
							num490 = num489;
						}
						else
						{
							num489 = 1886667907;
							num490 = num489;
						}
						num11 = num489 ^ ((int)num2 * -173188269);
						continue;
					}
					case 138u:
					{
						int num485;
						int num486;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[708]))
						{
							num485 = 2060643476;
							num486 = num485;
						}
						else
						{
							num485 = 312887160;
							num486 = num485;
						}
						num11 = num485 ^ ((int)num2 * -1980287790);
						continue;
					}
					case 339u:
					{
						int num483;
						int num484;
						if (_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[704]))
						{
							num483 = -324976264;
							num484 = num483;
						}
						else
						{
							num483 = -1273120565;
							num484 = num483;
						}
						num11 = num483 ^ (int)(num2 * 1994491928);
						continue;
					}
					case 225u:
						attackResult.AddAttackInfo2(target, _200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[762], (object)num298), Color.yellow, skill.AttackTime);
						num11 = 719398531;
						continue;
					case 162u:
						attackResult.AddCastInfo2(target, ResourceStrings.ResStrings[258], 1f, skill.AttackTime);
						num11 = (int)((num2 * 1584547242) ^ 0x79C2491D);
						continue;
					case 46u:
						num82 /= 2;
						num11 = ((int)num2 * -228874826) ^ -991288142;
						continue;
					case 170u:
						num34 = (int)((float)attackResult.Hp * 0.35f);
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[801], (object)role2.Name, (object)num34));
						num11 = (int)((num2 * 835604549) ^ 0x416E507);
						continue;
					case 197u:
						attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[785], 0.5f, skill.AttackTime);
						num11 = ((int)num2 * -1464417051) ^ -128327191;
						continue;
					case 255u:
						goto IL_3edf;
					case 16u:
					{
						int num477;
						int num478;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[677]))
						{
							num477 = -92127267;
							num478 = num477;
						}
						else
						{
							num477 = -856785096;
							num478 = num477;
						}
						num11 = num477 ^ (int)(num2 * 439633752);
						continue;
					}
					case 28u:
						goto IL_3f2e;
					case 324u:
						goto IL_3f45;
					case 266u:
					{
						int num473;
						int num474;
						if (!role2.BuiltInTalents[126])
						{
							num473 = -552912476;
							num474 = num473;
						}
						else
						{
							num473 = -986334298;
							num474 = num473;
						}
						num11 = num473 ^ ((int)num2 * -1056329795);
						continue;
					}
					case 156u:
						attackResult.Debuff.Clear();
						num11 = (int)(num2 * 650634197) ^ -964696086;
						continue;
					case 353u:
					{
						int num465;
						int num466;
						if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[659]))
						{
							num465 = 1347762311;
							num466 = num465;
						}
						else
						{
							num465 = 1155150635;
							num466 = num465;
						}
						num11 = num465 ^ ((int)num2 * -1116743513);
						continue;
					}
					case 145u:
					{
						int num460;
						int num461;
						if (!skill.HitSelf)
						{
							num460 = -895997467;
							num461 = num460;
						}
						else
						{
							num460 = -689431130;
							num461 = num460;
						}
						num11 = num460 ^ ((int)num2 * -116549933);
						continue;
					}
					case 99u:
						goto IL_400d;
					case 249u:
						goto IL_402a;
					case 136u:
					{
						int num452;
						int num453;
						if (Tools.ProbabilityTest(0.8))
						{
							num452 = -238999281;
							num453 = num452;
						}
						else
						{
							num452 = -1805510392;
							num453 = num452;
						}
						num11 = num452 ^ (int)(num2 * 51515494);
						continue;
					}
					case 280u:
					{
						int num446;
						int num447;
						if (_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[693]))
						{
							num446 = -1276417500;
							num447 = num446;
						}
						else
						{
							num446 = -426583750;
							num447 = num446;
						}
						num11 = num446 ^ (int)(num2 * 621107804);
						continue;
					}
					case 134u:
						num319 = 0.06;
						num11 = (int)((num2 * 1994068457) ^ 0x4E39A60C);
						continue;
					case 325u:
						goto IL_40cd;
					case 304u:
						num445 = 0.9999;
						num11 = (int)(num2 * 146488305) ^ -2035705240;
						continue;
					case 18u:
						goto IL_4142;
					case 192u:
						list[5] = true;
						num84 += 99;
						num11 = ((int)num2 * -183130876) ^ -316854750;
						continue;
					case 195u:
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[747], (object)role.Name, (object)ResourceStrings.ResStrings[264]));
						num11 = (int)(num2 * 1960305566) ^ -1433144136;
						continue;
					case 291u:
						goto IL_41c5;
					case 131u:
						num319 = 0.001;
						num11 = 1285019429;
						continue;
					case 348u:
					{
						int num439;
						int num440;
						if (!_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[698]))
						{
							num439 = 995527135;
							num440 = num439;
						}
						else
						{
							num439 = 1932597951;
							num440 = num439;
						}
						num11 = num439 ^ (int)(num2 * 2051984814);
						continue;
					}
					case 22u:
						goto IL_422d;
					case 247u:
						text = _200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[798], (object)(-num314));
						num11 = (int)(num2 * 1734515186) ^ -1884497125;
						continue;
					case 23u:
						text = _200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(38753286u), (object)num83);
						num11 = (int)((num2 * 494928833) ^ 0x65576A2C);
						continue;
					case 311u:
						goto IL_42ab;
					case 31u:
						goto IL_42ce;
					case 329u:
					{
						int num435;
						int num436;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[691]))
						{
							num435 = -437166072;
							num436 = num435;
						}
						else
						{
							num435 = -649989648;
							num436 = num435;
						}
						num11 = num435 ^ ((int)num2 * -444589012);
						continue;
					}
					case 36u:
						goto IL_432c;
					case 179u:
					{
						int num433;
						int num434;
						if (Tools.ProbabilityTest(0.1))
						{
							num433 = 1791442587;
							num434 = num433;
						}
						else
						{
							num433 = 303870384;
							num434 = num433;
						}
						num11 = num433 ^ ((int)num2 * -1286222439);
						continue;
					}
					case 67u:
						attackResult.AddCastInfo2(target, ResourceStrings.ResStrings[781], 0.5f, skill.AttackTime);
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[773], (object)role2.Name, (object)ResourceStrings.ResStrings[257]));
						num11 = ((int)num2 * -536035485) ^ 0x494EAB88;
						continue;
					case 69u:
						goto IL_43d5;
					case 56u:
						list[3] = true;
						num84 += 90;
						num11 = ((int)num2 * -352356661) ^ 0x4BBE571F;
						continue;
					case 210u:
					{
						int num431;
						int num432;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[678]))
						{
							num431 = -1344132522;
							num432 = num431;
						}
						else
						{
							num431 = -1876540423;
							num432 = num431;
						}
						num11 = num431 ^ (int)(num2 * 2095877439);
						continue;
					}
					case 72u:
					{
						int num429;
						int num430;
						if (Tools.ProbabilityTest(0.08))
						{
							num429 = -759830847;
							num430 = num429;
						}
						else
						{
							num429 = -720639203;
							num430 = num429;
						}
						num11 = num429 ^ ((int)num2 * -1970986197);
						continue;
					}
					case 92u:
					{
						int num421;
						int num422;
						if (_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[674]))
						{
							num421 = -969421088;
							num422 = num421;
						}
						else
						{
							num421 = -1310879597;
							num422 = num421;
						}
						num11 = num421 ^ ((int)num2 * -1592010608);
						continue;
					}
					case 143u:
						list.Clear();
						num11 = 562306171;
						continue;
					case 79u:
					{
						int num417;
						int num418;
						if (_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[673]))
						{
							num417 = 1476484363;
							num418 = num417;
						}
						else
						{
							num417 = 780509333;
							num418 = num417;
						}
						num11 = num417 ^ (int)(num2 * 532945841);
						continue;
					}
					case 137u:
					{
						int num411;
						int num412;
						if (!role2.BuiltInTalents[44])
						{
							num411 = -1067883908;
							num412 = num411;
						}
						else
						{
							num411 = -970640700;
							num412 = num411;
						}
						num11 = num411 ^ ((int)num2 * -1187348571);
						continue;
					}
					case 177u:
						target.Mp += num51;
						num11 = (int)(num2 * 1958178265) ^ -675390541;
						continue;
					case 88u:
						goto IL_4546;
					case 196u:
					{
						int num407;
						int num408;
						if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[701]))
						{
							num407 = 1054482573;
							num408 = num407;
						}
						else
						{
							num407 = 1013163268;
							num408 = num407;
						}
						num11 = num407 ^ (int)(num2 * 452235521);
						continue;
					}
					case 201u:
						goto IL_4599;
					case 126u:
					{
						int num401;
						int num402;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[688]))
						{
							num401 = 1865401440;
							num402 = num401;
						}
						else
						{
							num401 = 44501606;
							num402 = num401;
						}
						num11 = num401 ^ (int)(num2 * 903904202);
						continue;
					}
					case 14u:
						list[9] = true;
						num84 -= Tools.GetRandomInt(80, 99);
						num11 = ((int)num2 * -2079138697) ^ 0x3E4F1783;
						continue;
					case 295u:
					{
						num291 = 0.0;
						int num397;
						int num398;
						if (role2.BuiltInTalents[111])
						{
							num397 = -745539573;
							num398 = num397;
						}
						else
						{
							num397 = -1466855616;
							num398 = num397;
						}
						num11 = num397 ^ (int)(num2 * 288300577);
						continue;
					}
					case 185u:
					{
						int num393;
						int num394;
						if (_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[703]))
						{
							num393 = 1657638358;
							num394 = num393;
						}
						else
						{
							num393 = 1524428892;
							num394 = num393;
						}
						num11 = num393 ^ (int)(num2 * 2061412762);
						continue;
					}
					case 230u:
					{
						int num387;
						int num388;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[679]))
						{
							num387 = -1748479876;
							num388 = num387;
						}
						else
						{
							num387 = -733827130;
							num388 = num387;
						}
						num11 = num387 ^ ((int)num2 * -1913085634);
						continue;
					}
					case 250u:
						attackResult.costBall = 0;
						num11 = ((int)num2 * -1450655850) ^ -1572666944;
						continue;
					case 294u:
						goto IL_46cd;
					case 337u:
					{
						int num383;
						int num384;
						if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[654]))
						{
							num383 = 222171810;
							num384 = num383;
						}
						else
						{
							num383 = 1507541403;
							num384 = num383;
						}
						num11 = num383 ^ ((int)num2 * -2039256452);
						continue;
					}
					case 173u:
						goto IL_471b;
					case 237u:
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[747], (object)role.Name, (object)ResourceStrings.ResStrings[268]));
						num11 = (int)(num2 * 1584789283) ^ -1585771137;
						continue;
					case 285u:
					{
						int num377;
						int num378;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[696]))
						{
							num377 = 1191288821;
							num378 = num377;
						}
						else
						{
							num377 = 929018703;
							num378 = num377;
						}
						num11 = num377 ^ (int)(num2 * 1060121224);
						continue;
					}
					case 182u:
						if (role2.BuiltInTalents[87])
						{
							num11 = 1165461997;
							continue;
						}
						goto IL_5705;
					case 71u:
					{
						int num342;
						int num343;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[695]))
						{
							num342 = 1160911318;
							num343 = num342;
						}
						else
						{
							num342 = 1571228388;
							num343 = num342;
						}
						num11 = num342 ^ (int)(num2 * 1833232543);
						continue;
					}
					case 287u:
					{
						int num338;
						int num339;
						if ((float)target.Hp / (float)target.MaxHp < 0.8f)
						{
							num338 = 637561773;
							num339 = num338;
						}
						else
						{
							num338 = 899769810;
							num339 = num338;
						}
						num11 = num338 ^ (int)(num2 * 2125416297);
						continue;
					}
					case 116u:
					{
						int num336;
						int num337;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[666]))
						{
							num336 = -1891131880;
							num337 = num336;
						}
						else
						{
							num336 = -181846388;
							num337 = num336;
						}
						num11 = num336 ^ ((int)num2 * -1004871496);
						continue;
					}
					case 286u:
						goto IL_486d;
					case 161u:
					{
						num51 = _202D_202D_206F_202B_202C_206D_206E_206D_200C_202A_206E_202D_202B_202C_206E_202D_202B_202D_202A_206F_206E_206A_200B_200F_202A_200B_206D_206C_202A_202B_202A_202A_206E_200D_206A_200C_206B_202B_206E_202A_202E(role2.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(400004197u)]) + 300;
						int num332;
						int num333;
						if (num51 > 3000)
						{
							num332 = -1942567988;
							num333 = num332;
						}
						else
						{
							num332 = -1513392361;
							num333 = num332;
						}
						num11 = num332 ^ ((int)num2 * -2073689626);
						continue;
					}
					case 301u:
					{
						int num324;
						int num325;
						if (source.AddBuffOnly(buff10))
						{
							num324 = -1267512227;
							num325 = num324;
						}
						else
						{
							num324 = -1560292547;
							num325 = num324;
						}
						num11 = num324 ^ ((int)num2 * -856664933);
						continue;
					}
					case 19u:
						attackResult.Debuff.Add(buff2);
						num11 = (int)((num2 * 2118355337) ^ 0x703ACBCC);
						continue;
					case 278u:
						goto IL_4920;
					case 132u:
						num298 = _200E_200F_206F_200E_200C_206D_200F_202C_206E_206E_202C_200F_202E_202C_202D_206A_200E_206F_200E_200D_206C_202B_200C_206C_200B_200E_206D_206A_200C_206B_200D_206C_200C_202A_200E_202D_200D_200F_200B_206B_202E((int)((double)attackResult.Hp * 0.05), (int)((double)target.MaxHp * 0.05));
						num11 = (int)(num2 * 1493369821) ^ -197342814;
						continue;
					case 119u:
						goto IL_4982;
					case 150u:
					{
						int num320;
						int num321;
						if (!_200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(name, ResourceStrings.ResStrings[660]))
						{
							num320 = -1504662285;
							num321 = num320;
						}
						else
						{
							num320 = -38518706;
							num321 = num320;
						}
						num11 = num320 ^ ((int)num2 * -345075978);
						continue;
					}
					case 198u:
						goto IL_49d5;
					case 264u:
						num319 = 0.1;
						num11 = (int)((num2 * 604297425) ^ 0x1CCCF850);
						continue;
					case 159u:
						num51 = source.Mp;
						num11 = (int)(num2 * 682153907) ^ -1766532593;
						continue;
					case 66u:
						attackResult.AddAttackInfo2(source, text, Color.white, skill.AttackTime);
						num11 = ((int)num2 * -1094256645) ^ 0x245F85B3;
						continue;
					case 180u:
					{
						int num315;
						int num316;
						if (_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[667]))
						{
							num315 = 29967284;
							num316 = num315;
						}
						else
						{
							num315 = 2101428513;
							num316 = num315;
						}
						num11 = num315 ^ ((int)num2 * -1246732752);
						continue;
					}
					case 322u:
						source.Mp -= num314;
						num11 = (int)((num2 * 810930255) ^ 0x399867ED);
						continue;
					case 153u:
						num307 = 10000;
						num11 = ((int)num2 * -1486045980) ^ 0x206830FD;
						continue;
					case 248u:
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[800], (object)role2.Name, (object)num51));
						num11 = ((int)num2 * -2059838331) ^ 0x7FE49E1;
						continue;
					case 61u:
					{
						int num312;
						int num313;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[658]))
						{
							num312 = 1576730228;
							num313 = num312;
						}
						else
						{
							num312 = 1772343047;
							num313 = num312;
						}
						num11 = num312 ^ (int)(num2 * 1119000019);
						continue;
					}
					case 141u:
						attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[754], 0.5f, skill.AttackTime);
						attackResult.Hp = (int)((double)attackResult.Hp * Tools.GetRandom(1.2, 1.5));
						num11 = 561161841;
						continue;
					case 344u:
						num11 = (int)(num2 * 792832219) ^ -1297573684;
						continue;
					case 341u:
						goto IL_4b9e;
					case 336u:
					{
						int num308;
						int num309;
						if (Tools.ProbabilityTest(0.15))
						{
							num308 = -283959048;
							num309 = num308;
						}
						else
						{
							num308 = -1881161212;
							num309 = num308;
						}
						num11 = num308 ^ ((int)num2 * -948989250);
						continue;
					}
					case 118u:
						attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[1300], 0.5f, skill.AttackTime);
						num11 = ((int)num2 * -1434515372) ^ -1098248295;
						continue;
					case 154u:
					{
						int num305;
						int num306;
						if (_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[692]))
						{
							num305 = -1790805948;
							num306 = num305;
						}
						else
						{
							num305 = -243293181;
							num306 = num305;
						}
						num11 = num305 ^ ((int)num2 * -300063983);
						continue;
					}
					case 200u:
						num84 -= Tools.GetRandomInt(80, 99);
						num11 = ((int)num2 * -1323303902) ^ 0x2392F4C2;
						continue;
					case 213u:
					{
						int num299;
						int num300;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[675]))
						{
							num299 = 340732552;
							num300 = num299;
						}
						else
						{
							num299 = 1877552713;
							num300 = num299;
						}
						num11 = num299 ^ ((int)num2 * -111205511);
						continue;
					}
					case 1u:
						Log(_200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[786], (object)role.Name));
						num11 = (int)(num2 * 1824692476) ^ -752585303;
						continue;
					case 77u:
						num11 = (int)((num2 * 1178659798) ^ 0x71AE6A6A);
						continue;
					case 9u:
						Log(_202B_202B_206C_202D_202C_206A_202D_206C_200B_200B_206D_202D_200F_202E_200D_206B_202B_202B_206E_206F_202E_200F_202E_200D_200F_206D_200D_206D_200B_206A_206C_202D_202C_200E_206E_200F_200D_202B_200C_200E_202E(ResourceStrings.ResStrings[804], (object)role.Name, (object)role2.Name, (object)num298));
						num11 = ((int)num2 * -516626924) ^ 0x6B5D5C4F;
						continue;
					case 35u:
						buff.Level = 0;
						num11 = ((int)num2 * -952935596) ^ -1032453858;
						continue;
					case 318u:
						attackResult.AddAttackInfo2(source, _200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[806], (object)num82), Color.red, skill.AttackTime);
						num11 = (int)((num2 * 796341857) ^ 0x5DA92A2A);
						continue;
					case 320u:
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[747], (object)role.Name, (object)ResourceStrings.ResStrings[263]));
						num11 = (int)(num2 * 41312569) ^ -550745438;
						continue;
					case 30u:
					{
						int num292;
						int num293;
						if (!role.Female)
						{
							num292 = -110965578;
							num293 = num292;
						}
						else
						{
							num292 = -38217951;
							num293 = num292;
						}
						num11 = num292 ^ ((int)num2 * -224135217);
						continue;
					}
					case 193u:
					{
						int num287;
						int num288;
						if (_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[692]))
						{
							num287 = 651889560;
							num288 = num287;
						}
						else
						{
							num287 = 460930085;
							num288 = num287;
						}
						num11 = num287 ^ ((int)num2 * -1054178642);
						continue;
					}
					case 105u:
					{
						int num93;
						int num94;
						if (bf.IsRoleInField(ResourceStrings.ResStrings[634], source.Team))
						{
							num93 = -2106002140;
							num94 = num93;
						}
						else
						{
							num93 = -191393787;
							num94 = num93;
						}
						num11 = num93 ^ (int)(num2 * 853364127);
						continue;
					}
					case 124u:
					{
						int num87;
						int num88;
						if (!Tools.ProbabilityTest(0.05))
						{
							num87 = 133822949;
							num88 = num87;
						}
						else
						{
							num87 = 1302772849;
							num88 = num87;
						}
						num11 = num87 ^ ((int)num2 * -1064888740);
						continue;
					}
					case 52u:
						goto IL_4e94;
					case 7u:
					{
						int num85;
						int num86;
						if (!role2.Female)
						{
							num85 = -992889281;
							num86 = num85;
						}
						else
						{
							num85 = -1453614667;
							num86 = num85;
						}
						num11 = num85 ^ (int)(num2 * 1520691376);
						continue;
					}
					case 299u:
						num84 += 90;
						num11 = (int)((num2 * 596121704) ^ 0x1ECAFBEE);
						continue;
					case 50u:
					{
						int num80;
						int num81;
						if (_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[647]))
						{
							num80 = 1069731466;
							num81 = num80;
						}
						else
						{
							num80 = 86454145;
							num81 = num80;
						}
						num11 = num80 ^ ((int)num2 * -1476021474);
						continue;
					}
					case 117u:
					{
						int num72;
						int num73;
						if (!_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[672]))
						{
							num72 = 1190904281;
							num73 = num72;
						}
						else
						{
							num72 = 1917884480;
							num73 = num72;
						}
						num11 = num72 ^ (int)(num2 * 278762832);
						continue;
					}
					case 39u:
						attackResult.Hp = (int)((double)attackResult.Hp * (1.6 + (double)role.EquippedInternalSkill.Level * Tools.GetRandom(0.002, 0.004)));
						num11 = ((int)num2 * -129976938) ^ -1675099453;
						continue;
					case 15u:
						goto IL_4fad;
					case 293u:
						num71++;
						num11 = (int)((num2 * 1797307530) ^ 0x30B7D1E2);
						continue;
					case 332u:
					{
						int num66;
						int num67;
						if (role2.BuiltInTalents[97])
						{
							num66 = 1086118418;
							num67 = num66;
						}
						else
						{
							num66 = 1457467790;
							num67 = num66;
						}
						num11 = num66 ^ ((int)num2 * -1691395360);
						continue;
					}
					case 306u:
						Log(_206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(ResourceStrings.ResStrings[747], (object)role.Name, (object)ResourceStrings.ResStrings[266]));
						num11 = ((int)num2 * -1975635984) ^ 0x34A6D3CC;
						continue;
					case 121u:
						goto IL_5051;
					case 176u:
						flag3 = true;
						num11 = (int)(num2 * 1456589073) ^ -1177085892;
						continue;
					case 239u:
					{
						int num62;
						int num63;
						if (Tools.ProbabilityTest(0.1))
						{
							num62 = 1071386993;
							num63 = num62;
						}
						else
						{
							num62 = 1808558150;
							num63 = num62;
						}
						num11 = num62 ^ ((int)num2 * -1218845828);
						continue;
					}
					case 253u:
					{
						int num60;
						int num61;
						if (_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[699]))
						{
							num60 = 1919786614;
							num61 = num60;
						}
						else
						{
							num60 = 1828711053;
							num61 = num60;
						}
						num11 = num60 ^ ((int)num2 * -1476095171);
						continue;
					}
					case 6u:
					{
						int num52;
						int num53;
						if (num51 <= source.Mp)
						{
							num52 = -1105225744;
							num53 = num52;
						}
						else
						{
							num52 = -78871329;
							num53 = num52;
						}
						num11 = num52 ^ (int)(num2 * 712312593);
						continue;
					}
					case 262u:
						goto IL_510f;
					case 113u:
					{
						int num47;
						int num48;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(role.Name, ResourceStrings.ResStrings[632]))
						{
							num47 = -171349986;
							num48 = num47;
						}
						else
						{
							num47 = -385251174;
							num48 = num47;
						}
						num11 = num47 ^ (int)(num2 * 856714768);
						continue;
					}
					case 338u:
						goto IL_517c;
					case 8u:
					{
						int num41;
						int num42;
						if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(name, ResourceStrings.ResStrings[684]))
						{
							num41 = 2147239720;
							num42 = num41;
						}
						else
						{
							num41 = 1759235091;
							num42 = num41;
						}
						num11 = num41 ^ (int)(num2 * 413700227);
						continue;
					}
					case 112u:
					{
						int num35;
						int num36;
						if (_206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(name, ResourceStrings.ResStrings[655]))
						{
							num35 = 537654840;
							num36 = num35;
						}
						else
						{
							num35 = 1782720223;
							num36 = num35;
						}
						num11 = num35 ^ (int)(num2 * 40920836);
						continue;
					}
					case 98u:
						goto IL_5209;
					case 275u:
						goto IL_5227;
					case 202u:
						goto IL_5248;
					case 49u:
						target.Hp += num34;
						num11 = ((int)num2 * -776442184) ^ -106652531;
						continue;
					case 297u:
						goto IL_528d;
					case 160u:
						attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[756], 0.7f, skill.AttackTime);
						attackResult.Hp = (int)((double)attackResult.Hp * Tools.GetRandom(1.2, 1.5));
						num11 = ((int)num2 * -10522536) ^ 0x3CE3D86D;
						continue;
					case 60u:
						num33 = role.mingzhongValue;
						goto IL_5332;
					case 86u:
						attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[753], 0.35f, skill.AttackTime);
						attackResult.Hp = (int)((double)attackResult.Hp * Tools.GetRandom(1.2, 1.5));
						num11 = 2086362552;
						continue;
					default:
						{
							IEnumerator<BattleSprite> enumerator = bf.Sprites.GetEnumerator();
							try
							{
								while (true)
								{
									IL_55b5:
									int num17;
									int num18;
									if (!enumerator.MoveNext())
									{
										num17 = 181159541;
										num18 = num17;
									}
									else
									{
										num17 = 1696513662;
										num18 = num17;
									}
									while (true)
									{
										switch ((num2 = (uint)(num17 ^ 0x78034022)) % 17)
										{
										case 5u:
											num17 = 1696513662;
											continue;
										default:
											goto end_IL_53a9;
										case 0u:
										{
											int num30;
											int num31;
											if (!_200F_200E_206C_206D_202A_206A_206A_202B_206E_202D_202E_206F_206D_206D_206F_200E_202E_206D_206B_206D_202B_202C_206A_202A_200D_200D_206D_200C_200C_202B_206A_202D_202D_200C_206A_206C_206F_206B_200C_200C_202E((Object)(object)current2, (Object)(object)target))
											{
												num30 = 1444860985;
												num31 = num30;
											}
											else
											{
												num30 = 2059153720;
												num31 = num30;
											}
											num17 = num30 ^ (int)(num2 * 468533498);
											continue;
										}
										case 15u:
										{
											int num22;
											int num23;
											if (current2.Hp <= 1)
											{
												num22 = 1804804917;
												num23 = num22;
											}
											else
											{
												num22 = 990383275;
												num23 = num22;
											}
											num17 = num22 ^ (int)(num2 * 1061475385);
											continue;
										}
										case 16u:
											attackResult.Debuff.Clear();
											num17 = 333191676;
											continue;
										case 3u:
											current2.AttackInfo_fs(_200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(413954281u), (object)num19), Color.white, skill.AttackTime);
											Log(string.Format(ResourceStrings.ResStrings[830], current2.Role.Name, num19.ToString()));
											goto end_IL_53a9;
										case 13u:
											current2 = enumerator.Current;
											num17 = 837647360;
											continue;
										case 4u:
											attackResult.AddCastInfo2(target, ResourceStrings.ResStrings[248], 1f, skill.AttackTime);
											num17 = ((int)num2 * -1152071172) ^ -2051925219;
											continue;
										case 9u:
											Log(_200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[792], (object)current2.Role.Name));
											attackResult.AddCastInfo2(current2, ResourceStrings.ResStrings[248], 1f, skill.AttackTime);
											num17 = (int)(num2 * 1032682179) ^ -39662035;
											continue;
										case 2u:
											num19 = (int)((float)attackResult.Hp * 0.3f);
											num17 = ((int)num2 * -366960734) ^ -937681938;
											continue;
										case 7u:
											num19 = current2.Hp - 1;
											num17 = ((int)num2 * -837745473) ^ 0x93EFFEF;
											continue;
										case 1u:
											break;
										case 14u:
										{
											int num28;
											int num29;
											if (!current2.Role.BuiltInTalents[87])
											{
												num28 = 1716837191;
												num29 = num28;
											}
											else
											{
												num28 = 1966049003;
												num29 = num28;
											}
											num17 = num28 ^ ((int)num2 * -1270511528);
											continue;
										}
										case 8u:
										{
											attackResult.Hp = 0;
											int num26;
											int num27;
											if (current2.Hp - num19 > 0)
											{
												num26 = 1248745096;
												num27 = num26;
											}
											else
											{
												num26 = 1152686459;
												num27 = num26;
											}
											num17 = num26 ^ ((int)num2 * -659667793);
											continue;
										}
										case 11u:
										{
											int num24;
											int num25;
											if (Tools.GetRandom(0.0, 1.0) > 0.5)
											{
												num24 = 1309997379;
												num25 = num24;
											}
											else
											{
												num24 = 1148144708;
												num25 = num24;
											}
											num17 = num24 ^ (int)(num2 * 1240173081);
											continue;
										}
										case 10u:
										{
											int num20;
											int num21;
											if (current2.Team == target.Team)
											{
												num20 = -118352589;
												num21 = num20;
											}
											else
											{
												num20 = -1397675435;
												num21 = num20;
											}
											num17 = num20 ^ ((int)num2 * -995241678);
											continue;
										}
										case 12u:
											current2.Hp -= num19;
											num17 = (int)(num2 * 324091242) ^ -269803053;
											continue;
										case 6u:
											goto end_IL_53a9;
										}
										goto IL_55b5;
										continue;
										end_IL_53a9:
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
										IL_56ca:
										int num32 = 335214190;
										while (true)
										{
											switch ((num2 = (uint)(num32 ^ 0x78034022)) % 3)
											{
											case 0u:
												break;
											default:
												goto end_IL_56cf;
											case 2u:
												goto IL_56ed;
											case 1u:
												goto end_IL_56cf;
											}
											goto IL_56ca;
											IL_56ed:
											enumerator.Dispose();
											num32 = (int)(num2 * 1026194024) ^ -998289122;
											continue;
											end_IL_56cf:
											break;
										}
										break;
									}
								}
							}
							goto IL_5705;
						}
						IL_7048:
						if (!skill.IsSpecial)
						{
							num91 = 2100665432;
							num92 = num91;
						}
						else
						{
							num91 = 88182156;
							num92 = num91;
						}
						goto IL_5ca2;
						IL_6fd3:
						if (flag4)
						{
							num91 = 1203208753;
							num95 = num91;
						}
						else
						{
							num91 = 1306878338;
							num95 = num91;
						}
						goto IL_5ca2;
						IL_5ca2:
						while (true)
						{
							int num108;
							switch ((num2 = (uint)(num91 ^ 0x78034022)) % 145)
							{
							case 0u:
								break;
							case 28u:
								num102 = (int)((double)(role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3583101943u)] * 2 * role.EquippedInternalSkill.Level / 10 * (role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(400004197u)] / 100 + 2 - role2.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(400004197u)] / 100)) * Tools.GetRandom(1.0, 1.5));
								num91 = (int)((num2 * 638998765) ^ 0x370F2414);
								continue;
							case 75u:
								goto IL_5f88;
							case 43u:
								num222 = (source.MaxMp - source.Mp) * 2;
								num91 = (int)(num2 * 2128307471) ^ -2147117987;
								continue;
							case 134u:
								source.Hp += num224;
								num91 = ((int)num2 * -794551464) ^ -1560586565;
								continue;
							case 95u:
								attackResult.AddAttackInfo2(source, string.Format(ResourceStrings.ResStrings[764], -num222), Color.red, skill.AttackTime);
								num91 = (int)((num2 * 961100860) ^ 0x5A740084);
								continue;
							case 81u:
							{
								buff4.Round = 3;
								BuffInstance buff6 = new BuffInstance
								{
									buff = buff4,
									Owner = source,
									LeftRound = buff4.Round
								};
								int num246;
								int num247;
								if (!target.AddBuffOnly(buff6))
								{
									num246 = 936030219;
									num247 = num246;
								}
								else
								{
									num246 = 509468037;
									num247 = num246;
								}
								num91 = num246 ^ (int)(num2 * 479837481);
								continue;
							}
							case 59u:
								bf.func_jiushen(skill, source, target, attackResult);
								num91 = ((int)num2 * -1941858911) ^ 0x32C47FB7;
								continue;
							case 82u:
								attackResult.AddAttackInfo2(source, string.Format(ResourceStrings.ResStrings[818], num225), Color.blue, skill.AttackTime);
								num91 = 1150486069;
								continue;
							case 47u:
								num102 = 1;
								num91 = (int)(num2 * 950950528) ^ -333722594;
								continue;
							case 87u:
								goto IL_60f4;
							case 7u:
								source.Mp += num225;
								target.Mp -= num225;
								num91 = (int)((num2 * 1404113374) ^ 0x44FBCCE0);
								continue;
							case 69u:
								goto IL_6142;
							case 35u:
							{
								num225 = role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1790491204u)] * role.EquippedInternalSkill.Level / 10 * (role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(400004197u)] / 100 + 2 - role2.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1923523063u)] / 100);
								int num228;
								int num229;
								if (num225 >= 1)
								{
									num228 = -1664309247;
									num229 = num228;
								}
								else
								{
									num228 = -1499875693;
									num229 = num228;
								}
								num91 = num228 ^ ((int)num2 * -2133999934);
								continue;
							}
							case 91u:
								goto IL_61df;
							case 130u:
								attackResult.Debuff.Add(buff3);
								attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[281], 0.3f, skill.AttackTime);
								num91 = ((int)num2 * -1758017182) ^ 0x677C0A5;
								continue;
							case 74u:
								Log(string.Format(ResourceStrings.ResStrings[817], role.Name, num224));
								num91 = ((int)num2 * -1049589563) ^ -5157987;
								continue;
							case 78u:
								goto IL_627a;
							case 67u:
								Log(string.Format(ResourceStrings.ResStrings[811], battleSprite.Role.Name));
								num91 = ((int)num2 * -352437181) ^ -1476882071;
								continue;
							case 34u:
								num102 = target.Mp;
								num91 = (int)(num2 * 886602362) ^ -523001994;
								continue;
							case 96u:
								goto IL_62ea;
							case 37u:
								num223 += 0.05f;
								num91 = (int)(num2 * 343743152) ^ -1687258601;
								continue;
							case 3u:
								goto IL_6323;
							case 84u:
								text = string.Format(ResourceStrings.ResStrings[833], -attackResult.costBall);
								num91 = 960806168;
								continue;
							case 72u:
								num91 = ((int)num2 * -1959358761) ^ 0x272E1ABD;
								continue;
							case 48u:
								goto IL_637f;
							case 63u:
								target.Balls -= attackResult.costBall;
								num91 = (int)((num2 * 558323014) ^ 0x295E6E4C);
								continue;
							case 31u:
								Log(string.Format(ResourceStrings.ResStrings[822], role.Name, role2.Name, num105));
								num91 = (int)((num2 * 791392073) ^ 0x3587F657);
								continue;
							case 119u:
								attackResult.AddAttackInfo2(target, text, Color.blue, skill.AttackTime);
								target.Mp -= attackResult.Mp;
								num91 = 1246033593;
								continue;
							case 120u:
								attackResult.AddAttackInfo2(target, string.Format(ResourceStrings.ResStrings[798], -num222), Color.blue, skill.AttackTime);
								Log(string.Format(ResourceStrings.ResStrings[765], role.Name, role.Name, -num222));
								num91 = ((int)num2 * -790750924) ^ -1470527612;
								continue;
							case 116u:
								num224 /= 2;
								Log(string.Format(ResourceStrings.ResStrings[802], role.Name));
								num91 = (int)(num2 * 869219410) ^ -115733745;
								continue;
							case 135u:
								Log(string.Format(ResourceStrings.ResStrings[821], role.Name, role2.Name, num105));
								num91 = (int)(num2 * 775536040) ^ -15204695;
								continue;
							case 138u:
								goto IL_6523;
							case 127u:
								num248 = (int)((double)attackResult.Hp * 0.667);
								num91 = ((int)num2 * -1767165177) ^ 0x35BC72EC;
								continue;
							case 109u:
								goto IL_6570;
							case 100u:
								num91 = ((int)num2 * -428022692) ^ -1587907520;
								continue;
							case 142u:
								goto IL_65aa;
							case 108u:
							{
								int num242;
								int num243;
								if (num222 >= 0)
								{
									num242 = 894127997;
									num243 = num242;
								}
								else
								{
									num242 = 1565105539;
									num243 = num242;
								}
								num91 = num242 ^ ((int)num2 * -1439468767);
								continue;
							}
							case 45u:
								num225 = 1;
								num91 = (int)(num2 * 180715076) ^ -583812795;
								continue;
							case 32u:
							{
								int num238;
								int num239;
								if (name.StartsWith(ResourceStrings.ResStrings[709]))
								{
									num238 = 1465074542;
									num239 = num238;
								}
								else
								{
									num238 = 1500875316;
									num239 = num238;
								}
								num91 = num238 ^ (int)(num2 * 1730733620);
								continue;
							}
							case 23u:
								num91 = (int)(num2 * 650527044) ^ -1173657436;
								continue;
							case 114u:
								goto IL_6648;
							case 50u:
							{
								int num232;
								int num233;
								if (flag5)
								{
									num232 = -1722312508;
									num233 = num232;
								}
								else
								{
									num232 = -1858670498;
									num233 = num232;
								}
								num91 = num232 ^ (int)(num2 * 1537588917);
								continue;
							}
							case 49u:
								attackResult.AddAttackInfo2(source, string.Format(ResourceStrings.ResStrings[818], num102), Color.blue, skill.AttackTime);
								num91 = 1686743602;
								continue;
							case 118u:
								goto IL_66c3;
							case 98u:
							{
								int num220;
								int num221;
								if (source.GetBuff(ResourceStrings.ResStrings[544]) == null)
								{
									num220 = -162562481;
									num221 = num220;
								}
								else
								{
									num220 = -217951062;
									num221 = num220;
								}
								num91 = num220 ^ ((int)num2 * -679419931);
								continue;
							}
							case 9u:
								buff4.Name = ResourceStrings.ResStrings[550];
								num91 = ((int)num2 * -16582854) ^ -235692213;
								continue;
							case 94u:
								num222 = (int)((double)(role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3583101943u)] * 2 * role.EquippedInternalSkill.Level / 10 * (role.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(912726802u)] / 100 + 2 - role2.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(912726802u)] / 100)) * Tools.GetRandom(1.0, 2.0));
								num91 = ((int)num2 * -323082632) ^ -501001157;
								continue;
							case 13u:
								attackResult.AddAttackInfo2(target, string.Format(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3528104119u), attackResult.Hp), Color.white, skill.AttackTime);
								Log(string.Format(ResourceStrings.ResStrings[830], role2.Name, attackResult.Hp));
								num91 = 1827214120;
								continue;
							case 2u:
								target.Mp -= num105;
								num91 = (int)(num2 * 104152831) ^ -2089161809;
								continue;
							case 38u:
								goto IL_6855;
							case 70u:
								if (num68 == 1)
								{
									num91 = 1318486570;
									continue;
								}
								goto IL_79d9;
							case 117u:
								num105 = role.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1790491204u)] * role.EquippedInternalSkill.Level / 10 * 3 * (role.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3406067330u)] / 100 + 2 - role2.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3406067330u)] / 100);
								num91 = (int)((num2 * 885232743) ^ 0x4DBA87AF);
								continue;
							case 4u:
								num91 = ((int)num2 * -1211987370) ^ 0x575C0723;
								continue;
							case 62u:
								goto IL_6905;
							case 61u:
							{
								int num255;
								int num256;
								if (!role.BuiltInTalents[129])
								{
									num255 = -56663452;
									num256 = num255;
								}
								else
								{
									num255 = -1450904591;
									num256 = num255;
								}
								num91 = num255 ^ (int)(num2 * 808693695);
								continue;
							}
							case 124u:
							{
								int num253;
								int num254;
								if (attackResult.costBall <= 0)
								{
									num253 = -1800464256;
									num254 = num253;
								}
								else
								{
									num253 = -1894667722;
									num254 = num253;
								}
								num91 = num253 ^ (int)(num2 * 1985520837);
								continue;
							}
							case 33u:
								num222 = target.Mp;
								num91 = ((int)num2 * -1401540544) ^ 0x79DF14E5;
								continue;
							case 132u:
								target.Hp -= attackResult.Hp;
								num91 = 1684409212;
								continue;
							case 52u:
								num223 += 0.15f;
								num91 = 345648973;
								continue;
							case 131u:
								goto IL_69ca;
							case 86u:
								goto IL_6a0e;
							case 126u:
								target.Hp -= attackResult.Hp;
								num91 = (int)(num2 * 13688680) ^ -1883161196;
								continue;
							case 14u:
								text = string.Format(ResourceStrings.ResStrings[797], attackResult.Mp);
								num91 = ((int)num2 * -1798036885) ^ -665659275;
								continue;
							case 29u:
								goto IL_6a89;
							case 55u:
								attackResult.AddAttackInfo2(source, string.Format(ResourceStrings.ResStrings[818], num222), Color.blue, skill.AttackTime);
								Log(string.Format(ResourceStrings.ResStrings[823], role.Name, role2.Name, num222));
								num91 = 79385372;
								continue;
							case 22u:
								goto IL_6b28;
							case 93u:
								buff4 = new Buff();
								num91 = ((int)num2 * -1564080252) ^ -184124598;
								continue;
							case 140u:
								attackResult.Hp = (int)((double)attackResult.Hp * Tools.GetRandom(1.1, 1.4));
								source.DeleteBuff(ResourceStrings.ResStrings[541]);
								num91 = ((int)num2 * -880522557) ^ 0x5A7352DC;
								continue;
							case 90u:
								goto IL_6bb4;
							case 21u:
							{
								int num251;
								int num252;
								if (attackResult.Mp <= 0)
								{
									num251 = -1220289985;
									num252 = num251;
								}
								else
								{
									num251 = -464753725;
									num252 = num251;
								}
								num91 = num251 ^ (int)(num2 * 1137000470);
								continue;
							}
							case 53u:
								attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[815], 0.3f, skill.AttackTime);
								num223 += 0.15f;
								num91 = (int)((num2 * 1600567864) ^ 0x7493110C);
								continue;
							case 5u:
								attackResult.AddAttackInfo2(target, ResourceStrings.ResStrings[828] + string.Format(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(472421871u), attackResult.Hp), Color.yellow, skill.AttackTime);
								num91 = (int)(num2 * 768307213) ^ -68280262;
								continue;
							case 66u:
								goto IL_6cad;
							case 57u:
								goto IL_6ccf;
							case 115u:
							{
								int num249;
								int num250;
								if (name == ResourceStrings.ResStrings[710])
								{
									num249 = -95282188;
									num250 = num249;
								}
								else
								{
									num249 = -979894318;
									num250 = num249;
								}
								num91 = num249 ^ (int)(num2 * 1056080535);
								continue;
							}
							case 73u:
								source.Mp -= num105;
								num91 = (int)((num2 * 990678194) ^ 0x3935A6B8);
								continue;
							case 121u:
								goto IL_6d3f;
							case 60u:
								battleSprite.Hp -= num248;
								attackResult.AddAttackInfo2(battleSprite, string.Format(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3528104119u), num248), Color.yellow, skill.AttackTime);
								num91 = (int)(num2 * 1653066957) ^ -2075703681;
								continue;
							case 76u:
							{
								int num244;
								int num245;
								if (attackResult.Critical)
								{
									num244 = 525929773;
									num245 = num244;
								}
								else
								{
									num244 = 1135441807;
									num245 = num244;
								}
								num91 = num244 ^ (int)(num2 * 319244369);
								continue;
							}
							case 139u:
								buff3.Property = 100;
								num91 = (int)(num2 * 173619669) ^ -92564332;
								continue;
							case 136u:
								attackResult.AddAttackInfo2(source, string.Format(ResourceStrings.ResStrings[797], num105), Color.blue, skill.AttackTime);
								num91 = ((int)num2 * -115695336) ^ -906773632;
								continue;
							case 26u:
								Log(string.Format(ResourceStrings.ResStrings[829], role2.Name, attackResult.Hp));
								num91 = ((int)num2 * -735719840) ^ 0x4CF48F34;
								continue;
							case 102u:
								num222 /= 2;
								num91 = (int)(num2 * 2065221302) ^ -314455143;
								continue;
							case 106u:
								num223 = role.xiValue;
								num91 = 1948648263;
								continue;
							case 80u:
							{
								int num240;
								int num241;
								if (skill.HitSelf)
								{
									num240 = 130007060;
									num241 = num240;
								}
								else
								{
									num240 = 1273827574;
									num241 = num240;
								}
								num91 = num240 ^ ((int)num2 * -888951734);
								continue;
							}
							case 99u:
								target.Mp -= num102;
								num91 = (int)(num2 * 1858608016) ^ -1969715820;
								continue;
							case 36u:
								goto IL_6ee3;
							case 128u:
								num91 = ((int)num2 * -1466134350) ^ 0x747D3D27;
								continue;
							case 113u:
							{
								int num236;
								int num237;
								if (flag5)
								{
									num236 = 1995789585;
									num237 = num236;
								}
								else
								{
									num236 = 490879440;
									num237 = num236;
								}
								num91 = num236 ^ ((int)num2 * -1694421591);
								continue;
							}
							case 8u:
								randomInt2 = Tools.GetRandomInt(0, Buff.DebuffNames.Length - 1);
								num91 = 1692983997;
								continue;
							case 88u:
								Log(string.Format(ResourceStrings.ResStrings[834], role.Name, role2.Name, buff3.Name));
								num91 = (int)(num2 * 1761090712) ^ -1092618261;
								continue;
							case 83u:
								goto IL_6f8f;
							case 112u:
								num225 = target.Mp;
								num91 = ((int)num2 * -609684321) ^ -853651997;
								continue;
							case 97u:
								goto IL_6fd3;
							case 85u:
								goto IL_6fea;
							case 107u:
								Log(string.Format(ResourceStrings.ResStrings[827], role.Name, role2.Name, randomInt));
								num91 = (int)(num2 * 1210444482) ^ -90257433;
								continue;
							case 104u:
								goto IL_7048;
							case 143u:
								randomInt = Tools.GetRandomInt(10, 40);
								num91 = ((int)num2 * -1553946439) ^ -709991110;
								continue;
							case 141u:
								goto IL_7082;
							case 58u:
								attackResult.AddCastInfo2(battleSprite, ResourceStrings.ResStrings[810], 1f, skill.AttackTime);
								num91 = (int)(num2 * 682828017) ^ -1453627734;
								continue;
							case 42u:
								num105 = target.Mp;
								num91 = ((int)num2 * -185562651) ^ 0xDAB507F;
								continue;
							case 46u:
								text = string.Format(ResourceStrings.ResStrings[798], -attackResult.Mp);
								num91 = 384162140;
								continue;
							case 44u:
								goto IL_7127;
							case 92u:
								goto IL_7150;
							case 77u:
								attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[814], 0.3f, skill.AttackTime);
								num223 += 0.2f;
								num91 = ((int)num2 * -1668677413) ^ 0x583CD603;
								continue;
							case 39u:
								num225 = (source.MaxMp - source.Mp) * 2;
								num91 = ((int)num2 * -568731261) ^ -1095190624;
								continue;
							case 103u:
							{
								int num234;
								int num235;
								if (name == ResourceStrings.ResStrings[711])
								{
									num234 = -305101306;
									num235 = num234;
								}
								else
								{
									num234 = -1627974424;
									num235 = num234;
								}
								num91 = num234 ^ (int)(num2 * 1964074980);
								continue;
							}
							case 20u:
								goto IL_7214;
							case 110u:
							{
								int num230;
								int num231;
								if (flag5)
								{
									num230 = 1049590131;
									num231 = num230;
								}
								else
								{
									num230 = 1750546618;
									num231 = num230;
								}
								num91 = num230 ^ ((int)num2 * -802910840);
								continue;
							}
							case 68u:
								goto IL_7254;
							case 129u:
								buff3 = new Buff();
								buff3.Name = Buff.DebuffNames[randomInt2];
								num91 = ((int)num2 * -1310478699) ^ 0x3154F02C;
								continue;
							case 30u:
								attackResult.AddAttackInfo2(target, string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4136909829u), -attackResult.Hp), Color.green, skill.AttackTime);
								Log(string.Format(ResourceStrings.ResStrings[831], role2.Name, -attackResult.Hp));
								num91 = ((int)num2 * -1837289738) ^ 0x5FBA3237;
								continue;
							case 41u:
								attackResult.AddAttackInfo2(source, string.Format(ResourceStrings.ResStrings[806], num224), Color.red, skill.AttackTime);
								num91 = 1037660634;
								continue;
							case 15u:
								num98 = role.AttributesFinal[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(788062007u)];
								num91 = (int)((num2 * 842292816) ^ 0x17117B8E);
								continue;
							case 111u:
							{
								int num226;
								int num227;
								if (source.GetBuff(ResourceStrings.ResStrings[541]) != null)
								{
									num226 = -720929748;
									num227 = num226;
								}
								else
								{
									num226 = -959153648;
									num227 = num226;
								}
								num91 = num226 ^ ((int)num2 * -1134684058);
								continue;
							}
							case 65u:
								attackResult.AddAttackInfo2(target, string.Format(ResourceStrings.ResStrings[826], randomInt), Color.yellow, skill.AttackTime);
								num91 = (int)(num2 * 725069478) ^ -847677238;
								continue;
							case 11u:
								Log(string.Format(ResourceStrings.ResStrings[820], role.Name, role2.Name, num225));
								num91 = (int)((num2 * 1954117065) ^ 0x1070D3FB);
								continue;
							case 64u:
								Log(string.Format(ResourceStrings.ResStrings[819], role.Name, role2.Name, num102));
								num91 = ((int)num2 * -941033761) ^ -245893562;
								continue;
							case 51u:
								num105 = -(num105 / 2);
								num91 = ((int)num2 * -976350121) ^ 0x14616969;
								continue;
							case 56u:
								num224 = (int)((float)hp * Math.Min(num223, 0.5f));
								num91 = ((int)num2 * -523906609) ^ -2066655549;
								continue;
							case 137u:
								goto IL_74b4;
							case 89u:
								goto IL_74e2;
							case 122u:
								attackResult.AddAttackInfo2(target, string.Format(ResourceStrings.ResStrings[797], num105), Color.blue, skill.AttackTime);
								num91 = 143749271;
								continue;
							case 133u:
								attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[816], 0.3f, skill.AttackTime);
								num223 += 0.05f + (float)((double)(0.05f * (float)role.Level) / 30.0);
								num91 = (int)(num2 * 200458148) ^ -50248792;
								continue;
							case 19u:
							{
								int num218;
								int num219;
								if (num102 >= 1)
								{
									num218 = 616926135;
									num219 = num218;
								}
								else
								{
									num218 = 622936483;
									num219 = num218;
								}
								num91 = num218 ^ (int)(num2 * 1146838821);
								continue;
							}
							case 17u:
							{
								int num216;
								int num217;
								if (num105 <= target.Mp)
								{
									num216 = -655429568;
									num217 = num216;
								}
								else
								{
									num216 = -1766781007;
									num217 = num216;
								}
								num91 = num216 ^ ((int)num2 * -24685553);
								continue;
							}
							case 40u:
								target.Sp -= randomInt;
								num91 = ((int)num2 * -97156548) ^ -297169332;
								continue;
							case 71u:
								goto IL_7602;
							case 79u:
							{
								int num106;
								int num107;
								if (!flag5)
								{
									num106 = -1354860689;
									num107 = num106;
								}
								else
								{
									num106 = -18544350;
									num107 = num106;
								}
								num91 = num106 ^ (int)(num2 * 900124768);
								continue;
							}
							case 25u:
								attackResult.AddAttackInfo2(target, ResourceStrings.ResStrings[824], Color.red, skill.AttackTime);
								bf.ShowSkillAnimation(skill, target.X, target.Y, null);
								Log(string.Format(ResourceStrings.ResStrings[825], role2.Name));
								num91 = (int)((num2 * 1044597444) ^ 0x11EADD7A);
								continue;
							case 12u:
								attackResult.AddAttackInfo2(target, text, Color.cyan, skill.AttackTime);
								num91 = 1218272045;
								continue;
							case 125u:
								goto IL_76d8;
							case 105u:
								buff3.Level = 3;
								num91 = (int)((num2 * 757268367) ^ 0x4C69C374);
								continue;
							case 1u:
							{
								int num103;
								int num104;
								if (!(name == ResourceStrings.ResStrings[713]))
								{
									num103 = -226757105;
									num104 = num103;
								}
								else
								{
									num103 = -194991842;
									num104 = num103;
								}
								num91 = num103 ^ (int)(num2 * 1042433545);
								continue;
							}
							case 10u:
								goto IL_7746;
							case 24u:
								attackResult.Hp = (int)((double)attackResult.Hp * 0.333);
								battleSprite = list2[Tools.GetRandomInt(0, list2.Count) % list2.Count];
								num91 = (int)(num2 * 280899881) ^ -1442707689;
								continue;
							case 27u:
								text = string.Format(ResourceStrings.ResStrings[832], attackResult.costBall);
								num91 = ((int)num2 * -528578376) ^ 0x6D0E7CA1;
								continue;
							case 18u:
								num102 = (source.MaxMp - source.Mp) * 2;
								num91 = (int)((num2 * 103228190) ^ 0x6773D440);
								continue;
							case 54u:
								buff4.Level = 0;
								num91 = ((int)num2 * -967057021) ^ 0x5259F2C0;
								continue;
							case 101u:
								source.Mp += num102;
								num91 = ((int)num2 * -1747563608) ^ -7207270;
								continue;
							case 16u:
								attackResult.AddCastInfo2(source, string.Format(ResourceStrings.ResStrings[812], role.Name), 1f, skill.AttackTime);
								Log(string.Format(ResourceStrings.ResStrings[813], role.Name));
								num91 = ((int)num2 * -480264861) ^ 0x7926A03C;
								continue;
							case 123u:
							{
								int num100;
								int num101;
								if (!(name == ResourceStrings.ResStrings[712]))
								{
									num100 = -256073496;
									num101 = num100;
								}
								else
								{
									num100 = -345137740;
									num101 = num100;
								}
								num91 = num100 ^ ((int)num2 * -1143532291);
								continue;
							}
							case 6u:
								buff3.Round = 3;
								num91 = ((int)num2 * -1649458408) ^ -982221550;
								continue;
							default:
								{
									using (List<Buff>.Enumerator enumerator2 = attackResult.Buff.GetEnumerator())
									{
										while (true)
										{
											IL_79ac:
											int num96;
											int num97;
											if (!enumerator2.MoveNext())
											{
												num96 = 1714618083;
												num97 = num96;
											}
											else
											{
												num96 = 1101431157;
												num97 = num96;
											}
											while (true)
											{
												switch ((num2 = (uint)(num96 ^ 0x78034022)) % 4)
												{
												case 2u:
													num96 = 1101431157;
													continue;
												default:
													goto end_IL_790d;
												case 3u:
												{
													Buff current3 = enumerator2.Current;
													current3.Level = (int)((double)current3.Level * (1.0 + num98 * 0.002) + 0.5);
													int num99 = (int)num98 / 500;
													if (Tools.ProbabilityTest(num98 / 500.0))
													{
														num99++;
													}
													if (num99 > 2)
													{
														num99 = 2;
													}
													current3.Round += num99;
													num96 = 37216754;
													continue;
												}
												case 0u:
													break;
												case 1u:
													goto end_IL_790d;
												}
												goto IL_79ac;
												continue;
												end_IL_790d:
												break;
											}
											break;
										}
									}
									goto IL_79d9;
								}
								IL_7a3a:
								battleSprite2 = source;
								num108 = 1060195700;
								goto IL_79e6;
								IL_79e6:
								while (true)
								{
									int num113;
									int num162;
									double num165;
									double num166;
									double num185;
									int num186;
									int num187;
									int num211;
									switch ((num2 = (uint)(num108 ^ 0x78034022)) % 7)
									{
									case 3u:
										break;
									case 5u:
									{
										int num214;
										int num215;
										if (!((Object)(object)source != (Object)(object)target))
										{
											num214 = -2026808634;
											num215 = num214;
										}
										else
										{
											num214 = -449900356;
											num215 = num214;
										}
										num108 = num214 ^ (int)(num2 * 1489637558);
										continue;
									}
									case 2u:
										goto IL_7a3a;
									case 6u:
									{
										int num212;
										int num213;
										if (source.Team == target.Team)
										{
											num212 = -1401118018;
											num213 = num212;
										}
										else
										{
											num212 = -1700975822;
											num213 = num212;
										}
										num108 = num212 ^ ((int)num2 * -974847622);
										continue;
									}
									case 4u:
										num108 = (int)((num2 * 1190225747) ^ 0x4A25BE88);
										continue;
									case 0u:
										battleSprite2 = target;
										num108 = (int)(num2 * 412119400) ^ -1220414538;
										continue;
									default:
										{
											using (List<Buff>.Enumerator enumerator2 = attackResult.Buff.GetEnumerator())
											{
												while (true)
												{
													IL_7ada:
													int num109;
													int num110;
													if (enumerator2.MoveNext())
													{
														num109 = 472160283;
														num110 = num109;
													}
													else
													{
														num109 = 740825212;
														num110 = num109;
													}
													while (true)
													{
														switch ((num2 = (uint)(num109 ^ 0x78034022)) % 6)
														{
														case 2u:
															num109 = 472160283;
															continue;
														default:
															goto end_IL_7aad;
														case 3u:
															break;
														case 4u:
														{
															int num111;
															int num112;
															if (battleSprite2.AddBuffOnly(buff5))
															{
																num111 = -1528173183;
																num112 = num111;
															}
															else
															{
																num111 = -1070977831;
																num112 = num111;
															}
															num109 = num111 ^ (int)(num2 * 2063501613);
															continue;
														}
														case 5u:
															attackResult.AddAttackInfo2(battleSprite2, current4.Name + global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2303469568u) + current4.Level + global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2723692654u), Color.yellow, skill.AttackTime);
															Log(string.Format(ResourceStrings.ResStrings[835], battleSprite2.Role.Name, current4.Name, current4.Level));
															num109 = ((int)num2 * -2122149027) ^ 0xDF6A86E;
															continue;
														case 1u:
															current4 = enumerator2.Current;
															buff5 = new BuffInstance
															{
																buff = current4,
																Owner = battleSprite2,
																Level = current4.Level,
																LeftRound = current4.Round
															};
															num109 = 1608978242;
															continue;
														case 0u:
															goto end_IL_7aad;
														}
														goto IL_7ada;
														continue;
														end_IL_7aad:
														break;
													}
													break;
												}
											}
											if (target.HasBuff(ResourceStrings.ResStrings[543]))
											{
												goto IL_7c28;
											}
											goto IL_7cd6;
										}
										IL_8800:
										while (true)
										{
											switch ((num2 = (uint)(num113 ^ 0x78034022)) % 39)
											{
											case 4u:
												break;
											case 26u:
												num117 = 1;
												num113 = (int)((num2 * 1041636763) ^ 0xC725D61);
												continue;
											case 24u:
												num132 = 0.67;
												num136 = 0.22;
												num113 = 1344826177;
												continue;
											case 8u:
												num139++;
												num113 = ((int)num2 * -987387364) ^ -52285536;
												continue;
											case 12u:
												Log(string.Format(ResourceStrings.ResStrings[842], role2.Name));
												num113 = ((int)num2 * -1167879671) ^ 0x32D1DEF2;
												continue;
											case 9u:
												goto IL_8933;
											case 1u:
											{
												num144 = 0.5 + (double)role2.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1550623476u)] / (double)BattleField.ROLE_MAX_ATTRIBUTE[role2] * 0.3;
												int num145;
												int num146;
												if (!role2.BuiltInTalents[46])
												{
													num145 = 394118793;
													num146 = num145;
												}
												else
												{
													num145 = 14275311;
													num146 = num145;
												}
												num113 = num145 ^ ((int)num2 * -1437584216);
												continue;
											}
											case 3u:
											{
												int num151;
												int num152;
												if (!role.HasTalent(ResourceStrings.ResStrings[1254]))
												{
													num151 = 1325215095;
													num152 = num151;
												}
												else
												{
													num151 = 226411470;
													num152 = num151;
												}
												num113 = num151 ^ (int)(num2 * 1366352670);
												continue;
											}
											case 32u:
											{
												int num155;
												int num156;
												if (num116 > 0.5)
												{
													num155 = -337647388;
													num156 = num155;
												}
												else
												{
													num155 = -618719019;
													num156 = num155;
												}
												num113 = num155 ^ ((int)num2 * -1354391099);
												continue;
											}
											case 6u:
												attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[283], 0.3f, skill.AttackTime);
												Log(string.Format(ResourceStrings.ResStrings[844], role.Name));
												num113 = ((int)num2 * -776771408) ^ 0xD93B172;
												continue;
											case 23u:
												target.Balls += num139;
												num113 = 1533999725;
												continue;
											case 20u:
												goto IL_8a7f;
											case 14u:
											{
												int num147;
												int num148;
												if (!(name == ResourceStrings.ResStrings[618]))
												{
													num147 = -1732628136;
													num148 = num147;
												}
												else
												{
													num147 = -1073773445;
													num148 = num147;
												}
												num113 = num147 ^ (int)(num2 * 2092333072);
												continue;
											}
											case 29u:
											{
												num139 = 1;
												int num140;
												int num141;
												if (role2.BuiltInTalents[124])
												{
													num140 = -1412866566;
													num141 = num140;
												}
												else
												{
													num140 = -1039744131;
													num141 = num140;
												}
												num113 = num140 ^ ((int)num2 * -1143384024);
												continue;
											}
											case 31u:
												num116 += Tools.GetRandom(0.01, 0.5);
												num113 = (int)(num2 * 662687890) ^ -871186869;
												continue;
											case 13u:
												goto IL_8b3d;
											case 28u:
												num117 = 1;
												num116 += Tools.GetRandom(0.01, 0.6);
												num113 = (int)(num2 * 431785293) ^ -709890701;
												continue;
											case 18u:
												num113 = (int)((num2 * 597440007) ^ 0x34B02287);
												continue;
											case 16u:
												num117 = 1;
												num116 += (double)(0.005f * (float)role.Level);
												num113 = ((int)num2 * -1948669360) ^ 0x62430F17;
												continue;
											case 15u:
											{
												int num153;
												int num154;
												if (num68 == 2)
												{
													num153 = 699989812;
													num154 = num153;
												}
												else
												{
													num153 = 402165801;
													num154 = num153;
												}
												num113 = num153 ^ ((int)num2 * -2011946459);
												continue;
											}
											case 38u:
												attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[284], 0.3f, skill.AttackTime);
												Log(string.Format(ResourceStrings.ResStrings[845], role.Name));
												num113 = ((int)num2 * -421226324) ^ 0x1415537E;
												continue;
											case 21u:
												num117 = 1;
												num113 = ((int)num2 * -1936810688) ^ -824308096;
												continue;
											case 27u:
												goto IL_8c5a;
											case 25u:
												num116 += Tools.GetRandom(0.1, 0.6);
												attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[1255], 0.5f, skill.AttackTime);
												num113 = (int)(num2 * 1350072051) ^ -241466097;
												continue;
											case 35u:
												num117 = 1;
												num113 = ((int)num2 * -1370385262) ^ -2031770789;
												continue;
											case 36u:
												num132 = 0.6;
												num136 = 0.299;
												num113 = (int)(num2 * 757803130) ^ -382072274;
												continue;
											case 0u:
												num144 += 0.15;
												num113 = (int)((num2 * 12452656) ^ 0x53AA98B9);
												continue;
											case 37u:
												num113 = ((int)num2 * -1713622941) ^ 0x788342BA;
												continue;
											case 5u:
												Log(string.Format(ResourceStrings.ResStrings[843], role2.Name));
												num113 = (int)((num2 * 1179879971) ^ 0x6B59E99B);
												continue;
											case 22u:
												attackResult.AddAttackInfo2(target, string.Format(ResourceStrings.ResStrings[833], num139), Color.cyan, skill.AttackTime);
												num113 = (int)((num2 * 1435491609) ^ 0x2B0C4D2F);
												continue;
											case 34u:
											{
												num116 += (double)(0.003f * (float)role.Level);
												int num149;
												int num150;
												if (num116 <= 0.5)
												{
													num149 = 1735893271;
													num150 = num149;
												}
												else
												{
													num149 = 380191444;
													num150 = num149;
												}
												num113 = num149 ^ (int)(num2 * 1354983476);
												continue;
											}
											case 10u:
												num117 = 0;
												num116 = 0.0;
												num113 = 308083841;
												continue;
											case 11u:
												num116 = 0.5;
												num113 = ((int)num2 * -685124493) ^ 0x3EE996A1;
												continue;
											case 19u:
												num116 = 0.5;
												num113 = ((int)num2 * -415877801) ^ -206262323;
												continue;
											case 17u:
												goto IL_8e43;
											case 2u:
												goto IL_8e66;
											case 30u:
											{
												int num142;
												int num143;
												if (target.GetBuff(ResourceStrings.ResStrings[519]) != null)
												{
													num142 = 1840836989;
													num143 = num142;
												}
												else
												{
													num142 = 1806946159;
													num143 = num142;
												}
												num113 = num142 ^ ((int)num2 * -1706882545);
												continue;
											}
											case 7u:
												target.DeleteBuff(ResourceStrings.ResStrings[519]);
												attackResult.AddAttackInfo2(target, ResourceStrings.ResStrings[618], Color.white, skill.AttackTime);
												num113 = (int)(num2 * 77321371) ^ -1553536788;
												continue;
											default:
											{
												using (List<BuffInstance>.Enumerator enumerator3 = source.Buffs.GetEnumerator())
												{
													while (true)
													{
														IL_8ff4:
														int num114;
														int num115;
														if (!enumerator3.MoveNext())
														{
															num114 = 1008970646;
															num115 = num114;
														}
														else
														{
															num114 = 2132715919;
															num115 = num114;
														}
														while (true)
														{
															switch ((num2 = (uint)(num114 ^ 0x78034022)) % 18)
															{
															case 17u:
																num114 = 2132715919;
																continue;
															default:
																goto end_IL_8f22;
															case 11u:
																num116 += Tools.GetRandom(0.05, (float)current5.Level * 0.1f);
																num114 = 34070632;
																continue;
															case 4u:
															{
																int num120;
																int num121;
																if (name2 == ResourceStrings.ResStrings[528])
																{
																	num120 = 1649469481;
																	num121 = num120;
																}
																else
																{
																	num120 = 1075809763;
																	num121 = num120;
																}
																num114 = num120 ^ (int)(num2 * 1397636293);
																continue;
															}
															case 0u:
																num114 = (int)(num2 * 2084933120) ^ -1749594536;
																continue;
															case 14u:
																break;
															case 9u:
															{
																int num124;
																if (!(name2 == ResourceStrings.ResStrings[527]))
																{
																	num114 = 191644248;
																	num124 = num114;
																}
																else
																{
																	num114 = 1890744830;
																	num124 = num114;
																}
																continue;
															}
															case 6u:
																num117 = 1;
																num114 = ((int)num2 * -1151224307) ^ 0x5D7DAD9D;
																continue;
															case 13u:
																num116 = 1.0;
																num114 = (int)((num2 * 185766541) ^ 0x485F0553);
																continue;
															case 10u:
																num114 = (int)(num2 * 379282126) ^ -397918196;
																continue;
															case 15u:
															{
																int num125;
																int num126;
																if (!(name2 == ResourceStrings.ResStrings[526]))
																{
																	num125 = 701327903;
																	num126 = num125;
																}
																else
																{
																	num125 = 1378304604;
																	num126 = num125;
																}
																num114 = num125 ^ (int)(num2 * 32172203);
																continue;
															}
															case 16u:
																num116 += Tools.GetRandom(0.05, (float)current5.Level * 0.1f);
																num114 = 191644248;
																continue;
															case 1u:
																current5 = enumerator3.Current;
																num114 = 1698541715;
																continue;
															case 7u:
																name2 = current5.buff.Name;
																num114 = (int)((num2 * 461617213) ^ 0x5A4E3456);
																continue;
															case 2u:
															{
																int num123;
																if (num68 != 1)
																{
																	num114 = 1241505702;
																	num123 = num114;
																}
																else
																{
																	num114 = 609024049;
																	num123 = num114;
																}
																continue;
															}
															case 3u:
															{
																int num122;
																if (num117 >= 1)
																{
																	num114 = 1443279377;
																	num122 = num114;
																}
																else
																{
																	num114 = 1948444318;
																	num122 = num114;
																}
																continue;
															}
															case 12u:
															{
																num117 = 2;
																int num118;
																int num119;
																if (current5.Level >= 20)
																{
																	num118 = -2041824767;
																	num119 = num118;
																}
																else
																{
																	num118 = -32191726;
																	num119 = num118;
																}
																num114 = num118 ^ ((int)num2 * -1584639836);
																continue;
															}
															case 5u:
																num116 += (double)((float)current5.Level * 0.048f);
																num114 = ((int)num2 * -1006274440) ^ -1016434000;
																continue;
															case 8u:
																goto end_IL_8f22;
															}
															goto IL_8ff4;
															continue;
															end_IL_8f22:
															break;
														}
														break;
													}
												}
												int num127 = 0;
												while (true)
												{
													int num128;
													int num129;
													if (num127 < num117)
													{
														num128 = 748296384;
														num129 = num128;
													}
													else
													{
														num128 = 735162268;
														num129 = num128;
													}
													while (true)
													{
														switch ((num2 = (uint)(num128 ^ 0x78034022)) % 16)
														{
														case 15u:
															num128 = 748296384;
															continue;
														case 12u:
															target.Hp -= num130;
															num128 = 1688430305;
															continue;
														case 10u:
														{
															int num137;
															int num138;
															if (num130 > 0)
															{
																num137 = -148746367;
																num138 = num137;
															}
															else
															{
																num137 = -1463444117;
																num138 = num137;
															}
															num128 = num137 ^ ((int)num2 * -90171710);
															continue;
														}
														case 0u:
															num130 = (int)((double)attackResult.Hp * (num132 - num136 * (double)num127));
															num128 = 886484235;
															continue;
														case 4u:
															num130 = (int)((double)attackResult.Hp * num132);
															num128 = (int)(num2 * 902603607) ^ -2013296641;
															continue;
														case 14u:
															bf.RefreshSpritesOnly();
															num128 = ((int)num2 * -547178630) ^ 0x7182EDB;
															continue;
														case 9u:
														{
															int num131;
															if (num130 != 0)
															{
																num128 = 309971928;
																num131 = num128;
															}
															else
															{
																num128 = 1688430305;
																num131 = num128;
															}
															continue;
														}
														case 11u:
														{
															int num134;
															int num135;
															if (num68 == 1)
															{
																num134 = 1889190299;
																num135 = num134;
															}
															else
															{
																num134 = 1507820479;
																num135 = num134;
															}
															num128 = num134 ^ ((int)num2 * -2002348921);
															continue;
														}
														case 8u:
															Log(string.Format(ResourceStrings.ResStrings[849], role2.Name, -num130));
															num128 = (int)(num2 * 354600846) ^ -527181058;
															continue;
														case 6u:
															break;
														case 13u:
															attackResult.AddAttackInfo2(target, string.Format(ResourceStrings.ResStrings[847], -num130), Color.green, skill.AttackTime);
															num128 = 689232634;
															continue;
														case 2u:
														{
															int num133;
															if (Tools.ProbabilityTest(num116))
															{
																num128 = 378005849;
																num133 = num128;
															}
															else
															{
																num128 = 1688430305;
																num133 = num128;
															}
															continue;
														}
														case 3u:
															num127++;
															num128 = 756747972;
															continue;
														case 1u:
															num128 = ((int)num2 * -1236585027) ^ 0x39394C56;
															continue;
														case 7u:
															attackResult.AddAttackInfo2(target, string.Format(ResourceStrings.ResStrings[846], num130), attackResult.Critical ? Color.yellow : Color.white, skill.AttackTime);
															Log(string.Format(ResourceStrings.ResStrings[848], role2.Name, num130));
															num128 = 2109083950;
															continue;
														default:
															return attackResult;
														}
														break;
													}
												}
											}
											}
											break;
											IL_8e66:
											int num157;
											if (!role.BuiltInTalents[121])
											{
												num113 = 1028760476;
												num157 = num113;
											}
											else
											{
												num113 = 44601930;
												num157 = num113;
											}
											continue;
											IL_8a7f:
											int num158;
											if (role.HasTalent(ResourceStrings.ResStrings[1255]))
											{
												num113 = 2042961666;
												num158 = num113;
											}
											else
											{
												num113 = 644474678;
												num158 = num113;
											}
											continue;
											IL_8c5a:
											int num159;
											if (!Tools.ProbabilityTest(num144))
											{
												num113 = 1470245272;
												num159 = num113;
											}
											else
											{
												num113 = 666390506;
												num159 = num113;
											}
											continue;
											IL_8e43:
											int num160;
											if (role.BuiltInTalents[123])
											{
												num113 = 387626194;
												num160 = num113;
											}
											else
											{
												num113 = 1619590042;
												num160 = num113;
											}
											continue;
											IL_8b3d:
											int num161;
											if (!role.BuiltInTalents[122])
											{
												num113 = 421081906;
												num161 = num113;
											}
											else
											{
												num113 = 1419145747;
												num161 = num113;
											}
										}
										goto IL_87fb;
										IL_7cd6:
										if (num68 == 1)
										{
											num162 = 1463442677;
											goto IL_7c2d;
										}
										goto IL_808e;
										IL_87fb:
										num113 = 1393764270;
										goto IL_8800;
										IL_7c2d:
										while (true)
										{
											switch ((num2 = (uint)(num162 ^ 0x78034022)) % 7)
											{
											case 3u:
												break;
											case 5u:
											{
												int num163;
												int num164;
												if (!source.HasBuff(ResourceStrings.ResStrings[1200]))
												{
													num163 = 856917687;
													num164 = num163;
												}
												else
												{
													num163 = 2142693813;
													num164 = num163;
												}
												num162 = num163 ^ (int)(num2 * 873437601);
												continue;
											}
											case 6u:
												Log(string.Format(ResourceStrings.ResStrings[836], role2.Name));
												num162 = ((int)num2 * -1821266114) ^ -542476460;
												continue;
											case 4u:
												goto IL_7cd6;
											case 2u:
												goto IL_7ce8;
											default:
												goto IL_7d0c;
											case 0u:
												goto IL_87f5;
											}
											break;
										}
										goto IL_7c28;
										IL_7d0c:
										num165 = role.AttributesFinal[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1412133437u)];
										num166 = role2.AttributesFinal[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(400004197u)];
										using (List<Buff>.Enumerator enumerator2 = attackResult.Debuff.GetEnumerator())
										{
											while (true)
											{
												IL_8027:
												int num167;
												int num168;
												if (enumerator2.MoveNext())
												{
													num167 = 1024703792;
													num168 = num167;
												}
												else
												{
													num167 = 1103318124;
													num168 = num167;
												}
												while (true)
												{
													switch ((num2 = (uint)(num167 ^ 0x78034022)) % 22)
													{
													case 21u:
														num167 = 1024703792;
														continue;
													default:
														goto end_IL_7d54;
													case 16u:
														num170 = 2;
														num167 = (int)((num2 * 1580214999) ^ 0x65D963E5);
														continue;
													case 13u:
														num170++;
														num167 = (int)((num2 * 1026752274) ^ 0x1687715A);
														continue;
													case 11u:
														num167 = ((int)num2 * -1577993146) ^ -1787666156;
														continue;
													case 12u:
														current6 = enumerator2.Current;
														num167 = 947686836;
														continue;
													case 7u:
													{
														int num178;
														int num179;
														if (current6.Round > 1)
														{
															num178 = 907912487;
															num179 = num178;
														}
														else
														{
															num178 = 387909291;
															num179 = num178;
														}
														num167 = num178 ^ ((int)num2 * -2048100086);
														continue;
													}
													case 6u:
														num169 = num165;
														num167 = (int)((num2 * 1331882582) ^ 0x6EA352B3);
														continue;
													case 9u:
													{
														int num181;
														int num182;
														if (current6.Round > 1)
														{
															num181 = -23674572;
															num182 = num181;
														}
														else
														{
															num181 = -353122866;
															num182 = num181;
														}
														num167 = num181 ^ (int)(num2 * 876511761);
														continue;
													}
													case 20u:
														num170 = 0;
														num167 = 595339535;
														continue;
													case 3u:
														current6.Round--;
														num167 = (int)(num2 * 1959416133) ^ -1724992740;
														continue;
													case 1u:
													{
														current6.Round--;
														int num174;
														int num175;
														if (num166 >= 500.0)
														{
															num174 = 236976899;
															num175 = num174;
														}
														else
														{
															num174 = 637440799;
															num175 = num174;
														}
														num167 = num174 ^ ((int)num2 * -1688584558);
														continue;
													}
													case 5u:
													{
														current6.Level = (int)((double)current6.Level * (1.0 + num169 * 0.002) + 0.5);
														int num183;
														int num184;
														if (current6.Level <= 1)
														{
															num183 = -658612049;
															num184 = num183;
														}
														else
														{
															num183 = -1100196617;
															num184 = num183;
														}
														num167 = num183 ^ (int)(num2 * 432365187);
														continue;
													}
													case 14u:
														num170++;
														num167 = 233437294;
														continue;
													case 10u:
													{
														int num180;
														if (!(num169 >= 500.0))
														{
															num167 = 1044535214;
															num180 = num167;
														}
														else
														{
															num167 = 1998374700;
															num180 = num167;
														}
														continue;
													}
													case 15u:
													{
														int num176;
														int num177;
														if (Tools.ProbabilityTest(num166 * 0.002))
														{
															num176 = -1941480209;
															num177 = num176;
														}
														else
														{
															num176 = -456749073;
															num177 = num176;
														}
														num167 = num176 ^ ((int)num2 * -1538127654);
														continue;
													}
													case 18u:
														current6.Level = Math.Max(1, (int)((double)current6.Level / (1.0 + num166 * 0.002)));
														num167 = (int)(num2 * 332698292) ^ -193043208;
														continue;
													case 17u:
														current6.Round += num170;
														num167 = 1739188727;
														continue;
													case 0u:
													{
														int num172;
														int num173;
														if (Tools.ProbabilityTest(num169 / 500.0))
														{
															num172 = 795826195;
															num173 = num172;
														}
														else
														{
															num172 = 1382682040;
															num173 = num172;
														}
														num167 = num172 ^ ((int)num2 * -1561672972);
														continue;
													}
													case 19u:
														break;
													case 2u:
													{
														int num171;
														if (num170 > 2)
														{
															num167 = 191504982;
															num171 = num167;
														}
														else
														{
															num167 = 548525193;
															num171 = num167;
														}
														continue;
													}
													case 8u:
														num169 -= 500.0;
														num167 = ((int)num2 * -1711653037) ^ 0x17AEDBFE;
														continue;
													case 4u:
														goto end_IL_7d54;
													}
													goto IL_8027;
													continue;
													end_IL_7d54:
													break;
												}
												break;
											}
										}
										goto IL_808e;
										IL_7ce8:
										attackResult.Debuff.Clear();
										goto IL_808e;
										IL_7c28:
										num162 = 641373332;
										goto IL_7c2d;
										IL_808e:
										num185 = (double)(role.AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3406067330u)] - role2.AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3406067330u)]) * 0.002;
										if (num185 < 0.0)
										{
											goto IL_80d3;
										}
										goto IL_8146;
										IL_8146:
										if (num185 <= 0.4)
										{
											num186 = 51438454;
											num187 = num186;
										}
										else
										{
											num186 = 1401421389;
											num187 = num186;
										}
										goto IL_80d8;
										IL_80d3:
										num186 = 381296199;
										goto IL_80d8;
										IL_80d8:
										while (true)
										{
											switch ((num2 = (uint)(num186 ^ 0x78034022)) % 6)
											{
											case 3u:
												break;
											case 1u:
												num185 = 0.0;
												num186 = (int)(num2 * 1486673352) ^ -84466530;
												continue;
											case 5u:
												num185 = 0.4;
												num186 = (int)((num2 * 1727705045) ^ 0x2516B02D);
												continue;
											case 2u:
												list3 = new List<string>();
												num186 = 1522921228;
												continue;
											case 4u:
												goto IL_8146;
											default:
												goto IL_8167;
											}
											break;
										}
										goto IL_80d3;
										IL_8167:
										using (List<BuffInstance>.Enumerator enumerator3 = target.Buffs.GetEnumerator())
										{
											while (true)
											{
												IL_81a1:
												int num188;
												int num189;
												if (!enumerator3.MoveNext())
												{
													num188 = 749621015;
													num189 = num188;
												}
												else
												{
													num188 = 1828245506;
													num189 = num188;
												}
												while (true)
												{
													switch ((num2 = (uint)(num188 ^ 0x78034022)) % 5)
													{
													case 4u:
														num188 = 1828245506;
														continue;
													default:
														goto end_IL_817b;
													case 1u:
														break;
													case 3u:
														list3.Add(current7.Name);
														num188 = ((int)num2 * -865478044) ^ 0x7729202E;
														continue;
													case 2u:
														current7 = enumerator3.Current;
														num188 = 1773132163;
														continue;
													case 0u:
														goto end_IL_817b;
													}
													goto IL_81a1;
													continue;
													end_IL_817b:
													break;
												}
												break;
											}
										}
										using (List<Buff>.Enumerator enumerator2 = attackResult.Debuff.GetEnumerator())
										{
											while (true)
											{
												IL_82d8:
												int num190;
												int num191;
												if (!enumerator2.MoveNext())
												{
													num190 = 1874114729;
													num191 = num190;
												}
												else
												{
													num190 = 1072769878;
													num191 = num190;
												}
												while (true)
												{
													switch ((num2 = (uint)(num190 ^ 0x78034022)) % 32)
													{
													case 17u:
														num190 = 1072769878;
														continue;
													default:
														goto end_IL_8211;
													case 20u:
														current8 = enumerator2.Current;
														num190 = 1588590497;
														continue;
													case 15u:
														num192 = Tools.GetRandomInt(60, 100);
														num190 = ((int)num2 * -879561651) ^ 0x52F0F1B6;
														continue;
													case 12u:
														break;
													case 9u:
														num192 = num192 * 90 / 100;
														num190 = 1404858740;
														continue;
													case 2u:
														buffInstance.LeftRound += Tools.GetRandomInt(0, 2);
														num190 = ((int)num2 * -1993197183) ^ 0x22318112;
														continue;
													case 10u:
													{
														int num207;
														int num208;
														if (Tools.ProbabilityTest(0.5))
														{
															num207 = 228575897;
															num208 = num207;
														}
														else
														{
															num207 = 1499191020;
															num208 = num207;
														}
														num190 = num207 ^ (int)(num2 * 1602485702);
														continue;
													}
													case 29u:
														attackResult.AddAttackInfo2(target, current8.Name + global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2303469568u) + current8.Level + global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3703614712u), Color.red, skill.AttackTime);
														num190 = ((int)num2 * -638124079) ^ 0x126DACF0;
														continue;
													case 8u:
													{
														int num200;
														if (num192 <= 100)
														{
															num190 = 1772900917;
															num200 = num190;
														}
														else
														{
															num190 = 1073191057;
															num200 = num190;
														}
														continue;
													}
													case 1u:
													{
														int num194;
														int num195;
														if (!Tools.ProbabilityTest(Math.Max(0.001, role2.anti_debuffValue - num185 * ((double)num192 * 0.01))))
														{
															num194 = -1101734092;
															num195 = num194;
														}
														else
														{
															num194 = -1722964787;
															num195 = num194;
														}
														num190 = num194 ^ ((int)num2 * -1183987165);
														continue;
													}
													case 28u:
														buffInstance.Level += Tools.GetRandomInt(0, 2);
														num190 = (int)(num2 * 1506790694) ^ -1525425784;
														continue;
													case 26u:
													{
														int num203;
														int num204;
														if (current8.Name == ResourceStrings.ResStrings[531])
														{
															num203 = 1051268307;
															num204 = num203;
														}
														else
														{
															num203 = 33742145;
															num204 = num203;
														}
														num190 = num203 ^ ((int)num2 * -95943911);
														continue;
													}
													case 6u:
													{
														int num198;
														int num199;
														if (!role.BuiltInTalents[130])
														{
															num198 = 542594591;
															num199 = num198;
														}
														else
														{
															num198 = 163414467;
															num199 = num198;
														}
														num190 = num198 ^ ((int)num2 * -1440661754);
														continue;
													}
													case 5u:
														Log(string.Format(ResourceStrings.ResStrings[837], role.Name));
														num190 = (int)((num2 * 1370866634) ^ 0x31DDF33E);
														continue;
													case 27u:
														num192 /= 2;
														num190 = (int)(num2 * 405921456) ^ -879250014;
														continue;
													case 31u:
														Log(string.Format(ResourceStrings.ResStrings[841], role2.Name, buffInstance.buff.Name, buffInstance.Level));
														num190 = (int)((num2 * 2089988834) ^ 0x71C9F530);
														continue;
													case 3u:
													{
														num192 = current8.Property;
														int num209;
														int num210;
														if (num192 <= -1)
														{
															num209 = -630662017;
															num210 = num209;
														}
														else
														{
															num209 = -1225819368;
															num210 = num209;
														}
														num190 = num209 ^ (int)(num2 * 682024134);
														continue;
													}
													case 4u:
													{
														int num205;
														int num206;
														if (buffInstance.buff.Name.Equals(ResourceStrings.ResStrings[519]))
														{
															num205 = 1594099348;
															num206 = num205;
														}
														else
														{
															num205 = 75680447;
															num206 = num205;
														}
														num190 = num205 ^ ((int)num2 * -404921644);
														continue;
													}
													case 23u:
													{
														int num202;
														if (!list3.Contains(current8.Name))
														{
															num190 = 1404858740;
															num202 = num190;
														}
														else
														{
															num190 = 2041011864;
															num202 = num190;
														}
														continue;
													}
													case 18u:
													{
														int num201;
														if (!target.AddBuff2(buffInstance))
														{
															num190 = 325437422;
															num201 = num190;
														}
														else
														{
															num190 = 1451475807;
															num201 = num190;
														}
														continue;
													}
													case 13u:
													{
														int num197;
														if (!role.BuiltInTalents[132])
														{
															num190 = 121177616;
															num197 = num190;
														}
														else
														{
															num190 = 693972936;
															num197 = num190;
														}
														continue;
													}
													case 30u:
														Log(string.Format(ResourceStrings.ResStrings[839], role.Name));
														num190 = ((int)num2 * -639621710) ^ 0x4E06846;
														continue;
													case 22u:
													{
														int num196;
														if (num192 != 100)
														{
															num190 = 1291670307;
															num196 = num190;
														}
														else
														{
															num190 = 880589847;
															num196 = num190;
														}
														continue;
													}
													case 0u:
														buffInstance.Level += 5;
														buffInstance.LeftRound += 4;
														num190 = (int)(num2 * 1837132661) ^ -144301297;
														continue;
													case 7u:
														attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[293], 0.8f, skill.AttackTime);
														num190 = ((int)num2 * -1443038190) ^ 0x54B55280;
														continue;
													case 24u:
														attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[840], 0.7f, skill.AttackTime);
														num190 = (int)((num2 * 612396525) ^ 0x4DF8251A);
														continue;
													case 14u:
														attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[838], 0.7f, skill.AttackTime);
														buffInstance.Level += 3;
														buffInstance.LeftRound += 2;
														num190 = (int)(num2 * 1976098242) ^ -1509790425;
														continue;
													case 21u:
														buffInstance = new BuffInstance
														{
															buff = current8,
															Owner = target,
															Level = current8.Level,
															LeftRound = current8.Round
														};
														num190 = 1266432934;
														continue;
													case 16u:
														num190 = (int)(num2 * 2122868512) ^ -1500486796;
														continue;
													case 25u:
													{
														int num193;
														if (role.BuiltInTalents[131])
														{
															num190 = 1633767484;
															num193 = num190;
														}
														else
														{
															num190 = 726408175;
															num193 = num190;
														}
														continue;
													}
													case 19u:
														num192 = 100;
														num190 = (int)(num2 * 527397621) ^ -505656454;
														continue;
													case 11u:
														goto end_IL_8211;
													}
													goto IL_82d8;
													continue;
													end_IL_8211:
													break;
												}
												break;
											}
										}
										goto IL_87f5;
										IL_87f5:
										if (!flag4)
										{
											goto IL_87fb;
										}
										goto IL_8933;
										IL_8933:
										if (!skill.HitSelf)
										{
											num113 = 185746538;
											num211 = num113;
										}
										else
										{
											num113 = 1470245272;
											num211 = num113;
										}
										goto IL_8800;
									}
									break;
								}
								goto IL_79e1;
								IL_79d9:
								if (skill.HitSelf)
								{
									goto IL_79e1;
								}
								goto IL_7a3a;
								IL_79e1:
								num108 = 2072159918;
								goto IL_79e6;
							}
							break;
							IL_7746:
							if (target.Mp > 0)
							{
								num91 = (int)(num2 * 797166873) ^ -1743992429;
								continue;
							}
							goto IL_7137;
							IL_65aa:
							int num257;
							if (num102 <= target.Mp)
							{
								num91 = 1872863726;
								num257 = num91;
							}
							else
							{
								num91 = 461334814;
								num257 = num91;
							}
							continue;
							IL_76d8:
							int num258;
							if (attackResult.Hp < 0)
							{
								num91 = 956122740;
								num258 = num91;
							}
							else
							{
								num91 = 1684409212;
								num258 = num91;
							}
							continue;
							IL_61df:
							if ((Object)(object)source != (Object)(object)target)
							{
								num91 = ((int)num2 * -1015295024) ^ 0x24EF74A9;
								continue;
							}
							goto IL_6f9f;
							IL_6a0e:
							if ((Object)(object)source != (Object)(object)target)
							{
								num91 = (int)((num2 * 130685993) ^ 0x43D6CF5);
								continue;
							}
							goto IL_7137;
							IL_7602:
							int num259;
							if (role.BuiltInTalents[128])
							{
								num91 = 1848190986;
								num259 = num91;
							}
							else
							{
								num91 = 1953548748;
								num259 = num91;
							}
							continue;
							IL_6bd6:
							int num260;
							int num261;
							if (((uint)num260 & (flag ? 1u : 0u)) != 0)
							{
								num91 = 2093126081;
								num261 = num91;
							}
							else
							{
								num91 = 978108559;
								num261 = num91;
							}
							continue;
							IL_7137:
							int num262 = 0;
							goto IL_7138;
							IL_74e2:
							if (target.Mp > 0)
							{
								num91 = (int)((num2 * 534812533) ^ 0x79CF2DAE);
								continue;
							}
							goto IL_690e;
							IL_7138:
							int num263;
							if (((uint)num262 & (flag ? 1u : 0u)) == 0)
							{
								num91 = 440644683;
								num263 = num91;
							}
							else
							{
								num91 = 2086395637;
								num263 = num91;
							}
							continue;
							IL_74b4:
							int num264;
							if (name == ResourceStrings.ResStrings[1052])
							{
								num264 = 1;
								goto IL_6cb1;
							}
							num91 = ((int)num2 * -648646267) ^ 0x20AC3EA0;
							continue;
							IL_6570:
							int num265;
							if (num102 > (source.MaxMp - source.Mp) * 2)
							{
								num91 = 1534036249;
								num265 = num91;
							}
							else
							{
								num91 = 2001498538;
								num265 = num91;
							}
							continue;
							IL_6142:
							int num266;
							if (!(num223 > 0f && flag4))
							{
								num91 = 431240800;
								num266 = num91;
							}
							else
							{
								num91 = 385513533;
								num266 = num91;
							}
							continue;
							IL_7254:
							int num267;
							if (num225 <= (source.MaxMp - source.Mp) * 2)
							{
								num91 = 1993551756;
								num267 = num91;
							}
							else
							{
								num91 = 654134086;
								num267 = num91;
							}
							continue;
							IL_69ca:
							attackResult = LuaManager.Call<AttackResult>(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(861808263u), new object[5] { source, target, skill, bf, attackResult });
							int num268;
							if (flag5)
							{
								num91 = 992343338;
								num268 = num91;
							}
							else
							{
								num91 = 729415103;
								num268 = num91;
							}
							continue;
							IL_6f9f:
							int num269 = 0;
							goto IL_6fa0;
							IL_7214:
							if (target.Mp > 0)
							{
								num91 = (int)((num2 * 169267173) ^ 0xA30DFC);
								continue;
							}
							goto IL_6f9f;
							IL_6523:
							int num270;
							if (role.BuiltInTalents[120] && flag4)
							{
								num91 = 1127049479;
								num270 = num91;
							}
							else
							{
								num91 = 131358435;
								num270 = num91;
							}
							continue;
							IL_7150:
							int num271;
							if (!(name == ResourceStrings.ResStrings[709]))
							{
								num91 = 394047091;
								num271 = num91;
							}
							else
							{
								num91 = 917989841;
								num271 = num91;
							}
							continue;
							IL_6905:
							int num272 = (((Object)(object)source != (Object)(object)target) ? 1 : 0);
							goto IL_690f;
							IL_6855:
							if (role.BuiltInTalents[118])
							{
								num91 = 1427171341;
								continue;
							}
							goto IL_690e;
							IL_7127:
							num262 = (Tools.ProbabilityTest(0.5) ? 1 : 0);
							goto IL_7138;
							IL_7082:
							int num273;
							if (num222 > (source.MaxMp - source.Mp) * 2)
							{
								num91 = 251113013;
								num273 = num91;
							}
							else
							{
								num91 = 435393028;
								num273 = num91;
							}
							continue;
							IL_62ea:
							if (role.BuiltInTalents[117])
							{
								num91 = 1761451083;
								continue;
							}
							goto IL_6f9f;
							IL_690e:
							num272 = 0;
							goto IL_690f;
							IL_6fea:
							if (target.Mp > 0)
							{
								num91 = ((int)num2 * -1459151885) ^ 0x187B26ED;
								continue;
							}
							goto IL_6b31;
							IL_690f:
							int num274;
							if (((uint)num272 & (flag ? 1u : 0u)) != 0)
							{
								num91 = 1964181491;
								num274 = num91;
							}
							else
							{
								num91 = 136296258;
								num274 = num91;
							}
							continue;
							IL_6f8f:
							num269 = (Tools.ProbabilityTest(0.5) ? 1 : 0);
							goto IL_6fa0;
							IL_6ee3:
							int num275;
							if (attackResult.Hp > 0)
							{
								num91 = 974206322;
								num275 = num91;
							}
							else
							{
								num91 = 2099923000;
								num275 = num91;
							}
							continue;
							IL_6fa0:
							int num276;
							if (((uint)num269 & (flag ? 1u : 0u)) == 0)
							{
								num91 = 1223277857;
								num276 = num91;
							}
							else
							{
								num91 = 1499945043;
								num276 = num91;
							}
							continue;
							IL_637f:
							int num277;
							if (attackResult.costBall != 0)
							{
								num91 = 1861691266;
								num277 = num91;
							}
							else
							{
								num91 = 322834262;
								num277 = num91;
							}
							continue;
							IL_6d3f:
							if (role.BuiltInTalents[98])
							{
								num91 = 636983298;
								continue;
							}
							goto IL_7137;
							IL_66c3:
							int num278;
							if (!role.BuiltInTalents[127])
							{
								num91 = 1388332062;
								num278 = num91;
							}
							else
							{
								num91 = 1882295877;
								num278 = num91;
							}
							continue;
							IL_6ccf:
							int num279;
							if (num105 >= 0)
							{
								num91 = 569784247;
								num279 = num91;
							}
							else
							{
								num91 = 1464819804;
								num279 = num91;
							}
							continue;
							IL_627a:
							int num280;
							if (attackResult.Mp != 0)
							{
								num91 = 1771595141;
								num280 = num91;
							}
							else
							{
								num91 = 1246033593;
								num280 = num91;
							}
							continue;
							IL_60f4:
							int num281;
							if (num223 <= 0f)
							{
								num91 = 1054089220;
								num281 = num91;
							}
							else
							{
								num91 = 136189314;
								num281 = num91;
							}
							continue;
							IL_6cad:
							num264 = 0;
							goto IL_6cb1;
							IL_6cb1:
							flag5 = (byte)num264 != 0;
							if (role.BuiltInTalents[116])
							{
								num91 = 229400052;
								continue;
							}
							goto IL_6b31;
							IL_6648:
							int num282;
							if (num225 > target.Mp)
							{
								num91 = 1827002402;
								num282 = num91;
							}
							else
							{
								num91 = 1225139683;
								num282 = num91;
							}
							continue;
							IL_6b31:
							int num283 = 0;
							goto IL_6b32;
							IL_6bb4:
							num260 = ((role.EquippedInternalSkill.Name == ResourceStrings.ResStrings[700]) ? 1 : 0);
							goto IL_6bd6;
							IL_6b28:
							num283 = (((Object)(object)source != (Object)(object)target) ? 1 : 0);
							goto IL_6b32;
							IL_6b32:
							int num284;
							if (((uint)num283 & (flag ? 1u : 0u)) == 0)
							{
								num91 = 1105274700;
								num284 = num91;
							}
							else
							{
								num91 = 1019217847;
								num284 = num91;
							}
							continue;
							IL_6323:
							if (role.BuiltInTalents[119])
							{
								num91 = 966551788;
								continue;
							}
							num260 = 0;
							goto IL_6bd6;
							IL_5f88:
							int num285;
							if (num222 <= target.Mp)
							{
								num91 = 1545188837;
								num285 = num91;
							}
							else
							{
								num91 = 652826534;
								num285 = num91;
							}
							continue;
							IL_6a89:
							source.Mp += num222;
							target.Mp -= num222;
							int num286;
							if (num222 < 0)
							{
								num91 = 136296258;
								num286 = num91;
							}
							else
							{
								num91 = 902108129;
								num286 = num91;
							}
						}
						goto IL_5c9d;
						IL_5c9d:
						num91 = 833531215;
						goto IL_5ca2;
						IL_5705:
						if (!skill.HitSelf)
						{
							while (true)
							{
								int num344 = 359591177;
								while (true)
								{
									switch ((num2 = (uint)(num344 ^ 0x78034022)) % 3)
									{
									case 0u:
										break;
									case 2u:
										list4 = new List<BattleSprite>();
										num344 = (int)(num2 * 461627169) ^ -1340557809;
										continue;
									default:
										goto end_IL_5710;
									}
									break;
								}
								continue;
								end_IL_5710:
								break;
							}
							IEnumerator<BattleSprite> enumerator = bf.Sprites.GetEnumerator();
							try
							{
								while (true)
								{
									IL_5811:
									int num345;
									int num346;
									if (!enumerator.MoveNext())
									{
										num345 = 2078673804;
										num346 = num345;
									}
									else
									{
										num345 = 15224624;
										num346 = num345;
									}
									while (true)
									{
										switch ((num2 = (uint)(num345 ^ 0x78034022)) % 10)
										{
										case 7u:
											num345 = 15224624;
											continue;
										default:
											goto end_IL_5761;
										case 9u:
											list4.Add(current9);
											num345 = (int)((num2 * 2000362470) ^ 0x370942F5);
											continue;
										case 4u:
										{
											int num349;
											int num350;
											if (!Tools.ProbabilityTest(0.5))
											{
												num349 = -117657479;
												num350 = num349;
											}
											else
											{
												num349 = -1724158439;
												num350 = num349;
											}
											num345 = num349 ^ ((int)num2 * -1679214831);
											continue;
										}
										case 1u:
										{
											int num355;
											int num356;
											if (current9.Team != target.Team)
											{
												num355 = -914179620;
												num356 = num355;
											}
											else
											{
												num355 = -152329770;
												num356 = num355;
											}
											num345 = num355 ^ (int)(num2 * 2056715295);
											continue;
										}
										case 3u:
											break;
										case 8u:
											current9 = enumerator.Current;
											num345 = 222005442;
											continue;
										case 5u:
										{
											int num351;
											int num352;
											if (!((Object)(object)current9 != (Object)(object)target))
											{
												num351 = 1943542222;
												num352 = num351;
											}
											else
											{
												num351 = 745663463;
												num352 = num351;
											}
											num345 = num351 ^ (int)(num2 * 1932213703);
											continue;
										}
										case 0u:
										{
											int num353;
											int num354;
											if (Math.Abs(current9.X - target.X) + Math.Abs(current9.Y - target.Y) <= 5)
											{
												num353 = -1673297032;
												num354 = num353;
											}
											else
											{
												num353 = -1562990525;
												num354 = num353;
											}
											num345 = num353 ^ (int)(num2 * 132392746);
											continue;
										}
										case 2u:
										{
											int num347;
											int num348;
											if (current9.Role.BuiltInTalents[29])
											{
												num347 = 1477433267;
												num348 = num347;
											}
											else
											{
												num347 = 1350340499;
												num348 = num347;
											}
											num345 = num347 ^ (int)(num2 * 228277837);
											continue;
										}
										case 6u:
											goto end_IL_5761;
										}
										goto IL_5811;
										continue;
										end_IL_5761:
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
										IL_58e7:
										int num357 = 1009361346;
										while (true)
										{
											switch ((num2 = (uint)(num357 ^ 0x78034022)) % 3)
											{
											case 0u:
												break;
											default:
												goto end_IL_58ec;
											case 1u:
												goto IL_590a;
											case 2u:
												goto end_IL_58ec;
											}
											goto IL_58e7;
											IL_590a:
											enumerator.Dispose();
											num357 = ((int)num2 * -1797765456) ^ -817750313;
											continue;
											end_IL_58ec:
											break;
										}
										break;
									}
								}
							}
							if (list4.Count > 0)
							{
								while (true)
								{
									int num358 = 748340634;
									while (true)
									{
										switch ((num2 = (uint)(num358 ^ 0x78034022)) % 3)
										{
										case 0u:
											break;
										case 2u:
											num359 = (int)((double)attackResult.Hp / (double)(list4.Count + 1));
											num358 = ((int)num2 * -1949079026) ^ 0x5BD40C7D;
											continue;
										default:
											goto end_IL_592f;
										}
										break;
									}
									continue;
									end_IL_592f:
									break;
								}
								attackResult.Hp = num359;
								using List<BattleSprite>.Enumerator enumerator4 = list4.GetEnumerator();
								while (true)
								{
									IL_5a84:
									int num360;
									int num361;
									if (enumerator4.MoveNext())
									{
										num360 = 924967709;
										num361 = num360;
									}
									else
									{
										num360 = 626329617;
										num361 = num360;
									}
									while (true)
									{
										switch ((num2 = (uint)(num360 ^ 0x78034022)) % 7)
										{
										case 5u:
											num360 = 924967709;
											continue;
										default:
											goto end_IL_5994;
										case 0u:
											attackResult.AddAttackInfo2(current10, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1374331745u) + num359, Color.white, skill.AttackTime);
											attackResult.AddCastInfo2(current10, ResourceStrings.ResStrings[190], 1f, skill.AttackTime);
											num360 = ((int)num2 * -488393936) ^ -1215679848;
											continue;
										case 4u:
											current10.Hp -= num359;
											num360 = (int)((num2 * 623590533) ^ 0x417648B0);
											continue;
										case 6u:
											Log(string.Format(ResourceStrings.ResStrings[809], current10.Role.Name));
											num360 = (int)((num2 * 1255140999) ^ 0x18DCB0AB);
											continue;
										case 3u:
											break;
										case 1u:
											current10 = enumerator4.Current;
											num360 = 26998186;
											continue;
										case 2u:
											goto end_IL_5994;
										}
										goto IL_5a84;
										continue;
										end_IL_5994:
										break;
									}
									break;
								}
							}
						}
						if (role2.BuiltInTalents[115])
						{
							while (true)
							{
								int num362 = 385358127;
								while (true)
								{
									switch ((num2 = (uint)(num362 ^ 0x78034022)) % 4)
									{
									case 3u:
										break;
									case 1u:
										goto IL_5afd;
									case 2u:
										list2 = new List<BattleSprite>();
										num362 = (int)(num2 * 1473781818) ^ -100691214;
										continue;
									default:
										goto end_IL_5ad6;
									}
									break;
									IL_5afd:
									if (Tools.ProbabilityTest(0.5))
									{
										num362 = ((int)num2 * -1775929562) ^ -530048050;
										continue;
									}
									goto IL_6fd3;
								}
								continue;
								end_IL_5ad6:
								break;
							}
							IEnumerator<BattleSprite> enumerator = bf.Sprites.GetEnumerator();
							try
							{
								while (true)
								{
									IL_5c0b:
									int num363;
									int num364;
									if (!enumerator.MoveNext())
									{
										num363 = 1776206263;
										num364 = num363;
									}
									else
									{
										num363 = 1218017885;
										num364 = num363;
									}
									while (true)
									{
										switch ((num2 = (uint)(num363 ^ 0x78034022)) % 7)
										{
										case 3u:
											num363 = 1218017885;
											continue;
										default:
											goto end_IL_5b4e;
										case 5u:
										{
											int num367;
											int num368;
											if (Math.Abs(current11.X - target.X) + Math.Abs(current11.Y - target.Y) > 5)
											{
												num367 = -602607519;
												num368 = num367;
											}
											else
											{
												num367 = -238203546;
												num368 = num367;
											}
											num363 = num367 ^ ((int)num2 * -1121052556);
											continue;
										}
										case 0u:
											list2.Add(current11);
											num363 = ((int)num2 * -520493084) ^ 0x2D957BA5;
											continue;
										case 1u:
										{
											current11 = enumerator.Current;
											int num369;
											if (current11.Team != target.Team)
											{
												num363 = 1389820325;
												num369 = num363;
											}
											else
											{
												num363 = 711986781;
												num369 = num363;
											}
											continue;
										}
										case 6u:
											break;
										case 2u:
										{
											int num365;
											int num366;
											if ((Object)(object)current11 != (Object)(object)target)
											{
												num365 = -454700864;
												num366 = num365;
											}
											else
											{
												num365 = -118504414;
												num366 = num365;
											}
											num363 = num365 ^ ((int)num2 * -1635508999);
											continue;
										}
										case 4u:
											goto end_IL_5b4e;
										}
										goto IL_5c0b;
										continue;
										end_IL_5b4e:
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
										IL_5c55:
										int num370 = 1804250526;
										while (true)
										{
											switch ((num2 = (uint)(num370 ^ 0x78034022)) % 3)
											{
											case 0u:
												break;
											default:
												goto end_IL_5c5a;
											case 2u:
												goto IL_5c78;
											case 1u:
												goto end_IL_5c5a;
											}
											goto IL_5c55;
											IL_5c78:
											enumerator.Dispose();
											num370 = (int)(num2 * 233261699) ^ -1062610833;
											continue;
											end_IL_5c5a:
											break;
										}
										break;
									}
								}
							}
							if (list2.Count > 0)
							{
								goto IL_5c9d;
							}
						}
						goto IL_6fd3;
						IL_5332:
						num445 = num33;
						num11 = 365307768;
						continue;
					}
					break;
					IL_528d:
					int num521;
					if (!list[5])
					{
						num11 = 2128791624;
						num521 = num11;
					}
					else
					{
						num11 = 1077469114;
						num521 = num11;
					}
					continue;
					IL_34de:
					int num522;
					if (!role2.BuiltInTalents[38])
					{
						num11 = 717732653;
						num522 = num11;
					}
					else
					{
						num11 = 467451708;
						num522 = num11;
					}
					continue;
					IL_2cf6:
					int num523;
					if (Tools.ProbabilityTest(0.5))
					{
						num11 = 818666971;
						num523 = num11;
					}
					else
					{
						num11 = 375850909;
						num523 = num11;
					}
					continue;
					IL_5227:
					int num524;
					if (num319 >= 0.001)
					{
						num11 = 2067612652;
						num524 = num11;
					}
					else
					{
						num11 = 434337403;
						num524 = num11;
					}
					continue;
					IL_402a:
					int num525;
					if (role2.BuiltInTalents[90])
					{
						num11 = 1127118804;
						num525 = num11;
					}
					else
					{
						num11 = 2059425134;
						num525 = num11;
					}
					continue;
					IL_1e78:
					int num526;
					if (list[9])
					{
						num11 = 191251928;
						num526 = num11;
					}
					else
					{
						num11 = 1410720326;
						num526 = num11;
					}
					continue;
					IL_5209:
					int num527;
					if (attackResult.Hp > 0)
					{
						num11 = 1782602823;
						num527 = num11;
					}
					else
					{
						num11 = 459261903;
						num527 = num11;
					}
					continue;
					IL_3395:
					int num528;
					if (role.BuiltInTalents[107])
					{
						num11 = 2019238765;
						num528 = num11;
					}
					else
					{
						num11 = 243707761;
						num528 = num11;
					}
					continue;
					IL_400d:
					int num529;
					if (Tools.ProbabilityTest(num445))
					{
						num11 = 1421902426;
						num529 = num11;
					}
					else
					{
						num11 = 1503734173;
						num529 = num11;
					}
					continue;
					IL_517c:
					int num530;
					if (role.BuiltInTalents[89])
					{
						num11 = 1921530746;
						num530 = num11;
					}
					else
					{
						num11 = 186301464;
						num530 = num11;
					}
					continue;
					IL_223d:
					if (role2.BuiltInTalents[98])
					{
						num11 = 2006117244;
						continue;
					}
					int num531 = 0;
					goto IL_42df;
					IL_2bd9:
					int num532;
					if (list[10])
					{
						num11 = 1699711596;
						num532 = num11;
					}
					else
					{
						num11 = 807931521;
						num532 = num11;
					}
					continue;
					IL_510f:
					int num533;
					if ((double)source.Mp / (double)source.MaxMp > (double)target.Mp / (double)target.MaxMp)
					{
						num11 = 1554198647;
						num533 = num11;
					}
					else
					{
						num11 = 1766586311;
						num533 = num11;
					}
					continue;
					IL_3f45:
					int num534;
					if (role.BuiltInTalents[108])
					{
						num11 = 273289169;
						num534 = num11;
					}
					else
					{
						num11 = 1310893332;
						num534 = num11;
					}
					continue;
					IL_3362:
					int num535;
					if (num51 > 0)
					{
						num11 = 1697029054;
						num535 = num11;
					}
					else
					{
						num11 = 856420300;
						num535 = num11;
					}
					continue;
					IL_5051:
					int num536;
					if (!list[11])
					{
						num11 = 405541121;
						num536 = num11;
					}
					else
					{
						num11 = 1574268929;
						num536 = num11;
					}
					continue;
					IL_1ac2:
					int num537;
					if (num314 != 0)
					{
						num11 = 2067395590;
						num537 = num11;
					}
					else
					{
						num11 = 1962078995;
						num537 = num11;
					}
					continue;
					IL_3f2e:
					int num538;
					if (!flag4)
					{
						num11 = 1375059084;
						num538 = num11;
					}
					else
					{
						num11 = 1353949407;
						num538 = num11;
					}
					continue;
					IL_4fad:
					int num539;
					if (list[4])
					{
						num11 = 647374895;
						num539 = num11;
					}
					else
					{
						num11 = 1410065716;
						num539 = num11;
					}
					continue;
					IL_18a9:
					int num540;
					if (!role2.BuiltInTalents[89])
					{
						num11 = 487969243;
						num540 = num11;
					}
					else
					{
						num11 = 854283848;
						num540 = num11;
					}
					continue;
					IL_333f:
					int num541;
					if (role.BuiltInTalents[105])
					{
						num11 = 1663393083;
						num541 = num11;
					}
					else
					{
						num11 = 1635272956;
						num541 = num11;
					}
					continue;
					IL_4e94:
					int num542;
					if (!list[3])
					{
						num11 = 35677985;
						num542 = num11;
					}
					else
					{
						num11 = 1833812587;
						num542 = num11;
					}
					continue;
					IL_3edf:
					if (num291 >= 0.1)
					{
						num11 = 1929333290;
						continue;
					}
					int num543 = 0;
					goto IL_4237;
					IL_2a30:
					int num544;
					if (flag4)
					{
						num11 = 1354643717;
						num544 = num11;
					}
					else
					{
						num11 = 1649439388;
						num544 = num11;
					}
					continue;
					IL_4b9e:
					int num545;
					if (role.BuiltInTalents[114])
					{
						num11 = 1690300178;
						num545 = num11;
					}
					else
					{
						num11 = 367040451;
						num545 = num11;
					}
					continue;
					IL_42df:
					int num546;
					if (((uint)num531 & (flag ? 1u : 0u)) != 0)
					{
						num11 = 1916779372;
						num546 = num11;
					}
					else
					{
						num11 = 856420300;
						num546 = num11;
					}
					continue;
					IL_4237:
					int num547;
					if (((uint)num543 & (flag ? 1u : 0u)) == 0)
					{
						num11 = 605966621;
						num547 = num11;
					}
					else
					{
						num11 = 684602986;
						num547 = num11;
					}
					continue;
					IL_49d5:
					int num548;
					if (list[8])
					{
						num11 = 1000171519;
						num548 = num11;
					}
					else
					{
						num11 = 896762289;
						num548 = num11;
					}
					continue;
					IL_32d8:
					int num549;
					if (num83 != 0)
					{
						num11 = 1593608478;
						num549 = num11;
					}
					else
					{
						num11 = 121222677;
						num549 = num11;
					}
					continue;
					IL_1d44:
					int num550;
					if (!flag4)
					{
						num11 = 1750138220;
						num550 = num11;
					}
					else
					{
						num11 = 2129239064;
						num550 = num11;
					}
					continue;
					IL_4982:
					int num551;
					if (!list[7])
					{
						num11 = 1415025122;
						num551 = num11;
					}
					else
					{
						num11 = 1701589054;
						num551 = num11;
					}
					continue;
					IL_3d1c:
					int num552;
					if (role2.BuiltInTalents[109])
					{
						num11 = 1550368525;
						num552 = num11;
					}
					else
					{
						num11 = 1104081126;
						num552 = num11;
					}
					continue;
					IL_2997:
					int num553;
					if (!role.BuiltInTalents[104])
					{
						num11 = 2097795638;
						num553 = num11;
					}
					else
					{
						num11 = 473041204;
						num553 = num11;
					}
					continue;
					IL_4920:
					int num554;
					if (role.BuiltInTalents[103])
					{
						num11 = 750433836;
						num554 = num11;
					}
					else
					{
						num11 = 316238040;
						num554 = num11;
					}
					continue;
					IL_31f9:
					int num555;
					if (!(role.BuiltInTalents[112] && flag))
					{
						num11 = 366853406;
						num555 = num11;
					}
					else
					{
						num11 = 292667232;
						num555 = num11;
					}
					continue;
					IL_3b29:
					int num556;
					if (!role2.BuiltInTalents[92])
					{
						num11 = 1217668196;
						num556 = num11;
					}
					else
					{
						num11 = 1066986836;
						num556 = num11;
					}
					continue;
					IL_486d:
					int num557;
					if (!role.BuiltInTalents[106])
					{
						num11 = 1046000090;
						num557 = num11;
					}
					else
					{
						num11 = 923745202;
						num557 = num11;
					}
					continue;
					IL_1769:
					int num558;
					if (num71 >= 15)
					{
						num11 = 1546415727;
						num558 = num11;
					}
					else
					{
						num11 = 688005958;
						num558 = num11;
					}
					continue;
					IL_21e2:
					text = string.Empty;
					flag2 = false;
					int num559;
					if (num68 == 1)
					{
						num11 = 1915297363;
						num559 = num11;
					}
					else
					{
						num11 = 925468744;
						num559 = num11;
					}
					continue;
					IL_471b:
					int num560;
					if (role2.BuiltInTalents[36])
					{
						num11 = 848668292;
						num560 = num11;
					}
					else
					{
						num11 = 1865350;
						num560 = num11;
					}
					continue;
					IL_3937:
					int num561;
					if (!role2.BuiltInTalents[96])
					{
						num11 = 532508730;
						num561 = num11;
					}
					else
					{
						num11 = 1999968727;
						num561 = num11;
					}
					continue;
					IL_30ad:
					flag3 = false;
					int num562;
					if (num68 == 1)
					{
						num11 = 1822943207;
						num562 = num11;
					}
					else
					{
						num11 = 677739557;
						num562 = num11;
					}
					continue;
					IL_46cd:
					int num563;
					if (num314 > 0)
					{
						num11 = 230374502;
						num563 = num11;
					}
					else
					{
						num11 = 399930264;
						num563 = num11;
					}
					continue;
					IL_25ba:
					int num564;
					if (role.BuiltInTalents[140])
					{
						num11 = 2087021853;
						num564 = num11;
					}
					else
					{
						num11 = 2064289262;
						num564 = num11;
					}
					continue;
					IL_380d:
					int num565;
					if (!Tools.ProbabilityTest(0.12))
					{
						num11 = 1375059084;
						num565 = num11;
					}
					else
					{
						num11 = 772710888;
						num565 = num11;
					}
					continue;
					IL_4599:
					int num566;
					if (!flag2)
					{
						num11 = 1689410031;
						num566 = num11;
					}
					else
					{
						num11 = 605966621;
						num566 = num11;
					}
					continue;
					IL_1994:
					int num567;
					if (num83 >= 0)
					{
						num11 = 826497041;
						num567 = num11;
					}
					else
					{
						num11 = 1616570184;
						num567 = num11;
					}
					continue;
					IL_2ffb:
					int num568;
					if (Tools.ProbabilityTest(0.5))
					{
						num11 = 625273300;
						num568 = num11;
					}
					else
					{
						num11 = 1670085901;
						num568 = num11;
					}
					continue;
					IL_4546:
					int num569;
					if (list[2])
					{
						num11 = 1716025541;
						num569 = num11;
					}
					else
					{
						num11 = 1009497886;
						num569 = num11;
					}
					continue;
					IL_3706:
					int num570;
					if (!Tools.ProbabilityTest(0.07))
					{
						num11 = 1217668196;
						num570 = num11;
					}
					else
					{
						num11 = 1248783977;
						num570 = num11;
					}
					continue;
					IL_1c2c:
					int num571;
					if (!role.BuiltInTalents[95])
					{
						num11 = 2059869600;
						num571 = num11;
					}
					else
					{
						num11 = 1759590263;
						num571 = num11;
					}
					continue;
					IL_43d5:
					int num572;
					if (role.BuiltInTalents[110])
					{
						num11 = 1820826749;
						num572 = num11;
					}
					else
					{
						num11 = 560652478;
						num572 = num11;
					}
					continue;
					IL_259b:
					int num573;
					if (list[13])
					{
						num11 = 1950743492;
						num573 = num11;
					}
					else
					{
						num11 = 311611721;
						num573 = num11;
					}
					continue;
					IL_364f:
					int num574;
					if (!list[6])
					{
						num11 = 1512138325;
						num574 = num11;
					}
					else
					{
						num11 = 937638277;
						num574 = num11;
					}
					continue;
					IL_432c:
					int num575;
					if (num314 >= 0)
					{
						num11 = 820670129;
						num575 = num11;
					}
					else
					{
						num11 = 914177951;
						num575 = num11;
					}
					continue;
					IL_2f29:
					int num576;
					if (!list[14])
					{
						num11 = 311611721;
						num576 = num11;
					}
					else
					{
						num11 = 772499910;
						num576 = num11;
					}
					continue;
					IL_2162:
					int num577;
					if (flag4)
					{
						num11 = 865104336;
						num577 = num11;
					}
					else
					{
						num11 = 1670085901;
						num577 = num11;
					}
					continue;
					IL_42ce:
					num531 = (Tools.ProbabilityTest(0.3) ? 1 : 0);
					goto IL_42df;
					IL_42ab:
					int num578;
					if (role.BuiltInTalents[93])
					{
						num11 = 1304041465;
						num578 = num11;
					}
					else
					{
						num11 = 858067330;
						num578 = num11;
					}
					continue;
					IL_357d:
					int num579;
					if (!flag2)
					{
						num11 = 1915297363;
						num579 = num11;
					}
					else
					{
						num11 = 328478842;
						num579 = num11;
					}
					continue;
					IL_15d9:
					int num580;
					if (target.Hp <= target.MaxHp)
					{
						num11 = 964353513;
						num580 = num11;
					}
					else
					{
						num11 = 694889643;
						num580 = num11;
					}
					continue;
					IL_422d:
					num543 = (Tools.ProbabilityTest(num291) ? 1 : 0);
					goto IL_4237;
					IL_41c5:
					int num581;
					if (list[1])
					{
						num11 = 498584875;
						num581 = num11;
					}
					else
					{
						num11 = 1873139786;
						num581 = num11;
					}
					continue;
					IL_2e6a:
					int num582;
					if (role.BuiltInTalents[94])
					{
						num11 = 1607943954;
						num582 = num11;
					}
					else
					{
						num11 = 517592941;
						num582 = num11;
					}
					continue;
					IL_3501:
					int num583;
					if (!role.BuiltInTalents[139])
					{
						num11 = 309636931;
						num583 = num11;
					}
					else
					{
						num11 = 1226446568;
						num583 = num11;
					}
					continue;
					IL_4142:
					int num584;
					if (!list[12])
					{
						num11 = 1613873745;
						num584 = num11;
					}
					else
					{
						num11 = 1804421216;
						num584 = num11;
					}
					continue;
					IL_240c:
					num319 = 0.0;
					int num585;
					if (role2.BuiltInTalents[113])
					{
						num11 = 1047211909;
						num585 = num11;
					}
					else
					{
						num11 = 607875215;
						num585 = num11;
					}
					continue;
					IL_17a0:
					int num586;
					if (!flag2)
					{
						num11 = 2109542269;
						num586 = num11;
					}
					else
					{
						num11 = 1468587090;
						num586 = num11;
					}
					continue;
					IL_40cd:
					attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[752], 0.5f, skill.AttackTime);
					int num587;
					if (!_200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(role.EquippedInternalSkill.Name, ResourceStrings.ResStrings[700]))
					{
						num11 = 957163817;
						num587 = num11;
					}
					else
					{
						num11 = 529389512;
						num587 = num11;
					}
				}
				goto IL_0e4c;
				IL_00b1:
				flag = (byte)num588 != 0;
				num68 = CommonSettings.MOD_KEY();
				num = 772298840;
				continue;
				IL_2b0f:
				if (!role.BuiltInTalents[88])
				{
					num11 = 375850909;
					num589 = num11;
				}
				else
				{
					num11 = 1611425017;
					num589 = num11;
				}
				goto IL_0e51;
				IL_0e4c:
				num11 = 24891270;
				goto IL_0e51;
				IL_0465:
				num590 = 1036945235;
				goto IL_046a;
				IL_05f4:
				if (!(role.BuiltInTalents[99] && flag4))
				{
					num590 = 1205810384;
					num591 = num590;
				}
				else
				{
					num590 = 302272771;
					num591 = num590;
				}
				goto IL_046a;
				IL_046a:
				while (true)
				{
					switch ((num2 = (uint)(num590 ^ 0x78034022)) % 20)
					{
					case 19u:
						break;
					case 1u:
						attackResult.AddCastInfo2(target, ResourceStrings.ResStrings[299], 0.99f, skill.AttackTime);
						num590 = (int)(num2 * 1297931203) ^ -1556758330;
						continue;
					case 8u:
						num590 = ((int)num2 * -1257387294) ^ 0x41A19220;
						continue;
					case 6u:
						goto IL_0518;
					case 10u:
						goto IL_053d;
					case 7u:
					{
						num594 = Tools.GetRandomInt((int)((double)target.MaxHp * 0.02), 10);
						int num600;
						int num601;
						if (target.MaxHp <= num594)
						{
							num600 = -2077130213;
							num601 = num600;
						}
						else
						{
							num600 = -586309871;
							num601 = num600;
						}
						num590 = num600 ^ ((int)num2 * -63281301);
						continue;
					}
					case 12u:
						Log(_202B_202B_206C_202D_202C_206A_202D_206C_200B_200B_206D_202D_200F_202E_200D_206B_202B_202B_206E_206F_202E_200F_202E_200D_200F_206D_200D_206D_200B_206A_206C_202D_202C_200E_206E_200F_200D_202B_200C_200E_202E(ResourceStrings.ResStrings[790], (object)role.Name, (object)role2.Name, (object)num594));
						num590 = (int)(num2 * 1316395436) ^ -1282155149;
						continue;
					case 4u:
						num594 = target.MaxHp - 1;
						num590 = 1233339926;
						continue;
					case 16u:
						goto IL_05f4;
					case 3u:
						target.Hp = target.MaxHp;
						num590 = ((int)num2 * -1423480016) ^ -144505936;
						continue;
					case 11u:
					{
						int num598;
						int num599;
						if (!Tools.ProbabilityTest(0.1))
						{
							num598 = 492329495;
							num599 = num598;
						}
						else
						{
							num598 = 1581256589;
							num599 = num598;
						}
						num590 = num598 ^ ((int)num2 * -1400086884);
						continue;
					}
					case 13u:
					{
						attackCount = source.GetAttackCount();
						int num596;
						int num597;
						if (attackCount > 1)
						{
							num596 = -1309544377;
							num597 = num596;
						}
						else
						{
							num596 = -314206072;
							num597 = num596;
						}
						num590 = num596 ^ (int)(num2 * 203336024);
						continue;
					}
					case 0u:
						target.MaxHp = 1;
						num590 = ((int)num2 * -339712624) ^ -544860336;
						continue;
					case 9u:
						goto IL_06a9;
					case 5u:
						attackResult.AddCastInfo2(source, _200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[789], (object)role.Name), 0.9f, skill.AttackTime);
						num590 = ((int)num2 * -596560299) ^ 0x127F83AB;
						continue;
					case 2u:
						target.MaxHp -= num594;
						num590 = (int)(num2 * 1003571981) ^ -1636242088;
						continue;
					case 17u:
					{
						double num595 = _206E_206E_206B_206C_200B_202D_202C_202B_202E_200B_200C_206B_206D_202B_200E_200B_200C_206D_206C_206E_206B_200E_200F_202E_202C_202C_200D_200D_206A_206F_200C_206E_206B_202A_206C_200D_202B_206D_200E_202E_202E((double)(attackCount - 1) * 100.0, (double)(attackCount - 1) * 0.01 * (double)attackResult.Hp);
						attackResult.Hp += (int)num595;
						attackResult.AddCastInfo2(source, ResourceStrings.ResStrings[260], 0.12f, skill.AttackTime);
						Log(_202B_202B_206C_202D_202C_206A_202D_206C_200B_200B_206D_202D_200F_202E_200D_206B_202B_202B_206E_206F_202E_200F_202E_200D_200F_206D_200D_206D_200B_206A_206C_202D_202C_200E_206E_200F_200D_202B_200C_200E_202E(ResourceStrings.ResStrings[763], (object)role.Name, (object)attackCount, (object)(int)num595));
						num590 = ((int)num2 * -1962745664) ^ -1180976880;
						continue;
					}
					case 18u:
						attackResult.AddAttackInfo2(target, _200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[762], (object)num594), Color.yellow, skill.AttackTime);
						num590 = 1809152391;
						continue;
					case 15u:
						Log(_200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[761], (object)role2.Name));
						num590 = ((int)num2 * -1935119208) ^ -87845234;
						continue;
					default:
						goto IL_0837;
					}
					break;
					IL_0837:
					IEnumerator<BattleSprite> enumerator = bf.Sprites.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0899:
							int num602;
							int num603;
							if (!_202D_202A_206C_200D_200F_202B_202A_206D_206F_206C_200C_200E_200C_202A_200F_202B_200C_202A_206B_206E_202C_202C_206A_200C_200D_206B_202C_200F_206E_206D_206E_202C_206A_202D_206E_206E_206A_206E_206E_206A_202E((IEnumerator)enumerator))
							{
								num602 = 1701575716;
								num603 = num602;
							}
							else
							{
								num602 = 567094937;
								num603 = num602;
							}
							while (true)
							{
								switch ((num2 = (uint)(num602 ^ 0x78034022)) % 10)
								{
								case 5u:
									num602 = 567094937;
									continue;
								default:
									goto end_IL_084b;
								case 7u:
									current12 = enumerator.Current;
									num602 = 1572902294;
									continue;
								case 9u:
									break;
								case 3u:
								{
									int num608;
									int num609;
									if (_200F_200E_206C_206D_202A_206A_206A_202B_206E_202D_202E_206F_206D_206D_206F_200E_202E_206D_206B_206D_202B_202C_206A_202A_200D_200D_206D_200C_200C_202B_206A_202D_202D_200C_206A_206C_206F_206B_200C_200C_202E((Object)(object)current12, (Object)(object)source))
									{
										num608 = 1614468247;
										num609 = num608;
									}
									else
									{
										num608 = 1222978038;
										num609 = num608;
									}
									num602 = num608 ^ ((int)num2 * -1913026759);
									continue;
								}
								case 6u:
								{
									int num606;
									int num607;
									if (current12.Hp > 1)
									{
										num606 = 1750118128;
										num607 = num606;
									}
									else
									{
										num606 = 1121464625;
										num607 = num606;
									}
									num602 = num606 ^ ((int)num2 * -125106400);
									continue;
								}
								case 4u:
								{
									int num610;
									int num611;
									if (current12.Team == source.Team)
									{
										num610 = -912006890;
										num611 = num610;
									}
									else
									{
										num610 = -781759661;
										num611 = num610;
									}
									num602 = num610 ^ (int)(num2 * 881832889);
									continue;
								}
								case 0u:
								{
									int num604;
									int num605;
									if (!current12.Role.BuiltInTalents[87])
									{
										num604 = -1423969327;
										num605 = num604;
									}
									else
									{
										num604 = -1461798083;
										num605 = num604;
									}
									num602 = num604 ^ (int)(num2 * 201028776);
									continue;
								}
								case 1u:
									attackResult.Hp = (int)((double)attackResult.Hp * (1.0 + random / 10.0));
									attackResult.AddAttackInfo2(current12, ResourceStrings.ResStrings[248], Color.red, skill.AttackTime);
									Log(_200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[791], (object)current12.Role.Name));
									num602 = (int)((num2 * 2010504420) ^ 0x5F86A56D);
									continue;
								case 8u:
									random = Tools.GetRandom(0.0, 1.0);
									num602 = ((int)num2 * -1547936309) ^ 0x47A6A63B;
									continue;
								case 2u:
									goto end_IL_084b;
								}
								goto IL_0899;
								continue;
								end_IL_084b:
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
								IL_0a17:
								int num612 = 861305241;
								while (true)
								{
									switch ((num2 = (uint)(num612 ^ 0x78034022)) % 3)
									{
									case 0u:
										break;
									default:
										goto end_IL_0a1c;
									case 2u:
										goto IL_0a3a;
									case 1u:
										goto end_IL_0a1c;
									}
									goto IL_0a17;
									IL_0a3a:
									_206C_202B_200F_200F_206E_206B_202E_206F_206F_200F_206B_200E_206C_200C_200B_202B_206C_200F_200C_200B_200E_202A_202E_206D_202A_206F_202D_200E_200E_202C_200D_200D_206D_200F_206A_206B_206E_200D_200B_200E_202E((IDisposable)enumerator);
									num612 = ((int)num2 * -332481259) ^ -379765874;
									continue;
									end_IL_0a1c:
									break;
								}
								break;
							}
						}
					}
					goto IL_0a52;
					IL_06a9:
					if (role.BuiltInTalents[87])
					{
						num590 = 1467812820;
						continue;
					}
					goto IL_0a52;
					IL_0518:
					int num613;
					if (role.BuiltInTalents[100] && flag4)
					{
						num590 = 1755748637;
						num613 = num590;
					}
					else
					{
						num590 = 806477427;
						num613 = num590;
					}
					continue;
					IL_0a52:
					if (role.BuiltInTalents[25])
					{
						while (true)
						{
							int num614 = 1299852319;
							while (true)
							{
								switch ((num2 = (uint)(num614 ^ 0x78034022)) % 3)
								{
								case 2u:
									break;
								case 1u:
									list5 = new List<BattleSprite>();
									num614 = ((int)num2 * -1322195002) ^ 0x3075FF52;
									continue;
								default:
									goto end_IL_0a64;
								}
								break;
							}
							continue;
							end_IL_0a64:
							break;
						}
						enumerator = bf.Sprites.GetEnumerator();
						try
						{
							while (true)
							{
								IL_0ae3:
								int num615;
								int num616;
								if (_202D_202A_206C_200D_200F_202B_202A_206D_206F_206C_200C_200E_200C_202A_200F_202B_200C_202A_206B_206E_202C_202C_206A_200C_200D_206B_202C_200F_206E_206D_206E_202C_206A_202D_206E_206E_206A_206E_206E_206A_202E((IEnumerator)enumerator))
								{
									num615 = 1151038486;
									num616 = num615;
								}
								else
								{
									num615 = 1661992487;
									num616 = num615;
								}
								while (true)
								{
									switch ((num2 = (uint)(num615 ^ 0x78034022)) % 7)
									{
									case 5u:
										num615 = 1151038486;
										continue;
									default:
										goto end_IL_0ab2;
									case 6u:
										break;
									case 3u:
									{
										int num619;
										int num620;
										if (current13.Role.BuiltInTalents[25])
										{
											num619 = -1037130913;
											num620 = num619;
										}
										else
										{
											num619 = -851926253;
											num620 = num619;
										}
										num615 = num619 ^ ((int)num2 * -1226481113);
										continue;
									}
									case 1u:
										current13 = enumerator.Current;
										num615 = 1309324123;
										continue;
									case 2u:
										list5.Add(current13);
										num615 = (int)(num2 * 1912006297) ^ -569215882;
										continue;
									case 0u:
									{
										int num617;
										int num618;
										if (current13.Team == source.Team)
										{
											num617 = 1767000246;
											num618 = num617;
										}
										else
										{
											num617 = 361641074;
											num618 = num617;
										}
										num615 = num617 ^ ((int)num2 * -1218529393);
										continue;
									}
									case 4u:
										goto end_IL_0ab2;
									}
									goto IL_0ae3;
									continue;
									end_IL_0ab2:
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
									IL_0b8d:
									int num621 = 1482256449;
									while (true)
									{
										switch ((num2 = (uint)(num621 ^ 0x78034022)) % 3)
										{
										case 0u:
											break;
										default:
											goto end_IL_0b92;
										case 2u:
											goto IL_0bb0;
										case 1u:
											goto end_IL_0b92;
										}
										goto IL_0b8d;
										IL_0bb0:
										_206C_202B_200F_200F_206E_206B_202E_206F_206F_200F_206B_200E_206C_200C_200B_202B_206C_200F_200C_200B_200E_202A_202E_206D_202A_206F_202D_200E_200E_202C_200D_200D_206D_200F_206A_206B_206E_200D_200B_200E_202E((IDisposable)enumerator);
										num621 = (int)(num2 * 1042544179) ^ -839390823;
										continue;
										end_IL_0b92:
										break;
									}
									break;
								}
							}
						}
						if (list5.Count >= 3)
						{
							while (true)
							{
								int num622 = 907130806;
								while (true)
								{
									switch ((num2 = (uint)(num622 ^ 0x78034022)) % 3)
									{
									case 0u:
										break;
									case 2u:
										attackResult.Hp = (int)((double)attackResult.Hp * 1.5);
										num622 = ((int)num2 * -764610194) ^ -1630203996;
										continue;
									default:
										goto end_IL_0bd5;
									}
									break;
								}
								continue;
								end_IL_0bd5:
								break;
							}
							using List<BattleSprite>.Enumerator enumerator4 = list5.GetEnumerator();
							while (true)
							{
								IL_0c5f:
								int num623;
								int num624;
								if (!enumerator4.MoveNext())
								{
									num623 = 1831237164;
									num624 = num623;
								}
								else
								{
									num623 = 650603991;
									num624 = num623;
								}
								while (true)
								{
									switch ((num2 = (uint)(num623 ^ 0x78034022)) % 6)
									{
									case 4u:
										num623 = 650603991;
										continue;
									default:
										goto end_IL_0c32;
									case 2u:
										break;
									case 3u:
										Log(_200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[793], (object)current14.Role.Name));
										num623 = ((int)num2 * -1942026218) ^ -1904768436;
										continue;
									case 5u:
										attackResult.AddCastInfo2(current14, ResourceStrings.ResStrings[186], 1f, skill.AttackTime);
										num623 = (int)(num2 * 1567775815) ^ -820572708;
										continue;
									case 1u:
										current14 = enumerator4.Current;
										num623 = 480470457;
										continue;
									case 0u:
										goto end_IL_0c32;
									}
									goto IL_0c5f;
									continue;
									end_IL_0c32:
									break;
								}
								break;
							}
						}
						if (list5.Count > 0)
						{
							while (true)
							{
								int num625 = 775870610;
								while (true)
								{
									switch ((num2 = (uint)(num625 ^ 0x78034022)) % 3)
									{
									case 2u:
										break;
									case 1u:
										goto IL_0d37;
									default:
										goto IL_0d54;
									}
									break;
									IL_0d54:
									using (List<BattleSprite>.Enumerator enumerator4 = list5.GetEnumerator())
									{
										while (true)
										{
											IL_0d8d:
											int num626;
											int num627;
											if (enumerator4.MoveNext())
											{
												num626 = 296859324;
												num627 = num626;
											}
											else
											{
												num626 = 2068187961;
												num627 = num626;
											}
											while (true)
											{
												switch ((num2 = (uint)(num626 ^ 0x78034022)) % 5)
												{
												case 0u:
													num626 = 296859324;
													continue;
												default:
													goto end_IL_0d64;
												case 3u:
													break;
												case 1u:
													Log(_200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(ResourceStrings.ResStrings[795], (object)current15.Role.Name));
													num626 = ((int)num2 * -208388304) ^ -558460070;
													continue;
												case 2u:
													current15 = enumerator4.Current;
													attackResult.AddAttackInfo2(current15, ResourceStrings.ResStrings[794], Color.yellow, skill.AttackTime);
													current15.Role.BuiltInTalents[25] = false;
													num626 = 1631029992;
													continue;
												case 4u:
													goto end_IL_0d64;
												}
												goto IL_0d8d;
												continue;
												end_IL_0d64:
												break;
											}
											break;
										}
									}
									goto end_IL_0d14;
									IL_0d37:
									if (list5.Count >= 3)
									{
										goto end_IL_0d14;
									}
									num625 = ((int)num2 * -728755486) ^ 0x27A853D0;
								}
								continue;
								end_IL_0d14:
								break;
							}
						}
					}
					goto IL_0e3a;
					IL_053d:
					int num628;
					if (target.Hp > target.MaxHp)
					{
						num590 = 970263805;
						num628 = num590;
					}
					else
					{
						num590 = 1647025504;
						num628 = num590;
					}
				}
				goto IL_0465;
				IL_0e3a:
				if (role.BuiltInTalents[101])
				{
					goto IL_0e4c;
				}
				goto IL_5248;
			}
			break;
			IL_01e9:
			int num629;
			if (attackResult.Mp <= -4967297)
			{
				num = 921083229;
				num629 = num;
			}
			else
			{
				num = 231697137;
				num629 = num;
			}
		}
		goto IL_0007;
		IL_00ef:
		int num630;
		if (!_200D_206E_200B_202B_202C_206C_200E_206C_206E_202A_200B_206D_200F_206B_202A_206D_200C_206E_200B_202E_202B_202E_202E_202A_206F_202E_200E_206C_206A_206C_200B_206A_206A_200D_202E_202D_206A_206C_206B_200D_202E((Object)(object)target, (Object)null))
		{
			num = 1385167978;
			num630 = num;
		}
		else
		{
			num = 2024048658;
			num630 = num;
		}
		goto IL_000c;
	}

	static bool _200F_200E_206C_206D_202A_206A_206A_202B_206E_202D_202E_206F_206D_206D_206F_200E_202E_206D_206B_206D_202B_202C_206A_202A_200D_200D_206D_200C_200C_202B_206A_202D_202D_200C_206A_206C_206F_206B_200C_200C_202E(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static string _200C_206C_206B_200E_202C_200C_202E_206E_206F_200E_200D_206B_200B_200C_202D_206A_202D_200D_200D_200B_202A_206B_206C_206A_206B_202C_206F_200F_202E_206E_200D_206D_200F_206F_206C_206B_206B_200D_200C_200D_202E(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}

	static string _206B_202C_202C_200C_206D_200E_202D_200B_202D_202D_206C_206F_200C_206D_200C_200D_206F_200E_200F_206C_200B_200F_206B_202D_206B_202D_206E_206C_202E_206C_202A_200F_200D_202D_202A_200F_206B_202E_200D_202B_202E(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static int _202D_202D_206F_202B_202C_206D_206E_206D_200C_202A_206E_202D_202B_202C_206E_202D_202B_202D_202A_206F_206E_206A_200B_200F_202A_200B_206D_206C_202A_202B_202A_202A_206E_200D_206A_200C_206B_202B_206E_202A_202E(int P_0)
	{
		return Math.Abs(P_0);
	}

	static double _200C_200E_200C_202A_206B_206E_200F_200C_200B_206B_202D_200C_200B_206B_202A_202A_206F_206F_200B_202C_202D_200F_202C_206D_202B_206C_202A_202E_206D_206A_200E_202B_200B_202E_206A_202D_206A_200D_202A_206C_202E(double P_0, double P_1)
	{
		return Math.Pow(P_0, P_1);
	}

	static double _206E_206E_206B_206C_200B_202D_202C_202B_202E_200B_200C_206B_206D_202B_200E_200B_200C_206D_206C_206E_206B_200E_200F_202E_202C_202C_200D_200D_206A_206F_200C_206E_206B_202A_206C_200D_202B_206D_200E_202E_202E(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	static int _200E_200F_206F_200E_200C_206D_200F_202C_206E_206E_202C_200F_202E_202C_202D_206A_200E_206F_200E_200D_206C_202B_200C_206C_200B_200E_206D_206A_200C_206B_200D_206C_200C_202A_200E_202D_200D_200F_200B_206B_202E(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	static int _200C_202C_200E_206D_202A_206B_202B_202B_202D_202B_206C_202D_202A_206A_206E_200C_200E_202E_206B_200F_206A_202E_200E_206E_206E_202C_200E_202B_202A_206D_202B_200B_202D_202D_202B_206A_202B_200F_202D_206F_202E(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	static float _206D_200C_206E_200E_202D_200C_202B_206A_202E_202A_206C_200C_202E_200D_200C_202A_206F_202D_200C_202A_206A_202E_206C_202A_206F_206C_206F_206B_202B_202E_200B_200B_200E_206A_200F_202C_206F_200F_202C_206F_202E(float P_0, float P_1)
	{
		return Math.Max(P_0, P_1);
	}

	static bool _206B_200D_206D_202E_206E_200F_206E_200F_200C_200E_206E_202D_206C_202E_202A_206B_206C_200F_202C_206D_202B_202B_200E_206E_202E_202C_206C_200B_202E_200E_206B_200E_206D_200B_202E_206B_206E_206E_206C_206E_202E(string P_0, string P_1)
	{
		return P_0.StartsWith(P_1);
	}

	static bool _200B_202E_206A_200D_202A_202E_200B_200C_206E_200C_200C_206E_206A_206E_200F_202B_200B_200C_202E_206D_206E_202D_206E_206F_200F_200F_202D_200E_200F_202B_200D_200F_206A_206F_206A_200E_200C_200F_202C_206C_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static bool _200E_202B_202A_200F_206F_200C_200D_206B_200B_200D_202B_206E_206D_200D_200F_206C_206B_202D_202B_202A_202A_202D_202B_200B_200B_206F_200B_202D_206F_202E_200D_202B_202C_200F_202A_200B_202E_200C_200B_200C_202E(string P_0, string P_1)
	{
		return P_0.Contains(P_1);
	}

	static double _206C_200D_200B_202C_202B_206E_202B_206D_206B_202E_200B_202B_206D_200C_206E_206E_206C_202D_206B_200C_206E_202C_200F_206F_200D_200F_202A_202E_200C_202C_202A_200E_206B_202A_200F_200B_206D_200B_202A_200C_202E(int P_0)
	{
		return Convert.ToDouble(P_0);
	}

	static bool _200D_206E_200B_202B_202C_206C_200E_206C_206E_202A_200B_206D_200F_206B_202A_206D_200C_206E_200B_202E_202B_202E_202E_202A_206F_202E_200E_206C_206A_206C_200B_206A_206A_200D_202E_202D_206A_206C_206B_200D_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static bool _202D_202A_206C_200D_200F_202B_202A_206D_206F_206C_200C_200E_200C_202A_200F_202B_200C_202A_206B_206E_202C_202C_206A_200C_200D_206B_202C_200F_206E_206D_206E_202C_206A_202D_206E_206E_206A_206E_206E_206A_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _206C_202B_200F_200F_206E_206B_202E_206F_206F_200F_206B_200E_206C_200C_200B_202B_206C_200F_200C_200B_200E_202A_202E_206D_202A_206F_202D_200E_200E_202C_200D_200D_206D_200F_206A_206B_206E_200D_200B_200E_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static string _202B_202B_206C_202D_202C_206A_202D_206C_200B_200B_206D_202D_200F_202E_200D_206B_202B_202B_206E_206F_202E_200F_202E_200D_200F_206D_200D_206D_200B_206A_206C_202D_202C_200E_206E_200F_200D_202B_200C_200E_202E(string P_0, object P_1, object P_2, object P_3)
	{
		return string.Format(P_0, P_1, P_2, P_3);
	}

	static string[] _202B_206B_200E_206C_206A_200C_206F_200B_202B_200D_206F_200E_202E_206E_200C_200D_206D_202E_202D_206C_206E_200E_200D_200B_202E_206E_202D_200B_200F_202D_206E_206B_200D_202C_206A_206B_202B_200D_200F_206E_202E(string P_0, char[] P_1)
	{
		return P_0.Split(P_1);
	}

	static double _200E_200D_200B_202E_206E_206C_200B_200B_202A_202E_200C_202B_206C_202A_200E_200F_200B_202C_200C_206B_200C_202A_206D_202C_202A_200E_200E_206C_206C_206B_206A_202B_202E_202C_206E_206B_202C_200D_202A_206D_202E(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	static string _202C_202D_200B_202E_202E_206C_206E_206B_206D_200F_200B_200D_200E_206B_202E_200D_200D_200E_200F_202B_202E_202E_202E_206E_206D_206B_206E_202B_202A_206E_206B_202A_200E_200D_200F_200D_206C_200C_200F_206A_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}
}
