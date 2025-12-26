using System;
using LuaInterface;
using UnityEngine;

public class SpaceWrap
{
	private static LuaMethod[] enums = new LuaMethod[3]
	{
		new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(186622783u), GetWorld),
		new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(741054060u), GetSelf),
		new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2142259666u), IntToEnum)
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1154055024u), _200E_200C_206C_202A_206B_200B_202B_206A_202A_206F_206F_200E_200C_206D_202D_200B_202E_202B_206A_206C_202C_200D_200C_206A_206F_206E_206D_202D_206F_200B_200E_200B_206E_202B_206C_200B_200E_206E_202D_206F_202E(typeof(Space).TypeHandle), enums);
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetWorld(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(Space)0);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetSelf(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(Space)1);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int IntToEnum(IntPtr L)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		int num = (int)LuaDLL.lua_tonumber(L, 1);
		Space val = (Space)num;
		LuaScriptMgr.Push(L, (Enum)(object)val);
		return 1;
	}

	static Type _200E_200C_206C_202A_206B_200B_202B_206A_202A_206F_206F_200E_200C_206D_202D_200B_202E_202B_206A_206C_202C_200D_200C_206A_206F_206E_206D_202D_206F_200B_200E_200B_206E_202B_206C_200B_200E_206E_202D_206F_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
