using System;
using LuaInterface;
using UnityEngine;

public class CameraClearFlagsWrap
{
	private static LuaMethod[] enums = new LuaMethod[6]
	{
		new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(438084223u), GetSkybox),
		new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1991708486u), GetColor),
		new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2704924428u), GetSolidColor),
		new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(376863869u), GetDepth),
		new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(686710767u), GetNothing),
		new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2966529941u), IntToEnum)
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1127446979u), _202A_206B_200B_206D_202D_202D_200C_200F_200E_206D_200B_202E_200C_206F_206D_206B_202E_202B_206B_202B_206F_200C_200D_202D_206E_206F_200F_200E_206E_206D_206F_202A_206B_202A_202D_206D_206F_202D_200B_202E_202E(typeof(CameraClearFlags).TypeHandle), enums);
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetSkybox(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(CameraClearFlags)1);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetColor(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(CameraClearFlags)2);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetSolidColor(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(CameraClearFlags)2);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetDepth(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(CameraClearFlags)3);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetNothing(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(CameraClearFlags)4);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int IntToEnum(IntPtr L)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		int num = (int)LuaDLL.lua_tonumber(L, 1);
		CameraClearFlags val = (CameraClearFlags)num;
		LuaScriptMgr.Push(L, (Enum)(object)val);
		return 1;
	}

	static Type _202A_206B_200B_206D_202D_202D_200C_200F_200E_206D_200B_202E_200C_206F_206D_206B_202E_202B_206B_202B_206F_200C_200D_202D_206E_206F_200F_200E_206E_206D_206F_202A_206B_202A_202D_206D_206F_202D_200B_202E_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
