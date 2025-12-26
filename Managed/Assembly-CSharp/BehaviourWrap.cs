using System;
using LuaInterface;
using UnityEngine;

public class BehaviourWrap
{
	private static Type classType = _200E_202A_206F_200E_202B_206B_206B_206A_200C_202E_206D_206B_206D_206F_200C_202C_200B_202E_200F_202E_206F_202B_200D_202E_200B_206D_202E_202D_206E_206B_202C_206B_202D_206E_202B_206C_206C_200D_206D_206A_202E(typeof(Behaviour).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[3]
		{
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1657282774u), _206B_206F_206B_206A_206F_202C_200F_206B_206D_206F_200E_206F_202B_200E_200F_206A_200F_206B_200E_202D_206D_202D_200D_200E_200F_202A_206F_206A_206A_202D_202A_202C_206D_202E_200E_202E_202A_200B_202A_206F_202E),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2567984228u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(396454614u), Lua_Eq)
		};
		LuaField[] fields = new LuaField[2]
		{
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2776085456u), get_enabled, set_enabled),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2787808671u), get_isActiveAndEnabled, null)
		};
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1562017789u), _200E_202A_206F_200E_202B_206B_206B_206A_200C_202E_206D_206B_206D_206F_200C_202C_200B_202E_200F_202E_206F_202B_200D_202E_200B_206D_202E_202D_206E_206B_202C_206B_202D_206E_202B_206C_206C_200D_206D_206A_202E(typeof(Behaviour).TypeHandle), regs, fields, _200E_202A_206F_200E_202B_206B_206B_206A_200C_202E_206D_206B_206D_206F_200C_202C_200B_202E_200F_202E_206F_202B_200D_202E_200B_206D_202E_202D_206E_206B_202C_206B_202D_206E_202B_206C_206C_200D_206D_206A_202E(typeof(Component).TypeHandle));
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _206B_206F_206B_206A_206F_202C_200F_206B_206D_206F_200E_206F_202B_200E_200F_206A_200F_206B_200E_202D_206D_202D_200D_200E_200F_202A_206F_206A_206A_202D_202A_202C_206D_202E_200E_202E_202A_200B_202A_206F_202E(IntPtr P_0)
	{
		if (LuaDLL.lua_gettop(P_0) == 0)
		{
			while (true)
			{
				int num = -951751048;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1591386527)) % 4)
					{
					case 3u:
						break;
					case 1u:
					{
						Behaviour obj = _200E_206C_206E_206F_202A_200C_206D_206F_206E_206B_200F_200E_206C_200E_206D_206D_206D_200B_206B_206D_206A_202B_206C_200F_206E_200D_202E_200E_202E_200B_206B_206B_200D_206A_206E_206F_202D_200B_206B_202D_202E();
						LuaScriptMgr.Push(P_0, (Object)(object)obj);
						num = ((int)num2 * -1101171001) ^ 0x7E2A184E;
						continue;
					}
					case 0u:
						return 1;
					default:
						goto end_IL_000a;
					}
					break;
				}
				continue;
				end_IL_000a:
				break;
			}
		}
		LuaDLL.luaL_error(P_0, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2750073178u));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_enabled(IntPtr L)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Behaviour val = default(Behaviour);
		while (true)
		{
			int num = -1486697086;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -565921254)) % 7)
				{
				case 2u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2562779632u));
					num = -877131157;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 736379532;
						num6 = num5;
					}
					else
					{
						num5 = 976223526;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -111133408);
					continue;
				}
				case 6u:
				{
					val = (Behaviour)luaObject;
					int num3;
					int num4;
					if (_200F_206C_200B_200B_206F_200B_206C_202E_202C_202C_200F_200E_206F_200F_200C_202E_206E_202E_202B_200B_202D_202A_200E_206C_202B_206F_202E_202B_206E_202B_206E_206F_206F_200B_206B_206A_202E_206F_206F_202E_202E((Object)(object)val, (Object)null))
					{
						num3 = -286889512;
						num4 = num3;
					}
					else
					{
						num3 = -1728874677;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1466506548);
					continue;
				}
				case 4u:
					num = (int)((num2 * 2084716568) ^ 0x4126ECF3);
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1141766380u));
					num = (int)((num2 * 292643798) ^ 0x8486D43);
					continue;
				default:
					LuaScriptMgr.Push(L, _206A_206D_206C_202C_206D_206A_206C_200E_206A_200B_200B_202D_202C_200C_200B_202D_200C_200B_200C_202D_202E_200F_200C_206E_200B_206B_206D_200F_200F_202B_200D_206B_202E_206C_206F_202D_200B_202D_206B_202B_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_isActiveAndEnabled(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Behaviour val = default(Behaviour);
		while (true)
		{
			int num = -1001469626;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1986156884)) % 8)
				{
				case 5u:
					break;
				case 2u:
				{
					val = (Behaviour)luaObject;
					int num5;
					int num6;
					if (!_200F_206C_200B_200B_206F_200B_206C_202E_202C_202C_200F_200E_206F_200F_200C_202E_206E_202E_202B_200B_202D_202A_200E_206C_202B_206F_202E_202B_206E_202B_206E_206F_206F_200B_206B_206A_202E_206F_206F_202E_202E((Object)(object)val, (Object)null))
					{
						num5 = -1283221574;
						num6 = num5;
					}
					else
					{
						num5 = -1883065337;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 170049393);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3240634587u));
					num = -1469813776;
					continue;
				case 4u:
					LuaScriptMgr.Push(L, _200F_202A_200E_200B_200B_202B_206F_206A_206C_200E_206C_206A_202C_206B_202A_202A_200F_206B_200F_206A_206F_202C_206F_206E_200D_200D_200E_200F_202E_200D_206C_200F_200B_206E_202C_206A_200D_206A_206C_206B_202E(val));
					num = -1042202534;
					continue;
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -449117595;
						num4 = num3;
					}
					else
					{
						num3 = -1901663343;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1390432258);
					continue;
				}
				case 0u:
					num = (int)(num2 * 1559137149) ^ -1162955040;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(304712351u));
					num = ((int)num2 * -1244296412) ^ 0x55D18020;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_enabled(IntPtr L)
	{
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		Behaviour val = default(Behaviour);
		while (true)
		{
			int num = -1869442843;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -278111616)) % 10)
				{
				case 7u:
					break;
				case 6u:
					num = ((int)num2 * -1219152056) ^ -583468900;
					continue;
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2952166024u));
					num = (int)((num2 * 443743217) ^ 0x40B216A8);
					continue;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -2032132798) ^ 0xCA4BEE0;
					continue;
				case 2u:
					_202A_206D_202E_206F_200E_202E_200D_206D_206D_206A_202D_206E_202A_200E_200E_206D_202B_206F_206F_206B_206C_202D_206A_206E_200F_202C_202D_206A_206F_202E_206E_202D_200F_200F_200B_200B_206A_200E_200C_206B_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = -1509102315;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (!_200F_206C_200B_200B_206F_200B_206C_202E_202C_202C_200F_200E_206F_200F_200C_202E_206E_202E_202B_200B_202D_202A_200E_206C_202B_206F_202E_202B_206E_202B_206E_206F_206F_200B_206B_206A_202E_206F_206F_202E_202E((Object)(object)val, (Object)null))
					{
						num5 = 2078051099;
						num6 = num5;
					}
					else
					{
						num5 = 1029492265;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -184525517);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(489604900u));
					num = -846650132;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -173459389;
						num4 = num3;
					}
					else
					{
						num3 = -316089270;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1821992367);
					continue;
				}
				case 9u:
					val = (Behaviour)luaObject;
					num = ((int)num2 * -404338506) ^ 0x2B1B6B63;
					continue;
				default:
					return 0;
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
		bool b = _200F_206C_200B_200B_206F_200B_206C_202E_202C_202C_200F_200E_206F_200F_200C_202E_206E_202E_202B_200B_202D_202A_200E_206C_202B_206F_202E_202B_206E_202B_206E_206F_206F_200B_206B_206A_202E_206F_206F_202E_202E(val, val2);
		LuaScriptMgr.Push(L, b);
		return 1;
	}

	static Type _200E_202A_206F_200E_202B_206B_206B_206A_200C_202E_206D_206B_206D_206F_200C_202C_200B_202E_200F_202E_206F_202B_200D_202E_200B_206D_202E_202D_206E_206B_202C_206B_202D_206E_202B_206C_206C_200D_206D_206A_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static Behaviour _200E_206C_206E_206F_202A_200C_206D_206F_206E_206B_200F_200E_206C_200E_206D_206D_206D_200B_206B_206D_206A_202B_206C_200F_206E_200D_202E_200E_202E_200B_206B_206B_200D_206A_206E_206F_202D_200B_206B_202D_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Behaviour();
	}

	static bool _200F_206C_200B_200B_206F_200B_206C_202E_202C_202C_200F_200E_206F_200F_200C_202E_206E_202E_202B_200B_202D_202A_200E_206C_202B_206F_202E_202B_206E_202B_206E_206F_206F_200B_206B_206A_202E_206F_206F_202E_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static bool _206A_206D_206C_202C_206D_206A_206C_200E_206A_200B_200B_202D_202C_200C_200B_202D_200C_200B_200C_202D_202E_200F_200C_206E_200B_206B_206D_200F_200F_202B_200D_206B_202E_206C_206F_202D_200B_202D_206B_202B_202E(Behaviour P_0)
	{
		return P_0.enabled;
	}

	static bool _200F_202A_200E_200B_200B_202B_206F_206A_206C_200E_206C_206A_202C_206B_202A_202A_200F_206B_200F_206A_206F_202C_206F_206E_200D_200D_200E_200F_202E_200D_206C_200F_200B_206E_202C_206A_200D_206A_206C_206B_202E(Behaviour P_0)
	{
		return P_0.isActiveAndEnabled;
	}

	static void _202A_206D_202E_206F_200E_202E_200D_206D_206D_206A_202D_206E_202A_200E_200E_206D_202B_206F_206F_206B_206C_202D_206A_206E_200F_202C_202D_206A_206F_202E_206E_202D_200F_200F_200B_200B_206A_200E_200C_206B_202E(Behaviour P_0, bool P_1)
	{
		P_0.enabled = P_1;
	}
}
