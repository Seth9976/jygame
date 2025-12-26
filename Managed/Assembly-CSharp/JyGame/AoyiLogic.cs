using System;
using System.Collections;
using System.Collections.Generic;

namespace JyGame;

public class AoyiLogic
{
	public static Aoyi ChangeToAoyi(BattleSprite sprite, SkillBox currentSkill)
	{
		IEnumerable<Aoyi> all = ResourceManager.GetAll<Aoyi>();
		Aoyi aoyi = null;
		IEnumerator<Aoyi> enumerator = all.GetEnumerator();
		try
		{
			Aoyi current = default(Aoyi);
			BuffInstance buff2 = default(BuffInstance);
			double num6 = default(double);
			double num5 = default(double);
			double num4 = default(double);
			double num3 = default(double);
			BuffInstance buff = default(BuffInstance);
			bool flag = default(bool);
			bool flag2 = default(bool);
			AoyiCondition current2 = default(AoyiCondition);
			bool flag3 = default(bool);
			string[] array3 = default(string[]);
			string[] array = default(string[]);
			int num23 = default(int);
			string[] array2 = default(string[]);
			AoyiCondition aoyiCondition2 = default(AoyiCondition);
			while (true)
			{
				IL_08d6:
				if (_200E_200E_206B_206A_206B_202E_200F_206D_206B_206E_202B_202C_206C_206C_200C_206D_202E_202D_200F_202E_206C_206A_202B_200B_200C_206B_206F_206F_206E_202E_202A_200D_202E_200C_206D_206E_200C_200D_206A_202E((IEnumerator)enumerator))
				{
					while (true)
					{
						current = enumerator.Current;
						if (!_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(currentSkill.Name, current.start))
						{
							break;
						}
						int num = 1409606395;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num ^ 0x6D51048A)) % 23)
							{
							case 14u:
								num = 544098160;
								continue;
							case 12u:
							{
								buff2 = sprite.GetBuff(ResourceStrings.ResStrings[1252]);
								int num15;
								int num16;
								if (buff2 != null)
								{
									num15 = -1821901065;
									num16 = num15;
								}
								else
								{
									num15 = -1427527845;
									num16 = num15;
								}
								num = num15 ^ ((int)num2 * -1268080027);
								continue;
							}
							case 4u:
							{
								num6 += num5;
								num4 = (double)current.probability * num6;
								int num9;
								int num10;
								if (CommonSettings.MOD_KEY() != 2)
								{
									num9 = -673665610;
									num10 = num9;
								}
								else
								{
									num9 = -1139665885;
									num10 = num9;
								}
								num = num9 ^ ((int)num2 * -1011183362);
								continue;
							}
							case 8u:
								num4 = 0.99;
								num = (int)((num2 * 1902414879) ^ 0x7CBB1758);
								continue;
							case 5u:
								num6 = sprite.Role.AoyiBaseProbability;
								num = ((int)num2 * -1223231669) ^ -779765637;
								continue;
							case 15u:
								break;
							case 9u:
								num4 += 0.01 + (double)_202C_206C_206D_206A_200F_206D_202D_200B_206E_200C_200B_200C_202C_206E_206D_206F_200C_202E_200D_206D_206C_200D_202D_200D_200C_200B_200F_200D_202B_202B_202B_206E_202B_202D_202C_200F_206E_200F_206A_202D_202E(20, buff2.Level) * 0.02;
								num = (int)(num2 * 289749184) ^ -38149928;
								continue;
							case 1u:
								num3 += 5.0;
								num = ((int)num2 * -1774979756) ^ -162072623;
								continue;
							case 2u:
								goto IL_01b6;
							case 22u:
								num5 += 0.1;
								num = ((int)num2 * -889336923) ^ -1359231082;
								continue;
							case 13u:
							{
								num4 = 0.0;
								num5 = 0.0;
								int num13;
								int num14;
								if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(currentSkill.Name, ResourceStrings.ResStrings[157]))
								{
									num13 = -977584236;
									num14 = num13;
								}
								else
								{
									num13 = -1777699548;
									num14 = num13;
								}
								num = num13 ^ (int)(num2 * 2120567478);
								continue;
							}
							case 20u:
								num = (int)((num2 * 1346936523) ^ 0x1707F59A);
								continue;
							case 18u:
							{
								int num11;
								int num12;
								if (buff == null)
								{
									num11 = -1845692952;
									num12 = num11;
								}
								else
								{
									num11 = -216820332;
									num12 = num11;
								}
								num = num11 ^ ((int)num2 * -1167255441);
								continue;
							}
							case 7u:
								flag = true;
								num = ((int)num2 * -1506776150) ^ -285080485;
								continue;
							case 0u:
							{
								int num7;
								int num8;
								if (!sprite.Role.HasTalent(ResourceStrings.ResStrings[158]))
								{
									num7 = -965294974;
									num8 = num7;
								}
								else
								{
									num7 = -322395458;
									num8 = num7;
								}
								num = num7 ^ (int)(num2 * 2122025871);
								continue;
							}
							case 16u:
								num4 = ((double)current.probability + (double)sprite.Role.AttributesFinal[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1368077529u)] * 0.00035) * (1.0 + num5 + num6 + num3);
								num = 1309457890;
								continue;
							case 3u:
								goto IL_0318;
							case 17u:
								goto IL_032e;
							case 10u:
								num3 = 0.0;
								buff = sprite.GetBuff(ResourceStrings.ResStrings[1215]);
								num = 1613628569;
								continue;
							case 6u:
								goto IL_0397;
							case 21u:
								num3 = 0.1 * (double)buff.Level;
								num = ((int)num2 * -248081905) ^ 0x3205E2D8;
								continue;
							case 11u:
								goto IL_03df;
							default:
								goto IL_040a;
							}
							break;
							IL_03df:
							int num17;
							if (sprite.GetBuff(ResourceStrings.ResStrings[1216]) == null)
							{
								num = 618519661;
								num17 = num;
							}
							else
							{
								num = 561120185;
								num17 = num;
							}
							continue;
							IL_01b6:
							if (currentSkill.Level < current.level)
							{
								goto end_IL_0133;
							}
							num = ((int)num2 * -312671011) ^ 0x5914375D;
							continue;
							IL_032e:
							num5 += sprite.Role.Get_powerup_aoyi(current.Name, getpower: false) / 100.0;
							int num18;
							if (CommonSettings.MOD_KEY() == 1)
							{
								num = 1902469262;
								num18 = num;
							}
							else
							{
								num = 938810883;
								num18 = num;
							}
							continue;
							IL_0397:
							int num19;
							if (num4 <= 0.99)
							{
								num = 1309457890;
								num19 = num;
							}
							else
							{
								num = 974758796;
								num19 = num;
							}
							continue;
							IL_0318:
							if (!Tools.ProbabilityTest(num4))
							{
								goto end_IL_0133;
							}
							num = 2019199917;
						}
						continue;
						end_IL_0133:
						break;
					}
					continue;
				}
				int num20 = 1930041102;
				goto IL_08b0;
				IL_08b0:
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num20 ^ 0x6D51048A)) % 5)
					{
					case 3u:
						break;
					default:
						goto end_IL_08d6;
					case 0u:
						goto IL_08d6;
					case 4u:
						aoyi.attacktime = currentSkill.AttackTime;
						goto end_IL_08d6;
					case 1u:
						aoyi = current;
						num20 = (int)(num2 * 440901350) ^ -1944820177;
						continue;
					case 2u:
						goto end_IL_08d6;
					}
					break;
				}
				goto IL_08ab;
				IL_08ab:
				num20 = 577837401;
				goto IL_08b0;
				IL_040a:
				using (List<AoyiCondition>.Enumerator enumerator2 = current.Conditions.GetEnumerator())
				{
					while (true)
					{
						IL_04f5:
						int num21;
						int num22;
						if (enumerator2.MoveNext())
						{
							num21 = 798985875;
							num22 = num21;
						}
						else
						{
							num21 = 1518309644;
							num22 = num21;
						}
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num21 ^ 0x6D51048A)) % 31)
							{
							case 30u:
								num21 = 798985875;
								continue;
							default:
								goto end_IL_0421;
							case 3u:
								flag2 = GetChangeToAoyiResult(sprite, current2);
								num21 = 2040146872;
								continue;
							case 9u:
								flag = false;
								num21 = ((int)num2 * -2103034804) ^ -1768817626;
								continue;
							case 5u:
							{
								int num39;
								if (!flag2)
								{
									num21 = 1745565994;
									num39 = num21;
								}
								else
								{
									num21 = 1717234764;
									num39 = num21;
								}
								continue;
							}
							case 20u:
								break;
							case 7u:
								flag2 = flag3;
								num21 = ((int)num2 * -265267548) ^ -65905102;
								continue;
							case 17u:
								array3 = _206F_206F_206D_200D_200C_202C_200E_202C_202B_200D_206D_202D_200E_200F_200C_200E_202E_202E_206B_200B_206B_206D_202E_200B_202B_206D_202E_206E_206F_206D_200B_206F_200D_206B_206B_200F_202D_200F_206D_206F_202E(current2.levelValue, new char[1] { '|' });
								num21 = ((int)num2 * -1128806493) ^ 0x31A5903F;
								continue;
							case 26u:
							{
								flag3 = false;
								int num30;
								if (_202D_202D_200E_206B_200D_202A_200C_200C_200F_200D_206B_206B_200E_202B_200B_202A_202A_206A_202C_200E_200D_200C_200C_202B_206B_200D_200D_200F_202A_202E_200B_200E_200D_202C_206D_206F_200C_200C_200F_202A_202E(array[num23], global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3816599084u)))
								{
									num21 = 282794613;
									num30 = num21;
								}
								else
								{
									num21 = 222882361;
									num30 = num21;
								}
								continue;
							}
							case 2u:
								flag2 = flag3;
								num21 = (int)((num2 * 739994326) ^ 0x18547A98);
								continue;
							case 25u:
							{
								int num37;
								if (!_202D_202D_200E_206B_200D_202A_200C_200C_200F_200D_206B_206B_200E_202B_200B_202A_202A_206A_202C_200E_200D_200C_200C_202B_206B_200D_200D_200F_202A_202E_200B_200E_200D_202C_206D_206F_200C_200C_200F_202A_202E(current2.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1102747038u)))
								{
									num21 = 2137516256;
									num37 = num21;
								}
								else
								{
									num21 = 301554354;
									num37 = num21;
								}
								continue;
							}
							case 13u:
								array2 = _206F_206F_206D_200D_200C_202C_200E_202C_202B_200D_206D_202D_200E_200F_200C_200E_202E_202E_206B_200B_206B_206D_202E_200B_202B_206D_202E_206E_206F_206D_200B_206F_200D_206B_206B_200F_202D_200F_206D_206F_202E(current2.value, new char[1] { '|' });
								num21 = ((int)num2 * -537861788) ^ -8787178;
								continue;
							case 23u:
							{
								int num33;
								int num34;
								if (array.Length > 1)
								{
									num33 = -1201919982;
									num34 = num33;
								}
								else
								{
									num33 = -1294399526;
									num34 = num33;
								}
								num21 = num33 ^ ((int)num2 * -1854444505);
								continue;
							}
							case 6u:
							{
								int num26;
								int num27;
								if (!_202E_206F_206D_206D_206B_202A_200F_202B_202C_200D_206A_200E_206C_200E_206E_200D_206A_206A_206B_206A_206D_200C_206D_200D_206C_206D_202C_206A_206B_206F_206A_200E_202B_202E_206C_206A_200F_206E_202A_206F_202E(current2.type, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(271982949u)))
								{
									num26 = 2109601965;
									num27 = num26;
								}
								else
								{
									num26 = 890319716;
									num27 = num26;
								}
								num21 = num26 ^ ((int)num2 * -1218221654);
								continue;
							}
							case 8u:
								array = _206F_206F_206D_200D_200C_202C_200E_202C_202B_200D_206D_202D_200E_200F_200C_200E_202E_202E_206B_200B_206B_206D_202E_200B_202B_206D_202E_206E_206F_206D_200B_206F_200D_206B_206B_200F_202D_200F_206D_206F_202E(current2.type, new char[1] { '|' });
								num21 = (int)((num2 * 1830138739) ^ 0x229373B0);
								continue;
							case 27u:
								num21 = ((int)num2 * -2115952616) ^ -418266240;
								continue;
							case 14u:
								flag2 = !GetChangeToAoyiResult(sprite, current2);
								num21 = (int)((num2 * 1507279728) ^ 0x3B57BC98);
								continue;
							case 10u:
							{
								int num38;
								if (num23 < array.Length)
								{
									num21 = 1760958900;
									num38 = num21;
								}
								else
								{
									num21 = 1294076199;
									num38 = num21;
								}
								continue;
							}
							case 29u:
								num21 = ((int)num2 * -1343738549) ^ -1795090648;
								continue;
							case 15u:
							{
								flag3 = GetChangeToAoyiResult(sprite, aoyiCondition2);
								int num35;
								int num36;
								if (!flag3)
								{
									num35 = 1634391044;
									num36 = num35;
								}
								else
								{
									num35 = 1618946533;
									num36 = num35;
								}
								num21 = num35 ^ ((int)num2 * -359347035);
								continue;
							}
							case 0u:
							{
								int num31;
								int num32;
								if (array.Length == array2.Length)
								{
									num31 = -1649168004;
									num32 = num31;
								}
								else
								{
									num31 = -2025259526;
									num32 = num31;
								}
								num21 = num31 ^ (int)(num2 * 284228530);
								continue;
							}
							case 28u:
								current2.type = _206E_200B_206C_206C_202C_206E_200C_202D_206F_202B_202E_200D_202D_200E_200E_206D_206F_200E_200D_206B_206E_206C_206F_202A_206E_202D_206B_206A_200D_202A_206C_206E_202C_206F_200D_202E_200E_200F_200F_206E_202E(current2.type, 1, _206F_200E_206A_200C_206A_200F_200C_200C_206E_200F_200D_206B_206B_202C_202E_200C_206F_202C_200F_206E_206E_206A_206B_200B_206A_200E_206D_206B_200F_202C_202E_202C_200E_206A_200B_206E_206C_200E_200E_200D_202E(current2.type) - 1);
								num21 = (int)((num2 * 648076718) ^ 0x6FE7B84);
								continue;
							case 16u:
							{
								int num28;
								int num29;
								if (flag3)
								{
									num28 = 1290227484;
									num29 = num28;
								}
								else
								{
									num28 = 925778157;
									num29 = num28;
								}
								num21 = num28 ^ (int)(num2 * 1315425723);
								continue;
							}
							case 19u:
								num21 = ((int)num2 * -41775138) ^ 0x8755060;
								continue;
							case 18u:
								num23 = 0;
								num21 = ((int)num2 * -1584001166) ^ -606747224;
								continue;
							case 21u:
							{
								int num24;
								int num25;
								if (array2.Length == array3.Length)
								{
									num24 = 1722066260;
									num25 = num24;
								}
								else
								{
									num24 = 1558534568;
									num25 = num24;
								}
								num21 = num24 ^ (int)(num2 * 1476022804);
								continue;
							}
							case 11u:
								aoyiCondition2 = new AoyiCondition
								{
									type = array[num23],
									value = array2[num23],
									levelValue = array3[num23]
								};
								num21 = 422634534;
								continue;
							case 12u:
							{
								AoyiCondition aoyiCondition = new AoyiCondition
								{
									type = _206E_200B_206C_206C_202C_206E_200C_202D_206F_202B_202E_200D_202D_200E_200E_206D_206F_200E_200D_206B_206E_206C_206F_202A_206E_202D_206B_206A_200D_202A_206C_206E_202C_206F_200D_202E_200E_200F_200F_206E_202E(array[num23], 1, _206F_200E_206A_200C_206A_200F_200C_200C_206E_200F_200D_206B_206B_202C_202E_200C_206F_202C_200F_206E_206E_206A_206B_200B_206A_200E_206D_206B_200F_202C_202E_202C_200E_206A_200B_206E_206C_200E_200E_200D_202E(array[num23]) - 1),
									value = array2[num23],
									levelValue = array3[num23]
								};
								flag3 = !GetChangeToAoyiResult(sprite, aoyiCondition);
								num21 = (int)(num2 * 1933747978) ^ -698131789;
								continue;
							}
							case 1u:
								goto end_IL_0421;
							case 22u:
								num23++;
								num21 = 110285052;
								continue;
							case 24u:
								current2 = enumerator2.Current;
								flag2 = false;
								num21 = 384099445;
								continue;
							case 4u:
								goto end_IL_0421;
							}
							goto IL_04f5;
							continue;
							end_IL_0421:
							break;
						}
						break;
					}
				}
				if (!flag)
				{
					continue;
				}
				goto IL_08ab;
				continue;
				end_IL_08d6:
				break;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_091d:
					int num40 = 1535967607;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num40 ^ 0x6D51048A)) % 3)
						{
						case 2u:
							break;
						default:
							goto end_IL_0922;
						case 1u:
							goto IL_0940;
						case 0u:
							goto end_IL_0922;
						}
						goto IL_091d;
						IL_0940:
						_200E_200B_200E_202B_206D_206F_206A_200C_206C_200B_206F_206F_200D_206F_206C_206B_202E_206E_200E_200E_202B_202A_206A_200C_202B_206D_200E_200F_202B_202E_206A_206C_200F_200F_206C_206F_202A_200E_200D_200C_202E((IDisposable)enumerator);
						num40 = ((int)num2 * -1188314113) ^ 0x1A36F03C;
						continue;
						end_IL_0922:
						break;
					}
					break;
				}
			}
		}
		return aoyi;
	}

	public static double GetAoyiBaseProbability(Role role)
	{
		if (role.EquippedTitle == null)
		{
			goto IL_000b;
		}
		float num = role.EquippedTitle.Title.AoyiProbabilityAdd;
		goto IL_01a2;
		IL_018b:
		num = 0f;
		goto IL_01a2;
		IL_000b:
		int num2 = -1041586596;
		goto IL_0010;
		IL_0010:
		double num4 = default(double);
		double num5 = default(double);
		float num12 = default(float);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -1721633505)) % 20)
			{
			case 11u:
				break;
			case 12u:
			{
				num4 *= 1.0 + (double)role.AttributesFinal[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1368077529u)] / (double)BattleField.ROLE_MAX_ATTRIBUTE[role] * 0.2;
				int num10;
				int num11;
				if (num4 > 3.0)
				{
					num10 = -1573865275;
					num11 = num10;
				}
				else
				{
					num10 = -1523479219;
					num11 = num10;
				}
				num2 = num10 ^ ((int)num3 * -198343241);
				continue;
			}
			case 18u:
				num4 = 3.0;
				num2 = ((int)num3 * -1966379242) ^ 0x413B08A1;
				continue;
			case 4u:
			{
				int num8;
				int num9;
				if (role.HasRoleTalent(ResourceStrings.ResStrings[1253]))
				{
					num8 = -2070782932;
					num9 = num8;
				}
				else
				{
					num8 = -2118574470;
					num9 = num8;
				}
				num2 = num8 ^ (int)(num3 * 1849598498);
				continue;
			}
			case 10u:
				num5 += 0.2;
				num2 = (int)(num3 * 2014733382) ^ -1943198873;
				continue;
			case 13u:
			{
				int num13;
				int num14;
				if (role.HasTalent(ResourceStrings.ResStrings[159]))
				{
					num13 = 648485316;
					num14 = num13;
				}
				else
				{
					num13 = 533114529;
					num14 = num13;
				}
				num2 = num13 ^ ((int)num3 * -846080507);
				continue;
			}
			case 15u:
				num4 = 1.0;
				num2 = -290593009;
				continue;
			case 7u:
				goto IL_018b;
			case 6u:
				num4 += 0.5;
				num2 = ((int)num3 * -676141085) ^ -424411154;
				continue;
			case 0u:
				num5 = 0.0 + (double)num12;
				num2 = (int)((num3 * 1503380443) ^ 0x17B21E7E);
				continue;
			case 19u:
				num4 += 0.15;
				num2 = (int)(num3 * 1201916241) ^ -1913819335;
				continue;
			case 9u:
				goto IL_021a;
			case 2u:
				num4 += (double)num12;
				num2 = -282329290;
				continue;
			case 8u:
				goto IL_0254;
			case 5u:
				num5 += 0.08;
				num2 = (int)((num3 * 811362640) ^ 0x726289DB);
				continue;
			case 1u:
			{
				int num6;
				int num7;
				if (!role.HasTalent(ResourceStrings.ResStrings[159]))
				{
					num6 = 491597163;
					num7 = num6;
				}
				else
				{
					num6 = 1626583910;
					num7 = num6;
				}
				num2 = num6 ^ (int)(num3 * 1472472032);
				continue;
			}
			case 16u:
				return num5;
			case 3u:
				goto IL_02dc;
			case 14u:
				num5 += 5.0;
				num2 = (int)((num3 * 771792110) ^ 0x3637FCFA);
				continue;
			default:
				return num4;
			}
			break;
			IL_02dc:
			int num15;
			if (CommonSettings.MOD_KEY() != 2)
			{
				num2 = -476751990;
				num15 = num2;
			}
			else
			{
				num2 = -708566937;
				num15 = num2;
			}
			continue;
			IL_0254:
			int num16;
			if (role.HasTalent(ResourceStrings.ResStrings[1217]))
			{
				num2 = -130508455;
				num16 = num2;
			}
			else
			{
				num2 = -1523929618;
				num16 = num2;
			}
			continue;
			IL_021a:
			int num17;
			if (!role.HasTalent(ResourceStrings.ResStrings[1218]))
			{
				num2 = -1690667629;
				num17 = num2;
			}
			else
			{
				num2 = -1297434591;
				num17 = num2;
			}
		}
		goto IL_000b;
		IL_01a2:
		num12 = num;
		int num18;
		if (CommonSettings.MOD_KEY() != 1)
		{
			num2 = -1022267872;
			num18 = num2;
		}
		else
		{
			num2 = -862217781;
			num18 = num2;
		}
		goto IL_0010;
	}

	private static bool GetChangeToAoyiResult(BattleSprite sprite, AoyiCondition aoyiCondition)
	{
		if (!_206D_206C_202B_202E_200C_202E_202D_202C_202E_206A_202B_206F_206C_206E_202B_200C_206E_206F_200E_206F_200B_200B_200F_200B_206F_206C_200E_202E_206B_206D_206F_206C_200E_202B_200C_200E_200C_202A_200D_202B_202E(aoyiCondition.value))
		{
			Role role = default(Role);
			BuffInstance buff = default(BuffInstance);
			string[] array = default(string[]);
			string[] array2 = default(string[]);
			bool result = default(bool);
			while (true)
			{
				int num = -1511070200;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -41154371)) % 26)
					{
					case 18u:
						break;
					case 23u:
						return true;
					case 10u:
						goto IL_00a8;
					case 4u:
						goto IL_00cc;
					case 21u:
						goto IL_00f0;
					case 17u:
						goto IL_011b;
					case 7u:
						goto IL_0141;
					case 25u:
						goto IL_016b;
					case 19u:
						return true;
					case 3u:
						goto IL_01ab;
					case 14u:
						goto IL_01cf;
					case 22u:
						goto IL_01f3;
					case 6u:
						goto IL_0217;
					case 15u:
						goto IL_0242;
					case 1u:
						role = sprite.Role;
						num = ((int)num2 * -1373232894) ^ 0x51DD9E47;
						continue;
					case 13u:
						return true;
					case 8u:
						return true;
					case 24u:
						goto IL_02b1;
					case 11u:
						goto IL_02db;
					case 2u:
						goto IL_0306;
					case 5u:
						goto IL_0331;
					case 16u:
					{
						int num3;
						int num4;
						if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(278347322u)))
						{
							num3 = -1353842401;
							num4 = num3;
						}
						else
						{
							num3 = -2105023837;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 1134098929);
						continue;
					}
					case 12u:
						return true;
					case 20u:
						return true;
					case 0u:
						return true;
					default:
						goto IL_03ce;
					}
					break;
					IL_03ce:
					using (List<ItemInstance>.Enumerator enumerator = role.Equipment.GetEnumerator())
					{
						while (true)
						{
							IL_0431:
							int num5;
							int num6;
							if (enumerator.MoveNext())
							{
								num5 = -267110072;
								num6 = num5;
							}
							else
							{
								num5 = -1496556100;
								num6 = num5;
							}
							while (true)
							{
								switch ((num2 = (uint)(num5 ^ -41154371)) % 5)
								{
								case 3u:
									num5 = -267110072;
									continue;
								default:
									goto end_IL_03e1;
								case 4u:
								{
									int num7;
									if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(enumerator.Current.Name, aoyiCondition.value))
									{
										num5 = -806397075;
										num7 = num5;
									}
									else
									{
										num5 = -355241553;
										num7 = num5;
									}
									continue;
								}
								case 2u:
									break;
								case 0u:
									return true;
								case 1u:
									goto end_IL_03e1;
								}
								goto IL_0431;
								continue;
								end_IL_03e1:
								break;
							}
							break;
						}
					}
					goto end_IL_0010;
					IL_0331:
					if (role.GetInternalSkillLevel(aoyiCondition.value) < aoyiCondition.level)
					{
						goto end_IL_0010;
					}
					num = ((int)num2 * -1885834868) ^ -1946163277;
					continue;
					IL_00f0:
					int num8;
					if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(810474758u)))
					{
						num = -1529592411;
						num8 = num;
					}
					else
					{
						num = -795338572;
						num8 = num;
					}
					continue;
					IL_0306:
					int num9;
					if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4028951057u)))
					{
						num = -1204997492;
						num9 = num;
					}
					else
					{
						num = -598235984;
						num9 = num;
					}
					continue;
					IL_01f3:
					if (role.GetSpecialSkill(aoyiCondition.value) == null)
					{
						goto end_IL_0010;
					}
					num = (int)(num2 * 1015982227) ^ -2138974332;
					continue;
					IL_0141:
					if (_200E_202E_202E_206B_206C_202E_206D_202E_200B_202A_206A_206B_202D_200D_202B_202D_206F_200D_206F_206B_200C_202B_200E_200C_206A_206F_206B_200C_202E_202C_200B_200E_200D_202A_200C_200F_200D_202D_202B_202B_202E(0, buff.Level) < aoyiCondition.level)
					{
						goto end_IL_0010;
					}
					num = (int)(num2 * 828123023) ^ -990952208;
					continue;
					IL_02db:
					int num10;
					if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1871779284u)))
					{
						num = -455154015;
						num10 = num;
					}
					else
					{
						num = -312395636;
						num10 = num;
					}
					continue;
					IL_01cf:
					if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1812516200u)))
					{
						num = -1621352354;
						continue;
					}
					goto IL_0478;
					IL_00cc:
					if (!role.HasTalent(aoyiCondition.value))
					{
						goto end_IL_0010;
					}
					num = ((int)num2 * -305265931) ^ -1065895830;
					continue;
					IL_02b1:
					if (role.GetSkillLevel(aoyiCondition.value) < aoyiCondition.level)
					{
						goto end_IL_0010;
					}
					num = (int)(num2 * 2066308256) ^ -1829517411;
					continue;
					IL_01ab:
					if (!role.HasEquipmentTalent(aoyiCondition.value))
					{
						goto end_IL_0010;
					}
					num = ((int)num2 * -611203387) ^ -1537467468;
					continue;
					IL_0242:
					int num11;
					if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2323905826u)))
					{
						num = -1172640161;
						num11 = num;
					}
					else
					{
						num = -1107709432;
						num11 = num;
					}
					continue;
					IL_011b:
					buff = sprite.GetBuff(aoyiCondition.value);
					if (buff == null)
					{
						goto end_IL_0010;
					}
					num = ((int)num2 * -156046324) ^ -526825482;
					continue;
					IL_016b:
					int num12;
					if (!_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3833808748u)))
					{
						num = -1435975829;
						num12 = num;
					}
					else
					{
						num = -537508082;
						num12 = num;
					}
					continue;
					IL_0217:
					int num13;
					if (!_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(764267077u)))
					{
						num = -852228961;
						num13 = num;
					}
					else
					{
						num = -1337841828;
						num13 = num;
					}
					continue;
					IL_00a8:
					if (!role.HasRoleTalent(aoyiCondition.value))
					{
						goto end_IL_0010;
					}
					num = (int)(num2 * 1313061571) ^ -1761959984;
				}
				continue;
				IL_0492:
				int num14 = -422158820;
				goto IL_0497;
				IL_0478:
				if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1517837461u)))
				{
					goto IL_0492;
				}
				goto IL_068e;
				IL_068e:
				int num15;
				if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1022807051u)))
				{
					num14 = -134737495;
					num15 = num14;
				}
				else
				{
					num14 = -1476033033;
					num15 = num14;
				}
				goto IL_0497;
				IL_0497:
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num14 ^ -41154371)) % 18)
					{
					case 17u:
						break;
					case 12u:
					{
						int num20;
						int num21;
						if (array.Length >= 2)
						{
							num20 = 1848234097;
							num21 = num20;
						}
						else
						{
							num20 = 955558524;
							num21 = num20;
						}
						num14 = num20 ^ ((int)num2 * -456075655);
						continue;
					}
					case 5u:
					{
						int num24;
						int num25;
						if (!_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(role.EquippedTitle.Name, aoyiCondition.value))
						{
							num24 = 237602471;
							num25 = num24;
						}
						else
						{
							num24 = 949214553;
							num25 = num24;
						}
						num14 = num24 ^ (int)(num2 * 778070985);
						continue;
					}
					case 7u:
					{
						array2 = _206F_206F_206D_200D_200C_202C_200E_202C_202B_200D_206D_202D_200E_200F_200C_200E_202E_202E_206B_200B_206B_206D_202E_200B_202B_206D_202E_206E_206F_206D_200B_206F_200D_206B_206B_200F_202D_200F_206D_206F_202E(aoyiCondition.value, new char[1] { ',' });
						int num28;
						int num29;
						if (array2.Length >= 2)
						{
							num28 = 116261205;
							num29 = num28;
						}
						else
						{
							num28 = 1089699701;
							num29 = num28;
						}
						num14 = num28 ^ ((int)num2 * -1660971735);
						continue;
					}
					case 8u:
						goto IL_0587;
					case 11u:
					{
						int num26;
						int num27;
						if (role.AttributesFinal[array2[0]] >= int.Parse(array2[1]))
						{
							num26 = 1812382306;
							num27 = num26;
						}
						else
						{
							num26 = 362088374;
							num27 = num26;
						}
						num14 = num26 ^ (int)(num2 * 1949754150);
						continue;
					}
					case 1u:
					{
						int num18;
						int num19;
						if (role.EquippedTitle == null)
						{
							num18 = -1827642296;
							num19 = num18;
						}
						else
						{
							num18 = -1910129846;
							num19 = num18;
						}
						num14 = num18 ^ ((int)num2 * -759562848);
						continue;
					}
					case 4u:
						array = _206F_206F_206D_200D_200C_202C_200E_202C_202B_200D_206D_202D_200E_200F_200C_200E_202E_202E_206B_200B_206B_206D_202E_200B_202B_206D_202E_206E_206F_206D_200B_206F_200D_206B_206B_200F_202D_200F_206D_206F_202E(aoyiCondition.value, new char[1] { ',' });
						num14 = (int)(num2 * 1366607436) ^ -873962639;
						continue;
					case 13u:
						return true;
					case 3u:
						return true;
					case 0u:
						goto IL_0663;
					case 10u:
						goto IL_068e;
					case 16u:
						return true;
					case 14u:
						return true;
					case 6u:
					{
						int num22;
						int num23;
						if (role.Level < int.Parse(aoyiCondition.value))
						{
							num22 = 419045528;
							num23 = num22;
						}
						else
						{
							num22 = 1331633985;
							num23 = num22;
						}
						num14 = num22 ^ ((int)num2 * -439726164);
						continue;
					}
					case 2u:
					{
						int num16;
						int num17;
						if (role.Attributes[array[0]] < int.Parse(array[1]))
						{
							num16 = -162359008;
							num17 = num16;
						}
						else
						{
							num16 = -1319014709;
							num17 = num16;
						}
						num14 = num16 ^ (int)(num2 * 1241489035);
						continue;
					}
					case 9u:
						goto end_IL_0010;
					default:
						return result;
					}
					break;
					IL_0663:
					int num30;
					if (!_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1209570335u)))
					{
						num14 = -1619253784;
						num30 = num14;
					}
					else
					{
						num14 = -1374765848;
						num30 = num14;
					}
					continue;
					IL_0587:
					int num31;
					if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2377236142u)))
					{
						num14 = -1508138441;
						num31 = num14;
					}
					else
					{
						num14 = -760991469;
						num31 = num14;
					}
				}
				goto IL_0492;
				continue;
				end_IL_0010:
				break;
			}
		}
		return false;
	}

	private static bool GetChangeToAoyiResult2(Role role, AoyiCondition aoyiCondition)
	{
		if (!_206D_206C_202B_202E_200C_202E_202D_202C_202E_206A_202B_206F_206C_206E_202B_200C_206E_206F_200E_206F_200B_200B_200F_200B_206F_206C_200E_202E_206B_206D_206F_206C_200E_202B_200C_200E_200C_202A_200D_202B_202E(aoyiCondition.value))
		{
			string[] array = default(string[]);
			string[] array2 = default(string[]);
			bool result = default(bool);
			while (true)
			{
				int num = 1075694126;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x5410C54)) % 23)
					{
					case 5u:
						break;
					case 1u:
						goto IL_0087;
					case 8u:
						return true;
					case 4u:
						return true;
					case 11u:
						goto IL_00d5;
					case 12u:
						return true;
					case 15u:
						return true;
					case 6u:
						goto IL_0129;
					case 0u:
						goto IL_0154;
					case 9u:
						goto IL_0178;
					case 7u:
						return true;
					case 14u:
						goto IL_01b1;
					case 2u:
						goto IL_01dc;
					case 3u:
					{
						int num3;
						int num4;
						if (!_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1798426973u)))
						{
							num3 = -1021399910;
							num4 = num3;
						}
						else
						{
							num3 = -1300159931;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 1419095242);
						continue;
					}
					case 21u:
						goto IL_0234;
					case 17u:
						return true;
					case 13u:
						goto IL_0274;
					case 18u:
						goto IL_029e;
					case 20u:
						goto IL_02c9;
					case 19u:
						return true;
					case 16u:
						goto IL_0302;
					case 22u:
						goto IL_032d;
					default:
						goto IL_0358;
					}
					break;
					IL_032d:
					int num5;
					if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4179893029u)))
					{
						num = 1816659080;
						num5 = num;
					}
					else
					{
						num = 434508291;
						num5 = num;
					}
					continue;
					IL_0234:
					int num6;
					if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3693182192u)))
					{
						num = 163104971;
						num6 = num;
					}
					else
					{
						num = 493515289;
						num6 = num;
					}
					continue;
					IL_0178:
					if (!role.HasRoleTalent(aoyiCondition.value))
					{
						goto end_IL_0010;
					}
					num = (int)(num2 * 387644146) ^ -2144964293;
					continue;
					IL_0302:
					int num7;
					if (!_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3198126615u)))
					{
						num = 706456968;
						num7 = num;
					}
					else
					{
						num = 1984795247;
						num7 = num;
					}
					continue;
					IL_00d5:
					if (role.GetInternalSkillLevel(aoyiCondition.value) < aoyiCondition.level)
					{
						goto end_IL_0010;
					}
					num = (int)((num2 * 626069379) ^ 0x212B0C74);
					continue;
					IL_01dc:
					if (role.GetSpecialSkill(aoyiCondition.value) == null)
					{
						goto end_IL_0010;
					}
					num = ((int)num2 * -962624785) ^ -723806004;
					continue;
					IL_02c9:
					if (!role.HasTalent(aoyiCondition.value))
					{
						goto end_IL_0010;
					}
					num = (int)((num2 * 1853976822) ^ 0x75A3EC7E);
					continue;
					IL_0154:
					if (!role.HasEquipmentTalent(aoyiCondition.value))
					{
						goto end_IL_0010;
					}
					num = (int)((num2 * 1853705484) ^ 0x40784DD5);
					continue;
					IL_029e:
					int num8;
					if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(764267077u)))
					{
						num = 1997465184;
						num8 = num;
					}
					else
					{
						num = 440680016;
						num8 = num;
					}
					continue;
					IL_01b1:
					int num9;
					if (!_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(387622895u)))
					{
						num = 1406429361;
						num9 = num;
					}
					else
					{
						num = 1208547590;
						num9 = num;
					}
					continue;
					IL_0087:
					if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1812516200u)))
					{
						num = 1747264092;
						continue;
					}
					goto IL_0416;
					IL_0274:
					if (role.GetSkillLevel(aoyiCondition.value) < aoyiCondition.level)
					{
						goto end_IL_0010;
					}
					num = ((int)num2 * -1576268501) ^ -475613751;
					continue;
					IL_0129:
					int num10;
					if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4293099508u)))
					{
						num = 531439315;
						num10 = num;
					}
					else
					{
						num = 1617121481;
						num10 = num;
					}
				}
				continue;
				IL_0435:
				int num11;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num11 ^ 0x5410C54)) % 18)
					{
					case 13u:
						break;
					case 5u:
						return true;
					case 14u:
					{
						int num24;
						int num25;
						if (array.Length >= 2)
						{
							num24 = -799142551;
							num25 = num24;
						}
						else
						{
							num24 = -272098384;
							num25 = num24;
						}
						num11 = num24 ^ (int)(num2 * 435649660);
						continue;
					}
					case 10u:
					{
						int num16;
						int num17;
						if (role.EquippedTitle == null)
						{
							num16 = 450311676;
							num17 = num16;
						}
						else
						{
							num16 = 298965972;
							num17 = num16;
						}
						num11 = num16 ^ ((int)num2 * -2147444693);
						continue;
					}
					case 9u:
						goto IL_04ed;
					case 12u:
						return true;
					case 4u:
					{
						array2 = _206F_206F_206D_200D_200C_202C_200E_202C_202B_200D_206D_202D_200E_200F_200C_200E_202E_202E_206B_200B_206B_206D_202E_200B_202B_206D_202E_206E_206F_206D_200B_206F_200D_206B_206B_200F_202D_200F_206D_206F_202E(aoyiCondition.value, new char[1] { ',' });
						int num22;
						int num23;
						if (array2.Length < 2)
						{
							num22 = -1627328484;
							num23 = num22;
						}
						else
						{
							num22 = -1282313397;
							num23 = num22;
						}
						num11 = num22 ^ (int)(num2 * 1931975335);
						continue;
					}
					case 16u:
						goto end_IL_0010;
					case 17u:
						goto IL_0573;
					case 0u:
						array = _206F_206F_206D_200D_200C_202C_200E_202C_202B_200D_206D_202D_200E_200F_200C_200E_202E_202E_206B_200B_206B_206D_202E_200B_202B_206D_202E_206E_206F_206D_200B_206F_200D_206B_206B_200F_202D_200F_206D_206F_202E(aoyiCondition.value, new char[1] { ',' });
						num11 = (int)(num2 * 89089177) ^ -751435332;
						continue;
					case 1u:
						return true;
					case 8u:
					{
						int num14;
						int num15;
						if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(role.EquippedTitle.Name, aoyiCondition.value))
						{
							num14 = 122365001;
							num15 = num14;
						}
						else
						{
							num14 = 1332768192;
							num15 = num14;
						}
						num11 = num14 ^ ((int)num2 * -1164670236);
						continue;
					}
					case 11u:
						return true;
					case 2u:
						goto IL_0627;
					case 7u:
					{
						int num20;
						int num21;
						if (role.AttributesFinal[array2[0]] < int.Parse(array2[1]))
						{
							num20 = -658141105;
							num21 = num20;
						}
						else
						{
							num20 = -1952725880;
							num21 = num20;
						}
						num11 = num20 ^ (int)(num2 * 1872373509);
						continue;
					}
					case 15u:
					{
						int num18;
						int num19;
						if (role.Attributes[array[0]] >= int.Parse(array[1]))
						{
							num18 = -1355003438;
							num19 = num18;
						}
						else
						{
							num18 = -1902198462;
							num19 = num18;
						}
						num11 = num18 ^ ((int)num2 * -565413734);
						continue;
					}
					case 3u:
					{
						int num12;
						int num13;
						if (role.Level < int.Parse(aoyiCondition.value))
						{
							num12 = 875598141;
							num13 = num12;
						}
						else
						{
							num12 = 456408076;
							num13 = num12;
						}
						num11 = num12 ^ (int)(num2 * 1214017099);
						continue;
					}
					default:
						goto IL_06ec;
					}
					break;
					IL_0627:
					int num26;
					if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(413222635u)))
					{
						num11 = 1115324128;
						num26 = num11;
					}
					else
					{
						num11 = 255126384;
						num26 = num11;
					}
					continue;
					IL_0573:
					int num27;
					if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2723001403u)))
					{
						num11 = 511705260;
						num27 = num11;
					}
					else
					{
						num11 = 798765462;
						num27 = num11;
					}
				}
				goto IL_0430;
				IL_0358:
				using (List<ItemInstance>.Enumerator enumerator = role.Equipment.GetEnumerator())
				{
					while (true)
					{
						IL_03bc:
						int num28;
						int num29;
						if (!enumerator.MoveNext())
						{
							num28 = 1658597331;
							num29 = num28;
						}
						else
						{
							num28 = 2035743351;
							num29 = num28;
						}
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num28 ^ 0x5410C54)) % 6)
							{
							case 4u:
								num28 = 2035743351;
								continue;
							default:
								goto end_IL_036b;
							case 0u:
								result = true;
								num28 = ((int)num2 * -841381706) ^ 0x2BEF3DE8;
								continue;
							case 3u:
								break;
							case 5u:
							{
								int num30;
								if (!_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(enumerator.Current.Name, aoyiCondition.value))
								{
									num28 = 992586079;
									num30 = num28;
								}
								else
								{
									num28 = 957857790;
									num30 = num28;
								}
								continue;
							}
							case 1u:
								goto end_IL_036b;
							case 2u:
								goto IL_06ec;
							}
							goto IL_03bc;
							continue;
							end_IL_036b:
							break;
						}
						break;
					}
				}
				break;
				IL_0416:
				if (_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1517837461u)))
				{
					goto IL_0430;
				}
				goto IL_04ed;
				IL_04ed:
				int num31;
				if (!_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(aoyiCondition.type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1537375957u)))
				{
					num11 = 1293173445;
					num31 = num11;
				}
				else
				{
					num11 = 196114067;
					num31 = num11;
				}
				goto IL_0435;
				IL_06ec:
				return result;
				IL_0430:
				num11 = 728475120;
				goto IL_0435;
				continue;
				end_IL_0010:
				break;
			}
		}
		return false;
	}

	internal static List<Aoyi> GetAoyis(Role role, SkillBox currentSkill)
	{
		List<Aoyi> list = new List<Aoyi>();
		IEnumerator<Aoyi> enumerator = ResourceManager.GetAll<Aoyi>().GetEnumerator();
		try
		{
			bool flag2 = default(bool);
			bool flag = default(bool);
			string[] array = default(string[]);
			int num5 = default(int);
			string[] array2 = default(string[]);
			string[] array3 = default(string[]);
			AoyiCondition current2 = default(AoyiCondition);
			while (_200E_200E_206B_206A_206B_202E_200F_206D_206B_206E_202B_202C_206C_206C_200C_206D_202E_202D_200F_202E_206C_206A_202B_200B_200C_206B_206F_206F_206E_202E_202A_200D_202E_200C_206D_206E_200C_200D_206A_202E((IEnumerator)enumerator))
			{
				while (true)
				{
					Aoyi current = enumerator.Current;
					int num = -333205315;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -1559090347)) % 5)
						{
						case 3u:
							num = -1968759777;
							continue;
						case 1u:
							break;
						case 0u:
							goto IL_004f;
						case 4u:
							goto IL_0075;
						default:
							goto IL_0096;
						}
						break;
						IL_0096:
						using (List<AoyiCondition>.Enumerator enumerator2 = current.Conditions.GetEnumerator())
						{
							while (true)
							{
								IL_04a5:
								int num3;
								int num4;
								if (!enumerator2.MoveNext())
								{
									num3 = -631460090;
									num4 = num3;
								}
								else
								{
									num3 = -2079481238;
									num4 = num3;
								}
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ -1559090347)) % 27)
									{
									case 2u:
										num3 = -2079481238;
										continue;
									default:
										goto end_IL_00ac;
									case 10u:
										flag2 = flag;
										num3 = ((int)num2 * -1486636643) ^ 0x5E16E98B;
										continue;
									case 1u:
									{
										AoyiCondition aoyiCondition2 = new AoyiCondition
										{
											type = array[num5],
											value = array2[num5],
											levelValue = array3[num5]
										};
										flag = GetChangeToAoyiResult2(currentSkill.Owner, aoyiCondition2);
										int num19;
										if (!flag)
										{
											num3 = -955481233;
											num19 = num3;
										}
										else
										{
											num3 = -1053476168;
											num19 = num3;
										}
										continue;
									}
									case 16u:
										num5 = 0;
										num3 = ((int)num2 * -1027015973) ^ 0x7B639100;
										continue;
									case 9u:
										num3 = (int)(num2 * 2086258466) ^ -492398455;
										continue;
									case 5u:
									{
										int num10;
										int num11;
										if (list.Contains(current))
										{
											num10 = 1986675805;
											num11 = num10;
										}
										else
										{
											num10 = 1173111973;
											num11 = num10;
										}
										num3 = num10 ^ ((int)num2 * -36294754);
										continue;
									}
									case 14u:
										num3 = ((int)num2 * -1229177009) ^ 0x35F750F;
										continue;
									case 21u:
										current2 = enumerator2.Current;
										flag2 = false;
										num3 = -698873404;
										continue;
									case 25u:
									{
										int num22;
										if (!_202D_202D_200E_206B_200D_202A_200C_200C_200F_200D_206B_206B_200E_202B_200B_202A_202A_206A_202C_200E_200D_200C_200C_202B_206B_200D_200D_200F_202A_202E_200B_200E_200D_202C_206D_206F_200C_200C_200F_202A_202E(current2.type, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2651523886u)))
										{
											num3 = -1364236117;
											num22 = num3;
										}
										else
										{
											num3 = -347256989;
											num22 = num3;
										}
										continue;
									}
									case 22u:
									{
										int num15;
										int num16;
										if (array2.Length != array3.Length)
										{
											num15 = 1846306719;
											num16 = num15;
										}
										else
										{
											num15 = 1826083320;
											num16 = num15;
										}
										num3 = num15 ^ ((int)num2 * -1057139653);
										continue;
									}
									case 7u:
									{
										int num12;
										int num13;
										if (!_202E_206F_206D_206D_206B_202A_200F_202B_202C_200D_206A_200E_206C_200E_206E_200D_206A_206A_206B_206A_206D_200C_206D_200D_206C_206D_202C_206A_206B_206F_206A_200E_202B_202E_206C_206A_200F_206E_202A_206F_202E(current2.type, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3997850031u)))
										{
											num12 = -250561069;
											num13 = num12;
										}
										else
										{
											num12 = -1336476791;
											num13 = num12;
										}
										num3 = num12 ^ ((int)num2 * -428074165);
										continue;
									}
									case 17u:
									{
										AoyiCondition aoyiCondition = new AoyiCondition
										{
											type = _206E_200B_206C_206C_202C_206E_200C_202D_206F_202B_202E_200D_202D_200E_200E_206D_206F_200E_200D_206B_206E_206C_206F_202A_206E_202D_206B_206A_200D_202A_206C_206E_202C_206F_200D_202E_200E_200F_200F_206E_202E(array[num5], 1, _206F_200E_206A_200C_206A_200F_200C_200C_206E_200F_200D_206B_206B_202C_202E_200C_206F_202C_200F_206E_206E_206A_206B_200B_206A_200E_206D_206B_200F_202C_202E_202C_200E_206A_200B_206E_206C_200E_200E_200D_202E(array[num5]) - 1),
											value = array2[num5],
											levelValue = array3[num5]
										};
										flag = !GetChangeToAoyiResult2(currentSkill.Owner, aoyiCondition);
										num3 = ((int)num2 * -1291187780) ^ 0x291E9314;
										continue;
									}
									case 8u:
										current2.type = _206E_200B_206C_206C_202C_206E_200C_202D_206F_202B_202E_200D_202D_200E_200E_206D_206F_200E_200D_206B_206E_206C_206F_202A_206E_202D_206B_206A_200D_202A_206C_206E_202C_206F_200D_202E_200E_200F_200F_206E_202E(current2.type, 1, _206F_200E_206A_200C_206A_200F_200C_200C_206E_200F_200D_206B_206B_202C_202E_200C_206F_202C_200F_206E_206E_206A_206B_200B_206A_200E_206D_206B_200F_202C_202E_202C_200E_206A_200B_206E_206C_200E_200E_200D_202E(current2.type) - 1);
										flag2 = !GetChangeToAoyiResult2(currentSkill.Owner, current2);
										num3 = ((int)num2 * -2079821047) ^ 0xB20A534;
										continue;
									case 13u:
										flag2 = GetChangeToAoyiResult2(currentSkill.Owner, current2);
										num3 = -1450726702;
										continue;
									case 23u:
										num5++;
										num3 = -261831265;
										continue;
									case 20u:
										array = _206F_206F_206D_200D_200C_202C_200E_202C_202B_200D_206D_202D_200E_200F_200C_200E_202E_202E_206B_200B_206B_206D_202E_200B_202B_206D_202E_206E_206F_206D_200B_206F_200D_206B_206B_200F_202D_200F_206D_206F_202E(current2.type, new char[1] { '|' });
										array2 = _206F_206F_206D_200D_200C_202C_200E_202C_202B_200D_206D_202D_200E_200F_200C_200E_202E_202E_206B_200B_206B_206D_202E_200B_202B_206D_202E_206E_206F_206D_200B_206F_200D_206B_206B_200F_202D_200F_206D_206F_202E(current2.value, new char[1] { '|' });
										array3 = _206F_206F_206D_200D_200C_202C_200E_202C_202B_200D_206D_202D_200E_200F_200C_200E_202E_202E_206B_200B_206B_206D_202E_200B_202B_206D_202E_206E_206F_206D_200B_206F_200D_206B_206B_200F_202D_200F_206D_206F_202E(current2.levelValue, new char[1] { '|' });
										num3 = ((int)num2 * -282040021) ^ 0x5FA210C3;
										continue;
									case 6u:
									{
										int num20;
										int num21;
										if (flag)
										{
											num20 = 684351265;
											num21 = num20;
										}
										else
										{
											num20 = 218756847;
											num21 = num20;
										}
										num3 = num20 ^ (int)(num2 * 402111872);
										continue;
									}
									case 0u:
									{
										int num17;
										int num18;
										if (array.Length == array2.Length)
										{
											num17 = 1333461144;
											num18 = num17;
										}
										else
										{
											num17 = 1469936904;
											num18 = num17;
										}
										num3 = num17 ^ (int)(num2 * 515798574);
										continue;
									}
									case 15u:
										num3 = ((int)num2 * -373632711) ^ 0x2B79FB78;
										continue;
									case 24u:
										flag2 = flag;
										num3 = ((int)num2 * -206297225) ^ -344703037;
										continue;
									case 11u:
									{
										int num14;
										if (num5 < array.Length)
										{
											num3 = -881150191;
											num14 = num3;
										}
										else
										{
											num3 = -566499258;
											num14 = num3;
										}
										continue;
									}
									case 26u:
									{
										int num8;
										int num9;
										if (array.Length > 1)
										{
											num8 = -1003027457;
											num9 = num8;
										}
										else
										{
											num8 = -1780293390;
											num9 = num8;
										}
										num3 = num8 ^ ((int)num2 * -1217312785);
										continue;
									}
									case 19u:
										list.Add(current);
										num3 = (int)(num2 * 1503250446) ^ -1465729073;
										continue;
									case 12u:
									{
										int num7;
										if (flag2)
										{
											num3 = -1002108888;
											num7 = num3;
										}
										else
										{
											num3 = -1935434117;
											num7 = num3;
										}
										continue;
									}
									case 4u:
										break;
									case 3u:
									{
										flag = false;
										int num6;
										if (!_202D_202D_200E_206B_200D_202A_200C_200C_200F_200D_206B_206B_200E_202B_200B_202A_202A_206A_202C_200E_200D_200C_200C_202B_206B_200D_200D_200F_202A_202E_200B_200E_200D_202C_206D_206F_200C_200C_200F_202A_202E(array[num5], global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(887725519u)))
										{
											num3 = -1380220990;
											num6 = num3;
										}
										else
										{
											num3 = -436869335;
											num6 = num3;
										}
										continue;
									}
									case 18u:
										goto end_IL_00ac;
									}
									goto IL_04a5;
									continue;
									end_IL_00ac:
									break;
								}
								break;
							}
						}
						goto end_IL_0041;
						IL_0075:
						if (currentSkill.Level < current.level)
						{
							goto end_IL_0041;
						}
						num = (int)((num2 * 554709863) ^ 0x4F981B72);
						continue;
						IL_004f:
						if (!_206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(currentSkill.Name, current.start))
						{
							goto end_IL_0041;
						}
						num = ((int)num2 * -1975917000) ^ 0x106B0CB6;
					}
					continue;
					end_IL_0041:
					break;
				}
			}
			return list;
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_050f:
					int num23 = -207420760;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num23 ^ -1559090347)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_0514;
						case 2u:
							goto IL_0532;
						case 1u:
							goto end_IL_0514;
						}
						goto IL_050f;
						IL_0532:
						_200E_200B_200E_202B_206D_206F_206A_200C_206C_200B_206F_206F_200D_206F_206C_206B_202E_206E_200E_200E_202B_202A_206A_200C_202B_206D_200E_200F_202B_202E_206A_206C_200F_200F_206C_206F_202A_200E_200D_200C_202E((IDisposable)enumerator);
						num23 = (int)(num2 * 494468234) ^ -2100032533;
						continue;
						end_IL_0514:
						break;
					}
					break;
				}
			}
		}
	}

	static bool _206C_202C_206B_202C_200F_202A_206B_206D_206C_202E_202E_206C_206F_206A_206C_206E_200D_206F_206A_202B_206C_200F_206B_206A_200C_202C_206A_200F_206D_200F_202D_206F_200B_200C_206B_202A_200D_202B_206B_206F_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static int _202C_206C_206D_206A_200F_206D_202D_200B_206E_200C_200B_200C_202C_206E_206D_206F_200C_202E_200D_206D_206C_200D_202D_200D_200C_200B_200F_200D_202B_202B_202B_206E_202B_202D_202C_200F_206E_200F_206A_202D_202E(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	static bool _202E_206F_206D_206D_206B_202A_200F_202B_202C_200D_206A_200E_206C_200E_206E_200D_206A_206A_206B_206A_206D_200C_206D_200D_206C_206D_202C_206A_206B_206F_206A_200E_202B_202E_206C_206A_200F_206E_202A_206F_202E(string P_0, string P_1)
	{
		return P_0.Contains(P_1);
	}

	static string[] _206F_206F_206D_200D_200C_202C_200E_202C_202B_200D_206D_202D_200E_200F_200C_200E_202E_202E_206B_200B_206B_206D_202E_200B_202B_206D_202E_206E_206F_206D_200B_206F_200D_206B_206B_200F_202D_200F_206D_206F_202E(string P_0, char[] P_1)
	{
		return P_0.Split(P_1);
	}

	static bool _202D_202D_200E_206B_200D_202A_200C_200C_200F_200D_206B_206B_200E_202B_200B_202A_202A_206A_202C_200E_200D_200C_200C_202B_206B_200D_200D_200F_202A_202E_200B_200E_200D_202C_206D_206F_200C_200C_200F_202A_202E(string P_0, string P_1)
	{
		return P_0.StartsWith(P_1);
	}

	static int _206F_200E_206A_200C_206A_200F_200C_200C_206E_200F_200D_206B_206B_202C_202E_200C_206F_202C_200F_206E_206E_206A_206B_200B_206A_200E_206D_206B_200F_202C_202E_202C_200E_206A_200B_206E_206C_200E_200E_200D_202E(string P_0)
	{
		return P_0.Length;
	}

	static string _206E_200B_206C_206C_202C_206E_200C_202D_206F_202B_202E_200D_202D_200E_200E_206D_206F_200E_200D_206B_206E_206C_206F_202A_206E_202D_206B_206A_200D_202A_206C_206E_202C_206F_200D_202E_200E_200F_200F_206E_202E(string P_0, int P_1, int P_2)
	{
		return P_0.Substring(P_1, P_2);
	}

	static bool _200E_200E_206B_206A_206B_202E_200F_206D_206B_206E_202B_202C_206C_206C_200C_206D_202E_202D_200F_202E_206C_206A_202B_200B_200C_206B_206F_206F_206E_202E_202A_200D_202E_200C_206D_206E_200C_200D_206A_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _200E_200B_200E_202B_206D_206F_206A_200C_206C_200B_206F_206F_200D_206F_206C_206B_202E_206E_200E_200E_202B_202A_206A_200C_202B_206D_200E_200F_202B_202E_206A_206C_200F_200F_206C_206F_202A_200E_200D_200C_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static bool _206D_206C_202B_202E_200C_202E_202D_202C_202E_206A_202B_206F_206C_206E_202B_200C_206E_206F_200E_206F_200B_200B_200F_200B_206F_206C_200E_202E_206B_206D_206F_206C_200E_202B_200C_200E_200C_202A_200D_202B_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static int _200E_202E_202E_206B_206C_202E_206D_202E_200B_202A_206A_206B_202D_200D_202B_202D_206F_200D_206F_206B_200C_202B_200E_200C_206A_206F_206B_200C_202E_202C_200B_200E_200D_202A_200C_200F_200D_202D_202B_202B_202E(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}
}
