using System;
using System.Runtime.CompilerServices;
using LuaInterface;
using UnityEngine;

public class TestDelegateListenerWrap
{
	[CompilerGenerated]
	private sealed class _206A_200F_206F_202E_206A_206C_202C_200B_202A_206D_200D_200E_202A_206E_206E_206D_202A_202A_206A_200C_206D_200C_202A_200C_206E_202A_202A_206A_206C_200F_202D_200E_200F_202C_202E_206E_200C_206D_206E_202E_202E
	{
		internal LuaFunction func;

		internal void _202B_206D_202B_200B_206D_206B_202C_202A_202B_200E_202C_202C_202C_206E_200C_206C_200D_206B_202A_206E_200D_206F_206F_206F_206A_200E_206C_206B_202C_200F_206E_202B_200F_200C_200B_206A_206C_200D_202A_202D_202E()
		{
			func.Call();
		}
	}

	[CompilerGenerated]
	private sealed class _202D_200F_202A_202C_202B_202B_200D_206F_206F_200D_202C_206F_202C_200E_206A_202D_200F_206D_206B_200C_200E_200E_200B_200F_200F_202D_206D_206D_206C_202A_202C_202B_206D_200B_202D_206C_206D_202B_206E_206D_202E
	{
		internal IntPtr L;
	}

	[CompilerGenerated]
	private sealed class _206A_202E_206A_200D_200F_202C_202B_206C_200F_206B_200C_200D_202C_206E_202C_206F_202B_202C_202A_206C_200D_202D_206F_200F_206F_200B_202C_202E_200E_200F_202A_200F_206B_202E_206D_202B_200C_202E_202A_206F_202E
	{
		internal LuaFunction func;

		internal _202D_200F_202A_202C_202B_202B_200D_206F_206F_200D_202C_206F_202C_200E_206A_202D_200F_206D_206B_200C_200E_200E_200B_200F_200F_202D_206D_206D_206C_202A_202C_202B_206D_200B_202D_206C_206D_202B_206E_206D_202E _202A_202A_206E_202B_202A_200C_202C_200F_200F_206A_206D_200F_202B_202D_206F_206B_206B_202E_200F_202D_202C_202A_202D_206F_202A_202C_206A_202E_206C_206C_202A_206D_202D_200D_200F_200D_206F_206B_200B_206E_202E;

