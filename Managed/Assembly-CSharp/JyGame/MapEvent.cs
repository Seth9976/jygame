using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("event")]
public class MapEvent
{
	[XmlAttribute]
	public string type;

	[XmlAttribute]
	public string value;

	[XmlAttribute]
	public string image;

	[XmlAttribute("probability")]
	public double probabilityValue = 100.0;

	[XmlAttribute]
	public int lv = -1;

	[XmlAttribute]
	public string description;

	[XmlAttribute("repeat")]
	public string repeatValue;

	[XmlElement("condition")]
	public List<Condition> Conditions = new List<Condition>();

	[XmlIgnore]
	public bool noSetLocation;

	[XmlIgnore]
	public double probability
	{
		get
		{
			if (probabilityValue >= 100.0)
			{
				while (true)
				{
					uint num;
					switch ((num = 943970239u) % 3)
					{
					case 2u:
						continue;
					case 1u:
						return 100.0;
					}
					break;
				}
			}
			return _200F_202C_202D_206C_206A_206E_202A_202B_206C_202D_202A_202E_200B_202B_206A_206F_202B_206D_200F_200B_206E_206E_200C_206E_200F_200D_200D_206A_200E_206C_202A_200C_202E_200F_202D_206D_206E_200F_202A_202B_202E(100.0, probabilityValue + (double)CommonSettings.fjtl);
		}
	}

