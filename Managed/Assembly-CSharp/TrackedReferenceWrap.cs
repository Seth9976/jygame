using System;
using LuaInterface;
using UnityEngine;

public class TrackedReferenceWrap
{
	private static Type classType = _200E_206D_206D_200B_206F_206A_202A_202E_202A_200C_202B_200F_206E_202C_202D_200B_206C_202D_202B_202E_202A_206A_206A_202A_206F_200B_206F_200C_206E_206D_206E_206F_206F_200C_200E_202D_202B_200C_202D_200F_202E(typeof(TrackedReference).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[5]
		{
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1721257428u), Equals),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1470604359u), GetHashCode),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1657282774u), _202A_202B_202A_200E_200D_206E_200D_202B_200F_200D_202E_200C_206F_200D_202B_200C_202B_206E_202B_200C_202B_200C_200D_206B_202E_200B_202D_202B_206E_202D_200E_200B_200C_206F_202A_200E_206D_202D_206E_200F_202E),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(10103728u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(60698966u), Lua_Eq)
		};
		LuaField[] fields = default(LuaField[]);
		while (true)
		{
			int num = -1895223731;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1003582998)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_00ec;
				default:
					LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(347360279u), _200E_206D_206D_200B_206F_206A_202A_202E_202A_200C_202B_200F_206E_202C_202D_200B_206C_202D_202B_202E_202A_206A_206A_202A_206F_200B_206F_200C_206E_206D_206E_206F_206F_200C_200E_202D_202B_200C_202D_200F_202E(typeof(TrackedReference).TypeHandle), regs, fields, _200E_206D_206D_200B_206F_206A_202A_202E_202A_200C_202B_200F_206E_202C_202D_200B_206C_202D_202B_202E_202A_206A_206A_202A_206F_200B_206F_200C_206E_206D_206E_206F_206F_200C_200E_202D_202B_200C_202D_200F_202E(typeof(object).TypeHandle));
					return;
				}
				break;
				IL_00ec:
				fields = new LuaField[0];
				num = (int)((num2 * 80614043) ^ 0xA2C6138);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _202A_202B_202A_200E_200D_206E_200D_202B_200F_200D_202E_200C_206F_200D_202B_200C_202B_206E_202B_200C_202B_200C_200D_206B_202E_200B_202D_202B_206E_202D_200E_200B_200C_206F_202A_200E_206D_202D_206E_200F_202E(IntPtr P_0)
	{
		LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2490956564u));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Equals(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		TrackedReference val = default(TrackedReference);
		object varObject = default(object);
		while (true)
		{
			int num = -1159893913;
			while (true)
			{
				uint num2;
				bool num3;
				bool b;
				switch ((num2 = (uint)(num ^ -1652830515)) % 4)
				{
				case 0u:
					break;
				case 2u:
				{
					object varObject2 = LuaScriptMgr.GetVarObject(L, 1);
					val = (TrackedReference)((varObject2 is TrackedReference) ? varObject2 : null);
					num = ((int)num2 * -1142589578) ^ -714242624;
					continue;
				}
				case 1u:
					varObject = LuaScriptMgr.GetVarObject(L, 2);
					if (_200B_206B_206A_206F_206B_206B_200C_206A_206F_206C_200D_206A_202C_206C_206B_206F_200B_200B_206E_200F_202A_200C_200E_202C_200F_200E_206D_206F_202E_206E_200C_200F_206C_202B_200F_206A_202A_206A_202D_202A_202E(val, (TrackedReference)null))
					{
						num = (int)(num2 * 1294832179) ^ -93105099;
						continue;
					}
					num3 = varObject == null;
					goto IL_0076;
				default:
					{
						num3 = _206D_206D_200B_202D_200C_200F_200E_206B_202C_202E_206D_200E_202E_200C_202E_202D_200C_206F_200F_202E_200D_206E_206E_206E_200E_206F_202B_206E_200F_202A_206F_200C_202C_206C_200F_200C_200F_200E_200C_206A_202E(val, varObject);
						goto IL_0076;
					}
					IL_0076:
					b = num3;
					LuaScriptMgr.Push(L, b);
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetHashCode(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		TrackedReference val = (TrackedReference)LuaScriptMgr.GetTrackedObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3111849060u));
		int d = _202C_200D_200F_206A_206B_202C_206C_206B_202B_202C_202E_200C_202B_202C_202E_206A_200E_206B_200E_202B_202E_200B_206D_200C_200E_206B_200E_202C_200F_200B_202D_206E_202E_202D_200C_202C_200F_200B_206C_202A_202E(val);
		LuaScriptMgr.Push(L, d);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		TrackedReference val = (TrackedReference)((luaObject is TrackedReference) ? luaObject : null);
		TrackedReference val2 = default(TrackedReference);
		while (true)
		{
			int num = -2027583092;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -441377222)) % 4)
				{
				case 0u:
					break;
				case 2u:
				{
					object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
					val2 = (TrackedReference)((luaObject2 is TrackedReference) ? luaObject2 : null);
					num = (int)(num2 * 702081506) ^ -1358980447;
					continue;
				}
				case 3u:
				{
					bool b = _206D_200B_206B_206E_206D_200C_206F_200F_202B_202E_200D_200C_202D_206A_202A_206A_202E_202D_206E_202C_202B_206F_200B_200F_202C_202C_202D_202C_200B_202A_200C_200F_202E_202D_206F_206C_206C_206F_200B_202A_202E(val, val2);
					LuaScriptMgr.Push(L, b);
					num = (int)(num2 * 1981311234) ^ -1396967839;
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	static Type _200E_206D_206D_200B_206F_206A_202A_202E_202A_200C_202B_200F_206E_202C_202D_200B_206C_202D_202B_202E_202A_206A_206A_202A_206F_200B_206F_200C_206E_206D_206E_206F_206F_200C_200E_202D_202B_200C_202D_200F_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static bool _200B_206B_206A_206F_206B_206B_200C_206A_206F_206C_200D_206A_202C_206C_206B_206F_200B_200B_206E_200F_202A_200C_200E_202C_200F_200E_206D_206F_202E_206E_200C_200F_206C_202B_200F_206A_202A_206A_202D_202A_202E(TrackedReference P_0, TrackedReference P_1)
	{
		return P_0 != P_1;
	}

	static bool _206D_206D_200B_202D_200C_200F_200E_206B_202C_202E_206D_200E_202E_200C_202E_202D_200C_206F_200F_202E_200D_206E_206E_206E_200E_206F_202B_206E_200F_202A_206F_200C_202C_206C_200F_200C_200F_200E_200C_206A_202E(TrackedReference P_0, object P_1)
	{
		return P_0.Equals(P_1);
	}

	static int _202C_200D_200F_206A_206B_202C_206C_206B_202B_202C_202E_200C_202B_202C_202E_206A_200E_206B_200E_202B_202E_200B_206D_200C_200E_206B_200E_202C_200F_200B_202D_206E_202E_202D_200C_202C_200F_200B_206C_202A_202E(TrackedReference P_0)
	{
		return P_0.GetHashCode();
	}

	static bool _206D_200B_206B_206E_206D_200C_206F_200F_202B_202E_200D_200C_202D_206A_202A_206A_202E_202D_206E_202C_202B_206F_200B_200F_202C_202C_202D_202C_200B_202A_200C_200F_202E_202D_206F_206C_206C_206F_200B_202A_202E(TrackedReference P_0, TrackedReference P_1)
	{
		return P_0 == P_1;
	}
}
