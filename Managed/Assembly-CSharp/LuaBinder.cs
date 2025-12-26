using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public static class LuaBinder
{
	public static List<string> wrapList = new List<string>();

	[CompilerGenerated]
	private static Dictionary<string, int> _202B_200B_200D_206A_202E_202D_200C_200F_202B_202C_200D_206D_200C_206A_206B_206F_206A_200F_202D_206B_200D_206D_206B_200B_206D_202A_202A_200E_206D_202A_206A_200C_200C_206E_206B_200D_200B_206E_206B_202B_202E;

	public static void Bind(IntPtr L, string type = null)
	{
		if (type == null)
		{
			return;
		}
		Dictionary<string, int> dictionary = default(Dictionary<string, int>);
		string text = default(string);
		int value = default(int);
		while (true)
		{
			int num = 290195506;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2D849C20)) % 137)
				{
				case 83u:
					break;
				default:
					return;
				case 39u:
					num = ((int)num2 * -178817269) ^ 0x7B6AB2CB;
					continue;
				case 54u:
					num = ((int)num2 * -35350862) ^ -1663848331;
					continue;
				case 111u:
					ScreenWrap.Register(L);
					num = 1474861278;
					continue;
				case 9u:
					goto IL_027b;
				case 116u:
					num = (int)(num2 * 871007966) ^ -1033325969;
					continue;
				case 66u:
					goto IL_029d;
				case 87u:
					dictionary.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(301066716u), 5);
					num = (int)((num2 * 252409762) ^ 0x5C782AF1);
					continue;
				case 59u:
					goto IL_02d0;
				case 14u:
					goto IL_02e0;
				case 101u:
					goto IL_02f0;
				case 49u:
					num = ((int)num2 * -283132111) ^ 0x4E4A6305;
					continue;
				case 37u:
					num = ((int)num2 * -1399051377) ^ 0x62260ABA;
					continue;
				case 45u:
					num = ((int)num2 * -2022999903) ^ -1062512418;
					continue;
				case 48u:
					goto IL_0336;
				case 129u:
					goto IL_0346;
				case 102u:
					goto IL_0356;
				case 67u:
					goto IL_0366;
				case 110u:
					num = (int)(num2 * 1008263787) ^ -1862393817;
					continue;
				case 97u:
					goto IL_0388;
				case 134u:
					goto IL_0398;
				case 89u:
					goto IL_03a8;
				case 78u:
					goto IL_03b8;
				case 108u:
					num = ((int)num2 * -1976204376) ^ 0x7970A141;
					continue;
				case 22u:
					goto IL_03da;
				case 3u:
					dictionary.Add(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2397251649u), 34);
					num = (int)((num2 * 2030304848) ^ 0x1A183312);
					continue;
				case 104u:
					goto IL_040e;
				case 28u:
					dictionary.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(575500696u), 38);
					dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3161250144u), 39);
					dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(17956726u), 40);
					dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(529346352u), 41);
					num = ((int)num2 * -1126793330) ^ 0x53B04B66;
					continue;
				case 46u:
					goto IL_0478;
				case 61u:
					goto IL_0488;
				case 40u:
					num = (int)((num2 * 1191479660) ^ 0x471E5055);
					continue;
				case 16u:
					dictionary.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2630355616u), 11);
					dictionary.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1799980287u), 12);
					num = ((int)num2 * -996568129) ^ -1290778320;
					continue;
				case 68u:
					dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(898731749u), 2);
					num = ((int)num2 * -1763664123) ^ -2058140603;
					continue;
				case 11u:
					goto IL_0503;
				case 29u:
					goto IL_0513;
				case 93u:
					goto IL_0523;
				case 121u:
					goto IL_0533;
				case 42u:
					dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1951221181u), 52);
					num = (int)(num2 * 207819903) ^ -327974181;
					continue;
				case 56u:
					dictionary.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3285577286u), 60);
					dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4005959421u), 61);
					num = ((int)num2 * -1123062440) ^ 0x1939028A;
					continue;
				case 50u:
					goto IL_059d;
				case 103u:
					num = (int)(num2 * 1975739054) ^ -1082323041;
					continue;
				case 96u:
					goto IL_05bf;
				case 52u:
					goto IL_05cf;
				case 4u:
					num = ((int)num2 * -473965686) ^ -1697257183;
					continue;
				case 34u:
					goto IL_05f1;
				case 17u:
					dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1466961473u), 6);
					dictionary.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3491419186u), 7);
					num = (int)((num2 * 1171961059) ^ 0x7B9F9901);
					continue;
				case 19u:
					goto IL_0635;
				case 63u:
					goto IL_0645;
				case 118u:
					num = (int)(num2 * 1503903711) ^ -292052361;
					continue;
				case 76u:
					dictionary.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1692040588u), 56);
					num = (int)((num2 * 2118731949) ^ 0x2CB3463C);
					continue;
				case 75u:
					_202B_200B_200D_206A_202E_202D_200C_200F_202B_202C_200D_206D_200C_206A_206B_206F_206A_200F_202D_206B_200D_206D_206B_200B_206D_202A_202A_200E_206D_202A_206A_200C_200C_206E_206B_200D_200B_206E_206B_202B_202E = dictionary;
					num = ((int)num2 * -1534574421) ^ -1543707970;
					continue;
				case 107u:
					goto IL_06a3;
				case 43u:
					dictionary.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2264403192u), 48);
					dictionary.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2459096388u), 49);
					dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1622184597u), 50);
					dictionary.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1594359007u), 51);
					num = ((int)num2 * -349532534) ^ -325918499;
					continue;
				case 72u:
					num = ((int)num2 * -1062701666) ^ -70789511;
					continue;
				case 36u:
					goto IL_071f;
				case 18u:
				{
					text = type;
					int num8;
					int num9;
					if (text != null)
					{
						num8 = 1018726894;
						num9 = num8;
					}
					else
					{
						num8 = 1122561683;
						num9 = num8;
					}
					num = num8 ^ ((int)num2 * -1208870703);
					continue;
				}
				case 98u:
					goto IL_0750;
				case 0u:
					goto IL_0760;
				case 73u:
					num = ((int)num2 * -1386919541) ^ -569043652;
					continue;
				case 8u:
					goto IL_0782;
				case 99u:
					num = (int)(num2 * 1352967014) ^ -1211467553;
					continue;
				case 106u:
				{
					int num6;
					int num7;
					if (_202B_200B_200D_206A_202E_202D_200C_200F_202B_202C_200D_206D_200C_206A_206B_206F_206A_200F_202D_206B_200D_206D_206B_200B_206D_202A_202A_200E_206D_202A_206A_200C_200C_206E_206B_200D_200B_206E_206B_202B_202E == null)
					{
						num6 = 378936582;
						num7 = num6;
					}
					else
					{
						num6 = 1645430367;
						num7 = num6;
					}
					num = num6 ^ ((int)num2 * -2120676523);
					continue;
				}
				case 112u:
					goto IL_07c7;
				case 84u:
					dictionary.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(139229629u), 10);
					num = (int)((num2 * 590630090) ^ 0x55546FCD);
					continue;
				case 114u:
					num = ((int)num2 * -1856014789) ^ -319440055;
					continue;
				case 94u:
					return;
				case 51u:
					num = (int)((num2 * 443889121) ^ 0x505EB718);
					continue;
				case 7u:
					num = (int)(num2 * 475225044) ^ -1373677163;
					continue;
				case 105u:
					goto IL_083c;
				case 115u:
					goto IL_084c;
				case 100u:
					dictionary.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3361048272u), 62);
					num = ((int)num2 * -589986576) ^ 0x57807FA7;
					continue;
				case 86u:
					goto IL_0880;
				case 27u:
					dictionary.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(84939287u), 31);
					num = ((int)num2 * -1477314162) ^ -605224516;
					continue;
				case 90u:
					dictionary.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(631821111u), 4);
					num = (int)((num2 * 975302625) ^ 0x454683AE);
					continue;
				case 80u:
					num = ((int)num2 * -1793125944) ^ -832884015;
					continue;
				case 62u:
					goto IL_08e9;
				case 127u:
					goto IL_08f9;
				case 135u:
					dictionary.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1357660520u), 22);
					dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(620902591u), 23);
					dictionary.Add(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3848279231u), 24);
					dictionary.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(929719397u), 25);
					num = ((int)num2 * -2022886747) ^ 0x6A58C5E0;
					continue;
				case 117u:
					dictionary.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(552049989u), 32);
					num = (int)(num2 * 2129465759) ^ -1768607469;
					continue;
				case 128u:
					num = ((int)num2 * -215305184) ^ 0x2DD5CEE1;
					continue;
				case 92u:
					goto IL_0999;
				case 65u:
					dictionary.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2575481825u), 18);
					num = (int)((num2 * 904856261) ^ 0x32E1AF8A);
					continue;
				case 1u:
					goto IL_09cd;
				case 88u:
					goto IL_09dd;
				case 53u:
					num = ((int)num2 * -600834241) ^ 0xFF6A10;
					continue;
				case 79u:
					goto IL_09ff;
				case 31u:
					num = (int)((num2 * 706744258) ^ 0x7A262605);
					continue;
				case 33u:
					switch (value)
					{
					case 45:
						break;
					case 44:
						goto IL_027b;
					case 60:
						goto IL_029d;
					case 59:
						goto IL_02d0;
					case 40:
						goto IL_02e0;
					case 1:
						goto IL_02f0;
					case 29:
						goto IL_0336;
					case 11:
						goto IL_0346;
					case 21:
						goto IL_0356;
					case 57:
						goto IL_0366;
					case 37:
						goto IL_0388;
					case 16:
						goto IL_0398;
					case 38:
						goto IL_03a8;
					case 9:
						goto IL_03b8;
					case 46:
						goto IL_03da;
					case 53:
						goto IL_040e;
					case 48:
						goto IL_0478;
					case 8:
						goto IL_0488;
					case 31:
						goto IL_0503;
					case 56:
						goto IL_0513;
					case 27:
						goto IL_0523;
					case 23:
						goto IL_0533;
					case 25:
						goto IL_059d;
					case 26:
						goto IL_05bf;
					case 5:
						goto IL_05cf;
					case 10:
						goto IL_05f1;
					case 2:
						goto IL_0635;
					case 50:
						goto IL_0645;
					case 58:
						goto IL_06a3;
					case 18:
						goto IL_071f;
					case 0:
						goto IL_0750;
					case 54:
						goto IL_0760;
					case 30:
						goto IL_0782;
					case 62:
						goto IL_07c7;
					case 12:
						goto IL_083c;
					case 24:
						goto IL_084c;
					case 33:
						goto IL_0880;
					case 34:
						goto IL_08e9;
					case 42:
						goto IL_08f9;
					case 6:
						goto IL_0999;
					case 15:
						goto IL_09cd;
					case 22:
						goto IL_09dd;
					case 39:
						goto IL_09ff;
					default:
						goto IL_0b23;
					case 19:
						goto IL_0b59;
					case 28:
						goto IL_0c2f;
					case 3:
						goto IL_0c3f;
					case 52:
						goto IL_0c4f;
					case 17:
						goto IL_0c5f;
					case 51:
						goto IL_0c93;
					case 13:
						goto IL_0ca3;
					case 4:
						goto IL_0d5b;
					case 61:
						goto IL_0d6b;
					case 41:
						goto IL_0def;
					case 35:
						goto IL_0dff;
					case 7:
						goto IL_0e44;
					case 32:
						goto IL_0e9c;
					case 47:
						goto IL_0eac;
					case 20:
						goto IL_0ebc;
					case 14:
						goto IL_0f38;
					case 36:
						goto IL_0fb3;
					case 49:
						goto IL_10d0;
					case 43:
						goto IL_10e0;
					case 55:
						goto IL_1102;
					}
					goto case 111u;
				case 25u:
					dictionary.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1497347392u), 55);
					num = ((int)num2 * -1433377279) ^ -101000586;
					continue;
				case 119u:
					goto IL_0b59;
				case 26u:
					dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(69953357u), 13);
					dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4287309091u), 14);
					dictionary.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3603821596u), 15);
					dictionary.Add(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3713197699u), 16);
					num = (int)(num2 * 181100616) ^ -1724841407;
					continue;
				case 109u:
					num = ((int)num2 * -1184518224) ^ -2028315807;
					continue;
				case 58u:
					num = ((int)num2 * -258984923) ^ -644166870;
					continue;
				case 70u:
					dictionary.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(981321942u), 20);
					num = ((int)num2 * -1409621175) ^ 0x45CB4457;
					continue;
				case 57u:
					dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2812689413u), 21);
					num = (int)((num2 * 352196614) ^ 0x2B5B220D);
					continue;
				case 47u:
					goto IL_0c2f;
				case 64u:
					goto IL_0c3f;
				case 24u:
					goto IL_0c4f;
				case 60u:
					goto IL_0c5f;
				case 125u:
					dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(108067840u), 33);
					num = ((int)num2 * -721430036) ^ 0x1B23C49C;
					continue;
				case 130u:
					goto IL_0c93;
				case 113u:
					goto IL_0ca3;
				case 30u:
					num = (int)((num2 * 1862979110) ^ 0xB6BA443);
					continue;
				case 91u:
					dictionary = new Dictionary<string, int>(63);
					dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3006871054u), 0);
					dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3875880637u), 1);
					num = ((int)num2 * -1549898103) ^ 0x78D24559;
					continue;
				case 5u:
					dictionary.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1395396013u), 19);
					num = (int)(num2 * 541500325) ^ -1543654180;
					continue;
				case 126u:
					dictionary.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3472447929u), 17);
					num = (int)(num2 * 1226784334) ^ -1332242651;
					continue;
				case 38u:
					num = ((int)num2 * -1912874185) ^ 0x1791B1D5;
					continue;
				case 69u:
					goto IL_0d5b;
				case 132u:
					goto IL_0d6b;
				case 71u:
				{
					int num4;
					int num5;
					if (!wrapList.Contains(type))
					{
						num4 = 1975896824;
						num5 = num4;
					}
					else
					{
						num4 = 442965143;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 698663476);
					continue;
				}
				case 2u:
					wrapList.Add(type);
					type = _200B_200C_200F_200E_200C_206D_206F_202E_206C_206A_206B_202C_206E_200F_200C_200D_200F_200B_206B_206F_200D_202D_206A_202D_200E_200E_202C_200E_206D_200B_206C_206C_206E_200C_206E_200D_202D_200B_206B_202E_202E(type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(280495658u));
					num = 1334897202;
					continue;
				case 85u:
					num = ((int)num2 * -799435816) ^ -1685252255;
					continue;
				case 21u:
					num = ((int)num2 * -1283151238) ^ -2129810409;
					continue;
				case 123u:
					goto IL_0def;
				case 23u:
					goto IL_0dff;
				case 32u:
					dictionary.Add(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1768336349u), 8);
					dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3899251281u), 9);
					num = (int)(num2 * 888953901) ^ -503091089;
					continue;
				case 136u:
					goto IL_0e44;
				case 6u:
					dictionary.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1652665558u), 57);
					dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1651281175u), 58);
					dictionary.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3021428835u), 59);
					num = ((int)num2 * -621520639) ^ -905825830;
					continue;
				case 44u:
					goto IL_0e9c;
				case 122u:
					goto IL_0eac;
				case 124u:
					goto IL_0ebc;
				case 131u:
					dictionary.Add(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2520710091u), 53);
					dictionary.Add(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(57489323u), 54);
					num = ((int)num2 * -1351824575) ^ 0x61402B0F;
					continue;
				case 12u:
					dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2540357648u), 36);
					dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(284020444u), 37);
					num = (int)(num2 * 280575125) ^ -954248264;
					continue;
				case 133u:
					goto IL_0f38;
				case 120u:
					dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4046860304u), 35);
					num = (int)(num2 * 101492413) ^ -1197639737;
					continue;
				case 95u:
					dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3290144770u), 30);
					num = (int)(num2 * 1036708459) ^ -897450259;
					continue;
				case 15u:
				{
					int num3;
					if (!_202B_200B_200D_206A_202E_202D_200C_200F_202B_202C_200D_206D_200C_206A_206B_206F_206A_200F_202D_206B_200D_206D_206B_200B_206D_202A_202A_200E_206D_202A_206A_200C_200C_206E_206B_200D_200B_206E_206B_202B_202E.TryGetValue(text, out value))
					{
						num = 975370785;
						num3 = num;
					}
					else
					{
						num = 766549955;
						num3 = num;
					}
					continue;
				}
				case 82u:
					goto IL_0fb3;
				case 74u:
					dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(928441929u), 42);
					dictionary.Add(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3234600792u), 43);
					dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4221367783u), 44);
					dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2687198905u), 45);
					dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3872919895u), 46);
					dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1376184218u), 47);
					num = ((int)num2 * -975388746) ^ -1391535230;
					continue;
				case 20u:
					dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3514732868u), 26);
					dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3136375101u), 27);
					dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1622944033u), 28);
					dictionary.Add(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3834805412u), 29);
					num = (int)(num2 * 767117758) ^ -1694421462;
					continue;
				case 10u:
					dictionary.Add(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(558689161u), 3);
					num = ((int)num2 * -476869352) ^ -696912955;
					continue;
				case 35u:
					num = (int)((num2 * 596000631) ^ 0x5F45DEF8);
					continue;
				case 81u:
					goto IL_10d0;
				case 41u:
					goto IL_10e0;
				case 77u:
					num = ((int)num2 * -918956349) ^ 0x3A988264;
					continue;
				case 55u:
					goto IL_1102;
				case 13u:
					return;
					IL_02f0:
					AnimationClipWrap.Register(L);
					num = 438298528;
					continue;
					IL_02d0:
					TransformWrap.Register(L);
					num = 975370785;
					continue;
					IL_02e0:
					QualitySettingsWrap.Register(L);
					num = 975370785;
					continue;
					IL_1102:
					TextureWrap.Register(L);
					num = 749238681;
					continue;
					IL_10e0:
					RenderSettingsWrap.Register(L);
					num = 975370785;
					continue;
					IL_10d0:
					SphereColliderWrap.Register(L);
					num = 602415192;
					continue;
					IL_0fb3:
					ParticleRendererWrap.Register(L);
					num = 819415159;
					continue;
					IL_0f38:
					CameraWrap.Register(L);
					num = 1914497815;
					continue;
					IL_0ebc:
					DelegateWrap.Register(L);
					num = 975370785;
					continue;
					IL_0eac:
					SleepTimeoutWrap.Register(L);
					num = 975370785;
					continue;
					IL_0e9c:
					MonoBehaviourWrap.Register(L);
					num = 975370785;
					continue;
					IL_0e44:
					AsyncOperationWrap.Register(L);
					num = 1906971719;
					continue;
					IL_0dff:
					ParticleEmitterWrap.Register(L);
					num = 1109569317;
					continue;
					IL_0def:
					QueueModeWrap.Register(L);
					num = 2004371018;
					continue;
					IL_0d6b:
					UtilWrap.Register(L);
					num = 975370785;
					continue;
					IL_0d5b:
					AppConstWrap.Register(L);
					num = 213415026;
					continue;
					IL_0ca3:
					CameraClearFlagsWrap.Register(L);
					num = 975370785;
					continue;
					IL_0c93:
					System_ObjectWrap.Register(L);
					num = 1349503935;
					continue;
					IL_0c5f:
					ComponentWrap.Register(L);
					num = 1965987396;
					continue;
					IL_0c4f:
					TestDelegateListenerWrap.Register(L);
					num = 1525414296;
					continue;
					IL_0c3f:
					AnimationWrap.Register(L);
					num = 975370785;
					continue;
					IL_0c2f:
					LuaEnumTypeWrap.Register(L);
					num = 1347405845;
					continue;
					IL_0b59:
					DelegateFactoryWrap.Register(L);
					num = 975370785;
					continue;
					IL_0b23:
					num = (int)((num2 * 122621722) ^ 0x780E00D9);
					continue;
					IL_09ff:
					PlayModeWrap.Register(L);
					num = 975370785;
					continue;
					IL_09dd:
					GameObjectWrap.Register(L);
					num = 698775494;
					continue;
					IL_09cd:
					CharacterControllerWrap.Register(L);
					num = 975370785;
					continue;
					IL_0999:
					AssetBundleWrap.Register(L);
					num = 330120756;
					continue;
					IL_08f9:
					RendererWrap.Register(L);
					num = 975370785;
					continue;
					IL_08e9:
					ParticleAnimatorWrap.Register(L);
					num = 975370785;
					continue;
					IL_0880:
					ObjectWrap.Register(L);
					num = 736098226;
					continue;
					IL_084c:
					InputWrap.Register(L);
					num = 590454236;
					continue;
					IL_083c:
					BoxColliderWrap.Register(L);
					num = 975370785;
					continue;
					IL_07c7:
					WWWWrap.Register(L);
					num = 214969679;
					continue;
					IL_027b:
					RenderTextureWrap.Register(L);
					num = 949054991;
					continue;
					IL_029d:
					TypeWrap.Register(L);
					num = 975370785;
					continue;
					IL_0782:
					MeshColliderWrap.Register(L);
					num = 975370785;
					continue;
					IL_0760:
					TestLuaDelegateWrap.Register(L);
					num = 975370785;
					continue;
					IL_0750:
					AnimationBlendModeWrap.Register(L);
					num = 742853004;
					continue;
					IL_071f:
					DebuggerWrap.Register(L);
					num = 1238578734;
					continue;
					IL_06a3:
					TrackedReferenceWrap.Register(L);
					num = 975370785;
					continue;
					IL_0645:
					stringWrap.Register(L);
					num = 2055706891;
					continue;
					IL_0635:
					AnimationStateWrap.Register(L);
					num = 975370785;
					continue;
					IL_05f1:
					BehaviourWrap.Register(L);
					num = 975370785;
					continue;
					IL_05cf:
					ApplicationWrap.Register(L);
					num = 1668306714;
					continue;
					IL_05bf:
					LightTypeWrap.Register(L);
					num = 975370785;
					continue;
					IL_059d:
					KeyCodeWrap.Register(L);
					num = 975370785;
					continue;
					IL_0533:
					IEnumeratorWrap.Register(L);
					num = 757831855;
					continue;
					IL_0523:
					LightWrap.Register(L);
					num = 975370785;
					continue;
					IL_0513:
					TimeWrap.Register(L);
					num = 975370785;
					continue;
					IL_0503:
					MeshRendererWrap.Register(L);
					num = 975370785;
					continue;
					IL_0488:
					AudioClipWrap.Register(L);
					num = 181355321;
					continue;
					IL_0478:
					SpaceWrap.Register(L);
					num = 975370785;
					continue;
					IL_040e:
					TestEventListenerWrap.Register(L);
					num = 1656386281;
					continue;
					IL_03da:
					SkinnedMeshRendererWrap.Register(L);
					num = 975370785;
					continue;
					IL_03b8:
					AudioSourceWrap.Register(L);
					num = 975370785;
					continue;
					IL_03a8:
					PhysicsWrap.Register(L);
					num = 975370785;
					continue;
					IL_0398:
					ColliderWrap.Register(L);
					num = 1666076281;
					continue;
					IL_0388:
					ParticleSystemWrap.Register(L);
					num = 975370785;
					continue;
					IL_0366:
					TouchPhaseWrap.Register(L);
					num = 975370785;
					continue;
					IL_0356:
					EnumWrap.Register(L);
					num = 975370785;
					continue;
					IL_0346:
					BlendWeightsWrap.Register(L);
					num = 975370785;
					continue;
					IL_0336:
					MaterialWrap.Register(L);
					num = 986950684;
					continue;
				}
				break;
			}
		}
	}

	static string _200B_200C_200F_200E_200C_206D_206F_202E_206C_206A_206B_202C_206E_200F_200C_200D_200F_200B_206B_206F_200D_202D_206A_202D_200E_200E_202C_200E_206D_200B_206C_206C_206E_200C_206E_200D_202D_200B_206B_202E_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}
}
