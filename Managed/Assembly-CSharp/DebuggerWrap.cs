using System;
using LuaInterface;

public class DebuggerWrap
{
	private static Type classType = _206E_206C_200C_202D_202E_206C_206B_200E_200E_206E_206E_202C_200B_200C_202E_202D_200B_206F_200B_202E_206F_200B_202A_206A_202A_206F_206D_202D_200F_202D_206C_206A_202E_200C_200E_202C_202B_200E_200D_202D_202E(typeof(Debugger).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[5]
		{
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2560960481u), Log),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1697093029u), LogWarning),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(300084913u), LogError),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2705981273u), _206E_206F_202C_206F_200D_202E_206A_200C_200B_202E_200B_202D_206A_202C_200B_202A_202E_206A_206F_202D_206A_202E_206A_206A_206C_202B_200E_206F_200C_200F_202D_202E_206E_206A_200D_200D_206E_200B_202A_206C_202E),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2783592835u), GetClassType)
		};
		while (true)
		{
			int num = 990314864;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6FA970EB)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_00ec;
				case 0u:
					return;
				}
				break;
				IL_00ec:
				LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1291654443u), regs);
				num = (int)(num2 * 726571898) ^ -50879449;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _206E_206F_202C_206F_200D_202E_206A_200C_200B_202E_200B_202D_206A_202C_200B_202A_202E_206A_206F_202D_206A_202E_206A_206A_206C_202B_200E_206F_200C_200F_202D_202E_206E_206A_200D_200D_206E_200B_202A_206C_202E(IntPtr P_0)
	{
		LuaDLL.luaL_error(P_0, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3093087917u));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Log(IntPtr L)
	{
		int num = LuaDLL.lua_gettop(L);
		while (true)
		{
			int num2 = -676404655;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -12501473)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0029;
				default:
					return 0;
				}
				break;
				IL_0029:
				string luaString = LuaScriptMgr.GetLuaString(L, 1);
				object[] paramsObject = LuaScriptMgr.GetParamsObject(L, 2, num - 1);
				Debugger.Log(luaString, paramsObject);
				num2 = (int)((num3 * 574598464) ^ 0x6E829FF8);
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int LogWarning(IntPtr L)
	{
		int num = LuaDLL.lua_gettop(L);
		string luaString = default(string);
		object[] paramsObject = default(object[]);
		while (true)
		{
			int num2 = -1332195525;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -421384999)) % 4)
				{
				case 3u:
					break;
				case 2u:
					luaString = LuaScriptMgr.GetLuaString(L, 1);
					paramsObject = LuaScriptMgr.GetParamsObject(L, 2, num - 1);
					num2 = (int)((num3 * 638890405) ^ 0x60400E8A);
					continue;
				case 1u:
					Debugger.LogWarning(luaString, paramsObject);
					num2 = ((int)num3 * -1518509935) ^ 0x485ACEBC;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int LogError(IntPtr L)
	{
		int num = LuaDLL.lua_gettop(L);
		string luaString = default(string);
		object[] paramsObject = default(object[]);
		while (true)
		{
			int num2 = 267430900;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x3EF16E49)) % 5)
				{
				case 3u:
					break;
				case 1u:
					luaString = LuaScriptMgr.GetLuaString(L, 1);
					num2 = ((int)num3 * -1812684592) ^ -1610227649;
					continue;
				case 2u:
					paramsObject = LuaScriptMgr.GetParamsObject(L, 2, num - 1);
					num2 = ((int)num3 * -1995491843) ^ -2056838298;
					continue;
				case 4u:
					Debugger.LogError(luaString, paramsObject);
					num2 = (int)(num3 * 2131375854) ^ -1803829212;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	static Type _206E_206C_200C_202D_202E_206C_206B_200E_200E_206E_206E_202C_200B_200C_202E_202D_200B_206F_200B_202E_206F_200B_202A_206A_202A_206F_206D_202D_200F_202D_206C_206A_202E_200C_200E_202C_202B_200E_200D_202D_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
