using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace JyGame;

public class ResourceChecker
{
	public static bool CheckAll(ILogger logger)
	{
		bool result = true;
		logger.LogError(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2615361930u));
		int num = 0;
		try
		{
			num = 1;
			List<string> list = new List<string>();
			IEnumerator<Resource> enumerator = ResourceManager.GetAll<Resource>().GetEnumerator();
			try
			{
				Resource current = default(Resource);
				while (true)
				{
					IL_009c:
					int num2;
					int num3;
					if (!_202E_202B_200B_202C_202B_202E_206B_202B_202B_200E_202E_206D_206D_206A_200E_200B_202A_206E_206C_202E_206E_206B_200D_202E_206C_202A_202D_200F_200E_200D_202A_202D_206F_206E_200C_200B_200D_206E_202D_206F_202E((IEnumerator)enumerator))
					{
						num2 = 915184821;
						num3 = num2;
					}
					else
					{
						num2 = 745271108;
						num3 = num2;
					}
					while (true)
					{
						uint num4;
						switch ((num4 = (uint)(num2 ^ 0x1406650B)) % 6)
						{
						case 4u:
							num2 = 745271108;
							continue;
						default:
							goto end_IL_002e;
						case 1u:
							current = enumerator.Current;
							num2 = 671587182;
							continue;
						case 5u:
						{
							int num5;
							int num6;
							if (!_206D_200E_206E_200C_202D_202E_206C_200F_206E_202B_200F_200F_200E_200C_200F_202C_202E_200F_202C_206B_200C_206D_200F_206A_206D_206E_200F_202D_202A_200F_200E_202B_200C_206C_200D_206F_200D_206A_206F_206A_202E(current.Key, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2117797000u)))
							{
								num5 = 916904228;
								num6 = num5;
							}
							else
							{
								num5 = 1507077489;
								num6 = num5;
							}
							num2 = num5 ^ (int)(num4 * 797277177);
							continue;
						}
						case 0u:
							break;
						case 3u:
							list.Add(_200B_200E_206C_200F_202D_206B_206B_200D_206E_200C_202C_200F_202E_202D_202A_206C_206F_200D_206D_206B_202A_200E_206F_202C_202B_200B_200E_206C_200C_200C_200E_206B_206C_206D_206F_202C_202D_206B_202D_202E_202E(current.Key, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2117797000u), string.Empty));
							num2 = (int)(num4 * 568048250) ^ -1141992497;
							continue;
						case 2u:
							goto end_IL_002e;
						}
						goto IL_009c;
						continue;
						end_IL_002e:
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
						IL_00f1:
						int num7 = 1325306086;
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)(num7 ^ 0x1406650B)) % 3)
							{
							case 0u:
								break;
							default:
								goto end_IL_00f6;
							case 1u:
								goto IL_0114;
							case 2u:
								goto end_IL_00f6;
							}
							goto IL_00f1;
							IL_0114:
							_202A_200C_200F_202D_206F_206F_202E_202E_202B_200E_202B_202D_206E_202B_206E_206D_206C_200F_206F_200B_200E_206D_206E_206C_202C_206D_202C_200D_200D_202C_202E_202B_200C_206E_206A_200D_206A_200E_200B_202A_202E((IDisposable)enumerator);
							num7 = (int)((num4 * 1563723306) ^ 0xF230CB6);
							continue;
							end_IL_00f6:
							break;
						}
						break;
					}
				}
			}
			IEnumerator<Story> enumerator2 = ResourceManager.GetAll<Story>().GetEnumerator();
			try
			{
				Story current2 = default(Story);
				bool flag = default(bool);
				int num13 = default(int);
				string[] array = default(string[]);
				StoryAction current3 = default(StoryAction);
				string value = default(string);
				string text3 = default(string);
				string text2 = default(string);
				Condition current5 = default(Condition);
				bool flag2 = default(bool);
				string current6 = default(string);
				string text4 = default(string);
				string current7 = default(string);
				int num62 = default(int);
				while (true)
				{
					IL_0f87:
					List<string> list2;
					if (enumerator2.MoveNext())
					{
						string text;
						while (true)
						{
							current2 = enumerator2.Current;
							text = string.Empty;
							int num8 = 674621689;
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)(num8 ^ 0x1406650B)) % 4)
								{
								case 0u:
									num8 = 1418694682;
									continue;
								case 1u:
									break;
								case 2u:
									flag = false;
									num8 = ((int)num4 * -1457966846) ^ -667281168;
									continue;
								default:
									goto end_IL_0163;
								}
								break;
							}
							continue;
							end_IL_0163:
							break;
						}
						using (List<StoryAction>.Enumerator enumerator3 = current2.Actions.GetEnumerator())
						{
							while (true)
							{
								IL_02b6:
								int num9;
								int num10;
								if (enumerator3.MoveNext())
								{
									num9 = 971964132;
									num10 = num9;
								}
								else
								{
									num9 = 1303615184;
									num10 = num9;
								}
								while (true)
								{
									uint num4;
									switch ((num4 = (uint)(num9 ^ 0x1406650B)) % 41)
									{
									case 32u:
										num9 = 971964132;
										continue;
									default:
										goto end_IL_01a5;
									case 14u:
										num13 += 2;
										num9 = 1660348700;
										continue;
									case 28u:
									{
										int num32;
										if (array.Length < 2)
										{
											num9 = 713336471;
											num32 = num9;
										}
										else
										{
											num9 = 352142680;
											num32 = num9;
										}
										continue;
									}
									case 27u:
									{
										int num17;
										if (!(current3.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3192674775u)))
										{
											num9 = 1844924910;
											num17 = num9;
										}
										else
										{
											num9 = 1757257604;
											num17 = num9;
										}
										continue;
									}
									case 12u:
										break;
									case 35u:
										logger.LogError(string.Format(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3847480798u), current2.Name, value));
										num9 = ((int)num4 * -384831664) ^ -1752585606;
										continue;
									case 34u:
										logger.LogError(string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3059089567u), current2.Name, text3));
										num9 = ((int)num4 * -2088863747) ^ 0x2467B02D;
										continue;
									case 26u:
										text2 = array[0];
										num9 = 3429745;
										continue;
									case 22u:
									{
										int num23;
										int num24;
										if (!_206C_202A_206E_202E_202A_202D_200F_202B_202E_202D_202B_206E_206C_200D_206C_206D_200E_200F_206E_200C_200C_202E_202A_202B_202D_206B_202D_200D_206A_206C_200B_200B_200C_202A_200E_206C_202E_200C_206B_202B_202E(current3.type, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(862846315u)))
										{
											num23 = -1266824438;
											num24 = num23;
										}
										else
										{
											num23 = -2088924813;
											num24 = num23;
										}
										num9 = num23 ^ (int)(num4 * 2072980470);
										continue;
									}
									case 24u:
										num9 = (int)(num4 * 2026102943) ^ -613055315;
										continue;
									case 9u:
									{
										int num33;
										int num34;
										if (_206C_202A_206E_202E_202A_202D_200F_202B_202E_202D_202B_206E_206C_200D_206C_206D_200E_200F_206E_200C_200C_202E_202A_202B_202D_206B_202D_200D_206A_206C_200B_200B_200C_202A_200E_206C_202E_200C_206B_202B_202E(current3.type, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4071251743u)))
										{
											num33 = 480894378;
											num34 = num33;
										}
										else
										{
											num33 = 316300657;
											num34 = num33;
										}
										num9 = num33 ^ (int)(num4 * 1048506389);
										continue;
									}
									case 6u:
									{
										int num28;
										int num29;
										if (array.Length % 2 == 1)
										{
											num28 = -863604643;
											num29 = num28;
										}
										else
										{
											num28 = -946900223;
											num29 = num28;
										}
										num9 = num28 ^ (int)(num4 * 1741103437);
										continue;
									}
									case 31u:
										logger.LogError(_200C_200E_200D_206C_200D_200C_206F_202D_206C_202D_200E_202B_202E_202B_206C_200F_202E_202E_206E_202C_202A_202C_200B_206E_206E_202D_202A_200C_206D_206F_206C_200D_200E_202D_202D_206C_206A_206A_206D_206D_202E(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3478856077u), (object)current2.Name, (object)current3.type, (object)current3.value));
										num9 = (int)(num4 * 703745873) ^ -590173320;
										continue;
									case 23u:
										text = current3.value;
										num9 = (int)((num4 * 1643967980) ^ 0x2D8CC678);
										continue;
									case 10u:
									{
										int num22;
										if (ResourceManager.Get<Resource>(_202E_206F_206E_206B_202A_206C_206A_206F_200C_206C_202C_202A_206D_200E_202C_200D_202C_206F_200C_200F_206E_202E_206D_202C_200C_200F_200E_206A_206B_206F_200C_202C_206D_200E_202A_206A_200B_202C_200C_202C_202E(current3.value, new char[1] { '#' })[0]) != null)
										{
											num9 = 1844924910;
											num22 = num9;
										}
										else
										{
											num9 = 1170478907;
											num22 = num9;
										}
										continue;
									}
									case 11u:
										result = false;
										num9 = (int)((num4 * 1237767236) ^ 0xA9FB9F6);
										continue;
									case 30u:
										result = false;
										num9 = ((int)num4 * -1731609258) ^ 0x7AE7C800;
										continue;
									case 4u:
									{
										int num16;
										if (!(current3.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2413901991u)))
										{
											num9 = 2113021884;
											num16 = num9;
										}
										else
										{
											num9 = 141193921;
											num16 = num9;
										}
										continue;
									}
									case 29u:
										logger.LogError(string.Format(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(581657342u), current2.Name, array.Length.ToString()));
										result = false;
										num9 = (int)((num4 * 1718503557) ^ 0x3DFA0E28);
										continue;
									case 8u:
									{
										int num12;
										if (!_206C_202A_206E_202E_202A_202D_200F_202B_202E_202D_202B_206E_206C_200D_206C_206D_200E_200F_206E_200C_200C_202E_202A_202B_202D_206B_202D_200D_206A_206C_200B_200B_200C_202A_200E_206C_202E_200C_206B_202B_202E(current3.type, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2791571399u)))
										{
											num9 = 1882806816;
											num12 = num9;
										}
										else
										{
											num9 = 1114227918;
											num12 = num9;
										}
										continue;
									}
									case 20u:
										result = false;
										num9 = (int)(num4 * 1012790848) ^ -2072275972;
										continue;
									case 36u:
									{
										value = current3.value;
										int num30;
										int num31;
										if (!list.Contains(value))
										{
											num30 = 1522730986;
											num31 = num30;
										}
										else
										{
											num30 = 1576964096;
											num31 = num30;
										}
										num9 = num30 ^ ((int)num4 * -2135538773);
										continue;
									}
									case 19u:
									{
										int num26;
										int num27;
										if (ResourceManager.Get<Item>(text3) != null)
										{
											num26 = 317541623;
											num27 = num26;
										}
										else
										{
											num26 = 1553779963;
											num27 = num26;
										}
										num9 = num26 ^ ((int)num4 * -220602853);
										continue;
									}
									case 5u:
									{
										int num25;
										if (num13 >= array.Length - 1)
										{
											num9 = 531799334;
											num25 = num9;
										}
										else
										{
											num9 = 571753546;
											num25 = num9;
										}
										continue;
									}
									case 40u:
										result = false;
										num9 = ((int)num4 * -249980593) ^ 0x1119E65B;
										continue;
									case 25u:
										text3 = array[num13];
										num9 = 80834762;
										continue;
									case 7u:
										num9 = ((int)num4 * -1711031890) ^ -112153912;
										continue;
									case 21u:
									{
										int num20;
										int num21;
										if (ResourceManager.Get<Battle>(current3.value) != null)
										{
											num20 = -737012747;
											num21 = num20;
										}
										else
										{
											num20 = -1073400572;
											num21 = num20;
										}
										num9 = num20 ^ ((int)num4 * -329107371);
										continue;
									}
									case 37u:
										num9 = ((int)num4 * -726633178) ^ 0x38CE3640;
										continue;
									case 3u:
										logger.LogError(string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3059089567u), current2.Name, text2));
										num9 = ((int)num4 * -1211827103) ^ 0x59A8902;
										continue;
									case 16u:
										logger.LogError(_202B_202E_200F_200C_200F_202E_200B_206A_202C_200F_200C_202E_200B_206B_206D_206E_202D_206B_206C_206D_200B_200B_200D_206C_202A_202E_206A_206B_200E_206F_202A_206A_200E_200B_200C_200D_206C_200C_200C_206C_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(798400446u), (object)current2.Name, (object)current3.value));
										result = false;
										num9 = (int)(num4 * 692128554) ^ -109388851;
										continue;
									case 18u:
									{
										int num18;
										int num19;
										if (ResourceManager.Get<Item>(text2) != null)
										{
											num18 = -1715152410;
											num19 = num18;
										}
										else
										{
											num18 = -1472919284;
											num19 = num18;
										}
										num9 = num18 ^ ((int)num4 * -1520299948);
										continue;
									}
									case 38u:
										num9 = ((int)num4 * -1732786820) ^ 0x51060726;
										continue;
									case 2u:
										current3 = enumerator3.Current;
										num9 = 2015715808;
										continue;
									case 17u:
									{
										int num14;
										int num15;
										if (array.Length >= 2)
										{
											num14 = 2111035851;
											num15 = num14;
										}
										else
										{
											num14 = 1230733217;
											num15 = num14;
										}
										num9 = num14 ^ (int)(num4 * 137109665);
										continue;
									}
									case 15u:
										array = _202E_206F_206E_206B_202A_206C_206A_206F_200C_206C_202C_202A_206D_200E_202C_200D_202C_206F_200C_200F_206E_202E_206D_202C_200C_200F_200E_206A_206B_206F_200C_202C_206D_200E_202A_206A_200B_202C_200C_202C_202E(current3.value, new char[1] { '#' });
										num9 = (int)(num4 * 1968624489) ^ -1680077442;
										continue;
									case 1u:
										num13 = 0;
										num9 = ((int)num4 * -826457773) ^ -653171467;
										continue;
									case 13u:
									{
										int num11;
										if (!_206C_202A_206E_202E_202A_202D_200F_202B_202E_202D_202B_206E_206C_200D_206C_206D_200E_200F_206E_200C_200C_202E_202A_202B_202D_206B_202D_200D_206A_206C_200B_200B_200C_202A_200E_206C_202E_200C_206B_202B_202E(current3.type, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(543921849u)))
										{
											num9 = 923404803;
											num11 = num9;
										}
										else
										{
											num9 = 518502078;
											num11 = num9;
										}
										continue;
									}
									case 0u:
										num9 = (int)(num4 * 1984931988) ^ -269887966;
										continue;
									case 39u:
										flag = true;
										num9 = ((int)num4 * -303179004) ^ 0x765C6ED2;
										continue;
									case 33u:
										goto end_IL_01a5;
									}
									goto IL_02b6;
									continue;
									end_IL_01a5:
									break;
								}
								break;
							}
						}
						list2 = new List<string>();
						using (List<StoryResult>.Enumerator enumerator4 = current2.Results.GetEnumerator())
						{
							while (enumerator4.MoveNext())
							{
								while (true)
								{
									StoryResult current4 = enumerator4.Current;
									int num35 = 2084941082;
									while (true)
									{
										uint num4;
										switch ((num4 = (uint)(num35 ^ 0x1406650B)) % 12)
										{
										case 0u:
											num35 = 732596872;
											continue;
										case 10u:
											logger.LogError(string.Format(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3633663712u), current2.Name, current4.value));
											num35 = (int)((num4 * 1991929718) ^ 0x163A1135);
											continue;
										case 8u:
											result = false;
											num35 = ((int)num4 * -1222233206) ^ 0x53E6DB6;
											continue;
										case 6u:
											result = false;
											num35 = ((int)num4 * -885945206) ^ 0x10CE92A2;
											continue;
										case 11u:
											break;
										case 5u:
											goto IL_088a;
										case 1u:
										{
											int num38;
											int num39;
											if (!(current4.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(451352088u)))
											{
												num38 = 1055150008;
												num39 = num38;
											}
											else
											{
												num38 = 789894362;
												num39 = num38;
											}
											num35 = num38 ^ (int)(num4 * 1296766782);
											continue;
										}
										case 7u:
										{
											int num40;
											int num41;
											if (ResourceManager.Get<Map>(current4.value) == null)
											{
												num40 = 1022723374;
												num41 = num40;
											}
											else
											{
												num40 = 919491073;
												num41 = num40;
											}
											num35 = num40 ^ (int)(num4 * 324705377);
											continue;
										}
										case 2u:
											logger.LogError(string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(68445231u), current2.Name, current4.value));
											num35 = ((int)num4 * -1926516939) ^ -60450183;
											continue;
										case 9u:
											goto IL_094c;
										case 3u:
										{
											int num36;
											int num37;
											if (ResourceManager.Get<Story>(current4.value) == null)
											{
												num36 = 656165784;
												num37 = num36;
											}
											else
											{
												num36 = 573856555;
												num37 = num36;
											}
											num35 = num36 ^ (int)(num4 * 1549303875);
											continue;
										}
										default:
											goto IL_09a1;
										}
										break;
										IL_09a1:
										using (List<Condition>.Enumerator enumerator5 = current4.Conditions.GetEnumerator())
										{
											while (true)
											{
												IL_0ab9:
												int num42;
												int num43;
												if (enumerator5.MoveNext())
												{
													num42 = 616384712;
													num43 = num42;
												}
												else
												{
													num42 = 338448077;
													num43 = num42;
												}
												while (true)
												{
													switch ((num4 = (uint)(num42 ^ 0x1406650B)) % 10)
													{
													case 7u:
														num42 = 616384712;
														continue;
													default:
														goto end_IL_09b9;
													case 1u:
														logger.LogError(string.Format(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2945192796u), current2.Name, current4.value));
														result = false;
														num42 = 42926927;
														continue;
													case 6u:
														logger.LogError(string.Format(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1781019366u), current2.Name, current4.value, current5.value));
														result = false;
														num42 = ((int)num4 * -794356100) ^ 0x1AECACF7;
														continue;
													case 5u:
													{
														current5 = enumerator5.Current;
														int num46;
														if (!string.IsNullOrEmpty(current5.type))
														{
															num42 = 892558721;
															num46 = num42;
														}
														else
														{
															num42 = 197292120;
															num46 = num42;
														}
														continue;
													}
													case 9u:
													{
														int num50;
														if (!(current5.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2207755824u)))
														{
															num42 = 626476736;
															num50 = num42;
														}
														else
														{
															num42 = 892664939;
															num50 = num42;
														}
														continue;
													}
													case 4u:
														break;
													case 2u:
													{
														int num47;
														if (ResourceManager.Get<Story>(current5.value) != null)
														{
															num42 = 42926927;
															num47 = num42;
														}
														else
														{
															num42 = 1808295001;
															num47 = num42;
														}
														continue;
													}
													case 0u:
													{
														int num48;
														int num49;
														if (current5.value == null)
														{
															num48 = -1679148728;
															num49 = num48;
														}
														else
														{
															num48 = -1541797882;
															num49 = num48;
														}
														num42 = num48 ^ (int)(num4 * 38522600);
														continue;
													}
													case 3u:
													{
														int num44;
														int num45;
														if (!(current5.type == global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1743143517u)))
														{
															num44 = -1604047331;
															num45 = num44;
														}
														else
														{
															num44 = -1746939591;
															num45 = num44;
														}
														num42 = num44 ^ ((int)num4 * -1666592330);
														continue;
													}
													case 8u:
														goto end_IL_09b9;
													}
													goto IL_0ab9;
													continue;
													end_IL_09b9:
													break;
												}
												break;
											}
										}
										goto end_IL_0877;
										IL_094c:
										list2.Add(current4.ret);
										if (current4.Conditions.Count <= 0)
										{
											goto end_IL_0877;
										}
										num35 = 2075663255;
										continue;
										IL_088a:
										int num51;
										if (!(current4.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(117271931u)))
										{
											num35 = 1890799366;
											num51 = num35;
										}
										else
										{
											num35 = 293803884;
											num51 = num35;
										}
									}
									continue;
									end_IL_0877:
									break;
								}
							}
						}
						if (current2.Name.Contains(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1043080291u)))
						{
							continue;
						}
						while (true)
						{
							int num52 = 335177710;
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)(num52 ^ 0x1406650B)) % 6)
								{
								case 5u:
									break;
								case 3u:
								{
									int num53;
									int num54;
									if (list2.Count != 0)
									{
										num53 = -1729712721;
										num54 = num53;
									}
									else
									{
										num53 = -1174770129;
										num54 = num53;
									}
									num52 = num53 ^ ((int)num4 * -1085801054);
									continue;
								}
								case 0u:
									goto IL_0bec;
								case 1u:
									goto IL_0c04;
								case 2u:
									flag2 = true;
									num52 = ((int)num4 * -1745464068) ^ -1563330586;
									continue;
								default:
									goto IL_0c3e;
								}
								break;
								IL_0c3e:
								using (List<string>.Enumerator enumerator6 = list2.GetEnumerator())
								{
									while (true)
									{
										IL_0cac:
										int num55;
										int num56;
										if (enumerator6.MoveNext())
										{
											num55 = 1163127093;
											num56 = num55;
										}
										else
										{
											num55 = 1376025259;
											num56 = num55;
										}
										while (true)
										{
											switch ((num4 = (uint)(num55 ^ 0x1406650B)) % 7)
											{
											case 4u:
												num55 = 1163127093;
												continue;
											default:
												goto end_IL_0c4e;
											case 5u:
											{
												current6 = enumerator6.Current;
												int num59;
												if (current6 != global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2290395667u))
												{
													num55 = 720985936;
													num59 = num55;
												}
												else
												{
													num55 = 2042708162;
													num59 = num55;
												}
												continue;
											}
											case 2u:
												break;
											case 6u:
											{
												int num57;
												int num58;
												if (current6 != global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(60399309u))
												{
													num57 = -214576841;
													num58 = num57;
												}
												else
												{
													num57 = -633659221;
													num58 = num57;
												}
												num55 = num57 ^ (int)(num4 * 648405899);
												continue;
											}
											case 3u:
												flag2 = false;
												num55 = ((int)num4 * -1620252357) ^ -1743546234;
												continue;
											case 0u:
												num55 = ((int)num4 * -1540018149) ^ 0x71A1F715;
												continue;
											case 1u:
												goto end_IL_0c4e;
											}
											goto IL_0cac;
											continue;
											end_IL_0c4e:
											break;
										}
										break;
									}
								}
								goto IL_0d2f;
								IL_0c04:
								if (text != string.Empty)
								{
									num52 = (int)(num4 * 758958105) ^ -1960828618;
									continue;
								}
								goto IL_0d61;
								IL_0d61:
								text4 = string.Empty;
								int num60 = 1168713235;
								goto IL_0d3b;
								IL_0bec:
								flag2 = false;
								goto IL_0d2f;
								IL_0d2f:
								if (flag2)
								{
									goto end_IL_0b9a;
								}
								goto IL_0d36;
								IL_0d36:
								num60 = 2083410696;
								goto IL_0d3b;
								IL_0d3b:
								while (true)
								{
									switch ((num4 = (uint)(num60 ^ 0x1406650B)) % 5)
									{
									case 0u:
										break;
									case 3u:
										goto IL_0d61;
									case 1u:
										logger.LogError(string.Format(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1881424948u), current2.Name, text));
										result = false;
										num60 = (int)((num4 * 1468054453) ^ 0x47F42929);
										continue;
									default:
										goto IL_0db4;
									case 4u:
										goto end_IL_0b9a;
									}
									break;
								}
								goto IL_0d36;
							}
							continue;
							end_IL_0b9a:
							break;
						}
						continue;
					}
					int num61 = 435517319;
					goto IL_0f35;
					IL_0db4:
					using (List<string>.Enumerator enumerator6 = list2.GetEnumerator())
					{
						while (true)
						{
							IL_0eda:
							if (enumerator6.MoveNext())
							{
								current7 = enumerator6.Current;
								num62 = 0;
								try
								{
									if (!flag)
									{
										while (true)
										{
											IL_0dd2:
											int num63 = 1308394760;
											while (true)
											{
												uint num4;
												switch ((num4 = (uint)(num63 ^ 0x1406650B)) % 3)
												{
												case 0u:
													break;
												default:
													goto end_IL_0dd7;
												case 2u:
													goto IL_0df5;
												case 1u:
													goto end_IL_0dd7;
												}
												goto IL_0dd2;
												IL_0df5:
												num62 = int.Parse(current7);
												num63 = (int)((num4 * 578566419) ^ 0x44EC771B);
												continue;
												end_IL_0dd7:
												break;
											}
											break;
										}
									}
								}
								catch
								{
									while (true)
									{
										IL_0e11:
										int num64 = 1474987463;
										while (true)
										{
											uint num4;
											switch ((num4 = (uint)(num64 ^ 0x1406650B)) % 3)
											{
											case 0u:
												break;
											default:
												goto end_IL_0e16;
											case 2u:
												goto IL_0e34;
											case 1u:
												goto end_IL_0e16;
											}
											goto IL_0e11;
											IL_0e34:
											num62 = 0;
											num64 = ((int)num4 * -270584505) ^ 0x177EB7CA;
											continue;
											end_IL_0e16:
											break;
										}
										break;
									}
								}
								if (!(current7 == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2290395667u)))
								{
									goto IL_0e5c;
								}
								goto IL_0ebf;
							}
							int num65 = 1052766634;
							goto IL_0e61;
							IL_0ebf:
							text4 = current7;
							num65 = 1896721195;
							goto IL_0e61;
							IL_0e61:
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)(num65 ^ 0x1406650B)) % 7)
								{
								case 0u:
									break;
								default:
									goto end_IL_0eda;
								case 1u:
								{
									int num68;
									int num69;
									if (current7 == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1603159663u))
									{
										num68 = -1926749878;
										num69 = num68;
									}
									else
									{
										num68 = -781748492;
										num69 = num68;
									}
									num65 = num68 ^ (int)(num4 * 2000789443);
									continue;
								}
								case 2u:
									goto IL_0ebf;
								case 6u:
									num65 = (int)((num4 * 1374041432) ^ 0x40C48AAA);
									continue;
								case 5u:
									goto IL_0eda;
								case 4u:
								{
									int num66;
									int num67;
									if (num62 <= 0)
									{
										num66 = -1539829121;
										num67 = num66;
									}
									else
									{
										num66 = -1367911147;
										num67 = num66;
									}
									num65 = num66 ^ ((int)num4 * -1330131935);
									continue;
								}
								case 3u:
									goto end_IL_0eda;
								}
								break;
							}
							goto IL_0e5c;
							IL_0e5c:
							num65 = 1913727165;
							goto IL_0e61;
							continue;
							end_IL_0eda:
							break;
						}
					}
					if (!(text4 != string.Empty))
					{
						continue;
					}
					goto IL_0f30;
					IL_0f35:
					while (true)
					{
						uint num4;
						switch ((num4 = (uint)(num61 ^ 0x1406650B)) % 4)
						{
						case 3u:
							break;
						default:
							goto end_IL_0f87;
						case 1u:
							logger.LogError(string.Format(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2570300679u), current2.Name, text4));
							result = false;
							num61 = (int)(num4 * 1184214851) ^ -1104890006;
							continue;
						case 2u:
							goto IL_0f87;
						case 0u:
							goto end_IL_0f87;
						}
						break;
					}
					goto IL_0f30;
					IL_0f30:
					num61 = 1022886366;
					goto IL_0f35;
					continue;
					end_IL_0f87:
					break;
				}
			}
			finally
			{
				if (enumerator2 != null)
				{
					while (true)
					{
						IL_0fa0:
						int num70 = 1373085940;
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)(num70 ^ 0x1406650B)) % 3)
							{
							case 2u:
								break;
							default:
								goto end_IL_0fa5;
							case 1u:
								goto IL_0fc3;
							case 0u:
								goto end_IL_0fa5;
							}
							goto IL_0fa0;
							IL_0fc3:
							enumerator2.Dispose();
							num70 = (int)((num4 * 1336717038) ^ 0x1CD3A0D7);
							continue;
							end_IL_0fa5:
							break;
						}
						break;
					}
				}
			}
			num = 2;
			IEnumerator<Map> enumerator7 = ResourceManager.GetAll<Map>().GetEnumerator();
			try
			{
				MapRole current9 = default(MapRole);
				Condition current12 = default(Condition);
				while (enumerator7.MoveNext())
				{
					Map current8 = enumerator7.Current;
					using (List<MapRole>.Enumerator enumerator8 = current8.MapRoles.GetEnumerator())
					{
						while (true)
						{
							IL_10dd:
							int num71;
							int num72;
							if (enumerator8.MoveNext())
							{
								num71 = 789717644;
								num72 = num71;
							}
							else
							{
								num71 = 1202341103;
								num72 = num71;
							}
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)(num71 ^ 0x1406650B)) % 8)
								{
								case 5u:
									num71 = 789717644;
									continue;
								default:
									goto end_IL_100f;
								case 7u:
									current9 = enumerator8.Current;
									num71 = 122264378;
									continue;
								case 2u:
									logger.LogError(string.Format(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3820030834u), current8.Name, current9.pic));
									num71 = (int)(num4 * 1182722302) ^ -1595188796;
									continue;
								case 6u:
								{
									int num75;
									int num76;
									if (ResourceManager.Get<Resource>(current9.pic) != null)
									{
										num75 = 42819007;
										num76 = num75;
									}
									else
									{
										num75 = 1862246709;
										num76 = num75;
									}
									num71 = num75 ^ ((int)num4 * -558233506);
									continue;
								}
								case 1u:
								{
									int num73;
									int num74;
									if (string.IsNullOrEmpty(current9.pic))
									{
										num73 = 44729445;
										num74 = num73;
									}
									else
									{
										num73 = 600423627;
										num74 = num73;
									}
									num71 = num73 ^ ((int)num4 * -1089449666);
									continue;
								}
								case 0u:
									break;
								case 3u:
									result = false;
									num71 = (int)((num4 * 570919780) ^ 0x713C7397);
									continue;
								case 4u:
									goto end_IL_100f;
								}
								goto IL_10dd;
								continue;
								end_IL_100f:
								break;
							}
							break;
						}
					}
					foreach (MapRole mapRole in current8.MapRoles)
					{
						using List<MapEvent>.Enumerator enumerator9 = mapRole.Events.GetEnumerator();
						while (enumerator9.MoveNext())
						{
							while (true)
							{
								MapEvent current11 = enumerator9.Current;
								int num77 = 1952122378;
								while (true)
								{
									uint num4;
									switch ((num4 = (uint)(num77 ^ 0x1406650B)) % 8)
									{
									case 6u:
										num77 = 1445847838;
										continue;
									case 4u:
										logger.LogError(string.Format(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1157975266u), current8.Name, mapRole.Name, current11.value));
										num77 = ((int)num4 * -1546976660) ^ 0x63D72B48;
										continue;
									case 1u:
									{
										int num80;
										int num81;
										if (!(current11.type == global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1837891988u)))
										{
											num80 = -1354551293;
											num81 = num80;
										}
										else
										{
											num80 = -1806812535;
											num81 = num80;
										}
										num77 = num80 ^ ((int)num4 * -1935645784);
										continue;
									}
									case 0u:
										break;
									case 3u:
										result = false;
										num77 = ((int)num4 * -591118964) ^ -1182250033;
										continue;
									case 2u:
									{
										int num78;
										int num79;
										if (ResourceManager.Get<Story>(current11.value) == null)
										{
											num78 = -532796261;
											num79 = num78;
										}
										else
										{
											num78 = -1392526921;
											num79 = num78;
										}
										num77 = num78 ^ (int)(num4 * 1144086102);
										continue;
									}
									case 5u:
										goto end_IL_1153;
									default:
										goto IL_1266;
									}
									if (current11.Conditions.Count <= 0)
									{
										goto end_IL_1253;
									}
									num77 = 1031645572;
									continue;
									IL_1266:
									using (List<Condition>.Enumerator enumerator5 = current11.Conditions.GetEnumerator())
									{
										while (true)
										{
											IL_135b:
											int num82;
											int num83;
											if (enumerator5.MoveNext())
											{
												num82 = 1296720660;
												num83 = num82;
											}
											else
											{
												num82 = 1424717023;
												num83 = num82;
											}
											while (true)
											{
												switch ((num4 = (uint)(num82 ^ 0x1406650B)) % 9)
												{
												case 2u:
													num82 = 1296720660;
													continue;
												default:
													goto end_IL_127e;
												case 7u:
												{
													int num87;
													int num88;
													if (!(current12.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(25910476u)))
													{
														num87 = 1257428796;
														num88 = num87;
													}
													else
													{
														num87 = 1432088573;
														num88 = num87;
													}
													num82 = num87 ^ ((int)num4 * -466524413);
													continue;
												}
												case 6u:
													result = false;
													num82 = (int)(num4 * 715820882) ^ -401782264;
													continue;
												case 4u:
													logger.LogError(string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1608061985u), current8.Name, mapRole.Name, current12.value));
													num82 = (int)((num4 * 1565020619) ^ 0x6F79694);
													continue;
												case 8u:
												{
													int num86;
													if (ResourceManager.Get<Story>(current12.value) != null)
													{
														num82 = 898877502;
														num86 = num82;
													}
													else
													{
														num82 = 2080649663;
														num86 = num82;
													}
													continue;
												}
												case 3u:
													break;
												case 0u:
												{
													int num84;
													int num85;
													if (!(current12.type == global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1161730342u)))
													{
														num84 = 686513911;
														num85 = num84;
													}
													else
													{
														num84 = 176940885;
														num85 = num84;
													}
													num82 = num84 ^ ((int)num4 * -903409509);
													continue;
												}
												case 1u:
													current12 = enumerator5.Current;
													num82 = 288779669;
													continue;
												case 5u:
													goto end_IL_127e;
												}
												goto IL_135b;
												continue;
												end_IL_127e:
												break;
											}
											break;
										}
									}
									goto end_IL_1253;
									continue;
									end_IL_1153:
									break;
								}
								continue;
								end_IL_1253:
								break;
							}
						}
					}
				}
			}
			finally
			{
				if (enumerator7 != null)
				{
					while (true)
					{
						IL_141a:
						int num89 = 565801339;
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)(num89 ^ 0x1406650B)) % 3)
							{
							case 2u:
								break;
							default:
								goto end_IL_141f;
							case 1u:
								goto IL_143d;
							case 0u:
								goto end_IL_141f;
							}
							goto IL_141a;
							IL_143d:
							enumerator7.Dispose();
							num89 = (int)(num4 * 918841138) ^ -222723100;
							continue;
							end_IL_141f:
							break;
						}
						break;
					}
				}
			}
			num = 3;
			IEnumerator<Role> enumerator10 = ResourceManager.GetAll<Role>().GetEnumerator();
			try
			{
				Role current13 = default(Role);
				string current14 = default(string);
				SkillInstance current15 = default(SkillInstance);
				InternalSkillInstance current16 = default(InternalSkillInstance);
				SpecialSkillInstance current17 = default(SpecialSkillInstance);
				ItemInstance current18 = default(ItemInstance);
				while (true)
				{
					IL_1941:
					if (enumerator10.MoveNext())
					{
						current13 = enumerator10.Current;
						using (List<string>.Enumerator enumerator6 = current13.Talents.GetEnumerator())
						{
							while (true)
							{
								IL_14b3:
								int num90;
								int num91;
								if (!enumerator6.MoveNext())
								{
									num90 = 1550211935;
									num91 = num90;
								}
								else
								{
									num90 = 1667389487;
									num91 = num90;
								}
								while (true)
								{
									uint num4;
									switch ((num4 = (uint)(num90 ^ 0x1406650B)) % 6)
									{
									case 0u:
										num90 = 1667389487;
										continue;
									default:
										goto end_IL_1486;
									case 5u:
										break;
									case 1u:
									{
										int num92;
										int num93;
										if (ResourceManager.Get<Resource>(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1865695569u) + current14) != null)
										{
											num92 = 1489730869;
											num93 = num92;
										}
										else
										{
											num92 = 1089151973;
											num93 = num92;
										}
										num90 = num92 ^ ((int)num4 * -1568514489);
										continue;
									}
									case 4u:
										current14 = enumerator6.Current;
										num90 = 1883720534;
										continue;
									case 3u:
										logger.LogError(string.Format(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1103075338u), current13.Key, current14));
										result = false;
										num90 = ((int)num4 * -1102219227) ^ -1528898393;
										continue;
									case 2u:
										goto end_IL_1486;
									}
									goto IL_14b3;
									continue;
									end_IL_1486:
									break;
								}
								break;
							}
						}
						using (List<SkillInstance>.Enumerator enumerator11 = current13.Skills.GetEnumerator())
						{
							while (true)
							{
								IL_160d:
								int num94;
								int num95;
								if (enumerator11.MoveNext())
								{
									num94 = 1864667074;
									num95 = num94;
								}
								else
								{
									num94 = 271995189;
									num95 = num94;
								}
								while (true)
								{
									uint num4;
									switch ((num4 = (uint)(num94 ^ 0x1406650B)) % 6)
									{
									case 3u:
										num94 = 1864667074;
										continue;
									default:
										goto end_IL_156d;
									case 2u:
										logger.LogError(string.Format(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(975948176u), current13.Key, current15.Name));
										result = false;
										num94 = ((int)num4 * -1844486254) ^ -258741682;
										continue;
									case 0u:
									{
										int num96;
										int num97;
										if (ResourceManager.Get<Skill>(current15.Name) != null)
										{
											num96 = -986155106;
											num97 = num96;
										}
										else
										{
											num96 = -186855371;
											num97 = num96;
										}
										num94 = num96 ^ (int)(num4 * 1503531382);
										continue;
									}
									case 1u:
										current15 = enumerator11.Current;
										num94 = 877549133;
										continue;
									case 5u:
										break;
									case 4u:
										goto end_IL_156d;
									}
									goto IL_160d;
									continue;
									end_IL_156d:
									break;
								}
								break;
							}
						}
						using (List<InternalSkillInstance>.Enumerator enumerator12 = current13.InternalSkills.GetEnumerator())
						{
							while (true)
							{
								IL_168e:
								int num98;
								int num99;
								if (!enumerator12.MoveNext())
								{
									num98 = 1093780640;
									num99 = num98;
								}
								else
								{
									num98 = 2145891375;
									num99 = num98;
								}
								while (true)
								{
									uint num4;
									switch ((num4 = (uint)(num98 ^ 0x1406650B)) % 6)
									{
									case 3u:
										num98 = 2145891375;
										continue;
									default:
										goto end_IL_164f;
									case 0u:
										result = false;
										num98 = (int)((num4 * 1651614926) ^ 0x7CA91A51);
										continue;
									case 2u:
										break;
									case 4u:
									{
										current16 = enumerator12.Current;
										int num100;
										if (ResourceManager.Get<InternalSkill>(current16.Name) == null)
										{
											num98 = 1141657380;
											num100 = num98;
										}
										else
										{
											num98 = 1752388581;
											num100 = num98;
										}
										continue;
									}
									case 5u:
										logger.LogError(string.Format(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1853256371u), current13.Key, current16.Name));
										num98 = ((int)num4 * -1817385037) ^ 0xE6BF2C0;
										continue;
									case 1u:
										goto end_IL_164f;
									}
									goto IL_168e;
									continue;
									end_IL_164f:
									break;
								}
								break;
							}
						}
						using (List<SpecialSkillInstance>.Enumerator enumerator13 = current13.SpecialSkills.GetEnumerator())
						{
							while (true)
							{
								IL_17a0:
								int num101;
								int num102;
								if (!enumerator13.MoveNext())
								{
									num101 = 592746535;
									num102 = num101;
								}
								else
								{
									num101 = 707894380;
									num102 = num101;
								}
								while (true)
								{
									uint num4;
									switch ((num4 = (uint)(num101 ^ 0x1406650B)) % 6)
									{
									case 3u:
										num101 = 707894380;
										continue;
									default:
										goto end_IL_172e;
									case 5u:
										result = false;
										num101 = ((int)num4 * -1128313104) ^ 0x7733613D;
										continue;
									case 0u:
										logger.LogError(string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1596438895u), current13.Key, current17.Name));
										num101 = (int)(num4 * 955616790) ^ -1646816978;
										continue;
									case 4u:
										break;
									case 1u:
									{
										current17 = enumerator13.Current;
										int num103;
										if (ResourceManager.Get<SpecialSkill>(current17.Name) != null)
										{
											num101 = 1991923405;
											num103 = num101;
										}
										else
										{
											num101 = 70023861;
											num103 = num101;
										}
										continue;
									}
									case 2u:
										goto end_IL_172e;
									}
									goto IL_17a0;
									continue;
									end_IL_172e:
									break;
								}
								break;
							}
						}
						using (List<ItemInstance>.Enumerator enumerator14 = current13.Equipment.GetEnumerator())
						{
							while (true)
							{
								IL_1862:
								int num104;
								int num105;
								if (enumerator14.MoveNext())
								{
									num104 = 733542263;
									num105 = num104;
								}
								else
								{
									num104 = 914166810;
									num105 = num104;
								}
								while (true)
								{
									uint num4;
									switch ((num4 = (uint)(num104 ^ 0x1406650B)) % 6)
									{
									case 2u:
										num104 = 733542263;
										continue;
									default:
										goto end_IL_180d;
									case 4u:
									{
										current18 = enumerator14.Current;
										int num106;
										if (ResourceManager.Get<Item>(current18.Name) == null)
										{
											num104 = 1688600944;
											num106 = num104;
										}
										else
										{
											num104 = 905389206;
											num106 = num104;
										}
										continue;
									}
									case 1u:
										break;
									case 3u:
										logger.LogError(string.Format(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2059666551u), current13.Key, current18.Name));
										num104 = (int)(num4 * 1552187586) ^ -1776560097;
										continue;
									case 0u:
										result = false;
										num104 = ((int)num4 * -1050894615) ^ 0x336DD664;
										continue;
									case 5u:
										goto end_IL_180d;
									}
									goto IL_1862;
									continue;
									end_IL_180d:
									break;
								}
								break;
							}
						}
						if (ResourceManager.Get<Resource>(current13.Head) != null)
						{
							continue;
						}
						goto IL_18e5;
					}
					int num107 = 1430673089;
					goto IL_18ea;
					IL_18ea:
					while (true)
					{
						uint num4;
						switch ((num4 = (uint)(num107 ^ 0x1406650B)) % 4)
						{
						case 3u:
							break;
						default:
							goto end_IL_1941;
						case 1u:
							logger.LogError(string.Format(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2197404635u), current13.Key, current13.Head));
							result = false;
							num107 = (int)((num4 * 912281589) ^ 0x1AA0BF72);
							continue;
						case 0u:
							goto IL_1941;
						case 2u:
							goto end_IL_1941;
						}
						break;
					}
					goto IL_18e5;
					IL_18e5:
					num107 = 1123314822;
					goto IL_18ea;
					continue;
					end_IL_1941:
					break;
				}
			}
			finally
			{
				if (enumerator10 != null)
				{
					while (true)
					{
						IL_195a:
						int num108 = 1903277475;
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)(num108 ^ 0x1406650B)) % 3)
							{
							case 0u:
								break;
							default:
								goto end_IL_195f;
							case 2u:
								goto IL_197d;
							case 1u:
								goto end_IL_195f;
							}
							goto IL_195a;
							IL_197d:
							enumerator10.Dispose();
							num108 = (int)(num4 * 1571626170) ^ -543042531;
							continue;
							end_IL_195f:
							break;
						}
						break;
					}
				}
			}
			num = 4;
			enumerator7 = ResourceManager.GetAll<Map>().GetEnumerator();
			try
			{
				Music current20 = default(Music);
				MapEvent current22 = default(MapEvent);
				while (enumerator7.MoveNext())
				{
					Map current19;
					while (true)
					{
						current19 = enumerator7.Current;
						int num109;
						int num110;
						if (ResourceManager.Get<Resource>(current19.Pic) == null)
						{
							num109 = 316571060;
							num110 = num109;
						}
						else
						{
							num109 = 1599198276;
							num110 = num109;
						}
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)(num109 ^ 0x1406650B)) % 5)
							{
							case 4u:
								num109 = 1886459157;
								continue;
							case 1u:
								break;
							case 0u:
								result = false;
								num109 = (int)((num4 * 1314396598) ^ 0x6DB8418C);
								continue;
							case 2u:
								logger.LogError(string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2630598791u), current19.Name, current19.Pic));
								num109 = ((int)num4 * -1423832666) ^ -2043706307;
								continue;
							default:
								goto end_IL_19d3;
							}
							break;
						}
						continue;
						end_IL_19d3:
						break;
					}
					using (List<Music>.Enumerator enumerator15 = current19.Musics.GetEnumerator())
					{
						while (true)
						{
							IL_1a89:
							int num111;
							int num112;
							if (!enumerator15.MoveNext())
							{
								num111 = 1163930265;
								num112 = num111;
							}
							else
							{
								num111 = 216490583;
								num112 = num111;
							}
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)(num111 ^ 0x1406650B)) % 7)
								{
								case 0u:
									num111 = 216490583;
									continue;
								default:
									goto end_IL_1a58;
								case 2u:
									break;
								case 1u:
									result = false;
									num111 = ((int)num4 * -1216923121) ^ 0x1D582531;
									continue;
								case 4u:
								{
									int num113;
									int num114;
									if (ResourceManager.Get<Resource>(current20.Name) != null)
									{
										num113 = -131002708;
										num114 = num113;
									}
									else
									{
										num113 = -1441896030;
										num114 = num113;
									}
									num111 = num113 ^ ((int)num4 * -956054120);
									continue;
								}
								case 3u:
									logger.LogError(string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(870925104u), current19.Name, current20.Name));
									num111 = ((int)num4 * -1601973328) ^ -42861632;
									continue;
								case 6u:
									current20 = enumerator15.Current;
									num111 = 2032460092;
									continue;
								case 5u:
									goto end_IL_1a58;
								}
								goto IL_1a89;
								continue;
								end_IL_1a58:
								break;
							}
							break;
						}
					}
					foreach (MapLocation mapUnit in current19.MapUnits)
					{
						using List<MapEvent>.Enumerator enumerator9 = mapUnit.Events.GetEnumerator();
						while (true)
						{
							IL_1d13:
							int num115;
							int num116;
							if (enumerator9.MoveNext())
							{
								num115 = 1066501742;
								num116 = num115;
							}
							else
							{
								num115 = 464100786;
								num116 = num115;
							}
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)(num115 ^ 0x1406650B)) % 16)
								{
								case 4u:
									num115 = 1066501742;
									continue;
								default:
									goto end_IL_1b6d;
								case 10u:
								{
									int num120;
									int num121;
									if (ResourceManager.Get<Story>(current22.value) == null)
									{
										num120 = -2136434117;
										num121 = num120;
									}
									else
									{
										num120 = -2006452976;
										num121 = num120;
									}
									num115 = num120 ^ ((int)num4 * -274142170);
									continue;
								}
								case 11u:
								{
									int num124;
									int num125;
									if (ResourceManager.Get<Resource>(current22.image) == null)
									{
										num124 = -2103513070;
										num125 = num124;
									}
									else
									{
										num124 = -1756699364;
										num125 = num124;
									}
									num115 = num124 ^ (int)(num4 * 298469454);
									continue;
								}
								case 5u:
									current22 = enumerator9.Current;
									num115 = 937986525;
									continue;
								case 15u:
									logger.LogError(string.Format(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2233523045u), current19.Name, mapUnit.Name, current22.value));
									num115 = ((int)num4 * -1091983393) ^ 0x4B5D1B84;
									continue;
								case 3u:
									logger.LogError(string.Format(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3813151928u), current19.Name, mapUnit.Name, current22.value, current22.image));
									num115 = ((int)num4 * -1520198756) ^ 0x37D90057;
									continue;
								case 6u:
								{
									int num118;
									int num119;
									if (current22.type == global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3321561599u))
									{
										num118 = -379003595;
										num119 = num118;
									}
									else
									{
										num118 = -1230494531;
										num119 = num118;
									}
									num115 = num118 ^ (int)(num4 * 1192185718);
									continue;
								}
								case 7u:
								{
									int num126;
									if (string.IsNullOrEmpty(current22.image))
									{
										num115 = 1777141158;
										num126 = num115;
									}
									else
									{
										num115 = 1260560592;
										num126 = num115;
									}
									continue;
								}
								case 13u:
									break;
								case 8u:
									result = false;
									num115 = ((int)num4 * -1035255154) ^ 0x2639DFD6;
									continue;
								case 1u:
									num115 = ((int)num4 * -2124019264) ^ -1197519348;
									continue;
								case 12u:
									logger.LogError(string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1608061985u), current19.Name, mapUnit.Name, current22.value));
									result = false;
									num115 = ((int)num4 * -1770829966) ^ 0x3D21D9E2;
									continue;
								case 0u:
								{
									int num122;
									int num123;
									if (ResourceManager.Get<Map>(current22.value) != null)
									{
										num122 = 1392996844;
										num123 = num122;
									}
									else
									{
										num122 = 785788372;
										num123 = num122;
									}
									num115 = num122 ^ ((int)num4 * -398445694);
									continue;
								}
								case 14u:
									result = false;
									num115 = ((int)num4 * -1294210641) ^ -1047174594;
									continue;
								case 2u:
								{
									int num117;
									if (current22.type == global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(489087581u))
									{
										num115 = 931899419;
										num117 = num115;
									}
									else
									{
										num115 = 1121657804;
										num117 = num115;
									}
									continue;
								}
								case 9u:
									goto end_IL_1b6d;
								}
								goto IL_1d13;
								continue;
								end_IL_1b6d:
								break;
							}
							break;
						}
					}
				}
			}
			finally
			{
				if (enumerator7 != null)
				{
					while (true)
					{
						IL_1e41:
						int num127 = 1009857288;
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)(num127 ^ 0x1406650B)) % 3)
							{
							case 0u:
								break;
							default:
								goto end_IL_1e46;
							case 1u:
								goto IL_1e64;
							case 2u:
								goto end_IL_1e46;
							}
							goto IL_1e41;
							IL_1e64:
							enumerator7.Dispose();
							num127 = ((int)num4 * -321492548) ^ -1688740836;
							continue;
							end_IL_1e46:
							break;
						}
						break;
					}
				}
			}
			num = 5;
			IEnumerator<Item> enumerator17 = ResourceManager.GetAll<Item>().GetEnumerator();
			try
			{
				Item current23 = default(Item);
				while (true)
				{
					IL_1edf:
					int num128;
					int num129;
					if (!enumerator17.MoveNext())
					{
						num128 = 755782103;
						num129 = num128;
					}
					else
					{
						num128 = 103273973;
						num129 = num128;
					}
					while (true)
					{
						uint num4;
						switch ((num4 = (uint)(num128 ^ 0x1406650B)) % 5)
						{
						case 2u:
							num128 = 103273973;
							continue;
						default:
							goto end_IL_1e91;
						case 1u:
						{
							current23 = enumerator17.Current;
							int num130;
							if (ResourceManager.Get<Resource>(current23.pic) != null)
							{
								num128 = 568293263;
								num130 = num128;
							}
							else
							{
								num128 = 1267059021;
								num130 = num128;
							}
							continue;
						}
						case 0u:
							break;
						case 3u:
							logger.LogError(string.Format(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3047753148u), current23.Name, current23.pic));
							result = false;
							num128 = ((int)num4 * -1480716827) ^ -2019303663;
							continue;
						case 4u:
							goto end_IL_1e91;
						}
						goto IL_1edf;
						continue;
						end_IL_1e91:
						break;
					}
					break;
				}
			}
			finally
			{
				if (enumerator17 != null)
				{
					while (true)
					{
						IL_1f37:
						int num131 = 1682493229;
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)(num131 ^ 0x1406650B)) % 3)
							{
							case 0u:
								break;
							default:
								goto end_IL_1f3c;
							case 2u:
								goto IL_1f5a;
							case 1u:
								goto end_IL_1f3c;
							}
							goto IL_1f37;
							IL_1f5a:
							enumerator17.Dispose();
							num131 = (int)((num4 * 537343511) ^ 0x287B3DEA);
							continue;
							end_IL_1f3c:
							break;
						}
						break;
					}
				}
			}
			num = 6;
			IEnumerator<Battle> enumerator18 = ResourceManager.GetAll<Battle>().GetEnumerator();
			try
			{
				Battle current24 = default(Battle);
				string current25 = default(string);
				Dictionary<string, bool> dictionary = default(Dictionary<string, bool>);
				int num141 = default(int);
				BattleRole current26 = default(BattleRole);
				string text5 = default(string);
				RandomBattleRole randomBattleRoles = default(RandomBattleRole);
				string text6 = default(string);
				BattleRole current27 = default(BattleRole);
				while (true)
				{
					IL_2863:
					bool flag3;
					if (enumerator18.MoveNext())
					{
						while (true)
						{
							current24 = enumerator18.Current;
							int num132 = 1659147775;
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)(num132 ^ 0x1406650B)) % 4)
								{
								case 3u:
									num132 = 1658815978;
									continue;
								case 1u:
									break;
								case 0u:
									goto IL_1fbc;
								default:
									goto IL_1fd8;
								}
								break;
								IL_1fd8:
								using (List<string>.Enumerator enumerator6 = current24.mustKeys.GetEnumerator())
								{
									while (true)
									{
										IL_20a5:
										int num133;
										int num134;
										if (!enumerator6.MoveNext())
										{
											num133 = 2084730105;
											num134 = num133;
										}
										else
										{
											num133 = 1815825022;
											num134 = num133;
										}
										while (true)
										{
											switch ((num4 = (uint)(num133 ^ 0x1406650B)) % 7)
											{
											case 6u:
												num133 = 1815825022;
												continue;
											default:
												goto end_IL_1ff0;
											case 2u:
												logger.LogError(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2680704922u) + current24.Key + global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1094298405u) + current25);
												num133 = ((int)num4 * -1437581866) ^ -1933272542;
												continue;
											case 3u:
											{
												int num136;
												int num137;
												if (ResourceManager.Get<Role>(current25) != null)
												{
													num136 = -1712773111;
													num137 = num136;
												}
												else
												{
													num136 = -1894492165;
													num137 = num136;
												}
												num133 = num136 ^ ((int)num4 * -17017457);
												continue;
											}
											case 1u:
											{
												current25 = enumerator6.Current;
												int num135;
												if (string.IsNullOrEmpty(current25))
												{
													num133 = 1733426888;
													num135 = num133;
												}
												else
												{
													num133 = 129065892;
													num135 = num133;
												}
												continue;
											}
											case 5u:
												break;
											case 0u:
												result = false;
												num133 = ((int)num4 * -215116577) ^ -1157487991;
												continue;
											case 4u:
												goto end_IL_1ff0;
											}
											goto IL_20a5;
											continue;
											end_IL_1ff0:
											break;
										}
										break;
									}
								}
								goto IL_20e7;
								IL_1fbc:
								if (current24.mustKeys != null)
								{
									num132 = (int)((num4 * 574379594) ^ 0x27479E61);
									continue;
								}
								goto IL_20e7;
								IL_20e7:
								flag3 = true;
								goto end_IL_1fac;
							}
							continue;
							end_IL_1fac:
							break;
						}
						while (true)
						{
							int num138 = 302387585;
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)(num138 ^ 0x1406650B)) % 6)
								{
								case 4u:
									break;
								case 2u:
									dictionary = new Dictionary<string, bool>();
									num138 = (int)(num4 * 765782793) ^ -1958547312;
									continue;
								case 1u:
									num141 = 0;
									num138 = ((int)num4 * -314010093) ^ 0x16280772;
									continue;
								case 3u:
									num141 = current24.mustKeys.Count;
									num138 = ((int)num4 * -1205310343) ^ -79948991;
									continue;
								case 0u:
								{
									int num139;
									int num140;
									if (current24.mustKeys != null)
									{
										num139 = 542453104;
										num140 = num139;
									}
									else
									{
										num139 = 487438290;
										num140 = num139;
									}
									num138 = num139 ^ (int)(num4 * 915624095);
									continue;
								}
								default:
									goto end_IL_20ea;
								}
								break;
							}
							continue;
							end_IL_20ea:
							break;
						}
						int num142 = 0;
						using (List<BattleRole>.Enumerator enumerator19 = current24.Roles.GetEnumerator())
						{
							while (true)
							{
								IL_2500:
								int num143;
								int num144;
								if (!enumerator19.MoveNext())
								{
									num143 = 134411103;
									num144 = num143;
								}
								else
								{
									num143 = 154325612;
									num144 = num143;
								}
								while (true)
								{
									uint num4;
									switch ((num4 = (uint)(num143 ^ 0x1406650B)) % 23)
									{
									case 21u:
										num143 = 154325612;
										continue;
									default:
										goto end_IL_21a2;
									case 9u:
									{
										int num153;
										if (num141 <= 0)
										{
											num143 = 580523698;
											num153 = num143;
										}
										else
										{
											num143 = 1578274757;
											num153 = num143;
										}
										continue;
									}
									case 3u:
										result = false;
										num143 = ((int)num4 * -744199091) ^ -642974270;
										continue;
									case 14u:
									{
										int num151;
										int num152;
										if (current26.Y < 0)
										{
											num151 = 786684441;
											num152 = num151;
										}
										else
										{
											num151 = 287105147;
											num152 = num151;
										}
										num143 = num151 ^ (int)(num4 * 122949940);
										continue;
									}
									case 16u:
									{
										int num157;
										if (string.IsNullOrEmpty(current26.PredefinedKey))
										{
											num143 = 795231986;
											num157 = num143;
										}
										else
										{
											num143 = 1611745088;
											num157 = num143;
										}
										continue;
									}
									case 18u:
									{
										int num159;
										int num160;
										if (current26.Y < BattleField.MOVEBLOCK_MAX_Y)
										{
											num159 = 1959160176;
											num160 = num159;
										}
										else
										{
											num159 = 666419837;
											num160 = num159;
										}
										num143 = num159 ^ ((int)num4 * -2118109796);
										continue;
									}
									case 11u:
									{
										text5 = string.Format(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(954826904u), current26.X, current26.Y);
										int num156;
										if (dictionary.ContainsKey(text5))
										{
											num143 = 852381428;
											num156 = num143;
										}
										else
										{
											num143 = 1430533340;
											num156 = num143;
										}
										continue;
									}
									case 22u:
										logger.LogError(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2730811053u) + current24.Key + global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(703949147u) + text5);
										result = false;
										num143 = 2136034176;
										continue;
									case 20u:
									{
										int num147;
										int num148;
										if (ResourceManager.Get<Role>(current26.PredefinedKey) == null)
										{
											num147 = -471139407;
											num148 = num147;
										}
										else
										{
											num147 = -218668729;
											num148 = num147;
										}
										num143 = num147 ^ (int)(num4 * 1622842879);
										continue;
									}
									case 13u:
										flag3 = false;
										num143 = ((int)num4 * -1863162595) ^ 0x77F2777F;
										continue;
									case 10u:
										num142++;
										num143 = (int)((num4 * 840446404) ^ 0x61D6910E);
										continue;
									case 2u:
										num142++;
										num143 = (int)(num4 * 260947279) ^ -952219590;
										continue;
									case 17u:
										current26 = enumerator19.Current;
										num143 = 1548711870;
										continue;
									case 8u:
									{
										int num158;
										if (current26.X < 0)
										{
											num143 = 741335181;
											num158 = num143;
										}
										else
										{
											num143 = 556247540;
											num158 = num143;
										}
										continue;
									}
									case 1u:
										dictionary[text5] = true;
										num143 = 780334843;
										continue;
									case 4u:
									{
										int num154;
										int num155;
										if (current24.mustKeys.Contains(current26.PredefinedKey))
										{
											num154 = 770885365;
											num155 = num154;
										}
										else
										{
											num154 = 883839924;
											num155 = num154;
										}
										num143 = num154 ^ ((int)num4 * -431932283);
										continue;
									}
									case 6u:
										logger.LogError(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4293673987u) + current24.Key + global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(703949147u) + text5);
										num143 = ((int)num4 * -716884212) ^ 0x724F5EEF;
										continue;
									case 7u:
									{
										int num149;
										int num150;
										if (string.IsNullOrEmpty(current26.PredefinedKey))
										{
											num149 = -1219863197;
											num150 = num149;
										}
										else
										{
											num149 = -553845698;
											num150 = num149;
										}
										num143 = num149 ^ (int)(num4 * 684737451);
										continue;
									}
									case 19u:
									{
										int num145;
										int num146;
										if (current26.X < BattleField.MOVEBLOCK_MAX_X)
										{
											num145 = 588796389;
											num146 = num145;
										}
										else
										{
											num145 = 699788250;
											num146 = num145;
										}
										num143 = num145 ^ (int)(num4 * 539707817);
										continue;
									}
									case 12u:
										num143 = (int)(num4 * 279821000) ^ -1206845894;
										continue;
									case 0u:
										logger.LogError(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(708531163u) + current24.Key + global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1094298405u) + current26.PredefinedKey);
										num143 = ((int)num4 * -581578201) ^ -1411291726;
										continue;
									case 5u:
										break;
									case 15u:
										goto end_IL_21a2;
									}
									goto IL_2500;
									continue;
									end_IL_21a2:
									break;
								}
								break;
							}
						}
						if (num142 < num141)
						{
							goto IL_2533;
						}
						goto IL_259c;
					}
					int num161 = 1866083048;
					goto IL_2811;
					IL_2538:
					int num162;
					while (true)
					{
						uint num4;
						switch ((num4 = (uint)(num162 ^ 0x1406650B)) % 5)
						{
						case 2u:
							break;
						case 3u:
							logger.LogError(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1905806220u) + current24.Key);
							num162 = ((int)num4 * -1453246264) ^ -1308180745;
							continue;
						case 0u:
							result = false;
							num162 = (int)(num4 * 1157553661) ^ -1116599795;
							continue;
						case 4u:
							goto IL_259c;
						default:
							goto IL_25b3;
						}
						break;
					}
					goto IL_2533;
					IL_25b3:
					using (List<BattleRole>.Enumerator enumerator19 = randomBattleRoles.randomRoles.GetEnumerator())
					{
						while (true)
						{
							IL_26f1:
							int num163;
							int num164;
							if (enumerator19.MoveNext())
							{
								num163 = 1195105127;
								num164 = num163;
							}
							else
							{
								num163 = 850002373;
								num164 = num163;
							}
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)(num163 ^ 0x1406650B)) % 15)
								{
								case 5u:
									num163 = 1195105127;
									continue;
								default:
									goto end_IL_25cb;
								case 4u:
									logger.LogError(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1728356594u) + current24.Key + global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1178885009u) + text6);
									num163 = (int)(num4 * 1786503549) ^ -762224321;
									continue;
								case 12u:
								{
									int num167;
									int num168;
									if (current27.X >= BattleField.MOVEBLOCK_MAX_X)
									{
										num167 = 334599574;
										num168 = num167;
									}
									else
									{
										num167 = 1971692762;
										num168 = num167;
									}
									num163 = num167 ^ (int)(num4 * 1062229747);
									continue;
								}
								case 7u:
									current27 = enumerator19.Current;
									num163 = 1721593107;
									continue;
								case 14u:
									logger.LogError(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2730811053u) + current24.Key + global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2129775u) + text6);
									num163 = 767213902;
									continue;
								case 13u:
									result = false;
									num163 = (int)((num4 * 330479791) ^ 0x52485DA0);
									continue;
								case 11u:
									dictionary[text6] = true;
									num163 = 1204367770;
									continue;
								case 3u:
									break;
								case 0u:
									num163 = (int)(num4 * 1814980800) ^ -2112749094;
									continue;
								case 2u:
								{
									int num172;
									int num173;
									if (current27.Y >= BattleField.MOVEBLOCK_MAX_Y)
									{
										num172 = -726584937;
										num173 = num172;
									}
									else
									{
										num172 = -204966813;
										num173 = num172;
									}
									num163 = num172 ^ ((int)num4 * -417158473);
									continue;
								}
								case 9u:
								{
									int num171;
									if (current27.X >= 0)
									{
										num163 = 1806169272;
										num171 = num163;
									}
									else
									{
										num163 = 298777471;
										num171 = num163;
									}
									continue;
								}
								case 10u:
									flag3 = false;
									num163 = ((int)num4 * -1320403182) ^ 0x3494DCC2;
									continue;
								case 1u:
								{
									text6 = string.Format(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4069869147u), current27.X, current27.Y);
									int num169;
									int num170;
									if (!dictionary.ContainsKey(text6))
									{
										num169 = 680968981;
										num170 = num169;
									}
									else
									{
										num169 = 934249634;
										num170 = num169;
									}
									num163 = num169 ^ (int)(num4 * 2109800221);
									continue;
								}
								case 8u:
								{
									int num165;
									int num166;
									if (current27.Y < 0)
									{
										num165 = 553142119;
										num166 = num165;
									}
									else
									{
										num165 = 1175919947;
										num166 = num165;
									}
									num163 = num165 ^ ((int)num4 * -694778363);
									continue;
								}
								case 6u:
									goto end_IL_25cb;
								}
								goto IL_26f1;
								continue;
								end_IL_25cb:
								break;
							}
							break;
						}
					}
					goto IL_2808;
					IL_2533:
					num162 = 1707684195;
					goto IL_2538;
					IL_2808:
					if (flag3)
					{
						continue;
					}
					goto IL_280c;
					IL_280c:
					num161 = 1486734477;
					goto IL_2811;
					IL_259c:
					randomBattleRoles = current24.randomBattleRoles;
					if (randomBattleRoles != null)
					{
						num162 = 1393738459;
						goto IL_2538;
					}
					goto IL_2808;
					IL_2811:
					while (true)
					{
						uint num4;
						switch ((num4 = (uint)(num161 ^ 0x1406650B)) % 5)
						{
						case 3u:
							break;
						default:
							goto end_IL_2863;
						case 1u:
							logger.LogError(string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(589138950u), current24.Key));
							num161 = (int)((num4 * 1379743807) ^ 0x4D4C67D);
							continue;
						case 0u:
							goto IL_2863;
						case 2u:
							result = false;
							num161 = (int)(num4 * 458786819) ^ -796170146;
							continue;
						case 4u:
							goto end_IL_2863;
						}
						break;
					}
					goto IL_280c;
					continue;
					end_IL_2863:
					break;
				}
			}
			finally
			{
				if (enumerator18 != null)
				{
					while (true)
					{
						IL_288e:
						int num174 = 933659008;
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)(num174 ^ 0x1406650B)) % 3)
							{
							case 0u:
								break;
							default:
								goto end_IL_2893;
							case 1u:
								goto IL_28b1;
							case 2u:
								goto end_IL_2893;
							}
							goto IL_288e;
							IL_28b1:
							enumerator18.Dispose();
							num174 = ((int)num4 * -1262964004) ^ 0x1E57E817;
							continue;
							end_IL_2893:
							break;
						}
						break;
					}
				}
			}
			num = 7;
			string text10 = default(string);
			Resource current28 = default(Resource);
			string text7 = default(string);
			string text9 = default(string);
			string text8 = default(string);
			while (true)
			{
				IL_28cb:
				int num175 = 1686176169;
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num175 ^ 0x1406650B)) % 3)
					{
					case 0u:
						break;
					case 2u:
						if (!CommonSettings.MOD_MODE)
						{
							goto IL_28f8;
						}
						goto IL_2e2e;
					default:
						{
							enumerator = ResourceManager.GetAll<Resource>().GetEnumerator();
							try
							{
								while (true)
								{
									IL_2d7b:
									int num176;
									int num177;
									if (enumerator.MoveNext())
									{
										num176 = 1079519507;
										num177 = num176;
									}
									else
									{
										num176 = 646936993;
										num177 = num176;
									}
									while (true)
									{
										switch ((num4 = (uint)(num176 ^ 0x1406650B)) % 27)
										{
										case 25u:
											num176 = 1079519507;
											continue;
										default:
											goto end_IL_291d;
										case 8u:
										{
											text10 = Path.Combine(Application.dataPath + global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(205221932u), current28.Value);
											int num186;
											int num187;
											if (File.Exists(text10 + global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3459643501u)))
											{
												num186 = 1521115469;
												num187 = num186;
											}
											else
											{
												num186 = 1048762793;
												num187 = num186;
											}
											num176 = num186 ^ (int)(num4 * 1269723580);
											continue;
										}
										case 23u:
											num176 = (int)(num4 * 847071952) ^ -244375631;
											continue;
										case 10u:
										{
											int num188;
											int num189;
											if (File.Exists(text10 + global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(75377659u)))
											{
												num188 = -1885034421;
												num189 = num188;
											}
											else
											{
												num188 = -2115760740;
												num189 = num188;
											}
											num176 = num188 ^ (int)(num4 * 1937654163);
											continue;
										}
										case 18u:
										{
											int num195;
											int num196;
											if (!current28.Key.StartsWith(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(838926887u)))
											{
												num195 = 1492964154;
												num196 = num195;
											}
											else
											{
												num195 = 1708999082;
												num196 = num195;
											}
											num176 = num195 ^ (int)(num4 * 87383819);
											continue;
										}
										case 0u:
											num176 = ((int)num4 * -1449692331) ^ -728455877;
											continue;
										case 6u:
										{
											int num179;
											if (!current28.Key.StartsWith(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3365444451u)))
											{
												num176 = 1778450596;
												num179 = num176;
											}
											else
											{
												num176 = 264076186;
												num179 = num176;
											}
											continue;
										}
										case 1u:
											logger.LogError(string.Format(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(563170413u), current28.Key, text7));
											result = false;
											num176 = (int)(num4 * 536964236) ^ -1131921685;
											continue;
										case 19u:
											logger.LogError(string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3112809469u), current28.Key, text9));
											result = false;
											num176 = ((int)num4 * -1630296748) ^ 0x65F29E79;
											continue;
										case 14u:
										{
											int num192;
											int num193;
											if (File.Exists(text9 + global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1628623496u)))
											{
												num192 = -1235068133;
												num193 = num192;
											}
											else
											{
												num192 = -1131039820;
												num193 = num192;
											}
											num176 = num192 ^ (int)(num4 * 862204114);
											continue;
										}
										case 24u:
											logger.LogError(string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(122165133u), current28.Key, text10));
											num176 = ((int)num4 * -1571975707) ^ -7487508;
											continue;
										case 11u:
										{
											int num182;
											int num183;
											if (!current28.Key.StartsWith(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(876662380u)))
											{
												num182 = 1023142603;
												num183 = num182;
											}
											else
											{
												num182 = 1002635037;
												num183 = num182;
											}
											num176 = num182 ^ ((int)num4 * -486050057);
											continue;
										}
										case 5u:
											logger.LogError(string.Format(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(504163549u), current28.Key, text8));
											result = false;
											num176 = (int)(num4 * 2053977929) ^ -1772801666;
											continue;
										case 9u:
										{
											int num197;
											int num198;
											if (!File.Exists(text9 + global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3600562442u)))
											{
												num197 = -2007591891;
												num198 = num197;
											}
											else
											{
												num197 = -378958371;
												num198 = num197;
											}
											num176 = num197 ^ (int)(num4 * 1358501180);
											continue;
										}
										case 7u:
										{
											int num194;
											if (!current28.Key.StartsWith(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2522377210u)))
											{
												num176 = 589059588;
												num194 = num176;
											}
											else
											{
												num176 = 1681473200;
												num194 = num176;
											}
											continue;
										}
										case 26u:
											current28 = enumerator.Current;
											num176 = 1850241983;
											continue;
										case 20u:
											text9 = Path.Combine(Application.dataPath + global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3096452060u), current28.Value);
											num176 = (int)((num4 * 123116169) ^ 0x5CC901CA);
											continue;
										case 12u:
										{
											int num190;
											int num191;
											if (File.Exists(text8 + global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3159771589u)))
											{
												num190 = 1333880779;
												num191 = num190;
											}
											else
											{
												num190 = 1715136276;
												num191 = num190;
											}
											num176 = num190 ^ (int)(num4 * 879658898);
											continue;
										}
										case 17u:
										{
											int num184;
											int num185;
											if (File.Exists(text8 + global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1628623496u)))
											{
												num184 = 1668933273;
												num185 = num184;
											}
											else
											{
												num184 = 919346742;
												num185 = num184;
											}
											num176 = num184 ^ ((int)num4 * -1656836190);
											continue;
										}
										case 4u:
											num176 = (int)(num4 * 1748123166) ^ -916843111;
											continue;
										case 3u:
											result = false;
											num176 = (int)(num4 * 1987753691) ^ -477811669;
											continue;
										case 15u:
											text8 = Path.Combine(Application.dataPath + global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1943569622u), current28.Value);
											num176 = ((int)num4 * -1727917170) ^ 0x12C19A5;
											continue;
										case 13u:
										{
											int num180;
											int num181;
											if (!File.Exists(text7))
											{
												num180 = -250079054;
												num181 = num180;
											}
											else
											{
												num180 = -2086820631;
												num181 = num180;
											}
											num176 = num180 ^ ((int)num4 * -1884194755);
											continue;
										}
										case 21u:
											break;
										case 16u:
										{
											int num178;
											if (!current28.Key.StartsWith(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2718822631u)))
											{
												num176 = 1843139121;
												num178 = num176;
											}
											else
											{
												num176 = 1740990247;
												num178 = num176;
											}
											continue;
										}
										case 2u:
											text7 = Path.Combine(Application.dataPath + global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3096452060u), current28.Value);
											num176 = 1393312435;
											continue;
										case 22u:
											goto end_IL_291d;
										}
										goto IL_2d7b;
										continue;
										end_IL_291d:
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
										IL_2df4:
										int num199 = 1254795303;
										while (true)
										{
											switch ((num4 = (uint)(num199 ^ 0x1406650B)) % 3)
											{
											case 0u:
												break;
											default:
												goto end_IL_2df9;
											case 1u:
												goto IL_2e17;
											case 2u:
												goto end_IL_2df9;
											}
											goto IL_2df4;
											IL_2e17:
											enumerator.Dispose();
											num199 = (int)((num4 * 1809898834) ^ 0x36D289CF);
											continue;
											end_IL_2df9:
											break;
										}
										break;
									}
								}
							}
							goto IL_2e2e;
						}
						IL_2e2e:
						num = 8;
						goto end_IL_28d0;
					}
					goto IL_28cb;
					IL_28f8:
					num175 = (int)(num4 * 327864523) ^ -1216649934;
					continue;
					end_IL_28d0:
					break;
				}
				break;
			}
		}
		catch
		{
			while (true)
			{
				IL_2e33:
				int num200 = 1882180148;
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num200 ^ 0x1406650B)) % 3)
					{
					case 0u:
						break;
					default:
						goto end_IL_2e38;
					case 1u:
						goto IL_2e56;
					case 2u:
						goto end_IL_2e38;
					}
					goto IL_2e33;
					IL_2e56:
					Debug.LogError((object)(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1773724326u) + num));
					result = false;
					num200 = ((int)num4 * -2067155328) ^ -1382635957;
					continue;
					end_IL_2e38:
					break;
				}
				break;
			}
		}
		logger.LogError(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(716940082u));
		return result;
	}

	static bool _206D_200E_206E_200C_202D_202E_206C_200F_206E_202B_200F_200F_200E_200C_200F_202C_202E_200F_202C_206B_200C_206D_200F_206A_206D_206E_200F_202D_202A_200F_200E_202B_200C_206C_200D_206F_200D_206A_206F_206A_202E(string P_0, string P_1)
	{
		return P_0.StartsWith(P_1);
	}

	static string _200B_200E_206C_200F_202D_206B_206B_200D_206E_200C_202C_200F_202E_202D_202A_206C_206F_200D_206D_206B_202A_200E_206F_202C_202B_200B_200E_206C_200C_200C_200E_206B_206C_206D_206F_202C_202D_206B_202D_202E_202E(string P_0, string P_1, string P_2)
	{
		return P_0.Replace(P_1, P_2);
	}

	static bool _202E_202B_200B_202C_202B_202E_206B_202B_202B_200E_202E_206D_206D_206A_200E_200B_202A_206E_206C_202E_206E_206B_200D_202E_206C_202A_202D_200F_200E_200D_202A_202D_206F_206E_200C_200B_200D_206E_202D_206F_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _202A_200C_200F_202D_206F_206F_202E_202E_202B_200E_202B_202D_206E_202B_206E_206D_206C_200F_206F_200B_200E_206D_206E_206C_202C_206D_202C_200D_200D_202C_202E_202B_200C_206E_206A_200D_206A_200E_200B_202A_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static bool _206C_202A_206E_202E_202A_202D_200F_202B_202E_202D_202B_206E_206C_200D_206C_206D_200E_200F_206E_200C_200C_202E_202A_202B_202D_206B_202D_200D_206A_206C_200B_200B_200C_202A_200E_206C_202E_200C_206B_202B_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static string[] _202E_206F_206E_206B_202A_206C_206A_206F_200C_206C_202C_202A_206D_200E_202C_200D_202C_206F_200C_200F_206E_202E_206D_202C_200C_200F_200E_206A_206B_206F_200C_202C_206D_200E_202A_206A_200B_202C_200C_202C_202E(string P_0, char[] P_1)
	{
		return P_0.Split(P_1);
	}

	static string _200C_200E_200D_206C_200D_200C_206F_202D_206C_202D_200E_202B_202E_202B_206C_200F_202E_202E_206E_202C_202A_202C_200B_206E_206E_202D_202A_200C_206D_206F_206C_200D_200E_202D_202D_206C_206A_206A_206D_206D_202E(string P_0, object P_1, object P_2, object P_3)
	{
		return string.Format(P_0, P_1, P_2, P_3);
	}

	static string _202B_202E_200F_200C_200F_202E_200B_206A_202C_200F_200C_202E_200B_206B_206D_206E_202D_206B_206C_206D_200B_200B_200D_206C_202A_202E_206A_206B_200E_206F_202A_206A_200E_200B_200C_200D_206C_200C_200C_206C_202E(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}
}
