using System;
using LuaInterface;
using UnityEngine;

public class AsyncOperationWrap
{
	private static Type classType = _206B_206D_200E_200E_202E_206A_206E_202C_206F_202A_206E_206D_200C_206F_202B_206E_200F_202C_200D_202A_202D_200E_206D_206C_206F_206C_206B_202B_200C_202C_206D_200B_206F_200B_200E_206E_200D_202D_202D_200D_202E(typeof(AsyncOperation).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[2]
		{
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1621874631u), _200B_202C_200B_200C_200E_202B_206A_200F_202A_206D_200F_206A_200E_202B_200F_206F_206B_200B_202D_200E_206A_202E_200F_206C_206F_206D_202A_200C_206A_206E_200C_206B_206B_202D_202E_200B_206F_202B_200B_202B_202E),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2783592835u), GetClassType)
		};
		LuaField[] fields = default(LuaField[]);
		while (true)
		{
			int num = -1194102146;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1784402816)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_007a;
				default:
					LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2565608606u), _206B_206D_200E_200E_202E_206A_206E_202C_206F_202A_206E_206D_200C_206F_202B_206E_200F_202C_200D_202A_202D_200E_206D_206C_206F_206C_206B_202B_200C_202C_206D_200B_206F_200B_200E_206E_200D_202D_202D_200D_202E(typeof(AsyncOperation).TypeHandle), regs, fields, _206B_206D_200E_200E_202E_206A_206E_202C_206F_202A_206E_206D_200C_206F_202B_206E_200F_202C_200D_202A_202D_200E_206D_206C_206F_206C_206B_202B_200C_202C_206D_200B_206F_200B_200E_206E_200D_202D_202D_200D_202E(typeof(object).TypeHandle));
					return;
				}
				break;
				IL_007a:
				fields = new LuaField[4]
				{
					new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2432576747u), get_isDone, null),
					new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(163671717u), get_progress, null),
					new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2440425352u), get_priority, set_priority),
					new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3545475753u), get_allowSceneActivation, set_allowSceneActivation)
				};
				num = (int)(num2 * 889738818) ^ -838294872;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _200B_202C_200B_200C_200E_202B_206A_200F_202A_206D_200F_206A_200E_202B_200F_206F_206B_200B_202D_200E_206A_202E_200F_206C_206F_206D_202A_200C_206A_206E_200C_206B_206B_202D_202E_200B_206F_202B_200B_202B_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		AsyncOperation o = default(AsyncOperation);
		while (true)
		{
			int num2 = 902128035;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x46B3702A)) % 6)
				{
				case 0u:
					break;
				case 2u:
					LuaScriptMgr.PushObject(P_0, o);
					num2 = (int)((num3 * 1029023420) ^ 0x1B86EA23);
					continue;
				case 1u:
					o = _202E_206F_206A_200E_200C_202B_206E_200E_202A_206D_206D_200B_202A_202B_206E_202A_206C_202D_206B_200C_200E_206F_200B_200F_202D_202A_206C_206A_200B_206C_202E_200C_206D_206C_202D_206B_202E_202A_206A_206C_202E();
					num2 = (int)((num3 * 1503988840) ^ 0x336C6B04);
					continue;
				case 5u:
					return 1;
				case 3u:
				{
					int num4;
					int num5;
					if (num == 0)
					{
						num4 = -45156755;
						num5 = num4;
					}
					else
					{
						num4 = -468344572;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 1953905114);
					continue;
				}
				default:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2602822716u));
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
	private static int get_isDone(IntPtr L)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AsyncOperation val = default(AsyncOperation);
		while (true)
		{
			int num = 468937643;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x246FFFA3)) % 7)
				{
				case 6u:
					break;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(959814221u));
					num = (int)(num2 * 78854042) ^ -1755231364;
					continue;
				case 1u:
					LuaScriptMgr.Push(L, _206B_202B_202C_200B_200D_202E_206A_206A_200F_202B_202E_200B_200D_206A_200D_202C_202C_202D_200F_202C_200E_200C_206A_206C_200E_202C_200E_202A_200D_206A_206D_202D_200B_206E_206A_206B_200C_206A_200E_206D_202E(val));
					num = 1952779707;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2027815746u));
					num = 1665446354;
					continue;
				case 2u:
				{
					val = (AsyncOperation)luaObject;
					int num5;
					int num6;
					if (val == null)
					{
						num5 = 1766412894;
						num6 = num5;
					}
					else
					{
						num5 = 1743289490;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 965277096);
					continue;
				}
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -819915609;
						num4 = num3;
					}
					else
					{
						num3 = -209083788;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1577808515);
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
	private static int get_progress(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AsyncOperation val = default(AsyncOperation);
		while (true)
		{
			int num = 242095288;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x60313241)) % 8)
				{
				case 4u:
					break;
				case 1u:
				{
					val = (AsyncOperation)luaObject;
					int num5;
					int num6;
					if (val != null)
					{
						num5 = 567001178;
						num6 = num5;
					}
					else
					{
						num5 = 1223827996;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -335251378);
					continue;
				}
				case 7u:
					num = ((int)num2 * -2104794665) ^ 0x6E69A77D;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1896442079u));
					num = 1122850692;
					continue;
				case 5u:
					LuaScriptMgr.Push(L, _206D_206C_206A_202A_206E_202D_206B_202A_202A_206F_200B_200B_202C_200B_206B_200D_202E_202B_200B_200D_200C_206E_200D_200D_200B_202E_200D_202C_200B_202E_200F_202E_206F_200E_202E_200F_200D_202B_206B_206D_202E(val));
					num = 1668155087;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2285828471u));
					num = (int)((num2 * 1298317438) ^ 0x608EBFEE);
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 212433066;
						num4 = num3;
					}
					else
					{
						num3 = 1659867800;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1603720563);
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
	private static int get_priority(IntPtr L)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AsyncOperation val = default(AsyncOperation);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1222943831;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1467169796)) % 9)
				{
				case 6u:
					break;
				case 8u:
					val = (AsyncOperation)luaObject;
					num = ((int)num2 * -2050619660) ^ 0x581ACB2;
					continue;
				case 0u:
				{
					int num5;
					int num6;
					if (val == null)
					{
						num5 = 283273660;
						num6 = num5;
					}
					else
					{
						num5 = 1832806858;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2103025925);
					continue;
				}
				case 5u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -261300588) ^ -121356410;
					continue;
				case 7u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 23944517;
						num4 = num3;
					}
					else
					{
						num3 = 1000504763;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -443297922);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(228936693u));
					num = (int)(num2 * 231868081) ^ -233915283;
					continue;
				case 4u:
					LuaScriptMgr.Push(L, _206D_202C_206B_206F_206D_200C_200F_206B_206C_200E_206E_206E_200B_202D_202E_202A_202E_206D_206F_206B_202B_206F_200C_200D_200B_206D_200E_206F_200C_206D_206A_206A_200F_202E_206C_206F_206B_202D_202E_206B_202E(val));
					num = -1326971024;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2383153723u));
					num = -103308616;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_allowSceneActivation(IntPtr L)
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		AsyncOperation val = default(AsyncOperation);
		while (true)
		{
			int num = -1360041571;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1909473625)) % 10)
				{
				case 0u:
					break;
				case 8u:
					num = (int)((num2 * 127934598) ^ 0x5E083358);
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1544226142;
						num6 = num5;
					}
					else
					{
						num5 = 1911381543;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1904909419);
					continue;
				}
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1894525130) ^ -321946082;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(606291623u));
					num = -109549356;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3412856027u));
					num = ((int)num2 * -1910502867) ^ -245029785;
					continue;
				case 2u:
					val = (AsyncOperation)luaObject;
					num = ((int)num2 * -604703305) ^ 0x129B4526;
					continue;
				case 5u:
					LuaScriptMgr.Push(L, _206C_200E_206C_202A_202D_206B_202D_200B_200D_200E_200D_206F_206C_202B_200E_200E_206F_206C_206C_202D_206E_202A_206C_202B_200D_202D_206C_200F_200C_200F_202B_202D_200D_206A_200D_206D_206D_206A_200C_206D_202E(val));
					num = -51601261;
					continue;
				case 9u:
				{
					int num3;
					int num4;
					if (val == null)
					{
						num3 = 1922044837;
						num4 = num3;
					}
					else
					{
						num3 = 1645300341;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 2006570023);
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
	private static int set_priority(IntPtr L)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		AsyncOperation val = default(AsyncOperation);
		while (true)
		{
			int num = 716793016;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2F21ED2D)) % 9)
				{
				case 8u:
					break;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1717336833u));
					num = (int)((num2 * 2002415805) ^ 0x18AF24FD);
					continue;
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -330354555) ^ 0x789ECE4D;
					continue;
				case 2u:
				{
					val = (AsyncOperation)luaObject;
					int num5;
					int num6;
					if (val == null)
					{
						num5 = -66593523;
						num6 = num5;
					}
					else
					{
						num5 = -506732293;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2023125715);
					continue;
				}
				case 6u:
					num = ((int)num2 * -787578863) ^ 0x1E99F8CC;
					continue;
				case 5u:
					_206F_200E_206D_202E_200D_200D_200E_206D_206A_206E_200E_206F_200E_200F_206B_206D_206F_202D_202D_200E_202E_202E_200F_200E_202E_202B_202B_202A_202E_202B_206D_202A_200D_200B_200C_206D_202C_206E_200F_202E_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
					num = 1902013152;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -76282995;
						num4 = num3;
					}
					else
					{
						num3 = -1265220650;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -353942855);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3609666780u));
					num = 511729460;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_allowSceneActivation(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AsyncOperation val = (AsyncOperation)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -422258980;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -947579877)) % 8)
				{
				case 0u:
					break;
				case 1u:
					num = (int)(num2 * 1784003589) ^ -1889271510;
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1477844642) ^ 0x4713463B;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2382496128u));
					num = ((int)num2 * -1866447685) ^ 0x36363C5D;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 953925844;
						num6 = num5;
					}
					else
					{
						num5 = 1229690039;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1838102757);
					continue;
				}
				case 7u:
				{
					int num3;
					int num4;
					if (val != null)
					{
						num3 = -778316159;
						num4 = num3;
					}
					else
					{
						num3 = -1487683690;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -686035030);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3012998710u));
					num = -256116825;
					continue;
				default:
					_202E_202D_200E_206A_206D_202A_202B_200C_202A_202A_202D_206E_206F_200F_206A_200B_206E_206B_200C_200F_200B_202B_206B_200E_206D_200E_206B_200F_200C_200E_206E_206A_206A_200E_202C_206E_206E_206B_206E_206B_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	static Type _206B_206D_200E_200E_202E_206A_206E_202C_206F_202A_206E_206D_200C_206F_202B_206E_200F_202C_200D_202A_202D_200E_206D_206C_206F_206C_206B_202B_200C_202C_206D_200B_206F_200B_200E_206E_200D_202D_202D_200D_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static AsyncOperation _202E_206F_206A_200E_200C_202B_206E_200E_202A_206D_206D_200B_202A_202B_206E_202A_206C_202D_206B_200C_200E_206F_200B_200F_202D_202A_206C_206A_200B_206C_202E_200C_206D_206C_202D_206B_202E_202A_206A_206C_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new AsyncOperation();
	}

	static bool _206B_202B_202C_200B_200D_202E_206A_206A_200F_202B_202E_200B_200D_206A_200D_202C_202C_202D_200F_202C_200E_200C_206A_206C_200E_202C_200E_202A_200D_206A_206D_202D_200B_206E_206A_206B_200C_206A_200E_206D_202E(AsyncOperation P_0)
	{
		return P_0.isDone;
	}

	static float _206D_206C_206A_202A_206E_202D_206B_202A_202A_206F_200B_200B_202C_200B_206B_200D_202E_202B_200B_200D_200C_206E_200D_200D_200B_202E_200D_202C_200B_202E_200F_202E_206F_200E_202E_200F_200D_202B_206B_206D_202E(AsyncOperation P_0)
	{
		return P_0.progress;
	}

	static int _206D_202C_206B_206F_206D_200C_200F_206B_206C_200E_206E_206E_200B_202D_202E_202A_202E_206D_206F_206B_202B_206F_200C_200D_200B_206D_200E_206F_200C_206D_206A_206A_200F_202E_206C_206F_206B_202D_202E_206B_202E(AsyncOperation P_0)
	{
		return P_0.priority;
	}

	static bool _206C_200E_206C_202A_202D_206B_202D_200B_200D_200E_200D_206F_206C_202B_200E_200E_206F_206C_206C_202D_206E_202A_206C_202B_200D_202D_206C_200F_200C_200F_202B_202D_200D_206A_200D_206D_206D_206A_200C_206D_202E(AsyncOperation P_0)
	{
		return P_0.allowSceneActivation;
	}

	static void _206F_200E_206D_202E_200D_200D_200E_206D_206A_206E_200E_206F_200E_200F_206B_206D_206F_202D_202D_200E_202E_202E_200F_200E_202E_202B_202B_202A_202E_202B_206D_202A_200D_200B_200C_206D_202C_206E_200F_202E_202E(AsyncOperation P_0, int P_1)
	{
		P_0.priority = P_1;
	}

	static void _202E_202D_200E_206A_206D_202A_202B_200C_202A_202A_202D_206E_206F_200F_206A_200B_206E_206B_200C_200F_200B_202B_206B_200E_206D_200E_206B_200F_200C_200E_206E_206A_206A_200E_202C_206E_206E_206B_206E_206B_202E(AsyncOperation P_0, bool P_1)
	{
		P_0.allowSceneActivation = P_1;
	}
}
