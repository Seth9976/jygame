using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JyGame;

public class BattleAI
{
	private BattleField Field;

	private int[] directionX = new int[4] { 1, 0, -1, 0 };

	private int[] directionY = new int[4] { 0, 1, 0, -1 };

	public BattleAI(BattleField P_0)
	{
		while (true)
		{
			int num = -1215729212;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1512019411)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0050;
				case 1u:
					return;
				}
				break;
				IL_0050:
				Field = P_0;
				num = (int)((num2 * 885870259) ^ 0xC6B1C85);
			}
		}
	}

	public List<LocationBlock> GetMoveRange(int x, int y)
	{
		List<LocationBlock> list = new List<LocationBlock>();
		Queue<MoveSearchHelper> queue = default(Queue<MoveSearchHelper>);
		int x2 = default(int);
		int y2 = default(int);
		int cost = default(int);
		bool flag2 = default(bool);
		int moveAbility = default(int);
		bool flag = default(bool);
		LocationBlock current = default(LocationBlock);
		int num17 = default(int);
		int num13 = default(int);
		int num18 = default(int);
		BattleSprite sprite = default(BattleSprite);
		int num12 = default(int);
		int num14 = default(int);
		while (true)
		{
			int num = -164536969;
			while (true)
			{
				int num11;
				uint num2;
				switch ((num2 = (uint)(num ^ -1434786088)) % 9)
				{
				case 0u:
					break;
				case 1u:
					queue = new Queue<MoveSearchHelper>();
					num = (int)(num2 * 1227457789) ^ -1398668990;
					continue;
				case 8u:
				{
					MoveSearchHelper moveSearchHelper = queue.Dequeue();
					x2 = moveSearchHelper.X;
					y2 = moveSearchHelper.Y;
					cost = moveSearchHelper.Cost;
					num = -86509335;
					continue;
				}
				case 4u:
					queue.Enqueue(new MoveSearchHelper
					{
						X = x,
						Y = y,
						Cost = 0
					});
					flag2 = Field.currentSprite.Role.BuiltInTalents[19];
					moveAbility = Field.currentSprite.MoveAbility;
					goto IL_0339;
				case 6u:
				{
					int num9;
					int num10;
					if (!Field.isRemoveBlock(x2, y2))
					{
						num9 = 906046353;
						num10 = num9;
					}
					else
					{
						num9 = 187655410;
						num10 = num9;
					}
					num = num9 ^ (int)(num2 * 746335659);
					continue;
				}
				case 5u:
					flag = true;
					num = ((int)num2 * -465971890) ^ 0x52082510;
					continue;
				case 2u:
					flag = false;
					num = ((int)num2 * -1449250787) ^ 0x44410510;
					continue;
				case 7u:
					if (!flag)
					{
						num = -812912856;
						continue;
					}
					goto IL_024f;
				default:
					{
						using (List<LocationBlock>.Enumerator enumerator = list.GetEnumerator())
						{
							while (true)
							{
								IL_01e7:
								int num3;
								int num4;
								if (enumerator.MoveNext())
								{
									num3 = -487475221;
									num4 = num3;
								}
								else
								{
									num3 = -1237645358;
									num4 = num3;
								}
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ -1434786088)) % 8)
									{
									case 4u:
										num3 = -487475221;
										continue;
									default:
										goto end_IL_0162;
									case 7u:
										goto end_IL_0162;
									case 5u:
										flag = true;
										num3 = (int)((num2 * 711873524) ^ 0x746B96A3);
										continue;
									case 0u:
									{
										int num7;
										int num8;
										if (current.X == x2)
										{
											num7 = 477357185;
											num8 = num7;
										}
										else
										{
											num7 = 1532159390;
											num8 = num7;
										}
										num3 = num7 ^ (int)(num2 * 144962667);
										continue;
									}
									case 6u:
										break;
									case 3u:
										current = enumerator.Current;
										num3 = -31759456;
										continue;
									case 1u:
									{
										int num5;
										int num6;
										if (current.Y == y2)
										{
											num5 = 2126581414;
											num6 = num5;
										}
										else
										{
											num5 = 1410315805;
											num6 = num5;
										}
										num3 = num5 ^ ((int)num2 * -897457701);
										continue;
									}
									case 2u:
										goto end_IL_0162;
									}
									goto IL_01e7;
									continue;
									end_IL_0162:
									break;
								}
								break;
							}
						}
						goto IL_024f;
					}
					IL_024f:
					if (!flag)
					{
						goto IL_0256;
					}
					goto IL_0339;
					IL_0256:
					num11 = -178992985;
					goto IL_025b;
					IL_025b:
					while (true)
					{
						switch ((num2 = (uint)(num11 ^ -1434786088)) % 22)
						{
						case 4u:
							break;
						case 0u:
						{
							int x3 = num17 + directionX[num13];
							int y3 = num18 + directionY[num13];
							sprite = Field.GetSprite(x3, y3);
							num11 = -469614903;
							continue;
						}
						case 7u:
							num18 = y2 + directionY[num12];
							num11 = ((int)num2 * -1810097788) ^ 0x25578EBA;
							continue;
						case 12u:
							num17 = x2 + directionX[num12];
							num11 = -1120399177;
							continue;
						case 2u:
							goto IL_0339;
						case 20u:
							queue.Enqueue(new MoveSearchHelper
							{
								X = num17,
								Y = num18,
								Cost = cost + num14
							});
							num11 = ((int)num2 * -696052847) ^ -1244936786;
							continue;
						case 1u:
						{
							int num21;
							int num22;
							if (!_206E_206D_202B_202E_206D_200F_206B_200B_200C_206E_206F_206E_206C_206C_200F_202E_200F_206E_200E_206C_206A_206B_206F_200C_206A_206D_202A_206F_200C_200E_206C_206D_200B_206F_200F_206E_206E_206D_206F_202C_202E((Object)(object)sprite, (Object)null))
							{
								num21 = 195269902;
								num22 = num21;
							}
							else
							{
								num21 = 345360048;
								num22 = num21;
							}
							num11 = num21 ^ (int)(num2 * 93064253);
							continue;
						}
						case 11u:
							num11 = (int)(num2 * 434417872) ^ -1885741281;
							continue;
						case 19u:
							goto IL_03c2;
						case 18u:
							num11 = (int)((num2 * 1713540444) ^ 0x345ABA8D);
							continue;
						case 15u:
						{
							int num23;
							int num24;
							if (sprite.Team != Field.currentSprite.Team)
							{
								num23 = 1312367535;
								num24 = num23;
							}
							else
							{
								num23 = 1455215578;
								num24 = num23;
							}
							num11 = num23 ^ (int)(num2 * 320336741);
							continue;
						}
						case 3u:
							goto IL_0424;
						case 10u:
						{
							num14 = 1;
							int num19;
							int num20;
							if (!flag2)
							{
								num19 = 1378741214;
								num20 = num19;
							}
							else
							{
								num19 = 1471877095;
								num20 = num19;
							}
							num11 = num19 ^ ((int)num2 * -1101207421);
							continue;
						}
						case 17u:
							num13++;
							num11 = -1465489575;
							continue;
						case 16u:
							num12++;
							num11 = -1965401073;
							continue;
						case 9u:
							goto IL_0487;
						case 6u:
							num14 = 2;
							num11 = ((int)num2 * -14839347) ^ -482658678;
							continue;
						case 5u:
						{
							int num15;
							int num16;
							if (cost + num14 > moveAbility)
							{
								num15 = -175118609;
								num16 = num15;
							}
							else
							{
								num15 = -1740299719;
								num16 = num15;
							}
							num11 = num15 ^ ((int)num2 * -1346099285);
							continue;
						}
						case 14u:
							num13 = 0;
							num11 = ((int)num2 * -377011185) ^ -1658972674;
							continue;
						case 21u:
							list.Add(new LocationBlock
							{
								X = x2,
								Y = y2
							});
							num12 = 0;
							num11 = (int)((num2 * 14894947) ^ 0x14071A70);
							continue;
						case 8u:
							num11 = ((int)num2 * -1703453590) ^ -665029491;
							continue;
						default:
							return list;
						}
						break;
						IL_0487:
						int num25;
						if (num13 < 4)
						{
							num11 = -286327034;
							num25 = num11;
						}
						else
						{
							num11 = -610537475;
							num25 = num11;
						}
						continue;
						IL_0424:
						int num26;
						if (IsEmptyBlock(num17, num18))
						{
							num11 = -149519255;
							num26 = num11;
						}
						else
						{
							num11 = -1921186348;
							num26 = num11;
						}
						continue;
						IL_03c2:
						int num27;
						if (num12 < 4)
						{
							num11 = -1370266110;
							num27 = num11;
						}
						else
						{
							num11 = -877226380;
							num27 = num11;
						}
					}
					goto IL_0256;
					IL_0339:
					if (queue.Count > 0)
					{
						goto case 8u;
					}
					num11 = -851703295;
					goto IL_025b;
				}
				break;
			}
		}
	}

	public bool IsEmptyBlock(int x, int y)
	{
		if (x >= 0)
		{
			while (true)
			{
				int num = -947149668;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -723604242)) % 7)
					{
					case 3u:
						break;
					case 1u:
						return !Field.isRemoveBlock(x, y);
					case 2u:
					{
						int num7;
						int num8;
						if (y >= 0)
						{
							num7 = 106774241;
							num8 = num7;
						}
						else
						{
							num7 = 554664179;
							num8 = num7;
						}
						num = num7 ^ ((int)num2 * -1149020778);
						continue;
					}
					case 5u:
					{
						int num5;
						int num6;
						if (_200B_202B_202D_200C_200F_206B_202C_200C_206C_206E_200D_206C_202B_206A_206E_202A_206F_200C_202C_200C_206A_202C_206B_202A_200C_206A_202B_206A_200C_202C_200C_206E_202A_202A_200C_202A_206D_200F_202A_202A_202E((Object)(object)Field.GetSprite(x, y), (Object)null))
						{
							num5 = -1012608036;
							num6 = num5;
						}
						else
						{
							num5 = -924958272;
							num6 = num5;
						}
						num = num5 ^ (int)(num2 * 1879129);
						continue;
					}
					case 6u:
					{
						int num9;
						int num10;
						if (x < BattleField.MAX_X)
						{
							num9 = -768408071;
							num10 = num9;
						}
						else
						{
							num9 = -724013021;
							num10 = num9;
						}
						num = num9 ^ (int)(num2 * 1249951243);
						continue;
					}
					case 0u:
					{
						int num3;
						int num4;
						if (y >= BattleField.MAX_Y)
						{
							num3 = 1914929889;
							num4 = num3;
						}
						else
						{
							num3 = 2015402567;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 828353348);
						continue;
					}
					default:
						goto end_IL_0007;
					}
					break;
				}
				continue;
				end_IL_0007:
				break;
			}
		}
		return false;
	}

	public List<MoveSearchHelper> GetWay(int x, int y, int ex, int ey, bool ignoreSpirits = true)
	{
		if (x == ex)
		{
			goto IL_0007;
		}
		goto IL_0497;
		IL_0007:
		int num = -1996683679;
		goto IL_000c;
		IL_000c:
		int num12 = default(int);
		bool[,] array = default(bool[,]);
		int num6 = default(int);
		int num15 = default(int);
		int mAX_X = default(int);
		int mAX_Y = default(int);
		int num9 = default(int);
		int num3 = default(int);
		Queue<MoveSearchHelper> queue = default(Queue<MoveSearchHelper>);
		MoveSearchHelper moveSearchHelper = default(MoveSearchHelper);
		List<MoveSearchHelper> list = default(List<MoveSearchHelper>);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -115413712)) % 40)
			{
			case 7u:
				break;
			case 17u:
				num12++;
				num = ((int)num2 * -1715400502) ^ -461814296;
				continue;
			case 3u:
				array[num12, num6] = false;
				num = -686754740;
				continue;
			case 18u:
				goto IL_00f0;
			case 30u:
				array[x, y] = true;
				num = ((int)num2 * -1113158072) ^ 0x52956633;
				continue;
			case 23u:
				num15 = 0;
				num = -964445220;
				continue;
			case 31u:
				array = new bool[mAX_X, mAX_Y];
				num = (int)((num2 * 1064020229) ^ 0x4378C1D0);
				continue;
			case 4u:
				num6++;
				num = ((int)num2 * -581462358) ^ 0xDA1E905;
				continue;
			case 8u:
				return new List<MoveSearchHelper>();
			case 28u:
			{
				int num10;
				int num11;
				if (!array[num9, num3])
				{
					num10 = -165347340;
					num11 = num10;
				}
				else
				{
					num10 = -219092976;
					num11 = num10;
				}
				num = num10 ^ (int)(num2 * 1064373488);
				continue;
			}
			case 36u:
				queue.Enqueue(new MoveSearchHelper
				{
					X = num9,
					Y = num3,
					front = moveSearchHelper
				});
				num = (int)((num2 * 225670440) ^ 0x55C84235);
				continue;
			case 0u:
			{
				int num26;
				int num27;
				if (moveSearchHelper.X != ex)
				{
					num26 = 195294447;
					num27 = num26;
				}
				else
				{
					num26 = 1041723537;
					num27 = num26;
				}
				num = num26 ^ (int)(num2 * 1357810260);
				continue;
			}
			case 27u:
				moveSearchHelper = moveSearchHelper.front;
				num = (int)((num2 * 1167819054) ^ 0x4471C5B2);
				continue;
			case 19u:
				goto IL_0221;
			case 35u:
				num12 = 0;
				num = (int)(num2 * 649201668) ^ -1060848898;
				continue;
			case 15u:
				goto IL_0254;
			case 13u:
			{
				int num20;
				int num21;
				if (!_206E_206D_202B_202E_206D_200F_206B_200B_200C_206E_206F_206E_206C_206C_200F_202E_200F_206E_200E_206C_206A_206B_206F_200C_206A_206D_202A_206F_200C_200E_206C_206D_200B_206F_200F_206E_206E_206D_206F_202C_202E((Object)(object)Field.GetSprite(num9, num3), (Object)null))
				{
					num20 = 1601194557;
					num21 = num20;
				}
				else
				{
					num20 = 336827234;
					num21 = num20;
				}
				num = num20 ^ ((int)num2 * -437429078);
				continue;
			}
			case 11u:
				num = ((int)num2 * -1538295353) ^ -321057970;
				continue;
			case 16u:
				num15++;
				num = -1736625542;
				continue;
			case 21u:
				array[num9, num3] = true;
				num = ((int)num2 * -1375969417) ^ 0x5B58B3E3;
				continue;
			case 25u:
				moveSearchHelper = queue.Dequeue();
				num = -360208552;
				continue;
			case 6u:
			{
				int num13;
				int num14;
				if (num9 < mAX_X)
				{
					num13 = -2137497905;
					num14 = num13;
				}
				else
				{
					num13 = -1993515534;
					num14 = num13;
				}
				num = num13 ^ ((int)num2 * -584549773);
				continue;
			}
			case 5u:
				return list;
			case 22u:
			{
				int num28;
				int num29;
				if (ignoreSpirits)
				{
					num28 = -259639337;
					num29 = num28;
				}
				else
				{
					num28 = -219062691;
					num29 = num28;
				}
				num = num28 ^ ((int)num2 * -1383115901);
				continue;
			}
			case 9u:
			{
				int num24;
				int num25;
				if (moveSearchHelper.Y == ey)
				{
					num24 = -462412940;
					num25 = num24;
				}
				else
				{
					num24 = -1440374159;
					num25 = num24;
				}
				num = num24 ^ (int)(num2 * 1858722750);
				continue;
			}
			case 14u:
				num6 = 0;
				num = -2133951139;
				continue;
			case 1u:
			{
				int num22;
				int num23;
				if (y == ey)
				{
					num22 = -24618564;
					num23 = num22;
				}
				else
				{
					num22 = -1039504170;
					num23 = num22;
				}
				num = num22 ^ (int)(num2 * 178566628);
				continue;
			}
			case 39u:
			{
				num3 = moveSearchHelper.Y + directionY[num15];
				int num18;
				int num19;
				if (Field.isRemoveBlock(num9, num3))
				{
					num18 = 129976563;
					num19 = num18;
				}
				else
				{
					num18 = 1424140629;
					num19 = num18;
				}
				num = num18 ^ (int)(num2 * 1679035357);
				continue;
			}
			case 24u:
			{
				int num16;
				int num17;
				if (moveSearchHelper != null)
				{
					num16 = 690197666;
					num17 = num16;
				}
				else
				{
					num16 = 345497665;
					num17 = num16;
				}
				num = num16 ^ ((int)num2 * -1617015417);
				continue;
			}
			case 34u:
				queue = new Queue<MoveSearchHelper>();
				list = new List<MoveSearchHelper>();
				queue.Enqueue(new MoveSearchHelper
				{
					X = x,
					Y = y
				});
				num = ((int)num2 * -1208222783) ^ -1434056620;
				continue;
			case 20u:
				num9 = moveSearchHelper.X + directionX[num15];
				num = -737349553;
				continue;
			case 29u:
			{
				int num7;
				int num8;
				if (num3 < 0)
				{
					num7 = 1458196169;
					num8 = num7;
				}
				else
				{
					num7 = 1686848217;
					num8 = num7;
				}
				num = num7 ^ (int)(num2 * 39461229);
				continue;
			}
			case 37u:
				goto IL_047e;
			case 26u:
				goto IL_0497;
			case 10u:
				goto IL_04ad;
			case 32u:
			{
				int num4;
				int num5;
				if (num3 < mAX_Y)
				{
					num4 = 77525740;
					num5 = num4;
				}
				else
				{
					num4 = 1325443456;
					num5 = num4;
				}
				num = num4 ^ (int)(num2 * 1409107211);
				continue;
			}
			case 12u:
				num = ((int)num2 * -961654292) ^ -1853227030;
				continue;
			case 33u:
				list.Reverse();
				num = (int)((num2 * 728204100) ^ 0x72009781);
				continue;
			case 2u:
				list.Add(moveSearchHelper);
				num = -2037770453;
				continue;
			default:
				return new List<MoveSearchHelper>();
			}
			break;
			IL_04ad:
			int num30;
			if (num12 >= mAX_X)
			{
				num = -1858061046;
				num30 = num;
			}
			else
			{
				num = -2067767810;
				num30 = num;
			}
			continue;
			IL_00f0:
			int num31;
			if (num15 < 4)
			{
				num = -1825343060;
				num31 = num;
			}
			else
			{
				num = -305072085;
				num31 = num;
			}
			continue;
			IL_0254:
			int num32;
			if (num9 < 0)
			{
				num = -1637047472;
				num32 = num;
			}
			else
			{
				num = -651273882;
				num32 = num;
			}
			continue;
			IL_047e:
			int num33;
			if (num6 < mAX_Y)
			{
				num = -496894149;
				num33 = num;
			}
			else
			{
				num = -72589063;
				num33 = num;
			}
			continue;
			IL_0221:
			int num34;
			if (queue.Count > 0)
			{
				num = -1559694079;
				num34 = num;
			}
			else
			{
				num = -2035923746;
				num34 = num;
			}
		}
		goto IL_0007;
		IL_0497:
		mAX_X = BattleField.MAX_X;
		mAX_Y = BattleField.MAX_Y;
		num = -693969577;
		goto IL_000c;
	}

	private int GetAbsoluteDistance(BattleSprite a, BattleSprite b)
	{
		return _200D_206C_206C_200F_206D_200D_202B_202E_202A_202C_200C_206E_202C_206D_200F_202A_206D_200C_202C_200F_202D_202E_202A_200F_206B_206C_202B_202D_206F_202D_200B_202E_202A_202A_200F_206C_200C_202D_206E_206F_202E(a.X - b.X) + _200D_206C_206C_200F_206D_200D_202B_202E_202A_202C_200C_206E_202C_206D_200F_202A_206D_200C_202C_200F_202D_202E_202A_200F_206B_206C_202B_202D_206F_202D_200B_202E_202A_202A_200F_206C_200C_202D_206E_206F_202E(a.Y - b.Y);
	}

	public int GetDistance(BattleSprite a, BattleSprite b)
	{
		List<MoveSearchHelper> way = GetWay(a.X, a.Y, b.X, b.Y, ignoreSpirits: false);
		if (way == null)
		{
			while (true)
			{
				uint num;
				switch ((num = 527343697u) % 3)
				{
				case 0u:
					continue;
				case 1u:
					return 0;
				}
				break;
			}
		}
		return way.Count;
	}

	private int GetAbsoluteDistance(int x1, int y1, int x2, int y2)
	{
		return _200D_206C_206C_200F_206D_200D_202B_202E_202A_202C_200C_206E_202C_206D_200F_202A_206D_200C_202C_200F_202D_202E_202A_200F_206B_206C_202B_202D_206F_202D_200B_202E_202A_202A_200F_206C_200C_202D_206E_206F_202E(x1 - x2) + _200D_206C_206C_200F_206D_200D_202B_202E_202A_202C_200C_206E_202C_206D_200F_202A_206D_200C_202C_200F_202D_202E_202A_200F_206B_206C_202B_202D_206F_202D_200B_202E_202A_202A_200F_206C_200C_202D_206E_206F_202E(y1 - y2);
	}

	public int GetDistance(int x1, int y1, int x2, int y2)
	{
		List<MoveSearchHelper> way = GetWay(x1, y1, x2, y2, ignoreSpirits: false);
		if (way == null)
		{
			while (true)
			{
				uint num;
				switch ((num = 428358136u) % 3)
				{
				case 0u:
					continue;
				case 1u:
					return 0;
				}
				break;
			}
		}
		return way.Count;
	}

	public AIResult GetAIResult(bool isTrainingMode)
	{
		AIResult aIResult = new AIResult();
		bool flag = false;
		List<LocationBlock> moveRange = default(List<LocationBlock>);
		float num65 = default(float);
		float num13 = default(float);
		int num11 = default(int);
		LocationBlock current = default(LocationBlock);
		int num4 = default(int);
		int distance = default(int);
		BattleSprite current3 = default(BattleSprite);
		int distance2 = default(int);
		int num18 = default(int);
		BattleSprite battleSprite = default(BattleSprite);
		int num29 = default(int);
		int x = default(int);
		int y = default(int);
		int distance3 = default(int);
		LocationBlock current4 = default(LocationBlock);
		int num42 = default(int);
		List<SpecialSkillInstance> list = default(List<SpecialSkillInstance>);
		int num46 = default(int);
		SpecialSkillInstance current5 = default(SpecialSkillInstance);
		DateTime now = default(DateTime);
		TimeSpan ts = default(TimeSpan);
		int num62 = default(int);
		List<SkillBox> list2 = default(List<SkillBox>);
		string text = default(string);
		SkillBox current6 = default(SkillBox);
		bool flag3 = default(bool);
		double num75 = default(double);
		SkillBox skillBox = default(SkillBox);
		string key = default(string);
		string key2 = default(string);
		string key3 = default(string);
		bool flag4 = default(bool);
		SkillBox current7 = default(SkillBox);
		int num104 = default(int);
		SkillBox skillBox2 = default(SkillBox);
		SkillBox current8 = default(SkillBox);
		SkillBox current9 = default(SkillBox);
		bool flag2 = default(bool);
		SkillBox skillBox4 = default(SkillBox);
		bool flag5 = default(bool);
		SkillBox skillBox3 = default(SkillBox);
		int num111 = default(int);
		SkillBox current10 = default(SkillBox);
		List<LocationBlock> list3 = default(List<LocationBlock>);
		LocationBlock item = default(LocationBlock);
		double num138 = default(double);
		AttackResultCache attackResultCache = default(AttackResultCache);
		LocationBlock current13 = default(LocationBlock);
		double num143 = default(double);
		BattleSprite sprite = default(BattleSprite);
		LocationBlock current14 = default(LocationBlock);
		AttackResult attackResult = default(AttackResult);
		TimeSpan timeSpan = default(TimeSpan);
		while (true)
		{
			int num = -705655768;
			while (true)
			{
				IEnumerator<BattleSprite> enumerator2;
				int num63;
				int num64;
				uint num2;
				switch ((num2 = (uint)(num ^ -271918113)) % 10)
				{
				case 8u:
					break;
				case 5u:
					moveRange = GetMoveRange(Field.currentSprite.X, Field.currentSprite.Y);
					num = (int)(num2 * 1611385630) ^ -926488008;
					continue;
				case 2u:
				{
					num65 = (float)Field.currentSprite.Hp / (float)Field.currentSprite.MaxHp;
					num13 = (float)Field.currentSprite.Mp / (float)Field.currentSprite.MaxMp;
					int num68;
					int num69;
					if (!(num65 < 0.3f))
					{
						num68 = -1783582562;
						num69 = num68;
					}
					else
					{
						num68 = -1214093;
						num69 = num68;
					}
					num = num68 ^ (int)(num2 * 107137104);
					continue;
				}
				case 6u:
					if (Tools.ProbabilityTest(0.5))
					{
						num = -1048947179;
						continue;
					}
					goto IL_0407;
				case 7u:
					if (!isTrainingMode)
					{
						num = ((int)num2 * -1577742374) ^ -954978871;
						continue;
					}
					goto IL_0498;
				case 1u:
				{
					int num66;
					int num67;
					if (num65 >= 0.5f)
					{
						num66 = 1872761028;
						num67 = num66;
					}
					else
					{
						num66 = 1202051867;
						num67 = num66;
					}
					num = num66 ^ ((int)num2 * -1165798236);
					continue;
				}
				case 3u:
					if (num13 < 0.01f)
					{
						num = -2099923661;
						continue;
					}
					goto IL_0498;
				case 4u:
				{
					int num14;
					int num15;
					if (!(num13 < 0.1f))
					{
						num14 = -286024096;
						num15 = num14;
					}
					else
					{
						num14 = -1232835789;
						num15 = num14;
					}
					num = num14 ^ (int)(num2 * 2048836176);
					continue;
				}
				case 0u:
					num11 = 0;
					num = ((int)num2 * -40456860) ^ -1623359752;
					continue;
				default:
					{
						using (List<LocationBlock>.Enumerator enumerator = moveRange.GetEnumerator())
						{
							while (true)
							{
								IL_0395:
								if (enumerator.MoveNext())
								{
									while (true)
									{
										current = enumerator.Current;
										int num3 = -783548547;
										while (true)
										{
											switch ((num2 = (uint)(num3 ^ -271918113)) % 4)
											{
											case 0u:
												num3 = -2116268666;
												continue;
											case 1u:
												break;
											case 2u:
												num4 = int.MaxValue;
												num3 = (int)((num2 * 532207222) ^ 0x58E7D3BC);
												continue;
											default:
												goto end_IL_01d4;
											}
											break;
										}
										continue;
										end_IL_01d4:
										break;
									}
									enumerator2 = Field.Sprites.GetEnumerator();
									try
									{
										while (true)
										{
											IL_02c1:
											int num5;
											int num6;
											if (!_200F_202C_202A_202D_202B_202E_202C_200D_206D_206B_202C_202D_200D_202B_206F_200E_206A_202D_202D_202B_206C_202B_206A_200C_206D_206A_202D_202D_206A_202D_206D_206B_206A_202C_200F_206A_202C_200B_202E_202D_202E((IEnumerator)enumerator2))
											{
												num5 = -1817298810;
												num6 = num5;
											}
											else
											{
												num5 = -1349755002;
												num6 = num5;
											}
											while (true)
											{
												switch ((num2 = (uint)(num5 ^ -271918113)) % 6)
												{
												case 4u:
													num5 = -1349755002;
													continue;
												default:
													goto end_IL_0217;
												case 1u:
												{
													BattleSprite current2 = enumerator2.Current;
													distance = GetDistance(current2.X, current2.Y, current.X, current.Y);
													int num9;
													if (current2.Team == Field.currentSprite.Team)
													{
														num5 = -221598675;
														num9 = num5;
													}
													else
													{
														num5 = -1607679298;
														num9 = num5;
													}
													continue;
												}
												case 5u:
												{
													int num7;
													int num8;
													if (distance >= num4)
													{
														num7 = 442003131;
														num8 = num7;
													}
													else
													{
														num7 = 467102369;
														num8 = num7;
													}
													num5 = num7 ^ (int)(num2 * 1518582870);
													continue;
												}
												case 0u:
													break;
												case 2u:
													num4 = distance;
													num5 = (int)(num2 * 691338592) ^ -591588563;
													continue;
												case 3u:
													goto end_IL_0217;
												}
												goto IL_02c1;
												continue;
												end_IL_0217:
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
												IL_02fb:
												int num10 = -297846954;
												while (true)
												{
													switch ((num2 = (uint)(num10 ^ -271918113)) % 3)
													{
													case 0u:
														break;
													default:
														goto end_IL_0300;
													case 1u:
														goto IL_031e;
													case 2u:
														goto end_IL_0300;
													}
													goto IL_02fb;
													IL_031e:
													_200E_206E_200E_200F_206E_206F_200E_202A_206F_206F_206F_202A_200B_202D_202B_206C_206F_200F_206F_206F_206B_200C_200F_202B_202C_206B_206E_206F_200D_202E_206F_202C_202C_202D_202E_202C_200D_202A_206F_206E_202E((IDisposable)enumerator2);
													num10 = (int)((num2 * 291264520) ^ 0x6113644);
													continue;
													end_IL_0300:
													break;
												}
												break;
											}
										}
									}
									if (num4 <= num11)
									{
										continue;
									}
									goto IL_033c;
								}
								int num12 = -1469269047;
								goto IL_0341;
								IL_033c:
								num12 = -342254158;
								goto IL_0341;
								IL_0341:
								while (true)
								{
									switch ((num2 = (uint)(num12 ^ -271918113)) % 5)
									{
									case 4u:
										break;
									default:
										goto end_IL_0395;
									case 1u:
										num11 = num4;
										aIResult.MoveX = current.X;
										aIResult.MoveY = current.Y;
										num12 = (int)(num2 * 1295184322) ^ -1533400022;
										continue;
									case 2u:
										goto IL_0395;
									case 3u:
										aIResult.IsRest = true;
										num12 = (int)((num2 * 1356405426) ^ 0x4FC2AAD6);
										continue;
									case 0u:
										goto end_IL_0395;
									}
									break;
								}
								goto IL_033c;
								continue;
								end_IL_0395:
								break;
							}
						}
						return aIResult;
					}
					IL_1cc8:
					enumerator2 = Field.Sprites.GetEnumerator();
					try
					{
						while (true)
						{
							IL_1dc2:
							int num16;
							int num17;
							if (!enumerator2.MoveNext())
							{
								num16 = -1023989797;
								num17 = num16;
							}
							else
							{
								num16 = -1934702344;
								num17 = num16;
							}
							while (true)
							{
								switch ((num2 = (uint)(num16 ^ -271918113)) % 8)
								{
								case 6u:
									num16 = -1934702344;
									continue;
								default:
									goto end_IL_1ce4;
								case 7u:
									current3 = enumerator2.Current;
									num16 = -306728458;
									continue;
								case 1u:
								{
									int num21;
									int num22;
									if (current3.Team == Field.currentSprite.Team)
									{
										num21 = 965836626;
										num22 = num21;
									}
									else
									{
										num21 = 2124305641;
										num22 = num21;
									}
									num16 = num21 ^ ((int)num2 * -262852163);
									continue;
								}
								case 3u:
								{
									distance2 = GetDistance(current3, Field.currentSprite);
									int num19;
									int num20;
									if (distance2 >= num18)
									{
										num19 = -993964834;
										num20 = num19;
									}
									else
									{
										num19 = -889527573;
										num20 = num19;
									}
									num16 = num19 ^ ((int)num2 * -556060973);
									continue;
								}
								case 5u:
									num18 = distance2;
									num16 = ((int)num2 * -242285770) ^ -1305118149;
									continue;
								case 2u:
									battleSprite = current3;
									num16 = ((int)num2 * -485670535) ^ -1051676931;
									continue;
								case 0u:
									break;
								case 4u:
									goto end_IL_1ce4;
								}
								goto IL_1dc2;
								continue;
								end_IL_1ce4:
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
								IL_1de5:
								int num23 = -1305627917;
								while (true)
								{
									switch ((num2 = (uint)(num23 ^ -271918113)) % 3)
									{
									case 0u:
										break;
									default:
										goto end_IL_1dea;
									case 2u:
										goto IL_1e08;
									case 1u:
										goto end_IL_1dea;
									}
									goto IL_1de5;
									IL_1e08:
									enumerator2.Dispose();
									num23 = (int)((num2 * 1877298211) ^ 0x5A6A75D4);
									continue;
									end_IL_1dea:
									break;
								}
								break;
							}
						}
					}
					if ((Object)(object)battleSprite != (Object)null)
					{
						while (true)
						{
							int num24 = -17770690;
							while (true)
							{
								switch ((num2 = (uint)(num24 ^ -271918113)) % 4)
								{
								case 3u:
									break;
								case 1u:
									num29 = int.MaxValue;
									num24 = (int)((num2 * 335159105) ^ 0x14D20892);
									continue;
								case 0u:
									x = Field.currentSprite.X;
									y = Field.currentSprite.Y;
									num24 = (int)((num2 * 785956632) ^ 0x1DA469B1);
									continue;
								default:
								{
									using (List<LocationBlock>.Enumerator enumerator = moveRange.GetEnumerator())
									{
										while (true)
										{
											IL_1f7c:
											int num25;
											int num26;
											if (enumerator.MoveNext())
											{
												num25 = -2021843341;
												num26 = num25;
											}
											else
											{
												num25 = -1397519379;
												num26 = num25;
											}
											while (true)
											{
												switch ((num2 = (uint)(num25 ^ -271918113)) % 11)
												{
												case 5u:
													num25 = -2021843341;
													continue;
												default:
													goto end_IL_1eb1;
												case 3u:
												{
													int num30;
													int num31;
													if (distance3 == num29)
													{
														num30 = 685703571;
														num31 = num30;
													}
													else
													{
														num30 = 1380243199;
														num31 = num30;
													}
													num25 = num30 ^ ((int)num2 * -1720780712);
													continue;
												}
												case 10u:
												{
													int num32;
													int num33;
													if (distance3 < num29)
													{
														num32 = 2130596941;
														num33 = num32;
													}
													else
													{
														num32 = 1379634677;
														num33 = num32;
													}
													num25 = num32 ^ (int)(num2 * 81857857);
													continue;
												}
												case 6u:
													y = current4.Y;
													num25 = (int)((num2 * 523634574) ^ 0x5E1C6FDB);
													continue;
												case 7u:
													x = current4.X;
													num25 = ((int)num2 * -2003321231) ^ 0x624F82CA;
													continue;
												case 2u:
													num29 = distance3;
													num25 = -700563732;
													continue;
												case 1u:
													break;
												case 4u:
													current4 = enumerator.Current;
													num25 = -1557460261;
													continue;
												case 0u:
													distance3 = GetDistance(current4.X, current4.Y, battleSprite.X, battleSprite.Y);
													num25 = ((int)num2 * -1811277524) ^ 0x3AF71783;
													continue;
												case 8u:
												{
													int num27;
													int num28;
													if (Tools.ProbabilityTest(0.5))
													{
														num27 = -1573218083;
														num28 = num27;
													}
													else
													{
														num27 = -720501357;
														num28 = num27;
													}
													num25 = num27 ^ (int)(num2 * 1946249465);
													continue;
												}
												case 9u:
													goto end_IL_1eb1;
												}
												goto IL_1f7c;
												continue;
												end_IL_1eb1:
												break;
											}
											break;
										}
									}
									aIResult.skill = null;
									aIResult.MoveX = x;
									aIResult.MoveY = y;
									while (true)
									{
										int num34 = -306453037;
										while (true)
										{
											switch ((num2 = (uint)(num34 ^ -271918113)) % 13)
											{
											case 8u:
												break;
											case 9u:
												return aIResult;
											case 4u:
											{
												num42 = int.MinValue;
												int num59;
												int num60;
												if (list.Count != 0)
												{
													num59 = 1191048903;
													num60 = num59;
												}
												else
												{
													num59 = 631102718;
													num60 = num59;
												}
												num34 = num59 ^ ((int)num2 * -1784669815);
												continue;
											}
											case 0u:
												num46 = 0;
												num34 = ((int)num2 * -713038962) ^ -132521884;
												continue;
											case 1u:
												aIResult.IsRest = true;
												num34 = ((int)num2 * -302446778) ^ -1368896532;
												continue;
											case 7u:
												if (Tools.ProbabilityTest(0.5) || flag)
												{
													num34 = -892050736;
													continue;
												}
												goto IL_2592;
											case 2u:
											{
												int num58;
												if (!Tools.ProbabilityTest(0.1))
												{
													num34 = -104826059;
													num58 = num34;
												}
												else
												{
													num34 = -808485975;
													num58 = num34;
												}
												continue;
											}
											case 5u:
											{
												int num57;
												if (!Tools.ProbabilityTest(0.5))
												{
													num34 = -1307527435;
													num57 = num34;
												}
												else
												{
													num34 = -190699102;
													num57 = num34;
												}
												continue;
											}
											case 10u:
											{
												int num56;
												if (!Tools.ProbabilityTest(0.1))
												{
													num34 = -172868332;
													num56 = num34;
												}
												else
												{
													num34 = -1761968786;
													num56 = num34;
												}
												continue;
											}
											case 12u:
												num42 = 0;
												num34 = (int)((num2 * 1407491510) ^ 0x22C733C2);
												continue;
											case 3u:
												num42 = Tools.GetRandomInt(0, list.Count - 1);
												num34 = ((int)num2 * -85982482) ^ 0x79645722;
												continue;
											case 6u:
												num42 = -1;
												num34 = (int)(num2 * 1539665667) ^ -926927242;
												continue;
											default:
												{
													int num35 = int.MinValue;
													using (List<SpecialSkillInstance>.Enumerator enumerator3 = list.GetEnumerator())
													{
														while (true)
														{
															IL_2487:
															int num36;
															int num37;
															if (enumerator3.MoveNext())
															{
																num36 = -1277322248;
																num37 = num36;
															}
															else
															{
																num36 = -1840453423;
																num37 = num36;
															}
															while (true)
															{
																switch ((num2 = (uint)(num36 ^ -271918113)) % 29)
																{
																case 24u:
																	num36 = -1277322248;
																	continue;
																default:
																	goto end_IL_21ea;
																case 28u:
																{
																	int num51;
																	int num52;
																	if (current5.Cd == num35)
																	{
																		num51 = 1187454739;
																		num52 = num51;
																	}
																	else
																	{
																		num51 = 47009921;
																		num52 = num51;
																	}
																	num36 = num51 ^ (int)(num2 * 1954844940);
																	continue;
																}
																case 1u:
																	aIResult.skill = current5;
																	num36 = ((int)num2 * -2127197070) ^ 0x43513AA3;
																	continue;
																case 11u:
																	aIResult.skill = current5;
																	num36 = (int)((num2 * 347831653) ^ 0x49952D2F);
																	continue;
																case 20u:
																{
																	int num44;
																	int num45;
																	if (Tools.ProbabilityTest(0.3))
																	{
																		num44 = -1820189647;
																		num45 = num44;
																	}
																	else
																	{
																		num44 = -1707465235;
																		num45 = num44;
																	}
																	num36 = num44 ^ (int)(num2 * 332548585);
																	continue;
																}
																case 17u:
																	current5 = enumerator3.Current;
																	num36 = -1054607179;
																	continue;
																case 25u:
																	aIResult.AttackX = x;
																	aIResult.AttackY = y;
																	aIResult.IsRest = false;
																	num36 = ((int)num2 * -70333143) ^ -1922781750;
																	continue;
																case 7u:
																	num36 = ((int)num2 * -1063089408) ^ 0x3853F3B1;
																	continue;
																case 6u:
																{
																	int num49;
																	int num50;
																	if (num42 >= -1)
																	{
																		num49 = 346122626;
																		num50 = num49;
																	}
																	else
																	{
																		num49 = 2126248100;
																		num50 = num49;
																	}
																	num36 = num49 ^ (int)(num2 * 770947311);
																	continue;
																}
																case 23u:
																{
																	int num43;
																	if (num42 == -1)
																	{
																		num36 = -1214294857;
																		num43 = num36;
																	}
																	else
																	{
																		num36 = -188666570;
																		num43 = num36;
																	}
																	continue;
																}
																case 9u:
																	num46++;
																	num36 = -987795791;
																	continue;
																case 22u:
																	aIResult.AttackX = x;
																	num36 = ((int)num2 * -687070685) ^ 0x6DB28D97;
																	continue;
																case 27u:
																	aIResult.IsRest = false;
																	num36 = (int)(num2 * 1354896870) ^ -160834380;
																	continue;
																case 3u:
																	num35 = current5.Cd;
																	num36 = -1530761924;
																	continue;
																case 26u:
																{
																	int num54;
																	int num55;
																	if (current5.CostMp > num35)
																	{
																		num54 = -134004423;
																		num55 = num54;
																	}
																	else
																	{
																		num54 = -2099738391;
																		num55 = num54;
																	}
																	num36 = num54 ^ ((int)num2 * -265873229);
																	continue;
																}
																case 8u:
																	aIResult.AttackY = y;
																	num36 = (int)((num2 * 1347536745) ^ 0x74D0B341);
																	continue;
																case 21u:
																{
																	int num53;
																	if (num42 != num46)
																	{
																		num36 = -784058744;
																		num53 = num36;
																	}
																	else
																	{
																		num36 = -506645818;
																		num53 = num36;
																	}
																	continue;
																}
																case 15u:
																	aIResult.AttackY = y;
																	num36 = (int)(num2 * 633224868) ^ -1745955494;
																	continue;
																case 13u:
																{
																	int num47;
																	int num48;
																	if (Tools.ProbabilityTest(0.3))
																	{
																		num47 = 1998025240;
																		num48 = num47;
																	}
																	else
																	{
																		num47 = 1746294824;
																		num48 = num47;
																	}
																	num36 = num47 ^ (int)(num2 * 935602139);
																	continue;
																}
																case 5u:
																	break;
																case 18u:
																	goto end_IL_21ea;
																case 4u:
																	num35 = current5.CostMp;
																	num36 = -691665936;
																	continue;
																case 14u:
																{
																	int num40;
																	int num41;
																	if (current5.CostMp == num35)
																	{
																		num40 = -1877295008;
																		num41 = num40;
																	}
																	else
																	{
																		num40 = -195118443;
																		num41 = num40;
																	}
																	num36 = num40 ^ (int)(num2 * 1543948894);
																	continue;
																}
																case 2u:
																	aIResult.skill = current5;
																	num36 = ((int)num2 * -229371460) ^ -1059960049;
																	continue;
																case 10u:
																	aIResult.AttackX = x;
																	num36 = ((int)num2 * -1878911052) ^ -243896147;
																	continue;
																case 16u:
																	num36 = ((int)num2 * -1058728109) ^ 0x253ADCCE;
																	continue;
																case 19u:
																	aIResult.IsRest = false;
																	num36 = (int)(num2 * 326219692) ^ -472449736;
																	continue;
																case 0u:
																{
																	int num38;
																	int num39;
																	if (current5.Cd > num35)
																	{
																		num38 = -1921942691;
																		num39 = num38;
																	}
																	else
																	{
																		num38 = -1107318677;
																		num39 = num38;
																	}
																	num36 = num38 ^ ((int)num2 * -1335686928);
																	continue;
																}
																case 12u:
																	goto end_IL_21ea;
																}
																goto IL_2487;
																continue;
																end_IL_21ea:
																break;
															}
															break;
														}
													}
													goto IL_2592;
												}
												IL_2592:
												return aIResult;
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
					while (true)
					{
						aIResult.MoveX = Field.currentSprite.X;
						aIResult.MoveY = Field.currentSprite.Y;
						int num61 = -1820707138;
						while (true)
						{
							switch ((num2 = (uint)(num61 ^ -271918113)) % 3)
							{
							case 0u:
								goto IL_2594;
							case 2u:
								break;
							default:
								aIResult.IsRest = true;
								return aIResult;
							}
							break;
							IL_2594:
							num61 = -1072362686;
						}
					}
					IL_0498:
					now = DateTime.Now;
					ts = new TimeSpan(now.Ticks);
					num62 = 0;
					flag2 = false;
					list2 = new List<SkillBox>();
					list = new List<SpecialSkillInstance>();
					num63 = -452655763;
					goto IL_03d6;
					IL_0407:
					if (!Tools.ProbabilityTest(0.3))
					{
						num63 = -53655158;
						num64 = num63;
					}
					else
					{
						num63 = -1749129599;
						num64 = num63;
					}
					goto IL_03d6;
					IL_03d6:
					while (true)
					{
						switch ((num2 = (uint)(num63 ^ -271918113)) % 7)
						{
						case 0u:
							num63 = -309297251;
							continue;
						case 1u:
							break;
						case 5u:
							flag = true;
							num63 = (int)(num2 * 879595031) ^ -1337954568;
							continue;
						case 6u:
							goto IL_043a;
						case 3u:
							text = Field.currentSprite.Role.Key + Field.currentSprite.Team;
							num63 = (int)(num2 * 1073587937) ^ -76958707;
							continue;
						case 2u:
							goto IL_0498;
						default:
							goto IL_04cb;
						}
						break;
						IL_04cb:
						IEnumerator<SkillBox> enumerator4 = Field.currentSprite.Role.GetAvaliableSkills().GetEnumerator();
						try
						{
							while (true)
							{
								IL_0c73:
								if (enumerator4.MoveNext())
								{
									while (true)
									{
										current6 = enumerator4.Current;
										if (current6.Status != SkillStatus.Ok)
										{
											break;
										}
										int num70 = -122444467;
										while (true)
										{
											switch ((num2 = (uint)(num70 ^ -271918113)) % 18)
											{
											case 0u:
												num70 = -1437290562;
												continue;
											case 6u:
												if (flag3)
												{
													num70 = -1041550297;
													continue;
												}
												goto end_IL_0672;
											case 1u:
											{
												int num76;
												int num77;
												if (list2.Count >= 5)
												{
													num76 = 1449905660;
													num77 = num76;
												}
												else
												{
													num76 = 1589582229;
													num77 = num76;
												}
												num70 = num76 ^ (int)(num2 * 1898216623);
												continue;
											}
											case 13u:
												num62++;
												num70 = -924654663;
												continue;
											case 2u:
											{
												int num73;
												int num74;
												if (!current6.HitSelf)
												{
													num73 = 1332321296;
													num74 = num73;
												}
												else
												{
													num73 = 349410612;
													num74 = num73;
												}
												num70 = num73 ^ (int)(num2 * 104066789);
												continue;
											}
											case 9u:
												if (!(current6.Name == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1434409944u)))
												{
													num70 = (int)((num2 * 306735377) ^ 0x667F8DC3);
													continue;
												}
												goto end_IL_0672;
											case 15u:
												list.Add((SpecialSkillInstance)current6);
												flag3 = false;
												num70 = ((int)num2 * -1431536229) ^ -1068630144;
												continue;
											case 8u:
												if (current6.IsUsed)
												{
													num70 = (int)((num2 * 1955723168) ^ 0x44DB823C);
													continue;
												}
												goto end_IL_0672;
											case 14u:
												list2.Add(current6);
												num70 = (int)(num2 * 1466977841) ^ -276102447;
												continue;
											case 11u:
												flag2 = true;
												num70 = (int)((num2 * 1112417826) ^ 0x5BFB112F);
												continue;
											case 16u:
												num75 = double.MaxValue;
												num70 = -1803890845;
												continue;
											case 17u:
												break;
											case 3u:
												flag3 = true;
												num70 = ((int)num2 * -278356605) ^ 0x33EE52F5;
												continue;
											case 5u:
											{
												int num71;
												int num72;
												if (!current6.IsSpecial)
												{
													num71 = 2005986127;
													num72 = num71;
												}
												else
												{
													num71 = 2136493027;
													num72 = num71;
												}
												num70 = num71 ^ ((int)num2 * -1504889084);
												continue;
											}
											case 4u:
												goto IL_06e5;
											case 12u:
												skillBox = null;
												num70 = ((int)num2 * -1973588978) ^ 0x185B71DC;
												continue;
											default:
												goto IL_0718;
											case 10u:
												goto end_IL_0672;
											}
											break;
											IL_06e5:
											int num78;
											if (current6.SkillType != SkillType.Normal)
											{
												num70 = -924654663;
												num78 = num70;
											}
											else
											{
												num70 = -326412988;
												num78 = num70;
											}
										}
										continue;
										end_IL_0672:
										break;
									}
									continue;
								}
								int num79 = -1998073898;
								goto IL_0a58;
								IL_0b76:
								key = text + skillBox.Name + skillBox.Level;
								num79 = -297508462;
								goto IL_0a58;
								IL_0a58:
								while (true)
								{
									switch ((num2 = (uint)(num79 ^ -271918113)) % 14)
									{
									case 4u:
										break;
									default:
										goto end_IL_0c73;
									case 8u:
										Field.PowerCache[key] = skillBox.Power + (float)(skillBox.CostBall + skillBox.Cd + skillBox.GetCoverTypePower());
										num79 = ((int)num2 * -478553994) ^ -972358567;
										continue;
									case 0u:
									{
										int num84;
										int num85;
										if (Field.PowerCache[key2] <= Field.PowerCache[key])
										{
											num84 = 707991568;
											num85 = num84;
										}
										else
										{
											num84 = 1513543502;
											num85 = num84;
										}
										num79 = num84 ^ (int)(num2 * 2120469387);
										continue;
									}
									case 3u:
										list2.Insert(0, current6);
										num79 = ((int)num2 * -1980665538) ^ -1536428028;
										continue;
									case 12u:
										list2.Add(current6);
										num79 = -821339268;
										continue;
									case 10u:
										goto IL_0b5e;
									case 2u:
										goto IL_0b76;
									case 5u:
										list2.Remove(skillBox);
										num79 = ((int)num2 * -1345424600) ^ -773542823;
										continue;
									case 13u:
										Field.PowerCache[key2] = current6.Power + (float)(current6.CostBall + current6.Cd + current6.GetCoverTypePower());
										num79 = ((int)num2 * -1362700106) ^ -1927180719;
										continue;
									case 11u:
										num79 = (int)(num2 * 2026550957) ^ -251079871;
										continue;
									case 7u:
									{
										int num82;
										int num83;
										if (!Field.PowerCache.ContainsKey(key))
										{
											num82 = -1909692026;
											num83 = num82;
										}
										else
										{
											num82 = -1152401870;
											num83 = num82;
										}
										num79 = num82 ^ (int)(num2 * 1794529035);
										continue;
									}
									case 6u:
									{
										int num80;
										int num81;
										if (!Tools.ProbabilityTest(0.6))
										{
											num80 = -1802247263;
											num81 = num80;
										}
										else
										{
											num80 = -1484759364;
											num81 = num80;
										}
										num79 = num80 ^ ((int)num2 * -1201738556);
										continue;
									}
									case 1u:
										goto IL_0c73;
									case 9u:
										goto end_IL_0c73;
									}
									break;
									IL_0b5e:
									int num86;
									if (skillBox == null)
									{
										num79 = -821339268;
										num86 = num79;
									}
									else
									{
										num79 = -1225245669;
										num86 = num79;
									}
								}
								goto IL_0a53;
								IL_0718:
								using (List<SkillBox>.Enumerator enumerator5 = list2.GetEnumerator())
								{
									while (true)
									{
										IL_0935:
										int num87;
										int num88;
										if (!enumerator5.MoveNext())
										{
											num87 = -621226208;
											num88 = num87;
										}
										else
										{
											num87 = -837792203;
											num88 = num87;
										}
										while (true)
										{
											switch ((num2 = (uint)(num87 ^ -271918113)) % 20)
											{
											case 11u:
												num87 = -837792203;
												continue;
											default:
												goto end_IL_072b;
											case 17u:
												num87 = (int)((num2 * 1557551160) ^ 0x1C372B36);
												continue;
											case 3u:
											{
												int num97;
												if ((double)Field.PowerCache[key3] >= num75)
												{
													num87 = -1700255277;
													num97 = num87;
												}
												else
												{
													num87 = -1275325042;
													num97 = num87;
												}
												continue;
											}
											case 8u:
												num62--;
												num87 = (int)(num2 * 1467384676) ^ -127410919;
												continue;
											case 6u:
												flag4 = false;
												num87 = -462947154;
												continue;
											case 16u:
											{
												int num91;
												int num92;
												if (Tools.ProbabilityTest(0.5))
												{
													num91 = 335960075;
													num92 = num91;
												}
												else
												{
													num91 = 543073718;
													num92 = num91;
												}
												num87 = num91 ^ ((int)num2 * -406159918);
												continue;
											}
											case 1u:
											{
												int num100;
												if (!flag4)
												{
													num87 = -1700255277;
													num100 = num87;
												}
												else
												{
													num87 = -559151502;
													num100 = num87;
												}
												continue;
											}
											case 0u:
												flag4 = false;
												num87 = (int)((num2 * 646990846) ^ 0x5C7E3802);
												continue;
											case 18u:
											{
												int num93;
												int num94;
												if (num62 <= 0)
												{
													num93 = -1329081503;
													num94 = num93;
												}
												else
												{
													num93 = -424052594;
													num94 = num93;
												}
												num87 = num93 ^ (int)(num2 * 1708935216);
												continue;
											}
											case 9u:
											{
												int num101;
												if (!Tools.ProbabilityTest(0.8))
												{
													num87 = -839276955;
													num101 = num87;
												}
												else
												{
													num87 = -1592798133;
													num101 = num87;
												}
												continue;
											}
											case 13u:
											{
												flag4 = true;
												int num98;
												int num99;
												if (current7.IsSpecial)
												{
													num98 = -1295775960;
													num99 = num98;
												}
												else
												{
													num98 = -767901806;
													num99 = num98;
												}
												num87 = num98 ^ (int)(num2 * 1556288636);
												continue;
											}
											case 12u:
											{
												key3 = text + current7.Name + current7.Level;
												int num95;
												int num96;
												if (Field.PowerCache.ContainsKey(key3))
												{
													num95 = 1334499320;
													num96 = num95;
												}
												else
												{
													num95 = 1104816128;
													num96 = num95;
												}
												num87 = num95 ^ (int)(num2 * 1443031341);
												continue;
											}
											case 5u:
												num75 = Field.PowerCache[key3];
												num87 = (int)((num2 * 114542534) ^ 0x77D5268F);
												continue;
											case 4u:
												break;
											case 2u:
												flag4 = false;
												num87 = (int)(num2 * 1231903300) ^ -595519146;
												continue;
											case 14u:
												current7 = enumerator5.Current;
												num87 = -1921663397;
												continue;
											case 10u:
												skillBox = current7;
												num87 = ((int)num2 * -502164640) ^ -916374381;
												continue;
											case 7u:
											{
												int num89;
												int num90;
												if (global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2848864861u).Contains(current7.Name))
												{
													num89 = 467297271;
													num90 = num89;
												}
												else
												{
													num89 = 400555630;
													num90 = num89;
												}
												num87 = num89 ^ ((int)num2 * -2062755572);
												continue;
											}
											case 19u:
												Field.PowerCache[key3] = current7.Power + (float)(current7.CostBall + current7.Cd + current7.GetCoverTypePower());
												num87 = (int)(num2 * 1172351811) ^ -1290663859;
												continue;
											case 15u:
												goto end_IL_072b;
											}
											goto IL_0935;
											continue;
											end_IL_072b:
											break;
										}
										break;
									}
								}
								key2 = text + current6.Name + current6.Level;
								if (!Field.PowerCache.ContainsKey(key2))
								{
									goto IL_0a53;
								}
								goto IL_0b76;
								IL_0a53:
								num79 = -1450672582;
								goto IL_0a58;
								continue;
								end_IL_0c73:
								break;
							}
						}
						finally
						{
							if (enumerator4 != null)
							{
								while (true)
								{
									IL_0c8f:
									int num102 = -714832223;
									while (true)
									{
										switch ((num2 = (uint)(num102 ^ -271918113)) % 3)
										{
										case 2u:
											break;
										default:
											goto end_IL_0c94;
										case 1u:
											goto IL_0cb2;
										case 0u:
											goto end_IL_0c94;
										}
										goto IL_0c8f;
										IL_0cb2:
										enumerator4.Dispose();
										num102 = ((int)num2 * -2126771470) ^ 0x53E980C5;
										continue;
										end_IL_0c94:
										break;
									}
									break;
								}
							}
						}
						if (list2.Count > 2 && flag2)
						{
							while (true)
							{
								int num103 = -1820070743;
								while (true)
								{
									switch ((num2 = (uint)(num103 ^ -271918113)) % 3)
									{
									case 0u:
										break;
									case 1u:
										num104 = int.MaxValue;
										num103 = (int)((num2 * 152925685) ^ 0x2485AF84);
										continue;
									default:
										goto end_IL_0cdc;
									}
									break;
								}
								continue;
								end_IL_0cdc:
								break;
							}
							skillBox2 = null;
							using (List<SkillBox>.Enumerator enumerator5 = list2.GetEnumerator())
							{
								while (true)
								{
									IL_0dc1:
									int num105;
									int num106;
									if (!enumerator5.MoveNext())
									{
										num105 = -584976339;
										num106 = num105;
									}
									else
									{
										num105 = -750174776;
										num106 = num105;
									}
									while (true)
									{
										switch ((num2 = (uint)(num105 ^ -271918113)) % 6)
										{
										case 0u:
											num105 = -750174776;
											continue;
										default:
											goto end_IL_0d2c;
										case 3u:
										{
											current8 = enumerator5.Current;
											int num109;
											if (current8.CostMp < num104)
											{
												num105 = -1829709713;
												num109 = num105;
											}
											else
											{
												num105 = -206592650;
												num109 = num105;
											}
											continue;
										}
										case 2u:
										{
											int num107;
											int num108;
											if (current8.SkillType != SkillType.Normal)
											{
												num107 = 512440966;
												num108 = num107;
											}
											else
											{
												num107 = 1071062142;
												num108 = num107;
											}
											num105 = num107 ^ ((int)num2 * -944372467);
											continue;
										}
										case 5u:
											num104 = current8.CostMp;
											skillBox2 = current8;
											num105 = (int)(num2 * 1996378184) ^ -373849154;
											continue;
										case 1u:
											break;
										case 4u:
											goto end_IL_0d2c;
										}
										goto IL_0dc1;
										continue;
										end_IL_0d2c:
										break;
									}
									break;
								}
							}
							if (skillBox2 != null)
							{
								goto IL_0df5;
							}
						}
						goto IL_1501;
						IL_0e59:
						enumerator4 = Field.currentSprite.Role.GetAvaliableSkills().GetEnumerator();
						try
						{
							while (true)
							{
								IL_12c4:
								if (enumerator4.MoveNext())
								{
									while (true)
									{
										IL_103b:
										current9 = enumerator4.Current;
										int num110 = -1477362048;
										while (true)
										{
											switch ((num2 = (uint)(num110 ^ -271918113)) % 23)
											{
											case 7u:
												num110 = -1703555619;
												continue;
											case 6u:
												flag2 = true;
												num110 = ((int)num2 * -1825493365) ^ 0x249A2D9D;
												continue;
											case 2u:
												break;
											case 19u:
											{
												int num114;
												int num115;
												if (!current9.IsSpecial)
												{
													num114 = -1316943856;
													num115 = num114;
												}
												else
												{
													num114 = -1786101241;
													num115 = num114;
												}
												num110 = num114 ^ ((int)num2 * -1754820087);
												continue;
											}
											case 18u:
												skillBox4 = null;
												num110 = ((int)num2 * -1385663894) ^ -1882261187;
												continue;
											case 13u:
											{
												flag5 = false;
												int num118;
												int num119;
												if (!current9.HitSelf)
												{
													num118 = -1703258504;
													num119 = num118;
												}
												else
												{
													num118 = -547404207;
													num119 = num118;
												}
												num110 = num118 ^ ((int)num2 * -1750740735);
												continue;
											}
											case 16u:
												goto end_IL_0e7f;
											case 15u:
												goto IL_0f95;
											case 0u:
												goto IL_0fc3;
											case 9u:
												skillBox3 = current9;
												num110 = -433285655;
												continue;
											case 21u:
											{
												int num120;
												int num121;
												if (list2.Count < 5)
												{
													num120 = 1004717317;
													num121 = num120;
												}
												else
												{
													num120 = 1344990445;
													num121 = num120;
												}
												num110 = num120 ^ ((int)num2 * -1647311203);
												continue;
											}
											case 12u:
												goto IL_101e;
											case 1u:
												goto IL_103b;
											case 4u:
											{
												int num116;
												int num117;
												if (Tools.ProbabilityTest(0.3))
												{
													num116 = 954095592;
													num117 = num116;
												}
												else
												{
													num116 = 159315109;
													num117 = num116;
												}
												num110 = num116 ^ (int)(num2 * 1512149426);
												continue;
											}
											case 14u:
												goto IL_107b;
											case 10u:
												num110 = ((int)num2 * -1182010733) ^ 0x22DCB17A;
												continue;
											case 22u:
												goto IL_10ad;
											case 11u:
											{
												int num112;
												int num113;
												if (skillBox3 == null)
												{
													num112 = -1891224995;
													num113 = num112;
												}
												else
												{
													num112 = -770555600;
													num113 = num112;
												}
												num110 = num112 ^ (int)(num2 * 1625180355);
												continue;
											}
											case 3u:
												list.Add((SpecialSkillInstance)current9);
												num110 = (int)((num2 * 241549771) ^ 0x24669C4B);
												continue;
											case 17u:
												num111 = int.MaxValue;
												num110 = -1754559716;
												continue;
											case 20u:
												flag5 = true;
												num110 = (int)(num2 * 1457556267) ^ -164720382;
												continue;
											case 8u:
												goto IL_1148;
											default:
												goto IL_1167;
											}
											if (flag5)
											{
												num110 = -521425172;
												continue;
											}
											goto IL_12c4;
											IL_1148:
											if (current9.IsUsed)
											{
												num110 = ((int)num2 * -1406849394) ^ 0x3FF23D59;
												continue;
											}
											goto IL_12c4;
											IL_0f95:
											if (!(current9.Name == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(294007945u)))
											{
												num110 = ((int)num2 * -511427946) ^ -1328743119;
												continue;
											}
											goto IL_12c4;
											IL_10ad:
											list2.Add(current9);
											if (Field.currentSprite.Team == 2)
											{
												num110 = (int)(num2 * 1524017916) ^ -362481871;
												continue;
											}
											goto IL_12c4;
											IL_0fc3:
											if (current9.Level < current9.MaxLevel)
											{
												num110 = ((int)num2 * -917324992) ^ 0xF8EF982;
												continue;
											}
											goto IL_12c4;
											IL_107b:
											if (current9.Status == SkillStatus.Ok)
											{
												num110 = (int)(num2 * 1828796433) ^ -995840253;
												continue;
											}
											goto IL_12c4;
											IL_101e:
											int num122;
											if (current9.SkillType != SkillType.Normal)
											{
												num110 = -433285655;
												num122 = num110;
											}
											else
											{
												num110 = -2110379188;
												num122 = num110;
											}
											continue;
											end_IL_0e7f:
											break;
										}
										break;
									}
									break;
								}
								int num123 = -422563281;
								goto IL_128a;
								IL_128a:
								while (true)
								{
									switch ((num2 = (uint)(num123 ^ -271918113)) % 9)
									{
									case 3u:
										break;
									default:
										goto end_IL_12c4;
									case 1u:
										goto IL_12c4;
									case 0u:
										list2.Remove(skillBox4);
										num123 = ((int)num2 * -990388735) ^ 0x318CC4FA;
										continue;
									case 8u:
									{
										int num126;
										int num127;
										if (Tools.ProbabilityTest(0.7))
										{
											num126 = -2102809881;
											num127 = num126;
										}
										else
										{
											num126 = -991445373;
											num127 = num126;
										}
										num123 = num126 ^ (int)(num2 * 1040365321);
										continue;
									}
									case 5u:
										num123 = (int)(num2 * 1587017532) ^ -117352454;
										continue;
									case 7u:
									{
										int num124;
										int num125;
										if (current9.MaxLevel - current9.Level > skillBox4.MaxLevel - skillBox4.Level)
										{
											num124 = 158215544;
											num125 = num124;
										}
										else
										{
											num124 = 1147653384;
											num125 = num124;
										}
										num123 = num124 ^ (int)(num2 * 394232610);
										continue;
									}
									case 2u:
										list2.Insert(0, current9);
										num123 = ((int)num2 * -1480027270) ^ -19794583;
										continue;
									case 6u:
										list2.Add(current9);
										num123 = -1905238958;
										continue;
									case 4u:
										goto end_IL_12c4;
									}
									break;
								}
								goto IL_1285;
								IL_1285:
								num123 = -887792510;
								goto IL_128a;
								IL_1167:
								using (List<SkillBox>.Enumerator enumerator5 = list2.GetEnumerator())
								{
									while (true)
									{
										IL_1210:
										int num128;
										int num129;
										if (!enumerator5.MoveNext())
										{
											num128 = -2056567141;
											num129 = num128;
										}
										else
										{
											num128 = -1435453292;
											num129 = num128;
										}
										while (true)
										{
											switch ((num2 = (uint)(num128 ^ -271918113)) % 8)
											{
											case 6u:
												num128 = -1435453292;
												continue;
											default:
												goto end_IL_117a;
											case 3u:
												current10 = enumerator5.Current;
												num128 = -1203942806;
												continue;
											case 7u:
												num111 = current10.MaxLevel - current10.Level;
												num128 = (int)((num2 * 167771360) ^ 0x50A5D88F);
												continue;
											case 5u:
											{
												int num132;
												int num133;
												if (current10.MaxLevel - current10.Level >= num111)
												{
													num132 = -1257301843;
													num133 = num132;
												}
												else
												{
													num132 = -1034696066;
													num133 = num132;
												}
												num128 = num132 ^ ((int)num2 * -1171567648);
												continue;
											}
											case 2u:
												break;
											case 0u:
												skillBox4 = current10;
												num128 = (int)((num2 * 58725521) ^ 0x7F817BBD);
												continue;
											case 1u:
											{
												int num130;
												int num131;
												if (current10.MaxLevel < current10.Level)
												{
													num130 = 965683000;
													num131 = num130;
												}
												else
												{
													num130 = 1672155677;
													num131 = num130;
												}
												num128 = num130 ^ (int)(num2 * 1659744053);
												continue;
											}
											case 4u:
												goto end_IL_117a;
											}
											goto IL_1210;
											continue;
											end_IL_117a:
											break;
										}
										break;
									}
								}
								if (skillBox4 == null)
								{
									continue;
								}
								goto IL_1285;
								continue;
								end_IL_12c4:
								break;
							}
						}
						finally
						{
							if (enumerator4 != null)
							{
								while (true)
								{
									IL_13a4:
									int num134 = -835873407;
									while (true)
									{
										switch ((num2 = (uint)(num134 ^ -271918113)) % 3)
										{
										case 2u:
											break;
										default:
											goto end_IL_13a9;
										case 1u:
											goto IL_13c7;
										case 0u:
											goto end_IL_13a9;
										}
										goto IL_13a4;
										IL_13c7:
										enumerator4.Dispose();
										num134 = ((int)num2 * -1590357947) ^ 0x4D6652E7;
										continue;
										end_IL_13a9:
										break;
									}
									break;
								}
							}
						}
						if (list2.Count == 0)
						{
							goto IL_13eb;
						}
						goto IL_1501;
						IL_13f0:
						int num135;
						while (true)
						{
							switch ((num2 = (uint)(num135 ^ -271918113)) % 21)
							{
							case 0u:
								break;
							case 8u:
								num135 = ((int)num2 * -1551647082) ^ 0x2E971789;
								continue;
							case 5u:
								list2.Add(skillBox3);
								num135 = (int)(num2 * 280688134) ^ -1840076531;
								continue;
							case 18u:
								AttackLogic.Log(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3926030107u) + Field.currentSprite.Role.Name + global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(924355102u));
								num135 = (int)(num2 * 907032208) ^ -1571905776;
								continue;
							case 4u:
								list3.Add(item);
								num135 = ((int)num2 * -1976461778) ^ 0x17CE9C23;
								continue;
							case 2u:
								goto IL_14e8;
							case 6u:
								goto IL_1501;
							case 16u:
								flag = false;
								num135 = ((int)num2 * -2132971900) ^ -146233036;
								continue;
							case 15u:
								goto IL_1534;
							case 12u:
								item = moveRange[Tools.GetRandomInt(0, moveRange.Count - 1)];
								num135 = -668691025;
								continue;
							case 3u:
							{
								int num141;
								int num142;
								if (!list3.Contains(item))
								{
									num141 = -1800749293;
									num142 = num141;
								}
								else
								{
									num141 = -678502373;
									num142 = num141;
								}
								num135 = num141 ^ (int)(num2 * 1355320569);
								continue;
							}
							case 9u:
								goto IL_15a3;
							case 1u:
							{
								int num139;
								int num140;
								if (skillBox3 != null)
								{
									num139 = 1335526521;
									num140 = num139;
								}
								else
								{
									num139 = 655979999;
									num140 = num139;
								}
								num135 = num139 ^ ((int)num2 * -704553894);
								continue;
							}
							case 11u:
								list3 = new List<LocationBlock>();
								list3.Add(new LocationBlock
								{
									X = Field.currentSprite.X,
									Y = Field.currentSprite.Y
								});
								num135 = -1372092922;
								continue;
							case 14u:
								RuntimeData.Instance.isAttackAnalog = true;
								num135 = ((int)num2 * -793087339) ^ 0x7644E9D2;
								continue;
							case 10u:
								num138 = 0.0;
								num135 = -1919164784;
								continue;
							case 7u:
								list3 = moveRange;
								num135 = -1717808841;
								continue;
							case 17u:
								num135 = (int)((num2 * 1102193299) ^ 0x2C3AD381);
								continue;
							case 19u:
							{
								int num136;
								int num137;
								if (moveRange.Count > 20)
								{
									num136 = -263580810;
									num137 = num136;
								}
								else
								{
									num136 = -139010361;
									num137 = num136;
								}
								num135 = num136 ^ ((int)num2 * -1882048929);
								continue;
							}
							case 13u:
								attackResultCache = new AttackResultCache(Field.currentSprite, Field);
								num135 = ((int)num2 * -1376651412) ^ -1925543084;
								continue;
							default:
								goto IL_16d1;
							}
							break;
							IL_16d1:
							using (List<SkillBox>.Enumerator enumerator5 = list2.GetEnumerator())
							{
								while (true)
								{
									IL_1c1b:
									if (enumerator5.MoveNext())
									{
										SkillBox current11 = enumerator5.Current;
										foreach (LocationBlock item2 in list3)
										{
											List<LocationBlock> list4 = new List<LocationBlock>();
											list4.Clear();
											int x2 = item2.X;
											int y2 = item2.Y;
											using List<LocationBlock>.Enumerator enumerator6 = current11.GetSkillCastBlocks(x2, y2).GetEnumerator();
											while (true)
											{
												IL_1a60:
												if (enumerator6.MoveNext())
												{
													while (true)
													{
														current13 = enumerator6.Current;
														num143 = 0.0;
														int num144 = -405442577;
														while (true)
														{
															switch ((num2 = (uint)(num144 ^ -271918113)) % 3)
															{
															case 2u:
																num144 = -543270139;
																continue;
															case 1u:
																break;
															default:
																goto end_IL_1754;
															}
															break;
														}
														continue;
														end_IL_1754:
														break;
													}
													using (List<LocationBlock>.Enumerator enumerator7 = current11.GetSkillCoverBlocks(current13.X, current13.Y, x2, y2).GetEnumerator())
													{
														while (true)
														{
															IL_186a:
															int num145;
															int num146;
															if (!enumerator7.MoveNext())
															{
																num145 = -182086383;
																num146 = num145;
															}
															else
															{
																num145 = -2078449748;
																num146 = num145;
															}
															while (true)
															{
																switch ((num2 = (uint)(num145 ^ -271918113)) % 14)
																{
																case 7u:
																	num145 = -2078449748;
																	continue;
																default:
																	goto end_IL_1799;
																case 3u:
																{
																	int num149;
																	if (sprite.Team == Field.currentSprite.Team)
																	{
																		num145 = -50493553;
																		num149 = num145;
																	}
																	else
																	{
																		num145 = -913070875;
																		num149 = num145;
																	}
																	continue;
																}
																case 9u:
																{
																	int num150;
																	int num151;
																	if ((Object)(object)sprite == (Object)(object)Field.currentSprite)
																	{
																		num150 = -704140306;
																		num151 = num150;
																	}
																	else
																	{
																		num150 = -1279288422;
																		num151 = num150;
																	}
																	num145 = num150 ^ ((int)num2 * -1443586141);
																	continue;
																}
																case 5u:
																{
																	int num154;
																	int num155;
																	if (!list4.Contains(current14))
																	{
																		num154 = 1020994975;
																		num155 = num154;
																	}
																	else
																	{
																		num154 = 981058273;
																		num155 = num154;
																	}
																	num145 = num154 ^ (int)(num2 * 1416968324);
																	continue;
																}
																case 12u:
																	break;
																case 4u:
																	num143 += (double)attackResult.Hp;
																	num145 = (int)((num2 * 1585271004) ^ 0x4ABB249A);
																	continue;
																case 11u:
																	current14 = enumerator7.Current;
																	num145 = -1864317762;
																	continue;
																case 6u:
																	list4.Add(current14);
																	num145 = ((int)num2 * -1026788017) ^ -119133432;
																	continue;
																case 10u:
																{
																	int num156;
																	int num157;
																	if (RuntimeData.Instance.FriendlyFire)
																	{
																		num156 = 1016072639;
																		num157 = num156;
																	}
																	else
																	{
																		num156 = 2026192037;
																		num157 = num156;
																	}
																	num145 = num156 ^ ((int)num2 * -418324556);
																	continue;
																}
																case 8u:
																{
																	attackResult = attackResultCache.GetAttackResult(current11, sprite);
																	int num152;
																	int num153;
																	if (sprite.Team == Field.currentSprite.Team)
																	{
																		num152 = 2097341642;
																		num153 = num152;
																	}
																	else
																	{
																		num152 = 1278684019;
																		num153 = num152;
																	}
																	num145 = num152 ^ ((int)num2 * -1070118475);
																	continue;
																}
																case 13u:
																{
																	sprite = Field.GetSprite(current14.X, current14.Y);
																	int num147;
																	int num148;
																	if ((Object)(object)sprite == (Object)null)
																	{
																		num147 = -885053003;
																		num148 = num147;
																	}
																	else
																	{
																		num147 = -1071579146;
																		num148 = num147;
																	}
																	num145 = num147 ^ (int)(num2 * 1940369392);
																	continue;
																}
																case 1u:
																	num145 = (int)((num2 * 1192810836) ^ 0x1E7AB561);
																	continue;
																case 2u:
																	num143 -= (double)(attackResult.Hp / 2);
																	num145 = (int)((num2 * 1668601411) ^ 0x2C3D8285);
																	continue;
																case 0u:
																	goto end_IL_1799;
																}
																goto IL_186a;
																continue;
																end_IL_1799:
																break;
															}
															break;
														}
													}
													if (!(num143 > num138))
													{
														continue;
													}
													goto IL_19d2;
												}
												int num158 = -467440753;
												goto IL_19d7;
												IL_19d2:
												num158 = -134220139;
												goto IL_19d7;
												IL_19d7:
												while (true)
												{
													switch ((num2 = (uint)(num158 ^ -271918113)) % 9)
													{
													case 8u:
														break;
													default:
														goto end_IL_1a60;
													case 0u:
														aIResult.AttackX = current13.X;
														num158 = ((int)num2 * -2140883699) ^ -50253857;
														continue;
													case 3u:
														aIResult.MoveY = y2;
														num158 = (int)(num2 * 624482742) ^ -448047375;
														continue;
													case 2u:
														aIResult.IsRest = false;
														num158 = ((int)num2 * -1876277026) ^ 0x2570B6B5;
														continue;
													case 4u:
														goto IL_1a60;
													case 6u:
														aIResult.skill = current11;
														num158 = ((int)num2 * -1448920332) ^ -1195497543;
														continue;
													case 1u:
														aIResult.MoveX = x2;
														num158 = (int)(num2 * 1766075155) ^ -1335276011;
														continue;
													case 7u:
														aIResult.AttackY = current13.Y;
														num138 = num143;
														num158 = (int)(num2 * 1958779801) ^ -2131614096;
														continue;
													case 5u:
														goto end_IL_1a60;
													}
													break;
												}
												goto IL_19d2;
												continue;
												end_IL_1a60:
												break;
											}
										}
										now = DateTime.Now;
										goto IL_1b03;
									}
									int num159 = -674898626;
									goto IL_1b08;
									IL_1b08:
									while (true)
									{
										switch ((num2 = (uint)(num159 ^ -271918113)) % 10)
										{
										case 6u:
											break;
										default:
											goto end_IL_1c1b;
										case 3u:
										{
											int num164;
											int num165;
											if (aIResult.skill != null)
											{
												num164 = -624576761;
												num165 = num164;
											}
											else
											{
												num164 = -1176289262;
												num165 = num164;
											}
											num159 = num164 ^ ((int)num2 * -1378863561);
											continue;
										}
										case 5u:
											goto end_IL_1c1b;
										case 8u:
										{
											int num162;
											int num163;
											if (timeSpan.TotalSeconds < 0.4)
											{
												num162 = 951606779;
												num163 = num162;
											}
											else
											{
												num162 = 1564439058;
												num163 = num162;
											}
											num159 = num162 ^ (int)(num2 * 758733367);
											continue;
										}
										case 9u:
										{
											int num160;
											int num161;
											if (!Tools.ProbabilityTest(0.7))
											{
												num160 = -406205311;
												num161 = num160;
											}
											else
											{
												num160 = -1405689031;
												num161 = num160;
											}
											num159 = num160 ^ (int)(num2 * 1847982346);
											continue;
										}
										case 1u:
											timeSpan = new TimeSpan(now.Ticks).Subtract(ts);
											num159 = (int)((num2 * 69688945) ^ 0x76D687C2);
											continue;
										case 4u:
											goto IL_1c04;
										case 2u:
											goto IL_1c1b;
										case 0u:
											goto end_IL_1c1b;
										case 7u:
											goto end_IL_1c1b;
										}
										break;
										IL_1c04:
										int num166;
										if (!isTrainingMode)
										{
											num159 = -1108128757;
											num166 = num159;
										}
										else
										{
											num159 = -1912310800;
											num166 = num159;
										}
									}
									goto IL_1b03;
									IL_1b03:
									num159 = -244008450;
									goto IL_1b08;
									continue;
									end_IL_1c1b:
									break;
								}
							}
							RuntimeData.Instance.isAttackAnalog = false;
							goto IL_1c61;
							IL_1c66:
							int num167;
							while (true)
							{
								switch ((num2 = (uint)(num167 ^ -271918113)) % 5)
								{
								case 0u:
									break;
								case 4u:
									goto IL_1c8c;
								case 3u:
									num18 = int.MaxValue;
									battleSprite = null;
									num167 = -1055723079;
									continue;
								case 2u:
									return aIResult;
								default:
									goto IL_1cc8;
								}
								break;
							}
							goto IL_1c61;
							IL_15a3:
							int num168;
							if (list3.Count < 20)
							{
								num135 = -612884397;
								num168 = num135;
							}
							else
							{
								num135 = -1055760286;
								num168 = num135;
							}
							continue;
							IL_14e8:
							if (!flag)
							{
								num135 = ((int)num2 * -1424020952) ^ -1631471699;
								continue;
							}
							goto IL_1c8c;
							IL_1c61:
							num167 = -1342873072;
							goto IL_1c66;
							IL_1534:
							int num169;
							if (Field.currentSprite.Team == 1)
							{
								num135 = -1254913804;
								num169 = num135;
							}
							else
							{
								num135 = -1439218400;
								num169 = num135;
							}
							continue;
							IL_1c8c:
							int num170;
							if (aIResult.skill != null)
							{
								num167 = -848891525;
								num170 = num167;
							}
							else
							{
								num167 = -836460231;
								num170 = num167;
							}
							goto IL_1c66;
						}
						goto IL_13eb;
						IL_1501:
						int num171;
						if (list.Count > 0)
						{
							num135 = -2092328648;
							num171 = num135;
						}
						else
						{
							num135 = -458588420;
							num171 = num135;
						}
						goto IL_13f0;
						IL_13eb:
						num135 = -615368114;
						goto IL_13f0;
						IL_043a:
						if (!isTrainingMode)
						{
							num63 = ((int)num2 * -689571510) ^ -240913251;
							continue;
						}
						goto IL_0e3a;
						IL_0df5:
						int num172 = -130992655;
						goto IL_0dfa;
						IL_0e3a:
						skillBox3 = null;
						num172 = -1784052094;
						goto IL_0dfa;
						IL_0dfa:
						while (true)
						{
							switch ((num2 = (uint)(num172 ^ -271918113)) % 5)
							{
							case 0u:
								break;
							case 3u:
								list2.Remove(skillBox2);
								num172 = ((int)num2 * -65165863) ^ 0x56507B30;
								continue;
							case 1u:
								goto IL_0e3a;
							default:
								goto IL_0e59;
							case 4u:
								goto IL_1501;
							}
							break;
						}
						goto IL_0df5;
					}
					goto IL_0407;
				}
				break;
			}
		}
	}

	public List<LocationBlock> GetMoveRange2(BattleSprite currentSprite)
	{
		List<LocationBlock> list = new List<LocationBlock>();
		Queue<MoveSearchHelper> queue = default(Queue<MoveSearchHelper>);
		bool flag2 = default(bool);
		int x = default(int);
		int y = default(int);
		int cost = default(int);
		bool flag = default(bool);
		int moveAbility = default(int);
		LocationBlock current = default(LocationBlock);
		int num15 = default(int);
		int num12 = default(int);
		int num16 = default(int);
		int num9 = default(int);
		BattleSprite sprite = default(BattleSprite);
		int num17 = default(int);
		int x2 = default(int);
		while (true)
		{
			int num = 1825807327;
			while (true)
			{
				int num8;
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2814E1F5)) % 10)
				{
				case 3u:
					break;
				case 6u:
					queue = new Queue<MoveSearchHelper>();
					queue.Enqueue(new MoveSearchHelper
					{
						X = currentSprite.X,
						Y = currentSprite.Y,
						Cost = 0
					});
					flag2 = currentSprite.Role.BuiltInTalents[19];
					num = ((int)num2 * -2058518394) ^ 0x48C83D2E;
					continue;
				case 2u:
				{
					MoveSearchHelper moveSearchHelper = queue.Dequeue();
					x = moveSearchHelper.X;
					y = moveSearchHelper.Y;
					cost = moveSearchHelper.Cost;
					num = 627642052;
					continue;
				}
				case 9u:
				{
					int num25;
					int num26;
					if (Field.isRemoveBlock(x, y))
					{
						num25 = 936335820;
						num26 = num25;
					}
					else
					{
						num25 = 536314258;
						num26 = num25;
					}
					num = num25 ^ ((int)num2 * -322992041);
					continue;
				}
				case 0u:
					if (!flag)
					{
						num = 40594082;
						continue;
					}
					goto IL_0231;
				case 4u:
					flag = true;
					num = (int)(num2 * 1262727439) ^ -173824777;
					continue;
				case 7u:
					moveAbility = currentSprite.MoveAbility;
					num = ((int)num2 * -130837285) ^ -1503041844;
					continue;
				case 1u:
					flag = false;
					num = ((int)num2 * -312253040) ^ 0x6A5899FC;
					continue;
				default:
				{
					using (List<LocationBlock>.Enumerator enumerator = list.GetEnumerator())
					{
						while (true)
						{
							IL_01b7:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 1671455574;
								num4 = num3;
							}
							else
							{
								num3 = 440216796;
								num4 = num3;
							}
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ 0x2814E1F5)) % 6)
								{
								case 0u:
									num3 = 440216796;
									continue;
								default:
									goto end_IL_0172;
								case 2u:
									flag = true;
									goto end_IL_0172;
								case 4u:
									break;
								case 1u:
								{
									current = enumerator.Current;
									int num7;
									if (current.X != x)
									{
										num3 = 1224379451;
										num7 = num3;
									}
									else
									{
										num3 = 16634076;
										num7 = num3;
									}
									continue;
								}
								case 3u:
								{
									int num5;
									int num6;
									if (current.Y == y)
									{
										num5 = -851745845;
										num6 = num5;
									}
									else
									{
										num5 = -951324505;
										num6 = num5;
									}
									num3 = num5 ^ ((int)num2 * -265937092);
									continue;
								}
								case 5u:
									goto end_IL_0172;
								}
								goto IL_01b7;
								continue;
								end_IL_0172:
								break;
							}
							break;
						}
					}
					goto IL_0231;
				}
				case 8u:
					goto IL_0412;
					IL_0231:
					if (!flag)
					{
						goto IL_0238;
					}
					goto IL_0412;
					IL_0412:
					if (queue.Count > 0)
					{
						goto case 2u;
					}
					num8 = 1987972628;
					goto IL_023d;
					IL_023d:
					while (true)
					{
						switch ((num2 = (uint)(num8 ^ 0x2814E1F5)) % 21)
						{
						case 12u:
							break;
						case 18u:
						{
							int num20;
							int num21;
							if (!flag2)
							{
								num20 = -1886151751;
								num21 = num20;
							}
							else
							{
								num20 = -1206243119;
								num21 = num20;
							}
							num8 = num20 ^ ((int)num2 * -1982360047);
							continue;
						}
						case 16u:
							goto IL_02c7;
						case 11u:
							list.Add(new LocationBlock
							{
								X = x,
								Y = y
							});
							num8 = ((int)num2 * -384069658) ^ -1555068962;
							continue;
						case 17u:
							num15 = x + directionX[num12];
							num16 = y + directionY[num12];
							num9 = 1;
							num8 = 258566043;
							continue;
						case 7u:
						{
							int num13;
							int num14;
							if (_206E_206D_202B_202E_206D_200F_206B_200B_200C_206E_206F_206E_206C_206C_200F_202E_200F_206E_200E_206C_206A_206B_206F_200C_206A_206D_202A_206F_200C_200E_206C_206D_200B_206F_200F_206E_206E_206D_206F_202C_202E((Object)(object)sprite, (Object)null))
							{
								num13 = -1802869073;
								num14 = num13;
							}
							else
							{
								num13 = -273359958;
								num14 = num13;
							}
							num8 = num13 ^ ((int)num2 * -2015227737);
							continue;
						}
						case 3u:
							num12 = 0;
							num8 = (int)((num2 * 1832722698) ^ 0x289264AD);
							continue;
						case 4u:
							queue.Enqueue(new MoveSearchHelper
							{
								X = num15,
								Y = num16,
								Cost = cost + num9
							});
							num8 = ((int)num2 * -566689857) ^ 0x7D0491A7;
							continue;
						case 14u:
						{
							int num18;
							int num19;
							if (sprite.Team != currentSprite.Team)
							{
								num18 = -1908336062;
								num19 = num18;
							}
							else
							{
								num18 = -712395287;
								num19 = num18;
							}
							num8 = num18 ^ ((int)num2 * -1714387536);
							continue;
						}
						case 8u:
							num17++;
							num8 = 447325064;
							continue;
						case 15u:
							num9 = 2;
							num8 = ((int)num2 * -1935931175) ^ -1376109072;
							continue;
						case 20u:
							num8 = ((int)num2 * -991372154) ^ 0x353C33AD;
							continue;
						case 5u:
							goto IL_0412;
						case 2u:
							x2 = num15 + directionX[num17];
							num8 = 2003660957;
							continue;
						case 13u:
							num17 = 0;
							num8 = ((int)num2 * -143895217) ^ -1008378858;
							continue;
						case 6u:
						{
							int y2 = num16 + directionY[num17];
							sprite = Field.GetSprite(x2, y2);
							num8 = ((int)num2 * -546427527) ^ -1868930168;
							continue;
						}
						case 0u:
							goto IL_0488;
						case 19u:
							goto IL_04a8;
						case 9u:
							num12++;
							num8 = 266192265;
							continue;
						case 1u:
						{
							int num10;
							int num11;
							if (cost + num9 > moveAbility)
							{
								num10 = 292129187;
								num11 = num10;
							}
							else
							{
								num10 = 366196337;
								num11 = num10;
							}
							num8 = num10 ^ (int)(num2 * 478161293);
							continue;
						}
						default:
							return list;
						}
						break;
						IL_04a8:
						int num22;
						if (num17 >= 4)
						{
							num8 = 1214665119;
							num22 = num8;
						}
						else
						{
							num8 = 724347112;
							num22 = num8;
						}
						continue;
						IL_0488:
						int num23;
						if (IsEmptyBlock(num15, num16))
						{
							num8 = 923458593;
							num23 = num8;
						}
						else
						{
							num8 = 82217063;
							num23 = num8;
						}
						continue;
						IL_02c7:
						int num24;
						if (num12 >= 4)
						{
							num8 = 1180964819;
							num24 = num8;
						}
						else
						{
							num8 = 447343048;
							num24 = num8;
						}
					}
					goto IL_0238;
					IL_0238:
					num8 = 872431481;
					goto IL_023d;
				}
				break;
			}
		}
	}

	static bool _206E_206D_202B_202E_206D_200F_206B_200B_200C_206E_206F_206E_206C_206C_200F_202E_200F_206E_200E_206C_206A_206B_206F_200C_206A_206D_202A_206F_200C_200E_206C_206D_200B_206F_200F_206E_206E_206D_206F_202C_202E(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static bool _200B_202B_202D_200C_200F_206B_202C_200C_206C_206E_200D_206C_202B_206A_206E_202A_206F_200C_202C_200C_206A_202C_206B_202A_200C_206A_202B_206A_200C_202C_200C_206E_202A_202A_200C_202A_206D_200F_202A_202A_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static int _200D_206C_206C_200F_206D_200D_202B_202E_202A_202C_200C_206E_202C_206D_200F_202A_206D_200C_202C_200F_202D_202E_202A_200F_206B_206C_202B_202D_206F_202D_200B_202E_202A_202A_200F_206C_200C_202D_206E_206F_202E(int P_0)
	{
		return Math.Abs(P_0);
	}

	static bool _200F_202C_202A_202D_202B_202E_202C_200D_206D_206B_202C_202D_200D_202B_206F_200E_206A_202D_202D_202B_206C_202B_206A_200C_206D_206A_202D_202D_206A_202D_206D_206B_206A_202C_200F_206A_202C_200B_202E_202D_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _200E_206E_200E_200F_206E_206F_200E_202A_206F_206F_206F_202A_200B_202D_202B_206C_206F_200F_206F_206F_206B_200C_200F_202B_202C_206B_206E_206F_200D_202E_206F_202C_202C_202D_202E_202C_200D_202A_206F_206E_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}
}
