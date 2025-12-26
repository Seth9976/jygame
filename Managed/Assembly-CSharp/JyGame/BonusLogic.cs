using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JyGame;

public class BonusLogic
{
	private Battle _200B_200D_206A_206C_206D_202D_206D_202E_202B_206E_200E_202D_206B_202C_202B_202A_200E_200B_202B_202D_206C_206F_202B_202A_200B_206F_200E_202A_200F_206C_200E_206F_200D_200D_200F_202A_206F_206B_202C_202C_202E;

	public int Yuanbao;

	public int Money;

	public List<ItemInstance> Items = new List<ItemInstance>();

	public int Exp;

	public BonusLogic(Battle P_0)
	{
		_200B_200D_206A_206C_206D_202D_206D_202E_202B_206E_200E_202D_206B_202C_202B_202A_200E_200B_202B_202D_206C_206F_202B_202A_200B_206F_200E_202A_200F_206C_200E_206F_200D_200D_200F_202A_206F_206B_202C_202C_202E = P_0;
		CalcMoney();
		CalcItems();
		CalcExp();
		CalcYuanbao();
		CalcFinal();
	}

	private void CalcYuanbao()
	{
		if (RuntimeData.Instance.gameEngine.battleType == BattleType.Zhenlongqiju)
		{
			goto IL_0012;
		}
		goto IL_005e;
		IL_0012:
		int num = 318098593;
		goto IL_0017;
		IL_0017:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x6D699F6E)) % 6)
			{
			case 2u:
				break;
			default:
				return;
			case 3u:
				Yuanbao = ModData.ZhenlongqijuLevel / 2 + 1;
				num = (int)((num2 * 2099068145) ^ 0x323CD2A5);
				continue;
			case 1u:
				goto IL_005e;
			case 5u:
				Yuanbao = 1;
				num = ((int)num2 * -297515023) ^ -1730232485;
				continue;
			case 0u:
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_0012;
		IL_005e:
		int num3;
		if (!Tools.ProbabilityTest(CommonSettings.YUANBAO_DROP_RATE))
		{
			num = 1878047550;
			num3 = num;
		}
		else
		{
			num = 1955662043;
			num3 = num;
		}
		goto IL_0017;
	}

	private void CalcMoney()
	{
		Money = 0;
		int num8 = default(int);
		BattleRole current = default(BattleRole);
		while (true)
		{
			int num = -636253426;
			while (true)
			{
				int num12;
				uint num2;
				int num9;
				int num11;
				switch ((num2 = (uint)(num ^ -180999289)) % 4)
				{
				case 2u:
					break;
				case 1u:
				{
					int num13;
					if (_200B_200D_206A_206C_206D_202D_206D_202E_202B_206E_200E_202D_206B_202C_202B_202A_200E_200B_202B_202D_206C_206F_202B_202A_200B_206F_200E_202A_200F_206C_200E_206F_200D_200D_200F_202A_206F_206B_202C_202C_202E.Bonus)
					{
						num12 = 1575918517;
						num13 = num12;
					}
					else
					{
						num12 = 116186742;
						num13 = num12;
					}
					goto IL_0049;
				}
				case 3u:
					return;
				default:
					{
						using (List<BattleRole>.Enumerator enumerator = _200B_200D_206A_206C_206D_202D_206D_202E_202B_206E_200E_202D_206B_202C_202B_202A_200E_200B_202B_202D_206C_206F_202B_202A_200B_206F_200E_202A_200F_206C_200E_206F_200D_200D_200F_202A_206F_206B_202C_202C_202E.Roles.GetEnumerator())
						{
							while (true)
							{
								IL_00ab:
								int num3;
								int num4;
								if (!enumerator.MoveNext())
								{
									num3 = -420041790;
									num4 = num3;
								}
								else
								{
									num3 = -2112790583;
									num4 = num3;
								}
								while (true)
								{
									int num7;
									int num6;
									switch ((num2 = (uint)(num3 ^ -180999289)) % 6)
									{
									case 0u:
										num3 = -2112790583;
										continue;
									default:
										goto end_IL_007e;
									case 1u:
										break;
									case 5u:
										num8 = _200D_206C_202A_202C_200E_206D_200D_202A_202B_202E_202A_206A_206A_202D_206E_202D_202E_206C_200B_202C_200C_202B_202A_206F_206A_206A_206B_200D_202A_206A_206A_200F_206F_206B_200E_206B_206D_202B_202D_206B_202E(60, current.role.Level);
										if (!current.IsBoss)
										{
											num3 = ((int)num2 * -1100563) ^ 0x6DFF5C44;
											continue;
										}
										num7 = (int)_206A_206B_206F_202E_206B_202C_200B_206E_200B_206A_202D_200D_200D_206B_200E_206E_206E_200F_200D_206C_200B_200B_200D_202D_206C_202A_200C_202A_200E_206B_200C_200F_200B_202B_206B_206B_206F_206B_206F_200D_202E(1.23, (double)num8);
										goto IL_0114;
									case 2u:
										num7 = (int)_206A_206B_206F_202E_206B_202C_200B_206E_200B_206A_202D_200D_200D_206B_200E_206E_206E_200F_200D_206C_200B_200B_200D_202D_206C_202A_200C_202A_200E_206B_200C_200F_200B_202B_206B_206B_206F_206B_206F_200D_202E(1.2, (double)num8);
										goto IL_0114;
									case 4u:
									{
										current = enumerator.Current;
										int num5;
										if (current.Team == 1)
										{
											num3 = -1186206170;
											num5 = num3;
										}
										else
										{
											num3 = -1812834706;
											num5 = num3;
										}
										continue;
									}
									case 3u:
										goto end_IL_007e;
										IL_0114:
										num6 = num7;
										Money += num6;
										num3 = -1186206170;
										continue;
									}
									goto IL_00ab;
									continue;
									end_IL_007e:
									break;
								}
								break;
							}
						}
						if (Money < 0)
						{
							goto IL_016e;
						}
						goto IL_0206;
					}
					IL_0173:
					while (true)
					{
						switch ((num2 = (uint)(num9 ^ -180999289)) % 9)
						{
						case 5u:
							break;
						default:
							return;
						case 2u:
							goto IL_01ad;
						case 7u:
							Money++;
							num9 = ((int)num2 * -515316729) ^ 0x5EDBAFE3;
							continue;
						case 3u:
							Money = 20000;
							return;
						case 4u:
							goto IL_0206;
						case 6u:
							Money = 10;
							num9 = (int)(num2 * 137682274) ^ -1439490716;
							continue;
						case 8u:
							_202C_206B_202C_202B_206B_202A_206A_200D_202A_206B_206A_206F_206B_202D_200C_200C_206E_200D_206D_200F_202C_206C_206D_206F_206C_206E_206A_206C_202A_200D_200F_200F_206D_206D_200C_200C_206A_200E_200B_200F_202E((object)global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(693103522u));
							num9 = ((int)num2 * -1419824274) ^ 0x57CFD305;
							continue;
						case 0u:
							return;
						case 1u:
							return;
						}
						break;
						IL_01ad:
						int num10;
						if (Money % 2 == 1)
						{
							num9 = -1045870933;
							num10 = num9;
						}
						else
						{
							num9 = -1825799209;
							num10 = num9;
						}
					}
					goto IL_016e;
					IL_0206:
					if (Money < 10)
					{
						num9 = -1737841667;
						num11 = num9;
					}
					else
					{
						num9 = -180305298;
						num11 = num9;
					}
					goto IL_0173;
					IL_016e:
					num9 = -679890660;
					goto IL_0173;
				}
				break;
				IL_0049:
				num = num12 ^ (int)(num2 * 144227206);
			}
		}
	}

	private void CalcItems()
	{
		Items.Clear();
		if (RuntimeData.Instance.gameEngine.battleType == BattleType.Zhenlongqiju)
		{
			goto IL_0020;
		}
		goto IL_01ce;
		IL_0020:
		int num = -98377748;
		goto IL_0025;
		IL_0025:
		double num82 = default(double);
		int round = default(int);
		float num22 = default(float);
		int num44 = default(int);
		float num45 = default(float);
		bool flag = default(bool);
		BattleRole current = default(BattleRole);
		List<Item> list = default(List<Item>);
		Role role = default(Role);
		Item current2 = default(Item);
		double num15 = default(double);
		bool flag2 = default(bool);
		Skill skill = default(Skill);
		int num19 = default(int);
		InternalSkill internalSkill = default(InternalSkill);
		bool flag3 = default(bool);
		InternalSkill random2 = default(InternalSkill);
		int num29 = default(int);
		Skill random = default(Skill);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1221424558)) % 15)
			{
			case 11u:
				break;
			case 8u:
				ZhenlongqijuLogic.CalcItems(Items);
				num = (int)((num2 * 787791093) ^ 0x21892F9);
				continue;
			case 6u:
				num82 = LuaManager.GetConfigDouble(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2940352967u)) + (double)(round - 1) * LuaManager.GetConfigDouble(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4265649544u));
				num = ((int)num2 * -1122036361) ^ 0x34D2D51C;
				continue;
			case 13u:
				return;
			case 0u:
				return;
			case 12u:
			{
				int num97;
				int num98;
				if (!_200D_202E_200E_200B_202D_202C_202D_206F_206F_206D_202B_200F_202D_206F_200C_206B_206D_202C_200D_202D_200D_206D_206A_206D_202E_202C_206A_200B_202E_202C_202A_202A_200C_202C_200E_206D_202D_200D_202A_202A_202E(RuntimeData.Instance.GameMode, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1073497403u)))
				{
					num97 = 597812708;
					num98 = num97;
				}
				else
				{
					num97 = 950350962;
					num98 = num97;
				}
				num = num97 ^ (int)(num2 * 1952655959);
				continue;
			}
			case 2u:
				num22 = _202E_200B_202B_202D_202C_202C_202C_206E_200E_202C_200F_206E_206E_206D_202E_202E_202D_202A_202E_206C_206D_206E_202A_202E_200E_206A_206B_200C_206E_200B_206D_206E_206A_202A_202D_206C_200B_202D_206C_202E_202E(3f, (float)LuaManager.GetConfigInt(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2224899712u)));
				num = -1768032430;
				continue;
			case 1u:
				round = RuntimeData.Instance.Round;
				num44 = 0;
				num82 = 0.0;
				num = -141211866;
				continue;
			case 14u:
				goto IL_0170;
			case 3u:
				num45 = _202E_200B_202B_202D_202C_202C_202C_206E_200E_202C_200F_206E_206E_206D_202E_202E_202D_202A_202E_206C_206D_206E_202A_202E_200E_206A_206B_200C_206E_200B_206D_206E_206A_202A_202D_206C_200B_202D_206C_202E_202E(3f, (float)LuaManager.GetConfigInt(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(68158742u)));
				num = ((int)num2 * -1454327170) ^ -984122554;
				continue;
			case 4u:
				goto IL_01ce;
			case 9u:
				num = (int)((num2 * 509483845) ^ 0x572ECAAA);
				continue;
			case 10u:
				flag = RuntimeData.Instance.gameEngine.battleType != BattleType.Tower;
				num = (int)(num2 * 2083851756) ^ -281336904;
				continue;
			case 7u:
				num82 = LuaManager.GetConfigDouble(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1772193791u));
				num = ((int)num2 * -1431926119) ^ -1506369677;
				continue;
			default:
			{
				using List<BattleRole>.Enumerator enumerator = _200B_200D_206A_206C_206D_202D_206D_202E_202B_206E_200E_202D_206B_202C_202B_202A_200E_200B_202B_202D_206C_206F_202B_202A_200B_206F_200E_202A_200F_206C_200E_206F_200D_200D_200F_202A_206F_206B_202C_202C_202E.Roles.GetEnumerator();
				while (true)
				{
					IL_066f:
					if (enumerator.MoveNext())
					{
						while (true)
						{
							current = enumerator.Current;
							int num3 = -1852492340;
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ -1221424558)) % 6)
								{
								case 0u:
									num3 = -1112366897;
									continue;
								case 1u:
									break;
								case 5u:
									goto IL_02a5;
								case 2u:
									goto IL_02cb;
								case 3u:
									list = new List<Item>();
									num3 = (int)(num2 * 188965621) ^ -227972030;
									continue;
								default:
									goto IL_0302;
								}
								break;
								IL_0302:
								int num4 = _200D_206C_202A_202C_200E_206D_200D_202A_202B_202E_202A_206A_206A_202D_206E_202D_202E_206C_200B_202C_200C_202B_202A_206F_206A_206A_206B_200D_202A_206A_206A_200F_206F_206B_200E_206B_206D_202B_202D_206B_202E(490, role.Level);
								IEnumerator<Item> enumerator2 = ResourceManager.GetAll<Item>().GetEnumerator();
								try
								{
									while (true)
									{
										IL_03dc:
										int num5;
										int num6;
										if (!_200E_202E_206A_202C_206E_206D_200E_200B_200E_200B_202C_202A_206F_200B_200C_202E_206D_202A_206F_206F_200B_200D_200E_206E_200E_206A_206C_200D_200B_200E_206D_206D_200E_200B_206F_206C_202B_200C_206B_206F_202E((IEnumerator)enumerator2))
										{
											num5 = -1441164960;
											num6 = num5;
										}
										else
										{
											num5 = -1861270954;
											num6 = num5;
										}
										while (true)
										{
											switch ((num2 = (uint)(num5 ^ -1221424558)) % 8)
											{
											case 0u:
												num5 = -1861270954;
												continue;
											default:
												goto end_IL_032b;
											case 4u:
												current2 = enumerator2.Current;
												num5 = -413837684;
												continue;
											case 3u:
												list.Add(current2);
												num5 = (int)(num2 * 1294150969) ^ -330255586;
												continue;
											case 5u:
											{
												int num9;
												int num10;
												if (current2.round < round)
												{
													num9 = 1065324908;
													num10 = num9;
												}
												else
												{
													num9 = 1969739416;
													num10 = num9;
												}
												num5 = num9 ^ (int)(num2 * 1751203909);
												continue;
											}
											case 1u:
											{
												int num11;
												int num12;
												if (num4 >= (current2.level - 1) * 5)
												{
													num11 = 2085259036;
													num12 = num11;
												}
												else
												{
													num11 = 371819054;
													num12 = num11;
												}
												num5 = num11 ^ ((int)num2 * -4021141);
												continue;
											}
											case 7u:
												break;
											case 6u:
											{
												int num7;
												int num8;
												if (!current2.drop)
												{
													num7 = 1343625137;
													num8 = num7;
												}
												else
												{
													num7 = 2113604679;
													num8 = num7;
												}
												num5 = num7 ^ (int)(num2 * 1912964386);
												continue;
											}
											case 2u:
												goto end_IL_032b;
											}
											goto IL_03dc;
											continue;
											end_IL_032b:
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
											IL_0425:
											int num13 = -473751427;
											while (true)
											{
												switch ((num2 = (uint)(num13 ^ -1221424558)) % 3)
												{
												case 0u:
													break;
												default:
													goto end_IL_042a;
												case 2u:
													goto IL_0448;
												case 1u:
													goto end_IL_042a;
												}
												goto IL_0425;
												IL_0448:
												_206A_202C_206C_202B_206C_202E_200B_202B_200D_200E_202B_206B_206C_202B_200B_206B_200C_206D_202D_200C_200D_202B_202C_206E_206B_202A_200C_202A_202C_200B_202C_202E_206A_200C_206E_206A_202A_206F_206F_202E_202E((IDisposable)enumerator2);
												num13 = ((int)num2 * -579067205) ^ -796743826;
												continue;
												end_IL_042a:
												break;
											}
											break;
										}
									}
								}
								goto end_IL_0295;
								IL_02cb:
								if (current.Team != 1)
								{
									num3 = (int)((num2 * 1741365646) ^ 0x33536D6B);
									continue;
								}
								goto IL_066f;
								IL_02a5:
								role = current.role;
								if (!(role != null && flag))
								{
									goto end_IL_0295;
								}
								num3 = (int)((num2 * 802527664) ^ 0xF7DAD0C);
							}
							continue;
							end_IL_0295:
							break;
						}
						if (list.Count > 0)
						{
							goto IL_046d;
						}
						goto IL_05de;
					}
					int num14 = -134575798;
					goto IL_0472;
					IL_05de:
					num15 = 2.0;
					int num16;
					if (role == null)
					{
						num14 = -1219718825;
						num16 = num14;
					}
					else
					{
						num14 = -698314717;
						num16 = num14;
					}
					goto IL_0472;
					IL_0472:
					while (true)
					{
						switch ((num2 = (uint)(num14 ^ -1221424558)) % 80)
						{
						case 46u:
							break;
						default:
							return;
						case 77u:
							flag2 = true;
							num14 = (int)(num2 * 1763521550) ^ -1991839746;
							continue;
						case 41u:
							goto IL_05de;
						case 17u:
						{
							int num68;
							int num69;
							if (num15 <= 99.99)
							{
								num68 = -408061063;
								num69 = num68;
							}
							else
							{
								num68 = -681640750;
								num69 = num68;
							}
							num14 = num68 ^ (int)(num2 * 1658278414);
							continue;
						}
						case 64u:
						{
							int num54;
							int num55;
							if (skill.Hard >= 100f)
							{
								num54 = 2010211791;
								num55 = num54;
							}
							else
							{
								num54 = 2035609623;
								num55 = num54;
							}
							num14 = num54 ^ (int)(num2 * 1435345804);
							continue;
						}
						case 28u:
							num19++;
							num14 = ((int)num2 * -504178774) ^ -1641656674;
							continue;
						case 36u:
							goto IL_066f;
						case 26u:
							num14 = ((int)num2 * -1320280680) ^ -92623331;
							continue;
						case 45u:
						{
							int num74;
							int num75;
							if (Tools.ProbabilityTest(0.1 + BattleField.fjtl_percent))
							{
								num74 = 1047143622;
								num75 = num74;
							}
							else
							{
								num74 = 1128574242;
								num75 = num74;
							}
							num14 = num74 ^ ((int)num2 * -329978355);
							continue;
						}
						case 21u:
						{
							int num42;
							int num43;
							if (internalSkill.Hard < 100f)
							{
								num42 = -659903323;
								num43 = num42;
							}
							else
							{
								num42 = -1796329757;
								num43 = num42;
							}
							num14 = num42 ^ (int)(num2 * 2086171397);
							continue;
						}
						case 78u:
							flag2 = true;
							num14 = ((int)num2 * -124219457) ^ 0x2B4D7AB9;
							continue;
						case 14u:
							num15 = _200B_206B_206B_200B_206B_206E_202C_200B_202D_200F_206B_202C_200C_206C_200B_202A_206A_202D_206C_202B_206D_202C_206B_206F_202B_206A_206D_200F_206F_206D_202A_206B_206B_200D_202B_202A_202E_206D_200E_202E_202E((double)BattleField.ROLE_MAX_LEVEL[role] + 0.99, 99.99);
							num14 = -1219718825;
							continue;
						case 8u:
							flag3 = true;
							num14 = ((int)num2 * -437895967) ^ 0x12DC6C05;
							continue;
						case 79u:
							goto IL_0753;
						case 35u:
							flag3 = true;
							num14 = ((int)num2 * -1380317337) ^ -287938712;
							continue;
						case 40u:
							num14 = (int)((num2 * 1624679953) ^ 0x5A1589DF);
							continue;
						case 57u:
							internalSkill = null;
							num19 = 0;
							num14 = (int)(num2 * 544841620) ^ -1522733742;
							continue;
						case 12u:
						{
							int num62;
							int num63;
							if (skill != null)
							{
								num62 = 711888834;
								num63 = num62;
							}
							else
							{
								num62 = 1580171455;
								num63 = num62;
							}
							num14 = num62 ^ ((int)num2 * -1501135164);
							continue;
						}
						case 22u:
						{
							int num64;
							int num65;
							if (skill.Hard < 3f)
							{
								num64 = 1787537478;
								num65 = num64;
							}
							else
							{
								num64 = 69684652;
								num65 = num64;
							}
							num14 = num64 ^ (int)(num2 * 19502752);
							continue;
						}
						case 66u:
							Items.Add(Item.GetCanzhang(_200B_200B_200C_200E_202E_202B_200C_202E_200E_200E_200F_200F_206F_202B_202A_206D_200D_202D_202E_202B_200E_206B_202D_202B_202C_202B_206D_202D_206B_206A_206D_200C_206B_206D_202B_202E_200F_202B_206E_206F_202E(random2.Name, ResourceStrings.ResStrings[331])).Generate(setRandomTrigger: false));
							num14 = (int)(num2 * 248822631) ^ -1981010564;
							continue;
						case 24u:
							flag3 = true;
							num14 = ((int)num2 * -926999097) ^ -889992624;
							continue;
						case 18u:
							skill = ResourceManager.GetRandom<Skill>();
							num14 = -453401000;
							continue;
						case 53u:
							goto IL_0870;
						case 34u:
							num44++;
							num14 = ((int)num2 * -222074797) ^ 0x7B353C0C;
							continue;
						case 3u:
						{
							int num32;
							int num33;
							if (role.Level < BattleField.ROLE_MAX_LEVEL[role])
							{
								num32 = -1372633242;
								num33 = num32;
							}
							else
							{
								num32 = -198032199;
								num33 = num32;
							}
							num14 = num32 ^ (int)(num2 * 1650226439);
							continue;
						}
						case 50u:
						{
							int num27;
							int num28;
							if (!((double)skill.Hard < num15))
							{
								num27 = 1674583465;
								num28 = num27;
							}
							else
							{
								num27 = 109427719;
								num28 = num27;
							}
							num14 = num27 ^ ((int)num2 * -1862874819);
							continue;
						}
						case 33u:
							num15 += (double)role.Level / 3.0;
							num14 = (int)((num2 * 1027060803) ^ 0x312B8292);
							continue;
						case 0u:
						{
							int num72;
							int num73;
							if (!((double)internalSkill.Hard < num15))
							{
								num72 = -1163088665;
								num73 = num72;
							}
							else
							{
								num72 = -1499543905;
								num73 = num72;
							}
							num14 = num72 ^ (int)(num2 * 1289552874);
							continue;
						}
						case 43u:
							flag2 = true;
							num14 = ((int)num2 * -299193967) ^ 0x121C26E3;
							continue;
						case 38u:
							return;
						case 44u:
							goto IL_0985;
						case 19u:
							num29++;
							num14 = (int)((num2 * 132839543) ^ 0x12C15AA2);
							continue;
						case 11u:
						{
							int num60;
							int num61;
							if (role.Level >= 10)
							{
								num60 = -1663291073;
								num61 = num60;
							}
							else
							{
								num60 = -1818329604;
								num61 = num60;
							}
							num14 = num60 ^ ((int)num2 * -1744535482);
							continue;
						}
						case 31u:
						{
							int num56;
							int num57;
							if (Tools.ProbabilityTest(0.6))
							{
								num56 = -1122570350;
								num57 = num56;
							}
							else
							{
								num56 = -135708799;
								num57 = num56;
							}
							num14 = num56 ^ (int)(num2 * 957828278);
							continue;
						}
						case 30u:
							Items.Add(Item.GetCanzhang(_200B_200B_200C_200E_202E_202B_200C_202E_200E_200E_200F_200F_206F_202B_202A_206D_200D_202D_202E_202B_200E_206B_202D_202B_202C_202B_206D_202D_206B_206A_206D_200C_206B_206D_202B_202E_200F_202B_206E_206F_202E(internalSkill.Name, ResourceStrings.ResStrings[331])).Generate(setRandomTrigger: false));
							num14 = ((int)num2 * -975202623) ^ -2033540338;
							continue;
						case 7u:
							goto IL_0a56;
						case 27u:
							Items.Add(Item.GetCanzhang(_200B_200B_200C_200E_202E_202B_200C_202E_200E_200E_200F_200F_206F_202B_202A_206D_200D_202D_202E_202B_200E_206B_202D_202B_202C_202B_206D_202D_206B_206A_206D_200C_206B_206D_202B_202E_200F_202B_206E_206F_202E(random.Name, ResourceStrings.ResStrings[331])).Generate(setRandomTrigger: false));
							num14 = ((int)num2 * -46582993) ^ -1889339449;
							continue;
						case 42u:
							goto IL_0ab9;
						case 71u:
						{
							int num48;
							int num49;
							if (role.Level < 10)
							{
								num48 = 1542365798;
								num49 = num48;
							}
							else
							{
								num48 = 1637797860;
								num49 = num48;
							}
							num14 = num48 ^ (int)(num2 * 1477393184);
							continue;
						}
						case 73u:
							num14 = (int)(num2 * 694657759) ^ -296056257;
							continue;
						case 10u:
						{
							flag2 = false;
							int num38;
							int num39;
							if (skill.Hard < 100f)
							{
								num38 = -2131447017;
								num39 = num38;
							}
							else
							{
								num38 = -1060303785;
								num39 = num38;
							}
							num14 = num38 ^ (int)(num2 * 316698114);
							continue;
						}
						case 60u:
						{
							int num34;
							int num35;
							if (skill.Hard >= _200C_206C_202A_202A_202E_202A_200D_200F_206C_206B_202C_200F_206C_200F_206B_200C_202C_202D_200B_202A_200D_206A_202E_200C_202D_206B_200F_206F_202B_202C_200D_202A_200F_206A_206C_200B_200B_206A_202A_200C_202E(num22, 5f))
							{
								num34 = -1675331067;
								num35 = num34;
							}
							else
							{
								num34 = -940148138;
								num35 = num34;
							}
							num14 = num34 ^ (int)(num2 * 722583320);
							continue;
						}
						case 65u:
							skill = null;
							num14 = -133177183;
							continue;
						case 15u:
							goto IL_0b78;
						case 39u:
							flag2 = true;
							num14 = (int)((num2 * 675980517) ^ 0x4D034AFB);
							continue;
						case 29u:
							goto IL_0ba6;
						case 52u:
							goto IL_0bca;
						case 62u:
						{
							int num23;
							int num24;
							if (skill.Hard >= num22)
							{
								num23 = -85934013;
								num24 = num23;
							}
							else
							{
								num23 = -1396086176;
								num24 = num23;
							}
							num14 = num23 ^ ((int)num2 * -994505728);
							continue;
						}
						case 32u:
						{
							int num76;
							int num77;
							if (internalSkill.Hard < num45)
							{
								num76 = 299200290;
								num77 = num76;
							}
							else
							{
								num76 = 1158590855;
								num77 = num76;
							}
							num14 = num76 ^ ((int)num2 * -819614346);
							continue;
						}
						case 59u:
						{
							int num70;
							int num71;
							if (internalSkill.Hard < _200C_206C_202A_202A_202E_202A_200D_200F_206C_206B_202C_200F_206C_200F_206B_200C_202C_202D_200B_202A_200D_206A_202E_200C_202D_206B_200F_206F_202B_202C_200D_202A_200F_206A_206C_200B_200B_206A_202A_200C_202E(num45, 5f))
							{
								num70 = 349898236;
								num71 = num70;
							}
							else
							{
								num70 = 101733416;
								num71 = num70;
							}
							num14 = num70 ^ (int)(num2 * 470897131);
							continue;
						}
						case 68u:
						{
							int num66;
							int num67;
							if (role.Level < 30)
							{
								num66 = -1523526214;
								num67 = num66;
							}
							else
							{
								num66 = -219991190;
								num67 = num66;
							}
							num14 = num66 ^ ((int)num2 * -1678904806);
							continue;
						}
						case 55u:
						{
							int num58;
							int num59;
							if (skill.Hard <= 3f)
							{
								num58 = -1316487024;
								num59 = num58;
							}
							else
							{
								num58 = -1884413839;
								num59 = num58;
							}
							num14 = num58 ^ ((int)num2 * -632070881);
							continue;
						}
						case 25u:
							random2 = ResourceManager.GetRandom<InternalSkill>();
							num14 = -1829689931;
							continue;
						case 72u:
							goto IL_0cce;
						case 51u:
						{
							int num52;
							int num53;
							if (internalSkill.Hard <= 3f)
							{
								num52 = 2068664727;
								num53 = num52;
							}
							else
							{
								num52 = 1793073939;
								num53 = num52;
							}
							num14 = num52 ^ (int)(num2 * 1289225130);
							continue;
						}
						case 76u:
							goto IL_0d16;
						case 48u:
							goto IL_0d42;
						case 54u:
						{
							int num50;
							int num51;
							if (random.Hard >= num22)
							{
								num50 = 291281334;
								num51 = num50;
							}
							else
							{
								num50 = 295486832;
								num51 = num50;
							}
							num14 = num50 ^ (int)(num2 * 1149094278);
							continue;
						}
						case 75u:
							flag3 = true;
							num14 = (int)((num2 * 549019838) ^ 0x3819BEA7);
							continue;
						case 37u:
							goto IL_0d98;
						case 61u:
							Items.Add(list[Tools.GetRandomInt(0, list.Count - 1)].Generate(setRandomTrigger: true));
							num14 = (int)(num2 * 455137007) ^ -1865282920;
							continue;
						case 16u:
							goto IL_0def;
						case 20u:
							goto IL_0e1e;
						case 74u:
							random = ResourceManager.GetRandom<Skill>();
							num14 = ((int)num2 * -1557877678) ^ 0x47DB6860;
							continue;
						case 13u:
							goto IL_0e55;
						case 23u:
						{
							int num46;
							int num47;
							if (random2.Hard < num45)
							{
								num46 = -1696460444;
								num47 = num46;
							}
							else
							{
								num46 = -133709118;
								num47 = num46;
							}
							num14 = num46 ^ (int)(num2 * 307607728);
							continue;
						}
						case 5u:
							Items.Add(Item.GetCanzhang(_200B_200B_200C_200E_202E_202B_200C_202E_200E_200E_200F_200F_206F_202B_202A_206D_200D_202D_202E_202B_200E_206B_202D_202B_202C_202B_206D_202D_206B_206A_206D_200C_206B_206D_202B_202E_200F_202B_206E_206F_202E(skill.Name, ResourceStrings.ResStrings[331])).Generate(setRandomTrigger: false));
							num44++;
							num14 = ((int)num2 * -2094383479) ^ 0x5EFEEC22;
							continue;
						case 6u:
						{
							int num40;
							int num41;
							if (random2.Hard < 100f)
							{
								num40 = 335283476;
								num41 = num40;
							}
							else
							{
								num40 = 1910374198;
								num41 = num40;
							}
							num14 = num40 ^ ((int)num2 * -1412387674);
							continue;
						}
						case 1u:
						{
							int num36;
							int num37;
							if (role == null)
							{
								num36 = -264463714;
								num37 = num36;
							}
							else
							{
								num36 = -1916775015;
								num37 = num36;
							}
							num14 = num36 ^ ((int)num2 * -1048047919);
							continue;
						}
						case 9u:
							skill = null;
							num14 = (int)((num2 * 1304852484) ^ 0x6C9E0717);
							continue;
						case 70u:
						{
							int num30;
							int num31;
							if (random.Hard < 100f)
							{
								num30 = -425015481;
								num31 = num30;
							}
							else
							{
								num30 = -770313924;
								num31 = num30;
							}
							num14 = num30 ^ ((int)num2 * -1430726115);
							continue;
						}
						case 49u:
							num29 = 0;
							num14 = ((int)num2 * -741606935) ^ -1266975533;
							continue;
						case 4u:
							goto IL_0f9a;
						case 47u:
						{
							int num25;
							int num26;
							if (internalSkill.Hard >= 3f)
							{
								num25 = 520454552;
								num26 = num25;
							}
							else
							{
								num25 = 39011228;
								num26 = num25;
							}
							num14 = num25 ^ ((int)num2 * -458857250);
							continue;
						}
						case 63u:
						{
							int num20;
							int num21;
							if (internalSkill != null)
							{
								num20 = 2065113839;
								num21 = num20;
							}
							else
							{
								num20 = 1043903938;
								num21 = num20;
							}
							num14 = num20 ^ ((int)num2 * -556971864);
							continue;
						}
						case 2u:
							goto IL_1005;
						case 69u:
							internalSkill = null;
							num14 = -720424610;
							continue;
						case 67u:
						{
							int num17;
							int num18;
							if (role != null)
							{
								num17 = 1535350128;
								num18 = num17;
							}
							else
							{
								num17 = 204699194;
								num18 = num17;
							}
							num14 = num17 ^ ((int)num2 * -1432497408);
							continue;
						}
						case 58u:
							goto IL_1052;
						case 56u:
							return;
						}
						break;
						IL_1052:
						int num78;
						if (role.Level >= 20)
						{
							num14 = -1767356370;
							num78 = num14;
						}
						else
						{
							num14 = -1674656266;
							num78 = num14;
						}
						continue;
						IL_0d98:
						int num79;
						if (num29 < 400)
						{
							num14 = -1100601008;
							num79 = num14;
						}
						else
						{
							num14 = -1797649939;
							num79 = num14;
						}
						continue;
						IL_0bca:
						int num80;
						if (role.Level < 10)
						{
							num14 = -1478294475;
							num80 = num14;
						}
						else
						{
							num14 = -2077325048;
							num80 = num14;
						}
						continue;
						IL_1005:
						int num81;
						if (role.Level >= 20)
						{
							num14 = -422370999;
							num81 = num14;
						}
						else
						{
							num14 = -154298059;
							num81 = num14;
						}
						continue;
						IL_0870:
						int num83;
						if (Tools.ProbabilityTest(num82 + BattleField.fjtl_percent))
						{
							num14 = -336080085;
							num83 = num14;
						}
						else
						{
							num14 = -630759089;
							num83 = num14;
						}
						continue;
						IL_0d42:
						int num84;
						if (num44 < 10)
						{
							num14 = -875014858;
							num84 = num14;
						}
						else
						{
							num14 = -28385564;
							num84 = num14;
						}
						continue;
						IL_0f9a:
						int num85;
						if (role.Level >= 20)
						{
							num14 = -1337855610;
							num85 = num14;
						}
						else
						{
							num14 = -169205915;
							num85 = num14;
						}
						continue;
						IL_0ab9:
						int num86;
						if (flag2)
						{
							num14 = -1483646388;
							num86 = num14;
						}
						else
						{
							num14 = -242243517;
							num86 = num14;
						}
						continue;
						IL_0ba6:
						int num87;
						if (!Tools.ProbabilityTest(0.99))
						{
							num14 = -1979457126;
							num87 = num14;
						}
						else
						{
							num14 = -943397043;
							num87 = num14;
						}
						continue;
						IL_0e55:
						int num88;
						if (Tools.ProbabilityTest(num82 / LuaManager.GetConfigDouble(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(310301685u)) + BattleField.fjtl_percent))
						{
							num14 = -1243854885;
							num88 = num14;
						}
						else
						{
							num14 = -1979457126;
							num88 = num14;
						}
						continue;
						IL_0d16:
						internalSkill = ResourceManager.GetRandom<InternalSkill>();
						flag3 = false;
						int num89;
						if (internalSkill.Hard >= 100f)
						{
							num14 = -1866463609;
							num89 = num14;
						}
						else
						{
							num14 = -294957567;
							num89 = num14;
						}
						continue;
						IL_0753:
						int num90;
						if (Tools.ProbabilityTest(0.99))
						{
							num14 = -564022930;
							num90 = num14;
						}
						else
						{
							num14 = -630759089;
							num90 = num14;
						}
						continue;
						IL_0e1e:
						int num91;
						if (num19 >= 400)
						{
							num14 = -1930269441;
							num91 = num14;
						}
						else
						{
							num14 = -2055987746;
							num91 = num14;
						}
						continue;
						IL_0985:
						int num92;
						if (role.Level >= 10)
						{
							num14 = -1171137427;
							num92 = num14;
						}
						else
						{
							num14 = -502433007;
							num92 = num14;
						}
						continue;
						IL_0cce:
						int num93;
						if (!current.IsBoss)
						{
							num14 = -490218122;
							num93 = num14;
						}
						else
						{
							num14 = -310521150;
							num93 = num14;
						}
						continue;
						IL_0def:
						int num94;
						if (Tools.ProbabilityTest(num82 + (double)role.Level * 0.002))
						{
							num14 = -1550550627;
							num94 = num14;
						}
						else
						{
							num14 = -1162988526;
							num94 = num14;
						}
						continue;
						IL_0b78:
						int num95;
						if (flag3)
						{
							num14 = -1618636590;
							num95 = num14;
						}
						else
						{
							num14 = -1866463609;
							num95 = num14;
						}
						continue;
						IL_0a56:
						int num96;
						if (role.Level >= 20)
						{
							num14 = -549756258;
							num96 = num14;
						}
						else
						{
							num14 = -495235511;
							num96 = num14;
						}
					}
					goto IL_046d;
					IL_046d:
					num14 = -1853149073;
					goto IL_0472;
				}
			}
			}
			break;
			IL_0170:
			int num99;
			if (!_200D_202E_200E_200B_202D_202C_202D_206F_206F_206D_202B_200F_202D_206F_200C_206B_206D_202C_200D_202D_200D_206D_206A_206D_202E_202C_206A_200B_202E_202C_202A_202A_200C_202C_200E_206D_202D_200D_202A_202A_202E(RuntimeData.Instance.GameMode, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2309252705u)))
			{
				num = -170338965;
				num99 = num;
			}
			else
			{
				num = -26106029;
				num99 = num;
			}
		}
		goto IL_0020;
		IL_01ce:
		int num100;
		if (_200B_200D_206A_206C_206D_202D_206D_202E_202B_206E_200E_202D_206B_202C_202B_202A_200E_200B_202B_202D_206C_206F_202B_202A_200B_206F_200E_202A_200F_206C_200E_206F_200D_200D_200F_202A_206F_206B_202C_202C_202E.Bonus)
		{
			num = -2122212869;
			num100 = num;
		}
		else
		{
			num = -682619175;
			num100 = num;
		}
		goto IL_0025;
	}

	private void CalcExp()
	{
		int num = 0;
		int num6 = default(int);
		double num7 = default(double);
		BattleRole current = default(BattleRole);
		while (true)
		{
			int num2 = -792345153;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -417601300)) % 4)
				{
				case 0u:
					break;
				case 3u:
					num6 = 0;
					num2 = ((int)num3 * -529729779) ^ 0x5018ACDA;
					continue;
				case 1u:
					num7 = 0.0;
					num2 = (int)((num3 * 1225599833) ^ 0xAB0605F);
					continue;
				default:
				{
					using (List<BattleRole>.Enumerator enumerator = _200B_200D_206A_206C_206D_202D_206D_202E_202B_206E_200E_202D_206B_202C_202B_202A_200E_200B_202B_202D_206C_206F_202B_202A_200B_206F_200E_202A_200F_206C_200E_206F_200D_200D_200F_202A_206F_206B_202C_202C_202E.Roles.GetEnumerator())
					{
						while (true)
						{
							IL_0185:
							int num4;
							int num5;
							if (enumerator.MoveNext())
							{
								num4 = -735822315;
								num5 = num4;
							}
							else
							{
								num4 = -1094893068;
								num5 = num4;
							}
							while (true)
							{
								switch ((num3 = (uint)(num4 ^ -417601300)) % 11)
								{
								case 5u:
									num4 = -735822315;
									continue;
								default:
									goto end_IL_0071;
								case 0u:
								{
									int num10;
									if (current.IsBoss)
									{
										num4 = -84156346;
										num10 = num4;
									}
									else
									{
										num4 = -171145683;
										num10 = num4;
									}
									continue;
								}
								case 2u:
									num4 = ((int)num3 * -1535376688) ^ -1111297803;
									continue;
								case 3u:
									num++;
									num4 = ((int)num3 * -395057636) ^ 0x4670B74E;
									continue;
								case 10u:
									num7 += (double)current.role.LevelupExp / 15.0;
									num4 = ((int)num3 * -1854606447) ^ 0x1950A14E;
									continue;
								case 8u:
									current = enumerator.Current;
									num4 = -214403800;
									continue;
								case 4u:
								{
									int num8;
									int num9;
									if (current.Team == 1)
									{
										num8 = 1796810058;
										num9 = num8;
									}
									else
									{
										num8 = 1347874940;
										num9 = num8;
									}
									num4 = num8 ^ (int)(num3 * 1758799225);
									continue;
								}
								case 1u:
									num7 += (double)current.role.LevelupExp / 12.0;
									num4 = (int)(num3 * 865728700) ^ -1194664691;
									continue;
								case 9u:
									break;
								case 7u:
									num6++;
									num4 = -1900012665;
									continue;
								case 6u:
									goto end_IL_0071;
								}
								goto IL_0185;
								continue;
								end_IL_0071:
								break;
							}
							break;
						}
					}
					double num11 = num7 / (double)num;
					while (true)
					{
						int num12 = -809663552;
						while (true)
						{
							switch ((num3 = (uint)(num12 ^ -417601300)) % 14)
							{
							case 11u:
								break;
							default:
								return;
							case 9u:
								num12 = (int)((num3 * 1593184858) ^ 0x464D7212);
								continue;
							case 8u:
								num11 *= 1.0 - (double)(num6 - 3) * 0.01;
								num12 = ((int)num3 * -63004969) ^ 0x6C851224;
								continue;
							case 0u:
							{
								Exp = _202E_206A_202C_200F_202D_202B_206D_202E_200C_200B_206B_200D_206A_202A_200D_202C_202B_206C_200E_202A_200D_202E_200C_202D_202C_206A_202E_200E_202A_202E_206C_206F_202E_202E_200C_200B_202D_200D_200F_206D_202E((int)num11);
								int num16;
								if (Exp % 2 == 1)
								{
									num12 = -371046316;
									num16 = num12;
								}
								else
								{
									num12 = -589165343;
									num16 = num12;
								}
								continue;
							}
							case 7u:
								num11 = 2000000.0;
								num12 = ((int)num3 * -1793868176) ^ -165601300;
								continue;
							case 13u:
								num11 *= 1.1;
								num12 = (int)((num3 * 318937671) ^ 0x5DAE2E98);
								continue;
							case 3u:
							{
								int num15;
								if (num11 < 4.0)
								{
									num12 = -1777356348;
									num15 = num12;
								}
								else
								{
									num12 = -1058067230;
									num15 = num12;
								}
								continue;
							}
							case 2u:
							{
								int num18;
								if (num11 > 2000000.0)
								{
									num12 = -383190381;
									num18 = num12;
								}
								else
								{
									num12 = -1637988740;
									num18 = num12;
								}
								continue;
							}
							case 1u:
							{
								int num17;
								if (num6 == 0)
								{
									num12 = -1730494723;
									num17 = num12;
								}
								else
								{
									num12 = -165071313;
									num17 = num12;
								}
								continue;
							}
							case 6u:
								Exp++;
								num12 = ((int)num3 * -1682791043) ^ -2138563271;
								continue;
							case 12u:
								num12 = ((int)num3 * -439608949) ^ -2016528181;
								continue;
							case 10u:
								num11 = 4.0;
								num12 = (int)(num3 * 1846120945) ^ -1867957961;
								continue;
							case 4u:
							{
								int num13;
								int num14;
								if (num6 <= 3)
								{
									num13 = -130662559;
									num14 = num13;
								}
								else
								{
									num13 = -133701484;
									num14 = num13;
								}
								num12 = num13 ^ (int)(num3 * 1072491251);
								continue;
							}
							case 5u:
								return;
							}
							break;
						}
					}
				}
				}
				break;
			}
		}
	}

	public void Run()
	{
		if (!_200B_200D_206A_206C_206D_202D_206D_202E_202B_206E_200E_202D_206B_202C_202B_202A_200E_200B_202B_202D_206C_206F_202B_202A_200B_206F_200E_202A_200F_206C_200E_206F_200D_200D_200F_202A_206F_206B_202C_202C_202E.Bonus)
		{
			goto IL_000d;
		}
		goto IL_0045;
		IL_000d:
		int num = -878523781;
		goto IL_0012;
		IL_0012:
		int num7 = default(int);
		int exp = default(int);
		int num8;
		uint num2;
		ItemInstance current2 = default(ItemInstance);
		switch ((num2 = (uint)(num ^ -754533994)) % 4)
		{
		case 3u:
			break;
		case 1u:
			return;
		case 2u:
			goto IL_0045;
		default:
			{
				using (List<BattleRole>.Enumerator enumerator = _200B_200D_206A_206C_206D_202D_206D_202E_202B_206E_200E_202D_206B_202C_202B_202A_200E_200B_202B_202D_206C_206F_202B_202A_200B_206F_200E_202A_200F_206C_200E_206F_200D_200D_200F_202A_206F_206B_202C_202C_202E.Roles.GetEnumerator())
				{
					BattleRole current = default(BattleRole);
					while (true)
					{
						IL_00ca:
						int num3;
						int num4;
						if (enumerator.MoveNext())
						{
							num3 = -1731918152;
							num4 = num3;
						}
						else
						{
							num3 = -142691862;
							num4 = num3;
						}
						while (true)
						{
							switch ((num2 = (uint)(num3 ^ -754533994)) % 8)
							{
							case 5u:
								num3 = -1731918152;
								continue;
							default:
								goto end_IL_006d;
							case 0u:
								num7++;
								num3 = -613297407;
								continue;
							case 2u:
								current.role.AddExpBattle(exp);
								num3 = (int)((num2 * 1130469282) ^ 0x4AF488A1);
								continue;
							case 7u:
								break;
							case 6u:
								current = enumerator.Current;
								num3 = -1397803985;
								continue;
							case 3u:
								num3 = (int)((num2 * 633002562) ^ 0x73623967);
								continue;
							case 1u:
							{
								int num5;
								int num6;
								if (current.Team == 1)
								{
									num5 = 365537084;
									num6 = num5;
								}
								else
								{
									num5 = 1054089838;
									num6 = num5;
								}
								num3 = num5 ^ (int)(num2 * 1166423608);
								continue;
							}
							case 4u:
								goto end_IL_006d;
							}
							goto IL_00ca;
							continue;
							end_IL_006d:
							break;
						}
						break;
					}
				}
				if (RuntimeData.Instance.gameEngine.battleType == BattleType.Zhenlongqiju)
				{
					goto IL_0151;
				}
				goto IL_0194;
			}
			IL_0151:
			num8 = -657059985;
			goto IL_0156;
			IL_0194:
			ModData.ParamAdd(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2578060112u), num7);
			num8 = -689026978;
			goto IL_0156;
			IL_0156:
			while (true)
			{
				switch ((num2 = (uint)(num8 ^ -754533994)) % 4)
				{
				case 2u:
					break;
				case 1u:
					ModData.ZhenlongqijuKilled += num7;
					num8 = (int)(num2 * 870916569) ^ -1470101368;
					continue;
				case 3u:
					goto IL_0194;
				default:
				{
					using (List<ItemInstance>.Enumerator enumerator2 = Items.GetEnumerator())
					{
						while (true)
						{
							IL_0212:
							int num9;
							int num10;
							if (enumerator2.MoveNext())
							{
								num9 = -1352568103;
								num10 = num9;
							}
							else
							{
								num9 = -815637084;
								num10 = num9;
							}
							while (true)
							{
								switch ((num2 = (uint)(num9 ^ -754533994)) % 8)
								{
								case 6u:
									num9 = -1352568103;
									continue;
								default:
									goto end_IL_01c0;
								case 0u:
									RuntimeData.Instance.addItem(current2);
									num9 = (int)((num2 * 161561928) ^ 0x7128A6AA);
									continue;
								case 3u:
									break;
								case 7u:
									current2 = enumerator2.Current;
									num9 = -82441317;
									continue;
								case 4u:
									num9 = (int)(num2 * 181894810) ^ -1765800819;
									continue;
								case 1u:
									ModData.AddSkillMaxLevel(current2.CanzhangSkill, 1, string.Empty);
									num9 = -925875051;
									continue;
								case 5u:
								{
									int num11;
									int num12;
									if (current2.Type != ItemType.Canzhang)
									{
										num11 = -1286049091;
										num12 = num11;
									}
									else
									{
										num11 = -90630236;
										num12 = num11;
									}
									num9 = num11 ^ (int)(num2 * 1390123511);
									continue;
								}
								case 2u:
									goto end_IL_01c0;
								}
								goto IL_0212;
								continue;
								end_IL_01c0:
								break;
							}
							break;
						}
					}
					RuntimeData.Instance.Money += Money;
					RuntimeData.Instance.Yuanbao += Yuanbao;
					return;
				}
				}
				break;
			}
			goto IL_0151;
		}
		goto IL_000d;
		IL_0045:
		exp = Exp;
		num7 = 0;
		num = -1960847674;
		goto IL_0012;
	}

	private int setPercent(int money, string set)
	{
		if (_206B_206C_200F_202E_202B_206F_206C_202E_200F_206E_206B_200B_202C_206A_206C_200F_206D_206A_206A_200B_206B_206E_206F_206B_206E_200D_202B_206A_206D_200F_202C_202D_200C_202C_206E_206D_206E_206C_206C_206A_202E(set))
		{
			while (true)
			{
				uint num;
				switch ((num = 1016702573u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return _202E_206A_202C_200F_202D_202B_206D_202E_200C_200B_206B_200D_206A_202A_200D_202C_202B_206C_200E_202A_200D_202E_200C_202D_202C_206A_202E_200E_202A_202E_206C_206F_202E_202E_200C_200B_202D_200D_200F_206D_202E(money);
				}
				break;
			}
		}
		int result = default(int);
		try
		{
			if (!_206F_206E_202C_206A_200B_202E_202E_200B_202A_202A_200E_202C_206B_200C_202C_200D_202E_200E_202A_206D_200F_202E_206E_206B_206F_200F_206B_206E_206C_206F_206D_206B_200F_200B_206F_200B_202B_206B_200E_202C_202E(set, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(904572443u)))
			{
				goto IL_0056;
			}
			goto IL_013b;
			IL_0056:
			int num2 = 564528642;
			goto IL_005b;
			IL_005b:
			string s = default(string);
			while (true)
			{
				uint num;
				switch ((num = (uint)(num2 ^ 0x2EA1825F)) % 8)
				{
				case 0u:
					break;
				default:
					goto end_IL_0041;
				case 6u:
					result = Math.Max(0, (int)double.Parse(s));
					goto IL_0307;
				case 3u:
				{
					int num7;
					int num8;
					if (!_206F_206E_202C_206A_200B_202E_202E_200B_202A_202A_200E_202C_206B_200C_202C_200D_202E_200E_202A_206D_200F_202E_206E_206B_206F_200F_206B_206E_206C_206F_206D_206B_200F_200B_206F_200B_202B_206B_200E_202C_202E(set, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3826581440u)))
					{
						num7 = -786361595;
						num8 = num7;
					}
					else
					{
						num7 = -1545874592;
						num8 = num7;
					}
					num2 = num7 ^ ((int)num * -380095649);
					continue;
				}
				case 7u:
				{
					int num5;
					int num6;
					if (_206F_206E_202C_206A_200B_202E_202E_200B_202A_202A_200E_202C_206B_200C_202C_200D_202E_200E_202A_206D_200F_202E_206E_206B_206F_200F_206B_206E_206C_206F_206D_206B_200F_200B_206F_200B_202B_206B_200E_202C_202E(set, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3596761859u)))
					{
						num5 = 1088216843;
						num6 = num5;
					}
					else
					{
						num5 = 801240096;
						num6 = num5;
					}
					num2 = num5 ^ ((int)num * -1990675182);
					continue;
				}
				case 5u:
				{
					int num9;
					int num10;
					if (!_206F_206E_202C_206A_200B_202E_202E_200B_202A_202A_200E_202C_206B_200C_202C_200D_202E_200E_202A_206D_200F_202E_206E_206B_206F_200F_206B_206E_206C_206F_206D_206B_200F_200B_206F_200B_202B_206B_200E_202C_202E(set, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3675639468u)))
					{
						num9 = -1290942078;
						num10 = num9;
					}
					else
					{
						num9 = -1530738653;
						num10 = num9;
					}
					num2 = num9 ^ (int)(num * 982090174);
					continue;
				}
				case 2u:
					goto IL_013b;
				case 1u:
				{
					int num3;
					int num4;
					if (_206F_206E_202C_206A_200B_202E_202E_200B_202A_202A_200E_202C_206B_200C_202C_200D_202E_200E_202A_206D_200F_202E_206E_206B_206F_200F_206B_206E_206C_206F_206D_206B_200F_200B_206F_200B_202B_206B_200E_202C_202E(set, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(533767640u)))
					{
						num3 = 586552819;
						num4 = num3;
					}
					else
					{
						num3 = 552225109;
						num4 = num3;
					}
					num2 = num3 ^ ((int)num * -1523595018);
					continue;
				}
				case 4u:
					goto end_IL_0041;
				}
				break;
			}
			goto IL_0056;
			IL_013b:
			s = Tools.Compute(set.Replace(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3341456343u), Money.ToString()).Replace(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3399772948u), Yuanbao.ToString()).Replace(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3425183169u), Exp.ToString())
				.Replace(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3121341046u), RuntimeData.Instance.RoundString()));
			num2 = 1588298321;
			goto IL_005b;
			end_IL_0041:;
		}
		catch
		{
			while (true)
			{
				IL_01e4:
				int num11 = 1693392695;
				while (true)
				{
					uint num;
					switch ((num = (uint)(num11 ^ 0x2EA1825F)) % 3)
					{
					case 0u:
						break;
					case 2u:
						goto IL_0206;
					default:
						goto end_IL_01e9;
					}
					goto IL_01e4;
					IL_0206:
					result = Math.Abs(money);
					num11 = ((int)num * -277898942) ^ 0x78B0CF65;
					continue;
					end_IL_01e9:
					break;
				}
				break;
			}
			goto IL_0307;
		}
		double num12 = 1.0;
		try
		{
			num12 = double.Parse(set);
			while (true)
			{
				IL_0232:
				int num13 = 1171434276;
				while (true)
				{
					uint num;
					switch ((num = (uint)(num13 ^ 0x2EA1825F)) % 7)
					{
					case 2u:
						break;
					default:
						goto end_IL_0237;
					case 5u:
						num13 = ((int)num * -499290300) ^ 0x28634F56;
						continue;
					case 6u:
					{
						int num16;
						if (num12 < 0.0)
						{
							num13 = 1249500229;
							num16 = num13;
						}
						else
						{
							num13 = 1227550138;
							num16 = num13;
						}
						continue;
					}
					case 3u:
						num12 = 0.0;
						num13 = ((int)num * -87636069) ^ 0x2569C204;
						continue;
					case 0u:
						num12 = 1000.0;
						num13 = (int)(num * 1444644965) ^ -987953275;
						continue;
					case 1u:
					{
						int num14;
						int num15;
						if (num12 <= 1000.0)
						{
							num14 = -1059966771;
							num15 = num14;
						}
						else
						{
							num14 = -2039297459;
							num15 = num14;
						}
						num13 = num14 ^ ((int)num * -219749155);
						continue;
					}
					case 4u:
						goto end_IL_0237;
					}
					goto IL_0232;
					continue;
					end_IL_0237:
					break;
				}
				break;
			}
		}
		catch
		{
			result = Math.Abs(money);
			goto IL_0307;
		}
		return Math.Abs((int)((double)money * num12));
		IL_0307:
		return result;
	}

	private void CalcFinal()
	{
		int yuanbao = setPercent(Yuanbao, _200B_200D_206A_206C_206D_202D_206D_202E_202B_206E_200E_202D_206B_202C_202B_202A_200E_200B_202B_202D_206C_206F_202B_202A_200B_206F_200E_202A_200F_206C_200E_206F_200D_200D_200F_202A_206F_206B_202C_202C_202E.SetYuanbao);
		int exp = default(int);
		int money = default(int);
		while (true)
		{
			int num = 282391987;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x50404B00)) % 5)
				{
				case 2u:
					break;
				default:
					return;
				case 4u:
					Exp = exp;
					num = (int)(num2 * 1887281436) ^ -993808414;
					continue;
				case 3u:
					Yuanbao = yuanbao;
					Money = money;
					num = (int)((num2 * 1934138107) ^ 0xE53AABA);
					continue;
				case 1u:
					money = setPercent(Money, _200B_200D_206A_206C_206D_202D_206D_202E_202B_206E_200E_202D_206B_202C_202B_202A_200E_200B_202B_202D_206C_206F_202B_202A_200B_206F_200E_202A_200F_206C_200E_206F_200D_200D_200F_202A_206F_206B_202C_202C_202E.SetMoney);
					exp = setPercent(Exp, _200B_200D_206A_206C_206D_202D_206D_202E_202B_206E_200E_202D_206B_202C_202B_202A_200E_200B_202B_202D_206C_206F_202B_202A_200B_206F_200E_202A_200F_206C_200E_206F_200D_200D_200F_202A_206F_206B_202C_202C_202E.SetExp);
					num = ((int)num2 * -915468511) ^ 0xB50B82D;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	static int _200D_206C_202A_202C_200E_206D_200D_202A_202B_202E_202A_206A_206A_202D_206E_202D_202E_206C_200B_202C_200C_202B_202A_206F_206A_206A_206B_200D_202A_206A_206A_200F_206F_206B_200E_206B_206D_202B_202D_206B_202E(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	static double _206A_206B_206F_202E_206B_202C_200B_206E_200B_206A_202D_200D_200D_206B_200E_206E_206E_200F_200D_206C_200B_200B_200D_202D_206C_202A_200C_202A_200E_206B_200C_200F_200B_202B_206B_206B_206F_206B_206F_200D_202E(double P_0, double P_1)
	{
		return Math.Pow(P_0, P_1);
	}

	static void _202C_206B_202C_202B_206B_202A_206A_200D_202A_206B_206A_206F_206B_202D_200C_200C_206E_200D_206D_200F_202C_206C_206D_206F_206C_206E_206A_206C_202A_200D_200F_200F_206D_206D_200C_200C_206A_200E_200B_200F_202E(object P_0)
	{
		Debug.LogError(P_0);
	}

	static bool _200D_202E_200E_200B_202D_202C_202D_206F_206F_206D_202B_200F_202D_206F_200C_206B_206D_202C_200D_202D_200D_206D_206A_206D_202E_202C_206A_200B_202E_202C_202A_202A_200C_202C_200E_206D_202D_200D_202A_202A_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static float _202E_200B_202B_202D_202C_202C_202C_206E_200E_202C_200F_206E_206E_206D_202E_202E_202D_202A_202E_206C_206D_206E_202A_202E_200E_206A_206B_200C_206E_200B_206D_206E_206A_202A_202D_206C_200B_202D_206C_202E_202E(float P_0, float P_1)
	{
		return Math.Max(P_0, P_1);
	}

	static bool _200E_202E_206A_202C_206E_206D_200E_200B_200E_200B_202C_202A_206F_200B_200C_202E_206D_202A_206F_206F_200B_200D_200E_206E_200E_206A_206C_200D_200B_200E_206D_206D_200E_200B_206F_206C_202B_200C_206B_206F_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _206A_202C_206C_202B_206C_202E_200B_202B_200D_200E_202B_206B_206C_202B_200B_206B_200C_206D_202D_200C_200D_202B_202C_206E_206B_202A_200C_202A_202C_200B_202C_202E_206A_200C_206E_206A_202A_206F_206F_202E_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static double _200B_206B_206B_200B_206B_206E_202C_200B_202D_200F_206B_202C_200C_206C_200B_202A_206A_202D_206C_202B_206D_202C_206B_206F_202B_206A_206D_200F_206F_206D_202A_206B_206B_200D_202B_202A_202E_206D_200E_202E_202E(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	static float _200C_206C_202A_202A_202E_202A_200D_200F_206C_206B_202C_200F_206C_200F_206B_200C_202C_202D_200B_202A_200D_206A_202E_200C_202D_206B_200F_206F_202B_202C_200D_202A_200F_206A_206C_200B_200B_206A_202A_200C_202E(float P_0, float P_1)
	{
		return Math.Min(P_0, P_1);
	}

	static string _200B_200B_200C_200E_202E_202B_200C_202E_200E_200E_200F_200F_206F_202B_202A_206D_200D_202D_202E_202B_200E_206B_202D_202B_202C_202B_206D_202D_206B_206A_206D_200C_206B_206D_202B_202E_200F_202B_206E_206F_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static int _202E_206A_202C_200F_202D_202B_206D_202E_200C_200B_206B_200D_206A_202A_200D_202C_202B_206C_200E_202A_200D_202E_200C_202D_202C_206A_202E_200E_202A_202E_206C_206F_202E_202E_200C_200B_202D_200D_200F_206D_202E(int P_0)
	{
		return Math.Abs(P_0);
	}

	static bool _206B_206C_200F_202E_202B_206F_206C_202E_200F_206E_206B_200B_202C_206A_206C_200F_206D_206A_206A_200B_206B_206E_206F_206B_206E_200D_202B_206A_206D_200F_202C_202D_200C_202C_206E_206D_206E_206C_206C_206A_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static bool _206F_206E_202C_206A_200B_202E_202E_200B_202A_202A_200E_202C_206B_200C_202C_200D_202E_200E_202A_206D_200F_202E_206E_206B_206F_200F_206B_206E_206C_206F_206D_206B_200F_200B_206F_200B_202B_206B_200E_202C_202E(string P_0, string P_1)
	{
		return P_0.Contains(P_1);
	}
}
