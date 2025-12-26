using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace JyGame;

[XmlType("trigger")]
public class GlobalTrigger : BasePojo
{
	private string _206E_200B_202E_200B_200C_202A_206B_206F_202A_206A_202C_202A_206E_206B_206B_202A_202E_206D_206C_200D_202B_206F_206A_202C_206C_206D_202A_202A_202B_200F_206B_202C_206E_206D_206C_200C_206E_206D_202E_202C_202E;

	[XmlAttribute]
	public string story;

	[XmlElement("condition")]
	public List<Condition> Conditions;

	[XmlAttribute]
	public string repeat;

	public override string PK => _206E_200B_202E_200B_200C_202A_206B_206F_202A_206A_202C_202A_206E_206B_206B_202A_202E_206D_206C_200D_202B_206F_206A_202C_206C_206D_202A_202A_202B_200F_206B_202C_206E_206D_206C_200C_206E_206D_202E_202C_202E;

	public GlobalTrigger()
	{
		_206E_200B_202E_200B_200C_202A_206B_206F_202A_206A_202C_202A_206E_206B_206B_202A_202E_206D_206C_200D_202B_206F_206A_202C_206C_206D_202A_202A_202B_200F_206B_202C_206E_206D_206C_200C_206E_206D_202E_202C_202E = Guid.NewGuid().ToString();
	}

