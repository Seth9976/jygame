using System;
using LuaInterface;
using UnityEngine;

public class ObjectWrap
{
	private static Type classType = _206B_206B_202E_202B_206C_202A_206F_202A_206C_206A_202A_202A_206A_200F_200C_206E_202E_202E_206D_206E_202E_202D_206B_202D_206D_200C_200C_202A_206B_200F_202E_206D_200B_200F_206D_202E_206D_206A_206B_202C_202E(typeof(Object).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[15]
		{
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1327854493u), FindObjectsOfType),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2415718534u), DontDestroyOnLoad),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4146417739u), ToString),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4185348841u), Equals),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1396544371u), GetHashCode),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2150753471u), GetInstanceID),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3471059461u), Instantiate),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(508672135u), FindObjectOfType),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2694034405u), DestroyObject),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1402366993u), DestroyImmediate),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3521165592u), Destroy),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2904731379u), _206B_200D_206C_202B_202A_202C_202B_200B_202E_202E_202D_200C_202B_200D_202E_206E_202B_200F_202E_206A_202D_202E_200B_202E_206B_206C_202D_206E_200E_206E_202D_202C_206C_202D_200E_206B_202C_200E_202B_206B_202E),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2567984228u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1455900705u), Lua_ToString),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2206010212u), Lua_Eq)
		};
		LuaField[] fields = default(LuaField[]);
		while (true)
		{
			int num = 1589992909;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x41C08F87)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					fields = new LuaField[2]
					{
						new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1560628044u), get_name, set_name),
						new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3976516319u), get_hideFlags, set_hideFlags)
					};
					num = ((int)num2 * -281396078) ^ -637104520;
					continue;
				case 3u:
					LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3299138118u), _206B_206B_202E_202B_206C_202A_206F_202A_206C_206A_202A_202A_206A_200F_200C_206E_202E_202E_206D_206E_202E_202D_206B_202D_206D_200C_200C_202A_206B_200F_202E_206D_200B_200F_206D_202E_206D_206A_206B_202C_202E(typeof(Object).TypeHandle), regs, fields, _206B_206B_202E_202B_206C_202A_206F_202A_206C_206A_202A_202A_206A_200F_200C_206E_202E_202E_206D_206E_202E_202D_206B_202D_206D_200C_200C_202A_206B_200F_202E_206D_200B_200F_206D_202E_206D_206A_206B_202C_202E(typeof(object).TypeHandle));
					num = (int)(num2 * 294805286) ^ -594838284;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _206B_200D_206C_202B_202A_202C_202B_200B_202E_202E_202D_200C_202B_200D_202E_206E_202B_200F_202E_206A_202D_202E_200B_202E_206B_206C_202D_206E_200E_206E_202D_202C_206C_202D_200E_206B_202C_200E_202B_206B_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		Object obj = default(Object);
		while (true)
		{
			int num2 = -1567427585;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -526080188)) % 6)
				{
				case 0u:
					break;
				case 1u:
				{
					int num4;
					int num5;
					if (num != 0)
					{
						num4 = 604375438;
						num5 = num4;
					}
					else
					{
						num4 = 1010398396;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -117672393);
					continue;
				}
				case 5u:
					obj = _202A_200C_206E_206F_206E_200C_200D_202D_200F_200C_202A_200C_200E_202E_200D_206C_202B_202A_202A_200D_200D_200C_206F_206A_202D_202E_206B_202B_206D_200F_206C_206C_206C_206D_200F_202B_206A_200D_206D_202A_202E();
					num2 = (int)((num3 * 1462376187) ^ 0xE528A19);
					continue;
				case 2u:
					LuaScriptMgr.Push(P_0, obj);
					return 1;
				case 3u:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1310690058u));
					num2 = -400558260;
					continue;
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
	private static int get_name(IntPtr L)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Object val = default(Object);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1676735398;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2123019228)) % 9)
				{
				case 6u:
					break;
				case 5u:
				{
					val = (Object)luaObject;
					int num5;
					int num6;
					if (!_200D_202D_200B_200F_200B_200F_206D_200C_200B_200D_200C_206C_202C_206B_200B_206B_202C_200D_200E_200C_206D_200B_202E_202D_200D_202D_206D_200B_200B_200E_200C_202C_200E_206C_200B_202B_202E_202C_200F_200D_202E(val, (Object)null))
					{
						num5 = 603371598;
						num6 = num5;
					}
					else
					{
						num5 = 1158214031;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2066924030);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(702362092u));
					num = (int)((num2 * 1308813069) ^ 0x35BEDD6E);
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2209538024u));
					num = -1351597238;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1319361006;
						num4 = num3;
					}
					else
					{
						num3 = 2063745097;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1354428259);
					continue;
				}
				case 1u:
					num = ((int)num2 * -1411614111) ^ 0x60A35360;
					continue;
				case 8u:
					LuaScriptMgr.Push(L, _200D_200C_206B_206E_206A_206D_202D_206F_200B_202B_206A_202B_200E_200D_200E_206A_206F_202D_206D_206C_200B_202E_206A_200F_200D_202E_202C_206B_202C_200F_202A_202C_202C_206F_206F_206C_202D_202B_206D_202E_202E(val));
					num = -1092284205;
					continue;
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 818188206) ^ 0xBEB18D8);
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_hideFlags(IntPtr L)
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Object val = default(Object);
		while (true)
		{
			int num = -522019628;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1934222016)) % 9)
				{
				case 6u:
					break;
				case 3u:
					num = ((int)num2 * -313165166) ^ -2062856133;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1869403801u));
					num = (int)((num2 * 1008128735) ^ 0x751CB712);
					continue;
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1369572169) ^ 0x10EA8CCF;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (!_200D_202D_200B_200F_200B_200F_206D_200C_200B_200D_200C_206C_202C_206B_200B_206B_202C_200D_200E_200C_206D_200B_202E_202D_200D_202D_206D_200B_200B_200E_200C_202C_200E_206C_200B_202B_202E_202C_200F_200D_202E(val, (Object)null))
					{
						num5 = 649172987;
						num6 = num5;
					}
					else
					{
						num5 = 457090811;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 95060219);
					continue;
				}
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2503461990u));
					num = -2092101435;
					continue;
				case 1u:
					val = (Object)luaObject;
					num = (int)(num2 * 776421491) ^ -2143193754;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 475998803;
						num4 = num3;
					}
					else
					{
						num3 = 1921062548;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -845996710);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, (Enum)(object)_206B_206A_200E_206E_202E_206F_202C_202B_200D_200E_206B_206E_206C_200C_200B_206D_206F_206B_206D_206B_202B_202C_200B_206F_200F_200C_202A_202E_202E_206F_202B_206D_206D_200E_206F_202C_202A_202B_202B_202A_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_name(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Object val = (Object)luaObject;
		while (true)
		{
			int num = 320858897;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x38535D42)) % 7)
				{
				case 6u:
					break;
				case 5u:
				{
					int num5;
					int num6;
					if (!_200D_202D_200B_200F_200B_200F_206D_200C_200B_200D_200C_206C_202C_206B_200B_206B_202C_200D_200E_200C_206D_200B_202E_202D_200D_202D_206D_200B_200B_200E_200C_202C_200E_206C_200B_202B_202E_202C_200F_200D_202E(val, (Object)null))
					{
						num5 = -1038313473;
						num6 = num5;
					}
					else
					{
						num5 = -1780285866;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 307380711);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1188501119u));
					num = (int)((num2 * 838862096) ^ 0x3B2979EA);
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3090282989u));
					num = 184877082;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 256511595;
						num4 = num3;
					}
					else
					{
						num3 = 1218236826;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -138668121);
					continue;
				}
				case 4u:
					_206A_200E_206B_202C_202C_206A_200E_202B_202A_202B_200F_200B_202D_200F_202B_200B_202C_202B_200D_202D_206C_206D_202D_202E_200D_200B_200E_200D_206B_200B_200D_200B_206F_202C_202D_200C_200E_206B_200E_206C_202E(val, LuaScriptMgr.GetString(L, 3));
					num = 1439591850;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_hideFlags(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Object val = default(Object);
		while (true)
		{
			int num = 1170456872;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6321BD2A)) % 7)
				{
				case 0u:
					break;
				case 1u:
					val = (Object)luaObject;
					num = ((int)num2 * -1520688803) ^ 0x4045FAB7;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2816821910u));
					num = (int)((num2 * 1759752573) ^ 0x39D89492);
					continue;
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1642166203;
						num6 = num5;
					}
					else
					{
						num5 = 748111286;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -913993522);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (!_200D_202D_200B_200F_200B_200F_206D_200C_200B_200D_200C_206C_202C_206B_200B_206B_202C_200D_200E_200C_206D_200B_202E_202D_200D_202D_206D_200B_200B_200E_200C_202C_200E_206C_200B_202B_202E_202C_200F_200D_202E(val, (Object)null))
					{
						num3 = -427250287;
						num4 = num3;
					}
					else
					{
						num3 = -1210154277;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1269980928);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2942356423u));
					num = 671863953;
					continue;
				default:
					_200C_200F_200E_206D_202D_202B_202E_206C_202B_202C_202A_202A_202A_202E_202B_202E_202E_202D_206B_206B_202D_202E_206E_202A_200C_200F_202A_200D_202E_202C_200C_200F_200B_206E_200B_202A_206E_202C_202B_200C_202E(val, (HideFlags)(int)LuaScriptMgr.GetNetObject(L, 3, _206B_206B_202E_202B_206C_202A_206F_202A_206C_206A_202A_202A_206A_200F_200C_206E_202E_202E_206D_206E_202E_202D_206B_202D_206D_200C_200C_202A_206B_200F_202E_206D_200B_200F_206D_202E_206D_206A_206B_202C_202E(typeof(HideFlags).TypeHandle)));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Lua_ToString(IntPtr L)
	{
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		while (true)
		{
			int num = 1901464475;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x59B16DA)) % 6)
				{
				case 4u:
					break;
				case 5u:
					num = ((int)num2 * -1983867518) ^ -6644037;
					continue;
				case 2u:
					LuaScriptMgr.Push(L, _206A_206D_200B_202A_200B_202E_206E_202A_200C_200D_206C_206C_200D_202C_206B_202A_200C_200D_200C_206B_202C_200F_202D_206B_206C_206C_200E_200D_202D_202C_206A_200D_206D_200F_206E_202A_202E_206E_202A_202E_202E(luaObject));
					num = ((int)num2 * -1764808891) ^ -1528124891;
					continue;
				case 0u:
					LuaScriptMgr.Push(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4111597851u));
					num = 611547425;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (luaObject != null)
					{
						num3 = -23643700;
						num4 = num3;
					}
					else
					{
						num3 = -2130417958;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1319137956);
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int FindObjectsOfType(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Type typeObject = LuaScriptMgr.GetTypeObject(L, 1);
		Object[] o = _202E_200B_200F_202A_200D_200D_206A_202C_200C_206B_206D_206C_200D_206F_200C_202D_206D_200B_200F_206A_200F_206C_206D_202C_202E_206E_200F_200E_200D_202C_206D_206E_202B_202E_206D_202B_206A_202D_200D_200C_202E(typeObject);
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int DontDestroyOnLoad(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Object unityObject = LuaScriptMgr.GetUnityObject(L, 1, _206B_206B_202E_202B_206C_202A_206F_202A_206C_206A_202A_202A_206A_200F_200C_206E_202E_202E_206D_206E_202E_202D_206B_202D_206D_200C_200C_202A_206B_200F_202E_206D_200B_200F_206D_202E_206D_206A_206B_202C_202E(typeof(Object).TypeHandle));
		_206A_206B_206E_206E_206D_206B_202B_200F_202B_200F_200D_206A_206B_206D_202D_200D_206F_206C_202D_202C_202B_206E_206B_206F_202C_206E_202B_200D_200F_200F_202B_206B_202E_206C_206A_206F_206F_200C_202C_200F_202E(unityObject);
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int ToString(IntPtr L)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		while (true)
		{
			int num = 1971007778;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5D394314)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0029;
				default:
					return 1;
				}
				break;
				IL_0029:
				Object val = (Object)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(583430162u));
				string str = _202A_206A_206E_200C_206A_206D_200F_206E_202A_206B_202D_200D_200E_200F_206D_206A_202B_200B_200B_202C_206C_206E_200E_202A_206C_206B_202B_206B_202D_200C_206B_206B_206F_200C_200B_200C_206A_202B_200C_202D_202E(val);
				LuaScriptMgr.Push(L, str);
				num = ((int)num2 * -264109123) ^ -1832291054;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Equals(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		object varObject = LuaScriptMgr.GetVarObject(L, 1);
		Object val = (Object)((varObject is Object) ? varObject : null);
		object varObject2 = default(object);
		bool b = default(bool);
		while (true)
		{
			int num = -528978998;
			while (true)
			{
				uint num2;
				bool num3;
				switch ((num2 = (uint)(num ^ -2140966913)) % 6)
				{
				case 4u:
					break;
				case 3u:
					varObject2 = LuaScriptMgr.GetVarObject(L, 2);
					num = ((int)num2 * -1661296241) ^ -1162614174;
					continue;
				case 1u:
					num3 = _202D_202E_206C_206A_202D_200B_206F_202A_202A_202D_202C_202D_202E_200C_206F_206A_206B_206F_206D_202A_202B_202D_202E_200E_206D_206A_206F_206A_200B_200C_200E_202B_206E_206D_206D_206F_200F_202C_206A_200F_202E(val, varObject2);
					goto IL_0066;
				case 2u:
					if (!_200B_206E_206F_202C_202B_206E_206C_202A_202D_202B_206A_202E_202E_200C_206B_200B_206F_202B_206F_202B_206E_206D_202B_202D_202D_200B_202C_202A_206F_200B_202E_200F_200D_202D_206A_202C_200D_200E_206B_206B_202E(val, (Object)null))
					{
						num3 = varObject2 == null;
						goto IL_0066;
					}
					num = (int)((num2 * 1984183019) ^ 0x244DFB92);
					continue;
				case 5u:
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -382958388) ^ 0x496BA1CD;
					continue;
				default:
					{
						return 1;
					}
					IL_0066:
					b = num3;
					num = -155630290;
					continue;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetHashCode(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		Object val = default(Object);
		int d = default(int);
		while (true)
		{
			int num = -1670381046;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1812088380)) % 5)
				{
				case 2u:
					break;
				case 4u:
					val = (Object)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(583430162u));
					num = (int)((num2 * 907231939) ^ 0x51DF12E7);
					continue;
				case 0u:
					LuaScriptMgr.Push(L, d);
					num = ((int)num2 * -2020450111) ^ -213809065;
					continue;
				case 3u:
					d = _202A_200F_202B_200C_200D_200F_202D_202E_206A_202D_202E_202A_206E_206E_206E_200D_202C_206B_202E_202C_206C_202D_202A_202A_202D_200D_206B_202A_206F_202A_206C_202E_206B_206F_206B_200E_200E_202E_200B_206F_202E(val);
					num = ((int)num2 * -1834842743) ^ 0x45AC5027;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetInstanceID(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		int d = default(int);
		while (true)
		{
			int num = 1239477078;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xC9B638D)) % 4)
				{
				case 2u:
					break;
				case 3u:
				{
					Object val = (Object)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3933378541u));
					d = _202D_206B_200B_200C_202C_206B_202C_202C_206B_206C_200E_206C_202E_200C_202D_200B_202C_202C_206C_202D_202E_206C_200F_206D_202C_202D_206A_206B_200F_202A_206C_200E_206E_200B_206B_200B_206D_206A_200D_206C_202E(val);
					num = (int)((num2 * 1685814611) ^ 0x18546068);
					continue;
				}
				case 0u:
					LuaScriptMgr.Push(L, d);
					num = ((int)num2 * -1294704342) ^ -54382004;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Instantiate(IntPtr L)
	{
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		int num = LuaDLL.lua_gettop(L);
		if (num == 1)
		{
			goto IL_000e;
		}
		goto IL_0093;
		IL_000e:
		int num2 = 1819054055;
		goto IL_0013;
		IL_0013:
		Object unityObject = default(Object);
		Object obj2 = default(Object);
		Object unityObject2 = default(Object);
		Vector3 vector = default(Vector3);
		Quaternion quaternion = default(Quaternion);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0xB27C6B9)) % 11)
			{
			case 10u:
				break;
			case 7u:
				unityObject = LuaScriptMgr.GetUnityObject(L, 1, _206B_206B_202E_202B_206C_202A_206F_202A_206C_206A_202A_202A_206A_200F_200C_206E_202E_202E_206D_206E_202E_202D_206B_202D_206D_200C_200C_202A_206B_200F_202E_206D_200B_200F_206D_202E_206D_206A_206B_202C_202E(typeof(Object).TypeHandle));
				num2 = ((int)num3 * -1953414955) ^ 0x12D2646A;
				continue;
			case 9u:
				obj2 = _202C_202C_200F_206D_206C_202E_200C_202E_200B_200B_200E_202E_200F_202D_200B_202E_202B_202D_200F_200E_206A_206C_200D_206A_206A_202E_206E_206A_206B_200C_202C_202C_206C_206F_206A_202C_202C_202E_200F_206C_202E(unityObject2, vector, quaternion);
				num2 = ((int)num3 * -553195328) ^ 0x3504F960;
				continue;
			case 5u:
				goto IL_0093;
			case 8u:
				LuaScriptMgr.Push(L, obj2);
				return 1;
			case 6u:
				unityObject2 = LuaScriptMgr.GetUnityObject(L, 1, _206B_206B_202E_202B_206C_202A_206F_202A_206C_206A_202A_202A_206A_200F_200C_206E_202E_202E_206D_206E_202E_202D_206B_202D_206D_200C_200C_202A_206B_200F_202E_206D_200B_200F_206D_202E_206D_206A_206B_202C_202E(typeof(Object).TypeHandle));
				num2 = (int)((num3 * 224570148) ^ 0xAFCF7DD);
				continue;
			case 3u:
			{
				Object obj = _202D_200C_200F_202A_202B_202E_200D_202E_200E_206E_206E_206D_202A_206F_206D_200E_200D_202C_202C_202C_202E_206D_206F_200D_200C_206D_206D_200E_206C_200C_202C_200E_206D_200B_200E_206A_200F_202B_202E_200F_202E(unityObject);
				LuaScriptMgr.Push(L, obj);
				return 1;
			}
			case 4u:
				vector = LuaScriptMgr.GetVector3(L, 2);
				num2 = ((int)num3 * -1140036987) ^ -1680003946;
				continue;
			case 1u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2979673555u));
				num2 = 455617749;
				continue;
			case 0u:
				quaternion = LuaScriptMgr.GetQuaternion(L, 3);
				num2 = ((int)num3 * -2263669) ^ -1851721356;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_0093:
		int num4;
		if (num != 3)
		{
			num2 = 2048664195;
			num4 = num2;
		}
		else
		{
			num2 = 1423620314;
			num4 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int FindObjectOfType(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		Type typeObject = default(Type);
		while (true)
		{
			int num = 614832896;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x731A2A33)) % 4)
				{
				case 0u:
					break;
				case 3u:
					typeObject = LuaScriptMgr.GetTypeObject(L, 1);
					num = ((int)num2 * -1763972994) ^ 0xAB762D3;
					continue;
				case 2u:
				{
					Object obj = _202E_206E_200C_206C_200C_206C_206B_202A_202E_200F_200C_206A_200D_206F_200F_202B_202D_206F_206E_200D_200F_202D_200D_206C_202A_200F_206C_202C_206C_206B_202D_202B_202B_200E_202A_206E_206E_202E_202B_206C_202E(typeObject);
					LuaScriptMgr.Push(L, obj);
					num = ((int)num2 * -541101924) ^ 0x7BDEA4EA;
					continue;
				}
				default:
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
		object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
		Object val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
		bool b = _200D_202D_200B_200F_200B_200F_206D_200C_200B_200D_200C_206C_202C_206B_200B_206B_202C_200D_200E_200C_206D_200B_202E_202D_200D_202D_206D_200B_200B_200E_200C_202C_200E_206C_200B_202B_202E_202C_200F_200D_202E(val, val2);
		LuaScriptMgr.Push(L, b);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int DestroyObject(IntPtr L)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		Object val2 = default(Object);
		float num6 = default(float);
		Object val = default(Object);
		while (true)
		{
			int num2 = 2048512129;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x14BE6992)) % 10)
				{
				case 2u:
					break;
				case 9u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1106453874u));
					num2 = 1105634438;
					continue;
				case 5u:
					val2 = (Object)LuaScriptMgr.GetLuaObject(L, 1);
					num6 = (float)LuaScriptMgr.GetNumber(L, 2);
					num2 = (int)(num3 * 344028877) ^ -1504169505;
					continue;
				case 3u:
					return 0;
				case 0u:
					_200C_202B_206F_200E_202A_200F_206F_206F_206B_206A_206A_200D_202E_202E_200D_206B_206C_200F_206F_202B_206A_200E_206A_206D_202C_200F_206D_206F_202D_206D_200C_202A_206F_202E_206F_206F_206F_202A_200F_206F_202E(val2, num6);
					num2 = (int)(num3 * 1769709679) ^ -748292299;
					continue;
				case 6u:
					val = (Object)LuaScriptMgr.GetLuaObject(L, 1);
					num2 = (int)(num3 * 1473788899) ^ -1746325415;
					continue;
				case 4u:
				{
					int num7;
					if (num == 2)
					{
						num2 = 2113937061;
						num7 = num2;
					}
					else
					{
						num2 = 247179469;
						num7 = num2;
					}
					continue;
				}
				case 1u:
				{
					int num4;
					int num5;
					if (num != 1)
					{
						num4 = -1034745532;
						num5 = num4;
					}
					else
					{
						num4 = -1611779990;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 1848506980);
					continue;
				}
				case 7u:
					LuaScriptMgr.__gc(L);
					_206E_202B_206D_200F_206D_200F_202A_200B_202D_200F_200D_202A_202A_206A_202B_206E_200B_206B_206F_202A_206D_206F_206C_200D_200D_206C_200C_202A_202C_206F_206D_206C_202C_206F_200B_206B_200F_200B_206E_202A_202E(val);
					return 0;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int DestroyImmediate(IntPtr L)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 1)
		{
			goto IL_000b;
		}
		goto IL_0065;
		IL_000b:
		int num2 = 304176549;
		goto IL_0010;
		IL_0010:
		Object val2 = default(Object);
		Object val = default(Object);
		bool boolean = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0xC2A0DC)) % 10)
			{
			case 2u:
				break;
			case 1u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1116185691u));
				num2 = 1790628630;
				continue;
			case 4u:
				goto IL_0065;
			case 5u:
				_202E_206E_200D_202A_206F_206B_200D_200C_202D_202C_206E_200D_206D_206C_202D_206D_200C_202D_202E_200E_200B_202C_200E_206C_200F_202C_202D_206A_202E_202D_202B_202A_202C_206E_200E_200E_206E_200D_202B_200E_202E(val2);
				return 0;
			case 0u:
				return 0;
			case 9u:
				val2 = (Object)LuaScriptMgr.GetLuaObject(L, 1);
				num2 = ((int)num3 * -1875595581) ^ -1469457607;
				continue;
			case 6u:
				LuaScriptMgr.__gc(L);
				num2 = ((int)num3 * -689870643) ^ -816116855;
				continue;
			case 7u:
				_200C_200E_202C_200D_200B_206D_202E_206D_202E_206B_202D_200D_206A_206F_202C_200E_200E_202C_202C_202D_206B_202D_200E_202B_202C_202E_202D_206C_200D_206D_200F_202E_200B_200D_206A_206D_202D_200B_206F_200E_202E(val, boolean);
				num2 = ((int)num3 * -1933740215) ^ -1644979947;
				continue;
			case 3u:
				val = (Object)LuaScriptMgr.GetLuaObject(L, 1);
				boolean = LuaScriptMgr.GetBoolean(L, 2);
				num2 = (int)((num3 * 1739151750) ^ 0x3107947B);
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_000b;
		IL_0065:
		int num4;
		if (num == 2)
		{
			num2 = 1147568319;
			num4 = num2;
		}
		else
		{
			num2 = 562480067;
			num4 = num2;
		}
		goto IL_0010;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Destroy(IntPtr L)
	{
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		Object val2 = default(Object);
		float num5 = default(float);
		Object val = default(Object);
		while (true)
		{
			int num2 = 169555983;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x244F1E6A)) % 11)
				{
				case 3u:
					break;
				case 2u:
				{
					int num6;
					int num7;
					if (num == 1)
					{
						num6 = 374786388;
						num7 = num6;
					}
					else
					{
						num6 = 1520345831;
						num7 = num6;
					}
					num2 = num6 ^ ((int)num3 * -1471361121);
					continue;
				}
				case 8u:
					_202D_206B_206E_200D_202C_200C_200D_200E_202D_206F_200C_206A_206D_202B_202C_200B_200E_206C_206B_200E_202B_206E_206E_202B_202B_200B_202B_200E_202B_202D_200E_206D_206A_206B_206B_200F_202E_206B_202A_202E_202E(val2, num5);
					num2 = (int)(num3 * 1508828872) ^ -217564877;
					continue;
				case 10u:
					val2 = (Object)LuaScriptMgr.GetLuaObject(L, 1);
					num5 = (float)LuaScriptMgr.GetNumber(L, 2);
					num2 = ((int)num3 * -1265045428) ^ 0x2DFD17DE;
					continue;
				case 0u:
					return 0;
				case 4u:
					LuaScriptMgr.__gc(L);
					num2 = ((int)num3 * -57222325) ^ 0x65006B96;
					continue;
				case 6u:
				{
					int num4;
					if (num != 2)
					{
						num2 = 1078075678;
						num4 = num2;
					}
					else
					{
						num2 = 1572033654;
						num4 = num2;
					}
					continue;
				}
				case 7u:
					return 0;
				case 5u:
					_202A_206C_200C_206A_206B_200F_206B_202B_202B_206F_200C_202D_202C_202C_200D_202C_206C_206B_206A_206A_206A_206F_202A_200B_202D_206B_202B_202E_200D_206F_206B_206C_206F_206C_206A_202B_206F_200E_200C_200D_202E(val);
					num2 = (int)(num3 * 375159702) ^ -1376309287;
					continue;
				case 1u:
					val = (Object)LuaScriptMgr.GetLuaObject(L, 1);
					num2 = (int)((num3 * 1857461184) ^ 0x1B0CAE5C);
					continue;
				default:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4139788721u));
					return 0;
				}
				break;
			}
		}
	}

	static Type _206B_206B_202E_202B_206C_202A_206F_202A_206C_206A_202A_202A_206A_200F_200C_206E_202E_202E_206D_206E_202E_202D_206B_202D_206D_200C_200C_202A_206B_200F_202E_206D_200B_200F_206D_202E_206D_206A_206B_202C_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static Object _202A_200C_206E_206F_206E_200C_200D_202D_200F_200C_202A_200C_200E_202E_200D_206C_202B_202A_202A_200D_200D_200C_206F_206A_202D_202E_206B_202B_206D_200F_206C_206C_206C_206D_200F_202B_206A_200D_206D_202A_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Object();
	}

	static bool _200D_202D_200B_200F_200B_200F_206D_200C_200B_200D_200C_206C_202C_206B_200B_206B_202C_200D_200E_200C_206D_200B_202E_202D_200D_202D_206D_200B_200B_200E_200C_202C_200E_206C_200B_202B_202E_202C_200F_200D_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static string _200D_200C_206B_206E_206A_206D_202D_206F_200B_202B_206A_202B_200E_200D_200E_206A_206F_202D_206D_206C_200B_202E_206A_200F_200D_202E_202C_206B_202C_200F_202A_202C_202C_206F_206F_206C_202D_202B_206D_202E_202E(Object P_0)
	{
		return P_0.name;
	}

	static HideFlags _206B_206A_200E_206E_202E_206F_202C_202B_200D_200E_206B_206E_206C_200C_200B_206D_206F_206B_206D_206B_202B_202C_200B_206F_200F_200C_202A_202E_202E_206F_202B_206D_206D_200E_206F_202C_202A_202B_202B_202A_202E(Object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.hideFlags;
	}

	static void _206A_200E_206B_202C_202C_206A_200E_202B_202A_202B_200F_200B_202D_200F_202B_200B_202C_202B_200D_202D_206C_206D_202D_202E_200D_200B_200E_200D_206B_200B_200D_200B_206F_202C_202D_200C_200E_206B_200E_206C_202E(Object P_0, string P_1)
	{
		P_0.name = P_1;
	}

	static void _200C_200F_200E_206D_202D_202B_202E_206C_202B_202C_202A_202A_202A_202E_202B_202E_202E_202D_206B_206B_202D_202E_206E_202A_200C_200F_202A_200D_202E_202C_200C_200F_200B_206E_200B_202A_206E_202C_202B_200C_202E(Object P_0, HideFlags P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.hideFlags = P_1;
	}

	static string _206A_206D_200B_202A_200B_202E_206E_202A_200C_200D_206C_206C_200D_202C_206B_202A_200C_200D_200C_206B_202C_200F_202D_206B_206C_206C_200E_200D_202D_202C_206A_200D_206D_200F_206E_202A_202E_206E_202A_202E_202E(object P_0)
	{
		return P_0.ToString();
	}

	static Object[] _202E_200B_200F_202A_200D_200D_206A_202C_200C_206B_206D_206C_200D_206F_200C_202D_206D_200B_200F_206A_200F_206C_206D_202C_202E_206E_200F_200E_200D_202C_206D_206E_202B_202E_206D_202B_206A_202D_200D_200C_202E(Type P_0)
	{
		return Object.FindObjectsOfType(P_0);
	}

	static void _206A_206B_206E_206E_206D_206B_202B_200F_202B_200F_200D_206A_206B_206D_202D_200D_206F_206C_202D_202C_202B_206E_206B_206F_202C_206E_202B_200D_200F_200F_202B_206B_202E_206C_206A_206F_206F_200C_202C_200F_202E(Object P_0)
	{
		Object.DontDestroyOnLoad(P_0);
	}

	static string _202A_206A_206E_200C_206A_206D_200F_206E_202A_206B_202D_200D_200E_200F_206D_206A_202B_200B_200B_202C_206C_206E_200E_202A_206C_206B_202B_206B_202D_200C_206B_206B_206F_200C_200B_200C_206A_202B_200C_202D_202E(Object P_0)
	{
		return P_0.ToString();
	}

	static bool _200B_206E_206F_202C_202B_206E_206C_202A_202D_202B_206A_202E_202E_200C_206B_200B_206F_202B_206F_202B_206E_206D_202B_202D_202D_200B_202C_202A_206F_200B_202E_200F_200D_202D_206A_202C_200D_200E_206B_206B_202E(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static bool _202D_202E_206C_206A_202D_200B_206F_202A_202A_202D_202C_202D_202E_200C_206F_206A_206B_206F_206D_202A_202B_202D_202E_200E_206D_206A_206F_206A_200B_200C_200E_202B_206E_206D_206D_206F_200F_202C_206A_200F_202E(Object P_0, object P_1)
	{
		return P_0.Equals(P_1);
	}

	static int _202A_200F_202B_200C_200D_200F_202D_202E_206A_202D_202E_202A_206E_206E_206E_200D_202C_206B_202E_202C_206C_202D_202A_202A_202D_200D_206B_202A_206F_202A_206C_202E_206B_206F_206B_200E_200E_202E_200B_206F_202E(Object P_0)
	{
		return P_0.GetHashCode();
	}

	static int _202D_206B_200B_200C_202C_206B_202C_202C_206B_206C_200E_206C_202E_200C_202D_200B_202C_202C_206C_202D_202E_206C_200F_206D_202C_202D_206A_206B_200F_202A_206C_200E_206E_200B_206B_200B_206D_206A_200D_206C_202E(Object P_0)
	{
		return P_0.GetInstanceID();
	}

	static Object _202D_200C_200F_202A_202B_202E_200D_202E_200E_206E_206E_206D_202A_206F_206D_200E_200D_202C_202C_202C_202E_206D_206F_200D_200C_206D_206D_200E_206C_200C_202C_200E_206D_200B_200E_206A_200F_202B_202E_200F_202E(Object P_0)
	{
		return Object.Instantiate(P_0);
	}

	static Object _202C_202C_200F_206D_206C_202E_200C_202E_200B_200B_200E_202E_200F_202D_200B_202E_202B_202D_200F_200E_206A_206C_200D_206A_206A_202E_206E_206A_206B_200C_202C_202C_206C_206F_206A_202C_202C_202E_200F_206C_202E(Object P_0, Vector3 P_1, Quaternion P_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return Object.Instantiate(P_0, P_1, P_2);
	}

	static Object _202E_206E_200C_206C_200C_206C_206B_202A_202E_200F_200C_206A_200D_206F_200F_202B_202D_206F_206E_200D_200F_202D_200D_206C_202A_200F_206C_202C_206C_206B_202D_202B_202B_200E_202A_206E_206E_202E_202B_206C_202E(Type P_0)
	{
		return Object.FindObjectOfType(P_0);
	}

	static void _206E_202B_206D_200F_206D_200F_202A_200B_202D_200F_200D_202A_202A_206A_202B_206E_200B_206B_206F_202A_206D_206F_206C_200D_200D_206C_200C_202A_202C_206F_206D_206C_202C_206F_200B_206B_200F_200B_206E_202A_202E(Object P_0)
	{
		Object.DestroyObject(P_0);
	}

	static void _200C_202B_206F_200E_202A_200F_206F_206F_206B_206A_206A_200D_202E_202E_200D_206B_206C_200F_206F_202B_206A_200E_206A_206D_202C_200F_206D_206F_202D_206D_200C_202A_206F_202E_206F_206F_206F_202A_200F_206F_202E(Object P_0, float P_1)
	{
		Object.DestroyObject(P_0, P_1);
	}

	static void _202E_206E_200D_202A_206F_206B_200D_200C_202D_202C_206E_200D_206D_206C_202D_206D_200C_202D_202E_200E_200B_202C_200E_206C_200F_202C_202D_206A_202E_202D_202B_202A_202C_206E_200E_200E_206E_200D_202B_200E_202E(Object P_0)
	{
		Object.DestroyImmediate(P_0);
	}

	static void _200C_200E_202C_200D_200B_206D_202E_206D_202E_206B_202D_200D_206A_206F_202C_200E_200E_202C_202C_202D_206B_202D_200E_202B_202C_202E_202D_206C_200D_206D_200F_202E_200B_200D_206A_206D_202D_200B_206F_200E_202E(Object P_0, bool P_1)
	{
		Object.DestroyImmediate(P_0, P_1);
	}

	static void _202A_206C_200C_206A_206B_200F_206B_202B_202B_206F_200C_202D_202C_202C_200D_202C_206C_206B_206A_206A_206A_206F_202A_200B_202D_206B_202B_202E_200D_206F_206B_206C_206F_206C_206A_202B_206F_200E_200C_200D_202E(Object P_0)
	{
		Object.Destroy(P_0);
	}

	static void _202D_206B_206E_200D_202C_200C_200D_200E_202D_206F_200C_206A_206D_202B_202C_200B_200E_206C_206B_200E_202B_206E_206E_202B_202B_200B_202B_200E_202B_202D_200E_206D_206A_206B_206B_200F_202E_206B_202A_202E_202E(Object P_0, float P_1)
	{
		Object.Destroy(P_0, P_1);
	}
}
