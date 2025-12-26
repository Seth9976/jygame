using System;
using System.Runtime.CompilerServices;
using LuaInterface;
using UnityEngine;

public class TestLuaDelegateWrap
{
	[CompilerGenerated]
	private sealed class _206D_206C_202E_200C_206A_202C_200C_206C_206F_200B_202E_206B_202C_202E_206E_206B_200E_206E_200F_200B_206B_200E_202B_202C_206D_202C_202C_206B_200D_202E_202D_200B_206E_200E_202A_202E_202B_206D_202B_200D_202E
	{
		internal IntPtr L;
	}

	[CompilerGenerated]
	private sealed class _202C_202B_202D_202C_202E_202D_200B_202B_202E_200E_200D_202A_202A_206E_206C_202B_206F_200B_200C_202C_200D_200D_200B_206B_206A_200E_206E_206C_200F_202E_202C_200F_206A_200F_206D_200B_200D_202E_206F_206F_202E
	{
		internal LuaFunction func;

		internal _206D_206C_202E_200C_206A_202C_200C_206C_206F_200B_202E_206B_202C_202E_206E_206B_200E_206E_200F_200B_206B_200E_202B_202C_206D_202C_202C_206B_200D_202E_202D_200B_206E_200E_202A_202E_202B_206D_202B_200D_202E _202E_200B_206A_200E_202B_206F_200C_202E_206D_200E_206C_206C_202A_206C_200E_206C_200C_206B_202E_202C_200B_206F_202D_206C_206D_200B_206A_200D_206E_200F_206C_202C_200B_206C_200B_202C_206D_206F_200E_206C_202E;

