using System;
using System.Collections.Generic;
using System.IO;

namespace JyGame;

public class ModData
{
	public const string DEAD_KEY = "dead";

	public const string SAVE_KEY = "save";

	public const string LAST_SAVE_INDEX = "last_save_index";

	public const string TOTALKILL_KEY = "total_kill";

	public const string END_COUNT_KEY = "end_count";

	public const string MAX_ROUND_KEY = "max_round";

	public static List<string> Nicks;

	private static Dictionary<string, string> KeyValues;

	public static Dictionary<string, int> SkillMaxLevels;

	private static bool _206D_206F_202B_206D_206D_202C_202B_200D_202A_206D_202E_202B_202E_200B_206F_206A_206A_200D_202A_202D_202E_200B_200C_206A_206D_206D_202B_200B_206F_206C_202E_206B_202E_200F_200C_202D_200D_202B_200C_202B_202E;

	public static ModInfo CurrentMod => GlobalData.CurrentMod;

	public static int ZhenlongqijuLevel
	{
		get
		{
			return GetParam(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1953618033u));
		}
		set
		{
			if (value > 999)
			{
				goto IL_0008;
			}
			goto IL_0048;
			IL_0008:
			int num = 1062525096;
			goto IL_000d;
			IL_000d:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x46D0E197)) % 5)
				{
				case 2u:
					break;
				case 3u:
					value = 999;
					num = ((int)num2 * -448905604) ^ 0x20FE7DEF;
					continue;
				case 0u:
					goto IL_0048;
				case 4u:
					value = 0;
					num = (int)(num2 * 2020458401) ^ -964099074;
					continue;
				default:
					SetParam(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3023143406u), value);
					return;
				}
				break;
			}
			goto IL_0008;
			IL_0048:
			int num3;
			if (value >= 0)
			{
				num = 987005291;
				num3 = num;
			}
			else
			{
				num = 2060898274;
				num3 = num;
			}
			goto IL_000d;
		}
	}

	public static int Yuanbao
	{
		get
		{
			return GetParam(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(443702768u));
		}
		set
		{
			SetParam(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(443702768u), value);
		}
	}

	public static string ModXmlPath
	{
		get
		{
			if (GlobalData.CurrentMod == null)
			{
				while (true)
				{
					uint num;
					switch ((num = 1260939835u) % 3)
					{
					case 2u:
						continue;
					case 1u:
						return _200F_202D_206C_200B_206F_200F_202B_202B_206D_200B_202D_202E_202C_206C_200C_200C_200E_200E_206A_206C_202B_202B_200B_206A_206B_202C_200E_206D_202E_202E_206B_200B_200C_200B_206F_200D_202C_202E_202B_200E_202E(CommonSettings.persistentDataPath, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(561283264u));
					}
					break;
				}
			}
			return _200B_206C_200D_202B_206E_200C_200E_206C_206C_202C_206A_206E_200B_206D_206F_206A_200E_206D_202B_200D_202D_206A_200D_202C_206C_202A_206C_200D_206D_206D_206D_200E_200C_206F_206B_202E_206A_200F_200F_206D_202E(CommonSettings.persistentDataPath, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1812586943u), GlobalData.CurrentMod.key, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2358989324u));
		}
	}

	internal static int ZhenlongqijuKilled
	{
		get
		{
			return GetParam(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2898200133u));
		}
		set
		{
			if (value < 0)
			{
				while (true)
				{
					int num = 825170540;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x543302E)) % 3)
						{
						case 0u:
							break;
						case 1u:
							value = 0;
							num = ((int)num2 * -1379355632) ^ -909659063;
							continue;
						default:
							goto end_IL_0004;
						}
						break;
					}
					continue;
					end_IL_0004:
					break;
				}
			}
			SetParam(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3434347104u), value);
		}
	}

	internal static string Font
	{
		get
		{
			if (KeyValues.ContainsKey(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1434849684u)))
			{
				while (true)
				{
					uint num;
					switch ((num = 1919342734u) % 3)
					{
					case 2u:
						continue;
					case 1u:
						return _202B_200E_200D_206E_202A_202E_200C_206D_206C_200B_206C_202E_206B_206E_200B_200F_202D_206E_206C_206E_206F_202D_202C_206A_206B_206B_206A_206C_202A_206E_200E_206D_206B_206D_206C_206E_200C_202E_206C_200E_202E(KeyValues[global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1143535718u)]);
					}
					break;
				}
			}
			return string.Empty;
		}
		set
		{
			if (!_206C_206C_202E_200E_202E_206A_202E_206C_202C_206A_202A_206B_200E_200C_200C_202E_206A_200F_206A_200B_200C_200F_206C_200E_200E_202B_200F_206E_202D_206B_206F_206F_206B_206B_206A_200D_206A_200B_202A_200E_202E(value))
			{
				goto IL_000b;
			}
			goto IL_00ae;
			IL_000b:
			int num = 452106059;
			goto IL_0010;
			IL_0010:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x9A453EC)) % 7)
				{
				case 4u:
					break;
				case 1u:
				{
					int num3;
					int num4;
					if (_206D_202C_200C_200C_206A_202D_206E_206F_202B_200F_206B_200C_206E_202E_202D_202D_206C_202C_202D_206C_206B_200C_202C_206A_206F_202E_202E_200D_202B_206F_206B_206E_200F_200E_202A_202B_202B_206C_202B_206B_202E(value, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3556140356u)))
					{
						num3 = -95950391;
						num4 = num3;
					}
					else
					{
						num3 = -1540117879;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1882544710);
					continue;
				}
				case 0u:
					num = ((int)num2 * -1108410032) ^ -1062643881;
					continue;
				case 3u:
					_206D_206F_202B_206D_206D_202C_202B_200D_202A_206D_202E_202B_202E_200B_206F_206A_206A_200D_202A_202D_202E_200B_200C_206A_206D_206D_202B_200B_206F_206C_202E_206B_202E_200F_200C_202D_200D_202B_200C_202B_202E = true;
					num = 1943378894;
					continue;
				case 5u:
					KeyValues[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4048025543u)] = value;
					num = (int)((num2 * 1467264721) ^ 0x6BE55AF);
					continue;
				case 2u:
					goto IL_00ae;
				default:
					Save();
					return;
				}
				break;
			}
			goto IL_000b;
			IL_00ae:
			KeyValues[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3326259782u)] = string.Empty;
			KeyValues.Remove(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1143535718u));
			num = 1134349719;
			goto IL_0010;
		}
	}

	public static int HideCloud
	{
		get
		{
			if (!KeyValues.ContainsKey(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2527378141u)))
			{
				while (true)
				{
					uint num;
					switch ((num = 1362593521u) % 3)
					{
					case 2u:
						continue;
					case 1u:
						return 0;
					}
					break;
				}
			}
			return 1;
		}
		set
		{
			if (value != 1)
			{
				goto IL_0004;
			}
			goto IL_006a;
			IL_0004:
			int num = 464095438;
			goto IL_0009;
			IL_0009:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7C847AFA)) % 7)
				{
				case 4u:
					break;
				default:
					return;
				case 5u:
					_206D_206F_202B_206D_206D_202C_202B_200D_202A_206D_202E_202B_202E_200B_206F_206A_206A_200D_202A_202D_202E_200B_200C_206A_206D_206D_202B_200B_206F_206C_202E_206B_202E_200F_200C_202D_200D_202B_200C_202B_202E = true;
					num = 2143382728;
					continue;
				case 3u:
					KeyValues.Remove(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2156459499u));
					num = ((int)num2 * -828219520) ^ 0x7E76F1CC;
					continue;
				case 0u:
					goto IL_006a;
				case 2u:
				{
					int num3;
					int num4;
					if (!KeyValues.ContainsKey(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2527378141u)))
					{
						num3 = -1848534974;
						num4 = num3;
					}
					else
					{
						num3 = -946848565;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1066367535);
					continue;
				}
				case 1u:
					num = ((int)num2 * -750878531) ^ 0x124ACF90;
					continue;
				case 6u:
					return;
				}
				break;
			}
			goto IL_0004;
			IL_006a:
			KeyValues[global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(949159626u)] = global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2561488174u);
			num = 2084153294;
			goto IL_0009;
		}
	}

	static ModData()
	{
		Nicks = new List<string>();
		KeyValues = new Dictionary<string, string>();
		while (true)
		{
			int num = -1820175296;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1638203542)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					SkillMaxLevels = new Dictionary<string, int>();
					num = ((int)num2 * -2083466029) ^ -1477774557;
					continue;
				case 3u:
					_206D_206F_202B_206D_206D_202C_202B_200D_202A_206D_202E_202B_202E_200B_206F_206A_206A_200D_202A_202D_202E_200B_200C_206A_206D_206D_202B_200B_206F_206C_202E_206B_202E_200F_200C_202D_200D_202B_200C_202B_202E = false;
					num = (int)(num2 * 1115048828) ^ -1349786153;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public static void addNick(string nick)
	{
		if (Nicks.Contains(nick))
		{
			return;
		}
		while (true)
		{
			int num = -1891412672;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -510324744)) % 6)
				{
				case 0u:
					break;
				default:
					return;
				case 4u:
				{
					int num3;
					int num4;
					if (_206C_206C_202E_200E_202E_206A_202E_206C_202C_206A_202A_206B_200E_200C_200C_202E_206A_200F_206A_200B_200C_200F_206C_200E_200E_202B_200F_206E_202D_206B_206F_206F_206B_206B_206A_200D_206A_200B_202A_200E_202E(nick))
					{
						num3 = -1831898631;
						num4 = num3;
					}
					else
					{
						num3 = -1026058777;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 715237072);
					continue;
				}
				case 1u:
					Nicks.Add(nick);
					num = -1627916213;
					continue;
				case 5u:
					return;
				case 3u:
					_206D_206F_202B_206D_206D_202C_202B_200D_202A_206D_202E_202B_202E_200B_206F_206A_206A_200D_202A_202D_202E_200B_200C_206A_206D_206D_202B_200B_206F_206C_202E_206B_202E_200F_200C_202D_200D_202B_200C_202B_202E = true;
					num = (int)((num2 * 552423199) ^ 0x36FD405B);
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public static void SetParam(string key, int value)
	{
		KeyValues[key] = value.ToString();
		_206D_206F_202B_206D_206D_202C_202B_200D_202A_206D_202E_202B_202E_200B_206F_206A_206A_200D_202A_202D_202E_200B_200C_206A_206D_206D_202B_200B_206F_206C_202E_206B_202E_200F_200C_202D_200D_202B_200C_202B_202E = true;
	}

	public static int GetParam(string key)
	{
		if (KeyValues.ContainsKey(key))
		{
			while (true)
			{
				uint num;
				switch ((num = 765610282u) % 3)
				{
				case 2u:
					continue;
				case 1u:
					return int.Parse(KeyValues[key]);
				}
				break;
			}
		}
		return 0;
	}

	public static int ParamAdd(string key, int value)
	{
		int num = GetParam(key) + value;
		SetParam(key, num);
		return num;
	}

	public static int GetSkillMaxLevel(string skillName)
	{
		return _200E_206C_202E_200F_200F_200B_200B_206A_200D_202D_200F_206D_202E_206F_206A_206A_202E_206B_206A_200C_200E_202A_206B_200C_200B_200D_200E_206C_206C_206A_200E_206C_200C_200E_206E_200F_200B_200D_200E_202E_202E(SkillMaxLevels.ContainsKey(skillName) ? SkillMaxLevels[skillName] : 0, 10);
	}

	public static int AddSkillMaxLevel(string skillName, int level, string storyKey = "")
	{
		if (!_206C_206C_202E_200E_202E_206A_202E_206C_202C_206A_202A_206B_200E_200C_200C_202E_206A_200F_206A_200B_200C_200F_206C_200E_200E_202B_200F_206E_202D_206B_206F_206F_206B_206B_206A_200D_206A_200B_202A_200E_202E(storyKey))
		{
			goto IL_000b;
		}
		goto IL_02e4;
		IL_000b:
		int num = -1883376118;
		goto IL_0010;
		IL_0010:
		int num3 = default(int);
		int skillMaxLevel = default(int);
		string item = default(string);
		List<string> list = default(List<string>);
		int num4 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -711027590)) % 24)
			{
			case 6u:
				break;
			case 17u:
				num3 = skillMaxLevel + level;
				num = ((int)num2 * -1453353827) ^ -1349780500;
				continue;
			case 9u:
				item = RuntimeData.Instance.RoundString();
				num = ((int)num2 * -1860152644) ^ -129497175;
				continue;
			case 15u:
			{
				int num7;
				int num8;
				if (!KeyValues.ContainsKey(storyKey))
				{
					num7 = -1004144080;
					num8 = num7;
				}
				else
				{
					num7 = -1388256867;
					num8 = num7;
				}
				num = num7 ^ (int)(num2 * 878063463);
				continue;
			}
			case 14u:
				list = new List<string>(_206F_206C_206C_202B_206D_200D_200E_200F_200F_206E_202E_200F_206E_200F_200E_202D_202E_206A_206F_202E_202B_206C_200E_202C_200C_206C_202E_202C_200C_206C_206B_202B_202E_200E_202D_202E_202B_206E_202C_202B_202E(KeyValues[storyKey], new char[1] { '#' }, StringSplitOptions.RemoveEmptyEntries));
				num = ((int)num2 * -483413367) ^ -1897416002;
				continue;
			case 0u:
				KeyValues[storyKey] = _200C_206D_206F_202C_206A_206B_202A_202A_202B_202A_200C_206C_206D_202D_200B_200F_200D_200C_200C_206C_202A_206B_200D_206A_200C_200E_200E_206D_200E_200D_206F_202A_202E_206D_206B_200C_202C_206C_206E_200C_202E(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2057560981u), list.ToArray());
				num = -903677729;
				continue;
			case 10u:
			{
				int num9;
				int num10;
				if (!list.Contains(item))
				{
					num9 = -185292953;
					num10 = num9;
				}
				else
				{
					num9 = -2064406226;
					num10 = num9;
				}
				num = num9 ^ (int)(num2 * 521156459);
				continue;
			}
			case 2u:
				return -1;
			case 1u:
				_206D_206F_202B_206D_206D_202C_202B_200D_202A_206D_202E_202B_202E_200B_206F_206A_206A_200D_202A_202D_202E_200B_200C_206A_206D_206D_202B_200B_206F_206C_202E_206B_202E_200F_200C_202D_200D_202B_200C_202B_202E = true;
				AchievementPanelUI.timespan = new TimeSpan(0L);
				num = ((int)num2 * -1675304980) ^ -498803132;
				continue;
			case 5u:
				num4 = CommonSettings.MAX_SKILL_LEVEL;
				num = ((int)num2 * -1238618349) ^ -1577088776;
				continue;
			case 7u:
				num3 = skillMaxLevel;
				num = -364840994;
				continue;
			case 16u:
				goto IL_01cb;
			case 13u:
				goto IL_01e7;
			case 23u:
				num4 = CommonSettings.MAX_INTERNALSKILL_LEVEL;
				num = -2051254705;
				continue;
			case 22u:
			{
				int num5;
				int num6;
				if (ResourceManager.Get<InternalSkill>(skillName) != null)
				{
					num5 = 539529291;
					num6 = num5;
				}
				else
				{
					num5 = 1795474249;
					num6 = num5;
				}
				num = num5 ^ (int)(num2 * 621235589);
				continue;
			}
			case 11u:
				num = (int)(num2 * 443730208) ^ -5427266;
				continue;
			case 20u:
				SkillMaxLevels[skillName] = num3;
				num = -1630086069;
				continue;
			case 8u:
				list = new List<string>();
				num = (int)((num2 * 1931948812) ^ 0x1D432A4B);
				continue;
			case 4u:
				list.Add(item);
				num = ((int)num2 * -457944484) ^ 0x18F952A;
				continue;
			case 3u:
				num3 = _206E_200B_206A_202A_206B_206C_206F_202E_202E_202D_206A_200B_200F_206A_200D_200B_200B_202B_206D_206C_206F_202A_206C_202C_206A_206F_202D_202D_206D_200C_202B_200B_200D_202A_206C_206E_202A_202D_206D_202A_202E(skillMaxLevel + level, num4);
				num = (int)((num2 * 1531870926) ^ 0x46B79B4C);
				continue;
			case 19u:
				goto IL_02b3;
			case 12u:
				num = ((int)num2 * -287405642) ^ 0x1C14E56;
				continue;
			case 21u:
				goto IL_02e4;
			default:
				return num3;
			}
			break;
			IL_02b3:
			int num11;
			if (!list.Contains(item))
			{
				num = -1264764914;
				num11 = num;
			}
			else
			{
				num = -1651460966;
				num11 = num;
			}
			continue;
			IL_01e7:
			num3 = 10;
			int num12;
			if (skillMaxLevel + level <= num4)
			{
				num = -1486617765;
				num12 = num;
			}
			else
			{
				num = -928475142;
				num12 = num;
			}
			continue;
			IL_01cb:
			int num13;
			if (skillMaxLevel + level <= num4 + 5)
			{
				num = -888381471;
				num13 = num;
			}
			else
			{
				num = -1120777947;
				num13 = num;
			}
		}
		goto IL_000b;
		IL_02e4:
		skillMaxLevel = GetSkillMaxLevel(skillName);
		num4 = 1;
		num = -1713548132;
		goto IL_0010;
	}

	public static void Load()
	{
		if (_200E_200B_206E_200F_200E_202C_206D_202A_202B_206E_206E_202D_202A_206F_200C_200B_206A_206C_200E_200C_202C_206F_200D_206E_202A_202D_202D_202B_200C_206F_202C_206D_206C_202B_206E_200E_206A_202C_206E_202D_202E(ModXmlPath))
		{
			StreamReader streamReader = _202C_200B_202E_202B_200F_202D_206B_206F_206C_202B_200E_202B_200B_202D_206F_202B_206E_202C_200D_202E_200C_206D_206D_206C_206C_202C_200F_206E_200C_206D_206D_200B_200F_206F_206D_206A_202D_202E_206B_206D_202E(ModXmlPath);
			try
			{
				string text = _206A_200F_202A_202E_202A_200F_206D_200F_206C_200B_200B_206F_202D_200E_206C_202E_202C_206E_200E_206C_200E_202A_202D_200F_206E_202D_206B_206E_206E_200B_202E_200D_202C_206C_200E_206B_206F_206A_202D_202E_202E((TextReader)streamReader);
				while (true)
				{
					int num = 1445081327;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x7C596C9C)) % 8)
						{
						case 4u:
							break;
						default:
							return;
						case 3u:
						{
							int num5;
							int num6;
							if (_206D_206E_206A_206C_206C_202B_206B_202C_206A_206A_202E_206E_206E_200C_202D_206F_206F_200E_202C_202B_200C_202D_206A_206C_200C_200D_206B_206C_206F_202C_200C_206E_200F_202E_202C_202C_206B_206F_202C_206E_202E(text) <= 19)
							{
								num5 = 1724156247;
								num6 = num5;
							}
							else
							{
								num5 = 1886004754;
								num6 = num5;
							}
							num = num5 ^ (int)(num2 * 953252122);
							continue;
						}
						case 0u:
						{
							int num3;
							int num4;
							if (!_206F_206F_200C_200B_202E_200B_200F_206D_206F_206F_206D_200D_202D_202A_206B_206E_200D_206F_200D_202E_206F_202E_200F_200C_206F_200D_202A_202B_202E_200F_206B_202A_202E_202E_200B_206D_202B_200B_206C_202A_202E(text, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2008452740u)))
							{
								num3 = 359097258;
								num4 = num3;
							}
							else
							{
								num3 = 1493159257;
								num4 = num3;
							}
							num = num3 ^ (int)(num2 * 1217340341);
							continue;
						}
						case 5u:
							LoadFromXmlString(text);
							num = 1221038374;
							continue;
						case 6u:
							text = SaveManager.Decode_Save(text);
							num = ((int)num2 * -1869119411) ^ -70522393;
							continue;
						case 1u:
							AchievementPanelUI.timespan = new TimeSpan(0L);
							num = (int)(num2 * 297615311) ^ -1602096092;
							continue;
						case 2u:
							_206D_206F_202B_206D_206D_202C_202B_200D_202A_206D_202E_202B_202E_200B_206F_206A_206A_200D_202A_202D_202E_200B_200C_206A_206D_206D_202B_200B_206F_206C_202E_206B_202E_200F_200C_202D_200D_202B_200C_202B_202E = false;
							num = (int)(num2 * 486593161) ^ -1189642825;
							continue;
						case 7u:
							return;
						}
						break;
					}
				}
			}
			finally
			{
				if (streamReader != null)
				{
					while (true)
					{
						IL_010f:
						int num7 = 1886081853;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num7 ^ 0x7C596C9C)) % 3)
							{
							case 0u:
								break;
							default:
								goto end_IL_0114;
							case 1u:
								goto IL_0131;
							case 2u:
								goto end_IL_0114;
							}
							goto IL_010f;
							IL_0131:
							((IDisposable)streamReader).Dispose();
							num7 = (int)((num2 * 1624115559) ^ 0x4D7E17F6);
							continue;
							end_IL_0114:
							break;
						}
						break;
					}
				}
			}
		}
		while (true)
		{
			ClearAll();
			int num8 = 779283782;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num8 ^ 0x7C596C9C)) % 3)
				{
				case 0u:
					goto IL_0148;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0148:
				num8 = 1049623388;
			}
		}
	}

	private static void LoadFromXmlString(string xml)
	{
		GlobalSave globalSave = Tools.LoadObjectFromXML<GlobalSave>(xml);
		GameSaveKeyValues gameSaveKeyValues = default(GameSaveKeyValues);
		GlobalSkillMaxLevel globalSkillMaxLevel = default(GlobalSkillMaxLevel);
		int num3 = default(int);
		GlobalSkillMaxLevel[] skillMaxLevels = default(GlobalSkillMaxLevel[]);
		GameSaveKeyValues[] keyValues = default(GameSaveKeyValues[]);
		while (true)
		{
			int num = 1009562033;
			while (true)
			{
				uint num2;
				List<string> nicks;
				switch ((num2 = (uint)(num ^ 0x77D0635B)) % 24)
				{
				case 3u:
					break;
				default:
					return;
				case 18u:
				{
					int num8;
					int num9;
					if (globalSave != null)
					{
						num8 = -1304867720;
						num9 = num8;
					}
					else
					{
						num8 = -1131385170;
						num9 = num8;
					}
					num = num8 ^ ((int)num2 * -1760308713);
					continue;
				}
				case 9u:
					KeyValues.Add(gameSaveKeyValues.key, gameSaveKeyValues.value);
					num = (int)((num2 * 1308035720) ^ 0x68F1AEC2);
					continue;
				case 5u:
				{
					int num12;
					int num13;
					if (globalSkillMaxLevel.value >= 10)
					{
						num12 = 1424419685;
						num13 = num12;
					}
					else
					{
						num12 = 137435168;
						num13 = num12;
					}
					num = num12 ^ ((int)num2 * -423356102);
					continue;
				}
				case 10u:
					num3 = 0;
					num = ((int)num2 * -1237977783) ^ 0x69D7A9D7;
					continue;
				case 11u:
					skillMaxLevels = globalSave.SkillMaxLevels;
					num = (int)(num2 * 1528787003) ^ -753614048;
					continue;
				case 14u:
					keyValues = globalSave.KeyValues;
					num = (int)((num2 * 14178024) ^ 0xF20CFA4);
					continue;
				case 4u:
					gameSaveKeyValues = keyValues[num3];
					num = 1445099378;
					continue;
				case 15u:
				{
					int num5;
					int num6;
					if (globalSave.SkillMaxLevels != null)
					{
						num5 = -1176407648;
						num6 = num5;
					}
					else
					{
						num5 = -1872983664;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -368919608);
					continue;
				}
				case 23u:
					num3 = 0;
					num = (int)(num2 * 269070288) ^ -328883548;
					continue;
				case 0u:
					nicks = new List<string>();
					goto IL_0197;
				case 20u:
					SkillMaxLevels.Add(globalSkillMaxLevel.key, globalSkillMaxLevel.value);
					num = 1730853643;
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -1448004705) ^ -764110629;
					continue;
				case 8u:
					num = (int)((num2 * 696508936) ^ 0x126281CB);
					continue;
				case 2u:
					globalSkillMaxLevel = skillMaxLevels[num3];
					num = 343499686;
					continue;
				case 21u:
					if (globalSave.Nicks != null)
					{
						nicks = new List<string>(globalSave.Nicks);
						goto IL_0197;
					}
					num = (int)(num2 * 954277107) ^ -1037749860;
					continue;
				case 6u:
				{
					int num10;
					int num11;
					if (globalSave.KeyValues != null)
					{
						num10 = -1333686081;
						num11 = num10;
					}
					else
					{
						num10 = -1141916891;
						num11 = num10;
					}
					num = num10 ^ ((int)num2 * -87676805);
					continue;
				}
				case 7u:
				{
					int num7;
					if (num3 >= keyValues.Length)
					{
						num = 1356040447;
						num7 = num;
					}
					else
					{
						num = 1881626975;
						num7 = num;
					}
					continue;
				}
				case 17u:
					SkillMaxLevels.Add(globalSkillMaxLevel.key, 10);
					num = ((int)num2 * -143567368) ^ -74027333;
					continue;
				case 13u:
					KeyValues.Clear();
					num = ((int)num2 * -1463337916) ^ 0x39A99641;
					continue;
				case 12u:
					SkillMaxLevels.Clear();
					num = 88231972;
					continue;
				case 22u:
				{
					int num4;
					if (num3 >= skillMaxLevels.Length)
					{
						num = 1518897576;
						num4 = num;
					}
					else
					{
						num = 204594577;
						num4 = num;
					}
					continue;
				}
				case 16u:
					num3++;
					num = 666264205;
					continue;
				case 19u:
					return;
					IL_0197:
					Nicks = nicks;
					num = 1972439318;
					continue;
				}
				break;
			}
		}
	}

	public static void Save()
	{
		if (!_206D_206F_202B_206D_206D_202C_202B_200D_202A_206D_202E_202B_202E_200B_206F_206A_206A_200D_202A_202D_202E_200B_200C_206A_206D_206D_202B_200B_206F_206C_202E_206B_202E_200F_200C_202D_200D_202B_200C_202B_202E)
		{
			goto IL_0007;
		}
		goto IL_0043;
		IL_0007:
		int num = -928193881;
		goto IL_000c;
		IL_000c:
		GlobalSave globalSave = default(GlobalSave);
		KeyValuePair<string, int> current2 = default(KeyValuePair<string, int>);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -291806196)) % 5)
			{
			case 2u:
				break;
			case 3u:
				return;
			case 4u:
				goto IL_0043;
			case 1u:
				globalSave.Nicks = Nicks.ToArray();
				num = (int)((num2 * 909813169) ^ 0x65ECE4B3);
				continue;
			default:
			{
				globalSave.KeyValues = new GameSaveKeyValues[KeyValues.Count];
				int num3 = 0;
				using (Dictionary<string, string>.Enumerator enumerator = KeyValues.GetEnumerator())
				{
					while (true)
					{
						IL_00f6:
						int num4;
						int num5;
						if (enumerator.MoveNext())
						{
							num4 = -1178507258;
							num5 = num4;
						}
						else
						{
							num4 = -605583971;
							num5 = num4;
						}
						while (true)
						{
							switch ((num2 = (uint)(num4 ^ -291806196)) % 4)
							{
							case 0u:
								num4 = -1178507258;
								continue;
							default:
								goto end_IL_0099;
							case 2u:
							{
								KeyValuePair<string, string> current = enumerator.Current;
								globalSave.KeyValues[num3] = new GameSaveKeyValues
								{
									key = current.Key,
									value = current.Value
								};
								num3++;
								num4 = -795476677;
								continue;
							}
							case 3u:
								break;
							case 1u:
								goto end_IL_0099;
							}
							goto IL_00f6;
							continue;
							end_IL_0099:
							break;
						}
						break;
					}
				}
				globalSave.SkillMaxLevels = new GlobalSkillMaxLevel[SkillMaxLevels.Count];
				while (true)
				{
					int num6 = -764606099;
					while (true)
					{
						switch ((num2 = (uint)(num6 ^ -291806196)) % 3)
						{
						case 0u:
							break;
						case 2u:
							goto IL_0158;
						default:
						{
							using (Dictionary<string, int>.Enumerator enumerator2 = SkillMaxLevels.GetEnumerator())
							{
								while (true)
								{
									IL_01ee:
									int num7;
									int num8;
									if (!enumerator2.MoveNext())
									{
										num7 = -1318797585;
										num8 = num7;
									}
									else
									{
										num7 = -697160401;
										num8 = num7;
									}
									while (true)
									{
										switch ((num2 = (uint)(num7 ^ -291806196)) % 6)
										{
										case 4u:
											num7 = -697160401;
											continue;
										default:
											goto end_IL_017d;
										case 1u:
											current2 = enumerator2.Current;
											num7 = -2046618066;
											continue;
										case 2u:
											globalSave.SkillMaxLevels[num3] = new GlobalSkillMaxLevel
											{
												key = current2.Key,
												value = current2.Value
											};
											num7 = ((int)num2 * -1243953847) ^ -1462250410;
											continue;
										case 5u:
											break;
										case 0u:
											num3++;
											num7 = ((int)num2 * -2141718431) ^ 0x5D8C71D5;
											continue;
										case 3u:
											goto end_IL_017d;
										}
										goto IL_01ee;
										continue;
										end_IL_017d:
										break;
									}
									break;
								}
							}
							string text = Tools.SerializeXML(globalSave);
							StreamWriter streamWriter = _202C_206E_206E_206D_200E_200C_206E_200E_200F_200F_200F_200C_202E_206F_206E_206D_200C_200B_200B_200F_206E_200D_206F_202E_202A_206E_202D_206F_200E_202A_206E_202C_206F_200E_206C_202B_200E_200B_206B_206B_202E(ModXmlPath);
							try
							{
								int num9 = CommonSettings.EN_SAVE();
								while (true)
								{
									IL_024c:
									int num10 = -1196342655;
									while (true)
									{
										switch ((num2 = (uint)(num10 ^ -291806196)) % 5)
										{
										case 0u:
											break;
										default:
											goto end_IL_0251;
										case 2u:
										{
											int num11;
											int num12;
											if (num9.ToString() != global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1967782034u))
											{
												num11 = 741487091;
												num12 = num11;
											}
											else
											{
												num11 = 1159416487;
												num12 = num11;
											}
											num10 = num11 ^ ((int)num2 * -1659533973);
											continue;
										}
										case 1u:
											text = SaveManager.Encrypt_Save(text);
											num10 = ((int)num2 * -1551210110) ^ 0x669DBF68;
											continue;
										case 4u:
											streamWriter.Write(text);
											num10 = -1772594669;
											continue;
										case 3u:
											goto end_IL_0251;
										}
										goto IL_024c;
										continue;
										end_IL_0251:
										break;
									}
									break;
								}
							}
							finally
							{
								if (streamWriter != null)
								{
									while (true)
									{
										IL_02d5:
										int num13 = -1249596655;
										while (true)
										{
											switch ((num2 = (uint)(num13 ^ -291806196)) % 3)
											{
											case 0u:
												break;
											default:
												goto end_IL_02da;
											case 1u:
												goto IL_02f8;
											case 2u:
												goto end_IL_02da;
											}
											goto IL_02d5;
											IL_02f8:
											((IDisposable)streamWriter).Dispose();
											num13 = ((int)num2 * -1122870546) ^ 0x47B7F6D4;
											continue;
											end_IL_02da:
											break;
										}
										break;
									}
								}
							}
							_206D_206F_202B_206D_206D_202C_202B_200D_202A_206D_202E_202B_202E_200B_206F_206A_206A_200D_202A_202D_202E_200B_200C_206A_206D_206D_202B_200B_206F_206C_202E_206B_202E_200F_200C_202D_200D_202B_200C_202B_202E = false;
							return;
						}
						}
						break;
						IL_0158:
						num3 = 0;
						num6 = ((int)num2 * -216519039) ^ -711432462;
					}
				}
			}
			}
			break;
		}
		goto IL_0007;
		IL_0043:
		globalSave = new GlobalSave();
		num = -761907474;
		goto IL_000c;
	}

	public static void ClearAll()
	{
		KeyValues.Clear();
		while (true)
		{
			int num = 944794592;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x741E8A69)) % 5)
				{
				case 2u:
					break;
				default:
					return;
				case 4u:
					Save();
					num = ((int)num2 * -1843423410) ^ -1629489188;
					continue;
				case 0u:
					SkillMaxLevels.Clear();
					_206D_206F_202B_206D_206D_202C_202B_200D_202A_206D_202E_202B_202E_200B_206F_206A_206A_200D_202A_202D_202E_200B_200C_206A_206D_206D_202B_200B_206F_206C_202E_206B_202E_200F_200C_202D_200D_202B_200C_202B_202E = true;
					num = ((int)num2 * -1632680598) ^ -788149957;
					continue;
				case 1u:
					Nicks.Clear();
					num = ((int)num2 * -736762198) ^ 0x6B4D466D;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public static void Set_needSave()
	{
		_206D_206F_202B_206D_206D_202C_202B_200D_202A_206D_202E_202B_202E_200B_206F_206A_206A_200D_202A_202D_202E_200B_200C_206A_206D_206D_202B_200B_206F_206C_202E_206B_202E_200F_200C_202D_200D_202B_200C_202B_202E = true;
	}

	public static int Get_Quality_Level()
	{
		if (KeyValues.ContainsKey(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2769907043u)))
		{
			int num3 = default(int);
			while (true)
			{
				int num = 1886656291;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x1BFE31DD)) % 8)
					{
					case 3u:
						break;
					case 1u:
						return num3;
					case 0u:
					{
						int num4;
						int num5;
						if (num3 >= 0)
						{
							num4 = -1917642480;
							num5 = num4;
						}
						else
						{
							num4 = -17519590;
							num5 = num4;
						}
						num = num4 ^ ((int)num2 * -1070319723);
						continue;
					}
					case 6u:
						num3 = int.Parse(KeyValues[global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(410341292u)]);
						num = ((int)num2 * -156680145) ^ 0x7F3C8C77;
						continue;
					case 7u:
						num3 = 0;
						num = ((int)num2 * -1492002389) ^ -681776159;
						continue;
					case 5u:
						goto IL_00b8;
					case 4u:
						num3 = 5;
						num = ((int)num2 * -2047688902) ^ 0x18716AEC;
						continue;
					default:
						goto end_IL_0019;
					}
					break;
					IL_00b8:
					int num6;
					if (num3 > 5)
					{
						num = 1250440185;
						num6 = num;
					}
					else
					{
						num = 573321924;
						num6 = num;
					}
				}
				continue;
				end_IL_0019:
				break;
			}
		}
		return -1;
	}

	public static void Set_Quality_Level(int level = -1)
	{
		if (level >= 0)
		{
			goto IL_0007;
		}
		goto IL_0089;
		IL_0007:
		int num = 123045021;
		goto IL_000c;
		IL_000c:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x4C33CAA0)) % 9)
			{
			case 5u:
				break;
			case 1u:
			{
				int num4;
				int num5;
				if (level <= 5)
				{
					num4 = -1499133669;
					num5 = num4;
				}
				else
				{
					num4 = -124908040;
					num5 = num4;
				}
				num = num4 ^ ((int)num2 * -1289831377);
				continue;
			}
			case 3u:
				goto IL_0062;
			case 4u:
				goto IL_0089;
			case 7u:
				KeyValues.Remove(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4033273434u));
				num = ((int)num2 * -2124193908) ^ -471246032;
				continue;
			case 8u:
				KeyValues.Add(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2769907043u), level.ToString());
				num = 114087842;
				continue;
			case 2u:
				KeyValues[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4033273434u)] = level.ToString();
				num = ((int)num2 * -1252422260) ^ -1354085222;
				continue;
			case 0u:
				num = ((int)num2 * -968725345) ^ -608572542;
				continue;
			default:
				try
				{
					_206D_206F_202B_206D_206D_202C_202B_200D_202A_206D_202E_202B_202E_200B_206F_206A_206A_200D_202A_202D_202E_200B_200C_206A_206D_206D_202B_200B_206F_206C_202E_206B_202E_200F_200C_202D_200D_202B_200C_202B_202E = true;
					while (true)
					{
						int num3 = 1349860597;
						while (true)
						{
							int qUALITY_LEVEL;
							switch ((num2 = (uint)(num3 ^ 0x4C33CAA0)) % 6)
							{
							case 0u:
								break;
							default:
								return;
							case 2u:
								qUALITY_LEVEL = 3;
								goto IL_01a3;
							case 4u:
								if (GlobalData.CurrentMod != null)
								{
									qUALITY_LEVEL = CommonSettings.GET_QUALITY_LEVEL(GlobalData.CurrentMod.quality);
									goto IL_01a3;
								}
								num3 = (int)((num2 * 912547947) ^ 0x55065C9E);
								continue;
							case 1u:
								if (KeyValues.ContainsKey(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2769907043u)))
								{
									qUALITY_LEVEL = CommonSettings.GET_QUALITY_LEVEL(KeyValues[global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4033273434u)]);
									goto IL_01a3;
								}
								num3 = (int)(num2 * 1720867898) ^ -1136809538;
								continue;
							case 3u:
								Save();
								num3 = ((int)num2 * -1797782588) ^ 0x51AF902F;
								continue;
							case 5u:
								return;
								IL_01a3:
								CommonSettings.SET_QUALITY_LEVEL(qUALITY_LEVEL);
								num3 = 1646727973;
								continue;
							}
							break;
						}
					}
				}
				catch
				{
					return;
				}
			}
			break;
			IL_0062:
			int num6;
			if (KeyValues.ContainsKey(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2203766200u)))
			{
				num = 689740026;
				num6 = num;
			}
			else
			{
				num = 630327768;
				num6 = num;
			}
		}
		goto IL_0007;
		IL_0089:
		int num7;
		if (!KeyValues.ContainsKey(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(410341292u)))
		{
			num = 114087842;
			num7 = num;
		}
		else
		{
			num = 318096916;
			num7 = num;
		}
		goto IL_000c;
	}

	public static int AddYuanbao(int number, string storyKey)
	{
		if (_206C_206C_202E_200E_202E_206A_202E_206C_202C_206A_202A_206B_200E_200C_200C_202E_206A_200F_206A_200B_200C_200F_206C_200E_200E_202B_200F_206E_202D_206B_206F_206F_206B_206B_206A_200D_206A_200B_202A_200E_202E(storyKey))
		{
			goto IL_000b;
		}
		goto IL_00b7;
		IL_000b:
		int num = 1777466533;
		goto IL_0010;
		IL_0010:
		List<string> list = default(List<string>);
		string item = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x54B0E881)) % 12)
			{
			case 10u:
				break;
			case 2u:
			{
				int num5;
				int num6;
				if (!KeyValues.ContainsKey(storyKey))
				{
					num5 = 2147195583;
					num6 = num5;
				}
				else
				{
					num5 = 1243111770;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -2080982939);
				continue;
			}
			case 11u:
				KeyValues[storyKey] = _200C_206D_206F_202C_206A_206B_202A_202A_202B_202A_200C_206C_206D_202D_200B_200F_200D_200C_200C_206C_202A_206B_200D_206A_200C_200E_200E_206D_200E_200D_206F_202A_202E_206D_206B_200C_202C_206C_206E_200C_202E(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2471904275u), list.ToArray());
				Yuanbao = _200E_206C_202E_200F_200F_200B_200B_206A_200D_202D_200F_206D_202E_206F_206A_206A_202E_206B_206A_200C_200E_202A_206B_200C_200B_200D_200E_206C_206C_206A_200E_206C_200C_200E_206E_200F_200B_200D_200E_202E_202E(0, Yuanbao + number);
				num = 611058725;
				continue;
			case 9u:
				goto IL_00b7;
			case 7u:
				return 0;
			case 4u:
				goto IL_00db;
			case 8u:
				return 0;
			case 3u:
			{
				int num3;
				int num4;
				if (!list.Contains(item))
				{
					num3 = 1529743363;
					num4 = num3;
				}
				else
				{
					num3 = 1217575512;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1890235370);
				continue;
			}
			case 5u:
				list = new List<string>(_206F_206C_206C_202B_206D_200D_200E_200F_200F_206E_202E_200F_206E_200F_200E_202D_202E_206A_206F_202E_202B_206C_200E_202C_200C_206C_202E_202C_200C_206C_206B_202B_202E_200E_202D_202E_202B_206E_202C_202B_202E(KeyValues[storyKey], new char[1] { '#' }, StringSplitOptions.RemoveEmptyEntries));
				num = (int)(num2 * 1924745432) ^ -1725402830;
				continue;
			case 6u:
				item = RuntimeData.Instance.RoundString();
				num = (int)(num2 * 2115013540) ^ -797958545;
				continue;
			case 1u:
				list.Add(item);
				num = (int)((num2 * 287549011) ^ 0xF74AF05);
				continue;
			default:
				return number;
			}
			break;
			IL_00db:
			int num7;
			if (!list.Contains(item))
			{
				num = 903451404;
				num7 = num;
			}
			else
			{
				num = 870568882;
				num7 = num;
			}
		}
		goto IL_000b;
		IL_00b7:
		list = new List<string>();
		num = 1862427399;
		goto IL_0010;
	}

	public static bool RemoveParam(string key)
	{
		if (KeyValues.ContainsKey(key))
		{
			while (true)
			{
				int num = 88620709;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0xF427E95)) % 5)
					{
					case 0u:
						break;
					case 1u:
						return true;
					case 3u:
						_206D_206F_202B_206D_206D_202C_202B_200D_202A_206D_202E_202B_202E_200B_206F_206A_206A_200D_202A_202D_202E_200B_200C_206A_206D_206D_202B_200B_206F_206C_202E_206B_202E_200F_200C_202D_200D_202B_200C_202B_202E = true;
						num = (int)(num2 * 116014429) ^ -1130646853;
						continue;
					case 2u:
						KeyValues.Remove(key);
						num = (int)(num2 * 1924742792) ^ -526223248;
						continue;
					default:
						goto end_IL_000d;
					}
					break;
				}
				continue;
				end_IL_000d:
				break;
			}
		}
		return false;
	}

	internal static int UpdateKeyValues(string key, int addQty, bool force = false)
	{
		if (_206C_206C_202E_200E_202E_206A_202E_206C_202C_206A_202A_206B_200E_200C_200C_202E_206A_200F_206A_200B_200C_200F_206C_200E_200E_202B_200F_206E_202D_206B_206F_206F_206B_206B_206A_200D_206A_200B_202A_200E_202E(key))
		{
			goto IL_000b;
		}
		goto IL_01fd;
		IL_000b:
		int num = -1919533069;
		goto IL_0010;
		IL_0010:
		int num5 = default(int);
		bool flag = default(bool);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -703348176)) % 27)
			{
			case 16u:
				break;
			case 10u:
				return 0;
			case 0u:
				return 0;
			case 23u:
				num5 = int.Parse(KeyValues[key]);
				num = (int)(num2 * 957936261) ^ -821275158;
				continue;
			case 26u:
			{
				int num12;
				int num13;
				if (!force)
				{
					num12 = 956812001;
					num13 = num12;
				}
				else
				{
					num12 = 2138083667;
					num13 = num12;
				}
				num = num12 ^ ((int)num2 * -739533595);
				continue;
			}
			case 19u:
				goto IL_00f3;
			case 12u:
				return -1;
			case 8u:
				return num5;
			case 7u:
				KeyValues.Remove(key);
				num = (int)((num2 * 1069593876) ^ 0x69D6EF77);
				continue;
			case 1u:
				goto IL_0149;
			case 20u:
				flag = KeyValues.ContainsKey(key);
				num = (int)((num2 * 1666203022) ^ 0x65DD9A14);
				continue;
			case 2u:
			{
				int num6;
				int num7;
				if (num5 != 0)
				{
					num6 = -455749590;
					num7 = num6;
				}
				else
				{
					num6 = -899590511;
					num7 = num6;
				}
				num = num6 ^ ((int)num2 * -1665563972);
				continue;
			}
			case 9u:
				goto IL_01a2;
			case 22u:
				return -1;
			case 21u:
				num5 += addQty;
				KeyValues[key] = _200E_206C_202E_200F_200F_200B_200B_206A_200D_202D_200F_206D_202E_206F_206A_206A_202E_206B_206A_200C_200E_202A_206B_200C_200B_200D_200E_206C_206C_206A_200E_206C_200C_200E_206E_200F_200B_200D_200E_202E_202E(0, num5).ToString();
				num = ((int)num2 * -1833047433) ^ 0x5FC54794;
				continue;
			case 3u:
				goto IL_01fd;
			case 14u:
				return num5;
			case 5u:
			{
				int num10;
				int num11;
				if (addQty >= 0)
				{
					num10 = -1643905959;
					num11 = num10;
				}
				else
				{
					num10 = -815027959;
					num11 = num10;
				}
				num = num10 ^ (int)(num2 * 608597926);
				continue;
			}
			case 15u:
				goto IL_023d;
			case 11u:
				goto IL_025c;
			case 6u:
			{
				int num8;
				int num9;
				if (force)
				{
					num8 = 1620390385;
					num9 = num8;
				}
				else
				{
					num8 = 212449217;
					num9 = num8;
				}
				num = num8 ^ ((int)num2 * -99954082);
				continue;
			}
			case 4u:
				goto IL_0290;
			case 17u:
				KeyValues[key] = num5.ToString();
				num = -1449161977;
				continue;
			case 24u:
				return 1;
			case 13u:
				return 0;
			case 18u:
			{
				int num3;
				int num4;
				if (!_206C_206C_202E_200E_202E_206A_202E_206C_202C_206A_202A_206B_200E_200C_200C_202E_206A_200F_206A_200B_200C_200F_206C_200E_200E_202B_200F_206E_202D_206B_206F_206F_206B_206B_206A_200D_206A_200B_202A_200E_202E(KeyValues[key]))
				{
					num3 = -1063466195;
					num4 = num3;
				}
				else
				{
					num3 = -1512482069;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -553656961);
				continue;
			}
			default:
				return 0;
			}
			break;
			IL_0290:
			int num14;
			if (flag)
			{
				num = -132100936;
				num14 = num;
			}
			else
			{
				num = -221362285;
				num14 = num;
			}
			continue;
			IL_0244:
			int num15;
			int num16;
			if (((uint)num15 & (force ? 1u : 0u)) != 0)
			{
				num = -417349207;
				num16 = num;
			}
			else
			{
				num = -780576955;
				num16 = num;
			}
			continue;
			IL_0149:
			num5 += addQty;
			int num17;
			if (num5 > 0)
			{
				num = -746855119;
				num17 = num;
			}
			else
			{
				num = -1606241158;
				num17 = num;
			}
			continue;
			IL_025c:
			if (flag)
			{
				num15 = 0;
				goto IL_0244;
			}
			num = ((int)num2 * -1663408706) ^ -778741957;
			continue;
			IL_00f3:
			int num18;
			if (addQty < 0)
			{
				num = -1923132337;
				num18 = num;
			}
			else
			{
				num = -750191457;
				num18 = num;
			}
			continue;
			IL_01a2:
			int num19;
			if (flag)
			{
				num = -1441727569;
				num19 = num;
			}
			else
			{
				num = -917640378;
				num19 = num;
			}
			continue;
			IL_023d:
			num15 = ((addQty < 0) ? 1 : 0);
			goto IL_0244;
		}
		goto IL_000b;
		IL_01fd:
		num5 = 0;
		num = -2098444940;
		goto IL_0010;
	}

	public static double GetParamDouble(string key)
	{
		if (KeyValues.ContainsKey(key))
		{
			while (true)
			{
				uint num;
				switch ((num = 1017070195u) % 3)
				{
				case 2u:
					continue;
				case 1u:
					return double.Parse(KeyValues[key]);
				}
				break;
			}
		}
		return 0.0;
	}

	public static void SetParamDouble(string key, double value)
	{
		KeyValues[key] = value.ToString();
		while (true)
		{
			int num = -1797307673;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1096159683)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0034;
				case 0u:
					return;
				}
				break;
				IL_0034:
				_206D_206F_202B_206D_206D_202C_202B_200D_202A_206D_202E_202B_202E_200B_206F_206A_206A_200D_202A_202D_202E_200B_200C_206A_206D_206D_202B_200B_206F_206C_202E_206B_202E_200F_200C_202D_200D_202B_200C_202B_202E = true;
				num = ((int)num2 * -1043091981) ^ -613050475;
			}
		}
	}

	static bool _206C_206C_202E_200E_202E_206A_202E_206C_202C_206A_202A_206B_200E_200C_200C_202E_206A_200F_206A_200B_200C_200F_206C_200E_200E_202B_200F_206E_202D_206B_206F_206F_206B_206B_206A_200D_206A_200B_202A_200E_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static int _200E_206C_202E_200F_200F_200B_200B_206A_200D_202D_200F_206D_202E_206F_206A_206A_202E_206B_206A_200C_200E_202A_206B_200C_200B_200D_200E_206C_206C_206A_200E_206C_200C_200E_206E_200F_200B_200D_200E_202E_202E(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	static string[] _206F_206C_206C_202B_206D_200D_200E_200F_200F_206E_202E_200F_206E_200F_200E_202D_202E_206A_206F_202E_202B_206C_200E_202C_200C_206C_202E_202C_200C_206C_206B_202B_202E_200E_202D_202E_202B_206E_202C_202B_202E(string P_0, char[] P_1, StringSplitOptions P_2)
	{
		return P_0.Split(P_1, P_2);
	}

	static string _200C_206D_206F_202C_206A_206B_202A_202A_202B_202A_200C_206C_206D_202D_200B_200F_200D_200C_200C_206C_202A_206B_200D_206A_200C_200E_200E_206D_200E_200D_206F_202A_202E_206D_206B_200C_202C_206C_206E_200C_202E(string P_0, string[] P_1)
	{
		return string.Join(P_0, P_1);
	}

	static int _206E_200B_206A_202A_206B_206C_206F_202E_202E_202D_206A_200B_200F_206A_200D_200B_200B_202B_206D_206C_206F_202A_206C_202C_206A_206F_202D_202D_206D_200C_202B_200B_200D_202A_206C_206E_202A_202D_206D_202A_202E(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	static bool _200E_200B_206E_200F_200E_202C_206D_202A_202B_206E_206E_202D_202A_206F_200C_200B_206A_206C_200E_200C_202C_206F_200D_206E_202A_202D_202D_202B_200C_206F_202C_206D_206C_202B_206E_200E_206A_202C_206E_202D_202E(string P_0)
	{
		return File.Exists(P_0);
	}

	static StreamReader _202C_200B_202E_202B_200F_202D_206B_206F_206C_202B_200E_202B_200B_202D_206F_202B_206E_202C_200D_202E_200C_206D_206D_206C_206C_202C_200F_206E_200C_206D_206D_200B_200F_206F_206D_206A_202D_202E_206B_206D_202E(string P_0)
	{
		return new StreamReader(P_0);
	}

	static string _206A_200F_202A_202E_202A_200F_206D_200F_206C_200B_200B_206F_202D_200E_206C_202E_202C_206E_200E_206C_200E_202A_202D_200F_206E_202D_206B_206E_206E_200B_202E_200D_202C_206C_200E_206B_206F_206A_202D_202E_202E(TextReader P_0)
	{
		return P_0.ReadToEnd();
	}

	static int _206D_206E_206A_206C_206C_202B_206B_202C_206A_206A_202E_206E_206E_200C_202D_206F_206F_200E_202C_202B_200C_202D_206A_206C_200C_200D_206B_206C_206F_202C_200C_206E_200F_202E_202C_202C_206B_206F_202C_206E_202E(string P_0)
	{
		return P_0.Length;
	}

	static bool _206F_206F_200C_200B_202E_200B_200F_206D_206F_206F_206D_200D_202D_202A_206B_206E_200D_206F_200D_202E_206F_202E_200F_200C_206F_200D_202A_202B_202E_200F_206B_202A_202E_202E_200B_206D_202B_200B_206C_202A_202E(string P_0, string P_1)
	{
		return P_0.StartsWith(P_1);
	}

	static StreamWriter _202C_206E_206E_206D_200E_200C_206E_200E_200F_200F_200F_200C_202E_206F_206E_206D_200C_200B_200B_200F_206E_200D_206F_202E_202A_206E_202D_206F_200E_202A_206E_202C_206F_200E_206C_202B_200E_200B_206B_206B_202E(string P_0)
	{
		return new StreamWriter(P_0);
	}

	static string _200F_202D_206C_200B_206F_200F_202B_202B_206D_200B_202D_202E_202C_206C_200C_200C_200E_200E_206A_206C_202B_202B_200B_206A_206B_202C_200E_206D_202E_202E_206B_200B_200C_200B_206F_200D_202C_202E_202B_200E_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static string _200B_206C_200D_202B_206E_200C_200E_206C_206C_202C_206A_206E_200B_206D_206F_206A_200E_206D_202B_200D_202D_206A_200D_202C_206C_202A_206C_200D_206D_206D_206D_200E_200C_206F_206B_202E_206A_200F_200F_206D_202E(string P_0, string P_1, string P_2, string P_3)
	{
		return P_0 + P_1 + P_2 + P_3;
	}

	static string _202B_200E_200D_206E_202A_202E_200C_206D_206C_200B_206C_202E_206B_206E_200B_200F_202D_206E_206C_206E_206F_202D_202C_206A_206B_206B_206A_206C_202A_206E_200E_206D_206B_206D_206C_206E_200C_202E_206C_200E_202E(string P_0)
	{
		return P_0.Trim();
	}

	static bool _206D_202C_200C_200C_206A_202D_206E_206F_202B_200F_206B_200C_206E_202E_202D_202D_206C_202C_202D_206C_206B_200C_202C_206A_206F_202E_202E_200D_202B_206F_206B_206E_200F_200E_202A_202B_202B_206C_202B_206B_202E(string P_0, string P_1)
	{
		return P_0 != P_1;
	}
}
