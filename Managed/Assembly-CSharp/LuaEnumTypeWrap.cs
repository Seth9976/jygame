using System;
using LuaInterface;

public class LuaEnumTypeWrap
{
	private static LuaMethod[] enums = new LuaMethod[5]
	{
		new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3064174170u), GetAAA),
		new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3163201498u), GetBBB),
		new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(195916132u), GetCCC),
		new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(58049844u), GetDDD),
		new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2142259666u), IntToEnum)
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(349729141u), _202A_206D_206A_200C_206C_206B_200E_206C_200C_206D_206D_202C_202E_200D_200B_202B_206E_200D_206F_200C_202C_200B_202C_200E_202E_202E_206F_206A_206C_200D_206A_206F_206C_206E_200B_202A_202D_202A_202A_200E_202E(typeof(LuaEnumType).TypeHandle), enums);
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetAAA(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)LuaEnumType.AAA);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetBBB(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)LuaEnumType.BBB);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetCCC(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)LuaEnumType.CCC);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetDDD(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)LuaEnumType.DDD);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int IntToEnum(IntPtr L)
	{
		int num = (int)LuaDLL.lua_tonumber(L, 1);
		while (true)
		{
			int num2 = 1540035621;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x4F4DB784)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_002b;
				default:
					return 1;
				}
				break;
				IL_002b:
				LuaEnumType luaEnumType = (LuaEnumType)num;
				LuaScriptMgr.Push(L, (Enum)luaEnumType);
				num2 = ((int)num3 * -1184659948) ^ -703384265;
			}
		}
	}

	static Type _202A_206D_206A_200C_206C_206B_200E_206C_200C_206D_206D_202C_202E_200D_200B_202B_206E_200D_206F_200C_202C_200B_202C_200E_202E_202E_206F_206A_206C_200D_206A_206F_206C_206E_200B_202A_202D_202A_202A_200E_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
