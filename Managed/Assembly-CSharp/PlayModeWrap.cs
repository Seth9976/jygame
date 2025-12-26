using System;
using LuaInterface;
using UnityEngine;

public class PlayModeWrap
{
	private static LuaMethod[] enums = new LuaMethod[3]
	{
		new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1314451255u), GetStopSameLayer),
		new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(705649383u), GetStopAll),
		new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2966529941u), IntToEnum)
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(543584010u), _206F_202B_200F_206B_200D_206C_200E_200F_206D_202A_206E_200C_206B_202E_206E_202A_202E_206D_202C_202E_206D_202C_206D_200D_202C_200B_200D_206D_200D_202C_200B_206E_202D_200D_202D_206C_202D_200F_202A_206B_202E(typeof(PlayMode).TypeHandle), enums);
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetStopSameLayer(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(PlayMode)0);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetStopAll(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(PlayMode)4);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int IntToEnum(IntPtr L)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		int num = (int)LuaDLL.lua_tonumber(L, 1);
		PlayMode val = (PlayMode)num;
		LuaScriptMgr.Push(L, (Enum)(object)val);
		return 1;
	}

	static Type _206F_202B_200F_206B_200D_206C_200E_200F_206D_202A_206E_200C_206B_202E_206E_202A_202E_206D_202C_202E_206D_202C_206D_200D_202C_200B_200D_206D_200D_202C_200B_206E_202D_200D_202D_206C_202D_200F_202A_206B_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
