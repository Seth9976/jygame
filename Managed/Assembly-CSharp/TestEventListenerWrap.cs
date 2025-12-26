using System;
using System.Runtime.CompilerServices;
using LuaInterface;
using UnityEngine;

public class TestEventListenerWrap
{
	[CompilerGenerated]
	private sealed class _206D_202A_202D_202A_206D_206F_206F_206E_206F_206A_202D_200C_206D_200C_202D_206A_200D_202E_206C_200B_202A_206F_206E_202B_206A_202A_206F_200E_200D_202D_206C_206E_202E_206B_206F_202B_200B_200C_200D_200C_202E
	{
		internal IntPtr L;
	}

	[CompilerGenerated]
	private sealed class _200D_202D_206F_206C_200C_202D_206F_206E_202E_206E_200C_200C_200B_200C_206F_200C_206E_206A_206A_206F_206E_206F_202C_206A_200F_200F_200F_202E_200F_200C_206D_202D_206F_200E_202B_200F_202A_202D_202A_200D_202E
	{
		internal LuaFunction func;

		internal _206D_202A_202D_202A_206D_206F_206F_206E_206F_206A_202D_200C_206D_200C_202D_206A_200D_202E_206C_200B_202A_206F_206E_202B_206A_202A_206F_200E_200D_202D_206C_206E_202E_206B_206F_202B_200B_200C_200D_200C_202E _200C_202A_206C_206A_202E_206E_200C_200F_200D_200B_206C_206B_206D_202C_206A_200F_202A_202E_202B_202C_200B_202E_206A_202B_200B_206A_202D_206A_202A_200E_200C_200C_200E_206C_206A_206C_206F_206D_200F_206C_202E;

