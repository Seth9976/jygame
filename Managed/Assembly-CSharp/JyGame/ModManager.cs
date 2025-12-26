using System.Collections.Generic;
using UnityEngine;

namespace JyGame;

public class ModManager
{
	public static List<ModInfo> mods;

	public static string ModBaseUrl => _200D_200F_206F_200F_206D_206A_202D_202B_206C_200D_202B_200D_202B_200E_200E_206E_202C_206F_200C_202B_200B_202D_202E_206B_206A_200C_200C_200B_200B_206D_202C_206D_206F_206E_206F_200D_200E_202E_202C_206E_202E(new string[5]
	{
		global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1341726453u),
		CommonSettings.persistentDataPath,
		global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3203038334u),
		GlobalData.CurrentMod.key,
		global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(533767640u)
	});

	public static string ModBaseUrlPath => _206F_206F_200E_206A_206A_200B_200D_202D_200E_206E_202B_206D_202B_202E_200F_200F_206D_200D_206D_202E_206D_200B_200F_206D_206B_200D_200C_206E_202B_200D_206C_202D_200C_200B_200F_200C_200F_206F_200D_202E(CommonSettings.persistentDataPath, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1812586943u), GlobalData.CurrentMod.key, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(249724009u));

	public static void SetCurrentMod(ModInfo mod)
	{
		ModEditorResourceManager.ClearSpriteCache();
		while (true)
		{
			int num = -743996537;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1247792212)) % 7)
				{
				case 4u:
					break;
				default:
					return;
				case 2u:
					ResourceManager.ResetInitFlag();
					num = (int)(num2 * 865202918) ^ -1981404465;
					continue;
				case 1u:
					RuntimeData.Instance.IsInited = false;
					AudioManager.Init();
					GlobalData.CurrentMod = mod;
					num = ((int)num2 * -1526963265) ^ -771472011;
					continue;
				case 5u:
					CommonSettings.SET_MOD_KEY();
					num = ((int)num2 * -65812240) ^ -1922386454;
					continue;
				case 3u:
					AssetBundleManager.IsInited = false;
					num = ((int)num2 * -1726311365) ^ -1477222778;
					continue;
				case 6u:
					ModData.Load();
					LuaManager.Reload();
					num = ((int)num2 * -1919825872) ^ -398667855;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public static void SetCurrentMod2(ModInfo mod)
	{
		if (_206A_202C_206E_206C_206D_200E_206E_202A_206A_200F_200C_206D_200B_206E_200F_206E_202D_202D_202C_206F_206A_202A_206D_200D_200D_202C_200C_206B_206A_206E_200C_206F_206C_206B_200C_200C_202B_206C_202D_200E_202E((Object)(object)ModEditorResourceManager.LogoCache, (Object)null))
		{
			goto IL_0010;
		}
		goto IL_0141;
		IL_0010:
		int num = -831526549;
		goto IL_0015;
		IL_0015:
		int quality_Level = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1303077250)) % 14)
			{
			case 7u:
				break;
			default:
				return;
			case 13u:
			{
				int num3;
				int num4;
				if (quality_Level >= 0)
				{
					num3 = 1491040951;
					num4 = num3;
				}
				else
				{
					num3 = 1352366392;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 651388236);
				continue;
			}
			case 6u:
				CommonSettings.SET_QUALITY_LEVEL(CommonSettings.GET_QUALITY_LEVEL(mod.quality));
				num = -679587040;
				continue;
			case 4u:
				ResourceStrings.LoadDefaultStrings();
				num = (int)(num2 * 1815304399) ^ -253875502;
				continue;
			case 10u:
				ResourceStrings.LoadFromFile(_200D_200D_206D_202B_206B_200C_202C_206D_202D_202C_202B_200D_200E_200E_202C_202B_206C_202A_206A_202C_202C_200E_200F_200C_200B_202D_206B_206A_202C_200F_206A_206B_206E_202A_200E_202C_206F_200B_202E_202E_202E(ModBaseUrlPath, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3796154786u)));
				num = ((int)num2 * -2144227932) ^ -1993240069;
				continue;
			case 11u:
				_206B_202E_202E_206F_200E_206C_202A_206D_202B_206B_206A_200B_202E_202B_202E_206B_202E_206F_200F_200F_202E_202A_206B_202E_200F_206E_200B_200D_206C_200B_200D_206C_200D_206A_200E_200E_202C_206D_206F_206D_202E((Object)(object)ModEditorResourceManager.LogoCache);
				num = (int)((num2 * 2010562282) ^ 0x759A7F6A);
				continue;
			case 2u:
				ModEditorResourceManager.LogoCache = null;
				num = ((int)num2 * -835228832) ^ 0x3749D2C8;
				continue;
			case 3u:
				CommonSettings.SET_QUALITY_LEVEL(quality_Level);
				num = ((int)num2 * -845840153) ^ -1710057437;
				continue;
			case 12u:
				quality_Level = ModData.Get_Quality_Level();
				num = ((int)num2 * -1205162572) ^ 0x53AE830F;
				continue;
			case 8u:
				goto IL_0141;
			case 9u:
				CommonSettings.InitSettings();
				num = -1653285973;
				continue;
			case 0u:
				ModEditorResourceManager.LogoCache = ModEditorResourceManager.LoadSpriteWithCompress(_200D_200D_206D_202B_206B_200C_202C_206D_202D_202C_202B_200D_200E_200E_202C_202B_206C_202A_206A_202C_202C_200E_200F_200C_200B_202D_206B_206A_202C_200F_206A_206B_206E_202A_200E_202C_206F_200B_202E_202E_202E(mod.LocalDirPath, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(221466847u)));
				num = -1698798862;
				continue;
			case 1u:
				CommonSettings.SET_QUALITY_LEVEL(3);
				ResourceStrings.LoadDefaultStrings();
				num = -1195529061;
				continue;
			case 5u:
				return;
			}
			break;
		}
		goto IL_0010;
		IL_0141:
		int num5;
		if (CommonSettings.MOD_KEY() == -1)
		{
			num = -1916381897;
			num5 = num;
		}
		else
		{
			num = -1125902734;
			num5 = num;
		}
		goto IL_0015;
	}

	static string _200D_200F_206F_200F_206D_206A_202D_202B_206C_200D_202B_200D_202B_200E_200E_206E_202C_206F_200C_202B_200B_202D_202E_206B_206A_200C_200C_200B_200B_206D_202C_206D_206F_206E_206F_200D_200E_202E_202C_206E_202E(string[] P_0)
	{
		return string.Concat(P_0);
	}

	static string _206F_206F_200E_206A_206A_200B_200D_202D_200E_206E_202B_206D_202B_202E_200F_200F_206D_200D_206D_202E_206D_200B_200F_206D_206B_200D_200C_206E_202B_200D_206C_202D_200C_200B_200F_200C_200F_206F_200D_202E(string P_0, string P_1, string P_2, string P_3)
	{
		return P_0 + P_1 + P_2 + P_3;
	}

	static bool _206A_202C_206E_206C_206D_200E_206E_202A_206A_200F_200C_206D_200B_206E_200F_206E_202D_202D_202C_206F_206A_202A_206D_200D_200D_202C_200C_206B_206A_206E_200C_206F_206C_206B_200C_200C_202B_206C_202D_200E_202E(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static void _206B_202E_202E_206F_200E_206C_202A_206D_202B_206B_206A_200B_202E_202B_202E_206B_202E_206F_200F_200F_202E_202A_206B_202E_200F_206E_200B_200D_206C_200B_200D_206C_200D_206A_200E_200E_202C_206D_206F_206D_202E(Object P_0)
	{
		Object.DestroyImmediate(P_0);
	}

	static string _200D_200D_206D_202B_206B_200C_202C_206D_202D_202C_202B_200D_200E_200E_202C_202B_206C_202A_206A_202C_202C_200E_200F_200C_200B_202D_206B_206A_202C_200F_206A_206B_206E_202A_200E_202C_206F_200B_202E_202E_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}
}