		internal void _202E_200D_200E_200B_206D_200B_200E_200B_206B_206E_206B_200D_206D_200C_200B_202C_202A_200B_200F_206A_206C_206A_200E_206F_206E_200B_206A_200B_206D_200F_206B_206C_200F_206F_206F_206F_206F_202E_202D_206D_202E(GameObject P_0)
		{
			int oldTop = func.BeginPCall();
			while (true)
			{
				int num = 2007763318;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x4F144CF7)) % 4)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
						LuaScriptMgr.Push(_202A_202A_206E_202B_202A_200C_202C_200F_200F_206A_206D_200F_202B_202D_206F_206B_206B_202E_200F_202D_202C_202A_202D_206F_202A_202C_206A_202E_206C_206C_202A_206D_202D_200D_200F_200D_206F_206B_200B_206E_202E.L, (Object)(object)P_0);
						num = (int)((num2 * 1641960518) ^ 0x7D3EB567);
						continue;
					case 2u:
						func.PCall(oldTop, 1);
						func.EndPCall(oldTop);
						num = (int)((num2 * 1937560370) ^ 0x34C4FA54);
						continue;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	private static Type classType = _206F_200D_200F_206C_206E_200D_206B_202B_206E_206A_200F_200B_200D_206C_202D_206B_202A_202A_200D_200B_200E_206A_206C_206C_206C_202B_200D_200E_202E_202B_202C_202A_200D_206D_206B_202E_200D_206E_202C_206C_202E(typeof(TestDelegateListener).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[3]
		{
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1621874631u), _200F_202E_206C_206A_200F_200B_206D_200C_202D_206C_206D_200E_200E_206B_206B_202B_200D_200B_206B_206A_202C_206E_200C_202B_206A_202D_202C_200E_200D_206F_200B_206A_206D_200D_200B_206F_202D_202E_206A_202A_202E),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(215375861u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(60698966u), Lua_Eq)
		};
		LuaField[] fields = new LuaField[2]
		{
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3620891191u), get_onClick, set_onClick),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1602677530u), get_onEvClick, set_onEvClick)
		};
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4155102163u), _206F_200D_200F_206C_206E_200D_206B_202B_206E_206A_200F_200B_200D_206C_202D_206B_202A_202A_200D_200B_200E_206A_206C_206C_206C_202B_200D_200E_202E_202B_202C_202A_200D_206D_206B_202E_200D_206E_202C_206C_202E(typeof(TestDelegateListener).TypeHandle), regs, fields, _206F_200D_200F_206C_206E_200D_206B_202B_206E_206A_200F_200B_200D_206C_202D_206B_202A_202A_200D_200B_200E_206A_206C_206C_206C_202B_200D_200E_202E_202B_202C_202A_200D_206D_206B_202E_200D_206E_202C_206C_202E(typeof(MonoBehaviour).TypeHandle));
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _200F_202E_206C_206A_200F_200B_206D_200C_202D_206C_206D_200E_200E_206B_206B_202B_200D_200B_206B_206A_202C_206E_200C_202B_206A_202D_202C_200E_200D_206F_200B_206A_206D_200D_200B_206F_202D_202E_206A_202A_202E(IntPtr P_0)
	{
		LuaDLL.luaL_error(P_0, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2658685297u));
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
		TestDelegateListener testDelegateListener = default(TestDelegateListener);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1098038938;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x466E7CCB)) % 7)
				{
				case 6u:
					break;
				case 3u:
				{
					testDelegateListener = (TestDelegateListener)luaObject;
					int num5;
					int num6;
					if (!_202E_202E_200E_206D_200C_200F_206B_202B_206D_202C_200B_200C_202B_200B_200D_206D_200D_202A_206E_206A_202C_202E_202C_200D_206D_202A_206B_206F_206C_200B_206C_202C_200B_206F_206F_200F_202D_206A_200D_202D_202E((Object)(object)testDelegateListener, (Object)null))
					{
						num5 = 1565793473;
						num6 = num5;
					}
					else
					{
						num5 = 862804833;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1045891769);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1090982111u));
					num = ((int)num2 * -307058594) ^ -1348895008;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 690144360;
						num4 = num3;
					}
					else
					{
						num3 = 2053622365;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1439778830);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1742747936u));
					num = 1213035958;
					continue;
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1889510145) ^ 0x5734E95D;
					continue;
				default:
					LuaScriptMgr.Push(L, (Delegate)testDelegateListener.onClick);
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_onEvClick(IntPtr L)
	{
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		TestDelegateListener testDelegateListener = default(TestDelegateListener);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -892875286;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -65454692)) % 10)
				{
				case 0u:
					break;
				case 4u:
					testDelegateListener = (TestDelegateListener)luaObject;
					num = ((int)num2 * -619340036) ^ -866783386;
					continue;
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -440342818) ^ -1419269068;
					continue;
				case 9u:
					LuaScriptMgr.Push(L, (Delegate)testDelegateListener.onEvClick);
					num = -785212549;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(565215803u));
					num = (int)(num2 * 725405430) ^ -1543546267;
					continue;
				case 1u:
					num = (int)(num2 * 1088973134) ^ -883616503;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2453834483u));
					num = -465441105;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (!_202E_202E_200E_206D_200C_200F_206B_202B_206D_202C_200B_200C_202B_200B_200D_206D_200D_202A_206E_206A_202C_202E_202C_200D_206D_202A_206B_206F_206C_200B_206C_202C_200B_206F_206F_200F_202D_206A_200D_202D_202E((Object)(object)testDelegateListener, (Object)null))
					{
						num5 = 1992049417;
						num6 = num5;
					}
					else
					{
						num5 = 1242424157;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1842859739);
					continue;
				}
				case 6u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1355886794;
						num4 = num3;
					}
					else
					{
						num3 = -1931461761;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 996760188);
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
	private static int set_onClick(IntPtr L)
	{
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		_206A_200F_206F_202E_206A_206C_202C_200B_202A_206D_200D_200E_202A_206E_206E_206D_202A_202A_206A_200C_206D_200C_202A_200C_206E_202A_202A_206A_206C_200F_202D_200E_200F_202C_202E_206E_200C_206D_206E_202E_202E obj = default(_206A_200F_206F_202E_206A_206C_202C_200B_202A_206D_200D_200E_202A_206E_206E_206D_202A_202A_206A_200C_206D_200C_202A_200C_206E_202A_202A_206A_206C_200F_202D_200E_200F_202C_202E_206E_200C_206D_206E_202E_202E);
		TestDelegateListener testDelegateListener = default(TestDelegateListener);
		while (true)
		{
			int num = 239383593;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5CA60850)) % 12)
				{
				case 0u:
					break;
				case 1u:
				{
					LuaTypes luaTypes2 = LuaDLL.lua_type(L, 3);
					int num7;
					if (luaTypes2 != LuaTypes.LUA_TFUNCTION)
					{
						num = 1580782395;
						num7 = num;
					}
					else
					{
						num = 1255840466;
						num7 = num;
					}
					continue;
				}
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1346551727;
						num6 = num5;
					}
					else
					{
						num5 = 1430646586;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -654971009);
					continue;
				}
				case 9u:
					num = ((int)num2 * -921529151) ^ -426377188;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1742747936u));
					num = 1330339445;
					continue;
				case 2u:
					obj = new _206A_200F_206F_202E_206A_206C_202C_200B_202A_206D_200D_200E_202A_206E_206E_206D_202A_202A_206A_200C_206D_200C_202A_200C_206E_202A_202A_206A_206C_200F_202D_200E_200F_202C_202E_206E_200C_206D_206E_202E_202E();
					num = 1822030108;
					continue;
				case 3u:
					testDelegateListener.onClick = (Action)LuaScriptMgr.GetNetObject(L, 3, _206F_200D_200F_206C_206E_200D_206B_202B_206E_206A_200F_200B_200D_206C_202D_206B_202A_202A_200D_200B_200E_206A_206C_206C_206C_202B_200D_200E_202E_202B_202C_202A_200D_206D_206B_202E_200D_206E_202C_206C_202E(typeof(Action).TypeHandle));
					num = (int)((num2 * 674514505) ^ 0x1805EBFC);
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2038725230u));
					num = ((int)num2 * -2110959468) ^ 0x1DF74C1;
					continue;
				case 8u:
					obj.func = LuaScriptMgr.ToLuaFunction(L, 3);
					num = ((int)num2 * -980499506) ^ -1475690938;
					continue;
				case 5u:
				{
					testDelegateListener = (TestDelegateListener)luaObject;
					int num3;
					int num4;
					if (!_202E_202E_200E_206D_200C_200F_206B_202B_206D_202C_200B_200C_202B_200B_200D_206D_200D_202A_206E_206A_202C_202E_202C_200D_206D_202A_206B_206F_206C_200B_206C_202C_200B_206F_206F_200F_202D_206A_200D_202D_202E((Object)(object)testDelegateListener, (Object)null))
					{
						num3 = 1291427738;
						num4 = num3;
					}
					else
					{
						num3 = 2106223899;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 504792999);
					continue;
				}
				case 10u:
					testDelegateListener.onClick = obj._202B_206D_202B_200B_206D_206B_202C_202A_202B_200E_202C_202C_202C_206E_200C_206C_200D_206B_202A_206E_200D_206F_206F_206F_206A_200E_206C_206B_202C_200F_206E_202B_200F_200C_200B_206A_206C_200D_202A_202D_202E;
					num = (int)(num2 * 1401063721) ^ -498409327;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_onEvClick(IntPtr L)
	{
		_202D_200F_202A_202C_202B_202B_200D_206F_206F_200D_202C_206F_202C_200E_206A_202D_200F_206D_206B_200C_200E_200E_200B_200F_200F_202D_206D_206D_206C_202A_202C_202B_206D_200B_202D_206C_206D_202B_206E_206D_202E obj = new _202D_200F_202A_202C_202B_202B_200D_206F_206F_200D_202C_206F_202C_200E_206A_202D_200F_206D_206B_200C_200E_200E_200B_200F_200F_202D_206D_206D_206C_202A_202C_202B_206D_200B_202D_206C_206D_202B_206E_206D_202E();
		obj.L = L;
		TestDelegateListener testDelegateListener = default(TestDelegateListener);
		_206A_202E_206A_200D_200F_202C_202B_206C_200F_206B_200C_200D_202C_206E_202C_206F_202B_202C_202A_206C_200D_202D_206F_200F_206F_200B_202C_202E_200E_200F_202A_200F_206B_202E_206D_202B_200C_202E_202A_206F_202E obj2 = default(_206A_202E_206A_200D_200F_202C_202B_206C_200F_206B_200C_200D_202C_206E_202C_206F_202B_202C_202A_206C_200D_202D_206F_200F_206F_200B_202C_202E_200E_200F_202A_200F_206B_202E_206D_202B_200C_202E_202A_206F_202E);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 549317313;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7834EA60)) % 13)
				{
				case 0u:
					break;
				case 1u:
					LuaDLL.luaL_error(obj.L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(34642346u));
					num = 1008597059;
					continue;
				case 5u:
				{
					int num6;
					int num7;
					if (!_202E_202E_200E_206D_200C_200F_206B_202B_206D_202C_200B_200C_202B_200B_200D_206D_200D_202A_206E_206A_202C_202E_202C_200D_206D_202A_206B_206F_206C_200B_206C_202C_200B_206F_206F_200F_202D_206A_200D_202D_202E((Object)(object)testDelegateListener, (Object)null))
					{
						num6 = 1693133359;
						num7 = num6;
					}
					else
					{
						num6 = 660457989;
						num7 = num6;
					}
					num = num6 ^ ((int)num2 * -2047098278);
					continue;
				}
				case 10u:
				{
					object luaObject = LuaScriptMgr.GetLuaObject(obj.L, 1);
					testDelegateListener = (TestDelegateListener)luaObject;
					num = (int)((num2 * 252514949) ^ 0x39C3C0B);
					continue;
				}
				case 2u:
					obj2 = new _206A_202E_206A_200D_200F_202C_202B_206C_200F_206B_200C_200D_202C_206E_202C_206F_202B_202C_202A_206C_200D_202D_206F_200F_206F_200B_202C_202E_200E_200F_202A_200F_206B_202E_206D_202B_200C_202E_202A_206F_202E();
					num = 1770525874;
					continue;
				case 9u:
					obj2._202A_202A_206E_202B_202A_200C_202C_200F_200F_206A_206D_200F_202B_202D_206F_206B_206B_202E_200F_202D_202C_202A_202D_206F_202A_202C_206A_202E_206C_206C_202A_206D_202D_200D_200F_200D_206F_206B_200B_206E_202E = obj;
					obj2.func = LuaScriptMgr.ToLuaFunction(obj.L, 3);
					num = ((int)num2 * -579011776) ^ 0x6212EEDC;
					continue;
				case 4u:
					testDelegateListener.onEvClick = (TestLuaDelegate.VoidDelegate)LuaScriptMgr.GetNetObject(obj.L, 3, _206F_200D_200F_206C_206E_200D_206B_202B_206E_206A_200F_200B_200D_206C_202D_206B_202A_202A_200D_200B_200E_206A_206C_206C_206C_202B_200D_200E_202E_202B_202C_202A_200D_206D_206B_202E_200D_206E_202C_206C_202E(typeof(TestLuaDelegate.VoidDelegate).TypeHandle));
					num = ((int)num2 * -1305275822) ^ -2053199933;
					continue;
				case 7u:
					LuaDLL.luaL_error(obj.L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(565215803u));
					num = ((int)num2 * -902257506) ^ 0xF9E3C59;
					continue;
				case 11u:
				{
					LuaTypes luaTypes2 = LuaDLL.lua_type(obj.L, 3);
					int num5;
					if (luaTypes2 != LuaTypes.LUA_TFUNCTION)
					{
						num = 721214541;
						num5 = num;
					}
					else
					{
						num = 1921507031;
						num5 = num;
					}
					continue;
				}
				case 6u:
					luaTypes = LuaDLL.lua_type(obj.L, 1);
					num = ((int)num2 * -1787130169) ^ 0x52123154;
					continue;
				case 12u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1120704278;
						num4 = num3;
					}
					else
					{
						num3 = -535757682;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -683466725);
					continue;
				}
				case 3u:
					testDelegateListener.onEvClick = obj2._202E_200D_200E_200B_206D_200B_200E_200B_206B_206E_206B_200D_206D_200C_200B_202C_202A_200B_200F_206A_206C_206A_200E_206F_206E_200B_206A_200B_206D_200F_206B_206C_200F_206F_206F_206F_206F_202E_202D_206D_202E;
					num = ((int)num2 * -2098498274) ^ 0x54BCD4A1;
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
		Object val = default(Object);
		while (true)
		{
			int num = 1572054564;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2B08991)) % 5)
				{
				case 2u:
					break;
				case 1u:
				{
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 1);
					val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
					num = (int)(num2 * 496699560) ^ -1465189757;
					continue;
				}
				case 3u:
					b = _202E_202E_200E_206D_200C_200F_206B_202B_206D_202C_200B_200C_202B_200B_200D_206D_200D_202A_206E_206A_202C_202E_202C_200D_206D_202A_206B_206F_206C_200B_206C_202C_200B_206F_206F_200F_202D_206A_200D_202D_202E(val2, val);
					num = (int)(num2 * 176587428) ^ -2117560590;
					continue;
				case 0u:
				{
					object luaObject = LuaScriptMgr.GetLuaObject(L, 2);
					val = (Object)((luaObject is Object) ? luaObject : null);
					num = (int)((num2 * 811932153) ^ 0xB39E798);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, b);
					return 1;
				}
				break;
			}
		}
	}

	static Type _206F_200D_200F_206C_206E_200D_206B_202B_206E_206A_200F_200B_200D_206C_202D_206B_202A_202A_200D_200B_200E_206A_206C_206C_206C_202B_200D_200E_202E_202B_202C_202A_200D_206D_206B_202E_200D_206E_202C_206C_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static bool _202E_202E_200E_206D_200C_200F_206B_202B_206D_202C_200B_200C_202B_200B_200D_206D_200D_202A_206E_206A_202C_202E_202C_200D_206D_202A_206B_206F_206C_200B_206C_202C_200B_206F_206F_200F_202D_206A_200D_202D_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}
}
