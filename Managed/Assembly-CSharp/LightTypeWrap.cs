using System;
using LuaInterface;
using UnityEngine;

public class LightTypeWrap
{
	private static LuaMethod[] enums = new LuaMethod[5]
	{
		new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(121812649u), GetSpot),
		new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(982432253u), GetDirectional),
		new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(827209129u), GetPoint),
		new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1599307955u), GetArea),
		new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2966529941u), IntToEnum)
	};

	public static void Register(IntPtr L)
	{
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2065465578u), _200D_202D_202A_200D_206C_200C_202C_206D_206D_202E_200E_202A_200C_206F_200B_206D_202C_200B_202D_202D_202D_202C_206E_202D_200F_200E_202D_202C_202A_206B_206C_202E_200D_206E_206B_200F_202C_200C_206E_206C_202E(typeof(LightType).TypeHandle), enums);
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetSpot(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(LightType)0);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetDirectional(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(LightType)1);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetPoint(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(LightType)2);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetArea(IntPtr L)
	{
		LuaScriptMgr.Push(L, (Enum)(object)(LightType)3);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int IntToEnum(IntPtr L)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		int num = (int)LuaDLL.lua_tonumber(L, 1);
		LightType val = (LightType)num;
		while (true)
		{
			int num2 = 354065982;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x44AEEB39)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_002d;
				default:
					return 1;
				}
				break;
				IL_002d:
				LuaScriptMgr.Push(L, (Enum)(object)val);
				num2 = ((int)num3 * -2136226575) ^ -1093546603;
			}
		}
	}

	static Type _200D_202D_202A_200D_206C_200C_202C_206D_206D_202E_200E_202A_200C_206F_200B_206D_202C_200B_202D_202D_202D_202C_206E_202D_200F_200E_202D_202C_202A_206B_206C_202E_200D_206E_206B_200F_202C_200C_206E_206C_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
