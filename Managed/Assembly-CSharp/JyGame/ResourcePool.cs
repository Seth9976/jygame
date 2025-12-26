using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace JyGame;

public class ResourcePool
{
	[CompilerGenerated]
	private sealed class _200F_202A_206A_200C_206B_202A_206D_200F_202D_202A_200E_206C_206C_200E_202B_202E_200B_200B_200F_206B_200B_200B_206E_200C_202C_206B_202D_202C_202A_200D_206C_206A_202A_206F_206F_200F_200F_206A_206A_206C_202E : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;

		private object _200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E;

		public Battle battle;

		public CommonSettings.VoidCallBack callback;

		private List<string>.Enumerator _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E;
			}
		}

		[DebuggerHidden]
		public _200F_202A_206A_200C_206B_202A_206D_200F_202D_202A_200E_206C_206C_200E_202B_202E_200B_200B_200F_206B_200B_200B_206E_200C_202C_206B_202D_202C_202A_200D_206C_206A_202A_206F_206F_200F_200F_206A_206A_206C_202E(int P_0)
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = P_0;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;
			while (true)
			{
				int num2 = 974601293;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x45E1F4DB)) % 4)
					{
					case 0u:
						break;
					case 2u:
					{
						int num4;
						int num5;
						if (num != -3)
						{
							num4 = 1385719970;
							num5 = num4;
						}
						else
						{
							num4 = 925863840;
							num5 = num4;
						}
						num2 = num4 ^ ((int)num3 * -1820460780);
						continue;
					}
					case 1u:
						if (num == 2)
						{
							num2 = (int)(num3 * 206764711) ^ -1411158785;
							continue;
						}
						return;
					default:
						try
						{
							return;
						}
						finally
						{
							_202D_202A_202A_200E_206E_202E_206C_202C_206F_202C_200C_202E_202A_206E_202B_202D_202C_206F_206C_206A_202A_200F_206A_200F_206D_200B_200C_202C_202B_206E_200E_206C_202D_200D_202E_202D_206D_206D_202B_202C_202E();
						}
					}
					break;
				}
			}
		}

		private bool MoveNext()
		{
			bool result = default(bool);
			try
			{
				int num = _200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E;
				List<string> list2 = default(List<string>);
				string item = default(string);
				Role role = default(Role);
				string text = default(string);
				string item2 = default(string);
				UniqueSkillInstance current3 = default(UniqueSkillInstance);
				string item3 = default(string);
				string item4 = default(string);
				string item5 = default(string);
				string item6 = default(string);
				SpecialSkillInstance current4 = default(SpecialSkillInstance);
				string item8 = default(string);
				string item7 = default(string);
				UniqueSkillInstance current5 = default(UniqueSkillInstance);
				Aoyi current7 = default(Aoyi);
				string item9 = default(string);
				GameObject val = default(GameObject);
				string current8 = default(string);
				string text2 = default(string);
				bool flag = default(bool);
				UserDefinedAnimtionData animation2 = default(UserDefinedAnimtionData);
				UserDefinedAnimtionData animation3 = default(UserDefinedAnimtionData);
				while (true)
				{
					IL_0007:
					int num2 = -161625188;
					while (true)
					{
						int num54;
						uint num3;
						switch ((num3 = (uint)(num2 ^ -1064843462)) % 9)
						{
						case 6u:
							break;
						case 8u:
							_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = 0;
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 1;
							result = true;
							num2 = ((int)num3 * -1144352682) ^ 0x3B3C17A0;
							continue;
						case 5u:
							list2 = new List<string>();
							num2 = (int)((num3 * 2009732513) ^ 0x5A61A36D);
							continue;
						case 0u:
							goto end_IL_000c;
						case 3u:
							switch (num)
							{
							case 1:
								goto IL_00e0;
							case 0:
								goto IL_00f1;
							case 3:
								goto IL_0ce0;
							case 4:
								goto IL_0dfb;
							case 2:
								goto IL_0ebb;
							}
							num2 = (int)((num3 * 200924837) ^ 0x4296015);
							continue;
						case 1u:
							result = false;
							goto end_IL_000c;
						case 4u:
							goto IL_00e0;
						case 2u:
							goto IL_00f1;
						default:
							{
								List<string> list = new List<string>();
								using (List<BattleRole>.Enumerator enumerator = battle.Roles.GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										while (true)
										{
											BattleRole current = enumerator.Current;
											int num4 = -1238229338;
											while (true)
											{
												string animation;
												switch ((num3 = (uint)(num4 ^ -1064843462)) % 9)
												{
												case 0u:
													num4 = -1626718036;
													continue;
												case 4u:
												{
													int num9;
													int num10;
													if (!list2.Contains(item))
													{
														num9 = 779305175;
														num10 = num9;
													}
													else
													{
														num9 = 730812174;
														num10 = num9;
													}
													num4 = num9 ^ (int)(num3 * 817879350);
													continue;
												}
												case 1u:
													if (!UserDefinedAnimationManager.instance.Animations.Contains(current.Animation))
													{
														num4 = (int)(num3 * 716970084) ^ -1755438243;
														continue;
													}
													animation = current.Animation;
													goto IL_01c2;
												case 2u:
													animation = role.GetAnimation();
													goto IL_01c2;
												case 7u:
													list2.Add(item);
													num4 = ((int)num3 * -1861008009) ^ -149682395;
													continue;
												case 6u:
												{
													role = current.role;
													int num7;
													int num8;
													if (_206B_202E_206B_206F_200E_206C_202B_206D_206A_200E_200D_200D_206A_206D_200D_200C_206B_206D_202B_202D_202B_202D_200B_206A_202B_200D_206C_206A_202C_200F_206B_206C_202E_206A_200B_206B_202C_200D_206B_206D_202E(current.Animation))
													{
														num7 = -1128354647;
														num8 = num7;
													}
													else
													{
														num7 = -74717892;
														num8 = num7;
													}
													num4 = num7 ^ ((int)num3 * -502175951);
													continue;
												}
												case 8u:
													break;
												case 5u:
												{
													item = _200C_200D_200D_206F_200C_206C_200E_206E_206C_206D_200F_206E_200E_200D_200D_202B_202A_200C_206E_206F_206F_202A_206F_200B_202D_200C_200B_206C_206E_206D_202B_200B_206A_200D_202D_206D_200B_200B_206A_206C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(900743811u), text);
													int num5;
													int num6;
													if (_206B_202E_206B_206F_200E_206C_202B_206D_206A_200E_200D_200D_206A_206D_200D_200C_206B_206D_202B_202D_202B_202D_200B_206A_202B_200D_206C_206A_202C_200F_206B_206C_202E_206A_200B_206B_202C_200D_206B_206D_202E(text))
													{
														num5 = 1493597610;
														num6 = num5;
													}
													else
													{
														num5 = 143401613;
														num6 = num5;
													}
													num4 = num5 ^ ((int)num3 * -805639122);
													continue;
												}
												default:
													goto end_IL_021d;
													IL_01c2:
													text = animation;
													num4 = -1444821407;
													continue;
												}
												break;
											}
											continue;
											end_IL_021d:
											break;
										}
										using (List<SkillInstance>.Enumerator enumerator2 = role.Skills.GetEnumerator())
										{
											while (enumerator2.MoveNext())
											{
												SkillInstance current2;
												while (true)
												{
													current2 = enumerator2.Current;
													int num11;
													int num12;
													if (!list.Contains(current2.Name))
													{
														num11 = -1309757696;
														num12 = num11;
													}
													else
													{
														num11 = -836969463;
														num12 = num11;
													}
													while (true)
													{
														switch ((num3 = (uint)(num11 ^ -1064843462)) % 8)
														{
														case 6u:
															num11 = -1321478986;
															continue;
														case 3u:
															break;
														case 5u:
															item2 = _200C_200D_200D_206F_200C_206C_200E_206E_206C_206D_200F_206E_200E_200D_200D_202B_202A_200C_206E_206F_206F_202A_206F_200B_202D_200C_200B_206C_206E_206D_202B_200B_206A_200D_202D_206D_200B_200B_206A_206C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4063542567u), current2.Animation);
															num11 = (int)(num3 * 2055509180) ^ -414801561;
															continue;
														case 4u:
															goto end_IL_0281;
														case 1u:
														{
															int num13;
															int num14;
															if (!list2.Contains(item2))
															{
																num13 = -1698990496;
																num14 = num13;
															}
															else
															{
																num13 = -2053051793;
																num14 = num13;
															}
															num11 = num13 ^ (int)(num3 * 352133317);
															continue;
														}
														case 2u:
															list.Add(current2.Name);
															num11 = ((int)num3 * -1532952717) ^ -210287609;
															continue;
														case 7u:
															list2.Add(item2);
															num11 = (int)(num3 * 1734162750) ^ -1758524008;
															continue;
														default:
															goto end_IL_02fd;
														}
														int num15;
														if (_206B_202E_206B_206F_200E_206C_202B_206D_206A_200E_200D_200D_206A_206D_200D_200C_206B_206D_202B_202D_202B_202D_200B_206A_202B_200D_206C_206A_202C_200F_206B_206C_202E_206A_200B_206B_202C_200D_206B_206D_202E(current2.Animation))
														{
															num11 = -956014790;
															num15 = num11;
														}
														else
														{
															num11 = -1877548777;
															num15 = num11;
														}
														continue;
														end_IL_0281:
														break;
													}
													continue;
													end_IL_02fd:
													break;
												}
												using List<UniqueSkillInstance>.Enumerator enumerator3 = current2.UniqueSkills.GetEnumerator();
												while (true)
												{
													IL_03fa:
													int num16;
													int num17;
													if (enumerator3.MoveNext())
													{
														num16 = -1228131297;
														num17 = num16;
													}
													else
													{
														num16 = -642827619;
														num17 = num16;
													}
													while (true)
													{
														switch ((num3 = (uint)(num16 ^ -1064843462)) % 17)
														{
														case 0u:
															num16 = -1228131297;
															continue;
														default:
															goto end_IL_03a0;
														case 8u:
															break;
														case 11u:
														{
															int num24;
															if (_206B_202E_206B_206F_200E_206C_202B_206D_206A_200E_200D_200D_206A_206D_200D_200C_206B_206D_202B_202D_202B_202D_200B_206A_202B_200D_206C_206A_202C_200F_206B_206C_202E_206A_200B_206B_202C_200D_206B_206D_202E(current3.UniqueSkill.temp_animation))
															{
																num16 = -297499279;
																num24 = num16;
															}
															else
															{
																num16 = -2058681222;
																num24 = num16;
															}
															continue;
														}
														case 4u:
															list.Add(current3.Name);
															num16 = ((int)num3 * -319689541) ^ 0x2751FBD9;
															continue;
														case 10u:
															item3 = _200C_200D_200D_206F_200C_206C_200E_206E_206C_206D_200F_206E_200E_200D_200D_202B_202A_200C_206E_206F_206F_202A_206F_200B_202D_200C_200B_206C_206E_206D_202B_200B_206A_200D_202D_206D_200B_200B_206A_206C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(753338515u), _202D_200C_206F_206C_200E_200D_206F_200F_206C_206B_202D_202E_200C_202B_206B_206B_206F_202E_200B_206B_206C_200C_202C_200F_202A_200B_206A_202C_206B_206F_206C_206E_200B_206C_200D_202C_200F_200D_206F_202A_202E(current3.RoleEffect, new char[1] { '#' })[0]);
															num16 = ((int)num3 * -1037064274) ^ -1241018736;
															continue;
														case 13u:
															list2.Add(item4);
															num16 = (int)((num3 * 243951266) ^ 0x7DB28357);
															continue;
														case 6u:
														{
															int num28;
															if (!_206B_202E_206B_206F_200E_206C_202B_206D_206A_200E_200D_200D_206A_206D_200D_200C_206B_206D_202B_202D_202B_202D_200B_206A_202B_200D_206C_206A_202C_200F_206B_206C_202E_206A_200B_206B_202C_200D_206B_206D_202E(current3.RoleEffect))
															{
																num16 = -341664921;
																num28 = num16;
															}
															else
															{
																num16 = -424037247;
																num28 = num16;
															}
															continue;
														}
														case 3u:
														{
															int num25;
															if (_206B_202E_206B_206F_200E_206C_202B_206D_206A_200E_200D_200D_206A_206D_200D_200C_206B_206D_202B_202D_202B_202D_200B_206A_202B_200D_206C_206A_202C_200F_206B_206C_202E_206A_200B_206B_202C_200D_206B_206D_202E(current3.Animation))
															{
																num16 = -1317435451;
																num25 = num16;
															}
															else
															{
																num16 = -122898251;
																num25 = num16;
															}
															continue;
														}
														case 15u:
														{
															int num20;
															int num21;
															if (list2.Contains(item4))
															{
																num20 = 351880745;
																num21 = num20;
															}
															else
															{
																num20 = 2081879983;
																num21 = num20;
															}
															num16 = num20 ^ ((int)num3 * -1476287108);
															continue;
														}
														case 2u:
															list2.Add(item5);
															num16 = ((int)num3 * -1826734259) ^ -430135095;
															continue;
														case 14u:
															current3 = enumerator3.Current;
															num16 = -2106988796;
															continue;
														case 12u:
															item4 = _200C_200D_200D_206F_200C_206C_200E_206E_206C_206D_200F_206E_200E_200D_200D_202B_202A_200C_206E_206F_206F_202A_206F_200B_202D_200C_200B_206C_206E_206D_202B_200B_206A_200D_202D_206D_200B_200B_206A_206C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(753338515u), current3.Animation);
															num16 = (int)((num3 * 312960960) ^ 0x4C74D11F);
															continue;
														case 5u:
														{
															item5 = _200C_200D_200D_206F_200C_206C_200E_206E_206C_206D_200F_206E_200E_200D_200D_202B_202A_200C_206E_206F_206F_202A_206F_200B_202D_200C_200B_206C_206E_206D_202B_200B_206A_200D_202D_206D_200B_200B_206A_206C_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2081968230u), current3.UniqueSkill.temp_animation);
															int num26;
															int num27;
															if (!list2.Contains(item5))
															{
																num26 = 1744420066;
																num27 = num26;
															}
															else
															{
																num26 = 1428817457;
																num27 = num26;
															}
															num16 = num26 ^ (int)(num3 * 1163584257);
															continue;
														}
														case 7u:
														{
															int num22;
															int num23;
															if (list.Contains(current3.Name))
															{
																num22 = -2022783371;
																num23 = num22;
															}
															else
															{
																num22 = -1430655138;
																num23 = num22;
															}
															num16 = num22 ^ ((int)num3 * -887654612);
															continue;
														}
														case 16u:
															list2.Add(item3);
															num16 = (int)(num3 * 306187865) ^ -859924418;
															continue;
														case 1u:
														{
															int num18;
															int num19;
															if (list2.Contains(item3))
															{
																num18 = -1662625519;
																num19 = num18;
															}
															else
															{
																num18 = -215479683;
																num19 = num18;
															}
															num16 = num18 ^ (int)(num3 * 43659516);
															continue;
														}
														case 9u:
															goto end_IL_03a0;
														}
														goto IL_03fa;
														continue;
														end_IL_03a0:
														break;
													}
													break;
												}
											}
										}
										using (List<SpecialSkillInstance>.Enumerator enumerator4 = role.SpecialSkills.GetEnumerator())
										{
											while (true)
											{
												IL_0697:
												int num29;
												int num30;
												if (!enumerator4.MoveNext())
												{
													num29 = -1677171994;
													num30 = num29;
												}
												else
												{
													num29 = -1972613942;
													num30 = num29;
												}
												while (true)
												{
													switch ((num3 = (uint)(num29 ^ -1064843462)) % 6)
													{
													case 0u:
														num29 = -1972613942;
														continue;
													default:
														goto end_IL_066a;
													case 5u:
														break;
													case 3u:
													{
														item6 = _200C_200D_200D_206F_200C_206C_200E_206E_206C_206D_200F_206E_200E_200D_200D_202B_202A_200C_206E_206F_206F_202A_206F_200B_202D_200C_200B_206C_206E_206D_202B_200B_206A_200D_202D_206D_200B_200B_206A_206C_202E(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(753338515u), current4.Animation);
														int num32;
														int num33;
														if (!list2.Contains(item6))
														{
															num32 = -2109597431;
															num33 = num32;
														}
														else
														{
															num32 = -260307021;
															num33 = num32;
														}
														num29 = num32 ^ (int)(num3 * 46268088);
														continue;
													}
													case 1u:
														list2.Add(item6);
														num29 = ((int)num3 * -970183982) ^ 0x490AE05D;
														continue;
													case 4u:
													{
														current4 = enumerator4.Current;
														int num31;
														if (_206B_202E_206B_206F_200E_206C_202B_206D_206A_200E_200D_200D_206A_206D_200D_200C_206B_206D_202B_202D_202B_202D_200B_206A_202B_200D_206C_206A_202C_200F_206B_206C_202E_206A_200B_206B_202C_200D_206B_206D_202E(current4.Animation))
														{
															num29 = -129291461;
															num31 = num29;
														}
														else
														{
															num29 = -1311752211;
															num31 = num29;
														}
														continue;
													}
													case 2u:
														goto end_IL_066a;
													}
													goto IL_0697;
													continue;
													end_IL_066a:
													break;
												}
												break;
											}
										}
										if (role.EquippedInternalSkill == null)
										{
											while (true)
											{
												int num34 = -267354006;
												while (true)
												{
													switch ((num3 = (uint)(num34 ^ -1064843462)) % 3)
													{
													case 0u:
														break;
													case 2u:
														role.EquippedInternalSkill = role.GetEquippedInternalSkill();
														num34 = ((int)num3 * -1365461324) ^ 0x4AE764D6;
														continue;
													default:
														goto end_IL_074f;
													}
													break;
												}
												continue;
												end_IL_074f:
												break;
											}
										}
										using List<UniqueSkillInstance>.Enumerator enumerator3 = role.EquippedInternalSkill.UniqueSkills.GetEnumerator();
										while (true)
										{
											IL_0955:
											int num35;
											int num36;
											if (enumerator3.MoveNext())
											{
												num35 = -311715147;
												num36 = num35;
											}
											else
											{
												num35 = -451710727;
												num36 = num35;
											}
											while (true)
											{
												switch ((num3 = (uint)(num35 ^ -1064843462)) % 13)
												{
												case 0u:
													num35 = -311715147;
													continue;
												default:
													goto end_IL_07ad;
												case 8u:
													list2.Add(item8);
													num35 = ((int)num3 * -885615251) ^ 0x46572511;
													continue;
												case 12u:
												{
													int num39;
													int num40;
													if (!list2.Contains(item7))
													{
														num39 = -1410478246;
														num40 = num39;
													}
													else
													{
														num39 = -1035789606;
														num40 = num39;
													}
													num35 = num39 ^ ((int)num3 * -204147532);
													continue;
												}
												case 5u:
												{
													int num44;
													if (!_206B_202E_206B_206F_200E_206C_202B_206D_206A_200E_200D_200D_206A_206D_200D_200C_206B_206D_202B_202D_202B_202D_200B_206A_202B_200D_206C_206A_202C_200F_206B_206C_202E_206A_200B_206B_202C_200D_206B_206D_202E(current5.UniqueSkill.temp_animation))
													{
														num35 = -729492472;
														num44 = num35;
													}
													else
													{
														num35 = -1898918886;
														num44 = num35;
													}
													continue;
												}
												case 10u:
												{
													item8 = _200C_200D_200D_206F_200C_206C_200E_206E_206C_206D_200F_206E_200E_200D_200D_202B_202A_200C_206E_206F_206F_202A_206F_200B_202D_200C_200B_206C_206E_206D_202B_200B_206A_200D_202D_206D_200B_200B_206A_206C_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1101823350u), current5.Animation);
													int num41;
													int num42;
													if (list2.Contains(item8))
													{
														num41 = -655584381;
														num42 = num41;
													}
													else
													{
														num41 = -2053114352;
														num42 = num41;
													}
													num35 = num41 ^ (int)(num3 * 2057403710);
													continue;
												}
												case 3u:
													item7 = _200C_200D_200D_206F_200C_206C_200E_206E_206C_206D_200F_206E_200E_200D_200D_202B_202A_200C_206E_206F_206F_202A_206F_200B_202D_200C_200B_206C_206E_206D_202B_200B_206A_200D_202D_206D_200B_200B_206A_206C_202E(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2081968230u), current5.UniqueSkill.temp_animation);
													num35 = ((int)num3 * -1374534396) ^ -1148372094;
													continue;
												case 7u:
													list.Add(current5.Name);
													num35 = ((int)num3 * -1541993783) ^ 0x66686C4F;
													continue;
												case 6u:
													list2.Add(item7);
													num35 = ((int)num3 * -1820256111) ^ -1361652550;
													continue;
												case 11u:
												{
													int num43;
													if (!_206B_202E_206B_206F_200E_206C_202B_206D_206A_200E_200D_200D_206A_206D_200D_200C_206B_206D_202B_202D_202B_202D_200B_206A_202B_200D_206C_206A_202C_200F_206B_206C_202E_206A_200B_206B_202C_200D_206B_206D_202E(current5.Animation))
													{
														num35 = -246452802;
														num43 = num35;
													}
													else
													{
														num35 = -164418437;
														num43 = num35;
													}
													continue;
												}
												case 1u:
												{
													int num37;
													int num38;
													if (!list.Contains(current5.Name))
													{
														num37 = 542889527;
														num38 = num37;
													}
													else
													{
														num37 = 1920687258;
														num38 = num37;
													}
													num35 = num37 ^ ((int)num3 * -443907985);
													continue;
												}
												case 2u:
													break;
												case 4u:
													current5 = enumerator3.Current;
													num35 = -996529112;
													continue;
												case 9u:
													goto end_IL_07ad;
												}
												goto IL_0955;
												continue;
												end_IL_07ad:
												break;
											}
											break;
										}
									}
								}
								foreach (string item10 in list)
								{
									IEnumerator<Aoyi> enumerator6 = ResourceManager.GetAll<Aoyi>().GetEnumerator();
									try
									{
										while (true)
										{
											IL_0a14:
											int num45;
											int num46;
											if (!_206A_202A_200C_206B_206C_206D_200D_206D_202C_200D_206F_200F_202B_206F_206F_200E_202B_202B_200F_206C_200C_206B_202A_200E_200F_202B_200F_200E_206F_202E_202D_202A_202A_200B_202C_202C_202D_206C_200F_202D_202E((IEnumerator)enumerator6))
											{
												num45 = -1210810704;
												num46 = num45;
											}
											else
											{
												num45 = -663757942;
												num46 = num45;
											}
											while (true)
											{
												switch ((num3 = (uint)(num45 ^ -1064843462)) % 9)
												{
												case 5u:
													num45 = -663757942;
													continue;
												default:
													goto end_IL_09da;
												case 8u:
													break;
												case 6u:
												{
													int num51;
													int num52;
													if (!_206A_206D_200B_200B_202C_206F_206A_200B_206F_206F_206F_206C_206E_200C_202A_200F_206D_202A_202B_200E_206B_206D_200F_200F_200E_206E_202D_200C_202A_200C_200C_202C_200F_200F_200E_202D_206A_206D_206B_202A_202E(current7.start, item10))
													{
														num51 = -1192264927;
														num52 = num51;
													}
													else
													{
														num51 = -835174879;
														num52 = num51;
													}
													num45 = num51 ^ ((int)num3 * -823362840);
													continue;
												}
												case 2u:
													list2.Add(item9);
													num45 = ((int)num3 * -405117111) ^ 0x1D0A2570;
													continue;
												case 0u:
													item9 = _200C_200D_200D_206F_200C_206C_200E_206E_206C_206D_200F_206E_200E_200D_200D_202B_202A_200C_206E_206F_206F_202A_206F_200B_202D_200C_200B_206C_206E_206D_202B_200B_206A_200D_202D_206D_200B_200B_206A_206C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4063542567u), current7.animation);
													num45 = (int)(num3 * 636518834) ^ -714884964;
													continue;
												case 4u:
												{
													int num49;
													int num50;
													if (!_206B_202E_206B_206F_200E_206C_202B_206D_206A_200E_200D_200D_206A_206D_200D_200C_206B_206D_202B_202D_202B_202D_200B_206A_202B_200D_206C_206A_202C_200F_206B_206C_202E_206A_200B_206B_202C_200D_206B_206D_202E(current7.animation))
													{
														num49 = 1959268615;
														num50 = num49;
													}
													else
													{
														num49 = 42676618;
														num50 = num49;
													}
													num45 = num49 ^ (int)(num3 * 736929393);
													continue;
												}
												case 1u:
													current7 = enumerator6.Current;
													num45 = -1836847941;
													continue;
												case 7u:
												{
													int num47;
													int num48;
													if (!list2.Contains(item9))
													{
														num47 = 1947019969;
														num48 = num47;
													}
													else
													{
														num47 = 959505859;
														num48 = num47;
													}
													num45 = num47 ^ (int)(num3 * 252794889);
													continue;
												}
												case 3u:
													goto end_IL_09da;
												}
												goto IL_0a14;
												continue;
												end_IL_09da:
												break;
											}
											break;
										}
									}
									finally
									{
										if (enumerator6 != null)
										{
											while (true)
											{
												IL_0b09:
												int num53 = -1775267626;
												while (true)
												{
													switch ((num3 = (uint)(num53 ^ -1064843462)) % 3)
													{
													case 2u:
														break;
													default:
														goto end_IL_0b0e;
													case 1u:
														goto IL_0b2c;
													case 0u:
														goto end_IL_0b0e;
													}
													goto IL_0b09;
													IL_0b2c:
													_202A_206F_200C_202B_206F_202D_202E_200E_206E_202B_206F_200B_206A_202E_200E_206A_206B_200D_200E_202D_206B_206D_206C_200F_206F_202D_200B_202C_206A_202C_200F_202B_206E_206B_200C_200E_206C_202E_202B_206E_202E((IDisposable)enumerator6);
													num53 = (int)(num3 * 623233608) ^ -1965501858;
													continue;
													end_IL_0b0e:
													break;
												}
												break;
											}
										}
									}
								}
								_200C_200D_202D_206C_202D_202D_200C_202B_202B_206F_202E_200C_206F_200B_206F_206C_200E_206C_202E_206E_202D_202C_206C_206F_206F_206A_206F_200B_200F_206C_206E_200C_200C_200D_200C_202E_206E_202B_206E_202B_202E = list2.Count;
								_202A_206E_202D_202A_206D_206F_206A_200F_206D_200C_206D_206A_200E_202A_200D_200D_206C_202D_200B_200B_200D_202B_200B_200D_200D_200F_200F_206F_200C_200E_200C_200B_200F_206A_200E_202E_206C_200D_202E_202E = 0;
								goto IL_0b71;
							}
							IL_0ce0:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
							num54 = -1723995110;
							goto IL_0b76;
							IL_0b76:
							while (true)
							{
								switch ((num3 = (uint)(num54 ^ -1064843462)) % 44)
								{
								case 17u:
									break;
								default:
									goto end_IL_000c;
								case 16u:
								{
									int num66;
									int num67;
									if (!_202B_202C_206A_200F_202B_200E_200B_202D_206E_200B_200E_202A_200F_206D_200D_206C_200D_200B_202B_202D_206D_206A_202E_206F_202B_202B_206F_206C_202E_206C_206B_206A_202B_206C_200C_202D_200C_202A_202D_202D_202E((Object)(object)val, (Object)null))
									{
										num66 = -2040169063;
										num67 = num66;
									}
									else
									{
										num66 = -1818862248;
										num67 = num66;
									}
									num54 = num66 ^ ((int)num3 * -1455669055);
									continue;
								}
								case 14u:
									_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 3;
									num54 = ((int)num3 * -806746328) ^ 0x4864C9CE;
									continue;
								case 11u:
									goto IL_0c7d;
								case 31u:
									_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = 0;
									num54 = -620812278;
									continue;
								case 15u:
								{
									int num61 = _206C_206F_200F_200D_202D_200F_200C_200B_206C_200D_202B_200D_202A_200E_202A_202D_206B_202E_206C_206F_206B_202A_200C_206D_200D_200F_206B_200E_206C_206A_206D_206A_200F_206F_206B_206F_202D_202D_206F_202E(current8, '/') + 1;
									text2 = _206D_206C_206E_206F_200C_206B_200C_200F_206D_206A_200E_202E_202C_200D_202B_206B_202D_200E_202C_200D_202D_200E_202E_206F_202C_202C_206C_206C_206D_200E_206D_206A_200C_206C_200C_202A_202D_200E_206C_206F_202E(current8, num61, _202E_206A_206D_202B_200F_206F_206E_200B_200E_202C_206C_206F_200D_202B_202C_206A_206F_202B_200F_206F_202A_206E_200F_202B_202E_202E_202B_206C_206D_202E_206A_202B_200B_202B_202E_202E_206E_200E_202A_200C_202E(current8) - num61);
									num54 = ((int)num3 * -2004685567) ^ 0x57741A97;
									continue;
								}
								case 19u:
									goto IL_0ce0;
								case 23u:
								{
									int num70;
									int num71;
									if (CommonSettings.MOD_KEY() < 0)
									{
										num70 = 1941743987;
										num71 = num70;
									}
									else
									{
										num70 = 131975437;
										num71 = num70;
									}
									num54 = num70 ^ (int)(num3 * 316880116);
									continue;
								}
								case 40u:
									result = true;
									num54 = ((int)num3 * -1062201159) ^ -341490448;
									continue;
								case 34u:
									val = Resources.Load<GameObject>(current8);
									num54 = (int)((num3 * 1197493616) ^ 0x29BCBBBB);
									continue;
								case 21u:
									flag = true;
									num54 = ((int)num3 * -1564127948) ^ -1528831516;
									continue;
								case 27u:
								{
									int num62;
									int num63;
									if (animation2 != null)
									{
										num62 = -1932000058;
										num63 = num62;
									}
									else
									{
										num62 = -156715552;
										num63 = num62;
									}
									num54 = num62 ^ (int)(num3 * 754088069);
									continue;
								}
								case 38u:
									_202D_202D_202D_206D_206D_206A_200F_202C_202A_200B_206A_206D_202E_202D_200E_206B_200F_202C_206D_200B_200F_206D_202B_206C_202B_200B_202D_202D_200D_202B_206B_200D_200B_202B_202A_206A_206D_206B_200F_206E_202E((object)_200C_200D_200D_206F_200C_206C_200E_206E_206C_206D_200F_206E_200E_200D_200D_202B_202A_200C_206E_206F_206F_202A_206F_200B_202D_200C_200B_206C_206E_206D_202B_200B_206A_200D_202D_206D_200B_200B_206A_206C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2639879362u), text2));
									num54 = ((int)num3 * -972124934) ^ 0x7BF0AAC;
									continue;
								case 5u:
									animation2 = UserDefinedAnimationManager.instance.GetAnimation(text2, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2690174512u));
									num54 = (int)((num3 * 1353418899) ^ 0x121DDD9E);
									continue;
								case 42u:
									_202D_202D_202D_206D_206D_206A_200F_202C_202A_200B_206A_206D_202E_202D_200E_206B_200F_202C_206D_200B_200F_206D_202B_206C_202B_200B_202D_202D_200D_202B_206B_200D_200B_202B_202A_206A_206D_206B_200F_206E_202E((object)_200C_200D_200D_206F_200C_206C_200E_206E_206C_206D_200F_206E_200E_200D_200D_202B_202A_200C_206E_206F_206F_202A_206F_200B_202D_200C_200B_206C_206E_206D_202B_200B_206A_200D_202D_206D_200B_200B_206A_206C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4159584611u), current8));
									num54 = (int)(num3 * 1834453398) ^ -1096915375;
									continue;
								case 37u:
									goto IL_0dfb;
								case 12u:
									_202D_202D_202D_206D_206D_206A_200F_202C_202A_200B_206A_206D_202E_202D_200E_206B_200F_202C_206D_200B_200F_206D_202B_206C_202B_200B_202D_202D_200D_202B_206B_200D_200B_202B_202A_206A_206D_206B_200F_206E_202E((object)_200C_200D_200D_206F_200C_206C_200E_206E_206C_206D_200F_206E_200E_200D_200D_202B_202A_200C_206E_206F_206F_202A_206F_200B_202D_200C_200B_206C_206E_206D_202B_200B_206A_200D_202D_206D_200B_200B_206A_206C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4235055597u), text2));
									num54 = ((int)num3 * -2008116803) ^ 0x3BE1B782;
									continue;
								case 33u:
								{
									int num68;
									int num69;
									if (!_206D_200E_202D_202C_206D_206B_202A_200B_206B_202E_202E_206D_202E_206F_200B_206E_200E_202A_202E_202E_200D_202A_206C_200D_200F_200D_200C_206A_200C_206B_200B_206E_200B_206B_206B_202C_206C_202B_200E_200C_202E((Object)(object)val, (Object)null))
									{
										num68 = 1099532438;
										num69 = num68;
									}
									else
									{
										num68 = 736876116;
										num69 = num68;
									}
									num54 = num68 ^ ((int)num3 * -535092759);
									continue;
								}
								case 13u:
									_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 4;
									result = true;
									goto end_IL_000c;
								case 43u:
									num54 = ((int)num3 * -645858902) ^ -557201943;
									continue;
								case 41u:
									_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = 0;
									num54 = -962780485;
									continue;
								case 20u:
									result = true;
									num54 = ((int)num3 * -1799825710) ^ -1610454839;
									continue;
								case 8u:
									goto IL_0ebb;
								case 28u:
									_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = 2;
									num54 = ((int)num3 * -1554652737) ^ -1828935678;
									continue;
								case 25u:
									current8 = _206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.Current;
									num54 = -580914737;
									continue;
								case 36u:
								{
									int num64;
									int num65;
									if (callback != null)
									{
										num64 = 1695205503;
										num65 = num64;
									}
									else
									{
										num64 = 221838943;
										num65 = num64;
									}
									num54 = num64 ^ (int)(num3 * 815895349);
									continue;
								}
								case 4u:
									result = false;
									num54 = (int)(num3 * 499356095) ^ -1710514174;
									continue;
								case 18u:
								{
									int num59;
									int num60;
									if (!_206A_202A_206D_202D_206B_200F_200C_200E_202A_206A_206C_202B_200B_206D_200F_202D_200B_202C_200F_200D_206F_200B_206A_200F_200C_206A_202A_200D_200C_200D_202E_200D_200C_206D_202B_202C_200F_206E_200D_200E_202E(current8, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(875055782u)))
									{
										num59 = -1512753574;
										num60 = num59;
									}
									else
									{
										num59 = -549720677;
										num60 = num59;
									}
									num54 = num59 ^ ((int)num3 * -1128876494);
									continue;
								}
								case 35u:
									goto IL_0f68;
								case 2u:
									flag = false;
									num54 = -1724264235;
									continue;
								case 0u:
									goto IL_0f96;
								case 29u:
									_202A_206E_202D_202A_206D_206F_206A_200F_206D_200C_206D_206A_200E_202A_200D_200D_206C_202D_200B_200B_200D_202B_200B_200D_200D_200F_200F_206F_200C_200E_200C_200B_200F_206A_200E_202E_206C_200D_202E_202E++;
									num54 = -601193542;
									continue;
								case 26u:
									_200E_202B_206C_206A_206A_202C_200E_206A_206C_200F_206F_206E_202E_206A_200F_202B_206A_200F_202C_202E_202E_200E_206B_200E_206B_206F_206C_200E_200D_202E_200C_202B_206F_202B_200C_200F_202A_202B_202A_206A_202E.Add(current8, val);
									num54 = (int)(num3 * 771551146) ^ -544975347;
									continue;
								case 22u:
								{
									int num57;
									int num58;
									if (UserDefinedAnimationManager.instance.PreloadEffect(animation3))
									{
										num57 = 696845312;
										num58 = num57;
									}
									else
									{
										num57 = 1130246488;
										num58 = num57;
									}
									num54 = num57 ^ ((int)num3 * -2070279547);
									continue;
								}
								case 30u:
									_202D_202A_202A_200E_206E_202E_206C_202C_206F_202C_200C_202E_202A_206E_202B_202D_202C_206F_206C_206A_202A_200F_206A_200F_206D_200B_200C_202C_202B_206E_200E_206C_202D_200D_202E_202D_206D_206D_202B_202C_202E();
									_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = default(List<string>.Enumerator);
									_200E_202C_200E_206C_200B_202B_206F_200B_202B_206F_202A_202E_206A_200B_200C_206C_206B_206E_200E_206C_202B_200E_206D_200D_200D_202D_206A_200D_206F_206E_206F_200E_206A_206F_200B_206C_200E_206C_202E_206E_202E = 0;
									num54 = (int)((num3 * 1113947457) ^ 0x2076CB66);
									continue;
								case 3u:
									num54 = ((int)num3 * -302146215) ^ -1899324810;
									continue;
								case 6u:
									goto end_IL_000c;
								case 1u:
									_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
									num54 = ((int)num3 * -142422278) ^ 0x49FD3053;
									continue;
								case 7u:
									goto end_IL_000c;
								case 39u:
								{
									int num55;
									int num56;
									if (!UserDefinedAnimationManager.instance.PreloadAnimtion(animation2))
									{
										num55 = 1493879000;
										num56 = num55;
									}
									else
									{
										num55 = 1992302484;
										num56 = num55;
									}
									num54 = num55 ^ (int)(num3 * 933694796);
									continue;
								}
								case 10u:
									_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E = list2.GetEnumerator();
									num54 = ((int)num3 * -1898376267) ^ -1375661999;
									continue;
								case 9u:
									callback();
									num54 = (int)(num3 * 484732142) ^ -1893564647;
									continue;
								case 24u:
									flag = false;
									num54 = -758473121;
									continue;
								case 32u:
									goto end_IL_000c;
								}
								break;
								IL_0f96:
								animation3 = UserDefinedAnimationManager.instance.GetAnimation(text2, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3087221919u));
								int num72;
								if (animation3 == null)
								{
									num54 = -758473121;
									num72 = num54;
								}
								else
								{
									num54 = -217399704;
									num72 = num54;
								}
								continue;
								IL_0f68:
								int num73;
								if (!_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E.MoveNext())
								{
									num54 = -1634174968;
									num73 = num54;
								}
								else
								{
									num54 = -205201777;
									num73 = num54;
								}
								continue;
								IL_0c7d:
								int num74;
								if (flag)
								{
									num54 = -1034044824;
									num74 = num54;
								}
								else
								{
									num54 = -1486211491;
									num74 = num54;
								}
							}
							goto IL_0b71;
							IL_0ebb:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -3;
							num54 = -2112619735;
							goto IL_0b76;
							IL_0dfb:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
							num54 = -939002046;
							goto IL_0b76;
							IL_0b71:
							num54 = -437428488;
							goto IL_0b76;
							IL_00f1:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
							Clear();
							num2 = -534026722;
							continue;
							IL_00e0:
							_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
							num2 = -231801342;
							continue;
						}
						goto IL_0007;
						continue;
						end_IL_000c:
						break;
					}
					break;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _202D_202A_202A_200E_206E_202E_206C_202C_206F_202C_200C_202E_202A_206E_202B_202D_202C_206F_206C_206A_202A_200F_206A_200F_206D_200B_200C_202C_202B_206E_200E_206C_202D_200D_202E_202D_206D_206D_202B_202C_202E()
		{
			_200E_202B_200F_200F_202C_202A_200B_202C_206A_206F_200B_202D_206D_200C_206A_200B_202E_206B_200D_206A_206D_206F_206A_206D_202C_202D_200C_206D_200B_202B_206B_200D_200B_200B_202B_206D_206B_200D_206D_206D_202E = -1;
			while (true)
			{
				int num = -1097188279;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -748612878)) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
						goto IL_0029;
					case 1u:
						return;
					}
					break;
					IL_0029:
					((IDisposable)_206A_202D_202B_202E_200F_206A_206C_202E_202A_200D_200C_202D_206B_206D_200E_202B_206C_200E_200C_200D_206D_202C_202C_202E_202B_202A_202E_202A_200F_200E_200B_206D_202C_206D_200E_202B_202C_200E_202D_206D_202E/*cast due to .constrained prefix*/).Dispose();
					num = (int)(num2 * 1647326429) ^ -6473967;
				}
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw _202E_200E_206F_206E_202B_200C_206A_200F_200E_200C_206F_206A_206E_206A_206E_206D_206E_206D_206C_206F_200D_202E_200F_206C_206F_206D_200F_200E_200C_202C_206E_200E_200F_206B_200D_202D_200E_206D_202C_206C_202E();
		}

		static bool _206B_202E_206B_206F_200E_206C_202B_206D_206A_200E_200D_200D_206A_206D_200D_200C_206B_206D_202B_202D_202B_202D_200B_206A_202B_200D_206C_206A_202C_200F_206B_206C_202E_206A_200B_206B_202C_200D_206B_206D_202E(string P_0)
		{
			return string.IsNullOrEmpty(P_0);
		}

		static string _200C_200D_200D_206F_200C_206C_200E_206E_206C_206D_200F_206E_200E_200D_200D_202B_202A_200C_206E_206F_206F_202A_206F_200B_202D_200C_200B_206C_206E_206D_202B_200B_206A_200D_202D_206D_200B_200B_206A_206C_202E(string P_0, string P_1)
		{
			return P_0 + P_1;
		}

		static string[] _202D_200C_206F_206C_200E_200D_206F_200F_206C_206B_202D_202E_200C_202B_206B_206B_206F_202E_200B_206B_206C_200C_202C_200F_202A_200B_206A_202C_206B_206F_206C_206E_200B_206C_200D_202C_200F_200D_206F_202A_202E(string P_0, char[] P_1)
		{
			return P_0.Split(P_1);
		}

		static bool _206A_206D_200B_200B_202C_206F_206A_200B_206F_206F_206F_206C_206E_200C_202A_200F_206D_202A_202B_200E_206B_206D_200F_200F_200E_206E_202D_200C_202A_200C_200C_202C_200F_200F_200E_202D_206A_206D_206B_202A_202E(string P_0, string P_1)
		{
			return P_0 == P_1;
		}

		static bool _206A_202A_200C_206B_206C_206D_200D_206D_202C_200D_206F_200F_202B_206F_206F_200E_202B_202B_200F_206C_200C_206B_202A_200E_200F_202B_200F_200E_206F_202E_202D_202A_202A_200B_202C_202C_202D_206C_200F_202D_202E(IEnumerator P_0)
		{
			return P_0.MoveNext();
		}

		static void _202A_206F_200C_202B_206F_202D_202E_200E_206E_202B_206F_200B_206A_202E_200E_206A_206B_200D_200E_202D_206B_206D_206C_200F_206F_202D_200B_202C_206A_202C_200F_202B_206E_206B_200C_200E_206C_202E_202B_206E_202E(IDisposable P_0)
		{
			P_0.Dispose();
		}

		static bool _206D_200E_202D_202C_206D_206B_202A_200B_206B_202E_202E_206D_202E_206F_200B_206E_200E_202A_202E_202E_200D_202A_206C_200D_200F_200D_200C_206A_200C_206B_200B_206E_200B_206B_206B_202C_206C_202B_200E_200C_202E(Object P_0, Object P_1)
		{
			return P_0 == P_1;
		}

		static int _206C_206F_200F_200D_202D_200F_200C_200B_206C_200D_202B_200D_202A_200E_202A_202D_206B_202E_206C_206F_206B_202A_200C_206D_200D_200F_206B_200E_206C_206A_206D_206A_200F_206F_206B_206F_202D_202D_206F_202E(string P_0, char P_1)
		{
			return P_0.IndexOf(P_1);
		}

		static int _202E_206A_206D_202B_200F_206F_206E_200B_200E_202C_206C_206F_200D_202B_202C_206A_206F_202B_200F_206F_202A_206E_200F_202B_202E_202E_202B_206C_206D_202E_206A_202B_200B_202B_202E_202E_206E_200E_202A_200C_202E(string P_0)
		{
			return P_0.Length;
		}

		static string _206D_206C_206E_206F_200C_206B_200C_200F_206D_206A_200E_202E_202C_200D_202B_206B_202D_200E_202C_200D_202D_200E_202E_206F_202C_202C_206C_206C_206D_200E_206D_206A_200C_206C_200C_202A_202D_200E_206C_206F_202E(string P_0, int P_1, int P_2)
		{
			return P_0.Substring(P_1, P_2);
		}

		static bool _206A_202A_206D_202D_206B_200F_200C_200E_202A_206A_206C_202B_200B_206D_200F_202D_200B_202C_200F_200D_206F_200B_206A_200F_200C_206A_202A_200D_200C_200D_202E_200D_200C_206D_202B_202C_200F_206E_200D_200E_202E(string P_0, string P_1)
		{
			return P_0.StartsWith(P_1);
		}

		static void _202D_202D_202D_206D_206D_206A_200F_202C_202A_200B_206A_206D_202E_202D_200E_206B_200F_202C_206D_200B_200F_206D_202B_206C_202B_200B_202D_202D_200D_202B_206B_200D_200B_202B_202A_206A_206D_206B_200F_206E_202E(object P_0)
		{
			Debug.LogError(P_0);
		}

		static bool _202B_202C_206A_200F_202B_200E_200B_202D_206E_200B_200E_202A_200F_206D_200D_206C_200D_200B_202B_202D_206D_206A_202E_206F_202B_202B_206F_206C_202E_206C_206B_206A_202B_206C_200C_202D_200C_202A_202D_202D_202E(Object P_0, Object P_1)
		{
			return P_0 != P_1;
		}

		static NotSupportedException _202E_200E_206F_206E_202B_200C_206A_200F_200E_200C_206F_206A_206E_206A_206E_206D_206E_206D_206C_206F_200D_202E_200F_206C_206F_206D_200F_200E_200C_202C_206E_200E_200F_206B_200D_202D_200E_206D_202C_206C_202E()
		{
			return new NotSupportedException();
		}
	}

	private static int _200C_200D_202D_206C_202D_202D_200C_202B_202B_206F_202E_200C_206F_200B_206F_206C_200E_206C_202E_206E_202D_202C_206C_206F_206F_206A_206F_200B_200F_206C_206E_200C_200C_200D_200C_202E_206E_202B_206E_202B_202E;

	private static int _202A_206E_202D_202A_206D_206F_206A_200F_206D_200C_206D_206A_200E_202A_200D_200D_206C_202D_200B_200B_200D_202B_200B_200D_200D_200F_200F_206F_200C_200E_200C_200B_200F_206A_200E_202E_206C_200D_202E_202E;

	private static Dictionary<string, GameObject> _200E_202B_206C_206A_206A_202C_200E_206A_206C_200F_206F_206E_202E_206A_200F_202B_206A_200F_202C_202E_202E_200E_206B_200E_206B_206F_206C_200E_200D_202E_200C_202B_206F_202B_200C_200F_202A_202B_202A_206A_202E;

	static ResourcePool()
	{
		_200C_200D_202D_206C_202D_202D_200C_202B_202B_206F_202E_200C_206F_200B_206F_206C_200E_206C_202E_206E_202D_202C_206C_206F_206F_206A_206F_200B_200F_206C_206E_200C_200C_200D_200C_202E_206E_202B_206E_202B_202E = 0;
		_202A_206E_202D_202A_206D_206F_206A_200F_206D_200C_206D_206A_200E_202A_200D_200D_206C_202D_200B_200B_200D_202B_200B_200D_200D_200F_200F_206F_200C_200E_200C_200B_200F_206A_200E_202E_206C_200D_202E_202E = 0;
		_200E_202B_206C_206A_206A_202C_200E_206A_206C_200F_206F_206E_202E_206A_200F_202B_206A_200F_202C_202E_202E_200E_206B_200E_206B_206F_206C_200E_200D_202E_200C_202B_206F_202B_200C_200F_202A_202B_202A_206A_202E = new Dictionary<string, GameObject>();
	}

	public static void Init()
	{
		Clear();
	}

	public static void Clear()
	{
		_200E_202B_206C_206A_206A_202C_200E_206A_206C_200F_206F_206E_202E_206A_200F_202B_206A_200F_202C_202E_202E_200E_206B_200E_206B_206F_206C_200E_200D_202E_200C_202B_206F_202B_200C_200F_202A_202B_202A_206A_202E.Clear();
		while (true)
		{
			int num = -1431685270;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1354743979)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_002c;
				default:
					_202A_206E_202D_202A_206D_206F_206A_200F_206D_200C_206D_206A_200E_202A_200D_200D_206C_202D_200B_200B_200D_202B_200B_200D_200D_200F_200F_206F_200C_200E_200C_200B_200F_206A_200E_202E_206C_200D_202E_202E = 0;
					return;
				}
				break;
				IL_002c:
				_200C_200D_202D_206C_202D_202D_200C_202B_202B_206F_202E_200C_206F_200B_206F_206C_200E_206C_202E_206E_202D_202C_206C_206F_206F_206A_206F_200B_200F_206C_206E_200C_200C_200D_200C_202E_206E_202B_206E_202B_202E = 0;
				num = (int)((num2 * 1482317279) ^ 0x73E2FE49);
			}
		}
	}

	public static float GetLoadProgress()
	{
		if (_200C_200D_202D_206C_202D_202D_200C_202B_202B_206F_202E_200C_206F_200B_206F_206C_200E_206C_202E_206E_202D_202C_206C_206F_206F_206A_206F_200B_200F_206C_206E_200C_200C_200D_200C_202E_206E_202B_206E_202B_202E == 0)
		{
			while (true)
			{
				uint num;
				switch ((num = 99801299u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return 0f;
				}
				break;
			}
		}
		return (float)_202A_206E_202D_202A_206D_206F_206A_200F_206D_200C_206D_206A_200E_202A_200D_200D_206C_202D_200B_200B_200D_202B_200B_200D_200D_200F_200F_206F_200C_200E_200C_200B_200F_206A_200E_202E_206C_200D_202E_202E / (float)_200C_200D_202D_206C_202D_202D_200C_202B_202B_206F_202E_200C_206F_200B_206F_206C_200E_206C_202E_206E_202D_202C_206C_206F_206F_206A_206F_200B_200F_206C_206E_200C_200C_200D_200C_202E_206E_202B_206E_202B_202E;
	}

	public static GameObject Get(string key)
	{
		if (_200E_202B_206C_206A_206A_202C_200E_206A_206C_200F_206F_206E_202E_206A_200F_202B_206A_200F_202C_202E_202E_200E_206B_200E_206B_206F_206C_200E_200D_202E_200C_202B_206F_202B_200C_200F_202A_202B_202A_206A_202E.ContainsKey(key))
		{
			while (true)
			{
				uint num;
				switch ((num = 789044636u) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return _200E_202B_206C_206A_206A_202C_200E_206A_206C_200F_206F_206E_202E_206A_200F_202B_206A_200F_202C_202E_202E_200E_206B_200E_206B_206F_206C_200E_200D_202E_200C_202B_206F_202B_200C_200F_202A_202B_202A_206A_202E[key];
				}
				break;
			}
		}
		return Resources.Load<GameObject>(key);
	}

	public static IEnumerable<GameObject> GetAll<T>()
	{
		return _200E_202B_206C_206A_206A_202C_200E_206A_206C_200F_206F_206E_202E_206A_200F_202B_206A_200F_202C_202E_202E_200E_206B_200E_206B_206F_206C_200E_200D_202E_200C_202B_206F_202B_200C_200F_202A_202B_202A_206A_202E.Values;
	}

	public static IEnumerator Load(Battle battle, CommonSettings.VoidCallBack callback)
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new _200F_202A_206A_200C_206B_202A_206D_200F_202D_202A_200E_206C_206C_200E_202B_202E_200B_200B_200F_206B_200B_200B_206E_200C_202C_206B_202D_202C_202A_200D_206C_206A_202A_206F_206F_200F_200F_206A_206A_206C_202E(0)
		{
			battle = battle,
			callback = callback
		};
	}

	private static void GenerateResourcePool(Battle battle)
	{
	}
}