	public bool IsRepeatOnce
	{
		get
		{
			if (!_206D_202B_202D_202C_206D_202B_200B_206F_206A_200B_200F_200C_200B_202D_202C_206D_206B_206F_200D_202A_200D_200B_206C_206F_206A_206A_206A_200F_202C_206D_206A_200E_206F_200E_206A_202E_202B_206C_200E_206C_202E(repeatValue, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2129537481u)))
			{
				while (true)
				{
					uint num;
					switch ((num = 654170582u) % 3)
					{
					case 0u:
						continue;
					case 2u:
						return _200C_206C_200C_200B_206E_206A_206F_200B_202D_206D_206B_202C_206A_202C_202C_202B_206C_200C_202D_202A_202D_200C_206C_202C_206B_206A_202D_200F_206F_200F_206D_200E_206C_200E_206C_202D_202D_202A_202D_206D_202E(repeatValue, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(886536633u));
					}
					break;
				}
			}
			return true;
		}
	}

	[XmlIgnore]
	public bool IsActive
	{
		get
		{
			int num = -2;
			int num11 = default(int);
			int battleCount = default(int);
			string s = default(string);
			string[] array = default(string[]);
			while (true)
			{
				int num2 = -852769625;
				while (true)
				{
					int num15;
					uint num3;
					switch ((num3 = (uint)(num2 ^ -973005913)) % 34)
					{
					case 13u:
						break;
					case 28u:
						return false;
					case 19u:
					{
						int num23;
						if (num > num11)
						{
							num2 = -156012455;
							num23 = num2;
						}
						else
						{
							num2 = -1349094673;
							num23 = num2;
						}
						continue;
					}
					case 15u:
						return false;
					case 29u:
						battleCount = RuntimeData.Instance.GetBattleCount(value);
						num2 = (int)(num3 * 79092110) ^ -2085636400;
						continue;
					case 6u:
						s = repeatValue;
						num2 = -64860557;
						continue;
					case 20u:
						num = 1;
						num2 = ((int)num3 * -1259960493) ^ 0x4202DAFB;
						continue;
					case 23u:
					{
						int num21;
						int num22;
						if (!_206D_202B_202D_202C_206D_202B_200B_206F_206A_200B_200F_200C_200B_202D_202C_206D_206B_206F_200D_202A_200D_200B_206C_206F_206A_206A_206A_200F_202C_206D_206A_200E_206F_200E_206A_202E_202B_206C_200E_206C_202E(repeatValue, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(732921439u)))
						{
							num21 = 1612368316;
							num22 = num21;
						}
						else
						{
							num21 = 791537920;
							num22 = num21;
						}
						num2 = num21 ^ ((int)num3 * -1278339367);
						continue;
					}
					case 14u:
						num2 = (int)((num3 * 2138948133) ^ 0x77F970D9);
						continue;
					case 25u:
						num = int.MaxValue;
						num2 = ((int)num3 * -651969576) ^ 0x6C802144;
						continue;
					case 9u:
					{
						int num12;
						if (num11 <= 0)
						{
							num2 = -1073505184;
							num12 = num2;
						}
						else
						{
							num2 = -634101111;
							num12 = num2;
						}
						continue;
					}
					case 7u:
						num11 = int.Parse(array[2]);
						num2 = ((int)num3 * -701316771) ^ 0x399AD746;
						continue;
					case 22u:
						num2 = ((int)num3 * -442321041) ^ 0x41094C10;
						continue;
					case 2u:
						num11 = 1;
						num2 = (int)(num3 * 179578439) ^ -1104954116;
						continue;
					case 4u:
					{
						int num27;
						int num28;
						if (_202E_206C_200B_206A_206B_200B_200E_202A_206B_202A_206C_202E_200F_202D_206F_202E_202B_200D_200C_202D_202B_202E_200D_200B_202A_202D_200B_200C_206E_200F_200D_206D_202D_200E_206B_206B_206E_202D_200B_200E_202E(repeatValue))
						{
							num27 = -1577279460;
							num28 = num27;
						}
						else
						{
							num27 = -1682840754;
							num28 = num27;
						}
						num2 = num27 ^ ((int)num3 * -1518149964);
						continue;
					}
					case 8u:
						return false;
					case 32u:
					{
						int num18;
						int num19;
						if (num <= num11)
						{
							num18 = 326741976;
							num19 = num18;
						}
						else
						{
							num18 = 1888360680;
							num19 = num18;
						}
						num2 = num18 ^ (int)(num3 * 718415479);
						continue;
					}
					case 0u:
					{
						int num17;
						if (_200C_206C_200C_200B_206E_206A_206F_200B_202D_206D_206B_202C_206A_202C_202C_202B_206C_200C_202D_202A_202D_200C_206C_202C_206B_206A_202D_200F_206F_200F_206D_200E_206C_200E_206C_202D_202D_202A_202D_206D_202E(repeatValue, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(886536633u)))
						{
							num2 = -977012114;
							num17 = num2;
						}
						else
						{
							num2 = -1693102225;
							num17 = num2;
						}
						continue;
					}
					case 5u:
						num = 1;
						num2 = ((int)num3 * -1476740372) ^ 0x622B3F0F;
						continue;
					case 17u:
						return false;
					case 10u:
					{
						array = _206B_200B_200E_206C_202E_202D_206A_206D_206D_202B_206C_202B_200D_200C_206D_202B_206E_206F_200B_200F_202B_206E_206F_200C_202E_206A_200C_206F_200C_200F_206C_202D_200F_202E_202D_202E_206F_202E_202D_206E_202E(RuntimeData.Instance.KeyValues[value], new char[1] { '#' });
						int num8;
						int num9;
						if (array.Length < 3)
						{
							num8 = 434309034;
							num9 = num8;
						}
						else
						{
							num8 = 2007122232;
							num9 = num8;
						}
						num2 = num8 ^ (int)(num3 * 557583587);
						continue;
					}
					case 33u:
					{
						int num29;
						int num30;
						if (num <= battleCount)
						{
							num29 = -1143163226;
							num30 = num29;
						}
						else
						{
							num29 = -2020479416;
							num30 = num29;
						}
						num2 = num29 ^ ((int)num3 * -751339075);
						continue;
					}
					case 31u:
					{
						int num25;
						int num26;
						if (!_206D_202B_202D_202C_206D_202B_200B_206F_206A_200B_200F_200C_200B_202D_202C_206D_206B_206F_200D_202A_200D_200B_206C_206F_206A_206A_206A_200F_202C_206D_206A_200E_206F_200E_206A_202E_202B_206C_200E_206C_202E(type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(511095977u)))
						{
							num25 = -256015849;
							num26 = num25;
						}
						else
						{
							num25 = -1240439288;
							num26 = num25;
						}
						num2 = num25 ^ (int)(num3 * 943060678);
						continue;
					}
					case 21u:
					{
						int num24;
						if (num > 0)
						{
							num2 = -1232272070;
							num24 = num2;
						}
						else
						{
							num2 = -156012455;
							num24 = num2;
						}
						continue;
					}
					case 26u:
					{
						int num20;
						if (!Tools.ProbabilityTest(probability / 100.0))
						{
							num2 = -893641678;
							num20 = num2;
						}
						else
						{
							num2 = -365299163;
							num20 = num2;
						}
						continue;
					}
					case 1u:
						if (!RuntimeData.Instance.KeyValues.ContainsKey(value))
						{
							num2 = (int)(num3 * 89057716) ^ -2127805140;
							continue;
						}
						num15 = 1;
						goto IL_03df;
					case 12u:
					{
						int num16;
						if (!_206D_202B_202D_202C_206D_202B_200B_206F_206A_200B_200F_200C_200B_202D_202C_206D_206B_206F_200D_202A_200D_200B_206C_206F_206A_206A_206A_200F_202C_206D_206A_200E_206F_200E_206A_202E_202B_206C_200E_206C_202E(type, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3957091040u)))
						{
							num2 = -156012455;
							num16 = num2;
						}
						else
						{
							num2 = -706850744;
							num16 = num2;
						}
						continue;
					}
					case 27u:
						num15 = 0;
						goto IL_03df;
					case 11u:
						s = _200F_206F_206F_200B_202C_206E_200E_200B_202A_206A_206C_206B_206C_206B_200E_202B_202E_200B_206A_200D_202B_206E_202D_200B_200D_200D_202B_202C_202D_200E_202D_200D_206B_202D_202C_206F_200B_206C_206B_202E_202E(repeatValue, 0, 5);
						num2 = (int)((num3 * 327299595) ^ 0x4EA5BCE6);
						continue;
					case 18u:
						num2 = (int)(num3 * 1751387875) ^ -1968375690;
						continue;
					case 24u:
					{
						int num13;
						int num14;
						if (num11 < 1)
						{
							num13 = -1627042013;
							num14 = num13;
						}
						else
						{
							num13 = -608586656;
							num14 = num13;
						}
						num2 = num13 ^ (int)(num3 * 1485642214);
						continue;
					}
					case 16u:
					{
						num = (int)double.Parse(s);
						int num10;
						if (num != 0)
						{
							num2 = -1236182212;
							num10 = num2;
						}
						else
						{
							num2 = -270897150;
							num10 = num2;
						}
						continue;
					}
					case 3u:
					{
						int num7;
						if (num != -1)
						{
							num2 = -461738980;
							num7 = num2;
						}
						else
						{
							num2 = -325788618;
							num7 = num2;
						}
						continue;
					}
					default:
						{
							using (List<Condition>.Enumerator enumerator = Conditions.GetEnumerator())
							{
								while (true)
								{
									IL_04e4:
									int num4;
									int num5;
									if (enumerator.MoveNext())
									{
										num4 = -1857495153;
										num5 = num4;
									}
									else
									{
										num4 = -400923341;
										num5 = num4;
									}
									while (true)
									{
										switch ((num3 = (uint)(num4 ^ -973005913)) % 5)
										{
										case 4u:
											num4 = -1857495153;
											continue;
										default:
											goto end_IL_048a;
										case 1u:
										{
											int num6;
											if (!TriggerLogic.judge(enumerator.Current))
											{
												num4 = -677859408;
												num6 = num4;
											}
											else
											{
												num4 = -1190488246;
												num6 = num4;
											}
											continue;
										}
										case 3u:
											return false;
										case 0u:
											break;
										case 2u:
											goto end_IL_048a;
										}
										goto IL_04e4;
										continue;
										end_IL_048a:
										break;
									}
									break;
								}
							}
							return true;
						}
						IL_03df:
						num11 = num15;
						num2 = -2097843475;
						continue;
					}
					break;
				}
			}
		}
	}

	static double _200F_202C_202D_206C_206A_206E_202A_202B_206C_202D_202A_202E_200B_202B_206A_206F_202B_206D_200F_200B_206E_206E_200C_206E_200F_200D_200D_206A_200E_206C_202A_200C_202E_200F_202D_206D_206E_200F_202A_202B_202E(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	static bool _206D_202B_202D_202C_206D_202B_200B_206F_206A_200B_200F_200C_200B_202D_202C_206D_206B_206F_200D_202A_200D_200B_206C_206F_206A_206A_206A_200F_202C_206D_206A_200E_206F_200E_206A_202E_202B_206C_200E_206C_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static bool _200C_206C_200C_200B_206E_206A_206F_200B_202D_206D_206B_202C_206A_202C_202C_202B_206C_200C_202D_202A_202D_200C_206C_202C_206B_206A_202D_200F_206F_200F_206D_200E_206C_200E_206C_202D_202D_202A_202D_206D_202E(string P_0, string P_1)
	{
		return P_0.StartsWith(P_1);
	}

	static bool _202E_206C_200B_206A_206B_200B_200E_202A_206B_202A_206C_202E_200F_202D_206F_202E_202B_200D_200C_202D_202B_202E_200D_200B_202A_202D_200B_200C_206E_200F_200D_206D_202D_200E_206B_206B_206E_202D_200B_200E_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static string _200F_206F_206F_200B_202C_206E_200E_200B_202A_206A_206C_206B_206C_206B_200E_202B_202E_200B_206A_200D_202B_206E_202D_200B_200D_200D_202B_202C_202D_200E_202D_200D_206B_202D_202C_206F_200B_206C_206B_202E_202E(string P_0, int P_1, int P_2)
	{
		return P_0.Remove(P_1, P_2);
	}

	static string[] _206B_200B_200E_206C_202E_202D_206A_206D_206D_202B_206C_202B_200D_200C_206D_202B_206E_206F_200B_200F_202B_206E_206F_200C_202E_206A_200C_206F_200C_200F_206C_202D_200F_202E_202D_202E_206F_202E_202D_206E_202E(string P_0, char[] P_1)
	{
		return P_0.Split(P_1);
	}
}
