using System;
using System.Collections;
using System.Collections.Generic;
using JyGame;
using UnityEngine;

public class RoleSelectUI : MonoBehaviour
{
	public GameObject RoleMenuObj;

	private Battle battle;

	public RoleSelectMenu selectMenu => RoleMenuObj.GetComponent<RoleSelectMenu>();

	public void Load(string battleKey, List<string> forbiddenKeys, CommonSettings.VoidCallBack cancelCallback)
	{
		selectMenu.Show(battle, forbiddenKeys, cancelCallback, null);
	}

	private void Start()
	{
		Init();
		GameEngine gameEngine = default(GameEngine);
		Battle battle = default(Battle);
		List<Battle> list = default(List<Battle>);
		Battle current = default(Battle);
		string[] array = default(string[]);
		int num11 = default(int);
		string item = default(string);
		while (true)
		{
			int num = -160726370;
			while (true)
			{
				uint num2;
				int num8;
				int num18;
				switch ((num2 = (uint)(num ^ -1049766109)) % 4)
				{
				case 0u:
					break;
				case 1u:
					gameEngine = RuntimeData.Instance.gameEngine;
					battle = null;
					num = (int)(num2 * 584676607) ^ -1123738813;
					continue;
				case 3u:
					if (_202B_202E_200C_200B_202A_200D_200C_206D_202B_202D_206E_202A_200D_202E_200C_202B_200F_206A_202B_200B_206C_200E_200C_206E_202D_202C_206E_202A_200D_200E_206B_200C_206F_200F_200B_206B_206E_206E_206C_206D_202E(gameEngine.CurrentSceneValue, ResourceStrings.ResStrings[1302]))
					{
						num = (int)(num2 * 219454000) ^ -703052739;
						continue;
					}
					goto IL_01eb;
				default:
					{
						list = new List<Battle>();
						IEnumerator<Battle> enumerator = ResourceManager.GetAll<Battle>().GetEnumerator();
						try
						{
							while (true)
							{
								IL_00bb:
								int num3;
								int num4;
								if (_200B_202B_200C_200E_206B_200F_200D_200B_202E_200F_200C_202E_206E_206E_200F_202D_206A_202C_202C_200B_200E_202C_206D_200D_202B_200B_202D_200F_202E_202E_202C_206C_200D_202B_200B_202B_202E_200D_200E_206D_202E((IEnumerator)enumerator))
								{
									num3 = -549954510;
									num4 = num3;
								}
								else
								{
									num3 = -976228281;
									num4 = num3;
								}
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ -1049766109)) % 6)
									{
									case 5u:
										num3 = -549954510;
										continue;
									default:
										goto end_IL_0091;
									case 0u:
										break;
									case 4u:
									{
										int num5;
										int num6;
										if (!_202E_202C_206C_206C_202C_202B_206A_202C_202C_206B_202E_206F_206A_206E_206E_200B_206F_202C_206E_206C_200F_200D_206B_206C_206B_202D_206A_202D_200B_202B_200D_202A_200F_200B_202D_202D_202B_206A_202C_206C_202E(current.Key, ResourceStrings.ResStrings[1302]))
										{
											num5 = 765547985;
											num6 = num5;
										}
										else
										{
											num5 = 1760045818;
											num6 = num5;
										}
										num3 = num5 ^ ((int)num2 * -1873633982);
										continue;
									}
									case 1u:
										current = enumerator.Current;
										num3 = -410669487;
										continue;
									case 3u:
										list.Add(current);
										num3 = ((int)num2 * -1612221873) ^ 0x42278CE6;
										continue;
									case 2u:
										goto end_IL_0091;
									}
									goto IL_00bb;
									continue;
									end_IL_0091:
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
									IL_013d:
									int num7 = -1256166585;
									while (true)
									{
										switch ((num2 = (uint)(num7 ^ -1049766109)) % 3)
										{
										case 2u:
											break;
										default:
											goto end_IL_0142;
										case 1u:
											goto IL_0160;
										case 0u:
											goto end_IL_0142;
										}
										goto IL_013d;
										IL_0160:
										_202C_200D_200D_202E_206D_200D_206D_202E_202D_200D_206B_200B_206D_202E_206D_202A_206D_200F_206C_200C_200F_202E_202B_206B_202A_206E_202A_200F_206B_206C_202E_200C_202E_206B_202C_200C_202A_202B_200C_206C_202E((IDisposable)enumerator);
										num7 = (int)((num2 * 1361960551) ^ 0x185E3D3A);
										continue;
										end_IL_0142:
										break;
									}
									break;
								}
							}
						}
						if (list.Count > 0)
						{
							goto IL_0180;
						}
						goto IL_01eb;
					}
					IL_0185:
					while (true)
					{
						switch ((num2 = (uint)(num8 ^ -1049766109)) % 18)
						{
						case 10u:
							break;
						case 16u:
							return;
						case 15u:
							goto IL_01eb;
						case 2u:
							array = _202A_206B_200E_200D_200C_206C_202E_200E_206F_200D_200D_206B_206E_200D_200C_206E_206B_200D_206F_202E_202C_206E_202C_202B_206B_206E_202B_202E_202E_200D_202E_200E_202D_200D_202C_200E_206D_206D_200E_206B_202E(battle.Forbbiden, new char[1] { '#' }, StringSplitOptions.RemoveEmptyEntries);
							num11 = 0;
							num8 = ((int)num2 * -1004108553) ^ 0x37ABF866;
							continue;
						case 6u:
							gameEngine.BattleSelectRole_BattleCallback(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2075035802u));
							num8 = (int)(num2 * 1641454371) ^ -903950719;
							continue;
						case 1u:
							this.battle = battle;
							num8 = -1117863629;
							continue;
						case 3u:
							goto IL_0267;
						case 9u:
							num11++;
							num8 = -433912383;
							continue;
						case 8u:
							battle = list[Tools.GetRandomInt(0, list.Count - 1)];
							num8 = ((int)num2 * -1104786668) ^ -1775207580;
							continue;
						case 13u:
						{
							int num12;
							int num13;
							if (gameEngine.BattleSelectRole_BattleCallback == null)
							{
								num12 = 1616763972;
								num13 = num12;
							}
							else
							{
								num12 = 1985778434;
								num13 = num12;
							}
							num8 = num12 ^ ((int)num2 * -1971028225);
							continue;
						}
						case 0u:
						{
							int num14;
							int num15;
							if (!_200B_206B_200F_202E_200E_202A_200F_206C_200F_200E_202E_202A_202C_206C_200D_206E_206D_206E_206C_200F_202E_202B_206F_206B_206F_206F_200F_206F_202E_202E_202C_202D_202A_206E_206B_200F_202B_202C_202C_200D_202E(battle.Forbbiden))
							{
								num14 = 993551147;
								num15 = num14;
							}
							else
							{
								num14 = 1684576396;
								num15 = num14;
							}
							num8 = num14 ^ (int)(num2 * 460854980);
							continue;
						}
						case 5u:
							num8 = (int)(num2 * 2096119694) ^ -702868201;
							continue;
						case 4u:
							goto IL_0318;
						case 12u:
							item = array[num11];
							num8 = -1277709478;
							continue;
						case 17u:
							battle = ResourceManager.Get<Battle>(gameEngine.CurrentSceneValue);
							num8 = (int)(num2 * 1993847406) ^ -627677970;
							continue;
						case 14u:
							gameEngine.BattleSelectRole_CurrentForbbidenKeys.Add(item);
							num8 = ((int)num2 * -1759493300) ^ -1075237416;
							continue;
						case 11u:
						{
							int num9;
							int num10;
							if (!gameEngine.BattleSelectRole_CurrentForbbidenKeys.Contains(item))
							{
								num9 = -1737292029;
								num10 = num9;
							}
							else
							{
								num9 = -1396861214;
								num10 = num9;
							}
							num8 = num9 ^ (int)(num2 * 392645682);
							continue;
						}
						default:
							Load(null, gameEngine.BattleSelectRole_CurrentForbbidenKeys, gameEngine.BattleSelectRole_CurrentCancelCallback);
							return;
						}
						break;
						IL_0318:
						int num16;
						if (num11 < array.Length)
						{
							num8 = -1600132113;
							num16 = num8;
						}
						else
						{
							num8 = -420815668;
							num16 = num8;
						}
						continue;
						IL_0267:
						int num17;
						if (battle != null)
						{
							num8 = -881389282;
							num17 = num8;
						}
						else
						{
							num8 = -1052775118;
							num17 = num8;
						}
					}
					goto IL_0180;
					IL_01eb:
					if (battle != null)
					{
						num8 = -79355696;
						num18 = num8;
					}
					else
					{
						num8 = -1094122118;
						num18 = num8;
					}
					goto IL_0185;
					IL_0180:
					num8 = -1834660397;
					goto IL_0185;
				}
				break;
			}
		}
	}

	private void Init()
	{
	}

	private void Update()
	{
	}

	static bool _202B_202E_200C_200B_202A_200D_200C_206D_202B_202D_206E_202A_200D_202E_200C_202B_200F_206A_202B_200B_206C_200E_200C_206E_202D_202C_206E_202A_200D_200E_206B_200C_206F_200F_200B_206B_206E_206E_206C_206D_202E(string P_0, string P_1)
	{
		return P_0 == P_1;
	}

	static bool _202E_202C_206C_206C_202C_202B_206A_202C_202C_206B_202E_206F_206A_206E_206E_200B_206F_202C_206E_206C_200F_200D_206B_206C_206B_202D_206A_202D_200B_202B_200D_202A_200F_200B_202D_202D_202B_206A_202C_206C_202E(string P_0, string P_1)
	{
		return P_0.StartsWith(P_1);
	}

	static bool _200B_202B_200C_200E_206B_200F_200D_200B_202E_200F_200C_202E_206E_206E_200F_202D_206A_202C_202C_200B_200E_202C_206D_200D_202B_200B_202D_200F_202E_202E_202C_206C_200D_202B_200B_202B_202E_200D_200E_206D_202E(IEnumerator P_0)
	{
		return P_0.MoveNext();
	}

	static void _202C_200D_200D_202E_206D_200D_206D_202E_202D_200D_206B_200B_206D_202E_206D_202A_206D_200F_206C_200C_200F_202E_202B_206B_202A_206E_202A_200F_206B_206C_202E_200C_202E_206B_202C_200C_202A_202B_200C_206C_202E(IDisposable P_0)
	{
		P_0.Dispose();
	}

	static bool _200B_206B_200F_202E_200E_202A_200F_206C_200F_200E_202E_202A_202C_206C_200D_206E_206D_206E_206C_200F_202E_202B_206F_206B_206F_206F_200F_206F_202E_202E_202C_202D_202A_206E_206B_200F_202B_202C_202C_200D_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static string[] _202A_206B_200E_200D_200C_206C_202E_200E_206F_200D_200D_206B_206E_200D_200C_206E_206B_200D_206F_202E_202C_206E_202C_202B_206B_206E_202B_202E_202E_200D_202E_200E_202D_200D_202C_200E_206D_206D_200E_206B_202E(string P_0, char[] P_1, StringSplitOptions P_2)
	{
		return P_0.Split(P_1, P_2);
	}
}