	public static GlobalTrigger GetCurrentTrigger()
	{
		if (RuntimeData.Instance.HasFlag(CommonSettings.flagNoGlobalEvent))
		{
			while (true)
			{
				uint num;
				switch ((num = 819445696u) % 3)
				{
				case 2u:
					continue;
				case 1u:
					return null;
				}
				break;
			}
		}
		IEnumerator<GlobalTrigger> enumerator = ResourceManager.GetAll<GlobalTrigger>().GetEnumerator();
		try
		{
			GlobalTrigger current = default(GlobalTrigger);
			int num10 = default(int);
			bool flag = default(bool);
			string[] array = default(string[]);
			int num7 = default(int);
			Condition current2 = default(Condition);
			while (true)
			{
				uint num;
				if (_206C_202E_206B_202E_200C_206A_200D_206E_200D_200F_206B_200E_200C_200F_200F_202E_200E_202E_202C_206A_202B_202C_202B_206E_202B_206E_202B_206B_202B_202C_202C_202E_200C_206D_200C_206C_200F_200F_202B_202A_202E((IEnumerator)enumerator))
				{
					while (true)
					{
						current = enumerator.Current;
						int num2 = -200053188;
						while (true)
						{
							switch ((num = (uint)(num2 ^ -669933465)) % 23)
							{
							case 0u:
								num2 = -646068935;
								continue;
							case 11u:
								num10 = 1;
								num2 = ((int)num * -1906712001) ^ -39824608;
								continue;
							case 5u:
								break;
							case 13u:
							{
								int num17;
								int num18;
								if (num10 != 0)
								{
									num17 = -677641024;
									num18 = num17;
								}
								else
								{
									num17 = -1809673113;
									num18 = num17;
								}
								num2 = num17 ^ (int)(num * 1629971664);
								continue;
							}
							case 18u:
							{
								int num5;
								int num6;
								if (!_200F_202E_206D_202C_200B_200E_200C_202B_202C_200F_200E_206F_206D_200B_206B_200C_206E_200E_202B_206C_200F_200D_206E_206A_200B_202C_202D_202E_202C_206C_200F_202B_202D_200E_200D_206E_202D_200B_206D_200F_202E(current.repeat))
								{
									num5 = 1073718842;
									num6 = num5;
								}
								else
								{
									num5 = 2143354300;
									num6 = num5;
								}
								num2 = num5 ^ (int)(num * 1148089642);
								continue;
							}
							case 3u:
								flag = true;
								num2 = -1460742254;
								continue;
							case 19u:
								goto IL_0148;
							case 20u:
								array = _206D_200F_200C_202A_206C_206C_202A_202B_206C_200F_200C_200F_206A_200C_200E_206F_206D_206F_206E_200E_202B_206B_202B_200E_200B_200F_206F_200D_202C_200E_202D_206C_202E_202B_200C_202A_200B_200E_202D_206D_202E(RuntimeData.Instance.KeyValues[current.story], new char[1] { '#' });
								num2 = ((int)num * -1270130349) ^ -1042326936;
								continue;
							case 2u:
								flag = false;
								num2 = (int)(num * 1058616588) ^ -1034681082;
								continue;
							case 10u:
							{
								int num13;
								int num14;
								if (num10 <= 0)
								{
									num13 = 1897496611;
									num14 = num13;
								}
								else
								{
									num13 = 1523402436;
									num14 = num13;
								}
								num2 = num13 ^ (int)(num * 204672169);
								continue;
							}
							case 8u:
							{
								int num8;
								int num9;
								if (num7 < 1)
								{
									num8 = 644239222;
									num9 = num8;
								}
								else
								{
									num8 = 1006393080;
									num9 = num8;
								}
								num2 = num8 ^ (int)(num * 2072443436);
								continue;
							}
							case 14u:
								goto IL_01f8;
							case 15u:
							{
								int num15;
								int num16;
								if (!_200E_202C_200C_206C_200D_202B_202C_206B_206E_206E_200F_200B_200E_202A_206C_200B_206A_200F_202B_202C_200B_200C_200C_200E_206A_202D_202B_202C_200C_206C_206B_206E_200B_206E_202A_206E_206B_206C_206E_202D_202E(current.repeat, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1964736494u)))
								{
									num15 = -210776932;
									num16 = num15;
								}
								else
								{
									num15 = -846485401;
									num16 = num15;
								}
								num2 = num15 ^ ((int)num * -1445902612);
								continue;
							}
							case 16u:
								goto end_IL_005b;
							case 4u:
								num7 = int.Parse(array[2]);
								num2 = (int)((num * 1316483237) ^ 0x14BD122A);
								continue;
							case 6u:
								num10 = 1;
								num2 = (int)((num * 451874616) ^ 0x10103FA1);
								continue;
							case 17u:
								goto IL_028f;
							case 9u:
							{
								int num11;
								int num12;
								if (num10 != 1)
								{
									num11 = 873842516;
									num12 = num11;
								}
								else
								{
									num11 = 1955005372;
									num12 = num11;
								}
								num2 = num11 ^ (int)(num * 1433859070);
								continue;
							}
							case 22u:
								num10 = (int)double.Parse(current.repeat);
								num2 = (int)(num * 627278980) ^ -93681604;
								continue;
							case 7u:
								num7 = 1;
								num2 = (int)(num * 517447391) ^ -869310985;
								continue;
							case 1u:
							{
								int num3;
								int num4;
								if (array.Length < 3)
								{
									num3 = -2125927128;
									num4 = num3;
								}
								else
								{
									num3 = -637719001;
									num4 = num3;
								}
								num2 = num3 ^ (int)(num * 2029091026);
								continue;
							}
							case 12u:
								goto IL_0337;
							default:
								goto IL_0350;
							}
							if (!flag)
							{
								goto end_IL_024b;
							}
							num2 = -2031476496;
							continue;
							IL_0350:
							using (List<Condition>.Enumerator enumerator2 = current.Conditions.GetEnumerator())
							{
								while (true)
								{
									IL_0399:
									int num19;
									int num20;
									if (!enumerator2.MoveNext())
									{
										num19 = -781935703;
										num20 = num19;
									}
									else
									{
										num19 = -625066374;
										num20 = num19;
									}
									while (true)
									{
										switch ((num = (uint)(num19 ^ -669933465)) % 8)
										{
										case 2u:
											num19 = -625066374;
											continue;
										default:
											goto end_IL_0364;
										case 0u:
											break;
										case 3u:
										{
											int num23;
											int num24;
											if (current2 != null)
											{
												num23 = -2043295518;
												num24 = num23;
											}
											else
											{
												num23 = -1344462130;
												num24 = num23;
											}
											num19 = num23 ^ (int)(num * 1510081619);
											continue;
										}
										case 1u:
											goto end_IL_0364;
										case 4u:
										{
											int num21;
											int num22;
											if (TriggerLogic.judge(current2))
											{
												num21 = 2095028247;
												num22 = num21;
											}
											else
											{
												num21 = 1784332320;
												num22 = num21;
											}
											num19 = num21 ^ ((int)num * -1120341850);
											continue;
										}
										case 7u:
											flag = false;
											num19 = (int)((num * 1310404451) ^ 0x31C3133);
											continue;
										case 5u:
											current2 = enumerator2.Current;
											num19 = -270931332;
											continue;
										case 6u:
											goto end_IL_0364;
										}
										goto IL_0399;
										continue;
										end_IL_0364:
										break;
									}
									break;
								}
							}
							goto IL_0441;
							IL_0337:
							int num25;
							if (num10 <= num7)
							{
								num2 = -1359609147;
								num25 = num2;
							}
							else
							{
								num2 = -2062734178;
								num25 = num2;
							}
							continue;
							IL_0441:
							if (!flag)
							{
								goto end_IL_024b;
							}
							goto IL_0444;
							IL_01f8:
							int num26 = 0;
							goto IL_01fc;
							IL_028f:
							if (RuntimeData.Instance.KeyValues.ContainsKey(current.story))
							{
								num26 = 1;
								goto IL_01fc;
							}
							num2 = (int)(num * 8930709) ^ -1726115828;
							continue;
							IL_0148:
							if (current.Conditions != null)
							{
								num2 = ((int)num * -194293986) ^ -161211968;
								continue;
							}
							goto IL_0441;
							IL_01fc:
							num7 = num26;
							int num27;
							if (num7 <= 0)
							{
								num2 = -1626760620;
								num27 = num2;
							}
							else
							{
								num2 = -1089352853;
								num27 = num2;
							}
							continue;
							end_IL_005b:
							break;
						}
						continue;
						end_IL_024b:
						break;
					}
					continue;
				}
				int num28 = -832772715;
				goto IL_0449;
				IL_0444:
				num28 = -2085757410;
				goto IL_0449;
				IL_0449:
				switch ((num = (uint)(num28 ^ -669933465)) % 4)
				{
				case 0u:
					break;
				default:
					goto end_IL_0480;
				case 1u:
					return current;
				case 3u:
					continue;
				case 2u:
					goto end_IL_0480;
				}
				goto IL_0444;
				continue;
				end_IL_0480:
				break;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_0497:
					int num29 = -1179016795;
					while (true)
					{
						uint num;
						switch ((num = (uint)(num29 ^ -669933465)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_049c;
						case 1u:
							goto IL_04ba;
						case 2u:
							goto end_IL_049c;
						}
						goto IL_0497;
						IL_04ba:
						_200F_202A_206E_206E_206C_202D_200B_202A_202B_206F_206C_202B_202E_200E_200C_200E_202A_206D_206D_206A_206E_202E_206A_200B_200D_206C_202C_206F_206E_202E_200F_206F_206E_202A_206B_206C_202C_202D_206A_202C_202E((IDisposable)enumerator);
						num29 = (int)(num * 174410152) ^ -861493503;
						continue;
						end_IL_049c:
						break;
					}
					break;
				}
			}
		}
		return null;
	}

	static bool _200F_202E_206D_202C_200B_200E_200C_202B_202C_200F_200E_206F_206D_200B_206B_200C_206E_200E_202B_206C_200F_200D_206E_206A_200B_202C_202D_202E_202C_206C_200F_202B_202D_200E_200D_206E_202D_200B_206D_200F_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static bool _200E_202C_200C_206C_200D_202B_202C_206B_206E_206E_200F_200B_200E_202A_206C_200B_206A_200F_202B_202C_200B_200C_200C_200E_206A_202D_202B_202C_200C_206C_206B_206E_200B_206E_202A_206E_206B_206C_206E_202D_202E(string P_0, string P_1)
	{
		return P_0 != P_1;
	}

	static string[] _206D_200F_200C_202A_206C_206C_202A_202B_206C_200F_200C_200F_206A_200C_200E_206F_206D_206F_206E_200E_202B_206B_202B_200E_200B_200F_206F_200D_202C_200E_202D_206C_202E_202B_200C_202A_200B_200E_202D_206D_202E(string P_0, char[] P_1)
	{
		return P_0.Split(P_1);
	}

	static bool _206C_202E_206B_202E_200C_206A_200D_206E_200D_200F_206B_200E_200C_200F_200F_202E_200E_202E_202C_206A_202B_202C_202B_206E_202B_206E_202B_206B_202B_202C_202C_202E_200C_206D_200C_206C_200F_200F_202B_202A_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _200F_202A_206E_206E_206C_202D_200B_202A_202B_206F_206C_202B_202E_200E_200C_200E_202A_206D_206D_206A_206E_202E_206A_200B_200D_206C_202C_206F_206E_202E_200F_206F_206E_202A_206B_206C_202C_202D_206A_202C_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}
}
