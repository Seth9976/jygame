using System;
using LuaInterface;
using UnityEngine;

public class AssetBundleWrap
{
	private static Type classType = _202E_200E_200F_200B_202E_206B_202C_202A_200C_200C_202A_206B_206C_200E_206E_200B_206D_200B_202D_200B_202A_202B_200E_206F_206D_200B_206F_200E_200C_200D_202B_202D_202E_206E_200E_206B_206E_200C_206F_206F_202E(typeof(AssetBundle).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[16]
		{
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2880539218u), CreateFromMemory),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3012759633u), CreateFromMemoryImmediate),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2672105375u), CreateFromFile),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1564593168u), Contains),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3791532417u), LoadAsset),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1642387394u), LoadAssetAsync),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(585720565u), LoadAssetWithSubAssets),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(275337905u), LoadAssetWithSubAssetsAsync),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(774398030u), LoadAllAssets),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3155850284u), LoadAllAssetsAsync),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1772494639u), Unload),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2150852406u), GetAllAssetNames),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1884486018u), GetAllScenePaths),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1621874631u), _206D_206A_206D_202D_206B_202E_200E_200E_202D_202B_200C_206B_202A_206E_202E_200D_206B_206F_206E_206B_200B_200D_200F_206B_202E_206B_202C_200B_202B_200C_206E_202B_202E_200B_200B_206A_202B_202B_206B_202E_202E),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2783592835u), GetClassType),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2206010212u), Lua_Eq)
		};
		LuaField[] fields = default(LuaField[]);
		while (true)
		{
			int num = -1992870704;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2090594919)) % 4)
				{
				case 3u:
					break;
				default:
					return;
				case 1u:
					fields = new LuaField[1]
					{
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(37493382u), get_mainAsset, null)
					};
					num = (int)(num2 * 954379140) ^ -869206599;
					continue;
				case 0u:
					LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3834379586u), _202E_200E_200F_200B_202E_206B_202C_202A_200C_200C_202A_206B_206C_200E_206E_200B_206D_200B_202D_200B_202A_202B_200E_206F_206D_200B_206F_200E_200C_200D_202B_202D_202E_206E_200E_206B_206E_200C_206F_206F_202E(typeof(AssetBundle).TypeHandle), regs, fields, _202E_200E_200F_200B_202E_206B_202C_202A_200C_200C_202A_206B_206C_200E_206E_200B_206D_200B_202D_200B_202A_202B_200E_206F_206D_200B_206F_200E_200C_200D_202B_202D_202E_206E_200E_206B_206E_200C_206F_206F_202E(typeof(Object).TypeHandle));
					num = (int)(num2 * 1380479015) ^ -1187962857;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _206D_206A_206D_202D_206B_202E_200E_200E_202D_202B_200C_206B_202A_206E_202E_200D_206B_206F_206E_206B_200B_200D_200F_206B_202E_206B_202C_200B_202B_200C_206E_202B_202E_200B_200B_206A_202B_202B_206B_202E_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		AssetBundle obj = default(AssetBundle);
		while (true)
		{
			int num2 = -816524470;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -2136093932)) % 7)
				{
				case 0u:
					break;
				case 2u:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2059296167u));
					num2 = -5351038;
					continue;
				case 3u:
					obj = _200F_206C_202D_206D_200B_206E_206C_200C_202D_202A_200C_200D_202E_206D_202C_202D_206C_202B_206E_202C_206F_202B_200F_206C_206A_206C_206D_200D_200C_202D_200B_200C_200B_200B_200E_200C_206B_206A_202B_206F_202E();
					num2 = ((int)num3 * -749958857) ^ -1022012332;
					continue;
				case 5u:
					return 1;
				case 1u:
					LuaScriptMgr.Push(P_0, (Object)(object)obj);
					num2 = (int)((num3 * 389465269) ^ 0x18CEED53);
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (num == 0)
					{
						num4 = 1384244828;
						num5 = num4;
					}
					else
					{
						num4 = 850976499;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -787344410);
					continue;
				}
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_mainAsset(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AssetBundle val = (AssetBundle)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 2069968491;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3F5902BB)) % 7)
				{
				case 6u:
					break;
				case 1u:
				{
					int num5;
					int num6;
					if (!_206A_202C_202B_200F_206A_200D_202C_202B_200E_202C_202E_202B_200B_200D_202B_206E_206F_206F_202C_206D_202A_200B_206E_200B_206C_202C_202A_202E_200B_206C_206B_200C_206F_206C_202D_200F_202B_200E_200C_200E_202E((Object)(object)val, (Object)null))
					{
						num5 = -348693940;
						num6 = num5;
					}
					else
					{
						num5 = -212300163;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1343174813);
					continue;
				}
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -574732480) ^ 0x61044042;
					continue;
				case 5u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1400763052;
						num4 = num3;
					}
					else
					{
						num3 = -1990733165;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1360666977);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2456617497u));
					num = (int)((num2 * 2068776701) ^ 0x67A93AEF);
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1455214065u));
					num = 788350524;
					continue;
				default:
					LuaScriptMgr.Push(L, _200E_206E_200E_202C_200B_206D_206C_202E_206D_200C_206C_202D_202C_202D_206E_206B_200E_206B_200F_200E_206C_200C_206F_206B_200E_202A_200C_206A_200E_200E_200E_206C_206B_202D_200E_200F_206A_200E_202C_202C_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int CreateFromMemory(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		byte[] arrayNumber = LuaScriptMgr.GetArrayNumber<byte>(L, 1);
		while (true)
		{
			int num = -1381632480;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1875208166)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0031;
				default:
					return 1;
				}
				break;
				IL_0031:
				AssetBundleCreateRequest o = _206F_206D_206C_206E_206F_206F_202E_202E_202C_200B_200E_202C_206A_200B_200D_206D_206B_200E_200E_206B_202D_200D_202B_206E_200E_200C_202A_202E_202E_202E_200E_202A_202C_206A_202D_200D_202E_206B_200B_202E_202E(arrayNumber);
				LuaScriptMgr.PushObject(L, o);
				num = ((int)num2 * -571372196) ^ 0x1995640A;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int CreateFromMemoryImmediate(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		AssetBundle obj = default(AssetBundle);
		while (true)
		{
			int num = -1775002922;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2134808782)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0029;
				default:
					LuaScriptMgr.Push(L, (Object)(object)obj);
					return 1;
				}
				break;
				IL_0029:
				byte[] arrayNumber = LuaScriptMgr.GetArrayNumber<byte>(L, 1);
				obj = _200E_200F_202D_202B_206B_202A_200D_202C_202E_202B_202E_206B_200B_200B_202B_202D_206D_200D_200F_206B_200B_202D_206C_200B_202D_200E_206F_200B_202D_200C_206D_202D_200B_200C_202C_202B_202E_206F_202A_200F_202E(arrayNumber);
				num = ((int)num2 * -455218726) ^ 0x42A26952;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int CreateFromFile(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		string luaString = LuaScriptMgr.GetLuaString(L, 1);
		AssetBundle obj = _206F_202C_202A_200C_200D_200D_200C_206F_200D_202B_200C_206A_200E_200B_206B_202A_206A_206F_200C_206A_200F_206E_206F_200B_206E_200C_202D_202A_206A_202A_200D_206D_202E_202D_200E_200E_200C_200E_206E_202B_202E(luaString);
		LuaScriptMgr.Push(L, (Object)(object)obj);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Contains(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		AssetBundle val = (AssetBundle)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1260520869u));
		string luaString = default(string);
		bool b = default(bool);
		while (true)
		{
			int num = -2050384235;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1743742889)) % 4)
				{
				case 3u:
					break;
				case 2u:
					luaString = LuaScriptMgr.GetLuaString(L, 2);
					num = (int)((num2 * 1144455319) ^ 0x2BE4559C);
					continue;
				case 1u:
					b = _202D_200C_200D_200E_206E_202A_200C_206B_206D_206B_202A_202A_206F_200E_206D_200E_200D_200E_200F_200F_200B_202C_200D_206A_200F_200C_202B_206F_200C_206B_206A_206C_202D_200B_200B_202C_202C_206B_206E_202E_202E(val, luaString);
					num = (int)(num2 * 77627093) ^ -372372338;
					continue;
				default:
					LuaScriptMgr.Push(L, b);
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int LoadAsset(IntPtr L)
	{
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		AssetBundle val = default(AssetBundle);
		while (true)
		{
			int num2 = 1637980214;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x7E19320B)) % 8)
				{
				case 6u:
					break;
				case 4u:
					return 1;
				case 1u:
				{
					AssetBundle val2 = (AssetBundle)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2625006314u));
					string luaString2 = LuaScriptMgr.GetLuaString(L, 2);
					Type typeObject = LuaScriptMgr.GetTypeObject(L, 3);
					Object obj2 = _200E_202D_206B_202E_206C_206A_200D_202C_206F_200E_200E_202B_202D_202C_202E_202C_202D_202D_202A_200B_202C_200F_202A_206E_202C_202C_202B_200C_206C_200D_200C_206B_206F_200D_202C_202E_202D_202D_200D_206E_202E(val2, luaString2, typeObject);
					LuaScriptMgr.Push(L, obj2);
					num2 = (int)(num3 * 744771321) ^ -2072477914;
					continue;
				}
				case 2u:
				{
					string luaString = LuaScriptMgr.GetLuaString(L, 2);
					Object obj = _206F_206C_200F_206F_200C_206F_200B_206E_200C_200B_200C_200C_202B_202A_206C_200B_202A_202C_202A_200C_202D_206A_206A_206B_200E_202A_206C_200E_202E_206B_202C_202D_206B_202B_200F_202D_206E_200B_200F_206E_202E(val, luaString);
					LuaScriptMgr.Push(L, obj);
					return 1;
				}
				case 5u:
				{
					int num5;
					int num6;
					if (num == 2)
					{
						num5 = -1237116214;
						num6 = num5;
					}
					else
					{
						num5 = -465825975;
						num6 = num5;
					}
					num2 = num5 ^ (int)(num3 * 1386335789);
					continue;
				}
				case 0u:
					val = (AssetBundle)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4136263530u));
					num2 = (int)(num3 * 1144356269) ^ -630838111;
					continue;
				case 3u:
				{
					int num4;
					if (num != 3)
					{
						num2 = 1944285484;
						num4 = num2;
					}
					else
					{
						num2 = 1444965850;
						num4 = num2;
					}
					continue;
				}
				default:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3711568182u));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int LoadAssetAsync(IntPtr L)
	{
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_0118;
		IL_000e:
		int num2 = 333050298;
		goto IL_0013;
		IL_0013:
		Type typeObject = default(Type);
		AssetBundle val = default(AssetBundle);
		string luaString = default(string);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x594BFED4)) % 9)
			{
			case 0u:
				break;
			case 6u:
			{
				AssetBundle val2 = (AssetBundle)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1884862363u));
				string luaString2 = LuaScriptMgr.GetLuaString(L, 2);
				AssetBundleRequest o2 = _202A_200C_202D_202C_206B_202B_206B_206D_202B_202A_200B_206C_200E_206D_206C_202A_202A_202A_206B_200D_206B_206C_202E_206D_202E_202C_202A_202D_202B_206B_206E_200D_200D_206F_206B_202A_206B_206D_200C_202E(val2, luaString2);
				LuaScriptMgr.PushObject(L, o2);
				num2 = (int)(num3 * 1149131627) ^ -1742809921;
				continue;
			}
			case 8u:
				return 1;
			case 3u:
				typeObject = LuaScriptMgr.GetTypeObject(L, 3);
				num2 = (int)((num3 * 1991516951) ^ 0x25E407B9);
				continue;
			case 7u:
			{
				AssetBundleRequest o = _202B_200E_206F_200E_206C_200B_206E_206B_206F_202D_206E_200E_206B_202D_206B_206F_200D_200E_200C_200E_202A_200C_202A_202E_202E_206A_202E_206A_202E_200B_206C_202A_202D_202D_200F_202A_200B_206A_202B_200E_202E(val, luaString, typeObject);
				LuaScriptMgr.PushObject(L, o);
				num2 = (int)(num3 * 1468722244) ^ -82726925;
				continue;
			}
			case 5u:
				val = (AssetBundle)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1260520869u));
				luaString = LuaScriptMgr.GetLuaString(L, 2);
				num2 = ((int)num3 * -1184199242) ^ 0x18FE5F41;
				continue;
			case 4u:
				goto IL_0118;
			case 2u:
				return 1;
			default:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3323510372u));
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_0118:
		int num4;
		if (num != 3)
		{
			num2 = 245416215;
			num4 = num2;
		}
		else
		{
			num2 = 824430758;
			num4 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int LoadAssetWithSubAssets(IntPtr L)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000b;
		}
		goto IL_0083;
		IL_000b:
		int num2 = 2114568904;
		goto IL_0010;
		IL_0010:
		AssetBundle val = default(AssetBundle);
		Object[] o = default(Object[]);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x532EE3BA)) % 8)
			{
			case 4u:
				break;
			case 2u:
			{
				AssetBundle val2 = (AssetBundle)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4136263530u));
				string luaString2 = LuaScriptMgr.GetLuaString(L, 2);
				Object[] o2 = _206B_200E_206E_202D_206E_202D_206B_206D_206D_206A_202D_202B_206F_200C_202E_202B_200C_202A_202B_202C_202E_206B_200B_206D_206B_200C_200C_202B_206C_202D_202B_200B_206A_200E_200F_202D_202C_206F_200B_200E_202E(val2, luaString2);
				LuaScriptMgr.PushArray(L, o2);
				num2 = ((int)num3 * -1539023842) ^ 0x522B1597;
				continue;
			}
			case 7u:
				goto IL_0083;
			case 6u:
				val = (AssetBundle)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2625006314u));
				num2 = (int)((num3 * 700256086) ^ 0x766F150D);
				continue;
			case 3u:
			{
				string luaString = LuaScriptMgr.GetLuaString(L, 2);
				Type typeObject = LuaScriptMgr.GetTypeObject(L, 3);
				o = _202E_206E_200D_202B_202C_206B_200E_206A_206E_206E_200E_202C_202C_200E_200C_206D_202D_200B_206F_206B_200E_202C_206E_206B_206B_206E_202D_206F_202E_202D_206E_200C_202A_206F_206A_202D_202E_206D_206A_200F_202E(val, luaString, typeObject);
				num2 = (int)((num3 * 1542348415) ^ 0x7356EF2F);
				continue;
			}
			case 1u:
				return 1;
			case 0u:
				LuaScriptMgr.PushArray(L, o);
				return 1;
			default:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3958057036u));
				return 0;
			}
			break;
		}
		goto IL_000b;
		IL_0083:
		int num4;
		if (num == 3)
		{
			num2 = 127332932;
			num4 = num2;
		}
		else
		{
			num2 = 1178409775;
			num4 = num2;
		}
		goto IL_0010;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int LoadAssetWithSubAssetsAsync(IntPtr L)
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_0142;
		IL_000e:
		int num2 = 1072986170;
		goto IL_0013;
		IL_0013:
		AssetBundle val2 = default(AssetBundle);
		string luaString2 = default(string);
		AssetBundleRequest o2 = default(AssetBundleRequest);
		AssetBundleRequest o = default(AssetBundleRequest);
		AssetBundle val = default(AssetBundle);
		string luaString = default(string);
		Type typeObject = default(Type);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x6D1D12CA)) % 11)
			{
			case 10u:
				break;
			case 7u:
				val2 = (AssetBundle)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1884862363u));
				luaString2 = LuaScriptMgr.GetLuaString(L, 2);
				num2 = (int)(num3 * 1449779846) ^ -818780208;
				continue;
			case 2u:
				LuaScriptMgr.PushObject(L, o2);
				return 1;
			case 4u:
				return 1;
			case 1u:
				LuaScriptMgr.PushObject(L, o);
				num2 = (int)(num3 * 1966967393) ^ -629799337;
				continue;
			case 0u:
				o2 = _202A_206D_206A_206A_206A_206F_206C_206C_200D_202A_200B_206B_206F_202E_202B_202A_202A_202D_206B_206E_200E_206D_200C_202E_202A_206C_206B_206F_202C_200E_202A_202D_202E_202D_200B_206E_206F_206F_200B_200E_202E(val2, luaString2);
				num2 = (int)(num3 * 172647805) ^ -855417371;
				continue;
			case 6u:
				val = (AssetBundle)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2625006314u));
				luaString = LuaScriptMgr.GetLuaString(L, 2);
				typeObject = LuaScriptMgr.GetTypeObject(L, 3);
				num2 = ((int)num3 * -432923312) ^ 0x4745376D;
				continue;
			case 9u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3333532648u));
				num2 = 1094251008;
				continue;
			case 5u:
				goto IL_0142;
			case 3u:
				o = _206C_200E_202B_206E_206E_206D_206E_202B_202E_200F_200E_200E_206D_200D_202B_200D_206D_206A_202D_202B_200E_206F_206F_206F_202A_200F_200D_202E_206D_202E_202C_206E_200D_202D_200F_206D_206A_202C_202C_206C_202E(val, luaString, typeObject);
				num2 = (int)((num3 * 1283833570) ^ 0x7E78D3FF);
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_0142:
		int num4;
		if (num != 3)
		{
			num2 = 1408680455;
			num4 = num2;
		}
		else
		{
			num2 = 1813847308;
			num4 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int LoadAllAssets(IntPtr L)
	{
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		Object[] o = default(Object[]);
		Object[] o2 = default(Object[]);
		while (true)
		{
			int num2 = -557697437;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -200751374)) % 9)
				{
				case 4u:
					break;
				case 6u:
					LuaScriptMgr.PushArray(L, o);
					return 1;
				case 1u:
				{
					int num6;
					if (num == 2)
					{
						num2 = -475809258;
						num6 = num2;
					}
					else
					{
						num2 = -1357858990;
						num6 = num2;
					}
					continue;
				}
				case 3u:
				{
					AssetBundle val2 = (AssetBundle)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1260520869u));
					o2 = _202C_200D_202D_206C_200B_206A_200F_200F_200E_200F_202C_200D_202D_206A_206D_206C_200E_206D_206D_206C_202B_200E_206D_200D_206B_200C_200D_206E_200D_202D_206E_202C_206F_206A_200C_200C_200B_206E_200B_200C_202E(val2);
					num2 = (int)(num3 * 1009531580) ^ -110085207;
					continue;
				}
				case 5u:
				{
					int num4;
					int num5;
					if (num != 1)
					{
						num4 = 1894309568;
						num5 = num4;
					}
					else
					{
						num4 = 1700100831;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 972553705);
					continue;
				}
				case 8u:
					LuaScriptMgr.PushArray(L, o2);
					num2 = (int)(num3 * 1540623279) ^ -1789028498;
					continue;
				case 2u:
					return 1;
				case 0u:
				{
					AssetBundle val = (AssetBundle)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1260520869u));
					Type typeObject = LuaScriptMgr.GetTypeObject(L, 2);
					o = _202B_200E_206B_202B_202E_206E_206E_206C_202B_202E_206D_206D_206A_206C_200B_206E_206F_206B_206A_202C_202D_202B_206F_206C_200F_200E_206B_202B_206B_206F_206F_206D_206F_200F_206D_202E_200B_202B_200C_200E_202E(val, typeObject);
					num2 = (int)(num3 * 588930413) ^ -602860863;
					continue;
				}
				default:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2783940727u));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int LoadAllAssetsAsync(IntPtr L)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 1)
		{
			goto IL_000b;
		}
		goto IL_0052;
		IL_000b:
		int num2 = 355975524;
		goto IL_0010;
		IL_0010:
		AssetBundleRequest o2 = default(AssetBundleRequest);
		AssetBundle val2 = default(AssetBundle);
		AssetBundleRequest o = default(AssetBundleRequest);
		Type typeObject = default(Type);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x59F9F667)) % 11)
			{
			case 7u:
				break;
			case 10u:
				goto IL_0052;
			case 2u:
				LuaScriptMgr.PushObject(L, o2);
				return 1;
			case 9u:
				val2 = (AssetBundle)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2458391744u));
				num2 = ((int)num3 * -331115348) ^ 0x39E40E2A;
				continue;
			case 8u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(673819771u));
				num2 = 1735030162;
				continue;
			case 3u:
				o = _200C_202E_200B_202E_200B_202C_200E_206B_206C_206B_200B_206D_200E_202E_206E_202D_202A_206F_206E_206A_200D_202B_202E_200D_202B_206F_206F_206E_206C_206D_200E_202C_206C_200F_206E_202A_202E_202E_206E_206F_202E(val2, typeObject);
				num2 = (int)((num3 * 981883436) ^ 0x52C1ECF0);
				continue;
			case 4u:
			{
				AssetBundle val = (AssetBundle)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2458391744u));
				o2 = _200F_206D_200B_206F_200C_200C_202B_200F_206B_206D_206E_206E_206C_206A_200F_200E_206E_202D_200D_202A_202E_206A_200B_206B_202A_206B_206B_200C_206A_202B_200D_202B_206B_200B_200C_206D_202E_200B_202A_202B_202E(val);
				num2 = ((int)num3 * -2127056295) ^ 0x2D4B2865;
				continue;
			}
			case 6u:
				return 1;
			case 1u:
				typeObject = LuaScriptMgr.GetTypeObject(L, 2);
				num2 = (int)((num3 * 2095398380) ^ 0x58A03226);
				continue;
			case 0u:
				LuaScriptMgr.PushObject(L, o);
				num2 = ((int)num3 * -1878146704) ^ -1128166445;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_000b;
		IL_0052:
		int num4;
		if (num != 2)
		{
			num2 = 1482651878;
			num4 = num2;
		}
		else
		{
			num2 = 177004643;
			num4 = num2;
		}
		goto IL_0010;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Unload(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		AssetBundle val = default(AssetBundle);
		bool boolean = default(bool);
		while (true)
		{
			int num = -1543239339;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1150801324)) % 4)
				{
				case 2u:
					break;
				case 1u:
					val = (AssetBundle)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2625006314u));
					num = (int)(num2 * 771850337) ^ -531689510;
					continue;
				case 3u:
					boolean = LuaScriptMgr.GetBoolean(L, 2);
					num = ((int)num2 * -1212109510) ^ -486574962;
					continue;
				default:
					_200E_206C_206B_200D_202B_200D_200D_200D_200B_206C_200B_200F_202A_200C_202D_202C_206B_200F_200E_202A_202B_200D_202D_206E_202D_206D_200E_206D_206F_200E_200F_200F_206D_206E_206F_202E_200D_202D_206D_200C_202E(val, boolean);
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetAllAssetNames(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		AssetBundle val = (AssetBundle)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1260520869u));
		string[] o = default(string[]);
		while (true)
		{
			int num = 585939908;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x384A20A3)) % 4)
				{
				case 0u:
					break;
				case 3u:
					o = _200B_202C_206E_200E_202C_206E_206E_200E_206E_200F_200B_202C_202C_200F_206F_206A_206E_200B_200F_206D_200E_200E_206C_206C_202D_200E_202D_202B_200D_200B_200E_202D_206C_206A_202D_202A_202B_206E_206A_206D_202E(val);
					num = (int)((num2 * 1454642582) ^ 0x70418ECB);
					continue;
				case 2u:
					LuaScriptMgr.PushArray(L, o);
					num = ((int)num2 * -819938148) ^ -807130614;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetAllScenePaths(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		AssetBundle val = default(AssetBundle);
		string[] o = default(string[]);
		while (true)
		{
			int num = -857502812;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1362888367)) % 4)
				{
				case 0u:
					break;
				case 1u:
					val = (AssetBundle)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2625006314u));
					num = ((int)num2 * -1406976611) ^ -315421446;
					continue;
				case 2u:
					o = _206D_202A_200D_200C_200D_202A_202D_202B_206B_202C_202D_206F_206C_206E_202C_202D_202C_206A_200D_206D_206F_200F_202A_202E_206C_200F_202B_202D_202A_206C_206F_200C_202B_200B_202D_202A_200B_206D_206E_206F_202E(val);
					num = (int)(num2 * 396364183) ^ -323018892;
					continue;
				default:
					LuaScriptMgr.PushArray(L, o);
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Object val = (Object)((luaObject is Object) ? luaObject : null);
		Object val2 = default(Object);
		while (true)
		{
			int num = 1971576640;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x77A6D089)) % 4)
				{
				case 2u:
					break;
				case 1u:
				{
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
					val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
					num = (int)((num2 * 50055410) ^ 0x623AB047);
					continue;
				}
				case 0u:
				{
					bool b = _206A_202C_202B_200F_206A_200D_202C_202B_200E_202C_202E_202B_200B_200D_202B_206E_206F_206F_202C_206D_202A_200B_206E_200B_206C_202C_202A_202E_200B_206C_206B_200C_206F_206C_202D_200F_202B_200E_200C_200E_202E(val, val2);
					LuaScriptMgr.Push(L, b);
					num = (int)((num2 * 1546007131) ^ 0x507B3C32);
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _202E_200E_200F_200B_202E_206B_202C_202A_200C_200C_202A_206B_206C_200E_206E_200B_206D_200B_202D_200B_202A_202B_200E_206F_206D_200B_206F_200E_200C_200D_202B_202D_202E_206E_200E_206B_206E_200C_206F_206F_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static AssetBundle _200F_206C_202D_206D_200B_206E_206C_200C_202D_202A_200C_200D_202E_206D_202C_202D_206C_202B_206E_202C_206F_202B_200F_206C_206A_206C_206D_200D_200C_202D_200B_200C_200B_200B_200E_200C_206B_206A_202B_206F_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new AssetBundle();
	}

	static bool _206A_202C_202B_200F_206A_200D_202C_202B_200E_202C_202E_202B_200B_200D_202B_206E_206F_206F_202C_206D_202A_200B_206E_200B_206C_202C_202A_202E_200B_206C_206B_200C_206F_206C_202D_200F_202B_200E_200C_200E_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static Object _200E_206E_200E_202C_200B_206D_206C_202E_206D_200C_206C_202D_202C_202D_206E_206B_200E_206B_200F_200E_206C_200C_206F_206B_200E_202A_200C_206A_200E_200E_200E_206C_206B_202D_200E_200F_206A_200E_202C_202C_202E(AssetBundle P_0)
	{
		return P_0.mainAsset;
	}

	static AssetBundleCreateRequest _206F_206D_206C_206E_206F_206F_202E_202E_202C_200B_200E_202C_206A_200B_200D_206D_206B_200E_200E_206B_202D_200D_202B_206E_200E_200C_202A_202E_202E_202E_200E_202A_202C_206A_202D_200D_202E_206B_200B_202E_202E(byte[] P_0)
	{
		return AssetBundle.CreateFromMemory(P_0);
	}

	static AssetBundle _200E_200F_202D_202B_206B_202A_200D_202C_202E_202B_202E_206B_200B_200B_202B_202D_206D_200D_200F_206B_200B_202D_206C_200B_202D_200E_206F_200B_202D_200C_206D_202D_200B_200C_202C_202B_202E_206F_202A_200F_202E(byte[] P_0)
	{
		return AssetBundle.CreateFromMemoryImmediate(P_0);
	}

	static AssetBundle _206F_202C_202A_200C_200D_200D_200C_206F_200D_202B_200C_206A_200E_200B_206B_202A_206A_206F_200C_206A_200F_206E_206F_200B_206E_200C_202D_202A_206A_202A_200D_206D_202E_202D_200E_200E_200C_200E_206E_202B_202E(string P_0)
	{
		return AssetBundle.CreateFromFile(P_0);
	}

	static bool _202D_200C_200D_200E_206E_202A_200C_206B_206D_206B_202A_202A_206F_200E_206D_200E_200D_200E_200F_200F_200B_202C_200D_206A_200F_200C_202B_206F_200C_206B_206A_206C_202D_200B_200B_202C_202C_206B_206E_202E_202E(AssetBundle P_0, string P_1)
	{
		return P_0.Contains(P_1);
	}

	static Object _206F_206C_200F_206F_200C_206F_200B_206E_200C_200B_200C_200C_202B_202A_206C_200B_202A_202C_202A_200C_202D_206A_206A_206B_200E_202A_206C_200E_202E_206B_202C_202D_206B_202B_200F_202D_206E_200B_200F_206E_202E(AssetBundle P_0, string P_1)
	{
		return P_0.LoadAsset(P_1);
	}

	static Object _200E_202D_206B_202E_206C_206A_200D_202C_206F_200E_200E_202B_202D_202C_202E_202C_202D_202D_202A_200B_202C_200F_202A_206E_202C_202C_202B_200C_206C_200D_200C_206B_206F_200D_202C_202E_202D_202D_200D_206E_202E(AssetBundle P_0, string P_1, Type P_2)
	{
		return P_0.LoadAsset(P_1, P_2);
	}

	static AssetBundleRequest _202A_200C_202D_202C_206B_202B_206B_206D_202B_202A_200B_206C_200E_206D_206C_202A_202A_202A_206B_200D_206B_206C_202E_206D_202E_202C_202A_202D_202B_206B_206E_200D_200D_206F_206B_202A_206B_206D_200C_202E(AssetBundle P_0, string P_1)
	{
		return P_0.LoadAssetAsync(P_1);
	}

	static AssetBundleRequest _202B_200E_206F_200E_206C_200B_206E_206B_206F_202D_206E_200E_206B_202D_206B_206F_200D_200E_200C_200E_202A_200C_202A_202E_202E_206A_202E_206A_202E_200B_206C_202A_202D_202D_200F_202A_200B_206A_202B_200E_202E(AssetBundle P_0, string P_1, Type P_2)
	{
		return P_0.LoadAssetAsync(P_1, P_2);
	}

	static Object[] _206B_200E_206E_202D_206E_202D_206B_206D_206D_206A_202D_202B_206F_200C_202E_202B_200C_202A_202B_202C_202E_206B_200B_206D_206B_200C_200C_202B_206C_202D_202B_200B_206A_200E_200F_202D_202C_206F_200B_200E_202E(AssetBundle P_0, string P_1)
	{
		return P_0.LoadAssetWithSubAssets(P_1);
	}

	static Object[] _202E_206E_200D_202B_202C_206B_200E_206A_206E_206E_200E_202C_202C_200E_200C_206D_202D_200B_206F_206B_200E_202C_206E_206B_206B_206E_202D_206F_202E_202D_206E_200C_202A_206F_206A_202D_202E_206D_206A_200F_202E(AssetBundle P_0, string P_1, Type P_2)
	{
		return P_0.LoadAssetWithSubAssets(P_1, P_2);
	}

	static AssetBundleRequest _202A_206D_206A_206A_206A_206F_206C_206C_200D_202A_200B_206B_206F_202E_202B_202A_202A_202D_206B_206E_200E_206D_200C_202E_202A_206C_206B_206F_202C_200E_202A_202D_202E_202D_200B_206E_206F_206F_200B_200E_202E(AssetBundle P_0, string P_1)
	{
		return P_0.LoadAssetWithSubAssetsAsync(P_1);
	}

	static AssetBundleRequest _206C_200E_202B_206E_206E_206D_206E_202B_202E_200F_200E_200E_206D_200D_202B_200D_206D_206A_202D_202B_200E_206F_206F_206F_202A_200F_200D_202E_206D_202E_202C_206E_200D_202D_200F_206D_206A_202C_202C_206C_202E(AssetBundle P_0, string P_1, Type P_2)
	{
		return P_0.LoadAssetWithSubAssetsAsync(P_1, P_2);
	}

	static Object[] _202C_200D_202D_206C_200B_206A_200F_200F_200E_200F_202C_200D_202D_206A_206D_206C_200E_206D_206D_206C_202B_200E_206D_200D_206B_200C_200D_206E_200D_202D_206E_202C_206F_206A_200C_200C_200B_206E_200B_200C_202E(AssetBundle P_0)
	{
		return P_0.LoadAllAssets();
	}

	static Object[] _202B_200E_206B_202B_202E_206E_206E_206C_202B_202E_206D_206D_206A_206C_200B_206E_206F_206B_206A_202C_202D_202B_206F_206C_200F_200E_206B_202B_206B_206F_206F_206D_206F_200F_206D_202E_200B_202B_200C_200E_202E(AssetBundle P_0, Type P_1)
	{
		return P_0.LoadAllAssets(P_1);
	}

	static AssetBundleRequest _200F_206D_200B_206F_200C_200C_202B_200F_206B_206D_206E_206E_206C_206A_200F_200E_206E_202D_200D_202A_202E_206A_200B_206B_202A_206B_206B_200C_206A_202B_200D_202B_206B_200B_200C_206D_202E_200B_202A_202B_202E(AssetBundle P_0)
	{
		return P_0.LoadAllAssetsAsync();
	}

	static AssetBundleRequest _200C_202E_200B_202E_200B_202C_200E_206B_206C_206B_200B_206D_200E_202E_206E_202D_202A_206F_206E_206A_200D_202B_202E_200D_202B_206F_206F_206E_206C_206D_200E_202C_206C_200F_206E_202A_202E_202E_206E_206F_202E(AssetBundle P_0, Type P_1)
	{
		return P_0.LoadAllAssetsAsync(P_1);
	}

	static void _200E_206C_206B_200D_202B_200D_200D_200D_200B_206C_200B_200F_202A_200C_202D_202C_206B_200F_200E_202A_202B_200D_202D_206E_202D_206D_200E_206D_206F_200E_200F_200F_206D_206E_206F_202E_200D_202D_206D_200C_202E(AssetBundle P_0, bool P_1)
	{
		P_0.Unload(P_1);
	}

	static string[] _200B_202C_206E_200E_202C_206E_206E_200E_206E_200F_200B_202C_202C_200F_206F_206A_206E_200B_200F_206D_200E_200E_206C_206C_202D_200E_202D_202B_200D_200B_200E_202D_206C_206A_202D_202A_202B_206E_206A_206D_202E(AssetBundle P_0)
	{
		return P_0.GetAllAssetNames();
	}

	static string[] _206D_202A_200D_200C_200D_202A_202D_202B_206B_202C_202D_206F_206C_206E_202C_202D_202C_206A_200D_206D_206F_200F_202A_202E_206C_200F_202B_202D_202A_206C_206F_200C_202B_200B_202D_202A_200B_206D_206E_206F_202E(AssetBundle P_0)
	{
		return P_0.GetAllScenePaths();
	}
}
