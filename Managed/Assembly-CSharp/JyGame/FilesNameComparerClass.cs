using System;
using System.Collections;

namespace JyGame;

public class FilesNameComparerClass : IComparer
{
	int IComparer.Compare(object x, object y)
	{
		if (x != null)
		{
			int num8 = default(int);
			int num5 = default(int);
			char[] array = default(char[]);
			string text3 = default(string);
			string text = default(string);
			char[] array2 = default(char[]);
			while (true)
			{
				int num = -1699847425;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1526133395)) % 34)
					{
					case 0u:
						break;
					case 33u:
						return -1;
					case 20u:
						num8++;
						num5++;
						num = -345672924;
						continue;
					case 22u:
						return 1;
					case 14u:
					{
						int num13;
						int num14;
						if (!char.IsDigit(array[num5]))
						{
							num13 = -379005296;
							num14 = num13;
						}
						else
						{
							num13 = -1916384202;
							num14 = num13;
						}
						num = num13 ^ ((int)num2 * -1562506503);
						continue;
					}
					case 23u:
						text3 += array[num5];
						num = -1257461788;
						continue;
					case 31u:
						goto IL_012f;
					case 10u:
						goto end_IL_0006;
					case 9u:
						num5 = 0;
						num = (int)(num2 * 213966961) ^ -457263222;
						continue;
					case 16u:
						goto IL_017c;
					case 17u:
					{
						int num6;
						int num7;
						if (char.IsDigit(array[num5]))
						{
							num6 = 425049534;
							num7 = num6;
						}
						else
						{
							num6 = 2110305823;
							num7 = num6;
						}
						num = num6 ^ ((int)num2 * -1133848201);
						continue;
					}
					case 24u:
						goto IL_01c2;
					case 1u:
						goto IL_01df;
					case 8u:
						goto IL_01fa;
					case 27u:
						return -1;
					case 21u:
					{
						int num11;
						int num12;
						if (num5 >= array.Length)
						{
							num11 = -1602798402;
							num12 = num11;
						}
						else
						{
							num11 = -1347397124;
							num12 = num11;
						}
						num = num11 ^ (int)(num2 * 1875287881);
						continue;
					}
					case 4u:
						return 0;
					case 30u:
						goto IL_0264;
					case 29u:
						num = ((int)num2 * -164664025) ^ -2127224401;
						continue;
					case 18u:
						goto IL_0293;
					case 19u:
						goto IL_02ad;
					case 13u:
						return 1;
					case 25u:
						return -1;
					case 11u:
						goto IL_02fb;
					case 12u:
						num8 = 0;
						num = ((int)num2 * -1990722009) ^ 0x43E0F304;
						continue;
					case 2u:
						text = "";
						text3 = "";
						num = ((int)num2 * -304527878) ^ -199721203;
						continue;
					case 3u:
					{
						int num9;
						int num10;
						if (!char.IsDigit(array2[num8]))
						{
							num9 = 873729993;
							num10 = num9;
						}
						else
						{
							num9 = 535645854;
							num10 = num9;
						}
						num = num9 ^ ((int)num2 * -1405596331);
						continue;
					}
					case 5u:
						num5++;
						num = ((int)num2 * -784679747) ^ -39708023;
						continue;
					case 32u:
					{
						string text2 = x as string;
						string obj = y as string;
						array2 = _200F_202C_206B_202E_202B_206A_202D_206F_206B_206C_200C_206D_200B_206D_200F_202B_200B_200F_200D_202E_206A_206F_206B_206A_206E_206F_206F_200E_202D_206C_202C_200D_202E_200E_206A_206A_202B_202B_200E_200F_202E(text2);
						array = _200F_202C_206B_202E_202B_206A_202D_206F_206B_206C_200C_206D_200B_206D_200F_202B_200B_200F_200D_202E_206A_206F_206B_206A_206E_206F_206F_200E_202D_206C_202C_200D_202E_200E_206A_206A_202B_202B_200E_200F_202E(obj);
						num = -959991725;
						continue;
					}
					case 15u:
						goto IL_03af;
					case 6u:
						text += array2[num8];
						num8++;
						num = -264128391;
						continue;
					case 26u:
						num = ((int)num2 * -1985348914) ^ 0x66FB688C;
						continue;
					case 28u:
					{
						int num3;
						int num4;
						if (y != null)
						{
							num3 = -1558326759;
							num4 = num3;
						}
						else
						{
							num3 = -1483155783;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -1707252947);
						continue;
					}
					default:
						return 1;
					}
					break;
					IL_03af:
					int num15;
					if (int.Parse(text) < int.Parse(text3))
					{
						num = -1054611872;
						num15 = num;
					}
					else
					{
						num = -345672924;
						num15 = num;
					}
					continue;
					IL_012f:
					int num16;
					if (array2[num8] > array[num5])
					{
						num = -583864928;
						num16 = num;
					}
					else
					{
						num = -119393115;
						num16 = num;
					}
					continue;
					IL_01c2:
					int num17;
					if (array2[num8] >= array[num5])
					{
						num = -21618233;
						num17 = num;
					}
					else
					{
						num = -1311319058;
						num17 = num;
					}
					continue;
					IL_02fb:
					int num18;
					if (num8 < array2.Length)
					{
						num = -846038628;
						num18 = num;
					}
					else
					{
						num = -215270649;
						num18 = num;
					}
					continue;
					IL_0264:
					int num19;
					if (array2.Length <= array.Length)
					{
						num = -1159683246;
						num19 = num;
					}
					else
					{
						num = -876648138;
						num19 = num;
					}
					continue;
					IL_01df:
					int num20;
					if (num5 >= array.Length)
					{
						num = -1354709310;
						num20 = num;
					}
					else
					{
						num = -1800402929;
						num20 = num;
					}
					continue;
					IL_02ad:
					int num21;
					if (int.Parse(text) <= int.Parse(text3))
					{
						num = -1075387490;
						num21 = num;
					}
					else
					{
						num = -1718821991;
						num21 = num;
					}
					continue;
					IL_017c:
					int num22;
					if (!char.IsDigit(array2[num8]))
					{
						num = -1904679410;
						num22 = num;
					}
					else
					{
						num = -728364582;
						num22 = num;
					}
					continue;
					IL_01fa:
					int num23;
					if (array2.Length != array.Length)
					{
						num = -1000124111;
						num23 = num;
					}
					else
					{
						num = -704074725;
						num23 = num;
					}
					continue;
					IL_0293:
					int num24;
					if (num8 < array2.Length)
					{
						num = -509222224;
						num24 = num;
					}
					else
					{
						num = -2066245204;
						num24 = num;
					}
				}
				continue;
				end_IL_0006:
				break;
			}
		}
		throw _202A_206F_206E_202C_206A_206B_206E_202E_202A_206A_206C_206E_202D_200C_200F_206A_202D_202C_202B_202A_202E_206A_202B_206E_206F_202A_200C_206B_200E_202C_200D_206B_200D_200C_200B_200C_200D_206F_206E_206B_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2935957309u));
	}

	static ArgumentException _202A_206F_206E_202C_206A_206B_206E_202E_202A_206A_206C_206E_202D_200C_200F_206A_202D_202C_202B_202A_202E_206A_202B_206E_206F_202A_200C_206B_200E_202C_200D_206B_200D_200C_200B_200C_200D_206F_206E_206B_202E(string P_0)
	{
		return new ArgumentException(P_0);
	}

	static char[] _200F_202C_206B_202E_202B_206A_202D_206F_206B_206C_200C_206D_200B_206D_200F_202B_200B_200F_200D_202E_206A_206F_206B_206A_206E_206F_206F_200E_202D_206C_202C_200D_202E_200E_206A_206A_202B_202B_200E_200F_202E(string P_0)
	{
		return P_0.ToCharArray();
	}
}