		internal void _200C_206C_206E_206B_206A_202A_200D_202E_200C_202B_202C_202A_206A_206B_202D_206D_206C_206B_200D_200E_200B_200F_206E_206D_206F_206E_206B_202A_200F_202B_206C_200F_200E_202E_206F_206F_202C_200E_202B_206F_202E(GameObject P_0)
		{
			int oldTop = func.BeginPCall();
			LuaScriptMgr.Push(_202E_200B_206A_200E_202B_206F_200C_202E_206D_200E_206C_206C_202A_206C_200E_206C_200C_206B_202E_202C_200B_206F_202D_206C_206D_200B_206A_200D_206E_200F_206C_202C_200B_206C_200B_202C_206D_206F_200E_206C_202E.L, (Object)(object)P_0);
			func.PCall(oldTop, 1);
			while (true)
			{
				int num = -1282387236;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1033849633)) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
						goto IL_004d;
					case 2u:
						return;
					}
					break;
					IL_004d:
					func.EndPCall(oldTop);
					num = (int)((num2 * 1461135568) ^ 0x9E66246);
				}
			}
		}
	}

	private static Type classType = _202E_206C_202D_206C_206D_206D_206F_200C_206C_206A_200F_206D_202B_206C_206D_202B_200C_200D_206A_202E_202A_206D_206F_202D_206A_200C_206E_200D_202A_202B_200D_206A_206E_200F_206D_206B_202B_200E_202C_206E_202E(typeof(TestLuaDelegate).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[3]
		{
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2254933974u), _200C_200E_206B_206D_206B_206D_202D_202C_206D_202D_206D_200E_206A_206E_206D_202E_206C_200F_206E_206D_206A_206A_202C_202C_200D_202D_200D_206B_206A_200E_202B_206B_200F_206F_206F_206F_200C_200F_202B_202E),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(215375861u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3747390401u), Lua_Eq)
		};
		LuaField[] fields = new LuaField[1]
		{
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3620891191u), get_onClick, set_onClick)
		};
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3991266517u), _202E_206C_202D_206C_206D_206D_206F_200C_206C_206A_200F_206D_202B_206C_206D_202B_200C_200D_206A_202E_202A_206D_206F_202D_206A_200C_206E_200D_202A_202B_200D_206A_206E_200F_206D_206B_202B_200E_202C_206E_202E(typeof(TestLuaDelegate).TypeHandle), regs, fields, _202E_206C_202D_206C_206D_206D_206F_200C_206C_206A_200F_206D_202B_206C_206D_202B_200C_200D_206A_202E_202A_206D_206F_202D_206A_200C_206E_200D_202A_202B_200D_206A_206E_200F_206D_206B_202B_200E_202C_206E_202E(typeof(MonoBehaviour).TypeHandle));
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _200C_200E_206B_206D_206B_206D_202D_202C_206D_202D_206D_200E_206A_206E_206D_202E_206C_200F_206E_206D_206A_206A_202C_202C_200D_202D_200D_206B_206A_200E_202B_206B_200F_206F_206F_206F_200C_200F_202B_202E(IntPtr P_0)
	{
		LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2608642118u));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_onClick(IntPtr L)
	{
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		TestLuaDelegate testLuaDelegate = default(TestLuaDelegate);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1562568461;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -422292773)) % 9)
				{
				case 2u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3474186569u));
					num = ((int)num2 * -184873699) ^ -109405658;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(163992300u));
					num = -704667734;
					continue;
				case 5u:
					num = ((int)num2 * -613446213) ^ -5442311;
					continue;
				case 8u:
				{
					testLuaDelegate = (TestLuaDelegate)luaObject;
					int num5;
					int num6;
					if (_206F_206C_206F_206B_200C_200B_200F_202D_206C_200E_206A_200B_206E_200F_206A_200B_200E_206A_206F_202B_202B_206A_200F_206D_206A_206A_200B_200D_202B_200B_202E_206C_202C_206E_206D_206C_202B_202D_202D_200D_202E((Object)(object)testLuaDelegate, (Object)null))
					{
						num5 = 519306096;
						num6 = num5;
					}
					else
					{
						num5 = 1548391746;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 932396345);
					continue;
				}
				case 4u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 2079923103;
						num4 = num3;
					}
					else
					{
						num3 = 1762033538;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1142702735);
					continue;
				}
				case 7u:
					LuaScriptMgr.Push(L, (Delegate)testLuaDelegate.onClick);
					num = -1729037427;
					continue;
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1957771973) ^ -1321236935;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_onClick(IntPtr L)
	{
		_206D_206C_202E_200C_206A_202C_200C_206C_206F_200B_202E_206B_202C_202E_206E_206B_200E_206E_200F_200B_206B_200E_202B_202C_206D_202C_202C_206B_200D_202E_202D_200B_206E_200E_202A_202E_202B_206D_202B_200D_202E obj = new _206D_206C_202E_200C_206A_202C_200C_206C_206F_200B_202E_206B_202C_202E_206E_206B_200E_206E_200F_200B_206B_200E_202B_202C_206D_202C_202C_206B_200D_202E_202D_200B_206E_200E_202A_202E_202B_206D_202B_200D_202E();
		TestLuaDelegate testLuaDelegate = default(TestLuaDelegate);
		_202C_202B_202D_202C_202E_202D_200B_202B_202E_200E_200D_202A_202A_206E_206C_202B_206F_200B_200C_202C_200D_200D_200B_206B_206A_200E_206E_206C_200F_202E_202C_200F_206A_200F_206D_200B_200D_202E_206F_206F_202E obj2 = default(_202C_202B_202D_202C_202E_202D_200B_202B_202E_200E_200D_202A_202A_206E_206C_202B_206F_200B_200C_202C_200D_200D_200B_206B_206A_200E_206E_206C_200F_202E_202C_200F_206A_200F_206D_200B_200D_202E_206F_206F_202E);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 46765184;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x59FFBBDC)) % 15)
				{
				case 7u:
					break;
				case 13u:
					LuaDLL.luaL_error(obj.L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(163992300u));
					num = 2137756879;
					continue;
				case 2u:
					testLuaDelegate.onClick = obj2._200C_206C_206E_206B_206A_202A_200D_202E_200C_202B_202C_202A_206A_206B_202D_206D_206C_206B_200D_200E_200B_200F_206E_206D_206F_206E_206B_202A_200F_202B_206C_200F_200E_202E_206F_206F_202C_200E_202B_206F_202E;
					num = (int)((num2 * 1981979750) ^ 0x6095F1A2);
					continue;
				case 14u:
					obj.L = L;
					num = (int)((num2 * 982768053) ^ 0x4438B174);
					continue;
				case 11u:
					obj2 = new _202C_202B_202D_202C_202E_202D_200B_202B_202E_200E_200D_202A_202A_206E_206C_202B_206F_200B_200C_202C_200D_200D_200B_206B_206A_200E_206E_206C_200F_202E_202C_200F_206A_200F_206D_200B_200D_202E_206F_206F_202E();
					num = 186663029;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TFUNCTION)
					{
						num5 = -1230240608;
						num6 = num5;
					}
					else
					{
						num5 = -963063293;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1701394437);
					continue;
				}
				case 10u:
					LuaDLL.luaL_error(obj.L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1440863992u));
					num = ((int)num2 * -1501966395) ^ -1230241134;
					continue;
				case 6u:
					num = (int)(num2 * 530489597) ^ -464158328;
					continue;
				case 4u:
					testLuaDelegate.onClick = (TestLuaDelegate.VoidDelegate)LuaScriptMgr.GetNetObject(obj.L, 3, _202E_206C_202D_206C_206D_206D_206F_200C_206C_206A_200F_206D_202B_206C_206D_202B_200C_200D_206A_202E_202A_206D_206F_202D_206A_200C_206E_200D_202A_202B_200D_206A_206E_200F_206D_206B_202B_200E_202C_206E_202E(typeof(TestLuaDelegate.VoidDelegate).TypeHandle));
					num = ((int)num2 * -644727515) ^ 0x381485F4;
					continue;
				case 3u:
				{
					LuaTypes luaTypes2 = LuaDLL.lua_type(obj.L, 1);
					int num7;
					int num8;
					if (luaTypes2 == LuaTypes.LUA_TTABLE)
					{
						num7 = -606304647;
						num8 = num7;
					}
					else
					{
						num7 = -409424877;
						num8 = num7;
					}
					num = num7 ^ ((int)num2 * -1708888644);
					continue;
				}
				case 5u:
					obj2._202E_200B_206A_200E_202B_206F_200C_202E_206D_200E_206C_206C_202A_206C_200E_206C_200C_206B_202E_202C_200B_206F_202D_206C_206D_200B_206A_200D_206E_200F_206C_202C_200B_206C_200B_202C_206D_206F_200E_206C_202E = obj;
					obj2.func = LuaScriptMgr.ToLuaFunction(obj.L, 3);
					num = ((int)num2 * -491203814) ^ 0x3AC1A796;
					continue;
				case 12u:
					luaTypes = LuaDLL.lua_type(obj.L, 3);
					num = 528288859;
					continue;
				case 0u:
				{
					object luaObject = LuaScriptMgr.GetLuaObject(obj.L, 1);
					testLuaDelegate = (TestLuaDelegate)luaObject;
					int num3;
					int num4;
					if (!_206F_206C_206F_206B_200C_200B_200F_202D_206C_200E_206A_200B_206E_200F_206A_200B_200E_206A_206F_202B_202B_206A_200F_206D_206A_206A_200B_200D_202B_200B_202E_206C_202C_206E_206D_206C_202B_202D_202D_200D_202E((Object)(object)testLuaDelegate, (Object)null))
					{
						num3 = -1786586269;
						num4 = num3;
					}
					else
					{
						num3 = -485125575;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1208413069);
					continue;
				}
				case 9u:
					num = ((int)num2 * -533727001) ^ -1060084281;
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
		Object val2 = default(Object);
		bool b = default(bool);
		while (true)
		{
			int num = 1772027018;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x49A1349F)) % 5)
				{
				case 4u:
					break;
				case 1u:
				{
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 1);
					val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
					num = (int)((num2 * 274009045) ^ 0x635174E3);
					continue;
				}
				case 3u:
				{
					object luaObject = LuaScriptMgr.GetLuaObject(L, 2);
					Object val = (Object)((luaObject is Object) ? luaObject : null);
					b = _206F_206C_206F_206B_200C_200B_200F_202D_206C_200E_206A_200B_206E_200F_206A_200B_200E_206A_206F_202B_202B_206A_200F_206D_206A_206A_200B_200D_202B_200B_202E_206C_202C_206E_206D_206C_202B_202D_202D_200D_202E(val2, val);
					num = (int)((num2 * 519608783) ^ 0x1E56E11);
					continue;
				}
				case 0u:
					LuaScriptMgr.Push(L, b);
					num = ((int)num2 * -1788125260) ^ 0x707BDF64;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _202E_206C_202D_206C_206D_206D_206F_200C_206C_206A_200F_206D_202B_206C_206D_202B_200C_200D_206A_202E_202A_206D_206F_202D_206A_200C_206E_200D_202A_202B_200D_206A_206E_200F_206D_206B_202B_200E_202C_206E_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static bool _206F_206C_206F_206B_200C_200B_200F_202D_206C_200E_206A_200B_206E_200F_206A_200B_200E_206A_206F_202B_202B_206A_200F_206D_206A_206A_200B_200D_202B_200B_202E_206C_202C_206E_206D_206C_202B_202D_202D_200D_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}
}