		internal void _200B_200C_202E_206D_200C_200D_202B_200C_206A_202B_202E_206D_200D_200F_206D_206A_202A_200C_206A_202A_206E_206C_200D_200D_206B_206A_206B_206F_200C_206F_206E_200C_206F_206E_206A_202B_200D_206B_202B_200C_202E(GameObject P_0)
		{
			int oldTop = func.BeginPCall();
			while (true)
			{
				int num = -2076681362;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -2068889501)) % 5)
					{
					case 2u:
						break;
					default:
						return;
					case 4u:
						func.EndPCall(oldTop);
						num = ((int)num2 * -1049766829) ^ -2076801407;
						continue;
					case 3u:
						func.PCall(oldTop, 1);
						num = (int)(num2 * 434332753) ^ -1189774072;
						continue;
					case 1u:
						LuaScriptMgr.Push(_200C_202A_206C_206A_202E_206E_200C_200F_200D_200B_206C_206B_206D_202C_206A_200F_202A_202E_202B_202C_200B_202E_206A_202B_200B_206A_202D_206A_202A_200E_200C_200C_200E_206C_206A_206C_206F_206D_200F_206C_202E.L, (Object)(object)P_0);
						num = (int)((num2 * 1900559407) ^ 0x5F259C5A);
						continue;
					case 0u:
						return;
					}
					break;
				}
			}
		}
	}

	private static Type classType = _206E_202E_206C_206E_202E_200C_202C_206D_202A_206D_200B_206E_206D_200F_200D_206D_200C_200B_202E_206A_200B_200F_200E_200B_202E_206F_202E_200C_206A_200C_206D_206D_202B_202E_200D_206B_206B_200F_202D_200F_202E(typeof(TestEventListener).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[3]
		{
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1657282774u), _202E_206B_206C_202D_206E_200D_200C_202D_202E_200D_202E_206A_202B_206F_202B_202C_202B_200F_202A_202A_202A_206A_202C_206A_202E_206A_206C_202D_202E_202C_206A_200B_206F_206E_206E_202A_206C_202D_200C_202E),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3661446913u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(396454614u), Lua_Eq)
		};
		LuaField[] fields = new LuaField[1]
		{
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3306830390u), get_OnClick, set_OnClick)
		};
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2171757089u), _206E_202E_206C_206E_202E_200C_202C_206D_202A_206D_200B_206E_206D_200F_200D_206D_200C_200B_202E_206A_200B_200F_200E_200B_202E_206F_202E_200C_206A_200C_206D_206D_202B_202E_200D_206B_206B_200F_202D_200F_202E(typeof(TestEventListener).TypeHandle), regs, fields, _206E_202E_206C_206E_202E_200C_202C_206D_202A_206D_200B_206E_206D_200F_200D_206D_200C_200B_202E_206A_200B_200F_200E_200B_202E_206F_202E_200C_206A_200C_206D_206D_202B_202E_200D_206B_206B_200F_202D_200F_202E(typeof(MonoBehaviour).TypeHandle));
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _202E_206B_206C_202D_206E_200D_200C_202D_202E_200D_202E_206A_202B_206F_202B_202C_202B_200F_202A_202A_202A_206A_202C_206A_202E_206A_206C_202D_202E_202C_206A_200B_206F_206E_206E_202A_206C_202D_200C_202E(IntPtr P_0)
	{
		LuaDLL.luaL_error(P_0, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(470026703u));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_OnClick(IntPtr L)
	{
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		TestEventListener testEventListener = default(TestEventListener);
		while (true)
		{
			int num = 535334316;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x697C4B39)) % 6)
				{
				case 3u:
					break;
				case 1u:
				{
					testEventListener = (TestEventListener)luaObject;
					int num5;
					int num6;
					if (_202E_206C_202A_200F_200B_206B_200C_206D_200D_206E_200B_202A_200C_206D_200B_200B_206A_200F_200C_206B_200E_200E_206B_202B_200B_206F_200B_202C_202E_206D_206B_206A_202C_202C_202D_200B_206B_202E_206A_200C_202E((Object)(object)testEventListener, (Object)null))
					{
						num5 = 1830648319;
						num6 = num5;
					}
					else
					{
						num5 = 643943423;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 232564316);
					continue;
				}
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1497977769;
						num4 = num3;
					}
					else
					{
						num3 = -1038872948;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -860869425);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1829869334u));
					num = 1764110451;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(924389739u));
					num = ((int)num2 * -411260871) ^ -527635061;
					continue;
				default:
					LuaScriptMgr.Push(L, (Delegate)testEventListener.OnClick);
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_OnClick(IntPtr L)
	{
		_206D_202A_202D_202A_206D_206F_206F_206E_206F_206A_202D_200C_206D_200C_202D_206A_200D_202E_206C_200B_202A_206F_206E_202B_206A_202A_206F_200E_200D_202D_206C_206E_202E_206B_206F_202B_200B_200C_200D_200C_202E obj = new _206D_202A_202D_202A_206D_206F_206F_206E_206F_206A_202D_200C_206D_200C_202D_206A_200D_202E_206C_200B_202A_206F_206E_202B_206A_202A_206F_200E_200D_202D_206C_206E_202E_206B_206F_202B_200B_200C_200D_200C_202E();
		obj.L = L;
		object luaObject = LuaScriptMgr.GetLuaObject(obj.L, 1);
		TestEventListener testEventListener = (TestEventListener)luaObject;
		if (_202E_206C_202A_200F_200B_206B_200C_206D_200D_206E_200B_202A_200C_206D_200B_200B_206A_200F_200C_206B_200E_200E_206B_202B_200B_206F_200B_202C_202E_206D_206B_206A_202C_202C_202D_200B_206B_202E_206A_200C_202E((Object)(object)testEventListener, (Object)null))
		{
			goto IL_0030;
		}
		goto IL_0151;
		IL_0030:
		int num = -1172048986;
		goto IL_0035;
		IL_0035:
		LuaTypes luaTypes = default(LuaTypes);
		_200D_202D_206F_206C_200C_202D_206F_206E_202E_206E_200C_200C_200B_200C_206F_200C_206E_206A_206A_206F_206E_206F_202C_206A_200F_200F_200F_202E_200F_200C_206D_202D_206F_200E_202B_200F_202A_202D_202A_200D_202E obj2 = default(_200D_202D_206F_206C_200C_202D_206F_206E_202E_206E_200C_200C_200B_200C_206F_200C_206E_206A_206A_206F_206E_206F_202C_206A_200F_200F_200F_202E_200F_200C_206D_202D_206F_200E_202B_200F_202A_202D_202A_200D_202E);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -999683820)) % 12)
			{
			case 4u:
				break;
			case 6u:
				luaTypes = LuaDLL.lua_type(obj.L, 1);
				num = (int)(num2 * 1283890067) ^ -665827355;
				continue;
			case 5u:
				testEventListener.OnClick = (Action<GameObject>)LuaScriptMgr.GetNetObject(obj.L, 3, _206E_202E_206C_206E_202E_200C_202C_206D_202A_206D_200B_206E_206D_200F_200D_206D_200C_200B_202E_206A_200B_200F_200E_200B_202E_206F_202E_200C_206A_200C_206D_206D_202B_202E_200D_206B_206B_200F_202D_200F_202E(typeof(Action<GameObject>).TypeHandle));
				num = ((int)num2 * -167176254) ^ 0x329E6195;
				continue;
			case 8u:
				num = ((int)num2 * -1744306646) ^ 0x70116C11;
				continue;
			case 10u:
				testEventListener.OnClick = obj2._200B_200C_202E_206D_200C_200D_202B_200C_206A_202B_202E_206D_200D_200F_206D_206A_202A_200C_206A_202A_206E_206C_200D_200D_206B_206A_206B_206F_200C_206F_206E_200C_206F_206E_206A_202B_200D_206B_202B_200C_202E;
				num = ((int)num2 * -656614611) ^ -1871341847;
				continue;
			case 11u:
			{
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = 377407582;
					num4 = num3;
				}
				else
				{
					num3 = 743438668;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1751170884);
				continue;
			}
			case 2u:
				LuaDLL.luaL_error(obj.L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1211057089u));
				num = ((int)num2 * -826825037) ^ -1608145574;
				continue;
			case 9u:
				goto IL_0151;
			case 7u:
				num = (int)(num2 * 1174988875) ^ -1332068510;
				continue;
			case 0u:
				LuaDLL.luaL_error(obj.L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2192494899u));
				num = -111751127;
				continue;
			case 1u:
				obj2 = new _200D_202D_206F_206C_200C_202D_206F_206E_202E_206E_200C_200C_200B_200C_206F_200C_206E_206A_206A_206F_206E_206F_202C_206A_200F_200F_200F_202E_200F_200C_206D_202D_206F_200E_202B_200F_202A_202D_202A_200D_202E();
				obj2._200C_202A_206C_206A_202E_206E_200C_200F_200D_200B_206C_206B_206D_202C_206A_200F_202A_202E_202B_202C_200B_202E_206A_202B_200B_206A_202D_206A_202A_200E_200C_200C_200E_206C_206A_206C_206F_206D_200F_206C_202E = obj;
				obj2.func = LuaScriptMgr.ToLuaFunction(obj.L, 3);
				num = -1367387458;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_0030;
		IL_0151:
		LuaTypes luaTypes2 = LuaDLL.lua_type(obj.L, 3);
		int num5;
		if (luaTypes2 == LuaTypes.LUA_TFUNCTION)
		{
			num = -1867246407;
			num5 = num;
		}
		else
		{
			num = -503338055;
			num5 = num;
		}
		goto IL_0035;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		bool b = default(bool);
		Object val = default(Object);
		Object val2 = default(Object);
		while (true)
		{
			int num = -49014304;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1952881282)) % 5)
				{
				case 4u:
					break;
				case 0u:
					LuaScriptMgr.Push(L, b);
					num = (int)((num2 * 72480168) ^ 0x204293F7);
					continue;
				case 2u:
					b = _202E_206C_202A_200F_200B_206B_200C_206D_200D_206E_200B_202A_200C_206D_200B_200B_206A_200F_200C_206B_200E_200E_206B_202B_200B_206F_200B_202C_202E_206D_206B_206A_202C_202C_202D_200B_206B_202E_206A_200C_202E(val, val2);
					num = (int)(num2 * 353976895) ^ -1925206263;
					continue;
				case 1u:
				{
					object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
					val = (Object)((luaObject is Object) ? luaObject : null);
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
					val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
					num = (int)(num2 * 842440299) ^ -21308074;
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _206E_202E_206C_206E_202E_200C_202C_206D_202A_206D_200B_206E_206D_200F_200D_206D_200C_200B_202E_206A_200B_200F_200E_200B_202E_206F_202E_200C_206A_200C_206D_206D_202B_202E_200D_206B_206B_200F_202D_200F_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static bool _202E_206C_202A_200F_200B_206B_200C_206D_200D_206E_200B_202A_200C_206D_200B_200B_206A_200F_200C_206B_200E_200E_206B_202B_200B_206F_200B_202C_202E_206D_206B_206A_202C_202C_202D_200B_206B_202E_206A_200C_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}
}
