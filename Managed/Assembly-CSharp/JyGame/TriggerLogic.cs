using System;
using System.Collections.Generic;
using UnityEngine;

namespace JyGame;

public class TriggerLogic
{
	private static List<string> luaExtensionConditions;

	static TriggerLogic()
	{
	}

	public static bool judge(Condition condition)
	{
		if (!_206C_200C_200D_206C_206D_206F_202E_200B_202A_206F_206C_206B_206F_200F_202D_206F_202D_202B_206D_200F_202B_200B_202A_206D_206A_206E_200D_206A_200C_202A_206D_206F_200E_200C_206A_206C_200F_200D_202C_202B_202E(condition.type))
		{
			bool flag = default(bool);
			string[] array = default(string[]);
			int num7 = default(int);
			string[] array2 = default(string[]);
			int number = default(int);
			string[] array3 = default(string[]);
			while (true)
			{
				int num = -1863630637;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -392397865)) % 25)
					{
					case 6u:
						break;
					case 13u:
						flag = judgeCondition(new Condition
						{
							type = array[num7],
							value = array2[num7],
							number = number
						});
						num = -834019995;
						continue;
					case 9u:
						array = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.type, new char[1] { '|' });
						num = (int)((num2 * 449864007) ^ 0x4037844F);
						continue;
					case 14u:
						return false;
					case 4u:
						number = int.Parse(array3[num7]);
						num = (int)((num2 * 213395327) ^ 0x5745D5DF);
						continue;
					case 15u:
						array2 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '|' });
						num = ((int)num2 * -110822674) ^ -1850046954;
						continue;
					case 0u:
						goto IL_0145;
					case 8u:
						num7++;
						num = -50149457;
						continue;
					case 17u:
						array3 = condition.number.ToString().Split('|');
						num = ((int)num2 * -1709621483) ^ -1835048942;
						continue;
					case 10u:
					{
						int num5;
						int num6;
						if (array.Length <= 1)
						{
							num5 = 1446856249;
							num6 = num5;
						}
						else
						{
							num5 = 2088823068;
							num6 = num5;
						}
						num = num5 ^ (int)(num2 * 152104530);
						continue;
					}
					case 5u:
						return true;
					case 20u:
						return !judgeCondition(new Condition
						{
							type = condition.type.Substring(1, condition.type.Length - 1),
							value = condition.value,
							number = condition.number
						});
					case 11u:
					{
						int num10;
						int num11;
						if (array3.Length < num7 + 1)
						{
							num10 = 1417506287;
							num11 = num10;
						}
						else
						{
							num10 = 1260045083;
							num11 = num10;
						}
						num = num10 ^ ((int)num2 * -630154942);
						continue;
					}
					case 2u:
						flag = false;
						number = -1;
						num = -1288300742;
						continue;
					case 23u:
						num7 = 0;
						num = ((int)num2 * -1733026089) ^ -1877011460;
						continue;
					case 22u:
						goto IL_0274;
					case 3u:
					{
						int num8;
						int num9;
						if (array.Length == array2.Length)
						{
							num8 = 349499316;
							num9 = num8;
						}
						else
						{
							num8 = 1276356427;
							num9 = num8;
						}
						num = num8 ^ (int)(num2 * 1919642686);
						continue;
					}
					case 18u:
						goto IL_02b3;
					case 16u:
						flag = !judgeCondition(new Condition
						{
							type = array[num7].Substring(1, array[num7].Length - 1),
							value = array2[num7],
							number = number
						});
						num = (int)((num2 * 1587030385) ^ 0x53FD76A8);
						continue;
					case 12u:
					{
						int num3;
						int num4;
						if (condition.value == null)
						{
							num3 = -1306988640;
							num4 = num3;
						}
						else
						{
							num3 = -1143201507;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 1917930881);
						continue;
					}
					case 19u:
						num = (int)(num2 * 1923530584) ^ -334597555;
						continue;
					case 7u:
						goto end_IL_0010;
					case 21u:
						goto IL_036b;
					case 1u:
						goto IL_0396;
					default:
						return judgeCondition(condition);
					}
					break;
					IL_0396:
					int num12;
					if (_200F_200E_206B_202A_206B_200B_202E_206A_202D_202C_200B_206D_206F_202A_206A_206F_202D_202B_200E_200F_202A_202B_200D_202D_206A_206B_202C_202D_206A_202E_206C_206E_206D_202A_206F_200D_206D_202E_206D_206B_202E(condition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2876438784u)))
					{
						num = -707375838;
						num12 = num;
					}
					else
					{
						num = -769645033;
						num12 = num;
					}
					continue;
					IL_0145:
					int num13;
					if (!flag)
					{
						num = -1151647452;
						num13 = num;
					}
					else
					{
						num = -1393353102;
						num13 = num;
					}
					continue;
					IL_02b3:
					int num14;
					if (!array[num7].StartsWith(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4080104489u)))
					{
						num = -1933068326;
						num14 = num;
					}
					else
					{
						num = -1660798265;
						num14 = num;
					}
					continue;
					IL_036b:
					int num15;
					if (condition.type.StartsWith(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(887725519u)))
					{
						num = -623578849;
						num15 = num;
					}
					else
					{
						num = -310631180;
						num15 = num;
					}
					continue;
					IL_0274:
					int num16;
					if (num7 >= array.Length)
					{
						num = -1366222210;
						num16 = num;
					}
					else
					{
						num = -1824528666;
						num16 = num;
					}
				}
				continue;
				end_IL_0010:
				break;
			}
		}
		return false;
	}

	public static bool judgeCondition(Condition condition)
	{
		bool result = default(bool);
		if (luaExtensionConditions != null)
		{
			try
			{
				if (luaExtensionConditions.Contains(condition.type))
				{
					while (true)
					{
						uint num;
						switch ((num = 1889848700u) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_0019;
						case 2u:
							result = LuaManager.Call<bool>(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(94174256u), new object[1] { condition });
							return result;
						case 1u:
							goto end_IL_0019;
						}
						continue;
						end_IL_0019:
						break;
					}
				}
			}
			catch
			{
			}
		}
		if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3578328800u)))
		{
			goto IL_008e;
		}
		goto IL_5e66;
		IL_5e66:
		int num2;
		int num3;
		if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3702674158u)))
		{
			num2 = -633160472;
			num3 = num2;
		}
		else
		{
			num2 = -1682526422;
			num3 = num2;
		}
		goto IL_0093;
		IL_d18f:
		Role role3 = default(Role);
		Role role2 = default(Role);
		int num21 = default(int);
		string[] array3 = default(string[]);
		int num50 = default(int);
		string[] array6 = default(string[]);
		string[] array5 = default(string[]);
		int num31 = default(int);
		int num30 = default(int);
		string[] array = default(string[]);
		string[] array7 = default(string[]);
		string[] array8 = default(string[]);
		string[] array2 = default(string[]);
		string[] array4 = default(string[]);
		int num13 = default(int);
		Role role4 = default(Role);
		IEnumerator<Role> enumerator = default(IEnumerator<Role>);
		Role role = default(Role);
		Role current = default(Role);
		string[] array11 = default(string[]);
		bool result3 = default(bool);
		int num75 = default(int);
		Role teamRole2 = default(Role);
		string[] array9 = default(string[]);
		DateTime date = default(DateTime);
		string s = default(string);
		Role teamRole = default(Role);
		int num83 = default(int);
		int num78 = default(int);
		bool result2 = default(bool);
		string[] array10 = default(string[]);
		while (true)
		{
			int num4;
			int num5;
			if (!(condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3751044794u)))
			{
				num4 = -690681013;
				num5 = num4;
			}
			else
			{
				num4 = -142523167;
				num5 = num4;
			}
			while (true)
			{
				int num71;
				int num72;
				uint num;
				switch ((num = (uint)(num4 ^ -1375790662)) % 130)
				{
				case 84u:
					num4 = -146477484;
					continue;
				case 94u:
					role3 = RuntimeData.Instance.Team[0];
					num4 = (int)((num * 122045115) ^ 0x3221D506);
					continue;
				case 108u:
					role2 = null;
					num4 = -655438657;
					continue;
				case 36u:
				{
					int num22;
					int num23;
					if (RuntimeData.Instance.VerifiedRealTimeFlagOk(num21))
					{
						num22 = 556653776;
						num23 = num22;
					}
					else
					{
						num22 = 1749908809;
						num23 = num22;
					}
					num4 = num22 ^ ((int)num * -32774735);
					continue;
				}
				case 24u:
					num4 = ((int)num * -862304739) ^ -134119936;
					continue;
				case 74u:
					num4 = (int)(num * 1050294850) ^ -1203013166;
					continue;
				case 54u:
					num4 = ((int)num * -416711358) ^ 0x50269AE9;
					continue;
				case 116u:
				{
					int num69;
					int num70;
					if (array3.Length < 2)
					{
						num69 = -1989086033;
						num70 = num69;
					}
					else
					{
						num69 = -1708956917;
						num70 = num69;
					}
					num4 = num69 ^ ((int)num * -880087501);
					continue;
				}
				case 68u:
					num4 = ((int)num * -258548399) ^ -1076747237;
					continue;
				case 9u:
					num50 = 1;
					num4 = (int)((num * 690413819) ^ 0x53C54CC2);
					continue;
				case 114u:
					num4 = ((int)num * -1712449178) ^ 0x23A1583E;
					continue;
				case 5u:
					array6 = condition.value.Split('#');
					num4 = ((int)num * -575560777) ^ -1896549170;
					continue;
				case 106u:
					array5 = condition.value.Split('#');
					num4 = ((int)num * -887638196) ^ -399545819;
					continue;
				case 75u:
					return true;
				case 91u:
					num4 = (int)(num * 268417252) ^ -375302106;
					continue;
				case 1u:
					num4 = ((int)num * -2342041) ^ -1701711075;
					continue;
				case 52u:
					num31 = -1;
					num4 = (int)(num * 1908700860) ^ -1319452700;
					continue;
				case 86u:
					num30 = int.Parse(array[1]);
					num4 = (int)((num * 1555057145) ^ 0x16534178);
					continue;
				case 70u:
					num4 = (int)(num * 1850984653) ^ -2072691433;
					continue;
				case 73u:
					num4 = ((int)num * -1832498328) ^ -1897724663;
					continue;
				case 64u:
					array7 = condition.value.Split('#');
					num4 = ((int)num * -767224900) ^ 0x155C03BA;
					continue;
				case 14u:
					return RuntimeData.Instance.GetBattleLoseCount(array8[0]) >= int.Parse(array8[1]);
				case 38u:
					return RuntimeData.Instance.GetBattleCount(array2[0]) >= int.Parse(array2[1]);
				case 102u:
					role3 = RuntimeData.Instance.GetRole(array4[0]);
					num4 = -332563025;
					continue;
				case 88u:
					num4 = ((int)num * -2028622397) ^ -1430158424;
					continue;
				case 7u:
					num4 = (int)(num * 1837089384) ^ -958736696;
					continue;
				case 59u:
				{
					int num28;
					int num29;
					if (num21 > 49)
					{
						num28 = -1364863667;
						num29 = num28;
					}
					else
					{
						num28 = -846965250;
						num29 = num28;
					}
					num4 = num28 ^ (int)(num * 888451280);
					continue;
				}
				case 65u:
					return RuntimeData.Instance.GetBattleCount() >= int.Parse(array2[0]);
				case 58u:
				{
					int num73;
					int num74;
					if (RuntimeData.Instance.GetRealTimeFlagInterval(num21) >= double.Parse(array3[1]))
					{
						num73 = -1071709786;
						num74 = num73;
					}
					else
					{
						num73 = -58135615;
						num74 = num73;
					}
					num4 = num73 ^ (int)(num * 811531650);
					continue;
				}
				case 67u:
				{
					int num68;
					if (array.Length >= 2)
					{
						num4 = -1857104034;
						num68 = num4;
					}
					else
					{
						num4 = -70401531;
						num68 = num4;
					}
					continue;
				}
				case 29u:
					num13 = int.Parse(array7[0]);
					num4 = (int)(num * 1556627679) ^ -1077969071;
					continue;
				case 76u:
					num4 = ((int)num * -332095730) ^ 0x26D9611D;
					continue;
				case 113u:
					array = condition.value.Split('#');
					num4 = (int)((num * 1578616854) ^ 0x8B514F2);
					continue;
				case 82u:
					num4 = (int)(num * 1985995749) ^ -489743463;
					continue;
				case 10u:
					num4 = ((int)num * -425237306) ^ 0x2034C192;
					continue;
				case 117u:
					num21 = int.Parse(array3[0]);
					num4 = (int)(num * 231690537) ^ -1037179138;
					continue;
				case 100u:
					array4 = condition.value.Split('#');
					num4 = (int)((num * 167101832) ^ 0x4B0A5B44);
					continue;
				case 120u:
				{
					int num60;
					int num61;
					if (array6.Length >= 1)
					{
						num60 = -1927718723;
						num61 = num60;
					}
					else
					{
						num60 = -1401711056;
						num61 = num60;
					}
					num4 = num60 ^ ((int)num * -646576605);
					continue;
				}
				case 121u:
					num4 = (int)((num * 1749659314) ^ 0x5D7C69C6);
					continue;
				case 30u:
					role3 = null;
					num4 = -373277506;
					continue;
				case 4u:
					return false;
				case 57u:
				{
					int num53;
					int num54;
					if (array7.Length == 1)
					{
						num53 = 331396926;
						num54 = num53;
					}
					else
					{
						num53 = 1977052604;
						num54 = num53;
					}
					num4 = num53 ^ (int)(num * 1754013904);
					continue;
				}
				case 66u:
					num4 = (int)((num * 913003858) ^ 0x1A0518C8);
					continue;
				case 15u:
					num50 = 0;
					num4 = ((int)num * -619932733) ^ -108912368;
					continue;
				case 99u:
					num4 = (int)((num * 969888187) ^ 0x65B1249E);
					continue;
				case 17u:
					num50 = int.Parse(array5[1]);
					num4 = ((int)num * -1759755061) ^ -2737341;
					continue;
				case 111u:
					return false;
				case 125u:
				{
					int num46;
					int num47;
					if (role4 == null)
					{
						num46 = 397938332;
						num47 = num46;
					}
					else
					{
						num46 = 1002709954;
						num47 = num46;
					}
					num4 = num46 ^ (int)(num * 1022637208);
					continue;
				}
				case 19u:
					return false;
				case 101u:
					num31 = int.Parse(array4[0]);
					num4 = (int)(num * 776242555) ^ -1090668616;
					continue;
				case 51u:
				{
					int num41;
					if (array6.Length >= 2)
					{
						num4 = -535370188;
						num41 = num4;
					}
					else
					{
						num4 = -1892687766;
						num41 = num4;
					}
					continue;
				}
				case 124u:
				{
					int num38;
					int num39;
					if (role2 == null)
					{
						num38 = 1116387965;
						num39 = num38;
					}
					else
					{
						num38 = 1275541190;
						num39 = num38;
					}
					num4 = num38 ^ (int)(num * 1872627654);
					continue;
				}
				case 40u:
				{
					int num34;
					if (role4 != null)
					{
						num4 = -1275229679;
						num34 = num4;
					}
					else
					{
						num4 = -1063252219;
						num34 = num4;
					}
					continue;
				}
				case 49u:
				{
					int num26;
					int num27;
					if (array.Length != 1)
					{
						num26 = -658436969;
						num27 = num26;
					}
					else
					{
						num26 = -740507761;
						num27 = num26;
					}
					num4 = num26 ^ (int)(num * 1699412090);
					continue;
				}
				case 83u:
				{
					int num18;
					int num19;
					if (!string.IsNullOrEmpty(array3[0]))
					{
						num18 = 1833535226;
						num19 = num18;
					}
					else
					{
						num18 = 1306511672;
						num19 = num18;
					}
					num4 = num18 ^ ((int)num * -1230555593);
					continue;
				}
				case 12u:
					role2 = RuntimeData.Instance.Team[0];
					num4 = ((int)num * -616008941) ^ 0x27C37899;
					continue;
				case 50u:
				{
					int num16;
					if (!(condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2263670833u)))
					{
						num4 = -823492874;
						num16 = num4;
					}
					else
					{
						num4 = -791128733;
						num16 = num4;
					}
					continue;
				}
				case 6u:
					role2 = RuntimeData.Instance.GetRole(array7[0]);
					num4 = -943790811;
					continue;
				case 56u:
					num4 = ((int)num * -1593768990) ^ -475398251;
					continue;
				case 22u:
					num4 = ((int)num * -168247330) ^ 0x33146F50;
					continue;
				case 103u:
					num30 = 1;
					num4 = (int)(num * 570166651) ^ -1355524244;
					continue;
				case 81u:
					num4 = (int)(num * 2075220731) ^ -535708529;
					continue;
				case 18u:
					RuntimeData.Instance.RemoveVerifiedRealTimeFlags(num21);
					return true;
				case 119u:
				{
					int num105;
					if (!(condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(617207906u)))
					{
						num4 = -1883233492;
						num105 = num4;
					}
					else
					{
						num4 = -359673552;
						num105 = num4;
					}
					continue;
				}
				case 118u:
					num4 = ((int)num * -1934320725) ^ 0x740E7A7D;
					continue;
				case 77u:
					array2 = condition.value.Split('#');
					num4 = (int)(num * 977120962) ^ -48944549;
					continue;
				case 62u:
					return RuntimeData.Instance.GetBattleLoseCount() >= int.Parse(array8[0]);
				case 96u:
					array8 = condition.value.Split('#');
					num4 = (int)(num * 1855168799) ^ -991212293;
					continue;
				case 69u:
					if (condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1222766763u))
					{
						num4 = -1838091527;
						continue;
					}
					goto IL_dc42;
				case 31u:
					num4 = (int)(num * 112864221) ^ -966102761;
					continue;
				case 63u:
					role4 = RuntimeData.Instance.GetRole(array5[0]);
					num4 = -334121861;
					continue;
				case 85u:
					num4 = ((int)num * -560695189) ^ 0x1450ACBE;
					continue;
				case 26u:
					return false;
				case 47u:
				{
					int num67;
					if (role3 == null)
					{
						num4 = -911637784;
						num67 = num4;
					}
					else
					{
						num4 = -59320801;
						num67 = num4;
					}
					continue;
				}
				case 128u:
					num4 = ((int)num * -1961749943) ^ -1587572759;
					continue;
				case 79u:
				{
					int num65;
					int num66;
					if (role3 == null)
					{
						num65 = -1696264632;
						num66 = num65;
					}
					else
					{
						num65 = -1540658160;
						num66 = num65;
					}
					num4 = num65 ^ ((int)num * -2029200928);
					continue;
				}
				case 110u:
					enumerator = ResourceManager.GetAll<Role>().GetEnumerator();
					num4 = (int)(num * 555318341) ^ -1173596925;
					continue;
				case 107u:
					return false;
				case 42u:
					num13 = int.Parse(array7[1]);
					num4 = -515624593;
					continue;
				case 98u:
					role3 = ResourceManager.Get<Role>(array4[0]);
					num4 = (int)((num * 1508830594) ^ 0x36E8D2D4);
					continue;
				case 0u:
				{
					int num63;
					int num64;
					if (array8.Length < 1)
					{
						num63 = 1544605770;
						num64 = num63;
					}
					else
					{
						num63 = 984898895;
						num64 = num63;
					}
					num4 = num63 ^ ((int)num * -1885698688);
					continue;
				}
				case 43u:
					return true;
				case 109u:
				{
					int num62;
					if (array5.Length < 2)
					{
						num4 = -2127739477;
						num62 = num4;
					}
					else
					{
						num4 = -1253627051;
						num62 = num4;
					}
					continue;
				}
				case 2u:
					return RuntimeData.Instance.GetBattleWinCount(array6[0]) >= int.Parse(array6[1]);
				case 53u:
					num4 = (int)(num * 1523054314) ^ -868236210;
					continue;
				case 78u:
					num31 = int.Parse(array4[1]);
					num4 = -1801296598;
					continue;
				case 87u:
				{
					int num58;
					int num59;
					if (role2.character == num13)
					{
						num58 = 2095667094;
						num59 = num58;
					}
					else
					{
						num58 = 737517844;
						num59 = num58;
					}
					num4 = num58 ^ ((int)num * -108327627);
					continue;
				}
				case 34u:
				{
					int num57;
					if (condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(95872724u))
					{
						num4 = -210894904;
						num57 = num4;
					}
					else
					{
						num4 = -1850729578;
						num57 = num4;
					}
					continue;
				}
				case 37u:
					num4 = ((int)num * -1750527944) ^ 0x53D95F2A;
					continue;
				case 35u:
				{
					int num55;
					int num56;
					if (role4.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3274693663u)] == num50)
					{
						num55 = 651051427;
						num56 = num55;
					}
					else
					{
						num55 = 1730755817;
						num56 = num55;
					}
					num4 = num55 ^ (int)(num * 1973120964);
					continue;
				}
				case 61u:
					num4 = (int)(num * 946019659) ^ -192037622;
					continue;
				case 25u:
					num4 = (int)(num * 1114637670) ^ -1800533726;
					continue;
				case 23u:
					num4 = (int)(num * 1594246506) ^ -527417102;
					continue;
				case 92u:
				{
					int num51;
					int num52;
					if (array7.Length >= 1)
					{
						num51 = -1261783532;
						num52 = num51;
					}
					else
					{
						num51 = -1396018216;
						num52 = num51;
					}
					num4 = num51 ^ (int)(num * 1511886799);
					continue;
				}
				case 105u:
					role2 = ResourceManager.Get<Role>(array7[0]);
					num4 = ((int)num * -788766376) ^ 0x35046CDD;
					continue;
				case 126u:
				{
					int num49;
					if (array2.Length >= 2)
					{
						num4 = -899976524;
						num49 = num4;
					}
					else
					{
						num4 = -501417707;
						num49 = num4;
					}
					continue;
				}
				case 41u:
				{
					int num48;
					if (array8.Length < 2)
					{
						num4 = -617962324;
						num48 = num4;
					}
					else
					{
						num4 = -1079545848;
						num48 = num4;
					}
					continue;
				}
				case 28u:
					return false;
				case 44u:
				{
					int num44;
					int num45;
					if (array4.Length != 1)
					{
						num44 = -439051344;
						num45 = num44;
					}
					else
					{
						num44 = -1258867014;
						num45 = num44;
					}
					num4 = num44 ^ (int)(num * 919697141);
					continue;
				}
				case 46u:
					if (role == null)
					{
						num4 = (int)((num * 717325658) ^ 0x1F96427E);
						continue;
					}
					goto IL_d51d;
				case 80u:
				{
					int num42;
					int num43;
					if (num21 < 0)
					{
						num42 = -1185436051;
						num43 = num42;
					}
					else
					{
						num42 = -356566571;
						num43 = num42;
					}
					num4 = num42 ^ (int)(num * 1988548872);
					continue;
				}
				case 39u:
					num4 = (int)((num * 960619586) ^ 0xB7C89AA);
					continue;
				case 60u:
				{
					int num40;
					if (condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(484176047u))
					{
						num4 = -422523648;
						num40 = num4;
					}
					else
					{
						num4 = -576861579;
						num40 = num4;
					}
					continue;
				}
				case 123u:
				{
					int num36;
					int num37;
					if (array5.Length == 1)
					{
						num36 = -283307993;
						num37 = num36;
					}
					else
					{
						num36 = -811860213;
						num37 = num36;
					}
					num4 = num36 ^ ((int)num * -1868115176);
					continue;
				}
				case 55u:
					return false;
				case 104u:
					return RuntimeData.Instance.GetBattleWinCount() >= int.Parse(array6[0]);
				case 8u:
				{
					int num35;
					if (role2 != null)
					{
						num4 = -896678743;
						num35 = num4;
					}
					else
					{
						num4 = -274261253;
						num35 = num4;
					}
					continue;
				}
				case 20u:
					role4 = ResourceManager.Get<Role>(array5[0]);
					num4 = (int)(num * 52686270) ^ -306852631;
					continue;
				case 33u:
					array3 = condition.value.Split('#');
					num4 = (int)((num * 1771529218) ^ 0x372F390E);
					continue;
				case 115u:
				{
					int num32;
					int num33;
					if (role3.character2 != num31)
					{
						num32 = -73653019;
						num33 = num32;
					}
					else
					{
						num32 = -781434968;
						num33 = num32;
					}
					num4 = num32 ^ ((int)num * -32985015);
					continue;
				}
				case 122u:
					break;
				case 93u:
					num4 = ((int)num * -659485157) ^ 0x73756C95;
					continue;
				case 27u:
					num4 = ((int)num * -815050370) ^ -1066694066;
					continue;
				case 11u:
					num4 = (int)(num * 1403662326) ^ -123967363;
					continue;
				case 112u:
					num30 = 0;
					num4 = ((int)num * -299826910) ^ 0x795C854C;
					continue;
				case 95u:
				{
					int num24;
					int num25;
					if (array4.Length >= 1)
					{
						num24 = 149562488;
						num25 = num24;
					}
					else
					{
						num24 = 1196323169;
						num25 = num24;
					}
					num4 = num24 ^ ((int)num * -1374838158);
					continue;
				}
				case 129u:
					return true;
				case 3u:
				{
					int num20;
					if (!(condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2887354508u)))
					{
						num4 = -410645805;
						num20 = num4;
					}
					else
					{
						num4 = -997580781;
						num20 = num4;
					}
					continue;
				}
				case 127u:
					num4 = (int)((num * 1576609151) ^ 0x31B1D4BB);
					continue;
				case 89u:
				{
					int num17;
					if (!(condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(716765220u)))
					{
						num4 = -1746778859;
						num17 = num4;
					}
					else
					{
						num4 = -2074609136;
						num17 = num4;
					}
					continue;
				}
				case 45u:
					num4 = ((int)num * -1135144126) ^ 0x20C031AF;
					continue;
				case 90u:
				{
					int num14;
					int num15;
					if (array2.Length >= 1)
					{
						num14 = -244312652;
						num15 = num14;
					}
					else
					{
						num14 = -1259533495;
						num15 = num14;
					}
					num4 = num14 ^ ((int)num * -1930767808);
					continue;
				}
				case 71u:
					role = RuntimeData.Instance.GetRoleByName(array[0]);
					num4 = -531156133;
					continue;
				case 48u:
					num4 = (int)((num * 1729063322) ^ 0x2F02711);
					continue;
				case 97u:
					return false;
				case 16u:
					num13 = -1;
					num4 = (int)(num * 66862007) ^ -310471685;
					continue;
				case 32u:
					num4 = (int)((num * 99584552) ^ 0x44E62B8B);
					continue;
				case 72u:
					return false;
				case 21u:
					num4 = (int)((num * 846384661) ^ 0x43F603A);
					continue;
				default:
					{
						try
						{
							while (true)
							{
								IL_d44f:
								int num6;
								int num7;
								if (!enumerator.MoveNext())
								{
									num6 = -248781007;
									num7 = num6;
								}
								else
								{
									num6 = -1133143225;
									num7 = num6;
								}
								while (true)
								{
									switch ((num = (uint)(num6 ^ -1375790662)) % 9)
									{
									case 0u:
										num6 = -1133143225;
										continue;
									default:
										goto end_IL_d3b1;
									case 1u:
										current = enumerator.Current;
										num6 = -465524989;
										continue;
									case 5u:
										goto end_IL_d3b1;
									case 2u:
										num6 = (int)((num * 1076849529) ^ 0x796CBBAC);
										continue;
									case 7u:
										role = current;
										num6 = (int)(num * 1930407902) ^ -1580954142;
										continue;
									case 3u:
										break;
									case 8u:
									{
										int num10;
										int num11;
										if (current.Name == array[0])
										{
											num10 = 1248579825;
											num11 = num10;
										}
										else
										{
											num10 = 1509286050;
											num11 = num10;
										}
										num6 = num10 ^ (int)(num * 1378292019);
										continue;
									}
									case 6u:
									{
										int num8;
										int num9;
										if (current == null)
										{
											num8 = 150679791;
											num9 = num8;
										}
										else
										{
											num8 = 1114484525;
											num9 = num8;
										}
										num6 = num8 ^ ((int)num * -1168279388);
										continue;
									}
									case 4u:
										goto end_IL_d3b1;
									}
									goto IL_d44f;
									continue;
									end_IL_d3b1:
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
									IL_d4da:
									int num12 = -1008125380;
									while (true)
									{
										switch ((num = (uint)(num12 ^ -1375790662)) % 3)
										{
										case 2u:
											break;
										default:
											goto end_IL_d4df;
										case 1u:
											goto IL_d4ff;
										case 0u:
											goto end_IL_d4df;
										}
										goto IL_d4da;
										IL_d4ff:
										enumerator.Dispose();
										num12 = (int)((num * 965003383) ^ 0x4D8447A);
										continue;
										end_IL_d4df:
										break;
									}
									break;
								}
							}
						}
						goto IL_d51d;
					}
					IL_d51d:
					if (role != null)
					{
						goto IL_d528;
					}
					goto IL_daa3;
					IL_dc42:
					if (condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(268498534u))
					{
						num71 = -1176137461;
						num72 = num71;
					}
					else
					{
						num71 = -317865508;
						num72 = num71;
					}
					goto IL_d52d;
					IL_d52d:
					while (true)
					{
						switch ((num = (uint)(num71 ^ -1375790662)) % 65)
						{
						case 45u:
							break;
						case 31u:
							goto IL_d649;
						case 21u:
							return RuntimeData.Instance.Team[0].HasTitle(array11[0]);
						case 35u:
							num71 = ((int)num * -2008778284) ^ 0x3A58041;
							continue;
						case 6u:
							goto IL_d6c0;
						case 0u:
							goto IL_d6eb;
						case 10u:
							goto IL_d70f;
						case 9u:
							goto IL_d72b;
						case 25u:
							result3 = false;
							num71 = ((int)num * -1928932338) ^ -1497120581;
							continue;
						case 34u:
							goto IL_d765;
						case 8u:
							return true;
						case 30u:
							num71 = (int)(num * 108545153) ^ -2074027706;
							continue;
						case 60u:
							num75 = 0;
							num71 = ((int)num * -1882440302) ^ -248564671;
							continue;
						case 27u:
							num71 = ((int)num * -385573805) ^ 0x4AFDA7AA;
							continue;
						case 55u:
							return result3;
						case 47u:
							goto IL_d7fd;
						case 36u:
							num71 = ((int)num * -262389419) ^ 0x1A11DEC6;
							continue;
						case 51u:
							teamRole2 = RuntimeData.Instance.GetTeamRole(array11[0]);
							num71 = -737244655;
							continue;
						case 22u:
							return RuntimeData.Instance.Team[0].GetSpecialSkill(array9[0]) != null;
						case 26u:
						{
							int num88;
							int num89;
							if (date.Month != int.Parse(s))
							{
								num88 = 1841749165;
								num89 = num88;
							}
							else
							{
								num88 = 730196476;
								num89 = num88;
							}
							num71 = num88 ^ ((int)num * -1069803141);
							continue;
						}
						case 19u:
							return false;
						case 1u:
						{
							int num81;
							int num82;
							if (teamRole == null)
							{
								num81 = 516352335;
								num82 = num81;
							}
							else
							{
								num81 = 1532364681;
								num82 = num81;
							}
							num71 = num81 ^ ((int)num * -1349518332);
							continue;
						}
						case 28u:
							num83 = 1;
							num71 = (int)(num * 905084924) ^ -254989598;
							continue;
						case 39u:
							return RuntimeData.Instance.CurrentBigMap == condition.value;
						case 61u:
						{
							int num92;
							int num93;
							if (role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2015671736u)] != num30)
							{
								num92 = 1196752436;
								num93 = num92;
							}
							else
							{
								num92 = 1962505920;
								num93 = num92;
							}
							num71 = num92 ^ ((int)num * -556752411);
							continue;
						}
						case 63u:
							return true;
						case 20u:
							date = RuntimeData.Instance.Date;
							num71 = (int)(num * 771402522) ^ -1807207153;
							continue;
						case 49u:
							goto IL_d9c4;
						case 32u:
							num71 = (int)((num * 1644061) ^ 0x6E2B8638);
							continue;
						case 62u:
							num83++;
							num71 = -1862053544;
							continue;
						case 11u:
							num78++;
							num71 = -920447412;
							continue;
						case 23u:
							num75++;
							num71 = -1154106369;
							continue;
						case 15u:
							result3 = true;
							num71 = -620204878;
							continue;
						case 64u:
							return false;
						case 4u:
							array11 = condition.value.Split('#');
							num71 = (int)((num * 1370958754) ^ 0x7E5F1723);
							continue;
						case 38u:
							num71 = ((int)num * -1886396592) ^ -1724015549;
							continue;
						case 24u:
							goto IL_daa3;
						case 54u:
							goto IL_daaf;
						case 18u:
						{
							int num90;
							int num91;
							if (RuntimeData.Instance.Rank < 0)
							{
								num90 = 1321148350;
								num91 = num90;
							}
							else
							{
								num90 = 215184852;
								num91 = num90;
							}
							num71 = num90 ^ ((int)num * -1053237880);
							continue;
						}
						case 43u:
							return false;
						case 56u:
							return false;
						case 53u:
						{
							int num86;
							int num87;
							if (array11.Length >= 1)
							{
								num86 = -1398799648;
								num87 = num86;
							}
							else
							{
								num86 = -802718892;
								num87 = num86;
							}
							num71 = num86 ^ ((int)num * -574013954);
							continue;
						}
						case 3u:
							return result2;
						case 57u:
							return false;
						case 50u:
						{
							int num84;
							int num85;
							if (teamRole2 == null)
							{
								num84 = 1769370726;
								num85 = num84;
							}
							else
							{
								num84 = 356836136;
								num85 = num84;
							}
							num71 = num84 ^ (int)(num * 1905795077);
							continue;
						}
						case 46u:
							num71 = ((int)num * -1987816193) ^ -1465562285;
							continue;
						case 5u:
							return true;
						case 16u:
						{
							int num79;
							int num80;
							if (RuntimeData.Instance.Rank > int.Parse(condition.value))
							{
								num79 = 1530642472;
								num80 = num79;
							}
							else
							{
								num79 = 1932158863;
								num80 = num79;
							}
							num71 = num79 ^ ((int)num * -1213459763);
							continue;
						}
						case 58u:
							goto IL_dc14;
						case 40u:
							goto IL_dc42;
						case 37u:
							teamRole = RuntimeData.Instance.GetTeamRole(array9[0]);
							num71 = -1850219801;
							continue;
						case 14u:
							result2 = true;
							num78 = 1;
							num71 = -1314907735;
							continue;
						case 41u:
							num71 = (int)((num * 397079093) ^ 0x730145B2);
							continue;
						case 33u:
							num71 = ((int)num * -468582028) ^ 0x55DF28F5;
							continue;
						case 59u:
							goto IL_dccf;
						case 48u:
							num71 = ((int)num * -1224589589) ^ 0x2A22D847;
							continue;
						case 12u:
						{
							int num76;
							int num77;
							if (array9.Length >= 1)
							{
								num76 = -2102101088;
								num77 = num76;
							}
							else
							{
								num76 = -477586562;
								num77 = num76;
							}
							num71 = num76 ^ ((int)num * -1250681012);
							continue;
						}
						case 29u:
							s = array10[num75];
							num71 = -1286296570;
							continue;
						case 52u:
							return false;
						case 17u:
							array10 = condition.value.Split('#');
							num71 = ((int)num * -1677322530) ^ -1556334449;
							continue;
						case 44u:
							result2 = false;
							num71 = ((int)num * -223899367) ^ 0x662C25BF;
							continue;
						case 7u:
							num71 = (int)(num * 1223527466) ^ -2066066395;
							continue;
						case 42u:
							array9 = condition.value.Split('#');
							num71 = ((int)num * -933424874) ^ -1804346637;
							continue;
						case 13u:
							num71 = ((int)num * -1260610137) ^ 0x1E3DD3B4;
							continue;
						default:
							return result;
						}
						break;
						IL_dccf:
						int num94;
						if (!(condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4262177261u)))
						{
							num71 = -1561895188;
							num94 = num71;
						}
						else
						{
							num71 = -208893347;
							num94 = num71;
						}
						continue;
						IL_d72b:
						int num95;
						if (array9.Length != 1)
						{
							num71 = -1892972139;
							num95 = num71;
						}
						else
						{
							num71 = -41195805;
							num95 = num71;
						}
						continue;
						IL_d7fd:
						int num96;
						if (num78 < array11.Length)
						{
							num71 = -985387148;
							num96 = num71;
						}
						else
						{
							num71 = -216790963;
							num96 = num71;
						}
						continue;
						IL_dc14:
						int num97;
						if (teamRole.GetSpecialSkill(array9[num83]) == null)
						{
							num71 = -1318674412;
							num97 = num71;
						}
						else
						{
							num71 = -1980716074;
							num97 = num71;
						}
						continue;
						IL_d649:
						int num98;
						if (!teamRole2.HasTitle(array11[num78]))
						{
							num71 = -65834492;
							num98 = num71;
						}
						else
						{
							num71 = -1635139510;
							num98 = num71;
						}
						continue;
						IL_d6eb:
						int num99;
						if (num83 >= array9.Length)
						{
							num71 = -1277620951;
							num99 = num71;
						}
						else
						{
							num71 = -1448570609;
							num99 = num71;
						}
						continue;
						IL_daaf:
						int num100;
						if (condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2229499381u))
						{
							num71 = -410629362;
							num100 = num71;
						}
						else
						{
							num71 = -77872062;
							num100 = num71;
						}
						continue;
						IL_d765:
						int num101;
						if (!(condition.type == global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1533927897u)))
						{
							num71 = -157344386;
							num101 = num71;
						}
						else
						{
							num71 = -310277534;
							num101 = num71;
						}
						continue;
						IL_d70f:
						int num102;
						if (num75 < array10.Length)
						{
							num71 = -1087883910;
							num102 = num71;
						}
						else
						{
							num71 = -101993926;
							num102 = num71;
						}
						continue;
						IL_d9c4:
						int num103;
						if (array11.Length == 1)
						{
							num71 = -1291986206;
							num103 = num71;
						}
						else
						{
							num71 = -2104433620;
							num103 = num71;
						}
						continue;
						IL_d6c0:
						int num104;
						if (condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1052160258u))
						{
							num71 = -322207939;
							num104 = num71;
						}
						else
						{
							num71 = -1080390628;
							num104 = num71;
						}
					}
					goto IL_d528;
					IL_daa3:
					return false;
					IL_d528:
					num71 = -2047633234;
					goto IL_d52d;
				}
				break;
			}
		}
		IL_008e:
		num2 = -2040182564;
		goto IL_0093;
		IL_0093:
		string text12 = default(string);
		string[] array35 = default(string[]);
		Item item = default(Item);
		Role teamRole38 = default(Role);
		string roleKey31 = default(string);
		TimeSpan timeSpan = default(TimeSpan);
		Role roleByName = default(Role);
		int num388 = default(int);
		string[] array45 = default(string[]);
		string[] array39 = default(string[]);
		string roleKey39 = default(string);
		string[] array42 = default(string[]);
		string roleKey27 = default(string);
		string roleKey2 = default(string);
		string[] array77 = default(string[]);
		string roleKey46 = default(string);
		List<ItemInstance>.Enumerator enumerator2 = default(List<ItemInstance>.Enumerator);
		Role role6 = default(Role);
		string[] array34 = default(string[]);
		string[] array23 = default(string[]);
		Item item2 = default(Item);
		string[] array21 = default(string[]);
		string roleKey36 = default(string);
		string[] array22 = default(string[]);
		int num158 = default(int);
		string roleKey37 = default(string);
		string roleKey29 = default(string);
		string[] array56 = default(string[]);
		string text8 = default(string);
		Role teamRole12 = default(Role);
		int num169 = default(int);
		string[] array64 = default(string[]);
		string text23 = default(string);
		string[] array46 = default(string[]);
		string[] array13 = default(string[]);
		int num230 = default(int);
		string[] array69 = default(string[]);
		string roleKey30 = default(string);
		string[] array70 = default(string[]);
		string text = default(string);
		string text27 = default(string);
		string[] array65 = default(string[]);
		string[] array19 = default(string[]);
		string[] array50 = default(string[]);
		string[] array44 = default(string[]);
		Role teamRole31 = default(Role);
		Role teamRole39 = default(Role);
		string text9 = default(string);
		Role teamRole26 = default(Role);
		int num306 = default(int);
		int num155 = default(int);
		string[] array29 = default(string[]);
		string text28 = default(string);
		Role teamRole24 = default(Role);
		int num281 = default(int);
		string roleKey35 = default(string);
		Role teamRole28 = default(Role);
		string roleKey21 = default(string);
		string[] array57 = default(string[]);
		Role teamRole3 = default(Role);
		string roleKey13 = default(string);
		string text6 = default(string);
		string text16 = default(string);
		string roleKey16 = default(string);
		string[] array31 = default(string[]);
		string text10 = default(string);
		string roleKey9 = default(string);
		string[] array47 = default(string[]);
		string text49 = default(string);
		string[] array26 = default(string[]);
		int num220 = default(int);
		string text18 = default(string);
		string[] array58 = default(string[]);
		bool result7 = default(bool);
		string[] array61 = default(string[]);
		Role teamRole37 = default(Role);
		string[] array52 = default(string[]);
		string[] array53 = default(string[]);
		string text2 = default(string);
		Role teamRole7 = default(Role);
		string roleKey26 = default(string);
		string[] array73 = default(string[]);
		int num161 = default(int);
		string[] array33 = default(string[]);
		int num232 = default(int);
		Role teamRole22 = default(Role);
		string roleKey44 = default(string);
		string[] array62 = default(string[]);
		string text13 = default(string);
		string[] array16 = default(string[]);
		bool result5 = default(bool);
		int num143 = default(int);
		int num144 = default(int);
		Role role5 = default(Role);
		string[] array48 = default(string[]);
		string text21 = default(string);
		int num135 = default(int);
		Role teamRole16 = default(Role);
		string roleKey24 = default(string);
		int num209 = default(int);
		string[] array14 = default(string[]);
		string roleKey12 = default(string);
		int num142 = default(int);
		string[] array25 = default(string[]);
		string[] array28 = default(string[]);
		int num356 = default(int);
		int days = default(int);
		int num609 = default(int);
		int num652 = default(int);
		string roleKey6 = default(string);
		string[] array38 = default(string[]);
		Role teamRole21 = default(Role);
		int num472 = default(int);
		string roleKey20 = default(string);
		string text43 = default(string);
		string[] array18 = default(string[]);
		string[] array41 = default(string[]);
		string[] array49 = default(string[]);
		string roleKey52 = default(string);
		int num264 = default(int);
		string roleKey33 = default(string);
		int num179 = default(int);
		Role teamRole6 = default(Role);
		int num502 = default(int);
		string[] array66 = default(string[]);
		string[] array71 = default(string[]);
		bool result6 = default(bool);
		Role teamRole41 = default(Role);
		int num574 = default(int);
		string roleKey49 = default(string);
		string roleKey45 = default(string);
		string roleKey38 = default(string);
		string text11 = default(string);
		string text5 = default(string);
		string[] array76 = default(string[]);
		int internalSkillLevel = default(int);
		Role teamRole35 = default(Role);
		string text38 = default(string);
		Role teamRole19 = default(Role);
		string roleKey4 = default(string);
		string[] array75 = default(string[]);
		string roleKey50 = default(string);
		int num395 = default(int);
		string[] array68 = default(string[]);
		string text26 = default(string);
		string[] array63 = default(string[]);
		bool flag2 = default(bool);
		int num507 = default(int);
		Role teamRole9 = default(Role);
		string roleKey54 = default(string);
		string[] array72 = default(string[]);
		int num339 = default(int);
		Role teamRole40 = default(Role);
		int num110 = default(int);
		string roleKey17 = default(string);
		int num159 = default(int);
		string roleKey53 = default(string);
		string roleKey11 = default(string);
		string text17 = default(string);
		int num109 = default(int);
		string[] array12 = default(string[]);
		string text29 = default(string);
		Role teamRole36 = default(Role);
		int num447 = default(int);
		int num444 = default(int);
		Role teamRole25 = default(Role);
		string roleKey41 = default(string);
		string[] array74 = default(string[]);
		string[] array30 = default(string[]);
		int num132 = default(int);
		string roleKey32 = default(string);
		string[] array51 = default(string[]);
		int num225 = default(int);
		Role teamRole30 = default(Role);
		int num328 = default(int);
		string[] array60 = default(string[]);
		int num114 = default(int);
		string text31 = default(string);
		string roleKey8 = default(string);
		string[] array15 = default(string[]);
		int skillLevel = default(int);
		string text33 = default(string);
		string roleKey25 = default(string);
		string roleKey40 = default(string);
		string roleKey22 = default(string);
		string[] array43 = default(string[]);
		int num313 = default(int);
		string text34 = default(string);
		string[] array37 = default(string[]);
		int num117 = default(int);
		string[] array67 = default(string[]);
		Role teamRole29 = default(Role);
		string roleKey18 = default(string);
		string roleKey19 = default(string);
		Role teamRole27 = default(Role);
		int num292 = default(int);
		Role teamRole23 = default(Role);
		string roleKey = default(string);
		string text22 = default(string);
		string[] array59 = default(string[]);
		int num240 = default(int);
		string roleKey28 = default(string);
		int num231 = default(int);
		Role teamRole17 = default(Role);
		string[] array32 = default(string[]);
		Role teamRole15 = default(Role);
		string roleKey14 = default(string);
		string roleKey15 = default(string);
		int num120 = default(int);
		string text7 = default(string);
		string[] array24 = default(string[]);
		string roleKey3 = default(string);
		int num301 = default(int);
		string roleKey51 = default(string);
		Role teamRole13 = default(Role);
		int num180 = default(int);
		string roleKey43 = default(string);
		string roleKey34 = default(string);
		string text24 = default(string);
		bool result4 = default(bool);
		int num314 = default(int);
		string[] array17 = default(string[]);
		Role teamRole8 = default(Role);
		int num137 = default(int);
		string[] array27 = default(string[]);
		string roleKey55 = default(string);
		string text15 = default(string);
		string[] array36 = default(string[]);
		Role teamRole14 = default(Role);
		int num243 = default(int);
		string[] array55 = default(string[]);
		string roleKey23 = default(string);
		Role teamRole33 = default(Role);
		string text44 = default(string);
		int num485 = default(int);
		string roleKey10 = default(string);
		string roleKey7 = default(string);
		int num162 = default(int);
		string roleKey42 = default(string);
		int num212 = default(int);
		Role teamRole11 = default(Role);
		Role teamRole10 = default(Role);
		string[] array54 = default(string[]);
		int num113 = default(int);
		string roleKey48 = default(string);
		int num437 = default(int);
		Role teamRole32 = default(Role);
		string[] array20 = default(string[]);
		Role teamRole5 = default(Role);
		int num127 = default(int);
		Role teamRole34 = default(Role);
		string text37 = default(string);
		int num315 = default(int);
		string roleKey5 = default(string);
		string text4 = default(string);
		string roleKey47 = default(string);
		string text20 = default(string);
		string text3 = default(string);
		int num452 = default(int);
		Role teamRole20 = default(Role);
		Role teamRole4 = default(Role);
		int num136 = default(int);
		Role teamRole18 = default(Role);
		int num233 = default(int);
		int num160 = default(int);
		int num217 = default(int);
		bool flag = default(bool);
		Role teamRole42 = default(Role);
		Role teamRole43 = default(Role);
		Role teamRole44 = default(Role);
		Role teamRole45 = default(Role);
		Role teamRole46 = default(Role);
		Role teamRole47 = default(Role);
		Role teamRole48 = default(Role);
		Role teamRole49 = default(Role);
		Role teamRole50 = default(Role);
		Role teamRole51 = default(Role);
		Role teamRole52 = default(Role);
		Role teamRole53 = default(Role);
		Role teamRole54 = default(Role);
		Role teamRole55 = default(Role);
		Role teamRole56 = default(Role);
		Role teamRole57 = default(Role);
		Role teamRole58 = default(Role);
		while (true)
		{
			int num375;
			int num463;
			int num176;
			int num432;
			int num524;
			uint num;
			switch ((num = (uint)(num2 ^ -1375790662)) % 1344)
			{
			case 122u:
				break;
			case 802u:
				text12 = array35[0];
				num2 = ((int)num * -160799190) ^ -390203542;
				continue;
			case 1247u:
				num2 = ((int)num * -552344659) ^ -1371854732;
				continue;
			case 1283u:
			{
				int num595;
				int num596;
				if (item.type != 1)
				{
					num595 = 855148380;
					num596 = num595;
				}
				else
				{
					num595 = 1086884793;
					num596 = num595;
				}
				num2 = num595 ^ ((int)num * -613294073);
				continue;
			}
			case 519u:
				teamRole38 = RuntimeData.Instance.GetTeamRole(roleKey31);
				num2 = -246758311;
				continue;
			case 34u:
				goto IL_1620;
			case 620u:
				goto IL_1646;
			case 1167u:
				goto IL_1671;
			case 1018u:
				timeSpan = RuntimeData.Instance.Date - Tools.GetDateTime(-62135625600L);
				num2 = (int)((num * 380991934) ^ 0x5101714C);
				continue;
			case 547u:
				num2 = ((int)num * -1937127003) ^ 0x92BB19B;
				continue;
			case 1230u:
				goto IL_16e5;
			case 760u:
			{
				int num550;
				int num551;
				if (roleByName.isharem == 0)
				{
					num550 = 1262436359;
					num551 = num550;
				}
				else
				{
					num550 = 1415278435;
					num551 = num550;
				}
				num2 = num550 ^ (int)(num * 530437003);
				continue;
			}
			case 1126u:
				num388 = 0;
				num2 = (int)((num * 257868483) ^ 0x2E13C917);
				continue;
			case 1330u:
				return RuntimeData.Instance.GetHarems() >= int.Parse(condition.value);
			case 153u:
				array45 = condition.value.Split('#');
				num2 = ((int)num * -1149401429) ^ -1849424067;
				continue;
			case 55u:
				array39 = condition.value.Split('#');
				num2 = (int)(num * 1819932123) ^ -1449791124;
				continue;
			case 428u:
				return false;
			case 2u:
				roleKey39 = ResourceStrings.ResStrings[0];
				num2 = ((int)num * -1081310166) ^ -1441497577;
				continue;
			case 1214u:
				goto IL_1809;
			case 336u:
			{
				int num177;
				int num178;
				if (array42.Length == 1)
				{
					num177 = -2124348707;
					num178 = num177;
				}
				else
				{
					num177 = -1801791186;
					num178 = num177;
				}
				num2 = num177 ^ (int)(num * 344640091);
				continue;
			}
			case 215u:
				roleKey27 = ResourceStrings.ResStrings[0];
				num2 = ((int)num * -1742680633) ^ -620404913;
				continue;
			case 702u:
				return false;
			case 678u:
				goto IL_1882;
			case 230u:
				roleKey2 = string.Empty;
				num2 = -1759584231;
				continue;
			case 1136u:
				num2 = ((int)num * -712083226) ^ 0x34BFE11A;
				continue;
			case 1199u:
				array77 = condition.value.Split('#');
				num2 = ((int)num * -1528641307) ^ 0x16CD245;
				continue;
			case 787u:
				num2 = (int)(num * 1164526539) ^ -1991164156;
				continue;
			case 1139u:
				return true;
			case 466u:
				goto IL_191e;
			case 895u:
				roleKey46 = ResourceStrings.ResStrings[0];
				num2 = ((int)num * -208665688) ^ 0x31F660E;
				continue;
			case 1129u:
				return true;
			case 238u:
				enumerator2 = role6.Equipment.GetEnumerator();
				num2 = ((int)num * -710163934) ^ 0xD0945D1;
				continue;
			case 14u:
				goto IL_19ab;
			case 873u:
			{
				int num536;
				int num537;
				if (array34.Length >= 2)
				{
					num536 = 1916974852;
					num537 = num536;
				}
				else
				{
					num536 = 364054875;
					num537 = num536;
				}
				num2 = num536 ^ ((int)num * -600790035);
				continue;
			}
			case 102u:
			{
				int num510;
				int num511;
				if (array23.Length >= 1)
				{
					num510 = 322883060;
					num511 = num510;
				}
				else
				{
					num510 = 904946188;
					num511 = num510;
				}
				num2 = num510 ^ ((int)num * -855464911);
				continue;
			}
			case 263u:
			{
				int num494;
				int num495;
				if (item2.type == 2)
				{
					num494 = -927814509;
					num495 = num494;
				}
				else
				{
					num494 = -828553453;
					num495 = num494;
				}
				num2 = num494 ^ ((int)num * -1339007287);
				continue;
			}
			case 44u:
				return false;
			case 1033u:
			{
				int num311;
				int num312;
				if (array21.Length != 1)
				{
					num311 = -2014348854;
					num312 = num311;
				}
				else
				{
					num311 = -2098075746;
					num312 = num311;
				}
				num2 = num311 ^ ((int)num * -255938090);
				continue;
			}
			case 12u:
				roleKey36 = array22[0];
				num158 = int.Parse(array22[1]);
				num2 = -179041993;
				continue;
			case 198u:
				roleKey37 = string.Empty;
				num2 = -1119543178;
				continue;
			case 1236u:
				roleKey29 = array56[0];
				num2 = -1820151158;
				continue;
			case 1263u:
				text8 = string.Empty;
				num2 = (int)(num * 744195744) ^ -1742013052;
				continue;
			case 1196u:
				num2 = ((int)num * -1892346275) ^ 0x50CA2062;
				continue;
			case 301u:
			{
				int num170;
				int num171;
				if (teamRole12.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2259249129u)] < num169)
				{
					num170 = -1191813399;
					num171 = num170;
				}
				else
				{
					num170 = -1272135458;
					num171 = num170;
				}
				num2 = num170 ^ (int)(num * 1789514466);
				continue;
			}
			case 203u:
				goto IL_1b2d;
			case 495u:
			{
				int num683;
				int num684;
				if (array64.Length >= 1)
				{
					num683 = 2125303529;
					num684 = num683;
				}
				else
				{
					num683 = 1850004800;
					num684 = num683;
				}
				num2 = num683 ^ ((int)num * -1914572641);
				continue;
			}
			case 758u:
				return true;
			case 211u:
				text23 = string.Empty;
				num2 = ((int)num * -1431483038) ^ 0x20B7B315;
				continue;
			case 225u:
			{
				int num648;
				int num649;
				if (array46.Length < 1)
				{
					num648 = -1307106982;
					num649 = num648;
				}
				else
				{
					num648 = -1597804401;
					num649 = num648;
				}
				num2 = num648 ^ ((int)num * -965489052);
				continue;
			}
			case 1116u:
			{
				array13 = condition.value.Split('#');
				int num620;
				int num621;
				if (array13.Length >= 1)
				{
					num620 = -619062456;
					num621 = num620;
				}
				else
				{
					num620 = -319905313;
					num621 = num620;
				}
				num2 = num620 ^ (int)(num * 1110035842);
				continue;
			}
			case 564u:
				num230 = 0;
				num2 = (int)(num * 2049595615) ^ -183811872;
				continue;
			case 593u:
				array69 = condition.value.Split('#');
				num2 = ((int)num * -1117142978) ^ 0x2E99F6F9;
				continue;
			case 7u:
				roleKey30 = array70[0];
				text = array70[1];
				num2 = (int)((num * 715376100) ^ 0xEF66375);
				continue;
			case 1043u:
				goto IL_1c9a;
			case 1257u:
				goto IL_1cc0;
			case 828u:
				text27 = array65[1];
				num2 = ((int)num * -1282460926) ^ 0x4C6E9DE7;
				continue;
			case 851u:
				goto IL_1d09;
			case 414u:
				array19 = condition.value.Split('#');
				num2 = ((int)num * -1681147090) ^ 0x66871959;
				continue;
			case 879u:
			{
				int num585;
				int num586;
				if (array50.Length >= 1)
				{
					num585 = -219219818;
					num586 = num585;
				}
				else
				{
					num585 = -102264063;
					num586 = num585;
				}
				num2 = num585 ^ (int)(num * 1274077177);
				continue;
			}
			case 267u:
				return false;
			case 352u:
				return true;
			case 344u:
				return false;
			case 1219u:
				array10 = condition.value.Split('#');
				num2 = (int)((num * 2058911288) ^ 0x6C3ACA96);
				continue;
			case 1115u:
			{
				int num528;
				int num529;
				if (array44.Length >= 1)
				{
					num528 = -1883217177;
					num529 = num528;
				}
				else
				{
					num528 = -19807525;
					num529 = num528;
				}
				num2 = num528 ^ (int)(num * 1054000383);
				continue;
			}
			case 282u:
				goto IL_1e17;
			case 131u:
				goto IL_1e42;
			case 231u:
			{
				int num490;
				int num491;
				if (teamRole31 == null)
				{
					num490 = -569413262;
					num491 = num490;
				}
				else
				{
					num490 = -509765470;
					num491 = num490;
				}
				num2 = num490 ^ (int)(num * 1027304923);
				continue;
			}
			case 241u:
			{
				int num468;
				int num469;
				if (teamRole39 != null)
				{
					num468 = 582106252;
					num469 = num468;
				}
				else
				{
					num468 = 2035032342;
					num469 = num468;
				}
				num2 = num468 ^ ((int)num * -177784303);
				continue;
			}
			case 811u:
			{
				string text41 = text9.Replace(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3250051652u), RuntimeData.Instance.RoundString());
				string oldValue10 = global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(456209355u);
				num75 = teamRole26.MAX_INTERNALSKILL_LEVEL;
				num306 = (int)double.Parse(Tools.Compute(text41.Replace(oldValue10, num75.ToString())));
				num2 = (int)(num * 734311987) ^ -735718120;
				continue;
			}
			case 852u:
			{
				num155 = 0;
				int num426;
				int num427;
				if (array29.Length != 1)
				{
					num426 = 1385263306;
					num427 = num426;
				}
				else
				{
					num426 = 978699525;
					num427 = num426;
				}
				num2 = num426 ^ ((int)num * -834374158);
				continue;
			}
			case 435u:
				return false;
			case 997u:
				num2 = ((int)num * -1979675134) ^ -1923518275;
				continue;
			case 59u:
				return false;
			case 78u:
			{
				string text36 = text28.Replace(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1381559287u), RuntimeData.Instance.RoundString());
				string oldValue7 = global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(456209355u);
				num75 = teamRole24.MAX_ATTRIBUTE;
				num281 = (int)double.Parse(Tools.Compute(text36.Replace(oldValue7, num75.ToString())));
				num2 = -1235816153;
				continue;
			}
			case 531u:
				array10 = condition.value.Split('#');
				num75 = 0;
				num2 = (int)((num * 719644063) ^ 0x2BAFE004);
				continue;
			case 607u:
				goto IL_1fe9;
			case 956u:
				return false;
			case 400u:
				roleKey35 = array65[0];
				num2 = -1891663290;
				continue;
			case 1182u:
				goto IL_2030;
			case 967u:
				return RuntimeData.Instance.AutoSaveOnly;
			case 239u:
			{
				int num297;
				int num298;
				if (teamRole28 == null)
				{
					num297 = -706053501;
					num298 = num297;
				}
				else
				{
					num297 = -283633843;
					num298 = num297;
				}
				num2 = num297 ^ ((int)num * -2076985507);
				continue;
			}
			case 546u:
				roleKey36 = ResourceStrings.ResStrings[0];
				num2 = (int)(num * 1505607765) ^ -93647555;
				continue;
			case 750u:
				return true;
			case 950u:
				roleKey21 = array57[0];
				num2 = -763622299;
				continue;
			case 1119u:
				array50 = condition.value.Split('#');
				num2 = ((int)num * -2041220406) ^ -390159773;
				continue;
			case 964u:
				return false;
			case 1077u:
				teamRole3 = RuntimeData.Instance.GetTeamRole(roleKey13);
				num2 = -2116834745;
				continue;
			case 1132u:
			{
				item = ResourceManager.Get<Item>(text6);
				int num238;
				int num239;
				if (item == null)
				{
					num238 = 350683820;
					num239 = num238;
				}
				else
				{
					num238 = 445580841;
					num239 = num238;
				}
				num2 = num238 ^ (int)(num * 208581685);
				continue;
			}
			case 528u:
				return false;
			case 334u:
			{
				int num193;
				int num194;
				if (item.type == 12)
				{
					num193 = -1498762412;
					num194 = num193;
				}
				else
				{
					num193 = -2007954652;
					num194 = num193;
				}
				num2 = num193 ^ (int)(num * 1002746687);
				continue;
			}
			case 1013u:
				text16 = array45[0];
				num2 = ((int)num * -2138401517) ^ -2021143478;
				continue;
			case 507u:
				roleKey16 = array31[0];
				text10 = array31[1];
				num2 = -1239488940;
				continue;
			case 1012u:
				goto IL_2236;
			case 721u:
				goto IL_2264;
			case 23u:
			{
				int num123;
				int num124;
				if (Tools.ProbabilityTest(double.Parse(condition.value) / 100.0))
				{
					num123 = -1284664502;
					num124 = num123;
				}
				else
				{
					num123 = -1089079724;
					num124 = num123;
				}
				num2 = num123 ^ (int)(num * 2091358348);
				continue;
			}
			case 317u:
				return false;
			case 773u:
				item = ResourceManager.Get<Item>(text6);
				num2 = ((int)num * -1108748439) ^ -780389236;
				continue;
			case 1117u:
				num2 = ((int)num * -2112902792) ^ -1371456533;
				continue;
			case 524u:
				return false;
			case 210u:
			{
				int num677;
				int num678;
				if (!RuntimeData.Instance.NameInTeam(condition.value))
				{
					num677 = 340962449;
					num678 = num677;
				}
				else
				{
					num677 = 659090515;
					num678 = num677;
				}
				num2 = num677 ^ ((int)num * -1527260398);
				continue;
			}
			case 373u:
				roleKey9 = ResourceStrings.ResStrings[0];
				num2 = ((int)num * -729117987) ^ -329596055;
				continue;
			case 305u:
			{
				array47 = condition.value.Split('#');
				int num661;
				int num662;
				if (array47.Length < 2)
				{
					num661 = 470604329;
					num662 = num661;
				}
				else
				{
					num661 = 1791477133;
					num662 = num661;
				}
				num2 = num661 ^ ((int)num * -2003611529);
				continue;
			}
			case 327u:
				num2 = ((int)num * -689590020) ^ 0x427B98B9;
				continue;
			case 1024u:
				return true;
			case 266u:
				return false;
			case 1170u:
			{
				text49 = string.Empty;
				int num640;
				int num641;
				if (array26.Length != 1)
				{
					num640 = 346218007;
					num641 = num640;
				}
				else
				{
					num640 = 93107604;
					num641 = num640;
				}
				num2 = num640 ^ ((int)num * -1326172639);
				continue;
			}
			case 805u:
			{
				num220 = 0;
				int num628;
				int num629;
				if (array50.Length != 1)
				{
					num628 = -342902265;
					num629 = num628;
				}
				else
				{
					num628 = -1940263432;
					num629 = num628;
				}
				num2 = num628 ^ ((int)num * -137724814);
				continue;
			}
			case 1225u:
			{
				int num614;
				int num615;
				if (item.type == 2)
				{
					num614 = 401788923;
					num615 = num614;
				}
				else
				{
					num614 = 753490507;
					num615 = num614;
				}
				num2 = num614 ^ (int)(num * 1615127681);
				continue;
			}
			case 972u:
				text18 = array58[1];
				num2 = (int)((num * 201545097) ^ 0x34AC1D88);
				continue;
			case 901u:
				goto IL_2480;
			case 325u:
				result7 = true;
				num2 = -565288309;
				continue;
			case 722u:
			{
				int num593;
				int num594;
				if (item2.type != 4)
				{
					num593 = 464466330;
					num594 = num593;
				}
				else
				{
					num593 = 1039423055;
					num594 = num593;
				}
				num2 = num593 ^ ((int)num * -825139647);
				continue;
			}
			case 1306u:
			{
				int num583;
				int num584;
				if (RuntimeData.Instance.InTeam(condition.value))
				{
					num583 = -2137820806;
					num584 = num583;
				}
				else
				{
					num583 = -2117020833;
					num584 = num583;
				}
				num2 = num583 ^ ((int)num * -137472235);
				continue;
			}
			case 806u:
				return false;
			case 981u:
				return RuntimeData.Instance.getHaogan2(array61[0]) >= double.Parse(array61[1]);
			case 460u:
			{
				int num566;
				int num567;
				if (teamRole37 == null)
				{
					num566 = -118657534;
					num567 = num566;
				}
				else
				{
					num566 = -1029398778;
					num567 = num566;
				}
				num2 = num566 ^ ((int)num * -1585779912);
				continue;
			}
			case 856u:
				return false;
			case 1273u:
				return true;
			case 717u:
				return true;
			case 952u:
				array52 = condition.value.Split('#');
				num2 = ((int)num * -1897033919) ^ -1362492828;
				continue;
			case 1204u:
			{
				int num530;
				int num531;
				if (item2.type != 1)
				{
					num530 = -1063489471;
					num531 = num530;
				}
				else
				{
					num530 = -1799837811;
					num531 = num530;
				}
				num2 = num530 ^ ((int)num * -424012364);
				continue;
			}
			case 452u:
			{
				int num522;
				int num523;
				if (array53.Length == 1)
				{
					num522 = -1640894614;
					num523 = num522;
				}
				else
				{
					num522 = -266482667;
					num523 = num522;
				}
				num2 = num522 ^ (int)(num * 1898281007);
				continue;
			}
			case 1316u:
				item2 = ResourceManager.Get<Item>(text2);
				num2 = (int)((num * 1779602961) ^ 0xADD988C);
				continue;
			case 20u:
			{
				int num500;
				int num501;
				if (teamRole7 == null)
				{
					num500 = 1054206844;
					num501 = num500;
				}
				else
				{
					num500 = 589857516;
					num501 = num500;
				}
				num2 = num500 ^ ((int)num * -1078882321);
				continue;
			}
			case 656u:
				return false;
			case 1177u:
				goto IL_2679;
			case 837u:
				num2 = ((int)num * -433718450) ^ 0x63189C6E;
				continue;
			case 1118u:
			{
				int num475;
				int num476;
				if (item.type == 4)
				{
					num475 = -2052039312;
					num476 = num475;
				}
				else
				{
					num475 = -1046024568;
					num476 = num475;
				}
				num2 = num475 ^ ((int)num * -1036923566);
				continue;
			}
			case 234u:
				num2 = (int)(num * 1131658607) ^ -1816934693;
				continue;
			case 779u:
				return false;
			case 100u:
			{
				int num459;
				int num460;
				if (item2.type == 1)
				{
					num459 = 432945301;
					num460 = num459;
				}
				else
				{
					num459 = 97775889;
					num460 = num459;
				}
				num2 = num459 ^ (int)(num * 975569424);
				continue;
			}
			case 361u:
				role6 = RuntimeData.Instance.GetRole(roleKey30);
				num2 = -1552152686;
				continue;
			case 46u:
				array46 = condition.value.Split('#');
				num2 = (int)(num * 417861618) ^ -1409567193;
				continue;
			case 342u:
				return false;
			case 260u:
				teamRole37 = RuntimeData.Instance.GetTeamRole(roleKey26);
				num2 = -911537290;
				continue;
			case 674u:
			{
				int num440;
				int num441;
				if (array73.Length >= 1)
				{
					num440 = 803508886;
					num441 = num440;
				}
				else
				{
					num440 = 1879560506;
					num441 = num440;
				}
				num2 = num440 ^ (int)(num * 635090538);
				continue;
			}
			case 51u:
			{
				num161 = 0;
				int num414;
				int num415;
				if (array33.Length != 1)
				{
					num414 = 261711356;
					num415 = num414;
				}
				else
				{
					num414 = 991073232;
					num415 = num414;
				}
				num2 = num414 ^ (int)(num * 737419375);
				continue;
			}
			case 714u:
				goto IL_27e5;
			case 986u:
				return false;
			case 1158u:
				array26 = condition.value.Split('#');
				num2 = (int)(num * 122169082) ^ -1560958980;
				continue;
			case 774u:
				return false;
			case 427u:
				return false;
			case 1253u:
				return false;
			case 927u:
				num2 = ((int)num * -2070832184) ^ 0x8DDDF2;
				continue;
			case 698u:
				return true;
			case 196u:
				num232 = 0;
				num2 = (int)(num * 1728737313) ^ -8364559;
				continue;
			case 838u:
				num2 = ((int)num * -710905837) ^ 0x4B77CBDC;
				continue;
			case 462u:
				return true;
			case 1322u:
				array35 = condition.value.Split('#');
				num2 = ((int)num * -1853024639) ^ -554766203;
				continue;
			case 1269u:
				num75++;
				num2 = -272315213;
				continue;
			case 887u:
				return false;
			case 1066u:
				num2 = ((int)num * -407704835) ^ 0x582F57BE;
				continue;
			case 201u:
				return false;
			case 778u:
				num375 = 0;
				goto IL_2954;
			case 145u:
			{
				int num359;
				int num360;
				if (teamRole22 == null)
				{
					num359 = 658073386;
					num360 = num359;
				}
				else
				{
					num359 = 1629034370;
					num360 = num359;
				}
				num2 = num359 ^ ((int)num * -1917494096);
				continue;
			}
			case 248u:
				roleKey44 = string.Empty;
				num2 = -1036792202;
				continue;
			case 491u:
				array62 = condition.value.Split('#');
				num2 = (int)((num * 22706165) ^ 0x7D495FA1);
				continue;
			case 1259u:
				text13 = array16[0];
				num2 = (int)((num * 504806686) ^ 0x6682FACF);
				continue;
			case 1299u:
				return false;
			case 634u:
				result5 = true;
				num2 = -1222243989;
				continue;
			case 188u:
				num143 = RuntimeData.Instance.GetRolesEquipment(text6, num144);
				num2 = -1504947761;
				continue;
			case 399u:
				num2 = ((int)num * -1827389271) ^ -1414991847;
				continue;
			case 259u:
				role5 = RuntimeData.Instance.GetRole(condition.value);
				num2 = ((int)num * -527467969) ^ -893513890;
				continue;
			case 500u:
				return true;
			case 197u:
				return false;
			case 1224u:
			{
				int num318;
				int num319;
				if (item2.type != 2)
				{
					num318 = 1460985179;
					num319 = num318;
				}
				else
				{
					num318 = 865241586;
					num319 = num318;
				}
				num2 = num318 ^ ((int)num * -1719242501);
				continue;
			}
			case 1213u:
			{
				int num290;
				int num291;
				if (teamRole3 == null)
				{
					num290 = 1895426280;
					num291 = num290;
				}
				else
				{
					num290 = 701199580;
					num291 = num290;
				}
				num2 = num290 ^ (int)(num * 794960270);
				continue;
			}
			case 764u:
			{
				int num286;
				int num287;
				if (array62.Length >= 1)
				{
					num286 = -702178418;
					num287 = num286;
				}
				else
				{
					num286 = -1994057547;
					num287 = num286;
				}
				num2 = num286 ^ ((int)num * -902432955);
				continue;
			}
			case 477u:
			{
				int num282;
				int num283;
				if (teamRole24.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(430829805u)] >= num281)
				{
					num282 = 1275008459;
					num283 = num282;
				}
				else
				{
					num282 = 1955881079;
					num283 = num282;
				}
				num2 = num282 ^ ((int)num * -1389287882);
				continue;
			}
			case 177u:
				return false;
			case 395u:
			{
				int num260;
				int num261;
				if (array48.Length >= 1)
				{
					num260 = -1212978919;
					num261 = num260;
				}
				else
				{
					num260 = -245583632;
					num261 = num260;
				}
				num2 = num260 ^ (int)(num * 1562003464);
				continue;
			}
			case 1226u:
				roleKey35 = string.Empty;
				num2 = -853649647;
				continue;
			case 652u:
				text21 = string.Empty;
				num2 = (int)((num * 1073168390) ^ 0x2E18D78D);
				continue;
			case 1171u:
				num2 = (int)((num * 1641259739) ^ 0x609D7C23);
				continue;
			case 820u:
				num2 = (int)((num * 415365017) ^ 0x7F4341F6);
				continue;
			case 649u:
				goto IL_2bb1;
			case 413u:
				num135 = -1;
				num2 = -1507967292;
				continue;
			case 1228u:
			{
				int num236;
				int num237;
				if (RuntimeData.Instance.Round != int.Parse(condition.value))
				{
					num236 = 2058344254;
					num237 = num236;
				}
				else
				{
					num236 = 718522818;
					num237 = num236;
				}
				num2 = num236 ^ (int)(num * 912010689);
				continue;
			}
			case 552u:
				num2 = (int)((num * 523770265) ^ 0x2569A86D);
				continue;
			case 1071u:
				teamRole16 = RuntimeData.Instance.GetTeamRole(roleKey24);
				num2 = -1353390668;
				continue;
			case 741u:
				return false;
			case 588u:
			{
				int num215;
				int num216;
				if (RuntimeData.Instance.Round != int.Parse(condition.value))
				{
					num215 = -1739339990;
					num216 = num215;
				}
				else
				{
					num215 = -99881071;
					num216 = num215;
				}
				num2 = num215 ^ ((int)num * -1932911942);
				continue;
			}
			case 378u:
				goto IL_2c9a;
			case 1327u:
				return true;
			case 883u:
				return false;
			case 1131u:
				num209 = int.Parse(array14[0]);
				num2 = (int)((num * 1527279047) ^ 0x74CDFE5B);
				continue;
			case 1215u:
				return false;
			case 785u:
				return false;
			case 747u:
			{
				int num195;
				int num196;
				if (array29.Length >= 1)
				{
					num195 = 899309269;
					num196 = num195;
				}
				else
				{
					num195 = 83956355;
					num196 = num195;
				}
				num2 = num195 ^ (int)(num * 856096443);
				continue;
			}
			case 538u:
				num2 = ((int)num * -1035157803) ^ -742902528;
				continue;
			case 756u:
				return false;
			case 49u:
				num2 = (int)((num * 1339384096) ^ 0x64DF1F59);
				continue;
			case 534u:
				return true;
			case 186u:
				goto IL_2dbe;
			case 437u:
				goto IL_2de9;
			case 429u:
				goto IL_2e5e;
			case 618u:
				roleKey12 = ResourceStrings.ResStrings[0];
				num142 = int.Parse(array25[0]);
				num2 = (int)((num * 866006631) ^ 0x7B054A0B);
				continue;
			case 408u:
				goto IL_2ea4;
			case 1005u:
			{
				int num151;
				int num152;
				if (array28.Length >= 1)
				{
					num151 = -1448543750;
					num152 = num151;
				}
				else
				{
					num151 = -237907661;
					num152 = num151;
				}
				num2 = num151 ^ ((int)num * -1331268609);
				continue;
			}
			case 1235u:
				return false;
			case 1207u:
				num2 = ((int)num * -1621298447) ^ -99853787;
				continue;
			case 390u:
				num2 = ((int)num * -525268285) ^ -1557990352;
				continue;
			case 1084u:
				array21 = condition.value.Split('#');
				num2 = ((int)num * -1520309904) ^ 0x4ACA62F1;
				continue;
			case 143u:
			{
				int num125;
				int num126;
				if (array19.Length == 1)
				{
					num125 = -88587237;
					num126 = num125;
				}
				else
				{
					num125 = -1053905982;
					num126 = num125;
				}
				num2 = num125 ^ ((int)num * -1136832640);
				continue;
			}
			case 1221u:
				num356++;
				num2 = -899629531;
				continue;
			case 886u:
				roleKey35 = ResourceStrings.ResStrings[0];
				num2 = (int)(num * 1398223421) ^ -231732455;
				continue;
			case 375u:
				item = null;
				num2 = ((int)num * -1257455289) ^ -41916379;
				continue;
			case 763u:
			{
				int num679;
				int num680;
				if (days - num609 > num652)
				{
					num679 = -792645154;
					num680 = num679;
				}
				else
				{
					num679 = -869205295;
					num680 = num679;
				}
				num2 = num679 ^ ((int)num * -1381027380);
				continue;
			}
			case 1276u:
				goto IL_2ff2;
			case 1099u:
				goto IL_3018;
			case 1217u:
			{
				int num673;
				int num674;
				if (num135 != -1)
				{
					num673 = 243533403;
					num674 = num673;
				}
				else
				{
					num673 = 1472436918;
					num674 = num673;
				}
				num2 = num673 ^ ((int)num * -75686262);
				continue;
			}
			case 855u:
				roleKey6 = array38[0];
				num2 = -982765460;
				continue;
			case 535u:
			{
				int num667;
				int num668;
				if (teamRole21.AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(187771104u)] < num472)
				{
					num667 = 2147441987;
					num668 = num667;
				}
				else
				{
					num667 = 655167627;
					num668 = num667;
				}
				num2 = num667 ^ (int)(num * 712255193);
				continue;
			}
			case 43u:
				roleKey20 = string.Empty;
				text12 = string.Empty;
				num2 = -1099498010;
				continue;
			case 571u:
				return true;
			case 124u:
				return false;
			case 148u:
				num2 = ((int)num * -2022063173) ^ -1462797516;
				continue;
			case 212u:
				if (ResourceManager.Get<InternalSkill>(text8) != null)
				{
					num375 = 1;
					goto IL_2954;
				}
				num2 = -430414480;
				continue;
			case 423u:
				return false;
			case 905u:
				goto IL_3141;
			case 796u:
				text43 = array18[0];
				num2 = (int)(num * 1472767072) ^ -619601586;
				continue;
			case 1163u:
				return true;
			case 1218u:
				num2 = (int)(num * 1869122638) ^ -1747503288;
				continue;
			case 897u:
			{
				num652 = int.Parse(array41[1]);
				int num653;
				int num654;
				if (num652 <= 0)
				{
					num653 = 218751689;
					num654 = num653;
				}
				else
				{
					num653 = 385125527;
					num654 = num653;
				}
				num2 = num653 ^ ((int)num * -1739568829);
				continue;
			}
			case 780u:
				return false;
			case 570u:
				goto IL_31ea;
			case 330u:
				array49 = condition.value.Split('#');
				num2 = (int)((num * 411359735) ^ 0x6B9848D0);
				continue;
			case 1321u:
			{
				item = ResourceManager.Get<Item>(text6);
				int num644;
				int num645;
				if (item == null)
				{
					num644 = -391632455;
					num645 = num644;
				}
				else
				{
					num644 = -1692829456;
					num645 = num644;
				}
				num2 = num644 ^ ((int)num * -1616051103);
				continue;
			}
			case 1337u:
				roleKey52 = string.Empty;
				num2 = -1084609380;
				continue;
			case 1138u:
				return false;
			case 843u:
			{
				int num636;
				int num637;
				if (num135 >= num264)
				{
					num636 = -1632218967;
					num637 = num636;
				}
				else
				{
					num636 = -2038694319;
					num637 = num636;
				}
				num2 = num636 ^ (int)(num * 178639676);
				continue;
			}
			case 1180u:
				return false;
			case 1020u:
				roleKey33 = string.Empty;
				num2 = -1821275479;
				continue;
			case 586u:
				num179 = 0;
				num2 = (int)(num * 690049468) ^ -333356691;
				continue;
			case 402u:
				goto IL_32fd;
			case 226u:
				array65 = condition.value.Split('#');
				num2 = (int)((num * 1815414885) ^ 0xAD2F75D);
				continue;
			case 1047u:
				goto IL_3343;
			case 1095u:
			{
				teamRole6 = RuntimeData.Instance.GetTeamRole(roleKey21);
				int num630;
				int num631;
				if (teamRole6 != null)
				{
					num630 = 671625868;
					num631 = num630;
				}
				else
				{
					num630 = 1439911557;
					num631 = num630;
				}
				num2 = num630 ^ (int)(num * 1012065651);
				continue;
			}
			case 621u:
				goto IL_33a2;
			case 671u:
				goto IL_33cd;
			case 279u:
				num2 = (int)((num * 1890619190) ^ 0x221385AB);
				continue;
			case 1085u:
				goto IL_33fb;
			case 664u:
				return false;
			case 996u:
				return true;
			case 869u:
				return !string.IsNullOrEmpty(RuntimeData.Instance.Menpai);
			case 133u:
				num2 = ((int)num * -494912026) ^ -900775354;
				continue;
			case 250u:
				num502 = int.Parse(array42[1]);
				num2 = (int)(num * 368280565) ^ -1992602488;
				continue;
			case 195u:
				if (string.IsNullOrEmpty(array66[2]))
				{
					num2 = ((int)num * -162750468) ^ 0x3C16582A;
					continue;
				}
				num463 = int.Parse(array66[2]);
				goto IL_8660;
			case 925u:
				return false;
			case 221u:
				return true;
			case 1267u:
				goto IL_34f8;
			case 1121u:
				goto IL_3523;
			case 577u:
			{
				int num610;
				int num611;
				if (array71.Length < 1)
				{
					num610 = 1767426728;
					num611 = num610;
				}
				else
				{
					num610 = 181476332;
					num611 = num610;
				}
				num2 = num610 ^ ((int)num * -877933360);
				continue;
			}
			case 545u:
				num176 = days;
				goto IL_35cb;
			case 788u:
				goto IL_35d7;
			case 283u:
				return false;
			case 1209u:
				return true;
			case 316u:
				return true;
			case 910u:
				roleKey44 = ResourceStrings.ResStrings[0];
				num2 = ((int)num * -1887462859) ^ 0x73B736AD;
				continue;
			case 126u:
				goto IL_3669;
			case 149u:
				goto IL_3694;
			case 574u:
				num2 = ((int)num * -1292810311) ^ -531854396;
				continue;
			case 876u:
				return true;
			case 529u:
				num2 = (int)((num * 658296293) ^ 0x68A69282);
				continue;
			case 382u:
			{
				int num599;
				int num600;
				if (array45.Length != 1)
				{
					num599 = 1559649945;
					num600 = num599;
				}
				else
				{
					num599 = 140962984;
					num600 = num599;
				}
				num2 = num599 ^ ((int)num * -1051525994);
				continue;
			}
			case 592u:
				result6 = false;
				num2 = (int)(num * 1179948430) ^ -1909055088;
				continue;
			case 619u:
			{
				int num589;
				int num590;
				if (teamRole41 == null)
				{
					num589 = -202966175;
					num590 = num589;
				}
				else
				{
					num589 = -305297898;
					num590 = num589;
				}
				num2 = num589 ^ ((int)num * -1117077241);
				continue;
			}
			case 771u:
			{
				int num581;
				int num582;
				if (item.type == 1)
				{
					num581 = 1133317404;
					num582 = num581;
				}
				else
				{
					num581 = 113931857;
					num582 = num581;
				}
				num2 = num581 ^ ((int)num * -967890402);
				continue;
			}
			case 255u:
			{
				int num577;
				int num578;
				if (num143 < num144)
				{
					num577 = -277769554;
					num578 = num577;
				}
				else
				{
					num577 = -372313350;
					num578 = num577;
				}
				num2 = num577 ^ (int)(num * 831298486);
				continue;
			}
			case 228u:
			{
				string text50 = text16.Replace(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3250051652u), RuntimeData.Instance.RoundString());
				string oldValue16 = global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1878257442u);
				num75 = teamRole28.MAX_ATTRIBUTE;
				num574 = (int)double.Parse(Tools.Compute(text50.Replace(oldValue16, num75.ToString())));
				num2 = -1138064321;
				continue;
			}
			case 565u:
				num2 = ((int)num * -1810179387) ^ 0x5BC46387;
				continue;
			case 831u:
				goto IL_381d;
			case 406u:
				goto IL_3848;
			case 1293u:
				return false;
			case 931u:
				return false;
			case 1087u:
				roleKey49 = array28[0];
				num2 = -1711313598;
				continue;
			case 91u:
				num2 = (int)(num * 465077716) ^ -871508328;
				continue;
			case 958u:
				return false;
			case 461u:
				roleKey45 = string.Empty;
				num2 = -1162526948;
				continue;
			case 1157u:
				goto IL_38d2;
			case 338u:
				return true;
			case 192u:
				goto IL_3914;
			case 625u:
			{
				int num562;
				int num563;
				if (array49.Length < 1)
				{
					num562 = 617489981;
					num563 = num562;
				}
				else
				{
					num562 = 384349182;
					num563 = num562;
				}
				num2 = num562 ^ ((int)num * -1105260997);
				continue;
			}
			case 156u:
				num2 = ((int)num * -337463404) ^ 0x74174B53;
				continue;
			case 152u:
				roleKey38 = string.Empty;
				num2 = -1211300337;
				continue;
			case 821u:
				return false;
			case 857u:
				text11 = array34[1];
				num2 = ((int)num * -336596642) ^ 0x2E84646B;
				continue;
			case 114u:
			{
				int num556;
				int num557;
				if (array61.Length > 1)
				{
					num556 = -630545513;
					num557 = num556;
				}
				else
				{
					num556 = -900825618;
					num557 = num556;
				}
				num2 = num556 ^ (int)(num * 137247356);
				continue;
			}
			case 1105u:
			{
				int num552;
				int num553;
				if (item2.type == 12)
				{
					num552 = -842661094;
					num553 = num552;
				}
				else
				{
					num552 = -42276779;
					num553 = num552;
				}
				num2 = num552 ^ (int)(num * 414301398);
				continue;
			}
			case 38u:
				goto IL_3a1a;
			case 274u:
				roleKey6 = ResourceStrings.ResStrings[0];
				text5 = array38[0];
				num2 = ((int)num * -1541966804) ^ 0x5A297FB1;
				continue;
			case 762u:
				array76 = condition.value.Split('#');
				num2 = ((int)num * -62590154) ^ -170517292;
				continue;
			case 8u:
				return false;
			case 440u:
				goto IL_3a9f;
			case 5u:
				text49 = array26[0];
				num2 = ((int)num * -1327337470) ^ 0x7BDE5344;
				continue;
			case 881u:
				internalSkillLevel = teamRole35.GetInternalSkillLevel(text38);
				num2 = -294525392;
				continue;
			case 605u:
				teamRole19 = RuntimeData.Instance.GetTeamRole(roleKey4);
				num2 = -210542859;
				continue;
			case 700u:
				array75 = condition.value.Split('#');
				num2 = ((int)num * -1279336353) ^ -285798142;
				continue;
			case 1145u:
				roleKey50 = ResourceStrings.ResStrings[0];
				num395 = int.Parse(array73[0]);
				num2 = ((int)num * -1462991003) ^ -130195198;
				continue;
			case 867u:
				return false;
			case 561u:
				return true;
			case 1150u:
				num2 = (int)((num * 556747548) ^ 0x5EEB0AAC);
				continue;
			case 418u:
				goto IL_3bb0;
			case 790u:
				num143 += RuntimeData.Instance.GetXiangziCount(text6);
				num2 = (int)((num * 1934244424) ^ 0xBAAA200);
				continue;
			case 115u:
				return false;
			case 173u:
				return false;
			case 1107u:
				array68 = condition.value.Split('#');
				num2 = (int)(num * 1168308044) ^ -1491756566;
				continue;
			case 130u:
				return false;
			case 1017u:
				text26 = array63[0];
				num2 = (int)(num * 326503469) ^ -2132253106;
				continue;
			case 794u:
				goto IL_3c83;
			case 573u:
				goto IL_3ca9;
			case 581u:
			{
				int num532;
				int num533;
				if (array56.Length == 1)
				{
					num532 = 1152080521;
					num533 = num532;
				}
				else
				{
					num532 = 1645124764;
					num533 = num532;
				}
				num2 = num532 ^ (int)(num * 277169034);
				continue;
			}
			case 28u:
				goto IL_3cfa;
			case 1191u:
				num2 = ((int)num * -846388942) ^ -561454261;
				continue;
			case 176u:
				return false;
			case 638u:
			{
				int num518;
				int num519;
				if (!flag2)
				{
					num518 = 1473465475;
					num519 = num518;
				}
				else
				{
					num518 = 1941764208;
					num519 = num518;
				}
				num2 = num518 ^ ((int)num * -2143370783);
				continue;
			}
			case 144u:
				num502 = 0;
				num2 = ((int)num * -952466397) ^ -1358391910;
				continue;
			case 112u:
				num2 = (int)(num * 1057817958) ^ -463054408;
				continue;
			case 880u:
				return false;
			case 469u:
				num143 = RuntimeData.Instance.GetXiangziCount(text6);
				num2 = (int)((num * 1790827933) ^ 0x468A3869);
				continue;
			case 1133u:
				return false;
			case 1041u:
				num507 = 1;
				num2 = (int)(num * 1843726500) ^ -1140099798;
				continue;
			case 381u:
				teamRole9 = RuntimeData.Instance.GetTeamRole(roleKey54);
				num2 = -615364321;
				continue;
			case 1233u:
				return true;
			case 324u:
				return false;
			case 1162u:
			{
				int num505;
				int num506;
				if (array72.Length != 1)
				{
					num505 = -848158056;
					num506 = num505;
				}
				else
				{
					num505 = -1718683697;
					num506 = num505;
				}
				num2 = num505 ^ ((int)num * -246872030);
				continue;
			}
			case 1332u:
				num339 = int.Parse(array72[0]);
				num2 = ((int)num * -792536650) ^ -625759926;
				continue;
			case 376u:
			{
				int num496;
				int num497;
				if (teamRole40 != null)
				{
					num496 = 2079081028;
					num497 = num496;
				}
				else
				{
					num496 = 1655306052;
					num497 = num496;
				}
				num2 = num496 ^ ((int)num * -786584188);
				continue;
			}
			case 140u:
			{
				int num488;
				int num489;
				if (num110 != 0)
				{
					num488 = 292944547;
					num489 = num488;
				}
				else
				{
					num488 = 850198389;
					num489 = num488;
				}
				num2 = num488 ^ ((int)num * -1627639972);
				continue;
			}
			case 1144u:
				goto IL_3ed6;
			case 189u:
				return false;
			case 393u:
				roleKey52 = ResourceStrings.ResStrings[0];
				num2 = ((int)num * -1129562445) ^ -156521033;
				continue;
			case 1223u:
				return RuntimeData.Instance.getHaogan(roleKey17) >= num159;
			case 521u:
				roleKey53 = string.Empty;
				num2 = -1993436139;
				continue;
			case 693u:
				return true;
			case 666u:
				return false;
			case 306u:
				array41 = condition.value.Split('#');
				num2 = (int)(num * 2100175163) ^ -811777412;
				continue;
			case 765u:
				roleKey11 = ResourceStrings.ResStrings[0];
				num2 = (int)((num * 1266788888) ^ 0x3787A0E7);
				continue;
			case 1038u:
				return result5;
			case 1280u:
			{
				int num477;
				int num478;
				if (array41.Length >= 1)
				{
					num477 = -2020932483;
					num478 = num477;
				}
				else
				{
					num477 = -183575883;
					num478 = num477;
				}
				num2 = num477 ^ ((int)num * -1381776908);
				continue;
			}
			case 624u:
				return false;
			case 902u:
				return true;
			case 968u:
			{
				string text42 = text17.Replace(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3250051652u), RuntimeData.Instance.RoundString());
				string oldValue11 = global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3579531764u);
				num75 = teamRole21.MAX_HPMP;
				num472 = (int)double.Parse(Tools.Compute(text42.Replace(oldValue11, num75.ToString())));
				num2 = -785936674;
				continue;
			}
			case 908u:
				num2 = (int)((num * 820446652) ^ 0x1F1BD29B);
				continue;
			case 849u:
			{
				int num466;
				int num467;
				if (array75.Length == 1)
				{
					num466 = 1947369426;
					num467 = num466;
				}
				else
				{
					num466 = 918491392;
					num467 = num466;
				}
				num2 = num466 ^ ((int)num * -1180801505);
				continue;
			}
			case 341u:
				goto IL_40da;
			case 1189u:
				num109 = int.Parse(array12[0]);
				num2 = (int)((num * 738653495) ^ 0x5C0AF286);
				continue;
			case 978u:
				goto IL_4127;
			case 157u:
				roleKey50 = array73[0];
				num2 = -89751412;
				continue;
			case 1244u:
				goto IL_415d;
			case 1310u:
				goto IL_4188;
			case 654u:
				roleKey37 = array71[0];
				text21 = array71[1];
				num2 = -1105916520;
				continue;
			case 892u:
				return false;
			case 213u:
			{
				int num455;
				int num456;
				if (array35.Length < 1)
				{
					num455 = -1235291988;
					num456 = num455;
				}
				else
				{
					num455 = -1664169834;
					num456 = num455;
				}
				num2 = num455 ^ (int)(num * 640676075);
				continue;
			}
			case 781u:
			{
				int num450;
				int num451;
				if (array65.Length >= 1)
				{
					num450 = -341613330;
					num451 = num450;
				}
				else
				{
					num450 = -2089354191;
					num451 = num450;
				}
				num2 = num450 ^ ((int)num * -137386986);
				continue;
			}
			case 315u:
				array38 = condition.value.Split('#');
				num2 = ((int)num * -1701718383) ^ -936305162;
				continue;
			case 732u:
			{
				string text39 = text29.Replace(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(800863094u), RuntimeData.Instance.RoundString());
				string oldValue8 = global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(456209355u);
				num75 = teamRole36.MAX_ATTRIBUTE;
				num447 = (int)double.Parse(Tools.Compute(text39.Replace(oldValue8, num75.ToString())));
				num2 = -1208776834;
				continue;
			}
			case 1277u:
				num2 = (int)(num * 333437184) ^ -743943793;
				continue;
			case 1275u:
				num444 = int.Parse(array28[0]);
				num2 = (int)((num * 551483414) ^ 0x509CF0BA);
				continue;
			case 329u:
				roleKey21 = ResourceStrings.ResStrings[0];
				num2 = ((int)num * -1075684930) ^ -838396391;
				continue;
			case 1092u:
				num2 = ((int)num * -600213929) ^ 0x6427FFE;
				continue;
			case 645u:
			{
				int num435;
				int num436;
				if (teamRole25 == null)
				{
					num435 = 1068202930;
					num436 = num435;
				}
				else
				{
					num435 = 259518949;
					num436 = num435;
				}
				num2 = num435 ^ (int)(num * 1489621871);
				continue;
			}
			case 937u:
				teamRole28 = RuntimeData.Instance.GetTeamRole(roleKey41);
				num2 = -284508677;
				continue;
			case 482u:
				array71 = condition.value.Split('#');
				num2 = ((int)num * -700859297) ^ 0x70DEB825;
				continue;
			case 1053u:
				num432 = 0;
				goto IL_43d6;
			case 632u:
			{
				array74 = condition.value.Split('#');
				int num428;
				int num429;
				if (array74.Length < 1)
				{
					num428 = -1607227913;
					num429 = num428;
				}
				else
				{
					num428 = -37211260;
					num429 = num428;
				}
				num2 = num428 ^ (int)(num * 79816000);
				continue;
			}
			case 1021u:
				num209 = 0;
				num2 = ((int)num * -103483729) ^ 0x7B417EDB;
				continue;
			case 1023u:
				goto IL_443a;
			case 916u:
				return false;
			case 19u:
				return false;
			case 1246u:
				goto IL_4488;
			case 13u:
				array30 = condition.value.Split('#');
				num2 = ((int)num * -1796509062) ^ -300319815;
				continue;
			case 42u:
				return false;
			case 1194u:
				num132 = 1;
				num2 = (int)(num * 1794835241) ^ -1242115673;
				continue;
			case 668u:
				roleKey32 = array51[0];
				num2 = -508451023;
				continue;
			case 410u:
				num225 = int.Parse(array48[0]);
				num2 = ((int)num * -69561820) ^ -767856106;
				continue;
			case 541u:
				num2 = ((int)num * -1152216621) ^ -1403542836;
				continue;
			case 1151u:
				return true;
			case 463u:
				num2 = (int)((num * 601133713) ^ 0xDE7089D);
				continue;
			case 543u:
				goto IL_4577;
			case 415u:
				return false;
			case 1064u:
			{
				int num410;
				int num411;
				if (RuntimeData.Instance.Menpai != condition.value)
				{
					num410 = -280564357;
					num411 = num410;
				}
				else
				{
					num410 = -143574302;
					num411 = num410;
				}
				num2 = num410 ^ (int)(num * 1180058295);
				continue;
			}
			case 252u:
			{
				int num406;
				int num407;
				if (array31.Length < 1)
				{
					num406 = 1234251619;
					num407 = num406;
				}
				else
				{
					num406 = 1990436597;
					num407 = num406;
				}
				num2 = num406 ^ (int)(num * 2007437836);
				continue;
			}
			case 946u:
				return false;
			case 579u:
				num2 = (int)((num * 329974622) ^ 0x839714D);
				continue;
			case 343u:
			{
				int num400;
				int num401;
				if (teamRole30.AttributesFinal[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(31734228u)] < num328)
				{
					num400 = -1947922546;
					num401 = num400;
				}
				else
				{
					num400 = -631068535;
					num401 = num400;
				}
				num2 = num400 ^ ((int)num * -1608920713);
				continue;
			}
			case 817u:
				return false;
			case 922u:
				return false;
			case 1045u:
			{
				int num393;
				int num394;
				if (num135 != -1)
				{
					num393 = 243825381;
					num394 = num393;
				}
				else
				{
					num393 = 1276294505;
					num394 = num393;
				}
				num2 = num393 ^ (int)(num * 3446276);
				continue;
			}
			case 182u:
				num395 = int.Parse(array73[1]);
				num2 = (int)((num * 385574157) ^ 0x1D4753D6);
				continue;
			case 935u:
				array60 = condition.value.Split('#');
				num2 = ((int)num * -1417600971) ^ 0x6FC4152D;
				continue;
			case 1004u:
				num2 = ((int)num * -991086415) ^ 0x2C23AC6C;
				continue;
			case 1281u:
				return false;
			case 1042u:
				num2 = ((int)num * -1930120492) ^ 0x5EBEC313;
				continue;
			case 825u:
				return true;
			case 367u:
				goto IL_4766;
			case 835u:
				return false;
			case 936u:
				return false;
			case 1319u:
				num110 = RuntimeData.Instance.GetRolesEquipment(text2, num114);
				num2 = -1088002839;
				continue;
			case 296u:
				num2 = (int)(num * 1102241991) ^ -369835815;
				continue;
			case 598u:
				text31 = string.Empty;
				num2 = (int)(num * 302031899) ^ -488853488;
				continue;
			case 240u:
				item2 = null;
				num2 = (int)(num * 418569945) ^ -1521389154;
				continue;
			case 1082u:
			{
				array72 = condition.value.Split('#');
				int num380;
				int num381;
				if (array72.Length < 1)
				{
					num380 = 896063305;
					num381 = num380;
				}
				else
				{
					num380 = 957176908;
					num381 = num380;
				}
				num2 = num380 ^ (int)(num * 1957248362);
				continue;
			}
			case 1097u:
				result5 = false;
				num2 = (int)(num * 186672434) ^ -1546787722;
				continue;
			case 10u:
			{
				int num373;
				int num374;
				if (item2.type == 3)
				{
					num373 = 1310468377;
					num374 = num373;
				}
				else
				{
					num373 = 1231646613;
					num374 = num373;
				}
				num2 = num373 ^ ((int)num * -347594002);
				continue;
			}
			case 372u:
				text17 = string.Empty;
				num2 = (int)((num * 1974681957) ^ 0x3C1532A7);
				continue;
			case 1052u:
			{
				int num367;
				int num368;
				if (array35.Length == 1)
				{
					num367 = -908842409;
					num368 = num367;
				}
				else
				{
					num367 = -2009968820;
					num368 = num367;
				}
				num2 = num367 ^ (int)(num * 850858249);
				continue;
			}
			case 404u:
				num2 = (int)((num * 1902896153) ^ 0x314ED537);
				continue;
			case 403u:
				roleKey8 = array53[0];
				num2 = -282357273;
				continue;
			case 1188u:
				goto IL_48ff;
			case 353u:
				roleKey39 = string.Empty;
				num2 = -853799060;
				continue;
			case 309u:
				return false;
			case 421u:
			{
				int num361;
				int num362;
				if (array15.Length == 1)
				{
					num361 = 1323443934;
					num362 = num361;
				}
				else
				{
					num361 = 222505780;
					num362 = num361;
				}
				num2 = num361 ^ ((int)num * -762754847);
				continue;
			}
			case 351u:
				return false;
			case 1079u:
				num2 = (int)((num * 1675124556) ^ 0x1ACE26C);
				continue;
			case 777u:
				num356 = 1;
				num2 = ((int)num * -849046715) ^ -1996853757;
				continue;
			case 11u:
				goto IL_49b8;
			case 1184u:
				goto IL_49e3;
			case 1088u:
			{
				int num350;
				int num351;
				if (!RuntimeData.Instance.NameInTemp(condition.value))
				{
					num350 = 2132828322;
					num351 = num350;
				}
				else
				{
					num350 = 95465891;
					num351 = num350;
				}
				num2 = num350 ^ ((int)num * -1689045939);
				continue;
			}
			case 989u:
				return false;
			case 985u:
				return true;
			case 622u:
				goto IL_4a62;
			case 80u:
				num110 = RuntimeData.Instance.GetRolesEquipment(text2, num114);
				num2 = -1107821749;
				continue;
			case 1294u:
			{
				int num344;
				int num345;
				if (skillLevel == -1)
				{
					num344 = -1413790845;
					num345 = num344;
				}
				else
				{
					num344 = -633055526;
					num345 = num344;
				}
				num2 = num344 ^ ((int)num * -1676311364);
				continue;
			}
			case 1122u:
				return true;
			case 726u:
				text33 = array30[1];
				num2 = ((int)num * -830099337) ^ 0x3D83DEF5;
				continue;
			case 319u:
				goto IL_4af8;
			case 1148u:
				num2 = ((int)num * -1804438851) ^ -2018945684;
				continue;
			case 746u:
				goto IL_4b73;
			case 475u:
				goto IL_4ba1;
			case 612u:
				teamRole21 = RuntimeData.Instance.GetTeamRole(roleKey25);
				num2 = -580241541;
				continue;
			case 147u:
				roleKey40 = ResourceStrings.ResStrings[0];
				text28 = array68[0];
				num2 = ((int)num * -1429512244) ^ -102017854;
				continue;
			case 983u:
				roleKey22 = ResourceStrings.ResStrings[0];
				num179 = int.Parse(array43[0]);
				num2 = (int)((num * 872575439) ^ 0x52EC0E5B);
				continue;
			case 784u:
				num2 = ((int)num * -1824452541) ^ -809400660;
				continue;
			case 943u:
				return false;
			case 129u:
				num2 = ((int)num * -2083838011) ^ -1787625565;
				continue;
			case 1229u:
				return false;
			case 655u:
				goto IL_4c9b;
			case 1094u:
				return true;
			case 715u:
				num313 = int.Parse(array44[1]);
				num2 = (int)((num * 900546051) ^ 0x71E4E4F8);
				continue;
			case 364u:
				text34 = array37[0];
				num2 = ((int)num * -134892288) ^ -2000323249;
				continue;
			case 307u:
				num161 = int.Parse(array33[1]);
				num2 = ((int)num * -1739605477) ^ 0x4FA59CF5;
				continue;
			case 961u:
				return RuntimeData.Instance.Daode < int.Parse(condition.value);
			case 578u:
				return false;
			case 923u:
				return false;
			case 688u:
			{
				string text32 = text33.Replace(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1875398881u), RuntimeData.Instance.RoundString());
				string oldValue5 = global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3279928277u);
				num75 = teamRole3.MAX_ATTRIBUTE;
				num117 = (int)double.Parse(Tools.Compute(text32.Replace(oldValue5, num75.ToString())));
				num2 = -1406904060;
				continue;
			}
			case 85u:
				num2 = (int)((num * 845477035) ^ 0x6150812D);
				continue;
			case 1300u:
				text29 = string.Empty;
				num2 = ((int)num * -1523905745) ^ -593933139;
				continue;
			case 1002u:
				goto IL_4e0d;
			case 1120u:
				num2 = (int)(num * 306980004) ^ -1628065431;
				continue;
			case 389u:
				array67 = condition.value.Split('#');
				num2 = ((int)num * -291854893) ^ -423628692;
				continue;
			case 1096u:
				num143 = RuntimeData.Instance.GetRolesEquipment(text6, num144);
				num2 = -51972560;
				continue;
			case 865u:
			{
				int num322;
				int num323;
				if (RuntimeData.Instance.Money < int.Parse(condition.value))
				{
					num322 = -62145847;
					num323 = num322;
				}
				else
				{
					num322 = -1667194698;
					num323 = num322;
				}
				num2 = num322 ^ ((int)num * -220310142);
				continue;
			}
			case 735u:
				roleKey16 = string.Empty;
				text10 = string.Empty;
				num2 = -502910254;
				continue;
			case 858u:
			{
				int num309;
				int num310;
				if (array26.Length < 1)
				{
					num309 = 576938804;
					num310 = num309;
				}
				else
				{
					num309 = 131349433;
					num310 = num309;
				}
				num2 = num309 ^ ((int)num * -718013071);
				continue;
			}
			case 217u:
				goto IL_4f09;
			case 95u:
			{
				int num304;
				int num305;
				if (teamRole29 == null)
				{
					num304 = 1252252417;
					num305 = num304;
				}
				else
				{
					num304 = 1942172444;
					num305 = num304;
				}
				num2 = num304 ^ ((int)num * -2078736412);
				continue;
			}
			case 281u:
				num143 += RuntimeData.Instance.GetItemsCount(text6);
				num2 = (int)(num * 467378612) ^ -1103388043;
				continue;
			case 494u:
				num220 = int.Parse(array50[1]);
				num2 = (int)(num * 373670845) ^ -548652542;
				continue;
			case 45u:
				num2 = ((int)num * -515800404) ^ -1576669508;
				continue;
			case 987u:
				roleKey18 = array33[0];
				num2 = -1302283191;
				continue;
			case 1031u:
				roleKey13 = array30[0];
				num2 = -1395664788;
				continue;
			case 525u:
				roleKey19 = array34[0];
				num2 = -2114399133;
				continue;
			case 870u:
			{
				int num293;
				int num294;
				if (teamRole27.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(739543880u)] < num292)
				{
					num293 = 1447309648;
					num294 = num293;
				}
				else
				{
					num293 = 109994913;
					num294 = num293;
				}
				num2 = num293 ^ ((int)num * -1441754720);
				continue;
			}
			case 411u:
			{
				int num279;
				int num280;
				if (array56.Length < 1)
				{
					num279 = -315380445;
					num280 = num279;
				}
				else
				{
					num279 = -864044224;
					num280 = num279;
				}
				num2 = num279 ^ (int)(num * 78203550);
				continue;
			}
			case 1128u:
				return true;
			case 1255u:
			{
				int num275;
				int num276;
				if (teamRole23 != null)
				{
					num275 = 1674048272;
					num276 = num275;
				}
				else
				{
					num275 = 1207736548;
					num276 = num275;
				}
				num2 = num275 ^ (int)(num * 179743086);
				continue;
			}
			case 510u:
			{
				int num269;
				int num270;
				if (array49.Length != 1)
				{
					num269 = -1561879458;
					num270 = num269;
				}
				else
				{
					num269 = -522457864;
					num270 = num269;
				}
				num2 = num269 ^ (int)(num * 1980517741);
				continue;
			}
			case 994u:
				array61 = condition.value.Split('#');
				num2 = ((int)num * -479497082) ^ 0x76F54184;
				continue;
			case 1008u:
				teamRole22 = RuntimeData.Instance.GetTeamRole(roleKey);
				num2 = -457721813;
				continue;
			case 172u:
				roleKey8 = ResourceStrings.ResStrings[0];
				num2 = ((int)num * -1425309146) ^ 0x63A7B185;
				continue;
			case 1334u:
				return false;
			case 86u:
			{
				int num262;
				int num263;
				if (array51.Length != 1)
				{
					num262 = -408063062;
					num263 = num262;
				}
				else
				{
					num262 = -675598630;
					num263 = num262;
				}
				num2 = num262 ^ (int)(num * 1393148210);
				continue;
			}
			case 512u:
				return false;
			case 859u:
				text22 = string.Empty;
				num2 = (int)((num * 559386323) ^ 0x414FCB9C);
				continue;
			case 800u:
				roleKey33 = ResourceStrings.ResStrings[0];
				text23 = array59[0];
				num2 = (int)(num * 1905531568) ^ -660072410;
				continue;
			case 941u:
			{
				int num252;
				int num253;
				if (array13.Length == 1)
				{
					num252 = 1873306980;
					num253 = num252;
				}
				else
				{
					num252 = 299456191;
					num253 = num252;
				}
				num2 = num252 ^ ((int)num * -1083955697);
				continue;
			}
			case 292u:
				return false;
			case 158u:
				num209 = int.Parse(array14[1]);
				num2 = ((int)num * -175082069) ^ -470507629;
				continue;
			case 949u:
				goto IL_51dc;
			case 815u:
				return false;
			case 848u:
			{
				int num246;
				int num247;
				if (item2.type != 12)
				{
					num246 = -2035495744;
					num247 = num246;
				}
				else
				{
					num246 = -2049626219;
					num247 = num246;
				}
				num2 = num246 ^ ((int)num * -1845406668);
				continue;
			}
			case 1035u:
				goto IL_5237;
			case 744u:
			{
				int num241;
				int num242;
				if (skillLevel < num240)
				{
					num241 = 1417312762;
					num242 = num241;
				}
				else
				{
					num241 = 940414443;
					num242 = num241;
				}
				num2 = num241 ^ ((int)num * -2105297772);
				continue;
			}
			case 1220u:
				roleKey28 = array52[0];
				num231 = int.Parse(array52[1]);
				num2 = -827963614;
				continue;
			case 537u:
				goto IL_5296;
			case 459u:
				num230 = int.Parse(array51[1]);
				num2 = (int)(num * 302935938) ^ -980650006;
				continue;
			case 878u:
				teamRole17 = RuntimeData.Instance.GetTeamRole(roleKey18);
				num2 = -157941062;
				continue;
			case 345u:
			{
				int num223;
				int num224;
				if (_206B_202C_202E_200E_202B_200B_202E_206A_206C_206C_202B_200F_200C_200C_206E_206E_202B_206A_206F_200B_206D_206C_206D_202D_200B_206E_206C_206F_200B_206B_202A_202D_206D_202C_202E_206E_206E_206F_202D_200F_202E(RuntimeData.Instance.PrevStory, condition.value))
				{
					num223 = -2020112805;
					num224 = num223;
				}
				else
				{
					num223 = -853616260;
					num224 = num223;
				}
				num2 = num223 ^ (int)(num * 616087994);
				continue;
			}
			case 1124u:
				num159 = int.Parse(array32[0]);
				num2 = ((int)num * -678589668) ^ -1691084403;
				continue;
			case 1295u:
				roleKey26 = array48[0];
				num225 = int.Parse(array48[1]);
				num2 = -1333773122;
				continue;
			case 357u:
				roleKey8 = string.Empty;
				num2 = -339563010;
				continue;
			case 725u:
				num220 = int.Parse(array50[0]);
				num2 = ((int)num * -2074589509) ^ -1226996084;
				continue;
			case 409u:
				timeSpan = RuntimeData.Instance.Date - Tools.GetDateTime(-62135625600L);
				num2 = ((int)num * -2111769416) ^ 0x2C37FB9A;
				continue;
			case 1104u:
				goto IL_53cf;
			case 542u:
			{
				int num210;
				int num211;
				if (teamRole15 == null)
				{
					num210 = 1123572408;
					num211 = num210;
				}
				else
				{
					num210 = 315089600;
					num211 = num210;
				}
				num2 = num210 ^ ((int)num * -1554473345);
				continue;
			}
			case 505u:
				goto IL_540e;
			case 1264u:
			{
				int num205;
				int num206;
				if (RuntimeData.Instance.Menpai == condition.value)
				{
					num205 = 968957214;
					num206 = num205;
				}
				else
				{
					num205 = 1514675442;
					num206 = num205;
				}
				num2 = num205 ^ (int)(num * 1490415446);
				continue;
			}
			case 79u:
				return false;
			case 254u:
			{
				int num199;
				int num200;
				if (array47.Length == 2)
				{
					num199 = 1875071020;
					num200 = num199;
				}
				else
				{
					num199 = 948381596;
					num200 = num199;
				}
				num2 = num199 ^ ((int)num * -1498910640);
				continue;
			}
			case 90u:
				return false;
			case 761u:
				roleKey14 = string.Empty;
				num2 = -1586506968;
				continue;
			case 684u:
			{
				int num189;
				int num190;
				if (array45.Length < 1)
				{
					num189 = 1048043383;
					num190 = num189;
				}
				else
				{
					num189 = 1542714671;
					num190 = num189;
				}
				num2 = num189 ^ ((int)num * -1092812278);
				continue;
			}
			case 631u:
				return false;
			case 294u:
				num110 += RuntimeData.Instance.GetItemsCount(text2);
				num2 = ((int)num * -605570794) ^ 0x374C913F;
				continue;
			case 527u:
			{
				int num183;
				int num184;
				if (item.type == 1)
				{
					num183 = 271037942;
					num184 = num183;
				}
				else
				{
					num183 = 1467718455;
					num184 = num183;
				}
				num2 = num183 ^ (int)(num * 676335420);
				continue;
			}
			case 697u:
				array44 = condition.value.Split('#');
				num2 = (int)(num * 1882634467) ^ -1003669846;
				continue;
			case 686u:
			{
				string[] array40 = RuntimeData.Instance.KeyValues[array41[0]].Split('#');
				timeSpan = RuntimeData.Instance.Date - Tools.GetDateTime(-62135625600L);
				days = timeSpan.Days;
				if (array40.Length >= 2)
				{
					num176 = int.Parse(array40[1]);
					goto IL_35cb;
				}
				num2 = -1627129765;
				continue;
			}
			case 223u:
			{
				int num172;
				int num173;
				if (array39.Length == 1)
				{
					num172 = 1059633070;
					num173 = num172;
				}
				else
				{
					num172 = 1473030861;
					num173 = num172;
				}
				num2 = num172 ^ (int)(num * 1860982370);
				continue;
			}
			case 288u:
				return true;
			case 658u:
				array37 = condition.value.Split('#');
				num2 = (int)(num * 1429469637) ^ -282564665;
				continue;
			case 701u:
				roleKey21 = string.Empty;
				num2 = -238848083;
				continue;
			case 713u:
				return true;
			case 1044u:
				return true;
			case 861u:
				num2 = (int)((num * 1815202337) ^ 0x45DA98F6);
				continue;
			case 1237u:
				roleKey15 = string.Empty;
				num2 = -1740037086;
				continue;
			case 1u:
				return false;
			case 653u:
				num158 = int.Parse(array22[0]);
				num2 = ((int)num * -109459467) ^ 0x2C1B80C6;
				continue;
			case 84u:
				num155 = int.Parse(array29[0]);
				num2 = ((int)num * -1362869376) ^ 0x6F25825A;
				continue;
			case 348u:
				num2 = (int)(num * 477760398) ^ -718973347;
				continue;
			case 970u:
				array28 = condition.value.Split('#');
				num2 = ((int)num * -1059723674) ^ -1304791893;
				continue;
			case 1054u:
				num120 = teamRole6.GetSkillLevel(text7);
				num2 = (int)((num * 1663324511) ^ 0x57F66F56);
				continue;
			case 947u:
			{
				int num147;
				int num148;
				if (item.type != 2)
				{
					num147 = 1101864128;
					num148 = num147;
				}
				else
				{
					num147 = 931070765;
					num148 = num147;
				}
				num2 = num147 ^ (int)(num * 601640635);
				continue;
			}
			case 159u:
				goto IL_578f;
			case 1272u:
				num2 = ((int)num * -1830485165) ^ -1079343324;
				continue;
			case 41u:
				return true;
			case 840u:
				roleKey12 = array25[0];
				num142 = int.Parse(array25[1]);
				num2 = -221968655;
				continue;
			case 123u:
				roleKey13 = string.Empty;
				num2 = -1635526527;
				continue;
			case 1111u:
				array24 = condition.value.Split('#');
				num2 = ((int)num * -729365691) ^ -1522644950;
				continue;
			case 62u:
				num2 = ((int)num * -182160612) ^ 0x19902DC4;
				continue;
			case 939u:
				return false;
			case 164u:
				goto IL_5862;
			case 1168u:
				goto IL_588d;
			case 57u:
				num135 = teamRole6.GetInternalSkillLevel(text7);
				num2 = (int)((num * 1612941164) ^ 0x63A402A3);
				continue;
			case 110u:
			{
				int num130;
				int num131;
				if (item.type == 12)
				{
					num130 = -798301240;
					num131 = num130;
				}
				else
				{
					num130 = -1895073513;
					num131 = num130;
				}
				num2 = num130 ^ ((int)num * -963464258);
				continue;
			}
			case 720u:
				num132++;
				num2 = -1370844326;
				continue;
			case 318u:
			{
				int num118;
				int num119;
				if (teamRole3.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2663905188u)] < num117)
				{
					num118 = -1366408179;
					num119 = num118;
				}
				else
				{
					num118 = -1312394763;
					num119 = num118;
				}
				num2 = num118 ^ (int)(num * 612440279);
				continue;
			}
			case 396u:
				num2 = (int)(num * 1118988155) ^ -2042474769;
				continue;
			case 280u:
				return true;
			case 120u:
				roleKey3 = ResourceStrings.ResStrings[0];
				num2 = ((int)num * -2015411389) ^ -221136889;
				continue;
			case 68u:
				return false;
			case 933u:
			{
				int num685;
				int num686;
				if (item.type != 12)
				{
					num685 = 1673026406;
					num686 = num685;
				}
				else
				{
					num685 = 1464983588;
					num686 = num685;
				}
				num2 = num685 ^ (int)(num * 1809420190);
				continue;
			}
			case 503u:
				num301 = int.Parse(array67[1]);
				num2 = ((int)num * -1823783513) ^ 0x2827B6E6;
				continue;
			case 875u:
				roleKey15 = array16[0];
				text13 = array16[1];
				num2 = -1772275387;
				continue;
			case 117u:
				goto IL_5a1a;
			case 639u:
				num524 = 0;
				goto IL_5a51;
			case 438u:
				roleKey51 = ResourceStrings.ResStrings[0];
				text38 = array47[0];
				num240 = int.Parse(array47[1]);
				num2 = (int)(num * 1745079590) ^ -7592271;
				continue;
			case 457u:
			{
				int num681;
				int num682;
				if (array22.Length == 1)
				{
					num681 = -108822126;
					num682 = num681;
				}
				else
				{
					num681 = -950621572;
					num682 = num681;
				}
				num2 = num681 ^ (int)(num * 1488568186);
				continue;
			}
			case 268u:
				return false;
			case 271u:
				return false;
			case 1301u:
				num109 = 0;
				num2 = (int)((num * 1316805397) ^ 0x2EE75E5C);
				continue;
			case 236u:
				return false;
			case 754u:
			{
				int num675;
				int num676;
				if (teamRole13.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2249625138u)] < num180)
				{
					num675 = 529354479;
					num676 = num675;
				}
				else
				{
					num675 = 1773049831;
					num676 = num675;
				}
				num2 = num675 ^ (int)(num * 533795608);
				continue;
			}
			case 1262u:
				goto IL_5b44;
			case 572u:
				return false;
			case 61u:
				goto IL_5b89;
			case 1308u:
				return false;
			case 247u:
			{
				int num671;
				int num672;
				if (array43.Length < 1)
				{
					num671 = -30240668;
					num672 = num671;
				}
				else
				{
					num671 = -1568392493;
					num672 = num671;
				}
				num2 = num671 ^ (int)(num * 1349520341);
				continue;
			}
			case 347u:
				goto IL_5bf1;
			case 627u:
				num2 = (int)((num * 929143335) ^ 0x64300B37);
				continue;
			case 249u:
				return true;
			case 436u:
			{
				int num669;
				int num670;
				if (item.type == 1)
				{
					num669 = -1633140646;
					num670 = num669;
				}
				else
				{
					num669 = -917240315;
					num670 = num669;
				}
				num2 = num669 ^ ((int)num * -1679278805);
				continue;
			}
			case 569u:
				goto IL_5c71;
			case 362u:
				goto IL_5c9f;
			case 729u:
				goto IL_5cca;
			case 1113u:
				text43 = string.Empty;
				num2 = (int)(num * 1425725631) ^ -1839000469;
				continue;
			case 558u:
				return false;
			case 355u:
				goto IL_5d28;
			case 596u:
				return false;
			case 965u:
				return true;
			case 181u:
				return true;
			case 1291u:
				return false;
			case 1135u:
				array56 = condition.value.Split('#');
				num2 = (int)((num * 1915901435) ^ 0x39775A34);
				continue;
			case 486u:
				teamRole41 = RuntimeData.Instance.GetTeamRole(roleKey43);
				num2 = -205858991;
				continue;
			case 37u:
				return true;
			case 836u:
			{
				int num665;
				int num666;
				if (teamRole36.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(424952987u)] < num447)
				{
					num665 = 1685629671;
					num666 = num665;
				}
				else
				{
					num665 = 1233541853;
					num666 = num665;
				}
				num2 = num665 ^ ((int)num * -336766039);
				continue;
			}
			case 52u:
				return false;
			case 757u:
				roleKey34 = array75[0];
				text24 = array75[1];
				num2 = -885254942;
				continue;
			case 445u:
				goto IL_5e66;
			case 1076u:
				result4 = true;
				num2 = -1111009132;
				continue;
			case 844u:
				goto IL_5ea0;
			case 540u:
				goto IL_5ec1;
			case 335u:
			{
				int num663;
				int num664;
				if (array42.Length >= 1)
				{
					num663 = -530897459;
					num664 = num663;
				}
				else
				{
					num663 = -413160449;
					num664 = num663;
				}
				num2 = num663 ^ (int)(num * 610222412);
				continue;
			}
			case 47u:
				goto IL_5f0d;
			case 16u:
				goto IL_5f3b;
			case 1313u:
				num143 = RuntimeData.Instance.GetItemsCount(text6);
				num2 = ((int)num * -1163172566) ^ -1046490512;
				continue;
			case 1258u:
			{
				int num659;
				int num660;
				if (internalSkillLevel == -1)
				{
					num659 = -1637923362;
					num660 = num659;
				}
				else
				{
					num659 = -1922880530;
					num660 = num659;
				}
				num2 = num659 ^ (int)(num * 718223131);
				continue;
			}
			case 1014u:
				num314 = int.Parse(array62[1]);
				num2 = (int)(num * 1681131549) ^ -595873269;
				continue;
			case 1075u:
			{
				int num657;
				int num658;
				if (array14.Length != 1)
				{
					num657 = 314118703;
					num658 = num657;
				}
				else
				{
					num657 = 1053073074;
					num658 = num657;
				}
				num2 = num657 ^ (int)(num * 1564757839);
				continue;
			}
			case 246u:
				array12 = condition.value.Split('#');
				num2 = (int)((num * 1592694168) ^ 0x397B1F42);
				continue;
			case 397u:
				num2 = ((int)num * -2072495388) ^ 0x706EEBEB;
				continue;
			case 432u:
			{
				item = ResourceManager.Get<Item>(text6);
				int num655;
				int num656;
				if (item != null)
				{
					num655 = -1829771234;
					num656 = num655;
				}
				else
				{
					num655 = -984902496;
					num656 = num655;
				}
				num2 = num655 ^ (int)(num * 248267931);
				continue;
			}
			case 1159u:
				return true;
			case 998u:
				num2 = (int)(num * 2107357096) ^ -1185470597;
				continue;
			case 74u:
			{
				int num650;
				int num651;
				if (internalSkillLevel != -1)
				{
					num650 = 1282805244;
					num651 = num650;
				}
				else
				{
					num650 = 26380078;
					num651 = num650;
				}
				num2 = num650 ^ ((int)num * -604457947);
				continue;
			}
			case 591u:
				text33 = array30[0];
				num2 = ((int)num * -396212550) ^ 0x31AFBB61;
				continue;
			case 917u:
			{
				int num646;
				int num647;
				if (RuntimeData.Instance.KeyValues.ContainsKey(array77[0]))
				{
					num646 = 893621235;
					num647 = num646;
				}
				else
				{
					num646 = 1603766957;
					num647 = num646;
				}
				num2 = num646 ^ ((int)num * -836939078);
				continue;
			}
			case 583u:
				goto IL_60f7;
			case 819u:
				num2 = ((int)num * -1919131527) ^ 0x150004AB;
				continue;
			case 1282u:
				text6 = array66[0];
				num2 = -1406015719;
				continue;
			case 1147u:
			{
				array17 = condition.value.Split('#');
				int num642;
				int num643;
				if (array17.Length < 1)
				{
					num642 = -715417907;
					num643 = num642;
				}
				else
				{
					num642 = -1078363635;
					num643 = num642;
				}
				num2 = num642 ^ (int)(num * 1032744636);
				continue;
			}
			case 1343u:
				num2 = (int)((num * 190626588) ^ 0x1719A1B2);
				continue;
			case 331u:
				return true;
			case 89u:
				num110 += RuntimeData.Instance.GetXiangziCount(text2);
				num2 = ((int)num * -1750776165) ^ 0x5B5C3835;
				continue;
			case 1143u:
				return false;
			case 490u:
				roleKey22 = string.Empty;
				num2 = -139371664;
				continue;
			case 661u:
				return false;
			case 31u:
				text7 = array57[1];
				num2 = ((int)num * -1268600080) ^ 0x61E312B2;
				continue;
			case 530u:
			{
				int num638;
				int num639;
				if (array76.Length <= 1)
				{
					num638 = -774738011;
					num639 = num638;
				}
				else
				{
					num638 = -162871003;
					num639 = num638;
				}
				num2 = num638 ^ ((int)num * -1703985469);
				continue;
			}
			case 1174u:
			{
				text26 = string.Empty;
				int num634;
				int num635;
				if (array63.Length == 1)
				{
					num634 = -84503918;
					num635 = num634;
				}
				else
				{
					num634 = -96598023;
					num635 = num634;
				}
				num2 = num634 ^ (int)(num * 511724511);
				continue;
			}
			case 898u:
				array32 = condition.value.Split('#');
				num2 = (int)((num * 1279779556) ^ 0x994347F);
				continue;
			case 1242u:
				return false;
			case 1312u:
				goto IL_62ac;
			case 132u:
				num2 = (int)((num * 935357242) ^ 0x2DD4AA48);
				continue;
			case 499u:
				return false;
			case 433u:
				return false;
			case 1210u:
			{
				string text51 = text23.Replace(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1875398881u), RuntimeData.Instance.RoundString());
				string oldValue17 = global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3579531764u);
				num75 = teamRole8.MAX_ATTRIBUTE;
				num137 = (int)double.Parse(Tools.Compute(text51.Replace(oldValue17, num75.ToString())));
				num2 = -1468088696;
				continue;
			}
			case 27u:
				return !RuntimeData.Instance.Team[0].HasTalent(array23[0]);
			case 549u:
				roleKey43 = string.Empty;
				num2 = -759154781;
				continue;
			case 1028u:
				return false;
			case 54u:
				text9 = array27[2];
				num2 = (int)(num * 857128832) ^ -1451747474;
				continue;
			case 422u:
			{
				int num632;
				int num633;
				if (item.type == 4)
				{
					num632 = -877040500;
					num633 = num632;
				}
				else
				{
					num632 = -2103908831;
					num633 = num632;
				}
				num2 = num632 ^ (int)(num * 842729509);
				continue;
			}
			case 518u:
			{
				int num626;
				int num627;
				if (roleByName != null)
				{
					num626 = -41167074;
					num627 = num626;
				}
				else
				{
					num626 = -1100351757;
					num627 = num626;
				}
				num2 = num626 ^ (int)(num * 1039935098);
				continue;
			}
			case 948u:
				array31 = condition.value.Split('#');
				num2 = (int)(num * 765899329) ^ -630421838;
				continue;
			case 1206u:
				roleKey4 = string.Empty;
				num2 = -1539386863;
				continue;
			case 380u:
				num143 = RuntimeData.Instance.GetItemsCount(text6);
				num2 = (int)(num * 1328755242) ^ -1160732963;
				continue;
			case 82u:
			{
				int num624;
				int num625;
				if (array27.Length == 2)
				{
					num624 = 614121358;
					num625 = num624;
				}
				else
				{
					num624 = 1029530;
					num625 = num624;
				}
				num2 = num624 ^ ((int)num * -1851270614);
				continue;
			}
			case 446u:
			{
				int num622;
				int num623;
				if (item2.type != 4)
				{
					num622 = -1055632578;
					num623 = num622;
				}
				else
				{
					num622 = -1285725000;
					num623 = num622;
				}
				num2 = num622 ^ ((int)num * -1762850729);
				continue;
			}
			case 425u:
			{
				int num618;
				int num619;
				if (array59.Length != 1)
				{
					num618 = 1200574205;
					num619 = num618;
				}
				else
				{
					num618 = 618425773;
					num619 = num618;
				}
				num2 = num618 ^ ((int)num * -1820169633);
				continue;
			}
			case 1176u:
				roleKey13 = ResourceStrings.ResStrings[0];
				num2 = (int)(num * 631663188) ^ -1662740651;
				continue;
			case 718u:
			{
				int num616;
				int num617;
				if (num120 != -1)
				{
					num616 = 84994769;
					num617 = num616;
				}
				else
				{
					num616 = 265716069;
					num617 = num616;
				}
				num2 = num616 ^ (int)(num * 1791595095);
				continue;
			}
			case 474u:
				return true;
			case 942u:
				return RuntimeData.Instance.NewbieTask.Equals(condition.value);
			case 180u:
			{
				int num612;
				int num613;
				if (teamRole36 != null)
				{
					num612 = 1325008614;
					num613 = num612;
				}
				else
				{
					num612 = 1865256198;
					num613 = num612;
				}
				num2 = num612 ^ (int)(num * 439929952);
				continue;
			}
			case 326u:
				return false;
			case 1341u:
				num2 = ((int)num * -1923662055) ^ -1754733733;
				continue;
			case 640u:
			{
				int num607;
				int num608;
				if (teamRole17 != null)
				{
					num607 = 1061101549;
					num608 = num607;
				}
				else
				{
					num607 = 864156167;
					num608 = num607;
				}
				num2 = num607 ^ ((int)num * -737333031);
				continue;
			}
			case 200u:
			{
				int num605;
				int num606;
				if (item.type == 4)
				{
					num605 = -1290391858;
					num606 = num605;
				}
				else
				{
					num605 = -697195428;
					num606 = num605;
				}
				num2 = num605 ^ ((int)num * -1639514891);
				continue;
			}
			case 1114u:
				return false;
			case 928u:
				goto IL_663c;
			case 962u:
			{
				int num603;
				int num604;
				if (teamRole28.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4176639349u)] >= num574)
				{
					num603 = 1933599720;
					num604 = num603;
				}
				else
				{
					num603 = 156041578;
					num604 = num603;
				}
				num2 = num603 ^ ((int)num * -895841244);
				continue;
			}
			case 473u:
			{
				int num601;
				int num602;
				if (item.type != 12)
				{
					num601 = -458505431;
					num602 = num601;
				}
				else
				{
					num601 = -1398897248;
					num602 = num601;
				}
				num2 = num601 ^ ((int)num * -1119028138);
				continue;
			}
			case 629u:
				num2 = (int)((num * 136928599) ^ 0x76BD7B6D);
				continue;
			case 526u:
			{
				int num597;
				int num598;
				if (teamRole16 != null)
				{
					num597 = -509715723;
					num598 = num597;
				}
				else
				{
					num597 = -1841609323;
					num598 = num597;
				}
				num2 = num597 ^ (int)(num * 1383755646);
				continue;
			}
			case 589u:
				num2 = ((int)num * -1346668880) ^ 0xEEE6629;
				continue;
			case 81u:
				text49 = array26[1];
				num2 = (int)(num * 1203262224) ^ -1322275918;
				continue;
			case 516u:
				num2 = (int)((num * 1227459013) ^ 0x6CD96EE6);
				continue;
			case 9u:
			{
				int num591;
				int num592;
				if (array67.Length < 1)
				{
					num591 = -697792021;
					num592 = num591;
				}
				else
				{
					num591 = -925138433;
					num592 = num591;
				}
				num2 = num591 ^ ((int)num * -1279896560);
				continue;
			}
			case 24u:
				return true;
			case 532u:
				return true;
			case 1108u:
				return true;
			case 163u:
			{
				int num587;
				int num588;
				if (item2.type == 4)
				{
					num587 = 1969289742;
					num588 = num587;
				}
				else
				{
					num587 = 1362506993;
					num588 = num587;
				}
				num2 = num587 ^ (int)(num * 626254505);
				continue;
			}
			case 1003u:
				goto IL_67e7;
			case 792u:
				array33 = condition.value.Split('#');
				num2 = (int)((num * 551959344) ^ 0x10BDBE9F);
				continue;
			case 1057u:
				return false;
			case 360u:
				goto IL_6856;
			case 509u:
				roleKey55 = ResourceStrings.ResStrings[0];
				text15 = array36[0];
				num2 = ((int)num * -371874630) ^ -17940867;
				continue;
			case 520u:
				teamRole30 = RuntimeData.Instance.GetTeamRole(roleKey11);
				num2 = -1054641275;
				continue;
			case 660u:
				roleKey53 = array27[0];
				text8 = array27[1];
				num2 = -520118260;
				continue;
			case 803u:
				num2 = ((int)num * -1415936470) ^ -347125543;
				continue;
			case 830u:
				return false;
			case 103u:
				roleKey34 = ResourceStrings.ResStrings[0];
				text24 = array75[0];
				num2 = (int)((num * 612841217) ^ 0x52211D59);
				continue;
			case 1200u:
				goto IL_6932;
			case 827u:
			{
				int num579;
				int num580;
				if (teamRole14.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(704292959u)] < num243)
				{
					num579 = -1244579671;
					num580 = num579;
				}
				else
				{
					num579 = -321700387;
					num580 = num579;
				}
				num2 = num579 ^ (int)(num * 312641889);
				continue;
			}
			case 289u:
				text11 = string.Empty;
				num2 = (int)(num * 2049120478) ^ -1884414876;
				continue;
			case 708u:
				num230 = int.Parse(array51[0]);
				num2 = (int)((num * 679260494) ^ 0x4EA40068);
				continue;
			case 135u:
				goto IL_69d2;
			case 966u:
				goto IL_69fd;
			case 125u:
				goto IL_6a28;
			case 646u:
				goto IL_6a56;
			case 597u:
				roleKey54 = array67[0];
				num2 = -361860595;
				continue;
			case 1146u:
			{
				array55 = condition.value.Split('#');
				int num575;
				int num576;
				if (array55.Length >= 1)
				{
					num575 = 670261844;
					num576 = num575;
				}
				else
				{
					num575 = 1654599303;
					num576 = num575;
				}
				num2 = num575 ^ (int)(num * 634058016);
				continue;
			}
			case 1266u:
				array59 = condition.value.Split('#');
				num2 = ((int)num * -1794439217) ^ 0x73970736;
				continue;
			case 704u:
				roleKey23 = string.Empty;
				num2 = -409038404;
				continue;
			case 276u:
				return false;
			case 193u:
				roleKey32 = string.Empty;
				num2 = -2104564274;
				continue;
			case 703u:
				teamRole33 = RuntimeData.Instance.GetTeamRole(roleKey15);
				num2 = -1988204294;
				continue;
			case 371u:
				num2 = ((int)num * -1224235532) ^ 0x59DDC8F;
				continue;
			case 232u:
				array14 = condition.value.Split('#');
				num2 = ((int)num * -424947217) ^ 0x6049D9F0;
				continue;
			case 233u:
				return RuntimeData.Instance.getHaogan2(array76[0]) < double.Parse(array76[1]);
			case 1016u:
				num444 = int.Parse(array28[1]);
				num2 = (int)(num * 430064601) ^ -1560924016;
				continue;
			case 454u:
			{
				text44 = string.Empty;
				int num572;
				int num573;
				if (array24.Length == 1)
				{
					num572 = 1009396936;
					num573 = num572;
				}
				else
				{
					num572 = 1526946211;
					num573 = num572;
				}
				num2 = num572 ^ ((int)num * -1234320984);
				continue;
			}
			case 1050u:
				num485 = 1;
				num2 = ((int)num * -860938061) ^ 0x29E8A8F1;
				continue;
			case 1015u:
				roleKey41 = array45[0];
				num2 = -1280987638;
				continue;
			case 1333u:
				num2 = ((int)num * -423143903) ^ -387844766;
				continue;
			case 659u:
				goto IL_6c46;
			case 884u:
			{
				int num570;
				int num571;
				if (array77.Length < 2)
				{
					num570 = -534304437;
					num571 = num570;
				}
				else
				{
					num570 = -49065333;
					num571 = num570;
				}
				num2 = num570 ^ ((int)num * -50105923);
				continue;
			}
			case 719u:
				goto IL_6c97;
			case 287u:
				return false;
			case 882u:
			{
				int num568;
				int num569;
				if (item2.type == 12)
				{
					num568 = -910405289;
					num569 = num568;
				}
				else
				{
					num568 = -104031837;
					num569 = num568;
				}
				num2 = num568 ^ ((int)num * -393601843);
				continue;
			}
			case 687u:
				goto IL_6cf8;
			case 1048u:
				text22 = array57[2];
				num2 = ((int)num * -1884006598) ^ -1112533438;
				continue;
			case 194u:
				roleKey23 = ResourceStrings.ResStrings[0];
				text44 = array24[0];
				num2 = (int)((num * 269815638) ^ 0x92D3E2A);
				continue;
			case 1036u:
			{
				array57 = condition.value.Split('#');
				int num564;
				int num565;
				if (array57.Length < 2)
				{
					num564 = 781934378;
					num565 = num564;
				}
				else
				{
					num564 = 512574367;
					num565 = num564;
				}
				num2 = num564 ^ ((int)num * -1436261918);
				continue;
			}
			case 299u:
				num2 = ((int)num * -1877155632) ^ 0x384319D8;
				continue;
			case 730u:
				roleKey10 = array46[0];
				num2 = -2041662963;
				continue;
			case 559u:
				return false;
			case 924u:
				roleKey52 = array58[0];
				num2 = -605570954;
				continue;
			case 1073u:
				num2 = (int)((num * 218722802) ^ 0x414A4502);
				continue;
			case 912u:
				teamRole36 = RuntimeData.Instance.GetTeamRole(roleKey7);
				num2 = -1113311538;
				continue;
			case 753u:
				return false;
			case 426u:
				goto IL_6e21;
			case 823u:
				text31 = array46[1];
				num2 = ((int)num * -162644383) ^ 0x5E96D089;
				continue;
			case 1027u:
				return true;
			case 544u:
				return false;
			case 497u:
				teamRole23 = RuntimeData.Instance.GetTeamRole(roleKey39);
				num2 = -1930510115;
				continue;
			case 22u:
				return true;
			case 208u:
				num2 = ((int)num * -843264401) ^ -1931400724;
				continue;
			case 1100u:
			{
				num313 = 0;
				int num560;
				int num561;
				if (array44.Length == 1)
				{
					num560 = -1722651124;
					num561 = num560;
				}
				else
				{
					num560 = -1994207456;
					num561 = num560;
				}
				num2 = num560 ^ ((int)num * -1282337494);
				continue;
			}
			case 178u:
				goto IL_6f4e;
			case 1011u:
				return true;
			case 209u:
				return false;
			case 742u:
				return false;
			case 712u:
				goto IL_6fb3;
			case 1152u:
				num162 = 0;
				num2 = ((int)num * -162713122) ^ -962324163;
				continue;
			case 4u:
				num2 = ((int)num * -1319716867) ^ -1658526254;
				continue;
			case 251u:
				if (role6 != null)
				{
					num2 = ((int)num * -659699963) ^ 0x70EF9333;
					continue;
				}
				goto IL_c14f;
			case 749u:
				array51 = condition.value.Split('#');
				num2 = ((int)num * -409479315) ^ -798683069;
				continue;
			case 1164u:
				goto IL_704c;
			case 39u:
			{
				int num558;
				int num559;
				if (array57.Length == 2)
				{
					num558 = -149155019;
					num559 = num558;
				}
				else
				{
					num558 = -956768502;
					num559 = num558;
				}
				num2 = num558 ^ (int)(num * 364059402);
				continue;
			}
			case 533u:
				return false;
			case 453u:
				goto IL_70aa;
			case 407u:
				roleKey46 = array37[0];
				text34 = array37[1];
				num2 = -812684104;
				continue;
			case 169u:
			{
				array58 = condition.value.Split('#');
				int num554;
				int num555;
				if (array58.Length < 1)
				{
					num554 = -1703632438;
					num555 = num554;
				}
				else
				{
					num554 = -1651666794;
					num555 = num554;
				}
				num2 = num554 ^ ((int)num * -1274771187);
				continue;
			}
			case 121u:
				return result6;
			case 1248u:
				goto IL_713a;
			case 1192u:
				roleKey10 = ResourceStrings.ResStrings[0];
				num2 = (int)((num * 1577912454) ^ 0x1BF543);
				continue;
			case 179u:
				roleKey2 = ResourceStrings.ResStrings[0];
				num2 = (int)((num * 1738897235) ^ 0x74562E56);
				continue;
			case 269u:
				goto IL_71ac;
			case 1296u:
				goto IL_71d7;
			case 87u:
				text7 = string.Empty;
				num2 = ((int)num * -821057759) ^ -2031669354;
				continue;
			case 21u:
				roleKey38 = ResourceStrings.ResStrings[0];
				num2 = (int)((num * 1713769807) ^ 0x2DEB9EE1);
				continue;
			case 442u:
				return true;
			case 737u:
				roleKey42 = ResourceStrings.ResStrings[0];
				num2 = (int)(num * 556961678) ^ -1500664704;
				continue;
			case 795u:
				goto IL_7279;
			case 1019u:
				goto IL_72df;
			case 430u:
				goto IL_730a;
			case 1342u:
				return false;
			case 951u:
				return result7;
			case 70u:
				roleKey27 = string.Empty;
				num2 = -2129611218;
				continue;
			case 1285u:
				return false;
			case 392u:
				return true;
			case 816u:
				num212 = 0;
				num2 = ((int)num * -1603947363) ^ 0x1DF7AF45;
				continue;
			case 96u:
				return true;
			case 243u:
				num2 = ((int)num * -703648430) ^ -958446747;
				continue;
			case 17u:
				roleKey20 = ResourceStrings.ResStrings[0];
				num2 = (int)(num * 495198864) ^ -1030081656;
				continue;
			case 67u:
				roleKey54 = ResourceStrings.ResStrings[0];
				num2 = ((int)num * -1489574307) ^ -1010251505;
				continue;
			case 1010u:
				return false;
			case 842u:
				num2 = (int)((num * 527936080) ^ 0x25836B23);
				continue;
			case 0u:
				return false;
			case 1232u:
			{
				int num548;
				int num549;
				if (array51.Length >= 1)
				{
					num548 = -1639127781;
					num549 = num548;
				}
				else
				{
					num548 = -16864039;
					num549 = num548;
				}
				num2 = num548 ^ ((int)num * -1692634546);
				continue;
			}
			case 662u:
				num143 = RuntimeData.Instance.GetRolesEquipment(text6, num144);
				num2 = -2127313357;
				continue;
			case 689u:
			{
				int num546;
				int num547;
				if (array30.Length >= 1)
				{
					num546 = 748305782;
					num547 = num546;
				}
				else
				{
					num546 = 1869709928;
					num547 = num546;
				}
				num2 = num546 ^ ((int)num * -1788945945);
				continue;
			}
			case 1080u:
				roleKey24 = array19[0];
				num212 = int.Parse(array19[1]);
				num2 = -669237355;
				continue;
			case 1286u:
				roleKey18 = string.Empty;
				num2 = -926434295;
				continue;
			case 313u:
				teamRole11 = RuntimeData.Instance.GetTeamRole(roleKey2);
				num2 = -1415283361;
				continue;
			case 1195u:
			{
				int num544;
				int num545;
				if (teamRole10 == null)
				{
					num544 = -1776330393;
					num545 = num544;
				}
				else
				{
					num544 = -1759214799;
					num545 = num544;
				}
				num2 = num544 ^ ((int)num * -1684125924);
				continue;
			}
			case 511u:
				num162 = int.Parse(array34[2]);
				num2 = (int)(num * 562030165) ^ -1842167717;
				continue;
			case 740u:
				roleKey = array42[0];
				num2 = -1373609792;
				continue;
			case 651u:
				return true;
			case 1040u:
			{
				int num542;
				int num543;
				if (!RuntimeData.Instance.KeyValues.ContainsKey(condition.value))
				{
					num542 = 2073449998;
					num543 = num542;
				}
				else
				{
					num542 = 974198967;
					num543 = num542;
				}
				num2 = num542 ^ (int)(num * 667198200);
				continue;
			}
			case 514u:
				teamRole39 = RuntimeData.Instance.GetTeamRole(roleKey9);
				num2 = -983544022;
				continue;
			case 959u:
				teamRole26 = RuntimeData.Instance.GetTeamRole(roleKey53);
				num2 = (int)((num * 1714356306) ^ 0xD371B3);
				continue;
			case 576u:
				roleKey53 = ResourceStrings.ResStrings[0];
				num2 = ((int)num * -652177278) ^ 0x39F14364;
				continue;
			case 1093u:
				roleKey31 = array54[0];
				num2 = -1042462718;
				continue;
			case 710u:
				roleKey51 = array47[0];
				text38 = array47[1];
				num240 = int.Parse(array47[2]);
				num2 = -2007847070;
				continue;
			case 839u:
				roleKey3 = array50[0];
				num2 = -1575250732;
				continue;
			case 832u:
				array25 = condition.value.Split('#');
				num2 = ((int)num * -807663038) ^ -248482898;
				continue;
			case 363u:
				num113 = 0;
				num2 = ((int)num * -581630255) ^ 0x2294044;
				continue;
			case 808u:
				return true;
			case 184u:
			{
				int num540;
				int num541;
				if (array37.Length == 1)
				{
					num540 = -835368539;
					num541 = num540;
				}
				else
				{
					num540 = -57619251;
					num541 = num540;
				}
				num2 = num540 ^ ((int)num * -689335212);
				continue;
			}
			case 1187u:
				return false;
			case 108u:
				return false;
			case 690u:
				goto IL_76f6;
			case 770u:
				roleKey48 = ResourceStrings.ResStrings[0];
				num437 = int.Parse(array74[0]);
				num2 = (int)(num * 1727513746) ^ -1249560939;
				continue;
			case 739u:
			{
				int num538;
				int num539;
				if (teamRole38 != null)
				{
					num538 = -339562653;
					num539 = num538;
				}
				else
				{
					num538 = -732615964;
					num539 = num538;
				}
				num2 = num538 ^ ((int)num * -1571251133);
				continue;
			}
			case 94u:
				text9 = string.Empty;
				num2 = (int)(num * 1219336194) ^ -704181292;
				continue;
			case 1065u:
			{
				int num534;
				int num535;
				if (array62.Length != 1)
				{
					num534 = -876204703;
					num535 = num534;
				}
				else
				{
					num534 = -401298281;
					num535 = num534;
				}
				num2 = num534 ^ (int)(num * 1751997112);
				continue;
			}
			case 1252u:
				goto IL_77b6;
			case 1022u:
				text21 = array71[0];
				num2 = ((int)num * -347218237) ^ -1055383582;
				continue;
			case 517u:
			{
				string text48 = text9.Replace(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1875398881u), RuntimeData.Instance.RoundString());
				string oldValue15 = global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2783180816u);
				num75 = teamRole26.MAX_SKILL_LEVEL;
				int num525 = (int)double.Parse(Tools.Compute(text48.Replace(oldValue15, num75.ToString())));
				int num526;
				int num527;
				if (teamRole26.GetSkillLevel(text8) >= num525)
				{
					num526 = -1957013658;
					num527 = num526;
				}
				else
				{
					num526 = -320914271;
					num527 = num526;
				}
				num2 = num526 ^ (int)(num * 1604769804);
				continue;
			}
			case 220u:
				num2 = ((int)num * -1609780081) ^ -1306404809;
				continue;
			case 602u:
				if (!string.IsNullOrEmpty(array60[2]))
				{
					num524 = int.Parse(array60[2]);
					goto IL_5a51;
				}
				num2 = (int)(num * 1097871961) ^ -1683562801;
				continue;
			case 550u:
				goto IL_78a9;
			case 205u:
				teamRole32 = RuntimeData.Instance.GetTeamRole(array20[0]);
				num2 = -940073883;
				continue;
			case 628u:
				roleKey55 = array36[0];
				text15 = array36[1];
				num2 = -1744573777;
				continue;
			case 29u:
				goto IL_790e;
			case 48u:
				goto IL_7939;
			case 257u:
				goto IL_7964;
			case 601u:
				return false;
			case 77u:
				return false;
			case 502u:
			{
				int num520;
				int num521;
				if (array18.Length != 1)
				{
					num520 = 385831502;
					num521 = num520;
				}
				else
				{
					num520 = 1710724282;
					num521 = num520;
				}
				num2 = num520 ^ ((int)num * -919243841);
				continue;
			}
			case 138u:
				return true;
			case 339u:
				return RuntimeData.Instance.Round >= int.Parse(condition.value);
			case 111u:
			{
				string text47 = text27.Replace(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1875398881u), RuntimeData.Instance.RoundString());
				string oldValue14 = global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1878257442u);
				num75 = teamRole12.MAX_ATTRIBUTE;
				num169 = (int)double.Parse(Tools.Compute(text47.Replace(oldValue14, num75.ToString())));
				num2 = -2101899113;
				continue;
			}
			case 752u:
			{
				int num516;
				int num517;
				if (item2.type != 4)
				{
					num516 = -1900425413;
					num517 = num516;
				}
				else
				{
					num516 = -2059463620;
					num517 = num516;
				}
				num2 = num516 ^ ((int)num * -1979971113);
				continue;
			}
			case 608u:
				num314 = int.Parse(array62[0]);
				num2 = ((int)num * -1603480646) ^ 0x28307215;
				continue;
			case 1140u:
			{
				int num514;
				int num515;
				if (internalSkillLevel >= num240)
				{
					num514 = -2010827068;
					num515 = num514;
				}
				else
				{
					num514 = -1352916618;
					num515 = num514;
				}
				num2 = num514 ^ (int)(num * 96490398);
				continue;
			}
			case 1134u:
				num2 = ((int)num * -111614214) ^ 0x1692004C;
				continue;
			case 782u:
				num2 = (int)(num * 1016031814) ^ -379696078;
				continue;
			case 465u:
			{
				string text46 = text12.Replace(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3250051652u), RuntimeData.Instance.RoundString());
				string oldValue13 = global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1878257442u);
				num75 = teamRole5.MAX_ATTRIBUTE;
				num127 = (int)double.Parse(Tools.Compute(text46.Replace(oldValue13, num75.ToString())));
				num2 = -1429641053;
				continue;
			}
			case 93u:
				return ModData.Nicks.Contains(condition.value);
			case 227u:
				teamRole34 = RuntimeData.Instance.GetTeamRole(roleKey44);
				num2 = -1262294203;
				continue;
			case 606u:
				goto IL_7ba4;
			case 874u:
			{
				int num512;
				int num513;
				if (Tools.IsChineseTime(RuntimeData.Instance.Date, text37[0]))
				{
					num512 = 1543883588;
					num513 = num512;
				}
				else
				{
					num512 = 2078097159;
					num513 = num512;
				}
				num2 = num512 ^ (int)(num * 971735850);
				continue;
			}
			case 636u:
				array43 = condition.value.Split('#');
				num2 = ((int)num * -672263722) ^ -864684315;
				continue;
			case 165u:
				goto IL_7c2f;
			case 150u:
			{
				int num508;
				int num509;
				if (item2.type != 3)
				{
					num508 = -1784840460;
					num509 = num508;
				}
				else
				{
					num508 = -151036654;
					num509 = num508;
				}
				num2 = num508 ^ (int)(num * 2006491965);
				continue;
			}
			case 1007u:
				array73 = condition.value.Split('#');
				num2 = ((int)num * -1005590643) ^ 0x343A6C7B;
				continue;
			case 818u:
				num507++;
				num2 = -1265846220;
				continue;
			case 1202u:
			{
				string text45 = text22.Replace(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3121341046u), RuntimeData.Instance.RoundString());
				string oldValue12 = global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2783180816u);
				num75 = teamRole6.MAX_SKILL_LEVEL;
				num315 = (int)double.Parse(Tools.Compute(text45.Replace(oldValue12, num75.ToString())));
				num2 = ((int)num * -1622986792) ^ -411502700;
				continue;
			}
			case 611u:
				roleKey5 = string.Empty;
				text4 = string.Empty;
				num2 = -2127067015;
				continue;
			case 864u:
				return true;
			case 171u:
				text16 = array45[1];
				num2 = ((int)num * -1283794904) ^ -1392579618;
				continue;
			case 963u:
				return true;
			case 73u:
				return true;
			case 447u:
			{
				int num503;
				int num504;
				if (array12.Length >= 1)
				{
					num503 = 101493533;
					num504 = num503;
				}
				else
				{
					num503 = 1264973640;
					num504 = num503;
				}
				num2 = num503 ^ (int)(num * 582969855);
				continue;
			}
			case 1175u:
				roleKey = ResourceStrings.ResStrings[0];
				num502 = int.Parse(array42[0]);
				num2 = (int)((num * 1151810076) ^ 0x6EBFF5C0);
				continue;
			case 56u:
				text16 = string.Empty;
				num2 = (int)(num * 288961714) ^ -668757068;
				continue;
			case 118u:
				num388 = int.Parse(array39[0]);
				num2 = (int)(num * 992886554) ^ -722796158;
				continue;
			case 616u:
				return RuntimeData.Instance.Daode >= int.Parse(condition.value);
			case 723u:
				goto IL_7e5f;
			case 954u:
				goto IL_7e8a;
			case 1101u:
				num2 = (int)(num * 775980881) ^ -1009631165;
				continue;
			case 1155u:
				goto IL_7ecb;
			case 727u:
				num2 = ((int)num * -742685224) ^ 0x5863F78F;
				continue;
			case 109u:
				return false;
			case 1302u:
				roleKey26 = ResourceStrings.ResStrings[0];
				num2 = ((int)num * -404530800) ^ -452887552;
				continue;
			case 692u:
				num2 = (int)((num * 1209904784) ^ 0x4AD9F89C);
				continue;
			case 1098u:
				roleKey45 = ResourceStrings.ResStrings[0];
				num2 = (int)(num * 1692847610) ^ -417420728;
				continue;
			case 479u:
				num2 = (int)(num * 1642565907) ^ -282901410;
				continue;
			case 921u:
				text23 = array59[1];
				num2 = ((int)num * -745262531) ^ 0x7E6FA2D6;
				continue;
			case 1058u:
				roleKey47 = ResourceStrings.ResStrings[0];
				text20 = array21[0];
				num2 = (int)(num * 2102046931) ^ -515734898;
				continue;
			case 391u:
				goto IL_7fd8;
			case 1304u:
				teamRole40 = RuntimeData.Instance.GetTeamRole(roleKey34);
				num2 = -647474046;
				continue;
			case 33u:
			{
				int num498;
				int num499;
				if (array54.Length != 1)
				{
					num498 = -433602228;
					num499 = num498;
				}
				else
				{
					num498 = -58023007;
					num499 = num498;
				}
				num2 = num498 ^ ((int)num * -1289088621);
				continue;
			}
			case 154u:
				return false;
			case 759u:
				return false;
			case 1278u:
				roleKey43 = array18[0];
				num2 = -1568012781;
				continue;
			case 3u:
				return RuntimeData.Instance.Team[0].HasTalent(array69[0]);
			case 1049u:
			{
				int num492;
				int num493;
				if (role5 != null)
				{
					num492 = 1618308288;
					num493 = num492;
				}
				else
				{
					num492 = 2117471287;
					num493 = num492;
				}
				num2 = num492 ^ (int)(num * 54370762);
				continue;
			}
			case 314u:
				return false;
			case 204u:
				return false;
			case 346u:
				return false;
			case 728u:
				return RuntimeData.Instance.getHaogan(roleKey28) < num231;
			case 285u:
				return false;
			case 999u:
				goto IL_813e;
			case 854u:
			{
				int num486;
				int num487;
				if (item2.type == 12)
				{
					num486 = -1934283908;
					num487 = num486;
				}
				else
				{
					num486 = -1132767011;
					num487 = num486;
				}
				num2 = num486 ^ ((int)num * -1386122463);
				continue;
			}
			case 219u:
				num485++;
				num2 = -980545959;
				continue;
			case 909u:
			{
				int num483;
				int num484;
				if (array32.Length == 1)
				{
					num483 = -849820099;
					num484 = num483;
				}
				else
				{
					num483 = -876116152;
					num484 = num483;
				}
				num2 = num483 ^ (int)(num * 502000644);
				continue;
			}
			case 155u:
				return true;
			case 272u:
			{
				int num481;
				int num482;
				if (!RuntimeData.Instance.KeyValues.ContainsKey(_206C_202D_202B_202C_202E_206C_202C_206C_200C_202C_202D_200F_206C_206A_206A_200D_200E_202D_200D_206E_200F_200C_206F_202A_200D_202A_206D_206E_206F_206D_206A_206C_206B_200E_202A_206F_202B_202A_206A_206E_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3150541448u), condition.value)))
				{
					num481 = 1426282599;
					num482 = num481;
				}
				else
				{
					num481 = 341851543;
					num482 = num481;
				}
				num2 = num481 ^ ((int)num * -1441210593);
				continue;
			}
			case 1029u:
				num2 = ((int)num * -1512262877) ^ -822809103;
				continue;
			case 850u:
				num2 = ((int)num * -1546505616) ^ 0x580FE229;
				continue;
			case 745u:
			{
				int num479;
				int num480;
				if (ModData.ZhenlongqijuLevel >= int.Parse(condition.value))
				{
					num479 = -125235563;
					num480 = num479;
				}
				else
				{
					num479 = -2004844458;
					num480 = num479;
				}
				num2 = num479 ^ ((int)num * -1342794108);
				continue;
			}
			case 894u:
				text44 = array24[1];
				num2 = ((int)num * -786512598) ^ -2126648052;
				continue;
			case 1130u:
			{
				int num473;
				int num474;
				if (array36.Length >= 1)
				{
					num473 = 1331682236;
					num474 = num473;
				}
				else
				{
					num473 = 1351058327;
					num474 = num473;
				}
				num2 = num473 ^ ((int)num * -1748835492);
				continue;
			}
			case 1037u:
				goto IL_82d3;
			case 599u:
				return false;
			case 1239u:
				num2 = ((int)num * -326750429) ^ 0x5FDF346A;
				continue;
			case 630u:
				roleKey47 = array21[0];
				num2 = -447357131;
				continue;
			case 548u:
				num110 += RuntimeData.Instance.GetItemsCount(text2);
				num2 = (int)((num * 1248092074) ^ 0x4EEAB63F);
				continue;
			case 938u:
				return true;
			case 1193u:
				text43 = array18[1];
				num2 = (int)((num * 1078937216) ^ 0x5A8FCB5C);
				continue;
			case 471u:
				return false;
			case 323u:
			{
				int num470;
				int num471;
				if (array17.Length == 1)
				{
					num470 = -918699193;
					num471 = num470;
				}
				else
				{
					num470 = -888327567;
					num471 = num470;
				}
				num2 = num470 ^ (int)(num * 1107712654);
				continue;
			}
			case 1039u:
				text20 = array21[1];
				num2 = (int)(num * 852359407) ^ -232795895;
				continue;
			case 1288u:
				if (ResourceManager.Get<InternalSkill>(text7) != null)
				{
					num432 = 1;
					goto IL_43d6;
				}
				num2 = -1638907673;
				continue;
			case 1074u:
				return true;
			case 354u:
				roleKey44 = array44[0];
				num2 = -845327695;
				continue;
			case 65u:
				array18 = condition.value.Split('#');
				num2 = ((int)num * -883593457) ^ 0x5A85B308;
				continue;
			case 18u:
				num2 = ((int)num * -1638595268) ^ 0x4704DFD5;
				continue;
			case 1153u:
			{
				int num464;
				int num465;
				if (!RuntimeData.Instance.KeyValues.ContainsKey(_206C_202D_202B_202C_202E_206C_202C_206C_200C_202C_202D_200F_206C_206A_206A_200D_200E_202D_200D_206E_200F_200C_206F_202A_200D_202A_206D_206E_206F_206D_206A_206C_206B_200E_202A_206F_202B_202A_206A_206E_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4056663661u), condition.value)))
				{
					num464 = 1422657904;
					num465 = num464;
				}
				else
				{
					num464 = 360354616;
					num465 = num464;
				}
				num2 = num464 ^ ((int)num * -1641513698);
				continue;
			}
			case 673u:
				text = array70[0];
				num2 = (int)(num * 470456757) ^ -1007437832;
				continue;
			case 1227u:
				goto IL_84bd;
			case 716u:
				goto IL_84e3;
			case 1231u:
				result7 = false;
				num2 = ((int)num * -1313681498) ^ 0x32638877;
				continue;
			case 40u:
				goto IL_852a;
			case 83u:
				goto IL_859f;
			case 663u:
			{
				string text40 = text34.Replace(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1875398881u), RuntimeData.Instance.RoundString());
				string oldValue9 = global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1878257442u);
				num75 = teamRole27.MAX_ATTRIBUTE;
				num292 = (int)double.Parse(Tools.Compute(text40.Replace(oldValue9, num75.ToString())));
				num2 = -1470798628;
				continue;
			}
			case 304u:
				roleKey51 = string.Empty;
				text38 = string.Empty;
				num2 = -257617589;
				continue;
			case 167u:
				roleKey36 = string.Empty;
				num158 = 0;
				num2 = -1277513741;
				continue;
			case 1142u:
				text3 = string.Empty;
				num2 = (int)((num * 1748976983) ^ 0xE842551);
				continue;
			case 676u:
				num463 = 0;
				goto IL_8660;
			case 1160u:
				num2 = ((int)num * -2051551985) ^ 0x674D4BFE;
				continue;
			case 738u:
			{
				array15 = condition.value.Split('#');
				int num461;
				int num462;
				if (array15.Length >= 1)
				{
					num461 = -685000152;
					num462 = num461;
				}
				else
				{
					num461 = -1122471176;
					num462 = num461;
				}
				num2 = num461 ^ (int)(num * 891779794);
				continue;
			}
			case 1070u:
			{
				int num457;
				int num458;
				if (array38.Length == 1)
				{
					num457 = -140512720;
					num458 = num457;
				}
				else
				{
					num457 = -1953865867;
					num458 = num457;
				}
				num2 = num457 ^ ((int)num * -201830060);
				continue;
			}
			case 566u:
				num2 = ((int)num * -378322496) ^ -137182741;
				continue;
			case 734u:
			{
				num143 = 0;
				int num453;
				int num454;
				if (num452 > 0)
				{
					num453 = -548668835;
					num454 = num453;
				}
				else
				{
					num453 = -568279587;
					num454 = num453;
				}
				num2 = num453 ^ (int)(num * 567442989);
				continue;
			}
			case 829u:
				return false;
			case 977u:
			{
				text28 = string.Empty;
				int num448;
				int num449;
				if (array68.Length == 1)
				{
					num448 = -1654366302;
					num449 = num448;
				}
				else
				{
					num448 = -1190954768;
					num449 = num448;
				}
				num2 = num448 ^ (int)(num * 508939675);
				continue;
			}
			case 310u:
				return true;
			case 724u:
				return false;
			case 1222u:
			{
				int num445;
				int num446;
				if (array63.Length >= 1)
				{
					num445 = 1931522315;
					num446 = num445;
				}
				else
				{
					num445 = 585821415;
					num446 = num445;
				}
				num2 = num445 ^ ((int)num * -668824968);
				continue;
			}
			case 191u:
				num2 = ((int)num * -788077590) ^ 0x37E346CF;
				continue;
			case 626u:
				return false;
			case 337u:
				text29 = array55[0];
				num2 = ((int)num * -1094341719) ^ -1974627754;
				continue;
			case 1309u:
				return false;
			case 670u:
			{
				int num442;
				int num443;
				if (RuntimeData.Instance.InTeam(condition.value))
				{
					num442 = 2001515253;
					num443 = num442;
				}
				else
				{
					num442 = 1606253090;
					num443 = num442;
				}
				num2 = num442 ^ ((int)num * -815044191);
				continue;
			}
			case 202u:
				goto IL_8834;
			case 50u:
				teamRole14 = RuntimeData.Instance.GetTeamRole(roleKey47);
				num2 = -784773446;
				continue;
			case 92u:
				roleKey49 = ResourceStrings.ResStrings[0];
				num2 = (int)(num * 57508546) ^ -1035878983;
				continue;
			case 468u:
				goto IL_8899;
			case 1324u:
			{
				int num438;
				int num439;
				if (teamRole30 != null)
				{
					num438 = -104542370;
					num439 = num438;
				}
				else
				{
					num438 = -255537845;
					num439 = num438;
				}
				num2 = num438 ^ (int)(num * 351656390);
				continue;
			}
			case 1325u:
				roleKey48 = array74[0];
				num437 = int.Parse(array74[1]);
				num2 = -2050289999;
				continue;
			case 26u:
				return true;
			case 185u:
				return RuntimeData.Instance.Team[0].HasRoleTalent(array64[0]);
			case 1109u:
				goto IL_894c;
			case 1329u:
			{
				int num433;
				int num434;
				if (array70.Length != 0)
				{
					num433 = -900488377;
					num434 = num433;
				}
				else
				{
					num433 = -1685654598;
					num434 = num433;
				}
				num2 = num433 ^ ((int)num * -208874487);
				continue;
			}
			case 298u:
				return false;
			case 142u:
				goto IL_89b2;
			case 1211u:
				return true;
			case 1173u:
				return false;
			case 801u:
				array63 = condition.value.Split('#');
				num2 = (int)(num * 926146758) ^ -1651361286;
				continue;
			case 1169u:
				goto IL_8a38;
			case 736u:
				return false;
			case 174u:
				roleKey37 = ResourceStrings.ResStrings[0];
				num2 = (int)((num * 5766170) ^ 0x7282FFE8);
				continue;
			case 991u:
				goto IL_8a9c;
			case 1090u:
				goto IL_8ac7;
			case 328u:
				goto IL_8af2;
			case 444u:
			{
				int num430;
				int num431;
				if (array75.Length >= 1)
				{
					num430 = 1479641948;
					num431 = num430;
				}
				else
				{
					num430 = 566504561;
					num431 = num430;
				}
				num2 = num430 ^ ((int)num * -986728720);
				continue;
			}
			case 799u:
				result6 = true;
				num2 = -1740327449;
				continue;
			case 72u:
				num2 = (int)((num * 243278687) ^ 0x2870F09C);
				continue;
			case 915u:
			{
				int num424;
				int num425;
				if (flag2)
				{
					num424 = -603636583;
					num425 = num424;
				}
				else
				{
					num424 = -1285745866;
					num425 = num424;
				}
				num2 = num424 ^ (int)(num * 899976906);
				continue;
			}
			case 990u:
				goto IL_8b7e;
			case 170u:
				goto IL_8ba9;
			case 235u:
			{
				int num422;
				int num423;
				if (array65.Length != 1)
				{
					num422 = 1954067528;
					num423 = num422;
				}
				else
				{
					num422 = 1836613998;
					num423 = num422;
				}
				num2 = num422 ^ ((int)num * -2129265626);
				continue;
			}
			case 945u:
				num240 = 0;
				num2 = (int)((num * 756648574) ^ 0x75E603DA);
				continue;
			case 866u:
				goto IL_8c12;
			case 1067u:
			{
				int num420;
				int num421;
				if (item2.type != 2)
				{
					num420 = -1762427800;
					num421 = num420;
				}
				else
				{
					num420 = -99018566;
					num421 = num420;
				}
				num2 = num420 ^ (int)(num * 945364405);
				continue;
			}
			case 767u:
				goto IL_8c5a;
			case 412u:
				goto IL_8ccf;
			case 647u:
			{
				int num418;
				int num419;
				if (array60.Length <= 1)
				{
					num418 = 1766864839;
					num419 = num418;
				}
				else
				{
					num418 = 83418379;
					num419 = num418;
				}
				num2 = num418 ^ ((int)num * -301159077);
				continue;
			}
			case 685u:
				return true;
			case 455u:
				return RuntimeData.Instance.Round < int.Parse(condition.value);
			case 960u:
				return true;
			case 1297u:
				array23 = condition.value.Split('#');
				num2 = (int)(num * 580278766) ^ -1668786012;
				continue;
			case 587u:
				roleKey19 = string.Empty;
				num2 = -1601985509;
				continue;
			case 903u:
			{
				int num416;
				int num417;
				if (teamRole12 != null)
				{
					num416 = -1847817337;
					num417 = num416;
				}
				else
				{
					num416 = -776902550;
					num417 = num416;
				}
				num2 = num416 ^ (int)(num * 1282247966);
				continue;
			}
			case 955u:
				text33 = string.Empty;
				num2 = (int)((num * 968889651) ^ 0x577C27D6);
				continue;
			case 493u:
				return false;
			case 116u:
			{
				int num412;
				int num413;
				if (array68.Length < 1)
				{
					num412 = 1710964857;
					num413 = num412;
				}
				else
				{
					num412 = 904969736;
					num413 = num412;
				}
				num2 = num412 ^ (int)(num * 968493109);
				continue;
			}
			case 635u:
				roleKey26 = string.Empty;
				num225 = 0;
				num2 = -2081342325;
				continue;
			case 484u:
				return false;
			case 206u:
				goto IL_8e50;
			case 1000u:
			{
				int num408;
				int num409;
				if (array31.Length == 1)
				{
					num408 = 239454176;
					num409 = num408;
				}
				else
				{
					num408 = 692660985;
					num409 = num408;
				}
				num2 = num408 ^ ((int)num * -1055628261);
				continue;
			}
			case 539u:
				num2 = ((int)num * -1317129533) ^ -1582422943;
				continue;
			case 847u:
				goto IL_8eb6;
			case 1328u:
				num2 = (int)((num * 2015282345) ^ 0x62EF7AAC);
				continue;
			case 846u:
				return false;
			case 590u:
			{
				int num404;
				int num405;
				if (array54.Length >= 1)
				{
					num404 = -243409637;
					num405 = num404;
				}
				else
				{
					num404 = -1754987419;
					num405 = num404;
				}
				num2 = num404 ^ ((int)num * -115847814);
				continue;
			}
			case 456u:
				goto IL_8f34;
			case 568u:
				goto IL_8f58;
			case 1161u:
				roleKey47 = string.Empty;
				text20 = string.Empty;
				num2 = -390034957;
				continue;
			case 871u:
				goto IL_8f95;
			case 755u:
				return false;
			case 748u:
			{
				int num402;
				int num403;
				if (num143 == 0)
				{
					num402 = 1599184487;
					num403 = num402;
				}
				else
				{
					num402 = 403369983;
					num403 = num402;
				}
				num2 = num402 ^ (int)(num * 229174094);
				continue;
			}
			case 1154u:
				return true;
			case 679u:
				goto IL_8ffe;
			case 166u:
				roleKey28 = ResourceStrings.ResStrings[9];
				num231 = int.Parse(array52[0]);
				num2 = ((int)num * -309989388) ^ 0x15BE9E04;
				continue;
			case 1046u:
			{
				int num398;
				int num399;
				if (item2.type == 1)
				{
					num398 = -1886610238;
					num399 = num398;
				}
				else
				{
					num398 = -539514278;
					num399 = num398;
				}
				num2 = num398 ^ ((int)num * -859947076);
				continue;
			}
			case 885u:
			{
				int num396;
				int num397;
				if (item2.type == 3)
				{
					num396 = 2057435068;
					num397 = num396;
				}
				else
				{
					num396 = 980626377;
					num397 = num396;
				}
				num2 = num396 ^ ((int)num * -1207070723);
				continue;
			}
			case 175u:
				goto IL_90ac;
			case 264u:
				return true;
			case 480u:
				return false;
			case 222u:
				goto IL_9105;
			case 441u:
				roleKey15 = ResourceStrings.ResStrings[0];
				num2 = (int)(num * 1294767415) ^ -2065386130;
				continue;
			case 386u:
				goto IL_9152;
			case 896u:
			{
				int num391;
				int num392;
				if (array12.Length != 1)
				{
					num391 = 61506202;
					num392 = num391;
				}
				else
				{
					num391 = 1315905801;
					num392 = num391;
				}
				num2 = num391 ^ ((int)num * -2030032342);
				continue;
			}
			case 207u:
				return false;
			case 610u:
				return false;
			case 711u:
				return true;
			case 139u:
			{
				int num389;
				int num390;
				if (array21.Length < 1)
				{
					num389 = 1868772479;
					num390 = num389;
				}
				else
				{
					num389 = 1456452937;
					num390 = num389;
				}
				num2 = num389 ^ (int)(num * 1451755566);
				continue;
			}
			case 1078u:
				roleKey40 = string.Empty;
				num2 = -504200981;
				continue;
			case 1055u:
				roleKey46 = string.Empty;
				text34 = string.Empty;
				num2 = -1004091070;
				continue;
			case 793u:
				num2 = (int)(num * 1900368267) ^ -832083278;
				continue;
			case 834u:
				num388 = int.Parse(array39[1]);
				num2 = (int)((num * 607780526) ^ 0xB6AA4BA);
				continue;
			case 379u:
			{
				int num386;
				int num387;
				if (item.type != 3)
				{
					num386 = 1254493090;
					num387 = num386;
				}
				else
				{
					num386 = 2074976234;
					num387 = num386;
				}
				num2 = num386 ^ (int)(num * 617985970);
				continue;
			}
			case 890u:
				return false;
			case 366u:
			{
				int num384;
				int num385;
				if (teamRole20 != null)
				{
					num384 = 1567420082;
					num385 = num384;
				}
				else
				{
					num384 = 671822311;
					num385 = num384;
				}
				num2 = num384 ^ (int)(num * 397592656);
				continue;
			}
			case 449u:
				skillLevel = teamRole35.GetSkillLevel(text38);
				num2 = -374663180;
				continue;
			case 470u:
				return true;
			case 644u:
				roleByName = RuntimeData.Instance.GetRoleByName(condition.value);
				num2 = ((int)num * -1056121712) ^ -2081092932;
				continue;
			case 1208u:
				text37 = array10[num75];
				num2 = -830070320;
				continue;
			case 1323u:
				text27 = string.Empty;
				num2 = ((int)num * -1031390760) ^ 0x7C7F1099;
				continue;
			case 320u:
				num2 = ((int)num * -503080546) ^ -1024804705;
				continue;
			case 974u:
				goto IL_9337;
			case 600u:
				roleKey27 = array29[0];
				num155 = int.Parse(array29[1]);
				num2 = -1250089894;
				continue;
			case 431u:
			{
				int num382;
				int num383;
				if (teamRole4 != null)
				{
					num382 = 395950935;
					num383 = num382;
				}
				else
				{
					num382 = 597227862;
					num383 = num382;
				}
				num2 = num382 ^ ((int)num * -26383785);
				continue;
			}
			case 1279u:
			{
				int num378;
				int num379;
				if (teamRole34 != null)
				{
					num378 = -1074230332;
					num379 = num378;
				}
				else
				{
					num378 = -373521223;
					num379 = num378;
				}
				num2 = num378 ^ (int)(num * 924817176);
				continue;
			}
			case 277u:
				return false;
			case 311u:
				goto IL_93de;
			case 1271u:
				goto IL_9409;
			case 374u:
				roleKey42 = array72[0];
				num339 = int.Parse(array72[1]);
				num2 = -831989242;
				continue;
			case 575u:
			{
				int num376;
				int num377;
				if (array71.Length == 1)
				{
					num376 = -454464585;
					num377 = num376;
				}
				else
				{
					num376 = -987854313;
					num377 = num376;
				}
				num2 = num376 ^ ((int)num * -650586531);
				continue;
			}
			case 580u:
				goto IL_9475;
			case 467u:
				return true;
			case 1178u:
				return false;
			case 888u:
				num2 = ((int)num * -1566763818) ^ 0x34BC6E16;
				continue;
			case 553u:
				num232 = int.Parse(array53[1]);
				num2 = (int)(num * 20126029) ^ -727951940;
				continue;
			case 36u:
				roleKey25 = ResourceStrings.ResStrings[0];
				num2 = (int)((num * 1405900713) ^ 0xBE8E7C3);
				continue;
			case 1339u:
				num110 = RuntimeData.Instance.GetXiangziCount(text2);
				num2 = (int)((num * 691596090) ^ 0x73681D5E);
				continue;
			case 695u:
				return true;
			case 1081u:
				goto IL_9558;
			case 1001u:
				roleKey45 = array39[0];
				num2 = -91061448;
				continue;
			case 944u:
				roleKey33 = array59[0];
				num2 = -1936478365;
				continue;
			case 369u:
				num2 = ((int)num * -1684693897) ^ -457543980;
				continue;
			case 1063u:
				return false;
			case 349u:
			{
				int num371;
				int num372;
				if (array69.Length < 1)
				{
					num371 = -579684816;
					num372 = num371;
				}
				else
				{
					num371 = -602230308;
					num372 = num371;
				}
				num2 = num371 ^ (int)(num * 1565004919);
				continue;
			}
			case 187u:
			{
				int num369;
				int num370;
				if (item != null)
				{
					num369 = 1041471236;
					num370 = num369;
				}
				else
				{
					num369 = 670673549;
					num370 = num369;
				}
				num2 = num369 ^ ((int)num * -1809455129);
				continue;
			}
			case 563u:
			{
				int num365;
				int num366;
				if (item.type != 3)
				{
					num365 = 1290597648;
					num366 = num365;
				}
				else
				{
					num365 = 1272487108;
					num366 = num365;
				}
				num2 = num365 ^ (int)(num * 834295254);
				continue;
			}
			case 101u:
				teamRole12 = RuntimeData.Instance.GetTeamRole(roleKey35);
				num2 = -100571203;
				continue;
			case 603u:
				return false;
			case 768u:
			{
				int num363;
				int num364;
				if (teamRole33 != null)
				{
					num363 = -459229489;
					num364 = num363;
				}
				else
				{
					num363 = -76838216;
					num364 = num363;
				}
				num2 = num363 ^ ((int)num * -2052900699);
				continue;
			}
			case 733u:
				return false;
			case 594u:
			{
				int num357;
				int num358;
				if (item2 == null)
				{
					num357 = 1642165046;
					num358 = num357;
				}
				else
				{
					num357 = 1363461368;
					num358 = num357;
				}
				num2 = num357 ^ (int)(num * 601506755);
				continue;
			}
			case 677u:
			{
				int num354;
				int num355;
				if (array33.Length < 1)
				{
					num354 = -775165167;
					num355 = num354;
				}
				else
				{
					num354 = -955319681;
					num355 = num354;
				}
				num2 = num354 ^ (int)(num * 165437639);
				continue;
			}
			case 321u:
				goto IL_96ed;
			case 863u:
			{
				int num352;
				int num353;
				if (teamRole32 != null)
				{
					num352 = 1475721641;
					num353 = num352;
				}
				else
				{
					num352 = 1508235012;
					num353 = num352;
				}
				num2 = num352 ^ ((int)num * -617976780);
				continue;
			}
			case 58u:
			{
				int num348;
				int num349;
				if (timeSpan.Days <= int.Parse(condition.value))
				{
					num348 = 854719515;
					num349 = num348;
				}
				else
				{
					num348 = 588894558;
					num349 = num348;
				}
				num2 = num348 ^ (int)(num * 1477535870);
				continue;
			}
			case 786u:
				goto IL_976c;
			case 899u:
				roleKey7 = array55[0];
				text29 = array55[1];
				num2 = -1528774742;
				continue;
			case 1212u:
				roleKey14 = ResourceStrings.ResStrings[0];
				num2 = ((int)num * -995312611) ^ 0x2ECA1CF3;
				continue;
			case 913u:
				goto IL_97c8;
			case 557u:
				return false;
			case 555u:
			{
				int num346;
				int num347;
				if (item2.type == 2)
				{
					num346 = 939221677;
					num347 = num346;
				}
				else
				{
					num346 = 1944824072;
					num347 = num346;
				}
				num2 = num346 ^ (int)(num * 1249511272);
				continue;
			}
			case 513u:
				return false;
			case 1254u:
			{
				int num342;
				int num343;
				if (array52.Length != 1)
				{
					num342 = -520701946;
					num343 = num342;
				}
				else
				{
					num342 = -2053299036;
					num343 = num342;
				}
				num2 = num342 ^ ((int)num * -1873131212);
				continue;
			}
			case 807u:
				return true;
			case 812u:
				return false;
			case 458u:
				roleKey43 = ResourceStrings.ResStrings[0];
				num2 = ((int)num * -1571102597) ^ 0x13155DE8;
				continue;
			case 1186u:
			{
				int num340;
				int num341;
				if (array59.Length < 1)
				{
					num340 = 1588974107;
					num341 = num340;
				}
				else
				{
					num340 = 1361639562;
					num341 = num340;
				}
				num2 = num340 ^ (int)(num * 1551269542);
				continue;
			}
			case 1320u:
				num143 += RuntimeData.Instance.GetXiangziCount(text6);
				num2 = ((int)num * -1887480922) ^ -415063180;
				continue;
			case 162u:
				array70 = condition.value.Split('#');
				num2 = (int)(num * 527086249) ^ -1962030023;
				continue;
			case 1141u:
				return true;
			case 1238u:
				text5 = array38[1];
				num2 = (int)(num * 378855000) ^ -1075928263;
				continue;
			case 253u:
				return false;
			case 370u:
				roleKey42 = string.Empty;
				num339 = 0;
				num2 = -360605392;
				continue;
			case 833u:
				roleKey29 = ResourceStrings.ResStrings[0];
				num136 = int.Parse(array56[0]);
				num2 = (int)((num * 1453737907) ^ 0xDCD8A7C);
				continue;
			case 485u:
				goto IL_99a9;
			case 1183u:
			{
				item2 = ResourceManager.Get<Item>(text2);
				int num337;
				int num338;
				if (item2 != null)
				{
					num337 = -1002428867;
					num338 = num337;
				}
				else
				{
					num337 = -1649412125;
					num338 = num337;
				}
				num2 = num337 ^ (int)(num * 1835379581);
				continue;
			}
			case 709u:
			{
				string text35 = text10.Replace(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1381559287u), RuntimeData.Instance.RoundString());
				string oldValue6 = global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1878257442u);
				num75 = teamRole18.MAX_ATTRIBUTE;
				num233 = (int)double.Parse(Tools.Compute(text35.Replace(oldValue6, num75.ToString())));
				num2 = -1165327427;
				continue;
			}
			case 383u:
				return RuntimeData.Instance.Yuanbao >= int.Parse(condition.value);
			case 1068u:
				goto IL_9a75;
			case 439u:
				return false;
			case 199u:
			{
				int num335;
				int num336;
				if (array34.Length != 2)
				{
					num335 = 1031366171;
					num336 = num335;
				}
				else
				{
					num335 = 1645609973;
					num336 = num335;
				}
				num2 = num335 ^ ((int)num * -1515597900);
				continue;
			}
			case 691u:
			{
				item2 = ResourceManager.Get<Item>(text2);
				int num333;
				int num334;
				if (item2 == null)
				{
					num333 = 808566331;
					num334 = num333;
				}
				else
				{
					num333 = 277830551;
					num334 = num333;
				}
				num2 = num333 ^ (int)(num * 1243928281);
				continue;
			}
			case 308u:
				num2 = (int)(num * 253878616) ^ -415447290;
				continue;
			case 1060u:
				return true;
			case 772u:
			{
				int num331;
				int num332;
				if (array60.Length >= 1)
				{
					num331 = 30687148;
					num332 = num331;
				}
				else
				{
					num331 = 1794249208;
					num332 = num331;
				}
				num2 = num331 ^ (int)(num * 175585254);
				continue;
			}
			case 824u:
				num160 = int.Parse(array54[1]);
				num2 = (int)(num * 1609121333) ^ -1353894171;
				continue;
			case 672u:
				num2 = (int)((num * 2038834025) ^ 0x21306131);
				continue;
			case 1190u:
			{
				int num329;
				int num330;
				if (!RuntimeData.Instance.NameInTeam(condition.value))
				{
					num329 = 1996098438;
					num330 = num329;
				}
				else
				{
					num329 = 1183284044;
					num330 = num329;
				}
				num2 = num329 ^ ((int)num * -1154932289);
				continue;
			}
			case 488u:
				goto IL_9bc4;
			case 776u:
				array64 = condition.value.Split('#');
				num2 = ((int)num * -2070406891) ^ -1636549003;
				continue;
			case 1289u:
				text31 = array46[0];
				num2 = ((int)num * -30402801) ^ 0x4B626651;
				continue;
			case 1112u:
				goto IL_9c39;
			case 641u:
				goto IL_9c64;
			case 481u:
				teamRole31 = RuntimeData.Instance.GetTeamRole(array69[0]);
				num2 = -280516523;
				continue;
			case 562u:
				num2 = (int)(num * 1510413144) ^ -728764672;
				continue;
			case 137u:
				goto IL_9cc4;
			case 860u:
				goto IL_9cde;
			case 151u:
				roleKey5 = ResourceStrings.ResStrings[0];
				text4 = array17[0];
				num2 = (int)(num * 673929619) ^ -1670686415;
				continue;
			case 1026u:
				return false;
			case 1338u:
				goto IL_9d4b;
			case 64u:
				return true;
			case 682u:
				goto IL_9d71;
			case 665u:
				num75++;
				num2 = -1073465942;
				continue;
			case 657u:
				goto IL_9dac;
			case 940u:
			{
				string text30 = text3.Replace(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3250051652u), RuntimeData.Instance.RoundString());
				string oldValue4 = global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3579531764u);
				num75 = teamRole30.MAX_HPMP;
				num328 = (int)double.Parse(Tools.Compute(text30.Replace(oldValue4, num75.ToString())));
				num2 = -1511264915;
				continue;
			}
			case 613u:
				return true;
			case 286u:
			{
				array27 = condition.value.Split('#');
				int num326;
				int num327;
				if (array27.Length >= 2)
				{
					num326 = 1830378609;
					num327 = num326;
				}
				else
				{
					num326 = 193667597;
					num327 = num326;
				}
				num2 = num326 ^ ((int)num * -1123867825);
				continue;
			}
			case 853u:
				array34 = condition.value.Split('#');
				num2 = (int)(num * 1607786798) ^ -1925852331;
				continue;
			case 1245u:
				goto IL_9eb6;
			case 582u:
				return true;
			case 813u:
				roleKey41 = string.Empty;
				num2 = -1669502974;
				continue;
			case 295u:
				num2 = ((int)num * -1570763409) ^ -1838432855;
				continue;
			case 1205u:
				num2 = ((int)num * -516443708) ^ -1644073940;
				continue;
			case 993u:
			{
				int num324;
				int num325;
				if (item.type != 3)
				{
					num324 = -1991907451;
					num325 = num324;
				}
				else
				{
					num324 = -852806324;
					num325 = num324;
				}
				num2 = num324 ^ (int)(num * 506853322);
				continue;
			}
			case 388u:
				return false;
			case 804u:
				teamRole29 = RuntimeData.Instance.GetTeamRole(roleKey10);
				num2 = -2056871963;
				continue;
			case 694u:
				roleKey7 = ResourceStrings.ResStrings[0];
				num2 = ((int)num * -1652171928) ^ -1044062693;
				continue;
			case 6u:
				roleKey41 = ResourceStrings.ResStrings[0];
				num2 = (int)((num * 1242870224) ^ 0x1544A34D);
				continue;
			case 769u:
				roleKey40 = array68[0];
				text28 = array68[1];
				num2 = -792025882;
				continue;
			case 1156u:
				num75 = 0;
				num2 = (int)(num * 1377589081) ^ -482350770;
				continue;
			case 1051u:
			{
				array66 = condition.value.Split('#');
				int num320;
				int num321;
				if (array66.Length >= 1)
				{
					num320 = 1109879622;
					num321 = num320;
				}
				else
				{
					num320 = 1831336698;
					num321 = num320;
				}
				num2 = num320 ^ (int)(num * 1089480474);
				continue;
			}
			case 32u:
				return false;
			case 1123u:
				return false;
			case 489u:
			{
				int num316;
				int num317;
				if (num120 >= num315)
				{
					num316 = 1802371495;
					num317 = num316;
				}
				else
				{
					num316 = 1372595571;
					num317 = num316;
				}
				num2 = num316 ^ ((int)num * -2007820864);
				continue;
			}
			case 312u:
				goto IL_a07d;
			case 766u:
				num2 = ((int)num * -339015790) ^ -1573714580;
				continue;
			case 104u:
				array48 = condition.value.Split('#');
				num2 = (int)(num * 890373234) ^ -1139551455;
				continue;
			case 501u:
				num314 = 0;
				num2 = (int)((num * 332284444) ^ 0x34079CDF);
				continue;
			case 522u:
				return RuntimeData.Instance.Team.Count >= int.Parse(condition.value);
			case 1260u:
				goto IL_a137;
			case 1137u:
				num313 = int.Parse(array44[0]);
				num2 = (int)((num * 347797205) ^ 0x349C0D9C);
				continue;
			case 368u:
				goto IL_a182;
			case 1203u:
			{
				int num307;
				int num308;
				if (teamRole26.GetInternalSkillLevel(text8) < num306)
				{
					num307 = 1144884914;
					num308 = num307;
				}
				else
				{
					num307 = 1030852442;
					num308 = num307;
				}
				num2 = num307 ^ ((int)num * -1452391850);
				continue;
			}
			case 683u:
				return false;
			case 1284u:
				num2 = (int)(num * 975466217) ^ -1485753509;
				continue;
			case 365u:
				return false;
			case 1256u:
				goto IL_a21f;
			case 1314u:
				return false;
			case 451u:
			{
				int num302;
				int num303;
				if (item.type != 2)
				{
					num302 = 275081032;
					num303 = num302;
				}
				else
				{
					num302 = 1920706663;
					num303 = num302;
				}
				num2 = num302 ^ (int)(num * 937047339);
				continue;
			}
			case 930u:
				num301 = int.Parse(array67[0]);
				num2 = (int)(num * 1594915159) ^ -1888594743;
				continue;
			case 424u:
				return true;
			case 1307u:
			{
				int num299;
				int num300;
				if (array58.Length != 1)
				{
					num299 = -1200923007;
					num300 = num299;
				}
				else
				{
					num299 = -1439668268;
					num300 = num299;
				}
				num2 = num299 ^ ((int)num * -853240795);
				continue;
			}
			case 1315u:
			{
				int num295;
				int num296;
				if (array24.Length >= 1)
				{
					num295 = 567756413;
					num296 = num295;
				}
				else
				{
					num295 = 975732220;
					num296 = num295;
				}
				num2 = num295 ^ (int)(num * 213371661);
				continue;
			}
			case 995u:
				num2 = ((int)num * -612287555) ^ 0x67144DF8;
				continue;
			case 385u:
				num2 = ((int)num * -1700154282) ^ 0x4AE3A424;
				continue;
			case 675u:
			{
				int num288;
				int num289;
				if (array66.Length <= 1)
				{
					num288 = 1126251483;
					num289 = num288;
				}
				else
				{
					num288 = 1250018672;
					num289 = num288;
				}
				num2 = num288 ^ ((int)num * -1854864574);
				continue;
			}
			case 506u:
				num2 = (int)((num * 1701825436) ^ 0x47F10C70);
				continue;
			case 810u:
				return false;
			case 1056u:
				return true;
			case 551u:
			{
				int num284;
				int num285;
				if (teamRole26 == null)
				{
					num284 = 1201682912;
					num285 = num284;
				}
				else
				{
					num284 = 1127062928;
					num285 = num284;
				}
				num2 = num284 ^ ((int)num * -1211918826);
				continue;
			}
			case 1149u:
				text27 = array65[0];
				num2 = ((int)num * -1224916190) ^ -334699296;
				continue;
			case 584u:
				array29 = condition.value.Split('#');
				num2 = (int)((num * 555136212) ^ 0x417E0AF1);
				continue;
			case 107u:
				goto IL_a3ec;
			case 1298u:
				num2 = ((int)num * -138726337) ^ 0x52B75323;
				continue;
			case 464u:
				num143 += RuntimeData.Instance.GetItemsCount(text6);
				num2 = (int)((num * 302283316) ^ 0x271E1579);
				continue;
			case 1243u:
				num2 = (int)((num * 627949253) ^ 0x5391DD48);
				continue;
			case 637u:
				teamRole25 = RuntimeData.Instance.GetTeamRole(array64[0]);
				num2 = -1872719473;
				continue;
			case 953u:
			{
				int num277;
				int num278;
				if (item2.type == 3)
				{
					num277 = -489925269;
					num278 = num277;
				}
				else
				{
					num277 = -1557918011;
					num278 = num277;
				}
				num2 = num277 ^ ((int)num * -1023076919);
				continue;
			}
			case 556u:
				return false;
			case 1292u:
				num2 = (int)(num * 1607751018) ^ -188598152;
				continue;
			case 868u:
				return false;
			case 731u:
			{
				int num273;
				int num274;
				if (array39.Length >= 1)
				{
					num273 = 552898285;
					num274 = num273;
				}
				else
				{
					num273 = 17258462;
					num274 = num273;
				}
				num2 = num273 ^ ((int)num * -2119004882);
				continue;
			}
			case 141u:
				goto IL_a513;
			case 1059u:
				num2 = ((int)num * -36772461) ^ -1757353695;
				continue;
			case 1062u:
				array54 = condition.value.Split('#');
				num2 = (int)((num * 1636817656) ^ 0x5CF86BA4);
				continue;
			case 798u:
				return false;
			case 609u:
				goto IL_a598;
			case 681u:
				roleKey39 = array63[0];
				text26 = array63[1];
				num2 = -1188274677;
				continue;
			case 696u:
				goto IL_a5c7;
			case 420u:
				num2 = ((int)num * -867872357) ^ 0x4A167CDC;
				continue;
			case 988u:
				goto IL_a608;
			case 862u:
				text22 = array57[1];
				num2 = (int)((num * 762466012) ^ 0x214BEE81);
				continue;
			case 359u:
				return false;
			case 904u:
				return false;
			case 1335u:
				goto IL_a66c;
			case 472u:
				goto IL_a685;
			case 1102u:
				return true;
			case 483u:
				roleKey38 = array62[0];
				num2 = -1226514612;
				continue;
			case 53u:
			{
				int num271;
				int num272;
				if (item.type != 4)
				{
					num271 = 2042604095;
					num272 = num271;
				}
				else
				{
					num271 = 632135962;
					num272 = num271;
				}
				num2 = num271 ^ ((int)num * -971861908);
				continue;
			}
			case 30u:
				num143 += RuntimeData.Instance.GetXiangziCount(text6);
				num2 = ((int)num * -1228550572) ^ -1733742639;
				continue;
			case 1326u:
				return false;
			case 1103u:
				roleKey25 = string.Empty;
				num2 = -465127007;
				continue;
			case 907u:
				goto IL_a73d;
			case 450u:
			{
				int num267;
				int num268;
				if (ModData.ZhenlongqijuKilled < int.Parse(condition.value))
				{
					num267 = -1339294785;
					num268 = num267;
				}
				else
				{
					num267 = -1804664776;
					num268 = num267;
				}
				num2 = num267 ^ ((int)num * -1302173190);
				continue;
			}
			case 1198u:
				return RuntimeData.Instance.Follow.Count >= int.Parse(condition.value);
			case 1072u:
				num136 = int.Parse(array56[1]);
				num2 = ((int)num * -1478903538) ^ 0xFDD528E;
				continue;
			case 891u:
				num2 = ((int)num * -1252486881) ^ -1617757071;
				continue;
			case 333u:
				num2 = (int)(num * 1878219399) ^ -1369020957;
				continue;
			case 398u:
				text2 = array60[0];
				num2 = -742519427;
				continue;
			case 278u:
				return false;
			case 845u:
				teamRole15 = RuntimeData.Instance.GetTeamRole(roleKey36);
				num2 = -991158044;
				continue;
			case 669u:
				goto IL_a847;
			case 1025u:
			{
				int num265;
				int num266;
				if (teamRole21 == null)
				{
					num265 = -1288707246;
					num266 = num265;
				}
				else
				{
					num265 = -712641013;
					num266 = num265;
				}
				num2 = num265 ^ ((int)num * -760716679);
				continue;
			}
			case 60u:
				goto IL_a899;
			case 98u:
				return result4;
			case 1268u:
			{
				string text25 = text22.Replace(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3121341046u), RuntimeData.Instance.RoundString());
				string oldValue3 = global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1878257442u);
				num75 = teamRole6.MAX_INTERNALSKILL_LEVEL;
				num264 = (int)double.Parse(Tools.Compute(text25.Replace(oldValue3, num75.ToString())));
				num2 = ((int)num * -634022493) ^ -695800929;
				continue;
			}
			case 487u:
			{
				int num258;
				int num259;
				if (array37.Length < 1)
				{
					num258 = -1779436130;
					num259 = num258;
				}
				else
				{
					num258 = -1438447430;
					num259 = num258;
				}
				num2 = num258 ^ ((int)num * -1068056247);
				continue;
			}
			case 536u:
				goto IL_a952;
			case 293u:
				num2 = ((int)num * -753524143) ^ -1760567943;
				continue;
			case 127u:
				goto IL_a98e;
			case 358u:
				roleKey34 = string.Empty;
				text24 = string.Empty;
				num2 = -1269436437;
				continue;
			case 244u:
				num2 = ((int)num * -1488433871) ^ 0x34A387E2;
				continue;
			case 650u:
				teamRole20 = RuntimeData.Instance.GetTeamRole(roleKey19);
				num2 = -2090904044;
				continue;
			case 492u:
				goto IL_a9ff;
			case 394u:
				roleKey11 = string.Empty;
				num2 = -1097600190;
				continue;
			case 617u:
				return false;
			case 71u:
				return false;
			case 356u:
			{
				array53 = condition.value.Split('#');
				int num256;
				int num257;
				if (array53.Length >= 1)
				{
					num256 = -865483049;
					num257 = num256;
				}
				else
				{
					num256 = -1366219209;
					num257 = num256;
				}
				num2 = num256 ^ ((int)num * -853860318);
				continue;
			}
			case 1083u:
				return false;
			case 707u:
				return false;
			case 88u:
			{
				int num254;
				int num255;
				if (timeSpan.Days > int.Parse(condition.value))
				{
					num254 = -1102096181;
					num255 = num254;
				}
				else
				{
					num254 = -1183359868;
					num255 = num254;
				}
				num2 = num254 ^ (int)(num * 2102199365);
				continue;
			}
			case 262u:
				text18 = array58[0];
				num2 = (int)(num * 1783928260) ^ -1298341142;
				continue;
			case 980u:
				text17 = array49[0];
				num2 = ((int)num * -1563529064) ^ 0x335CBE17;
				continue;
			case 387u:
				return false;
			case 1091u:
				return false;
			case 975u:
			{
				int num250;
				int num251;
				if (teamRole19 != null)
				{
					num250 = -1133223218;
					num251 = num250;
				}
				else
				{
					num250 = -2089923740;
					num251 = num250;
				}
				num2 = num250 ^ ((int)num * -1325202913);
				continue;
			}
			case 973u:
				text7 = array57[0];
				num2 = (int)(num * 1948542678) ^ -1423116998;
				continue;
			case 1197u:
				return false;
			case 69u:
				return false;
			case 1165u:
				roleKey31 = string.Empty;
				num2 = -1025047489;
				continue;
			case 1331u:
				roleKey17 = ResourceStrings.ResStrings[9];
				num2 = (int)((num * 2116768802) ^ 0x335E65D8);
				continue;
			case 300u:
				roleKey32 = ResourceStrings.ResStrings[0];
				num2 = (int)(num * 1413993920) ^ -220005890;
				continue;
			case 443u:
			{
				int num248;
				int num249;
				if (array55.Length != 1)
				{
					num248 = -81945010;
					num249 = num248;
				}
				else
				{
					num248 = -115117317;
					num249 = num248;
				}
				num2 = num248 ^ ((int)num * -1974245835);
				continue;
			}
			case 826u:
				return false;
			case 168u:
				roleKey31 = ResourceStrings.ResStrings[0];
				num160 = int.Parse(array54[0]);
				num2 = ((int)num * -2023749252) ^ -155531128;
				continue;
			case 648u:
				num2 = (int)(num * 18299165) ^ -2106148958;
				continue;
			case 434u:
			{
				int num244;
				int num245;
				if (item2.type == 1)
				{
					num244 = 1099597282;
					num245 = num244;
				}
				else
				{
					num244 = 1514087219;
					num245 = num244;
				}
				num2 = num244 ^ ((int)num * -1428812769);
				continue;
			}
			case 523u:
				goto IL_acae;
			case 1030u:
			{
				string text19 = text20.Replace(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(800863094u), RuntimeData.Instance.RoundString());
				string oldValue2 = global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3279928277u);
				num75 = teamRole14.MAX_ATTRIBUTE;
				num243 = (int)double.Parse(Tools.Compute(text19.Replace(oldValue2, num75.ToString())));
				num2 = -1276652159;
				continue;
			}
			case 775u:
			{
				int num234;
				int num235;
				if (teamRole18.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1790491204u)] >= num233)
				{
					num234 = -742027489;
					num235 = num234;
				}
				else
				{
					num234 = -729427670;
					num235 = num234;
				}
				num2 = num234 ^ (int)(num * 504319856);
				continue;
			}
			case 920u:
				num232 = int.Parse(array53[0]);
				num2 = (int)(num * 1277970492) ^ -280083874;
				continue;
			case 585u:
				roleKey30 = ResourceStrings.ResStrings[0];
				num2 = -895762213;
				continue;
			case 604u:
				return true;
			case 971u:
				roleKey4 = array15[0];
				num113 = int.Parse(array15[1]);
				num2 = -849711001;
				continue;
			case 919u:
				goto IL_adeb;
			case 976u:
				roleKey29 = string.Empty;
				num2 = -1595065491;
				continue;
			case 872u:
				goto IL_ae27;
			case 1317u:
				return false;
			case 216u:
			{
				int num228;
				int num229;
				if (_206B_200C_200D_202B_202D_200E_202E_206D_200E_200F_202C_200C_202A_200F_200C_206D_202B_206E_202D_202D_200C_200D_202E_200B_206E_202B_206E_200B_206F_206D_200F_200F_202C_202B_202C_202D_200F_202E_202E_200C_202E(RuntimeData.Instance.GameMode, condition.value))
				{
					num228 = 84710129;
					num229 = num228;
				}
				else
				{
					num228 = 300854873;
					num229 = num228;
				}
				num2 = num228 ^ ((int)num * -1524921346);
				continue;
			}
			case 1216u:
				roleKey9 = string.Empty;
				num2 = -771178523;
				continue;
			case 508u:
				goto IL_ae96;
			case 1287u:
			{
				int num226;
				int num227;
				if (array19.Length < 1)
				{
					num226 = -509764178;
					num227 = num226;
				}
				else
				{
					num226 = -1341984880;
					num227 = num226;
				}
				num2 = num226 ^ ((int)num * -799947614);
				continue;
			}
			case 161u:
				goto IL_aee7;
			case 934u:
				text18 = string.Empty;
				num2 = (int)(num * 1932728584) ^ -570208687;
				continue;
			case 75u:
			{
				int num221;
				int num222;
				if (!RuntimeData.Instance.InTemp(condition.value))
				{
					num221 = 1836724967;
					num222 = num221;
				}
				else
				{
					num221 = 1319625869;
					num222 = num221;
				}
				num2 = num221 ^ (int)(num * 614009731);
				continue;
			}
			case 119u:
				num2 = (int)(num * 848868935) ^ -1179216624;
				continue;
			case 1172u:
			{
				num110 = 0;
				int num218;
				int num219;
				if (num217 > 0)
				{
					num218 = 1914728540;
					num219 = num218;
				}
				else
				{
					num218 = 225945345;
					num219 = num218;
				}
				num2 = num218 ^ (int)(num * 1014231897);
				continue;
			}
			case 322u:
				roleKey25 = array49[0];
				text17 = array49[1];
				num2 = -955936641;
				continue;
			case 1265u:
			{
				int num213;
				int num214;
				if (array48.Length == 1)
				{
					num213 = 1862354192;
					num214 = num213;
				}
				else
				{
					num213 = 1885040521;
					num214 = num213;
				}
				num2 = num213 ^ ((int)num * -882104580);
				continue;
			}
			case 706u:
				goto IL_afea;
			case 417u:
				roleKey24 = ResourceStrings.ResStrings[0];
				num212 = int.Parse(array19[0]);
				num2 = ((int)num * -963776164) ^ 0x6C881749;
				continue;
			case 1201u:
				return false;
			case 797u:
				num2 = ((int)num * -1099431576) ^ -364449573;
				continue;
			case 911u:
			{
				int num207;
				int num208;
				if (array43.Length == 1)
				{
					num207 = 461392944;
					num208 = num207;
				}
				else
				{
					num207 = 1791195654;
					num208 = num207;
				}
				num2 = num207 ^ ((int)num * -1259447277);
				continue;
			}
			case 297u:
				array42 = condition.value.Split('#');
				num2 = ((int)num * -1309596622) ^ -39982729;
				continue;
			case 900u:
				roleKey24 = string.Empty;
				num2 = -1981830006;
				continue;
			case 496u:
			{
				int num203;
				int num204;
				if (CommonSettings.GET_MOD_VERSION() == condition.value)
				{
					num203 = -146785064;
					num204 = num203;
				}
				else
				{
					num203 = -1374946837;
					num204 = num203;
				}
				num2 = num203 ^ (int)(num * 470159099);
				continue;
			}
			case 504u:
			{
				int num201;
				int num202;
				if (item.type != 3)
				{
					num201 = 1039122804;
					num202 = num201;
				}
				else
				{
					num201 = 126404378;
					num202 = num201;
				}
				num2 = num201 ^ ((int)num * -1625222333);
				continue;
			}
			case 1336u:
			{
				int num197;
				int num198;
				if (array46.Length != 1)
				{
					num197 = 1304914608;
					num198 = num197;
				}
				else
				{
					num197 = 759846722;
					num198 = num197;
				}
				num2 = num197 ^ ((int)num * -206766354);
				continue;
			}
			case 751u:
				return true;
			case 237u:
			{
				int num191;
				int num192;
				if (RuntimeData.Instance.KeyValues.ContainsKey(condition.value))
				{
					num191 = -306551787;
					num192 = num191;
				}
				else
				{
					num191 = -678968993;
					num192 = num191;
				}
				num2 = num191 ^ ((int)num * -1419894741);
				continue;
			}
			case 106u:
			{
				array20 = condition.value.Split('#');
				int num187;
				int num188;
				if (array20.Length >= 1)
				{
					num187 = 1857087935;
					num188 = num187;
				}
				else
				{
					num187 = 39014547;
					num188 = num187;
				}
				num2 = num187 ^ ((int)num * -1193682229);
				continue;
			}
			case 1234u:
				num2 = (int)((num * 815669655) ^ 0x360D6AA3);
				continue;
			case 405u:
				return false;
			case 258u:
				goto IL_b1fc;
			case 992u:
				num110 += RuntimeData.Instance.GetXiangziCount(text2);
				num2 = (int)((num * 543204171) ^ 0xC797360);
				continue;
			case 384u:
				return true;
			case 1009u:
			{
				int num185;
				int num186;
				if (item.type != 2)
				{
					num185 = -1725503808;
					num186 = num185;
				}
				else
				{
					num185 = -327203171;
					num186 = num185;
				}
				num2 = num185 ^ ((int)num * -361691317);
				continue;
			}
			case 969u:
				return true;
			case 256u:
				num2 = ((int)num * -531574545) ^ -781588349;
				continue;
			case 448u:
			{
				int num181;
				int num182;
				if (teamRole14 == null)
				{
					num181 = 2104164758;
					num182 = num181;
				}
				else
				{
					num181 = 1835956092;
					num182 = num181;
				}
				num2 = num181 ^ ((int)num * -335316754);
				continue;
			}
			case 218u:
				return false;
			case 979u:
			{
				string text14 = text15.Replace(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(800863094u), RuntimeData.Instance.RoundString());
				string oldValue = global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3579531764u);
				num75 = teamRole13.MAX_ATTRIBUTE;
				num180 = (int)double.Parse(Tools.Compute(text14.Replace(oldValue, num75.ToString())));
				num2 = -1926730488;
				continue;
			}
			case 303u:
				num2 = ((int)num * -1288425956) ^ 0x332A7999;
				continue;
			case 918u:
				return false;
			case 809u:
				roleKey23 = array24[0];
				num2 = -1742339964;
				continue;
			case 416u:
				num2 = (int)((num * 846629203) ^ 0x46ED4850);
				continue;
			case 929u:
				roleKey22 = array43[0];
				num179 = int.Parse(array43[1]);
				num2 = -796747706;
				continue;
			case 1240u:
			{
				text13 = string.Empty;
				int num174;
				int num175;
				if (array16.Length == 1)
				{
					num174 = 1987937307;
					num175 = num174;
				}
				else
				{
					num174 = 1854045577;
					num175 = num174;
				}
				num2 = num174 ^ ((int)num * -1906622511);
				continue;
			}
			case 783u:
				num2 = ((int)num * -1800616849) ^ 0x5479D16F;
				continue;
			case 1127u:
			{
				int num167;
				int num168;
				if (array38.Length >= 1)
				{
					num167 = -980846183;
					num168 = num167;
				}
				else
				{
					num167 = -1478611001;
					num168 = num167;
				}
				num2 = num167 ^ ((int)num * -1510572325);
				continue;
			}
			case 270u:
				return true;
			case 113u:
				goto IL_b427;
			case 877u:
				goto IL_b441;
			case 1125u:
			{
				int num165;
				int num166;
				if (teamRole11 == null)
				{
					num165 = 536555189;
					num166 = num165;
				}
				else
				{
					num165 = 497983986;
					num166 = num165;
				}
				num2 = num165 ^ ((int)num * -1903096543);
				continue;
			}
			case 99u:
				array36 = condition.value.Split('#');
				num2 = (int)(num * 1753440617) ^ -172404469;
				continue;
			case 1311u:
				num2 = (int)(num * 1037086593) ^ -1532071443;
				continue;
			case 1290u:
				roleKey20 = array35[0];
				text12 = array35[1];
				num2 = -988718913;
				continue;
			case 1241u:
				goto IL_b4dd;
			case 822u:
				teamRole10 = RuntimeData.Instance.GetTeamRole(roleKey5);
				num2 = -1407502767;
				continue;
			case 841u:
				return false;
			case 1274u:
				goto IL_b532;
			case 1340u:
				goto IL_b5a7;
			case 190u:
				goto IL_b5d2;
			case 302u:
				return false;
			case 401u:
				return false;
			case 105u:
				return false;
			case 1181u:
			{
				num110 = RuntimeData.Instance.GetItemsCount(text2);
				int num163;
				int num164;
				if (num110 >= num114)
				{
					num163 = 70851360;
					num164 = num163;
				}
				else
				{
					num163 = 147409597;
					num164 = num163;
				}
				num2 = num163 ^ ((int)num * -1775902944);
				continue;
			}
			case 419u:
				roleKey19 = ResourceStrings.ResStrings[0];
				text11 = array34[0];
				num162 = int.Parse(array34[1]);
				num2 = (int)(num * 1548758301) ^ -1847176441;
				continue;
			case 183u:
				roleKey18 = ResourceStrings.ResStrings[0];
				num161 = int.Parse(array33[0]);
				num2 = (int)(num * 1224679964) ^ -1007790212;
				continue;
			case 76u:
				return false;
			case 1032u:
				return false;
			case 554u:
				return false;
			case 1318u:
				num2 = ((int)num * -40095159) ^ 0x50B57C07;
				continue;
			case 261u:
				num160 = 0;
				num2 = (int)(num * 991750859) ^ -1564913044;
				continue;
			case 667u:
				roleKey3 = string.Empty;
				num2 = -1616231905;
				continue;
			case 134u:
				roleKey17 = array32[0];
				num159 = int.Parse(array32[1]);
				num2 = -1789112195;
				continue;
			case 476u:
				goto IL_b75e;
			case 350u:
				return false;
			case 275u:
				goto IL_b7a0;
			case 1250u:
				roleKey16 = ResourceStrings.ResStrings[0];
				text10 = array31[0];
				num2 = ((int)num * -871737092) ^ 0x3F6ADAF9;
				continue;
			case 1034u:
				goto IL_b7ed;
			case 1069u:
			{
				int num156;
				int num157;
				if (array30.Length != 1)
				{
					num156 = -2060972725;
					num157 = num156;
				}
				else
				{
					num156 = -1747487084;
					num157 = num156;
				}
				num2 = num156 ^ ((int)num * -992427506);
				continue;
			}
			case 1061u:
			{
				int num153;
				int num154;
				if (teamRole9 == null)
				{
					num153 = 541356015;
					num154 = num153;
				}
				else
				{
					num153 = 1155707134;
					num154 = num153;
				}
				num2 = num153 ^ (int)(num * 657137214);
				continue;
			}
			case 1006u:
				num2 = (int)(num * 1859215144) ^ -959121662;
				continue;
			case 128u:
			{
				int num149;
				int num150;
				if (role5.isharem == 0)
				{
					num149 = -665436723;
					num150 = num149;
				}
				else
				{
					num149 = -578729746;
					num150 = num149;
				}
				num2 = num149 ^ ((int)num * -919914605);
				continue;
			}
			case 1166u:
				return RuntimeData.Instance.Temp.Count >= int.Parse(condition.value);
			case 1179u:
			{
				int num145;
				int num146;
				if (array22.Length >= 1)
				{
					num145 = -724352183;
					num146 = num145;
				}
				else
				{
					num145 = -877164303;
					num146 = num145;
				}
				num2 = num145 ^ (int)(num * 1284302204);
				continue;
			}
			case 1249u:
				num2 = ((int)num * -1258816468) ^ -247049576;
				continue;
			case 926u:
				text8 = array27[0];
				text9 = array27[1];
				num2 = ((int)num * -696380928) ^ 0x4B87EC7C;
				continue;
			case 265u:
				goto IL_b92e;
			case 957u:
				return false;
			case 914u:
				return false;
			case 284u:
				num143 = RuntimeData.Instance.GetRolesEquipment(text6, num144);
				num2 = -2124880490;
				continue;
			case 63u:
				roleKey14 = array26[0];
				num2 = -1574019733;
				continue;
			case 340u:
			{
				int num140;
				int num141;
				if (array25.Length < 1)
				{
					num140 = 1531015548;
					num141 = num140;
				}
				else
				{
					num140 = 2111005634;
					num141 = num140;
				}
				num2 = num140 ^ ((int)num * -382012846);
				continue;
			}
			case 614u:
				roleKey11 = array13[0];
				num2 = -1733220295;
				continue;
			case 560u:
				goto IL_b9ee;
			case 498u:
			{
				int num138;
				int num139;
				if (teamRole8.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(701808387u)] < num137)
				{
					num138 = -1118305768;
					num139 = num138;
				}
				else
				{
					num138 = -1377031649;
					num139 = num138;
				}
				num2 = num138 ^ (int)(num * 168866811);
				continue;
			}
			case 478u:
				teamRole7 = RuntimeData.Instance.GetTeamRole(array23[0]);
				num2 = -1391201042;
				continue;
			case 932u:
				return true;
			case 982u:
				return true;
			case 705u:
				goto IL_ba83;
			case 229u:
				return false;
			case 1303u:
				num136 = 0;
				num2 = (int)((num * 253758733) ^ 0x40A970D4);
				continue;
			case 273u:
				roleKey10 = string.Empty;
				num2 = -425546132;
				continue;
			case 1305u:
				array22 = condition.value.Split('#');
				num2 = ((int)num * -610552730) ^ -1600405865;
				continue;
			case 680u:
				roleKey9 = array14[0];
				num2 = -1091465788;
				continue;
			case 377u:
				goto IL_bb7b;
			case 290u:
			{
				item2 = ResourceManager.Get<Item>(text2);
				int num133;
				int num134;
				if (item2 != null)
				{
					num133 = 1120975286;
					num134 = num133;
				}
				else
				{
					num133 = 120756222;
					num134 = num133;
				}
				num2 = num133 ^ ((int)num * -987016465);
				continue;
			}
			case 332u:
				goto IL_bbd2;
			case 146u:
				goto IL_bbfd;
			case 25u:
			{
				int num128;
				int num129;
				if (teamRole5.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3795453722u)] < num127)
				{
					num128 = 1072849893;
					num129 = num128;
				}
				else
				{
					num128 = 713181261;
					num129 = num128;
				}
				num2 = num128 ^ ((int)num * -830492522);
				continue;
			}
			case 633u:
				return false;
			case 1270u:
				return RuntimeData.Instance.Team[0].HasEquipmentTalent(array20[0]);
			case 984u:
				teamRole4 = RuntimeData.Instance.GetTeamRole(roleKey8);
				num2 = -1953447910;
				continue;
			case 906u:
				goto IL_bcc7;
			case 623u:
				num110 = RuntimeData.Instance.GetRolesEquipment(text2, num114);
				num2 = -319750784;
				continue;
			case 1110u:
				goto IL_bd15;
			case 1261u:
				goto IL_bd43;
			case 615u:
				result4 = false;
				num2 = ((int)num * -1304819907) ^ -2093617159;
				continue;
			case 1089u:
				goto IL_bd89;
			case 814u:
				roleKey7 = string.Empty;
				num2 = -1229115602;
				continue;
			case 291u:
				text3 = array13[0];
				num2 = ((int)num * -306494760) ^ -1393904051;
				continue;
			case 743u:
				num110 += RuntimeData.Instance.GetXiangziCount(text2);
				num2 = ((int)num * -1094787613) ^ 0x13C0CF23;
				continue;
			case 893u:
			{
				int num121;
				int num122;
				if (array18.Length < 1)
				{
					num121 = -188550143;
					num122 = num121;
				}
				else
				{
					num121 = -1495697638;
					num122 = num121;
				}
				num2 = num121 ^ ((int)num * -1860391191);
				continue;
			}
			case 35u:
				return false;
			case 889u:
				return false;
			case 1086u:
				roleKey6 = string.Empty;
				text5 = string.Empty;
				num2 = -532341868;
				continue;
			case 245u:
				return false;
			case 1106u:
				goto IL_be73;
			case 224u:
				return false;
			case 1251u:
				return false;
			case 97u:
				roleKey5 = array17[0];
				text4 = array17[1];
				num2 = -1229236212;
				continue;
			case 595u:
				num120 = -1;
				num2 = -2062275927;
				continue;
			case 699u:
			{
				array16 = condition.value.Split('#');
				int num115;
				int num116;
				if (array16.Length < 1)
				{
					num115 = -1983664206;
					num116 = num115;
				}
				else
				{
					num115 = -1248006016;
					num116 = num115;
				}
				num2 = num115 ^ (int)(num * 577141469);
				continue;
			}
			case 214u:
				num110 = RuntimeData.Instance.GetRolesEquipment(text2, num114);
				num2 = -593316509;
				continue;
			case 1185u:
				roleKey4 = ResourceStrings.ResStrings[0];
				num113 = int.Parse(array15[0]);
				num2 = (int)(num * 1132630144) ^ -174485273;
				continue;
			case 136u:
				return false;
			case 791u:
			{
				int num111;
				int num112;
				if (array14.Length < 1)
				{
					num111 = 1233378968;
					num112 = num111;
				}
				else
				{
					num111 = 1310152695;
					num112 = num111;
				}
				num2 = num111 ^ ((int)num * -1023997701);
				continue;
			}
			case 567u:
				goto IL_bfb1;
			case 515u:
				text3 = array13[1];
				num2 = ((int)num * -644263296) ^ -198907138;
				continue;
			case 15u:
				num110 = RuntimeData.Instance.GetItemsCount(text2);
				num2 = ((int)num * -1351821083) ^ -909187157;
				continue;
			case 642u:
				return true;
			case 160u:
				roleKey2 = array12[0];
				num109 = int.Parse(array12[1]);
				num2 = -40946118;
				continue;
			case 643u:
				roleKey = string.Empty;
				num2 = -1118786774;
				continue;
			case 789u:
				return false;
			case 242u:
				goto IL_c08a;
			default:
				{
					try
					{
						while (true)
						{
							IL_c101:
							int num106;
							int num107;
							if (enumerator2.MoveNext())
							{
								num106 = -553724617;
								num107 = num106;
							}
							else
							{
								num106 = -157132768;
								num107 = num106;
							}
							while (true)
							{
								switch ((num = (uint)(num106 ^ -1375790662)) % 5)
								{
								case 0u:
									num106 = -553724617;
									continue;
								default:
									goto end_IL_c0ab;
								case 1u:
								{
									int num108;
									if (enumerator2.Current.Name == text)
									{
										num106 = -938176426;
										num108 = num106;
									}
									else
									{
										num106 = -1447208450;
										num108 = num106;
									}
									continue;
								}
								case 2u:
									break;
								case 4u:
									return true;
								case 3u:
									goto end_IL_c0ab;
								}
								goto IL_c101;
								continue;
								end_IL_c0ab:
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
					}
					goto IL_c14f;
				}
				IL_2954:
				flag = (byte)num375 != 0;
				num2 = -1965619195;
				continue;
				IL_43d6:
				flag2 = (byte)num432 != 0;
				num2 = -8351491;
				continue;
				IL_c14f:
				return false;
				IL_35cb:
				num609 = num176;
				num2 = -1221831231;
				continue;
				IL_8660:
				num452 = num463;
				num2 = -1093950963;
				continue;
				IL_5a51:
				num217 = num524;
				num2 = -1034173046;
				continue;
			}
			break;
			IL_c08a:
			int num687;
			if (num452 != 2)
			{
				num2 = -941234931;
				num687 = num2;
			}
			else
			{
				num2 = -374293521;
				num687 = num2;
			}
			continue;
			IL_6932:
			int num688;
			if (condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2040632110u))
			{
				num2 = -1066118858;
				num688 = num2;
			}
			else
			{
				num2 = -1177770735;
				num688 = num2;
			}
			continue;
			IL_1e17:
			int num689;
			if (condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2217716284u))
			{
				num2 = -30306426;
				num689 = num2;
			}
			else
			{
				num2 = -2129528494;
				num689 = num2;
			}
			continue;
			IL_bfb1:
			int num690;
			if (teamRole39.AttributesFinal[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(187771104u)] < num209)
			{
				num2 = -1670537651;
				num690 = num2;
			}
			else
			{
				num2 = -67782717;
				num690 = num2;
			}
			continue;
			IL_8c5a:
			string text52 = text4.Replace(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3250051652u), RuntimeData.Instance.RoundString());
			string oldValue18 = global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1878257442u);
			num75 = teamRole10.MAX_ATTRIBUTE;
			int num691 = (int)double.Parse(Tools.Compute(text52.Replace(oldValue18, num75.ToString())));
			int num692;
			if (teamRole10.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1550623476u)] >= num691)
			{
				num2 = -1218710464;
				num692 = num2;
			}
			else
			{
				num2 = -375810378;
				num692 = num2;
			}
			continue;
			IL_2480:
			teamRole5 = RuntimeData.Instance.GetTeamRole(roleKey20);
			int num693;
			if (teamRole5 != null)
			{
				num2 = -554019157;
				num693 = num2;
			}
			else
			{
				num2 = -847081835;
				num693 = num2;
			}
			continue;
			IL_be73:
			teamRole42 = RuntimeData.Instance.GetTeamRole(roleKey50);
			int num694;
			if (teamRole42 == null)
			{
				num2 = -1085241986;
				num694 = num2;
			}
			else
			{
				num2 = -1326582717;
				num694 = num2;
			}
			continue;
			IL_6856:
			int num695;
			if (condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3540380992u))
			{
				num2 = -1505383934;
				num695 = num2;
			}
			else
			{
				num2 = -1163143321;
				num695 = num2;
			}
			continue;
			IL_8c12:
			int num696;
			if (array64.Length != 1)
			{
				num2 = -1938363001;
				num696 = num2;
			}
			else
			{
				num2 = -746148989;
				num696 = num2;
			}
			continue;
			IL_bd89:
			int num697;
			if (num110 >= num114)
			{
				num2 = -319750784;
				num697 = num2;
			}
			else
			{
				num2 = -414869222;
				num697 = num2;
			}
			continue;
			IL_49e3:
			int num698;
			if (condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1669329967u))
			{
				num2 = -2118868622;
				num698 = num2;
			}
			else
			{
				num2 = -1471537401;
				num698 = num2;
			}
			continue;
			IL_381d:
			int num699;
			if (condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3578282866u))
			{
				num2 = -665597838;
				num699 = num2;
			}
			else
			{
				num2 = -1766122199;
				num699 = num2;
			}
			continue;
			IL_bd43:
			int num700;
			if (!(condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(441668263u)))
			{
				num2 = -1965669479;
				num700 = num2;
			}
			else
			{
				num2 = -340821301;
				num700 = num2;
			}
			continue;
			IL_8ba9:
			int num701;
			if (condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3644717221u))
			{
				num2 = -1608297539;
				num701 = num2;
			}
			else
			{
				num2 = -1655000719;
				num701 = num2;
			}
			continue;
			IL_67e7:
			int num702;
			if (condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1787396203u))
			{
				num2 = -596648522;
				num702 = num2;
			}
			else
			{
				num2 = -1745119696;
				num702 = num2;
			}
			continue;
			IL_bd15:
			int num703;
			if (teamRole34.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2186305609u)] >= num313)
			{
				num2 = -766944225;
				num703 = num2;
			}
			else
			{
				num2 = -90566349;
				num703 = num2;
			}
			continue;
			IL_2ff2:
			teamRole43 = RuntimeData.Instance.GetTeamRole(roleKey22);
			int num704;
			if (teamRole43 == null)
			{
				num2 = -849846158;
				num704 = num2;
			}
			else
			{
				num2 = -745335766;
				num704 = num2;
			}
			continue;
			IL_8b7e:
			int num705;
			if (!(condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2930379503u)))
			{
				num2 = -1284919867;
				num705 = num2;
			}
			else
			{
				num2 = -1097864208;
				num705 = num2;
			}
			continue;
			IL_bcc7:
			string text53 = array10[num75];
			int num706;
			if (!Tools.IsChineseTime(RuntimeData.Instance.Date, text53[0]))
			{
				num2 = -1935841841;
				num706 = num2;
			}
			else
			{
				num2 = -1481737910;
				num706 = num2;
			}
			continue;
			IL_49b8:
			int num707;
			if (!(condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3789427655u)))
			{
				num2 = -1769273561;
				num707 = num2;
			}
			else
			{
				num2 = -4506012;
				num707 = num2;
			}
			continue;
			IL_663c:
			int num708;
			if (!(condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1370302112u)))
			{
				num2 = -564981312;
				num708 = num2;
			}
			else
			{
				num2 = -1316560568;
				num708 = num2;
			}
			continue;
			IL_bbfd:
			int num709;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(841233159u)))
			{
				num2 = -281339557;
				num709 = num2;
			}
			else
			{
				num2 = -1754058688;
				num709 = num2;
			}
			continue;
			IL_8af2:
			int num710;
			if (teamRole22.Level < num502)
			{
				num2 = -405499543;
				num710 = num2;
			}
			else
			{
				num2 = -1938013866;
				num710 = num2;
			}
			continue;
			IL_1882:
			int num711;
			if (num452 == 5)
			{
				num2 = -1853464001;
				num711 = num2;
			}
			else
			{
				num2 = -1773078045;
				num711 = num2;
			}
			continue;
			IL_bbd2:
			int num712;
			if (!(condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3510781452u)))
			{
				num2 = -1815931838;
				num712 = num2;
			}
			else
			{
				num2 = -1521529326;
				num712 = num2;
			}
			continue;
			IL_3694:
			int num713;
			if (!(condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4024965808u)))
			{
				num2 = -748598680;
				num713 = num2;
			}
			else
			{
				num2 = -483142664;
				num713 = num2;
			}
			continue;
			IL_8ac7:
			int num714;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3199971033u)))
			{
				num2 = -1882022622;
				num714 = num2;
			}
			else
			{
				num2 = -1775496732;
				num714 = num2;
			}
			continue;
			IL_bb7b:
			int num715;
			if (condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2792527707u))
			{
				num2 = -1019448758;
				num715 = num2;
			}
			else
			{
				num2 = -771494264;
				num715 = num2;
			}
			continue;
			IL_62ac:
			teamRole44 = RuntimeData.Instance.GetTeamRole(roleKey27);
			int num716;
			if (teamRole44 == null)
			{
				num2 = -1444017753;
				num716 = num2;
			}
			else
			{
				num2 = -921141794;
				num716 = num2;
			}
			continue;
			IL_48ff:
			int num717;
			if (teamRole44.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3535376985u)] >= num155)
			{
				num2 = -536551943;
				num717 = num2;
			}
			else
			{
				num2 = -1368745350;
				num717 = num2;
			}
			continue;
			IL_ba83:
			string text54 = text43.Replace(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1875398881u), RuntimeData.Instance.RoundString());
			string oldValue19 = global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3579531764u);
			num75 = teamRole41.MAX_ATTRIBUTE;
			int num718 = (int)double.Parse(Tools.Compute(text54.Replace(oldValue19, num75.ToString())));
			int num719;
			if (teamRole41.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(664072894u)] < num718)
			{
				num2 = -1320329069;
				num719 = num2;
			}
			else
			{
				num2 = -1404710314;
				num719 = num2;
			}
			continue;
			IL_8a9c:
			int num720;
			if (condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1648103964u))
			{
				num2 = -1028441557;
				num720 = num2;
			}
			else
			{
				num2 = -831360315;
				num720 = num2;
			}
			continue;
			IL_16e5:
			int num721;
			if (!_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3261685221u)))
			{
				num2 = -1339190408;
				num721 = num2;
			}
			else
			{
				num2 = -1737471621;
				num721 = num2;
			}
			continue;
			IL_b9ee:
			int num722;
			if (flag)
			{
				num2 = -1642263395;
				num722 = num2;
			}
			else
			{
				num2 = -1209420865;
				num722 = num2;
			}
			continue;
			IL_60f7:
			int num723;
			if (num120 == -1)
			{
				num2 = -1440322181;
				num723 = num2;
			}
			else
			{
				num2 = -90142639;
				num723 = num2;
			}
			continue;
			IL_8a38:
			int num724;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1743143517u)))
			{
				num2 = -1512858345;
				num724 = num2;
			}
			else
			{
				num2 = -1582173371;
				num724 = num2;
			}
			continue;
			IL_b92e:
			int num725;
			if (condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1131154416u))
			{
				num2 = -595533574;
				num725 = num2;
			}
			else
			{
				num2 = -660608957;
				num725 = num2;
			}
			continue;
			IL_2ea4:
			teamRole45 = RuntimeData.Instance.GetTeamRole(roleKey14);
			int num726;
			if (teamRole45 == null)
			{
				num2 = -1718608274;
				num726 = num2;
			}
			else
			{
				num2 = -1713452016;
				num726 = num2;
			}
			continue;
			IL_4766:
			teamRole46 = RuntimeData.Instance.GetTeamRole(roleKey38);
			int num727;
			if (teamRole46 == null)
			{
				num2 = -591060819;
				num727 = num2;
			}
			else
			{
				num2 = -1068267435;
				num727 = num2;
			}
			continue;
			IL_b7ed:
			int num728;
			if (condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2581382918u))
			{
				num2 = -472602779;
				num728 = num2;
			}
			else
			{
				num2 = -568507766;
				num728 = num2;
			}
			continue;
			IL_89b2:
			int num729;
			if (!(condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1803327088u)))
			{
				num2 = -953942299;
				num729 = num2;
			}
			else
			{
				num2 = -1435676309;
				num729 = num2;
			}
			continue;
			IL_5f3b:
			roleKey12 = string.Empty;
			num142 = 0;
			int num730;
			if (array25.Length != 1)
			{
				num2 = -74183502;
				num730 = num2;
			}
			else
			{
				num2 = -452213616;
				num730 = num2;
			}
			continue;
			IL_b7a0:
			roleKey49 = string.Empty;
			num444 = 0;
			int num731;
			if (array28.Length == 1)
			{
				num2 = -2116293146;
				num731 = num2;
			}
			else
			{
				num2 = -268226619;
				num731 = num2;
			}
			continue;
			IL_3669:
			int num732;
			if (!(condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1011280583u)))
			{
				num2 = -175807258;
				num732 = num2;
			}
			else
			{
				num2 = -1883373942;
				num732 = num2;
			}
			continue;
			IL_894c:
			teamRole13 = RuntimeData.Instance.GetTeamRole(roleKey55);
			int num733;
			if (teamRole13 != null)
			{
				num2 = -1852660311;
				num733 = num2;
			}
			else
			{
				num2 = -1046189833;
				num733 = num2;
			}
			continue;
			IL_b75e:
			int num734;
			if (condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(988686398u))
			{
				num2 = -1405001350;
				num734 = num2;
			}
			else
			{
				num2 = -184371114;
				num734 = num2;
			}
			continue;
			IL_2264:
			int num735;
			if (num217 != 2)
			{
				num2 = -1357698075;
				num735 = num2;
			}
			else
			{
				num2 = -774086719;
				num735 = num2;
			}
			continue;
			IL_5f0d:
			int num736;
			if (teamRole46.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(739543880u)] >= num314)
			{
				num2 = -1924034759;
				num736 = num2;
			}
			else
			{
				num2 = -186157817;
				num736 = num2;
			}
			continue;
			IL_b5d2:
			int num737;
			if (!(condition.type == global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2469439085u)))
			{
				num2 = -1259355019;
				num737 = num2;
			}
			else
			{
				num2 = -1460751716;
				num737 = num2;
			}
			continue;
			IL_8899:
			teamRole47 = RuntimeData.Instance.GetTeamRole(roleKey29);
			int num738;
			if (teamRole47 != null)
			{
				num2 = -604888064;
				num738 = num2;
			}
			else
			{
				num2 = -1457033312;
				num738 = num2;
			}
			continue;
			IL_4577:
			int num739;
			if (teamRole20.GetInternalSkillLevel(text11) >= num162)
			{
				num2 = -1725238238;
				num739 = num2;
			}
			else
			{
				num2 = -2041991349;
				num739 = num2;
			}
			continue;
			IL_b5a7:
			int num740;
			if (!(condition.type == global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3615434333u)))
			{
				num2 = -1567726049;
				num740 = num2;
			}
			else
			{
				num2 = -1018084583;
				num740 = num2;
			}
			continue;
			IL_1d09:
			int num741;
			if (teamRole31.HasTalent(array69[num132]))
			{
				num2 = -1018029270;
				num741 = num2;
			}
			else
			{
				num2 = -573568395;
				num741 = num2;
			}
			continue;
			IL_8834:
			int num742;
			if (condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1632173079u))
			{
				num2 = -95587347;
				num742 = num2;
			}
			else
			{
				num2 = -350793450;
				num742 = num2;
			}
			continue;
			IL_b532:
			string text55 = text31.Replace(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(800863094u), RuntimeData.Instance.RoundString());
			string oldValue20 = global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3579531764u);
			num75 = teamRole29.MAX_ATTRIBUTE;
			int num743 = (int)double.Parse(Tools.Compute(text55.Replace(oldValue20, num75.ToString())));
			int num744;
			if (teamRole29.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(664072894u)] < num743)
			{
				num2 = -916457890;
				num744 = num2;
			}
			else
			{
				num2 = -885901007;
				num744 = num2;
			}
			continue;
			IL_5ec1:
			teamRole24 = RuntimeData.Instance.GetTeamRole(roleKey40);
			int num745;
			if (teamRole24 == null)
			{
				num2 = -643974885;
				num745 = num2;
			}
			else
			{
				num2 = -963491916;
				num745 = num2;
			}
			continue;
			IL_35d7:
			int num746;
			if (teamRole4.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2249625138u)] >= num232)
			{
				num2 = -144796569;
				num746 = num2;
			}
			else
			{
				num2 = -313883519;
				num746 = num2;
			}
			continue;
			IL_b4dd:
			teamRole8 = RuntimeData.Instance.GetTeamRole(roleKey33);
			int num747;
			if (teamRole8 != null)
			{
				num2 = -1515914496;
				num747 = num2;
			}
			else
			{
				num2 = -491492428;
				num747 = num2;
			}
			continue;
			IL_859f:
			int num748;
			if (num110 < num114)
			{
				num2 = -982538660;
				num748 = num2;
			}
			else
			{
				num2 = -1226104069;
				num748 = num2;
			}
			continue;
			IL_4488:
			roleKey55 = string.Empty;
			text15 = string.Empty;
			int num749;
			if (array36.Length != 1)
			{
				num2 = -402550194;
				num749 = num2;
			}
			else
			{
				num2 = -1278814521;
				num749 = num2;
			}
			continue;
			IL_b441:
			int num750;
			if (num452 == 4)
			{
				num2 = -239090554;
				num750 = num2;
			}
			else
			{
				num2 = -631942500;
				num750 = num2;
			}
			continue;
			IL_5ea0:
			int num751;
			if (condition.number <= 0)
			{
				num751 = int.Parse(array60[1]);
				goto IL_392b;
			}
			num2 = (int)(num * 1506471539) ^ -509509090;
			continue;
			IL_852a:
			string text56 = text26.Replace(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(800863094u), RuntimeData.Instance.RoundString());
			string oldValue21 = global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3279928277u);
			num75 = teamRole23.MAX_ATTRIBUTE;
			int num752 = (int)double.Parse(Tools.Compute(text56.Replace(oldValue21, num75.ToString())));
			int num753;
			if (teamRole23.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2575692001u)] >= num752)
			{
				num2 = -2078630663;
				num753 = num2;
			}
			else
			{
				num2 = -1199406708;
				num753 = num2;
			}
			continue;
			IL_b427:
			int num754;
			if (num110 >= num114)
			{
				num2 = -319750784;
				num754 = num2;
			}
			else
			{
				num2 = -928864605;
				num754 = num2;
			}
			continue;
			IL_2e5e:
			int num755;
			if (num217 != 4)
			{
				num2 = -1488381588;
				num755 = num2;
			}
			else
			{
				num2 = -1698349913;
				num755 = num2;
			}
			continue;
			IL_19ab:
			teamRole48 = RuntimeData.Instance.GetTeamRole(roleKey3);
			int num756;
			if (teamRole48 != null)
			{
				num2 = -242795851;
				num756 = num2;
			}
			else
			{
				num2 = -1765119231;
				num756 = num2;
			}
			continue;
			IL_b1fc:
			int num757;
			if (!(condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(179930771u)))
			{
				num2 = -906505137;
				num757 = num2;
			}
			else
			{
				num2 = -298114539;
				num757 = num2;
			}
			continue;
			IL_84e3:
			int num758;
			if (!(condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(389179294u)))
			{
				num2 = -1262985179;
				num758 = num2;
			}
			else
			{
				num2 = -1932497553;
				num758 = num2;
			}
			continue;
			IL_5d28:
			int num759;
			if (!(condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(66822963u)))
			{
				num2 = -750233963;
				num759 = num2;
			}
			else
			{
				num2 = -1477827850;
				num759 = num2;
			}
			continue;
			IL_afea:
			int num760;
			if (!(condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3956886694u)))
			{
				num2 = -799526003;
				num760 = num2;
			}
			else
			{
				num2 = -1399265791;
				num760 = num2;
			}
			continue;
			IL_443a:
			int num761;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2392473003u)))
			{
				num2 = -1564099293;
				num761 = num2;
			}
			else
			{
				num2 = -2002566360;
				num761 = num2;
			}
			continue;
			IL_84bd:
			teamRole49 = RuntimeData.Instance.GetTeamRole(roleKey48);
			int num762;
			if (teamRole49 == null)
			{
				num2 = -1271973427;
				num762 = num2;
			}
			else
			{
				num2 = -917831267;
				num762 = num2;
			}
			continue;
			IL_aee7:
			int num763;
			if (teamRole50.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2475589736u)] < num142)
			{
				num2 = -523297220;
				num763 = num2;
			}
			else
			{
				num2 = -1758951527;
				num763 = num2;
			}
			continue;
			IL_3523:
			string text57 = text44.Replace(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1875398881u), RuntimeData.Instance.RoundString());
			string oldValue22 = global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3579531764u);
			num75 = teamRole51.MAX_ATTRIBUTE;
			int num764 = (int)double.Parse(Tools.Compute(text57.Replace(oldValue22, num75.ToString())));
			int num765;
			if (teamRole51.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(248942232u)] >= num764)
			{
				num2 = -1055805014;
				num765 = num2;
			}
			else
			{
				num2 = -1733222081;
				num765 = num2;
			}
			continue;
			IL_5cca:
			int num766;
			if (condition.type == global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3812245086u))
			{
				num2 = -191048506;
				num766 = num2;
			}
			else
			{
				num2 = -1165209529;
				num766 = num2;
			}
			continue;
			IL_ae96:
			int num767;
			if (condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4193585181u))
			{
				num2 = -26294528;
				num767 = num2;
			}
			else
			{
				num2 = -1040660560;
				num767 = num2;
			}
			continue;
			IL_82d3:
			int num768;
			if (condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1506046533u))
			{
				num2 = -1643198757;
				num768 = num2;
			}
			else
			{
				num2 = -1326874288;
				num768 = num2;
			}
			continue;
			IL_2236:
			int num769;
			if (!teamRole25.HasRoleTalent(array64[num485]))
			{
				num2 = -1020655971;
				num769 = num2;
			}
			else
			{
				num2 = -874531487;
				num769 = num2;
			}
			continue;
			IL_ae27:
			int num770;
			if (num217 < 6)
			{
				num2 = -319750784;
				num770 = num2;
			}
			else
			{
				num2 = -1213712290;
				num770 = num2;
			}
			continue;
			IL_4188:
			string text58 = text24.Replace(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3121341046u), RuntimeData.Instance.RoundString());
			string oldValue23 = global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3579531764u);
			num75 = teamRole40.MAX_ATTRIBUTE;
			int num771 = (int)double.Parse(Tools.Compute(text58.Replace(oldValue23, num75.ToString())));
			int num772;
			if (teamRole40.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(710450445u)] < num771)
			{
				num2 = -1200390155;
				num772 = num2;
			}
			else
			{
				num2 = -324096290;
				num772 = num2;
			}
			continue;
			IL_813e:
			int num773 = Math.Max(condition.number, 1);
			goto IL_8155;
			IL_adeb:
			int num774;
			if (condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1417958351u))
			{
				num2 = -1754283717;
				num774 = num2;
			}
			else
			{
				num2 = -207782306;
				num774 = num2;
			}
			continue;
			IL_7fd8:
			int num775;
			if (!RuntimeData.Instance.KeyValues.ContainsKey(array41[0]))
			{
				num2 = -181827627;
				num775 = num2;
			}
			else
			{
				num2 = -1447793413;
				num775 = num2;
			}
			continue;
			IL_5c9f:
			int num776;
			if (!(condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3785706900u)))
			{
				num2 = -1336357728;
				num776 = num2;
			}
			else
			{
				num2 = -685158889;
				num776 = num2;
			}
			continue;
			IL_acae:
			string[] array78 = RuntimeData.Instance.KeyValues[array77[0]].Split('#');
			int num777;
			if (array78.Length >= 3)
			{
				num777 = int.Parse(array78[2]);
				goto IL_541a;
			}
			num2 = ((int)num * -339103034) ^ 0xE0E1701;
			continue;
			IL_2de9:
			string text59 = text13.Replace(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3250051652u), RuntimeData.Instance.RoundString());
			string oldValue24 = global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2783180816u);
			num75 = teamRole33.MAX_ATTRIBUTE;
			int num778 = (int)double.Parse(Tools.Compute(text59.Replace(oldValue24, num75.ToString())));
			int num779;
			if (teamRole33.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1923523063u)] < num778)
			{
				num2 = -1759226743;
				num779 = num2;
			}
			else
			{
				num2 = -1267341383;
				num779 = num2;
			}
			continue;
			IL_7ecb:
			int num780;
			if (teamRole52.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1564888282u)] >= num230)
			{
				num2 = -1971403959;
				num780 = num2;
			}
			else
			{
				num2 = -168885929;
				num780 = num2;
			}
			continue;
			IL_a9ff:
			int num781;
			if (num143 >= num144)
			{
				num2 = -51972560;
				num781 = num2;
			}
			else
			{
				num2 = -68622685;
				num781 = num2;
			}
			continue;
			IL_34f8:
			int num782;
			if (!(condition.type == global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2307497602u)))
			{
				num2 = -800910590;
				num782 = num2;
			}
			else
			{
				num2 = -1259600711;
				num782 = num2;
			}
			continue;
			IL_5c71:
			int num783;
			if (teamRole42.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2301880830u)] < num395)
			{
				num2 = -494599585;
				num783 = num2;
			}
			else
			{
				num2 = -2040861862;
				num783 = num2;
			}
			continue;
			IL_a98e:
			int num784;
			if (condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1755742198u))
			{
				num2 = -793209516;
				num784 = num2;
			}
			else
			{
				num2 = -1661907332;
				num784 = num2;
			}
			continue;
			IL_7e8a:
			int num785;
			if (condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3381889714u))
			{
				num2 = -239777285;
				num785 = num2;
			}
			else
			{
				num2 = -1191981436;
				num785 = num2;
			}
			continue;
			IL_415d:
			int num786;
			if (!(condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1882381256u)))
			{
				num2 = -496381094;
				num786 = num2;
			}
			else
			{
				num2 = -179767262;
				num786 = num2;
			}
			continue;
			IL_a952:
			teamRole35 = RuntimeData.Instance.GetTeamRole(roleKey51);
			int num787;
			if (teamRole35 == null)
			{
				num2 = -1377563604;
				num787 = num2;
			}
			else
			{
				num2 = -2026737541;
				num787 = num2;
			}
			continue;
			IL_1646:
			int num788;
			if (condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3315792894u))
			{
				num2 = -1951778320;
				num788 = num2;
			}
			else
			{
				num2 = -1349316549;
				num788 = num2;
			}
			continue;
			IL_7e5f:
			int num789;
			if (condition.type == global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2419332954u))
			{
				num2 = -1266448878;
				num789 = num2;
			}
			else
			{
				num2 = -1561664127;
				num789 = num2;
			}
			continue;
			IL_a899:
			teamRole53 = RuntimeData.Instance.GetTeamRole(roleKey42);
			int num790;
			if (teamRole53 == null)
			{
				num2 = -1191713912;
				num790 = num2;
			}
			else
			{
				num2 = -925781488;
				num790 = num2;
			}
			continue;
			IL_5bf1:
			int num791;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1538408519u)))
			{
				num2 = -1647566496;
				num791 = num2;
			}
			else
			{
				num2 = -1416126988;
				num791 = num2;
			}
			continue;
			IL_1cc0:
			int num792;
			if (!teamRole32.HasEquipmentTalent(array20[num356]))
			{
				num2 = -1877328726;
				num792 = num2;
			}
			else
			{
				num2 = -1093972033;
				num792 = num2;
			}
			continue;
			IL_a847:
			int num793;
			if (condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(324835688u))
			{
				num2 = -1236430512;
				num793 = num2;
			}
			else
			{
				num2 = -521293071;
				num793 = num2;
			}
			continue;
			IL_7c2f:
			int num794;
			if (!(condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2967500518u)))
			{
				num2 = -1515116784;
				num794 = num2;
			}
			else
			{
				num2 = -2133369890;
				num794 = num2;
			}
			continue;
			IL_4127:
			teamRole54 = RuntimeData.Instance.GetTeamRole(roleKey49);
			int num795;
			if (teamRole54 == null)
			{
				num2 = -672272506;
				num795 = num2;
			}
			else
			{
				num2 = -1934571641;
				num795 = num2;
			}
			continue;
			IL_a73d:
			teamRole50 = RuntimeData.Instance.GetTeamRole(roleKey12);
			int num796;
			if (teamRole50 != null)
			{
				num2 = -1379523365;
				num796 = num2;
			}
			else
			{
				num2 = -1951507320;
				num796 = num2;
			}
			continue;
			IL_5b89:
			int num797;
			if (!(condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2208448119u)))
			{
				num2 = -1543370871;
				num797 = num2;
			}
			else
			{
				num2 = -666291960;
				num797 = num2;
			}
			continue;
			IL_7ba4:
			teamRole55 = RuntimeData.Instance.GetTeamRole(roleKey52);
			int num798;
			if (teamRole55 == null)
			{
				num2 = -53137482;
				num798 = num2;
			}
			else
			{
				num2 = -1207003484;
				num798 = num2;
			}
			continue;
			IL_a685:
			int num799;
			if (teamRole15.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1944260873u)] >= num158)
			{
				num2 = -4340499;
				num799 = num2;
			}
			else
			{
				num2 = -1800244992;
				num799 = num2;
			}
			continue;
			IL_33fb:
			int num800;
			if (!(condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2541497357u)))
			{
				num2 = -419505146;
				num800 = num2;
			}
			else
			{
				num2 = -812622650;
				num800 = num2;
			}
			continue;
			IL_2dbe:
			int num801;
			if (condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4107828666u))
			{
				num2 = -690731887;
				num801 = num2;
			}
			else
			{
				num2 = -881860933;
				num801 = num2;
			}
			continue;
			IL_a66c:
			int num802;
			if (num452 == 3)
			{
				num2 = -183684854;
				num802 = num2;
			}
			else
			{
				num2 = -492840617;
				num802 = num2;
			}
			continue;
			IL_7964:
			int num803;
			if (condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4054062386u))
			{
				num2 = -1123844612;
				num803 = num2;
			}
			else
			{
				num2 = -212485709;
				num803 = num2;
			}
			continue;
			IL_5b44:
			int num804;
			if (teamRole56.Attributes[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2722506620u)] < num388)
			{
				num2 = -480369784;
				num804 = num2;
			}
			else
			{
				num2 = -1395752812;
				num804 = num2;
			}
			continue;
			IL_a608:
			teamRole56 = RuntimeData.Instance.GetTeamRole(roleKey45);
			int num805;
			if (teamRole56 != null)
			{
				num2 = -2070697644;
				num805 = num2;
			}
			else
			{
				num2 = -195723626;
				num805 = num2;
			}
			continue;
			IL_40da:
			roleKey54 = string.Empty;
			num301 = 0;
			int num806;
			if (array67.Length == 1)
			{
				num2 = -1212823687;
				num806 = num2;
			}
			else
			{
				num2 = -1436994321;
				num806 = num2;
			}
			continue;
			IL_7939:
			int num807;
			if (!(condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(531245868u)))
			{
				num2 = -424333286;
				num807 = num2;
			}
			else
			{
				num2 = -1066637911;
				num807 = num2;
			}
			continue;
			IL_a5c7:
			int num808;
			if (!(condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3566195989u)))
			{
				num2 = -761003351;
				num808 = num2;
			}
			else
			{
				num2 = -340115337;
				num808 = num2;
			}
			continue;
			IL_2030:
			string text60 = text18.Replace(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3250051652u), RuntimeData.Instance.RoundString());
			string oldValue25 = global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3279928277u);
			num75 = teamRole55.MAX_ATTRIBUTE;
			int num809 = (int)double.Parse(Tools.Compute(text60.Replace(oldValue25, num75.ToString())));
			int num810;
			if (teamRole55.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(424952987u)] < num809)
			{
				num2 = -1415837116;
				num810 = num2;
			}
			else
			{
				num2 = -848296024;
				num810 = num2;
			}
			continue;
			IL_5a1a:
			int num811;
			if (!(condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3332547748u)))
			{
				num2 = -39145776;
				num811 = num2;
			}
			else
			{
				num2 = -1209327651;
				num811 = num2;
			}
			continue;
			IL_a598:
			int num812;
			if (num452 == 1)
			{
				num2 = -2104990698;
				num812 = num2;
			}
			else
			{
				num2 = -1049550520;
				num812 = num2;
			}
			continue;
			IL_790e:
			int num813;
			if (!(condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1349904213u)))
			{
				num2 = -2140460685;
				num813 = num2;
			}
			else
			{
				num2 = -275292415;
				num813 = num2;
			}
			continue;
			IL_33cd:
			int num814;
			if (num217 != 3)
			{
				num2 = -1064406889;
				num814 = num2;
			}
			else
			{
				num2 = -710075176;
				num814 = num2;
			}
			continue;
			IL_a513:
			int num815;
			if (teamRole11.AttributesFinal[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1995100678u)] < num109)
			{
				num2 = -242718703;
				num815 = num2;
			}
			else
			{
				num2 = -727815523;
				num815 = num2;
			}
			continue;
			IL_3ed6:
			int num816;
			if (!(condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1157940341u)))
			{
				num2 = -1413098651;
				num816 = num2;
			}
			else
			{
				num2 = -1712355635;
				num816 = num2;
			}
			continue;
			IL_78a9:
			int num817;
			if (teamRole7.HasTalent(array23[num507]))
			{
				num2 = -1316406477;
				num817 = num2;
			}
			else
			{
				num2 = -1038256312;
				num817 = num2;
			}
			continue;
			IL_a3ec:
			int num818;
			if (teamRole16.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2259249129u)] >= num212)
			{
				num2 = -1229973939;
				num818 = num2;
			}
			else
			{
				num2 = -1174366562;
				num818 = num2;
			}
			continue;
			IL_588d:
			int num819;
			if (teamRole43.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2249625138u)] < num179)
			{
				num2 = -944424404;
				num819 = num2;
			}
			else
			{
				num2 = -1928113201;
				num819 = num2;
			}
			continue;
			IL_1809:
			roleKey48 = string.Empty;
			num437 = 0;
			int num820;
			if (array74.Length != 1)
			{
				num2 = -383077417;
				num820 = num2;
			}
			else
			{
				num2 = -1968995784;
				num820 = num2;
			}
			continue;
			IL_a21f:
			int num821;
			if (teamRole20.GetSkillLevel(text11) >= num162)
			{
				num2 = -1472140803;
				num821 = num2;
			}
			else
			{
				num2 = -234710427;
				num821 = num2;
			}
			continue;
			IL_77b6:
			int num822;
			if (condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1171622527u))
			{
				num2 = -66677335;
				num822 = num2;
			}
			else
			{
				num2 = -627365616;
				num822 = num2;
			}
			continue;
			IL_2c9a:
			int num823;
			if (teamRole47.Attributes[global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3406067330u)] < num136)
			{
				num2 = -1328770015;
				num823 = num2;
			}
			else
			{
				num2 = -502563020;
				num823 = num2;
			}
			continue;
			IL_a182:
			int num824;
			if (teamRole38.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1790491204u)] >= num160)
			{
				num2 = -991644986;
				num824 = num2;
			}
			else
			{
				num2 = -1758027287;
				num824 = num2;
			}
			continue;
			IL_5862:
			int num825;
			if (!_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(320587214u)))
			{
				num2 = -1292404236;
				num825 = num2;
			}
			else
			{
				num2 = -1226997270;
				num825 = num2;
			}
			continue;
			IL_76f6:
			int num826;
			if (teamRole9.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2223184606u)] >= num301)
			{
				num2 = -851021834;
				num826 = num2;
			}
			else
			{
				num2 = -1183115462;
				num826 = num2;
			}
			continue;
			IL_a137:
			int num827;
			if (!(condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1396210625u)))
			{
				num2 = -1278651475;
				num827 = num2;
			}
			else
			{
				num2 = -1438295918;
				num827 = num2;
			}
			continue;
			IL_3cfa:
			int num828;
			if (!(condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3042346888u)))
			{
				num2 = -94504246;
				num828 = num2;
			}
			else
			{
				num2 = -637596641;
				num828 = num2;
			}
			continue;
			IL_33a2:
			int num829;
			if (condition.type == global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2666249838u))
			{
				num2 = -655527037;
				num829 = num2;
			}
			else
			{
				num2 = -745694272;
				num829 = num2;
			}
			continue;
			IL_a07d:
			int num830;
			if (condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(28988799u))
			{
				num2 = -754665666;
				num830 = num2;
			}
			else
			{
				num2 = -977968701;
				num830 = num2;
			}
			continue;
			IL_730a:
			int num831;
			if (condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(330406378u))
			{
				num2 = -1567011252;
				num831 = num2;
			}
			else
			{
				num2 = -2014531020;
				num831 = num2;
			}
			continue;
			IL_578f:
			int num832;
			if (condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(513518856u))
			{
				num2 = -1238365165;
				num832 = num2;
			}
			else
			{
				num2 = -144171407;
				num832 = num2;
			}
			continue;
			IL_9eb6:
			int num833;
			if (array69.Length != 1)
			{
				num2 = -922121637;
				num833 = num2;
			}
			else
			{
				num2 = -281770183;
				num833 = num2;
			}
			continue;
			IL_191e:
			int num834;
			if (!(condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1779176166u)))
			{
				num2 = -688600302;
				num834 = num2;
			}
			else
			{
				num2 = -967634558;
				num834 = num2;
			}
			continue;
			IL_72df:
			int num835;
			if (!(condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3040949333u)))
			{
				num2 = -349172073;
				num835 = num2;
			}
			else
			{
				num2 = -2000979628;
				num835 = num2;
			}
			continue;
			IL_9dac:
			int num836;
			if (condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3944553756u))
			{
				num2 = -59986283;
				num836 = num2;
			}
			else
			{
				num2 = -1985235582;
				num836 = num2;
			}
			continue;
			IL_3ca9:
			int num837;
			if (condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(122204110u))
			{
				num2 = -112142611;
				num837 = num2;
			}
			else
			{
				num2 = -355918506;
				num837 = num2;
			}
			continue;
			IL_540e:
			num777 = 1;
			goto IL_541a;
			IL_9d71:
			int num838;
			if (condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(519550208u))
			{
				num2 = -914336927;
				num838 = num2;
			}
			else
			{
				num2 = -2098451430;
				num838 = num2;
			}
			continue;
			IL_7279:
			string text61 = text21.Replace(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1381559287u), RuntimeData.Instance.RoundString());
			string oldValue26 = global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2783180816u);
			num75 = teamRole57.MAX_LEVEL;
			int num839 = (int)double.Parse(Tools.Compute(text61.Replace(oldValue26, num75.ToString())));
			int num840;
			if (teamRole57.Level < num839)
			{
				num2 = -153161708;
				num840 = num2;
			}
			else
			{
				num2 = -1124865556;
				num840 = num2;
			}
			continue;
			IL_541a:
			int num841;
			if (num777 >= int.Parse(array77[1]))
			{
				num2 = -471712486;
				num841 = num2;
			}
			else
			{
				num2 = -911265553;
				num841 = num2;
			}
			continue;
			IL_9d4b:
			int num842;
			if (num110 >= num114)
			{
				num2 = -390182410;
				num842 = num2;
			}
			else
			{
				num2 = -425054171;
				num842 = num2;
			}
			continue;
			IL_1fe9:
			int num843;
			if (!(condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3315383313u)))
			{
				num2 = -767311081;
				num843 = num2;
			}
			else
			{
				num2 = -706059548;
				num843 = num2;
			}
			continue;
			IL_71d7:
			int num844;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2693786157u)))
			{
				num2 = -1168982940;
				num844 = num2;
			}
			else
			{
				num2 = -1120942815;
				num844 = num2;
			}
			continue;
			IL_9cde:
			int num845;
			if (teamRole37.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3058596364u)] < num225)
			{
				num2 = -1366327788;
				num845 = num2;
			}
			else
			{
				num2 = -223778918;
				num845 = num2;
			}
			continue;
			IL_3343:
			int num846;
			if (teamRole17.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(701808387u)] >= num161)
			{
				num2 = -1427132256;
				num846 = num2;
			}
			else
			{
				num2 = -1533095264;
				num846 = num2;
			}
			continue;
			IL_53cf:
			int num847;
			if (num75 < array10.Length)
			{
				num2 = -141311678;
				num847 = num2;
			}
			else
			{
				num2 = -188297921;
				num847 = num2;
			}
			continue;
			IL_9cc4:
			int num848;
			if (num143 < num144)
			{
				num2 = -1862094870;
				num848 = num2;
			}
			else
			{
				num2 = -491438791;
				num848 = num2;
			}
			continue;
			IL_71ac:
			int num849;
			if (condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4080393772u))
			{
				num2 = -1841971520;
				num849 = num2;
			}
			else
			{
				num2 = -226583881;
				num849 = num2;
			}
			continue;
			IL_3c83:
			teamRole51 = RuntimeData.Instance.GetTeamRole(roleKey23);
			int num850;
			if (teamRole51 != null)
			{
				num2 = -370301477;
				num850 = num2;
			}
			else
			{
				num2 = -1589118432;
				num850 = num2;
			}
			continue;
			IL_9c64:
			int num851;
			if (condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1636085515u))
			{
				num2 = -1853973336;
				num851 = num2;
			}
			else
			{
				num2 = -270141781;
				num851 = num2;
			}
			continue;
			IL_2bb1:
			int num852;
			if (condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3228782035u))
			{
				num2 = -99790337;
				num852 = num2;
			}
			else
			{
				num2 = -1195618525;
				num852 = num2;
			}
			continue;
			IL_713a:
			int num853;
			if (condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1812842499u))
			{
				num2 = -335221079;
				num853 = num2;
			}
			else
			{
				num2 = -120809643;
				num853 = num2;
			}
			continue;
			IL_9c39:
			int num854;
			if (!(condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(350891008u)))
			{
				num2 = -1222450634;
				num854 = num2;
			}
			else
			{
				num2 = -1140863744;
				num854 = num2;
			}
			continue;
			IL_5296:
			int num855;
			if (condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3106792757u))
			{
				num2 = -1906980351;
				num855 = num2;
			}
			else
			{
				num2 = -2102181466;
				num855 = num2;
			}
			continue;
			IL_1c9a:
			teamRole58 = RuntimeData.Instance.GetTeamRole(roleKey6);
			int num856;
			if (teamRole58 == null)
			{
				num2 = -318016928;
				num856 = num2;
			}
			else
			{
				num2 = -822259515;
				num856 = num2;
			}
			continue;
			IL_9bc4:
			int num857;
			if (!(condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(238237322u)))
			{
				num2 = -1946618270;
				num857 = num2;
			}
			else
			{
				num2 = -1777454568;
				num857 = num2;
			}
			continue;
			IL_70aa:
			int num858;
			if (condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(15220418u))
			{
				num2 = -717621741;
				num858 = num2;
			}
			else
			{
				num2 = -169557256;
				num858 = num2;
			}
			continue;
			IL_3bb0:
			int num859;
			if (condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3435468698u))
			{
				num2 = -1929121117;
				num859 = num2;
			}
			else
			{
				num2 = -490179659;
				num859 = num2;
			}
			continue;
			IL_9a75:
			int num860;
			if (condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2013754923u))
			{
				num2 = -1237559695;
				num860 = num2;
			}
			else
			{
				num2 = -315473529;
				num860 = num2;
			}
			continue;
			IL_5237:
			int num861;
			if (array20.Length == 1)
			{
				num2 = -372178996;
				num861 = num2;
			}
			else
			{
				num2 = -644697417;
				num861 = num2;
			}
			continue;
			IL_704c:
			if (condition.number > 0)
			{
				num2 = ((int)num * -1132768379) ^ 0x3E391821;
				continue;
			}
			num773 = int.Parse(array66[1]);
			goto IL_8155;
			IL_99a9:
			int num862;
			if (teamRole19.Level < num113)
			{
				num2 = -874682809;
				num862 = num2;
			}
			else
			{
				num2 = -127379098;
				num862 = num2;
			}
			continue;
			IL_32fd:
			int num863;
			if (num217 != 1)
			{
				num2 = -882711061;
				num863 = num2;
			}
			else
			{
				num2 = -258757915;
				num863 = num2;
			}
			continue;
			IL_1620:
			teamRole57 = RuntimeData.Instance.GetTeamRole(roleKey37);
			int num864;
			if (teamRole57 == null)
			{
				num2 = -1469033681;
				num864 = num2;
			}
			else
			{
				num2 = -317534559;
				num864 = num2;
			}
			continue;
			IL_97c8:
			int num865;
			if (num485 >= array64.Length)
			{
				num2 = -517325800;
				num865 = num2;
			}
			else
			{
				num2 = -2107088242;
				num865 = num2;
			}
			continue;
			IL_8155:
			num144 = num773;
			int num866;
			if (array66.Length <= 2)
			{
				num2 = -1908269602;
				num866 = num2;
			}
			else
			{
				num2 = -1705541831;
				num866 = num2;
			}
			continue;
			IL_51dc:
			int num867;
			if (num143 >= num144)
			{
				num2 = -51972560;
				num867 = num2;
			}
			else
			{
				num2 = -1215061102;
				num867 = num2;
			}
			continue;
			IL_976c:
			int num868;
			if (num132 >= array69.Length)
			{
				num2 = -2045071027;
				num868 = num2;
			}
			else
			{
				num2 = -15382359;
				num868 = num2;
			}
			continue;
			IL_3a9f:
			int num869;
			if (!(condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3122723642u)))
			{
				num2 = -1160440204;
				num869 = num2;
			}
			else
			{
				num2 = -1256319056;
				num869 = num2;
			}
			continue;
			IL_6fb3:
			int num870;
			if (array23.Length == 1)
			{
				num2 = -1413844895;
				num870 = num2;
			}
			else
			{
				num2 = -749810396;
				num870 = num2;
			}
			continue;
			IL_96ed:
			if (condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(85080470u))
			{
				num2 = -410028520;
				continue;
			}
			goto IL_d18f;
			IL_27e5:
			int num871;
			if (num143 < num144)
			{
				num2 = -1956290289;
				num871 = num2;
			}
			else
			{
				num2 = -1831765866;
				num871 = num2;
			}
			continue;
			IL_9558:
			int num872;
			if (!(condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2851774473u)))
			{
				num2 = -1525923902;
				num872 = num2;
			}
			else
			{
				num2 = -798078184;
				num872 = num2;
			}
			continue;
			IL_4f09:
			int num873;
			if (num110 < num114)
			{
				num2 = -724030050;
				num873 = num2;
			}
			else
			{
				num2 = -319750784;
				num873 = num2;
			}
			continue;
			IL_6f4e:
			int num874;
			if (condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1334892524u))
			{
				num2 = -1797205741;
				num874 = num2;
			}
			else
			{
				num2 = -408192755;
				num874 = num2;
			}
			continue;
			IL_9475:
			int num875;
			if (array70.Length <= 1)
			{
				num2 = -1859196173;
				num875 = num2;
			}
			else
			{
				num2 = -1126760067;
				num875 = num2;
			}
			continue;
			IL_31ea:
			int num876;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(471529186u)))
			{
				num2 = -1861196859;
				num876 = num2;
			}
			else
			{
				num2 = -1165546530;
				num876 = num2;
			}
			continue;
			IL_3a1a:
			int num877;
			if (skillLevel != -1)
			{
				num2 = -885000384;
				num877 = num2;
			}
			else
			{
				num2 = -286244016;
				num877 = num2;
			}
			continue;
			IL_9409:
			int num878;
			if (!(condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(946834714u)))
			{
				num2 = -1946164427;
				num878 = num2;
			}
			else
			{
				num2 = -845198408;
				num878 = num2;
			}
			continue;
			IL_6e21:
			string text62 = text49.Replace(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3250051652u), RuntimeData.Instance.RoundString());
			string oldValue27 = global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3579531764u);
			num75 = teamRole45.MAX_ATTRIBUTE;
			int num879 = (int)double.Parse(Tools.Compute(text62.Replace(oldValue27, num75.ToString())));
			int num880;
			if (teamRole45.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2223184606u)] >= num879)
			{
				num2 = -1498167231;
				num880 = num2;
			}
			else
			{
				num2 = -1912352;
				num880 = num2;
			}
			continue;
			IL_4e0d:
			int num881;
			if (condition.type == global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1867383736u))
			{
				num2 = -1313379677;
				num881 = num2;
			}
			else
			{
				num2 = -1417466988;
				num881 = num2;
			}
			continue;
			IL_93de:
			int num882;
			if (!(condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1520637485u)))
			{
				num2 = -432058525;
				num882 = num2;
			}
			else
			{
				num2 = -1086617451;
				num882 = num2;
			}
			continue;
			IL_1e42:
			int num883;
			if (num143 >= num144)
			{
				num2 = -51972560;
				num883 = num2;
			}
			else
			{
				num2 = -1211514388;
				num883 = num2;
			}
			continue;
			IL_6cf8:
			int num884;
			if (!(condition.type == global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1520254590u)))
			{
				num2 = -1081699971;
				num884 = num2;
			}
			else
			{
				num2 = -1486998120;
				num884 = num2;
			}
			continue;
			IL_9337:
			int num885;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2207755824u)))
			{
				num2 = -320798486;
				num885 = num2;
			}
			else
			{
				num2 = -1431574677;
				num885 = num2;
			}
			continue;
			IL_1671:
			int num886;
			if (condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3342833277u))
			{
				num2 = -2117285742;
				num886 = num2;
			}
			else
			{
				num2 = -197061820;
				num886 = num2;
			}
			continue;
			IL_4c9b:
			int num887;
			if (teamRole48.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3535376985u)] < num220)
			{
				num2 = -977312488;
				num887 = num2;
			}
			else
			{
				num2 = -1191680532;
				num887 = num2;
			}
			continue;
			IL_9152:
			teamRole27 = RuntimeData.Instance.GetTeamRole(roleKey46);
			int num888;
			if (teamRole27 == null)
			{
				num2 = -518068855;
				num888 = num2;
			}
			else
			{
				num2 = -1310564179;
				num888 = num2;
			}
			continue;
			IL_6c97:
			int num889;
			if (!(condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(323350754u)))
			{
				num2 = -1961860447;
				num889 = num2;
			}
			else
			{
				num2 = -445646617;
				num889 = num2;
			}
			continue;
			IL_3914:
			num751 = Math.Max(condition.number, 1);
			goto IL_392b;
			IL_9105:
			int num890;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2724365288u)))
			{
				num2 = -2024746947;
				num890 = num2;
			}
			else
			{
				num2 = -584067905;
				num890 = num2;
			}
			continue;
			IL_392b:
			num114 = num751;
			int num891;
			if (array60.Length > 2)
			{
				num2 = -404307360;
				num891 = num2;
			}
			else
			{
				num2 = -1024926715;
				num891 = num2;
			}
			continue;
			IL_6c46:
			int num892;
			if (!(condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(841796004u)))
			{
				num2 = -133108805;
				num892 = num2;
			}
			else
			{
				num2 = -1926592688;
				num892 = num2;
			}
			continue;
			IL_90ac:
			int num893;
			if (condition.type == global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(215931630u))
			{
				num2 = -956313607;
				num893 = num2;
			}
			else
			{
				num2 = -939816273;
				num893 = num2;
			}
			continue;
			IL_4ba1:
			int num894;
			if (condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3104886982u))
			{
				num2 = -326466360;
				num894 = num2;
			}
			else
			{
				num2 = -534414984;
				num894 = num2;
			}
			continue;
			IL_3141:
			int num895;
			if (num75 >= array10.Length)
			{
				num2 = -639130472;
				num895 = num2;
			}
			else
			{
				num2 = -1185680592;
				num895 = num2;
			}
			continue;
			IL_8ffe:
			int num896;
			if (teamRole49.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(710450445u)] < num437)
			{
				num2 = -821491773;
				num896 = num2;
			}
			else
			{
				num2 = -408574878;
				num896 = num2;
			}
			continue;
			IL_6a56:
			teamRole52 = RuntimeData.Instance.GetTeamRole(roleKey32);
			int num897;
			if (teamRole52 == null)
			{
				num2 = -1644428447;
				num897 = num2;
			}
			else
			{
				num2 = -1252529735;
				num897 = num2;
			}
			continue;
			IL_2679:
			int num898;
			if (num452 >= 6)
			{
				num2 = -296241773;
				num898 = num2;
			}
			else
			{
				num2 = -51972560;
				num898 = num2;
			}
			continue;
			IL_8f95:
			int num899;
			if (!flag)
			{
				num2 = -1441195632;
				num899 = num2;
			}
			else
			{
				num2 = -1613516911;
				num899 = num2;
			}
			continue;
			IL_4b73:
			int num900;
			if (teamRole53.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1790491204u)] < num339)
			{
				num2 = -936807942;
				num900 = num2;
			}
			else
			{
				num2 = -588219298;
				num900 = num2;
			}
			continue;
			IL_6a28:
			int num901;
			if (teamRole54.Attributes[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2077292732u)] >= num444)
			{
				num2 = -1430474894;
				num901 = num2;
			}
			else
			{
				num2 = -943861979;
				num901 = num2;
			}
			continue;
			IL_8f58:
			roleKey50 = string.Empty;
			num395 = 0;
			int num902;
			if (array73.Length == 1)
			{
				num2 = -1852925181;
				num902 = num2;
			}
			else
			{
				num2 = -542818201;
				num902 = num2;
			}
			continue;
			IL_38d2:
			int num903;
			if (!_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3483067470u)))
			{
				num2 = -1420846248;
				num903 = num2;
			}
			else
			{
				num2 = -2118514304;
				num903 = num2;
			}
			continue;
			IL_1b2d:
			int num904;
			if (condition.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1645338772u))
			{
				num2 = -470302124;
				num904 = num2;
			}
			else
			{
				num2 = -1578467164;
				num904 = num2;
			}
			continue;
			IL_8f34:
			int num905;
			if (num356 < array20.Length)
			{
				num2 = -903311981;
				num905 = num2;
			}
			else
			{
				num2 = -2138888189;
				num905 = num2;
			}
			continue;
			IL_69fd:
			int num906;
			if (condition.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4198484663u))
			{
				num2 = -388942476;
				num906 = num2;
			}
			else
			{
				num2 = -1903697498;
				num906 = num2;
			}
			continue;
			IL_4af8:
			string text63 = text5.Replace(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(800863094u), RuntimeData.Instance.RoundString());
			string oldValue28 = global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3579531764u);
			num75 = teamRole58.MAX_LEVEL;
			int num907 = (int)double.Parse(Tools.Compute(text63.Replace(oldValue28, num75.ToString())));
			int num908;
			if (teamRole58.Level < num907)
			{
				num2 = -2138026452;
				num908 = num2;
			}
			else
			{
				num2 = -1680194964;
				num908 = num2;
			}
			continue;
			IL_8eb6:
			int num909;
			if (condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3174726870u))
			{
				num2 = -652917682;
				num909 = num2;
			}
			else
			{
				num2 = -1270671561;
				num909 = num2;
			}
			continue;
			IL_3018:
			int num910;
			if (condition.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2485202467u))
			{
				num2 = -200925981;
				num910 = num2;
			}
			else
			{
				num2 = -2060705402;
				num910 = num2;
			}
			continue;
			IL_69d2:
			int num911;
			if (condition.type == global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4252358952u))
			{
				num2 = -391038120;
				num911 = num2;
			}
			else
			{
				num2 = -2145706369;
				num911 = num2;
			}
			continue;
			IL_8e50:
			int num912;
			if (!(condition.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3904349729u)))
			{
				num2 = -1652185930;
				num912 = num2;
			}
			else
			{
				num2 = -2032197914;
				num912 = num2;
			}
			continue;
			IL_3848:
			int num913;
			if (num217 == 5)
			{
				num2 = -1417018615;
				num913 = num2;
			}
			else
			{
				num2 = -675910382;
				num913 = num2;
			}
			continue;
			IL_4a62:
			teamRole18 = RuntimeData.Instance.GetTeamRole(roleKey16);
			int num914;
			if (teamRole18 == null)
			{
				num2 = -1844272672;
				num914 = num2;
			}
			else
			{
				num2 = -585960449;
				num914 = num2;
			}
			continue;
			IL_8ccf:
			int num915;
			if (num507 < array23.Length)
			{
				num2 = -987722660;
				num915 = num2;
			}
			else
			{
				num2 = -48287820;
				num915 = num2;
			}
		}
		goto IL_008e;
	}

	public static void InitluaExtensionConditions()
	{
		if (luaExtensionConditions != null)
		{
			goto IL_000a;
		}
		goto IL_00c1;
		IL_000a:
		int num = 1864190571;
		goto IL_000f;
		IL_000f:
		string[] array = default(string[]);
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x4CD06256)) % 12)
			{
			case 0u:
				break;
			default:
				return;
			case 8u:
			{
				string item = array[num3];
				luaExtensionConditions.Add(item);
				num = 1518992497;
				continue;
			}
			case 1u:
				luaExtensionConditions = null;
				num = (int)(num2 * 1345387678) ^ -1089702177;
				continue;
			case 10u:
				array = LuaManager.Call<string[]>(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(193846707u), new object[0]);
				num3 = 0;
				num = ((int)num2 * -945265917) ^ -1261822798;
				continue;
			case 6u:
				luaExtensionConditions = null;
				num = ((int)num2 * -1480324216) ^ -1363945691;
				continue;
			case 3u:
				goto IL_00c1;
			case 4u:
			{
				int num4;
				int num5;
				if (luaExtensionConditions.Count != 0)
				{
					num4 = 1198249741;
					num5 = num4;
				}
				else
				{
					num4 = 1589044424;
					num5 = num4;
				}
				num = num4 ^ ((int)num2 * -907353365);
				continue;
			}
			case 2u:
				goto IL_0104;
			case 5u:
				luaExtensionConditions.Clear();
				num = ((int)num2 * -146465951) ^ -1429495578;
				continue;
			case 11u:
				num3++;
				num = (int)((num2 * 1679612799) ^ 0x6B9A9815);
				continue;
			case 9u:
				luaExtensionConditions = new List<string>();
				num = ((int)num2 * -843909532) ^ -694032568;
				continue;
			case 7u:
				return;
			}
			break;
			IL_0104:
			int num6;
			if (num3 < array.Length)
			{
				num = 2060186442;
				num6 = num;
			}
			else
			{
				num = 488206110;
				num6 = num;
			}
		}
		goto IL_000a;
		IL_00c1:
		int num7;
		if (luaExtensionConditions == null)
		{
			num = 818549731;
			num7 = num;
		}
		else
		{
			num = 2054362645;
			num7 = num;
		}
		goto IL_000f;
	}

	public static bool judgeBattle(Condition condition)
	{
		if (!_206C_200C_200D_206C_206D_206F_202E_200B_202A_206F_206C_206B_206F_200F_202D_206F_202D_202B_206D_200F_202B_200B_202A_206D_206A_206E_200D_206A_200C_202A_206D_206F_200E_200C_206A_206C_200F_200D_202C_202B_202E(condition.type))
		{
			string[] array = default(string[]);
			int number = default(int);
			string[] array3 = default(string[]);
			int num7 = default(int);
			string[] array2 = default(string[]);
			bool flag = default(bool);
			while (true)
			{
				int num = -525650913;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -826756279)) % 24)
					{
					case 5u:
						break;
					case 6u:
						goto IL_008b;
					case 20u:
						array = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.type, new char[1] { '|' });
						num = (int)((num2 * 1979964197) ^ 0x26BC1ADE);
						continue;
					case 0u:
						return true;
					case 15u:
						number = int.Parse(array3[num7]);
						num = ((int)num2 * -1167585166) ^ 0x18F94343;
						continue;
					case 11u:
						array2 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '|' });
						num = ((int)num2 * -1031603103) ^ 0x5681F1C6;
						continue;
					case 19u:
						flag = !judgeConditionBattle(new Condition
						{
							type = array[num7].Substring(1, array[num7].Length - 1),
							value = array2[num7],
							number = number
						});
						num = ((int)num2 * -588633500) ^ -1306108691;
						continue;
					case 23u:
						return false;
					case 10u:
						flag = judgeConditionBattle(new Condition
						{
							type = array[num7],
							value = array2[num7],
							number = number
						});
						num = -1717769247;
						continue;
					case 12u:
						goto IL_01cd;
					case 16u:
						goto IL_01f5;
					case 22u:
					{
						int num5;
						int num6;
						if (condition.value == null)
						{
							num5 = 712742755;
							num6 = num5;
						}
						else
						{
							num5 = 897220720;
							num6 = num5;
						}
						num = num5 ^ (int)(num2 * 345056888);
						continue;
					}
					case 9u:
						num7 = 0;
						num = (int)((num2 * 1753603821) ^ 0x57864EB2);
						continue;
					case 18u:
						num7++;
						num = -2015689137;
						continue;
					case 13u:
						flag = false;
						number = -1;
						num = -1763476911;
						continue;
					case 17u:
						goto IL_0265;
					case 1u:
						return !judgeConditionBattle(new Condition
						{
							type = condition.type.Substring(1, condition.type.Length - 1),
							value = condition.value,
							number = condition.number
						});
					case 2u:
						goto end_IL_0010;
					case 14u:
						goto IL_02f4;
					case 4u:
						array3 = condition.number.ToString().Split('|');
						num = ((int)num2 * -779974045) ^ 0x79B334E;
						continue;
					case 8u:
					{
						int num10;
						int num11;
						if (array3.Length < num7 + 1)
						{
							num10 = -525517523;
							num11 = num10;
						}
						else
						{
							num10 = -252244706;
							num11 = num10;
						}
						num = num10 ^ ((int)num2 * -1065408654);
						continue;
					}
					case 3u:
					{
						int num8;
						int num9;
						if (array.Length == array2.Length)
						{
							num8 = 1876258430;
							num9 = num8;
						}
						else
						{
							num8 = 2021921269;
							num9 = num8;
						}
						num = num8 ^ ((int)num2 * -1395491050);
						continue;
					}
					case 21u:
					{
						int num3;
						int num4;
						if (array.Length <= 1)
						{
							num3 = 1882815250;
							num4 = num3;
						}
						else
						{
							num3 = 988854157;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 1118828817);
						continue;
					}
					default:
						return judgeConditionBattle(condition);
					}
					break;
					IL_02f4:
					int num12;
					if (num7 < array.Length)
					{
						num = -1434832812;
						num12 = num;
					}
					else
					{
						num = -993680994;
						num12 = num;
					}
					continue;
					IL_008b:
					int num13;
					if (condition.type.StartsWith(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2651523886u)))
					{
						num = -1180490608;
						num13 = num;
					}
					else
					{
						num = -1152646754;
						num13 = num;
					}
					continue;
					IL_01f5:
					int num14;
					if (flag)
					{
						num = -146479415;
						num14 = num;
					}
					else
					{
						num = -1815692981;
						num14 = num;
					}
					continue;
					IL_0265:
					int num15;
					if (!_200F_200E_206B_202A_206B_200B_202E_206A_202D_202C_200B_206D_206F_202A_206A_206F_202D_202B_200E_200F_202A_202B_200D_202D_206A_206B_202C_202D_206A_202E_206C_206E_206D_202A_206F_200D_206D_202E_206D_206B_202E(condition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2876438784u)))
					{
						num = -1939751033;
						num15 = num;
					}
					else
					{
						num = -1574973371;
						num15 = num;
					}
					continue;
					IL_01cd:
					int num16;
					if (!array[num7].StartsWith(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(887725519u)))
					{
						num = -497043605;
						num16 = num;
					}
					else
					{
						num = -232504334;
						num16 = num;
					}
				}
				continue;
				end_IL_0010:
				break;
			}
		}
		return false;
	}

	internal static bool judgeConditionBattle(Condition condition)
	{
		if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1600121693u)))
		{
			goto IL_001a;
		}
		goto IL_13fb;
		IL_001a:
		int num = -1974256095;
		goto IL_001f;
		IL_001f:
		bool result2 = default(bool);
		int num85 = default(int);
		string[] array5 = default(string[]);
		string[] array3 = default(string[]);
		string roleKey4 = default(string);
		string[] array6 = default(string[]);
		Item item = default(Item);
		BattleSprite role7 = default(BattleSprite);
		string roleKey2 = default(string);
		int num42 = default(int);
		int num13 = default(int);
		string text2 = default(string);
		string[] array2 = default(string[]);
		int num10 = default(int);
		string[] array11 = default(string[]);
		int num5 = default(int);
		int num6 = default(int);
		int num68 = default(int);
		string[] array10 = default(string[]);
		BattleSprite role14 = default(BattleSprite);
		BattleSprite role10 = default(BattleSprite);
		BattleSprite role9 = default(BattleSprite);
		string[] array8 = default(string[]);
		string[] array14 = default(string[]);
		int num51 = default(int);
		BattleSprite role3 = default(BattleSprite);
		string[] array7 = default(string[]);
		string roleKey5 = default(string);
		BattleSprite role8 = default(BattleSprite);
		string[] array9 = default(string[]);
		Role role = default(Role);
		BattleSprite role2 = default(BattleSprite);
		string text = default(string);
		string roleKey3 = default(string);
		string[] array12 = default(string[]);
		int num139 = default(int);
		BattleSprite roleByName2 = default(BattleSprite);
		BattleSprite role15 = default(BattleSprite);
		bool result3 = default(bool);
		int num94 = default(int);
		BattleSprite role6 = default(BattleSprite);
		string[] array13 = default(string[]);
		Role role12 = default(Role);
		string[] array4 = default(string[]);
		BattleSprite role4 = default(BattleSprite);
		int num7 = default(int);
		BattleSprite role11 = default(BattleSprite);
		Role role16 = default(Role);
		bool result = default(bool);
		BattleSprite roleByName = default(BattleSprite);
		string[] array = default(string[]);
		BattleSprite role13 = default(BattleSprite);
		string roleKey = default(string);
		string text3 = default(string);
		Role role5 = default(Role);
		BattleSprite role17 = default(BattleSprite);
		bool result4 = default(bool);
		BattleSprite role18 = default(BattleSprite);
		while (true)
		{
			int num114;
			int num101;
			uint num2;
			switch ((num2 = (uint)(num ^ -322636350)) % 276)
			{
			case 125u:
				break;
			case 113u:
				return false;
			case 33u:
				return !_206C_200C_200D_206C_206D_206F_202E_200B_202A_206F_206C_206B_206F_200F_202D_206F_202D_202B_206D_200F_202B_200B_202A_206D_206A_206E_200D_206A_200C_202A_206D_206F_200E_200C_206A_206C_200F_200D_202C_202B_202E(RuntimeData.Instance.Menpai);
			case 274u:
				goto IL_04ba;
			case 156u:
				return true;
			case 142u:
				goto IL_04f3;
			case 103u:
				num = ((int)num2 * -1290398963) ^ -1909964597;
				continue;
			case 107u:
				result2 = true;
				num85 = 1;
				num = ((int)num2 * -1795008426) ^ -2054104989;
				continue;
			case 127u:
				return false;
			case 160u:
				if (condition.number > 0)
				{
					num = (int)(num2 * 1473005900) ^ -1157407790;
					continue;
				}
				num114 = int.Parse(array5[1]);
				goto IL_0ee3;
			case 260u:
				goto IL_0566;
			case 225u:
				return true;
			case 101u:
				array3 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
				num = ((int)num2 * -67404302) ^ -362422058;
				continue;
			case 205u:
				roleKey4 = array6[0];
				num = -1018456093;
				continue;
			case 65u:
			{
				int num56;
				int num57;
				if (item.type != 3)
				{
					num56 = 225539618;
					num57 = num56;
				}
				else
				{
					num56 = 1765728095;
					num57 = num56;
				}
				num = num56 ^ (int)(num2 * 1417787442);
				continue;
			}
			case 178u:
				goto IL_05f5;
			case 150u:
				role7 = AttackLogic.field.GetRole(roleKey2);
				num = -340043124;
				continue;
			case 169u:
				return false;
			case 257u:
				num42 = int.Parse(array6[0]);
				num = (int)(num2 * 1481468065) ^ -1078804579;
				continue;
			case 268u:
				num13 = 1;
				num = (int)((num2 * 289151830) ^ 0x21420BE6);
				continue;
			case 173u:
				text2 = array2[1];
				num10 = int.Parse(array2[2]);
				num = (int)(num2 * 1500854007) ^ -521255909;
				continue;
			case 64u:
				return true;
			case 189u:
				return true;
			case 58u:
				num = (int)(num2 * 542486062) ^ -298146842;
				continue;
			case 4u:
				goto IL_06ca;
			case 255u:
			{
				int num144;
				int num145;
				if (array11.Length <= 1)
				{
					num144 = 662168236;
					num145 = num144;
				}
				else
				{
					num144 = 1147164882;
					num145 = num144;
				}
				num = num144 ^ ((int)num2 * -2115669873);
				continue;
			}
			case 244u:
			{
				int num119;
				int num120;
				if (num5 < num6)
				{
					num119 = -1125922084;
					num120 = num119;
				}
				else
				{
					num119 = -475286326;
					num120 = num119;
				}
				num = num119 ^ ((int)num2 * -1242491674);
				continue;
			}
			case 123u:
				if (_206C_200C_200D_206C_206D_206F_202E_200B_202A_206F_206C_206B_206F_200F_202D_206F_202D_202B_206D_200F_202B_200B_202A_206D_206A_206E_200D_206A_200C_202A_206D_206F_200E_200C_206A_206C_200F_200D_202C_202B_202E(array5[2]))
				{
					num = ((int)num2 * -1692288327) ^ 0x1CB1D12F;
					continue;
				}
				num101 = int.Parse(array5[2]);
				goto IL_1948;
			case 210u:
			{
				int num69;
				int num70;
				if (_206A_206D_202E_200E_202E_202B_206F_202A_202C_206B_200D_202B_202A_206B_206A_202A_200E_202C_202E_206B_200D_202C_206F_202C_202A_206B_206F_202C_200D_206B_200E_206F_200B_200C_206D_200D_206B_202B_202E_202A_202E((Object)(object)role7, (Object)null))
				{
					num69 = 1388859232;
					num70 = num69;
				}
				else
				{
					num69 = 722215226;
					num70 = num69;
				}
				num = num69 ^ ((int)num2 * -2128360112);
				continue;
			}
			case 164u:
				roleKey2 = ResourceStrings.ResStrings[0];
				num68 = int.Parse(array10[0]);
				num = ((int)num2 * -258576514) ^ -1856209851;
				continue;
			case 22u:
				goto IL_07af;
			case 14u:
				roleKey4 = string.Empty;
				num42 = 0;
				num = -1067974988;
				continue;
			case 172u:
				goto IL_07dc;
			case 249u:
			{
				int num32;
				int num33;
				if (item.type != 1)
				{
					num32 = 1176847841;
					num33 = num32;
				}
				else
				{
					num32 = 830528386;
					num33 = num32;
				}
				num = num32 ^ ((int)num2 * -1061902519);
				continue;
			}
			case 270u:
			{
				int num16;
				int num17;
				if (item.type == 1)
				{
					num16 = -532075481;
					num17 = num16;
				}
				else
				{
					num16 = -2080186170;
					num17 = num16;
				}
				num = num16 ^ (int)(num2 * 940963409);
				continue;
			}
			case 192u:
				goto IL_0855;
			case 265u:
				goto IL_0880;
			case 5u:
			{
				int num158;
				int num159;
				if (!_206B_206F_206D_200B_206B_202D_200F_206F_200F_200D_202B_202D_206B_202E_202E_206F_202B_200B_206B_206F_202E_206C_206B_202E_200B_200D_206F_202C_202C_200D_206F_206A_206F_202C_200F_202D_206C_202C_202B_206B_202E((Object)(object)role14, (Object)null))
				{
					num158 = 777603787;
					num159 = num158;
				}
				else
				{
					num158 = 1290151570;
					num159 = num158;
				}
				num = num158 ^ ((int)num2 * -1218459906);
				continue;
			}
			case 34u:
			{
				int num142;
				int num143;
				if (array10.Length != 1)
				{
					num142 = 432568310;
					num143 = num142;
				}
				else
				{
					num142 = 1173754398;
					num143 = num142;
				}
				num = num142 ^ (int)(num2 * 4258870);
				continue;
			}
			case 52u:
				goto IL_08f6;
			case 104u:
			{
				int num133;
				int num134;
				if (_206A_206D_202E_200E_202E_202B_206F_202A_202C_206B_200D_202B_202A_206B_206A_202A_200E_202C_202E_206B_200D_202C_206F_202C_202A_206B_206F_202C_200D_206B_200E_206F_200B_200C_206D_200D_206B_202B_202E_202A_202E((Object)(object)role10, (Object)null))
				{
					num133 = -1491546683;
					num134 = num133;
				}
				else
				{
					num133 = -644860039;
					num134 = num133;
				}
				num = num133 ^ ((int)num2 * -1507073814);
				continue;
			}
			case 145u:
				return false;
			case 213u:
				return false;
			case 158u:
				goto IL_0969;
			case 154u:
				goto IL_0994;
			case 194u:
				role9 = AttackLogic.field.GetRole(array8[0]);
				num = -1519778887;
				continue;
			case 177u:
			{
				int num123;
				int num124;
				if (item.type == 2)
				{
					num123 = -765917603;
					num124 = num123;
				}
				else
				{
					num123 = -1248114453;
					num124 = num123;
				}
				num = num123 ^ ((int)num2 * -1237877504);
				continue;
			}
			case 83u:
				return AttackLogic.field.GetTeam1Count() >= int.Parse(condition.value);
			case 24u:
				goto IL_0a2e;
			case 170u:
				return false;
			case 8u:
				goto IL_0a65;
			case 61u:
				array14 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
				num51 = 0;
				num = (int)((num2 * 1452233756) ^ 0x66D4E247);
				continue;
			case 221u:
				goto IL_0ab5;
			case 254u:
			{
				int num90;
				int num91;
				if (role3.Mp < int.Parse(array7[1]))
				{
					num90 = -677450846;
					num91 = num90;
				}
				else
				{
					num90 = -1934194256;
					num91 = num90;
				}
				num = num90 ^ (int)(num2 * 1473909163);
				continue;
			}
			case 70u:
			{
				int num86;
				int num87;
				if (item.type != 4)
				{
					num86 = 1471197867;
					num87 = num86;
				}
				else
				{
					num86 = 401022827;
					num87 = num86;
				}
				num = num86 ^ ((int)num2 * -1701449655);
				continue;
			}
			case 59u:
				goto IL_0b36;
			case 261u:
				num42 = int.Parse(array6[1]);
				num = ((int)num2 * -197346505) ^ -1614900915;
				continue;
			case 17u:
				goto IL_0b78;
			case 2u:
				array7 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
				num = (int)(num2 * 2115728122) ^ -649818578;
				continue;
			case 149u:
				return false;
			case 167u:
				roleKey5 = array2[0];
				num = -1706471709;
				continue;
			case 94u:
			{
				int num60;
				int num61;
				if (item.type == 3)
				{
					num60 = 183296907;
					num61 = num60;
				}
				else
				{
					num60 = 578078532;
					num61 = num60;
				}
				num = num60 ^ ((int)num2 * -1195649400);
				continue;
			}
			case 98u:
				role8 = AttackLogic.field.GetRole(array9[0]);
				num = -1107091221;
				continue;
			case 105u:
				return RuntimeData.Instance.Round < int.Parse(condition.value);
			case 157u:
			{
				int num40;
				int num41;
				if (array5.Length < 1)
				{
					num40 = 1876131419;
					num41 = num40;
				}
				else
				{
					num40 = 130020572;
					num41 = num40;
				}
				num = num40 ^ ((int)num2 * -2101502625);
				continue;
			}
			case 77u:
				num13++;
				num = -2061794056;
				continue;
			case 224u:
			{
				int num30;
				int num31;
				if (item.type == 1)
				{
					num30 = -1633787627;
					num31 = num30;
				}
				else
				{
					num30 = -1943262977;
					num31 = num30;
				}
				num = num30 ^ (int)(num2 * 1976350391);
				continue;
			}
			case 174u:
				return false;
			case 258u:
				role = role2.Role;
				num = -630331544;
				continue;
			case 44u:
			{
				item = ResourceManager.Get<Item>(text);
				int num14;
				int num15;
				if (item != null)
				{
					num14 = -1624323670;
					num15 = num14;
				}
				else
				{
					num14 = -1067286902;
					num15 = num14;
				}
				num = num14 ^ (int)(num2 * 628398362);
				continue;
			}
			case 25u:
				roleKey3 = array12[0];
				num139 = int.Parse(array12[1]);
				num = -838852430;
				continue;
			case 47u:
				goto IL_0d1e;
			case 143u:
			{
				roleByName2 = AttackLogic.field.GetRoleByName(condition.value);
				int num154;
				int num155;
				if (!_206B_206F_206D_200B_206B_202D_200F_206F_200F_200D_202B_202D_206B_202E_202E_206F_202B_200B_206B_206F_202E_206C_206B_202E_200B_200D_206F_202C_202C_200D_206F_206A_206F_202C_200F_202D_206C_202C_202B_206B_202E((Object)(object)roleByName2, (Object)null))
				{
					num154 = -1616078775;
					num155 = num154;
				}
				else
				{
					num154 = -800100925;
					num155 = num154;
				}
				num = num154 ^ (int)(num2 * 1885462046);
				continue;
			}
			case 41u:
			{
				role15 = AttackLogic.field.GetRole(array11[0]);
				int num150;
				int num151;
				if (!_206B_206F_206D_200B_206B_202D_200F_206F_200F_200D_202B_202D_206B_202E_202E_206F_202B_200B_206B_206F_202E_206C_206B_202E_200B_200D_206F_202C_202C_200D_206F_206A_206F_202C_200F_202D_206C_202C_202B_206B_202E((Object)(object)role15, (Object)null))
				{
					num150 = -2117689280;
					num151 = num150;
				}
				else
				{
					num150 = -488830947;
					num151 = num150;
				}
				num = num150 ^ ((int)num2 * -968777867);
				continue;
			}
			case 165u:
				return true;
			case 54u:
				return false;
			case 147u:
				roleKey5 = string.Empty;
				text2 = string.Empty;
				num10 = 0;
				num = -509384538;
				continue;
			case 266u:
			{
				int num137;
				int num138;
				if (item.type != 2)
				{
					num137 = 1240535070;
					num138 = num137;
				}
				else
				{
					num137 = 1468904725;
					num138 = num137;
				}
				num = num137 ^ (int)(num2 * 442299603);
				continue;
			}
			case 99u:
			{
				int num131;
				int num132;
				if (item.type != 3)
				{
					num131 = -1043092221;
					num132 = num131;
				}
				else
				{
					num131 = -145703142;
					num132 = num131;
				}
				num = num131 ^ (int)(num2 * 748422641);
				continue;
			}
			case 102u:
			{
				int num127;
				int num128;
				if ((float)role15.Mp / (float)role15.MaxMp < float.Parse(array11[1]))
				{
					num127 = 1934999793;
					num128 = num127;
				}
				else
				{
					num127 = 1196262791;
					num128 = num127;
				}
				num = num127 ^ ((int)num2 * -1524835939);
				continue;
			}
			case 232u:
				result3 = true;
				num94 = 1;
				num = ((int)num2 * -335752507) ^ 0x125DB209;
				continue;
			case 85u:
			{
				int num117;
				int num118;
				if (!_206A_206D_202E_200E_202E_202B_206F_202A_202C_206B_200D_202B_202A_206B_206A_202A_200E_202C_202E_206B_200D_202C_206F_202C_202A_206B_206F_202C_200D_206B_200E_206F_200B_200C_206D_200D_206B_202B_202E_202A_202E((Object)(object)role8, (Object)null))
				{
					num117 = 90226670;
					num118 = num117;
				}
				else
				{
					num117 = 430611863;
					num118 = num117;
				}
				num = num117 ^ ((int)num2 * -1837871926);
				continue;
			}
			case 120u:
				return true;
			case 200u:
				return false;
			case 48u:
				num114 = _202E_206F_202E_200F_206A_206D_200D_206D_206B_206C_206E_202B_200E_206B_202C_206C_202D_200E_202B_206A_200F_206A_206A_200E_200C_202E_202A_206D_206C_206C_206B_200F_206F_206C_202E_206C_200B_200D_206E_206F_202E(condition.number, 1);
				goto IL_0ee3;
			case 75u:
				return _202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(AttackLogic.field.currentSprite.Role.Key, condition.value);
			case 240u:
				goto IL_0f22;
			case 133u:
				role6 = AttackLogic.field.GetRole(array13[0]);
				num = ((int)num2 * -1221476823) ^ 0x1B006823;
				continue;
			case 183u:
			{
				int num108;
				int num109;
				if (array12.Length != 1)
				{
					num108 = -576150318;
					num109 = num108;
				}
				else
				{
					num108 = -1409004120;
					num109 = num108;
				}
				num = num108 ^ ((int)num2 * -1681827521);
				continue;
			}
			case 87u:
				array12 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
				num = (int)(num2 * 1494226804) ^ -946324302;
				continue;
			case 49u:
				return false;
			case 263u:
				return true;
			case 0u:
			{
				int num102;
				int num103;
				if (!_206B_206F_206D_200B_206B_202D_200F_206F_200F_200D_202B_202D_206B_202E_202E_206F_202B_200B_206B_206F_202E_206C_206B_202E_200B_200D_206F_202C_202C_200D_206F_206A_206F_202C_200F_202D_206C_202C_202B_206B_202E((Object)(object)AttackLogic.field.currentSprite, (Object)null))
				{
					num102 = 2127822810;
					num103 = num102;
				}
				else
				{
					num102 = 1184742197;
					num103 = num102;
				}
				num = num102 ^ ((int)num2 * -938836220);
				continue;
			}
			case 211u:
				return false;
			case 241u:
				goto IL_101b;
			case 68u:
				goto IL_103c;
			case 90u:
				role12 = role8.Role;
				num = -2053267623;
				continue;
			case 182u:
				num = (int)((num2 * 1550636812) ^ 0x5669DD52);
				continue;
			case 251u:
				num85++;
				num = -1013357480;
				continue;
			case 20u:
				roleKey2 = array10[0];
				num68 = int.Parse(array10[1]);
				num = -1764834268;
				continue;
			case 193u:
			{
				int num92;
				int num93;
				if (num5 != 0)
				{
					num92 = -78411551;
					num93 = num92;
				}
				else
				{
					num92 = -1908337454;
					num93 = num92;
				}
				num = num92 ^ ((int)num2 * -1543493268);
				continue;
			}
			case 110u:
			{
				int num81;
				int num82;
				if (item.type == 1)
				{
					num81 = -203952859;
					num82 = num81;
				}
				else
				{
					num81 = -1217571578;
					num82 = num81;
				}
				num = num81 ^ ((int)num2 * -1235788935);
				continue;
			}
			case 198u:
				role2 = AttackLogic.field.GetRole(roleKey5);
				num = -1060762330;
				continue;
			case 141u:
				return false;
			case 250u:
				result3 = false;
				num = ((int)num2 * -1530894844) ^ 0x35FDAD25;
				continue;
			case 273u:
				goto IL_1143;
			case 79u:
				return true;
			case 12u:
				goto IL_1172;
			case 269u:
			{
				array6 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
				int num75;
				int num76;
				if (array6.Length >= 1)
				{
					num75 = 1436819420;
					num76 = num75;
				}
				else
				{
					num75 = 2106072515;
					num76 = num75;
				}
				num = num75 ^ ((int)num2 * -561628444);
				continue;
			}
			case 175u:
				return false;
			case 112u:
				goto IL_11f6;
			case 30u:
				return false;
			case 130u:
				return false;
			case 235u:
			{
				int num64;
				int num65;
				if (_206A_206D_202E_200E_202E_202B_206F_202A_202C_206B_200D_202B_202A_206B_206A_202A_200E_202C_202E_206B_200D_202C_206F_202C_202A_206B_206F_202C_200D_206B_200E_206F_200B_200C_206D_200D_206B_202B_202E_202A_202E((Object)(object)role9, (Object)null))
				{
					num64 = -1368263334;
					num65 = num64;
				}
				else
				{
					num64 = -1547205297;
					num65 = num64;
				}
				num = num64 ^ (int)(num2 * 387454562);
				continue;
			}
			case 122u:
				return false;
			case 78u:
				return RuntimeData.Instance.Daode >= int.Parse(condition.value);
			case 252u:
			{
				int num54;
				int num55;
				if (array7.Length <= 1)
				{
					num54 = 151819498;
					num55 = num54;
				}
				else
				{
					num54 = 1317058915;
					num55 = num54;
				}
				num = num54 ^ ((int)num2 * -1432934542);
				continue;
			}
			case 117u:
				goto IL_12bf;
			case 73u:
				return true;
			case 84u:
				goto IL_12ff;
			case 86u:
			{
				int num49;
				int num50;
				if (array6.Length != 1)
				{
					num49 = 861989403;
					num50 = num49;
				}
				else
				{
					num49 = 2051203109;
					num50 = num49;
				}
				num = num49 ^ (int)(num2 * 867519710);
				continue;
			}
			case 195u:
				return result3;
			case 222u:
				goto IL_135b;
			case 264u:
				goto IL_1386;
			case 237u:
				item = ResourceManager.Get<Item>(text);
				num = ((int)num2 * -796220447) ^ -1014919988;
				continue;
			case 131u:
				return AttackLogic.field.GetTeam2Count() >= int.Parse(condition.value);
			case 109u:
				goto IL_13fb;
			case 121u:
				role3 = AttackLogic.field.GetRole(array7[0]);
				num = ((int)num2 * -1575103269) ^ -322375603;
				continue;
			case 3u:
				return RuntimeData.Instance.Round >= int.Parse(condition.value);
			case 62u:
				return false;
			case 39u:
			{
				array4 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
				int num36;
				int num37;
				if (array4.Length == 0)
				{
					num36 = -1543678581;
					num37 = num36;
				}
				else
				{
					num36 = -706634499;
					num37 = num36;
				}
				num = num36 ^ (int)(num2 * 538164695);
				continue;
			}
			case 60u:
				role4 = AttackLogic.field.GetRole(array3[0]);
				num = -2056105157;
				continue;
			case 214u:
				return false;
			case 74u:
				return result2;
			case 179u:
			{
				int num26;
				int num27;
				if (item.type != 12)
				{
					num26 = -1776431354;
					num27 = num26;
				}
				else
				{
					num26 = -1302589892;
					num27 = num26;
				}
				num = num26 ^ (int)(num2 * 723686719);
				continue;
			}
			case 209u:
				return ModData.Nicks.Contains(condition.value);
			case 16u:
				return false;
			case 180u:
				num5 += RuntimeData.Instance.GetXiangziCount(text);
				num = (int)((num2 * 2057283231) ^ 0x17CCB6B6);
				continue;
			case 31u:
			{
				int num20;
				int num21;
				if (!_206B_200C_200D_202B_202D_200E_202E_206D_200E_200F_202C_200C_202A_200F_200C_206D_202B_206E_202D_202D_200C_200D_202E_200B_206E_202B_206E_200B_206F_206D_200F_200F_202C_202B_202C_202D_200F_202E_202E_200C_202E(RuntimeData.Instance.Menpai, condition.value))
				{
					num20 = -982932499;
					num21 = num20;
				}
				else
				{
					num20 = -587956838;
					num21 = num20;
				}
				num = num20 ^ ((int)num2 * -114605606);
				continue;
			}
			case 128u:
				goto IL_15b2;
			case 229u:
			{
				num5 = 0;
				int num8;
				int num9;
				if (num7 <= 0)
				{
					num8 = -464367614;
					num9 = num8;
				}
				else
				{
					num8 = -759954203;
					num9 = num8;
				}
				num = num8 ^ ((int)num2 * -1343210255);
				continue;
			}
			case 29u:
				num5 = RuntimeData.Instance.GetRolesEquipment(text, num6);
				num = -473325286;
				continue;
			case 186u:
				return false;
			case 42u:
				num139 = int.Parse(array12[0]);
				num = ((int)num2 * -433105145) ^ -1529500518;
				continue;
			case 46u:
			{
				int num156;
				int num157;
				if (role11.Team != 1)
				{
					num156 = -647708417;
					num157 = num156;
				}
				else
				{
					num156 = -2002272881;
					num157 = num156;
				}
				num = num156 ^ (int)(num2 * 928510150);
				continue;
			}
			case 259u:
				goto IL_166f;
			case 53u:
				goto IL_169a;
			case 253u:
				roleKey2 = string.Empty;
				num68 = 0;
				num = -2089229820;
				continue;
			case 190u:
			{
				int num152;
				int num153;
				if (array5.Length <= 2)
				{
					num152 = 1202323870;
					num153 = num152;
				}
				else
				{
					num152 = 214897899;
					num153 = num152;
				}
				num = num152 ^ (int)(num2 * 696887401);
				continue;
			}
			case 69u:
				return true;
			case 27u:
			{
				int num148;
				int num149;
				if (item.type == 4)
				{
					num148 = 2128360866;
					num149 = num148;
				}
				else
				{
					num148 = 116550879;
					num149 = num148;
				}
				num = num148 ^ ((int)num2 * -1108489433);
				continue;
			}
			case 81u:
			{
				int num146;
				int num147;
				if (item.type == 12)
				{
					num146 = -1936723714;
					num147 = num146;
				}
				else
				{
					num146 = -2132852691;
					num147 = num146;
				}
				num = num146 ^ (int)(num2 * 1131624099);
				continue;
			}
			case 118u:
				return true;
			case 45u:
			{
				int num140;
				int num141;
				if (_206A_206D_202E_200E_202E_202B_206F_202A_202C_206B_200D_202B_202A_206B_206A_202A_200E_202C_202E_206B_200D_202C_206F_202C_202A_206B_206F_202C_200D_206B_200E_206F_200B_200C_206D_200D_206B_202B_202E_202A_202E((Object)(object)role4, (Object)null))
				{
					num140 = -1111429791;
					num141 = num140;
				}
				else
				{
					num140 = -642812708;
					num141 = num140;
				}
				num = num140 ^ ((int)num2 * -1186623780);
				continue;
			}
			case 243u:
				return true;
			case 37u:
				result2 = false;
				num = ((int)num2 * -51946012) ^ 0x6B78A1DD;
				continue;
			case 153u:
				num139 = 0;
				num = (int)(num2 * 389989551) ^ -1825166778;
				continue;
			case 63u:
				return false;
			case 228u:
			{
				item = ResourceManager.Get<Item>(text);
				int num135;
				int num136;
				if (item != null)
				{
					num135 = 1007156607;
					num136 = num135;
				}
				else
				{
					num135 = 364734390;
					num136 = num135;
				}
				num = num135 ^ ((int)num2 * -898324309);
				continue;
			}
			case 96u:
				goto IL_180b;
			case 55u:
				role16 = role9.Role;
				result = true;
				num = -1495469458;
				continue;
			case 108u:
			{
				int num129;
				int num130;
				if (_206A_206D_202E_200E_202E_202B_206F_202A_202C_206B_200D_202B_202A_206B_206A_202A_200E_202C_202E_206B_200D_202C_206F_202C_202A_206B_206F_202C_200D_206B_200E_206F_200B_200C_206D_200D_206B_202B_202E_202A_202E((Object)(object)role2, (Object)null))
				{
					num129 = 2065017703;
					num130 = num129;
				}
				else
				{
					num129 = 2054106788;
					num130 = num129;
				}
				num = num129 ^ (int)(num2 * 545518110);
				continue;
			}
			case 248u:
				return false;
			case 203u:
				goto IL_187f;
			case 18u:
			{
				int num125;
				int num126;
				if (item.type != 4)
				{
					num125 = -541585007;
					num126 = num125;
				}
				else
				{
					num125 = -1060165617;
					num126 = num125;
				}
				num = num125 ^ (int)(num2 * 1721961785);
				continue;
			}
			case 139u:
				goto IL_18da;
			case 148u:
				goto IL_18fc;
			case 155u:
			{
				int num121;
				int num122;
				if (roleByName.Team == 1)
				{
					num121 = -1857288258;
					num122 = num121;
				}
				else
				{
					num121 = -52486749;
					num122 = num121;
				}
				num = num121 ^ (int)(num2 * 279025940);
				continue;
			}
			case 166u:
				num101 = 0;
				goto IL_1948;
			case 242u:
				role14 = AttackLogic.field.GetRole(array[0]);
				num = (int)(num2 * 850925146) ^ -426953549;
				continue;
			case 93u:
				num = (int)(num2 * 452149754) ^ -1370186729;
				continue;
			case 126u:
				goto IL_198d;
			case 15u:
				num5 += RuntimeData.Instance.GetItemsCount(text);
				num = ((int)num2 * -1828344142) ^ 0x7585C14C;
				continue;
			case 7u:
				roleKey4 = ResourceStrings.ResStrings[0];
				num = ((int)num2 * -944334108) ^ -1413897657;
				continue;
			case 176u:
				return false;
			case 226u:
			{
				item = ResourceManager.Get<Item>(text);
				int num115;
				int num116;
				if (item == null)
				{
					num115 = -1483114532;
					num116 = num115;
				}
				else
				{
					num115 = -1892992042;
					num116 = num115;
				}
				num = num115 ^ (int)(num2 * 769574459);
				continue;
			}
			case 38u:
				goto IL_1a32;
			case 114u:
				goto IL_1a5d;
			case 135u:
				result = false;
				num = (int)((num2 * 97943421) ^ 0x737414DC);
				continue;
			case 230u:
			{
				int num112;
				int num113;
				if ((float)role14.Hp / (float)role14.MaxHp < float.Parse(array[1]))
				{
					num112 = 617819751;
					num113 = num112;
				}
				else
				{
					num112 = 902844135;
					num113 = num112;
				}
				num = num112 ^ ((int)num2 * -43000001);
				continue;
			}
			case 88u:
			{
				int num110;
				int num111;
				if (item.type != 12)
				{
					num110 = 382060486;
					num111 = num110;
				}
				else
				{
					num110 = 1292868419;
					num111 = num110;
				}
				num = num110 ^ ((int)num2 * -1101997359);
				continue;
			}
			case 91u:
				num = ((int)num2 * -1285841078) ^ -1230121242;
				continue;
			case 19u:
				roleKey3 = ResourceStrings.ResStrings[0];
				num = (int)(num2 * 940457361) ^ -1403090377;
				continue;
			case 28u:
			{
				array9 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
				int num106;
				int num107;
				if (array9.Length > 1)
				{
					num106 = -1970208380;
					num107 = num106;
				}
				else
				{
					num106 = -1174858240;
					num107 = num106;
				}
				num = num106 ^ ((int)num2 * -325498417);
				continue;
			}
			case 217u:
			{
				role13 = AttackLogic.field.GetRole(condition.value);
				int num104;
				int num105;
				if (!_206B_206F_206D_200B_206B_202D_200F_206F_200F_200D_202B_202D_206B_202E_202E_206F_202B_200B_206B_206F_202E_206C_206B_202E_200B_200D_206F_202C_202C_200D_206F_206A_206F_202C_200F_202D_206C_202C_202B_206B_202E((Object)(object)role13, (Object)null))
				{
					num104 = -1693917159;
					num105 = num104;
				}
				else
				{
					num104 = -1964729270;
					num105 = num104;
				}
				num = num104 ^ (int)(num2 * 963704056);
				continue;
			}
			case 218u:
				return false;
			case 72u:
			{
				int num99;
				int num100;
				if (role13.Team == 2)
				{
					num99 = -613597931;
					num100 = num99;
				}
				else
				{
					num99 = -1494004607;
					num100 = num99;
				}
				num = num99 ^ (int)(num2 * 243688934);
				continue;
			}
			case 196u:
				return _206B_206F_206D_200B_206B_202D_200F_206F_200F_200D_202B_202D_206B_202E_202E_206F_202B_200B_206B_206F_202E_206C_206B_202E_200B_200D_206F_202C_202C_200D_206F_206A_206F_202C_200F_202D_206C_202C_202B_206B_202E((Object)(object)AttackLogic.field.GetRole(condition.value), (Object)null);
			case 181u:
				return AttackLogic.field.BattleTimestamp >= int.Parse(condition.value);
			case 216u:
				goto IL_1c38;
			case 223u:
			{
				int num97;
				int num98;
				if (role6.Hp < int.Parse(array13[1]))
				{
					num97 = 2027581239;
					num98 = num97;
				}
				else
				{
					num97 = 348821719;
					num98 = num97;
				}
				num = num97 ^ ((int)num2 * -1356056301);
				continue;
			}
			case 32u:
				num5 = RuntimeData.Instance.GetXiangziCount(text);
				num = ((int)num2 * -1192214630) ^ -231858318;
				continue;
			case 10u:
			{
				array13 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
				int num95;
				int num96;
				if (array13.Length > 1)
				{
					num95 = 321143063;
					num96 = num95;
				}
				else
				{
					num95 = 1074098306;
					num96 = num95;
				}
				num = num95 ^ (int)(num2 * 988636954);
				continue;
			}
			case 220u:
				goto IL_1cdd;
			case 207u:
				goto IL_1d08;
			case 161u:
				array = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
				num = (int)(num2 * 1926087839) ^ -2136507397;
				continue;
			case 247u:
				goto IL_1d66;
			case 275u:
				num94++;
				num = -961622720;
				continue;
			case 51u:
				roleKey5 = ResourceStrings.ResStrings[0];
				text2 = array2[0];
				num10 = int.Parse(array2[1]);
				num = ((int)num2 * -1681178206) ^ 0x4E473B82;
				continue;
			case 151u:
			{
				role11 = AttackLogic.field.GetRole(condition.value);
				int num88;
				int num89;
				if (!_206B_206F_206D_200B_206B_202D_200F_206F_200F_200D_202B_202D_206B_202E_202E_206F_202B_200B_206B_206F_202E_206C_206B_202E_200B_200D_206F_202C_202C_200D_206F_206A_206F_202C_200F_202D_206C_202C_202B_206B_202E((Object)(object)role11, (Object)null))
				{
					num88 = -481934816;
					num89 = num88;
				}
				else
				{
					num88 = -1338435377;
					num89 = num88;
				}
				num = num88 ^ ((int)num2 * -1683476539);
				continue;
			}
			case 57u:
				goto IL_1e09;
			case 129u:
				num5 = RuntimeData.Instance.GetItemsCount(text);
				num = (int)(num2 * 2133064365) ^ -1727460006;
				continue;
			case 134u:
				return true;
			case 187u:
				goto IL_1e58;
			case 1u:
				roleKey = array4[0];
				text3 = array4[1];
				num = ((int)num2 * -1443776184) ^ 0x16B0C642;
				continue;
			case 272u:
				return true;
			case 43u:
			{
				array10 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
				int num83;
				int num84;
				if (array10.Length >= 1)
				{
					num83 = -1180171519;
					num84 = num83;
				}
				else
				{
					num83 = -1644673825;
					num84 = num83;
				}
				num = num83 ^ ((int)num2 * -841139922);
				continue;
			}
			case 171u:
				goto IL_1ef3;
			case 144u:
				goto IL_1f1e;
			case 256u:
			{
				int num79;
				int num80;
				if (array12.Length >= 1)
				{
					num79 = -1020144320;
					num80 = num79;
				}
				else
				{
					num79 = -673297275;
					num80 = num79;
				}
				num = num79 ^ ((int)num2 * -326333342);
				continue;
			}
			case 106u:
			{
				int num77;
				int num78;
				if (item.type == 3)
				{
					num77 = 1745902043;
					num78 = num77;
				}
				else
				{
					num77 = 415856461;
					num78 = num77;
				}
				num = num77 ^ (int)(num2 * 2129896786);
				continue;
			}
			case 67u:
				array5 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
				num = (int)((num2 * 867401749) ^ 0x23146298);
				continue;
			case 246u:
				array11 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
				num = (int)(num2 * 2033914832) ^ -385545871;
				continue;
			case 138u:
				goto IL_1feb;
			case 137u:
				num5 = RuntimeData.Instance.GetRolesEquipment(text, num6);
				num = -8364322;
				continue;
			case 140u:
				role10 = AttackLogic.field.GetRole(roleKey4);
				num = -1873117574;
				continue;
			case 95u:
				return false;
			case 124u:
			{
				int num73;
				int num74;
				if (array2.Length != 2)
				{
					num73 = -496787823;
					num74 = num73;
				}
				else
				{
					num73 = -1641197891;
					num74 = num73;
				}
				num = num73 ^ ((int)num2 * -1980822926);
				continue;
			}
			case 184u:
				goto IL_2081;
			case 146u:
			{
				int num71;
				int num72;
				if (item.type != 2)
				{
					num71 = 222477998;
					num72 = num71;
				}
				else
				{
					num71 = 1420999213;
					num72 = num71;
				}
				num = num71 ^ ((int)num2 * -1403947113);
				continue;
			}
			case 227u:
				num5 = RuntimeData.Instance.GetRolesEquipment(text, num6);
				num = -1442670706;
				continue;
			case 152u:
			{
				int num66;
				int num67;
				if (Tools.ProbabilityTest(double.Parse(condition.value) / 100.0))
				{
					num66 = 1725390723;
					num67 = num66;
				}
				else
				{
					num66 = 961134824;
					num67 = num66;
				}
				num = num66 ^ ((int)num2 * -767294195);
				continue;
			}
			case 80u:
				num = (int)(num2 * 985364993) ^ -1135721196;
				continue;
			case 236u:
			{
				array2 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
				int num62;
				int num63;
				if (array2.Length < 2)
				{
					num62 = -1594490380;
					num63 = num62;
				}
				else
				{
					num62 = -409910799;
					num63 = num62;
				}
				num = num62 ^ ((int)num2 * -1977381663);
				continue;
			}
			case 208u:
				goto IL_2175;
			case 35u:
			{
				int num58;
				int num59;
				if (item == null)
				{
					num58 = 1016011877;
					num59 = num58;
				}
				else
				{
					num58 = 1216867419;
					num59 = num58;
				}
				num = num58 ^ (int)(num2 * 603778993);
				continue;
			}
			case 76u:
				num5 += RuntimeData.Instance.GetItemsCount(text);
				num = ((int)num2 * -1627881634) ^ 0x2FC22D82;
				continue;
			case 159u:
				return false;
			case 50u:
			{
				int num52;
				int num53;
				if (array3.Length > 1)
				{
					num52 = 202579178;
					num53 = num52;
				}
				else
				{
					num52 = 1399742493;
					num53 = num52;
				}
				num = num52 ^ ((int)num2 * -590280230);
				continue;
			}
			case 202u:
				goto IL_220d;
			case 206u:
				roleKey3 = string.Empty;
				num = -180171125;
				continue;
			case 197u:
				num51++;
				num = -155176035;
				continue;
			case 204u:
			{
				int num47;
				int num48;
				if (!_206B_206F_206D_200B_206B_202D_200F_206F_200F_200D_202B_202D_206B_202E_202E_206F_202B_200B_206B_206F_202E_206C_206B_202E_200B_200D_206F_202C_202C_200D_206F_206A_206F_202C_200F_202D_206C_202C_202B_206B_202E((Object)(object)role6, (Object)null))
				{
					num47 = -940224098;
					num48 = num47;
				}
				else
				{
					num47 = -174431887;
					num48 = num47;
				}
				num = num47 ^ ((int)num2 * -695177404);
				continue;
			}
			case 238u:
				num5 += RuntimeData.Instance.GetXiangziCount(text);
				num = (int)((num2 * 191887543) ^ 0x2FF28858);
				continue;
			case 56u:
			{
				array8 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
				int num45;
				int num46;
				if (array8.Length <= 1)
				{
					num45 = 1856614804;
					num46 = num45;
				}
				else
				{
					num45 = 1671922180;
					num46 = num45;
				}
				num = num45 ^ ((int)num2 * -907388373);
				continue;
			}
			case 245u:
				goto IL_22d1;
			case 21u:
				goto IL_22fc;
			case 188u:
				return false;
			case 13u:
				num5 = RuntimeData.Instance.GetItemsCount(text);
				num = (int)((num2 * 471753493) ^ 0x31B0F577);
				continue;
			case 231u:
			{
				int num43;
				int num44;
				if (roleByName2.Team == 2)
				{
					num43 = 275269908;
					num44 = num43;
				}
				else
				{
					num43 = 1624235060;
					num44 = num43;
				}
				num = num43 ^ ((int)num2 * -201444795);
				continue;
			}
			case 26u:
				role5 = role4.Role;
				num = -1066626314;
				continue;
			case 119u:
				return _206B_206F_206D_200B_206B_202D_200F_206F_200F_200D_202B_202D_206B_202E_202E_206F_202B_200B_206B_206F_202E_206C_206B_202E_200B_200D_206F_202C_202C_200D_206F_206A_206F_202C_200F_202D_206C_202C_202B_206B_202E((Object)(object)AttackLogic.field.GetRoleByName(condition.value), (Object)null);
			case 267u:
				num = (int)((num2 * 383049598) ^ 0x258AC3A2);
				continue;
			case 201u:
				num = (int)((num2 * 68953142) ^ 0x105489C);
				continue;
			case 116u:
				roleKey = ResourceStrings.ResStrings[0];
				text3 = array4[0];
				num = -1606369718;
				continue;
			case 132u:
			{
				int num38;
				int num39;
				if (!_206B_206F_206D_200B_206B_202D_200F_206F_200F_200D_202B_202D_206B_202E_202E_206F_202B_200B_206B_206F_202E_206C_206B_202E_200B_200D_206F_202C_202C_200D_206F_206A_206F_202C_200F_202D_206C_202C_202B_206B_202E((Object)(object)roleByName, (Object)null))
				{
					num38 = -395549209;
					num39 = num38;
				}
				else
				{
					num38 = -1268822279;
					num39 = num38;
				}
				num = num38 ^ (int)(num2 * 1999173403);
				continue;
			}
			case 89u:
				return false;
			case 271u:
				return _202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(AttackLogic.field.currentSprite.Role.Name, condition.value);
			case 92u:
				goto IL_245f;
			case 100u:
			{
				int num34;
				int num35;
				if (_206B_206F_206D_200B_206B_202D_200F_206F_200F_200D_202B_202D_206B_202E_202E_206F_202B_200B_206B_206F_202E_206C_206B_202E_200B_200D_206F_202C_202C_200D_206F_206A_206F_202C_200F_202D_206C_202C_202B_206B_202E((Object)(object)role3, (Object)null))
				{
					num34 = 235731820;
					num35 = num34;
				}
				else
				{
					num34 = 72393802;
					num35 = num34;
				}
				num = num34 ^ ((int)num2 * -2006972652);
				continue;
			}
			case 111u:
				return false;
			case 36u:
			{
				int num28;
				int num29;
				if (item.type == 12)
				{
					num28 = -429313137;
					num29 = num28;
				}
				else
				{
					num28 = -2064376078;
					num29 = num28;
				}
				num = num28 ^ (int)(num2 * 1573471687);
				continue;
			}
			case 233u:
			{
				int num24;
				int num25;
				if (!_206B_206F_206D_200B_206B_202D_200F_206F_200F_200D_202B_202D_206B_202E_202E_206F_202B_200B_206B_206F_202E_206C_206B_202E_200B_200D_206F_202C_202C_200D_206F_206A_206F_202C_200F_202D_206C_202C_202B_206B_202E((Object)(object)AttackLogic.field.currentSprite, (Object)null))
				{
					num24 = 1582505037;
					num25 = num24;
				}
				else
				{
					num24 = 273056791;
					num25 = num24;
				}
				num = num24 ^ (int)(num2 * 451807558);
				continue;
			}
			case 185u:
				goto IL_2514;
			case 191u:
				return false;
			case 71u:
				num5 = RuntimeData.Instance.GetRolesEquipment(text, num6);
				num = -199959077;
				continue;
			case 9u:
				return result;
			case 66u:
			{
				int num22;
				int num23;
				if (item.type == 2)
				{
					num22 = -1893615971;
					num23 = num22;
				}
				else
				{
					num22 = -490982635;
					num23 = num22;
				}
				num = num22 ^ (int)(num2 * 1966004990);
				continue;
			}
			case 168u:
				return true;
			case 136u:
				num5 += RuntimeData.Instance.GetXiangziCount(text);
				num = ((int)num2 * -1909896882) ^ 0x601F5182;
				continue;
			case 219u:
				goto IL_25c9;
			case 234u:
				return false;
			case 97u:
				return false;
			case 215u:
				roleByName = AttackLogic.field.GetRoleByName(condition.value);
				num = ((int)num2 * -2019843248) ^ 0x5667119A;
				continue;
			case 162u:
			{
				int num18;
				int num19;
				if (array.Length > 1)
				{
					num18 = 1011903644;
					num19 = num18;
				}
				else
				{
					num18 = 1586653093;
					num19 = num18;
				}
				num = num18 ^ (int)(num2 * 639895244);
				continue;
			}
			case 115u:
				return AttackLogic.field.GetTeam1Count() + AttackLogic.field.GetTeam2Count() >= int.Parse(condition.value);
			case 23u:
				return false;
			case 239u:
				goto IL_26a2;
			case 262u:
				goto IL_26cd;
			case 6u:
			{
				int num11;
				int num12;
				if (role.GetSkillLevel(text2) < num10)
				{
					num11 = -538214736;
					num12 = num11;
				}
				else
				{
					num11 = -1163376436;
					num12 = num11;
				}
				num = num11 ^ ((int)num2 * -1494423939);
				continue;
			}
			case 82u:
			{
				int num3;
				int num4;
				if (item.type == 4)
				{
					num3 = -591003367;
					num4 = num3;
				}
				else
				{
					num3 = -149755112;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1476596253);
				continue;
			}
			case 199u:
				num = ((int)num2 * -131269573) ^ -2075207127;
				continue;
			case 163u:
				return true;
			case 40u:
				goto IL_2758;
			case 11u:
				return true;
			default:
				goto IL_2787;
				IL_1948:
				num7 = num101;
				item = null;
				num = -1568922793;
				continue;
				IL_0ee3:
				num6 = num114;
				num = -105535328;
				continue;
			}
			break;
			IL_2787:
			using (List<ItemInstance>.Enumerator enumerator = role17.Role.Equipment.GetEnumerator())
			{
				while (true)
				{
					IL_27f1:
					int num160;
					int num161;
					if (enumerator.MoveNext())
					{
						num160 = -929781819;
						num161 = num160;
					}
					else
					{
						num160 = -1095991862;
						num161 = num160;
					}
					while (true)
					{
						switch ((num2 = (uint)(num160 ^ -322636350)) % 6)
						{
						case 3u:
							num160 = -929781819;
							continue;
						default:
							goto end_IL_27a1;
						case 1u:
						{
							int num162;
							if (!_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(enumerator.Current.Name, text3))
							{
								num160 = -263436386;
								num162 = num160;
							}
							else
							{
								num160 = -557762798;
								num162 = num160;
							}
							continue;
						}
						case 2u:
							break;
						case 4u:
							result4 = true;
							num160 = (int)((num2 * 609999673) ^ 0x31559E57);
							continue;
						case 0u:
							goto end_IL_27a1;
						case 5u:
							goto IL_3393;
						}
						goto IL_27f1;
						continue;
						end_IL_27a1:
						break;
					}
					break;
				}
			}
			goto IL_2846;
			IL_2758:
			int num163;
			if (num5 >= num6)
			{
				num = -473325286;
				num163 = num;
			}
			else
			{
				num = -595909919;
				num163 = num;
			}
			continue;
			IL_0b78:
			int num164;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2897929861u)))
			{
				num = -1540747587;
				num164 = num;
			}
			else
			{
				num = -608264925;
				num164 = num;
			}
			continue;
			IL_1a5d:
			int num165;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2241625074u)))
			{
				num = -123675309;
				num165 = num;
			}
			else
			{
				num = -1926509402;
				num165 = num;
			}
			continue;
			IL_26cd:
			int num166;
			if (array4.Length > 1)
			{
				num = -182306341;
				num166 = num;
			}
			else
			{
				num = -244015490;
				num166 = num;
			}
			continue;
			IL_12bf:
			int num167;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2434569815u)))
			{
				num = -1057618381;
				num167 = num;
			}
			else
			{
				num = -1760843048;
				num167 = num;
			}
			continue;
			IL_04f3:
			int num168;
			if (num85 < array9.Length)
			{
				num = -1343632718;
				num168 = num;
			}
			else
			{
				num = -418241964;
				num168 = num;
			}
			continue;
			IL_26a2:
			int num169;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1863769965u)))
			{
				num = -1381440869;
				num169 = num;
			}
			else
			{
				num = -89181402;
				num169 = num;
			}
			continue;
			IL_1a32:
			int num170;
			if (!_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(107710049u)))
			{
				num = -1430501190;
				num170 = num;
			}
			else
			{
				num = -584086831;
				num170 = num;
			}
			continue;
			IL_0969:
			int num171;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(258808380u)))
			{
				num = -1333466195;
				num171 = num;
			}
			else
			{
				num = -1329383676;
				num171 = num;
			}
			continue;
			IL_25c9:
			int num172;
			if (num7 < 6)
			{
				num = -473325286;
				num172 = num;
			}
			else
			{
				num = -1196779066;
				num172 = num;
			}
			continue;
			IL_11f6:
			int num173;
			if (num5 >= num6)
			{
				num = -473325286;
				num173 = num;
			}
			else
			{
				num = -345796330;
				num173 = num;
			}
			continue;
			IL_198d:
			int num174;
			if (!role16.HasTalent(array8[num13]))
			{
				num = -930606503;
				num174 = num;
			}
			else
			{
				num = -381772173;
				num174 = num;
			}
			continue;
			IL_2514:
			int num175;
			if (num7 != 5)
			{
				num = -1188695239;
				num175 = num;
			}
			else
			{
				num = -1828356989;
				num175 = num;
			}
			continue;
			IL_0b36:
			int num176;
			if (role10.Role.Level >= num42)
			{
				num = -1892363887;
				num176 = num;
			}
			else
			{
				num = -764476953;
				num176 = num;
			}
			continue;
			IL_06ca:
			int num177;
			if (!_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2505468929u)))
			{
				num = -238175489;
				num177 = num;
			}
			else
			{
				num = -360341212;
				num177 = num;
			}
			continue;
			IL_245f:
			int num178;
			if (!_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(480648235u)))
			{
				num = -972959928;
				num178 = num;
			}
			else
			{
				num = -2008430810;
				num178 = num;
			}
			continue;
			IL_18fc:
			int num179;
			if (num5 < num6)
			{
				num = -274065970;
				num179 = num;
			}
			else
			{
				num = -1732373014;
				num179 = num;
			}
			continue;
			IL_1172:
			int num180;
			if (role7.Role.AttributesFinal[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2434912689u)] < num68)
			{
				num = -1242686640;
				num180 = num;
			}
			else
			{
				num = -271237706;
				num180 = num;
			}
			continue;
			IL_22fc:
			int num181;
			if (!_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3346239900u)))
			{
				num = -788555730;
				num181 = num;
			}
			else
			{
				num = -1926251783;
				num181 = num;
			}
			continue;
			IL_07dc:
			int num182;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3511038183u)))
			{
				num = -443605118;
				num182 = num;
			}
			else
			{
				num = -1155254665;
				num182 = num;
			}
			continue;
			IL_18da:
			int num183;
			if (!role5.HasEquipmentTalent(array3[num94]))
			{
				num = -705404228;
				num183 = num;
			}
			else
			{
				num = -652563803;
				num183 = num;
			}
			continue;
			IL_22d1:
			int num184;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2168562558u)))
			{
				num = -1661233233;
				num184 = num;
			}
			else
			{
				num = -932398971;
				num184 = num;
			}
			continue;
			IL_0ab5:
			int num185;
			if (!_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2968884970u)))
			{
				num = -225142632;
				num185 = num;
			}
			else
			{
				num = -1448521347;
				num185 = num;
			}
			continue;
			IL_1143:
			int num186;
			if (num5 >= num6)
			{
				num = -473325286;
				num186 = num;
			}
			else
			{
				num = -569030890;
				num186 = num;
			}
			continue;
			IL_220d:
			int num187;
			if (num13 < array8.Length)
			{
				num = -1069267740;
				num187 = num;
			}
			else
			{
				num = -261034125;
				num187 = num;
			}
			continue;
			IL_187f:
			string text4 = array14[num51];
			int num188;
			if (Tools.IsChineseTime(RuntimeData.Instance.Date, _200E_206C_206D_202D_206E_200B_200C_202A_206F_206F_206A_202C_202C_200B_200B_202A_206B_200F_202A_206C_206C_200D_206D_202B_200B_200E_206E_202C_202C_206A_200F_206E_200D_200C_200F_206B_206C_206C_206A_200F_202E(text4, 0)))
			{
				num = -568989863;
				num188 = num;
			}
			else
			{
				num = -16331361;
				num188 = num;
			}
			continue;
			IL_08f6:
			int num189;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4202252821u)))
			{
				num = -1062644749;
				num189 = num;
			}
			else
			{
				num = -1709998553;
				num189 = num;
			}
			continue;
			IL_2175:
			int num190;
			if (num5 < num6)
			{
				num = -951999010;
				num190 = num;
			}
			else
			{
				num = -1711861765;
				num190 = num;
			}
			continue;
			IL_04ba:
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(871706881u)))
			{
				num = -868575735;
				continue;
			}
			goto IL_3113;
			IL_180b:
			int num191;
			if (!_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4019271803u)))
			{
				num = -804794368;
				num191 = num;
			}
			else
			{
				num = -1828255139;
				num191 = num;
			}
			continue;
			IL_2081:
			int num192;
			if (!_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(503077291u)))
			{
				num = -2087526342;
				num192 = num;
			}
			else
			{
				num = -1718036986;
				num192 = num;
			}
			continue;
			IL_103c:
			int num193;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1014797732u)))
			{
				num = -419185756;
				num193 = num;
			}
			else
			{
				num = -705540836;
				num193 = num;
			}
			continue;
			IL_0a65:
			int num194;
			if (!role12.HasRoleTalent(array9[num85]))
			{
				num = -844472485;
				num194 = num;
			}
			else
			{
				num = -1164304339;
				num194 = num;
			}
			continue;
			IL_1feb:
			int num195;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1864270144u)))
			{
				num = -477232149;
				num195 = num;
			}
			else
			{
				num = -980463647;
				num195 = num;
			}
			continue;
			IL_169a:
			int num196;
			if (num7 != 2)
			{
				num = -265158126;
				num196 = num;
			}
			else
			{
				num = -997976634;
				num196 = num;
			}
			continue;
			IL_0566:
			int num197;
			if (role.GetInternalSkillLevel(text2) < num10)
			{
				num = -1089700025;
				num197 = num;
			}
			else
			{
				num = -1489287626;
				num197 = num;
			}
			continue;
			IL_1f1e:
			role18 = AttackLogic.field.GetRole(roleKey3);
			int num198;
			if (_206A_206D_202E_200E_202E_202B_206F_202A_202C_206B_200D_202B_202A_206B_206A_202A_200E_202C_202E_206B_200D_202C_206F_202C_202A_206B_206F_202C_200D_206B_200E_206F_200B_200C_206D_200D_206B_202B_202E_202A_202E((Object)(object)role18, (Object)null))
			{
				num = -1346351288;
				num198 = num;
			}
			else
			{
				num = -664577975;
				num198 = num;
			}
			continue;
			IL_101b:
			text = array5[0];
			int num199;
			if (array5.Length <= 1)
			{
				num = -1900369630;
				num199 = num;
			}
			else
			{
				num = -1119779562;
				num199 = num;
			}
			continue;
			IL_166f:
			int num200;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(84463869u)))
			{
				num = -1002576709;
				num200 = num;
			}
			else
			{
				num = -343394454;
				num200 = num;
			}
			continue;
			IL_1ef3:
			int num201;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4082591332u)))
			{
				num = -1886199795;
				num201 = num;
			}
			else
			{
				num = -2048771513;
				num201 = num;
			}
			continue;
			IL_0880:
			int num202;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(177010428u)))
			{
				num = -357047085;
				num202 = num;
			}
			else
			{
				num = -1881796438;
				num202 = num;
			}
			continue;
			IL_0a2e:
			int num203;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(767449763u)))
			{
				num = -690978496;
				num203 = num;
			}
			else
			{
				num = -68805395;
				num203 = num;
			}
			continue;
			IL_1e58:
			int num204;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(389179294u)))
			{
				num = -1511917670;
				num204 = num;
			}
			else
			{
				num = -400546710;
				num204 = num;
			}
			continue;
			IL_15b2:
			role17 = AttackLogic.field.GetRole(roleKey);
			if (_206B_206F_206D_200B_206B_202D_200F_206F_200F_200D_202B_202D_206B_202E_202E_206F_202B_200B_206B_206F_202E_206C_206B_202E_200B_200D_206F_202C_202C_200D_206F_206A_206F_202C_200F_202D_206C_202C_202B_206B_202E((Object)(object)role17, (Object)null))
			{
				num = -1262742238;
				continue;
			}
			goto IL_2846;
			IL_0f22:
			int num205;
			if (!_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2162747465u)))
			{
				num = -163861122;
				num205 = num;
			}
			else
			{
				num = -943048266;
				num205 = num;
			}
			continue;
			IL_1e09:
			int num206;
			if (num7 != 4)
			{
				num = -611478717;
				num206 = num;
			}
			else
			{
				num = -1978832357;
				num206 = num;
			}
			continue;
			IL_2846:
			return false;
			IL_1386:
			int num207;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1140172321u)))
			{
				num = -870444817;
				num207 = num;
			}
			else
			{
				num = -761334084;
				num207 = num;
			}
			continue;
			IL_1d66:
			int num208;
			if (!_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1858947288u)))
			{
				num = -1319569571;
				num208 = num;
			}
			else
			{
				num = -676325979;
				num208 = num;
			}
			continue;
			IL_07af:
			int num209;
			if (num7 == 1)
			{
				num = -796206032;
				num209 = num;
			}
			else
			{
				num = -2001349877;
				num209 = num;
			}
			continue;
			IL_05f5:
			int num210;
			if (num94 < array3.Length)
			{
				num = -675452811;
				num210 = num;
			}
			else
			{
				num = -1570554659;
				num210 = num;
			}
			continue;
			IL_1d08:
			int num211;
			if (role18.Role.AttributesFinal[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1995100678u)] >= num139)
			{
				num = -1300063816;
				num211 = num;
			}
			else
			{
				num = -1547007320;
				num211 = num;
			}
			continue;
			IL_135b:
			int num212;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2994203278u)))
			{
				num = -725448823;
				num212 = num;
			}
			else
			{
				num = -1008534678;
				num212 = num;
			}
			continue;
			IL_0d1e:
			int num213;
			if (num51 >= array14.Length)
			{
				num = -2031212077;
				num213 = num;
			}
			else
			{
				num = -669691703;
				num213 = num;
			}
			continue;
			IL_1cdd:
			int num214;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2397888198u)))
			{
				num = -1913058367;
				num214 = num;
			}
			else
			{
				num = -793854139;
				num214 = num;
			}
			continue;
			IL_0994:
			int num215;
			if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1561049002u)))
			{
				num = -147346143;
				num215 = num;
			}
			else
			{
				num = -694496578;
				num215 = num;
			}
			continue;
			IL_12ff:
			int num216;
			if (!_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2280880831u)))
			{
				num = -912290206;
				num216 = num;
			}
			else
			{
				num = -914510032;
				num216 = num;
			}
			continue;
			IL_1c38:
			int num217;
			if (num7 == 3)
			{
				num = -515758806;
				num217 = num;
			}
			else
			{
				num = -880887453;
				num217 = num;
			}
			continue;
			IL_0855:
			int num218;
			if (!_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3027106464u)))
			{
				num = -970497638;
				num218 = num;
			}
			else
			{
				num = -828884153;
				num218 = num;
			}
		}
		goto IL_001a;
		IL_3113:
		int num224 = default(int);
		BattleSprite role22 = default(BattleSprite);
		string[] array20 = default(string[]);
		int num221 = default(int);
		string[] array19 = default(string[]);
		bool result6 = default(bool);
		string[] array21 = default(string[]);
		string[] array18 = default(string[]);
		int num233 = default(int);
		BattleSprite role19 = default(BattleSprite);
		string[] array15 = default(string[]);
		BattleSprite roleByName3 = default(BattleSprite);
		string[] array17 = default(string[]);
		string[] array16 = default(string[]);
		bool result5 = default(bool);
		Role role23 = default(Role);
		int num240 = default(int);
		Role role20 = default(Role);
		BattleSprite role21 = default(BattleSprite);
		while (true)
		{
			int num219;
			int num220;
			if (!_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1880938650u)))
			{
				num219 = -2098734249;
				num220 = num219;
			}
			else
			{
				num219 = -216132072;
				num220 = num219;
			}
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num219 ^ -322636350)) % 84)
				{
				case 83u:
					num219 = -1547862932;
					continue;
				case 41u:
					num224 = 1;
					num219 = ((int)num2 * -769830396) ^ -1844910498;
					continue;
				case 47u:
					return true;
				case 50u:
				{
					int num243;
					int num244;
					if (_206A_206D_202E_200E_202E_202B_206F_202A_202C_206B_200D_202B_202A_206B_206A_202A_200E_202C_202E_206B_200D_202C_206F_202C_202A_206B_206F_202C_200D_206B_200E_206F_200B_200C_206D_200D_206B_202B_202E_202A_202E((Object)(object)role22, (Object)null))
					{
						num243 = -1757054247;
						num244 = num243;
					}
					else
					{
						num243 = -960557191;
						num244 = num243;
					}
					num219 = num243 ^ (int)(num2 * 1051713372);
					continue;
				}
				case 36u:
				{
					int num229;
					int num230;
					if (array20.Length > 1)
					{
						num229 = 24459150;
						num230 = num229;
					}
					else
					{
						num229 = 714105552;
						num230 = num229;
					}
					num219 = num229 ^ ((int)num2 * -31032046);
					continue;
				}
				case 40u:
					num221 = int.Parse(array19[1]);
					num219 = (int)((num2 * 2000953759) ^ 0x70072909);
					continue;
				case 3u:
					break;
				case 76u:
					return result6;
				case 30u:
					num219 = ((int)num2 * -673671715) ^ -1542777716;
					continue;
				case 65u:
					return RuntimeData.Instance.GetBattleLoseCount() >= int.Parse(array21[0]);
				case 9u:
					return RuntimeData.Instance.GetBattleWinCount(array18[0]) >= int.Parse(array18[1]);
				case 13u:
					return RuntimeData.Instance.GetBattleLoseCount(array21[0]) >= int.Parse(array21[1]);
				case 27u:
					result6 = false;
					num219 = ((int)num2 * -767229903) ^ -276127405;
					continue;
				case 23u:
				{
					int num238;
					int num239;
					if (array19.Length == 1)
					{
						num238 = 478318296;
						num239 = num238;
					}
					else
					{
						num238 = 919607326;
						num239 = num238;
					}
					num219 = num238 ^ (int)(num2 * 2001813834);
					continue;
				}
				case 55u:
					return false;
				case 79u:
					num233++;
					num219 = -828714240;
					continue;
				case 4u:
					num219 = (int)(num2 * 25332445) ^ -953769224;
					continue;
				case 80u:
					role19 = AttackLogic.field.GetRole(array15[0]);
					num219 = -856614260;
					continue;
				case 11u:
				{
					int num231;
					int num232;
					if (_206A_206D_202E_200E_202E_202B_206F_202A_202C_206B_200D_202B_202A_206B_206A_202A_200E_202C_202E_206B_200D_202C_206F_202C_202A_206B_206F_202C_200D_206B_200E_206F_200B_200C_206D_200D_206B_202B_202E_202A_202E((Object)(object)roleByName3, (Object)null))
					{
						num231 = -976389379;
						num232 = num231;
					}
					else
					{
						num231 = -1369359862;
						num232 = num231;
					}
					num219 = num231 ^ ((int)num2 * -1816998219);
					continue;
				}
				case 74u:
					return RuntimeData.Instance.GetBattleWinCount() >= int.Parse(array18[0]);
				case 54u:
					num224 = int.Parse(array17[1]);
					num219 = (int)((num2 * 604044822) ^ 0x22D5E1B7);
					continue;
				case 7u:
					roleByName3 = AttackLogic.field.GetRoleByName(array19[0]);
					num219 = -269640599;
					continue;
				case 16u:
					goto IL_2c15;
				case 26u:
					return false;
				case 14u:
					num224 = 0;
					num219 = (int)((num2 * 885809804) ^ 0x12D10C3E);
					continue;
				case 59u:
					return false;
				case 15u:
					goto IL_2c83;
				case 20u:
					return false;
				case 52u:
					array19 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
					num219 = ((int)num2 * -1762631633) ^ -1827058622;
					continue;
				case 48u:
					return RuntimeData.Instance.GetBattleCount() >= int.Parse(array16[0]);
				case 77u:
					role22 = AttackLogic.field.GetRole(array17[0]);
					num219 = -1432755944;
					continue;
				case 25u:
					return false;
				case 62u:
					goto IL_2d38;
				case 68u:
					return RuntimeData.Instance.GetBattleCount(array16[0]) >= int.Parse(array16[1]);
				case 69u:
					return result5;
				case 5u:
					return false;
				case 67u:
					goto IL_2dac;
				case 22u:
					role23 = role19.Role;
					num219 = -1779669133;
					continue;
				case 12u:
				{
					int num247;
					int num248;
					if (array17.Length != 1)
					{
						num247 = 1190798350;
						num248 = num247;
					}
					else
					{
						num247 = 128287143;
						num248 = num247;
					}
					num219 = num247 ^ ((int)num2 * -384481909);
					continue;
				}
				case 64u:
					goto IL_2e16;
				case 71u:
				{
					int num245;
					int num246;
					if (array21.Length < 1)
					{
						num245 = 124037398;
						num246 = num245;
					}
					else
					{
						num245 = 1758587293;
						num246 = num245;
					}
					num219 = num245 ^ ((int)num2 * -1262947416);
					continue;
				}
				case 6u:
					array20 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
					num219 = (int)(num2 * 795791320) ^ -1013769034;
					continue;
				case 45u:
					goto IL_2e87;
				case 81u:
					num240++;
					num219 = -309945741;
					continue;
				case 19u:
					goto IL_2ec2;
				case 31u:
					goto IL_2ee4;
				case 28u:
					return false;
				case 75u:
					goto IL_2f24;
				case 35u:
					array21 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
					num219 = (int)((num2 * 257538904) ^ 0xD5850DD);
					continue;
				case 56u:
				{
					int num241;
					int num242;
					if (RuntimeData.Instance.Rank <= int.Parse(condition.value))
					{
						num241 = 847422885;
						num242 = num241;
					}
					else
					{
						num241 = 1626802291;
						num242 = num241;
					}
					num219 = num241 ^ ((int)num2 * -575079076);
					continue;
				}
				case 82u:
					array17 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
					num219 = ((int)num2 * -957065575) ^ -1256801574;
					continue;
				case 58u:
					result5 = false;
					num219 = (int)(num2 * 943237992) ^ -755265493;
					continue;
				case 43u:
					num240 = 1;
					num219 = ((int)num2 * -1849236724) ^ -290709154;
					continue;
				case 10u:
					return false;
				case 18u:
					return true;
				case 61u:
					goto IL_3037;
				case 72u:
					num219 = (int)((num2 * 1652268498) ^ 0x1B58D963);
					continue;
				case 46u:
					array18 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
					num219 = ((int)num2 * -528644291) ^ -483684617;
					continue;
				case 8u:
					goto IL_3091;
				case 37u:
					goto IL_30ac;
				case 1u:
					return false;
				case 66u:
				{
					int num236;
					int num237;
					if (_206A_206D_202E_200E_202E_202B_206F_202A_202C_206B_200D_202B_202A_206B_206A_202A_200E_202C_202E_206B_200D_202C_206F_202C_202A_206B_206F_202C_200D_206B_200E_206F_200B_200C_206D_200D_206B_202B_202E_202A_202E((Object)(object)role19, (Object)null))
					{
						num236 = 176569752;
						num237 = num236;
					}
					else
					{
						num236 = 1333783844;
						num237 = num236;
					}
					num219 = num236 ^ ((int)num2 * -790626272);
					continue;
				}
				case 70u:
					goto end_IL_284d;
				case 0u:
					return false;
				case 32u:
					goto IL_3153;
				case 39u:
					role20 = role21.Role;
					result6 = true;
					num219 = -255261851;
					continue;
				case 78u:
					goto IL_3184;
				case 17u:
				{
					int num234;
					int num235;
					if (RuntimeData.Instance.Rank < 0)
					{
						num234 = 118524794;
						num235 = num234;
					}
					else
					{
						num234 = 768174703;
						num235 = num234;
					}
					num219 = num234 ^ (int)(num2 * 2145167129);
					continue;
				}
				case 60u:
					num219 = (int)(num2 * 1480633163) ^ -171382173;
					continue;
				case 38u:
					goto IL_31dd;
				case 73u:
					result5 = true;
					num233 = 1;
					num219 = ((int)num2 * -1644197839) ^ -1397178245;
					continue;
				case 42u:
					goto IL_3211;
				case 51u:
				{
					int num227;
					int num228;
					if (array18.Length >= 1)
					{
						num227 = 540759551;
						num228 = num227;
					}
					else
					{
						num227 = 2048581778;
						num228 = num227;
					}
					num219 = num227 ^ ((int)num2 * -239671273);
					continue;
				}
				case 24u:
					num221 = 0;
					num219 = (int)((num2 * 454923797) ^ 0x71C74651);
					continue;
				case 33u:
					goto IL_3276;
				case 2u:
					goto IL_32a1;
				case 53u:
					return false;
				case 34u:
					num219 = ((int)num2 * -1307886365) ^ 0x284DF0BB;
					continue;
				case 49u:
				{
					array16 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
					int num225;
					int num226;
					if (array16.Length < 1)
					{
						num225 = -1290960259;
						num226 = num225;
					}
					else
					{
						num225 = -911487952;
						num226 = num225;
					}
					num219 = num225 ^ ((int)num2 * -133316480);
					continue;
				}
				case 57u:
				{
					array15 = _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(condition.value, new char[1] { '#' });
					int num222;
					int num223;
					if (array15.Length <= 1)
					{
						num222 = -1394064335;
						num223 = num222;
					}
					else
					{
						num222 = -4551598;
						num223 = num222;
					}
					num219 = num222 ^ ((int)num2 * -841543168);
					continue;
				}
				case 29u:
					return true;
				case 44u:
					num221 = 1;
					num219 = ((int)num2 * -1903415467) ^ 0x2F1258A4;
					continue;
				case 63u:
					return false;
				default:
					goto end_IL_3113;
				}
				int num249;
				if (array21.Length >= 2)
				{
					num219 = -395772785;
					num249 = num219;
				}
				else
				{
					num219 = -2052415141;
					num249 = num219;
				}
				continue;
				IL_32a1:
				int num250;
				if (array16.Length < 2)
				{
					num219 = -1894275050;
					num250 = num219;
				}
				else
				{
					num219 = -1830772850;
					num250 = num219;
				}
				continue;
				IL_3091:
				int num251;
				if (array18.Length >= 2)
				{
					num219 = -91961173;
					num251 = num219;
				}
				else
				{
					num219 = -857014224;
					num251 = num219;
				}
				continue;
				IL_30ac:
				int num252;
				if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2060622859u)))
				{
					num219 = -437054563;
					num252 = num219;
				}
				else
				{
					num219 = -1654506021;
					num252 = num219;
				}
				continue;
				IL_3276:
				int num253;
				if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(463191730u)))
				{
					num219 = -1607192008;
					num253 = num219;
				}
				else
				{
					num219 = -1820635647;
					num253 = num219;
				}
				continue;
				IL_2e87:
				int num254;
				if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2263670833u)))
				{
					num219 = -171243917;
					num254 = num219;
				}
				else
				{
					num219 = -1573865116;
					num254 = num219;
				}
				continue;
				IL_3037:
				int num255;
				if (num240 >= array20.Length)
				{
					num219 = -659347638;
					num255 = num219;
				}
				else
				{
					num219 = -2027498162;
					num255 = num219;
				}
				continue;
				IL_3211:
				int num256;
				if (!_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2644702447u)))
				{
					num219 = -2071894812;
					num256 = num219;
				}
				else
				{
					num219 = -1663893876;
					num256 = num219;
				}
				continue;
				IL_2d38:
				int num257;
				if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(798354570u)))
				{
					num219 = -842395090;
					num257 = num219;
				}
				else
				{
					num219 = -123864867;
					num257 = num219;
				}
				continue;
				IL_2c15:
				role21 = AttackLogic.field.GetRole(array20[0]);
				int num258;
				if (!_206A_206D_202E_200E_202E_202B_206F_202A_202C_206B_200D_202B_202A_206B_206A_202A_200E_202C_202E_206B_200D_202C_206F_202C_202A_206B_206F_202C_200D_206B_200E_206F_200B_200C_206D_200D_206B_202B_202E_202A_202E((Object)(object)role21, (Object)null))
				{
					num219 = -935366015;
					num258 = num219;
				}
				else
				{
					num219 = -102647786;
					num258 = num219;
				}
				continue;
				IL_31dd:
				int num259;
				if (array19.Length < 2)
				{
					num219 = -609522651;
					num259 = num219;
				}
				else
				{
					num219 = -172796266;
					num259 = num219;
				}
				continue;
				IL_2f24:
				int num260;
				if (role22.Role.Attributes[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2145573044u)] == num224)
				{
					num219 = -1963936841;
					num260 = num219;
				}
				else
				{
					num219 = -48539357;
					num260 = num219;
				}
				continue;
				IL_2e16:
				int num261;
				if (role20.GetSpecialSkill(array20[num240]) == null)
				{
					num219 = -1041868323;
					num261 = num219;
				}
				else
				{
					num219 = -1308241829;
					num261 = num219;
				}
				continue;
				IL_3184:
				int num262;
				if (num233 >= array15.Length)
				{
					num219 = -742665381;
					num262 = num219;
				}
				else
				{
					num219 = -1336107411;
					num262 = num219;
				}
				continue;
				IL_2ec2:
				int num263;
				if (!role23.HasTitle(array15[num233]))
				{
					num219 = -742658396;
					num263 = num219;
				}
				else
				{
					num219 = -1148039963;
					num263 = num219;
				}
				continue;
				IL_2ee4:
				int num264;
				if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1533927897u)))
				{
					num219 = -861406749;
					num264 = num219;
				}
				else
				{
					num219 = -1763623613;
					num264 = num219;
				}
				continue;
				IL_3153:
				int num265;
				if (array17.Length >= 2)
				{
					num219 = -24552648;
					num265 = num219;
				}
				else
				{
					num219 = -325258037;
					num265 = num219;
				}
				continue;
				IL_2c83:
				int num266;
				if (_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2730057027u)))
				{
					num219 = -927243837;
					num266 = num219;
				}
				else
				{
					num219 = -890448957;
					num266 = num219;
				}
				continue;
				IL_2dac:
				int num267;
				if (roleByName3.Role.Attributes[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2015671736u)] != num221)
				{
					num219 = -1028535633;
					num267 = num219;
				}
				else
				{
					num219 = -327699396;
					num267 = num219;
				}
				continue;
				end_IL_284d:
				break;
			}
			continue;
			end_IL_3113:
			break;
		}
		goto IL_3393;
		IL_13fb:
		int num268;
		if (!_202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(condition.type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3862351217u)))
		{
			num = -1609655205;
			num268 = num;
		}
		else
		{
			num = -1809070870;
			num268 = num;
		}
		goto IL_001f;
		IL_3393:
		return result4;
	}

	static bool _206C_200C_200D_206C_206D_206F_202E_200B_202A_206F_206C_206B_206F_200F_202D_206F_202D_202B_206D_200F_202B_200B_202A_206D_206A_206E_200D_206A_200C_202A_206D_206F_200E_200C_206A_206C_200F_200D_202C_202B_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static bool _200F_200E_206B_202A_206B_200B_202E_206A_202D_202C_200B_206D_206F_202A_206A_206F_202D_202B_200E_200F_202A_202B_200D_202D_206A_206B_202C_202D_206A_202E_206C_206E_206D_202A_206F_200D_206D_202E_206D_206B_202E(string P_0, string P_1)
	{
		return P_0.Contains(P_1);
	}

	static string[] _202E_200E_206C_206F_200D_200B_206C_206C_202C_202E_200F_206C_200F_202D_202D_200C_202C_206B_206A_202C_206C_202C_206A_206D_200D_206B_206C_200F_202A_206F_206A_202D_202C_206D_206E_200E_200B_206E_200C_202B_202E(string P_0, char[] P_1)
	{
		return P_0.Split(P_1);
	}

	static bool _202B_202B_202D_202D_206B_206B_206F_200C_206B_206E_202E_200C_202E_202B_206A_202E_202E_200C_206C_202B_206E_206A_202A_206B_200E_206F_200C_200B_200E_206A_200F_200E_206C_206A_202D_202E_206C_206C_202A_200E_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static bool _206B_202C_202E_200E_202B_200B_202E_206A_206C_206C_202B_200F_200C_200C_206E_206E_202B_206A_206F_200B_206D_206C_206D_202D_200B_206E_206C_206F_200B_206B_202A_202D_206D_202C_202E_206E_206E_206F_202D_200F_202E(string P_0, string P_1)
	{
		return P_0.Equals(P_1);
	}

	static string _206C_202D_202B_202C_202E_206C_202C_206C_200C_202C_202D_200F_206C_206A_206A_200D_200E_202D_200D_206E_200F_200C_206F_202A_200D_202A_206D_206E_206F_206D_206A_206C_206B_200E_202A_206F_202B_202A_206A_206E_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static bool _206B_200C_200D_202B_202D_200E_202E_206D_200E_200F_202C_200C_202A_200F_200C_206D_202B_206E_202D_202D_200C_200D_202E_200B_206E_202B_206E_200B_206F_206D_200F_200F_202C_202B_202C_202D_200F_202E_202E_200C_202E(string P_0, string P_1)
	{
		return P_0 != P_1;
	}

	static bool _206B_206F_206D_200B_206B_202D_200F_206F_200F_200D_202B_202D_206B_202E_202E_206F_202B_200B_206B_206F_202E_206C_206B_202E_200B_200D_206F_202C_202C_200D_206F_206A_206F_202C_200F_202D_206C_202C_202B_206B_202E(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static int _202E_206F_202E_200F_206A_206D_200D_206D_206B_206C_206E_202B_200E_206B_202C_206C_202D_200E_202B_206A_200F_206A_206A_200E_200C_202E_202A_206D_206C_206C_206B_200F_206F_206C_202E_206C_200B_200D_206E_206F_202E(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	static char _200E_206C_206D_202D_206E_200B_200C_202A_206F_206F_206A_202C_202C_200B_200B_202A_206B_200F_202A_206C_206C_200D_206D_202B_200B_200E_206E_202C_202C_206A_200F_206E_200D_200C_200F_206B_206C_206C_206A_200F_202E(string P_0, int P_1)
	{
		return P_0[P_1];
	}

	static bool _206A_206D_202E_200E_202E_202B_206F_202A_202C_206B_200D_202B_202A_206B_206A_202A_200E_202C_202E_206B_200D_202C_206F_202C_202A_206B_206F_202C_200D_206B_200E_206F_200B_200C_206D_200D_206B_202B_202E_202A_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}
}
