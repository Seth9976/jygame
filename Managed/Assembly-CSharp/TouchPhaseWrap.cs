using System;
using LuaInterface;
using UnityEngine;

public class TouchPhaseWrap
{
	private static LuaMethod[] enums = new LuaMethod[6]
	{
		new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2643793070u), GetBegan),
		new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1783890052u), GetMoved),
		new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(593656020u), GetStationary),
		new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1670683573u), GetEnded),
		new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(942506731u), GetCanceled),
		new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3074161671u), IntToEnum)
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2313393947u), _206B_202B_206A_206E_206E_206C_200C_200F_202E_206A_206B_202C_206D_200D_200C_206E_202A_206C_202C_200E_206A_200E_202C_200B_200E_202D_206B_202C_200D_200C_202B_206B_206C_206D_200C_206F_200B_200F_202D_200D_202E(typeof(TouchPhase).TypeHandle), enums);
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetBegan(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(TouchPhase)0);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetMoved(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(TouchPhase)1);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetStationary(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(TouchPhase)2);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetEnded(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(TouchPhase)3);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetCanceled(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(TouchPhase)4);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int IntToEnum(IntPtr L)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		int num = (int)LuaDLL.lua_tonumber(L, 1);
		TouchPhase val = (TouchPhase)num;
		LuaScriptMgr.Push(L, (Enum)(object)val);
		return 1;
	}

	static Type _206B_202B_206A_206E_206E_206C_200C_200F_202E_206A_206B_202C_206D_200D_200C_206E_202A_206C_202C_200E_206A_200E_202C_200B_200E_202D_206B_202C_200D_200C_202B_206B_206C_206D_200C_206F_200B_200F_202D_200D_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
